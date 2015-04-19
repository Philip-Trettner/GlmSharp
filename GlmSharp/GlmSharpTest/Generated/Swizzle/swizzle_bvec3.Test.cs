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
    public class BoolSwizzleVec3Test
    {

        [Test]
        public void XYZW()
        {
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xxxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.xxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xxzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xyyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xyzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.xyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.xzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xzxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.xzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.xzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.xzzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.xzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.xzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yxxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yxyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yxzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yyxx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yyxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yyxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yyyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yyzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yyzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.yzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.yzxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.yzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yzyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.yzyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yzyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.yzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.yzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.yzzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.yzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zxxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zxxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zxxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zxy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zxyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zxyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zxzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zxzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zxzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zyxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zyxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zyxz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zyyx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zyyy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zyyz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zyzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.zyzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zyzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.zz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zzx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zzxx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.zzxy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zzxz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zzy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zzyx;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.zzyy;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zzyz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.zzz;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.zzzx;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.zzzy;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.zzzz;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
        }

        [Test]
        public void RGBA()
        {
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rrrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rrrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rrrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rrgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.rrgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rrgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rrbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rrbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rrbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rgrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.rggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rggg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.rbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rbgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.rbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.rbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.rbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.rbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.rbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.grr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.grrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.grrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.grg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.grgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.grgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.grgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.grb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.grbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.grbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.grbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.ggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.ggrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.ggrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.ggrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.ggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.gggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.ggb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.ggbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.ggbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.ggbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.gbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.gbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gbrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.gbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.gbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.gbgg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.gbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.gbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.gbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.gbbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.gbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.br;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.brr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.brrr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.brrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.brrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.brg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.brgr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.brgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.brgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.brb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.brbr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.brbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.brbb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bgrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bgrg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bgrb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, true);
                var v = ov.swizzle.bgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, true, false);
                var v = ov.swizzle.bggr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bggg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bggb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bgbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bgbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bgbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bbrr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bbrg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bbrb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bbg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bbgr;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, true, true);
                var v = ov.swizzle.bbgg;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, false, true);
                var v = ov.swizzle.bbgb;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(false, true, false);
                var v = ov.swizzle.bbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var ov = new bvec3(true, false, true);
                var v = ov.swizzle.bbbr;
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var ov = new bvec3(true, false, false);
                var v = ov.swizzle.bbbg;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var ov = new bvec3(false, false, false);
                var v = ov.swizzle.bbbb;
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
        }

        [Test]
        public void InlineXYZW()
        {
            {
                var v0 = new bvec3(false, false, false);
                var v1 = new bvec2(true, true);
                var v2 = v0.xy;
                v0.xy = v1;
                var v3 = v0.xy;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(true, false, false);
                var v1 = new bvec2(false, true);
                var v2 = v0.xz;
                v0.xz = v1;
                var v3 = v0.xz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(false, true, false);
                var v1 = new bvec2(true, true);
                var v2 = v0.yz;
                v0.yz = v1;
                var v3 = v0.yz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(true, false, true);
                var v1 = new bvec3(false, false, false);
                var v2 = v0.xyz;
                v0.xyz = v1;
                var v3 = v0.xyz;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(true, v2.z);
            }
        }

        [Test]
        public void InlineRGBA()
        {
            {
                var v0 = new bvec3(true, true, false);
                var v1 = false;
                var v2 = v0.r;
                v0.r = v1;
                var v3 = v0.r;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec3(true, true, false);
                var v1 = false;
                var v2 = v0.g;
                v0.g = v1;
                var v3 = v0.g;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(false, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec3(true, true, true);
                var v1 = new bvec2(true, true);
                var v2 = v0.rg;
                v0.rg = v1;
                var v3 = v0.rg;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(true, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(true, v2.y);
            }
            {
                var v0 = new bvec3(false, true, true);
                var v1 = false;
                var v2 = v0.b;
                v0.b = v1;
                var v3 = v0.b;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2);
            }
            {
                var v0 = new bvec3(false, true, false);
                var v1 = new bvec2(false, false);
                var v2 = v0.rb;
                v0.rb = v1;
                var v3 = v0.rb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(false, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(false, true, false);
                var v1 = new bvec2(true, false);
                var v2 = v0.gb;
                v0.gb = v1;
                var v3 = v0.gb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(false, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
            }
            {
                var v0 = new bvec3(true, false, true);
                var v1 = new bvec3(true, true, false);
                var v2 = v0.rgb;
                v0.rgb = v1;
                var v3 = v0.rgb;
            
                Assert.AreEqual(v1, v3);
            
                Assert.AreEqual(true, v0.x);
                Assert.AreEqual(true, v0.y);
                Assert.AreEqual(false, v0.z);
            
                Assert.AreEqual(true, v2.x);
                Assert.AreEqual(false, v2.y);
                Assert.AreEqual(true, v2.z);
            }
        }

    }
}
