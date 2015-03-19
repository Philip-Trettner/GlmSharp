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
    public class BoolVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new bvec3(false);
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var v = new bvec3(false, true, false);
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var v = new bvec3(new bvec2(false, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
            }
            {
                var v = new bvec3(new bvec3(true, false, true));
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
            {
                var v = new bvec3(new bvec4(false, false, true, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(true, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new bvec3(false, true, false);
            Assert.AreEqual(false, v[0]);
            Assert.AreEqual(true, v[1]);
            Assert.AreEqual(false, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = false; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = false; } );
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
            var v = new bvec3(false, true, false);
            var vals = v.Values;
            Assert.AreEqual(false, vals[0]);
            Assert.AreEqual(true, vals[1]);
            Assert.AreEqual(false, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(false, bvec3.Zero.x);
            Assert.AreEqual(false, bvec3.Zero.y);
            Assert.AreEqual(false, bvec3.Zero.z);
            
            Assert.AreEqual(true, bvec3.Ones.x);
            Assert.AreEqual(true, bvec3.Ones.y);
            Assert.AreEqual(true, bvec3.Ones.z);
            
            Assert.AreEqual(true, bvec3.UnitX.x);
            Assert.AreEqual(false, bvec3.UnitX.y);
            Assert.AreEqual(false, bvec3.UnitX.z);
            
            Assert.AreEqual(false, bvec3.UnitY.x);
            Assert.AreEqual(true, bvec3.UnitY.y);
            Assert.AreEqual(false, bvec3.UnitY.z);
            
            Assert.AreEqual(false, bvec3.UnitZ.x);
            Assert.AreEqual(false, bvec3.UnitZ.y);
            Assert.AreEqual(true, bvec3.UnitZ.z);
        }

    }
}
