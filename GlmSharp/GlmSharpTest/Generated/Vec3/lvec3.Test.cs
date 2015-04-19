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
    public class LongVec3Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec3(-8L);
                Assert.AreEqual(-8L, v.x);
                Assert.AreEqual(-8L, v.y);
                Assert.AreEqual(-8L, v.z);
            }
            {
                var v = new lvec3(9L, -9L, 3L);
                Assert.AreEqual(9L, v.x);
                Assert.AreEqual(-9L, v.y);
                Assert.AreEqual(3L, v.z);
            }
            {
                var v = new lvec3(new lvec2(-5L, -7L));
                Assert.AreEqual(-5L, v.x);
                Assert.AreEqual(-7L, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new lvec3(new lvec3(6L, -6L, -9L));
                Assert.AreEqual(6L, v.x);
                Assert.AreEqual(-6L, v.y);
                Assert.AreEqual(-9L, v.z);
            }
            {
                var v = new lvec3(new lvec4(0, 4L, 6L, -1L));
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4L, v.y);
                Assert.AreEqual(6L, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec3(-8L, -8L, -1L);
            Assert.AreEqual(-8L, v[0]);
            Assert.AreEqual(-8L, v[1]);
            Assert.AreEqual(-1L, v[2]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[3]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[3] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[2] = 1;
            Assert.AreEqual(1, v[2]);
            v[1] = 2L;
            Assert.AreEqual(2L, v[1]);
            v[2] = 3L;
            Assert.AreEqual(3L, v[2]);
            v[2] = 4L;
            Assert.AreEqual(4L, v[2]);
            v[1] = 5L;
            Assert.AreEqual(5L, v[1]);
            v[0] = 6L;
            Assert.AreEqual(6L, v[0]);
            v[1] = 7L;
            Assert.AreEqual(7L, v[1]);
            v[1] = 8L;
            Assert.AreEqual(8L, v[1]);
            v[1] = 9L;
            Assert.AreEqual(9L, v[1]);
            v[2] = -1L;
            Assert.AreEqual(-1L, v[2]);
            v[2] = -2L;
            Assert.AreEqual(-2L, v[2]);
            v[1] = -3L;
            Assert.AreEqual(-3L, v[1]);
            v[1] = -4L;
            Assert.AreEqual(-4L, v[1]);
            v[1] = -5L;
            Assert.AreEqual(-5L, v[1]);
            v[0] = -6L;
            Assert.AreEqual(-6L, v[0]);
            v[1] = -7L;
            Assert.AreEqual(-7L, v[1]);
            v[1] = -8L;
            Assert.AreEqual(-8L, v[1]);
            v[1] = -9L;
            Assert.AreEqual(-9L, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new lvec3(-1L, 1, 6L);
            var vals = v.Values;
            Assert.AreEqual(-1L, vals[0]);
            Assert.AreEqual(1, vals[1]);
            Assert.AreEqual(6L, vals[2]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, lvec3.Zero.x);
            Assert.AreEqual(0, lvec3.Zero.y);
            Assert.AreEqual(0, lvec3.Zero.z);
            
            Assert.AreEqual(1, lvec3.Ones.x);
            Assert.AreEqual(1, lvec3.Ones.y);
            Assert.AreEqual(1, lvec3.Ones.z);
            
            Assert.AreEqual(1, lvec3.UnitX.x);
            Assert.AreEqual(0, lvec3.UnitX.y);
            Assert.AreEqual(0, lvec3.UnitX.z);
            
            Assert.AreEqual(0, lvec3.UnitY.x);
            Assert.AreEqual(1, lvec3.UnitY.y);
            Assert.AreEqual(0, lvec3.UnitY.z);
            
            Assert.AreEqual(0, lvec3.UnitZ.x);
            Assert.AreEqual(0, lvec3.UnitZ.y);
            Assert.AreEqual(1, lvec3.UnitZ.z);
            
            Assert.AreEqual(long.MaxValue, lvec3.MaxValue.x);
            Assert.AreEqual(long.MaxValue, lvec3.MaxValue.y);
            Assert.AreEqual(long.MaxValue, lvec3.MaxValue.z);
            
            Assert.AreEqual(long.MinValue, lvec3.MinValue.x);
            Assert.AreEqual(long.MinValue, lvec3.MinValue.y);
            Assert.AreEqual(long.MinValue, lvec3.MinValue.z);
        }

        [Test]
        public void Operators()
        {
            var v1 = new lvec3(6L, -5L, 3L);
            var v2 = new lvec3(6L, -5L, 3L);
            var v3 = new lvec3(3L, -5L, 6L);
            Assert.That(v1 == new lvec3(v1));
            Assert.That(v2 == new lvec3(v2));
            Assert.That(v3 == new lvec3(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new lvec3(8L, 3L, -7L);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = lvec3.Parse(s0);
            var v1 = lvec3.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = lvec3.TryParse(s0, out v0);
            var b1 = lvec3.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = lvec3.TryParse(null, out v0);
            Assert.False(b0);
            b0 = lvec3.TryParse("", out v0);
            Assert.False(b0);
            b0 = lvec3.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { lvec3.Parse(null); });
            Assert.Throws<FormatException>(() => { lvec3.Parse(""); });
            Assert.Throws<FormatException>(() => { lvec3.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = lvec3.Parse(s3, "; ", NumberStyles.Number);
            var v4 = lvec3.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = lvec3.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new lvec3(-1L, 4L, -7L);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<lvec3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new lvec3(-9L, 6L, 5L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-4L, 0, 3L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(9L, -9L, -7L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-7L, 3L, -1L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-3L, 9L, 5L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(5L, 3L, 4L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-3L, -5L, -3L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-5L, -9L, -2L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-6L, 4L, 2L);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(2L, 3L, 1);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new lvec3(-7L, 7L, -5L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-6L, -1L, -5L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-5L, 1, 9L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(1, -4L, 7L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(0, -6L, 5L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(9L, -1L, 4L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-4L, 4L, -2L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(0, 7L, -6L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-8L, -3L, 6L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-5L, -1L, -6L);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new lvec3(5L, 7L, 5L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(5L, 2L, -4L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-9L, -1L, -6L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-1L, -3L, 3L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(5L, 3L, 4L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-3L, -2L, 2L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-5L, -6L, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(8L, -1L, -3L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-9L, -2L, -2L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(3L, -3L, -7L);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new lvec3(-3L, 6L, -6L);
                var v1 = new lvec3(-3L, 1, -9L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-7L, 7L, 9L);
                var v1 = new lvec3(5L, -2L, -4L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-1L, -6L, 2L);
                var v1 = new lvec3(-8L, 0, 8L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-4L, 1, 0);
                var v1 = new lvec3(6L, 0, 0);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-1L, -7L, -5L);
                var v1 = new lvec3(1, -8L, 1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-9L, -9L, 0);
                var v1 = new lvec3(2L, 6L, -2L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-4L, 9L, 5L);
                var v1 = new lvec3(8L, 7L, -6L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(1, -5L, -1L);
                var v1 = new lvec3(4L, 8L, -7L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-9L, 3L, 4L);
                var v1 = new lvec3(-1L, -2L, 9L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(1, 6L, 5L);
                var v1 = new lvec3(-6L, 2L, 3L);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new lvec3(1, -4L, -2L);
                var v1 = new lvec3(0, -6L, 3L);
                var v2 = new lvec3(4L, 6L, -7L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-3L, 2L, 1);
                var v1 = new lvec3(2L, -7L, 8L);
                var v2 = new lvec3(-9L, -4L, 3L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-4L, -6L, -1L);
                var v1 = new lvec3(-3L, -3L, -2L);
                var v2 = new lvec3(4L, 6L, 5L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(8L, 4L, -1L);
                var v1 = new lvec3(4L, -2L, 3L);
                var v2 = new lvec3(9L, 0, 2L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-6L, 0, -4L);
                var v1 = new lvec3(5L, -1L, -9L);
                var v2 = new lvec3(3L, -3L, -3L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-6L, 2L, -4L);
                var v1 = new lvec3(8L, 1, -4L);
                var v2 = new lvec3(-9L, 7L, 4L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(6L, 8L, 0);
                var v1 = new lvec3(0, -6L, 8L);
                var v2 = new lvec3(-7L, -5L, 1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(5L, 7L, 9L);
                var v1 = new lvec3(-8L, -3L, -6L);
                var v2 = new lvec3(6L, 3L, -4L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(8L, 7L, 4L);
                var v1 = new lvec3(-2L, 8L, 0);
                var v2 = new lvec3(-8L, 7L, 4L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-1L, -9L, 3L);
                var v1 = new lvec3(-6L, 4L, 4L);
                var v2 = new lvec3(-8L, 2L, -1L);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new lvec3(2L, 7L, 9L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-9L, 2L, -8L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-2L, 1, 0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(7L, -9L, -2L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-7L, -1L, -6L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-5L, -2L, 2L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(6L, 5L, -6L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-9L, -8L, -7L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-8L, 7L, 8L);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-5L, -3L, 3L);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new lvec3(5L, -9L, -7L);
                var v1 = new lvec3(1, -1L, -9L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(9L, 6L, -5L);
                var v1 = new lvec3(-9L, -2L, -1L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(5L, -3L, 5L);
                var v1 = new lvec3(3L, -7L, -1L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(-4L, -1L, -6L);
                var v1 = new lvec3(8L, -4L, 4L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(7L, 9L, 9L);
                var v1 = new lvec3(-5L, 4L, 3L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(1, 2L, 5L);
                var v1 = new lvec3(8L, -7L, -4L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(-4L, 8L, -7L);
                var v1 = new lvec3(1, 4L, -8L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(9L, -1L, 4L);
                var v1 = new lvec3(2L, 3L, 2L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(-7L, 2L, -3L);
                var v1 = new lvec3(5L, -4L, -5L);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(0, -6L, 4L);
                var v1 = new lvec3(-3L, -4L, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new lvec3(7L, 8L, -9L);
                var v1 = new lvec3(9L, -2L, 6L);
                var v2 = new lvec3(-2L, -5L, 2L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-1L, -1L, -1L);
                var v1 = new lvec3(2L, -7L, 5L);
                var v2 = new lvec3(7L, -9L, 5L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(8L, -2L, 2L);
                var v1 = new lvec3(4L, 3L, -5L);
                var v2 = new lvec3(-3L, 9L, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-3L, -4L, 2L);
                var v1 = new lvec3(-3L, 1, 3L);
                var v2 = new lvec3(-8L, 5L, 2L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-3L, 5L, 3L);
                var v1 = new lvec3(1, 2L, -9L);
                var v2 = new lvec3(4L, 0, 9L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-1L, -2L, -9L);
                var v1 = new lvec3(-2L, 5L, -9L);
                var v2 = new lvec3(-5L, -1L, 4L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(5L, 3L, 5L);
                var v1 = new lvec3(4L, -6L, 2L);
                var v2 = new lvec3(4L, -8L, 0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-9L, -7L, 8L);
                var v1 = new lvec3(6L, 3L, -2L);
                var v2 = new lvec3(2L, -4L, -4L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(2L, 6L, 8L);
                var v1 = new lvec3(3L, -9L, 2L);
                var v2 = new lvec3(4L, 2L, -8L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(2L, 1, 8L);
                var v1 = new lvec3(3L, -8L, 9L);
                var v2 = new lvec3(-8L, -3L, 2L);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new lvec3(5L, 1, 6L);
                var v1 = new lvec3(5L, -8L, 2L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(1, 3L, -5L);
                var v1 = new lvec3(-5L, -3L, -9L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-8L, -4L, -6L);
                var v1 = new lvec3(4L, -6L, -2L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-7L, -5L, 3L);
                var v1 = new lvec3(5L, 9L, -4L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-1L, 7L, 0);
                var v1 = new lvec3(-5L, 1, -6L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-9L, 3L, -1L);
                var v1 = new lvec3(1, -8L, 8L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(3L, -8L, -7L);
                var v1 = new lvec3(-9L, 4L, -4L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(3L, -3L, -6L);
                var v1 = new lvec3(6L, 1, -5L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(4L, 0, 2L);
                var v1 = new lvec3(8L, -7L, -5L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-4L, -9L, -1L);
                var v1 = new lvec3(-2L, -4L, -1L);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new lvec3(4L, 9L, -3L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(-5L, -5L, -8L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(7L, 4L, -9L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(1, 5L, 8L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(4L, 7L, -8L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(2L, 4L, 2L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(-8L, 4L, -6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(8L, 2L, 1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(-6L, -1L, -9L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(-2L, -1L, -6L);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new lvec3(-4L, 4L, 3L);
                var v1 = new lvec3(1, 7L, -9L);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(6L, 9L, -1L);
                var v1 = new lvec3(-5L, -4L, -4L);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-9L, -9L, 3L);
                var v1 = new lvec3(-7L, -8L, 2L);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-3L, -2L, 3L);
                var v1 = new lvec3(-8L, 9L, 6L);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-3L, 2L, 0);
                var v1 = new lvec3(2L, 0, 1);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-5L, 9L, -2L);
                var v1 = new lvec3(5L, -3L, -9L);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-2L, -4L, 2L);
                var v1 = new lvec3(-7L, 1, -8L);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(4L, 2L, 0);
                var v1 = new lvec3(4L, 8L, 4L);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(4L, -2L, 0);
                var v1 = new lvec3(7L, 3L, -2L);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-1L, -5L, -5L);
                var v1 = new lvec3(-6L, 7L, 5L);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(69950535);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.Random(random, 4, 6);
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
        public void RandomUniform1()
        {
            var random = new Random(1498866180);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.RandomUniform(random, -1, 3);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.5, 1.0);
            Assert.AreEqual(avg.y, 0.5, 1.0);
            Assert.AreEqual(avg.z, 0.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(780298178);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.Random(random, 4, 8);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5.5, 1.0);
            Assert.AreEqual(avg.y, 5.5, 1.0);
            Assert.AreEqual(avg.z, 5.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(61730176);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.RandomUniform(random, -1, 2);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.z, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(796738896);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.Random(random, 4, 7);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 5, 1.0);
            Assert.AreEqual(avg.y, 5, 1.0);
            Assert.AreEqual(avg.z, 5, 1.0);
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.z, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(1596008656);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.RandomPoisson(random, 2.07107732983822);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.07107732983822, 1.0);
            Assert.AreEqual(avg.y, 2.07107732983822, 1.0);
            Assert.AreEqual(avg.z, 2.07107732983822, 1.0);
            
            Assert.AreEqual(variance.x, 2.07107732983822, 3.0);
            Assert.AreEqual(variance.y, 2.07107732983822, 3.0);
            Assert.AreEqual(variance.z, 2.07107732983822, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(877440654);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.RandomPoisson(random, 0.736655773239516);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.736655773239516, 1.0);
            Assert.AreEqual(avg.y, 0.736655773239516, 1.0);
            Assert.AreEqual(avg.z, 0.736655773239516, 1.0);
            
            Assert.AreEqual(variance.x, 0.736655773239516, 3.0);
            Assert.AreEqual(variance.y, 0.736655773239516, 3.0);
            Assert.AreEqual(variance.z, 0.736655773239516, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(885661013);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.RandomPoisson(random, 2.1842229197194);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.1842229197194, 1.0);
            Assert.AreEqual(avg.y, 2.1842229197194, 1.0);
            Assert.AreEqual(avg.z, 2.1842229197194, 1.0);
            
            Assert.AreEqual(variance.x, 2.1842229197194, 3.0);
            Assert.AreEqual(variance.y, 2.1842229197194, 3.0);
            Assert.AreEqual(variance.z, 2.1842229197194, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(167093011);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.RandomPoisson(random, 0.841521480279752);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.841521480279752, 1.0);
            Assert.AreEqual(avg.y, 0.841521480279752, 1.0);
            Assert.AreEqual(avg.z, 0.841521480279752, 1.0);
            
            Assert.AreEqual(variance.x, 0.841521480279752, 3.0);
            Assert.AreEqual(variance.y, 0.841521480279752, 3.0);
            Assert.AreEqual(variance.z, 0.841521480279752, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(175313370);
            var sum = new dvec3(0.0);
            var sumSqr = new dvec3(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec3.RandomPoisson(random, 2.28908862675963);
                sum += (dvec3)v;
                sumSqr += glm.Pow2((dvec3)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.28908862675963, 1.0);
            Assert.AreEqual(avg.y, 2.28908862675963, 1.0);
            Assert.AreEqual(avg.z, 2.28908862675963, 1.0);
            
            Assert.AreEqual(variance.x, 2.28908862675963, 3.0);
            Assert.AreEqual(variance.y, 2.28908862675963, 3.0);
            Assert.AreEqual(variance.z, 2.28908862675963, 3.0);
        }

    }
}
