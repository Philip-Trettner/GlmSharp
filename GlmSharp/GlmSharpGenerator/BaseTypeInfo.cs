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
                yield return TypeLong;
                yield return TypeBool;
                yield return TypeGeneric;
            }
        }

        public static readonly BaseTypeInfo TypeInt = new BaseTypeInfo
        {
            Name = "int",
            Prefix = "i"
        };
        public static readonly BaseTypeInfo TypeUint = new BaseTypeInfo
        {
            Name = "uint",
            Prefix = "u"
        };
        public static readonly BaseTypeInfo TypeFloat = new BaseTypeInfo
        {
            Name = "float"
        };
        public static readonly BaseTypeInfo TypeDouble = new BaseTypeInfo
        {
            Name = "double",
            Prefix = "d",
            LengthType = "double"
        };
        public static readonly BaseTypeInfo TypeLong = new BaseTypeInfo
        {
            Name = "long",
            Prefix = "l",
            LengthType = "double"
        };
        public static readonly BaseTypeInfo TypeBool = new BaseTypeInfo
        {
            Name = "bool",
            Prefix = "b",
            Arithmetics = false,
            HashCodeMultiplier = 2
        };
        public static readonly BaseTypeInfo TypeGeneric = new BaseTypeInfo
        {
            Name = "T",
            Prefix = "g",
            Generic = true,
            Arithmetics = false
        };

        public string Name { get; set; }
        public string Prefix { get; set; }
        public bool Generic { get; set; }

        public bool Arithmetics { get; set; } = true;
        public string LengthType { get; set; } = "float";

        public int HashCodeMultiplier { get; set; } = 397;
    }
}
