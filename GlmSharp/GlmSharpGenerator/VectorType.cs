using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace GlmSharpGenerator
{
    class VectorType : TypeBase
    {
        public int Components { get; set; } = 3;
        public override string ClassName => Name + Components;

        public string CompString => "xyzw".Substring(0, Components);

        public string CompParameterString => CompString.Select(c => BaseType + " " + c).CommaSeparated();
        public IEnumerable<string> CompParameters => CompString.Select(c => BaseType + " " + c);

        public string CompArgString => CompString.CommaSeparated();
        public IEnumerable<string> CompArgs => CompString.Select(c => c.ToString());

        public string DefaultValue => "default(" + BaseType + ")";

        public SwizzleType SwizzleType => new SwizzleType { BaseType = BaseType, BaseName = Name, Components = Components, Name = "swizzle_" + Name };

        private IEnumerable<string> Constructor(string comment, string args, IEnumerable<string> assignments)
        {
            yield return "";
            foreach (var line in comment.AsComment())
                yield return line;
            yield return string.Format("public {0}({1})", ClassName, args);
            yield return "{";
            var it = assignments.GetEnumerator();
            foreach (var c in CompString)
                yield return string.Format("this.{0} = {1};", c, it.MoveNext() ? it.Current : DefaultValue).Indent();
            yield return "}";
        }

        protected override IEnumerable<string> Body
        {
            get
            {
                // components
                for (var i = 0; i < Components; ++i)
                    yield return string.Format("public {0} {1};", BaseType, "xyzw"[i]);

                // swizzle
                yield return "";
                foreach (var line in "Returns an object that can be used for swizzling (e.g. swizzle.zy)".AsComment()) yield return line;
                yield return string.Format("public swizzle_{0} swizzle => new swizzle_{0}({1});", ClassName, CompArgString);

                // values
                yield return "";
                foreach (var line in "Returns an array with all values".AsComment()) yield return line;
                yield return string.Format("public {0}[] Values => new[] {{ {1} }};", BaseType, CompArgString);

                // ctors
                foreach (var line in Constructor("Component-wise constructor", CompParameterString, CompArgs)) yield return line;

                yield return "";
                foreach (var line in "all-same-value constructor".AsComment()) yield return line;
                yield return string.Format("public {0}({1} v)", ClassName, BaseType);
                yield return "{";
                foreach (var c in CompString)
                    yield return string.Format("this.{0} = v;", c).Indent();
                yield return "}";

                for (var comps = 2; comps <= 4; ++comps)
                {
                    yield return "";
                    foreach (var line in "from-vector constructor (empty fields are zero/false)".AsComment()) yield return line;
                    yield return string.Format("public {0}({1}{2} v)", ClassName, Name, comps);
                    yield return "{";
                    for (var c = 0; c < Components; ++c)
                        yield return string.Format("this.{0} = {1};", "xyzw"[c], c < comps ? "v." + "xyzw"[c] : DefaultValue).Indent();
                    yield return "}";
                }
            }
        }
    }
}
