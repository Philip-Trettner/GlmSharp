using System;
using System.Collections.Generic;
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
                yield return TypeDouble;
                yield return TypeDecimal;
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
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeInt, TypeDouble),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeInt, TypeDecimal),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeInt, TypeComplex),

                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeLong),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeFloat),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeDouble),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeDecimal),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeUint, TypeComplex),

                    new KeyValuePair<BuiltinType, BuiltinType>(TypeFloat, TypeDouble),
                    new KeyValuePair<BuiltinType, BuiltinType>(TypeFloat, TypeComplex),

                    new KeyValuePair<BuiltinType, BuiltinType>(TypeDouble, TypeComplex),

                    new KeyValuePair<BuiltinType, BuiltinType>(TypeLong, TypeDecimal)
                };
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
            TypeConstants = new[] { "MaxValue", "MinValue", "MinusOne" }
        };
        public static readonly BuiltinType TypeComplex = new BuiltinType
        {
            TypeName = "Complex",
            Prefix = "c",
            LengthType = "double",
            OneValueConstant = "1.0",
            ZeroValueConstant = "0.0",
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
            HasLogicOps = true,
            HasFormatString = false,
            IsBool = true
        };
        public static readonly BuiltinType TypeGeneric = new BuiltinType
        {
            TypeName = "T",
            Prefix = "g",
            Generic = true,
            HasArithmetics = false,
            OneValueConstant = null,
            ZeroValueConstant = "default(T)"
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
        public bool IsBool { get; set; } = false;
        public bool IsFloatingPoint { get; set; }

        public bool HasFormatString { get; set; } = true;

        public bool HasLogicOps { get; set; }

        public string OneValueConstant { get; set; } = "1";
        public string ZeroValueConstant { get; set; } = "0";

        public override string OneValue => OneValueConstant;
        public override string ZeroValue => ZeroValueConstant;

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
    }
}
