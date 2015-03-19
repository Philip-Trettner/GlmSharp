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
    public class IntVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec2(-4);
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
            }
            {
                var v = new ivec2(-8, 8);
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(8, v.y);
            }
            {
                var v = new ivec2(new ivec2(7, -3));
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-3, v.y);
            }
            {
                var v = new ivec2(new ivec3(-4, 0, -8));
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(0, v.y);
            }
            {
                var v = new ivec2(new ivec4(0, 1, 7, 9));
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(1, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new ivec2(-4, 7);
            Assert.AreEqual(-4, v[0]);
            Assert.AreEqual(7, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[0] = 0;
            Assert.AreEqual(0, v[0]);
            v[1] = 1;
            Assert.AreEqual(1, v[1]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[1] = -1;
            Assert.AreEqual(-1, v[1]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[0] = -5;
            Assert.AreEqual(-5, v[0]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[0] = -8;
            Assert.AreEqual(-8, v[0]);
            v[0] = -9;
            Assert.AreEqual(-9, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new ivec2(6, 9);
            var vals = v.Values;
            Assert.AreEqual(6, vals[0]);
            Assert.AreEqual(9, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, ivec2.Zero.x);
            Assert.AreEqual(0, ivec2.Zero.y);
            
            Assert.AreEqual(1, ivec2.Ones.x);
            Assert.AreEqual(1, ivec2.Ones.y);
            
            Assert.AreEqual(1, ivec2.UnitX.x);
            Assert.AreEqual(0, ivec2.UnitX.y);
            
            Assert.AreEqual(0, ivec2.UnitY.x);
            Assert.AreEqual(1, ivec2.UnitY.y);
            
            Assert.AreEqual(int.MaxValue, ivec2.MaxValue.x);
            Assert.AreEqual(int.MaxValue, ivec2.MaxValue.y);
            
            Assert.AreEqual(int.MinValue, ivec2.MinValue.x);
            Assert.AreEqual(int.MinValue, ivec2.MinValue.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new ivec2(-1, 5);
            var v2 = new ivec2(-1, 5);
            var v3 = new ivec2(5, -1);
            Assert.That(v1 == new ivec2(v1));
            Assert.That(v2 == new ivec2(v2));
            Assert.That(v3 == new ivec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new ivec2(4, -3);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = ivec2.Parse(s0);
            var v1 = ivec2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = ivec2.TryParse(s0, out v0);
            var b1 = ivec2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = ivec2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = ivec2.TryParse("", out v0);
            Assert.False(b0);
            b0 = ivec2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { ivec2.Parse(null); });
            Assert.Throws<FormatException>(() => { ivec2.Parse(""); });
            Assert.Throws<FormatException>(() => { ivec2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = ivec2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = ivec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = ivec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

    }
}
