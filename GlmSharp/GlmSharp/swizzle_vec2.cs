using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct swizzle_vec2
    {
        public readonly float x;
        public readonly float y;
        
        public swizzle_vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        
        public vec2 xx => new vec2(x, x);
        public vec2 xy => new vec2(x, y);
        public vec2 yx => new vec2(y, x);
        public vec2 yy => new vec2(y, y);
    }
}
