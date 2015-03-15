using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct ivec3
    {
        public int x;
        public int y;
        public int z;
        
        public swizzle_ivec3 swizzle => new swizzle_ivec3(x, y, z);
        
        public ivec3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
