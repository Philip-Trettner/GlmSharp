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
    public class UintSwizzleVec3Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new uvec3(6u, 4u, 5u);
                var v = ov.swizzle.xx;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
            }
            {
                var ov = new uvec3(1u, 9u, 8u);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec3(7u, 8u, 4u);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(7u, 7u, 2u);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(1u, 6u, 7u);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(3u, 9u, 5u);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var ov = new uvec3(4u, 9u, 7u);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(8u, 8u, 1u);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(9u, 8u, 7u);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(3u, 5u, 5u);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(5u, v.z);
            }
            {
                var ov = new uvec3(2u, 8u, 2u);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(9u, 4u, 5u);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(7u, 4u, 3u);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(9u, 8u, 7u);
                var v = ov.swizzle.xy;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(8u, v.y);
            }
            {
                var ov = new uvec3(0u, 4u, 1u);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var ov = new uvec3(2u, 1u, 5u);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(2u, 7u, 2u);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(0u, 7u, 8u);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(7u, 7u, 5u);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec3(4u, 1u, 0u);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(1u, 4u, 2u);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(8u, 4u, 9u);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(9u, 1u, 2u);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var ov = new uvec3(2u, 6u, 5u);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(2u, 4u, 0u);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(9u, 8u, 3u);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(9u, 7u, 7u);
                var v = ov.swizzle.xz;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(7u, v.y);
            }
            {
                var ov = new uvec3(1u, 0u, 8u);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec3(3u, 2u, 0u);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(4u, 1u, 6u);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(0u, 2u, 2u);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(2u, 8u, 4u);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uvec3(4u, 1u, 0u);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(2u, 2u, 9u);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(3u, 0u, 0u);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(6u, 8u, 2u);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var ov = new uvec3(7u, 7u, 9u);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(1u, 4u, 4u);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(3u, 9u, 3u);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(3u, 4u, 2u);
                var v = ov.swizzle.yx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(3u, v.y);
            }
            {
                var ov = new uvec3(8u, 4u, 0u);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uvec3(5u, 2u, 3u);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(3u, 9u, 6u);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(6u, 4u, 6u);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(3u, 7u, 4u);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec3(8u, 8u, 0u);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(8u, 7u, 3u);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(7u, 7u, 4u);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(6u, 8u, 8u);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uvec3(8u, 9u, 8u);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(1u, 1u, 6u);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(8u, 3u, 8u);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(9u, 7u, 8u);
                var v = ov.swizzle.yy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
            }
            {
                var ov = new uvec3(6u, 2u, 8u);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec3(6u, 0u, 2u);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(3u, 7u, 7u);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(9u, 5u, 1u);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(3u, 5u, 7u);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
            }
            {
                var ov = new uvec3(8u, 0u, 7u);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(5u, 9u, 3u);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(5u, 5u, 0u);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(8u, 5u, 3u);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(3u, v.z);
            }
            {
                var ov = new uvec3(9u, 4u, 3u);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(6u, 8u, 1u);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(1u, 1u, 4u);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(5u, 1u, 6u);
                var v = ov.swizzle.yz;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(6u, v.y);
            }
            {
                var ov = new uvec3(1u, 2u, 0u);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec3(0u, 8u, 4u);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(6u, 7u, 5u);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(9u, 0u, 3u);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(0u, 3u, 7u);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(3u, v.z);
            }
            {
                var ov = new uvec3(5u, 1u, 7u);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(8u, 8u, 5u);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(8u, 3u, 2u);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(4u, 2u, 6u);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec3(0u, 1u, 3u);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(3u, 2u, 9u);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(0u, 4u, 6u);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(2u, 4u, 6u);
                var v = ov.swizzle.zx;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(2u, v.y);
            }
            {
                var ov = new uvec3(6u, 1u, 7u);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec3(8u, 0u, 4u);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(9u, 5u, 5u);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(3u, 6u, 0u);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(6u, 7u, 2u);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec3(0u, 2u, 9u);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(8u, 5u, 6u);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(7u, 6u, 6u);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(1u, 5u, 7u);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec3(3u, 0u, 8u);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(0u, 2u, 6u);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(1u, 1u, 7u);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(8u, 0u, 3u);
                var v = ov.swizzle.zy;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(0u, v.y);
            }
            {
                var ov = new uvec3(8u, 4u, 7u);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uvec3(0u, 6u, 4u);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(3u, 7u, 5u);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(7u, 0u, 1u);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(7u, 4u, 8u);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
            }
            {
                var ov = new uvec3(0u, 8u, 4u);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(0u, 6u, 5u);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(7u, 6u, 5u);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(6u, 3u, 4u);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(4u, v.z);
            }
            {
                var ov = new uvec3(3u, 5u, 5u);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(5u, 2u, 1u);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(5u, 9u, 1u);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(9u, 7u, 0u);
                var v = ov.swizzle.zz;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
            }
            {
                var ov = new uvec3(2u, 8u, 8u);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var ov = new uvec3(1u, 6u, 9u);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(6u, 2u, 8u);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(7u, 1u, 3u);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(2u, 7u, 4u);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec3(8u, 0u, 8u);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(1u, 3u, 3u);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(0u, 0u, 2u);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(0u, 1u, 7u);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec3(0u, 2u, 4u);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(7u, 1u, 1u);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(4u, 8u, 8u);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new uvec3(2u, 1u, 2u);
                var v = ov.swizzle.rr;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
            }
            {
                var ov = new uvec3(7u, 5u, 5u);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec3(3u, 6u, 1u);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(3u, 0u, 1u);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(0u, 6u, 0u);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(6u, 4u, 5u);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(4u, v.z);
            }
            {
                var ov = new uvec3(2u, 1u, 4u);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(9u, 3u, 5u);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(5u, 7u, 1u);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(1u, 5u, 1u);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec3(7u, 1u, 3u);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(6u, 2u, 3u);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(2u, 5u, 0u);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(8u, 8u, 8u);
                var v = ov.swizzle.rg;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
            }
            {
                var ov = new uvec3(1u, 7u, 9u);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec3(1u, 1u, 9u);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(0u, 7u, 4u);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(7u, 8u, 7u);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(6u, 2u, 7u);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var ov = new uvec3(7u, 1u, 8u);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(4u, 1u, 0u);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(0u, 6u, 9u);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(7u, 4u, 4u);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
            }
            {
                var ov = new uvec3(7u, 3u, 8u);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(4u, 3u, 2u);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(6u, 8u, 6u);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(5u, 3u, 5u);
                var v = ov.swizzle.rb;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
            }
            {
                var ov = new uvec3(1u, 1u, 8u);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec3(6u, 0u, 2u);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(5u, 9u, 9u);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(5u, 5u, 4u);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(2u, 4u, 7u);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(4u, v.z);
            }
            {
                var ov = new uvec3(7u, 1u, 1u);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(0u, 3u, 7u);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(5u, 3u, 3u);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(6u, 2u, 5u);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
            }
            {
                var ov = new uvec3(4u, 9u, 4u);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(1u, 2u, 8u);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(2u, 2u, 9u);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(2u, 4u, 6u);
                var v = ov.swizzle.gr;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(2u, v.y);
            }
            {
                var ov = new uvec3(6u, 2u, 4u);
                var v = ov.swizzle.grr;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec3(4u, 1u, 8u);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(4u, 2u, 9u);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(5u, 9u, 6u);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(5u, 4u, 9u);
                var v = ov.swizzle.grg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(4u, v.z);
            }
            {
                var ov = new uvec3(8u, 5u, 8u);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(4u, 0u, 7u);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(7u, 0u, 0u);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(5u, 4u, 3u);
                var v = ov.swizzle.grb;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(3u, v.z);
            }
            {
                var ov = new uvec3(5u, 9u, 2u);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(7u, 5u, 7u);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(5u, 4u, 1u);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(2u, 1u, 1u);
                var v = ov.swizzle.gg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var ov = new uvec3(5u, 1u, 9u);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(5u, v.z);
            }
            {
                var ov = new uvec3(6u, 9u, 0u);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(7u, 6u, 7u);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(8u, 4u, 6u);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(1u, 7u, 3u);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec3(8u, 9u, 1u);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(4u, 9u, 6u);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(4u, 8u, 3u);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(6u, 8u, 3u);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(3u, v.z);
            }
            {
                var ov = new uvec3(9u, 0u, 9u);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(8u, 5u, 4u);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(7u, 8u, 8u);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(7u, 1u, 1u);
                var v = ov.swizzle.gb;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var ov = new uvec3(9u, 7u, 8u);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var ov = new uvec3(5u, 7u, 4u);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(5u, 6u, 7u);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(3u, 6u, 5u);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(0u, 8u, 1u);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uvec3(4u, 1u, 3u);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(6u, 9u, 1u);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(7u, 7u, 6u);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(7u, 9u, 9u);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var ov = new uvec3(1u, 4u, 8u);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(5u, 0u, 7u);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(9u, 4u, 1u);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(8u, 8u, 0u);
                var v = ov.swizzle.br;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(8u, v.y);
            }
            {
                var ov = new uvec3(8u, 1u, 1u);
                var v = ov.swizzle.brr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(8u, v.z);
            }
            {
                var ov = new uvec3(5u, 6u, 3u);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(4u, 8u, 6u);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(2u, 2u, 7u);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(4u, 1u, 2u);
                var v = ov.swizzle.brg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var ov = new uvec3(0u, 2u, 9u);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(2u, 7u, 7u);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(5u, 3u, 2u);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(8u, 7u, 6u);
                var v = ov.swizzle.brb;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec3(7u, 0u, 3u);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(0u, 6u, 2u);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(2u, 7u, 8u);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(8u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var ov = new uvec3(9u, 1u, 1u);
                var v = ov.swizzle.bg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var ov = new uvec3(2u, 3u, 1u);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var ov = new uvec3(2u, 9u, 1u);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(1u, 1u, 8u);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(5u, 8u, 2u);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(8u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(1u, 6u, 1u);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec3(3u, 3u, 7u);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(3u, v.w);
            }
            {
                var ov = new uvec3(9u, 6u, 9u);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(6u, v.w);
            }
            {
                var ov = new uvec3(6u, 7u, 7u);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(2u, 2u, 6u);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(6u, v.z);
            }
            {
                var ov = new uvec3(5u, 1u, 3u);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(3u, v.z);
                Assert.AreEqual(5u, v.w);
            }
            {
                var ov = new uvec3(3u, 1u, 1u);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(8u, 9u, 4u);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(4u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(5u, 2u, 4u);
                var v = ov.swizzle.bb;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
            }
            {
                var ov = new uvec3(0u, 7u, 5u);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var ov = new uvec3(7u, 1u, 1u);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(7u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(1u, 9u, 9u);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(0u, 9u, 4u);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(4u, v.w);
            }
            {
                var ov = new uvec3(0u, 9u, 4u);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(4u, v.x);
                Assert.AreEqual(4u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var ov = new uvec3(2u, 5u, 5u);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(2u, v.w);
            }
            {
                var ov = new uvec3(4u, 0u, 6u);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var ov = new uvec3(5u, 5u, 9u);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(5u, v.z);
                Assert.AreEqual(9u, v.w);
            }
            {
                var ov = new uvec3(5u, 1u, 7u);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(7u, v.x);
                Assert.AreEqual(7u, v.y);
                Assert.AreEqual(7u, v.z);
            }
            {
                var ov = new uvec3(1u, 2u, 6u);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(6u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var ov = new uvec3(6u, 7u, 0u);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(7u, v.w);
            }
            {
                var ov = new uvec3(2u, 8u, 9u);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
                Assert.AreEqual(9u, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new uvec3(1u, 5u, 8u);
                var v1 = new uvec2(0u, 3u);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(0u, v0.x);
                Assert.AreEqual(3u, v0.y);
                Assert.AreEqual(8u, v0.z);
            
                Assert.AreEqual(1u, v2.x);
                Assert.AreEqual(5u, v2.y);
            }
            {
                var v0 = new uvec3(4u, 5u, 2u);
                var v1 = new uvec2(6u, 3u);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6u, v0.x);
                Assert.AreEqual(5u, v0.y);
                Assert.AreEqual(3u, v0.z);
            
                Assert.AreEqual(4u, v2.x);
                Assert.AreEqual(2u, v2.y);
            }
            {
                var v0 = new uvec3(2u, 0u, 8u);
                var v1 = new uvec2(3u, 4u);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2u, v0.x);
                Assert.AreEqual(3u, v0.y);
                Assert.AreEqual(4u, v0.z);
            
                Assert.AreEqual(0u, v2.x);
                Assert.AreEqual(8u, v2.y);
            }
            {
                var v0 = new uvec3(8u, 5u, 1u);
                var v1 = new uvec3(2u, 4u, 4u);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(2u, v0.x);
                Assert.AreEqual(4u, v0.y);
                Assert.AreEqual(4u, v0.z);
            
                Assert.AreEqual(8u, v2.x);
                Assert.AreEqual(5u, v2.y);
                Assert.AreEqual(1u, v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new uvec3(8u, 0u, 9u);
                var v1 = 3u;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(3u, v0.x);
                Assert.AreEqual(0u, v0.y);
                Assert.AreEqual(9u, v0.z);
            
                Assert.AreEqual(8u, v2);
            }
            {
                var v0 = new uvec3(8u, 7u, 2u);
                var v1 = 6u;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(8u, v0.x);
                Assert.AreEqual(6u, v0.y);
                Assert.AreEqual(2u, v0.z);
            
                Assert.AreEqual(7u, v2);
            }
            {
                var v0 = new uvec3(6u, 7u, 3u);
                var v1 = new uvec2(0u, 6u);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(0u, v0.x);
                Assert.AreEqual(6u, v0.y);
                Assert.AreEqual(3u, v0.z);
            
                Assert.AreEqual(6u, v2.x);
                Assert.AreEqual(7u, v2.y);
            }
            {
                var v0 = new uvec3(9u, 0u, 7u);
                var v1 = 2u;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(9u, v0.x);
                Assert.AreEqual(0u, v0.y);
                Assert.AreEqual(2u, v0.z);
            
                Assert.AreEqual(7u, v2);
            }
            {
                var v0 = new uvec3(8u, 2u, 7u);
                var v1 = new uvec2(5u, 2u);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(5u, v0.x);
                Assert.AreEqual(2u, v0.y);
                Assert.AreEqual(2u, v0.z);
            
                Assert.AreEqual(8u, v2.x);
                Assert.AreEqual(7u, v2.y);
            }
            {
                var v0 = new uvec3(6u, 3u, 0u);
                var v1 = new uvec2(3u, 4u);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6u, v0.x);
                Assert.AreEqual(3u, v0.y);
                Assert.AreEqual(4u, v0.z);
            
                Assert.AreEqual(3u, v2.x);
                Assert.AreEqual(0u, v2.y);
            }
            {
                var v0 = new uvec3(7u, 1u, 4u);
                var v1 = new uvec3(6u, 3u, 9u);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(6u, v0.x);
                Assert.AreEqual(3u, v0.y);
                Assert.AreEqual(9u, v0.z);
            
                Assert.AreEqual(7u, v2.x);
                Assert.AreEqual(1u, v2.y);
                Assert.AreEqual(4u, v2.z);
            }
        }

    }
}
