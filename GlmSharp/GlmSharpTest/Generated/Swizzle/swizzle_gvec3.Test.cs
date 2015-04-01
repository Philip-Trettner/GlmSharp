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
    public class TSwizzleVec3Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new gvec3<string>("(-31)", "0", "((-89)2)");
                var v = ov.swizzle.xx;
                Assert.AreEqual("(-31)", v.x);
                Assert.AreEqual("(-31)", v.y);
            }
            {
                var ov = new gvec3<string>("((-17)3)", "((-96)-8)", "");
                var v = ov.swizzle.xxx;
                Assert.AreEqual("((-17)3)", v.x);
                Assert.AreEqual("((-17)3)", v.y);
                Assert.AreEqual("((-17)3)", v.z);
            }
            {
                var ov = new gvec3<string>("", "-4", "-4");
                var v = ov.swizzle.xxxx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("4", "", "((22)3)");
                var v = ov.swizzle.xxxy;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("-8", "((-6-5)8)", null);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("((38)1)", "((-69)-7)", "((-69)-7)");
                var v = ov.swizzle.xxy;
                Assert.AreEqual("((38)1)", v.x);
                Assert.AreEqual("((38)1)", v.y);
                Assert.AreEqual("((-69)-7)", v.z);
            }
            {
                var ov = new gvec3<string>("((-8-4)3)", null, "((-80)8)");
                var v = ov.swizzle.xxyx;
                Assert.AreEqual("((-8-4)3)", v.x);
                Assert.AreEqual("((-8-4)3)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((-8-4)3)", v.w);
            }
            {
                var ov = new gvec3<string>("((6-2)1)", "(84)", null);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual("((6-2)1)", v.x);
                Assert.AreEqual("((6-2)1)", v.y);
                Assert.AreEqual("(84)", v.z);
                Assert.AreEqual("(84)", v.w);
            }
            {
                var ov = new gvec3<string>("((-39)-1)", "-2", "(-5-7)");
                var v = ov.swizzle.xxyz;
                Assert.AreEqual("((-39)-1)", v.x);
                Assert.AreEqual("((-39)-1)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("(-5-7)", v.w);
            }
            {
                var ov = new gvec3<string>("3", null, null);
                var v = ov.swizzle.xxz;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("", "((-7-7)9)", "((98)5)");
                var v = ov.swizzle.xxzx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((98)5)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("((96)5)", "(-3-9)", "((9-7)7)");
                var v = ov.swizzle.xxzy;
                Assert.AreEqual("((96)5)", v.x);
                Assert.AreEqual("((96)5)", v.y);
                Assert.AreEqual("((9-7)7)", v.z);
                Assert.AreEqual("(-3-9)", v.w);
            }
            {
                var ov = new gvec3<string>("(79)", "(-4-5)", "");
                var v = ov.swizzle.xxzz;
                Assert.AreEqual("(79)", v.x);
                Assert.AreEqual("(79)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>(null, "5", "(13)");
                var v = ov.swizzle.xy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("5", v.y);
            }
            {
                var ov = new gvec3<string>("((-4-5)-9)", "((5-3)2)", "((-4-5)-9)");
                var v = ov.swizzle.xyx;
                Assert.AreEqual("((-4-5)-9)", v.x);
                Assert.AreEqual("((5-3)2)", v.y);
                Assert.AreEqual("((-4-5)-9)", v.z);
            }
            {
                var ov = new gvec3<string>("-5", "6", "-5");
                var v = ov.swizzle.xyxx;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec3<string>("(8-2)", "(-4-5)", "((9-3)-7)");
                var v = ov.swizzle.xyxy;
                Assert.AreEqual("(8-2)", v.x);
                Assert.AreEqual("(-4-5)", v.y);
                Assert.AreEqual("(8-2)", v.z);
                Assert.AreEqual("(-4-5)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(96)", "-6");
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(96)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec3<string>("", "", "1");
                var v = ov.swizzle.xyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("", "4", "(-80)");
                var v = ov.swizzle.xyyx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("4", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(7-3)", "(12)", "9");
                var v = ov.swizzle.xyyy;
                Assert.AreEqual("(7-3)", v.x);
                Assert.AreEqual("(12)", v.y);
                Assert.AreEqual("(12)", v.z);
                Assert.AreEqual("(12)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(-7-7)", "(-1-5)");
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-7-7)", v.y);
                Assert.AreEqual("(-7-7)", v.z);
                Assert.AreEqual("(-1-5)", v.w);
            }
            {
                var ov = new gvec3<string>("4", "((7-8)-5)", "((94)-8)");
                var v = ov.swizzle.xyz;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("((7-8)-5)", v.y);
                Assert.AreEqual("((94)-8)", v.z);
            }
            {
                var ov = new gvec3<string>(null, "-7", "-6");
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("-5", "((-9-3)-2)", "((-9-3)-2)");
                var v = ov.swizzle.xyzy;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("((-9-3)-2)", v.y);
                Assert.AreEqual("((-9-3)-2)", v.z);
                Assert.AreEqual("((-9-3)-2)", v.w);
            }
            {
                var ov = new gvec3<string>("((15)6)", "((8-8)-1)", "4");
                var v = ov.swizzle.xyzz;
                Assert.AreEqual("((15)6)", v.x);
                Assert.AreEqual("((8-8)-1)", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("4", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(69)", "(-8-5)");
                var v = ov.swizzle.xz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-8-5)", v.y);
            }
            {
                var ov = new gvec3<string>("", null, "-2");
                var v = ov.swizzle.xzx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("-3", "", "(-2-6)");
                var v = ov.swizzle.xzxx;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("(-2-6)", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec3<string>("-3", "(3-5)", "((-6-9)-1)");
                var v = ov.swizzle.xzxy;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("((-6-9)-1)", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("(3-5)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "((30)-2)", "(-88)");
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-88)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(-88)", v.w);
            }
            {
                var ov = new gvec3<string>("0", "((4-5)8)", "(-9-9)");
                var v = ov.swizzle.xzy;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("(-9-9)", v.y);
                Assert.AreEqual("((4-5)8)", v.z);
            }
            {
                var ov = new gvec3<string>("((-34)5)", "5", "6");
                var v = ov.swizzle.xzyx;
                Assert.AreEqual("((-34)5)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("((-34)5)", v.w);
            }
            {
                var ov = new gvec3<string>("", "((-1-2)-1)", "(4-3)");
                var v = ov.swizzle.xzyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(4-3)", v.y);
                Assert.AreEqual("((-1-2)-1)", v.z);
                Assert.AreEqual("((-1-2)-1)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "-6", "((-4-9)-1)");
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-4-9)-1)", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("((-4-9)-1)", v.w);
            }
            {
                var ov = new gvec3<string>("8", "((26)-7)", "((75)4)");
                var v = ov.swizzle.xzz;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("((75)4)", v.y);
                Assert.AreEqual("((75)4)", v.z);
            }
            {
                var ov = new gvec3<string>("((02)4)", "((9-8)4)", "5");
                var v = ov.swizzle.xzzx;
                Assert.AreEqual("((02)4)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("((02)4)", v.w);
            }
            {
                var ov = new gvec3<string>("((-9-8)-7)", "", "-3");
                var v = ov.swizzle.xzzy;
                Assert.AreEqual("((-9-8)-7)", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>(null, "((-47)0)", "-6");
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("-6", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec3<string>("(-9-8)", null, "(-71)");
                var v = ov.swizzle.yx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-9-8)", v.y);
            }
            {
                var ov = new gvec3<string>("-8", "((-73)7)", "((-26)3)");
                var v = ov.swizzle.yxx;
                Assert.AreEqual("((-73)7)", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("-8", v.z);
            }
            {
                var ov = new gvec3<string>("", "(17)", "");
                var v = ov.swizzle.yxxx;
                Assert.AreEqual("(17)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>(null, "((5-5)-3)", "4");
                var v = ov.swizzle.yxxy;
                Assert.AreEqual("((5-5)-3)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((5-5)-3)", v.w);
            }
            {
                var ov = new gvec3<string>("(7-7)", "-2", "4");
                var v = ov.swizzle.yxxz;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("(7-7)", v.y);
                Assert.AreEqual("(7-7)", v.z);
                Assert.AreEqual("4", v.w);
            }
            {
                var ov = new gvec3<string>(null, "6", "-8");
                var v = ov.swizzle.yxy;
                Assert.AreEqual("6", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("6", v.z);
            }
            {
                var ov = new gvec3<string>(null, "9", "(-61)");
                var v = ov.swizzle.yxyx;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("9", "((-91)3)", "0");
                var v = ov.swizzle.yxyy;
                Assert.AreEqual("((-91)3)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("((-91)3)", v.z);
                Assert.AreEqual("((-91)3)", v.w);
            }
            {
                var ov = new gvec3<string>("(16)", "((-6-8)-5)", "-2");
                var v = ov.swizzle.yxyz;
                Assert.AreEqual("((-6-8)-5)", v.x);
                Assert.AreEqual("(16)", v.y);
                Assert.AreEqual("((-6-8)-5)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec3<string>("((18)-6)", "((18)-6)", "");
                var v = ov.swizzle.yxz;
                Assert.AreEqual("((18)-6)", v.x);
                Assert.AreEqual("((18)-6)", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("((-7-4)8)", "-9", "-9");
                var v = ov.swizzle.yxzx;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((-7-4)8)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("((-7-4)8)", v.w);
            }
            {
                var ov = new gvec3<string>("-3", "((8-8)1)", "(69)");
                var v = ov.swizzle.yxzy;
                Assert.AreEqual("((8-8)1)", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("(69)", v.z);
                Assert.AreEqual("((8-8)1)", v.w);
            }
            {
                var ov = new gvec3<string>("-3", "-8", "((-58)2)");
                var v = ov.swizzle.yxzz;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("((-58)2)", v.z);
                Assert.AreEqual("((-58)2)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "((-8-7)-8)", "2");
                var v = ov.swizzle.yy;
                Assert.AreEqual("((-8-7)-8)", v.x);
                Assert.AreEqual("((-8-7)-8)", v.y);
            }
            {
                var ov = new gvec3<string>("(-48)", "2", "7");
                var v = ov.swizzle.yyx;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("(-48)", v.z);
            }
            {
                var ov = new gvec3<string>("2", "((-3-3)-6)", "");
                var v = ov.swizzle.yyxx;
                Assert.AreEqual("((-3-3)-6)", v.x);
                Assert.AreEqual("((-3-3)-6)", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec3<string>(null, "-2", "((11)8)");
                var v = ov.swizzle.yyxy;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("-2", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(7-3)", "((-14)4)");
                var v = ov.swizzle.yyxz;
                Assert.AreEqual("(7-3)", v.x);
                Assert.AreEqual("(7-3)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((-14)4)", v.w);
            }
            {
                var ov = new gvec3<string>("4", "(-3-4)", "4");
                var v = ov.swizzle.yyy;
                Assert.AreEqual("(-3-4)", v.x);
                Assert.AreEqual("(-3-4)", v.y);
                Assert.AreEqual("(-3-4)", v.z);
            }
            {
                var ov = new gvec3<string>("((-3-9)8)", "(85)", "(-67)");
                var v = ov.swizzle.yyyx;
                Assert.AreEqual("(85)", v.x);
                Assert.AreEqual("(85)", v.y);
                Assert.AreEqual("(85)", v.z);
                Assert.AreEqual("((-3-9)8)", v.w);
            }
            {
                var ov = new gvec3<string>("((56)4)", "(-4-4)", "(1-3)");
                var v = ov.swizzle.yyyy;
                Assert.AreEqual("(-4-4)", v.x);
                Assert.AreEqual("(-4-4)", v.y);
                Assert.AreEqual("(-4-4)", v.z);
                Assert.AreEqual("(-4-4)", v.w);
            }
            {
                var ov = new gvec3<string>("", "3", "5");
                var v = ov.swizzle.yyyz;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec3<string>("((4-6)7)", "", "((4-6)7)");
                var v = ov.swizzle.yyz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((4-6)7)", v.z);
            }
            {
                var ov = new gvec3<string>("(-46)", "((8-1)-6)", "(-96)");
                var v = ov.swizzle.yyzx;
                Assert.AreEqual("((8-1)-6)", v.x);
                Assert.AreEqual("((8-1)-6)", v.y);
                Assert.AreEqual("(-96)", v.z);
                Assert.AreEqual("(-46)", v.w);
            }
            {
                var ov = new gvec3<string>("", "(-3-1)", "(-87)");
                var v = ov.swizzle.yyzy;
                Assert.AreEqual("(-3-1)", v.x);
                Assert.AreEqual("(-3-1)", v.y);
                Assert.AreEqual("(-87)", v.z);
                Assert.AreEqual("(-3-1)", v.w);
            }
            {
                var ov = new gvec3<string>("((-29)8)", "", "((31)9)");
                var v = ov.swizzle.yyzz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((31)9)", v.z);
                Assert.AreEqual("((31)9)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "", "((92)5)");
                var v = ov.swizzle.yz;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((92)5)", v.y);
            }
            {
                var ov = new gvec3<string>("9", "((48)9)", "9");
                var v = ov.swizzle.yzx;
                Assert.AreEqual("((48)9)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
            }
            {
                var ov = new gvec3<string>("((7-4)-7)", "7", null);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((7-4)-7)", v.z);
                Assert.AreEqual("((7-4)-7)", v.w);
            }
            {
                var ov = new gvec3<string>("-1", "4", null);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("4", v.w);
            }
            {
                var ov = new gvec3<string>("", "((8-7)-6)", null);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual("((8-7)-6)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("((91)-7)", "-9", "-9");
                var v = ov.swizzle.yzy;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("-9", v.z);
            }
            {
                var ov = new gvec3<string>("4", "(5-9)", "(5-9)");
                var v = ov.swizzle.yzyx;
                Assert.AreEqual("(5-9)", v.x);
                Assert.AreEqual("(5-9)", v.y);
                Assert.AreEqual("(5-9)", v.z);
                Assert.AreEqual("4", v.w);
            }
            {
                var ov = new gvec3<string>("((-84)-3)", "-1", "(-26)");
                var v = ov.swizzle.yzyy;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("(-26)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec3<string>("(4-7)", "(7-2)", "");
                var v = ov.swizzle.yzyz;
                Assert.AreEqual("(7-2)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(7-2)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(3-3)", "(-50)", "((-6-7)-7)");
                var v = ov.swizzle.yzz;
                Assert.AreEqual("(-50)", v.x);
                Assert.AreEqual("((-6-7)-7)", v.y);
                Assert.AreEqual("((-6-7)-7)", v.z);
            }
            {
                var ov = new gvec3<string>("8", "8", "-3");
                var v = ov.swizzle.yzzx;
                Assert.AreEqual("8", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec3<string>("-2", null, "((6-6)8)");
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((6-6)8)", v.y);
                Assert.AreEqual("((6-6)8)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("((37)9)", "(6-8)", null);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual("(6-8)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>(null, "", "((-88)1)");
                var v = ov.swizzle.zx;
                Assert.AreEqual("((-88)1)", v.x);
                Assert.AreEqual(null, v.y);
            }
            {
                var ov = new gvec3<string>("(93)", "((-35)8)", "");
                var v = ov.swizzle.zxx;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(93)", v.y);
                Assert.AreEqual("(93)", v.z);
            }
            {
                var ov = new gvec3<string>("-3", "(1-6)", null);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec3<string>("", "((-4-5)8)", "-7");
                var v = ov.swizzle.zxxy;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((-4-5)8)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "-5", "(4-1)");
                var v = ov.swizzle.zxxz;
                Assert.AreEqual("(4-1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(4-1)", v.w);
            }
            {
                var ov = new gvec3<string>("((17)-1)", "((-22)6)", "(-59)");
                var v = ov.swizzle.zxy;
                Assert.AreEqual("(-59)", v.x);
                Assert.AreEqual("((17)-1)", v.y);
                Assert.AreEqual("((-22)6)", v.z);
            }
            {
                var ov = new gvec3<string>("5", "(68)", "(-64)");
                var v = ov.swizzle.zxyx;
                Assert.AreEqual("(-64)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("(68)", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec3<string>("(-5-8)", null, "(-5-8)");
                var v = ov.swizzle.zxyy;
                Assert.AreEqual("(-5-8)", v.x);
                Assert.AreEqual("(-5-8)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>(null, null, "(-19)");
                var v = ov.swizzle.zxyz;
                Assert.AreEqual("(-19)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(-19)", v.w);
            }
            {
                var ov = new gvec3<string>("((-9-8)-6)", "(14)", "((89)0)");
                var v = ov.swizzle.zxz;
                Assert.AreEqual("((89)0)", v.x);
                Assert.AreEqual("((-9-8)-6)", v.y);
                Assert.AreEqual("((89)0)", v.z);
            }
            {
                var ov = new gvec3<string>("8", "-6", "((-9-8)6)");
                var v = ov.swizzle.zxzx;
                Assert.AreEqual("((-9-8)6)", v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("((-9-8)6)", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec3<string>("(03)", "((97)4)", "7");
                var v = ov.swizzle.zxzy;
                Assert.AreEqual("7", v.x);
                Assert.AreEqual("(03)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("((97)4)", v.w);
            }
            {
                var ov = new gvec3<string>("-9", "((6-6)-2)", "((-39)5)");
                var v = ov.swizzle.zxzz;
                Assert.AreEqual("((-39)5)", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("((-39)5)", v.z);
                Assert.AreEqual("((-39)5)", v.w);
            }
            {
                var ov = new gvec3<string>("-2", "((89)-2)", "((-5-2)-6)");
                var v = ov.swizzle.zy;
                Assert.AreEqual("((-5-2)-6)", v.x);
                Assert.AreEqual("((89)-2)", v.y);
            }
            {
                var ov = new gvec3<string>("", "-3", "-3");
                var v = ov.swizzle.zyx;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("7", "6", "(8-3)");
                var v = ov.swizzle.zyxx;
                Assert.AreEqual("(8-3)", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec3<string>("9", "9", "-8");
                var v = ov.swizzle.zyxy;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec3<string>("(6-4)", "(92)", "-9");
                var v = ov.swizzle.zyxz;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("(92)", v.y);
                Assert.AreEqual("(6-4)", v.z);
                Assert.AreEqual("-9", v.w);
            }
            {
                var ov = new gvec3<string>("(94)", "((95)9)", "-1");
                var v = ov.swizzle.zyy;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("((95)9)", v.y);
                Assert.AreEqual("((95)9)", v.z);
            }
            {
                var ov = new gvec3<string>("(-53)", "", null);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(-53)", v.w);
            }
            {
                var ov = new gvec3<string>("((8-9)-3)", "8", null);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("8", v.y);
                Assert.AreEqual("8", v.z);
                Assert.AreEqual("8", v.w);
            }
            {
                var ov = new gvec3<string>("((-2-9)9)", "3", "((-2-9)9)");
                var v = ov.swizzle.zyyz;
                Assert.AreEqual("((-2-9)9)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("((-2-9)9)", v.w);
            }
            {
                var ov = new gvec3<string>("(88)", "((9-3)-2)", null);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((9-3)-2)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("2", "((65)4)", "((1-6)-1)");
                var v = ov.swizzle.zyzx;
                Assert.AreEqual("((1-6)-1)", v.x);
                Assert.AreEqual("((65)4)", v.y);
                Assert.AreEqual("((1-6)-1)", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec3<string>("((-21)6)", "", "-4");
                var v = ov.swizzle.zyzy;
                Assert.AreEqual("-4", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>(null, "-3", "((64)3)");
                var v = ov.swizzle.zyzz;
                Assert.AreEqual("((64)3)", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("((64)3)", v.z);
                Assert.AreEqual("((64)3)", v.w);
            }
            {
                var ov = new gvec3<string>("((-39)-1)", "((-67)4)", "((-39)-1)");
                var v = ov.swizzle.zz;
                Assert.AreEqual("((-39)-1)", v.x);
                Assert.AreEqual("((-39)-1)", v.y);
            }
            {
                var ov = new gvec3<string>("(-7-9)", "6", "((1-3)-6)");
                var v = ov.swizzle.zzx;
                Assert.AreEqual("((1-3)-6)", v.x);
                Assert.AreEqual("((1-3)-6)", v.y);
                Assert.AreEqual("(-7-9)", v.z);
            }
            {
                var ov = new gvec3<string>("5", "((-87)-7)", "(1-1)");
                var v = ov.swizzle.zzxx;
                Assert.AreEqual("(1-1)", v.x);
                Assert.AreEqual("(1-1)", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec3<string>("((78)2)", "5", "(1-6)");
                var v = ov.swizzle.zzxy;
                Assert.AreEqual("(1-6)", v.x);
                Assert.AreEqual("(1-6)", v.y);
                Assert.AreEqual("((78)2)", v.z);
                Assert.AreEqual("5", v.w);
            }
            {
                var ov = new gvec3<string>("(1-4)", "(2-1)", null);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(1-4)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("7", "((9-4)-5)", "(-51)");
                var v = ov.swizzle.zzy;
                Assert.AreEqual("(-51)", v.x);
                Assert.AreEqual("(-51)", v.y);
                Assert.AreEqual("((9-4)-5)", v.z);
            }
            {
                var ov = new gvec3<string>("((4-5)0)", "(37)", "2");
                var v = ov.swizzle.zzyx;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("(37)", v.z);
                Assert.AreEqual("((4-5)0)", v.w);
            }
            {
                var ov = new gvec3<string>("(4-4)", "-5", "");
                var v = ov.swizzle.zzyy;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec3<string>("(-6-5)", null, "((0-2)-5)");
                var v = ov.swizzle.zzyz;
                Assert.AreEqual("((0-2)-5)", v.x);
                Assert.AreEqual("((0-2)-5)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((0-2)-5)", v.w);
            }
            {
                var ov = new gvec3<string>("((11)6)", "(9-1)", "((72)2)");
                var v = ov.swizzle.zzz;
                Assert.AreEqual("((72)2)", v.x);
                Assert.AreEqual("((72)2)", v.y);
                Assert.AreEqual("((72)2)", v.z);
            }
            {
                var ov = new gvec3<string>("((-5-3)1)", "(9-6)", "((-5-3)1)");
                var v = ov.swizzle.zzzx;
                Assert.AreEqual("((-5-3)1)", v.x);
                Assert.AreEqual("((-5-3)1)", v.y);
                Assert.AreEqual("((-5-3)1)", v.z);
                Assert.AreEqual("((-5-3)1)", v.w);
            }
            {
                var ov = new gvec3<string>("(-17)", null, "(-17)");
                var v = ov.swizzle.zzzy;
                Assert.AreEqual("(-17)", v.x);
                Assert.AreEqual("(-17)", v.y);
                Assert.AreEqual("(-17)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("", "((76)-5)", null);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new gvec3<string>("1", null, "((5-3)-2)");
                var v = ov.swizzle.rr;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
            }
            {
                var ov = new gvec3<string>(null, "(81)", "");
                var v = ov.swizzle.rrr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("((3-8)-2)", "1", "((-7-7)-6)");
                var v = ov.swizzle.rrrr;
                Assert.AreEqual("((3-8)-2)", v.x);
                Assert.AreEqual("((3-8)-2)", v.y);
                Assert.AreEqual("((3-8)-2)", v.z);
                Assert.AreEqual("((3-8)-2)", v.w);
            }
            {
                var ov = new gvec3<string>("-1", null, "((-29)7)");
                var v = ov.swizzle.rrrg;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("3", "((8-7)9)", "-3");
                var v = ov.swizzle.rrrb;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec3<string>("9", "-4", "((-15)-1)");
                var v = ov.swizzle.rrg;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("-4", v.z);
            }
            {
                var ov = new gvec3<string>(null, "-9", "");
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>(null, "-5", null);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-5", v.z);
                Assert.AreEqual("-5", v.w);
            }
            {
                var ov = new gvec3<string>("((-74)-8)", "((-49)-3)", "");
                var v = ov.swizzle.rrgb;
                Assert.AreEqual("((-74)-8)", v.x);
                Assert.AreEqual("((-74)-8)", v.y);
                Assert.AreEqual("((-49)-3)", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("", "((-38)0)", "(-46)");
                var v = ov.swizzle.rrb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-46)", v.z);
            }
            {
                var ov = new gvec3<string>("((63)-5)", "((-5-3)-6)", "");
                var v = ov.swizzle.rrbr;
                Assert.AreEqual("((63)-5)", v.x);
                Assert.AreEqual("((63)-5)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((63)-5)", v.w);
            }
            {
                var ov = new gvec3<string>("", "((5-4)-4)", "((-55)9)");
                var v = ov.swizzle.rrbg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("((-55)9)", v.z);
                Assert.AreEqual("((5-4)-4)", v.w);
            }
            {
                var ov = new gvec3<string>("", "4", null);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("((4-6)5)", "(07)", "");
                var v = ov.swizzle.rg;
                Assert.AreEqual("((4-6)5)", v.x);
                Assert.AreEqual("(07)", v.y);
            }
            {
                var ov = new gvec3<string>("((7-8)4)", "((-5-3)-6)", "(97)");
                var v = ov.swizzle.rgr;
                Assert.AreEqual("((7-8)4)", v.x);
                Assert.AreEqual("((-5-3)-6)", v.y);
                Assert.AreEqual("((7-8)4)", v.z);
            }
            {
                var ov = new gvec3<string>("-7", "(-57)", "((85)9)");
                var v = ov.swizzle.rgrr;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(-57)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec3<string>("(-7-7)", "3", "((1-4)-2)");
                var v = ov.swizzle.rgrg;
                Assert.AreEqual("(-7-7)", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual("(-7-7)", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec3<string>("(-81)", "((97)-2)", "((-94)-2)");
                var v = ov.swizzle.rgrb;
                Assert.AreEqual("(-81)", v.x);
                Assert.AreEqual("((97)-2)", v.y);
                Assert.AreEqual("(-81)", v.z);
                Assert.AreEqual("((-94)-2)", v.w);
            }
            {
                var ov = new gvec3<string>("(-24)", "((7-4)-8)", "(-13)");
                var v = ov.swizzle.rgg;
                Assert.AreEqual("(-24)", v.x);
                Assert.AreEqual("((7-4)-8)", v.y);
                Assert.AreEqual("((7-4)-8)", v.z);
            }
            {
                var ov = new gvec3<string>("((-48)-6)", "9", "");
                var v = ov.swizzle.rggr;
                Assert.AreEqual("((-48)-6)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("((-48)-6)", v.w);
            }
            {
                var ov = new gvec3<string>("(81)", "", "(81)");
                var v = ov.swizzle.rggg;
                Assert.AreEqual("(81)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("((46)-1)", "9", "");
                var v = ov.swizzle.rggb;
                Assert.AreEqual("((46)-1)", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("-5", "((75)2)", "-5");
                var v = ov.swizzle.rgb;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("((75)2)", v.y);
                Assert.AreEqual("-5", v.z);
            }
            {
                var ov = new gvec3<string>("((-6-8)7)", "((47)-3)", null);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual("((-6-8)7)", v.x);
                Assert.AreEqual("((47)-3)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("((-6-8)7)", v.w);
            }
            {
                var ov = new gvec3<string>("", "(68)", "(-6-6)");
                var v = ov.swizzle.rgbg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(68)", v.y);
                Assert.AreEqual("(-6-6)", v.z);
                Assert.AreEqual("(68)", v.w);
            }
            {
                var ov = new gvec3<string>("(-40)", "((92)0)", "((92)0)");
                var v = ov.swizzle.rgbb;
                Assert.AreEqual("(-40)", v.x);
                Assert.AreEqual("((92)0)", v.y);
                Assert.AreEqual("((92)0)", v.z);
                Assert.AreEqual("((92)0)", v.w);
            }
            {
                var ov = new gvec3<string>("(-44)", "-4", "-1");
                var v = ov.swizzle.rb;
                Assert.AreEqual("(-44)", v.x);
                Assert.AreEqual("-1", v.y);
            }
            {
                var ov = new gvec3<string>("-1", "(-2-1)", "2");
                var v = ov.swizzle.rbr;
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("-1", v.z);
            }
            {
                var ov = new gvec3<string>("0", "((-40)-4)", "((-4-7)5)");
                var v = ov.swizzle.rbrr;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("((-4-7)5)", v.y);
                Assert.AreEqual("0", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec3<string>("((60)-7)", "(3-9)", null);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual("((60)-7)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((60)-7)", v.z);
                Assert.AreEqual("(3-9)", v.w);
            }
            {
                var ov = new gvec3<string>("(38)", "7", "((03)1)");
                var v = ov.swizzle.rbrb;
                Assert.AreEqual("(38)", v.x);
                Assert.AreEqual("((03)1)", v.y);
                Assert.AreEqual("(38)", v.z);
                Assert.AreEqual("((03)1)", v.w);
            }
            {
                var ov = new gvec3<string>("-9", "(-6-6)", "((-4-6)-5)");
                var v = ov.swizzle.rbg;
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((-4-6)-5)", v.y);
                Assert.AreEqual("(-6-6)", v.z);
            }
            {
                var ov = new gvec3<string>("(9-3)", "((5-2)7)", "((-29)2)");
                var v = ov.swizzle.rbgr;
                Assert.AreEqual("(9-3)", v.x);
                Assert.AreEqual("((-29)2)", v.y);
                Assert.AreEqual("((5-2)7)", v.z);
                Assert.AreEqual("(9-3)", v.w);
            }
            {
                var ov = new gvec3<string>("", "", "(-13)");
                var v = ov.swizzle.rbgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("(-13)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(1-4)", "1", "((-37)-2)");
                var v = ov.swizzle.rbgb;
                Assert.AreEqual("(1-4)", v.x);
                Assert.AreEqual("((-37)-2)", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual("((-37)-2)", v.w);
            }
            {
                var ov = new gvec3<string>("", "((-78)2)", "((-78)2)");
                var v = ov.swizzle.rbb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("((-78)2)", v.y);
                Assert.AreEqual("((-78)2)", v.z);
            }
            {
                var ov = new gvec3<string>("0", "(-1-4)", "6");
                var v = ov.swizzle.rbbr;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("6", v.y);
                Assert.AreEqual("6", v.z);
                Assert.AreEqual("0", v.w);
            }
            {
                var ov = new gvec3<string>("(5-4)", "(-80)", "(-3-5)");
                var v = ov.swizzle.rbbg;
                Assert.AreEqual("(5-4)", v.x);
                Assert.AreEqual("(-3-5)", v.y);
                Assert.AreEqual("(-3-5)", v.z);
                Assert.AreEqual("(-80)", v.w);
            }
            {
                var ov = new gvec3<string>("(61)", "((-2-3)1)", "((-2-3)1)");
                var v = ov.swizzle.rbbb;
                Assert.AreEqual("(61)", v.x);
                Assert.AreEqual("((-2-3)1)", v.y);
                Assert.AreEqual("((-2-3)1)", v.z);
                Assert.AreEqual("((-2-3)1)", v.w);
            }
            {
                var ov = new gvec3<string>("-8", "((5-3)5)", "((-82)5)");
                var v = ov.swizzle.gr;
                Assert.AreEqual("((5-3)5)", v.x);
                Assert.AreEqual("-8", v.y);
            }
            {
                var ov = new gvec3<string>("(-8-6)", "((5-8)-8)", "-3");
                var v = ov.swizzle.grr;
                Assert.AreEqual("((5-8)-8)", v.x);
                Assert.AreEqual("(-8-6)", v.y);
                Assert.AreEqual("(-8-6)", v.z);
            }
            {
                var ov = new gvec3<string>("((-5-7)-5)", "(50)", "8");
                var v = ov.swizzle.grrr;
                Assert.AreEqual("(50)", v.x);
                Assert.AreEqual("((-5-7)-5)", v.y);
                Assert.AreEqual("((-5-7)-5)", v.z);
                Assert.AreEqual("((-5-7)-5)", v.w);
            }
            {
                var ov = new gvec3<string>("", "(0-4)", "((-6-8)-7)");
                var v = ov.swizzle.grrg;
                Assert.AreEqual("(0-4)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("(0-4)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "((57)-1)", "");
                var v = ov.swizzle.grrb;
                Assert.AreEqual("((57)-1)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>(null, "((03)-5)", "((-73)-9)");
                var v = ov.swizzle.grg;
                Assert.AreEqual("((03)-5)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((03)-5)", v.z);
            }
            {
                var ov = new gvec3<string>("(93)", null, null);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(93)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(93)", v.w);
            }
            {
                var ov = new gvec3<string>("(8-5)", "-7", "((37)-9)");
                var v = ov.swizzle.grgg;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("(8-5)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec3<string>("-3", "4", "");
                var v = ov.swizzle.grgb;
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("4", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("((-69)-2)", "((-69)-2)", "(-89)");
                var v = ov.swizzle.grb;
                Assert.AreEqual("((-69)-2)", v.x);
                Assert.AreEqual("((-69)-2)", v.y);
                Assert.AreEqual("(-89)", v.z);
            }
            {
                var ov = new gvec3<string>("(-88)", "(82)", "(-88)");
                var v = ov.swizzle.grbr;
                Assert.AreEqual("(82)", v.x);
                Assert.AreEqual("(-88)", v.y);
                Assert.AreEqual("(-88)", v.z);
                Assert.AreEqual("(-88)", v.w);
            }
            {
                var ov = new gvec3<string>("-1", "(29)", "-1");
                var v = ov.swizzle.grbg;
                Assert.AreEqual("(29)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("(29)", v.w);
            }
            {
                var ov = new gvec3<string>("((4-7)1)", "9", "(1-9)");
                var v = ov.swizzle.grbb;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("((4-7)1)", v.y);
                Assert.AreEqual("(1-9)", v.z);
                Assert.AreEqual("(1-9)", v.w);
            }
            {
                var ov = new gvec3<string>(null, null, "-8");
                var v = ov.swizzle.gg;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
            }
            {
                var ov = new gvec3<string>(null, "(4-7)", "(-43)");
                var v = ov.swizzle.ggr;
                Assert.AreEqual("(4-7)", v.x);
                Assert.AreEqual("(4-7)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("9", "9", "1");
                var v = ov.swizzle.ggrr;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec3<string>("(13)", "((20)9)", "((-3-2)-1)");
                var v = ov.swizzle.ggrg;
                Assert.AreEqual("((20)9)", v.x);
                Assert.AreEqual("((20)9)", v.y);
                Assert.AreEqual("(13)", v.z);
                Assert.AreEqual("((20)9)", v.w);
            }
            {
                var ov = new gvec3<string>("5", "-6", "");
                var v = ov.swizzle.ggrb;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("5", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(-9-3)", "((-77)9)", "(1-6)");
                var v = ov.swizzle.ggg;
                Assert.AreEqual("((-77)9)", v.x);
                Assert.AreEqual("((-77)9)", v.y);
                Assert.AreEqual("((-77)9)", v.z);
            }
            {
                var ov = new gvec3<string>("-6", "((91)2)", "-6");
                var v = ov.swizzle.gggr;
                Assert.AreEqual("((91)2)", v.x);
                Assert.AreEqual("((91)2)", v.y);
                Assert.AreEqual("((91)2)", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec3<string>("(19)", "(-22)", "(19)");
                var v = ov.swizzle.gggg;
                Assert.AreEqual("(-22)", v.x);
                Assert.AreEqual("(-22)", v.y);
                Assert.AreEqual("(-22)", v.z);
                Assert.AreEqual("(-22)", v.w);
            }
            {
                var ov = new gvec3<string>("", "1", null);
                var v = ov.swizzle.gggb;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("1", v.y);
                Assert.AreEqual("1", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("(1-6)", "((-99)-7)", "((-1-8)1)");
                var v = ov.swizzle.ggb;
                Assert.AreEqual("((-99)-7)", v.x);
                Assert.AreEqual("((-99)-7)", v.y);
                Assert.AreEqual("((-1-8)1)", v.z);
            }
            {
                var ov = new gvec3<string>("((0-4)-6)", "-6", "(71)");
                var v = ov.swizzle.ggbr;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("(71)", v.z);
                Assert.AreEqual("((0-4)-6)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(-9-5)", "((-7-1)-6)");
                var v = ov.swizzle.ggbg;
                Assert.AreEqual("(-9-5)", v.x);
                Assert.AreEqual("(-9-5)", v.y);
                Assert.AreEqual("((-7-1)-6)", v.z);
                Assert.AreEqual("(-9-5)", v.w);
            }
            {
                var ov = new gvec3<string>("((6-6)0)", "(39)", "7");
                var v = ov.swizzle.ggbb;
                Assert.AreEqual("(39)", v.x);
                Assert.AreEqual("(39)", v.y);
                Assert.AreEqual("7", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec3<string>("-7", "(9-1)", "2");
                var v = ov.swizzle.gb;
                Assert.AreEqual("(9-1)", v.x);
                Assert.AreEqual("2", v.y);
            }
            {
                var ov = new gvec3<string>("4", null, "((14)-1)");
                var v = ov.swizzle.gbr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((14)-1)", v.y);
                Assert.AreEqual("4", v.z);
            }
            {
                var ov = new gvec3<string>("((-2-4)9)", null, "((8-3)0)");
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((8-3)0)", v.y);
                Assert.AreEqual("((-2-4)9)", v.z);
                Assert.AreEqual("((-2-4)9)", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(9-4)", "(9-4)");
                var v = ov.swizzle.gbrg;
                Assert.AreEqual("(9-4)", v.x);
                Assert.AreEqual("(9-4)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("(9-4)", v.w);
            }
            {
                var ov = new gvec3<string>("(94)", "1", "((92)-9)");
                var v = ov.swizzle.gbrb;
                Assert.AreEqual("1", v.x);
                Assert.AreEqual("((92)-9)", v.y);
                Assert.AreEqual("(94)", v.z);
                Assert.AreEqual("((92)-9)", v.w);
            }
            {
                var ov = new gvec3<string>("5", "((46)-5)", "((46)-5)");
                var v = ov.swizzle.gbg;
                Assert.AreEqual("((46)-5)", v.x);
                Assert.AreEqual("((46)-5)", v.y);
                Assert.AreEqual("((46)-5)", v.z);
            }
            {
                var ov = new gvec3<string>("-7", "-7", "((0-4)-1)");
                var v = ov.swizzle.gbgr;
                Assert.AreEqual("-7", v.x);
                Assert.AreEqual("((0-4)-1)", v.y);
                Assert.AreEqual("-7", v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec3<string>("-8", "((70)2)", "-8");
                var v = ov.swizzle.gbgg;
                Assert.AreEqual("((70)2)", v.x);
                Assert.AreEqual("-8", v.y);
                Assert.AreEqual("((70)2)", v.z);
                Assert.AreEqual("((70)2)", v.w);
            }
            {
                var ov = new gvec3<string>(null, null, "-7");
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual("-7", v.w);
            }
            {
                var ov = new gvec3<string>("(-71)", "0", "((-19)4)");
                var v = ov.swizzle.gbb;
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("((-19)4)", v.y);
                Assert.AreEqual("((-19)4)", v.z);
            }
            {
                var ov = new gvec3<string>("7", "9", "((-3-8)-4)");
                var v = ov.swizzle.gbbr;
                Assert.AreEqual("9", v.x);
                Assert.AreEqual("((-3-8)-4)", v.y);
                Assert.AreEqual("((-3-8)-4)", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec3<string>("(-4-3)", "(-4-3)", "(3-4)");
                var v = ov.swizzle.gbbg;
                Assert.AreEqual("(-4-3)", v.x);
                Assert.AreEqual("(3-4)", v.y);
                Assert.AreEqual("(3-4)", v.z);
                Assert.AreEqual("(-4-3)", v.w);
            }
            {
                var ov = new gvec3<string>("9", "((17)-5)", "(-49)");
                var v = ov.swizzle.gbbb;
                Assert.AreEqual("((17)-5)", v.x);
                Assert.AreEqual("(-49)", v.y);
                Assert.AreEqual("(-49)", v.z);
                Assert.AreEqual("(-49)", v.w);
            }
            {
                var ov = new gvec3<string>("-1", "-4", "(-7-3)");
                var v = ov.swizzle.br;
                Assert.AreEqual("(-7-3)", v.x);
                Assert.AreEqual("-1", v.y);
            }
            {
                var ov = new gvec3<string>("((1-9)8)", "((1-9)8)", "(7-8)");
                var v = ov.swizzle.brr;
                Assert.AreEqual("(7-8)", v.x);
                Assert.AreEqual("((1-9)8)", v.y);
                Assert.AreEqual("((1-9)8)", v.z);
            }
            {
                var ov = new gvec3<string>(null, null, "");
                var v = ov.swizzle.brrr;
                Assert.AreEqual("", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("((3-2)1)", "9", "((3-2)1)");
                var v = ov.swizzle.brrg;
                Assert.AreEqual("((3-2)1)", v.x);
                Assert.AreEqual("((3-2)1)", v.y);
                Assert.AreEqual("((3-2)1)", v.z);
                Assert.AreEqual("9", v.w);
            }
            {
                var ov = new gvec3<string>("", "-8", "((-48)-2)");
                var v = ov.swizzle.brrb;
                Assert.AreEqual("((-48)-2)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((-48)-2)", v.w);
            }
            {
                var ov = new gvec3<string>("(-83)", "(-46)", "-3");
                var v = ov.swizzle.brg;
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("(-83)", v.y);
                Assert.AreEqual("(-46)", v.z);
            }
            {
                var ov = new gvec3<string>("-1", "(-2-3)", "((6-4)0)");
                var v = ov.swizzle.brgr;
                Assert.AreEqual("((6-4)0)", v.x);
                Assert.AreEqual("-1", v.y);
                Assert.AreEqual("(-2-3)", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec3<string>("3", null, "");
                var v = ov.swizzle.brgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("3", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("-6", "(6-9)", "-6");
                var v = ov.swizzle.brgb;
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("(6-9)", v.z);
                Assert.AreEqual("-6", v.w);
            }
            {
                var ov = new gvec3<string>("(2-2)", "(9-8)", "(50)");
                var v = ov.swizzle.brb;
                Assert.AreEqual("(50)", v.x);
                Assert.AreEqual("(2-2)", v.y);
                Assert.AreEqual("(50)", v.z);
            }
            {
                var ov = new gvec3<string>(null, null, "((-23)3)");
                var v = ov.swizzle.brbr;
                Assert.AreEqual("((-23)3)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((-23)3)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("(50)", "", "3");
                var v = ov.swizzle.brbg;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("(50)", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>(null, "(-30)", null);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>(null, "6", "((-14)-7)");
                var v = ov.swizzle.bg;
                Assert.AreEqual("((-14)-7)", v.x);
                Assert.AreEqual("6", v.y);
            }
            {
                var ov = new gvec3<string>("(-98)", "5", "-5");
                var v = ov.swizzle.bgr;
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("(-98)", v.z);
            }
            {
                var ov = new gvec3<string>(null, "(1-7)", "-2");
                var v = ov.swizzle.bgrr;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("(1-7)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("-8", "-3", "(-4-3)");
                var v = ov.swizzle.bgrg;
                Assert.AreEqual("(-4-3)", v.x);
                Assert.AreEqual("-3", v.y);
                Assert.AreEqual("-8", v.z);
                Assert.AreEqual("-3", v.w);
            }
            {
                var ov = new gvec3<string>("(-1-7)", "((05)-2)", "-2");
                var v = ov.swizzle.bgrb;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("((05)-2)", v.y);
                Assert.AreEqual("(-1-7)", v.z);
                Assert.AreEqual("-2", v.w);
            }
            {
                var ov = new gvec3<string>("(-35)", "", "-8");
                var v = ov.swizzle.bgg;
                Assert.AreEqual("-8", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
            }
            {
                var ov = new gvec3<string>("((6-4)-6)", "((-2-8)0)", "((9-1)2)");
                var v = ov.swizzle.bggr;
                Assert.AreEqual("((9-1)2)", v.x);
                Assert.AreEqual("((-2-8)0)", v.y);
                Assert.AreEqual("((-2-8)0)", v.z);
                Assert.AreEqual("((6-4)-6)", v.w);
            }
            {
                var ov = new gvec3<string>("((9-7)7)", "(-53)", "(-89)");
                var v = ov.swizzle.bggg;
                Assert.AreEqual("(-89)", v.x);
                Assert.AreEqual("(-53)", v.y);
                Assert.AreEqual("(-53)", v.z);
                Assert.AreEqual("(-53)", v.w);
            }
            {
                var ov = new gvec3<string>("(24)", "9", "");
                var v = ov.swizzle.bggb;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("9", v.y);
                Assert.AreEqual("9", v.z);
                Assert.AreEqual("", v.w);
            }
            {
                var ov = new gvec3<string>("(81)", "((4-2)-8)", null);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((4-2)-8)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var ov = new gvec3<string>("(-72)", "((-21)2)", "-2");
                var v = ov.swizzle.bgbr;
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("((-21)2)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("(-72)", v.w);
            }
            {
                var ov = new gvec3<string>("(-96)", "((-87)-8)", "(-71)");
                var v = ov.swizzle.bgbg;
                Assert.AreEqual("(-71)", v.x);
                Assert.AreEqual("((-87)-8)", v.y);
                Assert.AreEqual("(-71)", v.z);
                Assert.AreEqual("((-87)-8)", v.w);
            }
            {
                var ov = new gvec3<string>("((4-2)0)", "", "3");
                var v = ov.swizzle.bgbb;
                Assert.AreEqual("3", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("3", v.z);
                Assert.AreEqual("3", v.w);
            }
            {
                var ov = new gvec3<string>("3", "((-72)2)", "(-58)");
                var v = ov.swizzle.bb;
                Assert.AreEqual("(-58)", v.x);
                Assert.AreEqual("(-58)", v.y);
            }
            {
                var ov = new gvec3<string>("(-7-1)", "", null);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(-7-1)", v.z);
            }
            {
                var ov = new gvec3<string>("((99)-4)", "(73)", null);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("((99)-4)", v.z);
                Assert.AreEqual("((99)-4)", v.w);
            }
            {
                var ov = new gvec3<string>("", null, "(6-8)");
                var v = ov.swizzle.bbrg;
                Assert.AreEqual("(6-8)", v.x);
                Assert.AreEqual("(6-8)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("-2", "((-95)-7)", "((-95)-7)");
                var v = ov.swizzle.bbrb;
                Assert.AreEqual("((-95)-7)", v.x);
                Assert.AreEqual("((-95)-7)", v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual("((-95)-7)", v.w);
            }
            {
                var ov = new gvec3<string>("", "((4-6)-2)", "(-7-2)");
                var v = ov.swizzle.bbg;
                Assert.AreEqual("(-7-2)", v.x);
                Assert.AreEqual("(-7-2)", v.y);
                Assert.AreEqual("((4-6)-2)", v.z);
            }
            {
                var ov = new gvec3<string>("7", "-9", null);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("7", v.w);
            }
            {
                var ov = new gvec3<string>("((5-9)-7)", "(-42)", "");
                var v = ov.swizzle.bbgg;
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("(-42)", v.z);
                Assert.AreEqual("(-42)", v.w);
            }
            {
                var ov = new gvec3<string>("((86)9)", "-2", null);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("-2", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var ov = new gvec3<string>("(-7-5)", "-3", "(-3-7)");
                var v = ov.swizzle.bbb;
                Assert.AreEqual("(-3-7)", v.x);
                Assert.AreEqual("(-3-7)", v.y);
                Assert.AreEqual("(-3-7)", v.z);
            }
            {
                var ov = new gvec3<string>("-1", "((-9-5)6)", "2");
                var v = ov.swizzle.bbbr;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("-1", v.w);
            }
            {
                var ov = new gvec3<string>("(44)", "2", "2");
                var v = ov.swizzle.bbbg;
                Assert.AreEqual("2", v.x);
                Assert.AreEqual("2", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("2", v.w);
            }
            {
                var ov = new gvec3<string>("((-9-5)5)", "(-5-3)", null);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new gvec3<string>("((9-8)-1)", "0", "((3-1)1)");
                var v1 = new gvec2<string>("((-42)1)", "-1");
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((-42)1)", v0.x);
                Assert.AreEqual("-1", v0.y);
                Assert.AreEqual("((3-1)1)", v0.z);
            
                Assert.AreEqual("((9-8)-1)", v2.x);
                Assert.AreEqual("0", v2.y);
            }
            {
                var v0 = new gvec3<string>("(96)", null, "(93)");
                var v1 = new gvec2<string>("", "((9-3)-2)");
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("", v0.x);
                Assert.AreEqual(null, v0.y);
                Assert.AreEqual("((9-3)-2)", v0.z);
            
                Assert.AreEqual("(96)", v2.x);
                Assert.AreEqual("(93)", v2.y);
            }
            {
                var v0 = new gvec3<string>("(-3-1)", "((93)-2)", "((0-1)1)");
                var v1 = new gvec2<string>("1", null);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-3-1)", v0.x);
                Assert.AreEqual("1", v0.y);
                Assert.AreEqual(null, v0.z);
            
                Assert.AreEqual("((93)-2)", v2.x);
                Assert.AreEqual("((0-1)1)", v2.y);
            }
            {
                var v0 = new gvec3<string>("3", "(8-7)", "-2");
                var v1 = new gvec3<string>("(-7-1)", "", "((-20)8)");
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-7-1)", v0.x);
                Assert.AreEqual("", v0.y);
                Assert.AreEqual("((-20)8)", v0.z);
            
                Assert.AreEqual("3", v2.x);
                Assert.AreEqual("(8-7)", v2.y);
                Assert.AreEqual("-2", v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new gvec3<string>("9", "((-3-2)4)", "-2");
                var v1 = "((-1-4)5)";
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((-1-4)5)", v0.x);
                Assert.AreEqual("((-3-2)4)", v0.y);
                Assert.AreEqual("-2", v0.z);
            
                Assert.AreEqual("9", v2);
            }
            {
                var v0 = new gvec3<string>("5", "(-25)", null);
                var v1 = "2";
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("5", v0.x);
                Assert.AreEqual("2", v0.y);
                Assert.AreEqual(null, v0.z);
            
                Assert.AreEqual("(-25)", v2);
            }
            {
                var v0 = new gvec3<string>("(-6-3)", "((57)3)", "(2-5)");
                var v1 = new gvec2<string>(null, "-7");
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(null, v0.x);
                Assert.AreEqual("-7", v0.y);
                Assert.AreEqual("(2-5)", v0.z);
            
                Assert.AreEqual("(-6-3)", v2.x);
                Assert.AreEqual("((57)3)", v2.y);
            }
            {
                var v0 = new gvec3<string>(null, "(68)", "-4");
                var v1 = "((-17)-5)";
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(null, v0.x);
                Assert.AreEqual("(68)", v0.y);
                Assert.AreEqual("((-17)-5)", v0.z);
            
                Assert.AreEqual("-4", v2);
            }
            {
                var v0 = new gvec3<string>(null, "(-52)", "(-5-9)");
                var v1 = new gvec2<string>("((-16)-6)", "(08)");
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((-16)-6)", v0.x);
                Assert.AreEqual("(-52)", v0.y);
                Assert.AreEqual("(08)", v0.z);
            
                Assert.AreEqual(null, v2.x);
                Assert.AreEqual("(-5-9)", v2.y);
            }
            {
                var v0 = new gvec3<string>("((0-1)6)", "-1", null);
                var v1 = new gvec2<string>("(-1-2)", "8");
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("((0-1)6)", v0.x);
                Assert.AreEqual("(-1-2)", v0.y);
                Assert.AreEqual("8", v0.z);
            
                Assert.AreEqual("-1", v2.x);
                Assert.AreEqual(null, v2.y);
            }
            {
                var v0 = new gvec3<string>("((-84)-8)", "((-97)0)", "(-4-8)");
                var v1 = new gvec3<string>("(-1-4)", "-8", "(-88)");
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual("(-1-4)", v0.x);
                Assert.AreEqual("-8", v0.y);
                Assert.AreEqual("(-88)", v0.z);
            
                Assert.AreEqual("((-84)-8)", v2.x);
                Assert.AreEqual("((-97)0)", v2.y);
                Assert.AreEqual("(-4-8)", v2.z);
            }
        }

    }
}
