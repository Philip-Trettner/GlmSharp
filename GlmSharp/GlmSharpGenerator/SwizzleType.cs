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
            if (i >= Components)
            {
                yield return "";
                yield break;
            }

            for (var a = 0; a < Components; ++a)
                foreach (var sw in Swizzle(i + 1))
                    yield return "xyzw"[a] + sw;

            if (i > 1)
                yield return "";
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
                foreach (var swizzle in Swizzle(0))
                    yield return string.Format("public {0}{1} {2} => new {0}{1}({3});", BaseName, swizzle.Length + GenericSuffic, swizzle, swizzle.CommaSeparated());
            }
        }
    }
}
