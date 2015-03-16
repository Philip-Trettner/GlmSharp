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
    /// Temporary vector of type long with 3 components, used for implementing swizzling for lvec3.
    /// </summary>
    [Serializable]
    public struct swizzle_lvec3
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly long x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly long y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly long z;
        
        
        /// <summary>
        /// Constructor for swizzle_lvec3.
        /// </summary>
        internal swizzle_lvec3(long x, long y, long z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns lvec3.xx swizzling.
        /// </summary>
        public lvec2 xx => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec3.xxx swizzling.
        /// </summary>
        public lvec3 xxx => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec3.xxxx swizzling.
        /// </summary>
        public lvec4 xxxx => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.xxxy swizzling.
        /// </summary>
        public lvec4 xxxy => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.xxxz swizzling.
        /// </summary>
        public lvec4 xxxz => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.xxy swizzling.
        /// </summary>
        public lvec3 xxy => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec3.xxyx swizzling.
        /// </summary>
        public lvec4 xxyx => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.xxyy swizzling.
        /// </summary>
        public lvec4 xxyy => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.xxyz swizzling.
        /// </summary>
        public lvec4 xxyz => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.xxz swizzling.
        /// </summary>
        public lvec3 xxz => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec3.xxzx swizzling.
        /// </summary>
        public lvec4 xxzx => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.xxzy swizzling.
        /// </summary>
        public lvec4 xxzy => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.xxzz swizzling.
        /// </summary>
        public lvec4 xxzz => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.xy swizzling.
        /// </summary>
        public lvec2 xy => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec3.xyx swizzling.
        /// </summary>
        public lvec3 xyx => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec3.xyxx swizzling.
        /// </summary>
        public lvec4 xyxx => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.xyxy swizzling.
        /// </summary>
        public lvec4 xyxy => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.xyxz swizzling.
        /// </summary>
        public lvec4 xyxz => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.xyy swizzling.
        /// </summary>
        public lvec3 xyy => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec3.xyyx swizzling.
        /// </summary>
        public lvec4 xyyx => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.xyyy swizzling.
        /// </summary>
        public lvec4 xyyy => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.xyyz swizzling.
        /// </summary>
        public lvec4 xyyz => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.xyz swizzling.
        /// </summary>
        public lvec3 xyz => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec3.xyzx swizzling.
        /// </summary>
        public lvec4 xyzx => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.xyzy swizzling.
        /// </summary>
        public lvec4 xyzy => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.xyzz swizzling.
        /// </summary>
        public lvec4 xyzz => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.xz swizzling.
        /// </summary>
        public lvec2 xz => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec3.xzx swizzling.
        /// </summary>
        public lvec3 xzx => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec3.xzxx swizzling.
        /// </summary>
        public lvec4 xzxx => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.xzxy swizzling.
        /// </summary>
        public lvec4 xzxy => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.xzxz swizzling.
        /// </summary>
        public lvec4 xzxz => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.xzy swizzling.
        /// </summary>
        public lvec3 xzy => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec3.xzyx swizzling.
        /// </summary>
        public lvec4 xzyx => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.xzyy swizzling.
        /// </summary>
        public lvec4 xzyy => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.xzyz swizzling.
        /// </summary>
        public lvec4 xzyz => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.xzz swizzling.
        /// </summary>
        public lvec3 xzz => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec3.xzzx swizzling.
        /// </summary>
        public lvec4 xzzx => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.xzzy swizzling.
        /// </summary>
        public lvec4 xzzy => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.xzzz swizzling.
        /// </summary>
        public lvec4 xzzz => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.yx swizzling.
        /// </summary>
        public lvec2 yx => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec3.yxx swizzling.
        /// </summary>
        public lvec3 yxx => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec3.yxxx swizzling.
        /// </summary>
        public lvec4 yxxx => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.yxxy swizzling.
        /// </summary>
        public lvec4 yxxy => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.yxxz swizzling.
        /// </summary>
        public lvec4 yxxz => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.yxy swizzling.
        /// </summary>
        public lvec3 yxy => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec3.yxyx swizzling.
        /// </summary>
        public lvec4 yxyx => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.yxyy swizzling.
        /// </summary>
        public lvec4 yxyy => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.yxyz swizzling.
        /// </summary>
        public lvec4 yxyz => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.yxz swizzling.
        /// </summary>
        public lvec3 yxz => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec3.yxzx swizzling.
        /// </summary>
        public lvec4 yxzx => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.yxzy swizzling.
        /// </summary>
        public lvec4 yxzy => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.yxzz swizzling.
        /// </summary>
        public lvec4 yxzz => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.yy swizzling.
        /// </summary>
        public lvec2 yy => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec3.yyx swizzling.
        /// </summary>
        public lvec3 yyx => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec3.yyxx swizzling.
        /// </summary>
        public lvec4 yyxx => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.yyxy swizzling.
        /// </summary>
        public lvec4 yyxy => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.yyxz swizzling.
        /// </summary>
        public lvec4 yyxz => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.yyy swizzling.
        /// </summary>
        public lvec3 yyy => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec3.yyyx swizzling.
        /// </summary>
        public lvec4 yyyx => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.yyyy swizzling.
        /// </summary>
        public lvec4 yyyy => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.yyyz swizzling.
        /// </summary>
        public lvec4 yyyz => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.yyz swizzling.
        /// </summary>
        public lvec3 yyz => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec3.yyzx swizzling.
        /// </summary>
        public lvec4 yyzx => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.yyzy swizzling.
        /// </summary>
        public lvec4 yyzy => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.yyzz swizzling.
        /// </summary>
        public lvec4 yyzz => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.yz swizzling.
        /// </summary>
        public lvec2 yz => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec3.yzx swizzling.
        /// </summary>
        public lvec3 yzx => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec3.yzxx swizzling.
        /// </summary>
        public lvec4 yzxx => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.yzxy swizzling.
        /// </summary>
        public lvec4 yzxy => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.yzxz swizzling.
        /// </summary>
        public lvec4 yzxz => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.yzy swizzling.
        /// </summary>
        public lvec3 yzy => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec3.yzyx swizzling.
        /// </summary>
        public lvec4 yzyx => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.yzyy swizzling.
        /// </summary>
        public lvec4 yzyy => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.yzyz swizzling.
        /// </summary>
        public lvec4 yzyz => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.yzz swizzling.
        /// </summary>
        public lvec3 yzz => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec3.yzzx swizzling.
        /// </summary>
        public lvec4 yzzx => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.yzzy swizzling.
        /// </summary>
        public lvec4 yzzy => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.yzzz swizzling.
        /// </summary>
        public lvec4 yzzz => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.zx swizzling.
        /// </summary>
        public lvec2 zx => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec3.zxx swizzling.
        /// </summary>
        public lvec3 zxx => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec3.zxxx swizzling.
        /// </summary>
        public lvec4 zxxx => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.zxxy swizzling.
        /// </summary>
        public lvec4 zxxy => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.zxxz swizzling.
        /// </summary>
        public lvec4 zxxz => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.zxy swizzling.
        /// </summary>
        public lvec3 zxy => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec3.zxyx swizzling.
        /// </summary>
        public lvec4 zxyx => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.zxyy swizzling.
        /// </summary>
        public lvec4 zxyy => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.zxyz swizzling.
        /// </summary>
        public lvec4 zxyz => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.zxz swizzling.
        /// </summary>
        public lvec3 zxz => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec3.zxzx swizzling.
        /// </summary>
        public lvec4 zxzx => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.zxzy swizzling.
        /// </summary>
        public lvec4 zxzy => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.zxzz swizzling.
        /// </summary>
        public lvec4 zxzz => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.zy swizzling.
        /// </summary>
        public lvec2 zy => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec3.zyx swizzling.
        /// </summary>
        public lvec3 zyx => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec3.zyxx swizzling.
        /// </summary>
        public lvec4 zyxx => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.zyxy swizzling.
        /// </summary>
        public lvec4 zyxy => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.zyxz swizzling.
        /// </summary>
        public lvec4 zyxz => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.zyy swizzling.
        /// </summary>
        public lvec3 zyy => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec3.zyyx swizzling.
        /// </summary>
        public lvec4 zyyx => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.zyyy swizzling.
        /// </summary>
        public lvec4 zyyy => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.zyyz swizzling.
        /// </summary>
        public lvec4 zyyz => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.zyz swizzling.
        /// </summary>
        public lvec3 zyz => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec3.zyzx swizzling.
        /// </summary>
        public lvec4 zyzx => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.zyzy swizzling.
        /// </summary>
        public lvec4 zyzy => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.zyzz swizzling.
        /// </summary>
        public lvec4 zyzz => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.zz swizzling.
        /// </summary>
        public lvec2 zz => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec3.zzx swizzling.
        /// </summary>
        public lvec3 zzx => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec3.zzxx swizzling.
        /// </summary>
        public lvec4 zzxx => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.zzxy swizzling.
        /// </summary>
        public lvec4 zzxy => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.zzxz swizzling.
        /// </summary>
        public lvec4 zzxz => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.zzy swizzling.
        /// </summary>
        public lvec3 zzy => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec3.zzyx swizzling.
        /// </summary>
        public lvec4 zzyx => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.zzyy swizzling.
        /// </summary>
        public lvec4 zzyy => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.zzyz swizzling.
        /// </summary>
        public lvec4 zzyz => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.zzz swizzling.
        /// </summary>
        public lvec3 zzz => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec3.zzzx swizzling.
        /// </summary>
        public lvec4 zzzx => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.zzzy swizzling.
        /// </summary>
        public lvec4 zzzy => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.zzzz swizzling.
        /// </summary>
        public lvec4 zzzz => new lvec4(z, z, z, z);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns lvec3.rr swizzling.
        /// </summary>
        public lvec2 rr => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec3.rrr swizzling.
        /// </summary>
        public lvec3 rrr => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec3.rrrr swizzling.
        /// </summary>
        public lvec4 rrrr => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec3.rrrg swizzling.
        /// </summary>
        public lvec4 rrrg => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec3.rrrb swizzling.
        /// </summary>
        public lvec4 rrrb => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec3.rrg swizzling.
        /// </summary>
        public lvec3 rrg => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec3.rrgr swizzling.
        /// </summary>
        public lvec4 rrgr => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec3.rrgg swizzling.
        /// </summary>
        public lvec4 rrgg => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec3.rrgb swizzling.
        /// </summary>
        public lvec4 rrgb => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec3.rrb swizzling.
        /// </summary>
        public lvec3 rrb => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec3.rrbr swizzling.
        /// </summary>
        public lvec4 rrbr => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec3.rrbg swizzling.
        /// </summary>
        public lvec4 rrbg => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec3.rrbb swizzling.
        /// </summary>
        public lvec4 rrbb => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec3.rg swizzling.
        /// </summary>
        public lvec2 rg => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec3.rgr swizzling.
        /// </summary>
        public lvec3 rgr => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec3.rgrr swizzling.
        /// </summary>
        public lvec4 rgrr => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec3.rgrg swizzling.
        /// </summary>
        public lvec4 rgrg => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec3.rgrb swizzling.
        /// </summary>
        public lvec4 rgrb => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec3.rgg swizzling.
        /// </summary>
        public lvec3 rgg => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec3.rggr swizzling.
        /// </summary>
        public lvec4 rggr => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec3.rggg swizzling.
        /// </summary>
        public lvec4 rggg => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec3.rggb swizzling.
        /// </summary>
        public lvec4 rggb => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec3.rgb swizzling.
        /// </summary>
        public lvec3 rgb => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec3.rgbr swizzling.
        /// </summary>
        public lvec4 rgbr => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec3.rgbg swizzling.
        /// </summary>
        public lvec4 rgbg => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec3.rgbb swizzling.
        /// </summary>
        public lvec4 rgbb => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec3.rb swizzling.
        /// </summary>
        public lvec2 rb => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec3.rbr swizzling.
        /// </summary>
        public lvec3 rbr => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec3.rbrr swizzling.
        /// </summary>
        public lvec4 rbrr => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec3.rbrg swizzling.
        /// </summary>
        public lvec4 rbrg => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec3.rbrb swizzling.
        /// </summary>
        public lvec4 rbrb => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec3.rbg swizzling.
        /// </summary>
        public lvec3 rbg => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec3.rbgr swizzling.
        /// </summary>
        public lvec4 rbgr => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec3.rbgg swizzling.
        /// </summary>
        public lvec4 rbgg => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec3.rbgb swizzling.
        /// </summary>
        public lvec4 rbgb => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec3.rbb swizzling.
        /// </summary>
        public lvec3 rbb => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec3.rbbr swizzling.
        /// </summary>
        public lvec4 rbbr => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec3.rbbg swizzling.
        /// </summary>
        public lvec4 rbbg => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec3.rbbb swizzling.
        /// </summary>
        public lvec4 rbbb => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec3.gr swizzling.
        /// </summary>
        public lvec2 gr => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec3.grr swizzling.
        /// </summary>
        public lvec3 grr => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec3.grrr swizzling.
        /// </summary>
        public lvec4 grrr => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec3.grrg swizzling.
        /// </summary>
        public lvec4 grrg => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec3.grrb swizzling.
        /// </summary>
        public lvec4 grrb => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec3.grg swizzling.
        /// </summary>
        public lvec3 grg => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec3.grgr swizzling.
        /// </summary>
        public lvec4 grgr => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec3.grgg swizzling.
        /// </summary>
        public lvec4 grgg => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec3.grgb swizzling.
        /// </summary>
        public lvec4 grgb => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec3.grb swizzling.
        /// </summary>
        public lvec3 grb => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec3.grbr swizzling.
        /// </summary>
        public lvec4 grbr => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec3.grbg swizzling.
        /// </summary>
        public lvec4 grbg => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec3.grbb swizzling.
        /// </summary>
        public lvec4 grbb => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec3.gg swizzling.
        /// </summary>
        public lvec2 gg => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec3.ggr swizzling.
        /// </summary>
        public lvec3 ggr => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec3.ggrr swizzling.
        /// </summary>
        public lvec4 ggrr => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec3.ggrg swizzling.
        /// </summary>
        public lvec4 ggrg => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec3.ggrb swizzling.
        /// </summary>
        public lvec4 ggrb => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec3.ggg swizzling.
        /// </summary>
        public lvec3 ggg => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec3.gggr swizzling.
        /// </summary>
        public lvec4 gggr => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec3.gggg swizzling.
        /// </summary>
        public lvec4 gggg => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec3.gggb swizzling.
        /// </summary>
        public lvec4 gggb => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec3.ggb swizzling.
        /// </summary>
        public lvec3 ggb => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec3.ggbr swizzling.
        /// </summary>
        public lvec4 ggbr => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec3.ggbg swizzling.
        /// </summary>
        public lvec4 ggbg => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec3.ggbb swizzling.
        /// </summary>
        public lvec4 ggbb => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec3.gb swizzling.
        /// </summary>
        public lvec2 gb => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec3.gbr swizzling.
        /// </summary>
        public lvec3 gbr => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec3.gbrr swizzling.
        /// </summary>
        public lvec4 gbrr => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec3.gbrg swizzling.
        /// </summary>
        public lvec4 gbrg => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec3.gbrb swizzling.
        /// </summary>
        public lvec4 gbrb => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec3.gbg swizzling.
        /// </summary>
        public lvec3 gbg => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec3.gbgr swizzling.
        /// </summary>
        public lvec4 gbgr => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec3.gbgg swizzling.
        /// </summary>
        public lvec4 gbgg => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec3.gbgb swizzling.
        /// </summary>
        public lvec4 gbgb => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec3.gbb swizzling.
        /// </summary>
        public lvec3 gbb => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec3.gbbr swizzling.
        /// </summary>
        public lvec4 gbbr => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec3.gbbg swizzling.
        /// </summary>
        public lvec4 gbbg => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec3.gbbb swizzling.
        /// </summary>
        public lvec4 gbbb => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec3.br swizzling.
        /// </summary>
        public lvec2 br => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec3.brr swizzling.
        /// </summary>
        public lvec3 brr => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec3.brrr swizzling.
        /// </summary>
        public lvec4 brrr => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec3.brrg swizzling.
        /// </summary>
        public lvec4 brrg => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec3.brrb swizzling.
        /// </summary>
        public lvec4 brrb => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec3.brg swizzling.
        /// </summary>
        public lvec3 brg => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec3.brgr swizzling.
        /// </summary>
        public lvec4 brgr => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec3.brgg swizzling.
        /// </summary>
        public lvec4 brgg => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec3.brgb swizzling.
        /// </summary>
        public lvec4 brgb => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec3.brb swizzling.
        /// </summary>
        public lvec3 brb => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec3.brbr swizzling.
        /// </summary>
        public lvec4 brbr => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec3.brbg swizzling.
        /// </summary>
        public lvec4 brbg => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec3.brbb swizzling.
        /// </summary>
        public lvec4 brbb => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec3.bg swizzling.
        /// </summary>
        public lvec2 bg => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec3.bgr swizzling.
        /// </summary>
        public lvec3 bgr => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec3.bgrr swizzling.
        /// </summary>
        public lvec4 bgrr => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec3.bgrg swizzling.
        /// </summary>
        public lvec4 bgrg => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec3.bgrb swizzling.
        /// </summary>
        public lvec4 bgrb => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec3.bgg swizzling.
        /// </summary>
        public lvec3 bgg => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec3.bggr swizzling.
        /// </summary>
        public lvec4 bggr => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec3.bggg swizzling.
        /// </summary>
        public lvec4 bggg => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec3.bggb swizzling.
        /// </summary>
        public lvec4 bggb => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec3.bgb swizzling.
        /// </summary>
        public lvec3 bgb => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec3.bgbr swizzling.
        /// </summary>
        public lvec4 bgbr => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec3.bgbg swizzling.
        /// </summary>
        public lvec4 bgbg => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec3.bgbb swizzling.
        /// </summary>
        public lvec4 bgbb => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec3.bb swizzling.
        /// </summary>
        public lvec2 bb => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec3.bbr swizzling.
        /// </summary>
        public lvec3 bbr => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec3.bbrr swizzling.
        /// </summary>
        public lvec4 bbrr => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec3.bbrg swizzling.
        /// </summary>
        public lvec4 bbrg => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec3.bbrb swizzling.
        /// </summary>
        public lvec4 bbrb => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec3.bbg swizzling.
        /// </summary>
        public lvec3 bbg => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec3.bbgr swizzling.
        /// </summary>
        public lvec4 bbgr => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec3.bbgg swizzling.
        /// </summary>
        public lvec4 bbgg => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec3.bbgb swizzling.
        /// </summary>
        public lvec4 bbgb => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec3.bbb swizzling.
        /// </summary>
        public lvec3 bbb => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec3.bbbr swizzling.
        /// </summary>
        public lvec4 bbbr => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec3.bbbg swizzling.
        /// </summary>
        public lvec4 bbbg => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec3.bbbb swizzling.
        /// </summary>
        public lvec4 bbbb => new lvec4(z, z, z, z);
    }
}
