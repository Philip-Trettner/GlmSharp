using System;
using System.Collections.Generic;
using System.Linq;
using GlmSharpGenerator.Members;

namespace GlmSharpGenerator.Types
{
    class VectorType : AbstractType
    {
        public VectorType(BuiltinType type, int comps)
        {
            Components = comps;
            BaseType = type;
            BaseName = type.Prefix + "vec";
        }

        public int Components { get; set; } = 3;

        public IEnumerable<string> Fields => "xyzw".Substring(0, Components).Select(c => c.ToString());

        public override string Name => BaseName + Components;

        public override string Folder => "Vec" + Components;


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
        public char ArgOfUpper(int c) => char.ToUpper("xyzw"[c]);
        public string ArgOfs(int c) => "xyzw"[c].ToString();

        public IEnumerable<string> SubCompParameters(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => BaseTypeName + " " + c);
        public string SubCompParameterString(int start, int end) => SubCompParameters(start, end).CommaSeparated();
        public IEnumerable<string> SubCompArgs(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => c.ToString());
        public string SubCompArgString(int start, int end) => SubCompArgs(start, end).CommaSeparated();

        public SwizzleType SwizzleType => new SwizzleType { Components = Components, BaseName = "swizzle_" + BaseName, BaseType = BaseType };


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
            if (otherType.HasArithmetics && BaseType.IsBool)
                return string.Format("{0} ? {1} : {2}", c, otherType.OneValue, otherType.ZeroValue);

            if (otherType.IsBool && BaseType.HasArithmetics)
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

        public IEnumerable<string> SwitchIndex(IEnumerable<string> cases)
        {
            yield return "switch (index)";
            yield return "{";
            foreach (var @case in cases)
                yield return @case.Indent();
            yield return "    default: throw new ArgumentOutOfRangeException(\"index\");";
            yield return "}";
        }

        public override IEnumerable<Member> GenerateMembers()
        {
            var boolVType = new VectorType(BuiltinType.TypeBool, Components);
            var doubleVType = new VectorType(BuiltinType.TypeDouble, Components);
            var integerVType = new VectorType(BuiltinType.TypeInt, Components);
            var absVType = !string.IsNullOrEmpty(BaseType.AbsOverrideType) ? Types[BaseType.AbsOverrideTypePrefix + "vec" + Components] : this;

            // fields
            foreach (var f in Fields)
                yield return new Field(f, BaseType)
                {
                    Comment = string.Format("{0}-component", f)
                };

            // swizzle
            yield return new Property("swizzle", SwizzleType)
            {
                GetterLine = Construct(SwizzleType, Fields),
                Comment = "Returns an object that can be used for swizzling (e.g. swizzle.zy)"
            };

            // predefs
            yield return new StaticProperty("Zero", this)
            {
                Value = Construct(this, ZeroValue.RepeatTimes(Components)),
                Comment = "Predefined all-zero vector"
            };

            if (!string.IsNullOrEmpty(BaseType.OneValue))
            {
                yield return new StaticProperty("Ones", this)
                {
                    Value = Construct(this, OneValue.RepeatTimes(Components)),
                    Comment = "Predefined all-ones vector"
                };

                for (var c = 0; c < Components; ++c)
                    yield return new StaticProperty("Unit" + ArgOfUpper(c), this)
                    {
                        Value = Construct(this, c.ImpulseString(BaseType.OneValue, ZeroValue, Components)),
                        Comment = string.Format("Predefined unit-{0} vector", ArgOfUpper(c))
                    };
            }

            if (BaseType.IsComplex)
            {
                yield return new StaticProperty("ImaginaryOnes", this)
                {
                    Value = Construct(this, "Complex.ImaginaryOne".RepeatTimes(Components)),
                    Comment = "Predefined all-imaginary-ones vector"
                };

                for (var c = 0; c < Components; ++c)
                    yield return new StaticProperty("ImaginaryUnit" + ArgOfUpper(c), this)
                    {
                        Value = Construct(this, c.ImpulseString("Complex.ImaginaryOne", ZeroValue, Components)),
                        Comment = string.Format("Predefined unit-imaginary-{0} vector", ArgOfUpper(c))
                    };
            }

            // Basetype constants
            foreach (var constant in BaseType.TypeConstants)
            {
                yield return new StaticProperty(constant, this)
                {
                    Value = Construct(this, string.Format("{0}.{1}", BaseTypeName, constant).RepeatTimes(Components)),
                    Comment = string.Format("Predefined all-{0} vector", constant)
                };
            }

            // values
            yield return new Property("Values", new ArrayType(BaseType))
            {
                GetterLine = string.Format("new[] {{ {0} }}", CompArgString),
                Comment = "Returns an array with all values"
            };

            // ctors
            yield return new Constructor(this, Fields)
            {
                Parameters = Fields.TypedArgs(BaseType),
                Initializers = Fields,
                Comment = "Component-wise constructor"
            };
            yield return new Constructor(this, Fields)
            {
                ParameterString = BaseTypeName + " v",
                Initializers = "v".RepeatTimes(Components),
                Comment = "all-same-value constructor"
            };

            for (var comps = 2; comps <= 4; ++comps)
            {
                yield return new Constructor(this, Fields)
                {
                    ParameterString = new VectorType(BaseType, comps).NameThat + " v",
                    Initializers = "v".DotComp(comps),
                    Comment = "from-vector constructor (empty fields are zero/false)"
                };

                for (var ucomps = comps; ucomps < Components; ++ucomps)
                    yield return new Constructor(this, Fields)
                    {
                        ParameterString = new VectorType(BaseType, comps).NameThat + " v, " + SubCompParameterString(comps, ucomps),
                        Initializers = "v".DotComp(comps).Concat(SubCompArgs(comps, ucomps)),
                        Comment = "from-vector-and-value constructor (empty fields are zero/false)"
                    };
            }

            // implicit upcasts
            var implicits = new HashSet<BuiltinType>();
            var upcasts = BuiltinType.Upcasts;
            foreach (var ukvp in upcasts.Where(k => k.Key == BaseType))
            {
                var otherType = ukvp.Value;
                implicits.Add(otherType);
                var targetType = new VectorType(otherType, Components);

                yield return new ImplicitOperator(targetType)
                {
                    ParameterString = NameThat + " v",
                    CodeString = Construct(targetType, CompString.Select(c => TypeCast(otherType, "v." + c)).ExactlyN(Components, otherType.ZeroValue)),
                    Comment = string.Format("Implicitly converts this to a {0}.", targetType.Name),
                };
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
                    var targetType = new VectorType(otherType, comps);
                    yield return new ExplicitOperator(targetType)
                    {
                        ParameterString = NameThat + " v",
                        CodeString = Construct(targetType, CompString.Select(c => TypeCast(otherType, "v." + c)).ExactlyN(comps, otherType.ZeroValue)),
                        Comment = string.Format("Explicitly converts this to a {0}.{1}", targetType.Name, commentAppendix)
                    };
                }
            }

            // IEnumerable
            yield return new Function(new AnyType(string.Format("IEnumerator<{0}>", BaseTypeName)), "GetEnumerator")
            {
                NoReturn = true,
                Code = Fields.Select(f => string.Format("yield return {0};", f)),
                Comment = "Returns an enumerator that iterates through all components."
            };

            yield return new Function(new AnyType("IEnumerator"), "IEnumerable.GetEnumerator")
            {
                Visibility = "",
                CodeString = "GetEnumerator()",
                Comment = "Returns an enumerator that iterates through all components."
            };

            // ToString
            yield return new Function(new AnyType("string"), "ToString")
            {
                Override = true,
                CodeString = "ToString(\", \")",
                Comment = "Returns a string representation of this vector using ', ' as a seperator."
            };
            yield return new Function(new AnyType("string"), "ToString")
            {
                ParameterString = "string sep",
                CodeString = Fields.Aggregated(" + sep + "),
                Comment = "Returns a string representation of this vector using a provided seperator."
            };
            if (!BaseType.Generic)
            {
                yield return new Function(new AnyType("string"), "ToString")
                {
                    ParameterString = "string sep, IFormatProvider provider",
                    CodeString = Fields.Select(f => f + ".ToString(provider)").Aggregated(" + sep + "),
                    Comment = "Returns a string representation of this vector using a provided seperator and a format provider for each component."
                };
                if (BaseType.HasFormatString)
                {
                    yield return new Function(new AnyType("string"), "ToString")
                    {
                        ParameterString = "string sep, string format",
                        CodeString = Fields.Select(f => f + ".ToString(format)").Aggregated(" + sep + "),
                        Comment = "Returns a string representation of this vector using a provided seperator and a format for each component."
                    };
                    yield return new Function(new AnyType("string"), "ToString")
                    {
                        ParameterString = "string sep, string format, IFormatProvider provider",
                        CodeString = Fields.Select(f => f + ".ToString(format, provider)").Aggregated(" + sep + "),
                        Comment = "Returns a string representation of this vector using a provided seperator and a format and format provider for each component."
                    };
                }
            }

            // IReadOnlyList
            yield return new Property("Count", BuiltinType.TypeInt)
            {
                GetterLine = Components.ToString(),
                Comment = string.Format("Returns the number of components ({0}).", Components)
            };

            yield return new Indexer(BaseType)
            {
                ParameterString = "int index",
                Getter = SwitchIndex(Components.ForIndexUpTo(i => string.Format("case {0}: return {1};", i, ArgOf(i)))),
                Setter = SwitchIndex(Components.ForIndexUpTo(i => string.Format("case {0}: {1} = value; break;", i, ArgOf(i)))),
                Comment = "Gets/Sets a specific indexed component (a bit slower than direct access)."
            };

            // Equality comparisons
            yield return new Function(BuiltinType.TypeBool, "Equals")
            {
                ParameterString = NameThat + " rhs",
                CodeString = Fields.Select(Comparer).Aggregated(" && "),
                Comment = "Returns true iff this equals rhs component-wise."
            };

            yield return new Function(BuiltinType.TypeBool, "Equals")
            {
                Override = true,
                ParameterString = "object obj",
                Code = new[]
                {
                    "if (ReferenceEquals(null, obj)) return false;",
                    string.Format("return obj is {0} && Equals(({0}) obj);", NameThat)
                },
                Comment = "Returns true iff this equals rhs type- and component-wise."
            };

            yield return new Operator(BuiltinType.TypeBool, "==")
            {
                Parameters = this.LhsRhs(),
                CodeString = "lhs.Equals(rhs)",
                Comment = "Returns true iff this equals rhs component-wise."
            };

            yield return new Operator(BuiltinType.TypeBool, "!=")
            {
                Parameters = this.LhsRhs(),
                CodeString = "!lhs.Equals(rhs)",
                Comment = "Returns true iff this does not equal rhs (component-wise)."
            };

            yield return new Function(BuiltinType.TypeInt, "GetHashCode")
            {
                Override = true,
                Code = new[]
                {
                    "unchecked",
                    "{",
                    string.Format("    return {0};", HashCodeFor(Components - 1)),
                    "}"
                },
                Comment = "Returns a hash code for this instance."
            };

            // Component-wise static functions
            yield return new ComponentWiseStaticFunction(Fields, boolVType, "Equal", this, "lhs", this, "rhs", BaseType.EqualFormat);
            yield return new ComponentWiseStaticFunction(Fields, boolVType, "NotEqual", this, "lhs", this, "rhs", BaseType.NotEqualFormat);

            if (BaseType.HasComparisons)
            {
                yield return new ComponentWiseStaticFunction(Fields, boolVType, "GreaterThan", this, "lhs", this, "rhs", "{0} > {1}");
                yield return new ComponentWiseStaticFunction(Fields, boolVType, "GreaterThanEqual", this, "lhs", this, "rhs", "{0} >= {1}");
                yield return new ComponentWiseStaticFunction(Fields, boolVType, "LesserThan", this, "lhs", this, "rhs", "{0} < {1}");
                yield return new ComponentWiseStaticFunction(Fields, boolVType, "LesserThanEqual", this, "lhs", this, "rhs", "{0} <= {1}");

                yield return new ComponentWiseOperator(Fields, boolVType, "<", this, "lhs", this, "rhs", "{0} < {1}");
                yield return new ComponentWiseOperator(Fields, boolVType, "<=", this, "lhs", this, "rhs", "{0} <= {1}");
                yield return new ComponentWiseOperator(Fields, boolVType, ">", this, "lhs", this, "rhs", "{0} > {1}");
                yield return new ComponentWiseOperator(Fields, boolVType, ">=", this, "lhs", this, "rhs", "{0} >= {1}");
            }

            if (BaseType.IsBool)
            {
                yield return new ComponentWiseStaticFunction(Fields, boolVType, "Not", this, "v", "!{0}");
                yield return new ComponentWiseOperator(Fields, this, "!", this, "v", "!{0}");

                yield return new ComponentWiseStaticFunction(Fields, this, "And", this, "lhs", this, "rhs", "{0} && {1}");
                yield return new ComponentWiseStaticFunction(Fields, this, "Nand", this, "lhs", this, "rhs", "!({0} && {1})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Or", this, "lhs", this, "rhs", "{0} || {1}");
                yield return new ComponentWiseStaticFunction(Fields, this, "Nor", this, "lhs", this, "rhs", "!({0} || {1})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Xor", this, "lhs", this, "rhs", "{0} != {1}");
                yield return new ComponentWiseStaticFunction(Fields, this, "Xnor", this, "lhs", this, "rhs", "{0} == {1}");
                yield return new ComponentWiseOperator(Fields, this, "&", this, "lhs", this, "rhs", "{0} && {1}");
                yield return new ComponentWiseOperator(Fields, this, "|", this, "lhs", this, "rhs", "{0} || {1}");
            }

            // Basetype test functions
            foreach (var kvp in BaseType.TypeTestFuncs)
                yield return new ComponentWiseStaticFunction(Fields, boolVType, kvp.Key, this, "v", kvp.Value);

            if (BaseType.HasArithmetics)
            {
                yield return new ComponentWiseStaticFunction(Fields, absVType, "Abs", this, "v", AbsString("{0}"));
                yield return new ComponentWiseStaticFunction(Fields, this, "HermiteInterpolationOrder3", this, "v", "(3 - 2 * {0}) * {0} * {0}");
                yield return new ComponentWiseStaticFunction(Fields, this, "HermiteInterpolationOrder5", this, "v", "((6 * {0} - 15) * {0} + 10) * {0} * {0} * {0}");

                yield return new ComponentWiseStaticFunction(Fields, this, "Sqr", this, "v", "{0} * {0}");
                yield return new ComponentWiseStaticFunction(Fields, this, "Pow2", this, "v", "{0} * {0}");
                yield return new ComponentWiseStaticFunction(Fields, this, "Pow3", this, "v", "{0} * {0} * {0}");

                if (BaseType.IsComplex)
                {
                    yield return new ComponentWiseStaticFunction(Fields, this, "Acos", this, "v", "Complex.Acos({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Asin", this, "v", "Complex.Asin({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Atan", this, "v", "Complex.Atan({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Cos", this, "v", "Complex.Cos({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Cosh", this, "v", "Complex.Cosh({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Exp", this, "v", "Complex.Exp({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Log", this, "v", "Complex.Log({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Log2", this, "v", "Complex.Log({0}, 2.0)");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Log10", this, "v", "Complex.Log10({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Reciprocal", this, "v", "Complex.Reciprocal({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Sin", this, "v", "Complex.Sin({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Sinh", this, "v", "Complex.Sinh({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Sqrt", this, "v", "Complex.Sqrt({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Tan", this, "v", "Complex.Tan({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Tanh", this, "v", "Complex.Tanh({0})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Conjugate", this, "v", "Complex.Conjugate({0})");

                    yield return new ComponentWiseStaticFunction(Fields, this, "Pow", this, "lhs", this, "rhs", "Complex.Pow({0}, {1})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Log", this, "lhs", doubleVType, "rhs", "Complex.Log({0}, {1})");

                    yield return new ComponentWiseStaticFunction(Fields, this, "FromPolarCoordinates", doubleVType, "magnitude", doubleVType, "phase", "Complex.FromPolarCoordinates({0}, {1})");
                }
                else
                {
                    // TODO: Acosh, Asinh, Atanh

                    yield return new ComponentWiseStaticFunction(Fields, this, "Step", this, "v", string.Format("{{0}} >= {0} ? {1} : {0}", ZeroValue, OneValue));
                    yield return new ComponentWiseStaticFunction(Fields, this, "Sqrt", this, "v", string.Format("({0})Math.Sqrt((double){{0}})", BaseTypeName));
                    yield return new ComponentWiseStaticFunction(Fields, integerVType, "Sign", this, "v", "Math.Sign({0})");

                    yield return new ComponentWiseStaticFunction(Fields, this, "Max", this, "lhs", this, "rhs", "Math.Max({0}, {1})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Min", this, "lhs", this, "rhs", "Math.Min({0}, {1})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Pow", this, "lhs", this, "rhs", BaseTypeCast + "Math.Pow((double){0}, (double){1})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Log", this, "lhs", this, "rhs", BaseTypeCast + "Math.Log((double){0}, (double){1})");

                    // TODO: Check if v > max ? max : v < min ? min : v is faster
                    yield return new ComponentWiseStaticFunction(Fields, this, "Clamp", this, "v", this, "min", this, "max", "Math.Min(Math.Max({0}, {1}), {2})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Mix", this, "min", this, "max", this, "a", "{0} * (1-{2}) + {1} * {2}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Lerp", this, "min", this, "max", this, "a", "{0} * (1-{2}) + {1} * {2}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Smoothstep", this, "edge0", this, "edge1", this, "v", "(({2} - {0}) / ({1} - {0})).Clamp().HermiteInterpolationOrder3()");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Smootherstep", this, "edge0", this, "edge1", this, "v", "(({2} - {0}) / ({1} - {0})).Clamp().HermiteInterpolationOrder5()");
                }

                // Operators
                yield return new ComponentWiseStaticFunction(Fields, this, "Add", this, "lhs", this, "rhs", "{0} + {1}");
                yield return new ComponentWiseStaticFunction(Fields, this, "Sub", this, "lhs", this, "rhs", "{0} - {1}");
                yield return new ComponentWiseStaticFunction(Fields, this, "Mul", this, "lhs", this, "rhs", "{0} * {1}");
                yield return new ComponentWiseStaticFunction(Fields, this, "Div", this, "lhs", this, "rhs", "{0} / {1}");

                yield return new ComponentWiseOperator(Fields, this, "+", this, "lhs", this, "rhs", "{0} + {1}");
                yield return new ComponentWiseOperator(Fields, this, "-", this, "lhs", this, "rhs", "{0} - {1}");
                yield return new ComponentWiseOperator(Fields, this, "*", this, "lhs", this, "rhs", "{0} * {1}");
                yield return new ComponentWiseOperator(Fields, this, "/", this, "lhs", this, "rhs", "{0} / {1}");

                yield return new ComponentWiseOperator(Fields, this, "+", this, "v", "~~~") { ReturnOverride = "v" };

                if (BaseType.IsSigned)
                    yield return new ComponentWiseOperator(Fields, this, "-", this, "v", "-{0}");

                if (BaseType.IsInteger)
                {
                    yield return new ComponentWiseStaticFunction(Fields, this, "Modulo", this, "lhs", this, "rhs", "{0} % {1}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Xor", this, "lhs", this, "rhs", "{0} ^ {1}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "BitwiseOr", this, "lhs", this, "rhs", "{0} | {1}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "BitwiseAnd", this, "lhs", this, "rhs", "{0} & {1}");

                    yield return new ComponentWiseOperator(Fields, this, "~", this, "v", "~{0}");
                    yield return new ComponentWiseOperator(Fields, this, "%", this, "lhs", this, "rhs", "{0} % {1}");
                    yield return new ComponentWiseOperator(Fields, this, "^", this, "lhs", this, "rhs", "{0} ^ {1}");
                    yield return new ComponentWiseOperator(Fields, this, "|", this, "lhs", this, "rhs", "{0} | {1}");
                    yield return new ComponentWiseOperator(Fields, this, "&", this, "lhs", this, "rhs", "{0} & {1}");

                    yield return new ComponentWiseStaticFunction(Fields, this, "LeftShift", this, "lhs", integerVType, "rhs", "{0} << {1}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "RightShift", this, "lhs", integerVType, "rhs", "{0} >> {1}");
                    yield return new ComponentWiseOperator(Fields, this, "<<", this, "lhs", BuiltinType.TypeInt, "rhs", "{0} << {1}") { CanScalar0 = false, CanScalar1 = false };
                    yield return new ComponentWiseOperator(Fields, this, ">>", this, "lhs", BuiltinType.TypeInt, "rhs", "{0} >> {1}") { CanScalar0 = false, CanScalar1 = false };
                }
            }

            if (BaseType.IsFloatingPoint)
            {
                yield return new ComponentWiseStaticFunction(Fields, this, "Degrees", this, "v", "{0} * " + ConstantSuffixFor("57.295779513082320876798154814105170332405472466564321")) { AdditionalComment = "Radians-To-Degrees Conversion" };
                yield return new ComponentWiseStaticFunction(Fields, this, "Radians", this, "v", "{0} * " + ConstantSuffixFor("0.0174532925199432957692369076848861271344287188854172")) { AdditionalComment = "Degrees-To-Radians Conversion" };

                yield return new ComponentWiseStaticFunction(Fields, this, "Acos", this, "v", string.Format("({0})Math.Acos((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Asin", this, "v", string.Format("({0})Math.Asin((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Atan", this, "v", string.Format("({0})Math.Atan((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Cos", this, "v", string.Format("({0})Math.Cos((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Cosh", this, "v", string.Format("({0})Math.Cosh((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Exp", this, "v", string.Format("({0})Math.Exp((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Log", this, "v", string.Format("({0})Math.Log((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Log2", this, "v", string.Format("({0})Math.Log((double){{0}}, 2)", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Log10", this, "v", string.Format("({0})Math.Log10((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Floor", this, "v", string.Format("({0})Math.Floor({{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Ceiling", this, "v", string.Format("({0})Math.Ceiling({{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Round", this, "v", string.Format("({0})Math.Round({{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Sin", this, "v", string.Format("({0})Math.Sin((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Sinh", this, "v", string.Format("({0})Math.Sinh((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Tan", this, "v", string.Format("({0})Math.Tan((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Tanh", this, "v", string.Format("({0})Math.Tanh((double){{0}})", BaseTypeName));
                yield return new ComponentWiseStaticFunction(Fields, this, "Truncate", this, "v", string.Format("({0})Math.Truncate((double){{0}})", BaseTypeName));
            }


            // Logicals
            if (BaseType.IsBool)
            {
                yield return new AggregatedProperty(Fields, "MinElement", BaseType, "&&", "Returns the minimal component of this vector.");
                yield return new AggregatedProperty(Fields, "MaxElement", BaseType, "||", "Returns the maximal component of this vector.");
                yield return new AggregatedProperty(Fields, "All", BaseType, "&&", "Returns true if all component are true.");
                yield return new AggregatedProperty(Fields, "Any", BaseType, "||", "Returns true if any component is true.");
            }
        }

        protected override IEnumerable<string> Body
        {
            get
            {

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
                }
            }
        }

    }
}
