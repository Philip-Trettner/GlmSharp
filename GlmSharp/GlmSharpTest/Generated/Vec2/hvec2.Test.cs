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
    public class HalfVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new hvec2(new Half(7.5));
                Assert.AreEqual(new Half(7.5), v.x);
                Assert.AreEqual(new Half(7.5), v.y);
            }
            {
                var v = new hvec2(new Half(-8), new Half(6.5));
                Assert.AreEqual(new Half(-8), v.x);
                Assert.AreEqual(new Half(6.5), v.y);
            }
            {
                var v = new hvec2(new hvec2(new Half(-3.5), new Half(-2.5)));
                Assert.AreEqual(new Half(-3.5), v.x);
                Assert.AreEqual(new Half(-2.5), v.y);
            }
            {
                var v = new hvec2(new hvec3(new Half(8.5), new Half(-0.5), new Half(7.5)));
                Assert.AreEqual(new Half(8.5), v.x);
                Assert.AreEqual(new Half(-0.5), v.y);
            }
            {
                var v = new hvec2(new hvec4(new Half(3), new Half(4), new Half(4), new Half(-0.5)));
                Assert.AreEqual(new Half(3), v.x);
                Assert.AreEqual(new Half(4), v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new hvec2(new Half(8.5), new Half(5.5));
            Assert.AreEqual(new Half(8.5), v[0]);
            Assert.AreEqual(new Half(5.5), v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = Half.Zero; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = Half.Zero; } );
            
            v[1] = Half.Zero;
            Assert.AreEqual(Half.Zero, v[1]);
            v[1] = Half.One;
            Assert.AreEqual(Half.One, v[1]);
            v[1] = new Half(2);
            Assert.AreEqual(new Half(2), v[1]);
            v[1] = new Half(3);
            Assert.AreEqual(new Half(3), v[1]);
            v[0] = new Half(4);
            Assert.AreEqual(new Half(4), v[0]);
            v[1] = new Half(5);
            Assert.AreEqual(new Half(5), v[1]);
            v[1] = new Half(6);
            Assert.AreEqual(new Half(6), v[1]);
            v[0] = new Half(7);
            Assert.AreEqual(new Half(7), v[0]);
            v[0] = new Half(8);
            Assert.AreEqual(new Half(8), v[0]);
            v[0] = new Half(9);
            Assert.AreEqual(new Half(9), v[0]);
            v[1] = new Half(-1);
            Assert.AreEqual(new Half(-1), v[1]);
            v[1] = new Half(-2);
            Assert.AreEqual(new Half(-2), v[1]);
            v[0] = new Half(-3);
            Assert.AreEqual(new Half(-3), v[0]);
            v[0] = new Half(-4);
            Assert.AreEqual(new Half(-4), v[0]);
            v[0] = new Half(-5);
            Assert.AreEqual(new Half(-5), v[0]);
            v[0] = new Half(-6);
            Assert.AreEqual(new Half(-6), v[0]);
            v[1] = new Half(-7);
            Assert.AreEqual(new Half(-7), v[1]);
            v[1] = new Half(-8);
            Assert.AreEqual(new Half(-8), v[1]);
            v[1] = new Half(-9);
            Assert.AreEqual(new Half(-9), v[1]);
            v[1] = new Half(-9.5);
            Assert.AreEqual(new Half(-9.5), v[1]);
            v[1] = new Half(-8.5);
            Assert.AreEqual(new Half(-8.5), v[1]);
            v[0] = new Half(-7.5);
            Assert.AreEqual(new Half(-7.5), v[0]);
            v[1] = new Half(-6.5);
            Assert.AreEqual(new Half(-6.5), v[1]);
            v[0] = new Half(-5.5);
            Assert.AreEqual(new Half(-5.5), v[0]);
            v[0] = new Half(-4.5);
            Assert.AreEqual(new Half(-4.5), v[0]);
            v[0] = new Half(-3.5);
            Assert.AreEqual(new Half(-3.5), v[0]);
            v[0] = new Half(-2.5);
            Assert.AreEqual(new Half(-2.5), v[0]);
            v[1] = new Half(-1.5);
            Assert.AreEqual(new Half(-1.5), v[1]);
            v[0] = new Half(-0.5);
            Assert.AreEqual(new Half(-0.5), v[0]);
            v[0] = new Half(0.5);
            Assert.AreEqual(new Half(0.5), v[0]);
            v[1] = new Half(1.5);
            Assert.AreEqual(new Half(1.5), v[1]);
            v[1] = new Half(2.5);
            Assert.AreEqual(new Half(2.5), v[1]);
            v[1] = new Half(3.5);
            Assert.AreEqual(new Half(3.5), v[1]);
            v[1] = new Half(4.5);
            Assert.AreEqual(new Half(4.5), v[1]);
            v[0] = new Half(5.5);
            Assert.AreEqual(new Half(5.5), v[0]);
            v[1] = new Half(6.5);
            Assert.AreEqual(new Half(6.5), v[1]);
            v[0] = new Half(7.5);
            Assert.AreEqual(new Half(7.5), v[0]);
            v[1] = new Half(8.5);
            Assert.AreEqual(new Half(8.5), v[1]);
            v[0] = new Half(9.5);
            Assert.AreEqual(new Half(9.5), v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new hvec2(new Half(-6.5), Half.Zero);
            var vals = v.Values;
            Assert.AreEqual(new Half(-6.5), vals[0]);
            Assert.AreEqual(Half.Zero, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(Half.Zero, hvec2.Zero.x);
            Assert.AreEqual(Half.Zero, hvec2.Zero.y);
            
            Assert.AreEqual(Half.One, hvec2.Ones.x);
            Assert.AreEqual(Half.One, hvec2.Ones.y);
            
            Assert.AreEqual(Half.One, hvec2.UnitX.x);
            Assert.AreEqual(Half.Zero, hvec2.UnitX.y);
            
            Assert.AreEqual(Half.Zero, hvec2.UnitY.x);
            Assert.AreEqual(Half.One, hvec2.UnitY.y);
            
            Assert.AreEqual(Half.MaxValue, hvec2.MaxValue.x);
            Assert.AreEqual(Half.MaxValue, hvec2.MaxValue.y);
            
            Assert.AreEqual(Half.MinValue, hvec2.MinValue.x);
            Assert.AreEqual(Half.MinValue, hvec2.MinValue.y);
            
            Assert.AreEqual(Half.Epsilon, hvec2.Epsilon.x);
            Assert.AreEqual(Half.Epsilon, hvec2.Epsilon.y);
            
            Assert.AreEqual(Half.NaN, hvec2.NaN.x);
            Assert.AreEqual(Half.NaN, hvec2.NaN.y);
            
            Assert.AreEqual(Half.NegativeInfinity, hvec2.NegativeInfinity.x);
            Assert.AreEqual(Half.NegativeInfinity, hvec2.NegativeInfinity.y);
            
            Assert.AreEqual(Half.PositiveInfinity, hvec2.PositiveInfinity.x);
            Assert.AreEqual(Half.PositiveInfinity, hvec2.PositiveInfinity.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new hvec2(new Half(-4), new Half(2.5));
            var v2 = new hvec2(new Half(-4), new Half(2.5));
            var v3 = new hvec2(new Half(2.5), new Half(-4));
            Assert.That(v1 == new hvec2(v1));
            Assert.That(v2 == new hvec2(v2));
            Assert.That(v3 == new hvec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new hvec2(new Half(-9), new Half(5));
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = hvec2.Parse(s0);
            var v1 = hvec2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = hvec2.TryParse(s0, out v0);
            var b1 = hvec2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = hvec2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = hvec2.TryParse("", out v0);
            Assert.False(b0);
            b0 = hvec2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { hvec2.Parse(null); });
            Assert.Throws<FormatException>(() => { hvec2.Parse(""); });
            Assert.Throws<FormatException>(() => { hvec2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = hvec2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = hvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = hvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new hvec2(new Half(-6.5), new Half(6));
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<hvec2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new hvec2(new Half(7.5), new Half(-5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec2(new Half(-4), new Half(-1));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec2(new Half(4), new Half(3));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec2(new Half(4), new Half(3.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec2(new Half(0.5), new Half(0.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec2(new Half(-1), new Half(5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec2(new Half(8), new Half(-0.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec2(new Half(-3.5), new Half(-2));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec2(new Half(2), new Half(-8.5));
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new hvec2(new Half(5), new Half(-6));
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new hvec2(new Half(5.5), new Half(-3));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec2(new Half(-2.5), new Half(-2));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec2(new Half(-8), new Half(4.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec2(new Half(5), new Half(8));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec2(new Half(-6.5), new Half(7));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec2(new Half(-6.5), new Half(1.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec2(new Half(-9), new Half(-7.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec2(new Half(7.5), new Half(-9.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec2(new Half(-2.5), new Half(8.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new hvec2(new Half(9), new Half(-5.5));
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new hvec2(new Half(-2), new Half(-4));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec2(new Half(7), new Half(1.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec2(Half.One, new Half(2.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec2(new Half(-5), new Half(-1.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec2(new Half(6.5), new Half(-2.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec2(new Half(-8.5), new Half(-5.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec2(new Half(-1.5), new Half(6.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec2(new Half(4.5), new Half(-4.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec2(new Half(-1.5), new Half(4.5));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new hvec2(new Half(-2), new Half(8));
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new hvec2(new Half(-6), new Half(-7));
                var v1 = new hvec2(new Half(9.5), new Half(-5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec2(new Half(-3), new Half(9.5));
                var v1 = new hvec2(new Half(5.5), new Half(-1));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec2(new Half(-7), new Half(5.5));
                var v1 = new hvec2(new Half(-2), new Half(8.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec2(new Half(2.5), new Half(8));
                var v1 = new hvec2(new Half(-7), new Half(-8));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec2(new Half(-2.5), new Half(-5));
                var v1 = new hvec2(new Half(5.5), new Half(-4));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec2(new Half(4), new Half(4.5));
                var v1 = new hvec2(new Half(9), new Half(3));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec2(new Half(-9.5), Half.Zero);
                var v1 = new hvec2(new Half(-1), Half.Zero);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec2(new Half(-2.5), new Half(4.5));
                var v1 = new hvec2(new Half(-0.5), new Half(4));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec2(Half.One, new Half(-5));
                var v1 = new hvec2(new Half(9), new Half(3));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new hvec2(Half.One, new Half(-0.5));
                var v1 = new hvec2(new Half(4.5), new Half(-6.5));
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new hvec2(new Half(3), new Half(-3.5));
                var v1 = new hvec2(new Half(-7.5), new Half(-9.5));
                var v2 = new hvec2(new Half(-0.5), new Half(9));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(-6.5), new Half(-9));
                var v1 = new hvec2(new Half(7.5), new Half(0.5));
                var v2 = new hvec2(Half.Zero, new Half(-9.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(-7.5), new Half(-5.5));
                var v1 = new hvec2(new Half(3), new Half(7.5));
                var v2 = new hvec2(new Half(4.5), new Half(6.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(7), new Half(7));
                var v1 = new hvec2(new Half(-8.5), new Half(3.5));
                var v2 = new hvec2(new Half(-3), new Half(-8.5));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec2(Half.Zero, new Half(-8.5));
                var v1 = new hvec2(new Half(2.5), new Half(-5));
                var v2 = new hvec2(new Half(1.5), Half.One);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(2.5), new Half(-8.5));
                var v1 = new hvec2(new Half(8.5), new Half(-8.5));
                var v2 = new hvec2(new Half(7.5), new Half(-3));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(6.5), new Half(-6.5));
                var v1 = new hvec2(new Half(8.5), new Half(-5));
                var v2 = new hvec2(new Half(2), new Half(4));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(-5), new Half(-4.5));
                var v1 = new hvec2(new Half(1.5), new Half(5));
                var v2 = new hvec2(new Half(-9), Half.One);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(2), new Half(-5));
                var v1 = new hvec2(new Half(-5), Half.One);
                var v2 = new hvec2(new Half(-1), new Half(4));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new hvec2(Half.One, new Half(-1));
                var v1 = new hvec2(new Half(-4), Half.Zero);
                var v2 = new hvec2(new Half(-9), new Half(8));
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new hvec2(new Half(5), new Half(-3));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec2(new Half(-7), new Half(-7));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec2(Half.One, new Half(8.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec2(new Half(9.5), new Half(8));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec2(new Half(5), new Half(-9.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec2(new Half(3.5), new Half(9.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec2(new Half(-1), new Half(-1));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec2(new Half(-8), new Half(-0.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec2(new Half(-0.5), new Half(5.5));
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new hvec2(new Half(3.5), new Half(-1.5));
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new hvec2(new Half(-1), new Half(7.5));
                var v1 = new hvec2(new Half(2.5), new Half(-7.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec2(new Half(-9), Half.One);
                var v1 = new hvec2(new Half(3.5), new Half(-9));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec2(new Half(3.5), new Half(3));
                var v1 = new hvec2(new Half(-8.5), new Half(7.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec2(new Half(-1.5), new Half(-7));
                var v1 = new hvec2(new Half(7.5), new Half(5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec2(new Half(8.5), new Half(-1));
                var v1 = new hvec2(new Half(9), new Half(7.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec2(new Half(2.5), new Half(-4.5));
                var v1 = new hvec2(new Half(-5), new Half(7));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec2(new Half(6), new Half(-2.5));
                var v1 = new hvec2(Half.Zero, new Half(-3.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec2(new Half(-0.5), new Half(-1.5));
                var v1 = new hvec2(new Half(-5.5), new Half(2));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec2(new Half(2), new Half(-9));
                var v1 = new hvec2(new Half(2.5), new Half(7.5));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new hvec2(new Half(2.5), new Half(9.5));
                var v1 = new hvec2(new Half(3), new Half(6));
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new hvec2(new Half(-5), new Half(-9.5));
                var v1 = new hvec2(new Half(2), Half.One);
                var v2 = new hvec2(new Half(-0.5), new Half(9));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(9), new Half(-4.5));
                var v1 = new hvec2(Half.Zero, new Half(-7));
                var v2 = new hvec2(new Half(-4.5), new Half(5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(-1.5), new Half(4));
                var v1 = new hvec2(new Half(-4.5), new Half(-6));
                var v2 = new hvec2(new Half(4.5), new Half(-6.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(7.5), new Half(8));
                var v1 = new hvec2(new Half(6), Half.One);
                var v2 = new hvec2(new Half(-9.5), new Half(1.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(5.5), new Half(-4));
                var v1 = new hvec2(new Half(-6.5), new Half(0.5));
                var v2 = new hvec2(new Half(7), new Half(-3.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(5), new Half(5));
                var v1 = new hvec2(new Half(-6), new Half(5.5));
                var v2 = new hvec2(new Half(-4), new Half(8.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(-8.5), new Half(-1.5));
                var v1 = new hvec2(new Half(7.5), Half.One);
                var v2 = new hvec2(new Half(-4.5), new Half(2.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec2(Half.One, new Half(2));
                var v1 = new hvec2(new Half(-5), new Half(9));
                var v2 = new hvec2(new Half(9), new Half(-4.5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(9.5), Half.Zero);
                var v1 = new hvec2(new Half(-4), new Half(-1.5));
                var v2 = new hvec2(new Half(-2.5), new Half(-5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new hvec2(new Half(-5.5), new Half(-4));
                var v1 = new hvec2(new Half(9.5), new Half(-1));
                var v2 = new hvec2(new Half(6), new Half(-5));
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new hvec2(new Half(-7), new Half(3));
                var v1 = new hvec2(new Half(-8), new Half(2));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec2(new Half(-6), new Half(9.5));
                var v1 = new hvec2(new Half(-1.5), new Half(-4.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec2(new Half(-6.5), new Half(-6));
                var v1 = new hvec2(new Half(-6), new Half(7));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec2(new Half(0.5), new Half(4.5));
                var v1 = new hvec2(new Half(9), new Half(7.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec2(new Half(0.5), new Half(-8.5));
                var v1 = new hvec2(new Half(5), new Half(8));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec2(new Half(-2.5), new Half(-7));
                var v1 = new hvec2(new Half(3.5), new Half(-5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec2(new Half(-9.5), new Half(-5.5));
                var v1 = new hvec2(new Half(-7), new Half(7.5));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec2(new Half(-0.5), Half.Zero);
                var v1 = new hvec2(new Half(8.5), new Half(-3));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec2(new Half(4.5), new Half(-2.5));
                var v1 = new hvec2(new Half(6.5), new Half(-1));
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new hvec2(new Half(-2), new Half(-4));
                var v1 = new hvec2(new Half(9.5), Half.Zero);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new hvec2(new Half(9), new Half(-6.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec2(new Half(-0.5), new Half(-3));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec2(new Half(5.5), new Half(4.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec2(Half.One, new Half(3));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec2(new Half(4.5), new Half(7.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec2(new Half(-6), Half.One);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec2(new Half(1.5), new Half(-4.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec2(new Half(-1), new Half(5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec2(new Half(4), new Half(-6));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new hvec2(new Half(-7), new Half(3.5));
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(100083895);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.Random(random, 3, 5);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1528999540);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomUniform(random, -2, 1);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5, 1.0);
            Assert.AreEqual(avg.y, -0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(810431538);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.Random(random, 3, 5);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(91863536);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomUniform(random, -2, 0);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(826872256);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.Random(random, 3, 4);
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
            var random = new Random(243091866);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomNormal(random, new Half(-0.121161404122208), new Half(0.74345937033345));
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.121161404122208, 1.0);
            Assert.AreEqual(avg.y, -0.121161404122208, 1.0);
            
            Assert.AreEqual(variance.x, 0.74345937033345, 3.0);
            Assert.AreEqual(variance.y, 0.74345937033345, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(989255956);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomGaussian(random, new Half(-0.730418823068225), new Half(4.91741801841064));
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.730418823068225, 1.0);
            Assert.AreEqual(avg.y, -0.730418823068225, 1.0);
            
            Assert.AreEqual(variance.x, 4.91741801841064, 3.0);
            Assert.AreEqual(variance.y, 4.91741801841064, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(668056629);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomNormal(random, new Half(1.62351945770137), new Half(6.03476788198332));
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.62351945770137, 1.0);
            Assert.AreEqual(avg.y, 1.62351945770137, 1.0);
            
            Assert.AreEqual(variance.x, 6.03476788198332, 3.0);
            Assert.AreEqual(variance.y, 6.03476788198332, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(564291193);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomGaussian(random, new Half(1.63122775202209), new Half(2.1211224059207));
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.63122775202209, 1.0);
            Assert.AreEqual(avg.y, 1.63122775202209, 1.0);
            
            Assert.AreEqual(variance.x, 2.1211224059207, 3.0);
            Assert.AreEqual(variance.y, 2.1211224059207, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1578545105);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomNormal(random, new Half(-0.738127117388941), new Half(8.83106349447326));
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.738127117388941, 1.0);
            Assert.AreEqual(avg.y, -0.738127117388941, 1.0);
            
            Assert.AreEqual(variance.x, 8.83106349447326, 3.0);
            Assert.AreEqual(variance.y, 8.83106349447326, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(770838095);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomNormal(random);
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
            var random = new Random(1796421923);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomNormal(random);
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
            var random = new Random(674522104);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomNormal(random);
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
            var random = new Random(1700105932);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomNormal(random);
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
            var random = new Random(963470077);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = hvec2.RandomNormal(random);
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
