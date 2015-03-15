using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_lvec2
    {
        public readonly long x;
        public readonly long y;
        
        public swizzle_lvec2(long x, long y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        public lvec2 xx => new lvec2(x, x);
        public lvec3 xxx => new lvec3(x, x, x);
        public lvec4 xxxx => new lvec4(x, x, x, x);
        public lvec4 xxxy => new lvec4(x, x, x, y);
        public lvec3 xxy => new lvec3(x, x, y);
        public lvec4 xxyx => new lvec4(x, x, y, x);
        public lvec4 xxyy => new lvec4(x, x, y, y);
        public lvec2 xy => new lvec2(x, y);
        public lvec3 xyx => new lvec3(x, y, x);
        public lvec4 xyxx => new lvec4(x, y, x, x);
        public lvec4 xyxy => new lvec4(x, y, x, y);
        public lvec3 xyy => new lvec3(x, y, y);
        public lvec4 xyyx => new lvec4(x, y, y, x);
        public lvec4 xyyy => new lvec4(x, y, y, y);
        public lvec2 yx => new lvec2(y, x);
        public lvec3 yxx => new lvec3(y, x, x);
        public lvec4 yxxx => new lvec4(y, x, x, x);
        public lvec4 yxxy => new lvec4(y, x, x, y);
        public lvec3 yxy => new lvec3(y, x, y);
        public lvec4 yxyx => new lvec4(y, x, y, x);
        public lvec4 yxyy => new lvec4(y, x, y, y);
        public lvec2 yy => new lvec2(y, y);
        public lvec3 yyx => new lvec3(y, y, x);
        public lvec4 yyxx => new lvec4(y, y, x, x);
        public lvec4 yyxy => new lvec4(y, y, x, y);
        public lvec3 yyy => new lvec3(y, y, y);
        public lvec4 yyyx => new lvec4(y, y, y, x);
        public lvec4 yyyy => new lvec4(y, y, y, y);
        
        // RGBA Versions
        public lvec2 rr => new lvec2(x, x);
        public lvec3 rrr => new lvec3(x, x, x);
        public lvec4 rrrr => new lvec4(x, x, x, x);
        public lvec4 rrrg => new lvec4(x, x, x, y);
        public lvec3 rrg => new lvec3(x, x, y);
        public lvec4 rrgr => new lvec4(x, x, y, x);
        public lvec4 rrgg => new lvec4(x, x, y, y);
        public lvec2 rg => new lvec2(x, y);
        public lvec3 rgr => new lvec3(x, y, x);
        public lvec4 rgrr => new lvec4(x, y, x, x);
        public lvec4 rgrg => new lvec4(x, y, x, y);
        public lvec3 rgg => new lvec3(x, y, y);
        public lvec4 rggr => new lvec4(x, y, y, x);
        public lvec4 rggg => new lvec4(x, y, y, y);
        public lvec2 gr => new lvec2(y, x);
        public lvec3 grr => new lvec3(y, x, x);
        public lvec4 grrr => new lvec4(y, x, x, x);
        public lvec4 grrg => new lvec4(y, x, x, y);
        public lvec3 grg => new lvec3(y, x, y);
        public lvec4 grgr => new lvec4(y, x, y, x);
        public lvec4 grgg => new lvec4(y, x, y, y);
        public lvec2 gg => new lvec2(y, y);
        public lvec3 ggr => new lvec3(y, y, x);
        public lvec4 ggrr => new lvec4(y, y, x, x);
        public lvec4 ggrg => new lvec4(y, y, x, y);
        public lvec3 ggg => new lvec3(y, y, y);
        public lvec4 gggr => new lvec4(y, y, y, x);
        public lvec4 gggg => new lvec4(y, y, y, y);
    }
}
