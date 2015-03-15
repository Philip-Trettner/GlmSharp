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

        public string AbsString(string s) => BaseTypeInfo.RequiredAbs ? (BaseTypeInfo.Complex ? s + ".Magnitude" : string.Format("Math.Abs({0})", s)) : s;
        public string AbsString(char s) => BaseTypeInfo.RequiredAbs ? (BaseTypeInfo.Complex ? s + ".Magnitude" : string.Format("Math.Abs({0})", s)) : s.ToString();

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

        public string SqrOf(string s) => BaseTypeInfo.Complex ? s + ".LengthSqr()" : s + "*" + s;
        public string SqrOf(char s) => SqrOf(s.ToString());

        public string SqrtOf(string s) => BaseTypeInfo.Decimal ? s + ".Sqrt()" : string.Format("Math.Sqrt({0})", s);
        public string SqrtOf(char s) => SqrOf(s.ToString());

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

        public string ComponentWiseOperatorForeign(string op, string returnType)
            => string.Format("public static {3} operator{2}({0} lhs, {3} rhs) => new {3}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, returnType);
        public string ComponentWiseOperatorForeignL(string op, string returnType)
            => string.Format("public static {3} operator{2}({3} lhs, {0} rhs) => new {3}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, returnType);

        public string ComponentWiseOperatorForeignScalar(string op, string scalarType, string returnType)
            => string.Format("public static {4} operator{2}({0} lhs, {3} rhs) => new {4}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs", c, op)).CommaSeparated(), op, scalarType, returnType);

        public string ComponentWiseOperatorForeignScalarL(string op, string scalarType, string returnType)
            => string.Format("public static {4} operator{2}({3} lhs, {0} rhs) => new {4}({1});", ClassNameThat,
                    CompString.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, scalarType, returnType);

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

                // implicit upcasts
                var implicits = new HashSet<BaseTypeInfo>();
                var upcasts = BaseTypeInfo.Upcasts;
                foreach (var ukvp in upcasts.Where(k => k.Key == BaseTypeInfo))
                {
                    var otherType = ukvp.Value;
                    implicits.Add(otherType);

                    var targetType = otherType.Prefix + "vec" + Components;
                    var targetTypeThat = otherType.Prefix + "vec" + Components + GenericSuffix;
                    foreach (var line in string.Format("Implicitly converts this to a {0}.", targetType).AsComment()) yield return line;
                    yield return string.Format("public static implicit operator {0}({1} v) => new {0}({2});", targetTypeThat, ClassNameThat, CompString.Select(c => TypeCast(otherType, "v." + c)).ExactlyN(Components, otherType.ZeroValue).CommaSeparated());
                }

                // explicit casts
                foreach (var oType in BaseTypeInfo.Types)
                {
                    var otherType = oType;
                    if (otherType.Generic != BaseTypeInfo.Generic)
                        continue; // cannot mix generic/non-generic
                    if (BaseTypeInfo.Complex && !otherType.Complex)
                        continue; // cannot "downcast" complex type

                    for (var comps = 2; comps <= 4; ++comps)
                    {
                        if (otherType == BaseTypeInfo && comps == Components)
                            continue; // same type and comps not useful

                        if (comps == Components && implicits.Contains(otherType))
                            continue; // already has an implicit conversion

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
                        foreach (var line in "Returns the minimal component of this vector.".AsComment()) yield return line;
                        yield return string.Format("public {0} MinElement => {1};", BaseType, NestedBiFuncFor("Math.Min({0}, {1})", Components - 1, ArgOfs));

                        foreach (var line in "Returns the maximal component of this vector.".AsComment()) yield return line;
                        yield return string.Format("public {0} MaxElement => {1};", BaseType, NestedBiFuncFor("Math.Max({0}, {1})", Components - 1, ArgOfs));
                    }

                    foreach (var line in "Returns the euclidean length of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Length => ({0}){1};", lengthType, SqrtOf(CompString.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the squared euclidean length of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} LengthSqr => {1};", lengthType, CompString.Select(SqrOf).Aggregated(" + "));

                    foreach (var line in "Returns the sum of all components.".AsComment()) yield return line;
                    yield return string.Format("public {0} Sum => {1};", BaseType, CompString.Aggregated(" + "));

                    foreach (var line in "Returns the euclidean norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm => ({0}){1};", lengthType, SqrtOf(CompString.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the one-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm1 => {1};", lengthType, CompString.Select(AbsString).Aggregated(" + "));

                    foreach (var line in "Returns the two-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm2 => ({0}){1};", lengthType, SqrtOf(CompString.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the max-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} NormMax => {1};", BaseType, NestedBiFuncFor("Math.Max({0}, {1})", Components - 1, c => AbsString(ArgOfs(c))));

                    foreach (var line in "Returns the p-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public double NormP(double p) => Math.Pow({0}, 1 / p);", CompString.Select(c => string.Format("Math.Pow((double){0}, p)", AbsString(c))).Aggregated(" + "));

                    // arithmetic operators
                    foreach (var kvp in new Dictionary<string, string>
                    {
                        {"+", "+ (add)"},
                        {"-", "- (subtract)"},
                        {"/", "/ (divide)"},
                        {"*", "* (multiply)"}
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

                        // upcasts
                        foreach (var ukvp in upcasts.Where(k => k.Key == BaseTypeInfo))
                        {
                            var upType = ukvp.Value;
                            var foreignType = upType.Prefix + "vec" + Components + GenericSuffix;

                            foreach (var line in string.Format("Executes a component-wise {0} (upcast to {1}).", opComment, foreignType).AsComment()) yield return line;
                            yield return ComponentWiseOperatorForeign(op, foreignType);
                            foreach (var line in string.Format("Executes a component-wise {0} (upcast to {1}).", opComment, foreignType).AsComment()) yield return line;
                            yield return ComponentWiseOperatorForeignL(op, foreignType);
                            foreach (var line in string.Format("Executes a component-wise {0} with a scalar (upcast to {1}).", opComment, foreignType).AsComment()) yield return line;
                            yield return ComponentWiseOperatorForeignScalar(op, upType.Name, foreignType);
                            foreach (var line in string.Format("Executes a component-wise {0} with a scalar (upcast to {1}).", opComment, foreignType).AsComment()) yield return line;
                            yield return ComponentWiseOperatorForeignScalarL(op, upType.Name, foreignType);
                        }
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

                    // normalized
                    if (!BaseTypeInfo.IsInteger)
                    {
                        foreach (var line in "Returns a copy of this vector with length one (undefined if this has zero length).".AsComment()) yield return line;
                        yield return string.Format("public {0} Normalized => this / Length;", ClassNameThat);

                        foreach (var line in "Returns a copy of this vector with length one (returns zero if length is zero).".AsComment()) yield return line;
                        yield return string.Format("public {0} NormalizedSafe => this == Zero ? Zero : this / Length;", ClassNameThat);
                    }

                    // dot
                    foreach (var line in "Returns the inner product (dot product, scalar product) of the two vectors.".AsComment()) yield return line;
                    yield return string.Format("public static {0} Dot({1} lhs, {1} rhs) => {2};", BaseType, ClassNameThat, CompString.Select(c => string.Format("lhs.{0} * rhs.{0}", c)).Aggregated(" + "));

                    // distance
                    foreach (var line in "Returns the euclidean distance between the two vectors.".AsComment()) yield return line;
                    yield return string.Format("public static {0} Distance({1} lhs, {1} rhs) => (lhs - rhs).Length;", lengthType, ClassNameThat);

                    foreach (var line in "Returns the squared euclidean distance between the two vectors.".AsComment()) yield return line;
                    yield return string.Format("public static {0} DistanceSqr({1} lhs, {1} rhs) => (lhs - rhs).LengthSqr;", lengthType, ClassNameThat);

                    // cross
                    switch (Components)
                    {
                        case 3:
                            foreach (var line in "Returns the outer product (cross product, vector product) of the two vectors.".AsComment()) yield return line;
                            yield return string.Format("public static {0} Cross({0} l, {0} r) => new {0}(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);", ClassNameThat);
                            break;
                        case 2:
                            foreach (var line in "Returns the length of the outer product (cross product, vector product) of the two vectors.".AsComment()) yield return line;
                            yield return string.Format("public static {1} Cross({0} l, {0} r) => l.x * r.y - l.y * r.x;", ClassNameThat, BaseType);
                            break;
                    }

                    // angle
                    if (Components == 2 && !BaseTypeInfo.Complex)
                    {
                        foreach (var line in "Returns the vector angle (atan2(y, x)) in radians.".AsComment()) yield return line;
                        yield return string.Format("public double Angle => Math.Atan2((double)y, (double)x);");

                        foreach (var line in "Returns a unit 2D vector with a given angle in radians.".AsComment()) yield return line;
                        yield return string.Format("public static {0} FromAngle(double angleInRad) => new {0}(({1})Math.Cos(angleInRad), ({1})Math.Sin(angleInRad));", ClassNameThat, BaseType);

                        foreach (var line in "Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).".AsComment()) yield return line;
                        yield return string.Format("public {0} Rotated(double angleInRad) => ({0})(dvec2.FromAngle(Angle) * (double)Length);", ClassNameThat);
                    }
                }
            }
        }

    }
}
