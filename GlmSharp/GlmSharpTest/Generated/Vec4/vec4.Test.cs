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
    public class FloatVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new vec4(0.5f);
                Assert.AreEqual(0.5f, v.x);
                Assert.AreEqual(0.5f, v.y);
                Assert.AreEqual(0.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
            {
                var v = new vec4(7.5f, -4.5f, -3.5f, 2f);
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(2f, v.w);
            }
            {
                var v = new vec4(new vec2(2.5f, -5f));
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-5f, v.y);
                Assert.AreEqual(0f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var v = new vec4(new vec3(3.5f, -7.5f, -6.5f));
                Assert.AreEqual(3.5f, v.x);
                Assert.AreEqual(-7.5f, v.y);
                Assert.AreEqual(-6.5f, v.z);
                Assert.AreEqual(0f, v.w);
            }
            {
                var v = new vec4(new vec4(2.5f, 8f, -9.5f, 0.5f));
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(8f, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new vec4(1.5f, -5f, 8f, 2.5f);
            Assert.AreEqual(1.5f, v[0]);
            Assert.AreEqual(-5f, v[1]);
            Assert.AreEqual(8f, v[2]);
            Assert.AreEqual(2.5f, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0f; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0f; } );
            
            v[1] = 0f;
            Assert.AreEqual(0f, v[1]);
            v[1] = 1f;
            Assert.AreEqual(1f, v[1]);
            v[3] = 2f;
            Assert.AreEqual(2f, v[3]);
            v[3] = 3f;
            Assert.AreEqual(3f, v[3]);
            v[0] = 4f;
            Assert.AreEqual(4f, v[0]);
            v[3] = 5f;
            Assert.AreEqual(5f, v[3]);
            v[0] = 6f;
            Assert.AreEqual(6f, v[0]);
            v[2] = 7f;
            Assert.AreEqual(7f, v[2]);
            v[1] = 8f;
            Assert.AreEqual(8f, v[1]);
            v[1] = 9f;
            Assert.AreEqual(9f, v[1]);
            v[0] = -1f;
            Assert.AreEqual(-1f, v[0]);
            v[1] = -2f;
            Assert.AreEqual(-2f, v[1]);
            v[3] = -3f;
            Assert.AreEqual(-3f, v[3]);
            v[0] = -4f;
            Assert.AreEqual(-4f, v[0]);
            v[3] = -5f;
            Assert.AreEqual(-5f, v[3]);
            v[3] = -6f;
            Assert.AreEqual(-6f, v[3]);
            v[0] = -7f;
            Assert.AreEqual(-7f, v[0]);
            v[3] = -8f;
            Assert.AreEqual(-8f, v[3]);
            v[2] = -9f;
            Assert.AreEqual(-9f, v[2]);
            v[2] = -9.5f;
            Assert.AreEqual(-9.5f, v[2]);
            v[0] = -8.5f;
            Assert.AreEqual(-8.5f, v[0]);
            v[3] = -7.5f;
            Assert.AreEqual(-7.5f, v[3]);
            v[0] = -6.5f;
            Assert.AreEqual(-6.5f, v[0]);
            v[2] = -5.5f;
            Assert.AreEqual(-5.5f, v[2]);
            v[0] = -4.5f;
            Assert.AreEqual(-4.5f, v[0]);
            v[1] = -3.5f;
            Assert.AreEqual(-3.5f, v[1]);
            v[3] = -2.5f;
            Assert.AreEqual(-2.5f, v[3]);
            v[3] = -1.5f;
            Assert.AreEqual(-1.5f, v[3]);
            v[0] = -0.5f;
            Assert.AreEqual(-0.5f, v[0]);
            v[1] = 0.5f;
            Assert.AreEqual(0.5f, v[1]);
            v[2] = 1.5f;
            Assert.AreEqual(1.5f, v[2]);
            v[2] = 2.5f;
            Assert.AreEqual(2.5f, v[2]);
            v[1] = 3.5f;
            Assert.AreEqual(3.5f, v[1]);
            v[3] = 4.5f;
            Assert.AreEqual(4.5f, v[3]);
            v[0] = 5.5f;
            Assert.AreEqual(5.5f, v[0]);
            v[3] = 6.5f;
            Assert.AreEqual(6.5f, v[3]);
            v[1] = 7.5f;
            Assert.AreEqual(7.5f, v[1]);
            v[1] = 8.5f;
            Assert.AreEqual(8.5f, v[1]);
            v[3] = 9.5f;
            Assert.AreEqual(9.5f, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new vec4(-6f, -9.5f, 0f, 5f);
            var vals = v.Values;
            Assert.AreEqual(-6f, vals[0]);
            Assert.AreEqual(-9.5f, vals[1]);
            Assert.AreEqual(0f, vals[2]);
            Assert.AreEqual(5f, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0f, vec4.Zero.x);
            Assert.AreEqual(0f, vec4.Zero.y);
            Assert.AreEqual(0f, vec4.Zero.z);
            Assert.AreEqual(0f, vec4.Zero.w);
            
            Assert.AreEqual(1f, vec4.Ones.x);
            Assert.AreEqual(1f, vec4.Ones.y);
            Assert.AreEqual(1f, vec4.Ones.z);
            Assert.AreEqual(1f, vec4.Ones.w);
            
            Assert.AreEqual(1f, vec4.UnitX.x);
            Assert.AreEqual(0f, vec4.UnitX.y);
            Assert.AreEqual(0f, vec4.UnitX.z);
            Assert.AreEqual(0f, vec4.UnitX.w);
            
            Assert.AreEqual(0f, vec4.UnitY.x);
            Assert.AreEqual(1f, vec4.UnitY.y);
            Assert.AreEqual(0f, vec4.UnitY.z);
            Assert.AreEqual(0f, vec4.UnitY.w);
            
            Assert.AreEqual(0f, vec4.UnitZ.x);
            Assert.AreEqual(0f, vec4.UnitZ.y);
            Assert.AreEqual(1f, vec4.UnitZ.z);
            Assert.AreEqual(0f, vec4.UnitZ.w);
            
            Assert.AreEqual(0f, vec4.UnitW.x);
            Assert.AreEqual(0f, vec4.UnitW.y);
            Assert.AreEqual(0f, vec4.UnitW.z);
            Assert.AreEqual(1f, vec4.UnitW.w);
            
            Assert.AreEqual(float.MaxValue, vec4.MaxValue.x);
            Assert.AreEqual(float.MaxValue, vec4.MaxValue.y);
            Assert.AreEqual(float.MaxValue, vec4.MaxValue.z);
            Assert.AreEqual(float.MaxValue, vec4.MaxValue.w);
            
            Assert.AreEqual(float.MinValue, vec4.MinValue.x);
            Assert.AreEqual(float.MinValue, vec4.MinValue.y);
            Assert.AreEqual(float.MinValue, vec4.MinValue.z);
            Assert.AreEqual(float.MinValue, vec4.MinValue.w);
            
            Assert.AreEqual(float.Epsilon, vec4.Epsilon.x);
            Assert.AreEqual(float.Epsilon, vec4.Epsilon.y);
            Assert.AreEqual(float.Epsilon, vec4.Epsilon.z);
            Assert.AreEqual(float.Epsilon, vec4.Epsilon.w);
            
            Assert.AreEqual(float.NaN, vec4.NaN.x);
            Assert.AreEqual(float.NaN, vec4.NaN.y);
            Assert.AreEqual(float.NaN, vec4.NaN.z);
            Assert.AreEqual(float.NaN, vec4.NaN.w);
            
            Assert.AreEqual(float.NegativeInfinity, vec4.NegativeInfinity.x);
            Assert.AreEqual(float.NegativeInfinity, vec4.NegativeInfinity.y);
            Assert.AreEqual(float.NegativeInfinity, vec4.NegativeInfinity.z);
            Assert.AreEqual(float.NegativeInfinity, vec4.NegativeInfinity.w);
            
            Assert.AreEqual(float.PositiveInfinity, vec4.PositiveInfinity.x);
            Assert.AreEqual(float.PositiveInfinity, vec4.PositiveInfinity.y);
            Assert.AreEqual(float.PositiveInfinity, vec4.PositiveInfinity.z);
            Assert.AreEqual(float.PositiveInfinity, vec4.PositiveInfinity.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new vec4(-8.5f, -3f, -8.5f, 7.5f);
            var v2 = new vec4(-8.5f, -3f, -8.5f, 7.5f);
            var v3 = new vec4(7.5f, -8.5f, -3f, -8.5f);
            Assert.That(v1 == new vec4(v1));
            Assert.That(v2 == new vec4(v2));
            Assert.That(v3 == new vec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new vec4(7f, -5.5f, -8f, 9.5f);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = vec4.Parse(s0);
            var v1 = vec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = vec4.TryParse(s0, out v0);
            var b1 = vec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = vec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = vec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = vec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { vec4.Parse(null); });
            Assert.Throws<FormatException>(() => { vec4.Parse(""); });
            Assert.Throws<FormatException>(() => { vec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = vec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = vec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = vec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new vec4(-6f, -3.5f, -9.5f, 9f);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<vec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new vec4(4f, 6.5f, -4.5f, -1f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec4(-0.5f, -1f, -8f, 7.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec4(-1f, -2f, -6.5f, -3.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec4(-1.5f, 0f, 8.5f, -6f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec4(1.5f, -5.5f, 5.5f, -9.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec4(8.5f, -7f, -5f, 8f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec4(-2.5f, -0.5f, 0.5f, 5.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec4(0.5f, 3f, 6f, -9.5f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec4(6f, 1f, -3f, -7f);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new vec4(-4f, 2.5f, -1f, -5f);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new vec4(-1.5f, 2.5f, -6f, -2f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec4(3.5f, -2.5f, 1.5f, 4f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec4(2f, -3.5f, -1f, -1f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec4(9.5f, -1f, -5.5f, -5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec4(7.5f, 5.5f, -9.5f, -8.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec4(-1f, -3f, 0f, 7f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec4(2f, 5f, -0.5f, 0f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec4(8.5f, 2.5f, 2.5f, -8f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec4(-3f, -0.5f, 2f, 2.5f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new vec4(-6.5f, -9f, 3.5f, 4f);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new vec4(4f, 3.5f, 6.5f, 1.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec4(-8f, -3.5f, 0f, -5.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec4(-5f, 5f, 8f, 3f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec4(8f, -4.5f, -7.5f, -8.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec4(9.5f, 1.5f, -7.5f, 4f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec4(0.5f, 1.5f, 4f, 1f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec4(4f, 3f, 9.5f, -7f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec4(2f, 2.5f, -4f, -2.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec4(7.5f, -1.5f, 8.5f, 1.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new vec4(6f, -4f, 6f, -6.5f);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new vec4(-6f, -4f, -9f, -2.5f);
                var v1 = new vec4(-8f, -4f, 0.5f, 1.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec4(4f, -0.5f, -0.5f, 6f);
                var v1 = new vec4(7.5f, 8.5f, -4.5f, 0.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec4(-6f, -4.5f, 5.5f, -9.5f);
                var v1 = new vec4(8f, 6f, -2f, -2f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec4(-2f, -4f, -7.5f, 3f);
                var v1 = new vec4(7.5f, 8.5f, -7.5f, -9f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec4(-6.5f, -2f, 6.5f, 1.5f);
                var v1 = new vec4(2f, -8.5f, -4.5f, -2f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec4(0f, 8f, 2f, 7f);
                var v1 = new vec4(-3f, -3.5f, 1.5f, 4.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec4(-4.5f, -2.5f, 2.5f, -6.5f);
                var v1 = new vec4(1.5f, 0f, -0.5f, 8f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec4(2f, 6f, -6f, 4f);
                var v1 = new vec4(2.5f, -2.5f, 4.5f, 5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec4(6f, -1f, -5.5f, -4.5f);
                var v1 = new vec4(2f, 4.5f, -2.5f, 4.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new vec4(9.5f, -5.5f, -9f, 0f);
                var v1 = new vec4(4f, 3f, 8.5f, -3.5f);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new vec4(6.5f, 5f, -1f, -9.5f);
                var v1 = new vec4(5f, 2f, 9f, -5f);
                var v2 = new vec4(-7f, 8f, -2.5f, 9.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec4(2f, -2f, 0.5f, 3.5f);
                var v1 = new vec4(4f, 4.5f, -9f, 3f);
                var v2 = new vec4(9f, 8.5f, 9f, 8.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec4(-6f, 4.5f, -3.5f, -2.5f);
                var v1 = new vec4(-2.5f, -9.5f, -6f, 9.5f);
                var v2 = new vec4(7f, 8f, 5.5f, 7f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec4(4.5f, -7f, -1.5f, -8.5f);
                var v1 = new vec4(7f, 7.5f, -2.5f, -9f);
                var v2 = new vec4(3.5f, 5.5f, 1f, 3f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec4(5f, 6f, -5.5f, -5.5f);
                var v1 = new vec4(-0.5f, 9.5f, -2f, 7.5f);
                var v2 = new vec4(5.5f, -2f, 4f, -1f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec4(-7f, -7.5f, -1.5f, 6.5f);
                var v1 = new vec4(3.5f, -1.5f, 1.5f, 4.5f);
                var v2 = new vec4(-7f, -6.5f, 8.5f, -1.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec4(5f, 7.5f, 6.5f, -3f);
                var v1 = new vec4(-2f, 0.5f, 4f, -9.5f);
                var v2 = new vec4(3.5f, -7.5f, -7.5f, -9.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec4(6.5f, 1.5f, -1f, 8f);
                var v1 = new vec4(6.5f, 7.5f, -2f, -6.5f);
                var v2 = new vec4(-3f, -7f, 4f, -4.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec4(8f, 1.5f, -3.5f, 5f);
                var v1 = new vec4(3f, 7f, -2.5f, -6.5f);
                var v2 = new vec4(7f, 6.5f, -9f, 2.5f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new vec4(2f, 9.5f, -3.5f, 4f);
                var v1 = new vec4(6f, -5.5f, -8f, 4.5f);
                var v2 = new vec4(0f, 7f, 9.5f, 1f);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new vec4(8.5f, 2.5f, 5f, -7f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec4(-8f, 2.5f, -3.5f, 4f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec4(-5.5f, 8.5f, -8.5f, -9f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec4(1.5f, 9.5f, 5f, -4.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec4(0f, 2.5f, 3f, -5.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec4(-9f, -2f, -9.5f, 9f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec4(3f, 5.5f, 4.5f, 0f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec4(2f, 5f, -6.5f, -3.5f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec4(-7f, -1.5f, -5.5f, -1f);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new vec4(-9.5f, -4f, 3.5f, 3f);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new vec4(3f, -6f, -7.5f, -7.5f);
                var v1 = new vec4(4.5f, 5.5f, -9.5f, -5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec4(-3f, -6.5f, 8f, -7f);
                var v1 = new vec4(8f, 4f, -5.5f, 0f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec4(9f, 7f, -9.5f, 3.5f);
                var v1 = new vec4(-9.5f, 0.5f, -2f, -4.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec4(-7.5f, 1f, 5.5f, 9.5f);
                var v1 = new vec4(-4.5f, 6f, 8f, -8.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec4(-2f, 6f, 0.5f, 2.5f);
                var v1 = new vec4(0.5f, 3.5f, 2.5f, -3f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec4(4.5f, 5.5f, 9.5f, -5f);
                var v1 = new vec4(-6f, 6f, 3f, -8.5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec4(-6.5f, 7f, -8.5f, 5.5f);
                var v1 = new vec4(2f, -9.5f, 8.5f, -3f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec4(3f, 6.5f, 0f, 3.5f);
                var v1 = new vec4(0f, -9.5f, 0.5f, 5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec4(-5f, -2.5f, 5f, 2f);
                var v1 = new vec4(-5f, 2.5f, -1f, -6f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new vec4(-5f, 7f, 9.5f, -4.5f);
                var v1 = new vec4(1.5f, 7.5f, 8f, -5f);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new vec4(6.5f, -5.5f, 7f, 2f);
                var v1 = new vec4(3f, -1.5f, 8f, 6f);
                var v2 = new vec4(-6f, -5.5f, -4.5f, -2f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec4(3f, -7.5f, 0f, -7.5f);
                var v1 = new vec4(5f, -4f, -2.5f, -3f);
                var v2 = new vec4(6f, 2.5f, -7f, -1.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec4(5.5f, 2f, 5f, 7.5f);
                var v1 = new vec4(1.5f, 9.5f, 3.5f, 8f);
                var v2 = new vec4(-7f, 1.5f, 5.5f, -8f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec4(-9.5f, 6.5f, -9f, 1f);
                var v1 = new vec4(-9f, -7f, -9f, -4f);
                var v2 = new vec4(-9f, 3f, 9.5f, -4f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec4(-6f, 7f, -1.5f, -2f);
                var v1 = new vec4(0f, -9f, 1f, 4f);
                var v2 = new vec4(7f, -9.5f, 7f, 1f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec4(-7.5f, -1f, -5f, -7f);
                var v1 = new vec4(0.5f, -7f, 4.5f, -2f);
                var v2 = new vec4(-3.5f, -7.5f, 2f, 8f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec4(4.5f, -4.5f, 3.5f, 0.5f);
                var v1 = new vec4(-3f, 2f, 8f, 2.5f);
                var v2 = new vec4(2f, 2.5f, -7.5f, -6.5f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec4(-1f, -8.5f, 7f, 8.5f);
                var v1 = new vec4(-0.5f, 1.5f, 9f, 9.5f);
                var v2 = new vec4(-0.5f, -8f, -9.5f, 8f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec4(2f, 2f, -5.5f, 2f);
                var v1 = new vec4(8f, -2.5f, -2.5f, 3.5f);
                var v2 = new vec4(5f, -9.5f, -8f, -6f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new vec4(-4.5f, -2f, 1.5f, 5f);
                var v1 = new vec4(-2f, -5f, 9.5f, 0.5f);
                var v2 = new vec4(-1.5f, 2.5f, 5f, 8f);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new vec4(0.5f, 3f, 0.5f, 6f);
                var v1 = new vec4(-6.5f, -6f, -4f, -8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec4(3.5f, 8f, 7f, -8f);
                var v1 = new vec4(1f, 1.5f, 9f, 0f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec4(-4f, -6.5f, -7.5f, 1.5f);
                var v1 = new vec4(8f, -5f, 3f, -7.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec4(1.5f, 8f, -7f, 3f);
                var v1 = new vec4(-8.5f, -3f, 3f, 2.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec4(1.5f, -2.5f, -9.5f, 5f);
                var v1 = new vec4(4f, -3f, -1.5f, 5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec4(6.5f, 8.5f, 1f, -7f);
                var v1 = new vec4(-6f, -5.5f, -6.5f, -8f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec4(-3.5f, 6.5f, 8f, -8f);
                var v1 = new vec4(-7.5f, 8f, -2.5f, -5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec4(9.5f, 8f, -6f, -5f);
                var v1 = new vec4(8.5f, 9f, 0f, -8.5f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec4(4f, -6f, -3.5f, -5f);
                var v1 = new vec4(-1f, 4f, 6.5f, 1f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new vec4(4.5f, -6f, 4.5f, 9f);
                var v1 = new vec4(-4f, -2.5f, 5f, 6f);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new vec4(-7f, 3f, 0f, -3f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec4(-9f, 0f, -6f, 7f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec4(-5f, -9f, -0.5f, -7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec4(-1f, 6.5f, -6.5f, -1f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec4(4.5f, -9f, 6f, 7.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec4(6f, 5f, -7.5f, -1.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec4(-3.5f, 2f, -5.5f, -5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec4(5f, 3.5f, 3.5f, 0.5f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec4(-2.5f, 3f, 6f, -9f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new vec4(4.5f, -5.5f, 4f, 7f);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(1862401202);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.Random(random, -2, 1);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5, 1.0);
            Assert.AreEqual(avg.y, -0.5, 1.0);
            Assert.AreEqual(avg.z, -0.5, 1.0);
            Assert.AreEqual(avg.w, -0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.75, 3.0);
            Assert.AreEqual(variance.y, 0.75, 3.0);
            Assert.AreEqual(variance.z, 0.75, 3.0);
            Assert.AreEqual(variance.w, 0.75, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1143833200);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomUniform(random, 3, 5);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            Assert.AreEqual(avg.z, 4, 1.0);
            Assert.AreEqual(avg.w, 4, 1.0);
            
            Assert.AreEqual(variance.x, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.333333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.333333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(425265198);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.Random(random, -2, -1);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.5, 1.0);
            Assert.AreEqual(avg.y, -1.5, 1.0);
            Assert.AreEqual(avg.z, -1.5, 1.0);
            Assert.AreEqual(avg.w, -1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(1854180843);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomUniform(random, 3, 4);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.5, 1.0);
            Assert.AreEqual(avg.y, 3.5, 1.0);
            Assert.AreEqual(avg.z, 3.5, 1.0);
            Assert.AreEqual(avg.w, 3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.w, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(441705916);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.Random(random, -2, 2);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomGaussian0()
        {
            var random = new Random(2005409173);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomNormal(random, 1.79478494999687f, 7.95614184250875f);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.79478494999687, 1.0);
            Assert.AreEqual(avg.y, 1.79478494999687, 1.0);
            Assert.AreEqual(avg.z, 1.79478494999687, 1.0);
            Assert.AreEqual(avg.w, 1.79478494999687, 1.0);
            
            Assert.AreEqual(variance.x, 7.95614184250875, 3.0);
            Assert.AreEqual(variance.y, 7.95614184250875, 3.0);
            Assert.AreEqual(variance.z, 7.95614184250875, 3.0);
            Assert.AreEqual(variance.w, 7.95614184250875, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(1374422296);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomGaussian(random, 1.18552753105086f, 2.13010051852562f);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.18552753105086, 1.0);
            Assert.AreEqual(avg.y, 1.18552753105086, 1.0);
            Assert.AreEqual(avg.z, 1.18552753105086, 1.0);
            Assert.AreEqual(avg.w, 1.18552753105086, 1.0);
            
            Assert.AreEqual(variance.x, 2.13010051852562, 3.0);
            Assert.AreEqual(variance.y, 2.13010051852562, 3.0);
            Assert.AreEqual(variance.z, 2.13010051852562, 3.0);
            Assert.AreEqual(variance.w, 2.13010051852562, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(785133147);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomNormal(random, -0.292426896417712f, 8.82208540980801f);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.292426896417712, 1.0);
            Assert.AreEqual(avg.y, -0.292426896417712, 1.0);
            Assert.AreEqual(avg.z, -0.292426896417712, 1.0);
            Assert.AreEqual(avg.w, -0.292426896417712, 1.0);
            
            Assert.AreEqual(variance.x, 8.82208540980801, 3.0);
            Assert.AreEqual(variance.y, 8.82208540980801, 3.0);
            Assert.AreEqual(variance.z, 8.82208540980801, 3.0);
            Assert.AreEqual(variance.w, 8.82208540980801, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(949457533);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomGaussian(random, 1.33877771130706f, 0.00640877522826603f);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.33877771130706, 1.0);
            Assert.AreEqual(avg.y, 1.33877771130706, 1.0);
            Assert.AreEqual(avg.z, 1.33877771130706, 1.0);
            Assert.AreEqual(avg.w, 1.33877771130706, 1.0);
            
            Assert.AreEqual(variance.x, 0.00640877522826603, 3.0);
            Assert.AreEqual(variance.y, 0.00640877522826603, 3.0);
            Assert.AreEqual(variance.z, 0.00640877522826603, 3.0);
            Assert.AreEqual(variance.w, 0.00640877522826603, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1963711445);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomNormal(random, 1.34592652849198f, 1.61838102229795f);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.34592652849198, 1.0);
            Assert.AreEqual(avg.y, 1.34592652849198, 1.0);
            Assert.AreEqual(avg.z, 1.34592652849198, 1.0);
            Assert.AreEqual(avg.w, 1.34592652849198, 1.0);
            
            Assert.AreEqual(variance.x, 1.61838102229795, 3.0);
            Assert.AreEqual(variance.y, 1.61838102229795, 3.0);
            Assert.AreEqual(variance.z, 1.61838102229795, 3.0);
            Assert.AreEqual(variance.w, 1.61838102229795, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(385671755);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomNormal(random);
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
            var random = new Random(1411255583);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomNormal(random);
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
            var random = new Random(289355764);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomNormal(random);
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
            var random = new Random(1314939592);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomNormal(random);
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
            var random = new Random(578303737);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = vec4.RandomNormal(random);
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
