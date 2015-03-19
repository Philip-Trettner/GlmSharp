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
                var v = new gvec3<string>("-9");
                Assert.AreEqual("-9", v.x);
                Assert.AreEqual("-9", v.y);
                Assert.AreEqual("-9", v.z);
            }
            {
                var v = new gvec3<string>("(-7-8)", "((-7-2)-6)", "((88)9)");
                Assert.AreEqual("(-7-8)", v.x);
                Assert.AreEqual("((-7-2)-6)", v.y);
                Assert.AreEqual("((88)9)", v.z);
            }
            {
                var v = new gvec3<string>(new gvec2<string>("(02)", "(25)"));
                Assert.AreEqual("(02)", v.x);
                Assert.AreEqual("(25)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var v = new gvec3<string>(new gvec3<string>("(3-8)", "((-6-5)2)", "(-1-3)"));
                Assert.AreEqual("(3-8)", v.x);
                Assert.AreEqual("((-6-5)2)", v.y);
                Assert.AreEqual("(-1-3)", v.z);
            }
            {
                var v = new gvec3<string>(new gvec4<string>("", "-6", "(-3-7)", "9"));
                Assert.AreEqual("", v.x);
                Assert.AreEqual("-6", v.y);
                Assert.AreEqual("(-3-7)", v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new gvec3<string>("(-14)", "-2", null);
            Assert.AreEqual("(-14)", v[0]);
            Assert.AreEqual("-2", v[1]);
            Assert.AreEqual(null, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = v[5]; } );
            
            v[0] = null;
            Assert.AreEqual(null, v[0]);
            v[2] = "";
            Assert.AreEqual("", v[2]);
            v[2] = "1";
            Assert.AreEqual("1", v[2]);
            v[1] = "(-7-5)";
            Assert.AreEqual("(-7-5)", v[1]);
            v[0] = "((-5-4)8)";
            Assert.AreEqual("((-5-4)8)", v[0]);
            v[0] = "1";
            Assert.AreEqual("1", v[0]);
            v[2] = "(-88)";
            Assert.AreEqual("(-88)", v[2]);
            v[0] = "((-1-3)-2)";
            Assert.AreEqual("((-1-3)-2)", v[0]);
            v[2] = "-2";
            Assert.AreEqual("-2", v[2]);
            v[0] = "(0-4)";
            Assert.AreEqual("(0-4)", v[0]);
            v[2] = "((47)-3)";
            Assert.AreEqual("((47)-3)", v[2]);
        }

    }
}
