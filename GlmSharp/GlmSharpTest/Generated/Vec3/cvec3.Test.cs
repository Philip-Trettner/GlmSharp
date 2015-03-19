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
    public class ComplexVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new cvec3(new Complex(-1.5d, 5.5d));
                Assert.AreEqual(new Complex(-1.5d, 5.5d), v.x);
                Assert.AreEqual(new Complex(-1.5d, 5.5d), v.y);
                Assert.AreEqual(new Complex(-1.5d, 5.5d), v.z);
            }
            {
                var v = new cvec3(new Complex(-5, 3), new Complex(7.5d, 9.5d), new Complex(-0.5d, 2.5d));
                Assert.AreEqual(new Complex(-5, 3), v.x);
                Assert.AreEqual(new Complex(7.5d, 9.5d), v.y);
                Assert.AreEqual(new Complex(-0.5d, 2.5d), v.z);
            }
            {
                var v = new cvec3(new cvec2(new Complex(9.5d, 6.5d), new Complex(1.5d, 3.5d)));
                Assert.AreEqual(new Complex(9.5d, 6.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, 3.5d), v.y);
                Assert.AreEqual(Complex.Zero, v.z);
            }
            {
                var v = new cvec3(new cvec3(new Complex(4, -3.5d), new Complex(-4, 7.5d), new Complex(0.0, -8.5d)));
                Assert.AreEqual(new Complex(4, -3.5d), v.x);
                Assert.AreEqual(new Complex(-4, 7.5d), v.y);
                Assert.AreEqual(new Complex(0.0, -8.5d), v.z);
            }
            {
                var v = new cvec3(new cvec4(new Complex(7, 2.5d), new Complex(1.5d, -5.5d), new Complex(1.0, -7), new Complex(2.5d, -7.5d)));
                Assert.AreEqual(new Complex(7, 2.5d), v.x);
                Assert.AreEqual(new Complex(1.5d, -5.5d), v.y);
                Assert.AreEqual(new Complex(1.0, -7), v.z);
            }
        }

    }
}
