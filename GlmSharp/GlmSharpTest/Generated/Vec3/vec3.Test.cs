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
    public class FloatVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new vec3(5.5f);
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(5.5f, v.y);
                Assert.AreEqual(5.5f, v.z);
            }
            {
                var v = new vec3(0f, 1f, -7.5f);
                Assert.AreEqual(0f, v.x);
                Assert.AreEqual(1f, v.y);
                Assert.AreEqual(-7.5f, v.z);
            }
            {
                var v = new vec3(new vec2(-7.5f, -3));
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var v = new vec3(new vec3(-7, -6, -4));
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var v = new vec3(new vec4(-5.5f, 5, 5, 4.5f));
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(5, v.z);
            }
        }

    }
}
