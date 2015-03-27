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
    public class IntVec4Test
    {

        [Test]
        public void Constructors()
        {
            {
                var v = new ivec4(9);
                Assert.AreEqual(9, v.x);
                Assert.AreEqual(9, v.y);
                Assert.AreEqual(9, v.z);
                Assert.AreEqual(9, v.w);
            }
            {
                var v = new ivec4(5, 4, 2, 0);
                Assert.AreEqual(5, v.x);
                Assert.AreEqual(4, v.y);
                Assert.AreEqual(2, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec2(2, -6));
                Assert.AreEqual(2, v.x);
                Assert.AreEqual(-6, v.y);
                Assert.AreEqual(0, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec3(-5, -9, 6));
                Assert.AreEqual(-5, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(6, v.z);
                Assert.AreEqual(0, v.w);
            }
            {
                var v = new ivec4(new ivec4(-1, -9, 3, -7));
                Assert.AreEqual(-1, v.x);
                Assert.AreEqual(-9, v.y);
                Assert.AreEqual(3, v.z);
                Assert.AreEqual(-7, v.w);
            }
        }

        [Test]
        public void Indexer()
        {
            var v = new ivec4(9, -7, -3, -9);
            Assert.AreEqual(9, v[0]);
            Assert.AreEqual(-7, v[1]);
            Assert.AreEqual(-3, v[2]);
            Assert.AreEqual(-9, v[3]);
            
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
            
            v[3] = 0;
            Assert.AreEqual(0, v[3]);
            v[2] = 1;
            Assert.AreEqual(1, v[2]);
            v[1] = 2;
            Assert.AreEqual(2, v[1]);
            v[3] = 3;
            Assert.AreEqual(3, v[3]);
            v[1] = 4;
            Assert.AreEqual(4, v[1]);
            v[0] = 5;
            Assert.AreEqual(5, v[0]);
            v[1] = 6;
            Assert.AreEqual(6, v[1]);
            v[2] = 7;
            Assert.AreEqual(7, v[2]);
            v[1] = 8;
            Assert.AreEqual(8, v[1]);
            v[1] = 9;
            Assert.AreEqual(9, v[1]);
            v[2] = -1;
            Assert.AreEqual(-1, v[2]);
            v[1] = -2;
            Assert.AreEqual(-2, v[1]);
            v[0] = -3;
            Assert.AreEqual(-3, v[0]);
            v[1] = -4;
            Assert.AreEqual(-4, v[1]);
            v[1] = -5;
            Assert.AreEqual(-5, v[1]);
            v[0] = -6;
            Assert.AreEqual(-6, v[0]);
            v[3] = -7;
            Assert.AreEqual(-7, v[3]);
            v[2] = -8;
            Assert.AreEqual(-8, v[2]);
            v[1] = -9;
            Assert.AreEqual(-9, v[1]);
        }

        [Test]
        public void PropertyValues()
        {
            var v = new ivec4(-7, -5, -7, -3);
            var vals = v.Values;
            Assert.AreEqual(-7, vals[0]);
            Assert.AreEqual(-5, vals[1]);
            Assert.AreEqual(-7, vals[2]);
            Assert.AreEqual(-3, vals[3]);
            Assert.That(vals.SequenceEqual(v.ToArray()));
        }

        [Test]
        public void StaticProperties()
        {
            Assert.AreEqual(0, ivec4.Zero.x);
            Assert.AreEqual(0, ivec4.Zero.y);
            Assert.AreEqual(0, ivec4.Zero.z);
            Assert.AreEqual(0, ivec4.Zero.w);
            
            Assert.AreEqual(1, ivec4.Ones.x);
            Assert.AreEqual(1, ivec4.Ones.y);
            Assert.AreEqual(1, ivec4.Ones.z);
            Assert.AreEqual(1, ivec4.Ones.w);
            
            Assert.AreEqual(1, ivec4.UnitX.x);
            Assert.AreEqual(0, ivec4.UnitX.y);
            Assert.AreEqual(0, ivec4.UnitX.z);
            Assert.AreEqual(0, ivec4.UnitX.w);
            
            Assert.AreEqual(0, ivec4.UnitY.x);
            Assert.AreEqual(1, ivec4.UnitY.y);
            Assert.AreEqual(0, ivec4.UnitY.z);
            Assert.AreEqual(0, ivec4.UnitY.w);
            
            Assert.AreEqual(0, ivec4.UnitZ.x);
            Assert.AreEqual(0, ivec4.UnitZ.y);
            Assert.AreEqual(1, ivec4.UnitZ.z);
            Assert.AreEqual(0, ivec4.UnitZ.w);
            
            Assert.AreEqual(0, ivec4.UnitW.x);
            Assert.AreEqual(0, ivec4.UnitW.y);
            Assert.AreEqual(0, ivec4.UnitW.z);
            Assert.AreEqual(1, ivec4.UnitW.w);
            
            Assert.AreEqual(int.MaxValue, ivec4.MaxValue.x);
            Assert.AreEqual(int.MaxValue, ivec4.MaxValue.y);
            Assert.AreEqual(int.MaxValue, ivec4.MaxValue.z);
            Assert.AreEqual(int.MaxValue, ivec4.MaxValue.w);
            
            Assert.AreEqual(int.MinValue, ivec4.MinValue.x);
            Assert.AreEqual(int.MinValue, ivec4.MinValue.y);
            Assert.AreEqual(int.MinValue, ivec4.MinValue.z);
            Assert.AreEqual(int.MinValue, ivec4.MinValue.w);
        }

        [Test]
        public void Operators()
        {
            var v1 = new ivec4(2, 5, 1, -8);
            var v2 = new ivec4(2, 5, 1, -8);
            var v3 = new ivec4(-8, 1, 5, 2);
            Assert.That(v1 == new ivec4(v1));
            Assert.That(v2 == new ivec4(v2));
            Assert.That(v3 == new ivec4(v3));
            Assert.That(v1 == v2);
            Assert.That(v1 != v3);
            Assert.That(v2 != v3);
        }

        [Test]
        public void StringInterop()
        {
            var v = new ivec4(8, 0, 3, -7);
            
            var s0 = v.ToString();
            var s1 = v.ToString("#");
            
            var v0 = ivec4.Parse(s0);
            var v1 = ivec4.Parse(s1, "#");
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            var b0 = ivec4.TryParse(s0, out v0);
            var b1 = ivec4.TryParse(s1, "#", out v1);
            Assert.That(b0);
            Assert.That(b1);
            Assert.AreEqual(v, v0);
            Assert.AreEqual(v, v1);
            
            b0 = ivec4.TryParse(null, out v0);
            Assert.False(b0);
            b0 = ivec4.TryParse("", out v0);
            Assert.False(b0);
            b0 = ivec4.TryParse(s0 + ", 0", out v0);
            Assert.False(b0);
            
            Assert.Throws<NullReferenceException>(() => { ivec4.Parse(null); });
            Assert.Throws<FormatException>(() => { ivec4.Parse(""); });
            Assert.Throws<FormatException>(() => { ivec4.Parse(s0 + ", 0"); });
            
            var s2 = v.ToString(";", CultureInfo.InvariantCulture);
            Assert.That(s2.Length > 0);
            
            var s3 = v.ToString("; ", "G");
            var s4 = v.ToString("; ", "G", CultureInfo.InvariantCulture);
            var v3 = ivec4.Parse(s3, "; ", NumberStyles.Number);
            var v4 = ivec4.Parse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture);
            Assert.AreEqual(v, v3);
            Assert.AreEqual(v, v4);
            
            var b4 = ivec4.TryParse(s4, "; ", NumberStyles.Number, CultureInfo.InvariantCulture, out v4);
            Assert.That(b4);
            Assert.AreEqual(v, v4);
        }

        [Test]
        public void SerializationJson()
        {
            var v0 = new ivec4(-8, -1, 6, -1);
            var s0 = JsonConvert.SerializeObject(v0);
            
            var v1 = JsonConvert.DeserializeObject<ivec4>(s0);
            var s1 = JsonConvert.SerializeObject(v1);
            
            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }

        [Test]
        public void InvariantId()
        {
            {
                var v0 = new ivec4(-1, -4, -9, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec4(-7, -5, -7, 4);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec4(6, -2, -3, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec4(9, 4, -3, 5);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec4(-2, 4, -5, -2);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec4(8, -7, -6, -6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec4(9, -1, 8, -8);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec4(5, 0, 5, -6);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec4(5, 2, -2, -9);
                Assert.AreEqual(v0, +v0);
            }
            {
                var v0 = new ivec4(1, 9, -4, -3);
                Assert.AreEqual(v0, +v0);
            }
        }

        [Test]
        public void InvariantDouble()
        {
            {
                var v0 = new ivec4(-1, 7, 8, 9);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec4(5, 5, 8, 8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec4(9, 5, 2, -8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec4(-4, 7, 1, 5);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec4(-8, 9, -2, 8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec4(-7, 5, 1, -2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec4(-5, -9, 9, 2);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec4(-4, 0, 4, -1);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec4(4, 1, 4, -8);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
            {
                var v0 = new ivec4(-5, 1, -8, -6);
                Assert.AreEqual(v0 + v0, 2 * v0);
            }
        }

        [Test]
        public void InvariantTriple()
        {
            {
                var v0 = new ivec4(3, 7, -8, 0);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec4(-3, 5, 3, -9);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec4(3, -5, 3, 1);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec4(9, 0, 3, 2);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec4(-7, -1, -1, -6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec4(6, -6, -9, -5);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec4(-4, -9, 4, -4);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec4(-2, 0, -4, 6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec4(-2, 2, 6, -8);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
            {
                var v0 = new ivec4(3, 4, -1, 6);
                Assert.AreEqual(v0 + v0 + v0, 3 * v0);
            }
        }

        [Test]
        public void InvariantCommutative()
        {
            {
                var v0 = new ivec4(-2, -3, 4, 2);
                var v1 = new ivec4(2, 0, 4, 0);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec4(7, -6, 5, -4);
                var v1 = new ivec4(-4, -4, -1, -5);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec4(8, 5, -2, 0);
                var v1 = new ivec4(2, 2, -1, -3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec4(-3, 1, -2, -3);
                var v1 = new ivec4(-2, 4, -9, -4);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec4(6, 6, 7, 0);
                var v1 = new ivec4(-4, -5, 5, -6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec4(-8, -4, 8, -1);
                var v1 = new ivec4(-7, -5, -4, 6);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec4(-5, -8, -6, 6);
                var v1 = new ivec4(0, 2, -9, 9);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec4(1, -2, 9, 1);
                var v1 = new ivec4(8, -1, 8, 2);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec4(-7, -2, 6, 6);
                var v1 = new ivec4(5, -1, 1, -3);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
            {
                var v0 = new ivec4(0, -6, 1, 7);
                var v1 = new ivec4(-3, 0, -5, -7);
                Assert.AreEqual(v0 * v1, v1 * v0);
            }
        }

        [Test]
        public void InvariantAssociative()
        {
            {
                var v0 = new ivec4(6, 1, -2, 5);
                var v1 = new ivec4(-9, -7, -9, 3);
                var v2 = new ivec4(2, -4, -4, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec4(-3, 6, -9, -6);
                var v1 = new ivec4(-5, 9, -3, -7);
                var v2 = new ivec4(-7, -2, -7, -6);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec4(8, 4, -2, 8);
                var v1 = new ivec4(0, 5, -3, 0);
                var v2 = new ivec4(6, -2, 8, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec4(9, 2, 1, 7);
                var v1 = new ivec4(7, -1, 9, -8);
                var v2 = new ivec4(8, -8, -3, -2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec4(9, -5, -5, 2);
                var v1 = new ivec4(-7, -5, 3, -4);
                var v2 = new ivec4(4, -5, -7, -5);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec4(5, 9, 3, -6);
                var v1 = new ivec4(0, -3, -7, 0);
                var v2 = new ivec4(-8, 8, 6, -2);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec4(8, 5, 8, 6);
                var v1 = new ivec4(2, -8, 7, 9);
                var v2 = new ivec4(-1, 0, -9, 4);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec4(-1, -1, 3, -2);
                var v1 = new ivec4(7, -4, 5, -4);
                var v2 = new ivec4(5, 5, 2, -7);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec4(6, -4, -7, -5);
                var v1 = new ivec4(0, -3, -3, 1);
                var v2 = new ivec4(8, 2, -3, -1);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
            {
                var v0 = new ivec4(5, -7, -2, 5);
                var v1 = new ivec4(7, 6, 3, 5);
                var v2 = new ivec4(-1, -8, 4, 9);
                Assert.AreEqual(v0 * (v1 + v2), v0 * v1 + v0 * v2);
            }
        }

        [Test]
        public void InvariantIdNeg()
        {
            {
                var v0 = new ivec4(6, 7, -4, 7);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec4(-3, 2, -1, 8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec4(-8, -9, -7, -4);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec4(-8, -3, -2, 0);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec4(-7, -1, 0, 6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec4(-3, 5, -2, -1);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec4(-4, 3, 7, 2);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec4(-2, -3, 8, 6);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec4(2, 2, -4, 8);
                Assert.AreEqual(v0, -(-v0));
            }
            {
                var v0 = new ivec4(-6, 4, -8, -6);
                Assert.AreEqual(v0, -(-v0));
            }
        }

        [Test]
        public void InvariantCommutativeNeg()
        {
            {
                var v0 = new ivec4(3, -6, 6, 4);
                var v1 = new ivec4(4, 1, -4, 4);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec4(4, 6, 3, -5);
                var v1 = new ivec4(9, -1, 1, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec4(-2, 3, -2, 2);
                var v1 = new ivec4(-2, -6, -6, 2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec4(5, 1, 7, 3);
                var v1 = new ivec4(1, -3, -7, 9);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec4(4, -3, -1, -8);
                var v1 = new ivec4(-2, -4, -8, -2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec4(-4, -1, 3, 0);
                var v1 = new ivec4(-7, -3, -2, 3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec4(1, -5, -6, -7);
                var v1 = new ivec4(9, 4, -1, 6);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec4(0, 3, -9, 3);
                var v1 = new ivec4(-4, -1, 2, -2);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec4(9, -4, -1, -6);
                var v1 = new ivec4(-9, 3, 0, -8);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
            {
                var v0 = new ivec4(4, 0, 7, 0);
                var v1 = new ivec4(-2, -5, 5, -3);
                Assert.AreEqual(v0 - v1, -(v1 - v0));
            }
        }

        [Test]
        public void InvariantAssociativeNeg()
        {
            {
                var v0 = new ivec4(7, -2, -3, -4);
                var v1 = new ivec4(0, 4, 0, 8);
                var v2 = new ivec4(2, 6, -5, -8);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec4(-2, 2, -4, 2);
                var v1 = new ivec4(-5, 0, 8, -2);
                var v2 = new ivec4(-8, -6, -4, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec4(-8, 0, 1, 4);
                var v1 = new ivec4(-8, -6, 4, -6);
                var v2 = new ivec4(1, 0, 8, 4);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec4(-7, -3, 4, -7);
                var v1 = new ivec4(1, 0, -4, 0);
                var v2 = new ivec4(-5, -4, -4, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec4(5, -4, -3, 8);
                var v1 = new ivec4(-1, 5, 8, -1);
                var v2 = new ivec4(-8, -2, -5, -9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec4(2, -6, 9, 5);
                var v1 = new ivec4(2, -9, -6, -2);
                var v2 = new ivec4(-3, 8, 4, 1);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec4(-5, -1, -1, -8);
                var v1 = new ivec4(1, -3, 5, 3);
                var v2 = new ivec4(5, -5, -9, 3);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec4(3, -5, 4, -6);
                var v1 = new ivec4(-2, -7, 6, 5);
                var v2 = new ivec4(-7, 5, -4, 5);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec4(9, 7, -8, -6);
                var v1 = new ivec4(-8, 2, -3, -6);
                var v2 = new ivec4(9, -1, -3, -9);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
            {
                var v0 = new ivec4(-4, -1, 9, 5);
                var v1 = new ivec4(5, -1, -3, 7);
                var v2 = new ivec4(-6, 6, 2, 6);
                Assert.AreEqual(v0 * (v1 - v2), v0 * v1 - v0 * v2);
            }
        }

        [Test]
        public void TriangleInequality()
        {
            {
                var v0 = new ivec4(-4, 7, 2, 7);
                var v1 = new ivec4(5, 4, 9, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec4(-2, 0, 1, -2);
                var v1 = new ivec4(2, -1, 5, -5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec4(2, 7, -7, 1);
                var v1 = new ivec4(-6, -6, 9, -1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec4(8, 6, 4, 0);
                var v1 = new ivec4(0, 8, -8, -5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec4(-3, -3, -6, -8);
                var v1 = new ivec4(2, -2, 1, -5);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec4(-3, -5, 9, 7);
                var v1 = new ivec4(-6, 4, -5, 1);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec4(-3, 0, -3, -1);
                var v1 = new ivec4(-4, -5, -2, -8);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec4(-7, -2, -8, -9);
                var v1 = new ivec4(-9, 9, 0, 2);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec4(2, 6, -8, 9);
                var v1 = new ivec4(-5, 7, -3, 9);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
            {
                var v0 = new ivec4(5, 2, 8, 1);
                var v1 = new ivec4(6, 2, -4, 4);
                Assert.GreaterOrEqual(v0.NormMax + v1.NormMax, (v0 + v1).NormMax);
            }
        }

        [Test]
        public void InvariantNorm()
        {
            {
                var v0 = new ivec4(4, -1, -2, -1);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec4(2, 0, -8, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec4(4, 8, -1, -3);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec4(-8, 6, 0, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec4(-1, 7, 9, 2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec4(4, 2, -3, 6);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec4(9, 4, -2, 8);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec4(-8, 5, -2, -2);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec4(-5, 1, -5, -9);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
            {
                var v0 = new ivec4(-1, -4, -7, -7);
                Assert.LessOrEqual(v0.NormMax, v0.Norm);
            }
        }

        [Test]
        public void RandomUniform0()
        {
            var random = new Random(889490485);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.Random(random, 1, 4);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 2, 1.0);
            Assert.AreEqual(avg.y, 2, 1.0);
            Assert.AreEqual(avg.z, 2, 1.0);
            Assert.AreEqual(avg.w, 2, 1.0);
            
            Assert.AreEqual(variance.x, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.y, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.z, 0.666666666666667, 3.0);
            Assert.AreEqual(variance.w, 0.666666666666667, 3.0);
        }

        [Test]
        public void RandomUniform1()
        {
            var random = new Random(1608058487);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.RandomUniform(random, -2, 2);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, -0.5, 1.0);
            Assert.AreEqual(avg.y, -0.5, 1.0);
            Assert.AreEqual(avg.z, -0.5, 1.0);
            Assert.AreEqual(avg.w, -0.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform2()
        {
            var random = new Random(179142842);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.Random(random, 3, 7);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 4.5, 1.0);
            Assert.AreEqual(avg.y, 4.5, 1.0);
            Assert.AreEqual(avg.z, 4.5, 1.0);
            Assert.AreEqual(avg.w, 4.5, 1.0);
            
            Assert.AreEqual(variance.x, 1.25, 3.0);
            Assert.AreEqual(variance.y, 1.25, 3.0);
            Assert.AreEqual(variance.z, 1.25, 3.0);
            Assert.AreEqual(variance.w, 1.25, 3.0);
        }

        [Test]
        public void RandomUniform3()
        {
            var random = new Random(897710844);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.RandomUniform(random, -2, 3);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 0, 1.0);
            Assert.AreEqual(avg.y, 0, 1.0);
            Assert.AreEqual(avg.z, 0, 1.0);
            Assert.AreEqual(avg.w, 0, 1.0);
            
            Assert.AreEqual(variance.x, 2, 3.0);
            Assert.AreEqual(variance.y, 2, 3.0);
            Assert.AreEqual(variance.z, 2, 3.0);
            Assert.AreEqual(variance.w, 2, 3.0);
        }

        [Test]
        public void RandomUniform4()
        {
            var random = new Random(162702124);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.Random(random, 4, 9);
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
        public void RandomPoisson0()
        {
            var random = new Random(1631764852);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.RandomPoisson(random, 1.34020516501749);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.34020516501749, 1.0);
            Assert.AreEqual(avg.y, 1.34020516501749, 1.0);
            Assert.AreEqual(avg.z, 1.34020516501749, 1.0);
            Assert.AreEqual(avg.w, 1.34020516501749, 1.0);
            
            Assert.AreEqual(variance.x, 1.34020516501749, 3.0);
            Assert.AreEqual(variance.y, 1.34020516501749, 3.0);
            Assert.AreEqual(variance.z, 1.34020516501749, 3.0);
            Assert.AreEqual(variance.w, 1.34020516501749, 3.0);
        }

        [Test]
        public void RandomPoisson1()
        {
            var random = new Random(202849207);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.RandomPoisson(random, 3.42047775253676);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.42047775253676, 1.0);
            Assert.AreEqual(avg.y, 3.42047775253676, 1.0);
            Assert.AreEqual(avg.z, 3.42047775253676, 1.0);
            Assert.AreEqual(avg.w, 3.42047775253676, 1.0);
            
            Assert.AreEqual(variance.x, 3.42047775253676, 3.0);
            Assert.AreEqual(variance.y, 3.42047775253676, 3.0);
            Assert.AreEqual(variance.z, 3.42047775253676, 3.0);
            Assert.AreEqual(variance.w, 3.42047775253676, 3.0);
        }

        [Test]
        public void RandomPoisson2()
        {
            var random = new Random(194628848);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.RandomPoisson(random, 1.97291060605688);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.97291060605688, 1.0);
            Assert.AreEqual(avg.y, 1.97291060605688, 1.0);
            Assert.AreEqual(avg.z, 1.97291060605688, 1.0);
            Assert.AreEqual(avg.w, 1.97291060605688, 1.0);
            
            Assert.AreEqual(variance.x, 1.97291060605688, 3.0);
            Assert.AreEqual(variance.y, 1.97291060605688, 3.0);
            Assert.AreEqual(variance.z, 1.97291060605688, 3.0);
            Assert.AreEqual(variance.w, 1.97291060605688, 3.0);
        }

        [Test]
        public void RandomPoisson3()
        {
            var random = new Random(913196850);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.RandomPoisson(random, 3.31561204549652);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 3.31561204549652, 1.0);
            Assert.AreEqual(avg.y, 3.31561204549652, 1.0);
            Assert.AreEqual(avg.z, 3.31561204549652, 1.0);
            Assert.AreEqual(avg.w, 3.31561204549652, 1.0);
            
            Assert.AreEqual(variance.x, 3.31561204549652, 3.0);
            Assert.AreEqual(variance.y, 3.31561204549652, 3.0);
            Assert.AreEqual(variance.z, 3.31561204549652, 3.0);
            Assert.AreEqual(variance.w, 3.31561204549652, 3.0);
        }

        [Test]
        public void RandomPoisson4()
        {
            var random = new Random(904976491);
            var sum = new dvec4(0.0);
            var sumSqr = new dvec4(0.0);
            
            const int count = 50000;
            for (var _ = 0; _ < count; ++_)
            {
                var v = ivec4.RandomPoisson(random, 1.86804489901664);
                sum += (dvec4)v;
                sumSqr += glm.Pow2((dvec4)v);
            }
            
            var avg = sum / (double)count;
            var variance = sumSqr / (double)count - avg * avg;
            
            Assert.AreEqual(avg.x, 1.86804489901664, 1.0);
            Assert.AreEqual(avg.y, 1.86804489901664, 1.0);
            Assert.AreEqual(avg.z, 1.86804489901664, 1.0);
            Assert.AreEqual(avg.w, 1.86804489901664, 1.0);
            
            Assert.AreEqual(variance.x, 1.86804489901664, 3.0);
            Assert.AreEqual(variance.y, 1.86804489901664, 3.0);
            Assert.AreEqual(variance.z, 1.86804489901664, 3.0);
            Assert.AreEqual(variance.w, 1.86804489901664, 3.0);
        }

    }
}
