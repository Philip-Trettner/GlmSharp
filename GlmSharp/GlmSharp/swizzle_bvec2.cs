using System;
using System.Collections.Generic;
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
        
        public bvec2 xx => new bvec2(x, x);
        public bvec2 xy => new bvec2(x, y);
        public bvec2 yx => new bvec2(y, x);
        public bvec2 yy => new bvec2(y, y);
    }
}
