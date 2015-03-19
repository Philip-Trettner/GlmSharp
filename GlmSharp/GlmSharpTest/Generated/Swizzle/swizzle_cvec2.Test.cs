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
    public class ComplexSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new cvec2(new Complex(5.5d, 6.5d), new Complex(-5.5d, -6.5d));
                var v = ov.swizzle.xx;
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.y);
            }
            {
                var ov = new cvec2(new Complex(1.5d, 6.5d), new Complex(-5, 9));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new Complex(1.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 6.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(8.5d, 9.5d), new Complex(-3, -9.5d));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new Complex(8.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-1, -6), new Complex(-6.5d, 3.5d));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(new Complex(-1, -6), v.x);
                Assert.AreEqual(new Complex(-1, -6), v.y);
                Assert.AreEqual(new Complex(-1, -6), v.z);
                Assert.AreEqual(new Complex(-6.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(5, 6.5d), new Complex(-2, -6));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new Complex(5, 6.5d), v.x);
                Assert.AreEqual(new Complex(5, 6.5d), v.y);
                Assert.AreEqual(new Complex(-2, -6), v.z);
            }
            {
                var ov = new cvec2(new Complex(2, -3.5d), new Complex(-7.5d, 9.5d));
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(new Complex(2, -3.5d), v.x);
                Assert.AreEqual(new Complex(2, -3.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(2, -3.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(7.5d, -4.5d), new Complex(-4.5d, -2.5d));
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-1.5d, 1.0), new Complex(6, -5.5d));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new Complex(-1.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(6, -5.5d), v.y);
            }
            {
                var ov = new cvec2(new Complex(1.5d, -6), new Complex(-1.5d, -8.5d));
                var v = ov.swizzle.xyx;
                Assert.AreEqual(new Complex(1.5d, -6), v.x);
                Assert.AreEqual(new Complex(-1.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -6), v.z);
            }
            {
                var ov = new cvec2(new Complex(6.5d, -4), new Complex(-8.5d, 5.5d));
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(new Complex(6.5d, -4), v.x);
                Assert.AreEqual(new Complex(-8.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -4), v.z);
                Assert.AreEqual(new Complex(6.5d, -4), v.w);
            }
            {
                var ov = new cvec2(new Complex(-3, 2.5d), new Complex(-7.5d, 9.5d));
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new Complex(-3, 2.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-3, 2.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(7, -0.5d), new Complex(0.0, -2));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new Complex(7, -0.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -2), v.y);
                Assert.AreEqual(new Complex(0.0, -2), v.z);
            }
            {
                var ov = new cvec2(new Complex(-2.5d, -5), new Complex(-7, 1.0));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new Complex(-2.5d, -5), v.x);
                Assert.AreEqual(new Complex(-7, 1.0), v.y);
                Assert.AreEqual(new Complex(-7, 1.0), v.z);
                Assert.AreEqual(new Complex(-2.5d, -5), v.w);
            }
            {
                var ov = new cvec2(new Complex(6.5d, -8), new Complex(6.5d, -0.5d));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new Complex(6.5d, -8), v.x);
                Assert.AreEqual(new Complex(6.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-2.5d, -9), new Complex(-6.5d, 6));
                var v = ov.swizzle.yx;
                Assert.AreEqual(new Complex(-6.5d, 6), v.x);
                Assert.AreEqual(new Complex(-2.5d, -9), v.y);
            }
            {
                var ov = new cvec2(new Complex(0.5d, 2.5d), new Complex(4, -1));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new Complex(4, -1), v.x);
                Assert.AreEqual(new Complex(0.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 2.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(4.5d, 3), new Complex(-9, 6.5d));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(new Complex(-9, 6.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 3), v.y);
                Assert.AreEqual(new Complex(4.5d, 3), v.z);
                Assert.AreEqual(new Complex(4.5d, 3), v.w);
            }
            {
                var ov = new cvec2(new Complex(-3, 8), new Complex(4, 0.0));
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(new Complex(4, 0.0), v.x);
                Assert.AreEqual(new Complex(-3, 8), v.y);
                Assert.AreEqual(new Complex(-3, 8), v.z);
                Assert.AreEqual(new Complex(4, 0.0), v.w);
            }
            {
                var ov = new cvec2(new Complex(5, -2), new Complex(5, 9));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new Complex(5, 9), v.x);
                Assert.AreEqual(new Complex(5, -2), v.y);
                Assert.AreEqual(new Complex(5, 9), v.z);
            }
            {
                var ov = new cvec2(new Complex(9.5d, -9), new Complex(5, -4.5d));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new Complex(5, -4.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -9), v.y);
                Assert.AreEqual(new Complex(5, -4.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -9), v.w);
            }
            {
                var ov = new cvec2(new Complex(2.5d, -1), new Complex(-6.5d, -3.5d));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -1), v.y);
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(7, -9), new Complex(-3.5d, 7));
                var v = ov.swizzle.yy;
                Assert.AreEqual(new Complex(-3.5d, 7), v.x);
                Assert.AreEqual(new Complex(-3.5d, 7), v.y);
            }
            {
                var ov = new cvec2(new Complex(-2.5d, 3), new Complex(-4.5d, 0.5d));
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new Complex(-4.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 3), v.z);
            }
            {
                var ov = new cvec2(new Complex(2, 2), new Complex(-7, 2));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new Complex(-7, 2), v.x);
                Assert.AreEqual(new Complex(-7, 2), v.y);
                Assert.AreEqual(new Complex(2, 2), v.z);
                Assert.AreEqual(new Complex(2, 2), v.w);
            }
            {
                var ov = new cvec2(new Complex(0.0, -5), new Complex(-7.5d, -9));
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(new Complex(-7.5d, -9), v.x);
                Assert.AreEqual(new Complex(-7.5d, -9), v.y);
                Assert.AreEqual(new Complex(0.0, -5), v.z);
                Assert.AreEqual(new Complex(-7.5d, -9), v.w);
            }
            {
                var ov = new cvec2(new Complex(2.5d, 7), new Complex(-1, -1));
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new Complex(-1, -1), v.x);
                Assert.AreEqual(new Complex(-1, -1), v.y);
                Assert.AreEqual(new Complex(-1, -1), v.z);
            }
            {
                var ov = new cvec2(new Complex(-7, 2.5d), new Complex(-2.5d, -8.5d));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-7, 2.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(8, 1.5d), new Complex(-3, 5.5d));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new Complex(-3, 5.5d), v.x);
                Assert.AreEqual(new Complex(-3, 5.5d), v.y);
                Assert.AreEqual(new Complex(-3, 5.5d), v.z);
                Assert.AreEqual(new Complex(-3, 5.5d), v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new cvec2(new Complex(-9.5d, -5.5d), new Complex(-4, -2));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new Complex(-9.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -5.5d), v.y);
            }
            {
                var ov = new cvec2(new Complex(-9.5d, 4), new Complex(9.5d, -3.5d));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new Complex(-9.5d, 4), v.x);
                Assert.AreEqual(new Complex(-9.5d, 4), v.y);
                Assert.AreEqual(new Complex(-9.5d, 4), v.z);
            }
            {
                var ov = new cvec2(new Complex(-5.5d, -0.5d), new Complex(9.5d, 8));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(new Complex(-5.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(3.5d, 8), new Complex(-5, 7));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new Complex(3.5d, 8), v.x);
                Assert.AreEqual(new Complex(3.5d, 8), v.y);
                Assert.AreEqual(new Complex(3.5d, 8), v.z);
                Assert.AreEqual(new Complex(-5, 7), v.w);
            }
            {
                var ov = new cvec2(new Complex(5.5d, -4.5d), new Complex(5.5d, 1.5d));
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 1.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-6, 0.5d), new Complex(-9, -6));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new Complex(-6, 0.5d), v.x);
                Assert.AreEqual(new Complex(-6, 0.5d), v.y);
                Assert.AreEqual(new Complex(-9, -6), v.z);
                Assert.AreEqual(new Complex(-6, 0.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(5.5d, -6), new Complex(-2.5d, 0.5d));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new Complex(5.5d, -6), v.x);
                Assert.AreEqual(new Complex(5.5d, -6), v.y);
                Assert.AreEqual(new Complex(-2.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(1.0, -5), new Complex(-8, -7.5d));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new Complex(1.0, -5), v.x);
                Assert.AreEqual(new Complex(-8, -7.5d), v.y);
            }
            {
                var ov = new cvec2(new Complex(8, -0.5d), new Complex(-0.5d, 0.0));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new Complex(8, -0.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(8, -0.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-0.5d, 2.5d), new Complex(0.5d, 1.5d));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new Complex(-0.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(3, 2), new Complex(-1.5d, -6.5d));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new Complex(3, 2), v.x);
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(3, 2), v.z);
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-2.5d, -7), new Complex(-6, -8.5d));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new Complex(-2.5d, -7), v.x);
                Assert.AreEqual(new Complex(-6, -8.5d), v.y);
                Assert.AreEqual(new Complex(-6, -8.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-1, 2.5d), new Complex(-1, 0.5d));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new Complex(-1, 2.5d), v.x);
                Assert.AreEqual(new Complex(-1, 0.5d), v.y);
                Assert.AreEqual(new Complex(-1, 0.5d), v.z);
                Assert.AreEqual(new Complex(-1, 2.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-4, 3), new Complex(-0.5d, 7.5d));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new Complex(-4, 3), v.x);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-2.5d, 6), new Complex(4, 5));
                var v = ov.swizzle.gr;
                Assert.AreEqual(new Complex(4, 5), v.x);
                Assert.AreEqual(new Complex(-2.5d, 6), v.y);
            }
            {
                var ov = new cvec2(new Complex(7, -1.5d), new Complex(-8, -3.5d));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new Complex(-8, -3.5d), v.x);
                Assert.AreEqual(new Complex(7, -1.5d), v.y);
                Assert.AreEqual(new Complex(7, -1.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(5.5d, -4.5d), new Complex(7, -2));
                var v = ov.swizzle.grrr;
                Assert.AreEqual(new Complex(7, -2), v.x);
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(5, 0.5d), new Complex(7.5d, -2.5d));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new Complex(7.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(5, 0.5d), v.y);
                Assert.AreEqual(new Complex(5, 0.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(-1.5d, -0.5d), new Complex(-3, -4.5d));
                var v = ov.swizzle.grg;
                Assert.AreEqual(new Complex(-3, -4.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-3, -4.5d), v.z);
            }
            {
                var ov = new cvec2(new Complex(-0.5d, -7.5d), new Complex(1.0, -7.5d));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(new Complex(1.0, -7.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(1.0, -7.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(3.5d, 6), new Complex(-3.5d, 2));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new Complex(-3.5d, 2), v.x);
                Assert.AreEqual(new Complex(3.5d, 6), v.y);
                Assert.AreEqual(new Complex(-3.5d, 2), v.z);
                Assert.AreEqual(new Complex(-3.5d, 2), v.w);
            }
            {
                var ov = new cvec2(new Complex(-4, 3), new Complex(5.5d, 8));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new Complex(5.5d, 8), v.x);
                Assert.AreEqual(new Complex(5.5d, 8), v.y);
            }
            {
                var ov = new cvec2(new Complex(-9.5d, -7), new Complex(-5.5d, 8.5d));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new Complex(-5.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -7), v.z);
            }
            {
                var ov = new cvec2(new Complex(4, 1.0), new Complex(4.5d, 0.5d));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(4, 1.0), v.z);
                Assert.AreEqual(new Complex(4, 1.0), v.w);
            }
            {
                var ov = new cvec2(new Complex(0.5d, -6), new Complex(-5.5d, 3));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new Complex(-5.5d, 3), v.x);
                Assert.AreEqual(new Complex(-5.5d, 3), v.y);
                Assert.AreEqual(new Complex(0.5d, -6), v.z);
                Assert.AreEqual(new Complex(-5.5d, 3), v.w);
            }
            {
                var ov = new cvec2(new Complex(1.0, 8.5d), new Complex(7.5d, 6));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new Complex(7.5d, 6), v.x);
                Assert.AreEqual(new Complex(7.5d, 6), v.y);
                Assert.AreEqual(new Complex(7.5d, 6), v.z);
            }
            {
                var ov = new cvec2(new Complex(-6.5d, 7.5d), new Complex(-4.5d, 9));
                var v = ov.swizzle.gggr;
                Assert.AreEqual(new Complex(-4.5d, 9), v.x);
                Assert.AreEqual(new Complex(-4.5d, 9), v.y);
                Assert.AreEqual(new Complex(-4.5d, 9), v.z);
                Assert.AreEqual(new Complex(-6.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec2(new Complex(4, 0.5d), new Complex(2.5d, 0.0));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new Complex(2.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.w);
            }
        }

    }
}
