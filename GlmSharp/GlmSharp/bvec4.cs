using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct bvec4
    {
        public bool x;
        public bool y;
        public bool z;
        public bool w;
        
        public swizzle_bvec4 swizzle => new swizzle_bvec4(x, y, z, w);
        
        public bvec4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
}
