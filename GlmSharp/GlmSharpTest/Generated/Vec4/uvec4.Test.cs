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

namespace GlmSharpTest.Generated.Vec4
{
    [TestFixture]
    public class UintVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uvec4(1u);
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var v = new uvec4(0u, 2, 0u, 8);
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var v = new uvec4(new uvec2(1u, 5));
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uvec4(new uvec3(0u, 0u, 1u));
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uvec4(new uvec4(2, 6, 2, 1u));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(1u, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec4(2, 4, 8, 2);
            Assert.AreEqual(2, v[0]);
            Assert.AreEqual(4, v[1]);
            Assert.AreEqual(8, v[2]);
            Assert.AreEqual(2, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[3] = 0u;
            Assert.AreEqual(0u, v[3]);
            v[2] = 1u;
            Assert.AreEqual(1u, v[2]);
            v[3] = 2;
            Assert.AreEqual(2, v[3]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[2] = 6;
            Assert.AreEqual(6, v[2]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[3] = 9;
            Assert.AreEqual(9, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uvec4(8, 5, 6, 5);
            var vals = v.Values;
            Assert.AreEqual(8, vals[0]);
            Assert.AreEqual(5, vals[1]);
            Assert.AreEqual(6, vals[2]);
            Assert.AreEqual(5, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uvec4.Zero.x);
            Assert.AreEqual(0u, uvec4.Zero.y);
            Assert.AreEqual(0u, uvec4.Zero.z);
            Assert.AreEqual(0u, uvec4.Zero.w);
            
            Assert.AreEqual(1u, uvec4.Ones.x);
            Assert.AreEqual(1u, uvec4.Ones.y);
            Assert.AreEqual(1u, uvec4.Ones.z);
            Assert.AreEqual(1u, uvec4.Ones.w);
            
            Assert.AreEqual(1u, uvec4.UnitX.x);
            Assert.AreEqual(0u, uvec4.UnitX.y);
            Assert.AreEqual(0u, uvec4.UnitX.z);
            Assert.AreEqual(0u, uvec4.UnitX.w);
            
            Assert.AreEqual(0u, uvec4.UnitY.x);
            Assert.AreEqual(1u, uvec4.UnitY.y);
            Assert.AreEqual(0u, uvec4.UnitY.z);
            Assert.AreEqual(0u, uvec4.UnitY.w);
            
            Assert.AreEqual(0u, uvec4.UnitZ.x);
            Assert.AreEqual(0u, uvec4.UnitZ.y);
            Assert.AreEqual(1u, uvec4.UnitZ.z);
            Assert.AreEqual(0u, uvec4.UnitZ.w);
            
            Assert.AreEqual(0u, uvec4.UnitW.x);
            Assert.AreEqual(0u, uvec4.UnitW.y);
            Assert.AreEqual(0u, uvec4.UnitW.z);
            Assert.AreEqual(1u, uvec4.UnitW.w);
            
            Assert.AreEqual(uint.MaxValue, uvec4.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uvec4.MaxValue.y);
            Assert.AreEqual(uint.MaxValue, uvec4.MaxValue.z);
            Assert.AreEqual(uint.MaxValue, uvec4.MaxValue.w);
            
            Assert.AreEqual(uint.MinValue, uvec4.MinValue.x);
            Assert.AreEqual(uint.MinValue, uvec4.MinValue.y);
            Assert.AreEqual(uint.MinValue, uvec4.MinValue.z);
            Assert.AreEqual(uint.MinValue, uvec4.MinValue.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uvec4(0u, 2, 9, 5);
            var v2 = new uvec4(0u, 2, 9, 5);
            var v3 = new uvec4(5, 9, 2, 0u);
            Assert.That(v1 == new uvec4(v1));
            Assert.That(v2 == new uvec4(v2));
            Assert.That(v3 == new uvec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new uvec4(7, 7, 0u, 9);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = uvec4.Parse(s0);
            var v1 = uvec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = uvec4.TryParse(s0, out v0);
            var b1 = uvec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = uvec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = uvec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = uvec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { uvec4.Parse(null); });
            Assert.Throws<FormatException>(() => { uvec4.Parse(""); });
            Assert.Throws<FormatException>(() => { uvec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = uvec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = uvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = uvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

    }
}
