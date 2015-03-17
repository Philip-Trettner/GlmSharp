using System;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharpGenerator.Types
{
    class VectorType : AbstractType
    {
        public int Components { get; set; } = 3;
        public override string Name => BaseName + Components;

        public string CompString => "xyzw".Substring(0, Components);

        public override string TypeComment => string.Format("A vector of type {0} with {1} components.", BaseTypeName, Components);

        public override IEnumerable<string> BaseClasses
        {
            get
            {
                yield return string.Format("IReadOnlyList<{0}>", BaseTypeName);
                yield return string.Format("IEquatable<{0}>", NameThat);
            }
        }

        public string CompParameterString => CompString.Select(c => BaseTypeName + " " + c).CommaSeparated();
        public IEnumerable<string> CompParameters => CompString.Select(c => BaseTypeName + " " + c);

        public string CompArgString => CompString.CommaSeparated();
        public IEnumerable<string> CompArgs => CompString.Select(c => c.ToString());


        public char ArgOf(int c) => "xyzw"[c];
        public string ArgOfs(int c) => "xyzw"[c].ToString();

        public IEnumerable<string> SubCompParameters(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => BaseTypeName + " " + c);
        public string SubCompParameterString(int start, int end) => SubCompParameters(start, end).CommaSeparated();
        public IEnumerable<string> SubCompArgs(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => c.ToString());
        public string SubCompArgString(int start, int end) => SubCompArgs(start, end).CommaSeparated();

        public SwizzleType SwizzleType => new SwizzleType { OriginalTypeName = BaseName, Components = Components, BaseName = "swizzle_" + BaseName, BaseType = BaseType };


        private IEnumerable<string> Constructor(string comment, string args, IEnumerable<string> assignments)
        {
            foreach (var line in comment.AsComment())
                yield return line;
            yield return string.Format("public {0}({1})", Name, args);
            yield return "{";
            var it = assignments.GetEnumerator();
            foreach (var c in CompString)
                yield return string.Format("this.{0} = {1};", c, it.MoveNext() ? it.Current : ZeroValue).Indent();
            yield return "}";
        }

        public string HashCodeFor(int c) => (c == 0 ? "" : string.Format("(({0}) * {1}) ^ ", HashCodeFor(c - 1), BaseType.HashCodeMultiplier)) + HashCodeOf(ArgOf(c).ToString());

        public string NestedBiFuncFor(string format, int c, Func<int, string> argOf) => c == 0 ? argOf(c) : string.Format(format, NestedBiFuncFor(format, c - 1, argOf), argOf(c));

        public string TypeCast(BuiltinType otherType, string c)
        {
            if (otherType.HasArithmetics && BaseType.HasLogicOps)
                return string.Format("{0} ? {1} : {2}", c, otherType.OneValue, otherType.ZeroValue);

            if (otherType.HasLogicOps && BaseType.HasArithmetics)
                return string.Format("{0} != {1}", c, BaseType.ZeroValue);

            return string.Format("({0}){1}", otherType.Name, c);
        }


        public string ComponentWiseOperator(string op)
            => string.Format("public static {0} operator{2}({0} lhs, {0} rhs) => new {0}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op);

        public string ComponentWiseOperator(string op, string internalOp)
            => string.Format("public static {0} operator{2}({0} lhs, {0} rhs) => new {0}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, internalOp)).CommaSeparated(), op);

        public string ComponentWiseOperatorScalar(string op, string scalarType)
            => string.Format("public static {0} operator{2}({0} lhs, {3} rhs) => new {0}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs", c, op)).CommaSeparated(), op, scalarType);

        public string ComponentWiseOperatorScalarL(string op, string scalarType)
            => string.Format("public static {0} operator{2}({3} lhs, {0} rhs) => new {0}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, scalarType);

        public string ComponentWiseOperatorForeign(string op, string returnType)
            => string.Format("public static {3} operator{2}({0} lhs, {3} rhs) => new {3}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, returnType);
        public string ComponentWiseOperatorForeignL(string op, string returnType)
            => string.Format("public static {3} operator{2}({3} lhs, {0} rhs) => new {3}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, returnType);

        public string ComponentWiseOperatorForeignScalar(string op, string scalarType, string returnType)
            => string.Format("public static {4} operator{2}({0} lhs, {3} rhs) => new {4}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs", c, op)).CommaSeparated(), op, scalarType, returnType);

        public string ComponentWiseOperatorForeignScalarL(string op, string scalarType, string returnType)
            => string.Format("public static {4} operator{2}({3} lhs, {0} rhs) => new {4}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, scalarType, returnType);

        public string ComparisonOperator(string op)
            => string.Format("public static bvec{3} operator{2}({0} lhs, {0} rhs) => new bvec{3}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs.{0}", c, op)).CommaSeparated(), op, Components);

        public string ComparisonOperatorScalar(string op, string scalarType)
            => string.Format("public static bvec{3} operator{2}({0} lhs, {4} rhs) => new bvec{3}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs.{0} {1} rhs", c, op)).CommaSeparated(), op, Components, scalarType);

        public string ComparisonOperatorScalarL(string op, string scalarType)
            => string.Format("public static bvec{3} operator{2}({4} lhs, {0} rhs) => new bvec{3}({1});", NameThat,
                    CompString.Select(c => string.Format("lhs {1} rhs.{0}", c, op)).CommaSeparated(), op, Components, scalarType);

        protected override IEnumerable<string> Body
        {
            get
            {
                // components
                for (var i = 0; i < Components; ++i)
                {
                    foreach (var line in string.Format("{0}-component", "xyzw"[i]).AsComment()) yield return line;
                    yield return "[DataMember]";
                    yield return string.Format("public {0} {1};", BaseTypeName, "xyzw"[i]);
                }

                // swizzle
                foreach (var line in "Returns an object that can be used for swizzling (e.g. swizzle.zy)".AsComment()) yield return line;
                yield return string.Format("public swizzle_{0} swizzle => new swizzle_{0}({1});", NameThat, CompArgString);

                // predefs
                foreach (var line in "Predefined all-zero vector".AsComment()) yield return line;
                yield return string.Format("public static {0} Zero {{ get; }} = new {0}({1});", NameThat, ZeroValue.RepeatTimes(Components).CommaSeparated());

                if (!string.IsNullOrEmpty(BaseType.OneValue))
                {
                    foreach (var line in "Predefined all-ones vector".AsComment()) yield return line;
                    yield return string.Format("public static {0} Ones {{ get; }} = new {0}({1});", NameThat, BaseType.OneValue.RepeatTimes(Components).CommaSeparated());

                    for (var c = 0; c < Components; ++c)
                    {
                        foreach (var line in string.Format("Predefined unit-{0} vector", char.ToUpper(ArgOf(c))).AsComment()) yield return line;
                        yield return string.Format("public static {0} Unit{1} {{ get; }} = new {0}({2});", NameThat, char.ToUpper(ArgOf(c)), c.ImpulseString(BaseType.OneValue, ZeroValue, Components).CommaSeparated());
                    }
                }

                if (BaseType.IsComplex)
                {
                    foreach (var line in "Predefined all-imaginary-ones vector".AsComment()) yield return line;
                    yield return string.Format("public static {0} ImaginaryOnes {{ get; }} = new {0}({1});", NameThat, "Complex.ImaginaryOne".RepeatTimes(Components).CommaSeparated());

                    for (var c = 0; c < Components; ++c)
                    {
                        foreach (var line in string.Format("Predefined unit-imaginary-{0} vector", char.ToUpper(ArgOf(c))).AsComment()) yield return line;
                        yield return string.Format("public static {0} ImaginaryUnit{1} {{ get; }} = new {0}({2});", NameThat, char.ToUpper(ArgOf(c)), c.ImpulseString("Complex.ImaginaryOne", ZeroValue, Components).CommaSeparated());
                    }
                }

                // values
                foreach (var line in "Returns an array with all values".AsComment()) yield return line;
                yield return string.Format("public {0}[] Values => new[] {{ {1} }};", BaseTypeName, CompArgString);

                // ctors
                foreach (var line in Constructor("Component-wise constructor", CompParameterString, CompArgs)) yield return line;
                foreach (var line in Constructor("all-same-value constructor", BaseTypeName + " v", "v".RepeatTimes(Components))) yield return line;

                for (var comps = 2; comps <= 4; ++comps)
                {
                    foreach (var line in Constructor("from-vector constructor (empty fields are zero/false)",
                        BaseName + comps + GenericSuffix + " v",
                        "v".DotComp(comps)))
                        yield return line;

                    for (var ucomps = comps; ucomps < Components; ++ucomps)
                        foreach (var line in Constructor("from-vector-and-value constructor (empty fields are zero/false)",
                            BaseName + comps + GenericSuffix + " v, " + SubCompParameterString(comps, ucomps),
                            "v".DotComp(comps).Concat(SubCompArgs(comps, ucomps))))
                            yield return line;
                }

                // implicit upcasts
                var implicits = new HashSet<BuiltinType>();
                var upcasts = BuiltinType.Upcasts;
                foreach (var ukvp in upcasts.Where(k => k.Key == BaseType))
                {
                    var otherType = ukvp.Value;
                    implicits.Add(otherType);

                    var targetType = otherType.Prefix + "vec" + Components;
                    var targetTypeThat = otherType.Prefix + "vec" + Components + GenericSuffix;
                    foreach (var line in string.Format("Implicitly converts this to a {0}.", targetType).AsComment()) yield return line;
                    yield return string.Format("public static implicit operator {0}({1} v) => new {0}({2});", targetTypeThat, NameThat, CompString.Select(c => TypeCast(otherType, "v." + c)).ExactlyN(Components, otherType.ZeroValue).CommaSeparated());
                }

                // explicit casts
                foreach (var oType in BuiltinType.BaseTypes)
                {
                    var otherType = oType;
                    if (otherType.Generic != BaseType.Generic)
                        continue; // cannot mix generic/non-generic
                    if (BaseType.IsComplex && !otherType.IsComplex)
                        continue; // cannot "downcast" complex type

                    for (var comps = 2; comps <= 4; ++comps)
                    {
                        if (otherType == BaseType && comps == Components)
                            continue; // same type and comps not useful

                        if (comps == Components && implicits.Contains(otherType))
                            continue; // already has an implicit conversion

                        var commentAppendix = "";
                        if (comps > Components)
                            commentAppendix = " (Higher components are zeroed)";
                        var targetType = otherType.Prefix + "vec" + comps;
                        var targetTypeThat = otherType.Prefix + "vec" + comps + GenericSuffix;
                        foreach (var line in string.Format("Explicitly converts this to a {0}.{1}", targetType, commentAppendix).AsComment()) yield return line;
                        yield return string.Format("public static explicit operator {0}({1} v) => new {0}({2});", targetTypeThat, NameThat, CompString.Select(c => TypeCast(otherType, "v." + c)).ExactlyN(comps, otherType.ZeroValue).CommaSeparated());
                    }
                }

                // IEnumerable
                foreach (var line in "Returns an enumerator that iterates through all components.".AsComment()) yield return line;
                yield return string.Format("public IEnumerator<{0}> GetEnumerator()", BaseTypeName);
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
                yield return string.Format("public {0} this[int index]", BaseTypeName);
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
                yield return string.Format("public bool Equals({0} rhs) => {1};", NameThat, CompString.Select(c => Comparer(c.ToString())).Aggregated(" && "));

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
                yield return "        return " + HashCodeFor(Components - 1) + ";";
                yield return "    }";
                yield return "}";

                if (!BaseType.Generic && !BaseType.IsComplex && BaseType.HasArithmetics)
                {
                    foreach (var line in "Returns a boolean vector with component-wise equal.".AsComment()) yield return line;
                    yield return string.Format("public static bvec{0} Equal({1} lhs, {1} rhs) => new bvec{0}({2});", Components, NameThat, CompString.Select(c => string.Format("lhs.{0} == rhs.{0}", c)).CommaSeparated());

                    foreach (var line in "Returns a boolean vector with component-wise not-equal.".AsComment()) yield return line;
                    yield return string.Format("public static bvec{0} NotEqual({1} lhs, {1} rhs) => new bvec{0}({2});", Components, NameThat, CompString.Select(c => string.Format("lhs.{0} != rhs.{0}", c)).CommaSeparated());

                    foreach (var line in "Returns a boolean vector with component-wise greater-than.".AsComment()) yield return line;
                    yield return string.Format("public static bvec{0} GreaterThan({1} lhs, {1} rhs) => lhs > rhs;", Components, NameThat);

                    foreach (var line in "Returns a boolean vector with component-wise greater-than-or-equal.".AsComment()) yield return line;
                    yield return string.Format("public static bvec{0} GreaterThanEqual({1} lhs, {1} rhs) => lhs >= rhs;", Components, NameThat);

                    foreach (var line in "Returns a boolean vector with component-wise lesser-than.".AsComment()) yield return line;
                    yield return string.Format("public static bvec{0} LesserThan({1} lhs, {1} rhs) => lhs < rhs;", Components, NameThat);

                    foreach (var line in "Returns a boolean vector with component-wise lesser-than-or-equal.".AsComment()) yield return line;
                    yield return string.Format("public static bvec{0} LesserThanEqual({1} lhs, {1} rhs) => lhs <= rhs;", Components, NameThat);
                }

                // ToString
                foreach (var line in "Returns a string representation of this vector using ', ' as a seperator.".AsComment()) yield return line;
                yield return string.Format("public override string ToString() => ToString(\", \");");

                foreach (var line in "Returns a string representation of this vector using a provided seperator.".AsComment()) yield return line;
                yield return string.Format("public string ToString(string sep) => {0};", CompString.Aggregated(" + sep + "));

                if (!BaseType.Generic)
                {
                    foreach (var line in "Returns a string representation of this vector using a provided seperator and a format provider for each component.".AsComment()) yield return line;
                    yield return string.Format("public string ToString(string sep, IFormatProvider provider) => {0};", CompString.Select(c => c + ".ToString(provider)").Aggregated(" + sep + "));

                    if (BaseType.HasFormatString)
                    {
                        foreach (var line in "Returns a string representation of this vector using a provided seperator and a format for each component.".AsComment()) yield return line;
                        yield return string.Format("public string ToString(string sep, string format) => {0};", CompString.Select(c => c + ".ToString(format)").Aggregated(" + sep + "));

                        foreach (var line in "Returns a string representation of this vector using a provided seperator and a format and format provider for each component.".AsComment()) yield return line;
                        yield return string.Format("public string ToString(string sep, string format, IFormatProvider provider) => {0};", CompString.Select(c => c + ".ToString(format, provider)").Aggregated(" + sep + "));
                    }
                }

                // Basetype constants
                foreach (var constant in BaseType.TypeConstants)
                {
                    foreach (var line in string.Format("Predefined all-{0} vector", constant).AsComment()) yield return line;
                    yield return string.Format("public static {0} {2} {{ get; }} = new {0}({1});", NameThat, string.Format("{0}.{1}", BaseTypeName, constant).RepeatTimes(Components).CommaSeparated(), constant);
                }

                // Basetype test functions
                foreach (var kvp in BaseType.TypeTestFuncs)
                {
                    var funcName = kvp.Key;
                    var funcImpl = kvp.Value;
                    foreach (var line in string.Format("Executes a component-wise {0}", funcName).AsComment()) yield return line;
                    yield return string.Format("public static bvec{0} {1}({2} v) => new bvec{0}({3});", Components, funcName, NameThat, CompString.Select(c => string.Format(funcImpl, "v." + c)).CommaSeparated());
                }

                // Parsing
                if (!BaseType.IsComplex && !BaseType.Generic)
                {
                    // Parse
                    foreach (var line in "Converts the string representation of the vector into a vector representation (using ', ' as a separator).".AsComment()) yield return line;
                    yield return string.Format("public static {0} Parse(string s) => Parse(s, \", \");", NameThat);

                    foreach (var line in "Converts the string representation of the vector into a vector representation (using a designated separator).".AsComment()) yield return line;
                    yield return string.Format("public static {0} Parse(string s, string sep)", NameThat);
                    yield return "{";
                    yield return "    var kvp = s.Split(new[] { sep }, StringSplitOptions.None);";
                    yield return string.Format("    if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components);
                    yield return string.Format("    return new {0}({1});", NameThat, Components.ForIndexUpTo(i => string.Format("{0}.Parse(kvp[{1}].Trim())", BaseTypeName, i)).CommaSeparated());
                    yield return "}";

                    if (BaseType.Name != "bool")
                    {
                        foreach (var line in "Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).".AsComment()) yield return line;
                        yield return string.Format("public static {0} Parse(string s, string sep, IFormatProvider provider)", NameThat);
                        yield return "{";
                        yield return "    var kvp = s.Split(new[] { sep }, StringSplitOptions.None);";
                        yield return string.Format("    if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components);
                        yield return string.Format("    return new {0}({1});", NameThat, Components.ForIndexUpTo(i => string.Format("{0}.Parse(kvp[{1}].Trim(), provider)", BaseTypeName, i)).CommaSeparated());
                        yield return "}";

                        foreach (var line in "Converts the string representation of the vector into a vector representation (using a designated separator and a number style).".AsComment()) yield return line;
                        yield return string.Format("public static {0} Parse(string s, string sep, NumberStyles style)", NameThat);
                        yield return "{";
                        yield return "    var kvp = s.Split(new[] { sep }, StringSplitOptions.None);";
                        yield return string.Format("    if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components);
                        yield return string.Format("    return new {0}({1});", NameThat, Components.ForIndexUpTo(i => string.Format("{0}.Parse(kvp[{1}].Trim(), style)", BaseTypeName, i)).CommaSeparated());
                        yield return "}";

                        foreach (var line in "Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).".AsComment()) yield return line;
                        yield return string.Format("public static {0} Parse(string s, string sep, NumberStyles style, IFormatProvider provider)", NameThat);
                        yield return "{";
                        yield return "    var kvp = s.Split(new[] { sep }, StringSplitOptions.None);";
                        yield return string.Format("    if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components);
                        yield return string.Format("    return new {0}({1});", NameThat, Components.ForIndexUpTo(i => string.Format("{0}.Parse(kvp[{1}].Trim(), style, provider)", BaseTypeName, i)).CommaSeparated());
                        yield return "}";
                    }

                    // TryParse
                    foreach (var line in "Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.".AsComment()) yield return line;
                    yield return string.Format("public static bool TryParse(string s, out {0} result) => TryParse(s, \", \", out result);", NameThat);

                    foreach (var line in "Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.".AsComment()) yield return line;
                    yield return string.Format("public static bool TryParse(string s, string sep, out {0} result)", NameThat);
                    yield return "{";
                    yield return "    result = Zero;";
                    yield return "    if (string.IsNullOrEmpty(s)) return false;";
                    yield return "    var kvp = s.Split(new[] { sep }, StringSplitOptions.None);";
                    yield return string.Format("    if (kvp.Length != {0}) return false;", Components);
                    yield return string.Format("    {0} {1};", BaseTypeName, CompString.Select(c => c + " = " + ZeroValue).CommaSeparated());
                    yield return string.Format("    var ok = {0};", Components.ForIndexUpTo(i => string.Format("{0}.TryParse(kvp[{1}].Trim(), out {2})", BaseTypeName, i, ArgOf(i))).Aggregated(" && "));
                    yield return string.Format("    result = ok ? new {0}({1}) : Zero;", NameThat, CompArgString);
                    yield return "    return ok;";
                    yield return "}";

                    if (BaseType.Name != "bool")
                    {
                        foreach (var line in "Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.".AsComment()) yield return line;
                        yield return string.Format("public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out {0} result)", NameThat);
                        yield return "{";
                        yield return "    result = Zero;";
                        yield return "    if (string.IsNullOrEmpty(s)) return false;";
                        yield return "    var kvp = s.Split(new[] { sep }, StringSplitOptions.None);";
                        yield return string.Format("    if (kvp.Length != {0}) return false;", Components);
                        yield return string.Format("    {0} {1};", BaseTypeName, CompString.Select(c => c + " = " + ZeroValue).CommaSeparated());
                        yield return string.Format("    var ok = {0};", Components.ForIndexUpTo(i => string.Format("{0}.TryParse(kvp[{1}].Trim(), style, provider, out {2})", BaseTypeName, i, ArgOf(i))).Aggregated(" && "));
                        yield return string.Format("    result = ok ? new {0}({1}) : Zero;", NameThat, CompArgString);
                        yield return "    return ok;";
                        yield return "}";
                    }
                }


                // Complex properties
                if (BaseType.IsComplex)
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
                if (BaseType.HasLogicOps)
                {
                    foreach (var line in "Returns the minimal component of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} MinElement => {1};", BaseTypeName, CompString.Aggregated(" && "));

                    foreach (var line in "Returns the maximal component of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} MaxElement => {1};", BaseTypeName, CompString.Aggregated(" || "));

                    foreach (var line in "Returns true if all component are true.".AsComment()) yield return line;
                    yield return string.Format("public {0} All => {1};", BaseTypeName, CompString.Aggregated(" && "));

                    foreach (var line in "Returns true if any component is true.".AsComment()) yield return line;
                    yield return string.Format("public {0} Any => {1};", BaseTypeName, CompString.Aggregated(" || "));

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
                        foreach (var line in "Returns the minimal component of this vector.".AsComment()) yield return line;
                        yield return string.Format("public {0} MinElement => {1};", BaseTypeName, NestedBiFuncFor("Math.Min({0}, {1})", Components - 1, ArgOfs));

                        foreach (var line in "Returns the maximal component of this vector.".AsComment()) yield return line;
                        yield return string.Format("public {0} MaxElement => {1};", BaseTypeName, NestedBiFuncFor("Math.Max({0}, {1})", Components - 1, ArgOfs));
                    }

                    foreach (var line in "Returns the euclidean length of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Length => ({0}){1};", lengthType, SqrtOf(CompString.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the squared euclidean length of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} LengthSqr => {1};", lengthType, CompString.Select(SqrOf).Aggregated(" + "));

                    foreach (var line in "Returns the sum of all components.".AsComment()) yield return line;
                    yield return string.Format("public {0} Sum => {1};", BaseTypeName, CompString.Aggregated(" + "));

                    foreach (var line in "Returns the euclidean norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm => ({0}){1};", lengthType, SqrtOf(CompString.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the one-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm1 => {1};", lengthType, CompString.Select(AbsString).Aggregated(" + "));

                    foreach (var line in "Returns the two-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} Norm2 => ({0}){1};", lengthType, SqrtOf(CompString.Select(SqrOf).Aggregated(" + ")));

                    foreach (var line in "Returns the max-norm of this vector.".AsComment()) yield return line;
                    yield return string.Format("public {0} NormMax => {1};", BaseTypeName, NestedBiFuncFor("Math.Max({0}, {1})", Components - 1, c => AbsString(ArgOfs(c))));

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
                        yield return ComponentWiseOperatorScalar(op, BaseTypeName);
                        foreach (var line in string.Format("Executes a component-wise {0} with a scalar.", opComment).AsComment()) yield return line;
                        yield return ComponentWiseOperatorScalarL(op, BaseTypeName);

                        // upcasts
                        foreach (var ukvp in upcasts.Where(k => k.Key == BaseType))
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

                        if (op == "-" && !BaseType.IsSigned)
                            continue; // unsigned

                        foreach (var line in string.Format("Executes a component-wise unary {0}.", opComment).AsComment()) yield return line;
                        if (op == "+")
                            yield return string.Format("public static {0} operator{1}({0} v) => v;", NameThat, op);
                        else
                            yield return string.Format("public static {0} operator{1}({0} v) => new {0}({2});", NameThat, op, CompString.Select(c => op + "v." + c).CommaSeparated());
                    }

                    // integer-only operators
                    if (BaseType.IsInteger)
                    {
                        foreach (var kvp in new Dictionary<string, string>
                        {
                            {"%", "% (modulo)"},
                            {"^", "^ (xor)"},
                            {"|", "bitwise-or"},
                            {"&", "bitwise-and"}
                        })
                        {
                            var op = kvp.Key;
                            var opComment = kvp.Value;

                            foreach (var line in string.Format("Executes a component-wise {0}.", opComment).AsComment()) yield return line;
                            yield return ComponentWiseOperator(op);
                            foreach (var line in string.Format("Executes a component-wise {0} with a scalar.", opComment).AsComment()) yield return line;
                            yield return ComponentWiseOperatorScalar(op, BaseTypeName);
                            foreach (var line in string.Format("Executes a component-wise {0} with a scalar.", opComment).AsComment()) yield return line;
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

                            foreach (var line in string.Format("Executes a component-wise {0} comparison.", opComment).AsComment()) yield return line;
                            yield return ComparisonOperator(op);
                            foreach (var line in string.Format("Executes a component-wise {0} comparison with a scalar.", opComment).AsComment()) yield return line;
                            yield return ComparisonOperatorScalar(op, BaseTypeName);
                            foreach (var line in string.Format("Executes a component-wise {0} comparison with a scalar.", opComment).AsComment()) yield return line;
                            yield return ComparisonOperatorScalarL(op, BaseTypeName);
                        }
                    }

                    // normalized
                    if (!BaseType.IsInteger)
                    {
                        foreach (var line in "Returns a copy of this vector with length one (undefined if this has zero length).".AsComment()) yield return line;
                        yield return string.Format("public {0} Normalized => this / Length;", NameThat);

                        foreach (var line in "Returns a copy of this vector with length one (returns zero if length is zero).".AsComment()) yield return line;
                        yield return string.Format("public {0} NormalizedSafe => this == Zero ? Zero : this / Length;", NameThat);
                    }

                    // dot
                    foreach (var line in "Returns the inner product (dot product, scalar product) of the two vectors.".AsComment()) yield return line;
                    yield return string.Format("public static {0} Dot({1} lhs, {1} rhs) => {2};", BaseTypeName, NameThat, CompString.Select(c => string.Format("lhs.{0} * rhs.{0}", c)).Aggregated(" + "));

                    // distance
                    foreach (var line in "Returns the euclidean distance between the two vectors.".AsComment()) yield return line;
                    yield return string.Format("public static {0} Distance({1} lhs, {1} rhs) => (lhs - rhs).Length;", lengthType, NameThat);

                    foreach (var line in "Returns the squared euclidean distance between the two vectors.".AsComment()) yield return line;
                    yield return string.Format("public static {0} DistanceSqr({1} lhs, {1} rhs) => (lhs - rhs).LengthSqr;", lengthType, NameThat);

                    if (BaseType.IsSigned)
                    {
                        // reflect
                        foreach (var line in "Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).".AsComment()) yield return line;
                        yield return string.Format("public static {0} Reflect({0} I, {0} N) => I - 2 * Dot(N, I) * N;", NameThat);

                        // refract
                        if (!BaseType.IsComplex)
                        {
                            foreach (var line in "Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).".AsComment()) yield return line;
                            yield return string.Format("public static {0} Refract({0} I, {0} N, {1} eta)", NameThat, BaseTypeName);
                            yield return "{";
                            yield return "    var dNI = Dot(N, I);";
                            yield return "    var k = 1 - eta * eta * (1 - dNI * dNI);";
                            yield return "    if (k < 0) return Zero;";
                            yield return string.Format("    return eta * I - (eta * dNI + ({1}){0}) * N;", BaseType.IsComplex ? "Complex.Sqrt(k)" : SqrtOf("k"), BaseTypeName);
                            yield return "}";

                            // faceforward
                            foreach (var line in "Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).".AsComment()) yield return line;
                            yield return string.Format("public static {0} FaceForward({0} N, {0} I, {0} Nref) => Dot(Nref, I) < 0 ? N : -N;", NameThat);
                        }
                    }

                    // cross
                    switch (Components)
                    {
                        case 3:
                            foreach (var line in "Returns the outer product (cross product, vector product) of the two vectors.".AsComment()) yield return line;
                            yield return string.Format("public static {0} Cross({0} l, {0} r) => new {0}(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);", NameThat);
                            break;
                        case 2:
                            foreach (var line in "Returns the length of the outer product (cross product, vector product) of the two vectors.".AsComment()) yield return line;
                            yield return string.Format("public static {1} Cross({0} l, {0} r) => l.x * r.y - l.y * r.x;", NameThat, BaseTypeName);
                            break;
                    }

                    // angle
                    if (Components == 2 && !BaseType.IsComplex)
                    {
                        foreach (var line in "Returns the vector angle (atan2(y, x)) in radians.".AsComment()) yield return line;
                        yield return string.Format("public double Angle => Math.Atan2((double)y, (double)x);");

                        foreach (var line in "Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types).".AsComment()) yield return line;
                        yield return string.Format("public static {0} FromAngle(double angleInRad) => new {0}(({1})Math.Cos(angleInRad), ({1})Math.Sin(angleInRad));", NameThat, BaseTypeName);

                        foreach (var line in "Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).".AsComment()) yield return line;
                        yield return string.Format("public {0} Rotated(double angleInRad) => ({0})(dvec2.FromAngle(Angle) * (double)Length);", NameThat);
                    }

                    // component-wise unary functions
                    foreach (var kvp in new Dictionary<string, Func<string, string>>
                    {
                        {"Abs", AbsString},
                    })
                    {
                        var op = kvp.Key;
                        var opFunc = kvp.Value;

                        var retType = NameThat;
                        if (op == "Abs" && !string.IsNullOrEmpty(BaseType.AbsOverrideType))
                            retType = BaseType.AbsOverrideTypePrefix + "vec" + Components + GenericSuffix;

                        foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("v." + c)).CommaSeparated());

                        foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, BaseTypeName, opFunc("v"));
                    }

                    foreach (var kvp in new Dictionary<string, Func<string, string>>
                    {
                        {"HermiteInterpolationOrder3", s => string.Format("(3 - 2 * {0}) * {0} * {0}", s)},
                        {"HermiteInterpolationOrder5", s => string.Format("((6 * {0} - 15) * {0} + 10) * {0} * {0} * {0}", s)},
                    })
                    {
                        var op = kvp.Key;
                        var opFunc = kvp.Value;

                        var retType = NameThat;

                        foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("v." + c)).CommaSeparated());

                        foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, BaseTypeName, opFunc("v"));
                    }

                    if (BaseType.IsFloatingPoint)
                    {
                        // TODO: Acosh, Asinh, Atanh

                        foreach (var kvp in new Dictionary<string, Func<string, string>>
                        {
                            {"Step", s => string.Format("{0} >= {1} ? {2} : {1}", s, ZeroValue, OneValue)},
                            {"Acos", s => string.Format("({1})Math.Acos((double){0})", s, BaseTypeName)},
                            {"Asin", s => string.Format("({1})Math.Asin((double){0})", s, BaseTypeName)},
                            {"Atan", s => string.Format("({1})Math.Atan((double){0})", s, BaseTypeName)},
                            {"Cos", s => string.Format("({1})Math.Cos((double){0})", s, BaseTypeName)},
                            {"Cosh", s => string.Format("({1})Math.Cosh((double){0})", s, BaseTypeName)},
                            {"Exp", s => string.Format("({1})Math.Exp((double){0})", s, BaseTypeName)},
                            {"Log", s => string.Format("({1})Math.Log((double){0})", s, BaseTypeName)},
                            {"Log2", s => string.Format("({1})Math.Log((double){0}, 2)", s, BaseTypeName)},
                            {"Log10", s => string.Format("({1})Math.Log10((double){0})", s, BaseTypeName)},
                            {"Floor", s => string.Format("({1})Math.Floor({0})", s, BaseTypeName)},
                            {"Ceiling", s => string.Format("({1})Math.Ceiling({0})", s, BaseTypeName)},
                            {"Round", s => string.Format("({1})Math.Round({0})", s, BaseTypeName)},
                            {"Sin", s => string.Format("({1})Math.Sin((double){0})", s, BaseTypeName)},
                            {"Sinh", s => string.Format("({1})Math.Sinh((double){0})", s, BaseTypeName)},
                            {"Sqrt", s => string.Format("({1})Math.Sqrt((double){0})", s, BaseTypeName)},
                            {"Tan", s => string.Format("({1})Math.Tan((double){0})", s, BaseTypeName)},
                            {"Tanh", s => string.Format("({1})Math.Tanh((double){0})", s, BaseTypeName)},
                            {"Truncate", s => string.Format("({1})Math.Truncate((double){0})", s, BaseTypeName)},
                            {"Sign", s => string.Format("Math.Sign({0})", s)},
                        })
                        {
                            var op = kvp.Key;
                            var opFunc = kvp.Value;

                            var retType = NameThat;

                            if (op == "Sign")
                                retType = "ivec" + Components;

                            foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("v." + c)).CommaSeparated());

                            foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, BaseTypeName, opFunc("v"));
                        }

                        foreach (var line in "Returns a component-wise executed radians-to-degrees conversion.".AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => v * {3};", NameThat, "Degrees", NameThat, ConstantSuffixFor("57.295779513082320876798154814105170332405472466564321"));

                        foreach (var line in "Returns a component-wise executed radians-to-degrees conversion with a scalar.".AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}(v * {3});", NameThat, "Degrees", BaseTypeName, ConstantSuffixFor("57.295779513082320876798154814105170332405472466564321"));

                        foreach (var line in "Returns a component-wise executed degrees-to-radians conversion.".AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => v * {3};", NameThat, "Radians", NameThat, ConstantSuffixFor("0.0174532925199432957692369076848861271344287188854172"));

                        foreach (var line in "Returns a component-wise executed degrees-to-radians conversion with a scalar.".AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}(v * {3});", NameThat, "Radians", BaseTypeName, ConstantSuffixFor("0.0174532925199432957692369076848861271344287188854172"));
                    }

                    if (BaseType.IsComplex)
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

                            var retType = NameThat;

                            foreach (var line in string.Format("Returns a component-wise executed complex {0}.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("v." + c)).CommaSeparated());

                            foreach (var line in string.Format("Returns a component-wise executed complex {0} with a scalar.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({4} s) => new {0}({3});", retType, op, NameThat, opFunc("s"), BaseTypeName);
                        }

                        foreach (var kvp in new Dictionary<string, Func<string, string, string>>
                        {
                            {"Pow", (s1, s2) => string.Format("Complex.Pow({0}, {1})", s1, s2)},
                            {"Log", (s1, s2) => string.Format("Complex.Log({0}, {1})", s1, s2)},
                        })
                        {
                            var op = kvp.Key;
                            var opFunc = kvp.Value;

                            var retType = NameThat;

                            var complexRhs = op != "Log";

                            // complex rhs
                            if (complexRhs)
                            {
                                foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                                yield return string.Format("public static {0} {1}({2} lhs, {2} rhs) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("lhs." + c, "rhs." + c)).CommaSeparated());

                                foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                                yield return string.Format("public static {0} {1}({2} v, {4} s) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("v." + c, "s")).CommaSeparated(), BaseTypeName);

                                foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                                yield return string.Format("public static {0} {1}({4} s, {2} v) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("s", "v." + c)).CommaSeparated(), BaseTypeName);

                                foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                                yield return string.Format("public static {0} {1}({4} s, {2} v) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("s", "v." + c)).CommaSeparated(), "double");

                                foreach (var line in string.Format("Returns a component-wise executed {0} with scalars.", op).AsComment()) yield return line;
                                yield return string.Format("public static {0} {1}({4} lhs, {4} rhs) => new {0}({3});", retType, op, NameThat, opFunc("lhs", "rhs"), BaseTypeName);
                            }

                            // double rhs
                            foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} lhs, {4} rhs) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("lhs." + c, "rhs." + c)).CommaSeparated(), "dvec" + Components);

                            foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} v, {4} s) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("v." + c, "s")).CommaSeparated(), "double");

                            foreach (var line in string.Format("Returns a component-wise executed {0} with scalars.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({4} lhs, {4} rhs) => new {0}({3});", retType, op, NameThat, opFunc("lhs", "rhs"), "double");
                        }

                        // from polar coordinates
                        foreach (var line in "Returns a component-wise executed FromPolarCoordinates.".AsComment()) yield return line;
                        yield return string.Format("public static {0} FromPolarCoordinates({1} lhs, {1} rhs) => new {0}({2});", NameThat, "dvec" + Components, CompString.Select(c => string.Format("Complex.FromPolarCoordinates({0}, {1})", "lhs." + c, "rhs." + c)).CommaSeparated());

                        foreach (var line in "Returns a component-wise executed FromPolarCoordinates with a scalar.".AsComment()) yield return line;
                        yield return string.Format("public static {0} FromPolarCoordinates(double s, {1} v) => new {0}({2});", NameThat, "dvec" + Components, CompString.Select(c => string.Format("Complex.FromPolarCoordinates({0}, {1})", "s", "v." + c)).CommaSeparated());

                        foreach (var line in "Returns a component-wise executed FromPolarCoordinates with a scalar.".AsComment()) yield return line;
                        yield return string.Format("public static {0} FromPolarCoordinates({1} v, double s) => new {0}({2});", NameThat, "dvec" + Components, CompString.Select(c => string.Format("Complex.FromPolarCoordinates({0}, {1})", "v." + c, "s")).CommaSeparated());
                    }

                    foreach (var kvp in new Dictionary<string, Func<string, string>>
                    {
                        {"Sqr", s => string.Format("{0} * {0}", s)},
                        {"Pow2", s => string.Format("{0} * {0}", s)},
                    })
                    {
                        var op = kvp.Key;
                        var opFunc = kvp.Value;

                        var retType = NameThat;

                        foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("v." + c)).CommaSeparated());

                        foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                        yield return string.Format("public static {0} {1}({2} v) => new {0}({3});", retType, op, BaseTypeName, opFunc("v"));
                    }

                    if (!BaseType.IsComplex)
                        foreach (var kvp in new Dictionary<string, Func<string, string, string>>
                        {
                            {"Max", (s1, s2) => string.Format("Math.Max({0}, {1})", s1, s2)},
                            {"Min", (s1, s2) => string.Format("Math.Min({0}, {1})", s1, s2)},
                            {"Pow", (s1, s2) => string.Format("({2})Math.Pow((double){0}, (double){1})", s1, s2, BaseTypeName)},
                            {"Log", (s1, s2) => string.Format("({2})Math.Log((double){0}, (double){1})", s1, s2, BaseTypeName)},
                        })
                        {
                            var op = kvp.Key;
                            var opFunc = kvp.Value;

                            var retType = NameThat;

                            foreach (var line in string.Format("Returns a component-wise executed {0}.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} lhs, {2} rhs) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("lhs." + c, "rhs." + c)).CommaSeparated());

                            foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} v, {4} s) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("v." + c, "s")).CommaSeparated(), BaseTypeName);

                            foreach (var line in string.Format("Returns a component-wise executed {0} with a scalar.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({4} s, {2} v) => new {0}({3});", retType, op, NameThat, CompString.Select(c => opFunc("s", "v." + c)).CommaSeparated(), BaseTypeName);

                            foreach (var line in string.Format("Returns a component-wise executed {0} with scalars.", op).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({4} lhs, {4} rhs) => new {0}({3});", retType, op, NameThat, opFunc("lhs", "rhs"), BaseTypeName);
                        }

                    foreach (var kvp in new Dictionary<string[], Func<string, string, string, string>>
                    {
                        {new []{"Clamp", "v", "min", "max"}, (s1, s2, s3) => string.Format("Math.Min(Math.Max({0}, {1}), {2})", s1, s2, s3)},
                        {new []{"Mix", "min", "max", "a"}, (s1, s2, s3) => string.Format("{0} * (1-{2}) + {1} * {2}", s1, s2, s3)},
                        {new []{"Lerp", "min", "max", "a"}, (s1, s2, s3) => string.Format("{0} * (1-{2}) + {1} * {2}", s1, s2, s3)},
                        {new []{"Smoothstep", "edge0", "edge1", "v"}, (s1, s2, s3) => string.Format("(({2} - {0}) / ({1} - {0})).Clamp().HermiteInterpolationOrder3()", s1, s2, s3)},
                        {new []{"Smootherstep", "edge0", "edge1", "v"}, (s1, s2, s3) => string.Format("(({2} - {0}) / ({1} - {0})).Clamp().HermiteInterpolationOrder5()", s1, s2, s3)},
                    })
                    {
                        var op = kvp.Key;
                        var opFunc = kvp.Value;

                        if (BaseType.IsComplex && op[0] != "Mix")
                            continue; // no clamp for complex

                        var retType = NameThat;

                        foreach (var scalars in new[]
                        {
                            new[] { false, false, false }, // no scalar
                            new[] { true, false, false },
                            new[] { false, true, false },
                            new[] { false, false, true },
                            new[] { true, true, false },
                            new[] { false, true, true },
                            new[] { true, false, true },
                            new[] { true, true, true }, // all scalar
                        })
                        {
                            var opt0 = scalars[0] ? BaseTypeName : NameThat;
                            var opt1 = scalars[1] ? BaseTypeName : NameThat;
                            var opt2 = scalars[2] ? BaseTypeName : NameThat;

                            Func<char, string> op0 = c => scalars[0] ? op[1] : op[1] + "." + c;
                            Func<char, string> op1 = c => scalars[1] ? op[2] : op[2] + "." + c;
                            Func<char, string> op2 = c => scalars[2] ? op[3] : op[3] + "." + c;

                            var comm = scalars.All(b => !b) ? "" : " with scalars";

                            var compStr = scalars.All(b => b) ? "_" : CompString;

                            foreach (var line in string.Format("Returns a component-wise executed {0}{1}.", op[0], comm).AsComment()) yield return line;
                            yield return string.Format("public static {0} {1}({2} {6}, {3} {7}, {4} {8}) => new {0}({5});", retType, op[0], opt0, opt1, opt2, compStr.Select(c => opFunc(op0(c), op1(c), op2(c))).CommaSeparated(), op[1], op[2], op[3]);
                        }
                    }
                }
            }
        }

    }
}
