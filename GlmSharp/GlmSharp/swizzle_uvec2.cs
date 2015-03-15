using System;
using System.Collections.Generic;
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
        
        public uvec2 xx => new uvec2(x, x);
        public uvec2 xy => new uvec2(x, y);
        public uvec2 yx => new uvec2(y, x);
        public uvec2 yy => new uvec2(y, y);
    }
}
