using System;
using System.Collections;
using System.Collections.Generic;
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
        
        public gvec2<T> xx => new gvec2<T>(x, x);
        public gvec2<T> xy => new gvec2<T>(x, y);
        public gvec2<T> yx => new gvec2<T>(y, x);
        public gvec2<T> yy => new gvec2<T>(y, y);
    }
}
