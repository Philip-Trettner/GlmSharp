using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Members
{
    class Function : Member
    {
        /// <summary>
        /// Return types
        /// </summary>
        public AbstractType ReturnType { get; set; }

        /// <summary>
        /// Parameters
        /// </summary>
        public IEnumerable<string> Parameters { get; set; } = new string[] { };

        /// <summary>
        /// Parameters as a string
        /// </summary>
        public string ParameterString { set { Parameters = new[] { value }; } }

        /// <summary>
        /// Lines of code
        /// </summary>
        public IEnumerable<string> Code { get; set; }

        /// <summary>
        /// Code as a string
        /// </summary>
        public string CodeString { set { Code = new[] { value }; } }
        
        /// <summary>
        /// True if override property
        /// </summary>
        public bool Override { get; set; }

        public virtual string ReturnName => ReturnType.NameThat;
        public virtual string FunctionName => Name;

        public override string MemberPrefix => base.MemberPrefix + (Override ? " override" : "");

        public Function(AbstractType returnType, string name)
        {
            ReturnType = returnType;
            Name = name;
        }

        public override IEnumerable<string> Lines
        {
            get
            {
                foreach (var line in base.Lines)
                    yield return line;

                var code = Code.ToArray();

                if (code.Length == 1)
                {
                    yield return string.Format("{0} {1} {2}({3}) => {4};", MemberPrefix, ReturnName, FunctionName, Parameters.CommaSeparated(), code[0]).Trim();
                }
                else
                {
                    yield return string.Format("{0} {1} {2}({3})", MemberPrefix, ReturnName, FunctionName, Parameters.CommaSeparated()).Trim();
                    yield return "{";
                    foreach (var line in code)
                        yield return line.Indent();
                    yield return "}";
                }
            }
        }
    }

}
