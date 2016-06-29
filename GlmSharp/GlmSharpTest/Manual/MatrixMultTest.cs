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
    public class MatrixMultTest
    {
        [Test]
        public void Simple()
        {
            /*
             * 1 2
             * 3 4
             */
            var m1 = new mat2(1, 3, 2, 4);

            /*
             * 5 7
             * 6 8
             */
            var m2 = new mat2(5, 6, 7, 8);

            /*
             * 1 2 * 5 7 = 17 23
             * 3 4   6 8   39 53
             */
            var r = m1 * m2;
            Assert.AreEqual(r.m00, 17);
            Assert.AreEqual(r.m01, 39);
            Assert.AreEqual(r.m10, 23);
            Assert.AreEqual(r.m11, 53);
        }
    }
}
