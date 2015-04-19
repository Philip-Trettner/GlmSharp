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
    public class HalfVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new hvec4(new Half(3));
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(3), v.y);
                Assert.AreEqual(new Half(3), v.z);
                Assert.AreEqual(new Half(3), v.w);
            }
            {
                var v = new hvec4(new Half(3.5), Half.Zero, new Half(-3.5), new Half(-1.5));
                Assert.AreEqual(new Half(3.5), v.x);
                Assert.AreEqual(Half.Zero, v.y);
                Assert.AreEqual(new Half(-3.5), v.z);
                Assert.AreEqual(new Half(-1.5), v.w);
            }
            {
                var v = new hvec4(new hvec2(new Half(3), new Half(9)));
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(9), v.y);
                Assert.AreEqual(Half.Zero, v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var v = new hvec4(new hvec3(new Half(-4.5), new Half(6.5), new Half(-2)));
                Assert.AreEqual(new Half(-4.5), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
                Assert.AreEqual(new Half(-2), v.z);
                Assert.AreEqual(Half.Zero, v.w);
            }
            {
                var v = new hvec4(new hvec4(Half.One, new Half(-6), new Half(1.5), new Half(-6.5)));
                Assert.AreEqual(Half.One, v.x);
                Assert.AreEqual(new Half(-6), v.y);
                Assert.AreEqual(new Half(1.5), v.z);
                Assert.AreEqual(new Half(-6.5), v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new hvec4(new Half(2), new Half(-7), new Half(-6), new Half(-9.5));
            Assert.AreEqual(new Half(2), v[0]);
            Assert.AreEqual(new Half(-7), v[1]);
            Assert.AreEqual(new Half(-6), v[2]);
            Assert.AreEqual(new Half(-9.5), v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = Half.Zero; } );
            
            v[2] = Half.Zero;
            Assert.AreEqual(Half.Zero, v[2]);
            v[2] = Half.One;
            Assert.AreEqual(Half.One, v[2]);
            v[3] = new Half(2);
            Assert.AreEqual(new Half(2), v[3]);
            v[2] = new Half(3);
            Assert.AreEqual(new Half(3), v[2]);
            v[1] = new Half(4);
            Assert.AreEqual(new Half(4), v[1]);
            v[0] = new Half(5);
            Assert.AreEqual(new Half(5), v[0]);
            v[2] = new Half(6);
            Assert.AreEqual(new Half(6), v[2]);
            v[0] = new Half(7);
            Assert.AreEqual(new Half(7), v[0]);
            v[3] = new Half(8);
            Assert.AreEqual(new Half(8), v[3]);
            v[3] = new Half(9);
            Assert.AreEqual(new Half(9), v[3]);
            v[3] = new Half(-1);
            Assert.AreEqual(new Half(-1), v[3]);
            v[0] = new Half(-2);
            Assert.AreEqual(new Half(-2), v[0]);
            v[0] = new Half(-3);
            Assert.AreEqual(new Half(-3), v[0]);
            v[1] = new Half(-4);
            Assert.AreEqual(new Half(-4), v[1]);
            v[1] = new Half(-5);
            Assert.AreEqual(new Half(-5), v[1]);
            v[0] = new Half(-6);
            Assert.AreEqual(new Half(-6), v[0]);
            v[3] = new Half(-7);
            Assert.AreEqual(new Half(-7), v[3]);
            v[3] = new Half(-8);
            Assert.AreEqual(new Half(-8), v[3]);
            v[1] = new Half(-9);
            Assert.AreEqual(new Half(-9), v[1]);
            v[2] = new Half(-9.5);
            Assert.AreEqual(new Half(-9.5), v[2]);
            v[2] = new Half(-8.5);
            Assert.AreEqual(new Half(-8.5), v[2]);
            v[0] = new Half(-7.5);
            Assert.AreEqual(new Half(-7.5), v[0]);
            v[0] = new Half(-6.5);
            Assert.AreEqual(new Half(-6.5), v[0]);
            v[3] = new Half(-5.5);
            Assert.AreEqual(new Half(-5.5), v[3]);
            v[1] = new Half(-4.5);
            Assert.AreEqual(new Half(-4.5), v[1]);
            v[0] = new Half(-3.5);
            Assert.AreEqual(new Half(-3.5), v[0]);
            v[1] = new Half(-2.5);
            Assert.AreEqual(new Half(-2.5), v[1]);
            v[1] = new Half(-1.5);
            Assert.AreEqual(new Half(-1.5), v[1]);
            v[1] = new Half(-0.5);
            Assert.AreEqual(new Half(-0.5), v[1]);
            v[1] = new Half(0.5);
            Assert.AreEqual(new Half(0.5), v[1]);
            v[2] = new Half(1.5);
            Assert.AreEqual(new Half(1.5), v[2]);
            v[2] = new Half(2.5);
            Assert.AreEqual(new Half(2.5), v[2]);
            v[1] = new Half(3.5);
            Assert.AreEqual(new Half(3.5), v[1]);
            v[2] = new Half(4.5);
            Assert.AreEqual(new Half(4.5), v[2]);
            v[1] = new Half(5.5);
            Assert.AreEqual(new Half(5.5), v[1]);
            v[2] = new Half(6.5);
            Assert.AreEqual(new Half(6.5), v[2]);
            v[0] = new Half(7.5);
            Assert.AreEqual(new Half(7.5), v[0]);
            v[1] = new Half(8.5);
            Assert.AreEqual(new Half(8.5), v[1]);
            v[2] = new Half(9.5);
            Assert.AreEqual(new Half(9.5), v[2]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new hvec4(new Half(-8), new Half(-1), new Half(-5.5), new Half(6));
            var vals = v.Values;
            Assert.AreEqual(new Half(-8), vals[0]);
            Assert.AreEqual(new Half(-1), vals[1]);
            Assert.AreEqual(new Half(-5.5), vals[2]);
            Assert.AreEqual(new Half(6), vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(Half.Zero, hvec4.Zero.x);
            Assert.AreEqual(Half.Zero, hvec4.Zero.y);
            Assert.AreEqual(Half.Zero, hvec4.Zero.z);
            Assert.AreEqual(Half.Zero, hvec4.Zero.w);
            
            Assert.AreEqual(Half.One, hvec4.Ones.x);
            Assert.AreEqual(Half.One, hvec4.Ones.y);
            Assert.AreEqual(Half.One, hvec4.Ones.z);
            Assert.AreEqual(Half.One, hvec4.Ones.w);
            
            Assert.AreEqual(Half.One, hvec4.UnitX.x);
            Assert.AreEqual(Half.Zero, hvec4.UnitX.y);
            Assert.AreEqual(Half.Zero, hvec4.UnitX.z);
            Assert.AreEqual(Half.Zero, hvec4.UnitX.w);
            
            Assert.AreEqual(Half.Zero, hvec4.UnitY.x);
            Assert.AreEqual(Half.One, hvec4.UnitY.y);
            Assert.AreEqual(Half.Zero, hvec4.UnitY.z);
            Assert.AreEqual(Half.Zero, hvec4.UnitY.w);
            
            Assert.AreEqual(Half.Zero, hvec4.UnitZ.x);
            Assert.AreEqual(Half.Zero, hvec4.UnitZ.y);
            Assert.AreEqual(Half.One, hvec4.UnitZ.z);
            Assert.AreEqual(Half.Zero, hvec4.UnitZ.w);
            
            Assert.AreEqual(Half.Zero, hvec4.UnitW.x);
            Assert.AreEqual(Half.Zero, hvec4.UnitW.y);
            Assert.AreEqual(Half.Zero, hvec4.UnitW.z);
            Assert.AreEqual(Half.One, hvec4.UnitW.w);
            
            Assert.AreEqual(Half.MaxValue, hvec4.MaxValue.x);
            Assert.AreEqual(Half.MaxValue, hvec4.MaxValue.y);
            Assert.AreEqual(Half.MaxValue, hvec4.MaxValue.z);
            Assert.AreEqual(Half.MaxValue, hvec4.MaxValue.w);
            
            Assert.AreEqual(Half.MinValue, hvec4.MinValue.x);
            Assert.AreEqual(Half.MinValue, hvec4.MinValue.y);
            Assert.AreEqual(Half.MinValue, hvec4.MinValue.z);
            Assert.AreEqual(Half.MinValue, hvec4.MinValue.w);
            
            Assert.AreEqual(Half.Epsilon, hvec4.Epsilon.x);
            Assert.AreEqual(Half.Epsilon, hvec4.Epsilon.y);
            Assert.AreEqual(Half.Epsilon, hvec4.Epsilon.z);
            Assert.AreEqual(Half.Epsilon, hvec4.Epsilon.w);
            
            Assert.AreEqual(Half.NaN, hvec4.NaN.x);
            Assert.AreEqual(Half.NaN, hvec4.NaN.y);
            Assert.AreEqual(Half.NaN, hvec4.NaN.z);
            Assert.AreEqual(Half.NaN, hvec4.NaN.w);
            
            Assert.AreEqual(Half.NegativeInfinity, hvec4.NegativeInfinity.x);
            Assert.AreEqual(Half.NegativeInfinity, hvec4.NegativeInfinity.y);
            Assert.AreEqual(Half.NegativeInfinity, hvec4.NegativeInfinity.z);
            Assert.AreEqual(Half.NegativeInfinity, hvec4.NegativeInfinity.w);
            
            Assert.AreEqual(Half.PositiveInfinity, hvec4.PositiveInfinity.x);
            Assert.AreEqual(Half.PositiveInfinity, hvec4.PositiveInfinity.y);
            Assert.AreEqual(Half.PositiveInfinity, hvec4.PositiveInfinity.z);
            Assert.AreEqual(Half.PositiveInfinity, hvec4.PositiveInfinity.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new hvec4(new Half(-5.5), new Half(0.5), new Half(-3), new Half(-6));
            var v2 = new hvec4(new Half(-5.5), new Half(0.5), new Half(-3), new Half(-6));
            var v3 = new hvec4(new Half(-6), new Half(-3), new Half(0.5), new Half(-5.5));
            Assert.That(v1 == new hvec4(v1));
            Assert.That(v2 == new hvec4(v2));
            Assert.That(v3 == new hvec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new hvec4(new Half(6.5), new Half(-9.5), new Half(-6), new Half(-4));
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = hvec4.Parse(s0);
            var v1 = hvec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = hvec4.TryParse(s0, out v0);
            var b1 = hvec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = hvec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = hvec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = hvec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { hvec4.Parse(null); });
            Assert.Throws<FormatException>(() => { hvec4.Parse(""); });
            Assert.Throws<FormatException>(() => { hvec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = hvec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = hvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = hvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new hvec4(Half.Zero, new Half(-8.5), new Half(-6), new Half(2));
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<hvec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new hvec4(new Half(9.5), new Half(7), new Half(8), new Half(3));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec4(new Half(8), new Half(3.5), new Half(-7), new Half(-5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec4(new Half(-7), new Half(-3.5), new Half(8), new Half(6));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec4(new Half(6.5), new Half(-7.5), new Half(-1), new Half(-4.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec4(new Half(-7.5), new Half(8), new Half(-1.5), new Half(-5.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec4(new Half(-7), new Half(-6.5), new Half(-1.5), new Half(-3));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec4(new Half(-8.5), new Half(0.5), new Half(9), new Half(0.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec4(new Half(-3.5), new Half(-6), new Half(4), new Half(-7));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec4(new Half(-8), new Half(6), new Half(2.5), new Half(-8));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec4(new Half(-6.5), new Half(0.5), new Half(8.5), Half.One);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new hvec4(new Half(4), new Half(8.5), new Half(9), Half.Zero);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec4(new Half(8.5), new Half(8), new Half(3.5), new Half(-4));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec4(new Half(-6), new Half(8), new Half(-6.5), new Half(-5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec4(new Half(-2), new Half(2), new Half(-9.5), new Half(8.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec4(new Half(9.5), new Half(-8.5), new Half(-2.5), new Half(-7));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec4(new Half(5.5), new Half(-6.5), new Half(8), new Half(4));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec4(new Half(-1.5), new Half(1.5), new Half(-1.5), new Half(-4));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec4(new Half(-5), new Half(-3.5), new Half(-6), new Half(8.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec4(new Half(2), Half.One, new Half(2), new Half(-8));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec4(new Half(-2), new Half(4.5), new Half(-3.5), new Half(-7));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new hvec4(new Half(-0.5), new Half(7.5), new Half(-0.5), new Half(-8.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec4(new Half(-4), new Half(9), new Half(-4.5), new Half(4.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec4(new Half(3), new Half(-0.5), new Half(-3.5), new Half(-8.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec4(new Half(2), new Half(-1.5), new Half(-7.5), new Half(3.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec4(new Half(8.5), new Half(-4.5), new Half(-4.5), new Half(3.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec4(new Half(-6), new Half(4), new Half(3), new Half(-1));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec4(new Half(-3.5), new Half(2.5), new Half(-9), new Half(7.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec4(new Half(9), new Half(-3.5), new Half(4.5), new Half(-0.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec4(new Half(-8), new Half(3), new Half(6), new Half(-9));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec4(new Half(-2.5), new Half(9.5), new Half(-2), new Half(9.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new hvec4(new Half(5.5), new Half(2.5), new Half(-1.5), new Half(-3.5));
                var v1 = new hvec4(new Half(0.5), new Half(0.5), Half.One, new Half(4.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec4(new Half(6.5), new Half(-2), new Half(5), new Half(-8));
                var v1 = new hvec4(new Half(-9), new Half(2.5), new Half(-2.5), new Half(3));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec4(new Half(-8), new Half(9), new Half(4.5), new Half(-8.5));
                var v1 = new hvec4(new Half(-4.5), new Half(-3.5), new Half(4), new Half(2.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec4(new Half(-2.5), new Half(4), new Half(2), new Half(5.5));
                var v1 = new hvec4(Half.One, new Half(-7.5), new Half(-2.5), new Half(4.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec4(new Half(2), new Half(-2.5), new Half(-1), new Half(5));
                var v1 = new hvec4(new Half(9.5), Half.Zero, new Half(-6), new Half(-2));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec4(new Half(2), new Half(-3), new Half(-3), new Half(8));
                var v1 = new hvec4(new Half(5), new Half(3.5), new Half(-4.5), new Half(7.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec4(new Half(8), new Half(-8), Half.Zero, new Half(-7));
                var v1 = new hvec4(new Half(6), new Half(-4.5), new Half(-6.5), new Half(9));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec4(new Half(-1.5), new Half(5.5), new Half(9.5), new Half(-4.5));
                var v1 = new hvec4(new Half(-1.5), new Half(5), new Half(2.5), new Half(-4));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec4(new Half(-4.5), new Half(-2), new Half(-6), new Half(2.5));
                var v1 = new hvec4(new Half(-8.5), new Half(-7.5), new Half(4), new Half(-7));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec4(new Half(4.5), new Half(-6.5), new Half(-9), new Half(-2));
                var v1 = new hvec4(new Half(-4), new Half(5.5), new Half(-2.5), new Half(3.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new hvec4(new Half(-8.5), new Half(9.5), new Half(6), new Half(-2));
                var v1 = new hvec4(new Half(0.5), new Half(-2), new Half(-6), new Half(2.5));
                var v2 = new hvec4(new Half(6.5), new Half(5.5), new Half(-7), new Half(-2));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec4(Half.One, new Half(6.5), new Half(-4.5), new Half(-7.5));
                var v1 = new hvec4(new Half(6.5), new Half(-7), new Half(-4.5), new Half(1.5));
                var v2 = new hvec4(new Half(-0.5), new Half(1.5), Half.Zero, new Half(-0.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec4(Half.Zero, Half.Zero, new Half(2), new Half(-1.5));
                var v1 = new hvec4(new Half(-8), new Half(8), new Half(-6.5), new Half(-9));
                var v2 = new hvec4(new Half(-6), new Half(-6), Half.One, new Half(-8));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(3), new Half(4.5), new Half(6.5), new Half(5.5));
                var v1 = new hvec4(new Half(-0.5), new Half(-2.5), new Half(-6), new Half(4));
                var v2 = new hvec4(new Half(3.5), new Half(-6.5), new Half(5.5), new Half(9.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(4), new Half(-8.5), new Half(2.5), new Half(-8));
                var v1 = new hvec4(new Half(6), new Half(-6.5), new Half(-1.5), new Half(0.5));
                var v2 = new hvec4(new Half(9.5), new Half(-7), new Half(-2), new Half(0.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(8), new Half(-2.5), new Half(-5), new Half(-1.5));
                var v1 = new hvec4(new Half(-3), new Half(7.5), new Half(5.5), new Half(-4.5));
                var v2 = new hvec4(new Half(5.5), new Half(6), new Half(-9), new Half(2));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(-8.5), new Half(0.5), Half.One, new Half(2));
                var v1 = new hvec4(new Half(-5), new Half(6.5), new Half(5.5), new Half(-7));
                var v2 = new hvec4(new Half(4), new Half(3), new Half(-5.5), new Half(7.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(-6), new Half(4), new Half(-2), new Half(3.5));
                var v1 = new hvec4(new Half(-1.5), new Half(-1), new Half(-9), new Half(-3.5));
                var v2 = new hvec4(new Half(-7.5), new Half(5), new Half(-2.5), Half.One);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(-2), new Half(-1.5), new Half(1.5), new Half(6.5));
                var v1 = new hvec4(new Half(-1.5), new Half(9), new Half(4), new Half(7.5));
                var v2 = new hvec4(Half.One, new Half(0.5), new Half(7.5), new Half(-7));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(-8.5), new Half(-3.5), new Half(-5), new Half(3));
                var v1 = new hvec4(new Half(-7.5), new Half(5.5), new Half(-4.5), new Half(5));
                var v2 = new hvec4(new Half(3), new Half(-8), new Half(-3), new Half(7));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new hvec4(new Half(-6.5), new Half(-2.5), new Half(2), new Half(8));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec4(new Half(2), Half.One, new Half(2.5), new Half(-7.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec4(new Half(4), new Half(-4.5), new Half(-1), new Half(1.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec4(new Half(0.5), new Half(-5.5), new Half(9.5), new Half(-4));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec4(new Half(1.5), new Half(-6), new Half(-1), new Half(-2));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec4(new Half(9.5), new Half(3), new Half(9), Half.Zero);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec4(new Half(-1.5), Half.One, new Half(-1), Half.One);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec4(new Half(3.5), new Half(4.5), new Half(0.5), new Half(5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec4(new Half(-4.5), new Half(5.5), new Half(0.5), new Half(-7.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec4(new Half(-1.5), new Half(1.5), Half.One, new Half(-8));
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new hvec4(new Half(-0.5), new Half(-5), new Half(3), new Half(0.5));
                var v1 = new hvec4(new Half(6.5), Half.Zero, new Half(5), new Half(3));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec4(new Half(5), new Half(-3), new Half(-3.5), new Half(7));
                var v1 = new hvec4(new Half(2), new Half(8), new Half(-9.5), new Half(-3));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec4(new Half(-1.5), new Half(8), new Half(-2.5), new Half(4));
                var v1 = new hvec4(new Half(-4.5), new Half(4), new Half(6.5), new Half(-2.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec4(new Half(9), new Half(5.5), new Half(-6.5), new Half(-4));
                var v1 = new hvec4(new Half(-1.5), new Half(-2), new Half(9.5), new Half(5.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec4(new Half(3), new Half(-4.5), new Half(-5), new Half(-8));
                var v1 = new hvec4(new Half(3), new Half(-9.5), new Half(-2.5), new Half(8));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec4(new Half(-5.5), new Half(1.5), new Half(-8.5), new Half(-7.5));
                var v1 = new hvec4(new Half(-6), new Half(-1.5), new Half(-0.5), new Half(-9.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec4(new Half(0.5), new Half(6.5), new Half(3), new Half(-1.5));
                var v1 = new hvec4(new Half(-0.5), new Half(6.5), Half.One, new Half(-5.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec4(new Half(-8), new Half(-7), new Half(-9.5), Half.One);
                var v1 = new hvec4(new Half(-7), new Half(1.5), new Half(-5), new Half(4.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec4(new Half(-3), new Half(0.5), new Half(4), new Half(-8));
                var v1 = new hvec4(new Half(3.5), Half.One, new Half(8), new Half(7));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec4(new Half(-7.5), new Half(-8), new Half(-9.5), new Half(3.5));
                var v1 = new hvec4(new Half(-6.5), new Half(-5), new Half(-1), new Half(-8.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new hvec4(new Half(7.5), new Half(6), new Half(-7), new Half(9));
                var v1 = new hvec4(new Half(-1.5), new Half(7), new Half(-7), new Half(-2));
                var v2 = new hvec4(Half.One, new Half(-2), new Half(8), new Half(-4));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(8), new Half(1.5), new Half(3), new Half(2.5));
                var v1 = new hvec4(new Half(2.5), new Half(2), new Half(-9.5), new Half(-4.5));
                var v2 = new hvec4(new Half(8.5), new Half(3), new Half(2.5), new Half(-6.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(5.5), new Half(4.5), new Half(-2), new Half(-6));
                var v1 = new hvec4(new Half(-7.5), new Half(-9), new Half(-5), new Half(7));
                var v2 = new hvec4(new Half(7.5), Half.Zero, new Half(9), new Half(2.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(-5), new Half(-7), new Half(9.5), new Half(-9.5));
                var v1 = new hvec4(new Half(9.5), new Half(9), Half.One, new Half(-7.5));
                var v2 = new hvec4(new Half(-3), new Half(2.5), new Half(3.5), new Half(-2.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(7.5), new Half(5.5), new Half(5.5), new Half(-2));
                var v1 = new hvec4(new Half(0.5), new Half(6.5), new Half(8.5), new Half(3.5));
                var v2 = new hvec4(new Half(-4), new Half(3.5), new Half(-4), new Half(3.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(5.5), Half.Zero, new Half(0.5), new Half(-6.5));
                var v1 = new hvec4(new Half(7.5), Half.Zero, new Half(-6), new Half(7));
                var v2 = new hvec4(new Half(-7.5), new Half(-1), new Half(-7), new Half(-5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(2), new Half(9.5), new Half(-3.5), new Half(-1.5));
                var v1 = new hvec4(new Half(2), new Half(9), new Half(-1), new Half(3));
                var v2 = new hvec4(Half.Zero, new Half(-4.5), new Half(-9), new Half(-3.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(-6.5), new Half(2), new Half(-8), Half.One);
                var v1 = new hvec4(new Half(2), new Half(-6), new Half(-8), new Half(-8.5));
                var v2 = new hvec4(new Half(3), new Half(6), new Half(-5.5), new Half(8.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(-9.5), new Half(-9), new Half(-4.5), new Half(-2));
                var v1 = new hvec4(new Half(-7), new Half(-4.5), new Half(5), new Half(-3.5));
                var v2 = new hvec4(new Half(-8), new Half(-8.5), new Half(8), new Half(1.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec4(new Half(-1), new Half(9), new Half(1.5), new Half(4));
                var v1 = new hvec4(new Half(-6.5), new Half(-1), new Half(2.5), new Half(-1));
                var v2 = new hvec4(new Half(-7.5), new Half(3), new Half(9.5), new Half(4.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new hvec4(new Half(8.5), new Half(-3), Half.One, new Half(-8));
                var v1 = new hvec4(Half.One, new Half(-0.5), new Half(7.5), Half.Zero);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec4(new Half(7), new Half(-7.5), new Half(5), new Half(-6.5));
                var v1 = new hvec4(new Half(-3.5), new Half(7), new Half(0.5), new Half(-9));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec4(new Half(6.5), new Half(6), new Half(2.5), new Half(8.5));
                var v1 = new hvec4(new Half(-4), new Half(-4), new Half(7.5), new Half(-2));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec4(new Half(8.5), new Half(7.5), new Half(-1.5), new Half(-8));
                var v1 = new hvec4(new Half(-7), new Half(6), new Half(2), new Half(-0.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec4(new Half(3), new Half(-4.5), Half.Zero, new Half(1.5));
                var v1 = new hvec4(new Half(-9.5), new Half(-5), new Half(-5.5), new Half(-2.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec4(new Half(9), new Half(9), new Half(-9.5), new Half(0.5));
                var v1 = new hvec4(new Half(-8), new Half(-6.5), Half.Zero, new Half(2));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec4(new Half(-7), new Half(-1.5), new Half(2.5), new Half(-2.5));
                var v1 = new hvec4(new Half(4.5), new Half(-1), new Half(-5.5), new Half(-5.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec4(new Half(-6), new Half(0.5), new Half(-9.5), new Half(4));
                var v1 = new hvec4(Half.One, new Half(-9), new Half(-5.5), Half.Zero);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec4(new Half(-9.5), new Half(-7), new Half(-9), Half.Zero);
                var v1 = new hvec4(new Half(6), new Half(8.5), new Half(8.5), new Half(-7.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec4(new Half(-6.5), new Half(4), new Half(-1.5), new Half(3));
                var v1 = new hvec4(new Half(4.5), new Half(6), new Half(3.5), new Half(-5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new hvec4(new Half(2.5), new Half(8), new Half(4), new Half(-9.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec4(new Half(4.5), new Half(2.5), new Half(8), new Half(0.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec4(new Half(5.5), new Half(2.5), new Half(9.5), new Half(9));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec4(new Half(-2), new Half(-3), new Half(-0.5), new Half(-7.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec4(new Half(2), new Half(6.5), new Half(9.5), new Half(9));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec4(new Half(-2.5), new Half(-3), new Half(1.5), new Half(7.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec4(Half.One, new Half(6.5), new Half(6), new Half(-4));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec4(new Half(-5), new Half(5), new Half(-3.5), new Half(9));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec4(new Half(-9), new Half(6.5), Half.Zero, new Half(8));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec4(new Half(-3.5), new Half(6), new Half(6.5), new Half(2.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1034084066);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.Random(random, 3, 7);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5, 1.0);
            Assert.AreEqual(avg.y, 5, 1.0);
            Assert.AreEqual(avg.z, 5, 1.0);
            Assert.AreEqual(avg.w, 5, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(315516064);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomUniform(random, 2, 3);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            Assert.AreEqual(avg.z, 2.5, 1.0);
            Assert.AreEqual(avg.w, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1744431709);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.Random(random, -3, -2);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2.5, 1.0);
            Assert.AreEqual(avg.y, -2.5, 1.0);
            Assert.AreEqual(avg.z, -2.5, 1.0);
            Assert.AreEqual(avg.w, -2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1025863707);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomUniform(random, 2, 6);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            Assert.AreEqual(avg.z, 4, 1.0);
            Assert.AreEqual(avg.w, 4, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1760872427);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.Random(random, -4, 0);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            Assert.AreEqual(avg.z, -2, 1.0);
            Assert.AreEqual(avg.w, -2, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(1942099055);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomNormal(random, new Half(1.24840440379847), new Half(6.99533409764773));
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.24840440379847, 1.0);
            Assert.AreEqual(avg.y, 1.24840440379847, 1.0);
            Assert.AreEqual(avg.z, 1.24840440379847, 1.0);
            Assert.AreEqual(avg.w, 1.24840440379847, 1.0);
            
            Assert.AreEqual(variance.x, 6.99533409764773, 3.0);
            Assert.AreEqual(variance.y, 6.99533409764773, 3.0);
            Assert.AreEqual(variance.z, 6.99533409764773, 3.0);
            Assert.AreEqual(variance.w, 6.99533409764773, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(1012767651);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomGaussian(random, new Half(1.8994558918753), new Half(4.19116101422867));
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.8994558918753, 1.0);
            Assert.AreEqual(avg.y, 1.8994558918753, 1.0);
            Assert.AreEqual(avg.z, 1.8994558918753, 1.0);
            Assert.AreEqual(avg.w, 1.8994558918753, 1.0);
            
            Assert.AreEqual(variance.x, 4.19116101422867, 3.0);
            Assert.AreEqual(variance.y, 4.19116101422867, 3.0);
            Assert.AreEqual(variance.z, 4.19116101422867, 3.0);
            Assert.AreEqual(variance.w, 4.19116101422867, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(1602056800);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomNormal(random, new Half(0.631998167667537), new Half(9.55732049865523));
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.631998167667537, 1.0);
            Assert.AreEqual(avg.y, 0.631998167667537, 1.0);
            Assert.AreEqual(avg.z, 0.631998167667537, 1.0);
            Assert.AreEqual(avg.w, 0.631998167667537, 1.0);
            
            Assert.AreEqual(variance.x, 9.55732049865523, 3.0);
            Assert.AreEqual(variance.y, 9.55732049865523, 3.0);
            Assert.AreEqual(variance.z, 9.55732049865523, 3.0);
            Assert.AreEqual(variance.w, 9.55732049865523, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(1777774669);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomGaussian(random, new Half(-0.999206440057236), new Half(8.37299713323498));
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.999206440057236, 1.0);
            Assert.AreEqual(avg.y, -0.999206440057236, 1.0);
            Assert.AreEqual(avg.z, -0.999206440057236, 1.0);
            Assert.AreEqual(avg.w, -0.999206440057236, 1.0);
            
            Assert.AreEqual(variance.x, 8.37299713323498, 3.0);
            Assert.AreEqual(variance.y, 8.37299713323498, 3.0);
            Assert.AreEqual(variance.z, 8.37299713323498, 3.0);
            Assert.AreEqual(variance.w, 8.37299713323498, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(423478502);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomNormal(random, new Half(1.89230707469038), new Half(2.57918876715898));
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.89230707469038, 1.0);
            Assert.AreEqual(avg.y, 1.89230707469038, 1.0);
            Assert.AreEqual(avg.z, 1.89230707469038, 1.0);
            Assert.AreEqual(avg.w, 1.89230707469038, 1.0);
            
            Assert.AreEqual(variance.x, 2.57918876715898, 3.0);
            Assert.AreEqual(variance.y, 2.57918876715898, 3.0);
            Assert.AreEqual(variance.z, 2.57918876715898, 3.0);
            Assert.AreEqual(variance.w, 2.57918876715898, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(1704838266);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomNormal(random);
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
            var random = new Random(582938447);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomNormal(random);
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
            var random = new Random(1608522275);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomNormal(random);
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
            var random = new Random(486622456);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomNormal(random);
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
            var random = new Random(1897470248);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec4.RandomNormal(random);
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
