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
    public class FloatVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new vec2(-5);
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-5, v.y);
            }
            {
                var v = new vec2(-0.5f, -2);
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-2, v.y);
            }
            {
                var v = new vec2(new vec2(-7, 3));
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(3, v.y);
            }
            {
                var v = new vec2(new vec3(-4.5f, -5.5f, -0.5f));
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
            }
            {
                var v = new vec2(new vec4(5.5f, -0.5f, 5, 2.5f));
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new vec2(-5, 6);
            Assert.AreEqual(-5, v[0]);
            Assert.AreEqual(6, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
            
            v[1] = 0f;
            Assert.AreEqual(0f, v[1]);
            v[1] = 1f;
            Assert.AreEqual(1f, v[1]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[1] = 4;
            Assert.AreEqual(4, v[1]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[1] = -1;
            Assert.AreEqual(-1, v[1]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[1] = -6;
            Assert.AreEqual(-6, v[1]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
            v[1] = -9.5f;
            Assert.AreEqual(-9.5f, v[1]);
            v[0] = -8.5f;
            Assert.AreEqual(-8.5f, v[0]);
            v[1] = -7.5f;
            Assert.AreEqual(-7.5f, v[1]);
            v[0] = -6.5f;
            Assert.AreEqual(-6.5f, v[0]);
            v[1] = -5.5f;
            Assert.AreEqual(-5.5f, v[1]);
            v[1] = -4.5f;
            Assert.AreEqual(-4.5f, v[1]);
            v[0] = -3.5f;
            Assert.AreEqual(-3.5f, v[0]);
            v[1] = -2.5f;
            Assert.AreEqual(-2.5f, v[1]);
            v[0] = -1.5f;
            Assert.AreEqual(-1.5f, v[0]);
            v[0] = -0.5f;
            Assert.AreEqual(-0.5f, v[0]);
            v[1] = 0.5f;
            Assert.AreEqual(0.5f, v[1]);
            v[0] = 1.5f;
            Assert.AreEqual(1.5f, v[0]);
            v[1] = 2.5f;
            Assert.AreEqual(2.5f, v[1]);
            v[1] = 3.5f;
            Assert.AreEqual(3.5f, v[1]);
            v[1] = 4.5f;
            Assert.AreEqual(4.5f, v[1]);
            v[0] = 5.5f;
            Assert.AreEqual(5.5f, v[0]);
            v[1] = 6.5f;
            Assert.AreEqual(6.5f, v[1]);
            v[0] = 7.5f;
            Assert.AreEqual(7.5f, v[0]);
            v[1] = 8.5f;
            Assert.AreEqual(8.5f, v[1]);
            v[1] = 9.5f;
            Assert.AreEqual(9.5f, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new vec2(0f, -2);
            var vals = v.Values;
            Assert.AreEqual(0f, vals[0]);
            Assert.AreEqual(-2, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0f, vec2.Zero.x);
            Assert.AreEqual(0f, vec2.Zero.y);
            
            Assert.AreEqual(1f, vec2.Ones.x);
            Assert.AreEqual(1f, vec2.Ones.y);
            
            Assert.AreEqual(1f, vec2.UnitX.x);
            Assert.AreEqual(0f, vec2.UnitX.y);
            
            Assert.AreEqual(0f, vec2.UnitY.x);
            Assert.AreEqual(1f, vec2.UnitY.y);
            
            Assert.AreEqual(float.MaxValue, vec2.MaxValue.x);
            Assert.AreEqual(float.MaxValue, vec2.MaxValue.y);
            
            Assert.AreEqual(float.MinValue, vec2.MinValue.x);
            Assert.AreEqual(float.MinValue, vec2.MinValue.y);
            
            Assert.AreEqual(float.Epsilon, vec2.Epsilon.x);
            Assert.AreEqual(float.Epsilon, vec2.Epsilon.y);
            
            Assert.AreEqual(float.NaN, vec2.NaN.x);
            Assert.AreEqual(float.NaN, vec2.NaN.y);
            
            Assert.AreEqual(float.NegativeInfinity, vec2.NegativeInfinity.x);
            Assert.AreEqual(float.NegativeInfinity, vec2.NegativeInfinity.y);
            
            Assert.AreEqual(float.PositiveInfinity, vec2.PositiveInfinity.x);
            Assert.AreEqual(float.PositiveInfinity, vec2.PositiveInfinity.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new vec2(6.5f, -8.5f);
            var v2 = new vec2(6.5f, -8.5f);
            var v3 = new vec2(-8.5f, 6.5f);
            Assert.That(v1 == new vec2(v1));
            Assert.That(v2 == new vec2(v2));
            Assert.That(v3 == new vec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new vec2(-5.5f, 1.5f);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = vec2.Parse(s0);
            var v1 = vec2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = vec2.TryParse(s0, out v0);
            var b1 = vec2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = vec2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = vec2.TryParse("", out v0);
            Assert.False(b0);
            b0 = vec2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { vec2.Parse(null); });
            Assert.Throws<FormatException>(() => { vec2.Parse(""); });
            Assert.Throws<FormatException>(() => { vec2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = vec2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = vec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = vec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new vec2(9.5f, -8);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<vec2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new vec2(-8.5f, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(8.5f, -9.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(-1.5f, -8);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(9, 1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(7.5f, 6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(9, 1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(-3, -1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(-4, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(4.5f, 1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(-7.5f, -9.5f);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new vec2(-3, -4.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(2, 2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(4.5f, -9.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(0f, 0f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(-5, 2.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(-5.5f, 4.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(-5, 0f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(8, -3.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(5.5f, -8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(3.5f, -9.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new vec2(-1.5f, -4.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(-6.5f, -7.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(-9, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(9, -9.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(-1.5f, -2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(-8.5f, -1.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(-5.5f, -5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(5, 2.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(6.5f, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(5.5f, 4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new vec2(5.5f, 3.5f);
                var v1 = new vec2(6, -8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(7.5f, 3.5f);
                var v1 = new vec2(-7, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-7, -2);
                var v1 = new vec2(9, -3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-6, 9.5f);
                var v1 = new vec2(-6.5f, 7.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(4.5f, 0.5f);
                var v1 = new vec2(-7, -7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(0f, 6.5f);
                var v1 = new vec2(7, 2.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-5.5f, 4);
                var v1 = new vec2(-9, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-8.5f, 0.5f);
                var v1 = new vec2(6, -8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-3.5f, -0.5f);
                var v1 = new vec2(4.5f, 8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(7.5f, 4);
                var v1 = new vec2(-9, -8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new vec2(-8.5f, 7.5f);
                var v1 = new vec2(6.5f, -1);
                var v2 = new vec2(5, 5.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-8, -1);
                var v1 = new vec2(0.5f, -5);
                var v2 = new vec2(0f, -6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-8, 1f);
                var v1 = new vec2(-5, 4);
                var v2 = new vec2(2, -6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(1.5f, 3);
                var v1 = new vec2(9.5f, 0.5f);
                var v2 = new vec2(1.5f, -2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-3, 9.5f);
                var v1 = new vec2(-4, -1);
                var v2 = new vec2(-7.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-8.5f, -3.5f);
                var v1 = new vec2(-1, -3.5f);
                var v2 = new vec2(8, -9.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-8.5f, 6);
                var v1 = new vec2(3, -3);
                var v2 = new vec2(-6.5f, -1.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(8, -9);
                var v1 = new vec2(5, -2);
                var v2 = new vec2(7.5f, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(3, 8.5f);
                var v1 = new vec2(-6, -2.5f);
                var v2 = new vec2(-2.5f, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(5.5f, 0.5f);
                var v1 = new vec2(6, -4.5f);
                var v2 = new vec2(7.5f, 6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new vec2(-6.5f, -4.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(2.5f, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(-8, -4.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(4.5f, 0f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(7.5f, 4);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(4.5f, 2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(6, -0.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(-0.5f, 6.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(7.5f, -5);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(-7, -5.5f);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new vec2(-1.5f, 8);
                var v1 = new vec2(7, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(5.5f, -1.5f);
                var v1 = new vec2(-1.5f, -1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-3.5f, -1.5f);
                var v1 = new vec2(-8.5f, 0f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-5.5f, 4.5f);
                var v1 = new vec2(8, -2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(7, 0.5f);
                var v1 = new vec2(3.5f, 3.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-1, -7.5f);
                var v1 = new vec2(3.5f, 8.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-9, 5);
                var v1 = new vec2(-6.5f, -6.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-9.5f, 9);
                var v1 = new vec2(-3, 7);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-5, -5.5f);
                var v1 = new vec2(4, 4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-6, -6.5f);
                var v1 = new vec2(7, 4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new vec2(-8.5f, -7);
                var v1 = new vec2(4.5f, 3.5f);
                var v2 = new vec2(4, -8.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(-7, 2);
                var v1 = new vec2(-0.5f, -0.5f);
                var v2 = new vec2(8.5f, 5.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(-8, -2);
                var v1 = new vec2(-5.5f, 3.5f);
                var v2 = new vec2(2, 6.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(0f, -3);
                var v1 = new vec2(7.5f, -6.5f);
                var v2 = new vec2(7.5f, 1f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(2.5f, 6);
                var v1 = new vec2(4.5f, -8.5f);
                var v2 = new vec2(-3.5f, 2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(8.5f, 5.5f);
                var v1 = new vec2(-9.5f, 8);
                var v2 = new vec2(9, 0.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(5, -3.5f);
                var v1 = new vec2(4.5f, 4.5f);
                var v2 = new vec2(5.5f, 8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(0f, -4);
                var v1 = new vec2(2.5f, -9);
                var v2 = new vec2(5.5f, -5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(-3, 0f);
                var v1 = new vec2(-9.5f, -5);
                var v2 = new vec2(8.5f, 3.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(-4.5f, 7.5f);
                var v1 = new vec2(-9, 3.5f);
                var v2 = new vec2(0f, 7.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new vec2(3.5f, -4.5f);
                var v1 = new vec2(7, -7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-1, -4.5f);
                var v1 = new vec2(-1.5f, -8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-4, -3);
                var v1 = new vec2(9, 6);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(8, -1);
                var v1 = new vec2(-4.5f, -2.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-3.5f, 1f);
                var v1 = new vec2(-9, 9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-6.5f, -5);
                var v1 = new vec2(5, 8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(0f, -8.5f);
                var v1 = new vec2(3, 7.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(6, 5.5f);
                var v1 = new vec2(-4.5f, 1f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-4, 6);
                var v1 = new vec2(6.5f, 7.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(4.5f, 1f);
                var v1 = new vec2(-6.5f, 0f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new vec2(2.5f, -1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(-4, -7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(-9, 7);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(6, -2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(1f, -4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(-6, 8.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(5.5f, 6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(9.5f, 9.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(6.5f, 7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(3.5f, 7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

    }
}
