using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_uvec2
    {
        public readonly uint x;
        public readonly uint y;
        
        public swizzle_uvec2(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        public uvec2 xx => new uvec2(x, x);
        public uvec3 xxx => new uvec3(x, x, x);
        public uvec4 xxxx => new uvec4(x, x, x, x);
        public uvec4 xxxy => new uvec4(x, x, x, y);
        public uvec3 xxy => new uvec3(x, x, y);
        public uvec4 xxyx => new uvec4(x, x, y, x);
        public uvec4 xxyy => new uvec4(x, x, y, y);
        public uvec2 xy => new uvec2(x, y);
        public uvec3 xyx => new uvec3(x, y, x);
        public uvec4 xyxx => new uvec4(x, y, x, x);
        public uvec4 xyxy => new uvec4(x, y, x, y);
        public uvec3 xyy => new uvec3(x, y, y);
        public uvec4 xyyx => new uvec4(x, y, y, x);
        public uvec4 xyyy => new uvec4(x, y, y, y);
        public uvec2 yx => new uvec2(y, x);
        public uvec3 yxx => new uvec3(y, x, x);
        public uvec4 yxxx => new uvec4(y, x, x, x);
        public uvec4 yxxy => new uvec4(y, x, x, y);
        public uvec3 yxy => new uvec3(y, x, y);
        public uvec4 yxyx => new uvec4(y, x, y, x);
        public uvec4 yxyy => new uvec4(y, x, y, y);
        public uvec2 yy => new uvec2(y, y);
        public uvec3 yyx => new uvec3(y, y, x);
        public uvec4 yyxx => new uvec4(y, y, x, x);
        public uvec4 yyxy => new uvec4(y, y, x, y);
        public uvec3 yyy => new uvec3(y, y, y);
        public uvec4 yyyx => new uvec4(y, y, y, x);
        public uvec4 yyyy => new uvec4(y, y, y, y);
        
        // RGBA Versions
        public uvec2 rr => new uvec2(x, x);
        public uvec3 rrr => new uvec3(x, x, x);
        public uvec4 rrrr => new uvec4(x, x, x, x);
        public uvec4 rrrg => new uvec4(x, x, x, y);
        public uvec3 rrg => new uvec3(x, x, y);
        public uvec4 rrgr => new uvec4(x, x, y, x);
        public uvec4 rrgg => new uvec4(x, x, y, y);
        public uvec2 rg => new uvec2(x, y);
        public uvec3 rgr => new uvec3(x, y, x);
        public uvec4 rgrr => new uvec4(x, y, x, x);
        public uvec4 rgrg => new uvec4(x, y, x, y);
        public uvec3 rgg => new uvec3(x, y, y);
        public uvec4 rggr => new uvec4(x, y, y, x);
        public uvec4 rggg => new uvec4(x, y, y, y);
        public uvec2 gr => new uvec2(y, x);
        public uvec3 grr => new uvec3(y, x, x);
        public uvec4 grrr => new uvec4(y, x, x, x);
        public uvec4 grrg => new uvec4(y, x, x, y);
        public uvec3 grg => new uvec3(y, x, y);
        public uvec4 grgr => new uvec4(y, x, y, x);
        public uvec4 grgg => new uvec4(y, x, y, y);
        public uvec2 gg => new uvec2(y, y);
        public uvec3 ggr => new uvec3(y, y, x);
        public uvec4 ggrr => new uvec4(y, y, x, x);
        public uvec4 ggrg => new uvec4(y, y, x, y);
        public uvec3 ggg => new uvec3(y, y, y);
        public uvec4 gggr => new uvec4(y, y, y, x);
        public uvec4 gggg => new uvec4(y, y, y, y);
    }
}
