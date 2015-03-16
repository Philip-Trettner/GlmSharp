﻿using System;
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

        public override string ClassName => Name + (Rows == Columns ? Columns.ToString() : Columns + "x" + Rows);

        public IEnumerable<string> Fields
        {
            get
            {
                for (var x = 0; x < Columns; ++x)
                    for (var y = 0; y < Rows; ++y)
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
                foreach (var line in "Predefined all-zero matrix (DO NOT MODIFY)".AsComment()) yield return line;
                yield return string.Format("public static readonly {0} Zero = new {0}({1});", ClassNameThat, ZeroValue.RepeatTimes(FieldCount).CommaSeparated());

                if (!string.IsNullOrEmpty(BaseTypeInfo.OneValue))
                {
                    foreach (var line in "Predefined all-ones matrix (DO NOT MODIFY)".AsComment()) yield return line;
                    yield return string.Format("public static readonly {0} Ones = new {0}({1});", ClassNameThat, OneValue.RepeatTimes(FieldCount).CommaSeparated());

                    foreach (var line in "Predefined identity matrix (DO NOT MODIFY)".AsComment()) yield return line;
                    yield return string.Format("public static readonly {0} Identity = new {0}({1});", ClassNameThat, Fields.Select(f => IsDiagonal(f) ? OneValue : ZeroValue).CommaSeparated());
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

                    if (!BaseTypeInfo.Complex)
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

                    // arithmetic operators
                    foreach (var kvp in new Dictionary<string, string>
                    {
                        {"+", "+ (add)"},
                        {"-", "- (subtract)"},
                        //{"/", "/ (divide)"}, not natural
                        //{"*", "* (multiply)"} not natural
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
                    if (!BaseTypeInfo.Complex)
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
                }
            }
        }
    }
}
