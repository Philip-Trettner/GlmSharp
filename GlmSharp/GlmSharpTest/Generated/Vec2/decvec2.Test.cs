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
    public class DecimalVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new decvec2(1.5m);
                Assert.AreEqual(1.5m, v.x);
                Assert.AreEqual(1.5m, v.y);
            }
            {
                var v = new decvec2(-3.5m, -6.5m);
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(-6.5m, v.y);
            }
            {
                var v = new decvec2(new decvec2(-6, -4));
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(-4, v.y);
            }
            {
                var v = new decvec2(new decvec3(-5.5m, 3, -4.5m));
                Assert.AreEqual(-5.5m, v.x);
                Assert.AreEqual(3, v.y);
            }
            {
                var v = new decvec2(new decvec4(9, -3, -8, -6.5m));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-3, v.y);
            }
        }

    }
}
