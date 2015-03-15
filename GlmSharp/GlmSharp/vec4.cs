using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct vec4
    {
        public float x;
        public float y;
        public float z;
        public float w;
        
        public swizzle_vec4 swizzle => new swizzle_vec4(x, y, z, w);
        
        public vec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
}
