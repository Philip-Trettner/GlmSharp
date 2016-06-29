using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Members;

namespace GlmSharpGenerator.Types
{
    partial class VectorType
    {
        private IEnumerable<string> InlineSwizzle(int nr = 0)
        {
            if (nr >= Components)
            {
                yield return "";
                yield break;
            }

            foreach (var sw in InlineSwizzle(nr + 1))
            {
                yield return "0" + sw;
                yield return "1" + sw;
            }
        }

        public override IEnumerable<Member> GenerateMembers()
        {
            var boolVType = new VectorType(BuiltinType.TypeBool, Components);
            var doubleVType = new VectorType(BuiltinType.TypeDouble, Components);
            var integerVType = new VectorType(BuiltinType.TypeInt, Components);
            var absVType = !string.IsNullOrEmpty(BaseType.AbsOverrideType) ? Types[BaseType.AbsOverrideTypePrefix + "vec" + Components] : this;
            var lengthType = new AnyType(BaseType.LengthType);

            // fields
            foreach (var f in Fields)
                yield return new Field(f, BaseType)
                {
                    Comment = $"{f}-component"
                };

            // swizzle
            yield return new Property("swizzle", SwizzleType)
            {
                GetterLine = Construct(SwizzleType, Fields),
                Comment = "Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)"
            };

            // inline-swizzle XYZW
            foreach (var swizzleBits in InlineSwizzle())
            {
                if (swizzleBits.Count(c => c == '1') < 2)
                    continue; // at least two set

                var swizzle = swizzleBits.Select((c, i) => c == '1' ? ArgOfs(i) : "").Aggregate((s1, s2) => s1 + s2);
                var vecType = new VectorType(BaseType, swizzle.Length);

                yield return new Property(swizzle, vecType)
                {
                    GetterLine = $"return {Construct(vecType, swizzle.Select(c => c.ToString()))};",
                    Setter = swizzle.Select((c, i) => $"{c} = value.{ArgOf(i)};"),
                    Comment = "Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property."
                };
            }
            // inline-swizzle RGBA
            foreach (var swizzleBits in InlineSwizzle())
            {
                if (swizzleBits.Count(c => c == '1') < 2)
                    continue; // at least two set

                var swizzle = swizzleBits.Select((c, i) => c == '1' ? ArgOfs(i) : "").Aggregate((s1, s2) => s1 + s2);
                var vecType = new VectorType(BaseType, swizzle.Length);

                yield return new Property(ToRgba(swizzle), vecType)
                {
                    GetterLine = $"return {Construct(vecType, swizzle.Select(c => c.ToString()))};",
                    Setter = swizzle.Select((c, i) => $"{c} = value.{ArgOf(i)};"),
                    Comment = "Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property."
                };
            }
            for (var c = 0; c < Components; ++c)
            {
                yield return new Property("rgba"[c].ToString(), BaseType)
                {
                    GetterLine = $"return {"xyzw"[c]};",
                    SetterLine = $"{"xyzw"[c]} = value;",
                    Comment = "Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property."
                };
            }

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
                        Comment = $"Predefined unit-{ArgOfUpper(c)} vector"
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
                        Comment = $"Predefined unit-imaginary-{ArgOfUpper(c)} vector"
                    };
            }

            // Basetype constants
            foreach (var constant in BaseType.TypeConstants)
            {
                yield return new StaticProperty(constant, this)
                {
                    Value = Construct(this, $"{BaseTypeName}.{constant}".RepeatTimes(Components)),
                    Comment = $"Predefined all-{constant} vector"
                };
            }

            // values
            yield return new Property("Values", new ArrayType(BaseType))
            {
                GetterLine = $"new[] {{ {CompArgString} }}",
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
                var commentAddition = "";
                if (comps < Components)
                    commentAddition = " (empty fields are zero/false)";
                else if (comps > Components)
                    commentAddition = " (additional fields are truncated)";

                yield return new Constructor(this, Fields)
                {
                    ParameterString = new VectorType(BaseType, comps).NameThat + " v",
                    Initializers = "v".DotComp(comps),
                    Comment = "from-vector constructor" + commentAddition
                };

                for (var ucomps = comps; ucomps < Components; ++ucomps)
                {
                    commentAddition = "";
                    if (ucomps < Components - 1)
                        commentAddition = " (empty fields are zero/false)";

                    yield return new Constructor(this, Fields)
                    {
                        ParameterString = new VectorType(BaseType, comps).NameThat + " v, " + SubCompParameterString(comps, ucomps),
                        Initializers = "v".DotComp(comps).Concat(SubCompArgs(comps, ucomps)),
                        Comment = "from-vector-and-value constructor" + commentAddition
                    };
                }
            }

            // ienumerable ctors
            if (Version >= 45)
                yield return new Constructor(this, Fields)
                {
                    ParameterString = $"IReadOnlyList<{BaseTypeName}> v",
                    Code = new[] { string.Format("var c = v.Count;") },
                    Initializers = Components.ForIndexUpTo(i => string.Format("c < {0} ? {1} : v[{0}]", i, ZeroValue)),
                    Comment = "From-array/list constructor (superfluous values are ignored, missing values are zero-filled)."
                };
            yield return new Constructor(this, Fields)
            {
                ParameterString = "Object[] v",
                Code = new[] { string.Format("var c = v.Length;") },
                Initializers = Components.ForIndexUpTo(i => string.Format("c < {0} ? {1} : ({2})v[{0}]", i, ZeroValue, BaseTypeName)),
                Comment = "Generic from-array constructor (superfluous values are ignored, missing values are zero-filled)."
            };
            yield return new Constructor(this, Fields)
            {
                ParameterString = $"{BaseTypeName}[] v",
                Code = new[] { string.Format("var c = v.Length;") },
                Initializers = Components.ForIndexUpTo(i => string.Format("c < {0} ? {1} : v[{0}]", i, ZeroValue)),
                Comment = "From-array constructor (superfluous values are ignored, missing values are zero-filled)."
            };
            yield return new Constructor(this, Fields)
            {
                ParameterString = $"{BaseTypeName}[] v, int startIndex",
                Code = new[] { string.Format("var c = v.Length;") },
                Initializers = Components.ForIndexUpTo(i => string.Format("c + startIndex < {0} ? {1} : v[{0} + startIndex]", i, ZeroValue)),
                Comment = "From-array constructor with base index (superfluous values are ignored, missing values are zero-filled)."
            };
            if (Version >= 40)
                yield return new Constructor(this, Fields)
                {
                    ParameterString = $"IEnumerable<{BaseTypeName}> v",
                    ConstructorChain = "this(v.ToArray())",
                    Comment = "From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled)."
                };
            else
                yield return new Constructor(this, Fields)
                {
                    ParameterString = $"IEnumerable<{BaseTypeName}> v",
                    ConstructorChain = $"this(new List<{BaseTypeName}>(v).ToArray())",
                    Comment = "From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled)."
                };

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
                    Comment = $"Implicitly converts this to a {targetType.Name}.",
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
                        Comment = $"Explicitly converts this to a {targetType.Name}.{commentAppendix}"
                    };
                }
            }
            yield return new ExplicitOperator(new ArrayType(BaseType))
            {
                ParameterString = NameThat + " v",
                CodeString = $"new [] {{ {Fields.Select(f => "v." + f).CommaSeparated()} }}",
                Comment = $"Explicitly converts this to a {BaseTypeName} array."
            };
            yield return new ExplicitOperator(new AnyType("Object[]"))
            {
                ParameterString = NameThat + " v",
                CodeString = $"new Object[] {{ {Fields.Select(f => "v." + f).CommaSeparated()} }}",
                Comment = string.Format("Explicitly converts this to a generic object array.")
            };

            // IEnumerable
            yield return new Function(new AnyType($"IEnumerator<{BaseTypeName}>"), "GetEnumerator")
            {
                Code = Fields.Select(f => $"yield return {f};"),
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

            // Parsing
            if (!BaseType.IsComplex && !BaseType.Generic)
            {
                // Parse
                yield return new Function(this, "Parse")
                {
                    Static = true,
                    ParameterString = "string s",
                    CodeString = "Parse(s, \", \")",
                    Comment = "Converts the string representation of the vector into a vector representation (using ', ' as a separator)."
                };

                yield return new Function(this, "Parse")
                {
                    Static = true,
                    ParameterString = "string s, string sep",
                    Code = new[]
                    {
                        "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                        string.Format("if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components),
                        $"return new {NameThat}({Components.ForIndexUpTo(i => $"{BaseTypeName}.Parse(kvp[{i}].Trim())").CommaSeparated()});"
                    },
                    Comment = "Converts the string representation of the vector into a vector representation (using a designated separator)."
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
                            $"return new {NameThat}({Components.ForIndexUpTo(i => $"{BaseTypeName}.Parse(kvp[{i}].Trim(), provider)").CommaSeparated()});"
                        },
                        Comment = "Converts the string representation of the vector into a vector representation (using a designated separator and a type provider)."
                    };
                    yield return new Function(this, "Parse")
                    {
                        Static = true,
                        ParameterString = "string s, string sep, NumberStyles style",
                        Code = new[]
                        {
                            "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                            string.Format("if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components),
                            $"return new {NameThat}({Components.ForIndexUpTo(i => $"{BaseTypeName}.Parse(kvp[{i}].Trim(), style)").CommaSeparated()});"
                        },
                        Comment = "Converts the string representation of the vector into a vector representation (using a designated separator and a number style)."
                    };
                    yield return new Function(this, "Parse")
                    {
                        Static = true,
                        ParameterString = "string s, string sep, NumberStyles style, IFormatProvider provider",
                        Code = new[]
                        {
                            "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                            string.Format("if (kvp.Length != {0}) throw new FormatException(\"input has not exactly {0} parts\");", Components),
                            $"return new {NameThat}({Components.ForIndexUpTo(i => $"{BaseTypeName}.Parse(kvp[{i}].Trim(), style, provider)").CommaSeparated()});"
                        },
                        Comment = "Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider)."
                    };
                }

                // TryParse
                yield return new Function(BuiltinType.TypeBool, "TryParse")
                {
                    Static = true,
                    ParameterString = $"string s, out {NameThat} result",
                    CodeString = "TryParse(s, \", \", out result)",
                    Comment = "Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid."
                };

                yield return new Function(BuiltinType.TypeBool, "TryParse")
                {
                    Static = true,
                    ParameterString = $"string s, string sep, out {NameThat} result",
                    Code = new[]
                    {
                        "result = Zero;",
                        "if (string.IsNullOrEmpty(s)) return false;",
                        "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                        $"if (kvp.Length != {Components}) return false;",
                        $"{BaseTypeName} {CompString.Select(c => c + " = " + ZeroValue).CommaSeparated()};",
                        $"var ok = {Components.ForIndexUpTo(i => $"{BaseTypeName}.TryParse(kvp[{i}].Trim(), out {ArgOf(i)})").Aggregated(" && ")};",
                        $"result = ok ? new {NameThat}({CompArgString}) : Zero;",
                        "return ok;"
                    },
                    Comment = "Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid."
                };

                if (!BaseType.IsBool)
                {
                    yield return new Function(BuiltinType.TypeBool, "TryParse")
                    {
                        Static = true,
                        ParameterString = $"string s, string sep, NumberStyles style, IFormatProvider provider, out {NameThat} result",
                        Code = new[]
                        {
                            "result = Zero;",
                            "if (string.IsNullOrEmpty(s)) return false;",
                            "var kvp = s.Split(new[] { sep }, StringSplitOptions.None);",
                            $"if (kvp.Length != {Components}) return false;",
                            $"{BaseTypeName} {CompString.Select(c => c + " = " + ZeroValue).CommaSeparated()};",
                            $"var ok = {Components.ForIndexUpTo(i => $"{BaseTypeName}.TryParse(kvp[{i}].Trim(), style, provider, out {ArgOf(i)})").Aggregated(" && ")};",
                            $"result = ok ? new {NameThat}({CompArgString}) : Zero;",
                            "return ok;"
                        },
                        Comment = "Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid."
                    };
                }
            }

            // IReadOnlyList
            yield return new Property("Count", BuiltinType.TypeInt)
            {
                GetterLine = Components.ToString(),
                Comment = $"Returns the number of components ({Components})."
            };

            yield return new Indexer(BaseType)
            {
                ParameterString = "int index",
                Getter = SwitchIndex(Components.ForIndexUpTo(i => $"case {i}: return {ArgOf(i)};")),
                Setter = SwitchIndex(Components.ForIndexUpTo(i => $"case {i}: {ArgOf(i)} = value; break;")),
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
                    $"    return {HashCodeFor(Components - 1)};",
                    "}"
                },
                Comment = "Returns a hash code for this instance."
            };

            if (BaseType.HasArithmetics && !BaseType.IsInteger)
                yield return new Function(BuiltinType.TypeBool, "ApproxEqual")
                {
                    Static = true,
                    Parameters = this.TypedArgs("lhs", "rhs").Concat(lengthType.TypedArgs("eps = " + lengthType.ConstantSuffixFor("0.1"))),
                    CodeString = "Distance(lhs, rhs) <= eps",
                    Comment = "Returns true iff distance between lhs and rhs is less than or equal to epsilon"
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
                    yield return new ComponentWiseStaticFunction(Fields, this, "InverseSqrt", this, "v", "Complex.One / Complex.Sqrt({0})");
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
                    yield return new ComponentWiseStaticFunction(Fields, this, "Sqrt", this, "v", $"({BaseTypeName})Math.Sqrt((double){{0}})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "InverseSqrt", this, "v", $"({BaseTypeName})(1.0 / Math.Sqrt((double){{0}}))");
                    yield return new ComponentWiseStaticFunction(Fields, integerVType, "Sign", this, "v", "Math.Sign({0})");

                    yield return new ComponentWiseStaticFunction(Fields, this, "Max", this, "lhs", this, "rhs", MathClass + ".Max({0}, {1})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Min", this, "lhs", this, "rhs", MathClass + ".Min({0}, {1})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Pow", this, "lhs", this, "rhs", BaseTypeCast + "Math.Pow((double){0}, (double){1})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Log", this, "lhs", this, "rhs", BaseTypeCast + "Math.Log((double){0}, (double){1})");

                    // TODO: Check if v > max ? max : v < min ? min : v is faster
                    yield return new ComponentWiseStaticFunction(Fields, this, "Clamp", this, "v", this, "min", this, "max", MathClass + ".Min(" + MathClass + ".Max({0}, {1}), {2})");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Mix", this, "min", this, "max", this, "a", "{0} * (1-{2}) + {1} * {2}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Lerp", this, "min", this, "max", this, "a", "{0} * (1-{2}) + {1} * {2}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Smoothstep", this, "edge0", this, "edge1", this, "v", "(({2} - {0}) / ({1} - {0})).Clamp().HermiteInterpolationOrder3()");
                    yield return new ComponentWiseStaticFunction(Fields, this, "Smootherstep", this, "edge0", this, "edge1", this, "v", "(({2} - {0}) / ({1} - {0})).Clamp().HermiteInterpolationOrder5()");
                }

                yield return new ComponentWiseStaticFunction(Fields, this, "Fma", this, "a", this, "b", this, "c", "{0} * {1} + {2}");

                // outer product
                // TODO: add to respective matrices
                for (var comps = 2; comps <= 4; ++comps)
                {
                    var otherVec = new VectorType(BaseType, comps);
                    var matThisThat = new MatrixType(BaseType, Components, comps);
                    var matThatThis = new MatrixType(BaseType, comps, Components);

                    yield return new Function(matThisThat, "OuterProduct")
                    {
                        Static = true,
                        Parameters = new[] { otherVec.Name + " c", this.Name + " r" },
                        CodeString = Construct(matThisThat, Components.ForIndexUpTo(ArgOfs).SelectMany(c => comps.ForIndexUpTo(ArgOf).Format("c.{0} * r." + c))),
                        Comment = "OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r."
                    };

                    if (comps != Components)
                        yield return new Function(matThatThis, "OuterProduct")
                        {
                            Static = true,
                            Parameters = new[] { this.Name + " c", otherVec.Name + " r" },
                            CodeString = Construct(matThatThis, comps.ForIndexUpTo(ArgOfs).SelectMany(c => Components.ForIndexUpTo(ArgOf).Format("c.{0} * r." + c))),
                            Comment = "OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r."
                        };
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

                yield return new ComponentWiseOperator(Fields, this, "+", this, "v", "identity") { ReturnOverride = "v" };

                if (BaseType.IsSigned)
                    yield return new ComponentWiseOperator(Fields, this, "-", this, "v", "-{0}");

                if (BaseType.IsInteger)
                {
                    yield return new ComponentWiseStaticFunction(Fields, this, "Xor", this, "lhs", this, "rhs", "{0} ^ {1}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "BitwiseOr", this, "lhs", this, "rhs", "{0} | {1}");
                    yield return new ComponentWiseStaticFunction(Fields, this, "BitwiseAnd", this, "lhs", this, "rhs", "{0} & {1}");

                    yield return new ComponentWiseOperator(Fields, this, "~", this, "v", "~{0}");
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
                yield return new ComponentWiseStaticFunction(Fields, this, "Modulo", this, "lhs", this, "rhs", "{0} % {1}");
                yield return new ComponentWiseOperator(Fields, this, "%", this, "lhs", this, "rhs", "{0} % {1}");

                yield return new ComponentWiseStaticFunction(Fields, this, "Degrees", this, "v", BaseTypeCast + "({0} * " + ConstantSuffixFor("57.295779513082320876798154814105170332405472466564321") + ")") { AdditionalComment = "Radians-To-Degrees Conversion" };
                yield return new ComponentWiseStaticFunction(Fields, this, "Radians", this, "v", BaseTypeCast + "({0} * " + ConstantSuffixFor("0.0174532925199432957692369076848861271344287188854172") + ")") { AdditionalComment = "Degrees-To-Radians Conversion" };

                yield return new ComponentWiseStaticFunction(Fields, this, "Acos", this, "v", $"({BaseTypeName})Math.Acos((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Asin", this, "v", $"({BaseTypeName})Math.Asin((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Atan", this, "v", $"({BaseTypeName})Math.Atan((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Cos", this, "v", $"({BaseTypeName})Math.Cos((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Cosh", this, "v", $"({BaseTypeName})Math.Cosh((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Exp", this, "v", $"({BaseTypeName})Math.Exp((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Log", this, "v", $"({BaseTypeName})Math.Log((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Log2", this, "v", $"({BaseTypeName})Math.Log((double){{0}}, 2)");
                yield return new ComponentWiseStaticFunction(Fields, this, "Log10", this, "v", $"({BaseTypeName})Math.Log10((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Floor", this, "v", $"({BaseTypeName})Math.Floor({{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Ceiling", this, "v", $"({BaseTypeName})Math.Ceiling({{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Round", this, "v", $"({BaseTypeName})Math.Round({{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Sin", this, "v", $"({BaseTypeName})Math.Sin((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Sinh", this, "v", $"({BaseTypeName})Math.Sinh((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Tan", this, "v", $"({BaseTypeName})Math.Tan((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Tanh", this, "v", $"({BaseTypeName})Math.Tanh((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Truncate", this, "v", $"({BaseTypeName})Math.Truncate((double){{0}})");
                yield return new ComponentWiseStaticFunction(Fields, this, "Fract", this, "v", $"({BaseTypeName})({{0}} - Math.Floor({{0}}))");
                yield return new ComponentWiseStaticFunction(Fields, this, "Trunc", this, "v", "(long)({0})");
            }


            // Logicals
            if (BaseType.IsBool)
            {
                yield return new AggregatedProperty(Fields, "MinElement", BaseType, "&&", "Returns the minimal component of this vector.");
                yield return new AggregatedProperty(Fields, "MaxElement", BaseType, "||", "Returns the maximal component of this vector.");
                yield return new AggregatedProperty(Fields, "All", BaseType, "&&", "Returns true if all component are true.");
                yield return new AggregatedProperty(Fields, "Any", BaseType, "||", "Returns true if any component is true.");
            }

            // Aggregated Properties
            if (BaseType.HasArithmetics)
            {
                if (!BaseType.IsComplex)
                {
                    yield return new Property("MinElement", BaseType)
                    {
                        GetterLine = NestedSymmetricFunction(Fields, MathClass + ".Min({0}, {1})"),
                        Comment = "Returns the minimal component of this vector."
                    };
                    yield return new Property("MaxElement", BaseType)
                    {
                        GetterLine = NestedSymmetricFunction(Fields, MathClass + ".Max({0}, {1})"),
                        Comment = "Returns the maximal component of this vector."
                    };
                }

                yield return new Property("Length", lengthType)
                {
                    GetterLine = "(" + lengthType.Name + ")" + SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")),
                    Comment = "Returns the euclidean length of this vector."
                };

                yield return new AggregatedProperty(Fields.Select(SqrOf), "LengthSqr", lengthType, "+", "Returns the squared euclidean length of this vector.");
                yield return new AggregatedProperty(Fields, "Sum", BaseType, "+", "Returns the sum of all components.");

                yield return new Property("Norm", lengthType)
                {
                    GetterLine = "(" + lengthType.Name + ")" + SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")),
                    Comment = "Returns the euclidean norm of this vector."
                };
                yield return new Property("Norm1", lengthType)
                {
                    GetterLine = Fields.Select(AbsString).Aggregated(" + "),
                    Comment = "Returns the one-norm of this vector."
                };
                yield return new Property("Norm2", lengthType)
                {
                    GetterLine = "(" + lengthType.Name + ")" + SqrtOf(Fields.Select(SqrOf).Aggregated(" + ")),
                    Comment = "Returns the two-norm (euclidean length) of this vector."
                };
                yield return new Property("NormMax", lengthType)
                {
                    GetterLine = NestedSymmetricFunction(Fields.Select(AbsString), MathClass + ".Max({0}, {1})"),
                    Comment = "Returns the max-norm of this vector."
                };
                yield return new Function(new AnyType("double"), "NormP")
                {
                    ParameterString = "double p",
                    CodeString = $"Math.Pow({Fields.Select(c => $"Math.Pow((double){AbsString(c)}, p)").Aggregated(" + ")}, 1 / p)",
                    Comment = "Returns the p-norm of this vector."
                };

                // normalized
                if (!BaseType.IsInteger)
                {
                    yield return new Property("Normalized", this)
                    {
                        GetterLine = $"this / {BaseTypeCast}Length",
                        Comment = "Returns a copy of this vector with length one (undefined if this has zero length)."
                    };
                    yield return new Property("NormalizedSafe", this)
                    {
                        GetterLine = $"this == Zero ? Zero : this / {BaseTypeCast}Length",
                        Comment = "Returns a copy of this vector with length one (returns zero if length is zero)."
                    };
                }
            }


            // angle
            if (Components == 2 && BaseType.IsFloatingPoint)
            {
                yield return new Property("Angle", BuiltinType.TypeDouble)
                {
                    GetterLine = "Math.Atan2((double)y, (double)x)",
                    Comment = "Returns the vector angle (atan2(y, x)) in radians."
                };

                yield return new Function(this, "FromAngle")
                {
                    Static = true,
                    ParameterString = "double angleInRad",
                    CodeString = Construct(this, string.Format("({0})Math.Cos(angleInRad), ({0})Math.Sin(angleInRad)", BaseTypeName)),
                    Comment = "Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types)."
                };

                yield return new Function(this, "Rotated")
                {
                    ParameterString = "double angleInRad",
                    CodeString = "(" + Name + ")(dvec2.FromAngle(Angle + angleInRad) * (double)Length)",
                    Comment = "Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated)."
                };
            }

            // Complex properties
            if (BaseType.IsComplex)
            {
                yield return new Property("Magnitude", doubleVType)
                {
                    GetterLine = Construct(doubleVType, Fields.Format("{0}.Magnitude")),
                    Comment = "Returns a vector containing component-wise magnitudes."
                };
                yield return new Property("Phase", doubleVType)
                {
                    GetterLine = Construct(doubleVType, Fields.Format("{0}.Phase")),
                    Comment = "Returns a vector containing component-wise phases."
                };
                yield return new Property("Imaginary", doubleVType)
                {
                    GetterLine = Construct(doubleVType, Fields.Format("{0}.Imaginary")),
                    Comment = "Returns a vector containing component-wise imaginary parts."
                };
                yield return new Property("Real", doubleVType)
                {
                    GetterLine = Construct(doubleVType, Fields.Format("{0}.Real")),
                    Comment = "Returns a vector containing component-wise real parts."
                };
            }

            // Arithmetic Funcs
            if (BaseType.HasArithmetics)
            {
                // dot
                yield return new Function(BaseType, "Dot")
                {
                    Static = true,
                    Parameters = this.LhsRhs(),
                    CodeString = Fields.Format(DotFormatString).Aggregated(" + "),
                    Comment = "Returns the inner product (dot product, scalar product) of the two vectors."
                };

                // distance
                yield return new Function(lengthType, "Distance")
                {
                    Static = true,
                    Parameters = this.LhsRhs(),
                    CodeString = "(lhs - rhs).Length",
                    Comment = "Returns the euclidean distance between the two vectors."
                };
                yield return new Function(lengthType, "DistanceSqr")
                {
                    Static = true,
                    Parameters = this.LhsRhs(),
                    CodeString = "(lhs - rhs).LengthSqr",
                    Comment = "Returns the squared euclidean distance between the two vectors."
                };

                if (BaseType.IsSigned)
                {
                    // reflect
                    yield return new Function(this, "Reflect")
                    {
                        Static = true,
                        Parameters = this.TypedArgs("I", "N"),
                        CodeString = "I - 2 * Dot(N, I) * N",
                        Comment = "Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result)."
                    };

                    if (!BaseType.IsComplex)
                    {
                        // refract
                        yield return new Function(this, "Refract")
                        {
                            Static = true,
                            Parameters = this.TypedArgs("I", "N").SConcat(BaseTypeName + " eta"),
                            Code = new[]
                            {
                                "var dNI = Dot(N, I);",
                                "var k = 1 - eta * eta * (1 - dNI * dNI);",
                                "if (k < 0) return Zero;",
                                string.Format("return eta * I - (eta * dNI + ({1}){0}) * N;", BaseType.IsComplex ? "Complex.Sqrt(k)" : SqrtOf("k"), BaseTypeName)
                            },
                            Comment = "Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result)."
                        };

                        // faceforward
                        yield return new Function(this, "FaceForward")
                        {
                            Static = true,
                            Parameters = this.TypedArgs("N", "I", "Nref"),
                            CodeString = "Dot(Nref, I) < 0 ? N : -N",
                            Comment = "Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N)."
                        };
                    }
                }

                // cross product
                if (BaseType.HasArithmetics)
                {
                    // cross
                    switch (Components)
                    {
                        case 3:
                            yield return new Function(this, "Cross")
                            {
                                Static = true,
                                Parameters = this.TypedArgs("l", "r"),
                                CodeString = Construct(this, "l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x"),
                                Comment = "Returns the outer product (cross product, vector product) of the two vectors."
                            };
                            break;
                        case 2:
                            yield return new Function(BaseType, "Cross")
                            {
                                Static = true,
                                Parameters = this.TypedArgs("l", "r"),
                                CodeString = "l.x * r.y - l.y * r.x",
                                Comment = "Returns the length of the outer product (cross product, vector product) of the two vectors."
                            };
                            break;
                    }
                }
            }

            // Random
            if (BaseType.IsBool)
                yield return new Function(this, "Random")
                {
                    Static = true,
                    ParameterString = "Random random, float trueProbability = 0.5f",
                    CodeString = Construct(this, "random.NextDouble() < trueProbability".RepeatTimes(Components)),
                    Comment = $"Returns a {Name} with independent and identically distributed random true/false values (the probability for 'true' can be configured)."
                };
            else if (BaseType.IsInteger)
            {
                yield return new Function(this, "Random")
                {
                    Static = true,
                    ParameterString = "Random random",
                    CodeString = Construct(this, (BaseTypeCast + "random.Next()").RepeatTimes(Components)),
                    Comment = $"Returns a {Name} with independent and identically distributed uniform integer values between 0 (inclusive) and int.MaxValue (exclusive)."
                };

                yield return new ComponentWiseStaticFunction(Fields, this, "Random", this, "maxValue", BaseTypeCast + "random.Next((int){0})")
                {
                    FirstParameter = "Random random",
                    CommentOverride = $"Returns a {Name} with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)"
                };
                yield return new ComponentWiseStaticFunction(Fields, this, "Random", this, "minValue", this, "maxValue", BaseTypeCast + "random.Next((int){0}, (int){1})")
                {
                    FirstParameter = "Random random",
                    CommentOverride = $"Returns a {Name} with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)"
                };
                yield return new ComponentWiseStaticFunction(Fields, this, "RandomUniform", this, "minValue", this, "maxValue", BaseTypeCast + "random.Next((int){0}, (int){1})")
                {
                    FirstParameter = "Random random",
                    CommentOverride = $"Returns a {Name} with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)"
                };

                yield return new ComponentWiseStaticFunction(Fields, this, "RandomPoisson", doubleVType, "lambda", BaseTypeCast + "{0}.GetPoisson(random)")
                {
                    DisableGlmGen = BaseType != BuiltinType.TypeInt,
                    FirstParameter = "Random random",
                    CommentOverride = $"Returns a {Name} with independent and identically distributed integer values according to a poisson distribution with given lambda parameter."
                };

                // TODO: http://en.wikipedia.org/wiki/Bernoulli_distribution
                // TODO: http://en.wikipedia.org/wiki/Binomial_distribution
                // TODO: http://en.wikipedia.org/wiki/Geometric_distribution
                // TODO: http://en.wikipedia.org/wiki/Negative_binomial_distribution
            }
            else if (BaseType.IsFloatingPoint)
            {
                yield return new Function(this, "Random")
                {
                    Static = true,
                    ParameterString = "Random random",
                    CodeString = Construct(this, (BaseTypeCast + "random.NextDouble()").RepeatTimes(Components)),
                    Comment = $"Returns a {Name} with independent and identically distributed uniform values between 0.0 and 1.0."
                };
                yield return new Function(this, "RandomSigned")
                {
                    Static = true,
                    ParameterString = "Random random",
                    CodeString = Construct(this, (BaseTypeCast + "(random.NextDouble() * 2.0 - 1.0)").RepeatTimes(Components)),
                    Comment = $"Returns a {Name} with independent and identically distributed uniform values between -1.0 and 1.0."
                };

                // uniform
                yield return new ComponentWiseStaticFunction(Fields, this, "Random", this, "minValue", this, "maxValue", BaseTypeCast + "random.NextDouble() * ({1} - {0}) + {0}")
                {
                    FirstParameter = "Random random",
                    CommentOverride = $"Returns a {Name} with independent and identically distributed uniform values between 'minValue' and 'maxValue'."
                };
                yield return new ComponentWiseStaticFunction(Fields, this, "RandomUniform", this, "minValue", this, "maxValue", BaseTypeCast + "random.NextDouble() * ({1} - {0}) + {0}")
                {
                    FirstParameter = "Random random",
                    CommentOverride = $"Returns a {Name} with independent and identically distributed uniform values between 'minValue' and 'maxValue'."
                };

                // normal, gaussian
                yield return new Function(this, "RandomNormal")
                {
                    Static = true,
                    ParameterString = "Random random",
                    CodeString = Construct(this, (BaseTypeCast + "(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble())))").RepeatTimes(Components)),
                    Comment = $"Returns a {Name} with independent and identically distributed values according to a normal distribution (zero mean, unit variance)."
                };
                yield return new ComponentWiseStaticFunction(Fields, this, "RandomNormal", this, "mean", this, "variance",
                    BaseTypeCast + "(Math.Sqrt((double){1}) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + {0}")
                {
                    FirstParameter = "Random random",
                    CommentOverride = $"Returns a {Name} with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance."
                };
                yield return new ComponentWiseStaticFunction(Fields, this, "RandomGaussian", this, "mean", this, "variance",
                    BaseTypeCast + "(Math.Sqrt((double){1}) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + {0}")
                {
                    FirstParameter = "Random random",
                    CommentOverride = $"Returns a {Name} with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance."
                };

                // TODO: Triangular distribution
                // TODO: Beta distribution
                // TODO: Chi/Chi-Squared distribution
                // TODO: Gamma distribution
                // TODO: Log-normal distribution
                // TODO: Logistic distribution
                // TODO: Laplace distribution
                // TODO: Rayleigh distribution
                // TODO: Tests

                // Dependent/Geometric
                // TODO: Circle, Sphere distribution
                // TODO: multi-dimensional gaussian distribution
            }

            // TODO: GLM_GTX_random
            // TODO: compRand, gaussRand, normalizedRand, signedRand, vecRand, ballRand, circularRand, diskRand, linearRand, sphericalRand
        }

    }
}
