using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Members
{
    class Constructor : Member
    {
        /// <summary>
        /// Constructor type
        /// </summary>
        public AbstractType Type { get; set; }

        /// <summary>
        /// ctor parameters
        /// </summary>
        public IEnumerable<string> Parameters { get; set; }

        /// <summary>
        /// Single parameter
        /// </summary>
        public string ParameterString { set { Parameters = new[] { value }; } }

        /// <summary>
        /// Constructor chain
        /// </summary>
        public string ConstructorChain { get; set; }

        /// <summary>
        /// Fields to initialize
        /// </summary>
        public IEnumerable<string> Fields { get; set; }

        /// <summary>
        /// Initializer ienumerable
        /// </summary>
        public IEnumerable<string> Initializers { get; set; }

        public IEnumerable<string> Code { get; set; }

        public override IEnumerable<string> Lines
        {
            get
            {
                foreach (var line in base.Lines)
                    yield return line;

                yield return $"{MemberPrefix} {Type.Name}({Parameters.CommaSeparated()})";
                if (!string.IsNullOrEmpty(ConstructorChain))
                    yield return (": " + ConstructorChain).Indent();
                yield return "{";
                if (Code != null)
                    foreach (var code in Code)
                        yield return code.Indent();
                if (string.IsNullOrEmpty(ConstructorChain))
                {
                    var it = Initializers.GetEnumerator();
                    foreach (var c in Fields)
                        yield return $"this.{c} = {(it.MoveNext() ? it.Current : Type.ZeroValue)};".Indent();
                }
                yield return "}";
            }
        }

        public Constructor(AbstractType type, IEnumerable<string> fields)
        {
            Fields = fields;
            Type = type;
        }
    }
}
