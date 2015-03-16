using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_dvec2
    {
        public readonly double x;
        public readonly double y;
        
        public swizzle_dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        public dvec2 xx => new dvec2(x, x);
        public dvec3 xxx => new dvec3(x, x, x);
        public dvec4 xxxx => new dvec4(x, x, x, x);
        public dvec4 xxxy => new dvec4(x, x, x, y);
        public dvec3 xxy => new dvec3(x, x, y);
        public dvec4 xxyx => new dvec4(x, x, y, x);
        public dvec4 xxyy => new dvec4(x, x, y, y);
        public dvec2 xy => new dvec2(x, y);
        public dvec3 xyx => new dvec3(x, y, x);
        public dvec4 xyxx => new dvec4(x, y, x, x);
        public dvec4 xyxy => new dvec4(x, y, x, y);
        public dvec3 xyy => new dvec3(x, y, y);
        public dvec4 xyyx => new dvec4(x, y, y, x);
        public dvec4 xyyy => new dvec4(x, y, y, y);
        public dvec2 yx => new dvec2(y, x);
        public dvec3 yxx => new dvec3(y, x, x);
        public dvec4 yxxx => new dvec4(y, x, x, x);
        public dvec4 yxxy => new dvec4(y, x, x, y);
        public dvec3 yxy => new dvec3(y, x, y);
        public dvec4 yxyx => new dvec4(y, x, y, x);
        public dvec4 yxyy => new dvec4(y, x, y, y);
        public dvec2 yy => new dvec2(y, y);
        public dvec3 yyx => new dvec3(y, y, x);
        public dvec4 yyxx => new dvec4(y, y, x, x);
        public dvec4 yyxy => new dvec4(y, y, x, y);
        public dvec3 yyy => new dvec3(y, y, y);
        public dvec4 yyyx => new dvec4(y, y, y, x);
        public dvec4 yyyy => new dvec4(y, y, y, y);
        
        // RGBA Versions
        public dvec2 rr => new dvec2(x, x);
        public dvec3 rrr => new dvec3(x, x, x);
        public dvec4 rrrr => new dvec4(x, x, x, x);
        public dvec4 rrrg => new dvec4(x, x, x, y);
        public dvec3 rrg => new dvec3(x, x, y);
        public dvec4 rrgr => new dvec4(x, x, y, x);
        public dvec4 rrgg => new dvec4(x, x, y, y);
        public dvec2 rg => new dvec2(x, y);
        public dvec3 rgr => new dvec3(x, y, x);
        public dvec4 rgrr => new dvec4(x, y, x, x);
        public dvec4 rgrg => new dvec4(x, y, x, y);
        public dvec3 rgg => new dvec3(x, y, y);
        public dvec4 rggr => new dvec4(x, y, y, x);
        public dvec4 rggg => new dvec4(x, y, y, y);
        public dvec2 gr => new dvec2(y, x);
        public dvec3 grr => new dvec3(y, x, x);
        public dvec4 grrr => new dvec4(y, x, x, x);
        public dvec4 grrg => new dvec4(y, x, x, y);
        public dvec3 grg => new dvec3(y, x, y);
        public dvec4 grgr => new dvec4(y, x, y, x);
        public dvec4 grgg => new dvec4(y, x, y, y);
        public dvec2 gg => new dvec2(y, y);
        public dvec3 ggr => new dvec3(y, y, x);
        public dvec4 ggrr => new dvec4(y, y, x, x);
        public dvec4 ggrg => new dvec4(y, y, x, y);
        public dvec3 ggg => new dvec3(y, y, y);
        public dvec4 gggr => new dvec4(y, y, y, x);
        public dvec4 gggg => new dvec4(y, y, y, y);
    }
}
