using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct uvec2
    {
        public uint x;
        public uint y;
        
        public swizzle_uvec2 swizzle => new swizzle_uvec2(x, y);
        
        public uvec2(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
