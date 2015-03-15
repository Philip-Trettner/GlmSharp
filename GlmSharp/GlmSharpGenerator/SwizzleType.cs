using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator
{
    class SwizzleType : TypeBase
    {
        public int Components { get; set; } = 3;
        public override string ClassName => Name + Components;
        public string BaseName { get; set; }

        public string CompString => "xyzw".Substring(0, Components);

        private IEnumerable<string> Swizzle(int i)
        {
            if (i >= 4)
            {
                yield return "";
                yield break;
            }
            
            if (i > 1)
                yield return "";

            for (var a = 0; a < Components; ++a)
                foreach (var sw in Swizzle(i + 1))
                    yield return "xyzw"[a] + sw;
        }

        private static string ToRgba(string xyzw)
        {
            var s = "";
            foreach (var c in xyzw)
            {
                switch (c)
                {
                    case 'x': s += 'r'; break;
                    case 'y': s += 'g'; break;
                    case 'z': s += 'b'; break;
                    case 'w': s += 'a'; break;
                }
            }
            return s;
        }

        protected override IEnumerable<string> Body
        {
            get
            {
                // components
                for (var i = 0; i < Components; ++i)
                    yield return string.Format("public readonly {0} {1};", BaseType, "xyzw"[i]);

                // ctor
                yield return "";
                yield return string.Format("public {0}({1})", ClassName, CompString.Select(c => BaseType + " " + c).CommaSeparated());
                yield return "{";
                foreach (var c in CompString)
                    yield return string.Format("this.{0} = {0};", c).Indent();
                yield return "}";

                // swizzle
                yield return "";
                yield return "// XYZW Versions";
                foreach (var swizzle in Swizzle(0))
                    yield return string.Format("public {0}{1} {2} => new {0}{1}({3});", BaseName, swizzle.Length + GenericSuffic, swizzle, swizzle.CommaSeparated());
                yield return "";
                yield return "// RGBA Versions";
                foreach (var swizzle in Swizzle(0))
                    yield return string.Format("public {0}{1} {2} => new {0}{1}({3});", BaseName, swizzle.Length + GenericSuffic, ToRgba(swizzle), swizzle.CommaSeparated());
            }
        }
    }
}
