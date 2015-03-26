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

namespace GlmSharpTest.Generated.Vec2
{
    [TestFixture]
    public class TVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new gvec2<string>("");
                Assert.AreEqual("", v.x);
                Assert.AreEqual("", v.y);
            }
            {
                var v = new gvec2<string>("", "0");
                Assert.AreEqual("", v.x);
                Assert.AreEqual("0", v.y);
            }
            {
                var v = new gvec2<string>(new gvec2<string>(null, null));
                Assert.AreEqual(null, v.x);
                Assert.AreEqual(null, v.y);
            }
            {
                var v = new gvec2<string>(new gvec3<string>("4", "((-8-5)7)", "4"));
                Assert.AreEqual("4", v.x);
                Assert.AreEqual("((-8-5)7)", v.y);
            }
            {
                var v = new gvec2<string>(new gvec4<string>("-1", "(73)", "(73)", "2"));
                Assert.AreEqual("-1", v.x);
                Assert.AreEqual("(73)", v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new gvec2<string>("", "5");
            Assert.AreEqual("", v[0]);
            Assert.AreEqual("5", v[1]);
            
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
            v[0] = "-9";
            Assert.AreEqual("-9", v[0]);
            v[0] = "(-9-4)";
            Assert.AreEqual("(-9-4)", v[0]);
            v[1] = "((-8-3)-3)";
            Assert.AreEqual("((-8-3)-3)", v[1]);
            v[1] = "1";
            Assert.AreEqual("1", v[1]);
            v[1] = "(3-3)";
            Assert.AreEqual("(3-3)", v[1]);
            v[1] = "((-50)-8)";
            Assert.AreEqual("((-50)-8)", v[1]);
            v[1] = "-8";
            Assert.AreEqual("-8", v[1]);
            v[1] = "(49)";
            Assert.AreEqual("(49)", v[1]);
            v[1] = "((-97)-8)";
            Assert.AreEqual("((-97)-8)", v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new gvec2<string>("((-18)-7)", "-9");
            var vals = v.Values;
            Assert.AreEqual("((-18)-7)", vals[0]);
            Assert.AreEqual("-9", vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(null, gvec2<string>.Zero.x);
            Assert.AreEqual(null, gvec2<string>.Zero.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new gvec2<string>("3", "(1-8)");
            var v2 = new gvec2<string>("3", "(1-8)");
            var v3 = new gvec2<string>("(1-8)", "3");
            Assert.That(v1 == new gvec2<string>(v1));
            Assert.That(v2 == new gvec2<string>(v2));
            Assert.That(v3 == new gvec2<string>(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new gvec2<string>("((69)8)", "(-63)");
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new gvec2<string>("(-30)", "-7");
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<gvec2<string>>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
