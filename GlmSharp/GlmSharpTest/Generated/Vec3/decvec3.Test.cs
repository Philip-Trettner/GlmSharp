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

namespace GlmSharpTest.Generated.Vec3
{
    [TestFixture]
    public class DecimalVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new decvec3(2m);
                Assert.AreEqual(2m, v.x);
                Assert.AreEqual(2m, v.y);
                Assert.AreEqual(2m, v.z);
            }
            {
                var v = new decvec3(-0.5m, 5m, 0m);
                Assert.AreEqual(-0.5m, v.x);
                Assert.AreEqual(5m, v.y);
                Assert.AreEqual(0m, v.z);
            }
            {
                var v = new decvec3(new decvec2(7m, 6m));
                Assert.AreEqual(7m, v.x);
                Assert.AreEqual(6m, v.y);
                Assert.AreEqual(0m, v.z);
            }
            {
                var v = new decvec3(new decvec3(2.5m, 7.5m, -8m));
                Assert.AreEqual(2.5m, v.x);
                Assert.AreEqual(7.5m, v.y);
                Assert.AreEqual(-8m, v.z);
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
            var v = new decvec3(-8m, 6.5m, -6m);
            Assert.AreEqual(-8m, v[0]);
            Assert.AreEqual(6.5m, v[1]);
            Assert.AreEqual(-6m, v[2]);
            
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
            v[0] = 2m;
            Assert.AreEqual(2m, v[0]);
            v[0] = 3m;
            Assert.AreEqual(3m, v[0]);
            v[2] = 4m;
            Assert.AreEqual(4m, v[2]);
            v[0] = 5m;
            Assert.AreEqual(5m, v[0]);
            v[2] = 6m;
            Assert.AreEqual(6m, v[2]);
            v[1] = 7m;
            Assert.AreEqual(7m, v[1]);
            v[0] = 8m;
            Assert.AreEqual(8m, v[0]);
            v[2] = 9m;
            Assert.AreEqual(9m, v[2]);
            v[1] = -1m;
            Assert.AreEqual(-1m, v[1]);
            v[0] = -2m;
            Assert.AreEqual(-2m, v[0]);
            v[0] = -3m;
            Assert.AreEqual(-3m, v[0]);
            v[1] = -4m;
            Assert.AreEqual(-4m, v[1]);
            v[2] = -5m;
            Assert.AreEqual(-5m, v[2]);
            v[1] = -6m;
            Assert.AreEqual(-6m, v[1]);
            v[0] = -7m;
            Assert.AreEqual(-7m, v[0]);
            v[1] = -8m;
            Assert.AreEqual(-8m, v[1]);
            v[1] = -9m;
            Assert.AreEqual(-9m, v[1]);
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
            var v = new decvec3(-7m, 7m, 0.5m);
            var vals = v.Values;
            Assert.AreEqual(-7m, vals[0]);
            Assert.AreEqual(7m, vals[1]);
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
            var v1 = new decvec3(-4.5m, 4.5m, 6m);
            var v2 = new decvec3(-4.5m, 4.5m, 6m);
            var v3 = new decvec3(6m, 4.5m, -4.5m);
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
            var v = new decvec3(-8.5m, 1m, -1m);
            
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

        [Test]
        public void SerializationJson()
        {
            var v0 = new decvec3(-7m, 0m, -1m);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<decvec3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new decvec3(0m, -1m, 3m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-0.5m, -0.5m, 0.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(4.5m, 2m, 4.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-5m, 9m, 0m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(0m, 8.5m, 6m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-7m, -6.5m, 4m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(3m, -4m, 7.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-2.5m, 1.5m, -6.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-5m, 6m, -9m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec3(-6.5m, -5.5m, 3m);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new decvec3(3m, 4.5m, -5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-5m, -7m, -2m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-6m, -2.5m, 8.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-9.5m, -7.5m, -9.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(7m, -3.5m, -6.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(6m, 9.5m, -4.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-2m, -2.5m, -5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-9m, 5m, 4.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(5.5m, -5m, -9.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec3(-8.5m, -7m, 7.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new decvec3(1.5m, -5m, 3m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-3.5m, -9.5m, -7.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-8.5m, -1.5m, -6.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-1m, -8m, 3.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-2.5m, -2.5m, -1.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-2m, -4.5m, -9.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(6m, -3m, 0m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(7m, -2m, 0.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(0.5m, 7.5m, -4m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec3(-9.5m, -3m, 3.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new decvec3(-3.5m, -3m, -7m);
                var v1 = new decvec3(5.5m, -9m, -3m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(1.5m, -8m, -3m);
                var v1 = new decvec3(1m, 7.5m, 2m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-5m, 1.5m, 5m);
                var v1 = new decvec3(-4m, 1m, 7m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-9.5m, -3.5m, -2m);
                var v1 = new decvec3(8.5m, 0.5m, -1m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(4m, -3m, -9m);
                var v1 = new decvec3(-2m, -8m, 9.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-1m, 0m, -1.5m);
                var v1 = new decvec3(8.5m, -9.5m, -4.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-3m, 9m, -3m);
                var v1 = new decvec3(8m, -7m, -7m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-6m, 4.5m, -5m);
                var v1 = new decvec3(-9.5m, 4m, -5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(-2m, 0m, 8m);
                var v1 = new decvec3(-1.5m, -3m, 1m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec3(9.5m, -2.5m, -7.5m);
                var v1 = new decvec3(6m, 1.5m, 5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new decvec3(5.5m, -8.5m, -9.5m);
                var v1 = new decvec3(6m, 4m, 5.5m);
                var v2 = new decvec3(8.5m, -6m, -5.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(7.5m, 5m, 1.5m);
                var v1 = new decvec3(4m, -4.5m, -7m);
                var v2 = new decvec3(-0.5m, 2.5m, -3.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-3m, 4m, -6m);
                var v1 = new decvec3(2.5m, 6.5m, 2m);
                var v2 = new decvec3(-6.5m, -4.5m, -6.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(3.5m, -0.5m, 9m);
                var v1 = new decvec3(-8.5m, -4.5m, 6.5m);
                var v2 = new decvec3(-1.5m, -4.5m, 6.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(3.5m, 4.5m, -9.5m);
                var v1 = new decvec3(-8.5m, 4m, 5m);
                var v2 = new decvec3(3m, -8.5m, 2m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-4.5m, 1.5m, 4.5m);
                var v1 = new decvec3(-6m, -5.5m, -3.5m);
                var v2 = new decvec3(-2m, -1.5m, -6.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-4m, 3m, -4.5m);
                var v1 = new decvec3(-7m, -5.5m, -9.5m);
                var v2 = new decvec3(-3m, 4m, -2.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-4m, -6m, -8.5m);
                var v1 = new decvec3(4.5m, -7m, 9.5m);
                var v2 = new decvec3(-8.5m, 6.5m, 7.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(5m, 2.5m, 9.5m);
                var v1 = new decvec3(-1m, -1.5m, -5m);
                var v2 = new decvec3(0m, 7.5m, 4.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec3(-0.5m, -8m, 4m);
                var v1 = new decvec3(-5.5m, 9m, 6.5m);
                var v2 = new decvec3(-3m, -4m, -7.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new decvec3(4.5m, 4.5m, -5.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(9m, 3.5m, 6m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-7.5m, -3.5m, -6m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(7m, -2m, -2m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-6m, 7.5m, 2m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(6.5m, 6.5m, -1.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-1.5m, -5.5m, 5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-9.5m, -3.5m, 1.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(4.5m, -5.5m, -5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec3(-8.5m, -3m, -5.5m);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new decvec3(-1.5m, -1m, 8m);
                var v1 = new decvec3(4m, -6m, 3m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-1.5m, -7m, -1.5m);
                var v1 = new decvec3(-5.5m, -5.5m, -4m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(8.5m, 2.5m, -6.5m);
                var v1 = new decvec3(-8.5m, -2.5m, -3m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-2m, -5m, 5m);
                var v1 = new decvec3(0m, 4.5m, -6m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-7m, -9m, -4m);
                var v1 = new decvec3(-8.5m, 0.5m, -5.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-0.5m, 2m, 2.5m);
                var v1 = new decvec3(0.5m, 0.5m, -1m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(7.5m, -8m, -6m);
                var v1 = new decvec3(-0.5m, -8m, 7m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(2.5m, -3.5m, -9.5m);
                var v1 = new decvec3(-3m, -0.5m, -7m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(9.5m, -7.5m, -0.5m);
                var v1 = new decvec3(0m, -5m, 3m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec3(-1.5m, -1.5m, -7m);
                var v1 = new decvec3(2.5m, -1.5m, 7.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new decvec3(-6.5m, 6m, -5m);
                var v1 = new decvec3(8.5m, 5m, -5.5m);
                var v2 = new decvec3(-0.5m, -1m, -5.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(-1.5m, 5.5m, 0m);
                var v1 = new decvec3(-8.5m, -6.5m, 6m);
                var v2 = new decvec3(-3m, 1.5m, 2m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(-2m, -8.5m, -8m);
                var v1 = new decvec3(7m, -6.5m, -8m);
                var v2 = new decvec3(-8.5m, 5.5m, -9.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(1m, 1m, 9.5m);
                var v1 = new decvec3(0m, 1m, -1.5m);
                var v2 = new decvec3(5.5m, -4m, 8.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(-8.5m, 0.5m, -2m);
                var v1 = new decvec3(2m, -0.5m, -4m);
                var v2 = new decvec3(3m, 4m, -9m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(7.5m, -8.5m, -4m);
                var v1 = new decvec3(-3m, 6m, -9.5m);
                var v2 = new decvec3(-0.5m, -2m, -2m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(7m, -6m, -6.5m);
                var v1 = new decvec3(7.5m, -7m, 9m);
                var v2 = new decvec3(3m, -1.5m, 8m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(-5.5m, -1.5m, 3.5m);
                var v1 = new decvec3(-2m, -4.5m, 9m);
                var v2 = new decvec3(8m, 1.5m, 1m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(0.5m, 9m, 1.5m);
                var v1 = new decvec3(3m, 4m, -9m);
                var v2 = new decvec3(8.5m, -5.5m, -5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec3(6m, -1.5m, 5.5m);
                var v1 = new decvec3(-9.5m, -1m, 0.5m);
                var v2 = new decvec3(-7m, -1.5m, 8.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new decvec3(-4m, -7m, -4.5m);
                var v1 = new decvec3(3.5m, -8.5m, -7.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(5.5m, -4m, -1m);
                var v1 = new decvec3(1m, -9m, -1m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(-3m, -8m, 6.5m);
                var v1 = new decvec3(-1m, -4.5m, 2m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(2.5m, 2.5m, -7m);
                var v1 = new decvec3(8.5m, -3.5m, -8m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(6.5m, -6.5m, -8m);
                var v1 = new decvec3(-4m, 4m, -1.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(-2.5m, -8m, 5m);
                var v1 = new decvec3(0.5m, -9m, 1.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(3.5m, -8m, 5m);
                var v1 = new decvec3(-4m, -2m, 9.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(0.5m, -4m, 1m);
                var v1 = new decvec3(9.5m, -8m, 1.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(0m, 6.5m, 5m);
                var v1 = new decvec3(-1m, 9.5m, 0m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec3(9.5m, -6m, 0.5m);
                var v1 = new decvec3(6m, 6.5m, 7.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new decvec3(-1.5m, 3m, -2.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(-2.5m, 9.5m, 9.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(7.5m, 2.5m, 0.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(7m, 3m, 4m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(-8m, 2m, -7.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(-6.5m, -8.5m, 8m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(2.5m, 5.5m, -0.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(8.5m, -5.5m, 3m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(-6m, 3.5m, -4.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec3(3m, 7m, -3m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new decvec3(7m, -1m, -4m);
                var v1 = new decvec3(-0.5m, 1m, 6m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(2.5m, -4m, 1.5m);
                var v1 = new decvec3(3m, 5.5m, 4m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-7.5m, -8m, -1.5m);
                var v1 = new decvec3(9m, 5.5m, 1.5m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(9m, 4m, 8m);
                var v1 = new decvec3(8m, -0.5m, 9m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(4.5m, 1.5m, -2m);
                var v1 = new decvec3(1.5m, -5m, 4m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-7m, -2m, -3m);
                var v1 = new decvec3(-7m, -3m, -5m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-9.5m, -9m, -3m);
                var v1 = new decvec3(-4.5m, 8m, 2m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(5m, -6.5m, 5.5m);
                var v1 = new decvec3(-4m, 1m, 3.5m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-6.5m, -5.5m, -5m);
                var v1 = new decvec3(-4m, -6.5m, 2m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new decvec3(-9.5m, 8.5m, -8.5m);
                var v1 = new decvec3(4m, 4.5m, 9m);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(2032154041);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.Random(random, 3, 4);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            Assert.AreEqual(avg.z, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(603238396);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomUniform(random, 2, 4);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            Assert.AreEqual(avg.z, 3, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1321806398);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.Random(random, -2, 1);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5, 1.0);
            Assert.AreEqual(avg.y, -0.5, 1.0);
            Assert.AreEqual(avg.z, -0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(2040374400);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomUniform(random, 3, 6);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            Assert.AreEqual(avg.z, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1305365680);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.Random(random, -2, 2);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(1889146070);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomNormal(random, 0.885999286028556m, 9.67327389385238m);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.885999286028556, 1.0);
            Assert.AreEqual(avg.y, 0.885999286028556, 1.0);
            Assert.AreEqual(avg.z, 0.885999286028556, 1.0);
            
            Assert.AreEqual(variance.x, 9.67327389385238, 3.0);
            Assert.AreEqual(variance.y, 9.67327389385238, 3.0);
            Assert.AreEqual(variance.z, 9.67327389385238, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(2053470456);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomGaussian(random, 1.49525670497457m, 5.49931524577519m);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.49525670497457, 1.0);
            Assert.AreEqual(avg.y, 1.49525670497457, 1.0);
            Assert.AreEqual(avg.z, 1.49525670497457, 1.0);
            
            Assert.AreEqual(variance.x, 5.49931524577519, 3.0);
            Assert.AreEqual(variance.y, 5.49931524577519, 3.0);
            Assert.AreEqual(variance.z, 5.49931524577519, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(1464181307);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomNormal(random, 1.50240552215949m, 7.11128749284488m);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.50240552215949, 1.0);
            Assert.AreEqual(avg.y, 1.50240552215949, 1.0);
            Assert.AreEqual(avg.z, 1.50240552215949, 1.0);
            
            Assert.AreEqual(variance.x, 7.11128749284488, 3.0);
            Assert.AreEqual(variance.y, 7.11128749284488, 3.0);
            Assert.AreEqual(variance.z, 7.11128749284488, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(1490685399);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomGaussian(random, -0.866389870115737m, 8.29561085826513m);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.866389870115737, 1.0);
            Assert.AreEqual(avg.y, -0.866389870115737, 1.0);
            Assert.AreEqual(avg.z, -0.866389870115737, 1.0);
            
            Assert.AreEqual(variance.x, 8.29561085826513, 3.0);
            Assert.AreEqual(variance.y, 8.29561085826513, 3.0);
            Assert.AreEqual(variance.z, 8.29561085826513, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(476431487);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomNormal(random, -0.602156070341429m, 5.45287065461877m);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.602156070341429, 1.0);
            Assert.AreEqual(avg.y, -0.602156070341429, 1.0);
            Assert.AreEqual(avg.z, -0.602156070341429, 1.0);
            
            Assert.AreEqual(variance.x, 5.45287065461877, 3.0);
            Assert.AreEqual(variance.y, 5.45287065461877, 3.0);
            Assert.AreEqual(variance.z, 5.45287065461877, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(1361399841);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomNormal(random);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal1()
        {
            var random = new Random(335816013);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomNormal(random);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal2()
        {
            var random = new Random(1457715832);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomNormal(random);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal3()
        {
            var random = new Random(432132004);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomNormal(random);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

        [Test]
        public void RandomNormal4()
        {
            var random = new Random(1168767859);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec3.RandomNormal(random);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
            Assert.AreEqual(variance.z, 1, 3.0);
        }

    }
}
