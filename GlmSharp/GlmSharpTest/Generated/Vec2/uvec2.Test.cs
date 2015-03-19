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
    public class UintVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uvec2(1u);
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var v = new uvec2(5, 2);
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var v = new uvec2(new uvec2(3, 3));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
            }
            {
                var v = new uvec2(new uvec3(9, 6, 6));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(6, v.y);
            }
            {
                var v = new uvec2(new uvec4(2, 3, 8, 7));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(3, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec2(2, 9);
            Assert.AreEqual(2, v[0]);
            Assert.AreEqual(9, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[1] = 0u;
            Assert.AreEqual(0u, v[1]);
            v[1] = 1u;
            Assert.AreEqual(1u, v[1]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[1] = 3;
            Assert.AreEqual(3, v[1]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uvec2(8, 0u);
            var vals = v.Values;
            Assert.AreEqual(8, vals[0]);
            Assert.AreEqual(0u, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uvec2.Zero.x);
            Assert.AreEqual(0u, uvec2.Zero.y);
            
            Assert.AreEqual(1u, uvec2.Ones.x);
            Assert.AreEqual(1u, uvec2.Ones.y);
            
            Assert.AreEqual(1u, uvec2.UnitX.x);
            Assert.AreEqual(0u, uvec2.UnitX.y);
            
            Assert.AreEqual(0u, uvec2.UnitY.x);
            Assert.AreEqual(1u, uvec2.UnitY.y);
            
            Assert.AreEqual(uint.MaxValue, uvec2.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uvec2.MaxValue.y);
            
            Assert.AreEqual(uint.MinValue, uvec2.MinValue.x);
            Assert.AreEqual(uint.MinValue, uvec2.MinValue.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uvec2(0u, 7);
            var v2 = new uvec2(0u, 7);
            var v3 = new uvec2(7, 0u);
            Assert.That(v1 == new uvec2(v1));
            Assert.That(v2 == new uvec2(v2));
            Assert.That(v3 == new uvec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new uvec2(7, 0u);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = uvec2.Parse(s0);
            var v1 = uvec2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = uvec2.TryParse(s0, out v0);
            var b1 = uvec2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = uvec2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = uvec2.TryParse("", out v0);
            Assert.False(b0);
            b0 = uvec2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { uvec2.Parse(null); });
            Assert.Throws<FormatException>(() => { uvec2.Parse(""); });
            Assert.Throws<FormatException>(() => { uvec2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = uvec2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = uvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = uvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

    }
}
