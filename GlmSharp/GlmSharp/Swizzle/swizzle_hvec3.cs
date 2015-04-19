using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp.Swizzle
{
    
    /// <summary>
    /// Temporary vector of type Half with 3 components, used for implementing swizzling for hvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_hvec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly Half x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly Half y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly Half z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_hvec3.
        /// </summary>
        internal swizzle_hvec3(Half x, Half y, Half z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns hvec3.xx swizzling.
        /// </summary>
        public hvec2 xx => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec3.rr swizzling (equivalent to hvec3.xx).
        /// </summary>
        public hvec2 rr => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec3.xxx swizzling.
        /// </summary>
        public hvec3 xxx => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec3.rrr swizzling (equivalent to hvec3.xxx).
        /// </summary>
        public hvec3 rrr => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec3.xxxx swizzling.
        /// </summary>
        public hvec4 xxxx => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.rrrr swizzling (equivalent to hvec3.xxxx).
        /// </summary>
        public hvec4 rrrr => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec3.xxxy swizzling.
        /// </summary>
        public hvec4 xxxy => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.rrrg swizzling (equivalent to hvec3.xxxy).
        /// </summary>
        public hvec4 rrrg => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec3.xxxz swizzling.
        /// </summary>
        public hvec4 xxxz => new hvec4(x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.rrrb swizzling (equivalent to hvec3.xxxz).
        /// </summary>
        public hvec4 rrrb => new hvec4(x, x, x, z);
        
        /// <summary>
        /// Returns hvec3.xxy swizzling.
        /// </summary>
        public hvec3 xxy => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec3.rrg swizzling (equivalent to hvec3.xxy).
        /// </summary>
        public hvec3 rrg => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec3.xxyx swizzling.
        /// </summary>
        public hvec4 xxyx => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.rrgr swizzling (equivalent to hvec3.xxyx).
        /// </summary>
        public hvec4 rrgr => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec3.xxyy swizzling.
        /// </summary>
        public hvec4 xxyy => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.rrgg swizzling (equivalent to hvec3.xxyy).
        /// </summary>
        public hvec4 rrgg => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec3.xxyz swizzling.
        /// </summary>
        public hvec4 xxyz => new hvec4(x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.rrgb swizzling (equivalent to hvec3.xxyz).
        /// </summary>
        public hvec4 rrgb => new hvec4(x, x, y, z);
        
        /// <summary>
        /// Returns hvec3.xxz swizzling.
        /// </summary>
        public hvec3 xxz => new hvec3(x, x, z);
        
        /// <summary>
        /// Returns hvec3.rrb swizzling (equivalent to hvec3.xxz).
        /// </summary>
        public hvec3 rrb => new hvec3(x, x, z);
        
        /// <summary>
        /// Returns hvec3.xxzx swizzling.
        /// </summary>
        public hvec4 xxzx => new hvec4(x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.rrbr swizzling (equivalent to hvec3.xxzx).
        /// </summary>
        public hvec4 rrbr => new hvec4(x, x, z, x);
        
        /// <summary>
        /// Returns hvec3.xxzy swizzling.
        /// </summary>
        public hvec4 xxzy => new hvec4(x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.rrbg swizzling (equivalent to hvec3.xxzy).
        /// </summary>
        public hvec4 rrbg => new hvec4(x, x, z, y);
        
        /// <summary>
        /// Returns hvec3.xxzz swizzling.
        /// </summary>
        public hvec4 xxzz => new hvec4(x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.rrbb swizzling (equivalent to hvec3.xxzz).
        /// </summary>
        public hvec4 rrbb => new hvec4(x, x, z, z);
        
        /// <summary>
        /// Returns hvec3.xy swizzling.
        /// </summary>
        public hvec2 xy => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec3.rg swizzling (equivalent to hvec3.xy).
        /// </summary>
        public hvec2 rg => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec3.xyx swizzling.
        /// </summary>
        public hvec3 xyx => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec3.rgr swizzling (equivalent to hvec3.xyx).
        /// </summary>
        public hvec3 rgr => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec3.xyxx swizzling.
        /// </summary>
        public hvec4 xyxx => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.rgrr swizzling (equivalent to hvec3.xyxx).
        /// </summary>
        public hvec4 rgrr => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec3.xyxy swizzling.
        /// </summary>
        public hvec4 xyxy => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.rgrg swizzling (equivalent to hvec3.xyxy).
        /// </summary>
        public hvec4 rgrg => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec3.xyxz swizzling.
        /// </summary>
        public hvec4 xyxz => new hvec4(x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.rgrb swizzling (equivalent to hvec3.xyxz).
        /// </summary>
        public hvec4 rgrb => new hvec4(x, y, x, z);
        
        /// <summary>
        /// Returns hvec3.xyy swizzling.
        /// </summary>
        public hvec3 xyy => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec3.rgg swizzling (equivalent to hvec3.xyy).
        /// </summary>
        public hvec3 rgg => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec3.xyyx swizzling.
        /// </summary>
        public hvec4 xyyx => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.rggr swizzling (equivalent to hvec3.xyyx).
        /// </summary>
        public hvec4 rggr => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec3.xyyy swizzling.
        /// </summary>
        public hvec4 xyyy => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.rggg swizzling (equivalent to hvec3.xyyy).
        /// </summary>
        public hvec4 rggg => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec3.xyyz swizzling.
        /// </summary>
        public hvec4 xyyz => new hvec4(x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.rggb swizzling (equivalent to hvec3.xyyz).
        /// </summary>
        public hvec4 rggb => new hvec4(x, y, y, z);
        
        /// <summary>
        /// Returns hvec3.xyz swizzling.
        /// </summary>
        public hvec3 xyz => new hvec3(x, y, z);
        
        /// <summary>
        /// Returns hvec3.rgb swizzling (equivalent to hvec3.xyz).
        /// </summary>
        public hvec3 rgb => new hvec3(x, y, z);
        
        /// <summary>
        /// Returns hvec3.xyzx swizzling.
        /// </summary>
        public hvec4 xyzx => new hvec4(x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.rgbr swizzling (equivalent to hvec3.xyzx).
        /// </summary>
        public hvec4 rgbr => new hvec4(x, y, z, x);
        
        /// <summary>
        /// Returns hvec3.xyzy swizzling.
        /// </summary>
        public hvec4 xyzy => new hvec4(x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.rgbg swizzling (equivalent to hvec3.xyzy).
        /// </summary>
        public hvec4 rgbg => new hvec4(x, y, z, y);
        
        /// <summary>
        /// Returns hvec3.xyzz swizzling.
        /// </summary>
        public hvec4 xyzz => new hvec4(x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.rgbb swizzling (equivalent to hvec3.xyzz).
        /// </summary>
        public hvec4 rgbb => new hvec4(x, y, z, z);
        
        /// <summary>
        /// Returns hvec3.xz swizzling.
        /// </summary>
        public hvec2 xz => new hvec2(x, z);
        
        /// <summary>
        /// Returns hvec3.rb swizzling (equivalent to hvec3.xz).
        /// </summary>
        public hvec2 rb => new hvec2(x, z);
        
        /// <summary>
        /// Returns hvec3.xzx swizzling.
        /// </summary>
        public hvec3 xzx => new hvec3(x, z, x);
        
        /// <summary>
        /// Returns hvec3.rbr swizzling (equivalent to hvec3.xzx).
        /// </summary>
        public hvec3 rbr => new hvec3(x, z, x);
        
        /// <summary>
        /// Returns hvec3.xzxx swizzling.
        /// </summary>
        public hvec4 xzxx => new hvec4(x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.rbrr swizzling (equivalent to hvec3.xzxx).
        /// </summary>
        public hvec4 rbrr => new hvec4(x, z, x, x);
        
        /// <summary>
        /// Returns hvec3.xzxy swizzling.
        /// </summary>
        public hvec4 xzxy => new hvec4(x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.rbrg swizzling (equivalent to hvec3.xzxy).
        /// </summary>
        public hvec4 rbrg => new hvec4(x, z, x, y);
        
        /// <summary>
        /// Returns hvec3.xzxz swizzling.
        /// </summary>
        public hvec4 xzxz => new hvec4(x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.rbrb swizzling (equivalent to hvec3.xzxz).
        /// </summary>
        public hvec4 rbrb => new hvec4(x, z, x, z);
        
        /// <summary>
        /// Returns hvec3.xzy swizzling.
        /// </summary>
        public hvec3 xzy => new hvec3(x, z, y);
        
        /// <summary>
        /// Returns hvec3.rbg swizzling (equivalent to hvec3.xzy).
        /// </summary>
        public hvec3 rbg => new hvec3(x, z, y);
        
        /// <summary>
        /// Returns hvec3.xzyx swizzling.
        /// </summary>
        public hvec4 xzyx => new hvec4(x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.rbgr swizzling (equivalent to hvec3.xzyx).
        /// </summary>
        public hvec4 rbgr => new hvec4(x, z, y, x);
        
        /// <summary>
        /// Returns hvec3.xzyy swizzling.
        /// </summary>
        public hvec4 xzyy => new hvec4(x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.rbgg swizzling (equivalent to hvec3.xzyy).
        /// </summary>
        public hvec4 rbgg => new hvec4(x, z, y, y);
        
        /// <summary>
        /// Returns hvec3.xzyz swizzling.
        /// </summary>
        public hvec4 xzyz => new hvec4(x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.rbgb swizzling (equivalent to hvec3.xzyz).
        /// </summary>
        public hvec4 rbgb => new hvec4(x, z, y, z);
        
        /// <summary>
        /// Returns hvec3.xzz swizzling.
        /// </summary>
        public hvec3 xzz => new hvec3(x, z, z);
        
        /// <summary>
        /// Returns hvec3.rbb swizzling (equivalent to hvec3.xzz).
        /// </summary>
        public hvec3 rbb => new hvec3(x, z, z);
        
        /// <summary>
        /// Returns hvec3.xzzx swizzling.
        /// </summary>
        public hvec4 xzzx => new hvec4(x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.rbbr swizzling (equivalent to hvec3.xzzx).
        /// </summary>
        public hvec4 rbbr => new hvec4(x, z, z, x);
        
        /// <summary>
        /// Returns hvec3.xzzy swizzling.
        /// </summary>
        public hvec4 xzzy => new hvec4(x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.rbbg swizzling (equivalent to hvec3.xzzy).
        /// </summary>
        public hvec4 rbbg => new hvec4(x, z, z, y);
        
        /// <summary>
        /// Returns hvec3.xzzz swizzling.
        /// </summary>
        public hvec4 xzzz => new hvec4(x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.rbbb swizzling (equivalent to hvec3.xzzz).
        /// </summary>
        public hvec4 rbbb => new hvec4(x, z, z, z);
        
        /// <summary>
        /// Returns hvec3.yx swizzling.
        /// </summary>
        public hvec2 yx => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec3.gr swizzling (equivalent to hvec3.yx).
        /// </summary>
        public hvec2 gr => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec3.yxx swizzling.
        /// </summary>
        public hvec3 yxx => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec3.grr swizzling (equivalent to hvec3.yxx).
        /// </summary>
        public hvec3 grr => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec3.yxxx swizzling.
        /// </summary>
        public hvec4 yxxx => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.grrr swizzling (equivalent to hvec3.yxxx).
        /// </summary>
        public hvec4 grrr => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec3.yxxy swizzling.
        /// </summary>
        public hvec4 yxxy => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.grrg swizzling (equivalent to hvec3.yxxy).
        /// </summary>
        public hvec4 grrg => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec3.yxxz swizzling.
        /// </summary>
        public hvec4 yxxz => new hvec4(y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.grrb swizzling (equivalent to hvec3.yxxz).
        /// </summary>
        public hvec4 grrb => new hvec4(y, x, x, z);
        
        /// <summary>
        /// Returns hvec3.yxy swizzling.
        /// </summary>
        public hvec3 yxy => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec3.grg swizzling (equivalent to hvec3.yxy).
        /// </summary>
        public hvec3 grg => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec3.yxyx swizzling.
        /// </summary>
        public hvec4 yxyx => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.grgr swizzling (equivalent to hvec3.yxyx).
        /// </summary>
        public hvec4 grgr => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec3.yxyy swizzling.
        /// </summary>
        public hvec4 yxyy => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.grgg swizzling (equivalent to hvec3.yxyy).
        /// </summary>
        public hvec4 grgg => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec3.yxyz swizzling.
        /// </summary>
        public hvec4 yxyz => new hvec4(y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.grgb swizzling (equivalent to hvec3.yxyz).
        /// </summary>
        public hvec4 grgb => new hvec4(y, x, y, z);
        
        /// <summary>
        /// Returns hvec3.yxz swizzling.
        /// </summary>
        public hvec3 yxz => new hvec3(y, x, z);
        
        /// <summary>
        /// Returns hvec3.grb swizzling (equivalent to hvec3.yxz).
        /// </summary>
        public hvec3 grb => new hvec3(y, x, z);
        
        /// <summary>
        /// Returns hvec3.yxzx swizzling.
        /// </summary>
        public hvec4 yxzx => new hvec4(y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.grbr swizzling (equivalent to hvec3.yxzx).
        /// </summary>
        public hvec4 grbr => new hvec4(y, x, z, x);
        
        /// <summary>
        /// Returns hvec3.yxzy swizzling.
        /// </summary>
        public hvec4 yxzy => new hvec4(y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.grbg swizzling (equivalent to hvec3.yxzy).
        /// </summary>
        public hvec4 grbg => new hvec4(y, x, z, y);
        
        /// <summary>
        /// Returns hvec3.yxzz swizzling.
        /// </summary>
        public hvec4 yxzz => new hvec4(y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.grbb swizzling (equivalent to hvec3.yxzz).
        /// </summary>
        public hvec4 grbb => new hvec4(y, x, z, z);
        
        /// <summary>
        /// Returns hvec3.yy swizzling.
        /// </summary>
        public hvec2 yy => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec3.gg swizzling (equivalent to hvec3.yy).
        /// </summary>
        public hvec2 gg => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec3.yyx swizzling.
        /// </summary>
        public hvec3 yyx => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec3.ggr swizzling (equivalent to hvec3.yyx).
        /// </summary>
        public hvec3 ggr => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec3.yyxx swizzling.
        /// </summary>
        public hvec4 yyxx => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.ggrr swizzling (equivalent to hvec3.yyxx).
        /// </summary>
        public hvec4 ggrr => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec3.yyxy swizzling.
        /// </summary>
        public hvec4 yyxy => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.ggrg swizzling (equivalent to hvec3.yyxy).
        /// </summary>
        public hvec4 ggrg => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec3.yyxz swizzling.
        /// </summary>
        public hvec4 yyxz => new hvec4(y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.ggrb swizzling (equivalent to hvec3.yyxz).
        /// </summary>
        public hvec4 ggrb => new hvec4(y, y, x, z);
        
        /// <summary>
        /// Returns hvec3.yyy swizzling.
        /// </summary>
        public hvec3 yyy => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec3.ggg swizzling (equivalent to hvec3.yyy).
        /// </summary>
        public hvec3 ggg => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec3.yyyx swizzling.
        /// </summary>
        public hvec4 yyyx => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.gggr swizzling (equivalent to hvec3.yyyx).
        /// </summary>
        public hvec4 gggr => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec3.yyyy swizzling.
        /// </summary>
        public hvec4 yyyy => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.gggg swizzling (equivalent to hvec3.yyyy).
        /// </summary>
        public hvec4 gggg => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec3.yyyz swizzling.
        /// </summary>
        public hvec4 yyyz => new hvec4(y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.gggb swizzling (equivalent to hvec3.yyyz).
        /// </summary>
        public hvec4 gggb => new hvec4(y, y, y, z);
        
        /// <summary>
        /// Returns hvec3.yyz swizzling.
        /// </summary>
        public hvec3 yyz => new hvec3(y, y, z);
        
        /// <summary>
        /// Returns hvec3.ggb swizzling (equivalent to hvec3.yyz).
        /// </summary>
        public hvec3 ggb => new hvec3(y, y, z);
        
        /// <summary>
        /// Returns hvec3.yyzx swizzling.
        /// </summary>
        public hvec4 yyzx => new hvec4(y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.ggbr swizzling (equivalent to hvec3.yyzx).
        /// </summary>
        public hvec4 ggbr => new hvec4(y, y, z, x);
        
        /// <summary>
        /// Returns hvec3.yyzy swizzling.
        /// </summary>
        public hvec4 yyzy => new hvec4(y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.ggbg swizzling (equivalent to hvec3.yyzy).
        /// </summary>
        public hvec4 ggbg => new hvec4(y, y, z, y);
        
        /// <summary>
        /// Returns hvec3.yyzz swizzling.
        /// </summary>
        public hvec4 yyzz => new hvec4(y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.ggbb swizzling (equivalent to hvec3.yyzz).
        /// </summary>
        public hvec4 ggbb => new hvec4(y, y, z, z);
        
        /// <summary>
        /// Returns hvec3.yz swizzling.
        /// </summary>
        public hvec2 yz => new hvec2(y, z);
        
        /// <summary>
        /// Returns hvec3.gb swizzling (equivalent to hvec3.yz).
        /// </summary>
        public hvec2 gb => new hvec2(y, z);
        
        /// <summary>
        /// Returns hvec3.yzx swizzling.
        /// </summary>
        public hvec3 yzx => new hvec3(y, z, x);
        
        /// <summary>
        /// Returns hvec3.gbr swizzling (equivalent to hvec3.yzx).
        /// </summary>
        public hvec3 gbr => new hvec3(y, z, x);
        
        /// <summary>
        /// Returns hvec3.yzxx swizzling.
        /// </summary>
        public hvec4 yzxx => new hvec4(y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.gbrr swizzling (equivalent to hvec3.yzxx).
        /// </summary>
        public hvec4 gbrr => new hvec4(y, z, x, x);
        
        /// <summary>
        /// Returns hvec3.yzxy swizzling.
        /// </summary>
        public hvec4 yzxy => new hvec4(y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.gbrg swizzling (equivalent to hvec3.yzxy).
        /// </summary>
        public hvec4 gbrg => new hvec4(y, z, x, y);
        
        /// <summary>
        /// Returns hvec3.yzxz swizzling.
        /// </summary>
        public hvec4 yzxz => new hvec4(y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.gbrb swizzling (equivalent to hvec3.yzxz).
        /// </summary>
        public hvec4 gbrb => new hvec4(y, z, x, z);
        
        /// <summary>
        /// Returns hvec3.yzy swizzling.
        /// </summary>
        public hvec3 yzy => new hvec3(y, z, y);
        
        /// <summary>
        /// Returns hvec3.gbg swizzling (equivalent to hvec3.yzy).
        /// </summary>
        public hvec3 gbg => new hvec3(y, z, y);
        
        /// <summary>
        /// Returns hvec3.yzyx swizzling.
        /// </summary>
        public hvec4 yzyx => new hvec4(y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.gbgr swizzling (equivalent to hvec3.yzyx).
        /// </summary>
        public hvec4 gbgr => new hvec4(y, z, y, x);
        
        /// <summary>
        /// Returns hvec3.yzyy swizzling.
        /// </summary>
        public hvec4 yzyy => new hvec4(y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.gbgg swizzling (equivalent to hvec3.yzyy).
        /// </summary>
        public hvec4 gbgg => new hvec4(y, z, y, y);
        
        /// <summary>
        /// Returns hvec3.yzyz swizzling.
        /// </summary>
        public hvec4 yzyz => new hvec4(y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.gbgb swizzling (equivalent to hvec3.yzyz).
        /// </summary>
        public hvec4 gbgb => new hvec4(y, z, y, z);
        
        /// <summary>
        /// Returns hvec3.yzz swizzling.
        /// </summary>
        public hvec3 yzz => new hvec3(y, z, z);
        
        /// <summary>
        /// Returns hvec3.gbb swizzling (equivalent to hvec3.yzz).
        /// </summary>
        public hvec3 gbb => new hvec3(y, z, z);
        
        /// <summary>
        /// Returns hvec3.yzzx swizzling.
        /// </summary>
        public hvec4 yzzx => new hvec4(y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.gbbr swizzling (equivalent to hvec3.yzzx).
        /// </summary>
        public hvec4 gbbr => new hvec4(y, z, z, x);
        
        /// <summary>
        /// Returns hvec3.yzzy swizzling.
        /// </summary>
        public hvec4 yzzy => new hvec4(y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.gbbg swizzling (equivalent to hvec3.yzzy).
        /// </summary>
        public hvec4 gbbg => new hvec4(y, z, z, y);
        
        /// <summary>
        /// Returns hvec3.yzzz swizzling.
        /// </summary>
        public hvec4 yzzz => new hvec4(y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.gbbb swizzling (equivalent to hvec3.yzzz).
        /// </summary>
        public hvec4 gbbb => new hvec4(y, z, z, z);
        
        /// <summary>
        /// Returns hvec3.zx swizzling.
        /// </summary>
        public hvec2 zx => new hvec2(z, x);
        
        /// <summary>
        /// Returns hvec3.br swizzling (equivalent to hvec3.zx).
        /// </summary>
        public hvec2 br => new hvec2(z, x);
        
        /// <summary>
        /// Returns hvec3.zxx swizzling.
        /// </summary>
        public hvec3 zxx => new hvec3(z, x, x);
        
        /// <summary>
        /// Returns hvec3.brr swizzling (equivalent to hvec3.zxx).
        /// </summary>
        public hvec3 brr => new hvec3(z, x, x);
        
        /// <summary>
        /// Returns hvec3.zxxx swizzling.
        /// </summary>
        public hvec4 zxxx => new hvec4(z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.brrr swizzling (equivalent to hvec3.zxxx).
        /// </summary>
        public hvec4 brrr => new hvec4(z, x, x, x);
        
        /// <summary>
        /// Returns hvec3.zxxy swizzling.
        /// </summary>
        public hvec4 zxxy => new hvec4(z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.brrg swizzling (equivalent to hvec3.zxxy).
        /// </summary>
        public hvec4 brrg => new hvec4(z, x, x, y);
        
        /// <summary>
        /// Returns hvec3.zxxz swizzling.
        /// </summary>
        public hvec4 zxxz => new hvec4(z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.brrb swizzling (equivalent to hvec3.zxxz).
        /// </summary>
        public hvec4 brrb => new hvec4(z, x, x, z);
        
        /// <summary>
        /// Returns hvec3.zxy swizzling.
        /// </summary>
        public hvec3 zxy => new hvec3(z, x, y);
        
        /// <summary>
        /// Returns hvec3.brg swizzling (equivalent to hvec3.zxy).
        /// </summary>
        public hvec3 brg => new hvec3(z, x, y);
        
        /// <summary>
        /// Returns hvec3.zxyx swizzling.
        /// </summary>
        public hvec4 zxyx => new hvec4(z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.brgr swizzling (equivalent to hvec3.zxyx).
        /// </summary>
        public hvec4 brgr => new hvec4(z, x, y, x);
        
        /// <summary>
        /// Returns hvec3.zxyy swizzling.
        /// </summary>
        public hvec4 zxyy => new hvec4(z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.brgg swizzling (equivalent to hvec3.zxyy).
        /// </summary>
        public hvec4 brgg => new hvec4(z, x, y, y);
        
        /// <summary>
        /// Returns hvec3.zxyz swizzling.
        /// </summary>
        public hvec4 zxyz => new hvec4(z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.brgb swizzling (equivalent to hvec3.zxyz).
        /// </summary>
        public hvec4 brgb => new hvec4(z, x, y, z);
        
        /// <summary>
        /// Returns hvec3.zxz swizzling.
        /// </summary>
        public hvec3 zxz => new hvec3(z, x, z);
        
        /// <summary>
        /// Returns hvec3.brb swizzling (equivalent to hvec3.zxz).
        /// </summary>
        public hvec3 brb => new hvec3(z, x, z);
        
        /// <summary>
        /// Returns hvec3.zxzx swizzling.
        /// </summary>
        public hvec4 zxzx => new hvec4(z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.brbr swizzling (equivalent to hvec3.zxzx).
        /// </summary>
        public hvec4 brbr => new hvec4(z, x, z, x);
        
        /// <summary>
        /// Returns hvec3.zxzy swizzling.
        /// </summary>
        public hvec4 zxzy => new hvec4(z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.brbg swizzling (equivalent to hvec3.zxzy).
        /// </summary>
        public hvec4 brbg => new hvec4(z, x, z, y);
        
        /// <summary>
        /// Returns hvec3.zxzz swizzling.
        /// </summary>
        public hvec4 zxzz => new hvec4(z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.brbb swizzling (equivalent to hvec3.zxzz).
        /// </summary>
        public hvec4 brbb => new hvec4(z, x, z, z);
        
        /// <summary>
        /// Returns hvec3.zy swizzling.
        /// </summary>
        public hvec2 zy => new hvec2(z, y);
        
        /// <summary>
        /// Returns hvec3.bg swizzling (equivalent to hvec3.zy).
        /// </summary>
        public hvec2 bg => new hvec2(z, y);
        
        /// <summary>
        /// Returns hvec3.zyx swizzling.
        /// </summary>
        public hvec3 zyx => new hvec3(z, y, x);
        
        /// <summary>
        /// Returns hvec3.bgr swizzling (equivalent to hvec3.zyx).
        /// </summary>
        public hvec3 bgr => new hvec3(z, y, x);
        
        /// <summary>
        /// Returns hvec3.zyxx swizzling.
        /// </summary>
        public hvec4 zyxx => new hvec4(z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.bgrr swizzling (equivalent to hvec3.zyxx).
        /// </summary>
        public hvec4 bgrr => new hvec4(z, y, x, x);
        
        /// <summary>
        /// Returns hvec3.zyxy swizzling.
        /// </summary>
        public hvec4 zyxy => new hvec4(z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.bgrg swizzling (equivalent to hvec3.zyxy).
        /// </summary>
        public hvec4 bgrg => new hvec4(z, y, x, y);
        
        /// <summary>
        /// Returns hvec3.zyxz swizzling.
        /// </summary>
        public hvec4 zyxz => new hvec4(z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.bgrb swizzling (equivalent to hvec3.zyxz).
        /// </summary>
        public hvec4 bgrb => new hvec4(z, y, x, z);
        
        /// <summary>
        /// Returns hvec3.zyy swizzling.
        /// </summary>
        public hvec3 zyy => new hvec3(z, y, y);
        
        /// <summary>
        /// Returns hvec3.bgg swizzling (equivalent to hvec3.zyy).
        /// </summary>
        public hvec3 bgg => new hvec3(z, y, y);
        
        /// <summary>
        /// Returns hvec3.zyyx swizzling.
        /// </summary>
        public hvec4 zyyx => new hvec4(z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.bggr swizzling (equivalent to hvec3.zyyx).
        /// </summary>
        public hvec4 bggr => new hvec4(z, y, y, x);
        
        /// <summary>
        /// Returns hvec3.zyyy swizzling.
        /// </summary>
        public hvec4 zyyy => new hvec4(z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.bggg swizzling (equivalent to hvec3.zyyy).
        /// </summary>
        public hvec4 bggg => new hvec4(z, y, y, y);
        
        /// <summary>
        /// Returns hvec3.zyyz swizzling.
        /// </summary>
        public hvec4 zyyz => new hvec4(z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.bggb swizzling (equivalent to hvec3.zyyz).
        /// </summary>
        public hvec4 bggb => new hvec4(z, y, y, z);
        
        /// <summary>
        /// Returns hvec3.zyz swizzling.
        /// </summary>
        public hvec3 zyz => new hvec3(z, y, z);
        
        /// <summary>
        /// Returns hvec3.bgb swizzling (equivalent to hvec3.zyz).
        /// </summary>
        public hvec3 bgb => new hvec3(z, y, z);
        
        /// <summary>
        /// Returns hvec3.zyzx swizzling.
        /// </summary>
        public hvec4 zyzx => new hvec4(z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.bgbr swizzling (equivalent to hvec3.zyzx).
        /// </summary>
        public hvec4 bgbr => new hvec4(z, y, z, x);
        
        /// <summary>
        /// Returns hvec3.zyzy swizzling.
        /// </summary>
        public hvec4 zyzy => new hvec4(z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.bgbg swizzling (equivalent to hvec3.zyzy).
        /// </summary>
        public hvec4 bgbg => new hvec4(z, y, z, y);
        
        /// <summary>
        /// Returns hvec3.zyzz swizzling.
        /// </summary>
        public hvec4 zyzz => new hvec4(z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.bgbb swizzling (equivalent to hvec3.zyzz).
        /// </summary>
        public hvec4 bgbb => new hvec4(z, y, z, z);
        
        /// <summary>
        /// Returns hvec3.zz swizzling.
        /// </summary>
        public hvec2 zz => new hvec2(z, z);
        
        /// <summary>
        /// Returns hvec3.bb swizzling (equivalent to hvec3.zz).
        /// </summary>
        public hvec2 bb => new hvec2(z, z);
        
        /// <summary>
        /// Returns hvec3.zzx swizzling.
        /// </summary>
        public hvec3 zzx => new hvec3(z, z, x);
        
        /// <summary>
        /// Returns hvec3.bbr swizzling (equivalent to hvec3.zzx).
        /// </summary>
        public hvec3 bbr => new hvec3(z, z, x);
        
        /// <summary>
        /// Returns hvec3.zzxx swizzling.
        /// </summary>
        public hvec4 zzxx => new hvec4(z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.bbrr swizzling (equivalent to hvec3.zzxx).
        /// </summary>
        public hvec4 bbrr => new hvec4(z, z, x, x);
        
        /// <summary>
        /// Returns hvec3.zzxy swizzling.
        /// </summary>
        public hvec4 zzxy => new hvec4(z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.bbrg swizzling (equivalent to hvec3.zzxy).
        /// </summary>
        public hvec4 bbrg => new hvec4(z, z, x, y);
        
        /// <summary>
        /// Returns hvec3.zzxz swizzling.
        /// </summary>
        public hvec4 zzxz => new hvec4(z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.bbrb swizzling (equivalent to hvec3.zzxz).
        /// </summary>
        public hvec4 bbrb => new hvec4(z, z, x, z);
        
        /// <summary>
        /// Returns hvec3.zzy swizzling.
        /// </summary>
        public hvec3 zzy => new hvec3(z, z, y);
        
        /// <summary>
        /// Returns hvec3.bbg swizzling (equivalent to hvec3.zzy).
        /// </summary>
        public hvec3 bbg => new hvec3(z, z, y);
        
        /// <summary>
        /// Returns hvec3.zzyx swizzling.
        /// </summary>
        public hvec4 zzyx => new hvec4(z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.bbgr swizzling (equivalent to hvec3.zzyx).
        /// </summary>
        public hvec4 bbgr => new hvec4(z, z, y, x);
        
        /// <summary>
        /// Returns hvec3.zzyy swizzling.
        /// </summary>
        public hvec4 zzyy => new hvec4(z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.bbgg swizzling (equivalent to hvec3.zzyy).
        /// </summary>
        public hvec4 bbgg => new hvec4(z, z, y, y);
        
        /// <summary>
        /// Returns hvec3.zzyz swizzling.
        /// </summary>
        public hvec4 zzyz => new hvec4(z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.bbgb swizzling (equivalent to hvec3.zzyz).
        /// </summary>
        public hvec4 bbgb => new hvec4(z, z, y, z);
        
        /// <summary>
        /// Returns hvec3.zzz swizzling.
        /// </summary>
        public hvec3 zzz => new hvec3(z, z, z);
        
        /// <summary>
        /// Returns hvec3.bbb swizzling (equivalent to hvec3.zzz).
        /// </summary>
        public hvec3 bbb => new hvec3(z, z, z);
        
        /// <summary>
        /// Returns hvec3.zzzx swizzling.
        /// </summary>
        public hvec4 zzzx => new hvec4(z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.bbbr swizzling (equivalent to hvec3.zzzx).
        /// </summary>
        public hvec4 bbbr => new hvec4(z, z, z, x);
        
        /// <summary>
        /// Returns hvec3.zzzy swizzling.
        /// </summary>
        public hvec4 zzzy => new hvec4(z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.bbbg swizzling (equivalent to hvec3.zzzy).
        /// </summary>
        public hvec4 bbbg => new hvec4(z, z, z, y);
        
        /// <summary>
        /// Returns hvec3.zzzz swizzling.
        /// </summary>
        public hvec4 zzzz => new hvec4(z, z, z, z);
        
        /// <summary>
        /// Returns hvec3.bbbb swizzling (equivalent to hvec3.zzzz).
        /// </summary>
        public hvec4 bbbb => new hvec4(z, z, z, z);

        #endregion

    }
}
