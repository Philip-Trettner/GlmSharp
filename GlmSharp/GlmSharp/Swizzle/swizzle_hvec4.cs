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
    /// Temporary vector of type Half with 4 components, used for implementing swizzling for hvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_hvec4
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
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly Half w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_hvec4.
        /// </summary>
        internal swizzle_hvec4(Half x, Half y, Half z, Half w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns hvec4.xx swizzling.
        /// </summary>
        public hvec2 xx => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec4.rr swizzling (equivalent to hvec4.xx).
        /// </summary>
        public hvec2 rr => new hvec2(x, x);
        
        /// <summary>
        /// Returns hvec4.xxx swizzling.
        /// </summary>
        public hvec3 xxx => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec4.rrr swizzling (equivalent to hvec4.xxx).
        /// </summary>
        public hvec3 rrr => new hvec3(x, x, x);
        
        /// <summary>
        /// Returns hvec4.xxxx swizzling.
        /// </summary>
        public hvec4 xxxx => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.rrrr swizzling (equivalent to hvec4.xxxx).
        /// </summary>
        public hvec4 rrrr => new hvec4(x, x, x, x);
        
        /// <summary>
        /// Returns hvec4.xxxy swizzling.
        /// </summary>
        public hvec4 xxxy => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.rrrg swizzling (equivalent to hvec4.xxxy).
        /// </summary>
        public hvec4 rrrg => new hvec4(x, x, x, y);
        
        /// <summary>
        /// Returns hvec4.xxxz swizzling.
        /// </summary>
        public hvec4 xxxz => new hvec4(x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.rrrb swizzling (equivalent to hvec4.xxxz).
        /// </summary>
        public hvec4 rrrb => new hvec4(x, x, x, z);
        
        /// <summary>
        /// Returns hvec4.xxxw swizzling.
        /// </summary>
        public hvec4 xxxw => new hvec4(x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.rrra swizzling (equivalent to hvec4.xxxw).
        /// </summary>
        public hvec4 rrra => new hvec4(x, x, x, w);
        
        /// <summary>
        /// Returns hvec4.xxy swizzling.
        /// </summary>
        public hvec3 xxy => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec4.rrg swizzling (equivalent to hvec4.xxy).
        /// </summary>
        public hvec3 rrg => new hvec3(x, x, y);
        
        /// <summary>
        /// Returns hvec4.xxyx swizzling.
        /// </summary>
        public hvec4 xxyx => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.rrgr swizzling (equivalent to hvec4.xxyx).
        /// </summary>
        public hvec4 rrgr => new hvec4(x, x, y, x);
        
        /// <summary>
        /// Returns hvec4.xxyy swizzling.
        /// </summary>
        public hvec4 xxyy => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.rrgg swizzling (equivalent to hvec4.xxyy).
        /// </summary>
        public hvec4 rrgg => new hvec4(x, x, y, y);
        
        /// <summary>
        /// Returns hvec4.xxyz swizzling.
        /// </summary>
        public hvec4 xxyz => new hvec4(x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.rrgb swizzling (equivalent to hvec4.xxyz).
        /// </summary>
        public hvec4 rrgb => new hvec4(x, x, y, z);
        
        /// <summary>
        /// Returns hvec4.xxyw swizzling.
        /// </summary>
        public hvec4 xxyw => new hvec4(x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.rrga swizzling (equivalent to hvec4.xxyw).
        /// </summary>
        public hvec4 rrga => new hvec4(x, x, y, w);
        
        /// <summary>
        /// Returns hvec4.xxz swizzling.
        /// </summary>
        public hvec3 xxz => new hvec3(x, x, z);
        
        /// <summary>
        /// Returns hvec4.rrb swizzling (equivalent to hvec4.xxz).
        /// </summary>
        public hvec3 rrb => new hvec3(x, x, z);
        
        /// <summary>
        /// Returns hvec4.xxzx swizzling.
        /// </summary>
        public hvec4 xxzx => new hvec4(x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.rrbr swizzling (equivalent to hvec4.xxzx).
        /// </summary>
        public hvec4 rrbr => new hvec4(x, x, z, x);
        
        /// <summary>
        /// Returns hvec4.xxzy swizzling.
        /// </summary>
        public hvec4 xxzy => new hvec4(x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.rrbg swizzling (equivalent to hvec4.xxzy).
        /// </summary>
        public hvec4 rrbg => new hvec4(x, x, z, y);
        
        /// <summary>
        /// Returns hvec4.xxzz swizzling.
        /// </summary>
        public hvec4 xxzz => new hvec4(x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.rrbb swizzling (equivalent to hvec4.xxzz).
        /// </summary>
        public hvec4 rrbb => new hvec4(x, x, z, z);
        
        /// <summary>
        /// Returns hvec4.xxzw swizzling.
        /// </summary>
        public hvec4 xxzw => new hvec4(x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.rrba swizzling (equivalent to hvec4.xxzw).
        /// </summary>
        public hvec4 rrba => new hvec4(x, x, z, w);
        
        /// <summary>
        /// Returns hvec4.xxw swizzling.
        /// </summary>
        public hvec3 xxw => new hvec3(x, x, w);
        
        /// <summary>
        /// Returns hvec4.rra swizzling (equivalent to hvec4.xxw).
        /// </summary>
        public hvec3 rra => new hvec3(x, x, w);
        
        /// <summary>
        /// Returns hvec4.xxwx swizzling.
        /// </summary>
        public hvec4 xxwx => new hvec4(x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.rrar swizzling (equivalent to hvec4.xxwx).
        /// </summary>
        public hvec4 rrar => new hvec4(x, x, w, x);
        
        /// <summary>
        /// Returns hvec4.xxwy swizzling.
        /// </summary>
        public hvec4 xxwy => new hvec4(x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.rrag swizzling (equivalent to hvec4.xxwy).
        /// </summary>
        public hvec4 rrag => new hvec4(x, x, w, y);
        
        /// <summary>
        /// Returns hvec4.xxwz swizzling.
        /// </summary>
        public hvec4 xxwz => new hvec4(x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.rrab swizzling (equivalent to hvec4.xxwz).
        /// </summary>
        public hvec4 rrab => new hvec4(x, x, w, z);
        
        /// <summary>
        /// Returns hvec4.xxww swizzling.
        /// </summary>
        public hvec4 xxww => new hvec4(x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.rraa swizzling (equivalent to hvec4.xxww).
        /// </summary>
        public hvec4 rraa => new hvec4(x, x, w, w);
        
        /// <summary>
        /// Returns hvec4.xy swizzling.
        /// </summary>
        public hvec2 xy => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec4.rg swizzling (equivalent to hvec4.xy).
        /// </summary>
        public hvec2 rg => new hvec2(x, y);
        
        /// <summary>
        /// Returns hvec4.xyx swizzling.
        /// </summary>
        public hvec3 xyx => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec4.rgr swizzling (equivalent to hvec4.xyx).
        /// </summary>
        public hvec3 rgr => new hvec3(x, y, x);
        
        /// <summary>
        /// Returns hvec4.xyxx swizzling.
        /// </summary>
        public hvec4 xyxx => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.rgrr swizzling (equivalent to hvec4.xyxx).
        /// </summary>
        public hvec4 rgrr => new hvec4(x, y, x, x);
        
        /// <summary>
        /// Returns hvec4.xyxy swizzling.
        /// </summary>
        public hvec4 xyxy => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.rgrg swizzling (equivalent to hvec4.xyxy).
        /// </summary>
        public hvec4 rgrg => new hvec4(x, y, x, y);
        
        /// <summary>
        /// Returns hvec4.xyxz swizzling.
        /// </summary>
        public hvec4 xyxz => new hvec4(x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.rgrb swizzling (equivalent to hvec4.xyxz).
        /// </summary>
        public hvec4 rgrb => new hvec4(x, y, x, z);
        
        /// <summary>
        /// Returns hvec4.xyxw swizzling.
        /// </summary>
        public hvec4 xyxw => new hvec4(x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.rgra swizzling (equivalent to hvec4.xyxw).
        /// </summary>
        public hvec4 rgra => new hvec4(x, y, x, w);
        
        /// <summary>
        /// Returns hvec4.xyy swizzling.
        /// </summary>
        public hvec3 xyy => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec4.rgg swizzling (equivalent to hvec4.xyy).
        /// </summary>
        public hvec3 rgg => new hvec3(x, y, y);
        
        /// <summary>
        /// Returns hvec4.xyyx swizzling.
        /// </summary>
        public hvec4 xyyx => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.rggr swizzling (equivalent to hvec4.xyyx).
        /// </summary>
        public hvec4 rggr => new hvec4(x, y, y, x);
        
        /// <summary>
        /// Returns hvec4.xyyy swizzling.
        /// </summary>
        public hvec4 xyyy => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.rggg swizzling (equivalent to hvec4.xyyy).
        /// </summary>
        public hvec4 rggg => new hvec4(x, y, y, y);
        
        /// <summary>
        /// Returns hvec4.xyyz swizzling.
        /// </summary>
        public hvec4 xyyz => new hvec4(x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.rggb swizzling (equivalent to hvec4.xyyz).
        /// </summary>
        public hvec4 rggb => new hvec4(x, y, y, z);
        
        /// <summary>
        /// Returns hvec4.xyyw swizzling.
        /// </summary>
        public hvec4 xyyw => new hvec4(x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.rgga swizzling (equivalent to hvec4.xyyw).
        /// </summary>
        public hvec4 rgga => new hvec4(x, y, y, w);
        
        /// <summary>
        /// Returns hvec4.xyz swizzling.
        /// </summary>
        public hvec3 xyz => new hvec3(x, y, z);
        
        /// <summary>
        /// Returns hvec4.rgb swizzling (equivalent to hvec4.xyz).
        /// </summary>
        public hvec3 rgb => new hvec3(x, y, z);
        
        /// <summary>
        /// Returns hvec4.xyzx swizzling.
        /// </summary>
        public hvec4 xyzx => new hvec4(x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.rgbr swizzling (equivalent to hvec4.xyzx).
        /// </summary>
        public hvec4 rgbr => new hvec4(x, y, z, x);
        
        /// <summary>
        /// Returns hvec4.xyzy swizzling.
        /// </summary>
        public hvec4 xyzy => new hvec4(x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.rgbg swizzling (equivalent to hvec4.xyzy).
        /// </summary>
        public hvec4 rgbg => new hvec4(x, y, z, y);
        
        /// <summary>
        /// Returns hvec4.xyzz swizzling.
        /// </summary>
        public hvec4 xyzz => new hvec4(x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.rgbb swizzling (equivalent to hvec4.xyzz).
        /// </summary>
        public hvec4 rgbb => new hvec4(x, y, z, z);
        
        /// <summary>
        /// Returns hvec4.xyzw swizzling.
        /// </summary>
        public hvec4 xyzw => new hvec4(x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.rgba swizzling (equivalent to hvec4.xyzw).
        /// </summary>
        public hvec4 rgba => new hvec4(x, y, z, w);
        
        /// <summary>
        /// Returns hvec4.xyw swizzling.
        /// </summary>
        public hvec3 xyw => new hvec3(x, y, w);
        
        /// <summary>
        /// Returns hvec4.rga swizzling (equivalent to hvec4.xyw).
        /// </summary>
        public hvec3 rga => new hvec3(x, y, w);
        
        /// <summary>
        /// Returns hvec4.xywx swizzling.
        /// </summary>
        public hvec4 xywx => new hvec4(x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.rgar swizzling (equivalent to hvec4.xywx).
        /// </summary>
        public hvec4 rgar => new hvec4(x, y, w, x);
        
        /// <summary>
        /// Returns hvec4.xywy swizzling.
        /// </summary>
        public hvec4 xywy => new hvec4(x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.rgag swizzling (equivalent to hvec4.xywy).
        /// </summary>
        public hvec4 rgag => new hvec4(x, y, w, y);
        
        /// <summary>
        /// Returns hvec4.xywz swizzling.
        /// </summary>
        public hvec4 xywz => new hvec4(x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.rgab swizzling (equivalent to hvec4.xywz).
        /// </summary>
        public hvec4 rgab => new hvec4(x, y, w, z);
        
        /// <summary>
        /// Returns hvec4.xyww swizzling.
        /// </summary>
        public hvec4 xyww => new hvec4(x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.rgaa swizzling (equivalent to hvec4.xyww).
        /// </summary>
        public hvec4 rgaa => new hvec4(x, y, w, w);
        
        /// <summary>
        /// Returns hvec4.xz swizzling.
        /// </summary>
        public hvec2 xz => new hvec2(x, z);
        
        /// <summary>
        /// Returns hvec4.rb swizzling (equivalent to hvec4.xz).
        /// </summary>
        public hvec2 rb => new hvec2(x, z);
        
        /// <summary>
        /// Returns hvec4.xzx swizzling.
        /// </summary>
        public hvec3 xzx => new hvec3(x, z, x);
        
        /// <summary>
        /// Returns hvec4.rbr swizzling (equivalent to hvec4.xzx).
        /// </summary>
        public hvec3 rbr => new hvec3(x, z, x);
        
        /// <summary>
        /// Returns hvec4.xzxx swizzling.
        /// </summary>
        public hvec4 xzxx => new hvec4(x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.rbrr swizzling (equivalent to hvec4.xzxx).
        /// </summary>
        public hvec4 rbrr => new hvec4(x, z, x, x);
        
        /// <summary>
        /// Returns hvec4.xzxy swizzling.
        /// </summary>
        public hvec4 xzxy => new hvec4(x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.rbrg swizzling (equivalent to hvec4.xzxy).
        /// </summary>
        public hvec4 rbrg => new hvec4(x, z, x, y);
        
        /// <summary>
        /// Returns hvec4.xzxz swizzling.
        /// </summary>
        public hvec4 xzxz => new hvec4(x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.rbrb swizzling (equivalent to hvec4.xzxz).
        /// </summary>
        public hvec4 rbrb => new hvec4(x, z, x, z);
        
        /// <summary>
        /// Returns hvec4.xzxw swizzling.
        /// </summary>
        public hvec4 xzxw => new hvec4(x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.rbra swizzling (equivalent to hvec4.xzxw).
        /// </summary>
        public hvec4 rbra => new hvec4(x, z, x, w);
        
        /// <summary>
        /// Returns hvec4.xzy swizzling.
        /// </summary>
        public hvec3 xzy => new hvec3(x, z, y);
        
        /// <summary>
        /// Returns hvec4.rbg swizzling (equivalent to hvec4.xzy).
        /// </summary>
        public hvec3 rbg => new hvec3(x, z, y);
        
        /// <summary>
        /// Returns hvec4.xzyx swizzling.
        /// </summary>
        public hvec4 xzyx => new hvec4(x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.rbgr swizzling (equivalent to hvec4.xzyx).
        /// </summary>
        public hvec4 rbgr => new hvec4(x, z, y, x);
        
        /// <summary>
        /// Returns hvec4.xzyy swizzling.
        /// </summary>
        public hvec4 xzyy => new hvec4(x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.rbgg swizzling (equivalent to hvec4.xzyy).
        /// </summary>
        public hvec4 rbgg => new hvec4(x, z, y, y);
        
        /// <summary>
        /// Returns hvec4.xzyz swizzling.
        /// </summary>
        public hvec4 xzyz => new hvec4(x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.rbgb swizzling (equivalent to hvec4.xzyz).
        /// </summary>
        public hvec4 rbgb => new hvec4(x, z, y, z);
        
        /// <summary>
        /// Returns hvec4.xzyw swizzling.
        /// </summary>
        public hvec4 xzyw => new hvec4(x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.rbga swizzling (equivalent to hvec4.xzyw).
        /// </summary>
        public hvec4 rbga => new hvec4(x, z, y, w);
        
        /// <summary>
        /// Returns hvec4.xzz swizzling.
        /// </summary>
        public hvec3 xzz => new hvec3(x, z, z);
        
        /// <summary>
        /// Returns hvec4.rbb swizzling (equivalent to hvec4.xzz).
        /// </summary>
        public hvec3 rbb => new hvec3(x, z, z);
        
        /// <summary>
        /// Returns hvec4.xzzx swizzling.
        /// </summary>
        public hvec4 xzzx => new hvec4(x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.rbbr swizzling (equivalent to hvec4.xzzx).
        /// </summary>
        public hvec4 rbbr => new hvec4(x, z, z, x);
        
        /// <summary>
        /// Returns hvec4.xzzy swizzling.
        /// </summary>
        public hvec4 xzzy => new hvec4(x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.rbbg swizzling (equivalent to hvec4.xzzy).
        /// </summary>
        public hvec4 rbbg => new hvec4(x, z, z, y);
        
        /// <summary>
        /// Returns hvec4.xzzz swizzling.
        /// </summary>
        public hvec4 xzzz => new hvec4(x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.rbbb swizzling (equivalent to hvec4.xzzz).
        /// </summary>
        public hvec4 rbbb => new hvec4(x, z, z, z);
        
        /// <summary>
        /// Returns hvec4.xzzw swizzling.
        /// </summary>
        public hvec4 xzzw => new hvec4(x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.rbba swizzling (equivalent to hvec4.xzzw).
        /// </summary>
        public hvec4 rbba => new hvec4(x, z, z, w);
        
        /// <summary>
        /// Returns hvec4.xzw swizzling.
        /// </summary>
        public hvec3 xzw => new hvec3(x, z, w);
        
        /// <summary>
        /// Returns hvec4.rba swizzling (equivalent to hvec4.xzw).
        /// </summary>
        public hvec3 rba => new hvec3(x, z, w);
        
        /// <summary>
        /// Returns hvec4.xzwx swizzling.
        /// </summary>
        public hvec4 xzwx => new hvec4(x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.rbar swizzling (equivalent to hvec4.xzwx).
        /// </summary>
        public hvec4 rbar => new hvec4(x, z, w, x);
        
        /// <summary>
        /// Returns hvec4.xzwy swizzling.
        /// </summary>
        public hvec4 xzwy => new hvec4(x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.rbag swizzling (equivalent to hvec4.xzwy).
        /// </summary>
        public hvec4 rbag => new hvec4(x, z, w, y);
        
        /// <summary>
        /// Returns hvec4.xzwz swizzling.
        /// </summary>
        public hvec4 xzwz => new hvec4(x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.rbab swizzling (equivalent to hvec4.xzwz).
        /// </summary>
        public hvec4 rbab => new hvec4(x, z, w, z);
        
        /// <summary>
        /// Returns hvec4.xzww swizzling.
        /// </summary>
        public hvec4 xzww => new hvec4(x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.rbaa swizzling (equivalent to hvec4.xzww).
        /// </summary>
        public hvec4 rbaa => new hvec4(x, z, w, w);
        
        /// <summary>
        /// Returns hvec4.xw swizzling.
        /// </summary>
        public hvec2 xw => new hvec2(x, w);
        
        /// <summary>
        /// Returns hvec4.ra swizzling (equivalent to hvec4.xw).
        /// </summary>
        public hvec2 ra => new hvec2(x, w);
        
        /// <summary>
        /// Returns hvec4.xwx swizzling.
        /// </summary>
        public hvec3 xwx => new hvec3(x, w, x);
        
        /// <summary>
        /// Returns hvec4.rar swizzling (equivalent to hvec4.xwx).
        /// </summary>
        public hvec3 rar => new hvec3(x, w, x);
        
        /// <summary>
        /// Returns hvec4.xwxx swizzling.
        /// </summary>
        public hvec4 xwxx => new hvec4(x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.rarr swizzling (equivalent to hvec4.xwxx).
        /// </summary>
        public hvec4 rarr => new hvec4(x, w, x, x);
        
        /// <summary>
        /// Returns hvec4.xwxy swizzling.
        /// </summary>
        public hvec4 xwxy => new hvec4(x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.rarg swizzling (equivalent to hvec4.xwxy).
        /// </summary>
        public hvec4 rarg => new hvec4(x, w, x, y);
        
        /// <summary>
        /// Returns hvec4.xwxz swizzling.
        /// </summary>
        public hvec4 xwxz => new hvec4(x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.rarb swizzling (equivalent to hvec4.xwxz).
        /// </summary>
        public hvec4 rarb => new hvec4(x, w, x, z);
        
        /// <summary>
        /// Returns hvec4.xwxw swizzling.
        /// </summary>
        public hvec4 xwxw => new hvec4(x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.rara swizzling (equivalent to hvec4.xwxw).
        /// </summary>
        public hvec4 rara => new hvec4(x, w, x, w);
        
        /// <summary>
        /// Returns hvec4.xwy swizzling.
        /// </summary>
        public hvec3 xwy => new hvec3(x, w, y);
        
        /// <summary>
        /// Returns hvec4.rag swizzling (equivalent to hvec4.xwy).
        /// </summary>
        public hvec3 rag => new hvec3(x, w, y);
        
        /// <summary>
        /// Returns hvec4.xwyx swizzling.
        /// </summary>
        public hvec4 xwyx => new hvec4(x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.ragr swizzling (equivalent to hvec4.xwyx).
        /// </summary>
        public hvec4 ragr => new hvec4(x, w, y, x);
        
        /// <summary>
        /// Returns hvec4.xwyy swizzling.
        /// </summary>
        public hvec4 xwyy => new hvec4(x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.ragg swizzling (equivalent to hvec4.xwyy).
        /// </summary>
        public hvec4 ragg => new hvec4(x, w, y, y);
        
        /// <summary>
        /// Returns hvec4.xwyz swizzling.
        /// </summary>
        public hvec4 xwyz => new hvec4(x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.ragb swizzling (equivalent to hvec4.xwyz).
        /// </summary>
        public hvec4 ragb => new hvec4(x, w, y, z);
        
        /// <summary>
        /// Returns hvec4.xwyw swizzling.
        /// </summary>
        public hvec4 xwyw => new hvec4(x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.raga swizzling (equivalent to hvec4.xwyw).
        /// </summary>
        public hvec4 raga => new hvec4(x, w, y, w);
        
        /// <summary>
        /// Returns hvec4.xwz swizzling.
        /// </summary>
        public hvec3 xwz => new hvec3(x, w, z);
        
        /// <summary>
        /// Returns hvec4.rab swizzling (equivalent to hvec4.xwz).
        /// </summary>
        public hvec3 rab => new hvec3(x, w, z);
        
        /// <summary>
        /// Returns hvec4.xwzx swizzling.
        /// </summary>
        public hvec4 xwzx => new hvec4(x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.rabr swizzling (equivalent to hvec4.xwzx).
        /// </summary>
        public hvec4 rabr => new hvec4(x, w, z, x);
        
        /// <summary>
        /// Returns hvec4.xwzy swizzling.
        /// </summary>
        public hvec4 xwzy => new hvec4(x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.rabg swizzling (equivalent to hvec4.xwzy).
        /// </summary>
        public hvec4 rabg => new hvec4(x, w, z, y);
        
        /// <summary>
        /// Returns hvec4.xwzz swizzling.
        /// </summary>
        public hvec4 xwzz => new hvec4(x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.rabb swizzling (equivalent to hvec4.xwzz).
        /// </summary>
        public hvec4 rabb => new hvec4(x, w, z, z);
        
        /// <summary>
        /// Returns hvec4.xwzw swizzling.
        /// </summary>
        public hvec4 xwzw => new hvec4(x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.raba swizzling (equivalent to hvec4.xwzw).
        /// </summary>
        public hvec4 raba => new hvec4(x, w, z, w);
        
        /// <summary>
        /// Returns hvec4.xww swizzling.
        /// </summary>
        public hvec3 xww => new hvec3(x, w, w);
        
        /// <summary>
        /// Returns hvec4.raa swizzling (equivalent to hvec4.xww).
        /// </summary>
        public hvec3 raa => new hvec3(x, w, w);
        
        /// <summary>
        /// Returns hvec4.xwwx swizzling.
        /// </summary>
        public hvec4 xwwx => new hvec4(x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.raar swizzling (equivalent to hvec4.xwwx).
        /// </summary>
        public hvec4 raar => new hvec4(x, w, w, x);
        
        /// <summary>
        /// Returns hvec4.xwwy swizzling.
        /// </summary>
        public hvec4 xwwy => new hvec4(x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.raag swizzling (equivalent to hvec4.xwwy).
        /// </summary>
        public hvec4 raag => new hvec4(x, w, w, y);
        
        /// <summary>
        /// Returns hvec4.xwwz swizzling.
        /// </summary>
        public hvec4 xwwz => new hvec4(x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.raab swizzling (equivalent to hvec4.xwwz).
        /// </summary>
        public hvec4 raab => new hvec4(x, w, w, z);
        
        /// <summary>
        /// Returns hvec4.xwww swizzling.
        /// </summary>
        public hvec4 xwww => new hvec4(x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.raaa swizzling (equivalent to hvec4.xwww).
        /// </summary>
        public hvec4 raaa => new hvec4(x, w, w, w);
        
        /// <summary>
        /// Returns hvec4.yx swizzling.
        /// </summary>
        public hvec2 yx => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec4.gr swizzling (equivalent to hvec4.yx).
        /// </summary>
        public hvec2 gr => new hvec2(y, x);
        
        /// <summary>
        /// Returns hvec4.yxx swizzling.
        /// </summary>
        public hvec3 yxx => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec4.grr swizzling (equivalent to hvec4.yxx).
        /// </summary>
        public hvec3 grr => new hvec3(y, x, x);
        
        /// <summary>
        /// Returns hvec4.yxxx swizzling.
        /// </summary>
        public hvec4 yxxx => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.grrr swizzling (equivalent to hvec4.yxxx).
        /// </summary>
        public hvec4 grrr => new hvec4(y, x, x, x);
        
        /// <summary>
        /// Returns hvec4.yxxy swizzling.
        /// </summary>
        public hvec4 yxxy => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.grrg swizzling (equivalent to hvec4.yxxy).
        /// </summary>
        public hvec4 grrg => new hvec4(y, x, x, y);
        
        /// <summary>
        /// Returns hvec4.yxxz swizzling.
        /// </summary>
        public hvec4 yxxz => new hvec4(y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.grrb swizzling (equivalent to hvec4.yxxz).
        /// </summary>
        public hvec4 grrb => new hvec4(y, x, x, z);
        
        /// <summary>
        /// Returns hvec4.yxxw swizzling.
        /// </summary>
        public hvec4 yxxw => new hvec4(y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.grra swizzling (equivalent to hvec4.yxxw).
        /// </summary>
        public hvec4 grra => new hvec4(y, x, x, w);
        
        /// <summary>
        /// Returns hvec4.yxy swizzling.
        /// </summary>
        public hvec3 yxy => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec4.grg swizzling (equivalent to hvec4.yxy).
        /// </summary>
        public hvec3 grg => new hvec3(y, x, y);
        
        /// <summary>
        /// Returns hvec4.yxyx swizzling.
        /// </summary>
        public hvec4 yxyx => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.grgr swizzling (equivalent to hvec4.yxyx).
        /// </summary>
        public hvec4 grgr => new hvec4(y, x, y, x);
        
        /// <summary>
        /// Returns hvec4.yxyy swizzling.
        /// </summary>
        public hvec4 yxyy => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.grgg swizzling (equivalent to hvec4.yxyy).
        /// </summary>
        public hvec4 grgg => new hvec4(y, x, y, y);
        
        /// <summary>
        /// Returns hvec4.yxyz swizzling.
        /// </summary>
        public hvec4 yxyz => new hvec4(y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.grgb swizzling (equivalent to hvec4.yxyz).
        /// </summary>
        public hvec4 grgb => new hvec4(y, x, y, z);
        
        /// <summary>
        /// Returns hvec4.yxyw swizzling.
        /// </summary>
        public hvec4 yxyw => new hvec4(y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.grga swizzling (equivalent to hvec4.yxyw).
        /// </summary>
        public hvec4 grga => new hvec4(y, x, y, w);
        
        /// <summary>
        /// Returns hvec4.yxz swizzling.
        /// </summary>
        public hvec3 yxz => new hvec3(y, x, z);
        
        /// <summary>
        /// Returns hvec4.grb swizzling (equivalent to hvec4.yxz).
        /// </summary>
        public hvec3 grb => new hvec3(y, x, z);
        
        /// <summary>
        /// Returns hvec4.yxzx swizzling.
        /// </summary>
        public hvec4 yxzx => new hvec4(y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.grbr swizzling (equivalent to hvec4.yxzx).
        /// </summary>
        public hvec4 grbr => new hvec4(y, x, z, x);
        
        /// <summary>
        /// Returns hvec4.yxzy swizzling.
        /// </summary>
        public hvec4 yxzy => new hvec4(y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.grbg swizzling (equivalent to hvec4.yxzy).
        /// </summary>
        public hvec4 grbg => new hvec4(y, x, z, y);
        
        /// <summary>
        /// Returns hvec4.yxzz swizzling.
        /// </summary>
        public hvec4 yxzz => new hvec4(y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.grbb swizzling (equivalent to hvec4.yxzz).
        /// </summary>
        public hvec4 grbb => new hvec4(y, x, z, z);
        
        /// <summary>
        /// Returns hvec4.yxzw swizzling.
        /// </summary>
        public hvec4 yxzw => new hvec4(y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.grba swizzling (equivalent to hvec4.yxzw).
        /// </summary>
        public hvec4 grba => new hvec4(y, x, z, w);
        
        /// <summary>
        /// Returns hvec4.yxw swizzling.
        /// </summary>
        public hvec3 yxw => new hvec3(y, x, w);
        
        /// <summary>
        /// Returns hvec4.gra swizzling (equivalent to hvec4.yxw).
        /// </summary>
        public hvec3 gra => new hvec3(y, x, w);
        
        /// <summary>
        /// Returns hvec4.yxwx swizzling.
        /// </summary>
        public hvec4 yxwx => new hvec4(y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.grar swizzling (equivalent to hvec4.yxwx).
        /// </summary>
        public hvec4 grar => new hvec4(y, x, w, x);
        
        /// <summary>
        /// Returns hvec4.yxwy swizzling.
        /// </summary>
        public hvec4 yxwy => new hvec4(y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.grag swizzling (equivalent to hvec4.yxwy).
        /// </summary>
        public hvec4 grag => new hvec4(y, x, w, y);
        
        /// <summary>
        /// Returns hvec4.yxwz swizzling.
        /// </summary>
        public hvec4 yxwz => new hvec4(y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.grab swizzling (equivalent to hvec4.yxwz).
        /// </summary>
        public hvec4 grab => new hvec4(y, x, w, z);
        
        /// <summary>
        /// Returns hvec4.yxww swizzling.
        /// </summary>
        public hvec4 yxww => new hvec4(y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.graa swizzling (equivalent to hvec4.yxww).
        /// </summary>
        public hvec4 graa => new hvec4(y, x, w, w);
        
        /// <summary>
        /// Returns hvec4.yy swizzling.
        /// </summary>
        public hvec2 yy => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec4.gg swizzling (equivalent to hvec4.yy).
        /// </summary>
        public hvec2 gg => new hvec2(y, y);
        
        /// <summary>
        /// Returns hvec4.yyx swizzling.
        /// </summary>
        public hvec3 yyx => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec4.ggr swizzling (equivalent to hvec4.yyx).
        /// </summary>
        public hvec3 ggr => new hvec3(y, y, x);
        
        /// <summary>
        /// Returns hvec4.yyxx swizzling.
        /// </summary>
        public hvec4 yyxx => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.ggrr swizzling (equivalent to hvec4.yyxx).
        /// </summary>
        public hvec4 ggrr => new hvec4(y, y, x, x);
        
        /// <summary>
        /// Returns hvec4.yyxy swizzling.
        /// </summary>
        public hvec4 yyxy => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.ggrg swizzling (equivalent to hvec4.yyxy).
        /// </summary>
        public hvec4 ggrg => new hvec4(y, y, x, y);
        
        /// <summary>
        /// Returns hvec4.yyxz swizzling.
        /// </summary>
        public hvec4 yyxz => new hvec4(y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.ggrb swizzling (equivalent to hvec4.yyxz).
        /// </summary>
        public hvec4 ggrb => new hvec4(y, y, x, z);
        
        /// <summary>
        /// Returns hvec4.yyxw swizzling.
        /// </summary>
        public hvec4 yyxw => new hvec4(y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.ggra swizzling (equivalent to hvec4.yyxw).
        /// </summary>
        public hvec4 ggra => new hvec4(y, y, x, w);
        
        /// <summary>
        /// Returns hvec4.yyy swizzling.
        /// </summary>
        public hvec3 yyy => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec4.ggg swizzling (equivalent to hvec4.yyy).
        /// </summary>
        public hvec3 ggg => new hvec3(y, y, y);
        
        /// <summary>
        /// Returns hvec4.yyyx swizzling.
        /// </summary>
        public hvec4 yyyx => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.gggr swizzling (equivalent to hvec4.yyyx).
        /// </summary>
        public hvec4 gggr => new hvec4(y, y, y, x);
        
        /// <summary>
        /// Returns hvec4.yyyy swizzling.
        /// </summary>
        public hvec4 yyyy => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.gggg swizzling (equivalent to hvec4.yyyy).
        /// </summary>
        public hvec4 gggg => new hvec4(y, y, y, y);
        
        /// <summary>
        /// Returns hvec4.yyyz swizzling.
        /// </summary>
        public hvec4 yyyz => new hvec4(y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.gggb swizzling (equivalent to hvec4.yyyz).
        /// </summary>
        public hvec4 gggb => new hvec4(y, y, y, z);
        
        /// <summary>
        /// Returns hvec4.yyyw swizzling.
        /// </summary>
        public hvec4 yyyw => new hvec4(y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.ggga swizzling (equivalent to hvec4.yyyw).
        /// </summary>
        public hvec4 ggga => new hvec4(y, y, y, w);
        
        /// <summary>
        /// Returns hvec4.yyz swizzling.
        /// </summary>
        public hvec3 yyz => new hvec3(y, y, z);
        
        /// <summary>
        /// Returns hvec4.ggb swizzling (equivalent to hvec4.yyz).
        /// </summary>
        public hvec3 ggb => new hvec3(y, y, z);
        
        /// <summary>
        /// Returns hvec4.yyzx swizzling.
        /// </summary>
        public hvec4 yyzx => new hvec4(y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.ggbr swizzling (equivalent to hvec4.yyzx).
        /// </summary>
        public hvec4 ggbr => new hvec4(y, y, z, x);
        
        /// <summary>
        /// Returns hvec4.yyzy swizzling.
        /// </summary>
        public hvec4 yyzy => new hvec4(y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.ggbg swizzling (equivalent to hvec4.yyzy).
        /// </summary>
        public hvec4 ggbg => new hvec4(y, y, z, y);
        
        /// <summary>
        /// Returns hvec4.yyzz swizzling.
        /// </summary>
        public hvec4 yyzz => new hvec4(y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.ggbb swizzling (equivalent to hvec4.yyzz).
        /// </summary>
        public hvec4 ggbb => new hvec4(y, y, z, z);
        
        /// <summary>
        /// Returns hvec4.yyzw swizzling.
        /// </summary>
        public hvec4 yyzw => new hvec4(y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.ggba swizzling (equivalent to hvec4.yyzw).
        /// </summary>
        public hvec4 ggba => new hvec4(y, y, z, w);
        
        /// <summary>
        /// Returns hvec4.yyw swizzling.
        /// </summary>
        public hvec3 yyw => new hvec3(y, y, w);
        
        /// <summary>
        /// Returns hvec4.gga swizzling (equivalent to hvec4.yyw).
        /// </summary>
        public hvec3 gga => new hvec3(y, y, w);
        
        /// <summary>
        /// Returns hvec4.yywx swizzling.
        /// </summary>
        public hvec4 yywx => new hvec4(y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.ggar swizzling (equivalent to hvec4.yywx).
        /// </summary>
        public hvec4 ggar => new hvec4(y, y, w, x);
        
        /// <summary>
        /// Returns hvec4.yywy swizzling.
        /// </summary>
        public hvec4 yywy => new hvec4(y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.ggag swizzling (equivalent to hvec4.yywy).
        /// </summary>
        public hvec4 ggag => new hvec4(y, y, w, y);
        
        /// <summary>
        /// Returns hvec4.yywz swizzling.
        /// </summary>
        public hvec4 yywz => new hvec4(y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.ggab swizzling (equivalent to hvec4.yywz).
        /// </summary>
        public hvec4 ggab => new hvec4(y, y, w, z);
        
        /// <summary>
        /// Returns hvec4.yyww swizzling.
        /// </summary>
        public hvec4 yyww => new hvec4(y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.ggaa swizzling (equivalent to hvec4.yyww).
        /// </summary>
        public hvec4 ggaa => new hvec4(y, y, w, w);
        
        /// <summary>
        /// Returns hvec4.yz swizzling.
        /// </summary>
        public hvec2 yz => new hvec2(y, z);
        
        /// <summary>
        /// Returns hvec4.gb swizzling (equivalent to hvec4.yz).
        /// </summary>
        public hvec2 gb => new hvec2(y, z);
        
        /// <summary>
        /// Returns hvec4.yzx swizzling.
        /// </summary>
        public hvec3 yzx => new hvec3(y, z, x);
        
        /// <summary>
        /// Returns hvec4.gbr swizzling (equivalent to hvec4.yzx).
        /// </summary>
        public hvec3 gbr => new hvec3(y, z, x);
        
        /// <summary>
        /// Returns hvec4.yzxx swizzling.
        /// </summary>
        public hvec4 yzxx => new hvec4(y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.gbrr swizzling (equivalent to hvec4.yzxx).
        /// </summary>
        public hvec4 gbrr => new hvec4(y, z, x, x);
        
        /// <summary>
        /// Returns hvec4.yzxy swizzling.
        /// </summary>
        public hvec4 yzxy => new hvec4(y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.gbrg swizzling (equivalent to hvec4.yzxy).
        /// </summary>
        public hvec4 gbrg => new hvec4(y, z, x, y);
        
        /// <summary>
        /// Returns hvec4.yzxz swizzling.
        /// </summary>
        public hvec4 yzxz => new hvec4(y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.gbrb swizzling (equivalent to hvec4.yzxz).
        /// </summary>
        public hvec4 gbrb => new hvec4(y, z, x, z);
        
        /// <summary>
        /// Returns hvec4.yzxw swizzling.
        /// </summary>
        public hvec4 yzxw => new hvec4(y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.gbra swizzling (equivalent to hvec4.yzxw).
        /// </summary>
        public hvec4 gbra => new hvec4(y, z, x, w);
        
        /// <summary>
        /// Returns hvec4.yzy swizzling.
        /// </summary>
        public hvec3 yzy => new hvec3(y, z, y);
        
        /// <summary>
        /// Returns hvec4.gbg swizzling (equivalent to hvec4.yzy).
        /// </summary>
        public hvec3 gbg => new hvec3(y, z, y);
        
        /// <summary>
        /// Returns hvec4.yzyx swizzling.
        /// </summary>
        public hvec4 yzyx => new hvec4(y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.gbgr swizzling (equivalent to hvec4.yzyx).
        /// </summary>
        public hvec4 gbgr => new hvec4(y, z, y, x);
        
        /// <summary>
        /// Returns hvec4.yzyy swizzling.
        /// </summary>
        public hvec4 yzyy => new hvec4(y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.gbgg swizzling (equivalent to hvec4.yzyy).
        /// </summary>
        public hvec4 gbgg => new hvec4(y, z, y, y);
        
        /// <summary>
        /// Returns hvec4.yzyz swizzling.
        /// </summary>
        public hvec4 yzyz => new hvec4(y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.gbgb swizzling (equivalent to hvec4.yzyz).
        /// </summary>
        public hvec4 gbgb => new hvec4(y, z, y, z);
        
        /// <summary>
        /// Returns hvec4.yzyw swizzling.
        /// </summary>
        public hvec4 yzyw => new hvec4(y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.gbga swizzling (equivalent to hvec4.yzyw).
        /// </summary>
        public hvec4 gbga => new hvec4(y, z, y, w);
        
        /// <summary>
        /// Returns hvec4.yzz swizzling.
        /// </summary>
        public hvec3 yzz => new hvec3(y, z, z);
        
        /// <summary>
        /// Returns hvec4.gbb swizzling (equivalent to hvec4.yzz).
        /// </summary>
        public hvec3 gbb => new hvec3(y, z, z);
        
        /// <summary>
        /// Returns hvec4.yzzx swizzling.
        /// </summary>
        public hvec4 yzzx => new hvec4(y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.gbbr swizzling (equivalent to hvec4.yzzx).
        /// </summary>
        public hvec4 gbbr => new hvec4(y, z, z, x);
        
        /// <summary>
        /// Returns hvec4.yzzy swizzling.
        /// </summary>
        public hvec4 yzzy => new hvec4(y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.gbbg swizzling (equivalent to hvec4.yzzy).
        /// </summary>
        public hvec4 gbbg => new hvec4(y, z, z, y);
        
        /// <summary>
        /// Returns hvec4.yzzz swizzling.
        /// </summary>
        public hvec4 yzzz => new hvec4(y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.gbbb swizzling (equivalent to hvec4.yzzz).
        /// </summary>
        public hvec4 gbbb => new hvec4(y, z, z, z);
        
        /// <summary>
        /// Returns hvec4.yzzw swizzling.
        /// </summary>
        public hvec4 yzzw => new hvec4(y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.gbba swizzling (equivalent to hvec4.yzzw).
        /// </summary>
        public hvec4 gbba => new hvec4(y, z, z, w);
        
        /// <summary>
        /// Returns hvec4.yzw swizzling.
        /// </summary>
        public hvec3 yzw => new hvec3(y, z, w);
        
        /// <summary>
        /// Returns hvec4.gba swizzling (equivalent to hvec4.yzw).
        /// </summary>
        public hvec3 gba => new hvec3(y, z, w);
        
        /// <summary>
        /// Returns hvec4.yzwx swizzling.
        /// </summary>
        public hvec4 yzwx => new hvec4(y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.gbar swizzling (equivalent to hvec4.yzwx).
        /// </summary>
        public hvec4 gbar => new hvec4(y, z, w, x);
        
        /// <summary>
        /// Returns hvec4.yzwy swizzling.
        /// </summary>
        public hvec4 yzwy => new hvec4(y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.gbag swizzling (equivalent to hvec4.yzwy).
        /// </summary>
        public hvec4 gbag => new hvec4(y, z, w, y);
        
        /// <summary>
        /// Returns hvec4.yzwz swizzling.
        /// </summary>
        public hvec4 yzwz => new hvec4(y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.gbab swizzling (equivalent to hvec4.yzwz).
        /// </summary>
        public hvec4 gbab => new hvec4(y, z, w, z);
        
        /// <summary>
        /// Returns hvec4.yzww swizzling.
        /// </summary>
        public hvec4 yzww => new hvec4(y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.gbaa swizzling (equivalent to hvec4.yzww).
        /// </summary>
        public hvec4 gbaa => new hvec4(y, z, w, w);
        
        /// <summary>
        /// Returns hvec4.yw swizzling.
        /// </summary>
        public hvec2 yw => new hvec2(y, w);
        
        /// <summary>
        /// Returns hvec4.ga swizzling (equivalent to hvec4.yw).
        /// </summary>
        public hvec2 ga => new hvec2(y, w);
        
        /// <summary>
        /// Returns hvec4.ywx swizzling.
        /// </summary>
        public hvec3 ywx => new hvec3(y, w, x);
        
        /// <summary>
        /// Returns hvec4.gar swizzling (equivalent to hvec4.ywx).
        /// </summary>
        public hvec3 gar => new hvec3(y, w, x);
        
        /// <summary>
        /// Returns hvec4.ywxx swizzling.
        /// </summary>
        public hvec4 ywxx => new hvec4(y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.garr swizzling (equivalent to hvec4.ywxx).
        /// </summary>
        public hvec4 garr => new hvec4(y, w, x, x);
        
        /// <summary>
        /// Returns hvec4.ywxy swizzling.
        /// </summary>
        public hvec4 ywxy => new hvec4(y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.garg swizzling (equivalent to hvec4.ywxy).
        /// </summary>
        public hvec4 garg => new hvec4(y, w, x, y);
        
        /// <summary>
        /// Returns hvec4.ywxz swizzling.
        /// </summary>
        public hvec4 ywxz => new hvec4(y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.garb swizzling (equivalent to hvec4.ywxz).
        /// </summary>
        public hvec4 garb => new hvec4(y, w, x, z);
        
        /// <summary>
        /// Returns hvec4.ywxw swizzling.
        /// </summary>
        public hvec4 ywxw => new hvec4(y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.gara swizzling (equivalent to hvec4.ywxw).
        /// </summary>
        public hvec4 gara => new hvec4(y, w, x, w);
        
        /// <summary>
        /// Returns hvec4.ywy swizzling.
        /// </summary>
        public hvec3 ywy => new hvec3(y, w, y);
        
        /// <summary>
        /// Returns hvec4.gag swizzling (equivalent to hvec4.ywy).
        /// </summary>
        public hvec3 gag => new hvec3(y, w, y);
        
        /// <summary>
        /// Returns hvec4.ywyx swizzling.
        /// </summary>
        public hvec4 ywyx => new hvec4(y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.gagr swizzling (equivalent to hvec4.ywyx).
        /// </summary>
        public hvec4 gagr => new hvec4(y, w, y, x);
        
        /// <summary>
        /// Returns hvec4.ywyy swizzling.
        /// </summary>
        public hvec4 ywyy => new hvec4(y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.gagg swizzling (equivalent to hvec4.ywyy).
        /// </summary>
        public hvec4 gagg => new hvec4(y, w, y, y);
        
        /// <summary>
        /// Returns hvec4.ywyz swizzling.
        /// </summary>
        public hvec4 ywyz => new hvec4(y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.gagb swizzling (equivalent to hvec4.ywyz).
        /// </summary>
        public hvec4 gagb => new hvec4(y, w, y, z);
        
        /// <summary>
        /// Returns hvec4.ywyw swizzling.
        /// </summary>
        public hvec4 ywyw => new hvec4(y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.gaga swizzling (equivalent to hvec4.ywyw).
        /// </summary>
        public hvec4 gaga => new hvec4(y, w, y, w);
        
        /// <summary>
        /// Returns hvec4.ywz swizzling.
        /// </summary>
        public hvec3 ywz => new hvec3(y, w, z);
        
        /// <summary>
        /// Returns hvec4.gab swizzling (equivalent to hvec4.ywz).
        /// </summary>
        public hvec3 gab => new hvec3(y, w, z);
        
        /// <summary>
        /// Returns hvec4.ywzx swizzling.
        /// </summary>
        public hvec4 ywzx => new hvec4(y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.gabr swizzling (equivalent to hvec4.ywzx).
        /// </summary>
        public hvec4 gabr => new hvec4(y, w, z, x);
        
        /// <summary>
        /// Returns hvec4.ywzy swizzling.
        /// </summary>
        public hvec4 ywzy => new hvec4(y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.gabg swizzling (equivalent to hvec4.ywzy).
        /// </summary>
        public hvec4 gabg => new hvec4(y, w, z, y);
        
        /// <summary>
        /// Returns hvec4.ywzz swizzling.
        /// </summary>
        public hvec4 ywzz => new hvec4(y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.gabb swizzling (equivalent to hvec4.ywzz).
        /// </summary>
        public hvec4 gabb => new hvec4(y, w, z, z);
        
        /// <summary>
        /// Returns hvec4.ywzw swizzling.
        /// </summary>
        public hvec4 ywzw => new hvec4(y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.gaba swizzling (equivalent to hvec4.ywzw).
        /// </summary>
        public hvec4 gaba => new hvec4(y, w, z, w);
        
        /// <summary>
        /// Returns hvec4.yww swizzling.
        /// </summary>
        public hvec3 yww => new hvec3(y, w, w);
        
        /// <summary>
        /// Returns hvec4.gaa swizzling (equivalent to hvec4.yww).
        /// </summary>
        public hvec3 gaa => new hvec3(y, w, w);
        
        /// <summary>
        /// Returns hvec4.ywwx swizzling.
        /// </summary>
        public hvec4 ywwx => new hvec4(y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.gaar swizzling (equivalent to hvec4.ywwx).
        /// </summary>
        public hvec4 gaar => new hvec4(y, w, w, x);
        
        /// <summary>
        /// Returns hvec4.ywwy swizzling.
        /// </summary>
        public hvec4 ywwy => new hvec4(y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.gaag swizzling (equivalent to hvec4.ywwy).
        /// </summary>
        public hvec4 gaag => new hvec4(y, w, w, y);
        
        /// <summary>
        /// Returns hvec4.ywwz swizzling.
        /// </summary>
        public hvec4 ywwz => new hvec4(y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.gaab swizzling (equivalent to hvec4.ywwz).
        /// </summary>
        public hvec4 gaab => new hvec4(y, w, w, z);
        
        /// <summary>
        /// Returns hvec4.ywww swizzling.
        /// </summary>
        public hvec4 ywww => new hvec4(y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.gaaa swizzling (equivalent to hvec4.ywww).
        /// </summary>
        public hvec4 gaaa => new hvec4(y, w, w, w);
        
        /// <summary>
        /// Returns hvec4.zx swizzling.
        /// </summary>
        public hvec2 zx => new hvec2(z, x);
        
        /// <summary>
        /// Returns hvec4.br swizzling (equivalent to hvec4.zx).
        /// </summary>
        public hvec2 br => new hvec2(z, x);
        
        /// <summary>
        /// Returns hvec4.zxx swizzling.
        /// </summary>
        public hvec3 zxx => new hvec3(z, x, x);
        
        /// <summary>
        /// Returns hvec4.brr swizzling (equivalent to hvec4.zxx).
        /// </summary>
        public hvec3 brr => new hvec3(z, x, x);
        
        /// <summary>
        /// Returns hvec4.zxxx swizzling.
        /// </summary>
        public hvec4 zxxx => new hvec4(z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.brrr swizzling (equivalent to hvec4.zxxx).
        /// </summary>
        public hvec4 brrr => new hvec4(z, x, x, x);
        
        /// <summary>
        /// Returns hvec4.zxxy swizzling.
        /// </summary>
        public hvec4 zxxy => new hvec4(z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.brrg swizzling (equivalent to hvec4.zxxy).
        /// </summary>
        public hvec4 brrg => new hvec4(z, x, x, y);
        
        /// <summary>
        /// Returns hvec4.zxxz swizzling.
        /// </summary>
        public hvec4 zxxz => new hvec4(z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.brrb swizzling (equivalent to hvec4.zxxz).
        /// </summary>
        public hvec4 brrb => new hvec4(z, x, x, z);
        
        /// <summary>
        /// Returns hvec4.zxxw swizzling.
        /// </summary>
        public hvec4 zxxw => new hvec4(z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.brra swizzling (equivalent to hvec4.zxxw).
        /// </summary>
        public hvec4 brra => new hvec4(z, x, x, w);
        
        /// <summary>
        /// Returns hvec4.zxy swizzling.
        /// </summary>
        public hvec3 zxy => new hvec3(z, x, y);
        
        /// <summary>
        /// Returns hvec4.brg swizzling (equivalent to hvec4.zxy).
        /// </summary>
        public hvec3 brg => new hvec3(z, x, y);
        
        /// <summary>
        /// Returns hvec4.zxyx swizzling.
        /// </summary>
        public hvec4 zxyx => new hvec4(z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.brgr swizzling (equivalent to hvec4.zxyx).
        /// </summary>
        public hvec4 brgr => new hvec4(z, x, y, x);
        
        /// <summary>
        /// Returns hvec4.zxyy swizzling.
        /// </summary>
        public hvec4 zxyy => new hvec4(z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.brgg swizzling (equivalent to hvec4.zxyy).
        /// </summary>
        public hvec4 brgg => new hvec4(z, x, y, y);
        
        /// <summary>
        /// Returns hvec4.zxyz swizzling.
        /// </summary>
        public hvec4 zxyz => new hvec4(z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.brgb swizzling (equivalent to hvec4.zxyz).
        /// </summary>
        public hvec4 brgb => new hvec4(z, x, y, z);
        
        /// <summary>
        /// Returns hvec4.zxyw swizzling.
        /// </summary>
        public hvec4 zxyw => new hvec4(z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.brga swizzling (equivalent to hvec4.zxyw).
        /// </summary>
        public hvec4 brga => new hvec4(z, x, y, w);
        
        /// <summary>
        /// Returns hvec4.zxz swizzling.
        /// </summary>
        public hvec3 zxz => new hvec3(z, x, z);
        
        /// <summary>
        /// Returns hvec4.brb swizzling (equivalent to hvec4.zxz).
        /// </summary>
        public hvec3 brb => new hvec3(z, x, z);
        
        /// <summary>
        /// Returns hvec4.zxzx swizzling.
        /// </summary>
        public hvec4 zxzx => new hvec4(z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.brbr swizzling (equivalent to hvec4.zxzx).
        /// </summary>
        public hvec4 brbr => new hvec4(z, x, z, x);
        
        /// <summary>
        /// Returns hvec4.zxzy swizzling.
        /// </summary>
        public hvec4 zxzy => new hvec4(z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.brbg swizzling (equivalent to hvec4.zxzy).
        /// </summary>
        public hvec4 brbg => new hvec4(z, x, z, y);
        
        /// <summary>
        /// Returns hvec4.zxzz swizzling.
        /// </summary>
        public hvec4 zxzz => new hvec4(z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.brbb swizzling (equivalent to hvec4.zxzz).
        /// </summary>
        public hvec4 brbb => new hvec4(z, x, z, z);
        
        /// <summary>
        /// Returns hvec4.zxzw swizzling.
        /// </summary>
        public hvec4 zxzw => new hvec4(z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.brba swizzling (equivalent to hvec4.zxzw).
        /// </summary>
        public hvec4 brba => new hvec4(z, x, z, w);
        
        /// <summary>
        /// Returns hvec4.zxw swizzling.
        /// </summary>
        public hvec3 zxw => new hvec3(z, x, w);
        
        /// <summary>
        /// Returns hvec4.bra swizzling (equivalent to hvec4.zxw).
        /// </summary>
        public hvec3 bra => new hvec3(z, x, w);
        
        /// <summary>
        /// Returns hvec4.zxwx swizzling.
        /// </summary>
        public hvec4 zxwx => new hvec4(z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.brar swizzling (equivalent to hvec4.zxwx).
        /// </summary>
        public hvec4 brar => new hvec4(z, x, w, x);
        
        /// <summary>
        /// Returns hvec4.zxwy swizzling.
        /// </summary>
        public hvec4 zxwy => new hvec4(z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.brag swizzling (equivalent to hvec4.zxwy).
        /// </summary>
        public hvec4 brag => new hvec4(z, x, w, y);
        
        /// <summary>
        /// Returns hvec4.zxwz swizzling.
        /// </summary>
        public hvec4 zxwz => new hvec4(z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.brab swizzling (equivalent to hvec4.zxwz).
        /// </summary>
        public hvec4 brab => new hvec4(z, x, w, z);
        
        /// <summary>
        /// Returns hvec4.zxww swizzling.
        /// </summary>
        public hvec4 zxww => new hvec4(z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.braa swizzling (equivalent to hvec4.zxww).
        /// </summary>
        public hvec4 braa => new hvec4(z, x, w, w);
        
        /// <summary>
        /// Returns hvec4.zy swizzling.
        /// </summary>
        public hvec2 zy => new hvec2(z, y);
        
        /// <summary>
        /// Returns hvec4.bg swizzling (equivalent to hvec4.zy).
        /// </summary>
        public hvec2 bg => new hvec2(z, y);
        
        /// <summary>
        /// Returns hvec4.zyx swizzling.
        /// </summary>
        public hvec3 zyx => new hvec3(z, y, x);
        
        /// <summary>
        /// Returns hvec4.bgr swizzling (equivalent to hvec4.zyx).
        /// </summary>
        public hvec3 bgr => new hvec3(z, y, x);
        
        /// <summary>
        /// Returns hvec4.zyxx swizzling.
        /// </summary>
        public hvec4 zyxx => new hvec4(z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.bgrr swizzling (equivalent to hvec4.zyxx).
        /// </summary>
        public hvec4 bgrr => new hvec4(z, y, x, x);
        
        /// <summary>
        /// Returns hvec4.zyxy swizzling.
        /// </summary>
        public hvec4 zyxy => new hvec4(z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.bgrg swizzling (equivalent to hvec4.zyxy).
        /// </summary>
        public hvec4 bgrg => new hvec4(z, y, x, y);
        
        /// <summary>
        /// Returns hvec4.zyxz swizzling.
        /// </summary>
        public hvec4 zyxz => new hvec4(z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.bgrb swizzling (equivalent to hvec4.zyxz).
        /// </summary>
        public hvec4 bgrb => new hvec4(z, y, x, z);
        
        /// <summary>
        /// Returns hvec4.zyxw swizzling.
        /// </summary>
        public hvec4 zyxw => new hvec4(z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.bgra swizzling (equivalent to hvec4.zyxw).
        /// </summary>
        public hvec4 bgra => new hvec4(z, y, x, w);
        
        /// <summary>
        /// Returns hvec4.zyy swizzling.
        /// </summary>
        public hvec3 zyy => new hvec3(z, y, y);
        
        /// <summary>
        /// Returns hvec4.bgg swizzling (equivalent to hvec4.zyy).
        /// </summary>
        public hvec3 bgg => new hvec3(z, y, y);
        
        /// <summary>
        /// Returns hvec4.zyyx swizzling.
        /// </summary>
        public hvec4 zyyx => new hvec4(z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.bggr swizzling (equivalent to hvec4.zyyx).
        /// </summary>
        public hvec4 bggr => new hvec4(z, y, y, x);
        
        /// <summary>
        /// Returns hvec4.zyyy swizzling.
        /// </summary>
        public hvec4 zyyy => new hvec4(z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.bggg swizzling (equivalent to hvec4.zyyy).
        /// </summary>
        public hvec4 bggg => new hvec4(z, y, y, y);
        
        /// <summary>
        /// Returns hvec4.zyyz swizzling.
        /// </summary>
        public hvec4 zyyz => new hvec4(z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.bggb swizzling (equivalent to hvec4.zyyz).
        /// </summary>
        public hvec4 bggb => new hvec4(z, y, y, z);
        
        /// <summary>
        /// Returns hvec4.zyyw swizzling.
        /// </summary>
        public hvec4 zyyw => new hvec4(z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.bgga swizzling (equivalent to hvec4.zyyw).
        /// </summary>
        public hvec4 bgga => new hvec4(z, y, y, w);
        
        /// <summary>
        /// Returns hvec4.zyz swizzling.
        /// </summary>
        public hvec3 zyz => new hvec3(z, y, z);
        
        /// <summary>
        /// Returns hvec4.bgb swizzling (equivalent to hvec4.zyz).
        /// </summary>
        public hvec3 bgb => new hvec3(z, y, z);
        
        /// <summary>
        /// Returns hvec4.zyzx swizzling.
        /// </summary>
        public hvec4 zyzx => new hvec4(z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.bgbr swizzling (equivalent to hvec4.zyzx).
        /// </summary>
        public hvec4 bgbr => new hvec4(z, y, z, x);
        
        /// <summary>
        /// Returns hvec4.zyzy swizzling.
        /// </summary>
        public hvec4 zyzy => new hvec4(z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.bgbg swizzling (equivalent to hvec4.zyzy).
        /// </summary>
        public hvec4 bgbg => new hvec4(z, y, z, y);
        
        /// <summary>
        /// Returns hvec4.zyzz swizzling.
        /// </summary>
        public hvec4 zyzz => new hvec4(z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.bgbb swizzling (equivalent to hvec4.zyzz).
        /// </summary>
        public hvec4 bgbb => new hvec4(z, y, z, z);
        
        /// <summary>
        /// Returns hvec4.zyzw swizzling.
        /// </summary>
        public hvec4 zyzw => new hvec4(z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.bgba swizzling (equivalent to hvec4.zyzw).
        /// </summary>
        public hvec4 bgba => new hvec4(z, y, z, w);
        
        /// <summary>
        /// Returns hvec4.zyw swizzling.
        /// </summary>
        public hvec3 zyw => new hvec3(z, y, w);
        
        /// <summary>
        /// Returns hvec4.bga swizzling (equivalent to hvec4.zyw).
        /// </summary>
        public hvec3 bga => new hvec3(z, y, w);
        
        /// <summary>
        /// Returns hvec4.zywx swizzling.
        /// </summary>
        public hvec4 zywx => new hvec4(z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.bgar swizzling (equivalent to hvec4.zywx).
        /// </summary>
        public hvec4 bgar => new hvec4(z, y, w, x);
        
        /// <summary>
        /// Returns hvec4.zywy swizzling.
        /// </summary>
        public hvec4 zywy => new hvec4(z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.bgag swizzling (equivalent to hvec4.zywy).
        /// </summary>
        public hvec4 bgag => new hvec4(z, y, w, y);
        
        /// <summary>
        /// Returns hvec4.zywz swizzling.
        /// </summary>
        public hvec4 zywz => new hvec4(z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.bgab swizzling (equivalent to hvec4.zywz).
        /// </summary>
        public hvec4 bgab => new hvec4(z, y, w, z);
        
        /// <summary>
        /// Returns hvec4.zyww swizzling.
        /// </summary>
        public hvec4 zyww => new hvec4(z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.bgaa swizzling (equivalent to hvec4.zyww).
        /// </summary>
        public hvec4 bgaa => new hvec4(z, y, w, w);
        
        /// <summary>
        /// Returns hvec4.zz swizzling.
        /// </summary>
        public hvec2 zz => new hvec2(z, z);
        
        /// <summary>
        /// Returns hvec4.bb swizzling (equivalent to hvec4.zz).
        /// </summary>
        public hvec2 bb => new hvec2(z, z);
        
        /// <summary>
        /// Returns hvec4.zzx swizzling.
        /// </summary>
        public hvec3 zzx => new hvec3(z, z, x);
        
        /// <summary>
        /// Returns hvec4.bbr swizzling (equivalent to hvec4.zzx).
        /// </summary>
        public hvec3 bbr => new hvec3(z, z, x);
        
        /// <summary>
        /// Returns hvec4.zzxx swizzling.
        /// </summary>
        public hvec4 zzxx => new hvec4(z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.bbrr swizzling (equivalent to hvec4.zzxx).
        /// </summary>
        public hvec4 bbrr => new hvec4(z, z, x, x);
        
        /// <summary>
        /// Returns hvec4.zzxy swizzling.
        /// </summary>
        public hvec4 zzxy => new hvec4(z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.bbrg swizzling (equivalent to hvec4.zzxy).
        /// </summary>
        public hvec4 bbrg => new hvec4(z, z, x, y);
        
        /// <summary>
        /// Returns hvec4.zzxz swizzling.
        /// </summary>
        public hvec4 zzxz => new hvec4(z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.bbrb swizzling (equivalent to hvec4.zzxz).
        /// </summary>
        public hvec4 bbrb => new hvec4(z, z, x, z);
        
        /// <summary>
        /// Returns hvec4.zzxw swizzling.
        /// </summary>
        public hvec4 zzxw => new hvec4(z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.bbra swizzling (equivalent to hvec4.zzxw).
        /// </summary>
        public hvec4 bbra => new hvec4(z, z, x, w);
        
        /// <summary>
        /// Returns hvec4.zzy swizzling.
        /// </summary>
        public hvec3 zzy => new hvec3(z, z, y);
        
        /// <summary>
        /// Returns hvec4.bbg swizzling (equivalent to hvec4.zzy).
        /// </summary>
        public hvec3 bbg => new hvec3(z, z, y);
        
        /// <summary>
        /// Returns hvec4.zzyx swizzling.
        /// </summary>
        public hvec4 zzyx => new hvec4(z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.bbgr swizzling (equivalent to hvec4.zzyx).
        /// </summary>
        public hvec4 bbgr => new hvec4(z, z, y, x);
        
        /// <summary>
        /// Returns hvec4.zzyy swizzling.
        /// </summary>
        public hvec4 zzyy => new hvec4(z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.bbgg swizzling (equivalent to hvec4.zzyy).
        /// </summary>
        public hvec4 bbgg => new hvec4(z, z, y, y);
        
        /// <summary>
        /// Returns hvec4.zzyz swizzling.
        /// </summary>
        public hvec4 zzyz => new hvec4(z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.bbgb swizzling (equivalent to hvec4.zzyz).
        /// </summary>
        public hvec4 bbgb => new hvec4(z, z, y, z);
        
        /// <summary>
        /// Returns hvec4.zzyw swizzling.
        /// </summary>
        public hvec4 zzyw => new hvec4(z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.bbga swizzling (equivalent to hvec4.zzyw).
        /// </summary>
        public hvec4 bbga => new hvec4(z, z, y, w);
        
        /// <summary>
        /// Returns hvec4.zzz swizzling.
        /// </summary>
        public hvec3 zzz => new hvec3(z, z, z);
        
        /// <summary>
        /// Returns hvec4.bbb swizzling (equivalent to hvec4.zzz).
        /// </summary>
        public hvec3 bbb => new hvec3(z, z, z);
        
        /// <summary>
        /// Returns hvec4.zzzx swizzling.
        /// </summary>
        public hvec4 zzzx => new hvec4(z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.bbbr swizzling (equivalent to hvec4.zzzx).
        /// </summary>
        public hvec4 bbbr => new hvec4(z, z, z, x);
        
        /// <summary>
        /// Returns hvec4.zzzy swizzling.
        /// </summary>
        public hvec4 zzzy => new hvec4(z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.bbbg swizzling (equivalent to hvec4.zzzy).
        /// </summary>
        public hvec4 bbbg => new hvec4(z, z, z, y);
        
        /// <summary>
        /// Returns hvec4.zzzz swizzling.
        /// </summary>
        public hvec4 zzzz => new hvec4(z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.bbbb swizzling (equivalent to hvec4.zzzz).
        /// </summary>
        public hvec4 bbbb => new hvec4(z, z, z, z);
        
        /// <summary>
        /// Returns hvec4.zzzw swizzling.
        /// </summary>
        public hvec4 zzzw => new hvec4(z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.bbba swizzling (equivalent to hvec4.zzzw).
        /// </summary>
        public hvec4 bbba => new hvec4(z, z, z, w);
        
        /// <summary>
        /// Returns hvec4.zzw swizzling.
        /// </summary>
        public hvec3 zzw => new hvec3(z, z, w);
        
        /// <summary>
        /// Returns hvec4.bba swizzling (equivalent to hvec4.zzw).
        /// </summary>
        public hvec3 bba => new hvec3(z, z, w);
        
        /// <summary>
        /// Returns hvec4.zzwx swizzling.
        /// </summary>
        public hvec4 zzwx => new hvec4(z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.bbar swizzling (equivalent to hvec4.zzwx).
        /// </summary>
        public hvec4 bbar => new hvec4(z, z, w, x);
        
        /// <summary>
        /// Returns hvec4.zzwy swizzling.
        /// </summary>
        public hvec4 zzwy => new hvec4(z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.bbag swizzling (equivalent to hvec4.zzwy).
        /// </summary>
        public hvec4 bbag => new hvec4(z, z, w, y);
        
        /// <summary>
        /// Returns hvec4.zzwz swizzling.
        /// </summary>
        public hvec4 zzwz => new hvec4(z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.bbab swizzling (equivalent to hvec4.zzwz).
        /// </summary>
        public hvec4 bbab => new hvec4(z, z, w, z);
        
        /// <summary>
        /// Returns hvec4.zzww swizzling.
        /// </summary>
        public hvec4 zzww => new hvec4(z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.bbaa swizzling (equivalent to hvec4.zzww).
        /// </summary>
        public hvec4 bbaa => new hvec4(z, z, w, w);
        
        /// <summary>
        /// Returns hvec4.zw swizzling.
        /// </summary>
        public hvec2 zw => new hvec2(z, w);
        
        /// <summary>
        /// Returns hvec4.ba swizzling (equivalent to hvec4.zw).
        /// </summary>
        public hvec2 ba => new hvec2(z, w);
        
        /// <summary>
        /// Returns hvec4.zwx swizzling.
        /// </summary>
        public hvec3 zwx => new hvec3(z, w, x);
        
        /// <summary>
        /// Returns hvec4.bar swizzling (equivalent to hvec4.zwx).
        /// </summary>
        public hvec3 bar => new hvec3(z, w, x);
        
        /// <summary>
        /// Returns hvec4.zwxx swizzling.
        /// </summary>
        public hvec4 zwxx => new hvec4(z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.barr swizzling (equivalent to hvec4.zwxx).
        /// </summary>
        public hvec4 barr => new hvec4(z, w, x, x);
        
        /// <summary>
        /// Returns hvec4.zwxy swizzling.
        /// </summary>
        public hvec4 zwxy => new hvec4(z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.barg swizzling (equivalent to hvec4.zwxy).
        /// </summary>
        public hvec4 barg => new hvec4(z, w, x, y);
        
        /// <summary>
        /// Returns hvec4.zwxz swizzling.
        /// </summary>
        public hvec4 zwxz => new hvec4(z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.barb swizzling (equivalent to hvec4.zwxz).
        /// </summary>
        public hvec4 barb => new hvec4(z, w, x, z);
        
        /// <summary>
        /// Returns hvec4.zwxw swizzling.
        /// </summary>
        public hvec4 zwxw => new hvec4(z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.bara swizzling (equivalent to hvec4.zwxw).
        /// </summary>
        public hvec4 bara => new hvec4(z, w, x, w);
        
        /// <summary>
        /// Returns hvec4.zwy swizzling.
        /// </summary>
        public hvec3 zwy => new hvec3(z, w, y);
        
        /// <summary>
        /// Returns hvec4.bag swizzling (equivalent to hvec4.zwy).
        /// </summary>
        public hvec3 bag => new hvec3(z, w, y);
        
        /// <summary>
        /// Returns hvec4.zwyx swizzling.
        /// </summary>
        public hvec4 zwyx => new hvec4(z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.bagr swizzling (equivalent to hvec4.zwyx).
        /// </summary>
        public hvec4 bagr => new hvec4(z, w, y, x);
        
        /// <summary>
        /// Returns hvec4.zwyy swizzling.
        /// </summary>
        public hvec4 zwyy => new hvec4(z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.bagg swizzling (equivalent to hvec4.zwyy).
        /// </summary>
        public hvec4 bagg => new hvec4(z, w, y, y);
        
        /// <summary>
        /// Returns hvec4.zwyz swizzling.
        /// </summary>
        public hvec4 zwyz => new hvec4(z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.bagb swizzling (equivalent to hvec4.zwyz).
        /// </summary>
        public hvec4 bagb => new hvec4(z, w, y, z);
        
        /// <summary>
        /// Returns hvec4.zwyw swizzling.
        /// </summary>
        public hvec4 zwyw => new hvec4(z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.baga swizzling (equivalent to hvec4.zwyw).
        /// </summary>
        public hvec4 baga => new hvec4(z, w, y, w);
        
        /// <summary>
        /// Returns hvec4.zwz swizzling.
        /// </summary>
        public hvec3 zwz => new hvec3(z, w, z);
        
        /// <summary>
        /// Returns hvec4.bab swizzling (equivalent to hvec4.zwz).
        /// </summary>
        public hvec3 bab => new hvec3(z, w, z);
        
        /// <summary>
        /// Returns hvec4.zwzx swizzling.
        /// </summary>
        public hvec4 zwzx => new hvec4(z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.babr swizzling (equivalent to hvec4.zwzx).
        /// </summary>
        public hvec4 babr => new hvec4(z, w, z, x);
        
        /// <summary>
        /// Returns hvec4.zwzy swizzling.
        /// </summary>
        public hvec4 zwzy => new hvec4(z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.babg swizzling (equivalent to hvec4.zwzy).
        /// </summary>
        public hvec4 babg => new hvec4(z, w, z, y);
        
        /// <summary>
        /// Returns hvec4.zwzz swizzling.
        /// </summary>
        public hvec4 zwzz => new hvec4(z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.babb swizzling (equivalent to hvec4.zwzz).
        /// </summary>
        public hvec4 babb => new hvec4(z, w, z, z);
        
        /// <summary>
        /// Returns hvec4.zwzw swizzling.
        /// </summary>
        public hvec4 zwzw => new hvec4(z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.baba swizzling (equivalent to hvec4.zwzw).
        /// </summary>
        public hvec4 baba => new hvec4(z, w, z, w);
        
        /// <summary>
        /// Returns hvec4.zww swizzling.
        /// </summary>
        public hvec3 zww => new hvec3(z, w, w);
        
        /// <summary>
        /// Returns hvec4.baa swizzling (equivalent to hvec4.zww).
        /// </summary>
        public hvec3 baa => new hvec3(z, w, w);
        
        /// <summary>
        /// Returns hvec4.zwwx swizzling.
        /// </summary>
        public hvec4 zwwx => new hvec4(z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.baar swizzling (equivalent to hvec4.zwwx).
        /// </summary>
        public hvec4 baar => new hvec4(z, w, w, x);
        
        /// <summary>
        /// Returns hvec4.zwwy swizzling.
        /// </summary>
        public hvec4 zwwy => new hvec4(z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.baag swizzling (equivalent to hvec4.zwwy).
        /// </summary>
        public hvec4 baag => new hvec4(z, w, w, y);
        
        /// <summary>
        /// Returns hvec4.zwwz swizzling.
        /// </summary>
        public hvec4 zwwz => new hvec4(z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.baab swizzling (equivalent to hvec4.zwwz).
        /// </summary>
        public hvec4 baab => new hvec4(z, w, w, z);
        
        /// <summary>
        /// Returns hvec4.zwww swizzling.
        /// </summary>
        public hvec4 zwww => new hvec4(z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.baaa swizzling (equivalent to hvec4.zwww).
        /// </summary>
        public hvec4 baaa => new hvec4(z, w, w, w);
        
        /// <summary>
        /// Returns hvec4.wx swizzling.
        /// </summary>
        public hvec2 wx => new hvec2(w, x);
        
        /// <summary>
        /// Returns hvec4.ar swizzling (equivalent to hvec4.wx).
        /// </summary>
        public hvec2 ar => new hvec2(w, x);
        
        /// <summary>
        /// Returns hvec4.wxx swizzling.
        /// </summary>
        public hvec3 wxx => new hvec3(w, x, x);
        
        /// <summary>
        /// Returns hvec4.arr swizzling (equivalent to hvec4.wxx).
        /// </summary>
        public hvec3 arr => new hvec3(w, x, x);
        
        /// <summary>
        /// Returns hvec4.wxxx swizzling.
        /// </summary>
        public hvec4 wxxx => new hvec4(w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.arrr swizzling (equivalent to hvec4.wxxx).
        /// </summary>
        public hvec4 arrr => new hvec4(w, x, x, x);
        
        /// <summary>
        /// Returns hvec4.wxxy swizzling.
        /// </summary>
        public hvec4 wxxy => new hvec4(w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.arrg swizzling (equivalent to hvec4.wxxy).
        /// </summary>
        public hvec4 arrg => new hvec4(w, x, x, y);
        
        /// <summary>
        /// Returns hvec4.wxxz swizzling.
        /// </summary>
        public hvec4 wxxz => new hvec4(w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.arrb swizzling (equivalent to hvec4.wxxz).
        /// </summary>
        public hvec4 arrb => new hvec4(w, x, x, z);
        
        /// <summary>
        /// Returns hvec4.wxxw swizzling.
        /// </summary>
        public hvec4 wxxw => new hvec4(w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.arra swizzling (equivalent to hvec4.wxxw).
        /// </summary>
        public hvec4 arra => new hvec4(w, x, x, w);
        
        /// <summary>
        /// Returns hvec4.wxy swizzling.
        /// </summary>
        public hvec3 wxy => new hvec3(w, x, y);
        
        /// <summary>
        /// Returns hvec4.arg swizzling (equivalent to hvec4.wxy).
        /// </summary>
        public hvec3 arg => new hvec3(w, x, y);
        
        /// <summary>
        /// Returns hvec4.wxyx swizzling.
        /// </summary>
        public hvec4 wxyx => new hvec4(w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.argr swizzling (equivalent to hvec4.wxyx).
        /// </summary>
        public hvec4 argr => new hvec4(w, x, y, x);
        
        /// <summary>
        /// Returns hvec4.wxyy swizzling.
        /// </summary>
        public hvec4 wxyy => new hvec4(w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.argg swizzling (equivalent to hvec4.wxyy).
        /// </summary>
        public hvec4 argg => new hvec4(w, x, y, y);
        
        /// <summary>
        /// Returns hvec4.wxyz swizzling.
        /// </summary>
        public hvec4 wxyz => new hvec4(w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.argb swizzling (equivalent to hvec4.wxyz).
        /// </summary>
        public hvec4 argb => new hvec4(w, x, y, z);
        
        /// <summary>
        /// Returns hvec4.wxyw swizzling.
        /// </summary>
        public hvec4 wxyw => new hvec4(w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.arga swizzling (equivalent to hvec4.wxyw).
        /// </summary>
        public hvec4 arga => new hvec4(w, x, y, w);
        
        /// <summary>
        /// Returns hvec4.wxz swizzling.
        /// </summary>
        public hvec3 wxz => new hvec3(w, x, z);
        
        /// <summary>
        /// Returns hvec4.arb swizzling (equivalent to hvec4.wxz).
        /// </summary>
        public hvec3 arb => new hvec3(w, x, z);
        
        /// <summary>
        /// Returns hvec4.wxzx swizzling.
        /// </summary>
        public hvec4 wxzx => new hvec4(w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.arbr swizzling (equivalent to hvec4.wxzx).
        /// </summary>
        public hvec4 arbr => new hvec4(w, x, z, x);
        
        /// <summary>
        /// Returns hvec4.wxzy swizzling.
        /// </summary>
        public hvec4 wxzy => new hvec4(w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.arbg swizzling (equivalent to hvec4.wxzy).
        /// </summary>
        public hvec4 arbg => new hvec4(w, x, z, y);
        
        /// <summary>
        /// Returns hvec4.wxzz swizzling.
        /// </summary>
        public hvec4 wxzz => new hvec4(w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.arbb swizzling (equivalent to hvec4.wxzz).
        /// </summary>
        public hvec4 arbb => new hvec4(w, x, z, z);
        
        /// <summary>
        /// Returns hvec4.wxzw swizzling.
        /// </summary>
        public hvec4 wxzw => new hvec4(w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.arba swizzling (equivalent to hvec4.wxzw).
        /// </summary>
        public hvec4 arba => new hvec4(w, x, z, w);
        
        /// <summary>
        /// Returns hvec4.wxw swizzling.
        /// </summary>
        public hvec3 wxw => new hvec3(w, x, w);
        
        /// <summary>
        /// Returns hvec4.ara swizzling (equivalent to hvec4.wxw).
        /// </summary>
        public hvec3 ara => new hvec3(w, x, w);
        
        /// <summary>
        /// Returns hvec4.wxwx swizzling.
        /// </summary>
        public hvec4 wxwx => new hvec4(w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.arar swizzling (equivalent to hvec4.wxwx).
        /// </summary>
        public hvec4 arar => new hvec4(w, x, w, x);
        
        /// <summary>
        /// Returns hvec4.wxwy swizzling.
        /// </summary>
        public hvec4 wxwy => new hvec4(w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.arag swizzling (equivalent to hvec4.wxwy).
        /// </summary>
        public hvec4 arag => new hvec4(w, x, w, y);
        
        /// <summary>
        /// Returns hvec4.wxwz swizzling.
        /// </summary>
        public hvec4 wxwz => new hvec4(w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.arab swizzling (equivalent to hvec4.wxwz).
        /// </summary>
        public hvec4 arab => new hvec4(w, x, w, z);
        
        /// <summary>
        /// Returns hvec4.wxww swizzling.
        /// </summary>
        public hvec4 wxww => new hvec4(w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.araa swizzling (equivalent to hvec4.wxww).
        /// </summary>
        public hvec4 araa => new hvec4(w, x, w, w);
        
        /// <summary>
        /// Returns hvec4.wy swizzling.
        /// </summary>
        public hvec2 wy => new hvec2(w, y);
        
        /// <summary>
        /// Returns hvec4.ag swizzling (equivalent to hvec4.wy).
        /// </summary>
        public hvec2 ag => new hvec2(w, y);
        
        /// <summary>
        /// Returns hvec4.wyx swizzling.
        /// </summary>
        public hvec3 wyx => new hvec3(w, y, x);
        
        /// <summary>
        /// Returns hvec4.agr swizzling (equivalent to hvec4.wyx).
        /// </summary>
        public hvec3 agr => new hvec3(w, y, x);
        
        /// <summary>
        /// Returns hvec4.wyxx swizzling.
        /// </summary>
        public hvec4 wyxx => new hvec4(w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.agrr swizzling (equivalent to hvec4.wyxx).
        /// </summary>
        public hvec4 agrr => new hvec4(w, y, x, x);
        
        /// <summary>
        /// Returns hvec4.wyxy swizzling.
        /// </summary>
        public hvec4 wyxy => new hvec4(w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.agrg swizzling (equivalent to hvec4.wyxy).
        /// </summary>
        public hvec4 agrg => new hvec4(w, y, x, y);
        
        /// <summary>
        /// Returns hvec4.wyxz swizzling.
        /// </summary>
        public hvec4 wyxz => new hvec4(w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.agrb swizzling (equivalent to hvec4.wyxz).
        /// </summary>
        public hvec4 agrb => new hvec4(w, y, x, z);
        
        /// <summary>
        /// Returns hvec4.wyxw swizzling.
        /// </summary>
        public hvec4 wyxw => new hvec4(w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.agra swizzling (equivalent to hvec4.wyxw).
        /// </summary>
        public hvec4 agra => new hvec4(w, y, x, w);
        
        /// <summary>
        /// Returns hvec4.wyy swizzling.
        /// </summary>
        public hvec3 wyy => new hvec3(w, y, y);
        
        /// <summary>
        /// Returns hvec4.agg swizzling (equivalent to hvec4.wyy).
        /// </summary>
        public hvec3 agg => new hvec3(w, y, y);
        
        /// <summary>
        /// Returns hvec4.wyyx swizzling.
        /// </summary>
        public hvec4 wyyx => new hvec4(w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.aggr swizzling (equivalent to hvec4.wyyx).
        /// </summary>
        public hvec4 aggr => new hvec4(w, y, y, x);
        
        /// <summary>
        /// Returns hvec4.wyyy swizzling.
        /// </summary>
        public hvec4 wyyy => new hvec4(w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.aggg swizzling (equivalent to hvec4.wyyy).
        /// </summary>
        public hvec4 aggg => new hvec4(w, y, y, y);
        
        /// <summary>
        /// Returns hvec4.wyyz swizzling.
        /// </summary>
        public hvec4 wyyz => new hvec4(w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.aggb swizzling (equivalent to hvec4.wyyz).
        /// </summary>
        public hvec4 aggb => new hvec4(w, y, y, z);
        
        /// <summary>
        /// Returns hvec4.wyyw swizzling.
        /// </summary>
        public hvec4 wyyw => new hvec4(w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.agga swizzling (equivalent to hvec4.wyyw).
        /// </summary>
        public hvec4 agga => new hvec4(w, y, y, w);
        
        /// <summary>
        /// Returns hvec4.wyz swizzling.
        /// </summary>
        public hvec3 wyz => new hvec3(w, y, z);
        
        /// <summary>
        /// Returns hvec4.agb swizzling (equivalent to hvec4.wyz).
        /// </summary>
        public hvec3 agb => new hvec3(w, y, z);
        
        /// <summary>
        /// Returns hvec4.wyzx swizzling.
        /// </summary>
        public hvec4 wyzx => new hvec4(w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.agbr swizzling (equivalent to hvec4.wyzx).
        /// </summary>
        public hvec4 agbr => new hvec4(w, y, z, x);
        
        /// <summary>
        /// Returns hvec4.wyzy swizzling.
        /// </summary>
        public hvec4 wyzy => new hvec4(w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.agbg swizzling (equivalent to hvec4.wyzy).
        /// </summary>
        public hvec4 agbg => new hvec4(w, y, z, y);
        
        /// <summary>
        /// Returns hvec4.wyzz swizzling.
        /// </summary>
        public hvec4 wyzz => new hvec4(w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.agbb swizzling (equivalent to hvec4.wyzz).
        /// </summary>
        public hvec4 agbb => new hvec4(w, y, z, z);
        
        /// <summary>
        /// Returns hvec4.wyzw swizzling.
        /// </summary>
        public hvec4 wyzw => new hvec4(w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.agba swizzling (equivalent to hvec4.wyzw).
        /// </summary>
        public hvec4 agba => new hvec4(w, y, z, w);
        
        /// <summary>
        /// Returns hvec4.wyw swizzling.
        /// </summary>
        public hvec3 wyw => new hvec3(w, y, w);
        
        /// <summary>
        /// Returns hvec4.aga swizzling (equivalent to hvec4.wyw).
        /// </summary>
        public hvec3 aga => new hvec3(w, y, w);
        
        /// <summary>
        /// Returns hvec4.wywx swizzling.
        /// </summary>
        public hvec4 wywx => new hvec4(w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.agar swizzling (equivalent to hvec4.wywx).
        /// </summary>
        public hvec4 agar => new hvec4(w, y, w, x);
        
        /// <summary>
        /// Returns hvec4.wywy swizzling.
        /// </summary>
        public hvec4 wywy => new hvec4(w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.agag swizzling (equivalent to hvec4.wywy).
        /// </summary>
        public hvec4 agag => new hvec4(w, y, w, y);
        
        /// <summary>
        /// Returns hvec4.wywz swizzling.
        /// </summary>
        public hvec4 wywz => new hvec4(w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.agab swizzling (equivalent to hvec4.wywz).
        /// </summary>
        public hvec4 agab => new hvec4(w, y, w, z);
        
        /// <summary>
        /// Returns hvec4.wyww swizzling.
        /// </summary>
        public hvec4 wyww => new hvec4(w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.agaa swizzling (equivalent to hvec4.wyww).
        /// </summary>
        public hvec4 agaa => new hvec4(w, y, w, w);
        
        /// <summary>
        /// Returns hvec4.wz swizzling.
        /// </summary>
        public hvec2 wz => new hvec2(w, z);
        
        /// <summary>
        /// Returns hvec4.ab swizzling (equivalent to hvec4.wz).
        /// </summary>
        public hvec2 ab => new hvec2(w, z);
        
        /// <summary>
        /// Returns hvec4.wzx swizzling.
        /// </summary>
        public hvec3 wzx => new hvec3(w, z, x);
        
        /// <summary>
        /// Returns hvec4.abr swizzling (equivalent to hvec4.wzx).
        /// </summary>
        public hvec3 abr => new hvec3(w, z, x);
        
        /// <summary>
        /// Returns hvec4.wzxx swizzling.
        /// </summary>
        public hvec4 wzxx => new hvec4(w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.abrr swizzling (equivalent to hvec4.wzxx).
        /// </summary>
        public hvec4 abrr => new hvec4(w, z, x, x);
        
        /// <summary>
        /// Returns hvec4.wzxy swizzling.
        /// </summary>
        public hvec4 wzxy => new hvec4(w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.abrg swizzling (equivalent to hvec4.wzxy).
        /// </summary>
        public hvec4 abrg => new hvec4(w, z, x, y);
        
        /// <summary>
        /// Returns hvec4.wzxz swizzling.
        /// </summary>
        public hvec4 wzxz => new hvec4(w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.abrb swizzling (equivalent to hvec4.wzxz).
        /// </summary>
        public hvec4 abrb => new hvec4(w, z, x, z);
        
        /// <summary>
        /// Returns hvec4.wzxw swizzling.
        /// </summary>
        public hvec4 wzxw => new hvec4(w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.abra swizzling (equivalent to hvec4.wzxw).
        /// </summary>
        public hvec4 abra => new hvec4(w, z, x, w);
        
        /// <summary>
        /// Returns hvec4.wzy swizzling.
        /// </summary>
        public hvec3 wzy => new hvec3(w, z, y);
        
        /// <summary>
        /// Returns hvec4.abg swizzling (equivalent to hvec4.wzy).
        /// </summary>
        public hvec3 abg => new hvec3(w, z, y);
        
        /// <summary>
        /// Returns hvec4.wzyx swizzling.
        /// </summary>
        public hvec4 wzyx => new hvec4(w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.abgr swizzling (equivalent to hvec4.wzyx).
        /// </summary>
        public hvec4 abgr => new hvec4(w, z, y, x);
        
        /// <summary>
        /// Returns hvec4.wzyy swizzling.
        /// </summary>
        public hvec4 wzyy => new hvec4(w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.abgg swizzling (equivalent to hvec4.wzyy).
        /// </summary>
        public hvec4 abgg => new hvec4(w, z, y, y);
        
        /// <summary>
        /// Returns hvec4.wzyz swizzling.
        /// </summary>
        public hvec4 wzyz => new hvec4(w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.abgb swizzling (equivalent to hvec4.wzyz).
        /// </summary>
        public hvec4 abgb => new hvec4(w, z, y, z);
        
        /// <summary>
        /// Returns hvec4.wzyw swizzling.
        /// </summary>
        public hvec4 wzyw => new hvec4(w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.abga swizzling (equivalent to hvec4.wzyw).
        /// </summary>
        public hvec4 abga => new hvec4(w, z, y, w);
        
        /// <summary>
        /// Returns hvec4.wzz swizzling.
        /// </summary>
        public hvec3 wzz => new hvec3(w, z, z);
        
        /// <summary>
        /// Returns hvec4.abb swizzling (equivalent to hvec4.wzz).
        /// </summary>
        public hvec3 abb => new hvec3(w, z, z);
        
        /// <summary>
        /// Returns hvec4.wzzx swizzling.
        /// </summary>
        public hvec4 wzzx => new hvec4(w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.abbr swizzling (equivalent to hvec4.wzzx).
        /// </summary>
        public hvec4 abbr => new hvec4(w, z, z, x);
        
        /// <summary>
        /// Returns hvec4.wzzy swizzling.
        /// </summary>
        public hvec4 wzzy => new hvec4(w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.abbg swizzling (equivalent to hvec4.wzzy).
        /// </summary>
        public hvec4 abbg => new hvec4(w, z, z, y);
        
        /// <summary>
        /// Returns hvec4.wzzz swizzling.
        /// </summary>
        public hvec4 wzzz => new hvec4(w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.abbb swizzling (equivalent to hvec4.wzzz).
        /// </summary>
        public hvec4 abbb => new hvec4(w, z, z, z);
        
        /// <summary>
        /// Returns hvec4.wzzw swizzling.
        /// </summary>
        public hvec4 wzzw => new hvec4(w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.abba swizzling (equivalent to hvec4.wzzw).
        /// </summary>
        public hvec4 abba => new hvec4(w, z, z, w);
        
        /// <summary>
        /// Returns hvec4.wzw swizzling.
        /// </summary>
        public hvec3 wzw => new hvec3(w, z, w);
        
        /// <summary>
        /// Returns hvec4.aba swizzling (equivalent to hvec4.wzw).
        /// </summary>
        public hvec3 aba => new hvec3(w, z, w);
        
        /// <summary>
        /// Returns hvec4.wzwx swizzling.
        /// </summary>
        public hvec4 wzwx => new hvec4(w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.abar swizzling (equivalent to hvec4.wzwx).
        /// </summary>
        public hvec4 abar => new hvec4(w, z, w, x);
        
        /// <summary>
        /// Returns hvec4.wzwy swizzling.
        /// </summary>
        public hvec4 wzwy => new hvec4(w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.abag swizzling (equivalent to hvec4.wzwy).
        /// </summary>
        public hvec4 abag => new hvec4(w, z, w, y);
        
        /// <summary>
        /// Returns hvec4.wzwz swizzling.
        /// </summary>
        public hvec4 wzwz => new hvec4(w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.abab swizzling (equivalent to hvec4.wzwz).
        /// </summary>
        public hvec4 abab => new hvec4(w, z, w, z);
        
        /// <summary>
        /// Returns hvec4.wzww swizzling.
        /// </summary>
        public hvec4 wzww => new hvec4(w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.abaa swizzling (equivalent to hvec4.wzww).
        /// </summary>
        public hvec4 abaa => new hvec4(w, z, w, w);
        
        /// <summary>
        /// Returns hvec4.ww swizzling.
        /// </summary>
        public hvec2 ww => new hvec2(w, w);
        
        /// <summary>
        /// Returns hvec4.aa swizzling (equivalent to hvec4.ww).
        /// </summary>
        public hvec2 aa => new hvec2(w, w);
        
        /// <summary>
        /// Returns hvec4.wwx swizzling.
        /// </summary>
        public hvec3 wwx => new hvec3(w, w, x);
        
        /// <summary>
        /// Returns hvec4.aar swizzling (equivalent to hvec4.wwx).
        /// </summary>
        public hvec3 aar => new hvec3(w, w, x);
        
        /// <summary>
        /// Returns hvec4.wwxx swizzling.
        /// </summary>
        public hvec4 wwxx => new hvec4(w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.aarr swizzling (equivalent to hvec4.wwxx).
        /// </summary>
        public hvec4 aarr => new hvec4(w, w, x, x);
        
        /// <summary>
        /// Returns hvec4.wwxy swizzling.
        /// </summary>
        public hvec4 wwxy => new hvec4(w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.aarg swizzling (equivalent to hvec4.wwxy).
        /// </summary>
        public hvec4 aarg => new hvec4(w, w, x, y);
        
        /// <summary>
        /// Returns hvec4.wwxz swizzling.
        /// </summary>
        public hvec4 wwxz => new hvec4(w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.aarb swizzling (equivalent to hvec4.wwxz).
        /// </summary>
        public hvec4 aarb => new hvec4(w, w, x, z);
        
        /// <summary>
        /// Returns hvec4.wwxw swizzling.
        /// </summary>
        public hvec4 wwxw => new hvec4(w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.aara swizzling (equivalent to hvec4.wwxw).
        /// </summary>
        public hvec4 aara => new hvec4(w, w, x, w);
        
        /// <summary>
        /// Returns hvec4.wwy swizzling.
        /// </summary>
        public hvec3 wwy => new hvec3(w, w, y);
        
        /// <summary>
        /// Returns hvec4.aag swizzling (equivalent to hvec4.wwy).
        /// </summary>
        public hvec3 aag => new hvec3(w, w, y);
        
        /// <summary>
        /// Returns hvec4.wwyx swizzling.
        /// </summary>
        public hvec4 wwyx => new hvec4(w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.aagr swizzling (equivalent to hvec4.wwyx).
        /// </summary>
        public hvec4 aagr => new hvec4(w, w, y, x);
        
        /// <summary>
        /// Returns hvec4.wwyy swizzling.
        /// </summary>
        public hvec4 wwyy => new hvec4(w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.aagg swizzling (equivalent to hvec4.wwyy).
        /// </summary>
        public hvec4 aagg => new hvec4(w, w, y, y);
        
        /// <summary>
        /// Returns hvec4.wwyz swizzling.
        /// </summary>
        public hvec4 wwyz => new hvec4(w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.aagb swizzling (equivalent to hvec4.wwyz).
        /// </summary>
        public hvec4 aagb => new hvec4(w, w, y, z);
        
        /// <summary>
        /// Returns hvec4.wwyw swizzling.
        /// </summary>
        public hvec4 wwyw => new hvec4(w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.aaga swizzling (equivalent to hvec4.wwyw).
        /// </summary>
        public hvec4 aaga => new hvec4(w, w, y, w);
        
        /// <summary>
        /// Returns hvec4.wwz swizzling.
        /// </summary>
        public hvec3 wwz => new hvec3(w, w, z);
        
        /// <summary>
        /// Returns hvec4.aab swizzling (equivalent to hvec4.wwz).
        /// </summary>
        public hvec3 aab => new hvec3(w, w, z);
        
        /// <summary>
        /// Returns hvec4.wwzx swizzling.
        /// </summary>
        public hvec4 wwzx => new hvec4(w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.aabr swizzling (equivalent to hvec4.wwzx).
        /// </summary>
        public hvec4 aabr => new hvec4(w, w, z, x);
        
        /// <summary>
        /// Returns hvec4.wwzy swizzling.
        /// </summary>
        public hvec4 wwzy => new hvec4(w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.aabg swizzling (equivalent to hvec4.wwzy).
        /// </summary>
        public hvec4 aabg => new hvec4(w, w, z, y);
        
        /// <summary>
        /// Returns hvec4.wwzz swizzling.
        /// </summary>
        public hvec4 wwzz => new hvec4(w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.aabb swizzling (equivalent to hvec4.wwzz).
        /// </summary>
        public hvec4 aabb => new hvec4(w, w, z, z);
        
        /// <summary>
        /// Returns hvec4.wwzw swizzling.
        /// </summary>
        public hvec4 wwzw => new hvec4(w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.aaba swizzling (equivalent to hvec4.wwzw).
        /// </summary>
        public hvec4 aaba => new hvec4(w, w, z, w);
        
        /// <summary>
        /// Returns hvec4.www swizzling.
        /// </summary>
        public hvec3 www => new hvec3(w, w, w);
        
        /// <summary>
        /// Returns hvec4.aaa swizzling (equivalent to hvec4.www).
        /// </summary>
        public hvec3 aaa => new hvec3(w, w, w);
        
        /// <summary>
        /// Returns hvec4.wwwx swizzling.
        /// </summary>
        public hvec4 wwwx => new hvec4(w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.aaar swizzling (equivalent to hvec4.wwwx).
        /// </summary>
        public hvec4 aaar => new hvec4(w, w, w, x);
        
        /// <summary>
        /// Returns hvec4.wwwy swizzling.
        /// </summary>
        public hvec4 wwwy => new hvec4(w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.aaag swizzling (equivalent to hvec4.wwwy).
        /// </summary>
        public hvec4 aaag => new hvec4(w, w, w, y);
        
        /// <summary>
        /// Returns hvec4.wwwz swizzling.
        /// </summary>
        public hvec4 wwwz => new hvec4(w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.aaab swizzling (equivalent to hvec4.wwwz).
        /// </summary>
        public hvec4 aaab => new hvec4(w, w, w, z);
        
        /// <summary>
        /// Returns hvec4.wwww swizzling.
        /// </summary>
        public hvec4 wwww => new hvec4(w, w, w, w);
        
        /// <summary>
        /// Returns hvec4.aaaa swizzling (equivalent to hvec4.wwww).
        /// </summary>
        public hvec4 aaaa => new hvec4(w, w, w, w);

        #endregion

    }
}
