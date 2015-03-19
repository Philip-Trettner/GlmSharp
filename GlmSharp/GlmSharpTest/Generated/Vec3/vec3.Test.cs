using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using NUnit.Framework;
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

    }
}
