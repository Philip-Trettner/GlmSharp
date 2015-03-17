using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Members
{
    class Operator : Function
    {
        public Operator(AbstractType type, string op) : base(type, "operator" + op)
        {
            Static = true;
        }
    }
}
