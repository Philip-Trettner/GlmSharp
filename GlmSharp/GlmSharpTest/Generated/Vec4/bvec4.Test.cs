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
    public class BoolVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new bvec4(false);
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var v = new bvec4(true, false, false, true);
                Assert.AreEqual(true, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(true, v.w);
            }
            {
                var v = new bvec4(new bvec2(false, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var v = new bvec4(new bvec3(false, true, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(true, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
            {
                var v = new bvec4(new bvec4(false, false, false, false));
                Assert.AreEqual(false, v.x);
                Assert.AreEqual(false, v.y);
                Assert.AreEqual(false, v.z);
                Assert.AreEqual(false, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new bvec4(true, false, false, true);
            Assert.AreEqual(true, v[0]);
            Assert.AreEqual(false, v[1]);
            Assert.AreEqual(false, v[2]);
            Assert.AreEqual(true, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = v[5]; } );
            
            v[0] = false;
            Assert.AreEqual(false, v[0]);
            v[3] = true;
            Assert.AreEqual(true, v[3]);
        }

    }
}
