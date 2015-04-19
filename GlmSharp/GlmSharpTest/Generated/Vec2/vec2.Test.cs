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
                var v = new vec2(-5f);
                Assert.AreEqual(-5f, v.x);
                Assert.AreEqual(-5f, v.y);
            }
            {
                var v = new vec2(-0.5f, -2f);
                Assert.AreEqual(-0.5f, v.x);
                Assert.AreEqual(-2f, v.y);
            }
            {
                var v = new vec2(new vec2(-7f, 3f));
                Assert.AreEqual(-7f, v.x);
                Assert.AreEqual(3f, v.y);
            }
            {
                var v = new vec2(new vec3(-4.5f, -5.5f, -0.5f));
                Assert.AreEqual(-4.5f, v.x);
                Assert.AreEqual(-5.5f, v.y);
            }
            {
                var v = new vec2(new vec4(5.5f, -0.5f, 5f, 2.5f));
                Assert.AreEqual(5.5f, v.x);
                Assert.AreEqual(-0.5f, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new vec2(-5f, 6f);
            Assert.AreEqual(-5f, v[0]);
            Assert.AreEqual(6f, v[1]);
            
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
            v[0] = 2f;
            Assert.AreEqual(2f, v[0]);
            v[0] = 3f;
            Assert.AreEqual(3f, v[0]);
            v[1] = 4f;
            Assert.AreEqual(4f, v[1]);
            v[1] = 5f;
            Assert.AreEqual(5f, v[1]);
            v[0] = 6f;
            Assert.AreEqual(6f, v[0]);
            v[1] = 7f;
            Assert.AreEqual(7f, v[1]);
            v[0] = 8f;
            Assert.AreEqual(8f, v[0]);
            v[0] = 9f;
            Assert.AreEqual(9f, v[0]);
            v[1] = -1f;
            Assert.AreEqual(-1f, v[1]);
            v[0] = -2f;
            Assert.AreEqual(-2f, v[0]);
            v[1] = -3f;
            Assert.AreEqual(-3f, v[1]);
            v[1] = -4f;
            Assert.AreEqual(-4f, v[1]);
            v[1] = -5f;
            Assert.AreEqual(-5f, v[1]);
            v[1] = -6f;
            Assert.AreEqual(-6f, v[1]);
            v[0] = -7f;
            Assert.AreEqual(-7f, v[0]);
            v[1] = -8f;
            Assert.AreEqual(-8f, v[1]);
            v[1] = -9f;
            Assert.AreEqual(-9f, v[1]);
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
            var v = new vec2(0f, -2f);
            var vals = v.Values;
            Assert.AreEqual(0f, vals[0]);
            Assert.AreEqual(-2f, vals[1]);
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
            var v0 = new vec2(9.5f, -8f);
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
                var v0 = new vec2(-8.5f, 3f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(8.5f, -9.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(-1.5f, -8f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(9f, 1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(7.5f, 6f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(9f, 1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(-3f, -1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec2(-4f, 5f);
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
                var v0 = new vec2(-3f, -4.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(2f, 2f);
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
                var v0 = new vec2(-5f, 2.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(-5.5f, 4.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(-5f, 0f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(8f, -3.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec2(5.5f, -8f);
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
                var v0 = new vec2(-9f, -9f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(9f, -9.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(-1.5f, -2f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(-8.5f, -1.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(-5.5f, -5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(5f, 2.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(6.5f, -4f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec2(5.5f, 4f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new vec2(5.5f, 3.5f);
                var v1 = new vec2(6f, -8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(7.5f, 3.5f);
                var v1 = new vec2(-7f, 7f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-7f, -2f);
                var v1 = new vec2(9f, -3f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-6f, 9.5f);
                var v1 = new vec2(-6.5f, 7.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(4.5f, 0.5f);
                var v1 = new vec2(-7f, -7f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(0f, 6.5f);
                var v1 = new vec2(7f, 2.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-5.5f, 4f);
                var v1 = new vec2(-9f, 9f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-8.5f, 0.5f);
                var v1 = new vec2(6f, -8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(-3.5f, -0.5f);
                var v1 = new vec2(4.5f, 8f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec2(7.5f, 4f);
                var v1 = new vec2(-9f, -8f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new vec2(-8.5f, 7.5f);
                var v1 = new vec2(6.5f, -1f);
                var v2 = new vec2(5f, 5.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-8f, -1f);
                var v1 = new vec2(0.5f, -5f);
                var v2 = new vec2(0f, -6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-8f, 1f);
                var v1 = new vec2(-5f, 4f);
                var v2 = new vec2(2f, -6f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(1.5f, 3f);
                var v1 = new vec2(9.5f, 0.5f);
                var v2 = new vec2(1.5f, -2f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-3f, 9.5f);
                var v1 = new vec2(-4f, -1f);
                var v2 = new vec2(-7.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-8.5f, -3.5f);
                var v1 = new vec2(-1f, -3.5f);
                var v2 = new vec2(8f, -9.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(-8.5f, 6f);
                var v1 = new vec2(3f, -3f);
                var v2 = new vec2(-6.5f, -1.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(8f, -9f);
                var v1 = new vec2(5f, -2f);
                var v2 = new vec2(7.5f, 4f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(3f, 8.5f);
                var v1 = new vec2(-6f, -2.5f);
                var v2 = new vec2(-2.5f, -4f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec2(5.5f, 0.5f);
                var v1 = new vec2(6f, -4.5f);
                var v2 = new vec2(7.5f, 6f);
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
                var v0 = new vec2(2.5f, 7f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(-8f, -4.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(4.5f, 0f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(7.5f, 4f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(4.5f, 2f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(6f, -0.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(-0.5f, 6.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(7.5f, -5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec2(-7f, -5.5f);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new vec2(-1.5f, 8f);
                var v1 = new vec2(7f, -3f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(5.5f, -1.5f);
                var v1 = new vec2(-1.5f, -1f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-3.5f, -1.5f);
                var v1 = new vec2(-8.5f, 0f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-5.5f, 4.5f);
                var v1 = new vec2(8f, -2f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(7f, 0.5f);
                var v1 = new vec2(3.5f, 3.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-1f, -7.5f);
                var v1 = new vec2(3.5f, 8.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-9f, 5f);
                var v1 = new vec2(-6.5f, -6.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-9.5f, 9f);
                var v1 = new vec2(-3f, 7f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-5f, -5.5f);
                var v1 = new vec2(4f, 4f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec2(-6f, -6.5f);
                var v1 = new vec2(7f, 4f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new vec2(-8.5f, -7f);
                var v1 = new vec2(4.5f, 3.5f);
                var v2 = new vec2(4f, -8.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(-7f, 2f);
                var v1 = new vec2(-0.5f, -0.5f);
                var v2 = new vec2(8.5f, 5.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(-8f, -2f);
                var v1 = new vec2(-5.5f, 3.5f);
                var v2 = new vec2(2f, 6.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(0f, -3f);
                var v1 = new vec2(7.5f, -6.5f);
                var v2 = new vec2(7.5f, 1f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(2.5f, 6f);
                var v1 = new vec2(4.5f, -8.5f);
                var v2 = new vec2(-3.5f, 2f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(8.5f, 5.5f);
                var v1 = new vec2(-9.5f, 8f);
                var v2 = new vec2(9f, 0.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(5f, -3.5f);
                var v1 = new vec2(4.5f, 4.5f);
                var v2 = new vec2(5.5f, 8f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(0f, -4f);
                var v1 = new vec2(2.5f, -9f);
                var v2 = new vec2(5.5f, -5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(-3f, 0f);
                var v1 = new vec2(-9.5f, -5f);
                var v2 = new vec2(8.5f, 3.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec2(-4.5f, 7.5f);
                var v1 = new vec2(-9f, 3.5f);
                var v2 = new vec2(0f, 7.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new vec2(3.5f, -4.5f);
                var v1 = new vec2(7f, -7f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-1f, -4.5f);
                var v1 = new vec2(-1.5f, -8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-4f, -3f);
                var v1 = new vec2(9f, 6f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(8f, -1f);
                var v1 = new vec2(-4.5f, -2.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-3.5f, 1f);
                var v1 = new vec2(-9f, 9f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-6.5f, -5f);
                var v1 = new vec2(5f, 8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(0f, -8.5f);
                var v1 = new vec2(3f, 7.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(6f, 5.5f);
                var v1 = new vec2(-4.5f, 1f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec2(-4f, 6f);
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
                var v0 = new vec2(2.5f, -1f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(-4f, -7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(-9f, 7f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(6f, -2f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(1f, -4f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(-6f, 8.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec2(5.5f, 6f);
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

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1024089128);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.Random(random, -1, 1);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(305521126);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomUniform(random, 1, 5);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1734436771);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.Random(random, -4, 0);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1015868769);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomUniform(random, 1, 4);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1750877489);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.Random(random, -4, -1);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2.5, 1.0);
            Assert.AreEqual(avg.y, -2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(1167097099);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomNormal(random, 1.02696778766204f, 4.58358774640764f);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.02696778766204, 1.0);
            Assert.AreEqual(avg.y, 1.02696778766204, 1.0);
            
            Assert.AreEqual(variance.x, 4.58358774640764, 3.0);
            Assert.AreEqual(variance.y, 4.58358774640764, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(65250723);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomGaussian(random, 0.417710368716023f, 8.75754639448484f);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.417710368716023, 1.0);
            Assert.AreEqual(avg.y, 0.417710368716023, 1.0);
            
            Assert.AreEqual(variance.x, 8.75754639448484, 3.0);
            Assert.AreEqual(variance.y, 8.75754639448484, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(1623445221);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomNormal(random, 0.475390265917122f, 2.19463950590912f);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.475390265917122, 1.0);
            Assert.AreEqual(avg.y, 0.475390265917122, 1.0);
            
            Assert.AreEqual(variance.x, 2.19463950590912, 3.0);
            Assert.AreEqual(variance.y, 2.19463950590912, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(1787769607);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomGaussian(random, -1.89340512635811f, 3.37896287132938f);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.89340512635811, 1.0);
            Assert.AreEqual(avg.y, -1.89340512635811, 1.0);
            
            Assert.AreEqual(variance.x, 3.37896287132938, 3.0);
            Assert.AreEqual(variance.y, 3.37896287132938, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(654539872);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomNormal(random, -1.88625630917319f, 4.99093511839907f);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.88625630917319, 1.0);
            Assert.AreEqual(avg.y, -1.88625630917319, 1.0);
            
            Assert.AreEqual(variance.x, 4.99093511839907, 3.0);
            Assert.AreEqual(variance.y, 4.99093511839907, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(1694843328);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomNormal(random);
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
            var random = new Random(572943509);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomNormal(random);
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
            var random = new Random(1598527337);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomNormal(random);
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
            var random = new Random(476627518);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomNormal(random);
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
            var random = new Random(1887475310);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec2.RandomNormal(random);
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
