using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator.Tests
{
    class TestFunc
    {
        public string Name { get; set; }
        public IEnumerable<string> Code { get; set; }

        public TestFunc(string name, params string[] code)
            : this(name, code as IEnumerable<string>)
        {
        }
        public TestFunc(string name, IEnumerable<string> code)
        {
            Name = name;
            Code = code;
        }
    }
}
