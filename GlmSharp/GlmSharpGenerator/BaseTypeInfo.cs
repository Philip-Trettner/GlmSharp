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
            Prefix = "d"
        };
        public static readonly BaseTypeInfo TypeLong = new BaseTypeInfo
        {
            Name = "long",
            Prefix = "l"
        };
        public static readonly BaseTypeInfo TypeBool = new BaseTypeInfo
        {
            Name = "bool",
            Prefix = "b"
        };
        public static readonly BaseTypeInfo TypeGeneric = new BaseTypeInfo
        {
            Name = "T",
            Prefix = "g",
            Generic = true
        };

        public string Name { get; set; }
        public string Prefix { get; set; }
        public bool Generic { get; set; }
    }
}
