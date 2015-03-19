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
    public class LongVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec4(0);
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(0, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(-9, 2, 0, -3);
                Assert.AreEqual(-9, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(-3, v.w);
            }
            {
                var v = new lvec4(new lvec2(-1, -1));
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec3(9, 9, -7));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(-7, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec4(0, -3, 8, 2));
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(2, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec4(4, 8, 2, 2);
            Assert.AreEqual(4, v[0]);
            Assert.AreEqual(8, v[1]);
            Assert.AreEqual(2, v[2]);
            Assert.AreEqual(2, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[3] = 0;
            Assert.AreEqual(0, v[3]);
            v[2] = 1;
            Assert.AreEqual(1, v[2]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[3] = 3;
            Assert.AreEqual(3, v[3]);
            v[3] = 4;
            Assert.AreEqual(4, v[3]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[1] = -1;
            Assert.AreEqual(-1, v[1]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[3] = -3;
            Assert.AreEqual(-3, v[3]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[2] = -5;
            Assert.AreEqual(-5, v[2]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[3] = -9;
            Assert.AreEqual(-9, v[3]);
        }

    }
}
