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
    public class UintVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uvec3(8);
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var v = new uvec3(4, 8, 2);
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var v = new uvec3(new uvec2(8, 3));
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var v = new uvec3(new uvec3(1u, 3, 1u));
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var v = new uvec3(new uvec4(0u, 5, 1u, 7));
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(1u, v.z);
            }
        }

    }
}
