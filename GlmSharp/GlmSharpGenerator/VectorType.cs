using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace GlmSharpGenerator
{
    class VectorType : TypeBase
    {
        public int Components { get; set; } = 3;
        public override string ClassName => Name + Components;

        public string CompString => "xyzw".Substring(0, Components);

        public override IEnumerable<string> BaseClasses
        {
            get
            {
                yield return string.Format("IReadOnlyList<{0}>", BaseType);
                yield return string.Format("IEquatable<{0}>", ClassNameThat);
            }
        }

        public string CompParameterString => CompString.Select(c => BaseType + " " + c).CommaSeparated();
        public IEnumerable<string> CompParameters => CompString.Select(c => BaseType + " " + c);

        public string CompArgString => CompString.CommaSeparated();
        public IEnumerable<string> CompArgs => CompString.Select(c => c.ToString());

        public string DefaultValue => "default(" + BaseType + ")";

        public char ArgOf(int c) => "xyzw"[c];
        public string ArgOfs(int c) => "xyzw"[c].ToString();

        public string AbsString(string s) => BaseTypeInfo.RequiredAbs ? string.Format("Math.Abs({0})", s) : s;
        public string AbsString(char s) => BaseTypeInfo.RequiredAbs ? string.Format("Math.Abs({0})", s) : s.ToString();

        public IEnumerable<string> SubCompParameters(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => BaseType + " " + c);
        public string SubCompParameterString(int start, int end) => SubCompParameters(start, end).CommaSeparated();
        public IEnumerable<string> SubCompArgs(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => c.ToString());
        public string SubCompArgString(int start, int end) => SubCompArgs(start, end).CommaSeparated();

        public SwizzleType SwizzleType => new SwizzleType { BaseType = BaseType, BaseName = Name, Components = Components, Name = "swizzle_" + Name, BaseTypeInfo = BaseTypeInfo };

        public string Comparer(string val) => IsGeneric ?
            string.Format("EqualityComparer<T>.Default.Equals({0}, rhs.{0})", val) :
            string.Format("{0}.Equals(rhs.{0})", val);

        public string HashCodeOf(string val) => IsGeneric ? string.Format("EqualityComparer<T>.Default.GetHashCode({0})", val) : string.Format("{0}.GetHashCode()", val);

        private IEnumerable<string> Constructor(string comment, string args, IEnumerable<string> assignments)
        {
            foreach (var line in comment.AsComment())
                yield return line;
            yield return string.Format("public {0}({1})", ClassName, args);
            yield return "{";
            var it = assignments.GetEnumerator();
            foreach (var c in CompString)
                yield return string.Format("this.{0} = {1};", c, it.MoveNext() ? it.Current : DefaultValue).Indent();
            yield return "}";
        }

        public string HashCodeFor(int c) => (c == 0 ? "" : string.Format("(({0}) * {1}) ^ ", HashCodeFor(c - 1), BaseTypeInfo.HashCodeMultiplier)) + HashCodeOf(ArgOf(c).ToString());

        public string NestedBiFuncFor(string format, int c, Func<int, string> argOf) => c == 0 ? argOf(c) : string.Format(format, NestedBiFuncFor(format, c - 1, argOf), argOf(c));

        public string TypeCast(BaseTypeInfo otherType, string c)
        {
            if (otherType.HasArithmetics && BaseTypeInfo.HasLogicOps)
                return string.Format("{0} ? {1} : {2}", c, otherType.OneValue, otherType.ZeroValue);

            if (otherType.HasLogicOps && BaseTypeInfo.HasArithmetics)
                return string.Format("{0} != {1}", c, BaseTypeInfo.ZeroValue);

            return string.Format("({0}){1}", otherType.Name, c);
        }

        public string ComponentWiseOperator(string op)
            => string.Format("public static {0} operator{2}({0} lhs, {0} rhs) => new {0}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op);

        public string ComponentWiseOperator(string op, string internalOp)
            => string.Format("public static {0} operator{2}({0} lhs, {0} rhs) => new {0}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, internalOp)).CommaSeparated(), op);

        public string ComponentWiseOperatorScalar(string op, string scalarType)
            => string.Format("public static {0} operator{2}({0} lhs, {3} rhs) => new {0}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs", c, op)).CommaSeparated(), op, scalarType);

        public string ComponentWiseOperatorScalarL(string op, string scalarType)
            => string.Format("public static {0} operator{2}({3} lhs, {0} rhs) => new {0}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, scalarType);

        public string ComparisonOperator(string op)
            => string.Format("public static bvec{3} operator{2}({0} lhs, {0} rhs) => new bvec{3}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, Components);

        public string ComparisonOperatorScalar(string op, string scalarType)
            => string.Format("public static bvec{3} operator{2}({0} lhs, {4} rhs) => new bvec{3}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs", c, op)).CommaSeparated(), op, Components, scalarType);

        public string ComparisonOperatorScalarL(string op, string scalarType)
            => string.Format("public static bvec{3} operator{2}({4} lhs, {0} rhs) => new bvec{3}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, Components, scalarType);

        protected override IEnumerable<string> Body
        {
            get
            {
                // components
                for (var i = 0; i < Components; ++i)
                {
                    foreach (var line in string.Format("{0}-component", "xyzw"[i]).AsComment()) yield return line;
                    yield return string.Format("public {0} {1};", BaseType, "xyzw"[i]);
                }

                // swizzle
                foreach (var line in "Returns an object that can be used for swizzling (e.g. swizzle.zy)".AsComment()) yield return line;
                yield return string.Format("public swizzle_{0} swizzle => new swizzle_{0}({1});", ClassNameThat, CompArgString);

                // predefs
                foreach (var line in "Predefined all-zero vector (DO NOT MODIFY)".AsComment()) yield return line;
                yield return string.Format("public static readonly {0} Zero = new {0}({1});", ClassNameThat, DefaultValue.RepeatTimes(Components).CommaSeparated());

                if (!string.IsNullOrEmpty(BaseTypeInfo.OneValue))
                {
                    foreach (var line in "Predefined all-ones vector (DO NOT MODIFY)".AsComment()) yield return line;
                    yield return string.Format("public static readonly {0} Ones = new {0}({1});", ClassNameThat, BaseTypeInfo.OneValue.RepeatTimes(Components).CommaSeparated());

                    for (var c = 0; c < Components; ++c)
                    {
                        foreach (var line in string.Format("Predefined unit-{0} vector (DO NOT MODIFY)", char.ToUpper(ArgOf(c))).AsComment()) yield return line;
                        yield return string.Format("public static readonly {0} Unit{1} = new {0}({2});", ClassNameThat, char.ToUpper(ArgOf(c)), c.ImpulseString(BaseTypeInfo.OneValue, DefaultValue, Components).CommaSeparated());
                    }
                }

                // values
                foreach (var line in "Returns an array with all values".AsComment()) yield return line;
                yield return string.Format("public {0}[] Values => new[] {{ {1} }};", BaseType, CompArgString);

                // ctors
                foreach (var line in Constructor("Component-wise constructor", CompParameterString, CompArgs)) yield return line;
                foreach (var line in Constructor("all-same-value constructor", BaseType + " v", "v".RepeatTimes(Components))) yield return line;

                for (var comps = 2; comps <= 4; ++comps)
                {
                    foreach (var line in Constructor("from-vector constructor (empty fields are zero/false)",
                        Name + comps + GenericSuffix + " v",
                        "v".DotComp(comps)))
                        yield return line;

                    for (var ucomps = comps; ucomps < Components; ++ucomps)
                        foreach (var line in Constructor("from-vector-and-value constructor (empty fields are zero/false)",
                            Name + comps + GenericSuffix + " v, " + SubCompParameterString(comps, ucomps),
                            "v".DotComp(comps).Concat(SubCompArgs(comps, ucomps))))
                            yield return line;
                }

                // explicit casts
                foreach (var oType in BaseTypeInfo.Types)
                {
                    var otherType = oType;
                    if (otherType.Generic != BaseTypeInfo.Generic)
                        continue; // cannot mix generic/non-generic

                    for (var comps = 2; comps <= 4; ++comps)
                    {
                        if (otherType == BaseTypeInfo && comps == Components)
                            continue; // same type and comps not useful

                        var commentAppendix = "";
                        if (comps > Components)
                            commentAppendix = " (Higher components are zeroed)";
                        var targetType = otherType.Prefix + "vec" + comps;
                        var targetTypeThat = otherType.Prefix + "vec" + comps + GenericSuffix;
                        foreach (var line in string.Format("Explicitly converts this to a {0}.{1}", targetType, commentAppendix).AsComment()) yield return line;
                        yield return string.Format("public static explicit operator {0}({1} v) => new {0}({2});", targetTypeThat, ClassNameThat, CompString.Select(c => TypeCast(otherType, "v." + c)).ExactlyN(comps, otherType.ZeroValue).CommaSeparated());
                    }
                }


                // IEnumerable
                foreach (var line in "Returns an enumerator that iterates through all components.".AsComment()) yield return line;
                yield return string.Format("public IEnumerator<{0}> GetEnumerator()", BaseType);
                yield return "{";
                foreach (var c in CompString)
                    yield return string.Format("yield return {0};", c).Indent();
                yield return "}";

                foreach (var line in "Returns an enumerator that iterates through all components.".AsComment()) yield return line;
                yield return "IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();";

                // IReadOnlyList
                foreach (var line in string.Format("Returns the number of components ({0}).", Components).AsComment()) yield return line;
                yield return string.Format("public int Count => {0};", Components);

                foreach (var line in "Gets/Sets a specific indexed component (a bit slower than direct access).".AsComment()) yield return line;
                yield return string.Format("public {0} this[int index]", BaseType);
                yield return "{";
                yield return "    get";
                yield return "    {";
                yield return "        switch (index)";
                yield return "        {";
                for (var c = 0; c < Components; ++c)
                    yield return string.Format("            case {0}: return {1};", c, "xyzw"[c]);
                yield return "            default: throw new ArgumentOutOfRangeException(\"index\");";
                yield return "        }";
                yield return "    }";
                yield return "    set";
                yield return "    {";
                yield return "        switch (index)";
                yield return "        {";
                for (var c = 0; c < Components; ++c)
                    yield return string.Format("            case {0}: this.{1} = value; break;", c, "xyzw"[c]);
                yield return "            default: throw new ArgumentOutOfRangeException(\"index\");";
                yield return "        }";
                yield return "    }";
                yield return "}";

                // Equality comparisons
                foreach (var line in "Returns true iff this equals rhs component-wise.".AsComment()) yield return line;
                yield return string.Format("public bool Equals({0} rhs) => {1};", ClassNameThat, CompString.Select(c => Comparer(c.ToString())).Aggregated(" && "));

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
                yield return "        return " + HashCodeFor(Components - 1) + ";";
                yield return "    }";
                yield return "}";

                // Logicals
                if (BaseTypeInfo.HasLogicOps)
                {
                    foreach (var line in "Returns the minimal component of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} MinElement => {1};", BaseType, CompString.Aggregated(" && "));

                    foreach (var line in "Returns the maximal component of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} MaxElement => {1};", BaseType, CompString.Aggregated(" || "));

                    foreach (var line in "Returns true if all component are true.".AsComment()) yield return line;
                    yield return string.Format("public {0} All => {1};", BaseType, CompString.Aggregated(" && "));

                    foreach (var line in "Returns true if any component is true.".AsComment()) yield return line;
                    yield return string.Format("public {0} Any => {1};", BaseType, CompString.Aggregated(" || "));

                    foreach (var line in "Executed a component-wise &&. (sorry for different overload but && cannot be overloaded directly)".AsComment()) yield return line;
                    yield return ComponentWiseOperator("&", "&&");

                    foreach (var line in "Executed a component-wise ||. (sorry for different overload but || cannot be overloaded directly)".AsComment()) yield return line;
                    yield return ComponentWiseOperator("|", "||");
                }

                // Arithmetics
                if (BaseTypeInfo.HasArithmetics)
                {
                    var lengthType = BaseTypeInfo.LengthType;

                    foreach (var line in "Returns the minimal component of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} MinElement => {1};", BaseType, NestedBiFuncFor("Math.Min({0}, {1})", Components - 1, ArgOfs));

                    foreach (var line in "Returns the maximal component of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} MaxElement => {1};", BaseType, NestedBiFuncFor("Math.Max({0}, {1})", Components - 1, ArgOfs));

                    foreach (var line in "Returns the euclidean length of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Length => ({0})Math.Sqrt({1});", lengthType, CompString.Select(c => c + "*" + c).Aggregated(" + "));

                    foreach (var line in "Returns the squared euclidean length of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} LengthSqr => {1};", lengthType, CompString.Select(c => c + "*" + c).Aggregated(" + "));

                    foreach (var line in "Returns the sum of all components.".AsComment()) yield return line;
                    yield return string.Format("public {0} Sum => {1};", lengthType, CompString.Aggregated(" + "));

                    foreach (var line in "Returns the euclidean norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm => ({0})Math.Sqrt({1});", lengthType, CompString.Select(c => c + "*" + c).Aggregated(" + "));

                    foreach (var line in "Returns the one-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm1 => {1};", lengthType, CompString.Select(AbsString).Aggregated(" + "));

                    foreach (var line in "Returns the two-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm2 => ({0})Math.Sqrt({1});", lengthType, CompString.Select(c => c + "*" + c).Aggregated(" + "));

                    foreach (var line in "Returns the max-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} NormMax => {1};", BaseType, NestedBiFuncFor("Math.Max({0}, {1})", Components - 1, c => AbsString(ArgOfs(c))));

                    foreach (var line in "Returns the p-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public double NormP(double p) => Math.Pow({0}, 1 / p);", CompString.Select(c => string.Format("Math.Pow({0}, p)", AbsString(c))).Aggregated(" + "));

                    /*var opDic = new Dictionary<string, string>();
                    opDic.Add("+", "+ (add)");
                    opDic.Add("-", "- (subtract)");
                    foreach (var kvp in opDic)
                    {
                        var op = kvp.Key;
                        var opComment = kvp.Value;
                    }*/

                    foreach (var line in "Executed a component-wise + (add).".AsComment()) yield return line;
                    yield return ComponentWiseOperator("+");
                    foreach (var line in "Executed a component-wise + (add) with a scalar.".AsComment()) yield return line;
                    yield return ComponentWiseOperatorScalar("+", BaseType);
                    foreach (var line in "Executed a component-wise + (add) with a scalar.".AsComment()) yield return line;
                    yield return ComponentWiseOperatorScalarL("+", BaseType);

                    foreach (var line in "Executed a component-wise - (subtract).".AsComment()) yield return line;
                    yield return ComponentWiseOperator("-");
                    foreach (var line in "Executed a component-wise - (subtract) with a scalar.".AsComment()) yield return line;
                    yield return ComponentWiseOperatorScalar("-", BaseType);
                    foreach (var line in "Executed a component-wise - (subtract) with a scalar.".AsComment()) yield return line;
                    yield return ComponentWiseOperatorScalarL("-", BaseType);

                    foreach (var line in "Executed a component-wise / (divide).".AsComment()) yield return line;
                    yield return ComponentWiseOperator("/");
                    foreach (var line in "Executed a component-wise / (divide) with a scalar.".AsComment()) yield return line;
                    yield return ComponentWiseOperatorScalar("/", BaseType);
                    foreach (var line in "Executed a component-wise / (divide) with a scalar.".AsComment()) yield return line;
                    yield return ComponentWiseOperatorScalarL("/", BaseType);

                    foreach (var line in "Executed a component-wise * (multiply).".AsComment()) yield return line;
                    yield return ComponentWiseOperator("*");
                    foreach (var line in "Executed a component-wise * (multiply) with a scalar.".AsComment()) yield return line;
                    yield return ComponentWiseOperatorScalar("*", BaseType);
                    foreach (var line in "Executed a component-wise * (multiply) with a scalar.".AsComment()) yield return line;
                    yield return ComponentWiseOperatorScalarL("*", BaseType);

                    if (BaseTypeInfo.IsInteger)
                    {
                        foreach (var line in "Executed a component-wise % (mod).".AsComment()) yield return line;
                        yield return ComponentWiseOperator("%");
                        foreach (var line in "Executed a component-wise % (mod) with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar("%", BaseType);
                        foreach (var line in "Executed a component-wise % (mod) with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalarL("%", BaseType);

                        foreach (var line in "Executed a component-wise ^ (xor).".AsComment()) yield return line;
                        yield return ComponentWiseOperator("^");
                        foreach (var line in "Executed a component-wise ^ (xor) with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar("^", BaseType);
                        foreach (var line in "Executed a component-wise ^ (xor) with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalarL("^", BaseType);

                        foreach (var line in "Executed a component-wise | (bitwise-or).".AsComment()) yield return line;
                        yield return ComponentWiseOperator("|");
                        foreach (var line in "Executed a component-wise | (bitwise-or) with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar("|", BaseType);
                        foreach (var line in "Executed a component-wise | (bitwise-or) with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalarL("|", BaseType);

                        foreach (var line in "Executed a component-wise & (bitwise-or).".AsComment()) yield return line;
                        yield return ComponentWiseOperator("&");
                        foreach (var line in "Executed a component-wise | (bitwise-or) with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar("&", BaseType);
                        foreach (var line in "Executed a component-wise | (bitwise-or) with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalarL("&", BaseType);

                        foreach (var line in "Executed a component-wise left-shift with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar("<<", "int");

                        foreach (var line in "Executed a component-wise right-shift with a scalar.".AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalar(">>", "int");
                    }

                    foreach (var line in "Executed a component-wise lesser-than comparison.".AsComment()) yield return line;
                    yield return ComparisonOperator("<");
                    foreach (var line in "Executed a component-wise lesser-than comparison with a scalar.".AsComment()) yield return line;
                    yield return ComparisonOperatorScalar("<", BaseType);
                    foreach (var line in "Executed a component-wise lesser-than comparison with a scalar.".AsComment()) yield return line;
                    yield return ComparisonOperatorScalarL("<", BaseType);

                    foreach (var line in "Executed a component-wise lesser-or-equal comparison.".AsComment()) yield return line;
                    yield return ComparisonOperator("<=");
                    foreach (var line in "Executed a component-wise lesser-or-equal comparison with a scalar.".AsComment()) yield return line;
                    yield return ComparisonOperatorScalar("<=", BaseType);
                    foreach (var line in "Executed a component-wise lesser-or-equal comparison with a scalar.".AsComment()) yield return line;
                    yield return ComparisonOperatorScalarL("<=", BaseType);

                    foreach (var line in "Executed a component-wise greater-than comparison.".AsComment()) yield return line;
                    yield return ComparisonOperator(">");
                    foreach (var line in "Executed a component-wise greater-than comparison with a scalar.".AsComment()) yield return line;
                    yield return ComparisonOperatorScalar(">", BaseType);
                    foreach (var line in "Executed a component-wise greater-than comparison with a scalar.".AsComment()) yield return line;
                    yield return ComparisonOperatorScalarL(">", BaseType);

                    foreach (var line in "Executed a component-wise greater-or-equal comparison.".AsComment()) yield return line;
                    yield return ComparisonOperator(">=");
                    foreach (var line in "Executed a component-wise greater-or-equal comparison with a scalar.".AsComment()) yield return line;
                    yield return ComparisonOperatorScalar(">=", BaseType);
                    foreach (var line in "Executed a component-wise greater-or-equal comparison with a scalar.".AsComment()) yield return line;
                    yield return ComparisonOperatorScalarL(">=", BaseType);

                    if (!BaseTypeInfo.IsInteger)
                    {
                        foreach (var line in "Returns a copy of this vector with length one (undefined if this has zero length).".AsComment()) yield return line;
                        yield return string.Format("public {0} Normalized => this / Length;", ClassNameThat);

                        foreach (var line in "Returns a copy of this vector with length one (returns zero if length is zero).".AsComment()) yield return line;
                        yield return string.Format("public {0} NormalizedSafe => this == Zero ? Zero : this / Length;", ClassNameThat);
                    }
                }
            }
        }

    }
}
