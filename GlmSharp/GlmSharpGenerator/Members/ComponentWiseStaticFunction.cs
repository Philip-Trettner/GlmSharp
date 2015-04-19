using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Members
{
    class ComponentWiseStaticFunction : Member
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
        public string FirstParameter { get; set; }

        /// <summary>
        /// Fields
        /// </summary>
        public IEnumerable<string> Fields { get; set; }

        /// <summary>
        /// If non-empty, overwrites comment generation
        /// </summary>
        public string CommentOverride { get; set; }

        /// <summary>
        /// If true, does not generate glm versions
        /// </summary>
        public bool DisableGlmGen { get; set; }

        private void BuildComment(bool allScalar)
        {
            Comment = string.Format("Returns a {0} from {3} application of {1} ({2}).", (allScalar ? ReturnType.BaseName : ReturnType.Name), Name, (!string.IsNullOrEmpty(AdditionalComment) ? AdditionalComment : string.Format(CompString, ParameterNames.OfType<object>().ToArray())), allScalar ? "the" : "component-wise");
            Comment = Comment.Replace("&", "&amp;");
            Comment = Comment.Replace(">", "&gt;");
            Comment = Comment.Replace("<", "&lt;");

            if (!string.IsNullOrEmpty(CommentOverride))
                Comment = CommentOverride;
        }

        public ComponentWiseStaticFunction(IEnumerable<string> fields, AbstractType returnType, string name, AbstractType para0, string paraName0, string compString)
        {
            Fields = fields;
            ReturnType = returnType;
            Name = name;
            ParameterTypes = new[] { para0 };
            ParameterNames = new[] { paraName0 };
            CompString = compString;
            Static = true;

            Comment = "DUMMY << >> &&";
        }

        public ComponentWiseStaticFunction(IEnumerable<string> fields, AbstractType returnType, string name, AbstractType para0, string paraName0, AbstractType para1, string paraName1, string compString)
        {
            Fields = fields;
            ReturnType = returnType;
            Name = name;
            ParameterTypes = new[] { para0, para1 };
            ParameterNames = new[] { paraName0, paraName1 };
            CompString = compString;
            Static = true;

            Comment = "DUMMY << >> &&";
        }

        public ComponentWiseStaticFunction(IEnumerable<string> fields, AbstractType returnType, string name, AbstractType para0, string paraName0, AbstractType para1, string paraName1, AbstractType para2, string paraName2, string compString)
        {
            Fields = fields;
            ReturnType = returnType;
            Name = name;
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
                    ParaInvoke = s[i] == '0' ? "{0}.{1}" : "{0}"
                };
            }
            return info;
        }

        public override IEnumerable<Member> GlmMembers()
        {
            if (DisableGlmGen)
                yield break;

            var ap = string.IsNullOrEmpty(FirstParameter) ? new string[] { } : new[] { FirstParameter };
            var ap2 = string.IsNullOrEmpty(FirstParameter) ? "" : FirstParameter.Split(' ').Last() + ", ";

            BuildComment(false);
            yield return new Function(ReturnType, Name + OriginalType.GenericSuffix)
            {
                Static = true,
                Comment = Comment,
                Parameters = ap.Concat(ParameterNames.Select((p, i) => ParameterTypes[i].NameThat + " " + p)),
                CodeString = $"{OriginalType.NameThat}.{Name}({ap2 + ParameterNames.CommaSeparated()})"
            };

            // scalar version
            if (OriginalType is VectorType && ((VectorType)OriginalType).Components == 3 &&
                CanScalar0 && CanScalar1 && CanScalar2)
            {
                yield return new Function(ReturnType.BaseType ?? ReturnType, Name + OriginalType.GenericSuffix)
                {
                    Static = true,
                    Comment = Comment,
                    Parameters = ap.Concat(ParameterNames.Select((p, i) => (ParameterTypes[i].BaseType ?? ParameterTypes[i]).NameThat + " " + p)),
                    CodeString = string.Format(CompString, ParameterNames.OfType<object>().ToArray())
                };
            }
        }

        public override IEnumerable<string> Lines
        {
            get
            {
                foreach (var pis in ParaInfosS(0))
                {
                    var arginfo = ParaInfos(pis);

                    BuildComment(arginfo.All(a => a.Scalar));
                    foreach (var line in base.Lines)
                        yield return line;

                    string invok;
                    if (arginfo.All(a => a.Scalar))
                        invok = string.Format(CompString, arginfo.Select(a => (object)a.ParaName).ToArray());
                    else invok = Fields.Select(f => string.Format(CompString, arginfo.Select(a => (object)string.Format(a.ParaInvoke, a.ParaName, f)).ToArray())).CommaSeparated();

                    var ap = string.IsNullOrEmpty(FirstParameter) ? "" : FirstParameter + ", ";

                    yield return string.Format("{0} {1} {2}({3}) => new {1}({4});",
                        MemberPrefix, ReturnType.NameThat, Name,
                        ap + arginfo.Select(a => a.Type.NameThat + " " + a.ParaName).CommaSeparated(),
                        invok
                        ).Trim();
                }
            }
        }
    }
}
