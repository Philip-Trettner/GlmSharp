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
    public class DecimalVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new decvec3(2);
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(2, v.z);
            }
            {
                var v = new decvec3(-0.5m, 5, 0m);
                Assert.AreEqual(-0.5m, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(0m, v.z);
            }
            {
                var v = new decvec3(new decvec2(7, 6));
                Assert.AreEqual(7, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(0m, v.z);
            }
            {
                var v = new decvec3(new decvec3(2.5m, 7.5m, -8));
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(7.5m, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var v = new decvec3(new decvec4(-6.5m, 0m, -7.5m, -2.5m));
                Assert.AreEqual(-6.5m, v.x);
                Assert.AreEqual(0m, v.y);
                Assert.AreEqual(-7.5m, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new decvec3(-8, 6.5m, -6);
            Assert.AreEqual(-8, v[0]);
            Assert.AreEqual(6.5m, v[1]);
            Assert.AreEqual(-6, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0m; } );
            
            v[2] = 0m;
            Assert.AreEqual(0m, v[2]);
            v[0] = 1m;
            Assert.AreEqual(1m, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[2] = 6;
            Assert.AreEqual(6, v[2]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[2] = 9;
            Assert.AreEqual(9, v[2]);
            v[1] = -1;
            Assert.AreEqual(-1, v[1]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[2] = -5;
            Assert.AreEqual(-5, v[2]);
            v[1] = -6;
            Assert.AreEqual(-6, v[1]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
            v[2] = -9.5m;
            Assert.AreEqual(-9.5m, v[2]);
            v[1] = -8.5m;
            Assert.AreEqual(-8.5m, v[1]);
            v[2] = -7.5m;
            Assert.AreEqual(-7.5m, v[2]);
            v[1] = -6.5m;
            Assert.AreEqual(-6.5m, v[1]);
            v[1] = -5.5m;
            Assert.AreEqual(-5.5m, v[1]);
            v[1] = -4.5m;
            Assert.AreEqual(-4.5m, v[1]);
            v[0] = -3.5m;
            Assert.AreEqual(-3.5m, v[0]);
            v[1] = -2.5m;
            Assert.AreEqual(-2.5m, v[1]);
            v[0] = -1.5m;
            Assert.AreEqual(-1.5m, v[0]);
            v[2] = -0.5m;
            Assert.AreEqual(-0.5m, v[2]);
            v[1] = 0.5m;
            Assert.AreEqual(0.5m, v[1]);
            v[1] = 1.5m;
            Assert.AreEqual(1.5m, v[1]);
            v[0] = 2.5m;
            Assert.AreEqual(2.5m, v[0]);
            v[0] = 3.5m;
            Assert.AreEqual(3.5m, v[0]);
            v[1] = 4.5m;
            Assert.AreEqual(4.5m, v[1]);
            v[1] = 5.5m;
            Assert.AreEqual(5.5m, v[1]);
            v[2] = 6.5m;
            Assert.AreEqual(6.5m, v[2]);
            v[2] = 7.5m;
            Assert.AreEqual(7.5m, v[2]);
            v[1] = 8.5m;
            Assert.AreEqual(8.5m, v[1]);
            v[0] = 9.5m;
            Assert.AreEqual(9.5m, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new decvec3(-7, 7, 0.5m);
            var vals = v.Values;
            Assert.AreEqual(-7, vals[0]);
            Assert.AreEqual(7, vals[1]);
            Assert.AreEqual(0.5m, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0m, decvec3.Zero.x);
            Assert.AreEqual(0m, decvec3.Zero.y);
            Assert.AreEqual(0m, decvec3.Zero.z);
            
            Assert.AreEqual(1m, decvec3.Ones.x);
            Assert.AreEqual(1m, decvec3.Ones.y);
            Assert.AreEqual(1m, decvec3.Ones.z);
            
            Assert.AreEqual(1m, decvec3.UnitX.x);
            Assert.AreEqual(0m, decvec3.UnitX.y);
            Assert.AreEqual(0m, decvec3.UnitX.z);
            
            Assert.AreEqual(0m, decvec3.UnitY.x);
            Assert.AreEqual(1m, decvec3.UnitY.y);
            Assert.AreEqual(0m, decvec3.UnitY.z);
            
            Assert.AreEqual(0m, decvec3.UnitZ.x);
            Assert.AreEqual(0m, decvec3.UnitZ.y);
            Assert.AreEqual(1m, decvec3.UnitZ.z);
            
            Assert.AreEqual(decimal.MaxValue, decvec3.MaxValue.x);
            Assert.AreEqual(decimal.MaxValue, decvec3.MaxValue.y);
            Assert.AreEqual(decimal.MaxValue, decvec3.MaxValue.z);
            
            Assert.AreEqual(decimal.MinValue, decvec3.MinValue.x);
            Assert.AreEqual(decimal.MinValue, decvec3.MinValue.y);
            Assert.AreEqual(decimal.MinValue, decvec3.MinValue.z);
            
            Assert.AreEqual(decimal.MinusOne, decvec3.MinusOne.x);
            Assert.AreEqual(decimal.MinusOne, decvec3.MinusOne.y);
            Assert.AreEqual(decimal.MinusOne, decvec3.MinusOne.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new decvec3(-4.5m, 4.5m, 6);
            var v2 = new decvec3(-4.5m, 4.5m, 6);
            var v3 = new decvec3(6, 4.5m, -4.5m);
            Assert.That(v1 == new decvec3(v1));
            Assert.That(v2 == new decvec3(v2));
            Assert.That(v3 == new decvec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new decvec3(-8.5m, 1m, -1);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = decvec3.Parse(s0);
            var v1 = decvec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = decvec3.TryParse(s0, out v0);
            var b1 = decvec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = decvec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = decvec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = decvec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { decvec3.Parse(null); });
            Assert.Throws<FormatException>(() => { decvec3.Parse(""); });
            Assert.Throws<FormatException>(() => { decvec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = decvec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = decvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = decvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

    }
}
