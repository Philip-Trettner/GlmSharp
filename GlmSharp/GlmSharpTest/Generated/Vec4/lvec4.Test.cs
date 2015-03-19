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
                var v = new lvec4(3);
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var v = new lvec4(6, -3, 5, 4);
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var v = new lvec4(new lvec2(-7, 8));
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec3(2, -9, 8));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec4(9, 8, -6, -3));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-3, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec4(4, -5, 5, 8);
            Assert.AreEqual(4, v[0]);
            Assert.AreEqual(-5, v[1]);
            Assert.AreEqual(5, v[2]);
            Assert.AreEqual(8, v[3]);
            
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
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[1] = 1;
            Assert.AreEqual(1, v[1]);
            v[3] = 2;
            Assert.AreEqual(2, v[3]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[3] = 6;
            Assert.AreEqual(6, v[3]);
            v[3] = 7;
            Assert.AreEqual(7, v[3]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[2] = -4;
            Assert.AreEqual(-4, v[2]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[3] = -9;
            Assert.AreEqual(-9, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new lvec4(-7, -7, 1, -5);
            var vals = v.Values;
            Assert.AreEqual(-7, vals[0]);
            Assert.AreEqual(-7, vals[1]);
            Assert.AreEqual(1, vals[2]);
            Assert.AreEqual(-5, vals[3]);
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, lvec4.Zero.x);
            Assert.AreEqual(0, lvec4.Zero.y);
            Assert.AreEqual(0, lvec4.Zero.z);
            Assert.AreEqual(0, lvec4.Zero.w);
            
            Assert.AreEqual(1, lvec4.Ones.x);
            Assert.AreEqual(1, lvec4.Ones.y);
            Assert.AreEqual(1, lvec4.Ones.z);
            Assert.AreEqual(1, lvec4.Ones.w);
            
            Assert.AreEqual(1, lvec4.UnitX.x);
            Assert.AreEqual(0, lvec4.UnitX.y);
            Assert.AreEqual(0, lvec4.UnitX.z);
            Assert.AreEqual(0, lvec4.UnitX.w);
            
            Assert.AreEqual(0, lvec4.UnitY.x);
            Assert.AreEqual(1, lvec4.UnitY.y);
            Assert.AreEqual(0, lvec4.UnitY.z);
            Assert.AreEqual(0, lvec4.UnitY.w);
            
            Assert.AreEqual(0, lvec4.UnitZ.x);
            Assert.AreEqual(0, lvec4.UnitZ.y);
            Assert.AreEqual(1, lvec4.UnitZ.z);
            Assert.AreEqual(0, lvec4.UnitZ.w);
            
            Assert.AreEqual(0, lvec4.UnitW.x);
            Assert.AreEqual(0, lvec4.UnitW.y);
            Assert.AreEqual(0, lvec4.UnitW.z);
            Assert.AreEqual(1, lvec4.UnitW.w);
            
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.x);
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.y);
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.z);
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.w);
            
            Assert.AreEqual(long.MinValue, lvec4.MinValue.x);
            Assert.AreEqual(long.MinValue, lvec4.MinValue.y);
            Assert.AreEqual(long.MinValue, lvec4.MinValue.z);
            Assert.AreEqual(long.MinValue, lvec4.MinValue.w);
        }

    }
}
