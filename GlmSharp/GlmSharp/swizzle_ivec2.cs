using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

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
        
        public ivec2 xx => new ivec2(x, x);
        public ivec2 xy => new ivec2(x, y);
        public ivec2 yx => new ivec2(y, x);
        public ivec2 yy => new ivec2(y, y);
    }
}
