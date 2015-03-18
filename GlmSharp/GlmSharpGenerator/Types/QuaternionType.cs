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
            var vec3Type = new VectorType(BaseType, 3);
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
                ParameterString = vec3Type.NameThat + " v, " + BaseTypeName + " s",
                Initializers = new[] { "v.x", "v.y", "v.z", "s" },
                Comment = "vector-and-scalar constructor"
            };
            if (BaseType.IsFloatingPoint)
            {
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
            // mat4-cast
            /*{
                var targetType = new MatrixType(BaseType, 4, 4);
                yield return new ExplicitOperator(targetType)
                {
                    ParameterString = NameThat + " v",
                    CodeString = Construct(targetType, CompString.Select(c => TypeCast(otherType, "v." + c))),
                    Comment = string.Format("Explicitly converts this to a {0}.", targetType.Name)
                };
            }*/


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
                yield return new ComponentWiseOperator(Fields, this, "/", this, "lhs", BaseType, "rhs", "{0} / {1}") { CanScalar0 = false, CanScalar1 = false };

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
            }
        }
    }
}
