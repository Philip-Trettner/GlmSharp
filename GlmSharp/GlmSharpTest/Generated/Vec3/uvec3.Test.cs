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
    public class UintVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new uvec3(9u);
                Assert.AreEqual(9u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(9u, v.z);
            }
            {
                var v = new uvec3(6u, 5u, 2u);
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var v = new uvec3(new uvec2(8u, 9u));
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(9u, v.y);
                Assert.AreEqual(0u, v.z);
            }
            {
                var v = new uvec3(new uvec3(6u, 3u, 2u));
                Assert.AreEqual(6u, v.x);
                Assert.AreEqual(3u, v.y);
                Assert.AreEqual(2u, v.z);
            }
            {
                var v = new uvec3(new uvec4(8u, 5u, 6u, 4u));
                Assert.AreEqual(8u, v.x);
                Assert.AreEqual(5u, v.y);
                Assert.AreEqual(6u, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec3(9u, 1u, 1u);
            Assert.AreEqual(9u, v[0]);
            Assert.AreEqual(1u, v[1]);
            Assert.AreEqual(1u, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0u; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0u; } );
            
            v[1] = 0u;
            Assert.AreEqual(0u, v[1]);
            v[0] = 1u;
            Assert.AreEqual(1u, v[0]);
            v[1] = 2u;
            Assert.AreEqual(2u, v[1]);
            v[2] = 3u;
            Assert.AreEqual(3u, v[2]);
            v[0] = 4u;
            Assert.AreEqual(4u, v[0]);
            v[2] = 5u;
            Assert.AreEqual(5u, v[2]);
            v[0] = 6u;
            Assert.AreEqual(6u, v[0]);
            v[2] = 7u;
            Assert.AreEqual(7u, v[2]);
            v[2] = 8u;
            Assert.AreEqual(8u, v[2]);
            v[1] = 9u;
            Assert.AreEqual(9u, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uvec3(5u, 2u, 9u);
            var vals = v.Values;
            Assert.AreEqual(5u, vals[0]);
            Assert.AreEqual(2u, vals[1]);
            Assert.AreEqual(9u, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0u, uvec3.Zero.x);
            Assert.AreEqual(0u, uvec3.Zero.y);
            Assert.AreEqual(0u, uvec3.Zero.z);
            
            Assert.AreEqual(1u, uvec3.Ones.x);
            Assert.AreEqual(1u, uvec3.Ones.y);
            Assert.AreEqual(1u, uvec3.Ones.z);
            
            Assert.AreEqual(1u, uvec3.UnitX.x);
            Assert.AreEqual(0u, uvec3.UnitX.y);
            Assert.AreEqual(0u, uvec3.UnitX.z);
            
            Assert.AreEqual(0u, uvec3.UnitY.x);
            Assert.AreEqual(1u, uvec3.UnitY.y);
            Assert.AreEqual(0u, uvec3.UnitY.z);
            
            Assert.AreEqual(0u, uvec3.UnitZ.x);
            Assert.AreEqual(0u, uvec3.UnitZ.y);
            Assert.AreEqual(1u, uvec3.UnitZ.z);
            
            Assert.AreEqual(uint.MaxValue, uvec3.MaxValue.x);
            Assert.AreEqual(uint.MaxValue, uvec3.MaxValue.y);
            Assert.AreEqual(uint.MaxValue, uvec3.MaxValue.z);
            
            Assert.AreEqual(uint.MinValue, uvec3.MinValue.x);
            Assert.AreEqual(uint.MinValue, uvec3.MinValue.y);
            Assert.AreEqual(uint.MinValue, uvec3.MinValue.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new uvec3(3u, 5u, 6u);
            var v2 = new uvec3(3u, 5u, 6u);
            var v3 = new uvec3(6u, 5u, 3u);
            Assert.That(v1 == new uvec3(v1));
            Assert.That(v2 == new uvec3(v2));
            Assert.That(v3 == new uvec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new uvec3(4u, 3u, 3u);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = uvec3.Parse(s0);
            var v1 = uvec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = uvec3.TryParse(s0, out v0);
            var b1 = uvec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = uvec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = uvec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = uvec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { uvec3.Parse(null); });
            Assert.Throws<FormatException>(() => { uvec3.Parse(""); });
            Assert.Throws<FormatException>(() => { uvec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = uvec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = uvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = uvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new uvec3(5u, 4u, 3u);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<uvec3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new uvec3(9u, 1u, 7u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec3(6u, 9u, 0u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec3(2u, 4u, 5u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec3(9u, 8u, 2u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec3(7u, 1u, 8u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec3(0u, 3u, 0u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec3(4u, 4u, 2u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec3(6u, 3u, 5u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec3(1u, 4u, 4u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec3(6u, 0u, 1u);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new uvec3(8u, 5u, 2u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec3(9u, 5u, 8u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec3(0u, 5u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec3(9u, 0u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec3(9u, 1u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec3(7u, 4u, 4u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec3(9u, 5u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec3(1u, 9u, 8u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec3(6u, 4u, 0u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec3(2u, 6u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new uvec3(2u, 5u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec3(3u, 1u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec3(2u, 0u, 0u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec3(4u, 9u, 5u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec3(1u, 4u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec3(9u, 4u, 3u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec3(0u, 1u, 4u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec3(5u, 1u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec3(6u, 4u, 3u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec3(6u, 7u, 7u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new uvec3(2u, 5u, 4u);
                var v1 = new uvec3(3u, 0u, 3u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec3(0u, 8u, 8u);
                var v1 = new uvec3(9u, 6u, 4u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec3(0u, 0u, 1u);
                var v1 = new uvec3(0u, 7u, 4u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec3(1u, 3u, 6u);
                var v1 = new uvec3(9u, 6u, 3u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec3(2u, 6u, 5u);
                var v1 = new uvec3(5u, 2u, 2u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec3(4u, 1u, 7u);
                var v1 = new uvec3(6u, 2u, 9u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec3(5u, 0u, 6u);
                var v1 = new uvec3(5u, 1u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec3(3u, 9u, 0u);
                var v1 = new uvec3(8u, 3u, 1u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec3(0u, 3u, 6u);
                var v1 = new uvec3(8u, 6u, 8u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec3(2u, 2u, 9u);
                var v1 = new uvec3(1u, 1u, 3u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new uvec3(0u, 8u, 1u);
                var v1 = new uvec3(1u, 8u, 2u);
                var v2 = new uvec3(4u, 8u, 1u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec3(5u, 4u, 3u);
                var v1 = new uvec3(0u, 1u, 9u);
                var v2 = new uvec3(2u, 5u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec3(9u, 1u, 9u);
                var v1 = new uvec3(7u, 2u, 6u);
                var v2 = new uvec3(9u, 1u, 9u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec3(9u, 3u, 4u);
                var v1 = new uvec3(0u, 3u, 6u);
                var v2 = new uvec3(8u, 6u, 2u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec3(1u, 6u, 3u);
                var v1 = new uvec3(7u, 9u, 5u);
                var v2 = new uvec3(0u, 2u, 1u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec3(8u, 6u, 0u);
                var v1 = new uvec3(6u, 5u, 3u);
                var v2 = new uvec3(6u, 8u, 2u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec3(0u, 2u, 6u);
                var v1 = new uvec3(5u, 1u, 6u);
                var v2 = new uvec3(2u, 5u, 4u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec3(6u, 4u, 1u);
                var v1 = new uvec3(7u, 1u, 4u);
                var v2 = new uvec3(6u, 0u, 9u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec3(9u, 1u, 2u);
                var v1 = new uvec3(4u, 7u, 9u);
                var v2 = new uvec3(4u, 0u, 5u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec3(9u, 3u, 8u);
                var v1 = new uvec3(1u, 4u, 4u);
                var v2 = new uvec3(4u, 7u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new uvec3(0u, 1u, 1u);
                var v1 = new uvec3(9u, 3u, 5u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec3(8u, 2u, 2u);
                var v1 = new uvec3(3u, 9u, 9u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec3(2u, 6u, 6u);
                var v1 = new uvec3(8u, 3u, 3u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec3(3u, 4u, 4u);
                var v1 = new uvec3(2u, 2u, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec3(5u, 5u, 5u);
                var v1 = new uvec3(0u, 5u, 7u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec3(1u, 0u, 4u);
                var v1 = new uvec3(2u, 2u, 7u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec3(0u, 3u, 6u);
                var v1 = new uvec3(5u, 4u, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec3(4u, 9u, 1u);
                var v1 = new uvec3(0u, 6u, 2u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec3(9u, 3u, 7u);
                var v1 = new uvec3(8u, 3u, 7u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec3(0u, 8u, 8u);
                var v1 = new uvec3(9u, 4u, 7u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new uvec3(2u, 3u, 1u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec3(7u, 7u, 8u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec3(1u, 7u, 6u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec3(1u, 9u, 1u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec3(3u, 0u, 4u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec3(8u, 3u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec3(7u, 8u, 4u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec3(3u, 5u, 0u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec3(0u, 7u, 2u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec3(1u, 4u, 8u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new uvec3(7u, 0u, 6u);
                var v1 = new uvec3(9u, 3u, 8u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uvec3(1u, 9u, 2u);
                var v1 = new uvec3(9u, 3u, 4u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uvec3(0u, 6u, 7u);
                var v1 = new uvec3(6u, 0u, 9u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uvec3(4u, 2u, 7u);
                var v1 = new uvec3(8u, 9u, 3u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uvec3(9u, 2u, 3u);
                var v1 = new uvec3(6u, 9u, 1u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uvec3(9u, 7u, 1u);
                var v1 = new uvec3(8u, 9u, 8u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uvec3(2u, 1u, 4u);
                var v1 = new uvec3(4u, 7u, 3u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uvec3(3u, 5u, 5u);
                var v1 = new uvec3(2u, 9u, 8u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uvec3(0u, 1u, 4u);
                var v1 = new uvec3(7u, 7u, 6u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new uvec3(8u, 8u, 1u);
                var v1 = new uvec3(3u, 0u, 0u);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(35781048);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.Random(random, 0, 4);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            Assert.AreEqual(avg.z, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1464696693);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.RandomUniform(random, 1, 3);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            Assert.AreEqual(avg.z, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(746128691);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.Random(random, 4, 6);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            Assert.AreEqual(avg.z, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(27560689);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.RandomUniform(random, 0, 5);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            Assert.AreEqual(avg.z, 2, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(762569409);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.Random(random, 5, 10);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 7, 1.0);
            Assert.AreEqual(avg.y, 7, 1.0);
            Assert.AreEqual(avg.z, 7, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1630178143);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.RandomPoisson(random, 2.61386011825589);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.61386011825589, 1.0);
            Assert.AreEqual(avg.y, 2.61386011825589, 1.0);
            Assert.AreEqual(avg.z, 2.61386011825589, 1.0);
            
            Assert.AreEqual(variance.x, 2.61386011825589, 3.0);
            Assert.AreEqual(variance.y, 2.61386011825589, 3.0);
            Assert.AreEqual(variance.z, 2.61386011825589, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(911610141);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.RandomPoisson(random, 3.19387298482185);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.19387298482185, 1.0);
            Assert.AreEqual(avg.y, 3.19387298482185, 1.0);
            Assert.AreEqual(avg.z, 3.19387298482185, 1.0);
            
            Assert.AreEqual(variance.x, 3.19387298482185, 3.0);
            Assert.AreEqual(variance.y, 3.19387298482185, 3.0);
            Assert.AreEqual(variance.z, 3.19387298482185, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(919830500);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.RandomPoisson(random, 1.64144013130173);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.64144013130173, 1.0);
            Assert.AreEqual(avg.y, 1.64144013130173, 1.0);
            Assert.AreEqual(avg.z, 1.64144013130173, 1.0);
            
            Assert.AreEqual(variance.x, 1.64144013130173, 3.0);
            Assert.AreEqual(variance.y, 1.64144013130173, 3.0);
            Assert.AreEqual(variance.z, 1.64144013130173, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(201262498);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.RandomPoisson(random, 3.29873869186209);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.29873869186209, 1.0);
            Assert.AreEqual(avg.y, 3.29873869186209, 1.0);
            Assert.AreEqual(avg.z, 3.29873869186209, 1.0);
            
            Assert.AreEqual(variance.x, 3.29873869186209, 3.0);
            Assert.AreEqual(variance.y, 3.29873869186209, 3.0);
            Assert.AreEqual(variance.z, 3.29873869186209, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(209482857);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec3.RandomPoisson(random, 1.74630583834197);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.74630583834197, 1.0);
            Assert.AreEqual(avg.y, 1.74630583834197, 1.0);
            Assert.AreEqual(avg.z, 1.74630583834197, 1.0);
            
            Assert.AreEqual(variance.x, 1.74630583834197, 3.0);
            Assert.AreEqual(variance.y, 1.74630583834197, 3.0);
            Assert.AreEqual(variance.z, 1.74630583834197, 3.0);
        }

    }
}
