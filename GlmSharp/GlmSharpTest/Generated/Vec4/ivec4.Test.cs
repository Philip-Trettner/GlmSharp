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
                var v = new ivec4(9);
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var v = new ivec4(5, 4, 2, 0);
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec2(2, -6));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec3(-5, -9, 6));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec4(-1, -9, 3, -7));
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-7, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new ivec4(9, -7, -3, -9);
            Assert.AreEqual(9, v[0]);
            Assert.AreEqual(-7, v[1]);
            Assert.AreEqual(-3, v[2]);
            Assert.AreEqual(-9, v[3]);
            
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
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[3] = 3;
            Assert.AreEqual(3, v[3]);
            v[1] = 4;
            Assert.AreEqual(4, v[1]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[3] = -7;
            Assert.AreEqual(-7, v[3]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new ivec4(-7, -5, -7, -3);
            var vals = v.Values;
            Assert.AreEqual(-7, vals[0]);
            Assert.AreEqual(-5, vals[1]);
            Assert.AreEqual(-7, vals[2]);
            Assert.AreEqual(-3, vals[3]);
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, ivec4.Zero.x);
            Assert.AreEqual(0, ivec4.Zero.y);
            Assert.AreEqual(0, ivec4.Zero.z);
            Assert.AreEqual(0, ivec4.Zero.w);
            
            Assert.AreEqual(1, ivec4.Ones.x);
            Assert.AreEqual(1, ivec4.Ones.y);
            Assert.AreEqual(1, ivec4.Ones.z);
            Assert.AreEqual(1, ivec4.Ones.w);
            
            Assert.AreEqual(1, ivec4.UnitX.x);
            Assert.AreEqual(0, ivec4.UnitX.y);
            Assert.AreEqual(0, ivec4.UnitX.z);
            Assert.AreEqual(0, ivec4.UnitX.w);
            
            Assert.AreEqual(0, ivec4.UnitY.x);
            Assert.AreEqual(1, ivec4.UnitY.y);
            Assert.AreEqual(0, ivec4.UnitY.z);
            Assert.AreEqual(0, ivec4.UnitY.w);
            
            Assert.AreEqual(0, ivec4.UnitZ.x);
            Assert.AreEqual(0, ivec4.UnitZ.y);
            Assert.AreEqual(1, ivec4.UnitZ.z);
            Assert.AreEqual(0, ivec4.UnitZ.w);
            
            Assert.AreEqual(0, ivec4.UnitW.x);
            Assert.AreEqual(0, ivec4.UnitW.y);
            Assert.AreEqual(0, ivec4.UnitW.z);
            Assert.AreEqual(1, ivec4.UnitW.w);
            
            Assert.AreEqual(int.MaxValue, ivec4.MaxValue.x);
            Assert.AreEqual(int.MaxValue, ivec4.MaxValue.y);
            Assert.AreEqual(int.MaxValue, ivec4.MaxValue.z);
            Assert.AreEqual(int.MaxValue, ivec4.MaxValue.w);
            
            Assert.AreEqual(int.MinValue, ivec4.MinValue.x);
            Assert.AreEqual(int.MinValue, ivec4.MinValue.y);
            Assert.AreEqual(int.MinValue, ivec4.MinValue.z);
            Assert.AreEqual(int.MinValue, ivec4.MinValue.w);
        }

    }
}
