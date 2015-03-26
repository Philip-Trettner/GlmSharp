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
                var v = new bvec2(new bvec2(false, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var v = new bvec2(new bvec3(false, false, true));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var v = new bvec2(new bvec4(true, false, false, true));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new bvec2(false, true);
            Assert.AreEqual(false, v[0]);
            Assert.AreEqual(true, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = false; } );
            
            v[1] = false;
            Assert.AreEqual(false, v[1]);
            v[1] = true;
            Assert.AreEqual(true, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new bvec2(true, false);
            var vals = v.Values;
            Assert.AreEqual(true, vals[0]);
            Assert.AreEqual(false, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(false, bvec2.Zero.x);
            Assert.AreEqual(false, bvec2.Zero.y);
            
            Assert.AreEqual(true, bvec2.Ones.x);
            Assert.AreEqual(true, bvec2.Ones.y);
            
            Assert.AreEqual(true, bvec2.UnitX.x);
            Assert.AreEqual(false, bvec2.UnitX.y);
            
            Assert.AreEqual(false, bvec2.UnitY.x);
            Assert.AreEqual(true, bvec2.UnitY.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new bvec2(false, true);
            var v2 = new bvec2(false, true);
            var v3 = new bvec2(true, false);
            Assert.That(v1 == new bvec2(v1));
            Assert.That(v2 == new bvec2(v2));
            Assert.That(v3 == new bvec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new bvec2(true, false);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = bvec2.Parse(s0);
            var v1 = bvec2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = bvec2.TryParse(s0, out v0);
            var b1 = bvec2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = bvec2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = bvec2.TryParse("", out v0);
            Assert.False(b0);
            b0 = bvec2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { bvec2.Parse(null); });
            Assert.Throws<FormatException>(() => { bvec2.Parse(""); });
            Assert.Throws<FormatException>(() => { bvec2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new bvec2(true, false);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<bvec2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
