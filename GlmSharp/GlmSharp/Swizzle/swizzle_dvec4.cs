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
    /// Temporary vector of type double with 4 components, used for implementing swizzling for dvec4.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_dvec4
    {
        
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
        
        // XYZW Versions
        
        /// <summary>
        /// Returns dvec4.xx swizzling.
        /// </summary>
        public dvec2 xx => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec4.xxx swizzling.
        /// </summary>
        public dvec3 xxx => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec4.xxxx swizzling.
        /// </summary>
        public dvec4 xxxx => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.xxxy swizzling.
        /// </summary>
        public dvec4 xxxy => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.xxxz swizzling.
        /// </summary>
        public dvec4 xxxz => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.xxxw swizzling.
        /// </summary>
        public dvec4 xxxw => new dvec4(x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.xxy swizzling.
        /// </summary>
        public dvec3 xxy => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec4.xxyx swizzling.
        /// </summary>
        public dvec4 xxyx => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.xxyy swizzling.
        /// </summary>
        public dvec4 xxyy => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.xxyz swizzling.
        /// </summary>
        public dvec4 xxyz => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.xxyw swizzling.
        /// </summary>
        public dvec4 xxyw => new dvec4(x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.xxz swizzling.
        /// </summary>
        public dvec3 xxz => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec4.xxzx swizzling.
        /// </summary>
        public dvec4 xxzx => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.xxzy swizzling.
        /// </summary>
        public dvec4 xxzy => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.xxzz swizzling.
        /// </summary>
        public dvec4 xxzz => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.xxzw swizzling.
        /// </summary>
        public dvec4 xxzw => new dvec4(x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.xxw swizzling.
        /// </summary>
        public dvec3 xxw => new dvec3(x, x, w);
        
        /// <summary>
        /// Returns dvec4.xxwx swizzling.
        /// </summary>
        public dvec4 xxwx => new dvec4(x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.xxwy swizzling.
        /// </summary>
        public dvec4 xxwy => new dvec4(x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.xxwz swizzling.
        /// </summary>
        public dvec4 xxwz => new dvec4(x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.xxww swizzling.
        /// </summary>
        public dvec4 xxww => new dvec4(x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.xy swizzling.
        /// </summary>
        public dvec2 xy => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec4.xyx swizzling.
        /// </summary>
        public dvec3 xyx => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec4.xyxx swizzling.
        /// </summary>
        public dvec4 xyxx => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.xyxy swizzling.
        /// </summary>
        public dvec4 xyxy => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.xyxz swizzling.
        /// </summary>
        public dvec4 xyxz => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.xyxw swizzling.
        /// </summary>
        public dvec4 xyxw => new dvec4(x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.xyy swizzling.
        /// </summary>
        public dvec3 xyy => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec4.xyyx swizzling.
        /// </summary>
        public dvec4 xyyx => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.xyyy swizzling.
        /// </summary>
        public dvec4 xyyy => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.xyyz swizzling.
        /// </summary>
        public dvec4 xyyz => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.xyyw swizzling.
        /// </summary>
        public dvec4 xyyw => new dvec4(x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.xyz swizzling.
        /// </summary>
        public dvec3 xyz => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec4.xyzx swizzling.
        /// </summary>
        public dvec4 xyzx => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.xyzy swizzling.
        /// </summary>
        public dvec4 xyzy => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.xyzz swizzling.
        /// </summary>
        public dvec4 xyzz => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.xyzw swizzling.
        /// </summary>
        public dvec4 xyzw => new dvec4(x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.xyw swizzling.
        /// </summary>
        public dvec3 xyw => new dvec3(x, y, w);
        
        /// <summary>
        /// Returns dvec4.xywx swizzling.
        /// </summary>
        public dvec4 xywx => new dvec4(x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.xywy swizzling.
        /// </summary>
        public dvec4 xywy => new dvec4(x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.xywz swizzling.
        /// </summary>
        public dvec4 xywz => new dvec4(x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.xyww swizzling.
        /// </summary>
        public dvec4 xyww => new dvec4(x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.xz swizzling.
        /// </summary>
        public dvec2 xz => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec4.xzx swizzling.
        /// </summary>
        public dvec3 xzx => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec4.xzxx swizzling.
        /// </summary>
        public dvec4 xzxx => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.xzxy swizzling.
        /// </summary>
        public dvec4 xzxy => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.xzxz swizzling.
        /// </summary>
        public dvec4 xzxz => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.xzxw swizzling.
        /// </summary>
        public dvec4 xzxw => new dvec4(x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.xzy swizzling.
        /// </summary>
        public dvec3 xzy => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec4.xzyx swizzling.
        /// </summary>
        public dvec4 xzyx => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.xzyy swizzling.
        /// </summary>
        public dvec4 xzyy => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.xzyz swizzling.
        /// </summary>
        public dvec4 xzyz => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.xzyw swizzling.
        /// </summary>
        public dvec4 xzyw => new dvec4(x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.xzz swizzling.
        /// </summary>
        public dvec3 xzz => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec4.xzzx swizzling.
        /// </summary>
        public dvec4 xzzx => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.xzzy swizzling.
        /// </summary>
        public dvec4 xzzy => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.xzzz swizzling.
        /// </summary>
        public dvec4 xzzz => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.xzzw swizzling.
        /// </summary>
        public dvec4 xzzw => new dvec4(x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.xzw swizzling.
        /// </summary>
        public dvec3 xzw => new dvec3(x, z, w);
        
        /// <summary>
        /// Returns dvec4.xzwx swizzling.
        /// </summary>
        public dvec4 xzwx => new dvec4(x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.xzwy swizzling.
        /// </summary>
        public dvec4 xzwy => new dvec4(x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.xzwz swizzling.
        /// </summary>
        public dvec4 xzwz => new dvec4(x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.xzww swizzling.
        /// </summary>
        public dvec4 xzww => new dvec4(x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.xw swizzling.
        /// </summary>
        public dvec2 xw => new dvec2(x, w);
        
        /// <summary>
        /// Returns dvec4.xwx swizzling.
        /// </summary>
        public dvec3 xwx => new dvec3(x, w, x);
        
        /// <summary>
        /// Returns dvec4.xwxx swizzling.
        /// </summary>
        public dvec4 xwxx => new dvec4(x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.xwxy swizzling.
        /// </summary>
        public dvec4 xwxy => new dvec4(x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.xwxz swizzling.
        /// </summary>
        public dvec4 xwxz => new dvec4(x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.xwxw swizzling.
        /// </summary>
        public dvec4 xwxw => new dvec4(x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.xwy swizzling.
        /// </summary>
        public dvec3 xwy => new dvec3(x, w, y);
        
        /// <summary>
        /// Returns dvec4.xwyx swizzling.
        /// </summary>
        public dvec4 xwyx => new dvec4(x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.xwyy swizzling.
        /// </summary>
        public dvec4 xwyy => new dvec4(x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.xwyz swizzling.
        /// </summary>
        public dvec4 xwyz => new dvec4(x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.xwyw swizzling.
        /// </summary>
        public dvec4 xwyw => new dvec4(x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.xwz swizzling.
        /// </summary>
        public dvec3 xwz => new dvec3(x, w, z);
        
        /// <summary>
        /// Returns dvec4.xwzx swizzling.
        /// </summary>
        public dvec4 xwzx => new dvec4(x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.xwzy swizzling.
        /// </summary>
        public dvec4 xwzy => new dvec4(x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.xwzz swizzling.
        /// </summary>
        public dvec4 xwzz => new dvec4(x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.xwzw swizzling.
        /// </summary>
        public dvec4 xwzw => new dvec4(x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.xww swizzling.
        /// </summary>
        public dvec3 xww => new dvec3(x, w, w);
        
        /// <summary>
        /// Returns dvec4.xwwx swizzling.
        /// </summary>
        public dvec4 xwwx => new dvec4(x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.xwwy swizzling.
        /// </summary>
        public dvec4 xwwy => new dvec4(x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.xwwz swizzling.
        /// </summary>
        public dvec4 xwwz => new dvec4(x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.xwww swizzling.
        /// </summary>
        public dvec4 xwww => new dvec4(x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.yx swizzling.
        /// </summary>
        public dvec2 yx => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec4.yxx swizzling.
        /// </summary>
        public dvec3 yxx => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec4.yxxx swizzling.
        /// </summary>
        public dvec4 yxxx => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.yxxy swizzling.
        /// </summary>
        public dvec4 yxxy => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.yxxz swizzling.
        /// </summary>
        public dvec4 yxxz => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.yxxw swizzling.
        /// </summary>
        public dvec4 yxxw => new dvec4(y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.yxy swizzling.
        /// </summary>
        public dvec3 yxy => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec4.yxyx swizzling.
        /// </summary>
        public dvec4 yxyx => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.yxyy swizzling.
        /// </summary>
        public dvec4 yxyy => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.yxyz swizzling.
        /// </summary>
        public dvec4 yxyz => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.yxyw swizzling.
        /// </summary>
        public dvec4 yxyw => new dvec4(y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.yxz swizzling.
        /// </summary>
        public dvec3 yxz => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec4.yxzx swizzling.
        /// </summary>
        public dvec4 yxzx => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.yxzy swizzling.
        /// </summary>
        public dvec4 yxzy => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.yxzz swizzling.
        /// </summary>
        public dvec4 yxzz => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.yxzw swizzling.
        /// </summary>
        public dvec4 yxzw => new dvec4(y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.yxw swizzling.
        /// </summary>
        public dvec3 yxw => new dvec3(y, x, w);
        
        /// <summary>
        /// Returns dvec4.yxwx swizzling.
        /// </summary>
        public dvec4 yxwx => new dvec4(y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.yxwy swizzling.
        /// </summary>
        public dvec4 yxwy => new dvec4(y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.yxwz swizzling.
        /// </summary>
        public dvec4 yxwz => new dvec4(y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.yxww swizzling.
        /// </summary>
        public dvec4 yxww => new dvec4(y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.yy swizzling.
        /// </summary>
        public dvec2 yy => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec4.yyx swizzling.
        /// </summary>
        public dvec3 yyx => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec4.yyxx swizzling.
        /// </summary>
        public dvec4 yyxx => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.yyxy swizzling.
        /// </summary>
        public dvec4 yyxy => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.yyxz swizzling.
        /// </summary>
        public dvec4 yyxz => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.yyxw swizzling.
        /// </summary>
        public dvec4 yyxw => new dvec4(y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.yyy swizzling.
        /// </summary>
        public dvec3 yyy => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec4.yyyx swizzling.
        /// </summary>
        public dvec4 yyyx => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.yyyy swizzling.
        /// </summary>
        public dvec4 yyyy => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.yyyz swizzling.
        /// </summary>
        public dvec4 yyyz => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.yyyw swizzling.
        /// </summary>
        public dvec4 yyyw => new dvec4(y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.yyz swizzling.
        /// </summary>
        public dvec3 yyz => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec4.yyzx swizzling.
        /// </summary>
        public dvec4 yyzx => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.yyzy swizzling.
        /// </summary>
        public dvec4 yyzy => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.yyzz swizzling.
        /// </summary>
        public dvec4 yyzz => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.yyzw swizzling.
        /// </summary>
        public dvec4 yyzw => new dvec4(y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.yyw swizzling.
        /// </summary>
        public dvec3 yyw => new dvec3(y, y, w);
        
        /// <summary>
        /// Returns dvec4.yywx swizzling.
        /// </summary>
        public dvec4 yywx => new dvec4(y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.yywy swizzling.
        /// </summary>
        public dvec4 yywy => new dvec4(y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.yywz swizzling.
        /// </summary>
        public dvec4 yywz => new dvec4(y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.yyww swizzling.
        /// </summary>
        public dvec4 yyww => new dvec4(y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.yz swizzling.
        /// </summary>
        public dvec2 yz => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec4.yzx swizzling.
        /// </summary>
        public dvec3 yzx => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec4.yzxx swizzling.
        /// </summary>
        public dvec4 yzxx => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.yzxy swizzling.
        /// </summary>
        public dvec4 yzxy => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.yzxz swizzling.
        /// </summary>
        public dvec4 yzxz => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.yzxw swizzling.
        /// </summary>
        public dvec4 yzxw => new dvec4(y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.yzy swizzling.
        /// </summary>
        public dvec3 yzy => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec4.yzyx swizzling.
        /// </summary>
        public dvec4 yzyx => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.yzyy swizzling.
        /// </summary>
        public dvec4 yzyy => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.yzyz swizzling.
        /// </summary>
        public dvec4 yzyz => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.yzyw swizzling.
        /// </summary>
        public dvec4 yzyw => new dvec4(y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.yzz swizzling.
        /// </summary>
        public dvec3 yzz => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec4.yzzx swizzling.
        /// </summary>
        public dvec4 yzzx => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.yzzy swizzling.
        /// </summary>
        public dvec4 yzzy => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.yzzz swizzling.
        /// </summary>
        public dvec4 yzzz => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.yzzw swizzling.
        /// </summary>
        public dvec4 yzzw => new dvec4(y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.yzw swizzling.
        /// </summary>
        public dvec3 yzw => new dvec3(y, z, w);
        
        /// <summary>
        /// Returns dvec4.yzwx swizzling.
        /// </summary>
        public dvec4 yzwx => new dvec4(y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.yzwy swizzling.
        /// </summary>
        public dvec4 yzwy => new dvec4(y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.yzwz swizzling.
        /// </summary>
        public dvec4 yzwz => new dvec4(y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.yzww swizzling.
        /// </summary>
        public dvec4 yzww => new dvec4(y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.yw swizzling.
        /// </summary>
        public dvec2 yw => new dvec2(y, w);
        
        /// <summary>
        /// Returns dvec4.ywx swizzling.
        /// </summary>
        public dvec3 ywx => new dvec3(y, w, x);
        
        /// <summary>
        /// Returns dvec4.ywxx swizzling.
        /// </summary>
        public dvec4 ywxx => new dvec4(y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.ywxy swizzling.
        /// </summary>
        public dvec4 ywxy => new dvec4(y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.ywxz swizzling.
        /// </summary>
        public dvec4 ywxz => new dvec4(y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.ywxw swizzling.
        /// </summary>
        public dvec4 ywxw => new dvec4(y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.ywy swizzling.
        /// </summary>
        public dvec3 ywy => new dvec3(y, w, y);
        
        /// <summary>
        /// Returns dvec4.ywyx swizzling.
        /// </summary>
        public dvec4 ywyx => new dvec4(y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.ywyy swizzling.
        /// </summary>
        public dvec4 ywyy => new dvec4(y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.ywyz swizzling.
        /// </summary>
        public dvec4 ywyz => new dvec4(y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.ywyw swizzling.
        /// </summary>
        public dvec4 ywyw => new dvec4(y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.ywz swizzling.
        /// </summary>
        public dvec3 ywz => new dvec3(y, w, z);
        
        /// <summary>
        /// Returns dvec4.ywzx swizzling.
        /// </summary>
        public dvec4 ywzx => new dvec4(y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.ywzy swizzling.
        /// </summary>
        public dvec4 ywzy => new dvec4(y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.ywzz swizzling.
        /// </summary>
        public dvec4 ywzz => new dvec4(y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.ywzw swizzling.
        /// </summary>
        public dvec4 ywzw => new dvec4(y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.yww swizzling.
        /// </summary>
        public dvec3 yww => new dvec3(y, w, w);
        
        /// <summary>
        /// Returns dvec4.ywwx swizzling.
        /// </summary>
        public dvec4 ywwx => new dvec4(y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.ywwy swizzling.
        /// </summary>
        public dvec4 ywwy => new dvec4(y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.ywwz swizzling.
        /// </summary>
        public dvec4 ywwz => new dvec4(y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.ywww swizzling.
        /// </summary>
        public dvec4 ywww => new dvec4(y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.zx swizzling.
        /// </summary>
        public dvec2 zx => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec4.zxx swizzling.
        /// </summary>
        public dvec3 zxx => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec4.zxxx swizzling.
        /// </summary>
        public dvec4 zxxx => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.zxxy swizzling.
        /// </summary>
        public dvec4 zxxy => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.zxxz swizzling.
        /// </summary>
        public dvec4 zxxz => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.zxxw swizzling.
        /// </summary>
        public dvec4 zxxw => new dvec4(z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.zxy swizzling.
        /// </summary>
        public dvec3 zxy => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec4.zxyx swizzling.
        /// </summary>
        public dvec4 zxyx => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.zxyy swizzling.
        /// </summary>
        public dvec4 zxyy => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.zxyz swizzling.
        /// </summary>
        public dvec4 zxyz => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.zxyw swizzling.
        /// </summary>
        public dvec4 zxyw => new dvec4(z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.zxz swizzling.
        /// </summary>
        public dvec3 zxz => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec4.zxzx swizzling.
        /// </summary>
        public dvec4 zxzx => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.zxzy swizzling.
        /// </summary>
        public dvec4 zxzy => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.zxzz swizzling.
        /// </summary>
        public dvec4 zxzz => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.zxzw swizzling.
        /// </summary>
        public dvec4 zxzw => new dvec4(z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.zxw swizzling.
        /// </summary>
        public dvec3 zxw => new dvec3(z, x, w);
        
        /// <summary>
        /// Returns dvec4.zxwx swizzling.
        /// </summary>
        public dvec4 zxwx => new dvec4(z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.zxwy swizzling.
        /// </summary>
        public dvec4 zxwy => new dvec4(z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.zxwz swizzling.
        /// </summary>
        public dvec4 zxwz => new dvec4(z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.zxww swizzling.
        /// </summary>
        public dvec4 zxww => new dvec4(z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.zy swizzling.
        /// </summary>
        public dvec2 zy => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec4.zyx swizzling.
        /// </summary>
        public dvec3 zyx => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec4.zyxx swizzling.
        /// </summary>
        public dvec4 zyxx => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.zyxy swizzling.
        /// </summary>
        public dvec4 zyxy => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.zyxz swizzling.
        /// </summary>
        public dvec4 zyxz => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.zyxw swizzling.
        /// </summary>
        public dvec4 zyxw => new dvec4(z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.zyy swizzling.
        /// </summary>
        public dvec3 zyy => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec4.zyyx swizzling.
        /// </summary>
        public dvec4 zyyx => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.zyyy swizzling.
        /// </summary>
        public dvec4 zyyy => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.zyyz swizzling.
        /// </summary>
        public dvec4 zyyz => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.zyyw swizzling.
        /// </summary>
        public dvec4 zyyw => new dvec4(z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.zyz swizzling.
        /// </summary>
        public dvec3 zyz => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec4.zyzx swizzling.
        /// </summary>
        public dvec4 zyzx => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.zyzy swizzling.
        /// </summary>
        public dvec4 zyzy => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.zyzz swizzling.
        /// </summary>
        public dvec4 zyzz => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.zyzw swizzling.
        /// </summary>
        public dvec4 zyzw => new dvec4(z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.zyw swizzling.
        /// </summary>
        public dvec3 zyw => new dvec3(z, y, w);
        
        /// <summary>
        /// Returns dvec4.zywx swizzling.
        /// </summary>
        public dvec4 zywx => new dvec4(z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.zywy swizzling.
        /// </summary>
        public dvec4 zywy => new dvec4(z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.zywz swizzling.
        /// </summary>
        public dvec4 zywz => new dvec4(z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.zyww swizzling.
        /// </summary>
        public dvec4 zyww => new dvec4(z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.zz swizzling.
        /// </summary>
        public dvec2 zz => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec4.zzx swizzling.
        /// </summary>
        public dvec3 zzx => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec4.zzxx swizzling.
        /// </summary>
        public dvec4 zzxx => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.zzxy swizzling.
        /// </summary>
        public dvec4 zzxy => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.zzxz swizzling.
        /// </summary>
        public dvec4 zzxz => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.zzxw swizzling.
        /// </summary>
        public dvec4 zzxw => new dvec4(z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.zzy swizzling.
        /// </summary>
        public dvec3 zzy => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec4.zzyx swizzling.
        /// </summary>
        public dvec4 zzyx => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.zzyy swizzling.
        /// </summary>
        public dvec4 zzyy => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.zzyz swizzling.
        /// </summary>
        public dvec4 zzyz => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.zzyw swizzling.
        /// </summary>
        public dvec4 zzyw => new dvec4(z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.zzz swizzling.
        /// </summary>
        public dvec3 zzz => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec4.zzzx swizzling.
        /// </summary>
        public dvec4 zzzx => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.zzzy swizzling.
        /// </summary>
        public dvec4 zzzy => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.zzzz swizzling.
        /// </summary>
        public dvec4 zzzz => new dvec4(z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.zzzw swizzling.
        /// </summary>
        public dvec4 zzzw => new dvec4(z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.zzw swizzling.
        /// </summary>
        public dvec3 zzw => new dvec3(z, z, w);
        
        /// <summary>
        /// Returns dvec4.zzwx swizzling.
        /// </summary>
        public dvec4 zzwx => new dvec4(z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.zzwy swizzling.
        /// </summary>
        public dvec4 zzwy => new dvec4(z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.zzwz swizzling.
        /// </summary>
        public dvec4 zzwz => new dvec4(z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.zzww swizzling.
        /// </summary>
        public dvec4 zzww => new dvec4(z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.zw swizzling.
        /// </summary>
        public dvec2 zw => new dvec2(z, w);
        
        /// <summary>
        /// Returns dvec4.zwx swizzling.
        /// </summary>
        public dvec3 zwx => new dvec3(z, w, x);
        
        /// <summary>
        /// Returns dvec4.zwxx swizzling.
        /// </summary>
        public dvec4 zwxx => new dvec4(z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.zwxy swizzling.
        /// </summary>
        public dvec4 zwxy => new dvec4(z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.zwxz swizzling.
        /// </summary>
        public dvec4 zwxz => new dvec4(z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.zwxw swizzling.
        /// </summary>
        public dvec4 zwxw => new dvec4(z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.zwy swizzling.
        /// </summary>
        public dvec3 zwy => new dvec3(z, w, y);
        
        /// <summary>
        /// Returns dvec4.zwyx swizzling.
        /// </summary>
        public dvec4 zwyx => new dvec4(z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.zwyy swizzling.
        /// </summary>
        public dvec4 zwyy => new dvec4(z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.zwyz swizzling.
        /// </summary>
        public dvec4 zwyz => new dvec4(z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.zwyw swizzling.
        /// </summary>
        public dvec4 zwyw => new dvec4(z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.zwz swizzling.
        /// </summary>
        public dvec3 zwz => new dvec3(z, w, z);
        
        /// <summary>
        /// Returns dvec4.zwzx swizzling.
        /// </summary>
        public dvec4 zwzx => new dvec4(z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.zwzy swizzling.
        /// </summary>
        public dvec4 zwzy => new dvec4(z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.zwzz swizzling.
        /// </summary>
        public dvec4 zwzz => new dvec4(z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.zwzw swizzling.
        /// </summary>
        public dvec4 zwzw => new dvec4(z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.zww swizzling.
        /// </summary>
        public dvec3 zww => new dvec3(z, w, w);
        
        /// <summary>
        /// Returns dvec4.zwwx swizzling.
        /// </summary>
        public dvec4 zwwx => new dvec4(z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.zwwy swizzling.
        /// </summary>
        public dvec4 zwwy => new dvec4(z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.zwwz swizzling.
        /// </summary>
        public dvec4 zwwz => new dvec4(z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.zwww swizzling.
        /// </summary>
        public dvec4 zwww => new dvec4(z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.wx swizzling.
        /// </summary>
        public dvec2 wx => new dvec2(w, x);
        
        /// <summary>
        /// Returns dvec4.wxx swizzling.
        /// </summary>
        public dvec3 wxx => new dvec3(w, x, x);
        
        /// <summary>
        /// Returns dvec4.wxxx swizzling.
        /// </summary>
        public dvec4 wxxx => new dvec4(w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.wxxy swizzling.
        /// </summary>
        public dvec4 wxxy => new dvec4(w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.wxxz swizzling.
        /// </summary>
        public dvec4 wxxz => new dvec4(w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.wxxw swizzling.
        /// </summary>
        public dvec4 wxxw => new dvec4(w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.wxy swizzling.
        /// </summary>
        public dvec3 wxy => new dvec3(w, x, y);
        
        /// <summary>
        /// Returns dvec4.wxyx swizzling.
        /// </summary>
        public dvec4 wxyx => new dvec4(w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.wxyy swizzling.
        /// </summary>
        public dvec4 wxyy => new dvec4(w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.wxyz swizzling.
        /// </summary>
        public dvec4 wxyz => new dvec4(w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.wxyw swizzling.
        /// </summary>
        public dvec4 wxyw => new dvec4(w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.wxz swizzling.
        /// </summary>
        public dvec3 wxz => new dvec3(w, x, z);
        
        /// <summary>
        /// Returns dvec4.wxzx swizzling.
        /// </summary>
        public dvec4 wxzx => new dvec4(w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.wxzy swizzling.
        /// </summary>
        public dvec4 wxzy => new dvec4(w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.wxzz swizzling.
        /// </summary>
        public dvec4 wxzz => new dvec4(w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.wxzw swizzling.
        /// </summary>
        public dvec4 wxzw => new dvec4(w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.wxw swizzling.
        /// </summary>
        public dvec3 wxw => new dvec3(w, x, w);
        
        /// <summary>
        /// Returns dvec4.wxwx swizzling.
        /// </summary>
        public dvec4 wxwx => new dvec4(w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.wxwy swizzling.
        /// </summary>
        public dvec4 wxwy => new dvec4(w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.wxwz swizzling.
        /// </summary>
        public dvec4 wxwz => new dvec4(w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.wxww swizzling.
        /// </summary>
        public dvec4 wxww => new dvec4(w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.wy swizzling.
        /// </summary>
        public dvec2 wy => new dvec2(w, y);
        
        /// <summary>
        /// Returns dvec4.wyx swizzling.
        /// </summary>
        public dvec3 wyx => new dvec3(w, y, x);
        
        /// <summary>
        /// Returns dvec4.wyxx swizzling.
        /// </summary>
        public dvec4 wyxx => new dvec4(w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.wyxy swizzling.
        /// </summary>
        public dvec4 wyxy => new dvec4(w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.wyxz swizzling.
        /// </summary>
        public dvec4 wyxz => new dvec4(w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.wyxw swizzling.
        /// </summary>
        public dvec4 wyxw => new dvec4(w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.wyy swizzling.
        /// </summary>
        public dvec3 wyy => new dvec3(w, y, y);
        
        /// <summary>
        /// Returns dvec4.wyyx swizzling.
        /// </summary>
        public dvec4 wyyx => new dvec4(w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.wyyy swizzling.
        /// </summary>
        public dvec4 wyyy => new dvec4(w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.wyyz swizzling.
        /// </summary>
        public dvec4 wyyz => new dvec4(w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.wyyw swizzling.
        /// </summary>
        public dvec4 wyyw => new dvec4(w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.wyz swizzling.
        /// </summary>
        public dvec3 wyz => new dvec3(w, y, z);
        
        /// <summary>
        /// Returns dvec4.wyzx swizzling.
        /// </summary>
        public dvec4 wyzx => new dvec4(w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.wyzy swizzling.
        /// </summary>
        public dvec4 wyzy => new dvec4(w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.wyzz swizzling.
        /// </summary>
        public dvec4 wyzz => new dvec4(w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.wyzw swizzling.
        /// </summary>
        public dvec4 wyzw => new dvec4(w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.wyw swizzling.
        /// </summary>
        public dvec3 wyw => new dvec3(w, y, w);
        
        /// <summary>
        /// Returns dvec4.wywx swizzling.
        /// </summary>
        public dvec4 wywx => new dvec4(w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.wywy swizzling.
        /// </summary>
        public dvec4 wywy => new dvec4(w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.wywz swizzling.
        /// </summary>
        public dvec4 wywz => new dvec4(w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.wyww swizzling.
        /// </summary>
        public dvec4 wyww => new dvec4(w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.wz swizzling.
        /// </summary>
        public dvec2 wz => new dvec2(w, z);
        
        /// <summary>
        /// Returns dvec4.wzx swizzling.
        /// </summary>
        public dvec3 wzx => new dvec3(w, z, x);
        
        /// <summary>
        /// Returns dvec4.wzxx swizzling.
        /// </summary>
        public dvec4 wzxx => new dvec4(w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.wzxy swizzling.
        /// </summary>
        public dvec4 wzxy => new dvec4(w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.wzxz swizzling.
        /// </summary>
        public dvec4 wzxz => new dvec4(w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.wzxw swizzling.
        /// </summary>
        public dvec4 wzxw => new dvec4(w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.wzy swizzling.
        /// </summary>
        public dvec3 wzy => new dvec3(w, z, y);
        
        /// <summary>
        /// Returns dvec4.wzyx swizzling.
        /// </summary>
        public dvec4 wzyx => new dvec4(w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.wzyy swizzling.
        /// </summary>
        public dvec4 wzyy => new dvec4(w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.wzyz swizzling.
        /// </summary>
        public dvec4 wzyz => new dvec4(w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.wzyw swizzling.
        /// </summary>
        public dvec4 wzyw => new dvec4(w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.wzz swizzling.
        /// </summary>
        public dvec3 wzz => new dvec3(w, z, z);
        
        /// <summary>
        /// Returns dvec4.wzzx swizzling.
        /// </summary>
        public dvec4 wzzx => new dvec4(w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.wzzy swizzling.
        /// </summary>
        public dvec4 wzzy => new dvec4(w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.wzzz swizzling.
        /// </summary>
        public dvec4 wzzz => new dvec4(w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.wzzw swizzling.
        /// </summary>
        public dvec4 wzzw => new dvec4(w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.wzw swizzling.
        /// </summary>
        public dvec3 wzw => new dvec3(w, z, w);
        
        /// <summary>
        /// Returns dvec4.wzwx swizzling.
        /// </summary>
        public dvec4 wzwx => new dvec4(w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.wzwy swizzling.
        /// </summary>
        public dvec4 wzwy => new dvec4(w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.wzwz swizzling.
        /// </summary>
        public dvec4 wzwz => new dvec4(w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.wzww swizzling.
        /// </summary>
        public dvec4 wzww => new dvec4(w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.ww swizzling.
        /// </summary>
        public dvec2 ww => new dvec2(w, w);
        
        /// <summary>
        /// Returns dvec4.wwx swizzling.
        /// </summary>
        public dvec3 wwx => new dvec3(w, w, x);
        
        /// <summary>
        /// Returns dvec4.wwxx swizzling.
        /// </summary>
        public dvec4 wwxx => new dvec4(w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.wwxy swizzling.
        /// </summary>
        public dvec4 wwxy => new dvec4(w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.wwxz swizzling.
        /// </summary>
        public dvec4 wwxz => new dvec4(w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.wwxw swizzling.
        /// </summary>
        public dvec4 wwxw => new dvec4(w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.wwy swizzling.
        /// </summary>
        public dvec3 wwy => new dvec3(w, w, y);
        
        /// <summary>
        /// Returns dvec4.wwyx swizzling.
        /// </summary>
        public dvec4 wwyx => new dvec4(w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.wwyy swizzling.
        /// </summary>
        public dvec4 wwyy => new dvec4(w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.wwyz swizzling.
        /// </summary>
        public dvec4 wwyz => new dvec4(w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.wwyw swizzling.
        /// </summary>
        public dvec4 wwyw => new dvec4(w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.wwz swizzling.
        /// </summary>
        public dvec3 wwz => new dvec3(w, w, z);
        
        /// <summary>
        /// Returns dvec4.wwzx swizzling.
        /// </summary>
        public dvec4 wwzx => new dvec4(w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.wwzy swizzling.
        /// </summary>
        public dvec4 wwzy => new dvec4(w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.wwzz swizzling.
        /// </summary>
        public dvec4 wwzz => new dvec4(w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.wwzw swizzling.
        /// </summary>
        public dvec4 wwzw => new dvec4(w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.www swizzling.
        /// </summary>
        public dvec3 www => new dvec3(w, w, w);
        
        /// <summary>
        /// Returns dvec4.wwwx swizzling.
        /// </summary>
        public dvec4 wwwx => new dvec4(w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.wwwy swizzling.
        /// </summary>
        public dvec4 wwwy => new dvec4(w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.wwwz swizzling.
        /// </summary>
        public dvec4 wwwz => new dvec4(w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.wwww swizzling.
        /// </summary>
        public dvec4 wwww => new dvec4(w, w, w, w);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns dvec4.rr swizzling.
        /// </summary>
        public dvec2 rr => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec4.rrr swizzling.
        /// </summary>
        public dvec3 rrr => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec4.rrrr swizzling.
        /// </summary>
        public dvec4 rrrr => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec4.rrrg swizzling.
        /// </summary>
        public dvec4 rrrg => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec4.rrrb swizzling.
        /// </summary>
        public dvec4 rrrb => new dvec4(x, x, x, z);
        
        /// <summary>
        /// Returns dvec4.rrra swizzling.
        /// </summary>
        public dvec4 rrra => new dvec4(x, x, x, w);
        
        /// <summary>
        /// Returns dvec4.rrg swizzling.
        /// </summary>
        public dvec3 rrg => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec4.rrgr swizzling.
        /// </summary>
        public dvec4 rrgr => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec4.rrgg swizzling.
        /// </summary>
        public dvec4 rrgg => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec4.rrgb swizzling.
        /// </summary>
        public dvec4 rrgb => new dvec4(x, x, y, z);
        
        /// <summary>
        /// Returns dvec4.rrga swizzling.
        /// </summary>
        public dvec4 rrga => new dvec4(x, x, y, w);
        
        /// <summary>
        /// Returns dvec4.rrb swizzling.
        /// </summary>
        public dvec3 rrb => new dvec3(x, x, z);
        
        /// <summary>
        /// Returns dvec4.rrbr swizzling.
        /// </summary>
        public dvec4 rrbr => new dvec4(x, x, z, x);
        
        /// <summary>
        /// Returns dvec4.rrbg swizzling.
        /// </summary>
        public dvec4 rrbg => new dvec4(x, x, z, y);
        
        /// <summary>
        /// Returns dvec4.rrbb swizzling.
        /// </summary>
        public dvec4 rrbb => new dvec4(x, x, z, z);
        
        /// <summary>
        /// Returns dvec4.rrba swizzling.
        /// </summary>
        public dvec4 rrba => new dvec4(x, x, z, w);
        
        /// <summary>
        /// Returns dvec4.rra swizzling.
        /// </summary>
        public dvec3 rra => new dvec3(x, x, w);
        
        /// <summary>
        /// Returns dvec4.rrar swizzling.
        /// </summary>
        public dvec4 rrar => new dvec4(x, x, w, x);
        
        /// <summary>
        /// Returns dvec4.rrag swizzling.
        /// </summary>
        public dvec4 rrag => new dvec4(x, x, w, y);
        
        /// <summary>
        /// Returns dvec4.rrab swizzling.
        /// </summary>
        public dvec4 rrab => new dvec4(x, x, w, z);
        
        /// <summary>
        /// Returns dvec4.rraa swizzling.
        /// </summary>
        public dvec4 rraa => new dvec4(x, x, w, w);
        
        /// <summary>
        /// Returns dvec4.rg swizzling.
        /// </summary>
        public dvec2 rg => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec4.rgr swizzling.
        /// </summary>
        public dvec3 rgr => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec4.rgrr swizzling.
        /// </summary>
        public dvec4 rgrr => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec4.rgrg swizzling.
        /// </summary>
        public dvec4 rgrg => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec4.rgrb swizzling.
        /// </summary>
        public dvec4 rgrb => new dvec4(x, y, x, z);
        
        /// <summary>
        /// Returns dvec4.rgra swizzling.
        /// </summary>
        public dvec4 rgra => new dvec4(x, y, x, w);
        
        /// <summary>
        /// Returns dvec4.rgg swizzling.
        /// </summary>
        public dvec3 rgg => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec4.rggr swizzling.
        /// </summary>
        public dvec4 rggr => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec4.rggg swizzling.
        /// </summary>
        public dvec4 rggg => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec4.rggb swizzling.
        /// </summary>
        public dvec4 rggb => new dvec4(x, y, y, z);
        
        /// <summary>
        /// Returns dvec4.rgga swizzling.
        /// </summary>
        public dvec4 rgga => new dvec4(x, y, y, w);
        
        /// <summary>
        /// Returns dvec4.rgb swizzling.
        /// </summary>
        public dvec3 rgb => new dvec3(x, y, z);
        
        /// <summary>
        /// Returns dvec4.rgbr swizzling.
        /// </summary>
        public dvec4 rgbr => new dvec4(x, y, z, x);
        
        /// <summary>
        /// Returns dvec4.rgbg swizzling.
        /// </summary>
        public dvec4 rgbg => new dvec4(x, y, z, y);
        
        /// <summary>
        /// Returns dvec4.rgbb swizzling.
        /// </summary>
        public dvec4 rgbb => new dvec4(x, y, z, z);
        
        /// <summary>
        /// Returns dvec4.rgba swizzling.
        /// </summary>
        public dvec4 rgba => new dvec4(x, y, z, w);
        
        /// <summary>
        /// Returns dvec4.rga swizzling.
        /// </summary>
        public dvec3 rga => new dvec3(x, y, w);
        
        /// <summary>
        /// Returns dvec4.rgar swizzling.
        /// </summary>
        public dvec4 rgar => new dvec4(x, y, w, x);
        
        /// <summary>
        /// Returns dvec4.rgag swizzling.
        /// </summary>
        public dvec4 rgag => new dvec4(x, y, w, y);
        
        /// <summary>
        /// Returns dvec4.rgab swizzling.
        /// </summary>
        public dvec4 rgab => new dvec4(x, y, w, z);
        
        /// <summary>
        /// Returns dvec4.rgaa swizzling.
        /// </summary>
        public dvec4 rgaa => new dvec4(x, y, w, w);
        
        /// <summary>
        /// Returns dvec4.rb swizzling.
        /// </summary>
        public dvec2 rb => new dvec2(x, z);
        
        /// <summary>
        /// Returns dvec4.rbr swizzling.
        /// </summary>
        public dvec3 rbr => new dvec3(x, z, x);
        
        /// <summary>
        /// Returns dvec4.rbrr swizzling.
        /// </summary>
        public dvec4 rbrr => new dvec4(x, z, x, x);
        
        /// <summary>
        /// Returns dvec4.rbrg swizzling.
        /// </summary>
        public dvec4 rbrg => new dvec4(x, z, x, y);
        
        /// <summary>
        /// Returns dvec4.rbrb swizzling.
        /// </summary>
        public dvec4 rbrb => new dvec4(x, z, x, z);
        
        /// <summary>
        /// Returns dvec4.rbra swizzling.
        /// </summary>
        public dvec4 rbra => new dvec4(x, z, x, w);
        
        /// <summary>
        /// Returns dvec4.rbg swizzling.
        /// </summary>
        public dvec3 rbg => new dvec3(x, z, y);
        
        /// <summary>
        /// Returns dvec4.rbgr swizzling.
        /// </summary>
        public dvec4 rbgr => new dvec4(x, z, y, x);
        
        /// <summary>
        /// Returns dvec4.rbgg swizzling.
        /// </summary>
        public dvec4 rbgg => new dvec4(x, z, y, y);
        
        /// <summary>
        /// Returns dvec4.rbgb swizzling.
        /// </summary>
        public dvec4 rbgb => new dvec4(x, z, y, z);
        
        /// <summary>
        /// Returns dvec4.rbga swizzling.
        /// </summary>
        public dvec4 rbga => new dvec4(x, z, y, w);
        
        /// <summary>
        /// Returns dvec4.rbb swizzling.
        /// </summary>
        public dvec3 rbb => new dvec3(x, z, z);
        
        /// <summary>
        /// Returns dvec4.rbbr swizzling.
        /// </summary>
        public dvec4 rbbr => new dvec4(x, z, z, x);
        
        /// <summary>
        /// Returns dvec4.rbbg swizzling.
        /// </summary>
        public dvec4 rbbg => new dvec4(x, z, z, y);
        
        /// <summary>
        /// Returns dvec4.rbbb swizzling.
        /// </summary>
        public dvec4 rbbb => new dvec4(x, z, z, z);
        
        /// <summary>
        /// Returns dvec4.rbba swizzling.
        /// </summary>
        public dvec4 rbba => new dvec4(x, z, z, w);
        
        /// <summary>
        /// Returns dvec4.rba swizzling.
        /// </summary>
        public dvec3 rba => new dvec3(x, z, w);
        
        /// <summary>
        /// Returns dvec4.rbar swizzling.
        /// </summary>
        public dvec4 rbar => new dvec4(x, z, w, x);
        
        /// <summary>
        /// Returns dvec4.rbag swizzling.
        /// </summary>
        public dvec4 rbag => new dvec4(x, z, w, y);
        
        /// <summary>
        /// Returns dvec4.rbab swizzling.
        /// </summary>
        public dvec4 rbab => new dvec4(x, z, w, z);
        
        /// <summary>
        /// Returns dvec4.rbaa swizzling.
        /// </summary>
        public dvec4 rbaa => new dvec4(x, z, w, w);
        
        /// <summary>
        /// Returns dvec4.ra swizzling.
        /// </summary>
        public dvec2 ra => new dvec2(x, w);
        
        /// <summary>
        /// Returns dvec4.rar swizzling.
        /// </summary>
        public dvec3 rar => new dvec3(x, w, x);
        
        /// <summary>
        /// Returns dvec4.rarr swizzling.
        /// </summary>
        public dvec4 rarr => new dvec4(x, w, x, x);
        
        /// <summary>
        /// Returns dvec4.rarg swizzling.
        /// </summary>
        public dvec4 rarg => new dvec4(x, w, x, y);
        
        /// <summary>
        /// Returns dvec4.rarb swizzling.
        /// </summary>
        public dvec4 rarb => new dvec4(x, w, x, z);
        
        /// <summary>
        /// Returns dvec4.rara swizzling.
        /// </summary>
        public dvec4 rara => new dvec4(x, w, x, w);
        
        /// <summary>
        /// Returns dvec4.rag swizzling.
        /// </summary>
        public dvec3 rag => new dvec3(x, w, y);
        
        /// <summary>
        /// Returns dvec4.ragr swizzling.
        /// </summary>
        public dvec4 ragr => new dvec4(x, w, y, x);
        
        /// <summary>
        /// Returns dvec4.ragg swizzling.
        /// </summary>
        public dvec4 ragg => new dvec4(x, w, y, y);
        
        /// <summary>
        /// Returns dvec4.ragb swizzling.
        /// </summary>
        public dvec4 ragb => new dvec4(x, w, y, z);
        
        /// <summary>
        /// Returns dvec4.raga swizzling.
        /// </summary>
        public dvec4 raga => new dvec4(x, w, y, w);
        
        /// <summary>
        /// Returns dvec4.rab swizzling.
        /// </summary>
        public dvec3 rab => new dvec3(x, w, z);
        
        /// <summary>
        /// Returns dvec4.rabr swizzling.
        /// </summary>
        public dvec4 rabr => new dvec4(x, w, z, x);
        
        /// <summary>
        /// Returns dvec4.rabg swizzling.
        /// </summary>
        public dvec4 rabg => new dvec4(x, w, z, y);
        
        /// <summary>
        /// Returns dvec4.rabb swizzling.
        /// </summary>
        public dvec4 rabb => new dvec4(x, w, z, z);
        
        /// <summary>
        /// Returns dvec4.raba swizzling.
        /// </summary>
        public dvec4 raba => new dvec4(x, w, z, w);
        
        /// <summary>
        /// Returns dvec4.raa swizzling.
        /// </summary>
        public dvec3 raa => new dvec3(x, w, w);
        
        /// <summary>
        /// Returns dvec4.raar swizzling.
        /// </summary>
        public dvec4 raar => new dvec4(x, w, w, x);
        
        /// <summary>
        /// Returns dvec4.raag swizzling.
        /// </summary>
        public dvec4 raag => new dvec4(x, w, w, y);
        
        /// <summary>
        /// Returns dvec4.raab swizzling.
        /// </summary>
        public dvec4 raab => new dvec4(x, w, w, z);
        
        /// <summary>
        /// Returns dvec4.raaa swizzling.
        /// </summary>
        public dvec4 raaa => new dvec4(x, w, w, w);
        
        /// <summary>
        /// Returns dvec4.gr swizzling.
        /// </summary>
        public dvec2 gr => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec4.grr swizzling.
        /// </summary>
        public dvec3 grr => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec4.grrr swizzling.
        /// </summary>
        public dvec4 grrr => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec4.grrg swizzling.
        /// </summary>
        public dvec4 grrg => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec4.grrb swizzling.
        /// </summary>
        public dvec4 grrb => new dvec4(y, x, x, z);
        
        /// <summary>
        /// Returns dvec4.grra swizzling.
        /// </summary>
        public dvec4 grra => new dvec4(y, x, x, w);
        
        /// <summary>
        /// Returns dvec4.grg swizzling.
        /// </summary>
        public dvec3 grg => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec4.grgr swizzling.
        /// </summary>
        public dvec4 grgr => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec4.grgg swizzling.
        /// </summary>
        public dvec4 grgg => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec4.grgb swizzling.
        /// </summary>
        public dvec4 grgb => new dvec4(y, x, y, z);
        
        /// <summary>
        /// Returns dvec4.grga swizzling.
        /// </summary>
        public dvec4 grga => new dvec4(y, x, y, w);
        
        /// <summary>
        /// Returns dvec4.grb swizzling.
        /// </summary>
        public dvec3 grb => new dvec3(y, x, z);
        
        /// <summary>
        /// Returns dvec4.grbr swizzling.
        /// </summary>
        public dvec4 grbr => new dvec4(y, x, z, x);
        
        /// <summary>
        /// Returns dvec4.grbg swizzling.
        /// </summary>
        public dvec4 grbg => new dvec4(y, x, z, y);
        
        /// <summary>
        /// Returns dvec4.grbb swizzling.
        /// </summary>
        public dvec4 grbb => new dvec4(y, x, z, z);
        
        /// <summary>
        /// Returns dvec4.grba swizzling.
        /// </summary>
        public dvec4 grba => new dvec4(y, x, z, w);
        
        /// <summary>
        /// Returns dvec4.gra swizzling.
        /// </summary>
        public dvec3 gra => new dvec3(y, x, w);
        
        /// <summary>
        /// Returns dvec4.grar swizzling.
        /// </summary>
        public dvec4 grar => new dvec4(y, x, w, x);
        
        /// <summary>
        /// Returns dvec4.grag swizzling.
        /// </summary>
        public dvec4 grag => new dvec4(y, x, w, y);
        
        /// <summary>
        /// Returns dvec4.grab swizzling.
        /// </summary>
        public dvec4 grab => new dvec4(y, x, w, z);
        
        /// <summary>
        /// Returns dvec4.graa swizzling.
        /// </summary>
        public dvec4 graa => new dvec4(y, x, w, w);
        
        /// <summary>
        /// Returns dvec4.gg swizzling.
        /// </summary>
        public dvec2 gg => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec4.ggr swizzling.
        /// </summary>
        public dvec3 ggr => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec4.ggrr swizzling.
        /// </summary>
        public dvec4 ggrr => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec4.ggrg swizzling.
        /// </summary>
        public dvec4 ggrg => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec4.ggrb swizzling.
        /// </summary>
        public dvec4 ggrb => new dvec4(y, y, x, z);
        
        /// <summary>
        /// Returns dvec4.ggra swizzling.
        /// </summary>
        public dvec4 ggra => new dvec4(y, y, x, w);
        
        /// <summary>
        /// Returns dvec4.ggg swizzling.
        /// </summary>
        public dvec3 ggg => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec4.gggr swizzling.
        /// </summary>
        public dvec4 gggr => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec4.gggg swizzling.
        /// </summary>
        public dvec4 gggg => new dvec4(y, y, y, y);
        
        /// <summary>
        /// Returns dvec4.gggb swizzling.
        /// </summary>
        public dvec4 gggb => new dvec4(y, y, y, z);
        
        /// <summary>
        /// Returns dvec4.ggga swizzling.
        /// </summary>
        public dvec4 ggga => new dvec4(y, y, y, w);
        
        /// <summary>
        /// Returns dvec4.ggb swizzling.
        /// </summary>
        public dvec3 ggb => new dvec3(y, y, z);
        
        /// <summary>
        /// Returns dvec4.ggbr swizzling.
        /// </summary>
        public dvec4 ggbr => new dvec4(y, y, z, x);
        
        /// <summary>
        /// Returns dvec4.ggbg swizzling.
        /// </summary>
        public dvec4 ggbg => new dvec4(y, y, z, y);
        
        /// <summary>
        /// Returns dvec4.ggbb swizzling.
        /// </summary>
        public dvec4 ggbb => new dvec4(y, y, z, z);
        
        /// <summary>
        /// Returns dvec4.ggba swizzling.
        /// </summary>
        public dvec4 ggba => new dvec4(y, y, z, w);
        
        /// <summary>
        /// Returns dvec4.gga swizzling.
        /// </summary>
        public dvec3 gga => new dvec3(y, y, w);
        
        /// <summary>
        /// Returns dvec4.ggar swizzling.
        /// </summary>
        public dvec4 ggar => new dvec4(y, y, w, x);
        
        /// <summary>
        /// Returns dvec4.ggag swizzling.
        /// </summary>
        public dvec4 ggag => new dvec4(y, y, w, y);
        
        /// <summary>
        /// Returns dvec4.ggab swizzling.
        /// </summary>
        public dvec4 ggab => new dvec4(y, y, w, z);
        
        /// <summary>
        /// Returns dvec4.ggaa swizzling.
        /// </summary>
        public dvec4 ggaa => new dvec4(y, y, w, w);
        
        /// <summary>
        /// Returns dvec4.gb swizzling.
        /// </summary>
        public dvec2 gb => new dvec2(y, z);
        
        /// <summary>
        /// Returns dvec4.gbr swizzling.
        /// </summary>
        public dvec3 gbr => new dvec3(y, z, x);
        
        /// <summary>
        /// Returns dvec4.gbrr swizzling.
        /// </summary>
        public dvec4 gbrr => new dvec4(y, z, x, x);
        
        /// <summary>
        /// Returns dvec4.gbrg swizzling.
        /// </summary>
        public dvec4 gbrg => new dvec4(y, z, x, y);
        
        /// <summary>
        /// Returns dvec4.gbrb swizzling.
        /// </summary>
        public dvec4 gbrb => new dvec4(y, z, x, z);
        
        /// <summary>
        /// Returns dvec4.gbra swizzling.
        /// </summary>
        public dvec4 gbra => new dvec4(y, z, x, w);
        
        /// <summary>
        /// Returns dvec4.gbg swizzling.
        /// </summary>
        public dvec3 gbg => new dvec3(y, z, y);
        
        /// <summary>
        /// Returns dvec4.gbgr swizzling.
        /// </summary>
        public dvec4 gbgr => new dvec4(y, z, y, x);
        
        /// <summary>
        /// Returns dvec4.gbgg swizzling.
        /// </summary>
        public dvec4 gbgg => new dvec4(y, z, y, y);
        
        /// <summary>
        /// Returns dvec4.gbgb swizzling.
        /// </summary>
        public dvec4 gbgb => new dvec4(y, z, y, z);
        
        /// <summary>
        /// Returns dvec4.gbga swizzling.
        /// </summary>
        public dvec4 gbga => new dvec4(y, z, y, w);
        
        /// <summary>
        /// Returns dvec4.gbb swizzling.
        /// </summary>
        public dvec3 gbb => new dvec3(y, z, z);
        
        /// <summary>
        /// Returns dvec4.gbbr swizzling.
        /// </summary>
        public dvec4 gbbr => new dvec4(y, z, z, x);
        
        /// <summary>
        /// Returns dvec4.gbbg swizzling.
        /// </summary>
        public dvec4 gbbg => new dvec4(y, z, z, y);
        
        /// <summary>
        /// Returns dvec4.gbbb swizzling.
        /// </summary>
        public dvec4 gbbb => new dvec4(y, z, z, z);
        
        /// <summary>
        /// Returns dvec4.gbba swizzling.
        /// </summary>
        public dvec4 gbba => new dvec4(y, z, z, w);
        
        /// <summary>
        /// Returns dvec4.gba swizzling.
        /// </summary>
        public dvec3 gba => new dvec3(y, z, w);
        
        /// <summary>
        /// Returns dvec4.gbar swizzling.
        /// </summary>
        public dvec4 gbar => new dvec4(y, z, w, x);
        
        /// <summary>
        /// Returns dvec4.gbag swizzling.
        /// </summary>
        public dvec4 gbag => new dvec4(y, z, w, y);
        
        /// <summary>
        /// Returns dvec4.gbab swizzling.
        /// </summary>
        public dvec4 gbab => new dvec4(y, z, w, z);
        
        /// <summary>
        /// Returns dvec4.gbaa swizzling.
        /// </summary>
        public dvec4 gbaa => new dvec4(y, z, w, w);
        
        /// <summary>
        /// Returns dvec4.ga swizzling.
        /// </summary>
        public dvec2 ga => new dvec2(y, w);
        
        /// <summary>
        /// Returns dvec4.gar swizzling.
        /// </summary>
        public dvec3 gar => new dvec3(y, w, x);
        
        /// <summary>
        /// Returns dvec4.garr swizzling.
        /// </summary>
        public dvec4 garr => new dvec4(y, w, x, x);
        
        /// <summary>
        /// Returns dvec4.garg swizzling.
        /// </summary>
        public dvec4 garg => new dvec4(y, w, x, y);
        
        /// <summary>
        /// Returns dvec4.garb swizzling.
        /// </summary>
        public dvec4 garb => new dvec4(y, w, x, z);
        
        /// <summary>
        /// Returns dvec4.gara swizzling.
        /// </summary>
        public dvec4 gara => new dvec4(y, w, x, w);
        
        /// <summary>
        /// Returns dvec4.gag swizzling.
        /// </summary>
        public dvec3 gag => new dvec3(y, w, y);
        
        /// <summary>
        /// Returns dvec4.gagr swizzling.
        /// </summary>
        public dvec4 gagr => new dvec4(y, w, y, x);
        
        /// <summary>
        /// Returns dvec4.gagg swizzling.
        /// </summary>
        public dvec4 gagg => new dvec4(y, w, y, y);
        
        /// <summary>
        /// Returns dvec4.gagb swizzling.
        /// </summary>
        public dvec4 gagb => new dvec4(y, w, y, z);
        
        /// <summary>
        /// Returns dvec4.gaga swizzling.
        /// </summary>
        public dvec4 gaga => new dvec4(y, w, y, w);
        
        /// <summary>
        /// Returns dvec4.gab swizzling.
        /// </summary>
        public dvec3 gab => new dvec3(y, w, z);
        
        /// <summary>
        /// Returns dvec4.gabr swizzling.
        /// </summary>
        public dvec4 gabr => new dvec4(y, w, z, x);
        
        /// <summary>
        /// Returns dvec4.gabg swizzling.
        /// </summary>
        public dvec4 gabg => new dvec4(y, w, z, y);
        
        /// <summary>
        /// Returns dvec4.gabb swizzling.
        /// </summary>
        public dvec4 gabb => new dvec4(y, w, z, z);
        
        /// <summary>
        /// Returns dvec4.gaba swizzling.
        /// </summary>
        public dvec4 gaba => new dvec4(y, w, z, w);
        
        /// <summary>
        /// Returns dvec4.gaa swizzling.
        /// </summary>
        public dvec3 gaa => new dvec3(y, w, w);
        
        /// <summary>
        /// Returns dvec4.gaar swizzling.
        /// </summary>
        public dvec4 gaar => new dvec4(y, w, w, x);
        
        /// <summary>
        /// Returns dvec4.gaag swizzling.
        /// </summary>
        public dvec4 gaag => new dvec4(y, w, w, y);
        
        /// <summary>
        /// Returns dvec4.gaab swizzling.
        /// </summary>
        public dvec4 gaab => new dvec4(y, w, w, z);
        
        /// <summary>
        /// Returns dvec4.gaaa swizzling.
        /// </summary>
        public dvec4 gaaa => new dvec4(y, w, w, w);
        
        /// <summary>
        /// Returns dvec4.br swizzling.
        /// </summary>
        public dvec2 br => new dvec2(z, x);
        
        /// <summary>
        /// Returns dvec4.brr swizzling.
        /// </summary>
        public dvec3 brr => new dvec3(z, x, x);
        
        /// <summary>
        /// Returns dvec4.brrr swizzling.
        /// </summary>
        public dvec4 brrr => new dvec4(z, x, x, x);
        
        /// <summary>
        /// Returns dvec4.brrg swizzling.
        /// </summary>
        public dvec4 brrg => new dvec4(z, x, x, y);
        
        /// <summary>
        /// Returns dvec4.brrb swizzling.
        /// </summary>
        public dvec4 brrb => new dvec4(z, x, x, z);
        
        /// <summary>
        /// Returns dvec4.brra swizzling.
        /// </summary>
        public dvec4 brra => new dvec4(z, x, x, w);
        
        /// <summary>
        /// Returns dvec4.brg swizzling.
        /// </summary>
        public dvec3 brg => new dvec3(z, x, y);
        
        /// <summary>
        /// Returns dvec4.brgr swizzling.
        /// </summary>
        public dvec4 brgr => new dvec4(z, x, y, x);
        
        /// <summary>
        /// Returns dvec4.brgg swizzling.
        /// </summary>
        public dvec4 brgg => new dvec4(z, x, y, y);
        
        /// <summary>
        /// Returns dvec4.brgb swizzling.
        /// </summary>
        public dvec4 brgb => new dvec4(z, x, y, z);
        
        /// <summary>
        /// Returns dvec4.brga swizzling.
        /// </summary>
        public dvec4 brga => new dvec4(z, x, y, w);
        
        /// <summary>
        /// Returns dvec4.brb swizzling.
        /// </summary>
        public dvec3 brb => new dvec3(z, x, z);
        
        /// <summary>
        /// Returns dvec4.brbr swizzling.
        /// </summary>
        public dvec4 brbr => new dvec4(z, x, z, x);
        
        /// <summary>
        /// Returns dvec4.brbg swizzling.
        /// </summary>
        public dvec4 brbg => new dvec4(z, x, z, y);
        
        /// <summary>
        /// Returns dvec4.brbb swizzling.
        /// </summary>
        public dvec4 brbb => new dvec4(z, x, z, z);
        
        /// <summary>
        /// Returns dvec4.brba swizzling.
        /// </summary>
        public dvec4 brba => new dvec4(z, x, z, w);
        
        /// <summary>
        /// Returns dvec4.bra swizzling.
        /// </summary>
        public dvec3 bra => new dvec3(z, x, w);
        
        /// <summary>
        /// Returns dvec4.brar swizzling.
        /// </summary>
        public dvec4 brar => new dvec4(z, x, w, x);
        
        /// <summary>
        /// Returns dvec4.brag swizzling.
        /// </summary>
        public dvec4 brag => new dvec4(z, x, w, y);
        
        /// <summary>
        /// Returns dvec4.brab swizzling.
        /// </summary>
        public dvec4 brab => new dvec4(z, x, w, z);
        
        /// <summary>
        /// Returns dvec4.braa swizzling.
        /// </summary>
        public dvec4 braa => new dvec4(z, x, w, w);
        
        /// <summary>
        /// Returns dvec4.bg swizzling.
        /// </summary>
        public dvec2 bg => new dvec2(z, y);
        
        /// <summary>
        /// Returns dvec4.bgr swizzling.
        /// </summary>
        public dvec3 bgr => new dvec3(z, y, x);
        
        /// <summary>
        /// Returns dvec4.bgrr swizzling.
        /// </summary>
        public dvec4 bgrr => new dvec4(z, y, x, x);
        
        /// <summary>
        /// Returns dvec4.bgrg swizzling.
        /// </summary>
        public dvec4 bgrg => new dvec4(z, y, x, y);
        
        /// <summary>
        /// Returns dvec4.bgrb swizzling.
        /// </summary>
        public dvec4 bgrb => new dvec4(z, y, x, z);
        
        /// <summary>
        /// Returns dvec4.bgra swizzling.
        /// </summary>
        public dvec4 bgra => new dvec4(z, y, x, w);
        
        /// <summary>
        /// Returns dvec4.bgg swizzling.
        /// </summary>
        public dvec3 bgg => new dvec3(z, y, y);
        
        /// <summary>
        /// Returns dvec4.bggr swizzling.
        /// </summary>
        public dvec4 bggr => new dvec4(z, y, y, x);
        
        /// <summary>
        /// Returns dvec4.bggg swizzling.
        /// </summary>
        public dvec4 bggg => new dvec4(z, y, y, y);
        
        /// <summary>
        /// Returns dvec4.bggb swizzling.
        /// </summary>
        public dvec4 bggb => new dvec4(z, y, y, z);
        
        /// <summary>
        /// Returns dvec4.bgga swizzling.
        /// </summary>
        public dvec4 bgga => new dvec4(z, y, y, w);
        
        /// <summary>
        /// Returns dvec4.bgb swizzling.
        /// </summary>
        public dvec3 bgb => new dvec3(z, y, z);
        
        /// <summary>
        /// Returns dvec4.bgbr swizzling.
        /// </summary>
        public dvec4 bgbr => new dvec4(z, y, z, x);
        
        /// <summary>
        /// Returns dvec4.bgbg swizzling.
        /// </summary>
        public dvec4 bgbg => new dvec4(z, y, z, y);
        
        /// <summary>
        /// Returns dvec4.bgbb swizzling.
        /// </summary>
        public dvec4 bgbb => new dvec4(z, y, z, z);
        
        /// <summary>
        /// Returns dvec4.bgba swizzling.
        /// </summary>
        public dvec4 bgba => new dvec4(z, y, z, w);
        
        /// <summary>
        /// Returns dvec4.bga swizzling.
        /// </summary>
        public dvec3 bga => new dvec3(z, y, w);
        
        /// <summary>
        /// Returns dvec4.bgar swizzling.
        /// </summary>
        public dvec4 bgar => new dvec4(z, y, w, x);
        
        /// <summary>
        /// Returns dvec4.bgag swizzling.
        /// </summary>
        public dvec4 bgag => new dvec4(z, y, w, y);
        
        /// <summary>
        /// Returns dvec4.bgab swizzling.
        /// </summary>
        public dvec4 bgab => new dvec4(z, y, w, z);
        
        /// <summary>
        /// Returns dvec4.bgaa swizzling.
        /// </summary>
        public dvec4 bgaa => new dvec4(z, y, w, w);
        
        /// <summary>
        /// Returns dvec4.bb swizzling.
        /// </summary>
        public dvec2 bb => new dvec2(z, z);
        
        /// <summary>
        /// Returns dvec4.bbr swizzling.
        /// </summary>
        public dvec3 bbr => new dvec3(z, z, x);
        
        /// <summary>
        /// Returns dvec4.bbrr swizzling.
        /// </summary>
        public dvec4 bbrr => new dvec4(z, z, x, x);
        
        /// <summary>
        /// Returns dvec4.bbrg swizzling.
        /// </summary>
        public dvec4 bbrg => new dvec4(z, z, x, y);
        
        /// <summary>
        /// Returns dvec4.bbrb swizzling.
        /// </summary>
        public dvec4 bbrb => new dvec4(z, z, x, z);
        
        /// <summary>
        /// Returns dvec4.bbra swizzling.
        /// </summary>
        public dvec4 bbra => new dvec4(z, z, x, w);
        
        /// <summary>
        /// Returns dvec4.bbg swizzling.
        /// </summary>
        public dvec3 bbg => new dvec3(z, z, y);
        
        /// <summary>
        /// Returns dvec4.bbgr swizzling.
        /// </summary>
        public dvec4 bbgr => new dvec4(z, z, y, x);
        
        /// <summary>
        /// Returns dvec4.bbgg swizzling.
        /// </summary>
        public dvec4 bbgg => new dvec4(z, z, y, y);
        
        /// <summary>
        /// Returns dvec4.bbgb swizzling.
        /// </summary>
        public dvec4 bbgb => new dvec4(z, z, y, z);
        
        /// <summary>
        /// Returns dvec4.bbga swizzling.
        /// </summary>
        public dvec4 bbga => new dvec4(z, z, y, w);
        
        /// <summary>
        /// Returns dvec4.bbb swizzling.
        /// </summary>
        public dvec3 bbb => new dvec3(z, z, z);
        
        /// <summary>
        /// Returns dvec4.bbbr swizzling.
        /// </summary>
        public dvec4 bbbr => new dvec4(z, z, z, x);
        
        /// <summary>
        /// Returns dvec4.bbbg swizzling.
        /// </summary>
        public dvec4 bbbg => new dvec4(z, z, z, y);
        
        /// <summary>
        /// Returns dvec4.bbbb swizzling.
        /// </summary>
        public dvec4 bbbb => new dvec4(z, z, z, z);
        
        /// <summary>
        /// Returns dvec4.bbba swizzling.
        /// </summary>
        public dvec4 bbba => new dvec4(z, z, z, w);
        
        /// <summary>
        /// Returns dvec4.bba swizzling.
        /// </summary>
        public dvec3 bba => new dvec3(z, z, w);
        
        /// <summary>
        /// Returns dvec4.bbar swizzling.
        /// </summary>
        public dvec4 bbar => new dvec4(z, z, w, x);
        
        /// <summary>
        /// Returns dvec4.bbag swizzling.
        /// </summary>
        public dvec4 bbag => new dvec4(z, z, w, y);
        
        /// <summary>
        /// Returns dvec4.bbab swizzling.
        /// </summary>
        public dvec4 bbab => new dvec4(z, z, w, z);
        
        /// <summary>
        /// Returns dvec4.bbaa swizzling.
        /// </summary>
        public dvec4 bbaa => new dvec4(z, z, w, w);
        
        /// <summary>
        /// Returns dvec4.ba swizzling.
        /// </summary>
        public dvec2 ba => new dvec2(z, w);
        
        /// <summary>
        /// Returns dvec4.bar swizzling.
        /// </summary>
        public dvec3 bar => new dvec3(z, w, x);
        
        /// <summary>
        /// Returns dvec4.barr swizzling.
        /// </summary>
        public dvec4 barr => new dvec4(z, w, x, x);
        
        /// <summary>
        /// Returns dvec4.barg swizzling.
        /// </summary>
        public dvec4 barg => new dvec4(z, w, x, y);
        
        /// <summary>
        /// Returns dvec4.barb swizzling.
        /// </summary>
        public dvec4 barb => new dvec4(z, w, x, z);
        
        /// <summary>
        /// Returns dvec4.bara swizzling.
        /// </summary>
        public dvec4 bara => new dvec4(z, w, x, w);
        
        /// <summary>
        /// Returns dvec4.bag swizzling.
        /// </summary>
        public dvec3 bag => new dvec3(z, w, y);
        
        /// <summary>
        /// Returns dvec4.bagr swizzling.
        /// </summary>
        public dvec4 bagr => new dvec4(z, w, y, x);
        
        /// <summary>
        /// Returns dvec4.bagg swizzling.
        /// </summary>
        public dvec4 bagg => new dvec4(z, w, y, y);
        
        /// <summary>
        /// Returns dvec4.bagb swizzling.
        /// </summary>
        public dvec4 bagb => new dvec4(z, w, y, z);
        
        /// <summary>
        /// Returns dvec4.baga swizzling.
        /// </summary>
        public dvec4 baga => new dvec4(z, w, y, w);
        
        /// <summary>
        /// Returns dvec4.bab swizzling.
        /// </summary>
        public dvec3 bab => new dvec3(z, w, z);
        
        /// <summary>
        /// Returns dvec4.babr swizzling.
        /// </summary>
        public dvec4 babr => new dvec4(z, w, z, x);
        
        /// <summary>
        /// Returns dvec4.babg swizzling.
        /// </summary>
        public dvec4 babg => new dvec4(z, w, z, y);
        
        /// <summary>
        /// Returns dvec4.babb swizzling.
        /// </summary>
        public dvec4 babb => new dvec4(z, w, z, z);
        
        /// <summary>
        /// Returns dvec4.baba swizzling.
        /// </summary>
        public dvec4 baba => new dvec4(z, w, z, w);
        
        /// <summary>
        /// Returns dvec4.baa swizzling.
        /// </summary>
        public dvec3 baa => new dvec3(z, w, w);
        
        /// <summary>
        /// Returns dvec4.baar swizzling.
        /// </summary>
        public dvec4 baar => new dvec4(z, w, w, x);
        
        /// <summary>
        /// Returns dvec4.baag swizzling.
        /// </summary>
        public dvec4 baag => new dvec4(z, w, w, y);
        
        /// <summary>
        /// Returns dvec4.baab swizzling.
        /// </summary>
        public dvec4 baab => new dvec4(z, w, w, z);
        
        /// <summary>
        /// Returns dvec4.baaa swizzling.
        /// </summary>
        public dvec4 baaa => new dvec4(z, w, w, w);
        
        /// <summary>
        /// Returns dvec4.ar swizzling.
        /// </summary>
        public dvec2 ar => new dvec2(w, x);
        
        /// <summary>
        /// Returns dvec4.arr swizzling.
        /// </summary>
        public dvec3 arr => new dvec3(w, x, x);
        
        /// <summary>
        /// Returns dvec4.arrr swizzling.
        /// </summary>
        public dvec4 arrr => new dvec4(w, x, x, x);
        
        /// <summary>
        /// Returns dvec4.arrg swizzling.
        /// </summary>
        public dvec4 arrg => new dvec4(w, x, x, y);
        
        /// <summary>
        /// Returns dvec4.arrb swizzling.
        /// </summary>
        public dvec4 arrb => new dvec4(w, x, x, z);
        
        /// <summary>
        /// Returns dvec4.arra swizzling.
        /// </summary>
        public dvec4 arra => new dvec4(w, x, x, w);
        
        /// <summary>
        /// Returns dvec4.arg swizzling.
        /// </summary>
        public dvec3 arg => new dvec3(w, x, y);
        
        /// <summary>
        /// Returns dvec4.argr swizzling.
        /// </summary>
        public dvec4 argr => new dvec4(w, x, y, x);
        
        /// <summary>
        /// Returns dvec4.argg swizzling.
        /// </summary>
        public dvec4 argg => new dvec4(w, x, y, y);
        
        /// <summary>
        /// Returns dvec4.argb swizzling.
        /// </summary>
        public dvec4 argb => new dvec4(w, x, y, z);
        
        /// <summary>
        /// Returns dvec4.arga swizzling.
        /// </summary>
        public dvec4 arga => new dvec4(w, x, y, w);
        
        /// <summary>
        /// Returns dvec4.arb swizzling.
        /// </summary>
        public dvec3 arb => new dvec3(w, x, z);
        
        /// <summary>
        /// Returns dvec4.arbr swizzling.
        /// </summary>
        public dvec4 arbr => new dvec4(w, x, z, x);
        
        /// <summary>
        /// Returns dvec4.arbg swizzling.
        /// </summary>
        public dvec4 arbg => new dvec4(w, x, z, y);
        
        /// <summary>
        /// Returns dvec4.arbb swizzling.
        /// </summary>
        public dvec4 arbb => new dvec4(w, x, z, z);
        
        /// <summary>
        /// Returns dvec4.arba swizzling.
        /// </summary>
        public dvec4 arba => new dvec4(w, x, z, w);
        
        /// <summary>
        /// Returns dvec4.ara swizzling.
        /// </summary>
        public dvec3 ara => new dvec3(w, x, w);
        
        /// <summary>
        /// Returns dvec4.arar swizzling.
        /// </summary>
        public dvec4 arar => new dvec4(w, x, w, x);
        
        /// <summary>
        /// Returns dvec4.arag swizzling.
        /// </summary>
        public dvec4 arag => new dvec4(w, x, w, y);
        
        /// <summary>
        /// Returns dvec4.arab swizzling.
        /// </summary>
        public dvec4 arab => new dvec4(w, x, w, z);
        
        /// <summary>
        /// Returns dvec4.araa swizzling.
        /// </summary>
        public dvec4 araa => new dvec4(w, x, w, w);
        
        /// <summary>
        /// Returns dvec4.ag swizzling.
        /// </summary>
        public dvec2 ag => new dvec2(w, y);
        
        /// <summary>
        /// Returns dvec4.agr swizzling.
        /// </summary>
        public dvec3 agr => new dvec3(w, y, x);
        
        /// <summary>
        /// Returns dvec4.agrr swizzling.
        /// </summary>
        public dvec4 agrr => new dvec4(w, y, x, x);
        
        /// <summary>
        /// Returns dvec4.agrg swizzling.
        /// </summary>
        public dvec4 agrg => new dvec4(w, y, x, y);
        
        /// <summary>
        /// Returns dvec4.agrb swizzling.
        /// </summary>
        public dvec4 agrb => new dvec4(w, y, x, z);
        
        /// <summary>
        /// Returns dvec4.agra swizzling.
        /// </summary>
        public dvec4 agra => new dvec4(w, y, x, w);
        
        /// <summary>
        /// Returns dvec4.agg swizzling.
        /// </summary>
        public dvec3 agg => new dvec3(w, y, y);
        
        /// <summary>
        /// Returns dvec4.aggr swizzling.
        /// </summary>
        public dvec4 aggr => new dvec4(w, y, y, x);
        
        /// <summary>
        /// Returns dvec4.aggg swizzling.
        /// </summary>
        public dvec4 aggg => new dvec4(w, y, y, y);
        
        /// <summary>
        /// Returns dvec4.aggb swizzling.
        /// </summary>
        public dvec4 aggb => new dvec4(w, y, y, z);
        
        /// <summary>
        /// Returns dvec4.agga swizzling.
        /// </summary>
        public dvec4 agga => new dvec4(w, y, y, w);
        
        /// <summary>
        /// Returns dvec4.agb swizzling.
        /// </summary>
        public dvec3 agb => new dvec3(w, y, z);
        
        /// <summary>
        /// Returns dvec4.agbr swizzling.
        /// </summary>
        public dvec4 agbr => new dvec4(w, y, z, x);
        
        /// <summary>
        /// Returns dvec4.agbg swizzling.
        /// </summary>
        public dvec4 agbg => new dvec4(w, y, z, y);
        
        /// <summary>
        /// Returns dvec4.agbb swizzling.
        /// </summary>
        public dvec4 agbb => new dvec4(w, y, z, z);
        
        /// <summary>
        /// Returns dvec4.agba swizzling.
        /// </summary>
        public dvec4 agba => new dvec4(w, y, z, w);
        
        /// <summary>
        /// Returns dvec4.aga swizzling.
        /// </summary>
        public dvec3 aga => new dvec3(w, y, w);
        
        /// <summary>
        /// Returns dvec4.agar swizzling.
        /// </summary>
        public dvec4 agar => new dvec4(w, y, w, x);
        
        /// <summary>
        /// Returns dvec4.agag swizzling.
        /// </summary>
        public dvec4 agag => new dvec4(w, y, w, y);
        
        /// <summary>
        /// Returns dvec4.agab swizzling.
        /// </summary>
        public dvec4 agab => new dvec4(w, y, w, z);
        
        /// <summary>
        /// Returns dvec4.agaa swizzling.
        /// </summary>
        public dvec4 agaa => new dvec4(w, y, w, w);
        
        /// <summary>
        /// Returns dvec4.ab swizzling.
        /// </summary>
        public dvec2 ab => new dvec2(w, z);
        
        /// <summary>
        /// Returns dvec4.abr swizzling.
        /// </summary>
        public dvec3 abr => new dvec3(w, z, x);
        
        /// <summary>
        /// Returns dvec4.abrr swizzling.
        /// </summary>
        public dvec4 abrr => new dvec4(w, z, x, x);
        
        /// <summary>
        /// Returns dvec4.abrg swizzling.
        /// </summary>
        public dvec4 abrg => new dvec4(w, z, x, y);
        
        /// <summary>
        /// Returns dvec4.abrb swizzling.
        /// </summary>
        public dvec4 abrb => new dvec4(w, z, x, z);
        
        /// <summary>
        /// Returns dvec4.abra swizzling.
        /// </summary>
        public dvec4 abra => new dvec4(w, z, x, w);
        
        /// <summary>
        /// Returns dvec4.abg swizzling.
        /// </summary>
        public dvec3 abg => new dvec3(w, z, y);
        
        /// <summary>
        /// Returns dvec4.abgr swizzling.
        /// </summary>
        public dvec4 abgr => new dvec4(w, z, y, x);
        
        /// <summary>
        /// Returns dvec4.abgg swizzling.
        /// </summary>
        public dvec4 abgg => new dvec4(w, z, y, y);
        
        /// <summary>
        /// Returns dvec4.abgb swizzling.
        /// </summary>
        public dvec4 abgb => new dvec4(w, z, y, z);
        
        /// <summary>
        /// Returns dvec4.abga swizzling.
        /// </summary>
        public dvec4 abga => new dvec4(w, z, y, w);
        
        /// <summary>
        /// Returns dvec4.abb swizzling.
        /// </summary>
        public dvec3 abb => new dvec3(w, z, z);
        
        /// <summary>
        /// Returns dvec4.abbr swizzling.
        /// </summary>
        public dvec4 abbr => new dvec4(w, z, z, x);
        
        /// <summary>
        /// Returns dvec4.abbg swizzling.
        /// </summary>
        public dvec4 abbg => new dvec4(w, z, z, y);
        
        /// <summary>
        /// Returns dvec4.abbb swizzling.
        /// </summary>
        public dvec4 abbb => new dvec4(w, z, z, z);
        
        /// <summary>
        /// Returns dvec4.abba swizzling.
        /// </summary>
        public dvec4 abba => new dvec4(w, z, z, w);
        
        /// <summary>
        /// Returns dvec4.aba swizzling.
        /// </summary>
        public dvec3 aba => new dvec3(w, z, w);
        
        /// <summary>
        /// Returns dvec4.abar swizzling.
        /// </summary>
        public dvec4 abar => new dvec4(w, z, w, x);
        
        /// <summary>
        /// Returns dvec4.abag swizzling.
        /// </summary>
        public dvec4 abag => new dvec4(w, z, w, y);
        
        /// <summary>
        /// Returns dvec4.abab swizzling.
        /// </summary>
        public dvec4 abab => new dvec4(w, z, w, z);
        
        /// <summary>
        /// Returns dvec4.abaa swizzling.
        /// </summary>
        public dvec4 abaa => new dvec4(w, z, w, w);
        
        /// <summary>
        /// Returns dvec4.aa swizzling.
        /// </summary>
        public dvec2 aa => new dvec2(w, w);
        
        /// <summary>
        /// Returns dvec4.aar swizzling.
        /// </summary>
        public dvec3 aar => new dvec3(w, w, x);
        
        /// <summary>
        /// Returns dvec4.aarr swizzling.
        /// </summary>
        public dvec4 aarr => new dvec4(w, w, x, x);
        
        /// <summary>
        /// Returns dvec4.aarg swizzling.
        /// </summary>
        public dvec4 aarg => new dvec4(w, w, x, y);
        
        /// <summary>
        /// Returns dvec4.aarb swizzling.
        /// </summary>
        public dvec4 aarb => new dvec4(w, w, x, z);
        
        /// <summary>
        /// Returns dvec4.aara swizzling.
        /// </summary>
        public dvec4 aara => new dvec4(w, w, x, w);
        
        /// <summary>
        /// Returns dvec4.aag swizzling.
        /// </summary>
        public dvec3 aag => new dvec3(w, w, y);
        
        /// <summary>
        /// Returns dvec4.aagr swizzling.
        /// </summary>
        public dvec4 aagr => new dvec4(w, w, y, x);
        
        /// <summary>
        /// Returns dvec4.aagg swizzling.
        /// </summary>
        public dvec4 aagg => new dvec4(w, w, y, y);
        
        /// <summary>
        /// Returns dvec4.aagb swizzling.
        /// </summary>
        public dvec4 aagb => new dvec4(w, w, y, z);
        
        /// <summary>
        /// Returns dvec4.aaga swizzling.
        /// </summary>
        public dvec4 aaga => new dvec4(w, w, y, w);
        
        /// <summary>
        /// Returns dvec4.aab swizzling.
        /// </summary>
        public dvec3 aab => new dvec3(w, w, z);
        
        /// <summary>
        /// Returns dvec4.aabr swizzling.
        /// </summary>
        public dvec4 aabr => new dvec4(w, w, z, x);
        
        /// <summary>
        /// Returns dvec4.aabg swizzling.
        /// </summary>
        public dvec4 aabg => new dvec4(w, w, z, y);
        
        /// <summary>
        /// Returns dvec4.aabb swizzling.
        /// </summary>
        public dvec4 aabb => new dvec4(w, w, z, z);
        
        /// <summary>
        /// Returns dvec4.aaba swizzling.
        /// </summary>
        public dvec4 aaba => new dvec4(w, w, z, w);
        
        /// <summary>
        /// Returns dvec4.aaa swizzling.
        /// </summary>
        public dvec3 aaa => new dvec3(w, w, w);
        
        /// <summary>
        /// Returns dvec4.aaar swizzling.
        /// </summary>
        public dvec4 aaar => new dvec4(w, w, w, x);
        
        /// <summary>
        /// Returns dvec4.aaag swizzling.
        /// </summary>
        public dvec4 aaag => new dvec4(w, w, w, y);
        
        /// <summary>
        /// Returns dvec4.aaab swizzling.
        /// </summary>
        public dvec4 aaab => new dvec4(w, w, w, z);
        
        /// <summary>
        /// Returns dvec4.aaaa swizzling.
        /// </summary>
        public dvec4 aaaa => new dvec4(w, w, w, w);
    }
}
