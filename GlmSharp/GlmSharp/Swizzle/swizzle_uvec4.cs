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
    /// Temporary vector of type uint with 4 components, used for implementing swizzling for uvec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_uvec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly uint y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly uint z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly uint w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_uvec4.
        /// </summary>
        internal swizzle_uvec4(uint x, uint y, uint z, uint w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns uvec4.xx swizzling.
        /// </summary>
        public uvec2 xx => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec4.rr swizzling (equivalent to uvec4.xx).
        /// </summary>
        public uvec2 rr => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec4.xxx swizzling.
        /// </summary>
        public uvec3 xxx => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec4.rrr swizzling (equivalent to uvec4.xxx).
        /// </summary>
        public uvec3 rrr => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec4.xxxx swizzling.
        /// </summary>
        public uvec4 xxxx => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.rrrr swizzling (equivalent to uvec4.xxxx).
        /// </summary>
        public uvec4 rrrr => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.xxxy swizzling.
        /// </summary>
        public uvec4 xxxy => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.rrrg swizzling (equivalent to uvec4.xxxy).
        /// </summary>
        public uvec4 rrrg => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.xxxz swizzling.
        /// </summary>
        public uvec4 xxxz => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.rrrb swizzling (equivalent to uvec4.xxxz).
        /// </summary>
        public uvec4 rrrb => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.xxxw swizzling.
        /// </summary>
        public uvec4 xxxw => new uvec4(x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.rrra swizzling (equivalent to uvec4.xxxw).
        /// </summary>
        public uvec4 rrra => new uvec4(x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.xxy swizzling.
        /// </summary>
        public uvec3 xxy => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec4.rrg swizzling (equivalent to uvec4.xxy).
        /// </summary>
        public uvec3 rrg => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec4.xxyx swizzling.
        /// </summary>
        public uvec4 xxyx => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.rrgr swizzling (equivalent to uvec4.xxyx).
        /// </summary>
        public uvec4 rrgr => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.xxyy swizzling.
        /// </summary>
        public uvec4 xxyy => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.rrgg swizzling (equivalent to uvec4.xxyy).
        /// </summary>
        public uvec4 rrgg => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.xxyz swizzling.
        /// </summary>
        public uvec4 xxyz => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.rrgb swizzling (equivalent to uvec4.xxyz).
        /// </summary>
        public uvec4 rrgb => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.xxyw swizzling.
        /// </summary>
        public uvec4 xxyw => new uvec4(x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.rrga swizzling (equivalent to uvec4.xxyw).
        /// </summary>
        public uvec4 rrga => new uvec4(x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.xxz swizzling.
        /// </summary>
        public uvec3 xxz => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec4.rrb swizzling (equivalent to uvec4.xxz).
        /// </summary>
        public uvec3 rrb => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec4.xxzx swizzling.
        /// </summary>
        public uvec4 xxzx => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.rrbr swizzling (equivalent to uvec4.xxzx).
        /// </summary>
        public uvec4 rrbr => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.xxzy swizzling.
        /// </summary>
        public uvec4 xxzy => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.rrbg swizzling (equivalent to uvec4.xxzy).
        /// </summary>
        public uvec4 rrbg => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.xxzz swizzling.
        /// </summary>
        public uvec4 xxzz => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.rrbb swizzling (equivalent to uvec4.xxzz).
        /// </summary>
        public uvec4 rrbb => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.xxzw swizzling.
        /// </summary>
        public uvec4 xxzw => new uvec4(x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.rrba swizzling (equivalent to uvec4.xxzw).
        /// </summary>
        public uvec4 rrba => new uvec4(x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.xxw swizzling.
        /// </summary>
        public uvec3 xxw => new uvec3(x, x, w);
        
        /// <summary>
        /// Returns uvec4.rra swizzling (equivalent to uvec4.xxw).
        /// </summary>
        public uvec3 rra => new uvec3(x, x, w);
        
        /// <summary>
        /// Returns uvec4.xxwx swizzling.
        /// </summary>
        public uvec4 xxwx => new uvec4(x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.rrar swizzling (equivalent to uvec4.xxwx).
        /// </summary>
        public uvec4 rrar => new uvec4(x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.xxwy swizzling.
        /// </summary>
        public uvec4 xxwy => new uvec4(x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.rrag swizzling (equivalent to uvec4.xxwy).
        /// </summary>
        public uvec4 rrag => new uvec4(x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.xxwz swizzling.
        /// </summary>
        public uvec4 xxwz => new uvec4(x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.rrab swizzling (equivalent to uvec4.xxwz).
        /// </summary>
        public uvec4 rrab => new uvec4(x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.xxww swizzling.
        /// </summary>
        public uvec4 xxww => new uvec4(x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.rraa swizzling (equivalent to uvec4.xxww).
        /// </summary>
        public uvec4 rraa => new uvec4(x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.xy swizzling.
        /// </summary>
        public uvec2 xy => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec4.rg swizzling (equivalent to uvec4.xy).
        /// </summary>
        public uvec2 rg => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec4.xyx swizzling.
        /// </summary>
        public uvec3 xyx => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec4.rgr swizzling (equivalent to uvec4.xyx).
        /// </summary>
        public uvec3 rgr => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec4.xyxx swizzling.
        /// </summary>
        public uvec4 xyxx => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.rgrr swizzling (equivalent to uvec4.xyxx).
        /// </summary>
        public uvec4 rgrr => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.xyxy swizzling.
        /// </summary>
        public uvec4 xyxy => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.rgrg swizzling (equivalent to uvec4.xyxy).
        /// </summary>
        public uvec4 rgrg => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.xyxz swizzling.
        /// </summary>
        public uvec4 xyxz => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.rgrb swizzling (equivalent to uvec4.xyxz).
        /// </summary>
        public uvec4 rgrb => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.xyxw swizzling.
        /// </summary>
        public uvec4 xyxw => new uvec4(x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.rgra swizzling (equivalent to uvec4.xyxw).
        /// </summary>
        public uvec4 rgra => new uvec4(x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.xyy swizzling.
        /// </summary>
        public uvec3 xyy => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec4.rgg swizzling (equivalent to uvec4.xyy).
        /// </summary>
        public uvec3 rgg => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec4.xyyx swizzling.
        /// </summary>
        public uvec4 xyyx => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.rggr swizzling (equivalent to uvec4.xyyx).
        /// </summary>
        public uvec4 rggr => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.xyyy swizzling.
        /// </summary>
        public uvec4 xyyy => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.rggg swizzling (equivalent to uvec4.xyyy).
        /// </summary>
        public uvec4 rggg => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.xyyz swizzling.
        /// </summary>
        public uvec4 xyyz => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.rggb swizzling (equivalent to uvec4.xyyz).
        /// </summary>
        public uvec4 rggb => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.xyyw swizzling.
        /// </summary>
        public uvec4 xyyw => new uvec4(x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.rgga swizzling (equivalent to uvec4.xyyw).
        /// </summary>
        public uvec4 rgga => new uvec4(x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.xyz swizzling.
        /// </summary>
        public uvec3 xyz => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec4.rgb swizzling (equivalent to uvec4.xyz).
        /// </summary>
        public uvec3 rgb => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec4.xyzx swizzling.
        /// </summary>
        public uvec4 xyzx => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.rgbr swizzling (equivalent to uvec4.xyzx).
        /// </summary>
        public uvec4 rgbr => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.xyzy swizzling.
        /// </summary>
        public uvec4 xyzy => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.rgbg swizzling (equivalent to uvec4.xyzy).
        /// </summary>
        public uvec4 rgbg => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.xyzz swizzling.
        /// </summary>
        public uvec4 xyzz => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.rgbb swizzling (equivalent to uvec4.xyzz).
        /// </summary>
        public uvec4 rgbb => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.xyzw swizzling.
        /// </summary>
        public uvec4 xyzw => new uvec4(x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.rgba swizzling (equivalent to uvec4.xyzw).
        /// </summary>
        public uvec4 rgba => new uvec4(x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.xyw swizzling.
        /// </summary>
        public uvec3 xyw => new uvec3(x, y, w);
        
        /// <summary>
        /// Returns uvec4.rga swizzling (equivalent to uvec4.xyw).
        /// </summary>
        public uvec3 rga => new uvec3(x, y, w);
        
        /// <summary>
        /// Returns uvec4.xywx swizzling.
        /// </summary>
        public uvec4 xywx => new uvec4(x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.rgar swizzling (equivalent to uvec4.xywx).
        /// </summary>
        public uvec4 rgar => new uvec4(x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.xywy swizzling.
        /// </summary>
        public uvec4 xywy => new uvec4(x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.rgag swizzling (equivalent to uvec4.xywy).
        /// </summary>
        public uvec4 rgag => new uvec4(x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.xywz swizzling.
        /// </summary>
        public uvec4 xywz => new uvec4(x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.rgab swizzling (equivalent to uvec4.xywz).
        /// </summary>
        public uvec4 rgab => new uvec4(x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.xyww swizzling.
        /// </summary>
        public uvec4 xyww => new uvec4(x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.rgaa swizzling (equivalent to uvec4.xyww).
        /// </summary>
        public uvec4 rgaa => new uvec4(x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.xz swizzling.
        /// </summary>
        public uvec2 xz => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec4.rb swizzling (equivalent to uvec4.xz).
        /// </summary>
        public uvec2 rb => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec4.xzx swizzling.
        /// </summary>
        public uvec3 xzx => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec4.rbr swizzling (equivalent to uvec4.xzx).
        /// </summary>
        public uvec3 rbr => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec4.xzxx swizzling.
        /// </summary>
        public uvec4 xzxx => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.rbrr swizzling (equivalent to uvec4.xzxx).
        /// </summary>
        public uvec4 rbrr => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.xzxy swizzling.
        /// </summary>
        public uvec4 xzxy => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.rbrg swizzling (equivalent to uvec4.xzxy).
        /// </summary>
        public uvec4 rbrg => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.xzxz swizzling.
        /// </summary>
        public uvec4 xzxz => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.rbrb swizzling (equivalent to uvec4.xzxz).
        /// </summary>
        public uvec4 rbrb => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.xzxw swizzling.
        /// </summary>
        public uvec4 xzxw => new uvec4(x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.rbra swizzling (equivalent to uvec4.xzxw).
        /// </summary>
        public uvec4 rbra => new uvec4(x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.xzy swizzling.
        /// </summary>
        public uvec3 xzy => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec4.rbg swizzling (equivalent to uvec4.xzy).
        /// </summary>
        public uvec3 rbg => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec4.xzyx swizzling.
        /// </summary>
        public uvec4 xzyx => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.rbgr swizzling (equivalent to uvec4.xzyx).
        /// </summary>
        public uvec4 rbgr => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.xzyy swizzling.
        /// </summary>
        public uvec4 xzyy => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.rbgg swizzling (equivalent to uvec4.xzyy).
        /// </summary>
        public uvec4 rbgg => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.xzyz swizzling.
        /// </summary>
        public uvec4 xzyz => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.rbgb swizzling (equivalent to uvec4.xzyz).
        /// </summary>
        public uvec4 rbgb => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.xzyw swizzling.
        /// </summary>
        public uvec4 xzyw => new uvec4(x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.rbga swizzling (equivalent to uvec4.xzyw).
        /// </summary>
        public uvec4 rbga => new uvec4(x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.xzz swizzling.
        /// </summary>
        public uvec3 xzz => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec4.rbb swizzling (equivalent to uvec4.xzz).
        /// </summary>
        public uvec3 rbb => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec4.xzzx swizzling.
        /// </summary>
        public uvec4 xzzx => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.rbbr swizzling (equivalent to uvec4.xzzx).
        /// </summary>
        public uvec4 rbbr => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.xzzy swizzling.
        /// </summary>
        public uvec4 xzzy => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.rbbg swizzling (equivalent to uvec4.xzzy).
        /// </summary>
        public uvec4 rbbg => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.xzzz swizzling.
        /// </summary>
        public uvec4 xzzz => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.rbbb swizzling (equivalent to uvec4.xzzz).
        /// </summary>
        public uvec4 rbbb => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.xzzw swizzling.
        /// </summary>
        public uvec4 xzzw => new uvec4(x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.rbba swizzling (equivalent to uvec4.xzzw).
        /// </summary>
        public uvec4 rbba => new uvec4(x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.xzw swizzling.
        /// </summary>
        public uvec3 xzw => new uvec3(x, z, w);
        
        /// <summary>
        /// Returns uvec4.rba swizzling (equivalent to uvec4.xzw).
        /// </summary>
        public uvec3 rba => new uvec3(x, z, w);
        
        /// <summary>
        /// Returns uvec4.xzwx swizzling.
        /// </summary>
        public uvec4 xzwx => new uvec4(x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.rbar swizzling (equivalent to uvec4.xzwx).
        /// </summary>
        public uvec4 rbar => new uvec4(x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.xzwy swizzling.
        /// </summary>
        public uvec4 xzwy => new uvec4(x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.rbag swizzling (equivalent to uvec4.xzwy).
        /// </summary>
        public uvec4 rbag => new uvec4(x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.xzwz swizzling.
        /// </summary>
        public uvec4 xzwz => new uvec4(x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.rbab swizzling (equivalent to uvec4.xzwz).
        /// </summary>
        public uvec4 rbab => new uvec4(x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.xzww swizzling.
        /// </summary>
        public uvec4 xzww => new uvec4(x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.rbaa swizzling (equivalent to uvec4.xzww).
        /// </summary>
        public uvec4 rbaa => new uvec4(x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.xw swizzling.
        /// </summary>
        public uvec2 xw => new uvec2(x, w);
        
        /// <summary>
        /// Returns uvec4.ra swizzling (equivalent to uvec4.xw).
        /// </summary>
        public uvec2 ra => new uvec2(x, w);
        
        /// <summary>
        /// Returns uvec4.xwx swizzling.
        /// </summary>
        public uvec3 xwx => new uvec3(x, w, x);
        
        /// <summary>
        /// Returns uvec4.rar swizzling (equivalent to uvec4.xwx).
        /// </summary>
        public uvec3 rar => new uvec3(x, w, x);
        
        /// <summary>
        /// Returns uvec4.xwxx swizzling.
        /// </summary>
        public uvec4 xwxx => new uvec4(x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.rarr swizzling (equivalent to uvec4.xwxx).
        /// </summary>
        public uvec4 rarr => new uvec4(x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.xwxy swizzling.
        /// </summary>
        public uvec4 xwxy => new uvec4(x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.rarg swizzling (equivalent to uvec4.xwxy).
        /// </summary>
        public uvec4 rarg => new uvec4(x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.xwxz swizzling.
        /// </summary>
        public uvec4 xwxz => new uvec4(x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.rarb swizzling (equivalent to uvec4.xwxz).
        /// </summary>
        public uvec4 rarb => new uvec4(x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.xwxw swizzling.
        /// </summary>
        public uvec4 xwxw => new uvec4(x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.rara swizzling (equivalent to uvec4.xwxw).
        /// </summary>
        public uvec4 rara => new uvec4(x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.xwy swizzling.
        /// </summary>
        public uvec3 xwy => new uvec3(x, w, y);
        
        /// <summary>
        /// Returns uvec4.rag swizzling (equivalent to uvec4.xwy).
        /// </summary>
        public uvec3 rag => new uvec3(x, w, y);
        
        /// <summary>
        /// Returns uvec4.xwyx swizzling.
        /// </summary>
        public uvec4 xwyx => new uvec4(x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.ragr swizzling (equivalent to uvec4.xwyx).
        /// </summary>
        public uvec4 ragr => new uvec4(x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.xwyy swizzling.
        /// </summary>
        public uvec4 xwyy => new uvec4(x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.ragg swizzling (equivalent to uvec4.xwyy).
        /// </summary>
        public uvec4 ragg => new uvec4(x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.xwyz swizzling.
        /// </summary>
        public uvec4 xwyz => new uvec4(x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.ragb swizzling (equivalent to uvec4.xwyz).
        /// </summary>
        public uvec4 ragb => new uvec4(x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.xwyw swizzling.
        /// </summary>
        public uvec4 xwyw => new uvec4(x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.raga swizzling (equivalent to uvec4.xwyw).
        /// </summary>
        public uvec4 raga => new uvec4(x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.xwz swizzling.
        /// </summary>
        public uvec3 xwz => new uvec3(x, w, z);
        
        /// <summary>
        /// Returns uvec4.rab swizzling (equivalent to uvec4.xwz).
        /// </summary>
        public uvec3 rab => new uvec3(x, w, z);
        
        /// <summary>
        /// Returns uvec4.xwzx swizzling.
        /// </summary>
        public uvec4 xwzx => new uvec4(x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.rabr swizzling (equivalent to uvec4.xwzx).
        /// </summary>
        public uvec4 rabr => new uvec4(x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.xwzy swizzling.
        /// </summary>
        public uvec4 xwzy => new uvec4(x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.rabg swizzling (equivalent to uvec4.xwzy).
        /// </summary>
        public uvec4 rabg => new uvec4(x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.xwzz swizzling.
        /// </summary>
        public uvec4 xwzz => new uvec4(x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.rabb swizzling (equivalent to uvec4.xwzz).
        /// </summary>
        public uvec4 rabb => new uvec4(x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.xwzw swizzling.
        /// </summary>
        public uvec4 xwzw => new uvec4(x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.raba swizzling (equivalent to uvec4.xwzw).
        /// </summary>
        public uvec4 raba => new uvec4(x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.xww swizzling.
        /// </summary>
        public uvec3 xww => new uvec3(x, w, w);
        
        /// <summary>
        /// Returns uvec4.raa swizzling (equivalent to uvec4.xww).
        /// </summary>
        public uvec3 raa => new uvec3(x, w, w);
        
        /// <summary>
        /// Returns uvec4.xwwx swizzling.
        /// </summary>
        public uvec4 xwwx => new uvec4(x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.raar swizzling (equivalent to uvec4.xwwx).
        /// </summary>
        public uvec4 raar => new uvec4(x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.xwwy swizzling.
        /// </summary>
        public uvec4 xwwy => new uvec4(x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.raag swizzling (equivalent to uvec4.xwwy).
        /// </summary>
        public uvec4 raag => new uvec4(x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.xwwz swizzling.
        /// </summary>
        public uvec4 xwwz => new uvec4(x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.raab swizzling (equivalent to uvec4.xwwz).
        /// </summary>
        public uvec4 raab => new uvec4(x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.xwww swizzling.
        /// </summary>
        public uvec4 xwww => new uvec4(x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.raaa swizzling (equivalent to uvec4.xwww).
        /// </summary>
        public uvec4 raaa => new uvec4(x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.yx swizzling.
        /// </summary>
        public uvec2 yx => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec4.gr swizzling (equivalent to uvec4.yx).
        /// </summary>
        public uvec2 gr => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec4.yxx swizzling.
        /// </summary>
        public uvec3 yxx => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec4.grr swizzling (equivalent to uvec4.yxx).
        /// </summary>
        public uvec3 grr => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec4.yxxx swizzling.
        /// </summary>
        public uvec4 yxxx => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.grrr swizzling (equivalent to uvec4.yxxx).
        /// </summary>
        public uvec4 grrr => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.yxxy swizzling.
        /// </summary>
        public uvec4 yxxy => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.grrg swizzling (equivalent to uvec4.yxxy).
        /// </summary>
        public uvec4 grrg => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.yxxz swizzling.
        /// </summary>
        public uvec4 yxxz => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.grrb swizzling (equivalent to uvec4.yxxz).
        /// </summary>
        public uvec4 grrb => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.yxxw swizzling.
        /// </summary>
        public uvec4 yxxw => new uvec4(y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.grra swizzling (equivalent to uvec4.yxxw).
        /// </summary>
        public uvec4 grra => new uvec4(y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.yxy swizzling.
        /// </summary>
        public uvec3 yxy => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec4.grg swizzling (equivalent to uvec4.yxy).
        /// </summary>
        public uvec3 grg => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec4.yxyx swizzling.
        /// </summary>
        public uvec4 yxyx => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.grgr swizzling (equivalent to uvec4.yxyx).
        /// </summary>
        public uvec4 grgr => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.yxyy swizzling.
        /// </summary>
        public uvec4 yxyy => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.grgg swizzling (equivalent to uvec4.yxyy).
        /// </summary>
        public uvec4 grgg => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.yxyz swizzling.
        /// </summary>
        public uvec4 yxyz => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.grgb swizzling (equivalent to uvec4.yxyz).
        /// </summary>
        public uvec4 grgb => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.yxyw swizzling.
        /// </summary>
        public uvec4 yxyw => new uvec4(y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.grga swizzling (equivalent to uvec4.yxyw).
        /// </summary>
        public uvec4 grga => new uvec4(y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.yxz swizzling.
        /// </summary>
        public uvec3 yxz => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec4.grb swizzling (equivalent to uvec4.yxz).
        /// </summary>
        public uvec3 grb => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec4.yxzx swizzling.
        /// </summary>
        public uvec4 yxzx => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.grbr swizzling (equivalent to uvec4.yxzx).
        /// </summary>
        public uvec4 grbr => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.yxzy swizzling.
        /// </summary>
        public uvec4 yxzy => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.grbg swizzling (equivalent to uvec4.yxzy).
        /// </summary>
        public uvec4 grbg => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.yxzz swizzling.
        /// </summary>
        public uvec4 yxzz => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.grbb swizzling (equivalent to uvec4.yxzz).
        /// </summary>
        public uvec4 grbb => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.yxzw swizzling.
        /// </summary>
        public uvec4 yxzw => new uvec4(y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.grba swizzling (equivalent to uvec4.yxzw).
        /// </summary>
        public uvec4 grba => new uvec4(y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.yxw swizzling.
        /// </summary>
        public uvec3 yxw => new uvec3(y, x, w);
        
        /// <summary>
        /// Returns uvec4.gra swizzling (equivalent to uvec4.yxw).
        /// </summary>
        public uvec3 gra => new uvec3(y, x, w);
        
        /// <summary>
        /// Returns uvec4.yxwx swizzling.
        /// </summary>
        public uvec4 yxwx => new uvec4(y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.grar swizzling (equivalent to uvec4.yxwx).
        /// </summary>
        public uvec4 grar => new uvec4(y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.yxwy swizzling.
        /// </summary>
        public uvec4 yxwy => new uvec4(y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.grag swizzling (equivalent to uvec4.yxwy).
        /// </summary>
        public uvec4 grag => new uvec4(y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.yxwz swizzling.
        /// </summary>
        public uvec4 yxwz => new uvec4(y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.grab swizzling (equivalent to uvec4.yxwz).
        /// </summary>
        public uvec4 grab => new uvec4(y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.yxww swizzling.
        /// </summary>
        public uvec4 yxww => new uvec4(y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.graa swizzling (equivalent to uvec4.yxww).
        /// </summary>
        public uvec4 graa => new uvec4(y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.yy swizzling.
        /// </summary>
        public uvec2 yy => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec4.gg swizzling (equivalent to uvec4.yy).
        /// </summary>
        public uvec2 gg => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec4.yyx swizzling.
        /// </summary>
        public uvec3 yyx => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec4.ggr swizzling (equivalent to uvec4.yyx).
        /// </summary>
        public uvec3 ggr => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec4.yyxx swizzling.
        /// </summary>
        public uvec4 yyxx => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.ggrr swizzling (equivalent to uvec4.yyxx).
        /// </summary>
        public uvec4 ggrr => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.yyxy swizzling.
        /// </summary>
        public uvec4 yyxy => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.ggrg swizzling (equivalent to uvec4.yyxy).
        /// </summary>
        public uvec4 ggrg => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.yyxz swizzling.
        /// </summary>
        public uvec4 yyxz => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.ggrb swizzling (equivalent to uvec4.yyxz).
        /// </summary>
        public uvec4 ggrb => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.yyxw swizzling.
        /// </summary>
        public uvec4 yyxw => new uvec4(y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.ggra swizzling (equivalent to uvec4.yyxw).
        /// </summary>
        public uvec4 ggra => new uvec4(y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.yyy swizzling.
        /// </summary>
        public uvec3 yyy => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec4.ggg swizzling (equivalent to uvec4.yyy).
        /// </summary>
        public uvec3 ggg => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec4.yyyx swizzling.
        /// </summary>
        public uvec4 yyyx => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.gggr swizzling (equivalent to uvec4.yyyx).
        /// </summary>
        public uvec4 gggr => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.yyyy swizzling.
        /// </summary>
        public uvec4 yyyy => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.gggg swizzling (equivalent to uvec4.yyyy).
        /// </summary>
        public uvec4 gggg => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.yyyz swizzling.
        /// </summary>
        public uvec4 yyyz => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.gggb swizzling (equivalent to uvec4.yyyz).
        /// </summary>
        public uvec4 gggb => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.yyyw swizzling.
        /// </summary>
        public uvec4 yyyw => new uvec4(y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.ggga swizzling (equivalent to uvec4.yyyw).
        /// </summary>
        public uvec4 ggga => new uvec4(y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.yyz swizzling.
        /// </summary>
        public uvec3 yyz => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec4.ggb swizzling (equivalent to uvec4.yyz).
        /// </summary>
        public uvec3 ggb => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec4.yyzx swizzling.
        /// </summary>
        public uvec4 yyzx => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.ggbr swizzling (equivalent to uvec4.yyzx).
        /// </summary>
        public uvec4 ggbr => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.yyzy swizzling.
        /// </summary>
        public uvec4 yyzy => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.ggbg swizzling (equivalent to uvec4.yyzy).
        /// </summary>
        public uvec4 ggbg => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.yyzz swizzling.
        /// </summary>
        public uvec4 yyzz => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.ggbb swizzling (equivalent to uvec4.yyzz).
        /// </summary>
        public uvec4 ggbb => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.yyzw swizzling.
        /// </summary>
        public uvec4 yyzw => new uvec4(y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.ggba swizzling (equivalent to uvec4.yyzw).
        /// </summary>
        public uvec4 ggba => new uvec4(y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.yyw swizzling.
        /// </summary>
        public uvec3 yyw => new uvec3(y, y, w);
        
        /// <summary>
        /// Returns uvec4.gga swizzling (equivalent to uvec4.yyw).
        /// </summary>
        public uvec3 gga => new uvec3(y, y, w);
        
        /// <summary>
        /// Returns uvec4.yywx swizzling.
        /// </summary>
        public uvec4 yywx => new uvec4(y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.ggar swizzling (equivalent to uvec4.yywx).
        /// </summary>
        public uvec4 ggar => new uvec4(y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.yywy swizzling.
        /// </summary>
        public uvec4 yywy => new uvec4(y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.ggag swizzling (equivalent to uvec4.yywy).
        /// </summary>
        public uvec4 ggag => new uvec4(y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.yywz swizzling.
        /// </summary>
        public uvec4 yywz => new uvec4(y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.ggab swizzling (equivalent to uvec4.yywz).
        /// </summary>
        public uvec4 ggab => new uvec4(y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.yyww swizzling.
        /// </summary>
        public uvec4 yyww => new uvec4(y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.ggaa swizzling (equivalent to uvec4.yyww).
        /// </summary>
        public uvec4 ggaa => new uvec4(y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.yz swizzling.
        /// </summary>
        public uvec2 yz => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec4.gb swizzling (equivalent to uvec4.yz).
        /// </summary>
        public uvec2 gb => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec4.yzx swizzling.
        /// </summary>
        public uvec3 yzx => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec4.gbr swizzling (equivalent to uvec4.yzx).
        /// </summary>
        public uvec3 gbr => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec4.yzxx swizzling.
        /// </summary>
        public uvec4 yzxx => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.gbrr swizzling (equivalent to uvec4.yzxx).
        /// </summary>
        public uvec4 gbrr => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.yzxy swizzling.
        /// </summary>
        public uvec4 yzxy => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.gbrg swizzling (equivalent to uvec4.yzxy).
        /// </summary>
        public uvec4 gbrg => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.yzxz swizzling.
        /// </summary>
        public uvec4 yzxz => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.gbrb swizzling (equivalent to uvec4.yzxz).
        /// </summary>
        public uvec4 gbrb => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.yzxw swizzling.
        /// </summary>
        public uvec4 yzxw => new uvec4(y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.gbra swizzling (equivalent to uvec4.yzxw).
        /// </summary>
        public uvec4 gbra => new uvec4(y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.yzy swizzling.
        /// </summary>
        public uvec3 yzy => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec4.gbg swizzling (equivalent to uvec4.yzy).
        /// </summary>
        public uvec3 gbg => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec4.yzyx swizzling.
        /// </summary>
        public uvec4 yzyx => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.gbgr swizzling (equivalent to uvec4.yzyx).
        /// </summary>
        public uvec4 gbgr => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.yzyy swizzling.
        /// </summary>
        public uvec4 yzyy => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.gbgg swizzling (equivalent to uvec4.yzyy).
        /// </summary>
        public uvec4 gbgg => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.yzyz swizzling.
        /// </summary>
        public uvec4 yzyz => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.gbgb swizzling (equivalent to uvec4.yzyz).
        /// </summary>
        public uvec4 gbgb => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.yzyw swizzling.
        /// </summary>
        public uvec4 yzyw => new uvec4(y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.gbga swizzling (equivalent to uvec4.yzyw).
        /// </summary>
        public uvec4 gbga => new uvec4(y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.yzz swizzling.
        /// </summary>
        public uvec3 yzz => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec4.gbb swizzling (equivalent to uvec4.yzz).
        /// </summary>
        public uvec3 gbb => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec4.yzzx swizzling.
        /// </summary>
        public uvec4 yzzx => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.gbbr swizzling (equivalent to uvec4.yzzx).
        /// </summary>
        public uvec4 gbbr => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.yzzy swizzling.
        /// </summary>
        public uvec4 yzzy => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.gbbg swizzling (equivalent to uvec4.yzzy).
        /// </summary>
        public uvec4 gbbg => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.yzzz swizzling.
        /// </summary>
        public uvec4 yzzz => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.gbbb swizzling (equivalent to uvec4.yzzz).
        /// </summary>
        public uvec4 gbbb => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.yzzw swizzling.
        /// </summary>
        public uvec4 yzzw => new uvec4(y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.gbba swizzling (equivalent to uvec4.yzzw).
        /// </summary>
        public uvec4 gbba => new uvec4(y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.yzw swizzling.
        /// </summary>
        public uvec3 yzw => new uvec3(y, z, w);
        
        /// <summary>
        /// Returns uvec4.gba swizzling (equivalent to uvec4.yzw).
        /// </summary>
        public uvec3 gba => new uvec3(y, z, w);
        
        /// <summary>
        /// Returns uvec4.yzwx swizzling.
        /// </summary>
        public uvec4 yzwx => new uvec4(y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.gbar swizzling (equivalent to uvec4.yzwx).
        /// </summary>
        public uvec4 gbar => new uvec4(y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.yzwy swizzling.
        /// </summary>
        public uvec4 yzwy => new uvec4(y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.gbag swizzling (equivalent to uvec4.yzwy).
        /// </summary>
        public uvec4 gbag => new uvec4(y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.yzwz swizzling.
        /// </summary>
        public uvec4 yzwz => new uvec4(y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.gbab swizzling (equivalent to uvec4.yzwz).
        /// </summary>
        public uvec4 gbab => new uvec4(y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.yzww swizzling.
        /// </summary>
        public uvec4 yzww => new uvec4(y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.gbaa swizzling (equivalent to uvec4.yzww).
        /// </summary>
        public uvec4 gbaa => new uvec4(y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.yw swizzling.
        /// </summary>
        public uvec2 yw => new uvec2(y, w);
        
        /// <summary>
        /// Returns uvec4.ga swizzling (equivalent to uvec4.yw).
        /// </summary>
        public uvec2 ga => new uvec2(y, w);
        
        /// <summary>
        /// Returns uvec4.ywx swizzling.
        /// </summary>
        public uvec3 ywx => new uvec3(y, w, x);
        
        /// <summary>
        /// Returns uvec4.gar swizzling (equivalent to uvec4.ywx).
        /// </summary>
        public uvec3 gar => new uvec3(y, w, x);
        
        /// <summary>
        /// Returns uvec4.ywxx swizzling.
        /// </summary>
        public uvec4 ywxx => new uvec4(y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.garr swizzling (equivalent to uvec4.ywxx).
        /// </summary>
        public uvec4 garr => new uvec4(y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.ywxy swizzling.
        /// </summary>
        public uvec4 ywxy => new uvec4(y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.garg swizzling (equivalent to uvec4.ywxy).
        /// </summary>
        public uvec4 garg => new uvec4(y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.ywxz swizzling.
        /// </summary>
        public uvec4 ywxz => new uvec4(y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.garb swizzling (equivalent to uvec4.ywxz).
        /// </summary>
        public uvec4 garb => new uvec4(y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.ywxw swizzling.
        /// </summary>
        public uvec4 ywxw => new uvec4(y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.gara swizzling (equivalent to uvec4.ywxw).
        /// </summary>
        public uvec4 gara => new uvec4(y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.ywy swizzling.
        /// </summary>
        public uvec3 ywy => new uvec3(y, w, y);
        
        /// <summary>
        /// Returns uvec4.gag swizzling (equivalent to uvec4.ywy).
        /// </summary>
        public uvec3 gag => new uvec3(y, w, y);
        
        /// <summary>
        /// Returns uvec4.ywyx swizzling.
        /// </summary>
        public uvec4 ywyx => new uvec4(y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.gagr swizzling (equivalent to uvec4.ywyx).
        /// </summary>
        public uvec4 gagr => new uvec4(y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.ywyy swizzling.
        /// </summary>
        public uvec4 ywyy => new uvec4(y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.gagg swizzling (equivalent to uvec4.ywyy).
        /// </summary>
        public uvec4 gagg => new uvec4(y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.ywyz swizzling.
        /// </summary>
        public uvec4 ywyz => new uvec4(y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.gagb swizzling (equivalent to uvec4.ywyz).
        /// </summary>
        public uvec4 gagb => new uvec4(y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.ywyw swizzling.
        /// </summary>
        public uvec4 ywyw => new uvec4(y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.gaga swizzling (equivalent to uvec4.ywyw).
        /// </summary>
        public uvec4 gaga => new uvec4(y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.ywz swizzling.
        /// </summary>
        public uvec3 ywz => new uvec3(y, w, z);
        
        /// <summary>
        /// Returns uvec4.gab swizzling (equivalent to uvec4.ywz).
        /// </summary>
        public uvec3 gab => new uvec3(y, w, z);
        
        /// <summary>
        /// Returns uvec4.ywzx swizzling.
        /// </summary>
        public uvec4 ywzx => new uvec4(y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.gabr swizzling (equivalent to uvec4.ywzx).
        /// </summary>
        public uvec4 gabr => new uvec4(y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.ywzy swizzling.
        /// </summary>
        public uvec4 ywzy => new uvec4(y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.gabg swizzling (equivalent to uvec4.ywzy).
        /// </summary>
        public uvec4 gabg => new uvec4(y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.ywzz swizzling.
        /// </summary>
        public uvec4 ywzz => new uvec4(y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.gabb swizzling (equivalent to uvec4.ywzz).
        /// </summary>
        public uvec4 gabb => new uvec4(y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.ywzw swizzling.
        /// </summary>
        public uvec4 ywzw => new uvec4(y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.gaba swizzling (equivalent to uvec4.ywzw).
        /// </summary>
        public uvec4 gaba => new uvec4(y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.yww swizzling.
        /// </summary>
        public uvec3 yww => new uvec3(y, w, w);
        
        /// <summary>
        /// Returns uvec4.gaa swizzling (equivalent to uvec4.yww).
        /// </summary>
        public uvec3 gaa => new uvec3(y, w, w);
        
        /// <summary>
        /// Returns uvec4.ywwx swizzling.
        /// </summary>
        public uvec4 ywwx => new uvec4(y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.gaar swizzling (equivalent to uvec4.ywwx).
        /// </summary>
        public uvec4 gaar => new uvec4(y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.ywwy swizzling.
        /// </summary>
        public uvec4 ywwy => new uvec4(y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.gaag swizzling (equivalent to uvec4.ywwy).
        /// </summary>
        public uvec4 gaag => new uvec4(y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.ywwz swizzling.
        /// </summary>
        public uvec4 ywwz => new uvec4(y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.gaab swizzling (equivalent to uvec4.ywwz).
        /// </summary>
        public uvec4 gaab => new uvec4(y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.ywww swizzling.
        /// </summary>
        public uvec4 ywww => new uvec4(y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.gaaa swizzling (equivalent to uvec4.ywww).
        /// </summary>
        public uvec4 gaaa => new uvec4(y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.zx swizzling.
        /// </summary>
        public uvec2 zx => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec4.br swizzling (equivalent to uvec4.zx).
        /// </summary>
        public uvec2 br => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec4.zxx swizzling.
        /// </summary>
        public uvec3 zxx => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec4.brr swizzling (equivalent to uvec4.zxx).
        /// </summary>
        public uvec3 brr => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec4.zxxx swizzling.
        /// </summary>
        public uvec4 zxxx => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.brrr swizzling (equivalent to uvec4.zxxx).
        /// </summary>
        public uvec4 brrr => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.zxxy swizzling.
        /// </summary>
        public uvec4 zxxy => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.brrg swizzling (equivalent to uvec4.zxxy).
        /// </summary>
        public uvec4 brrg => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.zxxz swizzling.
        /// </summary>
        public uvec4 zxxz => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.brrb swizzling (equivalent to uvec4.zxxz).
        /// </summary>
        public uvec4 brrb => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.zxxw swizzling.
        /// </summary>
        public uvec4 zxxw => new uvec4(z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.brra swizzling (equivalent to uvec4.zxxw).
        /// </summary>
        public uvec4 brra => new uvec4(z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.zxy swizzling.
        /// </summary>
        public uvec3 zxy => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec4.brg swizzling (equivalent to uvec4.zxy).
        /// </summary>
        public uvec3 brg => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec4.zxyx swizzling.
        /// </summary>
        public uvec4 zxyx => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.brgr swizzling (equivalent to uvec4.zxyx).
        /// </summary>
        public uvec4 brgr => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.zxyy swizzling.
        /// </summary>
        public uvec4 zxyy => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.brgg swizzling (equivalent to uvec4.zxyy).
        /// </summary>
        public uvec4 brgg => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.zxyz swizzling.
        /// </summary>
        public uvec4 zxyz => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.brgb swizzling (equivalent to uvec4.zxyz).
        /// </summary>
        public uvec4 brgb => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.zxyw swizzling.
        /// </summary>
        public uvec4 zxyw => new uvec4(z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.brga swizzling (equivalent to uvec4.zxyw).
        /// </summary>
        public uvec4 brga => new uvec4(z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.zxz swizzling.
        /// </summary>
        public uvec3 zxz => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec4.brb swizzling (equivalent to uvec4.zxz).
        /// </summary>
        public uvec3 brb => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec4.zxzx swizzling.
        /// </summary>
        public uvec4 zxzx => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.brbr swizzling (equivalent to uvec4.zxzx).
        /// </summary>
        public uvec4 brbr => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.zxzy swizzling.
        /// </summary>
        public uvec4 zxzy => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.brbg swizzling (equivalent to uvec4.zxzy).
        /// </summary>
        public uvec4 brbg => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.zxzz swizzling.
        /// </summary>
        public uvec4 zxzz => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.brbb swizzling (equivalent to uvec4.zxzz).
        /// </summary>
        public uvec4 brbb => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.zxzw swizzling.
        /// </summary>
        public uvec4 zxzw => new uvec4(z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.brba swizzling (equivalent to uvec4.zxzw).
        /// </summary>
        public uvec4 brba => new uvec4(z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.zxw swizzling.
        /// </summary>
        public uvec3 zxw => new uvec3(z, x, w);
        
        /// <summary>
        /// Returns uvec4.bra swizzling (equivalent to uvec4.zxw).
        /// </summary>
        public uvec3 bra => new uvec3(z, x, w);
        
        /// <summary>
        /// Returns uvec4.zxwx swizzling.
        /// </summary>
        public uvec4 zxwx => new uvec4(z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.brar swizzling (equivalent to uvec4.zxwx).
        /// </summary>
        public uvec4 brar => new uvec4(z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.zxwy swizzling.
        /// </summary>
        public uvec4 zxwy => new uvec4(z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.brag swizzling (equivalent to uvec4.zxwy).
        /// </summary>
        public uvec4 brag => new uvec4(z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.zxwz swizzling.
        /// </summary>
        public uvec4 zxwz => new uvec4(z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.brab swizzling (equivalent to uvec4.zxwz).
        /// </summary>
        public uvec4 brab => new uvec4(z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.zxww swizzling.
        /// </summary>
        public uvec4 zxww => new uvec4(z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.braa swizzling (equivalent to uvec4.zxww).
        /// </summary>
        public uvec4 braa => new uvec4(z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.zy swizzling.
        /// </summary>
        public uvec2 zy => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec4.bg swizzling (equivalent to uvec4.zy).
        /// </summary>
        public uvec2 bg => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec4.zyx swizzling.
        /// </summary>
        public uvec3 zyx => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec4.bgr swizzling (equivalent to uvec4.zyx).
        /// </summary>
        public uvec3 bgr => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec4.zyxx swizzling.
        /// </summary>
        public uvec4 zyxx => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.bgrr swizzling (equivalent to uvec4.zyxx).
        /// </summary>
        public uvec4 bgrr => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.zyxy swizzling.
        /// </summary>
        public uvec4 zyxy => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.bgrg swizzling (equivalent to uvec4.zyxy).
        /// </summary>
        public uvec4 bgrg => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.zyxz swizzling.
        /// </summary>
        public uvec4 zyxz => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.bgrb swizzling (equivalent to uvec4.zyxz).
        /// </summary>
        public uvec4 bgrb => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.zyxw swizzling.
        /// </summary>
        public uvec4 zyxw => new uvec4(z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.bgra swizzling (equivalent to uvec4.zyxw).
        /// </summary>
        public uvec4 bgra => new uvec4(z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.zyy swizzling.
        /// </summary>
        public uvec3 zyy => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec4.bgg swizzling (equivalent to uvec4.zyy).
        /// </summary>
        public uvec3 bgg => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec4.zyyx swizzling.
        /// </summary>
        public uvec4 zyyx => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.bggr swizzling (equivalent to uvec4.zyyx).
        /// </summary>
        public uvec4 bggr => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.zyyy swizzling.
        /// </summary>
        public uvec4 zyyy => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.bggg swizzling (equivalent to uvec4.zyyy).
        /// </summary>
        public uvec4 bggg => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.zyyz swizzling.
        /// </summary>
        public uvec4 zyyz => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.bggb swizzling (equivalent to uvec4.zyyz).
        /// </summary>
        public uvec4 bggb => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.zyyw swizzling.
        /// </summary>
        public uvec4 zyyw => new uvec4(z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.bgga swizzling (equivalent to uvec4.zyyw).
        /// </summary>
        public uvec4 bgga => new uvec4(z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.zyz swizzling.
        /// </summary>
        public uvec3 zyz => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec4.bgb swizzling (equivalent to uvec4.zyz).
        /// </summary>
        public uvec3 bgb => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec4.zyzx swizzling.
        /// </summary>
        public uvec4 zyzx => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.bgbr swizzling (equivalent to uvec4.zyzx).
        /// </summary>
        public uvec4 bgbr => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.zyzy swizzling.
        /// </summary>
        public uvec4 zyzy => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.bgbg swizzling (equivalent to uvec4.zyzy).
        /// </summary>
        public uvec4 bgbg => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.zyzz swizzling.
        /// </summary>
        public uvec4 zyzz => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.bgbb swizzling (equivalent to uvec4.zyzz).
        /// </summary>
        public uvec4 bgbb => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.zyzw swizzling.
        /// </summary>
        public uvec4 zyzw => new uvec4(z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.bgba swizzling (equivalent to uvec4.zyzw).
        /// </summary>
        public uvec4 bgba => new uvec4(z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.zyw swizzling.
        /// </summary>
        public uvec3 zyw => new uvec3(z, y, w);
        
        /// <summary>
        /// Returns uvec4.bga swizzling (equivalent to uvec4.zyw).
        /// </summary>
        public uvec3 bga => new uvec3(z, y, w);
        
        /// <summary>
        /// Returns uvec4.zywx swizzling.
        /// </summary>
        public uvec4 zywx => new uvec4(z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.bgar swizzling (equivalent to uvec4.zywx).
        /// </summary>
        public uvec4 bgar => new uvec4(z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.zywy swizzling.
        /// </summary>
        public uvec4 zywy => new uvec4(z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.bgag swizzling (equivalent to uvec4.zywy).
        /// </summary>
        public uvec4 bgag => new uvec4(z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.zywz swizzling.
        /// </summary>
        public uvec4 zywz => new uvec4(z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.bgab swizzling (equivalent to uvec4.zywz).
        /// </summary>
        public uvec4 bgab => new uvec4(z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.zyww swizzling.
        /// </summary>
        public uvec4 zyww => new uvec4(z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.bgaa swizzling (equivalent to uvec4.zyww).
        /// </summary>
        public uvec4 bgaa => new uvec4(z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.zz swizzling.
        /// </summary>
        public uvec2 zz => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec4.bb swizzling (equivalent to uvec4.zz).
        /// </summary>
        public uvec2 bb => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec4.zzx swizzling.
        /// </summary>
        public uvec3 zzx => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec4.bbr swizzling (equivalent to uvec4.zzx).
        /// </summary>
        public uvec3 bbr => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec4.zzxx swizzling.
        /// </summary>
        public uvec4 zzxx => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.bbrr swizzling (equivalent to uvec4.zzxx).
        /// </summary>
        public uvec4 bbrr => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.zzxy swizzling.
        /// </summary>
        public uvec4 zzxy => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.bbrg swizzling (equivalent to uvec4.zzxy).
        /// </summary>
        public uvec4 bbrg => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.zzxz swizzling.
        /// </summary>
        public uvec4 zzxz => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.bbrb swizzling (equivalent to uvec4.zzxz).
        /// </summary>
        public uvec4 bbrb => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.zzxw swizzling.
        /// </summary>
        public uvec4 zzxw => new uvec4(z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.bbra swizzling (equivalent to uvec4.zzxw).
        /// </summary>
        public uvec4 bbra => new uvec4(z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.zzy swizzling.
        /// </summary>
        public uvec3 zzy => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec4.bbg swizzling (equivalent to uvec4.zzy).
        /// </summary>
        public uvec3 bbg => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec4.zzyx swizzling.
        /// </summary>
        public uvec4 zzyx => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.bbgr swizzling (equivalent to uvec4.zzyx).
        /// </summary>
        public uvec4 bbgr => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.zzyy swizzling.
        /// </summary>
        public uvec4 zzyy => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.bbgg swizzling (equivalent to uvec4.zzyy).
        /// </summary>
        public uvec4 bbgg => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.zzyz swizzling.
        /// </summary>
        public uvec4 zzyz => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.bbgb swizzling (equivalent to uvec4.zzyz).
        /// </summary>
        public uvec4 bbgb => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.zzyw swizzling.
        /// </summary>
        public uvec4 zzyw => new uvec4(z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.bbga swizzling (equivalent to uvec4.zzyw).
        /// </summary>
        public uvec4 bbga => new uvec4(z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.zzz swizzling.
        /// </summary>
        public uvec3 zzz => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec4.bbb swizzling (equivalent to uvec4.zzz).
        /// </summary>
        public uvec3 bbb => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec4.zzzx swizzling.
        /// </summary>
        public uvec4 zzzx => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.bbbr swizzling (equivalent to uvec4.zzzx).
        /// </summary>
        public uvec4 bbbr => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.zzzy swizzling.
        /// </summary>
        public uvec4 zzzy => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.bbbg swizzling (equivalent to uvec4.zzzy).
        /// </summary>
        public uvec4 bbbg => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.zzzz swizzling.
        /// </summary>
        public uvec4 zzzz => new uvec4(z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.bbbb swizzling (equivalent to uvec4.zzzz).
        /// </summary>
        public uvec4 bbbb => new uvec4(z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.zzzw swizzling.
        /// </summary>
        public uvec4 zzzw => new uvec4(z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.bbba swizzling (equivalent to uvec4.zzzw).
        /// </summary>
        public uvec4 bbba => new uvec4(z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.zzw swizzling.
        /// </summary>
        public uvec3 zzw => new uvec3(z, z, w);
        
        /// <summary>
        /// Returns uvec4.bba swizzling (equivalent to uvec4.zzw).
        /// </summary>
        public uvec3 bba => new uvec3(z, z, w);
        
        /// <summary>
        /// Returns uvec4.zzwx swizzling.
        /// </summary>
        public uvec4 zzwx => new uvec4(z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.bbar swizzling (equivalent to uvec4.zzwx).
        /// </summary>
        public uvec4 bbar => new uvec4(z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.zzwy swizzling.
        /// </summary>
        public uvec4 zzwy => new uvec4(z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.bbag swizzling (equivalent to uvec4.zzwy).
        /// </summary>
        public uvec4 bbag => new uvec4(z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.zzwz swizzling.
        /// </summary>
        public uvec4 zzwz => new uvec4(z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.bbab swizzling (equivalent to uvec4.zzwz).
        /// </summary>
        public uvec4 bbab => new uvec4(z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.zzww swizzling.
        /// </summary>
        public uvec4 zzww => new uvec4(z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.bbaa swizzling (equivalent to uvec4.zzww).
        /// </summary>
        public uvec4 bbaa => new uvec4(z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.zw swizzling.
        /// </summary>
        public uvec2 zw => new uvec2(z, w);
        
        /// <summary>
        /// Returns uvec4.ba swizzling (equivalent to uvec4.zw).
        /// </summary>
        public uvec2 ba => new uvec2(z, w);
        
        /// <summary>
        /// Returns uvec4.zwx swizzling.
        /// </summary>
        public uvec3 zwx => new uvec3(z, w, x);
        
        /// <summary>
        /// Returns uvec4.bar swizzling (equivalent to uvec4.zwx).
        /// </summary>
        public uvec3 bar => new uvec3(z, w, x);
        
        /// <summary>
        /// Returns uvec4.zwxx swizzling.
        /// </summary>
        public uvec4 zwxx => new uvec4(z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.barr swizzling (equivalent to uvec4.zwxx).
        /// </summary>
        public uvec4 barr => new uvec4(z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.zwxy swizzling.
        /// </summary>
        public uvec4 zwxy => new uvec4(z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.barg swizzling (equivalent to uvec4.zwxy).
        /// </summary>
        public uvec4 barg => new uvec4(z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.zwxz swizzling.
        /// </summary>
        public uvec4 zwxz => new uvec4(z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.barb swizzling (equivalent to uvec4.zwxz).
        /// </summary>
        public uvec4 barb => new uvec4(z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.zwxw swizzling.
        /// </summary>
        public uvec4 zwxw => new uvec4(z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.bara swizzling (equivalent to uvec4.zwxw).
        /// </summary>
        public uvec4 bara => new uvec4(z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.zwy swizzling.
        /// </summary>
        public uvec3 zwy => new uvec3(z, w, y);
        
        /// <summary>
        /// Returns uvec4.bag swizzling (equivalent to uvec4.zwy).
        /// </summary>
        public uvec3 bag => new uvec3(z, w, y);
        
        /// <summary>
        /// Returns uvec4.zwyx swizzling.
        /// </summary>
        public uvec4 zwyx => new uvec4(z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.bagr swizzling (equivalent to uvec4.zwyx).
        /// </summary>
        public uvec4 bagr => new uvec4(z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.zwyy swizzling.
        /// </summary>
        public uvec4 zwyy => new uvec4(z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.bagg swizzling (equivalent to uvec4.zwyy).
        /// </summary>
        public uvec4 bagg => new uvec4(z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.zwyz swizzling.
        /// </summary>
        public uvec4 zwyz => new uvec4(z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.bagb swizzling (equivalent to uvec4.zwyz).
        /// </summary>
        public uvec4 bagb => new uvec4(z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.zwyw swizzling.
        /// </summary>
        public uvec4 zwyw => new uvec4(z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.baga swizzling (equivalent to uvec4.zwyw).
        /// </summary>
        public uvec4 baga => new uvec4(z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.zwz swizzling.
        /// </summary>
        public uvec3 zwz => new uvec3(z, w, z);
        
        /// <summary>
        /// Returns uvec4.bab swizzling (equivalent to uvec4.zwz).
        /// </summary>
        public uvec3 bab => new uvec3(z, w, z);
        
        /// <summary>
        /// Returns uvec4.zwzx swizzling.
        /// </summary>
        public uvec4 zwzx => new uvec4(z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.babr swizzling (equivalent to uvec4.zwzx).
        /// </summary>
        public uvec4 babr => new uvec4(z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.zwzy swizzling.
        /// </summary>
        public uvec4 zwzy => new uvec4(z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.babg swizzling (equivalent to uvec4.zwzy).
        /// </summary>
        public uvec4 babg => new uvec4(z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.zwzz swizzling.
        /// </summary>
        public uvec4 zwzz => new uvec4(z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.babb swizzling (equivalent to uvec4.zwzz).
        /// </summary>
        public uvec4 babb => new uvec4(z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.zwzw swizzling.
        /// </summary>
        public uvec4 zwzw => new uvec4(z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.baba swizzling (equivalent to uvec4.zwzw).
        /// </summary>
        public uvec4 baba => new uvec4(z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.zww swizzling.
        /// </summary>
        public uvec3 zww => new uvec3(z, w, w);
        
        /// <summary>
        /// Returns uvec4.baa swizzling (equivalent to uvec4.zww).
        /// </summary>
        public uvec3 baa => new uvec3(z, w, w);
        
        /// <summary>
        /// Returns uvec4.zwwx swizzling.
        /// </summary>
        public uvec4 zwwx => new uvec4(z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.baar swizzling (equivalent to uvec4.zwwx).
        /// </summary>
        public uvec4 baar => new uvec4(z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.zwwy swizzling.
        /// </summary>
        public uvec4 zwwy => new uvec4(z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.baag swizzling (equivalent to uvec4.zwwy).
        /// </summary>
        public uvec4 baag => new uvec4(z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.zwwz swizzling.
        /// </summary>
        public uvec4 zwwz => new uvec4(z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.baab swizzling (equivalent to uvec4.zwwz).
        /// </summary>
        public uvec4 baab => new uvec4(z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.zwww swizzling.
        /// </summary>
        public uvec4 zwww => new uvec4(z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.baaa swizzling (equivalent to uvec4.zwww).
        /// </summary>
        public uvec4 baaa => new uvec4(z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.wx swizzling.
        /// </summary>
        public uvec2 wx => new uvec2(w, x);
        
        /// <summary>
        /// Returns uvec4.ar swizzling (equivalent to uvec4.wx).
        /// </summary>
        public uvec2 ar => new uvec2(w, x);
        
        /// <summary>
        /// Returns uvec4.wxx swizzling.
        /// </summary>
        public uvec3 wxx => new uvec3(w, x, x);
        
        /// <summary>
        /// Returns uvec4.arr swizzling (equivalent to uvec4.wxx).
        /// </summary>
        public uvec3 arr => new uvec3(w, x, x);
        
        /// <summary>
        /// Returns uvec4.wxxx swizzling.
        /// </summary>
        public uvec4 wxxx => new uvec4(w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.arrr swizzling (equivalent to uvec4.wxxx).
        /// </summary>
        public uvec4 arrr => new uvec4(w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.wxxy swizzling.
        /// </summary>
        public uvec4 wxxy => new uvec4(w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.arrg swizzling (equivalent to uvec4.wxxy).
        /// </summary>
        public uvec4 arrg => new uvec4(w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.wxxz swizzling.
        /// </summary>
        public uvec4 wxxz => new uvec4(w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.arrb swizzling (equivalent to uvec4.wxxz).
        /// </summary>
        public uvec4 arrb => new uvec4(w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.wxxw swizzling.
        /// </summary>
        public uvec4 wxxw => new uvec4(w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.arra swizzling (equivalent to uvec4.wxxw).
        /// </summary>
        public uvec4 arra => new uvec4(w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.wxy swizzling.
        /// </summary>
        public uvec3 wxy => new uvec3(w, x, y);
        
        /// <summary>
        /// Returns uvec4.arg swizzling (equivalent to uvec4.wxy).
        /// </summary>
        public uvec3 arg => new uvec3(w, x, y);
        
        /// <summary>
        /// Returns uvec4.wxyx swizzling.
        /// </summary>
        public uvec4 wxyx => new uvec4(w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.argr swizzling (equivalent to uvec4.wxyx).
        /// </summary>
        public uvec4 argr => new uvec4(w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.wxyy swizzling.
        /// </summary>
        public uvec4 wxyy => new uvec4(w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.argg swizzling (equivalent to uvec4.wxyy).
        /// </summary>
        public uvec4 argg => new uvec4(w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.wxyz swizzling.
        /// </summary>
        public uvec4 wxyz => new uvec4(w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.argb swizzling (equivalent to uvec4.wxyz).
        /// </summary>
        public uvec4 argb => new uvec4(w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.wxyw swizzling.
        /// </summary>
        public uvec4 wxyw => new uvec4(w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.arga swizzling (equivalent to uvec4.wxyw).
        /// </summary>
        public uvec4 arga => new uvec4(w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.wxz swizzling.
        /// </summary>
        public uvec3 wxz => new uvec3(w, x, z);
        
        /// <summary>
        /// Returns uvec4.arb swizzling (equivalent to uvec4.wxz).
        /// </summary>
        public uvec3 arb => new uvec3(w, x, z);
        
        /// <summary>
        /// Returns uvec4.wxzx swizzling.
        /// </summary>
        public uvec4 wxzx => new uvec4(w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.arbr swizzling (equivalent to uvec4.wxzx).
        /// </summary>
        public uvec4 arbr => new uvec4(w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.wxzy swizzling.
        /// </summary>
        public uvec4 wxzy => new uvec4(w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.arbg swizzling (equivalent to uvec4.wxzy).
        /// </summary>
        public uvec4 arbg => new uvec4(w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.wxzz swizzling.
        /// </summary>
        public uvec4 wxzz => new uvec4(w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.arbb swizzling (equivalent to uvec4.wxzz).
        /// </summary>
        public uvec4 arbb => new uvec4(w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.wxzw swizzling.
        /// </summary>
        public uvec4 wxzw => new uvec4(w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.arba swizzling (equivalent to uvec4.wxzw).
        /// </summary>
        public uvec4 arba => new uvec4(w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.wxw swizzling.
        /// </summary>
        public uvec3 wxw => new uvec3(w, x, w);
        
        /// <summary>
        /// Returns uvec4.ara swizzling (equivalent to uvec4.wxw).
        /// </summary>
        public uvec3 ara => new uvec3(w, x, w);
        
        /// <summary>
        /// Returns uvec4.wxwx swizzling.
        /// </summary>
        public uvec4 wxwx => new uvec4(w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.arar swizzling (equivalent to uvec4.wxwx).
        /// </summary>
        public uvec4 arar => new uvec4(w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.wxwy swizzling.
        /// </summary>
        public uvec4 wxwy => new uvec4(w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.arag swizzling (equivalent to uvec4.wxwy).
        /// </summary>
        public uvec4 arag => new uvec4(w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.wxwz swizzling.
        /// </summary>
        public uvec4 wxwz => new uvec4(w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.arab swizzling (equivalent to uvec4.wxwz).
        /// </summary>
        public uvec4 arab => new uvec4(w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.wxww swizzling.
        /// </summary>
        public uvec4 wxww => new uvec4(w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.araa swizzling (equivalent to uvec4.wxww).
        /// </summary>
        public uvec4 araa => new uvec4(w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.wy swizzling.
        /// </summary>
        public uvec2 wy => new uvec2(w, y);
        
        /// <summary>
        /// Returns uvec4.ag swizzling (equivalent to uvec4.wy).
        /// </summary>
        public uvec2 ag => new uvec2(w, y);
        
        /// <summary>
        /// Returns uvec4.wyx swizzling.
        /// </summary>
        public uvec3 wyx => new uvec3(w, y, x);
        
        /// <summary>
        /// Returns uvec4.agr swizzling (equivalent to uvec4.wyx).
        /// </summary>
        public uvec3 agr => new uvec3(w, y, x);
        
        /// <summary>
        /// Returns uvec4.wyxx swizzling.
        /// </summary>
        public uvec4 wyxx => new uvec4(w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.agrr swizzling (equivalent to uvec4.wyxx).
        /// </summary>
        public uvec4 agrr => new uvec4(w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.wyxy swizzling.
        /// </summary>
        public uvec4 wyxy => new uvec4(w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.agrg swizzling (equivalent to uvec4.wyxy).
        /// </summary>
        public uvec4 agrg => new uvec4(w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.wyxz swizzling.
        /// </summary>
        public uvec4 wyxz => new uvec4(w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.agrb swizzling (equivalent to uvec4.wyxz).
        /// </summary>
        public uvec4 agrb => new uvec4(w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.wyxw swizzling.
        /// </summary>
        public uvec4 wyxw => new uvec4(w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.agra swizzling (equivalent to uvec4.wyxw).
        /// </summary>
        public uvec4 agra => new uvec4(w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.wyy swizzling.
        /// </summary>
        public uvec3 wyy => new uvec3(w, y, y);
        
        /// <summary>
        /// Returns uvec4.agg swizzling (equivalent to uvec4.wyy).
        /// </summary>
        public uvec3 agg => new uvec3(w, y, y);
        
        /// <summary>
        /// Returns uvec4.wyyx swizzling.
        /// </summary>
        public uvec4 wyyx => new uvec4(w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.aggr swizzling (equivalent to uvec4.wyyx).
        /// </summary>
        public uvec4 aggr => new uvec4(w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.wyyy swizzling.
        /// </summary>
        public uvec4 wyyy => new uvec4(w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.aggg swizzling (equivalent to uvec4.wyyy).
        /// </summary>
        public uvec4 aggg => new uvec4(w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.wyyz swizzling.
        /// </summary>
        public uvec4 wyyz => new uvec4(w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.aggb swizzling (equivalent to uvec4.wyyz).
        /// </summary>
        public uvec4 aggb => new uvec4(w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.wyyw swizzling.
        /// </summary>
        public uvec4 wyyw => new uvec4(w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.agga swizzling (equivalent to uvec4.wyyw).
        /// </summary>
        public uvec4 agga => new uvec4(w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.wyz swizzling.
        /// </summary>
        public uvec3 wyz => new uvec3(w, y, z);
        
        /// <summary>
        /// Returns uvec4.agb swizzling (equivalent to uvec4.wyz).
        /// </summary>
        public uvec3 agb => new uvec3(w, y, z);
        
        /// <summary>
        /// Returns uvec4.wyzx swizzling.
        /// </summary>
        public uvec4 wyzx => new uvec4(w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.agbr swizzling (equivalent to uvec4.wyzx).
        /// </summary>
        public uvec4 agbr => new uvec4(w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.wyzy swizzling.
        /// </summary>
        public uvec4 wyzy => new uvec4(w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.agbg swizzling (equivalent to uvec4.wyzy).
        /// </summary>
        public uvec4 agbg => new uvec4(w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.wyzz swizzling.
        /// </summary>
        public uvec4 wyzz => new uvec4(w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.agbb swizzling (equivalent to uvec4.wyzz).
        /// </summary>
        public uvec4 agbb => new uvec4(w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.wyzw swizzling.
        /// </summary>
        public uvec4 wyzw => new uvec4(w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.agba swizzling (equivalent to uvec4.wyzw).
        /// </summary>
        public uvec4 agba => new uvec4(w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.wyw swizzling.
        /// </summary>
        public uvec3 wyw => new uvec3(w, y, w);
        
        /// <summary>
        /// Returns uvec4.aga swizzling (equivalent to uvec4.wyw).
        /// </summary>
        public uvec3 aga => new uvec3(w, y, w);
        
        /// <summary>
        /// Returns uvec4.wywx swizzling.
        /// </summary>
        public uvec4 wywx => new uvec4(w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.agar swizzling (equivalent to uvec4.wywx).
        /// </summary>
        public uvec4 agar => new uvec4(w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.wywy swizzling.
        /// </summary>
        public uvec4 wywy => new uvec4(w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.agag swizzling (equivalent to uvec4.wywy).
        /// </summary>
        public uvec4 agag => new uvec4(w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.wywz swizzling.
        /// </summary>
        public uvec4 wywz => new uvec4(w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.agab swizzling (equivalent to uvec4.wywz).
        /// </summary>
        public uvec4 agab => new uvec4(w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.wyww swizzling.
        /// </summary>
        public uvec4 wyww => new uvec4(w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.agaa swizzling (equivalent to uvec4.wyww).
        /// </summary>
        public uvec4 agaa => new uvec4(w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.wz swizzling.
        /// </summary>
        public uvec2 wz => new uvec2(w, z);
        
        /// <summary>
        /// Returns uvec4.ab swizzling (equivalent to uvec4.wz).
        /// </summary>
        public uvec2 ab => new uvec2(w, z);
        
        /// <summary>
        /// Returns uvec4.wzx swizzling.
        /// </summary>
        public uvec3 wzx => new uvec3(w, z, x);
        
        /// <summary>
        /// Returns uvec4.abr swizzling (equivalent to uvec4.wzx).
        /// </summary>
        public uvec3 abr => new uvec3(w, z, x);
        
        /// <summary>
        /// Returns uvec4.wzxx swizzling.
        /// </summary>
        public uvec4 wzxx => new uvec4(w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.abrr swizzling (equivalent to uvec4.wzxx).
        /// </summary>
        public uvec4 abrr => new uvec4(w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.wzxy swizzling.
        /// </summary>
        public uvec4 wzxy => new uvec4(w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.abrg swizzling (equivalent to uvec4.wzxy).
        /// </summary>
        public uvec4 abrg => new uvec4(w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.wzxz swizzling.
        /// </summary>
        public uvec4 wzxz => new uvec4(w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.abrb swizzling (equivalent to uvec4.wzxz).
        /// </summary>
        public uvec4 abrb => new uvec4(w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.wzxw swizzling.
        /// </summary>
        public uvec4 wzxw => new uvec4(w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.abra swizzling (equivalent to uvec4.wzxw).
        /// </summary>
        public uvec4 abra => new uvec4(w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.wzy swizzling.
        /// </summary>
        public uvec3 wzy => new uvec3(w, z, y);
        
        /// <summary>
        /// Returns uvec4.abg swizzling (equivalent to uvec4.wzy).
        /// </summary>
        public uvec3 abg => new uvec3(w, z, y);
        
        /// <summary>
        /// Returns uvec4.wzyx swizzling.
        /// </summary>
        public uvec4 wzyx => new uvec4(w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.abgr swizzling (equivalent to uvec4.wzyx).
        /// </summary>
        public uvec4 abgr => new uvec4(w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.wzyy swizzling.
        /// </summary>
        public uvec4 wzyy => new uvec4(w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.abgg swizzling (equivalent to uvec4.wzyy).
        /// </summary>
        public uvec4 abgg => new uvec4(w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.wzyz swizzling.
        /// </summary>
        public uvec4 wzyz => new uvec4(w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.abgb swizzling (equivalent to uvec4.wzyz).
        /// </summary>
        public uvec4 abgb => new uvec4(w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.wzyw swizzling.
        /// </summary>
        public uvec4 wzyw => new uvec4(w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.abga swizzling (equivalent to uvec4.wzyw).
        /// </summary>
        public uvec4 abga => new uvec4(w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.wzz swizzling.
        /// </summary>
        public uvec3 wzz => new uvec3(w, z, z);
        
        /// <summary>
        /// Returns uvec4.abb swizzling (equivalent to uvec4.wzz).
        /// </summary>
        public uvec3 abb => new uvec3(w, z, z);
        
        /// <summary>
        /// Returns uvec4.wzzx swizzling.
        /// </summary>
        public uvec4 wzzx => new uvec4(w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.abbr swizzling (equivalent to uvec4.wzzx).
        /// </summary>
        public uvec4 abbr => new uvec4(w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.wzzy swizzling.
        /// </summary>
        public uvec4 wzzy => new uvec4(w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.abbg swizzling (equivalent to uvec4.wzzy).
        /// </summary>
        public uvec4 abbg => new uvec4(w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.wzzz swizzling.
        /// </summary>
        public uvec4 wzzz => new uvec4(w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.abbb swizzling (equivalent to uvec4.wzzz).
        /// </summary>
        public uvec4 abbb => new uvec4(w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.wzzw swizzling.
        /// </summary>
        public uvec4 wzzw => new uvec4(w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.abba swizzling (equivalent to uvec4.wzzw).
        /// </summary>
        public uvec4 abba => new uvec4(w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.wzw swizzling.
        /// </summary>
        public uvec3 wzw => new uvec3(w, z, w);
        
        /// <summary>
        /// Returns uvec4.aba swizzling (equivalent to uvec4.wzw).
        /// </summary>
        public uvec3 aba => new uvec3(w, z, w);
        
        /// <summary>
        /// Returns uvec4.wzwx swizzling.
        /// </summary>
        public uvec4 wzwx => new uvec4(w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.abar swizzling (equivalent to uvec4.wzwx).
        /// </summary>
        public uvec4 abar => new uvec4(w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.wzwy swizzling.
        /// </summary>
        public uvec4 wzwy => new uvec4(w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.abag swizzling (equivalent to uvec4.wzwy).
        /// </summary>
        public uvec4 abag => new uvec4(w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.wzwz swizzling.
        /// </summary>
        public uvec4 wzwz => new uvec4(w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.abab swizzling (equivalent to uvec4.wzwz).
        /// </summary>
        public uvec4 abab => new uvec4(w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.wzww swizzling.
        /// </summary>
        public uvec4 wzww => new uvec4(w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.abaa swizzling (equivalent to uvec4.wzww).
        /// </summary>
        public uvec4 abaa => new uvec4(w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.ww swizzling.
        /// </summary>
        public uvec2 ww => new uvec2(w, w);
        
        /// <summary>
        /// Returns uvec4.aa swizzling (equivalent to uvec4.ww).
        /// </summary>
        public uvec2 aa => new uvec2(w, w);
        
        /// <summary>
        /// Returns uvec4.wwx swizzling.
        /// </summary>
        public uvec3 wwx => new uvec3(w, w, x);
        
        /// <summary>
        /// Returns uvec4.aar swizzling (equivalent to uvec4.wwx).
        /// </summary>
        public uvec3 aar => new uvec3(w, w, x);
        
        /// <summary>
        /// Returns uvec4.wwxx swizzling.
        /// </summary>
        public uvec4 wwxx => new uvec4(w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.aarr swizzling (equivalent to uvec4.wwxx).
        /// </summary>
        public uvec4 aarr => new uvec4(w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.wwxy swizzling.
        /// </summary>
        public uvec4 wwxy => new uvec4(w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.aarg swizzling (equivalent to uvec4.wwxy).
        /// </summary>
        public uvec4 aarg => new uvec4(w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.wwxz swizzling.
        /// </summary>
        public uvec4 wwxz => new uvec4(w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.aarb swizzling (equivalent to uvec4.wwxz).
        /// </summary>
        public uvec4 aarb => new uvec4(w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.wwxw swizzling.
        /// </summary>
        public uvec4 wwxw => new uvec4(w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.aara swizzling (equivalent to uvec4.wwxw).
        /// </summary>
        public uvec4 aara => new uvec4(w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.wwy swizzling.
        /// </summary>
        public uvec3 wwy => new uvec3(w, w, y);
        
        /// <summary>
        /// Returns uvec4.aag swizzling (equivalent to uvec4.wwy).
        /// </summary>
        public uvec3 aag => new uvec3(w, w, y);
        
        /// <summary>
        /// Returns uvec4.wwyx swizzling.
        /// </summary>
        public uvec4 wwyx => new uvec4(w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.aagr swizzling (equivalent to uvec4.wwyx).
        /// </summary>
        public uvec4 aagr => new uvec4(w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.wwyy swizzling.
        /// </summary>
        public uvec4 wwyy => new uvec4(w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.aagg swizzling (equivalent to uvec4.wwyy).
        /// </summary>
        public uvec4 aagg => new uvec4(w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.wwyz swizzling.
        /// </summary>
        public uvec4 wwyz => new uvec4(w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.aagb swizzling (equivalent to uvec4.wwyz).
        /// </summary>
        public uvec4 aagb => new uvec4(w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.wwyw swizzling.
        /// </summary>
        public uvec4 wwyw => new uvec4(w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.aaga swizzling (equivalent to uvec4.wwyw).
        /// </summary>
        public uvec4 aaga => new uvec4(w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.wwz swizzling.
        /// </summary>
        public uvec3 wwz => new uvec3(w, w, z);
        
        /// <summary>
        /// Returns uvec4.aab swizzling (equivalent to uvec4.wwz).
        /// </summary>
        public uvec3 aab => new uvec3(w, w, z);
        
        /// <summary>
        /// Returns uvec4.wwzx swizzling.
        /// </summary>
        public uvec4 wwzx => new uvec4(w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.aabr swizzling (equivalent to uvec4.wwzx).
        /// </summary>
        public uvec4 aabr => new uvec4(w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.wwzy swizzling.
        /// </summary>
        public uvec4 wwzy => new uvec4(w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.aabg swizzling (equivalent to uvec4.wwzy).
        /// </summary>
        public uvec4 aabg => new uvec4(w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.wwzz swizzling.
        /// </summary>
        public uvec4 wwzz => new uvec4(w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.aabb swizzling (equivalent to uvec4.wwzz).
        /// </summary>
        public uvec4 aabb => new uvec4(w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.wwzw swizzling.
        /// </summary>
        public uvec4 wwzw => new uvec4(w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.aaba swizzling (equivalent to uvec4.wwzw).
        /// </summary>
        public uvec4 aaba => new uvec4(w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.www swizzling.
        /// </summary>
        public uvec3 www => new uvec3(w, w, w);
        
        /// <summary>
        /// Returns uvec4.aaa swizzling (equivalent to uvec4.www).
        /// </summary>
        public uvec3 aaa => new uvec3(w, w, w);
        
        /// <summary>
        /// Returns uvec4.wwwx swizzling.
        /// </summary>
        public uvec4 wwwx => new uvec4(w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.aaar swizzling (equivalent to uvec4.wwwx).
        /// </summary>
        public uvec4 aaar => new uvec4(w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.wwwy swizzling.
        /// </summary>
        public uvec4 wwwy => new uvec4(w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.aaag swizzling (equivalent to uvec4.wwwy).
        /// </summary>
        public uvec4 aaag => new uvec4(w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.wwwz swizzling.
        /// </summary>
        public uvec4 wwwz => new uvec4(w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.aaab swizzling (equivalent to uvec4.wwwz).
        /// </summary>
        public uvec4 aaab => new uvec4(w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.wwww swizzling.
        /// </summary>
        public uvec4 wwww => new uvec4(w, w, w, w);
        
        /// <summary>
        /// Returns uvec4.aaaa swizzling (equivalent to uvec4.wwww).
        /// </summary>
        public uvec4 aaaa => new uvec4(w, w, w, w);

        #endregion

    }
}
