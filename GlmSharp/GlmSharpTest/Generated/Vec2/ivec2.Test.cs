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
    public class IntVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec2(-4);
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-4, v.y);
            }
            {
                var v = new ivec2(7, 6);
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(6, v.y);
            }
            {
                var v = new ivec2(new ivec2(8, -5));
                Assert.AreEqual(8, v.x);
                Assert.AreEqual(-5, v.y);
            }
            {
                var v = new ivec2(new ivec3(-6, 3, 7));
                Assert.AreEqual(-6, v.x);
                Assert.AreEqual(3, v.y);
            }
            {
                var v = new ivec2(new ivec4(4, 8, 4, -3));
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(8, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new ivec2(6, 0);
            Assert.AreEqual(6, v[0]);
            Assert.AreEqual(0, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = v[5]; } );
            
            v[0] = 0;
            Assert.AreEqual(0, v[0]);
            v[1] = 1;
            Assert.AreEqual(1, v[1]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[0] = -5;
            Assert.AreEqual(-5, v[0]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[0] = -8;
            Assert.AreEqual(-8, v[0]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
        }

    }
}
