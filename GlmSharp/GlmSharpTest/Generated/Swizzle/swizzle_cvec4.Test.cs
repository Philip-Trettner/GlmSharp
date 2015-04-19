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
    public class ComplexSwizzleVec4Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new cvec4(new Complex(2.5d, 1.0), new Complex(9d, -6d), new Complex(7d, -7.5d), new Complex(-3.5d, 7d));
                var v = ov.swizzle.xx;
                Assert.AreEqual(new Complex(2.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(2.5d, 1.0), v.y);
            }
            {
                var ov = new cvec4(new Complex(-6d, 8d), new Complex(4d, -3.5d), new Complex(3d, 1.0), new Complex(7.5d, -1d));
                var v = ov.swizzle.xxx;
                Assert.AreEqual(new Complex(-6d, 8d), v.x);
                Assert.AreEqual(new Complex(-6d, 8d), v.y);
                Assert.AreEqual(new Complex(-6d, 8d), v.z);
            }
            {
                var ov = new cvec4(new Complex(6d, -3.5d), new Complex(4d, 0.0), new Complex(2d, 6.5d), new Complex(6.5d, -8.5d));
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(new Complex(6d, -3.5d), v.x);
                Assert.AreEqual(new Complex(6d, -3.5d), v.y);
                Assert.AreEqual(new Complex(6d, -3.5d), v.z);
                Assert.AreEqual(new Complex(6d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -2.5d), new Complex(-2.5d, -8.5d), new Complex(-9d, -6.5d), new Complex(3d, 9d));
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(new Complex(0.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, 3.5d), new Complex(8d, 1.5d), new Complex(-8.5d, -6d), new Complex(-7.5d, -9.5d));
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(new Complex(-4.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, -3d), new Complex(-3.5d, -4.5d), new Complex(-5d, 4d), new Complex(2d, -2.5d));
                var v = ov.swizzle.xxxw;
                Assert.AreEqual(new Complex(0.0, -3d), v.x);
                Assert.AreEqual(new Complex(0.0, -3d), v.y);
                Assert.AreEqual(new Complex(0.0, -3d), v.z);
                Assert.AreEqual(new Complex(2d, -2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, -7.5d), new Complex(-9d, -3d), new Complex(-3d, 2.5d), new Complex(3.5d, 2.5d));
                var v = ov.swizzle.xxy;
                Assert.AreEqual(new Complex(2d, -7.5d), v.x);
                Assert.AreEqual(new Complex(2d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-9d, -3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-9d, 1.5d), new Complex(6d, -9.5d), new Complex(-9.5d, -6d), new Complex(8d, 7d));
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(new Complex(-9d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-9d, 1.5d), v.y);
                Assert.AreEqual(new Complex(6d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-9d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, 6.5d), new Complex(-1.5d, -1d), new Complex(-6d, -6d), new Complex(-0.5d, 8d));
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(new Complex(-4d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-4d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, 4d), new Complex(9d, -8.5d), new Complex(4.5d, -0.5d), new Complex(-9d, 4d));
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(new Complex(0.5d, 4d), v.x);
                Assert.AreEqual(new Complex(0.5d, 4d), v.y);
                Assert.AreEqual(new Complex(9d, -8.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, 9.5d), new Complex(-1.5d, 6d), new Complex(-1d, 9d), new Complex(-2d, -3d));
                var v = ov.swizzle.xxyw;
                Assert.AreEqual(new Complex(2d, 9.5d), v.x);
                Assert.AreEqual(new Complex(2d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 6d), v.z);
                Assert.AreEqual(new Complex(-2d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -7.5d), new Complex(6.5d, -4d), new Complex(7d, -9.5d), new Complex(-8d, 5.5d));
                var v = ov.swizzle.xxz;
                Assert.AreEqual(new Complex(0.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(7d, -9.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -1d), new Complex(9.5d, 9.5d), new Complex(-7d, 7d), new Complex(-8d, -6.5d));
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(new Complex(-9.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-7d, 7d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 2.5d), new Complex(-7.5d, 0.0), new Complex(2.5d, 8.5d), new Complex(5d, -5d));
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(new Complex(-5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -1d), new Complex(4d, 2.5d), new Complex(-6.5d, -5.5d), new Complex(6.5d, 5.5d));
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(new Complex(5.5d, -1d), v.x);
                Assert.AreEqual(new Complex(5.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, 4.5d), new Complex(9d, 8d), new Complex(-8d, -8d), new Complex(0.0, 4d));
                var v = ov.swizzle.xxzw;
                Assert.AreEqual(new Complex(1.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-8d, -8d), v.z);
                Assert.AreEqual(new Complex(0.0, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, -4.5d), new Complex(4.5d, -0.5d), new Complex(-7.5d, -6.5d), new Complex(2d, -5d));
                var v = ov.swizzle.xxw;
                Assert.AreEqual(new Complex(-5.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(2d, -5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-2d, 3d), new Complex(0.5d, -4d), new Complex(-4d, 4d), new Complex(-6d, -1d));
                var v = ov.swizzle.xxwx;
                Assert.AreEqual(new Complex(-2d, 3d), v.x);
                Assert.AreEqual(new Complex(-2d, 3d), v.y);
                Assert.AreEqual(new Complex(-6d, -1d), v.z);
                Assert.AreEqual(new Complex(-2d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 2d), new Complex(2d, 9d), new Complex(-9d, -8d), new Complex(-3d, 5d));
                var v = ov.swizzle.xxwy;
                Assert.AreEqual(new Complex(-5d, 2d), v.x);
                Assert.AreEqual(new Complex(-5d, 2d), v.y);
                Assert.AreEqual(new Complex(-3d, 5d), v.z);
                Assert.AreEqual(new Complex(2d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -3d), new Complex(2d, 0.5d), new Complex(-3d, 5d), new Complex(6d, 7d));
                var v = ov.swizzle.xxwz;
                Assert.AreEqual(new Complex(-6d, -3d), v.x);
                Assert.AreEqual(new Complex(-6d, -3d), v.y);
                Assert.AreEqual(new Complex(6d, 7d), v.z);
                Assert.AreEqual(new Complex(-3d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, 1.5d), new Complex(4.5d, 6.5d), new Complex(-4d, -9.5d), new Complex(-9d, 1.5d));
                var v = ov.swizzle.xxww;
                Assert.AreEqual(new Complex(-1d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-9d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-9d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -3d), new Complex(1.0, 1.5d), new Complex(3.5d, -5d), new Complex(2.5d, 5.5d));
                var v = ov.swizzle.xy;
                Assert.AreEqual(new Complex(0.5d, -3d), v.x);
                Assert.AreEqual(new Complex(1.0, 1.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -2d), new Complex(9d, 9.5d), new Complex(3.5d, 7.5d), new Complex(-4.5d, 9d));
                var v = ov.swizzle.xyx;
                Assert.AreEqual(new Complex(5.5d, -2d), v.x);
                Assert.AreEqual(new Complex(9d, 9.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -2d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 6.5d), new Complex(7.5d, 3.5d), new Complex(-2.5d, 9d), new Complex(3.5d, 1.5d));
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, -2.5d), new Complex(-1d, 3d), new Complex(-2.5d, -2.5d), new Complex(5.5d, 2.5d));
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(new Complex(9d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 3d), v.y);
                Assert.AreEqual(new Complex(9d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-1d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, -0.5d), new Complex(5d, 2d), new Complex(6d, -0.5d), new Complex(-0.5d, 7.5d));
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(new Complex(-4d, -0.5d), v.x);
                Assert.AreEqual(new Complex(5d, 2d), v.y);
                Assert.AreEqual(new Complex(-4d, -0.5d), v.z);
                Assert.AreEqual(new Complex(6d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 2.5d), new Complex(0.0, 4.5d), new Complex(3d, -8d), new Complex(-3d, -9.5d));
                var v = ov.swizzle.xyxw;
                Assert.AreEqual(new Complex(-3.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 4.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-3d, -9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, -9.5d), new Complex(-9.5d, 0.5d), new Complex(0.5d, 1.0), new Complex(2.5d, -8d));
                var v = ov.swizzle.xyy;
                Assert.AreEqual(new Complex(2d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(2.5d, -2.5d), new Complex(-7d, -4d), new Complex(-3.5d, 1.0), new Complex(6.5d, 7.5d));
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(new Complex(2.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -4d), v.y);
                Assert.AreEqual(new Complex(-7d, -4d), v.z);
                Assert.AreEqual(new Complex(2.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -0.5d), new Complex(8.5d, -3.5d), new Complex(9d, 2.5d), new Complex(-7.5d, 1.5d));
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, -2d), new Complex(-0.5d, -2.5d), new Complex(7d, 2d), new Complex(1.0, 2d));
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(new Complex(1.0, -2d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(7d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -6d), new Complex(-1.5d, 4.5d), new Complex(-0.5d, -4d), new Complex(-7d, 8d));
                var v = ov.swizzle.xyyw;
                Assert.AreEqual(new Complex(6.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 9.5d), new Complex(-4.5d, -3.5d), new Complex(2d, -6d), new Complex(5d, 7d));
                var v = ov.swizzle.xyz;
                Assert.AreEqual(new Complex(-5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(2d, -6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6d, 2d), new Complex(-7d, -3d), new Complex(2.5d, -8d), new Complex(5d, -2.5d));
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(new Complex(-6d, 2d), v.x);
                Assert.AreEqual(new Complex(-7d, -3d), v.y);
                Assert.AreEqual(new Complex(2.5d, -8d), v.z);
                Assert.AreEqual(new Complex(-6d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 5d), new Complex(-5.5d, -6.5d), new Complex(2.5d, 8.5d), new Complex(-0.5d, -6d));
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(new Complex(-1.5d, 5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, -3d), new Complex(-9.5d, 2.5d), new Complex(0.5d, -3d), new Complex(-5d, -9.5d));
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(new Complex(8.5d, -3d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -3d), v.z);
                Assert.AreEqual(new Complex(0.5d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, 7.5d), new Complex(1.0, -8d), new Complex(2.5d, -6.5d), new Complex(9d, -8.5d));
                var v = ov.swizzle.xyzw;
                Assert.AreEqual(new Complex(-9.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -8d), v.y);
                Assert.AreEqual(new Complex(2.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(9d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -0.5d), new Complex(0.5d, -2d), new Complex(8.5d, 2d), new Complex(-2d, 1.0));
                var v = ov.swizzle.xyw;
                Assert.AreEqual(new Complex(-2d, -0.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-2d, 1.0), v.z);
            }
            {
                var ov = new cvec4(new Complex(0.0, 8d), new Complex(4d, 4.5d), new Complex(4.5d, -9d), new Complex(-4.5d, 2d));
                var v = ov.swizzle.xywx;
                Assert.AreEqual(new Complex(0.0, 8d), v.x);
                Assert.AreEqual(new Complex(4d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 2d), v.z);
                Assert.AreEqual(new Complex(0.0, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, 9.5d), new Complex(5d, -4.5d), new Complex(3.5d, -8.5d), new Complex(7.5d, 8.5d));
                var v = ov.swizzle.xywy;
                Assert.AreEqual(new Complex(7.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -9.5d), new Complex(-2.5d, 8d), new Complex(7.5d, -8.5d), new Complex(-7d, 4.5d));
                var v = ov.swizzle.xywz;
                Assert.AreEqual(new Complex(-2d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-7d, 4.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8d, -2d), new Complex(-5.5d, 2.5d), new Complex(-7d, -3d), new Complex(-6d, -3d));
                var v = ov.swizzle.xyww;
                Assert.AreEqual(new Complex(-8d, -2d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-6d, -3d), v.z);
                Assert.AreEqual(new Complex(-6d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 5.5d), new Complex(-9.5d, -3d), new Complex(8d, 0.5d), new Complex(-2d, 4d));
                var v = ov.swizzle.xz;
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(8d, 0.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(5d, -4.5d), new Complex(-8.5d, -6d), new Complex(-5.5d, -9d), new Complex(-8.5d, -9d));
                var v = ov.swizzle.xzx;
                Assert.AreEqual(new Complex(5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -9d), v.y);
                Assert.AreEqual(new Complex(5d, -4.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -4d), new Complex(2.5d, -6.5d), new Complex(-8.5d, 5d), new Complex(4.5d, 6.5d));
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(new Complex(9.5d, -4d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -4d), v.z);
                Assert.AreEqual(new Complex(9.5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -2d), new Complex(-9d, 1.5d), new Complex(4d, -8d), new Complex(-4.5d, -2.5d));
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(new Complex(6.5d, -2d), v.x);
                Assert.AreEqual(new Complex(4d, -8d), v.y);
                Assert.AreEqual(new Complex(6.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-9d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, -5.5d), new Complex(1.5d, -5d), new Complex(4d, 6.5d), new Complex(-1d, 6d));
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(new Complex(-2.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(4d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(4d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 3.5d), new Complex(7d, -4d), new Complex(7d, -2.5d), new Complex(-7.5d, -8d));
                var v = ov.swizzle.xzxw;
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(7d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, 1.0), new Complex(5.5d, 0.0), new Complex(-7d, 4.5d), new Complex(-2d, 1.0));
                var v = ov.swizzle.xzy;
                Assert.AreEqual(new Complex(1.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-7d, 4.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 0.0), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -2d), new Complex(-3d, -7d), new Complex(7.5d, 7d), new Complex(6.5d, 5d));
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(new Complex(-6.5d, -2d), v.x);
                Assert.AreEqual(new Complex(7.5d, 7d), v.y);
                Assert.AreEqual(new Complex(-3d, -7d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, 4d), new Complex(-7d, 7d), new Complex(-4.5d, -4.5d), new Complex(2.5d, -7d));
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(new Complex(-4.5d, 4d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 7d), v.z);
                Assert.AreEqual(new Complex(-7d, 7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -9d), new Complex(-3.5d, 6.5d), new Complex(5d, -4d), new Complex(-9d, 2.5d));
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(new Complex(-8.5d, -9d), v.x);
                Assert.AreEqual(new Complex(5d, -4d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -5d), new Complex(-3d, 8.5d), new Complex(-4.5d, -0.5d), new Complex(5d, -4d));
                var v = ov.swizzle.xzyw;
                Assert.AreEqual(new Complex(-8.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-3d, 8.5d), v.z);
                Assert.AreEqual(new Complex(5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -9.5d), new Complex(8.5d, -5.5d), new Complex(1.0, -5.5d), new Complex(2.5d, -1.5d));
                var v = ov.swizzle.xzz;
                Assert.AreEqual(new Complex(-4.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -5.5d), v.y);
                Assert.AreEqual(new Complex(1.0, -5.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, -0.5d), new Complex(-2d, 1.5d), new Complex(0.5d, 9d), new Complex(-3.5d, 7.5d));
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(new Complex(-7.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 9d), v.y);
                Assert.AreEqual(new Complex(0.5d, 9d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, 3.5d), new Complex(6d, 4d), new Complex(3.5d, -9d), new Complex(-7d, -9.5d));
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(new Complex(-9d, 3.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -9d), v.y);
                Assert.AreEqual(new Complex(3.5d, -9d), v.z);
                Assert.AreEqual(new Complex(6d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -6.5d), new Complex(-2.5d, -3d), new Complex(-8.5d, 2d), new Complex(-1d, -5.5d));
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(new Complex(-2d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, -9.5d), new Complex(-3d, -5d), new Complex(8.5d, 6d), new Complex(-3.5d, 4.5d));
                var v = ov.swizzle.xzzw;
                Assert.AreEqual(new Complex(3d, -9.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 6d), v.y);
                Assert.AreEqual(new Complex(8.5d, 6d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -6d), new Complex(-5.5d, 9.5d), new Complex(9d, 0.5d), new Complex(-9.5d, 1.0));
                var v = ov.swizzle.xzw;
                Assert.AreEqual(new Complex(5.5d, -6d), v.x);
                Assert.AreEqual(new Complex(9d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 1.0), v.z);
            }
            {
                var ov = new cvec4(new Complex(4.5d, 6d), new Complex(-3d, 0.0), new Complex(4d, 6d), new Complex(0.0, -3.5d));
                var v = ov.swizzle.xzwx;
                Assert.AreEqual(new Complex(4.5d, 6d), v.x);
                Assert.AreEqual(new Complex(4d, 6d), v.y);
                Assert.AreEqual(new Complex(0.0, -3.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, 8.5d), new Complex(-3.5d, 3d), new Complex(-0.5d, 2.5d), new Complex(8d, 3.5d));
                var v = ov.swizzle.xzwy;
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(8d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, -5.5d), new Complex(2d, -2d), new Complex(6.5d, 8.5d), new Complex(2.5d, -8d));
                var v = ov.swizzle.xzwz;
                Assert.AreEqual(new Complex(-7.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, -8d), v.z);
                Assert.AreEqual(new Complex(6.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, -5d), new Complex(-4.5d, 5d), new Complex(-0.5d, -2d), new Complex(-1d, -9d));
                var v = ov.swizzle.xzww;
                Assert.AreEqual(new Complex(3.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-1d, -9d), v.z);
                Assert.AreEqual(new Complex(-1d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, 7d), new Complex(-1d, 7d), new Complex(-7d, 9d), new Complex(-8d, 8.5d));
                var v = ov.swizzle.xw;
                Assert.AreEqual(new Complex(-6.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-8d, 8.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -1.5d), new Complex(8d, 2d), new Complex(-9.5d, 1.5d), new Complex(4.5d, 6d));
                var v = ov.swizzle.xwx;
                Assert.AreEqual(new Complex(-6.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 6d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -1.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(5d, 1.5d), new Complex(4.5d, 0.5d), new Complex(-6d, -1d), new Complex(7d, 7.5d));
                var v = ov.swizzle.xwxx;
                Assert.AreEqual(new Complex(5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(7d, 7.5d), v.y);
                Assert.AreEqual(new Complex(5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(5d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 1.5d), new Complex(8.5d, 4.5d), new Complex(9d, 8.5d), new Complex(0.0, -8d));
                var v = ov.swizzle.xwxy;
                Assert.AreEqual(new Complex(-5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -8d), v.y);
                Assert.AreEqual(new Complex(-5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 2.5d), new Complex(-7.5d, -7.5d), new Complex(8.5d, -7.5d), new Complex(9d, -3.5d));
                var v = ov.swizzle.xwxz;
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(9d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7d, -6.5d), new Complex(-0.5d, -7.5d), new Complex(0.0, 6.5d), new Complex(3.5d, 0.5d));
                var v = ov.swizzle.xwxw;
                Assert.AreEqual(new Complex(7d, -6.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(7d, -6.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, -2d), new Complex(-5.5d, -5.5d), new Complex(4.5d, 5.5d), new Complex(9d, 9d));
                var v = ov.swizzle.xwy;
                Assert.AreEqual(new Complex(-7d, -2d), v.x);
                Assert.AreEqual(new Complex(9d, 9d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -5.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -4d), new Complex(-1.5d, -5.5d), new Complex(-8d, 9d), new Complex(-9d, -4d));
                var v = ov.swizzle.xwyx;
                Assert.AreEqual(new Complex(0.5d, -4d), v.x);
                Assert.AreEqual(new Complex(-9d, -4d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 2d), new Complex(-2.5d, -4.5d), new Complex(3d, -4.5d), new Complex(-4.5d, 5d));
                var v = ov.swizzle.xwyy;
                Assert.AreEqual(new Complex(-5.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7d, -1.5d), new Complex(1.5d, 2.5d), new Complex(6.5d, -3d), new Complex(-3.5d, 1.0));
                var v = ov.swizzle.xwyz;
                Assert.AreEqual(new Complex(7d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(1.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2.5d, 9d), new Complex(9d, 9.5d), new Complex(4.5d, 4.5d), new Complex(1.5d, 8d));
                var v = ov.swizzle.xwyw;
                Assert.AreEqual(new Complex(2.5d, 9d), v.x);
                Assert.AreEqual(new Complex(1.5d, 8d), v.y);
                Assert.AreEqual(new Complex(9d, 9.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, 1.5d), new Complex(-8.5d, 2.5d), new Complex(4.5d, 2d), new Complex(-6.5d, 0.5d));
                var v = ov.swizzle.xwz;
                Assert.AreEqual(new Complex(9d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 2d), v.z);
            }
            {
                var ov = new cvec4(new Complex(2.5d, -3d), new Complex(6.5d, -9d), new Complex(3d, -5.5d), new Complex(-1d, 0.5d));
                var v = ov.swizzle.xwzx;
                Assert.AreEqual(new Complex(2.5d, -3d), v.x);
                Assert.AreEqual(new Complex(-1d, 0.5d), v.y);
                Assert.AreEqual(new Complex(3d, -5.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, -5.5d), new Complex(-9d, -5.5d), new Complex(2d, 4.5d), new Complex(3.5d, -4.5d));
                var v = ov.swizzle.xwzy;
                Assert.AreEqual(new Complex(-3.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(2d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-9d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, 9d), new Complex(-6.5d, -9.5d), new Complex(1.0, -5.5d), new Complex(9.5d, 4d));
                var v = ov.swizzle.xwzz;
                Assert.AreEqual(new Complex(9d, 9d), v.x);
                Assert.AreEqual(new Complex(9.5d, 4d), v.y);
                Assert.AreEqual(new Complex(1.0, -5.5d), v.z);
                Assert.AreEqual(new Complex(1.0, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, 7d), new Complex(-1d, -9d), new Complex(3d, 1.5d), new Complex(-8d, 6d));
                var v = ov.swizzle.xwzw;
                Assert.AreEqual(new Complex(-4d, 7d), v.x);
                Assert.AreEqual(new Complex(-8d, 6d), v.y);
                Assert.AreEqual(new Complex(3d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, -8d), new Complex(6.5d, 6.5d), new Complex(-5.5d, 4.5d), new Complex(-1.5d, 5d));
                var v = ov.swizzle.xww;
                Assert.AreEqual(new Complex(-7d, -8d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 7d), new Complex(-4.5d, 2.5d), new Complex(2.5d, -0.5d), new Complex(6.5d, 9.5d));
                var v = ov.swizzle.xwwx;
                Assert.AreEqual(new Complex(5.5d, 7d), v.x);
                Assert.AreEqual(new Complex(6.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, 7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 8d), new Complex(-3d, -8d), new Complex(-8d, -7d), new Complex(7.5d, -6.5d));
                var v = ov.swizzle.xwwy;
                Assert.AreEqual(new Complex(-3.5d, 8d), v.x);
                Assert.AreEqual(new Complex(7.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-3d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -1.5d), new Complex(9d, -2.5d), new Complex(-6.5d, 6.5d), new Complex(5.5d, -9.5d));
                var v = ov.swizzle.xwwz;
                Assert.AreEqual(new Complex(4.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -7.5d), new Complex(-2d, 3d), new Complex(-7d, 7.5d), new Complex(3.5d, 5.5d));
                var v = ov.swizzle.xwww;
                Assert.AreEqual(new Complex(0.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 8.5d), new Complex(6d, -8d), new Complex(2.5d, 0.5d), new Complex(4d, -7d));
                var v = ov.swizzle.yx;
                Assert.AreEqual(new Complex(6d, -8d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 8.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, -0.5d), new Complex(9d, 9.5d), new Complex(-5d, 4.5d), new Complex(-4.5d, 8d));
                var v = ov.swizzle.yxx;
                Assert.AreEqual(new Complex(9d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(0.5d, 5d), new Complex(7.5d, 8d), new Complex(-2d, 2.5d), new Complex(-8.5d, -0.5d));
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(new Complex(7.5d, 8d), v.x);
                Assert.AreEqual(new Complex(0.5d, 5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 5d), new Complex(-7d, -4.5d), new Complex(-4d, -0.5d), new Complex(-3d, 4.5d));
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(new Complex(-7d, -4.5d), v.x);
                Assert.AreEqual(new Complex(6d, 5d), v.y);
                Assert.AreEqual(new Complex(6d, 5d), v.z);
                Assert.AreEqual(new Complex(-7d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, 7.5d), new Complex(5d, 4.5d), new Complex(-1.5d, -7.5d), new Complex(6d, -9d));
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(new Complex(5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, -2.5d), new Complex(6d, -5.5d), new Complex(-4.5d, -8.5d), new Complex(-4d, 3d));
                var v = ov.swizzle.yxxw;
                Assert.AreEqual(new Complex(6d, -5.5d), v.x);
                Assert.AreEqual(new Complex(3d, -2.5d), v.y);
                Assert.AreEqual(new Complex(3d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-4d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 4d), new Complex(5d, -1d), new Complex(8.5d, 7.5d), new Complex(9.5d, -7.5d));
                var v = ov.swizzle.yxy;
                Assert.AreEqual(new Complex(5d, -1d), v.x);
                Assert.AreEqual(new Complex(1.0, 4d), v.y);
                Assert.AreEqual(new Complex(5d, -1d), v.z);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -6.5d), new Complex(6d, 3d), new Complex(8d, -8.5d), new Complex(2d, 1.0));
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(new Complex(6d, 3d), v.x);
                Assert.AreEqual(new Complex(9.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(6d, 3d), v.z);
                Assert.AreEqual(new Complex(9.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, -7.5d), new Complex(9d, 5.5d), new Complex(3.5d, 8d), new Complex(9d, 8.5d));
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(new Complex(9d, 5.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(9d, 5.5d), v.z);
                Assert.AreEqual(new Complex(9d, 5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, 3d), new Complex(-9.5d, -5d), new Complex(3d, -5d), new Complex(-4.5d, 6d));
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(new Complex(-9.5d, -5d), v.x);
                Assert.AreEqual(new Complex(4d, 3d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -5d), v.z);
                Assert.AreEqual(new Complex(3d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, 6.5d), new Complex(7d, -9d), new Complex(6d, 2.5d), new Complex(-0.5d, 0.0));
                var v = ov.swizzle.yxyw;
                Assert.AreEqual(new Complex(7d, -9d), v.x);
                Assert.AreEqual(new Complex(9d, 6.5d), v.y);
                Assert.AreEqual(new Complex(7d, -9d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, -6.5d), new Complex(6.5d, -2.5d), new Complex(1.5d, -6d), new Complex(-8d, 0.0));
                var v = ov.swizzle.yxz;
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -6.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 8.5d), new Complex(9d, 9.5d), new Complex(8.5d, -6.5d), new Complex(-5.5d, -4.5d));
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(new Complex(9d, 9.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -8.5d), new Complex(-1d, -7d), new Complex(0.5d, 6d), new Complex(-8d, -3d));
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(new Complex(-1d, -7d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 6d), v.z);
                Assert.AreEqual(new Complex(-1d, -7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, 7.5d), new Complex(-9d, -5.5d), new Complex(3d, 9d), new Complex(-9d, -6d));
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(new Complex(-9d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(3d, 9d), v.z);
                Assert.AreEqual(new Complex(3d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 1.0), new Complex(-6d, -2d), new Complex(-4.5d, -4.5d), new Complex(-5.5d, 0.0));
                var v = ov.swizzle.yxzw;
                Assert.AreEqual(new Complex(-6d, -2d), v.x);
                Assert.AreEqual(new Complex(-2d, 1.0), v.y);
                Assert.AreEqual(new Complex(-4.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, -4.5d), new Complex(9d, -0.5d), new Complex(-1.5d, 6d), new Complex(6.5d, 9d));
                var v = ov.swizzle.yxw;
                Assert.AreEqual(new Complex(9d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 9d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, -6d), new Complex(3d, -0.5d), new Complex(8d, -1.5d), new Complex(-7d, -9.5d));
                var v = ov.swizzle.yxwx;
                Assert.AreEqual(new Complex(3d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-7d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, -7d), new Complex(3d, -4d), new Complex(6.5d, -7.5d), new Complex(6.5d, 7d));
                var v = ov.swizzle.yxwy;
                Assert.AreEqual(new Complex(3d, -4d), v.x);
                Assert.AreEqual(new Complex(2d, -7d), v.y);
                Assert.AreEqual(new Complex(6.5d, 7d), v.z);
                Assert.AreEqual(new Complex(3d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, 2.5d), new Complex(6.5d, -9.5d), new Complex(-3d, -8d), new Complex(4d, -7d));
                var v = ov.swizzle.yxwz;
                Assert.AreEqual(new Complex(6.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(4d, -7d), v.z);
                Assert.AreEqual(new Complex(-3d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, 5.5d), new Complex(-8.5d, 4.5d), new Complex(3d, -8.5d), new Complex(-0.5d, -8.5d));
                var v = ov.swizzle.yxww;
                Assert.AreEqual(new Complex(-8.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-4d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7d, -8.5d), new Complex(-5.5d, 5.5d), new Complex(-9d, -9.5d), new Complex(-6.5d, 3d));
                var v = ov.swizzle.yy;
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -0.5d), new Complex(-5d, 4.5d), new Complex(-0.5d, 0.0), new Complex(-4.5d, -9.5d));
                var v = ov.swizzle.yyx;
                Assert.AreEqual(new Complex(-5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-7d, 2d), new Complex(-5.5d, 9.5d), new Complex(-4d, 2d), new Complex(4.5d, -4.5d));
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 2d), v.z);
                Assert.AreEqual(new Complex(-7d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 3.5d), new Complex(-6.5d, 1.5d), new Complex(0.0, -4d), new Complex(0.5d, 4.5d));
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8d, -9d), new Complex(5.5d, 5d), new Complex(3.5d, -5.5d), new Complex(2.5d, 7d));
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(new Complex(5.5d, 5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 5d), v.y);
                Assert.AreEqual(new Complex(8d, -9d), v.z);
                Assert.AreEqual(new Complex(3.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 9d), new Complex(-7.5d, 0.0), new Complex(-7.5d, 6d), new Complex(-9.5d, 5d));
                var v = ov.swizzle.yyxw;
                Assert.AreEqual(new Complex(-7.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-7.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(1.0, 9d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, 4.5d), new Complex(3.5d, 8.5d), new Complex(-8d, -9.5d), new Complex(-4.5d, -7d));
                var v = ov.swizzle.yyy;
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(6d, 3d), new Complex(8.5d, 2.5d), new Complex(4d, -8d), new Complex(0.5d, 7d));
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(new Complex(8.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(6d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -1.5d), new Complex(6.5d, 4d), new Complex(-6d, -7d), new Complex(3d, -1.5d));
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(new Complex(6.5d, 4d), v.x);
                Assert.AreEqual(new Complex(6.5d, 4d), v.y);
                Assert.AreEqual(new Complex(6.5d, 4d), v.z);
                Assert.AreEqual(new Complex(6.5d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, 8d), new Complex(5d, 1.0), new Complex(-6d, -9d), new Complex(8d, -9.5d));
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(new Complex(5d, 1.0), v.x);
                Assert.AreEqual(new Complex(5d, 1.0), v.y);
                Assert.AreEqual(new Complex(5d, 1.0), v.z);
                Assert.AreEqual(new Complex(-6d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, -1.5d), new Complex(-5.5d, 8d), new Complex(0.0, -5d), new Complex(-8d, -8d));
                var v = ov.swizzle.yyyw;
                Assert.AreEqual(new Complex(-5.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-8d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -2d), new Complex(1.0, 5.5d), new Complex(-4d, -3d), new Complex(-6d, 8.5d));
                var v = ov.swizzle.yyz;
                Assert.AreEqual(new Complex(1.0, 5.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 5.5d), v.y);
                Assert.AreEqual(new Complex(-4d, -3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(6.5d, 4d), new Complex(-7.5d, -6.5d), new Complex(5.5d, 8.5d), new Complex(-9d, 0.5d));
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(new Complex(-7.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 9d), new Complex(-2d, -4d), new Complex(-1.5d, 9d), new Complex(-3.5d, -9.5d));
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(new Complex(-2d, -4d), v.x);
                Assert.AreEqual(new Complex(-2d, -4d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 9d), v.z);
                Assert.AreEqual(new Complex(-2d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, -2.5d), new Complex(9.5d, -4d), new Complex(8d, 6d), new Complex(-3.5d, 1.5d));
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(new Complex(9.5d, -4d), v.x);
                Assert.AreEqual(new Complex(9.5d, -4d), v.y);
                Assert.AreEqual(new Complex(8d, 6d), v.z);
                Assert.AreEqual(new Complex(8d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, -4d), new Complex(3d, -7.5d), new Complex(-9d, -4d), new Complex(-8d, -1d));
                var v = ov.swizzle.yyzw;
                Assert.AreEqual(new Complex(3d, -7.5d), v.x);
                Assert.AreEqual(new Complex(3d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-9d, -4d), v.z);
                Assert.AreEqual(new Complex(-8d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -9d), new Complex(-6.5d, 5.5d), new Complex(-7.5d, 4.5d), new Complex(-3.5d, -0.5d));
                var v = ov.swizzle.yyw;
                Assert.AreEqual(new Complex(-6.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(7d, -2d), new Complex(6.5d, -3.5d), new Complex(9.5d, -3.5d), new Complex(3d, -5d));
                var v = ov.swizzle.yywx;
                Assert.AreEqual(new Complex(6.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(3d, -5d), v.z);
                Assert.AreEqual(new Complex(7d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, -5.5d), new Complex(-4.5d, 2d), new Complex(-7d, -8d), new Complex(-8d, 0.0));
                var v = ov.swizzle.yywy;
                Assert.AreEqual(new Complex(-4.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-8d, 0.0), v.z);
                Assert.AreEqual(new Complex(-4.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -6.5d), new Complex(3d, -2.5d), new Complex(-0.5d, 4.5d), new Complex(-2d, 7.5d));
                var v = ov.swizzle.yywz;
                Assert.AreEqual(new Complex(3d, -2.5d), v.x);
                Assert.AreEqual(new Complex(3d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -5.5d), new Complex(1.0, -9.5d), new Complex(-0.5d, -3d), new Complex(-5.5d, -8.5d));
                var v = ov.swizzle.yyww;
                Assert.AreEqual(new Complex(1.0, -9.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -9.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, 2.5d), new Complex(-4.5d, -1.5d), new Complex(1.0, 5.5d), new Complex(0.0, -3d));
                var v = ov.swizzle.yz;
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 5.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(7d, 2.5d), new Complex(-0.5d, 7.5d), new Complex(0.0, 8.5d), new Complex(1.5d, 4.5d));
                var v = ov.swizzle.yzx;
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 8.5d), v.y);
                Assert.AreEqual(new Complex(7d, 2.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(6.5d, 4.5d), new Complex(-0.5d, -2.5d), new Complex(-2d, 6d), new Complex(-2d, 3d));
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(new Complex(-0.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-2d, 6d), v.y);
                Assert.AreEqual(new Complex(6.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, 3.5d), new Complex(-6.5d, 4d), new Complex(7.5d, 8.5d), new Complex(6d, -4d));
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(new Complex(-6.5d, 4d), v.x);
                Assert.AreEqual(new Complex(7.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(4d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, 0.0), new Complex(-2.5d, -6.5d), new Complex(8d, -5.5d), new Complex(9.5d, -9d));
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(new Complex(-2.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(8d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(8d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 7.5d), new Complex(2.5d, -8.5d), new Complex(0.0, 3d), new Complex(3d, 5d));
                var v = ov.swizzle.yzxw;
                Assert.AreEqual(new Complex(2.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 3d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(3d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, 5.5d), new Complex(-1d, 6d), new Complex(4d, 4.5d), new Complex(8.5d, 9.5d));
                var v = ov.swizzle.yzy;
                Assert.AreEqual(new Complex(-1d, 6d), v.x);
                Assert.AreEqual(new Complex(4d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(9d, -8d), new Complex(6.5d, 9d), new Complex(6d, 5d), new Complex(5.5d, 1.5d));
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(new Complex(6.5d, 9d), v.x);
                Assert.AreEqual(new Complex(6d, 5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 9d), v.z);
                Assert.AreEqual(new Complex(9d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 8d), new Complex(4.5d, 3.5d), new Complex(-5d, -6d), new Complex(4.5d, 1.5d));
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(new Complex(4.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-5d, -6d), v.y);
                Assert.AreEqual(new Complex(4.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, 7.5d), new Complex(-7.5d, -9.5d), new Complex(-8d, 4.5d), new Complex(-8d, -5d));
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(new Complex(-7.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-8d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -4.5d), new Complex(7d, 0.5d), new Complex(6d, -8.5d), new Complex(-0.5d, 7.5d));
                var v = ov.swizzle.yzyw;
                Assert.AreEqual(new Complex(7d, 0.5d), v.x);
                Assert.AreEqual(new Complex(6d, -8.5d), v.y);
                Assert.AreEqual(new Complex(7d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, 3.5d), new Complex(5d, -2d), new Complex(-3d, 5d), new Complex(8.5d, -9d));
                var v = ov.swizzle.yzz;
                Assert.AreEqual(new Complex(5d, -2d), v.x);
                Assert.AreEqual(new Complex(-3d, 5d), v.y);
                Assert.AreEqual(new Complex(-3d, 5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(5d, -0.5d), new Complex(-6.5d, -8d), new Complex(2.5d, 7.5d), new Complex(3.5d, 0.0));
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(new Complex(-6.5d, -8d), v.x);
                Assert.AreEqual(new Complex(2.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(5d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2.5d, 5.5d), new Complex(-0.5d, 4.5d), new Complex(1.0, -8.5d), new Complex(-1d, -1d));
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(new Complex(-0.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -8.5d), v.y);
                Assert.AreEqual(new Complex(1.0, -8.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -7.5d), new Complex(8.5d, -0.5d), new Complex(5d, -7d), new Complex(7.5d, -3.5d));
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(new Complex(8.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(5d, -7d), v.y);
                Assert.AreEqual(new Complex(5d, -7d), v.z);
                Assert.AreEqual(new Complex(5d, -7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, 0.0), new Complex(1.0, 9.5d), new Complex(-7.5d, -5d), new Complex(0.0, -6.5d));
                var v = ov.swizzle.yzzw;
                Assert.AreEqual(new Complex(1.0, 9.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -5d), v.z);
                Assert.AreEqual(new Complex(0.0, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -9.5d), new Complex(-6d, -6d), new Complex(6.5d, 5.5d), new Complex(-1d, 0.0));
                var v = ov.swizzle.yzw;
                Assert.AreEqual(new Complex(-6d, -6d), v.x);
                Assert.AreEqual(new Complex(6.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 0.0), v.z);
            }
            {
                var ov = new cvec4(new Complex(7d, -3.5d), new Complex(3d, 4d), new Complex(-4.5d, -7d), new Complex(7.5d, -8.5d));
                var v = ov.swizzle.yzwx;
                Assert.AreEqual(new Complex(3d, 4d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -7d), v.y);
                Assert.AreEqual(new Complex(7.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(7d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8d, -3.5d), new Complex(1.5d, 9d), new Complex(3d, 1.5d), new Complex(-5d, 5d));
                var v = ov.swizzle.yzwy;
                Assert.AreEqual(new Complex(1.5d, 9d), v.x);
                Assert.AreEqual(new Complex(3d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 5d), v.z);
                Assert.AreEqual(new Complex(1.5d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, 8.5d), new Complex(-1d, 6d), new Complex(0.5d, -3d), new Complex(-0.5d, -8.5d));
                var v = ov.swizzle.yzwz;
                Assert.AreEqual(new Complex(-1d, 6d), v.x);
                Assert.AreEqual(new Complex(0.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, 1.0), new Complex(6d, -6d), new Complex(3.5d, 8d), new Complex(-3.5d, 9.5d));
                var v = ov.swizzle.yzww;
                Assert.AreEqual(new Complex(6d, -6d), v.x);
                Assert.AreEqual(new Complex(3.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, 9d), new Complex(-4d, 4d), new Complex(2d, 4.5d), new Complex(-4.5d, -5d));
                var v = ov.swizzle.yw;
                Assert.AreEqual(new Complex(-4d, 4d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(3.5d, 9d), new Complex(4d, 3d), new Complex(9d, 7d), new Complex(-6.5d, 7d));
                var v = ov.swizzle.ywx;
                Assert.AreEqual(new Complex(4d, 3d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 7d), v.y);
                Assert.AreEqual(new Complex(3.5d, 9d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-7d, 0.0), new Complex(-8.5d, 8d), new Complex(3.5d, -5d), new Complex(3.5d, -5.5d));
                var v = ov.swizzle.ywxx;
                Assert.AreEqual(new Complex(-8.5d, 8d), v.x);
                Assert.AreEqual(new Complex(3.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 0.0), v.z);
                Assert.AreEqual(new Complex(-7d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, -6d), new Complex(5d, 5.5d), new Complex(6d, -5d), new Complex(7.5d, -8d));
                var v = ov.swizzle.ywxy;
                Assert.AreEqual(new Complex(5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -6d), v.z);
                Assert.AreEqual(new Complex(5d, 5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8d, -7d), new Complex(2d, 3d), new Complex(0.5d, 0.5d), new Complex(2d, -6.5d));
                var v = ov.swizzle.ywxz;
                Assert.AreEqual(new Complex(2d, 3d), v.x);
                Assert.AreEqual(new Complex(2d, -6.5d), v.y);
                Assert.AreEqual(new Complex(8d, -7d), v.z);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, 1.0), new Complex(5.5d, -6d), new Complex(-5.5d, -3d), new Complex(1.0, -5.5d));
                var v = ov.swizzle.ywxw;
                Assert.AreEqual(new Complex(5.5d, -6d), v.x);
                Assert.AreEqual(new Complex(1.0, -5.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(1.0, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 0.0), new Complex(-2.5d, -6d), new Complex(-4.5d, -3d), new Complex(-5d, -4d));
                var v = ov.swizzle.ywy;
                Assert.AreEqual(new Complex(-2.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-5d, -4d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(8d, -5d), new Complex(-6d, 6.5d), new Complex(9.5d, -5.5d), new Complex(-8d, -7.5d));
                var v = ov.swizzle.ywyx;
                Assert.AreEqual(new Complex(-6d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 6.5d), v.z);
                Assert.AreEqual(new Complex(8d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8d, 0.5d), new Complex(5.5d, -5d), new Complex(7.5d, -3d), new Complex(9d, -4d));
                var v = ov.swizzle.ywyy;
                Assert.AreEqual(new Complex(5.5d, -5d), v.x);
                Assert.AreEqual(new Complex(9d, -4d), v.y);
                Assert.AreEqual(new Complex(5.5d, -5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, -9d), new Complex(-2d, -8d), new Complex(-7d, 0.5d), new Complex(3d, -8.5d));
                var v = ov.swizzle.ywyz;
                Assert.AreEqual(new Complex(-2d, -8d), v.x);
                Assert.AreEqual(new Complex(3d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -8d), v.z);
                Assert.AreEqual(new Complex(-7d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, 6.5d), new Complex(2d, 6d), new Complex(-8.5d, -9d), new Complex(-1.5d, -8d));
                var v = ov.swizzle.ywyw;
                Assert.AreEqual(new Complex(2d, 6d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.y);
                Assert.AreEqual(new Complex(2d, 6d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, 4.5d), new Complex(-1d, 7d), new Complex(-1.5d, 0.5d), new Complex(-9.5d, 0.0));
                var v = ov.swizzle.ywz;
                Assert.AreEqual(new Complex(-1d, 7d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(-1.5d, 0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(3d, -0.5d), new Complex(2.5d, 5.5d), new Complex(-8.5d, 2d), new Complex(5.5d, 6.5d));
                var v = ov.swizzle.ywzx;
                Assert.AreEqual(new Complex(2.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 2d), v.z);
                Assert.AreEqual(new Complex(3d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -3.5d), new Complex(0.5d, -5.5d), new Complex(-1.5d, 8.5d), new Complex(7d, 4.5d));
                var v = ov.swizzle.ywzy;
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(7d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, 2.5d), new Complex(1.0, 8d), new Complex(9.5d, -4d), new Complex(5d, 1.5d));
                var v = ov.swizzle.ywzz;
                Assert.AreEqual(new Complex(1.0, 8d), v.x);
                Assert.AreEqual(new Complex(5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -4d), v.z);
                Assert.AreEqual(new Complex(9.5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, 0.5d), new Complex(4.5d, 4.5d), new Complex(-4d, 1.5d), new Complex(0.0, 1.0));
                var v = ov.swizzle.ywzw;
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 1.0), v.y);
                Assert.AreEqual(new Complex(-4d, 1.5d), v.z);
                Assert.AreEqual(new Complex(0.0, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -4.5d), new Complex(-5d, 1.5d), new Complex(-5.5d, 1.5d), new Complex(1.5d, 0.0));
                var v = ov.swizzle.yww;
                Assert.AreEqual(new Complex(-5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(1.5d, 0.0), v.z);
            }
            {
                var ov = new cvec4(new Complex(8d, -6.5d), new Complex(7.5d, 1.0), new Complex(-5.5d, 6.5d), new Complex(6.5d, 8.5d));
                var v = ov.swizzle.ywwx;
                Assert.AreEqual(new Complex(7.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(6.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(8d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -3d), new Complex(-2.5d, 6d), new Complex(8d, -3.5d), new Complex(5.5d, 2.5d));
                var v = ov.swizzle.ywwy;
                Assert.AreEqual(new Complex(-2.5d, 6d), v.x);
                Assert.AreEqual(new Complex(5.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, 5.5d), new Complex(5.5d, 5.5d), new Complex(3d, -0.5d), new Complex(-5d, 1.5d));
                var v = ov.swizzle.ywwz;
                Assert.AreEqual(new Complex(5.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(3d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, -3.5d), new Complex(5d, 9d), new Complex(-1d, -7.5d), new Complex(-6d, -9d));
                var v = ov.swizzle.ywww;
                Assert.AreEqual(new Complex(5d, 9d), v.x);
                Assert.AreEqual(new Complex(-6d, -9d), v.y);
                Assert.AreEqual(new Complex(-6d, -9d), v.z);
                Assert.AreEqual(new Complex(-6d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 3.5d), new Complex(3d, -3.5d), new Complex(1.0, 4.5d), new Complex(-9d, 6d));
                var v = ov.swizzle.zx;
                Assert.AreEqual(new Complex(1.0, 4.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 3.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(6d, -5d), new Complex(-0.5d, -7d), new Complex(-9.5d, -8.5d), new Complex(-2d, 8d));
                var v = ov.swizzle.zxx;
                Assert.AreEqual(new Complex(-9.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(6d, -5d), v.y);
                Assert.AreEqual(new Complex(6d, -5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-3d, 4d), new Complex(-1d, 7.5d), new Complex(-5.5d, 0.5d), new Complex(9.5d, 2d));
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(new Complex(-5.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-3d, 4d), v.y);
                Assert.AreEqual(new Complex(-3d, 4d), v.z);
                Assert.AreEqual(new Complex(-3d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, -6d), new Complex(-8.5d, -5d), new Complex(6d, 0.5d), new Complex(-6.5d, 1.0));
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(new Complex(6d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -6d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, -7d), new Complex(7.5d, -0.5d), new Complex(-1d, -6d), new Complex(6d, -1.5d));
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(new Complex(-1d, -6d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -7d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-1d, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7d, 7.5d), new Complex(-5.5d, 3d), new Complex(-1d, -8.5d), new Complex(-0.5d, -9d));
                var v = ov.swizzle.zxxw;
                Assert.AreEqual(new Complex(-1d, -8.5d), v.x);
                Assert.AreEqual(new Complex(7d, 7.5d), v.y);
                Assert.AreEqual(new Complex(7d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, 5.5d), new Complex(3.5d, 5d), new Complex(3.5d, 9.5d), new Complex(3.5d, 7.5d));
                var v = ov.swizzle.zxy;
                Assert.AreEqual(new Complex(3.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(7.5d, -9d), new Complex(-5.5d, -8.5d), new Complex(7d, 4d), new Complex(-4d, -9d));
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(new Complex(7d, 4d), v.x);
                Assert.AreEqual(new Complex(7.5d, -9d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 9d), new Complex(8.5d, -2d), new Complex(4d, 8d), new Complex(-7d, 6.5d));
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(new Complex(4d, 8d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 9d), v.y);
                Assert.AreEqual(new Complex(8.5d, -2d), v.z);
                Assert.AreEqual(new Complex(8.5d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, 5.5d), new Complex(5d, -7.5d), new Complex(-5.5d, -5.5d), new Complex(-9.5d, 5d));
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(new Complex(-5.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-3d, 5.5d), v.y);
                Assert.AreEqual(new Complex(5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, -8d), new Complex(-3d, -4.5d), new Complex(-5.5d, 2.5d), new Complex(-4d, -4d));
                var v = ov.swizzle.zxyw;
                Assert.AreEqual(new Complex(-5.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -8d), v.y);
                Assert.AreEqual(new Complex(-3d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, -4d), new Complex(9d, -6.5d), new Complex(7d, -5d), new Complex(3.5d, -9.5d));
                var v = ov.swizzle.zxz;
                Assert.AreEqual(new Complex(7d, -5d), v.x);
                Assert.AreEqual(new Complex(2d, -4d), v.y);
                Assert.AreEqual(new Complex(7d, -5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, 2d), new Complex(-8.5d, -1.5d), new Complex(-0.5d, -5d), new Complex(0.0, 5.5d));
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(new Complex(-0.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, 4.5d), new Complex(3d, 2.5d), new Complex(7d, -9.5d), new Complex(-2d, -2.5d));
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(new Complex(7d, -9.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(7d, -9.5d), v.z);
                Assert.AreEqual(new Complex(3d, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, 4d), new Complex(-3d, -5d), new Complex(7.5d, -1d), new Complex(-4d, 9d));
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(new Complex(7.5d, -1d), v.x);
                Assert.AreEqual(new Complex(3.5d, 4d), v.y);
                Assert.AreEqual(new Complex(7.5d, -1d), v.z);
                Assert.AreEqual(new Complex(7.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -7d), new Complex(-3.5d, -5.5d), new Complex(-4d, 0.5d), new Complex(-1.5d, -6.5d));
                var v = ov.swizzle.zxzw;
                Assert.AreEqual(new Complex(-4d, 0.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -7d), v.y);
                Assert.AreEqual(new Complex(-4d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, 0.5d), new Complex(-1d, 9d), new Complex(-5d, 0.5d), new Complex(0.5d, 3d));
                var v = ov.swizzle.zxw;
                Assert.AreEqual(new Complex(-5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(3d, 0.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-7d, 4d), new Complex(-0.5d, 4.5d), new Complex(9d, 4d), new Complex(-9.5d, 2.5d));
                var v = ov.swizzle.zxwx;
                Assert.AreEqual(new Complex(9d, 4d), v.x);
                Assert.AreEqual(new Complex(-7d, 4d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, 3d), new Complex(1.5d, 9d), new Complex(0.5d, 9d), new Complex(5.5d, -2d));
                var v = ov.swizzle.zxwy;
                Assert.AreEqual(new Complex(0.5d, 9d), v.x);
                Assert.AreEqual(new Complex(-4d, 3d), v.y);
                Assert.AreEqual(new Complex(5.5d, -2d), v.z);
                Assert.AreEqual(new Complex(1.5d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -2d), new Complex(7.5d, 7d), new Complex(-2.5d, 2d), new Complex(-2d, 9d));
                var v = ov.swizzle.zxwz;
                Assert.AreEqual(new Complex(-2.5d, 2d), v.x);
                Assert.AreEqual(new Complex(9.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-2d, 9d), v.z);
                Assert.AreEqual(new Complex(-2.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -1.5d), new Complex(0.0, -7d), new Complex(4d, 3.5d), new Complex(-6d, -0.5d));
                var v = ov.swizzle.zxww;
                Assert.AreEqual(new Complex(4d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-6d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 6d), new Complex(6d, 7d), new Complex(-9d, -4.5d), new Complex(-9.5d, -6d));
                var v = ov.swizzle.zy;
                Assert.AreEqual(new Complex(-9d, -4.5d), v.x);
                Assert.AreEqual(new Complex(6d, 7d), v.y);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -0.5d), new Complex(2.5d, -8.5d), new Complex(-5.5d, 2.5d), new Complex(0.0, -8d));
                var v = ov.swizzle.zyx;
                Assert.AreEqual(new Complex(-5.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(8d, -2d), new Complex(-1d, -3d), new Complex(-5.5d, -0.5d), new Complex(0.5d, 4.5d));
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(new Complex(-5.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-1d, -3d), v.y);
                Assert.AreEqual(new Complex(8d, -2d), v.z);
                Assert.AreEqual(new Complex(8d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, 5.5d), new Complex(6.5d, 9d), new Complex(9d, -7.5d), new Complex(2.5d, 4d));
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(new Complex(9d, -7.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 9d), v.y);
                Assert.AreEqual(new Complex(8.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, 3.5d), new Complex(-8d, -2d), new Complex(-7d, -4d), new Complex(9.5d, 7d));
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(new Complex(-7d, -4d), v.x);
                Assert.AreEqual(new Complex(-8d, -2d), v.y);
                Assert.AreEqual(new Complex(4.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-7d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -8.5d), new Complex(8d, -9.5d), new Complex(-2.5d, 2.5d), new Complex(3d, -7.5d));
                var v = ov.swizzle.zyxw;
                Assert.AreEqual(new Complex(-2.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(8d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -8.5d), v.z);
                Assert.AreEqual(new Complex(3d, -7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, -7.5d), new Complex(-3d, 8d), new Complex(-3d, -6d), new Complex(5.5d, 7.5d));
                var v = ov.swizzle.zyy;
                Assert.AreEqual(new Complex(-3d, -6d), v.x);
                Assert.AreEqual(new Complex(-3d, 8d), v.y);
                Assert.AreEqual(new Complex(-3d, 8d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, -2d), new Complex(-4.5d, 8.5d), new Complex(-1.5d, -8.5d), new Complex(4.5d, 7.5d));
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(new Complex(-1.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -0.5d), new Complex(8.5d, 0.0), new Complex(3.5d, -6d), new Complex(7.5d, -7.5d));
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(new Complex(3.5d, -6d), v.x);
                Assert.AreEqual(new Complex(8.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(8.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(8.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, -4.5d), new Complex(5.5d, -4d), new Complex(9.5d, -4d), new Complex(-5.5d, -6.5d));
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(new Complex(9.5d, -4d), v.x);
                Assert.AreEqual(new Complex(5.5d, -4d), v.y);
                Assert.AreEqual(new Complex(5.5d, -4d), v.z);
                Assert.AreEqual(new Complex(9.5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5d, 0.0), new Complex(8d, -4.5d), new Complex(-2d, -8d), new Complex(2d, -1.5d));
                var v = ov.swizzle.zyyw;
                Assert.AreEqual(new Complex(-2d, -8d), v.x);
                Assert.AreEqual(new Complex(8d, -4.5d), v.y);
                Assert.AreEqual(new Complex(8d, -4.5d), v.z);
                Assert.AreEqual(new Complex(2d, -1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, -9d), new Complex(9.5d, -6d), new Complex(6.5d, -6d), new Complex(2d, 9.5d));
                var v = ov.swizzle.zyz;
                Assert.AreEqual(new Complex(6.5d, -6d), v.x);
                Assert.AreEqual(new Complex(9.5d, -6d), v.y);
                Assert.AreEqual(new Complex(6.5d, -6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, -5.5d), new Complex(4.5d, 7.5d), new Complex(-7d, -7d), new Complex(7d, -4d));
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(new Complex(-7d, -7d), v.x);
                Assert.AreEqual(new Complex(4.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-7d, -7d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 3d), new Complex(5d, -4.5d), new Complex(4d, 5d), new Complex(-3.5d, -5.5d));
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(new Complex(4d, 5d), v.x);
                Assert.AreEqual(new Complex(5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(4d, 5d), v.z);
                Assert.AreEqual(new Complex(5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, -6d), new Complex(-6d, 0.0), new Complex(5d, 2.5d), new Complex(-8d, -9d));
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(new Complex(5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-6d, 0.0), v.y);
                Assert.AreEqual(new Complex(5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(5d, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, 2d), new Complex(-1.5d, 4.5d), new Complex(-5d, 5d), new Complex(-6.5d, -3d));
                var v = ov.swizzle.zyzw;
                Assert.AreEqual(new Complex(-5d, 5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 1.5d), new Complex(-0.5d, 1.5d), new Complex(9d, 2d), new Complex(0.0, 3.5d));
                var v = ov.swizzle.zyw;
                Assert.AreEqual(new Complex(9d, 2d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 3.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(2d, 1.5d), new Complex(-2d, 9.5d), new Complex(0.0, -8d), new Complex(9.5d, -9d));
                var v = ov.swizzle.zywx;
                Assert.AreEqual(new Complex(0.0, -8d), v.x);
                Assert.AreEqual(new Complex(-2d, 9.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -9d), v.z);
                Assert.AreEqual(new Complex(2d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8d, 8.5d), new Complex(2.5d, 0.5d), new Complex(4.5d, 5d), new Complex(2d, 4.5d));
                var v = ov.swizzle.zywy;
                Assert.AreEqual(new Complex(4.5d, 5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(2d, 4.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, 2d), new Complex(-4.5d, 1.0), new Complex(7.5d, 3d), new Complex(-5d, 6d));
                var v = ov.swizzle.zywz;
                Assert.AreEqual(new Complex(7.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-5d, 6d), v.z);
                Assert.AreEqual(new Complex(7.5d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, 2.5d), new Complex(9d, -5d), new Complex(8d, -1d), new Complex(1.5d, -5d));
                var v = ov.swizzle.zyww;
                Assert.AreEqual(new Complex(8d, -1d), v.x);
                Assert.AreEqual(new Complex(9d, -5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -5d), v.z);
                Assert.AreEqual(new Complex(1.5d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8d, -9.5d), new Complex(-8.5d, 4d), new Complex(-1d, 2.5d), new Complex(-6d, 2d));
                var v = ov.swizzle.zz;
                Assert.AreEqual(new Complex(-1d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 2.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(3.5d, 2.5d), new Complex(6d, 0.5d), new Complex(-9d, 4d), new Complex(-6d, -7.5d));
                var v = ov.swizzle.zzx;
                Assert.AreEqual(new Complex(-9d, 4d), v.x);
                Assert.AreEqual(new Complex(-9d, 4d), v.y);
                Assert.AreEqual(new Complex(3.5d, 2.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, -9.5d), new Complex(-8.5d, 2.5d), new Complex(4d, -9d), new Complex(-7d, 5d));
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(new Complex(4d, -9d), v.x);
                Assert.AreEqual(new Complex(4d, -9d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -9d), new Complex(-0.5d, 5d), new Complex(-9.5d, 7.5d), new Complex(-7d, -2.5d));
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(new Complex(-9.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -9d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -1d), new Complex(5.5d, -8.5d), new Complex(0.0, 6d), new Complex(-5d, -6.5d));
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(new Complex(0.0, 6d), v.x);
                Assert.AreEqual(new Complex(0.0, 6d), v.y);
                Assert.AreEqual(new Complex(0.5d, -1d), v.z);
                Assert.AreEqual(new Complex(0.0, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -8d), new Complex(-7d, 7.5d), new Complex(-0.5d, -6d), new Complex(1.5d, -4d));
                var v = ov.swizzle.zzxw;
                Assert.AreEqual(new Complex(-0.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -6d), v.y);
                Assert.AreEqual(new Complex(4.5d, -8d), v.z);
                Assert.AreEqual(new Complex(1.5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -9d), new Complex(1.0, 9d), new Complex(-0.5d, -7.5d), new Complex(4.5d, -4d));
                var v = ov.swizzle.zzy;
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 9d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-8d, 7.5d), new Complex(1.5d, -4.5d), new Complex(1.0, -4.5d), new Complex(9d, -3.5d));
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(new Complex(1.0, -4.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -4.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -7.5d), new Complex(-6.5d, 1.5d), new Complex(-4d, 0.5d), new Complex(1.0, -5.5d));
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(new Complex(-4d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-4d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8d, 7.5d), new Complex(4.5d, 0.0), new Complex(7d, 0.0), new Complex(6.5d, 1.0));
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(new Complex(7d, 0.0), v.x);
                Assert.AreEqual(new Complex(7d, 0.0), v.y);
                Assert.AreEqual(new Complex(4.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(7d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, 4.5d), new Complex(-5.5d, 6.5d), new Complex(9d, 6.5d), new Complex(7.5d, 5d));
                var v = ov.swizzle.zzyw;
                Assert.AreEqual(new Complex(9d, 6.5d), v.x);
                Assert.AreEqual(new Complex(9d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 8d), new Complex(-7d, 8.5d), new Complex(8d, -6d), new Complex(7d, 4.5d));
                var v = ov.swizzle.zzz;
                Assert.AreEqual(new Complex(8d, -6d), v.x);
                Assert.AreEqual(new Complex(8d, -6d), v.y);
                Assert.AreEqual(new Complex(8d, -6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(4d, 2d), new Complex(-9.5d, -4d), new Complex(-5.5d, 5.5d), new Complex(-8.5d, -1d));
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(4d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, 5d), new Complex(3.5d, -1.5d), new Complex(6.5d, 6.5d), new Complex(1.5d, -7.5d));
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(new Complex(6.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, -0.5d), new Complex(-9.5d, -8d), new Complex(3d, -8.5d), new Complex(2.5d, -8.5d));
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(new Complex(3d, -8.5d), v.x);
                Assert.AreEqual(new Complex(3d, -8.5d), v.y);
                Assert.AreEqual(new Complex(3d, -8.5d), v.z);
                Assert.AreEqual(new Complex(3d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8d, 7d), new Complex(-5.5d, 0.5d), new Complex(7.5d, -4.5d), new Complex(7.5d, 4.5d));
                var v = ov.swizzle.zzzw;
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, 5d), new Complex(4.5d, 2.5d), new Complex(6.5d, -5.5d), new Complex(-1d, -3.5d));
                var v = ov.swizzle.zzw;
                Assert.AreEqual(new Complex(6.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -3.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-5d, -4d), new Complex(-9d, -1d), new Complex(8.5d, 0.5d), new Complex(6.5d, -1d));
                var v = ov.swizzle.zzwx;
                Assert.AreEqual(new Complex(8.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, -9d), new Complex(4d, 5d), new Complex(-8.5d, -1.5d), new Complex(9d, -9.5d));
                var v = ov.swizzle.zzwy;
                Assert.AreEqual(new Complex(-8.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(9d, -9.5d), v.z);
                Assert.AreEqual(new Complex(4d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 9.5d), new Complex(2.5d, 9d), new Complex(3d, 2d), new Complex(4.5d, -8.5d));
                var v = ov.swizzle.zzwz;
                Assert.AreEqual(new Complex(3d, 2d), v.x);
                Assert.AreEqual(new Complex(3d, 2d), v.y);
                Assert.AreEqual(new Complex(4.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(3d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2.5d, 4.5d), new Complex(-8.5d, -3.5d), new Complex(0.5d, 9d), new Complex(8.5d, -6.5d));
                var v = ov.swizzle.zzww;
                Assert.AreEqual(new Complex(0.5d, 9d), v.x);
                Assert.AreEqual(new Complex(0.5d, 9d), v.y);
                Assert.AreEqual(new Complex(8.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, -1.5d), new Complex(-8.5d, -4d), new Complex(0.0, -8d), new Complex(-3.5d, 3.5d));
                var v = ov.swizzle.zw;
                Assert.AreEqual(new Complex(0.0, -8d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 3.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 4.5d), new Complex(-6.5d, 8d), new Complex(9d, 5.5d), new Complex(8.5d, -9d));
                var v = ov.swizzle.zwx;
                Assert.AreEqual(new Complex(9d, 5.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -9d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 4.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -7d), new Complex(-5d, -9.5d), new Complex(-8d, 1.5d), new Complex(9d, 2d));
                var v = ov.swizzle.zwxx;
                Assert.AreEqual(new Complex(-8d, 1.5d), v.x);
                Assert.AreEqual(new Complex(9d, 2d), v.y);
                Assert.AreEqual(new Complex(0.5d, -7d), v.z);
                Assert.AreEqual(new Complex(0.5d, -7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, -1d), new Complex(-3d, 1.0), new Complex(-7d, 8.5d), new Complex(3.5d, -6d));
                var v = ov.swizzle.zwxy;
                Assert.AreEqual(new Complex(-7d, 8.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-3d, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -4d), new Complex(7.5d, 0.5d), new Complex(3.5d, -8.5d), new Complex(-4.5d, 2.5d));
                var v = ov.swizzle.zwxz;
                Assert.AreEqual(new Complex(3.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -4d), v.z);
                Assert.AreEqual(new Complex(3.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -5.5d), new Complex(-1.5d, -5.5d), new Complex(2.5d, 2.5d), new Complex(4d, 8.5d));
                var v = ov.swizzle.zwxw;
                Assert.AreEqual(new Complex(2.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(4d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(4d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 8.5d), new Complex(-2.5d, -5d), new Complex(-5.5d, -8.5d), new Complex(9.5d, -9d));
                var v = ov.swizzle.zwy;
                Assert.AreEqual(new Complex(-5.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -9d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-7d, -3d), new Complex(9d, 0.0), new Complex(9.5d, -3.5d), new Complex(6.5d, -7.5d));
                var v = ov.swizzle.zwyx;
                Assert.AreEqual(new Complex(9.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(9d, 0.0), v.z);
                Assert.AreEqual(new Complex(-7d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -8.5d), new Complex(9.5d, 1.0), new Complex(1.5d, 4d), new Complex(8.5d, 1.5d));
                var v = ov.swizzle.zwyy;
                Assert.AreEqual(new Complex(1.5d, 4d), v.x);
                Assert.AreEqual(new Complex(8.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(9.5d, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -3d), new Complex(9d, -0.5d), new Complex(-5.5d, 1.5d), new Complex(2.5d, 5d));
                var v = ov.swizzle.zwyz;
                Assert.AreEqual(new Complex(-5.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 5d), v.y);
                Assert.AreEqual(new Complex(9d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8d, -3d), new Complex(0.0, 8d), new Complex(5d, 2.5d), new Complex(-3d, 6.5d));
                var v = ov.swizzle.zwyw;
                Assert.AreEqual(new Complex(5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-3d, 6.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 8d), v.z);
                Assert.AreEqual(new Complex(-3d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, -4d), new Complex(-2d, -5.5d), new Complex(-6.5d, 8d), new Complex(4.5d, 7.5d));
                var v = ov.swizzle.zwz;
                Assert.AreEqual(new Complex(-6.5d, 8d), v.x);
                Assert.AreEqual(new Complex(4.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 8d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-5d, 9d), new Complex(9d, -3.5d), new Complex(-4d, 4d), new Complex(5.5d, 4d));
                var v = ov.swizzle.zwzx;
                Assert.AreEqual(new Complex(-4d, 4d), v.x);
                Assert.AreEqual(new Complex(5.5d, 4d), v.y);
                Assert.AreEqual(new Complex(-4d, 4d), v.z);
                Assert.AreEqual(new Complex(-5d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 5d), new Complex(4d, -5d), new Complex(-7d, 7.5d), new Complex(-9d, 3d));
                var v = ov.swizzle.zwzy;
                Assert.AreEqual(new Complex(-7d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-9d, 3d), v.y);
                Assert.AreEqual(new Complex(-7d, 7.5d), v.z);
                Assert.AreEqual(new Complex(4d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, -7.5d), new Complex(5.5d, -9.5d), new Complex(-4d, 3.5d), new Complex(9.5d, -9.5d));
                var v = ov.swizzle.zwzz;
                Assert.AreEqual(new Complex(-4d, 3.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-4d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-4d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, -2.5d), new Complex(-1d, -7d), new Complex(-7.5d, 3d), new Complex(-8.5d, -4d));
                var v = ov.swizzle.zwzw;
                Assert.AreEqual(new Complex(-7.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 3.5d), new Complex(-7.5d, 9d), new Complex(-5d, -8.5d), new Complex(-1.5d, 8d));
                var v = ov.swizzle.zww;
                Assert.AreEqual(new Complex(-5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 8d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 8d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, 7.5d), new Complex(-9d, 6d), new Complex(9.5d, 3d), new Complex(-1d, -6.5d));
                var v = ov.swizzle.zwwx;
                Assert.AreEqual(new Complex(9.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-1d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, 6.5d), new Complex(1.0, -4d), new Complex(-7d, -7d), new Complex(-8.5d, -3d));
                var v = ov.swizzle.zwwy;
                Assert.AreEqual(new Complex(-7d, -7d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -3d), v.z);
                Assert.AreEqual(new Complex(1.0, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 0.5d), new Complex(-9d, 3.5d), new Complex(-9d, -4.5d), new Complex(0.0, -2d));
                var v = ov.swizzle.zwwz;
                Assert.AreEqual(new Complex(-9d, -4.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -2d), v.y);
                Assert.AreEqual(new Complex(0.0, -2d), v.z);
                Assert.AreEqual(new Complex(-9d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, 3d), new Complex(-0.5d, -6.5d), new Complex(-4.5d, 6d), new Complex(6d, -4.5d));
                var v = ov.swizzle.zwww;
                Assert.AreEqual(new Complex(-4.5d, 6d), v.x);
                Assert.AreEqual(new Complex(6d, -4.5d), v.y);
                Assert.AreEqual(new Complex(6d, -4.5d), v.z);
                Assert.AreEqual(new Complex(6d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 6.5d), new Complex(4d, -9.5d), new Complex(8d, -4d), new Complex(0.5d, 3d));
                var v = ov.swizzle.wx;
                Assert.AreEqual(new Complex(0.5d, 3d), v.x);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 2d), new Complex(-2d, 8.5d), new Complex(-1d, 7d), new Complex(8.5d, 3.5d));
                var v = ov.swizzle.wxx;
                Assert.AreEqual(new Complex(8.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 2d), v.z);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 6.5d), new Complex(-4.5d, -1d), new Complex(3.5d, -8d), new Complex(7.5d, 6.5d));
                var v = ov.swizzle.wxxx;
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, 4d), new Complex(-4.5d, -8d), new Complex(8.5d, 3d), new Complex(4d, 2d));
                var v = ov.swizzle.wxxy;
                Assert.AreEqual(new Complex(4d, 2d), v.x);
                Assert.AreEqual(new Complex(-9d, 4d), v.y);
                Assert.AreEqual(new Complex(-9d, 4d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, 2d), new Complex(4.5d, 9.5d), new Complex(-3d, 8.5d), new Complex(6.5d, 2d));
                var v = ov.swizzle.wxxz;
                Assert.AreEqual(new Complex(6.5d, 2d), v.x);
                Assert.AreEqual(new Complex(7.5d, 2d), v.y);
                Assert.AreEqual(new Complex(7.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-3d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, -6.5d), new Complex(2d, -9d), new Complex(-7.5d, 5d), new Complex(-3.5d, 0.5d));
                var v = ov.swizzle.wxxw;
                Assert.AreEqual(new Complex(-3.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-1d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 7.5d), new Complex(6.5d, -5.5d), new Complex(6.5d, -4d), new Complex(8d, -3.5d));
                var v = ov.swizzle.wxy;
                Assert.AreEqual(new Complex(8d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -5.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6d, 3.5d), new Complex(-4d, -9d), new Complex(5.5d, -4d), new Complex(9d, 2d));
                var v = ov.swizzle.wxyx;
                Assert.AreEqual(new Complex(9d, 2d), v.x);
                Assert.AreEqual(new Complex(-6d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-4d, -9d), v.z);
                Assert.AreEqual(new Complex(-6d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 9d), new Complex(-5d, -7d), new Complex(-4.5d, -8d), new Complex(-1d, -1d));
                var v = ov.swizzle.wxyy;
                Assert.AreEqual(new Complex(-1d, -1d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 9d), v.y);
                Assert.AreEqual(new Complex(-5d, -7d), v.z);
                Assert.AreEqual(new Complex(-5d, -7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, 3.5d), new Complex(-4.5d, -7d), new Complex(6d, 4d), new Complex(8d, 6.5d));
                var v = ov.swizzle.wxyz;
                Assert.AreEqual(new Complex(8d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-3d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -7d), v.z);
                Assert.AreEqual(new Complex(6d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7d, 7.5d), new Complex(0.0, 8d), new Complex(-5d, -2.5d), new Complex(-1.5d, -3.5d));
                var v = ov.swizzle.wxyw;
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(7d, 7.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 8d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7d, 5.5d), new Complex(-9d, -8.5d), new Complex(2d, 6d), new Complex(7.5d, -2d));
                var v = ov.swizzle.wxz;
                Assert.AreEqual(new Complex(7.5d, -2d), v.x);
                Assert.AreEqual(new Complex(7d, 5.5d), v.y);
                Assert.AreEqual(new Complex(2d, 6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, 0.5d), new Complex(-5d, -8.5d), new Complex(3d, 8d), new Complex(9d, 3d));
                var v = ov.swizzle.wxzx;
                Assert.AreEqual(new Complex(9d, 3d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(3d, 8d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -6.5d), new Complex(-0.5d, 3d), new Complex(6.5d, 2d), new Complex(3.5d, -5d));
                var v = ov.swizzle.wxzy;
                Assert.AreEqual(new Complex(3.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-6d, -6.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -5d), new Complex(-7.5d, -5.5d), new Complex(2d, 4d), new Complex(-4.5d, -9d));
                var v = ov.swizzle.wxzz;
                Assert.AreEqual(new Complex(-4.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -5d), v.y);
                Assert.AreEqual(new Complex(2d, 4d), v.z);
                Assert.AreEqual(new Complex(2d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -5.5d), new Complex(1.0, -9.5d), new Complex(-7.5d, 7.5d), new Complex(-7.5d, -5d));
                var v = ov.swizzle.wxzw;
                Assert.AreEqual(new Complex(-7.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-6d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, 7.5d), new Complex(-5.5d, -3d), new Complex(-2d, -5.5d), new Complex(3d, -3.5d));
                var v = ov.swizzle.wxw;
                Assert.AreEqual(new Complex(3d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(3d, -3.5d), v.z);
            }
            {
                var ov = new cvec4(Complex.Zero, new Complex(-2.5d, 0.5d), new Complex(1.5d, 8d), new Complex(-2d, -5.5d));
                var v = ov.swizzle.wxwx;
                Assert.AreEqual(new Complex(-2d, -5.5d), v.x);
                Assert.AreEqual(Complex.Zero, v.y);
                Assert.AreEqual(new Complex(-2d, -5.5d), v.z);
                Assert.AreEqual(Complex.Zero, v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 3.5d), new Complex(3d, 9.5d), new Complex(-1.5d, 3d), new Complex(-1d, -2d));
                var v = ov.swizzle.wxwy;
                Assert.AreEqual(new Complex(-1d, -2d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -2d), v.z);
                Assert.AreEqual(new Complex(3d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 1.5d), new Complex(3.5d, -9.5d), new Complex(-8d, 2.5d), new Complex(8d, -5d));
                var v = ov.swizzle.wxwz;
                Assert.AreEqual(new Complex(8d, -5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(8d, -5d), v.z);
                Assert.AreEqual(new Complex(-8d, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -6d), new Complex(9.5d, 2d), new Complex(-2.5d, 5.5d), new Complex(1.0, -1d));
                var v = ov.swizzle.wxww;
                Assert.AreEqual(new Complex(1.0, -1d), v.x);
                Assert.AreEqual(new Complex(4.5d, -6d), v.y);
                Assert.AreEqual(new Complex(1.0, -1d), v.z);
                Assert.AreEqual(new Complex(1.0, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, 7d), new Complex(-3.5d, 7d), new Complex(3.5d, -9d), new Complex(7.5d, 5d));
                var v = ov.swizzle.wy;
                Assert.AreEqual(new Complex(7.5d, 5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 7d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-9d, -5d), new Complex(2.5d, 2d), new Complex(-2.5d, 6.5d), new Complex(1.5d, 8d));
                var v = ov.swizzle.wyx;
                Assert.AreEqual(new Complex(1.5d, 8d), v.x);
                Assert.AreEqual(new Complex(2.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-9d, -5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -1d), new Complex(-8.5d, -3.5d), new Complex(3.5d, -3d), new Complex(6d, -6d));
                var v = ov.swizzle.wyxx;
                Assert.AreEqual(new Complex(6d, -6d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -1d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8d, -1d), new Complex(3.5d, -2d), new Complex(8.5d, -1.5d), new Complex(-5.5d, -6.5d));
                var v = ov.swizzle.wyxy;
                Assert.AreEqual(new Complex(-5.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-8d, -1d), v.z);
                Assert.AreEqual(new Complex(3.5d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 5.5d), new Complex(8.5d, -9.5d), new Complex(7.5d, -1d), new Complex(4.5d, 0.0));
                var v = ov.swizzle.wyxz;
                Assert.AreEqual(new Complex(4.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(8.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(6d, 5.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, -2d), new Complex(1.5d, -4.5d), new Complex(-8.5d, -1d), new Complex(-2d, -7.5d));
                var v = ov.swizzle.wyxw;
                Assert.AreEqual(new Complex(-2d, -7.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-2d, -7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, 8.5d), new Complex(-4.5d, -1.5d), new Complex(5d, -7.5d), new Complex(-0.5d, 5.5d));
                var v = ov.swizzle.wyy;
                Assert.AreEqual(new Complex(-0.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -1.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(3d, 0.5d), new Complex(3.5d, 0.5d), new Complex(1.5d, 2d), new Complex(-7d, -8.5d));
                var v = ov.swizzle.wyyx;
                Assert.AreEqual(new Complex(-7d, -8.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(3d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, -5.5d), new Complex(-8.5d, -4.5d), new Complex(-2d, 5d), new Complex(3d, -2.5d));
                var v = ov.swizzle.wyyy;
                Assert.AreEqual(new Complex(3d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, 3.5d), new Complex(-5d, -8d), new Complex(-4.5d, -1d), new Complex(7d, 6.5d));
                var v = ov.swizzle.wyyz;
                Assert.AreEqual(new Complex(7d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-5d, -8d), v.y);
                Assert.AreEqual(new Complex(-5d, -8d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, 3.5d), new Complex(9.5d, 9.5d), new Complex(-0.5d, -4d), new Complex(7d, 5d));
                var v = ov.swizzle.wyyw;
                Assert.AreEqual(new Complex(7d, 5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(7d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, -3.5d), new Complex(-8.5d, -3.5d), new Complex(3.5d, 0.0), new Complex(4.5d, -9d));
                var v = ov.swizzle.wyz;
                Assert.AreEqual(new Complex(4.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 0.0), v.z);
            }
            {
                var ov = new cvec4(new Complex(4.5d, 1.5d), new Complex(4.5d, 9d), new Complex(1.0, -7d), new Complex(5.5d, 5.5d));
                var v = ov.swizzle.wyzx;
                Assert.AreEqual(new Complex(5.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, 9d), v.y);
                Assert.AreEqual(new Complex(1.0, -7d), v.z);
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 0.5d), new Complex(3.5d, 5.5d), new Complex(-7d, 8.5d), new Complex(-9d, -7.5d));
                var v = ov.swizzle.wyzy;
                Assert.AreEqual(new Complex(-9d, -7.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 8.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, 5.5d), new Complex(-8.5d, 5.5d), new Complex(6.5d, 5d), new Complex(3.5d, -3.5d));
                var v = ov.swizzle.wyzz;
                Assert.AreEqual(new Complex(3.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, -8d), new Complex(8.5d, 1.0), new Complex(-2.5d, -7d), new Complex(-0.5d, -8.5d));
                var v = ov.swizzle.wyzw;
                Assert.AreEqual(new Complex(-0.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-2.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -6.5d), new Complex(-6d, -0.5d), new Complex(2.5d, 1.5d), new Complex(6.5d, -4.5d));
                var v = ov.swizzle.wyw;
                Assert.AreEqual(new Complex(6.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-6d, -0.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -4.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 3d), new Complex(4.5d, 9.5d), new Complex(3.5d, -0.5d), new Complex(2.5d, -7d));
                var v = ov.swizzle.wywx;
                Assert.AreEqual(new Complex(2.5d, -7d), v.x);
                Assert.AreEqual(new Complex(4.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, -7d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, 7d), new Complex(-0.5d, -2d), new Complex(4.5d, 6d), new Complex(-5.5d, -2d));
                var v = ov.swizzle.wywy;
                Assert.AreEqual(new Complex(-5.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, 8d), new Complex(-4d, 2d), new Complex(0.0, 3.5d), new Complex(-9.5d, -3d));
                var v = ov.swizzle.wywz;
                Assert.AreEqual(new Complex(-9.5d, -3d), v.x);
                Assert.AreEqual(new Complex(-4d, 2d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -3d), v.z);
                Assert.AreEqual(new Complex(0.0, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2.5d, -1.5d), new Complex(-2d, 2d), new Complex(5.5d, 3d), new Complex(9d, -9.5d));
                var v = ov.swizzle.wyww;
                Assert.AreEqual(new Complex(9d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-2d, 2d), v.y);
                Assert.AreEqual(new Complex(9d, -9.5d), v.z);
                Assert.AreEqual(new Complex(9d, -9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2.5d, -1d), new Complex(5.5d, 6d), new Complex(-5d, -0.5d), new Complex(-9.5d, -1.5d));
                var v = ov.swizzle.wz;
                Assert.AreEqual(new Complex(-9.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-5d, -0.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(3d, -4.5d), new Complex(2.5d, -5.5d), new Complex(8.5d, 1.5d), new Complex(8d, 6.5d));
                var v = ov.swizzle.wzx;
                Assert.AreEqual(new Complex(8d, 6.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(3d, -4.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-9d, -3d), new Complex(1.5d, -4.5d), new Complex(-7.5d, -8d), new Complex(1.0, 0.5d));
                var v = ov.swizzle.wzxx;
                Assert.AreEqual(new Complex(1.0, 0.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-9d, -3d), v.z);
                Assert.AreEqual(new Complex(-9d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, -9.5d), new Complex(9.5d, 3.5d), new Complex(-7d, -7.5d), new Complex(4.5d, 7.5d));
                var v = ov.swizzle.wzxy;
                Assert.AreEqual(new Complex(4.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-3d, -9.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 4.5d), new Complex(6.5d, -5d), new Complex(-3d, -4d), new Complex(9.5d, 2.5d));
                var v = ov.swizzle.wzxz;
                Assert.AreEqual(new Complex(9.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-3d, -4d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-3d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, -9d), new Complex(9d, 0.0), new Complex(-7.5d, -3.5d), new Complex(-3d, -8d));
                var v = ov.swizzle.wzxw;
                Assert.AreEqual(new Complex(-3d, -8d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -9d), v.z);
                Assert.AreEqual(new Complex(-3d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -0.5d), new Complex(3.5d, -3.5d), new Complex(-7d, -1d), new Complex(1.5d, 2.5d));
                var v = ov.swizzle.wzy;
                Assert.AreEqual(new Complex(1.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -1d), v.y);
                Assert.AreEqual(new Complex(3.5d, -3.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, 0.0), new Complex(-6d, 0.5d), new Complex(0.0, 6.5d), new Complex(-5d, -4d));
                var v = ov.swizzle.wzyx;
                Assert.AreEqual(new Complex(-5d, -4d), v.x);
                Assert.AreEqual(new Complex(0.0, 6.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, 5.5d), new Complex(-7d, 4.5d), new Complex(7.5d, 9d), new Complex(5.5d, -6d));
                var v = ov.swizzle.wzyy;
                Assert.AreEqual(new Complex(5.5d, -6d), v.x);
                Assert.AreEqual(new Complex(7.5d, 9d), v.y);
                Assert.AreEqual(new Complex(-7d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, 7.5d), new Complex(-3d, 0.0), new Complex(2.5d, 8.5d), new Complex(-0.5d, -9.5d));
                var v = ov.swizzle.wzyz;
                Assert.AreEqual(new Complex(-0.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-3d, 0.0), v.z);
                Assert.AreEqual(new Complex(2.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, 7d), new Complex(-5.5d, 1.5d), new Complex(-4d, 1.0), new Complex(-7.5d, -6.5d));
                var v = ov.swizzle.wzyw;
                Assert.AreEqual(new Complex(-7.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-4d, 1.0), v.y);
                Assert.AreEqual(new Complex(-5.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 2.5d), new Complex(2.5d, -5d), new Complex(-1d, -0.5d), new Complex(2d, -6d));
                var v = ov.swizzle.wzz;
                Assert.AreEqual(new Complex(2d, -6d), v.x);
                Assert.AreEqual(new Complex(-1d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -9.5d), new Complex(5d, 5.5d), new Complex(1.5d, -8d), new Complex(6.5d, -3d));
                var v = ov.swizzle.wzzx;
                Assert.AreEqual(new Complex(6.5d, -3d), v.x);
                Assert.AreEqual(new Complex(1.5d, -8d), v.y);
                Assert.AreEqual(new Complex(1.5d, -8d), v.z);
                Assert.AreEqual(new Complex(6.5d, -9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, -0.5d), new Complex(5.5d, -2d), new Complex(8d, 9.5d), new Complex(-6.5d, 7d));
                var v = ov.swizzle.wzzy;
                Assert.AreEqual(new Complex(-6.5d, 7d), v.x);
                Assert.AreEqual(new Complex(8d, 9.5d), v.y);
                Assert.AreEqual(new Complex(8d, 9.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, -9d), new Complex(2d, 9d), new Complex(-9.5d, 9.5d), new Complex(9d, 8.5d));
                var v = ov.swizzle.wzzz;
                Assert.AreEqual(new Complex(9d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -1d), new Complex(6d, 7.5d), new Complex(-1.5d, 5.5d), new Complex(2d, -8.5d));
                var v = ov.swizzle.wzzw;
                Assert.AreEqual(new Complex(2d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(2d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -3.5d), new Complex(7d, 1.0), new Complex(8.5d, 4.5d), new Complex(5.5d, -3.5d));
                var v = ov.swizzle.wzw;
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(2d, -8.5d), new Complex(-7.5d, 5d), new Complex(3.5d, 7.5d), new Complex(-6d, 1.5d));
                var v = ov.swizzle.wzwx;
                Assert.AreEqual(new Complex(-6d, 1.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 1.5d), v.z);
                Assert.AreEqual(new Complex(2d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, -4d), new Complex(-6.5d, 3.5d), new Complex(3d, -7.5d), new Complex(-6d, -1.5d));
                var v = ov.swizzle.wzwy;
                Assert.AreEqual(new Complex(-6d, -1.5d), v.x);
                Assert.AreEqual(new Complex(3d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-6d, -1.5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 9.5d), new Complex(0.0, 0.0), new Complex(5d, -5.5d), new Complex(7d, -2d));
                var v = ov.swizzle.wzwz;
                Assert.AreEqual(new Complex(7d, -2d), v.x);
                Assert.AreEqual(new Complex(5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(7d, -2d), v.z);
                Assert.AreEqual(new Complex(5d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 4.5d), new Complex(-4d, 2.5d), new Complex(5.5d, -3d), new Complex(-5d, 2d));
                var v = ov.swizzle.wzww;
                Assert.AreEqual(new Complex(-5d, 2d), v.x);
                Assert.AreEqual(new Complex(5.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-5d, 2d), v.z);
                Assert.AreEqual(new Complex(-5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -3d), new Complex(4d, -6.5d), new Complex(-6d, -4.5d), new Complex(7d, -5.5d));
                var v = ov.swizzle.ww;
                Assert.AreEqual(new Complex(7d, -5.5d), v.x);
                Assert.AreEqual(new Complex(7d, -5.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(7d, 3.5d), new Complex(-5d, 0.0), new Complex(-7.5d, 5.5d), new Complex(8.5d, -1.5d));
                var v = ov.swizzle.wwx;
                Assert.AreEqual(new Complex(8.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(7d, 3.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(2.5d, 0.0), new Complex(-7.5d, 8.5d), new Complex(-4d, 6d), new Complex(-0.5d, 8d));
                var v = ov.swizzle.wwxx;
                Assert.AreEqual(new Complex(-0.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 8d), v.y);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 5.5d), new Complex(-1d, -9d), new Complex(1.5d, 6.5d), new Complex(9.5d, 0.5d));
                var v = ov.swizzle.wwxy;
                Assert.AreEqual(new Complex(9.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-1d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, -9.5d), new Complex(-6d, 3d), new Complex(9.5d, 5.5d), new Complex(-5d, -2d));
                var v = ov.swizzle.wwxz;
                Assert.AreEqual(new Complex(-5d, -2d), v.x);
                Assert.AreEqual(new Complex(-5d, -2d), v.y);
                Assert.AreEqual(new Complex(3.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, 5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 7.5d), new Complex(-5d, -5.5d), new Complex(2.5d, 6.5d), new Complex(-5d, 3.5d));
                var v = ov.swizzle.wwxw;
                Assert.AreEqual(new Complex(-5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-5d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, -2.5d), new Complex(3.5d, -2d), new Complex(-2.5d, 8d), new Complex(-3d, -6d));
                var v = ov.swizzle.wwy;
                Assert.AreEqual(new Complex(-3d, -6d), v.x);
                Assert.AreEqual(new Complex(-3d, -6d), v.y);
                Assert.AreEqual(new Complex(3.5d, -2d), v.z);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -3.5d), new Complex(-3d, -4.5d), new Complex(-1.5d, 3d), new Complex(1.0, -6d));
                var v = ov.swizzle.wwyx;
                Assert.AreEqual(new Complex(1.0, -6d), v.x);
                Assert.AreEqual(new Complex(1.0, -6d), v.y);
                Assert.AreEqual(new Complex(-3d, -4.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -5.5d), new Complex(-4d, 0.5d), new Complex(-8d, 7d), new Complex(-3.5d, 1.0));
                var v = ov.swizzle.wwyy;
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-4d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-4d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, -7d), new Complex(1.5d, 7d), new Complex(-2.5d, 1.5d), new Complex(-1.5d, -8.5d));
                var v = ov.swizzle.wwyz;
                Assert.AreEqual(new Complex(-1.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-2.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -1d), new Complex(5.5d, 9d), new Complex(-5.5d, 0.5d), new Complex(-8.5d, -6d));
                var v = ov.swizzle.wwyw;
                Assert.AreEqual(new Complex(-8.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -6d), v.y);
                Assert.AreEqual(new Complex(5.5d, 9d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, -5.5d), new Complex(-5d, -4d), new Complex(-9.5d, 2.5d), new Complex(-4.5d, -9d));
                var v = ov.swizzle.wwz;
                Assert.AreEqual(new Complex(-4.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -9d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 2.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(8d, 4d), new Complex(5d, 4.5d), new Complex(-4d, 2.5d), new Complex(6d, -1.5d));
                var v = ov.swizzle.wwzx;
                Assert.AreEqual(new Complex(6d, -1.5d), v.x);
                Assert.AreEqual(new Complex(6d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-4d, 2.5d), v.z);
                Assert.AreEqual(new Complex(8d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, 7.5d), new Complex(-9.5d, 8.5d), new Complex(2d, 3d), new Complex(9d, -3.5d));
                var v = ov.swizzle.wwzy;
                Assert.AreEqual(new Complex(9d, -3.5d), v.x);
                Assert.AreEqual(new Complex(9d, -3.5d), v.y);
                Assert.AreEqual(new Complex(2d, 3d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -2.5d), new Complex(0.0, -0.5d), new Complex(-6d, 6.5d), new Complex(-5d, -8.5d));
                var v = ov.swizzle.wwzz;
                Assert.AreEqual(new Complex(-5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-6d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 2.5d), new Complex(9d, -7d), new Complex(1.0, 9.5d), new Complex(-9d, -3d));
                var v = ov.swizzle.wwzw;
                Assert.AreEqual(new Complex(-9d, -3d), v.x);
                Assert.AreEqual(new Complex(-9d, -3d), v.y);
                Assert.AreEqual(new Complex(1.0, 9.5d), v.z);
                Assert.AreEqual(new Complex(-9d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, 4.5d), new Complex(-2d, -0.5d), new Complex(-7d, -7.5d), new Complex(-7.5d, 3d));
                var v = ov.swizzle.www;
                Assert.AreEqual(new Complex(-7.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(3.5d, -1d), new Complex(5d, 3.5d), new Complex(8d, -1d), new Complex(2d, 9d));
                var v = ov.swizzle.wwwx;
                Assert.AreEqual(new Complex(2d, 9d), v.x);
                Assert.AreEqual(new Complex(2d, 9d), v.y);
                Assert.AreEqual(new Complex(2d, 9d), v.z);
                Assert.AreEqual(new Complex(3.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, -3d), new Complex(-2d, -3d), new Complex(-6d, 1.0), new Complex(-7d, -2.5d));
                var v = ov.swizzle.wwwy;
                Assert.AreEqual(new Complex(-7d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-7d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-2d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, 3.5d), new Complex(-2d, -8d), new Complex(5d, 7d), new Complex(-7d, -2d));
                var v = ov.swizzle.wwwz;
                Assert.AreEqual(new Complex(-7d, -2d), v.x);
                Assert.AreEqual(new Complex(-7d, -2d), v.y);
                Assert.AreEqual(new Complex(-7d, -2d), v.z);
                Assert.AreEqual(new Complex(5d, 7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, -8d), new Complex(1.0, -2.5d), new Complex(4d, 9d), new Complex(0.5d, 0.5d));
                var v = ov.swizzle.wwww;
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new cvec4(new Complex(-6d, -1.5d), new Complex(9.5d, 6d), new Complex(5.5d, 1.5d), new Complex(-1d, -7.5d));
                var v = ov.swizzle.rr;
                Assert.AreEqual(new Complex(-6d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-6d, -1.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(0.0, 7.5d), new Complex(1.5d, -6d), new Complex(-4.5d, 3.5d), new Complex(-1.5d, -4.5d));
                var v = ov.swizzle.rrr;
                Assert.AreEqual(new Complex(0.0, 7.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -4d), new Complex(-1.5d, -6d), new Complex(-7d, 0.0), new Complex(2.5d, 7.5d));
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(new Complex(6.5d, -4d), v.x);
                Assert.AreEqual(new Complex(6.5d, -4d), v.y);
                Assert.AreEqual(new Complex(6.5d, -4d), v.z);
                Assert.AreEqual(new Complex(6.5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, -8d), new Complex(-0.5d, -4.5d), new Complex(2.5d, 7.5d), new Complex(-5d, 6d));
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(new Complex(-1.5d, -8d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -8d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, 7d), new Complex(9d, -1d), new Complex(-4d, 4.5d), new Complex(1.5d, -6d));
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(new Complex(3d, 7d), v.x);
                Assert.AreEqual(new Complex(3d, 7d), v.y);
                Assert.AreEqual(new Complex(3d, 7d), v.z);
                Assert.AreEqual(new Complex(-4d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -4.5d), new Complex(2.5d, 8d), new Complex(3.5d, 3.5d), new Complex(-8d, 5.5d));
                var v = ov.swizzle.rrra;
                Assert.AreEqual(new Complex(0.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 1.0), new Complex(-4d, 1.0), new Complex(0.5d, -9.5d), new Complex(-2.5d, 0.0));
                var v = ov.swizzle.rrg;
                Assert.AreEqual(new Complex(-2.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-2.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-4d, 1.0), v.z);
            }
            {
                var ov = new cvec4(new Complex(-9d, -8d), new Complex(-1.5d, -8.5d), new Complex(7.5d, -4d), new Complex(-7.5d, -6.5d));
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(new Complex(-9d, -8d), v.x);
                Assert.AreEqual(new Complex(-9d, -8d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-9d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -8d), new Complex(-6d, -3.5d), new Complex(8d, 7.5d), new Complex(-7.5d, 3.5d));
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(new Complex(-6d, -8d), v.x);
                Assert.AreEqual(new Complex(-6d, -8d), v.y);
                Assert.AreEqual(new Complex(-6d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, -8.5d), new Complex(-7d, 6.5d), new Complex(-5.5d, 2.5d), new Complex(-5d, 1.0));
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(new Complex(-3d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-3d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, 5.5d), new Complex(0.5d, -6.5d), new Complex(-6d, 4.5d), new Complex(-8.5d, -3d));
                var v = ov.swizzle.rrga;
                Assert.AreEqual(new Complex(3d, 5.5d), v.x);
                Assert.AreEqual(new Complex(3d, 5.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, 4.5d), new Complex(5.5d, -6.5d), new Complex(9d, -9d), new Complex(6.5d, -6.5d));
                var v = ov.swizzle.rrb;
                Assert.AreEqual(new Complex(-6.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(9d, -9d), v.z);
            }
            {
                var ov = new cvec4(new Complex(9d, -1d), new Complex(1.0, -7.5d), new Complex(-2.5d, 0.0), new Complex(4d, -7d));
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(new Complex(9d, -1d), v.x);
                Assert.AreEqual(new Complex(9d, -1d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(9d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, 7.5d), new Complex(-9d, -0.5d), new Complex(-1.5d, 7.5d), new Complex(-5.5d, -9d));
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(new Complex(-8.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-9d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5d, -1d), new Complex(-7d, 4.5d), new Complex(-5.5d, -9.5d), new Complex(-2.5d, 6.5d));
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(new Complex(5d, -1d), v.x);
                Assert.AreEqual(new Complex(5d, -1d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, 3.5d), new Complex(8.5d, 3.5d), new Complex(9d, 4d), new Complex(7d, 1.5d));
                var v = ov.swizzle.rrba;
                Assert.AreEqual(new Complex(0.0, 3.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 3.5d), v.y);
                Assert.AreEqual(new Complex(9d, 4d), v.z);
                Assert.AreEqual(new Complex(7d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, 1.0), new Complex(4.5d, -8d), new Complex(-7d, -8d), new Complex(-2d, 0.5d));
                var v = ov.swizzle.rra;
                Assert.AreEqual(new Complex(1.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(1.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-2d, 0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -4.5d), new Complex(-1d, 1.0), new Complex(1.0, -5.5d), new Complex(-3.5d, -2d));
                var v = ov.swizzle.rrar;
                Assert.AreEqual(new Complex(-9.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -9d), new Complex(9.5d, 3.5d), new Complex(-2.5d, -8d), new Complex(0.0, 0.0));
                var v = ov.swizzle.rrag;
                Assert.AreEqual(new Complex(-4.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -9d), v.y);
                Assert.AreEqual(new Complex(0.0, 0.0), v.z);
                Assert.AreEqual(new Complex(9.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -3d), new Complex(-3d, -9d), new Complex(5.5d, 1.0), new Complex(1.5d, -9d));
                var v = ov.swizzle.rrab;
                Assert.AreEqual(new Complex(-6d, -3d), v.x);
                Assert.AreEqual(new Complex(-6d, -3d), v.y);
                Assert.AreEqual(new Complex(1.5d, -9d), v.z);
                Assert.AreEqual(new Complex(5.5d, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, -8.5d), new Complex(3.5d, 6.5d), new Complex(-7d, -1.5d), new Complex(-7d, 4.5d));
                var v = ov.swizzle.rraa;
                Assert.AreEqual(new Complex(3d, -8.5d), v.x);
                Assert.AreEqual(new Complex(3d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, -8d), new Complex(2.5d, 4.5d), new Complex(0.0, -5.5d), new Complex(6.5d, -1.5d));
                var v = ov.swizzle.rg;
                Assert.AreEqual(new Complex(1.0, -8d), v.x);
                Assert.AreEqual(new Complex(2.5d, 4.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, -0.5d), new Complex(-4.5d, -8d), new Complex(-7d, -8.5d), new Complex(5.5d, -3.5d));
                var v = ov.swizzle.rgr;
                Assert.AreEqual(new Complex(-2.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(3.5d, -6d), new Complex(6.5d, 5.5d), new Complex(-4d, 5d), new Complex(5d, 2d));
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(new Complex(3.5d, -6d), v.x);
                Assert.AreEqual(new Complex(6.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -6d), v.z);
                Assert.AreEqual(new Complex(3.5d, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -7d), new Complex(8d, 1.0), new Complex(0.5d, -1d), new Complex(-0.5d, -7d));
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(new Complex(-8.5d, -7d), v.x);
                Assert.AreEqual(new Complex(8d, 1.0), v.y);
                Assert.AreEqual(new Complex(-8.5d, -7d), v.z);
                Assert.AreEqual(new Complex(8d, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, 3d), new Complex(7.5d, -1.5d), new Complex(-6d, 5.5d), new Complex(9.5d, 8d));
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(new Complex(-9d, 3d), v.x);
                Assert.AreEqual(new Complex(7.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-9d, 3d), v.z);
                Assert.AreEqual(new Complex(-6d, 5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, 7.5d), new Complex(0.0, -2.5d), new Complex(-9d, 8.5d), new Complex(-7.5d, 3d));
                var v = ov.swizzle.rgra;
                Assert.AreEqual(new Complex(9.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -2.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2.5d, -1d), new Complex(-1.5d, 4.5d), new Complex(8d, 4d), new Complex(2.5d, 2.5d));
                var v = ov.swizzle.rgg;
                Assert.AreEqual(new Complex(2.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 4.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 3.5d), new Complex(3.5d, 1.0), new Complex(-5.5d, -4d), new Complex(6d, 7.5d));
                var v = ov.swizzle.rggr;
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(3.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(-7.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 3d), new Complex(2.5d, -1d), new Complex(6d, -1d), new Complex(8.5d, 6d));
                var v = ov.swizzle.rggg;
                Assert.AreEqual(new Complex(-7.5d, 3d), v.x);
                Assert.AreEqual(new Complex(2.5d, -1d), v.y);
                Assert.AreEqual(new Complex(2.5d, -1d), v.z);
                Assert.AreEqual(new Complex(2.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, 1.5d), new Complex(-9.5d, -0.5d), new Complex(-4.5d, 0.0), new Complex(5.5d, 7d));
                var v = ov.swizzle.rggb;
                Assert.AreEqual(new Complex(3.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, -8.5d), new Complex(5d, 8.5d), new Complex(2.5d, 5.5d), new Complex(-1.5d, -6.5d));
                var v = ov.swizzle.rgga;
                Assert.AreEqual(new Complex(3.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, -4.5d), new Complex(-7.5d, -4d), new Complex(-9d, -6.5d), new Complex(7d, 8d));
                var v = ov.swizzle.rgb;
                Assert.AreEqual(new Complex(-3.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-9d, -6.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, 7d), new Complex(5d, -7.5d), new Complex(-3d, -4d), new Complex(5d, 2.5d));
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(new Complex(-6.5d, 7d), v.x);
                Assert.AreEqual(new Complex(5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-3d, -4d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, 8.5d), new Complex(-8d, -9d), new Complex(-7d, 6.5d), new Complex(0.0, -1.5d));
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(new Complex(-7d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -9d), v.y);
                Assert.AreEqual(new Complex(-7d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-8d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, 4.5d), new Complex(-9d, -9.5d), new Complex(4d, -5d), new Complex(8.5d, 4.5d));
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(new Complex(-3d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-9d, -9.5d), v.y);
                Assert.AreEqual(new Complex(4d, -5d), v.z);
                Assert.AreEqual(new Complex(4d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, -1d), new Complex(-5.5d, -1.5d), new Complex(-3d, 1.5d), new Complex(0.0, -2d));
                var v = ov.swizzle.rgba;
                Assert.AreEqual(new Complex(-7d, -1d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-3d, 1.5d), v.z);
                Assert.AreEqual(new Complex(0.0, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, -9.5d), new Complex(6d, 6d), new Complex(-6.5d, 9.5d), new Complex(-0.5d, 5d));
                var v = ov.swizzle.rga;
                Assert.AreEqual(new Complex(-3d, -9.5d), v.x);
                Assert.AreEqual(new Complex(6d, 6d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(1.0, -1.5d), new Complex(2.5d, 3d), new Complex(5.5d, -4.5d), new Complex(8.5d, -4d));
                var v = ov.swizzle.rgar;
                Assert.AreEqual(new Complex(1.0, -1.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 3d), v.y);
                Assert.AreEqual(new Complex(8.5d, -4d), v.z);
                Assert.AreEqual(new Complex(1.0, -1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, -3.5d), new Complex(-8.5d, -1.5d), new Complex(5d, -4.5d), new Complex(3.5d, 7.5d));
                var v = ov.swizzle.rgag;
                Assert.AreEqual(new Complex(-3d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7d, 1.5d), new Complex(1.5d, -6d), new Complex(5.5d, -9d), new Complex(9d, 5.5d));
                var v = ov.swizzle.rgab;
                Assert.AreEqual(new Complex(7d, 1.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -6d), v.y);
                Assert.AreEqual(new Complex(9d, 5.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, 9d), new Complex(0.0, 3.5d), new Complex(9d, -7.5d), new Complex(-7d, 8d));
                var v = ov.swizzle.rgaa;
                Assert.AreEqual(new Complex(9d, 9d), v.x);
                Assert.AreEqual(new Complex(0.0, 3.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 8d), v.z);
                Assert.AreEqual(new Complex(-7d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -3.5d), new Complex(-8d, -9.5d), new Complex(-0.5d, 8.5d), new Complex(3d, -7.5d));
                var v = ov.swizzle.rb;
                Assert.AreEqual(new Complex(-9.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 8.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-5d, -3d), new Complex(5d, -8.5d), new Complex(-4.5d, -1d), new Complex(-5d, 9d));
                var v = ov.swizzle.rbr;
                Assert.AreEqual(new Complex(-5d, -3d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-5d, -3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6d, -2d), new Complex(-3.5d, 6d), new Complex(-8d, 5.5d), new Complex(8d, 0.5d));
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(new Complex(-6d, -2d), v.x);
                Assert.AreEqual(new Complex(-8d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-6d, -2d), v.z);
                Assert.AreEqual(new Complex(-6d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, 6d), new Complex(2.5d, -7.5d), new Complex(-6d, 1.0), new Complex(-9.5d, -7d));
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(new Complex(3.5d, 6d), v.x);
                Assert.AreEqual(new Complex(-6d, 1.0), v.y);
                Assert.AreEqual(new Complex(3.5d, 6d), v.z);
                Assert.AreEqual(new Complex(2.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, -5d), new Complex(0.5d, -8d), new Complex(5d, -9d), new Complex(1.5d, 4d));
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(new Complex(8.5d, -5d), v.x);
                Assert.AreEqual(new Complex(5d, -9d), v.y);
                Assert.AreEqual(new Complex(8.5d, -5d), v.z);
                Assert.AreEqual(new Complex(5d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, 7.5d), new Complex(-4d, 9.5d), new Complex(3.5d, 5d), new Complex(6.5d, -1d));
                var v = ov.swizzle.rbra;
                Assert.AreEqual(new Complex(9d, 7.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, 5d), v.y);
                Assert.AreEqual(new Complex(9d, 7.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 2.5d), new Complex(-6.5d, 8.5d), new Complex(2.5d, 6.5d), new Complex(-7.5d, -8d));
                var v = ov.swizzle.rbg;
                Assert.AreEqual(new Complex(-2d, 2.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 8.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 1.0), new Complex(4.5d, -9.5d), new Complex(-0.5d, -6.5d), new Complex(-6d, -5d));
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(new Complex(-5.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-0.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 4d), new Complex(6.5d, -6.5d), new Complex(-9.5d, -4.5d), new Complex(5.5d, 0.0));
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(new Complex(-5d, 4d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, 7d), new Complex(-9.5d, -5d), new Complex(-4d, 1.5d), new Complex(6.5d, 7d));
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(new Complex(-7d, 7d), v.x);
                Assert.AreEqual(new Complex(-4d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -5d), v.z);
                Assert.AreEqual(new Complex(-4d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 0.5d), new Complex(-8.5d, -4d), new Complex(-6.5d, 0.0), new Complex(-2.5d, -9.5d));
                var v = ov.swizzle.rbga;
                Assert.AreEqual(new Complex(6d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(-8.5d, -4d), v.z);
                Assert.AreEqual(new Complex(-2.5d, -9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, 0.5d), new Complex(6.5d, 5.5d), new Complex(0.0, -0.5d), new Complex(-6d, 9d));
                var v = ov.swizzle.rbb;
                Assert.AreEqual(new Complex(2d, 0.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -0.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6d, -3d), new Complex(-5d, 9.5d), new Complex(-2d, -8.5d), new Complex(-9d, 1.5d));
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(new Complex(-6d, -3d), v.x);
                Assert.AreEqual(new Complex(-2d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -5d), new Complex(-9d, -8d), new Complex(6d, 9d), new Complex(5d, -4.5d));
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(new Complex(5.5d, -5d), v.x);
                Assert.AreEqual(new Complex(6d, 9d), v.y);
                Assert.AreEqual(new Complex(6d, 9d), v.z);
                Assert.AreEqual(new Complex(-9d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -4d), new Complex(3.5d, -2.5d), new Complex(1.5d, 0.5d), new Complex(1.5d, -4d));
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(new Complex(-4.5d, -4d), v.x);
                Assert.AreEqual(new Complex(1.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, -5.5d), new Complex(2d, 1.5d), new Complex(1.5d, 7d), new Complex(-8.5d, 2.5d));
                var v = ov.swizzle.rbba;
                Assert.AreEqual(new Complex(-3d, -5.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 7d), v.y);
                Assert.AreEqual(new Complex(1.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -6.5d), new Complex(2d, -8d), new Complex(4.5d, -3.5d), new Complex(6.5d, -6.5d));
                var v = ov.swizzle.rba;
                Assert.AreEqual(new Complex(6.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(4.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -6.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-2d, 4.5d), new Complex(-8.5d, 0.0), new Complex(3d, 6d), new Complex(-8d, 7.5d));
                var v = ov.swizzle.rbar;
                Assert.AreEqual(new Complex(-2d, 4.5d), v.x);
                Assert.AreEqual(new Complex(3d, 6d), v.y);
                Assert.AreEqual(new Complex(-8d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-2d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -5.5d), new Complex(9d, -2d), new Complex(-5.5d, -2d), new Complex(-0.5d, -6.5d));
                var v = ov.swizzle.rbag;
                Assert.AreEqual(new Complex(-6d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(9d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, 9.5d), new Complex(5d, -5.5d), new Complex(3.5d, -8d), new Complex(-5d, 6.5d));
                var v = ov.swizzle.rbab;
                Assert.AreEqual(new Complex(1.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -8d), v.y);
                Assert.AreEqual(new Complex(-5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, 7d), new Complex(-7d, -4.5d), new Complex(6d, 3d), new Complex(7d, 9.5d));
                var v = ov.swizzle.rbaa;
                Assert.AreEqual(new Complex(-6.5d, 7d), v.x);
                Assert.AreEqual(new Complex(6d, 3d), v.y);
                Assert.AreEqual(new Complex(7d, 9.5d), v.z);
                Assert.AreEqual(new Complex(7d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 7.5d), new Complex(9d, -0.5d), new Complex(-8.5d, 0.0), new Complex(5.5d, -2.5d));
                var v = ov.swizzle.ra;
                Assert.AreEqual(new Complex(-7.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -2.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -2d), new Complex(-4d, 8.5d), new Complex(9d, -4.5d), new Complex(-6.5d, -8.5d));
                var v = ov.swizzle.rar;
                Assert.AreEqual(new Complex(0.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -2d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, -4.5d), new Complex(-6.5d, -8d), new Complex(-6.5d, -8.5d), new Complex(3d, 7.5d));
                var v = ov.swizzle.rarr;
                Assert.AreEqual(new Complex(-1.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(3d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, 5d), new Complex(1.0, 6d), new Complex(0.5d, 6.5d), new Complex(0.0, -1d));
                var v = ov.swizzle.rarg;
                Assert.AreEqual(new Complex(0.5d, 5d), v.x);
                Assert.AreEqual(new Complex(0.0, -1d), v.y);
                Assert.AreEqual(new Complex(0.5d, 5d), v.z);
                Assert.AreEqual(new Complex(1.0, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, 7d), new Complex(4d, 5d), new Complex(3d, -3d), new Complex(5.5d, -2d));
                var v = ov.swizzle.rarb;
                Assert.AreEqual(new Complex(2d, 7d), v.x);
                Assert.AreEqual(new Complex(5.5d, -2d), v.y);
                Assert.AreEqual(new Complex(2d, 7d), v.z);
                Assert.AreEqual(new Complex(3d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 1.5d), new Complex(3.5d, -6.5d), new Complex(3d, 4d), new Complex(-3.5d, 0.0));
                var v = ov.swizzle.rara;
                Assert.AreEqual(new Complex(-2d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(-2d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 5d), new Complex(-7d, -3.5d), new Complex(-4d, -4.5d), new Complex(-9d, -2.5d));
                var v = ov.swizzle.rag;
                Assert.AreEqual(new Complex(5.5d, 5d), v.x);
                Assert.AreEqual(new Complex(-9d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-7d, -3.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(0.0, 6d), new Complex(-6d, 1.5d), new Complex(8d, 3d), new Complex(5.5d, 8.5d));
                var v = ov.swizzle.ragr;
                Assert.AreEqual(new Complex(0.0, 6d), v.x);
                Assert.AreEqual(new Complex(5.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 1.5d), v.z);
                Assert.AreEqual(new Complex(0.0, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -2.5d), new Complex(-6.5d, 5d), new Complex(8.5d, 4.5d), new Complex(-3.5d, 1.5d));
                var v = ov.swizzle.ragg;
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, -8d), new Complex(8.5d, 8.5d), new Complex(6d, 8d), new Complex(7.5d, 5.5d));
                var v = ov.swizzle.ragb;
                Assert.AreEqual(new Complex(-7.5d, -8d), v.x);
                Assert.AreEqual(new Complex(7.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(6d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, -4d), new Complex(-9.5d, -3.5d), new Complex(0.5d, -2d), new Complex(3.5d, 6d));
                var v = ov.swizzle.raga;
                Assert.AreEqual(new Complex(-1d, -4d), v.x);
                Assert.AreEqual(new Complex(3.5d, 6d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 0.5d), new Complex(-9.5d, -3d), new Complex(9.5d, -7d), new Complex(0.5d, 0.5d));
                var v = ov.swizzle.rab;
                Assert.AreEqual(new Complex(-3.5d, 0.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -7d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-5d, -1.5d), new Complex(3.5d, 5d), new Complex(-3d, -2.5d), new Complex(-8d, 9.5d));
                var v = ov.swizzle.rabr;
                Assert.AreEqual(new Complex(-5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-8d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-3d, -2.5d), v.z);
                Assert.AreEqual(new Complex(-5d, -1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, 9d), new Complex(-1d, 1.5d), new Complex(6.5d, 8d), new Complex(-0.5d, -4d));
                var v = ov.swizzle.rabg;
                Assert.AreEqual(new Complex(-4d, 9d), v.x);
                Assert.AreEqual(new Complex(-0.5d, -4d), v.y);
                Assert.AreEqual(new Complex(6.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-1d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, -6.5d), new Complex(4.5d, 9.5d), new Complex(0.0, -9.5d), new Complex(-3d, -5.5d));
                var v = ov.swizzle.rabb;
                Assert.AreEqual(new Complex(6d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-3d, -5.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -9.5d), v.z);
                Assert.AreEqual(new Complex(0.0, -9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, -1d), new Complex(0.5d, 7.5d), new Complex(-6.5d, -2d), new Complex(-2d, 2.5d));
                var v = ov.swizzle.raba;
                Assert.AreEqual(new Complex(0.0, -1d), v.x);
                Assert.AreEqual(new Complex(-2d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-2d, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, -2d), new Complex(-2.5d, -6.5d), new Complex(7d, 9d), new Complex(6d, 7.5d));
                var v = ov.swizzle.raa;
                Assert.AreEqual(new Complex(-5d, -2d), v.x);
                Assert.AreEqual(new Complex(6d, 7.5d), v.y);
                Assert.AreEqual(new Complex(6d, 7.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(2d, -2d), new Complex(4d, 2d), new Complex(-8d, 2.5d), new Complex(3d, 8d));
                var v = ov.swizzle.raar;
                Assert.AreEqual(new Complex(2d, -2d), v.x);
                Assert.AreEqual(new Complex(3d, 8d), v.y);
                Assert.AreEqual(new Complex(3d, 8d), v.z);
                Assert.AreEqual(new Complex(2d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, 6.5d), new Complex(5d, -8d), new Complex(-5.5d, 6.5d), new Complex(2.5d, 4d));
                var v = ov.swizzle.raag;
                Assert.AreEqual(new Complex(7.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 4d), v.y);
                Assert.AreEqual(new Complex(2.5d, 4d), v.z);
                Assert.AreEqual(new Complex(5d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, 8d), new Complex(9d, 7.5d), new Complex(9.5d, -1d), new Complex(-5d, 0.5d));
                var v = ov.swizzle.raab;
                Assert.AreEqual(new Complex(3d, 8d), v.x);
                Assert.AreEqual(new Complex(-5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8d, 8d), new Complex(-6.5d, 4.5d), new Complex(3d, 7.5d), new Complex(7d, 1.0));
                var v = ov.swizzle.raaa;
                Assert.AreEqual(new Complex(-8d, 8d), v.x);
                Assert.AreEqual(new Complex(7d, 1.0), v.y);
                Assert.AreEqual(new Complex(7d, 1.0), v.z);
                Assert.AreEqual(new Complex(7d, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, 1.0), new Complex(0.5d, 4d), new Complex(-7.5d, -2.5d), new Complex(-4.5d, 3.5d));
                var v = ov.swizzle.gr;
                Assert.AreEqual(new Complex(0.5d, 4d), v.x);
                Assert.AreEqual(new Complex(3d, 1.0), v.y);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 7.5d), new Complex(9d, -9d), new Complex(-9.5d, 6d), new Complex(-2.5d, -8d));
                var v = ov.swizzle.grr;
                Assert.AreEqual(new Complex(9d, -9d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 7.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(8.5d, -7d), new Complex(3.5d, -4.5d), new Complex(7.5d, -7.5d), new Complex(-9.5d, -6d));
                var v = ov.swizzle.grrr;
                Assert.AreEqual(new Complex(3.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -7d), v.y);
                Assert.AreEqual(new Complex(8.5d, -7d), v.z);
                Assert.AreEqual(new Complex(8.5d, -7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, -4d), new Complex(-8d, -8d), new Complex(-8d, 3.5d), new Complex(9.5d, 7d));
                var v = ov.swizzle.grrg;
                Assert.AreEqual(new Complex(-8d, -8d), v.x);
                Assert.AreEqual(new Complex(7.5d, -4d), v.y);
                Assert.AreEqual(new Complex(7.5d, -4d), v.z);
                Assert.AreEqual(new Complex(-8d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, 0.0), new Complex(2.5d, -7d), new Complex(-1.5d, -7d), new Complex(-1d, -6.5d));
                var v = ov.swizzle.grrb;
                Assert.AreEqual(new Complex(2.5d, -7d), v.x);
                Assert.AreEqual(new Complex(-3d, 0.0), v.y);
                Assert.AreEqual(new Complex(-3d, 0.0), v.z);
                Assert.AreEqual(new Complex(-1.5d, -7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, -1d), new Complex(9d, -7d), new Complex(-8.5d, 2d), new Complex(7d, 0.5d));
                var v = ov.swizzle.grra;
                Assert.AreEqual(new Complex(9d, -7d), v.x);
                Assert.AreEqual(new Complex(-5d, -1d), v.y);
                Assert.AreEqual(new Complex(-5d, -1d), v.z);
                Assert.AreEqual(new Complex(7d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 5.5d), new Complex(4d, 1.0), new Complex(-3.5d, 3d), new Complex(6.5d, -4.5d));
                var v = ov.swizzle.grg;
                Assert.AreEqual(new Complex(4d, 1.0), v.x);
                Assert.AreEqual(new Complex(-3.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(4d, 1.0), v.z);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -0.5d), new Complex(-4.5d, -0.5d), new Complex(5.5d, -5d), new Complex(-7d, -7d));
                var v = ov.swizzle.grgr;
                Assert.AreEqual(new Complex(-4.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 8.5d), new Complex(-6d, 8d), new Complex(8d, -1.5d), new Complex(-4.5d, 6d));
                var v = ov.swizzle.grgg;
                Assert.AreEqual(new Complex(-6d, 8d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 8d), v.z);
                Assert.AreEqual(new Complex(-6d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, 4.5d), new Complex(-7.5d, -6d), new Complex(-8.5d, 0.0), new Complex(2.5d, 3.5d));
                var v = ov.swizzle.grgb;
                Assert.AreEqual(new Complex(-7.5d, -6d), v.x);
                Assert.AreEqual(new Complex(4d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -6d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 6.5d), new Complex(1.5d, -5d), new Complex(4d, 1.5d), new Complex(4d, 9d));
                var v = ov.swizzle.grga;
                Assert.AreEqual(new Complex(1.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -5d), v.z);
                Assert.AreEqual(new Complex(4d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7d, 5.5d), new Complex(4d, -8d), new Complex(4.5d, 1.5d), new Complex(-4.5d, 0.5d));
                var v = ov.swizzle.grb;
                Assert.AreEqual(new Complex(4d, -8d), v.x);
                Assert.AreEqual(new Complex(7d, 5.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 1.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(2.5d, 4d), new Complex(0.0, 0.0), new Complex(2d, -2.5d), new Complex(-4.5d, 2.5d));
                var v = ov.swizzle.grbr;
                Assert.AreEqual(new Complex(0.0, 0.0), v.x);
                Assert.AreEqual(new Complex(2.5d, 4d), v.y);
                Assert.AreEqual(new Complex(2d, -2.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -8d), new Complex(3.5d, -5d), new Complex(2.5d, 0.5d), new Complex(3.5d, -5.5d));
                var v = ov.swizzle.grbg;
                Assert.AreEqual(new Complex(3.5d, -5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -8d), v.y);
                Assert.AreEqual(new Complex(2.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8d, 9.5d), new Complex(-4d, 4.5d), new Complex(8.5d, 8.5d), new Complex(-7.5d, 3.5d));
                var v = ov.swizzle.grbb;
                Assert.AreEqual(new Complex(-4d, 4.5d), v.x);
                Assert.AreEqual(new Complex(8d, 9.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, -5d), new Complex(-6.5d, -7.5d), new Complex(1.5d, -0.5d), new Complex(-3d, -3.5d));
                var v = ov.swizzle.grba;
                Assert.AreEqual(new Complex(-6.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(-3d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, -1d), new Complex(-8.5d, 3d), new Complex(3.5d, -7d), new Complex(-7.5d, 3d));
                var v = ov.swizzle.gra;
                Assert.AreEqual(new Complex(-8.5d, 3d), v.x);
                Assert.AreEqual(new Complex(8.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(8d, -2.5d), new Complex(3.5d, -3.5d), new Complex(4.5d, -2d), new Complex(0.5d, -4.5d));
                var v = ov.swizzle.grar;
                Assert.AreEqual(new Complex(3.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(8d, -2.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(8d, -2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -5d), new Complex(5.5d, -5.5d), new Complex(-3.5d, -3.5d), new Complex(-6.5d, 6.5d));
                var v = ov.swizzle.grag;
                Assert.AreEqual(new Complex(5.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, -6.5d), new Complex(-6d, 1.5d), new Complex(9.5d, 4.5d), new Complex(-7.5d, -5d));
                var v = ov.swizzle.grab;
                Assert.AreEqual(new Complex(-6d, 1.5d), v.x);
                Assert.AreEqual(new Complex(4d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -5d), v.z);
                Assert.AreEqual(new Complex(9.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, -1d), new Complex(0.0, -1d), new Complex(4d, -8d), new Complex(5.5d, -3.5d));
                var v = ov.swizzle.graa;
                Assert.AreEqual(new Complex(0.0, -1d), v.x);
                Assert.AreEqual(new Complex(9d, -1d), v.y);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(5.5d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, 9.5d), new Complex(9d, -8.5d), new Complex(-8.5d, 8.5d), new Complex(3.5d, -5.5d));
                var v = ov.swizzle.gg;
                Assert.AreEqual(new Complex(9d, -8.5d), v.x);
                Assert.AreEqual(new Complex(9d, -8.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -9d), new Complex(-6d, 3d), new Complex(-6d, 4d), new Complex(0.5d, 9.5d));
                var v = ov.swizzle.ggr;
                Assert.AreEqual(new Complex(-6d, 3d), v.x);
                Assert.AreEqual(new Complex(-6d, 3d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -9d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -8d), new Complex(8.5d, 6d), new Complex(8d, -6d), new Complex(1.0, -3d));
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(new Complex(8.5d, 6d), v.x);
                Assert.AreEqual(new Complex(8.5d, 6d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -8d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -4.5d), new Complex(2.5d, 5d), new Complex(5d, 8.5d), new Complex(-2.5d, 2.5d));
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(new Complex(2.5d, 5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 5d), v.y);
                Assert.AreEqual(new Complex(9.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 1.0), new Complex(-3d, -4.5d), new Complex(-7d, 1.0), new Complex(8.5d, -8d));
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(new Complex(-3d, -4.5d), v.x);
                Assert.AreEqual(new Complex(-3d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 1.0), v.z);
                Assert.AreEqual(new Complex(-7d, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(5d, -0.5d), new Complex(-3d, 2d), new Complex(-4d, -5d), new Complex(9.5d, 3.5d));
                var v = ov.swizzle.ggra;
                Assert.AreEqual(new Complex(-3d, 2d), v.x);
                Assert.AreEqual(new Complex(-3d, 2d), v.y);
                Assert.AreEqual(new Complex(5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, -3.5d), new Complex(8d, 1.5d), new Complex(-1.5d, 9.5d), new Complex(3.5d, 8d));
                var v = ov.swizzle.ggg;
                Assert.AreEqual(new Complex(8d, 1.5d), v.x);
                Assert.AreEqual(new Complex(8d, 1.5d), v.y);
                Assert.AreEqual(new Complex(8d, 1.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-5d, 0.0), new Complex(-7d, -7.5d), new Complex(-3d, -8.5d), new Complex(-5.5d, 2d));
                var v = ov.swizzle.gggr;
                Assert.AreEqual(new Complex(-7d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-7d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, 1.0), new Complex(6.5d, 2d), new Complex(0.5d, -2.5d), new Complex(-1.5d, -1.5d));
                var v = ov.swizzle.gggg;
                Assert.AreEqual(new Complex(6.5d, 2d), v.x);
                Assert.AreEqual(new Complex(6.5d, 2d), v.y);
                Assert.AreEqual(new Complex(6.5d, 2d), v.z);
                Assert.AreEqual(new Complex(6.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, 4d), new Complex(9.5d, 3.5d), new Complex(8.5d, -4.5d), new Complex(3.5d, -6.5d));
                var v = ov.swizzle.gggb;
                Assert.AreEqual(new Complex(9.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8d, -9d), new Complex(3d, -1d), new Complex(7d, 5d), new Complex(-4d, 7d));
                var v = ov.swizzle.ggga;
                Assert.AreEqual(new Complex(3d, -1d), v.x);
                Assert.AreEqual(new Complex(3d, -1d), v.y);
                Assert.AreEqual(new Complex(3d, -1d), v.z);
                Assert.AreEqual(new Complex(-4d, 7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 6d), new Complex(-4.5d, -2d), new Complex(-5.5d, -1d), new Complex(-3d, -8d));
                var v = ov.swizzle.ggb;
                Assert.AreEqual(new Complex(-4.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -1d), v.z);
            }
            {
                var ov = new cvec4(new Complex(9d, 0.5d), new Complex(-3d, 0.0), new Complex(-1d, -2d), new Complex(6.5d, -4.5d));
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(new Complex(-3d, 0.0), v.x);
                Assert.AreEqual(new Complex(-3d, 0.0), v.y);
                Assert.AreEqual(new Complex(-1d, -2d), v.z);
                Assert.AreEqual(new Complex(9d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 9d), new Complex(6d, 0.0), new Complex(-0.5d, 5.5d), new Complex(9d, 4.5d));
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(new Complex(6d, 0.0), v.x);
                Assert.AreEqual(new Complex(6d, 0.0), v.y);
                Assert.AreEqual(new Complex(-0.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(6d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, 5d), new Complex(-7.5d, 4d), new Complex(-3.5d, 6.5d), new Complex(-4d, -4.5d));
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(new Complex(-7.5d, 4d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 4d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 4d), new Complex(-7.5d, 6.5d), new Complex(-6d, 6.5d), new Complex(5d, 4.5d));
                var v = ov.swizzle.ggba;
                Assert.AreEqual(new Complex(-7.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-6d, 6.5d), v.z);
                Assert.AreEqual(new Complex(5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -5.5d), new Complex(-4.5d, -3d), new Complex(-6.5d, -1d), new Complex(3d, -8.5d));
                var v = ov.swizzle.gga;
                Assert.AreEqual(new Complex(-4.5d, -3d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -3d), v.y);
                Assert.AreEqual(new Complex(3d, -8.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(1.0, -6d), new Complex(-8d, 9d), new Complex(-1.5d, -2.5d), new Complex(-2d, 8d));
                var v = ov.swizzle.ggar;
                Assert.AreEqual(new Complex(-8d, 9d), v.x);
                Assert.AreEqual(new Complex(-8d, 9d), v.y);
                Assert.AreEqual(new Complex(-2d, 8d), v.z);
                Assert.AreEqual(new Complex(1.0, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 0.0), new Complex(-6.5d, -8d), new Complex(-9.5d, 7.5d), new Complex(2d, -6d));
                var v = ov.swizzle.ggag;
                Assert.AreEqual(new Complex(-6.5d, -8d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -8d), v.y);
                Assert.AreEqual(new Complex(2d, -6d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, 5.5d), new Complex(0.0, 5d), new Complex(-3d, -4.5d), new Complex(-7.5d, -4d));
                var v = ov.swizzle.ggab;
                Assert.AreEqual(new Complex(0.0, 5d), v.x);
                Assert.AreEqual(new Complex(0.0, 5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -4d), v.z);
                Assert.AreEqual(new Complex(-3d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -9.5d), new Complex(-6d, -9d), new Complex(-6.5d, -6d), new Complex(1.0, 7.5d));
                var v = ov.swizzle.ggaa;
                Assert.AreEqual(new Complex(-6d, -9d), v.x);
                Assert.AreEqual(new Complex(-6d, -9d), v.y);
                Assert.AreEqual(new Complex(1.0, 7.5d), v.z);
                Assert.AreEqual(new Complex(1.0, 7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 7d), new Complex(-6d, 5.5d), new Complex(9.5d, 3.5d), new Complex(-2d, 9.5d));
                var v = ov.swizzle.gb;
                Assert.AreEqual(new Complex(-6d, 5.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 3.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(6d, 5d), new Complex(-9.5d, 1.5d), new Complex(2.5d, -6.5d), new Complex(-7d, 7.5d));
                var v = ov.swizzle.gbr;
                Assert.AreEqual(new Complex(-9.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(6d, 5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-3d, 4.5d), new Complex(-5.5d, 7.5d), new Complex(6d, -7d), new Complex(5.5d, -6.5d));
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(new Complex(-5.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(6d, -7d), v.y);
                Assert.AreEqual(new Complex(-3d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-3d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, -4d), new Complex(1.0, 8d), new Complex(-1.5d, -6.5d), new Complex(1.0, 1.5d));
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(new Complex(1.0, 8d), v.x);
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -4d), v.z);
                Assert.AreEqual(new Complex(1.0, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 9.5d), new Complex(-9.5d, -1.5d), new Complex(-1d, 9.5d), new Complex(2.5d, -8.5d));
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(new Complex(-9.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 9.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 9.5d), v.z);
                Assert.AreEqual(new Complex(-1d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, -4d), new Complex(9.5d, 2d), new Complex(-7.5d, -6.5d), new Complex(0.0, -0.5d));
                var v = ov.swizzle.gbra;
                Assert.AreEqual(new Complex(9.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -6.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, -4d), v.z);
                Assert.AreEqual(new Complex(0.0, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 3d), new Complex(-2.5d, -7d), new Complex(4d, 6.5d), new Complex(5.5d, 7.5d));
                var v = ov.swizzle.gbg;
                Assert.AreEqual(new Complex(-2.5d, -7d), v.x);
                Assert.AreEqual(new Complex(4d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -7d), v.z);
            }
            {
                var ov = new cvec4(new Complex(8d, -7d), new Complex(4d, -9.5d), new Complex(-0.5d, 4d), new Complex(-1d, -5.5d));
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(new Complex(4d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 4d), v.y);
                Assert.AreEqual(new Complex(4d, -9.5d), v.z);
                Assert.AreEqual(new Complex(8d, -7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -9.5d), new Complex(-4d, 7.5d), new Complex(9.5d, -3.5d), new Complex(8d, -2.5d));
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(new Complex(-4d, 7.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-4d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-4d, 7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -9.5d), new Complex(-1d, 9d), new Complex(7.5d, -5d), new Complex(-8.5d, -4.5d));
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(new Complex(-1d, 9d), v.x);
                Assert.AreEqual(new Complex(7.5d, -5d), v.y);
                Assert.AreEqual(new Complex(-1d, 9d), v.z);
                Assert.AreEqual(new Complex(7.5d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -2.5d), new Complex(-1d, -2.5d), new Complex(8.5d, -4d), new Complex(0.5d, 2d));
                var v = ov.swizzle.gbga;
                Assert.AreEqual(new Complex(-1d, -2.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-1d, -2.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, 9.5d), new Complex(-4.5d, -4d), new Complex(-6d, 2d), new Complex(3d, -5.5d));
                var v = ov.swizzle.gbb;
                Assert.AreEqual(new Complex(-4.5d, -4d), v.x);
                Assert.AreEqual(new Complex(-6d, 2d), v.y);
                Assert.AreEqual(new Complex(-6d, 2d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-2d, -7.5d), new Complex(-1d, 2.5d), new Complex(-9.5d, -3d), new Complex(4d, -0.5d));
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(new Complex(-1d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -3d), v.z);
                Assert.AreEqual(new Complex(-2d, -7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, -7d), new Complex(0.5d, 5.5d), new Complex(-8d, -5.5d), new Complex(7d, 5d));
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(new Complex(0.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-8d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-8d, -5.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -2d), new Complex(9.5d, 1.0), new Complex(-3.5d, 6.5d), new Complex(-9d, -1.5d));
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(new Complex(9.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 2.5d), new Complex(6.5d, -4.5d), new Complex(8d, -8d), new Complex(8d, -3d));
                var v = ov.swizzle.gbba;
                Assert.AreEqual(new Complex(6.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(8d, -8d), v.y);
                Assert.AreEqual(new Complex(8d, -8d), v.z);
                Assert.AreEqual(new Complex(8d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5.5d, 3.5d), new Complex(5.5d, 3.5d), new Complex(6.5d, 2d), new Complex(-3d, -5d));
                var v = ov.swizzle.gba;
                Assert.AreEqual(new Complex(5.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 2d), v.y);
                Assert.AreEqual(new Complex(-3d, -5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(1.0, -6.5d), new Complex(-9d, 4.5d), new Complex(-7d, -2d), new Complex(1.5d, -0.5d));
                var v = ov.swizzle.gbar;
                Assert.AreEqual(new Complex(-9d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-7d, -2d), v.y);
                Assert.AreEqual(new Complex(1.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(1.0, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -4d), new Complex(0.5d, -5d), new Complex(6d, 1.5d), new Complex(-3d, -5.5d));
                var v = ov.swizzle.gbag;
                Assert.AreEqual(new Complex(0.5d, -5d), v.x);
                Assert.AreEqual(new Complex(6d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-3d, -5.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, -2.5d), new Complex(2.5d, -9.5d), new Complex(-5.5d, 0.5d), new Complex(0.0, -2.5d));
                var v = ov.swizzle.gbab;
                Assert.AreEqual(new Complex(2.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -2.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, -2d), new Complex(1.0, 9d), new Complex(-5.5d, -4d), new Complex(7.5d, -4.5d));
                var v = ov.swizzle.gbaa;
                Assert.AreEqual(new Complex(1.0, 9d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -4d), v.y);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, 7d), new Complex(-5.5d, -3d), new Complex(6d, 4d), new Complex(8d, -6.5d));
                var v = ov.swizzle.ga;
                Assert.AreEqual(new Complex(-5.5d, -3d), v.x);
                Assert.AreEqual(new Complex(8d, -6.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -3d), new Complex(2.5d, -9d), new Complex(-5d, -5d), new Complex(-3.5d, -8d));
                var v = ov.swizzle.gar;
                Assert.AreEqual(new Complex(2.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -8d), v.y);
                Assert.AreEqual(new Complex(6.5d, -3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, -3d), new Complex(-8d, -5.5d), new Complex(5d, 1.5d), new Complex(-0.5d, 1.0));
                var v = ov.swizzle.garr;
                Assert.AreEqual(new Complex(-8d, -5.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 1.0), v.y);
                Assert.AreEqual(new Complex(-5.5d, -3d), v.z);
                Assert.AreEqual(new Complex(-5.5d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, 6d), new Complex(-0.5d, 9.5d), new Complex(4.5d, 9d), new Complex(-8.5d, 5d));
                var v = ov.swizzle.garg;
                Assert.AreEqual(new Complex(-0.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 5d), v.y);
                Assert.AreEqual(new Complex(2d, 6d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, -2d), new Complex(2d, -3.5d), new Complex(1.0, 9.5d), new Complex(2.5d, -2.5d));
                var v = ov.swizzle.garb;
                Assert.AreEqual(new Complex(2d, -3.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, -2d), v.z);
                Assert.AreEqual(new Complex(1.0, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -8.5d), new Complex(-1.5d, -6.5d), new Complex(-7.5d, -6d), new Complex(-5d, 2d));
                var v = ov.swizzle.gara;
                Assert.AreEqual(new Complex(-1.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 2d), v.y);
                Assert.AreEqual(new Complex(4.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 1.0), new Complex(4d, 7.5d), new Complex(6d, -6d), new Complex(1.0, -0.5d));
                var v = ov.swizzle.gag;
                Assert.AreEqual(new Complex(4d, 7.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -0.5d), v.y);
                Assert.AreEqual(new Complex(4d, 7.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-5d, 8d), new Complex(-3.5d, 7d), new Complex(7d, -4d), new Complex(-4d, -9.5d));
                var v = ov.swizzle.gagr;
                Assert.AreEqual(new Complex(-3.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-4d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 7d), v.z);
                Assert.AreEqual(new Complex(-5d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, 9d), new Complex(-1d, 3.5d), new Complex(-5.5d, 4d), new Complex(-2d, -8d));
                var v = ov.swizzle.gagg;
                Assert.AreEqual(new Complex(-1d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-2d, -8d), v.y);
                Assert.AreEqual(new Complex(-1d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-1d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, -3.5d), new Complex(-2.5d, -8d), new Complex(-7d, 2d), new Complex(9d, 4d));
                var v = ov.swizzle.gagb;
                Assert.AreEqual(new Complex(-2.5d, -8d), v.x);
                Assert.AreEqual(new Complex(9d, 4d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -8d), v.z);
                Assert.AreEqual(new Complex(-7d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, -8d), new Complex(0.5d, 3.5d), new Complex(7d, -5d), new Complex(4d, -2.5d));
                var v = ov.swizzle.gaga;
                Assert.AreEqual(new Complex(0.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(4d, -2.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(4d, -2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, -8.5d), new Complex(-8d, 0.5d), new Complex(-1d, -6d), new Complex(-1d, -2.5d));
                var v = ov.swizzle.gab;
                Assert.AreEqual(new Complex(-8d, 0.5d), v.x);
                Assert.AreEqual(new Complex(-1d, -2.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(8.5d, -1d), new Complex(3d, -7.5d), new Complex(-2d, -6d), new Complex(8d, -5.5d));
                var v = ov.swizzle.gabr;
                Assert.AreEqual(new Complex(3d, -7.5d), v.x);
                Assert.AreEqual(new Complex(8d, -5.5d), v.y);
                Assert.AreEqual(new Complex(-2d, -6d), v.z);
                Assert.AreEqual(new Complex(8.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -1d), new Complex(1.5d, -3.5d), new Complex(3d, 2d), new Complex(6.5d, -5.5d));
                var v = ov.swizzle.gabg;
                Assert.AreEqual(new Complex(1.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(3d, 2d), v.z);
                Assert.AreEqual(new Complex(1.5d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 4.5d), new Complex(2.5d, 1.0), new Complex(-4.5d, -8.5d), new Complex(1.5d, -3d));
                var v = ov.swizzle.gabb;
                Assert.AreEqual(new Complex(2.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(1.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 0.0), new Complex(-3d, -6.5d), new Complex(-2d, 6d), new Complex(8.5d, 5d));
                var v = ov.swizzle.gaba;
                Assert.AreEqual(new Complex(-3d, -6.5d), v.x);
                Assert.AreEqual(new Complex(8.5d, 5d), v.y);
                Assert.AreEqual(new Complex(-2d, 6d), v.z);
                Assert.AreEqual(new Complex(8.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, 8d), new Complex(2.5d, -1d), new Complex(-6d, -0.5d), new Complex(1.5d, -3d));
                var v = ov.swizzle.gaa;
                Assert.AreEqual(new Complex(2.5d, -1d), v.x);
                Assert.AreEqual(new Complex(1.5d, -3d), v.y);
                Assert.AreEqual(new Complex(1.5d, -3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(5d, 2.5d), new Complex(-7.5d, -0.5d), new Complex(1.5d, -9.5d), new Complex(1.0, 1.5d));
                var v = ov.swizzle.gaar;
                Assert.AreEqual(new Complex(-7.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 1.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 1.5d), v.z);
                Assert.AreEqual(new Complex(5d, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, -5.5d), new Complex(2.5d, 4.5d), new Complex(-1.5d, 7d), new Complex(3d, -4.5d));
                var v = ov.swizzle.gaag;
                Assert.AreEqual(new Complex(2.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(3d, -4.5d), v.y);
                Assert.AreEqual(new Complex(3d, -4.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, 6d), new Complex(-7d, -2.5d), new Complex(0.5d, -8.5d), new Complex(5d, 9d));
                var v = ov.swizzle.gaab;
                Assert.AreEqual(new Complex(-7d, -2.5d), v.x);
                Assert.AreEqual(new Complex(5d, 9d), v.y);
                Assert.AreEqual(new Complex(5d, 9d), v.z);
                Assert.AreEqual(new Complex(0.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -7.5d), new Complex(5.5d, -0.5d), new Complex(3d, -9d), new Complex(-1d, -4.5d));
                var v = ov.swizzle.gaaa;
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-1d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-1d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-1d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, -0.5d), new Complex(8.5d, -0.5d), new Complex(-5d, 8d), new Complex(-8.5d, -5.5d));
                var v = ov.swizzle.br;
                Assert.AreEqual(new Complex(-5d, 8d), v.x);
                Assert.AreEqual(new Complex(-4d, -0.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(7d, -0.5d), new Complex(-2.5d, -8.5d), new Complex(9d, -8.5d), new Complex(7.5d, -5.5d));
                var v = ov.swizzle.brr;
                Assert.AreEqual(new Complex(9d, -8.5d), v.x);
                Assert.AreEqual(new Complex(7d, -0.5d), v.y);
                Assert.AreEqual(new Complex(7d, -0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(1.0, 4.5d), new Complex(-4.5d, -0.5d), new Complex(-5.5d, 3d), new Complex(1.5d, 4.5d));
                var v = ov.swizzle.brrr;
                Assert.AreEqual(new Complex(-5.5d, 3d), v.x);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.z);
                Assert.AreEqual(new Complex(1.0, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, -4.5d), new Complex(9d, 8d), new Complex(4.5d, -9d), new Complex(2.5d, 9d));
                var v = ov.swizzle.brrg;
                Assert.AreEqual(new Complex(4.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-9d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-9d, -4.5d), v.z);
                Assert.AreEqual(new Complex(9d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 8.5d), new Complex(-9.5d, 2d), new Complex(4d, 3.5d), new Complex(-6d, -9d));
                var v = ov.swizzle.brrb;
                Assert.AreEqual(new Complex(4d, 3.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 8.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 8.5d), v.z);
                Assert.AreEqual(new Complex(4d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, 2d), new Complex(9d, -7.5d), new Complex(-6.5d, 0.0), new Complex(6d, -4d));
                var v = ov.swizzle.brra;
                Assert.AreEqual(new Complex(-6.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-3d, 2d), v.y);
                Assert.AreEqual(new Complex(-3d, 2d), v.z);
                Assert.AreEqual(new Complex(6d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, -6d), new Complex(9.5d, -7d), new Complex(-6d, -6d), new Complex(-4.5d, 7d));
                var v = ov.swizzle.brg;
                Assert.AreEqual(new Complex(-6d, -6d), v.x);
                Assert.AreEqual(new Complex(3d, -6d), v.y);
                Assert.AreEqual(new Complex(9.5d, -7d), v.z);
            }
            {
                var ov = new cvec4(new Complex(1.0, -9d), new Complex(-9.5d, 9d), new Complex(6.5d, 1.5d), new Complex(0.5d, -2d));
                var v = ov.swizzle.brgr;
                Assert.AreEqual(new Complex(6.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(1.0, -9d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 9d), v.z);
                Assert.AreEqual(new Complex(1.0, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, 2d), new Complex(0.0, -9.5d), new Complex(-5.5d, -5d), new Complex(-2d, -9d));
                var v = ov.swizzle.brgg;
                Assert.AreEqual(new Complex(-5.5d, -5d), v.x);
                Assert.AreEqual(new Complex(9d, 2d), v.y);
                Assert.AreEqual(new Complex(0.0, -9.5d), v.z);
                Assert.AreEqual(new Complex(0.0, -9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, 9.5d), new Complex(5.5d, 5d), new Complex(-6.5d, -7.5d), new Complex(-9d, -2d));
                var v = ov.swizzle.brgb;
                Assert.AreEqual(new Complex(-6.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(-7d, 9.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 5d), v.z);
                Assert.AreEqual(new Complex(-6.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, 6d), new Complex(3.5d, 5.5d), new Complex(9.5d, 7.5d), new Complex(0.0, 2.5d));
                var v = ov.swizzle.brga;
                Assert.AreEqual(new Complex(9.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(-3d, 6d), v.y);
                Assert.AreEqual(new Complex(3.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(0.0, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8d, -1.5d), new Complex(6.5d, -4d), new Complex(-5.5d, 9.5d), new Complex(-1d, 5.5d));
                var v = ov.swizzle.brb;
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.x);
                Assert.AreEqual(new Complex(8d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 9.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, 8d), new Complex(8.5d, -1d), new Complex(3d, 8d), new Complex(-5d, -7d));
                var v = ov.swizzle.brbr;
                Assert.AreEqual(new Complex(3d, 8d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 8d), v.y);
                Assert.AreEqual(new Complex(3d, 8d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, 4.5d), new Complex(-2.5d, 9.5d), new Complex(8.5d, -7.5d), new Complex(4d, 4d));
                var v = ov.swizzle.brbg;
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-2.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -3.5d), new Complex(7d, 3.5d), new Complex(-8d, 6d), new Complex(8d, -2d));
                var v = ov.swizzle.brbb;
                Assert.AreEqual(new Complex(-8d, 6d), v.x);
                Assert.AreEqual(new Complex(-6d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-8d, 6d), v.z);
                Assert.AreEqual(new Complex(-8d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 3d), new Complex(-4.5d, -4d), new Complex(6.5d, 3d), new Complex(-7.5d, -4.5d));
                var v = ov.swizzle.brba;
                Assert.AreEqual(new Complex(6.5d, 3d), v.x);
                Assert.AreEqual(new Complex(-2d, 3d), v.y);
                Assert.AreEqual(new Complex(6.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-7.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 7.5d), new Complex(3.5d, 2.5d), new Complex(-7.5d, -0.5d), new Complex(-9d, 3d));
                var v = ov.swizzle.bra;
                Assert.AreEqual(new Complex(-7.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-9d, 3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, 4.5d), new Complex(-7.5d, 7.5d), new Complex(-5d, 7d), new Complex(6d, 3.5d));
                var v = ov.swizzle.brar;
                Assert.AreEqual(new Complex(-5d, 7d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(6d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -8.5d), new Complex(-3.5d, -8.5d), new Complex(3d, -1d), new Complex(-9d, 7d));
                var v = ov.swizzle.brag;
                Assert.AreEqual(new Complex(3d, -1d), v.x);
                Assert.AreEqual(new Complex(6.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-9d, 7d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, -4.5d), new Complex(-7.5d, 6d), new Complex(7.5d, -4.5d), new Complex(7d, 2d));
                var v = ov.swizzle.brab;
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(9d, -4.5d), v.y);
                Assert.AreEqual(new Complex(7d, 2d), v.z);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, -5d), new Complex(4d, -8d), new Complex(1.0, 6.5d), new Complex(3d, 7d));
                var v = ov.swizzle.braa;
                Assert.AreEqual(new Complex(1.0, 6.5d), v.x);
                Assert.AreEqual(new Complex(-5d, -5d), v.y);
                Assert.AreEqual(new Complex(3d, 7d), v.z);
                Assert.AreEqual(new Complex(3d, 7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, 8.5d), new Complex(-7.5d, -3d), new Complex(9.5d, -8d), new Complex(-7.5d, 2d));
                var v = ov.swizzle.bg;
                Assert.AreEqual(new Complex(9.5d, -8d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -3d), v.y);
            }
            {
                var ov = new cvec4(new Complex(1.0, 7.5d), new Complex(-9.5d, 7d), new Complex(5.5d, 2.5d), new Complex(9d, 4d));
                var v = ov.swizzle.bgr;
                Assert.AreEqual(new Complex(5.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 7d), v.y);
                Assert.AreEqual(new Complex(1.0, 7.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-7d, 7.5d), new Complex(-5d, 7d), new Complex(7d, 6d), new Complex(-2.5d, 2.5d));
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(new Complex(7d, 6d), v.x);
                Assert.AreEqual(new Complex(-5d, 7d), v.y);
                Assert.AreEqual(new Complex(-7d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, 1.5d), new Complex(-8d, 9d), new Complex(-2d, 5.5d), new Complex(-5d, 6.5d));
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(new Complex(-2d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-8d, 9d), v.y);
                Assert.AreEqual(new Complex(7.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-8d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, -7.5d), new Complex(5d, 4.5d), new Complex(-3.5d, 1.0), new Complex(0.0, 8d));
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.x);
                Assert.AreEqual(new Complex(5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(-4d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 0.0), new Complex(6.5d, -6d), new Complex(-8d, 6.5d), new Complex(4d, -1d));
                var v = ov.swizzle.bgra;
                Assert.AreEqual(new Complex(-8d, 6.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(4d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, -3.5d), new Complex(-9.5d, -3d), new Complex(4.5d, -9.5d), new Complex(4.5d, -9.5d));
                var v = ov.swizzle.bgg;
                Assert.AreEqual(new Complex(4.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -3d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-1d, 7d), new Complex(-1d, 1.0), new Complex(3.5d, 6.5d), new Complex(6d, -6.5d));
                var v = ov.swizzle.bggr;
                Assert.AreEqual(new Complex(3.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 1.0), v.y);
                Assert.AreEqual(new Complex(-1d, 1.0), v.z);
                Assert.AreEqual(new Complex(-1d, 7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -6d), new Complex(2.5d, 4.5d), new Complex(5d, -5.5d), new Complex(6d, -6.5d));
                var v = ov.swizzle.bggg;
                Assert.AreEqual(new Complex(5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, -5d), new Complex(0.0, -4.5d), new Complex(-7d, 3d), new Complex(5d, -4.5d));
                var v = ov.swizzle.bggb;
                Assert.AreEqual(new Complex(-7d, 3d), v.x);
                Assert.AreEqual(new Complex(0.0, -4.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -4.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 5d), new Complex(5d, 1.0), new Complex(-0.5d, 6.5d), new Complex(-7.5d, -1d));
                var v = ov.swizzle.bgga;
                Assert.AreEqual(new Complex(-0.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(5d, 1.0), v.y);
                Assert.AreEqual(new Complex(5d, 1.0), v.z);
                Assert.AreEqual(new Complex(-7.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, -3d), new Complex(-6d, -9d), new Complex(-8.5d, -6d), new Complex(2.5d, -5d));
                var v = ov.swizzle.bgb;
                Assert.AreEqual(new Complex(-8.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-6d, -9d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(9d, 8d), new Complex(-7.5d, -2.5d), new Complex(3.5d, -9.5d), new Complex(8d, -8d));
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(new Complex(3.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -9.5d), v.z);
                Assert.AreEqual(new Complex(9d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, -7d), new Complex(1.0, -4.5d), new Complex(-9.5d, 6d), new Complex(-9.5d, -6.5d));
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(new Complex(-9.5d, 6d), v.x);
                Assert.AreEqual(new Complex(1.0, -4.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 6d), v.z);
                Assert.AreEqual(new Complex(1.0, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, -4d), new Complex(5.5d, 4d), new Complex(7.5d, -6d), new Complex(-7.5d, -4.5d));
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(new Complex(7.5d, -6d), v.x);
                Assert.AreEqual(new Complex(5.5d, 4d), v.y);
                Assert.AreEqual(new Complex(7.5d, -6d), v.z);
                Assert.AreEqual(new Complex(7.5d, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -2.5d), new Complex(1.0, 9d), new Complex(8.5d, 7.5d), new Complex(6d, 3.5d));
                var v = ov.swizzle.bgba;
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 9d), v.y);
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.z);
                Assert.AreEqual(new Complex(6d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -1d), new Complex(0.0, -8.5d), new Complex(4d, -4d), new Complex(4d, 5.5d));
                var v = ov.swizzle.bga;
                Assert.AreEqual(new Complex(4d, -4d), v.x);
                Assert.AreEqual(new Complex(0.0, -8.5d), v.y);
                Assert.AreEqual(new Complex(4d, 5.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-2d, -5.5d), new Complex(5d, 9d), new Complex(-8.5d, -8.5d), new Complex(-3d, 5.5d));
                var v = ov.swizzle.bgar;
                Assert.AreEqual(new Complex(-8.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(5d, 9d), v.y);
                Assert.AreEqual(new Complex(-3d, 5.5d), v.z);
                Assert.AreEqual(new Complex(-2d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, 1.5d), new Complex(-9.5d, -4d), new Complex(-4d, 3d), new Complex(-8d, 7.5d));
                var v = ov.swizzle.bgag;
                Assert.AreEqual(new Complex(-4d, 3d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -4d), v.y);
                Assert.AreEqual(new Complex(-8d, 7.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, -8d), new Complex(6.5d, -4.5d), new Complex(-4.5d, 7.5d), new Complex(8d, 5d));
                var v = ov.swizzle.bgab;
                Assert.AreEqual(new Complex(-4.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(8d, 5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(8.5d, 6.5d), new Complex(2d, 3d), new Complex(-4.5d, 8d), new Complex(-1.5d, -8.5d));
                var v = ov.swizzle.bgaa;
                Assert.AreEqual(new Complex(-4.5d, 8d), v.x);
                Assert.AreEqual(new Complex(2d, 3d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, -7.5d), new Complex(-4.5d, -7d), new Complex(-1.5d, 6d), new Complex(-8.5d, -1.5d));
                var v = ov.swizzle.bb;
                Assert.AreEqual(new Complex(-1.5d, 6d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 6d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-3d, -4.5d), new Complex(-3.5d, 1.0), new Complex(3d, 6d), new Complex(9.5d, 9d));
                var v = ov.swizzle.bbr;
                Assert.AreEqual(new Complex(3d, 6d), v.x);
                Assert.AreEqual(new Complex(3d, 6d), v.y);
                Assert.AreEqual(new Complex(-3d, -4.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(3d, 8d), new Complex(4.5d, -8d), new Complex(-9.5d, 8.5d), new Complex(-4.5d, 4.5d));
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(new Complex(-9.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(3d, 8d), v.z);
                Assert.AreEqual(new Complex(3d, 8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 4d), new Complex(-6.5d, 1.0), new Complex(0.0, 7.5d), new Complex(-8d, 0.5d));
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(new Complex(0.0, 7.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.y);
                Assert.AreEqual(new Complex(6d, 4d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 1.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 2d), new Complex(-6d, -8d), new Complex(-9.5d, -0.5d), new Complex(3d, 7.5d));
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 2d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 3d), new Complex(-9.5d, -6.5d), new Complex(-9d, -2.5d), new Complex(9.5d, 2d));
                var v = ov.swizzle.bbra;
                Assert.AreEqual(new Complex(-9d, -2.5d), v.x);
                Assert.AreEqual(new Complex(-9d, -2.5d), v.y);
                Assert.AreEqual(new Complex(1.0, 3d), v.z);
                Assert.AreEqual(new Complex(9.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, -7.5d), new Complex(1.0, 6d), new Complex(-4d, 2d), new Complex(6d, -0.5d));
                var v = ov.swizzle.bbg;
                Assert.AreEqual(new Complex(-4d, 2d), v.x);
                Assert.AreEqual(new Complex(-4d, 2d), v.y);
                Assert.AreEqual(new Complex(1.0, 6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(9d, 4d), new Complex(-0.5d, 8d), new Complex(-6.5d, -1.5d), new Complex(-6.5d, -7.5d));
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(new Complex(-6.5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 8d), v.z);
                Assert.AreEqual(new Complex(9d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, 0.0), new Complex(-1d, -4d), new Complex(0.5d, -2d), new Complex(5.5d, 4.5d));
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(new Complex(0.5d, -2d), v.x);
                Assert.AreEqual(new Complex(0.5d, -2d), v.y);
                Assert.AreEqual(new Complex(-1d, -4d), v.z);
                Assert.AreEqual(new Complex(-1d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3d, -5d), new Complex(-6.5d, -3.5d), new Complex(2.5d, 9d), new Complex(-3.5d, -7.5d));
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(new Complex(2.5d, 9d), v.x);
                Assert.AreEqual(new Complex(2.5d, 9d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, 1.0), new Complex(-7.5d, -2d), new Complex(9d, -4.5d), new Complex(5.5d, -4d));
                var v = ov.swizzle.bbga;
                Assert.AreEqual(new Complex(9d, -4.5d), v.x);
                Assert.AreEqual(new Complex(9d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, -2d), v.z);
                Assert.AreEqual(new Complex(5.5d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -6d), new Complex(-1.5d, 8d), new Complex(-2d, 1.5d), new Complex(-5.5d, -6d));
                var v = ov.swizzle.bbb;
                Assert.AreEqual(new Complex(-2d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-2d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 1.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(5.5d, -4.5d), new Complex(7d, 5d), new Complex(7.5d, 2d), new Complex(-6.5d, -7d));
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(new Complex(7.5d, 2d), v.x);
                Assert.AreEqual(new Complex(7.5d, 2d), v.y);
                Assert.AreEqual(new Complex(7.5d, 2d), v.z);
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7.5d, -4d), new Complex(-8.5d, 9d), new Complex(-2.5d, -5d), new Complex(6.5d, 8.5d));
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(new Complex(-2.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5d, -2.5d), new Complex(-0.5d, 3d), new Complex(3.5d, 6d), new Complex(-2d, -7d));
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(new Complex(3.5d, 6d), v.x);
                Assert.AreEqual(new Complex(3.5d, 6d), v.y);
                Assert.AreEqual(new Complex(3.5d, 6d), v.z);
                Assert.AreEqual(new Complex(3.5d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 6.5d), new Complex(6.5d, -8d), new Complex(0.5d, 2d), new Complex(-4d, 9.5d));
                var v = ov.swizzle.bbba;
                Assert.AreEqual(new Complex(0.5d, 2d), v.x);
                Assert.AreEqual(new Complex(0.5d, 2d), v.y);
                Assert.AreEqual(new Complex(0.5d, 2d), v.z);
                Assert.AreEqual(new Complex(-4d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, -2.5d), new Complex(7.5d, -6d), new Complex(8d, 1.5d), new Complex(5.5d, 0.5d));
                var v = ov.swizzle.bba;
                Assert.AreEqual(new Complex(8d, 1.5d), v.x);
                Assert.AreEqual(new Complex(8d, 1.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, 0.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(2.5d, -0.5d), new Complex(5d, 3d), new Complex(5d, -3d), new Complex(-1.5d, -7d));
                var v = ov.swizzle.bbar;
                Assert.AreEqual(new Complex(5d, -3d), v.x);
                Assert.AreEqual(new Complex(5d, -3d), v.y);
                Assert.AreEqual(new Complex(-1.5d, -7d), v.z);
                Assert.AreEqual(new Complex(2.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 8d), new Complex(4.5d, 6d), new Complex(1.0, 3.5d), new Complex(-9d, 2.5d));
                var v = ov.swizzle.bbag;
                Assert.AreEqual(new Complex(1.0, 3.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 3.5d), v.y);
                Assert.AreEqual(new Complex(-9d, 2.5d), v.z);
                Assert.AreEqual(new Complex(4.5d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, 6.5d), new Complex(-5.5d, -3d), new Complex(9.5d, -2.5d), new Complex(0.0, -1d));
                var v = ov.swizzle.bbab;
                Assert.AreEqual(new Complex(9.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -1d), v.z);
                Assert.AreEqual(new Complex(9.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, -6d), new Complex(-0.5d, -3.5d), new Complex(-2d, 3d), new Complex(1.0, 7.5d));
                var v = ov.swizzle.bbaa;
                Assert.AreEqual(new Complex(-2d, 3d), v.x);
                Assert.AreEqual(new Complex(-2d, 3d), v.y);
                Assert.AreEqual(new Complex(1.0, 7.5d), v.z);
                Assert.AreEqual(new Complex(1.0, 7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2.5d, 5d), new Complex(0.0, 9d), new Complex(1.0, 5d), new Complex(5.5d, 0.5d));
                var v = ov.swizzle.ba;
                Assert.AreEqual(new Complex(1.0, 5d), v.x);
                Assert.AreEqual(new Complex(5.5d, 0.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, 8.5d), new Complex(3.5d, -3d), new Complex(0.5d, 4d), new Complex(-5.5d, -1d));
                var v = ov.swizzle.bar;
                Assert.AreEqual(new Complex(0.5d, 4d), v.x);
                Assert.AreEqual(new Complex(-5.5d, -1d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 8.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -9d), new Complex(-9.5d, 1.5d), new Complex(-4d, -6.5d), new Complex(5d, -5.5d));
                var v = ov.swizzle.barr;
                Assert.AreEqual(new Complex(-4d, -6.5d), v.x);
                Assert.AreEqual(new Complex(5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, -9d), v.z);
                Assert.AreEqual(new Complex(0.5d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2.5d, 8d), new Complex(5.5d, -4.5d), new Complex(-5.5d, -5.5d), new Complex(1.0, 7.5d));
                var v = ov.swizzle.barg;
                Assert.AreEqual(new Complex(-5.5d, -5.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 7.5d), v.y);
                Assert.AreEqual(new Complex(2.5d, 8d), v.z);
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, -6d), new Complex(-7d, 0.0), new Complex(1.5d, -2.5d), new Complex(0.5d, -9.5d));
                var v = ov.swizzle.barb;
                Assert.AreEqual(new Complex(1.5d, -2.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(-9d, -6d), v.z);
                Assert.AreEqual(new Complex(1.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 0.5d), new Complex(8d, -5.5d), new Complex(9.5d, 7d), new Complex(-1.5d, 7d));
                var v = ov.swizzle.bara;
                Assert.AreEqual(new Complex(9.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 7d), v.y);
                Assert.AreEqual(new Complex(1.0, 0.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, -5d), new Complex(7d, -8.5d), new Complex(-2.5d, 0.0), new Complex(-7.5d, -4d));
                var v = ov.swizzle.bag;
                Assert.AreEqual(new Complex(-2.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-7.5d, -4d), v.y);
                Assert.AreEqual(new Complex(7d, -8.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, -7d), new Complex(2.5d, 3.5d), new Complex(-6.5d, 0.0), new Complex(-6.5d, 9d));
                var v = ov.swizzle.bagr;
                Assert.AreEqual(new Complex(-6.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-6.5d, 9d), v.y);
                Assert.AreEqual(new Complex(2.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, -7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, -2d), new Complex(-1.5d, 3d), new Complex(-7.5d, 4.5d), new Complex(-1d, -6d));
                var v = ov.swizzle.bagg;
                Assert.AreEqual(new Complex(-7.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(-1d, -6d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 3d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, 8d), new Complex(-4d, 1.0), new Complex(-2d, -0.5d), new Complex(9.5d, -7d));
                var v = ov.swizzle.bagb;
                Assert.AreEqual(new Complex(-2d, -0.5d), v.x);
                Assert.AreEqual(new Complex(9.5d, -7d), v.y);
                Assert.AreEqual(new Complex(-4d, 1.0), v.z);
                Assert.AreEqual(new Complex(-2d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 8.5d), new Complex(-7.5d, 2d), new Complex(7.5d, 7.5d), new Complex(3d, -5d));
                var v = ov.swizzle.baga;
                Assert.AreEqual(new Complex(7.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(3d, -5d), v.y);
                Assert.AreEqual(new Complex(-7.5d, 2d), v.z);
                Assert.AreEqual(new Complex(3d, -5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -7.5d), new Complex(6.5d, 9d), new Complex(-2.5d, -6.5d), new Complex(-5d, -1d));
                var v = ov.swizzle.bab;
                Assert.AreEqual(new Complex(-2.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-5d, -1d), v.y);
                Assert.AreEqual(new Complex(-2.5d, -6.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -0.5d), new Complex(7.5d, -2.5d), new Complex(-8.5d, 5.5d), new Complex(-3d, -3d));
                var v = ov.swizzle.babr;
                Assert.AreEqual(new Complex(-8.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-3d, -3d), v.y);
                Assert.AreEqual(new Complex(-8.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(9.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, 9.5d), new Complex(-8.5d, -5.5d), new Complex(0.0, 4d), new Complex(-6.5d, -9.5d));
                var v = ov.swizzle.babg;
                Assert.AreEqual(new Complex(0.0, 4d), v.x);
                Assert.AreEqual(new Complex(-6.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 4d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 1.0), new Complex(-3d, 8.5d), new Complex(-7d, -4d), new Complex(-6d, -6d));
                var v = ov.swizzle.babb;
                Assert.AreEqual(new Complex(-7d, -4d), v.x);
                Assert.AreEqual(new Complex(-6d, -6d), v.y);
                Assert.AreEqual(new Complex(-7d, -4d), v.z);
                Assert.AreEqual(new Complex(-7d, -4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 9d), new Complex(7d, -1.5d), new Complex(4.5d, 4.5d), new Complex(7.5d, -4.5d));
                var v = ov.swizzle.baba;
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(4.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7.5d, 0.5d), new Complex(1.5d, -3d), new Complex(-8.5d, -2d), new Complex(4d, 2d));
                var v = ov.swizzle.baa;
                Assert.AreEqual(new Complex(-8.5d, -2d), v.x);
                Assert.AreEqual(new Complex(4d, 2d), v.y);
                Assert.AreEqual(new Complex(4d, 2d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-3d, -0.5d), new Complex(-4d, 6d), new Complex(5d, -0.5d), new Complex(5d, -2d));
                var v = ov.swizzle.baar;
                Assert.AreEqual(new Complex(5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(5d, -2d), v.y);
                Assert.AreEqual(new Complex(5d, -2d), v.z);
                Assert.AreEqual(new Complex(-3d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, 9d), new Complex(2.5d, 9d), new Complex(-5d, -9d), new Complex(-9.5d, -1.5d));
                var v = ov.swizzle.baag;
                Assert.AreEqual(new Complex(-5d, -9d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, -3.5d), new Complex(5.5d, 1.5d), new Complex(7d, -6.5d), new Complex(-6.5d, 4d));
                var v = ov.swizzle.baab;
                Assert.AreEqual(new Complex(7d, -6.5d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 4d), v.y);
                Assert.AreEqual(new Complex(-6.5d, 4d), v.z);
                Assert.AreEqual(new Complex(7d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, 7.5d), new Complex(-2d, -1.5d), new Complex(-7.5d, -4.5d), new Complex(1.5d, -0.5d));
                var v = ov.swizzle.baaa;
                Assert.AreEqual(new Complex(-7.5d, -4.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -0.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, 6.5d), new Complex(9d, -3.5d), new Complex(-4.5d, 9d), new Complex(3d, -3.5d));
                var v = ov.swizzle.ar;
                Assert.AreEqual(new Complex(3d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-1d, 6.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 6.5d), new Complex(9.5d, -4d), new Complex(9d, -2d), new Complex(-6.5d, 7d));
                var v = ov.swizzle.arr;
                Assert.AreEqual(new Complex(-6.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 6.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -2.5d), new Complex(6.5d, -4d), new Complex(3.5d, 4d), new Complex(7d, 7d));
                var v = ov.swizzle.arrr;
                Assert.AreEqual(new Complex(7d, 7d), v.x);
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 7d), new Complex(0.0, 9d), new Complex(5d, -5.5d), new Complex(-0.5d, 8d));
                var v = ov.swizzle.arrg;
                Assert.AreEqual(new Complex(-0.5d, 8d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 7d), v.y);
                Assert.AreEqual(new Complex(-2.5d, 7d), v.z);
                Assert.AreEqual(new Complex(0.0, 9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 6.5d), new Complex(-6.5d, -8d), new Complex(1.0, -9d), new Complex(-3.5d, -9.5d));
                var v = ov.swizzle.arrb;
                Assert.AreEqual(new Complex(-3.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(-5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 6.5d), v.z);
                Assert.AreEqual(new Complex(1.0, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.5d, 5.5d), new Complex(-6d, -8.5d), new Complex(8d, 0.0), new Complex(5d, -1.5d));
                var v = ov.swizzle.arra;
                Assert.AreEqual(new Complex(5d, -1.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, 5.5d), v.z);
                Assert.AreEqual(new Complex(5d, -1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 2d), new Complex(-9.5d, -7d), new Complex(-2d, 1.5d), new Complex(5d, -1d));
                var v = ov.swizzle.arg;
                Assert.AreEqual(new Complex(5d, -1d), v.x);
                Assert.AreEqual(new Complex(6d, 2d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -7d), v.z);
            }
            {
                var ov = new cvec4(new Complex(5d, -3d), new Complex(4.5d, 9d), new Complex(5.5d, -8d), new Complex(4.5d, -7.5d));
                var v = ov.swizzle.argr;
                Assert.AreEqual(new Complex(4.5d, -7.5d), v.x);
                Assert.AreEqual(new Complex(5d, -3d), v.y);
                Assert.AreEqual(new Complex(4.5d, 9d), v.z);
                Assert.AreEqual(new Complex(5d, -3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 3d), new Complex(3d, 2d), new Complex(-3.5d, -2.5d), new Complex(-1.5d, 2d));
                var v = ov.swizzle.argg;
                Assert.AreEqual(new Complex(-1.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 3d), v.y);
                Assert.AreEqual(new Complex(3d, 2d), v.z);
                Assert.AreEqual(new Complex(3d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 0.0), new Complex(-7d, -5.5d), new Complex(-7d, 6d), new Complex(-4d, -5d));
                var v = ov.swizzle.argb;
                Assert.AreEqual(new Complex(-4d, -5d), v.x);
                Assert.AreEqual(new Complex(6d, 0.0), v.y);
                Assert.AreEqual(new Complex(-7d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-7d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, 2.5d), new Complex(-6.5d, -7.5d), new Complex(8d, -5.5d), new Complex(7d, 6.5d));
                var v = ov.swizzle.arga;
                Assert.AreEqual(new Complex(7d, 6.5d), v.x);
                Assert.AreEqual(new Complex(3d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -7.5d), v.z);
                Assert.AreEqual(new Complex(7d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, 4d), new Complex(7d, 9d), new Complex(3.5d, -9.5d), new Complex(-1d, -5d));
                var v = ov.swizzle.arb;
                Assert.AreEqual(new Complex(-1d, -5d), v.x);
                Assert.AreEqual(new Complex(9.5d, 4d), v.y);
                Assert.AreEqual(new Complex(3.5d, -9.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(0.5d, 4d), new Complex(-9d, -5d), new Complex(7d, 6d), new Complex(7.5d, -9.5d));
                var v = ov.swizzle.arbr;
                Assert.AreEqual(new Complex(7.5d, -9.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 4d), v.y);
                Assert.AreEqual(new Complex(7d, 6d), v.z);
                Assert.AreEqual(new Complex(0.5d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, 6d), new Complex(6.5d, 4d), new Complex(9.5d, 4.5d), new Complex(5.5d, -5d));
                var v = ov.swizzle.arbg;
                Assert.AreEqual(new Complex(5.5d, -5d), v.x);
                Assert.AreEqual(new Complex(-1d, 6d), v.y);
                Assert.AreEqual(new Complex(9.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 4d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, -6.5d), new Complex(-9d, -9.5d), new Complex(7.5d, -6.5d), new Complex(7d, -8d));
                var v = ov.swizzle.arbb;
                Assert.AreEqual(new Complex(7d, -8d), v.x);
                Assert.AreEqual(new Complex(1.0, -6.5d), v.y);
                Assert.AreEqual(new Complex(7.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, -8.5d), new Complex(3d, 9.5d), new Complex(-7d, 2.5d), new Complex(2d, -6d));
                var v = ov.swizzle.arba;
                Assert.AreEqual(new Complex(2d, -6d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(-7d, 2.5d), v.z);
                Assert.AreEqual(new Complex(2d, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, 3.5d), new Complex(8.5d, -6.5d), new Complex(-7.5d, 4d), new Complex(-5.5d, 2d));
                var v = ov.swizzle.ara;
                Assert.AreEqual(new Complex(-5.5d, 2d), v.x);
                Assert.AreEqual(new Complex(0.0, 3.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 2d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-4d, -6.5d), new Complex(-8d, -7.5d), new Complex(-6.5d, 5d), new Complex(8.5d, -2d));
                var v = ov.swizzle.arar;
                Assert.AreEqual(new Complex(8.5d, -2d), v.x);
                Assert.AreEqual(new Complex(-4d, -6.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, -2d), v.z);
                Assert.AreEqual(new Complex(-4d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 9d), new Complex(-1.5d, 3d), new Complex(-7.5d, -4.5d), new Complex(8d, -2d));
                var v = ov.swizzle.arag;
                Assert.AreEqual(new Complex(8d, -2d), v.x);
                Assert.AreEqual(new Complex(6d, 9d), v.y);
                Assert.AreEqual(new Complex(8d, -2d), v.z);
                Assert.AreEqual(new Complex(-1.5d, 3d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, 5.5d), new Complex(0.0, 2d), new Complex(6d, -6.5d), new Complex(8.5d, 3.5d));
                var v = ov.swizzle.arab;
                Assert.AreEqual(new Complex(8.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(6d, 5.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 3.5d), v.z);
                Assert.AreEqual(new Complex(6d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 6.5d), new Complex(1.0, -5d), new Complex(-6d, 5d), new Complex(-3.5d, 8.5d));
                var v = ov.swizzle.araa;
                Assert.AreEqual(new Complex(-3.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2.5d, 0.0), new Complex(7.5d, 8.5d), new Complex(-5.5d, -4d), new Complex(-0.5d, 8.5d));
                var v = ov.swizzle.ag;
                Assert.AreEqual(new Complex(-0.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 8.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(3d, 8d), new Complex(1.5d, -3d), new Complex(-3.5d, -8d), new Complex(-2.5d, -8.5d));
                var v = ov.swizzle.agr;
                Assert.AreEqual(new Complex(-2.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -3d), v.y);
                Assert.AreEqual(new Complex(3d, 8d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, 0.0), new Complex(8d, -3.5d), new Complex(-3.5d, 4.5d), new Complex(9.5d, 3.5d));
                var v = ov.swizzle.agrr;
                Assert.AreEqual(new Complex(9.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(8d, -3.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(-9.5d, 0.0), v.w);
            }
            {
                var ov = new cvec4(new Complex(5d, -2.5d), new Complex(6d, 5d), new Complex(7d, 0.0), new Complex(0.0, -9.5d));
                var v = ov.swizzle.agrg;
                Assert.AreEqual(new Complex(0.0, -9.5d), v.x);
                Assert.AreEqual(new Complex(6d, 5d), v.y);
                Assert.AreEqual(new Complex(5d, -2.5d), v.z);
                Assert.AreEqual(new Complex(6d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 4d), new Complex(9d, -6d), new Complex(6.5d, 2.5d), new Complex(-2d, -9.5d));
                var v = ov.swizzle.agrb;
                Assert.AreEqual(new Complex(-2d, -9.5d), v.x);
                Assert.AreEqual(new Complex(9d, -6d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 4d), v.z);
                Assert.AreEqual(new Complex(6.5d, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, 8d), new Complex(8d, 4.5d), new Complex(1.5d, 7d), new Complex(-6.5d, 2d));
                var v = ov.swizzle.agra;
                Assert.AreEqual(new Complex(-6.5d, 2d), v.x);
                Assert.AreEqual(new Complex(8d, 4.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, 8d), v.z);
                Assert.AreEqual(new Complex(-6.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4d, -8d), new Complex(1.5d, -9.5d), new Complex(-1.5d, -8d), new Complex(1.0, -8d));
                var v = ov.swizzle.agg;
                Assert.AreEqual(new Complex(1.0, -8d), v.x);
                Assert.AreEqual(new Complex(1.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -9.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-2d, 4.5d), new Complex(8.5d, 0.5d), new Complex(-8.5d, -8.5d), new Complex(-3.5d, 4d));
                var v = ov.swizzle.aggr;
                Assert.AreEqual(new Complex(-3.5d, 4d), v.x);
                Assert.AreEqual(new Complex(8.5d, 0.5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(-2d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 3.5d), new Complex(0.5d, 4.5d), new Complex(-6d, -6d), new Complex(2d, 5.5d));
                var v = ov.swizzle.aggg;
                Assert.AreEqual(new Complex(2d, 5.5d), v.x);
                Assert.AreEqual(new Complex(0.5d, 4.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 4.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 4.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5d, 6d), new Complex(2.5d, 6d), new Complex(-9.5d, 1.5d), new Complex(-6.5d, 9d));
                var v = ov.swizzle.aggb;
                Assert.AreEqual(new Complex(-6.5d, 9d), v.x);
                Assert.AreEqual(new Complex(2.5d, 6d), v.y);
                Assert.AreEqual(new Complex(2.5d, 6d), v.z);
                Assert.AreEqual(new Complex(-9.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2.5d, 4d), new Complex(5.5d, -4.5d), new Complex(-9d, 9d), new Complex(7.5d, -6.5d));
                var v = ov.swizzle.agga;
                Assert.AreEqual(new Complex(7.5d, -6.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, 7d), new Complex(-7.5d, 1.5d), new Complex(2d, -6.5d), new Complex(0.0, -2.5d));
                var v = ov.swizzle.agb;
                Assert.AreEqual(new Complex(0.0, -2.5d), v.x);
                Assert.AreEqual(new Complex(-7.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(2d, -6.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(3.5d, 2d), new Complex(6d, 0.0), new Complex(-3d, -3.5d), new Complex(-7d, -9d));
                var v = ov.swizzle.agbr;
                Assert.AreEqual(new Complex(-7d, -9d), v.x);
                Assert.AreEqual(new Complex(6d, 0.0), v.y);
                Assert.AreEqual(new Complex(-3d, -3.5d), v.z);
                Assert.AreEqual(new Complex(3.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, -6.5d), new Complex(3d, -5.5d), new Complex(0.5d, 0.5d), new Complex(-8d, 4d));
                var v = ov.swizzle.agbg;
                Assert.AreEqual(new Complex(-8d, 4d), v.x);
                Assert.AreEqual(new Complex(3d, -5.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.z);
                Assert.AreEqual(new Complex(3d, -5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6d, -1.5d), new Complex(1.0, 8d), new Complex(-6d, -8d), new Complex(-2d, -0.5d));
                var v = ov.swizzle.agbb;
                Assert.AreEqual(new Complex(-2d, -0.5d), v.x);
                Assert.AreEqual(new Complex(1.0, 8d), v.y);
                Assert.AreEqual(new Complex(-6d, -8d), v.z);
                Assert.AreEqual(new Complex(-6d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(2d, 2.5d), new Complex(-5.5d, 7.5d), new Complex(-5d, -5.5d), new Complex(-8.5d, -1d));
                var v = ov.swizzle.agba;
                Assert.AreEqual(new Complex(-8.5d, -1d), v.x);
                Assert.AreEqual(new Complex(-5.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(-5d, -5.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -1d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 4d), new Complex(0.0, -1.5d), new Complex(-1d, 8.5d), new Complex(-5d, 3.5d));
                var v = ov.swizzle.aga;
                Assert.AreEqual(new Complex(-5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(0.0, -1.5d), v.y);
                Assert.AreEqual(new Complex(-5d, 3.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(0.5d, 0.5d), new Complex(4d, 2d), new Complex(-3.5d, -3d), new Complex(3.5d, 8.5d));
                var v = ov.swizzle.agar;
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(4d, 2d), v.y);
                Assert.AreEqual(new Complex(3.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(0.5d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-0.5d, -5.5d), new Complex(-4d, -9.5d), new Complex(-9.5d, -6d), new Complex(0.0, -8.5d));
                var v = ov.swizzle.agag;
                Assert.AreEqual(new Complex(0.0, -8.5d), v.x);
                Assert.AreEqual(new Complex(-4d, -9.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -8.5d), v.z);
                Assert.AreEqual(new Complex(-4d, -9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -4.5d), new Complex(3.5d, -5.5d), new Complex(-8.5d, 3.5d), new Complex(1.5d, -3.5d));
                var v = ov.swizzle.agab;
                Assert.AreEqual(new Complex(1.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(1.5d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1.5d, 5.5d), new Complex(-2.5d, -1.5d), new Complex(8d, -6d), new Complex(5d, 2.5d));
                var v = ov.swizzle.agaa;
                Assert.AreEqual(new Complex(5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(5d, 2.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-3.5d, 1.0), new Complex(4d, 0.0), new Complex(-8.5d, -9.5d), new Complex(-4.5d, 7d));
                var v = ov.swizzle.ab;
                Assert.AreEqual(new Complex(-4.5d, 7d), v.x);
                Assert.AreEqual(new Complex(-8.5d, -9.5d), v.y);
            }
            {
                var ov = new cvec4(new Complex(0.0, 2d), new Complex(8.5d, -1d), new Complex(6.5d, 7d), new Complex(-3d, 6.5d));
                var v = ov.swizzle.abr;
                Assert.AreEqual(new Complex(-3d, 6.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 7d), v.y);
                Assert.AreEqual(new Complex(0.0, 2d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-6d, -3.5d), new Complex(8d, 0.0), new Complex(-9.5d, -5d), new Complex(7d, 4d));
                var v = ov.swizzle.abrr;
                Assert.AreEqual(new Complex(7d, 4d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -5d), v.y);
                Assert.AreEqual(new Complex(-6d, -3.5d), v.z);
                Assert.AreEqual(new Complex(-6d, -3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, 9.5d), new Complex(7.5d, 9.5d), new Complex(9d, -7d), new Complex(0.0, -8d));
                var v = ov.swizzle.abrg;
                Assert.AreEqual(new Complex(0.0, -8d), v.x);
                Assert.AreEqual(new Complex(9d, -7d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(7.5d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, 1.5d), new Complex(-2.5d, 0.5d), new Complex(9d, 6.5d), new Complex(-1.5d, 7.5d));
                var v = ov.swizzle.abrb;
                Assert.AreEqual(new Complex(-1.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(9d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 1.5d), v.z);
                Assert.AreEqual(new Complex(9d, 6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -1.5d), new Complex(-9d, -1.5d), new Complex(-2.5d, 5.5d), new Complex(1.5d, 2d));
                var v = ov.swizzle.abra;
                Assert.AreEqual(new Complex(1.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-2.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -1.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 7d), new Complex(0.5d, 6d), new Complex(-2.5d, -9.5d), new Complex(-4d, 3d));
                var v = ov.swizzle.abg;
                Assert.AreEqual(new Complex(-4d, 3d), v.x);
                Assert.AreEqual(new Complex(-2.5d, -9.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, -6d), new Complex(-5.5d, 2.5d), new Complex(-6.5d, 3.5d), new Complex(-6d, 4d));
                var v = ov.swizzle.abgr;
                Assert.AreEqual(new Complex(-6d, 4d), v.x);
                Assert.AreEqual(new Complex(-6.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-5.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-6d, -9d), new Complex(8d, 0.5d), new Complex(5.5d, 8d), new Complex(-5.5d, 2d));
                var v = ov.swizzle.abgg;
                Assert.AreEqual(new Complex(-5.5d, 2d), v.x);
                Assert.AreEqual(new Complex(5.5d, 8d), v.y);
                Assert.AreEqual(new Complex(8d, 0.5d), v.z);
                Assert.AreEqual(new Complex(8d, 0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, 7d), new Complex(-3.5d, 1.5d), new Complex(-5d, -1.5d), new Complex(2.5d, -9d));
                var v = ov.swizzle.abgb;
                Assert.AreEqual(new Complex(2.5d, -9d), v.x);
                Assert.AreEqual(new Complex(-5d, -1.5d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-5d, -1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(7d, 4.5d), new Complex(-3d, -5d), new Complex(-8d, 9d), new Complex(-8.5d, -8.5d));
                var v = ov.swizzle.abga;
                Assert.AreEqual(new Complex(-8.5d, -8.5d), v.x);
                Assert.AreEqual(new Complex(-8d, 9d), v.y);
                Assert.AreEqual(new Complex(-3d, -5d), v.z);
                Assert.AreEqual(new Complex(-8.5d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4.5d, 4d), new Complex(-3d, 8d), new Complex(-9.5d, -7.5d), new Complex(2.5d, -3.5d));
                var v = ov.swizzle.abb;
                Assert.AreEqual(new Complex(2.5d, -3.5d), v.x);
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, -7.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 5d), new Complex(-8.5d, -3d), new Complex(-9.5d, 2.5d), new Complex(1.0, 3d));
                var v = ov.swizzle.abbr;
                Assert.AreEqual(new Complex(1.0, 3d), v.x);
                Assert.AreEqual(new Complex(-9.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 2.5d), v.z);
                Assert.AreEqual(new Complex(-5.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, -0.5d), new Complex(-9.5d, -9d), new Complex(-3.5d, 4d), new Complex(6d, -1d));
                var v = ov.swizzle.abbg;
                Assert.AreEqual(new Complex(6d, -1d), v.x);
                Assert.AreEqual(new Complex(-3.5d, 4d), v.y);
                Assert.AreEqual(new Complex(-3.5d, 4d), v.z);
                Assert.AreEqual(new Complex(-9.5d, -9d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-7d, 5d), new Complex(0.5d, -7d), new Complex(0.0, 7.5d), new Complex(9d, 5.5d));
                var v = ov.swizzle.abbb;
                Assert.AreEqual(new Complex(9d, 5.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.z);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-1d, -0.5d), new Complex(-6.5d, 2d), new Complex(3.5d, -8.5d), new Complex(1.5d, 3.5d));
                var v = ov.swizzle.abba;
                Assert.AreEqual(new Complex(1.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(3.5d, -8.5d), v.y);
                Assert.AreEqual(new Complex(3.5d, -8.5d), v.z);
                Assert.AreEqual(new Complex(1.5d, 3.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, 7d), new Complex(4d, 8d), new Complex(1.5d, -4.5d), new Complex(-2d, 7d));
                var v = ov.swizzle.aba;
                Assert.AreEqual(new Complex(-2d, 7d), v.x);
                Assert.AreEqual(new Complex(1.5d, -4.5d), v.y);
                Assert.AreEqual(new Complex(-2d, 7d), v.z);
            }
            {
                var ov = new cvec4(new Complex(2d, -1.5d), new Complex(-3.5d, -4d), new Complex(-8.5d, 9d), new Complex(-4.5d, 0.0));
                var v = ov.swizzle.abar;
                Assert.AreEqual(new Complex(-4.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(-8.5d, 9d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 0.0), v.z);
                Assert.AreEqual(new Complex(2d, -1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-2d, 9.5d), new Complex(-8d, -7d), new Complex(-8.5d, 0.0), new Complex(7d, -1d));
                var v = ov.swizzle.abag;
                Assert.AreEqual(new Complex(7d, -1d), v.x);
                Assert.AreEqual(new Complex(-8.5d, 0.0), v.y);
                Assert.AreEqual(new Complex(7d, -1d), v.z);
                Assert.AreEqual(new Complex(-8d, -7d), v.w);
            }
            {
                var ov = new cvec4(new Complex(1.0, -7d), new Complex(6d, -2d), new Complex(6.5d, 8.5d), new Complex(-1d, 6.5d));
                var v = ov.swizzle.abab;
                Assert.AreEqual(new Complex(-1d, 6.5d), v.x);
                Assert.AreEqual(new Complex(6.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-1d, 6.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9d, -7.5d), new Complex(4.5d, 4.5d), new Complex(-0.5d, 7.5d), new Complex(9.5d, 2d));
                var v = ov.swizzle.abaa;
                Assert.AreEqual(new Complex(9.5d, 2d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 7.5d), v.y);
                Assert.AreEqual(new Complex(9.5d, 2d), v.z);
                Assert.AreEqual(new Complex(9.5d, 2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3d, 8.5d), new Complex(-7.5d, -1.5d), new Complex(8.5d, -5d), new Complex(6.5d, 0.0));
                var v = ov.swizzle.aa;
                Assert.AreEqual(new Complex(6.5d, 0.0), v.x);
                Assert.AreEqual(new Complex(6.5d, 0.0), v.y);
            }
            {
                var ov = new cvec4(new Complex(-6.5d, -3.5d), new Complex(-1.5d, 5.5d), new Complex(6d, 4.5d), new Complex(-0.5d, 1.5d));
                var v = ov.swizzle.aar;
                Assert.AreEqual(new Complex(-0.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-6.5d, -3.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(-4.5d, 1.5d), new Complex(4d, 0.5d), new Complex(-8.5d, -1.5d), new Complex(-4.5d, 2.5d));
                var v = ov.swizzle.aarr;
                Assert.AreEqual(new Complex(-4.5d, 2.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 2.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 1.5d), v.z);
                Assert.AreEqual(new Complex(-4.5d, 1.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, 4.5d), new Complex(-3.5d, -6d), new Complex(6.5d, -4d), new Complex(-0.5d, 3.5d));
                var v = ov.swizzle.aarg;
                Assert.AreEqual(new Complex(-0.5d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 3.5d), v.y);
                Assert.AreEqual(new Complex(-9d, 4.5d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-8.5d, -6.5d), new Complex(8d, -3d), new Complex(-0.5d, 5.5d), new Complex(7.5d, 1.5d));
                var v = ov.swizzle.aarb;
                Assert.AreEqual(new Complex(7.5d, 1.5d), v.x);
                Assert.AreEqual(new Complex(7.5d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-8.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(-0.5d, 5.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.0, 1.0), new Complex(5.5d, 2.5d), new Complex(-0.5d, 4d), new Complex(9.5d, -2d));
                var v = ov.swizzle.aara;
                Assert.AreEqual(new Complex(9.5d, -2d), v.x);
                Assert.AreEqual(new Complex(9.5d, -2d), v.y);
                Assert.AreEqual(new Complex(0.0, 1.0), v.z);
                Assert.AreEqual(new Complex(9.5d, -2d), v.w);
            }
            {
                var ov = new cvec4(new Complex(9.5d, -8d), new Complex(-8d, 1.5d), new Complex(4d, 2.5d), new Complex(9d, 1.5d));
                var v = ov.swizzle.aag;
                Assert.AreEqual(new Complex(9d, 1.5d), v.x);
                Assert.AreEqual(new Complex(9d, 1.5d), v.y);
                Assert.AreEqual(new Complex(-8d, 1.5d), v.z);
            }
            {
                var ov = new cvec4(new Complex(3.5d, -8d), new Complex(0.5d, 1.0), new Complex(0.0, -2d), new Complex(-6d, 5.5d));
                var v = ov.swizzle.aagr;
                Assert.AreEqual(new Complex(-6d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-6d, 5.5d), v.y);
                Assert.AreEqual(new Complex(0.5d, 1.0), v.z);
                Assert.AreEqual(new Complex(3.5d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, 4d), new Complex(4.5d, -8d), new Complex(-2.5d, 3.5d), new Complex(2d, -8d));
                var v = ov.swizzle.aagg;
                Assert.AreEqual(new Complex(2d, -8d), v.x);
                Assert.AreEqual(new Complex(2d, -8d), v.y);
                Assert.AreEqual(new Complex(4.5d, -8d), v.z);
                Assert.AreEqual(new Complex(4.5d, -8d), v.w);
            }
            {
                var ov = new cvec4(new Complex(5d, 4.5d), new Complex(5.5d, -4.5d), new Complex(-1.5d, -7.5d), new Complex(-4d, 3.5d));
                var v = ov.swizzle.aagb;
                Assert.AreEqual(new Complex(-4d, 3.5d), v.x);
                Assert.AreEqual(new Complex(-4d, 3.5d), v.y);
                Assert.AreEqual(new Complex(5.5d, -4.5d), v.z);
                Assert.AreEqual(new Complex(-1.5d, -7.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9d, -8d), new Complex(1.5d, -9d), new Complex(9.5d, 8d), new Complex(7d, 6d));
                var v = ov.swizzle.aaga;
                Assert.AreEqual(new Complex(7d, 6d), v.x);
                Assert.AreEqual(new Complex(7d, 6d), v.y);
                Assert.AreEqual(new Complex(1.5d, -9d), v.z);
                Assert.AreEqual(new Complex(7d, 6d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -0.5d), new Complex(5.5d, 7d), new Complex(-1.5d, -7d), new Complex(-6d, 0.0));
                var v = ov.swizzle.aab;
                Assert.AreEqual(new Complex(-6d, 0.0), v.x);
                Assert.AreEqual(new Complex(-6d, 0.0), v.y);
                Assert.AreEqual(new Complex(-1.5d, -7d), v.z);
            }
            {
                var ov = new cvec4(new Complex(9d, 8.5d), new Complex(7d, 2d), new Complex(0.5d, -3d), new Complex(1.0, 7d));
                var v = ov.swizzle.aabr;
                Assert.AreEqual(new Complex(1.0, 7d), v.x);
                Assert.AreEqual(new Complex(1.0, 7d), v.y);
                Assert.AreEqual(new Complex(0.5d, -3d), v.z);
                Assert.AreEqual(new Complex(9d, 8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, 6.5d), new Complex(2.5d, 5d), new Complex(8.5d, 9.5d), new Complex(8d, 5d));
                var v = ov.swizzle.aabg;
                Assert.AreEqual(new Complex(8d, 5d), v.x);
                Assert.AreEqual(new Complex(8d, 5d), v.y);
                Assert.AreEqual(new Complex(8.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(2.5d, 5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(3.5d, -6.5d), new Complex(9.5d, 2d), new Complex(6.5d, -6.5d), new Complex(4d, 2.5d));
                var v = ov.swizzle.aabb;
                Assert.AreEqual(new Complex(4d, 2.5d), v.x);
                Assert.AreEqual(new Complex(4d, 2.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -6.5d), v.z);
                Assert.AreEqual(new Complex(6.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-5.5d, 0.0), new Complex(7.5d, 3d), new Complex(6.5d, -3d), new Complex(5.5d, -0.5d));
                var v = ov.swizzle.aaba;
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.x);
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.y);
                Assert.AreEqual(new Complex(6.5d, -3d), v.z);
                Assert.AreEqual(new Complex(5.5d, -0.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(4d, -7d), new Complex(4d, 1.5d), new Complex(2.5d, -1.5d), new Complex(-4.5d, -6d));
                var v = ov.swizzle.aaa;
                Assert.AreEqual(new Complex(-4.5d, -6d), v.x);
                Assert.AreEqual(new Complex(-4.5d, -6d), v.y);
                Assert.AreEqual(new Complex(-4.5d, -6d), v.z);
            }
            {
                var ov = new cvec4(new Complex(8.5d, -6.5d), new Complex(3.5d, 4.5d), new Complex(-6.5d, 7.5d), new Complex(-4.5d, 8.5d));
                var v = ov.swizzle.aaar;
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v.x);
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v.y);
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v.z);
                Assert.AreEqual(new Complex(8.5d, -6.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(-9.5d, 1.5d), new Complex(-5d, 9.5d), new Complex(-9d, -2d), new Complex(8d, -7.5d));
                var v = ov.swizzle.aaag;
                Assert.AreEqual(new Complex(8d, -7.5d), v.x);
                Assert.AreEqual(new Complex(8d, -7.5d), v.y);
                Assert.AreEqual(new Complex(8d, -7.5d), v.z);
                Assert.AreEqual(new Complex(-5d, 9.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(6.5d, -6.5d), new Complex(-8.5d, 6.5d), new Complex(2d, -8.5d), new Complex(4d, 7d));
                var v = ov.swizzle.aaab;
                Assert.AreEqual(new Complex(4d, 7d), v.x);
                Assert.AreEqual(new Complex(4d, 7d), v.y);
                Assert.AreEqual(new Complex(4d, 7d), v.z);
                Assert.AreEqual(new Complex(2d, -8.5d), v.w);
            }
            {
                var ov = new cvec4(new Complex(0.5d, -4d), new Complex(-0.5d, 2.5d), new Complex(9.5d, 2.5d), new Complex(-3.5d, -3d));
                var v = ov.swizzle.aaaa;
                Assert.AreEqual(new Complex(-3.5d, -3d), v.x);
                Assert.AreEqual(new Complex(-3.5d, -3d), v.y);
                Assert.AreEqual(new Complex(-3.5d, -3d), v.z);
                Assert.AreEqual(new Complex(-3.5d, -3d), v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new cvec4(new Complex(1.0, 9d), new Complex(-0.5d, 0.5d), new Complex(5d, -6.5d), new Complex(-7.5d, -7d));
                var v1 = new cvec2(new Complex(6.5d, 5.5d), new Complex(6d, 1.5d));
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(6.5d, 5.5d), v0.x);
                Assert.AreEqual(new Complex(6d, 1.5d), v0.y);
                Assert.AreEqual(new Complex(5d, -6.5d), v0.z);
                Assert.AreEqual(new Complex(-7.5d, -7d), v0.w);
            
                Assert.AreEqual(new Complex(1.0, 9d), v2.x);
                Assert.AreEqual(new Complex(-0.5d, 0.5d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(-2d, -5.5d), new Complex(4d, 0.5d), new Complex(4.5d, 4d), new Complex(7.5d, 9.5d));
                var v1 = new cvec2(new Complex(6.5d, 4.5d), new Complex(-3d, 6.5d));
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(6.5d, 4.5d), v0.x);
                Assert.AreEqual(new Complex(4d, 0.5d), v0.y);
                Assert.AreEqual(new Complex(-3d, 6.5d), v0.z);
                Assert.AreEqual(new Complex(7.5d, 9.5d), v0.w);
            
                Assert.AreEqual(new Complex(-2d, -5.5d), v2.x);
                Assert.AreEqual(new Complex(4.5d, 4d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(9d, 1.5d), new Complex(-2d, 8.5d), new Complex(-1.5d, 5d), new Complex(4d, 8d));
                var v1 = new cvec2(new Complex(7.5d, -3d), new Complex(-7d, -6d));
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(9d, 1.5d), v0.x);
                Assert.AreEqual(new Complex(7.5d, -3d), v0.y);
                Assert.AreEqual(new Complex(-7d, -6d), v0.z);
                Assert.AreEqual(new Complex(4d, 8d), v0.w);
            
                Assert.AreEqual(new Complex(-2d, 8.5d), v2.x);
                Assert.AreEqual(new Complex(-1.5d, 5d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(7d, -5d), new Complex(0.5d, 2.5d), new Complex(7d, -7d), new Complex(9d, 6.5d));
                var v1 = new cvec3(new Complex(7d, 0.5d), new Complex(1.5d, -2d), new Complex(0.5d, 8.5d));
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(7d, 0.5d), v0.x);
                Assert.AreEqual(new Complex(1.5d, -2d), v0.y);
                Assert.AreEqual(new Complex(0.5d, 8.5d), v0.z);
                Assert.AreEqual(new Complex(9d, 6.5d), v0.w);
            
                Assert.AreEqual(new Complex(7d, -5d), v2.x);
                Assert.AreEqual(new Complex(0.5d, 2.5d), v2.y);
                Assert.AreEqual(new Complex(7d, -7d), v2.z);
            }
            {
                var v0 = new cvec4(new Complex(5d, -2.5d), new Complex(-4.5d, 8.5d), new Complex(1.5d, -6.5d), new Complex(-8.5d, 3.5d));
                var v1 = new cvec2(new Complex(2d, -1.5d), new Complex(-2d, 9.5d));
                var v2 = v0.xw;
                v0.xw = v1;
                var v3 = v0.xw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(2d, -1.5d), v0.x);
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v0.y);
                Assert.AreEqual(new Complex(1.5d, -6.5d), v0.z);
                Assert.AreEqual(new Complex(-2d, 9.5d), v0.w);
            
                Assert.AreEqual(new Complex(5d, -2.5d), v2.x);
                Assert.AreEqual(new Complex(-8.5d, 3.5d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(-3.5d, -3d), new Complex(-3.5d, -6.5d), new Complex(-2.5d, -2d), new Complex(6d, 4.5d));
                var v1 = new cvec2(new Complex(-1.5d, -0.5d), new Complex(0.0, -7d));
                var v2 = v0.yw;
                v0.yw = v1;
                var v3 = v0.yw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-3.5d, -3d), v0.x);
                Assert.AreEqual(new Complex(-1.5d, -0.5d), v0.y);
                Assert.AreEqual(new Complex(-2.5d, -2d), v0.z);
                Assert.AreEqual(new Complex(0.0, -7d), v0.w);
            
                Assert.AreEqual(new Complex(-3.5d, -6.5d), v2.x);
                Assert.AreEqual(new Complex(6d, 4.5d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(-8d, -2d), new Complex(-4.5d, 2d), new Complex(7.5d, 5d), new Complex(-5.5d, -1d));
                var v1 = new cvec3(new Complex(9d, 3.5d), new Complex(5d, -6.5d), new Complex(5d, -6.5d));
                var v2 = v0.xyw;
                v0.xyw = v1;
                var v3 = v0.xyw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(9d, 3.5d), v0.x);
                Assert.AreEqual(new Complex(5d, -6.5d), v0.y);
                Assert.AreEqual(new Complex(7.5d, 5d), v0.z);
                Assert.AreEqual(new Complex(5d, -6.5d), v0.w);
            
                Assert.AreEqual(new Complex(-8d, -2d), v2.x);
                Assert.AreEqual(new Complex(-4.5d, 2d), v2.y);
                Assert.AreEqual(new Complex(-5.5d, -1d), v2.z);
            }
            {
                var v0 = new cvec4(new Complex(-2d, 2.5d), new Complex(-2.5d, 4.5d), new Complex(-5d, 0.0), new Complex(1.0, -8.5d));
                var v1 = new cvec2(new Complex(7.5d, -1.5d), new Complex(-7d, -2.5d));
                var v2 = v0.zw;
                v0.zw = v1;
                var v3 = v0.zw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-2d, 2.5d), v0.x);
                Assert.AreEqual(new Complex(-2.5d, 4.5d), v0.y);
                Assert.AreEqual(new Complex(7.5d, -1.5d), v0.z);
                Assert.AreEqual(new Complex(-7d, -2.5d), v0.w);
            
                Assert.AreEqual(new Complex(-5d, 0.0), v2.x);
                Assert.AreEqual(new Complex(1.0, -8.5d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(1.0, 5d), new Complex(-3.5d, 5d), new Complex(7.5d, -9.5d), new Complex(-8d, 6.5d));
                var v1 = new cvec3(new Complex(8.5d, 5d), new Complex(1.5d, -3d), new Complex(-8.5d, 7.5d));
                var v2 = v0.xzw;
                v0.xzw = v1;
                var v3 = v0.xzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(8.5d, 5d), v0.x);
                Assert.AreEqual(new Complex(-3.5d, 5d), v0.y);
                Assert.AreEqual(new Complex(1.5d, -3d), v0.z);
                Assert.AreEqual(new Complex(-8.5d, 7.5d), v0.w);
            
                Assert.AreEqual(new Complex(1.0, 5d), v2.x);
                Assert.AreEqual(new Complex(7.5d, -9.5d), v2.y);
                Assert.AreEqual(new Complex(-8d, 6.5d), v2.z);
            }
            {
                var v0 = new cvec4(new Complex(-5d, -2d), new Complex(1.5d, -9d), new Complex(1.5d, 5d), new Complex(-8.5d, 2.5d));
                var v1 = new cvec3(new Complex(-8.5d, 1.0), new Complex(-6.5d, 7.5d), new Complex(1.5d, -5d));
                var v2 = v0.yzw;
                v0.yzw = v1;
                var v3 = v0.yzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-5d, -2d), v0.x);
                Assert.AreEqual(new Complex(-8.5d, 1.0), v0.y);
                Assert.AreEqual(new Complex(-6.5d, 7.5d), v0.z);
                Assert.AreEqual(new Complex(1.5d, -5d), v0.w);
            
                Assert.AreEqual(new Complex(1.5d, -9d), v2.x);
                Assert.AreEqual(new Complex(1.5d, 5d), v2.y);
                Assert.AreEqual(new Complex(-8.5d, 2.5d), v2.z);
            }
            {
                var v0 = new cvec4(new Complex(-4.5d, 8.5d), new Complex(-1d, -9d), new Complex(-2.5d, -4d), new Complex(-6.5d, -9.5d));
                var v1 = new cvec4(new Complex(5d, 1.0), new Complex(9.5d, -6d), new Complex(3d, -0.5d), new Complex(-9d, 9.5d));
                var v2 = v0.xyzw;
                v0.xyzw = v1;
                var v3 = v0.xyzw;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(5d, 1.0), v0.x);
                Assert.AreEqual(new Complex(9.5d, -6d), v0.y);
                Assert.AreEqual(new Complex(3d, -0.5d), v0.z);
                Assert.AreEqual(new Complex(-9d, 9.5d), v0.w);
            
                Assert.AreEqual(new Complex(-4.5d, 8.5d), v2.x);
                Assert.AreEqual(new Complex(-1d, -9d), v2.y);
                Assert.AreEqual(new Complex(-2.5d, -4d), v2.z);
                Assert.AreEqual(new Complex(-6.5d, -9.5d), v2.w);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new cvec4(new Complex(9.5d, -3.5d), new Complex(5.5d, 6.5d), new Complex(-4.5d, 4.5d), new Complex(6.5d, -1d));
                var v1 = new Complex(-2d, -2.5d);
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-2d, -2.5d), v0.x);
                Assert.AreEqual(new Complex(5.5d, 6.5d), v0.y);
                Assert.AreEqual(new Complex(-4.5d, 4.5d), v0.z);
                Assert.AreEqual(new Complex(6.5d, -1d), v0.w);
            
                Assert.AreEqual(new Complex(9.5d, -3.5d), v2);
            }
            {
                var v0 = new cvec4(new Complex(0.0, 0.0), new Complex(-6.5d, -5.5d), new Complex(0.5d, 9.5d), new Complex(-7d, -5d));
                var v1 = new Complex(5d, -6.5d);
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(0.0, 0.0), v0.x);
                Assert.AreEqual(new Complex(5d, -6.5d), v0.y);
                Assert.AreEqual(new Complex(0.5d, 9.5d), v0.z);
                Assert.AreEqual(new Complex(-7d, -5d), v0.w);
            
                Assert.AreEqual(new Complex(-6.5d, -5.5d), v2);
            }
            {
                var v0 = new cvec4(new Complex(-2.5d, -4d), new Complex(1.5d, 8d), new Complex(-3d, 2d), new Complex(0.0, 4d));
                var v1 = new cvec2(new Complex(1.5d, -2d), new Complex(-8d, -9d));
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(1.5d, -2d), v0.x);
                Assert.AreEqual(new Complex(-8d, -9d), v0.y);
                Assert.AreEqual(new Complex(-3d, 2d), v0.z);
                Assert.AreEqual(new Complex(0.0, 4d), v0.w);
            
                Assert.AreEqual(new Complex(-2.5d, -4d), v2.x);
                Assert.AreEqual(new Complex(1.5d, 8d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(4.5d, 8d), new Complex(-8.5d, -9.5d), new Complex(-4d, 5.5d), new Complex(-7d, -6d));
                var v1 = new Complex(5.5d, 3d);
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(4.5d, 8d), v0.x);
                Assert.AreEqual(new Complex(-8.5d, -9.5d), v0.y);
                Assert.AreEqual(new Complex(5.5d, 3d), v0.z);
                Assert.AreEqual(new Complex(-7d, -6d), v0.w);
            
                Assert.AreEqual(new Complex(-4d, 5.5d), v2);
            }
            {
                var v0 = new cvec4(new Complex(2d, 5.5d), new Complex(5d, 9.5d), new Complex(-2d, 7d), new Complex(4d, -4d));
                var v1 = new cvec2(new Complex(6.5d, 7d), new Complex(4d, 0.0));
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(6.5d, 7d), v0.x);
                Assert.AreEqual(new Complex(5d, 9.5d), v0.y);
                Assert.AreEqual(new Complex(4d, 0.0), v0.z);
                Assert.AreEqual(new Complex(4d, -4d), v0.w);
            
                Assert.AreEqual(new Complex(2d, 5.5d), v2.x);
                Assert.AreEqual(new Complex(-2d, 7d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(-1d, 5d), new Complex(2d, -6d), new Complex(3d, 4.5d), new Complex(5.5d, -5.5d));
                var v1 = new cvec2(new Complex(2.5d, -8d), new Complex(9.5d, 8.5d));
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-1d, 5d), v0.x);
                Assert.AreEqual(new Complex(2.5d, -8d), v0.y);
                Assert.AreEqual(new Complex(9.5d, 8.5d), v0.z);
                Assert.AreEqual(new Complex(5.5d, -5.5d), v0.w);
            
                Assert.AreEqual(new Complex(2d, -6d), v2.x);
                Assert.AreEqual(new Complex(3d, 4.5d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(-5d, 0.0), new Complex(4.5d, 0.0), new Complex(4d, 0.5d), new Complex(-4d, -9d));
                var v1 = new cvec3(new Complex(-5.5d, 8d), new Complex(-3d, 9d), new Complex(-2.5d, 5.5d));
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-5.5d, 8d), v0.x);
                Assert.AreEqual(new Complex(-3d, 9d), v0.y);
                Assert.AreEqual(new Complex(-2.5d, 5.5d), v0.z);
                Assert.AreEqual(new Complex(-4d, -9d), v0.w);
            
                Assert.AreEqual(new Complex(-5d, 0.0), v2.x);
                Assert.AreEqual(new Complex(4.5d, 0.0), v2.y);
                Assert.AreEqual(new Complex(4d, 0.5d), v2.z);
            }
            {
                var v0 = new cvec4(new Complex(7.5d, -8d), new Complex(-2.5d, 2d), new Complex(0.5d, 8.5d), new Complex(-0.5d, 4.5d));
                var v1 = new Complex(8d, 1.0);
                var v2 = v0.a;
                v0.a = v1;
                var v3 = v0.a;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(7.5d, -8d), v0.x);
                Assert.AreEqual(new Complex(-2.5d, 2d), v0.y);
                Assert.AreEqual(new Complex(0.5d, 8.5d), v0.z);
                Assert.AreEqual(new Complex(8d, 1.0), v0.w);
            
                Assert.AreEqual(new Complex(-0.5d, 4.5d), v2);
            }
            {
                var v0 = new cvec4(new Complex(2d, 8.5d), new Complex(-9.5d, 0.5d), new Complex(-5.5d, 4.5d), new Complex(-7.5d, 9.5d));
                var v1 = new cvec2(new Complex(8.5d, 1.5d), new Complex(-8.5d, -9.5d));
                var v2 = v0.ra;
                v0.ra = v1;
                var v3 = v0.ra;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(8.5d, 1.5d), v0.x);
                Assert.AreEqual(new Complex(-9.5d, 0.5d), v0.y);
                Assert.AreEqual(new Complex(-5.5d, 4.5d), v0.z);
                Assert.AreEqual(new Complex(-8.5d, -9.5d), v0.w);
            
                Assert.AreEqual(new Complex(2d, 8.5d), v2.x);
                Assert.AreEqual(new Complex(-7.5d, 9.5d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(2d, -9.5d), new Complex(5d, 4d), new Complex(-2d, 3.5d), new Complex(9d, 4d));
                var v1 = new cvec2(new Complex(6.5d, -0.5d), new Complex(-0.5d, 4.5d));
                var v2 = v0.ga;
                v0.ga = v1;
                var v3 = v0.ga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(2d, -9.5d), v0.x);
                Assert.AreEqual(new Complex(6.5d, -0.5d), v0.y);
                Assert.AreEqual(new Complex(-2d, 3.5d), v0.z);
                Assert.AreEqual(new Complex(-0.5d, 4.5d), v0.w);
            
                Assert.AreEqual(new Complex(5d, 4d), v2.x);
                Assert.AreEqual(new Complex(9d, 4d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(-4d, -5.5d), new Complex(1.5d, 5.5d), new Complex(-6d, -9d), new Complex(5.5d, 9.5d));
                var v1 = new cvec3(new Complex(-3d, -7d), new Complex(-1.5d, -7.5d), new Complex(-3d, -9d));
                var v2 = v0.rga;
                v0.rga = v1;
                var v3 = v0.rga;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-3d, -7d), v0.x);
                Assert.AreEqual(new Complex(-1.5d, -7.5d), v0.y);
                Assert.AreEqual(new Complex(-6d, -9d), v0.z);
                Assert.AreEqual(new Complex(-3d, -9d), v0.w);
            
                Assert.AreEqual(new Complex(-4d, -5.5d), v2.x);
                Assert.AreEqual(new Complex(1.5d, 5.5d), v2.y);
                Assert.AreEqual(new Complex(5.5d, 9.5d), v2.z);
            }
            {
                var v0 = new cvec4(new Complex(9d, 9.5d), new Complex(4.5d, 6.5d), new Complex(1.5d, 9d), new Complex(8.5d, 2d));
                var v1 = new cvec2(new Complex(6d, 4d), new Complex(-3.5d, -9.5d));
                var v2 = v0.ba;
                v0.ba = v1;
                var v3 = v0.ba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(9d, 9.5d), v0.x);
                Assert.AreEqual(new Complex(4.5d, 6.5d), v0.y);
                Assert.AreEqual(new Complex(6d, 4d), v0.z);
                Assert.AreEqual(new Complex(-3.5d, -9.5d), v0.w);
            
                Assert.AreEqual(new Complex(1.5d, 9d), v2.x);
                Assert.AreEqual(new Complex(8.5d, 2d), v2.y);
            }
            {
                var v0 = new cvec4(new Complex(3d, 8.5d), new Complex(9d, 8.5d), new Complex(8d, 7d), new Complex(-2.5d, 0.0));
                var v1 = new cvec3(new Complex(-9d, 8.5d), new Complex(7d, 9.5d), new Complex(-2d, 6.5d));
                var v2 = v0.rba;
                v0.rba = v1;
                var v3 = v0.rba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-9d, 8.5d), v0.x);
                Assert.AreEqual(new Complex(9d, 8.5d), v0.y);
                Assert.AreEqual(new Complex(7d, 9.5d), v0.z);
                Assert.AreEqual(new Complex(-2d, 6.5d), v0.w);
            
                Assert.AreEqual(new Complex(3d, 8.5d), v2.x);
                Assert.AreEqual(new Complex(8d, 7d), v2.y);
                Assert.AreEqual(new Complex(-2.5d, 0.0), v2.z);
            }
            {
                var v0 = new cvec4(new Complex(-7d, 4d), new Complex(3d, 3d), new Complex(1.0, -3d), new Complex(-6d, -6d));
                var v1 = new cvec3(new Complex(-9.5d, 6d), new Complex(-1.5d, 5d), new Complex(3d, -5.5d));
                var v2 = v0.gba;
                v0.gba = v1;
                var v3 = v0.gba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(-7d, 4d), v0.x);
                Assert.AreEqual(new Complex(-9.5d, 6d), v0.y);
                Assert.AreEqual(new Complex(-1.5d, 5d), v0.z);
                Assert.AreEqual(new Complex(3d, -5.5d), v0.w);
            
                Assert.AreEqual(new Complex(3d, 3d), v2.x);
                Assert.AreEqual(new Complex(1.0, -3d), v2.y);
                Assert.AreEqual(new Complex(-6d, -6d), v2.z);
            }
            {
                var v0 = new cvec4(new Complex(-6.5d, -4d), new Complex(3.5d, 1.0), new Complex(-2.5d, -1d), new Complex(-1.5d, 3d));
                var v1 = new cvec4(new Complex(4d, 3.5d), new Complex(7.5d, -1d), new Complex(-5d, 5.5d), new Complex(9.5d, 4.5d));
                var v2 = v0.rgba;
                v0.rgba = v1;
                var v3 = v0.rgba;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(new Complex(4d, 3.5d), v0.x);
                Assert.AreEqual(new Complex(7.5d, -1d), v0.y);
                Assert.AreEqual(new Complex(-5d, 5.5d), v0.z);
                Assert.AreEqual(new Complex(9.5d, 4.5d), v0.w);
            
                Assert.AreEqual(new Complex(-6.5d, -4d), v2.x);
                Assert.AreEqual(new Complex(3.5d, 1.0), v2.y);
                Assert.AreEqual(new Complex(-2.5d, -1d), v2.z);
                Assert.AreEqual(new Complex(-1.5d, 3d), v2.w);
            }
        }

    }
}
