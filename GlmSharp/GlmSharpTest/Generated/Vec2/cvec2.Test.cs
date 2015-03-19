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
    public class ComplexVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new cvec2(new Complex(1.5d, -3));
                Assert.AreEqual(new Complex(1.5d, -3), v.x);
                Assert.AreEqual(new Complex(1.5d, -3), v.y);
            }
            {
                var v = new cvec2(new Complex(9.5d, -9), new Complex(-5, 6.5d));
                Assert.AreEqual(new Complex(9.5d, -9), v.x);
                Assert.AreEqual(new Complex(-5, 6.5d), v.y);
            }
            {
                var v = new cvec2(new cvec2(new Complex(-4, -8), new Complex(1.0, -9.5d)));
                Assert.AreEqual(new Complex(-4, -8), v.x);
                Assert.AreEqual(new Complex(1.0, -9.5d), v.y);
            }
            {
                var v = new cvec2(new cvec3(new Complex(-1.5d, -8), new Complex(4.5d, -5.5d), new Complex(-2.5d, -1)));
                Assert.AreEqual(new Complex(-1.5d, -8), v.x);
                Assert.AreEqual(new Complex(4.5d, -5.5d), v.y);
            }
            {
                var v = new cvec2(new cvec4(new Complex(-1, -5), new Complex(4.5d, -4.5d), new Complex(3.5d, 0.0), new Complex(-7.5d, -4)));
                Assert.AreEqual(new Complex(-1, -5), v.x);
                Assert.AreEqual(new Complex(4.5d, -4.5d), v.y);
            }
        }

    }
}
