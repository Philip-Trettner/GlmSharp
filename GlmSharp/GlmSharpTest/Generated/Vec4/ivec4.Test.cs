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
    public class IntVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec4(4);
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var v = new ivec4(-7, 5, 7, -8);
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var v = new ivec4(new ivec2(-5, 9));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec3(9, -8, -1));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec4(4, 4, 6, -3));
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-3, v.w);
            }
        }

    }
}
