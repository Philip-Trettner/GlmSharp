using System.Collections.Generic;
using System.Linq;
using GlmSharpGenerator.Members;

namespace GlmSharpGenerator.Types
{
    partial class SwizzleType : AbstractType
    {
        public int Components { get; set; }

        public override string Name => BaseName + Components;

        public override string Namespace { get; } = "GlmSharp.Swizzle";

        public override string Folder => "Swizzle";
        public override string DataContractArg { get; } = "(Namespace = \"swizzle\")";

        public IEnumerable<string> Fields => "xyzw".Substring(0, Components).Select(c => c.ToString());

        public override string TypeComment => $"Temporary vector of type {BaseTypeName} with {Components} components, used for implementing swizzling for {VectorType.Name}.";

        /// <summary>
        /// Class name for tests
        /// </summary>
        public override string TestClassName => BaseTypeName.Capitalized() + Folder + VectorType.Folder + "Test";

        /// <summary>
        /// Type for swizzling
        /// </summary>
        public VectorType VectorType => Types[BaseType.Prefix + "vec" + Components] as VectorType;
        /// <summary>
        /// Type for swizzling
        /// </summary>
        public VectorType VectorTypeFor(int comps) => Types[BaseType.Prefix + "vec" + comps] as VectorType;

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
    }
}
