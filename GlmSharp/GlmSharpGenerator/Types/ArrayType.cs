using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Members;

namespace GlmSharpGenerator.Types
{
    class ArrayType : AbstractType
    {
        /// <summary>
        /// Array suffix
        /// </summary>
        public string ArraySuffix { get; set; }

        public override string GenericSuffix => ""; // no suffix

        public ArrayType(BuiltinType type, string suffix = "[]")
        {
            BaseType = type;
            ArraySuffix = suffix;
        }

        public override string Name => BaseType.Name + ArraySuffix;

        public override string TypeComment
        {
            get { throw new NotSupportedException(); }
        }

        public override IEnumerable<Member> GenerateMembers()
        {
            throw new NotSupportedException();
        }
    }
}
