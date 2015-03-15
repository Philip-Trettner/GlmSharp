using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct uvec4
    {
        public uint x;
        public uint y;
        public uint z;
        public uint w;
        
        public swizzle_uvec4 swizzle => new swizzle_uvec4(x, y, z, w);
        
        public uvec4(uint x, uint y, uint z, uint w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
}
