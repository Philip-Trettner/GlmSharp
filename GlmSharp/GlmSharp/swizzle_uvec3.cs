using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp.Swizzle
{
    
    /// <summary>
    /// Temporary vector of type uint with 3 components, used for implementing swizzling for uvec3.
    /// </summary>
    [Serializable]
    public struct swizzle_uvec3
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly uint y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly uint z;
        
        
        /// <summary>
        /// Constructor for swizzle_uvec3.
        /// </summary>
        internal swizzle_uvec3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns uvec3.xx swizzling.
        /// </summary>
        public uvec2 xx => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec3.xxx swizzling.
        /// </summary>
        public uvec3 xxx => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec3.xxxx swizzling.
        /// </summary>
        public uvec4 xxxx => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.xxxy swizzling.
        /// </summary>
        public uvec4 xxxy => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.xxxz swizzling.
        /// </summary>
        public uvec4 xxxz => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.xxy swizzling.
        /// </summary>
        public uvec3 xxy => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec3.xxyx swizzling.
        /// </summary>
        public uvec4 xxyx => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.xxyy swizzling.
        /// </summary>
        public uvec4 xxyy => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.xxyz swizzling.
        /// </summary>
        public uvec4 xxyz => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.xxz swizzling.
        /// </summary>
        public uvec3 xxz => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec3.xxzx swizzling.
        /// </summary>
        public uvec4 xxzx => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.xxzy swizzling.
        /// </summary>
        public uvec4 xxzy => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.xxzz swizzling.
        /// </summary>
        public uvec4 xxzz => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.xy swizzling.
        /// </summary>
        public uvec2 xy => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec3.xyx swizzling.
        /// </summary>
        public uvec3 xyx => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec3.xyxx swizzling.
        /// </summary>
        public uvec4 xyxx => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.xyxy swizzling.
        /// </summary>
        public uvec4 xyxy => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.xyxz swizzling.
        /// </summary>
        public uvec4 xyxz => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.xyy swizzling.
        /// </summary>
        public uvec3 xyy => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec3.xyyx swizzling.
        /// </summary>
        public uvec4 xyyx => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.xyyy swizzling.
        /// </summary>
        public uvec4 xyyy => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.xyyz swizzling.
        /// </summary>
        public uvec4 xyyz => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.xyz swizzling.
        /// </summary>
        public uvec3 xyz => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec3.xyzx swizzling.
        /// </summary>
        public uvec4 xyzx => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.xyzy swizzling.
        /// </summary>
        public uvec4 xyzy => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.xyzz swizzling.
        /// </summary>
        public uvec4 xyzz => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.xz swizzling.
        /// </summary>
        public uvec2 xz => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec3.xzx swizzling.
        /// </summary>
        public uvec3 xzx => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec3.xzxx swizzling.
        /// </summary>
        public uvec4 xzxx => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.xzxy swizzling.
        /// </summary>
        public uvec4 xzxy => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.xzxz swizzling.
        /// </summary>
        public uvec4 xzxz => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.xzy swizzling.
        /// </summary>
        public uvec3 xzy => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec3.xzyx swizzling.
        /// </summary>
        public uvec4 xzyx => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.xzyy swizzling.
        /// </summary>
        public uvec4 xzyy => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.xzyz swizzling.
        /// </summary>
        public uvec4 xzyz => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.xzz swizzling.
        /// </summary>
        public uvec3 xzz => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec3.xzzx swizzling.
        /// </summary>
        public uvec4 xzzx => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.xzzy swizzling.
        /// </summary>
        public uvec4 xzzy => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.xzzz swizzling.
        /// </summary>
        public uvec4 xzzz => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.yx swizzling.
        /// </summary>
        public uvec2 yx => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec3.yxx swizzling.
        /// </summary>
        public uvec3 yxx => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec3.yxxx swizzling.
        /// </summary>
        public uvec4 yxxx => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.yxxy swizzling.
        /// </summary>
        public uvec4 yxxy => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.yxxz swizzling.
        /// </summary>
        public uvec4 yxxz => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.yxy swizzling.
        /// </summary>
        public uvec3 yxy => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec3.yxyx swizzling.
        /// </summary>
        public uvec4 yxyx => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.yxyy swizzling.
        /// </summary>
        public uvec4 yxyy => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.yxyz swizzling.
        /// </summary>
        public uvec4 yxyz => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.yxz swizzling.
        /// </summary>
        public uvec3 yxz => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec3.yxzx swizzling.
        /// </summary>
        public uvec4 yxzx => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.yxzy swizzling.
        /// </summary>
        public uvec4 yxzy => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.yxzz swizzling.
        /// </summary>
        public uvec4 yxzz => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.yy swizzling.
        /// </summary>
        public uvec2 yy => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec3.yyx swizzling.
        /// </summary>
        public uvec3 yyx => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec3.yyxx swizzling.
        /// </summary>
        public uvec4 yyxx => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.yyxy swizzling.
        /// </summary>
        public uvec4 yyxy => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.yyxz swizzling.
        /// </summary>
        public uvec4 yyxz => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.yyy swizzling.
        /// </summary>
        public uvec3 yyy => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec3.yyyx swizzling.
        /// </summary>
        public uvec4 yyyx => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.yyyy swizzling.
        /// </summary>
        public uvec4 yyyy => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.yyyz swizzling.
        /// </summary>
        public uvec4 yyyz => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.yyz swizzling.
        /// </summary>
        public uvec3 yyz => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec3.yyzx swizzling.
        /// </summary>
        public uvec4 yyzx => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.yyzy swizzling.
        /// </summary>
        public uvec4 yyzy => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.yyzz swizzling.
        /// </summary>
        public uvec4 yyzz => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.yz swizzling.
        /// </summary>
        public uvec2 yz => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec3.yzx swizzling.
        /// </summary>
        public uvec3 yzx => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec3.yzxx swizzling.
        /// </summary>
        public uvec4 yzxx => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.yzxy swizzling.
        /// </summary>
        public uvec4 yzxy => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.yzxz swizzling.
        /// </summary>
        public uvec4 yzxz => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.yzy swizzling.
        /// </summary>
        public uvec3 yzy => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec3.yzyx swizzling.
        /// </summary>
        public uvec4 yzyx => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.yzyy swizzling.
        /// </summary>
        public uvec4 yzyy => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.yzyz swizzling.
        /// </summary>
        public uvec4 yzyz => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.yzz swizzling.
        /// </summary>
        public uvec3 yzz => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec3.yzzx swizzling.
        /// </summary>
        public uvec4 yzzx => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.yzzy swizzling.
        /// </summary>
        public uvec4 yzzy => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.yzzz swizzling.
        /// </summary>
        public uvec4 yzzz => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.zx swizzling.
        /// </summary>
        public uvec2 zx => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec3.zxx swizzling.
        /// </summary>
        public uvec3 zxx => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec3.zxxx swizzling.
        /// </summary>
        public uvec4 zxxx => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.zxxy swizzling.
        /// </summary>
        public uvec4 zxxy => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.zxxz swizzling.
        /// </summary>
        public uvec4 zxxz => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.zxy swizzling.
        /// </summary>
        public uvec3 zxy => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec3.zxyx swizzling.
        /// </summary>
        public uvec4 zxyx => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.zxyy swizzling.
        /// </summary>
        public uvec4 zxyy => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.zxyz swizzling.
        /// </summary>
        public uvec4 zxyz => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.zxz swizzling.
        /// </summary>
        public uvec3 zxz => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec3.zxzx swizzling.
        /// </summary>
        public uvec4 zxzx => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.zxzy swizzling.
        /// </summary>
        public uvec4 zxzy => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.zxzz swizzling.
        /// </summary>
        public uvec4 zxzz => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.zy swizzling.
        /// </summary>
        public uvec2 zy => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec3.zyx swizzling.
        /// </summary>
        public uvec3 zyx => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec3.zyxx swizzling.
        /// </summary>
        public uvec4 zyxx => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.zyxy swizzling.
        /// </summary>
        public uvec4 zyxy => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.zyxz swizzling.
        /// </summary>
        public uvec4 zyxz => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.zyy swizzling.
        /// </summary>
        public uvec3 zyy => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec3.zyyx swizzling.
        /// </summary>
        public uvec4 zyyx => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.zyyy swizzling.
        /// </summary>
        public uvec4 zyyy => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.zyyz swizzling.
        /// </summary>
        public uvec4 zyyz => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.zyz swizzling.
        /// </summary>
        public uvec3 zyz => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec3.zyzx swizzling.
        /// </summary>
        public uvec4 zyzx => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.zyzy swizzling.
        /// </summary>
        public uvec4 zyzy => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.zyzz swizzling.
        /// </summary>
        public uvec4 zyzz => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.zz swizzling.
        /// </summary>
        public uvec2 zz => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec3.zzx swizzling.
        /// </summary>
        public uvec3 zzx => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec3.zzxx swizzling.
        /// </summary>
        public uvec4 zzxx => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.zzxy swizzling.
        /// </summary>
        public uvec4 zzxy => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.zzxz swizzling.
        /// </summary>
        public uvec4 zzxz => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.zzy swizzling.
        /// </summary>
        public uvec3 zzy => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec3.zzyx swizzling.
        /// </summary>
        public uvec4 zzyx => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.zzyy swizzling.
        /// </summary>
        public uvec4 zzyy => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.zzyz swizzling.
        /// </summary>
        public uvec4 zzyz => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.zzz swizzling.
        /// </summary>
        public uvec3 zzz => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec3.zzzx swizzling.
        /// </summary>
        public uvec4 zzzx => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.zzzy swizzling.
        /// </summary>
        public uvec4 zzzy => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.zzzz swizzling.
        /// </summary>
        public uvec4 zzzz => new uvec4(z, z, z, z);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns uvec3.rr swizzling.
        /// </summary>
        public uvec2 rr => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec3.rrr swizzling.
        /// </summary>
        public uvec3 rrr => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec3.rrrr swizzling.
        /// </summary>
        public uvec4 rrrr => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec3.rrrg swizzling.
        /// </summary>
        public uvec4 rrrg => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec3.rrrb swizzling.
        /// </summary>
        public uvec4 rrrb => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec3.rrg swizzling.
        /// </summary>
        public uvec3 rrg => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec3.rrgr swizzling.
        /// </summary>
        public uvec4 rrgr => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec3.rrgg swizzling.
        /// </summary>
        public uvec4 rrgg => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec3.rrgb swizzling.
        /// </summary>
        public uvec4 rrgb => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec3.rrb swizzling.
        /// </summary>
        public uvec3 rrb => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec3.rrbr swizzling.
        /// </summary>
        public uvec4 rrbr => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec3.rrbg swizzling.
        /// </summary>
        public uvec4 rrbg => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec3.rrbb swizzling.
        /// </summary>
        public uvec4 rrbb => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec3.rg swizzling.
        /// </summary>
        public uvec2 rg => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec3.rgr swizzling.
        /// </summary>
        public uvec3 rgr => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec3.rgrr swizzling.
        /// </summary>
        public uvec4 rgrr => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec3.rgrg swizzling.
        /// </summary>
        public uvec4 rgrg => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec3.rgrb swizzling.
        /// </summary>
        public uvec4 rgrb => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec3.rgg swizzling.
        /// </summary>
        public uvec3 rgg => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec3.rggr swizzling.
        /// </summary>
        public uvec4 rggr => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec3.rggg swizzling.
        /// </summary>
        public uvec4 rggg => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec3.rggb swizzling.
        /// </summary>
        public uvec4 rggb => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec3.rgb swizzling.
        /// </summary>
        public uvec3 rgb => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec3.rgbr swizzling.
        /// </summary>
        public uvec4 rgbr => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec3.rgbg swizzling.
        /// </summary>
        public uvec4 rgbg => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec3.rgbb swizzling.
        /// </summary>
        public uvec4 rgbb => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec3.rb swizzling.
        /// </summary>
        public uvec2 rb => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec3.rbr swizzling.
        /// </summary>
        public uvec3 rbr => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec3.rbrr swizzling.
        /// </summary>
        public uvec4 rbrr => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec3.rbrg swizzling.
        /// </summary>
        public uvec4 rbrg => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec3.rbrb swizzling.
        /// </summary>
        public uvec4 rbrb => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec3.rbg swizzling.
        /// </summary>
        public uvec3 rbg => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec3.rbgr swizzling.
        /// </summary>
        public uvec4 rbgr => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec3.rbgg swizzling.
        /// </summary>
        public uvec4 rbgg => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec3.rbgb swizzling.
        /// </summary>
        public uvec4 rbgb => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec3.rbb swizzling.
        /// </summary>
        public uvec3 rbb => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec3.rbbr swizzling.
        /// </summary>
        public uvec4 rbbr => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec3.rbbg swizzling.
        /// </summary>
        public uvec4 rbbg => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec3.rbbb swizzling.
        /// </summary>
        public uvec4 rbbb => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec3.gr swizzling.
        /// </summary>
        public uvec2 gr => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec3.grr swizzling.
        /// </summary>
        public uvec3 grr => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec3.grrr swizzling.
        /// </summary>
        public uvec4 grrr => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec3.grrg swizzling.
        /// </summary>
        public uvec4 grrg => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec3.grrb swizzling.
        /// </summary>
        public uvec4 grrb => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec3.grg swizzling.
        /// </summary>
        public uvec3 grg => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec3.grgr swizzling.
        /// </summary>
        public uvec4 grgr => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec3.grgg swizzling.
        /// </summary>
        public uvec4 grgg => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec3.grgb swizzling.
        /// </summary>
        public uvec4 grgb => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec3.grb swizzling.
        /// </summary>
        public uvec3 grb => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec3.grbr swizzling.
        /// </summary>
        public uvec4 grbr => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec3.grbg swizzling.
        /// </summary>
        public uvec4 grbg => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec3.grbb swizzling.
        /// </summary>
        public uvec4 grbb => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec3.gg swizzling.
        /// </summary>
        public uvec2 gg => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec3.ggr swizzling.
        /// </summary>
        public uvec3 ggr => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec3.ggrr swizzling.
        /// </summary>
        public uvec4 ggrr => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec3.ggrg swizzling.
        /// </summary>
        public uvec4 ggrg => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec3.ggrb swizzling.
        /// </summary>
        public uvec4 ggrb => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec3.ggg swizzling.
        /// </summary>
        public uvec3 ggg => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec3.gggr swizzling.
        /// </summary>
        public uvec4 gggr => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec3.gggg swizzling.
        /// </summary>
        public uvec4 gggg => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec3.gggb swizzling.
        /// </summary>
        public uvec4 gggb => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec3.ggb swizzling.
        /// </summary>
        public uvec3 ggb => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec3.ggbr swizzling.
        /// </summary>
        public uvec4 ggbr => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec3.ggbg swizzling.
        /// </summary>
        public uvec4 ggbg => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec3.ggbb swizzling.
        /// </summary>
        public uvec4 ggbb => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec3.gb swizzling.
        /// </summary>
        public uvec2 gb => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec3.gbr swizzling.
        /// </summary>
        public uvec3 gbr => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec3.gbrr swizzling.
        /// </summary>
        public uvec4 gbrr => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec3.gbrg swizzling.
        /// </summary>
        public uvec4 gbrg => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec3.gbrb swizzling.
        /// </summary>
        public uvec4 gbrb => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec3.gbg swizzling.
        /// </summary>
        public uvec3 gbg => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec3.gbgr swizzling.
        /// </summary>
        public uvec4 gbgr => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec3.gbgg swizzling.
        /// </summary>
        public uvec4 gbgg => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec3.gbgb swizzling.
        /// </summary>
        public uvec4 gbgb => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec3.gbb swizzling.
        /// </summary>
        public uvec3 gbb => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec3.gbbr swizzling.
        /// </summary>
        public uvec4 gbbr => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec3.gbbg swizzling.
        /// </summary>
        public uvec4 gbbg => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec3.gbbb swizzling.
        /// </summary>
        public uvec4 gbbb => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec3.br swizzling.
        /// </summary>
        public uvec2 br => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec3.brr swizzling.
        /// </summary>
        public uvec3 brr => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec3.brrr swizzling.
        /// </summary>
        public uvec4 brrr => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec3.brrg swizzling.
        /// </summary>
        public uvec4 brrg => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec3.brrb swizzling.
        /// </summary>
        public uvec4 brrb => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec3.brg swizzling.
        /// </summary>
        public uvec3 brg => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec3.brgr swizzling.
        /// </summary>
        public uvec4 brgr => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec3.brgg swizzling.
        /// </summary>
        public uvec4 brgg => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec3.brgb swizzling.
        /// </summary>
        public uvec4 brgb => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec3.brb swizzling.
        /// </summary>
        public uvec3 brb => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec3.brbr swizzling.
        /// </summary>
        public uvec4 brbr => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec3.brbg swizzling.
        /// </summary>
        public uvec4 brbg => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec3.brbb swizzling.
        /// </summary>
        public uvec4 brbb => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec3.bg swizzling.
        /// </summary>
        public uvec2 bg => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec3.bgr swizzling.
        /// </summary>
        public uvec3 bgr => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec3.bgrr swizzling.
        /// </summary>
        public uvec4 bgrr => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec3.bgrg swizzling.
        /// </summary>
        public uvec4 bgrg => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec3.bgrb swizzling.
        /// </summary>
        public uvec4 bgrb => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec3.bgg swizzling.
        /// </summary>
        public uvec3 bgg => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec3.bggr swizzling.
        /// </summary>
        public uvec4 bggr => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec3.bggg swizzling.
        /// </summary>
        public uvec4 bggg => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec3.bggb swizzling.
        /// </summary>
        public uvec4 bggb => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec3.bgb swizzling.
        /// </summary>
        public uvec3 bgb => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec3.bgbr swizzling.
        /// </summary>
        public uvec4 bgbr => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec3.bgbg swizzling.
        /// </summary>
        public uvec4 bgbg => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec3.bgbb swizzling.
        /// </summary>
        public uvec4 bgbb => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec3.bb swizzling.
        /// </summary>
        public uvec2 bb => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec3.bbr swizzling.
        /// </summary>
        public uvec3 bbr => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec3.bbrr swizzling.
        /// </summary>
        public uvec4 bbrr => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec3.bbrg swizzling.
        /// </summary>
        public uvec4 bbrg => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec3.bbrb swizzling.
        /// </summary>
        public uvec4 bbrb => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec3.bbg swizzling.
        /// </summary>
        public uvec3 bbg => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec3.bbgr swizzling.
        /// </summary>
        public uvec4 bbgr => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec3.bbgg swizzling.
        /// </summary>
        public uvec4 bbgg => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec3.bbgb swizzling.
        /// </summary>
        public uvec4 bbgb => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec3.bbb swizzling.
        /// </summary>
        public uvec3 bbb => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec3.bbbr swizzling.
        /// </summary>
        public uvec4 bbbr => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec3.bbbg swizzling.
        /// </summary>
        public uvec4 bbbg => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec3.bbbb swizzling.
        /// </summary>
        public uvec4 bbbb => new uvec4(z, z, z, z);
    }
}
