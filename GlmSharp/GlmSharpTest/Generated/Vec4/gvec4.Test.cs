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
                var v = new gvec4<string>("((-35)-9)");
                Assert.AreEqual("((-35)-9)", v.x);
                Assert.AreEqual("((-35)-9)", v.y);
                Assert.AreEqual("((-35)-9)", v.z);
                Assert.AreEqual("((-35)-9)", v.w);
            }
            {
                var v = new gvec4<string>("((8-6)3)", "(56)", "(1-1)", "(1-1)");
                Assert.AreEqual("((8-6)3)", v.x);
                Assert.AreEqual("(56)", v.y);
                Assert.AreEqual("(1-1)", v.z);
                Assert.AreEqual("(1-1)", v.w);
            }
            {
                var v = new gvec4<string>(new gvec2<string>("-2", "(-14)"));
                Assert.AreEqual("-2", v.x);
                Assert.AreEqual("(-14)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var v = new gvec4<string>(new gvec3<string>("((-4-7)-6)", "(-4-3)", "-4"));
                Assert.AreEqual("((-4-7)-6)", v.x);
                Assert.AreEqual("(-4-3)", v.y);
                Assert.AreEqual("-4", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var v = new gvec4<string>(new gvec4<string>("(-7-3)", "((28)-8)", "-1", "(-3-9)"));
                Assert.AreEqual("(-7-3)", v.x);
                Assert.AreEqual("((28)-8)", v.y);
                Assert.AreEqual("-1", v.z);
                Assert.AreEqual("(-3-9)", v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new gvec4<string>("8", "8", "((16)-8)", "2");
            Assert.AreEqual("8", v[0]);
            Assert.AreEqual("8", v[1]);
            Assert.AreEqual("((16)-8)", v[2]);
            Assert.AreEqual("2", v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = null; } );
            
            v[3] = null;
            Assert.AreEqual(null, v[3]);
            v[2] = "";
            Assert.AreEqual("", v[2]);
            v[2] = "0";
            Assert.AreEqual("0", v[2]);
            v[1] = "(-9-2)";
            Assert.AreEqual("(-9-2)", v[1]);
            v[3] = "((-3-5)2)";
            Assert.AreEqual("((-3-5)2)", v[3]);
            v[3] = "3";
            Assert.AreEqual("3", v[3]);
            v[1] = "(8-6)";
            Assert.AreEqual("(8-6)", v[1]);
            v[0] = "((-1-3)-5)";
            Assert.AreEqual("((-1-3)-5)", v[0]);
            v[3] = "-4";
            Assert.AreEqual("-4", v[3]);
            v[2] = "(70)";
            Assert.AreEqual("(70)", v[2]);
            v[2] = "((7-5)0)";
            Assert.AreEqual("((7-5)0)", v[2]);
        }

    }
}
