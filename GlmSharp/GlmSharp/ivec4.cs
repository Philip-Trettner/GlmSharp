using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct ivec4
    {
        public int x;
        public int y;
        public int z;
        public int w;
        
        public swizzle_ivec4 swizzle => new swizzle_ivec4(x, y, z, w);
        
        public ivec4(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
}
