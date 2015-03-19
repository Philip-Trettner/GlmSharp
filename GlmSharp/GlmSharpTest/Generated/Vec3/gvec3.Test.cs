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
    public class TVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new gvec3<string>("((-1-1)5)");
                Assert.AreEqual("((-1-1)5)", v.x);
                Assert.AreEqual("((-1-1)5)", v.y);
                Assert.AreEqual("((-1-1)5)", v.z);
            }
            {
                var v = new gvec3<string>("(0-1)", "5", "3");
                Assert.AreEqual("(0-1)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("3", v.z);
            }
            {
                var v = new gvec3<string>(new gvec2<string>("", "0"));
                Assert.AreEqual("", v.x);
                Assert.AreEqual("0", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var v = new gvec3<string>(new gvec3<string>("(-5-4)", "-4", null));
                Assert.AreEqual("(-5-4)", v.x);
                Assert.AreEqual("-4", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var v = new gvec3<string>(new gvec4<string>("((4-6)-5)", null, "(0-5)", "((2-6)1)"));
                Assert.AreEqual("((4-6)-5)", v.x);
                Assert.AreEqual(null, v.y);
                Assert.AreEqual("(0-5)", v.z);
            }
        }

    }
}
