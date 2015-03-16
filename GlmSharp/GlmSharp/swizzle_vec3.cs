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
    /// Temporary vector of type float with 3 components, used for implementing swizzling for vec3.
    /// </summary>
    [Serializable]
    public struct swizzle_vec3
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly float z;
        
        
        /// <summary>
        /// Constructor for swizzle_vec3.
        /// </summary>
        internal swizzle_vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns vec3.xx swizzling.
        /// </summary>
        public vec2 xx => new vec2(x, x);
        
        /// <summary>
        /// Returns vec3.xxx swizzling.
        /// </summary>
        public vec3 xxx => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec3.xxxx swizzling.
        /// </summary>
        public vec4 xxxx => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec3.xxxy swizzling.
        /// </summary>
        public vec4 xxxy => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec3.xxxz swizzling.
        /// </summary>
        public vec4 xxxz => new vec4(x, x, x, z);
        
        /// <summary>
        /// Returns vec3.xxy swizzling.
        /// </summary>
        public vec3 xxy => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec3.xxyx swizzling.
        /// </summary>
        public vec4 xxyx => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec3.xxyy swizzling.
        /// </summary>
        public vec4 xxyy => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec3.xxyz swizzling.
        /// </summary>
        public vec4 xxyz => new vec4(x, x, y, z);
        
        /// <summary>
        /// Returns vec3.xxz swizzling.
        /// </summary>
        public vec3 xxz => new vec3(x, x, z);
        
        /// <summary>
        /// Returns vec3.xxzx swizzling.
        /// </summary>
        public vec4 xxzx => new vec4(x, x, z, x);
        
        /// <summary>
        /// Returns vec3.xxzy swizzling.
        /// </summary>
        public vec4 xxzy => new vec4(x, x, z, y);
        
        /// <summary>
        /// Returns vec3.xxzz swizzling.
        /// </summary>
        public vec4 xxzz => new vec4(x, x, z, z);
        
        /// <summary>
        /// Returns vec3.xy swizzling.
        /// </summary>
        public vec2 xy => new vec2(x, y);
        
        /// <summary>
        /// Returns vec3.xyx swizzling.
        /// </summary>
        public vec3 xyx => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec3.xyxx swizzling.
        /// </summary>
        public vec4 xyxx => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec3.xyxy swizzling.
        /// </summary>
        public vec4 xyxy => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec3.xyxz swizzling.
        /// </summary>
        public vec4 xyxz => new vec4(x, y, x, z);
        
        /// <summary>
        /// Returns vec3.xyy swizzling.
        /// </summary>
        public vec3 xyy => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec3.xyyx swizzling.
        /// </summary>
        public vec4 xyyx => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec3.xyyy swizzling.
        /// </summary>
        public vec4 xyyy => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec3.xyyz swizzling.
        /// </summary>
        public vec4 xyyz => new vec4(x, y, y, z);
        
        /// <summary>
        /// Returns vec3.xyz swizzling.
        /// </summary>
        public vec3 xyz => new vec3(x, y, z);
        
        /// <summary>
        /// Returns vec3.xyzx swizzling.
        /// </summary>
        public vec4 xyzx => new vec4(x, y, z, x);
        
        /// <summary>
        /// Returns vec3.xyzy swizzling.
        /// </summary>
        public vec4 xyzy => new vec4(x, y, z, y);
        
        /// <summary>
        /// Returns vec3.xyzz swizzling.
        /// </summary>
        public vec4 xyzz => new vec4(x, y, z, z);
        
        /// <summary>
        /// Returns vec3.xz swizzling.
        /// </summary>
        public vec2 xz => new vec2(x, z);
        
        /// <summary>
        /// Returns vec3.xzx swizzling.
        /// </summary>
        public vec3 xzx => new vec3(x, z, x);
        
        /// <summary>
        /// Returns vec3.xzxx swizzling.
        /// </summary>
        public vec4 xzxx => new vec4(x, z, x, x);
        
        /// <summary>
        /// Returns vec3.xzxy swizzling.
        /// </summary>
        public vec4 xzxy => new vec4(x, z, x, y);
        
        /// <summary>
        /// Returns vec3.xzxz swizzling.
        /// </summary>
        public vec4 xzxz => new vec4(x, z, x, z);
        
        /// <summary>
        /// Returns vec3.xzy swizzling.
        /// </summary>
        public vec3 xzy => new vec3(x, z, y);
        
        /// <summary>
        /// Returns vec3.xzyx swizzling.
        /// </summary>
        public vec4 xzyx => new vec4(x, z, y, x);
        
        /// <summary>
        /// Returns vec3.xzyy swizzling.
        /// </summary>
        public vec4 xzyy => new vec4(x, z, y, y);
        
        /// <summary>
        /// Returns vec3.xzyz swizzling.
        /// </summary>
        public vec4 xzyz => new vec4(x, z, y, z);
        
        /// <summary>
        /// Returns vec3.xzz swizzling.
        /// </summary>
        public vec3 xzz => new vec3(x, z, z);
        
        /// <summary>
        /// Returns vec3.xzzx swizzling.
        /// </summary>
        public vec4 xzzx => new vec4(x, z, z, x);
        
        /// <summary>
        /// Returns vec3.xzzy swizzling.
        /// </summary>
        public vec4 xzzy => new vec4(x, z, z, y);
        
        /// <summary>
        /// Returns vec3.xzzz swizzling.
        /// </summary>
        public vec4 xzzz => new vec4(x, z, z, z);
        
        /// <summary>
        /// Returns vec3.yx swizzling.
        /// </summary>
        public vec2 yx => new vec2(y, x);
        
        /// <summary>
        /// Returns vec3.yxx swizzling.
        /// </summary>
        public vec3 yxx => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec3.yxxx swizzling.
        /// </summary>
        public vec4 yxxx => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec3.yxxy swizzling.
        /// </summary>
        public vec4 yxxy => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec3.yxxz swizzling.
        /// </summary>
        public vec4 yxxz => new vec4(y, x, x, z);
        
        /// <summary>
        /// Returns vec3.yxy swizzling.
        /// </summary>
        public vec3 yxy => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec3.yxyx swizzling.
        /// </summary>
        public vec4 yxyx => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec3.yxyy swizzling.
        /// </summary>
        public vec4 yxyy => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec3.yxyz swizzling.
        /// </summary>
        public vec4 yxyz => new vec4(y, x, y, z);
        
        /// <summary>
        /// Returns vec3.yxz swizzling.
        /// </summary>
        public vec3 yxz => new vec3(y, x, z);
        
        /// <summary>
        /// Returns vec3.yxzx swizzling.
        /// </summary>
        public vec4 yxzx => new vec4(y, x, z, x);
        
        /// <summary>
        /// Returns vec3.yxzy swizzling.
        /// </summary>
        public vec4 yxzy => new vec4(y, x, z, y);
        
        /// <summary>
        /// Returns vec3.yxzz swizzling.
        /// </summary>
        public vec4 yxzz => new vec4(y, x, z, z);
        
        /// <summary>
        /// Returns vec3.yy swizzling.
        /// </summary>
        public vec2 yy => new vec2(y, y);
        
        /// <summary>
        /// Returns vec3.yyx swizzling.
        /// </summary>
        public vec3 yyx => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec3.yyxx swizzling.
        /// </summary>
        public vec4 yyxx => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec3.yyxy swizzling.
        /// </summary>
        public vec4 yyxy => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec3.yyxz swizzling.
        /// </summary>
        public vec4 yyxz => new vec4(y, y, x, z);
        
        /// <summary>
        /// Returns vec3.yyy swizzling.
        /// </summary>
        public vec3 yyy => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec3.yyyx swizzling.
        /// </summary>
        public vec4 yyyx => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec3.yyyy swizzling.
        /// </summary>
        public vec4 yyyy => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec3.yyyz swizzling.
        /// </summary>
        public vec4 yyyz => new vec4(y, y, y, z);
        
        /// <summary>
        /// Returns vec3.yyz swizzling.
        /// </summary>
        public vec3 yyz => new vec3(y, y, z);
        
        /// <summary>
        /// Returns vec3.yyzx swizzling.
        /// </summary>
        public vec4 yyzx => new vec4(y, y, z, x);
        
        /// <summary>
        /// Returns vec3.yyzy swizzling.
        /// </summary>
        public vec4 yyzy => new vec4(y, y, z, y);
        
        /// <summary>
        /// Returns vec3.yyzz swizzling.
        /// </summary>
        public vec4 yyzz => new vec4(y, y, z, z);
        
        /// <summary>
        /// Returns vec3.yz swizzling.
        /// </summary>
        public vec2 yz => new vec2(y, z);
        
        /// <summary>
        /// Returns vec3.yzx swizzling.
        /// </summary>
        public vec3 yzx => new vec3(y, z, x);
        
        /// <summary>
        /// Returns vec3.yzxx swizzling.
        /// </summary>
        public vec4 yzxx => new vec4(y, z, x, x);
        
        /// <summary>
        /// Returns vec3.yzxy swizzling.
        /// </summary>
        public vec4 yzxy => new vec4(y, z, x, y);
        
        /// <summary>
        /// Returns vec3.yzxz swizzling.
        /// </summary>
        public vec4 yzxz => new vec4(y, z, x, z);
        
        /// <summary>
        /// Returns vec3.yzy swizzling.
        /// </summary>
        public vec3 yzy => new vec3(y, z, y);
        
        /// <summary>
        /// Returns vec3.yzyx swizzling.
        /// </summary>
        public vec4 yzyx => new vec4(y, z, y, x);
        
        /// <summary>
        /// Returns vec3.yzyy swizzling.
        /// </summary>
        public vec4 yzyy => new vec4(y, z, y, y);
        
        /// <summary>
        /// Returns vec3.yzyz swizzling.
        /// </summary>
        public vec4 yzyz => new vec4(y, z, y, z);
        
        /// <summary>
        /// Returns vec3.yzz swizzling.
        /// </summary>
        public vec3 yzz => new vec3(y, z, z);
        
        /// <summary>
        /// Returns vec3.yzzx swizzling.
        /// </summary>
        public vec4 yzzx => new vec4(y, z, z, x);
        
        /// <summary>
        /// Returns vec3.yzzy swizzling.
        /// </summary>
        public vec4 yzzy => new vec4(y, z, z, y);
        
        /// <summary>
        /// Returns vec3.yzzz swizzling.
        /// </summary>
        public vec4 yzzz => new vec4(y, z, z, z);
        
        /// <summary>
        /// Returns vec3.zx swizzling.
        /// </summary>
        public vec2 zx => new vec2(z, x);
        
        /// <summary>
        /// Returns vec3.zxx swizzling.
        /// </summary>
        public vec3 zxx => new vec3(z, x, x);
        
        /// <summary>
        /// Returns vec3.zxxx swizzling.
        /// </summary>
        public vec4 zxxx => new vec4(z, x, x, x);
        
        /// <summary>
        /// Returns vec3.zxxy swizzling.
        /// </summary>
        public vec4 zxxy => new vec4(z, x, x, y);
        
        /// <summary>
        /// Returns vec3.zxxz swizzling.
        /// </summary>
        public vec4 zxxz => new vec4(z, x, x, z);
        
        /// <summary>
        /// Returns vec3.zxy swizzling.
        /// </summary>
        public vec3 zxy => new vec3(z, x, y);
        
        /// <summary>
        /// Returns vec3.zxyx swizzling.
        /// </summary>
        public vec4 zxyx => new vec4(z, x, y, x);
        
        /// <summary>
        /// Returns vec3.zxyy swizzling.
        /// </summary>
        public vec4 zxyy => new vec4(z, x, y, y);
        
        /// <summary>
        /// Returns vec3.zxyz swizzling.
        /// </summary>
        public vec4 zxyz => new vec4(z, x, y, z);
        
        /// <summary>
        /// Returns vec3.zxz swizzling.
        /// </summary>
        public vec3 zxz => new vec3(z, x, z);
        
        /// <summary>
        /// Returns vec3.zxzx swizzling.
        /// </summary>
        public vec4 zxzx => new vec4(z, x, z, x);
        
        /// <summary>
        /// Returns vec3.zxzy swizzling.
        /// </summary>
        public vec4 zxzy => new vec4(z, x, z, y);
        
        /// <summary>
        /// Returns vec3.zxzz swizzling.
        /// </summary>
        public vec4 zxzz => new vec4(z, x, z, z);
        
        /// <summary>
        /// Returns vec3.zy swizzling.
        /// </summary>
        public vec2 zy => new vec2(z, y);
        
        /// <summary>
        /// Returns vec3.zyx swizzling.
        /// </summary>
        public vec3 zyx => new vec3(z, y, x);
        
        /// <summary>
        /// Returns vec3.zyxx swizzling.
        /// </summary>
        public vec4 zyxx => new vec4(z, y, x, x);
        
        /// <summary>
        /// Returns vec3.zyxy swizzling.
        /// </summary>
        public vec4 zyxy => new vec4(z, y, x, y);
        
        /// <summary>
        /// Returns vec3.zyxz swizzling.
        /// </summary>
        public vec4 zyxz => new vec4(z, y, x, z);
        
        /// <summary>
        /// Returns vec3.zyy swizzling.
        /// </summary>
        public vec3 zyy => new vec3(z, y, y);
        
        /// <summary>
        /// Returns vec3.zyyx swizzling.
        /// </summary>
        public vec4 zyyx => new vec4(z, y, y, x);
        
        /// <summary>
        /// Returns vec3.zyyy swizzling.
        /// </summary>
        public vec4 zyyy => new vec4(z, y, y, y);
        
        /// <summary>
        /// Returns vec3.zyyz swizzling.
        /// </summary>
        public vec4 zyyz => new vec4(z, y, y, z);
        
        /// <summary>
        /// Returns vec3.zyz swizzling.
        /// </summary>
        public vec3 zyz => new vec3(z, y, z);
        
        /// <summary>
        /// Returns vec3.zyzx swizzling.
        /// </summary>
        public vec4 zyzx => new vec4(z, y, z, x);
        
        /// <summary>
        /// Returns vec3.zyzy swizzling.
        /// </summary>
        public vec4 zyzy => new vec4(z, y, z, y);
        
        /// <summary>
        /// Returns vec3.zyzz swizzling.
        /// </summary>
        public vec4 zyzz => new vec4(z, y, z, z);
        
        /// <summary>
        /// Returns vec3.zz swizzling.
        /// </summary>
        public vec2 zz => new vec2(z, z);
        
        /// <summary>
        /// Returns vec3.zzx swizzling.
        /// </summary>
        public vec3 zzx => new vec3(z, z, x);
        
        /// <summary>
        /// Returns vec3.zzxx swizzling.
        /// </summary>
        public vec4 zzxx => new vec4(z, z, x, x);
        
        /// <summary>
        /// Returns vec3.zzxy swizzling.
        /// </summary>
        public vec4 zzxy => new vec4(z, z, x, y);
        
        /// <summary>
        /// Returns vec3.zzxz swizzling.
        /// </summary>
        public vec4 zzxz => new vec4(z, z, x, z);
        
        /// <summary>
        /// Returns vec3.zzy swizzling.
        /// </summary>
        public vec3 zzy => new vec3(z, z, y);
        
        /// <summary>
        /// Returns vec3.zzyx swizzling.
        /// </summary>
        public vec4 zzyx => new vec4(z, z, y, x);
        
        /// <summary>
        /// Returns vec3.zzyy swizzling.
        /// </summary>
        public vec4 zzyy => new vec4(z, z, y, y);
        
        /// <summary>
        /// Returns vec3.zzyz swizzling.
        /// </summary>
        public vec4 zzyz => new vec4(z, z, y, z);
        
        /// <summary>
        /// Returns vec3.zzz swizzling.
        /// </summary>
        public vec3 zzz => new vec3(z, z, z);
        
        /// <summary>
        /// Returns vec3.zzzx swizzling.
        /// </summary>
        public vec4 zzzx => new vec4(z, z, z, x);
        
        /// <summary>
        /// Returns vec3.zzzy swizzling.
        /// </summary>
        public vec4 zzzy => new vec4(z, z, z, y);
        
        /// <summary>
        /// Returns vec3.zzzz swizzling.
        /// </summary>
        public vec4 zzzz => new vec4(z, z, z, z);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns vec3.rr swizzling.
        /// </summary>
        public vec2 rr => new vec2(x, x);
        
        /// <summary>
        /// Returns vec3.rrr swizzling.
        /// </summary>
        public vec3 rrr => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec3.rrrr swizzling.
        /// </summary>
        public vec4 rrrr => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec3.rrrg swizzling.
        /// </summary>
        public vec4 rrrg => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec3.rrrb swizzling.
        /// </summary>
        public vec4 rrrb => new vec4(x, x, x, z);
        
        /// <summary>
        /// Returns vec3.rrg swizzling.
        /// </summary>
        public vec3 rrg => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec3.rrgr swizzling.
        /// </summary>
        public vec4 rrgr => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec3.rrgg swizzling.
        /// </summary>
        public vec4 rrgg => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec3.rrgb swizzling.
        /// </summary>
        public vec4 rrgb => new vec4(x, x, y, z);
        
        /// <summary>
        /// Returns vec3.rrb swizzling.
        /// </summary>
        public vec3 rrb => new vec3(x, x, z);
        
        /// <summary>
        /// Returns vec3.rrbr swizzling.
        /// </summary>
        public vec4 rrbr => new vec4(x, x, z, x);
        
        /// <summary>
        /// Returns vec3.rrbg swizzling.
        /// </summary>
        public vec4 rrbg => new vec4(x, x, z, y);
        
        /// <summary>
        /// Returns vec3.rrbb swizzling.
        /// </summary>
        public vec4 rrbb => new vec4(x, x, z, z);
        
        /// <summary>
        /// Returns vec3.rg swizzling.
        /// </summary>
        public vec2 rg => new vec2(x, y);
        
        /// <summary>
        /// Returns vec3.rgr swizzling.
        /// </summary>
        public vec3 rgr => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec3.rgrr swizzling.
        /// </summary>
        public vec4 rgrr => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec3.rgrg swizzling.
        /// </summary>
        public vec4 rgrg => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec3.rgrb swizzling.
        /// </summary>
        public vec4 rgrb => new vec4(x, y, x, z);
        
        /// <summary>
        /// Returns vec3.rgg swizzling.
        /// </summary>
        public vec3 rgg => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec3.rggr swizzling.
        /// </summary>
        public vec4 rggr => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec3.rggg swizzling.
        /// </summary>
        public vec4 rggg => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec3.rggb swizzling.
        /// </summary>
        public vec4 rggb => new vec4(x, y, y, z);
        
        /// <summary>
        /// Returns vec3.rgb swizzling.
        /// </summary>
        public vec3 rgb => new vec3(x, y, z);
        
        /// <summary>
        /// Returns vec3.rgbr swizzling.
        /// </summary>
        public vec4 rgbr => new vec4(x, y, z, x);
        
        /// <summary>
        /// Returns vec3.rgbg swizzling.
        /// </summary>
        public vec4 rgbg => new vec4(x, y, z, y);
        
        /// <summary>
        /// Returns vec3.rgbb swizzling.
        /// </summary>
        public vec4 rgbb => new vec4(x, y, z, z);
        
        /// <summary>
        /// Returns vec3.rb swizzling.
        /// </summary>
        public vec2 rb => new vec2(x, z);
        
        /// <summary>
        /// Returns vec3.rbr swizzling.
        /// </summary>
        public vec3 rbr => new vec3(x, z, x);
        
        /// <summary>
        /// Returns vec3.rbrr swizzling.
        /// </summary>
        public vec4 rbrr => new vec4(x, z, x, x);
        
        /// <summary>
        /// Returns vec3.rbrg swizzling.
        /// </summary>
        public vec4 rbrg => new vec4(x, z, x, y);
        
        /// <summary>
        /// Returns vec3.rbrb swizzling.
        /// </summary>
        public vec4 rbrb => new vec4(x, z, x, z);
        
        /// <summary>
        /// Returns vec3.rbg swizzling.
        /// </summary>
        public vec3 rbg => new vec3(x, z, y);
        
        /// <summary>
        /// Returns vec3.rbgr swizzling.
        /// </summary>
        public vec4 rbgr => new vec4(x, z, y, x);
        
        /// <summary>
        /// Returns vec3.rbgg swizzling.
        /// </summary>
        public vec4 rbgg => new vec4(x, z, y, y);
        
        /// <summary>
        /// Returns vec3.rbgb swizzling.
        /// </summary>
        public vec4 rbgb => new vec4(x, z, y, z);
        
        /// <summary>
        /// Returns vec3.rbb swizzling.
        /// </summary>
        public vec3 rbb => new vec3(x, z, z);
        
        /// <summary>
        /// Returns vec3.rbbr swizzling.
        /// </summary>
        public vec4 rbbr => new vec4(x, z, z, x);
        
        /// <summary>
        /// Returns vec3.rbbg swizzling.
        /// </summary>
        public vec4 rbbg => new vec4(x, z, z, y);
        
        /// <summary>
        /// Returns vec3.rbbb swizzling.
        /// </summary>
        public vec4 rbbb => new vec4(x, z, z, z);
        
        /// <summary>
        /// Returns vec3.gr swizzling.
        /// </summary>
        public vec2 gr => new vec2(y, x);
        
        /// <summary>
        /// Returns vec3.grr swizzling.
        /// </summary>
        public vec3 grr => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec3.grrr swizzling.
        /// </summary>
        public vec4 grrr => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec3.grrg swizzling.
        /// </summary>
        public vec4 grrg => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec3.grrb swizzling.
        /// </summary>
        public vec4 grrb => new vec4(y, x, x, z);
        
        /// <summary>
        /// Returns vec3.grg swizzling.
        /// </summary>
        public vec3 grg => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec3.grgr swizzling.
        /// </summary>
        public vec4 grgr => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec3.grgg swizzling.
        /// </summary>
        public vec4 grgg => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec3.grgb swizzling.
        /// </summary>
        public vec4 grgb => new vec4(y, x, y, z);
        
        /// <summary>
        /// Returns vec3.grb swizzling.
        /// </summary>
        public vec3 grb => new vec3(y, x, z);
        
        /// <summary>
        /// Returns vec3.grbr swizzling.
        /// </summary>
        public vec4 grbr => new vec4(y, x, z, x);
        
        /// <summary>
        /// Returns vec3.grbg swizzling.
        /// </summary>
        public vec4 grbg => new vec4(y, x, z, y);
        
        /// <summary>
        /// Returns vec3.grbb swizzling.
        /// </summary>
        public vec4 grbb => new vec4(y, x, z, z);
        
        /// <summary>
        /// Returns vec3.gg swizzling.
        /// </summary>
        public vec2 gg => new vec2(y, y);
        
        /// <summary>
        /// Returns vec3.ggr swizzling.
        /// </summary>
        public vec3 ggr => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec3.ggrr swizzling.
        /// </summary>
        public vec4 ggrr => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec3.ggrg swizzling.
        /// </summary>
        public vec4 ggrg => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec3.ggrb swizzling.
        /// </summary>
        public vec4 ggrb => new vec4(y, y, x, z);
        
        /// <summary>
        /// Returns vec3.ggg swizzling.
        /// </summary>
        public vec3 ggg => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec3.gggr swizzling.
        /// </summary>
        public vec4 gggr => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec3.gggg swizzling.
        /// </summary>
        public vec4 gggg => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec3.gggb swizzling.
        /// </summary>
        public vec4 gggb => new vec4(y, y, y, z);
        
        /// <summary>
        /// Returns vec3.ggb swizzling.
        /// </summary>
        public vec3 ggb => new vec3(y, y, z);
        
        /// <summary>
        /// Returns vec3.ggbr swizzling.
        /// </summary>
        public vec4 ggbr => new vec4(y, y, z, x);
        
        /// <summary>
        /// Returns vec3.ggbg swizzling.
        /// </summary>
        public vec4 ggbg => new vec4(y, y, z, y);
        
        /// <summary>
        /// Returns vec3.ggbb swizzling.
        /// </summary>
        public vec4 ggbb => new vec4(y, y, z, z);
        
        /// <summary>
        /// Returns vec3.gb swizzling.
        /// </summary>
        public vec2 gb => new vec2(y, z);
        
        /// <summary>
        /// Returns vec3.gbr swizzling.
        /// </summary>
        public vec3 gbr => new vec3(y, z, x);
        
        /// <summary>
        /// Returns vec3.gbrr swizzling.
        /// </summary>
        public vec4 gbrr => new vec4(y, z, x, x);
        
        /// <summary>
        /// Returns vec3.gbrg swizzling.
        /// </summary>
        public vec4 gbrg => new vec4(y, z, x, y);
        
        /// <summary>
        /// Returns vec3.gbrb swizzling.
        /// </summary>
        public vec4 gbrb => new vec4(y, z, x, z);
        
        /// <summary>
        /// Returns vec3.gbg swizzling.
        /// </summary>
        public vec3 gbg => new vec3(y, z, y);
        
        /// <summary>
        /// Returns vec3.gbgr swizzling.
        /// </summary>
        public vec4 gbgr => new vec4(y, z, y, x);
        
        /// <summary>
        /// Returns vec3.gbgg swizzling.
        /// </summary>
        public vec4 gbgg => new vec4(y, z, y, y);
        
        /// <summary>
        /// Returns vec3.gbgb swizzling.
        /// </summary>
        public vec4 gbgb => new vec4(y, z, y, z);
        
        /// <summary>
        /// Returns vec3.gbb swizzling.
        /// </summary>
        public vec3 gbb => new vec3(y, z, z);
        
        /// <summary>
        /// Returns vec3.gbbr swizzling.
        /// </summary>
        public vec4 gbbr => new vec4(y, z, z, x);
        
        /// <summary>
        /// Returns vec3.gbbg swizzling.
        /// </summary>
        public vec4 gbbg => new vec4(y, z, z, y);
        
        /// <summary>
        /// Returns vec3.gbbb swizzling.
        /// </summary>
        public vec4 gbbb => new vec4(y, z, z, z);
        
        /// <summary>
        /// Returns vec3.br swizzling.
        /// </summary>
        public vec2 br => new vec2(z, x);
        
        /// <summary>
        /// Returns vec3.brr swizzling.
        /// </summary>
        public vec3 brr => new vec3(z, x, x);
        
        /// <summary>
        /// Returns vec3.brrr swizzling.
        /// </summary>
        public vec4 brrr => new vec4(z, x, x, x);
        
        /// <summary>
        /// Returns vec3.brrg swizzling.
        /// </summary>
        public vec4 brrg => new vec4(z, x, x, y);
        
        /// <summary>
        /// Returns vec3.brrb swizzling.
        /// </summary>
        public vec4 brrb => new vec4(z, x, x, z);
        
        /// <summary>
        /// Returns vec3.brg swizzling.
        /// </summary>
        public vec3 brg => new vec3(z, x, y);
        
        /// <summary>
        /// Returns vec3.brgr swizzling.
        /// </summary>
        public vec4 brgr => new vec4(z, x, y, x);
        
        /// <summary>
        /// Returns vec3.brgg swizzling.
        /// </summary>
        public vec4 brgg => new vec4(z, x, y, y);
        
        /// <summary>
        /// Returns vec3.brgb swizzling.
        /// </summary>
        public vec4 brgb => new vec4(z, x, y, z);
        
        /// <summary>
        /// Returns vec3.brb swizzling.
        /// </summary>
        public vec3 brb => new vec3(z, x, z);
        
        /// <summary>
        /// Returns vec3.brbr swizzling.
        /// </summary>
        public vec4 brbr => new vec4(z, x, z, x);
        
        /// <summary>
        /// Returns vec3.brbg swizzling.
        /// </summary>
        public vec4 brbg => new vec4(z, x, z, y);
        
        /// <summary>
        /// Returns vec3.brbb swizzling.
        /// </summary>
        public vec4 brbb => new vec4(z, x, z, z);
        
        /// <summary>
        /// Returns vec3.bg swizzling.
        /// </summary>
        public vec2 bg => new vec2(z, y);
        
        /// <summary>
        /// Returns vec3.bgr swizzling.
        /// </summary>
        public vec3 bgr => new vec3(z, y, x);
        
        /// <summary>
        /// Returns vec3.bgrr swizzling.
        /// </summary>
        public vec4 bgrr => new vec4(z, y, x, x);
        
        /// <summary>
        /// Returns vec3.bgrg swizzling.
        /// </summary>
        public vec4 bgrg => new vec4(z, y, x, y);
        
        /// <summary>
        /// Returns vec3.bgrb swizzling.
        /// </summary>
        public vec4 bgrb => new vec4(z, y, x, z);
        
        /// <summary>
        /// Returns vec3.bgg swizzling.
        /// </summary>
        public vec3 bgg => new vec3(z, y, y);
        
        /// <summary>
        /// Returns vec3.bggr swizzling.
        /// </summary>
        public vec4 bggr => new vec4(z, y, y, x);
        
        /// <summary>
        /// Returns vec3.bggg swizzling.
        /// </summary>
        public vec4 bggg => new vec4(z, y, y, y);
        
        /// <summary>
        /// Returns vec3.bggb swizzling.
        /// </summary>
        public vec4 bggb => new vec4(z, y, y, z);
        
        /// <summary>
        /// Returns vec3.bgb swizzling.
        /// </summary>
        public vec3 bgb => new vec3(z, y, z);
        
        /// <summary>
        /// Returns vec3.bgbr swizzling.
        /// </summary>
        public vec4 bgbr => new vec4(z, y, z, x);
        
        /// <summary>
        /// Returns vec3.bgbg swizzling.
        /// </summary>
        public vec4 bgbg => new vec4(z, y, z, y);
        
        /// <summary>
        /// Returns vec3.bgbb swizzling.
        /// </summary>
        public vec4 bgbb => new vec4(z, y, z, z);
        
        /// <summary>
        /// Returns vec3.bb swizzling.
        /// </summary>
        public vec2 bb => new vec2(z, z);
        
        /// <summary>
        /// Returns vec3.bbr swizzling.
        /// </summary>
        public vec3 bbr => new vec3(z, z, x);
        
        /// <summary>
        /// Returns vec3.bbrr swizzling.
        /// </summary>
        public vec4 bbrr => new vec4(z, z, x, x);
        
        /// <summary>
        /// Returns vec3.bbrg swizzling.
        /// </summary>
        public vec4 bbrg => new vec4(z, z, x, y);
        
        /// <summary>
        /// Returns vec3.bbrb swizzling.
        /// </summary>
        public vec4 bbrb => new vec4(z, z, x, z);
        
        /// <summary>
        /// Returns vec3.bbg swizzling.
        /// </summary>
        public vec3 bbg => new vec3(z, z, y);
        
        /// <summary>
        /// Returns vec3.bbgr swizzling.
        /// </summary>
        public vec4 bbgr => new vec4(z, z, y, x);
        
        /// <summary>
        /// Returns vec3.bbgg swizzling.
        /// </summary>
        public vec4 bbgg => new vec4(z, z, y, y);
        
        /// <summary>
        /// Returns vec3.bbgb swizzling.
        /// </summary>
        public vec4 bbgb => new vec4(z, z, y, z);
        
        /// <summary>
        /// Returns vec3.bbb swizzling.
        /// </summary>
        public vec3 bbb => new vec3(z, z, z);
        
        /// <summary>
        /// Returns vec3.bbbr swizzling.
        /// </summary>
        public vec4 bbbr => new vec4(z, z, z, x);
        
        /// <summary>
        /// Returns vec3.bbbg swizzling.
        /// </summary>
        public vec4 bbbg => new vec4(z, z, z, y);
        
        /// <summary>
        /// Returns vec3.bbbb swizzling.
        /// </summary>
        public vec4 bbbb => new vec4(z, z, z, z);
    }
}
