using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct vec3
    {
        public float x;
        public float y;
        public float z;
        
        public swizzle_vec3 swizzle => new swizzle_vec3(x, y, z);
        
        public vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
