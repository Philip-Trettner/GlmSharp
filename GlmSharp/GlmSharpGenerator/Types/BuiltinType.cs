using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using GlmSharpGenerator.Members;

namespace GlmSharpGenerator.Types
{
    class BuiltinType : AbstractType
    {
        public static IEnumerable<BuiltinType> BaseTypes
        {
            get
            {
                yield return TypeInt;
                yield return TypeUint;
                yield return TypeFloat;
                yield return TypeHalf;
                yield return TypeDouble;
                yield return TypeDecimal;
                if (Version >= 30)
                    yield return TypeComplex;
                yield return TypeLong;
                yield return TypeBool;
                yield return TypeGeneric;
            }
        }

        public static List<KeyValuePair<BuiltinType, BuiltinType>> Upcasts
        {
            get
            {
                // from -> to
                var dic = new List<KeyValuePair<BuiltinType, BuiltinType>>
                {
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeInt, TypeLong),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeInt, TypeFloat),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeInt, TypeHalf),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeInt, TypeDouble),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeInt, TypeDecimal),

                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeLong),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeFloat),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeHalf),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeDouble),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeDecimal),

                    new KeyValuePair<BuiltinType, BuiltinType>(TypeHalf, TypeFloat),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeHalf, TypeDouble),

                    new KeyValuePair<BuiltinType, BuiltinType>(TypeFloat, TypeDouble),

                    new KeyValuePair<BuiltinType, BuiltinType>(TypeLong, TypeDecimal)
                };
                if (Version >= 30)
                {
                    dic.Add(new KeyValuePair<BuiltinType, BuiltinType>(TypeInt, TypeComplex));
                    dic.Add(new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeComplex));
                    dic.Add(new KeyValuePair<BuiltinType, BuiltinType>(TypeHalf, TypeComplex));
                    dic.Add(new KeyValuePair<BuiltinType, BuiltinType>(TypeFloat, TypeComplex));
                    dic.Add(new KeyValuePair<BuiltinType, BuiltinType>(TypeDouble, TypeComplex));
                }
                return dic;
            }
        }

        public static readonly BuiltinType TypeInt = new BuiltinType
        {
            TypeName = "int",
            Prefix = "i",
            IsInteger = true,
            TypeConstants = new[] { "MaxValue", "MinValue" }
        };
        public static readonly BuiltinType TypeUint = new BuiltinType
        {
            TypeName = "uint",
            Prefix = "u",
            OneValueConstant = "1u",
            ZeroValueConstant = "0u",
            IsSigned = false,
            IsInteger = true,
            TypeConstants = new[] { "MaxValue", "MinValue" }
        };
        public static readonly BuiltinType TypeHalf = new BuiltinType
        {
            TypeName = "Half",
            Prefix = "h",
            OneValueConstant = "Half.One",
            ZeroValueConstant = "Half.Zero",
            HasOwnFunctions = true,
            IsFloatingPoint = true,
            TypeConstants = new[] { "MaxValue", "MinValue", "Epsilon", "NaN", "NegativeInfinity", "PositiveInfinity" },
            TypeTestFuncs = new Dictionary<string, string>
            {
                { "IsInfinity", "Half.IsInfinity({0})" },
                { "IsFinite", "!Half.IsNaN({0}) && !Half.IsInfinity({0})" },
                { "IsNaN", "Half.IsNaN({0})" },
                { "IsNegativeInfinity", "Half.IsNegativeInfinity({0})" },
                { "IsPositiveInfinity", "Half.IsPositiveInfinity({0})" }
            }
        };
        public static readonly BuiltinType TypeFloat = new BuiltinType
        {
            TypeName = "float",
            OneValueConstant = "1f",
            ZeroValueConstant = "0f",
            IsFloatingPoint = true,
            TypeConstants = new[] { "MaxValue", "MinValue", "Epsilon", "NaN", "NegativeInfinity", "PositiveInfinity" },
            TypeTestFuncs = new Dictionary<string, string>
            {
                { "IsInfinity", "float.IsInfinity({0})" },
                { "IsFinite", "!float.IsNaN({0}) && !float.IsInfinity({0})" },
                { "IsNaN", "float.IsNaN({0})" },
                { "IsNegativeInfinity", "float.IsNegativeInfinity({0})" },
                { "IsPositiveInfinity", "float.IsPositiveInfinity({0})" }
            }
        };
        public static readonly BuiltinType TypeDouble = new BuiltinType
        {
            TypeName = "double",
            Prefix = "d",
            LengthType = "double",
            OneValueConstant = "1.0",
            ZeroValueConstant = "0.0",
            IsFloatingPoint = true,
            TypeConstants = new[] { "MaxValue", "MinValue", "Epsilon", "NaN", "NegativeInfinity", "PositiveInfinity" },
            TypeTestFuncs = new Dictionary<string, string>
            {
                { "IsInfinity", "double.IsInfinity({0})" },
                { "IsFinite", "!double.IsNaN({0}) && !double.IsInfinity({0})" },
                { "IsNaN", "double.IsNaN({0})" },
                { "IsNegativeInfinity", "double.IsNegativeInfinity({0})" },
                { "IsPositiveInfinity", "double.IsPositiveInfinity({0})" }
            }
        };
        public static readonly BuiltinType TypeDecimal = new BuiltinType
        {
            TypeName = "decimal",
            Prefix = "dec",
            LengthType = "decimal",
            OneValueConstant = "1m",
            ZeroValueConstant = "0m",
            Decimal = true,
            IsFloatingPoint = true,
            EpsilonFormat = "double.Epsilon",
            TypeConstants = new[] { "MaxValue", "MinValue", "MinusOne" }
        };
        public static readonly BuiltinType TypeComplex = new BuiltinType
        {
            TypeName = "Complex",
            Prefix = "c",
            LengthType = "double",
            OneValueConstant = "Complex.One",
            ZeroValueConstant = "Complex.Zero",
            IsComplex = true,
            AbsOverrideType = "double",
            AbsOverrideTypePrefix = "d"
        };
        public static readonly BuiltinType TypeLong = new BuiltinType
        {
            TypeName = "long",
            Prefix = "l",
            LengthType = "double",
            IsInteger = true,
            TypeConstants = new[] { "MaxValue", "MinValue" }
        };
        public static readonly BuiltinType TypeBool = new BuiltinType
        {
            TypeName = "bool",
            Prefix = "b",
            HasArithmetics = false,
            HashCodeMultiplier = 2,
            OneValueConstant = "true",
            ZeroValueConstant = "false",
            HasFormatString = false,
            IsBool = true,
            IsSigned = false
        };
        public static readonly BuiltinType TypeGeneric = new BuiltinType
        {
            TypeName = "T",
            Prefix = "g",
            Generic = true,
            HasArithmetics = false,
            OneValueConstant = null,
            ZeroValueConstant = "default(T)",
            EqualFormat = "EqualityComparer<T>.Default.Equals({0}, {1})",
            NotEqualFormat = "!EqualityComparer<T>.Default.Equals({0}, {1})",
            IsSigned = false
        };

        public string TypeName { get; set; }
        public string Prefix { get; set; }
        public bool Generic { get; set; }
        public bool IsComplex { get; set; }
        public bool Decimal { get; set; }

        public bool HasArithmetics { get; set; } = true;
        public bool HasComparisons => HasArithmetics && !Generic && !IsComplex;
        public string LengthType { get; set; } = "float";
        public string AbsOverrideType { get; set; }
        public string AbsOverrideTypePrefix { get; set; }
        public bool IsSigned { get; set; } = true;
        public bool IsInteger { get; set; } = false;
        public bool IsFloatingPoint { get; set; }
        public bool HasOwnFunctions { get; set; }

        public string EpsilonFormat { get; set; } = "{0}.Epsilon";


        public string EqualFormat { get; set; } = "{0} == {1}";
        public string NotEqualFormat { get; set; } = "{0} != {1}";

        public bool HasFormatString { get; set; } = true;

        public bool IsBool { get; set; }

        public string OneValueConstant { get; set; } = "1";
        public string ZeroValueConstant { get; set; } = "0";

        public override string MathClass => HasOwnFunctions ? Name : "Math";

        public override string OneValue => OneValueConstant;
        public override string ZeroValue => TestMode && Generic ? "null" : ZeroValueConstant;

        public int HashCodeMultiplier { get; set; } = 397;

        public override string Name => TypeName;

        public override string TypeComment => "Builtin " + Name;

        public override IEnumerable<Member> GenerateMembers()
        {
            yield break; // no-op
        }

        protected override IEnumerable<string> Body
        {
            get { throw new InvalidOperationException("No body for builtin types"); }
        }

        public string[] TypeConstants { get; set; } = new string[] { };

        public Dictionary<string, string> TypeTestFuncs { get; set; } = new Dictionary<string, string>();

        public IEnumerable<string> ValuesBorder
        {
            get
            {
                yield return ZeroValue;
                if (!string.IsNullOrEmpty(OneValue))
                    yield return OneValue;
                if (IsSigned)
                    yield return "-1";
                foreach (var constant in TypeConstants)
                    yield return Name + "." + constant;
            }
        }

        public string[] RandomSmallVals(int count)
        {
            var vals = ValuesSmallVals.ToArray();
            return count.ForIndexUpTo(f => vals[Random.Next(0, vals.Length)]).ToArray();
        }

        public IEnumerable<string> ValuesSmallVals
        {
            get
            {
                yield return ZeroValue;

                if (!string.IsNullOrEmpty(OneValue))
                    yield return OneValue;

                if (IsComplex)
                {
                    foreach (var r in TypeDouble.ValuesSmallVals)
                        foreach (var i in TypeDouble.ValuesSmallVals)
                            yield return $"new Complex({r}, {i})";
                    yield break;
                }

                if (Generic)
                {
                    yield return "\"\"";
                    for (int i = 1; i <= 3; ++i)
                        for (int l = 1; l <= 3; ++l)
                            yield return $"\"{TypeInt.RandomSmallVals(l).Aggregated("")}\"";
                    yield break;
                }

                if (!HasArithmetics)
                    yield break;

                for (var i = 2; i < 10; ++i)
                    yield return ConstantSuffixFor(i.ToString());

                if (IsSigned)
                    for (var i = 1; i < 10; ++i)
                        yield return ConstantSuffixFor((-i).ToString());

                if (IsFloatingPoint)
                    for (var i = -10; i < 10; ++i)
                        yield return ConstantSuffixFor((i + 0.5).ToString(CultureInfo.InvariantCulture));

            }
        }
    }
}
