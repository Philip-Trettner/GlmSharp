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
    public class LongVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec3(-8);
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var v = new lvec3(9, -9, 3);
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var v = new lvec3(new lvec2(-5, -7));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new lvec3(new lvec3(6, -6, -9));
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var v = new lvec3(new lvec4(0, 4, 6, -1));
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(6, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec3(-8, -8, -1);
            Assert.AreEqual(-8, v[0]);
            Assert.AreEqual(-8, v[1]);
            Assert.AreEqual(-1, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[2] = 1;
            Assert.AreEqual(1, v[2]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[2] = -2;
            Assert.AreEqual(-2, v[2]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new lvec3(-1, 1, 6);
            var vals = v.Values;
            Assert.AreEqual(-1, vals[0]);
            Assert.AreEqual(1, vals[1]);
            Assert.AreEqual(6, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, lvec3.Zero.x);
            Assert.AreEqual(0, lvec3.Zero.y);
            Assert.AreEqual(0, lvec3.Zero.z);
            
            Assert.AreEqual(1, lvec3.Ones.x);
            Assert.AreEqual(1, lvec3.Ones.y);
            Assert.AreEqual(1, lvec3.Ones.z);
            
            Assert.AreEqual(1, lvec3.UnitX.x);
            Assert.AreEqual(0, lvec3.UnitX.y);
            Assert.AreEqual(0, lvec3.UnitX.z);
            
            Assert.AreEqual(0, lvec3.UnitY.x);
            Assert.AreEqual(1, lvec3.UnitY.y);
            Assert.AreEqual(0, lvec3.UnitY.z);
            
            Assert.AreEqual(0, lvec3.UnitZ.x);
            Assert.AreEqual(0, lvec3.UnitZ.y);
            Assert.AreEqual(1, lvec3.UnitZ.z);
            
            Assert.AreEqual(long.MaxValue, lvec3.MaxValue.x);
            Assert.AreEqual(long.MaxValue, lvec3.MaxValue.y);
            Assert.AreEqual(long.MaxValue, lvec3.MaxValue.z);
            
            Assert.AreEqual(long.MinValue, lvec3.MinValue.x);
            Assert.AreEqual(long.MinValue, lvec3.MinValue.y);
            Assert.AreEqual(long.MinValue, lvec3.MinValue.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new lvec3(6, -5, 3);
            var v2 = new lvec3(6, -5, 3);
            var v3 = new lvec3(3, -5, 6);
            Assert.That(v1 == new lvec3(v1));
            Assert.That(v2 == new lvec3(v2));
            Assert.That(v3 == new lvec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new lvec3(8, 3, -7);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = lvec3.Parse(s0);
            var v1 = lvec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = lvec3.TryParse(s0, out v0);
            var b1 = lvec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = lvec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = lvec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = lvec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { lvec3.Parse(null); });
            Assert.Throws<FormatException>(() => { lvec3.Parse(""); });
            Assert.Throws<FormatException>(() => { lvec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = lvec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = lvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = lvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

    }
}
