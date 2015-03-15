using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_gvec3<T>
    {
        public readonly T x;
        public readonly T y;
        public readonly T z;
        
        public swizzle_gvec3(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        public gvec3<T> xxx => new gvec3<T>(x, x, x);
        public gvec3<T> xxy => new gvec3<T>(x, x, y);
        public gvec3<T> xxz => new gvec3<T>(x, x, z);
        public gvec2<T> xx => new gvec2<T>(x, x);
        public gvec3<T> xyx => new gvec3<T>(x, y, x);
        public gvec3<T> xyy => new gvec3<T>(x, y, y);
        public gvec3<T> xyz => new gvec3<T>(x, y, z);
        public gvec2<T> xy => new gvec2<T>(x, y);
        public gvec3<T> xzx => new gvec3<T>(x, z, x);
        public gvec3<T> xzy => new gvec3<T>(x, z, y);
        public gvec3<T> xzz => new gvec3<T>(x, z, z);
        public gvec2<T> xz => new gvec2<T>(x, z);
        public gvec3<T> yxx => new gvec3<T>(y, x, x);
        public gvec3<T> yxy => new gvec3<T>(y, x, y);
        public gvec3<T> yxz => new gvec3<T>(y, x, z);
        public gvec2<T> yx => new gvec2<T>(y, x);
        public gvec3<T> yyx => new gvec3<T>(y, y, x);
        public gvec3<T> yyy => new gvec3<T>(y, y, y);
        public gvec3<T> yyz => new gvec3<T>(y, y, z);
        public gvec2<T> yy => new gvec2<T>(y, y);
        public gvec3<T> yzx => new gvec3<T>(y, z, x);
        public gvec3<T> yzy => new gvec3<T>(y, z, y);
        public gvec3<T> yzz => new gvec3<T>(y, z, z);
        public gvec2<T> yz => new gvec2<T>(y, z);
        public gvec3<T> zxx => new gvec3<T>(z, x, x);
        public gvec3<T> zxy => new gvec3<T>(z, x, y);
        public gvec3<T> zxz => new gvec3<T>(z, x, z);
        public gvec2<T> zx => new gvec2<T>(z, x);
        public gvec3<T> zyx => new gvec3<T>(z, y, x);
        public gvec3<T> zyy => new gvec3<T>(z, y, y);
        public gvec3<T> zyz => new gvec3<T>(z, y, z);
        public gvec2<T> zy => new gvec2<T>(z, y);
        public gvec3<T> zzx => new gvec3<T>(z, z, x);
        public gvec3<T> zzy => new gvec3<T>(z, z, y);
        public gvec3<T> zzz => new gvec3<T>(z, z, z);
        public gvec2<T> zz => new gvec2<T>(z, z);
    }
}
