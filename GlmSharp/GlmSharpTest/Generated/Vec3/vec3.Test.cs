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
    public class FloatVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new vec3(9);
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
            }
            {
                var v = new vec3(8.5f, -3, -7.5f);
                Assert.AreEqual(8.5f, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(-7.5f, v.z);
            }
            {
                var v = new vec3(new vec2(-6.5f, 0.5f));
                Assert.AreEqual(-6.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var v = new vec3(new vec3(-5.5f, 6, -2.5f));
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-2.5f, v.z);
            }
            {
                var v = new vec3(new vec4(0.5f, 4, 4, 5));
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(4, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new vec3(-4.5f, -8, -0.5f);
            Assert.AreEqual(-4.5f, v[0]);
            Assert.AreEqual(-8, v[1]);
            Assert.AreEqual(-0.5f, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = v[5]; } );
            
            v[2] = 0f;
            Assert.AreEqual(0f, v[2]);
            v[2] = 1f;
            Assert.AreEqual(1f, v[2]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
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
            v[2] = 9;
            Assert.AreEqual(9, v[2]);
            v[1] = -1;
            Assert.AreEqual(-1, v[1]);
            v[2] = -2;
            Assert.AreEqual(-2, v[2]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[2] = -4;
            Assert.AreEqual(-4, v[2]);
            v[0] = -5;
            Assert.AreEqual(-5, v[0]);
            v[2] = -6;
            Assert.AreEqual(-6, v[2]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[2] = -9;
            Assert.AreEqual(-9, v[2]);
            v[2] = -9.5f;
            Assert.AreEqual(-9.5f, v[2]);
            v[1] = -8.5f;
            Assert.AreEqual(-8.5f, v[1]);
            v[1] = -7.5f;
            Assert.AreEqual(-7.5f, v[1]);
            v[0] = -6.5f;
            Assert.AreEqual(-6.5f, v[0]);
            v[1] = -5.5f;
            Assert.AreEqual(-5.5f, v[1]);
            v[0] = -4.5f;
            Assert.AreEqual(-4.5f, v[0]);
            v[1] = -3.5f;
            Assert.AreEqual(-3.5f, v[1]);
            v[1] = -2.5f;
            Assert.AreEqual(-2.5f, v[1]);
            v[1] = -1.5f;
            Assert.AreEqual(-1.5f, v[1]);
            v[1] = -0.5f;
            Assert.AreEqual(-0.5f, v[1]);
            v[0] = 0.5f;
            Assert.AreEqual(0.5f, v[0]);
            v[0] = 1.5f;
            Assert.AreEqual(1.5f, v[0]);
            v[2] = 2.5f;
            Assert.AreEqual(2.5f, v[2]);
            v[0] = 3.5f;
            Assert.AreEqual(3.5f, v[0]);
            v[1] = 4.5f;
            Assert.AreEqual(4.5f, v[1]);
            v[1] = 5.5f;
            Assert.AreEqual(5.5f, v[1]);
            v[1] = 6.5f;
            Assert.AreEqual(6.5f, v[1]);
            v[2] = 7.5f;
            Assert.AreEqual(7.5f, v[2]);
            v[2] = 8.5f;
            Assert.AreEqual(8.5f, v[2]);
            v[1] = 9.5f;
            Assert.AreEqual(9.5f, v[1]);
        }

    }
}
