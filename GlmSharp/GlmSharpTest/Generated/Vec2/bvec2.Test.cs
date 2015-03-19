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
    public class BoolVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new bvec2(false);
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var v = new bvec2(true, false);
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var v = new bvec2(new bvec2(true, true));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var v = new bvec2(new bvec3(true, true, false));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
            }
            {
                var v = new bvec2(new bvec4(false, false, true, true));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
        }

    }
}
