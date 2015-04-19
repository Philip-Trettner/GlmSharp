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
                var v = new decvec4(7.5m, -7.5m, -3m, 3m);
                Assert.AreEqual(7.5m, v.x);
                Assert.AreEqual(-7.5m, v.y);
                Assert.AreEqual(-3m, v.z);
                Assert.AreEqual(3m, v.w);
            }
            {
                var v = new decvec4(new decvec2(4m, 8m));
                Assert.AreEqual(4m, v.x);
                Assert.AreEqual(8m, v.y);
                Assert.AreEqual(0m, v.z);
                Assert.AreEqual(0m, v.w);
            }
            {
                var v = new decvec4(new decvec3(-4m, -9m, 4.5m));
                Assert.AreEqual(-4m, v.x);
                Assert.AreEqual(-9m, v.y);
                Assert.AreEqual(4.5m, v.z);
                Assert.AreEqual(0m, v.w);
            }
            {
                var v = new decvec4(new decvec4(-8m, -4.5m, -8m, -9.5m));
                Assert.AreEqual(-8m, v.x);
                Assert.AreEqual(-4.5m, v.y);
                Assert.AreEqual(-8m, v.z);
                Assert.AreEqual(-9.5m, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new decvec4(-5.5m, -9.5m, 7.5m, 6m);
            Assert.AreEqual(-5.5m, v[0]);
            Assert.AreEqual(-9.5m, v[1]);
            Assert.AreEqual(7.5m, v[2]);
            Assert.AreEqual(6m, v[3]);
            
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
            v[3] = 2m;
            Assert.AreEqual(2m, v[3]);
            v[1] = 3m;
            Assert.AreEqual(3m, v[1]);
            v[3] = 4m;
            Assert.AreEqual(4m, v[3]);
            v[2] = 5m;
            Assert.AreEqual(5m, v[2]);
            v[0] = 6m;
            Assert.AreEqual(6m, v[0]);
            v[1] = 7m;
            Assert.AreEqual(7m, v[1]);
            v[2] = 8m;
            Assert.AreEqual(8m, v[2]);
            v[3] = 9m;
            Assert.AreEqual(9m, v[3]);
            v[2] = -1m;
            Assert.AreEqual(-1m, v[2]);
            v[3] = -2m;
            Assert.AreEqual(-2m, v[3]);
            v[0] = -3m;
            Assert.AreEqual(-3m, v[0]);
            v[3] = -4m;
            Assert.AreEqual(-4m, v[3]);
            v[0] = -5m;
            Assert.AreEqual(-5m, v[0]);
            v[3] = -6m;
            Assert.AreEqual(-6m, v[3]);
            v[0] = -7m;
            Assert.AreEqual(-7m, v[0]);
            v[0] = -8m;
            Assert.AreEqual(-8m, v[0]);
            v[1] = -9m;
            Assert.AreEqual(-9m, v[1]);
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
            var v = new decvec4(9.5m, -5m, 5m, 3.5m);
            var vals = v.Values;
            Assert.AreEqual(9.5m, vals[0]);
            Assert.AreEqual(-5m, vals[1]);
            Assert.AreEqual(5m, vals[2]);
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
            var v = new decvec4(3m, 9m, -3.5m, -7m);
            
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
            var v0 = new decvec4(9.5m, 8m, -2.5m, -0.5m);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<decvec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new decvec4(-8m, 3m, -2.5m, -7m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec4(3.5m, 2.5m, -8m, -4.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec4(4.5m, 3m, 2.5m, 7.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec4(9m, -4.5m, -2.5m, -0.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec4(-9.5m, -4.5m, 6.5m, 0.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec4(7m, -4m, 5.5m, -0.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec4(-4m, 4m, 2.5m, 5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec4(-3m, -5.5m, -4m, 9.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec4(-3m, -5.5m, 8.5m, 8.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec4(-6.5m, 3.5m, -7.5m, -5m);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new decvec4(-2.5m, 2m, 1.5m, -2.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec4(-3m, 9m, 2.5m, 3m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec4(9.5m, 1.5m, 9.5m, -6.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec4(8.5m, 9.5m, 3m, 3.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec4(2m, 3m, -9m, -1m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec4(4m, 2.5m, 1m, -1.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec4(6.5m, -7m, 5m, 8.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec4(-1.5m, -8m, 6m, -7m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec4(7m, -4.5m, 6.5m, 7.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec4(-1m, 1.5m, 2m, 3m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new decvec4(-1m, 1m, 9m, 7m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec4(-1.5m, -2m, -5.5m, -6.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec4(-3.5m, -2m, 2m, 0.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec4(-0.5m, -4.5m, 6m, -1.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec4(0m, 7m, -7m, -3.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec4(-4.5m, -4m, 6.5m, 4.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec4(3.5m, -8m, 5.5m, -7.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec4(-6.5m, -7m, -4.5m, 7m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec4(-7.5m, -2.5m, 0m, 8.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec4(-2.5m, 6.5m, -1.5m, -3.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new decvec4(-1.5m, 5m, 0.5m, -2m);
                var v1 = new decvec4(6.5m, -3m, -7.5m, 1m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec4(-1m, 0.5m, 7.5m, -6m);
                var v1 = new decvec4(1m, 5m, -4.5m, 2m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec4(7.5m, 2m, 4.5m, -3m);
                var v1 = new decvec4(1m, -1m, -6m, 9m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec4(-5.5m, -3m, 5.5m, 2m);
                var v1 = new decvec4(8m, 7.5m, -5.5m, -5.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec4(-7.5m, -2.5m, -0.5m, 8m);
                var v1 = new decvec4(-6.5m, 9.5m, -8m, 6.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec4(-6.5m, 1m, 5.5m, -1.5m);
                var v1 = new decvec4(9m, 9.5m, 6.5m, -7m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec4(5m, 0m, 8m, -5m);
                var v1 = new decvec4(4m, -7m, -2.5m, -8m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec4(-0.5m, -9.5m, -2.5m, -5.5m);
                var v1 = new decvec4(-7m, -9m, 2.5m, -3m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec4(5m, -4m, 4.5m, -5m);
                var v1 = new decvec4(-7m, -7m, -9.5m, 8.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec4(-5.5m, 8.5m, -0.5m, 9.5m);
                var v1 = new decvec4(-5m, -1.5m, 0m, -5.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new decvec4(-9m, -0.5m, 6.5m, -9m);
                var v1 = new decvec4(0m, 4.5m, -5m, 2.5m);
                var v2 = new decvec4(-4.5m, 8m, -6.5m, 4.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec4(5.5m, 8.5m, 7.5m, -6m);
                var v1 = new decvec4(5.5m, 5m, -9.5m, -1.5m);
                var v2 = new decvec4(5m, 5m, 1.5m, 6.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec4(-6.5m, -2.5m, 9m, -2m);
                var v1 = new decvec4(9.5m, -0.5m, -6.5m, 5.5m);
                var v2 = new decvec4(-2m, 6m, 4m, -7.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec4(9.5m, 3.5m, 7m, -2.5m);
                var v1 = new decvec4(-3.5m, -2.5m, 2.5m, 8m);
                var v2 = new decvec4(5m, -1.5m, 9m, -2.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec4(4.5m, 5.5m, 8.5m, -3m);
                var v1 = new decvec4(0m, -1.5m, -4.5m, -3m);
                var v2 = new decvec4(7.5m, 9.5m, 6.5m, -4m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec4(-4.5m, 3m, 3.5m, 5.5m);
                var v1 = new decvec4(-3.5m, -1.5m, -6.5m, -0.5m);
                var v2 = new decvec4(3.5m, -5m, -7m, 1m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec4(8.5m, 3.5m, 1m, -8m);
                var v1 = new decvec4(-3m, -7.5m, 1.5m, 4.5m);
                var v2 = new decvec4(-8m, -7.5m, -7m, 4m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec4(1.5m, 9m, 4.5m, -5.5m);
                var v1 = new decvec4(-8.5m, 2.5m, -5.5m, 9.5m);
                var v2 = new decvec4(6.5m, 4.5m, 2m, -7.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec4(3.5m, 7.5m, -6.5m, -8m);
                var v1 = new decvec4(5m, -8.5m, 3.5m, -9m);
                var v2 = new decvec4(-8m, 6.5m, -5m, 7m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec4(-3.5m, 6m, 9.5m, -5m);
                var v1 = new decvec4(8m, 1m, 5.5m, 2m);
                var v2 = new decvec4(-3.5m, -0.5m, 3m, -6m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new decvec4(-7m, 2m, 0m, -7.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec4(-0.5m, 4m, 8.5m, 3m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec4(-7m, -9m, -0.5m, -5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec4(6m, -1m, -6.5m, -5.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec4(9.5m, 6m, 5.5m, 7m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec4(5.5m, 3.5m, -7.5m, -3.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec4(4.5m, -3.5m, 1m, 8.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec4(-6.5m, 4m, -5m, 8m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec4(3m, -3.5m, -6m, -9m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec4(-4m, 6.5m, 1m, 4m);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new decvec4(-2m, -8m, -4.5m, -7m);
                var v1 = new decvec4(-2m, 1m, 4m, 3.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec4(-0.5m, 4.5m, 2m, -7m);
                var v1 = new decvec4(-0.5m, 5m, 3m, 7m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec4(0.5m, 1.5m, -9m, 8.5m);
                var v1 = new decvec4(4.5m, -4m, -0.5m, -1m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec4(-7m, -8.5m, 0m, 9.5m);
                var v1 = new decvec4(1m, 3m, 0.5m, -3m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec4(7m, 8m, 9m, 7.5m);
                var v1 = new decvec4(3m, -7m, 2m, 5.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec4(9.5m, -1.5m, -8.5m, -3m);
                var v1 = new decvec4(-6.5m, -7m, 7m, -1m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec4(-7m, 4.5m, 1m, 1m);
                var v1 = new decvec4(-2.5m, 7m, 8.5m, 7.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec4(-0.5m, -5m, 9.5m, 0.5m);
                var v1 = new decvec4(1m, 5m, 2.5m, -4.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec4(4m, -0.5m, 8m, -8.5m);
                var v1 = new decvec4(6.5m, 6m, 4m, -4m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec4(-0.5m, -6.5m, 8.5m, 6m);
                var v1 = new decvec4(3.5m, -6m, -2.5m, 0m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new decvec4(0m, 8.5m, 9.5m, -3.5m);
                var v1 = new decvec4(9m, -3.5m, -2m, 4.5m);
                var v2 = new decvec4(-6.5m, -8m, -7m, 7.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec4(0.5m, -1m, -2.5m, -4.5m);
                var v1 = new decvec4(-1.5m, -5.5m, 4m, 7.5m);
                var v2 = new decvec4(-1.5m, 4.5m, -1.5m, -6.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec4(-8.5m, 3.5m, 4.5m, -6.5m);
                var v1 = new decvec4(1.5m, -9.5m, 9.5m, 1.5m);
                var v2 = new decvec4(-3m, -7m, 5.5m, -3m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec4(-5m, 1.5m, -4.5m, 5.5m);
                var v1 = new decvec4(7m, 3.5m, -5m, -7m);
                var v2 = new decvec4(-5m, 3.5m, 2m, -9.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec4(5.5m, 5.5m, 7m, -1.5m);
                var v1 = new decvec4(8.5m, 6m, 6.5m, 6m);
                var v2 = new decvec4(-1m, -6m, 4m, -7m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec4(2.5m, -0.5m, 3m, 2m);
                var v1 = new decvec4(-8m, -3.5m, -5.5m, -3m);
                var v2 = new decvec4(-5m, -4m, -1m, 6.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec4(8.5m, 9m, 0.5m, 5.5m);
                var v1 = new decvec4(-9.5m, -1m, 8m, -2.5m);
                var v2 = new decvec4(1.5m, -4m, -1.5m, 6.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec4(-2m, -1m, 2.5m, 6m);
                var v1 = new decvec4(-8.5m, -0.5m, 1m, 8.5m);
                var v2 = new decvec4(-3.5m, 8m, 3m, -9m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec4(0.5m, -2m, 8.5m, -0.5m);
                var v1 = new decvec4(9m, -0.5m, 4m, -8.5m);
                var v2 = new decvec4(-5.5m, -2m, 0.5m, -0.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec4(-7m, 1m, -3.5m, 9.5m);
                var v1 = new decvec4(7m, -8m, -4.5m, -8m);
                var v2 = new decvec4(0m, 6m, 1.5m, 6m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new decvec4(8.5m, -6m, 9m, -0.5m);
                var v1 = new decvec4(0.5m, 0.5m, 5m, -3.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec4(0.5m, 2m, -1.5m, -0.5m);
                var v1 = new decvec4(5.5m, -0.5m, -1m, -8.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec4(-4.5m, 3m, 0m, 7m);
                var v1 = new decvec4(5m, -9.5m, 8.5m, -5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec4(0m, -6.5m, 8m, -2.5m);
                var v1 = new decvec4(4.5m, -1.5m, 9.5m, -5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec4(8m, -9m, -0.5m, 8.5m);
                var v1 = new decvec4(0.5m, -8m, 8.5m, -2m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec4(3.5m, -1m, -9m, -5m);
                var v1 = new decvec4(-2m, -3.5m, -8.5m, -7m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec4(-5.5m, -8m, -7.5m, -8.5m);
                var v1 = new decvec4(0.5m, -6m, -4m, -9m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec4(-7m, 5.5m, -0.5m, 7m);
                var v1 = new decvec4(-7.5m, -8m, 2.5m, 2m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec4(2m, -4m, -9.5m, -7m);
                var v1 = new decvec4(9.5m, -2m, 1.5m, 6m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec4(5m, -0.5m, -5m, 5.5m);
                var v1 = new decvec4(0m, -6.5m, 2m, -5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new decvec4(5m, 6.5m, -2m, -5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec4(3m, 1m, -8.5m, -5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec4(0.5m, 6.5m, -3.5m, 1m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec4(-2.5m, -0.5m, 1m, 5.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec4(-8m, 0.5m, -4.5m, -2m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec4(0m, -4.5m, -0.5m, 9m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec4(-5m, 1.5m, 9.5m, -3.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec4(7.5m, 3.5m, -2.5m, -0.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec4(2.5m, -7.5m, 4m, 7.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec4(2m, 1m, -1.5m, -6.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1108112915);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.Random(random, -2, 0);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            Assert.AreEqual(avg.z, -1, 1.0);
            Assert.AreEqual(avg.w, -1, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1826680917);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomUniform(random, 4, 8);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 6, 1.0);
            Assert.AreEqual(avg.y, 6, 1.0);
            Assert.AreEqual(avg.z, 6, 1.0);
            Assert.AreEqual(avg.w, 6, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(397765272);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.Random(random, 0, 4);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            Assert.AreEqual(avg.z, 2, 1.0);
            Assert.AreEqual(avg.w, 2, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1116333274);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomUniform(random, -5, -4);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -4.5, 1.0);
            Assert.AreEqual(avg.y, -4.5, 1.0);
            Assert.AreEqual(avg.z, -4.5, 1.0);
            Assert.AreEqual(avg.w, -4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(381324554);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.Random(random, 0, 1);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            Assert.AreEqual(avg.z, 0.5, 1.0);
            Assert.AreEqual(avg.w, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(965104944);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomNormal(random, 1.66036205722967m, 3.66762384943088m);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.66036205722967, 1.0);
            Assert.AreEqual(avg.y, 1.66036205722967, 1.0);
            Assert.AreEqual(avg.z, 1.66036205722967, 1.0);
            Assert.AreEqual(avg.w, 1.66036205722967, 1.0);
            
            Assert.AreEqual(variance.x, 3.66762384943088, 3.0);
            Assert.AreEqual(variance.y, 3.66762384943088, 3.0);
            Assert.AreEqual(variance.z, 3.66762384943088, 3.0);
            Assert.AreEqual(variance.w, 3.66762384943088, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(1989761762);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomGaussian(random, -1.73038052382431m, 9.49366517341401m);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.73038052382431, 1.0);
            Assert.AreEqual(avg.y, -1.73038052382431, 1.0);
            Assert.AreEqual(avg.z, -1.73038052382431, 1.0);
            Assert.AreEqual(avg.w, -1.73038052382431, 1.0);
            
            Assert.AreEqual(variance.x, 9.49366517341401, 3.0);
            Assert.AreEqual(variance.y, 9.49366517341401, 3.0);
            Assert.AreEqual(variance.z, 9.49366517341401, 3.0);
            Assert.AreEqual(variance.w, 9.49366517341401, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(431567264);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomNormal(random, 0.261834583367144m, 4.25481633946989m);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.261834583367144, 1.0);
            Assert.AreEqual(avg.y, 0.261834583367144, 1.0);
            Assert.AreEqual(avg.z, 0.261834583367144, 1.0);
            Assert.AreEqual(avg.w, 0.261834583367144, 1.0);
            
            Assert.AreEqual(variance.x, 4.25481633946989, 3.0);
            Assert.AreEqual(variance.y, 4.25481633946989, 3.0);
            Assert.AreEqual(variance.z, 4.25481633946989, 3.0);
            Assert.AreEqual(variance.w, 4.25481633946989, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(267242878);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomGaussian(random, -1.36937002435763m, 3.07049297404964m);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.36937002435763, 1.0);
            Assert.AreEqual(avg.y, -1.36937002435763, 1.0);
            Assert.AreEqual(avg.z, -1.36937002435763, 1.0);
            Assert.AreEqual(avg.w, -1.36937002435763, 1.0);
            
            Assert.AreEqual(variance.x, 3.07049297404964, 3.0);
            Assert.AreEqual(variance.y, 3.07049297404964, 3.0);
            Assert.AreEqual(variance.z, 3.07049297404964, 3.0);
            Assert.AreEqual(variance.w, 3.07049297404964, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1400472613);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomNormal(random, -1.37651884154255m, 1.45852072697995m);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.37651884154255, 1.0);
            Assert.AreEqual(avg.y, -1.37651884154255, 1.0);
            Assert.AreEqual(avg.z, -1.37651884154255, 1.0);
            Assert.AreEqual(avg.w, -1.37651884154255, 1.0);
            
            Assert.AreEqual(variance.x, 1.45852072697995, 3.0);
            Assert.AreEqual(variance.y, 1.45852072697995, 3.0);
            Assert.AreEqual(variance.z, 1.45852072697995, 3.0);
            Assert.AreEqual(variance.w, 1.45852072697995, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(437358715);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomNormal(random);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal1()
        {
            var random = new Random(1559258534);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomNormal(random);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal2()
        {
            var random = new Random(533674706);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomNormal(random);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal3()
        {
            var random = new Random(1655574525);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomNormal(random);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

        [Test]
        public void RandomNormal4()
        {
            var random = new Random(244726733);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec4.RandomNormal(random);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
            Assert.AreEqual(variance.w, 1, 3.0);
        }

    }
}
