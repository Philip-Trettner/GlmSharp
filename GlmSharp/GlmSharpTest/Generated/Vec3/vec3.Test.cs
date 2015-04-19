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
    public class FloatVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new vec3(-7.5f);
                Assert.AreEqual(-7.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-7.5f, v.z);
            }
            {
                var v = new vec3(3.5f, 8.5f, 1f);
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(8.5f, v.y);
                Assert.AreEqual(1f, v.z);
            }
            {
                var v = new vec3(new vec2(3f, -1.5f));
                Assert.AreEqual(3f, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var v = new vec3(new vec3(-9.5f, -1f, -0.5f));
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-1f, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var v = new vec3(new vec4(6f, 9.5f, 0f, 7f));
                Assert.AreEqual(6f, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(0f, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new vec3(-6.5f, -1f, -7.5f);
            Assert.AreEqual(-6.5f, v[0]);
            Assert.AreEqual(-1f, v[1]);
            Assert.AreEqual(-7.5f, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
            
            v[0] = 0f;
            Assert.AreEqual(0f, v[0]);
            v[0] = 1f;
            Assert.AreEqual(1f, v[0]);
            v[0] = 2f;
            Assert.AreEqual(2f, v[0]);
            v[2] = 3f;
            Assert.AreEqual(3f, v[2]);
            v[0] = 4f;
            Assert.AreEqual(4f, v[0]);
            v[0] = 5f;
            Assert.AreEqual(5f, v[0]);
            v[0] = 6f;
            Assert.AreEqual(6f, v[0]);
            v[0] = 7f;
            Assert.AreEqual(7f, v[0]);
            v[1] = 8f;
            Assert.AreEqual(8f, v[1]);
            v[0] = 9f;
            Assert.AreEqual(9f, v[0]);
            v[0] = -1f;
            Assert.AreEqual(-1f, v[0]);
            v[1] = -2f;
            Assert.AreEqual(-2f, v[1]);
            v[2] = -3f;
            Assert.AreEqual(-3f, v[2]);
            v[2] = -4f;
            Assert.AreEqual(-4f, v[2]);
            v[2] = -5f;
            Assert.AreEqual(-5f, v[2]);
            v[0] = -6f;
            Assert.AreEqual(-6f, v[0]);
            v[2] = -7f;
            Assert.AreEqual(-7f, v[2]);
            v[0] = -8f;
            Assert.AreEqual(-8f, v[0]);
            v[0] = -9f;
            Assert.AreEqual(-9f, v[0]);
            v[1] = -9.5f;
            Assert.AreEqual(-9.5f, v[1]);
            v[2] = -8.5f;
            Assert.AreEqual(-8.5f, v[2]);
            v[0] = -7.5f;
            Assert.AreEqual(-7.5f, v[0]);
            v[2] = -6.5f;
            Assert.AreEqual(-6.5f, v[2]);
            v[1] = -5.5f;
            Assert.AreEqual(-5.5f, v[1]);
            v[1] = -4.5f;
            Assert.AreEqual(-4.5f, v[1]);
            v[1] = -3.5f;
            Assert.AreEqual(-3.5f, v[1]);
            v[1] = -2.5f;
            Assert.AreEqual(-2.5f, v[1]);
            v[1] = -1.5f;
            Assert.AreEqual(-1.5f, v[1]);
            v[2] = -0.5f;
            Assert.AreEqual(-0.5f, v[2]);
            v[1] = 0.5f;
            Assert.AreEqual(0.5f, v[1]);
            v[2] = 1.5f;
            Assert.AreEqual(1.5f, v[2]);
            v[2] = 2.5f;
            Assert.AreEqual(2.5f, v[2]);
            v[0] = 3.5f;
            Assert.AreEqual(3.5f, v[0]);
            v[2] = 4.5f;
            Assert.AreEqual(4.5f, v[2]);
            v[1] = 5.5f;
            Assert.AreEqual(5.5f, v[1]);
            v[2] = 6.5f;
            Assert.AreEqual(6.5f, v[2]);
            v[0] = 7.5f;
            Assert.AreEqual(7.5f, v[0]);
            v[1] = 8.5f;
            Assert.AreEqual(8.5f, v[1]);
            v[2] = 9.5f;
            Assert.AreEqual(9.5f, v[2]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new vec3(8f, -6f, -4f);
            var vals = v.Values;
            Assert.AreEqual(8f, vals[0]);
            Assert.AreEqual(-6f, vals[1]);
            Assert.AreEqual(-4f, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0f, vec3.Zero.x);
            Assert.AreEqual(0f, vec3.Zero.y);
            Assert.AreEqual(0f, vec3.Zero.z);
            
            Assert.AreEqual(1f, vec3.Ones.x);
            Assert.AreEqual(1f, vec3.Ones.y);
            Assert.AreEqual(1f, vec3.Ones.z);
            
            Assert.AreEqual(1f, vec3.UnitX.x);
            Assert.AreEqual(0f, vec3.UnitX.y);
            Assert.AreEqual(0f, vec3.UnitX.z);
            
            Assert.AreEqual(0f, vec3.UnitY.x);
            Assert.AreEqual(1f, vec3.UnitY.y);
            Assert.AreEqual(0f, vec3.UnitY.z);
            
            Assert.AreEqual(0f, vec3.UnitZ.x);
            Assert.AreEqual(0f, vec3.UnitZ.y);
            Assert.AreEqual(1f, vec3.UnitZ.z);
            
            Assert.AreEqual(float.MaxValue, vec3.MaxValue.x);
            Assert.AreEqual(float.MaxValue, vec3.MaxValue.y);
            Assert.AreEqual(float.MaxValue, vec3.MaxValue.z);
            
            Assert.AreEqual(float.MinValue, vec3.MinValue.x);
            Assert.AreEqual(float.MinValue, vec3.MinValue.y);
            Assert.AreEqual(float.MinValue, vec3.MinValue.z);
            
            Assert.AreEqual(float.Epsilon, vec3.Epsilon.x);
            Assert.AreEqual(float.Epsilon, vec3.Epsilon.y);
            Assert.AreEqual(float.Epsilon, vec3.Epsilon.z);
            
            Assert.AreEqual(float.NaN, vec3.NaN.x);
            Assert.AreEqual(float.NaN, vec3.NaN.y);
            Assert.AreEqual(float.NaN, vec3.NaN.z);
            
            Assert.AreEqual(float.NegativeInfinity, vec3.NegativeInfinity.x);
            Assert.AreEqual(float.NegativeInfinity, vec3.NegativeInfinity.y);
            Assert.AreEqual(float.NegativeInfinity, vec3.NegativeInfinity.z);
            
            Assert.AreEqual(float.PositiveInfinity, vec3.PositiveInfinity.x);
            Assert.AreEqual(float.PositiveInfinity, vec3.PositiveInfinity.y);
            Assert.AreEqual(float.PositiveInfinity, vec3.PositiveInfinity.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new vec3(-1.5f, -7f, 7f);
            var v2 = new vec3(-1.5f, -7f, 7f);
            var v3 = new vec3(7f, -7f, -1.5f);
            Assert.That(v1 == new vec3(v1));
            Assert.That(v2 == new vec3(v2));
            Assert.That(v3 == new vec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new vec3(-6f, -2.5f, 4f);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = vec3.Parse(s0);
            var v1 = vec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = vec3.TryParse(s0, out v0);
            var b1 = vec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = vec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = vec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = vec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { vec3.Parse(null); });
            Assert.Throws<FormatException>(() => { vec3.Parse(""); });
            Assert.Throws<FormatException>(() => { vec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = vec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = vec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = vec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new vec3(7f, -7.5f, 3.5f);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<vec3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new vec3(-3f, 0f, -2f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(5.5f, -0.5f, -4f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(-4f, -9.5f, 4f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(-0.5f, -7f, 4.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(0f, 5f, -3.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(0.5f, 3.5f, 3.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(-0.5f, -9.5f, 3f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(1f, -5.5f, 2f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(-0.5f, -3.5f, -6f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(3f, -3f, 1f);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new vec3(-8.5f, -1.5f, -0.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(-2.5f, 3.5f, -5.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(6.5f, -7.5f, 8f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(9f, -7f, 2f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(-2.5f, 5f, 6.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(0f, 6.5f, -3.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(-3.5f, -9.5f, 5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(-1.5f, 0.5f, -4f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(1f, 7f, 3f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(2.5f, -6f, 4.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new vec3(6.5f, -0.5f, 9f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(6f, -8f, -7.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(4f, 1f, -7.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(-1.5f, -5f, 6.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(6.5f, -9.5f, 3.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(6f, 8.5f, -6.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(-0.5f, 4f, -4.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(6f, 5.5f, 7f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(3f, 6f, -4f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(8f, -9.5f, 4.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new vec3(-6.5f, 8f, 8f);
                var v1 = new vec3(7.5f, -4.5f, -8f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(0.5f, -1.5f, 8f);
                var v1 = new vec3(-7f, -9.5f, -5.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(0.5f, -9.5f, -3.5f);
                var v1 = new vec3(-1.5f, 2f, -6f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(9.5f, -1.5f, 1.5f);
                var v1 = new vec3(-8.5f, -3.5f, 5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(2.5f, 3.5f, -6f);
                var v1 = new vec3(7.5f, -2.5f, 8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(8f, 0f, -9f);
                var v1 = new vec3(8f, 2.5f, 4.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(0f, -9.5f, -6f);
                var v1 = new vec3(6f, 1.5f, 6f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(-9f, 8.5f, -1.5f);
                var v1 = new vec3(1f, -5.5f, -5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(1f, -2.5f, -1f);
                var v1 = new vec3(-5.5f, 7.5f, 5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(-6.5f, 2f, -6.5f);
                var v1 = new vec3(2f, 5f, 2.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new vec3(-0.5f, 1f, -5.5f);
                var v1 = new vec3(5.5f, 5f, 9.5f);
                var v2 = new vec3(-4f, 3.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(2.5f, 4.5f, 1.5f);
                var v1 = new vec3(0.5f, 6f, 2f);
                var v2 = new vec3(-9f, 3f, -4.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(-4.5f, 3f, 4f);
                var v1 = new vec3(-5f, 0f, 5f);
                var v2 = new vec3(-4f, 7.5f, 0f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(-9f, 4f, -7.5f);
                var v1 = new vec3(8.5f, 3.5f, -0.5f);
                var v2 = new vec3(-7f, 2f, 3.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(7f, -2f, -6f);
                var v1 = new vec3(7.5f, -5f, -3f);
                var v2 = new vec3(7.5f, 9.5f, -9.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(-6.5f, -9.5f, -5.5f);
                var v1 = new vec3(4f, 2f, 9.5f);
                var v2 = new vec3(-4.5f, 7f, -3.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(3f, -4f, 1f);
                var v1 = new vec3(-8f, -8.5f, 8f);
                var v2 = new vec3(9.5f, 4.5f, -0.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(1f, 3.5f, 1f);
                var v1 = new vec3(1f, -3f, 4f);
                var v2 = new vec3(8f, -1f, 1.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(9f, -1.5f, -1.5f);
                var v1 = new vec3(2.5f, -7f, 1f);
                var v2 = new vec3(-4.5f, 0.5f, -8f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(-6f, -5f, 1f);
                var v1 = new vec3(-7.5f, -3f, -4.5f);
                var v2 = new vec3(2f, -4f, -1.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new vec3(0.5f, -1.5f, -9f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(2.5f, -8f, -0.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(0.5f, -7.5f, 1.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(-8.5f, -1.5f, -1f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(-9f, 4.5f, -7f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(-1f, 9.5f, -5.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(9f, -5.5f, -5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(-2.5f, 9f, -6f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(2f, 8.5f, 7f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(2.5f, -9.5f, 7f);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new vec3(6.5f, -3f, 5.5f);
                var v1 = new vec3(7.5f, 5.5f, 1.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(-5.5f, 2.5f, -9f);
                var v1 = new vec3(5f, -5f, 8f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(6.5f, 9.5f, 6.5f);
                var v1 = new vec3(-3.5f, 8f, 9.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(-2.5f, 3.5f, -5f);
                var v1 = new vec3(6f, 2f, 1.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(-9.5f, 3f, 8f);
                var v1 = new vec3(1.5f, 2f, 8f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(0.5f, -5f, 3.5f);
                var v1 = new vec3(-6f, 7.5f, -9f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(3f, -1.5f, -9.5f);
                var v1 = new vec3(-0.5f, 2f, -1f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(9f, 4.5f, 2f);
                var v1 = new vec3(5.5f, -7.5f, 1f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(-8.5f, 3f, 6.5f);
                var v1 = new vec3(6.5f, -8.5f, 6f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(0.5f, -0.5f, 9f);
                var v1 = new vec3(3f, -8f, 1.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new vec3(-1.5f, -9.5f, -8.5f);
                var v1 = new vec3(-8f, 3f, -4.5f);
                var v2 = new vec3(-3f, -5.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(6f, 2.5f, 3f);
                var v1 = new vec3(1.5f, -7f, -3f);
                var v2 = new vec3(7f, 4f, 5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(4.5f, -3f, 2f);
                var v1 = new vec3(7f, 6f, 4.5f);
                var v2 = new vec3(4.5f, 4f, -9.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(-0.5f, 8f, 0f);
                var v1 = new vec3(-6f, 1f, 8.5f);
                var v2 = new vec3(0f, 2f, 4f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(2.5f, 1.5f, 6f);
                var v1 = new vec3(-8f, -2.5f, 2.5f);
                var v2 = new vec3(0.5f, 3.5f, 5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(1.5f, -7f, 4.5f);
                var v1 = new vec3(-4f, 4f, 4f);
                var v2 = new vec3(-3f, -9.5f, 6f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(3.5f, -8.5f, -4f);
                var v1 = new vec3(-3.5f, -5.5f, 9.5f);
                var v2 = new vec3(4f, -6.5f, -6f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(-7.5f, 0.5f, 0.5f);
                var v1 = new vec3(4f, 0.5f, -4f);
                var v2 = new vec3(7f, -5f, -3f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(8.5f, -6f, -4.5f);
                var v1 = new vec3(9f, -8f, -3f);
                var v2 = new vec3(-0.5f, 2f, -2.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(-3.5f, -5f, 4f);
                var v1 = new vec3(6.5f, 2f, -7.5f);
                var v2 = new vec3(2.5f, 6f, -7.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new vec3(-3.5f, -9.5f, 5.5f);
                var v1 = new vec3(0.5f, 4f, 2.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(6.5f, -2f, 4.5f);
                var v1 = new vec3(-6f, -9.5f, -1f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-5.5f, -5.5f, 7f);
                var v1 = new vec3(-8f, 2.5f, -7.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-0.5f, 6f, 3.5f);
                var v1 = new vec3(9.5f, -8.5f, 0f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(9f, 4f, 5.5f);
                var v1 = new vec3(-7.5f, 3.5f, 8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-9f, -7f, 2.5f);
                var v1 = new vec3(3.5f, 3.5f, 4.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(6.5f, -6.5f, -1.5f);
                var v1 = new vec3(4f, 9f, 6f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(2f, -3f, -5.5f);
                var v1 = new vec3(-4f, 0f, -6.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-2f, -9.5f, -0.5f);
                var v1 = new vec3(-2f, 2f, -2.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-5f, -2.5f, 8.5f);
                var v1 = new vec3(4.5f, -9.5f, 9.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new vec3(-4.5f, 7f, -2.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(7.5f, -9f, 4f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-1f, 0.5f, 8f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(6.5f, -7.5f, 0.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-6.5f, 1f, -2f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-4.5f, 5.5f, -1.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(0f, 7.5f, -1f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-0.5f, 1.5f, -8.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-1.5f, 9.5f, 9f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-6.5f, -1.5f, 2.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new vec3(2f, 6.5f, 7f);
                var v1 = new vec3(8f, 3f, 6f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(8f, 0f, 1.5f);
                var v1 = new vec3(-4.5f, 8.5f, 1f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-3f, -4.5f, -6.5f);
                var v1 = new vec3(-5f, -6.5f, -1.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-1.5f, -3f, -5.5f);
                var v1 = new vec3(9f, 5f, 2.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-7.5f, -7.5f, -3f);
                var v1 = new vec3(2f, 7f, 3f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(2f, -2f, 2f);
                var v1 = new vec3(-2f, -4.5f, 9f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(7f, -8f, -8f);
                var v1 = new vec3(9f, -1f, -5.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-9f, 3.5f, 7f);
                var v1 = new vec3(-9f, 4f, -3f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-8.5f, -2.5f, 0.5f);
                var v1 = new vec3(0.5f, -5f, 7f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(3.5f, 3.5f, 0.5f);
                var v1 = new vec3(-6f, -2.5f, -8.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1443245165);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.Random(random, 3, 4);
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
            var random = new Random(724677163);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomUniform(random, 2, 5);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            Assert.AreEqual(avg.z, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(6109161);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.Random(random, -3, 0);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            Assert.AreEqual(avg.z, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1435024806);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomUniform(random, 2, 4);
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
        public void RandomUniform4()
        {
            var random = new Random(22549879);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.Random(random, -3, -1);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            Assert.AreEqual(avg.z, -2, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(1586253136);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomNormal(random, 1.41087636882946f, 1.2698647944582f);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.41087636882946, 1.0);
            Assert.AreEqual(avg.y, 1.41087636882946, 1.0);
            Assert.AreEqual(avg.z, 1.41087636882946, 1.0);
            
            Assert.AreEqual(variance.x, 1.2698647944582, 3.0);
            Assert.AreEqual(variance.y, 1.2698647944582, 3.0);
            Assert.AreEqual(variance.z, 1.2698647944582, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(1793578333);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomGaussian(random, 0.80161894988344f, 5.44382347047507f);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.80161894988344, 1.0);
            Assert.AreEqual(avg.y, 0.80161894988344, 1.0);
            Assert.AreEqual(avg.z, 0.80161894988344, 1.0);
            
            Assert.AreEqual(variance.x, 5.44382347047507, 3.0);
            Assert.AreEqual(variance.y, 5.44382347047507, 3.0);
            Assert.AreEqual(variance.z, 5.44382347047507, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(1204289184);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomNormal(random, 0.0914816847497044f, 5.50836242991889f);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.0914816847497044, 1.0);
            Assert.AreEqual(avg.y, 0.0914816847497044, 1.0);
            Assert.AreEqual(avg.z, 0.0914816847497044, 1.0);
            
            Assert.AreEqual(variance.x, 5.50836242991889, 3.0);
            Assert.AreEqual(variance.y, 5.50836242991889, 3.0);
            Assert.AreEqual(variance.z, 5.50836242991889, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(1368613570);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomGaussian(random, 1.72268629247448f, 6.69268582327882f);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.72268629247448, 1.0);
            Assert.AreEqual(avg.y, 1.72268629247448, 1.0);
            Assert.AreEqual(avg.z, 1.72268629247448, 1.0);
            
            Assert.AreEqual(variance.x, 6.69268582327882, 3.0);
            Assert.AreEqual(variance.y, 6.69268582327882, 3.0);
            Assert.AreEqual(variance.z, 6.69268582327882, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(235383835);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomNormal(random, 1.72983510965939f, 8.30465807034851f);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.72983510965939, 1.0);
            Assert.AreEqual(avg.y, 1.72983510965939, 1.0);
            Assert.AreEqual(avg.z, 1.72983510965939, 1.0);
            
            Assert.AreEqual(variance.x, 8.30465807034851, 3.0);
            Assert.AreEqual(variance.y, 8.30465807034851, 3.0);
            Assert.AreEqual(variance.z, 8.30465807034851, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(2113999365);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomNormal(random);
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
            var random = new Random(992099546);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomNormal(random);
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
            var random = new Random(2017683374);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomNormal(random);
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
            var random = new Random(895783555);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomNormal(random);
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
            var random = new Random(159147700);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec3.RandomNormal(random);
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
