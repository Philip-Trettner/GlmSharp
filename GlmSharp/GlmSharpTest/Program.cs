using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using GlmSharp;
using NUnit.Framework;

namespace GlmSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            vec4 v = new vec4();
            vec3 vv = v.swizzle.zxy;
            vv = vv.swizzle.bgr;
            ivec2 iv = (ivec2)v;

            iv += 2;
            iv /= 3;
            iv *= iv;
            iv = 2 + iv;

            vec3 g = vec3.UnitY;
            g = g.Normalized * 3;

            cvec3 cg = g;

            Complex c = 1.0;
            // FIXME: Upcasting
            //vec2 fv = iv * 1f;
            //dvec2 dv = iv * 1.0;
            //dv += c.Imaginary;
            
            //cvec4 cv = v * c;
            //c.Magnitude
            cvec4 cv = cvec4.ImaginaryOnes;

            dvec4 acv = cvec4.Abs(cv);
            acv = dvec4.Tanh(acv);

            bvec2.Parse("true, false");

            double d;
            double.TryParse("1", out d);

            var gbvec = new gvec4<bool>(true, false, true, false);
            var gsvec = new gvec3<string>("", "", null);
            var gpvec = new gvec2<Program>(null, null);
            var gopvec = new gvec2<Object>(null, null);
            var gtpvec = new gvec3<Type>(typeof(int), 1.GetType(), "".GetType());
        }
    }
}
