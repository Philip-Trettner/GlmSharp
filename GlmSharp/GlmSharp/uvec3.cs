using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct uvec3
    {
        public uint x;
        public uint y;
        public uint z;
        
        public swizzle_uvec3 swizzle => new swizzle_uvec3(x, y, z);
        
        public uvec3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
