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
    public class FloatSwizzleVec3Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new vec3(-9.5f, -6, 2);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
            }
            {
                var ov = new vec3(-3, -8, -6.5f);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new vec3(8, 0f, -1.5f);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new vec3(-8, 6, 9);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new vec3(-9, 9, 7.5f);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(4.5f, -8.5f, 3.5f);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec3(1.5f, -1, 2.5f);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec3(6, -8.5f, -2.5f);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(9, 5, -1.5f);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec3(9.5f, -0.5f, -9);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new vec3(5.5f, 2, -3.5f);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec3(-4.5f, -3.5f, -6);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec3(-5, 5, 6.5f);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec3(2.5f, 2, -9.5f);
                var v = ov.swizzle.xy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var ov = new vec3(5, 0.5f, 7);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new vec3(4, -4, -1.5f);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new vec3(8, 9, 5);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new vec3(9, 2.5f, 0.5f);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec3(5.5f, -3, 4.5f);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new vec3(-6, 3, -3);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new vec3(5.5f, 9, -2);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new vec3(8, -6.5f, 3);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new vec3(-6.5f, 3.5f, -5.5f);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
            }
            {
                var ov = new vec3(-7.5f, -9, -5);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(7.5f, 9.5f, 7);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec3(-2, 1f, 0.5f);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec3(-9.5f, 5, 1.5f);
                var v = ov.swizzle.xz;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
            }
            {
                var ov = new vec3(9.5f, 0.5f, -9);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(9.5f, v.z);
            }
            {
                var ov = new vec3(-3, -4.5f, -1);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new vec3(5.5f, 0.5f, -3);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec3(-8.5f, 9.5f, 2);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new vec3(-6.5f, 6.5f, 3.5f);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
            }
            {
                var ov = new vec3(8, 7.5f, 6);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new vec3(3, -8.5f, -8.5f);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(4, -2.5f, 1.5f);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, -3, 3.5f);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
            }
            {
                var ov = new vec3(-7.5f, -5.5f, -2);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(3, 5.5f, 8.5f);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec3(-7.5f, 6.5f, -9);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new vec3(3.5f, 6.5f, 8.5f);
                var v = ov.swizzle.yx;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
            }
            {
                var ov = new vec3(3.5f, -2.5f, 2);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
            }
            {
                var ov = new vec3(-1, 0f, -9.5f);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new vec3(-3, -4, 2);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new vec3(-5, 3, 4);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new vec3(-5.5f, -6, -5.5f);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var ov = new vec3(-1, 4.5f, 3);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new vec3(-2.5f, -7.5f, -3);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(-7, -3, 5);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new vec3(1f, -7, 3);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new vec3(3, 1f, 0f);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new vec3(-5, -5, 0f);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new vec3(8, -1, 4.5f);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec3(-8, 4.5f, -2.5f);
                var v = ov.swizzle.yy;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
            }
            {
                var ov = new vec3(-2, -8, 8.5f);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var ov = new vec3(1.5f, 7, -8.5f);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec3(7, -9.5f, -9);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(-5, -2, 1f);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(-6, 5, -5);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new vec3(-3.5f, -7, -4);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec3(7.5f, 9, -6.5f);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new vec3(-6, 8, -3);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new vec3(2, 9.5f, -1.5f);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
            }
            {
                var ov = new vec3(3, -5, 5);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new vec3(0.5f, 2.5f, 0f);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(-6, -6, 3);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new vec3(-4, -3.5f, 5);
                var v = ov.swizzle.yz;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var ov = new vec3(-4.5f, 3.5f, 7.5f);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
            }
            {
                var ov = new vec3(-5.5f, -0.5f, 0.5f);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec3(8.5f, 8.5f, 8);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(-3.5f, -7.5f, 3.5f);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(-9.5f, -8.5f, -4.5f);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec3(4, 6.5f, 8);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new vec3(-3.5f, -0.5f, 7);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec3(2.5f, 4, 5);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new vec3(-4, -5.5f, -9);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new vec3(1f, 9.5f, 0.5f);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(-1, -2, 0.5f);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new vec3(8, -2, -6);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new vec3(-3.5f, 1.5f, -9.5f);
                var v = ov.swizzle.zx;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
            }
            {
                var ov = new vec3(-7.5f, 3, 1f);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
            }
            {
                var ov = new vec3(-9, -8, 2.5f);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new vec3(-2, 9, -2);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new vec3(-6, -2, -9.5f);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(5.5f, -1.5f, 7.5f);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
            }
            {
                var ov = new vec3(7.5f, 3.5f, -0.5f);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, -1, 4);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new vec3(-1, 7.5f, 9.5f);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec3(-9, -5, -1);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-1, v.z);
            }
            {
                var ov = new vec3(3, -2, 8);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new vec3(8, -8, 4);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new vec3(-0.5f, 3, -4.5f);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec3(6, -3, -3.5f);
                var v = ov.swizzle.zy;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3, v.y);
            }
            {
                var ov = new vec3(-3, 1f, -5);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new vec3(7, -3.5f, -1.5f);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new vec3(9, -6, -5.5f);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new vec3(2.5f, -2, -9);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new vec3(-3.5f, 4.5f, -9.5f);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
            }
            {
                var ov = new vec3(-5, -2, 6);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new vec3(1f, 0f, 2);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec3(-7.5f, 8, 8.5f);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(2, 6, 3.5f);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(3.5f, v.z);
            }
            {
                var ov = new vec3(-5, 5, -4.5f);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new vec3(-2, 0.5f, -9.5f);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec3(2, -9, 8);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new vec3(0.5f, 3, -1);
                var v = ov.swizzle.zz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
            }
            {
                var ov = new vec3(-1, 8, 9.5f);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-1, v.z);
            }
            {
                var ov = new vec3(-2.5f, -1, 9.5f);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec3(0.5f, -7.5f, -5.5f);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(-4.5f, -5, 2.5f);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(-9, 4, -3);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(4, v.z);
            }
            {
                var ov = new vec3(-5.5f, 0.5f, 3.5f);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec3(-7, 5, -9);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new vec3(4.5f, 5.5f, 9);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new vec3(8.5f, -9.5f, -8.5f);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec3(8.5f, -5.5f, -5);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(-2, -5.5f, 7);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec3(5.5f, 0.5f, 1.5f);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new vec3(5.5f, -3.5f, -5);
                var v = ov.swizzle.rr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
            }
            {
                var ov = new vec3(-1.5f, 3.5f, 7.5f);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
            }
            {
                var ov = new vec3(-2.5f, 9, 8.5f);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec3(4.5f, 3.5f, -3);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(-8.5f, 7, -5.5f);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec3(-6.5f, 2, 3.5f);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new vec3(8.5f, 1f, 1f);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(1f, 2, -2);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new vec3(-4.5f, -1, -1);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new vec3(6, -0.5f, 7.5f);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(7.5f, v.z);
            }
            {
                var ov = new vec3(-8, -0.5f, -4.5f);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new vec3(7.5f, 2.5f, -6.5f);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(2.5f, 8.5f, 6);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new vec3(6.5f, 1f, -8);
                var v = ov.swizzle.rg;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(1f, v.y);
            }
            {
                var ov = new vec3(0f, -8.5f, -5);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var ov = new vec3(5, -2, -1);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new vec3(-9, 8, 6.5f);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new vec3(-6.5f, -3.5f, 3.5f);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(9.5f, 4.5f, -5.5f);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
            }
            {
                var ov = new vec3(2, 2, -7.5f);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new vec3(-3.5f, -9.5f, -8.5f);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(1f, -7, 4);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new vec3(-1.5f, -6.5f, -5);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new vec3(1f, 1.5f, 4);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(-2.5f, 1f, 9.5f);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(-5.5f, 1f, -8.5f);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(7.5f, -9.5f, 8.5f);
                var v = ov.swizzle.rb;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
            }
            {
                var ov = new vec3(0f, -2.5f, -8.5f);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var ov = new vec3(1f, 4.5f, 2);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(2.5f, 7.5f, 8.5f);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(8.5f, -0.5f, 5.5f);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec3(-5.5f, 9, -7.5f);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new vec3(7.5f, 9.5f, 4);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(-1, -7, -1.5f);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new vec3(5.5f, -8, -8);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new vec3(1.5f, 6.5f, -5.5f);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
            }
            {
                var ov = new vec3(3.5f, -6, 3.5f);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(3, 5, -7.5f);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new vec3(-6.5f, -3.5f, 2.5f);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(9.5f, 9.5f, -6.5f);
                var v = ov.swizzle.gr;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
            }
            {
                var ov = new vec3(1f, 6.5f, -3.5f);
                var v = ov.swizzle.grr;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
            }
            {
                var ov = new vec3(-7, 3, 1f);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new vec3(9, 2, 1.5f);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new vec3(-8, -2.5f, 1f);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(-6, -2.5f, 3);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-2.5f, v.z);
            }
            {
                var ov = new vec3(9, 4, 9);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new vec3(2, 9, 7.5f);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new vec3(-8, 8.5f, -7.5f);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(4, 4.5f, -6.5f);
                var v = ov.swizzle.grb;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-6.5f, v.z);
            }
            {
                var ov = new vec3(-4, 0f, -5.5f);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new vec3(-0.5f, 7.5f, 9.5f);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(-7.5f, 8, -9.5f);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(2, -9, -5);
                var v = ov.swizzle.gg;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
            }
            {
                var ov = new vec3(-6, -7.5f, 4.5f);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var ov = new vec3(3.5f, -5, -0.5f);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, -2.5f, -9);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec3(-9, -3, -8.5f);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(-6.5f, 7.5f, 0.5f);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
            }
            {
                var ov = new vec3(-4.5f, -6.5f, 7.5f);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec3(3, -2, 8);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new vec3(-9, 6.5f, 1f);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec3(7, -0.5f, -0.5f);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var ov = new vec3(2, 4.5f, -8);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new vec3(-6.5f, 7, -3.5f);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new vec3(4.5f, -2.5f, -1.5f);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec3(3, -4.5f, -5.5f);
                var v = ov.swizzle.gb;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
            }
            {
                var ov = new vec3(3.5f, -4, 7);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(3.5f, v.z);
            }
            {
                var ov = new vec3(4, 4.5f, -2.5f);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new vec3(2, 5, 0f);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new vec3(9, 6.5f, -3.5f);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec3(-6.5f, 9.5f, 6);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(9.5f, v.z);
            }
            {
                var ov = new vec3(5, 7.5f, -3.5f);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new vec3(2.5f, -4.5f, -3.5f);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec3(9.5f, -1.5f, 2.5f);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec3(0f, 5.5f, 5);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new vec3(5.5f, -0.5f, 9);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec3(1f, -7.5f, 7.5f);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec3(-4, -1, 8.5f);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(1f, -4, 1f);
                var v = ov.swizzle.br;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
            }
            {
                var ov = new vec3(-4, 4, -6.5f);
                var v = ov.swizzle.brr;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new vec3(-0.5f, 3.5f, 8.5f);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, 0f, 7);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec3(-9, -0.5f, 0.5f);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec3(2, -1, 0f);
                var v = ov.swizzle.brg;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-1, v.z);
            }
            {
                var ov = new vec3(7.5f, 3.5f, -4.5f);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec3(-5, 3, 8.5f);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new vec3(-8.5f, 7, -7);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new vec3(0.5f, 7, -5);
                var v = ov.swizzle.brb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new vec3(-0.5f, 8, -1.5f);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec3(8, 4, -6.5f);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new vec3(-5.5f, -8, -8.5f);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec3(2, -1, 4.5f);
                var v = ov.swizzle.bg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-1, v.y);
            }
            {
                var ov = new vec3(4.5f, 8, 5.5f);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(4.5f, v.z);
            }
            {
                var ov = new vec3(8.5f, -6, 0f);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(-9.5f, 8.5f, -1);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(7.5f, -6, -7);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new vec3(-3, -2.5f, 9);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
            }
            {
                var ov = new vec3(2, 3.5f, 6.5f);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new vec3(6, 8.5f, -3.5f);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec3(-6.5f, 2, 1.5f);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec3(-9, -1, -5.5f);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-5.5f, v.z);
            }
            {
                var ov = new vec3(7, -8, 2.5f);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new vec3(-9, 5.5f, -6.5f);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec3(1.5f, -9.5f, 5.5f);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec3(3, -6.5f, 2.5f);
                var v = ov.swizzle.bb;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
            }
            {
                var ov = new vec3(-7, -1, 8);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var ov = new vec3(3, 1.5f, 2.5f);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new vec3(-2, 6.5f, -8);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec3(-3, -7.5f, -4.5f);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec3(-5.5f, 6.5f, -2);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(6.5f, v.z);
            }
            {
                var ov = new vec3(8, -1, 5);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new vec3(4, -9, 5);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new vec3(-6, -3, -9.5f);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec3(-8, -8, -8.5f);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec3(3.5f, -7.5f, 6);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec3(-5, 9.5f, 9);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec3(4, 0.5f, -2.5f);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new vec3(3.5f, 6, -9);
                var v1 = new vec2(9.5f, -8);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9.5f, v0.x);
                Assert.AreEqual(-8, v0.y);
                Assert.AreEqual(-9, v0.z);
            
                Assert.AreEqual(3.5f, v2.x);
                Assert.AreEqual(6, v2.y);
            }
            {
                var v0 = new vec3(0f, 5.5f, 7);
                var v1 = new vec2(-8.5f, 8);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8.5f, v0.x);
                Assert.AreEqual(5.5f, v0.y);
                Assert.AreEqual(8, v0.z);
            
                Assert.AreEqual(0f, v2.x);
                Assert.AreEqual(7, v2.y);
            }
            {
                var v0 = new vec3(3, 9.5f, 3.5f);
                var v1 = new vec2(9, 0.5f);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3, v0.x);
                Assert.AreEqual(9, v0.y);
                Assert.AreEqual(0.5f, v0.z);
            
                Assert.AreEqual(9.5f, v2.x);
                Assert.AreEqual(3.5f, v2.y);
            }
            {
                var v0 = new vec3(-0.5f, -8.5f, -1);
                var v1 = new vec3(3, 7, 3);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3, v0.x);
                Assert.AreEqual(7, v0.y);
                Assert.AreEqual(3, v0.z);
            
                Assert.AreEqual(-0.5f, v2.x);
                Assert.AreEqual(-8.5f, v2.y);
                Assert.AreEqual(-1, v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new vec3(-2, 0.5f, -4.5f);
                var v1 = (float)2;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2, v0.x);
                Assert.AreEqual(0.5f, v0.y);
                Assert.AreEqual(-4.5f, v0.z);
            
                Assert.AreEqual(-2, v2);
            }
            {
                var v0 = new vec3(-7.5f, -1.5f, -0.5f);
                var v1 = (float)7;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-7.5f, v0.x);
                Assert.AreEqual(7, v0.y);
                Assert.AreEqual(-0.5f, v0.z);
            
                Assert.AreEqual(-1.5f, v2);
            }
            {
                var v0 = new vec3(-8, -7, -7.5f);
                var v1 = new vec2(-5, 6.5f);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5, v0.x);
                Assert.AreEqual(6.5f, v0.y);
                Assert.AreEqual(-7.5f, v0.z);
            
                Assert.AreEqual(-8, v2.x);
                Assert.AreEqual(-7, v2.y);
            }
            {
                var v0 = new vec3(6.5f, -3.5f, -9);
                var v1 = (float)-2;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6.5f, v0.x);
                Assert.AreEqual(-3.5f, v0.y);
                Assert.AreEqual(-2, v0.z);
            
                Assert.AreEqual(-9, v2);
            }
            {
                var v0 = new vec3(-7.5f, 8.5f, -6);
                var v1 = new vec2(7.5f, 0.5f);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(7.5f, v0.x);
                Assert.AreEqual(8.5f, v0.y);
                Assert.AreEqual(0.5f, v0.z);
            
                Assert.AreEqual(-7.5f, v2.x);
                Assert.AreEqual(-6, v2.y);
            }
            {
                var v0 = new vec3(-0.5f, -9, 7);
                var v1 = new vec2(-1.5f, 7.5f);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-0.5f, v0.x);
                Assert.AreEqual(-1.5f, v0.y);
                Assert.AreEqual(7.5f, v0.z);
            
                Assert.AreEqual(-9, v2.x);
                Assert.AreEqual(7, v2.y);
            }
            {
                var v0 = new vec3(-6.5f, 5, -7.5f);
                var v1 = new vec3(-9, -9, 0f);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-9, v0.x);
                Assert.AreEqual(-9, v0.y);
                Assert.AreEqual(0f, v0.z);
            
                Assert.AreEqual(-6.5f, v2.x);
                Assert.AreEqual(5, v2.y);
                Assert.AreEqual(-7.5f, v2.z);
            }
        }

    }
}
