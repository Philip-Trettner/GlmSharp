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
    /// Temporary vector of type double with 4 components, used for implementing swizzling for dvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_dvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly double y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly double z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly double w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_dvec4.
        /// </summary>
        internal swizzle_dvec4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns dvec4.xx swizzling.
        /// </summary>
        public dvec2 xx => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec4.rr swizzling (equivalent to dvec4.xx).
        /// </summary>
        public dvec2 rr => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec4.xxx swizzling.
        /// </summary>
        public dvec3 xxx => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec4.rrr swizzling (equivalent to dvec4.xxx).
        /// </summary>
        public dvec3 rrr => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec4.xxxx swizzling.
        /// </summary>
        public dvec4 xxxx => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.rrrr swizzling (equivalent to dvec4.xxxx).
        /// </summary>
        public dvec4 rrrr => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.xxxy swizzling.
        /// </summary>
        public dvec4 xxxy => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.rrrg swizzling (equivalent to dvec4.xxxy).
        /// </summary>
        public dvec4 rrrg => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.xxxz swizzling.
        /// </summary>
        public dvec4 xxxz => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.rrrb swizzling (equivalent to dvec4.xxxz).
        /// </summary>
        public dvec4 rrrb => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.xxxw swizzling.
        /// </summary>
        public dvec4 xxxw => new dvec4(x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.rrra swizzling (equivalent to dvec4.xxxw).
        /// </summary>
        public dvec4 rrra => new dvec4(x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.xxy swizzling.
        /// </summary>
        public dvec3 xxy => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec4.rrg swizzling (equivalent to dvec4.xxy).
        /// </summary>
        public dvec3 rrg => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec4.xxyx swizzling.
        /// </summary>
        public dvec4 xxyx => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.rrgr swizzling (equivalent to dvec4.xxyx).
        /// </summary>
        public dvec4 rrgr => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.xxyy swizzling.
        /// </summary>
        public dvec4 xxyy => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.rrgg swizzling (equivalent to dvec4.xxyy).
        /// </summary>
        public dvec4 rrgg => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.xxyz swizzling.
        /// </summary>
        public dvec4 xxyz => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.rrgb swizzling (equivalent to dvec4.xxyz).
        /// </summary>
        public dvec4 rrgb => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.xxyw swizzling.
        /// </summary>
        public dvec4 xxyw => new dvec4(x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.rrga swizzling (equivalent to dvec4.xxyw).
        /// </summary>
        public dvec4 rrga => new dvec4(x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.xxz swizzling.
        /// </summary>
        public dvec3 xxz => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec4.rrb swizzling (equivalent to dvec4.xxz).
        /// </summary>
        public dvec3 rrb => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec4.xxzx swizzling.
        /// </summary>
        public dvec4 xxzx => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.rrbr swizzling (equivalent to dvec4.xxzx).
        /// </summary>
        public dvec4 rrbr => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.xxzy swizzling.
        /// </summary>
        public dvec4 xxzy => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.rrbg swizzling (equivalent to dvec4.xxzy).
        /// </summary>
        public dvec4 rrbg => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.xxzz swizzling.
        /// </summary>
        public dvec4 xxzz => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.rrbb swizzling (equivalent to dvec4.xxzz).
        /// </summary>
        public dvec4 rrbb => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.xxzw swizzling.
        /// </summary>
        public dvec4 xxzw => new dvec4(x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.rrba swizzling (equivalent to dvec4.xxzw).
        /// </summary>
        public dvec4 rrba => new dvec4(x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.xxw swizzling.
        /// </summary>
        public dvec3 xxw => new dvec3(x, x, w);
        
        /// <summary>
        /// Returns dvec4.rra swizzling (equivalent to dvec4.xxw).
        /// </summary>
        public dvec3 rra => new dvec3(x, x, w);
        
        /// <summary>
        /// Returns dvec4.xxwx swizzling.
        /// </summary>
        public dvec4 xxwx => new dvec4(x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.rrar swizzling (equivalent to dvec4.xxwx).
        /// </summary>
        public dvec4 rrar => new dvec4(x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.xxwy swizzling.
        /// </summary>
        public dvec4 xxwy => new dvec4(x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.rrag swizzling (equivalent to dvec4.xxwy).
        /// </summary>
        public dvec4 rrag => new dvec4(x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.xxwz swizzling.
        /// </summary>
        public dvec4 xxwz => new dvec4(x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.rrab swizzling (equivalent to dvec4.xxwz).
        /// </summary>
        public dvec4 rrab => new dvec4(x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.xxww swizzling.
        /// </summary>
        public dvec4 xxww => new dvec4(x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.rraa swizzling (equivalent to dvec4.xxww).
        /// </summary>
        public dvec4 rraa => new dvec4(x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.xy swizzling.
        /// </summary>
        public dvec2 xy => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec4.rg swizzling (equivalent to dvec4.xy).
        /// </summary>
        public dvec2 rg => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec4.xyx swizzling.
        /// </summary>
        public dvec3 xyx => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec4.rgr swizzling (equivalent to dvec4.xyx).
        /// </summary>
        public dvec3 rgr => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec4.xyxx swizzling.
        /// </summary>
        public dvec4 xyxx => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.rgrr swizzling (equivalent to dvec4.xyxx).
        /// </summary>
        public dvec4 rgrr => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.xyxy swizzling.
        /// </summary>
        public dvec4 xyxy => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.rgrg swizzling (equivalent to dvec4.xyxy).
        /// </summary>
        public dvec4 rgrg => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.xyxz swizzling.
        /// </summary>
        public dvec4 xyxz => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.rgrb swizzling (equivalent to dvec4.xyxz).
        /// </summary>
        public dvec4 rgrb => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.xyxw swizzling.
        /// </summary>
        public dvec4 xyxw => new dvec4(x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.rgra swizzling (equivalent to dvec4.xyxw).
        /// </summary>
        public dvec4 rgra => new dvec4(x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.xyy swizzling.
        /// </summary>
        public dvec3 xyy => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec4.rgg swizzling (equivalent to dvec4.xyy).
        /// </summary>
        public dvec3 rgg => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec4.xyyx swizzling.
        /// </summary>
        public dvec4 xyyx => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.rggr swizzling (equivalent to dvec4.xyyx).
        /// </summary>
        public dvec4 rggr => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.xyyy swizzling.
        /// </summary>
        public dvec4 xyyy => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.rggg swizzling (equivalent to dvec4.xyyy).
        /// </summary>
        public dvec4 rggg => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.xyyz swizzling.
        /// </summary>
        public dvec4 xyyz => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.rggb swizzling (equivalent to dvec4.xyyz).
        /// </summary>
        public dvec4 rggb => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.xyyw swizzling.
        /// </summary>
        public dvec4 xyyw => new dvec4(x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.rgga swizzling (equivalent to dvec4.xyyw).
        /// </summary>
        public dvec4 rgga => new dvec4(x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.xyz swizzling.
        /// </summary>
        public dvec3 xyz => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec4.rgb swizzling (equivalent to dvec4.xyz).
        /// </summary>
        public dvec3 rgb => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec4.xyzx swizzling.
        /// </summary>
        public dvec4 xyzx => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.rgbr swizzling (equivalent to dvec4.xyzx).
        /// </summary>
        public dvec4 rgbr => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.xyzy swizzling.
        /// </summary>
        public dvec4 xyzy => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.rgbg swizzling (equivalent to dvec4.xyzy).
        /// </summary>
        public dvec4 rgbg => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.xyzz swizzling.
        /// </summary>
        public dvec4 xyzz => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.rgbb swizzling (equivalent to dvec4.xyzz).
        /// </summary>
        public dvec4 rgbb => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.xyzw swizzling.
        /// </summary>
        public dvec4 xyzw => new dvec4(x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.rgba swizzling (equivalent to dvec4.xyzw).
        /// </summary>
        public dvec4 rgba => new dvec4(x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.xyw swizzling.
        /// </summary>
        public dvec3 xyw => new dvec3(x, y, w);
        
        /// <summary>
        /// Returns dvec4.rga swizzling (equivalent to dvec4.xyw).
        /// </summary>
        public dvec3 rga => new dvec3(x, y, w);
        
        /// <summary>
        /// Returns dvec4.xywx swizzling.
        /// </summary>
        public dvec4 xywx => new dvec4(x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.rgar swizzling (equivalent to dvec4.xywx).
        /// </summary>
        public dvec4 rgar => new dvec4(x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.xywy swizzling.
        /// </summary>
        public dvec4 xywy => new dvec4(x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.rgag swizzling (equivalent to dvec4.xywy).
        /// </summary>
        public dvec4 rgag => new dvec4(x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.xywz swizzling.
        /// </summary>
        public dvec4 xywz => new dvec4(x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.rgab swizzling (equivalent to dvec4.xywz).
        /// </summary>
        public dvec4 rgab => new dvec4(x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.xyww swizzling.
        /// </summary>
        public dvec4 xyww => new dvec4(x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.rgaa swizzling (equivalent to dvec4.xyww).
        /// </summary>
        public dvec4 rgaa => new dvec4(x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.xz swizzling.
        /// </summary>
        public dvec2 xz => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec4.rb swizzling (equivalent to dvec4.xz).
        /// </summary>
        public dvec2 rb => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec4.xzx swizzling.
        /// </summary>
        public dvec3 xzx => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec4.rbr swizzling (equivalent to dvec4.xzx).
        /// </summary>
        public dvec3 rbr => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec4.xzxx swizzling.
        /// </summary>
        public dvec4 xzxx => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.rbrr swizzling (equivalent to dvec4.xzxx).
        /// </summary>
        public dvec4 rbrr => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.xzxy swizzling.
        /// </summary>
        public dvec4 xzxy => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.rbrg swizzling (equivalent to dvec4.xzxy).
        /// </summary>
        public dvec4 rbrg => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.xzxz swizzling.
        /// </summary>
        public dvec4 xzxz => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.rbrb swizzling (equivalent to dvec4.xzxz).
        /// </summary>
        public dvec4 rbrb => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.xzxw swizzling.
        /// </summary>
        public dvec4 xzxw => new dvec4(x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.rbra swizzling (equivalent to dvec4.xzxw).
        /// </summary>
        public dvec4 rbra => new dvec4(x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.xzy swizzling.
        /// </summary>
        public dvec3 xzy => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec4.rbg swizzling (equivalent to dvec4.xzy).
        /// </summary>
        public dvec3 rbg => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec4.xzyx swizzling.
        /// </summary>
        public dvec4 xzyx => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.rbgr swizzling (equivalent to dvec4.xzyx).
        /// </summary>
        public dvec4 rbgr => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.xzyy swizzling.
        /// </summary>
        public dvec4 xzyy => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.rbgg swizzling (equivalent to dvec4.xzyy).
        /// </summary>
        public dvec4 rbgg => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.xzyz swizzling.
        /// </summary>
        public dvec4 xzyz => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.rbgb swizzling (equivalent to dvec4.xzyz).
        /// </summary>
        public dvec4 rbgb => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.xzyw swizzling.
        /// </summary>
        public dvec4 xzyw => new dvec4(x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.rbga swizzling (equivalent to dvec4.xzyw).
        /// </summary>
        public dvec4 rbga => new dvec4(x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.xzz swizzling.
        /// </summary>
        public dvec3 xzz => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec4.rbb swizzling (equivalent to dvec4.xzz).
        /// </summary>
        public dvec3 rbb => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec4.xzzx swizzling.
        /// </summary>
        public dvec4 xzzx => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.rbbr swizzling (equivalent to dvec4.xzzx).
        /// </summary>
        public dvec4 rbbr => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.xzzy swizzling.
        /// </summary>
        public dvec4 xzzy => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.rbbg swizzling (equivalent to dvec4.xzzy).
        /// </summary>
        public dvec4 rbbg => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.xzzz swizzling.
        /// </summary>
        public dvec4 xzzz => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.rbbb swizzling (equivalent to dvec4.xzzz).
        /// </summary>
        public dvec4 rbbb => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.xzzw swizzling.
        /// </summary>
        public dvec4 xzzw => new dvec4(x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.rbba swizzling (equivalent to dvec4.xzzw).
        /// </summary>
        public dvec4 rbba => new dvec4(x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.xzw swizzling.
        /// </summary>
        public dvec3 xzw => new dvec3(x, z, w);
        
        /// <summary>
        /// Returns dvec4.rba swizzling (equivalent to dvec4.xzw).
        /// </summary>
        public dvec3 rba => new dvec3(x, z, w);
        
        /// <summary>
        /// Returns dvec4.xzwx swizzling.
        /// </summary>
        public dvec4 xzwx => new dvec4(x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.rbar swizzling (equivalent to dvec4.xzwx).
        /// </summary>
        public dvec4 rbar => new dvec4(x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.xzwy swizzling.
        /// </summary>
        public dvec4 xzwy => new dvec4(x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.rbag swizzling (equivalent to dvec4.xzwy).
        /// </summary>
        public dvec4 rbag => new dvec4(x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.xzwz swizzling.
        /// </summary>
        public dvec4 xzwz => new dvec4(x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.rbab swizzling (equivalent to dvec4.xzwz).
        /// </summary>
        public dvec4 rbab => new dvec4(x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.xzww swizzling.
        /// </summary>
        public dvec4 xzww => new dvec4(x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.rbaa swizzling (equivalent to dvec4.xzww).
        /// </summary>
        public dvec4 rbaa => new dvec4(x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.xw swizzling.
        /// </summary>
        public dvec2 xw => new dvec2(x, w);
        
        /// <summary>
        /// Returns dvec4.ra swizzling (equivalent to dvec4.xw).
        /// </summary>
        public dvec2 ra => new dvec2(x, w);
        
        /// <summary>
        /// Returns dvec4.xwx swizzling.
        /// </summary>
        public dvec3 xwx => new dvec3(x, w, x);
        
        /// <summary>
        /// Returns dvec4.rar swizzling (equivalent to dvec4.xwx).
        /// </summary>
        public dvec3 rar => new dvec3(x, w, x);
        
        /// <summary>
        /// Returns dvec4.xwxx swizzling.
        /// </summary>
        public dvec4 xwxx => new dvec4(x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.rarr swizzling (equivalent to dvec4.xwxx).
        /// </summary>
        public dvec4 rarr => new dvec4(x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.xwxy swizzling.
        /// </summary>
        public dvec4 xwxy => new dvec4(x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.rarg swizzling (equivalent to dvec4.xwxy).
        /// </summary>
        public dvec4 rarg => new dvec4(x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.xwxz swizzling.
        /// </summary>
        public dvec4 xwxz => new dvec4(x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.rarb swizzling (equivalent to dvec4.xwxz).
        /// </summary>
        public dvec4 rarb => new dvec4(x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.xwxw swizzling.
        /// </summary>
        public dvec4 xwxw => new dvec4(x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.rara swizzling (equivalent to dvec4.xwxw).
        /// </summary>
        public dvec4 rara => new dvec4(x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.xwy swizzling.
        /// </summary>
        public dvec3 xwy => new dvec3(x, w, y);
        
        /// <summary>
        /// Returns dvec4.rag swizzling (equivalent to dvec4.xwy).
        /// </summary>
        public dvec3 rag => new dvec3(x, w, y);
        
        /// <summary>
        /// Returns dvec4.xwyx swizzling.
        /// </summary>
        public dvec4 xwyx => new dvec4(x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.ragr swizzling (equivalent to dvec4.xwyx).
        /// </summary>
        public dvec4 ragr => new dvec4(x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.xwyy swizzling.
        /// </summary>
        public dvec4 xwyy => new dvec4(x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.ragg swizzling (equivalent to dvec4.xwyy).
        /// </summary>
        public dvec4 ragg => new dvec4(x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.xwyz swizzling.
        /// </summary>
        public dvec4 xwyz => new dvec4(x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.ragb swizzling (equivalent to dvec4.xwyz).
        /// </summary>
        public dvec4 ragb => new dvec4(x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.xwyw swizzling.
        /// </summary>
        public dvec4 xwyw => new dvec4(x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.raga swizzling (equivalent to dvec4.xwyw).
        /// </summary>
        public dvec4 raga => new dvec4(x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.xwz swizzling.
        /// </summary>
        public dvec3 xwz => new dvec3(x, w, z);
        
        /// <summary>
        /// Returns dvec4.rab swizzling (equivalent to dvec4.xwz).
        /// </summary>
        public dvec3 rab => new dvec3(x, w, z);
        
        /// <summary>
        /// Returns dvec4.xwzx swizzling.
        /// </summary>
        public dvec4 xwzx => new dvec4(x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.rabr swizzling (equivalent to dvec4.xwzx).
        /// </summary>
        public dvec4 rabr => new dvec4(x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.xwzy swizzling.
        /// </summary>
        public dvec4 xwzy => new dvec4(x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.rabg swizzling (equivalent to dvec4.xwzy).
        /// </summary>
        public dvec4 rabg => new dvec4(x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.xwzz swizzling.
        /// </summary>
        public dvec4 xwzz => new dvec4(x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.rabb swizzling (equivalent to dvec4.xwzz).
        /// </summary>
        public dvec4 rabb => new dvec4(x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.xwzw swizzling.
        /// </summary>
        public dvec4 xwzw => new dvec4(x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.raba swizzling (equivalent to dvec4.xwzw).
        /// </summary>
        public dvec4 raba => new dvec4(x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.xww swizzling.
        /// </summary>
        public dvec3 xww => new dvec3(x, w, w);
        
        /// <summary>
        /// Returns dvec4.raa swizzling (equivalent to dvec4.xww).
        /// </summary>
        public dvec3 raa => new dvec3(x, w, w);
        
        /// <summary>
        /// Returns dvec4.xwwx swizzling.
        /// </summary>
        public dvec4 xwwx => new dvec4(x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.raar swizzling (equivalent to dvec4.xwwx).
        /// </summary>
        public dvec4 raar => new dvec4(x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.xwwy swizzling.
        /// </summary>
        public dvec4 xwwy => new dvec4(x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.raag swizzling (equivalent to dvec4.xwwy).
        /// </summary>
        public dvec4 raag => new dvec4(x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.xwwz swizzling.
        /// </summary>
        public dvec4 xwwz => new dvec4(x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.raab swizzling (equivalent to dvec4.xwwz).
        /// </summary>
        public dvec4 raab => new dvec4(x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.xwww swizzling.
        /// </summary>
        public dvec4 xwww => new dvec4(x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.raaa swizzling (equivalent to dvec4.xwww).
        /// </summary>
        public dvec4 raaa => new dvec4(x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.yx swizzling.
        /// </summary>
        public dvec2 yx => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec4.gr swizzling (equivalent to dvec4.yx).
        /// </summary>
        public dvec2 gr => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec4.yxx swizzling.
        /// </summary>
        public dvec3 yxx => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec4.grr swizzling (equivalent to dvec4.yxx).
        /// </summary>
        public dvec3 grr => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec4.yxxx swizzling.
        /// </summary>
        public dvec4 yxxx => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.grrr swizzling (equivalent to dvec4.yxxx).
        /// </summary>
        public dvec4 grrr => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.yxxy swizzling.
        /// </summary>
        public dvec4 yxxy => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.grrg swizzling (equivalent to dvec4.yxxy).
        /// </summary>
        public dvec4 grrg => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.yxxz swizzling.
        /// </summary>
        public dvec4 yxxz => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.grrb swizzling (equivalent to dvec4.yxxz).
        /// </summary>
        public dvec4 grrb => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.yxxw swizzling.
        /// </summary>
        public dvec4 yxxw => new dvec4(y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.grra swizzling (equivalent to dvec4.yxxw).
        /// </summary>
        public dvec4 grra => new dvec4(y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.yxy swizzling.
        /// </summary>
        public dvec3 yxy => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec4.grg swizzling (equivalent to dvec4.yxy).
        /// </summary>
        public dvec3 grg => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec4.yxyx swizzling.
        /// </summary>
        public dvec4 yxyx => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.grgr swizzling (equivalent to dvec4.yxyx).
        /// </summary>
        public dvec4 grgr => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.yxyy swizzling.
        /// </summary>
        public dvec4 yxyy => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.grgg swizzling (equivalent to dvec4.yxyy).
        /// </summary>
        public dvec4 grgg => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.yxyz swizzling.
        /// </summary>
        public dvec4 yxyz => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.grgb swizzling (equivalent to dvec4.yxyz).
        /// </summary>
        public dvec4 grgb => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.yxyw swizzling.
        /// </summary>
        public dvec4 yxyw => new dvec4(y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.grga swizzling (equivalent to dvec4.yxyw).
        /// </summary>
        public dvec4 grga => new dvec4(y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.yxz swizzling.
        /// </summary>
        public dvec3 yxz => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec4.grb swizzling (equivalent to dvec4.yxz).
        /// </summary>
        public dvec3 grb => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec4.yxzx swizzling.
        /// </summary>
        public dvec4 yxzx => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.grbr swizzling (equivalent to dvec4.yxzx).
        /// </summary>
        public dvec4 grbr => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.yxzy swizzling.
        /// </summary>
        public dvec4 yxzy => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.grbg swizzling (equivalent to dvec4.yxzy).
        /// </summary>
        public dvec4 grbg => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.yxzz swizzling.
        /// </summary>
        public dvec4 yxzz => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.grbb swizzling (equivalent to dvec4.yxzz).
        /// </summary>
        public dvec4 grbb => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.yxzw swizzling.
        /// </summary>
        public dvec4 yxzw => new dvec4(y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.grba swizzling (equivalent to dvec4.yxzw).
        /// </summary>
        public dvec4 grba => new dvec4(y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.yxw swizzling.
        /// </summary>
        public dvec3 yxw => new dvec3(y, x, w);
        
        /// <summary>
        /// Returns dvec4.gra swizzling (equivalent to dvec4.yxw).
        /// </summary>
        public dvec3 gra => new dvec3(y, x, w);
        
        /// <summary>
        /// Returns dvec4.yxwx swizzling.
        /// </summary>
        public dvec4 yxwx => new dvec4(y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.grar swizzling (equivalent to dvec4.yxwx).
        /// </summary>
        public dvec4 grar => new dvec4(y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.yxwy swizzling.
        /// </summary>
        public dvec4 yxwy => new dvec4(y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.grag swizzling (equivalent to dvec4.yxwy).
        /// </summary>
        public dvec4 grag => new dvec4(y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.yxwz swizzling.
        /// </summary>
        public dvec4 yxwz => new dvec4(y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.grab swizzling (equivalent to dvec4.yxwz).
        /// </summary>
        public dvec4 grab => new dvec4(y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.yxww swizzling.
        /// </summary>
        public dvec4 yxww => new dvec4(y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.graa swizzling (equivalent to dvec4.yxww).
        /// </summary>
        public dvec4 graa => new dvec4(y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.yy swizzling.
        /// </summary>
        public dvec2 yy => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec4.gg swizzling (equivalent to dvec4.yy).
        /// </summary>
        public dvec2 gg => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec4.yyx swizzling.
        /// </summary>
        public dvec3 yyx => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec4.ggr swizzling (equivalent to dvec4.yyx).
        /// </summary>
        public dvec3 ggr => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec4.yyxx swizzling.
        /// </summary>
        public dvec4 yyxx => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.ggrr swizzling (equivalent to dvec4.yyxx).
        /// </summary>
        public dvec4 ggrr => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.yyxy swizzling.
        /// </summary>
        public dvec4 yyxy => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.ggrg swizzling (equivalent to dvec4.yyxy).
        /// </summary>
        public dvec4 ggrg => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.yyxz swizzling.
        /// </summary>
        public dvec4 yyxz => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.ggrb swizzling (equivalent to dvec4.yyxz).
        /// </summary>
        public dvec4 ggrb => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.yyxw swizzling.
        /// </summary>
        public dvec4 yyxw => new dvec4(y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.ggra swizzling (equivalent to dvec4.yyxw).
        /// </summary>
        public dvec4 ggra => new dvec4(y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.yyy swizzling.
        /// </summary>
        public dvec3 yyy => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec4.ggg swizzling (equivalent to dvec4.yyy).
        /// </summary>
        public dvec3 ggg => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec4.yyyx swizzling.
        /// </summary>
        public dvec4 yyyx => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.gggr swizzling (equivalent to dvec4.yyyx).
        /// </summary>
        public dvec4 gggr => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.yyyy swizzling.
        /// </summary>
        public dvec4 yyyy => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.gggg swizzling (equivalent to dvec4.yyyy).
        /// </summary>
        public dvec4 gggg => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.yyyz swizzling.
        /// </summary>
        public dvec4 yyyz => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.gggb swizzling (equivalent to dvec4.yyyz).
        /// </summary>
        public dvec4 gggb => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.yyyw swizzling.
        /// </summary>
        public dvec4 yyyw => new dvec4(y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.ggga swizzling (equivalent to dvec4.yyyw).
        /// </summary>
        public dvec4 ggga => new dvec4(y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.yyz swizzling.
        /// </summary>
        public dvec3 yyz => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec4.ggb swizzling (equivalent to dvec4.yyz).
        /// </summary>
        public dvec3 ggb => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec4.yyzx swizzling.
        /// </summary>
        public dvec4 yyzx => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.ggbr swizzling (equivalent to dvec4.yyzx).
        /// </summary>
        public dvec4 ggbr => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.yyzy swizzling.
        /// </summary>
        public dvec4 yyzy => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.ggbg swizzling (equivalent to dvec4.yyzy).
        /// </summary>
        public dvec4 ggbg => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.yyzz swizzling.
        /// </summary>
        public dvec4 yyzz => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.ggbb swizzling (equivalent to dvec4.yyzz).
        /// </summary>
        public dvec4 ggbb => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.yyzw swizzling.
        /// </summary>
        public dvec4 yyzw => new dvec4(y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.ggba swizzling (equivalent to dvec4.yyzw).
        /// </summary>
        public dvec4 ggba => new dvec4(y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.yyw swizzling.
        /// </summary>
        public dvec3 yyw => new dvec3(y, y, w);
        
        /// <summary>
        /// Returns dvec4.gga swizzling (equivalent to dvec4.yyw).
        /// </summary>
        public dvec3 gga => new dvec3(y, y, w);
        
        /// <summary>
        /// Returns dvec4.yywx swizzling.
        /// </summary>
        public dvec4 yywx => new dvec4(y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.ggar swizzling (equivalent to dvec4.yywx).
        /// </summary>
        public dvec4 ggar => new dvec4(y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.yywy swizzling.
        /// </summary>
        public dvec4 yywy => new dvec4(y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.ggag swizzling (equivalent to dvec4.yywy).
        /// </summary>
        public dvec4 ggag => new dvec4(y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.yywz swizzling.
        /// </summary>
        public dvec4 yywz => new dvec4(y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.ggab swizzling (equivalent to dvec4.yywz).
        /// </summary>
        public dvec4 ggab => new dvec4(y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.yyww swizzling.
        /// </summary>
        public dvec4 yyww => new dvec4(y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.ggaa swizzling (equivalent to dvec4.yyww).
        /// </summary>
        public dvec4 ggaa => new dvec4(y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.yz swizzling.
        /// </summary>
        public dvec2 yz => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec4.gb swizzling (equivalent to dvec4.yz).
        /// </summary>
        public dvec2 gb => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec4.yzx swizzling.
        /// </summary>
        public dvec3 yzx => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec4.gbr swizzling (equivalent to dvec4.yzx).
        /// </summary>
        public dvec3 gbr => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec4.yzxx swizzling.
        /// </summary>
        public dvec4 yzxx => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.gbrr swizzling (equivalent to dvec4.yzxx).
        /// </summary>
        public dvec4 gbrr => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.yzxy swizzling.
        /// </summary>
        public dvec4 yzxy => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.gbrg swizzling (equivalent to dvec4.yzxy).
        /// </summary>
        public dvec4 gbrg => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.yzxz swizzling.
        /// </summary>
        public dvec4 yzxz => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.gbrb swizzling (equivalent to dvec4.yzxz).
        /// </summary>
        public dvec4 gbrb => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.yzxw swizzling.
        /// </summary>
        public dvec4 yzxw => new dvec4(y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.gbra swizzling (equivalent to dvec4.yzxw).
        /// </summary>
        public dvec4 gbra => new dvec4(y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.yzy swizzling.
        /// </summary>
        public dvec3 yzy => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec4.gbg swizzling (equivalent to dvec4.yzy).
        /// </summary>
        public dvec3 gbg => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec4.yzyx swizzling.
        /// </summary>
        public dvec4 yzyx => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.gbgr swizzling (equivalent to dvec4.yzyx).
        /// </summary>
        public dvec4 gbgr => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.yzyy swizzling.
        /// </summary>
        public dvec4 yzyy => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.gbgg swizzling (equivalent to dvec4.yzyy).
        /// </summary>
        public dvec4 gbgg => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.yzyz swizzling.
        /// </summary>
        public dvec4 yzyz => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.gbgb swizzling (equivalent to dvec4.yzyz).
        /// </summary>
        public dvec4 gbgb => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.yzyw swizzling.
        /// </summary>
        public dvec4 yzyw => new dvec4(y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.gbga swizzling (equivalent to dvec4.yzyw).
        /// </summary>
        public dvec4 gbga => new dvec4(y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.yzz swizzling.
        /// </summary>
        public dvec3 yzz => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec4.gbb swizzling (equivalent to dvec4.yzz).
        /// </summary>
        public dvec3 gbb => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec4.yzzx swizzling.
        /// </summary>
        public dvec4 yzzx => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.gbbr swizzling (equivalent to dvec4.yzzx).
        /// </summary>
        public dvec4 gbbr => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.yzzy swizzling.
        /// </summary>
        public dvec4 yzzy => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.gbbg swizzling (equivalent to dvec4.yzzy).
        /// </summary>
        public dvec4 gbbg => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.yzzz swizzling.
        /// </summary>
        public dvec4 yzzz => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.gbbb swizzling (equivalent to dvec4.yzzz).
        /// </summary>
        public dvec4 gbbb => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.yzzw swizzling.
        /// </summary>
        public dvec4 yzzw => new dvec4(y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.gbba swizzling (equivalent to dvec4.yzzw).
        /// </summary>
        public dvec4 gbba => new dvec4(y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.yzw swizzling.
        /// </summary>
        public dvec3 yzw => new dvec3(y, z, w);
        
        /// <summary>
        /// Returns dvec4.gba swizzling (equivalent to dvec4.yzw).
        /// </summary>
        public dvec3 gba => new dvec3(y, z, w);
        
        /// <summary>
        /// Returns dvec4.yzwx swizzling.
        /// </summary>
        public dvec4 yzwx => new dvec4(y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.gbar swizzling (equivalent to dvec4.yzwx).
        /// </summary>
        public dvec4 gbar => new dvec4(y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.yzwy swizzling.
        /// </summary>
        public dvec4 yzwy => new dvec4(y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.gbag swizzling (equivalent to dvec4.yzwy).
        /// </summary>
        public dvec4 gbag => new dvec4(y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.yzwz swizzling.
        /// </summary>
        public dvec4 yzwz => new dvec4(y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.gbab swizzling (equivalent to dvec4.yzwz).
        /// </summary>
        public dvec4 gbab => new dvec4(y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.yzww swizzling.
        /// </summary>
        public dvec4 yzww => new dvec4(y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.gbaa swizzling (equivalent to dvec4.yzww).
        /// </summary>
        public dvec4 gbaa => new dvec4(y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.yw swizzling.
        /// </summary>
        public dvec2 yw => new dvec2(y, w);
        
        /// <summary>
        /// Returns dvec4.ga swizzling (equivalent to dvec4.yw).
        /// </summary>
        public dvec2 ga => new dvec2(y, w);
        
        /// <summary>
        /// Returns dvec4.ywx swizzling.
        /// </summary>
        public dvec3 ywx => new dvec3(y, w, x);
        
        /// <summary>
        /// Returns dvec4.gar swizzling (equivalent to dvec4.ywx).
        /// </summary>
        public dvec3 gar => new dvec3(y, w, x);
        
        /// <summary>
        /// Returns dvec4.ywxx swizzling.
        /// </summary>
        public dvec4 ywxx => new dvec4(y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.garr swizzling (equivalent to dvec4.ywxx).
        /// </summary>
        public dvec4 garr => new dvec4(y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.ywxy swizzling.
        /// </summary>
        public dvec4 ywxy => new dvec4(y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.garg swizzling (equivalent to dvec4.ywxy).
        /// </summary>
        public dvec4 garg => new dvec4(y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.ywxz swizzling.
        /// </summary>
        public dvec4 ywxz => new dvec4(y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.garb swizzling (equivalent to dvec4.ywxz).
        /// </summary>
        public dvec4 garb => new dvec4(y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.ywxw swizzling.
        /// </summary>
        public dvec4 ywxw => new dvec4(y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.gara swizzling (equivalent to dvec4.ywxw).
        /// </summary>
        public dvec4 gara => new dvec4(y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.ywy swizzling.
        /// </summary>
        public dvec3 ywy => new dvec3(y, w, y);
        
        /// <summary>
        /// Returns dvec4.gag swizzling (equivalent to dvec4.ywy).
        /// </summary>
        public dvec3 gag => new dvec3(y, w, y);
        
        /// <summary>
        /// Returns dvec4.ywyx swizzling.
        /// </summary>
        public dvec4 ywyx => new dvec4(y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.gagr swizzling (equivalent to dvec4.ywyx).
        /// </summary>
        public dvec4 gagr => new dvec4(y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.ywyy swizzling.
        /// </summary>
        public dvec4 ywyy => new dvec4(y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.gagg swizzling (equivalent to dvec4.ywyy).
        /// </summary>
        public dvec4 gagg => new dvec4(y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.ywyz swizzling.
        /// </summary>
        public dvec4 ywyz => new dvec4(y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.gagb swizzling (equivalent to dvec4.ywyz).
        /// </summary>
        public dvec4 gagb => new dvec4(y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.ywyw swizzling.
        /// </summary>
        public dvec4 ywyw => new dvec4(y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.gaga swizzling (equivalent to dvec4.ywyw).
        /// </summary>
        public dvec4 gaga => new dvec4(y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.ywz swizzling.
        /// </summary>
        public dvec3 ywz => new dvec3(y, w, z);
        
        /// <summary>
        /// Returns dvec4.gab swizzling (equivalent to dvec4.ywz).
        /// </summary>
        public dvec3 gab => new dvec3(y, w, z);
        
        /// <summary>
        /// Returns dvec4.ywzx swizzling.
        /// </summary>
        public dvec4 ywzx => new dvec4(y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.gabr swizzling (equivalent to dvec4.ywzx).
        /// </summary>
        public dvec4 gabr => new dvec4(y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.ywzy swizzling.
        /// </summary>
        public dvec4 ywzy => new dvec4(y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.gabg swizzling (equivalent to dvec4.ywzy).
        /// </summary>
        public dvec4 gabg => new dvec4(y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.ywzz swizzling.
        /// </summary>
        public dvec4 ywzz => new dvec4(y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.gabb swizzling (equivalent to dvec4.ywzz).
        /// </summary>
        public dvec4 gabb => new dvec4(y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.ywzw swizzling.
        /// </summary>
        public dvec4 ywzw => new dvec4(y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.gaba swizzling (equivalent to dvec4.ywzw).
        /// </summary>
        public dvec4 gaba => new dvec4(y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.yww swizzling.
        /// </summary>
        public dvec3 yww => new dvec3(y, w, w);
        
        /// <summary>
        /// Returns dvec4.gaa swizzling (equivalent to dvec4.yww).
        /// </summary>
        public dvec3 gaa => new dvec3(y, w, w);
        
        /// <summary>
        /// Returns dvec4.ywwx swizzling.
        /// </summary>
        public dvec4 ywwx => new dvec4(y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.gaar swizzling (equivalent to dvec4.ywwx).
        /// </summary>
        public dvec4 gaar => new dvec4(y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.ywwy swizzling.
        /// </summary>
        public dvec4 ywwy => new dvec4(y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.gaag swizzling (equivalent to dvec4.ywwy).
        /// </summary>
        public dvec4 gaag => new dvec4(y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.ywwz swizzling.
        /// </summary>
        public dvec4 ywwz => new dvec4(y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.gaab swizzling (equivalent to dvec4.ywwz).
        /// </summary>
        public dvec4 gaab => new dvec4(y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.ywww swizzling.
        /// </summary>
        public dvec4 ywww => new dvec4(y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.gaaa swizzling (equivalent to dvec4.ywww).
        /// </summary>
        public dvec4 gaaa => new dvec4(y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.zx swizzling.
        /// </summary>
        public dvec2 zx => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec4.br swizzling (equivalent to dvec4.zx).
        /// </summary>
        public dvec2 br => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec4.zxx swizzling.
        /// </summary>
        public dvec3 zxx => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec4.brr swizzling (equivalent to dvec4.zxx).
        /// </summary>
        public dvec3 brr => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec4.zxxx swizzling.
        /// </summary>
        public dvec4 zxxx => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.brrr swizzling (equivalent to dvec4.zxxx).
        /// </summary>
        public dvec4 brrr => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.zxxy swizzling.
        /// </summary>
        public dvec4 zxxy => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.brrg swizzling (equivalent to dvec4.zxxy).
        /// </summary>
        public dvec4 brrg => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.zxxz swizzling.
        /// </summary>
        public dvec4 zxxz => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.brrb swizzling (equivalent to dvec4.zxxz).
        /// </summary>
        public dvec4 brrb => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.zxxw swizzling.
        /// </summary>
        public dvec4 zxxw => new dvec4(z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.brra swizzling (equivalent to dvec4.zxxw).
        /// </summary>
        public dvec4 brra => new dvec4(z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.zxy swizzling.
        /// </summary>
        public dvec3 zxy => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec4.brg swizzling (equivalent to dvec4.zxy).
        /// </summary>
        public dvec3 brg => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec4.zxyx swizzling.
        /// </summary>
        public dvec4 zxyx => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.brgr swizzling (equivalent to dvec4.zxyx).
        /// </summary>
        public dvec4 brgr => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.zxyy swizzling.
        /// </summary>
        public dvec4 zxyy => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.brgg swizzling (equivalent to dvec4.zxyy).
        /// </summary>
        public dvec4 brgg => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.zxyz swizzling.
        /// </summary>
        public dvec4 zxyz => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.brgb swizzling (equivalent to dvec4.zxyz).
        /// </summary>
        public dvec4 brgb => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.zxyw swizzling.
        /// </summary>
        public dvec4 zxyw => new dvec4(z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.brga swizzling (equivalent to dvec4.zxyw).
        /// </summary>
        public dvec4 brga => new dvec4(z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.zxz swizzling.
        /// </summary>
        public dvec3 zxz => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec4.brb swizzling (equivalent to dvec4.zxz).
        /// </summary>
        public dvec3 brb => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec4.zxzx swizzling.
        /// </summary>
        public dvec4 zxzx => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.brbr swizzling (equivalent to dvec4.zxzx).
        /// </summary>
        public dvec4 brbr => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.zxzy swizzling.
        /// </summary>
        public dvec4 zxzy => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.brbg swizzling (equivalent to dvec4.zxzy).
        /// </summary>
        public dvec4 brbg => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.zxzz swizzling.
        /// </summary>
        public dvec4 zxzz => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.brbb swizzling (equivalent to dvec4.zxzz).
        /// </summary>
        public dvec4 brbb => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.zxzw swizzling.
        /// </summary>
        public dvec4 zxzw => new dvec4(z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.brba swizzling (equivalent to dvec4.zxzw).
        /// </summary>
        public dvec4 brba => new dvec4(z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.zxw swizzling.
        /// </summary>
        public dvec3 zxw => new dvec3(z, x, w);
        
        /// <summary>
        /// Returns dvec4.bra swizzling (equivalent to dvec4.zxw).
        /// </summary>
        public dvec3 bra => new dvec3(z, x, w);
        
        /// <summary>
        /// Returns dvec4.zxwx swizzling.
        /// </summary>
        public dvec4 zxwx => new dvec4(z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.brar swizzling (equivalent to dvec4.zxwx).
        /// </summary>
        public dvec4 brar => new dvec4(z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.zxwy swizzling.
        /// </summary>
        public dvec4 zxwy => new dvec4(z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.brag swizzling (equivalent to dvec4.zxwy).
        /// </summary>
        public dvec4 brag => new dvec4(z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.zxwz swizzling.
        /// </summary>
        public dvec4 zxwz => new dvec4(z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.brab swizzling (equivalent to dvec4.zxwz).
        /// </summary>
        public dvec4 brab => new dvec4(z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.zxww swizzling.
        /// </summary>
        public dvec4 zxww => new dvec4(z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.braa swizzling (equivalent to dvec4.zxww).
        /// </summary>
        public dvec4 braa => new dvec4(z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.zy swizzling.
        /// </summary>
        public dvec2 zy => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec4.bg swizzling (equivalent to dvec4.zy).
        /// </summary>
        public dvec2 bg => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec4.zyx swizzling.
        /// </summary>
        public dvec3 zyx => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec4.bgr swizzling (equivalent to dvec4.zyx).
        /// </summary>
        public dvec3 bgr => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec4.zyxx swizzling.
        /// </summary>
        public dvec4 zyxx => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.bgrr swizzling (equivalent to dvec4.zyxx).
        /// </summary>
        public dvec4 bgrr => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.zyxy swizzling.
        /// </summary>
        public dvec4 zyxy => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.bgrg swizzling (equivalent to dvec4.zyxy).
        /// </summary>
        public dvec4 bgrg => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.zyxz swizzling.
        /// </summary>
        public dvec4 zyxz => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.bgrb swizzling (equivalent to dvec4.zyxz).
        /// </summary>
        public dvec4 bgrb => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.zyxw swizzling.
        /// </summary>
        public dvec4 zyxw => new dvec4(z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.bgra swizzling (equivalent to dvec4.zyxw).
        /// </summary>
        public dvec4 bgra => new dvec4(z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.zyy swizzling.
        /// </summary>
        public dvec3 zyy => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec4.bgg swizzling (equivalent to dvec4.zyy).
        /// </summary>
        public dvec3 bgg => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec4.zyyx swizzling.
        /// </summary>
        public dvec4 zyyx => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.bggr swizzling (equivalent to dvec4.zyyx).
        /// </summary>
        public dvec4 bggr => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.zyyy swizzling.
        /// </summary>
        public dvec4 zyyy => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.bggg swizzling (equivalent to dvec4.zyyy).
        /// </summary>
        public dvec4 bggg => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.zyyz swizzling.
        /// </summary>
        public dvec4 zyyz => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.bggb swizzling (equivalent to dvec4.zyyz).
        /// </summary>
        public dvec4 bggb => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.zyyw swizzling.
        /// </summary>
        public dvec4 zyyw => new dvec4(z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.bgga swizzling (equivalent to dvec4.zyyw).
        /// </summary>
        public dvec4 bgga => new dvec4(z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.zyz swizzling.
        /// </summary>
        public dvec3 zyz => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec4.bgb swizzling (equivalent to dvec4.zyz).
        /// </summary>
        public dvec3 bgb => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec4.zyzx swizzling.
        /// </summary>
        public dvec4 zyzx => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.bgbr swizzling (equivalent to dvec4.zyzx).
        /// </summary>
        public dvec4 bgbr => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.zyzy swizzling.
        /// </summary>
        public dvec4 zyzy => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.bgbg swizzling (equivalent to dvec4.zyzy).
        /// </summary>
        public dvec4 bgbg => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.zyzz swizzling.
        /// </summary>
        public dvec4 zyzz => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.bgbb swizzling (equivalent to dvec4.zyzz).
        /// </summary>
        public dvec4 bgbb => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.zyzw swizzling.
        /// </summary>
        public dvec4 zyzw => new dvec4(z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.bgba swizzling (equivalent to dvec4.zyzw).
        /// </summary>
        public dvec4 bgba => new dvec4(z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.zyw swizzling.
        /// </summary>
        public dvec3 zyw => new dvec3(z, y, w);
        
        /// <summary>
        /// Returns dvec4.bga swizzling (equivalent to dvec4.zyw).
        /// </summary>
        public dvec3 bga => new dvec3(z, y, w);
        
        /// <summary>
        /// Returns dvec4.zywx swizzling.
        /// </summary>
        public dvec4 zywx => new dvec4(z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.bgar swizzling (equivalent to dvec4.zywx).
        /// </summary>
        public dvec4 bgar => new dvec4(z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.zywy swizzling.
        /// </summary>
        public dvec4 zywy => new dvec4(z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.bgag swizzling (equivalent to dvec4.zywy).
        /// </summary>
        public dvec4 bgag => new dvec4(z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.zywz swizzling.
        /// </summary>
        public dvec4 zywz => new dvec4(z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.bgab swizzling (equivalent to dvec4.zywz).
        /// </summary>
        public dvec4 bgab => new dvec4(z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.zyww swizzling.
        /// </summary>
        public dvec4 zyww => new dvec4(z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.bgaa swizzling (equivalent to dvec4.zyww).
        /// </summary>
        public dvec4 bgaa => new dvec4(z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.zz swizzling.
        /// </summary>
        public dvec2 zz => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec4.bb swizzling (equivalent to dvec4.zz).
        /// </summary>
        public dvec2 bb => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec4.zzx swizzling.
        /// </summary>
        public dvec3 zzx => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec4.bbr swizzling (equivalent to dvec4.zzx).
        /// </summary>
        public dvec3 bbr => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec4.zzxx swizzling.
        /// </summary>
        public dvec4 zzxx => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.bbrr swizzling (equivalent to dvec4.zzxx).
        /// </summary>
        public dvec4 bbrr => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.zzxy swizzling.
        /// </summary>
        public dvec4 zzxy => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.bbrg swizzling (equivalent to dvec4.zzxy).
        /// </summary>
        public dvec4 bbrg => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.zzxz swizzling.
        /// </summary>
        public dvec4 zzxz => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.bbrb swizzling (equivalent to dvec4.zzxz).
        /// </summary>
        public dvec4 bbrb => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.zzxw swizzling.
        /// </summary>
        public dvec4 zzxw => new dvec4(z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.bbra swizzling (equivalent to dvec4.zzxw).
        /// </summary>
        public dvec4 bbra => new dvec4(z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.zzy swizzling.
        /// </summary>
        public dvec3 zzy => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec4.bbg swizzling (equivalent to dvec4.zzy).
        /// </summary>
        public dvec3 bbg => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec4.zzyx swizzling.
        /// </summary>
        public dvec4 zzyx => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.bbgr swizzling (equivalent to dvec4.zzyx).
        /// </summary>
        public dvec4 bbgr => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.zzyy swizzling.
        /// </summary>
        public dvec4 zzyy => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.bbgg swizzling (equivalent to dvec4.zzyy).
        /// </summary>
        public dvec4 bbgg => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.zzyz swizzling.
        /// </summary>
        public dvec4 zzyz => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.bbgb swizzling (equivalent to dvec4.zzyz).
        /// </summary>
        public dvec4 bbgb => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.zzyw swizzling.
        /// </summary>
        public dvec4 zzyw => new dvec4(z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.bbga swizzling (equivalent to dvec4.zzyw).
        /// </summary>
        public dvec4 bbga => new dvec4(z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.zzz swizzling.
        /// </summary>
        public dvec3 zzz => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec4.bbb swizzling (equivalent to dvec4.zzz).
        /// </summary>
        public dvec3 bbb => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec4.zzzx swizzling.
        /// </summary>
        public dvec4 zzzx => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.bbbr swizzling (equivalent to dvec4.zzzx).
        /// </summary>
        public dvec4 bbbr => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.zzzy swizzling.
        /// </summary>
        public dvec4 zzzy => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.bbbg swizzling (equivalent to dvec4.zzzy).
        /// </summary>
        public dvec4 bbbg => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.zzzz swizzling.
        /// </summary>
        public dvec4 zzzz => new dvec4(z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.bbbb swizzling (equivalent to dvec4.zzzz).
        /// </summary>
        public dvec4 bbbb => new dvec4(z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.zzzw swizzling.
        /// </summary>
        public dvec4 zzzw => new dvec4(z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.bbba swizzling (equivalent to dvec4.zzzw).
        /// </summary>
        public dvec4 bbba => new dvec4(z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.zzw swizzling.
        /// </summary>
        public dvec3 zzw => new dvec3(z, z, w);
        
        /// <summary>
        /// Returns dvec4.bba swizzling (equivalent to dvec4.zzw).
        /// </summary>
        public dvec3 bba => new dvec3(z, z, w);
        
        /// <summary>
        /// Returns dvec4.zzwx swizzling.
        /// </summary>
        public dvec4 zzwx => new dvec4(z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.bbar swizzling (equivalent to dvec4.zzwx).
        /// </summary>
        public dvec4 bbar => new dvec4(z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.zzwy swizzling.
        /// </summary>
        public dvec4 zzwy => new dvec4(z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.bbag swizzling (equivalent to dvec4.zzwy).
        /// </summary>
        public dvec4 bbag => new dvec4(z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.zzwz swizzling.
        /// </summary>
        public dvec4 zzwz => new dvec4(z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.bbab swizzling (equivalent to dvec4.zzwz).
        /// </summary>
        public dvec4 bbab => new dvec4(z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.zzww swizzling.
        /// </summary>
        public dvec4 zzww => new dvec4(z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.bbaa swizzling (equivalent to dvec4.zzww).
        /// </summary>
        public dvec4 bbaa => new dvec4(z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.zw swizzling.
        /// </summary>
        public dvec2 zw => new dvec2(z, w);
        
        /// <summary>
        /// Returns dvec4.ba swizzling (equivalent to dvec4.zw).
        /// </summary>
        public dvec2 ba => new dvec2(z, w);
        
        /// <summary>
        /// Returns dvec4.zwx swizzling.
        /// </summary>
        public dvec3 zwx => new dvec3(z, w, x);
        
        /// <summary>
        /// Returns dvec4.bar swizzling (equivalent to dvec4.zwx).
        /// </summary>
        public dvec3 bar => new dvec3(z, w, x);
        
        /// <summary>
        /// Returns dvec4.zwxx swizzling.
        /// </summary>
        public dvec4 zwxx => new dvec4(z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.barr swizzling (equivalent to dvec4.zwxx).
        /// </summary>
        public dvec4 barr => new dvec4(z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.zwxy swizzling.
        /// </summary>
        public dvec4 zwxy => new dvec4(z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.barg swizzling (equivalent to dvec4.zwxy).
        /// </summary>
        public dvec4 barg => new dvec4(z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.zwxz swizzling.
        /// </summary>
        public dvec4 zwxz => new dvec4(z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.barb swizzling (equivalent to dvec4.zwxz).
        /// </summary>
        public dvec4 barb => new dvec4(z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.zwxw swizzling.
        /// </summary>
        public dvec4 zwxw => new dvec4(z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.bara swizzling (equivalent to dvec4.zwxw).
        /// </summary>
        public dvec4 bara => new dvec4(z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.zwy swizzling.
        /// </summary>
        public dvec3 zwy => new dvec3(z, w, y);
        
        /// <summary>
        /// Returns dvec4.bag swizzling (equivalent to dvec4.zwy).
        /// </summary>
        public dvec3 bag => new dvec3(z, w, y);
        
        /// <summary>
        /// Returns dvec4.zwyx swizzling.
        /// </summary>
        public dvec4 zwyx => new dvec4(z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.bagr swizzling (equivalent to dvec4.zwyx).
        /// </summary>
        public dvec4 bagr => new dvec4(z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.zwyy swizzling.
        /// </summary>
        public dvec4 zwyy => new dvec4(z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.bagg swizzling (equivalent to dvec4.zwyy).
        /// </summary>
        public dvec4 bagg => new dvec4(z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.zwyz swizzling.
        /// </summary>
        public dvec4 zwyz => new dvec4(z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.bagb swizzling (equivalent to dvec4.zwyz).
        /// </summary>
        public dvec4 bagb => new dvec4(z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.zwyw swizzling.
        /// </summary>
        public dvec4 zwyw => new dvec4(z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.baga swizzling (equivalent to dvec4.zwyw).
        /// </summary>
        public dvec4 baga => new dvec4(z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.zwz swizzling.
        /// </summary>
        public dvec3 zwz => new dvec3(z, w, z);
        
        /// <summary>
        /// Returns dvec4.bab swizzling (equivalent to dvec4.zwz).
        /// </summary>
        public dvec3 bab => new dvec3(z, w, z);
        
        /// <summary>
        /// Returns dvec4.zwzx swizzling.
        /// </summary>
        public dvec4 zwzx => new dvec4(z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.babr swizzling (equivalent to dvec4.zwzx).
        /// </summary>
        public dvec4 babr => new dvec4(z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.zwzy swizzling.
        /// </summary>
        public dvec4 zwzy => new dvec4(z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.babg swizzling (equivalent to dvec4.zwzy).
        /// </summary>
        public dvec4 babg => new dvec4(z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.zwzz swizzling.
        /// </summary>
        public dvec4 zwzz => new dvec4(z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.babb swizzling (equivalent to dvec4.zwzz).
        /// </summary>
        public dvec4 babb => new dvec4(z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.zwzw swizzling.
        /// </summary>
        public dvec4 zwzw => new dvec4(z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.baba swizzling (equivalent to dvec4.zwzw).
        /// </summary>
        public dvec4 baba => new dvec4(z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.zww swizzling.
        /// </summary>
        public dvec3 zww => new dvec3(z, w, w);
        
        /// <summary>
        /// Returns dvec4.baa swizzling (equivalent to dvec4.zww).
        /// </summary>
        public dvec3 baa => new dvec3(z, w, w);
        
        /// <summary>
        /// Returns dvec4.zwwx swizzling.
        /// </summary>
        public dvec4 zwwx => new dvec4(z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.baar swizzling (equivalent to dvec4.zwwx).
        /// </summary>
        public dvec4 baar => new dvec4(z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.zwwy swizzling.
        /// </summary>
        public dvec4 zwwy => new dvec4(z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.baag swizzling (equivalent to dvec4.zwwy).
        /// </summary>
        public dvec4 baag => new dvec4(z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.zwwz swizzling.
        /// </summary>
        public dvec4 zwwz => new dvec4(z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.baab swizzling (equivalent to dvec4.zwwz).
        /// </summary>
        public dvec4 baab => new dvec4(z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.zwww swizzling.
        /// </summary>
        public dvec4 zwww => new dvec4(z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.baaa swizzling (equivalent to dvec4.zwww).
        /// </summary>
        public dvec4 baaa => new dvec4(z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.wx swizzling.
        /// </summary>
        public dvec2 wx => new dvec2(w, x);
        
        /// <summary>
        /// Returns dvec4.ar swizzling (equivalent to dvec4.wx).
        /// </summary>
        public dvec2 ar => new dvec2(w, x);
        
        /// <summary>
        /// Returns dvec4.wxx swizzling.
        /// </summary>
        public dvec3 wxx => new dvec3(w, x, x);
        
        /// <summary>
        /// Returns dvec4.arr swizzling (equivalent to dvec4.wxx).
        /// </summary>
        public dvec3 arr => new dvec3(w, x, x);
        
        /// <summary>
        /// Returns dvec4.wxxx swizzling.
        /// </summary>
        public dvec4 wxxx => new dvec4(w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.arrr swizzling (equivalent to dvec4.wxxx).
        /// </summary>
        public dvec4 arrr => new dvec4(w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.wxxy swizzling.
        /// </summary>
        public dvec4 wxxy => new dvec4(w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.arrg swizzling (equivalent to dvec4.wxxy).
        /// </summary>
        public dvec4 arrg => new dvec4(w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.wxxz swizzling.
        /// </summary>
        public dvec4 wxxz => new dvec4(w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.arrb swizzling (equivalent to dvec4.wxxz).
        /// </summary>
        public dvec4 arrb => new dvec4(w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.wxxw swizzling.
        /// </summary>
        public dvec4 wxxw => new dvec4(w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.arra swizzling (equivalent to dvec4.wxxw).
        /// </summary>
        public dvec4 arra => new dvec4(w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.wxy swizzling.
        /// </summary>
        public dvec3 wxy => new dvec3(w, x, y);
        
        /// <summary>
        /// Returns dvec4.arg swizzling (equivalent to dvec4.wxy).
        /// </summary>
        public dvec3 arg => new dvec3(w, x, y);
        
        /// <summary>
        /// Returns dvec4.wxyx swizzling.
        /// </summary>
        public dvec4 wxyx => new dvec4(w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.argr swizzling (equivalent to dvec4.wxyx).
        /// </summary>
        public dvec4 argr => new dvec4(w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.wxyy swizzling.
        /// </summary>
        public dvec4 wxyy => new dvec4(w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.argg swizzling (equivalent to dvec4.wxyy).
        /// </summary>
        public dvec4 argg => new dvec4(w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.wxyz swizzling.
        /// </summary>
        public dvec4 wxyz => new dvec4(w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.argb swizzling (equivalent to dvec4.wxyz).
        /// </summary>
        public dvec4 argb => new dvec4(w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.wxyw swizzling.
        /// </summary>
        public dvec4 wxyw => new dvec4(w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.arga swizzling (equivalent to dvec4.wxyw).
        /// </summary>
        public dvec4 arga => new dvec4(w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.wxz swizzling.
        /// </summary>
        public dvec3 wxz => new dvec3(w, x, z);
        
        /// <summary>
        /// Returns dvec4.arb swizzling (equivalent to dvec4.wxz).
        /// </summary>
        public dvec3 arb => new dvec3(w, x, z);
        
        /// <summary>
        /// Returns dvec4.wxzx swizzling.
        /// </summary>
        public dvec4 wxzx => new dvec4(w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.arbr swizzling (equivalent to dvec4.wxzx).
        /// </summary>
        public dvec4 arbr => new dvec4(w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.wxzy swizzling.
        /// </summary>
        public dvec4 wxzy => new dvec4(w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.arbg swizzling (equivalent to dvec4.wxzy).
        /// </summary>
        public dvec4 arbg => new dvec4(w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.wxzz swizzling.
        /// </summary>
        public dvec4 wxzz => new dvec4(w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.arbb swizzling (equivalent to dvec4.wxzz).
        /// </summary>
        public dvec4 arbb => new dvec4(w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.wxzw swizzling.
        /// </summary>
        public dvec4 wxzw => new dvec4(w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.arba swizzling (equivalent to dvec4.wxzw).
        /// </summary>
        public dvec4 arba => new dvec4(w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.wxw swizzling.
        /// </summary>
        public dvec3 wxw => new dvec3(w, x, w);
        
        /// <summary>
        /// Returns dvec4.ara swizzling (equivalent to dvec4.wxw).
        /// </summary>
        public dvec3 ara => new dvec3(w, x, w);
        
        /// <summary>
        /// Returns dvec4.wxwx swizzling.
        /// </summary>
        public dvec4 wxwx => new dvec4(w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.arar swizzling (equivalent to dvec4.wxwx).
        /// </summary>
        public dvec4 arar => new dvec4(w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.wxwy swizzling.
        /// </summary>
        public dvec4 wxwy => new dvec4(w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.arag swizzling (equivalent to dvec4.wxwy).
        /// </summary>
        public dvec4 arag => new dvec4(w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.wxwz swizzling.
        /// </summary>
        public dvec4 wxwz => new dvec4(w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.arab swizzling (equivalent to dvec4.wxwz).
        /// </summary>
        public dvec4 arab => new dvec4(w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.wxww swizzling.
        /// </summary>
        public dvec4 wxww => new dvec4(w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.araa swizzling (equivalent to dvec4.wxww).
        /// </summary>
        public dvec4 araa => new dvec4(w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.wy swizzling.
        /// </summary>
        public dvec2 wy => new dvec2(w, y);
        
        /// <summary>
        /// Returns dvec4.ag swizzling (equivalent to dvec4.wy).
        /// </summary>
        public dvec2 ag => new dvec2(w, y);
        
        /// <summary>
        /// Returns dvec4.wyx swizzling.
        /// </summary>
        public dvec3 wyx => new dvec3(w, y, x);
        
        /// <summary>
        /// Returns dvec4.agr swizzling (equivalent to dvec4.wyx).
        /// </summary>
        public dvec3 agr => new dvec3(w, y, x);
        
        /// <summary>
        /// Returns dvec4.wyxx swizzling.
        /// </summary>
        public dvec4 wyxx => new dvec4(w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.agrr swizzling (equivalent to dvec4.wyxx).
        /// </summary>
        public dvec4 agrr => new dvec4(w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.wyxy swizzling.
        /// </summary>
        public dvec4 wyxy => new dvec4(w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.agrg swizzling (equivalent to dvec4.wyxy).
        /// </summary>
        public dvec4 agrg => new dvec4(w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.wyxz swizzling.
        /// </summary>
        public dvec4 wyxz => new dvec4(w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.agrb swizzling (equivalent to dvec4.wyxz).
        /// </summary>
        public dvec4 agrb => new dvec4(w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.wyxw swizzling.
        /// </summary>
        public dvec4 wyxw => new dvec4(w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.agra swizzling (equivalent to dvec4.wyxw).
        /// </summary>
        public dvec4 agra => new dvec4(w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.wyy swizzling.
        /// </summary>
        public dvec3 wyy => new dvec3(w, y, y);
        
        /// <summary>
        /// Returns dvec4.agg swizzling (equivalent to dvec4.wyy).
        /// </summary>
        public dvec3 agg => new dvec3(w, y, y);
        
        /// <summary>
        /// Returns dvec4.wyyx swizzling.
        /// </summary>
        public dvec4 wyyx => new dvec4(w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.aggr swizzling (equivalent to dvec4.wyyx).
        /// </summary>
        public dvec4 aggr => new dvec4(w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.wyyy swizzling.
        /// </summary>
        public dvec4 wyyy => new dvec4(w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.aggg swizzling (equivalent to dvec4.wyyy).
        /// </summary>
        public dvec4 aggg => new dvec4(w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.wyyz swizzling.
        /// </summary>
        public dvec4 wyyz => new dvec4(w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.aggb swizzling (equivalent to dvec4.wyyz).
        /// </summary>
        public dvec4 aggb => new dvec4(w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.wyyw swizzling.
        /// </summary>
        public dvec4 wyyw => new dvec4(w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.agga swizzling (equivalent to dvec4.wyyw).
        /// </summary>
        public dvec4 agga => new dvec4(w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.wyz swizzling.
        /// </summary>
        public dvec3 wyz => new dvec3(w, y, z);
        
        /// <summary>
        /// Returns dvec4.agb swizzling (equivalent to dvec4.wyz).
        /// </summary>
        public dvec3 agb => new dvec3(w, y, z);
        
        /// <summary>
        /// Returns dvec4.wyzx swizzling.
        /// </summary>
        public dvec4 wyzx => new dvec4(w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.agbr swizzling (equivalent to dvec4.wyzx).
        /// </summary>
        public dvec4 agbr => new dvec4(w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.wyzy swizzling.
        /// </summary>
        public dvec4 wyzy => new dvec4(w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.agbg swizzling (equivalent to dvec4.wyzy).
        /// </summary>
        public dvec4 agbg => new dvec4(w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.wyzz swizzling.
        /// </summary>
        public dvec4 wyzz => new dvec4(w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.agbb swizzling (equivalent to dvec4.wyzz).
        /// </summary>
        public dvec4 agbb => new dvec4(w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.wyzw swizzling.
        /// </summary>
        public dvec4 wyzw => new dvec4(w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.agba swizzling (equivalent to dvec4.wyzw).
        /// </summary>
        public dvec4 agba => new dvec4(w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.wyw swizzling.
        /// </summary>
        public dvec3 wyw => new dvec3(w, y, w);
        
        /// <summary>
        /// Returns dvec4.aga swizzling (equivalent to dvec4.wyw).
        /// </summary>
        public dvec3 aga => new dvec3(w, y, w);
        
        /// <summary>
        /// Returns dvec4.wywx swizzling.
        /// </summary>
        public dvec4 wywx => new dvec4(w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.agar swizzling (equivalent to dvec4.wywx).
        /// </summary>
        public dvec4 agar => new dvec4(w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.wywy swizzling.
        /// </summary>
        public dvec4 wywy => new dvec4(w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.agag swizzling (equivalent to dvec4.wywy).
        /// </summary>
        public dvec4 agag => new dvec4(w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.wywz swizzling.
        /// </summary>
        public dvec4 wywz => new dvec4(w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.agab swizzling (equivalent to dvec4.wywz).
        /// </summary>
        public dvec4 agab => new dvec4(w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.wyww swizzling.
        /// </summary>
        public dvec4 wyww => new dvec4(w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.agaa swizzling (equivalent to dvec4.wyww).
        /// </summary>
        public dvec4 agaa => new dvec4(w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.wz swizzling.
        /// </summary>
        public dvec2 wz => new dvec2(w, z);
        
        /// <summary>
        /// Returns dvec4.ab swizzling (equivalent to dvec4.wz).
        /// </summary>
        public dvec2 ab => new dvec2(w, z);
        
        /// <summary>
        /// Returns dvec4.wzx swizzling.
        /// </summary>
        public dvec3 wzx => new dvec3(w, z, x);
        
        /// <summary>
        /// Returns dvec4.abr swizzling (equivalent to dvec4.wzx).
        /// </summary>
        public dvec3 abr => new dvec3(w, z, x);
        
        /// <summary>
        /// Returns dvec4.wzxx swizzling.
        /// </summary>
        public dvec4 wzxx => new dvec4(w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.abrr swizzling (equivalent to dvec4.wzxx).
        /// </summary>
        public dvec4 abrr => new dvec4(w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.wzxy swizzling.
        /// </summary>
        public dvec4 wzxy => new dvec4(w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.abrg swizzling (equivalent to dvec4.wzxy).
        /// </summary>
        public dvec4 abrg => new dvec4(w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.wzxz swizzling.
        /// </summary>
        public dvec4 wzxz => new dvec4(w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.abrb swizzling (equivalent to dvec4.wzxz).
        /// </summary>
        public dvec4 abrb => new dvec4(w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.wzxw swizzling.
        /// </summary>
        public dvec4 wzxw => new dvec4(w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.abra swizzling (equivalent to dvec4.wzxw).
        /// </summary>
        public dvec4 abra => new dvec4(w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.wzy swizzling.
        /// </summary>
        public dvec3 wzy => new dvec3(w, z, y);
        
        /// <summary>
        /// Returns dvec4.abg swizzling (equivalent to dvec4.wzy).
        /// </summary>
        public dvec3 abg => new dvec3(w, z, y);
        
        /// <summary>
        /// Returns dvec4.wzyx swizzling.
        /// </summary>
        public dvec4 wzyx => new dvec4(w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.abgr swizzling (equivalent to dvec4.wzyx).
        /// </summary>
        public dvec4 abgr => new dvec4(w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.wzyy swizzling.
        /// </summary>
        public dvec4 wzyy => new dvec4(w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.abgg swizzling (equivalent to dvec4.wzyy).
        /// </summary>
        public dvec4 abgg => new dvec4(w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.wzyz swizzling.
        /// </summary>
        public dvec4 wzyz => new dvec4(w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.abgb swizzling (equivalent to dvec4.wzyz).
        /// </summary>
        public dvec4 abgb => new dvec4(w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.wzyw swizzling.
        /// </summary>
        public dvec4 wzyw => new dvec4(w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.abga swizzling (equivalent to dvec4.wzyw).
        /// </summary>
        public dvec4 abga => new dvec4(w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.wzz swizzling.
        /// </summary>
        public dvec3 wzz => new dvec3(w, z, z);
        
        /// <summary>
        /// Returns dvec4.abb swizzling (equivalent to dvec4.wzz).
        /// </summary>
        public dvec3 abb => new dvec3(w, z, z);
        
        /// <summary>
        /// Returns dvec4.wzzx swizzling.
        /// </summary>
        public dvec4 wzzx => new dvec4(w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.abbr swizzling (equivalent to dvec4.wzzx).
        /// </summary>
        public dvec4 abbr => new dvec4(w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.wzzy swizzling.
        /// </summary>
        public dvec4 wzzy => new dvec4(w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.abbg swizzling (equivalent to dvec4.wzzy).
        /// </summary>
        public dvec4 abbg => new dvec4(w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.wzzz swizzling.
        /// </summary>
        public dvec4 wzzz => new dvec4(w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.abbb swizzling (equivalent to dvec4.wzzz).
        /// </summary>
        public dvec4 abbb => new dvec4(w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.wzzw swizzling.
        /// </summary>
        public dvec4 wzzw => new dvec4(w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.abba swizzling (equivalent to dvec4.wzzw).
        /// </summary>
        public dvec4 abba => new dvec4(w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.wzw swizzling.
        /// </summary>
        public dvec3 wzw => new dvec3(w, z, w);
        
        /// <summary>
        /// Returns dvec4.aba swizzling (equivalent to dvec4.wzw).
        /// </summary>
        public dvec3 aba => new dvec3(w, z, w);
        
        /// <summary>
        /// Returns dvec4.wzwx swizzling.
        /// </summary>
        public dvec4 wzwx => new dvec4(w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.abar swizzling (equivalent to dvec4.wzwx).
        /// </summary>
        public dvec4 abar => new dvec4(w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.wzwy swizzling.
        /// </summary>
        public dvec4 wzwy => new dvec4(w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.abag swizzling (equivalent to dvec4.wzwy).
        /// </summary>
        public dvec4 abag => new dvec4(w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.wzwz swizzling.
        /// </summary>
        public dvec4 wzwz => new dvec4(w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.abab swizzling (equivalent to dvec4.wzwz).
        /// </summary>
        public dvec4 abab => new dvec4(w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.wzww swizzling.
        /// </summary>
        public dvec4 wzww => new dvec4(w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.abaa swizzling (equivalent to dvec4.wzww).
        /// </summary>
        public dvec4 abaa => new dvec4(w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.ww swizzling.
        /// </summary>
        public dvec2 ww => new dvec2(w, w);
        
        /// <summary>
        /// Returns dvec4.aa swizzling (equivalent to dvec4.ww).
        /// </summary>
        public dvec2 aa => new dvec2(w, w);
        
        /// <summary>
        /// Returns dvec4.wwx swizzling.
        /// </summary>
        public dvec3 wwx => new dvec3(w, w, x);
        
        /// <summary>
        /// Returns dvec4.aar swizzling (equivalent to dvec4.wwx).
        /// </summary>
        public dvec3 aar => new dvec3(w, w, x);
        
        /// <summary>
        /// Returns dvec4.wwxx swizzling.
        /// </summary>
        public dvec4 wwxx => new dvec4(w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.aarr swizzling (equivalent to dvec4.wwxx).
        /// </summary>
        public dvec4 aarr => new dvec4(w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.wwxy swizzling.
        /// </summary>
        public dvec4 wwxy => new dvec4(w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.aarg swizzling (equivalent to dvec4.wwxy).
        /// </summary>
        public dvec4 aarg => new dvec4(w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.wwxz swizzling.
        /// </summary>
        public dvec4 wwxz => new dvec4(w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.aarb swizzling (equivalent to dvec4.wwxz).
        /// </summary>
        public dvec4 aarb => new dvec4(w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.wwxw swizzling.
        /// </summary>
        public dvec4 wwxw => new dvec4(w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.aara swizzling (equivalent to dvec4.wwxw).
        /// </summary>
        public dvec4 aara => new dvec4(w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.wwy swizzling.
        /// </summary>
        public dvec3 wwy => new dvec3(w, w, y);
        
        /// <summary>
        /// Returns dvec4.aag swizzling (equivalent to dvec4.wwy).
        /// </summary>
        public dvec3 aag => new dvec3(w, w, y);
        
        /// <summary>
        /// Returns dvec4.wwyx swizzling.
        /// </summary>
        public dvec4 wwyx => new dvec4(w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.aagr swizzling (equivalent to dvec4.wwyx).
        /// </summary>
        public dvec4 aagr => new dvec4(w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.wwyy swizzling.
        /// </summary>
        public dvec4 wwyy => new dvec4(w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.aagg swizzling (equivalent to dvec4.wwyy).
        /// </summary>
        public dvec4 aagg => new dvec4(w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.wwyz swizzling.
        /// </summary>
        public dvec4 wwyz => new dvec4(w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.aagb swizzling (equivalent to dvec4.wwyz).
        /// </summary>
        public dvec4 aagb => new dvec4(w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.wwyw swizzling.
        /// </summary>
        public dvec4 wwyw => new dvec4(w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.aaga swizzling (equivalent to dvec4.wwyw).
        /// </summary>
        public dvec4 aaga => new dvec4(w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.wwz swizzling.
        /// </summary>
        public dvec3 wwz => new dvec3(w, w, z);
        
        /// <summary>
        /// Returns dvec4.aab swizzling (equivalent to dvec4.wwz).
        /// </summary>
        public dvec3 aab => new dvec3(w, w, z);
        
        /// <summary>
        /// Returns dvec4.wwzx swizzling.
        /// </summary>
        public dvec4 wwzx => new dvec4(w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.aabr swizzling (equivalent to dvec4.wwzx).
        /// </summary>
        public dvec4 aabr => new dvec4(w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.wwzy swizzling.
        /// </summary>
        public dvec4 wwzy => new dvec4(w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.aabg swizzling (equivalent to dvec4.wwzy).
        /// </summary>
        public dvec4 aabg => new dvec4(w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.wwzz swizzling.
        /// </summary>
        public dvec4 wwzz => new dvec4(w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.aabb swizzling (equivalent to dvec4.wwzz).
        /// </summary>
        public dvec4 aabb => new dvec4(w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.wwzw swizzling.
        /// </summary>
        public dvec4 wwzw => new dvec4(w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.aaba swizzling (equivalent to dvec4.wwzw).
        /// </summary>
        public dvec4 aaba => new dvec4(w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.www swizzling.
        /// </summary>
        public dvec3 www => new dvec3(w, w, w);
        
        /// <summary>
        /// Returns dvec4.aaa swizzling (equivalent to dvec4.www).
        /// </summary>
        public dvec3 aaa => new dvec3(w, w, w);
        
        /// <summary>
        /// Returns dvec4.wwwx swizzling.
        /// </summary>
        public dvec4 wwwx => new dvec4(w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.aaar swizzling (equivalent to dvec4.wwwx).
        /// </summary>
        public dvec4 aaar => new dvec4(w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.wwwy swizzling.
        /// </summary>
        public dvec4 wwwy => new dvec4(w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.aaag swizzling (equivalent to dvec4.wwwy).
        /// </summary>
        public dvec4 aaag => new dvec4(w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.wwwz swizzling.
        /// </summary>
        public dvec4 wwwz => new dvec4(w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.aaab swizzling (equivalent to dvec4.wwwz).
        /// </summary>
        public dvec4 aaab => new dvec4(w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.wwww swizzling.
        /// </summary>
        public dvec4 wwww => new dvec4(w, w, w, w);
        
        /// <summary>
        /// Returns dvec4.aaaa swizzling (equivalent to dvec4.wwww).
        /// </summary>
        public dvec4 aaaa => new dvec4(w, w, w, w);

        #endregion

    }
}
