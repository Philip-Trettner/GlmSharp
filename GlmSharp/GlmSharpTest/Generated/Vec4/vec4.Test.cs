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
    public class FloatVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new vec4(-8);
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-8, v.w);
            }
            {
                var v = new vec4(-5, 6, -2.5f, 2.5f);
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(-2.5f, v.z);
                Assert.AreEqual(2.5f, v.w);
            }
            {
                var v = new vec4(new vec2(-5.5f, -5.5f));
                Assert.AreEqual(-5.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var v = new vec4(new vec3(1.5f, 8.5f, -1.5f));
                Assert.AreEqual(1.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(-1.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var v = new vec4(new vec4(0.5f, 4.5f, -0.5f, 1f));
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(4.5f, v.y);
                Assert.AreEqual(-0.5f, v.z);
                Assert.AreEqual(1f, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new vec4(-4.5f, -2, -2.5f, -0.5f);
            Assert.AreEqual(-4.5f, v[0]);
            Assert.AreEqual(-2, v[1]);
            Assert.AreEqual(-2.5f, v[2]);
            Assert.AreEqual(-0.5f, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
            
            v[1] = 0f;
            Assert.AreEqual(0f, v[1]);
            v[3] = 1f;
            Assert.AreEqual(1f, v[3]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[2] = 9;
            Assert.AreEqual(9, v[2]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[3] = -6;
            Assert.AreEqual(-6, v[3]);
            v[2] = -7;
            Assert.AreEqual(-7, v[2]);
            v[3] = -8;
            Assert.AreEqual(-8, v[3]);
            v[3] = -9;
            Assert.AreEqual(-9, v[3]);
            v[0] = -9.5f;
            Assert.AreEqual(-9.5f, v[0]);
            v[3] = -8.5f;
            Assert.AreEqual(-8.5f, v[3]);
            v[0] = -7.5f;
            Assert.AreEqual(-7.5f, v[0]);
            v[1] = -6.5f;
            Assert.AreEqual(-6.5f, v[1]);
            v[0] = -5.5f;
            Assert.AreEqual(-5.5f, v[0]);
            v[3] = -4.5f;
            Assert.AreEqual(-4.5f, v[3]);
            v[3] = -3.5f;
            Assert.AreEqual(-3.5f, v[3]);
            v[2] = -2.5f;
            Assert.AreEqual(-2.5f, v[2]);
            v[1] = -1.5f;
            Assert.AreEqual(-1.5f, v[1]);
            v[3] = -0.5f;
            Assert.AreEqual(-0.5f, v[3]);
            v[2] = 0.5f;
            Assert.AreEqual(0.5f, v[2]);
            v[3] = 1.5f;
            Assert.AreEqual(1.5f, v[3]);
            v[3] = 2.5f;
            Assert.AreEqual(2.5f, v[3]);
            v[0] = 3.5f;
            Assert.AreEqual(3.5f, v[0]);
            v[2] = 4.5f;
            Assert.AreEqual(4.5f, v[2]);
            v[3] = 5.5f;
            Assert.AreEqual(5.5f, v[3]);
            v[1] = 6.5f;
            Assert.AreEqual(6.5f, v[1]);
            v[3] = 7.5f;
            Assert.AreEqual(7.5f, v[3]);
            v[3] = 8.5f;
            Assert.AreEqual(8.5f, v[3]);
            v[1] = 9.5f;
            Assert.AreEqual(9.5f, v[1]);
        }

    }
}
