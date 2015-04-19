using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Types;

namespace GlmSharpGenerator.Members
{
    class Property : Member
    {
        /// <summary>
        /// Property type
        /// </summary>
        public AbstractType Type { get; set; }

        /// <summary>
        /// True if override property
        /// </summary>
        public bool Override { get; set; }

        /// <summary>
        /// Getter code
        /// </summary>
        public IEnumerable<string> Getter { get; set; }
        /// <summary>
        /// Setter code
        /// </summary>
        public IEnumerable<string> Setter { get; set; }

        /// <summary>
        /// Single-Line getter
        /// </summary>
        public string GetterLine { set { Getter = new[] { value }; } }
        /// <summary>
        /// Single-Line setter
        /// </summary>
        public string SetterLine { set { Setter = new[] { value }; } }

        /// <summary>
        /// Initial value
        /// </summary>
        public string Value { get; set; }

        public override string MemberPrefix => base.MemberPrefix + (Override ? " override" : "");

        public Property(string name, AbstractType type)
        {
            Name = name;
            Type = type;
        }

        public override IEnumerable<Member> GlmMembers()
        {
            if (Static)
                yield break; // nothing for static props
            if (OriginalType is SwizzleType)
                yield break; // nothing for swizzling
            if (Setter != null)
                yield break; // nothing for stuff with setters
            
            var varname = OriginalType is VectorType ? "v" : OriginalType is QuaternionType ? "q" : "m";
            yield return new Function(Type, Name + OriginalType.GenericSuffix)
            {
                Static = true,
                Comment = Comment,
                ParameterString = $"{OriginalType.NameThat} {varname}",
                CodeString = $"{varname}.{Name}"
            };
        }

        public override IEnumerable<string> Lines
        {
            get
            {
                foreach (var line in base.Lines)
                    yield return line;

                if (!string.IsNullOrEmpty(Value))
                {
                    yield return $"{MemberPrefix} {Type.NameThat} {Name} {{ get; }} = {Value};";
                    yield break;
                }

                var getter = Getter?.ToArray();
                var setter = Setter?.ToArray();

                if (getter == null)
                    throw new NotSupportedException();

                if (setter == null) // getter-only
                {
                    if (getter.Length == 1)
                        yield return $"{MemberPrefix} {Type.NameThat} {Name} => {getter[0]};";
                    else
                    {
                        yield return $"{MemberPrefix} {Type.NameThat} {Name}";
                        yield return "{";
                        yield return "    get";
                        yield return "    {";
                        foreach (var line in getter)
                            yield return line.Indent(2);
                        yield return "    }";
                        yield return "}";
                    }
                }
                else
                {
                    yield return $"{MemberPrefix} {Type.NameThat} {Name}";
                    yield return "{";
                    yield return "    get";
                    yield return "    {";
                    foreach (var line in getter)
                        yield return line.Indent(2);
                    yield return "    }";
                    yield return "    set";
                    yield return "    {";
                    foreach (var line in setter)
                        yield return line.Indent(2);
                    yield return "    }";
                    yield return "}";
                }
            }
        }
    }
}
