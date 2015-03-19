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
                var v = new uvec2(2);
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var v = new uvec2(8, 5);
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var v = new uvec2(new uvec2(4, 0u));
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(0u, v.y);
            }
            {
                var v = new uvec2(new uvec3(5, 5, 6));
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
            }
            {
                var v = new uvec2(new uvec4(0u, 1u, 7, 4));
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(1u, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec2(7, 7);
            Assert.AreEqual(7, v[0]);
            Assert.AreEqual(7, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = v[5]; } );
            
            v[1] = 0u;
            Assert.AreEqual(0u, v[1]);
            v[0] = 1u;
            Assert.AreEqual(1u, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[1] = 3;
            Assert.AreEqual(3, v[1]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
        }

    }
}
