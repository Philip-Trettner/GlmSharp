using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Swizzle
{
    [TestFixture]
    public class ComplexSwizzleVec3Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new cvec3(new Complex(-1, -7), new Complex(-3.5d, 8), new Complex(-5.5d, -2.5d));
                var v = ov.swizzle.xx;
                Assert.AreEqual(new Complex(-1, -7), v.x);
                Assert.AreEqual(new Complex(-1, -7), v.y);
            }
            {
                var ov = new cvec3(new Complex(-2, -6), new Complex(-3, -9.5d), new Complex(-7.5d, -4.5d));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new Complex(-2, -6), v.x);
                Assert.AreEqual(new Complex(-2, -6), v.y);
                Assert.AreEqual(new Complex(-2, -6), v.z);
            }
            {
                var ov = new cvec3(new Complex(4, -3), new Complex(-8.5d, -9.5d), new Complex(-3, -4.5d));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new Complex(4, -3), v.x);
                Assert.AreEqual(new Complex(4, -3), v.y);
                Assert.AreEqual(new Complex(4, -3), v.z);
                Assert.AreEqual(new Complex(4, -3), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 4.5d), new Complex(-7.5d, 2), new Complex(-5.5d, -4.5d));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(new Complex(-3.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 2), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5, -4), new Complex(-1.5d, -8), new Complex(-3.5d, -6));
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(new Complex(-5, -4), v.x);
                Assert.AreEqual(new Complex(-5, -4), v.y);
                Assert.AreEqual(new Complex(-5, -4), v.z);
                Assert.AreEqual(new Complex(-3.5d, -6), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -8), new Complex(-6.5d, 3), new Complex(5, 7.5d));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new Complex(-8.5d, -8), v.x);
                Assert.AreEqual(new Complex(-8.5d, -8), v.y);
                Assert.AreEqual(new Complex(-6.5d, 3), v.z);
            }
            {
                var ov = new cvec3(new Complex(-1, -0.5d), new Complex(6.5d, 6), new Complex(-7, -1));
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(new Complex(-1, -0.5d), v.x);
                Assert.AreEqual(new Complex(-1, -0.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 6), v.z);
                Assert.AreEqual(new Complex(-1, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, -8.5d), new Complex(6.5d, -1.5d), new Complex(-3, 5.5d));
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -3), new Complex(-8.5d, 5), new Complex(-3.5d, -7));
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(new Complex(-1.5d, -3), v.x);
                Assert.AreEqual(new Complex(-1.5d, -3), v.y);
                Assert.AreEqual(new Complex(-8.5d, 5), v.z);
                Assert.AreEqual(new Complex(-3.5d, -7), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9, -5), new Complex(7.5d, -7.5d), new Complex(5, -5));
                var v = ov.swizzle.xxz;
                Assert.AreEqual(new Complex(-9, -5), v.x);
                Assert.AreEqual(new Complex(-9, -5), v.y);
                Assert.AreEqual(new Complex(5, -5), v.z);
            }
            {
                var ov = new cvec3(new Complex(-4, 7.5d), new Complex(-5.5d, 8), new Complex(-5, 7));
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(new Complex(-4, 7.5d), v.x);
                Assert.AreEqual(new Complex(-4, 7.5d), v.y);
                Assert.AreEqual(new Complex(-5, 7), v.z);
                Assert.AreEqual(new Complex(-4, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, -5.5d), new Complex(-7, 8.5d), new Complex(5.5d, 7.5d));
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(new Complex(-5.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-7, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7, 4.5d), new Complex(9, 1.0), new Complex(4.5d, 4.5d));
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(new Complex(-7, 4.5d), v.x);
                Assert.AreEqual(new Complex(-7, 4.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3, -2.5d), new Complex(-7, 8.5d), new Complex(8, 4.5d));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new Complex(-3, -2.5d), v.x);
                Assert.AreEqual(new Complex(-7, 8.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -6), new Complex(4.5d, 8), new Complex(-4.5d, 8));
                var v = ov.swizzle.xyx;
                Assert.AreEqual(new Complex(2.5d, -6), v.x);
                Assert.AreEqual(new Complex(4.5d, 8), v.y);
                Assert.AreEqual(new Complex(2.5d, -6), v.z);
            }
            {
                var ov = new cvec3(new Complex(-8, -7.5d), new Complex(7.5d, 8.5d), new Complex(-3, 3.5d));
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(new Complex(-8, -7.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-8, -7.5d), v.z);
                Assert.AreEqual(new Complex(-8, -7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -6), new Complex(5, -9.5d), new Complex(7.5d, -3.5d));
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new Complex(6.5d, -6), v.x);
                Assert.AreEqual(new Complex(5, -9.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -6), v.z);
                Assert.AreEqual(new Complex(5, -9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.0, -4), new Complex(8, 3), new Complex(3.5d, 9));
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(new Complex(0.0, -4), v.x);
                Assert.AreEqual(new Complex(8, 3), v.y);
                Assert.AreEqual(new Complex(0.0, -4), v.z);
                Assert.AreEqual(new Complex(3.5d, 9), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8, 3), new Complex(-3.5d, 5.5d), new Complex(-0.5d, -9.5d));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new Complex(-8, 3), v.x);
                Assert.AreEqual(new Complex(-3.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 5.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-1, 0.5d), new Complex(-5.5d, 3), new Complex(2.5d, -5));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new Complex(-1, 0.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 3), v.y);
                Assert.AreEqual(new Complex(-5.5d, 3), v.z);
                Assert.AreEqual(new Complex(-1, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 7), new Complex(-4.5d, 8.5d), new Complex(-6.5d, 8.5d));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new Complex(6.5d, 7), v.x);
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7, 8), new Complex(-2, 4.5d), new Complex(7.5d, 4.5d));
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(new Complex(7, 8), v.x);
                Assert.AreEqual(new Complex(-2, 4.5d), v.y);
                Assert.AreEqual(new Complex(-2, 4.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(9, -5), new Complex(0.5d, 0.5d), new Complex(-1, -8));
                var v = ov.swizzle.xyz;
                Assert.AreEqual(new Complex(9, -5), v.x);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-1, -8), v.z);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -9), new Complex(3, -7.5d), new Complex(-4, 0.0));
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(new Complex(0.5d, -9), v.x);
                Assert.AreEqual(new Complex(3, -7.5d), v.y);
                Assert.AreEqual(new Complex(-4, 0.0), v.z);
                Assert.AreEqual(new Complex(0.5d, -9), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2, 3), new Complex(8.5d, 2), new Complex(-9, 6));
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(new Complex(-2, 3), v.x);
                Assert.AreEqual(new Complex(8.5d, 2), v.y);
                Assert.AreEqual(new Complex(-9, 6), v.z);
                Assert.AreEqual(new Complex(8.5d, 2), v.w);
            }
            {
                var ov = new cvec3(new Complex(7, -5), new Complex(2.5d, 5), new Complex(2, -8));
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(new Complex(7, -5), v.x);
                Assert.AreEqual(new Complex(2.5d, 5), v.y);
                Assert.AreEqual(new Complex(2, -8), v.z);
                Assert.AreEqual(new Complex(2, -8), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -3.5d), new Complex(9, -1.5d), new Complex(-6.5d, 7));
                var v = ov.swizzle.xz;
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 7), v.y);
            }
            {
                var ov = new cvec3(new Complex(-3, -7.5d), new Complex(-7.5d, 9.5d), new Complex(1.5d, 9.5d));
                var v = ov.swizzle.xzx;
                Assert.AreEqual(new Complex(-3, -7.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-3, -7.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(7, -0.5d), new Complex(-4, -8.5d), new Complex(-6, 3));
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(new Complex(7, -0.5d), v.x);
                Assert.AreEqual(new Complex(-6, 3), v.y);
                Assert.AreEqual(new Complex(7, -0.5d), v.z);
                Assert.AreEqual(new Complex(7, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 8.5d), new Complex(6, -8), new Complex(1.5d, 2));
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 2), v.y);
                Assert.AreEqual(new Complex(-8.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(6, -8), v.w);
            }
            {
                var ov = new cvec3(new Complex(6, -5), new Complex(6, 2), new Complex(-4.5d, 7.5d));
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(new Complex(6, -5), v.x);
                Assert.AreEqual(new Complex(-4.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(6, -5), v.z);
                Assert.AreEqual(new Complex(-4.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(2, -8), new Complex(-7, -9.5d), new Complex(2.5d, 0.0));
                var v = ov.swizzle.xzy;
                Assert.AreEqual(new Complex(2, -8), v.x);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(-7, -9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 5.5d), new Complex(-4.5d, 4), new Complex(-7.5d, -3));
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(new Complex(-4.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -3), v.y);
                Assert.AreEqual(new Complex(-4.5d, 4), v.z);
                Assert.AreEqual(new Complex(-4.5d, 5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -5), new Complex(8, 4), new Complex(7, 5));
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(new Complex(-2.5d, -5), v.x);
                Assert.AreEqual(new Complex(7, 5), v.y);
                Assert.AreEqual(new Complex(8, 4), v.z);
                Assert.AreEqual(new Complex(8, 4), v.w);
            }
            {
                var ov = new cvec3(new Complex(2, -4), new Complex(5, 4.5d), new Complex(1.0, 6.5d));
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(new Complex(2, -4), v.x);
                Assert.AreEqual(new Complex(1.0, 6.5d), v.y);
                Assert.AreEqual(new Complex(5, 4.5d), v.z);
                Assert.AreEqual(new Complex(1.0, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, -6.5d), new Complex(-0.5d, -1), new Complex(-1, 1.0));
                var v = ov.swizzle.xzz;
                Assert.AreEqual(new Complex(-5.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-1, 1.0), v.y);
                Assert.AreEqual(new Complex(-1, 1.0), v.z);
            }
            {
                var ov = new cvec3(new Complex(-5, 0.0), new Complex(9, -2.5d), new Complex(4.5d, 0.5d));
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(new Complex(-5, 0.0), v.x);
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-5, 0.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 0.0), new Complex(-6.5d, 3), new Complex(-4, -3));
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(new Complex(-2.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-4, -3), v.y);
                Assert.AreEqual(new Complex(-4, -3), v.z);
                Assert.AreEqual(new Complex(-6.5d, 3), v.w);
            }
            {
                var ov = new cvec3(new Complex(9, 4), new Complex(-6.5d, -5.5d), new Complex(2, 6.5d));
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(new Complex(9, 4), v.x);
                Assert.AreEqual(new Complex(2, 6.5d), v.y);
                Assert.AreEqual(new Complex(2, 6.5d), v.z);
                Assert.AreEqual(new Complex(2, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 8.5d), new Complex(9.5d, -9.5d), new Complex(8.5d, -3));
                var v = ov.swizzle.yx;
                Assert.AreEqual(new Complex(9.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 8.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -1.5d), new Complex(-1.5d, -7), new Complex(-5.5d, 9));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new Complex(-1.5d, -7), v.x);
                Assert.AreEqual(new Complex(-7.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -1.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -5), new Complex(-5.5d, 1.0), new Complex(7.5d, -9));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(new Complex(-5.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-9.5d, -5), v.y);
                Assert.AreEqual(new Complex(-9.5d, -5), v.z);
                Assert.AreEqual(new Complex(-9.5d, -5), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 2), new Complex(8, -6.5d), new Complex(-8.5d, -9.5d));
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(new Complex(8, -6.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 2), v.y);
                Assert.AreEqual(new Complex(-1.5d, 2), v.z);
                Assert.AreEqual(new Complex(8, -6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 5), new Complex(-7.5d, -9), new Complex(6, 8.5d));
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(new Complex(-7.5d, -9), v.x);
                Assert.AreEqual(new Complex(-2.5d, 5), v.y);
                Assert.AreEqual(new Complex(-2.5d, 5), v.z);
                Assert.AreEqual(new Complex(6, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 4), new Complex(1.0, 8), new Complex(1.0, -7.5d));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new Complex(1.0, 8), v.x);
                Assert.AreEqual(new Complex(-8.5d, 4), v.y);
                Assert.AreEqual(new Complex(1.0, 8), v.z);
            }
            {
                var ov = new cvec3(new Complex(-5, 9.5d), new Complex(-1, 5), new Complex(-7, 2));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new Complex(-1, 5), v.x);
                Assert.AreEqual(new Complex(-5, 9.5d), v.y);
                Assert.AreEqual(new Complex(-1, 5), v.z);
                Assert.AreEqual(new Complex(-5, 9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 1.0), new Complex(-5.5d, 5), new Complex(-4.5d, -1));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new Complex(-5.5d, 5), v.x);
                Assert.AreEqual(new Complex(0.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-5.5d, 5), v.z);
                Assert.AreEqual(new Complex(-5.5d, 5), v.w);
            }
            {
                var ov = new cvec3(new Complex(4, 9.5d), new Complex(6, 5.5d), new Complex(6.5d, 0.5d));
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(new Complex(6, 5.5d), v.x);
                Assert.AreEqual(new Complex(4, 9.5d), v.y);
                Assert.AreEqual(new Complex(6, 5.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -3), new Complex(-9.5d, -5), new Complex(-6.5d, 8.5d));
                var v = ov.swizzle.yxz;
                Assert.AreEqual(new Complex(-9.5d, -5), v.x);
                Assert.AreEqual(new Complex(6.5d, -3), v.y);
                Assert.AreEqual(new Complex(-6.5d, 8.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-2, -6.5d), new Complex(3.5d, -3), new Complex(3.5d, 5.5d));
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(new Complex(3.5d, -3), v.x);
                Assert.AreEqual(new Complex(-2, -6.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-2, -6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, 1.0), new Complex(3.5d, 7.5d), new Complex(-4.5d, -4.5d));
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(new Complex(3.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 9.5d), new Complex(4, -4.5d), new Complex(-9.5d, -2.5d));
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(new Complex(4, -4.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 5.5d), new Complex(-7.5d, 8.5d), new Complex(-7.5d, 3.5d));
                var v = ov.swizzle.yy;
                Assert.AreEqual(new Complex(-7.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 8.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(4, -7), new Complex(6.5d, -8.5d), new Complex(-9.5d, -4.5d));
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(4, -7), v.z);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -8.5d), new Complex(-2.5d, 5.5d), new Complex(-1.5d, 8));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new Complex(-2.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -0.5d), new Complex(5, 3.5d), new Complex(-8.5d, 3.5d));
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(new Complex(5, 3.5d), v.x);
                Assert.AreEqual(new Complex(5, 3.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(5, 3.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2, -0.5d), new Complex(4.5d, 4), new Complex(-3, -6));
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(new Complex(4.5d, 4), v.x);
                Assert.AreEqual(new Complex(4.5d, 4), v.y);
                Assert.AreEqual(new Complex(-2, -0.5d), v.z);
                Assert.AreEqual(new Complex(-3, -6), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 4.5d), new Complex(1.0, 4.5d), new Complex(-6, -3));
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new Complex(1.0, 4.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-4, 0.0), new Complex(-7, -3.5d), new Complex(-8.5d, -9.5d));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new Complex(-7, -3.5d), v.x);
                Assert.AreEqual(new Complex(-7, -3.5d), v.y);
                Assert.AreEqual(new Complex(-7, -3.5d), v.z);
                Assert.AreEqual(new Complex(-4, 0.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -9), new Complex(-5.5d, 2), new Complex(3, -4.5d));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new Complex(-5.5d, 2), v.x);
                Assert.AreEqual(new Complex(-5.5d, 2), v.y);
                Assert.AreEqual(new Complex(-5.5d, 2), v.z);
                Assert.AreEqual(new Complex(-5.5d, 2), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4, -9), new Complex(-6, -8), new Complex(-6, -1));
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(new Complex(-6, -8), v.x);
                Assert.AreEqual(new Complex(-6, -8), v.y);
                Assert.AreEqual(new Complex(-6, -8), v.z);
                Assert.AreEqual(new Complex(-6, -1), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -4.5d), new Complex(8.5d, 3), new Complex(-1.5d, -7.5d));
                var v = ov.swizzle.yyz;
                Assert.AreEqual(new Complex(8.5d, 3), v.x);
                Assert.AreEqual(new Complex(8.5d, 3), v.y);
                Assert.AreEqual(new Complex(-1.5d, -7.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -4), new Complex(7.5d, 5), new Complex(6.5d, -5.5d));
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(new Complex(7.5d, 5), v.x);
                Assert.AreEqual(new Complex(7.5d, 5), v.y);
                Assert.AreEqual(new Complex(6.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -4), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 4.5d), new Complex(2.5d, 3), new Complex(-1.5d, 7));
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(new Complex(2.5d, 3), v.x);
                Assert.AreEqual(new Complex(2.5d, 3), v.y);
                Assert.AreEqual(new Complex(-1.5d, 7), v.z);
                Assert.AreEqual(new Complex(2.5d, 3), v.w);
            }
            {
                var ov = new cvec3(new Complex(4.5d, 8), new Complex(-4.5d, -6.5d), new Complex(-2.5d, -5.5d));
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(new Complex(-4.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(4, -5.5d), new Complex(-6, -9), new Complex(-9, 9.5d));
                var v = ov.swizzle.yz;
                Assert.AreEqual(new Complex(-6, -9), v.x);
                Assert.AreEqual(new Complex(-9, 9.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(8, -9.5d), new Complex(8, -8.5d), new Complex(-4, -9.5d));
                var v = ov.swizzle.yzx;
                Assert.AreEqual(new Complex(8, -8.5d), v.x);
                Assert.AreEqual(new Complex(-4, -9.5d), v.y);
                Assert.AreEqual(new Complex(8, -9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(2, 3), new Complex(9.5d, 3.5d), new Complex(9.5d, 7));
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(new Complex(9.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 7), v.y);
                Assert.AreEqual(new Complex(2, 3), v.z);
                Assert.AreEqual(new Complex(2, 3), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, -7), new Complex(2, 4), new Complex(2.5d, 0.0));
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(new Complex(2, 4), v.x);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(-8.5d, -7), v.z);
                Assert.AreEqual(new Complex(2, 4), v.w);
            }
            {
                var ov = new cvec3(new Complex(9, 9), new Complex(9, 7.5d), new Complex(-2.5d, 8.5d));
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(new Complex(9, 7.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(9, 9), v.z);
                Assert.AreEqual(new Complex(-2.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(9.5d, 7), new Complex(6.5d, -7), new Complex(8.5d, 5.5d));
                var v = ov.swizzle.yzy;
                Assert.AreEqual(new Complex(6.5d, -7), v.x);
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -7), v.z);
            }
            {
                var ov = new cvec3(new Complex(-9, 6), new Complex(0.5d, 7.5d), new Complex(-8.5d, 1.0));
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(new Complex(0.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(0.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-9, 6), v.w);
            }
            {
                var ov = new cvec3(new Complex(4, -3), new Complex(1.0, 4.5d), new Complex(-0.5d, 1.5d));
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(new Complex(1.0, 4.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.z);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(9.5d, -2.5d), new Complex(5, -3), new Complex(8, -1.5d));
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(new Complex(5, -3), v.x);
                Assert.AreEqual(new Complex(8, -1.5d), v.y);
                Assert.AreEqual(new Complex(5, -3), v.z);
                Assert.AreEqual(new Complex(8, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 8), new Complex(0.5d, 4.5d), new Complex(1.0, 8.5d));
                var v = ov.swizzle.yzz;
                Assert.AreEqual(new Complex(0.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 8.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 8.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 8), new Complex(2.5d, -4.5d), new Complex(-7, -2));
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(new Complex(2.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-7, -2), v.y);
                Assert.AreEqual(new Complex(-7, -2), v.z);
                Assert.AreEqual(new Complex(-4.5d, 8), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -1.5d), new Complex(8, -5), new Complex(1.0, 5));
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(new Complex(8, -5), v.x);
                Assert.AreEqual(new Complex(1.0, 5), v.y);
                Assert.AreEqual(new Complex(1.0, 5), v.z);
                Assert.AreEqual(new Complex(8, -5), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.0, -8), new Complex(-8, 7.5d), new Complex(-5, -9.5d));
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(new Complex(-8, 7.5d), v.x);
                Assert.AreEqual(new Complex(-5, -9.5d), v.y);
                Assert.AreEqual(new Complex(-5, -9.5d), v.z);
                Assert.AreEqual(new Complex(-5, -9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 4), new Complex(-2, -3), new Complex(-6, -5.5d));
                var v = ov.swizzle.zx;
                Assert.AreEqual(new Complex(-6, -5.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 4), v.y);
            }
            {
                var ov = new cvec3(new Complex(-7, 2), new Complex(6, 5), new Complex(5.5d, 6.5d));
                var v = ov.swizzle.zxx;
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-7, 2), v.y);
                Assert.AreEqual(new Complex(-7, 2), v.z);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -8.5d), new Complex(-3, 2), new Complex(-2.5d, 5));
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(new Complex(-2.5d, 5), v.x);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8, -5.5d), new Complex(-7.5d, -2.5d), new Complex(5.5d, -2.5d));
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(new Complex(5.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(8, -5.5d), v.y);
                Assert.AreEqual(new Complex(8, -5.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -2), new Complex(-6, 0.0), new Complex(4.5d, -4.5d));
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(new Complex(4.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -2), v.y);
                Assert.AreEqual(new Complex(-0.5d, -2), v.z);
                Assert.AreEqual(new Complex(4.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6, -8.5d), new Complex(0.0, 8), new Complex(-4, -7.5d));
                var v = ov.swizzle.zxy;
                Assert.AreEqual(new Complex(-4, -7.5d), v.x);
                Assert.AreEqual(new Complex(6, -8.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 8), v.z);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 8), new Complex(8, 3.5d), new Complex(3, 5));
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(new Complex(3, 5), v.x);
                Assert.AreEqual(new Complex(0.5d, 8), v.y);
                Assert.AreEqual(new Complex(8, 3.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 8), v.w);
            }
            {
                var ov = new cvec3(new Complex(4, 0.5d), new Complex(-7, 4.5d), new Complex(8, 7.5d));
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(new Complex(8, 7.5d), v.x);
                Assert.AreEqual(new Complex(4, 0.5d), v.y);
                Assert.AreEqual(new Complex(-7, 4.5d), v.z);
                Assert.AreEqual(new Complex(-7, 4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 6), new Complex(6.5d, 8), new Complex(9, -9));
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(new Complex(9, -9), v.x);
                Assert.AreEqual(new Complex(7.5d, 6), v.y);
                Assert.AreEqual(new Complex(6.5d, 8), v.z);
                Assert.AreEqual(new Complex(9, -9), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5, -2.5d), new Complex(-8.5d, -8.5d), new Complex(1.0, -8.5d));
                var v = ov.swizzle.zxz;
                Assert.AreEqual(new Complex(1.0, -8.5d), v.x);
                Assert.AreEqual(new Complex(-5, -2.5d), v.y);
                Assert.AreEqual(new Complex(1.0, -8.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 0.5d), new Complex(7.5d, -2.5d), new Complex(-8, -7));
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(new Complex(-8, -7), v.x);
                Assert.AreEqual(new Complex(-3.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-8, -7), v.z);
                Assert.AreEqual(new Complex(-3.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, -4), new Complex(-0.5d, 1.0), new Complex(-9, -7.5d));
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(new Complex(-9, -7.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -4), v.y);
                Assert.AreEqual(new Complex(-9, -7.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 1.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(4, -6), new Complex(-1.5d, 9), new Complex(5.5d, -0.5d));
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(4, -6), v.y);
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(3.5d, 4.5d), new Complex(3, 3), new Complex(3.5d, -1));
                var v = ov.swizzle.zy;
                Assert.AreEqual(new Complex(3.5d, -1), v.x);
                Assert.AreEqual(new Complex(3, 3), v.y);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -7.5d), new Complex(-6, -6.5d), new Complex(8, 4));
                var v = ov.swizzle.zyx;
                Assert.AreEqual(new Complex(8, 4), v.x);
                Assert.AreEqual(new Complex(-6, -6.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -7.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(6, -2), new Complex(5.5d, 7.5d), new Complex(-7, -6.5d));
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(new Complex(-7, -6.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(6, -2), v.z);
                Assert.AreEqual(new Complex(6, -2), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -2.5d), new Complex(-7.5d, 5), new Complex(8, 3));
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(new Complex(8, 3), v.x);
                Assert.AreEqual(new Complex(-7.5d, 5), v.y);
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 5), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -6.5d), new Complex(-2, 9), new Complex(9, 1.0));
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(new Complex(9, 1.0), v.x);
                Assert.AreEqual(new Complex(-2, 9), v.y);
                Assert.AreEqual(new Complex(-2.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(9, 1.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2, -2), new Complex(-4.5d, -3), new Complex(4.5d, -9));
                var v = ov.swizzle.zyy;
                Assert.AreEqual(new Complex(4.5d, -9), v.x);
                Assert.AreEqual(new Complex(-4.5d, -3), v.y);
                Assert.AreEqual(new Complex(-4.5d, -3), v.z);
            }
            {
                var ov = new cvec3(new Complex(6, -5.5d), new Complex(-9, 5.5d), new Complex(9, 6.5d));
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(new Complex(9, 6.5d), v.x);
                Assert.AreEqual(new Complex(-9, 5.5d), v.y);
                Assert.AreEqual(new Complex(-9, 5.5d), v.z);
                Assert.AreEqual(new Complex(6, -5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -6), new Complex(-8.5d, 2.5d), new Complex(1.5d, -8.5d));
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(new Complex(1.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -6.5d), new Complex(-7.5d, 3.5d), new Complex(-5.5d, 9.5d));
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8, 7), new Complex(4, 5.5d), new Complex(-3.5d, 9.5d));
                var v = ov.swizzle.zyz;
                Assert.AreEqual(new Complex(-3.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(4, 5.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-6, 0.0), new Complex(2, 3), new Complex(-2, 8.5d));
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(new Complex(-2, 8.5d), v.x);
                Assert.AreEqual(new Complex(2, 3), v.y);
                Assert.AreEqual(new Complex(-2, 8.5d), v.z);
                Assert.AreEqual(new Complex(-6, 0.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8, 3.5d), new Complex(6.5d, -4), new Complex(5, -2.5d));
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(new Complex(5, -2.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -4), v.y);
                Assert.AreEqual(new Complex(5, -2.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -4), v.w);
            }
            {
                var ov = new cvec3(new Complex(9, 5.5d), new Complex(-6.5d, 8), new Complex(1.0, 8));
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(new Complex(1.0, 8), v.x);
                Assert.AreEqual(new Complex(-6.5d, 8), v.y);
                Assert.AreEqual(new Complex(1.0, 8), v.z);
                Assert.AreEqual(new Complex(1.0, 8), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.0, 0.5d), new Complex(0.5d, 3.5d), new Complex(0.0, 9));
                var v = ov.swizzle.zz;
                Assert.AreEqual(new Complex(0.0, 9), v.x);
                Assert.AreEqual(new Complex(0.0, 9), v.y);
            }
            {
                var ov = new cvec3(new Complex(2.5d, 6.5d), new Complex(2.5d, 9.5d), new Complex(9.5d, -5));
                var v = ov.swizzle.zzx;
                Assert.AreEqual(new Complex(9.5d, -5), v.x);
                Assert.AreEqual(new Complex(9.5d, -5), v.y);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(3.5d, -7), new Complex(9.5d, 7), new Complex(-3.5d, -6));
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(new Complex(-3.5d, -6), v.x);
                Assert.AreEqual(new Complex(-3.5d, -6), v.y);
                Assert.AreEqual(new Complex(3.5d, -7), v.z);
                Assert.AreEqual(new Complex(3.5d, -7), v.w);
            }
            {
                var ov = new cvec3(new Complex(8, -4), new Complex(-3, 0.0), new Complex(3, -3.5d));
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(new Complex(3, -3.5d), v.x);
                Assert.AreEqual(new Complex(3, -3.5d), v.y);
                Assert.AreEqual(new Complex(8, -4), v.z);
                Assert.AreEqual(new Complex(-3, 0.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 3), new Complex(7.5d, 1.5d), new Complex(8, -3));
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(new Complex(8, -3), v.x);
                Assert.AreEqual(new Complex(8, -3), v.y);
                Assert.AreEqual(new Complex(-4.5d, 3), v.z);
                Assert.AreEqual(new Complex(8, -3), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 0.5d), new Complex(7, -7), new Complex(-7.5d, -2));
                var v = ov.swizzle.zzy;
                Assert.AreEqual(new Complex(-7.5d, -2), v.x);
                Assert.AreEqual(new Complex(-7.5d, -2), v.y);
                Assert.AreEqual(new Complex(7, -7), v.z);
            }
            {
                var ov = new cvec3(new Complex(1.0, -1.5d), new Complex(6.5d, 8.5d), new Complex(3.5d, 0.5d));
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(new Complex(3.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(1.0, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 5), new Complex(-0.5d, 3), new Complex(0.5d, 9.5d));
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(new Complex(0.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 3), v.z);
                Assert.AreEqual(new Complex(-0.5d, 3), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, -6.5d), new Complex(6, -5.5d), new Complex(-9.5d, 0.0));
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(new Complex(-9.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-9.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(6, -5.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 0.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 4), new Complex(8, -2.5d), new Complex(-5, 6.5d));
                var v = ov.swizzle.zzz;
                Assert.AreEqual(new Complex(-5, 6.5d), v.x);
                Assert.AreEqual(new Complex(-5, 6.5d), v.y);
                Assert.AreEqual(new Complex(-5, 6.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(3, -2), new Complex(1.0, -5), new Complex(2, 2));
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(new Complex(2, 2), v.x);
                Assert.AreEqual(new Complex(2, 2), v.y);
                Assert.AreEqual(new Complex(2, 2), v.z);
                Assert.AreEqual(new Complex(3, -2), v.w);
            }
            {
                var ov = new cvec3(new Complex(3.5d, 7), new Complex(5, 2.5d), new Complex(-0.5d, 1.0));
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(new Complex(-0.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-0.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-0.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(5, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(9, -4.5d), new Complex(3.5d, -9), new Complex(-1.5d, 2.5d));
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new cvec3(new Complex(5.5d, 6), new Complex(-5, 7.5d), new Complex(-2, 4.5d));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new Complex(5.5d, 6), v.x);
                Assert.AreEqual(new Complex(5.5d, 6), v.y);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 2.5d), new Complex(8.5d, -2), new Complex(8, -2));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new Complex(6.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 2.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 4), new Complex(-2, 4.5d), new Complex(2, -2));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(new Complex(-2.5d, 4), v.x);
                Assert.AreEqual(new Complex(-2.5d, 4), v.y);
                Assert.AreEqual(new Complex(-2.5d, 4), v.z);
                Assert.AreEqual(new Complex(-2.5d, 4), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1, 6), new Complex(5.5d, 6), new Complex(-8.5d, 1.0));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new Complex(-1, 6), v.x);
                Assert.AreEqual(new Complex(-1, 6), v.y);
                Assert.AreEqual(new Complex(-1, 6), v.z);
                Assert.AreEqual(new Complex(5.5d, 6), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3, 4), new Complex(0.5d, -8.5d), new Complex(9.5d, 1.5d));
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(new Complex(-3, 4), v.x);
                Assert.AreEqual(new Complex(-3, 4), v.y);
                Assert.AreEqual(new Complex(-3, 4), v.z);
                Assert.AreEqual(new Complex(9.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -6), new Complex(0.0, -8), new Complex(6, -7));
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new Complex(2.5d, -6), v.x);
                Assert.AreEqual(new Complex(2.5d, -6), v.y);
                Assert.AreEqual(new Complex(0.0, -8), v.z);
            }
            {
                var ov = new cvec3(new Complex(4, 7), new Complex(5, 0.0), new Complex(6, -8.5d));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new Complex(4, 7), v.x);
                Assert.AreEqual(new Complex(4, 7), v.y);
                Assert.AreEqual(new Complex(5, 0.0), v.z);
                Assert.AreEqual(new Complex(4, 7), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 5), new Complex(-6, -5), new Complex(-0.5d, 3));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new Complex(0.5d, 5), v.x);
                Assert.AreEqual(new Complex(0.5d, 5), v.y);
                Assert.AreEqual(new Complex(-6, -5), v.z);
                Assert.AreEqual(new Complex(-6, -5), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2, 0.5d), new Complex(-5, 4.5d), new Complex(3, 2));
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(new Complex(-2, 0.5d), v.x);
                Assert.AreEqual(new Complex(-2, 0.5d), v.y);
                Assert.AreEqual(new Complex(-5, 4.5d), v.z);
                Assert.AreEqual(new Complex(3, 2), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2, -7.5d), new Complex(7.5d, 8), new Complex(-2.5d, -6));
                var v = ov.swizzle.rrb;
                Assert.AreEqual(new Complex(-2, -7.5d), v.x);
                Assert.AreEqual(new Complex(-2, -7.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -6), v.z);
            }
            {
                var ov = new cvec3(new Complex(1.5d, 5.5d), new Complex(7.5d, -5.5d), new Complex(-6, -0.5d));
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(new Complex(1.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-6, -0.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, 5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2, 9.5d), new Complex(-1, -9.5d), new Complex(-0.5d, -7.5d));
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(new Complex(-2, 9.5d), v.x);
                Assert.AreEqual(new Complex(-2, 9.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-1, -9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.0, 9), new Complex(-7, -7), new Complex(-5.5d, 7.5d));
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(new Complex(0.0, 9), v.x);
                Assert.AreEqual(new Complex(0.0, 9), v.y);
                Assert.AreEqual(new Complex(-5.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8, -5.5d), new Complex(-8, 4.5d), new Complex(-2, 9));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new Complex(8, -5.5d), v.x);
                Assert.AreEqual(new Complex(-8, 4.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 0.0), new Complex(3, 6), new Complex(-8, -7.5d));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new Complex(8.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(3, 6), v.y);
                Assert.AreEqual(new Complex(8.5d, 0.0), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7, 0.5d), new Complex(9.5d, 7.5d), new Complex(1.5d, -8.5d));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new Complex(-7, 0.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-7, 0.5d), v.z);
                Assert.AreEqual(new Complex(-7, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -5), new Complex(7, 4), new Complex(7, -7));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new Complex(-3.5d, -5), v.x);
                Assert.AreEqual(new Complex(7, 4), v.y);
                Assert.AreEqual(new Complex(-3.5d, -5), v.z);
                Assert.AreEqual(new Complex(7, 4), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -1), new Complex(-5, 8), new Complex(0.5d, 8.5d));
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(new Complex(-2.5d, -1), v.x);
                Assert.AreEqual(new Complex(-5, 8), v.y);
                Assert.AreEqual(new Complex(-2.5d, -1), v.z);
                Assert.AreEqual(new Complex(0.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4, 2), new Complex(4, 8.5d), new Complex(9.5d, -7.5d));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new Complex(-4, 2), v.x);
                Assert.AreEqual(new Complex(4, 8.5d), v.y);
                Assert.AreEqual(new Complex(4, 8.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 1.5d), new Complex(-4.5d, 0.0), new Complex(-6.5d, -6));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(-4.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5, 6), new Complex(-5, -8.5d), new Complex(-5, -4.5d));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new Complex(5, 6), v.x);
                Assert.AreEqual(new Complex(-5, -8.5d), v.y);
                Assert.AreEqual(new Complex(-5, -8.5d), v.z);
                Assert.AreEqual(new Complex(-5, -8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5, 5.5d), new Complex(-9, -2), new Complex(7.5d, -7.5d));
                var v = ov.swizzle.rggb;
                Assert.AreEqual(new Complex(-5, 5.5d), v.x);
                Assert.AreEqual(new Complex(-9, -2), v.y);
                Assert.AreEqual(new Complex(-9, -2), v.z);
                Assert.AreEqual(new Complex(7.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(4, 9), new Complex(0.0, 2), new Complex(-9, 9.5d));
                var v = ov.swizzle.rgb;
                Assert.AreEqual(new Complex(4, 9), v.x);
                Assert.AreEqual(new Complex(0.0, 2), v.y);
                Assert.AreEqual(new Complex(-9, 9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-1, 6), new Complex(2.5d, 3), new Complex(-5.5d, 0.0));
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(new Complex(-1, 6), v.x);
                Assert.AreEqual(new Complex(2.5d, 3), v.y);
                Assert.AreEqual(new Complex(-5.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(-1, 6), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -9), new Complex(5.5d, -6.5d), new Complex(-2.5d, 6));
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(new Complex(-7.5d, -9), v.x);
                Assert.AreEqual(new Complex(5.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 6), v.z);
                Assert.AreEqual(new Complex(5.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(5.5d, -1), new Complex(2.5d, 5), new Complex(-3, 5));
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(new Complex(5.5d, -1), v.x);
                Assert.AreEqual(new Complex(2.5d, 5), v.y);
                Assert.AreEqual(new Complex(-3, 5), v.z);
                Assert.AreEqual(new Complex(-3, 5), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1, -9.5d), new Complex(4.5d, 9.5d), new Complex(-5, 7.5d));
                var v = ov.swizzle.rb;
                Assert.AreEqual(new Complex(-1, -9.5d), v.x);
                Assert.AreEqual(new Complex(-5, 7.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(-2, -8.5d), new Complex(-3.5d, 7), new Complex(0.5d, 2));
                var v = ov.swizzle.rbr;
                Assert.AreEqual(new Complex(-2, -8.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 2), v.y);
                Assert.AreEqual(new Complex(-2, -8.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-9, 6.5d), new Complex(4, -6.5d), new Complex(-6.5d, -4));
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(new Complex(-9, 6.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -4), v.y);
                Assert.AreEqual(new Complex(-9, 6.5d), v.z);
                Assert.AreEqual(new Complex(-9, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 1.5d), new Complex(8.5d, 7.5d), new Complex(5, -9));
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(new Complex(-4.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(5, -9), v.y);
                Assert.AreEqual(new Complex(-4.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.5d, 0.0), new Complex(-7, -9), new Complex(2.5d, -7));
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(new Complex(0.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(2.5d, -7), v.y);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(2.5d, -7), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.0, -9.5d), new Complex(3, -6), new Complex(3, -2));
                var v = ov.swizzle.rbg;
                Assert.AreEqual(new Complex(1.0, -9.5d), v.x);
                Assert.AreEqual(new Complex(3, -2), v.y);
                Assert.AreEqual(new Complex(3, -6), v.z);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -4.5d), new Complex(-6.5d, 2), new Complex(-5.5d, 5.5d));
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(new Complex(6.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 2), v.z);
                Assert.AreEqual(new Complex(6.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, 9.5d), new Complex(-3, -8), new Complex(9.5d, 2.5d));
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-3, -8), v.z);
                Assert.AreEqual(new Complex(-3, -8), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2, -9.5d), new Complex(-6, 6), new Complex(-6, 1.0));
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(new Complex(-2, -9.5d), v.x);
                Assert.AreEqual(new Complex(-6, 1.0), v.y);
                Assert.AreEqual(new Complex(-6, 6), v.z);
                Assert.AreEqual(new Complex(-6, 1.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, -7), new Complex(4, -0.5d), new Complex(-9, -4.5d));
                var v = ov.swizzle.rbb;
                Assert.AreEqual(new Complex(-5.5d, -7), v.x);
                Assert.AreEqual(new Complex(-9, -4.5d), v.y);
                Assert.AreEqual(new Complex(-9, -4.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(3, -0.5d), new Complex(-8, 1.5d), new Complex(-3, 3.5d));
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(new Complex(3, -0.5d), v.x);
                Assert.AreEqual(new Complex(-3, 3.5d), v.y);
                Assert.AreEqual(new Complex(-3, 3.5d), v.z);
                Assert.AreEqual(new Complex(3, -0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -4), new Complex(-3, 9), new Complex(0.5d, 0.0));
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(new Complex(-2.5d, -4), v.x);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(0.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(-3, 9), v.w);
            }
            {
                var ov = new cvec3(new Complex(7, -7), new Complex(3.5d, -4.5d), new Complex(-0.5d, -3));
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(new Complex(7, -7), v.x);
                Assert.AreEqual(new Complex(-0.5d, -3), v.y);
                Assert.AreEqual(new Complex(-0.5d, -3), v.z);
                Assert.AreEqual(new Complex(-0.5d, -3), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, -6.5d), new Complex(5.5d, 9.5d), new Complex(-4, -3.5d));
                var v = ov.swizzle.gr;
                Assert.AreEqual(new Complex(5.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -6.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(-5, 6), new Complex(-9, -9), new Complex(1.0, 5));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new Complex(-9, -9), v.x);
                Assert.AreEqual(new Complex(-5, 6), v.y);
                Assert.AreEqual(new Complex(-5, 6), v.z);
            }
            {
                var ov = new cvec3(new Complex(-4, -8), new Complex(-8.5d, 6), new Complex(-5, -6.5d));
                var v = ov.swizzle.grrr;
                Assert.AreEqual(new Complex(-8.5d, 6), v.x);
                Assert.AreEqual(new Complex(-4, -8), v.y);
                Assert.AreEqual(new Complex(-4, -8), v.z);
                Assert.AreEqual(new Complex(-4, -8), v.w);
            }
            {
                var ov = new cvec3(new Complex(1.5d, -5.5d), new Complex(-9.5d, 7.5d), new Complex(2.5d, 5));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new Complex(-9.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 3.5d), new Complex(8.5d, -3.5d), new Complex(9, 0.0));
                var v = ov.swizzle.grrb;
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(9, 0.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, 9), new Complex(0.5d, -8.5d), new Complex(-7.5d, -9));
                var v = ov.swizzle.grg;
                Assert.AreEqual(new Complex(0.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 9), v.y);
                Assert.AreEqual(new Complex(0.5d, -8.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-6, 4), Complex.One, new Complex(9, 8.5d));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(Complex.One, v.x);
                Assert.AreEqual(new Complex(-6, 4), v.y);
                Assert.AreEqual(Complex.One, v.z);
                Assert.AreEqual(new Complex(-6, 4), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4, 9.5d), new Complex(5.5d, -9.5d), new Complex(9.5d, 4.5d));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new Complex(5.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-4, 9.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(3, -2.5d), new Complex(-8.5d, 9.5d), new Complex(-8.5d, 3));
                var v = ov.swizzle.grgb;
                Assert.AreEqual(new Complex(-8.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(3, -2.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 3), v.w);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -3.5d), new Complex(2, -5.5d), new Complex(4, 7));
                var v = ov.swizzle.grb;
                Assert.AreEqual(new Complex(2, -5.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(4, 7), v.z);
            }
            {
                var ov = new cvec3(new Complex(2, -4), new Complex(4.5d, 3), new Complex(9, 0.5d));
                var v = ov.swizzle.grbr;
                Assert.AreEqual(new Complex(4.5d, 3), v.x);
                Assert.AreEqual(new Complex(2, -4), v.y);
                Assert.AreEqual(new Complex(9, 0.5d), v.z);
                Assert.AreEqual(new Complex(2, -4), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4, 8.5d), new Complex(-1, 9.5d), new Complex(-2.5d, 3));
                var v = ov.swizzle.grbg;
                Assert.AreEqual(new Complex(-1, 9.5d), v.x);
                Assert.AreEqual(new Complex(-4, 8.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 3), v.z);
                Assert.AreEqual(new Complex(-1, 9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1, 6), new Complex(5, 1.5d), new Complex(3.5d, 8.5d));
                var v = ov.swizzle.grbb;
                Assert.AreEqual(new Complex(5, 1.5d), v.x);
                Assert.AreEqual(new Complex(-1, 6), v.y);
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, -5.5d), new Complex(8.5d, 1.0), new Complex(4.5d, 9.5d));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new Complex(8.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(8.5d, 1.0), v.y);
            }
            {
                var ov = new cvec3(new Complex(0.0, -6), new Complex(2.5d, 3.5d), new Complex(-5.5d, 1.5d));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new Complex(2.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -6), v.z);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -9), new Complex(-9.5d, 6.5d), new Complex(-9.5d, 5));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new Complex(-9.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -9), v.z);
                Assert.AreEqual(new Complex(-2.5d, -9), v.w);
            }
            {
                var ov = new cvec3(new Complex(3, 1.5d), new Complex(9.5d, 3), new Complex(-7.5d, -0.5d));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new Complex(9.5d, 3), v.x);
                Assert.AreEqual(new Complex(9.5d, 3), v.y);
                Assert.AreEqual(new Complex(3, 1.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, 3), v.w);
            }
            {
                var ov = new cvec3(new Complex(7, -9), new Complex(2.5d, -2), new Complex(3.5d, -5.5d));
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(new Complex(2.5d, -2), v.x);
                Assert.AreEqual(new Complex(2.5d, -2), v.y);
                Assert.AreEqual(new Complex(7, -9), v.z);
                Assert.AreEqual(new Complex(3.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9, -3), new Complex(-1, -7.5d), new Complex(0.0, -7));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new Complex(-1, -7.5d), v.x);
                Assert.AreEqual(new Complex(-1, -7.5d), v.y);
                Assert.AreEqual(new Complex(-1, -7.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-4, 2.5d), new Complex(-1, -7), new Complex(7.5d, -9.5d));
                var v = ov.swizzle.gggr;
                Assert.AreEqual(new Complex(-1, -7), v.x);
                Assert.AreEqual(new Complex(-1, -7), v.y);
                Assert.AreEqual(new Complex(-1, -7), v.z);
                Assert.AreEqual(new Complex(-4, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 2), new Complex(-8.5d, 2.5d), new Complex(-8, -9.5d));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1, -4), new Complex(-0.5d, 7), new Complex(-3.5d, 4.5d));
                var v = ov.swizzle.gggb;
                Assert.AreEqual(new Complex(-0.5d, 7), v.x);
                Assert.AreEqual(new Complex(-0.5d, 7), v.y);
                Assert.AreEqual(new Complex(-0.5d, 7), v.z);
                Assert.AreEqual(new Complex(-3.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -4), new Complex(8, 2.5d), new Complex(-2.5d, -5.5d));
                var v = ov.swizzle.ggb;
                Assert.AreEqual(new Complex(8, 2.5d), v.x);
                Assert.AreEqual(new Complex(8, 2.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -5.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, 6.5d), new Complex(-8, 0.0), new Complex(-5.5d, -2.5d));
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(new Complex(-8, 0.0), v.x);
                Assert.AreEqual(new Complex(-8, 0.0), v.y);
                Assert.AreEqual(new Complex(-5.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-1.5d, -9.5d), new Complex(-7, -9.5d), new Complex(1.0, 8.5d));
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(new Complex(-7, -9.5d), v.x);
                Assert.AreEqual(new Complex(-7, -9.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 8.5d), v.z);
                Assert.AreEqual(new Complex(-7, -9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5, 9.5d), new Complex(-4, -8.5d), new Complex(2, -4.5d));
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(new Complex(-4, -8.5d), v.x);
                Assert.AreEqual(new Complex(-4, -8.5d), v.y);
                Assert.AreEqual(new Complex(2, -4.5d), v.z);
                Assert.AreEqual(new Complex(2, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6, 0.0), new Complex(-7, 7), new Complex(1.0, 0.0));
                var v = ov.swizzle.gb;
                Assert.AreEqual(new Complex(-7, 7), v.x);
                Assert.AreEqual(new Complex(1.0, 0.0), v.y);
            }
            {
                var ov = new cvec3(new Complex(0.0, 5.5d), new Complex(-1.5d, 3.5d), new Complex(3, -9.5d));
                var v = ov.swizzle.gbr;
                Assert.AreEqual(new Complex(-1.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(3, -9.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 5.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -9), new Complex(4.5d, 4.5d), new Complex(1.0, 0.5d));
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 0.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -9), v.z);
                Assert.AreEqual(new Complex(-7.5d, -9), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7, 5), new Complex(5.5d, -3.5d), new Complex(0.0, -6));
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -6), v.y);
                Assert.AreEqual(new Complex(-7, 5), v.z);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, -5.5d), new Complex(6.5d, -5), new Complex(5.5d, -4));
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(new Complex(6.5d, -5), v.x);
                Assert.AreEqual(new Complex(5.5d, -4), v.y);
                Assert.AreEqual(new Complex(-3.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -4), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -9), new Complex(-8, -9.5d), new Complex(-7, 6));
                var v = ov.swizzle.gbg;
                Assert.AreEqual(new Complex(-8, -9.5d), v.x);
                Assert.AreEqual(new Complex(-7, 6), v.y);
                Assert.AreEqual(new Complex(-8, -9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-7, -7), new Complex(0.5d, 2), new Complex(3, -6.5d));
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(new Complex(0.5d, 2), v.x);
                Assert.AreEqual(new Complex(3, -6.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 2), v.z);
                Assert.AreEqual(new Complex(-7, -7), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 7.5d), new Complex(5, 3), new Complex(-2, 2));
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(new Complex(5, 3), v.x);
                Assert.AreEqual(new Complex(-2, 2), v.y);
                Assert.AreEqual(new Complex(5, 3), v.z);
                Assert.AreEqual(new Complex(5, 3), v.w);
            }
            {
                var ov = new cvec3(new Complex(2.5d, -8.5d), new Complex(-8.5d, 4.5d), new Complex(-7.5d, 1.0));
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(new Complex(-8.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-8.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 1.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(8.5d, 1.0), new Complex(-9, 8.5d), new Complex(-5, -0.5d));
                var v = ov.swizzle.gbb;
                Assert.AreEqual(new Complex(-9, 8.5d), v.x);
                Assert.AreEqual(new Complex(-5, -0.5d), v.y);
                Assert.AreEqual(new Complex(-5, -0.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(1.5d, -5.5d), new Complex(3, -1), new Complex(7.5d, 1.0));
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(new Complex(3, -1), v.x);
                Assert.AreEqual(new Complex(7.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(7.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(1.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 2.5d), new Complex(8.5d, 2.5d), new Complex(4.5d, 8));
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(new Complex(8.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 8), v.y);
                Assert.AreEqual(new Complex(4.5d, 8), v.z);
                Assert.AreEqual(new Complex(8.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, -8), new Complex(-9.5d, 4), new Complex(2.5d, 9.5d));
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(new Complex(-9.5d, 4), v.x);
                Assert.AreEqual(new Complex(2.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4, 8.5d), new Complex(-1.5d, 4.5d), new Complex(4.5d, -4));
                var v = ov.swizzle.br;
                Assert.AreEqual(new Complex(4.5d, -4), v.x);
                Assert.AreEqual(new Complex(-4, 8.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 1.0), new Complex(5, 5), new Complex(-4, 6));
                var v = ov.swizzle.brr;
                Assert.AreEqual(new Complex(-4, 6), v.x);
                Assert.AreEqual(new Complex(-4.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-4.5d, 1.0), v.z);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 6), new Complex(6.5d, -2), new Complex(-8.5d, -3.5d));
                var v = ov.swizzle.brrr;
                Assert.AreEqual(new Complex(-8.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 6), v.y);
                Assert.AreEqual(new Complex(-2.5d, 6), v.z);
                Assert.AreEqual(new Complex(-2.5d, 6), v.w);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -4), new Complex(2.5d, 1.0), new Complex(9.5d, 0.0));
                var v = ov.swizzle.brrg;
                Assert.AreEqual(new Complex(9.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-0.5d, -4), v.y);
                Assert.AreEqual(new Complex(-0.5d, -4), v.z);
                Assert.AreEqual(new Complex(2.5d, 1.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(-4.5d, 1.5d), new Complex(8.5d, -7.5d), new Complex(-5.5d, -8));
                var v = ov.swizzle.brrb;
                Assert.AreEqual(new Complex(-5.5d, -8), v.x);
                Assert.AreEqual(new Complex(-4.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -8), v.w);
            }
            {
                var ov = new cvec3(new Complex(9.5d, 1.0), new Complex(-8, 2), new Complex(-2, 2));
                var v = ov.swizzle.brg;
                Assert.AreEqual(new Complex(-2, 2), v.x);
                Assert.AreEqual(new Complex(9.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-8, 2), v.z);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, 8.5d), new Complex(8, -5), new Complex(6, 6.5d));
                var v = ov.swizzle.brgr;
                Assert.AreEqual(new Complex(6, 6.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(8, -5), v.z);
                Assert.AreEqual(new Complex(-0.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -9), new Complex(-5.5d, -8), new Complex(-5, 3.5d));
                var v = ov.swizzle.brgg;
                Assert.AreEqual(new Complex(-5, 3.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -9), v.y);
                Assert.AreEqual(new Complex(-5.5d, -8), v.z);
                Assert.AreEqual(new Complex(-5.5d, -8), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 0.0), new Complex(-4.5d, -7.5d), new Complex(2.5d, -3));
                var v = ov.swizzle.brgb;
                Assert.AreEqual(new Complex(2.5d, -3), v.x);
                Assert.AreEqual(new Complex(-2.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(-4.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -3), v.w);
            }
            {
                var ov = new cvec3(new Complex(3, -5), new Complex(-1.5d, 2.5d), new Complex(7.5d, -7.5d));
                var v = ov.swizzle.brb;
                Assert.AreEqual(new Complex(7.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(3, -5), v.y);
                Assert.AreEqual(new Complex(7.5d, -7.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(1.0, 3), Complex.Zero, new Complex(8.5d, -6));
                var v = ov.swizzle.brbr;
                Assert.AreEqual(new Complex(8.5d, -6), v.x);
                Assert.AreEqual(new Complex(1.0, 3), v.y);
                Assert.AreEqual(new Complex(8.5d, -6), v.z);
                Assert.AreEqual(new Complex(1.0, 3), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 6), new Complex(2, -7), new Complex(1.0, 6));
                var v = ov.swizzle.brbg;
                Assert.AreEqual(new Complex(1.0, 6), v.x);
                Assert.AreEqual(new Complex(-5.5d, 6), v.y);
                Assert.AreEqual(new Complex(1.0, 6), v.z);
                Assert.AreEqual(new Complex(2, -7), v.w);
            }
            {
                var ov = new cvec3(new Complex(9, 8), new Complex(-3, 3.5d), new Complex(9.5d, 7.5d));
                var v = ov.swizzle.brbb;
                Assert.AreEqual(new Complex(9.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(9, 8), v.y);
                Assert.AreEqual(new Complex(9.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(7.5d, 5.5d), new Complex(5, -2), new Complex(-4.5d, -7.5d));
                var v = ov.swizzle.bg;
                Assert.AreEqual(new Complex(-4.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(5, -2), v.y);
            }
            {
                var ov = new cvec3(new Complex(0.0, -3), new Complex(8, -3.5d), new Complex(-2.5d, 7.5d));
                var v = ov.swizzle.bgr;
                Assert.AreEqual(new Complex(-2.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(8, -3.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -3), v.z);
            }
            {
                var ov = new cvec3(new Complex(-6, -1.5d), new Complex(5, 0.5d), new Complex(4, -0.5d));
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(new Complex(4, -0.5d), v.x);
                Assert.AreEqual(new Complex(5, 0.5d), v.y);
                Assert.AreEqual(new Complex(-6, -1.5d), v.z);
                Assert.AreEqual(new Complex(-6, -1.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3, -8.5d), new Complex(8.5d, 0.5d), new Complex(-8.5d, -1.5d));
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(new Complex(-8.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-3, -8.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 3), new Complex(6, -8), new Complex(-1, -2.5d));
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(new Complex(-1, -2.5d), v.x);
                Assert.AreEqual(new Complex(6, -8), v.y);
                Assert.AreEqual(new Complex(-6.5d, 3), v.z);
                Assert.AreEqual(new Complex(-1, -2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-3.5d, 1.0), new Complex(2.5d, -9.5d), new Complex(4, -5));
                var v = ov.swizzle.bgg;
                Assert.AreEqual(new Complex(4, -5), v.x);
                Assert.AreEqual(new Complex(2.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, -9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-9, -8), new Complex(8.5d, 1.0), new Complex(-9.5d, -5.5d));
                var v = ov.swizzle.bggr;
                Assert.AreEqual(new Complex(-9.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(8.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(-9, -8), v.w);
            }
            {
                var ov = new cvec3(new Complex(-8.5d, 3.5d), new Complex(-6.5d, 0.5d), new Complex(7, -8));
                var v = ov.swizzle.bggg;
                Assert.AreEqual(new Complex(7, -8), v.x);
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-5.5d, 3), new Complex(-1.5d, 8), new Complex(2.5d, 0.0));
                var v = ov.swizzle.bggb;
                Assert.AreEqual(new Complex(2.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-1.5d, 8), v.y);
                Assert.AreEqual(new Complex(-1.5d, 8), v.z);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.0, -6.5d), new Complex(1.0, -6.5d), new Complex(6.5d, 2));
                var v = ov.swizzle.bgb;
                Assert.AreEqual(new Complex(6.5d, 2), v.x);
                Assert.AreEqual(new Complex(1.0, -6.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 2), v.z);
            }
            {
                var ov = new cvec3(new Complex(-6.5d, 9), new Complex(-0.5d, 1.5d), new Complex(4, 6));
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(new Complex(4, 6), v.x);
                Assert.AreEqual(new Complex(-0.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(4, 6), v.z);
                Assert.AreEqual(new Complex(-6.5d, 9), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2, 5), new Complex(2.5d, 2), new Complex(3, 0.0));
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(new Complex(3, 0.0), v.x);
                Assert.AreEqual(new Complex(2.5d, 2), v.y);
                Assert.AreEqual(new Complex(3, 0.0), v.z);
                Assert.AreEqual(new Complex(2.5d, 2), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7.5d, -5), new Complex(-7.5d, 3), new Complex(-5, 0.5d));
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(new Complex(-5, 0.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 3), v.y);
                Assert.AreEqual(new Complex(-5, 0.5d), v.z);
                Assert.AreEqual(new Complex(-5, 0.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, 6.5d), new Complex(-1, -1), new Complex(-9, 0.5d));
                var v = ov.swizzle.bb;
                Assert.AreEqual(new Complex(-9, 0.5d), v.x);
                Assert.AreEqual(new Complex(-9, 0.5d), v.y);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -8.5d), new Complex(0.5d, 3.5d), new Complex(0.5d, 1.0));
                var v = ov.swizzle.bbr;
                Assert.AreEqual(new Complex(0.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(0.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-6, 2.5d), new Complex(-8, 9.5d), new Complex(3.5d, -8.5d));
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(new Complex(3.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-6, 2.5d), v.z);
                Assert.AreEqual(new Complex(-6, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-2.5d, -3.5d), new Complex(8.5d, 5), new Complex(9, 7.5d));
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(new Complex(9, 7.5d), v.x);
                Assert.AreEqual(new Complex(9, 7.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 5), v.w);
            }
            {
                var ov = new cvec3(new Complex(6.5d, 1.5d), new Complex(0.5d, 1.5d), new Complex(-5, 2.5d));
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(new Complex(-5, 2.5d), v.x);
                Assert.AreEqual(new Complex(-5, 2.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-5, 2.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-9.5d, -2), new Complex(-6, 9.5d), new Complex(-7.5d, -7.5d));
                var v = ov.swizzle.bbg;
                Assert.AreEqual(new Complex(-7.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-6, 9.5d), v.z);
            }
            {
                var ov = new cvec3(new Complex(-8, 1.0), new Complex(-7, 8), new Complex(-8.5d, -8));
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(new Complex(-8.5d, -8), v.x);
                Assert.AreEqual(new Complex(-8.5d, -8), v.y);
                Assert.AreEqual(new Complex(-7, 8), v.z);
                Assert.AreEqual(new Complex(-8, 1.0), v.w);
            }
            {
                var ov = new cvec3(new Complex(5.5d, 6.5d), new Complex(-6, 3), new Complex(4, 4));
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(new Complex(4, 4), v.x);
                Assert.AreEqual(new Complex(4, 4), v.y);
                Assert.AreEqual(new Complex(-6, 3), v.z);
                Assert.AreEqual(new Complex(-6, 3), v.w);
            }
            {
                var ov = new cvec3(new Complex(8, -3.5d), new Complex(0.5d, -1), new Complex(8, 7.5d));
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(new Complex(8, 7.5d), v.x);
                Assert.AreEqual(new Complex(8, 7.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -1), v.z);
                Assert.AreEqual(new Complex(8, 7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-7, -9), new Complex(-1, 6.5d), new Complex(-5, -5));
                var v = ov.swizzle.bbb;
                Assert.AreEqual(new Complex(-5, -5), v.x);
                Assert.AreEqual(new Complex(-5, -5), v.y);
                Assert.AreEqual(new Complex(-5, -5), v.z);
            }
            {
                var ov = new cvec3(new Complex(7, -4.5d), new Complex(3, -5.5d), new Complex(-1, -4));
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(new Complex(-1, -4), v.x);
                Assert.AreEqual(new Complex(-1, -4), v.y);
                Assert.AreEqual(new Complex(-1, -4), v.z);
                Assert.AreEqual(new Complex(7, -4.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(-0.5d, -4.5d), new Complex(1.5d, -7.5d), new Complex(-2.5d, -1.5d));
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec3(new Complex(0.0, 1.5d), new Complex(4.5d, -2), new Complex(2.5d, 6.5d));
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.w);
            }
        }

    }
}
