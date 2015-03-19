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
    public class DoubleVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec3(2.5d);
                Assert.AreEqual(2.5d, v.x);
                Assert.AreEqual(2.5d, v.y);
                Assert.AreEqual(2.5d, v.z);
            }
            {
                var v = new dvec3(7, 9.5d, -4);
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(9.5d, v.y);
                Assert.AreEqual(-4, v.z);
            }
            {
                var v = new dvec3(new dvec2(-7.5d, 6));
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(0.0, v.z);
            }
            {
                var v = new dvec3(new dvec3(3, 1.0, 7));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(1.0, v.y);
                Assert.AreEqual(7, v.z);
            }
            {
                var v = new dvec3(new dvec4(0.5d, 5, 4, -8));
                Assert.AreEqual(0.5d, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(4, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new dvec3(3, -1.5d, -2.5d);
            Assert.AreEqual(3, v[0]);
            Assert.AreEqual(-1.5d, v[1]);
            Assert.AreEqual(-2.5d, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[2] = 0.0;
            Assert.AreEqual(0.0, v[2]);
            v[1] = 1.0;
            Assert.AreEqual(1.0, v[1]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[2] = 6;
            Assert.AreEqual(6, v[2]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[2] = -2;
            Assert.AreEqual(-2, v[2]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[2] = -6;
            Assert.AreEqual(-6, v[2]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
            v[1] = -9.5d;
            Assert.AreEqual(-9.5d, v[1]);
            v[0] = -8.5d;
            Assert.AreEqual(-8.5d, v[0]);
            v[1] = -7.5d;
            Assert.AreEqual(-7.5d, v[1]);
            v[1] = -6.5d;
            Assert.AreEqual(-6.5d, v[1]);
            v[1] = -5.5d;
            Assert.AreEqual(-5.5d, v[1]);
            v[2] = -4.5d;
            Assert.AreEqual(-4.5d, v[2]);
            v[2] = -3.5d;
            Assert.AreEqual(-3.5d, v[2]);
            v[2] = -2.5d;
            Assert.AreEqual(-2.5d, v[2]);
            v[0] = -1.5d;
            Assert.AreEqual(-1.5d, v[0]);
            v[2] = -0.5d;
            Assert.AreEqual(-0.5d, v[2]);
            v[1] = 0.5d;
            Assert.AreEqual(0.5d, v[1]);
            v[1] = 1.5d;
            Assert.AreEqual(1.5d, v[1]);
            v[1] = 2.5d;
            Assert.AreEqual(2.5d, v[1]);
            v[1] = 3.5d;
            Assert.AreEqual(3.5d, v[1]);
            v[2] = 4.5d;
            Assert.AreEqual(4.5d, v[2]);
            v[2] = 5.5d;
            Assert.AreEqual(5.5d, v[2]);
            v[1] = 6.5d;
            Assert.AreEqual(6.5d, v[1]);
            v[2] = 7.5d;
            Assert.AreEqual(7.5d, v[2]);
            v[2] = 8.5d;
            Assert.AreEqual(8.5d, v[2]);
            v[1] = 9.5d;
            Assert.AreEqual(9.5d, v[1]);
        }

    }
}
