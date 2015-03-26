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

namespace GlmSharpTest.Generated.Vec3
{
    [TestFixture]
    public class TVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new gvec3<string>("((-4-3)-9)");
                Assert.AreEqual("((-4-3)-9)", v.x);
                Assert.AreEqual("((-4-3)-9)", v.y);
                Assert.AreEqual("((-4-3)-9)", v.z);
            }
            {
                var v = new gvec3<string>("0", "-7", "((81)6)");
                Assert.AreEqual("0", v.x);
                Assert.AreEqual("-7", v.y);
                Assert.AreEqual("((81)6)", v.z);
            }
            {
                var v = new gvec3<string>(new gvec2<string>("((10)-4)", "(3-4)"));
                Assert.AreEqual("((10)-4)", v.x);
                Assert.AreEqual("(3-4)", v.y);
                Assert.AreEqual(null, v.z);
            }
            {
                var v = new gvec3<string>(new gvec3<string>("((5-2)5)", "((54)-9)", "-1"));
                Assert.AreEqual("((5-2)5)", v.x);
                Assert.AreEqual("((54)-9)", v.y);
                Assert.AreEqual("-1", v.z);
            }
            {
                var v = new gvec3<string>(new gvec4<string>(null, "(83)", "-1", "(83)"));
                Assert.AreEqual(null, v.x);
                Assert.AreEqual("(83)", v.y);
                Assert.AreEqual("-1", v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new gvec3<string>("(8-7)", "-9", "((91)-3)");
            Assert.AreEqual("(8-7)", v[0]);
            Assert.AreEqual("-9", v[1]);
            Assert.AreEqual("((91)-3)", v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = null; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = null; } );
            
            v[0] = null;
            Assert.AreEqual(null, v[0]);
            v[2] = "";
            Assert.AreEqual("", v[2]);
            v[2] = "9";
            Assert.AreEqual("9", v[2]);
            v[2] = "(-57)";
            Assert.AreEqual("(-57)", v[2]);
            v[2] = "((2-4)2)";
            Assert.AreEqual("((2-4)2)", v[2]);
            v[1] = "2";
            Assert.AreEqual("2", v[1]);
            v[0] = "(-6-2)";
            Assert.AreEqual("(-6-2)", v[0]);
            v[0] = "((-8-2)0)";
            Assert.AreEqual("((-8-2)0)", v[0]);
            v[1] = "0";
            Assert.AreEqual("0", v[1]);
            v[2] = "(09)";
            Assert.AreEqual("(09)", v[2]);
            v[2] = "((-77)-6)";
            Assert.AreEqual("((-77)-6)", v[2]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new gvec3<string>("(72)", "-3", "((-22)5)");
            var vals = v.Values;
            Assert.AreEqual("(72)", vals[0]);
            Assert.AreEqual("-3", vals[1]);
            Assert.AreEqual("((-22)5)", vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(null, gvec3<string>.Zero.x);
            Assert.AreEqual(null, gvec3<string>.Zero.y);
            Assert.AreEqual(null, gvec3<string>.Zero.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new gvec3<string>("((-9-6)2)", "(-94)", "((-4-1)-4)");
            var v2 = new gvec3<string>("((-9-6)2)", "(-94)", "((-4-1)-4)");
            var v3 = new gvec3<string>("((-4-1)-4)", "(-94)", "((-9-6)2)");
            Assert.That(v1 == new gvec3<string>(v1));
            Assert.That(v2 == new gvec3<string>(v2));
            Assert.That(v3 == new gvec3<string>(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new gvec3<string>("-8", "(60)", "");
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new gvec3<string>("((94)9)", "-5", "-5");
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<gvec3<string>>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
