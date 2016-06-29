using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using GlmSharpGenerator.Members;

namespace GlmSharpGenerator.Types
{
    class MatrixType : AbstractType
    {
        public MatrixType(BuiltinType type, int cols, int rows)
        {
            Columns = cols;
            Rows = rows;
            BaseType = type;
            BaseName = type.Prefix + "mat";
        }

        public int Rows { get; set; }
        public int Columns { get; set; }
        public int FieldCount => Rows * Columns;
        public override string DataContractArg { get; } = "(Namespace = \"mat\")";

        public override string Name => BaseName + (Rows == Columns ? Columns.ToString() : Columns + "x" + Rows);

        public override string Folder => "Mat" + Columns + "x" + Rows;

        public override string TypeComment => $"A matrix of type {BaseTypeName} with {Columns} columns and {Rows} rows.";

        public bool HasField(string f) => ColOf(f) < Columns && RowOf(f) < Rows;

        public override IEnumerable<string> BaseClasses
        {
            get
            {
                if (Version >= 45)
                    yield return $"IReadOnlyList<{BaseTypeName}>";
                else
                    yield return $"IEnumerable<{BaseTypeName}>";
                yield return $"IEquatable<{NameThat}>";
            }
        }

        public static string[,] HelperFieldsOf(int s)
        {
            var f = new string[s, s];
            for (var x = 0; x < s; ++x)
                for (var y = 0; y < s; ++y)
                    f[x, y] = "m" + x + y;
            return f;
        }

        public static string[,] HelperSubmatrix(string[,] old, int tx, int ty)
        {
            var s = old.GetLength(0) - 1;
            var f = new string[s, s];
            for (var x = 0; x < s; ++x)
                for (var y = 0; y < s; ++y)
                    f[x, y] = old[x + (x >= tx ? 1 : 0), y + (y >= ty ? 1 : 0)];
            return f;
        }

        public static string HelperDet(string[,] f, int initialSign = 0)
        {
            var s = f.GetLength(0);
            if (s == 1)
                return (initialSign % 2 == 1 ? "-" : "") + f[0, 0];
            if (s <= 2)
                return (initialSign % 2 == 1 ? "-" : "") + string.Format("{0} * {1} {4} {2} * {3}", f[0, 0], f[1, 1], f[1, 0], f[0, 1], initialSign % 2 == 0 ? "-" : "+");

            var res = initialSign % 2 == 1 ? "-" : "";
            for (var i = 0; i < s; ++i)
            {
                if (res.Length > 1)
                    res += (i + initialSign) % 2 == 1 ? " - " : " + ";
                res += f[i, 0] + " * (" + HelperDet(HelperSubmatrix(f, i, 0)) + ")";
            }

            return res;
        }
        public string ClassNameTransposed => BaseName + (Rows == Columns ? Columns.ToString() : Rows + "x" + Columns) + GenericSuffix;

        public IEnumerable<string> Fields
        {
            get
            {
                for (var x = 0; x < Columns; ++x)
                    for (var y = 0; y < Rows; ++y)
                        yield return "m" + x + y;
            }
        }
        public IEnumerable<string> FieldsTransposed
        {
            get
            {
                for (var y = 0; y < Rows; ++y)
                    for (var x = 0; x < Columns; ++x)
                        yield return "m" + x + y;
            }
        }
        public IEnumerable<string> Column(int col)
        {
            for (var y = 0; y < Rows; ++y)
                yield return "m" + col + y;
        }
        public IEnumerable<string> Row(int row)
        {
            for (var x = 0; x < Columns; ++x)
                yield return "m" + x + row;
        }

        public string FieldFor(int f) => $"m{f/Rows}{f%Rows}";

        public string ArgOf(int c) => "xyzw"[c].ToString();

        public int RowOf(string fieldName) => fieldName[2] - '0';
        public int ColOf(string fieldName) => fieldName[1] - '0';

        public bool IsDiagonal(string fieldName) => fieldName[1] == fieldName[2];

        public string ColumnType => BaseType.Prefix + "vec" + Rows + GenericSuffix;
        public string RowType => BaseType.Prefix + "vec" + Columns + GenericSuffix;

        private IEnumerable<string> Constructor(string comment, string args, IEnumerable<string> assignments)
        {
            foreach (var line in comment.AsComment())
                yield return line;
            yield return $"public {Name}({args})";
            yield return "{";
            var it = assignments.GetEnumerator();
            foreach (var c in Fields)
                yield return $"this.{c} = {(it.MoveNext() ? it.Current : (c[1] == c[2] ? BaseType.OneValue : BaseType.ZeroValue))};".Indent();
            yield return "}";
        }

        public string HashCodeFor(int c) => (c == 0 ? "" : $"(({HashCodeFor(c - 1)}) * {BaseType.HashCodeMultiplier}) ^ ") + HashCodeOf(FieldFor(c));


        public string ComponentWiseOperator(string op)
            => string.Format("public static {0} operator{2}({0} lhs, {0} rhs) => new {0}({1});", NameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op);

        public string ComponentWiseOperator(string op, string internalOp)
            => string.Format("public static {0} operator{2}({0} lhs, {0} rhs) => new {0}({1});", NameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, internalOp)).CommaSeparated(), op);

        public string ComponentWiseOperatorScalar(string op, string scalarType)
            => string.Format("public static {0} operator{2}({0} lhs, {3} rhs) => new {0}({1});", NameThat,
                    Fields.Select(c => $"lhs.{c} {op} rhs").CommaSeparated(), op, scalarType);

        public string ComponentWiseOperatorScalarL(string op, string scalarType)
            => string.Format("public static {0} operator{2}({3} lhs, {0} rhs) => new {0}({1});", NameThat,
                    Fields.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, scalarType);

        public string ComponentWiseOperatorForeign(string op, string returnType)
            => string.Format("public static {3} operator{2}({0} lhs, {3} rhs) => new {3}({1});", NameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, returnType);
        public string ComponentWiseOperatorForeignL(string op, string returnType)
            => string.Format("public static {3} operator{2}({3} lhs, {0} rhs) => new {3}({1});", NameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, returnType);

        public string ComponentWiseOperatorForeignScalar(string op, string scalarType, string returnType)
            => string.Format("public static {4} operator{2}({0} lhs, {3} rhs) => new {4}({1});", NameThat,
                    Fields.Select(c => $"lhs.{c} {op} rhs").CommaSeparated(), op, scalarType, returnType);

        public string ComponentWiseOperatorForeignScalarL(string op, string scalarType, string returnType)
            => string.Format("public static {4} operator{2}({3} lhs, {0} rhs) => new {4}({1});", NameThat,
                    Fields.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, scalarType, returnType);

        public string ComparisonOperator(string op)
            => string.Format("public static bmat{3} operator{2}({0} lhs, {0} rhs) => new bmat{3}({1});", NameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, (Rows == Columns ? Columns.ToString() : Columns + "x" + Rows));

        public string ComparisonOperatorScalar(string op, string scalarType)
            => string.Format("public static bmat{3} operator{2}({0} lhs, {4} rhs) => new bmat{3}({1});", NameThat,
                    Fields.Select(c => $"lhs.{c} {op} rhs").CommaSeparated(), op, (Rows == Columns ? Columns.ToString() : Columns + "x" + Rows), scalarType);

        public string ComparisonOperatorScalarL(string op, string scalarType)
            => string.Format("public static bmat{3} operator{2}({4} lhs, {0} rhs) => new bmat{3}({1});", NameThat,
                    Fields.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, (Rows == Columns ? Columns.ToString() : Columns + "x" + Rows), scalarType);

        public string NestedBiFuncFor(string format, int c, Func<int, string> argOf) => c == 0 ? argOf(c) : string.Format(format, NestedBiFuncFor(format, c - 1, argOf), argOf(c));

        public IEnumerable<string> FieldsHelper(int cols, int rows)
        {
            for (var x = 0; x < cols; ++x)
                for (var y = 0; y < rows; ++y)
                    yield return "m" + x + y;
        }

        public override IEnumerable<Member> GenerateMembers()
        {
            var colVecType = new VectorType(BaseType, Rows);
            var rowVecType = new VectorType(BaseType, Columns);
            var quatType = new QuaternionType(BaseType);
            var diagonal = Rows == Columns;

            // fields
            foreach (var f in Fields)
                yield return new Field(f, BaseType)
                {
                    Comment = $"Column {ColOf(f)}, Rows {RowOf(f)}"
                };

            // Values
            yield return new Property("Values", new ArrayType(BaseType, "[,]"))
            {
                GetterLine = $"new[,] {{ {Columns.ForIndexUpTo(col => "{ " + Column(col).CommaSeparated() + " }").CommaSeparated()} }}",
                Comment = "Creates a 2D array with all values (address: Values[x, y])"
            };
            yield return new Property("Values1D", new ArrayType(BaseType))
            {
                GetterLine = $"new[] {{ {Fields.CommaSeparated()} }}",
                Comment = "Creates a 1D array with all values (internal order)"
            };

            // Columns
            for (var col = 0; col < Columns; ++col)
                yield return new Property("Column" + col, colVecType)
                {
                    GetterLine = $"return {Construct(colVecType, Column(col))};",
                    Setter = Column(col).Select((f,i) => $"{f} = value.{ArgOf(i)};"),
                    Comment = $"Gets or sets the column nr {col}"
                };
            // Rows
            for (var row = 0; row < Rows; ++row)
                yield return new Property("Row" + row, rowVecType)
                {
                    GetterLine = $"return {Construct(rowVecType, Row(row))};",
                    Setter = Row(row).Select((f,i) => $"{f} = value.{ArgOf(i)};"),
                    Comment = $"Gets or sets the row nr {row}"
                };

            // Constructors
            yield return new Constructor(this, Fields)
            {
                Parameters = Fields.TypedArgs(BaseType),
                Initializers = Fields,
                Comment = "Component-wise constructor"
            };
            // by-mat-ctors
            for (var rows = 2; rows <= 4; ++rows)
                for (var cols = 2; cols <= 4; ++cols)
                {
                    var matType = new MatrixType(BaseType, cols, rows);
                    yield return new Constructor(this, Fields)
                    {
                        Parameters = matType.TypedArgs("m"),
                        Initializers = Fields.Select(f => matType.HasField(f) ? "m." + f : IsDiagonal(f) && !string.IsNullOrEmpty(OneValue) ? OneValue : ZeroValue),
                        Comment = $"Constructs this matrix from a {matType.Name}. Non-overwritten fields are from an Identity matrix."
                    };
                }
            // by-column-vector-ctors
            for (var rows = 2; rows <= Rows; ++rows)
                for (var cols = 2; cols <= Columns; ++cols)
                {
                    var vecType = new VectorType(BaseType, rows);
                    var matType = new MatrixType(BaseType, cols, rows);
                    yield return new Constructor(this, Fields)
                    {
                        Parameters = vecType.TypedArgs(cols.ForIndexUpTo(c => "c" + c)),
                        Initializers = Fields.Select(f => matType.HasField(f) ? "c" + f[1] + "." + ArgOf(RowOf(f)) : IsDiagonal(f) && !string.IsNullOrEmpty(OneValue) ? OneValue : ZeroValue),
                        Comment = string.Format("Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.")
                    };
                }
            // to or from quaternion
            if (BaseType.IsFloatingPoint && Rows == Columns && Rows >= 3)
            {
                yield return new Constructor(this, Fields)
                {
                    Parameters = quatType.TypedArgs(" q"),
                    ConstructorChain = $"this(q.ToMat{Rows})",
                    Comment = $"Creates a rotation matrix from a {quatType.Name}."
                };

                yield return new ExplicitOperator(this)
                {
                    Parameters = quatType.TypedArgs(" q"),
                    CodeString = $"q.ToMat{Rows}",
                    Comment = $"Creates a rotation matrix from a {quatType.Name}."
                };

                yield return new Property("ToQuaternion", quatType)
                {
                    GetterLine = quatType.Name + ".FromMat" + Rows + "(this)",
                    Comment = "Creates a quaternion from the rotational part of this matrix."
                };
            }

            // predefs
            yield return new StaticProperty("Zero", this)
            {
                Value = Construct(this, ZeroValue.RepeatTimes(FieldCount)),
                Comment = "Predefined all-zero matrix"
            };

            if (!string.IsNullOrEmpty(BaseType.OneValue))
            {
                yield return new StaticProperty("Ones", this)
                {
                    Value = Construct(this, OneValue.RepeatTimes(FieldCount)),
                    Comment = "Predefined all-ones matrix"
                };

                yield return new StaticProperty("Identity", this)
                {
                    Value = Construct(this, Fields.Select(f => IsDiagonal(f) ? OneValue : ZeroValue)),
                    Comment = "Predefined identity matrix"
                };
            }

            if (BaseType.IsComplex)
            {
                yield return new StaticProperty("ImaginaryOnes", this)
                {
                    Value = Construct(this, "Complex.ImaginaryOne".RepeatTimes(FieldCount)),
                    Comment = "Predefined all-imaginary-ones matrix"
                };

                yield return new StaticProperty("ImaginaryIdentity", this)
                {
                    Value = Construct(this, Fields.Select(f => IsDiagonal(f) ? "Complex.ImaginaryOne" : ZeroValue)),
                    Comment = string.Format("Predefined diagonal-imaginary-one matrix")
                };
            }

            // Basetype constants
            foreach (var constant in BaseType.TypeConstants)
            {
                yield return new StaticProperty("All" + constant, this)
                {
                    Value = Construct(this, $"{BaseTypeName}.{constant}".RepeatTimes(FieldCount)),
                    Comment = $"Predefined all-{constant} matrix"
                };

                yield return new StaticProperty("Diagonal" + constant, this)
                {
                    Value = Construct(this, Fields.Select(f => IsDiagonal(f) ? $"{BaseTypeName}.{constant}" : ZeroValue)),
                    Comment = $"Predefined diagonal-{constant} matrix"
                };
            }


            // IEnumerable
            yield return new Function(new AnyType($"IEnumerator<{BaseTypeName}>"), "GetEnumerator")
            {
                Code = Fields.Select(f => $"yield return {f};"),
                Comment = "Returns an enumerator that iterates through all fields."
            };

            yield return new Function(new AnyType("IEnumerator"), "IEnumerable.GetEnumerator")
            {
                Visibility = "",
                CodeString = "GetEnumerator()",
                Comment = "Returns an enumerator that iterates through all fields."
            };
        }

        protected override IEnumerable<string> Body
        {
            get
            {

                // Indexer
                foreach (var line in $"Returns the number of Fields ({Columns} x {Rows} = {FieldCount}).".AsComment()) yield return line;
                yield return $"public int Count => {FieldCount};";

                foreach (var line in "Gets/Sets a specific indexed component (a bit slower than direct access).".AsComment()) yield return line;
                yield return $"public {BaseTypeName} this[int fieldIndex]";
                yield return "{";
                yield return "    get";
                yield return "    {";
                yield return "        switch (fieldIndex)";
                yield return "        {";
                for (var c = 0; c < FieldCount; ++c)
                    yield return $"            case {c}: return {FieldFor(c)};";
                yield return "            default: throw new ArgumentOutOfRangeException(\"fieldIndex\");";
                yield return "        }";
                yield return "    }";
                yield return "    set";
                yield return "    {";
                yield return "        switch (fieldIndex)";
                yield return "        {";
                for (var c = 0; c < FieldCount; ++c)
                    yield return $"            case {c}: this.{FieldFor(c)} = value; break;";
                yield return "            default: throw new ArgumentOutOfRangeException(\"fieldIndex\");";
                yield return "        }";
                yield return "    }";
                yield return "}";

                foreach (var line in "Gets/Sets a specific 2D-indexed component (a bit slower than direct access).".AsComment()) yield return line;
                yield return $"public {BaseTypeName} this[int col, int row]";
                yield return "{";
                yield return "    get";
                yield return "    {";
                yield return $"        return this[col * {Rows} + row];";
                yield return "    }";
                yield return "    set";
                yield return "    {";
                yield return $"        this[col * {Rows} + row] = value;";
                yield return "    }";
                yield return "}";


                // Equality comparisons
                foreach (var line in "Returns true iff this equals rhs component-wise.".AsComment()) yield return line;
                yield return $"public bool Equals({NameThat} rhs) => {Fields.Select(c => Comparer(c.ToString())).Aggregated(" && ")};";

                foreach (var line in "Returns true iff this equals rhs type- and component-wise.".AsComment()) yield return line;
                yield return "public override bool Equals(object obj)";
                yield return "{";
                yield return "    if (ReferenceEquals(null, obj)) return false;";
                yield return string.Format("    return obj is {0} && Equals(({0}) obj);", NameThat);
                yield return "}";

                foreach (var line in "Returns true iff this equals rhs component-wise.".AsComment()) yield return line;
                yield return string.Format("public static bool operator ==({0} lhs, {0} rhs) => lhs.Equals(rhs);", NameThat);

                foreach (var line in "Returns true iff this does not equal rhs (component-wise).".AsComment()) yield return line;
                yield return string.Format("public static bool operator !=({0} lhs, {0} rhs) => !lhs.Equals(rhs);", NameThat);

                foreach (var line in "Returns a hash code for this instance.".AsComment()) yield return line;
                yield return "public override int GetHashCode()";
                yield return "{";
                yield return "    unchecked";
                yield return "    {";
                yield return "        return " + HashCodeFor(FieldCount - 1) + ";";
                yield return "    }";
                yield return "}";


                // Transposed
                foreach (var line in "Returns a transposed version of this matrix.".AsComment()) yield return line;
                yield return string.Format("public {0} Transposed => new {0}({1});", ClassNameTransposed, FieldsTransposed.CommaSeparated());


                // Logicals
                if (BaseType.IsBool)
                {
                    foreach (var line in "Returns the minimal component of this matrix.".AsComment()) yield return line;
                    yield return $"public {BaseTypeName} MinElement => {Fields.Aggregated(" && ")};";

                    foreach (var line in "Returns the maximal component of this matrix.".AsComment()) yield return line;
                    yield return $"public {BaseTypeName} MaxElement => {Fields.Aggregated(" || ")};";

                    foreach (var line in "Returns true if all component are true.".AsComment()) yield return line;
                    yield return $"public {BaseTypeName} All => {Fields.Aggregated(" && ")};";

                    foreach (var line in "Returns true if any component is true.".AsComment()) yield return line;
                    yield return $"public {BaseTypeName} Any => {Fields.Aggregated(" || ")};";

                    foreach (var line in "Executes a component-wise &amp;&amp;. (sorry for different overload but &amp;&amp; cannot be overloaded directly)".AsComment()) yield return line;
                    yield return ComponentWiseOperator("&", "&&");

                    foreach (var line in "Executes a component-wise ||. (sorry for different overload but || cannot be overloaded directly)".AsComment()) yield return line;
                    yield return ComponentWiseOperator("|", "||");
                }


                // Arithmetics
                if (BaseType.HasArithmetics)
                {
                    var lengthType = BaseType.LengthType;

                    if (!BaseType.IsComplex)
                    {
                        foreach (var line in "Returns the minimal component of this matrix.".AsComment()) yield return line;
                        yield return $"public {BaseTypeName} MinElement => {NestedBiFuncFor(MathClass + ".Min({0}, {1})", FieldCount - 1, FieldFor)};";

                        foreach (var line in "Returns the maximal component of this matrix.".AsComment()) yield return line;
                        yield return $"public {BaseTypeName} MaxElement => {NestedBiFuncFor(MathClass + ".Max({0}, {1})", FieldCount - 1, FieldFor)};";
                    }

                    foreach (var line in "Returns the euclidean length of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} Length => ({0}){1};", lengthType, SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the squared euclidean length of this matrix.".AsComment()) yield return line;
                    yield return $"public {lengthType} LengthSqr => {Fields.Select(SqrOf).Aggregated(" + ")};";

                    foreach (var line in "Returns the sum of all fields.".AsComment()) yield return line;
                    yield return $"public {BaseTypeName} Sum => {Fields.Aggregated(" + ")};";

                    foreach (var line in "Returns the euclidean norm of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm => ({0}){1};", lengthType, SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the one-norm of this matrix.".AsComment()) yield return line;
                    yield return $"public {lengthType} Norm1 => {Fields.Select(AbsString).Aggregated(" + ")};";

                    foreach (var line in "Returns the two-norm of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm2 => ({0}){1};", lengthType, SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the max-norm of this matrix.".AsComment()) yield return line;
                    yield return $"public {BaseTypeName} NormMax => {NestedBiFuncFor(MathClass + ".Max({0}, {1})", FieldCount - 1, c => AbsString(FieldFor(c)))};";

                    foreach (var line in "Returns the p-norm of this matrix.".AsComment()) yield return line;
                    yield return $"public double NormP(double p) => Math.Pow({Fields.Select(c => $"Math.Pow((double){AbsString(c)}, p)").Aggregated(" + ")}, 1 / p);";

                    // determinant
                    if (Rows == Columns)
                    {
                        foreach (var line in "Returns determinant of this matrix.".AsComment()) yield return line;
                        yield return $"public {BaseTypeName} Determinant => {HelperDet(HelperFieldsOf(Rows))};";

                        if (BaseType.IsSigned)
                        {
                            foreach (var line in "Returns the adjunct of this matrix.".AsComment()) yield return line;
                            yield return string.Format("public {0} Adjugate => new {0}({1});", NameThat, FieldsTransposed.Select(f => HelperDet(HelperSubmatrix(HelperFieldsOf(Rows), ColOf(f), RowOf(f)), ColOf(f) + RowOf(f))).CommaSeparated());

                            foreach (var line in "Returns the inverse of this matrix (use with caution).".AsComment()) yield return line;
                            yield return $"public {NameThat} Inverse => Adjugate / Determinant;";
                        }
                    }

                    // matrix-matrix-multiplication
                    for (var rcols = 2; rcols <= 4; ++rcols)
                    {
                        var lhsRows = Rows;
                        var lhsCols = Columns;
                        var rhsRows = Columns;
                        var rhsColumns = rcols;
                        var rhsType = BaseName + (rhsRows == rhsColumns ? rhsColumns.ToString() : rhsColumns + "x" + rhsRows) + GenericSuffix;
                        var resultType = BaseName + (lhsRows == rhsColumns ? rhsColumns.ToString() : rhsColumns + "x" + lhsRows) + GenericSuffix;
                        foreach (var line in $"Executes a matrix-matrix-multiplication {NameThat} * {rhsType} -> {resultType}.".AsComment()) yield return line;
                        yield return string.Format("public static {0} operator*({1} lhs, {2} rhs) => new {0}({3});",
                            resultType, NameThat, rhsType,
                            FieldsHelper(rhsColumns, lhsRows).Select(f => lhsCols.ForIndexUpTo(i => string.Format("lhs.m{1}{2} * rhs.m{0}{1}", f[1], i, f[2])).Aggregated(" + ")).CommaSeparated());
                    }

                    // matrix-vector-multiplication
                    foreach (var line in "Executes a matrix-vector-multiplication.".AsComment()) yield return line;
                    yield return string.Format("public static {0} operator*({1} m, {2} v) => new {0}({3});", BaseType.Prefix + "vec" + Rows, NameThat, BaseType.Prefix + "vec" + Columns,
                        Rows.ForIndexUpTo(r => Columns.ForIndexUpTo(c => "m.m" + c + r + " * v." + "xyzw"[c]).Aggregated(" + ")).CommaSeparated());

                    // matrix-matrix-division
                    if (Rows == Columns && BaseType.IsSigned)
                    {
                        foreach (var line in "Executes a matrix-matrix-divison A / B == A * B^-1 (use with caution).".AsComment()) yield return line;
                        yield return string.Format("public static {0} operator/({0} A, {0} B) => A * B.Inverse;", NameThat);
                    }

                    // component-wise ops
                    foreach (var line in "Executes a component-wise * (multiply).".AsComment()) yield return line;
                    yield return string.Format("public static {0} CompMul({0} A, {0} B) => new {0}({1});", NameThat, Fields.Select(f => string.Format("A.{0} * B.{0}", f)).CommaSeparated());

                    foreach (var line in "Executes a component-wise / (divide).".AsComment()) yield return line;
                    yield return string.Format("public static {0} CompDiv({0} A, {0} B) => new {0}({1});", NameThat, Fields.Select(f => string.Format("A.{0} / B.{0}", f)).CommaSeparated());

                    foreach (var line in "Executes a component-wise + (add).".AsComment()) yield return line;
                    yield return string.Format("public static {0} CompAdd({0} A, {0} B) => new {0}({1});", NameThat, Fields.Select(f => string.Format("A.{0} + B.{0}", f)).CommaSeparated());

                    foreach (var line in "Executes a component-wise - (subtract).".AsComment()) yield return line;
                    yield return string.Format("public static {0} CompSub({0} A, {0} B) => new {0}({1});", NameThat, Fields.Select(f => string.Format("A.{0} - B.{0}", f)).CommaSeparated());

                    // arithmetic operators
                    foreach (var kvp in new Dictionary<string, string>
                    {
                        {"+", "+ (add)"},
                        {"-", "- (subtract)"},
                        {"/", "/ (divide)"}, // only scalar
                        {"*", "* (multiply)"} // only scalar
                    })
                    {
                        var op = kvp.Key;
                        var opComment = kvp.Value;

                        var onlyScalar = op == "/" || op == "*";

                        if (!onlyScalar)
                        {
                            foreach (var line in $"Executes a component-wise {opComment}.".AsComment()) yield return line;
                            yield return ComponentWiseOperator(op);
                        }
                        foreach (var line in $"Executes a component-wise {opComment} with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar(op, BaseTypeName);
                        foreach (var line in $"Executes a component-wise {opComment} with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalarL(op, BaseTypeName);
                    }

                    // integer-only operators
                    if (BaseType.IsInteger)
                    {
                        foreach (var kvp in new Dictionary<string, string>
                        {
                            {"%", "% (modulo)"},
                            {"^", "^ (xor)"},
                            {"|", "| (bitwise-or)"},
                            {"&", "&amp; (bitwise-and)"}
                        })
                        {
                            var op = kvp.Key;
                            var opComment = kvp.Value;

                            foreach (var line in $"Executes a component-wise {opComment}.".AsComment()) yield return line;
                            yield return ComponentWiseOperator(op);
                            foreach (var line in $"Executes a component-wise {opComment} with a scalar.".AsComment()) yield return line;
                            yield return ComponentWiseOperatorScalar(op, BaseTypeName);
                            foreach (var line in $"Executes a component-wise {opComment} with a scalar.".AsComment()) yield return line;
                            yield return ComponentWiseOperatorScalarL(op, BaseTypeName);
                        }

                        foreach (var line in "Executes a component-wise left-shift with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar("<<", "int");

                        foreach (var line in "Executes a component-wise right-shift with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar(">>", "int");
                    }

                    // comparisons
                    if (!BaseType.IsComplex)
                    {
                        foreach (var kvp in new Dictionary<string, string>
                        {
                            {"<", "lesser-than"},
                            {"<=", "lesser-or-equal"},
                            {">", "greater-than"},
                            {">=", "greater-or-equal"}
                        })
                        {
                            var op = kvp.Key;
                            var opComment = kvp.Value;

                            foreach (var line in $"Executes a component-wise {opComment} comparison.".AsComment()) yield return line;
                            yield return ComparisonOperator(op);
                            foreach (var line in $"Executes a component-wise {opComment} comparison with a scalar.".AsComment()) yield return line;
                            yield return ComparisonOperatorScalar(op, BaseTypeName);
                            foreach (var line in $"Executes a component-wise {opComment} comparison with a scalar.".AsComment()) yield return line;
                            yield return ComparisonOperatorScalarL(op, BaseTypeName);
                        }
                    }

                    // special mat4x4 funcs
                    if (BaseType.IsFloatingPoint && Rows == 4 && Columns == 4)
                    {
                        // frustum
                        foreach (var line in "Creates a frustrum projection matrix.".AsComment()) yield return line;
                        yield return string.Format("public static {0} Frustum({1} left, {1} right, {1} bottom, {1} top, {1} nearVal, {1} farVal)", NameThat, BaseTypeName);
                        yield return "{";
                        yield return "    var m = Identity;";
                        yield return "    m.m00 = (2 * nearVal) / (right - left);";
                        yield return "    m.m11 = (2 * nearVal) / (top - bottom);";
                        yield return "    m.m20 = (right + left) / (right - left);";
                        yield return "    m.m21 = (top + bottom) / (top - bottom);";
                        yield return "    m.m22 = -(farVal + nearVal) / (farVal - nearVal);";
                        yield return "    m.m23 = -1;";
                        yield return "    m.m32 = -(2 * farVal * nearVal) / (farVal - nearVal);";
                        yield return "    return m;";
                        yield return "}";

                        // infinite perspective
                        foreach (var line in "Creates a matrix for a symmetric perspective-view frustum with far plane at infinite.".AsComment()) yield return line;
                        yield return string.Format("public static {0} InfinitePerspective({1} fovy, {1} aspect, {1} zNear)", NameThat, BaseTypeName);
                        yield return "{";
                        yield return "    var range = Math.Tan((double)fovy / 2.0) * (double)zNear;";
                        yield return "    var l = -range * (double)aspect;";
                        yield return "    var r = range * (double)aspect;";
                        yield return "    var b = -range;";
                        yield return "    var t = range;";
                        yield return "    var m = Identity;";
                        yield return $"    m.m00 = ({BaseTypeName})( ((2.0)*(double)zNear)/(r - l) );";
                        yield return $"    m.m11 = ({BaseTypeName})( ((2.0)*(double)zNear)/(t - b) );";
                        yield return $"    m.m22 = ({BaseTypeName})( - (1.0) );";
                        yield return $"    m.m23 = ({BaseTypeName})( - (1.0) );";
                        yield return $"    m.m32 = ({BaseTypeName})( - (2.0)*(double)zNear );";
                        yield return "    return m;";
                        yield return "}";

                        // look at
                        foreach (var line in "Build a look at view matrix.".AsComment()) yield return line;
                        yield return string.Format("public static {0} LookAt({1} eye, {1} center, {1} up)", NameThat, BaseType.Prefix + "vec3");
                        yield return "{";
                        yield return "    var f = (center - eye).Normalized;";
                        yield return $"    var s = {BaseType.Prefix + "vec3"}.Cross(f, up).Normalized;";
                        yield return $"    var u = {BaseType.Prefix + "vec3"}.Cross(s, f);";
                        yield return "    var m = Identity;";
                        yield return "    m.m00 = s.x;";
                        yield return "    m.m10 = s.y;";
                        yield return "    m.m20 = s.z;";
                        yield return "    m.m01 = u.x;";
                        yield return "    m.m11 = u.y;";
                        yield return "    m.m21 = u.z;";
                        yield return "    m.m02 = -f.x;";
                        yield return "    m.m12 = -f.y;";
                        yield return "    m.m22 = -f.z;";
                        yield return $"    m.m30 = -{BaseType.Prefix + "vec3"}.Dot(s, eye);";
                        yield return $"    m.m31 = -{BaseType.Prefix + "vec3"}.Dot(u, eye);";
                        yield return $"    m.m32 = {BaseType.Prefix + "vec3"}.Dot(f, eye);";
                        yield return "    return m;";
                        yield return "}";

                        // ortho
                        foreach (var line in "Creates a matrix for an orthographic parallel viewing volume.".AsComment()) yield return line;
                        yield return string.Format("public static {0} Ortho({1} left, {1} right, {1} bottom, {1} top, {1} zNear, {1} zFar)", NameThat, BaseTypeName);
                        yield return "{";
                        yield return "    var m = Identity;";
                        yield return "    m.m00 = 2/(right - left);";
                        yield return "    m.m11 = 2/(top - bottom);";
                        yield return "    m.m22 = - 2/(zFar - zNear);";
                        yield return "    m.m30 = - (right + left)/(right - left);";
                        yield return "    m.m31 = - (top + bottom)/(top - bottom);";
                        yield return "    m.m32 = - (zFar + zNear)/(zFar - zNear);";
                        yield return "    return m;";
                        yield return "}";

                        foreach (var line in "Creates a matrix for projecting two-dimensional coordinates onto the screen.".AsComment()) yield return line;
                        yield return string.Format("public static {0} Ortho({1} left, {1} right, {1} bottom, {1} top)", NameThat, BaseTypeName);
                        yield return "{";
                        yield return "    var m = Identity;";
                        yield return "    m.m00 = 2/(right - left);";
                        yield return "    m.m11 = 2/(top - bottom);";
                        yield return "    m.m22 = - 1;";
                        yield return "    m.m30 = - (right + left)/(right - left);";
                        yield return "    m.m31 = - (top + bottom)/(top - bottom);";
                        yield return "    return m;";
                        yield return "}";

                        // perspective
                        foreach (var line in "Creates a perspective transformation matrix.".AsComment()) yield return line;
                        yield return string.Format("public static {0} Perspective({1} fovy, {1} aspect, {1} zNear, {1} zFar)", NameThat, BaseTypeName);
                        yield return "{";
                        yield return "    var tanHalfFovy = Math.Tan((double)fovy / 2.0);";
                        yield return "    var m = Zero;";
                        yield return $"    m.m00 = ({BaseTypeName})( 1 / ((double)aspect * tanHalfFovy) );";
                        yield return $"    m.m11 = ({BaseTypeName})( 1 / (tanHalfFovy) );";
                        yield return $"    m.m22 = ({BaseTypeName})( -(zFar + zNear) / (zFar - zNear) );";
                        yield return $"    m.m23 = ({BaseTypeName})( -1 );";
                        yield return $"    m.m32 = ({BaseTypeName})( -(2 * zFar * zNear) / (zFar - zNear) );";
                        yield return "    return m;";
                        yield return "}";

                        // perspectiveFov
                        foreach (var line in "Builds a perspective projection matrix based on a field of view.".AsComment()) yield return line;
                        yield return string.Format("public static {0} PerspectiveFov({1} fov, {1} width, {1} height, {1} zNear, {1} zFar)", NameThat, BaseTypeName);
                        yield return "{";
                        yield return "    if (width <= 0) throw new ArgumentOutOfRangeException(\"width\");";
                        yield return "    if (height <= 0) throw new ArgumentOutOfRangeException(\"height\");";
                        yield return "    if (fov <= 0) throw new ArgumentOutOfRangeException(\"fov\");";
                        yield return "    var h = Math.Cos((double)fov / 2.0) / Math.Sin((double)fov / 2.0);";
                        yield return "    var w = h * (double)(height / width);";
                        yield return "    var m = Zero;";
                        yield return $"    m.m00 = ({BaseTypeName})w;";
                        yield return $"    m.m11 = ({BaseTypeName})h;";
                        yield return "    m.m22 = - (zFar + zNear)/(zFar - zNear);";
                        yield return "    m.m23 = - 1;";
                        yield return "    m.m32 = - (2*zFar*zNear)/(zFar - zNear);";
                        yield return "    return m;";
                        yield return "}";

                        // TODO: Pick matrix

                        // project
                        foreach (var line in "Map the specified object coordinates (obj.x, obj.y, obj.z) into window coordinates.".AsComment()) yield return line;
                        yield return string.Format("public static {1} Project({1} obj, {0} model, {0} proj, {2} viewport)", NameThat, BaseType.Prefix + "vec3", BaseType.Prefix + "vec4");
                        yield return "{";
                        yield return $"    var tmp = proj * (model * new {BaseType.Prefix}vec4(obj, 1));";
                        yield return "    tmp /= tmp.w;";
                        yield return string.Format("    tmp = tmp * {0} + {0};", ConstantSuffixFor("0.5"));
                        yield return "    tmp.x = tmp.x * viewport.z + viewport.x;";
                        yield return "    tmp.y = tmp.y * viewport.w + viewport.y;";
                        yield return "    return tmp.swizzle.xyz;";
                        yield return "}";

                        // unproject
                        foreach (var line in "Map the specified window coordinates (win.x, win.y, win.z) into object coordinates.".AsComment()) yield return line;
                        yield return string.Format("public static {1} UnProject({1} win, {0} model, {0} proj, {2} viewport)", NameThat, BaseType.Prefix + "vec3", BaseType.Prefix + "vec4");
                        yield return "{";
                        yield return $"    var tmp = new {BaseType.Prefix + "vec4"}(win, 1);";
                        yield return "    tmp.x = (tmp.x - viewport.x) / viewport.z;";
                        yield return "    tmp.y = (tmp.y - viewport.y) / viewport.w;";
                        yield return "    tmp = tmp * 2 - 1;";
                        yield return "";
                        yield return "    var unp = proj.Inverse * tmp;";
                        yield return "    unp /= unp.w;";
                        yield return "    var obj = model.Inverse * unp;";
                        yield return $"    return ({BaseType.Prefix + "vec3"})obj / obj.w;";
                        yield return "}";

                        foreach (var line in "Map the specified window coordinates (win.x, win.y, win.z) into object coordinates (faster but less precise).".AsComment()) yield return line;
                        yield return string.Format("public static {1} UnProjectFaster({1} win, {0} model, {0} proj, {2} viewport)", NameThat, BaseType.Prefix + "vec3", BaseType.Prefix + "vec4");
                        yield return "{";
                        yield return $"    var tmp = new {BaseType.Prefix + "vec4"}(win, 1);";
                        yield return "    tmp.x = (tmp.x - viewport.x) / viewport.z;";
                        yield return "    tmp.y = (tmp.y - viewport.y) / viewport.w;";
                        yield return "    tmp = tmp * 2 - 1;";
                        yield return "";
                        yield return "    var obj = (proj * model).Inverse * tmp;";
                        yield return $"    return ({BaseType.Prefix + "vec3"})obj / obj.w;";
                        yield return "}";

                        // rotate
                        foreach (var line in "Builds a rotation 4 * 4 matrix created from an axis vector and an angle in radians.".AsComment()) yield return line;
                        yield return $"public static {NameThat} Rotate({BaseTypeName} angle, {BaseType.Prefix + "vec3"} v)";
                        yield return "{";
                        yield return $"    var c = ({BaseTypeName})Math.Cos((double)angle);";
                        yield return $"    var s = ({BaseTypeName})Math.Sin((double)angle);";
                        yield return "";
                        yield return "    var axis = v.Normalized;";
                        yield return "    var temp = (1 - c) * axis;";
                        yield return "";
                        yield return "    var m = Identity;";
                        yield return "    m.m00 = c + temp.x * axis.x;";
                        yield return "    m.m01 = 0 + temp.x * axis.y + s * axis.z;";
                        yield return "    m.m02 = 0 + temp.x * axis.z - s * axis.y;";
                        yield return "";
                        yield return "    m.m10 = 0 + temp.y * axis.x - s * axis.z;";
                        yield return "    m.m11 = c + temp.y * axis.y;";
                        yield return "    m.m12 = 0 + temp.y * axis.z + s * axis.x;";
                        yield return "";
                        yield return "    m.m20 = 0 + temp.z * axis.x + s * axis.y;";
                        yield return "    m.m21 = 0 + temp.z * axis.y - s * axis.x;";
                        yield return "    m.m22 = c + temp.z * axis.z;";
                        yield return "    return m;";
                        yield return "}";

                        for (var axis = 0; axis < 3; ++axis)
                        {
                            foreach (var line in $"Builds a rotation matrix around Unit{"XYZ"[axis]} and an angle in radians.".AsComment()) yield return line;
                            yield return $"public static {NameThat} Rotate{"XYZ"[axis]}({BaseTypeName} angle)";
                            yield return "{";
                            // TODO: more performant
                            yield return $"    return Rotate(angle, {BaseType.Prefix + "vec3"}.Unit{"XYZ"[axis]});";
                            yield return "}";
                        }

                        // scale
                        foreach (var line in "Builds a scale matrix by components x, y, z.".AsComment()) yield return line;
                        yield return string.Format("public static {0} Scale({1} x, {1} y, {1} z)", NameThat, BaseTypeName);
                        yield return "{";
                        yield return "    var m = Identity;";
                        yield return "    m.m00 = x;";
                        yield return "    m.m11 = y;";
                        yield return "    m.m22 = z;";
                        yield return "    return m;";
                        yield return "}";

                        foreach (var line in "Builds a scale matrix by vector v.".AsComment()) yield return line;
                        yield return $"public static {NameThat} Scale({BaseType.Prefix + "vec3"} v) => Scale(v.x, v.y, v.z);";
                        foreach (var line in "Builds a scale matrix by uniform scaling s.".AsComment()) yield return line;
                        yield return $"public static {NameThat} Scale({BaseTypeName} s) => Scale(s, s, s);";

                        // translation
                        foreach (var line in "Builds a translation matrix by components x, y, z.".AsComment()) yield return line;
                        yield return string.Format("public static {0} Translate({1} x, {1} y, {1} z)", NameThat, BaseTypeName);
                        yield return "{";
                        yield return "    var m = Identity;";
                        yield return "    m.m30 = x;";
                        yield return "    m.m31 = y;";
                        yield return "    m.m32 = z;";
                        yield return "    return m;";
                        yield return "}";

                        foreach (var line in "Builds a translation matrix by vector v.".AsComment()) yield return line;
                        yield return $"public static {NameThat} Translate({BaseType.Prefix + "vec3"} v) => Translate(v.x, v.y, v.z);";
                    }
                }
            }
        }
    }
}
