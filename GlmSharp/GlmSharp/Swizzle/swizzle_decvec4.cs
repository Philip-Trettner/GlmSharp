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
    /// Temporary vector of type decimal with 4 components, used for implementing swizzling for decvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_decvec4
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
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly decimal w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_decvec4.
        /// </summary>
        internal swizzle_decvec4(decimal x, decimal y, decimal z, decimal w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns decvec4.xx swizzling.
        /// </summary>
        public decvec2 xx => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec4.rr swizzling (equivalent to decvec4.xx).
        /// </summary>
        public decvec2 rr => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec4.xxx swizzling.
        /// </summary>
        public decvec3 xxx => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec4.rrr swizzling (equivalent to decvec4.xxx).
        /// </summary>
        public decvec3 rrr => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec4.xxxx swizzling.
        /// </summary>
        public decvec4 xxxx => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.rrrr swizzling (equivalent to decvec4.xxxx).
        /// </summary>
        public decvec4 rrrr => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.xxxy swizzling.
        /// </summary>
        public decvec4 xxxy => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.rrrg swizzling (equivalent to decvec4.xxxy).
        /// </summary>
        public decvec4 rrrg => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.xxxz swizzling.
        /// </summary>
        public decvec4 xxxz => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.rrrb swizzling (equivalent to decvec4.xxxz).
        /// </summary>
        public decvec4 rrrb => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.xxxw swizzling.
        /// </summary>
        public decvec4 xxxw => new decvec4(x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.rrra swizzling (equivalent to decvec4.xxxw).
        /// </summary>
        public decvec4 rrra => new decvec4(x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.xxy swizzling.
        /// </summary>
        public decvec3 xxy => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec4.rrg swizzling (equivalent to decvec4.xxy).
        /// </summary>
        public decvec3 rrg => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec4.xxyx swizzling.
        /// </summary>
        public decvec4 xxyx => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.rrgr swizzling (equivalent to decvec4.xxyx).
        /// </summary>
        public decvec4 rrgr => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.xxyy swizzling.
        /// </summary>
        public decvec4 xxyy => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.rrgg swizzling (equivalent to decvec4.xxyy).
        /// </summary>
        public decvec4 rrgg => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.xxyz swizzling.
        /// </summary>
        public decvec4 xxyz => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.rrgb swizzling (equivalent to decvec4.xxyz).
        /// </summary>
        public decvec4 rrgb => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.xxyw swizzling.
        /// </summary>
        public decvec4 xxyw => new decvec4(x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.rrga swizzling (equivalent to decvec4.xxyw).
        /// </summary>
        public decvec4 rrga => new decvec4(x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.xxz swizzling.
        /// </summary>
        public decvec3 xxz => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec4.rrb swizzling (equivalent to decvec4.xxz).
        /// </summary>
        public decvec3 rrb => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec4.xxzx swizzling.
        /// </summary>
        public decvec4 xxzx => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.rrbr swizzling (equivalent to decvec4.xxzx).
        /// </summary>
        public decvec4 rrbr => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.xxzy swizzling.
        /// </summary>
        public decvec4 xxzy => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.rrbg swizzling (equivalent to decvec4.xxzy).
        /// </summary>
        public decvec4 rrbg => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.xxzz swizzling.
        /// </summary>
        public decvec4 xxzz => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.rrbb swizzling (equivalent to decvec4.xxzz).
        /// </summary>
        public decvec4 rrbb => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.xxzw swizzling.
        /// </summary>
        public decvec4 xxzw => new decvec4(x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.rrba swizzling (equivalent to decvec4.xxzw).
        /// </summary>
        public decvec4 rrba => new decvec4(x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.xxw swizzling.
        /// </summary>
        public decvec3 xxw => new decvec3(x, x, w);
        
        /// <summary>
        /// Returns decvec4.rra swizzling (equivalent to decvec4.xxw).
        /// </summary>
        public decvec3 rra => new decvec3(x, x, w);
        
        /// <summary>
        /// Returns decvec4.xxwx swizzling.
        /// </summary>
        public decvec4 xxwx => new decvec4(x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.rrar swizzling (equivalent to decvec4.xxwx).
        /// </summary>
        public decvec4 rrar => new decvec4(x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.xxwy swizzling.
        /// </summary>
        public decvec4 xxwy => new decvec4(x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.rrag swizzling (equivalent to decvec4.xxwy).
        /// </summary>
        public decvec4 rrag => new decvec4(x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.xxwz swizzling.
        /// </summary>
        public decvec4 xxwz => new decvec4(x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.rrab swizzling (equivalent to decvec4.xxwz).
        /// </summary>
        public decvec4 rrab => new decvec4(x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.xxww swizzling.
        /// </summary>
        public decvec4 xxww => new decvec4(x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.rraa swizzling (equivalent to decvec4.xxww).
        /// </summary>
        public decvec4 rraa => new decvec4(x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.xy swizzling.
        /// </summary>
        public decvec2 xy => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec4.rg swizzling (equivalent to decvec4.xy).
        /// </summary>
        public decvec2 rg => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec4.xyx swizzling.
        /// </summary>
        public decvec3 xyx => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec4.rgr swizzling (equivalent to decvec4.xyx).
        /// </summary>
        public decvec3 rgr => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec4.xyxx swizzling.
        /// </summary>
        public decvec4 xyxx => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.rgrr swizzling (equivalent to decvec4.xyxx).
        /// </summary>
        public decvec4 rgrr => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.xyxy swizzling.
        /// </summary>
        public decvec4 xyxy => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.rgrg swizzling (equivalent to decvec4.xyxy).
        /// </summary>
        public decvec4 rgrg => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.xyxz swizzling.
        /// </summary>
        public decvec4 xyxz => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.rgrb swizzling (equivalent to decvec4.xyxz).
        /// </summary>
        public decvec4 rgrb => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.xyxw swizzling.
        /// </summary>
        public decvec4 xyxw => new decvec4(x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.rgra swizzling (equivalent to decvec4.xyxw).
        /// </summary>
        public decvec4 rgra => new decvec4(x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.xyy swizzling.
        /// </summary>
        public decvec3 xyy => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec4.rgg swizzling (equivalent to decvec4.xyy).
        /// </summary>
        public decvec3 rgg => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec4.xyyx swizzling.
        /// </summary>
        public decvec4 xyyx => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.rggr swizzling (equivalent to decvec4.xyyx).
        /// </summary>
        public decvec4 rggr => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.xyyy swizzling.
        /// </summary>
        public decvec4 xyyy => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.rggg swizzling (equivalent to decvec4.xyyy).
        /// </summary>
        public decvec4 rggg => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.xyyz swizzling.
        /// </summary>
        public decvec4 xyyz => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.rggb swizzling (equivalent to decvec4.xyyz).
        /// </summary>
        public decvec4 rggb => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.xyyw swizzling.
        /// </summary>
        public decvec4 xyyw => new decvec4(x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.rgga swizzling (equivalent to decvec4.xyyw).
        /// </summary>
        public decvec4 rgga => new decvec4(x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.xyz swizzling.
        /// </summary>
        public decvec3 xyz => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec4.rgb swizzling (equivalent to decvec4.xyz).
        /// </summary>
        public decvec3 rgb => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec4.xyzx swizzling.
        /// </summary>
        public decvec4 xyzx => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.rgbr swizzling (equivalent to decvec4.xyzx).
        /// </summary>
        public decvec4 rgbr => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.xyzy swizzling.
        /// </summary>
        public decvec4 xyzy => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.rgbg swizzling (equivalent to decvec4.xyzy).
        /// </summary>
        public decvec4 rgbg => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.xyzz swizzling.
        /// </summary>
        public decvec4 xyzz => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.rgbb swizzling (equivalent to decvec4.xyzz).
        /// </summary>
        public decvec4 rgbb => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.xyzw swizzling.
        /// </summary>
        public decvec4 xyzw => new decvec4(x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.rgba swizzling (equivalent to decvec4.xyzw).
        /// </summary>
        public decvec4 rgba => new decvec4(x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.xyw swizzling.
        /// </summary>
        public decvec3 xyw => new decvec3(x, y, w);
        
        /// <summary>
        /// Returns decvec4.rga swizzling (equivalent to decvec4.xyw).
        /// </summary>
        public decvec3 rga => new decvec3(x, y, w);
        
        /// <summary>
        /// Returns decvec4.xywx swizzling.
        /// </summary>
        public decvec4 xywx => new decvec4(x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.rgar swizzling (equivalent to decvec4.xywx).
        /// </summary>
        public decvec4 rgar => new decvec4(x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.xywy swizzling.
        /// </summary>
        public decvec4 xywy => new decvec4(x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.rgag swizzling (equivalent to decvec4.xywy).
        /// </summary>
        public decvec4 rgag => new decvec4(x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.xywz swizzling.
        /// </summary>
        public decvec4 xywz => new decvec4(x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.rgab swizzling (equivalent to decvec4.xywz).
        /// </summary>
        public decvec4 rgab => new decvec4(x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.xyww swizzling.
        /// </summary>
        public decvec4 xyww => new decvec4(x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.rgaa swizzling (equivalent to decvec4.xyww).
        /// </summary>
        public decvec4 rgaa => new decvec4(x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.xz swizzling.
        /// </summary>
        public decvec2 xz => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec4.rb swizzling (equivalent to decvec4.xz).
        /// </summary>
        public decvec2 rb => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec4.xzx swizzling.
        /// </summary>
        public decvec3 xzx => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec4.rbr swizzling (equivalent to decvec4.xzx).
        /// </summary>
        public decvec3 rbr => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec4.xzxx swizzling.
        /// </summary>
        public decvec4 xzxx => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.rbrr swizzling (equivalent to decvec4.xzxx).
        /// </summary>
        public decvec4 rbrr => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.xzxy swizzling.
        /// </summary>
        public decvec4 xzxy => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.rbrg swizzling (equivalent to decvec4.xzxy).
        /// </summary>
        public decvec4 rbrg => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.xzxz swizzling.
        /// </summary>
        public decvec4 xzxz => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.rbrb swizzling (equivalent to decvec4.xzxz).
        /// </summary>
        public decvec4 rbrb => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.xzxw swizzling.
        /// </summary>
        public decvec4 xzxw => new decvec4(x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.rbra swizzling (equivalent to decvec4.xzxw).
        /// </summary>
        public decvec4 rbra => new decvec4(x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.xzy swizzling.
        /// </summary>
        public decvec3 xzy => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec4.rbg swizzling (equivalent to decvec4.xzy).
        /// </summary>
        public decvec3 rbg => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec4.xzyx swizzling.
        /// </summary>
        public decvec4 xzyx => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.rbgr swizzling (equivalent to decvec4.xzyx).
        /// </summary>
        public decvec4 rbgr => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.xzyy swizzling.
        /// </summary>
        public decvec4 xzyy => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.rbgg swizzling (equivalent to decvec4.xzyy).
        /// </summary>
        public decvec4 rbgg => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.xzyz swizzling.
        /// </summary>
        public decvec4 xzyz => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.rbgb swizzling (equivalent to decvec4.xzyz).
        /// </summary>
        public decvec4 rbgb => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.xzyw swizzling.
        /// </summary>
        public decvec4 xzyw => new decvec4(x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.rbga swizzling (equivalent to decvec4.xzyw).
        /// </summary>
        public decvec4 rbga => new decvec4(x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.xzz swizzling.
        /// </summary>
        public decvec3 xzz => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec4.rbb swizzling (equivalent to decvec4.xzz).
        /// </summary>
        public decvec3 rbb => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec4.xzzx swizzling.
        /// </summary>
        public decvec4 xzzx => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.rbbr swizzling (equivalent to decvec4.xzzx).
        /// </summary>
        public decvec4 rbbr => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.xzzy swizzling.
        /// </summary>
        public decvec4 xzzy => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.rbbg swizzling (equivalent to decvec4.xzzy).
        /// </summary>
        public decvec4 rbbg => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.xzzz swizzling.
        /// </summary>
        public decvec4 xzzz => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.rbbb swizzling (equivalent to decvec4.xzzz).
        /// </summary>
        public decvec4 rbbb => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.xzzw swizzling.
        /// </summary>
        public decvec4 xzzw => new decvec4(x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.rbba swizzling (equivalent to decvec4.xzzw).
        /// </summary>
        public decvec4 rbba => new decvec4(x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.xzw swizzling.
        /// </summary>
        public decvec3 xzw => new decvec3(x, z, w);
        
        /// <summary>
        /// Returns decvec4.rba swizzling (equivalent to decvec4.xzw).
        /// </summary>
        public decvec3 rba => new decvec3(x, z, w);
        
        /// <summary>
        /// Returns decvec4.xzwx swizzling.
        /// </summary>
        public decvec4 xzwx => new decvec4(x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.rbar swizzling (equivalent to decvec4.xzwx).
        /// </summary>
        public decvec4 rbar => new decvec4(x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.xzwy swizzling.
        /// </summary>
        public decvec4 xzwy => new decvec4(x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.rbag swizzling (equivalent to decvec4.xzwy).
        /// </summary>
        public decvec4 rbag => new decvec4(x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.xzwz swizzling.
        /// </summary>
        public decvec4 xzwz => new decvec4(x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.rbab swizzling (equivalent to decvec4.xzwz).
        /// </summary>
        public decvec4 rbab => new decvec4(x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.xzww swizzling.
        /// </summary>
        public decvec4 xzww => new decvec4(x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.rbaa swizzling (equivalent to decvec4.xzww).
        /// </summary>
        public decvec4 rbaa => new decvec4(x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.xw swizzling.
        /// </summary>
        public decvec2 xw => new decvec2(x, w);
        
        /// <summary>
        /// Returns decvec4.ra swizzling (equivalent to decvec4.xw).
        /// </summary>
        public decvec2 ra => new decvec2(x, w);
        
        /// <summary>
        /// Returns decvec4.xwx swizzling.
        /// </summary>
        public decvec3 xwx => new decvec3(x, w, x);
        
        /// <summary>
        /// Returns decvec4.rar swizzling (equivalent to decvec4.xwx).
        /// </summary>
        public decvec3 rar => new decvec3(x, w, x);
        
        /// <summary>
        /// Returns decvec4.xwxx swizzling.
        /// </summary>
        public decvec4 xwxx => new decvec4(x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.rarr swizzling (equivalent to decvec4.xwxx).
        /// </summary>
        public decvec4 rarr => new decvec4(x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.xwxy swizzling.
        /// </summary>
        public decvec4 xwxy => new decvec4(x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.rarg swizzling (equivalent to decvec4.xwxy).
        /// </summary>
        public decvec4 rarg => new decvec4(x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.xwxz swizzling.
        /// </summary>
        public decvec4 xwxz => new decvec4(x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.rarb swizzling (equivalent to decvec4.xwxz).
        /// </summary>
        public decvec4 rarb => new decvec4(x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.xwxw swizzling.
        /// </summary>
        public decvec4 xwxw => new decvec4(x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.rara swizzling (equivalent to decvec4.xwxw).
        /// </summary>
        public decvec4 rara => new decvec4(x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.xwy swizzling.
        /// </summary>
        public decvec3 xwy => new decvec3(x, w, y);
        
        /// <summary>
        /// Returns decvec4.rag swizzling (equivalent to decvec4.xwy).
        /// </summary>
        public decvec3 rag => new decvec3(x, w, y);
        
        /// <summary>
        /// Returns decvec4.xwyx swizzling.
        /// </summary>
        public decvec4 xwyx => new decvec4(x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.ragr swizzling (equivalent to decvec4.xwyx).
        /// </summary>
        public decvec4 ragr => new decvec4(x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.xwyy swizzling.
        /// </summary>
        public decvec4 xwyy => new decvec4(x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.ragg swizzling (equivalent to decvec4.xwyy).
        /// </summary>
        public decvec4 ragg => new decvec4(x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.xwyz swizzling.
        /// </summary>
        public decvec4 xwyz => new decvec4(x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.ragb swizzling (equivalent to decvec4.xwyz).
        /// </summary>
        public decvec4 ragb => new decvec4(x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.xwyw swizzling.
        /// </summary>
        public decvec4 xwyw => new decvec4(x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.raga swizzling (equivalent to decvec4.xwyw).
        /// </summary>
        public decvec4 raga => new decvec4(x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.xwz swizzling.
        /// </summary>
        public decvec3 xwz => new decvec3(x, w, z);
        
        /// <summary>
        /// Returns decvec4.rab swizzling (equivalent to decvec4.xwz).
        /// </summary>
        public decvec3 rab => new decvec3(x, w, z);
        
        /// <summary>
        /// Returns decvec4.xwzx swizzling.
        /// </summary>
        public decvec4 xwzx => new decvec4(x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.rabr swizzling (equivalent to decvec4.xwzx).
        /// </summary>
        public decvec4 rabr => new decvec4(x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.xwzy swizzling.
        /// </summary>
        public decvec4 xwzy => new decvec4(x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.rabg swizzling (equivalent to decvec4.xwzy).
        /// </summary>
        public decvec4 rabg => new decvec4(x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.xwzz swizzling.
        /// </summary>
        public decvec4 xwzz => new decvec4(x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.rabb swizzling (equivalent to decvec4.xwzz).
        /// </summary>
        public decvec4 rabb => new decvec4(x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.xwzw swizzling.
        /// </summary>
        public decvec4 xwzw => new decvec4(x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.raba swizzling (equivalent to decvec4.xwzw).
        /// </summary>
        public decvec4 raba => new decvec4(x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.xww swizzling.
        /// </summary>
        public decvec3 xww => new decvec3(x, w, w);
        
        /// <summary>
        /// Returns decvec4.raa swizzling (equivalent to decvec4.xww).
        /// </summary>
        public decvec3 raa => new decvec3(x, w, w);
        
        /// <summary>
        /// Returns decvec4.xwwx swizzling.
        /// </summary>
        public decvec4 xwwx => new decvec4(x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.raar swizzling (equivalent to decvec4.xwwx).
        /// </summary>
        public decvec4 raar => new decvec4(x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.xwwy swizzling.
        /// </summary>
        public decvec4 xwwy => new decvec4(x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.raag swizzling (equivalent to decvec4.xwwy).
        /// </summary>
        public decvec4 raag => new decvec4(x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.xwwz swizzling.
        /// </summary>
        public decvec4 xwwz => new decvec4(x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.raab swizzling (equivalent to decvec4.xwwz).
        /// </summary>
        public decvec4 raab => new decvec4(x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.xwww swizzling.
        /// </summary>
        public decvec4 xwww => new decvec4(x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.raaa swizzling (equivalent to decvec4.xwww).
        /// </summary>
        public decvec4 raaa => new decvec4(x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.yx swizzling.
        /// </summary>
        public decvec2 yx => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec4.gr swizzling (equivalent to decvec4.yx).
        /// </summary>
        public decvec2 gr => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec4.yxx swizzling.
        /// </summary>
        public decvec3 yxx => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec4.grr swizzling (equivalent to decvec4.yxx).
        /// </summary>
        public decvec3 grr => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec4.yxxx swizzling.
        /// </summary>
        public decvec4 yxxx => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.grrr swizzling (equivalent to decvec4.yxxx).
        /// </summary>
        public decvec4 grrr => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.yxxy swizzling.
        /// </summary>
        public decvec4 yxxy => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.grrg swizzling (equivalent to decvec4.yxxy).
        /// </summary>
        public decvec4 grrg => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.yxxz swizzling.
        /// </summary>
        public decvec4 yxxz => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.grrb swizzling (equivalent to decvec4.yxxz).
        /// </summary>
        public decvec4 grrb => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.yxxw swizzling.
        /// </summary>
        public decvec4 yxxw => new decvec4(y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.grra swizzling (equivalent to decvec4.yxxw).
        /// </summary>
        public decvec4 grra => new decvec4(y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.yxy swizzling.
        /// </summary>
        public decvec3 yxy => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec4.grg swizzling (equivalent to decvec4.yxy).
        /// </summary>
        public decvec3 grg => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec4.yxyx swizzling.
        /// </summary>
        public decvec4 yxyx => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.grgr swizzling (equivalent to decvec4.yxyx).
        /// </summary>
        public decvec4 grgr => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.yxyy swizzling.
        /// </summary>
        public decvec4 yxyy => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.grgg swizzling (equivalent to decvec4.yxyy).
        /// </summary>
        public decvec4 grgg => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.yxyz swizzling.
        /// </summary>
        public decvec4 yxyz => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.grgb swizzling (equivalent to decvec4.yxyz).
        /// </summary>
        public decvec4 grgb => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.yxyw swizzling.
        /// </summary>
        public decvec4 yxyw => new decvec4(y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.grga swizzling (equivalent to decvec4.yxyw).
        /// </summary>
        public decvec4 grga => new decvec4(y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.yxz swizzling.
        /// </summary>
        public decvec3 yxz => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec4.grb swizzling (equivalent to decvec4.yxz).
        /// </summary>
        public decvec3 grb => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec4.yxzx swizzling.
        /// </summary>
        public decvec4 yxzx => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.grbr swizzling (equivalent to decvec4.yxzx).
        /// </summary>
        public decvec4 grbr => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.yxzy swizzling.
        /// </summary>
        public decvec4 yxzy => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.grbg swizzling (equivalent to decvec4.yxzy).
        /// </summary>
        public decvec4 grbg => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.yxzz swizzling.
        /// </summary>
        public decvec4 yxzz => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.grbb swizzling (equivalent to decvec4.yxzz).
        /// </summary>
        public decvec4 grbb => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.yxzw swizzling.
        /// </summary>
        public decvec4 yxzw => new decvec4(y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.grba swizzling (equivalent to decvec4.yxzw).
        /// </summary>
        public decvec4 grba => new decvec4(y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.yxw swizzling.
        /// </summary>
        public decvec3 yxw => new decvec3(y, x, w);
        
        /// <summary>
        /// Returns decvec4.gra swizzling (equivalent to decvec4.yxw).
        /// </summary>
        public decvec3 gra => new decvec3(y, x, w);
        
        /// <summary>
        /// Returns decvec4.yxwx swizzling.
        /// </summary>
        public decvec4 yxwx => new decvec4(y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.grar swizzling (equivalent to decvec4.yxwx).
        /// </summary>
        public decvec4 grar => new decvec4(y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.yxwy swizzling.
        /// </summary>
        public decvec4 yxwy => new decvec4(y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.grag swizzling (equivalent to decvec4.yxwy).
        /// </summary>
        public decvec4 grag => new decvec4(y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.yxwz swizzling.
        /// </summary>
        public decvec4 yxwz => new decvec4(y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.grab swizzling (equivalent to decvec4.yxwz).
        /// </summary>
        public decvec4 grab => new decvec4(y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.yxww swizzling.
        /// </summary>
        public decvec4 yxww => new decvec4(y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.graa swizzling (equivalent to decvec4.yxww).
        /// </summary>
        public decvec4 graa => new decvec4(y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.yy swizzling.
        /// </summary>
        public decvec2 yy => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec4.gg swizzling (equivalent to decvec4.yy).
        /// </summary>
        public decvec2 gg => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec4.yyx swizzling.
        /// </summary>
        public decvec3 yyx => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec4.ggr swizzling (equivalent to decvec4.yyx).
        /// </summary>
        public decvec3 ggr => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec4.yyxx swizzling.
        /// </summary>
        public decvec4 yyxx => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.ggrr swizzling (equivalent to decvec4.yyxx).
        /// </summary>
        public decvec4 ggrr => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.yyxy swizzling.
        /// </summary>
        public decvec4 yyxy => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.ggrg swizzling (equivalent to decvec4.yyxy).
        /// </summary>
        public decvec4 ggrg => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.yyxz swizzling.
        /// </summary>
        public decvec4 yyxz => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.ggrb swizzling (equivalent to decvec4.yyxz).
        /// </summary>
        public decvec4 ggrb => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.yyxw swizzling.
        /// </summary>
        public decvec4 yyxw => new decvec4(y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.ggra swizzling (equivalent to decvec4.yyxw).
        /// </summary>
        public decvec4 ggra => new decvec4(y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.yyy swizzling.
        /// </summary>
        public decvec3 yyy => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec4.ggg swizzling (equivalent to decvec4.yyy).
        /// </summary>
        public decvec3 ggg => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec4.yyyx swizzling.
        /// </summary>
        public decvec4 yyyx => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.gggr swizzling (equivalent to decvec4.yyyx).
        /// </summary>
        public decvec4 gggr => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.yyyy swizzling.
        /// </summary>
        public decvec4 yyyy => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.gggg swizzling (equivalent to decvec4.yyyy).
        /// </summary>
        public decvec4 gggg => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.yyyz swizzling.
        /// </summary>
        public decvec4 yyyz => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.gggb swizzling (equivalent to decvec4.yyyz).
        /// </summary>
        public decvec4 gggb => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.yyyw swizzling.
        /// </summary>
        public decvec4 yyyw => new decvec4(y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.ggga swizzling (equivalent to decvec4.yyyw).
        /// </summary>
        public decvec4 ggga => new decvec4(y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.yyz swizzling.
        /// </summary>
        public decvec3 yyz => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec4.ggb swizzling (equivalent to decvec4.yyz).
        /// </summary>
        public decvec3 ggb => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec4.yyzx swizzling.
        /// </summary>
        public decvec4 yyzx => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.ggbr swizzling (equivalent to decvec4.yyzx).
        /// </summary>
        public decvec4 ggbr => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.yyzy swizzling.
        /// </summary>
        public decvec4 yyzy => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.ggbg swizzling (equivalent to decvec4.yyzy).
        /// </summary>
        public decvec4 ggbg => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.yyzz swizzling.
        /// </summary>
        public decvec4 yyzz => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.ggbb swizzling (equivalent to decvec4.yyzz).
        /// </summary>
        public decvec4 ggbb => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.yyzw swizzling.
        /// </summary>
        public decvec4 yyzw => new decvec4(y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.ggba swizzling (equivalent to decvec4.yyzw).
        /// </summary>
        public decvec4 ggba => new decvec4(y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.yyw swizzling.
        /// </summary>
        public decvec3 yyw => new decvec3(y, y, w);
        
        /// <summary>
        /// Returns decvec4.gga swizzling (equivalent to decvec4.yyw).
        /// </summary>
        public decvec3 gga => new decvec3(y, y, w);
        
        /// <summary>
        /// Returns decvec4.yywx swizzling.
        /// </summary>
        public decvec4 yywx => new decvec4(y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.ggar swizzling (equivalent to decvec4.yywx).
        /// </summary>
        public decvec4 ggar => new decvec4(y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.yywy swizzling.
        /// </summary>
        public decvec4 yywy => new decvec4(y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.ggag swizzling (equivalent to decvec4.yywy).
        /// </summary>
        public decvec4 ggag => new decvec4(y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.yywz swizzling.
        /// </summary>
        public decvec4 yywz => new decvec4(y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.ggab swizzling (equivalent to decvec4.yywz).
        /// </summary>
        public decvec4 ggab => new decvec4(y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.yyww swizzling.
        /// </summary>
        public decvec4 yyww => new decvec4(y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.ggaa swizzling (equivalent to decvec4.yyww).
        /// </summary>
        public decvec4 ggaa => new decvec4(y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.yz swizzling.
        /// </summary>
        public decvec2 yz => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec4.gb swizzling (equivalent to decvec4.yz).
        /// </summary>
        public decvec2 gb => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec4.yzx swizzling.
        /// </summary>
        public decvec3 yzx => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec4.gbr swizzling (equivalent to decvec4.yzx).
        /// </summary>
        public decvec3 gbr => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec4.yzxx swizzling.
        /// </summary>
        public decvec4 yzxx => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.gbrr swizzling (equivalent to decvec4.yzxx).
        /// </summary>
        public decvec4 gbrr => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.yzxy swizzling.
        /// </summary>
        public decvec4 yzxy => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.gbrg swizzling (equivalent to decvec4.yzxy).
        /// </summary>
        public decvec4 gbrg => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.yzxz swizzling.
        /// </summary>
        public decvec4 yzxz => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.gbrb swizzling (equivalent to decvec4.yzxz).
        /// </summary>
        public decvec4 gbrb => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.yzxw swizzling.
        /// </summary>
        public decvec4 yzxw => new decvec4(y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.gbra swizzling (equivalent to decvec4.yzxw).
        /// </summary>
        public decvec4 gbra => new decvec4(y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.yzy swizzling.
        /// </summary>
        public decvec3 yzy => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec4.gbg swizzling (equivalent to decvec4.yzy).
        /// </summary>
        public decvec3 gbg => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec4.yzyx swizzling.
        /// </summary>
        public decvec4 yzyx => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.gbgr swizzling (equivalent to decvec4.yzyx).
        /// </summary>
        public decvec4 gbgr => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.yzyy swizzling.
        /// </summary>
        public decvec4 yzyy => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.gbgg swizzling (equivalent to decvec4.yzyy).
        /// </summary>
        public decvec4 gbgg => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.yzyz swizzling.
        /// </summary>
        public decvec4 yzyz => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.gbgb swizzling (equivalent to decvec4.yzyz).
        /// </summary>
        public decvec4 gbgb => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.yzyw swizzling.
        /// </summary>
        public decvec4 yzyw => new decvec4(y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.gbga swizzling (equivalent to decvec4.yzyw).
        /// </summary>
        public decvec4 gbga => new decvec4(y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.yzz swizzling.
        /// </summary>
        public decvec3 yzz => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec4.gbb swizzling (equivalent to decvec4.yzz).
        /// </summary>
        public decvec3 gbb => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec4.yzzx swizzling.
        /// </summary>
        public decvec4 yzzx => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.gbbr swizzling (equivalent to decvec4.yzzx).
        /// </summary>
        public decvec4 gbbr => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.yzzy swizzling.
        /// </summary>
        public decvec4 yzzy => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.gbbg swizzling (equivalent to decvec4.yzzy).
        /// </summary>
        public decvec4 gbbg => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.yzzz swizzling.
        /// </summary>
        public decvec4 yzzz => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.gbbb swizzling (equivalent to decvec4.yzzz).
        /// </summary>
        public decvec4 gbbb => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.yzzw swizzling.
        /// </summary>
        public decvec4 yzzw => new decvec4(y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.gbba swizzling (equivalent to decvec4.yzzw).
        /// </summary>
        public decvec4 gbba => new decvec4(y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.yzw swizzling.
        /// </summary>
        public decvec3 yzw => new decvec3(y, z, w);
        
        /// <summary>
        /// Returns decvec4.gba swizzling (equivalent to decvec4.yzw).
        /// </summary>
        public decvec3 gba => new decvec3(y, z, w);
        
        /// <summary>
        /// Returns decvec4.yzwx swizzling.
        /// </summary>
        public decvec4 yzwx => new decvec4(y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.gbar swizzling (equivalent to decvec4.yzwx).
        /// </summary>
        public decvec4 gbar => new decvec4(y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.yzwy swizzling.
        /// </summary>
        public decvec4 yzwy => new decvec4(y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.gbag swizzling (equivalent to decvec4.yzwy).
        /// </summary>
        public decvec4 gbag => new decvec4(y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.yzwz swizzling.
        /// </summary>
        public decvec4 yzwz => new decvec4(y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.gbab swizzling (equivalent to decvec4.yzwz).
        /// </summary>
        public decvec4 gbab => new decvec4(y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.yzww swizzling.
        /// </summary>
        public decvec4 yzww => new decvec4(y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.gbaa swizzling (equivalent to decvec4.yzww).
        /// </summary>
        public decvec4 gbaa => new decvec4(y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.yw swizzling.
        /// </summary>
        public decvec2 yw => new decvec2(y, w);
        
        /// <summary>
        /// Returns decvec4.ga swizzling (equivalent to decvec4.yw).
        /// </summary>
        public decvec2 ga => new decvec2(y, w);
        
        /// <summary>
        /// Returns decvec4.ywx swizzling.
        /// </summary>
        public decvec3 ywx => new decvec3(y, w, x);
        
        /// <summary>
        /// Returns decvec4.gar swizzling (equivalent to decvec4.ywx).
        /// </summary>
        public decvec3 gar => new decvec3(y, w, x);
        
        /// <summary>
        /// Returns decvec4.ywxx swizzling.
        /// </summary>
        public decvec4 ywxx => new decvec4(y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.garr swizzling (equivalent to decvec4.ywxx).
        /// </summary>
        public decvec4 garr => new decvec4(y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.ywxy swizzling.
        /// </summary>
        public decvec4 ywxy => new decvec4(y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.garg swizzling (equivalent to decvec4.ywxy).
        /// </summary>
        public decvec4 garg => new decvec4(y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.ywxz swizzling.
        /// </summary>
        public decvec4 ywxz => new decvec4(y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.garb swizzling (equivalent to decvec4.ywxz).
        /// </summary>
        public decvec4 garb => new decvec4(y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.ywxw swizzling.
        /// </summary>
        public decvec4 ywxw => new decvec4(y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.gara swizzling (equivalent to decvec4.ywxw).
        /// </summary>
        public decvec4 gara => new decvec4(y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.ywy swizzling.
        /// </summary>
        public decvec3 ywy => new decvec3(y, w, y);
        
        /// <summary>
        /// Returns decvec4.gag swizzling (equivalent to decvec4.ywy).
        /// </summary>
        public decvec3 gag => new decvec3(y, w, y);
        
        /// <summary>
        /// Returns decvec4.ywyx swizzling.
        /// </summary>
        public decvec4 ywyx => new decvec4(y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.gagr swizzling (equivalent to decvec4.ywyx).
        /// </summary>
        public decvec4 gagr => new decvec4(y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.ywyy swizzling.
        /// </summary>
        public decvec4 ywyy => new decvec4(y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.gagg swizzling (equivalent to decvec4.ywyy).
        /// </summary>
        public decvec4 gagg => new decvec4(y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.ywyz swizzling.
        /// </summary>
        public decvec4 ywyz => new decvec4(y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.gagb swizzling (equivalent to decvec4.ywyz).
        /// </summary>
        public decvec4 gagb => new decvec4(y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.ywyw swizzling.
        /// </summary>
        public decvec4 ywyw => new decvec4(y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.gaga swizzling (equivalent to decvec4.ywyw).
        /// </summary>
        public decvec4 gaga => new decvec4(y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.ywz swizzling.
        /// </summary>
        public decvec3 ywz => new decvec3(y, w, z);
        
        /// <summary>
        /// Returns decvec4.gab swizzling (equivalent to decvec4.ywz).
        /// </summary>
        public decvec3 gab => new decvec3(y, w, z);
        
        /// <summary>
        /// Returns decvec4.ywzx swizzling.
        /// </summary>
        public decvec4 ywzx => new decvec4(y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.gabr swizzling (equivalent to decvec4.ywzx).
        /// </summary>
        public decvec4 gabr => new decvec4(y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.ywzy swizzling.
        /// </summary>
        public decvec4 ywzy => new decvec4(y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.gabg swizzling (equivalent to decvec4.ywzy).
        /// </summary>
        public decvec4 gabg => new decvec4(y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.ywzz swizzling.
        /// </summary>
        public decvec4 ywzz => new decvec4(y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.gabb swizzling (equivalent to decvec4.ywzz).
        /// </summary>
        public decvec4 gabb => new decvec4(y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.ywzw swizzling.
        /// </summary>
        public decvec4 ywzw => new decvec4(y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.gaba swizzling (equivalent to decvec4.ywzw).
        /// </summary>
        public decvec4 gaba => new decvec4(y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.yww swizzling.
        /// </summary>
        public decvec3 yww => new decvec3(y, w, w);
        
        /// <summary>
        /// Returns decvec4.gaa swizzling (equivalent to decvec4.yww).
        /// </summary>
        public decvec3 gaa => new decvec3(y, w, w);
        
        /// <summary>
        /// Returns decvec4.ywwx swizzling.
        /// </summary>
        public decvec4 ywwx => new decvec4(y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.gaar swizzling (equivalent to decvec4.ywwx).
        /// </summary>
        public decvec4 gaar => new decvec4(y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.ywwy swizzling.
        /// </summary>
        public decvec4 ywwy => new decvec4(y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.gaag swizzling (equivalent to decvec4.ywwy).
        /// </summary>
        public decvec4 gaag => new decvec4(y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.ywwz swizzling.
        /// </summary>
        public decvec4 ywwz => new decvec4(y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.gaab swizzling (equivalent to decvec4.ywwz).
        /// </summary>
        public decvec4 gaab => new decvec4(y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.ywww swizzling.
        /// </summary>
        public decvec4 ywww => new decvec4(y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.gaaa swizzling (equivalent to decvec4.ywww).
        /// </summary>
        public decvec4 gaaa => new decvec4(y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.zx swizzling.
        /// </summary>
        public decvec2 zx => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec4.br swizzling (equivalent to decvec4.zx).
        /// </summary>
        public decvec2 br => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec4.zxx swizzling.
        /// </summary>
        public decvec3 zxx => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec4.brr swizzling (equivalent to decvec4.zxx).
        /// </summary>
        public decvec3 brr => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec4.zxxx swizzling.
        /// </summary>
        public decvec4 zxxx => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.brrr swizzling (equivalent to decvec4.zxxx).
        /// </summary>
        public decvec4 brrr => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.zxxy swizzling.
        /// </summary>
        public decvec4 zxxy => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.brrg swizzling (equivalent to decvec4.zxxy).
        /// </summary>
        public decvec4 brrg => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.zxxz swizzling.
        /// </summary>
        public decvec4 zxxz => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.brrb swizzling (equivalent to decvec4.zxxz).
        /// </summary>
        public decvec4 brrb => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.zxxw swizzling.
        /// </summary>
        public decvec4 zxxw => new decvec4(z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.brra swizzling (equivalent to decvec4.zxxw).
        /// </summary>
        public decvec4 brra => new decvec4(z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.zxy swizzling.
        /// </summary>
        public decvec3 zxy => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec4.brg swizzling (equivalent to decvec4.zxy).
        /// </summary>
        public decvec3 brg => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec4.zxyx swizzling.
        /// </summary>
        public decvec4 zxyx => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.brgr swizzling (equivalent to decvec4.zxyx).
        /// </summary>
        public decvec4 brgr => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.zxyy swizzling.
        /// </summary>
        public decvec4 zxyy => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.brgg swizzling (equivalent to decvec4.zxyy).
        /// </summary>
        public decvec4 brgg => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.zxyz swizzling.
        /// </summary>
        public decvec4 zxyz => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.brgb swizzling (equivalent to decvec4.zxyz).
        /// </summary>
        public decvec4 brgb => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.zxyw swizzling.
        /// </summary>
        public decvec4 zxyw => new decvec4(z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.brga swizzling (equivalent to decvec4.zxyw).
        /// </summary>
        public decvec4 brga => new decvec4(z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.zxz swizzling.
        /// </summary>
        public decvec3 zxz => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec4.brb swizzling (equivalent to decvec4.zxz).
        /// </summary>
        public decvec3 brb => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec4.zxzx swizzling.
        /// </summary>
        public decvec4 zxzx => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.brbr swizzling (equivalent to decvec4.zxzx).
        /// </summary>
        public decvec4 brbr => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.zxzy swizzling.
        /// </summary>
        public decvec4 zxzy => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.brbg swizzling (equivalent to decvec4.zxzy).
        /// </summary>
        public decvec4 brbg => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.zxzz swizzling.
        /// </summary>
        public decvec4 zxzz => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.brbb swizzling (equivalent to decvec4.zxzz).
        /// </summary>
        public decvec4 brbb => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.zxzw swizzling.
        /// </summary>
        public decvec4 zxzw => new decvec4(z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.brba swizzling (equivalent to decvec4.zxzw).
        /// </summary>
        public decvec4 brba => new decvec4(z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.zxw swizzling.
        /// </summary>
        public decvec3 zxw => new decvec3(z, x, w);
        
        /// <summary>
        /// Returns decvec4.bra swizzling (equivalent to decvec4.zxw).
        /// </summary>
        public decvec3 bra => new decvec3(z, x, w);
        
        /// <summary>
        /// Returns decvec4.zxwx swizzling.
        /// </summary>
        public decvec4 zxwx => new decvec4(z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.brar swizzling (equivalent to decvec4.zxwx).
        /// </summary>
        public decvec4 brar => new decvec4(z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.zxwy swizzling.
        /// </summary>
        public decvec4 zxwy => new decvec4(z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.brag swizzling (equivalent to decvec4.zxwy).
        /// </summary>
        public decvec4 brag => new decvec4(z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.zxwz swizzling.
        /// </summary>
        public decvec4 zxwz => new decvec4(z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.brab swizzling (equivalent to decvec4.zxwz).
        /// </summary>
        public decvec4 brab => new decvec4(z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.zxww swizzling.
        /// </summary>
        public decvec4 zxww => new decvec4(z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.braa swizzling (equivalent to decvec4.zxww).
        /// </summary>
        public decvec4 braa => new decvec4(z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.zy swizzling.
        /// </summary>
        public decvec2 zy => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec4.bg swizzling (equivalent to decvec4.zy).
        /// </summary>
        public decvec2 bg => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec4.zyx swizzling.
        /// </summary>
        public decvec3 zyx => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec4.bgr swizzling (equivalent to decvec4.zyx).
        /// </summary>
        public decvec3 bgr => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec4.zyxx swizzling.
        /// </summary>
        public decvec4 zyxx => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.bgrr swizzling (equivalent to decvec4.zyxx).
        /// </summary>
        public decvec4 bgrr => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.zyxy swizzling.
        /// </summary>
        public decvec4 zyxy => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.bgrg swizzling (equivalent to decvec4.zyxy).
        /// </summary>
        public decvec4 bgrg => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.zyxz swizzling.
        /// </summary>
        public decvec4 zyxz => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.bgrb swizzling (equivalent to decvec4.zyxz).
        /// </summary>
        public decvec4 bgrb => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.zyxw swizzling.
        /// </summary>
        public decvec4 zyxw => new decvec4(z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.bgra swizzling (equivalent to decvec4.zyxw).
        /// </summary>
        public decvec4 bgra => new decvec4(z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.zyy swizzling.
        /// </summary>
        public decvec3 zyy => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec4.bgg swizzling (equivalent to decvec4.zyy).
        /// </summary>
        public decvec3 bgg => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec4.zyyx swizzling.
        /// </summary>
        public decvec4 zyyx => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.bggr swizzling (equivalent to decvec4.zyyx).
        /// </summary>
        public decvec4 bggr => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.zyyy swizzling.
        /// </summary>
        public decvec4 zyyy => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.bggg swizzling (equivalent to decvec4.zyyy).
        /// </summary>
        public decvec4 bggg => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.zyyz swizzling.
        /// </summary>
        public decvec4 zyyz => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.bggb swizzling (equivalent to decvec4.zyyz).
        /// </summary>
        public decvec4 bggb => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.zyyw swizzling.
        /// </summary>
        public decvec4 zyyw => new decvec4(z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.bgga swizzling (equivalent to decvec4.zyyw).
        /// </summary>
        public decvec4 bgga => new decvec4(z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.zyz swizzling.
        /// </summary>
        public decvec3 zyz => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec4.bgb swizzling (equivalent to decvec4.zyz).
        /// </summary>
        public decvec3 bgb => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec4.zyzx swizzling.
        /// </summary>
        public decvec4 zyzx => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.bgbr swizzling (equivalent to decvec4.zyzx).
        /// </summary>
        public decvec4 bgbr => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.zyzy swizzling.
        /// </summary>
        public decvec4 zyzy => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.bgbg swizzling (equivalent to decvec4.zyzy).
        /// </summary>
        public decvec4 bgbg => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.zyzz swizzling.
        /// </summary>
        public decvec4 zyzz => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.bgbb swizzling (equivalent to decvec4.zyzz).
        /// </summary>
        public decvec4 bgbb => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.zyzw swizzling.
        /// </summary>
        public decvec4 zyzw => new decvec4(z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.bgba swizzling (equivalent to decvec4.zyzw).
        /// </summary>
        public decvec4 bgba => new decvec4(z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.zyw swizzling.
        /// </summary>
        public decvec3 zyw => new decvec3(z, y, w);
        
        /// <summary>
        /// Returns decvec4.bga swizzling (equivalent to decvec4.zyw).
        /// </summary>
        public decvec3 bga => new decvec3(z, y, w);
        
        /// <summary>
        /// Returns decvec4.zywx swizzling.
        /// </summary>
        public decvec4 zywx => new decvec4(z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.bgar swizzling (equivalent to decvec4.zywx).
        /// </summary>
        public decvec4 bgar => new decvec4(z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.zywy swizzling.
        /// </summary>
        public decvec4 zywy => new decvec4(z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.bgag swizzling (equivalent to decvec4.zywy).
        /// </summary>
        public decvec4 bgag => new decvec4(z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.zywz swizzling.
        /// </summary>
        public decvec4 zywz => new decvec4(z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.bgab swizzling (equivalent to decvec4.zywz).
        /// </summary>
        public decvec4 bgab => new decvec4(z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.zyww swizzling.
        /// </summary>
        public decvec4 zyww => new decvec4(z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.bgaa swizzling (equivalent to decvec4.zyww).
        /// </summary>
        public decvec4 bgaa => new decvec4(z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.zz swizzling.
        /// </summary>
        public decvec2 zz => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec4.bb swizzling (equivalent to decvec4.zz).
        /// </summary>
        public decvec2 bb => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec4.zzx swizzling.
        /// </summary>
        public decvec3 zzx => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec4.bbr swizzling (equivalent to decvec4.zzx).
        /// </summary>
        public decvec3 bbr => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec4.zzxx swizzling.
        /// </summary>
        public decvec4 zzxx => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.bbrr swizzling (equivalent to decvec4.zzxx).
        /// </summary>
        public decvec4 bbrr => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.zzxy swizzling.
        /// </summary>
        public decvec4 zzxy => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.bbrg swizzling (equivalent to decvec4.zzxy).
        /// </summary>
        public decvec4 bbrg => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.zzxz swizzling.
        /// </summary>
        public decvec4 zzxz => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.bbrb swizzling (equivalent to decvec4.zzxz).
        /// </summary>
        public decvec4 bbrb => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.zzxw swizzling.
        /// </summary>
        public decvec4 zzxw => new decvec4(z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.bbra swizzling (equivalent to decvec4.zzxw).
        /// </summary>
        public decvec4 bbra => new decvec4(z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.zzy swizzling.
        /// </summary>
        public decvec3 zzy => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec4.bbg swizzling (equivalent to decvec4.zzy).
        /// </summary>
        public decvec3 bbg => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec4.zzyx swizzling.
        /// </summary>
        public decvec4 zzyx => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.bbgr swizzling (equivalent to decvec4.zzyx).
        /// </summary>
        public decvec4 bbgr => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.zzyy swizzling.
        /// </summary>
        public decvec4 zzyy => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.bbgg swizzling (equivalent to decvec4.zzyy).
        /// </summary>
        public decvec4 bbgg => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.zzyz swizzling.
        /// </summary>
        public decvec4 zzyz => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.bbgb swizzling (equivalent to decvec4.zzyz).
        /// </summary>
        public decvec4 bbgb => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.zzyw swizzling.
        /// </summary>
        public decvec4 zzyw => new decvec4(z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.bbga swizzling (equivalent to decvec4.zzyw).
        /// </summary>
        public decvec4 bbga => new decvec4(z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.zzz swizzling.
        /// </summary>
        public decvec3 zzz => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec4.bbb swizzling (equivalent to decvec4.zzz).
        /// </summary>
        public decvec3 bbb => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec4.zzzx swizzling.
        /// </summary>
        public decvec4 zzzx => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.bbbr swizzling (equivalent to decvec4.zzzx).
        /// </summary>
        public decvec4 bbbr => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.zzzy swizzling.
        /// </summary>
        public decvec4 zzzy => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.bbbg swizzling (equivalent to decvec4.zzzy).
        /// </summary>
        public decvec4 bbbg => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.zzzz swizzling.
        /// </summary>
        public decvec4 zzzz => new decvec4(z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.bbbb swizzling (equivalent to decvec4.zzzz).
        /// </summary>
        public decvec4 bbbb => new decvec4(z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.zzzw swizzling.
        /// </summary>
        public decvec4 zzzw => new decvec4(z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.bbba swizzling (equivalent to decvec4.zzzw).
        /// </summary>
        public decvec4 bbba => new decvec4(z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.zzw swizzling.
        /// </summary>
        public decvec3 zzw => new decvec3(z, z, w);
        
        /// <summary>
        /// Returns decvec4.bba swizzling (equivalent to decvec4.zzw).
        /// </summary>
        public decvec3 bba => new decvec3(z, z, w);
        
        /// <summary>
        /// Returns decvec4.zzwx swizzling.
        /// </summary>
        public decvec4 zzwx => new decvec4(z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.bbar swizzling (equivalent to decvec4.zzwx).
        /// </summary>
        public decvec4 bbar => new decvec4(z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.zzwy swizzling.
        /// </summary>
        public decvec4 zzwy => new decvec4(z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.bbag swizzling (equivalent to decvec4.zzwy).
        /// </summary>
        public decvec4 bbag => new decvec4(z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.zzwz swizzling.
        /// </summary>
        public decvec4 zzwz => new decvec4(z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.bbab swizzling (equivalent to decvec4.zzwz).
        /// </summary>
        public decvec4 bbab => new decvec4(z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.zzww swizzling.
        /// </summary>
        public decvec4 zzww => new decvec4(z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.bbaa swizzling (equivalent to decvec4.zzww).
        /// </summary>
        public decvec4 bbaa => new decvec4(z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.zw swizzling.
        /// </summary>
        public decvec2 zw => new decvec2(z, w);
        
        /// <summary>
        /// Returns decvec4.ba swizzling (equivalent to decvec4.zw).
        /// </summary>
        public decvec2 ba => new decvec2(z, w);
        
        /// <summary>
        /// Returns decvec4.zwx swizzling.
        /// </summary>
        public decvec3 zwx => new decvec3(z, w, x);
        
        /// <summary>
        /// Returns decvec4.bar swizzling (equivalent to decvec4.zwx).
        /// </summary>
        public decvec3 bar => new decvec3(z, w, x);
        
        /// <summary>
        /// Returns decvec4.zwxx swizzling.
        /// </summary>
        public decvec4 zwxx => new decvec4(z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.barr swizzling (equivalent to decvec4.zwxx).
        /// </summary>
        public decvec4 barr => new decvec4(z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.zwxy swizzling.
        /// </summary>
        public decvec4 zwxy => new decvec4(z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.barg swizzling (equivalent to decvec4.zwxy).
        /// </summary>
        public decvec4 barg => new decvec4(z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.zwxz swizzling.
        /// </summary>
        public decvec4 zwxz => new decvec4(z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.barb swizzling (equivalent to decvec4.zwxz).
        /// </summary>
        public decvec4 barb => new decvec4(z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.zwxw swizzling.
        /// </summary>
        public decvec4 zwxw => new decvec4(z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.bara swizzling (equivalent to decvec4.zwxw).
        /// </summary>
        public decvec4 bara => new decvec4(z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.zwy swizzling.
        /// </summary>
        public decvec3 zwy => new decvec3(z, w, y);
        
        /// <summary>
        /// Returns decvec4.bag swizzling (equivalent to decvec4.zwy).
        /// </summary>
        public decvec3 bag => new decvec3(z, w, y);
        
        /// <summary>
        /// Returns decvec4.zwyx swizzling.
        /// </summary>
        public decvec4 zwyx => new decvec4(z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.bagr swizzling (equivalent to decvec4.zwyx).
        /// </summary>
        public decvec4 bagr => new decvec4(z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.zwyy swizzling.
        /// </summary>
        public decvec4 zwyy => new decvec4(z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.bagg swizzling (equivalent to decvec4.zwyy).
        /// </summary>
        public decvec4 bagg => new decvec4(z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.zwyz swizzling.
        /// </summary>
        public decvec4 zwyz => new decvec4(z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.bagb swizzling (equivalent to decvec4.zwyz).
        /// </summary>
        public decvec4 bagb => new decvec4(z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.zwyw swizzling.
        /// </summary>
        public decvec4 zwyw => new decvec4(z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.baga swizzling (equivalent to decvec4.zwyw).
        /// </summary>
        public decvec4 baga => new decvec4(z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.zwz swizzling.
        /// </summary>
        public decvec3 zwz => new decvec3(z, w, z);
        
        /// <summary>
        /// Returns decvec4.bab swizzling (equivalent to decvec4.zwz).
        /// </summary>
        public decvec3 bab => new decvec3(z, w, z);
        
        /// <summary>
        /// Returns decvec4.zwzx swizzling.
        /// </summary>
        public decvec4 zwzx => new decvec4(z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.babr swizzling (equivalent to decvec4.zwzx).
        /// </summary>
        public decvec4 babr => new decvec4(z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.zwzy swizzling.
        /// </summary>
        public decvec4 zwzy => new decvec4(z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.babg swizzling (equivalent to decvec4.zwzy).
        /// </summary>
        public decvec4 babg => new decvec4(z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.zwzz swizzling.
        /// </summary>
        public decvec4 zwzz => new decvec4(z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.babb swizzling (equivalent to decvec4.zwzz).
        /// </summary>
        public decvec4 babb => new decvec4(z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.zwzw swizzling.
        /// </summary>
        public decvec4 zwzw => new decvec4(z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.baba swizzling (equivalent to decvec4.zwzw).
        /// </summary>
        public decvec4 baba => new decvec4(z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.zww swizzling.
        /// </summary>
        public decvec3 zww => new decvec3(z, w, w);
        
        /// <summary>
        /// Returns decvec4.baa swizzling (equivalent to decvec4.zww).
        /// </summary>
        public decvec3 baa => new decvec3(z, w, w);
        
        /// <summary>
        /// Returns decvec4.zwwx swizzling.
        /// </summary>
        public decvec4 zwwx => new decvec4(z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.baar swizzling (equivalent to decvec4.zwwx).
        /// </summary>
        public decvec4 baar => new decvec4(z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.zwwy swizzling.
        /// </summary>
        public decvec4 zwwy => new decvec4(z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.baag swizzling (equivalent to decvec4.zwwy).
        /// </summary>
        public decvec4 baag => new decvec4(z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.zwwz swizzling.
        /// </summary>
        public decvec4 zwwz => new decvec4(z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.baab swizzling (equivalent to decvec4.zwwz).
        /// </summary>
        public decvec4 baab => new decvec4(z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.zwww swizzling.
        /// </summary>
        public decvec4 zwww => new decvec4(z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.baaa swizzling (equivalent to decvec4.zwww).
        /// </summary>
        public decvec4 baaa => new decvec4(z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.wx swizzling.
        /// </summary>
        public decvec2 wx => new decvec2(w, x);
        
        /// <summary>
        /// Returns decvec4.ar swizzling (equivalent to decvec4.wx).
        /// </summary>
        public decvec2 ar => new decvec2(w, x);
        
        /// <summary>
        /// Returns decvec4.wxx swizzling.
        /// </summary>
        public decvec3 wxx => new decvec3(w, x, x);
        
        /// <summary>
        /// Returns decvec4.arr swizzling (equivalent to decvec4.wxx).
        /// </summary>
        public decvec3 arr => new decvec3(w, x, x);
        
        /// <summary>
        /// Returns decvec4.wxxx swizzling.
        /// </summary>
        public decvec4 wxxx => new decvec4(w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.arrr swizzling (equivalent to decvec4.wxxx).
        /// </summary>
        public decvec4 arrr => new decvec4(w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.wxxy swizzling.
        /// </summary>
        public decvec4 wxxy => new decvec4(w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.arrg swizzling (equivalent to decvec4.wxxy).
        /// </summary>
        public decvec4 arrg => new decvec4(w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.wxxz swizzling.
        /// </summary>
        public decvec4 wxxz => new decvec4(w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.arrb swizzling (equivalent to decvec4.wxxz).
        /// </summary>
        public decvec4 arrb => new decvec4(w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.wxxw swizzling.
        /// </summary>
        public decvec4 wxxw => new decvec4(w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.arra swizzling (equivalent to decvec4.wxxw).
        /// </summary>
        public decvec4 arra => new decvec4(w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.wxy swizzling.
        /// </summary>
        public decvec3 wxy => new decvec3(w, x, y);
        
        /// <summary>
        /// Returns decvec4.arg swizzling (equivalent to decvec4.wxy).
        /// </summary>
        public decvec3 arg => new decvec3(w, x, y);
        
        /// <summary>
        /// Returns decvec4.wxyx swizzling.
        /// </summary>
        public decvec4 wxyx => new decvec4(w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.argr swizzling (equivalent to decvec4.wxyx).
        /// </summary>
        public decvec4 argr => new decvec4(w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.wxyy swizzling.
        /// </summary>
        public decvec4 wxyy => new decvec4(w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.argg swizzling (equivalent to decvec4.wxyy).
        /// </summary>
        public decvec4 argg => new decvec4(w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.wxyz swizzling.
        /// </summary>
        public decvec4 wxyz => new decvec4(w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.argb swizzling (equivalent to decvec4.wxyz).
        /// </summary>
        public decvec4 argb => new decvec4(w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.wxyw swizzling.
        /// </summary>
        public decvec4 wxyw => new decvec4(w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.arga swizzling (equivalent to decvec4.wxyw).
        /// </summary>
        public decvec4 arga => new decvec4(w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.wxz swizzling.
        /// </summary>
        public decvec3 wxz => new decvec3(w, x, z);
        
        /// <summary>
        /// Returns decvec4.arb swizzling (equivalent to decvec4.wxz).
        /// </summary>
        public decvec3 arb => new decvec3(w, x, z);
        
        /// <summary>
        /// Returns decvec4.wxzx swizzling.
        /// </summary>
        public decvec4 wxzx => new decvec4(w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.arbr swizzling (equivalent to decvec4.wxzx).
        /// </summary>
        public decvec4 arbr => new decvec4(w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.wxzy swizzling.
        /// </summary>
        public decvec4 wxzy => new decvec4(w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.arbg swizzling (equivalent to decvec4.wxzy).
        /// </summary>
        public decvec4 arbg => new decvec4(w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.wxzz swizzling.
        /// </summary>
        public decvec4 wxzz => new decvec4(w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.arbb swizzling (equivalent to decvec4.wxzz).
        /// </summary>
        public decvec4 arbb => new decvec4(w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.wxzw swizzling.
        /// </summary>
        public decvec4 wxzw => new decvec4(w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.arba swizzling (equivalent to decvec4.wxzw).
        /// </summary>
        public decvec4 arba => new decvec4(w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.wxw swizzling.
        /// </summary>
        public decvec3 wxw => new decvec3(w, x, w);
        
        /// <summary>
        /// Returns decvec4.ara swizzling (equivalent to decvec4.wxw).
        /// </summary>
        public decvec3 ara => new decvec3(w, x, w);
        
        /// <summary>
        /// Returns decvec4.wxwx swizzling.
        /// </summary>
        public decvec4 wxwx => new decvec4(w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.arar swizzling (equivalent to decvec4.wxwx).
        /// </summary>
        public decvec4 arar => new decvec4(w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.wxwy swizzling.
        /// </summary>
        public decvec4 wxwy => new decvec4(w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.arag swizzling (equivalent to decvec4.wxwy).
        /// </summary>
        public decvec4 arag => new decvec4(w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.wxwz swizzling.
        /// </summary>
        public decvec4 wxwz => new decvec4(w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.arab swizzling (equivalent to decvec4.wxwz).
        /// </summary>
        public decvec4 arab => new decvec4(w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.wxww swizzling.
        /// </summary>
        public decvec4 wxww => new decvec4(w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.araa swizzling (equivalent to decvec4.wxww).
        /// </summary>
        public decvec4 araa => new decvec4(w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.wy swizzling.
        /// </summary>
        public decvec2 wy => new decvec2(w, y);
        
        /// <summary>
        /// Returns decvec4.ag swizzling (equivalent to decvec4.wy).
        /// </summary>
        public decvec2 ag => new decvec2(w, y);
        
        /// <summary>
        /// Returns decvec4.wyx swizzling.
        /// </summary>
        public decvec3 wyx => new decvec3(w, y, x);
        
        /// <summary>
        /// Returns decvec4.agr swizzling (equivalent to decvec4.wyx).
        /// </summary>
        public decvec3 agr => new decvec3(w, y, x);
        
        /// <summary>
        /// Returns decvec4.wyxx swizzling.
        /// </summary>
        public decvec4 wyxx => new decvec4(w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.agrr swizzling (equivalent to decvec4.wyxx).
        /// </summary>
        public decvec4 agrr => new decvec4(w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.wyxy swizzling.
        /// </summary>
        public decvec4 wyxy => new decvec4(w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.agrg swizzling (equivalent to decvec4.wyxy).
        /// </summary>
        public decvec4 agrg => new decvec4(w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.wyxz swizzling.
        /// </summary>
        public decvec4 wyxz => new decvec4(w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.agrb swizzling (equivalent to decvec4.wyxz).
        /// </summary>
        public decvec4 agrb => new decvec4(w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.wyxw swizzling.
        /// </summary>
        public decvec4 wyxw => new decvec4(w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.agra swizzling (equivalent to decvec4.wyxw).
        /// </summary>
        public decvec4 agra => new decvec4(w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.wyy swizzling.
        /// </summary>
        public decvec3 wyy => new decvec3(w, y, y);
        
        /// <summary>
        /// Returns decvec4.agg swizzling (equivalent to decvec4.wyy).
        /// </summary>
        public decvec3 agg => new decvec3(w, y, y);
        
        /// <summary>
        /// Returns decvec4.wyyx swizzling.
        /// </summary>
        public decvec4 wyyx => new decvec4(w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.aggr swizzling (equivalent to decvec4.wyyx).
        /// </summary>
        public decvec4 aggr => new decvec4(w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.wyyy swizzling.
        /// </summary>
        public decvec4 wyyy => new decvec4(w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.aggg swizzling (equivalent to decvec4.wyyy).
        /// </summary>
        public decvec4 aggg => new decvec4(w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.wyyz swizzling.
        /// </summary>
        public decvec4 wyyz => new decvec4(w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.aggb swizzling (equivalent to decvec4.wyyz).
        /// </summary>
        public decvec4 aggb => new decvec4(w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.wyyw swizzling.
        /// </summary>
        public decvec4 wyyw => new decvec4(w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.agga swizzling (equivalent to decvec4.wyyw).
        /// </summary>
        public decvec4 agga => new decvec4(w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.wyz swizzling.
        /// </summary>
        public decvec3 wyz => new decvec3(w, y, z);
        
        /// <summary>
        /// Returns decvec4.agb swizzling (equivalent to decvec4.wyz).
        /// </summary>
        public decvec3 agb => new decvec3(w, y, z);
        
        /// <summary>
        /// Returns decvec4.wyzx swizzling.
        /// </summary>
        public decvec4 wyzx => new decvec4(w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.agbr swizzling (equivalent to decvec4.wyzx).
        /// </summary>
        public decvec4 agbr => new decvec4(w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.wyzy swizzling.
        /// </summary>
        public decvec4 wyzy => new decvec4(w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.agbg swizzling (equivalent to decvec4.wyzy).
        /// </summary>
        public decvec4 agbg => new decvec4(w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.wyzz swizzling.
        /// </summary>
        public decvec4 wyzz => new decvec4(w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.agbb swizzling (equivalent to decvec4.wyzz).
        /// </summary>
        public decvec4 agbb => new decvec4(w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.wyzw swizzling.
        /// </summary>
        public decvec4 wyzw => new decvec4(w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.agba swizzling (equivalent to decvec4.wyzw).
        /// </summary>
        public decvec4 agba => new decvec4(w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.wyw swizzling.
        /// </summary>
        public decvec3 wyw => new decvec3(w, y, w);
        
        /// <summary>
        /// Returns decvec4.aga swizzling (equivalent to decvec4.wyw).
        /// </summary>
        public decvec3 aga => new decvec3(w, y, w);
        
        /// <summary>
        /// Returns decvec4.wywx swizzling.
        /// </summary>
        public decvec4 wywx => new decvec4(w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.agar swizzling (equivalent to decvec4.wywx).
        /// </summary>
        public decvec4 agar => new decvec4(w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.wywy swizzling.
        /// </summary>
        public decvec4 wywy => new decvec4(w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.agag swizzling (equivalent to decvec4.wywy).
        /// </summary>
        public decvec4 agag => new decvec4(w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.wywz swizzling.
        /// </summary>
        public decvec4 wywz => new decvec4(w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.agab swizzling (equivalent to decvec4.wywz).
        /// </summary>
        public decvec4 agab => new decvec4(w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.wyww swizzling.
        /// </summary>
        public decvec4 wyww => new decvec4(w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.agaa swizzling (equivalent to decvec4.wyww).
        /// </summary>
        public decvec4 agaa => new decvec4(w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.wz swizzling.
        /// </summary>
        public decvec2 wz => new decvec2(w, z);
        
        /// <summary>
        /// Returns decvec4.ab swizzling (equivalent to decvec4.wz).
        /// </summary>
        public decvec2 ab => new decvec2(w, z);
        
        /// <summary>
        /// Returns decvec4.wzx swizzling.
        /// </summary>
        public decvec3 wzx => new decvec3(w, z, x);
        
        /// <summary>
        /// Returns decvec4.abr swizzling (equivalent to decvec4.wzx).
        /// </summary>
        public decvec3 abr => new decvec3(w, z, x);
        
        /// <summary>
        /// Returns decvec4.wzxx swizzling.
        /// </summary>
        public decvec4 wzxx => new decvec4(w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.abrr swizzling (equivalent to decvec4.wzxx).
        /// </summary>
        public decvec4 abrr => new decvec4(w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.wzxy swizzling.
        /// </summary>
        public decvec4 wzxy => new decvec4(w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.abrg swizzling (equivalent to decvec4.wzxy).
        /// </summary>
        public decvec4 abrg => new decvec4(w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.wzxz swizzling.
        /// </summary>
        public decvec4 wzxz => new decvec4(w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.abrb swizzling (equivalent to decvec4.wzxz).
        /// </summary>
        public decvec4 abrb => new decvec4(w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.wzxw swizzling.
        /// </summary>
        public decvec4 wzxw => new decvec4(w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.abra swizzling (equivalent to decvec4.wzxw).
        /// </summary>
        public decvec4 abra => new decvec4(w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.wzy swizzling.
        /// </summary>
        public decvec3 wzy => new decvec3(w, z, y);
        
        /// <summary>
        /// Returns decvec4.abg swizzling (equivalent to decvec4.wzy).
        /// </summary>
        public decvec3 abg => new decvec3(w, z, y);
        
        /// <summary>
        /// Returns decvec4.wzyx swizzling.
        /// </summary>
        public decvec4 wzyx => new decvec4(w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.abgr swizzling (equivalent to decvec4.wzyx).
        /// </summary>
        public decvec4 abgr => new decvec4(w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.wzyy swizzling.
        /// </summary>
        public decvec4 wzyy => new decvec4(w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.abgg swizzling (equivalent to decvec4.wzyy).
        /// </summary>
        public decvec4 abgg => new decvec4(w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.wzyz swizzling.
        /// </summary>
        public decvec4 wzyz => new decvec4(w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.abgb swizzling (equivalent to decvec4.wzyz).
        /// </summary>
        public decvec4 abgb => new decvec4(w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.wzyw swizzling.
        /// </summary>
        public decvec4 wzyw => new decvec4(w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.abga swizzling (equivalent to decvec4.wzyw).
        /// </summary>
        public decvec4 abga => new decvec4(w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.wzz swizzling.
        /// </summary>
        public decvec3 wzz => new decvec3(w, z, z);
        
        /// <summary>
        /// Returns decvec4.abb swizzling (equivalent to decvec4.wzz).
        /// </summary>
        public decvec3 abb => new decvec3(w, z, z);
        
        /// <summary>
        /// Returns decvec4.wzzx swizzling.
        /// </summary>
        public decvec4 wzzx => new decvec4(w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.abbr swizzling (equivalent to decvec4.wzzx).
        /// </summary>
        public decvec4 abbr => new decvec4(w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.wzzy swizzling.
        /// </summary>
        public decvec4 wzzy => new decvec4(w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.abbg swizzling (equivalent to decvec4.wzzy).
        /// </summary>
        public decvec4 abbg => new decvec4(w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.wzzz swizzling.
        /// </summary>
        public decvec4 wzzz => new decvec4(w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.abbb swizzling (equivalent to decvec4.wzzz).
        /// </summary>
        public decvec4 abbb => new decvec4(w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.wzzw swizzling.
        /// </summary>
        public decvec4 wzzw => new decvec4(w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.abba swizzling (equivalent to decvec4.wzzw).
        /// </summary>
        public decvec4 abba => new decvec4(w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.wzw swizzling.
        /// </summary>
        public decvec3 wzw => new decvec3(w, z, w);
        
        /// <summary>
        /// Returns decvec4.aba swizzling (equivalent to decvec4.wzw).
        /// </summary>
        public decvec3 aba => new decvec3(w, z, w);
        
        /// <summary>
        /// Returns decvec4.wzwx swizzling.
        /// </summary>
        public decvec4 wzwx => new decvec4(w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.abar swizzling (equivalent to decvec4.wzwx).
        /// </summary>
        public decvec4 abar => new decvec4(w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.wzwy swizzling.
        /// </summary>
        public decvec4 wzwy => new decvec4(w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.abag swizzling (equivalent to decvec4.wzwy).
        /// </summary>
        public decvec4 abag => new decvec4(w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.wzwz swizzling.
        /// </summary>
        public decvec4 wzwz => new decvec4(w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.abab swizzling (equivalent to decvec4.wzwz).
        /// </summary>
        public decvec4 abab => new decvec4(w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.wzww swizzling.
        /// </summary>
        public decvec4 wzww => new decvec4(w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.abaa swizzling (equivalent to decvec4.wzww).
        /// </summary>
        public decvec4 abaa => new decvec4(w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.ww swizzling.
        /// </summary>
        public decvec2 ww => new decvec2(w, w);
        
        /// <summary>
        /// Returns decvec4.aa swizzling (equivalent to decvec4.ww).
        /// </summary>
        public decvec2 aa => new decvec2(w, w);
        
        /// <summary>
        /// Returns decvec4.wwx swizzling.
        /// </summary>
        public decvec3 wwx => new decvec3(w, w, x);
        
        /// <summary>
        /// Returns decvec4.aar swizzling (equivalent to decvec4.wwx).
        /// </summary>
        public decvec3 aar => new decvec3(w, w, x);
        
        /// <summary>
        /// Returns decvec4.wwxx swizzling.
        /// </summary>
        public decvec4 wwxx => new decvec4(w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.aarr swizzling (equivalent to decvec4.wwxx).
        /// </summary>
        public decvec4 aarr => new decvec4(w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.wwxy swizzling.
        /// </summary>
        public decvec4 wwxy => new decvec4(w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.aarg swizzling (equivalent to decvec4.wwxy).
        /// </summary>
        public decvec4 aarg => new decvec4(w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.wwxz swizzling.
        /// </summary>
        public decvec4 wwxz => new decvec4(w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.aarb swizzling (equivalent to decvec4.wwxz).
        /// </summary>
        public decvec4 aarb => new decvec4(w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.wwxw swizzling.
        /// </summary>
        public decvec4 wwxw => new decvec4(w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.aara swizzling (equivalent to decvec4.wwxw).
        /// </summary>
        public decvec4 aara => new decvec4(w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.wwy swizzling.
        /// </summary>
        public decvec3 wwy => new decvec3(w, w, y);
        
        /// <summary>
        /// Returns decvec4.aag swizzling (equivalent to decvec4.wwy).
        /// </summary>
        public decvec3 aag => new decvec3(w, w, y);
        
        /// <summary>
        /// Returns decvec4.wwyx swizzling.
        /// </summary>
        public decvec4 wwyx => new decvec4(w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.aagr swizzling (equivalent to decvec4.wwyx).
        /// </summary>
        public decvec4 aagr => new decvec4(w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.wwyy swizzling.
        /// </summary>
        public decvec4 wwyy => new decvec4(w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.aagg swizzling (equivalent to decvec4.wwyy).
        /// </summary>
        public decvec4 aagg => new decvec4(w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.wwyz swizzling.
        /// </summary>
        public decvec4 wwyz => new decvec4(w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.aagb swizzling (equivalent to decvec4.wwyz).
        /// </summary>
        public decvec4 aagb => new decvec4(w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.wwyw swizzling.
        /// </summary>
        public decvec4 wwyw => new decvec4(w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.aaga swizzling (equivalent to decvec4.wwyw).
        /// </summary>
        public decvec4 aaga => new decvec4(w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.wwz swizzling.
        /// </summary>
        public decvec3 wwz => new decvec3(w, w, z);
        
        /// <summary>
        /// Returns decvec4.aab swizzling (equivalent to decvec4.wwz).
        /// </summary>
        public decvec3 aab => new decvec3(w, w, z);
        
        /// <summary>
        /// Returns decvec4.wwzx swizzling.
        /// </summary>
        public decvec4 wwzx => new decvec4(w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.aabr swizzling (equivalent to decvec4.wwzx).
        /// </summary>
        public decvec4 aabr => new decvec4(w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.wwzy swizzling.
        /// </summary>
        public decvec4 wwzy => new decvec4(w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.aabg swizzling (equivalent to decvec4.wwzy).
        /// </summary>
        public decvec4 aabg => new decvec4(w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.wwzz swizzling.
        /// </summary>
        public decvec4 wwzz => new decvec4(w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.aabb swizzling (equivalent to decvec4.wwzz).
        /// </summary>
        public decvec4 aabb => new decvec4(w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.wwzw swizzling.
        /// </summary>
        public decvec4 wwzw => new decvec4(w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.aaba swizzling (equivalent to decvec4.wwzw).
        /// </summary>
        public decvec4 aaba => new decvec4(w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.www swizzling.
        /// </summary>
        public decvec3 www => new decvec3(w, w, w);
        
        /// <summary>
        /// Returns decvec4.aaa swizzling (equivalent to decvec4.www).
        /// </summary>
        public decvec3 aaa => new decvec3(w, w, w);
        
        /// <summary>
        /// Returns decvec4.wwwx swizzling.
        /// </summary>
        public decvec4 wwwx => new decvec4(w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.aaar swizzling (equivalent to decvec4.wwwx).
        /// </summary>
        public decvec4 aaar => new decvec4(w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.wwwy swizzling.
        /// </summary>
        public decvec4 wwwy => new decvec4(w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.aaag swizzling (equivalent to decvec4.wwwy).
        /// </summary>
        public decvec4 aaag => new decvec4(w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.wwwz swizzling.
        /// </summary>
        public decvec4 wwwz => new decvec4(w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.aaab swizzling (equivalent to decvec4.wwwz).
        /// </summary>
        public decvec4 aaab => new decvec4(w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.wwww swizzling.
        /// </summary>
        public decvec4 wwww => new decvec4(w, w, w, w);
        
        /// <summary>
        /// Returns decvec4.aaaa swizzling (equivalent to decvec4.wwww).
        /// </summary>
        public decvec4 aaaa => new decvec4(w, w, w, w);

        #endregion

    }
}
