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
    public class DoubleVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec4(-1);
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-1, v.z);
                Assert.AreEqual(-1, v.w);
            }
            {
                var v = new dvec4(4.5d, -2, -8, -6.5d);
                Assert.AreEqual(4.5d, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-6.5d, v.w);
            }
            {
                var v = new dvec4(new dvec2(7, 2));
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec3(1.0, -2, 0.5d));
                Assert.AreEqual(1.0, v.x);
                Assert.AreEqual(-2, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec4(5, 5.5d, -9, 3));
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(5.5d, v.y);
                Assert.AreEqual(-9, v.z);
                Assert.AreEqual(3, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new dvec4(-1.5d, 6, -2, 8.5d);
            Assert.AreEqual(-1.5d, v[0]);
            Assert.AreEqual(6, v[1]);
            Assert.AreEqual(-2, v[2]);
            Assert.AreEqual(8.5d, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = v[5]; } );
            
            v[2] = 0.0;
            Assert.AreEqual(0.0, v[2]);
            v[3] = 1.0;
            Assert.AreEqual(1.0, v[3]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[1] = 3;
            Assert.AreEqual(3, v[1]);
            v[1] = 4;
            Assert.AreEqual(4, v[1]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[3] = 6;
            Assert.AreEqual(6, v[3]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[3] = 8;
            Assert.AreEqual(8, v[3]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[3] = -1;
            Assert.AreEqual(-1, v[3]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[3] = -5;
            Assert.AreEqual(-5, v[3]);
            v[1] = -6;
            Assert.AreEqual(-6, v[1]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[0] = -8;
            Assert.AreEqual(-8, v[0]);
            v[2] = -9;
            Assert.AreEqual(-9, v[2]);
            v[1] = -9.5d;
            Assert.AreEqual(-9.5d, v[1]);
            v[0] = -8.5d;
            Assert.AreEqual(-8.5d, v[0]);
            v[2] = -7.5d;
            Assert.AreEqual(-7.5d, v[2]);
            v[2] = -6.5d;
            Assert.AreEqual(-6.5d, v[2]);
            v[0] = -5.5d;
            Assert.AreEqual(-5.5d, v[0]);
            v[3] = -4.5d;
            Assert.AreEqual(-4.5d, v[3]);
            v[2] = -3.5d;
            Assert.AreEqual(-3.5d, v[2]);
            v[2] = -2.5d;
            Assert.AreEqual(-2.5d, v[2]);
            v[3] = -1.5d;
            Assert.AreEqual(-1.5d, v[3]);
            v[2] = -0.5d;
            Assert.AreEqual(-0.5d, v[2]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[2] = 1.5d;
            Assert.AreEqual(1.5d, v[2]);
            v[0] = 2.5d;
            Assert.AreEqual(2.5d, v[0]);
            v[3] = 3.5d;
            Assert.AreEqual(3.5d, v[3]);
            v[1] = 4.5d;
            Assert.AreEqual(4.5d, v[1]);
            v[3] = 5.5d;
            Assert.AreEqual(5.5d, v[3]);
            v[0] = 6.5d;
            Assert.AreEqual(6.5d, v[0]);
            v[1] = 7.5d;
            Assert.AreEqual(7.5d, v[1]);
            v[3] = 8.5d;
            Assert.AreEqual(8.5d, v[3]);
            v[2] = 9.5d;
            Assert.AreEqual(9.5d, v[2]);
        }

    }
}
