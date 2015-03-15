using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator
{
    class BaseTypeInfo
    {
        public static IEnumerable<BaseTypeInfo> Types
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
        public static List<KeyValuePair<BaseTypeInfo, BaseTypeInfo>> Upcasts
        {
            get
            {
                // from -> to
                var dic = new List<KeyValuePair<BaseTypeInfo, BaseTypeInfo>>
                {
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeInt, TypeLong),
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeInt, TypeFloat),
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeInt, TypeDouble),
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeInt, TypeDecimal),
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeInt, TypeComplex),

                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeUint, TypeLong),
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeUint, TypeFloat),
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeUint, TypeDouble),
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeUint, TypeDecimal),
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeUint, TypeComplex),

                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeFloat, TypeDouble),
                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeFloat, TypeComplex),

                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeDouble, TypeComplex),

                    new KeyValuePair<BaseTypeInfo, BaseTypeInfo>(TypeLong, TypeDecimal)
                };
                return dic;
            }
        }

        public static readonly BaseTypeInfo TypeInt = new BaseTypeInfo
        {
            Name = "int",
            Prefix = "i",
            IsInteger = true
        };
        public static readonly BaseTypeInfo TypeUint = new BaseTypeInfo
        {
            Name = "uint",
            Prefix = "u",
            RequiredAbs = false,
            IsInteger = true
        };
        public static readonly BaseTypeInfo TypeFloat = new BaseTypeInfo
        {
            Name = "float",
            OneValue = "1f"
        };
        public static readonly BaseTypeInfo TypeDouble = new BaseTypeInfo
        {
            Name = "double",
            Prefix = "d",
            LengthType = "double",
            OneValue = "1.0"
        };
        public static readonly BaseTypeInfo TypeDecimal = new BaseTypeInfo
        {
            Name = "decimal",
            Prefix = "dec",
            LengthType = "decimal",
            OneValue = "1m",
            Decimal = true
        };
        public static readonly BaseTypeInfo TypeComplex = new BaseTypeInfo
        {
            Name = "Complex",
            Prefix = "c",
            LengthType = "double",
            OneValue = "1.0",
            Complex = true
        };
        public static readonly BaseTypeInfo TypeLong = new BaseTypeInfo
        {
            Name = "long",
            Prefix = "l",
            LengthType = "double",
            IsInteger = true
        };
        public static readonly BaseTypeInfo TypeBool = new BaseTypeInfo
        {
            Name = "bool",
            Prefix = "b",
            HasArithmetics = false,
            HashCodeMultiplier = 2,
            OneValue = "true",
            HasLogicOps = true
        };
        public static readonly BaseTypeInfo TypeGeneric = new BaseTypeInfo
        {
            Name = "T",
            Prefix = "g",
            Generic = true,
            HasArithmetics = false,
            OneValue = null
        };

        public string Name { get; set; }
        public string Prefix { get; set; }
        public bool Generic { get; set; }
        public bool Complex { get; set; }
        public bool Decimal { get; set; }

        public bool HasArithmetics { get; set; } = true;
        public string LengthType { get; set; } = "float";
        public bool RequiredAbs { get; set; } = true;
        public bool IsInteger { get; set; } = false;

        public bool HasLogicOps { get; set; }

        public string OneValue { get; set; } = "1";

        public int HashCodeMultiplier { get; set; } = 397;

        public string ZeroValue => "default(" + Name + ")";
    }
}
