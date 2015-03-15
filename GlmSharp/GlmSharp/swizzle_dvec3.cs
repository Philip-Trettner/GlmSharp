using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct swizzle_dvec3
    {
        public readonly double x;
        public readonly double y;
        public readonly double z;
        
        public swizzle_dvec3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public dvec3 xxx => new dvec3(x, x, x);
        public dvec3 xxy => new dvec3(x, x, y);
        public dvec3 xxz => new dvec3(x, x, z);
        public dvec2 xx => new dvec2(x, x);
        public dvec3 xyx => new dvec3(x, y, x);
        public dvec3 xyy => new dvec3(x, y, y);
        public dvec3 xyz => new dvec3(x, y, z);
        public dvec2 xy => new dvec2(x, y);
        public dvec3 xzx => new dvec3(x, z, x);
        public dvec3 xzy => new dvec3(x, z, y);
        public dvec3 xzz => new dvec3(x, z, z);
        public dvec2 xz => new dvec2(x, z);
        public dvec3 yxx => new dvec3(y, x, x);
        public dvec3 yxy => new dvec3(y, x, y);
        public dvec3 yxz => new dvec3(y, x, z);
        public dvec2 yx => new dvec2(y, x);
        public dvec3 yyx => new dvec3(y, y, x);
        public dvec3 yyy => new dvec3(y, y, y);
        public dvec3 yyz => new dvec3(y, y, z);
        public dvec2 yy => new dvec2(y, y);
        public dvec3 yzx => new dvec3(y, z, x);
        public dvec3 yzy => new dvec3(y, z, y);
        public dvec3 yzz => new dvec3(y, z, z);
        public dvec2 yz => new dvec2(y, z);
        public dvec3 zxx => new dvec3(z, x, x);
        public dvec3 zxy => new dvec3(z, x, y);
        public dvec3 zxz => new dvec3(z, x, z);
        public dvec2 zx => new dvec2(z, x);
        public dvec3 zyx => new dvec3(z, y, x);
        public dvec3 zyy => new dvec3(z, y, y);
        public dvec3 zyz => new dvec3(z, y, z);
        public dvec2 zy => new dvec2(z, y);
        public dvec3 zzx => new dvec3(z, z, x);
        public dvec3 zzy => new dvec3(z, z, y);
        public dvec3 zzz => new dvec3(z, z, z);
        public dvec2 zz => new dvec2(z, z);
    }
}
