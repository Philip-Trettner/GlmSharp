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
    /// Temporary vector of type long with 4 components, used for implementing swizzling for lvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_lvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly long x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly long y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly long z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly long w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_lvec4.
        /// </summary>
        internal swizzle_lvec4(long x, long y, long z, long w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns lvec4.xx swizzling.
        /// </summary>
        public lvec2 xx => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec4.rr swizzling (equivalent to lvec4.xx).
        /// </summary>
        public lvec2 rr => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec4.xxx swizzling.
        /// </summary>
        public lvec3 xxx => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec4.rrr swizzling (equivalent to lvec4.xxx).
        /// </summary>
        public lvec3 rrr => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec4.xxxx swizzling.
        /// </summary>
        public lvec4 xxxx => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.rrrr swizzling (equivalent to lvec4.xxxx).
        /// </summary>
        public lvec4 rrrr => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.xxxy swizzling.
        /// </summary>
        public lvec4 xxxy => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.rrrg swizzling (equivalent to lvec4.xxxy).
        /// </summary>
        public lvec4 rrrg => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.xxxz swizzling.
        /// </summary>
        public lvec4 xxxz => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.rrrb swizzling (equivalent to lvec4.xxxz).
        /// </summary>
        public lvec4 rrrb => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.xxxw swizzling.
        /// </summary>
        public lvec4 xxxw => new lvec4(x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.rrra swizzling (equivalent to lvec4.xxxw).
        /// </summary>
        public lvec4 rrra => new lvec4(x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.xxy swizzling.
        /// </summary>
        public lvec3 xxy => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec4.rrg swizzling (equivalent to lvec4.xxy).
        /// </summary>
        public lvec3 rrg => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec4.xxyx swizzling.
        /// </summary>
        public lvec4 xxyx => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.rrgr swizzling (equivalent to lvec4.xxyx).
        /// </summary>
        public lvec4 rrgr => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.xxyy swizzling.
        /// </summary>
        public lvec4 xxyy => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.rrgg swizzling (equivalent to lvec4.xxyy).
        /// </summary>
        public lvec4 rrgg => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.xxyz swizzling.
        /// </summary>
        public lvec4 xxyz => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.rrgb swizzling (equivalent to lvec4.xxyz).
        /// </summary>
        public lvec4 rrgb => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.xxyw swizzling.
        /// </summary>
        public lvec4 xxyw => new lvec4(x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.rrga swizzling (equivalent to lvec4.xxyw).
        /// </summary>
        public lvec4 rrga => new lvec4(x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.xxz swizzling.
        /// </summary>
        public lvec3 xxz => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec4.rrb swizzling (equivalent to lvec4.xxz).
        /// </summary>
        public lvec3 rrb => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec4.xxzx swizzling.
        /// </summary>
        public lvec4 xxzx => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.rrbr swizzling (equivalent to lvec4.xxzx).
        /// </summary>
        public lvec4 rrbr => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.xxzy swizzling.
        /// </summary>
        public lvec4 xxzy => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.rrbg swizzling (equivalent to lvec4.xxzy).
        /// </summary>
        public lvec4 rrbg => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.xxzz swizzling.
        /// </summary>
        public lvec4 xxzz => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.rrbb swizzling (equivalent to lvec4.xxzz).
        /// </summary>
        public lvec4 rrbb => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.xxzw swizzling.
        /// </summary>
        public lvec4 xxzw => new lvec4(x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.rrba swizzling (equivalent to lvec4.xxzw).
        /// </summary>
        public lvec4 rrba => new lvec4(x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.xxw swizzling.
        /// </summary>
        public lvec3 xxw => new lvec3(x, x, w);
        
        /// <summary>
        /// Returns lvec4.rra swizzling (equivalent to lvec4.xxw).
        /// </summary>
        public lvec3 rra => new lvec3(x, x, w);
        
        /// <summary>
        /// Returns lvec4.xxwx swizzling.
        /// </summary>
        public lvec4 xxwx => new lvec4(x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.rrar swizzling (equivalent to lvec4.xxwx).
        /// </summary>
        public lvec4 rrar => new lvec4(x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.xxwy swizzling.
        /// </summary>
        public lvec4 xxwy => new lvec4(x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.rrag swizzling (equivalent to lvec4.xxwy).
        /// </summary>
        public lvec4 rrag => new lvec4(x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.xxwz swizzling.
        /// </summary>
        public lvec4 xxwz => new lvec4(x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.rrab swizzling (equivalent to lvec4.xxwz).
        /// </summary>
        public lvec4 rrab => new lvec4(x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.xxww swizzling.
        /// </summary>
        public lvec4 xxww => new lvec4(x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.rraa swizzling (equivalent to lvec4.xxww).
        /// </summary>
        public lvec4 rraa => new lvec4(x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.xy swizzling.
        /// </summary>
        public lvec2 xy => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec4.rg swizzling (equivalent to lvec4.xy).
        /// </summary>
        public lvec2 rg => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec4.xyx swizzling.
        /// </summary>
        public lvec3 xyx => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec4.rgr swizzling (equivalent to lvec4.xyx).
        /// </summary>
        public lvec3 rgr => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec4.xyxx swizzling.
        /// </summary>
        public lvec4 xyxx => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.rgrr swizzling (equivalent to lvec4.xyxx).
        /// </summary>
        public lvec4 rgrr => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.xyxy swizzling.
        /// </summary>
        public lvec4 xyxy => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.rgrg swizzling (equivalent to lvec4.xyxy).
        /// </summary>
        public lvec4 rgrg => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.xyxz swizzling.
        /// </summary>
        public lvec4 xyxz => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.rgrb swizzling (equivalent to lvec4.xyxz).
        /// </summary>
        public lvec4 rgrb => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.xyxw swizzling.
        /// </summary>
        public lvec4 xyxw => new lvec4(x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.rgra swizzling (equivalent to lvec4.xyxw).
        /// </summary>
        public lvec4 rgra => new lvec4(x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.xyy swizzling.
        /// </summary>
        public lvec3 xyy => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec4.rgg swizzling (equivalent to lvec4.xyy).
        /// </summary>
        public lvec3 rgg => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec4.xyyx swizzling.
        /// </summary>
        public lvec4 xyyx => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.rggr swizzling (equivalent to lvec4.xyyx).
        /// </summary>
        public lvec4 rggr => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.xyyy swizzling.
        /// </summary>
        public lvec4 xyyy => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.rggg swizzling (equivalent to lvec4.xyyy).
        /// </summary>
        public lvec4 rggg => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.xyyz swizzling.
        /// </summary>
        public lvec4 xyyz => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.rggb swizzling (equivalent to lvec4.xyyz).
        /// </summary>
        public lvec4 rggb => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.xyyw swizzling.
        /// </summary>
        public lvec4 xyyw => new lvec4(x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.rgga swizzling (equivalent to lvec4.xyyw).
        /// </summary>
        public lvec4 rgga => new lvec4(x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.xyz swizzling.
        /// </summary>
        public lvec3 xyz => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec4.rgb swizzling (equivalent to lvec4.xyz).
        /// </summary>
        public lvec3 rgb => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec4.xyzx swizzling.
        /// </summary>
        public lvec4 xyzx => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.rgbr swizzling (equivalent to lvec4.xyzx).
        /// </summary>
        public lvec4 rgbr => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.xyzy swizzling.
        /// </summary>
        public lvec4 xyzy => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.rgbg swizzling (equivalent to lvec4.xyzy).
        /// </summary>
        public lvec4 rgbg => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.xyzz swizzling.
        /// </summary>
        public lvec4 xyzz => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.rgbb swizzling (equivalent to lvec4.xyzz).
        /// </summary>
        public lvec4 rgbb => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.xyzw swizzling.
        /// </summary>
        public lvec4 xyzw => new lvec4(x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.rgba swizzling (equivalent to lvec4.xyzw).
        /// </summary>
        public lvec4 rgba => new lvec4(x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.xyw swizzling.
        /// </summary>
        public lvec3 xyw => new lvec3(x, y, w);
        
        /// <summary>
        /// Returns lvec4.rga swizzling (equivalent to lvec4.xyw).
        /// </summary>
        public lvec3 rga => new lvec3(x, y, w);
        
        /// <summary>
        /// Returns lvec4.xywx swizzling.
        /// </summary>
        public lvec4 xywx => new lvec4(x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.rgar swizzling (equivalent to lvec4.xywx).
        /// </summary>
        public lvec4 rgar => new lvec4(x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.xywy swizzling.
        /// </summary>
        public lvec4 xywy => new lvec4(x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.rgag swizzling (equivalent to lvec4.xywy).
        /// </summary>
        public lvec4 rgag => new lvec4(x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.xywz swizzling.
        /// </summary>
        public lvec4 xywz => new lvec4(x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.rgab swizzling (equivalent to lvec4.xywz).
        /// </summary>
        public lvec4 rgab => new lvec4(x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.xyww swizzling.
        /// </summary>
        public lvec4 xyww => new lvec4(x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.rgaa swizzling (equivalent to lvec4.xyww).
        /// </summary>
        public lvec4 rgaa => new lvec4(x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.xz swizzling.
        /// </summary>
        public lvec2 xz => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec4.rb swizzling (equivalent to lvec4.xz).
        /// </summary>
        public lvec2 rb => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec4.xzx swizzling.
        /// </summary>
        public lvec3 xzx => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec4.rbr swizzling (equivalent to lvec4.xzx).
        /// </summary>
        public lvec3 rbr => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec4.xzxx swizzling.
        /// </summary>
        public lvec4 xzxx => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.rbrr swizzling (equivalent to lvec4.xzxx).
        /// </summary>
        public lvec4 rbrr => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.xzxy swizzling.
        /// </summary>
        public lvec4 xzxy => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.rbrg swizzling (equivalent to lvec4.xzxy).
        /// </summary>
        public lvec4 rbrg => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.xzxz swizzling.
        /// </summary>
        public lvec4 xzxz => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.rbrb swizzling (equivalent to lvec4.xzxz).
        /// </summary>
        public lvec4 rbrb => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.xzxw swizzling.
        /// </summary>
        public lvec4 xzxw => new lvec4(x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.rbra swizzling (equivalent to lvec4.xzxw).
        /// </summary>
        public lvec4 rbra => new lvec4(x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.xzy swizzling.
        /// </summary>
        public lvec3 xzy => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec4.rbg swizzling (equivalent to lvec4.xzy).
        /// </summary>
        public lvec3 rbg => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec4.xzyx swizzling.
        /// </summary>
        public lvec4 xzyx => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.rbgr swizzling (equivalent to lvec4.xzyx).
        /// </summary>
        public lvec4 rbgr => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.xzyy swizzling.
        /// </summary>
        public lvec4 xzyy => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.rbgg swizzling (equivalent to lvec4.xzyy).
        /// </summary>
        public lvec4 rbgg => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.xzyz swizzling.
        /// </summary>
        public lvec4 xzyz => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.rbgb swizzling (equivalent to lvec4.xzyz).
        /// </summary>
        public lvec4 rbgb => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.xzyw swizzling.
        /// </summary>
        public lvec4 xzyw => new lvec4(x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.rbga swizzling (equivalent to lvec4.xzyw).
        /// </summary>
        public lvec4 rbga => new lvec4(x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.xzz swizzling.
        /// </summary>
        public lvec3 xzz => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec4.rbb swizzling (equivalent to lvec4.xzz).
        /// </summary>
        public lvec3 rbb => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec4.xzzx swizzling.
        /// </summary>
        public lvec4 xzzx => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.rbbr swizzling (equivalent to lvec4.xzzx).
        /// </summary>
        public lvec4 rbbr => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.xzzy swizzling.
        /// </summary>
        public lvec4 xzzy => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.rbbg swizzling (equivalent to lvec4.xzzy).
        /// </summary>
        public lvec4 rbbg => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.xzzz swizzling.
        /// </summary>
        public lvec4 xzzz => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.rbbb swizzling (equivalent to lvec4.xzzz).
        /// </summary>
        public lvec4 rbbb => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.xzzw swizzling.
        /// </summary>
        public lvec4 xzzw => new lvec4(x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.rbba swizzling (equivalent to lvec4.xzzw).
        /// </summary>
        public lvec4 rbba => new lvec4(x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.xzw swizzling.
        /// </summary>
        public lvec3 xzw => new lvec3(x, z, w);
        
        /// <summary>
        /// Returns lvec4.rba swizzling (equivalent to lvec4.xzw).
        /// </summary>
        public lvec3 rba => new lvec3(x, z, w);
        
        /// <summary>
        /// Returns lvec4.xzwx swizzling.
        /// </summary>
        public lvec4 xzwx => new lvec4(x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.rbar swizzling (equivalent to lvec4.xzwx).
        /// </summary>
        public lvec4 rbar => new lvec4(x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.xzwy swizzling.
        /// </summary>
        public lvec4 xzwy => new lvec4(x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.rbag swizzling (equivalent to lvec4.xzwy).
        /// </summary>
        public lvec4 rbag => new lvec4(x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.xzwz swizzling.
        /// </summary>
        public lvec4 xzwz => new lvec4(x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.rbab swizzling (equivalent to lvec4.xzwz).
        /// </summary>
        public lvec4 rbab => new lvec4(x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.xzww swizzling.
        /// </summary>
        public lvec4 xzww => new lvec4(x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.rbaa swizzling (equivalent to lvec4.xzww).
        /// </summary>
        public lvec4 rbaa => new lvec4(x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.xw swizzling.
        /// </summary>
        public lvec2 xw => new lvec2(x, w);
        
        /// <summary>
        /// Returns lvec4.ra swizzling (equivalent to lvec4.xw).
        /// </summary>
        public lvec2 ra => new lvec2(x, w);
        
        /// <summary>
        /// Returns lvec4.xwx swizzling.
        /// </summary>
        public lvec3 xwx => new lvec3(x, w, x);
        
        /// <summary>
        /// Returns lvec4.rar swizzling (equivalent to lvec4.xwx).
        /// </summary>
        public lvec3 rar => new lvec3(x, w, x);
        
        /// <summary>
        /// Returns lvec4.xwxx swizzling.
        /// </summary>
        public lvec4 xwxx => new lvec4(x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.rarr swizzling (equivalent to lvec4.xwxx).
        /// </summary>
        public lvec4 rarr => new lvec4(x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.xwxy swizzling.
        /// </summary>
        public lvec4 xwxy => new lvec4(x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.rarg swizzling (equivalent to lvec4.xwxy).
        /// </summary>
        public lvec4 rarg => new lvec4(x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.xwxz swizzling.
        /// </summary>
        public lvec4 xwxz => new lvec4(x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.rarb swizzling (equivalent to lvec4.xwxz).
        /// </summary>
        public lvec4 rarb => new lvec4(x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.xwxw swizzling.
        /// </summary>
        public lvec4 xwxw => new lvec4(x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.rara swizzling (equivalent to lvec4.xwxw).
        /// </summary>
        public lvec4 rara => new lvec4(x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.xwy swizzling.
        /// </summary>
        public lvec3 xwy => new lvec3(x, w, y);
        
        /// <summary>
        /// Returns lvec4.rag swizzling (equivalent to lvec4.xwy).
        /// </summary>
        public lvec3 rag => new lvec3(x, w, y);
        
        /// <summary>
        /// Returns lvec4.xwyx swizzling.
        /// </summary>
        public lvec4 xwyx => new lvec4(x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.ragr swizzling (equivalent to lvec4.xwyx).
        /// </summary>
        public lvec4 ragr => new lvec4(x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.xwyy swizzling.
        /// </summary>
        public lvec4 xwyy => new lvec4(x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.ragg swizzling (equivalent to lvec4.xwyy).
        /// </summary>
        public lvec4 ragg => new lvec4(x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.xwyz swizzling.
        /// </summary>
        public lvec4 xwyz => new lvec4(x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.ragb swizzling (equivalent to lvec4.xwyz).
        /// </summary>
        public lvec4 ragb => new lvec4(x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.xwyw swizzling.
        /// </summary>
        public lvec4 xwyw => new lvec4(x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.raga swizzling (equivalent to lvec4.xwyw).
        /// </summary>
        public lvec4 raga => new lvec4(x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.xwz swizzling.
        /// </summary>
        public lvec3 xwz => new lvec3(x, w, z);
        
        /// <summary>
        /// Returns lvec4.rab swizzling (equivalent to lvec4.xwz).
        /// </summary>
        public lvec3 rab => new lvec3(x, w, z);
        
        /// <summary>
        /// Returns lvec4.xwzx swizzling.
        /// </summary>
        public lvec4 xwzx => new lvec4(x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.rabr swizzling (equivalent to lvec4.xwzx).
        /// </summary>
        public lvec4 rabr => new lvec4(x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.xwzy swizzling.
        /// </summary>
        public lvec4 xwzy => new lvec4(x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.rabg swizzling (equivalent to lvec4.xwzy).
        /// </summary>
        public lvec4 rabg => new lvec4(x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.xwzz swizzling.
        /// </summary>
        public lvec4 xwzz => new lvec4(x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.rabb swizzling (equivalent to lvec4.xwzz).
        /// </summary>
        public lvec4 rabb => new lvec4(x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.xwzw swizzling.
        /// </summary>
        public lvec4 xwzw => new lvec4(x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.raba swizzling (equivalent to lvec4.xwzw).
        /// </summary>
        public lvec4 raba => new lvec4(x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.xww swizzling.
        /// </summary>
        public lvec3 xww => new lvec3(x, w, w);
        
        /// <summary>
        /// Returns lvec4.raa swizzling (equivalent to lvec4.xww).
        /// </summary>
        public lvec3 raa => new lvec3(x, w, w);
        
        /// <summary>
        /// Returns lvec4.xwwx swizzling.
        /// </summary>
        public lvec4 xwwx => new lvec4(x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.raar swizzling (equivalent to lvec4.xwwx).
        /// </summary>
        public lvec4 raar => new lvec4(x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.xwwy swizzling.
        /// </summary>
        public lvec4 xwwy => new lvec4(x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.raag swizzling (equivalent to lvec4.xwwy).
        /// </summary>
        public lvec4 raag => new lvec4(x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.xwwz swizzling.
        /// </summary>
        public lvec4 xwwz => new lvec4(x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.raab swizzling (equivalent to lvec4.xwwz).
        /// </summary>
        public lvec4 raab => new lvec4(x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.xwww swizzling.
        /// </summary>
        public lvec4 xwww => new lvec4(x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.raaa swizzling (equivalent to lvec4.xwww).
        /// </summary>
        public lvec4 raaa => new lvec4(x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.yx swizzling.
        /// </summary>
        public lvec2 yx => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec4.gr swizzling (equivalent to lvec4.yx).
        /// </summary>
        public lvec2 gr => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec4.yxx swizzling.
        /// </summary>
        public lvec3 yxx => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec4.grr swizzling (equivalent to lvec4.yxx).
        /// </summary>
        public lvec3 grr => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec4.yxxx swizzling.
        /// </summary>
        public lvec4 yxxx => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.grrr swizzling (equivalent to lvec4.yxxx).
        /// </summary>
        public lvec4 grrr => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.yxxy swizzling.
        /// </summary>
        public lvec4 yxxy => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.grrg swizzling (equivalent to lvec4.yxxy).
        /// </summary>
        public lvec4 grrg => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.yxxz swizzling.
        /// </summary>
        public lvec4 yxxz => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.grrb swizzling (equivalent to lvec4.yxxz).
        /// </summary>
        public lvec4 grrb => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.yxxw swizzling.
        /// </summary>
        public lvec4 yxxw => new lvec4(y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.grra swizzling (equivalent to lvec4.yxxw).
        /// </summary>
        public lvec4 grra => new lvec4(y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.yxy swizzling.
        /// </summary>
        public lvec3 yxy => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec4.grg swizzling (equivalent to lvec4.yxy).
        /// </summary>
        public lvec3 grg => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec4.yxyx swizzling.
        /// </summary>
        public lvec4 yxyx => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.grgr swizzling (equivalent to lvec4.yxyx).
        /// </summary>
        public lvec4 grgr => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.yxyy swizzling.
        /// </summary>
        public lvec4 yxyy => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.grgg swizzling (equivalent to lvec4.yxyy).
        /// </summary>
        public lvec4 grgg => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.yxyz swizzling.
        /// </summary>
        public lvec4 yxyz => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.grgb swizzling (equivalent to lvec4.yxyz).
        /// </summary>
        public lvec4 grgb => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.yxyw swizzling.
        /// </summary>
        public lvec4 yxyw => new lvec4(y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.grga swizzling (equivalent to lvec4.yxyw).
        /// </summary>
        public lvec4 grga => new lvec4(y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.yxz swizzling.
        /// </summary>
        public lvec3 yxz => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec4.grb swizzling (equivalent to lvec4.yxz).
        /// </summary>
        public lvec3 grb => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec4.yxzx swizzling.
        /// </summary>
        public lvec4 yxzx => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.grbr swizzling (equivalent to lvec4.yxzx).
        /// </summary>
        public lvec4 grbr => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.yxzy swizzling.
        /// </summary>
        public lvec4 yxzy => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.grbg swizzling (equivalent to lvec4.yxzy).
        /// </summary>
        public lvec4 grbg => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.yxzz swizzling.
        /// </summary>
        public lvec4 yxzz => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.grbb swizzling (equivalent to lvec4.yxzz).
        /// </summary>
        public lvec4 grbb => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.yxzw swizzling.
        /// </summary>
        public lvec4 yxzw => new lvec4(y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.grba swizzling (equivalent to lvec4.yxzw).
        /// </summary>
        public lvec4 grba => new lvec4(y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.yxw swizzling.
        /// </summary>
        public lvec3 yxw => new lvec3(y, x, w);
        
        /// <summary>
        /// Returns lvec4.gra swizzling (equivalent to lvec4.yxw).
        /// </summary>
        public lvec3 gra => new lvec3(y, x, w);
        
        /// <summary>
        /// Returns lvec4.yxwx swizzling.
        /// </summary>
        public lvec4 yxwx => new lvec4(y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.grar swizzling (equivalent to lvec4.yxwx).
        /// </summary>
        public lvec4 grar => new lvec4(y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.yxwy swizzling.
        /// </summary>
        public lvec4 yxwy => new lvec4(y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.grag swizzling (equivalent to lvec4.yxwy).
        /// </summary>
        public lvec4 grag => new lvec4(y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.yxwz swizzling.
        /// </summary>
        public lvec4 yxwz => new lvec4(y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.grab swizzling (equivalent to lvec4.yxwz).
        /// </summary>
        public lvec4 grab => new lvec4(y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.yxww swizzling.
        /// </summary>
        public lvec4 yxww => new lvec4(y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.graa swizzling (equivalent to lvec4.yxww).
        /// </summary>
        public lvec4 graa => new lvec4(y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.yy swizzling.
        /// </summary>
        public lvec2 yy => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec4.gg swizzling (equivalent to lvec4.yy).
        /// </summary>
        public lvec2 gg => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec4.yyx swizzling.
        /// </summary>
        public lvec3 yyx => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec4.ggr swizzling (equivalent to lvec4.yyx).
        /// </summary>
        public lvec3 ggr => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec4.yyxx swizzling.
        /// </summary>
        public lvec4 yyxx => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.ggrr swizzling (equivalent to lvec4.yyxx).
        /// </summary>
        public lvec4 ggrr => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.yyxy swizzling.
        /// </summary>
        public lvec4 yyxy => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.ggrg swizzling (equivalent to lvec4.yyxy).
        /// </summary>
        public lvec4 ggrg => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.yyxz swizzling.
        /// </summary>
        public lvec4 yyxz => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.ggrb swizzling (equivalent to lvec4.yyxz).
        /// </summary>
        public lvec4 ggrb => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.yyxw swizzling.
        /// </summary>
        public lvec4 yyxw => new lvec4(y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.ggra swizzling (equivalent to lvec4.yyxw).
        /// </summary>
        public lvec4 ggra => new lvec4(y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.yyy swizzling.
        /// </summary>
        public lvec3 yyy => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec4.ggg swizzling (equivalent to lvec4.yyy).
        /// </summary>
        public lvec3 ggg => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec4.yyyx swizzling.
        /// </summary>
        public lvec4 yyyx => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.gggr swizzling (equivalent to lvec4.yyyx).
        /// </summary>
        public lvec4 gggr => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.yyyy swizzling.
        /// </summary>
        public lvec4 yyyy => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.gggg swizzling (equivalent to lvec4.yyyy).
        /// </summary>
        public lvec4 gggg => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.yyyz swizzling.
        /// </summary>
        public lvec4 yyyz => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.gggb swizzling (equivalent to lvec4.yyyz).
        /// </summary>
        public lvec4 gggb => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.yyyw swizzling.
        /// </summary>
        public lvec4 yyyw => new lvec4(y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.ggga swizzling (equivalent to lvec4.yyyw).
        /// </summary>
        public lvec4 ggga => new lvec4(y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.yyz swizzling.
        /// </summary>
        public lvec3 yyz => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec4.ggb swizzling (equivalent to lvec4.yyz).
        /// </summary>
        public lvec3 ggb => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec4.yyzx swizzling.
        /// </summary>
        public lvec4 yyzx => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.ggbr swizzling (equivalent to lvec4.yyzx).
        /// </summary>
        public lvec4 ggbr => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.yyzy swizzling.
        /// </summary>
        public lvec4 yyzy => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.ggbg swizzling (equivalent to lvec4.yyzy).
        /// </summary>
        public lvec4 ggbg => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.yyzz swizzling.
        /// </summary>
        public lvec4 yyzz => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.ggbb swizzling (equivalent to lvec4.yyzz).
        /// </summary>
        public lvec4 ggbb => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.yyzw swizzling.
        /// </summary>
        public lvec4 yyzw => new lvec4(y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.ggba swizzling (equivalent to lvec4.yyzw).
        /// </summary>
        public lvec4 ggba => new lvec4(y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.yyw swizzling.
        /// </summary>
        public lvec3 yyw => new lvec3(y, y, w);
        
        /// <summary>
        /// Returns lvec4.gga swizzling (equivalent to lvec4.yyw).
        /// </summary>
        public lvec3 gga => new lvec3(y, y, w);
        
        /// <summary>
        /// Returns lvec4.yywx swizzling.
        /// </summary>
        public lvec4 yywx => new lvec4(y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.ggar swizzling (equivalent to lvec4.yywx).
        /// </summary>
        public lvec4 ggar => new lvec4(y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.yywy swizzling.
        /// </summary>
        public lvec4 yywy => new lvec4(y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.ggag swizzling (equivalent to lvec4.yywy).
        /// </summary>
        public lvec4 ggag => new lvec4(y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.yywz swizzling.
        /// </summary>
        public lvec4 yywz => new lvec4(y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.ggab swizzling (equivalent to lvec4.yywz).
        /// </summary>
        public lvec4 ggab => new lvec4(y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.yyww swizzling.
        /// </summary>
        public lvec4 yyww => new lvec4(y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.ggaa swizzling (equivalent to lvec4.yyww).
        /// </summary>
        public lvec4 ggaa => new lvec4(y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.yz swizzling.
        /// </summary>
        public lvec2 yz => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec4.gb swizzling (equivalent to lvec4.yz).
        /// </summary>
        public lvec2 gb => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec4.yzx swizzling.
        /// </summary>
        public lvec3 yzx => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec4.gbr swizzling (equivalent to lvec4.yzx).
        /// </summary>
        public lvec3 gbr => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec4.yzxx swizzling.
        /// </summary>
        public lvec4 yzxx => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.gbrr swizzling (equivalent to lvec4.yzxx).
        /// </summary>
        public lvec4 gbrr => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.yzxy swizzling.
        /// </summary>
        public lvec4 yzxy => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.gbrg swizzling (equivalent to lvec4.yzxy).
        /// </summary>
        public lvec4 gbrg => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.yzxz swizzling.
        /// </summary>
        public lvec4 yzxz => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.gbrb swizzling (equivalent to lvec4.yzxz).
        /// </summary>
        public lvec4 gbrb => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.yzxw swizzling.
        /// </summary>
        public lvec4 yzxw => new lvec4(y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.gbra swizzling (equivalent to lvec4.yzxw).
        /// </summary>
        public lvec4 gbra => new lvec4(y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.yzy swizzling.
        /// </summary>
        public lvec3 yzy => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec4.gbg swizzling (equivalent to lvec4.yzy).
        /// </summary>
        public lvec3 gbg => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec4.yzyx swizzling.
        /// </summary>
        public lvec4 yzyx => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.gbgr swizzling (equivalent to lvec4.yzyx).
        /// </summary>
        public lvec4 gbgr => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.yzyy swizzling.
        /// </summary>
        public lvec4 yzyy => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.gbgg swizzling (equivalent to lvec4.yzyy).
        /// </summary>
        public lvec4 gbgg => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.yzyz swizzling.
        /// </summary>
        public lvec4 yzyz => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.gbgb swizzling (equivalent to lvec4.yzyz).
        /// </summary>
        public lvec4 gbgb => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.yzyw swizzling.
        /// </summary>
        public lvec4 yzyw => new lvec4(y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.gbga swizzling (equivalent to lvec4.yzyw).
        /// </summary>
        public lvec4 gbga => new lvec4(y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.yzz swizzling.
        /// </summary>
        public lvec3 yzz => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec4.gbb swizzling (equivalent to lvec4.yzz).
        /// </summary>
        public lvec3 gbb => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec4.yzzx swizzling.
        /// </summary>
        public lvec4 yzzx => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.gbbr swizzling (equivalent to lvec4.yzzx).
        /// </summary>
        public lvec4 gbbr => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.yzzy swizzling.
        /// </summary>
        public lvec4 yzzy => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.gbbg swizzling (equivalent to lvec4.yzzy).
        /// </summary>
        public lvec4 gbbg => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.yzzz swizzling.
        /// </summary>
        public lvec4 yzzz => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.gbbb swizzling (equivalent to lvec4.yzzz).
        /// </summary>
        public lvec4 gbbb => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.yzzw swizzling.
        /// </summary>
        public lvec4 yzzw => new lvec4(y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.gbba swizzling (equivalent to lvec4.yzzw).
        /// </summary>
        public lvec4 gbba => new lvec4(y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.yzw swizzling.
        /// </summary>
        public lvec3 yzw => new lvec3(y, z, w);
        
        /// <summary>
        /// Returns lvec4.gba swizzling (equivalent to lvec4.yzw).
        /// </summary>
        public lvec3 gba => new lvec3(y, z, w);
        
        /// <summary>
        /// Returns lvec4.yzwx swizzling.
        /// </summary>
        public lvec4 yzwx => new lvec4(y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.gbar swizzling (equivalent to lvec4.yzwx).
        /// </summary>
        public lvec4 gbar => new lvec4(y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.yzwy swizzling.
        /// </summary>
        public lvec4 yzwy => new lvec4(y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.gbag swizzling (equivalent to lvec4.yzwy).
        /// </summary>
        public lvec4 gbag => new lvec4(y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.yzwz swizzling.
        /// </summary>
        public lvec4 yzwz => new lvec4(y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.gbab swizzling (equivalent to lvec4.yzwz).
        /// </summary>
        public lvec4 gbab => new lvec4(y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.yzww swizzling.
        /// </summary>
        public lvec4 yzww => new lvec4(y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.gbaa swizzling (equivalent to lvec4.yzww).
        /// </summary>
        public lvec4 gbaa => new lvec4(y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.yw swizzling.
        /// </summary>
        public lvec2 yw => new lvec2(y, w);
        
        /// <summary>
        /// Returns lvec4.ga swizzling (equivalent to lvec4.yw).
        /// </summary>
        public lvec2 ga => new lvec2(y, w);
        
        /// <summary>
        /// Returns lvec4.ywx swizzling.
        /// </summary>
        public lvec3 ywx => new lvec3(y, w, x);
        
        /// <summary>
        /// Returns lvec4.gar swizzling (equivalent to lvec4.ywx).
        /// </summary>
        public lvec3 gar => new lvec3(y, w, x);
        
        /// <summary>
        /// Returns lvec4.ywxx swizzling.
        /// </summary>
        public lvec4 ywxx => new lvec4(y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.garr swizzling (equivalent to lvec4.ywxx).
        /// </summary>
        public lvec4 garr => new lvec4(y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.ywxy swizzling.
        /// </summary>
        public lvec4 ywxy => new lvec4(y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.garg swizzling (equivalent to lvec4.ywxy).
        /// </summary>
        public lvec4 garg => new lvec4(y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.ywxz swizzling.
        /// </summary>
        public lvec4 ywxz => new lvec4(y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.garb swizzling (equivalent to lvec4.ywxz).
        /// </summary>
        public lvec4 garb => new lvec4(y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.ywxw swizzling.
        /// </summary>
        public lvec4 ywxw => new lvec4(y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.gara swizzling (equivalent to lvec4.ywxw).
        /// </summary>
        public lvec4 gara => new lvec4(y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.ywy swizzling.
        /// </summary>
        public lvec3 ywy => new lvec3(y, w, y);
        
        /// <summary>
        /// Returns lvec4.gag swizzling (equivalent to lvec4.ywy).
        /// </summary>
        public lvec3 gag => new lvec3(y, w, y);
        
        /// <summary>
        /// Returns lvec4.ywyx swizzling.
        /// </summary>
        public lvec4 ywyx => new lvec4(y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.gagr swizzling (equivalent to lvec4.ywyx).
        /// </summary>
        public lvec4 gagr => new lvec4(y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.ywyy swizzling.
        /// </summary>
        public lvec4 ywyy => new lvec4(y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.gagg swizzling (equivalent to lvec4.ywyy).
        /// </summary>
        public lvec4 gagg => new lvec4(y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.ywyz swizzling.
        /// </summary>
        public lvec4 ywyz => new lvec4(y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.gagb swizzling (equivalent to lvec4.ywyz).
        /// </summary>
        public lvec4 gagb => new lvec4(y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.ywyw swizzling.
        /// </summary>
        public lvec4 ywyw => new lvec4(y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.gaga swizzling (equivalent to lvec4.ywyw).
        /// </summary>
        public lvec4 gaga => new lvec4(y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.ywz swizzling.
        /// </summary>
        public lvec3 ywz => new lvec3(y, w, z);
        
        /// <summary>
        /// Returns lvec4.gab swizzling (equivalent to lvec4.ywz).
        /// </summary>
        public lvec3 gab => new lvec3(y, w, z);
        
        /// <summary>
        /// Returns lvec4.ywzx swizzling.
        /// </summary>
        public lvec4 ywzx => new lvec4(y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.gabr swizzling (equivalent to lvec4.ywzx).
        /// </summary>
        public lvec4 gabr => new lvec4(y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.ywzy swizzling.
        /// </summary>
        public lvec4 ywzy => new lvec4(y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.gabg swizzling (equivalent to lvec4.ywzy).
        /// </summary>
        public lvec4 gabg => new lvec4(y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.ywzz swizzling.
        /// </summary>
        public lvec4 ywzz => new lvec4(y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.gabb swizzling (equivalent to lvec4.ywzz).
        /// </summary>
        public lvec4 gabb => new lvec4(y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.ywzw swizzling.
        /// </summary>
        public lvec4 ywzw => new lvec4(y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.gaba swizzling (equivalent to lvec4.ywzw).
        /// </summary>
        public lvec4 gaba => new lvec4(y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.yww swizzling.
        /// </summary>
        public lvec3 yww => new lvec3(y, w, w);
        
        /// <summary>
        /// Returns lvec4.gaa swizzling (equivalent to lvec4.yww).
        /// </summary>
        public lvec3 gaa => new lvec3(y, w, w);
        
        /// <summary>
        /// Returns lvec4.ywwx swizzling.
        /// </summary>
        public lvec4 ywwx => new lvec4(y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.gaar swizzling (equivalent to lvec4.ywwx).
        /// </summary>
        public lvec4 gaar => new lvec4(y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.ywwy swizzling.
        /// </summary>
        public lvec4 ywwy => new lvec4(y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.gaag swizzling (equivalent to lvec4.ywwy).
        /// </summary>
        public lvec4 gaag => new lvec4(y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.ywwz swizzling.
        /// </summary>
        public lvec4 ywwz => new lvec4(y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.gaab swizzling (equivalent to lvec4.ywwz).
        /// </summary>
        public lvec4 gaab => new lvec4(y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.ywww swizzling.
        /// </summary>
        public lvec4 ywww => new lvec4(y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.gaaa swizzling (equivalent to lvec4.ywww).
        /// </summary>
        public lvec4 gaaa => new lvec4(y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.zx swizzling.
        /// </summary>
        public lvec2 zx => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec4.br swizzling (equivalent to lvec4.zx).
        /// </summary>
        public lvec2 br => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec4.zxx swizzling.
        /// </summary>
        public lvec3 zxx => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec4.brr swizzling (equivalent to lvec4.zxx).
        /// </summary>
        public lvec3 brr => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec4.zxxx swizzling.
        /// </summary>
        public lvec4 zxxx => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.brrr swizzling (equivalent to lvec4.zxxx).
        /// </summary>
        public lvec4 brrr => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.zxxy swizzling.
        /// </summary>
        public lvec4 zxxy => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.brrg swizzling (equivalent to lvec4.zxxy).
        /// </summary>
        public lvec4 brrg => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.zxxz swizzling.
        /// </summary>
        public lvec4 zxxz => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.brrb swizzling (equivalent to lvec4.zxxz).
        /// </summary>
        public lvec4 brrb => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.zxxw swizzling.
        /// </summary>
        public lvec4 zxxw => new lvec4(z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.brra swizzling (equivalent to lvec4.zxxw).
        /// </summary>
        public lvec4 brra => new lvec4(z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.zxy swizzling.
        /// </summary>
        public lvec3 zxy => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec4.brg swizzling (equivalent to lvec4.zxy).
        /// </summary>
        public lvec3 brg => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec4.zxyx swizzling.
        /// </summary>
        public lvec4 zxyx => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.brgr swizzling (equivalent to lvec4.zxyx).
        /// </summary>
        public lvec4 brgr => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.zxyy swizzling.
        /// </summary>
        public lvec4 zxyy => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.brgg swizzling (equivalent to lvec4.zxyy).
        /// </summary>
        public lvec4 brgg => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.zxyz swizzling.
        /// </summary>
        public lvec4 zxyz => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.brgb swizzling (equivalent to lvec4.zxyz).
        /// </summary>
        public lvec4 brgb => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.zxyw swizzling.
        /// </summary>
        public lvec4 zxyw => new lvec4(z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.brga swizzling (equivalent to lvec4.zxyw).
        /// </summary>
        public lvec4 brga => new lvec4(z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.zxz swizzling.
        /// </summary>
        public lvec3 zxz => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec4.brb swizzling (equivalent to lvec4.zxz).
        /// </summary>
        public lvec3 brb => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec4.zxzx swizzling.
        /// </summary>
        public lvec4 zxzx => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.brbr swizzling (equivalent to lvec4.zxzx).
        /// </summary>
        public lvec4 brbr => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.zxzy swizzling.
        /// </summary>
        public lvec4 zxzy => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.brbg swizzling (equivalent to lvec4.zxzy).
        /// </summary>
        public lvec4 brbg => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.zxzz swizzling.
        /// </summary>
        public lvec4 zxzz => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.brbb swizzling (equivalent to lvec4.zxzz).
        /// </summary>
        public lvec4 brbb => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.zxzw swizzling.
        /// </summary>
        public lvec4 zxzw => new lvec4(z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.brba swizzling (equivalent to lvec4.zxzw).
        /// </summary>
        public lvec4 brba => new lvec4(z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.zxw swizzling.
        /// </summary>
        public lvec3 zxw => new lvec3(z, x, w);
        
        /// <summary>
        /// Returns lvec4.bra swizzling (equivalent to lvec4.zxw).
        /// </summary>
        public lvec3 bra => new lvec3(z, x, w);
        
        /// <summary>
        /// Returns lvec4.zxwx swizzling.
        /// </summary>
        public lvec4 zxwx => new lvec4(z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.brar swizzling (equivalent to lvec4.zxwx).
        /// </summary>
        public lvec4 brar => new lvec4(z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.zxwy swizzling.
        /// </summary>
        public lvec4 zxwy => new lvec4(z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.brag swizzling (equivalent to lvec4.zxwy).
        /// </summary>
        public lvec4 brag => new lvec4(z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.zxwz swizzling.
        /// </summary>
        public lvec4 zxwz => new lvec4(z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.brab swizzling (equivalent to lvec4.zxwz).
        /// </summary>
        public lvec4 brab => new lvec4(z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.zxww swizzling.
        /// </summary>
        public lvec4 zxww => new lvec4(z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.braa swizzling (equivalent to lvec4.zxww).
        /// </summary>
        public lvec4 braa => new lvec4(z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.zy swizzling.
        /// </summary>
        public lvec2 zy => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec4.bg swizzling (equivalent to lvec4.zy).
        /// </summary>
        public lvec2 bg => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec4.zyx swizzling.
        /// </summary>
        public lvec3 zyx => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec4.bgr swizzling (equivalent to lvec4.zyx).
        /// </summary>
        public lvec3 bgr => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec4.zyxx swizzling.
        /// </summary>
        public lvec4 zyxx => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.bgrr swizzling (equivalent to lvec4.zyxx).
        /// </summary>
        public lvec4 bgrr => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.zyxy swizzling.
        /// </summary>
        public lvec4 zyxy => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.bgrg swizzling (equivalent to lvec4.zyxy).
        /// </summary>
        public lvec4 bgrg => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.zyxz swizzling.
        /// </summary>
        public lvec4 zyxz => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.bgrb swizzling (equivalent to lvec4.zyxz).
        /// </summary>
        public lvec4 bgrb => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.zyxw swizzling.
        /// </summary>
        public lvec4 zyxw => new lvec4(z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.bgra swizzling (equivalent to lvec4.zyxw).
        /// </summary>
        public lvec4 bgra => new lvec4(z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.zyy swizzling.
        /// </summary>
        public lvec3 zyy => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec4.bgg swizzling (equivalent to lvec4.zyy).
        /// </summary>
        public lvec3 bgg => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec4.zyyx swizzling.
        /// </summary>
        public lvec4 zyyx => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.bggr swizzling (equivalent to lvec4.zyyx).
        /// </summary>
        public lvec4 bggr => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.zyyy swizzling.
        /// </summary>
        public lvec4 zyyy => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.bggg swizzling (equivalent to lvec4.zyyy).
        /// </summary>
        public lvec4 bggg => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.zyyz swizzling.
        /// </summary>
        public lvec4 zyyz => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.bggb swizzling (equivalent to lvec4.zyyz).
        /// </summary>
        public lvec4 bggb => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.zyyw swizzling.
        /// </summary>
        public lvec4 zyyw => new lvec4(z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.bgga swizzling (equivalent to lvec4.zyyw).
        /// </summary>
        public lvec4 bgga => new lvec4(z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.zyz swizzling.
        /// </summary>
        public lvec3 zyz => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec4.bgb swizzling (equivalent to lvec4.zyz).
        /// </summary>
        public lvec3 bgb => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec4.zyzx swizzling.
        /// </summary>
        public lvec4 zyzx => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.bgbr swizzling (equivalent to lvec4.zyzx).
        /// </summary>
        public lvec4 bgbr => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.zyzy swizzling.
        /// </summary>
        public lvec4 zyzy => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.bgbg swizzling (equivalent to lvec4.zyzy).
        /// </summary>
        public lvec4 bgbg => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.zyzz swizzling.
        /// </summary>
        public lvec4 zyzz => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.bgbb swizzling (equivalent to lvec4.zyzz).
        /// </summary>
        public lvec4 bgbb => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.zyzw swizzling.
        /// </summary>
        public lvec4 zyzw => new lvec4(z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.bgba swizzling (equivalent to lvec4.zyzw).
        /// </summary>
        public lvec4 bgba => new lvec4(z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.zyw swizzling.
        /// </summary>
        public lvec3 zyw => new lvec3(z, y, w);
        
        /// <summary>
        /// Returns lvec4.bga swizzling (equivalent to lvec4.zyw).
        /// </summary>
        public lvec3 bga => new lvec3(z, y, w);
        
        /// <summary>
        /// Returns lvec4.zywx swizzling.
        /// </summary>
        public lvec4 zywx => new lvec4(z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.bgar swizzling (equivalent to lvec4.zywx).
        /// </summary>
        public lvec4 bgar => new lvec4(z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.zywy swizzling.
        /// </summary>
        public lvec4 zywy => new lvec4(z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.bgag swizzling (equivalent to lvec4.zywy).
        /// </summary>
        public lvec4 bgag => new lvec4(z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.zywz swizzling.
        /// </summary>
        public lvec4 zywz => new lvec4(z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.bgab swizzling (equivalent to lvec4.zywz).
        /// </summary>
        public lvec4 bgab => new lvec4(z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.zyww swizzling.
        /// </summary>
        public lvec4 zyww => new lvec4(z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.bgaa swizzling (equivalent to lvec4.zyww).
        /// </summary>
        public lvec4 bgaa => new lvec4(z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.zz swizzling.
        /// </summary>
        public lvec2 zz => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec4.bb swizzling (equivalent to lvec4.zz).
        /// </summary>
        public lvec2 bb => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec4.zzx swizzling.
        /// </summary>
        public lvec3 zzx => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec4.bbr swizzling (equivalent to lvec4.zzx).
        /// </summary>
        public lvec3 bbr => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec4.zzxx swizzling.
        /// </summary>
        public lvec4 zzxx => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.bbrr swizzling (equivalent to lvec4.zzxx).
        /// </summary>
        public lvec4 bbrr => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.zzxy swizzling.
        /// </summary>
        public lvec4 zzxy => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.bbrg swizzling (equivalent to lvec4.zzxy).
        /// </summary>
        public lvec4 bbrg => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.zzxz swizzling.
        /// </summary>
        public lvec4 zzxz => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.bbrb swizzling (equivalent to lvec4.zzxz).
        /// </summary>
        public lvec4 bbrb => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.zzxw swizzling.
        /// </summary>
        public lvec4 zzxw => new lvec4(z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.bbra swizzling (equivalent to lvec4.zzxw).
        /// </summary>
        public lvec4 bbra => new lvec4(z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.zzy swizzling.
        /// </summary>
        public lvec3 zzy => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec4.bbg swizzling (equivalent to lvec4.zzy).
        /// </summary>
        public lvec3 bbg => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec4.zzyx swizzling.
        /// </summary>
        public lvec4 zzyx => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.bbgr swizzling (equivalent to lvec4.zzyx).
        /// </summary>
        public lvec4 bbgr => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.zzyy swizzling.
        /// </summary>
        public lvec4 zzyy => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.bbgg swizzling (equivalent to lvec4.zzyy).
        /// </summary>
        public lvec4 bbgg => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.zzyz swizzling.
        /// </summary>
        public lvec4 zzyz => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.bbgb swizzling (equivalent to lvec4.zzyz).
        /// </summary>
        public lvec4 bbgb => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.zzyw swizzling.
        /// </summary>
        public lvec4 zzyw => new lvec4(z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.bbga swizzling (equivalent to lvec4.zzyw).
        /// </summary>
        public lvec4 bbga => new lvec4(z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.zzz swizzling.
        /// </summary>
        public lvec3 zzz => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec4.bbb swizzling (equivalent to lvec4.zzz).
        /// </summary>
        public lvec3 bbb => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec4.zzzx swizzling.
        /// </summary>
        public lvec4 zzzx => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.bbbr swizzling (equivalent to lvec4.zzzx).
        /// </summary>
        public lvec4 bbbr => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.zzzy swizzling.
        /// </summary>
        public lvec4 zzzy => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.bbbg swizzling (equivalent to lvec4.zzzy).
        /// </summary>
        public lvec4 bbbg => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.zzzz swizzling.
        /// </summary>
        public lvec4 zzzz => new lvec4(z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.bbbb swizzling (equivalent to lvec4.zzzz).
        /// </summary>
        public lvec4 bbbb => new lvec4(z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.zzzw swizzling.
        /// </summary>
        public lvec4 zzzw => new lvec4(z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.bbba swizzling (equivalent to lvec4.zzzw).
        /// </summary>
        public lvec4 bbba => new lvec4(z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.zzw swizzling.
        /// </summary>
        public lvec3 zzw => new lvec3(z, z, w);
        
        /// <summary>
        /// Returns lvec4.bba swizzling (equivalent to lvec4.zzw).
        /// </summary>
        public lvec3 bba => new lvec3(z, z, w);
        
        /// <summary>
        /// Returns lvec4.zzwx swizzling.
        /// </summary>
        public lvec4 zzwx => new lvec4(z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.bbar swizzling (equivalent to lvec4.zzwx).
        /// </summary>
        public lvec4 bbar => new lvec4(z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.zzwy swizzling.
        /// </summary>
        public lvec4 zzwy => new lvec4(z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.bbag swizzling (equivalent to lvec4.zzwy).
        /// </summary>
        public lvec4 bbag => new lvec4(z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.zzwz swizzling.
        /// </summary>
        public lvec4 zzwz => new lvec4(z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.bbab swizzling (equivalent to lvec4.zzwz).
        /// </summary>
        public lvec4 bbab => new lvec4(z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.zzww swizzling.
        /// </summary>
        public lvec4 zzww => new lvec4(z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.bbaa swizzling (equivalent to lvec4.zzww).
        /// </summary>
        public lvec4 bbaa => new lvec4(z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.zw swizzling.
        /// </summary>
        public lvec2 zw => new lvec2(z, w);
        
        /// <summary>
        /// Returns lvec4.ba swizzling (equivalent to lvec4.zw).
        /// </summary>
        public lvec2 ba => new lvec2(z, w);
        
        /// <summary>
        /// Returns lvec4.zwx swizzling.
        /// </summary>
        public lvec3 zwx => new lvec3(z, w, x);
        
        /// <summary>
        /// Returns lvec4.bar swizzling (equivalent to lvec4.zwx).
        /// </summary>
        public lvec3 bar => new lvec3(z, w, x);
        
        /// <summary>
        /// Returns lvec4.zwxx swizzling.
        /// </summary>
        public lvec4 zwxx => new lvec4(z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.barr swizzling (equivalent to lvec4.zwxx).
        /// </summary>
        public lvec4 barr => new lvec4(z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.zwxy swizzling.
        /// </summary>
        public lvec4 zwxy => new lvec4(z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.barg swizzling (equivalent to lvec4.zwxy).
        /// </summary>
        public lvec4 barg => new lvec4(z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.zwxz swizzling.
        /// </summary>
        public lvec4 zwxz => new lvec4(z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.barb swizzling (equivalent to lvec4.zwxz).
        /// </summary>
        public lvec4 barb => new lvec4(z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.zwxw swizzling.
        /// </summary>
        public lvec4 zwxw => new lvec4(z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.bara swizzling (equivalent to lvec4.zwxw).
        /// </summary>
        public lvec4 bara => new lvec4(z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.zwy swizzling.
        /// </summary>
        public lvec3 zwy => new lvec3(z, w, y);
        
        /// <summary>
        /// Returns lvec4.bag swizzling (equivalent to lvec4.zwy).
        /// </summary>
        public lvec3 bag => new lvec3(z, w, y);
        
        /// <summary>
        /// Returns lvec4.zwyx swizzling.
        /// </summary>
        public lvec4 zwyx => new lvec4(z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.bagr swizzling (equivalent to lvec4.zwyx).
        /// </summary>
        public lvec4 bagr => new lvec4(z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.zwyy swizzling.
        /// </summary>
        public lvec4 zwyy => new lvec4(z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.bagg swizzling (equivalent to lvec4.zwyy).
        /// </summary>
        public lvec4 bagg => new lvec4(z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.zwyz swizzling.
        /// </summary>
        public lvec4 zwyz => new lvec4(z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.bagb swizzling (equivalent to lvec4.zwyz).
        /// </summary>
        public lvec4 bagb => new lvec4(z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.zwyw swizzling.
        /// </summary>
        public lvec4 zwyw => new lvec4(z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.baga swizzling (equivalent to lvec4.zwyw).
        /// </summary>
        public lvec4 baga => new lvec4(z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.zwz swizzling.
        /// </summary>
        public lvec3 zwz => new lvec3(z, w, z);
        
        /// <summary>
        /// Returns lvec4.bab swizzling (equivalent to lvec4.zwz).
        /// </summary>
        public lvec3 bab => new lvec3(z, w, z);
        
        /// <summary>
        /// Returns lvec4.zwzx swizzling.
        /// </summary>
        public lvec4 zwzx => new lvec4(z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.babr swizzling (equivalent to lvec4.zwzx).
        /// </summary>
        public lvec4 babr => new lvec4(z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.zwzy swizzling.
        /// </summary>
        public lvec4 zwzy => new lvec4(z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.babg swizzling (equivalent to lvec4.zwzy).
        /// </summary>
        public lvec4 babg => new lvec4(z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.zwzz swizzling.
        /// </summary>
        public lvec4 zwzz => new lvec4(z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.babb swizzling (equivalent to lvec4.zwzz).
        /// </summary>
        public lvec4 babb => new lvec4(z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.zwzw swizzling.
        /// </summary>
        public lvec4 zwzw => new lvec4(z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.baba swizzling (equivalent to lvec4.zwzw).
        /// </summary>
        public lvec4 baba => new lvec4(z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.zww swizzling.
        /// </summary>
        public lvec3 zww => new lvec3(z, w, w);
        
        /// <summary>
        /// Returns lvec4.baa swizzling (equivalent to lvec4.zww).
        /// </summary>
        public lvec3 baa => new lvec3(z, w, w);
        
        /// <summary>
        /// Returns lvec4.zwwx swizzling.
        /// </summary>
        public lvec4 zwwx => new lvec4(z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.baar swizzling (equivalent to lvec4.zwwx).
        /// </summary>
        public lvec4 baar => new lvec4(z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.zwwy swizzling.
        /// </summary>
        public lvec4 zwwy => new lvec4(z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.baag swizzling (equivalent to lvec4.zwwy).
        /// </summary>
        public lvec4 baag => new lvec4(z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.zwwz swizzling.
        /// </summary>
        public lvec4 zwwz => new lvec4(z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.baab swizzling (equivalent to lvec4.zwwz).
        /// </summary>
        public lvec4 baab => new lvec4(z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.zwww swizzling.
        /// </summary>
        public lvec4 zwww => new lvec4(z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.baaa swizzling (equivalent to lvec4.zwww).
        /// </summary>
        public lvec4 baaa => new lvec4(z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.wx swizzling.
        /// </summary>
        public lvec2 wx => new lvec2(w, x);
        
        /// <summary>
        /// Returns lvec4.ar swizzling (equivalent to lvec4.wx).
        /// </summary>
        public lvec2 ar => new lvec2(w, x);
        
        /// <summary>
        /// Returns lvec4.wxx swizzling.
        /// </summary>
        public lvec3 wxx => new lvec3(w, x, x);
        
        /// <summary>
        /// Returns lvec4.arr swizzling (equivalent to lvec4.wxx).
        /// </summary>
        public lvec3 arr => new lvec3(w, x, x);
        
        /// <summary>
        /// Returns lvec4.wxxx swizzling.
        /// </summary>
        public lvec4 wxxx => new lvec4(w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.arrr swizzling (equivalent to lvec4.wxxx).
        /// </summary>
        public lvec4 arrr => new lvec4(w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.wxxy swizzling.
        /// </summary>
        public lvec4 wxxy => new lvec4(w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.arrg swizzling (equivalent to lvec4.wxxy).
        /// </summary>
        public lvec4 arrg => new lvec4(w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.wxxz swizzling.
        /// </summary>
        public lvec4 wxxz => new lvec4(w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.arrb swizzling (equivalent to lvec4.wxxz).
        /// </summary>
        public lvec4 arrb => new lvec4(w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.wxxw swizzling.
        /// </summary>
        public lvec4 wxxw => new lvec4(w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.arra swizzling (equivalent to lvec4.wxxw).
        /// </summary>
        public lvec4 arra => new lvec4(w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.wxy swizzling.
        /// </summary>
        public lvec3 wxy => new lvec3(w, x, y);
        
        /// <summary>
        /// Returns lvec4.arg swizzling (equivalent to lvec4.wxy).
        /// </summary>
        public lvec3 arg => new lvec3(w, x, y);
        
        /// <summary>
        /// Returns lvec4.wxyx swizzling.
        /// </summary>
        public lvec4 wxyx => new lvec4(w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.argr swizzling (equivalent to lvec4.wxyx).
        /// </summary>
        public lvec4 argr => new lvec4(w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.wxyy swizzling.
        /// </summary>
        public lvec4 wxyy => new lvec4(w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.argg swizzling (equivalent to lvec4.wxyy).
        /// </summary>
        public lvec4 argg => new lvec4(w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.wxyz swizzling.
        /// </summary>
        public lvec4 wxyz => new lvec4(w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.argb swizzling (equivalent to lvec4.wxyz).
        /// </summary>
        public lvec4 argb => new lvec4(w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.wxyw swizzling.
        /// </summary>
        public lvec4 wxyw => new lvec4(w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.arga swizzling (equivalent to lvec4.wxyw).
        /// </summary>
        public lvec4 arga => new lvec4(w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.wxz swizzling.
        /// </summary>
        public lvec3 wxz => new lvec3(w, x, z);
        
        /// <summary>
        /// Returns lvec4.arb swizzling (equivalent to lvec4.wxz).
        /// </summary>
        public lvec3 arb => new lvec3(w, x, z);
        
        /// <summary>
        /// Returns lvec4.wxzx swizzling.
        /// </summary>
        public lvec4 wxzx => new lvec4(w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.arbr swizzling (equivalent to lvec4.wxzx).
        /// </summary>
        public lvec4 arbr => new lvec4(w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.wxzy swizzling.
        /// </summary>
        public lvec4 wxzy => new lvec4(w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.arbg swizzling (equivalent to lvec4.wxzy).
        /// </summary>
        public lvec4 arbg => new lvec4(w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.wxzz swizzling.
        /// </summary>
        public lvec4 wxzz => new lvec4(w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.arbb swizzling (equivalent to lvec4.wxzz).
        /// </summary>
        public lvec4 arbb => new lvec4(w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.wxzw swizzling.
        /// </summary>
        public lvec4 wxzw => new lvec4(w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.arba swizzling (equivalent to lvec4.wxzw).
        /// </summary>
        public lvec4 arba => new lvec4(w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.wxw swizzling.
        /// </summary>
        public lvec3 wxw => new lvec3(w, x, w);
        
        /// <summary>
        /// Returns lvec4.ara swizzling (equivalent to lvec4.wxw).
        /// </summary>
        public lvec3 ara => new lvec3(w, x, w);
        
        /// <summary>
        /// Returns lvec4.wxwx swizzling.
        /// </summary>
        public lvec4 wxwx => new lvec4(w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.arar swizzling (equivalent to lvec4.wxwx).
        /// </summary>
        public lvec4 arar => new lvec4(w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.wxwy swizzling.
        /// </summary>
        public lvec4 wxwy => new lvec4(w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.arag swizzling (equivalent to lvec4.wxwy).
        /// </summary>
        public lvec4 arag => new lvec4(w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.wxwz swizzling.
        /// </summary>
        public lvec4 wxwz => new lvec4(w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.arab swizzling (equivalent to lvec4.wxwz).
        /// </summary>
        public lvec4 arab => new lvec4(w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.wxww swizzling.
        /// </summary>
        public lvec4 wxww => new lvec4(w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.araa swizzling (equivalent to lvec4.wxww).
        /// </summary>
        public lvec4 araa => new lvec4(w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.wy swizzling.
        /// </summary>
        public lvec2 wy => new lvec2(w, y);
        
        /// <summary>
        /// Returns lvec4.ag swizzling (equivalent to lvec4.wy).
        /// </summary>
        public lvec2 ag => new lvec2(w, y);
        
        /// <summary>
        /// Returns lvec4.wyx swizzling.
        /// </summary>
        public lvec3 wyx => new lvec3(w, y, x);
        
        /// <summary>
        /// Returns lvec4.agr swizzling (equivalent to lvec4.wyx).
        /// </summary>
        public lvec3 agr => new lvec3(w, y, x);
        
        /// <summary>
        /// Returns lvec4.wyxx swizzling.
        /// </summary>
        public lvec4 wyxx => new lvec4(w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.agrr swizzling (equivalent to lvec4.wyxx).
        /// </summary>
        public lvec4 agrr => new lvec4(w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.wyxy swizzling.
        /// </summary>
        public lvec4 wyxy => new lvec4(w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.agrg swizzling (equivalent to lvec4.wyxy).
        /// </summary>
        public lvec4 agrg => new lvec4(w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.wyxz swizzling.
        /// </summary>
        public lvec4 wyxz => new lvec4(w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.agrb swizzling (equivalent to lvec4.wyxz).
        /// </summary>
        public lvec4 agrb => new lvec4(w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.wyxw swizzling.
        /// </summary>
        public lvec4 wyxw => new lvec4(w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.agra swizzling (equivalent to lvec4.wyxw).
        /// </summary>
        public lvec4 agra => new lvec4(w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.wyy swizzling.
        /// </summary>
        public lvec3 wyy => new lvec3(w, y, y);
        
        /// <summary>
        /// Returns lvec4.agg swizzling (equivalent to lvec4.wyy).
        /// </summary>
        public lvec3 agg => new lvec3(w, y, y);
        
        /// <summary>
        /// Returns lvec4.wyyx swizzling.
        /// </summary>
        public lvec4 wyyx => new lvec4(w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.aggr swizzling (equivalent to lvec4.wyyx).
        /// </summary>
        public lvec4 aggr => new lvec4(w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.wyyy swizzling.
        /// </summary>
        public lvec4 wyyy => new lvec4(w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.aggg swizzling (equivalent to lvec4.wyyy).
        /// </summary>
        public lvec4 aggg => new lvec4(w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.wyyz swizzling.
        /// </summary>
        public lvec4 wyyz => new lvec4(w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.aggb swizzling (equivalent to lvec4.wyyz).
        /// </summary>
        public lvec4 aggb => new lvec4(w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.wyyw swizzling.
        /// </summary>
        public lvec4 wyyw => new lvec4(w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.agga swizzling (equivalent to lvec4.wyyw).
        /// </summary>
        public lvec4 agga => new lvec4(w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.wyz swizzling.
        /// </summary>
        public lvec3 wyz => new lvec3(w, y, z);
        
        /// <summary>
        /// Returns lvec4.agb swizzling (equivalent to lvec4.wyz).
        /// </summary>
        public lvec3 agb => new lvec3(w, y, z);
        
        /// <summary>
        /// Returns lvec4.wyzx swizzling.
        /// </summary>
        public lvec4 wyzx => new lvec4(w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.agbr swizzling (equivalent to lvec4.wyzx).
        /// </summary>
        public lvec4 agbr => new lvec4(w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.wyzy swizzling.
        /// </summary>
        public lvec4 wyzy => new lvec4(w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.agbg swizzling (equivalent to lvec4.wyzy).
        /// </summary>
        public lvec4 agbg => new lvec4(w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.wyzz swizzling.
        /// </summary>
        public lvec4 wyzz => new lvec4(w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.agbb swizzling (equivalent to lvec4.wyzz).
        /// </summary>
        public lvec4 agbb => new lvec4(w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.wyzw swizzling.
        /// </summary>
        public lvec4 wyzw => new lvec4(w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.agba swizzling (equivalent to lvec4.wyzw).
        /// </summary>
        public lvec4 agba => new lvec4(w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.wyw swizzling.
        /// </summary>
        public lvec3 wyw => new lvec3(w, y, w);
        
        /// <summary>
        /// Returns lvec4.aga swizzling (equivalent to lvec4.wyw).
        /// </summary>
        public lvec3 aga => new lvec3(w, y, w);
        
        /// <summary>
        /// Returns lvec4.wywx swizzling.
        /// </summary>
        public lvec4 wywx => new lvec4(w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.agar swizzling (equivalent to lvec4.wywx).
        /// </summary>
        public lvec4 agar => new lvec4(w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.wywy swizzling.
        /// </summary>
        public lvec4 wywy => new lvec4(w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.agag swizzling (equivalent to lvec4.wywy).
        /// </summary>
        public lvec4 agag => new lvec4(w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.wywz swizzling.
        /// </summary>
        public lvec4 wywz => new lvec4(w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.agab swizzling (equivalent to lvec4.wywz).
        /// </summary>
        public lvec4 agab => new lvec4(w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.wyww swizzling.
        /// </summary>
        public lvec4 wyww => new lvec4(w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.agaa swizzling (equivalent to lvec4.wyww).
        /// </summary>
        public lvec4 agaa => new lvec4(w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.wz swizzling.
        /// </summary>
        public lvec2 wz => new lvec2(w, z);
        
        /// <summary>
        /// Returns lvec4.ab swizzling (equivalent to lvec4.wz).
        /// </summary>
        public lvec2 ab => new lvec2(w, z);
        
        /// <summary>
        /// Returns lvec4.wzx swizzling.
        /// </summary>
        public lvec3 wzx => new lvec3(w, z, x);
        
        /// <summary>
        /// Returns lvec4.abr swizzling (equivalent to lvec4.wzx).
        /// </summary>
        public lvec3 abr => new lvec3(w, z, x);
        
        /// <summary>
        /// Returns lvec4.wzxx swizzling.
        /// </summary>
        public lvec4 wzxx => new lvec4(w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.abrr swizzling (equivalent to lvec4.wzxx).
        /// </summary>
        public lvec4 abrr => new lvec4(w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.wzxy swizzling.
        /// </summary>
        public lvec4 wzxy => new lvec4(w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.abrg swizzling (equivalent to lvec4.wzxy).
        /// </summary>
        public lvec4 abrg => new lvec4(w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.wzxz swizzling.
        /// </summary>
        public lvec4 wzxz => new lvec4(w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.abrb swizzling (equivalent to lvec4.wzxz).
        /// </summary>
        public lvec4 abrb => new lvec4(w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.wzxw swizzling.
        /// </summary>
        public lvec4 wzxw => new lvec4(w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.abra swizzling (equivalent to lvec4.wzxw).
        /// </summary>
        public lvec4 abra => new lvec4(w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.wzy swizzling.
        /// </summary>
        public lvec3 wzy => new lvec3(w, z, y);
        
        /// <summary>
        /// Returns lvec4.abg swizzling (equivalent to lvec4.wzy).
        /// </summary>
        public lvec3 abg => new lvec3(w, z, y);
        
        /// <summary>
        /// Returns lvec4.wzyx swizzling.
        /// </summary>
        public lvec4 wzyx => new lvec4(w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.abgr swizzling (equivalent to lvec4.wzyx).
        /// </summary>
        public lvec4 abgr => new lvec4(w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.wzyy swizzling.
        /// </summary>
        public lvec4 wzyy => new lvec4(w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.abgg swizzling (equivalent to lvec4.wzyy).
        /// </summary>
        public lvec4 abgg => new lvec4(w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.wzyz swizzling.
        /// </summary>
        public lvec4 wzyz => new lvec4(w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.abgb swizzling (equivalent to lvec4.wzyz).
        /// </summary>
        public lvec4 abgb => new lvec4(w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.wzyw swizzling.
        /// </summary>
        public lvec4 wzyw => new lvec4(w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.abga swizzling (equivalent to lvec4.wzyw).
        /// </summary>
        public lvec4 abga => new lvec4(w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.wzz swizzling.
        /// </summary>
        public lvec3 wzz => new lvec3(w, z, z);
        
        /// <summary>
        /// Returns lvec4.abb swizzling (equivalent to lvec4.wzz).
        /// </summary>
        public lvec3 abb => new lvec3(w, z, z);
        
        /// <summary>
        /// Returns lvec4.wzzx swizzling.
        /// </summary>
        public lvec4 wzzx => new lvec4(w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.abbr swizzling (equivalent to lvec4.wzzx).
        /// </summary>
        public lvec4 abbr => new lvec4(w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.wzzy swizzling.
        /// </summary>
        public lvec4 wzzy => new lvec4(w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.abbg swizzling (equivalent to lvec4.wzzy).
        /// </summary>
        public lvec4 abbg => new lvec4(w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.wzzz swizzling.
        /// </summary>
        public lvec4 wzzz => new lvec4(w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.abbb swizzling (equivalent to lvec4.wzzz).
        /// </summary>
        public lvec4 abbb => new lvec4(w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.wzzw swizzling.
        /// </summary>
        public lvec4 wzzw => new lvec4(w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.abba swizzling (equivalent to lvec4.wzzw).
        /// </summary>
        public lvec4 abba => new lvec4(w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.wzw swizzling.
        /// </summary>
        public lvec3 wzw => new lvec3(w, z, w);
        
        /// <summary>
        /// Returns lvec4.aba swizzling (equivalent to lvec4.wzw).
        /// </summary>
        public lvec3 aba => new lvec3(w, z, w);
        
        /// <summary>
        /// Returns lvec4.wzwx swizzling.
        /// </summary>
        public lvec4 wzwx => new lvec4(w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.abar swizzling (equivalent to lvec4.wzwx).
        /// </summary>
        public lvec4 abar => new lvec4(w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.wzwy swizzling.
        /// </summary>
        public lvec4 wzwy => new lvec4(w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.abag swizzling (equivalent to lvec4.wzwy).
        /// </summary>
        public lvec4 abag => new lvec4(w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.wzwz swizzling.
        /// </summary>
        public lvec4 wzwz => new lvec4(w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.abab swizzling (equivalent to lvec4.wzwz).
        /// </summary>
        public lvec4 abab => new lvec4(w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.wzww swizzling.
        /// </summary>
        public lvec4 wzww => new lvec4(w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.abaa swizzling (equivalent to lvec4.wzww).
        /// </summary>
        public lvec4 abaa => new lvec4(w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.ww swizzling.
        /// </summary>
        public lvec2 ww => new lvec2(w, w);
        
        /// <summary>
        /// Returns lvec4.aa swizzling (equivalent to lvec4.ww).
        /// </summary>
        public lvec2 aa => new lvec2(w, w);
        
        /// <summary>
        /// Returns lvec4.wwx swizzling.
        /// </summary>
        public lvec3 wwx => new lvec3(w, w, x);
        
        /// <summary>
        /// Returns lvec4.aar swizzling (equivalent to lvec4.wwx).
        /// </summary>
        public lvec3 aar => new lvec3(w, w, x);
        
        /// <summary>
        /// Returns lvec4.wwxx swizzling.
        /// </summary>
        public lvec4 wwxx => new lvec4(w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.aarr swizzling (equivalent to lvec4.wwxx).
        /// </summary>
        public lvec4 aarr => new lvec4(w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.wwxy swizzling.
        /// </summary>
        public lvec4 wwxy => new lvec4(w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.aarg swizzling (equivalent to lvec4.wwxy).
        /// </summary>
        public lvec4 aarg => new lvec4(w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.wwxz swizzling.
        /// </summary>
        public lvec4 wwxz => new lvec4(w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.aarb swizzling (equivalent to lvec4.wwxz).
        /// </summary>
        public lvec4 aarb => new lvec4(w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.wwxw swizzling.
        /// </summary>
        public lvec4 wwxw => new lvec4(w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.aara swizzling (equivalent to lvec4.wwxw).
        /// </summary>
        public lvec4 aara => new lvec4(w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.wwy swizzling.
        /// </summary>
        public lvec3 wwy => new lvec3(w, w, y);
        
        /// <summary>
        /// Returns lvec4.aag swizzling (equivalent to lvec4.wwy).
        /// </summary>
        public lvec3 aag => new lvec3(w, w, y);
        
        /// <summary>
        /// Returns lvec4.wwyx swizzling.
        /// </summary>
        public lvec4 wwyx => new lvec4(w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.aagr swizzling (equivalent to lvec4.wwyx).
        /// </summary>
        public lvec4 aagr => new lvec4(w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.wwyy swizzling.
        /// </summary>
        public lvec4 wwyy => new lvec4(w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.aagg swizzling (equivalent to lvec4.wwyy).
        /// </summary>
        public lvec4 aagg => new lvec4(w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.wwyz swizzling.
        /// </summary>
        public lvec4 wwyz => new lvec4(w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.aagb swizzling (equivalent to lvec4.wwyz).
        /// </summary>
        public lvec4 aagb => new lvec4(w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.wwyw swizzling.
        /// </summary>
        public lvec4 wwyw => new lvec4(w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.aaga swizzling (equivalent to lvec4.wwyw).
        /// </summary>
        public lvec4 aaga => new lvec4(w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.wwz swizzling.
        /// </summary>
        public lvec3 wwz => new lvec3(w, w, z);
        
        /// <summary>
        /// Returns lvec4.aab swizzling (equivalent to lvec4.wwz).
        /// </summary>
        public lvec3 aab => new lvec3(w, w, z);
        
        /// <summary>
        /// Returns lvec4.wwzx swizzling.
        /// </summary>
        public lvec4 wwzx => new lvec4(w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.aabr swizzling (equivalent to lvec4.wwzx).
        /// </summary>
        public lvec4 aabr => new lvec4(w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.wwzy swizzling.
        /// </summary>
        public lvec4 wwzy => new lvec4(w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.aabg swizzling (equivalent to lvec4.wwzy).
        /// </summary>
        public lvec4 aabg => new lvec4(w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.wwzz swizzling.
        /// </summary>
        public lvec4 wwzz => new lvec4(w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.aabb swizzling (equivalent to lvec4.wwzz).
        /// </summary>
        public lvec4 aabb => new lvec4(w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.wwzw swizzling.
        /// </summary>
        public lvec4 wwzw => new lvec4(w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.aaba swizzling (equivalent to lvec4.wwzw).
        /// </summary>
        public lvec4 aaba => new lvec4(w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.www swizzling.
        /// </summary>
        public lvec3 www => new lvec3(w, w, w);
        
        /// <summary>
        /// Returns lvec4.aaa swizzling (equivalent to lvec4.www).
        /// </summary>
        public lvec3 aaa => new lvec3(w, w, w);
        
        /// <summary>
        /// Returns lvec4.wwwx swizzling.
        /// </summary>
        public lvec4 wwwx => new lvec4(w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.aaar swizzling (equivalent to lvec4.wwwx).
        /// </summary>
        public lvec4 aaar => new lvec4(w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.wwwy swizzling.
        /// </summary>
        public lvec4 wwwy => new lvec4(w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.aaag swizzling (equivalent to lvec4.wwwy).
        /// </summary>
        public lvec4 aaag => new lvec4(w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.wwwz swizzling.
        /// </summary>
        public lvec4 wwwz => new lvec4(w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.aaab swizzling (equivalent to lvec4.wwwz).
        /// </summary>
        public lvec4 aaab => new lvec4(w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.wwww swizzling.
        /// </summary>
        public lvec4 wwww => new lvec4(w, w, w, w);
        
        /// <summary>
        /// Returns lvec4.aaaa swizzling (equivalent to lvec4.wwww).
        /// </summary>
        public lvec4 aaaa => new lvec4(w, w, w, w);

        #endregion

    }
}
