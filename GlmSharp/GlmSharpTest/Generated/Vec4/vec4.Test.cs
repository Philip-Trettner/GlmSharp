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
                var v = new vec4(7.5f, -4.5f, -3.5f, 2);
                Assert.AreEqual(7.5f, v.x);
                Assert.AreEqual(-4.5f, v.y);
                Assert.AreEqual(-3.5f, v.z);
                Assert.AreEqual(2, v.w);
            }
            {
                var v = new vec4(new vec2(2.5f, -5));
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(-5, v.y);
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
                var v = new vec4(new vec4(2.5f, 8, -9.5f, 0.5f));
                Assert.AreEqual(2.5f, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-9.5f, v.z);
                Assert.AreEqual(0.5f, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new vec4(1.5f, -5, 8, 2.5f);
            Assert.AreEqual(1.5f, v[0]);
            Assert.AreEqual(-5, v[1]);
            Assert.AreEqual(8, v[2]);
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
            v[3] = 2;
            Assert.AreEqual(2, v[3]);
            v[3] = 3;
            Assert.AreEqual(3, v[3]);
            v[0] = 4;
            Assert.AreEqual(4, v[0]);
            v[3] = 5;
            Assert.AreEqual(5, v[3]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[3] = -3;
            Assert.AreEqual(-3, v[3]);
            v[0] = -4;
            Assert.AreEqual(-4, v[0]);
            v[3] = -5;
            Assert.AreEqual(-5, v[3]);
            v[3] = -6;
            Assert.AreEqual(-6, v[3]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[3] = -8;
            Assert.AreEqual(-8, v[3]);
            v[2] = -9;
            Assert.AreEqual(-9, v[2]);
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
            var v = new vec4(-6, -9.5f, 0f, 5);
            var vals = v.Values;
            Assert.AreEqual(-6, vals[0]);
            Assert.AreEqual(-9.5f, vals[1]);
            Assert.AreEqual(0f, vals[2]);
            Assert.AreEqual(5, vals[3]);
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
            var v1 = new vec4(-8.5f, -3, -8.5f, 7.5f);
            var v2 = new vec4(-8.5f, -3, -8.5f, 7.5f);
            var v3 = new vec4(7.5f, -8.5f, -3, -8.5f);
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
            var v = new vec4(7, -5.5f, -8, 9.5f);
            
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

    }
}
