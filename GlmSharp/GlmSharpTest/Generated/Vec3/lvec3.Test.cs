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
    public class LongVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec3(-6);
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-6, v.z);
            }
            {
                var v = new lvec3(-3, 9, 3);
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var v = new lvec3(new lvec2(-1, 3));
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new lvec3(new lvec3(6, -1, 0));
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new lvec3(new lvec4(-7, -1, 0, 3));
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(0, v.z);
            }
        }

    }
}
