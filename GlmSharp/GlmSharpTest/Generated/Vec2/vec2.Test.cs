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
    public class FloatVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new vec2(-5.5f);
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
            }
            {
                var v = new vec2(5, 1f);
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(1f, v.y);
            }
            {
                var v = new vec2(new vec2(3, -6.5f));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-6.5f, v.y);
            }
            {
                var v = new vec2(new vec3(2, 4, 4.5f));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(4, v.y);
            }
            {
                var v = new vec2(new vec4(2, -4.5f, -3.5f, -0.5f));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-4.5f, v.y);
            }
        }

    }
}
