using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_lvec3
    {
        public readonly long x;
        public readonly long y;
        public readonly long z;
        
        public swizzle_lvec3(long x, long y, long z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public lvec3 xxx => new lvec3(x, x, x);
        public lvec3 xxy => new lvec3(x, x, y);
        public lvec3 xxz => new lvec3(x, x, z);
        public lvec2 xx => new lvec2(x, x);
        public lvec3 xyx => new lvec3(x, y, x);
        public lvec3 xyy => new lvec3(x, y, y);
        public lvec3 xyz => new lvec3(x, y, z);
        public lvec2 xy => new lvec2(x, y);
        public lvec3 xzx => new lvec3(x, z, x);
        public lvec3 xzy => new lvec3(x, z, y);
        public lvec3 xzz => new lvec3(x, z, z);
        public lvec2 xz => new lvec2(x, z);
        public lvec3 yxx => new lvec3(y, x, x);
        public lvec3 yxy => new lvec3(y, x, y);
        public lvec3 yxz => new lvec3(y, x, z);
        public lvec2 yx => new lvec2(y, x);
        public lvec3 yyx => new lvec3(y, y, x);
        public lvec3 yyy => new lvec3(y, y, y);
        public lvec3 yyz => new lvec3(y, y, z);
        public lvec2 yy => new lvec2(y, y);
        public lvec3 yzx => new lvec3(y, z, x);
        public lvec3 yzy => new lvec3(y, z, y);
        public lvec3 yzz => new lvec3(y, z, z);
        public lvec2 yz => new lvec2(y, z);
        public lvec3 zxx => new lvec3(z, x, x);
        public lvec3 zxy => new lvec3(z, x, y);
        public lvec3 zxz => new lvec3(z, x, z);
        public lvec2 zx => new lvec2(z, x);
        public lvec3 zyx => new lvec3(z, y, x);
        public lvec3 zyy => new lvec3(z, y, y);
        public lvec3 zyz => new lvec3(z, y, z);
        public lvec2 zy => new lvec2(z, y);
        public lvec3 zzx => new lvec3(z, z, x);
        public lvec3 zzy => new lvec3(z, z, y);
        public lvec3 zzz => new lvec3(z, z, z);
        public lvec2 zz => new lvec2(z, z);
    }
}
