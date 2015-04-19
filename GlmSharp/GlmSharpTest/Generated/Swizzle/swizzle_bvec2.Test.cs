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
    public class BoolSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.yx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.gr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.grr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.grg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.gg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec2(false, true);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(false, false);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec2(true, false);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec2(true, true);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new bvec2(true, true);
                var v1 = new bvec2(true, true);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new bvec2(false, false);
                var v1 = true;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
            
                Assert.AreEqual(false, v2);
            }
            {
                var v0 = new bvec2(false, true);
                var v1 = false;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec2(true, true);
                var v1 = new bvec2(true, false);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
        }

    }
}
