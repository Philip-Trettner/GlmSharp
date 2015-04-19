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
    public class DoubleVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new dvec3(-9.5d);
                Assert.AreEqual(-9.5d, v.x);
                Assert.AreEqual(-9.5d, v.y);
                Assert.AreEqual(-9.5d, v.z);
            }
            {
                var v = new dvec3(-5.5d, -3.5d, -2d);
                Assert.AreEqual(-5.5d, v.x);
                Assert.AreEqual(-3.5d, v.y);
                Assert.AreEqual(-2d, v.z);
            }
            {
                var v = new dvec3(new dvec2(8d, -7.5d));
                Assert.AreEqual(8d, v.x);
                Assert.AreEqual(-7.5d, v.y);
                Assert.AreEqual(0.0, v.z);
            }
            {
                var v = new dvec3(new dvec3(-1.5d, -9d, 9.5d));
                Assert.AreEqual(-1.5d, v.x);
                Assert.AreEqual(-9d, v.y);
                Assert.AreEqual(9.5d, v.z);
            }
            {
                var v = new dvec3(new dvec4(5d, 4d, -9d, 0.5d));
                Assert.AreEqual(5d, v.x);
                Assert.AreEqual(4d, v.y);
                Assert.AreEqual(-9d, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new dvec3(0.0, 2d, 5.5d);
            Assert.AreEqual(0.0, v[0]);
            Assert.AreEqual(2d, v[1]);
            Assert.AreEqual(5.5d, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0.0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0.0; } );
            
            v[1] = 0.0;
            Assert.AreEqual(0.0, v[1]);
            v[0] = 1.0;
            Assert.AreEqual(1.0, v[0]);
            v[2] = 2d;
            Assert.AreEqual(2d, v[2]);
            v[1] = 3d;
            Assert.AreEqual(3d, v[1]);
            v[1] = 4d;
            Assert.AreEqual(4d, v[1]);
            v[2] = 5d;
            Assert.AreEqual(5d, v[2]);
            v[0] = 6d;
            Assert.AreEqual(6d, v[0]);
            v[0] = 7d;
            Assert.AreEqual(7d, v[0]);
            v[1] = 8d;
            Assert.AreEqual(8d, v[1]);
            v[2] = 9d;
            Assert.AreEqual(9d, v[2]);
            v[2] = -1d;
            Assert.AreEqual(-1d, v[2]);
            v[0] = -2d;
            Assert.AreEqual(-2d, v[0]);
            v[2] = -3d;
            Assert.AreEqual(-3d, v[2]);
            v[2] = -4d;
            Assert.AreEqual(-4d, v[2]);
            v[0] = -5d;
            Assert.AreEqual(-5d, v[0]);
            v[0] = -6d;
            Assert.AreEqual(-6d, v[0]);
            v[0] = -7d;
            Assert.AreEqual(-7d, v[0]);
            v[2] = -8d;
            Assert.AreEqual(-8d, v[2]);
            v[0] = -9d;
            Assert.AreEqual(-9d, v[0]);
            v[2] = -9.5d;
            Assert.AreEqual(-9.5d, v[2]);
            v[1] = -8.5d;
            Assert.AreEqual(-8.5d, v[1]);
            v[1] = -7.5d;
            Assert.AreEqual(-7.5d, v[1]);
            v[1] = -6.5d;
            Assert.AreEqual(-6.5d, v[1]);
            v[2] = -5.5d;
            Assert.AreEqual(-5.5d, v[2]);
            v[1] = -4.5d;
            Assert.AreEqual(-4.5d, v[1]);
            v[1] = -3.5d;
            Assert.AreEqual(-3.5d, v[1]);
            v[1] = -2.5d;
            Assert.AreEqual(-2.5d, v[1]);
            v[0] = -1.5d;
            Assert.AreEqual(-1.5d, v[0]);
            v[2] = -0.5d;
            Assert.AreEqual(-0.5d, v[2]);
            v[0] = 0.5d;
            Assert.AreEqual(0.5d, v[0]);
            v[2] = 1.5d;
            Assert.AreEqual(1.5d, v[2]);
            v[0] = 2.5d;
            Assert.AreEqual(2.5d, v[0]);
            v[1] = 3.5d;
            Assert.AreEqual(3.5d, v[1]);
            v[0] = 4.5d;
            Assert.AreEqual(4.5d, v[0]);
            v[2] = 5.5d;
            Assert.AreEqual(5.5d, v[2]);
            v[1] = 6.5d;
            Assert.AreEqual(6.5d, v[1]);
            v[0] = 7.5d;
            Assert.AreEqual(7.5d, v[0]);
            v[2] = 8.5d;
            Assert.AreEqual(8.5d, v[2]);
            v[0] = 9.5d;
            Assert.AreEqual(9.5d, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new dvec3(4.5d, 1.0, 9d);
            var vals = v.Values;
            Assert.AreEqual(4.5d, vals[0]);
            Assert.AreEqual(1.0, vals[1]);
            Assert.AreEqual(9d, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0.0, dvec3.Zero.x);
            Assert.AreEqual(0.0, dvec3.Zero.y);
            Assert.AreEqual(0.0, dvec3.Zero.z);
            
            Assert.AreEqual(1.0, dvec3.Ones.x);
            Assert.AreEqual(1.0, dvec3.Ones.y);
            Assert.AreEqual(1.0, dvec3.Ones.z);
            
            Assert.AreEqual(1.0, dvec3.UnitX.x);
            Assert.AreEqual(0.0, dvec3.UnitX.y);
            Assert.AreEqual(0.0, dvec3.UnitX.z);
            
            Assert.AreEqual(0.0, dvec3.UnitY.x);
            Assert.AreEqual(1.0, dvec3.UnitY.y);
            Assert.AreEqual(0.0, dvec3.UnitY.z);
            
            Assert.AreEqual(0.0, dvec3.UnitZ.x);
            Assert.AreEqual(0.0, dvec3.UnitZ.y);
            Assert.AreEqual(1.0, dvec3.UnitZ.z);
            
            Assert.AreEqual(double.MaxValue, dvec3.MaxValue.x);
            Assert.AreEqual(double.MaxValue, dvec3.MaxValue.y);
            Assert.AreEqual(double.MaxValue, dvec3.MaxValue.z);
            
            Assert.AreEqual(double.MinValue, dvec3.MinValue.x);
            Assert.AreEqual(double.MinValue, dvec3.MinValue.y);
            Assert.AreEqual(double.MinValue, dvec3.MinValue.z);
            
            Assert.AreEqual(double.Epsilon, dvec3.Epsilon.x);
            Assert.AreEqual(double.Epsilon, dvec3.Epsilon.y);
            Assert.AreEqual(double.Epsilon, dvec3.Epsilon.z);
            
            Assert.AreEqual(double.NaN, dvec3.NaN.x);
            Assert.AreEqual(double.NaN, dvec3.NaN.y);
            Assert.AreEqual(double.NaN, dvec3.NaN.z);
            
            Assert.AreEqual(double.NegativeInfinity, dvec3.NegativeInfinity.x);
            Assert.AreEqual(double.NegativeInfinity, dvec3.NegativeInfinity.y);
            Assert.AreEqual(double.NegativeInfinity, dvec3.NegativeInfinity.z);
            
            Assert.AreEqual(double.PositiveInfinity, dvec3.PositiveInfinity.x);
            Assert.AreEqual(double.PositiveInfinity, dvec3.PositiveInfinity.y);
            Assert.AreEqual(double.PositiveInfinity, dvec3.PositiveInfinity.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new dvec3(6d, 0.0, -2.5d);
            var v2 = new dvec3(6d, 0.0, -2.5d);
            var v3 = new dvec3(-2.5d, 0.0, 6d);
            Assert.That(v1 == new dvec3(v1));
            Assert.That(v2 == new dvec3(v2));
            Assert.That(v3 == new dvec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new dvec3(8.5d, 6.5d, 1.5d);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = dvec3.Parse(s0);
            var v1 = dvec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = dvec3.TryParse(s0, out v0);
            var b1 = dvec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = dvec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = dvec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = dvec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { dvec3.Parse(null); });
            Assert.Throws<FormatException>(() => { dvec3.Parse(""); });
            Assert.Throws<FormatException>(() => { dvec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = dvec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = dvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = dvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new dvec3(5.5d, 5.5d, 1.5d);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<dvec3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new dvec3(-7.5d, -7d, -6.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec3(-7d, -1.5d, -4d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec3(9.5d, -8.5d, -4d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec3(2.5d, 4d, 3d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec3(7.5d, -3d, 1.0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec3(-3d, 5.5d, -6d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec3(6.5d, -6.5d, -4d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec3(-7d, -0.5d, 3.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec3(8.5d, 7.5d, -5.5d);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new dvec3(-9.5d, -2.5d, -3d);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new dvec3(-7.5d, -0.5d, 5.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec3(-3.5d, -8d, -2.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec3(-2d, 7d, -9d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec3(2d, -2.5d, -7d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec3(-1d, -2d, -0.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec3(9d, -2.5d, -4d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec3(-8d, -8d, 8.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec3(-0.5d, 7d, -6.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec3(-2d, -5.5d, -4d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new dvec3(-5.5d, -4d, -1.5d);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new dvec3(-4d, -8.5d, -6.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec3(-4d, -9d, 5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec3(-3.5d, 7d, 1.0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec3(-1.5d, -3d, 5.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec3(-5.5d, 1.0, -6.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec3(7d, 7.5d, 2.5d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec3(0.0, -7.5d, -7d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec3(7.5d, 9d, 1.0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec3(-4d, -1.5d, -9d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new dvec3(-7d, -7d, 2d);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new dvec3(4d, -8.5d, 2.5d);
                var v1 = new dvec3(5d, 6.5d, -2d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec3(4.5d, 1.0, -5.5d);
                var v1 = new dvec3(-8d, 9.5d, 4d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec3(5d, -1d, 3d);
                var v1 = new dvec3(2.5d, -4d, 8.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec3(-8d, -1.5d, -9d);
                var v1 = new dvec3(0.0, 5d, 3.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec3(1.0, -2.5d, 8.5d);
                var v1 = new dvec3(8d, 3d, -1d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec3(-7.5d, -4.5d, 4.5d);
                var v1 = new dvec3(-1d, -5d, -1.5d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec3(5.5d, -8d, 3d);
                var v1 = new dvec3(-6.5d, 4.5d, -7d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec3(7d, 8.5d, 3.5d);
                var v1 = new dvec3(-0.5d, 9.5d, -2d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec3(-6d, -1d, -0.5d);
                var v1 = new dvec3(4d, -4.5d, 4d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new dvec3(9.5d, 4d, -5d);
                var v1 = new dvec3(9.5d, 3d, 8d);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new dvec3(-4d, -6d, 0.0);
                var v1 = new dvec3(-9d, 5d, -2d);
                var v2 = new dvec3(4.5d, 7.5d, 4d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec3(-9.5d, 9d, -0.5d);
                var v1 = new dvec3(8d, -1d, -6.5d);
                var v2 = new dvec3(2.5d, -9.5d, -5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec3(-9.5d, 5.5d, 9.5d);
                var v1 = new dvec3(2d, 7.5d, 2.5d);
                var v2 = new dvec3(8.5d, 4.5d, -8d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec3(7.5d, -4.5d, 0.0);
                var v1 = new dvec3(-8.5d, -0.5d, 8.5d);
                var v2 = new dvec3(-5d, -7.5d, -8d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec3(8.5d, -5.5d, 9.5d);
                var v1 = new dvec3(6d, 3.5d, 7d);
                var v2 = new dvec3(-3.5d, -4d, -0.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec3(2d, 7d, 0.5d);
                var v1 = new dvec3(5.5d, 2d, -5d);
                var v2 = new dvec3(-3.5d, -1d, -8.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec3(-3.5d, -1d, -8d);
                var v1 = new dvec3(8d, -9.5d, -2d);
                var v2 = new dvec3(4.5d, 6.5d, -2d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec3(3d, 9.5d, -8.5d);
                var v1 = new dvec3(1.5d, 3.5d, -1.5d);
                var v2 = new dvec3(4d, 3.5d, 5.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec3(-5d, -3d, 1.0);
                var v1 = new dvec3(2.5d, -7d, -5.5d);
                var v2 = new dvec3(3d, 5.5d, -3.5d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new dvec3(-2.5d, 1.0, -6.5d);
                var v1 = new dvec3(-3.5d, 5.5d, -8d);
                var v2 = new dvec3(-7d, -0.5d, -2d);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new dvec3(-2d, -0.5d, 4d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec3(-7.5d, 4.5d, -7.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec3(-8d, 7d, 7.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec3(0.5d, -6d, 8d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec3(-9d, -6.5d, 7d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec3(0.0, -5.5d, -6d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec3(4.5d, -5d, 0.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec3(0.5d, -1.5d, -8.5d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec3(-1d, 3.5d, 9d);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new dvec3(-5.5d, 8d, -5d);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new dvec3(6d, 4d, -0.5d);
                var v1 = new dvec3(-6d, -7d, -9d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec3(-6.5d, 7.5d, 8d);
                var v1 = new dvec3(6d, -0.5d, -1d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec3(1.0, -8d, -0.5d);
                var v1 = new dvec3(-4.5d, -5d, 0.0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec3(-8d, 5d, -0.5d);
                var v1 = new dvec3(-1d, 5.5d, 5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec3(2.5d, -1.5d, 8d);
                var v1 = new dvec3(-4.5d, -2.5d, -4d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec3(-0.5d, 7d, 4.5d);
                var v1 = new dvec3(-6d, -2.5d, 3.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec3(3d, 7d, 5.5d);
                var v1 = new dvec3(-5d, 6d, 9d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec3(-4d, -8d, 6d);
                var v1 = new dvec3(1.5d, 5d, -3d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec3(-8d, 1.0, -8d);
                var v1 = new dvec3(-5d, 8.5d, 0.0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new dvec3(9.5d, 5.5d, 9d);
                var v1 = new dvec3(-6.5d, -6.5d, -0.5d);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new dvec3(5d, -2d, 4.5d);
                var v1 = new dvec3(-3.5d, 4d, 8d);
                var v2 = new dvec3(3.5d, -0.5d, 2d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec3(5d, 0.5d, 3d);
                var v1 = new dvec3(-8d, 8.5d, 1.0);
                var v2 = new dvec3(8d, 3d, -5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec3(5d, 0.5d, 3.5d);
                var v1 = new dvec3(7.5d, -7.5d, -1.5d);
                var v2 = new dvec3(5d, -3.5d, -3.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec3(7.5d, 5d, 8d);
                var v1 = new dvec3(0.0, 7.5d, -2.5d);
                var v2 = new dvec3(9d, -7d, -7d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec3(-5d, 9.5d, 3.5d);
                var v1 = new dvec3(-6d, 0.0, -2d);
                var v2 = new dvec3(-8.5d, -2d, 2.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec3(-9d, 4d, -8d);
                var v1 = new dvec3(4.5d, -2.5d, 2.5d);
                var v2 = new dvec3(-5d, -1.5d, -4d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec3(5.5d, 7d, 0.5d);
                var v1 = new dvec3(6d, -8.5d, -8d);
                var v2 = new dvec3(-6.5d, 5.5d, -5.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec3(3.5d, 4d, 3.5d);
                var v1 = new dvec3(-6d, 8d, -8.5d);
                var v2 = new dvec3(-4.5d, 4.5d, 3d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec3(-7.5d, -0.5d, -0.5d);
                var v1 = new dvec3(-7.5d, -6d, 9d);
                var v2 = new dvec3(6.5d, -3.5d, -7.5d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new dvec3(8d, 3d, -8d);
                var v1 = new dvec3(-7d, -4.5d, 8d);
                var v2 = new dvec3(-4d, -4d, 8d);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new dvec3(0.0, -2.5d, -6d);
                var v1 = new dvec3(-5.5d, 7d, 7.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec3(0.5d, -8.5d, 6.5d);
                var v1 = new dvec3(0.0, 6.5d, 2.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec3(6d, 5d, -8d);
                var v1 = new dvec3(-1d, -9d, -0.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec3(8.5d, -2d, -6.5d);
                var v1 = new dvec3(5d, -7.5d, 6.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec3(-7d, 3d, 0.0);
                var v1 = new dvec3(3d, -7.5d, 3d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec3(6.5d, 6.5d, -8.5d);
                var v1 = new dvec3(9.5d, 4.5d, -6d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec3(-5.5d, 6d, 3.5d);
                var v1 = new dvec3(-9d, 3d, -1.5d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec3(6.5d, 3d, 0.0);
                var v1 = new dvec3(-3d, -3d, 0.0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec3(7.5d, 8d, 1.0);
                var v1 = new dvec3(-6.5d, -2d, 9d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new dvec3(9d, 5.5d, 4d);
                var v1 = new dvec3(-9d, 6d, 3d);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new dvec3(-1d, 9d, 7d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec3(-5d, 8.5d, -5.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec3(2d, -1d, 9d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec3(-4.5d, 9.5d, 6d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec3(-5d, -7d, -7d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec3(-9d, 3.5d, -8.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec3(-4.5d, 4d, 5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec3(-1.5d, -6.5d, -5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec3(9.5d, -5.5d, 1.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new dvec3(0.0, -2d, -7.5d);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new dvec3(-4.5d, 4d, 4.5d);
                var v1 = new dvec3(1.0, 2d, -6.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new dvec3(-1.5d, 4.5d, -2d);
                var v1 = new dvec3(-3.5d, 0.0, 1.0);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new dvec3(-3.5d, 3d, 3.5d);
                var v1 = new dvec3(-4d, -6.5d, -9d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new dvec3(-7d, 5.5d, 3.5d);
                var v1 = new dvec3(-9d, 1.5d, 8.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new dvec3(-1d, 0.0, 6d);
                var v1 = new dvec3(4.5d, -2d, 5.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new dvec3(-8d, -6d, -4d);
                var v1 = new dvec3(2d, 9d, 7.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new dvec3(-3.5d, 9d, 2.5d);
                var v1 = new dvec3(-2d, 7.5d, 4d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new dvec3(-1.5d, -5d, -7.5d);
                var v1 = new dvec3(2.5d, -8d, -0.5d);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new dvec3(1.0, 3d, 2d);
                var v1 = new dvec3(-1.5d, 6d, 0.0);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new dvec3(1.5d, 5d, -4d);
                var v1 = new dvec3(5.5d, 0.5d, 1.0);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(839968601);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.Random(random, -1, 3);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1, 1.0);
            Assert.AreEqual(avg.y, 1, 1.0);
            Assert.AreEqual(avg.z, 1, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1558536603);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomUniform(random, 1, 5);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            Assert.AreEqual(avg.z, 3, 1.0);
            
            Assert.AreEqual(variance.x, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.y, 1.33333333333333, 3.0);
            Assert.AreEqual(variance.z, 1.33333333333333, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(129620958);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.Random(random, -4, -3);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3.5, 1.0);
            Assert.AreEqual(avg.y, -3.5, 1.0);
            Assert.AreEqual(avg.z, -3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(848188960);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomUniform(random, 1, 2);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            Assert.AreEqual(avg.z, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.y, 0.0833333333333333, 3.0);
            Assert.AreEqual(variance.z, 0.0833333333333333, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(113180240);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.Random(random, -3, -1);
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
            var random = new Random(696960630);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomNormal(random, 0.323738905751956d, 4.727100317705d);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.323738905751956, 1.0);
            Assert.AreEqual(avg.y, 0.323738905751956, 1.0);
            Assert.AreEqual(avg.z, 0.323738905751956, 1.0);
            
            Assert.AreEqual(variance.x, 4.727100317705, 3.0);
            Assert.AreEqual(variance.y, 4.727100317705, 3.0);
            Assert.AreEqual(variance.z, 4.727100317705, 3.0);
        }

        [Test]
        public void RandomGaussian1()
        {
            var random = new Random(861285016);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomGaussian(random, 0.932996324697974d, 0.553141669627811d);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.932996324697974, 1.0);
            Assert.AreEqual(avg.y, 0.932996324697974, 1.0);
            Assert.AreEqual(avg.z, 0.932996324697974, 1.0);
            
            Assert.AreEqual(variance.x, 0.553141669627811, 3.0);
            Assert.AreEqual(variance.y, 0.553141669627811, 3.0);
            Assert.AreEqual(variance.z, 0.553141669627811, 3.0);
        }

        [Test]
        public void RandomGaussian2()
        {
            var random = new Random(271995867);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomNormal(random, 0.94014514188289d, 2.16511394463718d);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.94014514188289, 1.0);
            Assert.AreEqual(avg.y, 0.94014514188289, 1.0);
            Assert.AreEqual(avg.z, 0.94014514188289, 1.0);
            
            Assert.AreEqual(variance.x, 2.16511394463718, 3.0);
            Assert.AreEqual(variance.y, 2.16511394463718, 3.0);
            Assert.AreEqual(variance.z, 2.16511394463718, 3.0);
        }

        [Test]
        public void RandomGaussian3()
        {
            var random = new Random(535387192);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomGaussian(random, -1.42865025039234d, 3.34943728211775d);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -1.42865025039234, 1.0);
            Assert.AreEqual(avg.y, -1.42865025039234, 1.0);
            Assert.AreEqual(avg.z, -1.42865025039234, 1.0);
            
            Assert.AreEqual(variance.x, 3.34943728211775, 3.0);
            Assert.AreEqual(variance.y, 3.34943728211775, 3.0);
            Assert.AreEqual(variance.z, 3.34943728211775, 3.0);
        }

        [Test]
        public void RandomGaussian4()
        {
            var random = new Random(1668616927);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomNormal(random, -0.0398956900648286d, 0.399044230766149d);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.0398956900648286, 1.0);
            Assert.AreEqual(avg.y, -0.0398956900648286, 1.0);
            Assert.AreEqual(avg.z, -0.0398956900648286, 1.0);
            
            Assert.AreEqual(variance.x, 0.399044230766149, 3.0);
            Assert.AreEqual(variance.y, 0.399044230766149, 3.0);
            Assert.AreEqual(variance.z, 0.399044230766149, 3.0);
        }

        [Test]
        public void RandomNormal0()
        {
            var random = new Random(169214401);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomNormal(random);
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
            var random = new Random(1291114220);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomNormal(random);
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
            var random = new Random(265530392);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomNormal(random);
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
            var random = new Random(1387430211);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomNormal(random);
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
            var random = new Random(2124066066);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = dvec3.RandomNormal(random);
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
