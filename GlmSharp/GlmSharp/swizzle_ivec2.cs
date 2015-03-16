using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_ivec2
    {
        public readonly int x;
        public readonly int y;
        
        public swizzle_ivec2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        public ivec2 xx => new ivec2(x, x);
        public ivec3 xxx => new ivec3(x, x, x);
        public ivec4 xxxx => new ivec4(x, x, x, x);
        public ivec4 xxxy => new ivec4(x, x, x, y);
        public ivec3 xxy => new ivec3(x, x, y);
        public ivec4 xxyx => new ivec4(x, x, y, x);
        public ivec4 xxyy => new ivec4(x, x, y, y);
        public ivec2 xy => new ivec2(x, y);
        public ivec3 xyx => new ivec3(x, y, x);
        public ivec4 xyxx => new ivec4(x, y, x, x);
        public ivec4 xyxy => new ivec4(x, y, x, y);
        public ivec3 xyy => new ivec3(x, y, y);
        public ivec4 xyyx => new ivec4(x, y, y, x);
        public ivec4 xyyy => new ivec4(x, y, y, y);
        public ivec2 yx => new ivec2(y, x);
        public ivec3 yxx => new ivec3(y, x, x);
        public ivec4 yxxx => new ivec4(y, x, x, x);
        public ivec4 yxxy => new ivec4(y, x, x, y);
        public ivec3 yxy => new ivec3(y, x, y);
        public ivec4 yxyx => new ivec4(y, x, y, x);
        public ivec4 yxyy => new ivec4(y, x, y, y);
        public ivec2 yy => new ivec2(y, y);
        public ivec3 yyx => new ivec3(y, y, x);
        public ivec4 yyxx => new ivec4(y, y, x, x);
        public ivec4 yyxy => new ivec4(y, y, x, y);
        public ivec3 yyy => new ivec3(y, y, y);
        public ivec4 yyyx => new ivec4(y, y, y, x);
        public ivec4 yyyy => new ivec4(y, y, y, y);
        
        // RGBA Versions
        public ivec2 rr => new ivec2(x, x);
        public ivec3 rrr => new ivec3(x, x, x);
        public ivec4 rrrr => new ivec4(x, x, x, x);
        public ivec4 rrrg => new ivec4(x, x, x, y);
        public ivec3 rrg => new ivec3(x, x, y);
        public ivec4 rrgr => new ivec4(x, x, y, x);
        public ivec4 rrgg => new ivec4(x, x, y, y);
        public ivec2 rg => new ivec2(x, y);
        public ivec3 rgr => new ivec3(x, y, x);
        public ivec4 rgrr => new ivec4(x, y, x, x);
        public ivec4 rgrg => new ivec4(x, y, x, y);
        public ivec3 rgg => new ivec3(x, y, y);
        public ivec4 rggr => new ivec4(x, y, y, x);
        public ivec4 rggg => new ivec4(x, y, y, y);
        public ivec2 gr => new ivec2(y, x);
        public ivec3 grr => new ivec3(y, x, x);
        public ivec4 grrr => new ivec4(y, x, x, x);
        public ivec4 grrg => new ivec4(y, x, x, y);
        public ivec3 grg => new ivec3(y, x, y);
        public ivec4 grgr => new ivec4(y, x, y, x);
        public ivec4 grgg => new ivec4(y, x, y, y);
        public ivec2 gg => new ivec2(y, y);
        public ivec3 ggr => new ivec3(y, y, x);
        public ivec4 ggrr => new ivec4(y, y, x, x);
        public ivec4 ggrg => new ivec4(y, y, x, y);
        public ivec3 ggg => new ivec3(y, y, y);
        public ivec4 gggr => new ivec4(y, y, y, x);
        public ivec4 gggg => new ivec4(y, y, y, y);
    }
}
