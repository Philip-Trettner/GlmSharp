using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GlmSharp;

namespace GlmSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            vec4 v = new vec4();
            vec3 vv = v.swizzle.zxy;
            vv = vv.swizzle.bgr;
            ivec2 iv = (ivec2) v;
        }
    }
}
