using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_vec3
    {
        public readonly float x;
        public readonly float y;
        public readonly float z;
        
        public swizzle_vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public vec3 xxx => new vec3(x, x, x);
        public vec3 xxy => new vec3(x, x, y);
        public vec3 xxz => new vec3(x, x, z);
        public vec2 xx => new vec2(x, x);
        public vec3 xyx => new vec3(x, y, x);
        public vec3 xyy => new vec3(x, y, y);
        public vec3 xyz => new vec3(x, y, z);
        public vec2 xy => new vec2(x, y);
        public vec3 xzx => new vec3(x, z, x);
        public vec3 xzy => new vec3(x, z, y);
        public vec3 xzz => new vec3(x, z, z);
        public vec2 xz => new vec2(x, z);
        public vec3 yxx => new vec3(y, x, x);
        public vec3 yxy => new vec3(y, x, y);
        public vec3 yxz => new vec3(y, x, z);
        public vec2 yx => new vec2(y, x);
        public vec3 yyx => new vec3(y, y, x);
        public vec3 yyy => new vec3(y, y, y);
        public vec3 yyz => new vec3(y, y, z);
        public vec2 yy => new vec2(y, y);
        public vec3 yzx => new vec3(y, z, x);
        public vec3 yzy => new vec3(y, z, y);
        public vec3 yzz => new vec3(y, z, z);
        public vec2 yz => new vec2(y, z);
        public vec3 zxx => new vec3(z, x, x);
        public vec3 zxy => new vec3(z, x, y);
        public vec3 zxz => new vec3(z, x, z);
        public vec2 zx => new vec2(z, x);
        public vec3 zyx => new vec3(z, y, x);
        public vec3 zyy => new vec3(z, y, y);
        public vec3 zyz => new vec3(z, y, z);
        public vec2 zy => new vec2(z, y);
        public vec3 zzx => new vec3(z, z, x);
        public vec3 zzy => new vec3(z, z, y);
        public vec3 zzz => new vec3(z, z, z);
        public vec2 zz => new vec2(z, z);
    }
}
