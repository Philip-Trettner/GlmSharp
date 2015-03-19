using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Swizzle
{
    [TestFixture]
    public class UintSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new uvec2(4, 9);
                var v = ov.swizzle.xx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
            }
            {
                var ov = new uvec2(9, 6);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new uvec2(1u, 3);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec2(3, 2);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new uvec2(8, 2);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new uvec2(6, 2);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new uvec2(9, 4);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new uvec2(2, 4);
                var v = ov.swizzle.xy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(4, v.y);
            }
            {
                var ov = new uvec2(8, 7);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var ov = new uvec2(6, 9);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new uvec2(2, 8);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new uvec2(9, 3);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new uvec2(1u, 8);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec2(0u, 6);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new uvec2(3, 4);
                var v = ov.swizzle.yx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(3, v.y);
            }
            {
                var ov = new uvec2(3, 6);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new uvec2(9, 6);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new uvec2(7, 3);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new uvec2(1u, 6);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new uvec2(1u, 2);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec2(5, 4);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new uvec2(2, 3);
                var v = ov.swizzle.yy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
            }
            {
                var ov = new uvec2(1u, 5);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec2(3, 2);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new uvec2(1u, 5);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new uvec2(7, 7);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var ov = new uvec2(0u, 4);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec2(8, 6);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new uvec2(3, 9);
                var v = ov.swizzle.rr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
            }
            {
                var ov = new uvec2(9, 8);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new uvec2(6, 1u);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new uvec2(8, 8);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new uvec2(4, 6);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new uvec2(5, 8);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new uvec2(3, 4);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new uvec2(3, 2);
                var v = ov.swizzle.rg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var ov = new uvec2(3, 2);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new uvec2(9, 4);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new uvec2(6, 6);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new uvec2(5, 3);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new uvec2(6, 3);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new uvec2(3, 8);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new uvec2(7, 2);
                var v = ov.swizzle.gr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(7, v.y);
            }
            {
                var ov = new uvec2(6, 9);
                var v = ov.swizzle.grr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new uvec2(6, 5);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new uvec2(7, 3);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new uvec2(3, 8);
                var v = ov.swizzle.grg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var ov = new uvec2(7, 7);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new uvec2(4, 9);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new uvec2(8, 9);
                var v = ov.swizzle.gg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
            }
            {
                var ov = new uvec2(8, 1u);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var ov = new uvec2(2, 1u);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new uvec2(4, 9);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new uvec2(7, 0u);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var ov = new uvec2(0u, 5);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec2(5, 6);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
        }

    }
}
