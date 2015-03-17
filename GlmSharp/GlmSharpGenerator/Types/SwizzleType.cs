using System.Collections.Generic;
using System.Linq;

namespace GlmSharpGenerator.Types
{
    class SwizzleType : AbstractType
    {
        public int Components { get; set; } = 3;
        public override string Name => BaseName + Components;
        public string OriginalTypeName { get; set; }

        public string CompString => "xyzw".Substring(0, Components);
        public override string Namespace { get; } = "GlmSharp.Swizzle";

        public override string Folder => "Swizzle";

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

        public override string TypeComment => string.Format("Temporary vector of type {0} with {1} components, used for implementing swizzling for {2}.", BaseTypeName, Components, BaseType.Prefix + "vec" + Components);

        protected override IEnumerable<string> Body
        {
            get
            {
                // components
                for (var i = 0; i < Components; ++i)
                {
                    foreach (var line in string.Format("{0}-component", "xyzw"[i]).AsComment()) yield return line;
                    yield return "[DataMember]";
                    yield return string.Format("internal readonly {0} {1};", BaseTypeName, "xyzw"[i]);
                }

                // ctor
                yield return "";
                foreach (var line in string.Format("Constructor for {0}.", Name).AsComment()) yield return line;
                yield return string.Format("internal {0}({1})", Name, CompString.Select(c => BaseTypeName + " " + c).CommaSeparated());
                yield return "{";
                foreach (var c in CompString)
                    yield return string.Format("this.{0} = {0};", c).Indent();
                yield return "}";

                // swizzle
                yield return "";
                yield return "// XYZW Versions";
                foreach (var swizzle in Swizzle(0))
                {
                    foreach (var line in string.Format("Returns {0}.{1} swizzling.", BaseType.Prefix + "vec" + Components, swizzle).AsComment()) yield return line;
                    yield return string.Format("public {0}{1} {2} => new {0}{1}({3});", OriginalTypeName, swizzle.Length + GenericSuffix, swizzle, swizzle.CommaSeparated());
                }
                yield return "";
                yield return "// RGBA Versions";
                foreach (var swizzle in Swizzle(0))
                {
                    foreach (var line in string.Format("Returns {0}.{1} swizzling.", BaseType.Prefix + "vec" + Components, ToRgba(swizzle)).AsComment()) yield return line;
                    yield return string.Format("public {0}{1} {2} => new {0}{1}({3});", OriginalTypeName, swizzle.Length + GenericSuffix, ToRgba(swizzle), swizzle.CommaSeparated());
                }
            }
        }
    }
}
