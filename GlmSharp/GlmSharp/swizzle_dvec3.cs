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
    /// Temporary vector of type double with 3 components, used for implementing swizzling for dvec3.
    /// </summary>
    [Serializable]
    public struct swizzle_dvec3
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly double y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly double z;
        
        
        /// <summary>
        /// Constructor for swizzle_dvec3.
        /// </summary>
        internal swizzle_dvec3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns dvec3.xx swizzling.
        /// </summary>
        public dvec2 xx => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec3.xxx swizzling.
        /// </summary>
        public dvec3 xxx => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec3.xxxx swizzling.
        /// </summary>
        public dvec4 xxxx => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.xxxy swizzling.
        /// </summary>
        public dvec4 xxxy => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.xxxz swizzling.
        /// </summary>
        public dvec4 xxxz => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.xxy swizzling.
        /// </summary>
        public dvec3 xxy => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec3.xxyx swizzling.
        /// </summary>
        public dvec4 xxyx => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.xxyy swizzling.
        /// </summary>
        public dvec4 xxyy => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.xxyz swizzling.
        /// </summary>
        public dvec4 xxyz => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.xxz swizzling.
        /// </summary>
        public dvec3 xxz => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec3.xxzx swizzling.
        /// </summary>
        public dvec4 xxzx => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.xxzy swizzling.
        /// </summary>
        public dvec4 xxzy => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.xxzz swizzling.
        /// </summary>
        public dvec4 xxzz => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.xy swizzling.
        /// </summary>
        public dvec2 xy => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec3.xyx swizzling.
        /// </summary>
        public dvec3 xyx => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec3.xyxx swizzling.
        /// </summary>
        public dvec4 xyxx => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.xyxy swizzling.
        /// </summary>
        public dvec4 xyxy => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.xyxz swizzling.
        /// </summary>
        public dvec4 xyxz => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.xyy swizzling.
        /// </summary>
        public dvec3 xyy => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec3.xyyx swizzling.
        /// </summary>
        public dvec4 xyyx => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.xyyy swizzling.
        /// </summary>
        public dvec4 xyyy => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.xyyz swizzling.
        /// </summary>
        public dvec4 xyyz => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.xyz swizzling.
        /// </summary>
        public dvec3 xyz => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec3.xyzx swizzling.
        /// </summary>
        public dvec4 xyzx => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.xyzy swizzling.
        /// </summary>
        public dvec4 xyzy => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.xyzz swizzling.
        /// </summary>
        public dvec4 xyzz => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.xz swizzling.
        /// </summary>
        public dvec2 xz => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec3.xzx swizzling.
        /// </summary>
        public dvec3 xzx => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec3.xzxx swizzling.
        /// </summary>
        public dvec4 xzxx => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.xzxy swizzling.
        /// </summary>
        public dvec4 xzxy => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.xzxz swizzling.
        /// </summary>
        public dvec4 xzxz => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.xzy swizzling.
        /// </summary>
        public dvec3 xzy => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec3.xzyx swizzling.
        /// </summary>
        public dvec4 xzyx => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.xzyy swizzling.
        /// </summary>
        public dvec4 xzyy => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.xzyz swizzling.
        /// </summary>
        public dvec4 xzyz => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.xzz swizzling.
        /// </summary>
        public dvec3 xzz => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec3.xzzx swizzling.
        /// </summary>
        public dvec4 xzzx => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.xzzy swizzling.
        /// </summary>
        public dvec4 xzzy => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.xzzz swizzling.
        /// </summary>
        public dvec4 xzzz => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.yx swizzling.
        /// </summary>
        public dvec2 yx => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec3.yxx swizzling.
        /// </summary>
        public dvec3 yxx => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec3.yxxx swizzling.
        /// </summary>
        public dvec4 yxxx => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.yxxy swizzling.
        /// </summary>
        public dvec4 yxxy => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.yxxz swizzling.
        /// </summary>
        public dvec4 yxxz => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.yxy swizzling.
        /// </summary>
        public dvec3 yxy => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec3.yxyx swizzling.
        /// </summary>
        public dvec4 yxyx => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.yxyy swizzling.
        /// </summary>
        public dvec4 yxyy => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.yxyz swizzling.
        /// </summary>
        public dvec4 yxyz => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.yxz swizzling.
        /// </summary>
        public dvec3 yxz => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec3.yxzx swizzling.
        /// </summary>
        public dvec4 yxzx => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.yxzy swizzling.
        /// </summary>
        public dvec4 yxzy => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.yxzz swizzling.
        /// </summary>
        public dvec4 yxzz => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.yy swizzling.
        /// </summary>
        public dvec2 yy => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec3.yyx swizzling.
        /// </summary>
        public dvec3 yyx => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec3.yyxx swizzling.
        /// </summary>
        public dvec4 yyxx => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.yyxy swizzling.
        /// </summary>
        public dvec4 yyxy => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.yyxz swizzling.
        /// </summary>
        public dvec4 yyxz => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.yyy swizzling.
        /// </summary>
        public dvec3 yyy => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec3.yyyx swizzling.
        /// </summary>
        public dvec4 yyyx => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.yyyy swizzling.
        /// </summary>
        public dvec4 yyyy => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.yyyz swizzling.
        /// </summary>
        public dvec4 yyyz => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.yyz swizzling.
        /// </summary>
        public dvec3 yyz => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec3.yyzx swizzling.
        /// </summary>
        public dvec4 yyzx => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.yyzy swizzling.
        /// </summary>
        public dvec4 yyzy => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.yyzz swizzling.
        /// </summary>
        public dvec4 yyzz => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.yz swizzling.
        /// </summary>
        public dvec2 yz => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec3.yzx swizzling.
        /// </summary>
        public dvec3 yzx => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec3.yzxx swizzling.
        /// </summary>
        public dvec4 yzxx => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.yzxy swizzling.
        /// </summary>
        public dvec4 yzxy => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.yzxz swizzling.
        /// </summary>
        public dvec4 yzxz => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.yzy swizzling.
        /// </summary>
        public dvec3 yzy => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec3.yzyx swizzling.
        /// </summary>
        public dvec4 yzyx => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.yzyy swizzling.
        /// </summary>
        public dvec4 yzyy => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.yzyz swizzling.
        /// </summary>
        public dvec4 yzyz => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.yzz swizzling.
        /// </summary>
        public dvec3 yzz => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec3.yzzx swizzling.
        /// </summary>
        public dvec4 yzzx => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.yzzy swizzling.
        /// </summary>
        public dvec4 yzzy => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.yzzz swizzling.
        /// </summary>
        public dvec4 yzzz => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.zx swizzling.
        /// </summary>
        public dvec2 zx => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec3.zxx swizzling.
        /// </summary>
        public dvec3 zxx => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec3.zxxx swizzling.
        /// </summary>
        public dvec4 zxxx => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.zxxy swizzling.
        /// </summary>
        public dvec4 zxxy => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.zxxz swizzling.
        /// </summary>
        public dvec4 zxxz => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.zxy swizzling.
        /// </summary>
        public dvec3 zxy => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec3.zxyx swizzling.
        /// </summary>
        public dvec4 zxyx => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.zxyy swizzling.
        /// </summary>
        public dvec4 zxyy => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.zxyz swizzling.
        /// </summary>
        public dvec4 zxyz => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.zxz swizzling.
        /// </summary>
        public dvec3 zxz => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec3.zxzx swizzling.
        /// </summary>
        public dvec4 zxzx => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.zxzy swizzling.
        /// </summary>
        public dvec4 zxzy => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.zxzz swizzling.
        /// </summary>
        public dvec4 zxzz => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.zy swizzling.
        /// </summary>
        public dvec2 zy => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec3.zyx swizzling.
        /// </summary>
        public dvec3 zyx => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec3.zyxx swizzling.
        /// </summary>
        public dvec4 zyxx => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.zyxy swizzling.
        /// </summary>
        public dvec4 zyxy => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.zyxz swizzling.
        /// </summary>
        public dvec4 zyxz => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.zyy swizzling.
        /// </summary>
        public dvec3 zyy => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec3.zyyx swizzling.
        /// </summary>
        public dvec4 zyyx => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.zyyy swizzling.
        /// </summary>
        public dvec4 zyyy => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.zyyz swizzling.
        /// </summary>
        public dvec4 zyyz => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.zyz swizzling.
        /// </summary>
        public dvec3 zyz => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec3.zyzx swizzling.
        /// </summary>
        public dvec4 zyzx => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.zyzy swizzling.
        /// </summary>
        public dvec4 zyzy => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.zyzz swizzling.
        /// </summary>
        public dvec4 zyzz => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.zz swizzling.
        /// </summary>
        public dvec2 zz => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec3.zzx swizzling.
        /// </summary>
        public dvec3 zzx => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec3.zzxx swizzling.
        /// </summary>
        public dvec4 zzxx => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.zzxy swizzling.
        /// </summary>
        public dvec4 zzxy => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.zzxz swizzling.
        /// </summary>
        public dvec4 zzxz => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.zzy swizzling.
        /// </summary>
        public dvec3 zzy => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec3.zzyx swizzling.
        /// </summary>
        public dvec4 zzyx => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.zzyy swizzling.
        /// </summary>
        public dvec4 zzyy => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.zzyz swizzling.
        /// </summary>
        public dvec4 zzyz => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.zzz swizzling.
        /// </summary>
        public dvec3 zzz => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec3.zzzx swizzling.
        /// </summary>
        public dvec4 zzzx => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.zzzy swizzling.
        /// </summary>
        public dvec4 zzzy => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.zzzz swizzling.
        /// </summary>
        public dvec4 zzzz => new dvec4(z, z, z, z);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns dvec3.rr swizzling.
        /// </summary>
        public dvec2 rr => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec3.rrr swizzling.
        /// </summary>
        public dvec3 rrr => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec3.rrrr swizzling.
        /// </summary>
        public dvec4 rrrr => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec3.rrrg swizzling.
        /// </summary>
        public dvec4 rrrg => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec3.rrrb swizzling.
        /// </summary>
        public dvec4 rrrb => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec3.rrg swizzling.
        /// </summary>
        public dvec3 rrg => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec3.rrgr swizzling.
        /// </summary>
        public dvec4 rrgr => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec3.rrgg swizzling.
        /// </summary>
        public dvec4 rrgg => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec3.rrgb swizzling.
        /// </summary>
        public dvec4 rrgb => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec3.rrb swizzling.
        /// </summary>
        public dvec3 rrb => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec3.rrbr swizzling.
        /// </summary>
        public dvec4 rrbr => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec3.rrbg swizzling.
        /// </summary>
        public dvec4 rrbg => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec3.rrbb swizzling.
        /// </summary>
        public dvec4 rrbb => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec3.rg swizzling.
        /// </summary>
        public dvec2 rg => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec3.rgr swizzling.
        /// </summary>
        public dvec3 rgr => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec3.rgrr swizzling.
        /// </summary>
        public dvec4 rgrr => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec3.rgrg swizzling.
        /// </summary>
        public dvec4 rgrg => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec3.rgrb swizzling.
        /// </summary>
        public dvec4 rgrb => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec3.rgg swizzling.
        /// </summary>
        public dvec3 rgg => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec3.rggr swizzling.
        /// </summary>
        public dvec4 rggr => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec3.rggg swizzling.
        /// </summary>
        public dvec4 rggg => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec3.rggb swizzling.
        /// </summary>
        public dvec4 rggb => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec3.rgb swizzling.
        /// </summary>
        public dvec3 rgb => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec3.rgbr swizzling.
        /// </summary>
        public dvec4 rgbr => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec3.rgbg swizzling.
        /// </summary>
        public dvec4 rgbg => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec3.rgbb swizzling.
        /// </summary>
        public dvec4 rgbb => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec3.rb swizzling.
        /// </summary>
        public dvec2 rb => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec3.rbr swizzling.
        /// </summary>
        public dvec3 rbr => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec3.rbrr swizzling.
        /// </summary>
        public dvec4 rbrr => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec3.rbrg swizzling.
        /// </summary>
        public dvec4 rbrg => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec3.rbrb swizzling.
        /// </summary>
        public dvec4 rbrb => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec3.rbg swizzling.
        /// </summary>
        public dvec3 rbg => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec3.rbgr swizzling.
        /// </summary>
        public dvec4 rbgr => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec3.rbgg swizzling.
        /// </summary>
        public dvec4 rbgg => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec3.rbgb swizzling.
        /// </summary>
        public dvec4 rbgb => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec3.rbb swizzling.
        /// </summary>
        public dvec3 rbb => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec3.rbbr swizzling.
        /// </summary>
        public dvec4 rbbr => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec3.rbbg swizzling.
        /// </summary>
        public dvec4 rbbg => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec3.rbbb swizzling.
        /// </summary>
        public dvec4 rbbb => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec3.gr swizzling.
        /// </summary>
        public dvec2 gr => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec3.grr swizzling.
        /// </summary>
        public dvec3 grr => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec3.grrr swizzling.
        /// </summary>
        public dvec4 grrr => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec3.grrg swizzling.
        /// </summary>
        public dvec4 grrg => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec3.grrb swizzling.
        /// </summary>
        public dvec4 grrb => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec3.grg swizzling.
        /// </summary>
        public dvec3 grg => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec3.grgr swizzling.
        /// </summary>
        public dvec4 grgr => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec3.grgg swizzling.
        /// </summary>
        public dvec4 grgg => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec3.grgb swizzling.
        /// </summary>
        public dvec4 grgb => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec3.grb swizzling.
        /// </summary>
        public dvec3 grb => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec3.grbr swizzling.
        /// </summary>
        public dvec4 grbr => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec3.grbg swizzling.
        /// </summary>
        public dvec4 grbg => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec3.grbb swizzling.
        /// </summary>
        public dvec4 grbb => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec3.gg swizzling.
        /// </summary>
        public dvec2 gg => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec3.ggr swizzling.
        /// </summary>
        public dvec3 ggr => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec3.ggrr swizzling.
        /// </summary>
        public dvec4 ggrr => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec3.ggrg swizzling.
        /// </summary>
        public dvec4 ggrg => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec3.ggrb swizzling.
        /// </summary>
        public dvec4 ggrb => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec3.ggg swizzling.
        /// </summary>
        public dvec3 ggg => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec3.gggr swizzling.
        /// </summary>
        public dvec4 gggr => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec3.gggg swizzling.
        /// </summary>
        public dvec4 gggg => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec3.gggb swizzling.
        /// </summary>
        public dvec4 gggb => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec3.ggb swizzling.
        /// </summary>
        public dvec3 ggb => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec3.ggbr swizzling.
        /// </summary>
        public dvec4 ggbr => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec3.ggbg swizzling.
        /// </summary>
        public dvec4 ggbg => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec3.ggbb swizzling.
        /// </summary>
        public dvec4 ggbb => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec3.gb swizzling.
        /// </summary>
        public dvec2 gb => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec3.gbr swizzling.
        /// </summary>
        public dvec3 gbr => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec3.gbrr swizzling.
        /// </summary>
        public dvec4 gbrr => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec3.gbrg swizzling.
        /// </summary>
        public dvec4 gbrg => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec3.gbrb swizzling.
        /// </summary>
        public dvec4 gbrb => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec3.gbg swizzling.
        /// </summary>
        public dvec3 gbg => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec3.gbgr swizzling.
        /// </summary>
        public dvec4 gbgr => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec3.gbgg swizzling.
        /// </summary>
        public dvec4 gbgg => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec3.gbgb swizzling.
        /// </summary>
        public dvec4 gbgb => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec3.gbb swizzling.
        /// </summary>
        public dvec3 gbb => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec3.gbbr swizzling.
        /// </summary>
        public dvec4 gbbr => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec3.gbbg swizzling.
        /// </summary>
        public dvec4 gbbg => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec3.gbbb swizzling.
        /// </summary>
        public dvec4 gbbb => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec3.br swizzling.
        /// </summary>
        public dvec2 br => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec3.brr swizzling.
        /// </summary>
        public dvec3 brr => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec3.brrr swizzling.
        /// </summary>
        public dvec4 brrr => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec3.brrg swizzling.
        /// </summary>
        public dvec4 brrg => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec3.brrb swizzling.
        /// </summary>
        public dvec4 brrb => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec3.brg swizzling.
        /// </summary>
        public dvec3 brg => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec3.brgr swizzling.
        /// </summary>
        public dvec4 brgr => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec3.brgg swizzling.
        /// </summary>
        public dvec4 brgg => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec3.brgb swizzling.
        /// </summary>
        public dvec4 brgb => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec3.brb swizzling.
        /// </summary>
        public dvec3 brb => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec3.brbr swizzling.
        /// </summary>
        public dvec4 brbr => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec3.brbg swizzling.
        /// </summary>
        public dvec4 brbg => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec3.brbb swizzling.
        /// </summary>
        public dvec4 brbb => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec3.bg swizzling.
        /// </summary>
        public dvec2 bg => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec3.bgr swizzling.
        /// </summary>
        public dvec3 bgr => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec3.bgrr swizzling.
        /// </summary>
        public dvec4 bgrr => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec3.bgrg swizzling.
        /// </summary>
        public dvec4 bgrg => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec3.bgrb swizzling.
        /// </summary>
        public dvec4 bgrb => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec3.bgg swizzling.
        /// </summary>
        public dvec3 bgg => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec3.bggr swizzling.
        /// </summary>
        public dvec4 bggr => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec3.bggg swizzling.
        /// </summary>
        public dvec4 bggg => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec3.bggb swizzling.
        /// </summary>
        public dvec4 bggb => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec3.bgb swizzling.
        /// </summary>
        public dvec3 bgb => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec3.bgbr swizzling.
        /// </summary>
        public dvec4 bgbr => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec3.bgbg swizzling.
        /// </summary>
        public dvec4 bgbg => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec3.bgbb swizzling.
        /// </summary>
        public dvec4 bgbb => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec3.bb swizzling.
        /// </summary>
        public dvec2 bb => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec3.bbr swizzling.
        /// </summary>
        public dvec3 bbr => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec3.bbrr swizzling.
        /// </summary>
        public dvec4 bbrr => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec3.bbrg swizzling.
        /// </summary>
        public dvec4 bbrg => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec3.bbrb swizzling.
        /// </summary>
        public dvec4 bbrb => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec3.bbg swizzling.
        /// </summary>
        public dvec3 bbg => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec3.bbgr swizzling.
        /// </summary>
        public dvec4 bbgr => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec3.bbgg swizzling.
        /// </summary>
        public dvec4 bbgg => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec3.bbgb swizzling.
        /// </summary>
        public dvec4 bbgb => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec3.bbb swizzling.
        /// </summary>
        public dvec3 bbb => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec3.bbbr swizzling.
        /// </summary>
        public dvec4 bbbr => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec3.bbbg swizzling.
        /// </summary>
        public dvec4 bbbg => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec3.bbbb swizzling.
        /// </summary>
        public dvec4 bbbb => new dvec4(z, z, z, z);
    }
}
