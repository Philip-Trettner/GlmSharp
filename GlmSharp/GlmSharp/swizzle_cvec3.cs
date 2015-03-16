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
    /// Temporary vector of type Complex with 3 components, used for implementing swizzling for cvec3.
    /// </summary>
    [Serializable]
    public struct swizzle_cvec3
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly Complex x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly Complex y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly Complex z;
        
        
        /// <summary>
        /// Constructor for swizzle_cvec3.
        /// </summary>
        internal swizzle_cvec3(Complex x, Complex y, Complex z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns cvec3.xx swizzling.
        /// </summary>
        public cvec2 xx => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec3.xxx swizzling.
        /// </summary>
        public cvec3 xxx => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec3.xxxx swizzling.
        /// </summary>
        public cvec4 xxxx => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.xxxy swizzling.
        /// </summary>
        public cvec4 xxxy => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.xxxz swizzling.
        /// </summary>
        public cvec4 xxxz => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.xxy swizzling.
        /// </summary>
        public cvec3 xxy => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec3.xxyx swizzling.
        /// </summary>
        public cvec4 xxyx => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.xxyy swizzling.
        /// </summary>
        public cvec4 xxyy => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.xxyz swizzling.
        /// </summary>
        public cvec4 xxyz => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.xxz swizzling.
        /// </summary>
        public cvec3 xxz => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec3.xxzx swizzling.
        /// </summary>
        public cvec4 xxzx => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.xxzy swizzling.
        /// </summary>
        public cvec4 xxzy => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.xxzz swizzling.
        /// </summary>
        public cvec4 xxzz => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.xy swizzling.
        /// </summary>
        public cvec2 xy => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec3.xyx swizzling.
        /// </summary>
        public cvec3 xyx => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec3.xyxx swizzling.
        /// </summary>
        public cvec4 xyxx => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.xyxy swizzling.
        /// </summary>
        public cvec4 xyxy => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.xyxz swizzling.
        /// </summary>
        public cvec4 xyxz => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.xyy swizzling.
        /// </summary>
        public cvec3 xyy => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec3.xyyx swizzling.
        /// </summary>
        public cvec4 xyyx => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.xyyy swizzling.
        /// </summary>
        public cvec4 xyyy => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.xyyz swizzling.
        /// </summary>
        public cvec4 xyyz => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.xyz swizzling.
        /// </summary>
        public cvec3 xyz => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec3.xyzx swizzling.
        /// </summary>
        public cvec4 xyzx => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.xyzy swizzling.
        /// </summary>
        public cvec4 xyzy => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.xyzz swizzling.
        /// </summary>
        public cvec4 xyzz => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.xz swizzling.
        /// </summary>
        public cvec2 xz => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec3.xzx swizzling.
        /// </summary>
        public cvec3 xzx => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec3.xzxx swizzling.
        /// </summary>
        public cvec4 xzxx => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.xzxy swizzling.
        /// </summary>
        public cvec4 xzxy => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.xzxz swizzling.
        /// </summary>
        public cvec4 xzxz => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.xzy swizzling.
        /// </summary>
        public cvec3 xzy => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec3.xzyx swizzling.
        /// </summary>
        public cvec4 xzyx => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.xzyy swizzling.
        /// </summary>
        public cvec4 xzyy => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.xzyz swizzling.
        /// </summary>
        public cvec4 xzyz => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.xzz swizzling.
        /// </summary>
        public cvec3 xzz => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec3.xzzx swizzling.
        /// </summary>
        public cvec4 xzzx => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.xzzy swizzling.
        /// </summary>
        public cvec4 xzzy => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.xzzz swizzling.
        /// </summary>
        public cvec4 xzzz => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.yx swizzling.
        /// </summary>
        public cvec2 yx => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec3.yxx swizzling.
        /// </summary>
        public cvec3 yxx => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec3.yxxx swizzling.
        /// </summary>
        public cvec4 yxxx => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.yxxy swizzling.
        /// </summary>
        public cvec4 yxxy => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.yxxz swizzling.
        /// </summary>
        public cvec4 yxxz => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.yxy swizzling.
        /// </summary>
        public cvec3 yxy => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec3.yxyx swizzling.
        /// </summary>
        public cvec4 yxyx => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.yxyy swizzling.
        /// </summary>
        public cvec4 yxyy => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.yxyz swizzling.
        /// </summary>
        public cvec4 yxyz => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.yxz swizzling.
        /// </summary>
        public cvec3 yxz => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec3.yxzx swizzling.
        /// </summary>
        public cvec4 yxzx => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.yxzy swizzling.
        /// </summary>
        public cvec4 yxzy => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.yxzz swizzling.
        /// </summary>
        public cvec4 yxzz => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.yy swizzling.
        /// </summary>
        public cvec2 yy => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec3.yyx swizzling.
        /// </summary>
        public cvec3 yyx => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec3.yyxx swizzling.
        /// </summary>
        public cvec4 yyxx => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.yyxy swizzling.
        /// </summary>
        public cvec4 yyxy => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.yyxz swizzling.
        /// </summary>
        public cvec4 yyxz => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.yyy swizzling.
        /// </summary>
        public cvec3 yyy => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec3.yyyx swizzling.
        /// </summary>
        public cvec4 yyyx => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.yyyy swizzling.
        /// </summary>
        public cvec4 yyyy => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.yyyz swizzling.
        /// </summary>
        public cvec4 yyyz => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.yyz swizzling.
        /// </summary>
        public cvec3 yyz => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec3.yyzx swizzling.
        /// </summary>
        public cvec4 yyzx => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.yyzy swizzling.
        /// </summary>
        public cvec4 yyzy => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.yyzz swizzling.
        /// </summary>
        public cvec4 yyzz => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.yz swizzling.
        /// </summary>
        public cvec2 yz => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec3.yzx swizzling.
        /// </summary>
        public cvec3 yzx => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec3.yzxx swizzling.
        /// </summary>
        public cvec4 yzxx => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.yzxy swizzling.
        /// </summary>
        public cvec4 yzxy => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.yzxz swizzling.
        /// </summary>
        public cvec4 yzxz => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.yzy swizzling.
        /// </summary>
        public cvec3 yzy => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec3.yzyx swizzling.
        /// </summary>
        public cvec4 yzyx => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.yzyy swizzling.
        /// </summary>
        public cvec4 yzyy => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.yzyz swizzling.
        /// </summary>
        public cvec4 yzyz => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.yzz swizzling.
        /// </summary>
        public cvec3 yzz => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec3.yzzx swizzling.
        /// </summary>
        public cvec4 yzzx => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.yzzy swizzling.
        /// </summary>
        public cvec4 yzzy => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.yzzz swizzling.
        /// </summary>
        public cvec4 yzzz => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.zx swizzling.
        /// </summary>
        public cvec2 zx => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec3.zxx swizzling.
        /// </summary>
        public cvec3 zxx => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec3.zxxx swizzling.
        /// </summary>
        public cvec4 zxxx => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.zxxy swizzling.
        /// </summary>
        public cvec4 zxxy => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.zxxz swizzling.
        /// </summary>
        public cvec4 zxxz => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.zxy swizzling.
        /// </summary>
        public cvec3 zxy => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec3.zxyx swizzling.
        /// </summary>
        public cvec4 zxyx => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.zxyy swizzling.
        /// </summary>
        public cvec4 zxyy => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.zxyz swizzling.
        /// </summary>
        public cvec4 zxyz => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.zxz swizzling.
        /// </summary>
        public cvec3 zxz => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec3.zxzx swizzling.
        /// </summary>
        public cvec4 zxzx => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.zxzy swizzling.
        /// </summary>
        public cvec4 zxzy => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.zxzz swizzling.
        /// </summary>
        public cvec4 zxzz => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.zy swizzling.
        /// </summary>
        public cvec2 zy => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec3.zyx swizzling.
        /// </summary>
        public cvec3 zyx => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec3.zyxx swizzling.
        /// </summary>
        public cvec4 zyxx => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.zyxy swizzling.
        /// </summary>
        public cvec4 zyxy => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.zyxz swizzling.
        /// </summary>
        public cvec4 zyxz => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.zyy swizzling.
        /// </summary>
        public cvec3 zyy => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec3.zyyx swizzling.
        /// </summary>
        public cvec4 zyyx => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.zyyy swizzling.
        /// </summary>
        public cvec4 zyyy => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.zyyz swizzling.
        /// </summary>
        public cvec4 zyyz => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.zyz swizzling.
        /// </summary>
        public cvec3 zyz => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec3.zyzx swizzling.
        /// </summary>
        public cvec4 zyzx => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.zyzy swizzling.
        /// </summary>
        public cvec4 zyzy => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.zyzz swizzling.
        /// </summary>
        public cvec4 zyzz => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.zz swizzling.
        /// </summary>
        public cvec2 zz => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec3.zzx swizzling.
        /// </summary>
        public cvec3 zzx => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec3.zzxx swizzling.
        /// </summary>
        public cvec4 zzxx => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.zzxy swizzling.
        /// </summary>
        public cvec4 zzxy => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.zzxz swizzling.
        /// </summary>
        public cvec4 zzxz => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.zzy swizzling.
        /// </summary>
        public cvec3 zzy => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec3.zzyx swizzling.
        /// </summary>
        public cvec4 zzyx => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.zzyy swizzling.
        /// </summary>
        public cvec4 zzyy => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.zzyz swizzling.
        /// </summary>
        public cvec4 zzyz => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.zzz swizzling.
        /// </summary>
        public cvec3 zzz => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec3.zzzx swizzling.
        /// </summary>
        public cvec4 zzzx => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.zzzy swizzling.
        /// </summary>
        public cvec4 zzzy => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.zzzz swizzling.
        /// </summary>
        public cvec4 zzzz => new cvec4(z, z, z, z);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns cvec3.rr swizzling.
        /// </summary>
        public cvec2 rr => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec3.rrr swizzling.
        /// </summary>
        public cvec3 rrr => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec3.rrrr swizzling.
        /// </summary>
        public cvec4 rrrr => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec3.rrrg swizzling.
        /// </summary>
        public cvec4 rrrg => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec3.rrrb swizzling.
        /// </summary>
        public cvec4 rrrb => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec3.rrg swizzling.
        /// </summary>
        public cvec3 rrg => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec3.rrgr swizzling.
        /// </summary>
        public cvec4 rrgr => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec3.rrgg swizzling.
        /// </summary>
        public cvec4 rrgg => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec3.rrgb swizzling.
        /// </summary>
        public cvec4 rrgb => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec3.rrb swizzling.
        /// </summary>
        public cvec3 rrb => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec3.rrbr swizzling.
        /// </summary>
        public cvec4 rrbr => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec3.rrbg swizzling.
        /// </summary>
        public cvec4 rrbg => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec3.rrbb swizzling.
        /// </summary>
        public cvec4 rrbb => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec3.rg swizzling.
        /// </summary>
        public cvec2 rg => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec3.rgr swizzling.
        /// </summary>
        public cvec3 rgr => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec3.rgrr swizzling.
        /// </summary>
        public cvec4 rgrr => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec3.rgrg swizzling.
        /// </summary>
        public cvec4 rgrg => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec3.rgrb swizzling.
        /// </summary>
        public cvec4 rgrb => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec3.rgg swizzling.
        /// </summary>
        public cvec3 rgg => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec3.rggr swizzling.
        /// </summary>
        public cvec4 rggr => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec3.rggg swizzling.
        /// </summary>
        public cvec4 rggg => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec3.rggb swizzling.
        /// </summary>
        public cvec4 rggb => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec3.rgb swizzling.
        /// </summary>
        public cvec3 rgb => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec3.rgbr swizzling.
        /// </summary>
        public cvec4 rgbr => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec3.rgbg swizzling.
        /// </summary>
        public cvec4 rgbg => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec3.rgbb swizzling.
        /// </summary>
        public cvec4 rgbb => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec3.rb swizzling.
        /// </summary>
        public cvec2 rb => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec3.rbr swizzling.
        /// </summary>
        public cvec3 rbr => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec3.rbrr swizzling.
        /// </summary>
        public cvec4 rbrr => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec3.rbrg swizzling.
        /// </summary>
        public cvec4 rbrg => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec3.rbrb swizzling.
        /// </summary>
        public cvec4 rbrb => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec3.rbg swizzling.
        /// </summary>
        public cvec3 rbg => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec3.rbgr swizzling.
        /// </summary>
        public cvec4 rbgr => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec3.rbgg swizzling.
        /// </summary>
        public cvec4 rbgg => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec3.rbgb swizzling.
        /// </summary>
        public cvec4 rbgb => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec3.rbb swizzling.
        /// </summary>
        public cvec3 rbb => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec3.rbbr swizzling.
        /// </summary>
        public cvec4 rbbr => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec3.rbbg swizzling.
        /// </summary>
        public cvec4 rbbg => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec3.rbbb swizzling.
        /// </summary>
        public cvec4 rbbb => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec3.gr swizzling.
        /// </summary>
        public cvec2 gr => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec3.grr swizzling.
        /// </summary>
        public cvec3 grr => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec3.grrr swizzling.
        /// </summary>
        public cvec4 grrr => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec3.grrg swizzling.
        /// </summary>
        public cvec4 grrg => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec3.grrb swizzling.
        /// </summary>
        public cvec4 grrb => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec3.grg swizzling.
        /// </summary>
        public cvec3 grg => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec3.grgr swizzling.
        /// </summary>
        public cvec4 grgr => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec3.grgg swizzling.
        /// </summary>
        public cvec4 grgg => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec3.grgb swizzling.
        /// </summary>
        public cvec4 grgb => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec3.grb swizzling.
        /// </summary>
        public cvec3 grb => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec3.grbr swizzling.
        /// </summary>
        public cvec4 grbr => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec3.grbg swizzling.
        /// </summary>
        public cvec4 grbg => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec3.grbb swizzling.
        /// </summary>
        public cvec4 grbb => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec3.gg swizzling.
        /// </summary>
        public cvec2 gg => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec3.ggr swizzling.
        /// </summary>
        public cvec3 ggr => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec3.ggrr swizzling.
        /// </summary>
        public cvec4 ggrr => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec3.ggrg swizzling.
        /// </summary>
        public cvec4 ggrg => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec3.ggrb swizzling.
        /// </summary>
        public cvec4 ggrb => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec3.ggg swizzling.
        /// </summary>
        public cvec3 ggg => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec3.gggr swizzling.
        /// </summary>
        public cvec4 gggr => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec3.gggg swizzling.
        /// </summary>
        public cvec4 gggg => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec3.gggb swizzling.
        /// </summary>
        public cvec4 gggb => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec3.ggb swizzling.
        /// </summary>
        public cvec3 ggb => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec3.ggbr swizzling.
        /// </summary>
        public cvec4 ggbr => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec3.ggbg swizzling.
        /// </summary>
        public cvec4 ggbg => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec3.ggbb swizzling.
        /// </summary>
        public cvec4 ggbb => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec3.gb swizzling.
        /// </summary>
        public cvec2 gb => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec3.gbr swizzling.
        /// </summary>
        public cvec3 gbr => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec3.gbrr swizzling.
        /// </summary>
        public cvec4 gbrr => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec3.gbrg swizzling.
        /// </summary>
        public cvec4 gbrg => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec3.gbrb swizzling.
        /// </summary>
        public cvec4 gbrb => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec3.gbg swizzling.
        /// </summary>
        public cvec3 gbg => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec3.gbgr swizzling.
        /// </summary>
        public cvec4 gbgr => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec3.gbgg swizzling.
        /// </summary>
        public cvec4 gbgg => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec3.gbgb swizzling.
        /// </summary>
        public cvec4 gbgb => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec3.gbb swizzling.
        /// </summary>
        public cvec3 gbb => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec3.gbbr swizzling.
        /// </summary>
        public cvec4 gbbr => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec3.gbbg swizzling.
        /// </summary>
        public cvec4 gbbg => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec3.gbbb swizzling.
        /// </summary>
        public cvec4 gbbb => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec3.br swizzling.
        /// </summary>
        public cvec2 br => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec3.brr swizzling.
        /// </summary>
        public cvec3 brr => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec3.brrr swizzling.
        /// </summary>
        public cvec4 brrr => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec3.brrg swizzling.
        /// </summary>
        public cvec4 brrg => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec3.brrb swizzling.
        /// </summary>
        public cvec4 brrb => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec3.brg swizzling.
        /// </summary>
        public cvec3 brg => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec3.brgr swizzling.
        /// </summary>
        public cvec4 brgr => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec3.brgg swizzling.
        /// </summary>
        public cvec4 brgg => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec3.brgb swizzling.
        /// </summary>
        public cvec4 brgb => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec3.brb swizzling.
        /// </summary>
        public cvec3 brb => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec3.brbr swizzling.
        /// </summary>
        public cvec4 brbr => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec3.brbg swizzling.
        /// </summary>
        public cvec4 brbg => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec3.brbb swizzling.
        /// </summary>
        public cvec4 brbb => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec3.bg swizzling.
        /// </summary>
        public cvec2 bg => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec3.bgr swizzling.
        /// </summary>
        public cvec3 bgr => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec3.bgrr swizzling.
        /// </summary>
        public cvec4 bgrr => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec3.bgrg swizzling.
        /// </summary>
        public cvec4 bgrg => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec3.bgrb swizzling.
        /// </summary>
        public cvec4 bgrb => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec3.bgg swizzling.
        /// </summary>
        public cvec3 bgg => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec3.bggr swizzling.
        /// </summary>
        public cvec4 bggr => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec3.bggg swizzling.
        /// </summary>
        public cvec4 bggg => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec3.bggb swizzling.
        /// </summary>
        public cvec4 bggb => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec3.bgb swizzling.
        /// </summary>
        public cvec3 bgb => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec3.bgbr swizzling.
        /// </summary>
        public cvec4 bgbr => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec3.bgbg swizzling.
        /// </summary>
        public cvec4 bgbg => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec3.bgbb swizzling.
        /// </summary>
        public cvec4 bgbb => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec3.bb swizzling.
        /// </summary>
        public cvec2 bb => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec3.bbr swizzling.
        /// </summary>
        public cvec3 bbr => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec3.bbrr swizzling.
        /// </summary>
        public cvec4 bbrr => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec3.bbrg swizzling.
        /// </summary>
        public cvec4 bbrg => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec3.bbrb swizzling.
        /// </summary>
        public cvec4 bbrb => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec3.bbg swizzling.
        /// </summary>
        public cvec3 bbg => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec3.bbgr swizzling.
        /// </summary>
        public cvec4 bbgr => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec3.bbgg swizzling.
        /// </summary>
        public cvec4 bbgg => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec3.bbgb swizzling.
        /// </summary>
        public cvec4 bbgb => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec3.bbb swizzling.
        /// </summary>
        public cvec3 bbb => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec3.bbbr swizzling.
        /// </summary>
        public cvec4 bbbr => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec3.bbbg swizzling.
        /// </summary>
        public cvec4 bbbg => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec3.bbbb swizzling.
        /// </summary>
        public cvec4 bbbb => new cvec4(z, z, z, z);
    }
}
