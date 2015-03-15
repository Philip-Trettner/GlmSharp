using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_cvec2
    {
        public readonly Complex x;
        public readonly Complex y;
        
        public swizzle_cvec2(Complex x, Complex y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        public cvec2 xx => new cvec2(x, x);
        public cvec3 xxx => new cvec3(x, x, x);
        public cvec4 xxxx => new cvec4(x, x, x, x);
        public cvec4 xxxy => new cvec4(x, x, x, y);
        public cvec3 xxy => new cvec3(x, x, y);
        public cvec4 xxyx => new cvec4(x, x, y, x);
        public cvec4 xxyy => new cvec4(x, x, y, y);
        public cvec2 xy => new cvec2(x, y);
        public cvec3 xyx => new cvec3(x, y, x);
        public cvec4 xyxx => new cvec4(x, y, x, x);
        public cvec4 xyxy => new cvec4(x, y, x, y);
        public cvec3 xyy => new cvec3(x, y, y);
        public cvec4 xyyx => new cvec4(x, y, y, x);
        public cvec4 xyyy => new cvec4(x, y, y, y);
        public cvec2 yx => new cvec2(y, x);
        public cvec3 yxx => new cvec3(y, x, x);
        public cvec4 yxxx => new cvec4(y, x, x, x);
        public cvec4 yxxy => new cvec4(y, x, x, y);
        public cvec3 yxy => new cvec3(y, x, y);
        public cvec4 yxyx => new cvec4(y, x, y, x);
        public cvec4 yxyy => new cvec4(y, x, y, y);
        public cvec2 yy => new cvec2(y, y);
        public cvec3 yyx => new cvec3(y, y, x);
        public cvec4 yyxx => new cvec4(y, y, x, x);
        public cvec4 yyxy => new cvec4(y, y, x, y);
        public cvec3 yyy => new cvec3(y, y, y);
        public cvec4 yyyx => new cvec4(y, y, y, x);
        public cvec4 yyyy => new cvec4(y, y, y, y);
        
        // RGBA Versions
        public cvec2 rr => new cvec2(x, x);
        public cvec3 rrr => new cvec3(x, x, x);
        public cvec4 rrrr => new cvec4(x, x, x, x);
        public cvec4 rrrg => new cvec4(x, x, x, y);
        public cvec3 rrg => new cvec3(x, x, y);
        public cvec4 rrgr => new cvec4(x, x, y, x);
        public cvec4 rrgg => new cvec4(x, x, y, y);
        public cvec2 rg => new cvec2(x, y);
        public cvec3 rgr => new cvec3(x, y, x);
        public cvec4 rgrr => new cvec4(x, y, x, x);
        public cvec4 rgrg => new cvec4(x, y, x, y);
        public cvec3 rgg => new cvec3(x, y, y);
        public cvec4 rggr => new cvec4(x, y, y, x);
        public cvec4 rggg => new cvec4(x, y, y, y);
        public cvec2 gr => new cvec2(y, x);
        public cvec3 grr => new cvec3(y, x, x);
        public cvec4 grrr => new cvec4(y, x, x, x);
        public cvec4 grrg => new cvec4(y, x, x, y);
        public cvec3 grg => new cvec3(y, x, y);
        public cvec4 grgr => new cvec4(y, x, y, x);
        public cvec4 grgg => new cvec4(y, x, y, y);
        public cvec2 gg => new cvec2(y, y);
        public cvec3 ggr => new cvec3(y, y, x);
        public cvec4 ggrr => new cvec4(y, y, x, x);
        public cvec4 ggrg => new cvec4(y, y, x, y);
        public cvec3 ggg => new cvec3(y, y, y);
        public cvec4 gggr => new cvec4(y, y, y, x);
        public cvec4 gggg => new cvec4(y, y, y, y);
    }
}
