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
    public class LongVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec4(3);
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var v = new lvec4(6, -3, 5, 4);
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var v = new lvec4(new lvec2(-7, 8));
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec3(2, -9, 8));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec4(9, 8, -6, -3));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-3, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec4(4, -5, 5, 8);
            Assert.AreEqual(4, v[0]);
            Assert.AreEqual(-5, v[1]);
            Assert.AreEqual(5, v[2]);
            Assert.AreEqual(8, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[1] = 1;
            Assert.AreEqual(1, v[1]);
            v[3] = 2;
            Assert.AreEqual(2, v[3]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[3] = 6;
            Assert.AreEqual(6, v[3]);
            v[3] = 7;
            Assert.AreEqual(7, v[3]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[2] = -4;
            Assert.AreEqual(-4, v[2]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[3] = -9;
            Assert.AreEqual(-9, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new lvec4(-7, -7, 1, -5);
            var vals = v.Values;
            Assert.AreEqual(-7, vals[0]);
            Assert.AreEqual(-7, vals[1]);
            Assert.AreEqual(1, vals[2]);
            Assert.AreEqual(-5, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, lvec4.Zero.x);
            Assert.AreEqual(0, lvec4.Zero.y);
            Assert.AreEqual(0, lvec4.Zero.z);
            Assert.AreEqual(0, lvec4.Zero.w);
            
            Assert.AreEqual(1, lvec4.Ones.x);
            Assert.AreEqual(1, lvec4.Ones.y);
            Assert.AreEqual(1, lvec4.Ones.z);
            Assert.AreEqual(1, lvec4.Ones.w);
            
            Assert.AreEqual(1, lvec4.UnitX.x);
            Assert.AreEqual(0, lvec4.UnitX.y);
            Assert.AreEqual(0, lvec4.UnitX.z);
            Assert.AreEqual(0, lvec4.UnitX.w);
            
            Assert.AreEqual(0, lvec4.UnitY.x);
            Assert.AreEqual(1, lvec4.UnitY.y);
            Assert.AreEqual(0, lvec4.UnitY.z);
            Assert.AreEqual(0, lvec4.UnitY.w);
            
            Assert.AreEqual(0, lvec4.UnitZ.x);
            Assert.AreEqual(0, lvec4.UnitZ.y);
            Assert.AreEqual(1, lvec4.UnitZ.z);
            Assert.AreEqual(0, lvec4.UnitZ.w);
            
            Assert.AreEqual(0, lvec4.UnitW.x);
            Assert.AreEqual(0, lvec4.UnitW.y);
            Assert.AreEqual(0, lvec4.UnitW.z);
            Assert.AreEqual(1, lvec4.UnitW.w);
            
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.x);
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.y);
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.z);
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.w);
            
            Assert.AreEqual(long.MinValue, lvec4.MinValue.x);
            Assert.AreEqual(long.MinValue, lvec4.MinValue.y);
            Assert.AreEqual(long.MinValue, lvec4.MinValue.z);
            Assert.AreEqual(long.MinValue, lvec4.MinValue.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new lvec4(1, -8, 9, 5);
            var v2 = new lvec4(1, -8, 9, 5);
            var v3 = new lvec4(5, 9, -8, 1);
            Assert.That(v1 == new lvec4(v1));
            Assert.That(v2 == new lvec4(v2));
            Assert.That(v3 == new lvec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new lvec4(-5, 3, 7, 6);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = lvec4.Parse(s0);
            var v1 = lvec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = lvec4.TryParse(s0, out v0);
            var b1 = lvec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = lvec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = lvec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = lvec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { lvec4.Parse(null); });
            Assert.Throws<FormatException>(() => { lvec4.Parse(""); });
            Assert.Throws<FormatException>(() => { lvec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = lvec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = lvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = lvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new lvec4(-6, 1, -1, -7);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<lvec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
