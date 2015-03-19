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
                var v = new lvec3(-7);
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-7, v.z);
            }
            {
                var v = new lvec3(5, 5, 7);
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var v = new lvec3(new lvec2(-7, -1));
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new lvec3(new lvec3(-5, -3, 7));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var v = new lvec3(new lvec4(-7, -7, -6, -5));
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(-6, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec3(-9, 1, 4);
            Assert.AreEqual(-9, v[0]);
            Assert.AreEqual(1, v[1]);
            Assert.AreEqual(4, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = v[5]; } );
            
            v[0] = 0;
            Assert.AreEqual(0, v[0]);
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[1] = 3;
            Assert.AreEqual(3, v[1]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[2] = -2;
            Assert.AreEqual(-2, v[2]);
            v[2] = -3;
            Assert.AreEqual(-3, v[2]);
            v[2] = -4;
            Assert.AreEqual(-4, v[2]);
            v[2] = -5;
            Assert.AreEqual(-5, v[2]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[2] = -7;
            Assert.AreEqual(-7, v[2]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[2] = -9;
            Assert.AreEqual(-9, v[2]);
        }

    }
}
