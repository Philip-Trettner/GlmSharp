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
    public class UintVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uvec3(9);
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var v = new uvec3(6, 5, 2);
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var v = new uvec3(new uvec2(8, 9));
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var v = new uvec3(new uvec3(6, 3, 2));
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var v = new uvec3(new uvec4(8, 5, 6, 4));
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(6, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec3(9, 1u, 1u);
            Assert.AreEqual(9, v[0]);
            Assert.AreEqual(1u, v[1]);
            Assert.AreEqual(1u, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[1] = 0u;
            Assert.AreEqual(0u, v[1]);
            v[0] = 1u;
            Assert.AreEqual(1u, v[0]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uvec3(5, 2, 9);
            var vals = v.Values;
            Assert.AreEqual(5, vals[0]);
            Assert.AreEqual(2, vals[1]);
            Assert.AreEqual(9, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uvec3.Zero.x);
            Assert.AreEqual(0u, uvec3.Zero.y);
            Assert.AreEqual(0u, uvec3.Zero.z);
            
            Assert.AreEqual(1u, uvec3.Ones.x);
            Assert.AreEqual(1u, uvec3.Ones.y);
            Assert.AreEqual(1u, uvec3.Ones.z);
            
            Assert.AreEqual(1u, uvec3.UnitX.x);
            Assert.AreEqual(0u, uvec3.UnitX.y);
            Assert.AreEqual(0u, uvec3.UnitX.z);
            
            Assert.AreEqual(0u, uvec3.UnitY.x);
            Assert.AreEqual(1u, uvec3.UnitY.y);
            Assert.AreEqual(0u, uvec3.UnitY.z);
            
            Assert.AreEqual(0u, uvec3.UnitZ.x);
            Assert.AreEqual(0u, uvec3.UnitZ.y);
            Assert.AreEqual(1u, uvec3.UnitZ.z);
            
            Assert.AreEqual(uint.MaxValue, uvec3.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uvec3.MaxValue.y);
            Assert.AreEqual(uint.MaxValue, uvec3.MaxValue.z);
            
            Assert.AreEqual(uint.MinValue, uvec3.MinValue.x);
            Assert.AreEqual(uint.MinValue, uvec3.MinValue.y);
            Assert.AreEqual(uint.MinValue, uvec3.MinValue.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uvec3(3, 5, 6);
            var v2 = new uvec3(3, 5, 6);
            var v3 = new uvec3(6, 5, 3);
            Assert.That(v1 == new uvec3(v1));
            Assert.That(v2 == new uvec3(v2));
            Assert.That(v3 == new uvec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

    }
}
