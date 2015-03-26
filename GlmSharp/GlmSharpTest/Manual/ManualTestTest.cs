using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharp;
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
            
        }
    }
}
