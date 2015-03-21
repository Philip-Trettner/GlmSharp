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
    /// Temporary vector of type T with 3 components, used for implementing swizzling for gvec3.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_gvec3<T>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly T x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly T y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly T z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_gvec3.
        /// </summary>
        internal swizzle_gvec3(T x, T y, T z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns gvec3.xx swizzling.
        /// </summary>
        public gvec2<T> xx => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec3.rr swizzling (equivalent to gvec3.xx).
        /// </summary>
        public gvec2<T> rr => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec3.xxx swizzling.
        /// </summary>
        public gvec3<T> xxx => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec3.rrr swizzling (equivalent to gvec3.xxx).
        /// </summary>
        public gvec3<T> rrr => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec3.xxxx swizzling.
        /// </summary>
        public gvec4<T> xxxx => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.rrrr swizzling (equivalent to gvec3.xxxx).
        /// </summary>
        public gvec4<T> rrrr => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec3.xxxy swizzling.
        /// </summary>
        public gvec4<T> xxxy => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.rrrg swizzling (equivalent to gvec3.xxxy).
        /// </summary>
        public gvec4<T> rrrg => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec3.xxxz swizzling.
        /// </summary>
        public gvec4<T> xxxz => new gvec4<T>(x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.rrrb swizzling (equivalent to gvec3.xxxz).
        /// </summary>
        public gvec4<T> rrrb => new gvec4<T>(x, x, x, z);
        
        /// <summary>
        /// Returns gvec3.xxy swizzling.
        /// </summary>
        public gvec3<T> xxy => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec3.rrg swizzling (equivalent to gvec3.xxy).
        /// </summary>
        public gvec3<T> rrg => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec3.xxyx swizzling.
        /// </summary>
        public gvec4<T> xxyx => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.rrgr swizzling (equivalent to gvec3.xxyx).
        /// </summary>
        public gvec4<T> rrgr => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec3.xxyy swizzling.
        /// </summary>
        public gvec4<T> xxyy => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.rrgg swizzling (equivalent to gvec3.xxyy).
        /// </summary>
        public gvec4<T> rrgg => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec3.xxyz swizzling.
        /// </summary>
        public gvec4<T> xxyz => new gvec4<T>(x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.rrgb swizzling (equivalent to gvec3.xxyz).
        /// </summary>
        public gvec4<T> rrgb => new gvec4<T>(x, x, y, z);
        
        /// <summary>
        /// Returns gvec3.xxz swizzling.
        /// </summary>
        public gvec3<T> xxz => new gvec3<T>(x, x, z);
        
        /// <summary>
        /// Returns gvec3.rrb swizzling (equivalent to gvec3.xxz).
        /// </summary>
        public gvec3<T> rrb => new gvec3<T>(x, x, z);
        
        /// <summary>
        /// Returns gvec3.xxzx swizzling.
        /// </summary>
        public gvec4<T> xxzx => new gvec4<T>(x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.rrbr swizzling (equivalent to gvec3.xxzx).
        /// </summary>
        public gvec4<T> rrbr => new gvec4<T>(x, x, z, x);
        
        /// <summary>
        /// Returns gvec3.xxzy swizzling.
        /// </summary>
        public gvec4<T> xxzy => new gvec4<T>(x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.rrbg swizzling (equivalent to gvec3.xxzy).
        /// </summary>
        public gvec4<T> rrbg => new gvec4<T>(x, x, z, y);
        
        /// <summary>
        /// Returns gvec3.xxzz swizzling.
        /// </summary>
        public gvec4<T> xxzz => new gvec4<T>(x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.rrbb swizzling (equivalent to gvec3.xxzz).
        /// </summary>
        public gvec4<T> rrbb => new gvec4<T>(x, x, z, z);
        
        /// <summary>
        /// Returns gvec3.xy swizzling.
        /// </summary>
        public gvec2<T> xy => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec3.rg swizzling (equivalent to gvec3.xy).
        /// </summary>
        public gvec2<T> rg => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec3.xyx swizzling.
        /// </summary>
        public gvec3<T> xyx => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec3.rgr swizzling (equivalent to gvec3.xyx).
        /// </summary>
        public gvec3<T> rgr => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec3.xyxx swizzling.
        /// </summary>
        public gvec4<T> xyxx => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.rgrr swizzling (equivalent to gvec3.xyxx).
        /// </summary>
        public gvec4<T> rgrr => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec3.xyxy swizzling.
        /// </summary>
        public gvec4<T> xyxy => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.rgrg swizzling (equivalent to gvec3.xyxy).
        /// </summary>
        public gvec4<T> rgrg => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec3.xyxz swizzling.
        /// </summary>
        public gvec4<T> xyxz => new gvec4<T>(x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.rgrb swizzling (equivalent to gvec3.xyxz).
        /// </summary>
        public gvec4<T> rgrb => new gvec4<T>(x, y, x, z);
        
        /// <summary>
        /// Returns gvec3.xyy swizzling.
        /// </summary>
        public gvec3<T> xyy => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec3.rgg swizzling (equivalent to gvec3.xyy).
        /// </summary>
        public gvec3<T> rgg => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec3.xyyx swizzling.
        /// </summary>
        public gvec4<T> xyyx => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.rggr swizzling (equivalent to gvec3.xyyx).
        /// </summary>
        public gvec4<T> rggr => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec3.xyyy swizzling.
        /// </summary>
        public gvec4<T> xyyy => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.rggg swizzling (equivalent to gvec3.xyyy).
        /// </summary>
        public gvec4<T> rggg => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec3.xyyz swizzling.
        /// </summary>
        public gvec4<T> xyyz => new gvec4<T>(x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.rggb swizzling (equivalent to gvec3.xyyz).
        /// </summary>
        public gvec4<T> rggb => new gvec4<T>(x, y, y, z);
        
        /// <summary>
        /// Returns gvec3.xyz swizzling.
        /// </summary>
        public gvec3<T> xyz => new gvec3<T>(x, y, z);
        
        /// <summary>
        /// Returns gvec3.rgb swizzling (equivalent to gvec3.xyz).
        /// </summary>
        public gvec3<T> rgb => new gvec3<T>(x, y, z);
        
        /// <summary>
        /// Returns gvec3.xyzx swizzling.
        /// </summary>
        public gvec4<T> xyzx => new gvec4<T>(x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.rgbr swizzling (equivalent to gvec3.xyzx).
        /// </summary>
        public gvec4<T> rgbr => new gvec4<T>(x, y, z, x);
        
        /// <summary>
        /// Returns gvec3.xyzy swizzling.
        /// </summary>
        public gvec4<T> xyzy => new gvec4<T>(x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.rgbg swizzling (equivalent to gvec3.xyzy).
        /// </summary>
        public gvec4<T> rgbg => new gvec4<T>(x, y, z, y);
        
        /// <summary>
        /// Returns gvec3.xyzz swizzling.
        /// </summary>
        public gvec4<T> xyzz => new gvec4<T>(x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.rgbb swizzling (equivalent to gvec3.xyzz).
        /// </summary>
        public gvec4<T> rgbb => new gvec4<T>(x, y, z, z);
        
        /// <summary>
        /// Returns gvec3.xz swizzling.
        /// </summary>
        public gvec2<T> xz => new gvec2<T>(x, z);
        
        /// <summary>
        /// Returns gvec3.rb swizzling (equivalent to gvec3.xz).
        /// </summary>
        public gvec2<T> rb => new gvec2<T>(x, z);
        
        /// <summary>
        /// Returns gvec3.xzx swizzling.
        /// </summary>
        public gvec3<T> xzx => new gvec3<T>(x, z, x);
        
        /// <summary>
        /// Returns gvec3.rbr swizzling (equivalent to gvec3.xzx).
        /// </summary>
        public gvec3<T> rbr => new gvec3<T>(x, z, x);
        
        /// <summary>
        /// Returns gvec3.xzxx swizzling.
        /// </summary>
        public gvec4<T> xzxx => new gvec4<T>(x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.rbrr swizzling (equivalent to gvec3.xzxx).
        /// </summary>
        public gvec4<T> rbrr => new gvec4<T>(x, z, x, x);
        
        /// <summary>
        /// Returns gvec3.xzxy swizzling.
        /// </summary>
        public gvec4<T> xzxy => new gvec4<T>(x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.rbrg swizzling (equivalent to gvec3.xzxy).
        /// </summary>
        public gvec4<T> rbrg => new gvec4<T>(x, z, x, y);
        
        /// <summary>
        /// Returns gvec3.xzxz swizzling.
        /// </summary>
        public gvec4<T> xzxz => new gvec4<T>(x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.rbrb swizzling (equivalent to gvec3.xzxz).
        /// </summary>
        public gvec4<T> rbrb => new gvec4<T>(x, z, x, z);
        
        /// <summary>
        /// Returns gvec3.xzy swizzling.
        /// </summary>
        public gvec3<T> xzy => new gvec3<T>(x, z, y);
        
        /// <summary>
        /// Returns gvec3.rbg swizzling (equivalent to gvec3.xzy).
        /// </summary>
        public gvec3<T> rbg => new gvec3<T>(x, z, y);
        
        /// <summary>
        /// Returns gvec3.xzyx swizzling.
        /// </summary>
        public gvec4<T> xzyx => new gvec4<T>(x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.rbgr swizzling (equivalent to gvec3.xzyx).
        /// </summary>
        public gvec4<T> rbgr => new gvec4<T>(x, z, y, x);
        
        /// <summary>
        /// Returns gvec3.xzyy swizzling.
        /// </summary>
        public gvec4<T> xzyy => new gvec4<T>(x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.rbgg swizzling (equivalent to gvec3.xzyy).
        /// </summary>
        public gvec4<T> rbgg => new gvec4<T>(x, z, y, y);
        
        /// <summary>
        /// Returns gvec3.xzyz swizzling.
        /// </summary>
        public gvec4<T> xzyz => new gvec4<T>(x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.rbgb swizzling (equivalent to gvec3.xzyz).
        /// </summary>
        public gvec4<T> rbgb => new gvec4<T>(x, z, y, z);
        
        /// <summary>
        /// Returns gvec3.xzz swizzling.
        /// </summary>
        public gvec3<T> xzz => new gvec3<T>(x, z, z);
        
        /// <summary>
        /// Returns gvec3.rbb swizzling (equivalent to gvec3.xzz).
        /// </summary>
        public gvec3<T> rbb => new gvec3<T>(x, z, z);
        
        /// <summary>
        /// Returns gvec3.xzzx swizzling.
        /// </summary>
        public gvec4<T> xzzx => new gvec4<T>(x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.rbbr swizzling (equivalent to gvec3.xzzx).
        /// </summary>
        public gvec4<T> rbbr => new gvec4<T>(x, z, z, x);
        
        /// <summary>
        /// Returns gvec3.xzzy swizzling.
        /// </summary>
        public gvec4<T> xzzy => new gvec4<T>(x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.rbbg swizzling (equivalent to gvec3.xzzy).
        /// </summary>
        public gvec4<T> rbbg => new gvec4<T>(x, z, z, y);
        
        /// <summary>
        /// Returns gvec3.xzzz swizzling.
        /// </summary>
        public gvec4<T> xzzz => new gvec4<T>(x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.rbbb swizzling (equivalent to gvec3.xzzz).
        /// </summary>
        public gvec4<T> rbbb => new gvec4<T>(x, z, z, z);
        
        /// <summary>
        /// Returns gvec3.yx swizzling.
        /// </summary>
        public gvec2<T> yx => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec3.gr swizzling (equivalent to gvec3.yx).
        /// </summary>
        public gvec2<T> gr => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec3.yxx swizzling.
        /// </summary>
        public gvec3<T> yxx => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec3.grr swizzling (equivalent to gvec3.yxx).
        /// </summary>
        public gvec3<T> grr => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec3.yxxx swizzling.
        /// </summary>
        public gvec4<T> yxxx => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.grrr swizzling (equivalent to gvec3.yxxx).
        /// </summary>
        public gvec4<T> grrr => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec3.yxxy swizzling.
        /// </summary>
        public gvec4<T> yxxy => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.grrg swizzling (equivalent to gvec3.yxxy).
        /// </summary>
        public gvec4<T> grrg => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec3.yxxz swizzling.
        /// </summary>
        public gvec4<T> yxxz => new gvec4<T>(y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.grrb swizzling (equivalent to gvec3.yxxz).
        /// </summary>
        public gvec4<T> grrb => new gvec4<T>(y, x, x, z);
        
        /// <summary>
        /// Returns gvec3.yxy swizzling.
        /// </summary>
        public gvec3<T> yxy => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec3.grg swizzling (equivalent to gvec3.yxy).
        /// </summary>
        public gvec3<T> grg => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec3.yxyx swizzling.
        /// </summary>
        public gvec4<T> yxyx => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.grgr swizzling (equivalent to gvec3.yxyx).
        /// </summary>
        public gvec4<T> grgr => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec3.yxyy swizzling.
        /// </summary>
        public gvec4<T> yxyy => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.grgg swizzling (equivalent to gvec3.yxyy).
        /// </summary>
        public gvec4<T> grgg => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec3.yxyz swizzling.
        /// </summary>
        public gvec4<T> yxyz => new gvec4<T>(y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.grgb swizzling (equivalent to gvec3.yxyz).
        /// </summary>
        public gvec4<T> grgb => new gvec4<T>(y, x, y, z);
        
        /// <summary>
        /// Returns gvec3.yxz swizzling.
        /// </summary>
        public gvec3<T> yxz => new gvec3<T>(y, x, z);
        
        /// <summary>
        /// Returns gvec3.grb swizzling (equivalent to gvec3.yxz).
        /// </summary>
        public gvec3<T> grb => new gvec3<T>(y, x, z);
        
        /// <summary>
        /// Returns gvec3.yxzx swizzling.
        /// </summary>
        public gvec4<T> yxzx => new gvec4<T>(y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.grbr swizzling (equivalent to gvec3.yxzx).
        /// </summary>
        public gvec4<T> grbr => new gvec4<T>(y, x, z, x);
        
        /// <summary>
        /// Returns gvec3.yxzy swizzling.
        /// </summary>
        public gvec4<T> yxzy => new gvec4<T>(y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.grbg swizzling (equivalent to gvec3.yxzy).
        /// </summary>
        public gvec4<T> grbg => new gvec4<T>(y, x, z, y);
        
        /// <summary>
        /// Returns gvec3.yxzz swizzling.
        /// </summary>
        public gvec4<T> yxzz => new gvec4<T>(y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.grbb swizzling (equivalent to gvec3.yxzz).
        /// </summary>
        public gvec4<T> grbb => new gvec4<T>(y, x, z, z);
        
        /// <summary>
        /// Returns gvec3.yy swizzling.
        /// </summary>
        public gvec2<T> yy => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec3.gg swizzling (equivalent to gvec3.yy).
        /// </summary>
        public gvec2<T> gg => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec3.yyx swizzling.
        /// </summary>
        public gvec3<T> yyx => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec3.ggr swizzling (equivalent to gvec3.yyx).
        /// </summary>
        public gvec3<T> ggr => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec3.yyxx swizzling.
        /// </summary>
        public gvec4<T> yyxx => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.ggrr swizzling (equivalent to gvec3.yyxx).
        /// </summary>
        public gvec4<T> ggrr => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec3.yyxy swizzling.
        /// </summary>
        public gvec4<T> yyxy => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.ggrg swizzling (equivalent to gvec3.yyxy).
        /// </summary>
        public gvec4<T> ggrg => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec3.yyxz swizzling.
        /// </summary>
        public gvec4<T> yyxz => new gvec4<T>(y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.ggrb swizzling (equivalent to gvec3.yyxz).
        /// </summary>
        public gvec4<T> ggrb => new gvec4<T>(y, y, x, z);
        
        /// <summary>
        /// Returns gvec3.yyy swizzling.
        /// </summary>
        public gvec3<T> yyy => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec3.ggg swizzling (equivalent to gvec3.yyy).
        /// </summary>
        public gvec3<T> ggg => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec3.yyyx swizzling.
        /// </summary>
        public gvec4<T> yyyx => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.gggr swizzling (equivalent to gvec3.yyyx).
        /// </summary>
        public gvec4<T> gggr => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec3.yyyy swizzling.
        /// </summary>
        public gvec4<T> yyyy => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.gggg swizzling (equivalent to gvec3.yyyy).
        /// </summary>
        public gvec4<T> gggg => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec3.yyyz swizzling.
        /// </summary>
        public gvec4<T> yyyz => new gvec4<T>(y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.gggb swizzling (equivalent to gvec3.yyyz).
        /// </summary>
        public gvec4<T> gggb => new gvec4<T>(y, y, y, z);
        
        /// <summary>
        /// Returns gvec3.yyz swizzling.
        /// </summary>
        public gvec3<T> yyz => new gvec3<T>(y, y, z);
        
        /// <summary>
        /// Returns gvec3.ggb swizzling (equivalent to gvec3.yyz).
        /// </summary>
        public gvec3<T> ggb => new gvec3<T>(y, y, z);
        
        /// <summary>
        /// Returns gvec3.yyzx swizzling.
        /// </summary>
        public gvec4<T> yyzx => new gvec4<T>(y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.ggbr swizzling (equivalent to gvec3.yyzx).
        /// </summary>
        public gvec4<T> ggbr => new gvec4<T>(y, y, z, x);
        
        /// <summary>
        /// Returns gvec3.yyzy swizzling.
        /// </summary>
        public gvec4<T> yyzy => new gvec4<T>(y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.ggbg swizzling (equivalent to gvec3.yyzy).
        /// </summary>
        public gvec4<T> ggbg => new gvec4<T>(y, y, z, y);
        
        /// <summary>
        /// Returns gvec3.yyzz swizzling.
        /// </summary>
        public gvec4<T> yyzz => new gvec4<T>(y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.ggbb swizzling (equivalent to gvec3.yyzz).
        /// </summary>
        public gvec4<T> ggbb => new gvec4<T>(y, y, z, z);
        
        /// <summary>
        /// Returns gvec3.yz swizzling.
        /// </summary>
        public gvec2<T> yz => new gvec2<T>(y, z);
        
        /// <summary>
        /// Returns gvec3.gb swizzling (equivalent to gvec3.yz).
        /// </summary>
        public gvec2<T> gb => new gvec2<T>(y, z);
        
        /// <summary>
        /// Returns gvec3.yzx swizzling.
        /// </summary>
        public gvec3<T> yzx => new gvec3<T>(y, z, x);
        
        /// <summary>
        /// Returns gvec3.gbr swizzling (equivalent to gvec3.yzx).
        /// </summary>
        public gvec3<T> gbr => new gvec3<T>(y, z, x);
        
        /// <summary>
        /// Returns gvec3.yzxx swizzling.
        /// </summary>
        public gvec4<T> yzxx => new gvec4<T>(y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.gbrr swizzling (equivalent to gvec3.yzxx).
        /// </summary>
        public gvec4<T> gbrr => new gvec4<T>(y, z, x, x);
        
        /// <summary>
        /// Returns gvec3.yzxy swizzling.
        /// </summary>
        public gvec4<T> yzxy => new gvec4<T>(y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.gbrg swizzling (equivalent to gvec3.yzxy).
        /// </summary>
        public gvec4<T> gbrg => new gvec4<T>(y, z, x, y);
        
        /// <summary>
        /// Returns gvec3.yzxz swizzling.
        /// </summary>
        public gvec4<T> yzxz => new gvec4<T>(y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.gbrb swizzling (equivalent to gvec3.yzxz).
        /// </summary>
        public gvec4<T> gbrb => new gvec4<T>(y, z, x, z);
        
        /// <summary>
        /// Returns gvec3.yzy swizzling.
        /// </summary>
        public gvec3<T> yzy => new gvec3<T>(y, z, y);
        
        /// <summary>
        /// Returns gvec3.gbg swizzling (equivalent to gvec3.yzy).
        /// </summary>
        public gvec3<T> gbg => new gvec3<T>(y, z, y);
        
        /// <summary>
        /// Returns gvec3.yzyx swizzling.
        /// </summary>
        public gvec4<T> yzyx => new gvec4<T>(y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.gbgr swizzling (equivalent to gvec3.yzyx).
        /// </summary>
        public gvec4<T> gbgr => new gvec4<T>(y, z, y, x);
        
        /// <summary>
        /// Returns gvec3.yzyy swizzling.
        /// </summary>
        public gvec4<T> yzyy => new gvec4<T>(y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.gbgg swizzling (equivalent to gvec3.yzyy).
        /// </summary>
        public gvec4<T> gbgg => new gvec4<T>(y, z, y, y);
        
        /// <summary>
        /// Returns gvec3.yzyz swizzling.
        /// </summary>
        public gvec4<T> yzyz => new gvec4<T>(y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.gbgb swizzling (equivalent to gvec3.yzyz).
        /// </summary>
        public gvec4<T> gbgb => new gvec4<T>(y, z, y, z);
        
        /// <summary>
        /// Returns gvec3.yzz swizzling.
        /// </summary>
        public gvec3<T> yzz => new gvec3<T>(y, z, z);
        
        /// <summary>
        /// Returns gvec3.gbb swizzling (equivalent to gvec3.yzz).
        /// </summary>
        public gvec3<T> gbb => new gvec3<T>(y, z, z);
        
        /// <summary>
        /// Returns gvec3.yzzx swizzling.
        /// </summary>
        public gvec4<T> yzzx => new gvec4<T>(y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.gbbr swizzling (equivalent to gvec3.yzzx).
        /// </summary>
        public gvec4<T> gbbr => new gvec4<T>(y, z, z, x);
        
        /// <summary>
        /// Returns gvec3.yzzy swizzling.
        /// </summary>
        public gvec4<T> yzzy => new gvec4<T>(y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.gbbg swizzling (equivalent to gvec3.yzzy).
        /// </summary>
        public gvec4<T> gbbg => new gvec4<T>(y, z, z, y);
        
        /// <summary>
        /// Returns gvec3.yzzz swizzling.
        /// </summary>
        public gvec4<T> yzzz => new gvec4<T>(y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.gbbb swizzling (equivalent to gvec3.yzzz).
        /// </summary>
        public gvec4<T> gbbb => new gvec4<T>(y, z, z, z);
        
        /// <summary>
        /// Returns gvec3.zx swizzling.
        /// </summary>
        public gvec2<T> zx => new gvec2<T>(z, x);
        
        /// <summary>
        /// Returns gvec3.br swizzling (equivalent to gvec3.zx).
        /// </summary>
        public gvec2<T> br => new gvec2<T>(z, x);
        
        /// <summary>
        /// Returns gvec3.zxx swizzling.
        /// </summary>
        public gvec3<T> zxx => new gvec3<T>(z, x, x);
        
        /// <summary>
        /// Returns gvec3.brr swizzling (equivalent to gvec3.zxx).
        /// </summary>
        public gvec3<T> brr => new gvec3<T>(z, x, x);
        
        /// <summary>
        /// Returns gvec3.zxxx swizzling.
        /// </summary>
        public gvec4<T> zxxx => new gvec4<T>(z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.brrr swizzling (equivalent to gvec3.zxxx).
        /// </summary>
        public gvec4<T> brrr => new gvec4<T>(z, x, x, x);
        
        /// <summary>
        /// Returns gvec3.zxxy swizzling.
        /// </summary>
        public gvec4<T> zxxy => new gvec4<T>(z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.brrg swizzling (equivalent to gvec3.zxxy).
        /// </summary>
        public gvec4<T> brrg => new gvec4<T>(z, x, x, y);
        
        /// <summary>
        /// Returns gvec3.zxxz swizzling.
        /// </summary>
        public gvec4<T> zxxz => new gvec4<T>(z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.brrb swizzling (equivalent to gvec3.zxxz).
        /// </summary>
        public gvec4<T> brrb => new gvec4<T>(z, x, x, z);
        
        /// <summary>
        /// Returns gvec3.zxy swizzling.
        /// </summary>
        public gvec3<T> zxy => new gvec3<T>(z, x, y);
        
        /// <summary>
        /// Returns gvec3.brg swizzling (equivalent to gvec3.zxy).
        /// </summary>
        public gvec3<T> brg => new gvec3<T>(z, x, y);
        
        /// <summary>
        /// Returns gvec3.zxyx swizzling.
        /// </summary>
        public gvec4<T> zxyx => new gvec4<T>(z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.brgr swizzling (equivalent to gvec3.zxyx).
        /// </summary>
        public gvec4<T> brgr => new gvec4<T>(z, x, y, x);
        
        /// <summary>
        /// Returns gvec3.zxyy swizzling.
        /// </summary>
        public gvec4<T> zxyy => new gvec4<T>(z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.brgg swizzling (equivalent to gvec3.zxyy).
        /// </summary>
        public gvec4<T> brgg => new gvec4<T>(z, x, y, y);
        
        /// <summary>
        /// Returns gvec3.zxyz swizzling.
        /// </summary>
        public gvec4<T> zxyz => new gvec4<T>(z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.brgb swizzling (equivalent to gvec3.zxyz).
        /// </summary>
        public gvec4<T> brgb => new gvec4<T>(z, x, y, z);
        
        /// <summary>
        /// Returns gvec3.zxz swizzling.
        /// </summary>
        public gvec3<T> zxz => new gvec3<T>(z, x, z);
        
        /// <summary>
        /// Returns gvec3.brb swizzling (equivalent to gvec3.zxz).
        /// </summary>
        public gvec3<T> brb => new gvec3<T>(z, x, z);
        
        /// <summary>
        /// Returns gvec3.zxzx swizzling.
        /// </summary>
        public gvec4<T> zxzx => new gvec4<T>(z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.brbr swizzling (equivalent to gvec3.zxzx).
        /// </summary>
        public gvec4<T> brbr => new gvec4<T>(z, x, z, x);
        
        /// <summary>
        /// Returns gvec3.zxzy swizzling.
        /// </summary>
        public gvec4<T> zxzy => new gvec4<T>(z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.brbg swizzling (equivalent to gvec3.zxzy).
        /// </summary>
        public gvec4<T> brbg => new gvec4<T>(z, x, z, y);
        
        /// <summary>
        /// Returns gvec3.zxzz swizzling.
        /// </summary>
        public gvec4<T> zxzz => new gvec4<T>(z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.brbb swizzling (equivalent to gvec3.zxzz).
        /// </summary>
        public gvec4<T> brbb => new gvec4<T>(z, x, z, z);
        
        /// <summary>
        /// Returns gvec3.zy swizzling.
        /// </summary>
        public gvec2<T> zy => new gvec2<T>(z, y);
        
        /// <summary>
        /// Returns gvec3.bg swizzling (equivalent to gvec3.zy).
        /// </summary>
        public gvec2<T> bg => new gvec2<T>(z, y);
        
        /// <summary>
        /// Returns gvec3.zyx swizzling.
        /// </summary>
        public gvec3<T> zyx => new gvec3<T>(z, y, x);
        
        /// <summary>
        /// Returns gvec3.bgr swizzling (equivalent to gvec3.zyx).
        /// </summary>
        public gvec3<T> bgr => new gvec3<T>(z, y, x);
        
        /// <summary>
        /// Returns gvec3.zyxx swizzling.
        /// </summary>
        public gvec4<T> zyxx => new gvec4<T>(z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.bgrr swizzling (equivalent to gvec3.zyxx).
        /// </summary>
        public gvec4<T> bgrr => new gvec4<T>(z, y, x, x);
        
        /// <summary>
        /// Returns gvec3.zyxy swizzling.
        /// </summary>
        public gvec4<T> zyxy => new gvec4<T>(z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.bgrg swizzling (equivalent to gvec3.zyxy).
        /// </summary>
        public gvec4<T> bgrg => new gvec4<T>(z, y, x, y);
        
        /// <summary>
        /// Returns gvec3.zyxz swizzling.
        /// </summary>
        public gvec4<T> zyxz => new gvec4<T>(z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.bgrb swizzling (equivalent to gvec3.zyxz).
        /// </summary>
        public gvec4<T> bgrb => new gvec4<T>(z, y, x, z);
        
        /// <summary>
        /// Returns gvec3.zyy swizzling.
        /// </summary>
        public gvec3<T> zyy => new gvec3<T>(z, y, y);
        
        /// <summary>
        /// Returns gvec3.bgg swizzling (equivalent to gvec3.zyy).
        /// </summary>
        public gvec3<T> bgg => new gvec3<T>(z, y, y);
        
        /// <summary>
        /// Returns gvec3.zyyx swizzling.
        /// </summary>
        public gvec4<T> zyyx => new gvec4<T>(z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.bggr swizzling (equivalent to gvec3.zyyx).
        /// </summary>
        public gvec4<T> bggr => new gvec4<T>(z, y, y, x);
        
        /// <summary>
        /// Returns gvec3.zyyy swizzling.
        /// </summary>
        public gvec4<T> zyyy => new gvec4<T>(z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.bggg swizzling (equivalent to gvec3.zyyy).
        /// </summary>
        public gvec4<T> bggg => new gvec4<T>(z, y, y, y);
        
        /// <summary>
        /// Returns gvec3.zyyz swizzling.
        /// </summary>
        public gvec4<T> zyyz => new gvec4<T>(z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.bggb swizzling (equivalent to gvec3.zyyz).
        /// </summary>
        public gvec4<T> bggb => new gvec4<T>(z, y, y, z);
        
        /// <summary>
        /// Returns gvec3.zyz swizzling.
        /// </summary>
        public gvec3<T> zyz => new gvec3<T>(z, y, z);
        
        /// <summary>
        /// Returns gvec3.bgb swizzling (equivalent to gvec3.zyz).
        /// </summary>
        public gvec3<T> bgb => new gvec3<T>(z, y, z);
        
        /// <summary>
        /// Returns gvec3.zyzx swizzling.
        /// </summary>
        public gvec4<T> zyzx => new gvec4<T>(z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.bgbr swizzling (equivalent to gvec3.zyzx).
        /// </summary>
        public gvec4<T> bgbr => new gvec4<T>(z, y, z, x);
        
        /// <summary>
        /// Returns gvec3.zyzy swizzling.
        /// </summary>
        public gvec4<T> zyzy => new gvec4<T>(z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.bgbg swizzling (equivalent to gvec3.zyzy).
        /// </summary>
        public gvec4<T> bgbg => new gvec4<T>(z, y, z, y);
        
        /// <summary>
        /// Returns gvec3.zyzz swizzling.
        /// </summary>
        public gvec4<T> zyzz => new gvec4<T>(z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.bgbb swizzling (equivalent to gvec3.zyzz).
        /// </summary>
        public gvec4<T> bgbb => new gvec4<T>(z, y, z, z);
        
        /// <summary>
        /// Returns gvec3.zz swizzling.
        /// </summary>
        public gvec2<T> zz => new gvec2<T>(z, z);
        
        /// <summary>
        /// Returns gvec3.bb swizzling (equivalent to gvec3.zz).
        /// </summary>
        public gvec2<T> bb => new gvec2<T>(z, z);
        
        /// <summary>
        /// Returns gvec3.zzx swizzling.
        /// </summary>
        public gvec3<T> zzx => new gvec3<T>(z, z, x);
        
        /// <summary>
        /// Returns gvec3.bbr swizzling (equivalent to gvec3.zzx).
        /// </summary>
        public gvec3<T> bbr => new gvec3<T>(z, z, x);
        
        /// <summary>
        /// Returns gvec3.zzxx swizzling.
        /// </summary>
        public gvec4<T> zzxx => new gvec4<T>(z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.bbrr swizzling (equivalent to gvec3.zzxx).
        /// </summary>
        public gvec4<T> bbrr => new gvec4<T>(z, z, x, x);
        
        /// <summary>
        /// Returns gvec3.zzxy swizzling.
        /// </summary>
        public gvec4<T> zzxy => new gvec4<T>(z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.bbrg swizzling (equivalent to gvec3.zzxy).
        /// </summary>
        public gvec4<T> bbrg => new gvec4<T>(z, z, x, y);
        
        /// <summary>
        /// Returns gvec3.zzxz swizzling.
        /// </summary>
        public gvec4<T> zzxz => new gvec4<T>(z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.bbrb swizzling (equivalent to gvec3.zzxz).
        /// </summary>
        public gvec4<T> bbrb => new gvec4<T>(z, z, x, z);
        
        /// <summary>
        /// Returns gvec3.zzy swizzling.
        /// </summary>
        public gvec3<T> zzy => new gvec3<T>(z, z, y);
        
        /// <summary>
        /// Returns gvec3.bbg swizzling (equivalent to gvec3.zzy).
        /// </summary>
        public gvec3<T> bbg => new gvec3<T>(z, z, y);
        
        /// <summary>
        /// Returns gvec3.zzyx swizzling.
        /// </summary>
        public gvec4<T> zzyx => new gvec4<T>(z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.bbgr swizzling (equivalent to gvec3.zzyx).
        /// </summary>
        public gvec4<T> bbgr => new gvec4<T>(z, z, y, x);
        
        /// <summary>
        /// Returns gvec3.zzyy swizzling.
        /// </summary>
        public gvec4<T> zzyy => new gvec4<T>(z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.bbgg swizzling (equivalent to gvec3.zzyy).
        /// </summary>
        public gvec4<T> bbgg => new gvec4<T>(z, z, y, y);
        
        /// <summary>
        /// Returns gvec3.zzyz swizzling.
        /// </summary>
        public gvec4<T> zzyz => new gvec4<T>(z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.bbgb swizzling (equivalent to gvec3.zzyz).
        /// </summary>
        public gvec4<T> bbgb => new gvec4<T>(z, z, y, z);
        
        /// <summary>
        /// Returns gvec3.zzz swizzling.
        /// </summary>
        public gvec3<T> zzz => new gvec3<T>(z, z, z);
        
        /// <summary>
        /// Returns gvec3.bbb swizzling (equivalent to gvec3.zzz).
        /// </summary>
        public gvec3<T> bbb => new gvec3<T>(z, z, z);
        
        /// <summary>
        /// Returns gvec3.zzzx swizzling.
        /// </summary>
        public gvec4<T> zzzx => new gvec4<T>(z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.bbbr swizzling (equivalent to gvec3.zzzx).
        /// </summary>
        public gvec4<T> bbbr => new gvec4<T>(z, z, z, x);
        
        /// <summary>
        /// Returns gvec3.zzzy swizzling.
        /// </summary>
        public gvec4<T> zzzy => new gvec4<T>(z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.bbbg swizzling (equivalent to gvec3.zzzy).
        /// </summary>
        public gvec4<T> bbbg => new gvec4<T>(z, z, z, y);
        
        /// <summary>
        /// Returns gvec3.zzzz swizzling.
        /// </summary>
        public gvec4<T> zzzz => new gvec4<T>(z, z, z, z);
        
        /// <summary>
        /// Returns gvec3.bbbb swizzling (equivalent to gvec3.zzzz).
        /// </summary>
        public gvec4<T> bbbb => new gvec4<T>(z, z, z, z);

        #endregion

    }
}
