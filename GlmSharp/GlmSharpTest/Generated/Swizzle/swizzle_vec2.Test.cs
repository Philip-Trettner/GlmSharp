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
    public class FloatSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new vec2(1.5f, 8);
                var v = ov.swizzle.xx;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
            }
            {
                var ov = new vec2(0.5f, -7);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
            }
            {
                var ov = new vec2(8.5f, -7.5f);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec2(-3, -4);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new vec2(-1.5f, 5.5f);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
            }
            {
                var ov = new vec2(-8, -4);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new vec2(-1.5f, -6.5f);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec2(-2.5f, -7.5f);
                var v = ov.swizzle.xy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
            }
            {
                var ov = new vec2(-9.5f, 3);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-9.5f, v.z);
            }
            {
                var ov = new vec2(2, 9.5f);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new vec2(-1.5f, 8);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new vec2(7, 3);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new vec2(0.5f, -6);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec2(-6.5f, 2.5f);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec2(5.5f, 5.5f);
                var v = ov.swizzle.yx;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
            }
            {
                var ov = new vec2(-9, -5.5f);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new vec2(-7, 7);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new vec2(3, 3.5f);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec2(-2, -9.5f);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-9.5f, v.z);
            }
            {
                var ov = new vec2(-8, -7.5f);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new vec2(9, -0.5f);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec2(5, -8.5f);
                var v = ov.swizzle.yy;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
            }
            {
                var ov = new vec2(6, 5.5f);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new vec2(-3.5f, 0.5f);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec2(-1.5f, -2.5f);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec2(-7, 1f);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
            }
            {
                var ov = new vec2(4.5f, 1f);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec2(-7.5f, -6.5f);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new vec2(-3, -0.5f);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
            }
            {
                var ov = new vec2(4.5f, -0.5f);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
            }
            {
                var ov = new vec2(0f, 8.5f);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec2(8.5f, -3);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new vec2(8, 9.5f);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(9.5f, v.z);
            }
            {
                var ov = new vec2(7.5f, 2);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec2(4.5f, -8);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new vec2(1f, 1f);
                var v = ov.swizzle.rg;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
            }
            {
                var ov = new vec2(-8.5f, 5);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec2(6, -3.5f);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new vec2(8.5f, 4);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new vec2(-4.5f, 2);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new vec2(-8, 2.5f);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new vec2(-8, -4.5f);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec2(-0.5f, -7);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-0.5f, v.y);
            }
            {
                var ov = new vec2(2, 7);
                var v = ov.swizzle.grr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new vec2(0f, -8.5f);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec2(-1.5f, -4.5f);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec2(0f, 2.5f);
                var v = ov.swizzle.grg;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(2.5f, v.z);
            }
            {
                var ov = new vec2(-3, -6);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new vec2(-3, -3);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new vec2(-5, -9);
                var v = ov.swizzle.gg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
            }
            {
                var ov = new vec2(-8.5f, -8);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec2(0.5f, -3.5f);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec2(-8.5f, 2);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new vec2(5.5f, 8.5f);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
            }
            {
                var ov = new vec2(9.5f, -2);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec2(4, 7);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new vec2(4, 9.5f);
                var v1 = new vec2(6, 3);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6, v0.x);
                Assert.AreEqual(3, v0.y);
            
                Assert.AreEqual(4, v2.x);
                Assert.AreEqual(9.5f, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new vec2(6.5f, -3.5f);
                var v1 = (float)-5.5f;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5.5f, v0.x);
                Assert.AreEqual(-3.5f, v0.y);
            
                Assert.AreEqual(6.5f, v2);
            }
            {
                var v0 = new vec2(-5, -1);
                var v1 = (float)7;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5, v0.x);
                Assert.AreEqual(7, v0.y);
            
                Assert.AreEqual(-1, v2);
            }
            {
                var v0 = new vec2(5.5f, -5);
                var v1 = new vec2(-0.5f, -7);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-0.5f, v0.x);
                Assert.AreEqual(-7, v0.y);
            
                Assert.AreEqual(5.5f, v2.x);
                Assert.AreEqual(-5, v2.y);
            }
        }

    }
}
