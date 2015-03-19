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
    public class DoubleVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec3(8.5d);
                Assert.AreEqual(8.5d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(8.5d, v.z);
            }
            {
                var v = new dvec3(2.5d, 1.0, -1);
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(-1, v.z);
            }
            {
                var v = new dvec3(new dvec2(0.0, 9.5d));
                Assert.AreEqual(0.0, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(0.0, v.z);
            }
            {
                var v = new dvec3(new dvec3(5.5d, 9, -6));
                Assert.AreEqual(5.5d, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var v = new dvec3(new dvec4(9, -6.5d, -6, 2));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-6.5d, v.y);
                Assert.AreEqual(-6, v.z);
            }
        }

    }
}
