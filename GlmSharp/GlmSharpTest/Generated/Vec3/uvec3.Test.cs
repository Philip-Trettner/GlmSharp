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
                var v = new uvec3(8);
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var v = new uvec3(1u, 7, 3);
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var v = new uvec3(new uvec2(8, 4));
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var v = new uvec3(new uvec3(5, 1u, 1u));
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
            }
            {
                var v = new uvec3(new uvec4(0u, 5, 4, 8));
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(4, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec3(6, 5, 9);
            Assert.AreEqual(6, v[0]);
            Assert.AreEqual(5, v[1]);
            Assert.AreEqual(9, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = v[5]; } );
            
            v[0] = 0u;
            Assert.AreEqual(0u, v[0]);
            v[0] = 1u;
            Assert.AreEqual(1u, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[2] = 6;
            Assert.AreEqual(6, v[2]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
        }

    }
}
