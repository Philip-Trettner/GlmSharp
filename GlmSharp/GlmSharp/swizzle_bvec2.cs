using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_bvec2
    {
        public readonly bool x;
        public readonly bool y;
        
        public swizzle_bvec2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        public bvec2 xx => new bvec2(x, x);
        public bvec3 xxx => new bvec3(x, x, x);
        public bvec4 xxxx => new bvec4(x, x, x, x);
        public bvec4 xxxy => new bvec4(x, x, x, y);
        public bvec3 xxy => new bvec3(x, x, y);
        public bvec4 xxyx => new bvec4(x, x, y, x);
        public bvec4 xxyy => new bvec4(x, x, y, y);
        public bvec2 xy => new bvec2(x, y);
        public bvec3 xyx => new bvec3(x, y, x);
        public bvec4 xyxx => new bvec4(x, y, x, x);
        public bvec4 xyxy => new bvec4(x, y, x, y);
        public bvec3 xyy => new bvec3(x, y, y);
        public bvec4 xyyx => new bvec4(x, y, y, x);
        public bvec4 xyyy => new bvec4(x, y, y, y);
        public bvec2 yx => new bvec2(y, x);
        public bvec3 yxx => new bvec3(y, x, x);
        public bvec4 yxxx => new bvec4(y, x, x, x);
        public bvec4 yxxy => new bvec4(y, x, x, y);
        public bvec3 yxy => new bvec3(y, x, y);
        public bvec4 yxyx => new bvec4(y, x, y, x);
        public bvec4 yxyy => new bvec4(y, x, y, y);
        public bvec2 yy => new bvec2(y, y);
        public bvec3 yyx => new bvec3(y, y, x);
        public bvec4 yyxx => new bvec4(y, y, x, x);
        public bvec4 yyxy => new bvec4(y, y, x, y);
        public bvec3 yyy => new bvec3(y, y, y);
        public bvec4 yyyx => new bvec4(y, y, y, x);
        public bvec4 yyyy => new bvec4(y, y, y, y);
        
        // RGBA Versions
        public bvec2 rr => new bvec2(x, x);
        public bvec3 rrr => new bvec3(x, x, x);
        public bvec4 rrrr => new bvec4(x, x, x, x);
        public bvec4 rrrg => new bvec4(x, x, x, y);
        public bvec3 rrg => new bvec3(x, x, y);
        public bvec4 rrgr => new bvec4(x, x, y, x);
        public bvec4 rrgg => new bvec4(x, x, y, y);
        public bvec2 rg => new bvec2(x, y);
        public bvec3 rgr => new bvec3(x, y, x);
        public bvec4 rgrr => new bvec4(x, y, x, x);
        public bvec4 rgrg => new bvec4(x, y, x, y);
        public bvec3 rgg => new bvec3(x, y, y);
        public bvec4 rggr => new bvec4(x, y, y, x);
        public bvec4 rggg => new bvec4(x, y, y, y);
        public bvec2 gr => new bvec2(y, x);
        public bvec3 grr => new bvec3(y, x, x);
        public bvec4 grrr => new bvec4(y, x, x, x);
        public bvec4 grrg => new bvec4(y, x, x, y);
        public bvec3 grg => new bvec3(y, x, y);
        public bvec4 grgr => new bvec4(y, x, y, x);
        public bvec4 grgg => new bvec4(y, x, y, y);
        public bvec2 gg => new bvec2(y, y);
        public bvec3 ggr => new bvec3(y, y, x);
        public bvec4 ggrr => new bvec4(y, y, x, x);
        public bvec4 ggrg => new bvec4(y, y, x, y);
        public bvec3 ggg => new bvec3(y, y, y);
        public bvec4 gggr => new bvec4(y, y, y, x);
        public bvec4 gggg => new bvec4(y, y, y, y);
    }
}
