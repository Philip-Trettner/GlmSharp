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
    public class IntVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec3(-8);
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var v = new ivec3(8, -5, -4);
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var v = new ivec3(new ivec2(-2, 1));
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(1, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new ivec3(new ivec3(1, 2, -5));
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(-5, v.z);
            }
            {
                var v = new ivec3(new ivec4(-2, -1, 2, -3));
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(2, v.z);
            }
        }

    }
}
