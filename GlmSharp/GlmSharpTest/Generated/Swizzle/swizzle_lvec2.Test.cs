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
    public class LongSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new lvec2(-1L, 3L);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
            }
            {
                var ov = new lvec2(-9L, -3L);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec2(-6L, 3L);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec2(3L, 8L);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec2(7L, -4L);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec2(-5L, -2L);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec2(5L, -7L);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec2(-8L, -6L);
                var v = ov.swizzle.xy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-6L, v.y);
            }
            {
                var ov = new lvec2(5L, -8L);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec2(-6L, 9L);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec2(-5L, 0);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec2(-5L, 3L);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec2(-2L, -1L);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec2(-7L, 3L);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec2(2L, -6L);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(2L, v.y);
            }
            {
                var ov = new lvec2(6L, -6L);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec2(6L, -2L);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec2(-1L, -2L);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec2(-1L, 8L);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec2(1, -1L);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec2(0, 8L);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec2(-2L, -8L);
                var v = ov.swizzle.yy;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
            }
            {
                var ov = new lvec2(-2L, -7L);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec2(9L, -4L);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec2(8L, 8L);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec2(-9L, 8L);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec2(-1L, 6L);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec2(-1L, -1L);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new lvec2(5L, -4L);
                var v = ov.swizzle.rr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var ov = new lvec2(-7L, -6L);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec2(-9L, 5L);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec2(1, -3L);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec2(-6L, 4L);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec2(8L, 8L);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
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
                var ov = new lvec2(-4L, -9L);
                var v = ov.swizzle.rg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
            }
            {
                var ov = new lvec2(-9L, 0);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec2(-4L, -8L);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec2(2L, -1L);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec2(-4L, 9L);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec2(3L, -3L);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec2(-2L, 6L);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec2(-9L, -6L);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-9L, v.y);
            }
            {
                var ov = new lvec2(-2L, -5L);
                var v = ov.swizzle.grr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec2(4L, -3L);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec2(-8L, 1);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec2(-9L, 2L);
                var v = ov.swizzle.grg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec2(-7L, 8L);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec2(-9L, -8L);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec2(9L, 7L);
                var v = ov.swizzle.gg;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
            }
            {
                var ov = new lvec2(7L, -4L);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(7L, v.z);
            }
            {
                var ov = new lvec2(1, -5L);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec2(1, -8L);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec2(-2L, 6L);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec2(-1L, -3L);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec2(-9L, -5L);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new lvec2(4L, 8L);
                var v1 = new lvec2(-2L, -9L);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-2L, v0.x);
                Assert.AreEqual(-9L, v0.y);
            
                Assert.AreEqual(4L, v2.x);
                Assert.AreEqual(8L, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new lvec2(-5L, -7L);
                var v1 = 8L;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(8L, v0.x);
                Assert.AreEqual(-7L, v0.y);
            
                Assert.AreEqual(-5L, v2);
            }
            {
                var v0 = new lvec2(-8L, -4L);
                var v1 = 1;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8L, v0.x);
                Assert.AreEqual(1, v0.y);
            
                Assert.AreEqual(-4L, v2);
            }
            {
                var v0 = new lvec2(-4L, 5L);
                var v1 = new lvec2(-3L, -5L);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3L, v0.x);
                Assert.AreEqual(-5L, v0.y);
            
                Assert.AreEqual(-4L, v2.x);
                Assert.AreEqual(5L, v2.y);
            }
        }

    }
}
