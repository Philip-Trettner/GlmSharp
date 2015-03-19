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
    public class IntVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec4(4);
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var v = new ivec4(5, 8, 3, -6);
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-6, v.w);
            }
            {
                var v = new ivec4(new ivec2(8, -4));
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-4, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec3(7, -3, 3));
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec4(9, 7, 8, 4));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(7, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(4, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new ivec4(-9, 8, -5, 2);
            Assert.AreEqual(-9, v[0]);
            Assert.AreEqual(8, v[1]);
            Assert.AreEqual(-5, v[2]);
            Assert.AreEqual(2, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = v[5]; } );
            
            v[0] = 0;
            Assert.AreEqual(0, v[0]);
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[3] = 5;
            Assert.AreEqual(5, v[3]);
            v[2] = 6;
            Assert.AreEqual(6, v[2]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[3] = -1;
            Assert.AreEqual(-1, v[3]);
            v[2] = -2;
            Assert.AreEqual(-2, v[2]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[0] = -5;
            Assert.AreEqual(-5, v[0]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[2] = -9;
            Assert.AreEqual(-9, v[2]);
        }

    }
}
