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
    public class BoolVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new bvec2(false);
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var v = new bvec2(true, false);
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var v = new bvec2(new bvec2(false, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var v = new bvec2(new bvec3(false, false, true));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
            }
            {
                var v = new bvec2(new bvec4(true, false, false, true));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new bvec2(false, true);
            Assert.AreEqual(false, v[0]);
            Assert.AreEqual(true, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = false; } );
            
            v[1] = false;
            Assert.AreEqual(false, v[1]);
            v[1] = true;
            Assert.AreEqual(true, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new bvec2(true, false);
            var vals = v.Values;
            Assert.AreEqual(true, vals[0]);
            Assert.AreEqual(false, vals[1]);
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(false, bvec2.Zero.x);
            Assert.AreEqual(false, bvec2.Zero.y);
            
            Assert.AreEqual(true, bvec2.Ones.x);
            Assert.AreEqual(true, bvec2.Ones.y);
            
            Assert.AreEqual(true, bvec2.UnitX.x);
            Assert.AreEqual(false, bvec2.UnitX.y);
            
            Assert.AreEqual(false, bvec2.UnitY.x);
            Assert.AreEqual(true, bvec2.UnitY.y);
        }

    }
}
