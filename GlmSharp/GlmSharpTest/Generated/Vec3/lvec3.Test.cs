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
                var v = new lvec3(-8);
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(-8, v.y);
                Assert.AreEqual(-8, v.z);
            }
            {
                var v = new lvec3(9, -9, 3);
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(3, v.z);
            }
            {
                var v = new lvec3(new lvec2(-5, -7));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-7, v.y);
                Assert.AreEqual(0, v.z);
            }
            {
                var v = new lvec3(new lvec3(6, -6, -9));
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(-9, v.z);
            }
            {
                var v = new lvec3(new lvec4(0, 4, 6, -1));
                Assert.AreEqual(0, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(6, v.z);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec3(-8, -8, -1);
            Assert.AreEqual(-8, v[0]);
            Assert.AreEqual(-8, v[1]);
            Assert.AreEqual(-1, v[2]);
            
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
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[2] = 3;
            Assert.AreEqual(3, v[2]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[1] = 5;
            Assert.AreEqual(5, v[1]);
            v[0] = 6;
            Assert.AreEqual(6, v[0]);
            v[1] = 7;
            Assert.AreEqual(7, v[1]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[2] = -2;
            Assert.AreEqual(-2, v[2]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new lvec3(-1, 1, 6);
            var vals = v.Values;
            Assert.AreEqual(-1, vals[0]);
            Assert.AreEqual(1, vals[1]);
            Assert.AreEqual(6, vals[2]);
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
            var v1 = new lvec3(6, -5, 3);
            var v2 = new lvec3(6, -5, 3);
            var v3 = new lvec3(3, -5, 6);
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
            var v = new lvec3(8, 3, -7);
            
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
            var v0 = new lvec3(-1, 4, -7);
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
                var v0 = new lvec3(-9, 6, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-4, 0, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(9, -9, -7);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-7, 3, -1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-3, 9, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(5, 3, 4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-3, -5, -3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-5, -9, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(-6, 4, 2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec3(2, 3, 1);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new lvec3(-7, 7, -5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-6, -1, -5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-5, 1, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(1, -4, 7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(0, -6, 5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(9, -1, 4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-4, 4, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(0, 7, -6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-8, -3, 6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec3(-5, -1, -6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new lvec3(5, 7, 5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(5, 2, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-9, -1, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-1, -3, 3);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(5, 3, 4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-3, -2, 2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-5, -6, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(8, -1, -3);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(-9, -2, -2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec3(3, -3, -7);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new lvec3(-3, 6, -6);
                var v1 = new lvec3(-3, 1, -9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-7, 7, 9);
                var v1 = new lvec3(5, -2, -4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-1, -6, 2);
                var v1 = new lvec3(-8, 0, 8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-4, 1, 0);
                var v1 = new lvec3(6, 0, 0);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-1, -7, -5);
                var v1 = new lvec3(1, -8, 1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-9, -9, 0);
                var v1 = new lvec3(2, 6, -2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-4, 9, 5);
                var v1 = new lvec3(8, 7, -6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(1, -5, -1);
                var v1 = new lvec3(4, 8, -7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(-9, 3, 4);
                var v1 = new lvec3(-1, -2, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec3(1, 6, 5);
                var v1 = new lvec3(-6, 2, 3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new lvec3(1, -4, -2);
                var v1 = new lvec3(0, -6, 3);
                var v2 = new lvec3(4, 6, -7);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-3, 2, 1);
                var v1 = new lvec3(2, -7, 8);
                var v2 = new lvec3(-9, -4, 3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-4, -6, -1);
                var v1 = new lvec3(-3, -3, -2);
                var v2 = new lvec3(4, 6, 5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(8, 4, -1);
                var v1 = new lvec3(4, -2, 3);
                var v2 = new lvec3(9, 0, 2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-6, 0, -4);
                var v1 = new lvec3(5, -1, -9);
                var v2 = new lvec3(3, -3, -3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-6, 2, -4);
                var v1 = new lvec3(8, 1, -4);
                var v2 = new lvec3(-9, 7, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(6, 8, 0);
                var v1 = new lvec3(0, -6, 8);
                var v2 = new lvec3(-7, -5, 1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(5, 7, 9);
                var v1 = new lvec3(-8, -3, -6);
                var v2 = new lvec3(6, 3, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(8, 7, 4);
                var v1 = new lvec3(-2, 8, 0);
                var v2 = new lvec3(-8, 7, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec3(-1, -9, 3);
                var v1 = new lvec3(-6, 4, 4);
                var v2 = new lvec3(-8, 2, -1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new lvec3(2, 7, 9);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-9, 2, -8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-2, 1, 0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(7, -9, -2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-7, -1, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-5, -2, 2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(6, 5, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-9, -8, -7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-8, 7, 8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec3(-5, -3, 3);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new lvec3(5, -9, -7);
                var v1 = new lvec3(1, -1, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(9, 6, -5);
                var v1 = new lvec3(-9, -2, -1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(5, -3, 5);
                var v1 = new lvec3(3, -7, -1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(-4, -1, -6);
                var v1 = new lvec3(8, -4, 4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(7, 9, 9);
                var v1 = new lvec3(-5, 4, 3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(1, 2, 5);
                var v1 = new lvec3(8, -7, -4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(-4, 8, -7);
                var v1 = new lvec3(1, 4, -8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(9, -1, 4);
                var v1 = new lvec3(2, 3, 2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(-7, 2, -3);
                var v1 = new lvec3(5, -4, -5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec3(0, -6, 4);
                var v1 = new lvec3(-3, -4, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new lvec3(7, 8, -9);
                var v1 = new lvec3(9, -2, 6);
                var v2 = new lvec3(-2, -5, 2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-1, -1, -1);
                var v1 = new lvec3(2, -7, 5);
                var v2 = new lvec3(7, -9, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(8, -2, 2);
                var v1 = new lvec3(4, 3, -5);
                var v2 = new lvec3(-3, 9, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-3, -4, 2);
                var v1 = new lvec3(-3, 1, 3);
                var v2 = new lvec3(-8, 5, 2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-3, 5, 3);
                var v1 = new lvec3(1, 2, -9);
                var v2 = new lvec3(4, 0, 9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-1, -2, -9);
                var v1 = new lvec3(-2, 5, -9);
                var v2 = new lvec3(-5, -1, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(5, 3, 5);
                var v1 = new lvec3(4, -6, 2);
                var v2 = new lvec3(4, -8, 0);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(-9, -7, 8);
                var v1 = new lvec3(6, 3, -2);
                var v2 = new lvec3(2, -4, -4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(2, 6, 8);
                var v1 = new lvec3(3, -9, 2);
                var v2 = new lvec3(4, 2, -8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec3(2, 1, 8);
                var v1 = new lvec3(3, -8, 9);
                var v2 = new lvec3(-8, -3, 2);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new lvec3(5, 1, 6);
                var v1 = new lvec3(5, -8, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(1, 3, -5);
                var v1 = new lvec3(-5, -3, -9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-8, -4, -6);
                var v1 = new lvec3(4, -6, -2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-7, -5, 3);
                var v1 = new lvec3(5, 9, -4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-1, 7, 0);
                var v1 = new lvec3(-5, 1, -6);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-9, 3, -1);
                var v1 = new lvec3(1, -8, 8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(3, -8, -7);
                var v1 = new lvec3(-9, 4, -4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(3, -3, -6);
                var v1 = new lvec3(6, 1, -5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(4, 0, 2);
                var v1 = new lvec3(8, -7, -5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec3(-4, -9, -1);
                var v1 = new lvec3(-2, -4, -1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new lvec3(4, 9, -3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(-5, -5, -8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(7, 4, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(1, 5, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(4, 7, -8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(2, 4, 2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(-8, 4, -6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(8, 2, 1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(-6, -1, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec3(-2, -1, -6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void InvariantCrossDot()
        {
            {
                var v0 = new lvec3(-4, 4, 3);
                var v1 = new lvec3(1, 7, -9);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(6, 9, -1);
                var v1 = new lvec3(-5, -4, -4);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-9, -9, 3);
                var v1 = new lvec3(-7, -8, 2);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-3, -2, 3);
                var v1 = new lvec3(-8, 9, 6);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-3, 2, 0);
                var v1 = new lvec3(2, 0, 1);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-5, 9, -2);
                var v1 = new lvec3(5, -3, -9);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-2, -4, 2);
                var v1 = new lvec3(-7, 1, -8);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(4, 2, 0);
                var v1 = new lvec3(4, 8, 4);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(4, -2, 0);
                var v1 = new lvec3(7, 3, -2);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
            {
                var v0 = new lvec3(-1, -5, -5);
                var v1 = new lvec3(-6, 7, 5);
                Assert.Less(glm.Abs(glm.Dot(v0, glm.Cross(v0, v1))), 0.1);
            }
        }

    }
}
