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
    public class FloatVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new vec4(7);
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(7, v.z);
                Assert.AreEqual(7, v.w);
            }
            {
                var v = new vec4(3.5f, -7.5f, -9, 9.5f);
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(9.5f, v.w);
            }
            {
                var v = new vec4(new vec2(-5.5f, 1f));
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var v = new vec4(new vec3(-5, -0.5f, -6.5f));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-0.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var v = new vec4(new vec4(6, 3, 8.5f, 7.5f));
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(8.5f, v.z);
                Assert.AreEqual(7.5f, v.w);
            }
        }

    }
}
