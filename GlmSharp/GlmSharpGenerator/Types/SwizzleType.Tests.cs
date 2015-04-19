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
                    yield return $"var ov = {Construct(VectorType, vals)};".Indent();
                    yield return $"var v = ov.swizzle.{swizzle};".Indent();
                    for (var i = 0; i < swizzle.Length; ++i)
                        yield return $"Assert.AreEqual({vals["xyzw".IndexOf(swizzle[i])]}, v.{"xyzw"[i]});".Indent();
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
                    yield return $"var ov = {Construct(VectorType, vals)};".Indent();
                    yield return $"var v = ov.swizzle.{ToRgba(swizzle)};".Indent();
                    for (var i = 0; i < swizzle.Length; ++i)
                        yield return $"Assert.AreEqual({vals["xyzw".IndexOf(swizzle[i])]}, v.{"xyzw"[i]});".Indent();
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
                    yield return $"var v0 = {Construct(VectorType, vals)};".Indent();
                    yield return $"var v1 = {Construct(vecType, subvals)};".Indent();
                    yield return $"var v2 = v0.{swizzle};".Indent();
                    yield return $"v0.{swizzle} = v1;".Indent();
                    yield return $"var v3 = v0.{swizzle};".Indent();
                    yield return "";
                    yield return "Assert.AreEqual(v1, v3);".Indent();
                    yield return "";
                    for (var i = 0; i < Components; ++i)
                        yield return $"Assert.AreEqual({(swizzleBits[i] == '1' ? subvals[swizzleBits.Substring(0, i).Count(c => c == '1')] : vals[i])}, v0.{"xyzw"[i]});".Indent();
                    yield return "";
                    for (var i = 0; i < swizzle.Length; ++i)
                        yield return $"Assert.AreEqual({vals["xyzw".IndexOf(swizzle[i])]}, v2.{"xyzw"[i]});".Indent();
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
                    yield return $"var v0 = {Construct(VectorType, vals)};".Indent();
                    yield return $"var v1 = {(swizzle.Length == 1 ? (BaseType.Generic ? subvals[0] : ConstantStringFor(subvals[0])) : Construct(vecType, subvals))};".Indent();
                    yield return $"var v2 = v0.{ToRgba(swizzle)};".Indent();
                    yield return $"v0.{ToRgba(swizzle)} = v1;".Indent();
                    yield return $"var v3 = v0.{ToRgba(swizzle)};".Indent();
                    yield return "";
                    yield return "Assert.AreEqual(v1, v3);".Indent();
                    yield return "";
                    for (var i = 0; i < Components; ++i)
                        yield return $"Assert.AreEqual({(swizzleBits[i] == '1' ? subvals[swizzleBits.Substring(0, i).Count(c => c == '1')] : vals[i])}, v0.{"xyzw"[i]});".Indent();
                    yield return "";
                    if (swizzle.Length == 1)
                        yield return $"Assert.AreEqual({vals["xyzw".IndexOf(swizzle[0])]}, v2);".Indent();
                    else
                        for (var i = 0; i < swizzle.Length; ++i)
                            yield return $"Assert.AreEqual({vals["xyzw".IndexOf(swizzle[i])]}, v2.{"xyzw"[i]});".Indent();
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
