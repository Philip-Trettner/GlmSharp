using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
using Newtonsoft.Json;
using GlmSharp;

// ReSharper disable InconsistentNaming

namespace GlmSharpTest.Generated.Vec4
{
    [TestFixture]
    public class DecimalVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new decvec4(-4.5m);
                Assert.AreEqual(-4.5m, v.x);
                Assert.AreEqual(-4.5m, v.y);
                Assert.AreEqual(-4.5m, v.z);
                Assert.AreEqual(-4.5m, v.w);
            }
            {
                var v = new decvec4(7.5m, -7.5m, -3, 3);
                Assert.AreEqual(7.5m, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(-3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var v = new decvec4(new decvec2(4, 8));
                Assert.AreEqual(4, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(0m, v.z);
                Assert.AreEqual(0m, v.w);
            }
            {
                var v = new decvec4(new decvec3(-4, -9, 4.5m));
                Assert.AreEqual(-4, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(4.5m, v.z);
                Assert.AreEqual(0m, v.w);
            }
            {
                var v = new decvec4(new decvec4(-8, -4.5m, -8, -9.5m));
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-4.5m, v.y);
                Assert.AreEqual(-8, v.z);
                Assert.AreEqual(-9.5m, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new decvec4(-5.5m, -9.5m, 7.5m, 6);
            Assert.AreEqual(-5.5m, v[0]);
            Assert.AreEqual(-9.5m, v[1]);
            Assert.AreEqual(7.5m, v[2]);
            Assert.AreEqual(6, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0m; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0m; } );
            
            v[3] = 0m;
            Assert.AreEqual(0m, v[3]);
            v[2] = 1m;
            Assert.AreEqual(1m, v[2]);
            v[3] = 2;
            Assert.AreEqual(2, v[3]);
            v[1] = 3;
            Assert.AreEqual(3, v[1]);
            v[3] = 4;
            Assert.AreEqual(4, v[3]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[3] = 9;
            Assert.AreEqual(9, v[3]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[3] = -2;
            Assert.AreEqual(-2, v[3]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[3] = -4;
            Assert.AreEqual(-4, v[3]);
            v[0] = -5;
            Assert.AreEqual(-5, v[0]);
            v[3] = -6;
            Assert.AreEqual(-6, v[3]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[0] = -8;
            Assert.AreEqual(-8, v[0]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
            v[0] = -9.5m;
            Assert.AreEqual(-9.5m, v[0]);
            v[2] = -8.5m;
            Assert.AreEqual(-8.5m, v[2]);
            v[3] = -7.5m;
            Assert.AreEqual(-7.5m, v[3]);
            v[2] = -6.5m;
            Assert.AreEqual(-6.5m, v[2]);
            v[1] = -5.5m;
            Assert.AreEqual(-5.5m, v[1]);
            v[2] = -4.5m;
            Assert.AreEqual(-4.5m, v[2]);
            v[3] = -3.5m;
            Assert.AreEqual(-3.5m, v[3]);
            v[0] = -2.5m;
            Assert.AreEqual(-2.5m, v[0]);
            v[3] = -1.5m;
            Assert.AreEqual(-1.5m, v[3]);
            v[1] = -0.5m;
            Assert.AreEqual(-0.5m, v[1]);
            v[3] = 0.5m;
            Assert.AreEqual(0.5m, v[3]);
            v[1] = 1.5m;
            Assert.AreEqual(1.5m, v[1]);
            v[0] = 2.5m;
            Assert.AreEqual(2.5m, v[0]);
            v[1] = 3.5m;
            Assert.AreEqual(3.5m, v[1]);
            v[1] = 4.5m;
            Assert.AreEqual(4.5m, v[1]);
            v[3] = 5.5m;
            Assert.AreEqual(5.5m, v[3]);
            v[1] = 6.5m;
            Assert.AreEqual(6.5m, v[1]);
            v[2] = 7.5m;
            Assert.AreEqual(7.5m, v[2]);
            v[1] = 8.5m;
            Assert.AreEqual(8.5m, v[1]);
            v[2] = 9.5m;
            Assert.AreEqual(9.5m, v[2]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new decvec4(9.5m, -5, 5, 3.5m);
            var vals = v.Values;
            Assert.AreEqual(9.5m, vals[0]);
            Assert.AreEqual(-5, vals[1]);
            Assert.AreEqual(5, vals[2]);
            Assert.AreEqual(3.5m, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0m, decvec4.Zero.x);
            Assert.AreEqual(0m, decvec4.Zero.y);
            Assert.AreEqual(0m, decvec4.Zero.z);
            Assert.AreEqual(0m, decvec4.Zero.w);
            
            Assert.AreEqual(1m, decvec4.Ones.x);
            Assert.AreEqual(1m, decvec4.Ones.y);
            Assert.AreEqual(1m, decvec4.Ones.z);
            Assert.AreEqual(1m, decvec4.Ones.w);
            
            Assert.AreEqual(1m, decvec4.UnitX.x);
            Assert.AreEqual(0m, decvec4.UnitX.y);
            Assert.AreEqual(0m, decvec4.UnitX.z);
            Assert.AreEqual(0m, decvec4.UnitX.w);
            
            Assert.AreEqual(0m, decvec4.UnitY.x);
            Assert.AreEqual(1m, decvec4.UnitY.y);
            Assert.AreEqual(0m, decvec4.UnitY.z);
            Assert.AreEqual(0m, decvec4.UnitY.w);
            
            Assert.AreEqual(0m, decvec4.UnitZ.x);
            Assert.AreEqual(0m, decvec4.UnitZ.y);
            Assert.AreEqual(1m, decvec4.UnitZ.z);
            Assert.AreEqual(0m, decvec4.UnitZ.w);
            
            Assert.AreEqual(0m, decvec4.UnitW.x);
            Assert.AreEqual(0m, decvec4.UnitW.y);
            Assert.AreEqual(0m, decvec4.UnitW.z);
            Assert.AreEqual(1m, decvec4.UnitW.w);
            
            Assert.AreEqual(decimal.MaxValue, decvec4.MaxValue.x);
            Assert.AreEqual(decimal.MaxValue, decvec4.MaxValue.y);
            Assert.AreEqual(decimal.MaxValue, decvec4.MaxValue.z);
            Assert.AreEqual(decimal.MaxValue, decvec4.MaxValue.w);
            
            Assert.AreEqual(decimal.MinValue, decvec4.MinValue.x);
            Assert.AreEqual(decimal.MinValue, decvec4.MinValue.y);
            Assert.AreEqual(decimal.MinValue, decvec4.MinValue.z);
            Assert.AreEqual(decimal.MinValue, decvec4.MinValue.w);
            
            Assert.AreEqual(decimal.MinusOne, decvec4.MinusOne.x);
            Assert.AreEqual(decimal.MinusOne, decvec4.MinusOne.y);
            Assert.AreEqual(decimal.MinusOne, decvec4.MinusOne.z);
            Assert.AreEqual(decimal.MinusOne, decvec4.MinusOne.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new decvec4(1m, -2.5m, 1.5m, -0.5m);
            var v2 = new decvec4(1m, -2.5m, 1.5m, -0.5m);
            var v3 = new decvec4(-0.5m, 1.5m, -2.5m, 1m);
            Assert.That(v1 == new decvec4(v1));
            Assert.That(v2 == new decvec4(v2));
            Assert.That(v3 == new decvec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new decvec4(3, 9, -3.5m, -7);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = decvec4.Parse(s0);
            var v1 = decvec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = decvec4.TryParse(s0, out v0);
            var b1 = decvec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = decvec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = decvec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = decvec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { decvec4.Parse(null); });
            Assert.Throws<FormatException>(() => { decvec4.Parse(""); });
            Assert.Throws<FormatException>(() => { decvec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = decvec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = decvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = decvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new decvec4(9.5m, 8, -2.5m, -0.5m);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<decvec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

    }
}
