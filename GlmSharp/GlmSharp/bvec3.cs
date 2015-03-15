using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct bvec3
    {
        public bool x;
        public bool y;
        public bool z;
        
        public swizzle_bvec3 swizzle => new swizzle_bvec3(x, y, z);
        
        public bvec3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
