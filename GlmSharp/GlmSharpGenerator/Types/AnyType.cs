using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Members;

namespace GlmSharpGenerator.Types
{
    class AnyType : AbstractType
    {
        public AnyType(string name)
        {
            Name = name;
        }

        public override string Name { get; }

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
