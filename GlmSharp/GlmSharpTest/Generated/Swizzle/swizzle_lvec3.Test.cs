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
    public class LongSwizzleVec3Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new lvec3(0, -8L, 3L);
                var v = ov.swizzle.xx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
            }
            {
                var ov = new lvec3(-9L, 8L, 8L);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec3(0, 1, 2L);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(5L, -7L, 6L);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec3(2L, 5L, -1L);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(2L, -1L, -7L);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-1L, v.z);
            }
            {
                var ov = new lvec3(7L, 1, 6L);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(-3L, 2L, -4L);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec3(-2L, 9L, -3L);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec3(-6L, 3L, 9L);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec3(0, 5L, -2L);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(-2L, 7L, 1);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(1, 1, -5L);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec3(1, 5L, 5L);
                var v = ov.swizzle.xy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var ov = new lvec3(8L, -5L, 3L);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec3(7L, -7L, 8L);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(0, 3L, 4L);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec3(5L, 7L, -8L);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(-4L, 7L, -5L);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
            }
            {
                var ov = new lvec3(9L, 6L, -8L);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec3(-6L, 3L, -7L);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec3(-3L, 5L, -1L);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(-4L, -1L, -7L);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec3(8L, 0, 8L);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(1, 6L, -5L);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec3(0, 3L, 7L);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(9L, 4L, -2L);
                var v = ov.swizzle.xz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-2L, v.y);
            }
            {
                var ov = new lvec3(3L, -6L, -9L);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec3(4L, -4L, -7L);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(-3L, -8L, 0);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(5L, -2L, -4L);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec3(-7L, 5L, 2L);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec3(7L, -6L, 8L);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(-3L, -3L, 6L);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec3(-1L, -1L, 2L);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec3(-5L, 4L, 1);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec3(3L, -3L, 4L);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec3(6L, -9L, 2L);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec3(5L, -2L, 7L);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(-8L, 7L, -1L);
                var v = ov.swizzle.yx;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-8L, v.y);
            }
            {
                var ov = new lvec3(-4L, 1, -3L);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec3(-7L, 2L, 8L);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec3(-5L, 4L, 0);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(-3L, -3L, 6L);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec3(-8L, -7L, -1L);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec3(5L, -3L, 4L);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec3(-7L, 8L, 9L);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(-5L, 9L, 4L);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(-6L, -9L, -2L);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec3(-2L, -1L, -3L);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec3(-5L, 9L, 7L);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec3(-8L, -8L, -2L);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec3(-4L, -4L, 8L);
                var v = ov.swizzle.yy;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
            }
            {
                var ov = new lvec3(-4L, 0, -9L);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec3(0, -1L, 0);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(-7L, 7L, 2L);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(-2L, 0, -9L);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec3(2L, 1, -8L);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec3(1, -8L, -1L);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec3(7L, 1, 3L);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec3(-6L, 3L, -3L);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec3(7L, -8L, 3L);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec3(-8L, 0, -8L);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(-8L, -1L, -8L);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(-6L, 2L, 8L);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(9L, -4L, -9L);
                var v = ov.swizzle.yz;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-9L, v.y);
            }
            {
                var ov = new lvec3(4L, -9L, -1L);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec3(8L, -9L, -1L);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(-4L, -3L, 8L);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec3(9L, -6L, 0);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(0, 5L, -3L);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec3(4L, -7L, -7L);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(6L, -3L, -3L);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec3(-6L, -8L, 7L);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(4L, -3L, 8L);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec3(0, 5L, -8L);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(9L, -2L, 4L);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec3(-2L, 3L, 2L);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec3(-3L, 6L, 3L);
                var v = ov.swizzle.zx;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-3L, v.y);
            }
            {
                var ov = new lvec3(2L, -3L, 4L);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec3(-4L, 8L, 4L);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec3(-8L, -7L, 5L);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec3(5L, -2L, 4L);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(-1L, 3L, 0);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec3(6L, 7L, 0);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec3(3L, 4L, 5L);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(2L, -4L, 7L);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(9L, -9L, 4L);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec3(-6L, 8L, 2L);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec3(9L, -2L, 9L);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec3(-3L, 3L, 0);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(7L, 2L, 8L);
                var v = ov.swizzle.zy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(2L, v.y);
            }
            {
                var ov = new lvec3(3L, 6L, -6L);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec3(2L, -5L, -3L);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec3(-3L, -8L, 8L);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(3L, 5L, -5L);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec3(1, 9L, 2L);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec3(-7L, 0, -9L);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec3(-7L, 4L, 8L);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(-9L, 1, 8L);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(2L, -5L, 0);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var ov = new lvec3(-5L, -8L, -9L);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec3(-9L, -8L, 5L);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(-2L, 0, -8L);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(9L, -9L, -9L);
                var v = ov.swizzle.zz;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
            }
            {
                var ov = new lvec3(-4L, -6L, 1);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec3(-6L, -2L, 2L);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec3(7L, 8L, 1);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(7L, -5L, 3L);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec3(1, 9L, -7L);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(9L, v.z);
            }
            {
                var ov = new lvec3(-9L, 3L, 4L);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec3(6L, -9L, -9L);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec3(-3L, -8L, 0);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(8L, 3L, 6L);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec3(8L, 9L, 9L);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(4L, 7L, 0);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(-9L, 3L, 7L);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new lvec3(8L, 3L, 9L);
                var v = ov.swizzle.rr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(8L, v.y);
            }
            {
                var ov = new lvec3(6L, -6L, -5L);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec3(9L, 5L, 7L);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec3(-4L, 9L, 8L);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec3(3L, 4L, 3L);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec3(-7L, 1, -6L);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec3(-1L, -7L, -1L);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(9L, -3L, 5L);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec3(0, -3L, 4L);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(0, 3L, -9L);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var ov = new lvec3(-2L, -8L, -1L);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec3(-8L, -1L, 4L);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(9L, -7L, 0);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(3L, 5L, 4L);
                var v = ov.swizzle.rg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(5L, v.y);
            }
            {
                var ov = new lvec3(6L, 9L, 7L);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec3(8L, -7L, -9L);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(5L, 2L, 0);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec3(-3L, 4L, 0);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(-6L, -8L, 9L);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec3(3L, 6L, 2L);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec3(-1L, 8L, 1);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(8L, 2L, -1L);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(-7L, 5L, -3L);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-3L, v.z);
            }
            {
                var ov = new lvec3(-8L, 6L, 3L);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(-6L, 7L, -1L);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(6L, 3L, 3L);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec3(-8L, -2L, -6L);
                var v = ov.swizzle.rb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-6L, v.y);
            }
            {
                var ov = new lvec3(4L, -5L, 0);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(4L, v.z);
            }
            {
                var ov = new lvec3(-9L, -8L, -4L);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec3(-1L, 1, -3L);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec3(-4L, 6L, -1L);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(-7L, -2L, -6L);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-2L, v.z);
            }
            {
                var ov = new lvec3(2L, -7L, 7L);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec3(-6L, -1L, -1L);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(6L, 6L, -6L);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec3(-6L, -6L, -7L);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec3(8L, 8L, -5L);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(6L, 4L, -4L);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(6L, 6L, -4L);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec3(1, 9L, 3L);
                var v = ov.swizzle.gr;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(1, v.y);
            }
            {
                var ov = new lvec3(-7L, 5L, 4L);
                var v = ov.swizzle.grr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
            }
            {
                var ov = new lvec3(0, 4L, -9L);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(-3L, -8L, -5L);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(-4L, 4L, 5L);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec3(-5L, 2L, 0);
                var v = ov.swizzle.grg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec3(5L, -7L, 7L);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec3(4L, 3L, 2L);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec3(-6L, 2L, -3L);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec3(-7L, 7L, 1);
                var v = ov.swizzle.grb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(1, v.z);
            }
            {
                var ov = new lvec3(-6L, -1L, 5L);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec3(2L, 0, 7L);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(4L, -8L, 5L);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec3(6L, 6L, 2L);
                var v = ov.swizzle.gg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
            }
            {
                var ov = new lvec3(-6L, 2L, -7L);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec3(1, -4L, 3L);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec3(8L, -2L, 2L);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(8L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec3(-4L, 1, 8L);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-4L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(5L, -6L, 5L);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec3(1, 1, 3L);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec3(-1L, 2L, -6L);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
                Assert.AreEqual(2L, v.w);
            }
            {
                var ov = new lvec3(-8L, -7L, 7L);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-7L, v.z);
                Assert.AreEqual(7L, v.w);
            }
            {
                var ov = new lvec3(9L, -2L, 3L);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(-2L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var ov = new lvec3(-8L, -1L, 4L);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(-5L, -9L, -1L);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec3(5L, 7L, 0);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(7L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(4L, -4L, 7L);
                var v = ov.swizzle.gb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(7L, v.y);
            }
            {
                var ov = new lvec3(8L, 8L, -6L);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(8L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(8L, v.z);
            }
            {
                var ov = new lvec3(-9L, 2L, 9L);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec3(-6L, -6L, 4L);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(-6L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec3(1, 3L, -6L);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec3(2L, -5L, 3L);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec3(5L, -8L, 5L);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec3(9L, -2L, 1);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec3(0, 9L, 1);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(9L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec3(-8L, -9L, 2L);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(2L, v.y);
                Assert.AreEqual(2L, v.z);
            }
            {
                var ov = new lvec3(-7L, -9L, 7L);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-7L, v.w);
            }
            {
                var ov = new lvec3(5L, -6L, 7L);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec3(-5L, 2L, -3L);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec3(0, -8L, -5L);
                var v = ov.swizzle.br;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(0, v.y);
            }
            {
                var ov = new lvec3(-8L, -3L, -6L);
                var v = ov.swizzle.brr;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var ov = new lvec3(-9L, -7L, 6L);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-9L, v.w);
            }
            {
                var ov = new lvec3(7L, -3L, 3L);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(-3L, v.w);
            }
            {
                var ov = new lvec3(7L, 0, 9L);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec3(-5L, -5L, 1);
                var v = ov.swizzle.brg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-5L, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec3(6L, 7L, -9L);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(7L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec3(-4L, 1, 2L);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(2L, v.x);
                Assert.AreEqual(-4L, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec3(7L, -9L, -6L);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(-6L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec3(-6L, -6L, 6L);
                var v = ov.swizzle.brb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec3(8L, 7L, -2L);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(-2L, v.x);
                Assert.AreEqual(8L, v.y);
                Assert.AreEqual(-2L, v.z);
                Assert.AreEqual(8L, v.w);
            }
            {
                var ov = new lvec3(9L, 4L, -9L);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(-1L, -1L, -8L);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(5L, 0, -3L);
                var v = ov.swizzle.bg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(0, v.y);
            }
            {
                var ov = new lvec3(-4L, 9L, 6L);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-4L, v.z);
            }
            {
                var ov = new lvec3(-8L, 9L, -9L);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-8L, v.w);
            }
            {
                var ov = new lvec3(-8L, 9L, 1);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(9L, v.w);
            }
            {
                var ov = new lvec3(5L, 7L, -4L);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(7L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(-4L, v.w);
            }
            {
                var ov = new lvec3(-4L, 5L, -7L);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec3(-2L, -1L, -4L);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(-4L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec3(0, 3L, 1);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(3L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(3L, v.w);
            }
            {
                var ov = new lvec3(0, -9L, 5L);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(-9L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec3(-1L, -7L, -5L);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(-5L, v.z);
            }
            {
                var ov = new lvec3(-1L, 4L, 3L);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(3L, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(3L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(3L, 1, 6L);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(1, v.w);
            }
            {
                var ov = new lvec3(5L, 0, -1L);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(-1L, v.z);
                Assert.AreEqual(-1L, v.w);
            }
            {
                var ov = new lvec3(-6L, 8L, 9L);
                var v = ov.swizzle.bb;
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(9L, v.y);
            }
            {
                var ov = new lvec3(-6L, -7L, 5L);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(-6L, v.z);
            }
            {
                var ov = new lvec3(4L, 2L, -9L);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(-9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(4L, v.z);
                Assert.AreEqual(4L, v.w);
            }
            {
                var ov = new lvec3(-8L, -6L, -8L);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
                Assert.AreEqual(-6L, v.w);
            }
            {
                var ov = new lvec3(1, -9L, 0);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var ov = new lvec3(4L, 5L, -7L);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(-7L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(5L, v.z);
            }
            {
                var ov = new lvec3(-2L, -3L, -1L);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(-1L, v.x);
                Assert.AreEqual(-1L, v.y);
                Assert.AreEqual(-3L, v.z);
                Assert.AreEqual(-2L, v.w);
            }
            {
                var ov = new lvec3(1, 6L, -3L);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(-3L, v.x);
                Assert.AreEqual(-3L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec3(3L, 6L, 5L);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(6L, v.z);
                Assert.AreEqual(5L, v.w);
            }
            {
                var ov = new lvec3(-8L, 2L, 6L);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(6L, v.y);
                Assert.AreEqual(6L, v.z);
            }
            {
                var ov = new lvec3(6L, 7L, 5L);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(6L, v.w);
            }
            {
                var ov = new lvec3(6L, -5L, 1);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(-5L, v.w);
            }
            {
                var ov = new lvec3(4L, 3L, 5L);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(5L, v.x);
                Assert.AreEqual(5L, v.y);
                Assert.AreEqual(5L, v.z);
                Assert.AreEqual(5L, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new lvec3(1, -9L, -9L);
                var v1 = new lvec2(9L, -9L);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9L, v0.x);
                Assert.AreEqual(-9L, v0.y);
                Assert.AreEqual(-9L, v0.z);
            
                Assert.AreEqual(1, v2.x);
                Assert.AreEqual(-9L, v2.y);
            }
            {
                var v0 = new lvec3(4L, 1, -3L);
                var v1 = new lvec2(-9L, 9L);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-9L, v0.x);
                Assert.AreEqual(1, v0.y);
                Assert.AreEqual(9L, v0.z);
            
                Assert.AreEqual(4L, v2.x);
                Assert.AreEqual(-3L, v2.y);
            }
            {
                var v0 = new lvec3(-5L, -6L, -5L);
                var v1 = new lvec2(-3L, -2L);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-5L, v0.x);
                Assert.AreEqual(-3L, v0.y);
                Assert.AreEqual(-2L, v0.z);
            
                Assert.AreEqual(-6L, v2.x);
                Assert.AreEqual(-5L, v2.y);
            }
            {
                var v0 = new lvec3(0, 3L, -4L);
                var v1 = new lvec3(-3L, -3L, 0);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-3L, v0.x);
                Assert.AreEqual(-3L, v0.y);
                Assert.AreEqual(0, v0.z);
            
                Assert.AreEqual(0, v2.x);
                Assert.AreEqual(3L, v2.y);
                Assert.AreEqual(-4L, v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new lvec3(-7L, 5L, -4L);
                var v1 = -4L;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-4L, v0.x);
                Assert.AreEqual(5L, v0.y);
                Assert.AreEqual(-4L, v0.z);
            
                Assert.AreEqual(-7L, v2);
            }
            {
                var v0 = new lvec3(9L, -1L, -1L);
                var v1 = 4L;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9L, v0.x);
                Assert.AreEqual(4L, v0.y);
                Assert.AreEqual(-1L, v0.z);
            
                Assert.AreEqual(-1L, v2);
            }
            {
                var v0 = new lvec3(-8L, 4L, 4L);
                var v1 = new lvec2(9L, -2L);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9L, v0.x);
                Assert.AreEqual(-2L, v0.y);
                Assert.AreEqual(4L, v0.z);
            
                Assert.AreEqual(-8L, v2.x);
                Assert.AreEqual(4L, v2.y);
            }
            {
                var v0 = new lvec3(-9L, 4L, -5L);
                var v1 = 5L;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-9L, v0.x);
                Assert.AreEqual(4L, v0.y);
                Assert.AreEqual(5L, v0.z);
            
                Assert.AreEqual(-5L, v2);
            }
            {
                var v0 = new lvec3(-1L, -1L, 4L);
                var v1 = new lvec2(8L, 4L);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(8L, v0.x);
                Assert.AreEqual(-1L, v0.y);
                Assert.AreEqual(4L, v0.z);
            
                Assert.AreEqual(-1L, v2.x);
                Assert.AreEqual(4L, v2.y);
            }
            {
                var v0 = new lvec3(6L, 8L, -2L);
                var v1 = new lvec2(1, -7L);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6L, v0.x);
                Assert.AreEqual(1, v0.y);
                Assert.AreEqual(-7L, v0.z);
            
                Assert.AreEqual(8L, v2.x);
                Assert.AreEqual(-2L, v2.y);
            }
            {
                var v0 = new lvec3(8L, -2L, -1L);
                var v1 = new lvec3(-2L, -4L, -9L);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(-2L, v0.x);
                Assert.AreEqual(-4L, v0.y);
                Assert.AreEqual(-9L, v0.z);
            
                Assert.AreEqual(8L, v2.x);
                Assert.AreEqual(-2L, v2.y);
                Assert.AreEqual(-1L, v2.z);
            }
        }

    }
}
