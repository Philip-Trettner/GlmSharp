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
    public class FloatSwizzleVec4Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new vec4(8f, -6.5f, -6f, 9f);
                var v = ov.swizzle.xx;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
            }
            {
                var ov = new vec4(8.5f, -4.5f, 5f, -2.5f);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
            }
            {
                var ov = new vec4(-2.5f, 1f, 4.5f, 5f);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(8f, 6.5f, 8f, 5f);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(-7.5f, -5.5f, -9.5f, -6.5f);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 5f, 5.5f, -2f);
                var v = ov.swizzle.xxxw;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(-0.5f, 5.5f, 3.5f, 6f);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
            }
            {
                var ov = new vec4(-7.5f, 2f, -1f, -7.5f);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 2f, 7f, 8.5f);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(-8f, 1.5f, -5f, 2f);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(6.5f, -2f, 6f, 0f);
                var v = ov.swizzle.xxyw;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(8f, -3f, 2f, -2.5f);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec4(0.5f, 3.5f, 5.5f, -8f);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, -9.5f, 8f, 2f);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-2.5f, 3f, -9.5f, 3f);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, 8.5f, 5f, -4.5f);
                var v = ov.swizzle.xxzw;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, -3f, 9f, 5f);
                var v = ov.swizzle.xxw;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(5f, v.z);
            }
            {
                var ov = new vec4(-1.5f, 9f, -1.5f, 1.5f);
                var v = ov.swizzle.xxwx;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec4(8f, -7f, -2.5f, -5.5f);
                var v = ov.swizzle.xxwy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(9.5f, 4.5f, 2f, -6f);
                var v = ov.swizzle.xxwz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(3.5f, 5f, -7f, -0.5f);
                var v = ov.swizzle.xxww;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(6f, 2.5f, 1.5f, -6f);
                var v = ov.swizzle.xy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(2.5f, v.y);
            }
            {
                var ov = new vec4(4.5f, 4f, -2f, -4f);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4.5f, v.z);
            }
            {
                var ov = new vec4(-1f, -2f, -2f, 7.5f);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(5f, -8.5f, 9f, 5.5f);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(3f, 6.5f, 9.5f, -9.5f);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(4f, 4f, 8f, -4f);
                var v = ov.swizzle.xyxw;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(3.5f, -5.5f, 3f, 2.5f);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
            }
            {
                var ov = new vec4(1f, 3f, -1f, -4.5f);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(-7.5f, -7f, -8f, 8.5f);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(-7.5f, 4.5f, -1f, -6.5f);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(8.5f, -4f, -9.5f, 7.5f);
                var v = ov.swizzle.xyyw;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec4(5f, -0.5f, -8f, -8f);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-8f, v.z);
            }
            {
                var ov = new vec4(-4.5f, 6f, -3f, 6.5f);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(6f, 6.5f, -5.5f, 2f);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(-6.5f, -8f, -6.5f, 9f);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(1f, -9f, -3f, 7f);
                var v = ov.swizzle.xyzw;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(0f, -3.5f, -5f, -0.5f);
                var v = ov.swizzle.xyw;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var ov = new vec4(2f, -2f, -4f, 8f);
                var v = ov.swizzle.xywx;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(-3.5f, -6f, -7.5f, 1.5f);
                var v = ov.swizzle.xywy;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(-4.5f, -2f, 7f, 3f);
                var v = ov.swizzle.xywz;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(5f, -4.5f, 7f, 4.5f);
                var v = ov.swizzle.xyww;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, -5f, -9f, -3.5f);
                var v = ov.swizzle.xz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-9f, v.y);
            }
            {
                var ov = new vec4(2.5f, -6f, -5f, 4f);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(2.5f, v.z);
            }
            {
                var ov = new vec4(-2f, 1f, -8.5f, -9.5f);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(0f, -2f, 6.5f, -9.5f);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(-5f, -0.5f, -6f, -4f);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(3.5f, 3f, -1f, 0.5f);
                var v = ov.swizzle.xzxw;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(-4f, 2.5f, -8f, -2f);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(2.5f, v.z);
            }
            {
                var ov = new vec4(9f, -9.5f, 3f, -7f);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(-1f, -9f, -7f, -3.5f);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(6f, -0.5f, 6.5f, -2.5f);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(6.5f, 8f, 7.5f, -5.5f);
                var v = ov.swizzle.xzyw;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 1f, 1.5f, -3f);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
            }
            {
                var ov = new vec4(-5f, -1.5f, -1.5f, -7f);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(9f, 4.5f, 1f, -2.5f);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(4f, -0.5f, -2f, 9.5f);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(7.5f, 2f, 4.5f, 2.5f);
                var v = ov.swizzle.xzzw;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(7.5f, 4f, 8f, -7.5f);
                var v = ov.swizzle.xzw;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-7.5f, v.z);
            }
            {
                var ov = new vec4(5.5f, -1f, -3f, -3.5f);
                var v = ov.swizzle.xzwx;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(2.5f, -0.5f, -7f, -5.5f);
                var v = ov.swizzle.xzwy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(6f, -3.5f, 5.5f, -3f);
                var v = ov.swizzle.xzwz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(1f, 5f, 7.5f, -7.5f);
                var v = ov.swizzle.xzww;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, -2.5f, 6f, -7f);
                var v = ov.swizzle.xw;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-7f, v.y);
            }
            {
                var ov = new vec4(-7f, -0.5f, -7.5f, -8f);
                var v = ov.swizzle.xwx;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-7f, v.z);
            }
            {
                var ov = new vec4(-7f, 6.5f, -0.5f, 3.5f);
                var v = ov.swizzle.xwxx;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(-5f, 5f, -2.5f, 0.5f);
                var v = ov.swizzle.xwxy;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(3.5f, 9f, -7f, 4f);
                var v = ov.swizzle.xwxz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(-5f, 2f, -4.5f, -8.5f);
                var v = ov.swizzle.xwxw;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(-7f, -7f, -8.5f, -8f);
                var v = ov.swizzle.xwy;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-7f, v.z);
            }
            {
                var ov = new vec4(4.5f, 9.5f, 8.5f, 2.5f);
                var v = ov.swizzle.xwyx;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(5f, -3f, 0f, -1f);
                var v = ov.swizzle.xwyy;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(7.5f, 1.5f, 4f, 6f);
                var v = ov.swizzle.xwyz;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(-1.5f, 5.5f, 8f, 5.5f);
                var v = ov.swizzle.xwyw;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(9.5f, -6.5f, 9f, 0f);
                var v = ov.swizzle.xwz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(9f, v.z);
            }
            {
                var ov = new vec4(9.5f, 4f, -9f, 2.5f);
                var v = ov.swizzle.xwzx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, 2.5f, 7f, -1.5f);
                var v = ov.swizzle.xwzy;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(1f, -3.5f, 0f, 0f);
                var v = ov.swizzle.xwzz;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(8f, 3f, -6.5f, -8f);
                var v = ov.swizzle.xwzw;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(8.5f, 7.5f, -1.5f, 2f);
                var v = ov.swizzle.xww;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec4(4f, -6f, 2.5f, 2f);
                var v = ov.swizzle.xwwx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(4f, 9f, -6f, -9f);
                var v = ov.swizzle.xwwy;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(3.5f, -0.5f, -8.5f, 3.5f);
                var v = ov.swizzle.xwwz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(7f, -9.5f, -9f, -0.5f);
                var v = ov.swizzle.xwww;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, 6f, 2f, -3f);
                var v = ov.swizzle.yx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-9.5f, v.y);
            }
            {
                var ov = new vec4(4f, -3f, 8f, -1f);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(1.5f, 4f, 7.5f, -5.5f);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(-2f, 1.5f, 7.5f, 2f);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 7f, 6.5f, -6.5f);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(-2f, -7f, -2.5f, -9f);
                var v = ov.swizzle.yxxw;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(-7f, -1.5f, 5.5f, -2f);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-1.5f, v.z);
            }
            {
                var ov = new vec4(5f, 6f, 2.5f, -0.5f);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(-4.5f, 3.5f, 7.5f, 2.5f);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(4.5f, -5f, 7.5f, 2.5f);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec4(6f, -8.5f, -1f, 0f);
                var v = ov.swizzle.yxyw;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-2f, 1.5f, 6f, 1f);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(6f, v.z);
            }
            {
                var ov = new vec4(2.5f, -9f, 8.5f, 9.5f);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(-6.5f, 5.5f, -8f, 3f);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(-9f, -6.5f, 6.5f, -7f);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(-7f, 6.5f, 5f, -5.5f);
                var v = ov.swizzle.yxzw;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(-2f, 8f, 9.5f, -8f);
                var v = ov.swizzle.yxw;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-8f, v.z);
            }
            {
                var ov = new vec4(4.5f, 4f, 7f, -9.5f);
                var v = ov.swizzle.yxwx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(-1f, 3f, -7f, 0.5f);
                var v = ov.swizzle.yxwy;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(5f, -2.5f, 7f, -3.5f);
                var v = ov.swizzle.yxwz;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(-8.5f, 3.5f, -9f, -2.5f);
                var v = ov.swizzle.yxww;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(8f, 2.5f, 5f, 0.5f);
                var v = ov.swizzle.yy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
            }
            {
                var ov = new vec4(-6f, 3.5f, -3f, -1f);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-6f, v.z);
            }
            {
                var ov = new vec4(-9f, -8.5f, -5f, 9f);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(-6f, -2.5f, -1.5f, 2f);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(2.5f, -0.5f, 7f, -1.5f);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(-1f, -9f, -0.5f, -9.5f);
                var v = ov.swizzle.yyxw;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-9f, -2.5f, 8.5f, 1.5f);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
            }
            {
                var ov = new vec4(-6f, -1f, 5.5f, -5.5f);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(-7f, -9f, -6f, -9.5f);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(3f, 9f, 2f, 0f);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(2.5f, 7.5f, 0f, -0.5f);
                var v = ov.swizzle.yyyw;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, 6f, -5f, -8f);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-5f, v.z);
            }
            {
                var ov = new vec4(9.5f, 4f, 3.5f, 2.5f);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(-3.5f, 1.5f, -6f, 0.5f);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(2f, -3.5f, -1f, -1.5f);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(5.5f, -8.5f, 4.5f, 8f);
                var v = ov.swizzle.yyzw;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec4(-4.5f, 1.5f, 2.5f, 6.5f);
                var v = ov.swizzle.yyw;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
            }
            {
                var ov = new vec4(-2f, 8f, 9.5f, -7.5f);
                var v = ov.swizzle.yywx;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(-3.5f, 6f, 5.5f, -4f);
                var v = ov.swizzle.yywy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(-8f, 9.5f, 0.5f, -3f);
                var v = ov.swizzle.yywz;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(-3f, -9.5f, 2.5f, -2f);
                var v = ov.swizzle.yyww;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(-7f, 2f, 8.5f, -3.5f);
                var v = ov.swizzle.yz;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(8.5f, v.y);
            }
            {
                var ov = new vec4(2f, -3.5f, -7f, -8f);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec4(8.5f, -4f, 5f, -1f);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(2f, 2.5f, 3f, 7.5f);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(-4f, -8f, 6f, 1.5f);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(4f, -1f, 6f, -9f);
                var v = ov.swizzle.yzxw;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(6.5f, 2f, -2f, 2f);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec4(5.5f, 8.5f, -6f, -6f);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, -6.5f, 2.5f, -6.5f);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, 6f, 3.5f, -4.5f);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, -8.5f, -5.5f, -3f);
                var v = ov.swizzle.yzyw;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(1f, -4.5f, -2f, -4.5f);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
            }
            {
                var ov = new vec4(6.5f, 3.5f, 8.5f, 4.5f);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(-3f, 1f, 6f, 5f);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(6.5f, -9f, -0.5f, 0f);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(-4f, -4f, -6.5f, 0f);
                var v = ov.swizzle.yzzw;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(7.5f, -0.5f, -8.5f, -9.5f);
                var v = ov.swizzle.yzw;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
            }
            {
                var ov = new vec4(0f, -8.5f, 3f, 6f);
                var v = ov.swizzle.yzwx;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-5.5f, -8.5f, 9.5f, -5.5f);
                var v = ov.swizzle.yzwy;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(-2.5f, 3.5f, -8f, -1f);
                var v = ov.swizzle.yzwz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(1.5f, -3.5f, 6f, 1f);
                var v = ov.swizzle.yzww;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(0f, -7.5f, 3f, -1.5f);
                var v = ov.swizzle.yw;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
            }
            {
                var ov = new vec4(-6f, -3.5f, -3.5f, -5f);
                var v = ov.swizzle.ywx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-6f, v.z);
            }
            {
                var ov = new vec4(-7f, 3.5f, -2f, -8f);
                var v = ov.swizzle.ywxx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(7.5f, -6.5f, -5f, -2f);
                var v = ov.swizzle.ywxy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(3f, 1.5f, -4.5f, -5f);
                var v = ov.swizzle.ywxz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, 1.5f, 9f, 1.5f);
                var v = ov.swizzle.ywxw;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(2f, -6.5f, -8f, 2f);
                var v = ov.swizzle.ywy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(-6.5f, v.z);
            }
            {
                var ov = new vec4(1f, -9f, 9f, -2.5f);
                var v = ov.swizzle.ywyx;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(6f, -7.5f, 0f, -6f);
                var v = ov.swizzle.ywyy;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(-3.5f, 3.5f, 4f, -4f);
                var v = ov.swizzle.ywyz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(4.5f, -0.5f, 0.5f, 1.5f);
                var v = ov.swizzle.ywyw;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(9f, -8.5f, -3.5f, 3f);
                var v = ov.swizzle.ywz;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-3.5f, v.z);
            }
            {
                var ov = new vec4(-9f, 5f, 6f, 9.5f);
                var v = ov.swizzle.ywzx;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(1f, 2.5f, -3f, 8f);
                var v = ov.swizzle.ywzy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(-2f, -2f, -3.5f, 2.5f);
                var v = ov.swizzle.ywzz;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec4(8f, -5.5f, -3f, 8.5f);
                var v = ov.swizzle.ywzw;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(-5.5f, -5.5f, -2f, -6f);
                var v = ov.swizzle.yww;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
            }
            {
                var ov = new vec4(-6.5f, 8.5f, -3.5f, -1f);
                var v = ov.swizzle.ywwx;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(-2.5f, -2f, -9.5f, 9.5f);
                var v = ov.swizzle.ywwy;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(1f, -9f, -7.5f, -8.5f);
                var v = ov.swizzle.ywwz;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(6.5f, -4f, -5.5f, 5.5f);
                var v = ov.swizzle.ywww;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(-2f, 9f, -3.5f, -5f);
                var v = ov.swizzle.zx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-2f, v.y);
            }
            {
                var ov = new vec4(9f, 1.5f, 4f, -4f);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
            }
            {
                var ov = new vec4(7f, -2f, 4f, -1f);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(-7f, 1.5f, 7f, -4.5f);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(9f, 9f, -8.5f, -9.5f);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, 6.5f, -3f, -0.5f);
                var v = ov.swizzle.zxxw;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(-2f, -3f, 6f, 2.5f);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-3f, v.z);
            }
            {
                var ov = new vec4(0.5f, 4f, 5.5f, 4.5f);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(0f, -8f, -3.5f, -4f);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(8.5f, 7.5f, 6f, 1.5f);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(4.5f, -2f, 2f, -6f);
                var v = ov.swizzle.zxyw;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(7f, 9f, -6.5f, -1f);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-6.5f, v.z);
            }
            {
                var ov = new vec4(-2f, 6.5f, -1f, -2.5f);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(3.5f, 3f, -6f, -6f);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(7.5f, 7.5f, 2f, 6.5f);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(-4.5f, -2f, -5.5f, 3f);
                var v = ov.swizzle.zxzw;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(-6f, 9f, -1f, 9.5f);
                var v = ov.swizzle.zxw;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(9.5f, v.z);
            }
            {
                var ov = new vec4(5f, 3.5f, -2.5f, -3f);
                var v = ov.swizzle.zxwx;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(3f, -0.5f, -3.5f, 8f);
                var v = ov.swizzle.zxwy;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(4.5f, 6.5f, -7.5f, 2f);
                var v = ov.swizzle.zxwz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, 6.5f, -8.5f, 4.5f);
                var v = ov.swizzle.zxww;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, 8f, 1f, 6.5f);
                var v = ov.swizzle.zy;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(8f, v.y);
            }
            {
                var ov = new vec4(2f, -1f, -7f, 1f);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec4(4.5f, -1f, 6f, -7.5f);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(-2.5f, 9.5f, 9.5f, 7.5f);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(8.5f, -5.5f, 4f, -8f);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(8f, 8.5f, -5.5f, 3f);
                var v = ov.swizzle.zyxw;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(-7f, 6f, -8.5f, 0f);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
            }
            {
                var ov = new vec4(-5f, 9.5f, 6f, -1.5f);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(1.5f, -0.5f, 9f, 6f);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(8f, -4f, 7.5f, 4.5f);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec4(-7f, -3.5f, -8f, 2.5f);
                var v = ov.swizzle.zyyw;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(-7.5f, 4f, -8.5f, 4.5f);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec4(7.5f, -4.5f, 3f, 5f);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, 3f, -4.5f, 5.5f);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(-4.5f, 7.5f, -9.5f, 5.5f);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, -6f, -3.5f, 5.5f);
                var v = ov.swizzle.zyzw;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(3f, -9f, 1.5f, 7.5f);
                var v = ov.swizzle.zyw;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(7.5f, v.z);
            }
            {
                var ov = new vec4(-0.5f, 2.5f, -1.5f, -5.5f);
                var v = ov.swizzle.zywx;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(-2.5f, -1f, 0f, -6.5f);
                var v = ov.swizzle.zywy;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(-9.5f, 1.5f, -7.5f, -2f);
                var v = ov.swizzle.zywz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(-3.5f, -3.5f, 3f, 0.5f);
                var v = ov.swizzle.zyww;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 0f, 6.5f, -2.5f);
                var v = ov.swizzle.zz;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
            }
            {
                var ov = new vec4(4f, -5f, -8.5f, -2f);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(4.5f, 1f, 4f, 1f);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(9.5f, -6.5f, -0.5f, 3f);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(-4f, -6.5f, 5f, 4f);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(6.5f, -9f, -9f, -8.5f);
                var v = ov.swizzle.zzxw;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(2f, 1f, -5f, 4.5f);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(1f, v.z);
            }
            {
                var ov = new vec4(-6f, 7f, 8f, 2f);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(-2f, 5.5f, 9.5f, 2f);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(-7.5f, 3f, 3.5f, -5f);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(-1f, -7f, 0.5f, -4.5f);
                var v = ov.swizzle.zzyw;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(5f, 9.5f, -5.5f, 7.5f);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
            }
            {
                var ov = new vec4(1f, -8f, 8.5f, 2f);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(-8.5f, 8.5f, 4.5f, -6f);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(-7.5f, -6f, -4.5f, 3f);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(0f, -2.5f, 5.5f, -2.5f);
                var v = ov.swizzle.zzzw;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(2.5f, 1f, -0.5f, 3f);
                var v = ov.swizzle.zzw;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(3f, v.z);
            }
            {
                var ov = new vec4(-5.5f, -3.5f, -8.5f, -1f);
                var v = ov.swizzle.zzwx;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, 0.5f, 3.5f, -9f);
                var v = ov.swizzle.zzwy;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, 3.5f, -5f, 3f);
                var v = ov.swizzle.zzwz;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(-8f, -8f, 2.5f, 7.5f);
                var v = ov.swizzle.zzww;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec4(8f, 6f, -8.5f, -3f);
                var v = ov.swizzle.zw;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-3f, v.y);
            }
            {
                var ov = new vec4(1f, -6.5f, -8.5f, 6f);
                var v = ov.swizzle.zwx;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(1f, v.z);
            }
            {
                var ov = new vec4(-8f, 0.5f, -5f, -5.5f);
                var v = ov.swizzle.zwxx;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(-8.5f, 3f, 2.5f, 3f);
                var v = ov.swizzle.zwxy;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(9f, -9.5f, -3f, -6f);
                var v = ov.swizzle.zwxz;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(7.5f, -1.5f, -3f, 0.5f);
                var v = ov.swizzle.zwxw;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(5f, -5f, -2.5f, -1.5f);
                var v = ov.swizzle.zwy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-5f, v.z);
            }
            {
                var ov = new vec4(1f, -7.5f, -3.5f, -7.5f);
                var v = ov.swizzle.zwyx;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(4.5f, 8.5f, -8f, -3.5f);
                var v = ov.swizzle.zwyy;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(-8.5f, -6f, 2f, 0f);
                var v = ov.swizzle.zwyz;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(5f, -5f, 2.5f, 0f);
                var v = ov.swizzle.zwyw;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-6f, 9f, 8.5f, -3.5f);
                var v = ov.swizzle.zwz;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
            }
            {
                var ov = new vec4(1f, -1f, 3.5f, 7.5f);
                var v = ov.swizzle.zwzx;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(4f, -7f, 0f, -8.5f);
                var v = ov.swizzle.zwzy;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(3.5f, 0.5f, 7f, -3.5f);
                var v = ov.swizzle.zwzz;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(6.5f, 2.5f, 4f, 6.5f);
                var v = ov.swizzle.zwzw;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(3f, 2.5f, 0.5f, -7.5f);
                var v = ov.swizzle.zww;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
            }
            {
                var ov = new vec4(-4.5f, 5f, -6.5f, 4.5f);
                var v = ov.swizzle.zwwx;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(-7f, -3f, 9f, -7.5f);
                var v = ov.swizzle.zwwy;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(5.5f, -3f, -5f, 6.5f);
                var v = ov.swizzle.zwwz;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(-7f, 0f, -2.5f, 0.5f);
                var v = ov.swizzle.zwww;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(-1.5f, -1.5f, -7f, -7f);
                var v = ov.swizzle.wx;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-1.5f, v.y);
            }
            {
                var ov = new vec4(8.5f, 7.5f, 3.5f, 0.5f);
                var v = ov.swizzle.wxx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
            }
            {
                var ov = new vec4(7f, -7f, 4f, -4f);
                var v = ov.swizzle.wxxx;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(-1f, 5.5f, 6.5f, -6.5f);
                var v = ov.swizzle.wxxy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, -6f, 1f, 5.5f);
                var v = ov.swizzle.wxxz;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(-2.5f, 8.5f, -9.5f, 2.5f);
                var v = ov.swizzle.wxxw;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(7f, -8f, -4.5f, -8.5f);
                var v = ov.swizzle.wxy;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-8f, v.z);
            }
            {
                var ov = new vec4(-6f, -2f, 8f, 5.5f);
                var v = ov.swizzle.wxyx;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(4f, -4f, 8f, -6f);
                var v = ov.swizzle.wxyy;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(-5f, -3f, -5.5f, -1.5f);
                var v = ov.swizzle.wxyz;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(-3f, 3.5f, -3.5f, 0f);
                var v = ov.swizzle.wxyw;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(7f, 5.5f, -2f, 0f);
                var v = ov.swizzle.wxz;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-2f, v.z);
            }
            {
                var ov = new vec4(-7f, 1.5f, -7f, 1f);
                var v = ov.swizzle.wxzx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(9.5f, 2.5f, 3f, -0.5f);
                var v = ov.swizzle.wxzy;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(7f, -4.5f, 9f, -9.5f);
                var v = ov.swizzle.wxzz;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(-2f, -3f, -4f, 6.5f);
                var v = ov.swizzle.wxzw;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(7f, 9f, 9f, 6.5f);
                var v = ov.swizzle.wxw;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(6.5f, v.z);
            }
            {
                var ov = new vec4(-2.5f, -9.5f, 8f, 6f);
                var v = ov.swizzle.wxwx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, -3f, -7.5f, 3.5f);
                var v = ov.swizzle.wxwy;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(-3f, -9.5f, -4.5f, -2f);
                var v = ov.swizzle.wxwz;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(6f, -4.5f, 4f, -4.5f);
                var v = ov.swizzle.wxww;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 7f, 5.5f, -3f);
                var v = ov.swizzle.wy;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(7f, v.y);
            }
            {
                var ov = new vec4(-1f, -9f, 8f, 0.5f);
                var v = ov.swizzle.wyx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-1f, v.z);
            }
            {
                var ov = new vec4(3f, 3f, -6f, 0f);
                var v = ov.swizzle.wyxx;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(-9.5f, 0.5f, 2.5f, 8.5f);
                var v = ov.swizzle.wyxy;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(-3.5f, -6f, -4f, 6.5f);
                var v = ov.swizzle.wyxz;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(-6.5f, 9f, 9f, -2.5f);
                var v = ov.swizzle.wyxw;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(9f, 9f, -7f, -2.5f);
                var v = ov.swizzle.wyy;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
            }
            {
                var ov = new vec4(0f, 7.5f, -4f, -2.5f);
                var v = ov.swizzle.wyyx;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(8f, -0.5f, 0f, 0f);
                var v = ov.swizzle.wyyy;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(-4f, 6.5f, -4.5f, 7f);
                var v = ov.swizzle.wyyz;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(-2f, -8f, 3f, -1.5f);
                var v = ov.swizzle.wyyw;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec4(7.5f, -7.5f, -4f, -7.5f);
                var v = ov.swizzle.wyz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-4f, v.z);
            }
            {
                var ov = new vec4(-1.5f, -3.5f, -4.5f, 1.5f);
                var v = ov.swizzle.wyzx;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec4(-1f, 7f, 1f, -4.5f);
                var v = ov.swizzle.wyzy;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(7.5f, 8f, 2f, 1f);
                var v = ov.swizzle.wyzz;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(1f, -8.5f, 0.5f, 5f);
                var v = ov.swizzle.wyzw;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, -1.5f, 2.5f, 0.5f);
                var v = ov.swizzle.wyw;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
            }
            {
                var ov = new vec4(-0.5f, 2.5f, -5.5f, 0.5f);
                var v = ov.swizzle.wywx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, 5f, -5.5f, 4f);
                var v = ov.swizzle.wywy;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(5f, -8.5f, -0.5f, -2.5f);
                var v = ov.swizzle.wywz;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 4.5f, 9.5f, -4f);
                var v = ov.swizzle.wyww;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(-3f, -6.5f, -6f, 0f);
                var v = ov.swizzle.wz;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-6f, v.y);
            }
            {
                var ov = new vec4(-2.5f, -5f, 2f, 5f);
                var v = ov.swizzle.wzx;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(-2.5f, v.z);
            }
            {
                var ov = new vec4(4.5f, -6.5f, 6f, 1.5f);
                var v = ov.swizzle.wzxx;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(-1.5f, 8.5f, 8.5f, 8f);
                var v = ov.swizzle.wzxy;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, -5.5f, 2.5f, 5.5f);
                var v = ov.swizzle.wzxz;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(1f, 5.5f, 0f, 5f);
                var v = ov.swizzle.wzxw;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(-6.5f, 7.5f, -9.5f, -6f);
                var v = ov.swizzle.wzy;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
            }
            {
                var ov = new vec4(-9f, -6f, 6f, 6f);
                var v = ov.swizzle.wzyx;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(-8.5f, -6f, 2.5f, 6f);
                var v = ov.swizzle.wzyy;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(-3f, 1.5f, 3f, -5f);
                var v = ov.swizzle.wzyz;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(0.5f, -9f, 5.5f, 7f);
                var v = ov.swizzle.wzyw;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(9.5f, 3.5f, -7f, 7f);
                var v = ov.swizzle.wzz;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
            }
            {
                var ov = new vec4(-6.5f, -8.5f, 6.5f, -2f);
                var v = ov.swizzle.wzzx;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(2f, 4f, -2f, -8f);
                var v = ov.swizzle.wzzy;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(-6.5f, -1f, -7f, 0.5f);
                var v = ov.swizzle.wzzz;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(5.5f, -3.5f, -3.5f, -8f);
                var v = ov.swizzle.wzzw;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(-7f, 9.5f, 9f, -2f);
                var v = ov.swizzle.wzw;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-2f, v.z);
            }
            {
                var ov = new vec4(5f, 2.5f, 6.5f, 9.5f);
                var v = ov.swizzle.wzwx;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, -8f, 5f, -6.5f);
                var v = ov.swizzle.wzwy;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(9.5f, 2.5f, 6f, 0.5f);
                var v = ov.swizzle.wzwz;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(-9.5f, -2f, 3.5f, 8.5f);
                var v = ov.swizzle.wzww;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(-9f, 4.5f, 4f, -7f);
                var v = ov.swizzle.ww;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
            }
            {
                var ov = new vec4(3f, -5f, -5.5f, 1f);
                var v = ov.swizzle.wwx;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(3f, v.z);
            }
            {
                var ov = new vec4(-4f, -3f, -9f, 3f);
                var v = ov.swizzle.wwxx;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(3.5f, -7f, 0.5f, 9.5f);
                var v = ov.swizzle.wwxy;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(-6.5f, 5f, 1f, 0.5f);
                var v = ov.swizzle.wwxz;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(-4.5f, 7.5f, 1.5f, -5.5f);
                var v = ov.swizzle.wwxw;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(8.5f, -0.5f, -8f, 0.5f);
                var v = ov.swizzle.wwy;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var ov = new vec4(4f, -2.5f, -1f, -5.5f);
                var v = ov.swizzle.wwyx;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(2.5f, -1.5f, 9.5f, -7.5f);
                var v = ov.swizzle.wwyy;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 2.5f, 7f, 1.5f);
                var v = ov.swizzle.wwyz;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(8f, 4.5f, -4.5f, 7f);
                var v = ov.swizzle.wwyw;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(9.5f, 1f, -0.5f, -7.5f);
                var v = ov.swizzle.wwz;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var ov = new vec4(2f, 6f, 6f, -5f);
                var v = ov.swizzle.wwzx;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(9f, 3f, -3f, -8.5f);
                var v = ov.swizzle.wwzy;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(3f, -8.5f, -9f, -4f);
                var v = ov.swizzle.wwzz;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(7.5f, 4.5f, 6.5f, -2.5f);
                var v = ov.swizzle.wwzw;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(2f, 5.5f, -2f, 4f);
                var v = ov.swizzle.www;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(-8f, 7f, 4f, 0.5f);
                var v = ov.swizzle.wwwx;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(7.5f, -1f, -7.5f, 0.5f);
                var v = ov.swizzle.wwwy;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(-3f, -5.5f, -4.5f, 6.5f);
                var v = ov.swizzle.wwwz;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(9.5f, 5.5f, -2.5f, 7.5f);
                var v = ov.swizzle.wwww;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new vec4(-5.5f, 3.5f, -2.5f, -5.5f);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
            }
            {
                var ov = new vec4(-4f, 8.5f, -6.5f, 6.5f);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
            }
            {
                var ov = new vec4(8.5f, -7f, -8.5f, 8f);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(-1f, 4.5f, 5.5f, 4.5f);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(4f, -6.5f, -2.5f, -4f);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(5f, 0f, -6f, 6.5f);
                var v = ov.swizzle.rrra;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(5f, 0f, -6f, -4f);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var ov = new vec4(-7.5f, -8.5f, 3.5f, 7f);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, -5f, -5f, 5f);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(5.5f, -5.5f, -4.5f, 6f);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 8f, 0f, 1.5f);
                var v = ov.swizzle.rrga;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(-6f, -4f, 0f, 9f);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var ov = new vec4(0f, 1.5f, -4.5f, 1.5f);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-5.5f, -7.5f, -3f, -5.5f);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(-7f, 1.5f, -9f, -3f);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(-7.5f, 9f, -4f, -8f);
                var v = ov.swizzle.rrba;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(-5.5f, -4f, -5f, 5.5f);
                var v = ov.swizzle.rra;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
            }
            {
                var ov = new vec4(-9f, -0.5f, 9.5f, -8.5f);
                var v = ov.swizzle.rrar;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(8.5f, -9.5f, -9f, 6.5f);
                var v = ov.swizzle.rrag;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(9.5f, -4.5f, -9.5f, 1.5f);
                var v = ov.swizzle.rrab;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(0f, 6f, -3f, 1.5f);
                var v = ov.swizzle.rraa;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 1f, -6.5f, -2f);
                var v = ov.swizzle.rg;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(1f, v.y);
            }
            {
                var ov = new vec4(1f, 0.5f, -1.5f, 3f);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(1f, v.z);
            }
            {
                var ov = new vec4(4f, -3f, -4.5f, -4.5f);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(5.5f, -6.5f, 6f, 2f);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(8.5f, 4f, 0.5f, -1f);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, 4f, 3.5f, 4f);
                var v = ov.swizzle.rgra;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(3f, -6f, -4.5f, 2.5f);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
            }
            {
                var ov = new vec4(-2f, -1.5f, -3f, -5f);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(6.5f, -6.5f, -7.5f, -7.5f);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, 3f, 3.5f, -0.5f);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(1f, 6.5f, -6f, -3.5f);
                var v = ov.swizzle.rgga;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, 3.5f, 1f, -6f);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(1f, v.z);
            }
            {
                var ov = new vec4(-8f, -8f, 2.5f, 6.5f);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(-7f, 2f, 9.5f, 1.5f);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(8f, -9f, 8f, -3.5f);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec4(5f, 6.5f, 2.5f, -7f);
                var v = ov.swizzle.rgba;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(9.5f, 9f, -0.5f, -2f);
                var v = ov.swizzle.rga;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-2f, v.z);
            }
            {
                var ov = new vec4(1f, -5.5f, -3f, 5.5f);
                var v = ov.swizzle.rgar;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(-1f, 0f, 9f, 5.5f);
                var v = ov.swizzle.rgag;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-1.5f, 7f, 9f, -1f);
                var v = ov.swizzle.rgab;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(-4f, 8f, -5f, 3.5f);
                var v = ov.swizzle.rgaa;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, -7f, 8.5f, 3.5f);
                var v = ov.swizzle.rb;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
            }
            {
                var ov = new vec4(-5.5f, 1.5f, -4f, -1f);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-5.5f, v.z);
            }
            {
                var ov = new vec4(5.5f, 7f, -5.5f, 5f);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(3f, 9.5f, -3.5f, -4.5f);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(3f, 0.5f, -5f, 3.5f);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(5f, 7.5f, -4.5f, -6f);
                var v = ov.swizzle.rbra;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(3.5f, 3f, 2f, 1f);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(3f, v.z);
            }
            {
                var ov = new vec4(8f, 8.5f, -2f, 6.5f);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec4(-8.5f, 8.5f, -8.5f, -6.5f);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(-1f, 5.5f, -1.5f, 9f);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec4(-1f, 1f, 0f, 2f);
                var v = ov.swizzle.rbga;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(-7f, 3f, 2.5f, -0.5f);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
            }
            {
                var ov = new vec4(-8.5f, -5.5f, 6f, -5.5f);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, -8.5f, -1.5f, 8.5f);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, -6.5f, 0f, -9.5f);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-1.5f, -3f, 1f, 7.5f);
                var v = ov.swizzle.rbba;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec4(6.5f, -2.5f, -5.5f, 4f);
                var v = ov.swizzle.rba;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(-8f, 2f, -4f, 8f);
                var v = ov.swizzle.rbar;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(1f, 4f, -6.5f, 3f);
                var v = ov.swizzle.rbag;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(6.5f, -6.5f, 8.5f, -0.5f);
                var v = ov.swizzle.rbab;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(-2f, -4f, -9.5f, -4.5f);
                var v = ov.swizzle.rbaa;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, -2.5f, 3f, 0f);
                var v = ov.swizzle.ra;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(0f, v.y);
            }
            {
                var ov = new vec4(-1f, -6.5f, 2.5f, -1.5f);
                var v = ov.swizzle.rar;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1f, v.z);
            }
            {
                var ov = new vec4(4.5f, 8f, -7.5f, 7.5f);
                var v = ov.swizzle.rarr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(9.5f, 3f, 6f, 0.5f);
                var v = ov.swizzle.rarg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(-9.5f, -2.5f, -2f, -9f);
                var v = ov.swizzle.rarb;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(-1f, 8.5f, -6.5f, -1.5f);
                var v = ov.swizzle.rara;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec4(8.5f, -5.5f, 1f, 8f);
                var v = ov.swizzle.rag;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-5.5f, v.z);
            }
            {
                var ov = new vec4(-5.5f, -2f, 7f, -5f);
                var v = ov.swizzle.ragr;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, -7f, 5f, 8f);
                var v = ov.swizzle.ragg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(-6.5f, -5.5f, 4.5f, 4.5f);
                var v = ov.swizzle.ragb;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(9f, -4.5f, -4f, 3.5f);
                var v = ov.swizzle.raga;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(-6.5f, -4.5f, 4f, 3.5f);
                var v = ov.swizzle.rab;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(-6f, 7f, 9f, -4.5f);
                var v = ov.swizzle.rabr;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(1f, 0f, -5f, 3.5f);
                var v = ov.swizzle.rabg;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(4f, -5f, 1f, -3.5f);
                var v = ov.swizzle.rabb;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(1f, v.w);
            }
            {
                var ov = new vec4(-7.5f, -5.5f, 4f, -6.5f);
                var v = ov.swizzle.raba;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(0f, 6f, 4f, -6.5f);
                var v = ov.swizzle.raa;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
            }
            {
                var ov = new vec4(7.5f, 7.5f, 6f, 5.5f);
                var v = ov.swizzle.raar;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec4(2.5f, -7f, 8f, -4.5f);
                var v = ov.swizzle.raag;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(-5.5f, -0.5f, 5f, -4f);
                var v = ov.swizzle.raab;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, 7f, 2.5f, -6f);
                var v = ov.swizzle.raaa;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(1f, -6.5f, -3f, 2.5f);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(1f, v.y);
            }
            {
                var ov = new vec4(2f, -3f, 4f, 8f);
                var v = ov.swizzle.grr;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(2f, v.z);
            }
            {
                var ov = new vec4(-7.5f, 8f, -3f, -3.5f);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(-8.5f, 0.5f, 2.5f, -7f);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, -8.5f, 6.5f, -9f);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(1f, -4f, 2.5f, -4.5f);
                var v = ov.swizzle.grra;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(1.5f, -0.5f, 8f, -5f);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var ov = new vec4(9f, -1.5f, 5f, -4f);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(2.5f, -1.5f, -8.5f, -7f);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, -3f, -9.5f, -5.5f);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(2.5f, 8.5f, -3f, -5.5f);
                var v = ov.swizzle.grga;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(4f, -6.5f, 3f, 4.5f);
                var v = ov.swizzle.grb;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(3f, v.z);
            }
            {
                var ov = new vec4(6.5f, -0.5f, 4.5f, 8.5f);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(-2f, -3f, -5f, -1.5f);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(1.5f, -1.5f, 0f, -3f);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(4f, -0.5f, 9.5f, 4.5f);
                var v = ov.swizzle.grba;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(2f, 8.5f, 4.5f, 3.5f);
                var v = ov.swizzle.gra;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(3.5f, v.z);
            }
            {
                var ov = new vec4(9f, -5f, -6.5f, 6f);
                var v = ov.swizzle.grar;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(1f, -2f, -3.5f, 2f);
                var v = ov.swizzle.grag;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(0f, 7f, -9.5f, 8f);
                var v = ov.swizzle.grab;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-3.5f, -5f, -9f, -9.5f);
                var v = ov.swizzle.graa;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, 7f, 2f, -9f);
                var v = ov.swizzle.gg;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
            }
            {
                var ov = new vec4(-3f, 3.5f, -3.5f, 5f);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-3f, v.z);
            }
            {
                var ov = new vec4(-3f, 7f, -9.5f, 3f);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(8.5f, -9f, -7.5f, 5f);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(-0.5f, -1f, -5.5f, -8.5f);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(5f, -2.5f, 7.5f, 9.5f);
                var v = ov.swizzle.ggra;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(-3.5f, -2f, -2.5f, -5.5f);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
            }
            {
                var ov = new vec4(7f, 2.5f, -2.5f, 0.5f);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(-1f, -9f, 1f, 5.5f);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(5.5f, -5f, -9.5f, -6f);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, -8f, 4.5f, 4.5f);
                var v = ov.swizzle.ggga;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(2.5f, -6.5f, 4f, -7.5f);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(-4.5f, -4f, -9f, -5f);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, 7.5f, -5f, 5f);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec4(9f, 3f, 2.5f, 1f);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(5f, 2f, 7.5f, -9.5f);
                var v = ov.swizzle.ggba;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, 0.5f, 2.5f, -9f);
                var v = ov.swizzle.gga;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-9f, v.z);
            }
            {
                var ov = new vec4(-8f, -2.5f, -1f, -5f);
                var v = ov.swizzle.ggar;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(1.5f, 8f, 2.5f, -1.5f);
                var v = ov.swizzle.ggag;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec4(3.5f, 3f, 7f, 2f);
                var v = ov.swizzle.ggab;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(7f, 5f, 8.5f, 4.5f);
                var v = ov.swizzle.ggaa;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(-3f, -2f, 0f, -4f);
                var v = ov.swizzle.gb;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(0f, v.y);
            }
            {
                var ov = new vec4(4f, 5.5f, -4.5f, 2.5f);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(-7.5f, -9f, 9f, -3.5f);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, -4f, -4f, 2f);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(1.5f, -4.5f, 4f, 8.5f);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(3f, 4f, -5.5f, -8.5f);
                var v = ov.swizzle.gbra;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(4f, -3.5f, -2f, 5f);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-3.5f, v.z);
            }
            {
                var ov = new vec4(6.5f, 0.5f, 3.5f, 0f);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(4f, 2f, 7f, 8f);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(-0.5f, -8f, -5f, -7.5f);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(1f, -8f, 2.5f, -3f);
                var v = ov.swizzle.gbga;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(8.5f, 5f, 8f, -9.5f);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
            }
            {
                var ov = new vec4(0.5f, 5f, -2f, -7.5f);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-2f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(0f, 0f, 0.5f, 8f);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-2.5f, -9f, 8f, -9f);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec4(-6.5f, -9f, 6.5f, 2.5f);
                var v = ov.swizzle.gbba;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(-4.5f, 9f, -7.5f, -7f);
                var v = ov.swizzle.gba;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7f, v.z);
            }
            {
                var ov = new vec4(6f, 4f, -3f, -3f);
                var v = ov.swizzle.gbar;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(-1f, -7.5f, 6.5f, -4.5f);
                var v = ov.swizzle.gbag;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(-3f, -2f, -6.5f, 9.5f);
                var v = ov.swizzle.gbab;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(-8f, 2.5f, -6f, 0.5f);
                var v = ov.swizzle.gbaa;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(-9f, -1f, 9.5f, 3f);
                var v = ov.swizzle.ga;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(3f, v.y);
            }
            {
                var ov = new vec4(-3f, 8.5f, -8.5f, -1f);
                var v = ov.swizzle.gar;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-3f, v.z);
            }
            {
                var ov = new vec4(9f, 5.5f, 8.5f, -6.5f);
                var v = ov.swizzle.garr;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(-7.5f, 9.5f, -2.5f, -1.5f);
                var v = ov.swizzle.garg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(-6.5f, 1.5f, -4f, -4.5f);
                var v = ov.swizzle.garb;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(3.5f, 8.5f, -2f, -9f);
                var v = ov.swizzle.gara;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(4f, 4f, 6.5f, -6f);
                var v = ov.swizzle.gag;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(5.5f, 9f, 1f, 1.5f);
                var v = ov.swizzle.gagr;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(3f, 5f, -4f, -4f);
                var v = ov.swizzle.gagg;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(9f, -8f, 4f, 7f);
                var v = ov.swizzle.gagb;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(4f, v.w);
            }
            {
                var ov = new vec4(-5.5f, 1f, 3f, -5f);
                var v = ov.swizzle.gaga;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(-6.5f, -4f, 3f, -3f);
                var v = ov.swizzle.gab;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(3f, v.z);
            }
            {
                var ov = new vec4(-5.5f, 4.5f, -6f, -3.5f);
                var v = ov.swizzle.gabr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(-8f, 1.5f, 7.5f, -9.5f);
                var v = ov.swizzle.gabg;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(9.5f, -8.5f, 9.5f, 7f);
                var v = ov.swizzle.gabb;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(2f, 5f, -6f, 0f);
                var v = ov.swizzle.gaba;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(4.5f, 7f, -9.5f, -6f);
                var v = ov.swizzle.gaa;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
            }
            {
                var ov = new vec4(-3.5f, -3f, -9f, 5f);
                var v = ov.swizzle.gaar;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec4(-3.5f, 6f, 1f, 1.5f);
                var v = ov.swizzle.gaag;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(5.5f, 7.5f, 5.5f, 1.5f);
                var v = ov.swizzle.gaab;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(0f, -5.5f, 1.5f, 0f);
                var v = ov.swizzle.gaaa;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(3.5f, -5f, -4f, -2f);
                var v = ov.swizzle.br;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(3.5f, v.y);
            }
            {
                var ov = new vec4(7f, 3.5f, -5f, -1.5f);
                var v = ov.swizzle.brr;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
            }
            {
                var ov = new vec4(-8f, 7.5f, 5f, -8f);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(-4.5f, 2f, -9.5f, -6f);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(3.5f, -1.5f, -3.5f, -2f);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec4(-6f, -1f, 0f, -2f);
                var v = ov.swizzle.brra;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(0.5f, 6f, -4.5f, 1f);
                var v = ov.swizzle.brg;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(6f, v.z);
            }
            {
                var ov = new vec4(-3.5f, 8f, 6f, -8f);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec4(-5f, -5f, 6f, -9.5f);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(4.5f, 7f, 7f, 2.5f);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(8.5f, 0.5f, -2.5f, -1.5f);
                var v = ov.swizzle.brga;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec4(0f, -6.5f, 5f, 2.5f);
                var v = ov.swizzle.brb;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(5f, v.z);
            }
            {
                var ov = new vec4(-7f, -9f, 7.5f, -3f);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(7.5f, -9.5f, -4.5f, -6.5f);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-5f, 1f, -7.5f, 1f);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(8f, -4f, 1f, 9f);
                var v = ov.swizzle.brba;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(1.5f, -2.5f, 3f, -1f);
                var v = ov.swizzle.bra;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(-1f, v.z);
            }
            {
                var ov = new vec4(6.5f, 0f, -7.5f, -3.5f);
                var v = ov.swizzle.brar;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, 4.5f, -3f, -4.5f);
                var v = ov.swizzle.brag;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(4.5f, v.w);
            }
            {
                var ov = new vec4(-6.5f, -2f, -1f, 6f);
                var v = ov.swizzle.brab;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(0f, 2.5f, -5.5f, 6f);
                var v = ov.swizzle.braa;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(-2f, 3.5f, -8.5f, 5.5f);
                var v = ov.swizzle.bg;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
            }
            {
                var ov = new vec4(0.5f, -6.5f, 5f, 2.5f);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
            }
            {
                var ov = new vec4(-3.5f, 6f, -5.5f, -4.5f);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec4(-1.5f, -8f, 7.5f, -4f);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(-9f, 5.5f, 6.5f, -7f);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(7.5f, -1f, 2.5f, 3f);
                var v = ov.swizzle.bgra;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(3f, v.w);
            }
            {
                var ov = new vec4(6f, 9.5f, 9.5f, 2f);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
            }
            {
                var ov = new vec4(0.5f, -5f, 1f, -6f);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, 5.5f, 7.5f, 7.5f);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(5f, 8f, -9.5f, -3f);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(5.5f, -0.5f, 0f, -4f);
                var v = ov.swizzle.bgga;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(9f, -1.5f, 6.5f, 5f);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
            }
            {
                var ov = new vec4(-5f, 7.5f, -2.5f, 4f);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(6.5f, 7f, 9f, 1f);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(0f, -8f, -1.5f, 1.5f);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-1.5f, v.w);
            }
            {
                var ov = new vec4(-5.5f, 2f, 1f, -1f);
                var v = ov.swizzle.bgba;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(5f, 7f, 5.5f, 3.5f);
                var v = ov.swizzle.bga;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(3.5f, v.z);
            }
            {
                var ov = new vec4(-9.5f, 9.5f, 7f, -1f);
                var v = ov.swizzle.bgar;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-6f, -6.5f, -8.5f, 7f);
                var v = ov.swizzle.bgag;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(-1f, -9f, 3.5f, -8f);
                var v = ov.swizzle.bgab;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(3f, 4.5f, -2.5f, 3.5f);
                var v = ov.swizzle.bgaa;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(-2.5f, 6.5f, -9.5f, -7.5f);
                var v = ov.swizzle.bb;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
            }
            {
                var ov = new vec4(-4.5f, 6.5f, 6.5f, -1.5f);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
            }
            {
                var ov = new vec4(-9.5f, -0.5f, -0.5f, 2.5f);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-2.5f, -0.5f, 8f, 2f);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(2.5f, 2f, -4.5f, -6f);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, -7f, -0.5f, -3f);
                var v = ov.swizzle.bbra;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(-3.5f, 1f, 0.5f, -7.5f);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(1f, v.z);
            }
            {
                var ov = new vec4(-5.5f, 9f, -2.5f, -0.5f);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(-6f, 8f, -6.5f, 8f);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec4(-1.5f, -4f, 8f, -5.5f);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec4(2f, -9.5f, 0.5f, -2.5f);
                var v = ov.swizzle.bbga;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(4.5f, -0.5f, -9.5f, -8.5f);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
            }
            {
                var ov = new vec4(-1f, 1.5f, -3.5f, 0f);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-3.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(8f, -2f, 4f, -1f);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(4f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(7f, 6f, 5.5f, -5.5f);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(5f, -5f, 3f, -1f);
                var v = ov.swizzle.bbba;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(3f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(1f, 9.5f, -7f, -9f);
                var v = ov.swizzle.bba;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-9f, v.z);
            }
            {
                var ov = new vec4(5f, 9.5f, -5f, -9f);
                var v = ov.swizzle.bbar;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(4.5f, 0f, -3f, 9f);
                var v = ov.swizzle.bbag;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-3.5f, 1f, -8f, 7.5f);
                var v = ov.swizzle.bbab;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-8f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(-8.5f, 9f, -1f, 3.5f);
                var v = ov.swizzle.bbaa;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(-5.5f, -2.5f, -8.5f, 4f);
                var v = ov.swizzle.ba;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(4f, v.y);
            }
            {
                var ov = new vec4(4f, -3f, 0f, -8.5f);
                var v = ov.swizzle.bar;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(-8f, -5.5f, -9f, -2.5f);
                var v = ov.swizzle.barr;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(-6f, -9.5f, -4.5f, 5.5f);
                var v = ov.swizzle.barg;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-2f, 1f, -5f, -1f);
                var v = ov.swizzle.barb;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-2f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(-6f, 7f, 6f, 7f);
                var v = ov.swizzle.bara;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(8.5f, 4.5f, -5.5f, 5f);
                var v = ov.swizzle.bag;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(4.5f, v.z);
            }
            {
                var ov = new vec4(-0.5f, 8.5f, 2f, 5.5f);
                var v = ov.swizzle.bagr;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(3f, 9f, -3.5f, -5f);
                var v = ov.swizzle.bagg;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(-9f, -3f, -5f, 3.5f);
                var v = ov.swizzle.bagb;
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(9.5f, 3.5f, 0f, 9f);
                var v = ov.swizzle.baga;
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(3.5f, v.z);
                Assert.AreEqual(9f, v.w);
            }
            {
                var ov = new vec4(-7.5f, -4.5f, 3.5f, 6f);
                var v = ov.swizzle.bab;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(3.5f, v.z);
            }
            {
                var ov = new vec4(-6f, -6.5f, -4.5f, -9.5f);
                var v = ov.swizzle.babr;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-4.5f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(4.5f, 0f, -7f, -7f);
                var v = ov.swizzle.babg;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-9.5f, -3f, 5f, 9f);
                var v = ov.swizzle.babb;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(-1.5f, 4.5f, 2.5f, -9.5f);
                var v = ov.swizzle.baba;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-7.5f, -6.5f, -5.5f, 6f);
                var v = ov.swizzle.baa;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
            }
            {
                var ov = new vec4(3.5f, -1f, -7f, 9.5f);
                var v = ov.swizzle.baar;
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(3.5f, v.w);
            }
            {
                var ov = new vec4(-3.5f, -7.5f, -2f, -7.5f);
                var v = ov.swizzle.baag;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-7.5f, v.w);
            }
            {
                var ov = new vec4(6f, 6.5f, -3.5f, -4f);
                var v = ov.swizzle.baab;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec4(0f, -8f, 0.5f, 5f);
                var v = ov.swizzle.baaa;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(-3f, -6.5f, 1f, 3f);
                var v = ov.swizzle.ar;
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-3f, v.y);
            }
            {
                var ov = new vec4(2.5f, 9f, 4.5f, 5f);
                var v = ov.swizzle.arr;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
            }
            {
                var ov = new vec4(6f, 5f, 4f, 4f);
                var v = ov.swizzle.arrr;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(1f, -9.5f, -1.5f, 8.5f);
                var v = ov.swizzle.arrg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(1f, -2.5f, -3f, 4f);
                var v = ov.swizzle.arrb;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(6f, -4.5f, 4.5f, -3f);
                var v = ov.swizzle.arra;
                Assert.AreEqual(-3f, v.x);
                Assert.AreEqual(6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(-0.5f, 4.5f, 9f, -5.5f);
                var v = ov.swizzle.arg;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(4.5f, v.z);
            }
            {
                var ov = new vec4(-2.5f, 1.5f, 8f, 9f);
                var v = ov.swizzle.argr;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-2.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(4f, -3.5f, 6f, 8.5f);
                var v = ov.swizzle.argg;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-3.5f, v.w);
            }
            {
                var ov = new vec4(-7.5f, -8.5f, -4f, -6.5f);
                var v = ov.swizzle.argb;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(-7f, -1f, 2.5f, -9.5f);
                var v = ov.swizzle.arga;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(-7f, 7f, -8.5f, -2.5f);
                var v = ov.swizzle.arb;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(-8.5f, v.z);
            }
            {
                var ov = new vec4(7f, -2.5f, -3f, -4f);
                var v = ov.swizzle.arbr;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-3f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(5f, -4.5f, 9.5f, -2.5f);
                var v = ov.swizzle.arbg;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(-4.5f, v.w);
            }
            {
                var ov = new vec4(-0.5f, -1.5f, -4f, 7.5f);
                var v = ov.swizzle.arbb;
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(0f, 9f, -9f, -6f);
                var v = ov.swizzle.arba;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(0f, v.y);
                Assert.AreEqual(-9f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(6.5f, 4.5f, 9.5f, -6f);
                var v = ov.swizzle.ara;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(-6f, v.z);
            }
            {
                var ov = new vec4(-3f, -0.5f, -7f, -9.5f);
                var v = ov.swizzle.arar;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-3f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(-4f, -0.5f, -1.5f, 5.5f);
                var v = ov.swizzle.arag;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, -4f, 6.5f, -8.5f);
                var v = ov.swizzle.arab;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(3.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(-4f, -7.5f, -6f, 9.5f);
                var v = ov.swizzle.araa;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(9.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(-9f, 5.5f, 4f, -9.5f);
                var v = ov.swizzle.ag;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
            }
            {
                var ov = new vec4(-3.5f, -9.5f, 9f, 4.5f);
                var v = ov.swizzle.agr;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
            }
            {
                var ov = new vec4(6f, -6f, -6.5f, 6f);
                var v = ov.swizzle.agrr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(-6f, v.y);
                Assert.AreEqual(6f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(1.5f, -7f, -5.5f, -7.5f);
                var v = ov.swizzle.agrg;
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-7f, v.w);
            }
            {
                var ov = new vec4(7f, 4f, -4f, -8f);
                var v = ov.swizzle.agrb;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(-1f, 2.5f, 9.5f, -6f);
                var v = ov.swizzle.agra;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(-6f, v.w);
            }
            {
                var ov = new vec4(6.5f, 3f, 4.5f, -6f);
                var v = ov.swizzle.agg;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(3f, v.y);
                Assert.AreEqual(3f, v.z);
            }
            {
                var ov = new vec4(2.5f, 2.5f, -5.5f, -9f);
                var v = ov.swizzle.aggr;
                Assert.AreEqual(-9f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, -9.5f, 6.5f, 1f);
                var v = ov.swizzle.aggg;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, -9.5f, -0.5f, 3.5f);
                var v = ov.swizzle.aggb;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, -7.5f, -4f, 8.5f);
                var v = ov.swizzle.agga;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(6f, -8.5f, 4f, -6f);
                var v = ov.swizzle.agb;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(-0.5f, -4f, -4f, 9f);
                var v = ov.swizzle.agbr;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(-4f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(7f, 7.5f, -0.5f, -2.5f);
                var v = ov.swizzle.agbg;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(7.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
            {
                var ov = new vec4(6.5f, -0.5f, -6.5f, -6.5f);
                var v = ov.swizzle.agbb;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(-6.5f, v.w);
            }
            {
                var ov = new vec4(-4.5f, 4.5f, 2f, -4f);
                var v = ov.swizzle.agba;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(2.5f, 4f, -3f, -2f);
                var v = ov.swizzle.aga;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(-2f, v.z);
            }
            {
                var ov = new vec4(-8.5f, -6.5f, 2.5f, -1.5f);
                var v = ov.swizzle.agar;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(-5f, -8.5f, 8.5f, -1.5f);
                var v = ov.swizzle.agag;
                Assert.AreEqual(-1.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(-8f, 1f, 8f, -6f);
                var v = ov.swizzle.agab;
                Assert.AreEqual(-6f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec4(9.5f, -9f, -3.5f, -8f);
                var v = ov.swizzle.agaa;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(-9f, v.y);
                Assert.AreEqual(-8f, v.z);
                Assert.AreEqual(-8f, v.w);
            }
            {
                var ov = new vec4(-9f, -4f, -1f, 6.5f);
                var v = ov.swizzle.ab;
                Assert.AreEqual(6.5f, v.x);
                Assert.AreEqual(-1f, v.y);
            }
            {
                var ov = new vec4(1.5f, 9f, 4f, 1f);
                var v = ov.swizzle.abr;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(1.5f, v.z);
            }
            {
                var ov = new vec4(6.5f, 6f, 8f, -4.5f);
                var v = ov.swizzle.abrr;
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(-9.5f, 0f, 5f, 2f);
                var v = ov.swizzle.abrg;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(7f, 2.5f, 5.5f, 6f);
                var v = ov.swizzle.abrb;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(-7.5f, -4.5f, 4.5f, -2.5f);
                var v = ov.swizzle.abra;
                Assert.AreEqual(-2.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(9.5f, 0f, 8f, 4.5f);
                var v = ov.swizzle.abg;
                Assert.AreEqual(4.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var ov = new vec4(-9.5f, 7f, -5.5f, 5f);
                var v = ov.swizzle.abgr;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-9.5f, v.w);
            }
            {
                var ov = new vec4(8f, -5.5f, 4.5f, -8f);
                var v = ov.swizzle.abgg;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-5.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(3.5f, -7f, -8.5f, -2f);
                var v = ov.swizzle.abgb;
                Assert.AreEqual(-2f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-7f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(-8f, 1.5f, 1.5f, 8f);
                var v = ov.swizzle.abga;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(1.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(8f, v.w);
            }
            {
                var ov = new vec4(-2f, -3f, 7f, -8f);
                var v = ov.swizzle.abb;
                Assert.AreEqual(-8f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
            }
            {
                var ov = new vec4(5.5f, 6f, 7f, 6f);
                var v = ov.swizzle.abbr;
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(5.5f, v.w);
            }
            {
                var ov = new vec4(-5.5f, -9f, 5.5f, 3.5f);
                var v = ov.swizzle.abbg;
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-9f, v.w);
            }
            {
                var ov = new vec4(-9f, -6.5f, 6.5f, 0.5f);
                var v = ov.swizzle.abbb;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(6.5f, v.y);
                Assert.AreEqual(6.5f, v.z);
                Assert.AreEqual(6.5f, v.w);
            }
            {
                var ov = new vec4(0f, -1f, -8.5f, -0.5f);
                var v = ov.swizzle.abba;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-0.5f, v.w);
            }
            {
                var ov = new vec4(-6.5f, 2f, -7f, 5.5f);
                var v = ov.swizzle.aba;
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-7f, v.y);
                Assert.AreEqual(5.5f, v.z);
            }
            {
                var ov = new vec4(5f, -1.5f, 8f, 0.5f);
                var v = ov.swizzle.abar;
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(5f, v.w);
            }
            {
                var ov = new vec4(-2f, -5.5f, -0.5f, 1.5f);
                var v = ov.swizzle.abag;
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(1.5f, v.z);
                Assert.AreEqual(-5.5f, v.w);
            }
            {
                var ov = new vec4(4.5f, -3.5f, -5f, -3.5f);
                var v = ov.swizzle.abab;
                Assert.AreEqual(-3.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(-5f, v.w);
            }
            {
                var ov = new vec4(2.5f, 1.5f, 9.5f, -4f);
                var v = ov.swizzle.abaa;
                Assert.AreEqual(-4f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(-4f, v.z);
                Assert.AreEqual(-4f, v.w);
            }
            {
                var ov = new vec4(9.5f, -7f, -7.5f, -0.5f);
                var v = ov.swizzle.aa;
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
            }
            {
                var ov = new vec4(-0.5f, 0f, 9.5f, -1f);
                var v = ov.swizzle.aar;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var ov = new vec4(-8.5f, 0.5f, -1f, 7f);
                var v = ov.swizzle.aarr;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(-8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(9f, 2f, -3.5f, 9f);
                var v = ov.swizzle.aarg;
                Assert.AreEqual(9f, v.x);
                Assert.AreEqual(9f, v.y);
                Assert.AreEqual(9f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var ov = new vec4(5.5f, -2f, -2f, 7f);
                var v = ov.swizzle.aarb;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(5.5f, v.z);
                Assert.AreEqual(-2f, v.w);
            }
            {
                var ov = new vec4(7.5f, -7f, 5.5f, 9.5f);
                var v = ov.swizzle.aara;
                Assert.AreEqual(9.5f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(7.5f, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var ov = new vec4(0.5f, 4f, 9.5f, 2.5f);
                var v = ov.swizzle.aag;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(4f, v.z);
            }
            {
                var ov = new vec4(7f, -1f, 7.5f, 8f);
                var v = ov.swizzle.aagr;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-1f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(-2f, 7f, -0.5f, 5f);
                var v = ov.swizzle.aagg;
                Assert.AreEqual(5f, v.x);
                Assert.AreEqual(5f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(-9.5f, -1.5f, 6f, 4f);
                var v = ov.swizzle.aagb;
                Assert.AreEqual(4f, v.x);
                Assert.AreEqual(4f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(6f, v.w);
            }
            {
                var ov = new vec4(-1.5f, 8.5f, 9f, -8.5f);
                var v = ov.swizzle.aaga;
                Assert.AreEqual(-8.5f, v.x);
                Assert.AreEqual(-8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(-8.5f, v.w);
            }
            {
                var ov = new vec4(-3f, -8.5f, -7.5f, 2.5f);
                var v = ov.swizzle.aab;
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(2.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
            }
            {
                var ov = new vec4(0f, 5f, 0.5f, -9.5f);
                var v = ov.swizzle.aabr;
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-9.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var ov = new vec4(-9f, 1.5f, -6f, -6.5f);
                var v = ov.swizzle.aabg;
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(-6.5f, v.y);
                Assert.AreEqual(-6f, v.z);
                Assert.AreEqual(1.5f, v.w);
            }
            {
                var ov = new vec4(-7.5f, -7.5f, 8.5f, -5.5f);
                var v = ov.swizzle.aabb;
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(8.5f, v.w);
            }
            {
                var ov = new vec4(0f, 6f, 2f, -1f);
                var v = ov.swizzle.aaba;
                Assert.AreEqual(-1f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(-1f, v.w);
            }
            {
                var ov = new vec4(2.5f, 2f, 6.5f, 1f);
                var v = ov.swizzle.aaa;
                Assert.AreEqual(1f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(1f, v.z);
            }
            {
                var ov = new vec4(-3f, -9.5f, -0.5f, 7f);
                var v = ov.swizzle.aaar;
                Assert.AreEqual(7f, v.x);
                Assert.AreEqual(7f, v.y);
                Assert.AreEqual(7f, v.z);
                Assert.AreEqual(-3f, v.w);
            }
            {
                var ov = new vec4(4f, 7f, -9f, 8.5f);
                var v = ov.swizzle.aaag;
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(7f, v.w);
            }
            {
                var ov = new vec4(6f, -4f, -2.5f, 8f);
                var v = ov.swizzle.aaab;
                Assert.AreEqual(8f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(8f, v.z);
                Assert.AreEqual(-2.5f, v.w);
            }
            {
                var ov = new vec4(-6.5f, 7f, 2.5f, 2f);
                var v = ov.swizzle.aaaa;
                Assert.AreEqual(2f, v.x);
                Assert.AreEqual(2f, v.y);
                Assert.AreEqual(2f, v.z);
                Assert.AreEqual(2f, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new vec4(6.5f, -2f, 0.5f, 8f);
                var v1 = new vec2(-8f, 2f);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8f, v0.x);
                Assert.AreEqual(2f, v0.y);
                Assert.AreEqual(0.5f, v0.z);
                Assert.AreEqual(8f, v0.w);
            
                Assert.AreEqual(6.5f, v2.x);
                Assert.AreEqual(-2f, v2.y);
            }
            {
                var v0 = new vec4(0f, 1f, -8f, 0.5f);
                var v1 = new vec2(1.5f, 2f);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(1.5f, v0.x);
                Assert.AreEqual(1f, v0.y);
                Assert.AreEqual(2f, v0.z);
                Assert.AreEqual(0.5f, v0.w);
            
                Assert.AreEqual(0f, v2.x);
                Assert.AreEqual(-8f, v2.y);
            }
            {
                var v0 = new vec4(-2.5f, 1f, 7.5f, 0f);
                var v1 = new vec2(6f, 9.5f);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-2.5f, v0.x);
                Assert.AreEqual(6f, v0.y);
                Assert.AreEqual(9.5f, v0.z);
                Assert.AreEqual(0f, v0.w);
            
                Assert.AreEqual(1f, v2.x);
                Assert.AreEqual(7.5f, v2.y);
            }
            {
                var v0 = new vec4(-7.5f, 5f, -7f, 3.5f);
                var v1 = new vec3(4.5f, -1.5f, -7f);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(4.5f, v0.x);
                Assert.AreEqual(-1.5f, v0.y);
                Assert.AreEqual(-7f, v0.z);
                Assert.AreEqual(3.5f, v0.w);
            
                Assert.AreEqual(-7.5f, v2.x);
                Assert.AreEqual(5f, v2.y);
                Assert.AreEqual(-7f, v2.z);
            }
            {
                var v0 = new vec4(5.5f, -3.5f, 7f, 6f);
                var v1 = new vec2(-3.5f, -7f);
                var v2 = v0.xw;
                v0.xw = v1;
                var v3 = v0.xw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3.5f, v0.x);
                Assert.AreEqual(-3.5f, v0.y);
                Assert.AreEqual(7f, v0.z);
                Assert.AreEqual(-7f, v0.w);
            
                Assert.AreEqual(5.5f, v2.x);
                Assert.AreEqual(6f, v2.y);
            }
            {
                var v0 = new vec4(7.5f, 3f, -7.5f, -9.5f);
                var v1 = new vec2(-0.5f, -7.5f);
                var v2 = v0.yw;
                v0.yw = v1;
                var v3 = v0.yw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(7.5f, v0.x);
                Assert.AreEqual(-0.5f, v0.y);
                Assert.AreEqual(-7.5f, v0.z);
                Assert.AreEqual(-7.5f, v0.w);
            
                Assert.AreEqual(3f, v2.x);
                Assert.AreEqual(-9.5f, v2.y);
            }
            {
                var v0 = new vec4(-7f, 4.5f, -9.5f, 9.5f);
                var v1 = new vec3(6f, 1f, 5.5f);
                var v2 = v0.xyw;
                v0.xyw = v1;
                var v3 = v0.xyw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6f, v0.x);
                Assert.AreEqual(1f, v0.y);
                Assert.AreEqual(-9.5f, v0.z);
                Assert.AreEqual(5.5f, v0.w);
            
                Assert.AreEqual(-7f, v2.x);
                Assert.AreEqual(4.5f, v2.y);
                Assert.AreEqual(9.5f, v2.z);
            }
            {
                var v0 = new vec4(-6f, 0f, -7f, -2.5f);
                var v1 = new vec2(-6.5f, 6.5f);
                var v2 = v0.zw;
                v0.zw = v1;
                var v3 = v0.zw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-6f, v0.x);
                Assert.AreEqual(0f, v0.y);
                Assert.AreEqual(-6.5f, v0.z);
                Assert.AreEqual(6.5f, v0.w);
            
                Assert.AreEqual(-7f, v2.x);
                Assert.AreEqual(-2.5f, v2.y);
            }
            {
                var v0 = new vec4(-7.5f, 9f, 4.5f, 4.5f);
                var v1 = new vec3(7f, 3f, -8f);
                var v2 = v0.xzw;
                v0.xzw = v1;
                var v3 = v0.xzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(7f, v0.x);
                Assert.AreEqual(9f, v0.y);
                Assert.AreEqual(3f, v0.z);
                Assert.AreEqual(-8f, v0.w);
            
                Assert.AreEqual(-7.5f, v2.x);
                Assert.AreEqual(4.5f, v2.y);
                Assert.AreEqual(4.5f, v2.z);
            }
            {
                var v0 = new vec4(1f, 2.5f, -7.5f, -7f);
                var v1 = new vec3(2.5f, 4.5f, 2.5f);
                var v2 = v0.yzw;
                v0.yzw = v1;
                var v3 = v0.yzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(1f, v0.x);
                Assert.AreEqual(2.5f, v0.y);
                Assert.AreEqual(4.5f, v0.z);
                Assert.AreEqual(2.5f, v0.w);
            
                Assert.AreEqual(2.5f, v2.x);
                Assert.AreEqual(-7.5f, v2.y);
                Assert.AreEqual(-7f, v2.z);
            }
            {
                var v0 = new vec4(-3f, 3.5f, 8.5f, 4f);
                var v1 = new vec4(-8.5f, 7f, -9f, 0.5f);
                var v2 = v0.xyzw;
                v0.xyzw = v1;
                var v3 = v0.xyzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8.5f, v0.x);
                Assert.AreEqual(7f, v0.y);
                Assert.AreEqual(-9f, v0.z);
                Assert.AreEqual(0.5f, v0.w);
            
                Assert.AreEqual(-3f, v2.x);
                Assert.AreEqual(3.5f, v2.y);
                Assert.AreEqual(8.5f, v2.z);
                Assert.AreEqual(4f, v2.w);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new vec4(0f, 6.5f, 7.5f, 9.5f);
                var v1 = 2f;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2f, v0.x);
                Assert.AreEqual(6.5f, v0.y);
                Assert.AreEqual(7.5f, v0.z);
                Assert.AreEqual(9.5f, v0.w);
            
                Assert.AreEqual(0f, v2);
            }
            {
                var v0 = new vec4(-0.5f, -4.5f, 4.5f, -8f);
                var v1 = 9.5f;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-0.5f, v0.x);
                Assert.AreEqual(9.5f, v0.y);
                Assert.AreEqual(4.5f, v0.z);
                Assert.AreEqual(-8f, v0.w);
            
                Assert.AreEqual(-4.5f, v2);
            }
            {
                var v0 = new vec4(-1f, -1f, -3.5f, -6.5f);
                var v1 = new vec2(6.5f, 1.5f);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6.5f, v0.x);
                Assert.AreEqual(1.5f, v0.y);
                Assert.AreEqual(-3.5f, v0.z);
                Assert.AreEqual(-6.5f, v0.w);
            
                Assert.AreEqual(-1f, v2.x);
                Assert.AreEqual(-1f, v2.y);
            }
            {
                var v0 = new vec4(-4f, -2f, -2.5f, -1.5f);
                var v1 = 1f;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-4f, v0.x);
                Assert.AreEqual(-2f, v0.y);
                Assert.AreEqual(1f, v0.z);
                Assert.AreEqual(-1.5f, v0.w);
            
                Assert.AreEqual(-2.5f, v2);
            }
            {
                var v0 = new vec4(-0.5f, 3f, 2f, -2.5f);
                var v1 = new vec2(-8f, 2f);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8f, v0.x);
                Assert.AreEqual(3f, v0.y);
                Assert.AreEqual(2f, v0.z);
                Assert.AreEqual(-2.5f, v0.w);
            
                Assert.AreEqual(-0.5f, v2.x);
                Assert.AreEqual(2f, v2.y);
            }
            {
                var v0 = new vec4(0.5f, 8.5f, 4f, 4.5f);
                var v1 = new vec2(7.5f, 9f);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(0.5f, v0.x);
                Assert.AreEqual(7.5f, v0.y);
                Assert.AreEqual(9f, v0.z);
                Assert.AreEqual(4.5f, v0.w);
            
                Assert.AreEqual(8.5f, v2.x);
                Assert.AreEqual(4f, v2.y);
            }
            {
                var v0 = new vec4(-7f, 0.5f, -6.5f, 4.5f);
                var v1 = new vec3(-7f, 7.5f, 3.5f);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-7f, v0.x);
                Assert.AreEqual(7.5f, v0.y);
                Assert.AreEqual(3.5f, v0.z);
                Assert.AreEqual(4.5f, v0.w);
            
                Assert.AreEqual(-7f, v2.x);
                Assert.AreEqual(0.5f, v2.y);
                Assert.AreEqual(-6.5f, v2.z);
            }
            {
                var v0 = new vec4(1f, -3f, -3.5f, -7.5f);
                var v1 = 1.5f;
                var v2 = v0.a;
                v0.a = v1;
                var v3 = v0.a;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(1f, v0.x);
                Assert.AreEqual(-3f, v0.y);
                Assert.AreEqual(-3.5f, v0.z);
                Assert.AreEqual(1.5f, v0.w);
            
                Assert.AreEqual(-7.5f, v2);
            }
            {
                var v0 = new vec4(6f, -0.5f, -8.5f, -2.5f);
                var v1 = new vec2(4.5f, 0.5f);
                var v2 = v0.ra;
                v0.ra = v1;
                var v3 = v0.ra;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(4.5f, v0.x);
                Assert.AreEqual(-0.5f, v0.y);
                Assert.AreEqual(-8.5f, v0.z);
                Assert.AreEqual(0.5f, v0.w);
            
                Assert.AreEqual(6f, v2.x);
                Assert.AreEqual(-2.5f, v2.y);
            }
            {
                var v0 = new vec4(3.5f, 0f, -0.5f, 2.5f);
                var v1 = new vec2(-2f, 3.5f);
                var v2 = v0.ga;
                v0.ga = v1;
                var v3 = v0.ga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3.5f, v0.x);
                Assert.AreEqual(-2f, v0.y);
                Assert.AreEqual(-0.5f, v0.z);
                Assert.AreEqual(3.5f, v0.w);
            
                Assert.AreEqual(0f, v2.x);
                Assert.AreEqual(2.5f, v2.y);
            }
            {
                var v0 = new vec4(5.5f, -2f, -5.5f, -2.5f);
                var v1 = new vec3(5.5f, 5.5f, -3f);
                var v2 = v0.rga;
                v0.rga = v1;
                var v3 = v0.rga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(5.5f, v0.x);
                Assert.AreEqual(5.5f, v0.y);
                Assert.AreEqual(-5.5f, v0.z);
                Assert.AreEqual(-3f, v0.w);
            
                Assert.AreEqual(5.5f, v2.x);
                Assert.AreEqual(-2f, v2.y);
                Assert.AreEqual(-2.5f, v2.z);
            }
            {
                var v0 = new vec4(4f, -3f, 1f, 9f);
                var v1 = new vec2(3.5f, -4f);
                var v2 = v0.ba;
                v0.ba = v1;
                var v3 = v0.ba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(4f, v0.x);
                Assert.AreEqual(-3f, v0.y);
                Assert.AreEqual(3.5f, v0.z);
                Assert.AreEqual(-4f, v0.w);
            
                Assert.AreEqual(1f, v2.x);
                Assert.AreEqual(9f, v2.y);
            }
            {
                var v0 = new vec4(7.5f, 6.5f, -5f, 3.5f);
                var v1 = new vec3(-3.5f, -1.5f, 2f);
                var v2 = v0.rba;
                v0.rba = v1;
                var v3 = v0.rba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3.5f, v0.x);
                Assert.AreEqual(6.5f, v0.y);
                Assert.AreEqual(-1.5f, v0.z);
                Assert.AreEqual(2f, v0.w);
            
                Assert.AreEqual(7.5f, v2.x);
                Assert.AreEqual(-5f, v2.y);
                Assert.AreEqual(3.5f, v2.z);
            }
            {
                var v0 = new vec4(-8.5f, -2f, -8.5f, -1.5f);
                var v1 = new vec3(-8.5f, 2f, 4f);
                var v2 = v0.gba;
                v0.gba = v1;
                var v3 = v0.gba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-8.5f, v0.x);
                Assert.AreEqual(-8.5f, v0.y);
                Assert.AreEqual(2f, v0.z);
                Assert.AreEqual(4f, v0.w);
            
                Assert.AreEqual(-2f, v2.x);
                Assert.AreEqual(-8.5f, v2.y);
                Assert.AreEqual(-1.5f, v2.z);
            }
            {
                var v0 = new vec4(-4f, 1f, 7.5f, -8.5f);
                var v1 = new vec4(-5.5f, -8f, 0.5f, 9.5f);
                var v2 = v0.rgba;
                v0.rgba = v1;
                var v3 = v0.rgba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5.5f, v0.x);
                Assert.AreEqual(-8f, v0.y);
                Assert.AreEqual(0.5f, v0.z);
                Assert.AreEqual(9.5f, v0.w);
            
                Assert.AreEqual(-4f, v2.x);
                Assert.AreEqual(1f, v2.y);
                Assert.AreEqual(7.5f, v2.z);
                Assert.AreEqual(-8.5f, v2.w);
            }
        }

    }
}
