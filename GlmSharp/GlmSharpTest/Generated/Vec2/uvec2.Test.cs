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
    public class UintVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uvec2(1u);
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(1u, v.y);
            }
            {
                var v = new uvec2(5u, 2u);
                Assert.AreEqual(5u, v.x);
                Assert.AreEqual(2u, v.y);
            }
            {
                var v = new uvec2(new uvec2(3u, 3u));
                Assert.AreEqual(3u, v.x);
                Assert.AreEqual(3u, v.y);
            }
            {
                var v = new uvec2(new uvec3(9u, 6u, 6u));
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(6u, v.y);
            }
            {
                var v = new uvec2(new uvec4(2u, 3u, 8u, 7u));
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(3u, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec2(2u, 9u);
            Assert.AreEqual(2u, v[0]);
            Assert.AreEqual(9u, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[1] = 0u;
            Assert.AreEqual(0u, v[1]);
            v[1] = 1u;
            Assert.AreEqual(1u, v[1]);
            v[0] = 2u;
            Assert.AreEqual(2u, v[0]);
            v[1] = 3u;
            Assert.AreEqual(3u, v[1]);
            v[0] = 4u;
            Assert.AreEqual(4u, v[0]);
            v[1] = 5u;
            Assert.AreEqual(5u, v[1]);
            v[1] = 6u;
            Assert.AreEqual(6u, v[1]);
            v[0] = 7u;
            Assert.AreEqual(7u, v[0]);
            v[0] = 8u;
            Assert.AreEqual(8u, v[0]);
            v[0] = 9u;
            Assert.AreEqual(9u, v[0]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uvec2(8u, 0u);
            var vals = v.Values;
            Assert.AreEqual(8u, vals[0]);
            Assert.AreEqual(0u, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uvec2.Zero.x);
            Assert.AreEqual(0u, uvec2.Zero.y);
            
            Assert.AreEqual(1u, uvec2.Ones.x);
            Assert.AreEqual(1u, uvec2.Ones.y);
            
            Assert.AreEqual(1u, uvec2.UnitX.x);
            Assert.AreEqual(0u, uvec2.UnitX.y);
            
            Assert.AreEqual(0u, uvec2.UnitY.x);
            Assert.AreEqual(1u, uvec2.UnitY.y);
            
            Assert.AreEqual(uint.MaxValue, uvec2.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uvec2.MaxValue.y);
            
            Assert.AreEqual(uint.MinValue, uvec2.MinValue.x);
            Assert.AreEqual(uint.MinValue, uvec2.MinValue.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uvec2(0u, 7u);
            var v2 = new uvec2(0u, 7u);
            var v3 = new uvec2(7u, 0u);
            Assert.That(v1 == new uvec2(v1));
            Assert.That(v2 == new uvec2(v2));
            Assert.That(v3 == new uvec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new uvec2(7u, 0u);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = uvec2.Parse(s0);
            var v1 = uvec2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = uvec2.TryParse(s0, out v0);
            var b1 = uvec2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = uvec2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = uvec2.TryParse("", out v0);
            Assert.False(b0);
            b0 = uvec2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { uvec2.Parse(null); });
            Assert.Throws<FormatException>(() => { uvec2.Parse(""); });
            Assert.Throws<FormatException>(() => { uvec2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = uvec2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = uvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = uvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new uvec2(8u, 2u);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<uvec2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new uvec2(6u, 3u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec2(0u, 5u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec2(4u, 0u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec2(1u, 1u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec2(5u, 5u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec2(5u, 1u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec2(5u, 8u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec2(0u, 3u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec2(3u, 8u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec2(1u, 7u);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new uvec2(1u, 3u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec2(9u, 0u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec2(0u, 8u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec2(1u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec2(7u, 3u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec2(3u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec2(1u, 4u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec2(4u, 4u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec2(3u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec2(2u, 2u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new uvec2(5u, 4u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec2(5u, 4u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec2(6u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec2(3u, 4u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec2(0u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec2(2u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec2(4u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec2(4u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec2(4u, 5u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec2(2u, 9u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new uvec2(3u, 7u);
                var v1 = new uvec2(3u, 9u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec2(9u, 4u);
                var v1 = new uvec2(4u, 1u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec2(4u, 2u);
                var v1 = new uvec2(0u, 5u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec2(1u, 8u);
                var v1 = new uvec2(6u, 1u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec2(1u, 5u);
                var v1 = new uvec2(6u, 6u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec2(1u, 3u);
                var v1 = new uvec2(2u, 7u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec2(2u, 5u);
                var v1 = new uvec2(7u, 1u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec2(9u, 6u);
                var v1 = new uvec2(8u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec2(3u, 4u);
                var v1 = new uvec2(5u, 3u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec2(7u, 5u);
                var v1 = new uvec2(7u, 6u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new uvec2(1u, 5u);
                var v1 = new uvec2(0u, 3u);
                var v2 = new uvec2(9u, 6u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec2(1u, 6u);
                var v1 = new uvec2(0u, 3u);
                var v2 = new uvec2(3u, 0u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec2(3u, 4u);
                var v1 = new uvec2(7u, 3u);
                var v2 = new uvec2(0u, 6u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec2(2u, 5u);
                var v1 = new uvec2(0u, 3u);
                var v2 = new uvec2(4u, 7u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec2(1u, 8u);
                var v1 = new uvec2(7u, 8u);
                var v2 = new uvec2(0u, 8u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec2(4u, 5u);
                var v1 = new uvec2(9u, 6u);
                var v2 = new uvec2(8u, 9u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec2(6u, 1u);
                var v1 = new uvec2(0u, 5u);
                var v2 = new uvec2(4u, 2u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec2(3u, 7u);
                var v1 = new uvec2(7u, 7u);
                var v2 = new uvec2(4u, 8u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec2(4u, 7u);
                var v1 = new uvec2(4u, 9u);
                var v2 = new uvec2(8u, 8u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec2(0u, 7u);
                var v1 = new uvec2(0u, 3u);
                var v2 = new uvec2(2u, 0u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new uvec2(3u, 2u);
                var v1 = new uvec2(7u, 9u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec2(2u, 7u);
                var v1 = new uvec2(5u, 8u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec2(6u, 9u);
                var v1 = new uvec2(1u, 5u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec2(2u, 3u);
                var v1 = new uvec2(9u, 6u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec2(4u, 7u);
                var v1 = new uvec2(9u, 2u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec2(0u, 4u);
                var v1 = new uvec2(8u, 9u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec2(5u, 6u);
                var v1 = new uvec2(3u, 8u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec2(9u, 8u);
                var v1 = new uvec2(2u, 4u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec2(1u, 0u);
                var v1 = new uvec2(9u, 3u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec2(6u, 6u);
                var v1 = new uvec2(1u, 9u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new uvec2(9u, 5u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec2(4u, 6u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec2(2u, 8u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec2(0u, 3u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec2(6u, 7u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec2(6u, 0u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec2(0u, 7u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec2(7u, 1u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec2(4u, 7u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec2(4u, 1u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(642522786);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.Random(random, 0, 3);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1, 1.0);
            Assert.AreEqual(avg.y, 1, 1.0);
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(2071438431);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.RandomUniform(random, 1, 6);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1352870429);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.Random(random, 4, 9);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 6, 1.0);
            Assert.AreEqual(avg.y, 6, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(634302427);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.RandomUniform(random, 1, 5);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1369311147);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.Random(random, 4, 8);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5.5, 1.0);
            Assert.AreEqual(avg.y, 5.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1023436405);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.RandomPoisson(random, 2.10027294028563);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.10027294028563, 1.0);
            Assert.AreEqual(avg.y, 2.10027294028563, 1.0);
            
            Assert.AreEqual(variance.x, 2.10027294028563, 3.0);
            Assert.AreEqual(variance.y, 2.10027294028563, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(304868403);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.RandomPoisson(random, 0.707460162792103);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.707460162792103, 1.0);
            Assert.AreEqual(avg.y, 0.707460162792103, 1.0);
            
            Assert.AreEqual(variance.x, 0.707460162792103, 3.0);
            Assert.AreEqual(variance.y, 0.707460162792103, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(313088762);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.RandomPoisson(random, 2.15502730927199);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.15502730927199, 1.0);
            Assert.AreEqual(avg.y, 2.15502730927199, 1.0);
            
            Assert.AreEqual(variance.x, 2.15502730927199, 3.0);
            Assert.AreEqual(variance.y, 2.15502730927199, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(1742004407);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.RandomPoisson(random, 0.81232586983234);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.81232586983234, 1.0);
            Assert.AreEqual(avg.y, 0.81232586983234, 1.0);
            
            Assert.AreEqual(variance.x, 0.81232586983234, 3.0);
            Assert.AreEqual(variance.y, 0.81232586983234, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(1750224766);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec2.RandomPoisson(random, 2.25989301631222);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.25989301631222, 1.0);
            Assert.AreEqual(avg.y, 2.25989301631222, 1.0);
            
            Assert.AreEqual(variance.x, 2.25989301631222, 3.0);
            Assert.AreEqual(variance.y, 2.25989301631222, 3.0);
        }

    }
}
