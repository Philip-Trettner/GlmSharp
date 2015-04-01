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
    public class TSwizzleVec4Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new gvec4<string>("(40)", null, "", "(40)");
                var v = ov.swizzle.xx;
                Assert.AreEqual("(40)", v.x);
                Assert.AreEqual("(40)", v.y);
            }
            {
                var ov = new gvec4<string>("", "-3", "", "(-17)");
                var v = ov.swizzle.xxx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("(07)", "(-71)", "((0-8)6)", "((0-8)6)");
                var v = ov.swizzle.xxxx;
                Assert.AreEqual("(07)", v.x);
                Assert.AreEqual("(07)", v.y);
                Assert.AreEqual("(07)", v.z);
                Assert.AreEqual("(07)", v.w);
            }
            {
                var ov = new gvec4<string>("((98)-1)", "(5-8)", "((98)-1)", "(-15)");
                var v = ov.swizzle.xxxy;
                Assert.AreEqual("((98)-1)", v.x);
                Assert.AreEqual("((98)-1)", v.y);
                Assert.AreEqual("((98)-1)", v.z);
                Assert.AreEqual("(5-8)", v.w);
            }
            {
                var ov = new gvec4<string>("0", "-8", "", "0");
                var v = ov.swizzle.xxxz;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("", "-9", "(-13)", "3");
                var v = ov.swizzle.xxxw;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("7", "6", "(-2-2)", "7");
                var v = ov.swizzle.xxy;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("6", v.z);
            }
            {
                var ov = new gvec4<string>("3", "(-1-3)", "-5", "((04)-6)");
                var v = ov.swizzle.xxyx;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("(-1-3)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("(6-3)", "(6-3)", "((12)-2)", "-7");
                var v = ov.swizzle.xxyy;
                Assert.AreEqual("(6-3)", v.x);
                Assert.AreEqual("(6-3)", v.y);
                Assert.AreEqual("(6-3)", v.z);
                Assert.AreEqual("(6-3)", v.w);
            }
            {
                var ov = new gvec4<string>("((-5-7)6)", "7", "(-7-2)", "7");
                var v = ov.swizzle.xxyz;
                Assert.AreEqual("((-5-7)6)", v.x);
                Assert.AreEqual("((-5-7)6)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("(-7-2)", v.w);
            }
            {
                var ov = new gvec4<string>("(-2-4)", "", "3", "");
                var v = ov.swizzle.xxyw;
                Assert.AreEqual("(-2-4)", v.x);
                Assert.AreEqual("(-2-4)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((-3-8)6)", "((83)-1)", null, "(-4-9)");
                var v = ov.swizzle.xxz;
                Assert.AreEqual("((-3-8)6)", v.x);
                Assert.AreEqual("((-3-8)6)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("((8-7)1)", "5", "9", "5");
                var v = ov.swizzle.xxzx;
                Assert.AreEqual("((8-7)1)", v.x);
                Assert.AreEqual("((8-7)1)", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("((8-7)1)", v.w);
            }
            {
                var ov = new gvec4<string>("0", "0", null, "0");
                var v = ov.swizzle.xxzy;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec4<string>("-3", null, "((-6-1)0)", "");
                var v = ov.swizzle.xxzz;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("((-6-1)0)", v.z);
                Assert.AreEqual("((-6-1)0)", v.w);
            }
            {
                var ov = new gvec4<string>("((-28)-2)", "((-28)-2)", "-9", "-9");
                var v = ov.swizzle.xxzw;
                Assert.AreEqual("((-28)-2)", v.x);
                Assert.AreEqual("((-28)-2)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>("(-2-5)", "(7-3)", "(-72)", null);
                var v = ov.swizzle.xxw;
                Assert.AreEqual("(-2-5)", v.x);
                Assert.AreEqual("(-2-5)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("(-6-7)", "(-6-7)", "2", "-6");
                var v = ov.swizzle.xxwx;
                Assert.AreEqual("(-6-7)", v.x);
                Assert.AreEqual("(-6-7)", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("(-6-7)", v.w);
            }
            {
                var ov = new gvec4<string>("((1-4)8)", "(6-6)", "((-4-2)1)", "6");
                var v = ov.swizzle.xxwy;
                Assert.AreEqual("((1-4)8)", v.x);
                Assert.AreEqual("((1-4)8)", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("(6-6)", v.w);
            }
            {
                var ov = new gvec4<string>("", "(7-4)", "((-1-9)1)", null);
                var v = ov.swizzle.xxwz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((-1-9)1)", v.w);
            }
            {
                var ov = new gvec4<string>("3", "7", "((01)-8)", "3");
                var v = ov.swizzle.xxww;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("(-97)", "", "-4", null);
                var v = ov.swizzle.xy;
                Assert.AreEqual("(-97)", v.x);
                Assert.AreEqual("", v.y);
            }
            {
                var ov = new gvec4<string>("9", "((32)-8)", "((40)-2)", "9");
                var v = ov.swizzle.xyx;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("((32)-8)", v.y);
                Assert.AreEqual("9", v.z);
            }
            {
                var ov = new gvec4<string>("((5-9)-4)", "(6-5)", "(-3-7)", "(-3-7)");
                var v = ov.swizzle.xyxx;
                Assert.AreEqual("((5-9)-4)", v.x);
                Assert.AreEqual("(6-5)", v.y);
                Assert.AreEqual("((5-9)-4)", v.z);
                Assert.AreEqual("((5-9)-4)", v.w);
            }
            {
                var ov = new gvec4<string>("-9", "(54)", "(70)", "-6");
                var v = ov.swizzle.xyxy;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("(54)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("(54)", v.w);
            }
            {
                var ov = new gvec4<string>("((73)-5)", "((-33)-7)", "-8", "(-7-7)");
                var v = ov.swizzle.xyxz;
                Assert.AreEqual("((73)-5)", v.x);
                Assert.AreEqual("((-33)-7)", v.y);
                Assert.AreEqual("((73)-5)", v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec4<string>("-6", "(11)", "(11)", "((8-8)2)");
                var v = ov.swizzle.xyxw;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("(11)", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("((8-8)2)", v.w);
            }
            {
                var ov = new gvec4<string>("-8", "(4-5)", "(-93)", "((-89)0)");
                var v = ov.swizzle.xyy;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("(4-5)", v.y);
                Assert.AreEqual("(4-5)", v.z);
            }
            {
                var ov = new gvec4<string>("-3", "2", "(-1-8)", "(-7-9)");
                var v = ov.swizzle.xyyx;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("(-2-2)", "(-11)", null, "(-11)");
                var v = ov.swizzle.xyyy;
                Assert.AreEqual("(-2-2)", v.x);
                Assert.AreEqual("(-11)", v.y);
                Assert.AreEqual("(-11)", v.z);
                Assert.AreEqual("(-11)", v.w);
            }
            {
                var ov = new gvec4<string>("-5", "(2-4)", null, null);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("(2-4)", v.y);
                Assert.AreEqual("(2-4)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("", "(18)", "", "-8");
                var v = ov.swizzle.xyyw;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(18)", v.y);
                Assert.AreEqual("(18)", v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec4<string>("-2", "0", "(7-7)", "((7-1)0)");
                var v = ov.swizzle.xyz;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("(7-7)", v.z);
            }
            {
                var ov = new gvec4<string>("((54)-5)", "(-68)", "3", "(-23)");
                var v = ov.swizzle.xyzx;
                Assert.AreEqual("((54)-5)", v.x);
                Assert.AreEqual("(-68)", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("((54)-5)", v.w);
            }
            {
                var ov = new gvec4<string>("((33)-7)", "7", "1", "-3");
                var v = ov.swizzle.xyzy;
                Assert.AreEqual("((33)-7)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec4<string>("2", null, "(80)", "2");
                var v = ov.swizzle.xyzz;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(80)", v.z);
                Assert.AreEqual("(80)", v.w);
            }
            {
                var ov = new gvec4<string>("((-66)0)", null, null, null);
                var v = ov.swizzle.xyzw;
                Assert.AreEqual("((-66)0)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((8-7)4)", "-9", "-9", "((8-7)4)");
                var v = ov.swizzle.xyw;
                Assert.AreEqual("((8-7)4)", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("((8-7)4)", v.z);
            }
            {
                var ov = new gvec4<string>("(96)", "((88)5)", "((-80)6)", "((48)7)");
                var v = ov.swizzle.xywx;
                Assert.AreEqual("(96)", v.x);
                Assert.AreEqual("((88)5)", v.y);
                Assert.AreEqual("((48)7)", v.z);
                Assert.AreEqual("(96)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "-2", "((7-1)7)", "((55)-2)");
                var v = ov.swizzle.xywy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("((55)-2)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec4<string>("", "-9", "(-2-9)", "");
                var v = ov.swizzle.xywz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-2-9)", v.w);
            }
            {
                var ov = new gvec4<string>("(9-7)", "(7-4)", "((45)1)", "((45)1)");
                var v = ov.swizzle.xyww;
                Assert.AreEqual("(9-7)", v.x);
                Assert.AreEqual("(7-4)", v.y);
                Assert.AreEqual("((45)1)", v.z);
                Assert.AreEqual("((45)1)", v.w);
            }
            {
                var ov = new gvec4<string>("6", "((-17)6)", "((8-8)-7)", "(3-2)");
                var v = ov.swizzle.xz;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("((8-8)-7)", v.y);
            }
            {
                var ov = new gvec4<string>("((-5-4)-8)", "((-9-4)-4)", "", "((-1-8)1)");
                var v = ov.swizzle.xzx;
                Assert.AreEqual("((-5-4)-8)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-5-4)-8)", v.z);
            }
            {
                var ov = new gvec4<string>(null, "3", null, "-1");
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("(5-1)", "", "(-44)", "1");
                var v = ov.swizzle.xzxy;
                Assert.AreEqual("(5-1)", v.x);
                Assert.AreEqual("(-44)", v.y);
                Assert.AreEqual("(5-1)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(7-3)", "((-27)-7)", "8", "3");
                var v = ov.swizzle.xzxz;
                Assert.AreEqual("(7-3)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("(7-3)", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("(-9-1)", null, "(1-3)", "(-9-1)");
                var v = ov.swizzle.xzxw;
                Assert.AreEqual("(-9-1)", v.x);
                Assert.AreEqual("(1-3)", v.y);
                Assert.AreEqual("(-9-1)", v.z);
                Assert.AreEqual("(-9-1)", v.w);
            }
            {
                var ov = new gvec4<string>("", "(-69)", "((5-1)9)", "-5");
                var v = ov.swizzle.xzy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((5-1)9)", v.y);
                Assert.AreEqual("(-69)", v.z);
            }
            {
                var ov = new gvec4<string>("(-6-4)", "(-8-4)", "((45)-2)", "((7-2)9)");
                var v = ov.swizzle.xzyx;
                Assert.AreEqual("(-6-4)", v.x);
                Assert.AreEqual("((45)-2)", v.y);
                Assert.AreEqual("(-8-4)", v.z);
                Assert.AreEqual("(-6-4)", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "", "-8", "-5");
                var v = ov.swizzle.xzyy;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(44)", "6", "-5", "(44)");
                var v = ov.swizzle.xzyz;
                Assert.AreEqual("(44)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("(45)", "((47)2)", "4", "(-5-6)");
                var v = ov.swizzle.xzyw;
                Assert.AreEqual("(45)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("((47)2)", v.z);
                Assert.AreEqual("(-5-6)", v.w);
            }
            {
                var ov = new gvec4<string>("0", "((70)-9)", "-6", "((70)-9)");
                var v = ov.swizzle.xzz;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
            }
            {
                var ov = new gvec4<string>("", "(8-3)", "((-5-6)-4)", "((6-5)-2)");
                var v = ov.swizzle.xzzx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-5-6)-4)", v.y);
                Assert.AreEqual("((-5-6)-4)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(-88)", "", "(9-9)", "(-24)");
                var v = ov.swizzle.xzzy;
                Assert.AreEqual("(-88)", v.x);
                Assert.AreEqual("(9-9)", v.y);
                Assert.AreEqual("(9-9)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(11)", null, "1", null);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual("(11)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec4<string>("(-5-5)", "((8-3)4)", "((8-3)4)", "(-7-5)");
                var v = ov.swizzle.xzzw;
                Assert.AreEqual("(-5-5)", v.x);
                Assert.AreEqual("((8-3)4)", v.y);
                Assert.AreEqual("((8-3)4)", v.z);
                Assert.AreEqual("(-7-5)", v.w);
            }
            {
                var ov = new gvec4<string>("(1-9)", null, "((-92)-7)", "((41)-7)");
                var v = ov.swizzle.xzw;
                Assert.AreEqual("(1-9)", v.x);
                Assert.AreEqual("((-92)-7)", v.y);
                Assert.AreEqual("((41)-7)", v.z);
            }
            {
                var ov = new gvec4<string>("(-6-7)", "(-6-7)", "4", "(2-3)");
                var v = ov.swizzle.xzwx;
                Assert.AreEqual("(-6-7)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("(2-3)", v.z);
                Assert.AreEqual("(-6-7)", v.w);
            }
            {
                var ov = new gvec4<string>("-3", "-3", "-3", "1");
                var v = ov.swizzle.xzwy;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("((92)6)", "(6-4)", "7", "");
                var v = ov.swizzle.xzwz;
                Assert.AreEqual("((92)6)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec4<string>("-6", "((-92)9)", "", "(38)");
                var v = ov.swizzle.xzww;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(38)", v.z);
                Assert.AreEqual("(38)", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "1", "((21)-3)", "((1-8)-4)");
                var v = ov.swizzle.xw;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("((1-8)-4)", v.y);
            }
            {
                var ov = new gvec4<string>("(54)", null, "", "((-23)-3)");
                var v = ov.swizzle.xwx;
                Assert.AreEqual("(54)", v.x);
                Assert.AreEqual("((-23)-3)", v.y);
                Assert.AreEqual("(54)", v.z);
            }
            {
                var ov = new gvec4<string>("(1-4)", "((13)-2)", null, "(30)");
                var v = ov.swizzle.xwxx;
                Assert.AreEqual("(1-4)", v.x);
                Assert.AreEqual("(30)", v.y);
                Assert.AreEqual("(1-4)", v.z);
                Assert.AreEqual("(1-4)", v.w);
            }
            {
                var ov = new gvec4<string>("-6", "-4", "(-86)", null);
                var v = ov.swizzle.xwxy;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-4", v.w);
            }
            {
                var ov = new gvec4<string>("(-9-1)", "6", "(-34)", null);
                var v = ov.swizzle.xwxz;
                Assert.AreEqual("(-9-1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-9-1)", v.z);
                Assert.AreEqual("(-34)", v.w);
            }
            {
                var ov = new gvec4<string>("((-6-3)-4)", "((-6-3)-4)", "(64)", "");
                var v = ov.swizzle.xwxw;
                Assert.AreEqual("((-6-3)-4)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-6-3)-4)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(4-8)", "(-2-1)", null, null);
                var v = ov.swizzle.xwy;
                Assert.AreEqual("(4-8)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-2-1)", v.z);
            }
            {
                var ov = new gvec4<string>("((-8-5)1)", "(-63)", "(-31)", "(-63)");
                var v = ov.swizzle.xwyx;
                Assert.AreEqual("((-8-5)1)", v.x);
                Assert.AreEqual("(-63)", v.y);
                Assert.AreEqual("(-63)", v.z);
                Assert.AreEqual("((-8-5)1)", v.w);
            }
            {
                var ov = new gvec4<string>("(0-7)", "(-4-9)", "1", "3");
                var v = ov.swizzle.xwyy;
                Assert.AreEqual("(0-7)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("(-4-9)", v.z);
                Assert.AreEqual("(-4-9)", v.w);
            }
            {
                var ov = new gvec4<string>("(2-9)", "9", null, "-1");
                var v = ov.swizzle.xwyz;
                Assert.AreEqual("(2-9)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("-8", "((19)-6)", "-8", "((72)3)");
                var v = ov.swizzle.xwyw;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("((72)3)", v.y);
                Assert.AreEqual("((19)-6)", v.z);
                Assert.AreEqual("((72)3)", v.w);
            }
            {
                var ov = new gvec4<string>("(-73)", "", "((-17)-3)", "");
                var v = ov.swizzle.xwz;
                Assert.AreEqual("(-73)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-17)-3)", v.z);
            }
            {
                var ov = new gvec4<string>("(-1-5)", "(-1-5)", "", "((5-5)9)");
                var v = ov.swizzle.xwzx;
                Assert.AreEqual("(-1-5)", v.x);
                Assert.AreEqual("((5-5)9)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-1-5)", v.w);
            }
            {
                var ov = new gvec4<string>("((-8-6)2)", "((-8-6)2)", "2", null);
                var v = ov.swizzle.xwzy;
                Assert.AreEqual("((-8-6)2)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("((-8-6)2)", v.w);
            }
            {
                var ov = new gvec4<string>("((9-8)-7)", "((9-8)-7)", null, "((0-3)7)");
                var v = ov.swizzle.xwzz;
                Assert.AreEqual("((9-8)-7)", v.x);
                Assert.AreEqual("((0-3)7)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((-59)3)", "8", "8", "((-52)7)");
                var v = ov.swizzle.xwzw;
                Assert.AreEqual("((-59)3)", v.x);
                Assert.AreEqual("((-52)7)", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("((-52)7)", v.w);
            }
            {
                var ov = new gvec4<string>("((-14)-1)", null, "((-97)-4)", "1");
                var v = ov.swizzle.xww;
                Assert.AreEqual("((-14)-1)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("1", v.z);
            }
            {
                var ov = new gvec4<string>("-3", "(-5-8)", "(-7-9)", "-3");
                var v = ov.swizzle.xwwx;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("", "((8-4)-6)", "((-83)2)", "(09)");
                var v = ov.swizzle.xwwy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(09)", v.y);
                Assert.AreEqual("(09)", v.z);
                Assert.AreEqual("((8-4)-6)", v.w);
            }
            {
                var ov = new gvec4<string>("((0-6)-7)", "((7-9)7)", "(9-7)", "((5-1)-8)");
                var v = ov.swizzle.xwwz;
                Assert.AreEqual("((0-6)-7)", v.x);
                Assert.AreEqual("((5-1)-8)", v.y);
                Assert.AreEqual("((5-1)-8)", v.z);
                Assert.AreEqual("(9-7)", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "(17)", "(17)", "(3-1)");
                var v = ov.swizzle.xwww;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("(3-1)", v.y);
                Assert.AreEqual("(3-1)", v.z);
                Assert.AreEqual("(3-1)", v.w);
            }
            {
                var ov = new gvec4<string>("4", "4", "((9-9)-6)", "(40)");
                var v = ov.swizzle.yx;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
            }
            {
                var ov = new gvec4<string>("5", "", "(5-9)", null);
                var v = ov.swizzle.yxx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
            }
            {
                var ov = new gvec4<string>("(-7-5)", "((-56)-1)", "", "3");
                var v = ov.swizzle.yxxx;
                Assert.AreEqual("((-56)-1)", v.x);
                Assert.AreEqual("(-7-5)", v.y);
                Assert.AreEqual("(-7-5)", v.z);
                Assert.AreEqual("(-7-5)", v.w);
            }
            {
                var ov = new gvec4<string>("", "-9", "9", "");
                var v = ov.swizzle.yxxy;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>("((3-7)-4)", "-5", "((3-7)-4)", "-5");
                var v = ov.swizzle.yxxz;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("((3-7)-4)", v.y);
                Assert.AreEqual("((3-7)-4)", v.z);
                Assert.AreEqual("((3-7)-4)", v.w);
            }
            {
                var ov = new gvec4<string>("-8", "-1", null, "2");
                var v = ov.swizzle.yxxw;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec4<string>("((-18)-5)", "(-9-7)", "(-7-5)", "2");
                var v = ov.swizzle.yxy;
                Assert.AreEqual("(-9-7)", v.x);
                Assert.AreEqual("((-18)-5)", v.y);
                Assert.AreEqual("(-9-7)", v.z);
            }
            {
                var ov = new gvec4<string>("3", "((-89)-7)", "((-21)2)", "0");
                var v = ov.swizzle.yxyx;
                Assert.AreEqual("((-89)-7)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("((-89)-7)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("((3-2)-8)", "(47)", "(47)", "2");
                var v = ov.swizzle.yxyy;
                Assert.AreEqual("(47)", v.x);
                Assert.AreEqual("((3-2)-8)", v.y);
                Assert.AreEqual("(47)", v.z);
                Assert.AreEqual("(47)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "(96)", "(46)", "(-5-9)");
                var v = ov.swizzle.yxyz;
                Assert.AreEqual("(96)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(96)", v.z);
                Assert.AreEqual("(46)", v.w);
            }
            {
                var ov = new gvec4<string>("", "", "-6", "((62)9)");
                var v = ov.swizzle.yxyw;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((62)9)", v.w);
            }
            {
                var ov = new gvec4<string>("((1-7)3)", "9", "((-5-4)5)", "((-5-4)5)");
                var v = ov.swizzle.yxz;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("((1-7)3)", v.y);
                Assert.AreEqual("((-5-4)5)", v.z);
            }
            {
                var ov = new gvec4<string>("7", "(7-8)", "(7-8)", "(-2-4)");
                var v = ov.swizzle.yxzx;
                Assert.AreEqual("(7-8)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("(7-8)", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec4<string>("(-1-4)", "-7", null, "-4");
                var v = ov.swizzle.yxzy;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(-1-4)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec4<string>("((5-9)-9)", "(28)", "0", "((-1-7)-5)");
                var v = ov.swizzle.yxzz;
                Assert.AreEqual("(28)", v.x);
                Assert.AreEqual("((5-9)-9)", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec4<string>("(-8-1)", "(-5-9)", "", "((24)1)");
                var v = ov.swizzle.yxzw;
                Assert.AreEqual("(-5-9)", v.x);
                Assert.AreEqual("(-8-1)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((24)1)", v.w);
            }
            {
                var ov = new gvec4<string>("((4-5)5)", null, "-7", "(-6-9)");
                var v = ov.swizzle.yxw;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((4-5)5)", v.y);
                Assert.AreEqual("(-6-9)", v.z);
            }
            {
                var ov = new gvec4<string>("", "-5", "(-87)", null);
                var v = ov.swizzle.yxwx;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("-3", "((12)-6)", "((-3-8)6)", "(-3-7)");
                var v = ov.swizzle.yxwy;
                Assert.AreEqual("((12)-6)", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("(-3-7)", v.z);
                Assert.AreEqual("((12)-6)", v.w);
            }
            {
                var ov = new gvec4<string>("((5-9)-8)", "-1", "((5-2)-4)", "-9");
                var v = ov.swizzle.yxwz;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("((5-9)-8)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("((5-2)-4)", v.w);
            }
            {
                var ov = new gvec4<string>("(2-1)", "1", "", "(-16)");
                var v = ov.swizzle.yxww;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("(2-1)", v.y);
                Assert.AreEqual("(-16)", v.z);
                Assert.AreEqual("(-16)", v.w);
            }
            {
                var ov = new gvec4<string>("(16)", "4", "(16)", null);
                var v = ov.swizzle.yy;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
            }
            {
                var ov = new gvec4<string>("((9-4)-6)", "((42)1)", "-3", "((8-2)5)");
                var v = ov.swizzle.yyx;
                Assert.AreEqual("((42)1)", v.x);
                Assert.AreEqual("((42)1)", v.y);
                Assert.AreEqual("((9-4)-6)", v.z);
            }
            {
                var ov = new gvec4<string>("", "((-95)4)", "((-95)4)", "((21)-1)");
                var v = ov.swizzle.yyxx;
                Assert.AreEqual("((-95)4)", v.x);
                Assert.AreEqual("((-95)4)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("7", "", "(0-5)", "");
                var v = ov.swizzle.yyxy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((-87)2)", "(-6-1)", "", "((-7-8)8)");
                var v = ov.swizzle.yyxz;
                Assert.AreEqual("(-6-1)", v.x);
                Assert.AreEqual("(-6-1)", v.y);
                Assert.AreEqual("((-87)2)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("", null, "(06)", "");
                var v = ov.swizzle.yyxw;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(52)", "4", "((-54)7)", "((-50)6)");
                var v = ov.swizzle.yyy;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
            }
            {
                var ov = new gvec4<string>("(19)", "(19)", "((-6-6)2)", "-2");
                var v = ov.swizzle.yyyx;
                Assert.AreEqual("(19)", v.x);
                Assert.AreEqual("(19)", v.y);
                Assert.AreEqual("(19)", v.z);
                Assert.AreEqual("(19)", v.w);
            }
            {
                var ov = new gvec4<string>("(-8-6)", null, "(-8-6)", "(-4-3)");
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("(-5-7)", "8", "((94)1)", "(-5-7)");
                var v = ov.swizzle.yyyz;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("((94)1)", v.w);
            }
            {
                var ov = new gvec4<string>("5", "((78)-1)", "((78)-1)", "(-6-4)");
                var v = ov.swizzle.yyyw;
                Assert.AreEqual("((78)-1)", v.x);
                Assert.AreEqual("((78)-1)", v.y);
                Assert.AreEqual("((78)-1)", v.z);
                Assert.AreEqual("(-6-4)", v.w);
            }
            {
                var ov = new gvec4<string>("7", "(-9-5)", "(-9-5)", "(-9-5)");
                var v = ov.swizzle.yyz;
                Assert.AreEqual("(-9-5)", v.x);
                Assert.AreEqual("(-9-5)", v.y);
                Assert.AreEqual("(-9-5)", v.z);
            }
            {
                var ov = new gvec4<string>("((0-7)5)", "", "(78)", "((0-7)5)");
                var v = ov.swizzle.yyzx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(78)", v.z);
                Assert.AreEqual("((0-7)5)", v.w);
            }
            {
                var ov = new gvec4<string>("-7", "(19)", "-3", "");
                var v = ov.swizzle.yyzy;
                Assert.AreEqual("(19)", v.x);
                Assert.AreEqual("(19)", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("(19)", v.w);
            }
            {
                var ov = new gvec4<string>("(1-3)", "((-50)-9)", "(7-1)", null);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual("((-50)-9)", v.x);
                Assert.AreEqual("((-50)-9)", v.y);
                Assert.AreEqual("(7-1)", v.z);
                Assert.AreEqual("(7-1)", v.w);
            }
            {
                var ov = new gvec4<string>("(-4-5)", "-2", "(7-2)", "(7-2)");
                var v = ov.swizzle.yyzw;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("(7-2)", v.z);
                Assert.AreEqual("(7-2)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "4", "-2", "-1");
                var v = ov.swizzle.yyw;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("-1", v.z);
            }
            {
                var ov = new gvec4<string>("(18)", "((-1-6)-4)", "((20)-1)", "(18)");
                var v = ov.swizzle.yywx;
                Assert.AreEqual("((-1-6)-4)", v.x);
                Assert.AreEqual("((-1-6)-4)", v.y);
                Assert.AreEqual("(18)", v.z);
                Assert.AreEqual("(18)", v.w);
            }
            {
                var ov = new gvec4<string>("(2-1)", "(-23)", "((-68)1)", "(2-1)");
                var v = ov.swizzle.yywy;
                Assert.AreEqual("(-23)", v.x);
                Assert.AreEqual("(-23)", v.y);
                Assert.AreEqual("(2-1)", v.z);
                Assert.AreEqual("(-23)", v.w);
            }
            {
                var ov = new gvec4<string>("5", "(6-9)", "((-30)4)", "(6-9)");
                var v = ov.swizzle.yywz;
                Assert.AreEqual("(6-9)", v.x);
                Assert.AreEqual("(6-9)", v.y);
                Assert.AreEqual("(6-9)", v.z);
                Assert.AreEqual("((-30)4)", v.w);
            }
            {
                var ov = new gvec4<string>("", "", "(39)", "-6");
                var v = ov.swizzle.yyww;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec4<string>("(-12)", "-9", "", "((-29)8)");
                var v = ov.swizzle.yz;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("", v.y);
            }
            {
                var ov = new gvec4<string>("0", "-2", "((-9-1)-1)", "((-9-1)-1)");
                var v = ov.swizzle.yzx;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("((-9-1)-1)", v.y);
                Assert.AreEqual("0", v.z);
            }
            {
                var ov = new gvec4<string>("((-81)-9)", "3", "((-21)0)", null);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("((-21)0)", v.y);
                Assert.AreEqual("((-81)-9)", v.z);
                Assert.AreEqual("((-81)-9)", v.w);
            }
            {
                var ov = new gvec4<string>("(-2-5)", "-9", "(-2-5)", "");
                var v = ov.swizzle.yzxy;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("(-2-5)", v.y);
                Assert.AreEqual("(-2-5)", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "9", "-1", "((-32)-2)");
                var v = ov.swizzle.yzxz;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec4<string>("-6", "((-7-4)-5)", null, "0");
                var v = ov.swizzle.yzxw;
                Assert.AreEqual("((-7-4)-5)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec4<string>("((-78)-8)", "", "-8", "((6-1)2)");
                var v = ov.swizzle.yzy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("1", null, "1", "((-60)-4)");
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec4<string>("((-7-3)-1)", "((-7-2)9)", "-1", "((-7-3)-1)");
                var v = ov.swizzle.yzyy;
                Assert.AreEqual("((-7-2)9)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("((-7-2)9)", v.z);
                Assert.AreEqual("((-7-2)9)", v.w);
            }
            {
                var ov = new gvec4<string>("(47)", "((-99)-2)", "3", "-7");
                var v = ov.swizzle.yzyz;
                Assert.AreEqual("((-99)-2)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("((-99)-2)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("4", "((8-7)-3)", "-4", "((8-7)-3)");
                var v = ov.swizzle.yzyw;
                Assert.AreEqual("((8-7)-3)", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("((8-7)-3)", v.z);
                Assert.AreEqual("((8-7)-3)", v.w);
            }
            {
                var ov = new gvec4<string>("(80)", "((0-4)4)", "(80)", "-3");
                var v = ov.swizzle.yzz;
                Assert.AreEqual("((0-4)4)", v.x);
                Assert.AreEqual("(80)", v.y);
                Assert.AreEqual("(80)", v.z);
            }
            {
                var ov = new gvec4<string>("-3", "", "", "-3");
                var v = ov.swizzle.yzzx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("(9-7)", "(9-7)", "-7", "(0-1)");
                var v = ov.swizzle.yzzy;
                Assert.AreEqual("(9-7)", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("(9-7)", v.w);
            }
            {
                var ov = new gvec4<string>("((-8-7)-6)", "", "8", "(-24)");
                var v = ov.swizzle.yzzz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>(null, "(56)", "8", "(56)");
                var v = ov.swizzle.yzzw;
                Assert.AreEqual("(56)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("(56)", v.w);
            }
            {
                var ov = new gvec4<string>("((-26)-5)", "", "((-26)-5)", "(80)");
                var v = ov.swizzle.yzw;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-26)-5)", v.y);
                Assert.AreEqual("(80)", v.z);
            }
            {
                var ov = new gvec4<string>("(-64)", "4", "(01)", "(-64)");
                var v = ov.swizzle.yzwx;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("(01)", v.y);
                Assert.AreEqual("(-64)", v.z);
                Assert.AreEqual("(-64)", v.w);
            }
            {
                var ov = new gvec4<string>("(56)", "-5", "-4", "(56)");
                var v = ov.swizzle.yzwy;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("(56)", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("", "(-9-3)", "(-9-3)", "");
                var v = ov.swizzle.yzwz;
                Assert.AreEqual("(-9-3)", v.x);
                Assert.AreEqual("(-9-3)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-9-3)", v.w);
            }
            {
                var ov = new gvec4<string>("", "(-33)", "(14)", "-6");
                var v = ov.swizzle.yzww;
                Assert.AreEqual("(-33)", v.x);
                Assert.AreEqual("(14)", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec4<string>("-1", "", "((6-3)-8)", "((6-3)-8)");
                var v = ov.swizzle.yw;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((6-3)-8)", v.y);
            }
            {
                var ov = new gvec4<string>("9", "((4-6)-3)", "((1-8)-6)", null);
                var v = ov.swizzle.ywx;
                Assert.AreEqual("((4-6)-3)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("9", v.z);
            }
            {
                var ov = new gvec4<string>(null, "2", null, "9");
                var v = ov.swizzle.ywxx;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((1-7)-5)", "8", "((1-7)-5)", "(2-2)");
                var v = ov.swizzle.ywxy;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("(2-2)", v.y);
                Assert.AreEqual("((1-7)-5)", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("8", "((-31)-3)", "((-31)-3)", null);
                var v = ov.swizzle.ywxz;
                Assert.AreEqual("((-31)-3)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("((-31)-3)", v.w);
            }
            {
                var ov = new gvec4<string>("-1", "((-4-2)6)", "9", "(-39)");
                var v = ov.swizzle.ywxw;
                Assert.AreEqual("((-4-2)6)", v.x);
                Assert.AreEqual("(-39)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("(-39)", v.w);
            }
            {
                var ov = new gvec4<string>("((-5-8)5)", "((42)-9)", "(6-5)", "-7");
                var v = ov.swizzle.ywy;
                Assert.AreEqual("((42)-9)", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("((42)-9)", v.z);
            }
            {
                var ov = new gvec4<string>("(2-9)", "((39)-7)", "(2-9)", "(-39)");
                var v = ov.swizzle.ywyx;
                Assert.AreEqual("((39)-7)", v.x);
                Assert.AreEqual("(-39)", v.y);
                Assert.AreEqual("((39)-7)", v.z);
                Assert.AreEqual("(2-9)", v.w);
            }
            {
                var ov = new gvec4<string>("-5", "((-2-2)-5)", "(18)", "-5");
                var v = ov.swizzle.ywyy;
                Assert.AreEqual("((-2-2)-5)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("((-2-2)-5)", v.z);
                Assert.AreEqual("((-2-2)-5)", v.w);
            }
            {
                var ov = new gvec4<string>("0", null, "((74)9)", "((92)6)");
                var v = ov.swizzle.ywyz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((92)6)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((74)9)", v.w);
            }
            {
                var ov = new gvec4<string>("8", "(8-8)", "-4", "((-86)0)");
                var v = ov.swizzle.ywyw;
                Assert.AreEqual("(8-8)", v.x);
                Assert.AreEqual("((-86)0)", v.y);
                Assert.AreEqual("(8-8)", v.z);
                Assert.AreEqual("((-86)0)", v.w);
            }
            {
                var ov = new gvec4<string>("5", "((-66)-7)", "((-66)-7)", "5");
                var v = ov.swizzle.ywz;
                Assert.AreEqual("((-66)-7)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("((-66)-7)", v.z);
            }
            {
                var ov = new gvec4<string>("-7", "0", null, "((-68)5)");
                var v = ov.swizzle.ywzx;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("((-68)5)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec4<string>("((3-7)-8)", "((-65)-2)", "-4", "(81)");
                var v = ov.swizzle.ywzy;
                Assert.AreEqual("((-65)-2)", v.x);
                Assert.AreEqual("(81)", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("((-65)-2)", v.w);
            }
            {
                var ov = new gvec4<string>("-9", "(36)", "-9", "(08)");
                var v = ov.swizzle.ywzz;
                Assert.AreEqual("(36)", v.x);
                Assert.AreEqual("(08)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>("3", null, "((0-2)-5)", "");
                var v = ov.swizzle.ywzw;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((0-2)-5)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(-20)", "(8-1)", null, null);
                var v = ov.swizzle.yww;
                Assert.AreEqual("(8-1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("(-60)", "-7", "-8", "((-33)-4)");
                var v = ov.swizzle.ywwx;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("((-33)-4)", v.y);
                Assert.AreEqual("((-33)-4)", v.z);
                Assert.AreEqual("(-60)", v.w);
            }
            {
                var ov = new gvec4<string>("((-8-2)7)", "-1", "(66)", null);
                var v = ov.swizzle.ywwy;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec4<string>("(-45)", "((51)9)", "-6", "-2");
                var v = ov.swizzle.ywwz;
                Assert.AreEqual("((51)9)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec4<string>("(46)", "((52)3)", null, "(-83)");
                var v = ov.swizzle.ywww;
                Assert.AreEqual("((52)3)", v.x);
                Assert.AreEqual("(-83)", v.y);
                Assert.AreEqual("(-83)", v.z);
                Assert.AreEqual("(-83)", v.w);
            }
            {
                var ov = new gvec4<string>("((-11)4)", "9", "(-9-7)", "(-9-3)");
                var v = ov.swizzle.zx;
                Assert.AreEqual("(-9-7)", v.x);
                Assert.AreEqual("((-11)4)", v.y);
            }
            {
                var ov = new gvec4<string>("(2-9)", "((72)-5)", "(2-9)", "((-13)0)");
                var v = ov.swizzle.zxx;
                Assert.AreEqual("(2-9)", v.x);
                Assert.AreEqual("(2-9)", v.y);
                Assert.AreEqual("(2-9)", v.z);
            }
            {
                var ov = new gvec4<string>("(60)", "((1-9)3)", null, null);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(60)", v.y);
                Assert.AreEqual("(60)", v.z);
                Assert.AreEqual("(60)", v.w);
            }
            {
                var ov = new gvec4<string>("2", null, "2", "((-86)-5)");
                var v = ov.swizzle.zxxy;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("2", "2", "1", "((18)0)");
                var v = ov.swizzle.zxxz;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec4<string>("(-78)", "((-41)0)", "6", "(-4-4)");
                var v = ov.swizzle.zxxw;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("(-78)", v.y);
                Assert.AreEqual("(-78)", v.z);
                Assert.AreEqual("(-4-4)", v.w);
            }
            {
                var ov = new gvec4<string>("3", "(33)", "((-4-9)2)", "((53)-4)");
                var v = ov.swizzle.zxy;
                Assert.AreEqual("((-4-9)2)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("(33)", v.z);
            }
            {
                var ov = new gvec4<string>("0", "2", "", "4");
                var v = ov.swizzle.zxyx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec4<string>("((-8-8)9)", "((-8-8)9)", "((-8-8)9)", "8");
                var v = ov.swizzle.zxyy;
                Assert.AreEqual("((-8-8)9)", v.x);
                Assert.AreEqual("((-8-8)9)", v.y);
                Assert.AreEqual("((-8-8)9)", v.z);
                Assert.AreEqual("((-8-8)9)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "", "2", "((29)0)");
                var v = ov.swizzle.zxyz;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec4<string>("8", "-9", "(32)", "8");
                var v = ov.swizzle.zxyw;
                Assert.AreEqual("(32)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("(-4-3)", "0", null, null);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-4-3)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("", "((57)2)", "(7-9)", "(7-9)");
                var v = ov.swizzle.zxzx;
                Assert.AreEqual("(7-9)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(7-9)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "-8", "(-99)", "(-71)");
                var v = ov.swizzle.zxzy;
                Assert.AreEqual("(-99)", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("(-99)", v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec4<string>("((53)8)", "-3", "-3", "-3");
                var v = ov.swizzle.zxzz;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("((53)8)", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("((3-1)9)", "((2-9)2)", "8", "");
                var v = ov.swizzle.zxzw;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("((3-1)9)", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((92)-3)", "((77)9)", "((-1-5)1)", "");
                var v = ov.swizzle.zxw;
                Assert.AreEqual("((-1-5)1)", v.x);
                Assert.AreEqual("((92)-3)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("(-6-9)", "((90)-9)", "-9", "");
                var v = ov.swizzle.zxwx;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("(-6-9)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-6-9)", v.w);
            }
            {
                var ov = new gvec4<string>("((41)-6)", "((1-8)3)", "((6-5)-2)", "6");
                var v = ov.swizzle.zxwy;
                Assert.AreEqual("((6-5)-2)", v.x);
                Assert.AreEqual("((41)-6)", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("((1-8)3)", v.w);
            }
            {
                var ov = new gvec4<string>("(-16)", "(-16)", "2", "");
                var v = ov.swizzle.zxwz;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("(-16)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec4<string>("(4-6)", "(-8-5)", "-4", "((-67)-8)");
                var v = ov.swizzle.zxww;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("(4-6)", v.y);
                Assert.AreEqual("((-67)-8)", v.z);
                Assert.AreEqual("((-67)-8)", v.w);
            }
            {
                var ov = new gvec4<string>("-3", null, "(31)", "");
                var v = ov.swizzle.zy;
                Assert.AreEqual("(31)", v.x);
                Assert.AreEqual(null, v.y);
            }
            {
                var ov = new gvec4<string>("(63)", "9", "-1", null);
                var v = ov.swizzle.zyx;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("(63)", v.z);
            }
            {
                var ov = new gvec4<string>("-3", "((0-9)7)", "(-3-7)", "(6-2)");
                var v = ov.swizzle.zyxx;
                Assert.AreEqual("(-3-7)", v.x);
                Assert.AreEqual("((0-9)7)", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("", "((56)8)", null, "((56)8)");
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((56)8)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((56)8)", v.w);
            }
            {
                var ov = new gvec4<string>("(07)", "(-33)", "(81)", "(-33)");
                var v = ov.swizzle.zyxz;
                Assert.AreEqual("(81)", v.x);
                Assert.AreEqual("(-33)", v.y);
                Assert.AreEqual("(07)", v.z);
                Assert.AreEqual("(81)", v.w);
            }
            {
                var ov = new gvec4<string>("", "-2", "3", "-1");
                var v = ov.swizzle.zyxw;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec4<string>("(-89)", "-4", null, null);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("-4", v.z);
            }
            {
                var ov = new gvec4<string>("(-91)", "-5", "(-91)", "(-91)");
                var v = ov.swizzle.zyyx;
                Assert.AreEqual("(-91)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("(-91)", v.w);
            }
            {
                var ov = new gvec4<string>("((-99)-4)", "(-6-4)", "1", "(-6-4)");
                var v = ov.swizzle.zyyy;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("(-6-4)", v.y);
                Assert.AreEqual("(-6-4)", v.z);
                Assert.AreEqual("(-6-4)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "((4-4)2)", "((4-6)4)", "((4-4)2)");
                var v = ov.swizzle.zyyz;
                Assert.AreEqual("((4-6)4)", v.x);
                Assert.AreEqual("((4-4)2)", v.y);
                Assert.AreEqual("((4-4)2)", v.z);
                Assert.AreEqual("((4-6)4)", v.w);
            }
            {
                var ov = new gvec4<string>("", "", "", "3");
                var v = ov.swizzle.zyyw;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("((37)7)", "((37)7)", "", "((-66)9)");
                var v = ov.swizzle.zyz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((37)7)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("(8-2)", "((-59)-9)", "2", null);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("((-59)-9)", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("(8-2)", v.w);
            }
            {
                var ov = new gvec4<string>("(2-3)", "((99)-7)", "(2-3)", "(-53)");
                var v = ov.swizzle.zyzy;
                Assert.AreEqual("(2-3)", v.x);
                Assert.AreEqual("((99)-7)", v.y);
                Assert.AreEqual("(2-3)", v.z);
                Assert.AreEqual("((99)-7)", v.w);
            }
            {
                var ov = new gvec4<string>("", "4", "(8-3)", "(-9-8)");
                var v = ov.swizzle.zyzz;
                Assert.AreEqual("(8-3)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("(8-3)", v.z);
                Assert.AreEqual("(8-3)", v.w);
            }
            {
                var ov = new gvec4<string>("-8", "3", "1", "(-36)");
                var v = ov.swizzle.zyzw;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("(-36)", v.w);
            }
            {
                var ov = new gvec4<string>("((5-2)4)", null, "", "4");
                var v = ov.swizzle.zyw;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("4", v.z);
            }
            {
                var ov = new gvec4<string>("((1-3)0)", "(-24)", "", "7");
                var v = ov.swizzle.zywx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(-24)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("((1-3)0)", v.w);
            }
            {
                var ov = new gvec4<string>("2", "0", null, "-2");
                var v = ov.swizzle.zywy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec4<string>("(-3-4)", "((19)4)", "((19)4)", "(-3-4)");
                var v = ov.swizzle.zywz;
                Assert.AreEqual("((19)4)", v.x);
                Assert.AreEqual("((19)4)", v.y);
                Assert.AreEqual("(-3-4)", v.z);
                Assert.AreEqual("((19)4)", v.w);
            }
            {
                var ov = new gvec4<string>("(0-4)", "(0-4)", "((-90)-8)", "(3-6)");
                var v = ov.swizzle.zyww;
                Assert.AreEqual("((-90)-8)", v.x);
                Assert.AreEqual("(0-4)", v.y);
                Assert.AreEqual("(3-6)", v.z);
                Assert.AreEqual("(3-6)", v.w);
            }
            {
                var ov = new gvec4<string>("(-77)", "((52)7)", "((2-9)-7)", "(5-6)");
                var v = ov.swizzle.zz;
                Assert.AreEqual("((2-9)-7)", v.x);
                Assert.AreEqual("((2-9)-7)", v.y);
            }
            {
                var ov = new gvec4<string>("((-94)-7)", "-8", null, "(7-1)");
                var v = ov.swizzle.zzx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-94)-7)", v.z);
            }
            {
                var ov = new gvec4<string>("((-1-2)-5)", "((-5-8)5)", null, "-2");
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-1-2)-5)", v.z);
                Assert.AreEqual("((-1-2)-5)", v.w);
            }
            {
                var ov = new gvec4<string>("-3", "(88)", "((0-6)-9)", "(-2-9)");
                var v = ov.swizzle.zzxy;
                Assert.AreEqual("((0-6)-9)", v.x);
                Assert.AreEqual("((0-6)-9)", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("(88)", v.w);
            }
            {
                var ov = new gvec4<string>("(07)", "", "", "(1-9)");
                var v = ov.swizzle.zzxz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(07)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("9", "9", "(-4-5)", "(80)");
                var v = ov.swizzle.zzxw;
                Assert.AreEqual("(-4-5)", v.x);
                Assert.AreEqual("(-4-5)", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("(80)", v.w);
            }
            {
                var ov = new gvec4<string>("", "1", "3", "-3");
                var v = ov.swizzle.zzy;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("1", v.z);
            }
            {
                var ov = new gvec4<string>("-1", null, null, "((9-4)-5)");
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec4<string>("((96)7)", "7", "7", "-1");
                var v = ov.swizzle.zzyy;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec4<string>("1", "", "(-44)", null);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual("(-44)", v.x);
                Assert.AreEqual("(-44)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-44)", v.w);
            }
            {
                var ov = new gvec4<string>("((7-1)7)", "((46)-6)", "-4", "((46)-6)");
                var v = ov.swizzle.zzyw;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("((46)-6)", v.z);
                Assert.AreEqual("((46)-6)", v.w);
            }
            {
                var ov = new gvec4<string>("(0-5)", "", "(07)", "(07)");
                var v = ov.swizzle.zzz;
                Assert.AreEqual("(07)", v.x);
                Assert.AreEqual("(07)", v.y);
                Assert.AreEqual("(07)", v.z);
            }
            {
                var ov = new gvec4<string>("((40)4)", null, null, "7");
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((40)4)", v.w);
            }
            {
                var ov = new gvec4<string>("-2", "", "2", "");
                var v = ov.swizzle.zzzy;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("", "", "(8-6)", "((55)2)");
                var v = ov.swizzle.zzzz;
                Assert.AreEqual("(8-6)", v.x);
                Assert.AreEqual("(8-6)", v.y);
                Assert.AreEqual("(8-6)", v.z);
                Assert.AreEqual("(8-6)", v.w);
            }
            {
                var ov = new gvec4<string>("((-3-3)-3)", null, "(-2-5)", "(4-4)");
                var v = ov.swizzle.zzzw;
                Assert.AreEqual("(-2-5)", v.x);
                Assert.AreEqual("(-2-5)", v.y);
                Assert.AreEqual("(-2-5)", v.z);
                Assert.AreEqual("(4-4)", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "8", "4", "(9-8)");
                var v = ov.swizzle.zzw;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("(9-8)", v.z);
            }
            {
                var ov = new gvec4<string>("3", null, "((2-4)2)", "(48)");
                var v = ov.swizzle.zzwx;
                Assert.AreEqual("((2-4)2)", v.x);
                Assert.AreEqual("((2-4)2)", v.y);
                Assert.AreEqual("(48)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>(null, "7", "((-29)7)", "(-4-5)");
                var v = ov.swizzle.zzwy;
                Assert.AreEqual("((-29)7)", v.x);
                Assert.AreEqual("((-29)7)", v.y);
                Assert.AreEqual("(-4-5)", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec4<string>(null, "((-3-9)1)", "-1", "-1");
                var v = ov.swizzle.zzwz;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec4<string>("7", "((8-6)8)", null, "(01)");
                var v = ov.swizzle.zzww;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(01)", v.z);
                Assert.AreEqual("(01)", v.w);
            }
            {
                var ov = new gvec4<string>("1", "((-4-4)4)", "(-68)", "((-5-7)7)");
                var v = ov.swizzle.zw;
                Assert.AreEqual("(-68)", v.x);
                Assert.AreEqual("((-5-7)7)", v.y);
            }
            {
                var ov = new gvec4<string>("2", "-1", "((97)8)", "(3-5)");
                var v = ov.swizzle.zwx;
                Assert.AreEqual("((97)8)", v.x);
                Assert.AreEqual("(3-5)", v.y);
                Assert.AreEqual("2", v.z);
            }
            {
                var ov = new gvec4<string>("7", "7", "(-72)", "(-72)");
                var v = ov.swizzle.zwxx;
                Assert.AreEqual("(-72)", v.x);
                Assert.AreEqual("(-72)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec4<string>("2", "0", "((70)4)", "-7");
                var v = ov.swizzle.zwxy;
                Assert.AreEqual("((70)4)", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec4<string>("-5", "", null, "(-53)");
                var v = ov.swizzle.zwxz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-53)", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("(29)", "((-6-1)6)", "((-9-5)-1)", "(-55)");
                var v = ov.swizzle.zwxw;
                Assert.AreEqual("((-9-5)-1)", v.x);
                Assert.AreEqual("(-55)", v.y);
                Assert.AreEqual("(29)", v.z);
                Assert.AreEqual("(-55)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "(-73)", "((-2-5)7)", "");
                var v = ov.swizzle.zwy;
                Assert.AreEqual("((-2-5)7)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-73)", v.z);
            }
            {
                var ov = new gvec4<string>("-7", "((83)6)", "", "((6-8)8)");
                var v = ov.swizzle.zwyx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((6-8)8)", v.y);
                Assert.AreEqual("((83)6)", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec4<string>("((-22)1)", "((-86)3)", "", "((-86)3)");
                var v = ov.swizzle.zwyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-86)3)", v.y);
                Assert.AreEqual("((-86)3)", v.z);
                Assert.AreEqual("((-86)3)", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-6)", "((-8-4)-6)", "-6", "((-8-4)-6)");
                var v = ov.swizzle.zwyz;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("((-8-4)-6)", v.y);
                Assert.AreEqual("((-8-4)-6)", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec4<string>("((11)7)", "((79)9)", null, "((79)9)");
                var v = ov.swizzle.zwyw;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((79)9)", v.y);
                Assert.AreEqual("((79)9)", v.z);
                Assert.AreEqual("((79)9)", v.w);
            }
            {
                var ov = new gvec4<string>("-9", "-9", "((8-4)1)", "((8-4)1)");
                var v = ov.swizzle.zwz;
                Assert.AreEqual("((8-4)1)", v.x);
                Assert.AreEqual("((8-4)1)", v.y);
                Assert.AreEqual("((8-4)1)", v.z);
            }
            {
                var ov = new gvec4<string>("-5", "(-39)", "", "");
                var v = ov.swizzle.zwzx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("((68)-4)", "9", "((68)-4)", "((-15)7)");
                var v = ov.swizzle.zwzy;
                Assert.AreEqual("((68)-4)", v.x);
                Assert.AreEqual("((-15)7)", v.y);
                Assert.AreEqual("((68)-4)", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec4<string>("((24)8)", "(37)", "-4", "((-9-6)-6)");
                var v = ov.swizzle.zwzz;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("((-9-6)-6)", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("-4", v.w);
            }
            {
                var ov = new gvec4<string>("(8-2)", "", "((-6-3)2)", "((-6-3)2)");
                var v = ov.swizzle.zwzw;
                Assert.AreEqual("((-6-3)2)", v.x);
                Assert.AreEqual("((-6-3)2)", v.y);
                Assert.AreEqual("((-6-3)2)", v.z);
                Assert.AreEqual("((-6-3)2)", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-1)", "-1", "-1", "(-73)");
                var v = ov.swizzle.zww;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("(-73)", v.y);
                Assert.AreEqual("(-73)", v.z);
            }
            {
                var ov = new gvec4<string>("(5-3)", "((0-2)4)", "((92)4)", "(04)");
                var v = ov.swizzle.zwwx;
                Assert.AreEqual("((92)4)", v.x);
                Assert.AreEqual("(04)", v.y);
                Assert.AreEqual("(04)", v.z);
                Assert.AreEqual("(5-3)", v.w);
            }
            {
                var ov = new gvec4<string>("2", "2", "(4-2)", "((-8-7)2)");
                var v = ov.swizzle.zwwy;
                Assert.AreEqual("(4-2)", v.x);
                Assert.AreEqual("((-8-7)2)", v.y);
                Assert.AreEqual("((-8-7)2)", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec4<string>("((4-4)-2)", "((4-4)-2)", "((-6-9)-1)", "((-5-9)7)");
                var v = ov.swizzle.zwwz;
                Assert.AreEqual("((-6-9)-1)", v.x);
                Assert.AreEqual("((-5-9)7)", v.y);
                Assert.AreEqual("((-5-9)7)", v.z);
                Assert.AreEqual("((-6-9)-1)", v.w);
            }
            {
                var ov = new gvec4<string>("-5", "(-24)", "(97)", "");
                var v = ov.swizzle.zwww;
                Assert.AreEqual("(97)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((-35)8)", null, "(-7-1)", null);
                var v = ov.swizzle.wx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-35)8)", v.y);
            }
            {
                var ov = new gvec4<string>(null, "(-4-7)", "(-4-7)", "(-4-7)");
                var v = ov.swizzle.wxx;
                Assert.AreEqual("(-4-7)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>(null, "-5", "((-65)-7)", "-3");
                var v = ov.swizzle.wxxx;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((4-5)1)", "(50)", "((-4-5)-8)", null);
                var v = ov.swizzle.wxxy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((4-5)1)", v.y);
                Assert.AreEqual("((4-5)1)", v.z);
                Assert.AreEqual("(50)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "(84)", "(4-7)", "(4-7)");
                var v = ov.swizzle.wxxz;
                Assert.AreEqual("(4-7)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(4-7)", v.w);
            }
            {
                var ov = new gvec4<string>("5", "(28)", "((76)-2)", "((-79)0)");
                var v = ov.swizzle.wxxw;
                Assert.AreEqual("((-79)0)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("((-79)0)", v.w);
            }
            {
                var ov = new gvec4<string>("(-69)", "", "((7-5)8)", null);
                var v = ov.swizzle.wxy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-69)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("((33)-6)", "((-56)-3)", "(44)", null);
                var v = ov.swizzle.wxyx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((33)-6)", v.y);
                Assert.AreEqual("((-56)-3)", v.z);
                Assert.AreEqual("((33)-6)", v.w);
            }
            {
                var ov = new gvec4<string>("5", null, "", null);
                var v = ov.swizzle.wxyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((96)8)", "((96)8)", "-9", "2");
                var v = ov.swizzle.wxyz;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("((96)8)", v.y);
                Assert.AreEqual("((96)8)", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>("1", "-2", "-2", null);
                var v = ov.swizzle.wxyw;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("(-4-3)", null, "(-4-3)", "6");
                var v = ov.swizzle.wxz;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("(-4-3)", v.y);
                Assert.AreEqual("(-4-3)", v.z);
            }
            {
                var ov = new gvec4<string>("-5", "((-25)-2)", "(-6-4)", "(-31)");
                var v = ov.swizzle.wxzx;
                Assert.AreEqual("(-31)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(-6-4)", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("(7-7)", "(7-7)", "((4-6)-4)", "(-4-1)");
                var v = ov.swizzle.wxzy;
                Assert.AreEqual("(-4-1)", v.x);
                Assert.AreEqual("(7-7)", v.y);
                Assert.AreEqual("((4-6)-4)", v.z);
                Assert.AreEqual("(7-7)", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-7)", null, null, "");
                var v = ov.swizzle.wxzz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(-7-7)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("-8", "((-46)9)", "(-48)", "-8");
                var v = ov.swizzle.wxzw;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("(-48)", v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec4<string>("((42)-3)", "(-6-6)", "", "");
                var v = ov.swizzle.wxw;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((42)-3)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("(18)", "((-5-6)7)", "-9", "((-5-6)7)");
                var v = ov.swizzle.wxwx;
                Assert.AreEqual("((-5-6)7)", v.x);
                Assert.AreEqual("(18)", v.y);
                Assert.AreEqual("((-5-6)7)", v.z);
                Assert.AreEqual("(18)", v.w);
            }
            {
                var ov = new gvec4<string>("((3-1)7)", "-4", "((3-1)7)", "");
                var v = ov.swizzle.wxwy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((3-1)7)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-4", v.w);
            }
            {
                var ov = new gvec4<string>("", "0", "(-91)", "(8-2)");
                var v = ov.swizzle.wxwz;
                Assert.AreEqual("(8-2)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(8-2)", v.z);
                Assert.AreEqual("(-91)", v.w);
            }
            {
                var ov = new gvec4<string>("(0-8)", "-3", "(-70)", "((01)-7)");
                var v = ov.swizzle.wxww;
                Assert.AreEqual("((01)-7)", v.x);
                Assert.AreEqual("(0-8)", v.y);
                Assert.AreEqual("((01)-7)", v.z);
                Assert.AreEqual("((01)-7)", v.w);
            }
            {
                var ov = new gvec4<string>("", "(-66)", "(-66)", "((-2-1)8)");
                var v = ov.swizzle.wy;
                Assert.AreEqual("((-2-1)8)", v.x);
                Assert.AreEqual("(-66)", v.y);
            }
            {
                var ov = new gvec4<string>("-6", "(2-6)", "((-50)-1)", "((-5-2)5)");
                var v = ov.swizzle.wyx;
                Assert.AreEqual("((-5-2)5)", v.x);
                Assert.AreEqual("(2-6)", v.y);
                Assert.AreEqual("-6", v.z);
            }
            {
                var ov = new gvec4<string>(null, "9", "6", "9");
                var v = ov.swizzle.wyxx;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("7", "7", null, "-6");
                var v = ov.swizzle.wyxy;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec4<string>("(-65)", "((58)-9)", null, "-5");
                var v = ov.swizzle.wyxz;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("((58)-9)", v.y);
                Assert.AreEqual("(-65)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("(6-5)", "(6-5)", null, null);
                var v = ov.swizzle.wyxw;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(6-5)", v.y);
                Assert.AreEqual("(6-5)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("(0-6)", null, "((8-7)9)", "(4-7)");
                var v = ov.swizzle.wyy;
                Assert.AreEqual("(4-7)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("((-87)8)", "-8", "((37)8)", "(3-3)");
                var v = ov.swizzle.wyyx;
                Assert.AreEqual("(3-3)", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("((-87)8)", v.w);
            }
            {
                var ov = new gvec4<string>("(28)", "((-73)0)", "-3", null);
                var v = ov.swizzle.wyyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-73)0)", v.y);
                Assert.AreEqual("((-73)0)", v.z);
                Assert.AreEqual("((-73)0)", v.w);
            }
            {
                var ov = new gvec4<string>("-5", "-5", "-7", "5");
                var v = ov.swizzle.wyyz;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec4<string>("(-83)", null, "(-86)", "(1-4)");
                var v = ov.swizzle.wyyw;
                Assert.AreEqual("(1-4)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(1-4)", v.w);
            }
            {
                var ov = new gvec4<string>(null, null, "((-52)9)", "(-21)");
                var v = ov.swizzle.wyz;
                Assert.AreEqual("(-21)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-52)9)", v.z);
            }
            {
                var ov = new gvec4<string>("-8", "(4-5)", "", "");
                var v = ov.swizzle.wyzx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(4-5)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec4<string>("((84)2)", "", "-5", "-8");
                var v = ov.swizzle.wyzy;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(8-4)", "(8-4)", "5", "((-1-3)2)");
                var v = ov.swizzle.wyzz;
                Assert.AreEqual("((-1-3)2)", v.x);
                Assert.AreEqual("(8-4)", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec4<string>("0", "0", "(68)", "(6-9)");
                var v = ov.swizzle.wyzw;
                Assert.AreEqual("(6-9)", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("(68)", v.z);
                Assert.AreEqual("(6-9)", v.w);
            }
            {
                var ov = new gvec4<string>("9", "2", "(-64)", "((-84)5)");
                var v = ov.swizzle.wyw;
                Assert.AreEqual("((-84)5)", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("((-84)5)", v.z);
            }
            {
                var ov = new gvec4<string>("(-5-8)", "", "4", "((-35)-6)");
                var v = ov.swizzle.wywx;
                Assert.AreEqual("((-35)-6)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-35)-6)", v.z);
                Assert.AreEqual("(-5-8)", v.w);
            }
            {
                var ov = new gvec4<string>("(-44)", "(94)", "(22)", "-8");
                var v = ov.swizzle.wywy;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("(94)", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("(94)", v.w);
            }
            {
                var ov = new gvec4<string>("(-47)", "(-27)", "-2", "(-27)");
                var v = ov.swizzle.wywz;
                Assert.AreEqual("(-27)", v.x);
                Assert.AreEqual("(-27)", v.y);
                Assert.AreEqual("(-27)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec4<string>("(3-7)", "((3-1)-2)", "((3-1)-2)", "(3-7)");
                var v = ov.swizzle.wyww;
                Assert.AreEqual("(3-7)", v.x);
                Assert.AreEqual("((3-1)-2)", v.y);
                Assert.AreEqual("(3-7)", v.z);
                Assert.AreEqual("(3-7)", v.w);
            }
            {
                var ov = new gvec4<string>("", "-3", "(-9-5)", "((5-1)0)");
                var v = ov.swizzle.wz;
                Assert.AreEqual("((5-1)0)", v.x);
                Assert.AreEqual("(-9-5)", v.y);
            }
            {
                var ov = new gvec4<string>("(4-8)", "(4-8)", "((-2-5)-2)", "(-4-1)");
                var v = ov.swizzle.wzx;
                Assert.AreEqual("(-4-1)", v.x);
                Assert.AreEqual("((-2-5)-2)", v.y);
                Assert.AreEqual("(4-8)", v.z);
            }
            {
                var ov = new gvec4<string>("(1-3)", "-6", "(1-3)", "((1-2)-5)");
                var v = ov.swizzle.wzxx;
                Assert.AreEqual("((1-2)-5)", v.x);
                Assert.AreEqual("(1-3)", v.y);
                Assert.AreEqual("(1-3)", v.z);
                Assert.AreEqual("(1-3)", v.w);
            }
            {
                var ov = new gvec4<string>("(70)", "(9-9)", null, "(70)");
                var v = ov.swizzle.wzxy;
                Assert.AreEqual("(70)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(70)", v.z);
                Assert.AreEqual("(9-9)", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "(1-2)", "", "(28)");
                var v = ov.swizzle.wzxz;
                Assert.AreEqual("(28)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((61)1)", "-4", "", "(78)");
                var v = ov.swizzle.wzxw;
                Assert.AreEqual("(78)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((61)1)", v.z);
                Assert.AreEqual("(78)", v.w);
            }
            {
                var ov = new gvec4<string>("((-79)9)", "9", "", "-9");
                var v = ov.swizzle.wzy;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("9", v.z);
            }
            {
                var ov = new gvec4<string>("((65)-6)", "8", "-7", "8");
                var v = ov.swizzle.wzyx;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("((65)-6)", v.w);
            }
            {
                var ov = new gvec4<string>("-6", "-1", "-3", "-3");
                var v = ov.swizzle.wzyy;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec4<string>(null, "(53)", "(1-6)", "5");
                var v = ov.swizzle.wzyz;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("(1-6)", v.y);
                Assert.AreEqual("(53)", v.z);
                Assert.AreEqual("(1-6)", v.w);
            }
            {
                var ov = new gvec4<string>("-3", "-3", "", "(3-7)");
                var v = ov.swizzle.wzyw;
                Assert.AreEqual("(3-7)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("(3-7)", v.w);
            }
            {
                var ov = new gvec4<string>("", "1", "(2-4)", "-3");
                var v = ov.swizzle.wzz;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("(2-4)", v.y);
                Assert.AreEqual("(2-4)", v.z);
            }
            {
                var ov = new gvec4<string>("6", "(42)", "(09)", "(09)");
                var v = ov.swizzle.wzzx;
                Assert.AreEqual("(09)", v.x);
                Assert.AreEqual("(09)", v.y);
                Assert.AreEqual("(09)", v.z);
                Assert.AreEqual("6", v.w);
            }
            {
                var ov = new gvec4<string>("-3", "((-1-8)1)", "-3", "-5");
                var v = ov.swizzle.wzzy;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("((-1-8)1)", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-2)", "((-39)0)", "((1-5)1)", "-9");
                var v = ov.swizzle.wzzz;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((1-5)1)", v.y);
                Assert.AreEqual("((1-5)1)", v.z);
                Assert.AreEqual("((1-5)1)", v.w);
            }
            {
                var ov = new gvec4<string>("((-9-1)8)", null, "(6-2)", "((-8-1)-1)");
                var v = ov.swizzle.wzzw;
                Assert.AreEqual("((-8-1)-1)", v.x);
                Assert.AreEqual("(6-2)", v.y);
                Assert.AreEqual("(6-2)", v.z);
                Assert.AreEqual("((-8-1)-1)", v.w);
            }
            {
                var ov = new gvec4<string>("", "(-2-7)", "7", "(70)");
                var v = ov.swizzle.wzw;
                Assert.AreEqual("(70)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("(70)", v.z);
            }
            {
                var ov = new gvec4<string>("(75)", "8", "(-92)", "0");
                var v = ov.swizzle.wzwx;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("(-92)", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("(75)", v.w);
            }
            {
                var ov = new gvec4<string>("(-13)", "(-8-8)", "(2-8)", "8");
                var v = ov.swizzle.wzwy;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("(2-8)", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("(-8-8)", v.w);
            }
            {
                var ov = new gvec4<string>("((2-2)-1)", "((9-3)9)", "((9-3)9)", "");
                var v = ov.swizzle.wzwz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((9-3)9)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((9-3)9)", v.w);
            }
            {
                var ov = new gvec4<string>("(48)", "((-7-7)-8)", "(4-6)", "((01)-1)");
                var v = ov.swizzle.wzww;
                Assert.AreEqual("((01)-1)", v.x);
                Assert.AreEqual("(4-6)", v.y);
                Assert.AreEqual("((01)-1)", v.z);
                Assert.AreEqual("((01)-1)", v.w);
            }
            {
                var ov = new gvec4<string>("(21)", "((-76)-1)", "(21)", "-5");
                var v = ov.swizzle.ww;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-5", v.y);
            }
            {
                var ov = new gvec4<string>("-3", "(0-6)", "(0-6)", "");
                var v = ov.swizzle.wwx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-3", v.z);
            }
            {
                var ov = new gvec4<string>("", "(-6-2)", "((-83)-8)", "((-83)-8)");
                var v = ov.swizzle.wwxx;
                Assert.AreEqual("((-83)-8)", v.x);
                Assert.AreEqual("((-83)-8)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("9", "((-6-2)8)", "(80)", "(80)");
                var v = ov.swizzle.wwxy;
                Assert.AreEqual("(80)", v.x);
                Assert.AreEqual("(80)", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("((-6-2)8)", v.w);
            }
            {
                var ov = new gvec4<string>("(-6-8)", "(-6-8)", "(0-2)", "-4");
                var v = ov.swizzle.wwxz;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("(-6-8)", v.z);
                Assert.AreEqual("(0-2)", v.w);
            }
            {
                var ov = new gvec4<string>("(-42)", "7", "-9", null);
                var v = ov.swizzle.wwxw;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-42)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>(null, "((-1-9)-2)", "-7", "(75)");
                var v = ov.swizzle.wwy;
                Assert.AreEqual("(75)", v.x);
                Assert.AreEqual("(75)", v.y);
                Assert.AreEqual("((-1-9)-2)", v.z);
            }
            {
                var ov = new gvec4<string>("-7", "((-24)-9)", null, "(98)");
                var v = ov.swizzle.wwyx;
                Assert.AreEqual("(98)", v.x);
                Assert.AreEqual("(98)", v.y);
                Assert.AreEqual("((-24)-9)", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec4<string>(null, "8", "(0-1)", "(79)");
                var v = ov.swizzle.wwyy;
                Assert.AreEqual("(79)", v.x);
                Assert.AreEqual("(79)", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("((-7-6)5)", "(-89)", "(79)", "1");
                var v = ov.swizzle.wwyz;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("(-89)", v.z);
                Assert.AreEqual("(79)", v.w);
            }
            {
                var ov = new gvec4<string>("((21)-2)", "((21)-2)", "(8-7)", "(05)");
                var v = ov.swizzle.wwyw;
                Assert.AreEqual("(05)", v.x);
                Assert.AreEqual("(05)", v.y);
                Assert.AreEqual("((21)-2)", v.z);
                Assert.AreEqual("(05)", v.w);
            }
            {
                var ov = new gvec4<string>("(-8-1)", "-2", null, "((-96)7)");
                var v = ov.swizzle.wwz;
                Assert.AreEqual("((-96)7)", v.x);
                Assert.AreEqual("((-96)7)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("(-63)", "((-99)6)", "-7", "-8");
                var v = ov.swizzle.wwzx;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("(-63)", v.w);
            }
            {
                var ov = new gvec4<string>("-9", "1", "((26)1)", "(20)");
                var v = ov.swizzle.wwzy;
                Assert.AreEqual("(20)", v.x);
                Assert.AreEqual("(20)", v.y);
                Assert.AreEqual("((26)1)", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-1)", "((6-1)-1)", "(4-2)", null);
                var v = ov.swizzle.wwzz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(4-2)", v.z);
                Assert.AreEqual("(4-2)", v.w);
            }
            {
                var ov = new gvec4<string>("", "(98)", "4", "(-74)");
                var v = ov.swizzle.wwzw;
                Assert.AreEqual("(-74)", v.x);
                Assert.AreEqual("(-74)", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("(-74)", v.w);
            }
            {
                var ov = new gvec4<string>("((4-7)3)", "", "(-9-8)", "-7");
                var v = ov.swizzle.www;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("-7", v.z);
            }
            {
                var ov = new gvec4<string>("((09)-4)", "9", null, "(7-8)");
                var v = ov.swizzle.wwwx;
                Assert.AreEqual("(7-8)", v.x);
                Assert.AreEqual("(7-8)", v.y);
                Assert.AreEqual("(7-8)", v.z);
                Assert.AreEqual("((09)-4)", v.w);
            }
            {
                var ov = new gvec4<string>("-3", "2", "((8-1)-7)", "((6-3)-2)");
                var v = ov.swizzle.wwwy;
                Assert.AreEqual("((6-3)-2)", v.x);
                Assert.AreEqual("((6-3)-2)", v.y);
                Assert.AreEqual("((6-3)-2)", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec4<string>(null, "((-43)-3)", "(23)", "");
                var v = ov.swizzle.wwwz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(23)", v.w);
            }
            {
                var ov = new gvec4<string>("(35)", "1", "((-3-4)9)", "-9");
                var v = ov.swizzle.wwww;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new gvec4<string>(null, "(3-4)", "((-67)2)", "((5-1)-2)");
                var v = ov.swizzle.rr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
            }
            {
                var ov = new gvec4<string>("", "", "((-4-1)-3)", "((2-7)9)");
                var v = ov.swizzle.rrr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>(null, "((-13)5)", "(-17)", "((-13)5)");
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("", "4", "-4", "4");
                var v = ov.swizzle.rrrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("4", v.w);
            }
            {
                var ov = new gvec4<string>("-6", "(21)", "(3-4)", null);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("(3-4)", v.w);
            }
            {
                var ov = new gvec4<string>("(65)", "(-55)", "-5", "");
                var v = ov.swizzle.rrra;
                Assert.AreEqual("(65)", v.x);
                Assert.AreEqual("(65)", v.y);
                Assert.AreEqual("(65)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(3-3)", "(-81)", "(-81)", "(3-3)");
                var v = ov.swizzle.rrg;
                Assert.AreEqual("(3-3)", v.x);
                Assert.AreEqual("(3-3)", v.y);
                Assert.AreEqual("(-81)", v.z);
            }
            {
                var ov = new gvec4<string>("((-56)-5)", "((-56)-5)", "-7", "(8-4)");
                var v = ov.swizzle.rrgr;
                Assert.AreEqual("((-56)-5)", v.x);
                Assert.AreEqual("((-56)-5)", v.y);
                Assert.AreEqual("((-56)-5)", v.z);
                Assert.AreEqual("((-56)-5)", v.w);
            }
            {
                var ov = new gvec4<string>("6", "(1-5)", "((-4-2)-7)", "((-7-7)6)");
                var v = ov.swizzle.rrgg;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("(1-5)", v.z);
                Assert.AreEqual("(1-5)", v.w);
            }
            {
                var ov = new gvec4<string>("", "((67)-1)", null, "((-6-8)-5)");
                var v = ov.swizzle.rrgb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((67)-1)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((-8-3)-6)", "((-8-3)-6)", "3", "3");
                var v = ov.swizzle.rrga;
                Assert.AreEqual("((-8-3)-6)", v.x);
                Assert.AreEqual("((-8-3)-6)", v.y);
                Assert.AreEqual("((-8-3)-6)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("(-86)", "-8", "(-86)", "((-10)-5)");
                var v = ov.swizzle.rrb;
                Assert.AreEqual("(-86)", v.x);
                Assert.AreEqual("(-86)", v.y);
                Assert.AreEqual("(-86)", v.z);
            }
            {
                var ov = new gvec4<string>("", "0", "2", "((-3-3)-9)");
                var v = ov.swizzle.rrbr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(-6-7)", "-3", "3", "(-70)");
                var v = ov.swizzle.rrbg;
                Assert.AreEqual("(-6-7)", v.x);
                Assert.AreEqual("(-6-7)", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("(-6-8)", "1", "3", "");
                var v = ov.swizzle.rrbb;
                Assert.AreEqual("(-6-8)", v.x);
                Assert.AreEqual("(-6-8)", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("((02)-7)", "((5-5)4)", "", "(33)");
                var v = ov.swizzle.rrba;
                Assert.AreEqual("((02)-7)", v.x);
                Assert.AreEqual("((02)-7)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(33)", v.w);
            }
            {
                var ov = new gvec4<string>("-1", "((-29)-8)", "(69)", "((-29)-8)");
                var v = ov.swizzle.rra;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("((-29)-8)", v.z);
            }
            {
                var ov = new gvec4<string>("(-9-1)", "((62)-2)", "(-1-3)", "");
                var v = ov.swizzle.rrar;
                Assert.AreEqual("(-9-1)", v.x);
                Assert.AreEqual("(-9-1)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-9-1)", v.w);
            }
            {
                var ov = new gvec4<string>("(-70)", "", "-8", "6");
                var v = ov.swizzle.rrag;
                Assert.AreEqual("(-70)", v.x);
                Assert.AreEqual("(-70)", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>(null, "(-26)", "(-26)", "(-26)");
                var v = ov.swizzle.rrab;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-26)", v.z);
                Assert.AreEqual("(-26)", v.w);
            }
            {
                var ov = new gvec4<string>("5", "(-32)", "(-5-2)", "(83)");
                var v = ov.swizzle.rraa;
                Assert.AreEqual("5", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("(83)", v.z);
                Assert.AreEqual("(83)", v.w);
            }
            {
                var ov = new gvec4<string>("(-32)", "((-3-7)0)", "(18)", "(18)");
                var v = ov.swizzle.rg;
                Assert.AreEqual("(-32)", v.x);
                Assert.AreEqual("((-3-7)0)", v.y);
            }
            {
                var ov = new gvec4<string>("((-90)-1)", "-5", "(-9-2)", "((-90)-1)");
                var v = ov.swizzle.rgr;
                Assert.AreEqual("((-90)-1)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("((-90)-1)", v.z);
            }
            {
                var ov = new gvec4<string>("(38)", "", null, "(-5-9)");
                var v = ov.swizzle.rgrr;
                Assert.AreEqual("(38)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(38)", v.z);
                Assert.AreEqual("(38)", v.w);
            }
            {
                var ov = new gvec4<string>("-7", "(-1-5)", "(-9-9)", "-7");
                var v = ov.swizzle.rgrg;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(-1-5)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("(-1-5)", v.w);
            }
            {
                var ov = new gvec4<string>("((-99)-1)", "((08)6)", "-3", "-9");
                var v = ov.swizzle.rgrb;
                Assert.AreEqual("((-99)-1)", v.x);
                Assert.AreEqual("((08)6)", v.y);
                Assert.AreEqual("((-99)-1)", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("((-7-3)0)", "0", "9", "9");
                var v = ov.swizzle.rgra;
                Assert.AreEqual("((-7-3)0)", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("((-7-3)0)", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec4<string>("(2-2)", "(1-4)", null, "4");
                var v = ov.swizzle.rgg;
                Assert.AreEqual("(2-2)", v.x);
                Assert.AreEqual("(1-4)", v.y);
                Assert.AreEqual("(1-4)", v.z);
            }
            {
                var ov = new gvec4<string>("((-4-7)-1)", null, "((-50)4)", null);
                var v = ov.swizzle.rggr;
                Assert.AreEqual("((-4-7)-1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((-4-7)-1)", v.w);
            }
            {
                var ov = new gvec4<string>("((-68)-5)", "((-50)8)", "(-84)", "0");
                var v = ov.swizzle.rggg;
                Assert.AreEqual("((-68)-5)", v.x);
                Assert.AreEqual("((-50)8)", v.y);
                Assert.AreEqual("((-50)8)", v.z);
                Assert.AreEqual("((-50)8)", v.w);
            }
            {
                var ov = new gvec4<string>("-5", "((10)7)", "(-94)", "((10)7)");
                var v = ov.swizzle.rggb;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("((10)7)", v.y);
                Assert.AreEqual("((10)7)", v.z);
                Assert.AreEqual("(-94)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "-2", "((68)2)", null);
                var v = ov.swizzle.rgga;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("", "((-56)-4)", "-3", "(66)");
                var v = ov.swizzle.rgb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-56)-4)", v.y);
                Assert.AreEqual("-3", v.z);
            }
            {
                var ov = new gvec4<string>("(10)", "((7-4)-7)", "4", null);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual("(10)", v.x);
                Assert.AreEqual("((7-4)-7)", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("(10)", v.w);
            }
            {
                var ov = new gvec4<string>("((4-6)8)", "(6-7)", "2", "((-9-2)-3)");
                var v = ov.swizzle.rgbg;
                Assert.AreEqual("((4-6)8)", v.x);
                Assert.AreEqual("(6-7)", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("(6-7)", v.w);
            }
            {
                var ov = new gvec4<string>("-7", "-4", "((90)6)", "(-7-1)");
                var v = ov.swizzle.rgbb;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("((90)6)", v.z);
                Assert.AreEqual("((90)6)", v.w);
            }
            {
                var ov = new gvec4<string>("(1-9)", "7", "-7", "(1-9)");
                var v = ov.swizzle.rgba;
                Assert.AreEqual("(1-9)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("(1-9)", v.w);
            }
            {
                var ov = new gvec4<string>("-5", "-5", null, "(60)");
                var v = ov.swizzle.rga;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(60)", v.z);
            }
            {
                var ov = new gvec4<string>("(-87)", "((42)7)", "(3-8)", "");
                var v = ov.swizzle.rgar;
                Assert.AreEqual("(-87)", v.x);
                Assert.AreEqual("((42)7)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-87)", v.w);
            }
            {
                var ov = new gvec4<string>("1", null, "1", "(-54)");
                var v = ov.swizzle.rgag;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-54)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((-77)-9)", null, null, "(-83)");
                var v = ov.swizzle.rgab;
                Assert.AreEqual("((-77)-9)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-83)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((-77)3)", "((-77)3)", "(3-3)", "((3-9)9)");
                var v = ov.swizzle.rgaa;
                Assert.AreEqual("((-77)3)", v.x);
                Assert.AreEqual("((-77)3)", v.y);
                Assert.AreEqual("((3-9)9)", v.z);
                Assert.AreEqual("((3-9)9)", v.w);
            }
            {
                var ov = new gvec4<string>("-5", "(8-8)", "((58)1)", null);
                var v = ov.swizzle.rb;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("((58)1)", v.y);
            }
            {
                var ov = new gvec4<string>("4", "", "(-3-9)", "((6-9)-9)");
                var v = ov.swizzle.rbr;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("(-3-9)", v.y);
                Assert.AreEqual("4", v.z);
            }
            {
                var ov = new gvec4<string>("((-2-8)-4)", "", "((-93)-2)", "-9");
                var v = ov.swizzle.rbrr;
                Assert.AreEqual("((-2-8)-4)", v.x);
                Assert.AreEqual("((-93)-2)", v.y);
                Assert.AreEqual("((-2-8)-4)", v.z);
                Assert.AreEqual("((-2-8)-4)", v.w);
            }
            {
                var ov = new gvec4<string>("6", "((-75)5)", "(-52)", "((1-9)5)");
                var v = ov.swizzle.rbrg;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("(-52)", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("((-75)5)", v.w);
            }
            {
                var ov = new gvec4<string>("((1-2)-4)", "((1-2)-4)", null, "((33)-6)");
                var v = ov.swizzle.rbrb;
                Assert.AreEqual("((1-2)-4)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((1-2)-4)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>(null, "((-15)6)", "5", "5");
                var v = ov.swizzle.rbra;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec4<string>("(-52)", "", "(-50)", "-2");
                var v = ov.swizzle.rbg;
                Assert.AreEqual("(-52)", v.x);
                Assert.AreEqual("(-50)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("((-4-6)8)", "(65)", "((-37)-3)", "((-4-6)8)");
                var v = ov.swizzle.rbgr;
                Assert.AreEqual("((-4-6)8)", v.x);
                Assert.AreEqual("((-37)-3)", v.y);
                Assert.AreEqual("(65)", v.z);
                Assert.AreEqual("((-4-6)8)", v.w);
            }
            {
                var ov = new gvec4<string>("((-3-6)0)", "(25)", "", "(-98)");
                var v = ov.swizzle.rbgg;
                Assert.AreEqual("((-3-6)0)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(25)", v.z);
                Assert.AreEqual("(25)", v.w);
            }
            {
                var ov = new gvec4<string>("((-36)8)", "(77)", "-1", "");
                var v = ov.swizzle.rbgb;
                Assert.AreEqual("((-36)8)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("(77)", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec4<string>("(26)", "(-4-8)", "(-3-8)", "(-3-8)");
                var v = ov.swizzle.rbga;
                Assert.AreEqual("(26)", v.x);
                Assert.AreEqual("(-3-8)", v.y);
                Assert.AreEqual("(-4-8)", v.z);
                Assert.AreEqual("(-3-8)", v.w);
            }
            {
                var ov = new gvec4<string>("(44)", "((37)8)", "-4", "-4");
                var v = ov.swizzle.rbb;
                Assert.AreEqual("(44)", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("-4", v.z);
            }
            {
                var ov = new gvec4<string>("1", "((-2-5)2)", "(-31)", "((52)-4)");
                var v = ov.swizzle.rbbr;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("(-31)", v.y);
                Assert.AreEqual("(-31)", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec4<string>("-9", "-7", "-9", "(8-5)");
                var v = ov.swizzle.rbbg;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec4<string>("(4-7)", "(4-7)", "(-33)", "");
                var v = ov.swizzle.rbbb;
                Assert.AreEqual("(4-7)", v.x);
                Assert.AreEqual("(-33)", v.y);
                Assert.AreEqual("(-33)", v.z);
                Assert.AreEqual("(-33)", v.w);
            }
            {
                var ov = new gvec4<string>("((-3-6)1)", "((-3-6)1)", "((-3-6)1)", "-6");
                var v = ov.swizzle.rbba;
                Assert.AreEqual("((-3-6)1)", v.x);
                Assert.AreEqual("((-3-6)1)", v.y);
                Assert.AreEqual("((-3-6)1)", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec4<string>("-9", "-9", "(8-3)", "((54)-1)");
                var v = ov.swizzle.rba;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("(8-3)", v.y);
                Assert.AreEqual("((54)-1)", v.z);
            }
            {
                var ov = new gvec4<string>("((5-9)6)", null, "", "((5-9)6)");
                var v = ov.swizzle.rbar;
                Assert.AreEqual("((5-9)6)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((5-9)6)", v.z);
                Assert.AreEqual("((5-9)6)", v.w);
            }
            {
                var ov = new gvec4<string>("((3-7)5)", "-8", "(57)", null);
                var v = ov.swizzle.rbag;
                Assert.AreEqual("((3-7)5)", v.x);
                Assert.AreEqual("(57)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec4<string>("-2", "(85)", "(85)", "-2");
                var v = ov.swizzle.rbab;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("(85)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("(85)", v.w);
            }
            {
                var ov = new gvec4<string>("4", "", "(0-5)", "(-3-2)");
                var v = ov.swizzle.rbaa;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("(0-5)", v.y);
                Assert.AreEqual("(-3-2)", v.z);
                Assert.AreEqual("(-3-2)", v.w);
            }
            {
                var ov = new gvec4<string>("(-96)", null, "-5", "(67)");
                var v = ov.swizzle.ra;
                Assert.AreEqual("(-96)", v.x);
                Assert.AreEqual("(67)", v.y);
            }
            {
                var ov = new gvec4<string>("((9-1)-9)", null, "-2", "-7");
                var v = ov.swizzle.rar;
                Assert.AreEqual("((9-1)-9)", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("((9-1)-9)", v.z);
            }
            {
                var ov = new gvec4<string>("-9", "(-80)", "(-80)", "((-50)-2)");
                var v = ov.swizzle.rarr;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((-50)-2)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>("(-3-3)", "(-3-3)", "-8", "((31)7)");
                var v = ov.swizzle.rarg;
                Assert.AreEqual("(-3-3)", v.x);
                Assert.AreEqual("((31)7)", v.y);
                Assert.AreEqual("(-3-3)", v.z);
                Assert.AreEqual("(-3-3)", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-3)", "((0-8)5)", "-9", "((-69)2)");
                var v = ov.swizzle.rarb;
                Assert.AreEqual("(-7-3)", v.x);
                Assert.AreEqual("((-69)2)", v.y);
                Assert.AreEqual("(-7-3)", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>("(89)", "2", "(89)", "(-2-1)");
                var v = ov.swizzle.rara;
                Assert.AreEqual("(89)", v.x);
                Assert.AreEqual("(-2-1)", v.y);
                Assert.AreEqual("(89)", v.z);
                Assert.AreEqual("(-2-1)", v.w);
            }
            {
                var ov = new gvec4<string>("((-73)-7)", "(-40)", "-2", "((-14)-3)");
                var v = ov.swizzle.rag;
                Assert.AreEqual("((-73)-7)", v.x);
                Assert.AreEqual("((-14)-3)", v.y);
                Assert.AreEqual("(-40)", v.z);
            }
            {
                var ov = new gvec4<string>("-2", "-2", "((54)0)", "(90)");
                var v = ov.swizzle.ragr;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("(90)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec4<string>("0", "((-3-3)1)", "((-3-3)1)", "(5-4)");
                var v = ov.swizzle.ragg;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("(5-4)", v.y);
                Assert.AreEqual("((-3-3)1)", v.z);
                Assert.AreEqual("((-3-3)1)", v.w);
            }
            {
                var ov = new gvec4<string>("7", "(-6-4)", "0", "0");
                var v = ov.swizzle.ragb;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("(-6-4)", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec4<string>("1", "(0-9)", "((-4-1)3)", "");
                var v = ov.swizzle.raga;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(0-9)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((02)0)", "((-19)7)", "9", "9");
                var v = ov.swizzle.rab;
                Assert.AreEqual("((02)0)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
            }
            {
                var ov = new gvec4<string>("-6", "5", "-6", "-6");
                var v = ov.swizzle.rabr;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec4<string>("((3-4)9)", "((-1-2)-7)", "-7", "(16)");
                var v = ov.swizzle.rabg;
                Assert.AreEqual("((3-4)9)", v.x);
                Assert.AreEqual("(16)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("((-1-2)-7)", v.w);
            }
            {
                var ov = new gvec4<string>("((76)5)", "(0-9)", "((50)-7)", "3");
                var v = ov.swizzle.rabb;
                Assert.AreEqual("((76)5)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("((50)-7)", v.z);
                Assert.AreEqual("((50)-7)", v.w);
            }
            {
                var ov = new gvec4<string>("(-94)", "8", "((-5-9)-4)", "(73)");
                var v = ov.swizzle.raba;
                Assert.AreEqual("(-94)", v.x);
                Assert.AreEqual("(73)", v.y);
                Assert.AreEqual("((-5-9)-4)", v.z);
                Assert.AreEqual("(73)", v.w);
            }
            {
                var ov = new gvec4<string>("", "(84)", null, "-6");
                var v = ov.swizzle.raa;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
            }
            {
                var ov = new gvec4<string>("((8-1)1)", "(22)", "((3-4)-4)", "((3-4)-4)");
                var v = ov.swizzle.raar;
                Assert.AreEqual("((8-1)1)", v.x);
                Assert.AreEqual("((3-4)-4)", v.y);
                Assert.AreEqual("((3-4)-4)", v.z);
                Assert.AreEqual("((8-1)1)", v.w);
            }
            {
                var ov = new gvec4<string>("1", "(11)", "((-34)2)", "");
                var v = ov.swizzle.raag;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(11)", v.w);
            }
            {
                var ov = new gvec4<string>("(4-1)", "", "((-1-4)-2)", "0");
                var v = ov.swizzle.raab;
                Assert.AreEqual("(4-1)", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("((-1-4)-2)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "((-47)6)", "(13)", "((-7-9)-8)");
                var v = ov.swizzle.raaa;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-7-9)-8)", v.y);
                Assert.AreEqual("((-7-9)-8)", v.z);
                Assert.AreEqual("((-7-9)-8)", v.w);
            }
            {
                var ov = new gvec4<string>("(27)", "", "1", "((-2-5)-4)");
                var v = ov.swizzle.gr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(27)", v.y);
            }
            {
                var ov = new gvec4<string>("((-5-6)-4)", "(92)", "", "2");
                var v = ov.swizzle.grr;
                Assert.AreEqual("(92)", v.x);
                Assert.AreEqual("((-5-6)-4)", v.y);
                Assert.AreEqual("((-5-6)-4)", v.z);
            }
            {
                var ov = new gvec4<string>("((-54)-6)", "3", null, "(-85)");
                var v = ov.swizzle.grrr;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("((-54)-6)", v.y);
                Assert.AreEqual("((-54)-6)", v.z);
                Assert.AreEqual("((-54)-6)", v.w);
            }
            {
                var ov = new gvec4<string>("((-2-2)7)", "(-5-4)", "-8", "(-13)");
                var v = ov.swizzle.grrg;
                Assert.AreEqual("(-5-4)", v.x);
                Assert.AreEqual("((-2-2)7)", v.y);
                Assert.AreEqual("((-2-2)7)", v.z);
                Assert.AreEqual("(-5-4)", v.w);
            }
            {
                var ov = new gvec4<string>("((96)6)", "", "(45)", "");
                var v = ov.swizzle.grrb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((96)6)", v.y);
                Assert.AreEqual("((96)6)", v.z);
                Assert.AreEqual("(45)", v.w);
            }
            {
                var ov = new gvec4<string>("(04)", "((-2-5)2)", "(-15)", "3");
                var v = ov.swizzle.grra;
                Assert.AreEqual("((-2-5)2)", v.x);
                Assert.AreEqual("(04)", v.y);
                Assert.AreEqual("(04)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("", "", "((-36)-6)", "((-3-4)-8)");
                var v = ov.swizzle.grg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("(-7-1)", "(64)", "-7", "((27)-4)");
                var v = ov.swizzle.grgr;
                Assert.AreEqual("(64)", v.x);
                Assert.AreEqual("(-7-1)", v.y);
                Assert.AreEqual("(64)", v.z);
                Assert.AreEqual("(-7-1)", v.w);
            }
            {
                var ov = new gvec4<string>("(-45)", "(-45)", "", "((-84)-8)");
                var v = ov.swizzle.grgg;
                Assert.AreEqual("(-45)", v.x);
                Assert.AreEqual("(-45)", v.y);
                Assert.AreEqual("(-45)", v.z);
                Assert.AreEqual("(-45)", v.w);
            }
            {
                var ov = new gvec4<string>("(8-7)", "-8", "(79)", "(79)");
                var v = ov.swizzle.grgb;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("(8-7)", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("(79)", v.w);
            }
            {
                var ov = new gvec4<string>("(4-1)", "(-28)", "3", "3");
                var v = ov.swizzle.grga;
                Assert.AreEqual("(-28)", v.x);
                Assert.AreEqual("(4-1)", v.y);
                Assert.AreEqual("(-28)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("-9", "((6-7)-8)", "(-3-5)", "5");
                var v = ov.swizzle.grb;
                Assert.AreEqual("((6-7)-8)", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("(-3-5)", v.z);
            }
            {
                var ov = new gvec4<string>("8", "((-36)-8)", "((50)-9)", "8");
                var v = ov.swizzle.grbr;
                Assert.AreEqual("((-36)-8)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("((50)-9)", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("", "8", "-6", "");
                var v = ov.swizzle.grbg;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("(-15)", "((-70)1)", "((-6-5)2)", "8");
                var v = ov.swizzle.grbb;
                Assert.AreEqual("((-70)1)", v.x);
                Assert.AreEqual("(-15)", v.y);
                Assert.AreEqual("((-6-5)2)", v.z);
                Assert.AreEqual("((-6-5)2)", v.w);
            }
            {
                var ov = new gvec4<string>("(52)", "(49)", "1", "8");
                var v = ov.swizzle.grba;
                Assert.AreEqual("(49)", v.x);
                Assert.AreEqual("(52)", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("((-1-7)-2)", "(6-4)", "((3-8)3)", null);
                var v = ov.swizzle.gra;
                Assert.AreEqual("(6-4)", v.x);
                Assert.AreEqual("((-1-7)-2)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("((74)8)", "-1", "((0-4)-2)", "(-1-5)");
                var v = ov.swizzle.grar;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("((74)8)", v.y);
                Assert.AreEqual("(-1-5)", v.z);
                Assert.AreEqual("((74)8)", v.w);
            }
            {
                var ov = new gvec4<string>("8", null, "(-3-6)", "7");
                var v = ov.swizzle.grag;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("", "4", "(83)", "(14)");
                var v = ov.swizzle.grab;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(14)", v.z);
                Assert.AreEqual("(83)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "8", "((2-8)9)", "8");
                var v = ov.swizzle.graa;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("((-6-8)-9)", "-7", "((-8-8)-4)", "(-20)");
                var v = ov.swizzle.gg;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("-7", v.y);
            }
            {
                var ov = new gvec4<string>("-8", null, "((76)-6)", "9");
                var v = ov.swizzle.ggr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-8", v.z);
            }
            {
                var ov = new gvec4<string>("((26)1)", "((26)1)", "(1-5)", "(5-7)");
                var v = ov.swizzle.ggrr;
                Assert.AreEqual("((26)1)", v.x);
                Assert.AreEqual("((26)1)", v.y);
                Assert.AreEqual("((26)1)", v.z);
                Assert.AreEqual("((26)1)", v.w);
            }
            {
                var ov = new gvec4<string>("-7", "", "((6-7)-2)", "(9-1)");
                var v = ov.swizzle.ggrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(8-1)", null, "", "((02)-3)");
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(8-1)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("-2", "((-3-2)9)", "-2", "(1-6)");
                var v = ov.swizzle.ggra;
                Assert.AreEqual("((-3-2)9)", v.x);
                Assert.AreEqual("((-3-2)9)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("(1-6)", v.w);
            }
            {
                var ov = new gvec4<string>("", "((72)4)", "((6-3)8)", "((2-4)-1)");
                var v = ov.swizzle.ggg;
                Assert.AreEqual("((72)4)", v.x);
                Assert.AreEqual("((72)4)", v.y);
                Assert.AreEqual("((72)4)", v.z);
            }
            {
                var ov = new gvec4<string>("((3-1)-5)", "((87)2)", "(-4-4)", "0");
                var v = ov.swizzle.gggr;
                Assert.AreEqual("((87)2)", v.x);
                Assert.AreEqual("((87)2)", v.y);
                Assert.AreEqual("((87)2)", v.z);
                Assert.AreEqual("((3-1)-5)", v.w);
            }
            {
                var ov = new gvec4<string>("8", "((35)-3)", "(-3-6)", "((35)-3)");
                var v = ov.swizzle.gggg;
                Assert.AreEqual("((35)-3)", v.x);
                Assert.AreEqual("((35)-3)", v.y);
                Assert.AreEqual("((35)-3)", v.z);
                Assert.AreEqual("((35)-3)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "-4", "((65)4)", null);
                var v = ov.swizzle.gggb;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("((65)4)", v.w);
            }
            {
                var ov = new gvec4<string>("-6", "-3", "-6", null);
                var v = ov.swizzle.ggga;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("7", "((-77)-8)", "((69)-3)", "7");
                var v = ov.swizzle.ggb;
                Assert.AreEqual("((-77)-8)", v.x);
                Assert.AreEqual("((-77)-8)", v.y);
                Assert.AreEqual("((69)-3)", v.z);
            }
            {
                var ov = new gvec4<string>("-5", "-5", "-5", "(15)");
                var v = ov.swizzle.ggbr;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("((6-7)6)", "3", "((95)4)", "(79)");
                var v = ov.swizzle.ggbg;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("((95)4)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("(7-5)", "", "", null);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((-4-5)6)", "((03)2)", null, "");
                var v = ov.swizzle.ggba;
                Assert.AreEqual("((03)2)", v.x);
                Assert.AreEqual("((03)2)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("6", "(03)", "", "((-1-6)0)");
                var v = ov.swizzle.gga;
                Assert.AreEqual("(03)", v.x);
                Assert.AreEqual("(03)", v.y);
                Assert.AreEqual("((-1-6)0)", v.z);
            }
            {
                var ov = new gvec4<string>("-3", null, "(-23)", "((71)-8)");
                var v = ov.swizzle.ggar;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((71)-8)", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-6)", "6", "(-7-6)", "((42)0)");
                var v = ov.swizzle.ggag;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("((42)0)", v.z);
                Assert.AreEqual("6", v.w);
            }
            {
                var ov = new gvec4<string>("(87)", "((0-8)-5)", "-5", "((0-8)-5)");
                var v = ov.swizzle.ggab;
                Assert.AreEqual("((0-8)-5)", v.x);
                Assert.AreEqual("((0-8)-5)", v.y);
                Assert.AreEqual("((0-8)-5)", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("-8", "(8-4)", "(31)", "((18)3)");
                var v = ov.swizzle.ggaa;
                Assert.AreEqual("(8-4)", v.x);
                Assert.AreEqual("(8-4)", v.y);
                Assert.AreEqual("((18)3)", v.z);
                Assert.AreEqual("((18)3)", v.w);
            }
            {
                var ov = new gvec4<string>("((-8-7)-1)", "((-3-8)5)", "(-5-6)", "(-5-6)");
                var v = ov.swizzle.gb;
                Assert.AreEqual("((-3-8)5)", v.x);
                Assert.AreEqual("(-5-6)", v.y);
            }
            {
                var ov = new gvec4<string>("((-85)-8)", "((98)7)", "((-85)-8)", "(3-7)");
                var v = ov.swizzle.gbr;
                Assert.AreEqual("((98)7)", v.x);
                Assert.AreEqual("((-85)-8)", v.y);
                Assert.AreEqual("((-85)-8)", v.z);
            }
            {
                var ov = new gvec4<string>("(72)", "((-3-3)-1)", "5", null);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual("((-3-3)-1)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("(72)", v.z);
                Assert.AreEqual("(72)", v.w);
            }
            {
                var ov = new gvec4<string>("((-20)2)", "-9", "6", "((7-1)-7)");
                var v = ov.swizzle.gbrg;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("((-20)2)", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>("((-6-2)-2)", "", "((0-6)-9)", "5");
                var v = ov.swizzle.gbrb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((0-6)-9)", v.y);
                Assert.AreEqual("((-6-2)-2)", v.z);
                Assert.AreEqual("((0-6)-9)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "((6-6)6)", null, "-2");
                var v = ov.swizzle.gbra;
                Assert.AreEqual("((6-6)6)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec4<string>("7", "(-3-5)", "((-80)8)", "7");
                var v = ov.swizzle.gbg;
                Assert.AreEqual("(-3-5)", v.x);
                Assert.AreEqual("((-80)8)", v.y);
                Assert.AreEqual("(-3-5)", v.z);
            }
            {
                var ov = new gvec4<string>(null, "((60)7)", "-4", "(12)");
                var v = ov.swizzle.gbgr;
                Assert.AreEqual("((60)7)", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("((60)7)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((-8-2)-4)", "((-48)-9)", "7", "(6-1)");
                var v = ov.swizzle.gbgg;
                Assert.AreEqual("((-48)-9)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("((-48)-9)", v.z);
                Assert.AreEqual("((-48)-9)", v.w);
            }
            {
                var ov = new gvec4<string>("((-94)1)", "(44)", "-5", "");
                var v = ov.swizzle.gbgb;
                Assert.AreEqual("(44)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(44)", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("-3", "", "(-7-9)", "6");
                var v = ov.swizzle.gbga;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(-7-9)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("6", v.w);
            }
            {
                var ov = new gvec4<string>("((32)-3)", "((32)-3)", "((09)4)", "((09)4)");
                var v = ov.swizzle.gbb;
                Assert.AreEqual("((32)-3)", v.x);
                Assert.AreEqual("((09)4)", v.y);
                Assert.AreEqual("((09)4)", v.z);
            }
            {
                var ov = new gvec4<string>("((43)6)", "(6-8)", "((43)6)", "((43)6)");
                var v = ov.swizzle.gbbr;
                Assert.AreEqual("(6-8)", v.x);
                Assert.AreEqual("((43)6)", v.y);
                Assert.AreEqual("((43)6)", v.z);
                Assert.AreEqual("((43)6)", v.w);
            }
            {
                var ov = new gvec4<string>("(-97)", "(8-1)", "(-97)", "");
                var v = ov.swizzle.gbbg;
                Assert.AreEqual("(8-1)", v.x);
                Assert.AreEqual("(-97)", v.y);
                Assert.AreEqual("(-97)", v.z);
                Assert.AreEqual("(8-1)", v.w);
            }
            {
                var ov = new gvec4<string>("3", "(6-4)", "(6-4)", "");
                var v = ov.swizzle.gbbb;
                Assert.AreEqual("(6-4)", v.x);
                Assert.AreEqual("(6-4)", v.y);
                Assert.AreEqual("(6-4)", v.z);
                Assert.AreEqual("(6-4)", v.w);
            }
            {
                var ov = new gvec4<string>("-7", null, "((-24)7)", "-7");
                var v = ov.swizzle.gbba;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-24)7)", v.y);
                Assert.AreEqual("((-24)7)", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec4<string>("((-3-2)5)", "-7", "(-81)", "((-3-2)5)");
                var v = ov.swizzle.gba;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(-81)", v.y);
                Assert.AreEqual("((-3-2)5)", v.z);
            }
            {
                var ov = new gvec4<string>("(8-7)", "(68)", "((26)-4)", "(14)");
                var v = ov.swizzle.gbar;
                Assert.AreEqual("(68)", v.x);
                Assert.AreEqual("((26)-4)", v.y);
                Assert.AreEqual("(14)", v.z);
                Assert.AreEqual("(8-7)", v.w);
            }
            {
                var ov = new gvec4<string>("((8-2)5)", "3", "4", "((-70)-1)");
                var v = ov.swizzle.gbag;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("((-70)-1)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("(44)", "(44)", "((07)9)", "4");
                var v = ov.swizzle.gbab;
                Assert.AreEqual("(44)", v.x);
                Assert.AreEqual("((07)9)", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("((07)9)", v.w);
            }
            {
                var ov = new gvec4<string>("((-13)5)", "(8-3)", "1", "(-4-8)");
                var v = ov.swizzle.gbaa;
                Assert.AreEqual("(8-3)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("(-4-8)", v.z);
                Assert.AreEqual("(-4-8)", v.w);
            }
            {
                var ov = new gvec4<string>("-6", "-6", null, "((-4-3)-4)");
                var v = ov.swizzle.ga;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("((-4-3)-4)", v.y);
            }
            {
                var ov = new gvec4<string>("((27)6)", "7", null, "(5-7)");
                var v = ov.swizzle.gar;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("(5-7)", v.y);
                Assert.AreEqual("((27)6)", v.z);
            }
            {
                var ov = new gvec4<string>("((-4-1)-4)", "((-46)-1)", "", "");
                var v = ov.swizzle.garr;
                Assert.AreEqual("((-46)-1)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-4-1)-4)", v.z);
                Assert.AreEqual("((-4-1)-4)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "", "", "8");
                var v = ov.swizzle.garg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((57)-4)", "-7", "", "(-3-4)");
                var v = ov.swizzle.garb;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(-3-4)", v.y);
                Assert.AreEqual("((57)-4)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("", "0", "", "-5");
                var v = ov.swizzle.gara;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-5)", "((-7-3)-2)", "5", "(23)");
                var v = ov.swizzle.gag;
                Assert.AreEqual("((-7-3)-2)", v.x);
                Assert.AreEqual("(23)", v.y);
                Assert.AreEqual("((-7-3)-2)", v.z);
            }
            {
                var ov = new gvec4<string>("(-5-4)", "((03)-2)", "6", "6");
                var v = ov.swizzle.gagr;
                Assert.AreEqual("((03)-2)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("((03)-2)", v.z);
                Assert.AreEqual("(-5-4)", v.w);
            }
            {
                var ov = new gvec4<string>("", "-3", "-3", "-3");
                var v = ov.swizzle.gagg;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("1", "((5-2)2)", "(2-7)", "((5-2)2)");
                var v = ov.swizzle.gagb;
                Assert.AreEqual("((5-2)2)", v.x);
                Assert.AreEqual("((5-2)2)", v.y);
                Assert.AreEqual("((5-2)2)", v.z);
                Assert.AreEqual("(2-7)", v.w);
            }
            {
                var ov = new gvec4<string>("((-36)3)", "((87)-8)", "", null);
                var v = ov.swizzle.gaga;
                Assert.AreEqual("((87)-8)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((87)-8)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((7-7)3)", null, "((6-1)-9)", "");
                var v = ov.swizzle.gab;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((6-1)-9)", v.z);
            }
            {
                var ov = new gvec4<string>("((-39)4)", "(-1-4)", "((-19)-6)", "-5");
                var v = ov.swizzle.gabr;
                Assert.AreEqual("(-1-4)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("((-19)-6)", v.z);
                Assert.AreEqual("((-39)4)", v.w);
            }
            {
                var ov = new gvec4<string>("((1-1)-3)", "((10)-9)", "((10)-9)", "(3-4)");
                var v = ov.swizzle.gabg;
                Assert.AreEqual("((10)-9)", v.x);
                Assert.AreEqual("(3-4)", v.y);
                Assert.AreEqual("((10)-9)", v.z);
                Assert.AreEqual("((10)-9)", v.w);
            }
            {
                var ov = new gvec4<string>("4", "((8-6)-2)", "((8-6)-2)", "((-4-4)0)");
                var v = ov.swizzle.gabb;
                Assert.AreEqual("((8-6)-2)", v.x);
                Assert.AreEqual("((-4-4)0)", v.y);
                Assert.AreEqual("((8-6)-2)", v.z);
                Assert.AreEqual("((8-6)-2)", v.w);
            }
            {
                var ov = new gvec4<string>("(63)", "((0-6)-1)", "((0-6)-1)", "((0-6)-1)");
                var v = ov.swizzle.gaba;
                Assert.AreEqual("((0-6)-1)", v.x);
                Assert.AreEqual("((0-6)-1)", v.y);
                Assert.AreEqual("((0-6)-1)", v.z);
                Assert.AreEqual("((0-6)-1)", v.w);
            }
            {
                var ov = new gvec4<string>("((36)0)", "((36)0)", "(-39)", "((8-7)-6)");
                var v = ov.swizzle.gaa;
                Assert.AreEqual("((36)0)", v.x);
                Assert.AreEqual("((8-7)-6)", v.y);
                Assert.AreEqual("((8-7)-6)", v.z);
            }
            {
                var ov = new gvec4<string>(null, "((-88)9)", "(-80)", "((68)9)");
                var v = ov.swizzle.gaar;
                Assert.AreEqual("((-88)9)", v.x);
                Assert.AreEqual("((68)9)", v.y);
                Assert.AreEqual("((68)9)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((5-6)4)", "-3", "-1", "((5-6)4)");
                var v = ov.swizzle.gaag;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("((5-6)4)", v.y);
                Assert.AreEqual("((5-6)4)", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("2", "(-50)", "((0-4)5)", "((-22)-8)");
                var v = ov.swizzle.gaab;
                Assert.AreEqual("(-50)", v.x);
                Assert.AreEqual("((-22)-8)", v.y);
                Assert.AreEqual("((-22)-8)", v.z);
                Assert.AreEqual("((0-4)5)", v.w);
            }
            {
                var ov = new gvec4<string>("(-25)", "((-58)8)", "((4-8)9)", "(63)");
                var v = ov.swizzle.gaaa;
                Assert.AreEqual("((-58)8)", v.x);
                Assert.AreEqual("(63)", v.y);
                Assert.AreEqual("(63)", v.z);
                Assert.AreEqual("(63)", v.w);
            }
            {
                var ov = new gvec4<string>("((79)-4)", "-7", "((-8-3)-4)", "");
                var v = ov.swizzle.br;
                Assert.AreEqual("((-8-3)-4)", v.x);
                Assert.AreEqual("((79)-4)", v.y);
            }
            {
                var ov = new gvec4<string>("(30)", "((-59)6)", null, "((-19)4)");
                var v = ov.swizzle.brr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(30)", v.y);
                Assert.AreEqual("(30)", v.z);
            }
            {
                var ov = new gvec4<string>(null, "(-77)", "(-77)", "");
                var v = ov.swizzle.brrr;
                Assert.AreEqual("(-77)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>(null, "((-96)-4)", "", "(-23)");
                var v = ov.swizzle.brrg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((-96)-4)", v.w);
            }
            {
                var ov = new gvec4<string>("((71)4)", "-9", "-9", "-4");
                var v = ov.swizzle.brrb;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((71)4)", v.y);
                Assert.AreEqual("((71)4)", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>("((-2-5)-8)", "(72)", "(-23)", "-3");
                var v = ov.swizzle.brra;
                Assert.AreEqual("(-23)", v.x);
                Assert.AreEqual("((-2-5)-8)", v.y);
                Assert.AreEqual("((-2-5)-8)", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("((72)9)", "((72)9)", "9", "((-74)-5)");
                var v = ov.swizzle.brg;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("((72)9)", v.y);
                Assert.AreEqual("((72)9)", v.z);
            }
            {
                var ov = new gvec4<string>("9", "(34)", "((6-7)-1)", "(-5-7)");
                var v = ov.swizzle.brgr;
                Assert.AreEqual("((6-7)-1)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("(34)", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "((88)1)", "-4", "-4");
                var v = ov.swizzle.brgg;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("((88)1)", v.z);
                Assert.AreEqual("((88)1)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "((-99)-4)", "-5", "(33)");
                var v = ov.swizzle.brgb;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-99)-4)", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("(8-2)", "((-27)-4)", "((-25)1)", "((-25)1)");
                var v = ov.swizzle.brga;
                Assert.AreEqual("((-25)1)", v.x);
                Assert.AreEqual("(8-2)", v.y);
                Assert.AreEqual("((-27)-4)", v.z);
                Assert.AreEqual("((-25)1)", v.w);
            }
            {
                var ov = new gvec4<string>("", "-5", "(-84)", null);
                var v = ov.swizzle.brb;
                Assert.AreEqual("(-84)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-84)", v.z);
            }
            {
                var ov = new gvec4<string>("(-26)", "((49)-3)", "(-81)", "-2");
                var v = ov.swizzle.brbr;
                Assert.AreEqual("(-81)", v.x);
                Assert.AreEqual("(-26)", v.y);
                Assert.AreEqual("(-81)", v.z);
                Assert.AreEqual("(-26)", v.w);
            }
            {
                var ov = new gvec4<string>("(33)", "((04)-3)", "6", "8");
                var v = ov.swizzle.brbg;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("(33)", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("((04)-3)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "(6-6)", "((4-3)-9)", "6");
                var v = ov.swizzle.brbb;
                Assert.AreEqual("((4-3)-9)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((4-3)-9)", v.z);
                Assert.AreEqual("((4-3)-9)", v.w);
            }
            {
                var ov = new gvec4<string>("((1-4)9)", "((9-2)-8)", "(45)", "(45)");
                var v = ov.swizzle.brba;
                Assert.AreEqual("(45)", v.x);
                Assert.AreEqual("((1-4)9)", v.y);
                Assert.AreEqual("(45)", v.z);
                Assert.AreEqual("(45)", v.w);
            }
            {
                var ov = new gvec4<string>("((-25)-7)", "(5-8)", "((8-5)1)", "(-1-8)");
                var v = ov.swizzle.bra;
                Assert.AreEqual("((8-5)1)", v.x);
                Assert.AreEqual("((-25)-7)", v.y);
                Assert.AreEqual("(-1-8)", v.z);
            }
            {
                var ov = new gvec4<string>("2", "((47)-3)", "((-12)8)", null);
                var v = ov.swizzle.brar;
                Assert.AreEqual("((-12)8)", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec4<string>("1", "1", "(-1-8)", "8");
                var v = ov.swizzle.brag;
                Assert.AreEqual("(-1-8)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec4<string>("(-8-7)", "(27)", "(-8-7)", "((-23)-3)");
                var v = ov.swizzle.brab;
                Assert.AreEqual("(-8-7)", v.x);
                Assert.AreEqual("(-8-7)", v.y);
                Assert.AreEqual("((-23)-3)", v.z);
                Assert.AreEqual("(-8-7)", v.w);
            }
            {
                var ov = new gvec4<string>("-6", null, "(19)", "((-97)-6)");
                var v = ov.swizzle.braa;
                Assert.AreEqual("(19)", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("((-97)-6)", v.z);
                Assert.AreEqual("((-97)-6)", v.w);
            }
            {
                var ov = new gvec4<string>("5", "((35)9)", "((6-2)-1)", "3");
                var v = ov.swizzle.bg;
                Assert.AreEqual("((6-2)-1)", v.x);
                Assert.AreEqual("((35)9)", v.y);
            }
            {
                var ov = new gvec4<string>("7", "7", "((-2-1)8)", "");
                var v = ov.swizzle.bgr;
                Assert.AreEqual("((-2-1)8)", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("7", v.z);
            }
            {
                var ov = new gvec4<string>("((-8-5)-9)", "(-45)", "(0-5)", null);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual("(0-5)", v.x);
                Assert.AreEqual("(-45)", v.y);
                Assert.AreEqual("((-8-5)-9)", v.z);
                Assert.AreEqual("((-8-5)-9)", v.w);
            }
            {
                var ov = new gvec4<string>("((09)0)", "(-7-8)", "(-7-8)", "((79)5)");
                var v = ov.swizzle.bgrg;
                Assert.AreEqual("(-7-8)", v.x);
                Assert.AreEqual("(-7-8)", v.y);
                Assert.AreEqual("((09)0)", v.z);
                Assert.AreEqual("(-7-8)", v.w);
            }
            {
                var ov = new gvec4<string>("((94)8)", "-3", "-3", "((94)8)");
                var v = ov.swizzle.bgrb;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("((94)8)", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec4<string>("(44)", null, "3", "(-1-9)");
                var v = ov.swizzle.bgra;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(44)", v.z);
                Assert.AreEqual("(-1-9)", v.w);
            }
            {
                var ov = new gvec4<string>("(2-8)", "(-1-1)", "(2-8)", "(-1-1)");
                var v = ov.swizzle.bgg;
                Assert.AreEqual("(2-8)", v.x);
                Assert.AreEqual("(-1-1)", v.y);
                Assert.AreEqual("(-1-1)", v.z);
            }
            {
                var ov = new gvec4<string>("5", "((-60)-3)", null, "((2-1)2)");
                var v = ov.swizzle.bggr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-60)-3)", v.y);
                Assert.AreEqual("((-60)-3)", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec4<string>("(1-1)", "((-4-4)-7)", "((-8-5)-2)", "(-70)");
                var v = ov.swizzle.bggg;
                Assert.AreEqual("((-8-5)-2)", v.x);
                Assert.AreEqual("((-4-4)-7)", v.y);
                Assert.AreEqual("((-4-4)-7)", v.z);
                Assert.AreEqual("((-4-4)-7)", v.w);
            }
            {
                var ov = new gvec4<string>("(-48)", "(08)", "(-48)", "((2-7)4)");
                var v = ov.swizzle.bggb;
                Assert.AreEqual("(-48)", v.x);
                Assert.AreEqual("(08)", v.y);
                Assert.AreEqual("(08)", v.z);
                Assert.AreEqual("(-48)", v.w);
            }
            {
                var ov = new gvec4<string>("(-94)", "2", "-2", "((-2-9)-2)");
                var v = ov.swizzle.bgga;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("((-2-9)-2)", v.w);
            }
            {
                var ov = new gvec4<string>("", "-1", "-1", "-5");
                var v = ov.swizzle.bgb;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
            }
            {
                var ov = new gvec4<string>("((-61)3)", "", "-4", "(37)");
                var v = ov.swizzle.bgbr;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("((-61)3)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "((02)-1)", "((9-5)7)", "(5-9)");
                var v = ov.swizzle.bgbg;
                Assert.AreEqual("((9-5)7)", v.x);
                Assert.AreEqual("((02)-1)", v.y);
                Assert.AreEqual("((9-5)7)", v.z);
                Assert.AreEqual("((02)-1)", v.w);
            }
            {
                var ov = new gvec4<string>("((78)-3)", "(-86)", "", "");
                var v = ov.swizzle.bgbb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(-86)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((11)-2)", "(2-9)", "((55)-3)", "((2-2)1)");
                var v = ov.swizzle.bgba;
                Assert.AreEqual("((55)-3)", v.x);
                Assert.AreEqual("(2-9)", v.y);
                Assert.AreEqual("((55)-3)", v.z);
                Assert.AreEqual("((2-2)1)", v.w);
            }
            {
                var ov = new gvec4<string>("((5-9)-8)", null, "(53)", "(53)");
                var v = ov.swizzle.bga;
                Assert.AreEqual("(53)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(53)", v.z);
            }
            {
                var ov = new gvec4<string>("1", "((3-9)-7)", "1", "((-5-3)0)");
                var v = ov.swizzle.bgar;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("((3-9)-7)", v.y);
                Assert.AreEqual("((-5-3)0)", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec4<string>("(5-7)", "(1-2)", "3", "(1-2)");
                var v = ov.swizzle.bgag;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("(1-2)", v.y);
                Assert.AreEqual("(1-2)", v.z);
                Assert.AreEqual("(1-2)", v.w);
            }
            {
                var ov = new gvec4<string>("-3", "(75)", "((47)6)", "-3");
                var v = ov.swizzle.bgab;
                Assert.AreEqual("((47)6)", v.x);
                Assert.AreEqual("(75)", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("((47)6)", v.w);
            }
            {
                var ov = new gvec4<string>("(-1-3)", "((-72)-7)", "((72)8)", "((-72)-7)");
                var v = ov.swizzle.bgaa;
                Assert.AreEqual("((72)8)", v.x);
                Assert.AreEqual("((-72)-7)", v.y);
                Assert.AreEqual("((-72)-7)", v.z);
                Assert.AreEqual("((-72)-7)", v.w);
            }
            {
                var ov = new gvec4<string>("(05)", "(-4-2)", "", "((3-8)8)");
                var v = ov.swizzle.bb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
            }
            {
                var ov = new gvec4<string>("(6-7)", "(6-5)", "-4", "((-94)7)");
                var v = ov.swizzle.bbr;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("(6-7)", v.z);
            }
            {
                var ov = new gvec4<string>("((02)-9)", "(2-1)", "((-8-5)7)", "(2-1)");
                var v = ov.swizzle.bbrr;
                Assert.AreEqual("((-8-5)7)", v.x);
                Assert.AreEqual("((-8-5)7)", v.y);
                Assert.AreEqual("((02)-9)", v.z);
                Assert.AreEqual("((02)-9)", v.w);
            }
            {
                var ov = new gvec4<string>("(-60)", "6", "((23)-7)", "-6");
                var v = ov.swizzle.bbrg;
                Assert.AreEqual("((23)-7)", v.x);
                Assert.AreEqual("((23)-7)", v.y);
                Assert.AreEqual("(-60)", v.z);
                Assert.AreEqual("6", v.w);
            }
            {
                var ov = new gvec4<string>("((-24)2)", "-8", "-8", "((8-2)3)");
                var v = ov.swizzle.bbrb;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("((-24)2)", v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec4<string>("((-8-8)1)", "-9", "(4-5)", "-4");
                var v = ov.swizzle.bbra;
                Assert.AreEqual("(4-5)", v.x);
                Assert.AreEqual("(4-5)", v.y);
                Assert.AreEqual("((-8-8)1)", v.z);
                Assert.AreEqual("-4", v.w);
            }
            {
                var ov = new gvec4<string>("((3-2)4)", "-2", "((5-4)-3)", "((3-2)4)");
                var v = ov.swizzle.bbg;
                Assert.AreEqual("((5-4)-3)", v.x);
                Assert.AreEqual("((5-4)-3)", v.y);
                Assert.AreEqual("-2", v.z);
            }
            {
                var ov = new gvec4<string>("-7", "(84)", "((-3-7)-3)", "((-9-5)8)");
                var v = ov.swizzle.bbgr;
                Assert.AreEqual("((-3-7)-3)", v.x);
                Assert.AreEqual("((-3-7)-3)", v.y);
                Assert.AreEqual("(84)", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec4<string>("(-38)", "8", "(-7-1)", "(-7-1)");
                var v = ov.swizzle.bbgg;
                Assert.AreEqual("(-7-1)", v.x);
                Assert.AreEqual("(-7-1)", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("(33)", "((-24)9)", "((0-4)-1)", "(6-4)");
                var v = ov.swizzle.bbgb;
                Assert.AreEqual("((0-4)-1)", v.x);
                Assert.AreEqual("((0-4)-1)", v.y);
                Assert.AreEqual("((-24)9)", v.z);
                Assert.AreEqual("((0-4)-1)", v.w);
            }
            {
                var ov = new gvec4<string>("(1-3)", "((1-2)7)", "((-93)-4)", "5");
                var v = ov.swizzle.bbga;
                Assert.AreEqual("((-93)-4)", v.x);
                Assert.AreEqual("((-93)-4)", v.y);
                Assert.AreEqual("((1-2)7)", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec4<string>("(-8-2)", "((5-7)5)", null, "(-5-8)");
                var v = ov.swizzle.bbb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("7", "6", "((8-8)-8)", "");
                var v = ov.swizzle.bbbr;
                Assert.AreEqual("((8-8)-8)", v.x);
                Assert.AreEqual("((8-8)-8)", v.y);
                Assert.AreEqual("((8-8)-8)", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec4<string>("(-75)", "((-61)-7)", "", "9");
                var v = ov.swizzle.bbbg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((-61)-7)", v.w);
            }
            {
                var ov = new gvec4<string>("9", "", "1", "(-9-9)");
                var v = ov.swizzle.bbbb;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("1", v.w);
            }
            {
                var ov = new gvec4<string>("", "-1", "(25)", "");
                var v = ov.swizzle.bbba;
                Assert.AreEqual("(25)", v.x);
                Assert.AreEqual("(25)", v.y);
                Assert.AreEqual("(25)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(15)", "((-7-7)9)", "((5-6)9)", "((-9-9)7)");
                var v = ov.swizzle.bba;
                Assert.AreEqual("((5-6)9)", v.x);
                Assert.AreEqual("((5-6)9)", v.y);
                Assert.AreEqual("((-9-9)7)", v.z);
            }
            {
                var ov = new gvec4<string>("8", null, "(24)", null);
                var v = ov.swizzle.bbar;
                Assert.AreEqual("(24)", v.x);
                Assert.AreEqual("(24)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("((3-8)-3)", null, "((-8-7)6)", "((3-8)-3)");
                var v = ov.swizzle.bbag;
                Assert.AreEqual("((-8-7)6)", v.x);
                Assert.AreEqual("((-8-7)6)", v.y);
                Assert.AreEqual("((3-8)-3)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("6", "((02)-1)", "", "");
                var v = ov.swizzle.bbab;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((14)5)", "((14)5)", "((42)-1)", "((14)5)");
                var v = ov.swizzle.bbaa;
                Assert.AreEqual("((42)-1)", v.x);
                Assert.AreEqual("((42)-1)", v.y);
                Assert.AreEqual("((14)5)", v.z);
                Assert.AreEqual("((14)5)", v.w);
            }
            {
                var ov = new gvec4<string>("(8-6)", "7", "((-15)4)", "");
                var v = ov.swizzle.ba;
                Assert.AreEqual("((-15)4)", v.x);
                Assert.AreEqual("", v.y);
            }
            {
                var ov = new gvec4<string>("(-2-6)", "", "((-3-7)7)", "(20)");
                var v = ov.swizzle.bar;
                Assert.AreEqual("((-3-7)7)", v.x);
                Assert.AreEqual("(20)", v.y);
                Assert.AreEqual("(-2-6)", v.z);
            }
            {
                var ov = new gvec4<string>("", "((-8-4)-4)", "-6", "(7-2)");
                var v = ov.swizzle.barr;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("(7-2)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(23)", "(28)", "", "7");
                var v = ov.swizzle.barg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("(23)", v.z);
                Assert.AreEqual("(28)", v.w);
            }
            {
                var ov = new gvec4<string>("((-1-7)8)", "((-3-1)-1)", "3", "");
                var v = ov.swizzle.barb;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-1-7)8)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("((-7-5)-6)", "-2", "7", "");
                var v = ov.swizzle.bara;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-7-5)-6)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("6", "(-42)", "(-40)", "");
                var v = ov.swizzle.bag;
                Assert.AreEqual("(-40)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-42)", v.z);
            }
            {
                var ov = new gvec4<string>("((-9-7)-3)", "-4", "(-37)", "4");
                var v = ov.swizzle.bagr;
                Assert.AreEqual("(-37)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("((-9-7)-3)", v.w);
            }
            {
                var ov = new gvec4<string>("", "-5", "", "7");
                var v = ov.swizzle.bagg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("((7-4)2)", null, "-5", null);
                var v = ov.swizzle.bagb;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("(32)", "(32)", "((-7-2)3)", null);
                var v = ov.swizzle.baga;
                Assert.AreEqual("((-7-2)3)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(32)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("-9", "", "(02)", "((-25)7)");
                var v = ov.swizzle.bab;
                Assert.AreEqual("(02)", v.x);
                Assert.AreEqual("((-25)7)", v.y);
                Assert.AreEqual("(02)", v.z);
            }
            {
                var ov = new gvec4<string>("(4-9)", "((0-1)-7)", "-1", "3");
                var v = ov.swizzle.babr;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("(4-9)", v.w);
            }
            {
                var ov = new gvec4<string>("3", "(-46)", "(03)", "(87)");
                var v = ov.swizzle.babg;
                Assert.AreEqual("(03)", v.x);
                Assert.AreEqual("(87)", v.y);
                Assert.AreEqual("(03)", v.z);
                Assert.AreEqual("(-46)", v.w);
            }
            {
                var ov = new gvec4<string>("-1", "-6", "((-7-2)-8)", "((-93)6)");
                var v = ov.swizzle.babb;
                Assert.AreEqual("((-7-2)-8)", v.x);
                Assert.AreEqual("((-93)6)", v.y);
                Assert.AreEqual("((-7-2)-8)", v.z);
                Assert.AreEqual("((-7-2)-8)", v.w);
            }
            {
                var ov = new gvec4<string>("(8-5)", "3", "((-8-3)9)", "5");
                var v = ov.swizzle.baba;
                Assert.AreEqual("((-8-3)9)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("((-8-3)9)", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec4<string>("", "-1", "((3-3)7)", "((1-1)-4)");
                var v = ov.swizzle.baa;
                Assert.AreEqual("((3-3)7)", v.x);
                Assert.AreEqual("((1-1)-4)", v.y);
                Assert.AreEqual("((1-1)-4)", v.z);
            }
            {
                var ov = new gvec4<string>("-5", "((-56)8)", "((-56)8)", "5");
                var v = ov.swizzle.baar;
                Assert.AreEqual("((-56)8)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("(-60)", "3", "", "1");
                var v = ov.swizzle.baag;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec4<string>("4", "", "-8", "4");
                var v = ov.swizzle.baab;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec4<string>("5", "5", "(-62)", "((97)7)");
                var v = ov.swizzle.baaa;
                Assert.AreEqual("(-62)", v.x);
                Assert.AreEqual("((97)7)", v.y);
                Assert.AreEqual("((97)7)", v.z);
                Assert.AreEqual("((97)7)", v.w);
            }
            {
                var ov = new gvec4<string>("(-74)", "-8", "-8", "-8");
                var v = ov.swizzle.ar;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("(-74)", v.y);
            }
            {
                var ov = new gvec4<string>("((-38)3)", "((-38)3)", "8", "((24)5)");
                var v = ov.swizzle.arr;
                Assert.AreEqual("((24)5)", v.x);
                Assert.AreEqual("((-38)3)", v.y);
                Assert.AreEqual("((-38)3)", v.z);
            }
            {
                var ov = new gvec4<string>("((13)4)", null, "((1-6)5)", "1");
                var v = ov.swizzle.arrr;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("((13)4)", v.y);
                Assert.AreEqual("((13)4)", v.z);
                Assert.AreEqual("((13)4)", v.w);
            }
            {
                var ov = new gvec4<string>("", "((39)4)", null, "(-4-9)");
                var v = ov.swizzle.arrg;
                Assert.AreEqual("(-4-9)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((39)4)", v.w);
            }
            {
                var ov = new gvec4<string>("2", "", "6", "(55)");
                var v = ov.swizzle.arrb;
                Assert.AreEqual("(55)", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("6", v.w);
            }
            {
                var ov = new gvec4<string>("-6", "9", "(-49)", null);
                var v = ov.swizzle.arra;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("7", "((9-7)-3)", "-4", "4");
                var v = ov.swizzle.arg;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("7", v.y);
                Assert.AreEqual("((9-7)-3)", v.z);
            }
            {
                var ov = new gvec4<string>("", "((44)9)", "6", "((44)9)");
                var v = ov.swizzle.argr;
                Assert.AreEqual("((44)9)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((44)9)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "-6", "(11)", "");
                var v = ov.swizzle.argg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec4<string>("8", "5", "", "(11)");
                var v = ov.swizzle.argb;
                Assert.AreEqual("(11)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((-11)-4)", "5", "((-11)-4)", null);
                var v = ov.swizzle.arga;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-11)-4)", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((8-7)9)", "4", "(94)", "");
                var v = ov.swizzle.arb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((8-7)9)", v.y);
                Assert.AreEqual("(94)", v.z);
            }
            {
                var ov = new gvec4<string>(null, "((-93)4)", "(-4-1)", "7");
                var v = ov.swizzle.arbr;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-4-1)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("-5", "-5", "8", "((-96)1)");
                var v = ov.swizzle.arbg;
                Assert.AreEqual("((-96)1)", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("(-2-3)", "5", "5", null);
                var v = ov.swizzle.arbb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-2-3)", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec4<string>("((-5-2)6)", "8", "((-40)-5)", "8");
                var v = ov.swizzle.arba;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("((-5-2)6)", v.y);
                Assert.AreEqual("((-40)-5)", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-7)", "-1", "", "(65)");
                var v = ov.swizzle.ara;
                Assert.AreEqual("(65)", v.x);
                Assert.AreEqual("(-7-7)", v.y);
                Assert.AreEqual("(65)", v.z);
            }
            {
                var ov = new gvec4<string>("((13)0)", "", "((13)0)", "-1");
                var v = ov.swizzle.arar;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("((13)0)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("((13)0)", v.w);
            }
            {
                var ov = new gvec4<string>("-5", "(-56)", "((21)1)", "-5");
                var v = ov.swizzle.arag;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("(-56)", v.w);
            }
            {
                var ov = new gvec4<string>("((-37)-9)", null, "((-93)-6)", "-7");
                var v = ov.swizzle.arab;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("((-37)-9)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("((-93)-6)", v.w);
            }
            {
                var ov = new gvec4<string>("", "", null, "");
                var v = ov.swizzle.araa;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>(null, "-7", "((-21)-2)", "(-82)");
                var v = ov.swizzle.ag;
                Assert.AreEqual("(-82)", v.x);
                Assert.AreEqual("-7", v.y);
            }
            {
                var ov = new gvec4<string>("((94)1)", "((-34)1)", "-7", "-9");
                var v = ov.swizzle.agr;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((-34)1)", v.y);
                Assert.AreEqual("((94)1)", v.z);
            }
            {
                var ov = new gvec4<string>("-8", null, "((-58)-1)", "(41)");
                var v = ov.swizzle.agrr;
                Assert.AreEqual("(41)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("-8", v.w);
            }
            {
                var ov = new gvec4<string>("6", "((-4-2)-4)", "((-35)-5)", "-3");
                var v = ov.swizzle.agrg;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("((-4-2)-4)", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("((-4-2)-4)", v.w);
            }
            {
                var ov = new gvec4<string>("(-83)", "", "-2", "4");
                var v = ov.swizzle.agrb;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-83)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec4<string>("(2-5)", "((03)-6)", "4", "(30)");
                var v = ov.swizzle.agra;
                Assert.AreEqual("(30)", v.x);
                Assert.AreEqual("((03)-6)", v.y);
                Assert.AreEqual("(2-5)", v.z);
                Assert.AreEqual("(30)", v.w);
            }
            {
                var ov = new gvec4<string>("((55)-7)", null, "((72)-5)", "(11)");
                var v = ov.swizzle.agg;
                Assert.AreEqual("(11)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("", "((-13)2)", "((-61)-8)", "(23)");
                var v = ov.swizzle.aggr;
                Assert.AreEqual("(23)", v.x);
                Assert.AreEqual("((-13)2)", v.y);
                Assert.AreEqual("((-13)2)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("(-6-9)", "((03)8)", "8", "8");
                var v = ov.swizzle.aggg;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("((03)8)", v.y);
                Assert.AreEqual("((03)8)", v.z);
                Assert.AreEqual("((03)8)", v.w);
            }
            {
                var ov = new gvec4<string>("(6-1)", "((5-3)9)", "(-4-7)", "-7");
                var v = ov.swizzle.aggb;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("((5-3)9)", v.y);
                Assert.AreEqual("((5-3)9)", v.z);
                Assert.AreEqual("(-4-7)", v.w);
            }
            {
                var ov = new gvec4<string>("", "4", "(-41)", "(-41)");
                var v = ov.swizzle.agga;
                Assert.AreEqual("(-41)", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("(-41)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "", "", "((33)-8)");
                var v = ov.swizzle.agb;
                Assert.AreEqual("((33)-8)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("(-89)", "9", "(-4-3)", "((-8-1)1)");
                var v = ov.swizzle.agbr;
                Assert.AreEqual("((-8-1)1)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("(-4-3)", v.z);
                Assert.AreEqual("(-89)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "-2", "((78)5)", "(59)");
                var v = ov.swizzle.agbg;
                Assert.AreEqual("(59)", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("((78)5)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec4<string>("", null, null, "7");
                var v = ov.swizzle.agbb;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("((67)-5)", "(43)", "-7", null);
                var v = ov.swizzle.agba;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(43)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("-1", "-1", "0", null);
                var v = ov.swizzle.aga;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("(-33)", null, "((-4-9)3)", "(-3-3)");
                var v = ov.swizzle.agar;
                Assert.AreEqual("(-3-3)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-3-3)", v.z);
                Assert.AreEqual("(-33)", v.w);
            }
            {
                var ov = new gvec4<string>("(-7-3)", "((-71)-8)", "((-5-2)9)", "");
                var v = ov.swizzle.agag;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-71)-8)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((-71)-8)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "(1-7)", "((-37)-2)", "((3-5)-7)");
                var v = ov.swizzle.agab;
                Assert.AreEqual("((3-5)-7)", v.x);
                Assert.AreEqual("(1-7)", v.y);
                Assert.AreEqual("((3-5)-7)", v.z);
                Assert.AreEqual("((-37)-2)", v.w);
            }
            {
                var ov = new gvec4<string>("-2", "((-82)-4)", "((5-2)-5)", "(-6-5)");
                var v = ov.swizzle.agaa;
                Assert.AreEqual("(-6-5)", v.x);
                Assert.AreEqual("((-82)-4)", v.y);
                Assert.AreEqual("(-6-5)", v.z);
                Assert.AreEqual("(-6-5)", v.w);
            }
            {
                var ov = new gvec4<string>("0", null, "((91)8)", "");
                var v = ov.swizzle.ab;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((91)8)", v.y);
            }
            {
                var ov = new gvec4<string>("0", "(2-6)", "((-9-5)0)", "-9");
                var v = ov.swizzle.abr;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((-9-5)0)", v.y);
                Assert.AreEqual("0", v.z);
            }
            {
                var ov = new gvec4<string>("((-3-4)1)", "((-1-9)8)", "(1-5)", "4");
                var v = ov.swizzle.abrr;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("(1-5)", v.y);
                Assert.AreEqual("((-3-4)1)", v.z);
                Assert.AreEqual("((-3-4)1)", v.w);
            }
            {
                var ov = new gvec4<string>("-4", "((9-1)-2)", "0", null);
                var v = ov.swizzle.abrg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("((9-1)-2)", v.w);
            }
            {
                var ov = new gvec4<string>("0", "((4-9)8)", "((7-4)4)", "(62)");
                var v = ov.swizzle.abrb;
                Assert.AreEqual("(62)", v.x);
                Assert.AreEqual("((7-4)4)", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("((7-4)4)", v.w);
            }
            {
                var ov = new gvec4<string>("-8", "((58)7)", "((58)7)", "");
                var v = ov.swizzle.abra;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((58)7)", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("((0-4)5)", null, "(7-2)", "(69)");
                var v = ov.swizzle.abg;
                Assert.AreEqual("(69)", v.x);
                Assert.AreEqual("(7-2)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec4<string>("0", "(-25)", "(-25)", "(1-4)");
                var v = ov.swizzle.abgr;
                Assert.AreEqual("(1-4)", v.x);
                Assert.AreEqual("(-25)", v.y);
                Assert.AreEqual("(-25)", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec4<string>("(66)", "((8-3)8)", "((-84)4)", "");
                var v = ov.swizzle.abgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-84)4)", v.y);
                Assert.AreEqual("((8-3)8)", v.z);
                Assert.AreEqual("((8-3)8)", v.w);
            }
            {
                var ov = new gvec4<string>("(3-5)", "(-69)", "((-81)-1)", "((0-5)-1)");
                var v = ov.swizzle.abgb;
                Assert.AreEqual("((0-5)-1)", v.x);
                Assert.AreEqual("((-81)-1)", v.y);
                Assert.AreEqual("(-69)", v.z);
                Assert.AreEqual("((-81)-1)", v.w);
            }
            {
                var ov = new gvec4<string>("", "((7-3)5)", "((-74)-1)", "-2");
                var v = ov.swizzle.abga;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("((-74)-1)", v.y);
                Assert.AreEqual("((7-3)5)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec4<string>("", "(6-4)", "-6", "(-4-4)");
                var v = ov.swizzle.abb;
                Assert.AreEqual("(-4-4)", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
            }
            {
                var ov = new gvec4<string>("(-22)", "-8", "(66)", "(-49)");
                var v = ov.swizzle.abbr;
                Assert.AreEqual("(-49)", v.x);
                Assert.AreEqual("(66)", v.y);
                Assert.AreEqual("(66)", v.z);
                Assert.AreEqual("(-22)", v.w);
            }
            {
                var ov = new gvec4<string>("(6-2)", "((7-8)-7)", "(-7-1)", "(6-2)");
                var v = ov.swizzle.abbg;
                Assert.AreEqual("(6-2)", v.x);
                Assert.AreEqual("(-7-1)", v.y);
                Assert.AreEqual("(-7-1)", v.z);
                Assert.AreEqual("((7-8)-7)", v.w);
            }
            {
                var ov = new gvec4<string>("((-69)-9)", "((-40)6)", "((-40)6)", "((-40)6)");
                var v = ov.swizzle.abbb;
                Assert.AreEqual("((-40)6)", v.x);
                Assert.AreEqual("((-40)6)", v.y);
                Assert.AreEqual("((-40)6)", v.z);
                Assert.AreEqual("((-40)6)", v.w);
            }
            {
                var ov = new gvec4<string>(null, "((-73)2)", "(9-7)", null);
                var v = ov.swizzle.abba;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(9-7)", v.y);
                Assert.AreEqual("(9-7)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("9", "-8", "9", "2");
                var v = ov.swizzle.aba;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("2", v.z);
            }
            {
                var ov = new gvec4<string>("(-7-2)", "((-8-7)-6)", "((2-7)-2)", "");
                var v = ov.swizzle.abar;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((2-7)-2)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-7-2)", v.w);
            }
            {
                var ov = new gvec4<string>("", "(-44)", "1", "((6-3)5)");
                var v = ov.swizzle.abag;
                Assert.AreEqual("((6-3)5)", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("((6-3)5)", v.z);
                Assert.AreEqual("(-44)", v.w);
            }
            {
                var ov = new gvec4<string>("(-9-8)", "((9-9)-1)", "9", null);
                var v = ov.swizzle.abab;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec4<string>("9", "9", "", "(-55)");
                var v = ov.swizzle.abaa;
                Assert.AreEqual("(-55)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-55)", v.z);
                Assert.AreEqual("(-55)", v.w);
            }
            {
                var ov = new gvec4<string>("(-74)", "((6-9)5)", "((-55)1)", "((-55)1)");
                var v = ov.swizzle.aa;
                Assert.AreEqual("((-55)1)", v.x);
                Assert.AreEqual("((-55)1)", v.y);
            }
            {
                var ov = new gvec4<string>("((35)0)", "(68)", "(84)", "9");
                var v = ov.swizzle.aar;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("((35)0)", v.z);
            }
            {
                var ov = new gvec4<string>(null, "((87)2)", "((87)2)", "((87)2)");
                var v = ov.swizzle.aarr;
                Assert.AreEqual("((87)2)", v.x);
                Assert.AreEqual("((87)2)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("(3-1)", "-5", "6", "-5");
                var v = ov.swizzle.aarg;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("-5", v.y);
                Assert.AreEqual("(3-1)", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec4<string>("((54)7)", "-4", "-4", "((3-6)-9)");
                var v = ov.swizzle.aarb;
                Assert.AreEqual("((3-6)-9)", v.x);
                Assert.AreEqual("((3-6)-9)", v.y);
                Assert.AreEqual("((54)7)", v.z);
                Assert.AreEqual("-4", v.w);
            }
            {
                var ov = new gvec4<string>("((28)-6)", "(11)", "4", "((4-8)6)");
                var v = ov.swizzle.aara;
                Assert.AreEqual("((4-8)6)", v.x);
                Assert.AreEqual("((4-8)6)", v.y);
                Assert.AreEqual("((28)-6)", v.z);
                Assert.AreEqual("((4-8)6)", v.w);
            }
            {
                var ov = new gvec4<string>("(83)", "((15)-3)", "8", "((-1-5)2)");
                var v = ov.swizzle.aag;
                Assert.AreEqual("((-1-5)2)", v.x);
                Assert.AreEqual("((-1-5)2)", v.y);
                Assert.AreEqual("((15)-3)", v.z);
            }
            {
                var ov = new gvec4<string>("9", "((45)-1)", "((45)-1)", "(-1-7)");
                var v = ov.swizzle.aagr;
                Assert.AreEqual("(-1-7)", v.x);
                Assert.AreEqual("(-1-7)", v.y);
                Assert.AreEqual("((45)-1)", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec4<string>("5", "", "5", "(-5-9)");
                var v = ov.swizzle.aagg;
                Assert.AreEqual("(-5-9)", v.x);
                Assert.AreEqual("(-5-9)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec4<string>("-7", "(6-6)", "((-7-5)-2)", null);
                var v = ov.swizzle.aagb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(6-6)", v.z);
                Assert.AreEqual("((-7-5)-2)", v.w);
            }
            {
                var ov = new gvec4<string>("((-39)8)", "-9", "((-39)8)", "-9");
                var v = ov.swizzle.aaga;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec4<string>(null, "((-2-2)3)", "((4-5)3)", "((-2-2)3)");
                var v = ov.swizzle.aab;
                Assert.AreEqual("((-2-2)3)", v.x);
                Assert.AreEqual("((-2-2)3)", v.y);
                Assert.AreEqual("((4-5)3)", v.z);
            }
            {
                var ov = new gvec4<string>("((-38)-3)", "((71)-4)", "((-38)-3)", "4");
                var v = ov.swizzle.aabr;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("((-38)-3)", v.z);
                Assert.AreEqual("((-38)-3)", v.w);
            }
            {
                var ov = new gvec4<string>("(-64)", null, "6", "6");
                var v = ov.swizzle.aabg;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("8", "(4-1)", "-6", null);
                var v = ov.swizzle.aabb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec4<string>("((-82)-3)", "((29)4)", "((-82)-3)", null);
                var v = ov.swizzle.aaba;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-82)-3)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec4<string>("1", "(7-5)", "-7", "");
                var v = ov.swizzle.aaa;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec4<string>("(45)", "((3-2)-6)", "((3-2)-6)", "-1");
                var v = ov.swizzle.aaar;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("(45)", v.w);
            }
            {
                var ov = new gvec4<string>("(-2-5)", "((-33)0)", null, "((-33)0)");
                var v = ov.swizzle.aaag;
                Assert.AreEqual("((-33)0)", v.x);
                Assert.AreEqual("((-33)0)", v.y);
                Assert.AreEqual("((-33)0)", v.z);
                Assert.AreEqual("((-33)0)", v.w);
            }
            {
                var ov = new gvec4<string>("((-86)4)", "(-8-9)", "((-86)4)", "((-86)4)");
                var v = ov.swizzle.aaab;
                Assert.AreEqual("((-86)4)", v.x);
                Assert.AreEqual("((-86)4)", v.y);
                Assert.AreEqual("((-86)4)", v.z);
                Assert.AreEqual("((-86)4)", v.w);
            }
            {
                var ov = new gvec4<string>("9", "(5-6)", "", "9");
                var v = ov.swizzle.aaaa;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("9", v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new gvec4<string>("", "((-48)7)", "1", "(-35)");
                var v1 = new gvec2<string>("(95)", "");
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(95)", v0.x);
                Assert.AreEqual("", v0.y);
                Assert.AreEqual("1", v0.z);
                Assert.AreEqual("(-35)", v0.w);
            
                Assert.AreEqual("", v2.x);
                Assert.AreEqual("((-48)7)", v2.y);
            }
            {
                var v0 = new gvec4<string>("((-5-3)-1)", "((-5-3)-1)", "((-2-4)-2)", "((6-6)-9)");
                var v1 = new gvec2<string>("(7-4)", "((-16)4)");
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(7-4)", v0.x);
                Assert.AreEqual("((-5-3)-1)", v0.y);
                Assert.AreEqual("((-16)4)", v0.z);
                Assert.AreEqual("((6-6)-9)", v0.w);
            
                Assert.AreEqual("((-5-3)-1)", v2.x);
                Assert.AreEqual("((-2-4)-2)", v2.y);
            }
            {
                var v0 = new gvec4<string>("((-87)-1)", "((-87)-1)", "9", "9");
                var v1 = new gvec2<string>("(0-4)", "-9");
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((-87)-1)", v0.x);
                Assert.AreEqual("(0-4)", v0.y);
                Assert.AreEqual("-9", v0.z);
                Assert.AreEqual("9", v0.w);
            
                Assert.AreEqual("((-87)-1)", v2.x);
                Assert.AreEqual("9", v2.y);
            }
            {
                var v0 = new gvec4<string>("((-6-5)4)", "", "((-6-5)4)", "(-7-5)");
                var v1 = new gvec3<string>(null, "8", "8");
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(null, v0.x);
                Assert.AreEqual("8", v0.y);
                Assert.AreEqual("8", v0.z);
                Assert.AreEqual("(-7-5)", v0.w);
            
                Assert.AreEqual("((-6-5)4)", v2.x);
                Assert.AreEqual("", v2.y);
                Assert.AreEqual("((-6-5)4)", v2.z);
            }
            {
                var v0 = new gvec4<string>("((-1-5)9)", "((4-5)-5)", "8", null);
                var v1 = new gvec2<string>("", "((57)1)");
                var v2 = v0.xw;
                v0.xw = v1;
                var v3 = v0.xw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("", v0.x);
                Assert.AreEqual("((4-5)-5)", v0.y);
                Assert.AreEqual("8", v0.z);
                Assert.AreEqual("((57)1)", v0.w);
            
                Assert.AreEqual("((-1-5)9)", v2.x);
                Assert.AreEqual(null, v2.y);
            }
            {
                var v0 = new gvec4<string>("", "(75)", "((2-9)8)", null);
                var v1 = new gvec2<string>("((-5-7)0)", "");
                var v2 = v0.yw;
                v0.yw = v1;
                var v3 = v0.yw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("", v0.x);
                Assert.AreEqual("((-5-7)0)", v0.y);
                Assert.AreEqual("((2-9)8)", v0.z);
                Assert.AreEqual("", v0.w);
            
                Assert.AreEqual("(75)", v2.x);
                Assert.AreEqual(null, v2.y);
            }
            {
                var v0 = new gvec4<string>("(27)", "-1", "-1", "(27)");
                var v1 = new gvec3<string>("", null, "-8");
                var v2 = v0.xyw;
                v0.xyw = v1;
                var v3 = v0.xyw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("", v0.x);
                Assert.AreEqual(null, v0.y);
                Assert.AreEqual("-1", v0.z);
                Assert.AreEqual("-8", v0.w);
            
                Assert.AreEqual("(27)", v2.x);
                Assert.AreEqual("-1", v2.y);
                Assert.AreEqual("(27)", v2.z);
            }
            {
                var v0 = new gvec4<string>("(4-2)", "-9", null, "((-97)5)");
                var v1 = new gvec2<string>("-8", "");
                var v2 = v0.zw;
                v0.zw = v1;
                var v3 = v0.zw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(4-2)", v0.x);
                Assert.AreEqual("-9", v0.y);
                Assert.AreEqual("-8", v0.z);
                Assert.AreEqual("", v0.w);
            
                Assert.AreEqual(null, v2.x);
                Assert.AreEqual("((-97)5)", v2.y);
            }
            {
                var v0 = new gvec4<string>("(-10)", "(78)", "((-6-7)1)", "(78)");
                var v1 = new gvec3<string>("", "(35)", "(35)");
                var v2 = v0.xzw;
                v0.xzw = v1;
                var v3 = v0.xzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("", v0.x);
                Assert.AreEqual("(78)", v0.y);
                Assert.AreEqual("(35)", v0.z);
                Assert.AreEqual("(35)", v0.w);
            
                Assert.AreEqual("(-10)", v2.x);
                Assert.AreEqual("((-6-7)1)", v2.y);
                Assert.AreEqual("(78)", v2.z);
            }
            {
                var v0 = new gvec4<string>("((6-8)0)", "(26)", "(26)", "-9");
                var v1 = new gvec3<string>("", "((-87)5)", "((-46)-7)");
                var v2 = v0.yzw;
                v0.yzw = v1;
                var v3 = v0.yzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((6-8)0)", v0.x);
                Assert.AreEqual("", v0.y);
                Assert.AreEqual("((-87)5)", v0.z);
                Assert.AreEqual("((-46)-7)", v0.w);
            
                Assert.AreEqual("(26)", v2.x);
                Assert.AreEqual("(26)", v2.y);
                Assert.AreEqual("-9", v2.z);
            }
            {
                var v0 = new gvec4<string>("(0-6)", "(-43)", "", "((-4-4)-4)");
                var v1 = new gvec4<string>("((-4-7)-7)", "-8", "(7-3)", "6");
                var v2 = v0.xyzw;
                v0.xyzw = v1;
                var v3 = v0.xyzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((-4-7)-7)", v0.x);
                Assert.AreEqual("-8", v0.y);
                Assert.AreEqual("(7-3)", v0.z);
                Assert.AreEqual("6", v0.w);
            
                Assert.AreEqual("(0-6)", v2.x);
                Assert.AreEqual("(-43)", v2.y);
                Assert.AreEqual("", v2.z);
                Assert.AreEqual("((-4-4)-4)", v2.w);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new gvec4<string>(null, "", "(6-9)", "((32)-8)");
                var v1 = "(30)";
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(30)", v0.x);
                Assert.AreEqual("", v0.y);
                Assert.AreEqual("(6-9)", v0.z);
                Assert.AreEqual("((32)-8)", v0.w);
            
                Assert.AreEqual(null, v2);
            }
            {
                var v0 = new gvec4<string>("4", "(-38)", "((54)5)", "(-66)");
                var v1 = "1";
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("4", v0.x);
                Assert.AreEqual("1", v0.y);
                Assert.AreEqual("((54)5)", v0.z);
                Assert.AreEqual("(-66)", v0.w);
            
                Assert.AreEqual("(-38)", v2);
            }
            {
                var v0 = new gvec4<string>("((6-2)-5)", "(-7-4)", "((6-2)-5)", "8");
                var v1 = new gvec2<string>("4", null);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("4", v0.x);
                Assert.AreEqual(null, v0.y);
                Assert.AreEqual("((6-2)-5)", v0.z);
                Assert.AreEqual("8", v0.w);
            
                Assert.AreEqual("((6-2)-5)", v2.x);
                Assert.AreEqual("(-7-4)", v2.y);
            }
            {
                var v0 = new gvec4<string>("((5-3)-1)", "", "8", "-5");
                var v1 = "4";
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((5-3)-1)", v0.x);
                Assert.AreEqual("", v0.y);
                Assert.AreEqual("4", v0.z);
                Assert.AreEqual("-5", v0.w);
            
                Assert.AreEqual("8", v2);
            }
            {
                var v0 = new gvec4<string>(null, "(91)", "-3", "(91)");
                var v1 = new gvec2<string>("((-5-6)-5)", "-3");
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((-5-6)-5)", v0.x);
                Assert.AreEqual("(91)", v0.y);
                Assert.AreEqual("-3", v0.z);
                Assert.AreEqual("(91)", v0.w);
            
                Assert.AreEqual(null, v2.x);
                Assert.AreEqual("-3", v2.y);
            }
            {
                var v0 = new gvec4<string>("(1-8)", "(-9-8)", "((0-6)6)", "(1-8)");
                var v1 = new gvec2<string>("((-6-6)8)", "((-6-6)8)");
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(1-8)", v0.x);
                Assert.AreEqual("((-6-6)8)", v0.y);
                Assert.AreEqual("((-6-6)8)", v0.z);
                Assert.AreEqual("(1-8)", v0.w);
            
                Assert.AreEqual("(-9-8)", v2.x);
                Assert.AreEqual("((0-6)6)", v2.y);
            }
            {
                var v0 = new gvec4<string>("((0-8)1)", "(20)", "(20)", "1");
                var v1 = new gvec3<string>("-5", "(-11)", "((-13)-4)");
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("-5", v0.x);
                Assert.AreEqual("(-11)", v0.y);
                Assert.AreEqual("((-13)-4)", v0.z);
                Assert.AreEqual("1", v0.w);
            
                Assert.AreEqual("((0-8)1)", v2.x);
                Assert.AreEqual("(20)", v2.y);
                Assert.AreEqual("(20)", v2.z);
            }
            {
                var v0 = new gvec4<string>("((9-5)7)", "(66)", "((3-4)4)", "(66)");
                var v1 = "(68)";
                var v2 = v0.a;
                v0.a = v1;
                var v3 = v0.a;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((9-5)7)", v0.x);
                Assert.AreEqual("(66)", v0.y);
                Assert.AreEqual("((3-4)4)", v0.z);
                Assert.AreEqual("(68)", v0.w);
            
                Assert.AreEqual("(66)", v2);
            }
            {
                var v0 = new gvec4<string>("((4-9)-8)", "-1", "(-9-4)", "((-91)-8)");
                var v1 = new gvec2<string>("((05)7)", "((05)7)");
                var v2 = v0.ra;
                v0.ra = v1;
                var v3 = v0.ra;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((05)7)", v0.x);
                Assert.AreEqual("-1", v0.y);
                Assert.AreEqual("(-9-4)", v0.z);
                Assert.AreEqual("((05)7)", v0.w);
            
                Assert.AreEqual("((4-9)-8)", v2.x);
                Assert.AreEqual("((-91)-8)", v2.y);
            }
            {
                var v0 = new gvec4<string>("(-4-9)", "0", "((-2-4)9)", "-9");
                var v1 = new gvec2<string>("", "8");
                var v2 = v0.ga;
                v0.ga = v1;
                var v3 = v0.ga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-4-9)", v0.x);
                Assert.AreEqual("", v0.y);
                Assert.AreEqual("((-2-4)9)", v0.z);
                Assert.AreEqual("8", v0.w);
            
                Assert.AreEqual("0", v2.x);
                Assert.AreEqual("-9", v2.y);
            }
            {
                var v0 = new gvec4<string>("((-5-1)4)", "-8", "((-4-9)6)", "(-9-7)");
                var v1 = new gvec3<string>(null, "(8-1)", "-1");
                var v2 = v0.rga;
                v0.rga = v1;
                var v3 = v0.rga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(null, v0.x);
                Assert.AreEqual("(8-1)", v0.y);
                Assert.AreEqual("((-4-9)6)", v0.z);
                Assert.AreEqual("-1", v0.w);
            
                Assert.AreEqual("((-5-1)4)", v2.x);
                Assert.AreEqual("-8", v2.y);
                Assert.AreEqual("(-9-7)", v2.z);
            }
            {
                var v0 = new gvec4<string>("(8-1)", "(3-6)", "(3-6)", "-7");
                var v1 = new gvec2<string>("", "");
                var v2 = v0.ba;
                v0.ba = v1;
                var v3 = v0.ba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(8-1)", v0.x);
                Assert.AreEqual("(3-6)", v0.y);
                Assert.AreEqual("", v0.z);
                Assert.AreEqual("", v0.w);
            
                Assert.AreEqual("(3-6)", v2.x);
                Assert.AreEqual("-7", v2.y);
            }
            {
                var v0 = new gvec4<string>("-8", "", "(-39)", null);
                var v1 = new gvec3<string>("8", "5", "((9-9)5)");
                var v2 = v0.rba;
                v0.rba = v1;
                var v3 = v0.rba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("8", v0.x);
                Assert.AreEqual("", v0.y);
                Assert.AreEqual("5", v0.z);
                Assert.AreEqual("((9-9)5)", v0.w);
            
                Assert.AreEqual("-8", v2.x);
                Assert.AreEqual("(-39)", v2.y);
                Assert.AreEqual(null, v2.z);
            }
            {
                var v0 = new gvec4<string>(null, "-3", "7", "");
                var v1 = new gvec3<string>(null, "((6-4)-5)", null);
                var v2 = v0.gba;
                v0.gba = v1;
                var v3 = v0.gba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(null, v0.x);
                Assert.AreEqual(null, v0.y);
                Assert.AreEqual("((6-4)-5)", v0.z);
                Assert.AreEqual(null, v0.w);
            
                Assert.AreEqual("-3", v2.x);
                Assert.AreEqual("7", v2.y);
                Assert.AreEqual("", v2.z);
            }
            {
                var v0 = new gvec4<string>("(88)", "(88)", "((88)8)", "((88)8)");
                var v1 = new gvec4<string>("4", "-1", "-1", "4");
                var v2 = v0.rgba;
                v0.rgba = v1;
                var v3 = v0.rgba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("4", v0.x);
                Assert.AreEqual("-1", v0.y);
                Assert.AreEqual("-1", v0.z);
                Assert.AreEqual("4", v0.w);
            
                Assert.AreEqual("(88)", v2.x);
                Assert.AreEqual("(88)", v2.y);
                Assert.AreEqual("((88)8)", v2.z);
                Assert.AreEqual("((88)8)", v2.w);
            }
        }

    }
}
