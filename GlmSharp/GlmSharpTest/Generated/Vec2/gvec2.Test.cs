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
                var v = new gvec2<string>("(7-2)");
                Assert.AreEqual("(7-2)", v.x);
                Assert.AreEqual("(7-2)", v.y);
            }
            {
                var v = new gvec2<string>("((4-4)9)", "");
                Assert.AreEqual("((4-4)9)", v.x);
                Assert.AreEqual("", v.y);
            }
            {
                var v = new gvec2<string>(new gvec2<string>("-6", "(-5-3)"));
                Assert.AreEqual("-6", v.x);
                Assert.AreEqual("(-5-3)", v.y);
            }
            {
                var v = new gvec2<string>(new gvec3<string>("-3", "((-4-8)1)", "(8-9)"));
                Assert.AreEqual("-3", v.x);
                Assert.AreEqual("((-4-8)1)", v.y);
            }
            {
                var v = new gvec2<string>(new gvec4<string>("-5", null, "(9-4)", "((07)0)"));
                Assert.AreEqual("-5", v.x);
                Assert.AreEqual(null, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new gvec2<string>("", "-5");
            Assert.AreEqual("", v[0]);
            Assert.AreEqual("-5", v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = null; } );
            
            v[0] = null;
            Assert.AreEqual(null, v[0]);
            v[1] = "";
            Assert.AreEqual("", v[1]);
            v[0] = "9";
            Assert.AreEqual("9", v[0]);
            v[0] = "(2-9)";
            Assert.AreEqual("(2-9)", v[0]);
            v[0] = "((-2-8)4)";
            Assert.AreEqual("((-2-8)4)", v[0]);
            v[0] = "-3";
            Assert.AreEqual("-3", v[0]);
            v[0] = "(99)";
            Assert.AreEqual("(99)", v[0]);
            v[0] = "((-26)5)";
            Assert.AreEqual("((-26)5)", v[0]);
            v[1] = "-5";
            Assert.AreEqual("-5", v[1]);
            v[1] = "(4-9)";
            Assert.AreEqual("(4-9)", v[1]);
            v[1] = "((-51)0)";
            Assert.AreEqual("((-51)0)", v[1]);
        }

    }
}
