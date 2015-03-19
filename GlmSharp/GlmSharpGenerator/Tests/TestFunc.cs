using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Tests
{
    class TestFunc
    {
        public string Name { get; set; }
        public IEnumerable<string> Code { get; set; }


        public TestFunc(AbstractType type, string name, params string[] code)
            : this(type, name, code as IEnumerable<string>)
        {
        }
        public TestFunc(AbstractType type, string name, IEnumerable<string> code)
        {
            type.ResetRandom(name.GetHashCode());
            Name = name;
            Code = code.ToArray();
        }
    }
}
