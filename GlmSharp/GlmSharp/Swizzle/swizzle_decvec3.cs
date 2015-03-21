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
    /// Temporary vector of type decimal with 3 components, used for implementing swizzling for decvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_decvec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly decimal x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly decimal y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly decimal z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_decvec3.
        /// </summary>
        internal swizzle_decvec3(decimal x, decimal y, decimal z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns decvec3.xx swizzling.
        /// </summary>
        public decvec2 xx => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec3.rr swizzling (equivalent to decvec3.xx).
        /// </summary>
        public decvec2 rr => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec3.xxx swizzling.
        /// </summary>
        public decvec3 xxx => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec3.rrr swizzling (equivalent to decvec3.xxx).
        /// </summary>
        public decvec3 rrr => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec3.xxxx swizzling.
        /// </summary>
        public decvec4 xxxx => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.rrrr swizzling (equivalent to decvec3.xxxx).
        /// </summary>
        public decvec4 rrrr => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec3.xxxy swizzling.
        /// </summary>
        public decvec4 xxxy => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.rrrg swizzling (equivalent to decvec3.xxxy).
        /// </summary>
        public decvec4 rrrg => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec3.xxxz swizzling.
        /// </summary>
        public decvec4 xxxz => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.rrrb swizzling (equivalent to decvec3.xxxz).
        /// </summary>
        public decvec4 rrrb => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec3.xxy swizzling.
        /// </summary>
        public decvec3 xxy => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec3.rrg swizzling (equivalent to decvec3.xxy).
        /// </summary>
        public decvec3 rrg => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec3.xxyx swizzling.
        /// </summary>
        public decvec4 xxyx => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.rrgr swizzling (equivalent to decvec3.xxyx).
        /// </summary>
        public decvec4 rrgr => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec3.xxyy swizzling.
        /// </summary>
        public decvec4 xxyy => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.rrgg swizzling (equivalent to decvec3.xxyy).
        /// </summary>
        public decvec4 rrgg => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec3.xxyz swizzling.
        /// </summary>
        public decvec4 xxyz => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.rrgb swizzling (equivalent to decvec3.xxyz).
        /// </summary>
        public decvec4 rrgb => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec3.xxz swizzling.
        /// </summary>
        public decvec3 xxz => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec3.rrb swizzling (equivalent to decvec3.xxz).
        /// </summary>
        public decvec3 rrb => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec3.xxzx swizzling.
        /// </summary>
        public decvec4 xxzx => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.rrbr swizzling (equivalent to decvec3.xxzx).
        /// </summary>
        public decvec4 rrbr => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec3.xxzy swizzling.
        /// </summary>
        public decvec4 xxzy => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.rrbg swizzling (equivalent to decvec3.xxzy).
        /// </summary>
        public decvec4 rrbg => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec3.xxzz swizzling.
        /// </summary>
        public decvec4 xxzz => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.rrbb swizzling (equivalent to decvec3.xxzz).
        /// </summary>
        public decvec4 rrbb => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec3.xy swizzling.
        /// </summary>
        public decvec2 xy => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec3.rg swizzling (equivalent to decvec3.xy).
        /// </summary>
        public decvec2 rg => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec3.xyx swizzling.
        /// </summary>
        public decvec3 xyx => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec3.rgr swizzling (equivalent to decvec3.xyx).
        /// </summary>
        public decvec3 rgr => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec3.xyxx swizzling.
        /// </summary>
        public decvec4 xyxx => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.rgrr swizzling (equivalent to decvec3.xyxx).
        /// </summary>
        public decvec4 rgrr => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec3.xyxy swizzling.
        /// </summary>
        public decvec4 xyxy => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.rgrg swizzling (equivalent to decvec3.xyxy).
        /// </summary>
        public decvec4 rgrg => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec3.xyxz swizzling.
        /// </summary>
        public decvec4 xyxz => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.rgrb swizzling (equivalent to decvec3.xyxz).
        /// </summary>
        public decvec4 rgrb => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec3.xyy swizzling.
        /// </summary>
        public decvec3 xyy => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec3.rgg swizzling (equivalent to decvec3.xyy).
        /// </summary>
        public decvec3 rgg => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec3.xyyx swizzling.
        /// </summary>
        public decvec4 xyyx => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.rggr swizzling (equivalent to decvec3.xyyx).
        /// </summary>
        public decvec4 rggr => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec3.xyyy swizzling.
        /// </summary>
        public decvec4 xyyy => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.rggg swizzling (equivalent to decvec3.xyyy).
        /// </summary>
        public decvec4 rggg => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec3.xyyz swizzling.
        /// </summary>
        public decvec4 xyyz => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.rggb swizzling (equivalent to decvec3.xyyz).
        /// </summary>
        public decvec4 rggb => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec3.xyz swizzling.
        /// </summary>
        public decvec3 xyz => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec3.rgb swizzling (equivalent to decvec3.xyz).
        /// </summary>
        public decvec3 rgb => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec3.xyzx swizzling.
        /// </summary>
        public decvec4 xyzx => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.rgbr swizzling (equivalent to decvec3.xyzx).
        /// </summary>
        public decvec4 rgbr => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec3.xyzy swizzling.
        /// </summary>
        public decvec4 xyzy => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.rgbg swizzling (equivalent to decvec3.xyzy).
        /// </summary>
        public decvec4 rgbg => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec3.xyzz swizzling.
        /// </summary>
        public decvec4 xyzz => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.rgbb swizzling (equivalent to decvec3.xyzz).
        /// </summary>
        public decvec4 rgbb => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec3.xz swizzling.
        /// </summary>
        public decvec2 xz => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec3.rb swizzling (equivalent to decvec3.xz).
        /// </summary>
        public decvec2 rb => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec3.xzx swizzling.
        /// </summary>
        public decvec3 xzx => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec3.rbr swizzling (equivalent to decvec3.xzx).
        /// </summary>
        public decvec3 rbr => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec3.xzxx swizzling.
        /// </summary>
        public decvec4 xzxx => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.rbrr swizzling (equivalent to decvec3.xzxx).
        /// </summary>
        public decvec4 rbrr => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec3.xzxy swizzling.
        /// </summary>
        public decvec4 xzxy => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.rbrg swizzling (equivalent to decvec3.xzxy).
        /// </summary>
        public decvec4 rbrg => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec3.xzxz swizzling.
        /// </summary>
        public decvec4 xzxz => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.rbrb swizzling (equivalent to decvec3.xzxz).
        /// </summary>
        public decvec4 rbrb => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec3.xzy swizzling.
        /// </summary>
        public decvec3 xzy => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec3.rbg swizzling (equivalent to decvec3.xzy).
        /// </summary>
        public decvec3 rbg => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec3.xzyx swizzling.
        /// </summary>
        public decvec4 xzyx => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.rbgr swizzling (equivalent to decvec3.xzyx).
        /// </summary>
        public decvec4 rbgr => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec3.xzyy swizzling.
        /// </summary>
        public decvec4 xzyy => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.rbgg swizzling (equivalent to decvec3.xzyy).
        /// </summary>
        public decvec4 rbgg => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec3.xzyz swizzling.
        /// </summary>
        public decvec4 xzyz => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.rbgb swizzling (equivalent to decvec3.xzyz).
        /// </summary>
        public decvec4 rbgb => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec3.xzz swizzling.
        /// </summary>
        public decvec3 xzz => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec3.rbb swizzling (equivalent to decvec3.xzz).
        /// </summary>
        public decvec3 rbb => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec3.xzzx swizzling.
        /// </summary>
        public decvec4 xzzx => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.rbbr swizzling (equivalent to decvec3.xzzx).
        /// </summary>
        public decvec4 rbbr => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec3.xzzy swizzling.
        /// </summary>
        public decvec4 xzzy => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.rbbg swizzling (equivalent to decvec3.xzzy).
        /// </summary>
        public decvec4 rbbg => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec3.xzzz swizzling.
        /// </summary>
        public decvec4 xzzz => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.rbbb swizzling (equivalent to decvec3.xzzz).
        /// </summary>
        public decvec4 rbbb => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec3.yx swizzling.
        /// </summary>
        public decvec2 yx => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec3.gr swizzling (equivalent to decvec3.yx).
        /// </summary>
        public decvec2 gr => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec3.yxx swizzling.
        /// </summary>
        public decvec3 yxx => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec3.grr swizzling (equivalent to decvec3.yxx).
        /// </summary>
        public decvec3 grr => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec3.yxxx swizzling.
        /// </summary>
        public decvec4 yxxx => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.grrr swizzling (equivalent to decvec3.yxxx).
        /// </summary>
        public decvec4 grrr => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec3.yxxy swizzling.
        /// </summary>
        public decvec4 yxxy => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.grrg swizzling (equivalent to decvec3.yxxy).
        /// </summary>
        public decvec4 grrg => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec3.yxxz swizzling.
        /// </summary>
        public decvec4 yxxz => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.grrb swizzling (equivalent to decvec3.yxxz).
        /// </summary>
        public decvec4 grrb => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec3.yxy swizzling.
        /// </summary>
        public decvec3 yxy => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec3.grg swizzling (equivalent to decvec3.yxy).
        /// </summary>
        public decvec3 grg => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec3.yxyx swizzling.
        /// </summary>
        public decvec4 yxyx => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.grgr swizzling (equivalent to decvec3.yxyx).
        /// </summary>
        public decvec4 grgr => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec3.yxyy swizzling.
        /// </summary>
        public decvec4 yxyy => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.grgg swizzling (equivalent to decvec3.yxyy).
        /// </summary>
        public decvec4 grgg => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec3.yxyz swizzling.
        /// </summary>
        public decvec4 yxyz => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.grgb swizzling (equivalent to decvec3.yxyz).
        /// </summary>
        public decvec4 grgb => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec3.yxz swizzling.
        /// </summary>
        public decvec3 yxz => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec3.grb swizzling (equivalent to decvec3.yxz).
        /// </summary>
        public decvec3 grb => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec3.yxzx swizzling.
        /// </summary>
        public decvec4 yxzx => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.grbr swizzling (equivalent to decvec3.yxzx).
        /// </summary>
        public decvec4 grbr => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec3.yxzy swizzling.
        /// </summary>
        public decvec4 yxzy => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.grbg swizzling (equivalent to decvec3.yxzy).
        /// </summary>
        public decvec4 grbg => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec3.yxzz swizzling.
        /// </summary>
        public decvec4 yxzz => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.grbb swizzling (equivalent to decvec3.yxzz).
        /// </summary>
        public decvec4 grbb => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec3.yy swizzling.
        /// </summary>
        public decvec2 yy => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec3.gg swizzling (equivalent to decvec3.yy).
        /// </summary>
        public decvec2 gg => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec3.yyx swizzling.
        /// </summary>
        public decvec3 yyx => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec3.ggr swizzling (equivalent to decvec3.yyx).
        /// </summary>
        public decvec3 ggr => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec3.yyxx swizzling.
        /// </summary>
        public decvec4 yyxx => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.ggrr swizzling (equivalent to decvec3.yyxx).
        /// </summary>
        public decvec4 ggrr => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec3.yyxy swizzling.
        /// </summary>
        public decvec4 yyxy => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.ggrg swizzling (equivalent to decvec3.yyxy).
        /// </summary>
        public decvec4 ggrg => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec3.yyxz swizzling.
        /// </summary>
        public decvec4 yyxz => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.ggrb swizzling (equivalent to decvec3.yyxz).
        /// </summary>
        public decvec4 ggrb => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec3.yyy swizzling.
        /// </summary>
        public decvec3 yyy => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec3.ggg swizzling (equivalent to decvec3.yyy).
        /// </summary>
        public decvec3 ggg => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec3.yyyx swizzling.
        /// </summary>
        public decvec4 yyyx => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.gggr swizzling (equivalent to decvec3.yyyx).
        /// </summary>
        public decvec4 gggr => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec3.yyyy swizzling.
        /// </summary>
        public decvec4 yyyy => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.gggg swizzling (equivalent to decvec3.yyyy).
        /// </summary>
        public decvec4 gggg => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec3.yyyz swizzling.
        /// </summary>
        public decvec4 yyyz => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.gggb swizzling (equivalent to decvec3.yyyz).
        /// </summary>
        public decvec4 gggb => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec3.yyz swizzling.
        /// </summary>
        public decvec3 yyz => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec3.ggb swizzling (equivalent to decvec3.yyz).
        /// </summary>
        public decvec3 ggb => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec3.yyzx swizzling.
        /// </summary>
        public decvec4 yyzx => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.ggbr swizzling (equivalent to decvec3.yyzx).
        /// </summary>
        public decvec4 ggbr => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec3.yyzy swizzling.
        /// </summary>
        public decvec4 yyzy => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.ggbg swizzling (equivalent to decvec3.yyzy).
        /// </summary>
        public decvec4 ggbg => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec3.yyzz swizzling.
        /// </summary>
        public decvec4 yyzz => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.ggbb swizzling (equivalent to decvec3.yyzz).
        /// </summary>
        public decvec4 ggbb => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec3.yz swizzling.
        /// </summary>
        public decvec2 yz => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec3.gb swizzling (equivalent to decvec3.yz).
        /// </summary>
        public decvec2 gb => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec3.yzx swizzling.
        /// </summary>
        public decvec3 yzx => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec3.gbr swizzling (equivalent to decvec3.yzx).
        /// </summary>
        public decvec3 gbr => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec3.yzxx swizzling.
        /// </summary>
        public decvec4 yzxx => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.gbrr swizzling (equivalent to decvec3.yzxx).
        /// </summary>
        public decvec4 gbrr => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec3.yzxy swizzling.
        /// </summary>
        public decvec4 yzxy => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.gbrg swizzling (equivalent to decvec3.yzxy).
        /// </summary>
        public decvec4 gbrg => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec3.yzxz swizzling.
        /// </summary>
        public decvec4 yzxz => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.gbrb swizzling (equivalent to decvec3.yzxz).
        /// </summary>
        public decvec4 gbrb => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec3.yzy swizzling.
        /// </summary>
        public decvec3 yzy => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec3.gbg swizzling (equivalent to decvec3.yzy).
        /// </summary>
        public decvec3 gbg => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec3.yzyx swizzling.
        /// </summary>
        public decvec4 yzyx => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.gbgr swizzling (equivalent to decvec3.yzyx).
        /// </summary>
        public decvec4 gbgr => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec3.yzyy swizzling.
        /// </summary>
        public decvec4 yzyy => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.gbgg swizzling (equivalent to decvec3.yzyy).
        /// </summary>
        public decvec4 gbgg => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec3.yzyz swizzling.
        /// </summary>
        public decvec4 yzyz => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.gbgb swizzling (equivalent to decvec3.yzyz).
        /// </summary>
        public decvec4 gbgb => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec3.yzz swizzling.
        /// </summary>
        public decvec3 yzz => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec3.gbb swizzling (equivalent to decvec3.yzz).
        /// </summary>
        public decvec3 gbb => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec3.yzzx swizzling.
        /// </summary>
        public decvec4 yzzx => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.gbbr swizzling (equivalent to decvec3.yzzx).
        /// </summary>
        public decvec4 gbbr => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec3.yzzy swizzling.
        /// </summary>
        public decvec4 yzzy => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.gbbg swizzling (equivalent to decvec3.yzzy).
        /// </summary>
        public decvec4 gbbg => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec3.yzzz swizzling.
        /// </summary>
        public decvec4 yzzz => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.gbbb swizzling (equivalent to decvec3.yzzz).
        /// </summary>
        public decvec4 gbbb => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec3.zx swizzling.
        /// </summary>
        public decvec2 zx => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec3.br swizzling (equivalent to decvec3.zx).
        /// </summary>
        public decvec2 br => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec3.zxx swizzling.
        /// </summary>
        public decvec3 zxx => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec3.brr swizzling (equivalent to decvec3.zxx).
        /// </summary>
        public decvec3 brr => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec3.zxxx swizzling.
        /// </summary>
        public decvec4 zxxx => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.brrr swizzling (equivalent to decvec3.zxxx).
        /// </summary>
        public decvec4 brrr => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec3.zxxy swizzling.
        /// </summary>
        public decvec4 zxxy => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.brrg swizzling (equivalent to decvec3.zxxy).
        /// </summary>
        public decvec4 brrg => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec3.zxxz swizzling.
        /// </summary>
        public decvec4 zxxz => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.brrb swizzling (equivalent to decvec3.zxxz).
        /// </summary>
        public decvec4 brrb => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec3.zxy swizzling.
        /// </summary>
        public decvec3 zxy => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec3.brg swizzling (equivalent to decvec3.zxy).
        /// </summary>
        public decvec3 brg => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec3.zxyx swizzling.
        /// </summary>
        public decvec4 zxyx => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.brgr swizzling (equivalent to decvec3.zxyx).
        /// </summary>
        public decvec4 brgr => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec3.zxyy swizzling.
        /// </summary>
        public decvec4 zxyy => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.brgg swizzling (equivalent to decvec3.zxyy).
        /// </summary>
        public decvec4 brgg => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec3.zxyz swizzling.
        /// </summary>
        public decvec4 zxyz => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.brgb swizzling (equivalent to decvec3.zxyz).
        /// </summary>
        public decvec4 brgb => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec3.zxz swizzling.
        /// </summary>
        public decvec3 zxz => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec3.brb swizzling (equivalent to decvec3.zxz).
        /// </summary>
        public decvec3 brb => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec3.zxzx swizzling.
        /// </summary>
        public decvec4 zxzx => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.brbr swizzling (equivalent to decvec3.zxzx).
        /// </summary>
        public decvec4 brbr => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec3.zxzy swizzling.
        /// </summary>
        public decvec4 zxzy => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.brbg swizzling (equivalent to decvec3.zxzy).
        /// </summary>
        public decvec4 brbg => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec3.zxzz swizzling.
        /// </summary>
        public decvec4 zxzz => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.brbb swizzling (equivalent to decvec3.zxzz).
        /// </summary>
        public decvec4 brbb => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec3.zy swizzling.
        /// </summary>
        public decvec2 zy => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec3.bg swizzling (equivalent to decvec3.zy).
        /// </summary>
        public decvec2 bg => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec3.zyx swizzling.
        /// </summary>
        public decvec3 zyx => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec3.bgr swizzling (equivalent to decvec3.zyx).
        /// </summary>
        public decvec3 bgr => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec3.zyxx swizzling.
        /// </summary>
        public decvec4 zyxx => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.bgrr swizzling (equivalent to decvec3.zyxx).
        /// </summary>
        public decvec4 bgrr => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec3.zyxy swizzling.
        /// </summary>
        public decvec4 zyxy => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.bgrg swizzling (equivalent to decvec3.zyxy).
        /// </summary>
        public decvec4 bgrg => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec3.zyxz swizzling.
        /// </summary>
        public decvec4 zyxz => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.bgrb swizzling (equivalent to decvec3.zyxz).
        /// </summary>
        public decvec4 bgrb => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec3.zyy swizzling.
        /// </summary>
        public decvec3 zyy => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec3.bgg swizzling (equivalent to decvec3.zyy).
        /// </summary>
        public decvec3 bgg => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec3.zyyx swizzling.
        /// </summary>
        public decvec4 zyyx => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.bggr swizzling (equivalent to decvec3.zyyx).
        /// </summary>
        public decvec4 bggr => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec3.zyyy swizzling.
        /// </summary>
        public decvec4 zyyy => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.bggg swizzling (equivalent to decvec3.zyyy).
        /// </summary>
        public decvec4 bggg => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec3.zyyz swizzling.
        /// </summary>
        public decvec4 zyyz => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.bggb swizzling (equivalent to decvec3.zyyz).
        /// </summary>
        public decvec4 bggb => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec3.zyz swizzling.
        /// </summary>
        public decvec3 zyz => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec3.bgb swizzling (equivalent to decvec3.zyz).
        /// </summary>
        public decvec3 bgb => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec3.zyzx swizzling.
        /// </summary>
        public decvec4 zyzx => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.bgbr swizzling (equivalent to decvec3.zyzx).
        /// </summary>
        public decvec4 bgbr => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec3.zyzy swizzling.
        /// </summary>
        public decvec4 zyzy => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.bgbg swizzling (equivalent to decvec3.zyzy).
        /// </summary>
        public decvec4 bgbg => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec3.zyzz swizzling.
        /// </summary>
        public decvec4 zyzz => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.bgbb swizzling (equivalent to decvec3.zyzz).
        /// </summary>
        public decvec4 bgbb => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec3.zz swizzling.
        /// </summary>
        public decvec2 zz => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec3.bb swizzling (equivalent to decvec3.zz).
        /// </summary>
        public decvec2 bb => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec3.zzx swizzling.
        /// </summary>
        public decvec3 zzx => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec3.bbr swizzling (equivalent to decvec3.zzx).
        /// </summary>
        public decvec3 bbr => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec3.zzxx swizzling.
        /// </summary>
        public decvec4 zzxx => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.bbrr swizzling (equivalent to decvec3.zzxx).
        /// </summary>
        public decvec4 bbrr => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec3.zzxy swizzling.
        /// </summary>
        public decvec4 zzxy => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.bbrg swizzling (equivalent to decvec3.zzxy).
        /// </summary>
        public decvec4 bbrg => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec3.zzxz swizzling.
        /// </summary>
        public decvec4 zzxz => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.bbrb swizzling (equivalent to decvec3.zzxz).
        /// </summary>
        public decvec4 bbrb => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec3.zzy swizzling.
        /// </summary>
        public decvec3 zzy => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec3.bbg swizzling (equivalent to decvec3.zzy).
        /// </summary>
        public decvec3 bbg => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec3.zzyx swizzling.
        /// </summary>
        public decvec4 zzyx => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.bbgr swizzling (equivalent to decvec3.zzyx).
        /// </summary>
        public decvec4 bbgr => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec3.zzyy swizzling.
        /// </summary>
        public decvec4 zzyy => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.bbgg swizzling (equivalent to decvec3.zzyy).
        /// </summary>
        public decvec4 bbgg => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec3.zzyz swizzling.
        /// </summary>
        public decvec4 zzyz => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.bbgb swizzling (equivalent to decvec3.zzyz).
        /// </summary>
        public decvec4 bbgb => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec3.zzz swizzling.
        /// </summary>
        public decvec3 zzz => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec3.bbb swizzling (equivalent to decvec3.zzz).
        /// </summary>
        public decvec3 bbb => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec3.zzzx swizzling.
        /// </summary>
        public decvec4 zzzx => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.bbbr swizzling (equivalent to decvec3.zzzx).
        /// </summary>
        public decvec4 bbbr => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec3.zzzy swizzling.
        /// </summary>
        public decvec4 zzzy => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.bbbg swizzling (equivalent to decvec3.zzzy).
        /// </summary>
        public decvec4 bbbg => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec3.zzzz swizzling.
        /// </summary>
        public decvec4 zzzz => new decvec4(z, z, z, z);
        
        /// <summary>
        /// Returns decvec3.bbbb swizzling (equivalent to decvec3.zzzz).
        /// </summary>
        public decvec4 bbbb => new decvec4(z, z, z, z);

        #endregion

    }
}
