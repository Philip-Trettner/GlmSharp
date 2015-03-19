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
                var v = new uvec4(0u);
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uvec4(2, 5, 2, 0u);
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uvec4(new uvec2(2, 4));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uvec4(new uvec3(5, 4, 1u));
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uvec4(new uvec4(2, 3, 9, 6));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(6, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec4(4, 4, 8, 8);
            Assert.AreEqual(4, v[0]);
            Assert.AreEqual(4, v[1]);
            Assert.AreEqual(8, v[2]);
            Assert.AreEqual(8, v[3]);
            
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
            v[1] = 1u;
            Assert.AreEqual(1u, v[1]);
            v[2] = 2;
            Assert.AreEqual(2, v[2]);
            v[3] = 3;
            Assert.AreEqual(3, v[3]);
            v[3] = 4;
            Assert.AreEqual(4, v[3]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
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
