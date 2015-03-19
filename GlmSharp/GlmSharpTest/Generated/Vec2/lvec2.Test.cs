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
    public class LongVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec2(-5);
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
            }
            {
                var v = new lvec2(2, -3);
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-3, v.y);
            }
            {
                var v = new lvec2(new lvec2(2, 8));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(8, v.y);
            }
            {
                var v = new lvec2(new lvec3(-5, -7, -1));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-7, v.y);
            }
            {
                var v = new lvec2(new lvec4(4, 6, -6, 2));
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(6, v.y);
            }
        }

    }
}
