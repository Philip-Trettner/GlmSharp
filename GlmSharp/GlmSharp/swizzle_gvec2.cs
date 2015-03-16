using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_gvec2<T>
    {
        public readonly T x;
        public readonly T y;
        
        public swizzle_gvec2(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        public gvec2<T> xx => new gvec2<T>(x, x);
        public gvec3<T> xxx => new gvec3<T>(x, x, x);
        public gvec4<T> xxxx => new gvec4<T>(x, x, x, x);
        public gvec4<T> xxxy => new gvec4<T>(x, x, x, y);
        public gvec3<T> xxy => new gvec3<T>(x, x, y);
        public gvec4<T> xxyx => new gvec4<T>(x, x, y, x);
        public gvec4<T> xxyy => new gvec4<T>(x, x, y, y);
        public gvec2<T> xy => new gvec2<T>(x, y);
        public gvec3<T> xyx => new gvec3<T>(x, y, x);
        public gvec4<T> xyxx => new gvec4<T>(x, y, x, x);
        public gvec4<T> xyxy => new gvec4<T>(x, y, x, y);
        public gvec3<T> xyy => new gvec3<T>(x, y, y);
        public gvec4<T> xyyx => new gvec4<T>(x, y, y, x);
        public gvec4<T> xyyy => new gvec4<T>(x, y, y, y);
        public gvec2<T> yx => new gvec2<T>(y, x);
        public gvec3<T> yxx => new gvec3<T>(y, x, x);
        public gvec4<T> yxxx => new gvec4<T>(y, x, x, x);
        public gvec4<T> yxxy => new gvec4<T>(y, x, x, y);
        public gvec3<T> yxy => new gvec3<T>(y, x, y);
        public gvec4<T> yxyx => new gvec4<T>(y, x, y, x);
        public gvec4<T> yxyy => new gvec4<T>(y, x, y, y);
        public gvec2<T> yy => new gvec2<T>(y, y);
        public gvec3<T> yyx => new gvec3<T>(y, y, x);
        public gvec4<T> yyxx => new gvec4<T>(y, y, x, x);
        public gvec4<T> yyxy => new gvec4<T>(y, y, x, y);
        public gvec3<T> yyy => new gvec3<T>(y, y, y);
        public gvec4<T> yyyx => new gvec4<T>(y, y, y, x);
        public gvec4<T> yyyy => new gvec4<T>(y, y, y, y);
        
        // RGBA Versions
        public gvec2<T> rr => new gvec2<T>(x, x);
        public gvec3<T> rrr => new gvec3<T>(x, x, x);
        public gvec4<T> rrrr => new gvec4<T>(x, x, x, x);
        public gvec4<T> rrrg => new gvec4<T>(x, x, x, y);
        public gvec3<T> rrg => new gvec3<T>(x, x, y);
        public gvec4<T> rrgr => new gvec4<T>(x, x, y, x);
        public gvec4<T> rrgg => new gvec4<T>(x, x, y, y);
        public gvec2<T> rg => new gvec2<T>(x, y);
        public gvec3<T> rgr => new gvec3<T>(x, y, x);
        public gvec4<T> rgrr => new gvec4<T>(x, y, x, x);
        public gvec4<T> rgrg => new gvec4<T>(x, y, x, y);
        public gvec3<T> rgg => new gvec3<T>(x, y, y);
        public gvec4<T> rggr => new gvec4<T>(x, y, y, x);
        public gvec4<T> rggg => new gvec4<T>(x, y, y, y);
        public gvec2<T> gr => new gvec2<T>(y, x);
        public gvec3<T> grr => new gvec3<T>(y, x, x);
        public gvec4<T> grrr => new gvec4<T>(y, x, x, x);
        public gvec4<T> grrg => new gvec4<T>(y, x, x, y);
        public gvec3<T> grg => new gvec3<T>(y, x, y);
        public gvec4<T> grgr => new gvec4<T>(y, x, y, x);
        public gvec4<T> grgg => new gvec4<T>(y, x, y, y);
        public gvec2<T> gg => new gvec2<T>(y, y);
        public gvec3<T> ggr => new gvec3<T>(y, y, x);
        public gvec4<T> ggrr => new gvec4<T>(y, y, x, x);
        public gvec4<T> ggrg => new gvec4<T>(y, y, x, y);
        public gvec3<T> ggg => new gvec3<T>(y, y, y);
        public gvec4<T> gggr => new gvec4<T>(y, y, y, x);
        public gvec4<T> gggg => new gvec4<T>(y, y, y, y);
    }
}
