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
    /// Temporary vector of type float with 4 components, used for implementing swizzling for vec4.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_vec4
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly float z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly float w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_vec4.
        /// </summary>
        internal swizzle_vec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns vec4.xx swizzling.
        /// </summary>
        public vec2 xx => new vec2(x, x);
        
        /// <summary>
        /// Returns vec4.rr swizzling (equivalent to vec4.xx).
        /// </summary>
        public vec2 rr => new vec2(x, x);
        
        /// <summary>
        /// Returns vec4.xxx swizzling.
        /// </summary>
        public vec3 xxx => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec4.rrr swizzling (equivalent to vec4.xxx).
        /// </summary>
        public vec3 rrr => new vec3(x, x, x);
        
        /// <summary>
        /// Returns vec4.xxxx swizzling.
        /// </summary>
        public vec4 xxxx => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec4.rrrr swizzling (equivalent to vec4.xxxx).
        /// </summary>
        public vec4 rrrr => new vec4(x, x, x, x);
        
        /// <summary>
        /// Returns vec4.xxxy swizzling.
        /// </summary>
        public vec4 xxxy => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec4.rrrg swizzling (equivalent to vec4.xxxy).
        /// </summary>
        public vec4 rrrg => new vec4(x, x, x, y);
        
        /// <summary>
        /// Returns vec4.xxxz swizzling.
        /// </summary>
        public vec4 xxxz => new vec4(x, x, x, z);
        
        /// <summary>
        /// Returns vec4.rrrb swizzling (equivalent to vec4.xxxz).
        /// </summary>
        public vec4 rrrb => new vec4(x, x, x, z);
        
        /// <summary>
        /// Returns vec4.xxxw swizzling.
        /// </summary>
        public vec4 xxxw => new vec4(x, x, x, w);
        
        /// <summary>
        /// Returns vec4.rrra swizzling (equivalent to vec4.xxxw).
        /// </summary>
        public vec4 rrra => new vec4(x, x, x, w);
        
        /// <summary>
        /// Returns vec4.xxy swizzling.
        /// </summary>
        public vec3 xxy => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec4.rrg swizzling (equivalent to vec4.xxy).
        /// </summary>
        public vec3 rrg => new vec3(x, x, y);
        
        /// <summary>
        /// Returns vec4.xxyx swizzling.
        /// </summary>
        public vec4 xxyx => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec4.rrgr swizzling (equivalent to vec4.xxyx).
        /// </summary>
        public vec4 rrgr => new vec4(x, x, y, x);
        
        /// <summary>
        /// Returns vec4.xxyy swizzling.
        /// </summary>
        public vec4 xxyy => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec4.rrgg swizzling (equivalent to vec4.xxyy).
        /// </summary>
        public vec4 rrgg => new vec4(x, x, y, y);
        
        /// <summary>
        /// Returns vec4.xxyz swizzling.
        /// </summary>
        public vec4 xxyz => new vec4(x, x, y, z);
        
        /// <summary>
        /// Returns vec4.rrgb swizzling (equivalent to vec4.xxyz).
        /// </summary>
        public vec4 rrgb => new vec4(x, x, y, z);
        
        /// <summary>
        /// Returns vec4.xxyw swizzling.
        /// </summary>
        public vec4 xxyw => new vec4(x, x, y, w);
        
        /// <summary>
        /// Returns vec4.rrga swizzling (equivalent to vec4.xxyw).
        /// </summary>
        public vec4 rrga => new vec4(x, x, y, w);
        
        /// <summary>
        /// Returns vec4.xxz swizzling.
        /// </summary>
        public vec3 xxz => new vec3(x, x, z);
        
        /// <summary>
        /// Returns vec4.rrb swizzling (equivalent to vec4.xxz).
        /// </summary>
        public vec3 rrb => new vec3(x, x, z);
        
        /// <summary>
        /// Returns vec4.xxzx swizzling.
        /// </summary>
        public vec4 xxzx => new vec4(x, x, z, x);
        
        /// <summary>
        /// Returns vec4.rrbr swizzling (equivalent to vec4.xxzx).
        /// </summary>
        public vec4 rrbr => new vec4(x, x, z, x);
        
        /// <summary>
        /// Returns vec4.xxzy swizzling.
        /// </summary>
        public vec4 xxzy => new vec4(x, x, z, y);
        
        /// <summary>
        /// Returns vec4.rrbg swizzling (equivalent to vec4.xxzy).
        /// </summary>
        public vec4 rrbg => new vec4(x, x, z, y);
        
        /// <summary>
        /// Returns vec4.xxzz swizzling.
        /// </summary>
        public vec4 xxzz => new vec4(x, x, z, z);
        
        /// <summary>
        /// Returns vec4.rrbb swizzling (equivalent to vec4.xxzz).
        /// </summary>
        public vec4 rrbb => new vec4(x, x, z, z);
        
        /// <summary>
        /// Returns vec4.xxzw swizzling.
        /// </summary>
        public vec4 xxzw => new vec4(x, x, z, w);
        
        /// <summary>
        /// Returns vec4.rrba swizzling (equivalent to vec4.xxzw).
        /// </summary>
        public vec4 rrba => new vec4(x, x, z, w);
        
        /// <summary>
        /// Returns vec4.xxw swizzling.
        /// </summary>
        public vec3 xxw => new vec3(x, x, w);
        
        /// <summary>
        /// Returns vec4.rra swizzling (equivalent to vec4.xxw).
        /// </summary>
        public vec3 rra => new vec3(x, x, w);
        
        /// <summary>
        /// Returns vec4.xxwx swizzling.
        /// </summary>
        public vec4 xxwx => new vec4(x, x, w, x);
        
        /// <summary>
        /// Returns vec4.rrar swizzling (equivalent to vec4.xxwx).
        /// </summary>
        public vec4 rrar => new vec4(x, x, w, x);
        
        /// <summary>
        /// Returns vec4.xxwy swizzling.
        /// </summary>
        public vec4 xxwy => new vec4(x, x, w, y);
        
        /// <summary>
        /// Returns vec4.rrag swizzling (equivalent to vec4.xxwy).
        /// </summary>
        public vec4 rrag => new vec4(x, x, w, y);
        
        /// <summary>
        /// Returns vec4.xxwz swizzling.
        /// </summary>
        public vec4 xxwz => new vec4(x, x, w, z);
        
        /// <summary>
        /// Returns vec4.rrab swizzling (equivalent to vec4.xxwz).
        /// </summary>
        public vec4 rrab => new vec4(x, x, w, z);
        
        /// <summary>
        /// Returns vec4.xxww swizzling.
        /// </summary>
        public vec4 xxww => new vec4(x, x, w, w);
        
        /// <summary>
        /// Returns vec4.rraa swizzling (equivalent to vec4.xxww).
        /// </summary>
        public vec4 rraa => new vec4(x, x, w, w);
        
        /// <summary>
        /// Returns vec4.xy swizzling.
        /// </summary>
        public vec2 xy => new vec2(x, y);
        
        /// <summary>
        /// Returns vec4.rg swizzling (equivalent to vec4.xy).
        /// </summary>
        public vec2 rg => new vec2(x, y);
        
        /// <summary>
        /// Returns vec4.xyx swizzling.
        /// </summary>
        public vec3 xyx => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec4.rgr swizzling (equivalent to vec4.xyx).
        /// </summary>
        public vec3 rgr => new vec3(x, y, x);
        
        /// <summary>
        /// Returns vec4.xyxx swizzling.
        /// </summary>
        public vec4 xyxx => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec4.rgrr swizzling (equivalent to vec4.xyxx).
        /// </summary>
        public vec4 rgrr => new vec4(x, y, x, x);
        
        /// <summary>
        /// Returns vec4.xyxy swizzling.
        /// </summary>
        public vec4 xyxy => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec4.rgrg swizzling (equivalent to vec4.xyxy).
        /// </summary>
        public vec4 rgrg => new vec4(x, y, x, y);
        
        /// <summary>
        /// Returns vec4.xyxz swizzling.
        /// </summary>
        public vec4 xyxz => new vec4(x, y, x, z);
        
        /// <summary>
        /// Returns vec4.rgrb swizzling (equivalent to vec4.xyxz).
        /// </summary>
        public vec4 rgrb => new vec4(x, y, x, z);
        
        /// <summary>
        /// Returns vec4.xyxw swizzling.
        /// </summary>
        public vec4 xyxw => new vec4(x, y, x, w);
        
        /// <summary>
        /// Returns vec4.rgra swizzling (equivalent to vec4.xyxw).
        /// </summary>
        public vec4 rgra => new vec4(x, y, x, w);
        
        /// <summary>
        /// Returns vec4.xyy swizzling.
        /// </summary>
        public vec3 xyy => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec4.rgg swizzling (equivalent to vec4.xyy).
        /// </summary>
        public vec3 rgg => new vec3(x, y, y);
        
        /// <summary>
        /// Returns vec4.xyyx swizzling.
        /// </summary>
        public vec4 xyyx => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec4.rggr swizzling (equivalent to vec4.xyyx).
        /// </summary>
        public vec4 rggr => new vec4(x, y, y, x);
        
        /// <summary>
        /// Returns vec4.xyyy swizzling.
        /// </summary>
        public vec4 xyyy => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec4.rggg swizzling (equivalent to vec4.xyyy).
        /// </summary>
        public vec4 rggg => new vec4(x, y, y, y);
        
        /// <summary>
        /// Returns vec4.xyyz swizzling.
        /// </summary>
        public vec4 xyyz => new vec4(x, y, y, z);
        
        /// <summary>
        /// Returns vec4.rggb swizzling (equivalent to vec4.xyyz).
        /// </summary>
        public vec4 rggb => new vec4(x, y, y, z);
        
        /// <summary>
        /// Returns vec4.xyyw swizzling.
        /// </summary>
        public vec4 xyyw => new vec4(x, y, y, w);
        
        /// <summary>
        /// Returns vec4.rgga swizzling (equivalent to vec4.xyyw).
        /// </summary>
        public vec4 rgga => new vec4(x, y, y, w);
        
        /// <summary>
        /// Returns vec4.xyz swizzling.
        /// </summary>
        public vec3 xyz => new vec3(x, y, z);
        
        /// <summary>
        /// Returns vec4.rgb swizzling (equivalent to vec4.xyz).
        /// </summary>
        public vec3 rgb => new vec3(x, y, z);
        
        /// <summary>
        /// Returns vec4.xyzx swizzling.
        /// </summary>
        public vec4 xyzx => new vec4(x, y, z, x);
        
        /// <summary>
        /// Returns vec4.rgbr swizzling (equivalent to vec4.xyzx).
        /// </summary>
        public vec4 rgbr => new vec4(x, y, z, x);
        
        /// <summary>
        /// Returns vec4.xyzy swizzling.
        /// </summary>
        public vec4 xyzy => new vec4(x, y, z, y);
        
        /// <summary>
        /// Returns vec4.rgbg swizzling (equivalent to vec4.xyzy).
        /// </summary>
        public vec4 rgbg => new vec4(x, y, z, y);
        
        /// <summary>
        /// Returns vec4.xyzz swizzling.
        /// </summary>
        public vec4 xyzz => new vec4(x, y, z, z);
        
        /// <summary>
        /// Returns vec4.rgbb swizzling (equivalent to vec4.xyzz).
        /// </summary>
        public vec4 rgbb => new vec4(x, y, z, z);
        
        /// <summary>
        /// Returns vec4.xyzw swizzling.
        /// </summary>
        public vec4 xyzw => new vec4(x, y, z, w);
        
        /// <summary>
        /// Returns vec4.rgba swizzling (equivalent to vec4.xyzw).
        /// </summary>
        public vec4 rgba => new vec4(x, y, z, w);
        
        /// <summary>
        /// Returns vec4.xyw swizzling.
        /// </summary>
        public vec3 xyw => new vec3(x, y, w);
        
        /// <summary>
        /// Returns vec4.rga swizzling (equivalent to vec4.xyw).
        /// </summary>
        public vec3 rga => new vec3(x, y, w);
        
        /// <summary>
        /// Returns vec4.xywx swizzling.
        /// </summary>
        public vec4 xywx => new vec4(x, y, w, x);
        
        /// <summary>
        /// Returns vec4.rgar swizzling (equivalent to vec4.xywx).
        /// </summary>
        public vec4 rgar => new vec4(x, y, w, x);
        
        /// <summary>
        /// Returns vec4.xywy swizzling.
        /// </summary>
        public vec4 xywy => new vec4(x, y, w, y);
        
        /// <summary>
        /// Returns vec4.rgag swizzling (equivalent to vec4.xywy).
        /// </summary>
        public vec4 rgag => new vec4(x, y, w, y);
        
        /// <summary>
        /// Returns vec4.xywz swizzling.
        /// </summary>
        public vec4 xywz => new vec4(x, y, w, z);
        
        /// <summary>
        /// Returns vec4.rgab swizzling (equivalent to vec4.xywz).
        /// </summary>
        public vec4 rgab => new vec4(x, y, w, z);
        
        /// <summary>
        /// Returns vec4.xyww swizzling.
        /// </summary>
        public vec4 xyww => new vec4(x, y, w, w);
        
        /// <summary>
        /// Returns vec4.rgaa swizzling (equivalent to vec4.xyww).
        /// </summary>
        public vec4 rgaa => new vec4(x, y, w, w);
        
        /// <summary>
        /// Returns vec4.xz swizzling.
        /// </summary>
        public vec2 xz => new vec2(x, z);
        
        /// <summary>
        /// Returns vec4.rb swizzling (equivalent to vec4.xz).
        /// </summary>
        public vec2 rb => new vec2(x, z);
        
        /// <summary>
        /// Returns vec4.xzx swizzling.
        /// </summary>
        public vec3 xzx => new vec3(x, z, x);
        
        /// <summary>
        /// Returns vec4.rbr swizzling (equivalent to vec4.xzx).
        /// </summary>
        public vec3 rbr => new vec3(x, z, x);
        
        /// <summary>
        /// Returns vec4.xzxx swizzling.
        /// </summary>
        public vec4 xzxx => new vec4(x, z, x, x);
        
        /// <summary>
        /// Returns vec4.rbrr swizzling (equivalent to vec4.xzxx).
        /// </summary>
        public vec4 rbrr => new vec4(x, z, x, x);
        
        /// <summary>
        /// Returns vec4.xzxy swizzling.
        /// </summary>
        public vec4 xzxy => new vec4(x, z, x, y);
        
        /// <summary>
        /// Returns vec4.rbrg swizzling (equivalent to vec4.xzxy).
        /// </summary>
        public vec4 rbrg => new vec4(x, z, x, y);
        
        /// <summary>
        /// Returns vec4.xzxz swizzling.
        /// </summary>
        public vec4 xzxz => new vec4(x, z, x, z);
        
        /// <summary>
        /// Returns vec4.rbrb swizzling (equivalent to vec4.xzxz).
        /// </summary>
        public vec4 rbrb => new vec4(x, z, x, z);
        
        /// <summary>
        /// Returns vec4.xzxw swizzling.
        /// </summary>
        public vec4 xzxw => new vec4(x, z, x, w);
        
        /// <summary>
        /// Returns vec4.rbra swizzling (equivalent to vec4.xzxw).
        /// </summary>
        public vec4 rbra => new vec4(x, z, x, w);
        
        /// <summary>
        /// Returns vec4.xzy swizzling.
        /// </summary>
        public vec3 xzy => new vec3(x, z, y);
        
        /// <summary>
        /// Returns vec4.rbg swizzling (equivalent to vec4.xzy).
        /// </summary>
        public vec3 rbg => new vec3(x, z, y);
        
        /// <summary>
        /// Returns vec4.xzyx swizzling.
        /// </summary>
        public vec4 xzyx => new vec4(x, z, y, x);
        
        /// <summary>
        /// Returns vec4.rbgr swizzling (equivalent to vec4.xzyx).
        /// </summary>
        public vec4 rbgr => new vec4(x, z, y, x);
        
        /// <summary>
        /// Returns vec4.xzyy swizzling.
        /// </summary>
        public vec4 xzyy => new vec4(x, z, y, y);
        
        /// <summary>
        /// Returns vec4.rbgg swizzling (equivalent to vec4.xzyy).
        /// </summary>
        public vec4 rbgg => new vec4(x, z, y, y);
        
        /// <summary>
        /// Returns vec4.xzyz swizzling.
        /// </summary>
        public vec4 xzyz => new vec4(x, z, y, z);
        
        /// <summary>
        /// Returns vec4.rbgb swizzling (equivalent to vec4.xzyz).
        /// </summary>
        public vec4 rbgb => new vec4(x, z, y, z);
        
        /// <summary>
        /// Returns vec4.xzyw swizzling.
        /// </summary>
        public vec4 xzyw => new vec4(x, z, y, w);
        
        /// <summary>
        /// Returns vec4.rbga swizzling (equivalent to vec4.xzyw).
        /// </summary>
        public vec4 rbga => new vec4(x, z, y, w);
        
        /// <summary>
        /// Returns vec4.xzz swizzling.
        /// </summary>
        public vec3 xzz => new vec3(x, z, z);
        
        /// <summary>
        /// Returns vec4.rbb swizzling (equivalent to vec4.xzz).
        /// </summary>
        public vec3 rbb => new vec3(x, z, z);
        
        /// <summary>
        /// Returns vec4.xzzx swizzling.
        /// </summary>
        public vec4 xzzx => new vec4(x, z, z, x);
        
        /// <summary>
        /// Returns vec4.rbbr swizzling (equivalent to vec4.xzzx).
        /// </summary>
        public vec4 rbbr => new vec4(x, z, z, x);
        
        /// <summary>
        /// Returns vec4.xzzy swizzling.
        /// </summary>
        public vec4 xzzy => new vec4(x, z, z, y);
        
        /// <summary>
        /// Returns vec4.rbbg swizzling (equivalent to vec4.xzzy).
        /// </summary>
        public vec4 rbbg => new vec4(x, z, z, y);
        
        /// <summary>
        /// Returns vec4.xzzz swizzling.
        /// </summary>
        public vec4 xzzz => new vec4(x, z, z, z);
        
        /// <summary>
        /// Returns vec4.rbbb swizzling (equivalent to vec4.xzzz).
        /// </summary>
        public vec4 rbbb => new vec4(x, z, z, z);
        
        /// <summary>
        /// Returns vec4.xzzw swizzling.
        /// </summary>
        public vec4 xzzw => new vec4(x, z, z, w);
        
        /// <summary>
        /// Returns vec4.rbba swizzling (equivalent to vec4.xzzw).
        /// </summary>
        public vec4 rbba => new vec4(x, z, z, w);
        
        /// <summary>
        /// Returns vec4.xzw swizzling.
        /// </summary>
        public vec3 xzw => new vec3(x, z, w);
        
        /// <summary>
        /// Returns vec4.rba swizzling (equivalent to vec4.xzw).
        /// </summary>
        public vec3 rba => new vec3(x, z, w);
        
        /// <summary>
        /// Returns vec4.xzwx swizzling.
        /// </summary>
        public vec4 xzwx => new vec4(x, z, w, x);
        
        /// <summary>
        /// Returns vec4.rbar swizzling (equivalent to vec4.xzwx).
        /// </summary>
        public vec4 rbar => new vec4(x, z, w, x);
        
        /// <summary>
        /// Returns vec4.xzwy swizzling.
        /// </summary>
        public vec4 xzwy => new vec4(x, z, w, y);
        
        /// <summary>
        /// Returns vec4.rbag swizzling (equivalent to vec4.xzwy).
        /// </summary>
        public vec4 rbag => new vec4(x, z, w, y);
        
        /// <summary>
        /// Returns vec4.xzwz swizzling.
        /// </summary>
        public vec4 xzwz => new vec4(x, z, w, z);
        
        /// <summary>
        /// Returns vec4.rbab swizzling (equivalent to vec4.xzwz).
        /// </summary>
        public vec4 rbab => new vec4(x, z, w, z);
        
        /// <summary>
        /// Returns vec4.xzww swizzling.
        /// </summary>
        public vec4 xzww => new vec4(x, z, w, w);
        
        /// <summary>
        /// Returns vec4.rbaa swizzling (equivalent to vec4.xzww).
        /// </summary>
        public vec4 rbaa => new vec4(x, z, w, w);
        
        /// <summary>
        /// Returns vec4.xw swizzling.
        /// </summary>
        public vec2 xw => new vec2(x, w);
        
        /// <summary>
        /// Returns vec4.ra swizzling (equivalent to vec4.xw).
        /// </summary>
        public vec2 ra => new vec2(x, w);
        
        /// <summary>
        /// Returns vec4.xwx swizzling.
        /// </summary>
        public vec3 xwx => new vec3(x, w, x);
        
        /// <summary>
        /// Returns vec4.rar swizzling (equivalent to vec4.xwx).
        /// </summary>
        public vec3 rar => new vec3(x, w, x);
        
        /// <summary>
        /// Returns vec4.xwxx swizzling.
        /// </summary>
        public vec4 xwxx => new vec4(x, w, x, x);
        
        /// <summary>
        /// Returns vec4.rarr swizzling (equivalent to vec4.xwxx).
        /// </summary>
        public vec4 rarr => new vec4(x, w, x, x);
        
        /// <summary>
        /// Returns vec4.xwxy swizzling.
        /// </summary>
        public vec4 xwxy => new vec4(x, w, x, y);
        
        /// <summary>
        /// Returns vec4.rarg swizzling (equivalent to vec4.xwxy).
        /// </summary>
        public vec4 rarg => new vec4(x, w, x, y);
        
        /// <summary>
        /// Returns vec4.xwxz swizzling.
        /// </summary>
        public vec4 xwxz => new vec4(x, w, x, z);
        
        /// <summary>
        /// Returns vec4.rarb swizzling (equivalent to vec4.xwxz).
        /// </summary>
        public vec4 rarb => new vec4(x, w, x, z);
        
        /// <summary>
        /// Returns vec4.xwxw swizzling.
        /// </summary>
        public vec4 xwxw => new vec4(x, w, x, w);
        
        /// <summary>
        /// Returns vec4.rara swizzling (equivalent to vec4.xwxw).
        /// </summary>
        public vec4 rara => new vec4(x, w, x, w);
        
        /// <summary>
        /// Returns vec4.xwy swizzling.
        /// </summary>
        public vec3 xwy => new vec3(x, w, y);
        
        /// <summary>
        /// Returns vec4.rag swizzling (equivalent to vec4.xwy).
        /// </summary>
        public vec3 rag => new vec3(x, w, y);
        
        /// <summary>
        /// Returns vec4.xwyx swizzling.
        /// </summary>
        public vec4 xwyx => new vec4(x, w, y, x);
        
        /// <summary>
        /// Returns vec4.ragr swizzling (equivalent to vec4.xwyx).
        /// </summary>
        public vec4 ragr => new vec4(x, w, y, x);
        
        /// <summary>
        /// Returns vec4.xwyy swizzling.
        /// </summary>
        public vec4 xwyy => new vec4(x, w, y, y);
        
        /// <summary>
        /// Returns vec4.ragg swizzling (equivalent to vec4.xwyy).
        /// </summary>
        public vec4 ragg => new vec4(x, w, y, y);
        
        /// <summary>
        /// Returns vec4.xwyz swizzling.
        /// </summary>
        public vec4 xwyz => new vec4(x, w, y, z);
        
        /// <summary>
        /// Returns vec4.ragb swizzling (equivalent to vec4.xwyz).
        /// </summary>
        public vec4 ragb => new vec4(x, w, y, z);
        
        /// <summary>
        /// Returns vec4.xwyw swizzling.
        /// </summary>
        public vec4 xwyw => new vec4(x, w, y, w);
        
        /// <summary>
        /// Returns vec4.raga swizzling (equivalent to vec4.xwyw).
        /// </summary>
        public vec4 raga => new vec4(x, w, y, w);
        
        /// <summary>
        /// Returns vec4.xwz swizzling.
        /// </summary>
        public vec3 xwz => new vec3(x, w, z);
        
        /// <summary>
        /// Returns vec4.rab swizzling (equivalent to vec4.xwz).
        /// </summary>
        public vec3 rab => new vec3(x, w, z);
        
        /// <summary>
        /// Returns vec4.xwzx swizzling.
        /// </summary>
        public vec4 xwzx => new vec4(x, w, z, x);
        
        /// <summary>
        /// Returns vec4.rabr swizzling (equivalent to vec4.xwzx).
        /// </summary>
        public vec4 rabr => new vec4(x, w, z, x);
        
        /// <summary>
        /// Returns vec4.xwzy swizzling.
        /// </summary>
        public vec4 xwzy => new vec4(x, w, z, y);
        
        /// <summary>
        /// Returns vec4.rabg swizzling (equivalent to vec4.xwzy).
        /// </summary>
        public vec4 rabg => new vec4(x, w, z, y);
        
        /// <summary>
        /// Returns vec4.xwzz swizzling.
        /// </summary>
        public vec4 xwzz => new vec4(x, w, z, z);
        
        /// <summary>
        /// Returns vec4.rabb swizzling (equivalent to vec4.xwzz).
        /// </summary>
        public vec4 rabb => new vec4(x, w, z, z);
        
        /// <summary>
        /// Returns vec4.xwzw swizzling.
        /// </summary>
        public vec4 xwzw => new vec4(x, w, z, w);
        
        /// <summary>
        /// Returns vec4.raba swizzling (equivalent to vec4.xwzw).
        /// </summary>
        public vec4 raba => new vec4(x, w, z, w);
        
        /// <summary>
        /// Returns vec4.xww swizzling.
        /// </summary>
        public vec3 xww => new vec3(x, w, w);
        
        /// <summary>
        /// Returns vec4.raa swizzling (equivalent to vec4.xww).
        /// </summary>
        public vec3 raa => new vec3(x, w, w);
        
        /// <summary>
        /// Returns vec4.xwwx swizzling.
        /// </summary>
        public vec4 xwwx => new vec4(x, w, w, x);
        
        /// <summary>
        /// Returns vec4.raar swizzling (equivalent to vec4.xwwx).
        /// </summary>
        public vec4 raar => new vec4(x, w, w, x);
        
        /// <summary>
        /// Returns vec4.xwwy swizzling.
        /// </summary>
        public vec4 xwwy => new vec4(x, w, w, y);
        
        /// <summary>
        /// Returns vec4.raag swizzling (equivalent to vec4.xwwy).
        /// </summary>
        public vec4 raag => new vec4(x, w, w, y);
        
        /// <summary>
        /// Returns vec4.xwwz swizzling.
        /// </summary>
        public vec4 xwwz => new vec4(x, w, w, z);
        
        /// <summary>
        /// Returns vec4.raab swizzling (equivalent to vec4.xwwz).
        /// </summary>
        public vec4 raab => new vec4(x, w, w, z);
        
        /// <summary>
        /// Returns vec4.xwww swizzling.
        /// </summary>
        public vec4 xwww => new vec4(x, w, w, w);
        
        /// <summary>
        /// Returns vec4.raaa swizzling (equivalent to vec4.xwww).
        /// </summary>
        public vec4 raaa => new vec4(x, w, w, w);
        
        /// <summary>
        /// Returns vec4.yx swizzling.
        /// </summary>
        public vec2 yx => new vec2(y, x);
        
        /// <summary>
        /// Returns vec4.gr swizzling (equivalent to vec4.yx).
        /// </summary>
        public vec2 gr => new vec2(y, x);
        
        /// <summary>
        /// Returns vec4.yxx swizzling.
        /// </summary>
        public vec3 yxx => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec4.grr swizzling (equivalent to vec4.yxx).
        /// </summary>
        public vec3 grr => new vec3(y, x, x);
        
        /// <summary>
        /// Returns vec4.yxxx swizzling.
        /// </summary>
        public vec4 yxxx => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec4.grrr swizzling (equivalent to vec4.yxxx).
        /// </summary>
        public vec4 grrr => new vec4(y, x, x, x);
        
        /// <summary>
        /// Returns vec4.yxxy swizzling.
        /// </summary>
        public vec4 yxxy => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec4.grrg swizzling (equivalent to vec4.yxxy).
        /// </summary>
        public vec4 grrg => new vec4(y, x, x, y);
        
        /// <summary>
        /// Returns vec4.yxxz swizzling.
        /// </summary>
        public vec4 yxxz => new vec4(y, x, x, z);
        
        /// <summary>
        /// Returns vec4.grrb swizzling (equivalent to vec4.yxxz).
        /// </summary>
        public vec4 grrb => new vec4(y, x, x, z);
        
        /// <summary>
        /// Returns vec4.yxxw swizzling.
        /// </summary>
        public vec4 yxxw => new vec4(y, x, x, w);
        
        /// <summary>
        /// Returns vec4.grra swizzling (equivalent to vec4.yxxw).
        /// </summary>
        public vec4 grra => new vec4(y, x, x, w);
        
        /// <summary>
        /// Returns vec4.yxy swizzling.
        /// </summary>
        public vec3 yxy => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec4.grg swizzling (equivalent to vec4.yxy).
        /// </summary>
        public vec3 grg => new vec3(y, x, y);
        
        /// <summary>
        /// Returns vec4.yxyx swizzling.
        /// </summary>
        public vec4 yxyx => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec4.grgr swizzling (equivalent to vec4.yxyx).
        /// </summary>
        public vec4 grgr => new vec4(y, x, y, x);
        
        /// <summary>
        /// Returns vec4.yxyy swizzling.
        /// </summary>
        public vec4 yxyy => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec4.grgg swizzling (equivalent to vec4.yxyy).
        /// </summary>
        public vec4 grgg => new vec4(y, x, y, y);
        
        /// <summary>
        /// Returns vec4.yxyz swizzling.
        /// </summary>
        public vec4 yxyz => new vec4(y, x, y, z);
        
        /// <summary>
        /// Returns vec4.grgb swizzling (equivalent to vec4.yxyz).
        /// </summary>
        public vec4 grgb => new vec4(y, x, y, z);
        
        /// <summary>
        /// Returns vec4.yxyw swizzling.
        /// </summary>
        public vec4 yxyw => new vec4(y, x, y, w);
        
        /// <summary>
        /// Returns vec4.grga swizzling (equivalent to vec4.yxyw).
        /// </summary>
        public vec4 grga => new vec4(y, x, y, w);
        
        /// <summary>
        /// Returns vec4.yxz swizzling.
        /// </summary>
        public vec3 yxz => new vec3(y, x, z);
        
        /// <summary>
        /// Returns vec4.grb swizzling (equivalent to vec4.yxz).
        /// </summary>
        public vec3 grb => new vec3(y, x, z);
        
        /// <summary>
        /// Returns vec4.yxzx swizzling.
        /// </summary>
        public vec4 yxzx => new vec4(y, x, z, x);
        
        /// <summary>
        /// Returns vec4.grbr swizzling (equivalent to vec4.yxzx).
        /// </summary>
        public vec4 grbr => new vec4(y, x, z, x);
        
        /// <summary>
        /// Returns vec4.yxzy swizzling.
        /// </summary>
        public vec4 yxzy => new vec4(y, x, z, y);
        
        /// <summary>
        /// Returns vec4.grbg swizzling (equivalent to vec4.yxzy).
        /// </summary>
        public vec4 grbg => new vec4(y, x, z, y);
        
        /// <summary>
        /// Returns vec4.yxzz swizzling.
        /// </summary>
        public vec4 yxzz => new vec4(y, x, z, z);
        
        /// <summary>
        /// Returns vec4.grbb swizzling (equivalent to vec4.yxzz).
        /// </summary>
        public vec4 grbb => new vec4(y, x, z, z);
        
        /// <summary>
        /// Returns vec4.yxzw swizzling.
        /// </summary>
        public vec4 yxzw => new vec4(y, x, z, w);
        
        /// <summary>
        /// Returns vec4.grba swizzling (equivalent to vec4.yxzw).
        /// </summary>
        public vec4 grba => new vec4(y, x, z, w);
        
        /// <summary>
        /// Returns vec4.yxw swizzling.
        /// </summary>
        public vec3 yxw => new vec3(y, x, w);
        
        /// <summary>
        /// Returns vec4.gra swizzling (equivalent to vec4.yxw).
        /// </summary>
        public vec3 gra => new vec3(y, x, w);
        
        /// <summary>
        /// Returns vec4.yxwx swizzling.
        /// </summary>
        public vec4 yxwx => new vec4(y, x, w, x);
        
        /// <summary>
        /// Returns vec4.grar swizzling (equivalent to vec4.yxwx).
        /// </summary>
        public vec4 grar => new vec4(y, x, w, x);
        
        /// <summary>
        /// Returns vec4.yxwy swizzling.
        /// </summary>
        public vec4 yxwy => new vec4(y, x, w, y);
        
        /// <summary>
        /// Returns vec4.grag swizzling (equivalent to vec4.yxwy).
        /// </summary>
        public vec4 grag => new vec4(y, x, w, y);
        
        /// <summary>
        /// Returns vec4.yxwz swizzling.
        /// </summary>
        public vec4 yxwz => new vec4(y, x, w, z);
        
        /// <summary>
        /// Returns vec4.grab swizzling (equivalent to vec4.yxwz).
        /// </summary>
        public vec4 grab => new vec4(y, x, w, z);
        
        /// <summary>
        /// Returns vec4.yxww swizzling.
        /// </summary>
        public vec4 yxww => new vec4(y, x, w, w);
        
        /// <summary>
        /// Returns vec4.graa swizzling (equivalent to vec4.yxww).
        /// </summary>
        public vec4 graa => new vec4(y, x, w, w);
        
        /// <summary>
        /// Returns vec4.yy swizzling.
        /// </summary>
        public vec2 yy => new vec2(y, y);
        
        /// <summary>
        /// Returns vec4.gg swizzling (equivalent to vec4.yy).
        /// </summary>
        public vec2 gg => new vec2(y, y);
        
        /// <summary>
        /// Returns vec4.yyx swizzling.
        /// </summary>
        public vec3 yyx => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec4.ggr swizzling (equivalent to vec4.yyx).
        /// </summary>
        public vec3 ggr => new vec3(y, y, x);
        
        /// <summary>
        /// Returns vec4.yyxx swizzling.
        /// </summary>
        public vec4 yyxx => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec4.ggrr swizzling (equivalent to vec4.yyxx).
        /// </summary>
        public vec4 ggrr => new vec4(y, y, x, x);
        
        /// <summary>
        /// Returns vec4.yyxy swizzling.
        /// </summary>
        public vec4 yyxy => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec4.ggrg swizzling (equivalent to vec4.yyxy).
        /// </summary>
        public vec4 ggrg => new vec4(y, y, x, y);
        
        /// <summary>
        /// Returns vec4.yyxz swizzling.
        /// </summary>
        public vec4 yyxz => new vec4(y, y, x, z);
        
        /// <summary>
        /// Returns vec4.ggrb swizzling (equivalent to vec4.yyxz).
        /// </summary>
        public vec4 ggrb => new vec4(y, y, x, z);
        
        /// <summary>
        /// Returns vec4.yyxw swizzling.
        /// </summary>
        public vec4 yyxw => new vec4(y, y, x, w);
        
        /// <summary>
        /// Returns vec4.ggra swizzling (equivalent to vec4.yyxw).
        /// </summary>
        public vec4 ggra => new vec4(y, y, x, w);
        
        /// <summary>
        /// Returns vec4.yyy swizzling.
        /// </summary>
        public vec3 yyy => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec4.ggg swizzling (equivalent to vec4.yyy).
        /// </summary>
        public vec3 ggg => new vec3(y, y, y);
        
        /// <summary>
        /// Returns vec4.yyyx swizzling.
        /// </summary>
        public vec4 yyyx => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec4.gggr swizzling (equivalent to vec4.yyyx).
        /// </summary>
        public vec4 gggr => new vec4(y, y, y, x);
        
        /// <summary>
        /// Returns vec4.yyyy swizzling.
        /// </summary>
        public vec4 yyyy => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec4.gggg swizzling (equivalent to vec4.yyyy).
        /// </summary>
        public vec4 gggg => new vec4(y, y, y, y);
        
        /// <summary>
        /// Returns vec4.yyyz swizzling.
        /// </summary>
        public vec4 yyyz => new vec4(y, y, y, z);
        
        /// <summary>
        /// Returns vec4.gggb swizzling (equivalent to vec4.yyyz).
        /// </summary>
        public vec4 gggb => new vec4(y, y, y, z);
        
        /// <summary>
        /// Returns vec4.yyyw swizzling.
        /// </summary>
        public vec4 yyyw => new vec4(y, y, y, w);
        
        /// <summary>
        /// Returns vec4.ggga swizzling (equivalent to vec4.yyyw).
        /// </summary>
        public vec4 ggga => new vec4(y, y, y, w);
        
        /// <summary>
        /// Returns vec4.yyz swizzling.
        /// </summary>
        public vec3 yyz => new vec3(y, y, z);
        
        /// <summary>
        /// Returns vec4.ggb swizzling (equivalent to vec4.yyz).
        /// </summary>
        public vec3 ggb => new vec3(y, y, z);
        
        /// <summary>
        /// Returns vec4.yyzx swizzling.
        /// </summary>
        public vec4 yyzx => new vec4(y, y, z, x);
        
        /// <summary>
        /// Returns vec4.ggbr swizzling (equivalent to vec4.yyzx).
        /// </summary>
        public vec4 ggbr => new vec4(y, y, z, x);
        
        /// <summary>
        /// Returns vec4.yyzy swizzling.
        /// </summary>
        public vec4 yyzy => new vec4(y, y, z, y);
        
        /// <summary>
        /// Returns vec4.ggbg swizzling (equivalent to vec4.yyzy).
        /// </summary>
        public vec4 ggbg => new vec4(y, y, z, y);
        
        /// <summary>
        /// Returns vec4.yyzz swizzling.
        /// </summary>
        public vec4 yyzz => new vec4(y, y, z, z);
        
        /// <summary>
        /// Returns vec4.ggbb swizzling (equivalent to vec4.yyzz).
        /// </summary>
        public vec4 ggbb => new vec4(y, y, z, z);
        
        /// <summary>
        /// Returns vec4.yyzw swizzling.
        /// </summary>
        public vec4 yyzw => new vec4(y, y, z, w);
        
        /// <summary>
        /// Returns vec4.ggba swizzling (equivalent to vec4.yyzw).
        /// </summary>
        public vec4 ggba => new vec4(y, y, z, w);
        
        /// <summary>
        /// Returns vec4.yyw swizzling.
        /// </summary>
        public vec3 yyw => new vec3(y, y, w);
        
        /// <summary>
        /// Returns vec4.gga swizzling (equivalent to vec4.yyw).
        /// </summary>
        public vec3 gga => new vec3(y, y, w);
        
        /// <summary>
        /// Returns vec4.yywx swizzling.
        /// </summary>
        public vec4 yywx => new vec4(y, y, w, x);
        
        /// <summary>
        /// Returns vec4.ggar swizzling (equivalent to vec4.yywx).
        /// </summary>
        public vec4 ggar => new vec4(y, y, w, x);
        
        /// <summary>
        /// Returns vec4.yywy swizzling.
        /// </summary>
        public vec4 yywy => new vec4(y, y, w, y);
        
        /// <summary>
        /// Returns vec4.ggag swizzling (equivalent to vec4.yywy).
        /// </summary>
        public vec4 ggag => new vec4(y, y, w, y);
        
        /// <summary>
        /// Returns vec4.yywz swizzling.
        /// </summary>
        public vec4 yywz => new vec4(y, y, w, z);
        
        /// <summary>
        /// Returns vec4.ggab swizzling (equivalent to vec4.yywz).
        /// </summary>
        public vec4 ggab => new vec4(y, y, w, z);
        
        /// <summary>
        /// Returns vec4.yyww swizzling.
        /// </summary>
        public vec4 yyww => new vec4(y, y, w, w);
        
        /// <summary>
        /// Returns vec4.ggaa swizzling (equivalent to vec4.yyww).
        /// </summary>
        public vec4 ggaa => new vec4(y, y, w, w);
        
        /// <summary>
        /// Returns vec4.yz swizzling.
        /// </summary>
        public vec2 yz => new vec2(y, z);
        
        /// <summary>
        /// Returns vec4.gb swizzling (equivalent to vec4.yz).
        /// </summary>
        public vec2 gb => new vec2(y, z);
        
        /// <summary>
        /// Returns vec4.yzx swizzling.
        /// </summary>
        public vec3 yzx => new vec3(y, z, x);
        
        /// <summary>
        /// Returns vec4.gbr swizzling (equivalent to vec4.yzx).
        /// </summary>
        public vec3 gbr => new vec3(y, z, x);
        
        /// <summary>
        /// Returns vec4.yzxx swizzling.
        /// </summary>
        public vec4 yzxx => new vec4(y, z, x, x);
        
        /// <summary>
        /// Returns vec4.gbrr swizzling (equivalent to vec4.yzxx).
        /// </summary>
        public vec4 gbrr => new vec4(y, z, x, x);
        
        /// <summary>
        /// Returns vec4.yzxy swizzling.
        /// </summary>
        public vec4 yzxy => new vec4(y, z, x, y);
        
        /// <summary>
        /// Returns vec4.gbrg swizzling (equivalent to vec4.yzxy).
        /// </summary>
        public vec4 gbrg => new vec4(y, z, x, y);
        
        /// <summary>
        /// Returns vec4.yzxz swizzling.
        /// </summary>
        public vec4 yzxz => new vec4(y, z, x, z);
        
        /// <summary>
        /// Returns vec4.gbrb swizzling (equivalent to vec4.yzxz).
        /// </summary>
        public vec4 gbrb => new vec4(y, z, x, z);
        
        /// <summary>
        /// Returns vec4.yzxw swizzling.
        /// </summary>
        public vec4 yzxw => new vec4(y, z, x, w);
        
        /// <summary>
        /// Returns vec4.gbra swizzling (equivalent to vec4.yzxw).
        /// </summary>
        public vec4 gbra => new vec4(y, z, x, w);
        
        /// <summary>
        /// Returns vec4.yzy swizzling.
        /// </summary>
        public vec3 yzy => new vec3(y, z, y);
        
        /// <summary>
        /// Returns vec4.gbg swizzling (equivalent to vec4.yzy).
        /// </summary>
        public vec3 gbg => new vec3(y, z, y);
        
        /// <summary>
        /// Returns vec4.yzyx swizzling.
        /// </summary>
        public vec4 yzyx => new vec4(y, z, y, x);
        
        /// <summary>
        /// Returns vec4.gbgr swizzling (equivalent to vec4.yzyx).
        /// </summary>
        public vec4 gbgr => new vec4(y, z, y, x);
        
        /// <summary>
        /// Returns vec4.yzyy swizzling.
        /// </summary>
        public vec4 yzyy => new vec4(y, z, y, y);
        
        /// <summary>
        /// Returns vec4.gbgg swizzling (equivalent to vec4.yzyy).
        /// </summary>
        public vec4 gbgg => new vec4(y, z, y, y);
        
        /// <summary>
        /// Returns vec4.yzyz swizzling.
        /// </summary>
        public vec4 yzyz => new vec4(y, z, y, z);
        
        /// <summary>
        /// Returns vec4.gbgb swizzling (equivalent to vec4.yzyz).
        /// </summary>
        public vec4 gbgb => new vec4(y, z, y, z);
        
        /// <summary>
        /// Returns vec4.yzyw swizzling.
        /// </summary>
        public vec4 yzyw => new vec4(y, z, y, w);
        
        /// <summary>
        /// Returns vec4.gbga swizzling (equivalent to vec4.yzyw).
        /// </summary>
        public vec4 gbga => new vec4(y, z, y, w);
        
        /// <summary>
        /// Returns vec4.yzz swizzling.
        /// </summary>
        public vec3 yzz => new vec3(y, z, z);
        
        /// <summary>
        /// Returns vec4.gbb swizzling (equivalent to vec4.yzz).
        /// </summary>
        public vec3 gbb => new vec3(y, z, z);
        
        /// <summary>
        /// Returns vec4.yzzx swizzling.
        /// </summary>
        public vec4 yzzx => new vec4(y, z, z, x);
        
        /// <summary>
        /// Returns vec4.gbbr swizzling (equivalent to vec4.yzzx).
        /// </summary>
        public vec4 gbbr => new vec4(y, z, z, x);
        
        /// <summary>
        /// Returns vec4.yzzy swizzling.
        /// </summary>
        public vec4 yzzy => new vec4(y, z, z, y);
        
        /// <summary>
        /// Returns vec4.gbbg swizzling (equivalent to vec4.yzzy).
        /// </summary>
        public vec4 gbbg => new vec4(y, z, z, y);
        
        /// <summary>
        /// Returns vec4.yzzz swizzling.
        /// </summary>
        public vec4 yzzz => new vec4(y, z, z, z);
        
        /// <summary>
        /// Returns vec4.gbbb swizzling (equivalent to vec4.yzzz).
        /// </summary>
        public vec4 gbbb => new vec4(y, z, z, z);
        
        /// <summary>
        /// Returns vec4.yzzw swizzling.
        /// </summary>
        public vec4 yzzw => new vec4(y, z, z, w);
        
        /// <summary>
        /// Returns vec4.gbba swizzling (equivalent to vec4.yzzw).
        /// </summary>
        public vec4 gbba => new vec4(y, z, z, w);
        
        /// <summary>
        /// Returns vec4.yzw swizzling.
        /// </summary>
        public vec3 yzw => new vec3(y, z, w);
        
        /// <summary>
        /// Returns vec4.gba swizzling (equivalent to vec4.yzw).
        /// </summary>
        public vec3 gba => new vec3(y, z, w);
        
        /// <summary>
        /// Returns vec4.yzwx swizzling.
        /// </summary>
        public vec4 yzwx => new vec4(y, z, w, x);
        
        /// <summary>
        /// Returns vec4.gbar swizzling (equivalent to vec4.yzwx).
        /// </summary>
        public vec4 gbar => new vec4(y, z, w, x);
        
        /// <summary>
        /// Returns vec4.yzwy swizzling.
        /// </summary>
        public vec4 yzwy => new vec4(y, z, w, y);
        
        /// <summary>
        /// Returns vec4.gbag swizzling (equivalent to vec4.yzwy).
        /// </summary>
        public vec4 gbag => new vec4(y, z, w, y);
        
        /// <summary>
        /// Returns vec4.yzwz swizzling.
        /// </summary>
        public vec4 yzwz => new vec4(y, z, w, z);
        
        /// <summary>
        /// Returns vec4.gbab swizzling (equivalent to vec4.yzwz).
        /// </summary>
        public vec4 gbab => new vec4(y, z, w, z);
        
        /// <summary>
        /// Returns vec4.yzww swizzling.
        /// </summary>
        public vec4 yzww => new vec4(y, z, w, w);
        
        /// <summary>
        /// Returns vec4.gbaa swizzling (equivalent to vec4.yzww).
        /// </summary>
        public vec4 gbaa => new vec4(y, z, w, w);
        
        /// <summary>
        /// Returns vec4.yw swizzling.
        /// </summary>
        public vec2 yw => new vec2(y, w);
        
        /// <summary>
        /// Returns vec4.ga swizzling (equivalent to vec4.yw).
        /// </summary>
        public vec2 ga => new vec2(y, w);
        
        /// <summary>
        /// Returns vec4.ywx swizzling.
        /// </summary>
        public vec3 ywx => new vec3(y, w, x);
        
        /// <summary>
        /// Returns vec4.gar swizzling (equivalent to vec4.ywx).
        /// </summary>
        public vec3 gar => new vec3(y, w, x);
        
        /// <summary>
        /// Returns vec4.ywxx swizzling.
        /// </summary>
        public vec4 ywxx => new vec4(y, w, x, x);
        
        /// <summary>
        /// Returns vec4.garr swizzling (equivalent to vec4.ywxx).
        /// </summary>
        public vec4 garr => new vec4(y, w, x, x);
        
        /// <summary>
        /// Returns vec4.ywxy swizzling.
        /// </summary>
        public vec4 ywxy => new vec4(y, w, x, y);
        
        /// <summary>
        /// Returns vec4.garg swizzling (equivalent to vec4.ywxy).
        /// </summary>
        public vec4 garg => new vec4(y, w, x, y);
        
        /// <summary>
        /// Returns vec4.ywxz swizzling.
        /// </summary>
        public vec4 ywxz => new vec4(y, w, x, z);
        
        /// <summary>
        /// Returns vec4.garb swizzling (equivalent to vec4.ywxz).
        /// </summary>
        public vec4 garb => new vec4(y, w, x, z);
        
        /// <summary>
        /// Returns vec4.ywxw swizzling.
        /// </summary>
        public vec4 ywxw => new vec4(y, w, x, w);
        
        /// <summary>
        /// Returns vec4.gara swizzling (equivalent to vec4.ywxw).
        /// </summary>
        public vec4 gara => new vec4(y, w, x, w);
        
        /// <summary>
        /// Returns vec4.ywy swizzling.
        /// </summary>
        public vec3 ywy => new vec3(y, w, y);
        
        /// <summary>
        /// Returns vec4.gag swizzling (equivalent to vec4.ywy).
        /// </summary>
        public vec3 gag => new vec3(y, w, y);
        
        /// <summary>
        /// Returns vec4.ywyx swizzling.
        /// </summary>
        public vec4 ywyx => new vec4(y, w, y, x);
        
        /// <summary>
        /// Returns vec4.gagr swizzling (equivalent to vec4.ywyx).
        /// </summary>
        public vec4 gagr => new vec4(y, w, y, x);
        
        /// <summary>
        /// Returns vec4.ywyy swizzling.
        /// </summary>
        public vec4 ywyy => new vec4(y, w, y, y);
        
        /// <summary>
        /// Returns vec4.gagg swizzling (equivalent to vec4.ywyy).
        /// </summary>
        public vec4 gagg => new vec4(y, w, y, y);
        
        /// <summary>
        /// Returns vec4.ywyz swizzling.
        /// </summary>
        public vec4 ywyz => new vec4(y, w, y, z);
        
        /// <summary>
        /// Returns vec4.gagb swizzling (equivalent to vec4.ywyz).
        /// </summary>
        public vec4 gagb => new vec4(y, w, y, z);
        
        /// <summary>
        /// Returns vec4.ywyw swizzling.
        /// </summary>
        public vec4 ywyw => new vec4(y, w, y, w);
        
        /// <summary>
        /// Returns vec4.gaga swizzling (equivalent to vec4.ywyw).
        /// </summary>
        public vec4 gaga => new vec4(y, w, y, w);
        
        /// <summary>
        /// Returns vec4.ywz swizzling.
        /// </summary>
        public vec3 ywz => new vec3(y, w, z);
        
        /// <summary>
        /// Returns vec4.gab swizzling (equivalent to vec4.ywz).
        /// </summary>
        public vec3 gab => new vec3(y, w, z);
        
        /// <summary>
        /// Returns vec4.ywzx swizzling.
        /// </summary>
        public vec4 ywzx => new vec4(y, w, z, x);
        
        /// <summary>
        /// Returns vec4.gabr swizzling (equivalent to vec4.ywzx).
        /// </summary>
        public vec4 gabr => new vec4(y, w, z, x);
        
        /// <summary>
        /// Returns vec4.ywzy swizzling.
        /// </summary>
        public vec4 ywzy => new vec4(y, w, z, y);
        
        /// <summary>
        /// Returns vec4.gabg swizzling (equivalent to vec4.ywzy).
        /// </summary>
        public vec4 gabg => new vec4(y, w, z, y);
        
        /// <summary>
        /// Returns vec4.ywzz swizzling.
        /// </summary>
        public vec4 ywzz => new vec4(y, w, z, z);
        
        /// <summary>
        /// Returns vec4.gabb swizzling (equivalent to vec4.ywzz).
        /// </summary>
        public vec4 gabb => new vec4(y, w, z, z);
        
        /// <summary>
        /// Returns vec4.ywzw swizzling.
        /// </summary>
        public vec4 ywzw => new vec4(y, w, z, w);
        
        /// <summary>
        /// Returns vec4.gaba swizzling (equivalent to vec4.ywzw).
        /// </summary>
        public vec4 gaba => new vec4(y, w, z, w);
        
        /// <summary>
        /// Returns vec4.yww swizzling.
        /// </summary>
        public vec3 yww => new vec3(y, w, w);
        
        /// <summary>
        /// Returns vec4.gaa swizzling (equivalent to vec4.yww).
        /// </summary>
        public vec3 gaa => new vec3(y, w, w);
        
        /// <summary>
        /// Returns vec4.ywwx swizzling.
        /// </summary>
        public vec4 ywwx => new vec4(y, w, w, x);
        
        /// <summary>
        /// Returns vec4.gaar swizzling (equivalent to vec4.ywwx).
        /// </summary>
        public vec4 gaar => new vec4(y, w, w, x);
        
        /// <summary>
        /// Returns vec4.ywwy swizzling.
        /// </summary>
        public vec4 ywwy => new vec4(y, w, w, y);
        
        /// <summary>
        /// Returns vec4.gaag swizzling (equivalent to vec4.ywwy).
        /// </summary>
        public vec4 gaag => new vec4(y, w, w, y);
        
        /// <summary>
        /// Returns vec4.ywwz swizzling.
        /// </summary>
        public vec4 ywwz => new vec4(y, w, w, z);
        
        /// <summary>
        /// Returns vec4.gaab swizzling (equivalent to vec4.ywwz).
        /// </summary>
        public vec4 gaab => new vec4(y, w, w, z);
        
        /// <summary>
        /// Returns vec4.ywww swizzling.
        /// </summary>
        public vec4 ywww => new vec4(y, w, w, w);
        
        /// <summary>
        /// Returns vec4.gaaa swizzling (equivalent to vec4.ywww).
        /// </summary>
        public vec4 gaaa => new vec4(y, w, w, w);
        
        /// <summary>
        /// Returns vec4.zx swizzling.
        /// </summary>
        public vec2 zx => new vec2(z, x);
        
        /// <summary>
        /// Returns vec4.br swizzling (equivalent to vec4.zx).
        /// </summary>
        public vec2 br => new vec2(z, x);
        
        /// <summary>
        /// Returns vec4.zxx swizzling.
        /// </summary>
        public vec3 zxx => new vec3(z, x, x);
        
        /// <summary>
        /// Returns vec4.brr swizzling (equivalent to vec4.zxx).
        /// </summary>
        public vec3 brr => new vec3(z, x, x);
        
        /// <summary>
        /// Returns vec4.zxxx swizzling.
        /// </summary>
        public vec4 zxxx => new vec4(z, x, x, x);
        
        /// <summary>
        /// Returns vec4.brrr swizzling (equivalent to vec4.zxxx).
        /// </summary>
        public vec4 brrr => new vec4(z, x, x, x);
        
        /// <summary>
        /// Returns vec4.zxxy swizzling.
        /// </summary>
        public vec4 zxxy => new vec4(z, x, x, y);
        
        /// <summary>
        /// Returns vec4.brrg swizzling (equivalent to vec4.zxxy).
        /// </summary>
        public vec4 brrg => new vec4(z, x, x, y);
        
        /// <summary>
        /// Returns vec4.zxxz swizzling.
        /// </summary>
        public vec4 zxxz => new vec4(z, x, x, z);
        
        /// <summary>
        /// Returns vec4.brrb swizzling (equivalent to vec4.zxxz).
        /// </summary>
        public vec4 brrb => new vec4(z, x, x, z);
        
        /// <summary>
        /// Returns vec4.zxxw swizzling.
        /// </summary>
        public vec4 zxxw => new vec4(z, x, x, w);
        
        /// <summary>
        /// Returns vec4.brra swizzling (equivalent to vec4.zxxw).
        /// </summary>
        public vec4 brra => new vec4(z, x, x, w);
        
        /// <summary>
        /// Returns vec4.zxy swizzling.
        /// </summary>
        public vec3 zxy => new vec3(z, x, y);
        
        /// <summary>
        /// Returns vec4.brg swizzling (equivalent to vec4.zxy).
        /// </summary>
        public vec3 brg => new vec3(z, x, y);
        
        /// <summary>
        /// Returns vec4.zxyx swizzling.
        /// </summary>
        public vec4 zxyx => new vec4(z, x, y, x);
        
        /// <summary>
        /// Returns vec4.brgr swizzling (equivalent to vec4.zxyx).
        /// </summary>
        public vec4 brgr => new vec4(z, x, y, x);
        
        /// <summary>
        /// Returns vec4.zxyy swizzling.
        /// </summary>
        public vec4 zxyy => new vec4(z, x, y, y);
        
        /// <summary>
        /// Returns vec4.brgg swizzling (equivalent to vec4.zxyy).
        /// </summary>
        public vec4 brgg => new vec4(z, x, y, y);
        
        /// <summary>
        /// Returns vec4.zxyz swizzling.
        /// </summary>
        public vec4 zxyz => new vec4(z, x, y, z);
        
        /// <summary>
        /// Returns vec4.brgb swizzling (equivalent to vec4.zxyz).
        /// </summary>
        public vec4 brgb => new vec4(z, x, y, z);
        
        /// <summary>
        /// Returns vec4.zxyw swizzling.
        /// </summary>
        public vec4 zxyw => new vec4(z, x, y, w);
        
        /// <summary>
        /// Returns vec4.brga swizzling (equivalent to vec4.zxyw).
        /// </summary>
        public vec4 brga => new vec4(z, x, y, w);
        
        /// <summary>
        /// Returns vec4.zxz swizzling.
        /// </summary>
        public vec3 zxz => new vec3(z, x, z);
        
        /// <summary>
        /// Returns vec4.brb swizzling (equivalent to vec4.zxz).
        /// </summary>
        public vec3 brb => new vec3(z, x, z);
        
        /// <summary>
        /// Returns vec4.zxzx swizzling.
        /// </summary>
        public vec4 zxzx => new vec4(z, x, z, x);
        
        /// <summary>
        /// Returns vec4.brbr swizzling (equivalent to vec4.zxzx).
        /// </summary>
        public vec4 brbr => new vec4(z, x, z, x);
        
        /// <summary>
        /// Returns vec4.zxzy swizzling.
        /// </summary>
        public vec4 zxzy => new vec4(z, x, z, y);
        
        /// <summary>
        /// Returns vec4.brbg swizzling (equivalent to vec4.zxzy).
        /// </summary>
        public vec4 brbg => new vec4(z, x, z, y);
        
        /// <summary>
        /// Returns vec4.zxzz swizzling.
        /// </summary>
        public vec4 zxzz => new vec4(z, x, z, z);
        
        /// <summary>
        /// Returns vec4.brbb swizzling (equivalent to vec4.zxzz).
        /// </summary>
        public vec4 brbb => new vec4(z, x, z, z);
        
        /// <summary>
        /// Returns vec4.zxzw swizzling.
        /// </summary>
        public vec4 zxzw => new vec4(z, x, z, w);
        
        /// <summary>
        /// Returns vec4.brba swizzling (equivalent to vec4.zxzw).
        /// </summary>
        public vec4 brba => new vec4(z, x, z, w);
        
        /// <summary>
        /// Returns vec4.zxw swizzling.
        /// </summary>
        public vec3 zxw => new vec3(z, x, w);
        
        /// <summary>
        /// Returns vec4.bra swizzling (equivalent to vec4.zxw).
        /// </summary>
        public vec3 bra => new vec3(z, x, w);
        
        /// <summary>
        /// Returns vec4.zxwx swizzling.
        /// </summary>
        public vec4 zxwx => new vec4(z, x, w, x);
        
        /// <summary>
        /// Returns vec4.brar swizzling (equivalent to vec4.zxwx).
        /// </summary>
        public vec4 brar => new vec4(z, x, w, x);
        
        /// <summary>
        /// Returns vec4.zxwy swizzling.
        /// </summary>
        public vec4 zxwy => new vec4(z, x, w, y);
        
        /// <summary>
        /// Returns vec4.brag swizzling (equivalent to vec4.zxwy).
        /// </summary>
        public vec4 brag => new vec4(z, x, w, y);
        
        /// <summary>
        /// Returns vec4.zxwz swizzling.
        /// </summary>
        public vec4 zxwz => new vec4(z, x, w, z);
        
        /// <summary>
        /// Returns vec4.brab swizzling (equivalent to vec4.zxwz).
        /// </summary>
        public vec4 brab => new vec4(z, x, w, z);
        
        /// <summary>
        /// Returns vec4.zxww swizzling.
        /// </summary>
        public vec4 zxww => new vec4(z, x, w, w);
        
        /// <summary>
        /// Returns vec4.braa swizzling (equivalent to vec4.zxww).
        /// </summary>
        public vec4 braa => new vec4(z, x, w, w);
        
        /// <summary>
        /// Returns vec4.zy swizzling.
        /// </summary>
        public vec2 zy => new vec2(z, y);
        
        /// <summary>
        /// Returns vec4.bg swizzling (equivalent to vec4.zy).
        /// </summary>
        public vec2 bg => new vec2(z, y);
        
        /// <summary>
        /// Returns vec4.zyx swizzling.
        /// </summary>
        public vec3 zyx => new vec3(z, y, x);
        
        /// <summary>
        /// Returns vec4.bgr swizzling (equivalent to vec4.zyx).
        /// </summary>
        public vec3 bgr => new vec3(z, y, x);
        
        /// <summary>
        /// Returns vec4.zyxx swizzling.
        /// </summary>
        public vec4 zyxx => new vec4(z, y, x, x);
        
        /// <summary>
        /// Returns vec4.bgrr swizzling (equivalent to vec4.zyxx).
        /// </summary>
        public vec4 bgrr => new vec4(z, y, x, x);
        
        /// <summary>
        /// Returns vec4.zyxy swizzling.
        /// </summary>
        public vec4 zyxy => new vec4(z, y, x, y);
        
        /// <summary>
        /// Returns vec4.bgrg swizzling (equivalent to vec4.zyxy).
        /// </summary>
        public vec4 bgrg => new vec4(z, y, x, y);
        
        /// <summary>
        /// Returns vec4.zyxz swizzling.
        /// </summary>
        public vec4 zyxz => new vec4(z, y, x, z);
        
        /// <summary>
        /// Returns vec4.bgrb swizzling (equivalent to vec4.zyxz).
        /// </summary>
        public vec4 bgrb => new vec4(z, y, x, z);
        
        /// <summary>
        /// Returns vec4.zyxw swizzling.
        /// </summary>
        public vec4 zyxw => new vec4(z, y, x, w);
        
        /// <summary>
        /// Returns vec4.bgra swizzling (equivalent to vec4.zyxw).
        /// </summary>
        public vec4 bgra => new vec4(z, y, x, w);
        
        /// <summary>
        /// Returns vec4.zyy swizzling.
        /// </summary>
        public vec3 zyy => new vec3(z, y, y);
        
        /// <summary>
        /// Returns vec4.bgg swizzling (equivalent to vec4.zyy).
        /// </summary>
        public vec3 bgg => new vec3(z, y, y);
        
        /// <summary>
        /// Returns vec4.zyyx swizzling.
        /// </summary>
        public vec4 zyyx => new vec4(z, y, y, x);
        
        /// <summary>
        /// Returns vec4.bggr swizzling (equivalent to vec4.zyyx).
        /// </summary>
        public vec4 bggr => new vec4(z, y, y, x);
        
        /// <summary>
        /// Returns vec4.zyyy swizzling.
        /// </summary>
        public vec4 zyyy => new vec4(z, y, y, y);
        
        /// <summary>
        /// Returns vec4.bggg swizzling (equivalent to vec4.zyyy).
        /// </summary>
        public vec4 bggg => new vec4(z, y, y, y);
        
        /// <summary>
        /// Returns vec4.zyyz swizzling.
        /// </summary>
        public vec4 zyyz => new vec4(z, y, y, z);
        
        /// <summary>
        /// Returns vec4.bggb swizzling (equivalent to vec4.zyyz).
        /// </summary>
        public vec4 bggb => new vec4(z, y, y, z);
        
        /// <summary>
        /// Returns vec4.zyyw swizzling.
        /// </summary>
        public vec4 zyyw => new vec4(z, y, y, w);
        
        /// <summary>
        /// Returns vec4.bgga swizzling (equivalent to vec4.zyyw).
        /// </summary>
        public vec4 bgga => new vec4(z, y, y, w);
        
        /// <summary>
        /// Returns vec4.zyz swizzling.
        /// </summary>
        public vec3 zyz => new vec3(z, y, z);
        
        /// <summary>
        /// Returns vec4.bgb swizzling (equivalent to vec4.zyz).
        /// </summary>
        public vec3 bgb => new vec3(z, y, z);
        
        /// <summary>
        /// Returns vec4.zyzx swizzling.
        /// </summary>
        public vec4 zyzx => new vec4(z, y, z, x);
        
        /// <summary>
        /// Returns vec4.bgbr swizzling (equivalent to vec4.zyzx).
        /// </summary>
        public vec4 bgbr => new vec4(z, y, z, x);
        
        /// <summary>
        /// Returns vec4.zyzy swizzling.
        /// </summary>
        public vec4 zyzy => new vec4(z, y, z, y);
        
        /// <summary>
        /// Returns vec4.bgbg swizzling (equivalent to vec4.zyzy).
        /// </summary>
        public vec4 bgbg => new vec4(z, y, z, y);
        
        /// <summary>
        /// Returns vec4.zyzz swizzling.
        /// </summary>
        public vec4 zyzz => new vec4(z, y, z, z);
        
        /// <summary>
        /// Returns vec4.bgbb swizzling (equivalent to vec4.zyzz).
        /// </summary>
        public vec4 bgbb => new vec4(z, y, z, z);
        
        /// <summary>
        /// Returns vec4.zyzw swizzling.
        /// </summary>
        public vec4 zyzw => new vec4(z, y, z, w);
        
        /// <summary>
        /// Returns vec4.bgba swizzling (equivalent to vec4.zyzw).
        /// </summary>
        public vec4 bgba => new vec4(z, y, z, w);
        
        /// <summary>
        /// Returns vec4.zyw swizzling.
        /// </summary>
        public vec3 zyw => new vec3(z, y, w);
        
        /// <summary>
        /// Returns vec4.bga swizzling (equivalent to vec4.zyw).
        /// </summary>
        public vec3 bga => new vec3(z, y, w);
        
        /// <summary>
        /// Returns vec4.zywx swizzling.
        /// </summary>
        public vec4 zywx => new vec4(z, y, w, x);
        
        /// <summary>
        /// Returns vec4.bgar swizzling (equivalent to vec4.zywx).
        /// </summary>
        public vec4 bgar => new vec4(z, y, w, x);
        
        /// <summary>
        /// Returns vec4.zywy swizzling.
        /// </summary>
        public vec4 zywy => new vec4(z, y, w, y);
        
        /// <summary>
        /// Returns vec4.bgag swizzling (equivalent to vec4.zywy).
        /// </summary>
        public vec4 bgag => new vec4(z, y, w, y);
        
        /// <summary>
        /// Returns vec4.zywz swizzling.
        /// </summary>
        public vec4 zywz => new vec4(z, y, w, z);
        
        /// <summary>
        /// Returns vec4.bgab swizzling (equivalent to vec4.zywz).
        /// </summary>
        public vec4 bgab => new vec4(z, y, w, z);
        
        /// <summary>
        /// Returns vec4.zyww swizzling.
        /// </summary>
        public vec4 zyww => new vec4(z, y, w, w);
        
        /// <summary>
        /// Returns vec4.bgaa swizzling (equivalent to vec4.zyww).
        /// </summary>
        public vec4 bgaa => new vec4(z, y, w, w);
        
        /// <summary>
        /// Returns vec4.zz swizzling.
        /// </summary>
        public vec2 zz => new vec2(z, z);
        
        /// <summary>
        /// Returns vec4.bb swizzling (equivalent to vec4.zz).
        /// </summary>
        public vec2 bb => new vec2(z, z);
        
        /// <summary>
        /// Returns vec4.zzx swizzling.
        /// </summary>
        public vec3 zzx => new vec3(z, z, x);
        
        /// <summary>
        /// Returns vec4.bbr swizzling (equivalent to vec4.zzx).
        /// </summary>
        public vec3 bbr => new vec3(z, z, x);
        
        /// <summary>
        /// Returns vec4.zzxx swizzling.
        /// </summary>
        public vec4 zzxx => new vec4(z, z, x, x);
        
        /// <summary>
        /// Returns vec4.bbrr swizzling (equivalent to vec4.zzxx).
        /// </summary>
        public vec4 bbrr => new vec4(z, z, x, x);
        
        /// <summary>
        /// Returns vec4.zzxy swizzling.
        /// </summary>
        public vec4 zzxy => new vec4(z, z, x, y);
        
        /// <summary>
        /// Returns vec4.bbrg swizzling (equivalent to vec4.zzxy).
        /// </summary>
        public vec4 bbrg => new vec4(z, z, x, y);
        
        /// <summary>
        /// Returns vec4.zzxz swizzling.
        /// </summary>
        public vec4 zzxz => new vec4(z, z, x, z);
        
        /// <summary>
        /// Returns vec4.bbrb swizzling (equivalent to vec4.zzxz).
        /// </summary>
        public vec4 bbrb => new vec4(z, z, x, z);
        
        /// <summary>
        /// Returns vec4.zzxw swizzling.
        /// </summary>
        public vec4 zzxw => new vec4(z, z, x, w);
        
        /// <summary>
        /// Returns vec4.bbra swizzling (equivalent to vec4.zzxw).
        /// </summary>
        public vec4 bbra => new vec4(z, z, x, w);
        
        /// <summary>
        /// Returns vec4.zzy swizzling.
        /// </summary>
        public vec3 zzy => new vec3(z, z, y);
        
        /// <summary>
        /// Returns vec4.bbg swizzling (equivalent to vec4.zzy).
        /// </summary>
        public vec3 bbg => new vec3(z, z, y);
        
        /// <summary>
        /// Returns vec4.zzyx swizzling.
        /// </summary>
        public vec4 zzyx => new vec4(z, z, y, x);
        
        /// <summary>
        /// Returns vec4.bbgr swizzling (equivalent to vec4.zzyx).
        /// </summary>
        public vec4 bbgr => new vec4(z, z, y, x);
        
        /// <summary>
        /// Returns vec4.zzyy swizzling.
        /// </summary>
        public vec4 zzyy => new vec4(z, z, y, y);
        
        /// <summary>
        /// Returns vec4.bbgg swizzling (equivalent to vec4.zzyy).
        /// </summary>
        public vec4 bbgg => new vec4(z, z, y, y);
        
        /// <summary>
        /// Returns vec4.zzyz swizzling.
        /// </summary>
        public vec4 zzyz => new vec4(z, z, y, z);
        
        /// <summary>
        /// Returns vec4.bbgb swizzling (equivalent to vec4.zzyz).
        /// </summary>
        public vec4 bbgb => new vec4(z, z, y, z);
        
        /// <summary>
        /// Returns vec4.zzyw swizzling.
        /// </summary>
        public vec4 zzyw => new vec4(z, z, y, w);
        
        /// <summary>
        /// Returns vec4.bbga swizzling (equivalent to vec4.zzyw).
        /// </summary>
        public vec4 bbga => new vec4(z, z, y, w);
        
        /// <summary>
        /// Returns vec4.zzz swizzling.
        /// </summary>
        public vec3 zzz => new vec3(z, z, z);
        
        /// <summary>
        /// Returns vec4.bbb swizzling (equivalent to vec4.zzz).
        /// </summary>
        public vec3 bbb => new vec3(z, z, z);
        
        /// <summary>
        /// Returns vec4.zzzx swizzling.
        /// </summary>
        public vec4 zzzx => new vec4(z, z, z, x);
        
        /// <summary>
        /// Returns vec4.bbbr swizzling (equivalent to vec4.zzzx).
        /// </summary>
        public vec4 bbbr => new vec4(z, z, z, x);
        
        /// <summary>
        /// Returns vec4.zzzy swizzling.
        /// </summary>
        public vec4 zzzy => new vec4(z, z, z, y);
        
        /// <summary>
        /// Returns vec4.bbbg swizzling (equivalent to vec4.zzzy).
        /// </summary>
        public vec4 bbbg => new vec4(z, z, z, y);
        
        /// <summary>
        /// Returns vec4.zzzz swizzling.
        /// </summary>
        public vec4 zzzz => new vec4(z, z, z, z);
        
        /// <summary>
        /// Returns vec4.bbbb swizzling (equivalent to vec4.zzzz).
        /// </summary>
        public vec4 bbbb => new vec4(z, z, z, z);
        
        /// <summary>
        /// Returns vec4.zzzw swizzling.
        /// </summary>
        public vec4 zzzw => new vec4(z, z, z, w);
        
        /// <summary>
        /// Returns vec4.bbba swizzling (equivalent to vec4.zzzw).
        /// </summary>
        public vec4 bbba => new vec4(z, z, z, w);
        
        /// <summary>
        /// Returns vec4.zzw swizzling.
        /// </summary>
        public vec3 zzw => new vec3(z, z, w);
        
        /// <summary>
        /// Returns vec4.bba swizzling (equivalent to vec4.zzw).
        /// </summary>
        public vec3 bba => new vec3(z, z, w);
        
        /// <summary>
        /// Returns vec4.zzwx swizzling.
        /// </summary>
        public vec4 zzwx => new vec4(z, z, w, x);
        
        /// <summary>
        /// Returns vec4.bbar swizzling (equivalent to vec4.zzwx).
        /// </summary>
        public vec4 bbar => new vec4(z, z, w, x);
        
        /// <summary>
        /// Returns vec4.zzwy swizzling.
        /// </summary>
        public vec4 zzwy => new vec4(z, z, w, y);
        
        /// <summary>
        /// Returns vec4.bbag swizzling (equivalent to vec4.zzwy).
        /// </summary>
        public vec4 bbag => new vec4(z, z, w, y);
        
        /// <summary>
        /// Returns vec4.zzwz swizzling.
        /// </summary>
        public vec4 zzwz => new vec4(z, z, w, z);
        
        /// <summary>
        /// Returns vec4.bbab swizzling (equivalent to vec4.zzwz).
        /// </summary>
        public vec4 bbab => new vec4(z, z, w, z);
        
        /// <summary>
        /// Returns vec4.zzww swizzling.
        /// </summary>
        public vec4 zzww => new vec4(z, z, w, w);
        
        /// <summary>
        /// Returns vec4.bbaa swizzling (equivalent to vec4.zzww).
        /// </summary>
        public vec4 bbaa => new vec4(z, z, w, w);
        
        /// <summary>
        /// Returns vec4.zw swizzling.
        /// </summary>
        public vec2 zw => new vec2(z, w);
        
        /// <summary>
        /// Returns vec4.ba swizzling (equivalent to vec4.zw).
        /// </summary>
        public vec2 ba => new vec2(z, w);
        
        /// <summary>
        /// Returns vec4.zwx swizzling.
        /// </summary>
        public vec3 zwx => new vec3(z, w, x);
        
        /// <summary>
        /// Returns vec4.bar swizzling (equivalent to vec4.zwx).
        /// </summary>
        public vec3 bar => new vec3(z, w, x);
        
        /// <summary>
        /// Returns vec4.zwxx swizzling.
        /// </summary>
        public vec4 zwxx => new vec4(z, w, x, x);
        
        /// <summary>
        /// Returns vec4.barr swizzling (equivalent to vec4.zwxx).
        /// </summary>
        public vec4 barr => new vec4(z, w, x, x);
        
        /// <summary>
        /// Returns vec4.zwxy swizzling.
        /// </summary>
        public vec4 zwxy => new vec4(z, w, x, y);
        
        /// <summary>
        /// Returns vec4.barg swizzling (equivalent to vec4.zwxy).
        /// </summary>
        public vec4 barg => new vec4(z, w, x, y);
        
        /// <summary>
        /// Returns vec4.zwxz swizzling.
        /// </summary>
        public vec4 zwxz => new vec4(z, w, x, z);
        
        /// <summary>
        /// Returns vec4.barb swizzling (equivalent to vec4.zwxz).
        /// </summary>
        public vec4 barb => new vec4(z, w, x, z);
        
        /// <summary>
        /// Returns vec4.zwxw swizzling.
        /// </summary>
        public vec4 zwxw => new vec4(z, w, x, w);
        
        /// <summary>
        /// Returns vec4.bara swizzling (equivalent to vec4.zwxw).
        /// </summary>
        public vec4 bara => new vec4(z, w, x, w);
        
        /// <summary>
        /// Returns vec4.zwy swizzling.
        /// </summary>
        public vec3 zwy => new vec3(z, w, y);
        
        /// <summary>
        /// Returns vec4.bag swizzling (equivalent to vec4.zwy).
        /// </summary>
        public vec3 bag => new vec3(z, w, y);
        
        /// <summary>
        /// Returns vec4.zwyx swizzling.
        /// </summary>
        public vec4 zwyx => new vec4(z, w, y, x);
        
        /// <summary>
        /// Returns vec4.bagr swizzling (equivalent to vec4.zwyx).
        /// </summary>
        public vec4 bagr => new vec4(z, w, y, x);
        
        /// <summary>
        /// Returns vec4.zwyy swizzling.
        /// </summary>
        public vec4 zwyy => new vec4(z, w, y, y);
        
        /// <summary>
        /// Returns vec4.bagg swizzling (equivalent to vec4.zwyy).
        /// </summary>
        public vec4 bagg => new vec4(z, w, y, y);
        
        /// <summary>
        /// Returns vec4.zwyz swizzling.
        /// </summary>
        public vec4 zwyz => new vec4(z, w, y, z);
        
        /// <summary>
        /// Returns vec4.bagb swizzling (equivalent to vec4.zwyz).
        /// </summary>
        public vec4 bagb => new vec4(z, w, y, z);
        
        /// <summary>
        /// Returns vec4.zwyw swizzling.
        /// </summary>
        public vec4 zwyw => new vec4(z, w, y, w);
        
        /// <summary>
        /// Returns vec4.baga swizzling (equivalent to vec4.zwyw).
        /// </summary>
        public vec4 baga => new vec4(z, w, y, w);
        
        /// <summary>
        /// Returns vec4.zwz swizzling.
        /// </summary>
        public vec3 zwz => new vec3(z, w, z);
        
        /// <summary>
        /// Returns vec4.bab swizzling (equivalent to vec4.zwz).
        /// </summary>
        public vec3 bab => new vec3(z, w, z);
        
        /// <summary>
        /// Returns vec4.zwzx swizzling.
        /// </summary>
        public vec4 zwzx => new vec4(z, w, z, x);
        
        /// <summary>
        /// Returns vec4.babr swizzling (equivalent to vec4.zwzx).
        /// </summary>
        public vec4 babr => new vec4(z, w, z, x);
        
        /// <summary>
        /// Returns vec4.zwzy swizzling.
        /// </summary>
        public vec4 zwzy => new vec4(z, w, z, y);
        
        /// <summary>
        /// Returns vec4.babg swizzling (equivalent to vec4.zwzy).
        /// </summary>
        public vec4 babg => new vec4(z, w, z, y);
        
        /// <summary>
        /// Returns vec4.zwzz swizzling.
        /// </summary>
        public vec4 zwzz => new vec4(z, w, z, z);
        
        /// <summary>
        /// Returns vec4.babb swizzling (equivalent to vec4.zwzz).
        /// </summary>
        public vec4 babb => new vec4(z, w, z, z);
        
        /// <summary>
        /// Returns vec4.zwzw swizzling.
        /// </summary>
        public vec4 zwzw => new vec4(z, w, z, w);
        
        /// <summary>
        /// Returns vec4.baba swizzling (equivalent to vec4.zwzw).
        /// </summary>
        public vec4 baba => new vec4(z, w, z, w);
        
        /// <summary>
        /// Returns vec4.zww swizzling.
        /// </summary>
        public vec3 zww => new vec3(z, w, w);
        
        /// <summary>
        /// Returns vec4.baa swizzling (equivalent to vec4.zww).
        /// </summary>
        public vec3 baa => new vec3(z, w, w);
        
        /// <summary>
        /// Returns vec4.zwwx swizzling.
        /// </summary>
        public vec4 zwwx => new vec4(z, w, w, x);
        
        /// <summary>
        /// Returns vec4.baar swizzling (equivalent to vec4.zwwx).
        /// </summary>
        public vec4 baar => new vec4(z, w, w, x);
        
        /// <summary>
        /// Returns vec4.zwwy swizzling.
        /// </summary>
        public vec4 zwwy => new vec4(z, w, w, y);
        
        /// <summary>
        /// Returns vec4.baag swizzling (equivalent to vec4.zwwy).
        /// </summary>
        public vec4 baag => new vec4(z, w, w, y);
        
        /// <summary>
        /// Returns vec4.zwwz swizzling.
        /// </summary>
        public vec4 zwwz => new vec4(z, w, w, z);
        
        /// <summary>
        /// Returns vec4.baab swizzling (equivalent to vec4.zwwz).
        /// </summary>
        public vec4 baab => new vec4(z, w, w, z);
        
        /// <summary>
        /// Returns vec4.zwww swizzling.
        /// </summary>
        public vec4 zwww => new vec4(z, w, w, w);
        
        /// <summary>
        /// Returns vec4.baaa swizzling (equivalent to vec4.zwww).
        /// </summary>
        public vec4 baaa => new vec4(z, w, w, w);
        
        /// <summary>
        /// Returns vec4.wx swizzling.
        /// </summary>
        public vec2 wx => new vec2(w, x);
        
        /// <summary>
        /// Returns vec4.ar swizzling (equivalent to vec4.wx).
        /// </summary>
        public vec2 ar => new vec2(w, x);
        
        /// <summary>
        /// Returns vec4.wxx swizzling.
        /// </summary>
        public vec3 wxx => new vec3(w, x, x);
        
        /// <summary>
        /// Returns vec4.arr swizzling (equivalent to vec4.wxx).
        /// </summary>
        public vec3 arr => new vec3(w, x, x);
        
        /// <summary>
        /// Returns vec4.wxxx swizzling.
        /// </summary>
        public vec4 wxxx => new vec4(w, x, x, x);
        
        /// <summary>
        /// Returns vec4.arrr swizzling (equivalent to vec4.wxxx).
        /// </summary>
        public vec4 arrr => new vec4(w, x, x, x);
        
        /// <summary>
        /// Returns vec4.wxxy swizzling.
        /// </summary>
        public vec4 wxxy => new vec4(w, x, x, y);
        
        /// <summary>
        /// Returns vec4.arrg swizzling (equivalent to vec4.wxxy).
        /// </summary>
        public vec4 arrg => new vec4(w, x, x, y);
        
        /// <summary>
        /// Returns vec4.wxxz swizzling.
        /// </summary>
        public vec4 wxxz => new vec4(w, x, x, z);
        
        /// <summary>
        /// Returns vec4.arrb swizzling (equivalent to vec4.wxxz).
        /// </summary>
        public vec4 arrb => new vec4(w, x, x, z);
        
        /// <summary>
        /// Returns vec4.wxxw swizzling.
        /// </summary>
        public vec4 wxxw => new vec4(w, x, x, w);
        
        /// <summary>
        /// Returns vec4.arra swizzling (equivalent to vec4.wxxw).
        /// </summary>
        public vec4 arra => new vec4(w, x, x, w);
        
        /// <summary>
        /// Returns vec4.wxy swizzling.
        /// </summary>
        public vec3 wxy => new vec3(w, x, y);
        
        /// <summary>
        /// Returns vec4.arg swizzling (equivalent to vec4.wxy).
        /// </summary>
        public vec3 arg => new vec3(w, x, y);
        
        /// <summary>
        /// Returns vec4.wxyx swizzling.
        /// </summary>
        public vec4 wxyx => new vec4(w, x, y, x);
        
        /// <summary>
        /// Returns vec4.argr swizzling (equivalent to vec4.wxyx).
        /// </summary>
        public vec4 argr => new vec4(w, x, y, x);
        
        /// <summary>
        /// Returns vec4.wxyy swizzling.
        /// </summary>
        public vec4 wxyy => new vec4(w, x, y, y);
        
        /// <summary>
        /// Returns vec4.argg swizzling (equivalent to vec4.wxyy).
        /// </summary>
        public vec4 argg => new vec4(w, x, y, y);
        
        /// <summary>
        /// Returns vec4.wxyz swizzling.
        /// </summary>
        public vec4 wxyz => new vec4(w, x, y, z);
        
        /// <summary>
        /// Returns vec4.argb swizzling (equivalent to vec4.wxyz).
        /// </summary>
        public vec4 argb => new vec4(w, x, y, z);
        
        /// <summary>
        /// Returns vec4.wxyw swizzling.
        /// </summary>
        public vec4 wxyw => new vec4(w, x, y, w);
        
        /// <summary>
        /// Returns vec4.arga swizzling (equivalent to vec4.wxyw).
        /// </summary>
        public vec4 arga => new vec4(w, x, y, w);
        
        /// <summary>
        /// Returns vec4.wxz swizzling.
        /// </summary>
        public vec3 wxz => new vec3(w, x, z);
        
        /// <summary>
        /// Returns vec4.arb swizzling (equivalent to vec4.wxz).
        /// </summary>
        public vec3 arb => new vec3(w, x, z);
        
        /// <summary>
        /// Returns vec4.wxzx swizzling.
        /// </summary>
        public vec4 wxzx => new vec4(w, x, z, x);
        
        /// <summary>
        /// Returns vec4.arbr swizzling (equivalent to vec4.wxzx).
        /// </summary>
        public vec4 arbr => new vec4(w, x, z, x);
        
        /// <summary>
        /// Returns vec4.wxzy swizzling.
        /// </summary>
        public vec4 wxzy => new vec4(w, x, z, y);
        
        /// <summary>
        /// Returns vec4.arbg swizzling (equivalent to vec4.wxzy).
        /// </summary>
        public vec4 arbg => new vec4(w, x, z, y);
        
        /// <summary>
        /// Returns vec4.wxzz swizzling.
        /// </summary>
        public vec4 wxzz => new vec4(w, x, z, z);
        
        /// <summary>
        /// Returns vec4.arbb swizzling (equivalent to vec4.wxzz).
        /// </summary>
        public vec4 arbb => new vec4(w, x, z, z);
        
        /// <summary>
        /// Returns vec4.wxzw swizzling.
        /// </summary>
        public vec4 wxzw => new vec4(w, x, z, w);
        
        /// <summary>
        /// Returns vec4.arba swizzling (equivalent to vec4.wxzw).
        /// </summary>
        public vec4 arba => new vec4(w, x, z, w);
        
        /// <summary>
        /// Returns vec4.wxw swizzling.
        /// </summary>
        public vec3 wxw => new vec3(w, x, w);
        
        /// <summary>
        /// Returns vec4.ara swizzling (equivalent to vec4.wxw).
        /// </summary>
        public vec3 ara => new vec3(w, x, w);
        
        /// <summary>
        /// Returns vec4.wxwx swizzling.
        /// </summary>
        public vec4 wxwx => new vec4(w, x, w, x);
        
        /// <summary>
        /// Returns vec4.arar swizzling (equivalent to vec4.wxwx).
        /// </summary>
        public vec4 arar => new vec4(w, x, w, x);
        
        /// <summary>
        /// Returns vec4.wxwy swizzling.
        /// </summary>
        public vec4 wxwy => new vec4(w, x, w, y);
        
        /// <summary>
        /// Returns vec4.arag swizzling (equivalent to vec4.wxwy).
        /// </summary>
        public vec4 arag => new vec4(w, x, w, y);
        
        /// <summary>
        /// Returns vec4.wxwz swizzling.
        /// </summary>
        public vec4 wxwz => new vec4(w, x, w, z);
        
        /// <summary>
        /// Returns vec4.arab swizzling (equivalent to vec4.wxwz).
        /// </summary>
        public vec4 arab => new vec4(w, x, w, z);
        
        /// <summary>
        /// Returns vec4.wxww swizzling.
        /// </summary>
        public vec4 wxww => new vec4(w, x, w, w);
        
        /// <summary>
        /// Returns vec4.araa swizzling (equivalent to vec4.wxww).
        /// </summary>
        public vec4 araa => new vec4(w, x, w, w);
        
        /// <summary>
        /// Returns vec4.wy swizzling.
        /// </summary>
        public vec2 wy => new vec2(w, y);
        
        /// <summary>
        /// Returns vec4.ag swizzling (equivalent to vec4.wy).
        /// </summary>
        public vec2 ag => new vec2(w, y);
        
        /// <summary>
        /// Returns vec4.wyx swizzling.
        /// </summary>
        public vec3 wyx => new vec3(w, y, x);
        
        /// <summary>
        /// Returns vec4.agr swizzling (equivalent to vec4.wyx).
        /// </summary>
        public vec3 agr => new vec3(w, y, x);
        
        /// <summary>
        /// Returns vec4.wyxx swizzling.
        /// </summary>
        public vec4 wyxx => new vec4(w, y, x, x);
        
        /// <summary>
        /// Returns vec4.agrr swizzling (equivalent to vec4.wyxx).
        /// </summary>
        public vec4 agrr => new vec4(w, y, x, x);
        
        /// <summary>
        /// Returns vec4.wyxy swizzling.
        /// </summary>
        public vec4 wyxy => new vec4(w, y, x, y);
        
        /// <summary>
        /// Returns vec4.agrg swizzling (equivalent to vec4.wyxy).
        /// </summary>
        public vec4 agrg => new vec4(w, y, x, y);
        
        /// <summary>
        /// Returns vec4.wyxz swizzling.
        /// </summary>
        public vec4 wyxz => new vec4(w, y, x, z);
        
        /// <summary>
        /// Returns vec4.agrb swizzling (equivalent to vec4.wyxz).
        /// </summary>
        public vec4 agrb => new vec4(w, y, x, z);
        
        /// <summary>
        /// Returns vec4.wyxw swizzling.
        /// </summary>
        public vec4 wyxw => new vec4(w, y, x, w);
        
        /// <summary>
        /// Returns vec4.agra swizzling (equivalent to vec4.wyxw).
        /// </summary>
        public vec4 agra => new vec4(w, y, x, w);
        
        /// <summary>
        /// Returns vec4.wyy swizzling.
        /// </summary>
        public vec3 wyy => new vec3(w, y, y);
        
        /// <summary>
        /// Returns vec4.agg swizzling (equivalent to vec4.wyy).
        /// </summary>
        public vec3 agg => new vec3(w, y, y);
        
        /// <summary>
        /// Returns vec4.wyyx swizzling.
        /// </summary>
        public vec4 wyyx => new vec4(w, y, y, x);
        
        /// <summary>
        /// Returns vec4.aggr swizzling (equivalent to vec4.wyyx).
        /// </summary>
        public vec4 aggr => new vec4(w, y, y, x);
        
        /// <summary>
        /// Returns vec4.wyyy swizzling.
        /// </summary>
        public vec4 wyyy => new vec4(w, y, y, y);
        
        /// <summary>
        /// Returns vec4.aggg swizzling (equivalent to vec4.wyyy).
        /// </summary>
        public vec4 aggg => new vec4(w, y, y, y);
        
        /// <summary>
        /// Returns vec4.wyyz swizzling.
        /// </summary>
        public vec4 wyyz => new vec4(w, y, y, z);
        
        /// <summary>
        /// Returns vec4.aggb swizzling (equivalent to vec4.wyyz).
        /// </summary>
        public vec4 aggb => new vec4(w, y, y, z);
        
        /// <summary>
        /// Returns vec4.wyyw swizzling.
        /// </summary>
        public vec4 wyyw => new vec4(w, y, y, w);
        
        /// <summary>
        /// Returns vec4.agga swizzling (equivalent to vec4.wyyw).
        /// </summary>
        public vec4 agga => new vec4(w, y, y, w);
        
        /// <summary>
        /// Returns vec4.wyz swizzling.
        /// </summary>
        public vec3 wyz => new vec3(w, y, z);
        
        /// <summary>
        /// Returns vec4.agb swizzling (equivalent to vec4.wyz).
        /// </summary>
        public vec3 agb => new vec3(w, y, z);
        
        /// <summary>
        /// Returns vec4.wyzx swizzling.
        /// </summary>
        public vec4 wyzx => new vec4(w, y, z, x);
        
        /// <summary>
        /// Returns vec4.agbr swizzling (equivalent to vec4.wyzx).
        /// </summary>
        public vec4 agbr => new vec4(w, y, z, x);
        
        /// <summary>
        /// Returns vec4.wyzy swizzling.
        /// </summary>
        public vec4 wyzy => new vec4(w, y, z, y);
        
        /// <summary>
        /// Returns vec4.agbg swizzling (equivalent to vec4.wyzy).
        /// </summary>
        public vec4 agbg => new vec4(w, y, z, y);
        
        /// <summary>
        /// Returns vec4.wyzz swizzling.
        /// </summary>
        public vec4 wyzz => new vec4(w, y, z, z);
        
        /// <summary>
        /// Returns vec4.agbb swizzling (equivalent to vec4.wyzz).
        /// </summary>
        public vec4 agbb => new vec4(w, y, z, z);
        
        /// <summary>
        /// Returns vec4.wyzw swizzling.
        /// </summary>
        public vec4 wyzw => new vec4(w, y, z, w);
        
        /// <summary>
        /// Returns vec4.agba swizzling (equivalent to vec4.wyzw).
        /// </summary>
        public vec4 agba => new vec4(w, y, z, w);
        
        /// <summary>
        /// Returns vec4.wyw swizzling.
        /// </summary>
        public vec3 wyw => new vec3(w, y, w);
        
        /// <summary>
        /// Returns vec4.aga swizzling (equivalent to vec4.wyw).
        /// </summary>
        public vec3 aga => new vec3(w, y, w);
        
        /// <summary>
        /// Returns vec4.wywx swizzling.
        /// </summary>
        public vec4 wywx => new vec4(w, y, w, x);
        
        /// <summary>
        /// Returns vec4.agar swizzling (equivalent to vec4.wywx).
        /// </summary>
        public vec4 agar => new vec4(w, y, w, x);
        
        /// <summary>
        /// Returns vec4.wywy swizzling.
        /// </summary>
        public vec4 wywy => new vec4(w, y, w, y);
        
        /// <summary>
        /// Returns vec4.agag swizzling (equivalent to vec4.wywy).
        /// </summary>
        public vec4 agag => new vec4(w, y, w, y);
        
        /// <summary>
        /// Returns vec4.wywz swizzling.
        /// </summary>
        public vec4 wywz => new vec4(w, y, w, z);
        
        /// <summary>
        /// Returns vec4.agab swizzling (equivalent to vec4.wywz).
        /// </summary>
        public vec4 agab => new vec4(w, y, w, z);
        
        /// <summary>
        /// Returns vec4.wyww swizzling.
        /// </summary>
        public vec4 wyww => new vec4(w, y, w, w);
        
        /// <summary>
        /// Returns vec4.agaa swizzling (equivalent to vec4.wyww).
        /// </summary>
        public vec4 agaa => new vec4(w, y, w, w);
        
        /// <summary>
        /// Returns vec4.wz swizzling.
        /// </summary>
        public vec2 wz => new vec2(w, z);
        
        /// <summary>
        /// Returns vec4.ab swizzling (equivalent to vec4.wz).
        /// </summary>
        public vec2 ab => new vec2(w, z);
        
        /// <summary>
        /// Returns vec4.wzx swizzling.
        /// </summary>
        public vec3 wzx => new vec3(w, z, x);
        
        /// <summary>
        /// Returns vec4.abr swizzling (equivalent to vec4.wzx).
        /// </summary>
        public vec3 abr => new vec3(w, z, x);
        
        /// <summary>
        /// Returns vec4.wzxx swizzling.
        /// </summary>
        public vec4 wzxx => new vec4(w, z, x, x);
        
        /// <summary>
        /// Returns vec4.abrr swizzling (equivalent to vec4.wzxx).
        /// </summary>
        public vec4 abrr => new vec4(w, z, x, x);
        
        /// <summary>
        /// Returns vec4.wzxy swizzling.
        /// </summary>
        public vec4 wzxy => new vec4(w, z, x, y);
        
        /// <summary>
        /// Returns vec4.abrg swizzling (equivalent to vec4.wzxy).
        /// </summary>
        public vec4 abrg => new vec4(w, z, x, y);
        
        /// <summary>
        /// Returns vec4.wzxz swizzling.
        /// </summary>
        public vec4 wzxz => new vec4(w, z, x, z);
        
        /// <summary>
        /// Returns vec4.abrb swizzling (equivalent to vec4.wzxz).
        /// </summary>
        public vec4 abrb => new vec4(w, z, x, z);
        
        /// <summary>
        /// Returns vec4.wzxw swizzling.
        /// </summary>
        public vec4 wzxw => new vec4(w, z, x, w);
        
        /// <summary>
        /// Returns vec4.abra swizzling (equivalent to vec4.wzxw).
        /// </summary>
        public vec4 abra => new vec4(w, z, x, w);
        
        /// <summary>
        /// Returns vec4.wzy swizzling.
        /// </summary>
        public vec3 wzy => new vec3(w, z, y);
        
        /// <summary>
        /// Returns vec4.abg swizzling (equivalent to vec4.wzy).
        /// </summary>
        public vec3 abg => new vec3(w, z, y);
        
        /// <summary>
        /// Returns vec4.wzyx swizzling.
        /// </summary>
        public vec4 wzyx => new vec4(w, z, y, x);
        
        /// <summary>
        /// Returns vec4.abgr swizzling (equivalent to vec4.wzyx).
        /// </summary>
        public vec4 abgr => new vec4(w, z, y, x);
        
        /// <summary>
        /// Returns vec4.wzyy swizzling.
        /// </summary>
        public vec4 wzyy => new vec4(w, z, y, y);
        
        /// <summary>
        /// Returns vec4.abgg swizzling (equivalent to vec4.wzyy).
        /// </summary>
        public vec4 abgg => new vec4(w, z, y, y);
        
        /// <summary>
        /// Returns vec4.wzyz swizzling.
        /// </summary>
        public vec4 wzyz => new vec4(w, z, y, z);
        
        /// <summary>
        /// Returns vec4.abgb swizzling (equivalent to vec4.wzyz).
        /// </summary>
        public vec4 abgb => new vec4(w, z, y, z);
        
        /// <summary>
        /// Returns vec4.wzyw swizzling.
        /// </summary>
        public vec4 wzyw => new vec4(w, z, y, w);
        
        /// <summary>
        /// Returns vec4.abga swizzling (equivalent to vec4.wzyw).
        /// </summary>
        public vec4 abga => new vec4(w, z, y, w);
        
        /// <summary>
        /// Returns vec4.wzz swizzling.
        /// </summary>
        public vec3 wzz => new vec3(w, z, z);
        
        /// <summary>
        /// Returns vec4.abb swizzling (equivalent to vec4.wzz).
        /// </summary>
        public vec3 abb => new vec3(w, z, z);
        
        /// <summary>
        /// Returns vec4.wzzx swizzling.
        /// </summary>
        public vec4 wzzx => new vec4(w, z, z, x);
        
        /// <summary>
        /// Returns vec4.abbr swizzling (equivalent to vec4.wzzx).
        /// </summary>
        public vec4 abbr => new vec4(w, z, z, x);
        
        /// <summary>
        /// Returns vec4.wzzy swizzling.
        /// </summary>
        public vec4 wzzy => new vec4(w, z, z, y);
        
        /// <summary>
        /// Returns vec4.abbg swizzling (equivalent to vec4.wzzy).
        /// </summary>
        public vec4 abbg => new vec4(w, z, z, y);
        
        /// <summary>
        /// Returns vec4.wzzz swizzling.
        /// </summary>
        public vec4 wzzz => new vec4(w, z, z, z);
        
        /// <summary>
        /// Returns vec4.abbb swizzling (equivalent to vec4.wzzz).
        /// </summary>
        public vec4 abbb => new vec4(w, z, z, z);
        
        /// <summary>
        /// Returns vec4.wzzw swizzling.
        /// </summary>
        public vec4 wzzw => new vec4(w, z, z, w);
        
        /// <summary>
        /// Returns vec4.abba swizzling (equivalent to vec4.wzzw).
        /// </summary>
        public vec4 abba => new vec4(w, z, z, w);
        
        /// <summary>
        /// Returns vec4.wzw swizzling.
        /// </summary>
        public vec3 wzw => new vec3(w, z, w);
        
        /// <summary>
        /// Returns vec4.aba swizzling (equivalent to vec4.wzw).
        /// </summary>
        public vec3 aba => new vec3(w, z, w);
        
        /// <summary>
        /// Returns vec4.wzwx swizzling.
        /// </summary>
        public vec4 wzwx => new vec4(w, z, w, x);
        
        /// <summary>
        /// Returns vec4.abar swizzling (equivalent to vec4.wzwx).
        /// </summary>
        public vec4 abar => new vec4(w, z, w, x);
        
        /// <summary>
        /// Returns vec4.wzwy swizzling.
        /// </summary>
        public vec4 wzwy => new vec4(w, z, w, y);
        
        /// <summary>
        /// Returns vec4.abag swizzling (equivalent to vec4.wzwy).
        /// </summary>
        public vec4 abag => new vec4(w, z, w, y);
        
        /// <summary>
        /// Returns vec4.wzwz swizzling.
        /// </summary>
        public vec4 wzwz => new vec4(w, z, w, z);
        
        /// <summary>
        /// Returns vec4.abab swizzling (equivalent to vec4.wzwz).
        /// </summary>
        public vec4 abab => new vec4(w, z, w, z);
        
        /// <summary>
        /// Returns vec4.wzww swizzling.
        /// </summary>
        public vec4 wzww => new vec4(w, z, w, w);
        
        /// <summary>
        /// Returns vec4.abaa swizzling (equivalent to vec4.wzww).
        /// </summary>
        public vec4 abaa => new vec4(w, z, w, w);
        
        /// <summary>
        /// Returns vec4.ww swizzling.
        /// </summary>
        public vec2 ww => new vec2(w, w);
        
        /// <summary>
        /// Returns vec4.aa swizzling (equivalent to vec4.ww).
        /// </summary>
        public vec2 aa => new vec2(w, w);
        
        /// <summary>
        /// Returns vec4.wwx swizzling.
        /// </summary>
        public vec3 wwx => new vec3(w, w, x);
        
        /// <summary>
        /// Returns vec4.aar swizzling (equivalent to vec4.wwx).
        /// </summary>
        public vec3 aar => new vec3(w, w, x);
        
        /// <summary>
        /// Returns vec4.wwxx swizzling.
        /// </summary>
        public vec4 wwxx => new vec4(w, w, x, x);
        
        /// <summary>
        /// Returns vec4.aarr swizzling (equivalent to vec4.wwxx).
        /// </summary>
        public vec4 aarr => new vec4(w, w, x, x);
        
        /// <summary>
        /// Returns vec4.wwxy swizzling.
        /// </summary>
        public vec4 wwxy => new vec4(w, w, x, y);
        
        /// <summary>
        /// Returns vec4.aarg swizzling (equivalent to vec4.wwxy).
        /// </summary>
        public vec4 aarg => new vec4(w, w, x, y);
        
        /// <summary>
        /// Returns vec4.wwxz swizzling.
        /// </summary>
        public vec4 wwxz => new vec4(w, w, x, z);
        
        /// <summary>
        /// Returns vec4.aarb swizzling (equivalent to vec4.wwxz).
        /// </summary>
        public vec4 aarb => new vec4(w, w, x, z);
        
        /// <summary>
        /// Returns vec4.wwxw swizzling.
        /// </summary>
        public vec4 wwxw => new vec4(w, w, x, w);
        
        /// <summary>
        /// Returns vec4.aara swizzling (equivalent to vec4.wwxw).
        /// </summary>
        public vec4 aara => new vec4(w, w, x, w);
        
        /// <summary>
        /// Returns vec4.wwy swizzling.
        /// </summary>
        public vec3 wwy => new vec3(w, w, y);
        
        /// <summary>
        /// Returns vec4.aag swizzling (equivalent to vec4.wwy).
        /// </summary>
        public vec3 aag => new vec3(w, w, y);
        
        /// <summary>
        /// Returns vec4.wwyx swizzling.
        /// </summary>
        public vec4 wwyx => new vec4(w, w, y, x);
        
        /// <summary>
        /// Returns vec4.aagr swizzling (equivalent to vec4.wwyx).
        /// </summary>
        public vec4 aagr => new vec4(w, w, y, x);
        
        /// <summary>
        /// Returns vec4.wwyy swizzling.
        /// </summary>
        public vec4 wwyy => new vec4(w, w, y, y);
        
        /// <summary>
        /// Returns vec4.aagg swizzling (equivalent to vec4.wwyy).
        /// </summary>
        public vec4 aagg => new vec4(w, w, y, y);
        
        /// <summary>
        /// Returns vec4.wwyz swizzling.
        /// </summary>
        public vec4 wwyz => new vec4(w, w, y, z);
        
        /// <summary>
        /// Returns vec4.aagb swizzling (equivalent to vec4.wwyz).
        /// </summary>
        public vec4 aagb => new vec4(w, w, y, z);
        
        /// <summary>
        /// Returns vec4.wwyw swizzling.
        /// </summary>
        public vec4 wwyw => new vec4(w, w, y, w);
        
        /// <summary>
        /// Returns vec4.aaga swizzling (equivalent to vec4.wwyw).
        /// </summary>
        public vec4 aaga => new vec4(w, w, y, w);
        
        /// <summary>
        /// Returns vec4.wwz swizzling.
        /// </summary>
        public vec3 wwz => new vec3(w, w, z);
        
        /// <summary>
        /// Returns vec4.aab swizzling (equivalent to vec4.wwz).
        /// </summary>
        public vec3 aab => new vec3(w, w, z);
        
        /// <summary>
        /// Returns vec4.wwzx swizzling.
        /// </summary>
        public vec4 wwzx => new vec4(w, w, z, x);
        
        /// <summary>
        /// Returns vec4.aabr swizzling (equivalent to vec4.wwzx).
        /// </summary>
        public vec4 aabr => new vec4(w, w, z, x);
        
        /// <summary>
        /// Returns vec4.wwzy swizzling.
        /// </summary>
        public vec4 wwzy => new vec4(w, w, z, y);
        
        /// <summary>
        /// Returns vec4.aabg swizzling (equivalent to vec4.wwzy).
        /// </summary>
        public vec4 aabg => new vec4(w, w, z, y);
        
        /// <summary>
        /// Returns vec4.wwzz swizzling.
        /// </summary>
        public vec4 wwzz => new vec4(w, w, z, z);
        
        /// <summary>
        /// Returns vec4.aabb swizzling (equivalent to vec4.wwzz).
        /// </summary>
        public vec4 aabb => new vec4(w, w, z, z);
        
        /// <summary>
        /// Returns vec4.wwzw swizzling.
        /// </summary>
        public vec4 wwzw => new vec4(w, w, z, w);
        
        /// <summary>
        /// Returns vec4.aaba swizzling (equivalent to vec4.wwzw).
        /// </summary>
        public vec4 aaba => new vec4(w, w, z, w);
        
        /// <summary>
        /// Returns vec4.www swizzling.
        /// </summary>
        public vec3 www => new vec3(w, w, w);
        
        /// <summary>
        /// Returns vec4.aaa swizzling (equivalent to vec4.www).
        /// </summary>
        public vec3 aaa => new vec3(w, w, w);
        
        /// <summary>
        /// Returns vec4.wwwx swizzling.
        /// </summary>
        public vec4 wwwx => new vec4(w, w, w, x);
        
        /// <summary>
        /// Returns vec4.aaar swizzling (equivalent to vec4.wwwx).
        /// </summary>
        public vec4 aaar => new vec4(w, w, w, x);
        
        /// <summary>
        /// Returns vec4.wwwy swizzling.
        /// </summary>
        public vec4 wwwy => new vec4(w, w, w, y);
        
        /// <summary>
        /// Returns vec4.aaag swizzling (equivalent to vec4.wwwy).
        /// </summary>
        public vec4 aaag => new vec4(w, w, w, y);
        
        /// <summary>
        /// Returns vec4.wwwz swizzling.
        /// </summary>
        public vec4 wwwz => new vec4(w, w, w, z);
        
        /// <summary>
        /// Returns vec4.aaab swizzling (equivalent to vec4.wwwz).
        /// </summary>
        public vec4 aaab => new vec4(w, w, w, z);
        
        /// <summary>
        /// Returns vec4.wwww swizzling.
        /// </summary>
        public vec4 wwww => new vec4(w, w, w, w);
        
        /// <summary>
        /// Returns vec4.aaaa swizzling (equivalent to vec4.wwww).
        /// </summary>
        public vec4 aaaa => new vec4(w, w, w, w);

        #endregion

    }
}
