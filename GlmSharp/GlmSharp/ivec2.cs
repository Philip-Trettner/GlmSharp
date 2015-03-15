using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct ivec2
    {
        public int x;
        public int y;
        
        public swizzle_ivec2 swizzle => new swizzle_ivec2(x, y);
        
        public ivec2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
