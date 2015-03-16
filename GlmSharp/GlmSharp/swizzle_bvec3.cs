using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    
    /// <summary>
    /// Temporary vector of type bool with 3 components, used for implementing swizzling for bvec3.
    /// </summary>
    [Serializable]
    public struct swizzle_bvec3
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly bool z;
        
        
        /// <summary>
        /// Constructor for swizzle_bvec3.
        /// </summary>
        internal swizzle_bvec3(bool x, bool y, bool z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns bvec3.xx swizzling.
        /// </summary>
        public bvec2 xx => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec3.xxx swizzling.
        /// </summary>
        public bvec3 xxx => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec3.xxxx swizzling.
        /// </summary>
        public bvec4 xxxx => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.xxxy swizzling.
        /// </summary>
        public bvec4 xxxy => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.xxxz swizzling.
        /// </summary>
        public bvec4 xxxz => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.xxy swizzling.
        /// </summary>
        public bvec3 xxy => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec3.xxyx swizzling.
        /// </summary>
        public bvec4 xxyx => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.xxyy swizzling.
        /// </summary>
        public bvec4 xxyy => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.xxyz swizzling.
        /// </summary>
        public bvec4 xxyz => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.xxz swizzling.
        /// </summary>
        public bvec3 xxz => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec3.xxzx swizzling.
        /// </summary>
        public bvec4 xxzx => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.xxzy swizzling.
        /// </summary>
        public bvec4 xxzy => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.xxzz swizzling.
        /// </summary>
        public bvec4 xxzz => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.xy swizzling.
        /// </summary>
        public bvec2 xy => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec3.xyx swizzling.
        /// </summary>
        public bvec3 xyx => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec3.xyxx swizzling.
        /// </summary>
        public bvec4 xyxx => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.xyxy swizzling.
        /// </summary>
        public bvec4 xyxy => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.xyxz swizzling.
        /// </summary>
        public bvec4 xyxz => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.xyy swizzling.
        /// </summary>
        public bvec3 xyy => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec3.xyyx swizzling.
        /// </summary>
        public bvec4 xyyx => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.xyyy swizzling.
        /// </summary>
        public bvec4 xyyy => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.xyyz swizzling.
        /// </summary>
        public bvec4 xyyz => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.xyz swizzling.
        /// </summary>
        public bvec3 xyz => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec3.xyzx swizzling.
        /// </summary>
        public bvec4 xyzx => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.xyzy swizzling.
        /// </summary>
        public bvec4 xyzy => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.xyzz swizzling.
        /// </summary>
        public bvec4 xyzz => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.xz swizzling.
        /// </summary>
        public bvec2 xz => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec3.xzx swizzling.
        /// </summary>
        public bvec3 xzx => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec3.xzxx swizzling.
        /// </summary>
        public bvec4 xzxx => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.xzxy swizzling.
        /// </summary>
        public bvec4 xzxy => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.xzxz swizzling.
        /// </summary>
        public bvec4 xzxz => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.xzy swizzling.
        /// </summary>
        public bvec3 xzy => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec3.xzyx swizzling.
        /// </summary>
        public bvec4 xzyx => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.xzyy swizzling.
        /// </summary>
        public bvec4 xzyy => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.xzyz swizzling.
        /// </summary>
        public bvec4 xzyz => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.xzz swizzling.
        /// </summary>
        public bvec3 xzz => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec3.xzzx swizzling.
        /// </summary>
        public bvec4 xzzx => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.xzzy swizzling.
        /// </summary>
        public bvec4 xzzy => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.xzzz swizzling.
        /// </summary>
        public bvec4 xzzz => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.yx swizzling.
        /// </summary>
        public bvec2 yx => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec3.yxx swizzling.
        /// </summary>
        public bvec3 yxx => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec3.yxxx swizzling.
        /// </summary>
        public bvec4 yxxx => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.yxxy swizzling.
        /// </summary>
        public bvec4 yxxy => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.yxxz swizzling.
        /// </summary>
        public bvec4 yxxz => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.yxy swizzling.
        /// </summary>
        public bvec3 yxy => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec3.yxyx swizzling.
        /// </summary>
        public bvec4 yxyx => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.yxyy swizzling.
        /// </summary>
        public bvec4 yxyy => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.yxyz swizzling.
        /// </summary>
        public bvec4 yxyz => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.yxz swizzling.
        /// </summary>
        public bvec3 yxz => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec3.yxzx swizzling.
        /// </summary>
        public bvec4 yxzx => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.yxzy swizzling.
        /// </summary>
        public bvec4 yxzy => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.yxzz swizzling.
        /// </summary>
        public bvec4 yxzz => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.yy swizzling.
        /// </summary>
        public bvec2 yy => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec3.yyx swizzling.
        /// </summary>
        public bvec3 yyx => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec3.yyxx swizzling.
        /// </summary>
        public bvec4 yyxx => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.yyxy swizzling.
        /// </summary>
        public bvec4 yyxy => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.yyxz swizzling.
        /// </summary>
        public bvec4 yyxz => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.yyy swizzling.
        /// </summary>
        public bvec3 yyy => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec3.yyyx swizzling.
        /// </summary>
        public bvec4 yyyx => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.yyyy swizzling.
        /// </summary>
        public bvec4 yyyy => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.yyyz swizzling.
        /// </summary>
        public bvec4 yyyz => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.yyz swizzling.
        /// </summary>
        public bvec3 yyz => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec3.yyzx swizzling.
        /// </summary>
        public bvec4 yyzx => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.yyzy swizzling.
        /// </summary>
        public bvec4 yyzy => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.yyzz swizzling.
        /// </summary>
        public bvec4 yyzz => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.yz swizzling.
        /// </summary>
        public bvec2 yz => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec3.yzx swizzling.
        /// </summary>
        public bvec3 yzx => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec3.yzxx swizzling.
        /// </summary>
        public bvec4 yzxx => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.yzxy swizzling.
        /// </summary>
        public bvec4 yzxy => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.yzxz swizzling.
        /// </summary>
        public bvec4 yzxz => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.yzy swizzling.
        /// </summary>
        public bvec3 yzy => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec3.yzyx swizzling.
        /// </summary>
        public bvec4 yzyx => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.yzyy swizzling.
        /// </summary>
        public bvec4 yzyy => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.yzyz swizzling.
        /// </summary>
        public bvec4 yzyz => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.yzz swizzling.
        /// </summary>
        public bvec3 yzz => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec3.yzzx swizzling.
        /// </summary>
        public bvec4 yzzx => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.yzzy swizzling.
        /// </summary>
        public bvec4 yzzy => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.yzzz swizzling.
        /// </summary>
        public bvec4 yzzz => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.zx swizzling.
        /// </summary>
        public bvec2 zx => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec3.zxx swizzling.
        /// </summary>
        public bvec3 zxx => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec3.zxxx swizzling.
        /// </summary>
        public bvec4 zxxx => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.zxxy swizzling.
        /// </summary>
        public bvec4 zxxy => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.zxxz swizzling.
        /// </summary>
        public bvec4 zxxz => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.zxy swizzling.
        /// </summary>
        public bvec3 zxy => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec3.zxyx swizzling.
        /// </summary>
        public bvec4 zxyx => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.zxyy swizzling.
        /// </summary>
        public bvec4 zxyy => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.zxyz swizzling.
        /// </summary>
        public bvec4 zxyz => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.zxz swizzling.
        /// </summary>
        public bvec3 zxz => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec3.zxzx swizzling.
        /// </summary>
        public bvec4 zxzx => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.zxzy swizzling.
        /// </summary>
        public bvec4 zxzy => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.zxzz swizzling.
        /// </summary>
        public bvec4 zxzz => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.zy swizzling.
        /// </summary>
        public bvec2 zy => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec3.zyx swizzling.
        /// </summary>
        public bvec3 zyx => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec3.zyxx swizzling.
        /// </summary>
        public bvec4 zyxx => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.zyxy swizzling.
        /// </summary>
        public bvec4 zyxy => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.zyxz swizzling.
        /// </summary>
        public bvec4 zyxz => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.zyy swizzling.
        /// </summary>
        public bvec3 zyy => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec3.zyyx swizzling.
        /// </summary>
        public bvec4 zyyx => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.zyyy swizzling.
        /// </summary>
        public bvec4 zyyy => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.zyyz swizzling.
        /// </summary>
        public bvec4 zyyz => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.zyz swizzling.
        /// </summary>
        public bvec3 zyz => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec3.zyzx swizzling.
        /// </summary>
        public bvec4 zyzx => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.zyzy swizzling.
        /// </summary>
        public bvec4 zyzy => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.zyzz swizzling.
        /// </summary>
        public bvec4 zyzz => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.zz swizzling.
        /// </summary>
        public bvec2 zz => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec3.zzx swizzling.
        /// </summary>
        public bvec3 zzx => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec3.zzxx swizzling.
        /// </summary>
        public bvec4 zzxx => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.zzxy swizzling.
        /// </summary>
        public bvec4 zzxy => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.zzxz swizzling.
        /// </summary>
        public bvec4 zzxz => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.zzy swizzling.
        /// </summary>
        public bvec3 zzy => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec3.zzyx swizzling.
        /// </summary>
        public bvec4 zzyx => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.zzyy swizzling.
        /// </summary>
        public bvec4 zzyy => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.zzyz swizzling.
        /// </summary>
        public bvec4 zzyz => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.zzz swizzling.
        /// </summary>
        public bvec3 zzz => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec3.zzzx swizzling.
        /// </summary>
        public bvec4 zzzx => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.zzzy swizzling.
        /// </summary>
        public bvec4 zzzy => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.zzzz swizzling.
        /// </summary>
        public bvec4 zzzz => new bvec4(z, z, z, z);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns bvec3.rr swizzling.
        /// </summary>
        public bvec2 rr => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec3.rrr swizzling.
        /// </summary>
        public bvec3 rrr => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec3.rrrr swizzling.
        /// </summary>
        public bvec4 rrrr => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec3.rrrg swizzling.
        /// </summary>
        public bvec4 rrrg => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec3.rrrb swizzling.
        /// </summary>
        public bvec4 rrrb => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec3.rrg swizzling.
        /// </summary>
        public bvec3 rrg => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec3.rrgr swizzling.
        /// </summary>
        public bvec4 rrgr => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec3.rrgg swizzling.
        /// </summary>
        public bvec4 rrgg => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec3.rrgb swizzling.
        /// </summary>
        public bvec4 rrgb => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec3.rrb swizzling.
        /// </summary>
        public bvec3 rrb => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec3.rrbr swizzling.
        /// </summary>
        public bvec4 rrbr => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec3.rrbg swizzling.
        /// </summary>
        public bvec4 rrbg => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec3.rrbb swizzling.
        /// </summary>
        public bvec4 rrbb => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec3.rg swizzling.
        /// </summary>
        public bvec2 rg => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec3.rgr swizzling.
        /// </summary>
        public bvec3 rgr => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec3.rgrr swizzling.
        /// </summary>
        public bvec4 rgrr => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec3.rgrg swizzling.
        /// </summary>
        public bvec4 rgrg => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec3.rgrb swizzling.
        /// </summary>
        public bvec4 rgrb => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec3.rgg swizzling.
        /// </summary>
        public bvec3 rgg => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec3.rggr swizzling.
        /// </summary>
        public bvec4 rggr => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec3.rggg swizzling.
        /// </summary>
        public bvec4 rggg => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec3.rggb swizzling.
        /// </summary>
        public bvec4 rggb => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec3.rgb swizzling.
        /// </summary>
        public bvec3 rgb => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec3.rgbr swizzling.
        /// </summary>
        public bvec4 rgbr => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec3.rgbg swizzling.
        /// </summary>
        public bvec4 rgbg => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec3.rgbb swizzling.
        /// </summary>
        public bvec4 rgbb => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec3.rb swizzling.
        /// </summary>
        public bvec2 rb => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec3.rbr swizzling.
        /// </summary>
        public bvec3 rbr => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec3.rbrr swizzling.
        /// </summary>
        public bvec4 rbrr => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec3.rbrg swizzling.
        /// </summary>
        public bvec4 rbrg => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec3.rbrb swizzling.
        /// </summary>
        public bvec4 rbrb => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec3.rbg swizzling.
        /// </summary>
        public bvec3 rbg => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec3.rbgr swizzling.
        /// </summary>
        public bvec4 rbgr => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec3.rbgg swizzling.
        /// </summary>
        public bvec4 rbgg => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec3.rbgb swizzling.
        /// </summary>
        public bvec4 rbgb => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec3.rbb swizzling.
        /// </summary>
        public bvec3 rbb => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec3.rbbr swizzling.
        /// </summary>
        public bvec4 rbbr => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec3.rbbg swizzling.
        /// </summary>
        public bvec4 rbbg => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec3.rbbb swizzling.
        /// </summary>
        public bvec4 rbbb => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec3.gr swizzling.
        /// </summary>
        public bvec2 gr => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec3.grr swizzling.
        /// </summary>
        public bvec3 grr => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec3.grrr swizzling.
        /// </summary>
        public bvec4 grrr => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec3.grrg swizzling.
        /// </summary>
        public bvec4 grrg => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec3.grrb swizzling.
        /// </summary>
        public bvec4 grrb => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec3.grg swizzling.
        /// </summary>
        public bvec3 grg => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec3.grgr swizzling.
        /// </summary>
        public bvec4 grgr => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec3.grgg swizzling.
        /// </summary>
        public bvec4 grgg => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec3.grgb swizzling.
        /// </summary>
        public bvec4 grgb => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec3.grb swizzling.
        /// </summary>
        public bvec3 grb => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec3.grbr swizzling.
        /// </summary>
        public bvec4 grbr => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec3.grbg swizzling.
        /// </summary>
        public bvec4 grbg => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec3.grbb swizzling.
        /// </summary>
        public bvec4 grbb => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec3.gg swizzling.
        /// </summary>
        public bvec2 gg => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec3.ggr swizzling.
        /// </summary>
        public bvec3 ggr => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec3.ggrr swizzling.
        /// </summary>
        public bvec4 ggrr => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec3.ggrg swizzling.
        /// </summary>
        public bvec4 ggrg => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec3.ggrb swizzling.
        /// </summary>
        public bvec4 ggrb => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec3.ggg swizzling.
        /// </summary>
        public bvec3 ggg => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec3.gggr swizzling.
        /// </summary>
        public bvec4 gggr => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec3.gggg swizzling.
        /// </summary>
        public bvec4 gggg => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec3.gggb swizzling.
        /// </summary>
        public bvec4 gggb => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec3.ggb swizzling.
        /// </summary>
        public bvec3 ggb => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec3.ggbr swizzling.
        /// </summary>
        public bvec4 ggbr => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec3.ggbg swizzling.
        /// </summary>
        public bvec4 ggbg => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec3.ggbb swizzling.
        /// </summary>
        public bvec4 ggbb => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec3.gb swizzling.
        /// </summary>
        public bvec2 gb => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec3.gbr swizzling.
        /// </summary>
        public bvec3 gbr => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec3.gbrr swizzling.
        /// </summary>
        public bvec4 gbrr => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec3.gbrg swizzling.
        /// </summary>
        public bvec4 gbrg => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec3.gbrb swizzling.
        /// </summary>
        public bvec4 gbrb => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec3.gbg swizzling.
        /// </summary>
        public bvec3 gbg => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec3.gbgr swizzling.
        /// </summary>
        public bvec4 gbgr => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec3.gbgg swizzling.
        /// </summary>
        public bvec4 gbgg => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec3.gbgb swizzling.
        /// </summary>
        public bvec4 gbgb => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec3.gbb swizzling.
        /// </summary>
        public bvec3 gbb => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec3.gbbr swizzling.
        /// </summary>
        public bvec4 gbbr => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec3.gbbg swizzling.
        /// </summary>
        public bvec4 gbbg => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec3.gbbb swizzling.
        /// </summary>
        public bvec4 gbbb => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec3.br swizzling.
        /// </summary>
        public bvec2 br => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec3.brr swizzling.
        /// </summary>
        public bvec3 brr => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec3.brrr swizzling.
        /// </summary>
        public bvec4 brrr => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec3.brrg swizzling.
        /// </summary>
        public bvec4 brrg => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec3.brrb swizzling.
        /// </summary>
        public bvec4 brrb => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec3.brg swizzling.
        /// </summary>
        public bvec3 brg => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec3.brgr swizzling.
        /// </summary>
        public bvec4 brgr => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec3.brgg swizzling.
        /// </summary>
        public bvec4 brgg => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec3.brgb swizzling.
        /// </summary>
        public bvec4 brgb => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec3.brb swizzling.
        /// </summary>
        public bvec3 brb => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec3.brbr swizzling.
        /// </summary>
        public bvec4 brbr => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec3.brbg swizzling.
        /// </summary>
        public bvec4 brbg => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec3.brbb swizzling.
        /// </summary>
        public bvec4 brbb => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec3.bg swizzling.
        /// </summary>
        public bvec2 bg => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec3.bgr swizzling.
        /// </summary>
        public bvec3 bgr => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec3.bgrr swizzling.
        /// </summary>
        public bvec4 bgrr => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec3.bgrg swizzling.
        /// </summary>
        public bvec4 bgrg => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec3.bgrb swizzling.
        /// </summary>
        public bvec4 bgrb => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec3.bgg swizzling.
        /// </summary>
        public bvec3 bgg => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec3.bggr swizzling.
        /// </summary>
        public bvec4 bggr => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec3.bggg swizzling.
        /// </summary>
        public bvec4 bggg => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec3.bggb swizzling.
        /// </summary>
        public bvec4 bggb => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec3.bgb swizzling.
        /// </summary>
        public bvec3 bgb => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec3.bgbr swizzling.
        /// </summary>
        public bvec4 bgbr => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec3.bgbg swizzling.
        /// </summary>
        public bvec4 bgbg => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec3.bgbb swizzling.
        /// </summary>
        public bvec4 bgbb => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec3.bb swizzling.
        /// </summary>
        public bvec2 bb => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec3.bbr swizzling.
        /// </summary>
        public bvec3 bbr => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec3.bbrr swizzling.
        /// </summary>
        public bvec4 bbrr => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec3.bbrg swizzling.
        /// </summary>
        public bvec4 bbrg => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec3.bbrb swizzling.
        /// </summary>
        public bvec4 bbrb => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec3.bbg swizzling.
        /// </summary>
        public bvec3 bbg => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec3.bbgr swizzling.
        /// </summary>
        public bvec4 bbgr => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec3.bbgg swizzling.
        /// </summary>
        public bvec4 bbgg => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec3.bbgb swizzling.
        /// </summary>
        public bvec4 bbgb => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec3.bbb swizzling.
        /// </summary>
        public bvec3 bbb => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec3.bbbr swizzling.
        /// </summary>
        public bvec4 bbbr => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec3.bbbg swizzling.
        /// </summary>
        public bvec4 bbbg => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec3.bbbb swizzling.
        /// </summary>
        public bvec4 bbbb => new bvec4(z, z, z, z);
    }
}
