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
    public class DecimalVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new decvec2(7.5m);
                Assert.AreEqual(7.5m, v.x);
                Assert.AreEqual(7.5m, v.y);
            }
            {
                var v = new decvec2(9, -8.5m);
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-8.5m, v.y);
            }
            {
                var v = new decvec2(new decvec2(-9.5m, -5));
                Assert.AreEqual(-9.5m, v.x);
                Assert.AreEqual(-5, v.y);
            }
            {
                var v = new decvec2(new decvec3(-3.5m, -6, -3));
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(-6, v.y);
            }
            {
                var v = new decvec2(new decvec4(4.5m, 5, 8.5m, -8.5m));
                Assert.AreEqual(4.5m, v.x);
                Assert.AreEqual(5, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new decvec2(6.5m, 2.5m);
            Assert.AreEqual(6.5m, v[0]);
            Assert.AreEqual(2.5m, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0m; } );
            
            v[1] = 0m;
            Assert.AreEqual(0m, v[1]);
            v[0] = 1m;
            Assert.AreEqual(1m, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[1] = -1;
            Assert.AreEqual(-1, v[1]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[0] = -5;
            Assert.AreEqual(-5, v[0]);
            v[1] = -6;
            Assert.AreEqual(-6, v[1]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[0] = -8;
            Assert.AreEqual(-8, v[0]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
            v[1] = -9.5m;
            Assert.AreEqual(-9.5m, v[1]);
            v[0] = -8.5m;
            Assert.AreEqual(-8.5m, v[0]);
            v[1] = -7.5m;
            Assert.AreEqual(-7.5m, v[1]);
            v[1] = -6.5m;
            Assert.AreEqual(-6.5m, v[1]);
            v[1] = -5.5m;
            Assert.AreEqual(-5.5m, v[1]);
            v[0] = -4.5m;
            Assert.AreEqual(-4.5m, v[0]);
            v[0] = -3.5m;
            Assert.AreEqual(-3.5m, v[0]);
            v[0] = -2.5m;
            Assert.AreEqual(-2.5m, v[0]);
            v[0] = -1.5m;
            Assert.AreEqual(-1.5m, v[0]);
            v[0] = -0.5m;
            Assert.AreEqual(-0.5m, v[0]);
            v[0] = 0.5m;
            Assert.AreEqual(0.5m, v[0]);
            v[1] = 1.5m;
            Assert.AreEqual(1.5m, v[1]);
            v[0] = 2.5m;
            Assert.AreEqual(2.5m, v[0]);
            v[0] = 3.5m;
            Assert.AreEqual(3.5m, v[0]);
            v[0] = 4.5m;
            Assert.AreEqual(4.5m, v[0]);
            v[1] = 5.5m;
            Assert.AreEqual(5.5m, v[1]);
            v[1] = 6.5m;
            Assert.AreEqual(6.5m, v[1]);
            v[1] = 7.5m;
            Assert.AreEqual(7.5m, v[1]);
            v[0] = 8.5m;
            Assert.AreEqual(8.5m, v[0]);
            v[1] = 9.5m;
            Assert.AreEqual(9.5m, v[1]);
        }

    }
}
