using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct swizzle_uvec3
    {
        public readonly uint x;
        public readonly uint y;
        public readonly uint z;
        
        public swizzle_uvec3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public uvec3 xxx => new uvec3(x, x, x);
        public uvec3 xxy => new uvec3(x, x, y);
        public uvec3 xxz => new uvec3(x, x, z);
        public uvec2 xx => new uvec2(x, x);
        public uvec3 xyx => new uvec3(x, y, x);
        public uvec3 xyy => new uvec3(x, y, y);
        public uvec3 xyz => new uvec3(x, y, z);
        public uvec2 xy => new uvec2(x, y);
        public uvec3 xzx => new uvec3(x, z, x);
        public uvec3 xzy => new uvec3(x, z, y);
        public uvec3 xzz => new uvec3(x, z, z);
        public uvec2 xz => new uvec2(x, z);
        public uvec3 yxx => new uvec3(y, x, x);
        public uvec3 yxy => new uvec3(y, x, y);
        public uvec3 yxz => new uvec3(y, x, z);
        public uvec2 yx => new uvec2(y, x);
        public uvec3 yyx => new uvec3(y, y, x);
        public uvec3 yyy => new uvec3(y, y, y);
        public uvec3 yyz => new uvec3(y, y, z);
        public uvec2 yy => new uvec2(y, y);
        public uvec3 yzx => new uvec3(y, z, x);
        public uvec3 yzy => new uvec3(y, z, y);
        public uvec3 yzz => new uvec3(y, z, z);
        public uvec2 yz => new uvec2(y, z);
        public uvec3 zxx => new uvec3(z, x, x);
        public uvec3 zxy => new uvec3(z, x, y);
        public uvec3 zxz => new uvec3(z, x, z);
        public uvec2 zx => new uvec2(z, x);
        public uvec3 zyx => new uvec3(z, y, x);
        public uvec3 zyy => new uvec3(z, y, y);
        public uvec3 zyz => new uvec3(z, y, z);
        public uvec2 zy => new uvec2(z, y);
        public uvec3 zzx => new uvec3(z, z, x);
        public uvec3 zzy => new uvec3(z, z, y);
        public uvec3 zzz => new uvec3(z, z, z);
        public uvec2 zz => new uvec2(z, z);
    }
}
