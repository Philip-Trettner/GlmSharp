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
    public class TVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new gvec4<string>("((-48)-2)");
                Assert.AreEqual("((-48)-2)", v.x);
                Assert.AreEqual("((-48)-2)", v.y);
                Assert.AreEqual("((-48)-2)", v.z);
                Assert.AreEqual("((-48)-2)", v.w);
            }
            {
                var v = new gvec4<string>("(-40)", "", "", "((-59)3)");
                Assert.AreEqual("(-40)", v.x);
                Assert.AreEqual("", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual("((-59)3)", v.w);
            }
            {
                var v = new gvec4<string>(new gvec2<string>("(89)", "(89)"));
                Assert.AreEqual("(89)", v.x);
                Assert.AreEqual("(89)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var v = new gvec4<string>(new gvec3<string>("((8-3)-4)", "5", "(-4-5)"));
                Assert.AreEqual("((8-3)-4)", v.x);
                Assert.AreEqual("5", v.y);
                Assert.AreEqual("(-4-5)", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var v = new gvec4<string>(new gvec4<string>(null, "((-41)5)", "2", "(-24)"));
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("((-41)5)", v.y);
                Assert.AreEqual("2", v.z);
                Assert.AreEqual("(-24)", v.w);
            }
        }

    }
}
