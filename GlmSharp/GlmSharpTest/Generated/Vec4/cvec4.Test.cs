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
    public class ComplexVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new cvec4(new Complex(0.0, 7.5d));
                Assert.AreEqual(new Complex(0.0, 7.5d), v.x);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.y);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.z);
                Assert.AreEqual(new Complex(0.0, 7.5d), v.w);
            }
            {
                var v = new cvec4(new Complex(4.5d, -2), new Complex(-2, 4), new Complex(-4.5d, 9.5d), new Complex(2, 4));
                Assert.AreEqual(new Complex(4.5d, -2), v.x);
                Assert.AreEqual(new Complex(-2, 4), v.y);
                Assert.AreEqual(new Complex(-4.5d, 9.5d), v.z);
                Assert.AreEqual(new Complex(2, 4), v.w);
            }
            {
                var v = new cvec4(new cvec2(new Complex(4, -6.5d), new Complex(-0.5d, 9.5d)));
                Assert.AreEqual(new Complex(4, -6.5d), v.x);
                Assert.AreEqual(new Complex(-0.5d, 9.5d), v.y);
                Assert.AreEqual(Complex.Zero, v.z);
                Assert.AreEqual(Complex.Zero, v.w);
            }
            {
                var v = new cvec4(new cvec3(new Complex(8.5d, 7.5d), new Complex(2.5d, 6.5d), new Complex(-9.5d, 8.5d)));
                Assert.AreEqual(new Complex(8.5d, 7.5d), v.x);
                Assert.AreEqual(new Complex(2.5d, 6.5d), v.y);
                Assert.AreEqual(new Complex(-9.5d, 8.5d), v.z);
                Assert.AreEqual(Complex.Zero, v.w);
            }
            {
                var v = new cvec4(new cvec4(new Complex(2.5d, 2), new Complex(-2, -8), new Complex(-7, 9), new Complex(2.5d, 0.0)));
                Assert.AreEqual(new Complex(2.5d, 2), v.x);
                Assert.AreEqual(new Complex(-2, -8), v.y);
                Assert.AreEqual(new Complex(-7, 9), v.z);
                Assert.AreEqual(new Complex(2.5d, 0.0), v.w);
            }
        }

    }
}
