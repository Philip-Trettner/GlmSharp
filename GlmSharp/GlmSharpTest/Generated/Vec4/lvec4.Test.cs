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
    public class LongVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec4(-4);
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(-4, v.z);
                Assert.AreEqual(-4, v.w);
            }
            {
                var v = new lvec4(1, -2, -8, -7);
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var v = new lvec4(new lvec2(2, 8));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec3(-1, -9, 7));
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec4(3, 7, 1, 6));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(1, v.z);
                Assert.AreEqual(6, v.w);
            }
        }

    }
}
