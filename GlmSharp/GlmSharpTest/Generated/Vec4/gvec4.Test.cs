using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
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
                var v = new gvec4<string>("(0-2)");
                Assert.AreEqual("(0-2)", v.x);
                Assert.AreEqual("(0-2)", v.y);
                Assert.AreEqual("(0-2)", v.z);
                Assert.AreEqual("(0-2)", v.w);
            }
            {
                var v = new gvec4<string>("(2-8)", "((3-4)7)", "-3", null);
                Assert.AreEqual("(2-8)", v.x);
                Assert.AreEqual("((3-4)7)", v.y);
                Assert.AreEqual("-3", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var v = new gvec4<string>(new gvec2<string>(null, "(-1-8)"));
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(-1-8)", v.y);
                Assert.AreEqual(null, v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var v = new gvec4<string>(new gvec3<string>("((-18)5)", "(2-3)", ""));
                Assert.AreEqual("((-18)5)", v.x);
                Assert.AreEqual("(2-3)", v.y);
                Assert.AreEqual("", v.z);
                Assert.AreEqual(null, v.w);
            }
            {
                var v = new gvec4<string>(new gvec4<string>("((8-7)7)", "((8-7)7)", "-9", "-9"));
                Assert.AreEqual("((8-7)7)", v.x);
                Assert.AreEqual("((8-7)7)", v.y);
                Assert.AreEqual("-9", v.z);
                Assert.AreEqual("-9", v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new gvec4<string>("((-4-2)-2)", "((2-2)6)", "(-3-8)", "");
            Assert.AreEqual("((-4-2)-2)", v[0]);
            Assert.AreEqual("((2-2)6)", v[1]);
            Assert.AreEqual("(-3-8)", v[2]);
            Assert.AreEqual("", v[3]);
            
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
            
            v[0] = null;
            Assert.AreEqual(null, v[0]);
            v[2] = "";
            Assert.AreEqual("", v[2]);
            v[3] = "-9";
            Assert.AreEqual("-9", v[3]);
            v[0] = "(4-4)";
            Assert.AreEqual("(4-4)", v[0]);
            v[2] = "((7-8)-9)";
            Assert.AreEqual("((7-8)-9)", v[2]);
            v[3] = "5";
            Assert.AreEqual("5", v[3]);
            v[3] = "(-10)";
            Assert.AreEqual("(-10)", v[3]);
            v[2] = "((-48)0)";
            Assert.AreEqual("((-48)0)", v[2]);
            v[2] = "4";
            Assert.AreEqual("4", v[2]);
            v[1] = "(-12)";
            Assert.AreEqual("(-12)", v[1]);
            v[3] = "((-7-8)8)";
            Assert.AreEqual("((-7-8)8)", v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new gvec4<string>("5", "(-2-9)", "(-5-4)", null);
            var vals = v.Values;
            Assert.AreEqual("5", vals[0]);
            Assert.AreEqual("(-2-9)", vals[1]);
            Assert.AreEqual("(-5-4)", vals[2]);
            Assert.AreEqual(null, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(null, gvec4<string>.Zero.x);
            Assert.AreEqual(null, gvec4<string>.Zero.y);
            Assert.AreEqual(null, gvec4<string>.Zero.z);
            Assert.AreEqual(null, gvec4<string>.Zero.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new gvec4<string>("((2-9)-2)", "-5", "((2-9)-2)", "(-2-4)");
            var v2 = new gvec4<string>("((2-9)-2)", "-5", "((2-9)-2)", "(-2-4)");
            var v3 = new gvec4<string>("(-2-4)", "((2-9)-2)", "-5", "((2-9)-2)");
            Assert.That(v1 == new gvec4<string>(v1));
            Assert.That(v2 == new gvec4<string>(v2));
            Assert.That(v3 == new gvec4<string>(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new gvec4<string>("5", "((75)9)", "-9", "5");
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new gvec4<string>("-1", "(-90)", "", "((5-6)-9)");
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<gvec4<string>>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
