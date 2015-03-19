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
    public class LongVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec2(2);
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var v = new lvec2(1, 9);
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9, v.y);
            }
            {
                var v = new lvec2(new lvec2(3, -2));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-2, v.y);
            }
            {
                var v = new lvec2(new lvec3(-8, 1, -9));
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(1, v.y);
            }
            {
                var v = new lvec2(new lvec4(6, 6, -9, -4));
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec2(2, -2);
            Assert.AreEqual(2, v[0]);
            Assert.AreEqual(-2, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[1] = 4;
            Assert.AreEqual(4, v[1]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
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
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new lvec2(9, 9);
            var vals = v.Values;
            Assert.AreEqual(9, vals[0]);
            Assert.AreEqual(9, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, lvec2.Zero.x);
            Assert.AreEqual(0, lvec2.Zero.y);
            
            Assert.AreEqual(1, lvec2.Ones.x);
            Assert.AreEqual(1, lvec2.Ones.y);
            
            Assert.AreEqual(1, lvec2.UnitX.x);
            Assert.AreEqual(0, lvec2.UnitX.y);
            
            Assert.AreEqual(0, lvec2.UnitY.x);
            Assert.AreEqual(1, lvec2.UnitY.y);
            
            Assert.AreEqual(long.MaxValue, lvec2.MaxValue.x);
            Assert.AreEqual(long.MaxValue, lvec2.MaxValue.y);
            
            Assert.AreEqual(long.MinValue, lvec2.MinValue.x);
            Assert.AreEqual(long.MinValue, lvec2.MinValue.y);
        }

    }
}
