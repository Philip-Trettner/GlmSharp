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
    public class IntVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec2(7);
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(7, v.y);
            }
            {
                var v = new ivec2(-8, 6);
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(6, v.y);
            }
            {
                var v = new ivec2(new ivec2(-8, 6));
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(6, v.y);
            }
            {
                var v = new ivec2(new ivec3(-9, -6, 9));
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-6, v.y);
            }
            {
                var v = new ivec2(new ivec4(-3, 5, 7, -7));
                Assert.AreEqual(-3, v.x);
                Assert.AreEqual(5, v.y);
            }
        }

    }
}
