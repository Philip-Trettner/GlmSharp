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
    public class UintVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uvec4(1u);
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(1u, v.w);
            }
            {
                var v = new uvec4(0u, 2, 0u, 8);
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(2, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(8, v.w);
            }
            {
                var v = new uvec4(new uvec2(1u, 5));
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(5, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uvec4(new uvec3(0u, 0u, 1u));
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(0u, v.y);
                Assert.AreEqual(1u, v.z);
                Assert.AreEqual(0u, v.w);
            }
            {
                var v = new uvec4(new uvec4(2, 6, 2, 1u));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(6, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(1u, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec4(2, 4, 8, 2);
            Assert.AreEqual(2, v[0]);
            Assert.AreEqual(4, v[1]);
            Assert.AreEqual(8, v[2]);
            Assert.AreEqual(2, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[3] = 0u;
            Assert.AreEqual(0u, v[3]);
            v[2] = 1u;
            Assert.AreEqual(1u, v[2]);
            v[3] = 2;
            Assert.AreEqual(2, v[3]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[2] = 6;
            Assert.AreEqual(6, v[2]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[0] = 8;
            Assert.AreEqual(8, v[0]);
            v[3] = 9;
            Assert.AreEqual(9, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uvec4(8, 5, 6, 5);
            var vals = v.Values;
            Assert.AreEqual(8, vals[0]);
            Assert.AreEqual(5, vals[1]);
            Assert.AreEqual(6, vals[2]);
            Assert.AreEqual(5, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uvec4.Zero.x);
            Assert.AreEqual(0u, uvec4.Zero.y);
            Assert.AreEqual(0u, uvec4.Zero.z);
            Assert.AreEqual(0u, uvec4.Zero.w);
            
            Assert.AreEqual(1u, uvec4.Ones.x);
            Assert.AreEqual(1u, uvec4.Ones.y);
            Assert.AreEqual(1u, uvec4.Ones.z);
            Assert.AreEqual(1u, uvec4.Ones.w);
            
            Assert.AreEqual(1u, uvec4.UnitX.x);
            Assert.AreEqual(0u, uvec4.UnitX.y);
            Assert.AreEqual(0u, uvec4.UnitX.z);
            Assert.AreEqual(0u, uvec4.UnitX.w);
            
            Assert.AreEqual(0u, uvec4.UnitY.x);
            Assert.AreEqual(1u, uvec4.UnitY.y);
            Assert.AreEqual(0u, uvec4.UnitY.z);
            Assert.AreEqual(0u, uvec4.UnitY.w);
            
            Assert.AreEqual(0u, uvec4.UnitZ.x);
            Assert.AreEqual(0u, uvec4.UnitZ.y);
            Assert.AreEqual(1u, uvec4.UnitZ.z);
            Assert.AreEqual(0u, uvec4.UnitZ.w);
            
            Assert.AreEqual(0u, uvec4.UnitW.x);
            Assert.AreEqual(0u, uvec4.UnitW.y);
            Assert.AreEqual(0u, uvec4.UnitW.z);
            Assert.AreEqual(1u, uvec4.UnitW.w);
            
            Assert.AreEqual(uint.MaxValue, uvec4.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uvec4.MaxValue.y);
            Assert.AreEqual(uint.MaxValue, uvec4.MaxValue.z);
            Assert.AreEqual(uint.MaxValue, uvec4.MaxValue.w);
            
            Assert.AreEqual(uint.MinValue, uvec4.MinValue.x);
            Assert.AreEqual(uint.MinValue, uvec4.MinValue.y);
            Assert.AreEqual(uint.MinValue, uvec4.MinValue.z);
            Assert.AreEqual(uint.MinValue, uvec4.MinValue.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uvec4(0u, 2, 9, 5);
            var v2 = new uvec4(0u, 2, 9, 5);
            var v3 = new uvec4(5, 9, 2, 0u);
            Assert.That(v1 == new uvec4(v1));
            Assert.That(v2 == new uvec4(v2));
            Assert.That(v3 == new uvec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new uvec4(7, 7, 0u, 9);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = uvec4.Parse(s0);
            var v1 = uvec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = uvec4.TryParse(s0, out v0);
            var b1 = uvec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = uvec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = uvec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = uvec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { uvec4.Parse(null); });
            Assert.Throws<FormatException>(() => { uvec4.Parse(""); });
            Assert.Throws<FormatException>(() => { uvec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = uvec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = uvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = uvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new uvec4(8, 7, 0u, 6);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<uvec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new uvec4(6, 8, 0u, 8);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(9, 9, 3, 6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(7, 7, 1u, 1u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(9, 6, 7, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(9, 6, 4, 9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(1u, 8, 2, 7);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(8, 0u, 1u, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(0u, 5, 8, 4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(7, 0u, 2, 2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(5, 1u, 8, 0u);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new uvec4(1u, 9, 9, 6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(5, 0u, 9, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(5, 1u, 7, 7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(7, 6, 8, 2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(7, 8, 9, 0u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(0u, 9, 1u, 6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(8, 7, 2, 2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(6, 3, 0u, 4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(6, 7, 1u, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(3, 1u, 2, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new uvec4(5, 9, 5, 1u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(1u, 0u, 1u, 8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(8, 6, 6, 5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(9, 0u, 7, 3);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(7, 7, 0u, 6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(5, 4, 2, 4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(9, 7, 5, 7);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(7, 3, 6, 7);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(3, 6, 0u, 9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(9, 9, 5, 8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new uvec4(2, 3, 8, 6);
                var v1 = new uvec4(2, 0u, 3, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(0u, 5, 5, 5);
                var v1 = new uvec4(9, 6, 1u, 0u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(7, 4, 1u, 1u);
                var v1 = new uvec4(7, 4, 0u, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(6, 1u, 0u, 6);
                var v1 = new uvec4(7, 6, 2, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(1u, 9, 9, 9);
                var v1 = new uvec4(8, 0u, 8, 3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(9, 4, 4, 0u);
                var v1 = new uvec4(4, 2, 5, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(9, 4, 8, 2);
                var v1 = new uvec4(4, 6, 9, 7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(3, 1u, 0u, 1u);
                var v1 = new uvec4(9, 6, 7, 3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(2, 9, 3, 0u);
                var v1 = new uvec4(6, 2, 1u, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(5, 7, 1u, 3);
                var v1 = new uvec4(0u, 9, 2, 3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new uvec4(3, 2, 8, 8);
                var v1 = new uvec4(8, 4, 3, 6);
                var v2 = new uvec4(9, 7, 1u, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(8, 7, 9, 6);
                var v1 = new uvec4(9, 7, 9, 6);
                var v2 = new uvec4(0u, 5, 3, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(1u, 5, 2, 9);
                var v1 = new uvec4(3, 0u, 6, 0u);
                var v2 = new uvec4(5, 2, 9, 3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(6, 0u, 1u, 8);
                var v1 = new uvec4(7, 1u, 8, 4);
                var v2 = new uvec4(6, 4, 5, 7);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(8, 8, 9, 5);
                var v1 = new uvec4(3, 0u, 2, 7);
                var v2 = new uvec4(8, 4, 7, 3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(2, 3, 2, 8);
                var v1 = new uvec4(0u, 1u, 8, 6);
                var v2 = new uvec4(7, 6, 9, 8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(6, 1u, 8, 9);
                var v1 = new uvec4(7, 8, 8, 7);
                var v2 = new uvec4(9, 5, 1u, 5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(1u, 0u, 6, 4);
                var v1 = new uvec4(0u, 1u, 4, 2);
                var v2 = new uvec4(3, 7, 5, 3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(8, 9, 4, 4);
                var v1 = new uvec4(5, 9, 9, 1u);
                var v2 = new uvec4(8, 0u, 9, 2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(2, 2, 9, 9);
                var v1 = new uvec4(6, 9, 3, 7);
                var v2 = new uvec4(1u, 6, 7, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new uvec4(0u, 6, 5, 2);
                var v1 = new uvec4(0u, 8, 8, 0u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(6, 8, 8, 9);
                var v1 = new uvec4(7, 3, 6, 7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(4, 7, 7, 2);
                var v1 = new uvec4(0u, 8, 7, 3);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(6, 8, 9, 9);
                var v1 = new uvec4(3, 2, 9, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(9, 2, 0u, 4);
                var v1 = new uvec4(9, 5, 5, 8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(1u, 0u, 5, 6);
                var v1 = new uvec4(9, 4, 1u, 4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(3, 8, 1u, 1u);
                var v1 = new uvec4(2, 2, 4, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(9, 1u, 5, 2);
                var v1 = new uvec4(9, 9, 6, 4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(9, 6, 0u, 4);
                var v1 = new uvec4(3, 1u, 7, 9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(1u, 8, 1u, 9);
                var v1 = new uvec4(3, 1u, 4, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new uvec4(9, 9, 4, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(7, 6, 2, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(8, 9, 2, 0u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(5, 5, 3, 4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(0u, 5, 6, 4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(3, 5, 4, 2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(8, 4, 0u, 0u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(4, 2, 5, 7);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(3, 0u, 1u, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(0u, 9, 7, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(659101511);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.Random(random, 2, 5);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            Assert.AreEqual(avg.z, 3, 1.0);
            Assert.AreEqual(avg.w, 3, 1.0);
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.z, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.w, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(2088017156);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.RandomUniform(random, 4, 9);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 6, 1.0);
            Assert.AreEqual(avg.y, 6, 1.0);
            Assert.AreEqual(avg.z, 6, 1.0);
            Assert.AreEqual(avg.w, 6, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1369449154);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.Random(random, 1, 6);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            Assert.AreEqual(avg.z, 3, 1.0);
            Assert.AreEqual(avg.w, 3, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(650881152);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.RandomUniform(random, 4, 8);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5.5, 1.0);
            Assert.AreEqual(avg.y, 5.5, 1.0);
            Assert.AreEqual(avg.z, 5.5, 1.0);
            Assert.AreEqual(avg.w, 5.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1385889872);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.Random(random, 1, 5);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            Assert.AreEqual(avg.z, 2.5, 1.0);
            Assert.AreEqual(avg.w, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

    }
}
