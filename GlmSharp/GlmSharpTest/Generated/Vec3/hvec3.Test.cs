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
    public class HalfVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new hvec3(new Half(-3.5));
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-3.5), v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
            }
            {
                var v = new hvec3(new Half(-4.5), new Half(8), new Half(-6.5));
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(8), v.y);
                Assert.AreEqual(new Half(-6.5), v.z);
            }
            {
                var v = new hvec3(new hvec2(new Half(7), new Half(9.5)));
                Assert.AreEqual(new Half(7), v.x);
                Assert.AreEqual(new Half(9.5), v.y);
                Assert.AreEqual(Half.Zero, v.z);
            }
            {
                var v = new hvec3(new hvec3(new Half(-3.5), new Half(-5.5), new Half(2)));
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-5.5), v.y);
                Assert.AreEqual(new Half(2), v.z);
            }
            {
                var v = new hvec3(new hvec4(new Half(-2.5), new Half(3.5), new Half(-4.5), new Half(-0.5)));
                Assert.AreEqual(new Half(-2.5), v.x);
                Assert.AreEqual(new Half(3.5), v.y);
                Assert.AreEqual(new Half(-4.5), v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new hvec3(new Half(1.5), new Half(-6.5), new Half(-1.5));
            Assert.AreEqual(new Half(1.5), v[0]);
            Assert.AreEqual(new Half(-6.5), v[1]);
            Assert.AreEqual(new Half(-1.5), v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = Half.Zero; } );
            
            v[1] = Half.Zero;
            Assert.AreEqual(Half.Zero, v[1]);
            v[0] = Half.One;
            Assert.AreEqual(Half.One, v[0]);
            v[1] = new Half(2);
            Assert.AreEqual(new Half(2), v[1]);
            v[2] = new Half(3);
            Assert.AreEqual(new Half(3), v[2]);
            v[0] = new Half(4);
            Assert.AreEqual(new Half(4), v[0]);
            v[1] = new Half(5);
            Assert.AreEqual(new Half(5), v[1]);
            v[2] = new Half(6);
            Assert.AreEqual(new Half(6), v[2]);
            v[1] = new Half(7);
            Assert.AreEqual(new Half(7), v[1]);
            v[2] = new Half(8);
            Assert.AreEqual(new Half(8), v[2]);
            v[1] = new Half(9);
            Assert.AreEqual(new Half(9), v[1]);
            v[1] = new Half(-1);
            Assert.AreEqual(new Half(-1), v[1]);
            v[0] = new Half(-2);
            Assert.AreEqual(new Half(-2), v[0]);
            v[1] = new Half(-3);
            Assert.AreEqual(new Half(-3), v[1]);
            v[0] = new Half(-4);
            Assert.AreEqual(new Half(-4), v[0]);
            v[0] = new Half(-5);
            Assert.AreEqual(new Half(-5), v[0]);
            v[0] = new Half(-6);
            Assert.AreEqual(new Half(-6), v[0]);
            v[1] = new Half(-7);
            Assert.AreEqual(new Half(-7), v[1]);
            v[0] = new Half(-8);
            Assert.AreEqual(new Half(-8), v[0]);
            v[2] = new Half(-9);
            Assert.AreEqual(new Half(-9), v[2]);
            v[2] = new Half(-9.5);
            Assert.AreEqual(new Half(-9.5), v[2]);
            v[0] = new Half(-8.5);
            Assert.AreEqual(new Half(-8.5), v[0]);
            v[0] = new Half(-7.5);
            Assert.AreEqual(new Half(-7.5), v[0]);
            v[2] = new Half(-6.5);
            Assert.AreEqual(new Half(-6.5), v[2]);
            v[1] = new Half(-5.5);
            Assert.AreEqual(new Half(-5.5), v[1]);
            v[2] = new Half(-4.5);
            Assert.AreEqual(new Half(-4.5), v[2]);
            v[0] = new Half(-3.5);
            Assert.AreEqual(new Half(-3.5), v[0]);
            v[1] = new Half(-2.5);
            Assert.AreEqual(new Half(-2.5), v[1]);
            v[1] = new Half(-1.5);
            Assert.AreEqual(new Half(-1.5), v[1]);
            v[2] = new Half(-0.5);
            Assert.AreEqual(new Half(-0.5), v[2]);
            v[1] = new Half(0.5);
            Assert.AreEqual(new Half(0.5), v[1]);
            v[2] = new Half(1.5);
            Assert.AreEqual(new Half(1.5), v[2]);
            v[0] = new Half(2.5);
            Assert.AreEqual(new Half(2.5), v[0]);
            v[0] = new Half(3.5);
            Assert.AreEqual(new Half(3.5), v[0]);
            v[1] = new Half(4.5);
            Assert.AreEqual(new Half(4.5), v[1]);
            v[0] = new Half(5.5);
            Assert.AreEqual(new Half(5.5), v[0]);
            v[2] = new Half(6.5);
            Assert.AreEqual(new Half(6.5), v[2]);
            v[2] = new Half(7.5);
            Assert.AreEqual(new Half(7.5), v[2]);
            v[0] = new Half(8.5);
            Assert.AreEqual(new Half(8.5), v[0]);
            v[0] = new Half(9.5);
            Assert.AreEqual(new Half(9.5), v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new hvec3(new Half(-2), new Half(7), new Half(-5.5));
            var vals = v.Values;
            Assert.AreEqual(new Half(-2), vals[0]);
            Assert.AreEqual(new Half(7), vals[1]);
            Assert.AreEqual(new Half(-5.5), vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(Half.Zero, hvec3.Zero.x);
            Assert.AreEqual(Half.Zero, hvec3.Zero.y);
            Assert.AreEqual(Half.Zero, hvec3.Zero.z);
            
            Assert.AreEqual(Half.One, hvec3.Ones.x);
            Assert.AreEqual(Half.One, hvec3.Ones.y);
            Assert.AreEqual(Half.One, hvec3.Ones.z);
            
            Assert.AreEqual(Half.One, hvec3.UnitX.x);
            Assert.AreEqual(Half.Zero, hvec3.UnitX.y);
            Assert.AreEqual(Half.Zero, hvec3.UnitX.z);
            
            Assert.AreEqual(Half.Zero, hvec3.UnitY.x);
            Assert.AreEqual(Half.One, hvec3.UnitY.y);
            Assert.AreEqual(Half.Zero, hvec3.UnitY.z);
            
            Assert.AreEqual(Half.Zero, hvec3.UnitZ.x);
            Assert.AreEqual(Half.Zero, hvec3.UnitZ.y);
            Assert.AreEqual(Half.One, hvec3.UnitZ.z);
            
            Assert.AreEqual(Half.MaxValue, hvec3.MaxValue.x);
            Assert.AreEqual(Half.MaxValue, hvec3.MaxValue.y);
            Assert.AreEqual(Half.MaxValue, hvec3.MaxValue.z);
            
            Assert.AreEqual(Half.MinValue, hvec3.MinValue.x);
            Assert.AreEqual(Half.MinValue, hvec3.MinValue.y);
            Assert.AreEqual(Half.MinValue, hvec3.MinValue.z);
            
            Assert.AreEqual(Half.Epsilon, hvec3.Epsilon.x);
            Assert.AreEqual(Half.Epsilon, hvec3.Epsilon.y);
            Assert.AreEqual(Half.Epsilon, hvec3.Epsilon.z);
            
            Assert.AreEqual(Half.NaN, hvec3.NaN.x);
            Assert.AreEqual(Half.NaN, hvec3.NaN.y);
            Assert.AreEqual(Half.NaN, hvec3.NaN.z);
            
            Assert.AreEqual(Half.NegativeInfinity, hvec3.NegativeInfinity.x);
            Assert.AreEqual(Half.NegativeInfinity, hvec3.NegativeInfinity.y);
            Assert.AreEqual(Half.NegativeInfinity, hvec3.NegativeInfinity.z);
            
            Assert.AreEqual(Half.PositiveInfinity, hvec3.PositiveInfinity.x);
            Assert.AreEqual(Half.PositiveInfinity, hvec3.PositiveInfinity.y);
            Assert.AreEqual(Half.PositiveInfinity, hvec3.PositiveInfinity.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new hvec3(new Half(-4.5), new Half(-4.5), new Half(7.5));
            var v2 = new hvec3(new Half(-4.5), new Half(-4.5), new Half(7.5));
            var v3 = new hvec3(new Half(7.5), new Half(-4.5), new Half(-4.5));
            Assert.That(v1 == new hvec3(v1));
            Assert.That(v2 == new hvec3(v2));
            Assert.That(v3 == new hvec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new hvec3(new Half(7), new Half(-3), new Half(3));
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = hvec3.Parse(s0);
            var v1 = hvec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = hvec3.TryParse(s0, out v0);
            var b1 = hvec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = hvec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = hvec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = hvec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { hvec3.Parse(null); });
            Assert.Throws<FormatException>(() => { hvec3.Parse(""); });
            Assert.Throws<FormatException>(() => { hvec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = hvec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = hvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = hvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new hvec3(new Half(-2), new Half(-4), new Half(3));
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<hvec3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new hvec3(new Half(8), new Half(8), Half.One);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec3(new Half(-4), new Half(-4.5), new Half(2));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec3(new Half(7), new Half(6), new Half(0.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec3(new Half(7), new Half(-7.5), new Half(9));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec3(new Half(-9), new Half(2), new Half(-5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec3(new Half(9.5), Half.One, new Half(1.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec3(new Half(-7), new Half(3), new Half(-6.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec3(new Half(-5.5), new Half(8.5), Half.One);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec3(new Half(-7.5), new Half(-3), new Half(-9));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec3(Half.One, new Half(2.5), new Half(8.5));
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new hvec3(new Half(-5.5), new Half(-9.5), new Half(9.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec3(new Half(7), new Half(7.5), new Half(5.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec3(new Half(2), new Half(5.5), new Half(-7.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec3(new Half(0.5), new Half(-2), new Half(-2.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec3(new Half(8), new Half(8), new Half(7));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec3(new Half(2.5), new Half(-1.5), new Half(-1.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec3(new Half(8.5), new Half(6.5), new Half(-3.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec3(new Half(6), new Half(-7), new Half(-4));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec3(new Half(7), new Half(-8.5), Half.Zero);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec3(new Half(4.5), new Half(6.5), new Half(7.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new hvec3(new Half(-8), new Half(4), Half.One);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec3(new Half(-7), new Half(4.5), new Half(-2));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec3(new Half(-8.5), new Half(-8.5), new Half(2));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec3(new Half(-2), new Half(-4), new Half(-7));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec3(new Half(2.5), new Half(-5), new Half(3.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec3(new Half(4), new Half(9.5), new Half(-5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec3(new Half(-4), new Half(4), new Half(-9));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec3(new Half(3), new Half(-8), new Half(4.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec3(new Half(5), new Half(-6.5), new Half(-5.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec3(new Half(3), new Half(3), new Half(8));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new hvec3(new Half(8), new Half(5), new Half(-6));
                var v1 = new hvec3(new Half(-2.5), new Half(-3), new Half(0.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec3(new Half(-5.5), new Half(-1.5), new Half(-6.5));
                var v1 = new hvec3(new Half(6), new Half(-8.5), new Half(-0.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec3(new Half(0.5), new Half(6.5), new Half(0.5));
                var v1 = new hvec3(new Half(0.5), new Half(3), new Half(-4.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec3(new Half(-2), new Half(-3), new Half(5));
                var v1 = new hvec3(new Half(9.5), new Half(2), new Half(-8.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec3(new Half(3.5), new Half(8), new Half(8));
                var v1 = new hvec3(new Half(-3.5), new Half(-7), new Half(6));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec3(new Half(-3), new Half(-9), new Half(7.5));
                var v1 = new hvec3(new Half(7.5), new Half(-8), new Half(-8));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec3(new Half(9), new Half(-2), new Half(2.5));
                var v1 = new hvec3(new Half(-9.5), new Half(6), new Half(-9.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec3(new Half(-1.5), new Half(0.5), new Half(1.5));
                var v1 = new hvec3(new Half(3.5), new Half(9.5), new Half(7.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec3(new Half(-0.5), new Half(-3), new Half(-4.5));
                var v1 = new hvec3(new Half(8), new Half(-4), new Half(6));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec3(new Half(-8), new Half(9), new Half(2));
                var v1 = new hvec3(new Half(4.5), new Half(4.5), new Half(4));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new hvec3(new Half(2.5), new Half(3.5), new Half(4.5));
                var v1 = new hvec3(new Half(-6), new Half(9), new Half(-1));
                var v2 = new hvec3(new Half(-9.5), new Half(5), new Half(7.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(-3), new Half(-1.5), new Half(-6));
                var v1 = new hvec3(new Half(-2), new Half(9), new Half(-4));
                var v2 = new hvec3(new Half(9), new Half(5.5), new Half(-2.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(6.5), new Half(-9), new Half(-4.5));
                var v1 = new hvec3(new Half(2.5), new Half(-3.5), new Half(5));
                var v2 = new hvec3(new Half(-8.5), new Half(-1), new Half(7.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(-8.5), new Half(-5.5), new Half(-4.5));
                var v1 = new hvec3(new Half(7), Half.Zero, new Half(7));
                var v2 = new hvec3(new Half(8.5), new Half(-9), new Half(5.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(9.5), new Half(8), new Half(-7));
                var v1 = new hvec3(new Half(-4.5), new Half(6.5), new Half(6.5));
                var v2 = new hvec3(new Half(-6), new Half(4.5), new Half(2.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(-5), new Half(7), Half.Zero);
                var v1 = new hvec3(new Half(-5.5), new Half(7.5), new Half(3));
                var v2 = new hvec3(new Half(9), new Half(8), new Half(3.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(-5), Half.Zero, new Half(6));
                var v1 = new hvec3(new Half(-1.5), new Half(5.5), new Half(9.5));
                var v2 = new hvec3(new Half(-3), new Half(8.5), new Half(-8.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(-2), new Half(5), new Half(-1.5));
                var v1 = new hvec3(new Half(7), new Half(-3), new Half(0.5));
                var v2 = new hvec3(new Half(-9), new Half(9), new Half(-2.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(9), new Half(-2), new Half(-6.5));
                var v1 = new hvec3(new Half(-0.5), new Half(-7), new Half(2.5));
                var v2 = new hvec3(new Half(-3), new Half(5), new Half(3));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(6.5), new Half(7.5), new Half(-3.5));
                var v1 = new hvec3(new Half(-8.5), new Half(7.5), new Half(1.5));
                var v2 = new hvec3(new Half(-4), new Half(-5.5), new Half(-9));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new hvec3(new Half(4.5), new Half(-9.5), new Half(-0.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec3(new Half(-3), new Half(-7.5), Half.Zero);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec3(new Half(6.5), new Half(5.5), new Half(4));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec3(new Half(2), new Half(-7.5), new Half(5.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec3(Half.Zero, new Half(7.5), new Half(-0.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec3(Half.One, new Half(0.5), new Half(-4.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec3(new Half(-7.5), new Half(9.5), new Half(5.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec3(new Half(5), new Half(6.5), new Half(-7));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec3(new Half(8), new Half(-2), new Half(4));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec3(new Half(4.5), Half.Zero, new Half(-1));
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new hvec3(new Half(9.5), new Half(3), new Half(5));
                var v1 = new hvec3(new Half(-9), new Half(9.5), new Half(2));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec3(new Half(0.5), new Half(5), new Half(3.5));
                var v1 = new hvec3(new Half(-3.5), new Half(8), new Half(3.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec3(new Half(-8), new Half(2), new Half(7));
                var v1 = new hvec3(new Half(-7), new Half(9.5), Half.Zero);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec3(new Half(8.5), new Half(8), new Half(5.5));
                var v1 = new hvec3(new Half(-5.5), new Half(-0.5), new Half(1.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec3(new Half(-2.5), new Half(-7), new Half(6));
                var v1 = new hvec3(new Half(3.5), new Half(-7.5), new Half(-2));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec3(new Half(9.5), new Half(-7.5), new Half(-2));
                var v1 = new hvec3(new Half(6.5), new Half(-5), new Half(-9.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec3(new Half(5.5), new Half(-4.5), new Half(-7.5));
                var v1 = new hvec3(new Half(-7), new Half(-6.5), new Half(4.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec3(new Half(-2.5), new Half(0.5), new Half(-5));
                var v1 = new hvec3(new Half(-3.5), new Half(9), new Half(-8));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec3(Half.Zero, new Half(9.5), Half.Zero);
                var v1 = new hvec3(new Half(-8.5), new Half(-7.5), new Half(-4));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec3(Half.Zero, new Half(-6), new Half(-5));
                var v1 = new hvec3(new Half(-4), new Half(1.5), new Half(-7.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new hvec3(new Half(-3.5), new Half(-4), new Half(-0.5));
                var v1 = new hvec3(new Half(5), new Half(8), new Half(8));
                var v2 = new hvec3(new Half(-4), new Half(8.5), Half.One);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(4.5), new Half(7.5), new Half(9));
                var v1 = new hvec3(new Half(8.5), new Half(-8), new Half(-5));
                var v2 = new hvec3(new Half(3), new Half(3.5), new Half(2.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(8), new Half(6.5), new Half(2));
                var v1 = new hvec3(new Half(2), new Half(6), new Half(7));
                var v2 = new hvec3(new Half(-5), new Half(-5.5), new Half(-8));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(-6.5), new Half(-5), new Half(2));
                var v1 = new hvec3(new Half(0.5), new Half(-2.5), new Half(6));
                var v2 = new hvec3(new Half(-8), new Half(1.5), new Half(-5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(-8), new Half(2), new Half(-9));
                var v1 = new hvec3(new Half(0.5), new Half(2.5), Half.One);
                var v2 = new hvec3(Half.One, new Half(2.5), new Half(-4));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec3(Half.Zero, new Half(-7.5), new Half(-3.5));
                var v1 = new hvec3(new Half(-8), new Half(-8), new Half(-4.5));
                var v2 = new hvec3(new Half(-9.5), new Half(-0.5), new Half(-3.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(-1), new Half(-5.5), new Half(6));
                var v1 = new hvec3(new Half(-7.5), new Half(0.5), new Half(-5.5));
                var v2 = new hvec3(new Half(1.5), new Half(0.5), new Half(-5.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(8.5), new Half(4), new Half(9));
                var v1 = new hvec3(new Half(2), new Half(-8.5), new Half(-3.5));
                var v2 = new hvec3(new Half(9.5), new Half(-3.5), new Half(0.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(-4), new Half(-8), new Half(4));
                var v1 = new hvec3(Half.One, Half.Zero, new Half(-4));
                var v2 = new hvec3(new Half(3.5), new Half(-4), new Half(2));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec3(new Half(1.5), new Half(4), new Half(6.5));
                var v1 = new hvec3(new Half(-8), new Half(-1), new Half(8.5));
                var v2 = new hvec3(new Half(-8.5), new Half(6), new Half(7));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new hvec3(new Half(0.5), new Half(-8.5), Half.Zero);
                var v1 = new hvec3(new Half(-6.5), new Half(4), new Half(-3.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec3(new Half(9.5), Half.One, new Half(3.5));
                var v1 = new hvec3(new Half(-8.5), Half.Zero, new Half(-6.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec3(new Half(-9.5), Half.One, new Half(-8));
                var v1 = new hvec3(new Half(-5.5), new Half(3), new Half(-6.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec3(new Half(1.5), new Half(4), new Half(-1.5));
                var v1 = new hvec3(new Half(6.5), new Half(8.5), new Half(-5.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec3(new Half(-9), new Half(-6.5), Half.One);
                var v1 = new hvec3(new Half(-5), new Half(9.5), new Half(-8.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec3(new Half(-2.5), new Half(7.5), new Half(4));
                var v1 = new hvec3(new Half(4.5), new Half(-9), new Half(-3));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec3(new Half(-8.5), new Half(-2.5), new Half(3.5));
                var v1 = new hvec3(new Half(-8.5), new Half(2), new Half(-9));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec3(new Half(5), new Half(2), new Half(8.5));
                var v1 = new hvec3(new Half(3.5), new Half(6.5), new Half(-3));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec3(new Half(9.5), new Half(-3.5), new Half(2.5));
                var v1 = new hvec3(new Half(-6.5), new Half(-5.5), new Half(-3));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec3(new Half(-7), new Half(3.5), new Half(-6.5));
                var v1 = new hvec3(new Half(-6), new Half(3), new Half(-7.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new hvec3(new Half(-8.5), new Half(-6), new Half(-7));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec3(new Half(-7), new Half(-5), new Half(3.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec3(new Half(4), new Half(-7), new Half(4.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec3(new Half(-5), new Half(-1.5), new Half(5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec3(Half.One, new Half(8.5), new Half(9.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec3(new Half(3.5), new Half(3), new Half(-3.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec3(new Half(-1.5), new Half(-7.5), new Half(0.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec3(new Half(-2), new Half(5), new Half(-8.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec3(new Half(-8.5), new Half(-3.5), new Half(-3));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec3(new Half(-8.5), new Half(8), new Half(-0.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new hvec3(new Half(-8.5), new Half(3), Half.Zero);
                var v1 = new hvec3(new Half(3.5), new Half(-4), new Half(9.5));
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new hvec3(new Half(-3.5), new Half(7), new Half(0.5));
                var v1 = new hvec3(new Half(7), new Half(8.5), new Half(2));
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new hvec3(new Half(4.5), new Half(-8), new Half(3));
                var v1 = new hvec3(new Half(-1.5), new Half(1.5), new Half(-6.5));
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new hvec3(Half.Zero, new Half(-9), new Half(2.5));
                var v1 = new hvec3(new Half(-6), new Half(3.5), new Half(8.5));
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new hvec3(new Half(8), new Half(4), new Half(8));
                var v1 = new hvec3(new Half(-5.5), new Half(8.5), new Half(0.5));
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new hvec3(new Half(-1), new Half(-3), new Half(1.5));
                var v1 = new hvec3(new Half(9), new Half(2.5), new Half(-7));
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new hvec3(new Half(-3), new Half(-6.5), new Half(-4.5));
                var v1 = new hvec3(new Half(-9.5), new Half(2.5), new Half(9.5));
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new hvec3(new Half(-4), new Half(3.5), new Half(9.5));
                var v1 = new hvec3(new Half(-3.5), new Half(6.5), Half.One);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new hvec3(new Half(-7), new Half(7.5), new Half(-5));
                var v1 = new hvec3(new Half(7), new Half(-4), new Half(-5));
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new hvec3(new Half(8), new Half(5), new Half(-1));
                var v1 = new hvec3(Half.One, new Half(-4.5), new Half(8));
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1640825804);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.Random(random, 2, 3);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            Assert.AreEqual(avg.z, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(922257802);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomUniform(random, 0, 4);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            Assert.AreEqual(avg.z, 2, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(203689800);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.Random(random, -5, -1);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3, 1.0);
            Assert.AreEqual(avg.y, -3, 1.0);
            Assert.AreEqual(avg.z, -3, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1632605445);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomUniform(random, 0, 3);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            Assert.AreEqual(avg.z, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(220130518);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.Random(random, -5, -2);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3.5, 1.0);
            Assert.AreEqual(avg.y, -3.5, 1.0);
            Assert.AreEqual(avg.z, -3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(1783833775);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomNormal(random, new Half(0.563621499838131), new Half(3.86939672002075));
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.563621499838131, 1.0);
            Assert.AreEqual(avg.y, 0.563621499838131, 1.0);
            Assert.AreEqual(avg.z, 0.563621499838131, 1.0);
            
            Assert.AreEqual(variance.x, 3.86939672002075, 3.0);
            Assert.AreEqual(variance.y, 3.86939672002075, 3.0);
            Assert.AreEqual(variance.z, 3.86939672002075, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(1619509389);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomGaussian(random, new Half(-0.0456359191078859), new Half(8.04335539603762));
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.0456359191078859, 1.0);
            Assert.AreEqual(avg.y, -0.0456359191078859, 1.0);
            Assert.AreEqual(avg.z, -0.0456359191078859, 1.0);
            
            Assert.AreEqual(variance.x, 8.04335539603762, 3.0);
            Assert.AreEqual(variance.y, 8.04335539603762, 3.0);
            Assert.AreEqual(variance.z, 8.04335539603762, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(61314891);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomNormal(random, new Half(-0.0527847362928022), new Half(6.43138314896793));
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.0527847362928022, 1.0);
            Assert.AreEqual(avg.y, -0.0527847362928022, 1.0);
            Assert.AreEqual(avg.z, -0.0527847362928022, 1.0);
            
            Assert.AreEqual(variance.x, 6.43138314896793, 3.0);
            Assert.AreEqual(variance.y, 6.43138314896793, 3.0);
            Assert.AreEqual(variance.z, 6.43138314896793, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(1171032931);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomGaussian(random, new Half(-1.68398934401758), new Half(5.24705978354768));
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.68398934401758, 1.0);
            Assert.AreEqual(avg.y, -1.68398934401758, 1.0);
            Assert.AreEqual(avg.z, -1.68398934401758, 1.0);
            
            Assert.AreEqual(variance.x, 5.24705978354768, 3.0);
            Assert.AreEqual(variance.y, 5.24705978354768, 3.0);
            Assert.AreEqual(variance.z, 5.24705978354768, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(37803196);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomNormal(random, new Half(-1.42291002134928), new Half(5.70512614478596));
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.42291002134928, 1.0);
            Assert.AreEqual(avg.y, -1.42291002134928, 1.0);
            Assert.AreEqual(avg.z, -1.42291002134928, 1.0);
            
            Assert.AreEqual(variance.x, 5.70512614478596, 3.0);
            Assert.AreEqual(variance.y, 5.70512614478596, 3.0);
            Assert.AreEqual(variance.z, 5.70512614478596, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(164096357);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomNormal(random);
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
            var random = new Random(1189680185);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomNormal(random);
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
            var random = new Random(67780366);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomNormal(random);
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
            var random = new Random(1093364194);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomNormal(random);
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
            var random = new Random(356728339);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec3.RandomNormal(random);
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
