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
    public class TSwizzleVec2Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new gvec2<string>("(63)", "((-33)-5)");
                var v = ov.swizzle.xx;
                Assert.AreEqual("(63)", v.x);
                Assert.AreEqual("(63)", v.y);
            }
            {
                var ov = new gvec2<string>("((0-1)-7)", "((0-1)-7)");
                var v = ov.swizzle.xxx;
                Assert.AreEqual("((0-1)-7)", v.x);
                Assert.AreEqual("((0-1)-7)", v.y);
                Assert.AreEqual("((0-1)-7)", v.z);
            }
            {
                var ov = new gvec2<string>("(55)", "(55)");
                var v = ov.swizzle.xxxx;
                Assert.AreEqual("(55)", v.x);
                Assert.AreEqual("(55)", v.y);
                Assert.AreEqual("(55)", v.z);
                Assert.AreEqual("(55)", v.w);
            }
            {
                var ov = new gvec2<string>("(67)", "(42)");
                var v = ov.swizzle.xxxy;
                Assert.AreEqual("(67)", v.x);
                Assert.AreEqual("(67)", v.y);
                Assert.AreEqual("(67)", v.z);
                Assert.AreEqual("(42)", v.w);
            }
            {
                var ov = new gvec2<string>("(0-1)", null);
                var v = ov.swizzle.xxy;
                Assert.AreEqual("(0-1)", v.x);
                Assert.AreEqual("(0-1)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec2<string>("((91)0)", "((-40)-4)");
                var v = ov.swizzle.xxyx;
                Assert.AreEqual("((91)0)", v.x);
                Assert.AreEqual("((91)0)", v.y);
                Assert.AreEqual("((-40)-4)", v.z);
                Assert.AreEqual("((91)0)", v.w);
            }
            {
                var ov = new gvec2<string>("((4-4)-2)", "");
                var v = ov.swizzle.xxyy;
                Assert.AreEqual("((4-4)-2)", v.x);
                Assert.AreEqual("((4-4)-2)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec2<string>("((1-9)0)", "");
                var v = ov.swizzle.xy;
                Assert.AreEqual("((1-9)0)", v.x);
                Assert.AreEqual("", v.y);
            }
            {
                var ov = new gvec2<string>("((-5-1)0)", "((-5-1)0)");
                var v = ov.swizzle.xyx;
                Assert.AreEqual("((-5-1)0)", v.x);
                Assert.AreEqual("((-5-1)0)", v.y);
                Assert.AreEqual("((-5-1)0)", v.z);
            }
            {
                var ov = new gvec2<string>("1", "((4-8)-4)");
                var v = ov.swizzle.xyxx;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("((4-8)-4)", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec2<string>("(-5-8)", "((7-2)-7)");
                var v = ov.swizzle.xyxy;
                Assert.AreEqual("(-5-8)", v.x);
                Assert.AreEqual("((7-2)-7)", v.y);
                Assert.AreEqual("(-5-8)", v.z);
                Assert.AreEqual("((7-2)-7)", v.w);
            }
            {
                var ov = new gvec2<string>("2", "((61)-6)");
                var v = ov.swizzle.xyy;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("((61)-6)", v.y);
                Assert.AreEqual("((61)-6)", v.z);
            }
            {
                var ov = new gvec2<string>("((-1-5)-2)", "(-10)");
                var v = ov.swizzle.xyyx;
                Assert.AreEqual("((-1-5)-2)", v.x);
                Assert.AreEqual("(-10)", v.y);
                Assert.AreEqual("(-10)", v.z);
                Assert.AreEqual("((-1-5)-2)", v.w);
            }
            {
                var ov = new gvec2<string>("(-4-2)", "6");
                var v = ov.swizzle.xyyy;
                Assert.AreEqual("(-4-2)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("6", v.w);
            }
            {
                var ov = new gvec2<string>("7", "((-5-1)-4)");
                var v = ov.swizzle.yx;
                Assert.AreEqual("((-5-1)-4)", v.x);
                Assert.AreEqual("7", v.y);
            }
            {
                var ov = new gvec2<string>(null, null);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec2<string>("3", "-1");
                var v = ov.swizzle.yxxx;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec2<string>("5", "(8-1)");
                var v = ov.swizzle.yxxy;
                Assert.AreEqual("(8-1)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("(8-1)", v.w);
            }
            {
                var ov = new gvec2<string>("(4-5)", "(-5-7)");
                var v = ov.swizzle.yxy;
                Assert.AreEqual("(-5-7)", v.x);
                Assert.AreEqual("(4-5)", v.y);
                Assert.AreEqual("(-5-7)", v.z);
            }
            {
                var ov = new gvec2<string>("-2", "(-94)");
                var v = ov.swizzle.yxyx;
                Assert.AreEqual("(-94)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("(-94)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec2<string>("((-9-7)-3)", "-9");
                var v = ov.swizzle.yxyy;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((-9-7)-3)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec2<string>("-8", "((-22)-9)");
                var v = ov.swizzle.yy;
                Assert.AreEqual("((-22)-9)", v.x);
                Assert.AreEqual("((-22)-9)", v.y);
            }
            {
                var ov = new gvec2<string>("(46)", "(-9-2)");
                var v = ov.swizzle.yyx;
                Assert.AreEqual("(-9-2)", v.x);
                Assert.AreEqual("(-9-2)", v.y);
                Assert.AreEqual("(46)", v.z);
            }
            {
                var ov = new gvec2<string>("5", "(-51)");
                var v = ov.swizzle.yyxx;
                Assert.AreEqual("(-51)", v.x);
                Assert.AreEqual("(-51)", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec2<string>("", "(6-2)");
                var v = ov.swizzle.yyxy;
                Assert.AreEqual("(6-2)", v.x);
                Assert.AreEqual("(6-2)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(6-2)", v.w);
            }
            {
                var ov = new gvec2<string>("(-4-5)", "((17)3)");
                var v = ov.swizzle.yyy;
                Assert.AreEqual("((17)3)", v.x);
                Assert.AreEqual("((17)3)", v.y);
                Assert.AreEqual("((17)3)", v.z);
            }
            {
                var ov = new gvec2<string>(null, "0");
                var v = ov.swizzle.yyyx;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec2<string>("((5-9)-7)", "");
                var v = ov.swizzle.yyyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new gvec2<string>(null, "6");
                var v = ov.swizzle.rr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
            }
            {
                var ov = new gvec2<string>("((-7-7)-1)", "-3");
                var v = ov.swizzle.rrr;
                Assert.AreEqual("((-7-7)-1)", v.x);
                Assert.AreEqual("((-7-7)-1)", v.y);
                Assert.AreEqual("((-7-7)-1)", v.z);
            }
            {
                var ov = new gvec2<string>("3", "(-49)");
                var v = ov.swizzle.rrrr;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec2<string>(null, "0");
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec2<string>("-2", "6");
                var v = ov.swizzle.rrg;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("6", v.z);
            }
            {
                var ov = new gvec2<string>("8", "6");
                var v = ov.swizzle.rrgr;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec2<string>("(16)", "(-6-2)");
                var v = ov.swizzle.rrgg;
                Assert.AreEqual("(16)", v.x);
                Assert.AreEqual("(16)", v.y);
                Assert.AreEqual("(-6-2)", v.z);
                Assert.AreEqual("(-6-2)", v.w);
            }
            {
                var ov = new gvec2<string>(null, "-3");
                var v = ov.swizzle.rg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-3", v.y);
            }
            {
                var ov = new gvec2<string>("((-8-5)-2)", null);
                var v = ov.swizzle.rgr;
                Assert.AreEqual("((-8-5)-2)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-8-5)-2)", v.z);
            }
            {
                var ov = new gvec2<string>("((19)-6)", "1");
                var v = ov.swizzle.rgrr;
                Assert.AreEqual("((19)-6)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("((19)-6)", v.z);
                Assert.AreEqual("((19)-6)", v.w);
            }
            {
                var ov = new gvec2<string>("-4", "");
                var v = ov.swizzle.rgrg;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec2<string>("-7", null);
                var v = ov.swizzle.rgg;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec2<string>("((-73)1)", "");
                var v = ov.swizzle.rggr;
                Assert.AreEqual("((-73)1)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((-73)1)", v.w);
            }
            {
                var ov = new gvec2<string>("", "4");
                var v = ov.swizzle.rggg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("4", v.w);
            }
            {
                var ov = new gvec2<string>("(-10)", "-8");
                var v = ov.swizzle.gr;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("(-10)", v.y);
            }
            {
                var ov = new gvec2<string>("((-86)0)", "-6");
                var v = ov.swizzle.grr;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("((-86)0)", v.y);
                Assert.AreEqual("((-86)0)", v.z);
            }
            {
                var ov = new gvec2<string>(null, "((-97)8)");
                var v = ov.swizzle.grrr;
                Assert.AreEqual("((-97)8)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec2<string>("((-3-1)-4)", "5");
                var v = ov.swizzle.grrg;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("((-3-1)-4)", v.y);
                Assert.AreEqual("((-3-1)-4)", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec2<string>("(-7-8)", "9");
                var v = ov.swizzle.grg;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("(-7-8)", v.y);
                Assert.AreEqual("9", v.z);
            }
            {
                var ov = new gvec2<string>("(80)", "(80)");
                var v = ov.swizzle.grgr;
                Assert.AreEqual("(80)", v.x);
                Assert.AreEqual("(80)", v.y);
                Assert.AreEqual("(80)", v.z);
                Assert.AreEqual("(80)", v.w);
            }
            {
                var ov = new gvec2<string>("((54)-8)", "((54)-8)");
                var v = ov.swizzle.grgg;
                Assert.AreEqual("((54)-8)", v.x);
                Assert.AreEqual("((54)-8)", v.y);
                Assert.AreEqual("((54)-8)", v.z);
                Assert.AreEqual("((54)-8)", v.w);
            }
            {
                var ov = new gvec2<string>("", "-3");
                var v = ov.swizzle.gg;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
            }
            {
                var ov = new gvec2<string>("(-1-5)", "((2-9)-3)");
                var v = ov.swizzle.ggr;
                Assert.AreEqual("((2-9)-3)", v.x);
                Assert.AreEqual("((2-9)-3)", v.y);
                Assert.AreEqual("(-1-5)", v.z);
            }
            {
                var ov = new gvec2<string>("-9", "4");
                var v = ov.swizzle.ggrr;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec2<string>("(42)", null);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(42)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec2<string>("3", "(93)");
                var v = ov.swizzle.ggg;
                Assert.AreEqual("(93)", v.x);
                Assert.AreEqual("(93)", v.y);
                Assert.AreEqual("(93)", v.z);
            }
            {
                var ov = new gvec2<string>("((-6-3)1)", "((-6-3)1)");
                var v = ov.swizzle.gggr;
                Assert.AreEqual("((-6-3)1)", v.x);
                Assert.AreEqual("((-6-3)1)", v.y);
                Assert.AreEqual("((-6-3)1)", v.z);
                Assert.AreEqual("((-6-3)1)", v.w);
            }
            {
                var ov = new gvec2<string>("((-6-2)1)", "-7");
                var v = ov.swizzle.gggg;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("-7", v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new gvec2<string>("-3", "(60)");
                var v1 = new gvec2<string>("", null);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("", v0.x);
                Assert.AreEqual(null, v0.y);
            
                Assert.AreEqual("-3", v2.x);
                Assert.AreEqual("(60)", v2.y);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new gvec2<string>(null, null);
                var v1 = "8";
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("8", v0.x);
                Assert.AreEqual(null, v0.y);
            
                Assert.AreEqual(null, v2);
            }
            {
                var v0 = new gvec2<string>("(-82)", "(-97)");
                var v1 = "(37)";
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-82)", v0.x);
                Assert.AreEqual("(37)", v0.y);
            
                Assert.AreEqual("(-97)", v2);
            }
            {
                var v0 = new gvec2<string>("(-90)", "-1");
                var v1 = new gvec2<string>("(-2-6)", null);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-2-6)", v0.x);
                Assert.AreEqual(null, v0.y);
            
                Assert.AreEqual("(-90)", v2.x);
                Assert.AreEqual("-1", v2.y);
            }
        }

    }
}
