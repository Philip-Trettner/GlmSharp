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
    public class LongSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new lvec2(-1, 3);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
            }
            {
                var ov = new lvec2(-9, -3);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new lvec2(-6, 3);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new lvec2(3, 8);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new lvec2(7, -4);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new lvec2(-5, -2);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new lvec2(5, -7);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new lvec2(-8, -6);
                var v = ov.swizzle.xy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-6, v.y);
            }
            {
                var ov = new lvec2(5, -8);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new lvec2(-6, 9);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new lvec2(-5, 0);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec2(-5, 3);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new lvec2(-2, -1);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new lvec2(-7, 3);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new lvec2(2, -6);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var ov = new lvec2(6, -6);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new lvec2(6, -2);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new lvec2(-1, -2);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new lvec2(-1, 8);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var ov = new lvec2(1, -1);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec2(0, 8);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new lvec2(-2, -8);
                var v = ov.swizzle.yy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
            }
            {
                var ov = new lvec2(-2, -7);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var ov = new lvec2(9, -4);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new lvec2(8, 8);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new lvec2(-9, 8);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var ov = new lvec2(-1, 6);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new lvec2(-1, -1);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new lvec2(5, -4);
                var v = ov.swizzle.rr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var ov = new lvec2(-7, -6);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var ov = new lvec2(-9, 5);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new lvec2(1, -3);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new lvec2(-6, 4);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(4, v.z);
            }
            {
                var ov = new lvec2(8, 8);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new lvec2(0, 0);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec2(-4, -9);
                var v = ov.swizzle.rg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-9, v.y);
            }
            {
                var ov = new lvec2(-9, 0);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new lvec2(-4, -8);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new lvec2(2, -1);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new lvec2(-4, 9);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new lvec2(3, -3);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new lvec2(-2, 6);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new lvec2(-9, -6);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-9, v.y);
            }
            {
                var ov = new lvec2(-2, -5);
                var v = ov.swizzle.grr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var ov = new lvec2(4, -3);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new lvec2(-8, 1);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec2(-9, 2);
                var v = ov.swizzle.grg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new lvec2(-7, 8);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new lvec2(-9, -8);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new lvec2(9, 7);
                var v = ov.swizzle.gg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
            }
            {
                var ov = new lvec2(7, -4);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var ov = new lvec2(1, -5);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec2(1, -8);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new lvec2(-2, 6);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new lvec2(-1, -3);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new lvec2(-9, -5);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
        }

    }
}
