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
    public class DoubleSwizzleVec3Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new dvec3(-7.5d, -9d, -1.5d);
                var v = ov.swizzle.xx;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
            }
            {
                var ov = new dvec3(-4d, 8.5d, -8d);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(-4d, v.z);
            }
            {
                var ov = new dvec3(4.5d, 3.5d, 6.5d);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec3(1.5d, -6d, -2.5d);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(-6d, v.w);
            }
            {
                var ov = new dvec3(-5d, 7.5d, -8d);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(-5d, v.x);
                Assert.AreEqual(-5d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(-8d, v.w);
            }
            {
                var ov = new dvec3(6.5d, -8d, 6.5d);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-8d, v.z);
            }
            {
                var ov = new dvec3(0.0, -3.5d, 6d);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec3(8d, -4d, 2.5d);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(-4d, v.z);
                Assert.AreEqual(-4d, v.w);
            }
            {
                var ov = new dvec3(-1d, -6.5d, 1.0);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec3(-1.5d, -8.5d, 2.5d);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
            }
            {
                var ov = new dvec3(8.5d, -9d, -0.5d);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec3(-8d, 9d, 5.5d);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(-8d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(9d, v.w);
            }
            {
                var ov = new dvec3(-3d, -3.5d, -9d);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(-9d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
            {
                var ov = new dvec3(2d, 9.5d, -5d);
                var v = ov.swizzle.xy;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(9.5d, v.y);
            }
            {
                var ov = new dvec3(9.5d, -5d, -4.5d);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(-5d, v.y);
                Assert.AreEqual(9.5d, v.z);
            }
            {
                var ov = new dvec3(6.5d, 7d, -7.5d);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(7d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec3(0.5d, 8d, 9.5d);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(8d, v.w);
            }
            {
                var ov = new dvec3(6.5d, -7.5d, 6d);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(6d, v.w);
            }
            {
                var ov = new dvec3(-5d, -3d, 5d);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(-5d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(-3d, v.z);
            }
            {
                var ov = new dvec3(6.5d, 2d, -6d);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(2d, v.y);
                Assert.AreEqual(2d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec3(-7d, 6d, -3d);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-7d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(6d, v.w);
            }
            {
                var ov = new dvec3(3d, 3.5d, 7.5d);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec3(8.5d, 7.5d, -2.5d);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
            }
            {
                var ov = new dvec3(-7.5d, -6.5d, 1.5d);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec3(-7d, 7.5d, -2.5d);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(-7d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec3(1.5d, 9d, 8.5d);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(9d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec3(7d, -5d, -5d);
                var v = ov.swizzle.xz;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(-5d, v.y);
            }
            {
                var ov = new dvec3(-9.5d, 7.5d, -2d);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec3(2.5d, 1.0, 7.5d);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec3(-7.5d, 3d, 7.5d);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(3d, v.w);
            }
            {
                var ov = new dvec3(-0.5d, -7d, -5.5d);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec3(3d, -3.5d, 2.5d);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec3(2d, 5.5d, -7.5d);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(2d, v.w);
            }
            {
                var ov = new dvec3(-2.5d, 7.5d, -1d);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(7.5d, v.w);
            }
            {
                var ov = new dvec3(4.5d, 7d, -4.5d);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec3(8d, -9.5d, -5.5d);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
            }
            {
                var ov = new dvec3(-9.5d, -5.5d, 3d);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(3d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec3(6d, -0.5d, -2.5d);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec3(1.0, 6.5d, 8d);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(8d, v.z);
                Assert.AreEqual(8d, v.w);
            }
            {
                var ov = new dvec3(0.0, -2d, 1.5d);
                var v = ov.swizzle.yx;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(0.0, v.y);
            }
            {
                var ov = new dvec3(0.0, -7d, 4.5d);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(-7d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(0.0, v.z);
            }
            {
                var ov = new dvec3(0.5d, 2.5d, 6d);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec3(7d, -4d, -2d);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(7d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(-4d, v.w);
            }
            {
                var ov = new dvec3(4.5d, -1.5d, -5d);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-5d, v.w);
            }
            {
                var ov = new dvec3(-7d, -9.5d, -8d);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-7d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec3(3d, -4.5d, 0.5d);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(3d, v.w);
            }
            {
                var ov = new dvec3(-3.5d, -6.5d, -7.5d);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec3(-3d, 1.0, -9.5d);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec3(3.5d, -6.5d, -2.5d);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
            }
            {
                var ov = new dvec3(6.5d, 1.0, -0.5d);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec3(-5.5d, 1.0, -6.5d);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec3(0.5d, -2.5d, -9.5d);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-9.5d, v.w);
            }
            {
                var ov = new dvec3(-7d, 4d, -5d);
                var v = ov.swizzle.yy;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
            }
            {
                var ov = new dvec3(-8d, 1.0, 5d);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(-8d, v.z);
            }
            {
                var ov = new dvec3(-3d, -4.5d, 5.5d);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-3d, v.z);
                Assert.AreEqual(-3d, v.w);
            }
            {
                var ov = new dvec3(-0.5d, 0.5d, 9d);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec3(9d, 7.5d, -2d);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(9d, v.z);
                Assert.AreEqual(-2d, v.w);
            }
            {
                var ov = new dvec3(-9d, -4d, -1.5d);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(-4d, v.z);
            }
            {
                var ov = new dvec3(9d, -2.5d, -5d);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(9d, v.w);
            }
            {
                var ov = new dvec3(-5d, 6.5d, 9d);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(6.5d, v.w);
            }
            {
                var ov = new dvec3(-9.5d, -1d, -2d);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-1d, v.z);
                Assert.AreEqual(-2d, v.w);
            }
            {
                var ov = new dvec3(-7.5d, -1d, -3.5d);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec3(1.5d, -3.5d, 2.5d);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec3(8.5d, -2.5d, -9.5d);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec3(-5d, 7d, -7.5d);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(7d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec3(-6d, 9.5d, -7d);
                var v = ov.swizzle.yz;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(-7d, v.y);
            }
            {
                var ov = new dvec3(-5.5d, 4d, 2.5d);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(-5.5d, v.z);
            }
            {
                var ov = new dvec3(-8d, -2.5d, 3d);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(-8d, v.z);
                Assert.AreEqual(-8d, v.w);
            }
            {
                var ov = new dvec3(-8d, 5d, -1.5d);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-8d, v.z);
                Assert.AreEqual(5d, v.w);
            }
            {
                var ov = new dvec3(4.5d, -9.5d, 9.5d);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec3(4d, 2d, 8d);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(2d, v.z);
            }
            {
                var ov = new dvec3(5d, 8.5d, 0.5d);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(5d, v.w);
            }
            {
                var ov = new dvec3(3.5d, 1.5d, -4d);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec3(8d, 7.5d, 3d);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(3d, v.w);
            }
            {
                var ov = new dvec3(-7d, -2d, -1d);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-1d, v.z);
            }
            {
                var ov = new dvec3(1.5d, 3d, 6d);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec3(5d, 4.5d, -1.5d);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec3(7.5d, 0.5d, 1.5d);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec3(-7d, 2d, -5.5d);
                var v = ov.swizzle.zx;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-7d, v.y);
            }
            {
                var ov = new dvec3(8d, 3d, 5d);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(8d, v.z);
            }
            {
                var ov = new dvec3(8.5d, 6.5d, 5d);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec3(2.5d, 3.5d, -4.5d);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec3(-2d, 9d, 9d);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(9d, v.w);
            }
            {
                var ov = new dvec3(2.5d, -7.5d, 8d);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
            }
            {
                var ov = new dvec3(3d, -6d, 7d);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(-6d, v.z);
                Assert.AreEqual(3d, v.w);
            }
            {
                var ov = new dvec3(-1.5d, 0.0, -6d);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec3(3.5d, -2.5d, 1.0);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var ov = new dvec3(-8.5d, -1.5d, -3.5d);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
            }
            {
                var ov = new dvec3(-2d, 6d, -2d);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(-2d, v.w);
            }
            {
                var ov = new dvec3(-7d, -1.5d, 6.5d);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-7d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec3(6d, -4.5d, -2.5d);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(-2.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec3(8d, 9d, 0.0);
                var v = ov.swizzle.zy;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(9d, v.y);
            }
            {
                var ov = new dvec3(8.5d, -4.5d, -8d);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(-8d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
            }
            {
                var ov = new dvec3(-4.5d, -9.5d, 4.5d);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-4.5d, v.w);
            }
            {
                var ov = new dvec3(6.5d, -4d, -2d);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(-4d, v.w);
            }
            {
                var ov = new dvec3(-9d, 4.5d, -4d);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-9d, v.z);
                Assert.AreEqual(-4d, v.w);
            }
            {
                var ov = new dvec3(-5.5d, -0.5d, 1.0);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
            }
            {
                var ov = new dvec3(7d, -5d, -7d);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(-7d, v.x);
                Assert.AreEqual(-5d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(7d, v.w);
            }
            {
                var ov = new dvec3(4d, -8d, 7d);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(-8d, v.z);
                Assert.AreEqual(-8d, v.w);
            }
            {
                var ov = new dvec3(-9.5d, -8.5d, -3.5d);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-8.5d, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec3(-3d, 4.5d, -7.5d);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(4.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
            }
            {
                var ov = new dvec3(-3d, -3.5d, 7.5d);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
                Assert.AreEqual(-3d, v.w);
            }
            {
                var ov = new dvec3(-7.5d, 5.5d, 6d);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec3(6d, 0.5d, -6d);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-6d, v.z);
                Assert.AreEqual(-6d, v.w);
            }
            {
                var ov = new dvec3(7.5d, 8d, 7d);
                var v = ov.swizzle.zz;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(7d, v.y);
            }
            {
                var ov = new dvec3(6d, -4.5d, -5d);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(-5d, v.x);
                Assert.AreEqual(-5d, v.y);
                Assert.AreEqual(6d, v.z);
            }
            {
                var ov = new dvec3(-5d, 3.5d, -2d);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(-5d, v.w);
            }
            {
                var ov = new dvec3(8.5d, 3.5d, 9.5d);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec3(4.5d, 8.5d, -1d);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-1d, v.w);
            }
            {
                var ov = new dvec3(-1d, 3d, 2.5d);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(3d, v.z);
            }
            {
                var ov = new dvec3(3.5d, -8d, 3d);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(-8d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec3(1.5d, -3d, -3.5d);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-3d, v.z);
                Assert.AreEqual(-3d, v.w);
            }
            {
                var ov = new dvec3(-3d, -6.5d, -1.5d);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec3(-5d, 7.5d, 9.5d);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(9.5d, v.z);
            }
            {
                var ov = new dvec3(6d, -8d, 8.5d);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(6d, v.w);
            }
            {
                var ov = new dvec3(-3.5d, -1d, 6d);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(-1d, v.w);
            }
            {
                var ov = new dvec3(9d, 8.5d, 2.5d);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new dvec3(-7.5d, -9d, 6.5d);
                var v = ov.swizzle.rr;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
            }
            {
                var ov = new dvec3(3.5d, 9.5d, 2d);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
            }
            {
                var ov = new dvec3(-6d, 3.5d, 1.0);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(-6d, v.y);
                Assert.AreEqual(-6d, v.z);
                Assert.AreEqual(-6d, v.w);
            }
            {
                var ov = new dvec3(3d, 9.5d, -1.5d);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(3d, v.z);
                Assert.AreEqual(9.5d, v.w);
            }
            {
                var ov = new dvec3(7d, 4d, -1d);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(7d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(-1d, v.w);
            }
            {
                var ov = new dvec3(-2.5d, -6.5d, -3d);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-6.5d, v.z);
            }
            {
                var ov = new dvec3(9d, 8.5d, -9d);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(9d, v.x);
                Assert.AreEqual(9d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(9d, v.w);
            }
            {
                var ov = new dvec3(4d, -8d, -4d);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(-8d, v.z);
                Assert.AreEqual(-8d, v.w);
            }
            {
                var ov = new dvec3(6.5d, -4.5d, 8.5d);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec3(-0.5d, 4d, -9.5d);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec3(-5.5d, -2d, -0.5d);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec3(-1d, -7.5d, -6.5d);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec3(8.5d, -3.5d, -2d);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(-2d, v.w);
            }
            {
                var ov = new dvec3(5.5d, -6.5d, -3.5d);
                var v = ov.swizzle.rg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-6.5d, v.y);
            }
            {
                var ov = new dvec3(-7.5d, -4.5d, 2d);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
            }
            {
                var ov = new dvec3(-7d, 8d, 4.5d);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(-7d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(-7d, v.z);
                Assert.AreEqual(-7d, v.w);
            }
            {
                var ov = new dvec3(-9d, -8.5d, -2d);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(-9d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-9d, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec3(3d, -2d, 5d);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(3d, v.z);
                Assert.AreEqual(5d, v.w);
            }
            {
                var ov = new dvec3(-3d, -8d, 0.0);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(-8d, v.z);
            }
            {
                var ov = new dvec3(-6.5d, 6.5d, -4d);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(6.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec3(3d, -3.5d, -1.5d);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec3(-8.5d, -9.5d, -2.5d);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(-8.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec3(9.5d, 7.5d, -7.5d);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
            }
            {
                var ov = new dvec3(-1.5d, -1.5d, 6.5d);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec3(1.0, -4d, -5d);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(-4d, v.w);
            }
            {
                var ov = new dvec3(2.5d, -7.5d, 3.5d);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec3(-1d, -9.5d, -7d);
                var v = ov.swizzle.rb;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-7d, v.y);
            }
            {
                var ov = new dvec3(4d, -1d, -5.5d);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(4d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(4d, v.z);
            }
            {
                var ov = new dvec3(7d, -9.5d, 0.0);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(7d, v.w);
            }
            {
                var ov = new dvec3(-6.5d, 8.5d, 4d);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec3(-7.5d, -6d, 0.5d);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(0.5d, v.w);
            }
            {
                var ov = new dvec3(8.5d, 1.5d, 7.5d);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
            }
            {
                var ov = new dvec3(8.5d, 0.0, 4d);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec3(-6d, -7d, -2d);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(-7d, v.z);
                Assert.AreEqual(-7d, v.w);
            }
            {
                var ov = new dvec3(-3d, 1.5d, 2.5d);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec3(-6d, 1.0, 7.5d);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
            }
            {
                var ov = new dvec3(1.5d, -9.5d, 5.5d);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(1.5d, v.w);
            }
            {
                var ov = new dvec3(7d, -2d, -7d);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(-7d, v.y);
                Assert.AreEqual(-7d, v.z);
                Assert.AreEqual(-2d, v.w);
            }
            {
                var ov = new dvec3(6.5d, 9.5d, -6d);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(6.5d, v.x);
                Assert.AreEqual(-6d, v.y);
                Assert.AreEqual(-6d, v.z);
                Assert.AreEqual(-6d, v.w);
            }
            {
                var ov = new dvec3(4d, -3d, 9.5d);
                var v = ov.swizzle.gr;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(4d, v.y);
            }
            {
                var ov = new dvec3(-2.5d, -7d, 8.5d);
                var v = ov.swizzle.grr;
                Assert.AreEqual(-7d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-2.5d, v.z);
            }
            {
                var ov = new dvec3(-7d, 5d, -2d);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(-7d, v.y);
                Assert.AreEqual(-7d, v.z);
                Assert.AreEqual(-7d, v.w);
            }
            {
                var ov = new dvec3(6d, 3d, -6.5d);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(3d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(3d, v.w);
            }
            {
                var ov = new dvec3(-8d, 4.5d, -7.5d);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(-8d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec3(-1.5d, 5.5d, 2d);
                var v = ov.swizzle.grg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
            }
            {
                var ov = new dvec3(5d, 2.5d, -9d);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(5d, v.w);
            }
            {
                var ov = new dvec3(1.5d, 2.5d, -9d);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(2.5d, v.w);
            }
            {
                var ov = new dvec3(2d, 2.5d, -9d);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
            {
                var ov = new dvec3(9d, -5d, 4d);
                var v = ov.swizzle.grb;
                Assert.AreEqual(-5d, v.x);
                Assert.AreEqual(9d, v.y);
                Assert.AreEqual(4d, v.z);
            }
            {
                var ov = new dvec3(-3d, 1.0, 2.5d);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(-3d, v.w);
            }
            {
                var ov = new dvec3(-8.5d, 3.5d, -1.5d);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(-8.5d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec3(4d, -1.5d, 0.0);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec3(-3d, 5.5d, -4.5d);
                var v = ov.swizzle.gg;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
            }
            {
                var ov = new dvec3(-9.5d, 8d, 8.5d);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec3(-5d, -3d, -4.5d);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(-3d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(-5d, v.w);
            }
            {
                var ov = new dvec3(-4d, -9d, -6d);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-9d, v.x);
                Assert.AreEqual(-9d, v.y);
                Assert.AreEqual(-4d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
            {
                var ov = new dvec3(-5d, 0.5d, 6d);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(0.5d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(6d, v.w);
            }
            {
                var ov = new dvec3(6.5d, -4d, -9.5d);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(-4d, v.z);
            }
            {
                var ov = new dvec3(-8.5d, -4.5d, -4.5d);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-4.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-8.5d, v.w);
            }
            {
                var ov = new dvec3(-9.5d, 7d, 1.5d);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(7d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(7d, v.w);
            }
            {
                var ov = new dvec3(7d, 3.5d, 2d);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(2d, v.w);
            }
            {
                var ov = new dvec3(0.5d, 7.5d, 1.0);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(1.0, v.z);
            }
            {
                var ov = new dvec3(3.5d, -5.5d, 6d);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5.5d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec3(1.0, 3.5d, 6.5d);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(6.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
            {
                var ov = new dvec3(4.5d, -1d, -6.5d);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(-1d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-6.5d, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var ov = new dvec3(-8.5d, -2.5d, -9d);
                var v = ov.swizzle.gb;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-9d, v.y);
            }
            {
                var ov = new dvec3(3.5d, 5.5d, 5.5d);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
            }
            {
                var ov = new dvec3(-1.5d, 8.5d, -1d);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(-1d, v.y);
                Assert.AreEqual(-1.5d, v.z);
                Assert.AreEqual(-1.5d, v.w);
            }
            {
                var ov = new dvec3(-4.5d, -5.5d, -9.5d);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-4.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec3(7d, -6.5d, 3d);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(3d, v.w);
            }
            {
                var ov = new dvec3(-6d, 3.5d, -1.5d);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
            }
            {
                var ov = new dvec3(4.5d, -3d, -6d);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(-6d, v.y);
                Assert.AreEqual(-3d, v.z);
                Assert.AreEqual(4.5d, v.w);
            }
            {
                var ov = new dvec3(5.5d, -5.5d, -6d);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-6d, v.y);
                Assert.AreEqual(-5.5d, v.z);
                Assert.AreEqual(-5.5d, v.w);
            }
            {
                var ov = new dvec3(-5.5d, -9.5d, 5.5d);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(5.5d, v.w);
            }
            {
                var ov = new dvec3(9d, -3d, 7.5d);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(7.5d, v.z);
            }
            {
                var ov = new dvec3(-1d, 2d, 2d);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(2d, v.y);
                Assert.AreEqual(2d, v.z);
                Assert.AreEqual(-1d, v.w);
            }
            {
                var ov = new dvec3(6.5d, 0.0, 8.5d);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec3(5d, -3.5d, -2d);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(-2d, v.z);
                Assert.AreEqual(-2d, v.w);
            }
            {
                var ov = new dvec3(5.5d, -9.5d, 5.5d);
                var v = ov.swizzle.br;
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(5.5d, v.y);
            }
            {
                var ov = new dvec3(1.5d, 5d, -3d);
                var v = ov.swizzle.brr;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(1.5d, v.z);
            }
            {
                var ov = new dvec3(-7.5d, -3.5d, 0.0);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec3(3d, -3.5d, 9.5d);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(9.5d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(3d, v.z);
                Assert.AreEqual(-3.5d, v.w);
            }
            {
                var ov = new dvec3(8d, 0.0, 8.5d);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(8d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec3(7d, -4.5d, 2d);
                var v = ov.swizzle.brg;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(7d, v.y);
                Assert.AreEqual(-4.5d, v.z);
            }
            {
                var ov = new dvec3(3d, 9d, -5d);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(-5d, v.x);
                Assert.AreEqual(3d, v.y);
                Assert.AreEqual(9d, v.z);
                Assert.AreEqual(3d, v.w);
            }
            {
                var ov = new dvec3(0.0, -9d, -4.5d);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(-9d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
            {
                var ov = new dvec3(-4d, -5d, -7.5d);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-4d, v.y);
                Assert.AreEqual(-5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var ov = new dvec3(-7d, -1d, -6.5d);
                var v = ov.swizzle.brb;
                Assert.AreEqual(-6.5d, v.x);
                Assert.AreEqual(-7d, v.y);
                Assert.AreEqual(-6.5d, v.z);
            }
            {
                var ov = new dvec3(4d, 9d, 7d);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(4d, v.w);
            }
            {
                var ov = new dvec3(-6d, 8.5d, 2.5d);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(-6d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec3(-9.5d, 4d, -9d);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(-9d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
            {
                var ov = new dvec3(2d, 2d, 4.5d);
                var v = ov.swizzle.bg;
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(2d, v.y);
            }
            {
                var ov = new dvec3(4.5d, 5d, -2.5d);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(5d, v.y);
                Assert.AreEqual(4.5d, v.z);
            }
            {
                var ov = new dvec3(8.5d, 1.0, 2d);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(8.5d, v.w);
            }
            {
                var ov = new dvec3(4d, -0.5d, -6d);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(4d, v.z);
                Assert.AreEqual(-0.5d, v.w);
            }
            {
                var ov = new dvec3(5.5d, 2d, -7d);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(-7d, v.x);
                Assert.AreEqual(2d, v.y);
                Assert.AreEqual(5.5d, v.z);
                Assert.AreEqual(-7d, v.w);
            }
            {
                var ov = new dvec3(6.5d, 5.5d, 0.0);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(5.5d, v.z);
            }
            {
                var ov = new dvec3(9d, -8d, 1.5d);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(-8d, v.z);
                Assert.AreEqual(9d, v.w);
            }
            {
                var ov = new dvec3(1.5d, 5d, -5d);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(-5d, v.x);
                Assert.AreEqual(5d, v.y);
                Assert.AreEqual(5d, v.z);
                Assert.AreEqual(5d, v.w);
            }
            {
                var ov = new dvec3(-8d, 8.5d, -6d);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(-6d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
                Assert.AreEqual(-6d, v.w);
            }
            {
                var ov = new dvec3(2.5d, 3.5d, 2d);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(2d, v.z);
            }
            {
                var ov = new dvec3(5d, -1.5d, -9.5d);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-1.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
                Assert.AreEqual(5d, v.w);
            }
            {
                var ov = new dvec3(-5.5d, 0.0, 7d);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(7d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec3(-8.5d, 5d, -4d);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(-4d, v.x);
                Assert.AreEqual(5d, v.y);
                Assert.AreEqual(-4d, v.z);
                Assert.AreEqual(-4d, v.w);
            }
            {
                var ov = new dvec3(8.5d, -6d, -3d);
                var v = ov.swizzle.bb;
                Assert.AreEqual(-3d, v.x);
                Assert.AreEqual(-3d, v.y);
            }
            {
                var ov = new dvec3(-9.5d, -2d, -7.5d);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var ov = new dvec3(6d, 9d, 7d);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(7d, v.x);
                Assert.AreEqual(7d, v.y);
                Assert.AreEqual(6d, v.z);
                Assert.AreEqual(6d, v.w);
            }
            {
                var ov = new dvec3(0.5d, -9d, 2d);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(2d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
            {
                var ov = new dvec3(2.5d, -1d, -2.5d);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(-2.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
                Assert.AreEqual(-2.5d, v.w);
            }
            {
                var ov = new dvec3(-1.5d, -2d, 7.5d);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(7.5d, v.x);
                Assert.AreEqual(7.5d, v.y);
                Assert.AreEqual(-2d, v.z);
            }
            {
                var ov = new dvec3(-9d, -7d, 6d);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(6d, v.x);
                Assert.AreEqual(6d, v.y);
                Assert.AreEqual(-7d, v.z);
                Assert.AreEqual(-9d, v.w);
            }
            {
                var ov = new dvec3(-1d, 5d, 8d);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(8d, v.y);
                Assert.AreEqual(5d, v.z);
                Assert.AreEqual(5d, v.w);
            }
            {
                var ov = new dvec3(9.5d, 9.5d, 0.0);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(0.0, v.y);
                Assert.AreEqual(9.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var ov = new dvec3(6.5d, -2d, 2d);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(2d, v.y);
                Assert.AreEqual(2d, v.z);
            }
            {
                var ov = new dvec3(9d, -6d, -0.5d);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(-0.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(9d, v.w);
            }
            {
                var ov = new dvec3(-2.5d, -2d, 2d);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(2d, v.x);
                Assert.AreEqual(2d, v.y);
                Assert.AreEqual(2d, v.z);
                Assert.AreEqual(-2d, v.w);
            }
            {
                var ov = new dvec3(-8d, -2d, 3.5d);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(3.5d, v.x);
                Assert.AreEqual(3.5d, v.y);
                Assert.AreEqual(3.5d, v.z);
                Assert.AreEqual(3.5d, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new dvec3(5.5d, 9d, 4d);
                var v1 = new dvec2(9.5d, 8.5d);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9.5d, v0.x);
                Assert.AreEqual(8.5d, v0.y);
                Assert.AreEqual(4d, v0.z);
            
                Assert.AreEqual(5.5d, v2.x);
                Assert.AreEqual(9d, v2.y);
            }
            {
                var v0 = new dvec3(5.5d, -8.5d, 0.0);
                var v1 = new dvec2(-0.5d, -7.5d);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-0.5d, v0.x);
                Assert.AreEqual(-8.5d, v0.y);
                Assert.AreEqual(-7.5d, v0.z);
            
                Assert.AreEqual(5.5d, v2.x);
                Assert.AreEqual(0.0, v2.y);
            }
            {
                var v0 = new dvec3(-4d, -8d, 0.5d);
                var v1 = new dvec2(7.5d, 9d);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-4d, v0.x);
                Assert.AreEqual(7.5d, v0.y);
                Assert.AreEqual(9d, v0.z);
            
                Assert.AreEqual(-8d, v2.x);
                Assert.AreEqual(0.5d, v2.y);
            }
            {
                var v0 = new dvec3(2.5d, -8d, -3d);
                var v1 = new dvec3(-3d, -6.5d, -9d);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3d, v0.x);
                Assert.AreEqual(-6.5d, v0.y);
                Assert.AreEqual(-9d, v0.z);
            
                Assert.AreEqual(2.5d, v2.x);
                Assert.AreEqual(-8d, v2.y);
                Assert.AreEqual(-3d, v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new dvec3(-4d, 3.5d, -1d);
                var v1 = 3d;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3d, v0.x);
                Assert.AreEqual(3.5d, v0.y);
                Assert.AreEqual(-1d, v0.z);
            
                Assert.AreEqual(-4d, v2);
            }
            {
                var v0 = new dvec3(2d, -6.5d, -5d);
                var v1 = 9.5d;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2d, v0.x);
                Assert.AreEqual(9.5d, v0.y);
                Assert.AreEqual(-5d, v0.z);
            
                Assert.AreEqual(-6.5d, v2);
            }
            {
                var v0 = new dvec3(-3.5d, 0.5d, 2.5d);
                var v1 = new dvec2(3.5d, 3.5d);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3.5d, v0.x);
                Assert.AreEqual(3.5d, v0.y);
                Assert.AreEqual(2.5d, v0.z);
            
                Assert.AreEqual(-3.5d, v2.x);
                Assert.AreEqual(0.5d, v2.y);
            }
            {
                var v0 = new dvec3(-5.5d, 5d, -7.5d);
                var v1 = 8d;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5.5d, v0.x);
                Assert.AreEqual(5d, v0.y);
                Assert.AreEqual(8d, v0.z);
            
                Assert.AreEqual(-7.5d, v2);
            }
            {
                var v0 = new dvec3(-5.5d, 6d, 2.5d);
                var v1 = new dvec2(-2d, 2.5d);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-2d, v0.x);
                Assert.AreEqual(6d, v0.y);
                Assert.AreEqual(2.5d, v0.z);
            
                Assert.AreEqual(-5.5d, v2.x);
                Assert.AreEqual(2.5d, v2.y);
            }
            {
                var v0 = new dvec3(-7.5d, -6.5d, 9d);
                var v1 = new dvec2(5d, -1d);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-7.5d, v0.x);
                Assert.AreEqual(5d, v0.y);
                Assert.AreEqual(-1d, v0.z);
            
                Assert.AreEqual(-6.5d, v2.x);
                Assert.AreEqual(9d, v2.y);
            }
            {
                var v0 = new dvec3(-2d, 7.5d, 4.5d);
                var v1 = new dvec3(-6.5d, 5.5d, 2d);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-6.5d, v0.x);
                Assert.AreEqual(5.5d, v0.y);
                Assert.AreEqual(2d, v0.z);
            
                Assert.AreEqual(-2d, v2.x);
                Assert.AreEqual(7.5d, v2.y);
                Assert.AreEqual(4.5d, v2.z);
            }
        }

    }
}
