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
    public class IntVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec3(-9);
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var v = new ivec3(7, -5, 9);
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-5, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var v = new ivec3(new ivec2(-4, -8));
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new ivec3(new ivec3(-2, -3, 8));
                Assert.AreEqual(-2, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(8, v.z);
            }
            {
                var v = new ivec3(new ivec4(9, 8, -1, -9));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-1, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new ivec3(2, 4, 8);
            Assert.AreEqual(2, v[0]);
            Assert.AreEqual(4, v[1]);
            Assert.AreEqual(8, v[2]);
            
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
            
            v[0] = 0;
            Assert.AreEqual(0, v[0]);
            v[1] = 1;
            Assert.AreEqual(1, v[1]);
            v[2] = 2;
            Assert.AreEqual(2, v[2]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[2] = -2;
            Assert.AreEqual(-2, v[2]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[0] = -5;
            Assert.AreEqual(-5, v[0]);
            v[1] = -6;
            Assert.AreEqual(-6, v[1]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[0] = -9;
            Assert.AreEqual(-9, v[0]);
        }

    }
}
