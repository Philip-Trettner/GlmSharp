using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Members;

namespace GlmSharpGenerator.Types
{
    class QuaternionType : AbstractType
    {
        public int Components { get; set; } = 4;

        public QuaternionType(BuiltinType type)
        {
            BaseType = type;
            BaseName = type.Prefix + "quat";
        }

        public override string Name => BaseName;

        public override string TypeComment => string.Format("A quaternion of type {0}.", BaseTypeName);


        public IEnumerable<string> Fields => "xyzw".Substring(0, Components).Select(c => c.ToString());


        public override string Folder => "Quat";

        public string CompString => "xyzw".Substring(0, Components);


        public override IEnumerable<string> BaseClasses
        {
            get
            {
                yield return string.Format("IReadOnlyList<{0}>", BaseTypeName);
                yield return string.Format("IEquatable<{0}>", NameThat);
            }
        }

        public string CompArgString => CompString.CommaSeparated();


        public char ArgOf(int c) => "xyzw"[c];
        public string ArgOfs(int c) => "xyzw"[c].ToString();
        public char ArgOfUpper(int c) => char.ToUpper("xyzw"[c]);

        public IEnumerable<string> SubCompParameters(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => BaseTypeName + " " + c);
        public string SubCompParameterString(int start, int end) => SubCompParameters(start, end).CommaSeparated();
        public IEnumerable<string> SubCompArgs(int start, int end) => "xyzw".Substring(start, end - start + 1).Select(c => c.ToString());

        public string HashCodeFor(int c) => (c == 0 ? "" : string.Format("(({0}) * {1}) ^ ", HashCodeFor(c - 1), BaseType.HashCodeMultiplier)) + HashCodeOf(ArgOf(c).ToString());


        public override IEnumerable<Member> GenerateMembers()
        {
            var boolVType = new VectorType(BuiltinType.TypeBool, Components);
            var mat3Type = new MatrixType(BaseType, 3, 3);
            var mat4Type = new MatrixType(BaseType, 4, 4);
            var vec3Type = new VectorType(BaseType, 3);
            var vec4Type = new VectorType(BaseType, 4);
            var dvec3Type = new VectorType(BuiltinType.TypeDouble, 3);
            var lengthType = new AnyType(BaseType.LengthType);

            // fields
            foreach (var f in Fields)
                yield return new Field(f, BaseType)
                {
                    Comment = string.Format("{0}-component", f)
                };


            // predefs
            yield return new StaticProperty("Zero", this)
            {
                Value = Construct(this, ZeroValue.RepeatTimes(Components)),
                Comment = "Predefined all-zero quaternion"
            };

            if (!string.IsNullOrEmpty(BaseType.OneValue))
            {
                yield return new StaticProperty("Ones", this)
                {
                    Value = Construct(this, OneValue.RepeatTimes(Components)),
                    Comment = "Predefined all-ones quaternion"
                };

                yield return new StaticProperty("Identity", this)
                {
                    Value = Construct(this, Fields.Select(f => f == "w" ? OneValue : ZeroValue)),
                    Comment = "Predefined identity quaternion"
                };

                for (var c = 0; c < Components; ++c)
                    yield return new StaticProperty("Unit" + ArgOfUpper(c), this)
                    {
                        Value = Construct(this, c.ImpulseString(BaseType.OneValue, ZeroValue, Components)),
                        Comment = string.Format("Predefined unit-{0} quaternion", ArgOfUpper(c))
                    };
            }

            if (BaseType.IsComplex)
            {
                yield return new StaticProperty("ImaginaryOnes", this)
                {
                    Value = Construct(this, "Complex.ImaginaryOne".RepeatTimes(Components)),
                    Comment = "Predefined all-imaginary-ones quaternion"
                };

                for (var c = 0; c < Components; ++c)
                    yield return new StaticProperty("ImaginaryUnit" + ArgOfUpper(c), this)
                    {
                        Value = Construct(this, c.ImpulseString("Complex.ImaginaryOne", ZeroValue, Components)),
                        Comment = string.Format("Predefined unit-imaginary-{0} quaternion", ArgOfUpper(c))
                    };
            }

            // Basetype constants
            foreach (var constant in BaseType.TypeConstants)
            {
                yield return new StaticProperty(constant, this)
                {
                    Value = Construct(this, string.Format("{0}.{1}", BaseTypeName, constant).RepeatTimes(Components)),
                    Comment = string.Format("Predefined all-{0} quaternion", constant)
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
            yield return new Constructor(this, Fields)
            {
                ParameterString = this.NameThat + " q",
                Initializers = Fields.Select(f => "q." + f),
                Comment = "copy constructor"
            };
            yield return new Constructor(this, Fields)
            {
                ParameterString = vec3Type.NameThat + " v, " + BaseTypeName + " s",
                Initializers = new[] { "v.x", "v.y", "v.z", "s" },
                Comment = "vector-and-scalar constructor (CAUTION: not angle-axis, use FromAngleAxis instead)"
            };
            if (BaseType.IsFloatingPoint)
            {
                // from angle between axes
                yield return new Constructor(this, Fields)
                {
                    Parameters = vec3Type.TypedArgs("u", "v"),
                    Code = new[]
                    {
                        string.Format("var localW = {0}.Cross(u, v);", vec3Type.NameThat),
                        string.Format("var dot = {0}.Dot(u, v);", vec3Type.NameThat),
                        string.Format("var q = new {0}(localW.x, localW.y, localW.z, {1} + dot).Normalized;", NameThat, OneValue)
                    },
                    Initializers = new[] { "q.x", "q.y", "q.z", "q.w" },
                    Comment = "Create a quaternion from two normalized axis (http://lolengine.net/blog/2013/09/18/beautiful-maths-quaternion-from-vectors)"
                };

                // from euler angle
                yield return new Constructor(this, Fields)
                {
                    Parameters = vec3Type.TypedArgs("eulerAngle"),
                    Code = new[]
                    {
                        string.Format("var c = {0}.Cos(eulerAngle / 2);", vec3Type.NameThat),
                        string.Format("var s = {0}.Sin(eulerAngle / 2);", vec3Type.NameThat),
                    },
                    Initializers = new[]
                    {
                        "s.x * c.y * c.z - c.x * s.y * s.z",
                        "c.x * s.y * c.z + s.x * c.y * s.z",
                        "c.x * c.y * s.z - s.x * s.y * c.z",
                        "c.x * c.y * c.z + s.x * s.y * s.z"
                    },
                    Comment = "Create a quaternion from two normalized axis (http://lolengine.net/blog/2013/09/18/beautiful-maths-quaternion-from-vectors)"
                };

                // from matrices
                yield return new Constructor(this, Fields)
                {
                    ParameterString = mat3Type.Name + " m",
                    ConstructorChain = "this(FromMat3(m))",
                    Comment = string.Format("Creates a quaternion from the rotational part of a {0}.", mat3Type.Name)
                };
                yield return new Constructor(this, Fields)
                {
                    ParameterString = mat4Type.Name + " m",
                    ConstructorChain = "this(FromMat4(m))",
                    Comment = string.Format("Creates a quaternion from the rotational part of a {0}.", mat4Type.Name)
                };
            }


            // implicit upcasts
            var implicits = new HashSet<BuiltinType>();
            var upcasts = BuiltinType.Upcasts;
            foreach (var ukvp in upcasts.Where(k => k.Key == BaseType))
            {
                var otherType = ukvp.Value;
                implicits.Add(otherType);
                var targetType = new QuaternionType(otherType);

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

                {
                    {
                        var targetType = new VectorType(otherType, Components);
                        yield return new ExplicitOperator(targetType)
                        {
                            ParameterString = NameThat + " v",
                            CodeString = Construct(targetType, CompString.Select(c => TypeCast(otherType, "v." + c))),
                            Comment = string.Format("Explicitly converts this to a {0}.", targetType.Name)
                        };
                    }

                    if (otherType == BaseType)
                        continue; // same type and comps not useful

                    if (implicits.Contains(otherType))
                        continue; // already has an implicit conversion

                    {
                        var targetType = new QuaternionType(otherType);
                        yield return new ExplicitOperator(targetType)
                        {
                            ParameterString = NameThat + " v",
                            CodeString = Construct(targetType, CompString.Select(c => TypeCast(otherType, "v." + c))),
                            Comment = string.Format("Explicitly converts this to a {0}.", targetType.Name)
                        };
                    }
                }
            }
            // from matrices
            if (BaseType.IsFloatingPoint)
            {
                yield return new ExplicitOperator(this)
                {
                    ParameterString = mat3Type.Name + " m",
                    CodeString = "FromMat3(m)",
                    Comment = string.Format("Creates a quaternion from the rotational part of a {0}.", mat3Type.Name)
                };
                yield return new ExplicitOperator(this)
                {
                    ParameterString = mat4Type.Name + " m",
                    CodeString = "FromMat4(m)",
                    Comment = string.Format("Creates a quaternion from the rotational part of a {0}.", mat4Type.Name)
                };
            }


            // IEnumerable
            yield return new Function(new AnyType(string.Format("IEnumerator<{0}>", BaseTypeName)), "GetEnumerator")
            {
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
                Comment = "Returns a string representation of this quaternion using ', ' as a seperator."
            };
            yield return new Function(new AnyType("string"), "ToString")
            {
                ParameterString = "string sep",
                CodeString = Fields.Aggregated(" + sep + "),
                Comment = "Returns a string representation of this quaternion using a provided seperator."
            };
            if (!BaseType.Generic)
            {
                yield return new Function(new AnyType("string"), "ToString")
                {
                    ParameterString = "string sep, IFormatProvider provider",
                    CodeString = Fields.Select(f => f + ".ToString(provider)").Aggregated(" + sep + "),
                    Comment = "Returns a string representation of this quaternion using a provided seperator and a format provider for each component."
                };
                if (BaseType.HasFormatString)
                {
                    yield return new Function(new AnyType("string"), "ToString")
                    {
                        ParameterString = "string sep, string format",
                        CodeString = Fields.Select(f => f + ".ToString(format)").Aggregated(" + sep + "),
                        Comment = "Returns a string representation of this quaternion using a provided seperator and a format for each component."
                    };
                    yield return new Function(new AnyType("string"), "ToString")
                    {
                        ParameterString = "string sep, string format, IFormatProvider provider",
                        CodeString = Fields.Select(f => f + ".ToString(format, provider)").Aggregated(" + sep + "),
                        Comment = "Returns a string representation of this quaternion using a provided seperator and a format and format provider for each component."
                    };
                }
            }

            // Parsing
            if (!BaseType.IsComplex && !BaseType.Generic)
            {
                // Parse
                yield return new Function(this, "Parse")
                {
                    Static = true,
                    ParameterString = "string s",
                    CodeString = "Parse(s, \", \")",
                    Comment = "Converts the string representation of the quaternion into a quaternion representation (using ', ' as a separator)."
                };

                yield return new Function(this, "Parse")
                {
                    Static = true,
                    ParameterString = "string s, string sep",
                    Code = new[]
                    {
                        "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                        string.Format("if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components),
                        string.Format("return new {0}({1});", NameThat, Components.ForIndexUpTo(i => string.Format("{0}.Parse(kvp[{1}].Trim())", BaseTypeName, i)).CommaSeparated())
                    },
                    Comment = "Converts the string representation of the quaternion into a quaternion representation (using a designated separator)."
                };

                if (BaseType.Name != "bool")
                {
                    yield return new Function(this, "Parse")
                    {
                        Static = true,
                        ParameterString = "string s, string sep, IFormatProvider provider",
                        Code = new[]
                        {
                            "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                            string.Format("if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components),
                            string.Format("return new {0}({1});", NameThat, Components.ForIndexUpTo(i => string.Format("{0}.Parse(kvp[{1}].Trim(), provider)", BaseTypeName, i)).CommaSeparated())
                        },
                        Comment = "Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a type provider)."
                    };
                    yield return new Function(this, "Parse")
                    {
                        Static = true,
                        ParameterString = "string s, string sep, NumberStyles style",
                        Code = new[]
                        {
                            "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                            string.Format("if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components),
                            string.Format("return new {0}({1});", NameThat, Components.ForIndexUpTo(i => string.Format("{0}.Parse(kvp[{1}].Trim(), style)", BaseTypeName, i)).CommaSeparated())
                        },
                        Comment = "Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style)."
                    };
                    yield return new Function(this, "Parse")
                    {
                        Static = true,
                        ParameterString = "string s, string sep, NumberStyles style, IFormatProvider provider",
                        Code = new[]
                        {
                            "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                            string.Format("if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components),
                            string.Format("return new {0}({1});", NameThat, Components.ForIndexUpTo(i => string.Format("{0}.Parse(kvp[{1}].Trim(), style, provider)", BaseTypeName, i)).CommaSeparated())
                        },
                        Comment = "Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider)."
                    };
                }

                // TryParse
                yield return new Function(BuiltinType.TypeBool, "TryParse")
                {
                    Static = true,
                    ParameterString = string.Format("string s, out {0} result", NameThat),
                    CodeString = "TryParse(s, \", \", out result)",
                    Comment = "Tries to convert the string representation of the quaternion into a quaternion representation (using ', ' as a separator), returns false if string was invalid."
                };

                yield return new Function(BuiltinType.TypeBool, "TryParse")
                {
                    Static = true,
                    ParameterString = string.Format("string s, string sep, out {0} result", NameThat),
                    Code = new[]
                    {
                        "result = Zero;",
                        "if (string.IsNullOrEmpty(s)) return false;",
                        "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                        string.Format("if (kvp.Length != {0}) return false;", Components),
                        string.Format("{0} {1};", BaseTypeName, CompString.Select(c => c + " = " + ZeroValue).CommaSeparated()),
                        string.Format("var ok = {0};", Components.ForIndexUpTo(i => string.Format("{0}.TryParse(kvp[{1}].Trim(), out {2})", BaseTypeName, i, ArgOf(i))).Aggregated(" && ")),
                        string.Format("result = ok ? new {0}({1}) : Zero;", NameThat, CompArgString),
                        "return ok;"
                    },
                    Comment = "Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator), returns false if string was invalid."
                };

                if (!BaseType.IsBool)
                {
                    yield return new Function(BuiltinType.TypeBool, "TryParse")
                    {
                        Static = true,
                        ParameterString = string.Format("string s, string sep, NumberStyles style, IFormatProvider provider, out {0} result", NameThat),
                        Code = new[]
                        {
                            "result = Zero;",
                            "if (string.IsNullOrEmpty(s)) return false;",
                            "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                            string.Format("if (kvp.Length != {0}) return false;", Components),
                            string.Format("{0} {1};", BaseTypeName, CompString.Select(c => c + " = " + ZeroValue).CommaSeparated()),
                            string.Format("var ok = {0};", Components.ForIndexUpTo(i => string.Format("{0}.TryParse(kvp[{1}].Trim(), style, provider, out {2})", BaseTypeName, i, ArgOf(i))).Aggregated(" && ")),
                            string.Format("result = ok ? new {0}({1}) : Zero;", NameThat, CompArgString),
                            "return ok;"
                        },
                        Comment = "Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider), returns false if string was invalid."
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

            // Basetype test functions
            foreach (var kvp in BaseType.TypeTestFuncs)
                yield return new ComponentWiseStaticFunction(Fields, boolVType, kvp.Key, this, "v", kvp.Value);

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

            if (BaseType.HasArithmetics)
            {
                // ops
                yield return new ComponentWiseOperator(Fields, this, "+", this, "v", "identity") { ReturnOverride = "v" };

                if (BaseType.IsSigned)
                    yield return new ComponentWiseOperator(Fields, this, "-", this, "v", "-{0}");

                yield return new ComponentWiseOperator(Fields, this, "+", this, "lhs", this, "rhs", "{0} + {1}");
                yield return new ComponentWiseOperator(Fields, this, "-", this, "lhs", this, "rhs", "{0} - {1}");
                yield return new ComponentWiseOperator(Fields, this, "*", this, "lhs", BaseType, "rhs", "{0} * {1}") { CanScalar0 = false, CanScalar1 = false };
                yield return new ComponentWiseOperator(Fields, this, "*", BaseType, "lhs", this, "rhs", "{0} * {1}") { CanScalar0 = false, CanScalar1 = false };
                yield return new ComponentWiseOperator(Fields, this, "/", this, "lhs", BaseType, "rhs", "{0} / {1}") { CanScalar0 = false, CanScalar1 = false };

                // quat-quat-mult
                yield return new Operator(this, "*")
                {
                    Parameters = this.TypedArgs("p", "q"),
                    CodeString = Construct(this,
                        "p.w * q.x + p.x * q.w + p.y * q.z - p.z * q.y",
                        "p.w * q.y + p.y * q.w + p.z * q.x - p.x * q.z",
                        "p.w * q.z + p.z * q.w + p.x * q.y - p.y * q.x",
                        "p.w * q.w - p.x * q.x - p.y * q.y - p.z * q.z"),
                    Comment = "Returns proper multiplication of two quaternions."
                };
                // quat-vec-mult, vec-quat-mult
                yield return new Operator(vec3Type, "*")
                {
                    Parameters = this.TypedArgs("q").Concat(vec3Type.TypedArgs("v")),
                    Code = new[]
                    {
                        string.Format("var qv = {0};", Construct(vec3Type, "q.x", "q.y", "q.z")),
                        string.Format("var uv = {0}.Cross(qv, v);", vec3Type.Name),
                        string.Format("var uuv = {0}.Cross(qv, uv);", vec3Type.Name),
                        "return v + ((uv * q.w) + uuv) * 2;"
                    },
                    Comment = "Returns a vector rotated by the quaternion."
                };
                yield return new Operator(vec4Type, "*")
                {
                    Parameters = this.TypedArgs("q").Concat(vec4Type.TypedArgs("v")),
                    CodeString = Construct(vec4Type, "q * " + Construct(vec3Type, "v"), "v.w"),
                    Comment = "Returns a vector rotated by the quaternion (preserves v.w)."
                };
                if (BaseType.IsSigned)
                {
                    yield return new Operator(vec3Type, "*")
                    {
                        Parameters = vec3Type.TypedArgs("v").Concat(this.TypedArgs("q")),
                        CodeString = "q.Inverse * v",
                        Comment = "Returns a vector rotated by the inverted quaternion."
                    };
                    yield return new Operator(vec4Type, "*")
                    {
                        Parameters = vec4Type.TypedArgs("v").Concat(this.TypedArgs("q")),
                        CodeString = "q.Inverse * v",
                        Comment = "Returns a vector rotated by the inverted quaternion (preserves v.w)."
                    };
                }

                // dot
                yield return new Function(BaseType, "Dot")
                {
                    Static = true,
                    Parameters = this.LhsRhs(),
                    CodeString = Fields.Format(DotFormatString).Aggregated(" + "),
                    Comment = "Returns the inner product (dot product, scalar product) of the two quaternions."
                };

                // length
                yield return new Property("Length", lengthType)
                {
                    GetterLine = "(" + lengthType.Name + ")" + SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")),
                    Comment = "Returns the euclidean length of this quaternion."
                };
                yield return new Property("LengthSqr", BaseType)
                {
                    GetterLine = Fields.Select(SqrOf).Aggregated(" + "),
                    Comment = "Returns the squared euclidean length of this quaternion."
                };

                // normalized
                if (!BaseType.IsInteger)
                {
                    yield return new Property("Normalized", this)
                    {
                        GetterLine = "this / Length",
                        Comment = "Returns a copy of this quaternion with length one (undefined if this has zero length)."
                    };
                    yield return new Property("NormalizedSafe", this)
                    {
                        GetterLine = "this == Zero ? Identity : this / Length",
                        Comment = "Returns a copy of this quaternion with length one (returns zero if length is zero)."
                    };
                }
            }

            // Logicals
            if (BaseType.IsBool)
            {
                yield return new AggregatedProperty(Fields, "MinElement", BaseType, "&&", "Returns the minimal component of this quaternion.");
                yield return new AggregatedProperty(Fields, "MaxElement", BaseType, "||", "Returns the maximal component of this quaternion.");
                yield return new AggregatedProperty(Fields, "All", BaseType, "&&", "Returns true if all component are true.");
                yield return new AggregatedProperty(Fields, "Any", BaseType, "||", "Returns true if any component is true.");
            }

            // floating point
            if (BaseType.IsFloatingPoint)
            {
                // angles
                yield return new Property("Angle", BuiltinType.TypeDouble)
                {
                    GetterLine = "Math.Acos((double)w) * 2.0",
                    Comment = "Returns the represented angle of this quaternion"
                };

                yield return new Property("Axis", vec3Type)
                {
                    Getter = new[]
                    {
                        "var s1 = 1 - w * w;",
                        string.Format("if (s1 < 0) return {0}.UnitZ;", vec3Type.Name),
                        string.Format("var s2 = 1 / {0};", SqrtOf("s1")),
                        string.Format("return {0};", Construct(vec3Type, BaseTypeCast + "(x * s2)", BaseTypeCast + "(y * s2)", BaseTypeCast + "(z * s2)"))
                    },
                    Comment = "Returns the represented axis of this quaternion"
                };

                yield return new Property("Yaw", BuiltinType.TypeDouble)
                {
                    GetterLine = "Math.Asin(-2.0 * (double)(x * z - w * y))",
                    Comment = "Returns the represented yaw angle of this quaternion"
                };

                yield return new Property("Pitch", BuiltinType.TypeDouble)
                {
                    GetterLine = "Math.Atan2(2.0 * (double)(y * z + w * x), (double)(w * w - x * x - y * y + z * z))",
                    Comment = "Returns the represented pitch angle of this quaternion"
                };

                yield return new Property("Roll", BuiltinType.TypeDouble)
                {
                    GetterLine = "Math.Atan2(2.0 * (double)(x * y + w * z), (double)(w * w + x * x - y * y - z * z))",
                    Comment = "Returns the represented roll angle of this quaternion"
                };

                yield return new Property("EulerAngles", dvec3Type)
                {
                    GetterLine = Construct(dvec3Type, "Pitch", "Yaw", "Roll"),
                    Comment = "Returns the represented euler angles (pitch, yaw, roll) of this quaternion"
                };

                yield return new Function(this, "FromAxisAngle")
                {
                    Static = true,
                    Parameters = BaseType.TypedArgs("angle").Concat(vec3Type.TypedArgs("v")),
                    Code = new[]
                    {
                        "var s = Math.Sin((double)angle * 0.5);",
                        "var c = Math.Cos((double)angle * 0.5);",
                        string.Format("return {0};", Construct(this, BaseTypeCast + "((double)v.x * s)", BaseTypeCast + "((double)v.y * s)", BaseTypeCast + "((double)v.z * s)", BaseTypeCast + "c"))
                    },
                    Comment = "Creates a quaternion from an axis and an angle (in radians)"
                };
            }

            // mat casts
            if (BaseType.IsFloatingPoint)
            {
                yield return new Property("ToMat3", mat3Type)
                {
                    GetterLine = Construct(mat3Type,
                        "1 - 2 * (y*y + z*z)",
                        "2 * (x*y + w*z)",
                        "2 * (x*z - w*y)",

                        "2 * (x*y - w*z)",
                        "1 - 2 * (x*x + z*z)",
                        "2 * (y*z + w*x)",

                        "2 * (x*z + w*y)",
                        "2 * (y*z - w*x)",
                        "1 - 2 * (x*x + y*y)"
                        ),
                    Comment = string.Format("Creates a {0} that realizes the rotation of this quaternion", mat3Type.Name)
                };

                yield return new Property("ToMat4", mat4Type)
                {
                    GetterLine = Construct(mat4Type, "ToMat3"),
                    Comment = string.Format("Creates a {0} that realizes the rotation of this quaternion", mat4Type.Name)
                };

                yield return new Function(this, "FromMat3")
                {
                    Static = true,
                    Parameters = mat3Type.TypedArgs("m"),
                    Code = new[]
                    {
                        "var fourXSquaredMinus1 = m.m00 - m.m11 - m.m22;",
                        "var fourYSquaredMinus1 = m.m11 - m.m00 - m.m22;",
                        "var fourZSquaredMinus1 = m.m22 - m.m00 - m.m11;",
                        "var fourWSquaredMinus1 = m.m00 + m.m11 + m.m22;",
                        "var biggestIndex = 0;",
                        "var fourBiggestSquaredMinus1 = fourWSquaredMinus1;",
                        "if(fourXSquaredMinus1 > fourBiggestSquaredMinus1)",
                        "{",
                        "    fourBiggestSquaredMinus1 = fourXSquaredMinus1;",
                        "    biggestIndex = 1;",
                        "}",
                        "if(fourYSquaredMinus1 > fourBiggestSquaredMinus1)",
                        "{",
                        "    fourBiggestSquaredMinus1 = fourYSquaredMinus1;",
                        "    biggestIndex = 2;",
                        "}",
                        "if(fourZSquaredMinus1 > fourBiggestSquaredMinus1)",
                        "{",
                        "    fourBiggestSquaredMinus1 = fourZSquaredMinus1;",
                        "    biggestIndex = 3;",
                        "}",
                        "var biggestVal = Math.Sqrt((double)fourBiggestSquaredMinus1 + 1.0) * 0.5;",
                        "var mult = 0.25 / biggestVal;",
                        "switch(biggestIndex)",
                        "{",
                        string.Format("    case 0: return {0};", Construct(this, BaseTypeCast + "((double)(m.m12 - m.m21) * mult)", BaseTypeCast + "((double)(m.m20 - m.m02) * mult)", BaseTypeCast + "((double)(m.m01 - m.m10) * mult)", BaseTypeCast + "(biggestVal)")),
                        string.Format("    case 1: return {0};", Construct(this, BaseTypeCast + "(biggestVal)", BaseTypeCast + "((double)(m.m01 + m.m10) * mult)", BaseTypeCast + "((double)(m.m20 + m.m02) * mult)", BaseTypeCast + "((double)(m.m12 - m.m21) * mult)")),
                        string.Format("    case 2: return {0};", Construct(this, BaseTypeCast + "((double)(m.m01 + m.m10) * mult)", BaseTypeCast + "(biggestVal)", BaseTypeCast + "((double)(m.m12 + m.m21) * mult)", BaseTypeCast + "((double)(m.m20 - m.m02) * mult)")),
                        string.Format("    default: return {0};", Construct(this, BaseTypeCast + "((double)(m.m20 + m.m02) * mult)", BaseTypeCast + "((double)(m.m12 + m.m21) * mult)", BaseTypeCast + "(biggestVal)", BaseTypeCast + "((double)(m.m01 - m.m10) * mult)")),
                        "}"
                    },
                    Comment = string.Format("Creates a quaternion from the rotational part of a {0}.", mat4Type.Name)
                };

                yield return new Function(this, "FromMat4")
                {
                    Static = true,
                    Parameters = mat4Type.TypedArgs("m"),
                    CodeString = string.Format("FromMat3({0})", Construct(mat3Type, "m")),
                    Comment = string.Format("Creates a quaternion from the rotational part of a {0}.", mat3Type.Name)
                };
            }

            if (BaseType.IsSigned)
            {
                yield return new Property("Conjugate", this)
                {
                    GetterLine = Construct(this, "-x", "-y", "-z", "w"),
                    Comment = "Returns the conjugated quaternion"
                };

                yield return new Property("Inverse", this)
                {
                    GetterLine = "Conjugate / LengthSqr",
                    Comment = "Returns the inverse quaternion"
                };
            }

            // cross
            if (BaseType.HasArithmetics)
            {
                yield return new Function(this, "Cross")
                {
                    Static = true,
                    Parameters = this.TypedArgs("q1", "q2"),
                    CodeString = Construct(this,
                        "q1.w * q2.x + q1.x * q2.w + q1.y * q2.z - q1.z * q2.y",
                        "q1.w * q2.y + q1.y * q2.w + q1.z * q2.x - q1.x * q2.z",
                        "q1.w * q2.z + q1.z * q2.w + q1.x * q2.y - q1.y * q2.x",
                        "q1.w * q2.w - q1.x * q2.x - q1.y * q2.y - q1.z * q2.z"),
                    Comment = "Returns the cross product between two quaternions."
                };
            }
        }
    }
}
