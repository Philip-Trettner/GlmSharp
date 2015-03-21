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
    /// Temporary vector of type int with 4 components, used for implementing swizzling for ivec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_ivec4
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
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly int w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_ivec4.
        /// </summary>
        internal swizzle_ivec4(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns ivec4.xx swizzling.
        /// </summary>
        public ivec2 xx => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec4.rr swizzling (equivalent to ivec4.xx).
        /// </summary>
        public ivec2 rr => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec4.xxx swizzling.
        /// </summary>
        public ivec3 xxx => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec4.rrr swizzling (equivalent to ivec4.xxx).
        /// </summary>
        public ivec3 rrr => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec4.xxxx swizzling.
        /// </summary>
        public ivec4 xxxx => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.rrrr swizzling (equivalent to ivec4.xxxx).
        /// </summary>
        public ivec4 rrrr => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec4.xxxy swizzling.
        /// </summary>
        public ivec4 xxxy => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.rrrg swizzling (equivalent to ivec4.xxxy).
        /// </summary>
        public ivec4 rrrg => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec4.xxxz swizzling.
        /// </summary>
        public ivec4 xxxz => new ivec4(x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.rrrb swizzling (equivalent to ivec4.xxxz).
        /// </summary>
        public ivec4 rrrb => new ivec4(x, x, x, z);
        
        /// <summary>
        /// Returns ivec4.xxxw swizzling.
        /// </summary>
        public ivec4 xxxw => new ivec4(x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.rrra swizzling (equivalent to ivec4.xxxw).
        /// </summary>
        public ivec4 rrra => new ivec4(x, x, x, w);
        
        /// <summary>
        /// Returns ivec4.xxy swizzling.
        /// </summary>
        public ivec3 xxy => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec4.rrg swizzling (equivalent to ivec4.xxy).
        /// </summary>
        public ivec3 rrg => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec4.xxyx swizzling.
        /// </summary>
        public ivec4 xxyx => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.rrgr swizzling (equivalent to ivec4.xxyx).
        /// </summary>
        public ivec4 rrgr => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec4.xxyy swizzling.
        /// </summary>
        public ivec4 xxyy => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.rrgg swizzling (equivalent to ivec4.xxyy).
        /// </summary>
        public ivec4 rrgg => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec4.xxyz swizzling.
        /// </summary>
        public ivec4 xxyz => new ivec4(x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.rrgb swizzling (equivalent to ivec4.xxyz).
        /// </summary>
        public ivec4 rrgb => new ivec4(x, x, y, z);
        
        /// <summary>
        /// Returns ivec4.xxyw swizzling.
        /// </summary>
        public ivec4 xxyw => new ivec4(x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.rrga swizzling (equivalent to ivec4.xxyw).
        /// </summary>
        public ivec4 rrga => new ivec4(x, x, y, w);
        
        /// <summary>
        /// Returns ivec4.xxz swizzling.
        /// </summary>
        public ivec3 xxz => new ivec3(x, x, z);
        
        /// <summary>
        /// Returns ivec4.rrb swizzling (equivalent to ivec4.xxz).
        /// </summary>
        public ivec3 rrb => new ivec3(x, x, z);
        
        /// <summary>
        /// Returns ivec4.xxzx swizzling.
        /// </summary>
        public ivec4 xxzx => new ivec4(x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.rrbr swizzling (equivalent to ivec4.xxzx).
        /// </summary>
        public ivec4 rrbr => new ivec4(x, x, z, x);
        
        /// <summary>
        /// Returns ivec4.xxzy swizzling.
        /// </summary>
        public ivec4 xxzy => new ivec4(x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.rrbg swizzling (equivalent to ivec4.xxzy).
        /// </summary>
        public ivec4 rrbg => new ivec4(x, x, z, y);
        
        /// <summary>
        /// Returns ivec4.xxzz swizzling.
        /// </summary>
        public ivec4 xxzz => new ivec4(x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.rrbb swizzling (equivalent to ivec4.xxzz).
        /// </summary>
        public ivec4 rrbb => new ivec4(x, x, z, z);
        
        /// <summary>
        /// Returns ivec4.xxzw swizzling.
        /// </summary>
        public ivec4 xxzw => new ivec4(x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.rrba swizzling (equivalent to ivec4.xxzw).
        /// </summary>
        public ivec4 rrba => new ivec4(x, x, z, w);
        
        /// <summary>
        /// Returns ivec4.xxw swizzling.
        /// </summary>
        public ivec3 xxw => new ivec3(x, x, w);
        
        /// <summary>
        /// Returns ivec4.rra swizzling (equivalent to ivec4.xxw).
        /// </summary>
        public ivec3 rra => new ivec3(x, x, w);
        
        /// <summary>
        /// Returns ivec4.xxwx swizzling.
        /// </summary>
        public ivec4 xxwx => new ivec4(x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.rrar swizzling (equivalent to ivec4.xxwx).
        /// </summary>
        public ivec4 rrar => new ivec4(x, x, w, x);
        
        /// <summary>
        /// Returns ivec4.xxwy swizzling.
        /// </summary>
        public ivec4 xxwy => new ivec4(x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.rrag swizzling (equivalent to ivec4.xxwy).
        /// </summary>
        public ivec4 rrag => new ivec4(x, x, w, y);
        
        /// <summary>
        /// Returns ivec4.xxwz swizzling.
        /// </summary>
        public ivec4 xxwz => new ivec4(x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.rrab swizzling (equivalent to ivec4.xxwz).
        /// </summary>
        public ivec4 rrab => new ivec4(x, x, w, z);
        
        /// <summary>
        /// Returns ivec4.xxww swizzling.
        /// </summary>
        public ivec4 xxww => new ivec4(x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.rraa swizzling (equivalent to ivec4.xxww).
        /// </summary>
        public ivec4 rraa => new ivec4(x, x, w, w);
        
        /// <summary>
        /// Returns ivec4.xy swizzling.
        /// </summary>
        public ivec2 xy => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec4.rg swizzling (equivalent to ivec4.xy).
        /// </summary>
        public ivec2 rg => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec4.xyx swizzling.
        /// </summary>
        public ivec3 xyx => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec4.rgr swizzling (equivalent to ivec4.xyx).
        /// </summary>
        public ivec3 rgr => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec4.xyxx swizzling.
        /// </summary>
        public ivec4 xyxx => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.rgrr swizzling (equivalent to ivec4.xyxx).
        /// </summary>
        public ivec4 rgrr => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec4.xyxy swizzling.
        /// </summary>
        public ivec4 xyxy => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.rgrg swizzling (equivalent to ivec4.xyxy).
        /// </summary>
        public ivec4 rgrg => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec4.xyxz swizzling.
        /// </summary>
        public ivec4 xyxz => new ivec4(x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.rgrb swizzling (equivalent to ivec4.xyxz).
        /// </summary>
        public ivec4 rgrb => new ivec4(x, y, x, z);
        
        /// <summary>
        /// Returns ivec4.xyxw swizzling.
        /// </summary>
        public ivec4 xyxw => new ivec4(x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.rgra swizzling (equivalent to ivec4.xyxw).
        /// </summary>
        public ivec4 rgra => new ivec4(x, y, x, w);
        
        /// <summary>
        /// Returns ivec4.xyy swizzling.
        /// </summary>
        public ivec3 xyy => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec4.rgg swizzling (equivalent to ivec4.xyy).
        /// </summary>
        public ivec3 rgg => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec4.xyyx swizzling.
        /// </summary>
        public ivec4 xyyx => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.rggr swizzling (equivalent to ivec4.xyyx).
        /// </summary>
        public ivec4 rggr => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec4.xyyy swizzling.
        /// </summary>
        public ivec4 xyyy => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.rggg swizzling (equivalent to ivec4.xyyy).
        /// </summary>
        public ivec4 rggg => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec4.xyyz swizzling.
        /// </summary>
        public ivec4 xyyz => new ivec4(x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.rggb swizzling (equivalent to ivec4.xyyz).
        /// </summary>
        public ivec4 rggb => new ivec4(x, y, y, z);
        
        /// <summary>
        /// Returns ivec4.xyyw swizzling.
        /// </summary>
        public ivec4 xyyw => new ivec4(x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.rgga swizzling (equivalent to ivec4.xyyw).
        /// </summary>
        public ivec4 rgga => new ivec4(x, y, y, w);
        
        /// <summary>
        /// Returns ivec4.xyz swizzling.
        /// </summary>
        public ivec3 xyz => new ivec3(x, y, z);
        
        /// <summary>
        /// Returns ivec4.rgb swizzling (equivalent to ivec4.xyz).
        /// </summary>
        public ivec3 rgb => new ivec3(x, y, z);
        
        /// <summary>
        /// Returns ivec4.xyzx swizzling.
        /// </summary>
        public ivec4 xyzx => new ivec4(x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.rgbr swizzling (equivalent to ivec4.xyzx).
        /// </summary>
        public ivec4 rgbr => new ivec4(x, y, z, x);
        
        /// <summary>
        /// Returns ivec4.xyzy swizzling.
        /// </summary>
        public ivec4 xyzy => new ivec4(x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.rgbg swizzling (equivalent to ivec4.xyzy).
        /// </summary>
        public ivec4 rgbg => new ivec4(x, y, z, y);
        
        /// <summary>
        /// Returns ivec4.xyzz swizzling.
        /// </summary>
        public ivec4 xyzz => new ivec4(x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.rgbb swizzling (equivalent to ivec4.xyzz).
        /// </summary>
        public ivec4 rgbb => new ivec4(x, y, z, z);
        
        /// <summary>
        /// Returns ivec4.xyzw swizzling.
        /// </summary>
        public ivec4 xyzw => new ivec4(x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.rgba swizzling (equivalent to ivec4.xyzw).
        /// </summary>
        public ivec4 rgba => new ivec4(x, y, z, w);
        
        /// <summary>
        /// Returns ivec4.xyw swizzling.
        /// </summary>
        public ivec3 xyw => new ivec3(x, y, w);
        
        /// <summary>
        /// Returns ivec4.rga swizzling (equivalent to ivec4.xyw).
        /// </summary>
        public ivec3 rga => new ivec3(x, y, w);
        
        /// <summary>
        /// Returns ivec4.xywx swizzling.
        /// </summary>
        public ivec4 xywx => new ivec4(x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.rgar swizzling (equivalent to ivec4.xywx).
        /// </summary>
        public ivec4 rgar => new ivec4(x, y, w, x);
        
        /// <summary>
        /// Returns ivec4.xywy swizzling.
        /// </summary>
        public ivec4 xywy => new ivec4(x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.rgag swizzling (equivalent to ivec4.xywy).
        /// </summary>
        public ivec4 rgag => new ivec4(x, y, w, y);
        
        /// <summary>
        /// Returns ivec4.xywz swizzling.
        /// </summary>
        public ivec4 xywz => new ivec4(x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.rgab swizzling (equivalent to ivec4.xywz).
        /// </summary>
        public ivec4 rgab => new ivec4(x, y, w, z);
        
        /// <summary>
        /// Returns ivec4.xyww swizzling.
        /// </summary>
        public ivec4 xyww => new ivec4(x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.rgaa swizzling (equivalent to ivec4.xyww).
        /// </summary>
        public ivec4 rgaa => new ivec4(x, y, w, w);
        
        /// <summary>
        /// Returns ivec4.xz swizzling.
        /// </summary>
        public ivec2 xz => new ivec2(x, z);
        
        /// <summary>
        /// Returns ivec4.rb swizzling (equivalent to ivec4.xz).
        /// </summary>
        public ivec2 rb => new ivec2(x, z);
        
        /// <summary>
        /// Returns ivec4.xzx swizzling.
        /// </summary>
        public ivec3 xzx => new ivec3(x, z, x);
        
        /// <summary>
        /// Returns ivec4.rbr swizzling (equivalent to ivec4.xzx).
        /// </summary>
        public ivec3 rbr => new ivec3(x, z, x);
        
        /// <summary>
        /// Returns ivec4.xzxx swizzling.
        /// </summary>
        public ivec4 xzxx => new ivec4(x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.rbrr swizzling (equivalent to ivec4.xzxx).
        /// </summary>
        public ivec4 rbrr => new ivec4(x, z, x, x);
        
        /// <summary>
        /// Returns ivec4.xzxy swizzling.
        /// </summary>
        public ivec4 xzxy => new ivec4(x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.rbrg swizzling (equivalent to ivec4.xzxy).
        /// </summary>
        public ivec4 rbrg => new ivec4(x, z, x, y);
        
        /// <summary>
        /// Returns ivec4.xzxz swizzling.
        /// </summary>
        public ivec4 xzxz => new ivec4(x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.rbrb swizzling (equivalent to ivec4.xzxz).
        /// </summary>
        public ivec4 rbrb => new ivec4(x, z, x, z);
        
        /// <summary>
        /// Returns ivec4.xzxw swizzling.
        /// </summary>
        public ivec4 xzxw => new ivec4(x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.rbra swizzling (equivalent to ivec4.xzxw).
        /// </summary>
        public ivec4 rbra => new ivec4(x, z, x, w);
        
        /// <summary>
        /// Returns ivec4.xzy swizzling.
        /// </summary>
        public ivec3 xzy => new ivec3(x, z, y);
        
        /// <summary>
        /// Returns ivec4.rbg swizzling (equivalent to ivec4.xzy).
        /// </summary>
        public ivec3 rbg => new ivec3(x, z, y);
        
        /// <summary>
        /// Returns ivec4.xzyx swizzling.
        /// </summary>
        public ivec4 xzyx => new ivec4(x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.rbgr swizzling (equivalent to ivec4.xzyx).
        /// </summary>
        public ivec4 rbgr => new ivec4(x, z, y, x);
        
        /// <summary>
        /// Returns ivec4.xzyy swizzling.
        /// </summary>
        public ivec4 xzyy => new ivec4(x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.rbgg swizzling (equivalent to ivec4.xzyy).
        /// </summary>
        public ivec4 rbgg => new ivec4(x, z, y, y);
        
        /// <summary>
        /// Returns ivec4.xzyz swizzling.
        /// </summary>
        public ivec4 xzyz => new ivec4(x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.rbgb swizzling (equivalent to ivec4.xzyz).
        /// </summary>
        public ivec4 rbgb => new ivec4(x, z, y, z);
        
        /// <summary>
        /// Returns ivec4.xzyw swizzling.
        /// </summary>
        public ivec4 xzyw => new ivec4(x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.rbga swizzling (equivalent to ivec4.xzyw).
        /// </summary>
        public ivec4 rbga => new ivec4(x, z, y, w);
        
        /// <summary>
        /// Returns ivec4.xzz swizzling.
        /// </summary>
        public ivec3 xzz => new ivec3(x, z, z);
        
        /// <summary>
        /// Returns ivec4.rbb swizzling (equivalent to ivec4.xzz).
        /// </summary>
        public ivec3 rbb => new ivec3(x, z, z);
        
        /// <summary>
        /// Returns ivec4.xzzx swizzling.
        /// </summary>
        public ivec4 xzzx => new ivec4(x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.rbbr swizzling (equivalent to ivec4.xzzx).
        /// </summary>
        public ivec4 rbbr => new ivec4(x, z, z, x);
        
        /// <summary>
        /// Returns ivec4.xzzy swizzling.
        /// </summary>
        public ivec4 xzzy => new ivec4(x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.rbbg swizzling (equivalent to ivec4.xzzy).
        /// </summary>
        public ivec4 rbbg => new ivec4(x, z, z, y);
        
        /// <summary>
        /// Returns ivec4.xzzz swizzling.
        /// </summary>
        public ivec4 xzzz => new ivec4(x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.rbbb swizzling (equivalent to ivec4.xzzz).
        /// </summary>
        public ivec4 rbbb => new ivec4(x, z, z, z);
        
        /// <summary>
        /// Returns ivec4.xzzw swizzling.
        /// </summary>
        public ivec4 xzzw => new ivec4(x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.rbba swizzling (equivalent to ivec4.xzzw).
        /// </summary>
        public ivec4 rbba => new ivec4(x, z, z, w);
        
        /// <summary>
        /// Returns ivec4.xzw swizzling.
        /// </summary>
        public ivec3 xzw => new ivec3(x, z, w);
        
        /// <summary>
        /// Returns ivec4.rba swizzling (equivalent to ivec4.xzw).
        /// </summary>
        public ivec3 rba => new ivec3(x, z, w);
        
        /// <summary>
        /// Returns ivec4.xzwx swizzling.
        /// </summary>
        public ivec4 xzwx => new ivec4(x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.rbar swizzling (equivalent to ivec4.xzwx).
        /// </summary>
        public ivec4 rbar => new ivec4(x, z, w, x);
        
        /// <summary>
        /// Returns ivec4.xzwy swizzling.
        /// </summary>
        public ivec4 xzwy => new ivec4(x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.rbag swizzling (equivalent to ivec4.xzwy).
        /// </summary>
        public ivec4 rbag => new ivec4(x, z, w, y);
        
        /// <summary>
        /// Returns ivec4.xzwz swizzling.
        /// </summary>
        public ivec4 xzwz => new ivec4(x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.rbab swizzling (equivalent to ivec4.xzwz).
        /// </summary>
        public ivec4 rbab => new ivec4(x, z, w, z);
        
        /// <summary>
        /// Returns ivec4.xzww swizzling.
        /// </summary>
        public ivec4 xzww => new ivec4(x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.rbaa swizzling (equivalent to ivec4.xzww).
        /// </summary>
        public ivec4 rbaa => new ivec4(x, z, w, w);
        
        /// <summary>
        /// Returns ivec4.xw swizzling.
        /// </summary>
        public ivec2 xw => new ivec2(x, w);
        
        /// <summary>
        /// Returns ivec4.ra swizzling (equivalent to ivec4.xw).
        /// </summary>
        public ivec2 ra => new ivec2(x, w);
        
        /// <summary>
        /// Returns ivec4.xwx swizzling.
        /// </summary>
        public ivec3 xwx => new ivec3(x, w, x);
        
        /// <summary>
        /// Returns ivec4.rar swizzling (equivalent to ivec4.xwx).
        /// </summary>
        public ivec3 rar => new ivec3(x, w, x);
        
        /// <summary>
        /// Returns ivec4.xwxx swizzling.
        /// </summary>
        public ivec4 xwxx => new ivec4(x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.rarr swizzling (equivalent to ivec4.xwxx).
        /// </summary>
        public ivec4 rarr => new ivec4(x, w, x, x);
        
        /// <summary>
        /// Returns ivec4.xwxy swizzling.
        /// </summary>
        public ivec4 xwxy => new ivec4(x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.rarg swizzling (equivalent to ivec4.xwxy).
        /// </summary>
        public ivec4 rarg => new ivec4(x, w, x, y);
        
        /// <summary>
        /// Returns ivec4.xwxz swizzling.
        /// </summary>
        public ivec4 xwxz => new ivec4(x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.rarb swizzling (equivalent to ivec4.xwxz).
        /// </summary>
        public ivec4 rarb => new ivec4(x, w, x, z);
        
        /// <summary>
        /// Returns ivec4.xwxw swizzling.
        /// </summary>
        public ivec4 xwxw => new ivec4(x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.rara swizzling (equivalent to ivec4.xwxw).
        /// </summary>
        public ivec4 rara => new ivec4(x, w, x, w);
        
        /// <summary>
        /// Returns ivec4.xwy swizzling.
        /// </summary>
        public ivec3 xwy => new ivec3(x, w, y);
        
        /// <summary>
        /// Returns ivec4.rag swizzling (equivalent to ivec4.xwy).
        /// </summary>
        public ivec3 rag => new ivec3(x, w, y);
        
        /// <summary>
        /// Returns ivec4.xwyx swizzling.
        /// </summary>
        public ivec4 xwyx => new ivec4(x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.ragr swizzling (equivalent to ivec4.xwyx).
        /// </summary>
        public ivec4 ragr => new ivec4(x, w, y, x);
        
        /// <summary>
        /// Returns ivec4.xwyy swizzling.
        /// </summary>
        public ivec4 xwyy => new ivec4(x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.ragg swizzling (equivalent to ivec4.xwyy).
        /// </summary>
        public ivec4 ragg => new ivec4(x, w, y, y);
        
        /// <summary>
        /// Returns ivec4.xwyz swizzling.
        /// </summary>
        public ivec4 xwyz => new ivec4(x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.ragb swizzling (equivalent to ivec4.xwyz).
        /// </summary>
        public ivec4 ragb => new ivec4(x, w, y, z);
        
        /// <summary>
        /// Returns ivec4.xwyw swizzling.
        /// </summary>
        public ivec4 xwyw => new ivec4(x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.raga swizzling (equivalent to ivec4.xwyw).
        /// </summary>
        public ivec4 raga => new ivec4(x, w, y, w);
        
        /// <summary>
        /// Returns ivec4.xwz swizzling.
        /// </summary>
        public ivec3 xwz => new ivec3(x, w, z);
        
        /// <summary>
        /// Returns ivec4.rab swizzling (equivalent to ivec4.xwz).
        /// </summary>
        public ivec3 rab => new ivec3(x, w, z);
        
        /// <summary>
        /// Returns ivec4.xwzx swizzling.
        /// </summary>
        public ivec4 xwzx => new ivec4(x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.rabr swizzling (equivalent to ivec4.xwzx).
        /// </summary>
        public ivec4 rabr => new ivec4(x, w, z, x);
        
        /// <summary>
        /// Returns ivec4.xwzy swizzling.
        /// </summary>
        public ivec4 xwzy => new ivec4(x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.rabg swizzling (equivalent to ivec4.xwzy).
        /// </summary>
        public ivec4 rabg => new ivec4(x, w, z, y);
        
        /// <summary>
        /// Returns ivec4.xwzz swizzling.
        /// </summary>
        public ivec4 xwzz => new ivec4(x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.rabb swizzling (equivalent to ivec4.xwzz).
        /// </summary>
        public ivec4 rabb => new ivec4(x, w, z, z);
        
        /// <summary>
        /// Returns ivec4.xwzw swizzling.
        /// </summary>
        public ivec4 xwzw => new ivec4(x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.raba swizzling (equivalent to ivec4.xwzw).
        /// </summary>
        public ivec4 raba => new ivec4(x, w, z, w);
        
        /// <summary>
        /// Returns ivec4.xww swizzling.
        /// </summary>
        public ivec3 xww => new ivec3(x, w, w);
        
        /// <summary>
        /// Returns ivec4.raa swizzling (equivalent to ivec4.xww).
        /// </summary>
        public ivec3 raa => new ivec3(x, w, w);
        
        /// <summary>
        /// Returns ivec4.xwwx swizzling.
        /// </summary>
        public ivec4 xwwx => new ivec4(x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.raar swizzling (equivalent to ivec4.xwwx).
        /// </summary>
        public ivec4 raar => new ivec4(x, w, w, x);
        
        /// <summary>
        /// Returns ivec4.xwwy swizzling.
        /// </summary>
        public ivec4 xwwy => new ivec4(x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.raag swizzling (equivalent to ivec4.xwwy).
        /// </summary>
        public ivec4 raag => new ivec4(x, w, w, y);
        
        /// <summary>
        /// Returns ivec4.xwwz swizzling.
        /// </summary>
        public ivec4 xwwz => new ivec4(x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.raab swizzling (equivalent to ivec4.xwwz).
        /// </summary>
        public ivec4 raab => new ivec4(x, w, w, z);
        
        /// <summary>
        /// Returns ivec4.xwww swizzling.
        /// </summary>
        public ivec4 xwww => new ivec4(x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.raaa swizzling (equivalent to ivec4.xwww).
        /// </summary>
        public ivec4 raaa => new ivec4(x, w, w, w);
        
        /// <summary>
        /// Returns ivec4.yx swizzling.
        /// </summary>
        public ivec2 yx => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec4.gr swizzling (equivalent to ivec4.yx).
        /// </summary>
        public ivec2 gr => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec4.yxx swizzling.
        /// </summary>
        public ivec3 yxx => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec4.grr swizzling (equivalent to ivec4.yxx).
        /// </summary>
        public ivec3 grr => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec4.yxxx swizzling.
        /// </summary>
        public ivec4 yxxx => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.grrr swizzling (equivalent to ivec4.yxxx).
        /// </summary>
        public ivec4 grrr => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec4.yxxy swizzling.
        /// </summary>
        public ivec4 yxxy => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.grrg swizzling (equivalent to ivec4.yxxy).
        /// </summary>
        public ivec4 grrg => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec4.yxxz swizzling.
        /// </summary>
        public ivec4 yxxz => new ivec4(y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.grrb swizzling (equivalent to ivec4.yxxz).
        /// </summary>
        public ivec4 grrb => new ivec4(y, x, x, z);
        
        /// <summary>
        /// Returns ivec4.yxxw swizzling.
        /// </summary>
        public ivec4 yxxw => new ivec4(y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.grra swizzling (equivalent to ivec4.yxxw).
        /// </summary>
        public ivec4 grra => new ivec4(y, x, x, w);
        
        /// <summary>
        /// Returns ivec4.yxy swizzling.
        /// </summary>
        public ivec3 yxy => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec4.grg swizzling (equivalent to ivec4.yxy).
        /// </summary>
        public ivec3 grg => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec4.yxyx swizzling.
        /// </summary>
        public ivec4 yxyx => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.grgr swizzling (equivalent to ivec4.yxyx).
        /// </summary>
        public ivec4 grgr => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec4.yxyy swizzling.
        /// </summary>
        public ivec4 yxyy => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.grgg swizzling (equivalent to ivec4.yxyy).
        /// </summary>
        public ivec4 grgg => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec4.yxyz swizzling.
        /// </summary>
        public ivec4 yxyz => new ivec4(y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.grgb swizzling (equivalent to ivec4.yxyz).
        /// </summary>
        public ivec4 grgb => new ivec4(y, x, y, z);
        
        /// <summary>
        /// Returns ivec4.yxyw swizzling.
        /// </summary>
        public ivec4 yxyw => new ivec4(y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.grga swizzling (equivalent to ivec4.yxyw).
        /// </summary>
        public ivec4 grga => new ivec4(y, x, y, w);
        
        /// <summary>
        /// Returns ivec4.yxz swizzling.
        /// </summary>
        public ivec3 yxz => new ivec3(y, x, z);
        
        /// <summary>
        /// Returns ivec4.grb swizzling (equivalent to ivec4.yxz).
        /// </summary>
        public ivec3 grb => new ivec3(y, x, z);
        
        /// <summary>
        /// Returns ivec4.yxzx swizzling.
        /// </summary>
        public ivec4 yxzx => new ivec4(y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.grbr swizzling (equivalent to ivec4.yxzx).
        /// </summary>
        public ivec4 grbr => new ivec4(y, x, z, x);
        
        /// <summary>
        /// Returns ivec4.yxzy swizzling.
        /// </summary>
        public ivec4 yxzy => new ivec4(y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.grbg swizzling (equivalent to ivec4.yxzy).
        /// </summary>
        public ivec4 grbg => new ivec4(y, x, z, y);
        
        /// <summary>
        /// Returns ivec4.yxzz swizzling.
        /// </summary>
        public ivec4 yxzz => new ivec4(y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.grbb swizzling (equivalent to ivec4.yxzz).
        /// </summary>
        public ivec4 grbb => new ivec4(y, x, z, z);
        
        /// <summary>
        /// Returns ivec4.yxzw swizzling.
        /// </summary>
        public ivec4 yxzw => new ivec4(y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.grba swizzling (equivalent to ivec4.yxzw).
        /// </summary>
        public ivec4 grba => new ivec4(y, x, z, w);
        
        /// <summary>
        /// Returns ivec4.yxw swizzling.
        /// </summary>
        public ivec3 yxw => new ivec3(y, x, w);
        
        /// <summary>
        /// Returns ivec4.gra swizzling (equivalent to ivec4.yxw).
        /// </summary>
        public ivec3 gra => new ivec3(y, x, w);
        
        /// <summary>
        /// Returns ivec4.yxwx swizzling.
        /// </summary>
        public ivec4 yxwx => new ivec4(y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.grar swizzling (equivalent to ivec4.yxwx).
        /// </summary>
        public ivec4 grar => new ivec4(y, x, w, x);
        
        /// <summary>
        /// Returns ivec4.yxwy swizzling.
        /// </summary>
        public ivec4 yxwy => new ivec4(y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.grag swizzling (equivalent to ivec4.yxwy).
        /// </summary>
        public ivec4 grag => new ivec4(y, x, w, y);
        
        /// <summary>
        /// Returns ivec4.yxwz swizzling.
        /// </summary>
        public ivec4 yxwz => new ivec4(y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.grab swizzling (equivalent to ivec4.yxwz).
        /// </summary>
        public ivec4 grab => new ivec4(y, x, w, z);
        
        /// <summary>
        /// Returns ivec4.yxww swizzling.
        /// </summary>
        public ivec4 yxww => new ivec4(y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.graa swizzling (equivalent to ivec4.yxww).
        /// </summary>
        public ivec4 graa => new ivec4(y, x, w, w);
        
        /// <summary>
        /// Returns ivec4.yy swizzling.
        /// </summary>
        public ivec2 yy => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec4.gg swizzling (equivalent to ivec4.yy).
        /// </summary>
        public ivec2 gg => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec4.yyx swizzling.
        /// </summary>
        public ivec3 yyx => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec4.ggr swizzling (equivalent to ivec4.yyx).
        /// </summary>
        public ivec3 ggr => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec4.yyxx swizzling.
        /// </summary>
        public ivec4 yyxx => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.ggrr swizzling (equivalent to ivec4.yyxx).
        /// </summary>
        public ivec4 ggrr => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec4.yyxy swizzling.
        /// </summary>
        public ivec4 yyxy => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.ggrg swizzling (equivalent to ivec4.yyxy).
        /// </summary>
        public ivec4 ggrg => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec4.yyxz swizzling.
        /// </summary>
        public ivec4 yyxz => new ivec4(y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.ggrb swizzling (equivalent to ivec4.yyxz).
        /// </summary>
        public ivec4 ggrb => new ivec4(y, y, x, z);
        
        /// <summary>
        /// Returns ivec4.yyxw swizzling.
        /// </summary>
        public ivec4 yyxw => new ivec4(y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.ggra swizzling (equivalent to ivec4.yyxw).
        /// </summary>
        public ivec4 ggra => new ivec4(y, y, x, w);
        
        /// <summary>
        /// Returns ivec4.yyy swizzling.
        /// </summary>
        public ivec3 yyy => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec4.ggg swizzling (equivalent to ivec4.yyy).
        /// </summary>
        public ivec3 ggg => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec4.yyyx swizzling.
        /// </summary>
        public ivec4 yyyx => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.gggr swizzling (equivalent to ivec4.yyyx).
        /// </summary>
        public ivec4 gggr => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec4.yyyy swizzling.
        /// </summary>
        public ivec4 yyyy => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.gggg swizzling (equivalent to ivec4.yyyy).
        /// </summary>
        public ivec4 gggg => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec4.yyyz swizzling.
        /// </summary>
        public ivec4 yyyz => new ivec4(y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.gggb swizzling (equivalent to ivec4.yyyz).
        /// </summary>
        public ivec4 gggb => new ivec4(y, y, y, z);
        
        /// <summary>
        /// Returns ivec4.yyyw swizzling.
        /// </summary>
        public ivec4 yyyw => new ivec4(y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.ggga swizzling (equivalent to ivec4.yyyw).
        /// </summary>
        public ivec4 ggga => new ivec4(y, y, y, w);
        
        /// <summary>
        /// Returns ivec4.yyz swizzling.
        /// </summary>
        public ivec3 yyz => new ivec3(y, y, z);
        
        /// <summary>
        /// Returns ivec4.ggb swizzling (equivalent to ivec4.yyz).
        /// </summary>
        public ivec3 ggb => new ivec3(y, y, z);
        
        /// <summary>
        /// Returns ivec4.yyzx swizzling.
        /// </summary>
        public ivec4 yyzx => new ivec4(y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.ggbr swizzling (equivalent to ivec4.yyzx).
        /// </summary>
        public ivec4 ggbr => new ivec4(y, y, z, x);
        
        /// <summary>
        /// Returns ivec4.yyzy swizzling.
        /// </summary>
        public ivec4 yyzy => new ivec4(y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.ggbg swizzling (equivalent to ivec4.yyzy).
        /// </summary>
        public ivec4 ggbg => new ivec4(y, y, z, y);
        
        /// <summary>
        /// Returns ivec4.yyzz swizzling.
        /// </summary>
        public ivec4 yyzz => new ivec4(y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.ggbb swizzling (equivalent to ivec4.yyzz).
        /// </summary>
        public ivec4 ggbb => new ivec4(y, y, z, z);
        
        /// <summary>
        /// Returns ivec4.yyzw swizzling.
        /// </summary>
        public ivec4 yyzw => new ivec4(y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.ggba swizzling (equivalent to ivec4.yyzw).
        /// </summary>
        public ivec4 ggba => new ivec4(y, y, z, w);
        
        /// <summary>
        /// Returns ivec4.yyw swizzling.
        /// </summary>
        public ivec3 yyw => new ivec3(y, y, w);
        
        /// <summary>
        /// Returns ivec4.gga swizzling (equivalent to ivec4.yyw).
        /// </summary>
        public ivec3 gga => new ivec3(y, y, w);
        
        /// <summary>
        /// Returns ivec4.yywx swizzling.
        /// </summary>
        public ivec4 yywx => new ivec4(y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.ggar swizzling (equivalent to ivec4.yywx).
        /// </summary>
        public ivec4 ggar => new ivec4(y, y, w, x);
        
        /// <summary>
        /// Returns ivec4.yywy swizzling.
        /// </summary>
        public ivec4 yywy => new ivec4(y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.ggag swizzling (equivalent to ivec4.yywy).
        /// </summary>
        public ivec4 ggag => new ivec4(y, y, w, y);
        
        /// <summary>
        /// Returns ivec4.yywz swizzling.
        /// </summary>
        public ivec4 yywz => new ivec4(y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.ggab swizzling (equivalent to ivec4.yywz).
        /// </summary>
        public ivec4 ggab => new ivec4(y, y, w, z);
        
        /// <summary>
        /// Returns ivec4.yyww swizzling.
        /// </summary>
        public ivec4 yyww => new ivec4(y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.ggaa swizzling (equivalent to ivec4.yyww).
        /// </summary>
        public ivec4 ggaa => new ivec4(y, y, w, w);
        
        /// <summary>
        /// Returns ivec4.yz swizzling.
        /// </summary>
        public ivec2 yz => new ivec2(y, z);
        
        /// <summary>
        /// Returns ivec4.gb swizzling (equivalent to ivec4.yz).
        /// </summary>
        public ivec2 gb => new ivec2(y, z);
        
        /// <summary>
        /// Returns ivec4.yzx swizzling.
        /// </summary>
        public ivec3 yzx => new ivec3(y, z, x);
        
        /// <summary>
        /// Returns ivec4.gbr swizzling (equivalent to ivec4.yzx).
        /// </summary>
        public ivec3 gbr => new ivec3(y, z, x);
        
        /// <summary>
        /// Returns ivec4.yzxx swizzling.
        /// </summary>
        public ivec4 yzxx => new ivec4(y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.gbrr swizzling (equivalent to ivec4.yzxx).
        /// </summary>
        public ivec4 gbrr => new ivec4(y, z, x, x);
        
        /// <summary>
        /// Returns ivec4.yzxy swizzling.
        /// </summary>
        public ivec4 yzxy => new ivec4(y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.gbrg swizzling (equivalent to ivec4.yzxy).
        /// </summary>
        public ivec4 gbrg => new ivec4(y, z, x, y);
        
        /// <summary>
        /// Returns ivec4.yzxz swizzling.
        /// </summary>
        public ivec4 yzxz => new ivec4(y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.gbrb swizzling (equivalent to ivec4.yzxz).
        /// </summary>
        public ivec4 gbrb => new ivec4(y, z, x, z);
        
        /// <summary>
        /// Returns ivec4.yzxw swizzling.
        /// </summary>
        public ivec4 yzxw => new ivec4(y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.gbra swizzling (equivalent to ivec4.yzxw).
        /// </summary>
        public ivec4 gbra => new ivec4(y, z, x, w);
        
        /// <summary>
        /// Returns ivec4.yzy swizzling.
        /// </summary>
        public ivec3 yzy => new ivec3(y, z, y);
        
        /// <summary>
        /// Returns ivec4.gbg swizzling (equivalent to ivec4.yzy).
        /// </summary>
        public ivec3 gbg => new ivec3(y, z, y);
        
        /// <summary>
        /// Returns ivec4.yzyx swizzling.
        /// </summary>
        public ivec4 yzyx => new ivec4(y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.gbgr swizzling (equivalent to ivec4.yzyx).
        /// </summary>
        public ivec4 gbgr => new ivec4(y, z, y, x);
        
        /// <summary>
        /// Returns ivec4.yzyy swizzling.
        /// </summary>
        public ivec4 yzyy => new ivec4(y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.gbgg swizzling (equivalent to ivec4.yzyy).
        /// </summary>
        public ivec4 gbgg => new ivec4(y, z, y, y);
        
        /// <summary>
        /// Returns ivec4.yzyz swizzling.
        /// </summary>
        public ivec4 yzyz => new ivec4(y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.gbgb swizzling (equivalent to ivec4.yzyz).
        /// </summary>
        public ivec4 gbgb => new ivec4(y, z, y, z);
        
        /// <summary>
        /// Returns ivec4.yzyw swizzling.
        /// </summary>
        public ivec4 yzyw => new ivec4(y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.gbga swizzling (equivalent to ivec4.yzyw).
        /// </summary>
        public ivec4 gbga => new ivec4(y, z, y, w);
        
        /// <summary>
        /// Returns ivec4.yzz swizzling.
        /// </summary>
        public ivec3 yzz => new ivec3(y, z, z);
        
        /// <summary>
        /// Returns ivec4.gbb swizzling (equivalent to ivec4.yzz).
        /// </summary>
        public ivec3 gbb => new ivec3(y, z, z);
        
        /// <summary>
        /// Returns ivec4.yzzx swizzling.
        /// </summary>
        public ivec4 yzzx => new ivec4(y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.gbbr swizzling (equivalent to ivec4.yzzx).
        /// </summary>
        public ivec4 gbbr => new ivec4(y, z, z, x);
        
        /// <summary>
        /// Returns ivec4.yzzy swizzling.
        /// </summary>
        public ivec4 yzzy => new ivec4(y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.gbbg swizzling (equivalent to ivec4.yzzy).
        /// </summary>
        public ivec4 gbbg => new ivec4(y, z, z, y);
        
        /// <summary>
        /// Returns ivec4.yzzz swizzling.
        /// </summary>
        public ivec4 yzzz => new ivec4(y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.gbbb swizzling (equivalent to ivec4.yzzz).
        /// </summary>
        public ivec4 gbbb => new ivec4(y, z, z, z);
        
        /// <summary>
        /// Returns ivec4.yzzw swizzling.
        /// </summary>
        public ivec4 yzzw => new ivec4(y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.gbba swizzling (equivalent to ivec4.yzzw).
        /// </summary>
        public ivec4 gbba => new ivec4(y, z, z, w);
        
        /// <summary>
        /// Returns ivec4.yzw swizzling.
        /// </summary>
        public ivec3 yzw => new ivec3(y, z, w);
        
        /// <summary>
        /// Returns ivec4.gba swizzling (equivalent to ivec4.yzw).
        /// </summary>
        public ivec3 gba => new ivec3(y, z, w);
        
        /// <summary>
        /// Returns ivec4.yzwx swizzling.
        /// </summary>
        public ivec4 yzwx => new ivec4(y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.gbar swizzling (equivalent to ivec4.yzwx).
        /// </summary>
        public ivec4 gbar => new ivec4(y, z, w, x);
        
        /// <summary>
        /// Returns ivec4.yzwy swizzling.
        /// </summary>
        public ivec4 yzwy => new ivec4(y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.gbag swizzling (equivalent to ivec4.yzwy).
        /// </summary>
        public ivec4 gbag => new ivec4(y, z, w, y);
        
        /// <summary>
        /// Returns ivec4.yzwz swizzling.
        /// </summary>
        public ivec4 yzwz => new ivec4(y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.gbab swizzling (equivalent to ivec4.yzwz).
        /// </summary>
        public ivec4 gbab => new ivec4(y, z, w, z);
        
        /// <summary>
        /// Returns ivec4.yzww swizzling.
        /// </summary>
        public ivec4 yzww => new ivec4(y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.gbaa swizzling (equivalent to ivec4.yzww).
        /// </summary>
        public ivec4 gbaa => new ivec4(y, z, w, w);
        
        /// <summary>
        /// Returns ivec4.yw swizzling.
        /// </summary>
        public ivec2 yw => new ivec2(y, w);
        
        /// <summary>
        /// Returns ivec4.ga swizzling (equivalent to ivec4.yw).
        /// </summary>
        public ivec2 ga => new ivec2(y, w);
        
        /// <summary>
        /// Returns ivec4.ywx swizzling.
        /// </summary>
        public ivec3 ywx => new ivec3(y, w, x);
        
        /// <summary>
        /// Returns ivec4.gar swizzling (equivalent to ivec4.ywx).
        /// </summary>
        public ivec3 gar => new ivec3(y, w, x);
        
        /// <summary>
        /// Returns ivec4.ywxx swizzling.
        /// </summary>
        public ivec4 ywxx => new ivec4(y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.garr swizzling (equivalent to ivec4.ywxx).
        /// </summary>
        public ivec4 garr => new ivec4(y, w, x, x);
        
        /// <summary>
        /// Returns ivec4.ywxy swizzling.
        /// </summary>
        public ivec4 ywxy => new ivec4(y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.garg swizzling (equivalent to ivec4.ywxy).
        /// </summary>
        public ivec4 garg => new ivec4(y, w, x, y);
        
        /// <summary>
        /// Returns ivec4.ywxz swizzling.
        /// </summary>
        public ivec4 ywxz => new ivec4(y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.garb swizzling (equivalent to ivec4.ywxz).
        /// </summary>
        public ivec4 garb => new ivec4(y, w, x, z);
        
        /// <summary>
        /// Returns ivec4.ywxw swizzling.
        /// </summary>
        public ivec4 ywxw => new ivec4(y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.gara swizzling (equivalent to ivec4.ywxw).
        /// </summary>
        public ivec4 gara => new ivec4(y, w, x, w);
        
        /// <summary>
        /// Returns ivec4.ywy swizzling.
        /// </summary>
        public ivec3 ywy => new ivec3(y, w, y);
        
        /// <summary>
        /// Returns ivec4.gag swizzling (equivalent to ivec4.ywy).
        /// </summary>
        public ivec3 gag => new ivec3(y, w, y);
        
        /// <summary>
        /// Returns ivec4.ywyx swizzling.
        /// </summary>
        public ivec4 ywyx => new ivec4(y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.gagr swizzling (equivalent to ivec4.ywyx).
        /// </summary>
        public ivec4 gagr => new ivec4(y, w, y, x);
        
        /// <summary>
        /// Returns ivec4.ywyy swizzling.
        /// </summary>
        public ivec4 ywyy => new ivec4(y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.gagg swizzling (equivalent to ivec4.ywyy).
        /// </summary>
        public ivec4 gagg => new ivec4(y, w, y, y);
        
        /// <summary>
        /// Returns ivec4.ywyz swizzling.
        /// </summary>
        public ivec4 ywyz => new ivec4(y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.gagb swizzling (equivalent to ivec4.ywyz).
        /// </summary>
        public ivec4 gagb => new ivec4(y, w, y, z);
        
        /// <summary>
        /// Returns ivec4.ywyw swizzling.
        /// </summary>
        public ivec4 ywyw => new ivec4(y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.gaga swizzling (equivalent to ivec4.ywyw).
        /// </summary>
        public ivec4 gaga => new ivec4(y, w, y, w);
        
        /// <summary>
        /// Returns ivec4.ywz swizzling.
        /// </summary>
        public ivec3 ywz => new ivec3(y, w, z);
        
        /// <summary>
        /// Returns ivec4.gab swizzling (equivalent to ivec4.ywz).
        /// </summary>
        public ivec3 gab => new ivec3(y, w, z);
        
        /// <summary>
        /// Returns ivec4.ywzx swizzling.
        /// </summary>
        public ivec4 ywzx => new ivec4(y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.gabr swizzling (equivalent to ivec4.ywzx).
        /// </summary>
        public ivec4 gabr => new ivec4(y, w, z, x);
        
        /// <summary>
        /// Returns ivec4.ywzy swizzling.
        /// </summary>
        public ivec4 ywzy => new ivec4(y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.gabg swizzling (equivalent to ivec4.ywzy).
        /// </summary>
        public ivec4 gabg => new ivec4(y, w, z, y);
        
        /// <summary>
        /// Returns ivec4.ywzz swizzling.
        /// </summary>
        public ivec4 ywzz => new ivec4(y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.gabb swizzling (equivalent to ivec4.ywzz).
        /// </summary>
        public ivec4 gabb => new ivec4(y, w, z, z);
        
        /// <summary>
        /// Returns ivec4.ywzw swizzling.
        /// </summary>
        public ivec4 ywzw => new ivec4(y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.gaba swizzling (equivalent to ivec4.ywzw).
        /// </summary>
        public ivec4 gaba => new ivec4(y, w, z, w);
        
        /// <summary>
        /// Returns ivec4.yww swizzling.
        /// </summary>
        public ivec3 yww => new ivec3(y, w, w);
        
        /// <summary>
        /// Returns ivec4.gaa swizzling (equivalent to ivec4.yww).
        /// </summary>
        public ivec3 gaa => new ivec3(y, w, w);
        
        /// <summary>
        /// Returns ivec4.ywwx swizzling.
        /// </summary>
        public ivec4 ywwx => new ivec4(y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.gaar swizzling (equivalent to ivec4.ywwx).
        /// </summary>
        public ivec4 gaar => new ivec4(y, w, w, x);
        
        /// <summary>
        /// Returns ivec4.ywwy swizzling.
        /// </summary>
        public ivec4 ywwy => new ivec4(y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.gaag swizzling (equivalent to ivec4.ywwy).
        /// </summary>
        public ivec4 gaag => new ivec4(y, w, w, y);
        
        /// <summary>
        /// Returns ivec4.ywwz swizzling.
        /// </summary>
        public ivec4 ywwz => new ivec4(y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.gaab swizzling (equivalent to ivec4.ywwz).
        /// </summary>
        public ivec4 gaab => new ivec4(y, w, w, z);
        
        /// <summary>
        /// Returns ivec4.ywww swizzling.
        /// </summary>
        public ivec4 ywww => new ivec4(y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.gaaa swizzling (equivalent to ivec4.ywww).
        /// </summary>
        public ivec4 gaaa => new ivec4(y, w, w, w);
        
        /// <summary>
        /// Returns ivec4.zx swizzling.
        /// </summary>
        public ivec2 zx => new ivec2(z, x);
        
        /// <summary>
        /// Returns ivec4.br swizzling (equivalent to ivec4.zx).
        /// </summary>
        public ivec2 br => new ivec2(z, x);
        
        /// <summary>
        /// Returns ivec4.zxx swizzling.
        /// </summary>
        public ivec3 zxx => new ivec3(z, x, x);
        
        /// <summary>
        /// Returns ivec4.brr swizzling (equivalent to ivec4.zxx).
        /// </summary>
        public ivec3 brr => new ivec3(z, x, x);
        
        /// <summary>
        /// Returns ivec4.zxxx swizzling.
        /// </summary>
        public ivec4 zxxx => new ivec4(z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.brrr swizzling (equivalent to ivec4.zxxx).
        /// </summary>
        public ivec4 brrr => new ivec4(z, x, x, x);
        
        /// <summary>
        /// Returns ivec4.zxxy swizzling.
        /// </summary>
        public ivec4 zxxy => new ivec4(z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.brrg swizzling (equivalent to ivec4.zxxy).
        /// </summary>
        public ivec4 brrg => new ivec4(z, x, x, y);
        
        /// <summary>
        /// Returns ivec4.zxxz swizzling.
        /// </summary>
        public ivec4 zxxz => new ivec4(z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.brrb swizzling (equivalent to ivec4.zxxz).
        /// </summary>
        public ivec4 brrb => new ivec4(z, x, x, z);
        
        /// <summary>
        /// Returns ivec4.zxxw swizzling.
        /// </summary>
        public ivec4 zxxw => new ivec4(z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.brra swizzling (equivalent to ivec4.zxxw).
        /// </summary>
        public ivec4 brra => new ivec4(z, x, x, w);
        
        /// <summary>
        /// Returns ivec4.zxy swizzling.
        /// </summary>
        public ivec3 zxy => new ivec3(z, x, y);
        
        /// <summary>
        /// Returns ivec4.brg swizzling (equivalent to ivec4.zxy).
        /// </summary>
        public ivec3 brg => new ivec3(z, x, y);
        
        /// <summary>
        /// Returns ivec4.zxyx swizzling.
        /// </summary>
        public ivec4 zxyx => new ivec4(z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.brgr swizzling (equivalent to ivec4.zxyx).
        /// </summary>
        public ivec4 brgr => new ivec4(z, x, y, x);
        
        /// <summary>
        /// Returns ivec4.zxyy swizzling.
        /// </summary>
        public ivec4 zxyy => new ivec4(z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.brgg swizzling (equivalent to ivec4.zxyy).
        /// </summary>
        public ivec4 brgg => new ivec4(z, x, y, y);
        
        /// <summary>
        /// Returns ivec4.zxyz swizzling.
        /// </summary>
        public ivec4 zxyz => new ivec4(z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.brgb swizzling (equivalent to ivec4.zxyz).
        /// </summary>
        public ivec4 brgb => new ivec4(z, x, y, z);
        
        /// <summary>
        /// Returns ivec4.zxyw swizzling.
        /// </summary>
        public ivec4 zxyw => new ivec4(z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.brga swizzling (equivalent to ivec4.zxyw).
        /// </summary>
        public ivec4 brga => new ivec4(z, x, y, w);
        
        /// <summary>
        /// Returns ivec4.zxz swizzling.
        /// </summary>
        public ivec3 zxz => new ivec3(z, x, z);
        
        /// <summary>
        /// Returns ivec4.brb swizzling (equivalent to ivec4.zxz).
        /// </summary>
        public ivec3 brb => new ivec3(z, x, z);
        
        /// <summary>
        /// Returns ivec4.zxzx swizzling.
        /// </summary>
        public ivec4 zxzx => new ivec4(z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.brbr swizzling (equivalent to ivec4.zxzx).
        /// </summary>
        public ivec4 brbr => new ivec4(z, x, z, x);
        
        /// <summary>
        /// Returns ivec4.zxzy swizzling.
        /// </summary>
        public ivec4 zxzy => new ivec4(z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.brbg swizzling (equivalent to ivec4.zxzy).
        /// </summary>
        public ivec4 brbg => new ivec4(z, x, z, y);
        
        /// <summary>
        /// Returns ivec4.zxzz swizzling.
        /// </summary>
        public ivec4 zxzz => new ivec4(z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.brbb swizzling (equivalent to ivec4.zxzz).
        /// </summary>
        public ivec4 brbb => new ivec4(z, x, z, z);
        
        /// <summary>
        /// Returns ivec4.zxzw swizzling.
        /// </summary>
        public ivec4 zxzw => new ivec4(z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.brba swizzling (equivalent to ivec4.zxzw).
        /// </summary>
        public ivec4 brba => new ivec4(z, x, z, w);
        
        /// <summary>
        /// Returns ivec4.zxw swizzling.
        /// </summary>
        public ivec3 zxw => new ivec3(z, x, w);
        
        /// <summary>
        /// Returns ivec4.bra swizzling (equivalent to ivec4.zxw).
        /// </summary>
        public ivec3 bra => new ivec3(z, x, w);
        
        /// <summary>
        /// Returns ivec4.zxwx swizzling.
        /// </summary>
        public ivec4 zxwx => new ivec4(z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.brar swizzling (equivalent to ivec4.zxwx).
        /// </summary>
        public ivec4 brar => new ivec4(z, x, w, x);
        
        /// <summary>
        /// Returns ivec4.zxwy swizzling.
        /// </summary>
        public ivec4 zxwy => new ivec4(z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.brag swizzling (equivalent to ivec4.zxwy).
        /// </summary>
        public ivec4 brag => new ivec4(z, x, w, y);
        
        /// <summary>
        /// Returns ivec4.zxwz swizzling.
        /// </summary>
        public ivec4 zxwz => new ivec4(z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.brab swizzling (equivalent to ivec4.zxwz).
        /// </summary>
        public ivec4 brab => new ivec4(z, x, w, z);
        
        /// <summary>
        /// Returns ivec4.zxww swizzling.
        /// </summary>
        public ivec4 zxww => new ivec4(z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.braa swizzling (equivalent to ivec4.zxww).
        /// </summary>
        public ivec4 braa => new ivec4(z, x, w, w);
        
        /// <summary>
        /// Returns ivec4.zy swizzling.
        /// </summary>
        public ivec2 zy => new ivec2(z, y);
        
        /// <summary>
        /// Returns ivec4.bg swizzling (equivalent to ivec4.zy).
        /// </summary>
        public ivec2 bg => new ivec2(z, y);
        
        /// <summary>
        /// Returns ivec4.zyx swizzling.
        /// </summary>
        public ivec3 zyx => new ivec3(z, y, x);
        
        /// <summary>
        /// Returns ivec4.bgr swizzling (equivalent to ivec4.zyx).
        /// </summary>
        public ivec3 bgr => new ivec3(z, y, x);
        
        /// <summary>
        /// Returns ivec4.zyxx swizzling.
        /// </summary>
        public ivec4 zyxx => new ivec4(z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.bgrr swizzling (equivalent to ivec4.zyxx).
        /// </summary>
        public ivec4 bgrr => new ivec4(z, y, x, x);
        
        /// <summary>
        /// Returns ivec4.zyxy swizzling.
        /// </summary>
        public ivec4 zyxy => new ivec4(z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.bgrg swizzling (equivalent to ivec4.zyxy).
        /// </summary>
        public ivec4 bgrg => new ivec4(z, y, x, y);
        
        /// <summary>
        /// Returns ivec4.zyxz swizzling.
        /// </summary>
        public ivec4 zyxz => new ivec4(z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.bgrb swizzling (equivalent to ivec4.zyxz).
        /// </summary>
        public ivec4 bgrb => new ivec4(z, y, x, z);
        
        /// <summary>
        /// Returns ivec4.zyxw swizzling.
        /// </summary>
        public ivec4 zyxw => new ivec4(z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.bgra swizzling (equivalent to ivec4.zyxw).
        /// </summary>
        public ivec4 bgra => new ivec4(z, y, x, w);
        
        /// <summary>
        /// Returns ivec4.zyy swizzling.
        /// </summary>
        public ivec3 zyy => new ivec3(z, y, y);
        
        /// <summary>
        /// Returns ivec4.bgg swizzling (equivalent to ivec4.zyy).
        /// </summary>
        public ivec3 bgg => new ivec3(z, y, y);
        
        /// <summary>
        /// Returns ivec4.zyyx swizzling.
        /// </summary>
        public ivec4 zyyx => new ivec4(z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.bggr swizzling (equivalent to ivec4.zyyx).
        /// </summary>
        public ivec4 bggr => new ivec4(z, y, y, x);
        
        /// <summary>
        /// Returns ivec4.zyyy swizzling.
        /// </summary>
        public ivec4 zyyy => new ivec4(z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.bggg swizzling (equivalent to ivec4.zyyy).
        /// </summary>
        public ivec4 bggg => new ivec4(z, y, y, y);
        
        /// <summary>
        /// Returns ivec4.zyyz swizzling.
        /// </summary>
        public ivec4 zyyz => new ivec4(z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.bggb swizzling (equivalent to ivec4.zyyz).
        /// </summary>
        public ivec4 bggb => new ivec4(z, y, y, z);
        
        /// <summary>
        /// Returns ivec4.zyyw swizzling.
        /// </summary>
        public ivec4 zyyw => new ivec4(z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.bgga swizzling (equivalent to ivec4.zyyw).
        /// </summary>
        public ivec4 bgga => new ivec4(z, y, y, w);
        
        /// <summary>
        /// Returns ivec4.zyz swizzling.
        /// </summary>
        public ivec3 zyz => new ivec3(z, y, z);
        
        /// <summary>
        /// Returns ivec4.bgb swizzling (equivalent to ivec4.zyz).
        /// </summary>
        public ivec3 bgb => new ivec3(z, y, z);
        
        /// <summary>
        /// Returns ivec4.zyzx swizzling.
        /// </summary>
        public ivec4 zyzx => new ivec4(z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.bgbr swizzling (equivalent to ivec4.zyzx).
        /// </summary>
        public ivec4 bgbr => new ivec4(z, y, z, x);
        
        /// <summary>
        /// Returns ivec4.zyzy swizzling.
        /// </summary>
        public ivec4 zyzy => new ivec4(z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.bgbg swizzling (equivalent to ivec4.zyzy).
        /// </summary>
        public ivec4 bgbg => new ivec4(z, y, z, y);
        
        /// <summary>
        /// Returns ivec4.zyzz swizzling.
        /// </summary>
        public ivec4 zyzz => new ivec4(z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.bgbb swizzling (equivalent to ivec4.zyzz).
        /// </summary>
        public ivec4 bgbb => new ivec4(z, y, z, z);
        
        /// <summary>
        /// Returns ivec4.zyzw swizzling.
        /// </summary>
        public ivec4 zyzw => new ivec4(z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.bgba swizzling (equivalent to ivec4.zyzw).
        /// </summary>
        public ivec4 bgba => new ivec4(z, y, z, w);
        
        /// <summary>
        /// Returns ivec4.zyw swizzling.
        /// </summary>
        public ivec3 zyw => new ivec3(z, y, w);
        
        /// <summary>
        /// Returns ivec4.bga swizzling (equivalent to ivec4.zyw).
        /// </summary>
        public ivec3 bga => new ivec3(z, y, w);
        
        /// <summary>
        /// Returns ivec4.zywx swizzling.
        /// </summary>
        public ivec4 zywx => new ivec4(z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.bgar swizzling (equivalent to ivec4.zywx).
        /// </summary>
        public ivec4 bgar => new ivec4(z, y, w, x);
        
        /// <summary>
        /// Returns ivec4.zywy swizzling.
        /// </summary>
        public ivec4 zywy => new ivec4(z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.bgag swizzling (equivalent to ivec4.zywy).
        /// </summary>
        public ivec4 bgag => new ivec4(z, y, w, y);
        
        /// <summary>
        /// Returns ivec4.zywz swizzling.
        /// </summary>
        public ivec4 zywz => new ivec4(z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.bgab swizzling (equivalent to ivec4.zywz).
        /// </summary>
        public ivec4 bgab => new ivec4(z, y, w, z);
        
        /// <summary>
        /// Returns ivec4.zyww swizzling.
        /// </summary>
        public ivec4 zyww => new ivec4(z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.bgaa swizzling (equivalent to ivec4.zyww).
        /// </summary>
        public ivec4 bgaa => new ivec4(z, y, w, w);
        
        /// <summary>
        /// Returns ivec4.zz swizzling.
        /// </summary>
        public ivec2 zz => new ivec2(z, z);
        
        /// <summary>
        /// Returns ivec4.bb swizzling (equivalent to ivec4.zz).
        /// </summary>
        public ivec2 bb => new ivec2(z, z);
        
        /// <summary>
        /// Returns ivec4.zzx swizzling.
        /// </summary>
        public ivec3 zzx => new ivec3(z, z, x);
        
        /// <summary>
        /// Returns ivec4.bbr swizzling (equivalent to ivec4.zzx).
        /// </summary>
        public ivec3 bbr => new ivec3(z, z, x);
        
        /// <summary>
        /// Returns ivec4.zzxx swizzling.
        /// </summary>
        public ivec4 zzxx => new ivec4(z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.bbrr swizzling (equivalent to ivec4.zzxx).
        /// </summary>
        public ivec4 bbrr => new ivec4(z, z, x, x);
        
        /// <summary>
        /// Returns ivec4.zzxy swizzling.
        /// </summary>
        public ivec4 zzxy => new ivec4(z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.bbrg swizzling (equivalent to ivec4.zzxy).
        /// </summary>
        public ivec4 bbrg => new ivec4(z, z, x, y);
        
        /// <summary>
        /// Returns ivec4.zzxz swizzling.
        /// </summary>
        public ivec4 zzxz => new ivec4(z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.bbrb swizzling (equivalent to ivec4.zzxz).
        /// </summary>
        public ivec4 bbrb => new ivec4(z, z, x, z);
        
        /// <summary>
        /// Returns ivec4.zzxw swizzling.
        /// </summary>
        public ivec4 zzxw => new ivec4(z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.bbra swizzling (equivalent to ivec4.zzxw).
        /// </summary>
        public ivec4 bbra => new ivec4(z, z, x, w);
        
        /// <summary>
        /// Returns ivec4.zzy swizzling.
        /// </summary>
        public ivec3 zzy => new ivec3(z, z, y);
        
        /// <summary>
        /// Returns ivec4.bbg swizzling (equivalent to ivec4.zzy).
        /// </summary>
        public ivec3 bbg => new ivec3(z, z, y);
        
        /// <summary>
        /// Returns ivec4.zzyx swizzling.
        /// </summary>
        public ivec4 zzyx => new ivec4(z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.bbgr swizzling (equivalent to ivec4.zzyx).
        /// </summary>
        public ivec4 bbgr => new ivec4(z, z, y, x);
        
        /// <summary>
        /// Returns ivec4.zzyy swizzling.
        /// </summary>
        public ivec4 zzyy => new ivec4(z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.bbgg swizzling (equivalent to ivec4.zzyy).
        /// </summary>
        public ivec4 bbgg => new ivec4(z, z, y, y);
        
        /// <summary>
        /// Returns ivec4.zzyz swizzling.
        /// </summary>
        public ivec4 zzyz => new ivec4(z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.bbgb swizzling (equivalent to ivec4.zzyz).
        /// </summary>
        public ivec4 bbgb => new ivec4(z, z, y, z);
        
        /// <summary>
        /// Returns ivec4.zzyw swizzling.
        /// </summary>
        public ivec4 zzyw => new ivec4(z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.bbga swizzling (equivalent to ivec4.zzyw).
        /// </summary>
        public ivec4 bbga => new ivec4(z, z, y, w);
        
        /// <summary>
        /// Returns ivec4.zzz swizzling.
        /// </summary>
        public ivec3 zzz => new ivec3(z, z, z);
        
        /// <summary>
        /// Returns ivec4.bbb swizzling (equivalent to ivec4.zzz).
        /// </summary>
        public ivec3 bbb => new ivec3(z, z, z);
        
        /// <summary>
        /// Returns ivec4.zzzx swizzling.
        /// </summary>
        public ivec4 zzzx => new ivec4(z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.bbbr swizzling (equivalent to ivec4.zzzx).
        /// </summary>
        public ivec4 bbbr => new ivec4(z, z, z, x);
        
        /// <summary>
        /// Returns ivec4.zzzy swizzling.
        /// </summary>
        public ivec4 zzzy => new ivec4(z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.bbbg swizzling (equivalent to ivec4.zzzy).
        /// </summary>
        public ivec4 bbbg => new ivec4(z, z, z, y);
        
        /// <summary>
        /// Returns ivec4.zzzz swizzling.
        /// </summary>
        public ivec4 zzzz => new ivec4(z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.bbbb swizzling (equivalent to ivec4.zzzz).
        /// </summary>
        public ivec4 bbbb => new ivec4(z, z, z, z);
        
        /// <summary>
        /// Returns ivec4.zzzw swizzling.
        /// </summary>
        public ivec4 zzzw => new ivec4(z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.bbba swizzling (equivalent to ivec4.zzzw).
        /// </summary>
        public ivec4 bbba => new ivec4(z, z, z, w);
        
        /// <summary>
        /// Returns ivec4.zzw swizzling.
        /// </summary>
        public ivec3 zzw => new ivec3(z, z, w);
        
        /// <summary>
        /// Returns ivec4.bba swizzling (equivalent to ivec4.zzw).
        /// </summary>
        public ivec3 bba => new ivec3(z, z, w);
        
        /// <summary>
        /// Returns ivec4.zzwx swizzling.
        /// </summary>
        public ivec4 zzwx => new ivec4(z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.bbar swizzling (equivalent to ivec4.zzwx).
        /// </summary>
        public ivec4 bbar => new ivec4(z, z, w, x);
        
        /// <summary>
        /// Returns ivec4.zzwy swizzling.
        /// </summary>
        public ivec4 zzwy => new ivec4(z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.bbag swizzling (equivalent to ivec4.zzwy).
        /// </summary>
        public ivec4 bbag => new ivec4(z, z, w, y);
        
        /// <summary>
        /// Returns ivec4.zzwz swizzling.
        /// </summary>
        public ivec4 zzwz => new ivec4(z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.bbab swizzling (equivalent to ivec4.zzwz).
        /// </summary>
        public ivec4 bbab => new ivec4(z, z, w, z);
        
        /// <summary>
        /// Returns ivec4.zzww swizzling.
        /// </summary>
        public ivec4 zzww => new ivec4(z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.bbaa swizzling (equivalent to ivec4.zzww).
        /// </summary>
        public ivec4 bbaa => new ivec4(z, z, w, w);
        
        /// <summary>
        /// Returns ivec4.zw swizzling.
        /// </summary>
        public ivec2 zw => new ivec2(z, w);
        
        /// <summary>
        /// Returns ivec4.ba swizzling (equivalent to ivec4.zw).
        /// </summary>
        public ivec2 ba => new ivec2(z, w);
        
        /// <summary>
        /// Returns ivec4.zwx swizzling.
        /// </summary>
        public ivec3 zwx => new ivec3(z, w, x);
        
        /// <summary>
        /// Returns ivec4.bar swizzling (equivalent to ivec4.zwx).
        /// </summary>
        public ivec3 bar => new ivec3(z, w, x);
        
        /// <summary>
        /// Returns ivec4.zwxx swizzling.
        /// </summary>
        public ivec4 zwxx => new ivec4(z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.barr swizzling (equivalent to ivec4.zwxx).
        /// </summary>
        public ivec4 barr => new ivec4(z, w, x, x);
        
        /// <summary>
        /// Returns ivec4.zwxy swizzling.
        /// </summary>
        public ivec4 zwxy => new ivec4(z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.barg swizzling (equivalent to ivec4.zwxy).
        /// </summary>
        public ivec4 barg => new ivec4(z, w, x, y);
        
        /// <summary>
        /// Returns ivec4.zwxz swizzling.
        /// </summary>
        public ivec4 zwxz => new ivec4(z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.barb swizzling (equivalent to ivec4.zwxz).
        /// </summary>
        public ivec4 barb => new ivec4(z, w, x, z);
        
        /// <summary>
        /// Returns ivec4.zwxw swizzling.
        /// </summary>
        public ivec4 zwxw => new ivec4(z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.bara swizzling (equivalent to ivec4.zwxw).
        /// </summary>
        public ivec4 bara => new ivec4(z, w, x, w);
        
        /// <summary>
        /// Returns ivec4.zwy swizzling.
        /// </summary>
        public ivec3 zwy => new ivec3(z, w, y);
        
        /// <summary>
        /// Returns ivec4.bag swizzling (equivalent to ivec4.zwy).
        /// </summary>
        public ivec3 bag => new ivec3(z, w, y);
        
        /// <summary>
        /// Returns ivec4.zwyx swizzling.
        /// </summary>
        public ivec4 zwyx => new ivec4(z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.bagr swizzling (equivalent to ivec4.zwyx).
        /// </summary>
        public ivec4 bagr => new ivec4(z, w, y, x);
        
        /// <summary>
        /// Returns ivec4.zwyy swizzling.
        /// </summary>
        public ivec4 zwyy => new ivec4(z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.bagg swizzling (equivalent to ivec4.zwyy).
        /// </summary>
        public ivec4 bagg => new ivec4(z, w, y, y);
        
        /// <summary>
        /// Returns ivec4.zwyz swizzling.
        /// </summary>
        public ivec4 zwyz => new ivec4(z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.bagb swizzling (equivalent to ivec4.zwyz).
        /// </summary>
        public ivec4 bagb => new ivec4(z, w, y, z);
        
        /// <summary>
        /// Returns ivec4.zwyw swizzling.
        /// </summary>
        public ivec4 zwyw => new ivec4(z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.baga swizzling (equivalent to ivec4.zwyw).
        /// </summary>
        public ivec4 baga => new ivec4(z, w, y, w);
        
        /// <summary>
        /// Returns ivec4.zwz swizzling.
        /// </summary>
        public ivec3 zwz => new ivec3(z, w, z);
        
        /// <summary>
        /// Returns ivec4.bab swizzling (equivalent to ivec4.zwz).
        /// </summary>
        public ivec3 bab => new ivec3(z, w, z);
        
        /// <summary>
        /// Returns ivec4.zwzx swizzling.
        /// </summary>
        public ivec4 zwzx => new ivec4(z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.babr swizzling (equivalent to ivec4.zwzx).
        /// </summary>
        public ivec4 babr => new ivec4(z, w, z, x);
        
        /// <summary>
        /// Returns ivec4.zwzy swizzling.
        /// </summary>
        public ivec4 zwzy => new ivec4(z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.babg swizzling (equivalent to ivec4.zwzy).
        /// </summary>
        public ivec4 babg => new ivec4(z, w, z, y);
        
        /// <summary>
        /// Returns ivec4.zwzz swizzling.
        /// </summary>
        public ivec4 zwzz => new ivec4(z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.babb swizzling (equivalent to ivec4.zwzz).
        /// </summary>
        public ivec4 babb => new ivec4(z, w, z, z);
        
        /// <summary>
        /// Returns ivec4.zwzw swizzling.
        /// </summary>
        public ivec4 zwzw => new ivec4(z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.baba swizzling (equivalent to ivec4.zwzw).
        /// </summary>
        public ivec4 baba => new ivec4(z, w, z, w);
        
        /// <summary>
        /// Returns ivec4.zww swizzling.
        /// </summary>
        public ivec3 zww => new ivec3(z, w, w);
        
        /// <summary>
        /// Returns ivec4.baa swizzling (equivalent to ivec4.zww).
        /// </summary>
        public ivec3 baa => new ivec3(z, w, w);
        
        /// <summary>
        /// Returns ivec4.zwwx swizzling.
        /// </summary>
        public ivec4 zwwx => new ivec4(z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.baar swizzling (equivalent to ivec4.zwwx).
        /// </summary>
        public ivec4 baar => new ivec4(z, w, w, x);
        
        /// <summary>
        /// Returns ivec4.zwwy swizzling.
        /// </summary>
        public ivec4 zwwy => new ivec4(z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.baag swizzling (equivalent to ivec4.zwwy).
        /// </summary>
        public ivec4 baag => new ivec4(z, w, w, y);
        
        /// <summary>
        /// Returns ivec4.zwwz swizzling.
        /// </summary>
        public ivec4 zwwz => new ivec4(z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.baab swizzling (equivalent to ivec4.zwwz).
        /// </summary>
        public ivec4 baab => new ivec4(z, w, w, z);
        
        /// <summary>
        /// Returns ivec4.zwww swizzling.
        /// </summary>
        public ivec4 zwww => new ivec4(z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.baaa swizzling (equivalent to ivec4.zwww).
        /// </summary>
        public ivec4 baaa => new ivec4(z, w, w, w);
        
        /// <summary>
        /// Returns ivec4.wx swizzling.
        /// </summary>
        public ivec2 wx => new ivec2(w, x);
        
        /// <summary>
        /// Returns ivec4.ar swizzling (equivalent to ivec4.wx).
        /// </summary>
        public ivec2 ar => new ivec2(w, x);
        
        /// <summary>
        /// Returns ivec4.wxx swizzling.
        /// </summary>
        public ivec3 wxx => new ivec3(w, x, x);
        
        /// <summary>
        /// Returns ivec4.arr swizzling (equivalent to ivec4.wxx).
        /// </summary>
        public ivec3 arr => new ivec3(w, x, x);
        
        /// <summary>
        /// Returns ivec4.wxxx swizzling.
        /// </summary>
        public ivec4 wxxx => new ivec4(w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.arrr swizzling (equivalent to ivec4.wxxx).
        /// </summary>
        public ivec4 arrr => new ivec4(w, x, x, x);
        
        /// <summary>
        /// Returns ivec4.wxxy swizzling.
        /// </summary>
        public ivec4 wxxy => new ivec4(w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.arrg swizzling (equivalent to ivec4.wxxy).
        /// </summary>
        public ivec4 arrg => new ivec4(w, x, x, y);
        
        /// <summary>
        /// Returns ivec4.wxxz swizzling.
        /// </summary>
        public ivec4 wxxz => new ivec4(w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.arrb swizzling (equivalent to ivec4.wxxz).
        /// </summary>
        public ivec4 arrb => new ivec4(w, x, x, z);
        
        /// <summary>
        /// Returns ivec4.wxxw swizzling.
        /// </summary>
        public ivec4 wxxw => new ivec4(w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.arra swizzling (equivalent to ivec4.wxxw).
        /// </summary>
        public ivec4 arra => new ivec4(w, x, x, w);
        
        /// <summary>
        /// Returns ivec4.wxy swizzling.
        /// </summary>
        public ivec3 wxy => new ivec3(w, x, y);
        
        /// <summary>
        /// Returns ivec4.arg swizzling (equivalent to ivec4.wxy).
        /// </summary>
        public ivec3 arg => new ivec3(w, x, y);
        
        /// <summary>
        /// Returns ivec4.wxyx swizzling.
        /// </summary>
        public ivec4 wxyx => new ivec4(w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.argr swizzling (equivalent to ivec4.wxyx).
        /// </summary>
        public ivec4 argr => new ivec4(w, x, y, x);
        
        /// <summary>
        /// Returns ivec4.wxyy swizzling.
        /// </summary>
        public ivec4 wxyy => new ivec4(w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.argg swizzling (equivalent to ivec4.wxyy).
        /// </summary>
        public ivec4 argg => new ivec4(w, x, y, y);
        
        /// <summary>
        /// Returns ivec4.wxyz swizzling.
        /// </summary>
        public ivec4 wxyz => new ivec4(w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.argb swizzling (equivalent to ivec4.wxyz).
        /// </summary>
        public ivec4 argb => new ivec4(w, x, y, z);
        
        /// <summary>
        /// Returns ivec4.wxyw swizzling.
        /// </summary>
        public ivec4 wxyw => new ivec4(w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.arga swizzling (equivalent to ivec4.wxyw).
        /// </summary>
        public ivec4 arga => new ivec4(w, x, y, w);
        
        /// <summary>
        /// Returns ivec4.wxz swizzling.
        /// </summary>
        public ivec3 wxz => new ivec3(w, x, z);
        
        /// <summary>
        /// Returns ivec4.arb swizzling (equivalent to ivec4.wxz).
        /// </summary>
        public ivec3 arb => new ivec3(w, x, z);
        
        /// <summary>
        /// Returns ivec4.wxzx swizzling.
        /// </summary>
        public ivec4 wxzx => new ivec4(w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.arbr swizzling (equivalent to ivec4.wxzx).
        /// </summary>
        public ivec4 arbr => new ivec4(w, x, z, x);
        
        /// <summary>
        /// Returns ivec4.wxzy swizzling.
        /// </summary>
        public ivec4 wxzy => new ivec4(w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.arbg swizzling (equivalent to ivec4.wxzy).
        /// </summary>
        public ivec4 arbg => new ivec4(w, x, z, y);
        
        /// <summary>
        /// Returns ivec4.wxzz swizzling.
        /// </summary>
        public ivec4 wxzz => new ivec4(w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.arbb swizzling (equivalent to ivec4.wxzz).
        /// </summary>
        public ivec4 arbb => new ivec4(w, x, z, z);
        
        /// <summary>
        /// Returns ivec4.wxzw swizzling.
        /// </summary>
        public ivec4 wxzw => new ivec4(w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.arba swizzling (equivalent to ivec4.wxzw).
        /// </summary>
        public ivec4 arba => new ivec4(w, x, z, w);
        
        /// <summary>
        /// Returns ivec4.wxw swizzling.
        /// </summary>
        public ivec3 wxw => new ivec3(w, x, w);
        
        /// <summary>
        /// Returns ivec4.ara swizzling (equivalent to ivec4.wxw).
        /// </summary>
        public ivec3 ara => new ivec3(w, x, w);
        
        /// <summary>
        /// Returns ivec4.wxwx swizzling.
        /// </summary>
        public ivec4 wxwx => new ivec4(w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.arar swizzling (equivalent to ivec4.wxwx).
        /// </summary>
        public ivec4 arar => new ivec4(w, x, w, x);
        
        /// <summary>
        /// Returns ivec4.wxwy swizzling.
        /// </summary>
        public ivec4 wxwy => new ivec4(w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.arag swizzling (equivalent to ivec4.wxwy).
        /// </summary>
        public ivec4 arag => new ivec4(w, x, w, y);
        
        /// <summary>
        /// Returns ivec4.wxwz swizzling.
        /// </summary>
        public ivec4 wxwz => new ivec4(w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.arab swizzling (equivalent to ivec4.wxwz).
        /// </summary>
        public ivec4 arab => new ivec4(w, x, w, z);
        
        /// <summary>
        /// Returns ivec4.wxww swizzling.
        /// </summary>
        public ivec4 wxww => new ivec4(w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.araa swizzling (equivalent to ivec4.wxww).
        /// </summary>
        public ivec4 araa => new ivec4(w, x, w, w);
        
        /// <summary>
        /// Returns ivec4.wy swizzling.
        /// </summary>
        public ivec2 wy => new ivec2(w, y);
        
        /// <summary>
        /// Returns ivec4.ag swizzling (equivalent to ivec4.wy).
        /// </summary>
        public ivec2 ag => new ivec2(w, y);
        
        /// <summary>
        /// Returns ivec4.wyx swizzling.
        /// </summary>
        public ivec3 wyx => new ivec3(w, y, x);
        
        /// <summary>
        /// Returns ivec4.agr swizzling (equivalent to ivec4.wyx).
        /// </summary>
        public ivec3 agr => new ivec3(w, y, x);
        
        /// <summary>
        /// Returns ivec4.wyxx swizzling.
        /// </summary>
        public ivec4 wyxx => new ivec4(w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.agrr swizzling (equivalent to ivec4.wyxx).
        /// </summary>
        public ivec4 agrr => new ivec4(w, y, x, x);
        
        /// <summary>
        /// Returns ivec4.wyxy swizzling.
        /// </summary>
        public ivec4 wyxy => new ivec4(w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.agrg swizzling (equivalent to ivec4.wyxy).
        /// </summary>
        public ivec4 agrg => new ivec4(w, y, x, y);
        
        /// <summary>
        /// Returns ivec4.wyxz swizzling.
        /// </summary>
        public ivec4 wyxz => new ivec4(w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.agrb swizzling (equivalent to ivec4.wyxz).
        /// </summary>
        public ivec4 agrb => new ivec4(w, y, x, z);
        
        /// <summary>
        /// Returns ivec4.wyxw swizzling.
        /// </summary>
        public ivec4 wyxw => new ivec4(w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.agra swizzling (equivalent to ivec4.wyxw).
        /// </summary>
        public ivec4 agra => new ivec4(w, y, x, w);
        
        /// <summary>
        /// Returns ivec4.wyy swizzling.
        /// </summary>
        public ivec3 wyy => new ivec3(w, y, y);
        
        /// <summary>
        /// Returns ivec4.agg swizzling (equivalent to ivec4.wyy).
        /// </summary>
        public ivec3 agg => new ivec3(w, y, y);
        
        /// <summary>
        /// Returns ivec4.wyyx swizzling.
        /// </summary>
        public ivec4 wyyx => new ivec4(w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.aggr swizzling (equivalent to ivec4.wyyx).
        /// </summary>
        public ivec4 aggr => new ivec4(w, y, y, x);
        
        /// <summary>
        /// Returns ivec4.wyyy swizzling.
        /// </summary>
        public ivec4 wyyy => new ivec4(w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.aggg swizzling (equivalent to ivec4.wyyy).
        /// </summary>
        public ivec4 aggg => new ivec4(w, y, y, y);
        
        /// <summary>
        /// Returns ivec4.wyyz swizzling.
        /// </summary>
        public ivec4 wyyz => new ivec4(w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.aggb swizzling (equivalent to ivec4.wyyz).
        /// </summary>
        public ivec4 aggb => new ivec4(w, y, y, z);
        
        /// <summary>
        /// Returns ivec4.wyyw swizzling.
        /// </summary>
        public ivec4 wyyw => new ivec4(w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.agga swizzling (equivalent to ivec4.wyyw).
        /// </summary>
        public ivec4 agga => new ivec4(w, y, y, w);
        
        /// <summary>
        /// Returns ivec4.wyz swizzling.
        /// </summary>
        public ivec3 wyz => new ivec3(w, y, z);
        
        /// <summary>
        /// Returns ivec4.agb swizzling (equivalent to ivec4.wyz).
        /// </summary>
        public ivec3 agb => new ivec3(w, y, z);
        
        /// <summary>
        /// Returns ivec4.wyzx swizzling.
        /// </summary>
        public ivec4 wyzx => new ivec4(w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.agbr swizzling (equivalent to ivec4.wyzx).
        /// </summary>
        public ivec4 agbr => new ivec4(w, y, z, x);
        
        /// <summary>
        /// Returns ivec4.wyzy swizzling.
        /// </summary>
        public ivec4 wyzy => new ivec4(w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.agbg swizzling (equivalent to ivec4.wyzy).
        /// </summary>
        public ivec4 agbg => new ivec4(w, y, z, y);
        
        /// <summary>
        /// Returns ivec4.wyzz swizzling.
        /// </summary>
        public ivec4 wyzz => new ivec4(w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.agbb swizzling (equivalent to ivec4.wyzz).
        /// </summary>
        public ivec4 agbb => new ivec4(w, y, z, z);
        
        /// <summary>
        /// Returns ivec4.wyzw swizzling.
        /// </summary>
        public ivec4 wyzw => new ivec4(w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.agba swizzling (equivalent to ivec4.wyzw).
        /// </summary>
        public ivec4 agba => new ivec4(w, y, z, w);
        
        /// <summary>
        /// Returns ivec4.wyw swizzling.
        /// </summary>
        public ivec3 wyw => new ivec3(w, y, w);
        
        /// <summary>
        /// Returns ivec4.aga swizzling (equivalent to ivec4.wyw).
        /// </summary>
        public ivec3 aga => new ivec3(w, y, w);
        
        /// <summary>
        /// Returns ivec4.wywx swizzling.
        /// </summary>
        public ivec4 wywx => new ivec4(w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.agar swizzling (equivalent to ivec4.wywx).
        /// </summary>
        public ivec4 agar => new ivec4(w, y, w, x);
        
        /// <summary>
        /// Returns ivec4.wywy swizzling.
        /// </summary>
        public ivec4 wywy => new ivec4(w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.agag swizzling (equivalent to ivec4.wywy).
        /// </summary>
        public ivec4 agag => new ivec4(w, y, w, y);
        
        /// <summary>
        /// Returns ivec4.wywz swizzling.
        /// </summary>
        public ivec4 wywz => new ivec4(w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.agab swizzling (equivalent to ivec4.wywz).
        /// </summary>
        public ivec4 agab => new ivec4(w, y, w, z);
        
        /// <summary>
        /// Returns ivec4.wyww swizzling.
        /// </summary>
        public ivec4 wyww => new ivec4(w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.agaa swizzling (equivalent to ivec4.wyww).
        /// </summary>
        public ivec4 agaa => new ivec4(w, y, w, w);
        
        /// <summary>
        /// Returns ivec4.wz swizzling.
        /// </summary>
        public ivec2 wz => new ivec2(w, z);
        
        /// <summary>
        /// Returns ivec4.ab swizzling (equivalent to ivec4.wz).
        /// </summary>
        public ivec2 ab => new ivec2(w, z);
        
        /// <summary>
        /// Returns ivec4.wzx swizzling.
        /// </summary>
        public ivec3 wzx => new ivec3(w, z, x);
        
        /// <summary>
        /// Returns ivec4.abr swizzling (equivalent to ivec4.wzx).
        /// </summary>
        public ivec3 abr => new ivec3(w, z, x);
        
        /// <summary>
        /// Returns ivec4.wzxx swizzling.
        /// </summary>
        public ivec4 wzxx => new ivec4(w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.abrr swizzling (equivalent to ivec4.wzxx).
        /// </summary>
        public ivec4 abrr => new ivec4(w, z, x, x);
        
        /// <summary>
        /// Returns ivec4.wzxy swizzling.
        /// </summary>
        public ivec4 wzxy => new ivec4(w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.abrg swizzling (equivalent to ivec4.wzxy).
        /// </summary>
        public ivec4 abrg => new ivec4(w, z, x, y);
        
        /// <summary>
        /// Returns ivec4.wzxz swizzling.
        /// </summary>
        public ivec4 wzxz => new ivec4(w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.abrb swizzling (equivalent to ivec4.wzxz).
        /// </summary>
        public ivec4 abrb => new ivec4(w, z, x, z);
        
        /// <summary>
        /// Returns ivec4.wzxw swizzling.
        /// </summary>
        public ivec4 wzxw => new ivec4(w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.abra swizzling (equivalent to ivec4.wzxw).
        /// </summary>
        public ivec4 abra => new ivec4(w, z, x, w);
        
        /// <summary>
        /// Returns ivec4.wzy swizzling.
        /// </summary>
        public ivec3 wzy => new ivec3(w, z, y);
        
        /// <summary>
        /// Returns ivec4.abg swizzling (equivalent to ivec4.wzy).
        /// </summary>
        public ivec3 abg => new ivec3(w, z, y);
        
        /// <summary>
        /// Returns ivec4.wzyx swizzling.
        /// </summary>
        public ivec4 wzyx => new ivec4(w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.abgr swizzling (equivalent to ivec4.wzyx).
        /// </summary>
        public ivec4 abgr => new ivec4(w, z, y, x);
        
        /// <summary>
        /// Returns ivec4.wzyy swizzling.
        /// </summary>
        public ivec4 wzyy => new ivec4(w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.abgg swizzling (equivalent to ivec4.wzyy).
        /// </summary>
        public ivec4 abgg => new ivec4(w, z, y, y);
        
        /// <summary>
        /// Returns ivec4.wzyz swizzling.
        /// </summary>
        public ivec4 wzyz => new ivec4(w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.abgb swizzling (equivalent to ivec4.wzyz).
        /// </summary>
        public ivec4 abgb => new ivec4(w, z, y, z);
        
        /// <summary>
        /// Returns ivec4.wzyw swizzling.
        /// </summary>
        public ivec4 wzyw => new ivec4(w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.abga swizzling (equivalent to ivec4.wzyw).
        /// </summary>
        public ivec4 abga => new ivec4(w, z, y, w);
        
        /// <summary>
        /// Returns ivec4.wzz swizzling.
        /// </summary>
        public ivec3 wzz => new ivec3(w, z, z);
        
        /// <summary>
        /// Returns ivec4.abb swizzling (equivalent to ivec4.wzz).
        /// </summary>
        public ivec3 abb => new ivec3(w, z, z);
        
        /// <summary>
        /// Returns ivec4.wzzx swizzling.
        /// </summary>
        public ivec4 wzzx => new ivec4(w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.abbr swizzling (equivalent to ivec4.wzzx).
        /// </summary>
        public ivec4 abbr => new ivec4(w, z, z, x);
        
        /// <summary>
        /// Returns ivec4.wzzy swizzling.
        /// </summary>
        public ivec4 wzzy => new ivec4(w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.abbg swizzling (equivalent to ivec4.wzzy).
        /// </summary>
        public ivec4 abbg => new ivec4(w, z, z, y);
        
        /// <summary>
        /// Returns ivec4.wzzz swizzling.
        /// </summary>
        public ivec4 wzzz => new ivec4(w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.abbb swizzling (equivalent to ivec4.wzzz).
        /// </summary>
        public ivec4 abbb => new ivec4(w, z, z, z);
        
        /// <summary>
        /// Returns ivec4.wzzw swizzling.
        /// </summary>
        public ivec4 wzzw => new ivec4(w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.abba swizzling (equivalent to ivec4.wzzw).
        /// </summary>
        public ivec4 abba => new ivec4(w, z, z, w);
        
        /// <summary>
        /// Returns ivec4.wzw swizzling.
        /// </summary>
        public ivec3 wzw => new ivec3(w, z, w);
        
        /// <summary>
        /// Returns ivec4.aba swizzling (equivalent to ivec4.wzw).
        /// </summary>
        public ivec3 aba => new ivec3(w, z, w);
        
        /// <summary>
        /// Returns ivec4.wzwx swizzling.
        /// </summary>
        public ivec4 wzwx => new ivec4(w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.abar swizzling (equivalent to ivec4.wzwx).
        /// </summary>
        public ivec4 abar => new ivec4(w, z, w, x);
        
        /// <summary>
        /// Returns ivec4.wzwy swizzling.
        /// </summary>
        public ivec4 wzwy => new ivec4(w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.abag swizzling (equivalent to ivec4.wzwy).
        /// </summary>
        public ivec4 abag => new ivec4(w, z, w, y);
        
        /// <summary>
        /// Returns ivec4.wzwz swizzling.
        /// </summary>
        public ivec4 wzwz => new ivec4(w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.abab swizzling (equivalent to ivec4.wzwz).
        /// </summary>
        public ivec4 abab => new ivec4(w, z, w, z);
        
        /// <summary>
        /// Returns ivec4.wzww swizzling.
        /// </summary>
        public ivec4 wzww => new ivec4(w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.abaa swizzling (equivalent to ivec4.wzww).
        /// </summary>
        public ivec4 abaa => new ivec4(w, z, w, w);
        
        /// <summary>
        /// Returns ivec4.ww swizzling.
        /// </summary>
        public ivec2 ww => new ivec2(w, w);
        
        /// <summary>
        /// Returns ivec4.aa swizzling (equivalent to ivec4.ww).
        /// </summary>
        public ivec2 aa => new ivec2(w, w);
        
        /// <summary>
        /// Returns ivec4.wwx swizzling.
        /// </summary>
        public ivec3 wwx => new ivec3(w, w, x);
        
        /// <summary>
        /// Returns ivec4.aar swizzling (equivalent to ivec4.wwx).
        /// </summary>
        public ivec3 aar => new ivec3(w, w, x);
        
        /// <summary>
        /// Returns ivec4.wwxx swizzling.
        /// </summary>
        public ivec4 wwxx => new ivec4(w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.aarr swizzling (equivalent to ivec4.wwxx).
        /// </summary>
        public ivec4 aarr => new ivec4(w, w, x, x);
        
        /// <summary>
        /// Returns ivec4.wwxy swizzling.
        /// </summary>
        public ivec4 wwxy => new ivec4(w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.aarg swizzling (equivalent to ivec4.wwxy).
        /// </summary>
        public ivec4 aarg => new ivec4(w, w, x, y);
        
        /// <summary>
        /// Returns ivec4.wwxz swizzling.
        /// </summary>
        public ivec4 wwxz => new ivec4(w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.aarb swizzling (equivalent to ivec4.wwxz).
        /// </summary>
        public ivec4 aarb => new ivec4(w, w, x, z);
        
        /// <summary>
        /// Returns ivec4.wwxw swizzling.
        /// </summary>
        public ivec4 wwxw => new ivec4(w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.aara swizzling (equivalent to ivec4.wwxw).
        /// </summary>
        public ivec4 aara => new ivec4(w, w, x, w);
        
        /// <summary>
        /// Returns ivec4.wwy swizzling.
        /// </summary>
        public ivec3 wwy => new ivec3(w, w, y);
        
        /// <summary>
        /// Returns ivec4.aag swizzling (equivalent to ivec4.wwy).
        /// </summary>
        public ivec3 aag => new ivec3(w, w, y);
        
        /// <summary>
        /// Returns ivec4.wwyx swizzling.
        /// </summary>
        public ivec4 wwyx => new ivec4(w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.aagr swizzling (equivalent to ivec4.wwyx).
        /// </summary>
        public ivec4 aagr => new ivec4(w, w, y, x);
        
        /// <summary>
        /// Returns ivec4.wwyy swizzling.
        /// </summary>
        public ivec4 wwyy => new ivec4(w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.aagg swizzling (equivalent to ivec4.wwyy).
        /// </summary>
        public ivec4 aagg => new ivec4(w, w, y, y);
        
        /// <summary>
        /// Returns ivec4.wwyz swizzling.
        /// </summary>
        public ivec4 wwyz => new ivec4(w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.aagb swizzling (equivalent to ivec4.wwyz).
        /// </summary>
        public ivec4 aagb => new ivec4(w, w, y, z);
        
        /// <summary>
        /// Returns ivec4.wwyw swizzling.
        /// </summary>
        public ivec4 wwyw => new ivec4(w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.aaga swizzling (equivalent to ivec4.wwyw).
        /// </summary>
        public ivec4 aaga => new ivec4(w, w, y, w);
        
        /// <summary>
        /// Returns ivec4.wwz swizzling.
        /// </summary>
        public ivec3 wwz => new ivec3(w, w, z);
        
        /// <summary>
        /// Returns ivec4.aab swizzling (equivalent to ivec4.wwz).
        /// </summary>
        public ivec3 aab => new ivec3(w, w, z);
        
        /// <summary>
        /// Returns ivec4.wwzx swizzling.
        /// </summary>
        public ivec4 wwzx => new ivec4(w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.aabr swizzling (equivalent to ivec4.wwzx).
        /// </summary>
        public ivec4 aabr => new ivec4(w, w, z, x);
        
        /// <summary>
        /// Returns ivec4.wwzy swizzling.
        /// </summary>
        public ivec4 wwzy => new ivec4(w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.aabg swizzling (equivalent to ivec4.wwzy).
        /// </summary>
        public ivec4 aabg => new ivec4(w, w, z, y);
        
        /// <summary>
        /// Returns ivec4.wwzz swizzling.
        /// </summary>
        public ivec4 wwzz => new ivec4(w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.aabb swizzling (equivalent to ivec4.wwzz).
        /// </summary>
        public ivec4 aabb => new ivec4(w, w, z, z);
        
        /// <summary>
        /// Returns ivec4.wwzw swizzling.
        /// </summary>
        public ivec4 wwzw => new ivec4(w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.aaba swizzling (equivalent to ivec4.wwzw).
        /// </summary>
        public ivec4 aaba => new ivec4(w, w, z, w);
        
        /// <summary>
        /// Returns ivec4.www swizzling.
        /// </summary>
        public ivec3 www => new ivec3(w, w, w);
        
        /// <summary>
        /// Returns ivec4.aaa swizzling (equivalent to ivec4.www).
        /// </summary>
        public ivec3 aaa => new ivec3(w, w, w);
        
        /// <summary>
        /// Returns ivec4.wwwx swizzling.
        /// </summary>
        public ivec4 wwwx => new ivec4(w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.aaar swizzling (equivalent to ivec4.wwwx).
        /// </summary>
        public ivec4 aaar => new ivec4(w, w, w, x);
        
        /// <summary>
        /// Returns ivec4.wwwy swizzling.
        /// </summary>
        public ivec4 wwwy => new ivec4(w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.aaag swizzling (equivalent to ivec4.wwwy).
        /// </summary>
        public ivec4 aaag => new ivec4(w, w, w, y);
        
        /// <summary>
        /// Returns ivec4.wwwz swizzling.
        /// </summary>
        public ivec4 wwwz => new ivec4(w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.aaab swizzling (equivalent to ivec4.wwwz).
        /// </summary>
        public ivec4 aaab => new ivec4(w, w, w, z);
        
        /// <summary>
        /// Returns ivec4.wwww swizzling.
        /// </summary>
        public ivec4 wwww => new ivec4(w, w, w, w);
        
        /// <summary>
        /// Returns ivec4.aaaa swizzling (equivalent to ivec4.wwww).
        /// </summary>
        public ivec4 aaaa => new ivec4(w, w, w, w);

        #endregion

    }
}
