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
        }
    }
}
