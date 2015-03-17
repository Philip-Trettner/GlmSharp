using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Linq;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp.Swizzle
{
    
    /// <summary>
    /// Temporary vector of type uint with 4 components, used for implementing swizzling for uvec4.
    /// </summary>
    [Serializable]
    [DataContract]
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
        
        // XYZW Versions
        
        /// <summary>
        /// Returns uvec4.xx swizzling.
        /// </summary>
        public uvec2 xx => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec4.xxx swizzling.
        /// </summary>
        public uvec3 xxx => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec4.xxxx swizzling.
        /// </summary>
        public uvec4 xxxx => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.xxxy swizzling.
        /// </summary>
        public uvec4 xxxy => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.xxxz swizzling.
        /// </summary>
        public uvec4 xxxz => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.xxxw swizzling.
        /// </summary>
        public uvec4 xxxw => new uvec4(x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.xxy swizzling.
        /// </summary>
        public uvec3 xxy => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec4.xxyx swizzling.
        /// </summary>
        public uvec4 xxyx => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.xxyy swizzling.
        /// </summary>
        public uvec4 xxyy => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.xxyz swizzling.
        /// </summary>
        public uvec4 xxyz => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.xxyw swizzling.
        /// </summary>
        public uvec4 xxyw => new uvec4(x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.xxz swizzling.
        /// </summary>
        public uvec3 xxz => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec4.xxzx swizzling.
        /// </summary>
        public uvec4 xxzx => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.xxzy swizzling.
        /// </summary>
        public uvec4 xxzy => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.xxzz swizzling.
        /// </summary>
        public uvec4 xxzz => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.xxzw swizzling.
        /// </summary>
        public uvec4 xxzw => new uvec4(x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.xxw swizzling.
        /// </summary>
        public uvec3 xxw => new uvec3(x, x, w);
        
        /// <summary>
        /// Returns uvec4.xxwx swizzling.
        /// </summary>
        public uvec4 xxwx => new uvec4(x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.xxwy swizzling.
        /// </summary>
        public uvec4 xxwy => new uvec4(x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.xxwz swizzling.
        /// </summary>
        public uvec4 xxwz => new uvec4(x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.xxww swizzling.
        /// </summary>
        public uvec4 xxww => new uvec4(x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.xy swizzling.
        /// </summary>
        public uvec2 xy => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec4.xyx swizzling.
        /// </summary>
        public uvec3 xyx => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec4.xyxx swizzling.
        /// </summary>
        public uvec4 xyxx => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.xyxy swizzling.
        /// </summary>
        public uvec4 xyxy => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.xyxz swizzling.
        /// </summary>
        public uvec4 xyxz => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.xyxw swizzling.
        /// </summary>
        public uvec4 xyxw => new uvec4(x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.xyy swizzling.
        /// </summary>
        public uvec3 xyy => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec4.xyyx swizzling.
        /// </summary>
        public uvec4 xyyx => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.xyyy swizzling.
        /// </summary>
        public uvec4 xyyy => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.xyyz swizzling.
        /// </summary>
        public uvec4 xyyz => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.xyyw swizzling.
        /// </summary>
        public uvec4 xyyw => new uvec4(x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.xyz swizzling.
        /// </summary>
        public uvec3 xyz => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec4.xyzx swizzling.
        /// </summary>
        public uvec4 xyzx => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.xyzy swizzling.
        /// </summary>
        public uvec4 xyzy => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.xyzz swizzling.
        /// </summary>
        public uvec4 xyzz => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.xyzw swizzling.
        /// </summary>
        public uvec4 xyzw => new uvec4(x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.xyw swizzling.
        /// </summary>
        public uvec3 xyw => new uvec3(x, y, w);
        
        /// <summary>
        /// Returns uvec4.xywx swizzling.
        /// </summary>
        public uvec4 xywx => new uvec4(x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.xywy swizzling.
        /// </summary>
        public uvec4 xywy => new uvec4(x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.xywz swizzling.
        /// </summary>
        public uvec4 xywz => new uvec4(x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.xyww swizzling.
        /// </summary>
        public uvec4 xyww => new uvec4(x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.xz swizzling.
        /// </summary>
        public uvec2 xz => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec4.xzx swizzling.
        /// </summary>
        public uvec3 xzx => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec4.xzxx swizzling.
        /// </summary>
        public uvec4 xzxx => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.xzxy swizzling.
        /// </summary>
        public uvec4 xzxy => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.xzxz swizzling.
        /// </summary>
        public uvec4 xzxz => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.xzxw swizzling.
        /// </summary>
        public uvec4 xzxw => new uvec4(x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.xzy swizzling.
        /// </summary>
        public uvec3 xzy => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec4.xzyx swizzling.
        /// </summary>
        public uvec4 xzyx => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.xzyy swizzling.
        /// </summary>
        public uvec4 xzyy => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.xzyz swizzling.
        /// </summary>
        public uvec4 xzyz => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.xzyw swizzling.
        /// </summary>
        public uvec4 xzyw => new uvec4(x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.xzz swizzling.
        /// </summary>
        public uvec3 xzz => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec4.xzzx swizzling.
        /// </summary>
        public uvec4 xzzx => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.xzzy swizzling.
        /// </summary>
        public uvec4 xzzy => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.xzzz swizzling.
        /// </summary>
        public uvec4 xzzz => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.xzzw swizzling.
        /// </summary>
        public uvec4 xzzw => new uvec4(x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.xzw swizzling.
        /// </summary>
        public uvec3 xzw => new uvec3(x, z, w);
        
        /// <summary>
        /// Returns uvec4.xzwx swizzling.
        /// </summary>
        public uvec4 xzwx => new uvec4(x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.xzwy swizzling.
        /// </summary>
        public uvec4 xzwy => new uvec4(x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.xzwz swizzling.
        /// </summary>
        public uvec4 xzwz => new uvec4(x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.xzww swizzling.
        /// </summary>
        public uvec4 xzww => new uvec4(x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.xw swizzling.
        /// </summary>
        public uvec2 xw => new uvec2(x, w);
        
        /// <summary>
        /// Returns uvec4.xwx swizzling.
        /// </summary>
        public uvec3 xwx => new uvec3(x, w, x);
        
        /// <summary>
        /// Returns uvec4.xwxx swizzling.
        /// </summary>
        public uvec4 xwxx => new uvec4(x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.xwxy swizzling.
        /// </summary>
        public uvec4 xwxy => new uvec4(x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.xwxz swizzling.
        /// </summary>
        public uvec4 xwxz => new uvec4(x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.xwxw swizzling.
        /// </summary>
        public uvec4 xwxw => new uvec4(x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.xwy swizzling.
        /// </summary>
        public uvec3 xwy => new uvec3(x, w, y);
        
        /// <summary>
        /// Returns uvec4.xwyx swizzling.
        /// </summary>
        public uvec4 xwyx => new uvec4(x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.xwyy swizzling.
        /// </summary>
        public uvec4 xwyy => new uvec4(x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.xwyz swizzling.
        /// </summary>
        public uvec4 xwyz => new uvec4(x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.xwyw swizzling.
        /// </summary>
        public uvec4 xwyw => new uvec4(x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.xwz swizzling.
        /// </summary>
        public uvec3 xwz => new uvec3(x, w, z);
        
        /// <summary>
        /// Returns uvec4.xwzx swizzling.
        /// </summary>
        public uvec4 xwzx => new uvec4(x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.xwzy swizzling.
        /// </summary>
        public uvec4 xwzy => new uvec4(x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.xwzz swizzling.
        /// </summary>
        public uvec4 xwzz => new uvec4(x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.xwzw swizzling.
        /// </summary>
        public uvec4 xwzw => new uvec4(x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.xww swizzling.
        /// </summary>
        public uvec3 xww => new uvec3(x, w, w);
        
        /// <summary>
        /// Returns uvec4.xwwx swizzling.
        /// </summary>
        public uvec4 xwwx => new uvec4(x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.xwwy swizzling.
        /// </summary>
        public uvec4 xwwy => new uvec4(x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.xwwz swizzling.
        /// </summary>
        public uvec4 xwwz => new uvec4(x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.xwww swizzling.
        /// </summary>
        public uvec4 xwww => new uvec4(x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.yx swizzling.
        /// </summary>
        public uvec2 yx => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec4.yxx swizzling.
        /// </summary>
        public uvec3 yxx => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec4.yxxx swizzling.
        /// </summary>
        public uvec4 yxxx => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.yxxy swizzling.
        /// </summary>
        public uvec4 yxxy => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.yxxz swizzling.
        /// </summary>
        public uvec4 yxxz => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.yxxw swizzling.
        /// </summary>
        public uvec4 yxxw => new uvec4(y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.yxy swizzling.
        /// </summary>
        public uvec3 yxy => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec4.yxyx swizzling.
        /// </summary>
        public uvec4 yxyx => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.yxyy swizzling.
        /// </summary>
        public uvec4 yxyy => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.yxyz swizzling.
        /// </summary>
        public uvec4 yxyz => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.yxyw swizzling.
        /// </summary>
        public uvec4 yxyw => new uvec4(y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.yxz swizzling.
        /// </summary>
        public uvec3 yxz => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec4.yxzx swizzling.
        /// </summary>
        public uvec4 yxzx => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.yxzy swizzling.
        /// </summary>
        public uvec4 yxzy => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.yxzz swizzling.
        /// </summary>
        public uvec4 yxzz => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.yxzw swizzling.
        /// </summary>
        public uvec4 yxzw => new uvec4(y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.yxw swizzling.
        /// </summary>
        public uvec3 yxw => new uvec3(y, x, w);
        
        /// <summary>
        /// Returns uvec4.yxwx swizzling.
        /// </summary>
        public uvec4 yxwx => new uvec4(y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.yxwy swizzling.
        /// </summary>
        public uvec4 yxwy => new uvec4(y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.yxwz swizzling.
        /// </summary>
        public uvec4 yxwz => new uvec4(y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.yxww swizzling.
        /// </summary>
        public uvec4 yxww => new uvec4(y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.yy swizzling.
        /// </summary>
        public uvec2 yy => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec4.yyx swizzling.
        /// </summary>
        public uvec3 yyx => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec4.yyxx swizzling.
        /// </summary>
        public uvec4 yyxx => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.yyxy swizzling.
        /// </summary>
        public uvec4 yyxy => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.yyxz swizzling.
        /// </summary>
        public uvec4 yyxz => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.yyxw swizzling.
        /// </summary>
        public uvec4 yyxw => new uvec4(y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.yyy swizzling.
        /// </summary>
        public uvec3 yyy => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec4.yyyx swizzling.
        /// </summary>
        public uvec4 yyyx => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.yyyy swizzling.
        /// </summary>
        public uvec4 yyyy => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.yyyz swizzling.
        /// </summary>
        public uvec4 yyyz => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.yyyw swizzling.
        /// </summary>
        public uvec4 yyyw => new uvec4(y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.yyz swizzling.
        /// </summary>
        public uvec3 yyz => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec4.yyzx swizzling.
        /// </summary>
        public uvec4 yyzx => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.yyzy swizzling.
        /// </summary>
        public uvec4 yyzy => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.yyzz swizzling.
        /// </summary>
        public uvec4 yyzz => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.yyzw swizzling.
        /// </summary>
        public uvec4 yyzw => new uvec4(y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.yyw swizzling.
        /// </summary>
        public uvec3 yyw => new uvec3(y, y, w);
        
        /// <summary>
        /// Returns uvec4.yywx swizzling.
        /// </summary>
        public uvec4 yywx => new uvec4(y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.yywy swizzling.
        /// </summary>
        public uvec4 yywy => new uvec4(y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.yywz swizzling.
        /// </summary>
        public uvec4 yywz => new uvec4(y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.yyww swizzling.
        /// </summary>
        public uvec4 yyww => new uvec4(y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.yz swizzling.
        /// </summary>
        public uvec2 yz => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec4.yzx swizzling.
        /// </summary>
        public uvec3 yzx => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec4.yzxx swizzling.
        /// </summary>
        public uvec4 yzxx => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.yzxy swizzling.
        /// </summary>
        public uvec4 yzxy => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.yzxz swizzling.
        /// </summary>
        public uvec4 yzxz => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.yzxw swizzling.
        /// </summary>
        public uvec4 yzxw => new uvec4(y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.yzy swizzling.
        /// </summary>
        public uvec3 yzy => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec4.yzyx swizzling.
        /// </summary>
        public uvec4 yzyx => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.yzyy swizzling.
        /// </summary>
        public uvec4 yzyy => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.yzyz swizzling.
        /// </summary>
        public uvec4 yzyz => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.yzyw swizzling.
        /// </summary>
        public uvec4 yzyw => new uvec4(y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.yzz swizzling.
        /// </summary>
        public uvec3 yzz => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec4.yzzx swizzling.
        /// </summary>
        public uvec4 yzzx => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.yzzy swizzling.
        /// </summary>
        public uvec4 yzzy => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.yzzz swizzling.
        /// </summary>
        public uvec4 yzzz => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.yzzw swizzling.
        /// </summary>
        public uvec4 yzzw => new uvec4(y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.yzw swizzling.
        /// </summary>
        public uvec3 yzw => new uvec3(y, z, w);
        
        /// <summary>
        /// Returns uvec4.yzwx swizzling.
        /// </summary>
        public uvec4 yzwx => new uvec4(y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.yzwy swizzling.
        /// </summary>
        public uvec4 yzwy => new uvec4(y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.yzwz swizzling.
        /// </summary>
        public uvec4 yzwz => new uvec4(y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.yzww swizzling.
        /// </summary>
        public uvec4 yzww => new uvec4(y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.yw swizzling.
        /// </summary>
        public uvec2 yw => new uvec2(y, w);
        
        /// <summary>
        /// Returns uvec4.ywx swizzling.
        /// </summary>
        public uvec3 ywx => new uvec3(y, w, x);
        
        /// <summary>
        /// Returns uvec4.ywxx swizzling.
        /// </summary>
        public uvec4 ywxx => new uvec4(y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.ywxy swizzling.
        /// </summary>
        public uvec4 ywxy => new uvec4(y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.ywxz swizzling.
        /// </summary>
        public uvec4 ywxz => new uvec4(y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.ywxw swizzling.
        /// </summary>
        public uvec4 ywxw => new uvec4(y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.ywy swizzling.
        /// </summary>
        public uvec3 ywy => new uvec3(y, w, y);
        
        /// <summary>
        /// Returns uvec4.ywyx swizzling.
        /// </summary>
        public uvec4 ywyx => new uvec4(y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.ywyy swizzling.
        /// </summary>
        public uvec4 ywyy => new uvec4(y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.ywyz swizzling.
        /// </summary>
        public uvec4 ywyz => new uvec4(y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.ywyw swizzling.
        /// </summary>
        public uvec4 ywyw => new uvec4(y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.ywz swizzling.
        /// </summary>
        public uvec3 ywz => new uvec3(y, w, z);
        
        /// <summary>
        /// Returns uvec4.ywzx swizzling.
        /// </summary>
        public uvec4 ywzx => new uvec4(y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.ywzy swizzling.
        /// </summary>
        public uvec4 ywzy => new uvec4(y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.ywzz swizzling.
        /// </summary>
        public uvec4 ywzz => new uvec4(y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.ywzw swizzling.
        /// </summary>
        public uvec4 ywzw => new uvec4(y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.yww swizzling.
        /// </summary>
        public uvec3 yww => new uvec3(y, w, w);
        
        /// <summary>
        /// Returns uvec4.ywwx swizzling.
        /// </summary>
        public uvec4 ywwx => new uvec4(y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.ywwy swizzling.
        /// </summary>
        public uvec4 ywwy => new uvec4(y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.ywwz swizzling.
        /// </summary>
        public uvec4 ywwz => new uvec4(y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.ywww swizzling.
        /// </summary>
        public uvec4 ywww => new uvec4(y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.zx swizzling.
        /// </summary>
        public uvec2 zx => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec4.zxx swizzling.
        /// </summary>
        public uvec3 zxx => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec4.zxxx swizzling.
        /// </summary>
        public uvec4 zxxx => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.zxxy swizzling.
        /// </summary>
        public uvec4 zxxy => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.zxxz swizzling.
        /// </summary>
        public uvec4 zxxz => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.zxxw swizzling.
        /// </summary>
        public uvec4 zxxw => new uvec4(z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.zxy swizzling.
        /// </summary>
        public uvec3 zxy => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec4.zxyx swizzling.
        /// </summary>
        public uvec4 zxyx => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.zxyy swizzling.
        /// </summary>
        public uvec4 zxyy => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.zxyz swizzling.
        /// </summary>
        public uvec4 zxyz => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.zxyw swizzling.
        /// </summary>
        public uvec4 zxyw => new uvec4(z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.zxz swizzling.
        /// </summary>
        public uvec3 zxz => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec4.zxzx swizzling.
        /// </summary>
        public uvec4 zxzx => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.zxzy swizzling.
        /// </summary>
        public uvec4 zxzy => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.zxzz swizzling.
        /// </summary>
        public uvec4 zxzz => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.zxzw swizzling.
        /// </summary>
        public uvec4 zxzw => new uvec4(z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.zxw swizzling.
        /// </summary>
        public uvec3 zxw => new uvec3(z, x, w);
        
        /// <summary>
        /// Returns uvec4.zxwx swizzling.
        /// </summary>
        public uvec4 zxwx => new uvec4(z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.zxwy swizzling.
        /// </summary>
        public uvec4 zxwy => new uvec4(z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.zxwz swizzling.
        /// </summary>
        public uvec4 zxwz => new uvec4(z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.zxww swizzling.
        /// </summary>
        public uvec4 zxww => new uvec4(z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.zy swizzling.
        /// </summary>
        public uvec2 zy => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec4.zyx swizzling.
        /// </summary>
        public uvec3 zyx => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec4.zyxx swizzling.
        /// </summary>
        public uvec4 zyxx => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.zyxy swizzling.
        /// </summary>
        public uvec4 zyxy => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.zyxz swizzling.
        /// </summary>
        public uvec4 zyxz => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.zyxw swizzling.
        /// </summary>
        public uvec4 zyxw => new uvec4(z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.zyy swizzling.
        /// </summary>
        public uvec3 zyy => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec4.zyyx swizzling.
        /// </summary>
        public uvec4 zyyx => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.zyyy swizzling.
        /// </summary>
        public uvec4 zyyy => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.zyyz swizzling.
        /// </summary>
        public uvec4 zyyz => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.zyyw swizzling.
        /// </summary>
        public uvec4 zyyw => new uvec4(z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.zyz swizzling.
        /// </summary>
        public uvec3 zyz => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec4.zyzx swizzling.
        /// </summary>
        public uvec4 zyzx => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.zyzy swizzling.
        /// </summary>
        public uvec4 zyzy => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.zyzz swizzling.
        /// </summary>
        public uvec4 zyzz => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.zyzw swizzling.
        /// </summary>
        public uvec4 zyzw => new uvec4(z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.zyw swizzling.
        /// </summary>
        public uvec3 zyw => new uvec3(z, y, w);
        
        /// <summary>
        /// Returns uvec4.zywx swizzling.
        /// </summary>
        public uvec4 zywx => new uvec4(z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.zywy swizzling.
        /// </summary>
        public uvec4 zywy => new uvec4(z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.zywz swizzling.
        /// </summary>
        public uvec4 zywz => new uvec4(z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.zyww swizzling.
        /// </summary>
        public uvec4 zyww => new uvec4(z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.zz swizzling.
        /// </summary>
        public uvec2 zz => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec4.zzx swizzling.
        /// </summary>
        public uvec3 zzx => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec4.zzxx swizzling.
        /// </summary>
        public uvec4 zzxx => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.zzxy swizzling.
        /// </summary>
        public uvec4 zzxy => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.zzxz swizzling.
        /// </summary>
        public uvec4 zzxz => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.zzxw swizzling.
        /// </summary>
        public uvec4 zzxw => new uvec4(z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.zzy swizzling.
        /// </summary>
        public uvec3 zzy => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec4.zzyx swizzling.
        /// </summary>
        public uvec4 zzyx => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.zzyy swizzling.
        /// </summary>
        public uvec4 zzyy => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.zzyz swizzling.
        /// </summary>
        public uvec4 zzyz => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.zzyw swizzling.
        /// </summary>
        public uvec4 zzyw => new uvec4(z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.zzz swizzling.
        /// </summary>
        public uvec3 zzz => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec4.zzzx swizzling.
        /// </summary>
        public uvec4 zzzx => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.zzzy swizzling.
        /// </summary>
        public uvec4 zzzy => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.zzzz swizzling.
        /// </summary>
        public uvec4 zzzz => new uvec4(z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.zzzw swizzling.
        /// </summary>
        public uvec4 zzzw => new uvec4(z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.zzw swizzling.
        /// </summary>
        public uvec3 zzw => new uvec3(z, z, w);
        
        /// <summary>
        /// Returns uvec4.zzwx swizzling.
        /// </summary>
        public uvec4 zzwx => new uvec4(z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.zzwy swizzling.
        /// </summary>
        public uvec4 zzwy => new uvec4(z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.zzwz swizzling.
        /// </summary>
        public uvec4 zzwz => new uvec4(z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.zzww swizzling.
        /// </summary>
        public uvec4 zzww => new uvec4(z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.zw swizzling.
        /// </summary>
        public uvec2 zw => new uvec2(z, w);
        
        /// <summary>
        /// Returns uvec4.zwx swizzling.
        /// </summary>
        public uvec3 zwx => new uvec3(z, w, x);
        
        /// <summary>
        /// Returns uvec4.zwxx swizzling.
        /// </summary>
        public uvec4 zwxx => new uvec4(z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.zwxy swizzling.
        /// </summary>
        public uvec4 zwxy => new uvec4(z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.zwxz swizzling.
        /// </summary>
        public uvec4 zwxz => new uvec4(z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.zwxw swizzling.
        /// </summary>
        public uvec4 zwxw => new uvec4(z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.zwy swizzling.
        /// </summary>
        public uvec3 zwy => new uvec3(z, w, y);
        
        /// <summary>
        /// Returns uvec4.zwyx swizzling.
        /// </summary>
        public uvec4 zwyx => new uvec4(z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.zwyy swizzling.
        /// </summary>
        public uvec4 zwyy => new uvec4(z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.zwyz swizzling.
        /// </summary>
        public uvec4 zwyz => new uvec4(z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.zwyw swizzling.
        /// </summary>
        public uvec4 zwyw => new uvec4(z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.zwz swizzling.
        /// </summary>
        public uvec3 zwz => new uvec3(z, w, z);
        
        /// <summary>
        /// Returns uvec4.zwzx swizzling.
        /// </summary>
        public uvec4 zwzx => new uvec4(z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.zwzy swizzling.
        /// </summary>
        public uvec4 zwzy => new uvec4(z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.zwzz swizzling.
        /// </summary>
        public uvec4 zwzz => new uvec4(z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.zwzw swizzling.
        /// </summary>
        public uvec4 zwzw => new uvec4(z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.zww swizzling.
        /// </summary>
        public uvec3 zww => new uvec3(z, w, w);
        
        /// <summary>
        /// Returns uvec4.zwwx swizzling.
        /// </summary>
        public uvec4 zwwx => new uvec4(z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.zwwy swizzling.
        /// </summary>
        public uvec4 zwwy => new uvec4(z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.zwwz swizzling.
        /// </summary>
        public uvec4 zwwz => new uvec4(z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.zwww swizzling.
        /// </summary>
        public uvec4 zwww => new uvec4(z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.wx swizzling.
        /// </summary>
        public uvec2 wx => new uvec2(w, x);
        
        /// <summary>
        /// Returns uvec4.wxx swizzling.
        /// </summary>
        public uvec3 wxx => new uvec3(w, x, x);
        
        /// <summary>
        /// Returns uvec4.wxxx swizzling.
        /// </summary>
        public uvec4 wxxx => new uvec4(w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.wxxy swizzling.
        /// </summary>
        public uvec4 wxxy => new uvec4(w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.wxxz swizzling.
        /// </summary>
        public uvec4 wxxz => new uvec4(w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.wxxw swizzling.
        /// </summary>
        public uvec4 wxxw => new uvec4(w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.wxy swizzling.
        /// </summary>
        public uvec3 wxy => new uvec3(w, x, y);
        
        /// <summary>
        /// Returns uvec4.wxyx swizzling.
        /// </summary>
        public uvec4 wxyx => new uvec4(w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.wxyy swizzling.
        /// </summary>
        public uvec4 wxyy => new uvec4(w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.wxyz swizzling.
        /// </summary>
        public uvec4 wxyz => new uvec4(w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.wxyw swizzling.
        /// </summary>
        public uvec4 wxyw => new uvec4(w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.wxz swizzling.
        /// </summary>
        public uvec3 wxz => new uvec3(w, x, z);
        
        /// <summary>
        /// Returns uvec4.wxzx swizzling.
        /// </summary>
        public uvec4 wxzx => new uvec4(w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.wxzy swizzling.
        /// </summary>
        public uvec4 wxzy => new uvec4(w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.wxzz swizzling.
        /// </summary>
        public uvec4 wxzz => new uvec4(w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.wxzw swizzling.
        /// </summary>
        public uvec4 wxzw => new uvec4(w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.wxw swizzling.
        /// </summary>
        public uvec3 wxw => new uvec3(w, x, w);
        
        /// <summary>
        /// Returns uvec4.wxwx swizzling.
        /// </summary>
        public uvec4 wxwx => new uvec4(w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.wxwy swizzling.
        /// </summary>
        public uvec4 wxwy => new uvec4(w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.wxwz swizzling.
        /// </summary>
        public uvec4 wxwz => new uvec4(w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.wxww swizzling.
        /// </summary>
        public uvec4 wxww => new uvec4(w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.wy swizzling.
        /// </summary>
        public uvec2 wy => new uvec2(w, y);
        
        /// <summary>
        /// Returns uvec4.wyx swizzling.
        /// </summary>
        public uvec3 wyx => new uvec3(w, y, x);
        
        /// <summary>
        /// Returns uvec4.wyxx swizzling.
        /// </summary>
        public uvec4 wyxx => new uvec4(w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.wyxy swizzling.
        /// </summary>
        public uvec4 wyxy => new uvec4(w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.wyxz swizzling.
        /// </summary>
        public uvec4 wyxz => new uvec4(w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.wyxw swizzling.
        /// </summary>
        public uvec4 wyxw => new uvec4(w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.wyy swizzling.
        /// </summary>
        public uvec3 wyy => new uvec3(w, y, y);
        
        /// <summary>
        /// Returns uvec4.wyyx swizzling.
        /// </summary>
        public uvec4 wyyx => new uvec4(w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.wyyy swizzling.
        /// </summary>
        public uvec4 wyyy => new uvec4(w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.wyyz swizzling.
        /// </summary>
        public uvec4 wyyz => new uvec4(w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.wyyw swizzling.
        /// </summary>
        public uvec4 wyyw => new uvec4(w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.wyz swizzling.
        /// </summary>
        public uvec3 wyz => new uvec3(w, y, z);
        
        /// <summary>
        /// Returns uvec4.wyzx swizzling.
        /// </summary>
        public uvec4 wyzx => new uvec4(w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.wyzy swizzling.
        /// </summary>
        public uvec4 wyzy => new uvec4(w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.wyzz swizzling.
        /// </summary>
        public uvec4 wyzz => new uvec4(w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.wyzw swizzling.
        /// </summary>
        public uvec4 wyzw => new uvec4(w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.wyw swizzling.
        /// </summary>
        public uvec3 wyw => new uvec3(w, y, w);
        
        /// <summary>
        /// Returns uvec4.wywx swizzling.
        /// </summary>
        public uvec4 wywx => new uvec4(w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.wywy swizzling.
        /// </summary>
        public uvec4 wywy => new uvec4(w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.wywz swizzling.
        /// </summary>
        public uvec4 wywz => new uvec4(w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.wyww swizzling.
        /// </summary>
        public uvec4 wyww => new uvec4(w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.wz swizzling.
        /// </summary>
        public uvec2 wz => new uvec2(w, z);
        
        /// <summary>
        /// Returns uvec4.wzx swizzling.
        /// </summary>
        public uvec3 wzx => new uvec3(w, z, x);
        
        /// <summary>
        /// Returns uvec4.wzxx swizzling.
        /// </summary>
        public uvec4 wzxx => new uvec4(w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.wzxy swizzling.
        /// </summary>
        public uvec4 wzxy => new uvec4(w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.wzxz swizzling.
        /// </summary>
        public uvec4 wzxz => new uvec4(w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.wzxw swizzling.
        /// </summary>
        public uvec4 wzxw => new uvec4(w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.wzy swizzling.
        /// </summary>
        public uvec3 wzy => new uvec3(w, z, y);
        
        /// <summary>
        /// Returns uvec4.wzyx swizzling.
        /// </summary>
        public uvec4 wzyx => new uvec4(w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.wzyy swizzling.
        /// </summary>
        public uvec4 wzyy => new uvec4(w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.wzyz swizzling.
        /// </summary>
        public uvec4 wzyz => new uvec4(w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.wzyw swizzling.
        /// </summary>
        public uvec4 wzyw => new uvec4(w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.wzz swizzling.
        /// </summary>
        public uvec3 wzz => new uvec3(w, z, z);
        
        /// <summary>
        /// Returns uvec4.wzzx swizzling.
        /// </summary>
        public uvec4 wzzx => new uvec4(w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.wzzy swizzling.
        /// </summary>
        public uvec4 wzzy => new uvec4(w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.wzzz swizzling.
        /// </summary>
        public uvec4 wzzz => new uvec4(w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.wzzw swizzling.
        /// </summary>
        public uvec4 wzzw => new uvec4(w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.wzw swizzling.
        /// </summary>
        public uvec3 wzw => new uvec3(w, z, w);
        
        /// <summary>
        /// Returns uvec4.wzwx swizzling.
        /// </summary>
        public uvec4 wzwx => new uvec4(w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.wzwy swizzling.
        /// </summary>
        public uvec4 wzwy => new uvec4(w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.wzwz swizzling.
        /// </summary>
        public uvec4 wzwz => new uvec4(w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.wzww swizzling.
        /// </summary>
        public uvec4 wzww => new uvec4(w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.ww swizzling.
        /// </summary>
        public uvec2 ww => new uvec2(w, w);
        
        /// <summary>
        /// Returns uvec4.wwx swizzling.
        /// </summary>
        public uvec3 wwx => new uvec3(w, w, x);
        
        /// <summary>
        /// Returns uvec4.wwxx swizzling.
        /// </summary>
        public uvec4 wwxx => new uvec4(w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.wwxy swizzling.
        /// </summary>
        public uvec4 wwxy => new uvec4(w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.wwxz swizzling.
        /// </summary>
        public uvec4 wwxz => new uvec4(w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.wwxw swizzling.
        /// </summary>
        public uvec4 wwxw => new uvec4(w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.wwy swizzling.
        /// </summary>
        public uvec3 wwy => new uvec3(w, w, y);
        
        /// <summary>
        /// Returns uvec4.wwyx swizzling.
        /// </summary>
        public uvec4 wwyx => new uvec4(w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.wwyy swizzling.
        /// </summary>
        public uvec4 wwyy => new uvec4(w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.wwyz swizzling.
        /// </summary>
        public uvec4 wwyz => new uvec4(w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.wwyw swizzling.
        /// </summary>
        public uvec4 wwyw => new uvec4(w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.wwz swizzling.
        /// </summary>
        public uvec3 wwz => new uvec3(w, w, z);
        
        /// <summary>
        /// Returns uvec4.wwzx swizzling.
        /// </summary>
        public uvec4 wwzx => new uvec4(w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.wwzy swizzling.
        /// </summary>
        public uvec4 wwzy => new uvec4(w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.wwzz swizzling.
        /// </summary>
        public uvec4 wwzz => new uvec4(w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.wwzw swizzling.
        /// </summary>
        public uvec4 wwzw => new uvec4(w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.www swizzling.
        /// </summary>
        public uvec3 www => new uvec3(w, w, w);
        
        /// <summary>
        /// Returns uvec4.wwwx swizzling.
        /// </summary>
        public uvec4 wwwx => new uvec4(w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.wwwy swizzling.
        /// </summary>
        public uvec4 wwwy => new uvec4(w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.wwwz swizzling.
        /// </summary>
        public uvec4 wwwz => new uvec4(w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.wwww swizzling.
        /// </summary>
        public uvec4 wwww => new uvec4(w, w, w, w);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns uvec4.rr swizzling.
        /// </summary>
        public uvec2 rr => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec4.rrr swizzling.
        /// </summary>
        public uvec3 rrr => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec4.rrrr swizzling.
        /// </summary>
        public uvec4 rrrr => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec4.rrrg swizzling.
        /// </summary>
        public uvec4 rrrg => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec4.rrrb swizzling.
        /// </summary>
        public uvec4 rrrb => new uvec4(x, x, x, z);
        
        /// <summary>
        /// Returns uvec4.rrra swizzling.
        /// </summary>
        public uvec4 rrra => new uvec4(x, x, x, w);
        
        /// <summary>
        /// Returns uvec4.rrg swizzling.
        /// </summary>
        public uvec3 rrg => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec4.rrgr swizzling.
        /// </summary>
        public uvec4 rrgr => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec4.rrgg swizzling.
        /// </summary>
        public uvec4 rrgg => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec4.rrgb swizzling.
        /// </summary>
        public uvec4 rrgb => new uvec4(x, x, y, z);
        
        /// <summary>
        /// Returns uvec4.rrga swizzling.
        /// </summary>
        public uvec4 rrga => new uvec4(x, x, y, w);
        
        /// <summary>
        /// Returns uvec4.rrb swizzling.
        /// </summary>
        public uvec3 rrb => new uvec3(x, x, z);
        
        /// <summary>
        /// Returns uvec4.rrbr swizzling.
        /// </summary>
        public uvec4 rrbr => new uvec4(x, x, z, x);
        
        /// <summary>
        /// Returns uvec4.rrbg swizzling.
        /// </summary>
        public uvec4 rrbg => new uvec4(x, x, z, y);
        
        /// <summary>
        /// Returns uvec4.rrbb swizzling.
        /// </summary>
        public uvec4 rrbb => new uvec4(x, x, z, z);
        
        /// <summary>
        /// Returns uvec4.rrba swizzling.
        /// </summary>
        public uvec4 rrba => new uvec4(x, x, z, w);
        
        /// <summary>
        /// Returns uvec4.rra swizzling.
        /// </summary>
        public uvec3 rra => new uvec3(x, x, w);
        
        /// <summary>
        /// Returns uvec4.rrar swizzling.
        /// </summary>
        public uvec4 rrar => new uvec4(x, x, w, x);
        
        /// <summary>
        /// Returns uvec4.rrag swizzling.
        /// </summary>
        public uvec4 rrag => new uvec4(x, x, w, y);
        
        /// <summary>
        /// Returns uvec4.rrab swizzling.
        /// </summary>
        public uvec4 rrab => new uvec4(x, x, w, z);
        
        /// <summary>
        /// Returns uvec4.rraa swizzling.
        /// </summary>
        public uvec4 rraa => new uvec4(x, x, w, w);
        
        /// <summary>
        /// Returns uvec4.rg swizzling.
        /// </summary>
        public uvec2 rg => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec4.rgr swizzling.
        /// </summary>
        public uvec3 rgr => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec4.rgrr swizzling.
        /// </summary>
        public uvec4 rgrr => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec4.rgrg swizzling.
        /// </summary>
        public uvec4 rgrg => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec4.rgrb swizzling.
        /// </summary>
        public uvec4 rgrb => new uvec4(x, y, x, z);
        
        /// <summary>
        /// Returns uvec4.rgra swizzling.
        /// </summary>
        public uvec4 rgra => new uvec4(x, y, x, w);
        
        /// <summary>
        /// Returns uvec4.rgg swizzling.
        /// </summary>
        public uvec3 rgg => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec4.rggr swizzling.
        /// </summary>
        public uvec4 rggr => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec4.rggg swizzling.
        /// </summary>
        public uvec4 rggg => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec4.rggb swizzling.
        /// </summary>
        public uvec4 rggb => new uvec4(x, y, y, z);
        
        /// <summary>
        /// Returns uvec4.rgga swizzling.
        /// </summary>
        public uvec4 rgga => new uvec4(x, y, y, w);
        
        /// <summary>
        /// Returns uvec4.rgb swizzling.
        /// </summary>
        public uvec3 rgb => new uvec3(x, y, z);
        
        /// <summary>
        /// Returns uvec4.rgbr swizzling.
        /// </summary>
        public uvec4 rgbr => new uvec4(x, y, z, x);
        
        /// <summary>
        /// Returns uvec4.rgbg swizzling.
        /// </summary>
        public uvec4 rgbg => new uvec4(x, y, z, y);
        
        /// <summary>
        /// Returns uvec4.rgbb swizzling.
        /// </summary>
        public uvec4 rgbb => new uvec4(x, y, z, z);
        
        /// <summary>
        /// Returns uvec4.rgba swizzling.
        /// </summary>
        public uvec4 rgba => new uvec4(x, y, z, w);
        
        /// <summary>
        /// Returns uvec4.rga swizzling.
        /// </summary>
        public uvec3 rga => new uvec3(x, y, w);
        
        /// <summary>
        /// Returns uvec4.rgar swizzling.
        /// </summary>
        public uvec4 rgar => new uvec4(x, y, w, x);
        
        /// <summary>
        /// Returns uvec4.rgag swizzling.
        /// </summary>
        public uvec4 rgag => new uvec4(x, y, w, y);
        
        /// <summary>
        /// Returns uvec4.rgab swizzling.
        /// </summary>
        public uvec4 rgab => new uvec4(x, y, w, z);
        
        /// <summary>
        /// Returns uvec4.rgaa swizzling.
        /// </summary>
        public uvec4 rgaa => new uvec4(x, y, w, w);
        
        /// <summary>
        /// Returns uvec4.rb swizzling.
        /// </summary>
        public uvec2 rb => new uvec2(x, z);
        
        /// <summary>
        /// Returns uvec4.rbr swizzling.
        /// </summary>
        public uvec3 rbr => new uvec3(x, z, x);
        
        /// <summary>
        /// Returns uvec4.rbrr swizzling.
        /// </summary>
        public uvec4 rbrr => new uvec4(x, z, x, x);
        
        /// <summary>
        /// Returns uvec4.rbrg swizzling.
        /// </summary>
        public uvec4 rbrg => new uvec4(x, z, x, y);
        
        /// <summary>
        /// Returns uvec4.rbrb swizzling.
        /// </summary>
        public uvec4 rbrb => new uvec4(x, z, x, z);
        
        /// <summary>
        /// Returns uvec4.rbra swizzling.
        /// </summary>
        public uvec4 rbra => new uvec4(x, z, x, w);
        
        /// <summary>
        /// Returns uvec4.rbg swizzling.
        /// </summary>
        public uvec3 rbg => new uvec3(x, z, y);
        
        /// <summary>
        /// Returns uvec4.rbgr swizzling.
        /// </summary>
        public uvec4 rbgr => new uvec4(x, z, y, x);
        
        /// <summary>
        /// Returns uvec4.rbgg swizzling.
        /// </summary>
        public uvec4 rbgg => new uvec4(x, z, y, y);
        
        /// <summary>
        /// Returns uvec4.rbgb swizzling.
        /// </summary>
        public uvec4 rbgb => new uvec4(x, z, y, z);
        
        /// <summary>
        /// Returns uvec4.rbga swizzling.
        /// </summary>
        public uvec4 rbga => new uvec4(x, z, y, w);
        
        /// <summary>
        /// Returns uvec4.rbb swizzling.
        /// </summary>
        public uvec3 rbb => new uvec3(x, z, z);
        
        /// <summary>
        /// Returns uvec4.rbbr swizzling.
        /// </summary>
        public uvec4 rbbr => new uvec4(x, z, z, x);
        
        /// <summary>
        /// Returns uvec4.rbbg swizzling.
        /// </summary>
        public uvec4 rbbg => new uvec4(x, z, z, y);
        
        /// <summary>
        /// Returns uvec4.rbbb swizzling.
        /// </summary>
        public uvec4 rbbb => new uvec4(x, z, z, z);
        
        /// <summary>
        /// Returns uvec4.rbba swizzling.
        /// </summary>
        public uvec4 rbba => new uvec4(x, z, z, w);
        
        /// <summary>
        /// Returns uvec4.rba swizzling.
        /// </summary>
        public uvec3 rba => new uvec3(x, z, w);
        
        /// <summary>
        /// Returns uvec4.rbar swizzling.
        /// </summary>
        public uvec4 rbar => new uvec4(x, z, w, x);
        
        /// <summary>
        /// Returns uvec4.rbag swizzling.
        /// </summary>
        public uvec4 rbag => new uvec4(x, z, w, y);
        
        /// <summary>
        /// Returns uvec4.rbab swizzling.
        /// </summary>
        public uvec4 rbab => new uvec4(x, z, w, z);
        
        /// <summary>
        /// Returns uvec4.rbaa swizzling.
        /// </summary>
        public uvec4 rbaa => new uvec4(x, z, w, w);
        
        /// <summary>
        /// Returns uvec4.ra swizzling.
        /// </summary>
        public uvec2 ra => new uvec2(x, w);
        
        /// <summary>
        /// Returns uvec4.rar swizzling.
        /// </summary>
        public uvec3 rar => new uvec3(x, w, x);
        
        /// <summary>
        /// Returns uvec4.rarr swizzling.
        /// </summary>
        public uvec4 rarr => new uvec4(x, w, x, x);
        
        /// <summary>
        /// Returns uvec4.rarg swizzling.
        /// </summary>
        public uvec4 rarg => new uvec4(x, w, x, y);
        
        /// <summary>
        /// Returns uvec4.rarb swizzling.
        /// </summary>
        public uvec4 rarb => new uvec4(x, w, x, z);
        
        /// <summary>
        /// Returns uvec4.rara swizzling.
        /// </summary>
        public uvec4 rara => new uvec4(x, w, x, w);
        
        /// <summary>
        /// Returns uvec4.rag swizzling.
        /// </summary>
        public uvec3 rag => new uvec3(x, w, y);
        
        /// <summary>
        /// Returns uvec4.ragr swizzling.
        /// </summary>
        public uvec4 ragr => new uvec4(x, w, y, x);
        
        /// <summary>
        /// Returns uvec4.ragg swizzling.
        /// </summary>
        public uvec4 ragg => new uvec4(x, w, y, y);
        
        /// <summary>
        /// Returns uvec4.ragb swizzling.
        /// </summary>
        public uvec4 ragb => new uvec4(x, w, y, z);
        
        /// <summary>
        /// Returns uvec4.raga swizzling.
        /// </summary>
        public uvec4 raga => new uvec4(x, w, y, w);
        
        /// <summary>
        /// Returns uvec4.rab swizzling.
        /// </summary>
        public uvec3 rab => new uvec3(x, w, z);
        
        /// <summary>
        /// Returns uvec4.rabr swizzling.
        /// </summary>
        public uvec4 rabr => new uvec4(x, w, z, x);
        
        /// <summary>
        /// Returns uvec4.rabg swizzling.
        /// </summary>
        public uvec4 rabg => new uvec4(x, w, z, y);
        
        /// <summary>
        /// Returns uvec4.rabb swizzling.
        /// </summary>
        public uvec4 rabb => new uvec4(x, w, z, z);
        
        /// <summary>
        /// Returns uvec4.raba swizzling.
        /// </summary>
        public uvec4 raba => new uvec4(x, w, z, w);
        
        /// <summary>
        /// Returns uvec4.raa swizzling.
        /// </summary>
        public uvec3 raa => new uvec3(x, w, w);
        
        /// <summary>
        /// Returns uvec4.raar swizzling.
        /// </summary>
        public uvec4 raar => new uvec4(x, w, w, x);
        
        /// <summary>
        /// Returns uvec4.raag swizzling.
        /// </summary>
        public uvec4 raag => new uvec4(x, w, w, y);
        
        /// <summary>
        /// Returns uvec4.raab swizzling.
        /// </summary>
        public uvec4 raab => new uvec4(x, w, w, z);
        
        /// <summary>
        /// Returns uvec4.raaa swizzling.
        /// </summary>
        public uvec4 raaa => new uvec4(x, w, w, w);
        
        /// <summary>
        /// Returns uvec4.gr swizzling.
        /// </summary>
        public uvec2 gr => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec4.grr swizzling.
        /// </summary>
        public uvec3 grr => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec4.grrr swizzling.
        /// </summary>
        public uvec4 grrr => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec4.grrg swizzling.
        /// </summary>
        public uvec4 grrg => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec4.grrb swizzling.
        /// </summary>
        public uvec4 grrb => new uvec4(y, x, x, z);
        
        /// <summary>
        /// Returns uvec4.grra swizzling.
        /// </summary>
        public uvec4 grra => new uvec4(y, x, x, w);
        
        /// <summary>
        /// Returns uvec4.grg swizzling.
        /// </summary>
        public uvec3 grg => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec4.grgr swizzling.
        /// </summary>
        public uvec4 grgr => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec4.grgg swizzling.
        /// </summary>
        public uvec4 grgg => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec4.grgb swizzling.
        /// </summary>
        public uvec4 grgb => new uvec4(y, x, y, z);
        
        /// <summary>
        /// Returns uvec4.grga swizzling.
        /// </summary>
        public uvec4 grga => new uvec4(y, x, y, w);
        
        /// <summary>
        /// Returns uvec4.grb swizzling.
        /// </summary>
        public uvec3 grb => new uvec3(y, x, z);
        
        /// <summary>
        /// Returns uvec4.grbr swizzling.
        /// </summary>
        public uvec4 grbr => new uvec4(y, x, z, x);
        
        /// <summary>
        /// Returns uvec4.grbg swizzling.
        /// </summary>
        public uvec4 grbg => new uvec4(y, x, z, y);
        
        /// <summary>
        /// Returns uvec4.grbb swizzling.
        /// </summary>
        public uvec4 grbb => new uvec4(y, x, z, z);
        
        /// <summary>
        /// Returns uvec4.grba swizzling.
        /// </summary>
        public uvec4 grba => new uvec4(y, x, z, w);
        
        /// <summary>
        /// Returns uvec4.gra swizzling.
        /// </summary>
        public uvec3 gra => new uvec3(y, x, w);
        
        /// <summary>
        /// Returns uvec4.grar swizzling.
        /// </summary>
        public uvec4 grar => new uvec4(y, x, w, x);
        
        /// <summary>
        /// Returns uvec4.grag swizzling.
        /// </summary>
        public uvec4 grag => new uvec4(y, x, w, y);
        
        /// <summary>
        /// Returns uvec4.grab swizzling.
        /// </summary>
        public uvec4 grab => new uvec4(y, x, w, z);
        
        /// <summary>
        /// Returns uvec4.graa swizzling.
        /// </summary>
        public uvec4 graa => new uvec4(y, x, w, w);
        
        /// <summary>
        /// Returns uvec4.gg swizzling.
        /// </summary>
        public uvec2 gg => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec4.ggr swizzling.
        /// </summary>
        public uvec3 ggr => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec4.ggrr swizzling.
        /// </summary>
        public uvec4 ggrr => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec4.ggrg swizzling.
        /// </summary>
        public uvec4 ggrg => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec4.ggrb swizzling.
        /// </summary>
        public uvec4 ggrb => new uvec4(y, y, x, z);
        
        /// <summary>
        /// Returns uvec4.ggra swizzling.
        /// </summary>
        public uvec4 ggra => new uvec4(y, y, x, w);
        
        /// <summary>
        /// Returns uvec4.ggg swizzling.
        /// </summary>
        public uvec3 ggg => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec4.gggr swizzling.
        /// </summary>
        public uvec4 gggr => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec4.gggg swizzling.
        /// </summary>
        public uvec4 gggg => new uvec4(y, y, y, y);
        
        /// <summary>
        /// Returns uvec4.gggb swizzling.
        /// </summary>
        public uvec4 gggb => new uvec4(y, y, y, z);
        
        /// <summary>
        /// Returns uvec4.ggga swizzling.
        /// </summary>
        public uvec4 ggga => new uvec4(y, y, y, w);
        
        /// <summary>
        /// Returns uvec4.ggb swizzling.
        /// </summary>
        public uvec3 ggb => new uvec3(y, y, z);
        
        /// <summary>
        /// Returns uvec4.ggbr swizzling.
        /// </summary>
        public uvec4 ggbr => new uvec4(y, y, z, x);
        
        /// <summary>
        /// Returns uvec4.ggbg swizzling.
        /// </summary>
        public uvec4 ggbg => new uvec4(y, y, z, y);
        
        /// <summary>
        /// Returns uvec4.ggbb swizzling.
        /// </summary>
        public uvec4 ggbb => new uvec4(y, y, z, z);
        
        /// <summary>
        /// Returns uvec4.ggba swizzling.
        /// </summary>
        public uvec4 ggba => new uvec4(y, y, z, w);
        
        /// <summary>
        /// Returns uvec4.gga swizzling.
        /// </summary>
        public uvec3 gga => new uvec3(y, y, w);
        
        /// <summary>
        /// Returns uvec4.ggar swizzling.
        /// </summary>
        public uvec4 ggar => new uvec4(y, y, w, x);
        
        /// <summary>
        /// Returns uvec4.ggag swizzling.
        /// </summary>
        public uvec4 ggag => new uvec4(y, y, w, y);
        
        /// <summary>
        /// Returns uvec4.ggab swizzling.
        /// </summary>
        public uvec4 ggab => new uvec4(y, y, w, z);
        
        /// <summary>
        /// Returns uvec4.ggaa swizzling.
        /// </summary>
        public uvec4 ggaa => new uvec4(y, y, w, w);
        
        /// <summary>
        /// Returns uvec4.gb swizzling.
        /// </summary>
        public uvec2 gb => new uvec2(y, z);
        
        /// <summary>
        /// Returns uvec4.gbr swizzling.
        /// </summary>
        public uvec3 gbr => new uvec3(y, z, x);
        
        /// <summary>
        /// Returns uvec4.gbrr swizzling.
        /// </summary>
        public uvec4 gbrr => new uvec4(y, z, x, x);
        
        /// <summary>
        /// Returns uvec4.gbrg swizzling.
        /// </summary>
        public uvec4 gbrg => new uvec4(y, z, x, y);
        
        /// <summary>
        /// Returns uvec4.gbrb swizzling.
        /// </summary>
        public uvec4 gbrb => new uvec4(y, z, x, z);
        
        /// <summary>
        /// Returns uvec4.gbra swizzling.
        /// </summary>
        public uvec4 gbra => new uvec4(y, z, x, w);
        
        /// <summary>
        /// Returns uvec4.gbg swizzling.
        /// </summary>
        public uvec3 gbg => new uvec3(y, z, y);
        
        /// <summary>
        /// Returns uvec4.gbgr swizzling.
        /// </summary>
        public uvec4 gbgr => new uvec4(y, z, y, x);
        
        /// <summary>
        /// Returns uvec4.gbgg swizzling.
        /// </summary>
        public uvec4 gbgg => new uvec4(y, z, y, y);
        
        /// <summary>
        /// Returns uvec4.gbgb swizzling.
        /// </summary>
        public uvec4 gbgb => new uvec4(y, z, y, z);
        
        /// <summary>
        /// Returns uvec4.gbga swizzling.
        /// </summary>
        public uvec4 gbga => new uvec4(y, z, y, w);
        
        /// <summary>
        /// Returns uvec4.gbb swizzling.
        /// </summary>
        public uvec3 gbb => new uvec3(y, z, z);
        
        /// <summary>
        /// Returns uvec4.gbbr swizzling.
        /// </summary>
        public uvec4 gbbr => new uvec4(y, z, z, x);
        
        /// <summary>
        /// Returns uvec4.gbbg swizzling.
        /// </summary>
        public uvec4 gbbg => new uvec4(y, z, z, y);
        
        /// <summary>
        /// Returns uvec4.gbbb swizzling.
        /// </summary>
        public uvec4 gbbb => new uvec4(y, z, z, z);
        
        /// <summary>
        /// Returns uvec4.gbba swizzling.
        /// </summary>
        public uvec4 gbba => new uvec4(y, z, z, w);
        
        /// <summary>
        /// Returns uvec4.gba swizzling.
        /// </summary>
        public uvec3 gba => new uvec3(y, z, w);
        
        /// <summary>
        /// Returns uvec4.gbar swizzling.
        /// </summary>
        public uvec4 gbar => new uvec4(y, z, w, x);
        
        /// <summary>
        /// Returns uvec4.gbag swizzling.
        /// </summary>
        public uvec4 gbag => new uvec4(y, z, w, y);
        
        /// <summary>
        /// Returns uvec4.gbab swizzling.
        /// </summary>
        public uvec4 gbab => new uvec4(y, z, w, z);
        
        /// <summary>
        /// Returns uvec4.gbaa swizzling.
        /// </summary>
        public uvec4 gbaa => new uvec4(y, z, w, w);
        
        /// <summary>
        /// Returns uvec4.ga swizzling.
        /// </summary>
        public uvec2 ga => new uvec2(y, w);
        
        /// <summary>
        /// Returns uvec4.gar swizzling.
        /// </summary>
        public uvec3 gar => new uvec3(y, w, x);
        
        /// <summary>
        /// Returns uvec4.garr swizzling.
        /// </summary>
        public uvec4 garr => new uvec4(y, w, x, x);
        
        /// <summary>
        /// Returns uvec4.garg swizzling.
        /// </summary>
        public uvec4 garg => new uvec4(y, w, x, y);
        
        /// <summary>
        /// Returns uvec4.garb swizzling.
        /// </summary>
        public uvec4 garb => new uvec4(y, w, x, z);
        
        /// <summary>
        /// Returns uvec4.gara swizzling.
        /// </summary>
        public uvec4 gara => new uvec4(y, w, x, w);
        
        /// <summary>
        /// Returns uvec4.gag swizzling.
        /// </summary>
        public uvec3 gag => new uvec3(y, w, y);
        
        /// <summary>
        /// Returns uvec4.gagr swizzling.
        /// </summary>
        public uvec4 gagr => new uvec4(y, w, y, x);
        
        /// <summary>
        /// Returns uvec4.gagg swizzling.
        /// </summary>
        public uvec4 gagg => new uvec4(y, w, y, y);
        
        /// <summary>
        /// Returns uvec4.gagb swizzling.
        /// </summary>
        public uvec4 gagb => new uvec4(y, w, y, z);
        
        /// <summary>
        /// Returns uvec4.gaga swizzling.
        /// </summary>
        public uvec4 gaga => new uvec4(y, w, y, w);
        
        /// <summary>
        /// Returns uvec4.gab swizzling.
        /// </summary>
        public uvec3 gab => new uvec3(y, w, z);
        
        /// <summary>
        /// Returns uvec4.gabr swizzling.
        /// </summary>
        public uvec4 gabr => new uvec4(y, w, z, x);
        
        /// <summary>
        /// Returns uvec4.gabg swizzling.
        /// </summary>
        public uvec4 gabg => new uvec4(y, w, z, y);
        
        /// <summary>
        /// Returns uvec4.gabb swizzling.
        /// </summary>
        public uvec4 gabb => new uvec4(y, w, z, z);
        
        /// <summary>
        /// Returns uvec4.gaba swizzling.
        /// </summary>
        public uvec4 gaba => new uvec4(y, w, z, w);
        
        /// <summary>
        /// Returns uvec4.gaa swizzling.
        /// </summary>
        public uvec3 gaa => new uvec3(y, w, w);
        
        /// <summary>
        /// Returns uvec4.gaar swizzling.
        /// </summary>
        public uvec4 gaar => new uvec4(y, w, w, x);
        
        /// <summary>
        /// Returns uvec4.gaag swizzling.
        /// </summary>
        public uvec4 gaag => new uvec4(y, w, w, y);
        
        /// <summary>
        /// Returns uvec4.gaab swizzling.
        /// </summary>
        public uvec4 gaab => new uvec4(y, w, w, z);
        
        /// <summary>
        /// Returns uvec4.gaaa swizzling.
        /// </summary>
        public uvec4 gaaa => new uvec4(y, w, w, w);
        
        /// <summary>
        /// Returns uvec4.br swizzling.
        /// </summary>
        public uvec2 br => new uvec2(z, x);
        
        /// <summary>
        /// Returns uvec4.brr swizzling.
        /// </summary>
        public uvec3 brr => new uvec3(z, x, x);
        
        /// <summary>
        /// Returns uvec4.brrr swizzling.
        /// </summary>
        public uvec4 brrr => new uvec4(z, x, x, x);
        
        /// <summary>
        /// Returns uvec4.brrg swizzling.
        /// </summary>
        public uvec4 brrg => new uvec4(z, x, x, y);
        
        /// <summary>
        /// Returns uvec4.brrb swizzling.
        /// </summary>
        public uvec4 brrb => new uvec4(z, x, x, z);
        
        /// <summary>
        /// Returns uvec4.brra swizzling.
        /// </summary>
        public uvec4 brra => new uvec4(z, x, x, w);
        
        /// <summary>
        /// Returns uvec4.brg swizzling.
        /// </summary>
        public uvec3 brg => new uvec3(z, x, y);
        
        /// <summary>
        /// Returns uvec4.brgr swizzling.
        /// </summary>
        public uvec4 brgr => new uvec4(z, x, y, x);
        
        /// <summary>
        /// Returns uvec4.brgg swizzling.
        /// </summary>
        public uvec4 brgg => new uvec4(z, x, y, y);
        
        /// <summary>
        /// Returns uvec4.brgb swizzling.
        /// </summary>
        public uvec4 brgb => new uvec4(z, x, y, z);
        
        /// <summary>
        /// Returns uvec4.brga swizzling.
        /// </summary>
        public uvec4 brga => new uvec4(z, x, y, w);
        
        /// <summary>
        /// Returns uvec4.brb swizzling.
        /// </summary>
        public uvec3 brb => new uvec3(z, x, z);
        
        /// <summary>
        /// Returns uvec4.brbr swizzling.
        /// </summary>
        public uvec4 brbr => new uvec4(z, x, z, x);
        
        /// <summary>
        /// Returns uvec4.brbg swizzling.
        /// </summary>
        public uvec4 brbg => new uvec4(z, x, z, y);
        
        /// <summary>
        /// Returns uvec4.brbb swizzling.
        /// </summary>
        public uvec4 brbb => new uvec4(z, x, z, z);
        
        /// <summary>
        /// Returns uvec4.brba swizzling.
        /// </summary>
        public uvec4 brba => new uvec4(z, x, z, w);
        
        /// <summary>
        /// Returns uvec4.bra swizzling.
        /// </summary>
        public uvec3 bra => new uvec3(z, x, w);
        
        /// <summary>
        /// Returns uvec4.brar swizzling.
        /// </summary>
        public uvec4 brar => new uvec4(z, x, w, x);
        
        /// <summary>
        /// Returns uvec4.brag swizzling.
        /// </summary>
        public uvec4 brag => new uvec4(z, x, w, y);
        
        /// <summary>
        /// Returns uvec4.brab swizzling.
        /// </summary>
        public uvec4 brab => new uvec4(z, x, w, z);
        
        /// <summary>
        /// Returns uvec4.braa swizzling.
        /// </summary>
        public uvec4 braa => new uvec4(z, x, w, w);
        
        /// <summary>
        /// Returns uvec4.bg swizzling.
        /// </summary>
        public uvec2 bg => new uvec2(z, y);
        
        /// <summary>
        /// Returns uvec4.bgr swizzling.
        /// </summary>
        public uvec3 bgr => new uvec3(z, y, x);
        
        /// <summary>
        /// Returns uvec4.bgrr swizzling.
        /// </summary>
        public uvec4 bgrr => new uvec4(z, y, x, x);
        
        /// <summary>
        /// Returns uvec4.bgrg swizzling.
        /// </summary>
        public uvec4 bgrg => new uvec4(z, y, x, y);
        
        /// <summary>
        /// Returns uvec4.bgrb swizzling.
        /// </summary>
        public uvec4 bgrb => new uvec4(z, y, x, z);
        
        /// <summary>
        /// Returns uvec4.bgra swizzling.
        /// </summary>
        public uvec4 bgra => new uvec4(z, y, x, w);
        
        /// <summary>
        /// Returns uvec4.bgg swizzling.
        /// </summary>
        public uvec3 bgg => new uvec3(z, y, y);
        
        /// <summary>
        /// Returns uvec4.bggr swizzling.
        /// </summary>
        public uvec4 bggr => new uvec4(z, y, y, x);
        
        /// <summary>
        /// Returns uvec4.bggg swizzling.
        /// </summary>
        public uvec4 bggg => new uvec4(z, y, y, y);
        
        /// <summary>
        /// Returns uvec4.bggb swizzling.
        /// </summary>
        public uvec4 bggb => new uvec4(z, y, y, z);
        
        /// <summary>
        /// Returns uvec4.bgga swizzling.
        /// </summary>
        public uvec4 bgga => new uvec4(z, y, y, w);
        
        /// <summary>
        /// Returns uvec4.bgb swizzling.
        /// </summary>
        public uvec3 bgb => new uvec3(z, y, z);
        
        /// <summary>
        /// Returns uvec4.bgbr swizzling.
        /// </summary>
        public uvec4 bgbr => new uvec4(z, y, z, x);
        
        /// <summary>
        /// Returns uvec4.bgbg swizzling.
        /// </summary>
        public uvec4 bgbg => new uvec4(z, y, z, y);
        
        /// <summary>
        /// Returns uvec4.bgbb swizzling.
        /// </summary>
        public uvec4 bgbb => new uvec4(z, y, z, z);
        
        /// <summary>
        /// Returns uvec4.bgba swizzling.
        /// </summary>
        public uvec4 bgba => new uvec4(z, y, z, w);
        
        /// <summary>
        /// Returns uvec4.bga swizzling.
        /// </summary>
        public uvec3 bga => new uvec3(z, y, w);
        
        /// <summary>
        /// Returns uvec4.bgar swizzling.
        /// </summary>
        public uvec4 bgar => new uvec4(z, y, w, x);
        
        /// <summary>
        /// Returns uvec4.bgag swizzling.
        /// </summary>
        public uvec4 bgag => new uvec4(z, y, w, y);
        
        /// <summary>
        /// Returns uvec4.bgab swizzling.
        /// </summary>
        public uvec4 bgab => new uvec4(z, y, w, z);
        
        /// <summary>
        /// Returns uvec4.bgaa swizzling.
        /// </summary>
        public uvec4 bgaa => new uvec4(z, y, w, w);
        
        /// <summary>
        /// Returns uvec4.bb swizzling.
        /// </summary>
        public uvec2 bb => new uvec2(z, z);
        
        /// <summary>
        /// Returns uvec4.bbr swizzling.
        /// </summary>
        public uvec3 bbr => new uvec3(z, z, x);
        
        /// <summary>
        /// Returns uvec4.bbrr swizzling.
        /// </summary>
        public uvec4 bbrr => new uvec4(z, z, x, x);
        
        /// <summary>
        /// Returns uvec4.bbrg swizzling.
        /// </summary>
        public uvec4 bbrg => new uvec4(z, z, x, y);
        
        /// <summary>
        /// Returns uvec4.bbrb swizzling.
        /// </summary>
        public uvec4 bbrb => new uvec4(z, z, x, z);
        
        /// <summary>
        /// Returns uvec4.bbra swizzling.
        /// </summary>
        public uvec4 bbra => new uvec4(z, z, x, w);
        
        /// <summary>
        /// Returns uvec4.bbg swizzling.
        /// </summary>
        public uvec3 bbg => new uvec3(z, z, y);
        
        /// <summary>
        /// Returns uvec4.bbgr swizzling.
        /// </summary>
        public uvec4 bbgr => new uvec4(z, z, y, x);
        
        /// <summary>
        /// Returns uvec4.bbgg swizzling.
        /// </summary>
        public uvec4 bbgg => new uvec4(z, z, y, y);
        
        /// <summary>
        /// Returns uvec4.bbgb swizzling.
        /// </summary>
        public uvec4 bbgb => new uvec4(z, z, y, z);
        
        /// <summary>
        /// Returns uvec4.bbga swizzling.
        /// </summary>
        public uvec4 bbga => new uvec4(z, z, y, w);
        
        /// <summary>
        /// Returns uvec4.bbb swizzling.
        /// </summary>
        public uvec3 bbb => new uvec3(z, z, z);
        
        /// <summary>
        /// Returns uvec4.bbbr swizzling.
        /// </summary>
        public uvec4 bbbr => new uvec4(z, z, z, x);
        
        /// <summary>
        /// Returns uvec4.bbbg swizzling.
        /// </summary>
        public uvec4 bbbg => new uvec4(z, z, z, y);
        
        /// <summary>
        /// Returns uvec4.bbbb swizzling.
        /// </summary>
        public uvec4 bbbb => new uvec4(z, z, z, z);
        
        /// <summary>
        /// Returns uvec4.bbba swizzling.
        /// </summary>
        public uvec4 bbba => new uvec4(z, z, z, w);
        
        /// <summary>
        /// Returns uvec4.bba swizzling.
        /// </summary>
        public uvec3 bba => new uvec3(z, z, w);
        
        /// <summary>
        /// Returns uvec4.bbar swizzling.
        /// </summary>
        public uvec4 bbar => new uvec4(z, z, w, x);
        
        /// <summary>
        /// Returns uvec4.bbag swizzling.
        /// </summary>
        public uvec4 bbag => new uvec4(z, z, w, y);
        
        /// <summary>
        /// Returns uvec4.bbab swizzling.
        /// </summary>
        public uvec4 bbab => new uvec4(z, z, w, z);
        
        /// <summary>
        /// Returns uvec4.bbaa swizzling.
        /// </summary>
        public uvec4 bbaa => new uvec4(z, z, w, w);
        
        /// <summary>
        /// Returns uvec4.ba swizzling.
        /// </summary>
        public uvec2 ba => new uvec2(z, w);
        
        /// <summary>
        /// Returns uvec4.bar swizzling.
        /// </summary>
        public uvec3 bar => new uvec3(z, w, x);
        
        /// <summary>
        /// Returns uvec4.barr swizzling.
        /// </summary>
        public uvec4 barr => new uvec4(z, w, x, x);
        
        /// <summary>
        /// Returns uvec4.barg swizzling.
        /// </summary>
        public uvec4 barg => new uvec4(z, w, x, y);
        
        /// <summary>
        /// Returns uvec4.barb swizzling.
        /// </summary>
        public uvec4 barb => new uvec4(z, w, x, z);
        
        /// <summary>
        /// Returns uvec4.bara swizzling.
        /// </summary>
        public uvec4 bara => new uvec4(z, w, x, w);
        
        /// <summary>
        /// Returns uvec4.bag swizzling.
        /// </summary>
        public uvec3 bag => new uvec3(z, w, y);
        
        /// <summary>
        /// Returns uvec4.bagr swizzling.
        /// </summary>
        public uvec4 bagr => new uvec4(z, w, y, x);
        
        /// <summary>
        /// Returns uvec4.bagg swizzling.
        /// </summary>
        public uvec4 bagg => new uvec4(z, w, y, y);
        
        /// <summary>
        /// Returns uvec4.bagb swizzling.
        /// </summary>
        public uvec4 bagb => new uvec4(z, w, y, z);
        
        /// <summary>
        /// Returns uvec4.baga swizzling.
        /// </summary>
        public uvec4 baga => new uvec4(z, w, y, w);
        
        /// <summary>
        /// Returns uvec4.bab swizzling.
        /// </summary>
        public uvec3 bab => new uvec3(z, w, z);
        
        /// <summary>
        /// Returns uvec4.babr swizzling.
        /// </summary>
        public uvec4 babr => new uvec4(z, w, z, x);
        
        /// <summary>
        /// Returns uvec4.babg swizzling.
        /// </summary>
        public uvec4 babg => new uvec4(z, w, z, y);
        
        /// <summary>
        /// Returns uvec4.babb swizzling.
        /// </summary>
        public uvec4 babb => new uvec4(z, w, z, z);
        
        /// <summary>
        /// Returns uvec4.baba swizzling.
        /// </summary>
        public uvec4 baba => new uvec4(z, w, z, w);
        
        /// <summary>
        /// Returns uvec4.baa swizzling.
        /// </summary>
        public uvec3 baa => new uvec3(z, w, w);
        
        /// <summary>
        /// Returns uvec4.baar swizzling.
        /// </summary>
        public uvec4 baar => new uvec4(z, w, w, x);
        
        /// <summary>
        /// Returns uvec4.baag swizzling.
        /// </summary>
        public uvec4 baag => new uvec4(z, w, w, y);
        
        /// <summary>
        /// Returns uvec4.baab swizzling.
        /// </summary>
        public uvec4 baab => new uvec4(z, w, w, z);
        
        /// <summary>
        /// Returns uvec4.baaa swizzling.
        /// </summary>
        public uvec4 baaa => new uvec4(z, w, w, w);
        
        /// <summary>
        /// Returns uvec4.ar swizzling.
        /// </summary>
        public uvec2 ar => new uvec2(w, x);
        
        /// <summary>
        /// Returns uvec4.arr swizzling.
        /// </summary>
        public uvec3 arr => new uvec3(w, x, x);
        
        /// <summary>
        /// Returns uvec4.arrr swizzling.
        /// </summary>
        public uvec4 arrr => new uvec4(w, x, x, x);
        
        /// <summary>
        /// Returns uvec4.arrg swizzling.
        /// </summary>
        public uvec4 arrg => new uvec4(w, x, x, y);
        
        /// <summary>
        /// Returns uvec4.arrb swizzling.
        /// </summary>
        public uvec4 arrb => new uvec4(w, x, x, z);
        
        /// <summary>
        /// Returns uvec4.arra swizzling.
        /// </summary>
        public uvec4 arra => new uvec4(w, x, x, w);
        
        /// <summary>
        /// Returns uvec4.arg swizzling.
        /// </summary>
        public uvec3 arg => new uvec3(w, x, y);
        
        /// <summary>
        /// Returns uvec4.argr swizzling.
        /// </summary>
        public uvec4 argr => new uvec4(w, x, y, x);
        
        /// <summary>
        /// Returns uvec4.argg swizzling.
        /// </summary>
        public uvec4 argg => new uvec4(w, x, y, y);
        
        /// <summary>
        /// Returns uvec4.argb swizzling.
        /// </summary>
        public uvec4 argb => new uvec4(w, x, y, z);
        
        /// <summary>
        /// Returns uvec4.arga swizzling.
        /// </summary>
        public uvec4 arga => new uvec4(w, x, y, w);
        
        /// <summary>
        /// Returns uvec4.arb swizzling.
        /// </summary>
        public uvec3 arb => new uvec3(w, x, z);
        
        /// <summary>
        /// Returns uvec4.arbr swizzling.
        /// </summary>
        public uvec4 arbr => new uvec4(w, x, z, x);
        
        /// <summary>
        /// Returns uvec4.arbg swizzling.
        /// </summary>
        public uvec4 arbg => new uvec4(w, x, z, y);
        
        /// <summary>
        /// Returns uvec4.arbb swizzling.
        /// </summary>
        public uvec4 arbb => new uvec4(w, x, z, z);
        
        /// <summary>
        /// Returns uvec4.arba swizzling.
        /// </summary>
        public uvec4 arba => new uvec4(w, x, z, w);
        
        /// <summary>
        /// Returns uvec4.ara swizzling.
        /// </summary>
        public uvec3 ara => new uvec3(w, x, w);
        
        /// <summary>
        /// Returns uvec4.arar swizzling.
        /// </summary>
        public uvec4 arar => new uvec4(w, x, w, x);
        
        /// <summary>
        /// Returns uvec4.arag swizzling.
        /// </summary>
        public uvec4 arag => new uvec4(w, x, w, y);
        
        /// <summary>
        /// Returns uvec4.arab swizzling.
        /// </summary>
        public uvec4 arab => new uvec4(w, x, w, z);
        
        /// <summary>
        /// Returns uvec4.araa swizzling.
        /// </summary>
        public uvec4 araa => new uvec4(w, x, w, w);
        
        /// <summary>
        /// Returns uvec4.ag swizzling.
        /// </summary>
        public uvec2 ag => new uvec2(w, y);
        
        /// <summary>
        /// Returns uvec4.agr swizzling.
        /// </summary>
        public uvec3 agr => new uvec3(w, y, x);
        
        /// <summary>
        /// Returns uvec4.agrr swizzling.
        /// </summary>
        public uvec4 agrr => new uvec4(w, y, x, x);
        
        /// <summary>
        /// Returns uvec4.agrg swizzling.
        /// </summary>
        public uvec4 agrg => new uvec4(w, y, x, y);
        
        /// <summary>
        /// Returns uvec4.agrb swizzling.
        /// </summary>
        public uvec4 agrb => new uvec4(w, y, x, z);
        
        /// <summary>
        /// Returns uvec4.agra swizzling.
        /// </summary>
        public uvec4 agra => new uvec4(w, y, x, w);
        
        /// <summary>
        /// Returns uvec4.agg swizzling.
        /// </summary>
        public uvec3 agg => new uvec3(w, y, y);
        
        /// <summary>
        /// Returns uvec4.aggr swizzling.
        /// </summary>
        public uvec4 aggr => new uvec4(w, y, y, x);
        
        /// <summary>
        /// Returns uvec4.aggg swizzling.
        /// </summary>
        public uvec4 aggg => new uvec4(w, y, y, y);
        
        /// <summary>
        /// Returns uvec4.aggb swizzling.
        /// </summary>
        public uvec4 aggb => new uvec4(w, y, y, z);
        
        /// <summary>
        /// Returns uvec4.agga swizzling.
        /// </summary>
        public uvec4 agga => new uvec4(w, y, y, w);
        
        /// <summary>
        /// Returns uvec4.agb swizzling.
        /// </summary>
        public uvec3 agb => new uvec3(w, y, z);
        
        /// <summary>
        /// Returns uvec4.agbr swizzling.
        /// </summary>
        public uvec4 agbr => new uvec4(w, y, z, x);
        
        /// <summary>
        /// Returns uvec4.agbg swizzling.
        /// </summary>
        public uvec4 agbg => new uvec4(w, y, z, y);
        
        /// <summary>
        /// Returns uvec4.agbb swizzling.
        /// </summary>
        public uvec4 agbb => new uvec4(w, y, z, z);
        
        /// <summary>
        /// Returns uvec4.agba swizzling.
        /// </summary>
        public uvec4 agba => new uvec4(w, y, z, w);
        
        /// <summary>
        /// Returns uvec4.aga swizzling.
        /// </summary>
        public uvec3 aga => new uvec3(w, y, w);
        
        /// <summary>
        /// Returns uvec4.agar swizzling.
        /// </summary>
        public uvec4 agar => new uvec4(w, y, w, x);
        
        /// <summary>
        /// Returns uvec4.agag swizzling.
        /// </summary>
        public uvec4 agag => new uvec4(w, y, w, y);
        
        /// <summary>
        /// Returns uvec4.agab swizzling.
        /// </summary>
        public uvec4 agab => new uvec4(w, y, w, z);
        
        /// <summary>
        /// Returns uvec4.agaa swizzling.
        /// </summary>
        public uvec4 agaa => new uvec4(w, y, w, w);
        
        /// <summary>
        /// Returns uvec4.ab swizzling.
        /// </summary>
        public uvec2 ab => new uvec2(w, z);
        
        /// <summary>
        /// Returns uvec4.abr swizzling.
        /// </summary>
        public uvec3 abr => new uvec3(w, z, x);
        
        /// <summary>
        /// Returns uvec4.abrr swizzling.
        /// </summary>
        public uvec4 abrr => new uvec4(w, z, x, x);
        
        /// <summary>
        /// Returns uvec4.abrg swizzling.
        /// </summary>
        public uvec4 abrg => new uvec4(w, z, x, y);
        
        /// <summary>
        /// Returns uvec4.abrb swizzling.
        /// </summary>
        public uvec4 abrb => new uvec4(w, z, x, z);
        
        /// <summary>
        /// Returns uvec4.abra swizzling.
        /// </summary>
        public uvec4 abra => new uvec4(w, z, x, w);
        
        /// <summary>
        /// Returns uvec4.abg swizzling.
        /// </summary>
        public uvec3 abg => new uvec3(w, z, y);
        
        /// <summary>
        /// Returns uvec4.abgr swizzling.
        /// </summary>
        public uvec4 abgr => new uvec4(w, z, y, x);
        
        /// <summary>
        /// Returns uvec4.abgg swizzling.
        /// </summary>
        public uvec4 abgg => new uvec4(w, z, y, y);
        
        /// <summary>
        /// Returns uvec4.abgb swizzling.
        /// </summary>
        public uvec4 abgb => new uvec4(w, z, y, z);
        
        /// <summary>
        /// Returns uvec4.abga swizzling.
        /// </summary>
        public uvec4 abga => new uvec4(w, z, y, w);
        
        /// <summary>
        /// Returns uvec4.abb swizzling.
        /// </summary>
        public uvec3 abb => new uvec3(w, z, z);
        
        /// <summary>
        /// Returns uvec4.abbr swizzling.
        /// </summary>
        public uvec4 abbr => new uvec4(w, z, z, x);
        
        /// <summary>
        /// Returns uvec4.abbg swizzling.
        /// </summary>
        public uvec4 abbg => new uvec4(w, z, z, y);
        
        /// <summary>
        /// Returns uvec4.abbb swizzling.
        /// </summary>
        public uvec4 abbb => new uvec4(w, z, z, z);
        
        /// <summary>
        /// Returns uvec4.abba swizzling.
        /// </summary>
        public uvec4 abba => new uvec4(w, z, z, w);
        
        /// <summary>
        /// Returns uvec4.aba swizzling.
        /// </summary>
        public uvec3 aba => new uvec3(w, z, w);
        
        /// <summary>
        /// Returns uvec4.abar swizzling.
        /// </summary>
        public uvec4 abar => new uvec4(w, z, w, x);
        
        /// <summary>
        /// Returns uvec4.abag swizzling.
        /// </summary>
        public uvec4 abag => new uvec4(w, z, w, y);
        
        /// <summary>
        /// Returns uvec4.abab swizzling.
        /// </summary>
        public uvec4 abab => new uvec4(w, z, w, z);
        
        /// <summary>
        /// Returns uvec4.abaa swizzling.
        /// </summary>
        public uvec4 abaa => new uvec4(w, z, w, w);
        
        /// <summary>
        /// Returns uvec4.aa swizzling.
        /// </summary>
        public uvec2 aa => new uvec2(w, w);
        
        /// <summary>
        /// Returns uvec4.aar swizzling.
        /// </summary>
        public uvec3 aar => new uvec3(w, w, x);
        
        /// <summary>
        /// Returns uvec4.aarr swizzling.
        /// </summary>
        public uvec4 aarr => new uvec4(w, w, x, x);
        
        /// <summary>
        /// Returns uvec4.aarg swizzling.
        /// </summary>
        public uvec4 aarg => new uvec4(w, w, x, y);
        
        /// <summary>
        /// Returns uvec4.aarb swizzling.
        /// </summary>
        public uvec4 aarb => new uvec4(w, w, x, z);
        
        /// <summary>
        /// Returns uvec4.aara swizzling.
        /// </summary>
        public uvec4 aara => new uvec4(w, w, x, w);
        
        /// <summary>
        /// Returns uvec4.aag swizzling.
        /// </summary>
        public uvec3 aag => new uvec3(w, w, y);
        
        /// <summary>
        /// Returns uvec4.aagr swizzling.
        /// </summary>
        public uvec4 aagr => new uvec4(w, w, y, x);
        
        /// <summary>
        /// Returns uvec4.aagg swizzling.
        /// </summary>
        public uvec4 aagg => new uvec4(w, w, y, y);
        
        /// <summary>
        /// Returns uvec4.aagb swizzling.
        /// </summary>
        public uvec4 aagb => new uvec4(w, w, y, z);
        
        /// <summary>
        /// Returns uvec4.aaga swizzling.
        /// </summary>
        public uvec4 aaga => new uvec4(w, w, y, w);
        
        /// <summary>
        /// Returns uvec4.aab swizzling.
        /// </summary>
        public uvec3 aab => new uvec3(w, w, z);
        
        /// <summary>
        /// Returns uvec4.aabr swizzling.
        /// </summary>
        public uvec4 aabr => new uvec4(w, w, z, x);
        
        /// <summary>
        /// Returns uvec4.aabg swizzling.
        /// </summary>
        public uvec4 aabg => new uvec4(w, w, z, y);
        
        /// <summary>
        /// Returns uvec4.aabb swizzling.
        /// </summary>
        public uvec4 aabb => new uvec4(w, w, z, z);
        
        /// <summary>
        /// Returns uvec4.aaba swizzling.
        /// </summary>
        public uvec4 aaba => new uvec4(w, w, z, w);
        
        /// <summary>
        /// Returns uvec4.aaa swizzling.
        /// </summary>
        public uvec3 aaa => new uvec3(w, w, w);
        
        /// <summary>
        /// Returns uvec4.aaar swizzling.
        /// </summary>
        public uvec4 aaar => new uvec4(w, w, w, x);
        
        /// <summary>
        /// Returns uvec4.aaag swizzling.
        /// </summary>
        public uvec4 aaag => new uvec4(w, w, w, y);
        
        /// <summary>
        /// Returns uvec4.aaab swizzling.
        /// </summary>
        public uvec4 aaab => new uvec4(w, w, w, z);
        
        /// <summary>
        /// Returns uvec4.aaaa swizzling.
        /// </summary>
        public uvec4 aaaa => new uvec4(w, w, w, w);
    }
}
