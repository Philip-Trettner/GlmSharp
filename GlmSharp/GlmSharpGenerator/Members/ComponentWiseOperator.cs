using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Members
{
    class ComponentWiseOperator : Member
    {
        /// <summary>
        /// Func return type
        /// </summary>
        public AbstractType ReturnType { get; set; }

        /// <summary>
        /// If true, parameter 0 could be scalar
        /// </summary>
        public bool CanScalar0 { get; set; } = true;
        /// <summary>
        /// If true, parameter 1 could be scalar
        /// </summary>
        public bool CanScalar1 { get; set; } = true;
        /// <summary>
        /// If true, parameter 2 could be scalar
        /// </summary>
        public bool CanScalar2 { get; set; } = true;
        

        /// <summary>
        /// string.Format-compatible string for each component
        /// </summary>
        public string CompString { get; set; }

        /// <summary>
        /// Array of parameter types
        /// </summary>
        public AbstractType[] ParameterTypes { get; set; }
        /// <summary>
        /// Parameter names
        /// </summary>
        public string[] ParameterNames { get; set; }

        public string AdditionalComment { get; set; }

        /// <summary>
        /// If non-null, overrides return value
        /// </summary>
        public string ReturnOverride { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        public IEnumerable<string> Fields { get; set; }

        private void BuildComment()
        {
            Comment = "Returns a " + ReturnType.Name + " from component-wise application of " + Name + " (" + (!string.IsNullOrEmpty(AdditionalComment) ? AdditionalComment : string.Format(CompString, ParameterNames.OfType<object>().ToArray())) + ").";
            Comment = Comment.Replace("&", "&amp;");
            Comment = Comment.Replace(">", "&gt;");
            Comment = Comment.Replace("<", "&lt;");
        }

        public ComponentWiseOperator(IEnumerable<string> fields, AbstractType returnType, string name, AbstractType para0, string paraName0, string compString)
        {
            Fields = fields;
            ReturnType = returnType;
            Name = "operator" + name;
            ParameterTypes = new[] { para0 };
            ParameterNames = new[] { paraName0 };
            CompString = compString;
            Static = true;

            Comment = "DUMMY << >> &&";
        }

        public ComponentWiseOperator(IEnumerable<string> fields, AbstractType returnType, string name, AbstractType para0, string paraName0, AbstractType para1, string paraName1, string compString)
        {
            Fields = fields;
            ReturnType = returnType;
            Name = "operator" + name;
            ParameterTypes = new[] { para0, para1 };
            ParameterNames = new[] { paraName0, paraName1 };
            CompString = compString;
            Static = true;

            Comment = "DUMMY << >> &&";
        }

        public ComponentWiseOperator(IEnumerable<string> fields, AbstractType returnType, string name, AbstractType para0, string paraName0, AbstractType para1, string paraName1, AbstractType para2, string paraName2, string compString)
        {
            Fields = fields;
            ReturnType = returnType;
            Name = "operator" + name;
            ParameterTypes = new[] { para0, para1, para2 };
            ParameterNames = new[] { paraName0, paraName1, paraName2 };
            CompString = compString;
            Static = true;

            Comment = "DUMMY << >> &&";
        }

        private class ArgInfo
        {
            public AbstractType Type;
            public string ParaName;
            public string ParaInvoke;
            public bool Scalar;
        }

        private IEnumerable<string> ParaInfosS(int i)
        {
            if (i >= ParameterNames.Length)
            {
                yield return "";
                yield break;
            }

            foreach (var s in ParaInfosS(i + 1))
                yield return "0" + s;

            if (i == 0 && CanScalar0)
                foreach (var s in ParaInfosS(i + 1))
                    yield return "1" + s;

            if (i == 1 && CanScalar1)
                foreach (var s in ParaInfosS(i + 1))
                    yield return "1" + s;

            if (i == 2 && CanScalar2)
                foreach (var s in ParaInfosS(i + 1))
                    yield return "1" + s;
        }
        private ArgInfo[] ParaInfos(string s)
        {
            var info = new ArgInfo[s.Length];
            for (var i = 0; i < s.Length; ++i)
            {
                info[i] = new ArgInfo
                {
                    ParaName = ParameterNames[i],
                    Type = s[i] == '0' ? ParameterTypes[i] : ParameterTypes[i].BaseType,
                    Scalar = s[i] != '0',
                    ParaInvoke = s[i] == '0' && !(ParameterTypes[i] is BuiltinType) ? "{0}.{1}" : "{0}"
                };
            }
            return info;
        }

        public override IEnumerable<string> Lines
        {
            get
            {
                // TODO: Upcasts

                foreach (var pis in ParaInfosS(0))
                {
                    var arginfo = ParaInfos(pis);
                    if (arginfo.All(a => a.Scalar))
                        continue; // not all scalars for ops

                    BuildComment();
                    foreach (var line in base.Lines)
                        yield return line;

                    string invok;
                    if (arginfo.All(a => a.Scalar))
                        invok = string.Format(CompString, arginfo.Select(a => (object)a.ParaName).ToArray());
                    else invok = Fields.Select(f => string.Format(CompString, arginfo.Select(a => (object)string.Format(a.ParaInvoke, a.ParaName, f)).ToArray())).CommaSeparated();

                    if (!string.IsNullOrEmpty(ReturnOverride))
                    {
                        yield return $"{MemberPrefix} {ReturnType.NameThat} {Name}({arginfo.Select(a => a.Type.NameThat + " " + a.ParaName).CommaSeparated()}) => {ReturnOverride};".Trim();
                    }
                    else
                    {
                        yield return string.Format("{0} {1} {2}({3}) => new {1}({4});",
                            MemberPrefix, ReturnType.NameThat, Name,
                            arginfo.Select(a => a.Type.NameThat + " " + a.ParaName).CommaSeparated(),
                            invok
                            ).Trim();
                    }
                }
            }
        }
    }
}
