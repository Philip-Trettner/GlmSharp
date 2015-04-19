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
    public class DecimalSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new decvec2(0.5m, -3m);
                var v = ov.swizzle.xx;
                Assert.AreEqual(0.5m, v.x);
                Assert.AreEqual(0.5m, v.y);
            }
            {
                var ov = new decvec2(4.5m, -4m);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(4.5m, v.x);
                Assert.AreEqual(4.5m, v.y);
                Assert.AreEqual(4.5m, v.z);
            }
            {
                var ov = new decvec2(2.5m, 8.5m);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(2.5m, v.y);
                Assert.AreEqual(2.5m, v.z);
                Assert.AreEqual(2.5m, v.w);
            }
            {
                var ov = new decvec2(0m, 4.5m);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(0m, v.x);
                Assert.AreEqual(0m, v.y);
                Assert.AreEqual(0m, v.z);
                Assert.AreEqual(4.5m, v.w);
            }
            {
                var ov = new decvec2(-4m, -5.5m);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-4m, v.x);
                Assert.AreEqual(-4m, v.y);
                Assert.AreEqual(-5.5m, v.z);
            }
            {
                var ov = new decvec2(4m, 5.5m);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(4m, v.x);
                Assert.AreEqual(4m, v.y);
                Assert.AreEqual(5.5m, v.z);
                Assert.AreEqual(4m, v.w);
            }
            {
                var ov = new decvec2(3.5m, 7m);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(3.5m, v.x);
                Assert.AreEqual(3.5m, v.y);
                Assert.AreEqual(7m, v.z);
                Assert.AreEqual(7m, v.w);
            }
            {
                var ov = new decvec2(4.5m, -7m);
                var v = ov.swizzle.xy;
                Assert.AreEqual(4.5m, v.x);
                Assert.AreEqual(-7m, v.y);
            }
            {
                var ov = new decvec2(7m, 6.5m);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(7m, v.x);
                Assert.AreEqual(6.5m, v.y);
                Assert.AreEqual(7m, v.z);
            }
            {
                var ov = new decvec2(0.5m, 5m);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(0.5m, v.x);
                Assert.AreEqual(5m, v.y);
                Assert.AreEqual(0.5m, v.z);
                Assert.AreEqual(0.5m, v.w);
            }
            {
                var ov = new decvec2(0m, -6.5m);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(0m, v.x);
                Assert.AreEqual(-6.5m, v.y);
                Assert.AreEqual(0m, v.z);
                Assert.AreEqual(-6.5m, v.w);
            }
            {
                var ov = new decvec2(4m, 4.5m);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(4m, v.x);
                Assert.AreEqual(4.5m, v.y);
                Assert.AreEqual(4.5m, v.z);
            }
            {
                var ov = new decvec2(-4m, -7m);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-4m, v.x);
                Assert.AreEqual(-7m, v.y);
                Assert.AreEqual(-7m, v.z);
                Assert.AreEqual(-4m, v.w);
            }
            {
                var ov = new decvec2(-1.5m, -3m);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-1.5m, v.x);
                Assert.AreEqual(-3m, v.y);
                Assert.AreEqual(-3m, v.z);
                Assert.AreEqual(-3m, v.w);
            }
            {
                var ov = new decvec2(5m, -3m);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-3m, v.x);
                Assert.AreEqual(5m, v.y);
            }
            {
                var ov = new decvec2(-2.5m, -3.5m);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(-2.5m, v.y);
                Assert.AreEqual(-2.5m, v.z);
            }
            {
                var ov = new decvec2(-2m, 4.5m);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(4.5m, v.x);
                Assert.AreEqual(-2m, v.y);
                Assert.AreEqual(-2m, v.z);
                Assert.AreEqual(-2m, v.w);
            }
            {
                var ov = new decvec2(1.5m, -2m);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(-2m, v.x);
                Assert.AreEqual(1.5m, v.y);
                Assert.AreEqual(1.5m, v.z);
                Assert.AreEqual(-2m, v.w);
            }
            {
                var ov = new decvec2(-1m, -9m);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-9m, v.x);
                Assert.AreEqual(-1m, v.y);
                Assert.AreEqual(-9m, v.z);
            }
            {
                var ov = new decvec2(6.5m, -3.5m);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(6.5m, v.y);
                Assert.AreEqual(-3.5m, v.z);
                Assert.AreEqual(6.5m, v.w);
            }
            {
                var ov = new decvec2(5m, 0m);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(0m, v.x);
                Assert.AreEqual(5m, v.y);
                Assert.AreEqual(0m, v.z);
                Assert.AreEqual(0m, v.w);
            }
            {
                var ov = new decvec2(-0.5m, 4.5m);
                var v = ov.swizzle.yy;
                Assert.AreEqual(4.5m, v.x);
                Assert.AreEqual(4.5m, v.y);
            }
            {
                var ov = new decvec2(-8.5m, -3.5m);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(-3.5m, v.y);
                Assert.AreEqual(-8.5m, v.z);
            }
            {
                var ov = new decvec2(-4m, -3.5m);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(-3.5m, v.y);
                Assert.AreEqual(-4m, v.z);
                Assert.AreEqual(-4m, v.w);
            }
            {
                var ov = new decvec2(-6.5m, 7.5m);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(7.5m, v.x);
                Assert.AreEqual(7.5m, v.y);
                Assert.AreEqual(-6.5m, v.z);
                Assert.AreEqual(7.5m, v.w);
            }
            {
                var ov = new decvec2(4m, 6m);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(6m, v.x);
                Assert.AreEqual(6m, v.y);
                Assert.AreEqual(6m, v.z);
            }
            {
                var ov = new decvec2(-5.5m, 9.5m);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(9.5m, v.x);
                Assert.AreEqual(9.5m, v.y);
                Assert.AreEqual(9.5m, v.z);
                Assert.AreEqual(-5.5m, v.w);
            }
            {
                var ov = new decvec2(6m, 6m);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(6m, v.x);
                Assert.AreEqual(6m, v.y);
                Assert.AreEqual(6m, v.z);
                Assert.AreEqual(6m, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new decvec2(-4m, 2m);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-4m, v.x);
                Assert.AreEqual(-4m, v.y);
            }
            {
                var ov = new decvec2(-7.5m, 8.5m);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(-7.5m, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(-7.5m, v.z);
            }
            {
                var ov = new decvec2(-7m, -4.5m);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(-7m, v.x);
                Assert.AreEqual(-7m, v.y);
                Assert.AreEqual(-7m, v.z);
                Assert.AreEqual(-7m, v.w);
            }
            {
                var ov = new decvec2(-7.5m, -3.5m);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(-7.5m, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(-7.5m, v.z);
                Assert.AreEqual(-3.5m, v.w);
            }
            {
                var ov = new decvec2(2m, 8m);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(2m, v.x);
                Assert.AreEqual(2m, v.y);
                Assert.AreEqual(8m, v.z);
            }
            {
                var ov = new decvec2(-8m, 1.5m);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(-8m, v.x);
                Assert.AreEqual(-8m, v.y);
                Assert.AreEqual(1.5m, v.z);
                Assert.AreEqual(-8m, v.w);
            }
            {
                var ov = new decvec2(1.5m, 9m);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(1.5m, v.x);
                Assert.AreEqual(1.5m, v.y);
                Assert.AreEqual(9m, v.z);
                Assert.AreEqual(9m, v.w);
            }
            {
                var ov = new decvec2(8m, -1.5m);
                var v = ov.swizzle.rg;
                Assert.AreEqual(8m, v.x);
                Assert.AreEqual(-1.5m, v.y);
            }
            {
                var ov = new decvec2(-3.5m, 6.5m);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(6.5m, v.y);
                Assert.AreEqual(-3.5m, v.z);
            }
            {
                var ov = new decvec2(-6.5m, -4m);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-6.5m, v.x);
                Assert.AreEqual(-4m, v.y);
                Assert.AreEqual(-6.5m, v.z);
                Assert.AreEqual(-6.5m, v.w);
            }
            {
                var ov = new decvec2(1.5m, -1.5m);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(1.5m, v.x);
                Assert.AreEqual(-1.5m, v.y);
                Assert.AreEqual(1.5m, v.z);
                Assert.AreEqual(-1.5m, v.w);
            }
            {
                var ov = new decvec2(-6.5m, 9m);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-6.5m, v.x);
                Assert.AreEqual(9m, v.y);
                Assert.AreEqual(9m, v.z);
            }
            {
                var ov = new decvec2(8.5m, -2m);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(8.5m, v.x);
                Assert.AreEqual(-2m, v.y);
                Assert.AreEqual(-2m, v.z);
                Assert.AreEqual(8.5m, v.w);
            }
            {
                var ov = new decvec2(5m, 6m);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(5m, v.x);
                Assert.AreEqual(6m, v.y);
                Assert.AreEqual(6m, v.z);
                Assert.AreEqual(6m, v.w);
            }
            {
                var ov = new decvec2(4m, 4.5m);
                var v = ov.swizzle.gr;
                Assert.AreEqual(4.5m, v.x);
                Assert.AreEqual(4m, v.y);
            }
            {
                var ov = new decvec2(4m, 9.5m);
                var v = ov.swizzle.grr;
                Assert.AreEqual(9.5m, v.x);
                Assert.AreEqual(4m, v.y);
                Assert.AreEqual(4m, v.z);
            }
            {
                var ov = new decvec2(-3m, -6.5m);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-6.5m, v.x);
                Assert.AreEqual(-3m, v.y);
                Assert.AreEqual(-3m, v.z);
                Assert.AreEqual(-3m, v.w);
            }
            {
                var ov = new decvec2(-5.5m, 5m);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(5m, v.x);
                Assert.AreEqual(-5.5m, v.y);
                Assert.AreEqual(-5.5m, v.z);
                Assert.AreEqual(5m, v.w);
            }
            {
                var ov = new decvec2(3.5m, -2.5m);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-2.5m, v.x);
                Assert.AreEqual(3.5m, v.y);
                Assert.AreEqual(-2.5m, v.z);
            }
            {
                var ov = new decvec2(-3.5m, -7.5m);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-7.5m, v.x);
                Assert.AreEqual(-3.5m, v.y);
                Assert.AreEqual(-7.5m, v.z);
                Assert.AreEqual(-3.5m, v.w);
            }
            {
                var ov = new decvec2(6m, 2m);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(2m, v.x);
                Assert.AreEqual(6m, v.y);
                Assert.AreEqual(2m, v.z);
                Assert.AreEqual(2m, v.w);
            }
            {
                var ov = new decvec2(4.5m, 3m);
                var v = ov.swizzle.gg;
                Assert.AreEqual(3m, v.x);
                Assert.AreEqual(3m, v.y);
            }
            {
                var ov = new decvec2(-4m, -4.5m);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-4.5m, v.x);
                Assert.AreEqual(-4.5m, v.y);
                Assert.AreEqual(-4m, v.z);
            }
            {
                var ov = new decvec2(-6m, 4m);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(4m, v.x);
                Assert.AreEqual(4m, v.y);
                Assert.AreEqual(-6m, v.z);
                Assert.AreEqual(-6m, v.w);
            }
            {
                var ov = new decvec2(-3m, 9.5m);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(9.5m, v.x);
                Assert.AreEqual(9.5m, v.y);
                Assert.AreEqual(-3m, v.z);
                Assert.AreEqual(9.5m, v.w);
            }
            {
                var ov = new decvec2(-5m, 2.5m);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(2.5m, v.y);
                Assert.AreEqual(2.5m, v.z);
            }
            {
                var ov = new decvec2(1.5m, 6.5m);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(6.5m, v.x);
                Assert.AreEqual(6.5m, v.y);
                Assert.AreEqual(6.5m, v.z);
                Assert.AreEqual(1.5m, v.w);
            }
            {
                var ov = new decvec2(1m, -4.5m);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-4.5m, v.x);
                Assert.AreEqual(-4.5m, v.y);
                Assert.AreEqual(-4.5m, v.z);
                Assert.AreEqual(-4.5m, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new decvec2(3m, -3.5m);
                var v1 = new decvec2(-9m, 4.5m);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-9m, v0.x);
                Assert.AreEqual(4.5m, v0.y);
            
                Assert.AreEqual(3m, v2.x);
                Assert.AreEqual(-3.5m, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new decvec2(7.5m, 9.5m);
                var v1 = -2m;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-2m, v0.x);
                Assert.AreEqual(9.5m, v0.y);
            
                Assert.AreEqual(7.5m, v2);
            }
            {
                var v0 = new decvec2(-5.5m, -1.5m);
                var v1 = 4.5m;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5.5m, v0.x);
                Assert.AreEqual(4.5m, v0.y);
            
                Assert.AreEqual(-1.5m, v2);
            }
            {
                var v0 = new decvec2(-9.5m, -1.5m);
                var v1 = new decvec2(-6.5m, -3.5m);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-6.5m, v0.x);
                Assert.AreEqual(-3.5m, v0.y);
            
                Assert.AreEqual(-9.5m, v2.x);
                Assert.AreEqual(-1.5m, v2.y);
            }
        }

    }
}
