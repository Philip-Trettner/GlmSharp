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
    /// Temporary vector of type Complex with 4 components, used for implementing swizzling for cvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_cvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly Complex x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly Complex y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly Complex z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly Complex w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_cvec4.
        /// </summary>
        internal swizzle_cvec4(Complex x, Complex y, Complex z, Complex w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns cvec4.xx swizzling.
        /// </summary>
        public cvec2 xx => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec4.rr swizzling (equivalent to cvec4.xx).
        /// </summary>
        public cvec2 rr => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec4.xxx swizzling.
        /// </summary>
        public cvec3 xxx => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec4.rrr swizzling (equivalent to cvec4.xxx).
        /// </summary>
        public cvec3 rrr => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec4.xxxx swizzling.
        /// </summary>
        public cvec4 xxxx => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.rrrr swizzling (equivalent to cvec4.xxxx).
        /// </summary>
        public cvec4 rrrr => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.xxxy swizzling.
        /// </summary>
        public cvec4 xxxy => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.rrrg swizzling (equivalent to cvec4.xxxy).
        /// </summary>
        public cvec4 rrrg => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.xxxz swizzling.
        /// </summary>
        public cvec4 xxxz => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.rrrb swizzling (equivalent to cvec4.xxxz).
        /// </summary>
        public cvec4 rrrb => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.xxxw swizzling.
        /// </summary>
        public cvec4 xxxw => new cvec4(x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.rrra swizzling (equivalent to cvec4.xxxw).
        /// </summary>
        public cvec4 rrra => new cvec4(x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.xxy swizzling.
        /// </summary>
        public cvec3 xxy => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec4.rrg swizzling (equivalent to cvec4.xxy).
        /// </summary>
        public cvec3 rrg => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec4.xxyx swizzling.
        /// </summary>
        public cvec4 xxyx => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.rrgr swizzling (equivalent to cvec4.xxyx).
        /// </summary>
        public cvec4 rrgr => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.xxyy swizzling.
        /// </summary>
        public cvec4 xxyy => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.rrgg swizzling (equivalent to cvec4.xxyy).
        /// </summary>
        public cvec4 rrgg => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.xxyz swizzling.
        /// </summary>
        public cvec4 xxyz => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.rrgb swizzling (equivalent to cvec4.xxyz).
        /// </summary>
        public cvec4 rrgb => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.xxyw swizzling.
        /// </summary>
        public cvec4 xxyw => new cvec4(x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.rrga swizzling (equivalent to cvec4.xxyw).
        /// </summary>
        public cvec4 rrga => new cvec4(x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.xxz swizzling.
        /// </summary>
        public cvec3 xxz => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec4.rrb swizzling (equivalent to cvec4.xxz).
        /// </summary>
        public cvec3 rrb => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec4.xxzx swizzling.
        /// </summary>
        public cvec4 xxzx => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.rrbr swizzling (equivalent to cvec4.xxzx).
        /// </summary>
        public cvec4 rrbr => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.xxzy swizzling.
        /// </summary>
        public cvec4 xxzy => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.rrbg swizzling (equivalent to cvec4.xxzy).
        /// </summary>
        public cvec4 rrbg => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.xxzz swizzling.
        /// </summary>
        public cvec4 xxzz => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.rrbb swizzling (equivalent to cvec4.xxzz).
        /// </summary>
        public cvec4 rrbb => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.xxzw swizzling.
        /// </summary>
        public cvec4 xxzw => new cvec4(x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.rrba swizzling (equivalent to cvec4.xxzw).
        /// </summary>
        public cvec4 rrba => new cvec4(x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.xxw swizzling.
        /// </summary>
        public cvec3 xxw => new cvec3(x, x, w);
        
        /// <summary>
        /// Returns cvec4.rra swizzling (equivalent to cvec4.xxw).
        /// </summary>
        public cvec3 rra => new cvec3(x, x, w);
        
        /// <summary>
        /// Returns cvec4.xxwx swizzling.
        /// </summary>
        public cvec4 xxwx => new cvec4(x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.rrar swizzling (equivalent to cvec4.xxwx).
        /// </summary>
        public cvec4 rrar => new cvec4(x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.xxwy swizzling.
        /// </summary>
        public cvec4 xxwy => new cvec4(x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.rrag swizzling (equivalent to cvec4.xxwy).
        /// </summary>
        public cvec4 rrag => new cvec4(x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.xxwz swizzling.
        /// </summary>
        public cvec4 xxwz => new cvec4(x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.rrab swizzling (equivalent to cvec4.xxwz).
        /// </summary>
        public cvec4 rrab => new cvec4(x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.xxww swizzling.
        /// </summary>
        public cvec4 xxww => new cvec4(x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.rraa swizzling (equivalent to cvec4.xxww).
        /// </summary>
        public cvec4 rraa => new cvec4(x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.xy swizzling.
        /// </summary>
        public cvec2 xy => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec4.rg swizzling (equivalent to cvec4.xy).
        /// </summary>
        public cvec2 rg => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec4.xyx swizzling.
        /// </summary>
        public cvec3 xyx => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec4.rgr swizzling (equivalent to cvec4.xyx).
        /// </summary>
        public cvec3 rgr => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec4.xyxx swizzling.
        /// </summary>
        public cvec4 xyxx => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.rgrr swizzling (equivalent to cvec4.xyxx).
        /// </summary>
        public cvec4 rgrr => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.xyxy swizzling.
        /// </summary>
        public cvec4 xyxy => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.rgrg swizzling (equivalent to cvec4.xyxy).
        /// </summary>
        public cvec4 rgrg => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.xyxz swizzling.
        /// </summary>
        public cvec4 xyxz => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.rgrb swizzling (equivalent to cvec4.xyxz).
        /// </summary>
        public cvec4 rgrb => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.xyxw swizzling.
        /// </summary>
        public cvec4 xyxw => new cvec4(x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.rgra swizzling (equivalent to cvec4.xyxw).
        /// </summary>
        public cvec4 rgra => new cvec4(x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.xyy swizzling.
        /// </summary>
        public cvec3 xyy => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec4.rgg swizzling (equivalent to cvec4.xyy).
        /// </summary>
        public cvec3 rgg => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec4.xyyx swizzling.
        /// </summary>
        public cvec4 xyyx => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.rggr swizzling (equivalent to cvec4.xyyx).
        /// </summary>
        public cvec4 rggr => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.xyyy swizzling.
        /// </summary>
        public cvec4 xyyy => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.rggg swizzling (equivalent to cvec4.xyyy).
        /// </summary>
        public cvec4 rggg => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.xyyz swizzling.
        /// </summary>
        public cvec4 xyyz => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.rggb swizzling (equivalent to cvec4.xyyz).
        /// </summary>
        public cvec4 rggb => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.xyyw swizzling.
        /// </summary>
        public cvec4 xyyw => new cvec4(x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.rgga swizzling (equivalent to cvec4.xyyw).
        /// </summary>
        public cvec4 rgga => new cvec4(x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.xyz swizzling.
        /// </summary>
        public cvec3 xyz => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec4.rgb swizzling (equivalent to cvec4.xyz).
        /// </summary>
        public cvec3 rgb => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec4.xyzx swizzling.
        /// </summary>
        public cvec4 xyzx => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.rgbr swizzling (equivalent to cvec4.xyzx).
        /// </summary>
        public cvec4 rgbr => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.xyzy swizzling.
        /// </summary>
        public cvec4 xyzy => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.rgbg swizzling (equivalent to cvec4.xyzy).
        /// </summary>
        public cvec4 rgbg => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.xyzz swizzling.
        /// </summary>
        public cvec4 xyzz => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.rgbb swizzling (equivalent to cvec4.xyzz).
        /// </summary>
        public cvec4 rgbb => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.xyzw swizzling.
        /// </summary>
        public cvec4 xyzw => new cvec4(x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.rgba swizzling (equivalent to cvec4.xyzw).
        /// </summary>
        public cvec4 rgba => new cvec4(x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.xyw swizzling.
        /// </summary>
        public cvec3 xyw => new cvec3(x, y, w);
        
        /// <summary>
        /// Returns cvec4.rga swizzling (equivalent to cvec4.xyw).
        /// </summary>
        public cvec3 rga => new cvec3(x, y, w);
        
        /// <summary>
        /// Returns cvec4.xywx swizzling.
        /// </summary>
        public cvec4 xywx => new cvec4(x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.rgar swizzling (equivalent to cvec4.xywx).
        /// </summary>
        public cvec4 rgar => new cvec4(x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.xywy swizzling.
        /// </summary>
        public cvec4 xywy => new cvec4(x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.rgag swizzling (equivalent to cvec4.xywy).
        /// </summary>
        public cvec4 rgag => new cvec4(x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.xywz swizzling.
        /// </summary>
        public cvec4 xywz => new cvec4(x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.rgab swizzling (equivalent to cvec4.xywz).
        /// </summary>
        public cvec4 rgab => new cvec4(x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.xyww swizzling.
        /// </summary>
        public cvec4 xyww => new cvec4(x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.rgaa swizzling (equivalent to cvec4.xyww).
        /// </summary>
        public cvec4 rgaa => new cvec4(x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.xz swizzling.
        /// </summary>
        public cvec2 xz => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec4.rb swizzling (equivalent to cvec4.xz).
        /// </summary>
        public cvec2 rb => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec4.xzx swizzling.
        /// </summary>
        public cvec3 xzx => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec4.rbr swizzling (equivalent to cvec4.xzx).
        /// </summary>
        public cvec3 rbr => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec4.xzxx swizzling.
        /// </summary>
        public cvec4 xzxx => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.rbrr swizzling (equivalent to cvec4.xzxx).
        /// </summary>
        public cvec4 rbrr => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.xzxy swizzling.
        /// </summary>
        public cvec4 xzxy => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.rbrg swizzling (equivalent to cvec4.xzxy).
        /// </summary>
        public cvec4 rbrg => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.xzxz swizzling.
        /// </summary>
        public cvec4 xzxz => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.rbrb swizzling (equivalent to cvec4.xzxz).
        /// </summary>
        public cvec4 rbrb => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.xzxw swizzling.
        /// </summary>
        public cvec4 xzxw => new cvec4(x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.rbra swizzling (equivalent to cvec4.xzxw).
        /// </summary>
        public cvec4 rbra => new cvec4(x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.xzy swizzling.
        /// </summary>
        public cvec3 xzy => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec4.rbg swizzling (equivalent to cvec4.xzy).
        /// </summary>
        public cvec3 rbg => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec4.xzyx swizzling.
        /// </summary>
        public cvec4 xzyx => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.rbgr swizzling (equivalent to cvec4.xzyx).
        /// </summary>
        public cvec4 rbgr => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.xzyy swizzling.
        /// </summary>
        public cvec4 xzyy => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.rbgg swizzling (equivalent to cvec4.xzyy).
        /// </summary>
        public cvec4 rbgg => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.xzyz swizzling.
        /// </summary>
        public cvec4 xzyz => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.rbgb swizzling (equivalent to cvec4.xzyz).
        /// </summary>
        public cvec4 rbgb => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.xzyw swizzling.
        /// </summary>
        public cvec4 xzyw => new cvec4(x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.rbga swizzling (equivalent to cvec4.xzyw).
        /// </summary>
        public cvec4 rbga => new cvec4(x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.xzz swizzling.
        /// </summary>
        public cvec3 xzz => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec4.rbb swizzling (equivalent to cvec4.xzz).
        /// </summary>
        public cvec3 rbb => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec4.xzzx swizzling.
        /// </summary>
        public cvec4 xzzx => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.rbbr swizzling (equivalent to cvec4.xzzx).
        /// </summary>
        public cvec4 rbbr => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.xzzy swizzling.
        /// </summary>
        public cvec4 xzzy => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.rbbg swizzling (equivalent to cvec4.xzzy).
        /// </summary>
        public cvec4 rbbg => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.xzzz swizzling.
        /// </summary>
        public cvec4 xzzz => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.rbbb swizzling (equivalent to cvec4.xzzz).
        /// </summary>
        public cvec4 rbbb => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.xzzw swizzling.
        /// </summary>
        public cvec4 xzzw => new cvec4(x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.rbba swizzling (equivalent to cvec4.xzzw).
        /// </summary>
        public cvec4 rbba => new cvec4(x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.xzw swizzling.
        /// </summary>
        public cvec3 xzw => new cvec3(x, z, w);
        
        /// <summary>
        /// Returns cvec4.rba swizzling (equivalent to cvec4.xzw).
        /// </summary>
        public cvec3 rba => new cvec3(x, z, w);
        
        /// <summary>
        /// Returns cvec4.xzwx swizzling.
        /// </summary>
        public cvec4 xzwx => new cvec4(x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.rbar swizzling (equivalent to cvec4.xzwx).
        /// </summary>
        public cvec4 rbar => new cvec4(x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.xzwy swizzling.
        /// </summary>
        public cvec4 xzwy => new cvec4(x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.rbag swizzling (equivalent to cvec4.xzwy).
        /// </summary>
        public cvec4 rbag => new cvec4(x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.xzwz swizzling.
        /// </summary>
        public cvec4 xzwz => new cvec4(x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.rbab swizzling (equivalent to cvec4.xzwz).
        /// </summary>
        public cvec4 rbab => new cvec4(x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.xzww swizzling.
        /// </summary>
        public cvec4 xzww => new cvec4(x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.rbaa swizzling (equivalent to cvec4.xzww).
        /// </summary>
        public cvec4 rbaa => new cvec4(x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.xw swizzling.
        /// </summary>
        public cvec2 xw => new cvec2(x, w);
        
        /// <summary>
        /// Returns cvec4.ra swizzling (equivalent to cvec4.xw).
        /// </summary>
        public cvec2 ra => new cvec2(x, w);
        
        /// <summary>
        /// Returns cvec4.xwx swizzling.
        /// </summary>
        public cvec3 xwx => new cvec3(x, w, x);
        
        /// <summary>
        /// Returns cvec4.rar swizzling (equivalent to cvec4.xwx).
        /// </summary>
        public cvec3 rar => new cvec3(x, w, x);
        
        /// <summary>
        /// Returns cvec4.xwxx swizzling.
        /// </summary>
        public cvec4 xwxx => new cvec4(x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.rarr swizzling (equivalent to cvec4.xwxx).
        /// </summary>
        public cvec4 rarr => new cvec4(x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.xwxy swizzling.
        /// </summary>
        public cvec4 xwxy => new cvec4(x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.rarg swizzling (equivalent to cvec4.xwxy).
        /// </summary>
        public cvec4 rarg => new cvec4(x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.xwxz swizzling.
        /// </summary>
        public cvec4 xwxz => new cvec4(x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.rarb swizzling (equivalent to cvec4.xwxz).
        /// </summary>
        public cvec4 rarb => new cvec4(x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.xwxw swizzling.
        /// </summary>
        public cvec4 xwxw => new cvec4(x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.rara swizzling (equivalent to cvec4.xwxw).
        /// </summary>
        public cvec4 rara => new cvec4(x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.xwy swizzling.
        /// </summary>
        public cvec3 xwy => new cvec3(x, w, y);
        
        /// <summary>
        /// Returns cvec4.rag swizzling (equivalent to cvec4.xwy).
        /// </summary>
        public cvec3 rag => new cvec3(x, w, y);
        
        /// <summary>
        /// Returns cvec4.xwyx swizzling.
        /// </summary>
        public cvec4 xwyx => new cvec4(x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.ragr swizzling (equivalent to cvec4.xwyx).
        /// </summary>
        public cvec4 ragr => new cvec4(x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.xwyy swizzling.
        /// </summary>
        public cvec4 xwyy => new cvec4(x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.ragg swizzling (equivalent to cvec4.xwyy).
        /// </summary>
        public cvec4 ragg => new cvec4(x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.xwyz swizzling.
        /// </summary>
        public cvec4 xwyz => new cvec4(x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.ragb swizzling (equivalent to cvec4.xwyz).
        /// </summary>
        public cvec4 ragb => new cvec4(x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.xwyw swizzling.
        /// </summary>
        public cvec4 xwyw => new cvec4(x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.raga swizzling (equivalent to cvec4.xwyw).
        /// </summary>
        public cvec4 raga => new cvec4(x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.xwz swizzling.
        /// </summary>
        public cvec3 xwz => new cvec3(x, w, z);
        
        /// <summary>
        /// Returns cvec4.rab swizzling (equivalent to cvec4.xwz).
        /// </summary>
        public cvec3 rab => new cvec3(x, w, z);
        
        /// <summary>
        /// Returns cvec4.xwzx swizzling.
        /// </summary>
        public cvec4 xwzx => new cvec4(x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.rabr swizzling (equivalent to cvec4.xwzx).
        /// </summary>
        public cvec4 rabr => new cvec4(x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.xwzy swizzling.
        /// </summary>
        public cvec4 xwzy => new cvec4(x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.rabg swizzling (equivalent to cvec4.xwzy).
        /// </summary>
        public cvec4 rabg => new cvec4(x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.xwzz swizzling.
        /// </summary>
        public cvec4 xwzz => new cvec4(x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.rabb swizzling (equivalent to cvec4.xwzz).
        /// </summary>
        public cvec4 rabb => new cvec4(x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.xwzw swizzling.
        /// </summary>
        public cvec4 xwzw => new cvec4(x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.raba swizzling (equivalent to cvec4.xwzw).
        /// </summary>
        public cvec4 raba => new cvec4(x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.xww swizzling.
        /// </summary>
        public cvec3 xww => new cvec3(x, w, w);
        
        /// <summary>
        /// Returns cvec4.raa swizzling (equivalent to cvec4.xww).
        /// </summary>
        public cvec3 raa => new cvec3(x, w, w);
        
        /// <summary>
        /// Returns cvec4.xwwx swizzling.
        /// </summary>
        public cvec4 xwwx => new cvec4(x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.raar swizzling (equivalent to cvec4.xwwx).
        /// </summary>
        public cvec4 raar => new cvec4(x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.xwwy swizzling.
        /// </summary>
        public cvec4 xwwy => new cvec4(x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.raag swizzling (equivalent to cvec4.xwwy).
        /// </summary>
        public cvec4 raag => new cvec4(x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.xwwz swizzling.
        /// </summary>
        public cvec4 xwwz => new cvec4(x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.raab swizzling (equivalent to cvec4.xwwz).
        /// </summary>
        public cvec4 raab => new cvec4(x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.xwww swizzling.
        /// </summary>
        public cvec4 xwww => new cvec4(x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.raaa swizzling (equivalent to cvec4.xwww).
        /// </summary>
        public cvec4 raaa => new cvec4(x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.yx swizzling.
        /// </summary>
        public cvec2 yx => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec4.gr swizzling (equivalent to cvec4.yx).
        /// </summary>
        public cvec2 gr => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec4.yxx swizzling.
        /// </summary>
        public cvec3 yxx => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec4.grr swizzling (equivalent to cvec4.yxx).
        /// </summary>
        public cvec3 grr => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec4.yxxx swizzling.
        /// </summary>
        public cvec4 yxxx => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.grrr swizzling (equivalent to cvec4.yxxx).
        /// </summary>
        public cvec4 grrr => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.yxxy swizzling.
        /// </summary>
        public cvec4 yxxy => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.grrg swizzling (equivalent to cvec4.yxxy).
        /// </summary>
        public cvec4 grrg => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.yxxz swizzling.
        /// </summary>
        public cvec4 yxxz => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.grrb swizzling (equivalent to cvec4.yxxz).
        /// </summary>
        public cvec4 grrb => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.yxxw swizzling.
        /// </summary>
        public cvec4 yxxw => new cvec4(y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.grra swizzling (equivalent to cvec4.yxxw).
        /// </summary>
        public cvec4 grra => new cvec4(y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.yxy swizzling.
        /// </summary>
        public cvec3 yxy => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec4.grg swizzling (equivalent to cvec4.yxy).
        /// </summary>
        public cvec3 grg => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec4.yxyx swizzling.
        /// </summary>
        public cvec4 yxyx => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.grgr swizzling (equivalent to cvec4.yxyx).
        /// </summary>
        public cvec4 grgr => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.yxyy swizzling.
        /// </summary>
        public cvec4 yxyy => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.grgg swizzling (equivalent to cvec4.yxyy).
        /// </summary>
        public cvec4 grgg => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.yxyz swizzling.
        /// </summary>
        public cvec4 yxyz => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.grgb swizzling (equivalent to cvec4.yxyz).
        /// </summary>
        public cvec4 grgb => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.yxyw swizzling.
        /// </summary>
        public cvec4 yxyw => new cvec4(y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.grga swizzling (equivalent to cvec4.yxyw).
        /// </summary>
        public cvec4 grga => new cvec4(y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.yxz swizzling.
        /// </summary>
        public cvec3 yxz => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec4.grb swizzling (equivalent to cvec4.yxz).
        /// </summary>
        public cvec3 grb => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec4.yxzx swizzling.
        /// </summary>
        public cvec4 yxzx => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.grbr swizzling (equivalent to cvec4.yxzx).
        /// </summary>
        public cvec4 grbr => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.yxzy swizzling.
        /// </summary>
        public cvec4 yxzy => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.grbg swizzling (equivalent to cvec4.yxzy).
        /// </summary>
        public cvec4 grbg => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.yxzz swizzling.
        /// </summary>
        public cvec4 yxzz => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.grbb swizzling (equivalent to cvec4.yxzz).
        /// </summary>
        public cvec4 grbb => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.yxzw swizzling.
        /// </summary>
        public cvec4 yxzw => new cvec4(y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.grba swizzling (equivalent to cvec4.yxzw).
        /// </summary>
        public cvec4 grba => new cvec4(y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.yxw swizzling.
        /// </summary>
        public cvec3 yxw => new cvec3(y, x, w);
        
        /// <summary>
        /// Returns cvec4.gra swizzling (equivalent to cvec4.yxw).
        /// </summary>
        public cvec3 gra => new cvec3(y, x, w);
        
        /// <summary>
        /// Returns cvec4.yxwx swizzling.
        /// </summary>
        public cvec4 yxwx => new cvec4(y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.grar swizzling (equivalent to cvec4.yxwx).
        /// </summary>
        public cvec4 grar => new cvec4(y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.yxwy swizzling.
        /// </summary>
        public cvec4 yxwy => new cvec4(y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.grag swizzling (equivalent to cvec4.yxwy).
        /// </summary>
        public cvec4 grag => new cvec4(y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.yxwz swizzling.
        /// </summary>
        public cvec4 yxwz => new cvec4(y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.grab swizzling (equivalent to cvec4.yxwz).
        /// </summary>
        public cvec4 grab => new cvec4(y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.yxww swizzling.
        /// </summary>
        public cvec4 yxww => new cvec4(y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.graa swizzling (equivalent to cvec4.yxww).
        /// </summary>
        public cvec4 graa => new cvec4(y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.yy swizzling.
        /// </summary>
        public cvec2 yy => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec4.gg swizzling (equivalent to cvec4.yy).
        /// </summary>
        public cvec2 gg => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec4.yyx swizzling.
        /// </summary>
        public cvec3 yyx => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec4.ggr swizzling (equivalent to cvec4.yyx).
        /// </summary>
        public cvec3 ggr => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec4.yyxx swizzling.
        /// </summary>
        public cvec4 yyxx => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.ggrr swizzling (equivalent to cvec4.yyxx).
        /// </summary>
        public cvec4 ggrr => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.yyxy swizzling.
        /// </summary>
        public cvec4 yyxy => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.ggrg swizzling (equivalent to cvec4.yyxy).
        /// </summary>
        public cvec4 ggrg => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.yyxz swizzling.
        /// </summary>
        public cvec4 yyxz => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.ggrb swizzling (equivalent to cvec4.yyxz).
        /// </summary>
        public cvec4 ggrb => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.yyxw swizzling.
        /// </summary>
        public cvec4 yyxw => new cvec4(y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.ggra swizzling (equivalent to cvec4.yyxw).
        /// </summary>
        public cvec4 ggra => new cvec4(y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.yyy swizzling.
        /// </summary>
        public cvec3 yyy => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec4.ggg swizzling (equivalent to cvec4.yyy).
        /// </summary>
        public cvec3 ggg => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec4.yyyx swizzling.
        /// </summary>
        public cvec4 yyyx => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.gggr swizzling (equivalent to cvec4.yyyx).
        /// </summary>
        public cvec4 gggr => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.yyyy swizzling.
        /// </summary>
        public cvec4 yyyy => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.gggg swizzling (equivalent to cvec4.yyyy).
        /// </summary>
        public cvec4 gggg => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.yyyz swizzling.
        /// </summary>
        public cvec4 yyyz => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.gggb swizzling (equivalent to cvec4.yyyz).
        /// </summary>
        public cvec4 gggb => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.yyyw swizzling.
        /// </summary>
        public cvec4 yyyw => new cvec4(y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.ggga swizzling (equivalent to cvec4.yyyw).
        /// </summary>
        public cvec4 ggga => new cvec4(y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.yyz swizzling.
        /// </summary>
        public cvec3 yyz => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec4.ggb swizzling (equivalent to cvec4.yyz).
        /// </summary>
        public cvec3 ggb => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec4.yyzx swizzling.
        /// </summary>
        public cvec4 yyzx => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.ggbr swizzling (equivalent to cvec4.yyzx).
        /// </summary>
        public cvec4 ggbr => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.yyzy swizzling.
        /// </summary>
        public cvec4 yyzy => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.ggbg swizzling (equivalent to cvec4.yyzy).
        /// </summary>
        public cvec4 ggbg => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.yyzz swizzling.
        /// </summary>
        public cvec4 yyzz => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.ggbb swizzling (equivalent to cvec4.yyzz).
        /// </summary>
        public cvec4 ggbb => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.yyzw swizzling.
        /// </summary>
        public cvec4 yyzw => new cvec4(y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.ggba swizzling (equivalent to cvec4.yyzw).
        /// </summary>
        public cvec4 ggba => new cvec4(y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.yyw swizzling.
        /// </summary>
        public cvec3 yyw => new cvec3(y, y, w);
        
        /// <summary>
        /// Returns cvec4.gga swizzling (equivalent to cvec4.yyw).
        /// </summary>
        public cvec3 gga => new cvec3(y, y, w);
        
        /// <summary>
        /// Returns cvec4.yywx swizzling.
        /// </summary>
        public cvec4 yywx => new cvec4(y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.ggar swizzling (equivalent to cvec4.yywx).
        /// </summary>
        public cvec4 ggar => new cvec4(y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.yywy swizzling.
        /// </summary>
        public cvec4 yywy => new cvec4(y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.ggag swizzling (equivalent to cvec4.yywy).
        /// </summary>
        public cvec4 ggag => new cvec4(y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.yywz swizzling.
        /// </summary>
        public cvec4 yywz => new cvec4(y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.ggab swizzling (equivalent to cvec4.yywz).
        /// </summary>
        public cvec4 ggab => new cvec4(y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.yyww swizzling.
        /// </summary>
        public cvec4 yyww => new cvec4(y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.ggaa swizzling (equivalent to cvec4.yyww).
        /// </summary>
        public cvec4 ggaa => new cvec4(y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.yz swizzling.
        /// </summary>
        public cvec2 yz => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec4.gb swizzling (equivalent to cvec4.yz).
        /// </summary>
        public cvec2 gb => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec4.yzx swizzling.
        /// </summary>
        public cvec3 yzx => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec4.gbr swizzling (equivalent to cvec4.yzx).
        /// </summary>
        public cvec3 gbr => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec4.yzxx swizzling.
        /// </summary>
        public cvec4 yzxx => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.gbrr swizzling (equivalent to cvec4.yzxx).
        /// </summary>
        public cvec4 gbrr => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.yzxy swizzling.
        /// </summary>
        public cvec4 yzxy => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.gbrg swizzling (equivalent to cvec4.yzxy).
        /// </summary>
        public cvec4 gbrg => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.yzxz swizzling.
        /// </summary>
        public cvec4 yzxz => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.gbrb swizzling (equivalent to cvec4.yzxz).
        /// </summary>
        public cvec4 gbrb => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.yzxw swizzling.
        /// </summary>
        public cvec4 yzxw => new cvec4(y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.gbra swizzling (equivalent to cvec4.yzxw).
        /// </summary>
        public cvec4 gbra => new cvec4(y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.yzy swizzling.
        /// </summary>
        public cvec3 yzy => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec4.gbg swizzling (equivalent to cvec4.yzy).
        /// </summary>
        public cvec3 gbg => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec4.yzyx swizzling.
        /// </summary>
        public cvec4 yzyx => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.gbgr swizzling (equivalent to cvec4.yzyx).
        /// </summary>
        public cvec4 gbgr => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.yzyy swizzling.
        /// </summary>
        public cvec4 yzyy => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.gbgg swizzling (equivalent to cvec4.yzyy).
        /// </summary>
        public cvec4 gbgg => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.yzyz swizzling.
        /// </summary>
        public cvec4 yzyz => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.gbgb swizzling (equivalent to cvec4.yzyz).
        /// </summary>
        public cvec4 gbgb => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.yzyw swizzling.
        /// </summary>
        public cvec4 yzyw => new cvec4(y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.gbga swizzling (equivalent to cvec4.yzyw).
        /// </summary>
        public cvec4 gbga => new cvec4(y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.yzz swizzling.
        /// </summary>
        public cvec3 yzz => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec4.gbb swizzling (equivalent to cvec4.yzz).
        /// </summary>
        public cvec3 gbb => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec4.yzzx swizzling.
        /// </summary>
        public cvec4 yzzx => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.gbbr swizzling (equivalent to cvec4.yzzx).
        /// </summary>
        public cvec4 gbbr => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.yzzy swizzling.
        /// </summary>
        public cvec4 yzzy => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.gbbg swizzling (equivalent to cvec4.yzzy).
        /// </summary>
        public cvec4 gbbg => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.yzzz swizzling.
        /// </summary>
        public cvec4 yzzz => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.gbbb swizzling (equivalent to cvec4.yzzz).
        /// </summary>
        public cvec4 gbbb => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.yzzw swizzling.
        /// </summary>
        public cvec4 yzzw => new cvec4(y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.gbba swizzling (equivalent to cvec4.yzzw).
        /// </summary>
        public cvec4 gbba => new cvec4(y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.yzw swizzling.
        /// </summary>
        public cvec3 yzw => new cvec3(y, z, w);
        
        /// <summary>
        /// Returns cvec4.gba swizzling (equivalent to cvec4.yzw).
        /// </summary>
        public cvec3 gba => new cvec3(y, z, w);
        
        /// <summary>
        /// Returns cvec4.yzwx swizzling.
        /// </summary>
        public cvec4 yzwx => new cvec4(y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.gbar swizzling (equivalent to cvec4.yzwx).
        /// </summary>
        public cvec4 gbar => new cvec4(y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.yzwy swizzling.
        /// </summary>
        public cvec4 yzwy => new cvec4(y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.gbag swizzling (equivalent to cvec4.yzwy).
        /// </summary>
        public cvec4 gbag => new cvec4(y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.yzwz swizzling.
        /// </summary>
        public cvec4 yzwz => new cvec4(y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.gbab swizzling (equivalent to cvec4.yzwz).
        /// </summary>
        public cvec4 gbab => new cvec4(y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.yzww swizzling.
        /// </summary>
        public cvec4 yzww => new cvec4(y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.gbaa swizzling (equivalent to cvec4.yzww).
        /// </summary>
        public cvec4 gbaa => new cvec4(y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.yw swizzling.
        /// </summary>
        public cvec2 yw => new cvec2(y, w);
        
        /// <summary>
        /// Returns cvec4.ga swizzling (equivalent to cvec4.yw).
        /// </summary>
        public cvec2 ga => new cvec2(y, w);
        
        /// <summary>
        /// Returns cvec4.ywx swizzling.
        /// </summary>
        public cvec3 ywx => new cvec3(y, w, x);
        
        /// <summary>
        /// Returns cvec4.gar swizzling (equivalent to cvec4.ywx).
        /// </summary>
        public cvec3 gar => new cvec3(y, w, x);
        
        /// <summary>
        /// Returns cvec4.ywxx swizzling.
        /// </summary>
        public cvec4 ywxx => new cvec4(y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.garr swizzling (equivalent to cvec4.ywxx).
        /// </summary>
        public cvec4 garr => new cvec4(y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.ywxy swizzling.
        /// </summary>
        public cvec4 ywxy => new cvec4(y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.garg swizzling (equivalent to cvec4.ywxy).
        /// </summary>
        public cvec4 garg => new cvec4(y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.ywxz swizzling.
        /// </summary>
        public cvec4 ywxz => new cvec4(y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.garb swizzling (equivalent to cvec4.ywxz).
        /// </summary>
        public cvec4 garb => new cvec4(y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.ywxw swizzling.
        /// </summary>
        public cvec4 ywxw => new cvec4(y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.gara swizzling (equivalent to cvec4.ywxw).
        /// </summary>
        public cvec4 gara => new cvec4(y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.ywy swizzling.
        /// </summary>
        public cvec3 ywy => new cvec3(y, w, y);
        
        /// <summary>
        /// Returns cvec4.gag swizzling (equivalent to cvec4.ywy).
        /// </summary>
        public cvec3 gag => new cvec3(y, w, y);
        
        /// <summary>
        /// Returns cvec4.ywyx swizzling.
        /// </summary>
        public cvec4 ywyx => new cvec4(y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.gagr swizzling (equivalent to cvec4.ywyx).
        /// </summary>
        public cvec4 gagr => new cvec4(y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.ywyy swizzling.
        /// </summary>
        public cvec4 ywyy => new cvec4(y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.gagg swizzling (equivalent to cvec4.ywyy).
        /// </summary>
        public cvec4 gagg => new cvec4(y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.ywyz swizzling.
        /// </summary>
        public cvec4 ywyz => new cvec4(y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.gagb swizzling (equivalent to cvec4.ywyz).
        /// </summary>
        public cvec4 gagb => new cvec4(y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.ywyw swizzling.
        /// </summary>
        public cvec4 ywyw => new cvec4(y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.gaga swizzling (equivalent to cvec4.ywyw).
        /// </summary>
        public cvec4 gaga => new cvec4(y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.ywz swizzling.
        /// </summary>
        public cvec3 ywz => new cvec3(y, w, z);
        
        /// <summary>
        /// Returns cvec4.gab swizzling (equivalent to cvec4.ywz).
        /// </summary>
        public cvec3 gab => new cvec3(y, w, z);
        
        /// <summary>
        /// Returns cvec4.ywzx swizzling.
        /// </summary>
        public cvec4 ywzx => new cvec4(y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.gabr swizzling (equivalent to cvec4.ywzx).
        /// </summary>
        public cvec4 gabr => new cvec4(y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.ywzy swizzling.
        /// </summary>
        public cvec4 ywzy => new cvec4(y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.gabg swizzling (equivalent to cvec4.ywzy).
        /// </summary>
        public cvec4 gabg => new cvec4(y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.ywzz swizzling.
        /// </summary>
        public cvec4 ywzz => new cvec4(y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.gabb swizzling (equivalent to cvec4.ywzz).
        /// </summary>
        public cvec4 gabb => new cvec4(y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.ywzw swizzling.
        /// </summary>
        public cvec4 ywzw => new cvec4(y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.gaba swizzling (equivalent to cvec4.ywzw).
        /// </summary>
        public cvec4 gaba => new cvec4(y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.yww swizzling.
        /// </summary>
        public cvec3 yww => new cvec3(y, w, w);
        
        /// <summary>
        /// Returns cvec4.gaa swizzling (equivalent to cvec4.yww).
        /// </summary>
        public cvec3 gaa => new cvec3(y, w, w);
        
        /// <summary>
        /// Returns cvec4.ywwx swizzling.
        /// </summary>
        public cvec4 ywwx => new cvec4(y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.gaar swizzling (equivalent to cvec4.ywwx).
        /// </summary>
        public cvec4 gaar => new cvec4(y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.ywwy swizzling.
        /// </summary>
        public cvec4 ywwy => new cvec4(y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.gaag swizzling (equivalent to cvec4.ywwy).
        /// </summary>
        public cvec4 gaag => new cvec4(y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.ywwz swizzling.
        /// </summary>
        public cvec4 ywwz => new cvec4(y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.gaab swizzling (equivalent to cvec4.ywwz).
        /// </summary>
        public cvec4 gaab => new cvec4(y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.ywww swizzling.
        /// </summary>
        public cvec4 ywww => new cvec4(y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.gaaa swizzling (equivalent to cvec4.ywww).
        /// </summary>
        public cvec4 gaaa => new cvec4(y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.zx swizzling.
        /// </summary>
        public cvec2 zx => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec4.br swizzling (equivalent to cvec4.zx).
        /// </summary>
        public cvec2 br => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec4.zxx swizzling.
        /// </summary>
        public cvec3 zxx => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec4.brr swizzling (equivalent to cvec4.zxx).
        /// </summary>
        public cvec3 brr => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec4.zxxx swizzling.
        /// </summary>
        public cvec4 zxxx => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.brrr swizzling (equivalent to cvec4.zxxx).
        /// </summary>
        public cvec4 brrr => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.zxxy swizzling.
        /// </summary>
        public cvec4 zxxy => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.brrg swizzling (equivalent to cvec4.zxxy).
        /// </summary>
        public cvec4 brrg => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.zxxz swizzling.
        /// </summary>
        public cvec4 zxxz => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.brrb swizzling (equivalent to cvec4.zxxz).
        /// </summary>
        public cvec4 brrb => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.zxxw swizzling.
        /// </summary>
        public cvec4 zxxw => new cvec4(z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.brra swizzling (equivalent to cvec4.zxxw).
        /// </summary>
        public cvec4 brra => new cvec4(z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.zxy swizzling.
        /// </summary>
        public cvec3 zxy => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec4.brg swizzling (equivalent to cvec4.zxy).
        /// </summary>
        public cvec3 brg => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec4.zxyx swizzling.
        /// </summary>
        public cvec4 zxyx => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.brgr swizzling (equivalent to cvec4.zxyx).
        /// </summary>
        public cvec4 brgr => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.zxyy swizzling.
        /// </summary>
        public cvec4 zxyy => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.brgg swizzling (equivalent to cvec4.zxyy).
        /// </summary>
        public cvec4 brgg => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.zxyz swizzling.
        /// </summary>
        public cvec4 zxyz => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.brgb swizzling (equivalent to cvec4.zxyz).
        /// </summary>
        public cvec4 brgb => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.zxyw swizzling.
        /// </summary>
        public cvec4 zxyw => new cvec4(z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.brga swizzling (equivalent to cvec4.zxyw).
        /// </summary>
        public cvec4 brga => new cvec4(z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.zxz swizzling.
        /// </summary>
        public cvec3 zxz => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec4.brb swizzling (equivalent to cvec4.zxz).
        /// </summary>
        public cvec3 brb => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec4.zxzx swizzling.
        /// </summary>
        public cvec4 zxzx => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.brbr swizzling (equivalent to cvec4.zxzx).
        /// </summary>
        public cvec4 brbr => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.zxzy swizzling.
        /// </summary>
        public cvec4 zxzy => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.brbg swizzling (equivalent to cvec4.zxzy).
        /// </summary>
        public cvec4 brbg => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.zxzz swizzling.
        /// </summary>
        public cvec4 zxzz => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.brbb swizzling (equivalent to cvec4.zxzz).
        /// </summary>
        public cvec4 brbb => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.zxzw swizzling.
        /// </summary>
        public cvec4 zxzw => new cvec4(z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.brba swizzling (equivalent to cvec4.zxzw).
        /// </summary>
        public cvec4 brba => new cvec4(z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.zxw swizzling.
        /// </summary>
        public cvec3 zxw => new cvec3(z, x, w);
        
        /// <summary>
        /// Returns cvec4.bra swizzling (equivalent to cvec4.zxw).
        /// </summary>
        public cvec3 bra => new cvec3(z, x, w);
        
        /// <summary>
        /// Returns cvec4.zxwx swizzling.
        /// </summary>
        public cvec4 zxwx => new cvec4(z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.brar swizzling (equivalent to cvec4.zxwx).
        /// </summary>
        public cvec4 brar => new cvec4(z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.zxwy swizzling.
        /// </summary>
        public cvec4 zxwy => new cvec4(z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.brag swizzling (equivalent to cvec4.zxwy).
        /// </summary>
        public cvec4 brag => new cvec4(z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.zxwz swizzling.
        /// </summary>
        public cvec4 zxwz => new cvec4(z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.brab swizzling (equivalent to cvec4.zxwz).
        /// </summary>
        public cvec4 brab => new cvec4(z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.zxww swizzling.
        /// </summary>
        public cvec4 zxww => new cvec4(z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.braa swizzling (equivalent to cvec4.zxww).
        /// </summary>
        public cvec4 braa => new cvec4(z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.zy swizzling.
        /// </summary>
        public cvec2 zy => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec4.bg swizzling (equivalent to cvec4.zy).
        /// </summary>
        public cvec2 bg => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec4.zyx swizzling.
        /// </summary>
        public cvec3 zyx => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec4.bgr swizzling (equivalent to cvec4.zyx).
        /// </summary>
        public cvec3 bgr => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec4.zyxx swizzling.
        /// </summary>
        public cvec4 zyxx => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.bgrr swizzling (equivalent to cvec4.zyxx).
        /// </summary>
        public cvec4 bgrr => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.zyxy swizzling.
        /// </summary>
        public cvec4 zyxy => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.bgrg swizzling (equivalent to cvec4.zyxy).
        /// </summary>
        public cvec4 bgrg => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.zyxz swizzling.
        /// </summary>
        public cvec4 zyxz => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.bgrb swizzling (equivalent to cvec4.zyxz).
        /// </summary>
        public cvec4 bgrb => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.zyxw swizzling.
        /// </summary>
        public cvec4 zyxw => new cvec4(z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.bgra swizzling (equivalent to cvec4.zyxw).
        /// </summary>
        public cvec4 bgra => new cvec4(z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.zyy swizzling.
        /// </summary>
        public cvec3 zyy => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec4.bgg swizzling (equivalent to cvec4.zyy).
        /// </summary>
        public cvec3 bgg => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec4.zyyx swizzling.
        /// </summary>
        public cvec4 zyyx => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.bggr swizzling (equivalent to cvec4.zyyx).
        /// </summary>
        public cvec4 bggr => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.zyyy swizzling.
        /// </summary>
        public cvec4 zyyy => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.bggg swizzling (equivalent to cvec4.zyyy).
        /// </summary>
        public cvec4 bggg => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.zyyz swizzling.
        /// </summary>
        public cvec4 zyyz => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.bggb swizzling (equivalent to cvec4.zyyz).
        /// </summary>
        public cvec4 bggb => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.zyyw swizzling.
        /// </summary>
        public cvec4 zyyw => new cvec4(z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.bgga swizzling (equivalent to cvec4.zyyw).
        /// </summary>
        public cvec4 bgga => new cvec4(z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.zyz swizzling.
        /// </summary>
        public cvec3 zyz => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec4.bgb swizzling (equivalent to cvec4.zyz).
        /// </summary>
        public cvec3 bgb => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec4.zyzx swizzling.
        /// </summary>
        public cvec4 zyzx => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.bgbr swizzling (equivalent to cvec4.zyzx).
        /// </summary>
        public cvec4 bgbr => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.zyzy swizzling.
        /// </summary>
        public cvec4 zyzy => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.bgbg swizzling (equivalent to cvec4.zyzy).
        /// </summary>
        public cvec4 bgbg => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.zyzz swizzling.
        /// </summary>
        public cvec4 zyzz => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.bgbb swizzling (equivalent to cvec4.zyzz).
        /// </summary>
        public cvec4 bgbb => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.zyzw swizzling.
        /// </summary>
        public cvec4 zyzw => new cvec4(z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.bgba swizzling (equivalent to cvec4.zyzw).
        /// </summary>
        public cvec4 bgba => new cvec4(z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.zyw swizzling.
        /// </summary>
        public cvec3 zyw => new cvec3(z, y, w);
        
        /// <summary>
        /// Returns cvec4.bga swizzling (equivalent to cvec4.zyw).
        /// </summary>
        public cvec3 bga => new cvec3(z, y, w);
        
        /// <summary>
        /// Returns cvec4.zywx swizzling.
        /// </summary>
        public cvec4 zywx => new cvec4(z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.bgar swizzling (equivalent to cvec4.zywx).
        /// </summary>
        public cvec4 bgar => new cvec4(z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.zywy swizzling.
        /// </summary>
        public cvec4 zywy => new cvec4(z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.bgag swizzling (equivalent to cvec4.zywy).
        /// </summary>
        public cvec4 bgag => new cvec4(z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.zywz swizzling.
        /// </summary>
        public cvec4 zywz => new cvec4(z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.bgab swizzling (equivalent to cvec4.zywz).
        /// </summary>
        public cvec4 bgab => new cvec4(z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.zyww swizzling.
        /// </summary>
        public cvec4 zyww => new cvec4(z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.bgaa swizzling (equivalent to cvec4.zyww).
        /// </summary>
        public cvec4 bgaa => new cvec4(z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.zz swizzling.
        /// </summary>
        public cvec2 zz => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec4.bb swizzling (equivalent to cvec4.zz).
        /// </summary>
        public cvec2 bb => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec4.zzx swizzling.
        /// </summary>
        public cvec3 zzx => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec4.bbr swizzling (equivalent to cvec4.zzx).
        /// </summary>
        public cvec3 bbr => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec4.zzxx swizzling.
        /// </summary>
        public cvec4 zzxx => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.bbrr swizzling (equivalent to cvec4.zzxx).
        /// </summary>
        public cvec4 bbrr => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.zzxy swizzling.
        /// </summary>
        public cvec4 zzxy => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.bbrg swizzling (equivalent to cvec4.zzxy).
        /// </summary>
        public cvec4 bbrg => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.zzxz swizzling.
        /// </summary>
        public cvec4 zzxz => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.bbrb swizzling (equivalent to cvec4.zzxz).
        /// </summary>
        public cvec4 bbrb => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.zzxw swizzling.
        /// </summary>
        public cvec4 zzxw => new cvec4(z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.bbra swizzling (equivalent to cvec4.zzxw).
        /// </summary>
        public cvec4 bbra => new cvec4(z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.zzy swizzling.
        /// </summary>
        public cvec3 zzy => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec4.bbg swizzling (equivalent to cvec4.zzy).
        /// </summary>
        public cvec3 bbg => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec4.zzyx swizzling.
        /// </summary>
        public cvec4 zzyx => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.bbgr swizzling (equivalent to cvec4.zzyx).
        /// </summary>
        public cvec4 bbgr => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.zzyy swizzling.
        /// </summary>
        public cvec4 zzyy => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.bbgg swizzling (equivalent to cvec4.zzyy).
        /// </summary>
        public cvec4 bbgg => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.zzyz swizzling.
        /// </summary>
        public cvec4 zzyz => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.bbgb swizzling (equivalent to cvec4.zzyz).
        /// </summary>
        public cvec4 bbgb => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.zzyw swizzling.
        /// </summary>
        public cvec4 zzyw => new cvec4(z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.bbga swizzling (equivalent to cvec4.zzyw).
        /// </summary>
        public cvec4 bbga => new cvec4(z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.zzz swizzling.
        /// </summary>
        public cvec3 zzz => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec4.bbb swizzling (equivalent to cvec4.zzz).
        /// </summary>
        public cvec3 bbb => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec4.zzzx swizzling.
        /// </summary>
        public cvec4 zzzx => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.bbbr swizzling (equivalent to cvec4.zzzx).
        /// </summary>
        public cvec4 bbbr => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.zzzy swizzling.
        /// </summary>
        public cvec4 zzzy => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.bbbg swizzling (equivalent to cvec4.zzzy).
        /// </summary>
        public cvec4 bbbg => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.zzzz swizzling.
        /// </summary>
        public cvec4 zzzz => new cvec4(z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.bbbb swizzling (equivalent to cvec4.zzzz).
        /// </summary>
        public cvec4 bbbb => new cvec4(z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.zzzw swizzling.
        /// </summary>
        public cvec4 zzzw => new cvec4(z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.bbba swizzling (equivalent to cvec4.zzzw).
        /// </summary>
        public cvec4 bbba => new cvec4(z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.zzw swizzling.
        /// </summary>
        public cvec3 zzw => new cvec3(z, z, w);
        
        /// <summary>
        /// Returns cvec4.bba swizzling (equivalent to cvec4.zzw).
        /// </summary>
        public cvec3 bba => new cvec3(z, z, w);
        
        /// <summary>
        /// Returns cvec4.zzwx swizzling.
        /// </summary>
        public cvec4 zzwx => new cvec4(z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.bbar swizzling (equivalent to cvec4.zzwx).
        /// </summary>
        public cvec4 bbar => new cvec4(z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.zzwy swizzling.
        /// </summary>
        public cvec4 zzwy => new cvec4(z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.bbag swizzling (equivalent to cvec4.zzwy).
        /// </summary>
        public cvec4 bbag => new cvec4(z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.zzwz swizzling.
        /// </summary>
        public cvec4 zzwz => new cvec4(z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.bbab swizzling (equivalent to cvec4.zzwz).
        /// </summary>
        public cvec4 bbab => new cvec4(z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.zzww swizzling.
        /// </summary>
        public cvec4 zzww => new cvec4(z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.bbaa swizzling (equivalent to cvec4.zzww).
        /// </summary>
        public cvec4 bbaa => new cvec4(z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.zw swizzling.
        /// </summary>
        public cvec2 zw => new cvec2(z, w);
        
        /// <summary>
        /// Returns cvec4.ba swizzling (equivalent to cvec4.zw).
        /// </summary>
        public cvec2 ba => new cvec2(z, w);
        
        /// <summary>
        /// Returns cvec4.zwx swizzling.
        /// </summary>
        public cvec3 zwx => new cvec3(z, w, x);
        
        /// <summary>
        /// Returns cvec4.bar swizzling (equivalent to cvec4.zwx).
        /// </summary>
        public cvec3 bar => new cvec3(z, w, x);
        
        /// <summary>
        /// Returns cvec4.zwxx swizzling.
        /// </summary>
        public cvec4 zwxx => new cvec4(z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.barr swizzling (equivalent to cvec4.zwxx).
        /// </summary>
        public cvec4 barr => new cvec4(z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.zwxy swizzling.
        /// </summary>
        public cvec4 zwxy => new cvec4(z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.barg swizzling (equivalent to cvec4.zwxy).
        /// </summary>
        public cvec4 barg => new cvec4(z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.zwxz swizzling.
        /// </summary>
        public cvec4 zwxz => new cvec4(z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.barb swizzling (equivalent to cvec4.zwxz).
        /// </summary>
        public cvec4 barb => new cvec4(z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.zwxw swizzling.
        /// </summary>
        public cvec4 zwxw => new cvec4(z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.bara swizzling (equivalent to cvec4.zwxw).
        /// </summary>
        public cvec4 bara => new cvec4(z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.zwy swizzling.
        /// </summary>
        public cvec3 zwy => new cvec3(z, w, y);
        
        /// <summary>
        /// Returns cvec4.bag swizzling (equivalent to cvec4.zwy).
        /// </summary>
        public cvec3 bag => new cvec3(z, w, y);
        
        /// <summary>
        /// Returns cvec4.zwyx swizzling.
        /// </summary>
        public cvec4 zwyx => new cvec4(z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.bagr swizzling (equivalent to cvec4.zwyx).
        /// </summary>
        public cvec4 bagr => new cvec4(z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.zwyy swizzling.
        /// </summary>
        public cvec4 zwyy => new cvec4(z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.bagg swizzling (equivalent to cvec4.zwyy).
        /// </summary>
        public cvec4 bagg => new cvec4(z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.zwyz swizzling.
        /// </summary>
        public cvec4 zwyz => new cvec4(z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.bagb swizzling (equivalent to cvec4.zwyz).
        /// </summary>
        public cvec4 bagb => new cvec4(z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.zwyw swizzling.
        /// </summary>
        public cvec4 zwyw => new cvec4(z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.baga swizzling (equivalent to cvec4.zwyw).
        /// </summary>
        public cvec4 baga => new cvec4(z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.zwz swizzling.
        /// </summary>
        public cvec3 zwz => new cvec3(z, w, z);
        
        /// <summary>
        /// Returns cvec4.bab swizzling (equivalent to cvec4.zwz).
        /// </summary>
        public cvec3 bab => new cvec3(z, w, z);
        
        /// <summary>
        /// Returns cvec4.zwzx swizzling.
        /// </summary>
        public cvec4 zwzx => new cvec4(z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.babr swizzling (equivalent to cvec4.zwzx).
        /// </summary>
        public cvec4 babr => new cvec4(z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.zwzy swizzling.
        /// </summary>
        public cvec4 zwzy => new cvec4(z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.babg swizzling (equivalent to cvec4.zwzy).
        /// </summary>
        public cvec4 babg => new cvec4(z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.zwzz swizzling.
        /// </summary>
        public cvec4 zwzz => new cvec4(z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.babb swizzling (equivalent to cvec4.zwzz).
        /// </summary>
        public cvec4 babb => new cvec4(z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.zwzw swizzling.
        /// </summary>
        public cvec4 zwzw => new cvec4(z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.baba swizzling (equivalent to cvec4.zwzw).
        /// </summary>
        public cvec4 baba => new cvec4(z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.zww swizzling.
        /// </summary>
        public cvec3 zww => new cvec3(z, w, w);
        
        /// <summary>
        /// Returns cvec4.baa swizzling (equivalent to cvec4.zww).
        /// </summary>
        public cvec3 baa => new cvec3(z, w, w);
        
        /// <summary>
        /// Returns cvec4.zwwx swizzling.
        /// </summary>
        public cvec4 zwwx => new cvec4(z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.baar swizzling (equivalent to cvec4.zwwx).
        /// </summary>
        public cvec4 baar => new cvec4(z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.zwwy swizzling.
        /// </summary>
        public cvec4 zwwy => new cvec4(z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.baag swizzling (equivalent to cvec4.zwwy).
        /// </summary>
        public cvec4 baag => new cvec4(z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.zwwz swizzling.
        /// </summary>
        public cvec4 zwwz => new cvec4(z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.baab swizzling (equivalent to cvec4.zwwz).
        /// </summary>
        public cvec4 baab => new cvec4(z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.zwww swizzling.
        /// </summary>
        public cvec4 zwww => new cvec4(z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.baaa swizzling (equivalent to cvec4.zwww).
        /// </summary>
        public cvec4 baaa => new cvec4(z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.wx swizzling.
        /// </summary>
        public cvec2 wx => new cvec2(w, x);
        
        /// <summary>
        /// Returns cvec4.ar swizzling (equivalent to cvec4.wx).
        /// </summary>
        public cvec2 ar => new cvec2(w, x);
        
        /// <summary>
        /// Returns cvec4.wxx swizzling.
        /// </summary>
        public cvec3 wxx => new cvec3(w, x, x);
        
        /// <summary>
        /// Returns cvec4.arr swizzling (equivalent to cvec4.wxx).
        /// </summary>
        public cvec3 arr => new cvec3(w, x, x);
        
        /// <summary>
        /// Returns cvec4.wxxx swizzling.
        /// </summary>
        public cvec4 wxxx => new cvec4(w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.arrr swizzling (equivalent to cvec4.wxxx).
        /// </summary>
        public cvec4 arrr => new cvec4(w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.wxxy swizzling.
        /// </summary>
        public cvec4 wxxy => new cvec4(w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.arrg swizzling (equivalent to cvec4.wxxy).
        /// </summary>
        public cvec4 arrg => new cvec4(w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.wxxz swizzling.
        /// </summary>
        public cvec4 wxxz => new cvec4(w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.arrb swizzling (equivalent to cvec4.wxxz).
        /// </summary>
        public cvec4 arrb => new cvec4(w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.wxxw swizzling.
        /// </summary>
        public cvec4 wxxw => new cvec4(w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.arra swizzling (equivalent to cvec4.wxxw).
        /// </summary>
        public cvec4 arra => new cvec4(w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.wxy swizzling.
        /// </summary>
        public cvec3 wxy => new cvec3(w, x, y);
        
        /// <summary>
        /// Returns cvec4.arg swizzling (equivalent to cvec4.wxy).
        /// </summary>
        public cvec3 arg => new cvec3(w, x, y);
        
        /// <summary>
        /// Returns cvec4.wxyx swizzling.
        /// </summary>
        public cvec4 wxyx => new cvec4(w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.argr swizzling (equivalent to cvec4.wxyx).
        /// </summary>
        public cvec4 argr => new cvec4(w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.wxyy swizzling.
        /// </summary>
        public cvec4 wxyy => new cvec4(w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.argg swizzling (equivalent to cvec4.wxyy).
        /// </summary>
        public cvec4 argg => new cvec4(w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.wxyz swizzling.
        /// </summary>
        public cvec4 wxyz => new cvec4(w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.argb swizzling (equivalent to cvec4.wxyz).
        /// </summary>
        public cvec4 argb => new cvec4(w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.wxyw swizzling.
        /// </summary>
        public cvec4 wxyw => new cvec4(w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.arga swizzling (equivalent to cvec4.wxyw).
        /// </summary>
        public cvec4 arga => new cvec4(w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.wxz swizzling.
        /// </summary>
        public cvec3 wxz => new cvec3(w, x, z);
        
        /// <summary>
        /// Returns cvec4.arb swizzling (equivalent to cvec4.wxz).
        /// </summary>
        public cvec3 arb => new cvec3(w, x, z);
        
        /// <summary>
        /// Returns cvec4.wxzx swizzling.
        /// </summary>
        public cvec4 wxzx => new cvec4(w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.arbr swizzling (equivalent to cvec4.wxzx).
        /// </summary>
        public cvec4 arbr => new cvec4(w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.wxzy swizzling.
        /// </summary>
        public cvec4 wxzy => new cvec4(w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.arbg swizzling (equivalent to cvec4.wxzy).
        /// </summary>
        public cvec4 arbg => new cvec4(w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.wxzz swizzling.
        /// </summary>
        public cvec4 wxzz => new cvec4(w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.arbb swizzling (equivalent to cvec4.wxzz).
        /// </summary>
        public cvec4 arbb => new cvec4(w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.wxzw swizzling.
        /// </summary>
        public cvec4 wxzw => new cvec4(w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.arba swizzling (equivalent to cvec4.wxzw).
        /// </summary>
        public cvec4 arba => new cvec4(w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.wxw swizzling.
        /// </summary>
        public cvec3 wxw => new cvec3(w, x, w);
        
        /// <summary>
        /// Returns cvec4.ara swizzling (equivalent to cvec4.wxw).
        /// </summary>
        public cvec3 ara => new cvec3(w, x, w);
        
        /// <summary>
        /// Returns cvec4.wxwx swizzling.
        /// </summary>
        public cvec4 wxwx => new cvec4(w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.arar swizzling (equivalent to cvec4.wxwx).
        /// </summary>
        public cvec4 arar => new cvec4(w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.wxwy swizzling.
        /// </summary>
        public cvec4 wxwy => new cvec4(w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.arag swizzling (equivalent to cvec4.wxwy).
        /// </summary>
        public cvec4 arag => new cvec4(w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.wxwz swizzling.
        /// </summary>
        public cvec4 wxwz => new cvec4(w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.arab swizzling (equivalent to cvec4.wxwz).
        /// </summary>
        public cvec4 arab => new cvec4(w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.wxww swizzling.
        /// </summary>
        public cvec4 wxww => new cvec4(w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.araa swizzling (equivalent to cvec4.wxww).
        /// </summary>
        public cvec4 araa => new cvec4(w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.wy swizzling.
        /// </summary>
        public cvec2 wy => new cvec2(w, y);
        
        /// <summary>
        /// Returns cvec4.ag swizzling (equivalent to cvec4.wy).
        /// </summary>
        public cvec2 ag => new cvec2(w, y);
        
        /// <summary>
        /// Returns cvec4.wyx swizzling.
        /// </summary>
        public cvec3 wyx => new cvec3(w, y, x);
        
        /// <summary>
        /// Returns cvec4.agr swizzling (equivalent to cvec4.wyx).
        /// </summary>
        public cvec3 agr => new cvec3(w, y, x);
        
        /// <summary>
        /// Returns cvec4.wyxx swizzling.
        /// </summary>
        public cvec4 wyxx => new cvec4(w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.agrr swizzling (equivalent to cvec4.wyxx).
        /// </summary>
        public cvec4 agrr => new cvec4(w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.wyxy swizzling.
        /// </summary>
        public cvec4 wyxy => new cvec4(w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.agrg swizzling (equivalent to cvec4.wyxy).
        /// </summary>
        public cvec4 agrg => new cvec4(w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.wyxz swizzling.
        /// </summary>
        public cvec4 wyxz => new cvec4(w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.agrb swizzling (equivalent to cvec4.wyxz).
        /// </summary>
        public cvec4 agrb => new cvec4(w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.wyxw swizzling.
        /// </summary>
        public cvec4 wyxw => new cvec4(w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.agra swizzling (equivalent to cvec4.wyxw).
        /// </summary>
        public cvec4 agra => new cvec4(w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.wyy swizzling.
        /// </summary>
        public cvec3 wyy => new cvec3(w, y, y);
        
        /// <summary>
        /// Returns cvec4.agg swizzling (equivalent to cvec4.wyy).
        /// </summary>
        public cvec3 agg => new cvec3(w, y, y);
        
        /// <summary>
        /// Returns cvec4.wyyx swizzling.
        /// </summary>
        public cvec4 wyyx => new cvec4(w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.aggr swizzling (equivalent to cvec4.wyyx).
        /// </summary>
        public cvec4 aggr => new cvec4(w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.wyyy swizzling.
        /// </summary>
        public cvec4 wyyy => new cvec4(w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.aggg swizzling (equivalent to cvec4.wyyy).
        /// </summary>
        public cvec4 aggg => new cvec4(w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.wyyz swizzling.
        /// </summary>
        public cvec4 wyyz => new cvec4(w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.aggb swizzling (equivalent to cvec4.wyyz).
        /// </summary>
        public cvec4 aggb => new cvec4(w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.wyyw swizzling.
        /// </summary>
        public cvec4 wyyw => new cvec4(w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.agga swizzling (equivalent to cvec4.wyyw).
        /// </summary>
        public cvec4 agga => new cvec4(w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.wyz swizzling.
        /// </summary>
        public cvec3 wyz => new cvec3(w, y, z);
        
        /// <summary>
        /// Returns cvec4.agb swizzling (equivalent to cvec4.wyz).
        /// </summary>
        public cvec3 agb => new cvec3(w, y, z);
        
        /// <summary>
        /// Returns cvec4.wyzx swizzling.
        /// </summary>
        public cvec4 wyzx => new cvec4(w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.agbr swizzling (equivalent to cvec4.wyzx).
        /// </summary>
        public cvec4 agbr => new cvec4(w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.wyzy swizzling.
        /// </summary>
        public cvec4 wyzy => new cvec4(w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.agbg swizzling (equivalent to cvec4.wyzy).
        /// </summary>
        public cvec4 agbg => new cvec4(w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.wyzz swizzling.
        /// </summary>
        public cvec4 wyzz => new cvec4(w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.agbb swizzling (equivalent to cvec4.wyzz).
        /// </summary>
        public cvec4 agbb => new cvec4(w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.wyzw swizzling.
        /// </summary>
        public cvec4 wyzw => new cvec4(w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.agba swizzling (equivalent to cvec4.wyzw).
        /// </summary>
        public cvec4 agba => new cvec4(w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.wyw swizzling.
        /// </summary>
        public cvec3 wyw => new cvec3(w, y, w);
        
        /// <summary>
        /// Returns cvec4.aga swizzling (equivalent to cvec4.wyw).
        /// </summary>
        public cvec3 aga => new cvec3(w, y, w);
        
        /// <summary>
        /// Returns cvec4.wywx swizzling.
        /// </summary>
        public cvec4 wywx => new cvec4(w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.agar swizzling (equivalent to cvec4.wywx).
        /// </summary>
        public cvec4 agar => new cvec4(w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.wywy swizzling.
        /// </summary>
        public cvec4 wywy => new cvec4(w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.agag swizzling (equivalent to cvec4.wywy).
        /// </summary>
        public cvec4 agag => new cvec4(w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.wywz swizzling.
        /// </summary>
        public cvec4 wywz => new cvec4(w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.agab swizzling (equivalent to cvec4.wywz).
        /// </summary>
        public cvec4 agab => new cvec4(w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.wyww swizzling.
        /// </summary>
        public cvec4 wyww => new cvec4(w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.agaa swizzling (equivalent to cvec4.wyww).
        /// </summary>
        public cvec4 agaa => new cvec4(w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.wz swizzling.
        /// </summary>
        public cvec2 wz => new cvec2(w, z);
        
        /// <summary>
        /// Returns cvec4.ab swizzling (equivalent to cvec4.wz).
        /// </summary>
        public cvec2 ab => new cvec2(w, z);
        
        /// <summary>
        /// Returns cvec4.wzx swizzling.
        /// </summary>
        public cvec3 wzx => new cvec3(w, z, x);
        
        /// <summary>
        /// Returns cvec4.abr swizzling (equivalent to cvec4.wzx).
        /// </summary>
        public cvec3 abr => new cvec3(w, z, x);
        
        /// <summary>
        /// Returns cvec4.wzxx swizzling.
        /// </summary>
        public cvec4 wzxx => new cvec4(w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.abrr swizzling (equivalent to cvec4.wzxx).
        /// </summary>
        public cvec4 abrr => new cvec4(w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.wzxy swizzling.
        /// </summary>
        public cvec4 wzxy => new cvec4(w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.abrg swizzling (equivalent to cvec4.wzxy).
        /// </summary>
        public cvec4 abrg => new cvec4(w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.wzxz swizzling.
        /// </summary>
        public cvec4 wzxz => new cvec4(w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.abrb swizzling (equivalent to cvec4.wzxz).
        /// </summary>
        public cvec4 abrb => new cvec4(w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.wzxw swizzling.
        /// </summary>
        public cvec4 wzxw => new cvec4(w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.abra swizzling (equivalent to cvec4.wzxw).
        /// </summary>
        public cvec4 abra => new cvec4(w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.wzy swizzling.
        /// </summary>
        public cvec3 wzy => new cvec3(w, z, y);
        
        /// <summary>
        /// Returns cvec4.abg swizzling (equivalent to cvec4.wzy).
        /// </summary>
        public cvec3 abg => new cvec3(w, z, y);
        
        /// <summary>
        /// Returns cvec4.wzyx swizzling.
        /// </summary>
        public cvec4 wzyx => new cvec4(w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.abgr swizzling (equivalent to cvec4.wzyx).
        /// </summary>
        public cvec4 abgr => new cvec4(w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.wzyy swizzling.
        /// </summary>
        public cvec4 wzyy => new cvec4(w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.abgg swizzling (equivalent to cvec4.wzyy).
        /// </summary>
        public cvec4 abgg => new cvec4(w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.wzyz swizzling.
        /// </summary>
        public cvec4 wzyz => new cvec4(w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.abgb swizzling (equivalent to cvec4.wzyz).
        /// </summary>
        public cvec4 abgb => new cvec4(w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.wzyw swizzling.
        /// </summary>
        public cvec4 wzyw => new cvec4(w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.abga swizzling (equivalent to cvec4.wzyw).
        /// </summary>
        public cvec4 abga => new cvec4(w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.wzz swizzling.
        /// </summary>
        public cvec3 wzz => new cvec3(w, z, z);
        
        /// <summary>
        /// Returns cvec4.abb swizzling (equivalent to cvec4.wzz).
        /// </summary>
        public cvec3 abb => new cvec3(w, z, z);
        
        /// <summary>
        /// Returns cvec4.wzzx swizzling.
        /// </summary>
        public cvec4 wzzx => new cvec4(w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.abbr swizzling (equivalent to cvec4.wzzx).
        /// </summary>
        public cvec4 abbr => new cvec4(w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.wzzy swizzling.
        /// </summary>
        public cvec4 wzzy => new cvec4(w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.abbg swizzling (equivalent to cvec4.wzzy).
        /// </summary>
        public cvec4 abbg => new cvec4(w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.wzzz swizzling.
        /// </summary>
        public cvec4 wzzz => new cvec4(w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.abbb swizzling (equivalent to cvec4.wzzz).
        /// </summary>
        public cvec4 abbb => new cvec4(w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.wzzw swizzling.
        /// </summary>
        public cvec4 wzzw => new cvec4(w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.abba swizzling (equivalent to cvec4.wzzw).
        /// </summary>
        public cvec4 abba => new cvec4(w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.wzw swizzling.
        /// </summary>
        public cvec3 wzw => new cvec3(w, z, w);
        
        /// <summary>
        /// Returns cvec4.aba swizzling (equivalent to cvec4.wzw).
        /// </summary>
        public cvec3 aba => new cvec3(w, z, w);
        
        /// <summary>
        /// Returns cvec4.wzwx swizzling.
        /// </summary>
        public cvec4 wzwx => new cvec4(w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.abar swizzling (equivalent to cvec4.wzwx).
        /// </summary>
        public cvec4 abar => new cvec4(w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.wzwy swizzling.
        /// </summary>
        public cvec4 wzwy => new cvec4(w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.abag swizzling (equivalent to cvec4.wzwy).
        /// </summary>
        public cvec4 abag => new cvec4(w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.wzwz swizzling.
        /// </summary>
        public cvec4 wzwz => new cvec4(w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.abab swizzling (equivalent to cvec4.wzwz).
        /// </summary>
        public cvec4 abab => new cvec4(w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.wzww swizzling.
        /// </summary>
        public cvec4 wzww => new cvec4(w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.abaa swizzling (equivalent to cvec4.wzww).
        /// </summary>
        public cvec4 abaa => new cvec4(w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.ww swizzling.
        /// </summary>
        public cvec2 ww => new cvec2(w, w);
        
        /// <summary>
        /// Returns cvec4.aa swizzling (equivalent to cvec4.ww).
        /// </summary>
        public cvec2 aa => new cvec2(w, w);
        
        /// <summary>
        /// Returns cvec4.wwx swizzling.
        /// </summary>
        public cvec3 wwx => new cvec3(w, w, x);
        
        /// <summary>
        /// Returns cvec4.aar swizzling (equivalent to cvec4.wwx).
        /// </summary>
        public cvec3 aar => new cvec3(w, w, x);
        
        /// <summary>
        /// Returns cvec4.wwxx swizzling.
        /// </summary>
        public cvec4 wwxx => new cvec4(w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.aarr swizzling (equivalent to cvec4.wwxx).
        /// </summary>
        public cvec4 aarr => new cvec4(w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.wwxy swizzling.
        /// </summary>
        public cvec4 wwxy => new cvec4(w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.aarg swizzling (equivalent to cvec4.wwxy).
        /// </summary>
        public cvec4 aarg => new cvec4(w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.wwxz swizzling.
        /// </summary>
        public cvec4 wwxz => new cvec4(w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.aarb swizzling (equivalent to cvec4.wwxz).
        /// </summary>
        public cvec4 aarb => new cvec4(w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.wwxw swizzling.
        /// </summary>
        public cvec4 wwxw => new cvec4(w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.aara swizzling (equivalent to cvec4.wwxw).
        /// </summary>
        public cvec4 aara => new cvec4(w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.wwy swizzling.
        /// </summary>
        public cvec3 wwy => new cvec3(w, w, y);
        
        /// <summary>
        /// Returns cvec4.aag swizzling (equivalent to cvec4.wwy).
        /// </summary>
        public cvec3 aag => new cvec3(w, w, y);
        
        /// <summary>
        /// Returns cvec4.wwyx swizzling.
        /// </summary>
        public cvec4 wwyx => new cvec4(w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.aagr swizzling (equivalent to cvec4.wwyx).
        /// </summary>
        public cvec4 aagr => new cvec4(w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.wwyy swizzling.
        /// </summary>
        public cvec4 wwyy => new cvec4(w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.aagg swizzling (equivalent to cvec4.wwyy).
        /// </summary>
        public cvec4 aagg => new cvec4(w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.wwyz swizzling.
        /// </summary>
        public cvec4 wwyz => new cvec4(w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.aagb swizzling (equivalent to cvec4.wwyz).
        /// </summary>
        public cvec4 aagb => new cvec4(w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.wwyw swizzling.
        /// </summary>
        public cvec4 wwyw => new cvec4(w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.aaga swizzling (equivalent to cvec4.wwyw).
        /// </summary>
        public cvec4 aaga => new cvec4(w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.wwz swizzling.
        /// </summary>
        public cvec3 wwz => new cvec3(w, w, z);
        
        /// <summary>
        /// Returns cvec4.aab swizzling (equivalent to cvec4.wwz).
        /// </summary>
        public cvec3 aab => new cvec3(w, w, z);
        
        /// <summary>
        /// Returns cvec4.wwzx swizzling.
        /// </summary>
        public cvec4 wwzx => new cvec4(w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.aabr swizzling (equivalent to cvec4.wwzx).
        /// </summary>
        public cvec4 aabr => new cvec4(w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.wwzy swizzling.
        /// </summary>
        public cvec4 wwzy => new cvec4(w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.aabg swizzling (equivalent to cvec4.wwzy).
        /// </summary>
        public cvec4 aabg => new cvec4(w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.wwzz swizzling.
        /// </summary>
        public cvec4 wwzz => new cvec4(w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.aabb swizzling (equivalent to cvec4.wwzz).
        /// </summary>
        public cvec4 aabb => new cvec4(w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.wwzw swizzling.
        /// </summary>
        public cvec4 wwzw => new cvec4(w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.aaba swizzling (equivalent to cvec4.wwzw).
        /// </summary>
        public cvec4 aaba => new cvec4(w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.www swizzling.
        /// </summary>
        public cvec3 www => new cvec3(w, w, w);
        
        /// <summary>
        /// Returns cvec4.aaa swizzling (equivalent to cvec4.www).
        /// </summary>
        public cvec3 aaa => new cvec3(w, w, w);
        
        /// <summary>
        /// Returns cvec4.wwwx swizzling.
        /// </summary>
        public cvec4 wwwx => new cvec4(w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.aaar swizzling (equivalent to cvec4.wwwx).
        /// </summary>
        public cvec4 aaar => new cvec4(w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.wwwy swizzling.
        /// </summary>
        public cvec4 wwwy => new cvec4(w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.aaag swizzling (equivalent to cvec4.wwwy).
        /// </summary>
        public cvec4 aaag => new cvec4(w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.wwwz swizzling.
        /// </summary>
        public cvec4 wwwz => new cvec4(w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.aaab swizzling (equivalent to cvec4.wwwz).
        /// </summary>
        public cvec4 aaab => new cvec4(w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.wwww swizzling.
        /// </summary>
        public cvec4 wwww => new cvec4(w, w, w, w);
        
        /// <summary>
        /// Returns cvec4.aaaa swizzling (equivalent to cvec4.wwww).
        /// </summary>
        public cvec4 aaaa => new cvec4(w, w, w, w);

        #endregion

    }
}
