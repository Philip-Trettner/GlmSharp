using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharpGenerator.Tests;

namespace GlmSharpGenerator.Types
{
    partial class SwizzleType
    {
        private IEnumerable<string> XyzwTests
        {
            get
            {
                foreach (var swizzle in Swizzle(0))
                {
                    var vals = BaseType.RandomSmallVals(Components);

                    yield return "{";
                    yield return string.Format("var ov = {0};", Construct(VectorType, vals)).Indent();
                    yield return string.Format("var v = ov.swizzle.{0};", swizzle).Indent();
                    for (var i = 0; i < swizzle.Length; ++i)
                        yield return string.Format("Assert.AreEqual({0}, v.{1});", vals["xyzw".IndexOf(swizzle[i])], "xyzw"[i]).Indent();
                    yield return "}";
                }
            }
        }

        private IEnumerable<string> RgbaTests
        {
            get
            {
                foreach (var swizzle in Swizzle(0))
                {
                    var vals = BaseType.RandomSmallVals(Components);

                    yield return "{";
                    yield return string.Format("var ov = {0};", Construct(VectorType, vals)).Indent();
                    yield return string.Format("var v = ov.swizzle.{0};", ToRgba(swizzle)).Indent();
                    for (var i = 0; i < swizzle.Length; ++i)
                        yield return string.Format("Assert.AreEqual({0}, v.{1});", vals["xyzw".IndexOf(swizzle[i])], "xyzw"[i]).Indent();
                    yield return "}";
                }
            }
        }

        public override IEnumerable<TestFunc> GenerateTests()
        {
            yield return new TestFunc(this, "XYZW", XyzwTests);
            yield return new TestFunc(this, "RGBA", RgbaTests);
        }
    }
}
