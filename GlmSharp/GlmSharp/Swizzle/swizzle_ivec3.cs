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
    /// Temporary vector of type int with 3 components, used for implementing swizzling for ivec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_ivec3
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly int x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly int y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly int z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_ivec3.
        /// </summary>
        internal swizzle_ivec3(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns ivec3.xx swizzling.
        /// </summary>
        public ivec2 xx => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec3.rr swizzling (equivalent to ivec3.xx).
        /// </summary>
        public ivec2 rr => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec3.xxx swizzling.
        /// </summary>
        public ivec3 xxx => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec3.rrr swizzling (equivalent to ivec3.xxx).
        /// </summary>
        public ivec3 rrr => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec3.xxxx swizzling.
        /// </summary>
        public ivec4 xxxx => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.rrrr swizzling (equivalent to ivec3.xxxx).
        /// </summary>
        public ivec4 rrrr => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec3.xxxy swizzling.
        /// </summary>
        public ivec4 xxxy => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.rrrg swizzling (equivalent to ivec3.xxxy).
        /// </summary>
        public ivec4 rrrg => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec3.xxxz swizzling.
        /// </summary>
        public ivec4 xxxz => new ivec4(x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.rrrb swizzling (equivalent to ivec3.xxxz).
        /// </summary>
        public ivec4 rrrb => new ivec4(x, x, x, z);
        
        /// <summary>
        /// Returns ivec3.xxy swizzling.
        /// </summary>
        public ivec3 xxy => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec3.rrg swizzling (equivalent to ivec3.xxy).
        /// </summary>
        public ivec3 rrg => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec3.xxyx swizzling.
        /// </summary>
        public ivec4 xxyx => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.rrgr swizzling (equivalent to ivec3.xxyx).
        /// </summary>
        public ivec4 rrgr => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec3.xxyy swizzling.
        /// </summary>
        public ivec4 xxyy => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.rrgg swizzling (equivalent to ivec3.xxyy).
        /// </summary>
        public ivec4 rrgg => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec3.xxyz swizzling.
        /// </summary>
        public ivec4 xxyz => new ivec4(x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.rrgb swizzling (equivalent to ivec3.xxyz).
        /// </summary>
        public ivec4 rrgb => new ivec4(x, x, y, z);
        
        /// <summary>
        /// Returns ivec3.xxz swizzling.
        /// </summary>
        public ivec3 xxz => new ivec3(x, x, z);
        
        /// <summary>
        /// Returns ivec3.rrb swizzling (equivalent to ivec3.xxz).
        /// </summary>
        public ivec3 rrb => new ivec3(x, x, z);
        
        /// <summary>
        /// Returns ivec3.xxzx swizzling.
        /// </summary>
        public ivec4 xxzx => new ivec4(x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.rrbr swizzling (equivalent to ivec3.xxzx).
        /// </summary>
        public ivec4 rrbr => new ivec4(x, x, z, x);
        
        /// <summary>
        /// Returns ivec3.xxzy swizzling.
        /// </summary>
        public ivec4 xxzy => new ivec4(x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.rrbg swizzling (equivalent to ivec3.xxzy).
        /// </summary>
        public ivec4 rrbg => new ivec4(x, x, z, y);
        
        /// <summary>
        /// Returns ivec3.xxzz swizzling.
        /// </summary>
        public ivec4 xxzz => new ivec4(x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.rrbb swizzling (equivalent to ivec3.xxzz).
        /// </summary>
        public ivec4 rrbb => new ivec4(x, x, z, z);
        
        /// <summary>
        /// Returns ivec3.xy swizzling.
        /// </summary>
        public ivec2 xy => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec3.rg swizzling (equivalent to ivec3.xy).
        /// </summary>
        public ivec2 rg => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec3.xyx swizzling.
        /// </summary>
        public ivec3 xyx => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec3.rgr swizzling (equivalent to ivec3.xyx).
        /// </summary>
        public ivec3 rgr => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec3.xyxx swizzling.
        /// </summary>
        public ivec4 xyxx => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.rgrr swizzling (equivalent to ivec3.xyxx).
        /// </summary>
        public ivec4 rgrr => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec3.xyxy swizzling.
        /// </summary>
        public ivec4 xyxy => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.rgrg swizzling (equivalent to ivec3.xyxy).
        /// </summary>
        public ivec4 rgrg => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec3.xyxz swizzling.
        /// </summary>
        public ivec4 xyxz => new ivec4(x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.rgrb swizzling (equivalent to ivec3.xyxz).
        /// </summary>
        public ivec4 rgrb => new ivec4(x, y, x, z);
        
        /// <summary>
        /// Returns ivec3.xyy swizzling.
        /// </summary>
        public ivec3 xyy => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec3.rgg swizzling (equivalent to ivec3.xyy).
        /// </summary>
        public ivec3 rgg => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec3.xyyx swizzling.
        /// </summary>
        public ivec4 xyyx => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.rggr swizzling (equivalent to ivec3.xyyx).
        /// </summary>
        public ivec4 rggr => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec3.xyyy swizzling.
        /// </summary>
        public ivec4 xyyy => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.rggg swizzling (equivalent to ivec3.xyyy).
        /// </summary>
        public ivec4 rggg => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec3.xyyz swizzling.
        /// </summary>
        public ivec4 xyyz => new ivec4(x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.rggb swizzling (equivalent to ivec3.xyyz).
        /// </summary>
        public ivec4 rggb => new ivec4(x, y, y, z);
        
        /// <summary>
        /// Returns ivec3.xyz swizzling.
        /// </summary>
        public ivec3 xyz => new ivec3(x, y, z);
        
        /// <summary>
        /// Returns ivec3.rgb swizzling (equivalent to ivec3.xyz).
        /// </summary>
        public ivec3 rgb => new ivec3(x, y, z);
        
        /// <summary>
        /// Returns ivec3.xyzx swizzling.
        /// </summary>
        public ivec4 xyzx => new ivec4(x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.rgbr swizzling (equivalent to ivec3.xyzx).
        /// </summary>
        public ivec4 rgbr => new ivec4(x, y, z, x);
        
        /// <summary>
        /// Returns ivec3.xyzy swizzling.
        /// </summary>
        public ivec4 xyzy => new ivec4(x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.rgbg swizzling (equivalent to ivec3.xyzy).
        /// </summary>
        public ivec4 rgbg => new ivec4(x, y, z, y);
        
        /// <summary>
        /// Returns ivec3.xyzz swizzling.
        /// </summary>
        public ivec4 xyzz => new ivec4(x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.rgbb swizzling (equivalent to ivec3.xyzz).
        /// </summary>
        public ivec4 rgbb => new ivec4(x, y, z, z);
        
        /// <summary>
        /// Returns ivec3.xz swizzling.
        /// </summary>
        public ivec2 xz => new ivec2(x, z);
        
        /// <summary>
        /// Returns ivec3.rb swizzling (equivalent to ivec3.xz).
        /// </summary>
        public ivec2 rb => new ivec2(x, z);
        
        /// <summary>
        /// Returns ivec3.xzx swizzling.
        /// </summary>
        public ivec3 xzx => new ivec3(x, z, x);
        
        /// <summary>
        /// Returns ivec3.rbr swizzling (equivalent to ivec3.xzx).
        /// </summary>
        public ivec3 rbr => new ivec3(x, z, x);
        
        /// <summary>
        /// Returns ivec3.xzxx swizzling.
        /// </summary>
        public ivec4 xzxx => new ivec4(x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.rbrr swizzling (equivalent to ivec3.xzxx).
        /// </summary>
        public ivec4 rbrr => new ivec4(x, z, x, x);
        
        /// <summary>
        /// Returns ivec3.xzxy swizzling.
        /// </summary>
        public ivec4 xzxy => new ivec4(x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.rbrg swizzling (equivalent to ivec3.xzxy).
        /// </summary>
        public ivec4 rbrg => new ivec4(x, z, x, y);
        
        /// <summary>
        /// Returns ivec3.xzxz swizzling.
        /// </summary>
        public ivec4 xzxz => new ivec4(x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.rbrb swizzling (equivalent to ivec3.xzxz).
        /// </summary>
        public ivec4 rbrb => new ivec4(x, z, x, z);
        
        /// <summary>
        /// Returns ivec3.xzy swizzling.
        /// </summary>
        public ivec3 xzy => new ivec3(x, z, y);
        
        /// <summary>
        /// Returns ivec3.rbg swizzling (equivalent to ivec3.xzy).
        /// </summary>
        public ivec3 rbg => new ivec3(x, z, y);
        
        /// <summary>
        /// Returns ivec3.xzyx swizzling.
        /// </summary>
        public ivec4 xzyx => new ivec4(x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.rbgr swizzling (equivalent to ivec3.xzyx).
        /// </summary>
        public ivec4 rbgr => new ivec4(x, z, y, x);
        
        /// <summary>
        /// Returns ivec3.xzyy swizzling.
        /// </summary>
        public ivec4 xzyy => new ivec4(x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.rbgg swizzling (equivalent to ivec3.xzyy).
        /// </summary>
        public ivec4 rbgg => new ivec4(x, z, y, y);
        
        /// <summary>
        /// Returns ivec3.xzyz swizzling.
        /// </summary>
        public ivec4 xzyz => new ivec4(x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.rbgb swizzling (equivalent to ivec3.xzyz).
        /// </summary>
        public ivec4 rbgb => new ivec4(x, z, y, z);
        
        /// <summary>
        /// Returns ivec3.xzz swizzling.
        /// </summary>
        public ivec3 xzz => new ivec3(x, z, z);
        
        /// <summary>
        /// Returns ivec3.rbb swizzling (equivalent to ivec3.xzz).
        /// </summary>
        public ivec3 rbb => new ivec3(x, z, z);
        
        /// <summary>
        /// Returns ivec3.xzzx swizzling.
        /// </summary>
        public ivec4 xzzx => new ivec4(x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.rbbr swizzling (equivalent to ivec3.xzzx).
        /// </summary>
        public ivec4 rbbr => new ivec4(x, z, z, x);
        
        /// <summary>
        /// Returns ivec3.xzzy swizzling.
        /// </summary>
        public ivec4 xzzy => new ivec4(x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.rbbg swizzling (equivalent to ivec3.xzzy).
        /// </summary>
        public ivec4 rbbg => new ivec4(x, z, z, y);
        
        /// <summary>
        /// Returns ivec3.xzzz swizzling.
        /// </summary>
        public ivec4 xzzz => new ivec4(x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.rbbb swizzling (equivalent to ivec3.xzzz).
        /// </summary>
        public ivec4 rbbb => new ivec4(x, z, z, z);
        
        /// <summary>
        /// Returns ivec3.yx swizzling.
        /// </summary>
        public ivec2 yx => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec3.gr swizzling (equivalent to ivec3.yx).
        /// </summary>
        public ivec2 gr => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec3.yxx swizzling.
        /// </summary>
        public ivec3 yxx => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec3.grr swizzling (equivalent to ivec3.yxx).
        /// </summary>
        public ivec3 grr => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec3.yxxx swizzling.
        /// </summary>
        public ivec4 yxxx => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.grrr swizzling (equivalent to ivec3.yxxx).
        /// </summary>
        public ivec4 grrr => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec3.yxxy swizzling.
        /// </summary>
        public ivec4 yxxy => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.grrg swizzling (equivalent to ivec3.yxxy).
        /// </summary>
        public ivec4 grrg => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec3.yxxz swizzling.
        /// </summary>
        public ivec4 yxxz => new ivec4(y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.grrb swizzling (equivalent to ivec3.yxxz).
        /// </summary>
        public ivec4 grrb => new ivec4(y, x, x, z);
        
        /// <summary>
        /// Returns ivec3.yxy swizzling.
        /// </summary>
        public ivec3 yxy => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec3.grg swizzling (equivalent to ivec3.yxy).
        /// </summary>
        public ivec3 grg => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec3.yxyx swizzling.
        /// </summary>
        public ivec4 yxyx => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.grgr swizzling (equivalent to ivec3.yxyx).
        /// </summary>
        public ivec4 grgr => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec3.yxyy swizzling.
        /// </summary>
        public ivec4 yxyy => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.grgg swizzling (equivalent to ivec3.yxyy).
        /// </summary>
        public ivec4 grgg => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec3.yxyz swizzling.
        /// </summary>
        public ivec4 yxyz => new ivec4(y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.grgb swizzling (equivalent to ivec3.yxyz).
        /// </summary>
        public ivec4 grgb => new ivec4(y, x, y, z);
        
        /// <summary>
        /// Returns ivec3.yxz swizzling.
        /// </summary>
        public ivec3 yxz => new ivec3(y, x, z);
        
        /// <summary>
        /// Returns ivec3.grb swizzling (equivalent to ivec3.yxz).
        /// </summary>
        public ivec3 grb => new ivec3(y, x, z);
        
        /// <summary>
        /// Returns ivec3.yxzx swizzling.
        /// </summary>
        public ivec4 yxzx => new ivec4(y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.grbr swizzling (equivalent to ivec3.yxzx).
        /// </summary>
        public ivec4 grbr => new ivec4(y, x, z, x);
        
        /// <summary>
        /// Returns ivec3.yxzy swizzling.
        /// </summary>
        public ivec4 yxzy => new ivec4(y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.grbg swizzling (equivalent to ivec3.yxzy).
        /// </summary>
        public ivec4 grbg => new ivec4(y, x, z, y);
        
        /// <summary>
        /// Returns ivec3.yxzz swizzling.
        /// </summary>
        public ivec4 yxzz => new ivec4(y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.grbb swizzling (equivalent to ivec3.yxzz).
        /// </summary>
        public ivec4 grbb => new ivec4(y, x, z, z);
        
        /// <summary>
        /// Returns ivec3.yy swizzling.
        /// </summary>
        public ivec2 yy => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec3.gg swizzling (equivalent to ivec3.yy).
        /// </summary>
        public ivec2 gg => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec3.yyx swizzling.
        /// </summary>
        public ivec3 yyx => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec3.ggr swizzling (equivalent to ivec3.yyx).
        /// </summary>
        public ivec3 ggr => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec3.yyxx swizzling.
        /// </summary>
        public ivec4 yyxx => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.ggrr swizzling (equivalent to ivec3.yyxx).
        /// </summary>
        public ivec4 ggrr => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec3.yyxy swizzling.
        /// </summary>
        public ivec4 yyxy => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.ggrg swizzling (equivalent to ivec3.yyxy).
        /// </summary>
        public ivec4 ggrg => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec3.yyxz swizzling.
        /// </summary>
        public ivec4 yyxz => new ivec4(y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.ggrb swizzling (equivalent to ivec3.yyxz).
        /// </summary>
        public ivec4 ggrb => new ivec4(y, y, x, z);
        
        /// <summary>
        /// Returns ivec3.yyy swizzling.
        /// </summary>
        public ivec3 yyy => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec3.ggg swizzling (equivalent to ivec3.yyy).
        /// </summary>
        public ivec3 ggg => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec3.yyyx swizzling.
        /// </summary>
        public ivec4 yyyx => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.gggr swizzling (equivalent to ivec3.yyyx).
        /// </summary>
        public ivec4 gggr => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec3.yyyy swizzling.
        /// </summary>
        public ivec4 yyyy => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.gggg swizzling (equivalent to ivec3.yyyy).
        /// </summary>
        public ivec4 gggg => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec3.yyyz swizzling.
        /// </summary>
        public ivec4 yyyz => new ivec4(y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.gggb swizzling (equivalent to ivec3.yyyz).
        /// </summary>
        public ivec4 gggb => new ivec4(y, y, y, z);
        
        /// <summary>
        /// Returns ivec3.yyz swizzling.
        /// </summary>
        public ivec3 yyz => new ivec3(y, y, z);
        
        /// <summary>
        /// Returns ivec3.ggb swizzling (equivalent to ivec3.yyz).
        /// </summary>
        public ivec3 ggb => new ivec3(y, y, z);
        
        /// <summary>
        /// Returns ivec3.yyzx swizzling.
        /// </summary>
        public ivec4 yyzx => new ivec4(y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.ggbr swizzling (equivalent to ivec3.yyzx).
        /// </summary>
        public ivec4 ggbr => new ivec4(y, y, z, x);
        
        /// <summary>
        /// Returns ivec3.yyzy swizzling.
        /// </summary>
        public ivec4 yyzy => new ivec4(y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.ggbg swizzling (equivalent to ivec3.yyzy).
        /// </summary>
        public ivec4 ggbg => new ivec4(y, y, z, y);
        
        /// <summary>
        /// Returns ivec3.yyzz swizzling.
        /// </summary>
        public ivec4 yyzz => new ivec4(y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.ggbb swizzling (equivalent to ivec3.yyzz).
        /// </summary>
        public ivec4 ggbb => new ivec4(y, y, z, z);
        
        /// <summary>
        /// Returns ivec3.yz swizzling.
        /// </summary>
        public ivec2 yz => new ivec2(y, z);
        
        /// <summary>
        /// Returns ivec3.gb swizzling (equivalent to ivec3.yz).
        /// </summary>
        public ivec2 gb => new ivec2(y, z);
        
        /// <summary>
        /// Returns ivec3.yzx swizzling.
        /// </summary>
        public ivec3 yzx => new ivec3(y, z, x);
        
        /// <summary>
        /// Returns ivec3.gbr swizzling (equivalent to ivec3.yzx).
        /// </summary>
        public ivec3 gbr => new ivec3(y, z, x);
        
        /// <summary>
        /// Returns ivec3.yzxx swizzling.
        /// </summary>
        public ivec4 yzxx => new ivec4(y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.gbrr swizzling (equivalent to ivec3.yzxx).
        /// </summary>
        public ivec4 gbrr => new ivec4(y, z, x, x);
        
        /// <summary>
        /// Returns ivec3.yzxy swizzling.
        /// </summary>
        public ivec4 yzxy => new ivec4(y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.gbrg swizzling (equivalent to ivec3.yzxy).
        /// </summary>
        public ivec4 gbrg => new ivec4(y, z, x, y);
        
        /// <summary>
        /// Returns ivec3.yzxz swizzling.
        /// </summary>
        public ivec4 yzxz => new ivec4(y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.gbrb swizzling (equivalent to ivec3.yzxz).
        /// </summary>
        public ivec4 gbrb => new ivec4(y, z, x, z);
        
        /// <summary>
        /// Returns ivec3.yzy swizzling.
        /// </summary>
        public ivec3 yzy => new ivec3(y, z, y);
        
        /// <summary>
        /// Returns ivec3.gbg swizzling (equivalent to ivec3.yzy).
        /// </summary>
        public ivec3 gbg => new ivec3(y, z, y);
        
        /// <summary>
        /// Returns ivec3.yzyx swizzling.
        /// </summary>
        public ivec4 yzyx => new ivec4(y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.gbgr swizzling (equivalent to ivec3.yzyx).
        /// </summary>
        public ivec4 gbgr => new ivec4(y, z, y, x);
        
        /// <summary>
        /// Returns ivec3.yzyy swizzling.
        /// </summary>
        public ivec4 yzyy => new ivec4(y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.gbgg swizzling (equivalent to ivec3.yzyy).
        /// </summary>
        public ivec4 gbgg => new ivec4(y, z, y, y);
        
        /// <summary>
        /// Returns ivec3.yzyz swizzling.
        /// </summary>
        public ivec4 yzyz => new ivec4(y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.gbgb swizzling (equivalent to ivec3.yzyz).
        /// </summary>
        public ivec4 gbgb => new ivec4(y, z, y, z);
        
        /// <summary>
        /// Returns ivec3.yzz swizzling.
        /// </summary>
        public ivec3 yzz => new ivec3(y, z, z);
        
        /// <summary>
        /// Returns ivec3.gbb swizzling (equivalent to ivec3.yzz).
        /// </summary>
        public ivec3 gbb => new ivec3(y, z, z);
        
        /// <summary>
        /// Returns ivec3.yzzx swizzling.
        /// </summary>
        public ivec4 yzzx => new ivec4(y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.gbbr swizzling (equivalent to ivec3.yzzx).
        /// </summary>
        public ivec4 gbbr => new ivec4(y, z, z, x);
        
        /// <summary>
        /// Returns ivec3.yzzy swizzling.
        /// </summary>
        public ivec4 yzzy => new ivec4(y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.gbbg swizzling (equivalent to ivec3.yzzy).
        /// </summary>
        public ivec4 gbbg => new ivec4(y, z, z, y);
        
        /// <summary>
        /// Returns ivec3.yzzz swizzling.
        /// </summary>
        public ivec4 yzzz => new ivec4(y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.gbbb swizzling (equivalent to ivec3.yzzz).
        /// </summary>
        public ivec4 gbbb => new ivec4(y, z, z, z);
        
        /// <summary>
        /// Returns ivec3.zx swizzling.
        /// </summary>
        public ivec2 zx => new ivec2(z, x);
        
        /// <summary>
        /// Returns ivec3.br swizzling (equivalent to ivec3.zx).
        /// </summary>
        public ivec2 br => new ivec2(z, x);
        
        /// <summary>
        /// Returns ivec3.zxx swizzling.
        /// </summary>
        public ivec3 zxx => new ivec3(z, x, x);
        
        /// <summary>
        /// Returns ivec3.brr swizzling (equivalent to ivec3.zxx).
        /// </summary>
        public ivec3 brr => new ivec3(z, x, x);
        
        /// <summary>
        /// Returns ivec3.zxxx swizzling.
        /// </summary>
        public ivec4 zxxx => new ivec4(z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.brrr swizzling (equivalent to ivec3.zxxx).
        /// </summary>
        public ivec4 brrr => new ivec4(z, x, x, x);
        
        /// <summary>
        /// Returns ivec3.zxxy swizzling.
        /// </summary>
        public ivec4 zxxy => new ivec4(z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.brrg swizzling (equivalent to ivec3.zxxy).
        /// </summary>
        public ivec4 brrg => new ivec4(z, x, x, y);
        
        /// <summary>
        /// Returns ivec3.zxxz swizzling.
        /// </summary>
        public ivec4 zxxz => new ivec4(z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.brrb swizzling (equivalent to ivec3.zxxz).
        /// </summary>
        public ivec4 brrb => new ivec4(z, x, x, z);
        
        /// <summary>
        /// Returns ivec3.zxy swizzling.
        /// </summary>
        public ivec3 zxy => new ivec3(z, x, y);
        
        /// <summary>
        /// Returns ivec3.brg swizzling (equivalent to ivec3.zxy).
        /// </summary>
        public ivec3 brg => new ivec3(z, x, y);
        
        /// <summary>
        /// Returns ivec3.zxyx swizzling.
        /// </summary>
        public ivec4 zxyx => new ivec4(z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.brgr swizzling (equivalent to ivec3.zxyx).
        /// </summary>
        public ivec4 brgr => new ivec4(z, x, y, x);
        
        /// <summary>
        /// Returns ivec3.zxyy swizzling.
        /// </summary>
        public ivec4 zxyy => new ivec4(z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.brgg swizzling (equivalent to ivec3.zxyy).
        /// </summary>
        public ivec4 brgg => new ivec4(z, x, y, y);
        
        /// <summary>
        /// Returns ivec3.zxyz swizzling.
        /// </summary>
        public ivec4 zxyz => new ivec4(z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.brgb swizzling (equivalent to ivec3.zxyz).
        /// </summary>
        public ivec4 brgb => new ivec4(z, x, y, z);
        
        /// <summary>
        /// Returns ivec3.zxz swizzling.
        /// </summary>
        public ivec3 zxz => new ivec3(z, x, z);
        
        /// <summary>
        /// Returns ivec3.brb swizzling (equivalent to ivec3.zxz).
        /// </summary>
        public ivec3 brb => new ivec3(z, x, z);
        
        /// <summary>
        /// Returns ivec3.zxzx swizzling.
        /// </summary>
        public ivec4 zxzx => new ivec4(z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.brbr swizzling (equivalent to ivec3.zxzx).
        /// </summary>
        public ivec4 brbr => new ivec4(z, x, z, x);
        
        /// <summary>
        /// Returns ivec3.zxzy swizzling.
        /// </summary>
        public ivec4 zxzy => new ivec4(z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.brbg swizzling (equivalent to ivec3.zxzy).
        /// </summary>
        public ivec4 brbg => new ivec4(z, x, z, y);
        
        /// <summary>
        /// Returns ivec3.zxzz swizzling.
        /// </summary>
        public ivec4 zxzz => new ivec4(z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.brbb swizzling (equivalent to ivec3.zxzz).
        /// </summary>
        public ivec4 brbb => new ivec4(z, x, z, z);
        
        /// <summary>
        /// Returns ivec3.zy swizzling.
        /// </summary>
        public ivec2 zy => new ivec2(z, y);
        
        /// <summary>
        /// Returns ivec3.bg swizzling (equivalent to ivec3.zy).
        /// </summary>
        public ivec2 bg => new ivec2(z, y);
        
        /// <summary>
        /// Returns ivec3.zyx swizzling.
        /// </summary>
        public ivec3 zyx => new ivec3(z, y, x);
        
        /// <summary>
        /// Returns ivec3.bgr swizzling (equivalent to ivec3.zyx).
        /// </summary>
        public ivec3 bgr => new ivec3(z, y, x);
        
        /// <summary>
        /// Returns ivec3.zyxx swizzling.
        /// </summary>
        public ivec4 zyxx => new ivec4(z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.bgrr swizzling (equivalent to ivec3.zyxx).
        /// </summary>
        public ivec4 bgrr => new ivec4(z, y, x, x);
        
        /// <summary>
        /// Returns ivec3.zyxy swizzling.
        /// </summary>
        public ivec4 zyxy => new ivec4(z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.bgrg swizzling (equivalent to ivec3.zyxy).
        /// </summary>
        public ivec4 bgrg => new ivec4(z, y, x, y);
        
        /// <summary>
        /// Returns ivec3.zyxz swizzling.
        /// </summary>
        public ivec4 zyxz => new ivec4(z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.bgrb swizzling (equivalent to ivec3.zyxz).
        /// </summary>
        public ivec4 bgrb => new ivec4(z, y, x, z);
        
        /// <summary>
        /// Returns ivec3.zyy swizzling.
        /// </summary>
        public ivec3 zyy => new ivec3(z, y, y);
        
        /// <summary>
        /// Returns ivec3.bgg swizzling (equivalent to ivec3.zyy).
        /// </summary>
        public ivec3 bgg => new ivec3(z, y, y);
        
        /// <summary>
        /// Returns ivec3.zyyx swizzling.
        /// </summary>
        public ivec4 zyyx => new ivec4(z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.bggr swizzling (equivalent to ivec3.zyyx).
        /// </summary>
        public ivec4 bggr => new ivec4(z, y, y, x);
        
        /// <summary>
        /// Returns ivec3.zyyy swizzling.
        /// </summary>
        public ivec4 zyyy => new ivec4(z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.bggg swizzling (equivalent to ivec3.zyyy).
        /// </summary>
        public ivec4 bggg => new ivec4(z, y, y, y);
        
        /// <summary>
        /// Returns ivec3.zyyz swizzling.
        /// </summary>
        public ivec4 zyyz => new ivec4(z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.bggb swizzling (equivalent to ivec3.zyyz).
        /// </summary>
        public ivec4 bggb => new ivec4(z, y, y, z);
        
        /// <summary>
        /// Returns ivec3.zyz swizzling.
        /// </summary>
        public ivec3 zyz => new ivec3(z, y, z);
        
        /// <summary>
        /// Returns ivec3.bgb swizzling (equivalent to ivec3.zyz).
        /// </summary>
        public ivec3 bgb => new ivec3(z, y, z);
        
        /// <summary>
        /// Returns ivec3.zyzx swizzling.
        /// </summary>
        public ivec4 zyzx => new ivec4(z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.bgbr swizzling (equivalent to ivec3.zyzx).
        /// </summary>
        public ivec4 bgbr => new ivec4(z, y, z, x);
        
        /// <summary>
        /// Returns ivec3.zyzy swizzling.
        /// </summary>
        public ivec4 zyzy => new ivec4(z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.bgbg swizzling (equivalent to ivec3.zyzy).
        /// </summary>
        public ivec4 bgbg => new ivec4(z, y, z, y);
        
        /// <summary>
        /// Returns ivec3.zyzz swizzling.
        /// </summary>
        public ivec4 zyzz => new ivec4(z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.bgbb swizzling (equivalent to ivec3.zyzz).
        /// </summary>
        public ivec4 bgbb => new ivec4(z, y, z, z);
        
        /// <summary>
        /// Returns ivec3.zz swizzling.
        /// </summary>
        public ivec2 zz => new ivec2(z, z);
        
        /// <summary>
        /// Returns ivec3.bb swizzling (equivalent to ivec3.zz).
        /// </summary>
        public ivec2 bb => new ivec2(z, z);
        
        /// <summary>
        /// Returns ivec3.zzx swizzling.
        /// </summary>
        public ivec3 zzx => new ivec3(z, z, x);
        
        /// <summary>
        /// Returns ivec3.bbr swizzling (equivalent to ivec3.zzx).
        /// </summary>
        public ivec3 bbr => new ivec3(z, z, x);
        
        /// <summary>
        /// Returns ivec3.zzxx swizzling.
        /// </summary>
        public ivec4 zzxx => new ivec4(z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.bbrr swizzling (equivalent to ivec3.zzxx).
        /// </summary>
        public ivec4 bbrr => new ivec4(z, z, x, x);
        
        /// <summary>
        /// Returns ivec3.zzxy swizzling.
        /// </summary>
        public ivec4 zzxy => new ivec4(z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.bbrg swizzling (equivalent to ivec3.zzxy).
        /// </summary>
        public ivec4 bbrg => new ivec4(z, z, x, y);
        
        /// <summary>
        /// Returns ivec3.zzxz swizzling.
        /// </summary>
        public ivec4 zzxz => new ivec4(z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.bbrb swizzling (equivalent to ivec3.zzxz).
        /// </summary>
        public ivec4 bbrb => new ivec4(z, z, x, z);
        
        /// <summary>
        /// Returns ivec3.zzy swizzling.
        /// </summary>
        public ivec3 zzy => new ivec3(z, z, y);
        
        /// <summary>
        /// Returns ivec3.bbg swizzling (equivalent to ivec3.zzy).
        /// </summary>
        public ivec3 bbg => new ivec3(z, z, y);
        
        /// <summary>
        /// Returns ivec3.zzyx swizzling.
        /// </summary>
        public ivec4 zzyx => new ivec4(z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.bbgr swizzling (equivalent to ivec3.zzyx).
        /// </summary>
        public ivec4 bbgr => new ivec4(z, z, y, x);
        
        /// <summary>
        /// Returns ivec3.zzyy swizzling.
        /// </summary>
        public ivec4 zzyy => new ivec4(z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.bbgg swizzling (equivalent to ivec3.zzyy).
        /// </summary>
        public ivec4 bbgg => new ivec4(z, z, y, y);
        
        /// <summary>
        /// Returns ivec3.zzyz swizzling.
        /// </summary>
        public ivec4 zzyz => new ivec4(z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.bbgb swizzling (equivalent to ivec3.zzyz).
        /// </summary>
        public ivec4 bbgb => new ivec4(z, z, y, z);
        
        /// <summary>
        /// Returns ivec3.zzz swizzling.
        /// </summary>
        public ivec3 zzz => new ivec3(z, z, z);
        
        /// <summary>
        /// Returns ivec3.bbb swizzling (equivalent to ivec3.zzz).
        /// </summary>
        public ivec3 bbb => new ivec3(z, z, z);
        
        /// <summary>
        /// Returns ivec3.zzzx swizzling.
        /// </summary>
        public ivec4 zzzx => new ivec4(z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.bbbr swizzling (equivalent to ivec3.zzzx).
        /// </summary>
        public ivec4 bbbr => new ivec4(z, z, z, x);
        
        /// <summary>
        /// Returns ivec3.zzzy swizzling.
        /// </summary>
        public ivec4 zzzy => new ivec4(z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.bbbg swizzling (equivalent to ivec3.zzzy).
        /// </summary>
        public ivec4 bbbg => new ivec4(z, z, z, y);
        
        /// <summary>
        /// Returns ivec3.zzzz swizzling.
        /// </summary>
        public ivec4 zzzz => new ivec4(z, z, z, z);
        
        /// <summary>
        /// Returns ivec3.bbbb swizzling (equivalent to ivec3.zzzz).
        /// </summary>
        public ivec4 bbbb => new ivec4(z, z, z, z);

        #endregion

    }
}
