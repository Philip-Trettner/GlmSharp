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
    /// Temporary vector of type bool with 4 components, used for implementing swizzling for bvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_bvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly bool z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly bool w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_bvec4.
        /// </summary>
        internal swizzle_bvec4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns bvec4.xx swizzling.
        /// </summary>
        public bvec2 xx => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec4.rr swizzling (equivalent to bvec4.xx).
        /// </summary>
        public bvec2 rr => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec4.xxx swizzling.
        /// </summary>
        public bvec3 xxx => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec4.rrr swizzling (equivalent to bvec4.xxx).
        /// </summary>
        public bvec3 rrr => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec4.xxxx swizzling.
        /// </summary>
        public bvec4 xxxx => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.rrrr swizzling (equivalent to bvec4.xxxx).
        /// </summary>
        public bvec4 rrrr => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.xxxy swizzling.
        /// </summary>
        public bvec4 xxxy => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.rrrg swizzling (equivalent to bvec4.xxxy).
        /// </summary>
        public bvec4 rrrg => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.xxxz swizzling.
        /// </summary>
        public bvec4 xxxz => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.rrrb swizzling (equivalent to bvec4.xxxz).
        /// </summary>
        public bvec4 rrrb => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.xxxw swizzling.
        /// </summary>
        public bvec4 xxxw => new bvec4(x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.rrra swizzling (equivalent to bvec4.xxxw).
        /// </summary>
        public bvec4 rrra => new bvec4(x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.xxy swizzling.
        /// </summary>
        public bvec3 xxy => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec4.rrg swizzling (equivalent to bvec4.xxy).
        /// </summary>
        public bvec3 rrg => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec4.xxyx swizzling.
        /// </summary>
        public bvec4 xxyx => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.rrgr swizzling (equivalent to bvec4.xxyx).
        /// </summary>
        public bvec4 rrgr => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.xxyy swizzling.
        /// </summary>
        public bvec4 xxyy => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.rrgg swizzling (equivalent to bvec4.xxyy).
        /// </summary>
        public bvec4 rrgg => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.xxyz swizzling.
        /// </summary>
        public bvec4 xxyz => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.rrgb swizzling (equivalent to bvec4.xxyz).
        /// </summary>
        public bvec4 rrgb => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.xxyw swizzling.
        /// </summary>
        public bvec4 xxyw => new bvec4(x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.rrga swizzling (equivalent to bvec4.xxyw).
        /// </summary>
        public bvec4 rrga => new bvec4(x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.xxz swizzling.
        /// </summary>
        public bvec3 xxz => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec4.rrb swizzling (equivalent to bvec4.xxz).
        /// </summary>
        public bvec3 rrb => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec4.xxzx swizzling.
        /// </summary>
        public bvec4 xxzx => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.rrbr swizzling (equivalent to bvec4.xxzx).
        /// </summary>
        public bvec4 rrbr => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.xxzy swizzling.
        /// </summary>
        public bvec4 xxzy => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.rrbg swizzling (equivalent to bvec4.xxzy).
        /// </summary>
        public bvec4 rrbg => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.xxzz swizzling.
        /// </summary>
        public bvec4 xxzz => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.rrbb swizzling (equivalent to bvec4.xxzz).
        /// </summary>
        public bvec4 rrbb => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.xxzw swizzling.
        /// </summary>
        public bvec4 xxzw => new bvec4(x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.rrba swizzling (equivalent to bvec4.xxzw).
        /// </summary>
        public bvec4 rrba => new bvec4(x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.xxw swizzling.
        /// </summary>
        public bvec3 xxw => new bvec3(x, x, w);
        
        /// <summary>
        /// Returns bvec4.rra swizzling (equivalent to bvec4.xxw).
        /// </summary>
        public bvec3 rra => new bvec3(x, x, w);
        
        /// <summary>
        /// Returns bvec4.xxwx swizzling.
        /// </summary>
        public bvec4 xxwx => new bvec4(x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.rrar swizzling (equivalent to bvec4.xxwx).
        /// </summary>
        public bvec4 rrar => new bvec4(x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.xxwy swizzling.
        /// </summary>
        public bvec4 xxwy => new bvec4(x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.rrag swizzling (equivalent to bvec4.xxwy).
        /// </summary>
        public bvec4 rrag => new bvec4(x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.xxwz swizzling.
        /// </summary>
        public bvec4 xxwz => new bvec4(x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.rrab swizzling (equivalent to bvec4.xxwz).
        /// </summary>
        public bvec4 rrab => new bvec4(x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.xxww swizzling.
        /// </summary>
        public bvec4 xxww => new bvec4(x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.rraa swizzling (equivalent to bvec4.xxww).
        /// </summary>
        public bvec4 rraa => new bvec4(x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.xy swizzling.
        /// </summary>
        public bvec2 xy => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec4.rg swizzling (equivalent to bvec4.xy).
        /// </summary>
        public bvec2 rg => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec4.xyx swizzling.
        /// </summary>
        public bvec3 xyx => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec4.rgr swizzling (equivalent to bvec4.xyx).
        /// </summary>
        public bvec3 rgr => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec4.xyxx swizzling.
        /// </summary>
        public bvec4 xyxx => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.rgrr swizzling (equivalent to bvec4.xyxx).
        /// </summary>
        public bvec4 rgrr => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.xyxy swizzling.
        /// </summary>
        public bvec4 xyxy => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.rgrg swizzling (equivalent to bvec4.xyxy).
        /// </summary>
        public bvec4 rgrg => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.xyxz swizzling.
        /// </summary>
        public bvec4 xyxz => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.rgrb swizzling (equivalent to bvec4.xyxz).
        /// </summary>
        public bvec4 rgrb => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.xyxw swizzling.
        /// </summary>
        public bvec4 xyxw => new bvec4(x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.rgra swizzling (equivalent to bvec4.xyxw).
        /// </summary>
        public bvec4 rgra => new bvec4(x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.xyy swizzling.
        /// </summary>
        public bvec3 xyy => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec4.rgg swizzling (equivalent to bvec4.xyy).
        /// </summary>
        public bvec3 rgg => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec4.xyyx swizzling.
        /// </summary>
        public bvec4 xyyx => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.rggr swizzling (equivalent to bvec4.xyyx).
        /// </summary>
        public bvec4 rggr => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.xyyy swizzling.
        /// </summary>
        public bvec4 xyyy => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.rggg swizzling (equivalent to bvec4.xyyy).
        /// </summary>
        public bvec4 rggg => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.xyyz swizzling.
        /// </summary>
        public bvec4 xyyz => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.rggb swizzling (equivalent to bvec4.xyyz).
        /// </summary>
        public bvec4 rggb => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.xyyw swizzling.
        /// </summary>
        public bvec4 xyyw => new bvec4(x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.rgga swizzling (equivalent to bvec4.xyyw).
        /// </summary>
        public bvec4 rgga => new bvec4(x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.xyz swizzling.
        /// </summary>
        public bvec3 xyz => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec4.rgb swizzling (equivalent to bvec4.xyz).
        /// </summary>
        public bvec3 rgb => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec4.xyzx swizzling.
        /// </summary>
        public bvec4 xyzx => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.rgbr swizzling (equivalent to bvec4.xyzx).
        /// </summary>
        public bvec4 rgbr => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.xyzy swizzling.
        /// </summary>
        public bvec4 xyzy => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.rgbg swizzling (equivalent to bvec4.xyzy).
        /// </summary>
        public bvec4 rgbg => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.xyzz swizzling.
        /// </summary>
        public bvec4 xyzz => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.rgbb swizzling (equivalent to bvec4.xyzz).
        /// </summary>
        public bvec4 rgbb => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.xyzw swizzling.
        /// </summary>
        public bvec4 xyzw => new bvec4(x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.rgba swizzling (equivalent to bvec4.xyzw).
        /// </summary>
        public bvec4 rgba => new bvec4(x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.xyw swizzling.
        /// </summary>
        public bvec3 xyw => new bvec3(x, y, w);
        
        /// <summary>
        /// Returns bvec4.rga swizzling (equivalent to bvec4.xyw).
        /// </summary>
        public bvec3 rga => new bvec3(x, y, w);
        
        /// <summary>
        /// Returns bvec4.xywx swizzling.
        /// </summary>
        public bvec4 xywx => new bvec4(x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.rgar swizzling (equivalent to bvec4.xywx).
        /// </summary>
        public bvec4 rgar => new bvec4(x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.xywy swizzling.
        /// </summary>
        public bvec4 xywy => new bvec4(x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.rgag swizzling (equivalent to bvec4.xywy).
        /// </summary>
        public bvec4 rgag => new bvec4(x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.xywz swizzling.
        /// </summary>
        public bvec4 xywz => new bvec4(x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.rgab swizzling (equivalent to bvec4.xywz).
        /// </summary>
        public bvec4 rgab => new bvec4(x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.xyww swizzling.
        /// </summary>
        public bvec4 xyww => new bvec4(x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.rgaa swizzling (equivalent to bvec4.xyww).
        /// </summary>
        public bvec4 rgaa => new bvec4(x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.xz swizzling.
        /// </summary>
        public bvec2 xz => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec4.rb swizzling (equivalent to bvec4.xz).
        /// </summary>
        public bvec2 rb => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec4.xzx swizzling.
        /// </summary>
        public bvec3 xzx => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec4.rbr swizzling (equivalent to bvec4.xzx).
        /// </summary>
        public bvec3 rbr => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec4.xzxx swizzling.
        /// </summary>
        public bvec4 xzxx => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.rbrr swizzling (equivalent to bvec4.xzxx).
        /// </summary>
        public bvec4 rbrr => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.xzxy swizzling.
        /// </summary>
        public bvec4 xzxy => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.rbrg swizzling (equivalent to bvec4.xzxy).
        /// </summary>
        public bvec4 rbrg => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.xzxz swizzling.
        /// </summary>
        public bvec4 xzxz => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.rbrb swizzling (equivalent to bvec4.xzxz).
        /// </summary>
        public bvec4 rbrb => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.xzxw swizzling.
        /// </summary>
        public bvec4 xzxw => new bvec4(x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.rbra swizzling (equivalent to bvec4.xzxw).
        /// </summary>
        public bvec4 rbra => new bvec4(x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.xzy swizzling.
        /// </summary>
        public bvec3 xzy => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec4.rbg swizzling (equivalent to bvec4.xzy).
        /// </summary>
        public bvec3 rbg => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec4.xzyx swizzling.
        /// </summary>
        public bvec4 xzyx => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.rbgr swizzling (equivalent to bvec4.xzyx).
        /// </summary>
        public bvec4 rbgr => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.xzyy swizzling.
        /// </summary>
        public bvec4 xzyy => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.rbgg swizzling (equivalent to bvec4.xzyy).
        /// </summary>
        public bvec4 rbgg => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.xzyz swizzling.
        /// </summary>
        public bvec4 xzyz => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.rbgb swizzling (equivalent to bvec4.xzyz).
        /// </summary>
        public bvec4 rbgb => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.xzyw swizzling.
        /// </summary>
        public bvec4 xzyw => new bvec4(x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.rbga swizzling (equivalent to bvec4.xzyw).
        /// </summary>
        public bvec4 rbga => new bvec4(x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.xzz swizzling.
        /// </summary>
        public bvec3 xzz => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec4.rbb swizzling (equivalent to bvec4.xzz).
        /// </summary>
        public bvec3 rbb => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec4.xzzx swizzling.
        /// </summary>
        public bvec4 xzzx => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.rbbr swizzling (equivalent to bvec4.xzzx).
        /// </summary>
        public bvec4 rbbr => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.xzzy swizzling.
        /// </summary>
        public bvec4 xzzy => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.rbbg swizzling (equivalent to bvec4.xzzy).
        /// </summary>
        public bvec4 rbbg => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.xzzz swizzling.
        /// </summary>
        public bvec4 xzzz => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.rbbb swizzling (equivalent to bvec4.xzzz).
        /// </summary>
        public bvec4 rbbb => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.xzzw swizzling.
        /// </summary>
        public bvec4 xzzw => new bvec4(x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.rbba swizzling (equivalent to bvec4.xzzw).
        /// </summary>
        public bvec4 rbba => new bvec4(x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.xzw swizzling.
        /// </summary>
        public bvec3 xzw => new bvec3(x, z, w);
        
        /// <summary>
        /// Returns bvec4.rba swizzling (equivalent to bvec4.xzw).
        /// </summary>
        public bvec3 rba => new bvec3(x, z, w);
        
        /// <summary>
        /// Returns bvec4.xzwx swizzling.
        /// </summary>
        public bvec4 xzwx => new bvec4(x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.rbar swizzling (equivalent to bvec4.xzwx).
        /// </summary>
        public bvec4 rbar => new bvec4(x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.xzwy swizzling.
        /// </summary>
        public bvec4 xzwy => new bvec4(x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.rbag swizzling (equivalent to bvec4.xzwy).
        /// </summary>
        public bvec4 rbag => new bvec4(x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.xzwz swizzling.
        /// </summary>
        public bvec4 xzwz => new bvec4(x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.rbab swizzling (equivalent to bvec4.xzwz).
        /// </summary>
        public bvec4 rbab => new bvec4(x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.xzww swizzling.
        /// </summary>
        public bvec4 xzww => new bvec4(x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.rbaa swizzling (equivalent to bvec4.xzww).
        /// </summary>
        public bvec4 rbaa => new bvec4(x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.xw swizzling.
        /// </summary>
        public bvec2 xw => new bvec2(x, w);
        
        /// <summary>
        /// Returns bvec4.ra swizzling (equivalent to bvec4.xw).
        /// </summary>
        public bvec2 ra => new bvec2(x, w);
        
        /// <summary>
        /// Returns bvec4.xwx swizzling.
        /// </summary>
        public bvec3 xwx => new bvec3(x, w, x);
        
        /// <summary>
        /// Returns bvec4.rar swizzling (equivalent to bvec4.xwx).
        /// </summary>
        public bvec3 rar => new bvec3(x, w, x);
        
        /// <summary>
        /// Returns bvec4.xwxx swizzling.
        /// </summary>
        public bvec4 xwxx => new bvec4(x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.rarr swizzling (equivalent to bvec4.xwxx).
        /// </summary>
        public bvec4 rarr => new bvec4(x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.xwxy swizzling.
        /// </summary>
        public bvec4 xwxy => new bvec4(x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.rarg swizzling (equivalent to bvec4.xwxy).
        /// </summary>
        public bvec4 rarg => new bvec4(x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.xwxz swizzling.
        /// </summary>
        public bvec4 xwxz => new bvec4(x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.rarb swizzling (equivalent to bvec4.xwxz).
        /// </summary>
        public bvec4 rarb => new bvec4(x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.xwxw swizzling.
        /// </summary>
        public bvec4 xwxw => new bvec4(x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.rara swizzling (equivalent to bvec4.xwxw).
        /// </summary>
        public bvec4 rara => new bvec4(x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.xwy swizzling.
        /// </summary>
        public bvec3 xwy => new bvec3(x, w, y);
        
        /// <summary>
        /// Returns bvec4.rag swizzling (equivalent to bvec4.xwy).
        /// </summary>
        public bvec3 rag => new bvec3(x, w, y);
        
        /// <summary>
        /// Returns bvec4.xwyx swizzling.
        /// </summary>
        public bvec4 xwyx => new bvec4(x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.ragr swizzling (equivalent to bvec4.xwyx).
        /// </summary>
        public bvec4 ragr => new bvec4(x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.xwyy swizzling.
        /// </summary>
        public bvec4 xwyy => new bvec4(x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.ragg swizzling (equivalent to bvec4.xwyy).
        /// </summary>
        public bvec4 ragg => new bvec4(x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.xwyz swizzling.
        /// </summary>
        public bvec4 xwyz => new bvec4(x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.ragb swizzling (equivalent to bvec4.xwyz).
        /// </summary>
        public bvec4 ragb => new bvec4(x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.xwyw swizzling.
        /// </summary>
        public bvec4 xwyw => new bvec4(x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.raga swizzling (equivalent to bvec4.xwyw).
        /// </summary>
        public bvec4 raga => new bvec4(x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.xwz swizzling.
        /// </summary>
        public bvec3 xwz => new bvec3(x, w, z);
        
        /// <summary>
        /// Returns bvec4.rab swizzling (equivalent to bvec4.xwz).
        /// </summary>
        public bvec3 rab => new bvec3(x, w, z);
        
        /// <summary>
        /// Returns bvec4.xwzx swizzling.
        /// </summary>
        public bvec4 xwzx => new bvec4(x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.rabr swizzling (equivalent to bvec4.xwzx).
        /// </summary>
        public bvec4 rabr => new bvec4(x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.xwzy swizzling.
        /// </summary>
        public bvec4 xwzy => new bvec4(x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.rabg swizzling (equivalent to bvec4.xwzy).
        /// </summary>
        public bvec4 rabg => new bvec4(x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.xwzz swizzling.
        /// </summary>
        public bvec4 xwzz => new bvec4(x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.rabb swizzling (equivalent to bvec4.xwzz).
        /// </summary>
        public bvec4 rabb => new bvec4(x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.xwzw swizzling.
        /// </summary>
        public bvec4 xwzw => new bvec4(x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.raba swizzling (equivalent to bvec4.xwzw).
        /// </summary>
        public bvec4 raba => new bvec4(x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.xww swizzling.
        /// </summary>
        public bvec3 xww => new bvec3(x, w, w);
        
        /// <summary>
        /// Returns bvec4.raa swizzling (equivalent to bvec4.xww).
        /// </summary>
        public bvec3 raa => new bvec3(x, w, w);
        
        /// <summary>
        /// Returns bvec4.xwwx swizzling.
        /// </summary>
        public bvec4 xwwx => new bvec4(x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.raar swizzling (equivalent to bvec4.xwwx).
        /// </summary>
        public bvec4 raar => new bvec4(x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.xwwy swizzling.
        /// </summary>
        public bvec4 xwwy => new bvec4(x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.raag swizzling (equivalent to bvec4.xwwy).
        /// </summary>
        public bvec4 raag => new bvec4(x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.xwwz swizzling.
        /// </summary>
        public bvec4 xwwz => new bvec4(x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.raab swizzling (equivalent to bvec4.xwwz).
        /// </summary>
        public bvec4 raab => new bvec4(x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.xwww swizzling.
        /// </summary>
        public bvec4 xwww => new bvec4(x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.raaa swizzling (equivalent to bvec4.xwww).
        /// </summary>
        public bvec4 raaa => new bvec4(x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.yx swizzling.
        /// </summary>
        public bvec2 yx => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec4.gr swizzling (equivalent to bvec4.yx).
        /// </summary>
        public bvec2 gr => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec4.yxx swizzling.
        /// </summary>
        public bvec3 yxx => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec4.grr swizzling (equivalent to bvec4.yxx).
        /// </summary>
        public bvec3 grr => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec4.yxxx swizzling.
        /// </summary>
        public bvec4 yxxx => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.grrr swizzling (equivalent to bvec4.yxxx).
        /// </summary>
        public bvec4 grrr => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.yxxy swizzling.
        /// </summary>
        public bvec4 yxxy => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.grrg swizzling (equivalent to bvec4.yxxy).
        /// </summary>
        public bvec4 grrg => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.yxxz swizzling.
        /// </summary>
        public bvec4 yxxz => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.grrb swizzling (equivalent to bvec4.yxxz).
        /// </summary>
        public bvec4 grrb => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.yxxw swizzling.
        /// </summary>
        public bvec4 yxxw => new bvec4(y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.grra swizzling (equivalent to bvec4.yxxw).
        /// </summary>
        public bvec4 grra => new bvec4(y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.yxy swizzling.
        /// </summary>
        public bvec3 yxy => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec4.grg swizzling (equivalent to bvec4.yxy).
        /// </summary>
        public bvec3 grg => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec4.yxyx swizzling.
        /// </summary>
        public bvec4 yxyx => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.grgr swizzling (equivalent to bvec4.yxyx).
        /// </summary>
        public bvec4 grgr => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.yxyy swizzling.
        /// </summary>
        public bvec4 yxyy => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.grgg swizzling (equivalent to bvec4.yxyy).
        /// </summary>
        public bvec4 grgg => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.yxyz swizzling.
        /// </summary>
        public bvec4 yxyz => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.grgb swizzling (equivalent to bvec4.yxyz).
        /// </summary>
        public bvec4 grgb => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.yxyw swizzling.
        /// </summary>
        public bvec4 yxyw => new bvec4(y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.grga swizzling (equivalent to bvec4.yxyw).
        /// </summary>
        public bvec4 grga => new bvec4(y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.yxz swizzling.
        /// </summary>
        public bvec3 yxz => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec4.grb swizzling (equivalent to bvec4.yxz).
        /// </summary>
        public bvec3 grb => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec4.yxzx swizzling.
        /// </summary>
        public bvec4 yxzx => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.grbr swizzling (equivalent to bvec4.yxzx).
        /// </summary>
        public bvec4 grbr => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.yxzy swizzling.
        /// </summary>
        public bvec4 yxzy => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.grbg swizzling (equivalent to bvec4.yxzy).
        /// </summary>
        public bvec4 grbg => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.yxzz swizzling.
        /// </summary>
        public bvec4 yxzz => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.grbb swizzling (equivalent to bvec4.yxzz).
        /// </summary>
        public bvec4 grbb => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.yxzw swizzling.
        /// </summary>
        public bvec4 yxzw => new bvec4(y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.grba swizzling (equivalent to bvec4.yxzw).
        /// </summary>
        public bvec4 grba => new bvec4(y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.yxw swizzling.
        /// </summary>
        public bvec3 yxw => new bvec3(y, x, w);
        
        /// <summary>
        /// Returns bvec4.gra swizzling (equivalent to bvec4.yxw).
        /// </summary>
        public bvec3 gra => new bvec3(y, x, w);
        
        /// <summary>
        /// Returns bvec4.yxwx swizzling.
        /// </summary>
        public bvec4 yxwx => new bvec4(y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.grar swizzling (equivalent to bvec4.yxwx).
        /// </summary>
        public bvec4 grar => new bvec4(y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.yxwy swizzling.
        /// </summary>
        public bvec4 yxwy => new bvec4(y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.grag swizzling (equivalent to bvec4.yxwy).
        /// </summary>
        public bvec4 grag => new bvec4(y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.yxwz swizzling.
        /// </summary>
        public bvec4 yxwz => new bvec4(y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.grab swizzling (equivalent to bvec4.yxwz).
        /// </summary>
        public bvec4 grab => new bvec4(y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.yxww swizzling.
        /// </summary>
        public bvec4 yxww => new bvec4(y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.graa swizzling (equivalent to bvec4.yxww).
        /// </summary>
        public bvec4 graa => new bvec4(y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.yy swizzling.
        /// </summary>
        public bvec2 yy => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec4.gg swizzling (equivalent to bvec4.yy).
        /// </summary>
        public bvec2 gg => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec4.yyx swizzling.
        /// </summary>
        public bvec3 yyx => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec4.ggr swizzling (equivalent to bvec4.yyx).
        /// </summary>
        public bvec3 ggr => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec4.yyxx swizzling.
        /// </summary>
        public bvec4 yyxx => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.ggrr swizzling (equivalent to bvec4.yyxx).
        /// </summary>
        public bvec4 ggrr => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.yyxy swizzling.
        /// </summary>
        public bvec4 yyxy => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.ggrg swizzling (equivalent to bvec4.yyxy).
        /// </summary>
        public bvec4 ggrg => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.yyxz swizzling.
        /// </summary>
        public bvec4 yyxz => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.ggrb swizzling (equivalent to bvec4.yyxz).
        /// </summary>
        public bvec4 ggrb => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.yyxw swizzling.
        /// </summary>
        public bvec4 yyxw => new bvec4(y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.ggra swizzling (equivalent to bvec4.yyxw).
        /// </summary>
        public bvec4 ggra => new bvec4(y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.yyy swizzling.
        /// </summary>
        public bvec3 yyy => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec4.ggg swizzling (equivalent to bvec4.yyy).
        /// </summary>
        public bvec3 ggg => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec4.yyyx swizzling.
        /// </summary>
        public bvec4 yyyx => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.gggr swizzling (equivalent to bvec4.yyyx).
        /// </summary>
        public bvec4 gggr => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.yyyy swizzling.
        /// </summary>
        public bvec4 yyyy => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.gggg swizzling (equivalent to bvec4.yyyy).
        /// </summary>
        public bvec4 gggg => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.yyyz swizzling.
        /// </summary>
        public bvec4 yyyz => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.gggb swizzling (equivalent to bvec4.yyyz).
        /// </summary>
        public bvec4 gggb => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.yyyw swizzling.
        /// </summary>
        public bvec4 yyyw => new bvec4(y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.ggga swizzling (equivalent to bvec4.yyyw).
        /// </summary>
        public bvec4 ggga => new bvec4(y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.yyz swizzling.
        /// </summary>
        public bvec3 yyz => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec4.ggb swizzling (equivalent to bvec4.yyz).
        /// </summary>
        public bvec3 ggb => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec4.yyzx swizzling.
        /// </summary>
        public bvec4 yyzx => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.ggbr swizzling (equivalent to bvec4.yyzx).
        /// </summary>
        public bvec4 ggbr => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.yyzy swizzling.
        /// </summary>
        public bvec4 yyzy => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.ggbg swizzling (equivalent to bvec4.yyzy).
        /// </summary>
        public bvec4 ggbg => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.yyzz swizzling.
        /// </summary>
        public bvec4 yyzz => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.ggbb swizzling (equivalent to bvec4.yyzz).
        /// </summary>
        public bvec4 ggbb => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.yyzw swizzling.
        /// </summary>
        public bvec4 yyzw => new bvec4(y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.ggba swizzling (equivalent to bvec4.yyzw).
        /// </summary>
        public bvec4 ggba => new bvec4(y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.yyw swizzling.
        /// </summary>
        public bvec3 yyw => new bvec3(y, y, w);
        
        /// <summary>
        /// Returns bvec4.gga swizzling (equivalent to bvec4.yyw).
        /// </summary>
        public bvec3 gga => new bvec3(y, y, w);
        
        /// <summary>
        /// Returns bvec4.yywx swizzling.
        /// </summary>
        public bvec4 yywx => new bvec4(y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.ggar swizzling (equivalent to bvec4.yywx).
        /// </summary>
        public bvec4 ggar => new bvec4(y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.yywy swizzling.
        /// </summary>
        public bvec4 yywy => new bvec4(y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.ggag swizzling (equivalent to bvec4.yywy).
        /// </summary>
        public bvec4 ggag => new bvec4(y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.yywz swizzling.
        /// </summary>
        public bvec4 yywz => new bvec4(y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.ggab swizzling (equivalent to bvec4.yywz).
        /// </summary>
        public bvec4 ggab => new bvec4(y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.yyww swizzling.
        /// </summary>
        public bvec4 yyww => new bvec4(y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.ggaa swizzling (equivalent to bvec4.yyww).
        /// </summary>
        public bvec4 ggaa => new bvec4(y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.yz swizzling.
        /// </summary>
        public bvec2 yz => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec4.gb swizzling (equivalent to bvec4.yz).
        /// </summary>
        public bvec2 gb => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec4.yzx swizzling.
        /// </summary>
        public bvec3 yzx => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec4.gbr swizzling (equivalent to bvec4.yzx).
        /// </summary>
        public bvec3 gbr => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec4.yzxx swizzling.
        /// </summary>
        public bvec4 yzxx => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.gbrr swizzling (equivalent to bvec4.yzxx).
        /// </summary>
        public bvec4 gbrr => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.yzxy swizzling.
        /// </summary>
        public bvec4 yzxy => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.gbrg swizzling (equivalent to bvec4.yzxy).
        /// </summary>
        public bvec4 gbrg => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.yzxz swizzling.
        /// </summary>
        public bvec4 yzxz => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.gbrb swizzling (equivalent to bvec4.yzxz).
        /// </summary>
        public bvec4 gbrb => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.yzxw swizzling.
        /// </summary>
        public bvec4 yzxw => new bvec4(y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.gbra swizzling (equivalent to bvec4.yzxw).
        /// </summary>
        public bvec4 gbra => new bvec4(y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.yzy swizzling.
        /// </summary>
        public bvec3 yzy => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec4.gbg swizzling (equivalent to bvec4.yzy).
        /// </summary>
        public bvec3 gbg => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec4.yzyx swizzling.
        /// </summary>
        public bvec4 yzyx => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.gbgr swizzling (equivalent to bvec4.yzyx).
        /// </summary>
        public bvec4 gbgr => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.yzyy swizzling.
        /// </summary>
        public bvec4 yzyy => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.gbgg swizzling (equivalent to bvec4.yzyy).
        /// </summary>
        public bvec4 gbgg => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.yzyz swizzling.
        /// </summary>
        public bvec4 yzyz => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.gbgb swizzling (equivalent to bvec4.yzyz).
        /// </summary>
        public bvec4 gbgb => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.yzyw swizzling.
        /// </summary>
        public bvec4 yzyw => new bvec4(y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.gbga swizzling (equivalent to bvec4.yzyw).
        /// </summary>
        public bvec4 gbga => new bvec4(y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.yzz swizzling.
        /// </summary>
        public bvec3 yzz => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec4.gbb swizzling (equivalent to bvec4.yzz).
        /// </summary>
        public bvec3 gbb => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec4.yzzx swizzling.
        /// </summary>
        public bvec4 yzzx => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.gbbr swizzling (equivalent to bvec4.yzzx).
        /// </summary>
        public bvec4 gbbr => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.yzzy swizzling.
        /// </summary>
        public bvec4 yzzy => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.gbbg swizzling (equivalent to bvec4.yzzy).
        /// </summary>
        public bvec4 gbbg => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.yzzz swizzling.
        /// </summary>
        public bvec4 yzzz => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.gbbb swizzling (equivalent to bvec4.yzzz).
        /// </summary>
        public bvec4 gbbb => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.yzzw swizzling.
        /// </summary>
        public bvec4 yzzw => new bvec4(y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.gbba swizzling (equivalent to bvec4.yzzw).
        /// </summary>
        public bvec4 gbba => new bvec4(y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.yzw swizzling.
        /// </summary>
        public bvec3 yzw => new bvec3(y, z, w);
        
        /// <summary>
        /// Returns bvec4.gba swizzling (equivalent to bvec4.yzw).
        /// </summary>
        public bvec3 gba => new bvec3(y, z, w);
        
        /// <summary>
        /// Returns bvec4.yzwx swizzling.
        /// </summary>
        public bvec4 yzwx => new bvec4(y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.gbar swizzling (equivalent to bvec4.yzwx).
        /// </summary>
        public bvec4 gbar => new bvec4(y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.yzwy swizzling.
        /// </summary>
        public bvec4 yzwy => new bvec4(y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.gbag swizzling (equivalent to bvec4.yzwy).
        /// </summary>
        public bvec4 gbag => new bvec4(y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.yzwz swizzling.
        /// </summary>
        public bvec4 yzwz => new bvec4(y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.gbab swizzling (equivalent to bvec4.yzwz).
        /// </summary>
        public bvec4 gbab => new bvec4(y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.yzww swizzling.
        /// </summary>
        public bvec4 yzww => new bvec4(y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.gbaa swizzling (equivalent to bvec4.yzww).
        /// </summary>
        public bvec4 gbaa => new bvec4(y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.yw swizzling.
        /// </summary>
        public bvec2 yw => new bvec2(y, w);
        
        /// <summary>
        /// Returns bvec4.ga swizzling (equivalent to bvec4.yw).
        /// </summary>
        public bvec2 ga => new bvec2(y, w);
        
        /// <summary>
        /// Returns bvec4.ywx swizzling.
        /// </summary>
        public bvec3 ywx => new bvec3(y, w, x);
        
        /// <summary>
        /// Returns bvec4.gar swizzling (equivalent to bvec4.ywx).
        /// </summary>
        public bvec3 gar => new bvec3(y, w, x);
        
        /// <summary>
        /// Returns bvec4.ywxx swizzling.
        /// </summary>
        public bvec4 ywxx => new bvec4(y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.garr swizzling (equivalent to bvec4.ywxx).
        /// </summary>
        public bvec4 garr => new bvec4(y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.ywxy swizzling.
        /// </summary>
        public bvec4 ywxy => new bvec4(y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.garg swizzling (equivalent to bvec4.ywxy).
        /// </summary>
        public bvec4 garg => new bvec4(y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.ywxz swizzling.
        /// </summary>
        public bvec4 ywxz => new bvec4(y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.garb swizzling (equivalent to bvec4.ywxz).
        /// </summary>
        public bvec4 garb => new bvec4(y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.ywxw swizzling.
        /// </summary>
        public bvec4 ywxw => new bvec4(y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.gara swizzling (equivalent to bvec4.ywxw).
        /// </summary>
        public bvec4 gara => new bvec4(y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.ywy swizzling.
        /// </summary>
        public bvec3 ywy => new bvec3(y, w, y);
        
        /// <summary>
        /// Returns bvec4.gag swizzling (equivalent to bvec4.ywy).
        /// </summary>
        public bvec3 gag => new bvec3(y, w, y);
        
        /// <summary>
        /// Returns bvec4.ywyx swizzling.
        /// </summary>
        public bvec4 ywyx => new bvec4(y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.gagr swizzling (equivalent to bvec4.ywyx).
        /// </summary>
        public bvec4 gagr => new bvec4(y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.ywyy swizzling.
        /// </summary>
        public bvec4 ywyy => new bvec4(y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.gagg swizzling (equivalent to bvec4.ywyy).
        /// </summary>
        public bvec4 gagg => new bvec4(y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.ywyz swizzling.
        /// </summary>
        public bvec4 ywyz => new bvec4(y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.gagb swizzling (equivalent to bvec4.ywyz).
        /// </summary>
        public bvec4 gagb => new bvec4(y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.ywyw swizzling.
        /// </summary>
        public bvec4 ywyw => new bvec4(y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.gaga swizzling (equivalent to bvec4.ywyw).
        /// </summary>
        public bvec4 gaga => new bvec4(y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.ywz swizzling.
        /// </summary>
        public bvec3 ywz => new bvec3(y, w, z);
        
        /// <summary>
        /// Returns bvec4.gab swizzling (equivalent to bvec4.ywz).
        /// </summary>
        public bvec3 gab => new bvec3(y, w, z);
        
        /// <summary>
        /// Returns bvec4.ywzx swizzling.
        /// </summary>
        public bvec4 ywzx => new bvec4(y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.gabr swizzling (equivalent to bvec4.ywzx).
        /// </summary>
        public bvec4 gabr => new bvec4(y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.ywzy swizzling.
        /// </summary>
        public bvec4 ywzy => new bvec4(y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.gabg swizzling (equivalent to bvec4.ywzy).
        /// </summary>
        public bvec4 gabg => new bvec4(y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.ywzz swizzling.
        /// </summary>
        public bvec4 ywzz => new bvec4(y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.gabb swizzling (equivalent to bvec4.ywzz).
        /// </summary>
        public bvec4 gabb => new bvec4(y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.ywzw swizzling.
        /// </summary>
        public bvec4 ywzw => new bvec4(y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.gaba swizzling (equivalent to bvec4.ywzw).
        /// </summary>
        public bvec4 gaba => new bvec4(y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.yww swizzling.
        /// </summary>
        public bvec3 yww => new bvec3(y, w, w);
        
        /// <summary>
        /// Returns bvec4.gaa swizzling (equivalent to bvec4.yww).
        /// </summary>
        public bvec3 gaa => new bvec3(y, w, w);
        
        /// <summary>
        /// Returns bvec4.ywwx swizzling.
        /// </summary>
        public bvec4 ywwx => new bvec4(y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.gaar swizzling (equivalent to bvec4.ywwx).
        /// </summary>
        public bvec4 gaar => new bvec4(y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.ywwy swizzling.
        /// </summary>
        public bvec4 ywwy => new bvec4(y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.gaag swizzling (equivalent to bvec4.ywwy).
        /// </summary>
        public bvec4 gaag => new bvec4(y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.ywwz swizzling.
        /// </summary>
        public bvec4 ywwz => new bvec4(y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.gaab swizzling (equivalent to bvec4.ywwz).
        /// </summary>
        public bvec4 gaab => new bvec4(y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.ywww swizzling.
        /// </summary>
        public bvec4 ywww => new bvec4(y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.gaaa swizzling (equivalent to bvec4.ywww).
        /// </summary>
        public bvec4 gaaa => new bvec4(y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.zx swizzling.
        /// </summary>
        public bvec2 zx => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec4.br swizzling (equivalent to bvec4.zx).
        /// </summary>
        public bvec2 br => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec4.zxx swizzling.
        /// </summary>
        public bvec3 zxx => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec4.brr swizzling (equivalent to bvec4.zxx).
        /// </summary>
        public bvec3 brr => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec4.zxxx swizzling.
        /// </summary>
        public bvec4 zxxx => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.brrr swizzling (equivalent to bvec4.zxxx).
        /// </summary>
        public bvec4 brrr => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.zxxy swizzling.
        /// </summary>
        public bvec4 zxxy => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.brrg swizzling (equivalent to bvec4.zxxy).
        /// </summary>
        public bvec4 brrg => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.zxxz swizzling.
        /// </summary>
        public bvec4 zxxz => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.brrb swizzling (equivalent to bvec4.zxxz).
        /// </summary>
        public bvec4 brrb => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.zxxw swizzling.
        /// </summary>
        public bvec4 zxxw => new bvec4(z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.brra swizzling (equivalent to bvec4.zxxw).
        /// </summary>
        public bvec4 brra => new bvec4(z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.zxy swizzling.
        /// </summary>
        public bvec3 zxy => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec4.brg swizzling (equivalent to bvec4.zxy).
        /// </summary>
        public bvec3 brg => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec4.zxyx swizzling.
        /// </summary>
        public bvec4 zxyx => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.brgr swizzling (equivalent to bvec4.zxyx).
        /// </summary>
        public bvec4 brgr => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.zxyy swizzling.
        /// </summary>
        public bvec4 zxyy => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.brgg swizzling (equivalent to bvec4.zxyy).
        /// </summary>
        public bvec4 brgg => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.zxyz swizzling.
        /// </summary>
        public bvec4 zxyz => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.brgb swizzling (equivalent to bvec4.zxyz).
        /// </summary>
        public bvec4 brgb => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.zxyw swizzling.
        /// </summary>
        public bvec4 zxyw => new bvec4(z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.brga swizzling (equivalent to bvec4.zxyw).
        /// </summary>
        public bvec4 brga => new bvec4(z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.zxz swizzling.
        /// </summary>
        public bvec3 zxz => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec4.brb swizzling (equivalent to bvec4.zxz).
        /// </summary>
        public bvec3 brb => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec4.zxzx swizzling.
        /// </summary>
        public bvec4 zxzx => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.brbr swizzling (equivalent to bvec4.zxzx).
        /// </summary>
        public bvec4 brbr => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.zxzy swizzling.
        /// </summary>
        public bvec4 zxzy => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.brbg swizzling (equivalent to bvec4.zxzy).
        /// </summary>
        public bvec4 brbg => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.zxzz swizzling.
        /// </summary>
        public bvec4 zxzz => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.brbb swizzling (equivalent to bvec4.zxzz).
        /// </summary>
        public bvec4 brbb => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.zxzw swizzling.
        /// </summary>
        public bvec4 zxzw => new bvec4(z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.brba swizzling (equivalent to bvec4.zxzw).
        /// </summary>
        public bvec4 brba => new bvec4(z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.zxw swizzling.
        /// </summary>
        public bvec3 zxw => new bvec3(z, x, w);
        
        /// <summary>
        /// Returns bvec4.bra swizzling (equivalent to bvec4.zxw).
        /// </summary>
        public bvec3 bra => new bvec3(z, x, w);
        
        /// <summary>
        /// Returns bvec4.zxwx swizzling.
        /// </summary>
        public bvec4 zxwx => new bvec4(z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.brar swizzling (equivalent to bvec4.zxwx).
        /// </summary>
        public bvec4 brar => new bvec4(z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.zxwy swizzling.
        /// </summary>
        public bvec4 zxwy => new bvec4(z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.brag swizzling (equivalent to bvec4.zxwy).
        /// </summary>
        public bvec4 brag => new bvec4(z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.zxwz swizzling.
        /// </summary>
        public bvec4 zxwz => new bvec4(z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.brab swizzling (equivalent to bvec4.zxwz).
        /// </summary>
        public bvec4 brab => new bvec4(z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.zxww swizzling.
        /// </summary>
        public bvec4 zxww => new bvec4(z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.braa swizzling (equivalent to bvec4.zxww).
        /// </summary>
        public bvec4 braa => new bvec4(z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.zy swizzling.
        /// </summary>
        public bvec2 zy => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec4.bg swizzling (equivalent to bvec4.zy).
        /// </summary>
        public bvec2 bg => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec4.zyx swizzling.
        /// </summary>
        public bvec3 zyx => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec4.bgr swizzling (equivalent to bvec4.zyx).
        /// </summary>
        public bvec3 bgr => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec4.zyxx swizzling.
        /// </summary>
        public bvec4 zyxx => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.bgrr swizzling (equivalent to bvec4.zyxx).
        /// </summary>
        public bvec4 bgrr => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.zyxy swizzling.
        /// </summary>
        public bvec4 zyxy => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.bgrg swizzling (equivalent to bvec4.zyxy).
        /// </summary>
        public bvec4 bgrg => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.zyxz swizzling.
        /// </summary>
        public bvec4 zyxz => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.bgrb swizzling (equivalent to bvec4.zyxz).
        /// </summary>
        public bvec4 bgrb => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.zyxw swizzling.
        /// </summary>
        public bvec4 zyxw => new bvec4(z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.bgra swizzling (equivalent to bvec4.zyxw).
        /// </summary>
        public bvec4 bgra => new bvec4(z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.zyy swizzling.
        /// </summary>
        public bvec3 zyy => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec4.bgg swizzling (equivalent to bvec4.zyy).
        /// </summary>
        public bvec3 bgg => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec4.zyyx swizzling.
        /// </summary>
        public bvec4 zyyx => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.bggr swizzling (equivalent to bvec4.zyyx).
        /// </summary>
        public bvec4 bggr => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.zyyy swizzling.
        /// </summary>
        public bvec4 zyyy => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.bggg swizzling (equivalent to bvec4.zyyy).
        /// </summary>
        public bvec4 bggg => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.zyyz swizzling.
        /// </summary>
        public bvec4 zyyz => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.bggb swizzling (equivalent to bvec4.zyyz).
        /// </summary>
        public bvec4 bggb => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.zyyw swizzling.
        /// </summary>
        public bvec4 zyyw => new bvec4(z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.bgga swizzling (equivalent to bvec4.zyyw).
        /// </summary>
        public bvec4 bgga => new bvec4(z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.zyz swizzling.
        /// </summary>
        public bvec3 zyz => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec4.bgb swizzling (equivalent to bvec4.zyz).
        /// </summary>
        public bvec3 bgb => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec4.zyzx swizzling.
        /// </summary>
        public bvec4 zyzx => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.bgbr swizzling (equivalent to bvec4.zyzx).
        /// </summary>
        public bvec4 bgbr => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.zyzy swizzling.
        /// </summary>
        public bvec4 zyzy => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.bgbg swizzling (equivalent to bvec4.zyzy).
        /// </summary>
        public bvec4 bgbg => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.zyzz swizzling.
        /// </summary>
        public bvec4 zyzz => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.bgbb swizzling (equivalent to bvec4.zyzz).
        /// </summary>
        public bvec4 bgbb => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.zyzw swizzling.
        /// </summary>
        public bvec4 zyzw => new bvec4(z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.bgba swizzling (equivalent to bvec4.zyzw).
        /// </summary>
        public bvec4 bgba => new bvec4(z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.zyw swizzling.
        /// </summary>
        public bvec3 zyw => new bvec3(z, y, w);
        
        /// <summary>
        /// Returns bvec4.bga swizzling (equivalent to bvec4.zyw).
        /// </summary>
        public bvec3 bga => new bvec3(z, y, w);
        
        /// <summary>
        /// Returns bvec4.zywx swizzling.
        /// </summary>
        public bvec4 zywx => new bvec4(z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.bgar swizzling (equivalent to bvec4.zywx).
        /// </summary>
        public bvec4 bgar => new bvec4(z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.zywy swizzling.
        /// </summary>
        public bvec4 zywy => new bvec4(z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.bgag swizzling (equivalent to bvec4.zywy).
        /// </summary>
        public bvec4 bgag => new bvec4(z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.zywz swizzling.
        /// </summary>
        public bvec4 zywz => new bvec4(z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.bgab swizzling (equivalent to bvec4.zywz).
        /// </summary>
        public bvec4 bgab => new bvec4(z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.zyww swizzling.
        /// </summary>
        public bvec4 zyww => new bvec4(z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.bgaa swizzling (equivalent to bvec4.zyww).
        /// </summary>
        public bvec4 bgaa => new bvec4(z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.zz swizzling.
        /// </summary>
        public bvec2 zz => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec4.bb swizzling (equivalent to bvec4.zz).
        /// </summary>
        public bvec2 bb => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec4.zzx swizzling.
        /// </summary>
        public bvec3 zzx => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec4.bbr swizzling (equivalent to bvec4.zzx).
        /// </summary>
        public bvec3 bbr => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec4.zzxx swizzling.
        /// </summary>
        public bvec4 zzxx => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.bbrr swizzling (equivalent to bvec4.zzxx).
        /// </summary>
        public bvec4 bbrr => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.zzxy swizzling.
        /// </summary>
        public bvec4 zzxy => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.bbrg swizzling (equivalent to bvec4.zzxy).
        /// </summary>
        public bvec4 bbrg => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.zzxz swizzling.
        /// </summary>
        public bvec4 zzxz => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.bbrb swizzling (equivalent to bvec4.zzxz).
        /// </summary>
        public bvec4 bbrb => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.zzxw swizzling.
        /// </summary>
        public bvec4 zzxw => new bvec4(z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.bbra swizzling (equivalent to bvec4.zzxw).
        /// </summary>
        public bvec4 bbra => new bvec4(z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.zzy swizzling.
        /// </summary>
        public bvec3 zzy => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec4.bbg swizzling (equivalent to bvec4.zzy).
        /// </summary>
        public bvec3 bbg => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec4.zzyx swizzling.
        /// </summary>
        public bvec4 zzyx => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.bbgr swizzling (equivalent to bvec4.zzyx).
        /// </summary>
        public bvec4 bbgr => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.zzyy swizzling.
        /// </summary>
        public bvec4 zzyy => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.bbgg swizzling (equivalent to bvec4.zzyy).
        /// </summary>
        public bvec4 bbgg => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.zzyz swizzling.
        /// </summary>
        public bvec4 zzyz => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.bbgb swizzling (equivalent to bvec4.zzyz).
        /// </summary>
        public bvec4 bbgb => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.zzyw swizzling.
        /// </summary>
        public bvec4 zzyw => new bvec4(z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.bbga swizzling (equivalent to bvec4.zzyw).
        /// </summary>
        public bvec4 bbga => new bvec4(z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.zzz swizzling.
        /// </summary>
        public bvec3 zzz => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec4.bbb swizzling (equivalent to bvec4.zzz).
        /// </summary>
        public bvec3 bbb => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec4.zzzx swizzling.
        /// </summary>
        public bvec4 zzzx => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.bbbr swizzling (equivalent to bvec4.zzzx).
        /// </summary>
        public bvec4 bbbr => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.zzzy swizzling.
        /// </summary>
        public bvec4 zzzy => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.bbbg swizzling (equivalent to bvec4.zzzy).
        /// </summary>
        public bvec4 bbbg => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.zzzz swizzling.
        /// </summary>
        public bvec4 zzzz => new bvec4(z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.bbbb swizzling (equivalent to bvec4.zzzz).
        /// </summary>
        public bvec4 bbbb => new bvec4(z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.zzzw swizzling.
        /// </summary>
        public bvec4 zzzw => new bvec4(z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.bbba swizzling (equivalent to bvec4.zzzw).
        /// </summary>
        public bvec4 bbba => new bvec4(z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.zzw swizzling.
        /// </summary>
        public bvec3 zzw => new bvec3(z, z, w);
        
        /// <summary>
        /// Returns bvec4.bba swizzling (equivalent to bvec4.zzw).
        /// </summary>
        public bvec3 bba => new bvec3(z, z, w);
        
        /// <summary>
        /// Returns bvec4.zzwx swizzling.
        /// </summary>
        public bvec4 zzwx => new bvec4(z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.bbar swizzling (equivalent to bvec4.zzwx).
        /// </summary>
        public bvec4 bbar => new bvec4(z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.zzwy swizzling.
        /// </summary>
        public bvec4 zzwy => new bvec4(z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.bbag swizzling (equivalent to bvec4.zzwy).
        /// </summary>
        public bvec4 bbag => new bvec4(z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.zzwz swizzling.
        /// </summary>
        public bvec4 zzwz => new bvec4(z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.bbab swizzling (equivalent to bvec4.zzwz).
        /// </summary>
        public bvec4 bbab => new bvec4(z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.zzww swizzling.
        /// </summary>
        public bvec4 zzww => new bvec4(z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.bbaa swizzling (equivalent to bvec4.zzww).
        /// </summary>
        public bvec4 bbaa => new bvec4(z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.zw swizzling.
        /// </summary>
        public bvec2 zw => new bvec2(z, w);
        
        /// <summary>
        /// Returns bvec4.ba swizzling (equivalent to bvec4.zw).
        /// </summary>
        public bvec2 ba => new bvec2(z, w);
        
        /// <summary>
        /// Returns bvec4.zwx swizzling.
        /// </summary>
        public bvec3 zwx => new bvec3(z, w, x);
        
        /// <summary>
        /// Returns bvec4.bar swizzling (equivalent to bvec4.zwx).
        /// </summary>
        public bvec3 bar => new bvec3(z, w, x);
        
        /// <summary>
        /// Returns bvec4.zwxx swizzling.
        /// </summary>
        public bvec4 zwxx => new bvec4(z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.barr swizzling (equivalent to bvec4.zwxx).
        /// </summary>
        public bvec4 barr => new bvec4(z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.zwxy swizzling.
        /// </summary>
        public bvec4 zwxy => new bvec4(z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.barg swizzling (equivalent to bvec4.zwxy).
        /// </summary>
        public bvec4 barg => new bvec4(z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.zwxz swizzling.
        /// </summary>
        public bvec4 zwxz => new bvec4(z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.barb swizzling (equivalent to bvec4.zwxz).
        /// </summary>
        public bvec4 barb => new bvec4(z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.zwxw swizzling.
        /// </summary>
        public bvec4 zwxw => new bvec4(z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.bara swizzling (equivalent to bvec4.zwxw).
        /// </summary>
        public bvec4 bara => new bvec4(z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.zwy swizzling.
        /// </summary>
        public bvec3 zwy => new bvec3(z, w, y);
        
        /// <summary>
        /// Returns bvec4.bag swizzling (equivalent to bvec4.zwy).
        /// </summary>
        public bvec3 bag => new bvec3(z, w, y);
        
        /// <summary>
        /// Returns bvec4.zwyx swizzling.
        /// </summary>
        public bvec4 zwyx => new bvec4(z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.bagr swizzling (equivalent to bvec4.zwyx).
        /// </summary>
        public bvec4 bagr => new bvec4(z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.zwyy swizzling.
        /// </summary>
        public bvec4 zwyy => new bvec4(z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.bagg swizzling (equivalent to bvec4.zwyy).
        /// </summary>
        public bvec4 bagg => new bvec4(z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.zwyz swizzling.
        /// </summary>
        public bvec4 zwyz => new bvec4(z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.bagb swizzling (equivalent to bvec4.zwyz).
        /// </summary>
        public bvec4 bagb => new bvec4(z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.zwyw swizzling.
        /// </summary>
        public bvec4 zwyw => new bvec4(z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.baga swizzling (equivalent to bvec4.zwyw).
        /// </summary>
        public bvec4 baga => new bvec4(z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.zwz swizzling.
        /// </summary>
        public bvec3 zwz => new bvec3(z, w, z);
        
        /// <summary>
        /// Returns bvec4.bab swizzling (equivalent to bvec4.zwz).
        /// </summary>
        public bvec3 bab => new bvec3(z, w, z);
        
        /// <summary>
        /// Returns bvec4.zwzx swizzling.
        /// </summary>
        public bvec4 zwzx => new bvec4(z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.babr swizzling (equivalent to bvec4.zwzx).
        /// </summary>
        public bvec4 babr => new bvec4(z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.zwzy swizzling.
        /// </summary>
        public bvec4 zwzy => new bvec4(z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.babg swizzling (equivalent to bvec4.zwzy).
        /// </summary>
        public bvec4 babg => new bvec4(z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.zwzz swizzling.
        /// </summary>
        public bvec4 zwzz => new bvec4(z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.babb swizzling (equivalent to bvec4.zwzz).
        /// </summary>
        public bvec4 babb => new bvec4(z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.zwzw swizzling.
        /// </summary>
        public bvec4 zwzw => new bvec4(z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.baba swizzling (equivalent to bvec4.zwzw).
        /// </summary>
        public bvec4 baba => new bvec4(z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.zww swizzling.
        /// </summary>
        public bvec3 zww => new bvec3(z, w, w);
        
        /// <summary>
        /// Returns bvec4.baa swizzling (equivalent to bvec4.zww).
        /// </summary>
        public bvec3 baa => new bvec3(z, w, w);
        
        /// <summary>
        /// Returns bvec4.zwwx swizzling.
        /// </summary>
        public bvec4 zwwx => new bvec4(z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.baar swizzling (equivalent to bvec4.zwwx).
        /// </summary>
        public bvec4 baar => new bvec4(z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.zwwy swizzling.
        /// </summary>
        public bvec4 zwwy => new bvec4(z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.baag swizzling (equivalent to bvec4.zwwy).
        /// </summary>
        public bvec4 baag => new bvec4(z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.zwwz swizzling.
        /// </summary>
        public bvec4 zwwz => new bvec4(z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.baab swizzling (equivalent to bvec4.zwwz).
        /// </summary>
        public bvec4 baab => new bvec4(z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.zwww swizzling.
        /// </summary>
        public bvec4 zwww => new bvec4(z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.baaa swizzling (equivalent to bvec4.zwww).
        /// </summary>
        public bvec4 baaa => new bvec4(z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.wx swizzling.
        /// </summary>
        public bvec2 wx => new bvec2(w, x);
        
        /// <summary>
        /// Returns bvec4.ar swizzling (equivalent to bvec4.wx).
        /// </summary>
        public bvec2 ar => new bvec2(w, x);
        
        /// <summary>
        /// Returns bvec4.wxx swizzling.
        /// </summary>
        public bvec3 wxx => new bvec3(w, x, x);
        
        /// <summary>
        /// Returns bvec4.arr swizzling (equivalent to bvec4.wxx).
        /// </summary>
        public bvec3 arr => new bvec3(w, x, x);
        
        /// <summary>
        /// Returns bvec4.wxxx swizzling.
        /// </summary>
        public bvec4 wxxx => new bvec4(w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.arrr swizzling (equivalent to bvec4.wxxx).
        /// </summary>
        public bvec4 arrr => new bvec4(w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.wxxy swizzling.
        /// </summary>
        public bvec4 wxxy => new bvec4(w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.arrg swizzling (equivalent to bvec4.wxxy).
        /// </summary>
        public bvec4 arrg => new bvec4(w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.wxxz swizzling.
        /// </summary>
        public bvec4 wxxz => new bvec4(w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.arrb swizzling (equivalent to bvec4.wxxz).
        /// </summary>
        public bvec4 arrb => new bvec4(w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.wxxw swizzling.
        /// </summary>
        public bvec4 wxxw => new bvec4(w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.arra swizzling (equivalent to bvec4.wxxw).
        /// </summary>
        public bvec4 arra => new bvec4(w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.wxy swizzling.
        /// </summary>
        public bvec3 wxy => new bvec3(w, x, y);
        
        /// <summary>
        /// Returns bvec4.arg swizzling (equivalent to bvec4.wxy).
        /// </summary>
        public bvec3 arg => new bvec3(w, x, y);
        
        /// <summary>
        /// Returns bvec4.wxyx swizzling.
        /// </summary>
        public bvec4 wxyx => new bvec4(w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.argr swizzling (equivalent to bvec4.wxyx).
        /// </summary>
        public bvec4 argr => new bvec4(w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.wxyy swizzling.
        /// </summary>
        public bvec4 wxyy => new bvec4(w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.argg swizzling (equivalent to bvec4.wxyy).
        /// </summary>
        public bvec4 argg => new bvec4(w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.wxyz swizzling.
        /// </summary>
        public bvec4 wxyz => new bvec4(w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.argb swizzling (equivalent to bvec4.wxyz).
        /// </summary>
        public bvec4 argb => new bvec4(w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.wxyw swizzling.
        /// </summary>
        public bvec4 wxyw => new bvec4(w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.arga swizzling (equivalent to bvec4.wxyw).
        /// </summary>
        public bvec4 arga => new bvec4(w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.wxz swizzling.
        /// </summary>
        public bvec3 wxz => new bvec3(w, x, z);
        
        /// <summary>
        /// Returns bvec4.arb swizzling (equivalent to bvec4.wxz).
        /// </summary>
        public bvec3 arb => new bvec3(w, x, z);
        
        /// <summary>
        /// Returns bvec4.wxzx swizzling.
        /// </summary>
        public bvec4 wxzx => new bvec4(w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.arbr swizzling (equivalent to bvec4.wxzx).
        /// </summary>
        public bvec4 arbr => new bvec4(w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.wxzy swizzling.
        /// </summary>
        public bvec4 wxzy => new bvec4(w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.arbg swizzling (equivalent to bvec4.wxzy).
        /// </summary>
        public bvec4 arbg => new bvec4(w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.wxzz swizzling.
        /// </summary>
        public bvec4 wxzz => new bvec4(w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.arbb swizzling (equivalent to bvec4.wxzz).
        /// </summary>
        public bvec4 arbb => new bvec4(w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.wxzw swizzling.
        /// </summary>
        public bvec4 wxzw => new bvec4(w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.arba swizzling (equivalent to bvec4.wxzw).
        /// </summary>
        public bvec4 arba => new bvec4(w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.wxw swizzling.
        /// </summary>
        public bvec3 wxw => new bvec3(w, x, w);
        
        /// <summary>
        /// Returns bvec4.ara swizzling (equivalent to bvec4.wxw).
        /// </summary>
        public bvec3 ara => new bvec3(w, x, w);
        
        /// <summary>
        /// Returns bvec4.wxwx swizzling.
        /// </summary>
        public bvec4 wxwx => new bvec4(w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.arar swizzling (equivalent to bvec4.wxwx).
        /// </summary>
        public bvec4 arar => new bvec4(w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.wxwy swizzling.
        /// </summary>
        public bvec4 wxwy => new bvec4(w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.arag swizzling (equivalent to bvec4.wxwy).
        /// </summary>
        public bvec4 arag => new bvec4(w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.wxwz swizzling.
        /// </summary>
        public bvec4 wxwz => new bvec4(w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.arab swizzling (equivalent to bvec4.wxwz).
        /// </summary>
        public bvec4 arab => new bvec4(w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.wxww swizzling.
        /// </summary>
        public bvec4 wxww => new bvec4(w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.araa swizzling (equivalent to bvec4.wxww).
        /// </summary>
        public bvec4 araa => new bvec4(w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.wy swizzling.
        /// </summary>
        public bvec2 wy => new bvec2(w, y);
        
        /// <summary>
        /// Returns bvec4.ag swizzling (equivalent to bvec4.wy).
        /// </summary>
        public bvec2 ag => new bvec2(w, y);
        
        /// <summary>
        /// Returns bvec4.wyx swizzling.
        /// </summary>
        public bvec3 wyx => new bvec3(w, y, x);
        
        /// <summary>
        /// Returns bvec4.agr swizzling (equivalent to bvec4.wyx).
        /// </summary>
        public bvec3 agr => new bvec3(w, y, x);
        
        /// <summary>
        /// Returns bvec4.wyxx swizzling.
        /// </summary>
        public bvec4 wyxx => new bvec4(w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.agrr swizzling (equivalent to bvec4.wyxx).
        /// </summary>
        public bvec4 agrr => new bvec4(w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.wyxy swizzling.
        /// </summary>
        public bvec4 wyxy => new bvec4(w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.agrg swizzling (equivalent to bvec4.wyxy).
        /// </summary>
        public bvec4 agrg => new bvec4(w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.wyxz swizzling.
        /// </summary>
        public bvec4 wyxz => new bvec4(w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.agrb swizzling (equivalent to bvec4.wyxz).
        /// </summary>
        public bvec4 agrb => new bvec4(w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.wyxw swizzling.
        /// </summary>
        public bvec4 wyxw => new bvec4(w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.agra swizzling (equivalent to bvec4.wyxw).
        /// </summary>
        public bvec4 agra => new bvec4(w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.wyy swizzling.
        /// </summary>
        public bvec3 wyy => new bvec3(w, y, y);
        
        /// <summary>
        /// Returns bvec4.agg swizzling (equivalent to bvec4.wyy).
        /// </summary>
        public bvec3 agg => new bvec3(w, y, y);
        
        /// <summary>
        /// Returns bvec4.wyyx swizzling.
        /// </summary>
        public bvec4 wyyx => new bvec4(w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.aggr swizzling (equivalent to bvec4.wyyx).
        /// </summary>
        public bvec4 aggr => new bvec4(w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.wyyy swizzling.
        /// </summary>
        public bvec4 wyyy => new bvec4(w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.aggg swizzling (equivalent to bvec4.wyyy).
        /// </summary>
        public bvec4 aggg => new bvec4(w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.wyyz swizzling.
        /// </summary>
        public bvec4 wyyz => new bvec4(w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.aggb swizzling (equivalent to bvec4.wyyz).
        /// </summary>
        public bvec4 aggb => new bvec4(w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.wyyw swizzling.
        /// </summary>
        public bvec4 wyyw => new bvec4(w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.agga swizzling (equivalent to bvec4.wyyw).
        /// </summary>
        public bvec4 agga => new bvec4(w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.wyz swizzling.
        /// </summary>
        public bvec3 wyz => new bvec3(w, y, z);
        
        /// <summary>
        /// Returns bvec4.agb swizzling (equivalent to bvec4.wyz).
        /// </summary>
        public bvec3 agb => new bvec3(w, y, z);
        
        /// <summary>
        /// Returns bvec4.wyzx swizzling.
        /// </summary>
        public bvec4 wyzx => new bvec4(w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.agbr swizzling (equivalent to bvec4.wyzx).
        /// </summary>
        public bvec4 agbr => new bvec4(w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.wyzy swizzling.
        /// </summary>
        public bvec4 wyzy => new bvec4(w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.agbg swizzling (equivalent to bvec4.wyzy).
        /// </summary>
        public bvec4 agbg => new bvec4(w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.wyzz swizzling.
        /// </summary>
        public bvec4 wyzz => new bvec4(w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.agbb swizzling (equivalent to bvec4.wyzz).
        /// </summary>
        public bvec4 agbb => new bvec4(w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.wyzw swizzling.
        /// </summary>
        public bvec4 wyzw => new bvec4(w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.agba swizzling (equivalent to bvec4.wyzw).
        /// </summary>
        public bvec4 agba => new bvec4(w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.wyw swizzling.
        /// </summary>
        public bvec3 wyw => new bvec3(w, y, w);
        
        /// <summary>
        /// Returns bvec4.aga swizzling (equivalent to bvec4.wyw).
        /// </summary>
        public bvec3 aga => new bvec3(w, y, w);
        
        /// <summary>
        /// Returns bvec4.wywx swizzling.
        /// </summary>
        public bvec4 wywx => new bvec4(w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.agar swizzling (equivalent to bvec4.wywx).
        /// </summary>
        public bvec4 agar => new bvec4(w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.wywy swizzling.
        /// </summary>
        public bvec4 wywy => new bvec4(w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.agag swizzling (equivalent to bvec4.wywy).
        /// </summary>
        public bvec4 agag => new bvec4(w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.wywz swizzling.
        /// </summary>
        public bvec4 wywz => new bvec4(w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.agab swizzling (equivalent to bvec4.wywz).
        /// </summary>
        public bvec4 agab => new bvec4(w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.wyww swizzling.
        /// </summary>
        public bvec4 wyww => new bvec4(w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.agaa swizzling (equivalent to bvec4.wyww).
        /// </summary>
        public bvec4 agaa => new bvec4(w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.wz swizzling.
        /// </summary>
        public bvec2 wz => new bvec2(w, z);
        
        /// <summary>
        /// Returns bvec4.ab swizzling (equivalent to bvec4.wz).
        /// </summary>
        public bvec2 ab => new bvec2(w, z);
        
        /// <summary>
        /// Returns bvec4.wzx swizzling.
        /// </summary>
        public bvec3 wzx => new bvec3(w, z, x);
        
        /// <summary>
        /// Returns bvec4.abr swizzling (equivalent to bvec4.wzx).
        /// </summary>
        public bvec3 abr => new bvec3(w, z, x);
        
        /// <summary>
        /// Returns bvec4.wzxx swizzling.
        /// </summary>
        public bvec4 wzxx => new bvec4(w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.abrr swizzling (equivalent to bvec4.wzxx).
        /// </summary>
        public bvec4 abrr => new bvec4(w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.wzxy swizzling.
        /// </summary>
        public bvec4 wzxy => new bvec4(w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.abrg swizzling (equivalent to bvec4.wzxy).
        /// </summary>
        public bvec4 abrg => new bvec4(w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.wzxz swizzling.
        /// </summary>
        public bvec4 wzxz => new bvec4(w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.abrb swizzling (equivalent to bvec4.wzxz).
        /// </summary>
        public bvec4 abrb => new bvec4(w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.wzxw swizzling.
        /// </summary>
        public bvec4 wzxw => new bvec4(w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.abra swizzling (equivalent to bvec4.wzxw).
        /// </summary>
        public bvec4 abra => new bvec4(w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.wzy swizzling.
        /// </summary>
        public bvec3 wzy => new bvec3(w, z, y);
        
        /// <summary>
        /// Returns bvec4.abg swizzling (equivalent to bvec4.wzy).
        /// </summary>
        public bvec3 abg => new bvec3(w, z, y);
        
        /// <summary>
        /// Returns bvec4.wzyx swizzling.
        /// </summary>
        public bvec4 wzyx => new bvec4(w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.abgr swizzling (equivalent to bvec4.wzyx).
        /// </summary>
        public bvec4 abgr => new bvec4(w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.wzyy swizzling.
        /// </summary>
        public bvec4 wzyy => new bvec4(w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.abgg swizzling (equivalent to bvec4.wzyy).
        /// </summary>
        public bvec4 abgg => new bvec4(w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.wzyz swizzling.
        /// </summary>
        public bvec4 wzyz => new bvec4(w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.abgb swizzling (equivalent to bvec4.wzyz).
        /// </summary>
        public bvec4 abgb => new bvec4(w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.wzyw swizzling.
        /// </summary>
        public bvec4 wzyw => new bvec4(w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.abga swizzling (equivalent to bvec4.wzyw).
        /// </summary>
        public bvec4 abga => new bvec4(w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.wzz swizzling.
        /// </summary>
        public bvec3 wzz => new bvec3(w, z, z);
        
        /// <summary>
        /// Returns bvec4.abb swizzling (equivalent to bvec4.wzz).
        /// </summary>
        public bvec3 abb => new bvec3(w, z, z);
        
        /// <summary>
        /// Returns bvec4.wzzx swizzling.
        /// </summary>
        public bvec4 wzzx => new bvec4(w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.abbr swizzling (equivalent to bvec4.wzzx).
        /// </summary>
        public bvec4 abbr => new bvec4(w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.wzzy swizzling.
        /// </summary>
        public bvec4 wzzy => new bvec4(w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.abbg swizzling (equivalent to bvec4.wzzy).
        /// </summary>
        public bvec4 abbg => new bvec4(w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.wzzz swizzling.
        /// </summary>
        public bvec4 wzzz => new bvec4(w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.abbb swizzling (equivalent to bvec4.wzzz).
        /// </summary>
        public bvec4 abbb => new bvec4(w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.wzzw swizzling.
        /// </summary>
        public bvec4 wzzw => new bvec4(w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.abba swizzling (equivalent to bvec4.wzzw).
        /// </summary>
        public bvec4 abba => new bvec4(w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.wzw swizzling.
        /// </summary>
        public bvec3 wzw => new bvec3(w, z, w);
        
        /// <summary>
        /// Returns bvec4.aba swizzling (equivalent to bvec4.wzw).
        /// </summary>
        public bvec3 aba => new bvec3(w, z, w);
        
        /// <summary>
        /// Returns bvec4.wzwx swizzling.
        /// </summary>
        public bvec4 wzwx => new bvec4(w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.abar swizzling (equivalent to bvec4.wzwx).
        /// </summary>
        public bvec4 abar => new bvec4(w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.wzwy swizzling.
        /// </summary>
        public bvec4 wzwy => new bvec4(w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.abag swizzling (equivalent to bvec4.wzwy).
        /// </summary>
        public bvec4 abag => new bvec4(w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.wzwz swizzling.
        /// </summary>
        public bvec4 wzwz => new bvec4(w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.abab swizzling (equivalent to bvec4.wzwz).
        /// </summary>
        public bvec4 abab => new bvec4(w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.wzww swizzling.
        /// </summary>
        public bvec4 wzww => new bvec4(w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.abaa swizzling (equivalent to bvec4.wzww).
        /// </summary>
        public bvec4 abaa => new bvec4(w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.ww swizzling.
        /// </summary>
        public bvec2 ww => new bvec2(w, w);
        
        /// <summary>
        /// Returns bvec4.aa swizzling (equivalent to bvec4.ww).
        /// </summary>
        public bvec2 aa => new bvec2(w, w);
        
        /// <summary>
        /// Returns bvec4.wwx swizzling.
        /// </summary>
        public bvec3 wwx => new bvec3(w, w, x);
        
        /// <summary>
        /// Returns bvec4.aar swizzling (equivalent to bvec4.wwx).
        /// </summary>
        public bvec3 aar => new bvec3(w, w, x);
        
        /// <summary>
        /// Returns bvec4.wwxx swizzling.
        /// </summary>
        public bvec4 wwxx => new bvec4(w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.aarr swizzling (equivalent to bvec4.wwxx).
        /// </summary>
        public bvec4 aarr => new bvec4(w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.wwxy swizzling.
        /// </summary>
        public bvec4 wwxy => new bvec4(w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.aarg swizzling (equivalent to bvec4.wwxy).
        /// </summary>
        public bvec4 aarg => new bvec4(w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.wwxz swizzling.
        /// </summary>
        public bvec4 wwxz => new bvec4(w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.aarb swizzling (equivalent to bvec4.wwxz).
        /// </summary>
        public bvec4 aarb => new bvec4(w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.wwxw swizzling.
        /// </summary>
        public bvec4 wwxw => new bvec4(w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.aara swizzling (equivalent to bvec4.wwxw).
        /// </summary>
        public bvec4 aara => new bvec4(w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.wwy swizzling.
        /// </summary>
        public bvec3 wwy => new bvec3(w, w, y);
        
        /// <summary>
        /// Returns bvec4.aag swizzling (equivalent to bvec4.wwy).
        /// </summary>
        public bvec3 aag => new bvec3(w, w, y);
        
        /// <summary>
        /// Returns bvec4.wwyx swizzling.
        /// </summary>
        public bvec4 wwyx => new bvec4(w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.aagr swizzling (equivalent to bvec4.wwyx).
        /// </summary>
        public bvec4 aagr => new bvec4(w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.wwyy swizzling.
        /// </summary>
        public bvec4 wwyy => new bvec4(w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.aagg swizzling (equivalent to bvec4.wwyy).
        /// </summary>
        public bvec4 aagg => new bvec4(w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.wwyz swizzling.
        /// </summary>
        public bvec4 wwyz => new bvec4(w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.aagb swizzling (equivalent to bvec4.wwyz).
        /// </summary>
        public bvec4 aagb => new bvec4(w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.wwyw swizzling.
        /// </summary>
        public bvec4 wwyw => new bvec4(w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.aaga swizzling (equivalent to bvec4.wwyw).
        /// </summary>
        public bvec4 aaga => new bvec4(w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.wwz swizzling.
        /// </summary>
        public bvec3 wwz => new bvec3(w, w, z);
        
        /// <summary>
        /// Returns bvec4.aab swizzling (equivalent to bvec4.wwz).
        /// </summary>
        public bvec3 aab => new bvec3(w, w, z);
        
        /// <summary>
        /// Returns bvec4.wwzx swizzling.
        /// </summary>
        public bvec4 wwzx => new bvec4(w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.aabr swizzling (equivalent to bvec4.wwzx).
        /// </summary>
        public bvec4 aabr => new bvec4(w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.wwzy swizzling.
        /// </summary>
        public bvec4 wwzy => new bvec4(w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.aabg swizzling (equivalent to bvec4.wwzy).
        /// </summary>
        public bvec4 aabg => new bvec4(w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.wwzz swizzling.
        /// </summary>
        public bvec4 wwzz => new bvec4(w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.aabb swizzling (equivalent to bvec4.wwzz).
        /// </summary>
        public bvec4 aabb => new bvec4(w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.wwzw swizzling.
        /// </summary>
        public bvec4 wwzw => new bvec4(w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.aaba swizzling (equivalent to bvec4.wwzw).
        /// </summary>
        public bvec4 aaba => new bvec4(w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.www swizzling.
        /// </summary>
        public bvec3 www => new bvec3(w, w, w);
        
        /// <summary>
        /// Returns bvec4.aaa swizzling (equivalent to bvec4.www).
        /// </summary>
        public bvec3 aaa => new bvec3(w, w, w);
        
        /// <summary>
        /// Returns bvec4.wwwx swizzling.
        /// </summary>
        public bvec4 wwwx => new bvec4(w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.aaar swizzling (equivalent to bvec4.wwwx).
        /// </summary>
        public bvec4 aaar => new bvec4(w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.wwwy swizzling.
        /// </summary>
        public bvec4 wwwy => new bvec4(w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.aaag swizzling (equivalent to bvec4.wwwy).
        /// </summary>
        public bvec4 aaag => new bvec4(w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.wwwz swizzling.
        /// </summary>
        public bvec4 wwwz => new bvec4(w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.aaab swizzling (equivalent to bvec4.wwwz).
        /// </summary>
        public bvec4 aaab => new bvec4(w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.wwww swizzling.
        /// </summary>
        public bvec4 wwww => new bvec4(w, w, w, w);
        
        /// <summary>
        /// Returns bvec4.aaaa swizzling (equivalent to bvec4.wwww).
        /// </summary>
        public bvec4 aaaa => new bvec4(w, w, w, w);

        #endregion

    }
}
