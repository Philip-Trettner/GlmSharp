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
    public class UintVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uvec2(6);
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
            }
            {
                var v = new uvec2(8, 5);
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var v = new uvec2(new uvec2(1u, 9));
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(9, v.y);
            }
            {
                var v = new uvec2(new uvec3(5, 5, 1u));
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var v = new uvec2(new uvec4(7, 7, 3, 7));
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
            }
        }

    }
}
