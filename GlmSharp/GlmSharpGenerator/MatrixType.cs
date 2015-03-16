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
                foreach (var line in "Returns an enumerator that iterates through all components.".AsComment()) yield return line;
                yield return string.Format("public IEnumerator<{0}> GetEnumerator()", BaseType);
                yield return "{";
                foreach (var c in Fields)
                    yield return string.Format("yield return {0};", c).Indent();
                yield return "}";

                foreach (var line in "Returns an enumerator that iterates through all components.".AsComment()) yield return line;
                yield return "IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();";


                // Indexer
                foreach (var line in string.Format("Returns the number of components ({0}).", FieldCount).AsComment()) yield return line;
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
            }
        }
    }
}
