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
        private IEnumerable<string> InlineSwizzle(int nr = 0)
        {
            if (nr >= Components)
            {
                yield return "";
                yield break;
            }

            foreach (var sw in InlineSwizzle(nr + 1))
            {
                yield return "0" + sw;
                yield return "1" + sw;
            }
        }

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

        private IEnumerable<string> InlineXyzwTests
        {
            get
            {
                foreach (var swizzleBits in InlineSwizzle())
                {
                    if (swizzleBits.Count(c => c == '1') < 2)
                        continue; // at least two set

                    var swizzle = swizzleBits.Select((c, i) => c == '1' ? "xyzw"[i].ToString() : "").Aggregate((s1, s2) => s1 + s2);
                    var vecType = new VectorType(BaseType, swizzle.Length);

                    var vals = BaseType.RandomSmallVals(Components);
                    var subvals = BaseType.RandomSmallVals(swizzle.Length);

                    yield return "{";
                    yield return string.Format("var v0 = {0};", Construct(VectorType, vals)).Indent();
                    yield return string.Format("var v1 = {0};", Construct(vecType, subvals)).Indent();
                    yield return string.Format("var v2 = v0.{0};", swizzle).Indent();
                    yield return string.Format("v0.{0} = v1;", swizzle).Indent();
                    yield return string.Format("var v3 = v0.{0};", swizzle).Indent();
                    yield return "";
                    yield return "Assert.AreEqual(v1, v3);".Indent();
                    yield return "";
                    for (var i = 0; i < Components; ++i)
                        yield return string.Format("Assert.AreEqual({0}, v0.{1});", swizzleBits[i] == '1' ? subvals[swizzleBits.Substring(0, i).Count(c => c == '1')] : vals[i], "xyzw"[i]).Indent();
                    yield return "";
                    for (var i = 0; i < swizzle.Length; ++i)
                        yield return string.Format("Assert.AreEqual({0}, v2.{1});", vals["xyzw".IndexOf(swizzle[i])], "xyzw"[i]).Indent();
                    yield return "}";
                }
            }
        }

        private IEnumerable<string> InlineRgbaTests
        {
            get
            {
                foreach (var swizzleBits in InlineSwizzle())
                {
                    if (swizzleBits.Count(c => c == '1') < 1)
                        continue; // at least one set

                    var swizzle = swizzleBits.Select((c, i) => c == '1' ? "xyzw"[i].ToString() : "").Aggregate((s1, s2) => s1 + s2);
                    var vecType = new VectorType(BaseType, swizzle.Length);

                    var vals = BaseType.RandomSmallVals(Components);
                    var subvals = BaseType.RandomSmallVals(swizzle.Length);

                    yield return "{";
                    yield return string.Format("var v0 = {0};", Construct(VectorType, vals)).Indent();
                    yield return string.Format("var v1 = {0};", swizzle.Length == 1 ? (BaseType.Generic ? "" : BaseTypeCast) + subvals[0] : Construct(vecType, subvals)).Indent();
                    yield return string.Format("var v2 = v0.{0};", ToRgba(swizzle)).Indent();
                    yield return string.Format("v0.{0} = v1;", ToRgba(swizzle)).Indent();
                    yield return string.Format("var v3 = v0.{0};", ToRgba(swizzle)).Indent();
                    yield return "";
                    yield return "Assert.AreEqual(v1, v3);".Indent();
                    yield return "";
                    for (var i = 0; i < Components; ++i)
                        yield return string.Format("Assert.AreEqual({0}, v0.{1});", swizzleBits[i] == '1' ? subvals[swizzleBits.Substring(0, i).Count(c => c == '1')] : vals[i], "xyzw"[i]).Indent();
                    yield return "";
                    if (swizzle.Length == 1)
                        yield return string.Format("Assert.AreEqual({0}, v2);", vals["xyzw".IndexOf(swizzle[0])]).Indent();
                    else
                        for (var i = 0; i < swizzle.Length; ++i)
                            yield return string.Format("Assert.AreEqual({0}, v2.{1});", vals["xyzw".IndexOf(swizzle[i])], "xyzw"[i]).Indent();
                    yield return "}";
                }
            }
        }

        public override IEnumerable<TestFunc> GenerateTests()
        {
            yield return new TestFunc(this, "XYZW", XyzwTests);
            yield return new TestFunc(this, "RGBA", RgbaTests);
            yield return new TestFunc(this, "InlineXYZW", InlineXyzwTests);
            yield return new TestFunc(this, "InlineRGBA", InlineRgbaTests);
        }
    }
}
