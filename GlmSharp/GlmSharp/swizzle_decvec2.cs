using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_decvec2
    {
        public readonly decimal x;
        public readonly decimal y;
        
        public swizzle_decvec2(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        public decvec2 xx => new decvec2(x, x);
        public decvec3 xxx => new decvec3(x, x, x);
        public decvec4 xxxx => new decvec4(x, x, x, x);
        public decvec4 xxxy => new decvec4(x, x, x, y);
        public decvec3 xxy => new decvec3(x, x, y);
        public decvec4 xxyx => new decvec4(x, x, y, x);
        public decvec4 xxyy => new decvec4(x, x, y, y);
        public decvec2 xy => new decvec2(x, y);
        public decvec3 xyx => new decvec3(x, y, x);
        public decvec4 xyxx => new decvec4(x, y, x, x);
        public decvec4 xyxy => new decvec4(x, y, x, y);
        public decvec3 xyy => new decvec3(x, y, y);
        public decvec4 xyyx => new decvec4(x, y, y, x);
        public decvec4 xyyy => new decvec4(x, y, y, y);
        public decvec2 yx => new decvec2(y, x);
        public decvec3 yxx => new decvec3(y, x, x);
        public decvec4 yxxx => new decvec4(y, x, x, x);
        public decvec4 yxxy => new decvec4(y, x, x, y);
        public decvec3 yxy => new decvec3(y, x, y);
        public decvec4 yxyx => new decvec4(y, x, y, x);
        public decvec4 yxyy => new decvec4(y, x, y, y);
        public decvec2 yy => new decvec2(y, y);
        public decvec3 yyx => new decvec3(y, y, x);
        public decvec4 yyxx => new decvec4(y, y, x, x);
        public decvec4 yyxy => new decvec4(y, y, x, y);
        public decvec3 yyy => new decvec3(y, y, y);
        public decvec4 yyyx => new decvec4(y, y, y, x);
        public decvec4 yyyy => new decvec4(y, y, y, y);
        
        // RGBA Versions
        public decvec2 rr => new decvec2(x, x);
        public decvec3 rrr => new decvec3(x, x, x);
        public decvec4 rrrr => new decvec4(x, x, x, x);
        public decvec4 rrrg => new decvec4(x, x, x, y);
        public decvec3 rrg => new decvec3(x, x, y);
        public decvec4 rrgr => new decvec4(x, x, y, x);
        public decvec4 rrgg => new decvec4(x, x, y, y);
        public decvec2 rg => new decvec2(x, y);
        public decvec3 rgr => new decvec3(x, y, x);
        public decvec4 rgrr => new decvec4(x, y, x, x);
        public decvec4 rgrg => new decvec4(x, y, x, y);
        public decvec3 rgg => new decvec3(x, y, y);
        public decvec4 rggr => new decvec4(x, y, y, x);
        public decvec4 rggg => new decvec4(x, y, y, y);
        public decvec2 gr => new decvec2(y, x);
        public decvec3 grr => new decvec3(y, x, x);
        public decvec4 grrr => new decvec4(y, x, x, x);
        public decvec4 grrg => new decvec4(y, x, x, y);
        public decvec3 grg => new decvec3(y, x, y);
        public decvec4 grgr => new decvec4(y, x, y, x);
        public decvec4 grgg => new decvec4(y, x, y, y);
        public decvec2 gg => new decvec2(y, y);
        public decvec3 ggr => new decvec3(y, y, x);
        public decvec4 ggrr => new decvec4(y, y, x, x);
        public decvec4 ggrg => new decvec4(y, y, x, y);
        public decvec3 ggg => new decvec3(y, y, y);
        public decvec4 gggr => new decvec4(y, y, y, x);
        public decvec4 gggg => new decvec4(y, y, y, y);
    }
}
