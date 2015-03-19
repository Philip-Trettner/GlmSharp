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
    public class TVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new gvec2<string>("-2");
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("-2", v.y);
            }
            {
                var v = new gvec2<string>("((-5-8)5)", "4");
                Assert.AreEqual("((-5-8)5)", v.x);
                Assert.AreEqual("4", v.y);
            }
            {
                var v = new gvec2<string>(new gvec2<string>("(-4-9)", "7"));
                Assert.AreEqual("(-4-9)", v.x);
                Assert.AreEqual("7", v.y);
            }
            {
                var v = new gvec2<string>(new gvec3<string>("-9", "((-53)-2)", "((-53)-2)"));
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("((-53)-2)", v.y);
            }
            {
                var v = new gvec2<string>(new gvec4<string>("((-18)5)", "(-33)", "((0-6)5)", null));
                Assert.AreEqual("((-18)5)", v.x);
                Assert.AreEqual("(-33)", v.y);
            }
        }

    }
}
