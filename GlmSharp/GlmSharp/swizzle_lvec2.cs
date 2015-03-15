using System;
using System.Collections;
using System.Collections.Generic;
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
        
        public lvec2 xx => new lvec2(x, x);
        public lvec2 xy => new lvec2(x, y);
        public lvec2 yx => new lvec2(y, x);
        public lvec2 yy => new lvec2(y, y);
    }
}
