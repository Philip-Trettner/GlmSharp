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
    public class LongVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new lvec4(3);
                Assert.AreEqual(3, v.x);
                Assert.AreEqual(3, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(3, v.w);
            }
            {
                var v = new lvec4(6, -3, 5, 4);
                Assert.AreEqual(6, v.x);
                Assert.AreEqual(-3, v.y);
                Assert.AreEqual(5, v.z);
                Assert.AreEqual(4, v.w);
            }
            {
                var v = new lvec4(new lvec2(-7, 8));
                Assert.AreEqual(-7, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec3(2, -9, 8));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(8, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new lvec4(new lvec4(9, 8, -6, -3));
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(8, v.y);
                Assert.AreEqual(-6, v.z);
                Assert.AreEqual(-3, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new lvec4(4, -5, 5, 8);
            Assert.AreEqual(4, v[0]);
            Assert.AreEqual(-5, v[1]);
            Assert.AreEqual(5, v[2]);
            Assert.AreEqual(8, v[3]);
            
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-2147483648]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-2147483648] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[-1]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[-1] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[4]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[4] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[2147483647]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[2147483647] = 0; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { var s = v[5]; } );
            Assert.Throws<ArgumentOutOfRangeException>(() => { v[5] = 0; } );
            
            v[1] = 0;
            Assert.AreEqual(0, v[1]);
            v[1] = 1;
            Assert.AreEqual(1, v[1]);
            v[3] = 2;
            Assert.AreEqual(2, v[3]);
            v[0] = 3;
            Assert.AreEqual(3, v[0]);
            v[2] = 4;
            Assert.AreEqual(4, v[2]);
            v[2] = 5;
            Assert.AreEqual(5, v[2]);
            v[3] = 6;
            Assert.AreEqual(6, v[3]);
            v[3] = 7;
            Assert.AreEqual(7, v[3]);
            v[2] = 8;
            Assert.AreEqual(8, v[2]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[0] = -2;
            Assert.AreEqual(-2, v[0]);
            v[1] = -3;
            Assert.AreEqual(-3, v[1]);
            v[2] = -4;
            Assert.AreEqual(-4, v[2]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[1] = -7;
            Assert.AreEqual(-7, v[1]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[3] = -9;
            Assert.AreEqual(-9, v[3]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new lvec4(-7, -7, 1, -5);
            var vals = v.Values;
            Assert.AreEqual(-7, vals[0]);
            Assert.AreEqual(-7, vals[1]);
            Assert.AreEqual(1, vals[2]);
            Assert.AreEqual(-5, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, lvec4.Zero.x);
            Assert.AreEqual(0, lvec4.Zero.y);
            Assert.AreEqual(0, lvec4.Zero.z);
            Assert.AreEqual(0, lvec4.Zero.w);
            
            Assert.AreEqual(1, lvec4.Ones.x);
            Assert.AreEqual(1, lvec4.Ones.y);
            Assert.AreEqual(1, lvec4.Ones.z);
            Assert.AreEqual(1, lvec4.Ones.w);
            
            Assert.AreEqual(1, lvec4.UnitX.x);
            Assert.AreEqual(0, lvec4.UnitX.y);
            Assert.AreEqual(0, lvec4.UnitX.z);
            Assert.AreEqual(0, lvec4.UnitX.w);
            
            Assert.AreEqual(0, lvec4.UnitY.x);
            Assert.AreEqual(1, lvec4.UnitY.y);
            Assert.AreEqual(0, lvec4.UnitY.z);
            Assert.AreEqual(0, lvec4.UnitY.w);
            
            Assert.AreEqual(0, lvec4.UnitZ.x);
            Assert.AreEqual(0, lvec4.UnitZ.y);
            Assert.AreEqual(1, lvec4.UnitZ.z);
            Assert.AreEqual(0, lvec4.UnitZ.w);
            
            Assert.AreEqual(0, lvec4.UnitW.x);
            Assert.AreEqual(0, lvec4.UnitW.y);
            Assert.AreEqual(0, lvec4.UnitW.z);
            Assert.AreEqual(1, lvec4.UnitW.w);
            
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.x);
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.y);
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.z);
            Assert.AreEqual(long.MaxValue, lvec4.MaxValue.w);
            
            Assert.AreEqual(long.MinValue, lvec4.MinValue.x);
            Assert.AreEqual(long.MinValue, lvec4.MinValue.y);
            Assert.AreEqual(long.MinValue, lvec4.MinValue.z);
            Assert.AreEqual(long.MinValue, lvec4.MinValue.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new lvec4(1, -8, 9, 5);
            var v2 = new lvec4(1, -8, 9, 5);
            var v3 = new lvec4(5, 9, -8, 1);
            Assert.That(v1 == new lvec4(v1));
            Assert.That(v2 == new lvec4(v2));
            Assert.That(v3 == new lvec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new lvec4(-5, 3, 7, 6);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = lvec4.Parse(s0);
            var v1 = lvec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = lvec4.TryParse(s0, out v0);
            var b1 = lvec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = lvec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = lvec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = lvec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { lvec4.Parse(null); });
            Assert.Throws<FormatException>(() => { lvec4.Parse(""); });
            Assert.Throws<FormatException>(() => { lvec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = lvec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = lvec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = lvec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new lvec4(-6, 1, -1, -7);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<lvec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new lvec4(-3, 9, -2, -3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec4(-1, 3, 7, -3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec4(-6, 8, -7, 8);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec4(7, 2, -1, -1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec4(4, 0, 7, 1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec4(-4, -4, 5, 3);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec4(6, -9, 4, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec4(-9, -3, -4, 6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec4(7, 3, -5, 1);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new lvec4(9, -7, -4, -7);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new lvec4(3, 4, 8, -8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec4(0, -5, -7, 7);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec4(9, 9, -9, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec4(5, 2, 0, 4);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec4(9, 8, 0, -8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec4(9, 0, 1, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec4(7, -7, 4, -1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec4(-4, 4, 5, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec4(1, -1, -3, 3);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new lvec4(7, 8, 7, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new lvec4(-1, 4, -9, 7);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec4(-3, -4, 1, -8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec4(-6, 0, -8, 5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec4(-1, 9, -9, 6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec4(-1, 7, 1, -1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec4(-9, 9, 3, 0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec4(8, -6, 9, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec4(-6, 4, -6, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec4(-4, 9, -1, 2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new lvec4(0, 5, -5, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new lvec4(0, 9, -3, 5);
                var v1 = new lvec4(7, 1, 5, -1);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec4(0, -7, -4, 6);
                var v1 = new lvec4(5, -6, -4, -4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec4(-3, 2, 6, 4);
                var v1 = new lvec4(-8, 4, -9, -2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec4(-8, -1, 7, 7);
                var v1 = new lvec4(4, 4, 0, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec4(-5, -2, -6, 1);
                var v1 = new lvec4(7, 7, -3, 3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec4(-8, 0, -3, -4);
                var v1 = new lvec4(5, 9, -6, -9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec4(-1, -8, -1, -8);
                var v1 = new lvec4(3, 1, 7, -6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec4(-1, 1, 7, -7);
                var v1 = new lvec4(-4, -8, 5, -6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec4(-7, 8, -1, -3);
                var v1 = new lvec4(0, -2, 5, 5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new lvec4(8, 3, 5, -8);
                var v1 = new lvec4(-1, 4, 6, 8);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new lvec4(7, -1, 5, 2);
                var v1 = new lvec4(6, 2, 5, -4);
                var v2 = new lvec4(-7, 1, 7, 3);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec4(7, 3, 3, -3);
                var v1 = new lvec4(-4, 8, -9, 9);
                var v2 = new lvec4(8, -4, 6, -9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec4(-4, -2, 2, 4);
                var v1 = new lvec4(8, -9, -7, 2);
                var v2 = new lvec4(-9, 0, 8, -1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec4(-4, 7, 5, 0);
                var v1 = new lvec4(-5, 3, 3, 7);
                var v2 = new lvec4(-3, -2, 8, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec4(-8, -1, 0, -6);
                var v1 = new lvec4(8, 9, 0, -3);
                var v2 = new lvec4(4, 6, 7, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec4(-9, 0, 4, -8);
                var v1 = new lvec4(4, 4, 4, 6);
                var v2 = new lvec4(-4, -3, -8, 5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec4(3, -8, -5, 5);
                var v1 = new lvec4(9, -8, 6, 2);
                var v2 = new lvec4(3, 7, 6, -8);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec4(-8, 1, -4, 8);
                var v1 = new lvec4(0, -5, 5, 7);
                var v2 = new lvec4(-9, -1, 0, -4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec4(-8, 5, 3, 7);
                var v1 = new lvec4(7, 2, -9, 5);
                var v2 = new lvec4(-2, -4, -3, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new lvec4(-5, -5, 3, 6);
                var v1 = new lvec4(-9, 5, -1, -2);
                var v2 = new lvec4(-4, 6, -9, 2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new lvec4(7, 4, 3, 0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec4(-2, -7, -4, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec4(0, -6, 4, -3);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec4(1, -7, -1, 8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec4(-1, 7, -2, 0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec4(-4, 0, -1, 4);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec4(8, -3, 6, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec4(-6, -2, 1, -6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec4(3, -1, 3, -2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new lvec4(6, 5, 7, -2);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new lvec4(-1, -6, -2, 3);
                var v1 = new lvec4(0, -8, -1, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec4(-5, 8, -8, -3);
                var v1 = new lvec4(-1, 0, 0, -7);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec4(-6, -5, 0, 4);
                var v1 = new lvec4(-4, 9, 7, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec4(-7, -5, 6, -1);
                var v1 = new lvec4(7, -2, -3, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec4(1, -9, 6, 3);
                var v1 = new lvec4(-2, -5, 7, -6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec4(7, 2, 9, 5);
                var v1 = new lvec4(4, -8, 9, 2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec4(6, -1, -8, 1);
                var v1 = new lvec4(-5, 0, -3, 1);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec4(8, -8, 5, 5);
                var v1 = new lvec4(-2, 0, 5, 2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec4(-5, 4, -1, -1);
                var v1 = new lvec4(-3, -7, 4, 0);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new lvec4(7, 3, -6, -2);
                var v1 = new lvec4(-9, 1, 8, -9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new lvec4(6, 0, 4, -4);
                var v1 = new lvec4(5, -5, 5, 8);
                var v2 = new lvec4(-7, 8, 6, 9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec4(7, 8, 8, 7);
                var v1 = new lvec4(-4, -8, 3, -4);
                var v2 = new lvec4(7, 9, 9, -4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec4(4, -6, -3, 9);
                var v1 = new lvec4(-1, 8, 5, 6);
                var v2 = new lvec4(3, -2, 8, -6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec4(6, -7, 1, -1);
                var v1 = new lvec4(0, -4, -9, 5);
                var v2 = new lvec4(5, -6, 7, -9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec4(2, -2, 2, 9);
                var v1 = new lvec4(-4, -9, -5, -6);
                var v2 = new lvec4(-1, 9, 8, 9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec4(2, -5, -8, 7);
                var v1 = new lvec4(2, -9, 5, -5);
                var v2 = new lvec4(-9, -2, 0, -7);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec4(-7, -3, -4, -4);
                var v1 = new lvec4(9, 3, 8, 8);
                var v2 = new lvec4(7, -3, 6, -9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec4(5, -6, -3, 3);
                var v1 = new lvec4(-6, -2, 4, -6);
                var v2 = new lvec4(7, -2, 8, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec4(-5, -1, 2, 5);
                var v1 = new lvec4(9, -2, 0, -1);
                var v2 = new lvec4(-1, 5, -2, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new lvec4(5, 1, 6, 6);
                var v1 = new lvec4(1, 0, 1, 8);
                var v2 = new lvec4(7, -9, 2, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new lvec4(5, 3, -3, 3);
                var v1 = new lvec4(9, -7, -1, 5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec4(5, -6, -5, -7);
                var v1 = new lvec4(-7, -6, 7, 5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec4(-9, -3, -9, -9);
                var v1 = new lvec4(-1, -9, -5, 9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec4(0, 9, -6, 8);
                var v1 = new lvec4(0, 0, -4, 0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec4(9, -3, -2, -3);
                var v1 = new lvec4(-5, -9, 4, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec4(-8, 1, -2, -3);
                var v1 = new lvec4(3, -2, 3, -5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec4(0, 6, -4, 8);
                var v1 = new lvec4(8, -8, -4, 5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec4(7, 3, 3, 0);
                var v1 = new lvec4(1, 2, 4, 5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec4(2, -5, 6, 4);
                var v1 = new lvec4(3, -4, 9, 0);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new lvec4(8, -7, 1, 9);
                var v1 = new lvec4(7, 1, 5, 7);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new lvec4(-9, -4, -9, -4);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec4(5, -9, 6, -7);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec4(-8, -2, 0, 6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec4(-9, 0, 3, 7);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec4(5, -8, -3, 9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec4(-8, 7, 9, -3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec4(5, 5, 1, -6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec4(7, 7, 6, -2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec4(-8, 4, -2, 2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new lvec4(0, -3, -1, -3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(676692273);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.Random(random, 3, 6);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            Assert.AreEqual(avg.z, 4, 1.0);
            Assert.AreEqual(avg.w, 4, 1.0);
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.z, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.w, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(2105607918);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.RandomUniform(random, -3, 0);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2, 1.0);
            Assert.AreEqual(avg.y, -2, 1.0);
            Assert.AreEqual(avg.z, -2, 1.0);
            Assert.AreEqual(avg.w, -2, 1.0);
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.z, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.w, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(1387039916);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.Random(random, 2, 4);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.5, 1.0);
            Assert.AreEqual(avg.y, 2.5, 1.0);
            Assert.AreEqual(avg.z, 2.5, 1.0);
            Assert.AreEqual(avg.w, 2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
            Assert.AreEqual(variance.w, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(668471914);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.RandomUniform(random, -3, -1);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -2.5, 1.0);
            Assert.AreEqual(avg.y, -2.5, 1.0);
            Assert.AreEqual(avg.z, -2.5, 1.0);
            Assert.AreEqual(avg.w, -2.5, 1.0);
            
            Assert.AreEqual(variance.x, 0.25, 3.0);
            Assert.AreEqual(variance.y, 0.25, 3.0);
            Assert.AreEqual(variance.z, 0.25, 3.0);
            Assert.AreEqual(variance.w, 0.25, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(1403480634);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.Random(random, 2, 7);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4, 1.0);
            Assert.AreEqual(avg.y, 4, 1.0);
            Assert.AreEqual(avg.z, 4, 1.0);
            Assert.AreEqual(avg.w, 4, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
        }

        [Test]
        public void RandomPoisson0()
        {
            var random = new Random(989266918);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.RandomPoisson(random, 1.55749015186796);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.55749015186796, 1.0);
            Assert.AreEqual(avg.y, 1.55749015186796, 1.0);
            Assert.AreEqual(avg.z, 1.55749015186796, 1.0);
            Assert.AreEqual(avg.w, 1.55749015186796, 1.0);
            
            Assert.AreEqual(variance.x, 1.55749015186796, 3.0);
            Assert.AreEqual(variance.y, 1.55749015186796, 3.0);
            Assert.AreEqual(variance.z, 1.55749015186796, 3.0);
            Assert.AreEqual(variance.w, 1.55749015186796, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(270698916);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.RandomPoisson(random, 1.25024295120977);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.25024295120977, 1.0);
            Assert.AreEqual(avg.y, 1.25024295120977, 1.0);
            Assert.AreEqual(avg.z, 1.25024295120977, 1.0);
            Assert.AreEqual(avg.w, 1.25024295120977, 1.0);
            
            Assert.AreEqual(variance.x, 1.25024295120977, 3.0);
            Assert.AreEqual(variance.y, 1.25024295120977, 3.0);
            Assert.AreEqual(variance.z, 1.25024295120977, 3.0);
            Assert.AreEqual(variance.w, 1.25024295120977, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(278919275);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.RandomPoisson(random, 2.69781009768965);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.69781009768965, 1.0);
            Assert.AreEqual(avg.y, 2.69781009768965, 1.0);
            Assert.AreEqual(avg.z, 2.69781009768965, 1.0);
            Assert.AreEqual(avg.w, 2.69781009768965, 1.0);
            
            Assert.AreEqual(variance.x, 2.69781009768965, 3.0);
            Assert.AreEqual(variance.y, 2.69781009768965, 3.0);
            Assert.AreEqual(variance.z, 2.69781009768965, 3.0);
            Assert.AreEqual(variance.w, 2.69781009768965, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(1707834920);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.RandomPoisson(random, 1.35510865825001);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.35510865825001, 1.0);
            Assert.AreEqual(avg.y, 1.35510865825001, 1.0);
            Assert.AreEqual(avg.z, 1.35510865825001, 1.0);
            Assert.AreEqual(avg.w, 1.35510865825001, 1.0);
            
            Assert.AreEqual(variance.x, 1.35510865825001, 3.0);
            Assert.AreEqual(variance.y, 1.35510865825001, 3.0);
            Assert.AreEqual(variance.z, 1.35510865825001, 3.0);
            Assert.AreEqual(variance.w, 1.35510865825001, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(1716055279);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = lvec4.RandomPoisson(random, 2.80267580472989);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2.80267580472989, 1.0);
            Assert.AreEqual(avg.y, 2.80267580472989, 1.0);
            Assert.AreEqual(avg.z, 2.80267580472989, 1.0);
            Assert.AreEqual(avg.w, 2.80267580472989, 1.0);
            
            Assert.AreEqual(variance.x, 2.80267580472989, 3.0);
            Assert.AreEqual(variance.y, 2.80267580472989, 3.0);
            Assert.AreEqual(variance.z, 2.80267580472989, 3.0);
            Assert.AreEqual(variance.w, 2.80267580472989, 3.0);
        }

    }
}
