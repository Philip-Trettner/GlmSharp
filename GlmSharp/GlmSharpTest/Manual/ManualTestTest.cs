using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using GlmSharp;
using Newtonsoft.Json;
using NUnit.Framework;

namespace GlmSharpTest.Manual
{
    [TestFixture]
    public class ManualTestTest
    {
        [Test]
        public void Test()
        {
            var v = new vec2(3);
            Assert.AreEqual(3, v.x);
            Assert.AreEqual(3, v.y);

            var v2 = glm.swizzle(v).rgrg;
            Assert.AreEqual(3, v2.x);
            Assert.AreEqual(3, v2.y);
            Assert.AreEqual(3, v2.z);
            Assert.AreEqual(3, v2.w);

            v.y += glm.Smoothstep(0, 1, v.x);

            v2.yw = new vec2(6);
            Assert.AreEqual(3, v2.x);
            Assert.AreEqual(6, v2.y);
            Assert.AreEqual(3, v2.z);
            Assert.AreEqual(6, v2.w);

            //Assert.AreEqual(1.0, 2.0, 0.1);
        }

        [Test]
        public void HalfTypeZero()
        {
            var v0 = new Half(-5.5);
            var v1 = new Half(0.5);
            var v2 = new Half(0.5);
            var a = v0 * (v1 - v2);
            var b = v0 * v1 - v0 * v2;

            /*var f0 = new[] { -5.5f };
            var f1 = new[] { 0.5f };
            var f2 = new[] { 0.5f };
            var fa = f0[0] * (f1[0] - f2[0]);
            var fb = f0[0] * f1[0] - f0[0] * f2[0];

            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(fa)));
            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(fb)));
            Console.WriteLine(BitConverter.ToString(BitConverter.GetBytes(-fb)));

            Console.WriteLine(Half.GetBits(new Half(-5.5) * new Half(0.0)));
            Console.WriteLine(Half.GetBits(new Half(-5.5) * new Half(-0.0)));
            Console.WriteLine(Half.GetBits(new Half(5.5) * new Half(0.0)));
            Console.WriteLine(Half.GetBits(new Half(5.5) * new Half(-0.0)));
            Console.WriteLine(Half.GetBits(a));
            Console.WriteLine(Half.GetBits(b));*/
            Assert.AreEqual(a, b);
        }

        [Test]
        public void HalfSerializationJson()
        {
            var h = new Half(2.2);
            var sh = JsonConvert.SerializeObject(h);
            Console.WriteLine(sh);

            var v0 = new hvec3(new Half(-2), new Half(-4), new Half(3));
            var s0 = JsonConvert.SerializeObject(v0);

            var v1 = JsonConvert.DeserializeObject<hvec3>(s0);
            var s1 = JsonConvert.SerializeObject(v1);

            Assert.AreEqual(v0, v1);
            Assert.AreEqual(s0, s1);
        }
    }
}
