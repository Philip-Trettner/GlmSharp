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

namespace GlmSharpTest.Generated.Vec4
{
    [TestFixture]
    public class DecimalVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new decvec4(-3);
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var v = new decvec4(-6, -2, -6.5m, -7);
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-6.5m, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var v = new decvec4(new decvec2(-1, -5.5m));
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-5.5m, v.y);
                Assert.AreEqual(0m, v.z);
                Assert.AreEqual(0m, v.w);
            }
            {
                var v = new decvec4(new decvec3(-1, -7.5m, 4));
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(0m, v.w);
            }
            {
                var v = new decvec4(new decvec4(-5.5m, 2.5m, 4.5m, 8));
                Assert.AreEqual(-5.5m, v.x);
                Assert.AreEqual(2.5m, v.y);
                Assert.AreEqual(4.5m, v.z);
                Assert.AreEqual(8, v.w);
            }
        }

    }
}
