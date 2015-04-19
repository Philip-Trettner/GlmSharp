using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Swizzle
{
    [TestFixture]
    public class HalfSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new hvec2(new Half(8.5), new Half(9));
                var v = ov.swizzle.xx;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
            }
            {
                var ov = new hvec2(new Half(9.5), new Half(5.5));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
            }
            {
                var ov = new hvec2(new Half(2.5), new Half(-9.5));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-2), new Half(7));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec2(new Half(-3.5), new Half(-7));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
            }
            {
                var ov = new hvec2(Half.One, new Half(-2));
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec2(new Half(-8.5), new Half(4.5));
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec2(new Half(7), new Half(-1.5));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
            }
            {
                var ov = new hvec2(new Half(0.5), new Half(-3));
                var v = ov.swizzle.xyx;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
            }
            {
                var ov = new hvec2(new Half(-8), new Half(5));
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec2(new Half(7), Half.One);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec2(new Half(-4.5), new Half(-7));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-7), v.z);
            }
            {
                var ov = new hvec2(new Half(6), new Half(-9.5));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec2(new Half(7), new Half(5.5));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-5.5), new Half(2));
                var v = ov.swizzle.yx;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
            }
            {
                var ov = new hvec2(new Half(-4), new Half(8.5));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-4), v.z);
            }
            {
                var ov = new hvec2(new Half(8.5), new Half(-3));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-2), Half.Zero);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec2(new Half(-9), new Half(2.5));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
            }
            {
                var ov = new hvec2(new Half(-3), new Half(3));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec2(new Half(-9.5), new Half(-2));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec2(new Half(-0.5), Half.One);
                var v = ov.swizzle.yy;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
            }
            {
                var ov = new hvec2(new Half(6), new Half(-5.5));
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(6), v.z);
            }
            {
                var ov = new hvec2(new Half(-3), new Half(5));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec2(Half.Zero, Half.One);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec2(new Half(-1), new Half(-9));
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-9), v.z);
            }
            {
                var ov = new hvec2(new Half(-4.5), new Half(8));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-3), new Half(6.5));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new hvec2(new Half(-6.5), new Half(9.5));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
            }
            {
                var ov = new hvec2(new Half(-2.5), new Half(-8.5));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
            }
            {
                var ov = new hvec2(new Half(-8), new Half(6));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec2(new Half(3.5), new Half(9.5));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-6), Half.Zero);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(Half.Zero, v.z);
            }
            {
                var ov = new hvec2(new Half(-5), new Half(8));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec2(new Half(-9), new Half(6.5));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-8.5), new Half(9.5));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
            }
            {
                var ov = new hvec2(new Half(7), new Half(-4));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(7), v.z);
            }
            {
                var ov = new hvec2(new Half(-2), new Half(-5));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec2(new Half(7.5), new Half(7));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec2(new Half(4), new Half(2.5));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
            }
            {
                var ov = new hvec2(new Half(0.5), new Half(-5));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-4.5), new Half(-1.5));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec2(new Half(-6.5), new Half(-5.5));
                var v = ov.swizzle.gr;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
            }
            {
                var ov = new hvec2(new Half(1.5), new Half(-2));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
            }
            {
                var ov = new hvec2(Half.Zero, Half.One);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec2(new Half(5), new Half(4.5));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec2(Half.One, Half.Zero);
                var v = ov.swizzle.grg;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.Zero, v.z);
            }
            {
                var ov = new hvec2(new Half(2), new Half(8.5));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec2(new Half(-8.5), new Half(-4));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-4), v.w);
            }
            {
                var ov = new hvec2(new Half(5.5), new Half(-1));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-1), v.y);
            }
            {
                var ov = new hvec2(Half.Zero, new Half(-6.5));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
            }
            {
                var ov = new hvec2(new Half(-5), new Half(-6.5));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec2(new Half(0.5), new Half(3));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec2(new Half(-8.5), new Half(5));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
            }
            {
                var ov = new hvec2(new Half(1.5), new Half(6));
                var v = ov.swizzle.gggr;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec2(new Half(8), new Half(-5));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new hvec2(new Half(-4.5), new Half(-9.5));
                var v1 = new hvec2(new Half(-6.5), new Half(9));
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-6.5), v0.x);
                Assert.AreEqual(new Half(9), v0.y);
            
                Assert.AreEqual(new Half(-4.5), v2.x);
                Assert.AreEqual(new Half(-9.5), v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new hvec2(new Half(6), new Half(6.5));
                var v1 = new Half(new Half(-7));
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-7), v0.x);
                Assert.AreEqual(new Half(6.5), v0.y);
            
                Assert.AreEqual(new Half(6), v2);
            }
            {
                var v0 = new hvec2(new Half(6), new Half(-0.5));
                var v1 = new Half(new Half(-6));
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(6), v0.x);
                Assert.AreEqual(new Half(-6), v0.y);
            
                Assert.AreEqual(new Half(-0.5), v2);
            }
            {
                var v0 = new hvec2(new Half(1.5), Half.One);
                var v1 = new hvec2(new Half(6.5), new Half(-8));
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(6.5), v0.x);
                Assert.AreEqual(new Half(-8), v0.y);
            
                Assert.AreEqual(new Half(1.5), v2.x);
                Assert.AreEqual(Half.One, v2.y);
            }
        }

    }
}
