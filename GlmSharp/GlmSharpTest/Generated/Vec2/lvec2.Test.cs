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
    public class LongVec2Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec2(2);
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(2, v.y);
            }
            {
                var v = new lvec2(1, 9);
                Assert.AreEqual(1, v.x);
                Assert.AreEqual(9, v.y);
            }
            {
                var v = new lvec2(new lvec2(3, -2));
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(-2, v.y);
            }
            {
                var v = new lvec2(new lvec3(-8, 1, -9));
                Assert.AreEqual(-8, v.x);
                Assert.AreEqual(1, v.y);
            }
            {
                var v = new lvec2(new lvec4(6, 6, -9, -4));
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(6, v.y);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec2(2, -2);
            Assert.AreEqual(2, v[0]);
            Assert.AreEqual(-2, v[1]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[0] = 1;
            Assert.AreEqual(1, v[0]);
            v[0] = 2;
            Assert.AreEqual(2, v[0]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[1] = 4;
            Assert.AreEqual(4, v[1]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[0] = 7;
            Assert.AreEqual(7, v[0]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[0] = 9;
            Assert.AreEqual(9, v[0]);
            v[0] = -1;
            Assert.AreEqual(-1, v[0]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[0] = -7;
            Assert.AreEqual(-7, v[0]);
            v[1] = -8;
            Assert.AreEqual(-8, v[1]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new lvec2(9, 9);
            var vals = v.Values;
            Assert.AreEqual(9, vals[0]);
            Assert.AreEqual(9, vals[1]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, lvec2.Zero.x);
            Assert.AreEqual(0, lvec2.Zero.y);
            
            Assert.AreEqual(1, lvec2.Ones.x);
            Assert.AreEqual(1, lvec2.Ones.y);
            
            Assert.AreEqual(1, lvec2.UnitX.x);
            Assert.AreEqual(0, lvec2.UnitX.y);
            
            Assert.AreEqual(0, lvec2.UnitY.x);
            Assert.AreEqual(1, lvec2.UnitY.y);
            
            Assert.AreEqual(long.MaxValue, lvec2.MaxValue.x);
            Assert.AreEqual(long.MaxValue, lvec2.MaxValue.y);
            
            Assert.AreEqual(long.MinValue, lvec2.MinValue.x);
            Assert.AreEqual(long.MinValue, lvec2.MinValue.y);
        }

        [Test]
        public void Operators()
        {
            var v1 = new lvec2(9, -1);
            var v2 = new lvec2(9, -1);
            var v3 = new lvec2(-1, 9);
            Assert.That(v1 == new lvec2(v1));
            Assert.That(v2 == new lvec2(v2));
            Assert.That(v3 == new lvec2(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new lvec2(-2, 6);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = lvec2.Parse(s0);
            var v1 = lvec2.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = lvec2.TryParse(s0, out v0);
            var b1 = lvec2.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = lvec2.TryParse(null, out v0);
            Assert.False(b0);
            b0 = lvec2.TryParse("", out v0);
            Assert.False(b0);
            b0 = lvec2.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { lvec2.Parse(null); });
            Assert.Throws<FormatException>(() => { lvec2.Parse(""); });
            Assert.Throws<FormatException>(() => { lvec2.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = lvec2.Parse(s3, "; ", NumberStyles.Number);
            var v4 = lvec2.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = lvec2.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new lvec2(9, 6);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<lvec2>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new lvec2(-8, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec2(-4, -1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec2(6, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec2(-2, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec2(-9, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec2(5, -7);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec2(8, 7);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec2(-3, 0);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec2(-5, 2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec2(-7, 2);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new lvec2(3, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec2(-5, -1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec2(-7, 0);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec2(-4, -4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec2(-7, 4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec2(9, -3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec2(-5, 4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec2(1, -1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec2(-6, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec2(9, -7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new lvec2(-6, 2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec2(4, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec2(4, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec2(8, 4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec2(-1, -5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec2(-1, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec2(9, -7);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec2(3, 8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec2(-5, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec2(8, 5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new lvec2(-2, 6);
                var v1 = new lvec2(-6, 8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec2(-4, -9);
                var v1 = new lvec2(9, 0);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec2(6, 6);
                var v1 = new lvec2(-3, -2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec2(4, -6);
                var v1 = new lvec2(1, -9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec2(-2, 3);
                var v1 = new lvec2(1, -7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec2(-9, 0);
                var v1 = new lvec2(6, -4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec2(0, -5);
                var v1 = new lvec2(-8, 2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec2(0, 6);
                var v1 = new lvec2(7, -2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec2(5, -5);
                var v1 = new lvec2(4, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec2(-2, -1);
                var v1 = new lvec2(-3, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new lvec2(-9, -7);
                var v1 = new lvec2(-7, 6);
                var v2 = new lvec2(-1, -3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec2(4, 8);
                var v1 = new lvec2(9, -3);
                var v2 = new lvec2(1, -8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec2(-4, 4);
                var v1 = new lvec2(-8, 2);
                var v2 = new lvec2(-2, -3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec2(-1, 6);
                var v1 = new lvec2(-3, -2);
                var v2 = new lvec2(-8, -5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec2(2, -3);
                var v1 = new lvec2(-3, -7);
                var v2 = new lvec2(-4, -9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec2(-6, 0);
                var v1 = new lvec2(4, -8);
                var v2 = new lvec2(-9, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec2(-4, 4);
                var v1 = new lvec2(8, -5);
                var v2 = new lvec2(8, -1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec2(8, -7);
                var v1 = new lvec2(-7, -6);
                var v2 = new lvec2(2, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec2(-9, -1);
                var v1 = new lvec2(-2, 3);
                var v2 = new lvec2(-2, 3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec2(-3, 7);
                var v1 = new lvec2(-8, 1);
                var v2 = new lvec2(4, -8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new lvec2(-9, 3);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec2(-9, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec2(4, -8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec2(-6, -4);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec2(5, -8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec2(4, 8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec2(-9, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec2(-1, 6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec2(-5, -4);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec2(-8, -6);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new lvec2(-6, -2);
                var v1 = new lvec2(-2, 5);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec2(-6, -7);
                var v1 = new lvec2(-9, 8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec2(-2, 6);
                var v1 = new lvec2(-1, 9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec2(-1, 7);
                var v1 = new lvec2(1, -8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec2(9, 6);
                var v1 = new lvec2(9, -2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec2(7, -6);
                var v1 = new lvec2(-7, 2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec2(-9, 9);
                var v1 = new lvec2(7, -1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec2(-5, 5);
                var v1 = new lvec2(0, 9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec2(2, -9);
                var v1 = new lvec2(1, 1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec2(-6, -6);
                var v1 = new lvec2(6, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new lvec2(9, -7);
                var v1 = new lvec2(0, -5);
                var v2 = new lvec2(-4, -7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec2(8, 4);
                var v1 = new lvec2(-4, -9);
                var v2 = new lvec2(-8, -7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec2(-9, 0);
                var v1 = new lvec2(-3, -8);
                var v2 = new lvec2(-9, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec2(1, 5);
                var v1 = new lvec2(3, 7);
                var v2 = new lvec2(-1, -4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec2(-9, -7);
                var v1 = new lvec2(8, 0);
                var v2 = new lvec2(1, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec2(-4, -3);
                var v1 = new lvec2(8, -3);
                var v2 = new lvec2(0, 3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec2(-2, 7);
                var v1 = new lvec2(7, -6);
                var v2 = new lvec2(7, -8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec2(-5, -5);
                var v1 = new lvec2(-2, -4);
                var v2 = new lvec2(2, -3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec2(-5, 3);
                var v1 = new lvec2(-1, -7);
                var v2 = new lvec2(6, -3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec2(-8, 1);
                var v1 = new lvec2(5, 5);
                var v2 = new lvec2(-6, -7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new lvec2(8, -4);
                var v1 = new lvec2(-2, -6);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec2(-6, -6);
                var v1 = new lvec2(7, -4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec2(7, -3);
                var v1 = new lvec2(-7, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec2(-1, -7);
                var v1 = new lvec2(6, -9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec2(-3, 1);
                var v1 = new lvec2(-8, 8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec2(0, -3);
                var v1 = new lvec2(-7, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec2(0, 5);
                var v1 = new lvec2(-5, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec2(-8, -8);
                var v1 = new lvec2(-7, -5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec2(7, -5);
                var v1 = new lvec2(-5, -7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec2(5, 6);
                var v1 = new lvec2(-4, 6);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new lvec2(-2, -5);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec2(6, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec2(-1, 4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec2(-3, -5);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec2(-7, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec2(2, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec2(-7, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec2(0, 3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec2(-4, 4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec2(-1, -4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(95269133);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.Random(random, -1, 1);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5, 1.0);
            Assert.AreEqual(avg.y, -0.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(813837135);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.RandomUniform(random, -4, 1);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1532405137);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.Random(random, 1, 6);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3, 1.0);
            Assert.AreEqual(avg.y, 3, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(103489492);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.RandomUniform(random, -4, -2);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -3.5, 1.0);
            Assert.AreEqual(avg.y, -3.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1515964419);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.Random(random, 1, 3);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.5, 1.0);
            Assert.AreEqual(avg.y, 1.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(278502557);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.RandomPoisson(random, 0.615427033563809);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0.615427033563809, 1.0);
            Assert.AreEqual(avg.y, 0.615427033563809, 1.0);
            
            Assert.AreEqual(variance.x, 0.615427033563809, 3.0);
            Assert.AreEqual(variance.y, 0.615427033563809, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(997070559);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.RandomPoisson(random, 1.14525588399044);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.14525588399044, 1.0);
            Assert.AreEqual(avg.y, 1.14525588399044, 1.0);
            
            Assert.AreEqual(variance.x, 1.14525588399044, 3.0);
            Assert.AreEqual(variance.y, 1.14525588399044, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(988850200);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.RandomPoisson(random, 2.69768873751056);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.69768873751056, 1.0);
            Assert.AreEqual(avg.y, 2.69768873751056, 1.0);
            
            Assert.AreEqual(variance.x, 2.69768873751056, 3.0);
            Assert.AreEqual(variance.y, 2.69768873751056, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(1707418202);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.RandomPoisson(random, 1.0403901769502);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.0403901769502, 1.0);
            Assert.AreEqual(avg.y, 1.0403901769502, 1.0);
            
            Assert.AreEqual(variance.x, 1.0403901769502, 3.0);
            Assert.AreEqual(variance.y, 1.0403901769502, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(1699197843);
            var sum = new dvec2(0.0);
            var sumSqr = new dvec2(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec2.RandomPoisson(random, 2.59282303047032);
                sum += (dvec2)v;
                sumSqr += glm.Pow2((dvec2)v);
            }
            
            var avg = sum / (double)count;
            var variance =  sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.59282303047032, 1.0);
            Assert.AreEqual(avg.y, 2.59282303047032, 1.0);
            
            Assert.AreEqual(variance.x, 2.59282303047032, 3.0);
            Assert.AreEqual(variance.y, 2.59282303047032, 3.0);
        }

    }
}
