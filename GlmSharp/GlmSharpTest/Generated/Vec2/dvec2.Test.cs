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

namespace GlmSharpTest.Generated.Vec2
{
    [TestFixture]
    public class DoubleVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec2(2);
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var v = new dvec2(-4.5d, -2.5d);
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-2.5d, v.y);
            }
            {
                var v = new dvec2(new dvec2(4.5d, -0.5d));
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-0.5d, v.y);
            }
            {
                var v = new dvec2(new dvec3(-5, 8, -5.5d));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(8, v.y);
            }
            {
                var v = new dvec2(new dvec4(-8, 7, 4.5d, 5.5d));
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(7, v.y);
            }
        }

    }
}
