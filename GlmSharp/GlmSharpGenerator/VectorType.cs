using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlmSharpGenerator
{
    class VectorType : TypeBase
    {
        public int Components { get; set; } = 3;
        public override string ClassName => Name + Components;
        public string CompString => "xyzw".Substring(0, Components);
        public string CompParameterString => CompString.Select(c => BaseType + " " + c).CommaSeparated();
        public string CompArgString => CompString.CommaSeparated();

        public SwizzleType SwizzleType => new SwizzleType { BaseType = BaseType, BaseName = Name, Components = Components, Name = "swizzle_" + Name };

        protected override IEnumerable<string> Body
        {
            get
            {
                // components
                for (var i = 0; i < Components; ++i)
                    yield return string.Format("public {0} {1};", BaseType, "xyzw"[i]);

                // swizzle
                yield return "";
                yield return string.Format("public swizzle_{0} swizzle => new swizzle_{0}({1});", ClassName, CompArgString);

                // ctors
                yield return "";
                yield return string.Format("public {0}({1})", ClassName, CompParameterString);
                yield return "{";
                foreach (var c in CompString)
                    yield return string.Format("this.{0} = {0};", c).Indent();
                yield return "}";
            }
        }
    }
}
