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
    public class BoolVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new bvec4(true);
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var v = new bvec4(true, false, true, false);
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var v = new bvec4(new bvec2(false, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var v = new bvec4(new bvec3(true, true, false));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var v = new bvec4(new bvec4(true, false, false, true));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new bvec4(true, false, true, true);
            Assert.AreEqual(true, v[0]);
            Assert.AreEqual(false, v[1]);
            Assert.AreEqual(true, v[2]);
            Assert.AreEqual(true, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = false; } );
            
            v[3] = false;
            Assert.AreEqual(false, v[3]);
            v[3] = true;
            Assert.AreEqual(true, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new bvec4(true, false, true, false);
            var vals = v.Values;
            Assert.AreEqual(true, vals[0]);
            Assert.AreEqual(false, vals[1]);
            Assert.AreEqual(true, vals[2]);
            Assert.AreEqual(false, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(false, bvec4.Zero.x);
            Assert.AreEqual(false, bvec4.Zero.y);
            Assert.AreEqual(false, bvec4.Zero.z);
            Assert.AreEqual(false, bvec4.Zero.w);
            
            Assert.AreEqual(true, bvec4.Ones.x);
            Assert.AreEqual(true, bvec4.Ones.y);
            Assert.AreEqual(true, bvec4.Ones.z);
            Assert.AreEqual(true, bvec4.Ones.w);
            
            Assert.AreEqual(true, bvec4.UnitX.x);
            Assert.AreEqual(false, bvec4.UnitX.y);
            Assert.AreEqual(false, bvec4.UnitX.z);
            Assert.AreEqual(false, bvec4.UnitX.w);
            
            Assert.AreEqual(false, bvec4.UnitY.x);
            Assert.AreEqual(true, bvec4.UnitY.y);
            Assert.AreEqual(false, bvec4.UnitY.z);
            Assert.AreEqual(false, bvec4.UnitY.w);
            
            Assert.AreEqual(false, bvec4.UnitZ.x);
            Assert.AreEqual(false, bvec4.UnitZ.y);
            Assert.AreEqual(true, bvec4.UnitZ.z);
            Assert.AreEqual(false, bvec4.UnitZ.w);
            
            Assert.AreEqual(false, bvec4.UnitW.x);
            Assert.AreEqual(false, bvec4.UnitW.y);
            Assert.AreEqual(false, bvec4.UnitW.z);
            Assert.AreEqual(true, bvec4.UnitW.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new bvec4(false, false, true, false);
            var v2 = new bvec4(false, false, true, false);
            var v3 = new bvec4(false, true, false, false);
            Assert.That(v1 == new bvec4(v1));
            Assert.That(v2 == new bvec4(v2));
            Assert.That(v3 == new bvec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new bvec4(false, true, true, false);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = bvec4.Parse(s0);
            var v1 = bvec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = bvec4.TryParse(s0, out v0);
            var b1 = bvec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = bvec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = bvec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = bvec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { bvec4.Parse(null); });
            Assert.Throws<FormatException>(() => { bvec4.Parse(""); });
            Assert.Throws<FormatException>(() => { bvec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new bvec4(true, true, true, false);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<bvec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
