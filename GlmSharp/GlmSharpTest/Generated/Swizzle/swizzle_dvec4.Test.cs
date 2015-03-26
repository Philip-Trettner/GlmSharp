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
    public class DoubleSwizzleVec4Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new dvec4(-0.5d, -6.5d, -6, 8.5d);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
            }
            {
                var ov = new dvec4(8.5d, -7.5d, 0.5d, -6);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
            }
            {
                var ov = new dvec4(-0.5d, 8, 9, 5.5d);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(-1.5d, 2, 5, -1);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new dvec4(-9, 5, 4.5d, -2.5d);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(-2, 3.5d, -6.5d, -4.5d);
                var v = ov.swizzle.xxxw;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(-3, -9.5d, -1.5d, 6.5d);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec4(3, 0.5d, -6, -4.5d);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(7, 8, 3, 8);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(0.0, 1.5d, 2.5d, -2.5d);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(1.5d, 9.5d, -1.5d, 5.5d);
                var v = ov.swizzle.xxyw;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(8.5d, 7, -0.5d, 1.0);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
            }
            {
                var ov = new dvec4(1.5d, -3, -5.5d, 5.5d);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(3, -9.5d, -6.5d, 6.5d);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, 0.5d, -4.5d, -9);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, 3.5d, -2, 8.5d);
                var v = ov.swizzle.xxzw;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(2.5d, -5.5d, -1.5d, -9);
                var v = ov.swizzle.xxw;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new dvec4(8.5d, 6.5d, -1, -2.5d);
                var v = ov.swizzle.xxwx;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(-4, 6, 5.5d, -2);
                var v = ov.swizzle.xxwy;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(4, -1.5d, -2.5d, 4);
                var v = ov.swizzle.xxwz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(0.5d, -2.5d, 4, 0.5d);
                var v = ov.swizzle.xxww;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(6, -9.5d, -7.5d, -2.5d);
                var v = ov.swizzle.xy;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-9.5d, v.y);
            }
            {
                var ov = new dvec4(-3.5d, 6, 8, 9);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec4(5, -3, 2.5d, 7.5d);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(-2.5d, 0.5d, 2, -5);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(-9.5d, -1, 2, 4.5d);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new dvec4(2, 6.5d, -7.5d, 6.5d);
                var v = ov.swizzle.xyxw;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -2, 2.5d, -2);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var ov = new dvec4(3, -8.5d, -1.5d, 7);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(-0.5d, -7.5d, 2.5d, -2);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(1.0, 0.0, 2.5d, 2.5d);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(-2.5d, 0.0, -7.5d, 0.0);
                var v = ov.swizzle.xyyw;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(-5, 8.5d, -5.5d, -5);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
            }
            {
                var ov = new dvec4(-4.5d, -2, -4.5d, -9);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(-4.5d, 9, -1.5d, 9);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(8.5d, -3.5d, 3, -4);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(-4, 7.5d, 6, -4.5d);
                var v = ov.swizzle.xyzw;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(-4.5d, -4.5d, 8, 5);
                var v = ov.swizzle.xyw;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new dvec4(7.5d, 0.5d, -3, -9);
                var v = ov.swizzle.xywx;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(-9, 9, 7, 1.0);
                var v = ov.swizzle.xywy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(-5, -7.5d, -7.5d, -3.5d);
                var v = ov.swizzle.xywz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(-2.5d, -8, -2.5d, 1.5d);
                var v = ov.swizzle.xyww;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(6.5d, 8, -6.5d, -9);
                var v = ov.swizzle.xz;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
            }
            {
                var ov = new dvec4(3.5d, -7.5d, -4, -5);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(3.5d, v.z);
            }
            {
                var ov = new dvec4(7.5d, -8, -8, 0.5d);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, 7.5d, -5, -0.5d);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(0.5d, -8, -7, 4.5d);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(9.5d, 5, 0.0, -5);
                var v = ov.swizzle.xzxw;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(2, -2.5d, 5.5d, -7);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
            }
            {
                var ov = new dvec4(4, -8, -2.5d, 6.5d);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(-1, -6, -0.5d, -6);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new dvec4(2, 0.5d, -3, -6);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(-7, 7.5d, -7.5d, 0.0);
                var v = ov.swizzle.xzyw;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(1.5d, -7, 7, -8);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var ov = new dvec4(6, 2.5d, 5.5d, 9);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(0.0, 2.5d, 1.5d, 0.5d);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(8, 7, -6, 6);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new dvec4(-3.5d, 7.5d, -1, -9);
                var v = ov.swizzle.xzzw;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(1.5d, -7.5d, -9.5d, -9);
                var v = ov.swizzle.xzw;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new dvec4(7, 9.5d, -2.5d, 9.5d);
                var v = ov.swizzle.xzwx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(5, 1.0, -8, 2);
                var v = ov.swizzle.xzwy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(-5.5d, 9.5d, -5.5d, -3.5d);
                var v = ov.swizzle.xzwz;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-9.5d, -8, 9, -3);
                var v = ov.swizzle.xzww;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(-7.5d, -7, 5.5d, -8);
                var v = ov.swizzle.xw;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-8, v.y);
            }
            {
                var ov = new dvec4(-5.5d, 8.5d, 7, 4.5d);
                var v = ov.swizzle.xwx;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
            }
            {
                var ov = new dvec4(-4, 6, -0.5d, -9);
                var v = ov.swizzle.xwxx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(-2.5d, 2, 8, 8);
                var v = ov.swizzle.xwxy;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new dvec4(7.5d, -0.5d, 9, 7);
                var v = ov.swizzle.xwxz;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(5, 6.5d, 4, 9.5d);
                var v = ov.swizzle.xwxw;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(-5, -0.5d, 6, 8);
                var v = ov.swizzle.xwy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-0.5d, v.z);
            }
            {
                var ov = new dvec4(-5.5d, 0.5d, -3.5d, 8);
                var v = ov.swizzle.xwyx;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-2.5d, 8.5d, 7.5d, -5);
                var v = ov.swizzle.xwyy;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(-3.5d, 2, 4.5d, 9);
                var v = ov.swizzle.xwyz;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(2.5d, 2.5d, -3.5d, 9.5d);
                var v = ov.swizzle.xwyw;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(-2, 8.5d, -5, -8.5d);
                var v = ov.swizzle.xwz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new dvec4(1.5d, -5, -1.5d, 1.5d);
                var v = ov.swizzle.xwzx;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(7, 2, 6, -3.5d);
                var v = ov.swizzle.xwzy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new dvec4(-3, 6.5d, 3, 4.5d);
                var v = ov.swizzle.xwzz;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(2.5d, 8.5d, -1, -5.5d);
                var v = ov.swizzle.xwzw;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-9.5d, -9.5d, 1.5d, -0.5d);
                var v = ov.swizzle.xww;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
            }
            {
                var ov = new dvec4(5, 4.5d, -6.5d, 5.5d);
                var v = ov.swizzle.xwwx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(4.5d, 0.0, -6, -4);
                var v = ov.swizzle.xwwy;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(9, 5, -1.5d, -6);
                var v = ov.swizzle.xwwz;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(-4, -4.5d, -8, 9);
                var v = ov.swizzle.xwww;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(1.0, 5.5d, 1.0, -4.5d);
                var v = ov.swizzle.yx;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(1.0, v.y);
            }
            {
                var ov = new dvec4(1.5d, -1, 1.0, 0.5d);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
            }
            {
                var ov = new dvec4(8.5d, 9.5d, -7, 3.5d);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(-8.5d, 1.0, -9, 1.5d);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(7, -3.5d, -5, 6.5d);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(1.5d, 3.5d, 6.5d, 7);
                var v = ov.swizzle.yxxw;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-2.5d, 2.5d, -6, 7);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
            }
            {
                var ov = new dvec4(8, -2.5d, -9.5d, 7);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(-8.5d, 1.0, -7.5d, -5.5d);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(-9, 5, 7.5d, 4.5d);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(2.5d, 3.5d, 6.5d, 4.5d);
                var v = ov.swizzle.yxyw;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(-6.5d, -7.5d, 2.5d, 7);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
            }
            {
                var ov = new dvec4(-3.5d, 6.5d, 8, -1.5d);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(9, -8.5d, -8, 7);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(8.5d, 3.5d, 8.5d, 8.5d);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, 3.5d, -7.5d, -2);
                var v = ov.swizzle.yxzw;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(-9.5d, 9, -2, -9.5d);
                var v = ov.swizzle.yxw;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec4(-9.5d, 4.5d, -2, 1.0);
                var v = ov.swizzle.yxwx;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(-0.5d, -9.5d, 3, 8.5d);
                var v = ov.swizzle.yxwy;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(7.5d, 2, -5.5d, 4);
                var v = ov.swizzle.yxwz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(0.0, 7, -7.5d, -2);
                var v = ov.swizzle.yxww;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(-9, 2.5d, 7.5d, 0.0);
                var v = ov.swizzle.yy;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
            }
            {
                var ov = new dvec4(-5.5d, -5, -4.5d, -3.5d);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5.5d, v.z);
            }
            {
                var ov = new dvec4(7, 8.5d, 0.0, 9.5d);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-1, -4.5d, -5, -4);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(9, -3, -1.5d, 1.5d);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, 6, 8.5d, -0.5d);
                var v = ov.swizzle.yyxw;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(-7, -9, -1, 6.5d);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new dvec4(8, 3.5d, 8.5d, -2.5d);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(-2, 9, 2.5d, -2.5d);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(-2, -2, 5.5d, 4);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(8, -3.5d, 3.5d, 0.5d);
                var v = ov.swizzle.yyyw;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(-9.5d, 4, -1.5d, -3);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-1.5d, v.z);
            }
            {
                var ov = new dvec4(-1.5d, -1, 4.5d, -2.5d);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(-9.5d, 0.5d, -2.5d, -2);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(3.5d, 7, -5.5d, 4);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(3, -0.5d, -7, -4);
                var v = ov.swizzle.yyzw;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(9.5d, -3, -2.5d, 0.0);
                var v = ov.swizzle.yyw;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(0.0, v.z);
            }
            {
                var ov = new dvec4(2.5d, -2.5d, 1.0, 8.5d);
                var v = ov.swizzle.yywx;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(-8, -6.5d, -7.5d, 8.5d);
                var v = ov.swizzle.yywy;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(-3, 8, 8, -2);
                var v = ov.swizzle.yywz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(1.5d, 8.5d, 8, 8.5d);
                var v = ov.swizzle.yyww;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, -2, 7, -7.5d);
                var v = ov.swizzle.yz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(7, v.y);
            }
            {
                var ov = new dvec4(-6.5d, -9.5d, 4.5d, 3);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
            }
            {
                var ov = new dvec4(-1.5d, 0.5d, 1.0, -9.5d);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(8, -9.5d, 0.5d, 6);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(-8, -2.5d, -9.5d, 1.0);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(8, 6.5d, 9, 6.5d);
                var v = ov.swizzle.yzxw;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(7, -1.5d, 9.5d, -4.5d);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
            }
            {
                var ov = new dvec4(8.5d, -2, -4, 5);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(-8.5d, -9, -5, -1.5d);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(5, 5, -8, -2);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new dvec4(2.5d, 7.5d, -1, -2.5d);
                var v = ov.swizzle.yzyw;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(-7.5d, 2, 0.5d, 3.5d);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
            }
            {
                var ov = new dvec4(-8, 1.0, 3.5d, 4);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new dvec4(-8, 7, -0.5d, 2);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(2, -1, -4, 4.5d);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(-8.5d, 8, 4, -6);
                var v = ov.swizzle.yzzw;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new dvec4(-7, 5.5d, 9.5d, 0.5d);
                var v = ov.swizzle.yzw;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
            }
            {
                var ov = new dvec4(4, 2, 0.0, -3);
                var v = ov.swizzle.yzwx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(8, 8, 8, -1);
                var v = ov.swizzle.yzwy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(-3.5d, -7.5d, -4, 5);
                var v = ov.swizzle.yzwz;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(8.5d, 5, 7, 6.5d);
                var v = ov.swizzle.yzww;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(-8, 9, -1.5d, -4);
                var v = ov.swizzle.yw;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-4, v.y);
            }
            {
                var ov = new dvec4(-0.5d, -3, -4.5d, 5.5d);
                var v = ov.swizzle.ywx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
            }
            {
                var ov = new dvec4(2.5d, -5.5d, 1.5d, -6.5d);
                var v = ov.swizzle.ywxx;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(2.5d, 4.5d, 9, -2.5d);
                var v = ov.swizzle.ywxy;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(3, 9.5d, -1.5d, -5);
                var v = ov.swizzle.ywxz;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(1.0, -8.5d, 6.5d, 9);
                var v = ov.swizzle.ywxw;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(8.5d, -8, -6, -9.5d);
                var v = ov.swizzle.ywy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var ov = new dvec4(7.5d, 7, 5.5d, -6);
                var v = ov.swizzle.ywyx;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(1.0, 8, 7.5d, 7);
                var v = ov.swizzle.ywyy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(7, -4.5d, 0.0, 2.5d);
                var v = ov.swizzle.ywyz;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(-8, 5, -8.5d, -4.5d);
                var v = ov.swizzle.ywyw;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(-8, -4.5d, -9, 1.5d);
                var v = ov.swizzle.ywz;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new dvec4(-3, -2.5d, 2, 8.5d);
                var v = ov.swizzle.ywzx;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(-7, 2.5d, 5.5d, 7.5d);
                var v = ov.swizzle.ywzy;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(-4, -9, -5, -1);
                var v = ov.swizzle.ywzz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(6.5d, 4, 7.5d, -5.5d);
                var v = ov.swizzle.ywzw;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-1.5d, -5, -7.5d, -5.5d);
                var v = ov.swizzle.yww;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
            }
            {
                var ov = new dvec4(7.5d, 1.0, -9, -8);
                var v = ov.swizzle.ywwx;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, 6.5d, 7.5d, 5.5d);
                var v = ov.swizzle.ywwy;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(0.0, -1, 2.5d, -4);
                var v = ov.swizzle.ywwz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, -4.5d, 7, -1);
                var v = ov.swizzle.ywww;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(5, 6.5d, 8.5d, 8);
                var v = ov.swizzle.zx;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var ov = new dvec4(-3, 0.0, 4.5d, -0.5d);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
            }
            {
                var ov = new dvec4(-1, -0.5d, 6.5d, -3);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(8, 6.5d, 6.5d, 2);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(3, 4.5d, 4.5d, -1);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(7, -4.5d, 9.5d, -8.5d);
                var v = ov.swizzle.zxxw;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(5.5d, 0.0, 6.5d, 2);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(0.0, v.z);
            }
            {
                var ov = new dvec4(-3.5d, 0.0, -2, -2);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(7.5d, -2.5d, -9, 1.5d);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(-7, -3, -2, 7.5d);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(7, 0.5d, 6, 9);
                var v = ov.swizzle.zxyw;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(9.5d, -5.5d, -3.5d, 4);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec4(-5, 0.5d, -1, 5);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(0.5d, 6.5d, 2, -9.5d);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(7.5d, -7, -4, -2);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(3, 2.5d, 2, -1);
                var v = ov.swizzle.zxzw;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(-8, -4.5d, -5, -8.5d);
                var v = ov.swizzle.zxw;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8.5d, v.z);
            }
            {
                var ov = new dvec4(-8, 4, -4.5d, 0.5d);
                var v = ov.swizzle.zxwx;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new dvec4(-7.5d, 7.5d, 2, -7);
                var v = ov.swizzle.zxwy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(-8, -0.5d, -8.5d, -1);
                var v = ov.swizzle.zxwz;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(-4, 2.5d, -2.5d, 6.5d);
                var v = ov.swizzle.zxww;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(0.5d, 5, -8.5d, 0.0);
                var v = ov.swizzle.zy;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var ov = new dvec4(-5.5d, 8.5d, 4.5d, 0.0);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
            }
            {
                var ov = new dvec4(9.5d, 0.0, 3.5d, -6);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(-1.5d, 6.5d, 2.5d, -5);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(9, 5, -3.5d, -1);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(4, -9.5d, -6.5d, 3.5d);
                var v = ov.swizzle.zyxw;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, -4.5d, 2, 7);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
            }
            {
                var ov = new dvec4(5.5d, 2, 7.5d, -2);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(5, 5, -8.5d, -2);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(3, -5, 6.5d, -9);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(9, -4.5d, 1.5d, -7.5d);
                var v = ov.swizzle.zyyw;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(3, -2.5d, -0.5d, -7.5d);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
            }
            {
                var ov = new dvec4(7.5d, 6, 1.0, 8);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(5, -7, 2.5d, 9);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(-6.5d, -2.5d, 6, 8.5d);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(6.5d, -2.5d, 4, 6.5d);
                var v = ov.swizzle.zyzw;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(2, -7.5d, -1, -7.5d);
                var v = ov.swizzle.zyw;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
            }
            {
                var ov = new dvec4(-6, -9.5d, -2, 5.5d);
                var v = ov.swizzle.zywx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new dvec4(8, 7, 0.0, -9.5d);
                var v = ov.swizzle.zywy;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 1.0, 0.5d, 6);
                var v = ov.swizzle.zywz;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(6.5d, -8.5d, 9, -0.5d);
                var v = ov.swizzle.zyww;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(1.0, -1.5d, 5, -1.5d);
                var v = ov.swizzle.zz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var ov = new dvec4(-4, -1, -0.5d, -6);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new dvec4(7, 8.5d, -6.5d, -6.5d);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-9.5d, 4.5d, -9, -7.5d);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(-7, 7, 5, -8);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(4.5d, 6, 0.0, 8.5d);
                var v = ov.swizzle.zzxw;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(-6, -2, -9.5d, -8.5d);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var ov = new dvec4(7.5d, 0.0, 2, -6);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(-7, -5, 5.5d, -4);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(-6, -7.5d, 8, 4);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(1.5d, 5.5d, -2.5d, -1);
                var v = ov.swizzle.zzyw;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -7, 9.5d, 4.5d);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
            }
            {
                var ov = new dvec4(-7.5d, 8, -0.5d, -0.5d);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(-5, 2.5d, 4.5d, 4.5d);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(-1.5d, 7, -2, 1.0);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(1.5d, 7, -9, 6);
                var v = ov.swizzle.zzzw;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(5.5d, 7, 5, 5);
                var v = ov.swizzle.zzw;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new dvec4(9.5d, 4, 5, 5.5d);
                var v = ov.swizzle.zzwx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(8.5d, 1.0, -2.5d, 9.5d);
                var v = ov.swizzle.zzwy;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(-9, 0.5d, -4, 9.5d);
                var v = ov.swizzle.zzwz;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(-3, -3.5d, 9.5d, -0.5d);
                var v = ov.swizzle.zzww;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(-2, -4, 0.0, -4.5d);
                var v = ov.swizzle.zw;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(-4.5d, v.y);
            }
            {
                var ov = new dvec4(-8.5d, 0.0, -3.5d, 8);
                var v = ov.swizzle.zwx;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-8.5d, v.z);
            }
            {
                var ov = new dvec4(9, 6, -4, -6.5d);
                var v = ov.swizzle.zwxx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(-6, -8.5d, -5, -6);
                var v = ov.swizzle.zwxy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(-2, 4.5d, 5.5d, -7);
                var v = ov.swizzle.zwxz;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(2, 3.5d, 0.5d, -4);
                var v = ov.swizzle.zwxw;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(5, 4.5d, -6, 7.5d);
                var v = ov.swizzle.zwy;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
            }
            {
                var ov = new dvec4(3.5d, -3, -1.5d, 4);
                var v = ov.swizzle.zwyx;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(8, 0.5d, 5.5d, -7.5d);
                var v = ov.swizzle.zwyy;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(6, -9.5d, -5.5d, 8.5d);
                var v = ov.swizzle.zwyz;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-9, 7.5d, -3.5d, 2.5d);
                var v = ov.swizzle.zwyw;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(-2.5d, 3, -5.5d, 8.5d);
                var v = ov.swizzle.zwz;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
            }
            {
                var ov = new dvec4(-5, 8.5d, -2.5d, -9);
                var v = ov.swizzle.zwzx;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(0.5d, -7.5d, -2.5d, -8);
                var v = ov.swizzle.zwzy;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(-6.5d, -2.5d, -9.5d, -3.5d);
                var v = ov.swizzle.zwzz;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(-4.5d, -1.5d, -5, 6.5d);
                var v = ov.swizzle.zwzw;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(-8, 8, -4, -3.5d);
                var v = ov.swizzle.zww;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec4(-4.5d, 3.5d, 8, 1.5d);
                var v = ov.swizzle.zwwx;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(9, 7.5d, 8.5d, 4);
                var v = ov.swizzle.zwwy;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(7, 7.5d, -3.5d, 1.0);
                var v = ov.swizzle.zwwz;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(-1, -8, -6.5d, 5.5d);
                var v = ov.swizzle.zwww;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(-4.5d, 9, -5, -3.5d);
                var v = ov.swizzle.wx;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
            }
            {
                var ov = new dvec4(3, -8, 8.5d, -9.5d);
                var v = ov.swizzle.wxx;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new dvec4(0.0, 8.5d, -4, 0.5d);
                var v = ov.swizzle.wxxx;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(-7.5d, -0.5d, -5, -8);
                var v = ov.swizzle.wxxy;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 7.5d, -3, -7.5d);
                var v = ov.swizzle.wxxz;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 6.5d, 9, 3.5d);
                var v = ov.swizzle.wxxw;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(-6.5d, -7.5d, 9, -3.5d);
                var v = ov.swizzle.wxy;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
            }
            {
                var ov = new dvec4(0.0, -9, -6, 6);
                var v = ov.swizzle.wxyx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(5, -9.5d, -2, 8);
                var v = ov.swizzle.wxyy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, -1.5d, -6.5d, 7);
                var v = ov.swizzle.wxyz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(5.5d, -0.5d, 0.5d, -1);
                var v = ov.swizzle.wxyw;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(-6.5d, 8, -6.5d, -9);
                var v = ov.swizzle.wxz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
            }
            {
                var ov = new dvec4(-6.5d, 8, -2, -3);
                var v = ov.swizzle.wxzx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(4, 0.0, 6, -0.5d);
                var v = ov.swizzle.wxzy;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(0.0, -8.5d, 3, -8.5d);
                var v = ov.swizzle.wxzz;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(7, -3, -9.5d, -8.5d);
                var v = ov.swizzle.wxzw;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(-6.5d, 6, -5.5d, 1.0);
                var v = ov.swizzle.wxw;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(1.0, v.z);
            }
            {
                var ov = new dvec4(-7, 5, -5.5d, 1.0);
                var v = ov.swizzle.wxwx;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(-5, 5, -2.5d, 9.5d);
                var v = ov.swizzle.wxwy;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(5, 8.5d, 9, -5);
                var v = ov.swizzle.wxwz;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(8.5d, 1.5d, 2, 2.5d);
                var v = ov.swizzle.wxww;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(7, 2, 1.0, 5);
                var v = ov.swizzle.wy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var ov = new dvec4(-4, -6.5d, 7, -3);
                var v = ov.swizzle.wyx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new dvec4(-4.5d, 1.0, 0.0, -7.5d);
                var v = ov.swizzle.wyxx;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(8, 8, -1.5d, -7);
                var v = ov.swizzle.wyxy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(-4.5d, -8.5d, 1.0, -7);
                var v = ov.swizzle.wyxz;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(-5.5d, 9, 8.5d, 9.5d);
                var v = ov.swizzle.wyxw;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(-4, 6, -6.5d, 2);
                var v = ov.swizzle.wyy;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new dvec4(-2, -1.5d, -7.5d, -6);
                var v = ov.swizzle.wyyx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(9, -1.5d, -4, -9.5d);
                var v = ov.swizzle.wyyy;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(4, -8, -1.5d, 4.5d);
                var v = ov.swizzle.wyyz;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(8.5d, -1, -7, -3);
                var v = ov.swizzle.wyyw;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(4, 4, 1.5d, 6.5d);
                var v = ov.swizzle.wyz;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(1.5d, v.z);
            }
            {
                var ov = new dvec4(9, 3.5d, -0.5d, -8);
                var v = ov.swizzle.wyzx;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(0.5d, -4.5d, 7, 7.5d);
                var v = ov.swizzle.wyzy;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(4, 1.0, 2.5d, 7);
                var v = ov.swizzle.wyzz;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, 5, 1.0, 6.5d);
                var v = ov.swizzle.wyzw;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(-9, -4.5d, -2, -9.5d);
                var v = ov.swizzle.wyw;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec4(5.5d, 7, -2, 6);
                var v = ov.swizzle.wywx;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(2.5d, 6, -9, -3);
                var v = ov.swizzle.wywy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(2.5d, -4.5d, 5.5d, 8);
                var v = ov.swizzle.wywz;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(-5, -3.5d, 2.5d, -8);
                var v = ov.swizzle.wyww;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new dvec4(9.5d, 4, -3.5d, -4.5d);
                var v = ov.swizzle.wz;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
            }
            {
                var ov = new dvec4(-9.5d, -6, -6, 3);
                var v = ov.swizzle.wzx;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec4(-3.5d, -8.5d, 4.5d, 2.5d);
                var v = ov.swizzle.wzxx;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(9, -8.5d, 4.5d, -9.5d);
                var v = ov.swizzle.wzxy;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(2.5d, -1, 1.0, 1.0);
                var v = ov.swizzle.wzxz;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(-8.5d, -7.5d, -4.5d, -6.5d);
                var v = ov.swizzle.wzxw;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(5, 4.5d, 5, -9);
                var v = ov.swizzle.wzy;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(4.5d, v.z);
            }
            {
                var ov = new dvec4(6, -6.5d, 2.5d, -4);
                var v = ov.swizzle.wzyx;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(-4, -6.5d, 6.5d, -5);
                var v = ov.swizzle.wzyy;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(8.5d, -2.5d, 0.0, -9);
                var v = ov.swizzle.wzyz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(2.5d, 8, -9.5d, -2);
                var v = ov.swizzle.wzyw;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(-2, -2.5d, 3, -1);
                var v = ov.swizzle.wzz;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new dvec4(1.5d, -5, -7, 4);
                var v = ov.swizzle.wzzx;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, 1.5d, 7.5d, -7);
                var v = ov.swizzle.wzzy;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(-9, 2, -9, -4.5d);
                var v = ov.swizzle.wzzz;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(-1, 7.5d, 6.5d, 3);
                var v = ov.swizzle.wzzw;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(-1.5d, -8.5d, -9, -3.5d);
                var v = ov.swizzle.wzw;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec4(-5.5d, -9, -8.5d, 5);
                var v = ov.swizzle.wzwx;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-1, -6.5d, 9, -3);
                var v = ov.swizzle.wzwy;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(1.0, -3, -1, -9);
                var v = ov.swizzle.wzwz;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(1.5d, 4.5d, -2.5d, 1.5d);
                var v = ov.swizzle.wzww;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(6, -1.5d, -0.5d, -7.5d);
                var v = ov.swizzle.ww;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
            }
            {
                var ov = new dvec4(-3.5d, -9.5d, 5.5d, 6.5d);
                var v = ov.swizzle.wwx;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec4(7, -5, 7, 4.5d);
                var v = ov.swizzle.wwxx;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-2, -7, -5.5d, 1.5d);
                var v = ov.swizzle.wwxy;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(7, -8, -2.5d, -2);
                var v = ov.swizzle.wwxz;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, -2, 3.5d, 1.0);
                var v = ov.swizzle.wwxw;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(-8.5d, -5.5d, -5, 5);
                var v = ov.swizzle.wwy;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-5.5d, v.z);
            }
            {
                var ov = new dvec4(2.5d, 9.5d, 4.5d, -6);
                var v = ov.swizzle.wwyx;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(9, 5, 6.5d, 9.5d);
                var v = ov.swizzle.wwyy;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(1.5d, 6.5d, 9.5d, 4);
                var v = ov.swizzle.wwyz;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -4.5d, 7.5d, 6.5d);
                var v = ov.swizzle.wwyw;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(-5, -5, 1.0, -4.5d);
                var v = ov.swizzle.wwz;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(1.0, v.z);
            }
            {
                var ov = new dvec4(-0.5d, -9, -1, -3);
                var v = ov.swizzle.wwzx;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(7, -5, 7.5d, 5.5d);
                var v = ov.swizzle.wwzy;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(4.5d, -2.5d, 1.0, 1.0);
                var v = ov.swizzle.wwzz;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(5, -0.5d, 4, 8);
                var v = ov.swizzle.wwzw;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(-9.5d, 2.5d, -5.5d, 5);
                var v = ov.swizzle.www;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
            }
            {
                var ov = new dvec4(-9.5d, -5.5d, 9.5d, -2);
                var v = ov.swizzle.wwwx;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(-8, -6.5d, -1.5d, 8);
                var v = ov.swizzle.wwwy;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(-4, 7.5d, -2.5d, 6);
                var v = ov.swizzle.wwwz;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(-6.5d, 0.5d, -7, -3);
                var v = ov.swizzle.wwww;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new dvec4(-5, -6, 9, 8);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
            }
            {
                var ov = new dvec4(9.5d, 8.5d, -9.5d, -1);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
            }
            {
                var ov = new dvec4(7, -2.5d, 5, -9.5d);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(5.5d, 9.5d, -6.5d, -3);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(-7.5d, 4, -6, 8.5d);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new dvec4(-5, -9.5d, 8, -8.5d);
                var v = ov.swizzle.rrra;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(5.5d, -1.5d, -3, -8.5d);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
            }
            {
                var ov = new dvec4(-7.5d, -7.5d, 5, 5);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(9, -9.5d, -0.5d, 8);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(-2, -8.5d, 9.5d, -1);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(1.5d, 2, 2.5d, 4);
                var v = ov.swizzle.rrga;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 5, -3.5d, -5);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec4(-8, -7, -1.5d, 4);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new dvec4(1.5d, 3.5d, 4, 4.5d);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(6, -0.5d, -3, -1);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(-3.5d, 9.5d, -0.5d, -3.5d);
                var v = ov.swizzle.rrba;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(-8.5d, 0.0, -1, -6);
                var v = ov.swizzle.rra;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var ov = new dvec4(9, -4, 1.0, 0.0);
                var v = ov.swizzle.rrar;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(5, 4, 6, -3);
                var v = ov.swizzle.rrag;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(-1.5d, 4, 1.5d, 0.5d);
                var v = ov.swizzle.rrab;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(1.0, 7.5d, 3, 4);
                var v = ov.swizzle.rraa;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(3.5d, 1.0, -5, -7);
                var v = ov.swizzle.rg;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(1.0, v.y);
            }
            {
                var ov = new dvec4(-6, 5.5d, 2, -7.5d);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var ov = new dvec4(7, -1.5d, -4.5d, 2.5d);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-3, 6, -5.5d, -0.5d);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(5.5d, -1, 5, 4);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(-6, -1.5d, 9.5d, -3.5d);
                var v = ov.swizzle.rgra;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(-3.5d, 2.5d, 6, 2);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
            }
            {
                var ov = new dvec4(7.5d, -6.5d, 9, -1.5d);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(6.5d, -5.5d, 2.5d, -9);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-3.5d, 3.5d, 9.5d, -4);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(-1, -9, 2.5d, -7);
                var v = ov.swizzle.rgga;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(-9.5d, -5, 9.5d, -8.5d);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(9.5d, v.z);
            }
            {
                var ov = new dvec4(-9.5d, 2, 5.5d, 0.5d);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(2.5d, 9.5d, -0.5d, 5);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(2, -1.5d, 0.5d, -5.5d);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 0.0, -4.5d, -4.5d);
                var v = ov.swizzle.rgba;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(-8, 6.5d, 6.5d, -0.5d);
                var v = ov.swizzle.rga;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
            }
            {
                var ov = new dvec4(-4, 4, 2, 1.0);
                var v = ov.swizzle.rgar;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(-1, 1.5d, 3.5d, 7.5d);
                var v = ov.swizzle.rgag;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(5.5d, -7.5d, 6, -2);
                var v = ov.swizzle.rgab;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(2.5d, -4.5d, -7.5d, 4.5d);
                var v = ov.swizzle.rgaa;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(-1.5d, -9, 5.5d, 6.5d);
                var v = ov.swizzle.rb;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
            }
            {
                var ov = new dvec4(4.5d, -2.5d, -7, 7.5d);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(4.5d, v.z);
            }
            {
                var ov = new dvec4(2, -6, -4.5d, -1);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new dvec4(3.5d, 7, 9.5d, -6.5d);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-8, 9, 7, -6);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(9.5d, 3.5d, -9.5d, 1.0);
                var v = ov.swizzle.rbra;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(5, 2.5d, -1, -9.5d);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(2.5d, v.z);
            }
            {
                var ov = new dvec4(-7.5d, -9, 1.5d, 3);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(-8, 0.5d, 6.5d, 9.5d);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(0.0, 9.5d, 4.5d, -3.5d);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(-2.5d, 5, 8.5d, 5.5d);
                var v = ov.swizzle.rbga;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(5, -7.5d, 3, -1.5d);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new dvec4(-6.5d, -6.5d, 4.5d, -6.5d);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(-7, 6, 5.5d, 4.5d);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(9.5d, 4.5d, 0.5d, 2);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(-7, 7.5d, -5, -5.5d);
                var v = ov.swizzle.rbba;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -7.5d, 3.5d, 3);
                var v = ov.swizzle.rba;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new dvec4(-1, 0.0, -6.5d, -9);
                var v = ov.swizzle.rbar;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(-5, -8.5d, -1.5d, 4.5d);
                var v = ov.swizzle.rbag;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(5.5d, -5.5d, 6.5d, -5.5d);
                var v = ov.swizzle.rbab;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(-1.5d, -6.5d, 7.5d, 9.5d);
                var v = ov.swizzle.rbaa;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, 8, -2.5d, -2);
                var v = ov.swizzle.ra;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-2, v.y);
            }
            {
                var ov = new dvec4(5.5d, 2, 9.5d, 6);
                var v = ov.swizzle.rar;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(5.5d, v.z);
            }
            {
                var ov = new dvec4(8, 1.5d, 9, 0.5d);
                var v = ov.swizzle.rarr;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(0.5d, -4, -1, -5.5d);
                var v = ov.swizzle.rarg;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 0.0, -7, -6.5d);
                var v = ov.swizzle.rarb;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(0.0, -5, 7, 5.5d);
                var v = ov.swizzle.rara;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(-8, 0.0, 9.5d, -5);
                var v = ov.swizzle.rag;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(0.0, v.z);
            }
            {
                var ov = new dvec4(7.5d, 6, -5, 4.5d);
                var v = ov.swizzle.ragr;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, -6, 9.5d, -6);
                var v = ov.swizzle.ragg;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new dvec4(4.5d, -7.5d, 7, 8);
                var v = ov.swizzle.ragb;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(0.0, -6, 9, -5.5d);
                var v = ov.swizzle.raga;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-1, 8.5d, 4, -7.5d);
                var v = ov.swizzle.rab;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(4, v.z);
            }
            {
                var ov = new dvec4(-4, -3, 5.5d, -1.5d);
                var v = ov.swizzle.rabr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(5, -5, 9.5d, 9);
                var v = ov.swizzle.rabg;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(1.0, 1.5d, 3.5d, 4.5d);
                var v = ov.swizzle.rabb;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(3, -4.5d, 8, 2);
                var v = ov.swizzle.raba;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new dvec4(-7, -6, 0.5d, -4);
                var v = ov.swizzle.raa;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new dvec4(-4, 5.5d, -0.5d, 6);
                var v = ov.swizzle.raar;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(2.5d, 8, -7.5d, -5.5d);
                var v = ov.swizzle.raag;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(5, -5.5d, -5.5d, -9);
                var v = ov.swizzle.raab;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(6.5d, -7, 0.0, -4.5d);
                var v = ov.swizzle.raaa;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(-2, -2.5d, -1.5d, -4.5d);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2, v.y);
            }
            {
                var ov = new dvec4(-7, 0.5d, -5, 3);
                var v = ov.swizzle.grr;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var ov = new dvec4(-1.5d, -4, 5, -5);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(6, 7, 6, 5.5d);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(8, 0.5d, 7, -9);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-6.5d, -1.5d, 5.5d, 7.5d);
                var v = ov.swizzle.grra;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(2.5d, -5, 3, -8);
                var v = ov.swizzle.grg;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new dvec4(6, -5, 8.5d, -3.5d);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -5.5d, 0.5d, 0.5d);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(-1.5d, 5, 7.5d, -6.5d);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec4(-9.5d, -4.5d, -8, -9);
                var v = ov.swizzle.grga;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(3, 7, -8, 8.5d);
                var v = ov.swizzle.grb;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var ov = new dvec4(-7, -0.5d, -1, 6);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(9, -7.5d, 1.0, -6.5d);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(1.5d, 0.5d, 2.5d, 2);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(-2.5d, 7.5d, 7.5d, -4);
                var v = ov.swizzle.grba;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(-5, -9, 1.5d, -6.5d);
                var v = ov.swizzle.gra;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-6.5d, v.z);
            }
            {
                var ov = new dvec4(-7, -7, 6, 3);
                var v = ov.swizzle.grar;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(3.5d, -4.5d, 8.5d, 8.5d);
                var v = ov.swizzle.grag;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(9, -7, 4.5d, -4.5d);
                var v = ov.swizzle.grab;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(6.5d, 5, 0.0, -7);
                var v = ov.swizzle.graa;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(3, 2.5d, -6, 2);
                var v = ov.swizzle.gg;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
            }
            {
                var ov = new dvec4(-7.5d, 7, 8.5d, 7.5d);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-7.5d, v.z);
            }
            {
                var ov = new dvec4(-3, 4.5d, 6.5d, -6.5d);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(-1.5d, 4, 3, -5.5d);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(-6, 5.5d, -8.5d, 0.0);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(-6.5d, 7, -4, -4.5d);
                var v = ov.swizzle.ggra;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, 3, -3, -5);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new dvec4(6.5d, 7, 5, -8.5d);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(6.5d, -9.5d, 9, -6.5d);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(2, -0.5d, 0.0, 8);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(-8, 9, 1.5d, 8.5d);
                var v = ov.swizzle.ggga;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(-1.5d, -5, 9, 5);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new dvec4(-3, -1, 8, 1.0);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(-5.5d, 0.0, 4.5d, 6.5d);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(-8, 1.5d, -9, -9);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(5.5d, -5.5d, 1.0, 4);
                var v = ov.swizzle.ggba;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(-1.5d, -5, -2.5d, 8);
                var v = ov.swizzle.gga;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var ov = new dvec4(4.5d, -9.5d, -8.5d, -2.5d);
                var v = ov.swizzle.ggar;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, -2, -7.5d, -4);
                var v = ov.swizzle.ggag;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(-7, -5, 6.5d, 8);
                var v = ov.swizzle.ggab;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(3.5d, 6, 1.0, -3.5d);
                var v = ov.swizzle.ggaa;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, 4, 7.5d, 6.5d);
                var v = ov.swizzle.gb;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(7.5d, v.y);
            }
            {
                var ov = new dvec4(-4.5d, -4, 4, -2);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-4.5d, v.z);
            }
            {
                var ov = new dvec4(-1, -7.5d, -4, 4.5d);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(8, -3.5d, 9, -4);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(-1.5d, 1.0, -2, 2.5d);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(-0.5d, -8.5d, 6, -3);
                var v = ov.swizzle.gbra;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(-9, -8.5d, -9.5d, 3);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
            }
            {
                var ov = new dvec4(4.5d, 9, -4.5d, -1.5d);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(-7.5d, -5, 5, -5.5d);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(-8, 1.5d, -6.5d, -8.5d);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(-6, 8, -7, -3);
                var v = ov.swizzle.gbga;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(8.5d, -2.5d, 4, 0.5d);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
            }
            {
                var ov = new dvec4(5, -6.5d, -8.5d, 2.5d);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(5.5d, 8, 6.5d, -8);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(7.5d, -5.5d, -7, 4);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(3.5d, 1.0, -7, 0.0);
                var v = ov.swizzle.gbba;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(6.5d, -4.5d, -2, 3.5d);
                var v = ov.swizzle.gba;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(3.5d, v.z);
            }
            {
                var ov = new dvec4(-8.5d, -4.5d, 6.5d, 6.5d);
                var v = ov.swizzle.gbar;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(-8, 0.5d, -7, -8.5d);
                var v = ov.swizzle.gbag;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec4(3, 4.5d, -5, 1.5d);
                var v = ov.swizzle.gbab;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(-6, 0.5d, 7.5d, -2);
                var v = ov.swizzle.gbaa;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 3.5d, 3.5d, -4);
                var v = ov.swizzle.ga;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(-4, v.y);
            }
            {
                var ov = new dvec4(-9, -2.5d, -2.5d, 3.5d);
                var v = ov.swizzle.gar;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var ov = new dvec4(-4, -9, -1.5d, -4);
                var v = ov.swizzle.garr;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(2.5d, -7, -7, -3);
                var v = ov.swizzle.garg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(-5, -2, 9, -9.5d);
                var v = ov.swizzle.garb;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(-2.5d, -5.5d, -4, 4);
                var v = ov.swizzle.gara;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(1.5d, -6, -5, 3);
                var v = ov.swizzle.gag;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var ov = new dvec4(9, -4.5d, -1.5d, 3);
                var v = ov.swizzle.gagr;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var ov = new dvec4(3, 4, -2, 3);
                var v = ov.swizzle.gagg;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(2.5d, 8.5d, -4, 4.5d);
                var v = ov.swizzle.gagb;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(8.5d, 2, -6.5d, 9.5d);
                var v = ov.swizzle.gaga;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(2, 3, -1.5d, -3.5d);
                var v = ov.swizzle.gab;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
            }
            {
                var ov = new dvec4(-8, 2, -7, 3);
                var v = ov.swizzle.gabr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new dvec4(-8.5d, -7, -4.5d, 4);
                var v = ov.swizzle.gabg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(-9, -0.5d, -7.5d, 3);
                var v = ov.swizzle.gabb;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(-2, -6.5d, -6.5d, -1.5d);
                var v = ov.swizzle.gaba;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(0.5d, -4.5d, 9, -2.5d);
                var v = ov.swizzle.gaa;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
            }
            {
                var ov = new dvec4(5, -3, -9.5d, -7);
                var v = ov.swizzle.gaar;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(8.5d, -5, -7.5d, -5.5d);
                var v = ov.swizzle.gaag;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(1.0, -5, 1.0, -1.5d);
                var v = ov.swizzle.gaab;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(-2.5d, -1.5d, -3.5d, 7);
                var v = ov.swizzle.gaaa;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(8, -5.5d, -7.5d, -2.5d);
                var v = ov.swizzle.br;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(8, v.y);
            }
            {
                var ov = new dvec4(-9.5d, 6, -4.5d, 3);
                var v = ov.swizzle.brr;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec4(-6, -1, -7.5d, -5);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var ov = new dvec4(-9.5d, 4.5d, 8, -8);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(3.5d, 1.0, -8.5d, 4);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(-7.5d, 0.0, 5, 5);
                var v = ov.swizzle.brra;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(5.5d, 1.0, 3, 3);
                var v = ov.swizzle.brg;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(1.0, v.z);
            }
            {
                var ov = new dvec4(-2.5d, 4.5d, -6, -5.5d);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(7.5d, -5, -9.5d, 6);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(2, -6.5d, 6, 9.5d);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(-1.5d, -6, 0.0, -2.5d);
                var v = ov.swizzle.brga;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(3.5d, 6, 3, 6);
                var v = ov.swizzle.brb;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var ov = new dvec4(6, -5.5d, 5.5d, -4.5d);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(6, -8.5d, -3.5d, 8);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec4(-8, -7, 1.5d, -8);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(2, -8.5d, -7, -7.5d);
                var v = ov.swizzle.brba;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, 8.5d, -8, 4);
                var v = ov.swizzle.bra;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(4, v.z);
            }
            {
                var ov = new dvec4(-5, 2, -6, 9);
                var v = ov.swizzle.brar;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(4.5d, -7.5d, -6, 5);
                var v = ov.swizzle.brag;
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, -9, -3, -1.5d);
                var v = ov.swizzle.brab;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(7.5d, 6.5d, 7.5d, 3);
                var v = ov.swizzle.braa;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(9.5d, 0.5d, -7, -6);
                var v = ov.swizzle.bg;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(0.5d, v.y);
            }
            {
                var ov = new dvec4(-0.5d, -1, -1.5d, -4.5d);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-0.5d, v.z);
            }
            {
                var ov = new dvec4(2.5d, -0.5d, 6.5d, 7);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, -9, 2.5d, 4.5d);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 9.5d, 2.5d, 4);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(7, -4.5d, 1.5d, -4.5d);
                var v = ov.swizzle.bgra;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(5, -9.5d, 9, 9.5d);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec4(4, 2, -8.5d, 5);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(-6.5d, -4, -7.5d, 3);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(-7.5d, 1.0, -5, 4);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(-4, 0.5d, -8, 5);
                var v = ov.swizzle.bgga;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(-4.5d, 8, 6, -9.5d);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new dvec4(-3.5d, -8, 9.5d, 8.5d);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(4, 3.5d, 5.5d, -4);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, 1.5d, -1, 9);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(1.0, -1.5d, -8.5d, -0.5d);
                var v = ov.swizzle.bgba;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(7, 0.5d, -5.5d, -3.5d);
                var v = ov.swizzle.bga;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec4(6.5d, -0.5d, -3, -1.5d);
                var v = ov.swizzle.bgar;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -1.5d, 0.5d, -8);
                var v = ov.swizzle.bgag;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(7, -4.5d, 9.5d, 7.5d);
                var v = ov.swizzle.bgab;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec4(-4, -0.5d, -4, -2.5d);
                var v = ov.swizzle.bgaa;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(3, -7.5d, 1.0, 0.5d);
                var v = ov.swizzle.bb;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
            }
            {
                var ov = new dvec4(-8, 8, 3, 0.5d);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var ov = new dvec4(1.5d, 5, 2, -3.5d);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(8, -0.5d, 7.5d, 5.5d);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -9.5d, -6.5d, 7.5d);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec4(4, -2, -4, -7);
                var v = ov.swizzle.bbra;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(3, -7, 6, -5);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var ov = new dvec4(1.5d, -3, 6.5d, -2);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(-5, 4.5d, -4.5d, -4.5d);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 4.5d, 7, -1.5d);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-4.5d, -6.5d, 6.5d, -9);
                var v = ov.swizzle.bbga;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(-4.5d, 4, 9, -8);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new dvec4(-2.5d, 4, -3, 3.5d);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(6, -7, -7.5d, 2.5d);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var ov = new dvec4(8, -5.5d, -2.5d, 1.0);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(1.0, -0.5d, 8.5d, -8);
                var v = ov.swizzle.bbba;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new dvec4(9, 1.5d, -1, -4);
                var v = ov.swizzle.bba;
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var ov = new dvec4(3, -2, 5, 0.5d);
                var v = ov.swizzle.bbar;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(-2, 5.5d, -2, -8.5d);
                var v = ov.swizzle.bbag;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(-5, 5.5d, 2.5d, 9.5d);
                var v = ov.swizzle.bbab;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(7, -1.5d, -2.5d, -3.5d);
                var v = ov.swizzle.bbaa;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(0.0, 2, 5, 8.5d);
                var v = ov.swizzle.ba;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(8.5d, v.y);
            }
            {
                var ov = new dvec4(-2, 3.5d, -7, 4);
                var v = ov.swizzle.bar;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var ov = new dvec4(7, 6, -3.5d, 5.5d);
                var v = ov.swizzle.barr;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -9, 9, 3.5d);
                var v = ov.swizzle.barg;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(3.5d, 5.5d, -5, -6);
                var v = ov.swizzle.barb;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(9.5d, -6.5d, -8.5d, -1);
                var v = ov.swizzle.bara;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(4, 1.0, -7, -3);
                var v = ov.swizzle.bag;
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(1.0, v.z);
            }
            {
                var ov = new dvec4(2.5d, -1.5d, 4.5d, -4);
                var v = ov.swizzle.bagr;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(2, -2, -8, 6);
                var v = ov.swizzle.bagg;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(-4.5d, -3, 1.0, 9);
                var v = ov.swizzle.bagb;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(5.5d, 1.0, -7.5d, 5);
                var v = ov.swizzle.baga;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(8, -7, 6.5d, 6.5d);
                var v = ov.swizzle.bab;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
            }
            {
                var ov = new dvec4(-3.5d, 8.5d, 5, -2);
                var v = ov.swizzle.babr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(-4, -1, -2.5d, -7);
                var v = ov.swizzle.babg;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var ov = new dvec4(-7.5d, 4.5d, 3.5d, -1);
                var v = ov.swizzle.babb;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(-6, 3, -3, -9.5d);
                var v = ov.swizzle.baba;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(-2, -3, 2.5d, -2);
                var v = ov.swizzle.baa;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
            }
            {
                var ov = new dvec4(1.0, 2, 8, -8.5d);
                var v = ov.swizzle.baar;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(3.5d, 4, -9.5d, 7.5d);
                var v = ov.swizzle.baag;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(0.0, -5, 2, -1.5d);
                var v = ov.swizzle.baab;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new dvec4(4, -8.5d, -2.5d, 3.5d);
                var v = ov.swizzle.baaa;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(-7.5d, -7.5d, 0.0, 1.5d);
                var v = ov.swizzle.ar;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
            }
            {
                var ov = new dvec4(-4.5d, 0.0, -4.5d, 1.5d);
                var v = ov.swizzle.arr;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
            }
            {
                var ov = new dvec4(-9, 1.5d, 3.5d, 1.5d);
                var v = ov.swizzle.arrr;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(-1.5d, 2, 3.5d, 5.5d);
                var v = ov.swizzle.arrg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -5.5d, 4.5d, -6.5d);
                var v = ov.swizzle.arrb;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(0.5d, -5.5d, -8, 8);
                var v = ov.swizzle.arra;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var ov = new dvec4(1.5d, -0.5d, -6, 6);
                var v = ov.swizzle.arg;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
            }
            {
                var ov = new dvec4(1.5d, 5, 6, 5.5d);
                var v = ov.swizzle.argr;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(-7, -9, 7.5d, 0.5d);
                var v = ov.swizzle.argg;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(-3, 0.0, -2.5d, 0.0);
                var v = ov.swizzle.argb;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(-8, -7, 2, 2);
                var v = ov.swizzle.arga;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var ov = new dvec4(-2, -0.5d, 9, 8.5d);
                var v = ov.swizzle.arb;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var ov = new dvec4(-7.5d, 7, 3, -9.5d);
                var v = ov.swizzle.arbr;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(-2.5d, 3, 3, 8.5d);
                var v = ov.swizzle.arbg;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(3, 2.5d, 0.0, 5.5d);
                var v = ov.swizzle.arbb;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(-4.5d, -9, 9.5d, -3);
                var v = ov.swizzle.arba;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(-5.5d, 8.5d, -5, 8);
                var v = ov.swizzle.ara;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var ov = new dvec4(4, 3, -6.5d, -6.5d);
                var v = ov.swizzle.arar;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(7.5d, 4.5d, 5, -3);
                var v = ov.swizzle.arag;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(-7.5d, -6, 6.5d, 1.0);
                var v = ov.swizzle.arab;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(-9.5d, -8, -5.5d, -5.5d);
                var v = ov.swizzle.araa;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec4(2, -2.5d, 8, -3);
                var v = ov.swizzle.ag;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-2.5d, v.y);
            }
            {
                var ov = new dvec4(-6, 9.5d, -3.5d, -8.5d);
                var v = ov.swizzle.agr;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var ov = new dvec4(0.0, 2.5d, -6, 8.5d);
                var v = ov.swizzle.agrr;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(-8, -0.5d, -8, -3);
                var v = ov.swizzle.agrg;
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(-4, 0.0, 3.5d, -8);
                var v = ov.swizzle.agrb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, -9.5d, -6.5d, 3.5d);
                var v = ov.swizzle.agra;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(8.5d, 0.5d, -6, -1.5d);
                var v = ov.swizzle.agg;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
            }
            {
                var ov = new dvec4(5.5d, 8.5d, -5, 6);
                var v = ov.swizzle.aggr;
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, -5, -1, 7.5d);
                var v = ov.swizzle.aggg;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(0.5d, 1.0, 3.5d, 5);
                var v = ov.swizzle.aggb;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec4(-8, 1.0, -6.5d, 4);
                var v = ov.swizzle.agga;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var ov = new dvec4(-8, 6, 5.5d, 2.5d);
                var v = ov.swizzle.agb;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(5.5d, v.z);
            }
            {
                var ov = new dvec4(8.5d, -6.5d, -1.5d, -9.5d);
                var v = ov.swizzle.agbr;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(-5.5d, 6, 9.5d, -7.5d);
                var v = ov.swizzle.agbg;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(6, v.w);
            }
            {
                var ov = new dvec4(3, -6, -5, -3.5d);
                var v = ov.swizzle.agbb;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(-6.5d, 7.5d, -4.5d, 1.0);
                var v = ov.swizzle.agba;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec4(-8, 8, 4, 2);
                var v = ov.swizzle.aga;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new dvec4(-9, -9.5d, -6.5d, -2);
                var v = ov.swizzle.agar;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(6, -1.5d, 0.0, -6.5d);
                var v = ov.swizzle.agag;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(6.5d, -9, -5, 1.5d);
                var v = ov.swizzle.agab;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(-5, v.w);
            }
            {
                var ov = new dvec4(4.5d, -5.5d, -0.5d, -2);
                var v = ov.swizzle.agaa;
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(-1, 5.5d, -6.5d, -1.5d);
                var v = ov.swizzle.ab;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
            }
            {
                var ov = new dvec4(-6, -1.5d, 4.5d, -5);
                var v = ov.swizzle.abr;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var ov = new dvec4(-2.5d, 6, -7.5d, -9.5d);
                var v = ov.swizzle.abrr;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec4(-6, -7.5d, -2.5d, 8);
                var v = ov.swizzle.abrg;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(2, 3.5d, -3, -8);
                var v = ov.swizzle.abrb;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var ov = new dvec4(0.0, -6, -3, 6.5d);
                var v = ov.swizzle.abra;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(6, -7, -3.5d, -4.5d);
                var v = ov.swizzle.abg;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var ov = new dvec4(0.0, -5.5d, 1.5d, 9.5d);
                var v = ov.swizzle.abgr;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(7, -4, 0.5d, -7.5d);
                var v = ov.swizzle.abgg;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(-3.5d, -6, -3.5d, 1.5d);
                var v = ov.swizzle.abgb;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec4(-3.5d, 8, -4.5d, 0.0);
                var v = ov.swizzle.abga;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(5, -9.5d, 6, -4);
                var v = ov.swizzle.abb;
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(6, v.z);
            }
            {
                var ov = new dvec4(2.5d, 6, -1.5d, 0.0);
                var v = ov.swizzle.abbr;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(-1, -2, -2, 5.5d);
                var v = ov.swizzle.abbg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-2, v.z);
                Assert.AreEqual(-2, v.w);
            }
            {
                var ov = new dvec4(-6.5d, -3.5d, -7.5d, 8.5d);
                var v = ov.swizzle.abbb;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(2, 8, -4, 3);
                var v = ov.swizzle.abba;
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var ov = new dvec4(-5, -6.5d, -2, 2);
                var v = ov.swizzle.aba;
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new dvec4(2.5d, 4, -6.5d, -2.5d);
                var v = ov.swizzle.abar;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec4(6, -7.5d, 2.5d, 1.5d);
                var v = ov.swizzle.abag;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(0.5d, -3, 1.5d, -3.5d);
                var v = ov.swizzle.abab;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec4(-1, -2, 3.5d, 4.5d);
                var v = ov.swizzle.abaa;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(5.5d, 1.5d, -1.5d, 6.5d);
                var v = ov.swizzle.aa;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
            }
            {
                var ov = new dvec4(2, 5.5d, 9.5d, 9.5d);
                var v = ov.swizzle.aar;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var ov = new dvec4(4.5d, -1.5d, -1.5d, -8);
                var v = ov.swizzle.aarr;
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, -7.5d, -4.5d, -6.5d);
                var v = ov.swizzle.aarg;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(8, 4, -7.5d, -2.5d);
                var v = ov.swizzle.aarb;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec4(-6.5d, 1.0, 4.5d, -0.5d);
                var v = ov.swizzle.aara;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec4(-9, -9.5d, 4, 9);
                var v = ov.swizzle.aag;
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec4(5.5d, 5.5d, -1.5d, 1.5d);
                var v = ov.swizzle.aagr;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec4(-5, -9.5d, 7, -5.5d);
                var v = ov.swizzle.aagg;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec4(4.5d, -5, 0.0, 7.5d);
                var v = ov.swizzle.aagb;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec4(4, -6.5d, 2.5d, -9);
                var v = ov.swizzle.aaga;
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-9, v.w);
            }
            {
                var ov = new dvec4(3.5d, -5, 7.5d, 8);
                var v = ov.swizzle.aab;
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(7.5d, v.z);
            }
            {
                var ov = new dvec4(-1.5d, 7, -8, 5);
                var v = ov.swizzle.aabr;
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec4(-0.5d, 5, -1, 4.5d);
                var v = ov.swizzle.aabg;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(5, v.w);
            }
            {
                var ov = new dvec4(6.5d, 8.5d, -8, -7.5d);
                var v = ov.swizzle.aabb;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var ov = new dvec4(0.5d, 0.5d, 4, 8.5d);
                var v = ov.swizzle.aaba;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec4(9.5d, 7.5d, 2, -5);
                var v = ov.swizzle.aaa;
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var ov = new dvec4(-4, 0.0, -1.5d, 3.5d);
                var v = ov.swizzle.aaar;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var ov = new dvec4(3, -4.5d, -6.5d, 0.0);
                var v = ov.swizzle.aaag;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec4(8, -5, 6.5d, 4);
                var v = ov.swizzle.aaab;
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec4(-7.5d, 5.5d, -7.5d, -2.5d);
                var v = ov.swizzle.aaaa;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
        }

    }
}
