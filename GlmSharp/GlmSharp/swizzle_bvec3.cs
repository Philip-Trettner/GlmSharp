using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct swizzle_bvec3
    {
        public readonly bool x;
        public readonly bool y;
        public readonly bool z;
        
        public swizzle_bvec3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public bvec3 xxx => new bvec3(x, x, x);
        public bvec3 xxy => new bvec3(x, x, y);
        public bvec3 xxz => new bvec3(x, x, z);
        public bvec2 xx => new bvec2(x, x);
        public bvec3 xyx => new bvec3(x, y, x);
        public bvec3 xyy => new bvec3(x, y, y);
        public bvec3 xyz => new bvec3(x, y, z);
        public bvec2 xy => new bvec2(x, y);
        public bvec3 xzx => new bvec3(x, z, x);
        public bvec3 xzy => new bvec3(x, z, y);
        public bvec3 xzz => new bvec3(x, z, z);
        public bvec2 xz => new bvec2(x, z);
        public bvec3 yxx => new bvec3(y, x, x);
        public bvec3 yxy => new bvec3(y, x, y);
        public bvec3 yxz => new bvec3(y, x, z);
        public bvec2 yx => new bvec2(y, x);
        public bvec3 yyx => new bvec3(y, y, x);
        public bvec3 yyy => new bvec3(y, y, y);
        public bvec3 yyz => new bvec3(y, y, z);
        public bvec2 yy => new bvec2(y, y);
        public bvec3 yzx => new bvec3(y, z, x);
        public bvec3 yzy => new bvec3(y, z, y);
        public bvec3 yzz => new bvec3(y, z, z);
        public bvec2 yz => new bvec2(y, z);
        public bvec3 zxx => new bvec3(z, x, x);
        public bvec3 zxy => new bvec3(z, x, y);
        public bvec3 zxz => new bvec3(z, x, z);
        public bvec2 zx => new bvec2(z, x);
        public bvec3 zyx => new bvec3(z, y, x);
        public bvec3 zyy => new bvec3(z, y, y);
        public bvec3 zyz => new bvec3(z, y, z);
        public bvec2 zy => new bvec2(z, y);
        public bvec3 zzx => new bvec3(z, z, x);
        public bvec3 zzy => new bvec3(z, z, y);
        public bvec3 zzz => new bvec3(z, z, z);
        public bvec2 zz => new bvec2(z, z);
    }
}
