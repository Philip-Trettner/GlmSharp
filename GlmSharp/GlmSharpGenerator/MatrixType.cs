using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator
{
    class MatrixType : TypeBase
    {
        public int Rows { get; set; }
        public int Columns { get; set; }
        public int FieldCount => Rows * Columns;

        public override IEnumerable<string> BaseClasses
        {
            get
            {
                yield return string.Format("IReadOnlyList<{0}>", BaseType);
                yield return string.Format("IEquatable<{0}>", ClassNameThat);
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

        public override string ClassName => Name + (Rows == Columns ? Columns.ToString() : Columns + "x" + Rows);
        public string ClassNameTransposed => Name + (Rows == Columns ? Columns.ToString() : Rows + "x" + Columns) + GenericSuffix;

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

        public string FieldFor(int f) => string.Format("m{0}{1}", f / Rows, f % Rows);

        public string ArgOf(int c) => "xyzw"[c].ToString();

        public int RowOf(string fieldName) => fieldName[2] - '0';
        public int ColOf(string fieldName) => fieldName[1] - '0';

        public bool IsDiagonal(string fieldName) => fieldName[1] == fieldName[2];

        public string ColumnType => BaseTypeInfo.Prefix + "vec" + Rows + GenericSuffix;
        public string RowType => BaseTypeInfo.Prefix + "vec" + Columns + GenericSuffix;

        private IEnumerable<string> Constructor(string comment, string args, IEnumerable<string> assignments)
        {
            foreach (var line in comment.AsComment())
                yield return line;
            yield return string.Format("public {0}({1})", ClassName, args);
            yield return "{";
            var it = assignments.GetEnumerator();
            foreach (var c in Fields)
                yield return string.Format("this.{0} = {1};", c, it.MoveNext() ? it.Current : (c[1] == c[2] ? BaseTypeInfo.OneValue : BaseTypeInfo.ZeroValue)).Indent();
            yield return "}";
        }

        public string HashCodeFor(int c) => (c == 0 ? "" : string.Format("(({0}) * {1}) ^ ", HashCodeFor(c - 1), BaseTypeInfo.HashCodeMultiplier)) + HashCodeOf(FieldFor(c));


        public string ComponentWiseOperator(string op)
            => string.Format("public static {0} operator{2}({0} lhs, {0} rhs) => new {0}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op);

        public string ComponentWiseOperator(string op, string internalOp)
            => string.Format("public static {0} operator{2}({0} lhs, {0} rhs) => new {0}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, internalOp)).CommaSeparated(), op);

        public string ComponentWiseOperatorScalar(string op, string scalarType)
            => string.Format("public static {0} operator{2}({0} lhs, {3} rhs) => new {0}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs", c, op)).CommaSeparated(), op, scalarType);

        public string ComponentWiseOperatorScalarL(string op, string scalarType)
            => string.Format("public static {0} operator{2}({3} lhs, {0} rhs) => new {0}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, scalarType);

        public string ComponentWiseOperatorForeign(string op, string returnType)
            => string.Format("public static {3} operator{2}({0} lhs, {3} rhs) => new {3}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, returnType);
        public string ComponentWiseOperatorForeignL(string op, string returnType)
            => string.Format("public static {3} operator{2}({3} lhs, {0} rhs) => new {3}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, returnType);

        public string ComponentWiseOperatorForeignScalar(string op, string scalarType, string returnType)
            => string.Format("public static {4} operator{2}({0} lhs, {3} rhs) => new {4}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs", c, op)).CommaSeparated(), op, scalarType, returnType);

        public string ComponentWiseOperatorForeignScalarL(string op, string scalarType, string returnType)
            => string.Format("public static {4} operator{2}({3} lhs, {0} rhs) => new {4}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, scalarType, returnType);

        public string ComparisonOperator(string op)
            => string.Format("public static bmat{3} operator{2}({0} lhs, {0} rhs) => new bmat{3}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, (Rows == Columns ? Columns.ToString() : Columns + "x" + Rows));

        public string ComparisonOperatorScalar(string op, string scalarType)
            => string.Format("public static bmat{3} operator{2}({0} lhs, {4} rhs) => new bmat{3}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs.{0} {1} rhs", c, op)).CommaSeparated(), op, (Rows == Columns ? Columns.ToString() : Columns + "x" + Rows), scalarType);

        public string ComparisonOperatorScalarL(string op, string scalarType)
            => string.Format("public static bmat{3} operator{2}({4} lhs, {0} rhs) => new bmat{3}({1});", ClassNameThat,
                    Fields.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, (Rows == Columns ? Columns.ToString() : Columns + "x" + Rows), scalarType);

        public string NestedBiFuncFor(string format, int c, Func<int, string> argOf) => c == 0 ? argOf(c) : string.Format(format, NestedBiFuncFor(format, c - 1, argOf), argOf(c));

        public IEnumerable<string> FieldsHelper(int cols, int rows)
        {
            for (var x = 0; x < cols; ++x)
                for (var y = 0; y < rows; ++y)
                    yield return "m" + x + y;
        }

        protected override IEnumerable<string> Body
        {
            get
            {
                // Fields
                yield return "// Matrix fields mXY";
                for (var x = 0; x < Columns; ++x)
                    yield return string.Format("public {0} {1}; // Column {2}", BaseType, Column(x).CommaSeparated(), x);


                // Values
                foreach (var line in "Creates a 2D array with all values (address: Values[x, y])".AsComment()) yield return line;
                yield return string.Format("public {0}[,] Values => new[,] {{ {1} }};", BaseType, Columns.ForIndexUpTo(col => "{ " + Column(col).CommaSeparated() + " }").CommaSeparated());

                foreach (var line in "Creates a 1D array with all values (internal order)".AsComment()) yield return line;
                yield return string.Format("public {0}[] Values1D => new[] {{ {1} }};", BaseType, Fields.CommaSeparated());


                // Columns
                for (var x = 0; x < Columns; ++x)
                {
                    foreach (var line in string.Format("Returns the column nr {0}", x).AsComment()) yield return line;
                    yield return string.Format("public {0} Column{1} => new {0}({2});", ColumnType, x, Column(x).CommaSeparated());
                }


                // Rows
                for (var y = 0; y < Rows; ++y)
                {
                    foreach (var line in string.Format("Returns the row nr {0}", y).AsComment()) yield return line;
                    yield return string.Format("public {0} Row{1} => new {0}({2});", RowType, y, Row(y).CommaSeparated());
                }


                // predefs
                foreach (var line in "Predefined all-zero matrix".AsComment()) yield return line;
                yield return string.Format("public static {0} Zero {{ get; }} = new {0}({1});", ClassNameThat, ZeroValue.RepeatTimes(FieldCount).CommaSeparated());

                if (!string.IsNullOrEmpty(BaseTypeInfo.OneValue))
                {
                    foreach (var line in "Predefined all-ones matrix".AsComment()) yield return line;
                    yield return string.Format("public static {0} Ones {{ get; }} = new {0}({1});", ClassNameThat, OneValue.RepeatTimes(FieldCount).CommaSeparated());

                    foreach (var line in "Predefined identity matrix".AsComment()) yield return line;
                    yield return string.Format("public static {0} Identity {{ get; }} = new {0}({1});", ClassNameThat, Fields.Select(f => IsDiagonal(f) ? OneValue : ZeroValue).CommaSeparated());
                }


                // Constructors
                foreach (var line in Constructor("Component-wise constructor", Fields.Select(f => BaseType + " " + f).CommaSeparated(), Fields)) yield return line;
                foreach (var line in Constructor("Copy constructor", ClassNameThat + " m", Fields.Select(f => "m." + f))) yield return line;
                foreach (var line in Constructor("Column constructor", Columns.ForIndexUpTo(col => ColumnType + " c" + col).CommaSeparated(), Fields.Select(f => "c" + ColOf(f) + "." + ArgOf(RowOf(f))))) yield return line;

                // TODO: sub-col init
                // TODO: sub-mat init


                // IEnumerable
                foreach (var line in "Returns an enumerator that iterates through all FieldCount.".AsComment()) yield return line;
                yield return string.Format("public IEnumerator<{0}> GetEnumerator()", BaseType);
                yield return "{";
                foreach (var c in Fields)
                    yield return string.Format("yield return {0};", c).Indent();
                yield return "}";

                foreach (var line in "Returns an enumerator that iterates through all FieldCount.".AsComment()) yield return line;
                yield return "IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();";


                // Indexer
                foreach (var line in string.Format("Returns the number of FieldCount ({0}).", FieldCount).AsComment()) yield return line;
                yield return string.Format("public int Count => {0};", FieldCount);

                foreach (var line in "Gets/Sets a specific indexed component (a bit slower than direct access).".AsComment()) yield return line;
                yield return string.Format("public {0} this[int fieldIndex]", BaseType);
                yield return "{";
                yield return "    get";
                yield return "    {";
                yield return "        switch (fieldIndex)";
                yield return "        {";
                for (var c = 0; c < FieldCount; ++c)
                    yield return string.Format("            case {0}: return {1};", c, FieldFor(c));
                yield return "            default: throw new ArgumentOutOfRangeException(\"fieldIndex\");";
                yield return "        }";
                yield return "    }";
                yield return "    set";
                yield return "    {";
                yield return "        switch (fieldIndex)";
                yield return "        {";
                for (var c = 0; c < FieldCount; ++c)
                    yield return string.Format("            case {0}: this.{1} = value; break;", c, FieldFor(c));
                yield return "            default: throw new ArgumentOutOfRangeException(\"fieldIndex\");";
                yield return "        }";
                yield return "    }";
                yield return "}";

                foreach (var line in "Gets/Sets a specific 2D-indexed component (a bit slower than direct access).".AsComment()) yield return line;
                yield return string.Format("public {0} this[int col, int row]", BaseType);
                yield return "{";
                yield return "    get";
                yield return "    {";
                yield return string.Format("        return this[col * {0} + row];", Rows);
                yield return "    }";
                yield return "    set";
                yield return "    {";
                yield return string.Format("        this[col * {0} + row] = value;", Rows);
                yield return "    }";
                yield return "}";


                // Equality comparisons
                foreach (var line in "Returns true iff this equals rhs component-wise.".AsComment()) yield return line;
                yield return string.Format("public bool Equals({0} rhs) => {1};", ClassNameThat, Fields.Select(c => Comparer(c.ToString())).Aggregated(" && "));

                foreach (var line in "Returns true iff this equals rhs type- and component-wise.".AsComment()) yield return line;
                yield return "public override bool Equals(object obj)";
                yield return "{";
                yield return "    if (ReferenceEquals(null, obj)) return false;";
                yield return string.Format("    return obj is {0} && Equals(({0}) obj);", ClassNameThat);
                yield return "}";

                foreach (var line in "Returns true iff this equals rhs component-wise.".AsComment()) yield return line;
                yield return string.Format("public static bool operator ==({0} lhs, {0} rhs) => lhs.Equals(rhs);", ClassNameThat);

                foreach (var line in "Returns true iff this does not equal rhs (component-wise).".AsComment()) yield return line;
                yield return string.Format("public static bool operator !=({0} lhs, {0} rhs) => !lhs.Equals(rhs);", ClassNameThat);

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
                if (BaseTypeInfo.HasLogicOps)
                {
                    foreach (var line in "Returns the minimal component of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} MinElement => {1};", BaseType, Fields.Aggregated(" && "));

                    foreach (var line in "Returns the maximal component of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} MaxElement => {1};", BaseType, Fields.Aggregated(" || "));

                    foreach (var line in "Returns true if all component are true.".AsComment()) yield return line;
                    yield return string.Format("public {0} All => {1};", BaseType, Fields.Aggregated(" && "));

                    foreach (var line in "Returns true if any component is true.".AsComment()) yield return line;
                    yield return string.Format("public {0} Any => {1};", BaseType, Fields.Aggregated(" || "));

                    foreach (var line in "Executes a component-wise &&. (sorry for different overload but && cannot be overloaded directly)".AsComment()) yield return line;
                    yield return ComponentWiseOperator("&", "&&");

                    foreach (var line in "Executes a component-wise ||. (sorry for different overload but || cannot be overloaded directly)".AsComment()) yield return line;
                    yield return ComponentWiseOperator("|", "||");
                }


                // Arithmetics
                if (BaseTypeInfo.HasArithmetics)
                {
                    var lengthType = BaseTypeInfo.LengthType;

                    if (!BaseTypeInfo.IsComplex)
                    {
                        foreach (var line in "Returns the minimal component of this matrix.".AsComment()) yield return line;
                        yield return string.Format("public {0} MinElement => {1};", BaseType, NestedBiFuncFor("Math.Min({0}, {1})", FieldCount - 1, FieldFor));

                        foreach (var line in "Returns the maximal component of this matrix.".AsComment()) yield return line;
                        yield return string.Format("public {0} MaxElement => {1};", BaseType, NestedBiFuncFor("Math.Max({0}, {1})", FieldCount - 1, FieldFor));
                    }

                    foreach (var line in "Returns the euclidean length of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} Length => ({0}){1};", lengthType, SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the squared euclidean length of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} LengthSqr => {1};", lengthType, Fields.Select(SqrOf).Aggregated(" + "));

                    foreach (var line in "Returns the sum of all FieldCount.".AsComment()) yield return line;
                    yield return string.Format("public {0} Sum => {1};", BaseType, Fields.Aggregated(" + "));

                    foreach (var line in "Returns the euclidean norm of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm => ({0}){1};", lengthType, SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the one-norm of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm1 => {1};", lengthType, Fields.Select(AbsString).Aggregated(" + "));

                    foreach (var line in "Returns the two-norm of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm2 => ({0}){1};", lengthType, SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the max-norm of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public {0} NormMax => {1};", BaseType, NestedBiFuncFor("Math.Max({0}, {1})", FieldCount - 1, c => AbsString(FieldFor(c))));

                    foreach (var line in "Returns the p-norm of this matrix.".AsComment()) yield return line;
                    yield return string.Format("public double NormP(double p) => Math.Pow({0}, 1 / p);", Fields.Select(c => string.Format("Math.Pow((double){0}, p)", AbsString(c))).Aggregated(" + "));

                    // determinant
                    if (Rows == Columns)
                    {
                        foreach (var line in "Returns determinant of this matrix.".AsComment()) yield return line;
                        yield return string.Format("public {0} Determinant => {1};", BaseType, HelperDet(HelperFieldsOf(Rows)));

                        if (BaseTypeInfo.IsSigned)
                        {
                            foreach (var line in "Returns the adjunct of this matrix.".AsComment()) yield return line;
                            yield return string.Format("public {0} Adjugate => new {0}({1});", ClassNameThat, FieldsTransposed.Select(f => HelperDet(HelperSubmatrix(HelperFieldsOf(Rows), ColOf(f), RowOf(f)), ColOf(f) + RowOf(f))).CommaSeparated());

                            foreach (var line in "Returns the inverse of this matrix (use with caution).".AsComment()) yield return line;
                            yield return string.Format("public {0} Inverse => Adjugate / Determinant;", ClassNameThat);
                        }
                    }

                    // matrix-matrix-multiplication
                    for (var rcols = 2; rcols <= 4; ++rcols)
                    {
                        var lhsRows = Rows;
                        var lhsCols = Columns;
                        var rhsRows = Columns;
                        var rhsColumns = rcols;
                        var rhsType = Name + (rhsRows == rhsColumns ? rhsColumns.ToString() : rhsColumns + "x" + rhsRows) + GenericSuffix;
                        var resultType = Name + (lhsRows == rhsColumns ? rhsColumns.ToString() : rhsColumns + "x" + lhsRows) + GenericSuffix;
                        foreach (var line in string.Format("Executes a matrix-matrix-multiplication {0} * {1} -> {2}.", ClassNameThat, rhsType, resultType).AsComment()) yield return line;
                        yield return string.Format("public static {0} operator*({1} lhs, {2} rhs) => new {0}({3});",
                            resultType, ClassNameThat, rhsType,
                            FieldsHelper(lhsRows, rhsColumns).Select(f => lhsCols.ForIndexUpTo(i => string.Format("lhs.m{1}{0} * rhs.m{2}{1}", f[1], i, f[2])).Aggregated(" + ")).CommaSeparated());
                    }

                    // matrix-matrix-division
                    if (Rows == Columns && BaseTypeInfo.IsSigned)
                    {
                        foreach (var line in "Executes a matrix-matrix-divison A / B == A * B^-1 (use with caution).".AsComment()) yield return line;
                        yield return string.Format("public static {0} operator/({0} A, {0} B) => A * B.Inverse;", ClassNameThat);
                    }

                    // component-wise ops
                    foreach (var line in "Executes a component-wise * (multiply).".AsComment()) yield return line;
                    yield return string.Format("public static {0} CompMul({0} A, {0} B) => new {0}({1});", ClassNameThat, Fields.Select(f => string.Format("A.{0} * B.{0}", f)).CommaSeparated());

                    foreach (var line in "Executes a component-wise / (divide).".AsComment()) yield return line;
                    yield return string.Format("public static {0} CompDiv({0} A, {0} B) => new {0}({1});", ClassNameThat, Fields.Select(f => string.Format("A.{0} / B.{0}", f)).CommaSeparated());

                    foreach (var line in "Executes a component-wise + (add).".AsComment()) yield return line;
                    yield return string.Format("public static {0} CompAdd({0} A, {0} B) => new {0}({1});", ClassNameThat, Fields.Select(f => string.Format("A.{0} + B.{0}", f)).CommaSeparated());

                    foreach (var line in "Executes a component-wise - (subtract).".AsComment()) yield return line;
                    yield return string.Format("public static {0} CompSub({0} A, {0} B) => new {0}({1});", ClassNameThat, Fields.Select(f => string.Format("A.{0} - B.{0}", f)).CommaSeparated());

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
                            foreach (var line in string.Format("Executes a component-wise {0}.", opComment).AsComment()) yield return line;
                            yield return ComponentWiseOperator(op);
                        }
                        foreach (var line in string.Format("Executes a component-wise {0} with a scalar.", opComment).AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar(op, BaseType);
                        foreach (var line in string.Format("Executes a component-wise {0} with a scalar.", opComment).AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalarL(op, BaseType);
                    }

                    // integer-only operators
                    if (BaseTypeInfo.IsInteger)
                    {
                        foreach (var kvp in new Dictionary<string, string>
                        {
                            {"%", "% (modulo)"},
                            {"^", "^ (xor)"},
                            {"|", "| (bitwise-or)"},
                            {"&", "& (bitwise-and)"}
                        })
                        {
                            var op = kvp.Key;
                            var opComment = kvp.Value;

                            foreach (var line in string.Format("Executes a component-wise {0}.", opComment).AsComment()) yield return line;
                            yield return ComponentWiseOperator(op);
                            foreach (var line in string.Format("Executes a component-wise {0} with a scalar.", opComment).AsComment()) yield return line;
                            yield return ComponentWiseOperatorScalar(op, BaseType);
                            foreach (var line in string.Format("Executes a component-wise {0} with a scalar.", opComment).AsComment()) yield return line;
                            yield return ComponentWiseOperatorScalarL(op, BaseType);
                        }

                        foreach (var line in "Executes a component-wise left-shift with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar("<<", "int");

                        foreach (var line in "Executes a component-wise right-shift with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar(">>", "int");
                    }

                    // comparisons
                    if (!BaseTypeInfo.IsComplex)
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

                            foreach (var line in string.Format("Executes a component-wise {0} comparison.", opComment).AsComment()) yield return line;
                            yield return ComparisonOperator(op);
                            foreach (var line in string.Format("Executes a component-wise {0} comparison with a scalar.", opComment).AsComment()) yield return line;
                            yield return ComparisonOperatorScalar(op, BaseType);
                            foreach (var line in string.Format("Executes a component-wise {0} comparison with a scalar.", opComment).AsComment()) yield return line;
                            yield return ComparisonOperatorScalarL(op, BaseType);
                        }
                    }

                    // special mat4x4 funcs
                    if (BaseTypeInfo.IsFloatingPoint && Rows == 4 && Columns == 4)
                    {
                        // frustum
                        foreach (var line in "Creates a frustrum projection matrix.".AsComment()) yield return line;
                        yield return string.Format("public static {0} Frustum({1} left, {1} right, {1} bottom, {1} top, {1} nearVal, {1} farVal)", ClassNameThat, BaseType);
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
                        yield return string.Format("public static {0} InfinitePerspective({1} fovy, {1} aspect, {1} zNear)", ClassNameThat, BaseType);
                        yield return "{";
                        yield return "    var range = Math.Tan((double)fovy / 2.0) * (double)zNear;";
                        yield return "    var l = -range * (double)aspect;";
                        yield return "    var r = range * (double)aspect;";
                        yield return "    var b = -range;";
                        yield return "    var t = range;";
                        yield return "    var m = Identity;";
                        yield return string.Format("    m.m00 = ({0})( ((2.0)*(double)zNear)/(r - l) );", BaseType);
                        yield return string.Format("    m.m11 = ({0})( ((2.0)*(double)zNear)/(t - b) );", BaseType);
                        yield return string.Format("    m.m22 = ({0})( - (1.0) );", BaseType);
                        yield return string.Format("    m.m23 = ({0})( - (1.0) );", BaseType);
                        yield return string.Format("    m.m32 = ({0})( - (2.0)*(double)zNear );", BaseType);
                        yield return "    return m;";
                        yield return "}";

                        // look at
                        foreach (var line in "Build a look at view matrix.".AsComment()) yield return line;
                        yield return string.Format("public static {0} LookAt({1} eye, {1} center, {1} up)", ClassNameThat, BaseTypeInfo.Prefix + "vec3");
                        yield return "{";
                        yield return "    var f = (center - eye).Normalized;";
                        yield return string.Format("    var s = {0}.Cross(f, up).Normalized;", BaseTypeInfo.Prefix + "vec3");
                        yield return string.Format("    var u = {0}.Cross(s, f);", BaseTypeInfo.Prefix + "vec3");
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
                        yield return string.Format("    m.m30 = -{0}.Dot(s, eye);", BaseTypeInfo.Prefix + "vec3");
                        yield return string.Format("    m.m31 = -{0}.Dot(u, eye);", BaseTypeInfo.Prefix + "vec3");
                        yield return string.Format("    m.m32 = {0}.Dot(f, eye);", BaseTypeInfo.Prefix + "vec3");
                        yield return "    return m;";
                        yield return "}";

                        // ortho
                        foreach (var line in "Creates a matrix for an orthographic parallel viewing volume.".AsComment()) yield return line;
                        yield return string.Format("public static {0} Ortho({1} left, {1} right, {1} bottom, {1} top, {1} zNear, {1} zFar)", ClassNameThat, BaseType);
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
                        yield return string.Format("public static {0} Ortho({1} left, {1} right, {1} bottom, {1} top)", ClassNameThat, BaseType);
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
                        yield return string.Format("public static {0} Perspective({1} fovy, {1} aspect, {1} zNear, {1} zFar)", ClassNameThat, BaseType);
                        yield return "{";
                        yield return "    var tanHalfFovy = Math.Tan((double)fovy / 2.0);";
                        yield return "    var m = Identity;";
                        yield return string.Format("    m.m00 = ({0})( 1 / ((double)aspect * tanHalfFovy) );", BaseType);
                        yield return string.Format("    m.m11 = ({0})( 1 / (tanHalfFovy) );", BaseType);
                        yield return string.Format("    m.m22 = ({0})( -(zFar + zNear) / (zFar - zNear) );", BaseType);
                        yield return string.Format("    m.m23 = ({0})( -1 );", BaseType);
                        yield return string.Format("    m.m32 = ({0})( -(2 * zFar * zNear) / (zFar - zNear) );", BaseType);
                        yield return "    return m;";
                        yield return "}";
                    }
                }
            }
        }
    }
}
