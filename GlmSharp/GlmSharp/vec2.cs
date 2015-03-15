using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct vec2
    {
        public float x;
        public float y;
        
        public swizzle_vec2 swizzle => new swizzle_vec2(x, y);
        
        public vec2(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
