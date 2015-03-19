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
    public class DoubleVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec4(1.0);
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(1.0, v.z);
                Assert.AreEqual(1.0, v.w);
            }
            {
                var v = new dvec4(-5.5d, -5, 6, -7);
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(-7, v.w);
            }
            {
                var v = new dvec4(new dvec2(4.5d, -8));
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec3(-5.5d, -5, -5));
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(-5, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec4(0.5d, -2.5d, -0.5d, -7));
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
                Assert.AreEqual(-0.5d, v.z);
                Assert.AreEqual(-7, v.w);
            }
        }

    }
}
