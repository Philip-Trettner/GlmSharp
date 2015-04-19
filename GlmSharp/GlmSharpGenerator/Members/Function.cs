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

        public override IEnumerable<Member> GlmMembers()
        {
            if (OriginalType is SwizzleType)
                yield break; // nothing for swizzling
            if (Visibility != "public")
                yield break;
            if (this is ExplicitOperator)
                yield break;
            if (this is ImplicitOperator)
                yield break;
            if (this is Operator)
                yield break;

            if (Static)
            {
                var paras = Parameters.ParasRecovered().ToArray();
                if (paras.Length == 0)
                    throw new NotSupportedException();

                var ptype = paras[0].Split(' ')[0];
                if (ptype == OriginalType.NameThat)
                {
                    yield return new Function(ReturnType, Name + OriginalType.GenericSuffix)
                    {
                        Static = true,
                        Parameters = Parameters,
                        Comment = Comment,
                        CodeString = $"{OriginalType.NameThat}.{Name}({Parameters.ArgNames().CommaSeparated()})"
                    };
                }

                yield break; // nothing for static props
            }

            var varname = OriginalType is VectorType ? "v" : OriginalType is QuaternionType ? "q" : "m";

            yield return new Function(ReturnType, Name + OriginalType.GenericSuffix)
            {
                Static = true,
                Comment = Comment,
                Parameters = OriginalType.TypedArgs(varname).Concat(Parameters),
                CodeString = $"{varname}.{Name}({Parameters.ArgNames().CommaSeparated()})"
            };
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
                    yield return $"{MemberPrefix} {ReturnName} {FunctionName}({Parameters.CommaSeparated()}) => {code[0]};".Trim();
                }
                else
                {
                    yield return $"{MemberPrefix} {ReturnName} {FunctionName}({Parameters.CommaSeparated()})".Trim();
                    yield return "{";
                    foreach (var line in code)
                        yield return line.Indent();
                    yield return "}";
                }
            }
        }
    }

}
