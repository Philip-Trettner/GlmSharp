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


        public char ArgOf(int c) => "xyzw"[c];
        public string ArgOfs(int c) => "xyzw"[c].ToString();

        public IEnumerable<string> SubCompParameters(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => BaseType + " " + c);
        public string SubCompParameterString(int start, int end) => SubCompParameters(start, end).CommaSeparated();
        public IEnumerable<string> SubCompArgs(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => c.ToString());
        public string SubCompArgString(int start, int end) => SubCompArgs(start, end).CommaSeparated();

        public SwizzleType SwizzleType => new SwizzleType { BaseType = BaseType, BaseName = Name, Components = Components, Name = "swizzle_" + Name, BaseTypeInfo = BaseTypeInfo };


        private IEnumerable<string> Constructor(string comment, string args, IEnumerable<string> assignments)
        {
            foreach (var line in comment.AsComment())
                yield return line;
            yield return string.Format("public {0}({1})", ClassName, args);
            yield return "{";
            var it = assignments.GetEnumerator();
            foreach (var c in CompString)
                yield return string.Format("this.{0} = {1};", c, it.MoveNext() ? it.Current : ZeroValue).Indent();
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
                yield return string.Format("public static readonly {0} Zero = new {0}({1});", ClassNameThat, ZeroValue.RepeatTimes(Components).CommaSeparated());

                if (!string.IsNullOrEmpty(BaseTypeInfo.OneValue))
                {
                    foreach (var line in "Predefined all-ones vector (DO NOT MODIFY)".AsComment()) yield return line;
                    yield return string.Format("public static readonly {0} Ones = new {0}({1});", ClassNameThat, BaseTypeInfo.OneValue.RepeatTimes(Components).CommaSeparated());

                    for (var c = 0; c < Components; ++c)
                    {
                        foreach (var line in string.Format("Predefined unit-{0} vector (DO NOT MODIFY)", char.ToUpper(ArgOf(c))).AsComment()) yield return line;
                        yield return string.Format("public static readonly {0} Unit{1} = new {0}({2});", ClassNameThat, char.ToUpper(ArgOf(c)), c.ImpulseString(BaseTypeInfo.OneValue, ZeroValue, Components).CommaSeparated());
                    }
                }

                if (BaseTypeInfo.Complex)
                {
                    foreach (var line in "Predefined all-imaginary-ones vector (DO NOT MODIFY)".AsComment()) yield return line;
                    yield return string.Format("public static readonly {0} ImaginaryOnes = new {0}({1});", ClassNameThat, "Complex.ImaginaryOne".RepeatTimes(Components).CommaSeparated());

                    for (var c = 0; c < Components; ++c)
                    {
                        foreach (var line in string.Format("Predefined unit-imaginary-{0} vector (DO NOT MODIFY)", char.ToUpper(ArgOf(c))).AsComment()) yield return line;
                        yield return string.Format("public static readonly {0} ImaginaryUnit{1} = new {0}({2});", ClassNameThat, char.ToUpper(ArgOf(c)), c.ImpulseString("Complex.ImaginaryOne", ZeroValue, Components).CommaSeparated());
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

                // ToString
                foreach (var line in "Returns a string representation of this vector using ', ' as a seperator.".AsComment()) yield return line;
                yield return string.Format("public override string ToString() => ToString(\", \");");

                foreach (var line in "Returns a string representation of this vector using a provided seperator.".AsComment()) yield return line;
                yield return string.Format("public string ToString(string sep) => {0};", CompString.Aggregated(" + sep + "));

                if (!BaseTypeInfo.Generic)
                {
                    foreach (var line in "Returns a string representation of this vector using a provided seperator and a format provider for each component.".AsComment()) yield return line;
                    yield return string.Format("public string ToString(string sep, IFormatProvider provider) => {0};", CompString.Select(c => c + ".ToString(provider)").Aggregated(" + sep + "));

                    if (BaseTypeInfo.HasFormatString)
                    {
                        foreach (var line in "Returns a string representation of this vector using a provided seperator and a format for each component.".AsComment()) yield return line;
                        yield return string.Format("public string ToString(string sep, string format) => {0};", CompString.Select(c => c + ".ToString(format)").Aggregated(" + sep + "));

                        foreach (var line in "Returns a string representation of this vector using a provided seperator and a format and format provider for each component.".AsComment()) yield return line;
                        yield return string.Format("public string ToString(string sep, string format, IFormatProvider provider) => {0};", CompString.Select(c => c + ".ToString(format, provider)").Aggregated(" + sep + "));
                    }
                }

                // TODO: BaseType stuff

                // Complex properties
                if (BaseTypeInfo.Complex)
                {
                    foreach (var line in "Returns a vector containing component-wise magnitudes.".AsComment()) yield return line;
                    yield return string.Format("public dvec{0} Magnitude => new dvec{0}({1});", Components, CompString.Select(c => c + ".Magnitude").CommaSeparated());

                    foreach (var line in "Returns a vector containing component-wise phases.".AsComment()) yield return line;
                    yield return string.Format("public dvec{0} Phase => new dvec{0}({1});", Components, CompString.Select(c => c + ".Phase").CommaSeparated());

                    foreach (var line in "Returns a vector containing component-wise imaginary parts.".AsComment()) yield return line;
                    yield return string.Format("public dvec{0} Imaginary => new dvec{0}({1});", Components, CompString.Select(c => c + ".Imaginary").CommaSeparated());

                    foreach (var line in "Returns a vector containing component-wise real parts.".AsComment()) yield return line;
                    yield return string.Format("public dvec{0} Real => new dvec{0}({1});", Components, CompString.Select(c => c + ".Real").CommaSeparated());
                }

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

                    // binary arithmetic operators
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

                    // unary arithmetic operators
                    foreach (var kvp in new Dictionary<string, string>
                    {
                        {"+", "+ (add)"},
                        {"-", "- (subtract)"},
                    })
                    {
                        var op = kvp.Key;
                        var opComment = kvp.Value;

                        if (op == "-" && !BaseTypeInfo.RequiredAbs)
                            continue; // unsigned

                        foreach (var line in string.Format("Executes a component-wise unary {0}.", opComment).AsComment()) yield return line;
                        if (op == "+")
                            yield return string.Format("public static {0} operator{1}({0} v) => v;", ClassNameThat, op);
                        else
                            yield return string.Format("public static {0} operator{1}({0} v) => new {0}({2});", ClassNameThat, op, CompString.Select(c => op + "v." + c).CommaSeparated());
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

                        foreach (var line in "Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types).".AsComment()) yield return line;
                        yield return string.Format("public static {0} FromAngle(double angleInRad) => new {0}(({1})Math.Cos(angleInRad), ({1})Math.Sin(angleInRad));", ClassNameThat, BaseType);

                        foreach (var line in "Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).".AsComment()) yield return line;
                        yield return string.Format("public {0} Rotated(double angleInRad) => ({0})(dvec2.FromAngle(Angle) * (double)Length);", ClassNameThat);
                    }

                    // component-wise unary functions
                    foreach (var kvp in new Dictionary<string, Func<string, string>>
                    {
                        {"Abs", AbsString},
                    })
                    {
                        var op = kvp.Key;
                        var opFunc = kvp.Value;

                        var retType = ClassNameThat;
                        if (op == "Abs" && !string.IsNullOrEmpty(BaseTypeInfo.AbsOverrideType))
                            retType = BaseTypeInfo.AbsOverrideTypePrefix + "vec" + Components + GenericSuffix;

                        foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("v." + c)).CommaSeparated());
                    }

                    if (BaseTypeInfo.IsFloatingPoint)
                        foreach (var kvp in new Dictionary<string, Func<string, string>>
                        {
                            {"Step", s => string.Format("{0} >= {1} ? {2} : {1}", s, ZeroValue, OneValue)},
                            {"Acos", s => string.Format("({1})Math.Acos((double){0})", s, BaseType)},
                            {"Asin", s => string.Format("({1})Math.Asin((double){0})", s, BaseType)},
                            {"Atan", s => string.Format("({1})Math.Atan((double){0})", s, BaseType)},
                            {"Cos", s => string.Format("({1})Math.Cos((double){0})", s, BaseType)},
                            {"Cosh", s => string.Format("({1})Math.Cosh((double){0})", s, BaseType)},
                            {"Exp", s => string.Format("({1})Math.Exp((double){0})", s, BaseType)},
                            {"Log", s => string.Format("({1})Math.Log((double){0})", s, BaseType)},
                            {"Log2", s => string.Format("({1})Math.Log((double){0}, 2)", s, BaseType)},
                            {"Log10", s => string.Format("({1})Math.Log10((double){0})", s, BaseType)},
                            {"Floor", s => string.Format("({1})Math.Floor({0})", s, BaseType)},
                            {"Ceiling", s => string.Format("({1})Math.Ceiling({0})", s, BaseType)},
                            {"Round", s => string.Format("({1})Math.Round({0})", s, BaseType)},
                            {"Sin", s => string.Format("({1})Math.Sin((double){0})", s, BaseType)},
                            {"Sinh", s => string.Format("({1})Math.Sinh((double){0})", s, BaseType)},
                            {"Sqrt", s => string.Format("({1})Math.Sqrt((double){0})", s, BaseType)},
                            {"Tan", s => string.Format("({1})Math.Tan((double){0})", s, BaseType)},
                            {"Tanh", s => string.Format("({1})Math.Tanh((double){0})", s, BaseType)},
                            {"Truncate", s => string.Format("({1})Math.Truncate((double){0})", s, BaseType)},
                            {"Sign", s => string.Format("Math.Sign({0})", s)},
                        })
                        {
                            var op = kvp.Key;
                            var opFunc = kvp.Value;

                            var retType = ClassNameThat;

                            if (op == "Sign")
                                retType = "ivec" + Components;

                            foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("v." + c)).CommaSeparated());
                        }

                    if (BaseTypeInfo.Complex)
                    {
                        foreach (var kvp in new Dictionary<string, Func<string, string>>
                        {
                            {"Acos", s => string.Format("Complex.Acos({0})", s)},
                            {"Asin", s => string.Format("Complex.Asin({0})", s)},
                            {"Atan", s => string.Format("Complex.Atan({0})", s)},
                            {"Cos", s => string.Format("Complex.Cos({0})", s)},
                            {"Cosh", s => string.Format("Complex.Cosh({0})", s)},
                            {"Exp", s => string.Format("Complex.Exp({0})", s)},
                            {"Log", s => string.Format("Complex.Log({0})", s)},
                            {"Log2", s => string.Format("Complex.Log({0}, 2.0)", s)},
                            {"Log10", s => string.Format("Complex.Log10({0})", s)},
                            {"Reciprocal", s => string.Format("Complex.Reciprocal({0})", s)},
                            {"Sin", s => string.Format("Complex.Sin({0})", s)},
                            {"Sinh", s => string.Format("Complex.Sinh({0})", s)},
                            {"Sqrt", s => string.Format("Complex.Sqrt({0})", s)},
                            {"Tan", s => string.Format("Complex.Tan({0})", s)},
                            {"Tanh", s => string.Format("Complex.Tanh({0})", s)},
                            {"Conjugate", s => string.Format("Complex.Conjugate({0})", s)},
                        })
                        {
                            var op = kvp.Key;
                            var opFunc = kvp.Value;

                            var retType = ClassNameThat;

                            foreach (var line in string.Format("Returns a component-wise executed complex {0}.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("v." + c)).CommaSeparated());
                        }

                        foreach (var kvp in new Dictionary<string, Func<string, string, string>>
                        {
                            {"Pow", (s1, s2) => string.Format("Complex.Pow({0}, {1})", s1, s2)},
                            {"Log", (s1, s2) => string.Format("Complex.Log({0}, {1})", s1, s2)},
                        })
                        {
                            var op = kvp.Key;
                            var opFunc = kvp.Value;

                            var retType = ClassNameThat;

                            var complexRhs = op != "Log";

                            // complex rhs
                            if (complexRhs)
                            {
                                foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                                yield return string.Format("public static {0} {1}({2} lhs, {2} rhs) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("lhs." + c, "rhs." + c)).CommaSeparated());

                                foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                                yield return string.Format("public static {0} {1}({2} v, {4} s) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("v." + c, "s")).CommaSeparated(), BaseType);

                                foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                                yield return string.Format("public static {0} {1}({4} s, {2} v) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("s", "v." + c)).CommaSeparated(), BaseType);

                                foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                                yield return string.Format("public static {0} {1}({4} s, {2} v) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("s", "v." + c)).CommaSeparated(), "double");
                            }

                            // double rhs
                            foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} lhs, {4} rhs) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("lhs." + c, "rhs." + c)).CommaSeparated(), "dvec" + Components);

                            foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} v, {4} s) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("v." + c, "s")).CommaSeparated(), "double");
                        }

                        // from polar coordinates
                        foreach (var line in "Returns a component-wise executed FromPolarCoordinates.".AsComment()) yield return line;
                        yield return string.Format("public static {0} FromPolarCoordinates({1} lhs, {1} rhs) => new {0}({2});", ClassNameThat, "dvec" + Components, CompString.Select(c => string.Format("Complex.FromPolarCoordinates({0}, {1})", "lhs." + c, "rhs." + c)).CommaSeparated());

                        foreach (var line in "Returns a component-wise executed FromPolarCoordinates with a scalar.".AsComment()) yield return line;
                        yield return string.Format("public static {0} FromPolarCoordinates(double s, {1} v) => new {0}({2});", ClassNameThat, "dvec" + Components, CompString.Select(c => string.Format("Complex.FromPolarCoordinates({0}, {1})", "s", "v." + c)).CommaSeparated());

                        foreach (var line in "Returns a component-wise executed FromPolarCoordinates with a scalar.".AsComment()) yield return line;
                        yield return string.Format("public static {0} FromPolarCoordinates({1} v, double s) => new {0}({2});", ClassNameThat, "dvec" + Components, CompString.Select(c => string.Format("Complex.FromPolarCoordinates({0}, {1})", "v." + c, "s")).CommaSeparated());
                    }

                    foreach (var kvp in new Dictionary<string, Func<string, string>>
                    {
                        {"Sqr", s => string.Format("{0} * {0}", s)},
                        {"Pow2", s => string.Format("{0} * {0}", s)},
                    })
                    {
                        var op = kvp.Key;
                        var opFunc = kvp.Value;

                        var retType = ClassNameThat;

                        foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("v." + c)).CommaSeparated());
                    }

                    if (!BaseTypeInfo.Complex)
                        foreach (var kvp in new Dictionary<string, Func<string, string, string>>
                        {
                            {"Max", (s1, s2) => string.Format("Math.Max({0}, {1})", s1, s2)},
                            {"Min", (s1, s2) => string.Format("Math.Min({0}, {1})", s1, s2)},
                            {"Pow", (s1, s2) => string.Format("({2})Math.Pow((double){0}, (double){1})", s1, s2, BaseType)},
                            {"Log", (s1, s2) => string.Format("({2})Math.Log((double){0}, (double){1})", s1, s2, BaseType)},
                        })
                        {
                            var op = kvp.Key;
                            var opFunc = kvp.Value;

                            var retType = ClassNameThat;

                            foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} lhs, {2} rhs) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("lhs." + c, "rhs." + c)).CommaSeparated());

                            foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} v, {4} s) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("v." + c, "s")).CommaSeparated(), BaseType);

                            foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({4} s, {2} v) => new {0}({3});", retType, op, ClassNameThat, CompString.Select(c => opFunc("s", "v." + c)).CommaSeparated(), BaseType);
                        }


                    /*

inline vec3 clamp(vec3 const& v, vec3 const& mi, vec3 const& ma) { return vec3(clamp(v.x, mi.x, ma.x), clamp(v.y, mi.y, ma.y), clamp(v.z, mi.z, ma.z)); }
inline vec3 mix(vec3 const& mi, vec3 const& ma, vec3 const& a) { return vec3(mix(mi.x, ma.x, a.x), mix(mi.y, ma.y, a.y), mix(mi.z, ma.z, a.z)); }
inline vec3 mix(vec3 const& mi, vec3 const& ma, float a) { return vec3(mix(mi.x, ma.x, a), mix(mi.y, ma.y, a), mix(mi.z, ma.z, a)); }
inline vec3 smoothstep(vec3 const& edge0, vec3 const& edge1, vec3 const& v) { return vec3(smoothstep(edge0.x, edge1.x, v.x), smoothstep(edge0.y, edge1.y, v.y), smoothstep(edge0.z, edge1.z, v.z)); }

// bool vectors
inline bvec3 isfinite(vec3 const& v) { return bvec3(isfinite(v.x), isfinite(v.y), isfinite(v.z)); }
inline bvec3 isnan(vec3 const& v) { return bvec3(isnan(v.x), isnan(v.y), isnan(v.z)); }
inline bvec3 isinf(vec3 const& v) { return bvec3(isinf(v.x), isinf(v.y), isinf(v.z)); }
inline bvec3 equal(vec3 const& v1, vec3 const& v2) { return bvec3(equal(v1.x, v2.x), equal(v1.y, v2.y), equal(v1.z, v2.z)); }
inline bvec3 greaterThan(vec3 const& v1, vec3 const& v2) { return bvec3(greaterThan(v1.x, v2.x), greaterThan(v1.y, v2.y), greaterThan(v1.z, v2.z)); }
inline bvec3 greaterThanEqual(vec3 const& v1, vec3 const& v2) { return bvec3(greaterThanEqual(v1.x, v2.x), greaterThanEqual(v1.y, v2.y), greaterThanEqual(v1.z, v2.z)); }
inline bvec3 lessThan(vec3 const& v1, vec3 const& v2) { return bvec3(lessThan(v1.x, v2.x), lessThan(v1.y, v2.y), lessThan(v1.z, v2.z)); }
inline bvec3 lessThanEqual(vec3 const& v1, vec3 const& v2) { return bvec3(lessThanEqual(v1.x, v2.x), lessThanEqual(v1.y, v2.y), lessThanEqual(v1.z, v2.z)); }
                    */
                }
            }
        }

    }
}
