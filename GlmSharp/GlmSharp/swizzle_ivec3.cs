using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct swizzle_ivec3
    {
        public readonly int x;
        public readonly int y;
        public readonly int z;
        
        public swizzle_ivec3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public ivec3 xxx => new ivec3(x, x, x);
        public ivec3 xxy => new ivec3(x, x, y);
        public ivec3 xxz => new ivec3(x, x, z);
        public ivec2 xx => new ivec2(x, x);
        public ivec3 xyx => new ivec3(x, y, x);
        public ivec3 xyy => new ivec3(x, y, y);
        public ivec3 xyz => new ivec3(x, y, z);
        public ivec2 xy => new ivec2(x, y);
        public ivec3 xzx => new ivec3(x, z, x);
        public ivec3 xzy => new ivec3(x, z, y);
        public ivec3 xzz => new ivec3(x, z, z);
        public ivec2 xz => new ivec2(x, z);
        public ivec3 yxx => new ivec3(y, x, x);
        public ivec3 yxy => new ivec3(y, x, y);
        public ivec3 yxz => new ivec3(y, x, z);
        public ivec2 yx => new ivec2(y, x);
        public ivec3 yyx => new ivec3(y, y, x);
        public ivec3 yyy => new ivec3(y, y, y);
        public ivec3 yyz => new ivec3(y, y, z);
        public ivec2 yy => new ivec2(y, y);
        public ivec3 yzx => new ivec3(y, z, x);
        public ivec3 yzy => new ivec3(y, z, y);
        public ivec3 yzz => new ivec3(y, z, z);
        public ivec2 yz => new ivec2(y, z);
        public ivec3 zxx => new ivec3(z, x, x);
        public ivec3 zxy => new ivec3(z, x, y);
        public ivec3 zxz => new ivec3(z, x, z);
        public ivec2 zx => new ivec2(z, x);
        public ivec3 zyx => new ivec3(z, y, x);
        public ivec3 zyy => new ivec3(z, y, y);
        public ivec3 zyz => new ivec3(z, y, z);
        public ivec2 zy => new ivec2(z, y);
        public ivec3 zzx => new ivec3(z, z, x);
        public ivec3 zzy => new ivec3(z, z, y);
        public ivec3 zzz => new ivec3(z, z, z);
        public ivec2 zz => new ivec2(z, z);
    }
}
