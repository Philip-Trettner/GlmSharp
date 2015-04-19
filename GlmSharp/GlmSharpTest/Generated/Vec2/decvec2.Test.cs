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
                var v = new decvec2(9m, -8.5m);
                Assert.AreEqual(9m, v.x);
                Assert.AreEqual(-8.5m, v.y);
            }
            {
                var v = new decvec2(new decvec2(-9.5m, -5m));
                Assert.AreEqual(-9.5m, v.x);
                Assert.AreEqual(-5m, v.y);
            }
            {
                var v = new decvec2(new decvec3(-3.5m, -6m, -3m));
                Assert.AreEqual(-3.5m, v.x);
                Assert.AreEqual(-6m, v.y);
            }
            {
                var v = new decvec2(new decvec4(4.5m, 5m, 8.5m, -8.5m));
                Assert.AreEqual(4.5m, v.x);
                Assert.AreEqual(5m, v.y);
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
            v[0] = 2m;
            Assert.AreEqual(2m, v[0]);
            v[0] = 3m;
            Assert.AreEqual(3m, v[0]);
            v[0] = 4m;
            Assert.AreEqual(4m, v[0]);
            v[0] = 5m;
            Assert.AreEqual(5m, v[0]);
            v[0] = 6m;
            Assert.AreEqual(6m, v[0]);
            v[1] = 7m;
            Assert.AreEqual(7m, v[1]);
            v[1] = 8m;
            Assert.AreEqual(8m, v[1]);
            v[0] = 9m;
            Assert.AreEqual(9m, v[0]);
            v[1] = -1m;
            Assert.AreEqual(-1m, v[1]);
            v[0] = -2m;
            Assert.AreEqual(-2m, v[0]);
            v[1] = -3m;
            Assert.AreEqual(-3m, v[1]);
            v[0] = -4m;
            Assert.AreEqual(-4m, v[0]);
            v[0] = -5m;
            Assert.AreEqual(-5m, v[0]);
            v[1] = -6m;
            Assert.AreEqual(-6m, v[1]);
            v[0] = -7m;
            Assert.AreEqual(-7m, v[0]);
            v[0] = -8m;
            Assert.AreEqual(-8m, v[0]);
            v[1] = -9m;
            Assert.AreEqual(-9m, v[1]);
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

        [Test]
        public void PropertyValues()
        {
            var v = new decvec2(-1m, -2.5m);
            var vals = v.Values;
            Assert.AreEqual(-1m, vals[0]);
            Assert.AreEqual(-2.5m, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0m, decvec2.Zero.x);
            Assert.AreEqual(0m, decvec2.Zero.y);
            
            Assert.AreEqual(1m, decvec2.Ones.x);
            Assert.AreEqual(1m, decvec2.Ones.y);
            
            Assert.AreEqual(1m, decvec2.UnitX.x);
            Assert.AreEqual(0m, decvec2.UnitX.y);
            
            Assert.AreEqual(0m, decvec2.UnitY.x);
            Assert.AreEqual(1m, decvec2.UnitY.y);
            
            Assert.AreEqual(decimal.MaxValue, decvec2.MaxValue.x);
            Assert.AreEqual(decimal.MaxValue, decvec2.MaxValue.y);
            
            Assert.AreEqual(decimal.MinValue, decvec2.MinValue.x);
            Assert.AreEqual(decimal.MinValue, decvec2.MinValue.y);
            
            Assert.AreEqual(decimal.MinusOne, decvec2.MinusOne.x);
            Assert.AreEqual(decimal.MinusOne, decvec2.MinusOne.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new decvec2(0.5m, -4m);
            var v2 = new decvec2(0.5m, -4m);
            var v3 = new decvec2(-4m, 0.5m);
            Assert.That(v1 == new decvec2(v1));
            Assert.That(v2 == new decvec2(v2));
            Assert.That(v3 == new decvec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new decvec2(2m, 3m);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = decvec2.Parse(s0);
            var v1 = decvec2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = decvec2.TryParse(s0, out v0);
            var b1 = decvec2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = decvec2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = decvec2.TryParse("", out v0);
            Assert.False(b0);
            b0 = decvec2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { decvec2.Parse(null); });
            Assert.Throws<FormatException>(() => { decvec2.Parse(""); });
            Assert.Throws<FormatException>(() => { decvec2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = decvec2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = decvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = decvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new decvec2(-2m, -8.5m);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<decvec2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new decvec2(5m, 1.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec2(-1.5m, 9m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec2(-7.5m, -1m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec2(-2m, -2.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec2(-8m, 2.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec2(-2m, 0m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec2(7m, 6m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec2(-3.5m, -2m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec2(-3.5m, 6.5m);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new decvec2(6.5m, -2m);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new decvec2(8.5m, -5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec2(0.5m, 4.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec2(-5.5m, 0.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec2(9.5m, 1m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec2(-5m, 2m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec2(-9.5m, -9.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec2(0m, -9m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec2(4m, -1m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec2(5.5m, 3.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new decvec2(-9m, -0.5m);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new decvec2(-6.5m, -4m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec2(8m, -5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec2(9.5m, 2.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec2(0.5m, -7.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec2(1m, -6.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec2(-7.5m, -3.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec2(1.5m, 4m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec2(7m, 5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec2(4.5m, 6.5m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new decvec2(-6m, 4m);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new decvec2(-2m, 2m);
                var v1 = new decvec2(8.5m, 5.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec2(-7.5m, 5.5m);
                var v1 = new decvec2(-4.5m, 7.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec2(2m, -9.5m);
                var v1 = new decvec2(9.5m, 1.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec2(5.5m, 0.5m);
                var v1 = new decvec2(8m, -8m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec2(-8m, -3.5m);
                var v1 = new decvec2(-5m, 2m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec2(-8.5m, 2m);
                var v1 = new decvec2(3.5m, -3m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec2(8.5m, 6m);
                var v1 = new decvec2(-7m, -6m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec2(3.5m, -4m);
                var v1 = new decvec2(9m, -7m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec2(0m, 6.5m);
                var v1 = new decvec2(0.5m, -9.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new decvec2(7m, 1m);
                var v1 = new decvec2(-3m, 0.5m);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new decvec2(-1.5m, -5.5m);
                var v1 = new decvec2(-3.5m, -8m);
                var v2 = new decvec2(4m, -0.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec2(-1m, 4m);
                var v1 = new decvec2(7.5m, 1m);
                var v2 = new decvec2(-9.5m, 5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec2(-3m, -9.5m);
                var v1 = new decvec2(0m, 8m);
                var v2 = new decvec2(0m, 5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec2(4.5m, -9m);
                var v1 = new decvec2(-1.5m, 3.5m);
                var v2 = new decvec2(1m, 2.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec2(-3.5m, -8m);
                var v1 = new decvec2(7.5m, 8m);
                var v2 = new decvec2(-6.5m, 2m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec2(2.5m, -9m);
                var v1 = new decvec2(0m, -8.5m);
                var v2 = new decvec2(-3m, 1.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec2(2.5m, -4.5m);
                var v1 = new decvec2(-3m, 4m);
                var v2 = new decvec2(8m, -5.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec2(8.5m, 4m);
                var v1 = new decvec2(0.5m, -2.5m);
                var v2 = new decvec2(-4.5m, -2m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec2(2m, 2m);
                var v1 = new decvec2(-6.5m, -8m);
                var v2 = new decvec2(-1m, -1.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new decvec2(5.5m, 4.5m);
                var v1 = new decvec2(-7.5m, 4.5m);
                var v2 = new decvec2(1.5m, -3.5m);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new decvec2(-0.5m, -1m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec2(-7.5m, -5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec2(-6m, -9m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec2(-2.5m, 3.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec2(5m, 1.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec2(-4m, -3.5m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec2(1m, 7m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec2(-5m, 1m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec2(6.5m, 3m);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new decvec2(-9m, 9.5m);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new decvec2(-6.5m, 1.5m);
                var v1 = new decvec2(-5.5m, -5.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec2(-6.5m, -6.5m);
                var v1 = new decvec2(-1m, 1.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec2(4m, 6m);
                var v1 = new decvec2(-7.5m, -3m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec2(1.5m, -4.5m);
                var v1 = new decvec2(4m, -4.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec2(-6.5m, -9.5m);
                var v1 = new decvec2(-8m, -7m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec2(-3.5m, 2m);
                var v1 = new decvec2(6.5m, -5.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec2(-6.5m, -8m);
                var v1 = new decvec2(-0.5m, 4.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec2(-7.5m, -7m);
                var v1 = new decvec2(0.5m, 5.5m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec2(-9m, -9.5m);
                var v1 = new decvec2(3m, 4m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new decvec2(-5m, -0.5m);
                var v1 = new decvec2(9m, 0m);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new decvec2(1.5m, -6.5m);
                var v1 = new decvec2(7.5m, 3m);
                var v2 = new decvec2(-4m, 0.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec2(-6.5m, 9.5m);
                var v1 = new decvec2(0m, 5m);
                var v2 = new decvec2(5m, -9m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec2(7.5m, 7m);
                var v1 = new decvec2(-1.5m, 4m);
                var v2 = new decvec2(-1.5m, -4m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec2(-1m, 7.5m);
                var v1 = new decvec2(9.5m, 1m);
                var v2 = new decvec2(2.5m, -8.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec2(9m, -7m);
                var v1 = new decvec2(-8m, 6.5m);
                var v2 = new decvec2(-6m, -5.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec2(5m, 7m);
                var v1 = new decvec2(-4m, 5.5m);
                var v2 = new decvec2(8.5m, -9.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec2(-4.5m, -3.5m);
                var v1 = new decvec2(-6.5m, -2m);
                var v2 = new decvec2(-9m, -3m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec2(-9m, -7.5m);
                var v1 = new decvec2(-6m, -1.5m);
                var v2 = new decvec2(3m, -5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec2(9.5m, -4m);
                var v1 = new decvec2(4m, -2m);
                var v2 = new decvec2(-3.5m, 1.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new decvec2(0.5m, 0.5m);
                var v1 = new decvec2(1.5m, -6m);
                var v2 = new decvec2(3.5m, 7.5m);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new decvec2(6m, -4m);
                var v1 = new decvec2(8.5m, 3m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec2(7.5m, -5m);
                var v1 = new decvec2(-7.5m, -3.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec2(-4.5m, -6m);
                var v1 = new decvec2(-0.5m, 5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec2(5.5m, -8.5m);
                var v1 = new decvec2(9m, 3m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec2(4.5m, -3.5m);
                var v1 = new decvec2(8.5m, 4m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec2(1.5m, 7.5m);
                var v1 = new decvec2(6m, -0.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec2(6.5m, -5m);
                var v1 = new decvec2(-1.5m, 2m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec2(9m, 5.5m);
                var v1 = new decvec2(-7m, -6.5m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec2(0m, 4.5m);
                var v1 = new decvec2(7m, 4m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new decvec2(6.5m, -5.5m);
                var v1 = new decvec2(1.5m, 6m);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new decvec2(3.5m, -6.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec2(-3m, 7m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec2(2.5m, -8.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec2(-4m, -7m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec2(-4m, -4.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec2(5m, 4m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec2(-4.5m, -1m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec2(0m, -8m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec2(-5.5m, 1m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new decvec2(-4.5m, 4.5m);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1743234967);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.Random(random, -3, 1);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(314319322);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomUniform(random, -2, 2);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1032887324);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.Random(random, 3, 7);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5, 1.0);
            Assert.AreEqual(avg.y, 5, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1751455326);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomUniform(random, -2, -1);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1016446606);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.Random(random, 3, 4);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(1600226996);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomNormal(random, -1.07154903331378m, 3.42177232421086m);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.07154903331378, 1.0);
            Assert.AreEqual(avg.y, -1.07154903331378, 1.0);
            
            Assert.AreEqual(variance.x, 3.42177232421086, 3.0);
            Assert.AreEqual(variance.y, 3.42177232421086, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(1354639710);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomGaussian(random, -0.462291614367762m, 9.24781364819399m);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.462291614367762, 1.0);
            Assert.AreEqual(avg.y, -0.462291614367762, 1.0);
            
            Assert.AreEqual(variance.x, 9.24781364819399, 3.0);
            Assert.AreEqual(variance.y, 9.24781364819399, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(1943928859);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomNormal(random, -1.0062543260894m, 4.50066786468991m);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.0062543260894, 1.0);
            Assert.AreEqual(avg.y, -1.0062543260894, 1.0);
            
            Assert.AreEqual(variance.x, 4.50066786468991, 3.0);
            Assert.AreEqual(variance.y, 4.50066786468991, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(1435902610);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomGaussian(random, 1.36254106618582m, 3.31634452720934m);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.36254106618582, 1.0);
            Assert.AreEqual(avg.y, 1.36254106618582, 1.0);
            
            Assert.AreEqual(variance.x, 3.31634452720934, 3.0);
            Assert.AreEqual(variance.y, 3.31634452720934, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(765350561);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomNormal(random, -0.469440431552679m, 7.6358414011243m);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.469440431552679, 1.0);
            Assert.AreEqual(avg.y, -0.469440431552679, 1.0);
            
            Assert.AreEqual(variance.x, 7.6358414011243, 3.0);
            Assert.AreEqual(variance.y, 7.6358414011243, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(2046710325);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomNormal(random);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

        [Test]
        public void RandomNormal1()
        {
            var random = new Random(924810506);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomNormal(random);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

        [Test]
        public void RandomNormal2()
        {
            var random = new Random(1950394334);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomNormal(random);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

        [Test]
        public void RandomNormal3()
        {
            var random = new Random(828494515);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomNormal(random);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

        [Test]
        public void RandomNormal4()
        {
            var random = new Random(91858660);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = decvec2.RandomNormal(random);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1, 3.0);
            Assert.AreEqual(variance.y, 1, 3.0);
        }

    }
}
