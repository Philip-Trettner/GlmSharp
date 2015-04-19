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
    public class DoubleVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec4(-7.5d);
                Assert.AreEqual(-7.5d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(-7.5d, v.z);
                Assert.AreEqual(-7.5d, v.w);
            }
            {
                var v = new dvec4(1.5d, -8d, -3.5d, 0.0);
                Assert.AreEqual(1.5d, v.x);
                Assert.AreEqual(-8d, v.y);
                Assert.AreEqual(-3.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec2(-3.5d, 1.5d));
                Assert.AreEqual(-3.5d, v.x);
                Assert.AreEqual(1.5d, v.y);
                Assert.AreEqual(0.0, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec3(-2d, 8.5d, 0.5d));
                Assert.AreEqual(-2d, v.x);
                Assert.AreEqual(8.5d, v.y);
                Assert.AreEqual(0.5d, v.z);
                Assert.AreEqual(0.0, v.w);
            }
            {
                var v = new dvec4(new dvec4(-4.5d, -2d, 4.5d, -1d));
                Assert.AreEqual(-4.5d, v.x);
                Assert.AreEqual(-2d, v.y);
                Assert.AreEqual(4.5d, v.z);
                Assert.AreEqual(-1d, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new dvec4(8.5d, 4.5d, 3d, 1.0);
            Assert.AreEqual(8.5d, v[0]);
            Assert.AreEqual(4.5d, v[1]);
            Assert.AreEqual(3d, v[2]);
            Assert.AreEqual(1.0, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[1] = 0.0;
            Assert.AreEqual(0.0, v[1]);
            v[3] = 1.0;
            Assert.AreEqual(1.0, v[3]);
            v[1] = 2d;
            Assert.AreEqual(2d, v[1]);
            v[2] = 3d;
            Assert.AreEqual(3d, v[2]);
            v[3] = 4d;
            Assert.AreEqual(4d, v[3]);
            v[2] = 5d;
            Assert.AreEqual(5d, v[2]);
            v[2] = 6d;
            Assert.AreEqual(6d, v[2]);
            v[2] = 7d;
            Assert.AreEqual(7d, v[2]);
            v[2] = 8d;
            Assert.AreEqual(8d, v[2]);
            v[1] = 9d;
            Assert.AreEqual(9d, v[1]);
            v[0] = -1d;
            Assert.AreEqual(-1d, v[0]);
            v[1] = -2d;
            Assert.AreEqual(-2d, v[1]);
            v[0] = -3d;
            Assert.AreEqual(-3d, v[0]);
            v[3] = -4d;
            Assert.AreEqual(-4d, v[3]);
            v[2] = -5d;
            Assert.AreEqual(-5d, v[2]);
            v[3] = -6d;
            Assert.AreEqual(-6d, v[3]);
            v[0] = -7d;
            Assert.AreEqual(-7d, v[0]);
            v[0] = -8d;
            Assert.AreEqual(-8d, v[0]);
            v[1] = -9d;
            Assert.AreEqual(-9d, v[1]);
            v[0] = -9.5d;
            Assert.AreEqual(-9.5d, v[0]);
            v[2] = -8.5d;
            Assert.AreEqual(-8.5d, v[2]);
            v[1] = -7.5d;
            Assert.AreEqual(-7.5d, v[1]);
            v[1] = -6.5d;
            Assert.AreEqual(-6.5d, v[1]);
            v[0] = -5.5d;
            Assert.AreEqual(-5.5d, v[0]);
            v[1] = -4.5d;
            Assert.AreEqual(-4.5d, v[1]);
            v[1] = -3.5d;
            Assert.AreEqual(-3.5d, v[1]);
            v[3] = -2.5d;
            Assert.AreEqual(-2.5d, v[3]);
            v[0] = -1.5d;
            Assert.AreEqual(-1.5d, v[0]);
            v[2] = -0.5d;
            Assert.AreEqual(-0.5d, v[2]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[0] = 1.5d;
            Assert.AreEqual(1.5d, v[0]);
            v[1] = 2.5d;
            Assert.AreEqual(2.5d, v[1]);
            v[2] = 3.5d;
            Assert.AreEqual(3.5d, v[2]);
            v[1] = 4.5d;
            Assert.AreEqual(4.5d, v[1]);
            v[3] = 5.5d;
            Assert.AreEqual(5.5d, v[3]);
            v[1] = 6.5d;
            Assert.AreEqual(6.5d, v[1]);
            v[3] = 7.5d;
            Assert.AreEqual(7.5d, v[3]);
            v[0] = 8.5d;
            Assert.AreEqual(8.5d, v[0]);
            v[3] = 9.5d;
            Assert.AreEqual(9.5d, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new dvec4(6.5d, 8d, 1.0, 6d);
            var vals = v.Values;
            Assert.AreEqual(6.5d, vals[0]);
            Assert.AreEqual(8d, vals[1]);
            Assert.AreEqual(1.0, vals[2]);
            Assert.AreEqual(6d, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, dvec4.Zero.x);
            Assert.AreEqual(0.0, dvec4.Zero.y);
            Assert.AreEqual(0.0, dvec4.Zero.z);
            Assert.AreEqual(0.0, dvec4.Zero.w);
            
            Assert.AreEqual(1.0, dvec4.Ones.x);
            Assert.AreEqual(1.0, dvec4.Ones.y);
            Assert.AreEqual(1.0, dvec4.Ones.z);
            Assert.AreEqual(1.0, dvec4.Ones.w);
            
            Assert.AreEqual(1.0, dvec4.UnitX.x);
            Assert.AreEqual(0.0, dvec4.UnitX.y);
            Assert.AreEqual(0.0, dvec4.UnitX.z);
            Assert.AreEqual(0.0, dvec4.UnitX.w);
            
            Assert.AreEqual(0.0, dvec4.UnitY.x);
            Assert.AreEqual(1.0, dvec4.UnitY.y);
            Assert.AreEqual(0.0, dvec4.UnitY.z);
            Assert.AreEqual(0.0, dvec4.UnitY.w);
            
            Assert.AreEqual(0.0, dvec4.UnitZ.x);
            Assert.AreEqual(0.0, dvec4.UnitZ.y);
            Assert.AreEqual(1.0, dvec4.UnitZ.z);
            Assert.AreEqual(0.0, dvec4.UnitZ.w);
            
            Assert.AreEqual(0.0, dvec4.UnitW.x);
            Assert.AreEqual(0.0, dvec4.UnitW.y);
            Assert.AreEqual(0.0, dvec4.UnitW.z);
            Assert.AreEqual(1.0, dvec4.UnitW.w);
            
            Assert.AreEqual(double.MaxValue, dvec4.MaxValue.x);
            Assert.AreEqual(double.MaxValue, dvec4.MaxValue.y);
            Assert.AreEqual(double.MaxValue, dvec4.MaxValue.z);
            Assert.AreEqual(double.MaxValue, dvec4.MaxValue.w);
            
            Assert.AreEqual(double.MinValue, dvec4.MinValue.x);
            Assert.AreEqual(double.MinValue, dvec4.MinValue.y);
            Assert.AreEqual(double.MinValue, dvec4.MinValue.z);
            Assert.AreEqual(double.MinValue, dvec4.MinValue.w);
            
            Assert.AreEqual(double.Epsilon, dvec4.Epsilon.x);
            Assert.AreEqual(double.Epsilon, dvec4.Epsilon.y);
            Assert.AreEqual(double.Epsilon, dvec4.Epsilon.z);
            Assert.AreEqual(double.Epsilon, dvec4.Epsilon.w);
            
            Assert.AreEqual(double.NaN, dvec4.NaN.x);
            Assert.AreEqual(double.NaN, dvec4.NaN.y);
            Assert.AreEqual(double.NaN, dvec4.NaN.z);
            Assert.AreEqual(double.NaN, dvec4.NaN.w);
            
            Assert.AreEqual(double.NegativeInfinity, dvec4.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, dvec4.NegativeInfinity.y);
            Assert.AreEqual(double.NegativeInfinity, dvec4.NegativeInfinity.z);
            Assert.AreEqual(double.NegativeInfinity, dvec4.NegativeInfinity.w);
            
            Assert.AreEqual(double.PositiveInfinity, dvec4.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, dvec4.PositiveInfinity.y);
            Assert.AreEqual(double.PositiveInfinity, dvec4.PositiveInfinity.z);
            Assert.AreEqual(double.PositiveInfinity, dvec4.PositiveInfinity.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new dvec4(4d, 3.5d, 5.5d, -6d);
            var v2 = new dvec4(4d, 3.5d, 5.5d, -6d);
            var v3 = new dvec4(-6d, 5.5d, 3.5d, 4d);
            Assert.That(v1 == new dvec4(v1));
            Assert.That(v2 == new dvec4(v2));
            Assert.That(v3 == new dvec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new dvec4(0.0, 3d, -6.5d, 1.5d);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = dvec4.Parse(s0);
            var v1 = dvec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = dvec4.TryParse(s0, out v0);
            var b1 = dvec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = dvec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = dvec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = dvec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { dvec4.Parse(null); });
            Assert.Throws<FormatException>(() => { dvec4.Parse(""); });
            Assert.Throws<FormatException>(() => { dvec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = dvec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = dvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = dvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new dvec4(6.5d, 2d, -6.5d, 2d);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<dvec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new dvec4(-8.5d, 9d, 1.5d, 2d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec4(6.5d, -1d, 5.5d, -1.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec4(-4d, 7d, -4.5d, 9d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec4(3.5d, 4.5d, 7.5d, 1.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec4(-3d, 6d, 8d, 3d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec4(-2.5d, -8d, -3d, -5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec4(5d, 8.5d, -3d, 8.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec4(-6.5d, 4d, 9d, -2.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec4(7.5d, -9.5d, -7.5d, 4.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec4(5.5d, -5.5d, 6d, 1.0);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new dvec4(-5.5d, 6.5d, -2.5d, 0.0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec4(9d, 1.5d, -5d, 0.0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec4(-9d, -3.5d, 6d, -1d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec4(-5d, 1.5d, 3.5d, 2.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec4(9d, -6.5d, 5d, 7.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec4(-4.5d, -2.5d, -5.5d, 1.0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec4(3d, -7.5d, -3.5d, 5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec4(-8d, 6.5d, -1d, -1.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec4(-6.5d, -0.5d, -3d, 0.0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec4(8.5d, 0.0, -7d, -7d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new dvec4(-2d, -4d, 1.5d, 9.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec4(-2.5d, 1.0, -7.5d, -4d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec4(2d, 3d, 3.5d, 2d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec4(-9.5d, -7.5d, -9d, -3.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec4(-4d, -7.5d, -3d, 2d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec4(0.5d, 8.5d, 3.5d, -7.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec4(-7.5d, -0.5d, 7d, 5.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec4(-3d, 4.5d, -6d, 7.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec4(-8d, 9d, -7.5d, -7.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec4(-4d, 9.5d, 8.5d, 2d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new dvec4(-8d, 7d, 4.5d, -9.5d);
                var v1 = new dvec4(-8.5d, -9d, 1.0, 1.0);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec4(-6d, -6d, 4d, -1d);
                var v1 = new dvec4(8.5d, -8.5d, -4d, -7d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec4(-2.5d, -1d, 4.5d, 6d);
                var v1 = new dvec4(3d, -2.5d, 9d, -5.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec4(6.5d, 6d, 0.5d, -4.5d);
                var v1 = new dvec4(-8d, 1.5d, -4.5d, 3d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec4(-3d, -9.5d, 8d, 4d);
                var v1 = new dvec4(3d, -6.5d, 2.5d, 9.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec4(8d, 0.5d, -8d, -2.5d);
                var v1 = new dvec4(-6d, 5.5d, 1.0, 7.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec4(3d, 1.0, -6d, 3d);
                var v1 = new dvec4(-4d, -1d, -2.5d, 0.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec4(8.5d, 9d, -5.5d, -5d);
                var v1 = new dvec4(-1.5d, -6d, -6.5d, -5.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec4(0.5d, 1.0, 8.5d, -8d);
                var v1 = new dvec4(-3d, 8d, -3d, 4d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec4(-8d, 5.5d, 7.5d, -3d);
                var v1 = new dvec4(9d, -6.5d, 8d, 1.0);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new dvec4(-6d, -6.5d, 2.5d, 3.5d);
                var v1 = new dvec4(7.5d, -6d, 7.5d, 0.5d);
                var v2 = new dvec4(4d, 4d, 0.5d, -7.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec4(-2d, 0.5d, -2.5d, -4d);
                var v1 = new dvec4(2d, -5.5d, 7d, -5d);
                var v2 = new dvec4(-3.5d, 1.0, -4d, -1d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec4(1.5d, 3.5d, -0.5d, -9d);
                var v1 = new dvec4(-0.5d, 8d, -2.5d, 6d);
                var v2 = new dvec4(-1.5d, -1d, -8.5d, -3.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec4(-3.5d, 2d, -7.5d, 0.0);
                var v1 = new dvec4(-1.5d, 5d, -4.5d, 0.0);
                var v2 = new dvec4(6d, 7.5d, 4d, 9d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec4(5d, 3.5d, 2d, -7.5d);
                var v1 = new dvec4(2.5d, 3d, 4.5d, -5d);
                var v2 = new dvec4(8d, -8.5d, 1.0, 4d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec4(-3.5d, -9d, 0.0, 5.5d);
                var v1 = new dvec4(-8d, -6.5d, 4.5d, 1.0);
                var v2 = new dvec4(8d, 0.0, -2.5d, 0.0);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec4(2d, 6d, -2.5d, -8.5d);
                var v1 = new dvec4(-6d, -4d, 3d, 3.5d);
                var v2 = new dvec4(-1.5d, -9.5d, -3d, 5.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec4(6d, 4d, -5d, -5.5d);
                var v1 = new dvec4(-6d, 6d, -7d, 5d);
                var v2 = new dvec4(0.0, -8d, -4d, 8d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec4(4d, -0.5d, -6.5d, -5.5d);
                var v1 = new dvec4(3d, 3d, 0.0, 4d);
                var v2 = new dvec4(5d, 1.0, -9.5d, -4.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec4(-7d, -3d, 8.5d, 5.5d);
                var v1 = new dvec4(-8d, 8d, -6d, 6d);
                var v2 = new dvec4(5d, 5d, -0.5d, -3d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new dvec4(-4d, 6.5d, 6.5d, 6.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec4(-3.5d, -3.5d, -8.5d, 0.0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec4(6.5d, -5d, 6.5d, 1.0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec4(-6.5d, 2d, -3d, -7.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec4(7d, -3.5d, -7.5d, 4.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec4(-6d, -1.5d, 4d, 9.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec4(2d, 2.5d, -8.5d, 5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec4(-3d, -6.5d, -9d, -8.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec4(-9d, 0.5d, 2.5d, -7.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec4(1.0, 5d, -7d, -8d);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new dvec4(8d, -2d, -8.5d, 0.5d);
                var v1 = new dvec4(8d, -6.5d, -2.5d, 0.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec4(8d, 0.5d, 8d, 3d);
                var v1 = new dvec4(5d, 7.5d, 3.5d, 6d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec4(7.5d, -1d, 5d, -4.5d);
                var v1 = new dvec4(-6d, 9d, -2d, -5.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec4(-4.5d, -2.5d, -9.5d, 6d);
                var v1 = new dvec4(1.5d, -7.5d, 4.5d, -4.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec4(-5.5d, -2d, -4.5d, 0.0);
                var v1 = new dvec4(1.5d, -3.5d, -8d, 8d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec4(1.0, 6d, -3d, 4d);
                var v1 = new dvec4(-5.5d, -3.5d, 2d, 2.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec4(-1.5d, 2.5d, 5d, -2d);
                var v1 = new dvec4(-9d, -5.5d, 7d, 9.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec4(0.0, 6.5d, 5d, -7.5d);
                var v1 = new dvec4(2d, -9.5d, 9.5d, -3.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec4(6.5d, -5.5d, -9.5d, 3.5d);
                var v1 = new dvec4(-2d, 2.5d, -5d, -2d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec4(3.5d, 7.5d, -5.5d, 8d);
                var v1 = new dvec4(6.5d, 6d, 0.0, 9.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new dvec4(3d, 4d, 2d, -2d);
                var v1 = new dvec4(-3d, 4d, 0.5d, 6.5d);
                var v2 = new dvec4(3d, -7.5d, -1d, -1d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec4(-5d, -9d, 7.5d, -2.5d);
                var v1 = new dvec4(-9.5d, 4d, -8d, -1d);
                var v2 = new dvec4(7d, 9.5d, 4d, 9d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec4(-3d, -2.5d, -4d, -6d);
                var v1 = new dvec4(1.0, 1.0, 5.5d, -9d);
                var v2 = new dvec4(7.5d, -4d, -9d, 8d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec4(-2.5d, -7.5d, -1d, -7.5d);
                var v1 = new dvec4(5d, -5d, -6.5d, -4.5d);
                var v2 = new dvec4(-4d, -5.5d, 6d, 8.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec4(-5.5d, 6.5d, 4d, -9d);
                var v1 = new dvec4(7d, 1.5d, -2.5d, 4d);
                var v2 = new dvec4(9.5d, 3.5d, 8.5d, -4.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec4(0.5d, -4d, 5.5d, 2d);
                var v1 = new dvec4(-3.5d, 1.5d, -3d, 0.0);
                var v2 = new dvec4(0.0, -1.5d, 0.0, 8.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec4(4.5d, 5.5d, 4d, 3.5d);
                var v1 = new dvec4(-7d, -9.5d, 5.5d, -1.5d);
                var v2 = new dvec4(-8.5d, -6d, 2.5d, 4d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec4(6.5d, -7d, -2d, 6d);
                var v1 = new dvec4(-3.5d, -5d, 9d, 3.5d);
                var v2 = new dvec4(-6.5d, -4.5d, 2.5d, 2.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec4(-9d, -9.5d, 8.5d, -6.5d);
                var v1 = new dvec4(-2d, 5d, 8.5d, 5.5d);
                var v2 = new dvec4(6.5d, 5d, -5.5d, -2d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec4(-3.5d, 4.5d, -2.5d, -9.5d);
                var v1 = new dvec4(8.5d, -1d, 4d, -5d);
                var v2 = new dvec4(-8.5d, 0.5d, 5d, 9d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new dvec4(-2d, -8.5d, 1.0, -2.5d);
                var v1 = new dvec4(-4d, -2.5d, -5d, 7.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec4(-3.5d, 3d, 7d, -9.5d);
                var v1 = new dvec4(0.0, 6.5d, 2.5d, -7.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec4(-1.5d, -7.5d, 1.0, -7d);
                var v1 = new dvec4(-5d, -6d, 0.5d, 0.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec4(8.5d, 4.5d, -3.5d, -8d);
                var v1 = new dvec4(-2.5d, -4d, 1.0, 7d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec4(-0.5d, -4d, -0.5d, -9d);
                var v1 = new dvec4(5d, -2.5d, 2d, -0.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec4(-2.5d, -8.5d, -2d, 9.5d);
                var v1 = new dvec4(-7d, 1.0, -6d, 9d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec4(0.5d, -3.5d, -4d, 2d);
                var v1 = new dvec4(4.5d, 7.5d, -3d, 5.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec4(1.5d, -2d, -1.5d, -9d);
                var v1 = new dvec4(0.0, 6.5d, 9d, -3d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec4(2d, 9.5d, 0.5d, -2.5d);
                var v1 = new dvec4(7d, -4d, -7d, 1.0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec4(-9d, -2d, -0.5d, 4.5d);
                var v1 = new dvec4(4d, 0.5d, -3d, 6.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new dvec4(8d, 2d, -6d, 0.0);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec4(6d, -9.5d, 8.5d, -8d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec4(9d, 0.0, -9d, -4d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec4(-1d, 8.5d, -2d, 7.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec4(9d, -1d, 7.5d, -4.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec4(-9d, 0.5d, 5d, 5.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec4(6d, -4.5d, -9d, -9d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec4(7d, -4d, -6.5d, -7d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec4(-7d, -8d, -1.5d, 3.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec4(-5d, 2.5d, -4d, 9d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(946833268);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.Random(random, -3, 1);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1, 1.0);
            Assert.AreEqual(avg.y, -1, 1.0);
            Assert.AreEqual(avg.z, -1, 1.0);
            Assert.AreEqual(avg.w, -1, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.w, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1665401270);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomUniform(random, 3, 7);
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
        public void RandomUniform2()
        {
            var random = new Random(236485625);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.Random(random, -2, 2);
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
        public void RandomUniform3()
        {
            var random = new Random(955053627);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomUniform(random, 3, 4);
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
            var random = new Random(220044907);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.Random(random, -2, -1);
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
        public void RandomGaussian0()
        {
            var random = new Random(803825297);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomNormal(random, 1.0502472887981d, 2.7189641691367d);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.0502472887981, 1.0);
            Assert.AreEqual(avg.y, 1.0502472887981, 1.0);
            Assert.AreEqual(avg.z, 1.0502472887981, 1.0);
            Assert.AreEqual(avg.w, 1.0502472887981, 1.0);
            
            Assert.AreEqual(variance.x, 2.7189641691367, 3.0);
            Assert.AreEqual(variance.y, 2.7189641691367, 3.0);
            Assert.AreEqual(variance.z, 2.7189641691367, 3.0);
            Assert.AreEqual(variance.w, 2.7189641691367, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(968149683);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomGaussian(random, 1.65950470774411d, 8.5450055210595d);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.65950470774411, 1.0);
            Assert.AreEqual(avg.y, 1.65950470774411, 1.0);
            Assert.AreEqual(avg.z, 1.65950470774411, 1.0);
            Assert.AreEqual(avg.w, 1.65950470774411, 1.0);
            
            Assert.AreEqual(variance.x, 8.5450055210595, 3.0);
            Assert.AreEqual(variance.y, 8.5450055210595, 3.0);
            Assert.AreEqual(variance.z, 8.5450055210595, 3.0);
            Assert.AreEqual(variance.w, 8.5450055210595, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(378860534);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomNormal(random, 1.66665352492903d, 0.15697779606887d);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.66665352492903, 1.0);
            Assert.AreEqual(avg.y, 1.66665352492903, 1.0);
            Assert.AreEqual(avg.z, 1.66665352492903, 1.0);
            Assert.AreEqual(avg.w, 1.66665352492903, 1.0);
            
            Assert.AreEqual(variance.x, 0.15697779606887, 3.0);
            Assert.AreEqual(variance.y, 0.15697779606887, 3.0);
            Assert.AreEqual(variance.z, 0.15697779606887, 3.0);
            Assert.AreEqual(variance.w, 0.15697779606887, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(428522525);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomGaussian(random, -0.702141867346196d, 1.34130113354945d);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.702141867346196, 1.0);
            Assert.AreEqual(avg.y, -0.702141867346196, 1.0);
            Assert.AreEqual(avg.z, -0.702141867346196, 1.0);
            Assert.AreEqual(avg.w, -0.702141867346196, 1.0);
            
            Assert.AreEqual(variance.x, 1.34130113354945, 3.0);
            Assert.AreEqual(variance.y, 1.34130113354945, 3.0);
            Assert.AreEqual(variance.z, 1.34130113354945, 3.0);
            Assert.AreEqual(variance.w, 1.34130113354945, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1561752260);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomNormal(random, -0.76640407311097d, 2.40718037933446d);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.76640407311097, 1.0);
            Assert.AreEqual(avg.y, -0.76640407311097, 1.0);
            Assert.AreEqual(avg.z, -0.76640407311097, 1.0);
            Assert.AreEqual(avg.w, -0.76640407311097, 1.0);
            
            Assert.AreEqual(variance.x, 2.40718037933446, 3.0);
            Assert.AreEqual(variance.y, 2.40718037933446, 3.0);
            Assert.AreEqual(variance.z, 2.40718037933446, 3.0);
            Assert.AreEqual(variance.w, 2.40718037933446, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(276079068);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomNormal(random);
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
            var random = new Random(1397978887);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomNormal(random);
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
            var random = new Random(372395059);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomNormal(random);
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
            var random = new Random(1494294878);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomNormal(random);
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
            var random = new Random(83447086);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec4.RandomNormal(random);
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
