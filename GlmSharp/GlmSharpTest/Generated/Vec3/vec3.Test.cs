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
                var v = new vec3(new vec2(3, -1.5f));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-1.5f, v.y);
                Assert.AreEqual(0f, v.z);
            }
            {
                var v = new vec3(new vec3(-9.5f, -1, -0.5f));
                Assert.AreEqual(-9.5f, v.x);
                Assert.AreEqual(-1, v.y);
                Assert.AreEqual(-0.5f, v.z);
            }
            {
                var v = new vec3(new vec4(6, 9.5f, 0f, 7));
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(9.5f, v.y);
                Assert.AreEqual(0f, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new vec3(-6.5f, -1, -7.5f);
            Assert.AreEqual(-6.5f, v[0]);
            Assert.AreEqual(-1, v[1]);
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
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[2] = -3;
            Assert.AreEqual(-3, v[2]);
            v[2] = -4;
            Assert.AreEqual(-4, v[2]);
            v[2] = -5;
            Assert.AreEqual(-5, v[2]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[2] = -7;
            Assert.AreEqual(-7, v[2]);
            v[0] = -8;
            Assert.AreEqual(-8, v[0]);
            v[0] = -9;
            Assert.AreEqual(-9, v[0]);
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
            var v = new vec3(8, -6, -4);
            var vals = v.Values;
            Assert.AreEqual(8, vals[0]);
            Assert.AreEqual(-6, vals[1]);
            Assert.AreEqual(-4, vals[2]);
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
            var v1 = new vec3(-1.5f, -7, 7);
            var v2 = new vec3(-1.5f, -7, 7);
            var v3 = new vec3(7, -7, -1.5f);
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
            var v = new vec3(-6, -2.5f, 4);
            
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
            var v0 = new vec3(7, -7.5f, 3.5f);
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
                var v0 = new vec3(-3, 0f, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(5.5f, -0.5f, -4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(-4, -9.5f, 4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(-0.5f, -7, 4.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(0f, 5, -3.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(0.5f, 3.5f, 3.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(-0.5f, -9.5f, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(1f, -5.5f, 2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(-0.5f, -3.5f, -6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec3(3, -3, 1f);
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
                var v0 = new vec3(6.5f, -7.5f, 8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(9, -7, 2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(-2.5f, 5, 6.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(0f, 6.5f, -3.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(-3.5f, -9.5f, 5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(-1.5f, 0.5f, -4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(1f, 7, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec3(2.5f, -6, 4.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new vec3(6.5f, -0.5f, 9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(6, -8, -7.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(4, 1f, -7.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(-1.5f, -5, 6.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(6.5f, -9.5f, 3.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(6, 8.5f, -6.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(-0.5f, 4, -4.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(6, 5.5f, 7);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(3, 6, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec3(8, -9.5f, 4.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new vec3(-6.5f, 8, 8);
                var v1 = new vec3(7.5f, -4.5f, -8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(0.5f, -1.5f, 8);
                var v1 = new vec3(-7, -9.5f, -5.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(0.5f, -9.5f, -3.5f);
                var v1 = new vec3(-1.5f, 2, -6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(9.5f, -1.5f, 1.5f);
                var v1 = new vec3(-8.5f, -3.5f, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(2.5f, 3.5f, -6);
                var v1 = new vec3(7.5f, -2.5f, 8.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(8, 0f, -9);
                var v1 = new vec3(8, 2.5f, 4.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(0f, -9.5f, -6);
                var v1 = new vec3(6, 1.5f, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(-9, 8.5f, -1.5f);
                var v1 = new vec3(1f, -5.5f, -5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(1f, -2.5f, -1);
                var v1 = new vec3(-5.5f, 7.5f, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec3(-6.5f, 2, -6.5f);
                var v1 = new vec3(2, 5, 2.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new vec3(-0.5f, 1f, -5.5f);
                var v1 = new vec3(5.5f, 5, 9.5f);
                var v2 = new vec3(-4, 3.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(2.5f, 4.5f, 1.5f);
                var v1 = new vec3(0.5f, 6, 2);
                var v2 = new vec3(-9, 3, -4.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(-4.5f, 3, 4);
                var v1 = new vec3(-5, 0f, 5);
                var v2 = new vec3(-4, 7.5f, 0f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(-9, 4, -7.5f);
                var v1 = new vec3(8.5f, 3.5f, -0.5f);
                var v2 = new vec3(-7, 2, 3.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(7, -2, -6);
                var v1 = new vec3(7.5f, -5, -3);
                var v2 = new vec3(7.5f, 9.5f, -9.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(-6.5f, -9.5f, -5.5f);
                var v1 = new vec3(4, 2, 9.5f);
                var v2 = new vec3(-4.5f, 7, -3.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(3, -4, 1f);
                var v1 = new vec3(-8, -8.5f, 8);
                var v2 = new vec3(9.5f, 4.5f, -0.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(1f, 3.5f, 1f);
                var v1 = new vec3(1f, -3, 4);
                var v2 = new vec3(8, -1, 1.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(9, -1.5f, -1.5f);
                var v1 = new vec3(2.5f, -7, 1f);
                var v2 = new vec3(-4.5f, 0.5f, -8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec3(-6, -5, 1f);
                var v1 = new vec3(-7.5f, -3, -4.5f);
                var v2 = new vec3(2, -4, -1.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new vec3(0.5f, -1.5f, -9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(2.5f, -8, -0.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(0.5f, -7.5f, 1.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(-8.5f, -1.5f, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(-9, 4.5f, -7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(-1, 9.5f, -5.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(9, -5.5f, -5);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(-2.5f, 9, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(2, 8.5f, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec3(2.5f, -9.5f, 7);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new vec3(6.5f, -3, 5.5f);
                var v1 = new vec3(7.5f, 5.5f, 1.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(-5.5f, 2.5f, -9);
                var v1 = new vec3(5, -5, 8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(6.5f, 9.5f, 6.5f);
                var v1 = new vec3(-3.5f, 8, 9.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(-2.5f, 3.5f, -5);
                var v1 = new vec3(6, 2, 1.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(-9.5f, 3, 8);
                var v1 = new vec3(1.5f, 2, 8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(0.5f, -5, 3.5f);
                var v1 = new vec3(-6, 7.5f, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(3, -1.5f, -9.5f);
                var v1 = new vec3(-0.5f, 2, -1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(9, 4.5f, 2);
                var v1 = new vec3(5.5f, -7.5f, 1f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(-8.5f, 3, 6.5f);
                var v1 = new vec3(6.5f, -8.5f, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec3(0.5f, -0.5f, 9);
                var v1 = new vec3(3, -8, 1.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new vec3(-1.5f, -9.5f, -8.5f);
                var v1 = new vec3(-8, 3, -4.5f);
                var v2 = new vec3(-3, -5.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(6, 2.5f, 3);
                var v1 = new vec3(1.5f, -7, -3);
                var v2 = new vec3(7, 4, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(4.5f, -3, 2);
                var v1 = new vec3(7, 6, 4.5f);
                var v2 = new vec3(4.5f, 4, -9.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(-0.5f, 8, 0f);
                var v1 = new vec3(-6, 1f, 8.5f);
                var v2 = new vec3(0f, 2, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(2.5f, 1.5f, 6);
                var v1 = new vec3(-8, -2.5f, 2.5f);
                var v2 = new vec3(0.5f, 3.5f, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(1.5f, -7, 4.5f);
                var v1 = new vec3(-4, 4, 4);
                var v2 = new vec3(-3, -9.5f, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(3.5f, -8.5f, -4);
                var v1 = new vec3(-3.5f, -5.5f, 9.5f);
                var v2 = new vec3(4, -6.5f, -6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(-7.5f, 0.5f, 0.5f);
                var v1 = new vec3(4, 0.5f, -4);
                var v2 = new vec3(7, -5, -3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(8.5f, -6, -4.5f);
                var v1 = new vec3(9, -8, -3);
                var v2 = new vec3(-0.5f, 2, -2.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec3(-3.5f, -5, 4);
                var v1 = new vec3(6.5f, 2, -7.5f);
                var v2 = new vec3(2.5f, 6, -7.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new vec3(-3.5f, -9.5f, 5.5f);
                var v1 = new vec3(0.5f, 4, 2.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(6.5f, -2, 4.5f);
                var v1 = new vec3(-6, -9.5f, -1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-5.5f, -5.5f, 7);
                var v1 = new vec3(-8, 2.5f, -7.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-0.5f, 6, 3.5f);
                var v1 = new vec3(9.5f, -8.5f, 0f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(9, 4, 5.5f);
                var v1 = new vec3(-7.5f, 3.5f, 8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-9, -7, 2.5f);
                var v1 = new vec3(3.5f, 3.5f, 4.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(6.5f, -6.5f, -1.5f);
                var v1 = new vec3(4, 9, 6);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(2, -3, -5.5f);
                var v1 = new vec3(-4, 0f, -6.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-2, -9.5f, -0.5f);
                var v1 = new vec3(-2, 2, -2.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec3(-5, -2.5f, 8.5f);
                var v1 = new vec3(4.5f, -9.5f, 9.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new vec3(-4.5f, 7, -2.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(7.5f, -9, 4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-1, 0.5f, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(6.5f, -7.5f, 0.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-6.5f, 1f, -2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-4.5f, 5.5f, -1.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(0f, 7.5f, -1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-0.5f, 1.5f, -8.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec3(-1.5f, 9.5f, 9);
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
                var v0 = new vec3(2, 6.5f, 7);
                var v1 = new vec3(8, 3, 6);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(8, 0f, 1.5f);
                var v1 = new vec3(-4.5f, 8.5f, 1f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-3, -4.5f, -6.5f);
                var v1 = new vec3(-5, -6.5f, -1.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-1.5f, -3, -5.5f);
                var v1 = new vec3(9, 5, 2.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-7.5f, -7.5f, -3);
                var v1 = new vec3(2, 7, 3);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(2, -2, 2);
                var v1 = new vec3(-2, -4.5f, 9);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(7, -8, -8);
                var v1 = new vec3(9, -1, -5.5f);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-9, 3.5f, 7);
                var v1 = new vec3(-9, 4, -3);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(-8.5f, -2.5f, 0.5f);
                var v1 = new vec3(0.5f, -5, 7);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new vec3(3.5f, 3.5f, 0.5f);
                var v1 = new vec3(-6, -2.5f, -8.5f);
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
            var variance =  sumSqr / (double)count - avg * avg;
            
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
            var variance =  sumSqr / (double)count - avg * avg;
            
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
            var variance =  sumSqr / (double)count - avg * avg;
            
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
            var variance =  sumSqr / (double)count - avg * avg;
            
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
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            Assert.AreEqual(avg.z, -2, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.333333333333333, 3.0);
        }

    }
}
