using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct bvec2
    {
        public bool x;
        public bool y;
        
        public swizzle_bvec2 swizzle => new swizzle_bvec2(x, y);
        
        public bvec2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
