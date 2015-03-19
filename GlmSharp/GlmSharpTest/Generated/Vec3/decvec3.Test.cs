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

namespace GlmSharpTest.Generated.Vec3
{
    [TestFixture]
    public class DecimalVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new decvec3(7);
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var v = new decvec3(7, -0.5m, -7.5m);
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-0.5m, v.y);
                Assert.AreEqual(-7.5m, v.z);
            }
            {
                var v = new decvec3(new decvec2(2.5m, 1m));
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(1m, v.y);
                Assert.AreEqual(0m, v.z);
            }
            {
                var v = new decvec3(new decvec3(-2, 1.5m, -2.5m));
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(1.5m, v.y);
                Assert.AreEqual(-2.5m, v.z);
            }
            {
                var v = new decvec3(new decvec4(1.5m, 4.5m, -8, 0m));
                Assert.AreEqual(1.5m, v.x);
                Assert.AreEqual(4.5m, v.y);
                Assert.AreEqual(-8, v.z);
            }
        }

    }
}
