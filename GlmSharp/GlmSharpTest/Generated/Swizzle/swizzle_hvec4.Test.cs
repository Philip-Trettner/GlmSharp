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
    public class HalfSwizzleVec4Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new hvec4(new Half(-7), new Half(8.5), new Half(-2), new Half(-9.5));
                var v = ov.swizzle.xx;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-7), v.y);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-4.5), new Half(-1), new Half(-1.5));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-6), v.z);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-4), new Half(9), new Half(-4));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(1.5), new Half(5.5), new Half(-5));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(4), new Half(-9), new Half(9));
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(-0.5), new Half(8), new Half(-6));
                var v = ov.swizzle.xxxw;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-4), new Half(-7), new Half(-5.5));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-4), v.z);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-7.5), new Half(8.5), Half.Zero);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(-8), new Half(-1), Half.One);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(-2.5), new Half(2.5), new Half(-3.5));
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(-7), new Half(-9.5), new Half(7));
                var v = ov.swizzle.xxyw;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(2.5), new Half(-7), new Half(-2.5));
                var v = ov.swizzle.xxz;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-7), v.z);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(3), new Half(-1.5), new Half(-1));
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(3), new Half(-7), new Half(-2.5));
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(5.5), new Half(4), Half.One);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-3.5), new Half(8), new Half(8));
                var v = ov.swizzle.xxzw;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(9), new Half(-9.5), new Half(-6.5));
                var v = ov.swizzle.xxw;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(4.5), new Half(2.5), new Half(2));
                var v = ov.swizzle.xxwx;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(2.5), new Half(-7), new Half(-8));
                var v = ov.swizzle.xxwy;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), Half.One, new Half(8.5), new Half(-6.5));
                var v = ov.swizzle.xxwz;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(0.5), new Half(2.5), new Half(-5));
                var v = ov.swizzle.xxww;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(-2.5), new Half(8), new Half(0.5));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
            }
            {
                var ov = new hvec4(Half.One, new Half(-5.5), new Half(-2), new Half(-2.5));
                var v = ov.swizzle.xyx;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(Half.One, v.z);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(0.5), new Half(-8), new Half(6));
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-1), new Half(1.5), new Half(7));
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(4.5), new Half(6), new Half(7.5));
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(-4.5), new Half(8.5), new Half(8.5));
                var v = ov.swizzle.xyxw;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(9.5), new Half(-7), new Half(-1.5));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(-8.5), new Half(4), new Half(-7));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(3.5), new Half(3.5), new Half(-4), new Half(-1.5));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-0.5), new Half(-7.5), new Half(6.5));
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(5), new Half(-9.5), new Half(-7.5));
                var v = ov.swizzle.xyyw;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(9), new Half(9), new Half(8.5));
                var v = ov.swizzle.xyz;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9), v.z);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(1.5), new Half(-1), new Half(2));
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(4.5), new Half(4), new Half(8));
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(-1), new Half(2), Half.One);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-5.5), new Half(0.5), new Half(2));
                var v = ov.swizzle.xyzw;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), Half.Zero, new Half(-3), new Half(-4));
                var v = ov.swizzle.xyw;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(-4), v.z);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(3), new Half(7), new Half(-6.5));
                var v = ov.swizzle.xywx;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(-1), new Half(-5), new Half(5));
                var v = ov.swizzle.xywy;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-6), new Half(-5.5), new Half(-7));
                var v = ov.swizzle.xywz;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(-8), new Half(-7), new Half(5));
                var v = ov.swizzle.xyww;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), Half.One, new Half(4.5), new Half(9.5));
                var v = ov.swizzle.xz;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(5), new Half(9.5), new Half(0.5));
                var v = ov.swizzle.xzx;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(-9.5), new Half(-0.5), new Half(8.5));
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
                Assert.AreEqual(new Half(-2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(-7), new Half(6.5), new Half(-4));
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(6.5), Half.One, new Half(6));
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(-2.5), new Half(1.5), new Half(-3));
                var v = ov.swizzle.xzxw;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(9.5), new Half(3), new Half(-3));
                var v = ov.swizzle.xzy;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(-3.5), new Half(-2), new Half(-0.5));
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-4.5), new Half(2.5), new Half(-5.5));
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-4), new Half(-4.5), new Half(1.5));
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(3), new Half(-7), new Half(6.5), new Half(2.5));
                var v = ov.swizzle.xzyw;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-7), new Half(0.5), new Half(-1.5));
                var v = ov.swizzle.xzz;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(-1), new Half(-9.5), new Half(3.5));
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(9), new Half(-7.5), new Half(-6.5));
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(9), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(-8.5), new Half(-9.5), new Half(0.5));
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(-2.5), new Half(4), Half.One);
                var v = ov.swizzle.xzzw;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec4(new Half(8), Half.Zero, new Half(2.5), new Half(0.5));
                var v = ov.swizzle.xzw;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-2), new Half(6), new Half(-5.5));
                var v = ov.swizzle.xzwx;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(-1), new Half(3), new Half(6));
                var v = ov.swizzle.xzwy;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(8.5), new Half(1.5), new Half(2));
                var v = ov.swizzle.xzwz;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-6), new Half(2.5), new Half(-5));
                var v = ov.swizzle.xzww;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-8), new Half(-3), new Half(6.5));
                var v = ov.swizzle.xw;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
            }
            {
                var ov = new hvec4(new Half(2), new Half(8), new Half(-3), new Half(-3.5));
                var v = ov.swizzle.xwx;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
            }
            {
                var ov = new hvec4(new Half(3.5), new Half(5.5), new Half(0.5), new Half(-7));
                var v = ov.swizzle.xwxx;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(5.5), new Half(-6.5), new Half(-8.5));
                var v = ov.swizzle.xwxy;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), Half.Zero, new Half(2), new Half(7));
                var v = ov.swizzle.xwxz;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(5.5), new Half(-6.5), new Half(5));
                var v = ov.swizzle.xwxw;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-6), new Half(1.5), new Half(-2));
                var v = ov.swizzle.xwy;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-6), v.z);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-8), new Half(-7.5), new Half(-3.5));
                var v = ov.swizzle.xwyx;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(-0.5), new Half(5.5), new Half(0.5));
                var v = ov.swizzle.xwyy;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(5.5), new Half(-2.5), new Half(-6));
                var v = ov.swizzle.xwyz;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(-2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(-8.5), new Half(0.5), new Half(-6));
                var v = ov.swizzle.xwyw;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(-3.5), new Half(4.5), new Half(6.5));
                var v = ov.swizzle.xwz;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(9), new Half(-8), new Half(7));
                var v = ov.swizzle.xwzx;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-5.5), new Half(-1), new Half(9));
                var v = ov.swizzle.xwzy;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(6), new Half(-0.5), new Half(-2.5));
                var v = ov.swizzle.xwzz;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), Half.Zero, new Half(5.5), new Half(-6));
                var v = ov.swizzle.xwzw;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(3), new Half(-7.5), new Half(-6.5));
                var v = ov.swizzle.xww;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(3.5), new Half(3.5), new Half(-0.5));
                var v = ov.swizzle.xwwx;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-2.5), new Half(8), new Half(-6.5));
                var v = ov.swizzle.xwwy;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(-2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(6), new Half(-4.5), new Half(-9.5));
                var v = ov.swizzle.xwwz;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(4.5), new Half(6.5), new Half(-8.5));
                var v = ov.swizzle.xwww;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(-4), new Half(-4), new Half(9));
                var v = ov.swizzle.yx;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(-4.5), new Half(5.5), new Half(-8.5));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
            }
            {
                var ov = new hvec4(new Half(5), Half.Zero, new Half(8.5), new Half(8.5));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-5), new Half(2), new Half(-7));
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(3), new Half(-1), new Half(6.5), new Half(-7.5));
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-1.5), new Half(3.5), new Half(-3.5));
                var v = ov.swizzle.yxxw;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(-1.5), new Half(4), new Half(-1.5));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(9), new Half(5), new Half(-6.5));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-5), new Half(-6), new Half(8.5));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-2), new Half(4), new Half(-5));
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(-3), new Half(-6.5), new Half(-4));
                var v = ov.swizzle.yxyw;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-4), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-1), new Half(8.5), new Half(0.5));
                var v = ov.swizzle.yxz;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
            }
            {
                var ov = new hvec4(new Half(3), new Half(8), new Half(-6), new Half(-1));
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(-5), new Half(4), new Half(-2));
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(-1.5), new Half(5.5), new Half(0.5));
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(6), new Half(9.5), new Half(6.5));
                var v = ov.swizzle.yxzw;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(-5), new Half(3.5), new Half(-1));
                var v = ov.swizzle.yxw;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(-1), v.z);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(3), new Half(-2.5), new Half(2.5));
                var v = ov.swizzle.yxwx;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-7.5), new Half(-5.5), new Half(2));
                var v = ov.swizzle.yxwy;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-9.5), new Half(7.5), new Half(3));
                var v = ov.swizzle.yxwz;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(-5), new Half(-4.5), new Half(-3));
                var v = ov.swizzle.yxww;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(3.5), new Half(5.5), new Half(-4.5), new Half(-0.5));
                var v = ov.swizzle.yy;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
            }
            {
                var ov = new hvec4(new Half(9), new Half(4), new Half(-8), Half.One);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(9), v.z);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-5), new Half(4.5), new Half(2.5));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-3.5), new Half(-9), new Half(-4));
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-2.5), new Half(0.5), new Half(9.5));
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(-5.5), new Half(4), new Half(-7));
                var v = ov.swizzle.yyxw;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(2), new Half(6), Half.Zero);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(2), v.z);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(1.5), Half.Zero, new Half(5));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(-3.5), new Half(3), new Half(9.5));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(4), Half.Zero, new Half(5.5));
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(-4.5), new Half(-5), new Half(1.5));
                var v = ov.swizzle.yyyw;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(1.5), new Half(-0.5), new Half(-9));
                var v = ov.swizzle.yyz;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-5.5), new Half(-3.5), new Half(2));
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(-4.5), new Half(2.5), new Half(8));
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(7), new Half(8.5), new Half(7));
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(-8), new Half(-2), new Half(-3.5));
                var v = ov.swizzle.yyzw;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-0.5), new Half(-1), new Half(-1.5));
                var v = ov.swizzle.yyw;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(-9.5), new Half(-6.5), new Half(-3));
                var v = ov.swizzle.yywx;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(5.5), new Half(-4), new Half(6.5));
                var v = ov.swizzle.yywy;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(-3), new Half(0.5), new Half(9.5));
                var v = ov.swizzle.yywz;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-2.5), new Half(9.5), new Half(6));
                var v = ov.swizzle.yyww;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(8.5), new Half(-8.5), new Half(5.5));
                var v = ov.swizzle.yz;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(5.5), new Half(8), new Half(-7.5));
                var v = ov.swizzle.yzx;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
            }
            {
                var ov = new hvec4(new Half(6), new Half(2.5), new Half(7.5), new Half(7));
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-0.5), new Half(-8), new Half(7.5));
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), Half.One, new Half(5.5), new Half(-8.5));
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-4), new Half(-5), new Half(-1.5));
                var v = ov.swizzle.yzxw;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(5.5), new Half(8.5), new Half(-7));
                var v = ov.swizzle.yzy;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(8.5), new Half(5.5), new Half(-1));
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(4), new Half(-8.5), new Half(-5));
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-5), new Half(3.5), new Half(-1.5));
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), Half.Zero, new Half(5), new Half(4.5));
                var v = ov.swizzle.yzyw;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(5), new Half(-7.5), new Half(-8.5));
                var v = ov.swizzle.yzz;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(2.5), new Half(-9), new Half(-2));
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(-8), new Half(5), new Half(1.5));
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(2.5), new Half(-5.5), new Half(8.5));
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(1.5), new Half(4), new Half(8));
                var v = ov.swizzle.yzzw;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(-3.5), new Half(-0.5), new Half(8));
                var v = ov.swizzle.yzw;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(8), v.z);
            }
            {
                var ov = new hvec4(new Half(7), new Half(2), new Half(-0.5), new Half(5));
                var v = ov.swizzle.yzwx;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(7), new Half(9), new Half(9.5));
                var v = ov.swizzle.yzwy;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-9.5), new Half(0.5), new Half(5));
                var v = ov.swizzle.yzwz;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-8), new Half(-7.5), new Half(-4.5));
                var v = ov.swizzle.yzww;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(-5.5), new Half(-9), new Half(9.5));
                var v = ov.swizzle.yw;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(0.5), new Half(1.5), new Half(-6));
                var v = ov.swizzle.ywx;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(5.5), new Half(1.5), new Half(-9.5));
                var v = ov.swizzle.ywxx;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(7.5), new Half(7.5), new Half(-2));
                var v = ov.swizzle.ywxy;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-4), new Half(-4), new Half(2.5));
                var v = ov.swizzle.ywxz;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(-4), v.w);
            }
            {
                var ov = new hvec4(new Half(3), new Half(-3), new Half(3), new Half(-5.5));
                var v = ov.swizzle.ywxw;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(5), new Half(-6.5), new Half(3));
                var v = ov.swizzle.ywy;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(5), v.z);
            }
            {
                var ov = new hvec4(new Half(2), new Half(-9), new Half(-4.5), new Half(-9));
                var v = ov.swizzle.ywyx;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(-9.5), new Half(-1.5), new Half(-4));
                var v = ov.swizzle.ywyy;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(0.5), new Half(-1), new Half(-7));
                var v = ov.swizzle.ywyz;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(-4), new Half(-6), new Half(-3));
                var v = ov.swizzle.ywyw;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(0.5), new Half(3), new Half(9));
                var v = ov.swizzle.ywz;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(3), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-8), new Half(-0.5), new Half(9.5));
                var v = ov.swizzle.ywzx;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-0.5), new Half(-8.5), new Half(6));
                var v = ov.swizzle.ywzy;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(4.5), new Half(2.5), new Half(2.5));
                var v = ov.swizzle.ywzz;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-2.5), new Half(-3), new Half(-1));
                var v = ov.swizzle.ywzw;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(-3), new Half(-1), new Half(-7));
                var v = ov.swizzle.yww;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-7), v.z);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-5.5), new Half(3), new Half(-3.5));
                var v = ov.swizzle.ywwx;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(6.5), new Half(-8.5), new Half(0.5));
                var v = ov.swizzle.ywwy;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(1.5), new Half(8), new Half(-8));
                var v = ov.swizzle.ywwz;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(-4), new Half(-8.5), new Half(-5.5));
                var v = ov.swizzle.ywww;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-4.5), new Half(-4), new Half(-9.5));
                var v = ov.swizzle.zx;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(-7.5), new Half(3.5), new Half(-4));
                var v = ov.swizzle.zxx;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(-8), new Half(-1), new Half(-4.5));
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(4), new Half(2), new Half(2));
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(-2.5), Half.Zero, new Half(8.5));
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(2), new Half(6.5), new Half(8));
                var v = ov.swizzle.zxxw;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(1.5), new Half(9), new Half(-0.5));
                var v = ov.swizzle.zxy;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-4), new Half(0.5), new Half(3.5));
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-1.5), new Half(-8.5), new Half(-5.5));
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(0.5), new Half(-8), new Half(-2.5));
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(0.5), new Half(-1.5), new Half(-4.5));
                var v = ov.swizzle.zxyw;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(5.5), new Half(-0.5), new Half(2.5));
                var v = ov.swizzle.zxz;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(5), new Half(7.5), new Half(-5));
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-6.5), new Half(9), new Half(-1.5));
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(5), new Half(-2), new Half(6));
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(4), new Half(-1.5), new Half(-5.5));
                var v = ov.swizzle.zxzw;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-7), new Half(-9), new Half(-2));
                var v = ov.swizzle.zxw;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(-8), new Half(3), new Half(-0.5));
                var v = ov.swizzle.zxwx;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-3), new Half(8), new Half(-4.5));
                var v = ov.swizzle.zxwy;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-2), new Half(-6.5), new Half(-3));
                var v = ov.swizzle.zxwz;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(-7), Half.Zero, new Half(-9));
                var v = ov.swizzle.zxww;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-5), new Half(-9.5), new Half(-6.5));
                var v = ov.swizzle.zy;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(2.5), new Half(6.5), new Half(3.5));
                var v = ov.swizzle.zyx;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-2), new Half(-5), new Half(-3.5));
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(4), new Half(6.5), new Half(8));
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-7), new Half(8), new Half(-1));
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(7), new Half(6), new Half(9.5));
                var v = ov.swizzle.zyxw;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(-4.5), new Half(-5), new Half(-7));
                var v = ov.swizzle.zyy;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(8.5), new Half(5), new Half(5.5));
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(3), new Half(8), new Half(6), new Half(-3));
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(6.5), new Half(3.5), new Half(2.5));
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(9), new Half(-1), new Half(7.5));
                var v = ov.swizzle.zyyw;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(-7.5), new Half(-6.5), new Half(8));
                var v = ov.swizzle.zyz;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-5), new Half(6.5), new Half(-5.5));
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-0.5), new Half(-7), new Half(8));
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-9.5), new Half(7), new Half(4.5));
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-9), new Half(-1), new Half(-9.5));
                var v = ov.swizzle.zyzw;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-9), new Half(-7.5), new Half(2.5));
                var v = ov.swizzle.zyw;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(-6.5), new Half(-1), new Half(-9.5));
                var v = ov.swizzle.zywx;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(-7), new Half(-0.5), new Half(3.5));
                var v = ov.swizzle.zywy;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(8), Half.One, new Half(2.5));
                var v = ov.swizzle.zywz;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(6), Half.One, new Half(7));
                var v = ov.swizzle.zyww;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(-8.5), new Half(-1.5), new Half(-4));
                var v = ov.swizzle.zz;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(7.5), new Half(4), new Half(-7));
                var v = ov.swizzle.zzx;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(8.5), new Half(-5), new Half(2));
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(1.5), new Half(1.5), new Half(-9));
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(0.5), new Half(-1), new Half(2.5));
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(3), new Half(-6), Half.Zero, new Half(1.5));
                var v = ov.swizzle.zzxw;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-6.5), new Half(-2), new Half(9.5));
                var v = ov.swizzle.zzy;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-6), new Half(3.5), new Half(-1));
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(3), new Half(-7), new Half(-4.5));
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(7), Half.Zero, Half.Zero);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(4.5), new Half(1.5), new Half(-4.5));
                var v = ov.swizzle.zzyw;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(-3.5), new Half(5.5), new Half(5));
                var v = ov.swizzle.zzz;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-6.5), new Half(1.5), new Half(-1));
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(8), new Half(4), new Half(-3.5));
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(6.5), new Half(-4), new Half(9));
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-4), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(4), new Half(8.5), new Half(-3));
                var v = ov.swizzle.zzzw;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(4), new Half(-5.5), new Half(5.5));
                var v = ov.swizzle.zzw;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(6), new Half(-2.5), new Half(2.5));
                var v = ov.swizzle.zzwx;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(-4), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(9), new Half(-3), new Half(8));
                var v = ov.swizzle.zzwy;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(9), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-5), new Half(-1.5), new Half(-5));
                var v = ov.swizzle.zzwz;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(5), new Half(-6.5), new Half(5.5));
                var v = ov.swizzle.zzww;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(-7.5), new Half(-4), new Half(8));
                var v = ov.swizzle.zw;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(8), v.y);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(1.5), new Half(4), new Half(4.5));
                var v = ov.swizzle.zwx;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(1.5), new Half(-5), new Half(-5));
                var v = ov.swizzle.zwxx;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(-9), new Half(-9.5), new Half(8.5));
                var v = ov.swizzle.zwxy;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(Half.One, Half.Zero, new Half(2.5), new Half(-1));
                var v = ov.swizzle.zwxz;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(9.5), new Half(-8.5), new Half(-3.5));
                var v = ov.swizzle.zwxw;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(5.5), Half.One, new Half(5));
                var v = ov.swizzle.zwy;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
            }
            {
                var ov = new hvec4(new Half(8), new Half(8.5), new Half(-7.5), new Half(-9.5));
                var v = ov.swizzle.zwyx;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(2), new Half(-1.5), new Half(-6.5));
                var v = ov.swizzle.zwyy;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-5), new Half(5.5), new Half(-7.5));
                var v = ov.swizzle.zwyz;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(2.5), new Half(8.5), new Half(9.5));
                var v = ov.swizzle.zwyw;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(8.5), new Half(-3), new Half(6));
                var v = ov.swizzle.zwz;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-3), v.z);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(0.5), new Half(-3), new Half(-2.5));
                var v = ov.swizzle.zwzx;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-2), new Half(9.5), new Half(-4.5));
                var v = ov.swizzle.zwzy;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(-1.5), new Half(-3), new Half(3));
                var v = ov.swizzle.zwzz;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(9.5), new Half(-3.5), new Half(5.5));
                var v = ov.swizzle.zwzw;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(4.5), new Half(2.5), new Half(3.5));
                var v = ov.swizzle.zww;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(6.5), new Half(7), new Half(-3.5));
                var v = ov.swizzle.zwwx;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(9), new Half(8), new Half(3));
                var v = ov.swizzle.zwwy;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(9), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-8.5), new Half(0.5), new Half(8.5));
                var v = ov.swizzle.zwwz;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(4.5), new Half(9), new Half(-8));
                var v = ov.swizzle.zwww;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(4.5), new Half(6), new Half(9));
                var v = ov.swizzle.wx;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
            }
            {
                var ov = new hvec4(new Half(2), new Half(2), new Half(-7.5), Half.One);
                var v = ov.swizzle.wxx;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(2), v.z);
            }
            {
                var ov = new hvec4(new Half(2), new Half(2.5), new Half(2.5), new Half(2));
                var v = ov.swizzle.wxxx;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(2), new Half(0.5), Half.Zero);
                var v = ov.swizzle.wxxy;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-9), new Half(-6), new Half(9.5));
                var v = ov.swizzle.wxxz;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-3.5), new Half(-6.5), new Half(3));
                var v = ov.swizzle.wxxw;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(6.5), new Half(-4.5), new Half(-9.5));
                var v = ov.swizzle.wxy;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(-5), new Half(-7.5), new Half(5.5));
                var v = ov.swizzle.wxyx;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(8), new Half(8), new Half(-5));
                var v = ov.swizzle.wxyy;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-6.5), new Half(0.5), new Half(-1.5));
                var v = ov.swizzle.wxyz;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(5), new Half(-5.5), new Half(-3));
                var v = ov.swizzle.wxyw;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(6), new Half(7.5), new Half(8.5));
                var v = ov.swizzle.wxz;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(0.5), new Half(2.5), new Half(2));
                var v = ov.swizzle.wxzx;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-1), new Half(5.5), Half.Zero);
                var v = ov.swizzle.wxzy;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(2), new Half(6), new Half(6));
                var v = ov.swizzle.wxzz;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), Half.One, new Half(4), new Half(-1.5));
                var v = ov.swizzle.wxzw;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(7.5), new Half(-3), new Half(7.5));
                var v = ov.swizzle.wxw;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
            }
            {
                var ov = new hvec4(new Half(3.5), new Half(-5), new Half(-2), new Half(-6.5));
                var v = ov.swizzle.wxwx;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(-2.5), new Half(-4.5), new Half(-6));
                var v = ov.swizzle.wxwy;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(-2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(-1), new Half(-3.5), new Half(6.5));
                var v = ov.swizzle.wxwz;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(-2.5), new Half(-1.5), new Half(7));
                var v = ov.swizzle.wxww;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-9), new Half(-6), new Half(-8));
                var v = ov.swizzle.wy;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-9), v.y);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(8), new Half(3), new Half(-3.5));
                var v = ov.swizzle.wyx;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-3), v.z);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-5.5), new Half(-1), new Half(-3));
                var v = ov.swizzle.wyxx;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(5.5), new Half(2), new Half(-9.5));
                var v = ov.swizzle.wyxy;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(3.5), new Half(9.5), new Half(4), new Half(-7));
                var v = ov.swizzle.wyxz;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(9), new Half(-4), new Half(2.5));
                var v = ov.swizzle.wyxw;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(-9), new Half(8.5), Half.Zero);
                var v = ov.swizzle.wyy;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-9), v.z);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-1), new Half(6), new Half(1.5));
                var v = ov.swizzle.wyyx;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(7.5), new Half(6), new Half(1.5));
                var v = ov.swizzle.wyyy;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(5.5), new Half(-5.5), new Half(-4.5));
                var v = ov.swizzle.wyyz;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(-3.5), new Half(7), new Half(4));
                var v = ov.swizzle.wyyw;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-2), new Half(-5), new Half(6));
                var v = ov.swizzle.wyz;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-5), v.z);
            }
            {
                var ov = new hvec4(new Half(7), new Half(6), new Half(3), new Half(9.5));
                var v = ov.swizzle.wyzx;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-2), new Half(-0.5), new Half(-2));
                var v = ov.swizzle.wyzy;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-6.5), new Half(2.5), new Half(4.5));
                var v = ov.swizzle.wyzz;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(2), new Half(8), new Half(4));
                var v = ov.swizzle.wyzw;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-9.5), new Half(9.5), new Half(3));
                var v = ov.swizzle.wyw;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(3), v.z);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(-1), new Half(7.5), new Half(8.5));
                var v = ov.swizzle.wywx;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-9), new Half(5), new Half(1.5));
                var v = ov.swizzle.wywy;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(9), new Half(-6), new Half(-4));
                var v = ov.swizzle.wywz;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(1.5), new Half(2.5), new Half(9));
                var v = ov.swizzle.wyww;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(9), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(7), new Half(8), Half.One);
                var v = ov.swizzle.wz;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(8), v.y);
            }
            {
                var ov = new hvec4(new Half(7), new Half(4.5), new Half(-3.5), new Half(8.5));
                var v = ov.swizzle.wzx;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(7), v.z);
            }
            {
                var ov = new hvec4(new Half(2), new Half(0.5), new Half(-5), new Half(7));
                var v = ov.swizzle.wzxx;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(2), new Half(-2.5), new Half(6.5));
                var v = ov.swizzle.wzxy;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-1), new Half(-8), new Half(7.5));
                var v = ov.swizzle.wzxz;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(4), new Half(-5.5), new Half(3));
                var v = ov.swizzle.wzxw;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(8.5), new Half(9), new Half(5.5));
                var v = ov.swizzle.wzy;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-8), new Half(0.5), new Half(-9));
                var v = ov.swizzle.wzyx;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(9.5), new Half(7.5), new Half(9));
                var v = ov.swizzle.wzyy;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(7.5), new Half(5.5), new Half(4.5));
                var v = ov.swizzle.wzyz;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(9.5), new Half(5.5), new Half(-3.5));
                var v = ov.swizzle.wzyw;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(8.5), new Half(-4), Half.Zero);
                var v = ov.swizzle.wzz;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-4), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-9), Half.Zero, new Half(3.5));
                var v = ov.swizzle.wzzx;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(5.5), Half.One, new Half(2));
                var v = ov.swizzle.wzzy;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(5), new Half(6.5), new Half(9));
                var v = ov.swizzle.wzzz;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(1.5), new Half(0.5), new Half(-5.5));
                var v = ov.swizzle.wzzw;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(5.5), new Half(7.5), new Half(-9));
                var v = ov.swizzle.wzw;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-7), new Half(-4.5), new Half(-6));
                var v = ov.swizzle.wzwx;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-6.5), new Half(-2), new Half(8));
                var v = ov.swizzle.wzwy;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(7.5), new Half(8.5), new Half(6));
                var v = ov.swizzle.wzwz;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(9), new Half(-3), new Half(-1.5));
                var v = ov.swizzle.wzww;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(7.5), new Half(5), new Half(-5));
                var v = ov.swizzle.ww;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(5.5), new Half(-3.5), new Half(5));
                var v = ov.swizzle.wwx;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-3.5), new Half(9), new Half(4.5));
                var v = ov.swizzle.wwxx;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-1), new Half(-3.5), new Half(9));
                var v = ov.swizzle.wwxy;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(5.5), new Half(6.5), new Half(5));
                var v = ov.swizzle.wwxz;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(-4.5), new Half(-7), new Half(0.5));
                var v = ov.swizzle.wwxw;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(2.5), new Half(3.5), new Half(-3.5));
                var v = ov.swizzle.wwy;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-0.5), new Half(-5.5), new Half(-5));
                var v = ov.swizzle.wwyx;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(2), new Half(6), new Half(2));
                var v = ov.swizzle.wwyy;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-6.5), new Half(-8.5), new Half(8));
                var v = ov.swizzle.wwyz;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(-9), new Half(-5), new Half(-0.5));
                var v = ov.swizzle.wwyw;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-8), Half.Zero, new Half(8.5));
                var v = ov.swizzle.wwz;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(-0.5), new Half(6), new Half(0.5));
                var v = ov.swizzle.wwzx;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(7), new Half(4.5), new Half(2.5));
                var v = ov.swizzle.wwzy;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(-5), new Half(1.5), new Half(5));
                var v = ov.swizzle.wwzz;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(9.5), new Half(9.5), new Half(-1));
                var v = ov.swizzle.wwzw;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(4.5), new Half(-6), new Half(6));
                var v = ov.swizzle.www;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(6), v.z);
            }
            {
                var ov = new hvec4(new Half(3), new Half(-6.5), new Half(-9), new Half(-7));
                var v = ov.swizzle.wwwx;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-2.5), new Half(-4), new Half(-5));
                var v = ov.swizzle.wwwy;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(-1.5), new Half(-8), new Half(5));
                var v = ov.swizzle.wwwz;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(4.5), new Half(-5), new Half(-7));
                var v = ov.swizzle.wwww;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new hvec4(new Half(-7), new Half(7.5), new Half(-7.5), new Half(9.5));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-7), v.y);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(3.5), new Half(9.5), new Half(-6));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-6), v.z);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(-5.5), new Half(9.5), new Half(-2.5));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(4), new Half(-0.5), new Half(-6));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(4.5), new Half(2), new Half(6));
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(2.5), new Half(-1), new Half(-1));
                var v = ov.swizzle.rrra;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(3.5), Half.Zero, new Half(7.5));
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(2), new Half(9.5), new Half(-7.5));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(2.5), new Half(6), new Half(-3.5));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(5.5), new Half(5), new Half(-5));
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(8.5), new Half(-5.5), new Half(5));
                var v = ov.swizzle.rrga;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(2.5), new Half(7), new Half(1.5));
                var v = ov.swizzle.rrb;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(7), v.z);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-3), new Half(4.5), new Half(-9.5));
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(7.5), new Half(2), new Half(-5.5));
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(-1), new Half(-5.5), new Half(-7.5));
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(3.5), Half.One, new Half(1.5), new Half(-6));
                var v = ov.swizzle.rrba;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-8), new Half(9.5), new Half(-9));
                var v = ov.swizzle.rra;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(3), new Half(-9), new Half(-4.5));
                var v = ov.swizzle.rrar;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(-2.5), new Half(9.5), new Half(2));
                var v = ov.swizzle.rrag;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(-2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(5), new Half(-0.5), new Half(-5.5));
                var v = ov.swizzle.rrab;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(8), new Half(7), new Half(-3));
                var v = ov.swizzle.rraa;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-9), new Half(9), new Half(0.5));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-9), v.y);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-7.5), Half.Zero, new Half(-4.5));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(-6.5), new Half(-7.5), new Half(4));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(8), new Half(-8.5), new Half(4));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(3.5), new Half(-0.5), new Half(4.5), new Half(-2.5));
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(3.5), new Half(9), new Half(1.5), new Half(-5.5));
                var v = ov.swizzle.rgra;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(9.5), new Half(-6), new Half(-9.5));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(9.5), new Half(6.5), new Half(-5.5));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(-9), new Half(7), new Half(5));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(8), new Half(-0.5), new Half(-5));
                var v = ov.swizzle.rggb;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(3.5), new Half(-4), new Half(5));
                var v = ov.swizzle.rgga;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(5.5), new Half(6.5), new Half(9.5));
                var v = ov.swizzle.rgb;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-4.5), new Half(1.5), new Half(6.5));
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(-8.5), new Half(-9), new Half(8.5));
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-3.5), new Half(3.5), new Half(0.5));
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-9.5), new Half(3), new Half(-3));
                var v = ov.swizzle.rgba;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(7.5), new Half(-1), new Half(-1.5));
                var v = ov.swizzle.rga;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
            }
            {
                var ov = new hvec4(Half.One, new Half(-6), new Half(6.5), new Half(-5.5));
                var v = ov.swizzle.rgar;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-9), new Half(-5.5), new Half(9.5));
                var v = ov.swizzle.rgag;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(-4.5), new Half(-9), new Half(2));
                var v = ov.swizzle.rgab;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(3), new Half(-7), new Half(5.5), new Half(7.5));
                var v = ov.swizzle.rgaa;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(9.5), new Half(9), new Half(-4));
                var v = ov.swizzle.rb;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(9), v.y);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(8), new Half(-7), new Half(-7.5));
                var v = ov.swizzle.rbr;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(8.5), new Half(8), new Half(-6.5));
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), Half.Zero, new Half(-8), new Half(7));
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(7), new Half(8.5), new Half(9));
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(6), new Half(6.5), new Half(5.5));
                var v = ov.swizzle.rbra;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(-9), new Half(2), new Half(2));
                var v = ov.swizzle.rbg;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(-9), v.z);
            }
            {
                var ov = new hvec4(new Half(6), new Half(0.5), new Half(-2.5), new Half(-0.5));
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(5), new Half(4), new Half(-2.5));
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(6.5), new Half(-0.5), new Half(2.5));
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(-5), new Half(9), Half.One);
                var v = ov.swizzle.rbga;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec4(new Half(9), Half.Zero, new Half(9), new Half(5.5));
                var v = ov.swizzle.rbb;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9), v.z);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-1), new Half(-8), new Half(6.5));
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-3.5), new Half(9), Half.Zero);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(3), new Half(-4), new Half(-7), new Half(-9.5));
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-4), new Half(-5), new Half(-5.5));
                var v = ov.swizzle.rbba;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(-9.5), new Half(9.5), new Half(-5.5));
                var v = ov.swizzle.rba;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(0.5), new Half(-9.5), new Half(-1.5));
                var v = ov.swizzle.rbar;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(5), new Half(-1), new Half(-3));
                var v = ov.swizzle.rbag;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(4.5), new Half(-4.5), new Half(6.5));
                var v = ov.swizzle.rbab;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(7), new Half(5.5), new Half(6.5));
                var v = ov.swizzle.rbaa;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(0.5), new Half(-1), new Half(7.5));
                var v = ov.swizzle.ra;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(3), new Half(-5.5), new Half(-4));
                var v = ov.swizzle.rar;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(9), new Half(-2.5), new Half(-5.5));
                var v = ov.swizzle.rarr;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-4.5), new Half(0.5), new Half(0.5));
                var v = ov.swizzle.rarg;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(-4.5), new Half(9.5), new Half(-7));
                var v = ov.swizzle.rarb;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(0.5), new Half(-8), new Half(-3));
                var v = ov.swizzle.rara;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(6.5), new Half(3), new Half(8));
                var v = ov.swizzle.rag;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(-9.5), new Half(-1), new Half(8.5));
                var v = ov.swizzle.ragr;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-9), new Half(-2), new Half(-8.5));
                var v = ov.swizzle.ragg;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(8), Half.One, new Half(-1.5), new Half(1.5));
                var v = ov.swizzle.ragb;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(5), new Half(7), new Half(8));
                var v = ov.swizzle.raga;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-2.5), new Half(-3), new Half(-3));
                var v = ov.swizzle.rab;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-3), v.z);
            }
            {
                var ov = new hvec4(new Half(4), new Half(4.5), new Half(4.5), new Half(-5.5));
                var v = ov.swizzle.rabr;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-9), new Half(5), new Half(-6.5));
                var v = ov.swizzle.rabg;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(7.5), new Half(-6.5), Half.Zero);
                var v = ov.swizzle.rabb;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-6), new Half(-4.5), new Half(9.5));
                var v = ov.swizzle.raba;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(-1.5), new Half(4), new Half(-8.5));
                var v = ov.swizzle.raa;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(8), new Half(-7.5), Half.Zero);
                var v = ov.swizzle.raar;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(7), new Half(9), new Half(-4.5));
                var v = ov.swizzle.raag;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(9), new Half(4.5), new Half(-1.5));
                var v = ov.swizzle.raab;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(0.5), new Half(3), new Half(4.5));
                var v = ov.swizzle.raaa;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-2.5), new Half(0.5), Half.Zero);
                var v = ov.swizzle.gr;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-1.5), new Half(8), new Half(-2));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-3), v.z);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-2.5), new Half(1.5), new Half(1.5));
                var v = ov.swizzle.grrr;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(7), new Half(9), new Half(0.5));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(2.5), new Half(9.5), new Half(5.5));
                var v = ov.swizzle.grrb;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(4.5), new Half(-3.5), Half.Zero);
                var v = ov.swizzle.grra;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-8.5), Half.Zero, new Half(3));
                var v = ov.swizzle.grg;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
            }
            {
                var ov = new hvec4(new Half(2), new Half(4.5), new Half(-7), new Half(-1));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(0.5), new Half(-4), new Half(-2));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8.5), new Half(4), new Half(7), new Half(-4.5));
                var v = ov.swizzle.grgb;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(9), new Half(-8.5), new Half(-1));
                var v = ov.swizzle.grga;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-9), new Half(3), new Half(-4));
                var v = ov.swizzle.grb;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(3), v.z);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(4), new Half(5), new Half(1.5));
                var v = ov.swizzle.grbr;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(8), new Half(-8.5), new Half(1.5));
                var v = ov.swizzle.grbg;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-0.5), new Half(1.5), new Half(2.5));
                var v = ov.swizzle.grbb;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(5), new Half(8), new Half(-5.5));
                var v = ov.swizzle.grba;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(-8.5), new Half(-9), new Half(0.5));
                var v = ov.swizzle.gra;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(8.5), new Half(1.5), new Half(-7));
                var v = ov.swizzle.grar;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(-5), new Half(5.5), new Half(2));
                var v = ov.swizzle.grag;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-6), new Half(-5.5), new Half(-0.5));
                var v = ov.swizzle.grab;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-2.5), new Half(3), new Half(8.5));
                var v = ov.swizzle.graa;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-3.5), new Half(-9.5), new Half(3));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
            }
            {
                var ov = new hvec4(new Half(9), new Half(-6.5), new Half(-1), new Half(8));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(9), v.z);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-6), new Half(7.5), new Half(5.5));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-4), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(7.5), Half.Zero, new Half(6.5));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-3), new Half(-9.5), Half.Zero);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-0.5), new Half(7), new Half(-6));
                var v = ov.swizzle.ggra;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-8), new Half(-8), new Half(-4.5));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
            }
            {
                var ov = new hvec4(new Half(5), Half.One, new Half(-6), Half.Zero);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(-1), new Half(5.5), new Half(-5.5));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(-6), new Half(-8.5), new Half(-1));
                var v = ov.swizzle.gggb;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(-7.5), new Half(3), new Half(7));
                var v = ov.swizzle.ggga;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), Half.Zero, Half.One, new Half(-6));
                var v = ov.swizzle.ggb;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(Half.One, v.z);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(-2.5), new Half(-0.5), new Half(3));
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(3), new Half(-4.5), new Half(9.5));
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(3), new Half(0.5), new Half(1.5));
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-4.5), new Half(3), new Half(-2));
                var v = ov.swizzle.ggba;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(6.5), new Half(3.5), new Half(1.5));
                var v = ov.swizzle.gga;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
            }
            {
                var ov = new hvec4(new Half(2), new Half(-7), new Half(5.5), new Half(-5.5));
                var v = ov.swizzle.ggar;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(9), new Half(-3), new Half(1.5));
                var v = ov.swizzle.ggag;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(9), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(9.5), new Half(7.5), new Half(-3));
                var v = ov.swizzle.ggab;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), Half.One, new Half(9), new Half(-8));
                var v = ov.swizzle.ggaa;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-2), new Half(4.5), new Half(8.5));
                var v = ov.swizzle.gb;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(5.5), new Half(4), new Half(7.5));
                var v = ov.swizzle.gbr;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(0.5), new Half(4), Half.One);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(new Half(0.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(2.5), new Half(7), new Half(-7.5));
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-1), new Half(-3), new Half(8.5));
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(5), new Half(-2), new Half(7.5));
                var v = ov.swizzle.gbra;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(3.5), new Half(-5), new Half(-9.5));
                var v = ov.swizzle.gbg;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-7), new Half(-5), new Half(3));
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(-4.5), new Half(9.5), new Half(-1.5));
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(5.5), new Half(5), new Half(6));
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(8.5), new Half(8.5), new Half(2));
                var v = ov.swizzle.gbga;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-1), new Half(-2), new Half(3.5));
                var v = ov.swizzle.gbb;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-2), v.z);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(-6), new Half(6), new Half(6));
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-2), new Half(-4.5), new Half(6));
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(7.5), new Half(7), new Half(2.5));
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(-4.5), new Half(1.5), new Half(9));
                var v = ov.swizzle.gbba;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(9), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), Half.One, new Half(-3.5), new Half(4.5));
                var v = ov.swizzle.gba;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(-9.5), new Half(-9.5), new Half(-2));
                var v = ov.swizzle.gbar;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(6), new Half(-3.5), new Half(4.5));
                var v = ov.swizzle.gbag;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(9), new Half(3.5), new Half(-9));
                var v = ov.swizzle.gbab;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-8.5), new Half(-0.5), new Half(0.5));
                var v = ov.swizzle.gbaa;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(7), new Half(-6), new Half(3));
                var v = ov.swizzle.ga;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(3), v.y);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(2.5), new Half(-1.5), new Half(4));
                var v = ov.swizzle.gar;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(-3), new Half(-3.5), new Half(-2.5));
                var v = ov.swizzle.garr;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
                Assert.AreEqual(new Half(-2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-1.5), new Half(-2.5), new Half(3));
                var v = ov.swizzle.garg;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(-8), Half.Zero, new Half(-2));
                var v = ov.swizzle.garb;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(5.5), Half.One, new Half(-7.5));
                var v = ov.swizzle.gara;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(1.5), Half.Zero, new Half(0.5));
                var v = ov.swizzle.gag;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-0.5), new Half(-1), new Half(9.5));
                var v = ov.swizzle.gagr;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), Half.One, new Half(9.5), new Half(6));
                var v = ov.swizzle.gagg;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-6.5), new Half(4.5), Half.Zero);
                var v = ov.swizzle.gagb;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(-5), new Half(-5.5), new Half(1.5));
                var v = ov.swizzle.gaga;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(8.5), new Half(-1.5), new Half(-9));
                var v = ov.swizzle.gab;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-0.5), new Half(4.5), new Half(3));
                var v = ov.swizzle.gabr;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(-7), new Half(3.5), new Half(-5));
                var v = ov.swizzle.gabg;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(3.5), new Half(-8), new Half(8));
                var v = ov.swizzle.gabb;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(8.5), Half.Zero, new Half(8.5));
                var v = ov.swizzle.gaba;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(-2.5), new Half(1.5), new Half(4));
                var v = ov.swizzle.gaa;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(4), v.z);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(-9.5), new Half(-8), Half.One);
                var v = ov.swizzle.gaar;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(9.5), new Half(-9.5), new Half(-8.5));
                var v = ov.swizzle.gaag;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(9), new Half(2), new Half(-2.5));
                var v = ov.swizzle.gaab;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(3), new Half(-8.5), new Half(7), new Half(-5));
                var v = ov.swizzle.gaaa;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(6), new Half(-8), new Half(-9));
                var v = ov.swizzle.br;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-4.5), Half.Zero, new Half(2.5));
                var v = ov.swizzle.brr;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(7), v.z);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-3.5), new Half(8), new Half(2.5));
                var v = ov.swizzle.brrr;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-3.5), new Half(-0.5), new Half(2.5));
                var v = ov.swizzle.brrg;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-6.5), new Half(-0.5), new Half(2));
                var v = ov.swizzle.brrb;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(3.5), new Half(-9.5), new Half(-8.5));
                var v = ov.swizzle.brra;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(-3), new Half(3), new Half(6.5));
                var v = ov.swizzle.brg;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(1.5), new Half(5), new Half(-1));
                var v = ov.swizzle.brgr;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-3.5), new Half(4), new Half(5.5));
                var v = ov.swizzle.brgg;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-3), new Half(7.5), new Half(3));
                var v = ov.swizzle.brgb;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-4.5), new Half(6.5), new Half(8.5));
                var v = ov.swizzle.brga;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(-2.5), new Half(6), new Half(-4.5));
                var v = ov.swizzle.brb;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(6), v.z);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(9), new Half(-9), new Half(-9.5));
                var v = ov.swizzle.brbr;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-9), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(5), new Half(2), Half.Zero);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(7.5), new Half(-7.5), new Half(5.5));
                var v = ov.swizzle.brbb;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(3), Half.One, new Half(-4));
                var v = ov.swizzle.brba;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(-4), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(8.5), new Half(2), new Half(-1.5));
                var v = ov.swizzle.bra;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(3.5), new Half(-6.5), new Half(5.5));
                var v = ov.swizzle.brar;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-4.5), new Half(-6.5), new Half(-3.5));
                var v = ov.swizzle.brag;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(-7.5), new Half(-0.5), new Half(9));
                var v = ov.swizzle.brab;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-9), new Half(-6), new Half(-8.5));
                var v = ov.swizzle.braa;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(-4.5), new Half(-9), new Half(-4.5));
                var v = ov.swizzle.bg;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(3), new Half(8), new Half(-2));
                var v = ov.swizzle.bgr;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(2), new Half(-6.5), new Half(-5));
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(-7.5), new Half(-8), new Half(3.5));
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-9), new Half(3), new Half(-1.5));
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(-5.5), new Half(5.5), new Half(6));
                var v = ov.swizzle.bgra;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-6), new Half(3), new Half(5));
                var v = ov.swizzle.bgg;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-6), v.z);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-2), new Half(-0.5), new Half(2));
                var v = ov.swizzle.bggr;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-8.5), new Half(2), new Half(5.5));
                var v = ov.swizzle.bggg;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-7), new Half(4), new Half(-8));
                var v = ov.swizzle.bggb;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-7), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-2), new Half(3), new Half(-6.5));
                var v = ov.swizzle.bgga;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2), new Half(7), new Half(2), new Half(-6));
                var v = ov.swizzle.bgb;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(2), v.z);
            }
            {
                var ov = new hvec4(new Half(3), new Half(6.5), new Half(-4.5), new Half(-2.5));
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(-5), new Half(-1.5), new Half(4.5), new Half(-2.5));
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(new Half(4.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-3), new Half(2), new Half(6));
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(new Half(2), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(2), new Half(4), new Half(-9));
                var v = ov.swizzle.bgba;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-8.5), new Half(-2.5), new Half(2));
                var v = ov.swizzle.bga;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-7.5), new Half(-4), new Half(7));
                var v = ov.swizzle.bgar;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-4.5), new Half(3), new Half(-5));
                var v = ov.swizzle.bgag;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(-2), new Half(3), new Half(-4));
                var v = ov.swizzle.bgab;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-1.5), Half.One, new Half(-1));
                var v = ov.swizzle.bgaa;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(-2.5), Half.One, new Half(-2.5), Half.Zero);
                var v = ov.swizzle.bb;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
            }
            {
                var ov = new hvec4(new Half(-2.5), new Half(-5), new Half(5), new Half(6));
                var v = ov.swizzle.bbr;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(8.5), new Half(-9), new Half(-7.5));
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-4), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-5.5), new Half(9), new Half(-8.5));
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(9.5), new Half(6.5), new Half(-7.5));
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-7), new Half(-4), new Half(0.5));
                var v = ov.swizzle.bbra;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(-9), new Half(6), new Half(-8));
                var v = ov.swizzle.bbg;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-9), v.z);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-0.5), new Half(3.5), new Half(-2));
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(3.5), new Half(2.5), new Half(-1));
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(3.5), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(-3.5), new Half(-6), new Half(3));
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(6), new Half(3.5), new Half(-6));
                var v = ov.swizzle.bbga;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(6), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-7.5), new Half(8), new Half(5.5));
                var v = ov.swizzle.bbb;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(8), v.z);
            }
            {
                var ov = new hvec4(Half.One, new Half(-7.5), new Half(2.5), new Half(-4));
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(-9), new Half(-0.5), new Half(-1));
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-9), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(6.5), new Half(-6), new Half(7));
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-2.5), new Half(8.5), new Half(-4.5));
                var v = ov.swizzle.bbba;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(6), new Half(-9.5), new Half(-4));
                var v = ov.swizzle.bba;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-4), v.z);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(9.5), new Half(-2.5), new Half(5.5));
                var v = ov.swizzle.bbar;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(3.5), new Half(5), new Half(-5));
                var v = ov.swizzle.bbag;
                Assert.AreEqual(new Half(5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(7.5), new Half(-6.5), new Half(2));
                var v = ov.swizzle.bbab;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(-1), new Half(-7), new Half(-3.5));
                var v = ov.swizzle.bbaa;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(6.5), new Half(-9.5), new Half(-8.5), new Half(-7.5));
                var v = ov.swizzle.ba;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-7.5), new Half(-6.5), new Half(7.5));
                var v = ov.swizzle.bar;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(4), v.z);
            }
            {
                var ov = new hvec4(new Half(9), new Half(7), new Half(5.5), new Half(-0.5));
                var v = ov.swizzle.barr;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(9), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(7), new Half(-1), new Half(9.5));
                var v = ov.swizzle.barg;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(Half.One, new Half(5.5), new Half(3), new Half(2));
                var v = ov.swizzle.barb;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(7.5), new Half(-0.5), new Half(8.5));
                var v = ov.swizzle.bara;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(5.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(-4), new Half(-2.5), new Half(0.5));
                var v = ov.swizzle.bag;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(-4), v.z);
            }
            {
                var ov = new hvec4(new Half(-3), new Half(-3), new Half(7.5), new Half(7.5));
                var v = ov.swizzle.bagr;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(-2), new Half(-0.5), new Half(-4.5));
                var v = ov.swizzle.bagg;
                Assert.AreEqual(new Half(-0.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-2), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(8.5), new Half(8), new Half(-1));
                var v = ov.swizzle.bagb;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(8.5), v.z);
                Assert.AreEqual(new Half(8), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(0.5), new Half(-3.5), new Half(-6));
                var v = ov.swizzle.baga;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(-6), new Half(6), new Half(-6));
                var v = ov.swizzle.bab;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(6), v.z);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(-5.5), Half.One, new Half(-5));
                var v = ov.swizzle.babr;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(-5), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-5), new Half(1.5), new Half(8.5));
                var v = ov.swizzle.babg;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-7.5), new Half(7), new Half(1.5));
                var v = ov.swizzle.babb;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(2.5), new Half(-5.5), new Half(6.5));
                var v = ov.swizzle.baba;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(7.5), new Half(-9), new Half(6.5));
                var v = ov.swizzle.baa;
                Assert.AreEqual(new Half(-9), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(-3.5), new Half(-3), new Half(3));
                var v = ov.swizzle.baar;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(2.5), new Half(-3.5), new Half(5));
                var v = ov.swizzle.baag;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(-4), Half.Zero, new Half(7.5));
                var v = ov.swizzle.baab;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-1), new Half(4), new Half(-0.5));
                var v = ov.swizzle.baaa;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-2), new Half(-6.5), new Half(0.5), new Half(6.5));
                var v = ov.swizzle.ar;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(1.5), new Half(4.5), new Half(4));
                var v = ov.swizzle.arr;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-8), new Half(-6), new Half(-5.5));
                var v = ov.swizzle.arrr;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(0.5), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5), new Half(-0.5), new Half(6), new Half(9.5));
                var v = ov.swizzle.arrg;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(5), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(9), new Half(7.5), Half.Zero);
                var v = ov.swizzle.arrb;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(new Half(7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(8.5), new Half(-0.5), new Half(-5));
                var v = ov.swizzle.arra;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-4.5), new Half(-2.5), new Half(-7));
                var v = ov.swizzle.arg;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(9), new Half(-6.5), new Half(-5.5));
                var v = ov.swizzle.argr;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(4.5), new Half(-4.5), new Half(-2.5));
                var v = ov.swizzle.argg;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-6.5), new Half(-5), new Half(-2.5));
                var v = ov.swizzle.argb;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(1.5), new Half(8), new Half(-3), new Half(7));
                var v = ov.swizzle.arga;
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(1.5), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), Half.One, new Half(9.5), new Half(-6.5));
                var v = ov.swizzle.arb;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
            }
            {
                var ov = new hvec4(new Half(6), Half.Zero, Half.Zero, new Half(7.5));
                var v = ov.swizzle.arbr;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(3), new Half(-8), new Half(-3));
                var v = ov.swizzle.arbg;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(3.5), new Half(-5), new Half(7), new Half(6.5));
                var v = ov.swizzle.arbb;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-8), new Half(-7.5), new Half(-9.5));
                var v = ov.swizzle.arba;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(-9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(2.5), new Half(6.5), new Half(-1));
                var v = ov.swizzle.ara;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(-1), v.z);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-9), new Half(2.5), new Half(-4));
                var v = ov.swizzle.arar;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(4), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(9), new Half(8), Half.One);
                var v = ov.swizzle.arag;
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(new Half(9), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(-8.5), new Half(8.5), new Half(-2.5));
                var v = ov.swizzle.arab;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
                Assert.AreEqual(new Half(8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4.5), new Half(4), new Half(9), new Half(-8.5));
                var v = ov.swizzle.araa;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
                Assert.AreEqual(new Half(-8.5), v.w);
            }
            {
                var ov = new hvec4(new Half(9), new Half(-4.5), new Half(9), new Half(-5.5));
                var v = ov.swizzle.ag;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-2), new Half(3.5), new Half(3.5));
                var v = ov.swizzle.agr;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(-6), v.z);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-9), new Half(-6.5), new Half(-4));
                var v = ov.swizzle.agrr;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-9), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(-6), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(2.5), new Half(-3), new Half(-4.5));
                var v = ov.swizzle.agrg;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(2.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4), new Half(-1.5), new Half(-8), new Half(-1.5));
                var v = ov.swizzle.agrb;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-2.5), new Half(3), new Half(4));
                var v = ov.swizzle.agra;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(4), v.w);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(-6), new Half(-1.5), new Half(-3));
                var v = ov.swizzle.agg;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(-6), v.z);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-9.5), new Half(-1), Half.Zero);
                var v = ov.swizzle.aggr;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(8), Half.One, new Half(-1), new Half(8));
                var v = ov.swizzle.aggg;
                Assert.AreEqual(new Half(8), v.x);
                Assert.AreEqual(Half.One, v.y);
                Assert.AreEqual(Half.One, v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-3), new Half(4.5), new Half(2.5));
                var v = ov.swizzle.aggb;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(9.5), new Half(8.5), new Half(-5));
                var v = ov.swizzle.agga;
                Assert.AreEqual(new Half(-5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(5.5), new Half(-6), new Half(2.5));
                var v = ov.swizzle.agb;
                Assert.AreEqual(new Half(2.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(-6), v.z);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-4), new Half(-7.5), new Half(7.5));
                var v = ov.swizzle.agbr;
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(-7.5), new Half(-2), new Half(-7.5));
                var v = ov.swizzle.agbg;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(-7.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(5), new Half(-1.5), Half.Zero);
                var v = ov.swizzle.agbb;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(-8.5), new Half(-6), new Half(5.5));
                var v = ov.swizzle.agba;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(-6), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-6.5), new Half(4), new Half(-4.5));
                var v = ov.swizzle.aga;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(3), new Half(2), new Half(1.5));
                var v = ov.swizzle.agar;
                Assert.AreEqual(new Half(1.5), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(-4.5), new Half(2), new Half(9));
                var v = ov.swizzle.agag;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-1.5), new Half(-8), new Half(9.5));
                var v = ov.swizzle.agab;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(Half.Zero, new Half(5.5), new Half(4), new Half(3));
                var v = ov.swizzle.agaa;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(-4), new Half(-4), new Half(-2.5));
                var v = ov.swizzle.ab;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(-4), v.y);
            }
            {
                var ov = new hvec4(new Half(-0.5), new Half(-1.5), new Half(-2.5), new Half(-7));
                var v = ov.swizzle.abr;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-0.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(4.5), new Half(8), new Half(4));
                var v = ov.swizzle.abrr;
                Assert.AreEqual(new Half(4), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-5.5), v.z);
                Assert.AreEqual(new Half(-5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-6.5), new Half(3), new Half(6), new Half(3));
                var v = ov.swizzle.abrg;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(0.5), new Half(-1), new Half(3));
                var v = ov.swizzle.abrb;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(0.5), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(1.5), new Half(2), Half.Zero);
                var v = ov.swizzle.abra;
                Assert.AreEqual(Half.Zero, v.x);
                Assert.AreEqual(new Half(2), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(2), new Half(4.5), new Half(3.5));
                var v = ov.swizzle.abg;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
            }
            {
                var ov = new hvec4(new Half(-1.5), new Half(-1.5), new Half(9.5), new Half(-1.5));
                var v = ov.swizzle.abgr;
                Assert.AreEqual(new Half(-1.5), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-3), new Half(7.5), new Half(5.5));
                var v = ov.swizzle.abgg;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(-3), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-8), new Half(5.5), new Half(3.5));
                var v = ov.swizzle.abgb;
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(-8), v.z);
                Assert.AreEqual(new Half(5.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(-3.5), new Half(6), new Half(9.5));
                var v = ov.swizzle.abga;
                Assert.AreEqual(new Half(9.5), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7), new Half(7.5), new Half(-2.5), new Half(-5.5));
                var v = ov.swizzle.abb;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-4), new Half(9), new Half(-1));
                var v = ov.swizzle.abbr;
                Assert.AreEqual(new Half(-1), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-7.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), Half.Zero, new Half(2.5), new Half(6));
                var v = ov.swizzle.abbg;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(2.5), v.y);
                Assert.AreEqual(new Half(2.5), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(-4), new Half(7), new Half(-2.5));
                var v = ov.swizzle.abbb;
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(7), v.y);
                Assert.AreEqual(new Half(7), v.z);
                Assert.AreEqual(new Half(7), v.w);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(3.5), new Half(-1.5), new Half(6.5));
                var v = ov.swizzle.abba;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(-1.5), v.z);
                Assert.AreEqual(new Half(6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(-9.5), new Half(-1.5), new Half(9));
                var v = ov.swizzle.aba;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(-1.5), v.y);
                Assert.AreEqual(new Half(9), v.z);
            }
            {
                var ov = new hvec4(new Half(6), new Half(-1), new Half(4.5), new Half(-2));
                var v = ov.swizzle.abar;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(4.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(-7), new Half(-2.5), new Half(-4.5));
                var v = ov.swizzle.abag;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
                Assert.AreEqual(new Half(-7), v.w);
            }
            {
                var ov = new hvec4(new Half(-5.5), new Half(3), new Half(-6.5), new Half(-7.5));
                var v = ov.swizzle.abab;
                Assert.AreEqual(new Half(-7.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-7.5), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(9), new Half(-1), new Half(-4));
                var v = ov.swizzle.abaa;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-1), v.y);
                Assert.AreEqual(new Half(-4), v.z);
                Assert.AreEqual(new Half(-4), v.w);
            }
            {
                var ov = new hvec4(new Half(-9), new Half(-0.5), new Half(4), new Half(-6));
                var v = ov.swizzle.aa;
                Assert.AreEqual(new Half(-6), v.x);
                Assert.AreEqual(new Half(-6), v.y);
            }
            {
                var ov = new hvec4(new Half(-8.5), new Half(0.5), new Half(-4.5), new Half(5.5));
                var v = ov.swizzle.aar;
                Assert.AreEqual(new Half(5.5), v.x);
                Assert.AreEqual(new Half(5.5), v.y);
                Assert.AreEqual(new Half(-8.5), v.z);
            }
            {
                var ov = new hvec4(new Half(-1), new Half(8), new Half(9.5), new Half(-6.5));
                var v = ov.swizzle.aarr;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-1), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(-1), new Half(3), new Half(6.5));
                var v = ov.swizzle.aarg;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(7.5), v.z);
                Assert.AreEqual(new Half(-1), v.w);
            }
            {
                var ov = new hvec4(new Half(8), new Half(-7), new Half(-8), new Half(-2));
                var v = ov.swizzle.aarb;
                Assert.AreEqual(new Half(-2), v.x);
                Assert.AreEqual(new Half(-2), v.y);
                Assert.AreEqual(new Half(8), v.z);
                Assert.AreEqual(new Half(-8), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(7.5), new Half(-5), new Half(6));
                var v = ov.swizzle.aara;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(new Half(6), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(7), new Half(-7.5), new Half(6));
                var v = ov.swizzle.aag;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(7), v.z);
            }
            {
                var ov = new hvec4(new Half(0.5), new Half(-3.5), new Half(-1), new Half(-5.5));
                var v = ov.swizzle.aagr;
                Assert.AreEqual(new Half(-5.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-7.5), new Half(-5), new Half(-7), new Half(6));
                var v = ov.swizzle.aagg;
                Assert.AreEqual(new Half(6), v.x);
                Assert.AreEqual(new Half(6), v.y);
                Assert.AreEqual(new Half(-5), v.z);
                Assert.AreEqual(new Half(-5), v.w);
            }
            {
                var ov = new hvec4(new Half(-6), new Half(-2), new Half(-0.5), new Half(-7));
                var v = ov.swizzle.aagb;
                Assert.AreEqual(new Half(-7), v.x);
                Assert.AreEqual(new Half(-7), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-3.5), new Half(9.5), Half.One, new Half(-3.5));
                var v = ov.swizzle.aaga;
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(9.5), v.z);
                Assert.AreEqual(new Half(-3.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-8), new Half(3), new Half(-2.5), new Half(-3));
                var v = ov.swizzle.aab;
                Assert.AreEqual(new Half(-3), v.x);
                Assert.AreEqual(new Half(-3), v.y);
                Assert.AreEqual(new Half(-2.5), v.z);
            }
            {
                var ov = new hvec4(new Half(9.5), new Half(-2.5), new Half(-3), new Half(8.5));
                var v = ov.swizzle.aabr;
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(8.5), v.y);
                Assert.AreEqual(new Half(-3), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(2.5), new Half(9.5), new Half(4.5), new Half(-8.5));
                var v = ov.swizzle.aabg;
                Assert.AreEqual(new Half(-8.5), v.x);
                Assert.AreEqual(new Half(-8.5), v.y);
                Assert.AreEqual(new Half(4.5), v.z);
                Assert.AreEqual(new Half(9.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-4), new Half(7.5), new Half(2), new Half(-4));
                var v = ov.swizzle.aabb;
                Assert.AreEqual(new Half(-4), v.x);
                Assert.AreEqual(new Half(-4), v.y);
                Assert.AreEqual(new Half(2), v.z);
                Assert.AreEqual(new Half(2), v.w);
            }
            {
                var ov = new hvec4(new Half(7), new Half(-8), new Half(4), new Half(-4.5));
                var v = ov.swizzle.aaba;
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(-4.5), v.y);
                Assert.AreEqual(new Half(4), v.z);
                Assert.AreEqual(new Half(-4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(7.5), new Half(-6), Half.Zero, new Half(-6.5));
                var v = ov.swizzle.aaa;
                Assert.AreEqual(new Half(-6.5), v.x);
                Assert.AreEqual(new Half(-6.5), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
            }
            {
                var ov = new hvec4(new Half(4.5), new Half(7.5), new Half(-8.5), new Half(6.5));
                var v = ov.swizzle.aaar;
                Assert.AreEqual(new Half(6.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(6.5), v.z);
                Assert.AreEqual(new Half(4.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-1.5), Half.One, new Half(-4.5), new Half(-9.5));
                var v = ov.swizzle.aaag;
                Assert.AreEqual(new Half(-9.5), v.x);
                Assert.AreEqual(new Half(-9.5), v.y);
                Assert.AreEqual(new Half(-9.5), v.z);
                Assert.AreEqual(Half.One, v.w);
            }
            {
                var ov = new hvec4(new Half(5.5), new Half(-0.5), new Half(-0.5), new Half(9));
                var v = ov.swizzle.aaab;
                Assert.AreEqual(new Half(9), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(new Half(9), v.z);
                Assert.AreEqual(new Half(-0.5), v.w);
            }
            {
                var ov = new hvec4(new Half(-9.5), new Half(9), new Half(6), new Half(3));
                var v = ov.swizzle.aaaa;
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new hvec4(new Half(3), new Half(8), new Half(5.5), new Half(3.5));
                var v1 = new hvec2(new Half(-6), new Half(7));
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-6), v0.x);
                Assert.AreEqual(new Half(7), v0.y);
                Assert.AreEqual(new Half(5.5), v0.z);
                Assert.AreEqual(new Half(3.5), v0.w);
            
                Assert.AreEqual(new Half(3), v2.x);
                Assert.AreEqual(new Half(8), v2.y);
            }
            {
                var v0 = new hvec4(new Half(-5.5), new Half(-8.5), new Half(7.5), new Half(-6.5));
                var v1 = new hvec2(new Half(-3), new Half(-5.5));
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-3), v0.x);
                Assert.AreEqual(new Half(-8.5), v0.y);
                Assert.AreEqual(new Half(-5.5), v0.z);
                Assert.AreEqual(new Half(-6.5), v0.w);
            
                Assert.AreEqual(new Half(-5.5), v2.x);
                Assert.AreEqual(new Half(7.5), v2.y);
            }
            {
                var v0 = new hvec4(new Half(-3.5), new Half(1.5), new Half(3), new Half(-9.5));
                var v1 = new hvec2(new Half(0.5), new Half(-1.5));
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-3.5), v0.x);
                Assert.AreEqual(new Half(0.5), v0.y);
                Assert.AreEqual(new Half(-1.5), v0.z);
                Assert.AreEqual(new Half(-9.5), v0.w);
            
                Assert.AreEqual(new Half(1.5), v2.x);
                Assert.AreEqual(new Half(3), v2.y);
            }
            {
                var v0 = new hvec4(new Half(6), new Half(-3), new Half(-7.5), Half.Zero);
                var v1 = new hvec3(new Half(9.5), new Half(-3), new Half(5));
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(9.5), v0.x);
                Assert.AreEqual(new Half(-3), v0.y);
                Assert.AreEqual(new Half(5), v0.z);
                Assert.AreEqual(Half.Zero, v0.w);
            
                Assert.AreEqual(new Half(6), v2.x);
                Assert.AreEqual(new Half(-3), v2.y);
                Assert.AreEqual(new Half(-7.5), v2.z);
            }
            {
                var v0 = new hvec4(new Half(2), Half.One, new Half(-5.5), new Half(3));
                var v1 = new hvec2(new Half(3), new Half(-1));
                var v2 = v0.xw;
                v0.xw = v1;
                var v3 = v0.xw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(3), v0.x);
                Assert.AreEqual(Half.One, v0.y);
                Assert.AreEqual(new Half(-5.5), v0.z);
                Assert.AreEqual(new Half(-1), v0.w);
            
                Assert.AreEqual(new Half(2), v2.x);
                Assert.AreEqual(new Half(3), v2.y);
            }
            {
                var v0 = new hvec4(new Half(-6.5), new Half(9), new Half(4), new Half(-1.5));
                var v1 = new hvec2(new Half(8), new Half(-8.5));
                var v2 = v0.yw;
                v0.yw = v1;
                var v3 = v0.yw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-6.5), v0.x);
                Assert.AreEqual(new Half(8), v0.y);
                Assert.AreEqual(new Half(4), v0.z);
                Assert.AreEqual(new Half(-8.5), v0.w);
            
                Assert.AreEqual(new Half(9), v2.x);
                Assert.AreEqual(new Half(-1.5), v2.y);
            }
            {
                var v0 = new hvec4(new Half(4), new Half(-4), new Half(-3), new Half(-2.5));
                var v1 = new hvec3(new Half(-8), new Half(-9), new Half(-8.5));
                var v2 = v0.xyw;
                v0.xyw = v1;
                var v3 = v0.xyw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-8), v0.x);
                Assert.AreEqual(new Half(-9), v0.y);
                Assert.AreEqual(new Half(-3), v0.z);
                Assert.AreEqual(new Half(-8.5), v0.w);
            
                Assert.AreEqual(new Half(4), v2.x);
                Assert.AreEqual(new Half(-4), v2.y);
                Assert.AreEqual(new Half(-2.5), v2.z);
            }
            {
                var v0 = new hvec4(new Half(9), new Half(-6.5), new Half(8), new Half(4));
                var v1 = new hvec2(new Half(4.5), new Half(-5));
                var v2 = v0.zw;
                v0.zw = v1;
                var v3 = v0.zw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(9), v0.x);
                Assert.AreEqual(new Half(-6.5), v0.y);
                Assert.AreEqual(new Half(4.5), v0.z);
                Assert.AreEqual(new Half(-5), v0.w);
            
                Assert.AreEqual(new Half(8), v2.x);
                Assert.AreEqual(new Half(4), v2.y);
            }
            {
                var v0 = new hvec4(new Half(-2), new Half(-8.5), new Half(6), new Half(-9));
                var v1 = new hvec3(new Half(-8), new Half(2), new Half(8));
                var v2 = v0.xzw;
                v0.xzw = v1;
                var v3 = v0.xzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-8), v0.x);
                Assert.AreEqual(new Half(-8.5), v0.y);
                Assert.AreEqual(new Half(2), v0.z);
                Assert.AreEqual(new Half(8), v0.w);
            
                Assert.AreEqual(new Half(-2), v2.x);
                Assert.AreEqual(new Half(6), v2.y);
                Assert.AreEqual(new Half(-9), v2.z);
            }
            {
                var v0 = new hvec4(new Half(-7.5), new Half(-2.5), new Half(-3), new Half(5));
                var v1 = new hvec3(new Half(9.5), new Half(-7), new Half(4.5));
                var v2 = v0.yzw;
                v0.yzw = v1;
                var v3 = v0.yzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-7.5), v0.x);
                Assert.AreEqual(new Half(9.5), v0.y);
                Assert.AreEqual(new Half(-7), v0.z);
                Assert.AreEqual(new Half(4.5), v0.w);
            
                Assert.AreEqual(new Half(-2.5), v2.x);
                Assert.AreEqual(new Half(-3), v2.y);
                Assert.AreEqual(new Half(5), v2.z);
            }
            {
                var v0 = new hvec4(new Half(-3), new Half(-0.5), new Half(-5), new Half(-7.5));
                var v1 = new hvec4(new Half(3), new Half(4.5), new Half(9.5), new Half(-4.5));
                var v2 = v0.xyzw;
                v0.xyzw = v1;
                var v3 = v0.xyzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(3), v0.x);
                Assert.AreEqual(new Half(4.5), v0.y);
                Assert.AreEqual(new Half(9.5), v0.z);
                Assert.AreEqual(new Half(-4.5), v0.w);
            
                Assert.AreEqual(new Half(-3), v2.x);
                Assert.AreEqual(new Half(-0.5), v2.y);
                Assert.AreEqual(new Half(-5), v2.z);
                Assert.AreEqual(new Half(-7.5), v2.w);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new hvec4(new Half(3.5), Half.Zero, new Half(2.5), new Half(-5));
                var v1 = new Half(new Half(4));
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(4), v0.x);
                Assert.AreEqual(Half.Zero, v0.y);
                Assert.AreEqual(new Half(2.5), v0.z);
                Assert.AreEqual(new Half(-5), v0.w);
            
                Assert.AreEqual(new Half(3.5), v2);
            }
            {
                var v0 = new hvec4(new Half(-5.5), Half.One, new Half(-4), new Half(7.5));
                var v1 = new Half(new Half(6));
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-5.5), v0.x);
                Assert.AreEqual(new Half(6), v0.y);
                Assert.AreEqual(new Half(-4), v0.z);
                Assert.AreEqual(new Half(7.5), v0.w);
            
                Assert.AreEqual(Half.One, v2);
            }
            {
                var v0 = new hvec4(new Half(-0.5), new Half(-0.5), new Half(-2.5), new Half(3.5));
                var v1 = new hvec2(new Half(1.5), new Half(-3));
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(1.5), v0.x);
                Assert.AreEqual(new Half(-3), v0.y);
                Assert.AreEqual(new Half(-2.5), v0.z);
                Assert.AreEqual(new Half(3.5), v0.w);
            
                Assert.AreEqual(new Half(-0.5), v2.x);
                Assert.AreEqual(new Half(-0.5), v2.y);
            }
            {
                var v0 = new hvec4(new Half(0.5), new Half(-6.5), new Half(2), new Half(-8.5));
                var v1 = new Half(new Half(6.5));
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(0.5), v0.x);
                Assert.AreEqual(new Half(-6.5), v0.y);
                Assert.AreEqual(new Half(6.5), v0.z);
                Assert.AreEqual(new Half(-8.5), v0.w);
            
                Assert.AreEqual(new Half(2), v2);
            }
            {
                var v0 = new hvec4(new Half(-8.5), new Half(8.5), new Half(-8), new Half(8.5));
                var v1 = new hvec2(new Half(-1), new Half(-3.5));
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-1), v0.x);
                Assert.AreEqual(new Half(8.5), v0.y);
                Assert.AreEqual(new Half(-3.5), v0.z);
                Assert.AreEqual(new Half(8.5), v0.w);
            
                Assert.AreEqual(new Half(-8.5), v2.x);
                Assert.AreEqual(new Half(-8), v2.y);
            }
            {
                var v0 = new hvec4(new Half(-4), Half.One, new Half(-2.5), Half.One);
                var v1 = new hvec2(new Half(-2), new Half(4));
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-4), v0.x);
                Assert.AreEqual(new Half(-2), v0.y);
                Assert.AreEqual(new Half(4), v0.z);
                Assert.AreEqual(Half.One, v0.w);
            
                Assert.AreEqual(Half.One, v2.x);
                Assert.AreEqual(new Half(-2.5), v2.y);
            }
            {
                var v0 = new hvec4(new Half(4.5), new Half(-7.5), new Half(3), new Half(5.5));
                var v1 = new hvec3(new Half(-0.5), new Half(-7), Half.One);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-0.5), v0.x);
                Assert.AreEqual(new Half(-7), v0.y);
                Assert.AreEqual(Half.One, v0.z);
                Assert.AreEqual(new Half(5.5), v0.w);
            
                Assert.AreEqual(new Half(4.5), v2.x);
                Assert.AreEqual(new Half(-7.5), v2.y);
                Assert.AreEqual(new Half(3), v2.z);
            }
            {
                var v0 = new hvec4(new Half(-4), Half.One, new Half(9), new Half(6.5));
                var v1 = new Half(new Half(7.5));
                var v2 = v0.a;
                v0.a = v1;
                var v3 = v0.a;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-4), v0.x);
                Assert.AreEqual(Half.One, v0.y);
                Assert.AreEqual(new Half(9), v0.z);
                Assert.AreEqual(new Half(7.5), v0.w);
            
                Assert.AreEqual(new Half(6.5), v2);
            }
            {
                var v0 = new hvec4(new Half(-5.5), new Half(7.5), new Half(3), new Half(-7));
                var v1 = new hvec2(new Half(-6), Half.Zero);
                var v2 = v0.ra;
                v0.ra = v1;
                var v3 = v0.ra;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-6), v0.x);
                Assert.AreEqual(new Half(7.5), v0.y);
                Assert.AreEqual(new Half(3), v0.z);
                Assert.AreEqual(Half.Zero, v0.w);
            
                Assert.AreEqual(new Half(-5.5), v2.x);
                Assert.AreEqual(new Half(-7), v2.y);
            }
            {
                var v0 = new hvec4(new Half(-7.5), new Half(-1.5), new Half(4), new Half(-7.5));
                var v1 = new hvec2(new Half(-2), Half.One);
                var v2 = v0.ga;
                v0.ga = v1;
                var v3 = v0.ga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-7.5), v0.x);
                Assert.AreEqual(new Half(-2), v0.y);
                Assert.AreEqual(new Half(4), v0.z);
                Assert.AreEqual(Half.One, v0.w);
            
                Assert.AreEqual(new Half(-1.5), v2.x);
                Assert.AreEqual(new Half(-7.5), v2.y);
            }
            {
                var v0 = new hvec4(new Half(-5), new Half(-6), new Half(3.5), new Half(8.5));
                var v1 = new hvec3(new Half(-1.5), new Half(-2), new Half(-1));
                var v2 = v0.rga;
                v0.rga = v1;
                var v3 = v0.rga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-1.5), v0.x);
                Assert.AreEqual(new Half(-2), v0.y);
                Assert.AreEqual(new Half(3.5), v0.z);
                Assert.AreEqual(new Half(-1), v0.w);
            
                Assert.AreEqual(new Half(-5), v2.x);
                Assert.AreEqual(new Half(-6), v2.y);
                Assert.AreEqual(new Half(8.5), v2.z);
            }
            {
                var v0 = new hvec4(new Half(5), new Half(-7), new Half(-4.5), new Half(3.5));
                var v1 = new hvec2(new Half(-1), new Half(-2.5));
                var v2 = v0.ba;
                v0.ba = v1;
                var v3 = v0.ba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(5), v0.x);
                Assert.AreEqual(new Half(-7), v0.y);
                Assert.AreEqual(new Half(-1), v0.z);
                Assert.AreEqual(new Half(-2.5), v0.w);
            
                Assert.AreEqual(new Half(-4.5), v2.x);
                Assert.AreEqual(new Half(3.5), v2.y);
            }
            {
                var v0 = new hvec4(new Half(-7), Half.One, new Half(5), Half.Zero);
                var v1 = new hvec3(new Half(7), new Half(4.5), new Half(-2));
                var v2 = v0.rba;
                v0.rba = v1;
                var v3 = v0.rba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(7), v0.x);
                Assert.AreEqual(Half.One, v0.y);
                Assert.AreEqual(new Half(4.5), v0.z);
                Assert.AreEqual(new Half(-2), v0.w);
            
                Assert.AreEqual(new Half(-7), v2.x);
                Assert.AreEqual(new Half(5), v2.y);
                Assert.AreEqual(Half.Zero, v2.z);
            }
            {
                var v0 = new hvec4(Half.One, new Half(-8.5), new Half(-4), new Half(-4));
                var v1 = new hvec3(new Half(-6.5), new Half(6.5), new Half(-3.5));
                var v2 = v0.gba;
                v0.gba = v1;
                var v3 = v0.gba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(Half.One, v0.x);
                Assert.AreEqual(new Half(-6.5), v0.y);
                Assert.AreEqual(new Half(6.5), v0.z);
                Assert.AreEqual(new Half(-3.5), v0.w);
            
                Assert.AreEqual(new Half(-8.5), v2.x);
                Assert.AreEqual(new Half(-4), v2.y);
                Assert.AreEqual(new Half(-4), v2.z);
            }
            {
                var v0 = new hvec4(new Half(-2.5), new Half(-9), new Half(-5.5), new Half(9.5));
                var v1 = new hvec4(new Half(-3), new Half(9), Half.One, new Half(-8.5));
                var v2 = v0.rgba;
                v0.rgba = v1;
                var v3 = v0.rgba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Half(-3), v0.x);
                Assert.AreEqual(new Half(9), v0.y);
                Assert.AreEqual(Half.One, v0.z);
                Assert.AreEqual(new Half(-8.5), v0.w);
            
                Assert.AreEqual(new Half(-2.5), v2.x);
                Assert.AreEqual(new Half(-9), v2.y);
                Assert.AreEqual(new Half(-5.5), v2.z);
                Assert.AreEqual(new Half(9.5), v2.w);
            }
        }

    }
}
