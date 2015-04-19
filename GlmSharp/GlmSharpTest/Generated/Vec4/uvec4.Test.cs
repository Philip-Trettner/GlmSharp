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
                var v = new uvec4(0u, 2u, 0u, 8u);
                Assert.AreEqual(0u, v.x);
                Assert.AreEqual(2u, v.y);
                Assert.AreEqual(0u, v.z);
                Assert.AreEqual(8u, v.w);
            }
            {
                var v = new uvec4(new uvec2(1u, 5u));
                Assert.AreEqual(1u, v.x);
                Assert.AreEqual(5u, v.y);
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
                var v = new uvec4(new uvec4(2u, 6u, 2u, 1u));
                Assert.AreEqual(2u, v.x);
                Assert.AreEqual(6u, v.y);
                Assert.AreEqual(2u, v.z);
                Assert.AreEqual(1u, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new uvec4(2u, 4u, 8u, 2u);
            Assert.AreEqual(2u, v[0]);
            Assert.AreEqual(4u, v[1]);
            Assert.AreEqual(8u, v[2]);
            Assert.AreEqual(2u, v[3]);
            
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
            v[3] = 2u;
            Assert.AreEqual(2u, v[3]);
            v[0] = 3u;
            Assert.AreEqual(3u, v[0]);
            v[2] = 4u;
            Assert.AreEqual(4u, v[2]);
            v[1] = 5u;
            Assert.AreEqual(5u, v[1]);
            v[2] = 6u;
            Assert.AreEqual(6u, v[2]);
            v[0] = 7u;
            Assert.AreEqual(7u, v[0]);
            v[0] = 8u;
            Assert.AreEqual(8u, v[0]);
            v[3] = 9u;
            Assert.AreEqual(9u, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new uvec4(8u, 5u, 6u, 5u);
            var vals = v.Values;
            Assert.AreEqual(8u, vals[0]);
            Assert.AreEqual(5u, vals[1]);
            Assert.AreEqual(6u, vals[2]);
            Assert.AreEqual(5u, vals[3]);
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
            var v1 = new uvec4(0u, 2u, 9u, 5u);
            var v2 = new uvec4(0u, 2u, 9u, 5u);
            var v3 = new uvec4(5u, 9u, 2u, 0u);
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
            var v = new uvec4(7u, 7u, 0u, 9u);
            
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
            var v0 = new uvec4(8u, 7u, 0u, 6u);
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
                var v0 = new uvec4(6u, 8u, 0u, 8u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(9u, 9u, 3u, 6u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(7u, 7u, 1u, 1u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(9u, 6u, 7u, 5u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(9u, 6u, 4u, 9u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(1u, 8u, 2u, 7u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(8u, 0u, 1u, 5u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(0u, 5u, 8u, 4u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(7u, 0u, 2u, 2u);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new uvec4(5u, 1u, 8u, 0u);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new uvec4(1u, 9u, 9u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(5u, 0u, 9u, 3u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(5u, 1u, 7u, 7u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(7u, 6u, 8u, 2u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(7u, 8u, 9u, 0u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(0u, 9u, 1u, 6u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(8u, 7u, 2u, 2u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(6u, 3u, 0u, 4u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(6u, 7u, 1u, 9u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new uvec4(3u, 1u, 2u, 3u);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new uvec4(5u, 9u, 5u, 1u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(1u, 0u, 1u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(8u, 6u, 6u, 5u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(9u, 0u, 7u, 3u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(7u, 7u, 0u, 6u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(5u, 4u, 2u, 4u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(9u, 7u, 5u, 7u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(7u, 3u, 6u, 7u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(3u, 6u, 0u, 9u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new uvec4(9u, 9u, 5u, 8u);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new uvec4(2u, 3u, 8u, 6u);
                var v1 = new uvec4(2u, 0u, 3u, 5u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(0u, 5u, 5u, 5u);
                var v1 = new uvec4(9u, 6u, 1u, 0u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(7u, 4u, 1u, 1u);
                var v1 = new uvec4(7u, 4u, 0u, 7u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(6u, 1u, 0u, 6u);
                var v1 = new uvec4(7u, 6u, 2u, 6u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(1u, 9u, 9u, 9u);
                var v1 = new uvec4(8u, 0u, 8u, 3u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(9u, 4u, 4u, 0u);
                var v1 = new uvec4(4u, 2u, 5u, 6u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(9u, 4u, 8u, 2u);
                var v1 = new uvec4(4u, 6u, 9u, 7u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(3u, 1u, 0u, 1u);
                var v1 = new uvec4(9u, 6u, 7u, 3u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(2u, 9u, 3u, 0u);
                var v1 = new uvec4(6u, 2u, 1u, 6u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new uvec4(5u, 7u, 1u, 3u);
                var v1 = new uvec4(0u, 9u, 2u, 3u);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new uvec4(3u, 2u, 8u, 8u);
                var v1 = new uvec4(8u, 4u, 3u, 6u);
                var v2 = new uvec4(9u, 7u, 1u, 4u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(8u, 7u, 9u, 6u);
                var v1 = new uvec4(9u, 7u, 9u, 6u);
                var v2 = new uvec4(0u, 5u, 3u, 4u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(1u, 5u, 2u, 9u);
                var v1 = new uvec4(3u, 0u, 6u, 0u);
                var v2 = new uvec4(5u, 2u, 9u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(6u, 0u, 1u, 8u);
                var v1 = new uvec4(7u, 1u, 8u, 4u);
                var v2 = new uvec4(6u, 4u, 5u, 7u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(8u, 8u, 9u, 5u);
                var v1 = new uvec4(3u, 0u, 2u, 7u);
                var v2 = new uvec4(8u, 4u, 7u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(2u, 3u, 2u, 8u);
                var v1 = new uvec4(0u, 1u, 8u, 6u);
                var v2 = new uvec4(7u, 6u, 9u, 8u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(6u, 1u, 8u, 9u);
                var v1 = new uvec4(7u, 8u, 8u, 7u);
                var v2 = new uvec4(9u, 5u, 1u, 5u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(1u, 0u, 6u, 4u);
                var v1 = new uvec4(0u, 1u, 4u, 2u);
                var v2 = new uvec4(3u, 7u, 5u, 3u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(8u, 9u, 4u, 4u);
                var v1 = new uvec4(5u, 9u, 9u, 1u);
                var v2 = new uvec4(8u, 0u, 9u, 2u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new uvec4(2u, 2u, 9u, 9u);
                var v1 = new uvec4(6u, 9u, 3u, 7u);
                var v2 = new uvec4(1u, 6u, 7u, 9u);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new uvec4(0u, 6u, 5u, 2u);
                var v1 = new uvec4(0u, 8u, 8u, 0u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(6u, 8u, 8u, 9u);
                var v1 = new uvec4(7u, 3u, 6u, 7u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(4u, 7u, 7u, 2u);
                var v1 = new uvec4(0u, 8u, 7u, 3u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(6u, 8u, 9u, 9u);
                var v1 = new uvec4(3u, 2u, 9u, 2u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(9u, 2u, 0u, 4u);
                var v1 = new uvec4(9u, 5u, 5u, 8u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(1u, 0u, 5u, 6u);
                var v1 = new uvec4(9u, 4u, 1u, 4u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(3u, 8u, 1u, 1u);
                var v1 = new uvec4(2u, 2u, 4u, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(9u, 1u, 5u, 2u);
                var v1 = new uvec4(9u, 9u, 6u, 4u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(9u, 6u, 0u, 4u);
                var v1 = new uvec4(3u, 1u, 7u, 9u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new uvec4(1u, 8u, 1u, 9u);
                var v1 = new uvec4(3u, 1u, 4u, 1u);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new uvec4(9u, 9u, 4u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(7u, 6u, 2u, 9u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(8u, 9u, 2u, 0u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(5u, 5u, 3u, 4u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(0u, 5u, 6u, 4u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(3u, 5u, 4u, 2u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(8u, 4u, 0u, 0u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(4u, 2u, 5u, 7u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(3u, 0u, 1u, 3u);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new uvec4(0u, 9u, 7u, 9u);
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
            var variance = sumSqr / (double)count - avg * avg;
            
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
            var variance = sumSqr / (double)count - avg * avg;
            
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
            var variance = sumSqr / (double)count - avg * avg;
            
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
            var variance = sumSqr / (double)count - avg * avg;
            
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
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            Assert.AreEqual(avg.z, 2.5, 1.0);
            Assert.AreEqual(avg.w, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1006857680);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.RandomPoisson(random, 0.646168329821047);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.646168329821047, 1.0);
            Assert.AreEqual(avg.y, 0.646168329821047, 1.0);
            Assert.AreEqual(avg.z, 0.646168329821047, 1.0);
            Assert.AreEqual(avg.w, 0.646168329821047, 1.0);
            
            Assert.AreEqual(variance.x, 0.646168329821047, 3.0);
            Assert.AreEqual(variance.y, 0.646168329821047, 3.0);
            Assert.AreEqual(variance.z, 0.646168329821047, 3.0);
            Assert.AreEqual(variance.w, 0.646168329821047, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(288289678);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.RandomPoisson(random, 2.16156477325669);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.16156477325669, 1.0);
            Assert.AreEqual(avg.y, 2.16156477325669, 1.0);
            Assert.AreEqual(avg.z, 2.16156477325669, 1.0);
            Assert.AreEqual(avg.w, 2.16156477325669, 1.0);
            
            Assert.AreEqual(variance.x, 2.16156477325669, 3.0);
            Assert.AreEqual(variance.y, 2.16156477325669, 3.0);
            Assert.AreEqual(variance.z, 2.16156477325669, 3.0);
            Assert.AreEqual(variance.w, 2.16156477325669, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(296510037);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.RandomPoisson(random, 0.60913191973657);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.60913191973657, 1.0);
            Assert.AreEqual(avg.y, 0.60913191973657, 1.0);
            Assert.AreEqual(avg.z, 0.60913191973657, 1.0);
            Assert.AreEqual(avg.w, 0.60913191973657, 1.0);
            
            Assert.AreEqual(variance.x, 0.60913191973657, 3.0);
            Assert.AreEqual(variance.y, 0.60913191973657, 3.0);
            Assert.AreEqual(variance.z, 0.60913191973657, 3.0);
            Assert.AreEqual(variance.w, 0.60913191973657, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(1725425682);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.RandomPoisson(random, 2.26643048029692);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.26643048029692, 1.0);
            Assert.AreEqual(avg.y, 2.26643048029692, 1.0);
            Assert.AreEqual(avg.z, 2.26643048029692, 1.0);
            Assert.AreEqual(avg.w, 2.26643048029692, 1.0);
            
            Assert.AreEqual(variance.x, 2.26643048029692, 3.0);
            Assert.AreEqual(variance.y, 2.26643048029692, 3.0);
            Assert.AreEqual(variance.z, 2.26643048029692, 3.0);
            Assert.AreEqual(variance.w, 2.26643048029692, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(1733646041);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = uvec4.RandomPoisson(random, 0.713997626776806);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.713997626776806, 1.0);
            Assert.AreEqual(avg.y, 0.713997626776806, 1.0);
            Assert.AreEqual(avg.z, 0.713997626776806, 1.0);
            Assert.AreEqual(avg.w, 0.713997626776806, 1.0);
            
            Assert.AreEqual(variance.x, 0.713997626776806, 3.0);
            Assert.AreEqual(variance.y, 0.713997626776806, 3.0);
            Assert.AreEqual(variance.z, 0.713997626776806, 3.0);
            Assert.AreEqual(variance.w, 0.713997626776806, 3.0);
        }

    }
}
