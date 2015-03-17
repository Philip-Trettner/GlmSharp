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
    /// Temporary vector of type long with 4 components, used for implementing swizzling for lvec4.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_lvec4
    {
        
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
        
        // XYZW Versions
        
        /// <summary>
        /// Returns lvec4.xx swizzling.
        /// </summary>
        public lvec2 xx => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec4.xxx swizzling.
        /// </summary>
        public lvec3 xxx => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec4.xxxx swizzling.
        /// </summary>
        public lvec4 xxxx => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.xxxy swizzling.
        /// </summary>
        public lvec4 xxxy => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.xxxz swizzling.
        /// </summary>
        public lvec4 xxxz => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.xxxw swizzling.
        /// </summary>
        public lvec4 xxxw => new lvec4(x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.xxy swizzling.
        /// </summary>
        public lvec3 xxy => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec4.xxyx swizzling.
        /// </summary>
        public lvec4 xxyx => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.xxyy swizzling.
        /// </summary>
        public lvec4 xxyy => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.xxyz swizzling.
        /// </summary>
        public lvec4 xxyz => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.xxyw swizzling.
        /// </summary>
        public lvec4 xxyw => new lvec4(x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.xxz swizzling.
        /// </summary>
        public lvec3 xxz => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec4.xxzx swizzling.
        /// </summary>
        public lvec4 xxzx => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.xxzy swizzling.
        /// </summary>
        public lvec4 xxzy => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.xxzz swizzling.
        /// </summary>
        public lvec4 xxzz => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.xxzw swizzling.
        /// </summary>
        public lvec4 xxzw => new lvec4(x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.xxw swizzling.
        /// </summary>
        public lvec3 xxw => new lvec3(x, x, w);
        
        /// <summary>
        /// Returns lvec4.xxwx swizzling.
        /// </summary>
        public lvec4 xxwx => new lvec4(x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.xxwy swizzling.
        /// </summary>
        public lvec4 xxwy => new lvec4(x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.xxwz swizzling.
        /// </summary>
        public lvec4 xxwz => new lvec4(x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.xxww swizzling.
        /// </summary>
        public lvec4 xxww => new lvec4(x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.xy swizzling.
        /// </summary>
        public lvec2 xy => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec4.xyx swizzling.
        /// </summary>
        public lvec3 xyx => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec4.xyxx swizzling.
        /// </summary>
        public lvec4 xyxx => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.xyxy swizzling.
        /// </summary>
        public lvec4 xyxy => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.xyxz swizzling.
        /// </summary>
        public lvec4 xyxz => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.xyxw swizzling.
        /// </summary>
        public lvec4 xyxw => new lvec4(x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.xyy swizzling.
        /// </summary>
        public lvec3 xyy => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec4.xyyx swizzling.
        /// </summary>
        public lvec4 xyyx => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.xyyy swizzling.
        /// </summary>
        public lvec4 xyyy => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.xyyz swizzling.
        /// </summary>
        public lvec4 xyyz => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.xyyw swizzling.
        /// </summary>
        public lvec4 xyyw => new lvec4(x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.xyz swizzling.
        /// </summary>
        public lvec3 xyz => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec4.xyzx swizzling.
        /// </summary>
        public lvec4 xyzx => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.xyzy swizzling.
        /// </summary>
        public lvec4 xyzy => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.xyzz swizzling.
        /// </summary>
        public lvec4 xyzz => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.xyzw swizzling.
        /// </summary>
        public lvec4 xyzw => new lvec4(x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.xyw swizzling.
        /// </summary>
        public lvec3 xyw => new lvec3(x, y, w);
        
        /// <summary>
        /// Returns lvec4.xywx swizzling.
        /// </summary>
        public lvec4 xywx => new lvec4(x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.xywy swizzling.
        /// </summary>
        public lvec4 xywy => new lvec4(x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.xywz swizzling.
        /// </summary>
        public lvec4 xywz => new lvec4(x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.xyww swizzling.
        /// </summary>
        public lvec4 xyww => new lvec4(x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.xz swizzling.
        /// </summary>
        public lvec2 xz => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec4.xzx swizzling.
        /// </summary>
        public lvec3 xzx => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec4.xzxx swizzling.
        /// </summary>
        public lvec4 xzxx => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.xzxy swizzling.
        /// </summary>
        public lvec4 xzxy => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.xzxz swizzling.
        /// </summary>
        public lvec4 xzxz => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.xzxw swizzling.
        /// </summary>
        public lvec4 xzxw => new lvec4(x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.xzy swizzling.
        /// </summary>
        public lvec3 xzy => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec4.xzyx swizzling.
        /// </summary>
        public lvec4 xzyx => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.xzyy swizzling.
        /// </summary>
        public lvec4 xzyy => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.xzyz swizzling.
        /// </summary>
        public lvec4 xzyz => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.xzyw swizzling.
        /// </summary>
        public lvec4 xzyw => new lvec4(x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.xzz swizzling.
        /// </summary>
        public lvec3 xzz => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec4.xzzx swizzling.
        /// </summary>
        public lvec4 xzzx => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.xzzy swizzling.
        /// </summary>
        public lvec4 xzzy => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.xzzz swizzling.
        /// </summary>
        public lvec4 xzzz => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.xzzw swizzling.
        /// </summary>
        public lvec4 xzzw => new lvec4(x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.xzw swizzling.
        /// </summary>
        public lvec3 xzw => new lvec3(x, z, w);
        
        /// <summary>
        /// Returns lvec4.xzwx swizzling.
        /// </summary>
        public lvec4 xzwx => new lvec4(x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.xzwy swizzling.
        /// </summary>
        public lvec4 xzwy => new lvec4(x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.xzwz swizzling.
        /// </summary>
        public lvec4 xzwz => new lvec4(x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.xzww swizzling.
        /// </summary>
        public lvec4 xzww => new lvec4(x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.xw swizzling.
        /// </summary>
        public lvec2 xw => new lvec2(x, w);
        
        /// <summary>
        /// Returns lvec4.xwx swizzling.
        /// </summary>
        public lvec3 xwx => new lvec3(x, w, x);
        
        /// <summary>
        /// Returns lvec4.xwxx swizzling.
        /// </summary>
        public lvec4 xwxx => new lvec4(x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.xwxy swizzling.
        /// </summary>
        public lvec4 xwxy => new lvec4(x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.xwxz swizzling.
        /// </summary>
        public lvec4 xwxz => new lvec4(x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.xwxw swizzling.
        /// </summary>
        public lvec4 xwxw => new lvec4(x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.xwy swizzling.
        /// </summary>
        public lvec3 xwy => new lvec3(x, w, y);
        
        /// <summary>
        /// Returns lvec4.xwyx swizzling.
        /// </summary>
        public lvec4 xwyx => new lvec4(x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.xwyy swizzling.
        /// </summary>
        public lvec4 xwyy => new lvec4(x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.xwyz swizzling.
        /// </summary>
        public lvec4 xwyz => new lvec4(x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.xwyw swizzling.
        /// </summary>
        public lvec4 xwyw => new lvec4(x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.xwz swizzling.
        /// </summary>
        public lvec3 xwz => new lvec3(x, w, z);
        
        /// <summary>
        /// Returns lvec4.xwzx swizzling.
        /// </summary>
        public lvec4 xwzx => new lvec4(x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.xwzy swizzling.
        /// </summary>
        public lvec4 xwzy => new lvec4(x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.xwzz swizzling.
        /// </summary>
        public lvec4 xwzz => new lvec4(x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.xwzw swizzling.
        /// </summary>
        public lvec4 xwzw => new lvec4(x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.xww swizzling.
        /// </summary>
        public lvec3 xww => new lvec3(x, w, w);
        
        /// <summary>
        /// Returns lvec4.xwwx swizzling.
        /// </summary>
        public lvec4 xwwx => new lvec4(x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.xwwy swizzling.
        /// </summary>
        public lvec4 xwwy => new lvec4(x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.xwwz swizzling.
        /// </summary>
        public lvec4 xwwz => new lvec4(x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.xwww swizzling.
        /// </summary>
        public lvec4 xwww => new lvec4(x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.yx swizzling.
        /// </summary>
        public lvec2 yx => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec4.yxx swizzling.
        /// </summary>
        public lvec3 yxx => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec4.yxxx swizzling.
        /// </summary>
        public lvec4 yxxx => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.yxxy swizzling.
        /// </summary>
        public lvec4 yxxy => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.yxxz swizzling.
        /// </summary>
        public lvec4 yxxz => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.yxxw swizzling.
        /// </summary>
        public lvec4 yxxw => new lvec4(y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.yxy swizzling.
        /// </summary>
        public lvec3 yxy => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec4.yxyx swizzling.
        /// </summary>
        public lvec4 yxyx => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.yxyy swizzling.
        /// </summary>
        public lvec4 yxyy => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.yxyz swizzling.
        /// </summary>
        public lvec4 yxyz => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.yxyw swizzling.
        /// </summary>
        public lvec4 yxyw => new lvec4(y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.yxz swizzling.
        /// </summary>
        public lvec3 yxz => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec4.yxzx swizzling.
        /// </summary>
        public lvec4 yxzx => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.yxzy swizzling.
        /// </summary>
        public lvec4 yxzy => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.yxzz swizzling.
        /// </summary>
        public lvec4 yxzz => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.yxzw swizzling.
        /// </summary>
        public lvec4 yxzw => new lvec4(y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.yxw swizzling.
        /// </summary>
        public lvec3 yxw => new lvec3(y, x, w);
        
        /// <summary>
        /// Returns lvec4.yxwx swizzling.
        /// </summary>
        public lvec4 yxwx => new lvec4(y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.yxwy swizzling.
        /// </summary>
        public lvec4 yxwy => new lvec4(y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.yxwz swizzling.
        /// </summary>
        public lvec4 yxwz => new lvec4(y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.yxww swizzling.
        /// </summary>
        public lvec4 yxww => new lvec4(y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.yy swizzling.
        /// </summary>
        public lvec2 yy => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec4.yyx swizzling.
        /// </summary>
        public lvec3 yyx => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec4.yyxx swizzling.
        /// </summary>
        public lvec4 yyxx => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.yyxy swizzling.
        /// </summary>
        public lvec4 yyxy => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.yyxz swizzling.
        /// </summary>
        public lvec4 yyxz => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.yyxw swizzling.
        /// </summary>
        public lvec4 yyxw => new lvec4(y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.yyy swizzling.
        /// </summary>
        public lvec3 yyy => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec4.yyyx swizzling.
        /// </summary>
        public lvec4 yyyx => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.yyyy swizzling.
        /// </summary>
        public lvec4 yyyy => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.yyyz swizzling.
        /// </summary>
        public lvec4 yyyz => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.yyyw swizzling.
        /// </summary>
        public lvec4 yyyw => new lvec4(y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.yyz swizzling.
        /// </summary>
        public lvec3 yyz => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec4.yyzx swizzling.
        /// </summary>
        public lvec4 yyzx => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.yyzy swizzling.
        /// </summary>
        public lvec4 yyzy => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.yyzz swizzling.
        /// </summary>
        public lvec4 yyzz => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.yyzw swizzling.
        /// </summary>
        public lvec4 yyzw => new lvec4(y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.yyw swizzling.
        /// </summary>
        public lvec3 yyw => new lvec3(y, y, w);
        
        /// <summary>
        /// Returns lvec4.yywx swizzling.
        /// </summary>
        public lvec4 yywx => new lvec4(y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.yywy swizzling.
        /// </summary>
        public lvec4 yywy => new lvec4(y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.yywz swizzling.
        /// </summary>
        public lvec4 yywz => new lvec4(y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.yyww swizzling.
        /// </summary>
        public lvec4 yyww => new lvec4(y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.yz swizzling.
        /// </summary>
        public lvec2 yz => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec4.yzx swizzling.
        /// </summary>
        public lvec3 yzx => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec4.yzxx swizzling.
        /// </summary>
        public lvec4 yzxx => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.yzxy swizzling.
        /// </summary>
        public lvec4 yzxy => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.yzxz swizzling.
        /// </summary>
        public lvec4 yzxz => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.yzxw swizzling.
        /// </summary>
        public lvec4 yzxw => new lvec4(y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.yzy swizzling.
        /// </summary>
        public lvec3 yzy => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec4.yzyx swizzling.
        /// </summary>
        public lvec4 yzyx => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.yzyy swizzling.
        /// </summary>
        public lvec4 yzyy => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.yzyz swizzling.
        /// </summary>
        public lvec4 yzyz => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.yzyw swizzling.
        /// </summary>
        public lvec4 yzyw => new lvec4(y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.yzz swizzling.
        /// </summary>
        public lvec3 yzz => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec4.yzzx swizzling.
        /// </summary>
        public lvec4 yzzx => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.yzzy swizzling.
        /// </summary>
        public lvec4 yzzy => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.yzzz swizzling.
        /// </summary>
        public lvec4 yzzz => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.yzzw swizzling.
        /// </summary>
        public lvec4 yzzw => new lvec4(y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.yzw swizzling.
        /// </summary>
        public lvec3 yzw => new lvec3(y, z, w);
        
        /// <summary>
        /// Returns lvec4.yzwx swizzling.
        /// </summary>
        public lvec4 yzwx => new lvec4(y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.yzwy swizzling.
        /// </summary>
        public lvec4 yzwy => new lvec4(y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.yzwz swizzling.
        /// </summary>
        public lvec4 yzwz => new lvec4(y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.yzww swizzling.
        /// </summary>
        public lvec4 yzww => new lvec4(y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.yw swizzling.
        /// </summary>
        public lvec2 yw => new lvec2(y, w);
        
        /// <summary>
        /// Returns lvec4.ywx swizzling.
        /// </summary>
        public lvec3 ywx => new lvec3(y, w, x);
        
        /// <summary>
        /// Returns lvec4.ywxx swizzling.
        /// </summary>
        public lvec4 ywxx => new lvec4(y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.ywxy swizzling.
        /// </summary>
        public lvec4 ywxy => new lvec4(y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.ywxz swizzling.
        /// </summary>
        public lvec4 ywxz => new lvec4(y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.ywxw swizzling.
        /// </summary>
        public lvec4 ywxw => new lvec4(y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.ywy swizzling.
        /// </summary>
        public lvec3 ywy => new lvec3(y, w, y);
        
        /// <summary>
        /// Returns lvec4.ywyx swizzling.
        /// </summary>
        public lvec4 ywyx => new lvec4(y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.ywyy swizzling.
        /// </summary>
        public lvec4 ywyy => new lvec4(y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.ywyz swizzling.
        /// </summary>
        public lvec4 ywyz => new lvec4(y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.ywyw swizzling.
        /// </summary>
        public lvec4 ywyw => new lvec4(y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.ywz swizzling.
        /// </summary>
        public lvec3 ywz => new lvec3(y, w, z);
        
        /// <summary>
        /// Returns lvec4.ywzx swizzling.
        /// </summary>
        public lvec4 ywzx => new lvec4(y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.ywzy swizzling.
        /// </summary>
        public lvec4 ywzy => new lvec4(y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.ywzz swizzling.
        /// </summary>
        public lvec4 ywzz => new lvec4(y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.ywzw swizzling.
        /// </summary>
        public lvec4 ywzw => new lvec4(y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.yww swizzling.
        /// </summary>
        public lvec3 yww => new lvec3(y, w, w);
        
        /// <summary>
        /// Returns lvec4.ywwx swizzling.
        /// </summary>
        public lvec4 ywwx => new lvec4(y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.ywwy swizzling.
        /// </summary>
        public lvec4 ywwy => new lvec4(y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.ywwz swizzling.
        /// </summary>
        public lvec4 ywwz => new lvec4(y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.ywww swizzling.
        /// </summary>
        public lvec4 ywww => new lvec4(y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.zx swizzling.
        /// </summary>
        public lvec2 zx => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec4.zxx swizzling.
        /// </summary>
        public lvec3 zxx => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec4.zxxx swizzling.
        /// </summary>
        public lvec4 zxxx => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.zxxy swizzling.
        /// </summary>
        public lvec4 zxxy => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.zxxz swizzling.
        /// </summary>
        public lvec4 zxxz => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.zxxw swizzling.
        /// </summary>
        public lvec4 zxxw => new lvec4(z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.zxy swizzling.
        /// </summary>
        public lvec3 zxy => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec4.zxyx swizzling.
        /// </summary>
        public lvec4 zxyx => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.zxyy swizzling.
        /// </summary>
        public lvec4 zxyy => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.zxyz swizzling.
        /// </summary>
        public lvec4 zxyz => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.zxyw swizzling.
        /// </summary>
        public lvec4 zxyw => new lvec4(z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.zxz swizzling.
        /// </summary>
        public lvec3 zxz => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec4.zxzx swizzling.
        /// </summary>
        public lvec4 zxzx => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.zxzy swizzling.
        /// </summary>
        public lvec4 zxzy => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.zxzz swizzling.
        /// </summary>
        public lvec4 zxzz => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.zxzw swizzling.
        /// </summary>
        public lvec4 zxzw => new lvec4(z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.zxw swizzling.
        /// </summary>
        public lvec3 zxw => new lvec3(z, x, w);
        
        /// <summary>
        /// Returns lvec4.zxwx swizzling.
        /// </summary>
        public lvec4 zxwx => new lvec4(z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.zxwy swizzling.
        /// </summary>
        public lvec4 zxwy => new lvec4(z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.zxwz swizzling.
        /// </summary>
        public lvec4 zxwz => new lvec4(z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.zxww swizzling.
        /// </summary>
        public lvec4 zxww => new lvec4(z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.zy swizzling.
        /// </summary>
        public lvec2 zy => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec4.zyx swizzling.
        /// </summary>
        public lvec3 zyx => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec4.zyxx swizzling.
        /// </summary>
        public lvec4 zyxx => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.zyxy swizzling.
        /// </summary>
        public lvec4 zyxy => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.zyxz swizzling.
        /// </summary>
        public lvec4 zyxz => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.zyxw swizzling.
        /// </summary>
        public lvec4 zyxw => new lvec4(z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.zyy swizzling.
        /// </summary>
        public lvec3 zyy => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec4.zyyx swizzling.
        /// </summary>
        public lvec4 zyyx => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.zyyy swizzling.
        /// </summary>
        public lvec4 zyyy => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.zyyz swizzling.
        /// </summary>
        public lvec4 zyyz => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.zyyw swizzling.
        /// </summary>
        public lvec4 zyyw => new lvec4(z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.zyz swizzling.
        /// </summary>
        public lvec3 zyz => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec4.zyzx swizzling.
        /// </summary>
        public lvec4 zyzx => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.zyzy swizzling.
        /// </summary>
        public lvec4 zyzy => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.zyzz swizzling.
        /// </summary>
        public lvec4 zyzz => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.zyzw swizzling.
        /// </summary>
        public lvec4 zyzw => new lvec4(z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.zyw swizzling.
        /// </summary>
        public lvec3 zyw => new lvec3(z, y, w);
        
        /// <summary>
        /// Returns lvec4.zywx swizzling.
        /// </summary>
        public lvec4 zywx => new lvec4(z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.zywy swizzling.
        /// </summary>
        public lvec4 zywy => new lvec4(z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.zywz swizzling.
        /// </summary>
        public lvec4 zywz => new lvec4(z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.zyww swizzling.
        /// </summary>
        public lvec4 zyww => new lvec4(z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.zz swizzling.
        /// </summary>
        public lvec2 zz => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec4.zzx swizzling.
        /// </summary>
        public lvec3 zzx => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec4.zzxx swizzling.
        /// </summary>
        public lvec4 zzxx => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.zzxy swizzling.
        /// </summary>
        public lvec4 zzxy => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.zzxz swizzling.
        /// </summary>
        public lvec4 zzxz => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.zzxw swizzling.
        /// </summary>
        public lvec4 zzxw => new lvec4(z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.zzy swizzling.
        /// </summary>
        public lvec3 zzy => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec4.zzyx swizzling.
        /// </summary>
        public lvec4 zzyx => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.zzyy swizzling.
        /// </summary>
        public lvec4 zzyy => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.zzyz swizzling.
        /// </summary>
        public lvec4 zzyz => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.zzyw swizzling.
        /// </summary>
        public lvec4 zzyw => new lvec4(z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.zzz swizzling.
        /// </summary>
        public lvec3 zzz => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec4.zzzx swizzling.
        /// </summary>
        public lvec4 zzzx => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.zzzy swizzling.
        /// </summary>
        public lvec4 zzzy => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.zzzz swizzling.
        /// </summary>
        public lvec4 zzzz => new lvec4(z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.zzzw swizzling.
        /// </summary>
        public lvec4 zzzw => new lvec4(z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.zzw swizzling.
        /// </summary>
        public lvec3 zzw => new lvec3(z, z, w);
        
        /// <summary>
        /// Returns lvec4.zzwx swizzling.
        /// </summary>
        public lvec4 zzwx => new lvec4(z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.zzwy swizzling.
        /// </summary>
        public lvec4 zzwy => new lvec4(z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.zzwz swizzling.
        /// </summary>
        public lvec4 zzwz => new lvec4(z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.zzww swizzling.
        /// </summary>
        public lvec4 zzww => new lvec4(z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.zw swizzling.
        /// </summary>
        public lvec2 zw => new lvec2(z, w);
        
        /// <summary>
        /// Returns lvec4.zwx swizzling.
        /// </summary>
        public lvec3 zwx => new lvec3(z, w, x);
        
        /// <summary>
        /// Returns lvec4.zwxx swizzling.
        /// </summary>
        public lvec4 zwxx => new lvec4(z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.zwxy swizzling.
        /// </summary>
        public lvec4 zwxy => new lvec4(z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.zwxz swizzling.
        /// </summary>
        public lvec4 zwxz => new lvec4(z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.zwxw swizzling.
        /// </summary>
        public lvec4 zwxw => new lvec4(z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.zwy swizzling.
        /// </summary>
        public lvec3 zwy => new lvec3(z, w, y);
        
        /// <summary>
        /// Returns lvec4.zwyx swizzling.
        /// </summary>
        public lvec4 zwyx => new lvec4(z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.zwyy swizzling.
        /// </summary>
        public lvec4 zwyy => new lvec4(z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.zwyz swizzling.
        /// </summary>
        public lvec4 zwyz => new lvec4(z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.zwyw swizzling.
        /// </summary>
        public lvec4 zwyw => new lvec4(z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.zwz swizzling.
        /// </summary>
        public lvec3 zwz => new lvec3(z, w, z);
        
        /// <summary>
        /// Returns lvec4.zwzx swizzling.
        /// </summary>
        public lvec4 zwzx => new lvec4(z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.zwzy swizzling.
        /// </summary>
        public lvec4 zwzy => new lvec4(z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.zwzz swizzling.
        /// </summary>
        public lvec4 zwzz => new lvec4(z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.zwzw swizzling.
        /// </summary>
        public lvec4 zwzw => new lvec4(z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.zww swizzling.
        /// </summary>
        public lvec3 zww => new lvec3(z, w, w);
        
        /// <summary>
        /// Returns lvec4.zwwx swizzling.
        /// </summary>
        public lvec4 zwwx => new lvec4(z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.zwwy swizzling.
        /// </summary>
        public lvec4 zwwy => new lvec4(z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.zwwz swizzling.
        /// </summary>
        public lvec4 zwwz => new lvec4(z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.zwww swizzling.
        /// </summary>
        public lvec4 zwww => new lvec4(z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.wx swizzling.
        /// </summary>
        public lvec2 wx => new lvec2(w, x);
        
        /// <summary>
        /// Returns lvec4.wxx swizzling.
        /// </summary>
        public lvec3 wxx => new lvec3(w, x, x);
        
        /// <summary>
        /// Returns lvec4.wxxx swizzling.
        /// </summary>
        public lvec4 wxxx => new lvec4(w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.wxxy swizzling.
        /// </summary>
        public lvec4 wxxy => new lvec4(w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.wxxz swizzling.
        /// </summary>
        public lvec4 wxxz => new lvec4(w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.wxxw swizzling.
        /// </summary>
        public lvec4 wxxw => new lvec4(w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.wxy swizzling.
        /// </summary>
        public lvec3 wxy => new lvec3(w, x, y);
        
        /// <summary>
        /// Returns lvec4.wxyx swizzling.
        /// </summary>
        public lvec4 wxyx => new lvec4(w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.wxyy swizzling.
        /// </summary>
        public lvec4 wxyy => new lvec4(w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.wxyz swizzling.
        /// </summary>
        public lvec4 wxyz => new lvec4(w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.wxyw swizzling.
        /// </summary>
        public lvec4 wxyw => new lvec4(w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.wxz swizzling.
        /// </summary>
        public lvec3 wxz => new lvec3(w, x, z);
        
        /// <summary>
        /// Returns lvec4.wxzx swizzling.
        /// </summary>
        public lvec4 wxzx => new lvec4(w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.wxzy swizzling.
        /// </summary>
        public lvec4 wxzy => new lvec4(w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.wxzz swizzling.
        /// </summary>
        public lvec4 wxzz => new lvec4(w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.wxzw swizzling.
        /// </summary>
        public lvec4 wxzw => new lvec4(w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.wxw swizzling.
        /// </summary>
        public lvec3 wxw => new lvec3(w, x, w);
        
        /// <summary>
        /// Returns lvec4.wxwx swizzling.
        /// </summary>
        public lvec4 wxwx => new lvec4(w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.wxwy swizzling.
        /// </summary>
        public lvec4 wxwy => new lvec4(w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.wxwz swizzling.
        /// </summary>
        public lvec4 wxwz => new lvec4(w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.wxww swizzling.
        /// </summary>
        public lvec4 wxww => new lvec4(w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.wy swizzling.
        /// </summary>
        public lvec2 wy => new lvec2(w, y);
        
        /// <summary>
        /// Returns lvec4.wyx swizzling.
        /// </summary>
        public lvec3 wyx => new lvec3(w, y, x);
        
        /// <summary>
        /// Returns lvec4.wyxx swizzling.
        /// </summary>
        public lvec4 wyxx => new lvec4(w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.wyxy swizzling.
        /// </summary>
        public lvec4 wyxy => new lvec4(w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.wyxz swizzling.
        /// </summary>
        public lvec4 wyxz => new lvec4(w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.wyxw swizzling.
        /// </summary>
        public lvec4 wyxw => new lvec4(w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.wyy swizzling.
        /// </summary>
        public lvec3 wyy => new lvec3(w, y, y);
        
        /// <summary>
        /// Returns lvec4.wyyx swizzling.
        /// </summary>
        public lvec4 wyyx => new lvec4(w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.wyyy swizzling.
        /// </summary>
        public lvec4 wyyy => new lvec4(w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.wyyz swizzling.
        /// </summary>
        public lvec4 wyyz => new lvec4(w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.wyyw swizzling.
        /// </summary>
        public lvec4 wyyw => new lvec4(w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.wyz swizzling.
        /// </summary>
        public lvec3 wyz => new lvec3(w, y, z);
        
        /// <summary>
        /// Returns lvec4.wyzx swizzling.
        /// </summary>
        public lvec4 wyzx => new lvec4(w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.wyzy swizzling.
        /// </summary>
        public lvec4 wyzy => new lvec4(w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.wyzz swizzling.
        /// </summary>
        public lvec4 wyzz => new lvec4(w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.wyzw swizzling.
        /// </summary>
        public lvec4 wyzw => new lvec4(w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.wyw swizzling.
        /// </summary>
        public lvec3 wyw => new lvec3(w, y, w);
        
        /// <summary>
        /// Returns lvec4.wywx swizzling.
        /// </summary>
        public lvec4 wywx => new lvec4(w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.wywy swizzling.
        /// </summary>
        public lvec4 wywy => new lvec4(w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.wywz swizzling.
        /// </summary>
        public lvec4 wywz => new lvec4(w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.wyww swizzling.
        /// </summary>
        public lvec4 wyww => new lvec4(w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.wz swizzling.
        /// </summary>
        public lvec2 wz => new lvec2(w, z);
        
        /// <summary>
        /// Returns lvec4.wzx swizzling.
        /// </summary>
        public lvec3 wzx => new lvec3(w, z, x);
        
        /// <summary>
        /// Returns lvec4.wzxx swizzling.
        /// </summary>
        public lvec4 wzxx => new lvec4(w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.wzxy swizzling.
        /// </summary>
        public lvec4 wzxy => new lvec4(w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.wzxz swizzling.
        /// </summary>
        public lvec4 wzxz => new lvec4(w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.wzxw swizzling.
        /// </summary>
        public lvec4 wzxw => new lvec4(w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.wzy swizzling.
        /// </summary>
        public lvec3 wzy => new lvec3(w, z, y);
        
        /// <summary>
        /// Returns lvec4.wzyx swizzling.
        /// </summary>
        public lvec4 wzyx => new lvec4(w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.wzyy swizzling.
        /// </summary>
        public lvec4 wzyy => new lvec4(w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.wzyz swizzling.
        /// </summary>
        public lvec4 wzyz => new lvec4(w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.wzyw swizzling.
        /// </summary>
        public lvec4 wzyw => new lvec4(w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.wzz swizzling.
        /// </summary>
        public lvec3 wzz => new lvec3(w, z, z);
        
        /// <summary>
        /// Returns lvec4.wzzx swizzling.
        /// </summary>
        public lvec4 wzzx => new lvec4(w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.wzzy swizzling.
        /// </summary>
        public lvec4 wzzy => new lvec4(w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.wzzz swizzling.
        /// </summary>
        public lvec4 wzzz => new lvec4(w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.wzzw swizzling.
        /// </summary>
        public lvec4 wzzw => new lvec4(w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.wzw swizzling.
        /// </summary>
        public lvec3 wzw => new lvec3(w, z, w);
        
        /// <summary>
        /// Returns lvec4.wzwx swizzling.
        /// </summary>
        public lvec4 wzwx => new lvec4(w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.wzwy swizzling.
        /// </summary>
        public lvec4 wzwy => new lvec4(w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.wzwz swizzling.
        /// </summary>
        public lvec4 wzwz => new lvec4(w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.wzww swizzling.
        /// </summary>
        public lvec4 wzww => new lvec4(w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.ww swizzling.
        /// </summary>
        public lvec2 ww => new lvec2(w, w);
        
        /// <summary>
        /// Returns lvec4.wwx swizzling.
        /// </summary>
        public lvec3 wwx => new lvec3(w, w, x);
        
        /// <summary>
        /// Returns lvec4.wwxx swizzling.
        /// </summary>
        public lvec4 wwxx => new lvec4(w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.wwxy swizzling.
        /// </summary>
        public lvec4 wwxy => new lvec4(w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.wwxz swizzling.
        /// </summary>
        public lvec4 wwxz => new lvec4(w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.wwxw swizzling.
        /// </summary>
        public lvec4 wwxw => new lvec4(w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.wwy swizzling.
        /// </summary>
        public lvec3 wwy => new lvec3(w, w, y);
        
        /// <summary>
        /// Returns lvec4.wwyx swizzling.
        /// </summary>
        public lvec4 wwyx => new lvec4(w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.wwyy swizzling.
        /// </summary>
        public lvec4 wwyy => new lvec4(w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.wwyz swizzling.
        /// </summary>
        public lvec4 wwyz => new lvec4(w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.wwyw swizzling.
        /// </summary>
        public lvec4 wwyw => new lvec4(w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.wwz swizzling.
        /// </summary>
        public lvec3 wwz => new lvec3(w, w, z);
        
        /// <summary>
        /// Returns lvec4.wwzx swizzling.
        /// </summary>
        public lvec4 wwzx => new lvec4(w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.wwzy swizzling.
        /// </summary>
        public lvec4 wwzy => new lvec4(w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.wwzz swizzling.
        /// </summary>
        public lvec4 wwzz => new lvec4(w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.wwzw swizzling.
        /// </summary>
        public lvec4 wwzw => new lvec4(w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.www swizzling.
        /// </summary>
        public lvec3 www => new lvec3(w, w, w);
        
        /// <summary>
        /// Returns lvec4.wwwx swizzling.
        /// </summary>
        public lvec4 wwwx => new lvec4(w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.wwwy swizzling.
        /// </summary>
        public lvec4 wwwy => new lvec4(w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.wwwz swizzling.
        /// </summary>
        public lvec4 wwwz => new lvec4(w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.wwww swizzling.
        /// </summary>
        public lvec4 wwww => new lvec4(w, w, w, w);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns lvec4.rr swizzling.
        /// </summary>
        public lvec2 rr => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec4.rrr swizzling.
        /// </summary>
        public lvec3 rrr => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec4.rrrr swizzling.
        /// </summary>
        public lvec4 rrrr => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec4.rrrg swizzling.
        /// </summary>
        public lvec4 rrrg => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec4.rrrb swizzling.
        /// </summary>
        public lvec4 rrrb => new lvec4(x, x, x, z);
        
        /// <summary>
        /// Returns lvec4.rrra swizzling.
        /// </summary>
        public lvec4 rrra => new lvec4(x, x, x, w);
        
        /// <summary>
        /// Returns lvec4.rrg swizzling.
        /// </summary>
        public lvec3 rrg => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec4.rrgr swizzling.
        /// </summary>
        public lvec4 rrgr => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec4.rrgg swizzling.
        /// </summary>
        public lvec4 rrgg => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec4.rrgb swizzling.
        /// </summary>
        public lvec4 rrgb => new lvec4(x, x, y, z);
        
        /// <summary>
        /// Returns lvec4.rrga swizzling.
        /// </summary>
        public lvec4 rrga => new lvec4(x, x, y, w);
        
        /// <summary>
        /// Returns lvec4.rrb swizzling.
        /// </summary>
        public lvec3 rrb => new lvec3(x, x, z);
        
        /// <summary>
        /// Returns lvec4.rrbr swizzling.
        /// </summary>
        public lvec4 rrbr => new lvec4(x, x, z, x);
        
        /// <summary>
        /// Returns lvec4.rrbg swizzling.
        /// </summary>
        public lvec4 rrbg => new lvec4(x, x, z, y);
        
        /// <summary>
        /// Returns lvec4.rrbb swizzling.
        /// </summary>
        public lvec4 rrbb => new lvec4(x, x, z, z);
        
        /// <summary>
        /// Returns lvec4.rrba swizzling.
        /// </summary>
        public lvec4 rrba => new lvec4(x, x, z, w);
        
        /// <summary>
        /// Returns lvec4.rra swizzling.
        /// </summary>
        public lvec3 rra => new lvec3(x, x, w);
        
        /// <summary>
        /// Returns lvec4.rrar swizzling.
        /// </summary>
        public lvec4 rrar => new lvec4(x, x, w, x);
        
        /// <summary>
        /// Returns lvec4.rrag swizzling.
        /// </summary>
        public lvec4 rrag => new lvec4(x, x, w, y);
        
        /// <summary>
        /// Returns lvec4.rrab swizzling.
        /// </summary>
        public lvec4 rrab => new lvec4(x, x, w, z);
        
        /// <summary>
        /// Returns lvec4.rraa swizzling.
        /// </summary>
        public lvec4 rraa => new lvec4(x, x, w, w);
        
        /// <summary>
        /// Returns lvec4.rg swizzling.
        /// </summary>
        public lvec2 rg => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec4.rgr swizzling.
        /// </summary>
        public lvec3 rgr => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec4.rgrr swizzling.
        /// </summary>
        public lvec4 rgrr => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec4.rgrg swizzling.
        /// </summary>
        public lvec4 rgrg => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec4.rgrb swizzling.
        /// </summary>
        public lvec4 rgrb => new lvec4(x, y, x, z);
        
        /// <summary>
        /// Returns lvec4.rgra swizzling.
        /// </summary>
        public lvec4 rgra => new lvec4(x, y, x, w);
        
        /// <summary>
        /// Returns lvec4.rgg swizzling.
        /// </summary>
        public lvec3 rgg => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec4.rggr swizzling.
        /// </summary>
        public lvec4 rggr => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec4.rggg swizzling.
        /// </summary>
        public lvec4 rggg => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec4.rggb swizzling.
        /// </summary>
        public lvec4 rggb => new lvec4(x, y, y, z);
        
        /// <summary>
        /// Returns lvec4.rgga swizzling.
        /// </summary>
        public lvec4 rgga => new lvec4(x, y, y, w);
        
        /// <summary>
        /// Returns lvec4.rgb swizzling.
        /// </summary>
        public lvec3 rgb => new lvec3(x, y, z);
        
        /// <summary>
        /// Returns lvec4.rgbr swizzling.
        /// </summary>
        public lvec4 rgbr => new lvec4(x, y, z, x);
        
        /// <summary>
        /// Returns lvec4.rgbg swizzling.
        /// </summary>
        public lvec4 rgbg => new lvec4(x, y, z, y);
        
        /// <summary>
        /// Returns lvec4.rgbb swizzling.
        /// </summary>
        public lvec4 rgbb => new lvec4(x, y, z, z);
        
        /// <summary>
        /// Returns lvec4.rgba swizzling.
        /// </summary>
        public lvec4 rgba => new lvec4(x, y, z, w);
        
        /// <summary>
        /// Returns lvec4.rga swizzling.
        /// </summary>
        public lvec3 rga => new lvec3(x, y, w);
        
        /// <summary>
        /// Returns lvec4.rgar swizzling.
        /// </summary>
        public lvec4 rgar => new lvec4(x, y, w, x);
        
        /// <summary>
        /// Returns lvec4.rgag swizzling.
        /// </summary>
        public lvec4 rgag => new lvec4(x, y, w, y);
        
        /// <summary>
        /// Returns lvec4.rgab swizzling.
        /// </summary>
        public lvec4 rgab => new lvec4(x, y, w, z);
        
        /// <summary>
        /// Returns lvec4.rgaa swizzling.
        /// </summary>
        public lvec4 rgaa => new lvec4(x, y, w, w);
        
        /// <summary>
        /// Returns lvec4.rb swizzling.
        /// </summary>
        public lvec2 rb => new lvec2(x, z);
        
        /// <summary>
        /// Returns lvec4.rbr swizzling.
        /// </summary>
        public lvec3 rbr => new lvec3(x, z, x);
        
        /// <summary>
        /// Returns lvec4.rbrr swizzling.
        /// </summary>
        public lvec4 rbrr => new lvec4(x, z, x, x);
        
        /// <summary>
        /// Returns lvec4.rbrg swizzling.
        /// </summary>
        public lvec4 rbrg => new lvec4(x, z, x, y);
        
        /// <summary>
        /// Returns lvec4.rbrb swizzling.
        /// </summary>
        public lvec4 rbrb => new lvec4(x, z, x, z);
        
        /// <summary>
        /// Returns lvec4.rbra swizzling.
        /// </summary>
        public lvec4 rbra => new lvec4(x, z, x, w);
        
        /// <summary>
        /// Returns lvec4.rbg swizzling.
        /// </summary>
        public lvec3 rbg => new lvec3(x, z, y);
        
        /// <summary>
        /// Returns lvec4.rbgr swizzling.
        /// </summary>
        public lvec4 rbgr => new lvec4(x, z, y, x);
        
        /// <summary>
        /// Returns lvec4.rbgg swizzling.
        /// </summary>
        public lvec4 rbgg => new lvec4(x, z, y, y);
        
        /// <summary>
        /// Returns lvec4.rbgb swizzling.
        /// </summary>
        public lvec4 rbgb => new lvec4(x, z, y, z);
        
        /// <summary>
        /// Returns lvec4.rbga swizzling.
        /// </summary>
        public lvec4 rbga => new lvec4(x, z, y, w);
        
        /// <summary>
        /// Returns lvec4.rbb swizzling.
        /// </summary>
        public lvec3 rbb => new lvec3(x, z, z);
        
        /// <summary>
        /// Returns lvec4.rbbr swizzling.
        /// </summary>
        public lvec4 rbbr => new lvec4(x, z, z, x);
        
        /// <summary>
        /// Returns lvec4.rbbg swizzling.
        /// </summary>
        public lvec4 rbbg => new lvec4(x, z, z, y);
        
        /// <summary>
        /// Returns lvec4.rbbb swizzling.
        /// </summary>
        public lvec4 rbbb => new lvec4(x, z, z, z);
        
        /// <summary>
        /// Returns lvec4.rbba swizzling.
        /// </summary>
        public lvec4 rbba => new lvec4(x, z, z, w);
        
        /// <summary>
        /// Returns lvec4.rba swizzling.
        /// </summary>
        public lvec3 rba => new lvec3(x, z, w);
        
        /// <summary>
        /// Returns lvec4.rbar swizzling.
        /// </summary>
        public lvec4 rbar => new lvec4(x, z, w, x);
        
        /// <summary>
        /// Returns lvec4.rbag swizzling.
        /// </summary>
        public lvec4 rbag => new lvec4(x, z, w, y);
        
        /// <summary>
        /// Returns lvec4.rbab swizzling.
        /// </summary>
        public lvec4 rbab => new lvec4(x, z, w, z);
        
        /// <summary>
        /// Returns lvec4.rbaa swizzling.
        /// </summary>
        public lvec4 rbaa => new lvec4(x, z, w, w);
        
        /// <summary>
        /// Returns lvec4.ra swizzling.
        /// </summary>
        public lvec2 ra => new lvec2(x, w);
        
        /// <summary>
        /// Returns lvec4.rar swizzling.
        /// </summary>
        public lvec3 rar => new lvec3(x, w, x);
        
        /// <summary>
        /// Returns lvec4.rarr swizzling.
        /// </summary>
        public lvec4 rarr => new lvec4(x, w, x, x);
        
        /// <summary>
        /// Returns lvec4.rarg swizzling.
        /// </summary>
        public lvec4 rarg => new lvec4(x, w, x, y);
        
        /// <summary>
        /// Returns lvec4.rarb swizzling.
        /// </summary>
        public lvec4 rarb => new lvec4(x, w, x, z);
        
        /// <summary>
        /// Returns lvec4.rara swizzling.
        /// </summary>
        public lvec4 rara => new lvec4(x, w, x, w);
        
        /// <summary>
        /// Returns lvec4.rag swizzling.
        /// </summary>
        public lvec3 rag => new lvec3(x, w, y);
        
        /// <summary>
        /// Returns lvec4.ragr swizzling.
        /// </summary>
        public lvec4 ragr => new lvec4(x, w, y, x);
        
        /// <summary>
        /// Returns lvec4.ragg swizzling.
        /// </summary>
        public lvec4 ragg => new lvec4(x, w, y, y);
        
        /// <summary>
        /// Returns lvec4.ragb swizzling.
        /// </summary>
        public lvec4 ragb => new lvec4(x, w, y, z);
        
        /// <summary>
        /// Returns lvec4.raga swizzling.
        /// </summary>
        public lvec4 raga => new lvec4(x, w, y, w);
        
        /// <summary>
        /// Returns lvec4.rab swizzling.
        /// </summary>
        public lvec3 rab => new lvec3(x, w, z);
        
        /// <summary>
        /// Returns lvec4.rabr swizzling.
        /// </summary>
        public lvec4 rabr => new lvec4(x, w, z, x);
        
        /// <summary>
        /// Returns lvec4.rabg swizzling.
        /// </summary>
        public lvec4 rabg => new lvec4(x, w, z, y);
        
        /// <summary>
        /// Returns lvec4.rabb swizzling.
        /// </summary>
        public lvec4 rabb => new lvec4(x, w, z, z);
        
        /// <summary>
        /// Returns lvec4.raba swizzling.
        /// </summary>
        public lvec4 raba => new lvec4(x, w, z, w);
        
        /// <summary>
        /// Returns lvec4.raa swizzling.
        /// </summary>
        public lvec3 raa => new lvec3(x, w, w);
        
        /// <summary>
        /// Returns lvec4.raar swizzling.
        /// </summary>
        public lvec4 raar => new lvec4(x, w, w, x);
        
        /// <summary>
        /// Returns lvec4.raag swizzling.
        /// </summary>
        public lvec4 raag => new lvec4(x, w, w, y);
        
        /// <summary>
        /// Returns lvec4.raab swizzling.
        /// </summary>
        public lvec4 raab => new lvec4(x, w, w, z);
        
        /// <summary>
        /// Returns lvec4.raaa swizzling.
        /// </summary>
        public lvec4 raaa => new lvec4(x, w, w, w);
        
        /// <summary>
        /// Returns lvec4.gr swizzling.
        /// </summary>
        public lvec2 gr => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec4.grr swizzling.
        /// </summary>
        public lvec3 grr => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec4.grrr swizzling.
        /// </summary>
        public lvec4 grrr => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec4.grrg swizzling.
        /// </summary>
        public lvec4 grrg => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec4.grrb swizzling.
        /// </summary>
        public lvec4 grrb => new lvec4(y, x, x, z);
        
        /// <summary>
        /// Returns lvec4.grra swizzling.
        /// </summary>
        public lvec4 grra => new lvec4(y, x, x, w);
        
        /// <summary>
        /// Returns lvec4.grg swizzling.
        /// </summary>
        public lvec3 grg => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec4.grgr swizzling.
        /// </summary>
        public lvec4 grgr => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec4.grgg swizzling.
        /// </summary>
        public lvec4 grgg => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec4.grgb swizzling.
        /// </summary>
        public lvec4 grgb => new lvec4(y, x, y, z);
        
        /// <summary>
        /// Returns lvec4.grga swizzling.
        /// </summary>
        public lvec4 grga => new lvec4(y, x, y, w);
        
        /// <summary>
        /// Returns lvec4.grb swizzling.
        /// </summary>
        public lvec3 grb => new lvec3(y, x, z);
        
        /// <summary>
        /// Returns lvec4.grbr swizzling.
        /// </summary>
        public lvec4 grbr => new lvec4(y, x, z, x);
        
        /// <summary>
        /// Returns lvec4.grbg swizzling.
        /// </summary>
        public lvec4 grbg => new lvec4(y, x, z, y);
        
        /// <summary>
        /// Returns lvec4.grbb swizzling.
        /// </summary>
        public lvec4 grbb => new lvec4(y, x, z, z);
        
        /// <summary>
        /// Returns lvec4.grba swizzling.
        /// </summary>
        public lvec4 grba => new lvec4(y, x, z, w);
        
        /// <summary>
        /// Returns lvec4.gra swizzling.
        /// </summary>
        public lvec3 gra => new lvec3(y, x, w);
        
        /// <summary>
        /// Returns lvec4.grar swizzling.
        /// </summary>
        public lvec4 grar => new lvec4(y, x, w, x);
        
        /// <summary>
        /// Returns lvec4.grag swizzling.
        /// </summary>
        public lvec4 grag => new lvec4(y, x, w, y);
        
        /// <summary>
        /// Returns lvec4.grab swizzling.
        /// </summary>
        public lvec4 grab => new lvec4(y, x, w, z);
        
        /// <summary>
        /// Returns lvec4.graa swizzling.
        /// </summary>
        public lvec4 graa => new lvec4(y, x, w, w);
        
        /// <summary>
        /// Returns lvec4.gg swizzling.
        /// </summary>
        public lvec2 gg => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec4.ggr swizzling.
        /// </summary>
        public lvec3 ggr => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec4.ggrr swizzling.
        /// </summary>
        public lvec4 ggrr => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec4.ggrg swizzling.
        /// </summary>
        public lvec4 ggrg => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec4.ggrb swizzling.
        /// </summary>
        public lvec4 ggrb => new lvec4(y, y, x, z);
        
        /// <summary>
        /// Returns lvec4.ggra swizzling.
        /// </summary>
        public lvec4 ggra => new lvec4(y, y, x, w);
        
        /// <summary>
        /// Returns lvec4.ggg swizzling.
        /// </summary>
        public lvec3 ggg => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec4.gggr swizzling.
        /// </summary>
        public lvec4 gggr => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec4.gggg swizzling.
        /// </summary>
        public lvec4 gggg => new lvec4(y, y, y, y);
        
        /// <summary>
        /// Returns lvec4.gggb swizzling.
        /// </summary>
        public lvec4 gggb => new lvec4(y, y, y, z);
        
        /// <summary>
        /// Returns lvec4.ggga swizzling.
        /// </summary>
        public lvec4 ggga => new lvec4(y, y, y, w);
        
        /// <summary>
        /// Returns lvec4.ggb swizzling.
        /// </summary>
        public lvec3 ggb => new lvec3(y, y, z);
        
        /// <summary>
        /// Returns lvec4.ggbr swizzling.
        /// </summary>
        public lvec4 ggbr => new lvec4(y, y, z, x);
        
        /// <summary>
        /// Returns lvec4.ggbg swizzling.
        /// </summary>
        public lvec4 ggbg => new lvec4(y, y, z, y);
        
        /// <summary>
        /// Returns lvec4.ggbb swizzling.
        /// </summary>
        public lvec4 ggbb => new lvec4(y, y, z, z);
        
        /// <summary>
        /// Returns lvec4.ggba swizzling.
        /// </summary>
        public lvec4 ggba => new lvec4(y, y, z, w);
        
        /// <summary>
        /// Returns lvec4.gga swizzling.
        /// </summary>
        public lvec3 gga => new lvec3(y, y, w);
        
        /// <summary>
        /// Returns lvec4.ggar swizzling.
        /// </summary>
        public lvec4 ggar => new lvec4(y, y, w, x);
        
        /// <summary>
        /// Returns lvec4.ggag swizzling.
        /// </summary>
        public lvec4 ggag => new lvec4(y, y, w, y);
        
        /// <summary>
        /// Returns lvec4.ggab swizzling.
        /// </summary>
        public lvec4 ggab => new lvec4(y, y, w, z);
        
        /// <summary>
        /// Returns lvec4.ggaa swizzling.
        /// </summary>
        public lvec4 ggaa => new lvec4(y, y, w, w);
        
        /// <summary>
        /// Returns lvec4.gb swizzling.
        /// </summary>
        public lvec2 gb => new lvec2(y, z);
        
        /// <summary>
        /// Returns lvec4.gbr swizzling.
        /// </summary>
        public lvec3 gbr => new lvec3(y, z, x);
        
        /// <summary>
        /// Returns lvec4.gbrr swizzling.
        /// </summary>
        public lvec4 gbrr => new lvec4(y, z, x, x);
        
        /// <summary>
        /// Returns lvec4.gbrg swizzling.
        /// </summary>
        public lvec4 gbrg => new lvec4(y, z, x, y);
        
        /// <summary>
        /// Returns lvec4.gbrb swizzling.
        /// </summary>
        public lvec4 gbrb => new lvec4(y, z, x, z);
        
        /// <summary>
        /// Returns lvec4.gbra swizzling.
        /// </summary>
        public lvec4 gbra => new lvec4(y, z, x, w);
        
        /// <summary>
        /// Returns lvec4.gbg swizzling.
        /// </summary>
        public lvec3 gbg => new lvec3(y, z, y);
        
        /// <summary>
        /// Returns lvec4.gbgr swizzling.
        /// </summary>
        public lvec4 gbgr => new lvec4(y, z, y, x);
        
        /// <summary>
        /// Returns lvec4.gbgg swizzling.
        /// </summary>
        public lvec4 gbgg => new lvec4(y, z, y, y);
        
        /// <summary>
        /// Returns lvec4.gbgb swizzling.
        /// </summary>
        public lvec4 gbgb => new lvec4(y, z, y, z);
        
        /// <summary>
        /// Returns lvec4.gbga swizzling.
        /// </summary>
        public lvec4 gbga => new lvec4(y, z, y, w);
        
        /// <summary>
        /// Returns lvec4.gbb swizzling.
        /// </summary>
        public lvec3 gbb => new lvec3(y, z, z);
        
        /// <summary>
        /// Returns lvec4.gbbr swizzling.
        /// </summary>
        public lvec4 gbbr => new lvec4(y, z, z, x);
        
        /// <summary>
        /// Returns lvec4.gbbg swizzling.
        /// </summary>
        public lvec4 gbbg => new lvec4(y, z, z, y);
        
        /// <summary>
        /// Returns lvec4.gbbb swizzling.
        /// </summary>
        public lvec4 gbbb => new lvec4(y, z, z, z);
        
        /// <summary>
        /// Returns lvec4.gbba swizzling.
        /// </summary>
        public lvec4 gbba => new lvec4(y, z, z, w);
        
        /// <summary>
        /// Returns lvec4.gba swizzling.
        /// </summary>
        public lvec3 gba => new lvec3(y, z, w);
        
        /// <summary>
        /// Returns lvec4.gbar swizzling.
        /// </summary>
        public lvec4 gbar => new lvec4(y, z, w, x);
        
        /// <summary>
        /// Returns lvec4.gbag swizzling.
        /// </summary>
        public lvec4 gbag => new lvec4(y, z, w, y);
        
        /// <summary>
        /// Returns lvec4.gbab swizzling.
        /// </summary>
        public lvec4 gbab => new lvec4(y, z, w, z);
        
        /// <summary>
        /// Returns lvec4.gbaa swizzling.
        /// </summary>
        public lvec4 gbaa => new lvec4(y, z, w, w);
        
        /// <summary>
        /// Returns lvec4.ga swizzling.
        /// </summary>
        public lvec2 ga => new lvec2(y, w);
        
        /// <summary>
        /// Returns lvec4.gar swizzling.
        /// </summary>
        public lvec3 gar => new lvec3(y, w, x);
        
        /// <summary>
        /// Returns lvec4.garr swizzling.
        /// </summary>
        public lvec4 garr => new lvec4(y, w, x, x);
        
        /// <summary>
        /// Returns lvec4.garg swizzling.
        /// </summary>
        public lvec4 garg => new lvec4(y, w, x, y);
        
        /// <summary>
        /// Returns lvec4.garb swizzling.
        /// </summary>
        public lvec4 garb => new lvec4(y, w, x, z);
        
        /// <summary>
        /// Returns lvec4.gara swizzling.
        /// </summary>
        public lvec4 gara => new lvec4(y, w, x, w);
        
        /// <summary>
        /// Returns lvec4.gag swizzling.
        /// </summary>
        public lvec3 gag => new lvec3(y, w, y);
        
        /// <summary>
        /// Returns lvec4.gagr swizzling.
        /// </summary>
        public lvec4 gagr => new lvec4(y, w, y, x);
        
        /// <summary>
        /// Returns lvec4.gagg swizzling.
        /// </summary>
        public lvec4 gagg => new lvec4(y, w, y, y);
        
        /// <summary>
        /// Returns lvec4.gagb swizzling.
        /// </summary>
        public lvec4 gagb => new lvec4(y, w, y, z);
        
        /// <summary>
        /// Returns lvec4.gaga swizzling.
        /// </summary>
        public lvec4 gaga => new lvec4(y, w, y, w);
        
        /// <summary>
        /// Returns lvec4.gab swizzling.
        /// </summary>
        public lvec3 gab => new lvec3(y, w, z);
        
        /// <summary>
        /// Returns lvec4.gabr swizzling.
        /// </summary>
        public lvec4 gabr => new lvec4(y, w, z, x);
        
        /// <summary>
        /// Returns lvec4.gabg swizzling.
        /// </summary>
        public lvec4 gabg => new lvec4(y, w, z, y);
        
        /// <summary>
        /// Returns lvec4.gabb swizzling.
        /// </summary>
        public lvec4 gabb => new lvec4(y, w, z, z);
        
        /// <summary>
        /// Returns lvec4.gaba swizzling.
        /// </summary>
        public lvec4 gaba => new lvec4(y, w, z, w);
        
        /// <summary>
        /// Returns lvec4.gaa swizzling.
        /// </summary>
        public lvec3 gaa => new lvec3(y, w, w);
        
        /// <summary>
        /// Returns lvec4.gaar swizzling.
        /// </summary>
        public lvec4 gaar => new lvec4(y, w, w, x);
        
        /// <summary>
        /// Returns lvec4.gaag swizzling.
        /// </summary>
        public lvec4 gaag => new lvec4(y, w, w, y);
        
        /// <summary>
        /// Returns lvec4.gaab swizzling.
        /// </summary>
        public lvec4 gaab => new lvec4(y, w, w, z);
        
        /// <summary>
        /// Returns lvec4.gaaa swizzling.
        /// </summary>
        public lvec4 gaaa => new lvec4(y, w, w, w);
        
        /// <summary>
        /// Returns lvec4.br swizzling.
        /// </summary>
        public lvec2 br => new lvec2(z, x);
        
        /// <summary>
        /// Returns lvec4.brr swizzling.
        /// </summary>
        public lvec3 brr => new lvec3(z, x, x);
        
        /// <summary>
        /// Returns lvec4.brrr swizzling.
        /// </summary>
        public lvec4 brrr => new lvec4(z, x, x, x);
        
        /// <summary>
        /// Returns lvec4.brrg swizzling.
        /// </summary>
        public lvec4 brrg => new lvec4(z, x, x, y);
        
        /// <summary>
        /// Returns lvec4.brrb swizzling.
        /// </summary>
        public lvec4 brrb => new lvec4(z, x, x, z);
        
        /// <summary>
        /// Returns lvec4.brra swizzling.
        /// </summary>
        public lvec4 brra => new lvec4(z, x, x, w);
        
        /// <summary>
        /// Returns lvec4.brg swizzling.
        /// </summary>
        public lvec3 brg => new lvec3(z, x, y);
        
        /// <summary>
        /// Returns lvec4.brgr swizzling.
        /// </summary>
        public lvec4 brgr => new lvec4(z, x, y, x);
        
        /// <summary>
        /// Returns lvec4.brgg swizzling.
        /// </summary>
        public lvec4 brgg => new lvec4(z, x, y, y);
        
        /// <summary>
        /// Returns lvec4.brgb swizzling.
        /// </summary>
        public lvec4 brgb => new lvec4(z, x, y, z);
        
        /// <summary>
        /// Returns lvec4.brga swizzling.
        /// </summary>
        public lvec4 brga => new lvec4(z, x, y, w);
        
        /// <summary>
        /// Returns lvec4.brb swizzling.
        /// </summary>
        public lvec3 brb => new lvec3(z, x, z);
        
        /// <summary>
        /// Returns lvec4.brbr swizzling.
        /// </summary>
        public lvec4 brbr => new lvec4(z, x, z, x);
        
        /// <summary>
        /// Returns lvec4.brbg swizzling.
        /// </summary>
        public lvec4 brbg => new lvec4(z, x, z, y);
        
        /// <summary>
        /// Returns lvec4.brbb swizzling.
        /// </summary>
        public lvec4 brbb => new lvec4(z, x, z, z);
        
        /// <summary>
        /// Returns lvec4.brba swizzling.
        /// </summary>
        public lvec4 brba => new lvec4(z, x, z, w);
        
        /// <summary>
        /// Returns lvec4.bra swizzling.
        /// </summary>
        public lvec3 bra => new lvec3(z, x, w);
        
        /// <summary>
        /// Returns lvec4.brar swizzling.
        /// </summary>
        public lvec4 brar => new lvec4(z, x, w, x);
        
        /// <summary>
        /// Returns lvec4.brag swizzling.
        /// </summary>
        public lvec4 brag => new lvec4(z, x, w, y);
        
        /// <summary>
        /// Returns lvec4.brab swizzling.
        /// </summary>
        public lvec4 brab => new lvec4(z, x, w, z);
        
        /// <summary>
        /// Returns lvec4.braa swizzling.
        /// </summary>
        public lvec4 braa => new lvec4(z, x, w, w);
        
        /// <summary>
        /// Returns lvec4.bg swizzling.
        /// </summary>
        public lvec2 bg => new lvec2(z, y);
        
        /// <summary>
        /// Returns lvec4.bgr swizzling.
        /// </summary>
        public lvec3 bgr => new lvec3(z, y, x);
        
        /// <summary>
        /// Returns lvec4.bgrr swizzling.
        /// </summary>
        public lvec4 bgrr => new lvec4(z, y, x, x);
        
        /// <summary>
        /// Returns lvec4.bgrg swizzling.
        /// </summary>
        public lvec4 bgrg => new lvec4(z, y, x, y);
        
        /// <summary>
        /// Returns lvec4.bgrb swizzling.
        /// </summary>
        public lvec4 bgrb => new lvec4(z, y, x, z);
        
        /// <summary>
        /// Returns lvec4.bgra swizzling.
        /// </summary>
        public lvec4 bgra => new lvec4(z, y, x, w);
        
        /// <summary>
        /// Returns lvec4.bgg swizzling.
        /// </summary>
        public lvec3 bgg => new lvec3(z, y, y);
        
        /// <summary>
        /// Returns lvec4.bggr swizzling.
        /// </summary>
        public lvec4 bggr => new lvec4(z, y, y, x);
        
        /// <summary>
        /// Returns lvec4.bggg swizzling.
        /// </summary>
        public lvec4 bggg => new lvec4(z, y, y, y);
        
        /// <summary>
        /// Returns lvec4.bggb swizzling.
        /// </summary>
        public lvec4 bggb => new lvec4(z, y, y, z);
        
        /// <summary>
        /// Returns lvec4.bgga swizzling.
        /// </summary>
        public lvec4 bgga => new lvec4(z, y, y, w);
        
        /// <summary>
        /// Returns lvec4.bgb swizzling.
        /// </summary>
        public lvec3 bgb => new lvec3(z, y, z);
        
        /// <summary>
        /// Returns lvec4.bgbr swizzling.
        /// </summary>
        public lvec4 bgbr => new lvec4(z, y, z, x);
        
        /// <summary>
        /// Returns lvec4.bgbg swizzling.
        /// </summary>
        public lvec4 bgbg => new lvec4(z, y, z, y);
        
        /// <summary>
        /// Returns lvec4.bgbb swizzling.
        /// </summary>
        public lvec4 bgbb => new lvec4(z, y, z, z);
        
        /// <summary>
        /// Returns lvec4.bgba swizzling.
        /// </summary>
        public lvec4 bgba => new lvec4(z, y, z, w);
        
        /// <summary>
        /// Returns lvec4.bga swizzling.
        /// </summary>
        public lvec3 bga => new lvec3(z, y, w);
        
        /// <summary>
        /// Returns lvec4.bgar swizzling.
        /// </summary>
        public lvec4 bgar => new lvec4(z, y, w, x);
        
        /// <summary>
        /// Returns lvec4.bgag swizzling.
        /// </summary>
        public lvec4 bgag => new lvec4(z, y, w, y);
        
        /// <summary>
        /// Returns lvec4.bgab swizzling.
        /// </summary>
        public lvec4 bgab => new lvec4(z, y, w, z);
        
        /// <summary>
        /// Returns lvec4.bgaa swizzling.
        /// </summary>
        public lvec4 bgaa => new lvec4(z, y, w, w);
        
        /// <summary>
        /// Returns lvec4.bb swizzling.
        /// </summary>
        public lvec2 bb => new lvec2(z, z);
        
        /// <summary>
        /// Returns lvec4.bbr swizzling.
        /// </summary>
        public lvec3 bbr => new lvec3(z, z, x);
        
        /// <summary>
        /// Returns lvec4.bbrr swizzling.
        /// </summary>
        public lvec4 bbrr => new lvec4(z, z, x, x);
        
        /// <summary>
        /// Returns lvec4.bbrg swizzling.
        /// </summary>
        public lvec4 bbrg => new lvec4(z, z, x, y);
        
        /// <summary>
        /// Returns lvec4.bbrb swizzling.
        /// </summary>
        public lvec4 bbrb => new lvec4(z, z, x, z);
        
        /// <summary>
        /// Returns lvec4.bbra swizzling.
        /// </summary>
        public lvec4 bbra => new lvec4(z, z, x, w);
        
        /// <summary>
        /// Returns lvec4.bbg swizzling.
        /// </summary>
        public lvec3 bbg => new lvec3(z, z, y);
        
        /// <summary>
        /// Returns lvec4.bbgr swizzling.
        /// </summary>
        public lvec4 bbgr => new lvec4(z, z, y, x);
        
        /// <summary>
        /// Returns lvec4.bbgg swizzling.
        /// </summary>
        public lvec4 bbgg => new lvec4(z, z, y, y);
        
        /// <summary>
        /// Returns lvec4.bbgb swizzling.
        /// </summary>
        public lvec4 bbgb => new lvec4(z, z, y, z);
        
        /// <summary>
        /// Returns lvec4.bbga swizzling.
        /// </summary>
        public lvec4 bbga => new lvec4(z, z, y, w);
        
        /// <summary>
        /// Returns lvec4.bbb swizzling.
        /// </summary>
        public lvec3 bbb => new lvec3(z, z, z);
        
        /// <summary>
        /// Returns lvec4.bbbr swizzling.
        /// </summary>
        public lvec4 bbbr => new lvec4(z, z, z, x);
        
        /// <summary>
        /// Returns lvec4.bbbg swizzling.
        /// </summary>
        public lvec4 bbbg => new lvec4(z, z, z, y);
        
        /// <summary>
        /// Returns lvec4.bbbb swizzling.
        /// </summary>
        public lvec4 bbbb => new lvec4(z, z, z, z);
        
        /// <summary>
        /// Returns lvec4.bbba swizzling.
        /// </summary>
        public lvec4 bbba => new lvec4(z, z, z, w);
        
        /// <summary>
        /// Returns lvec4.bba swizzling.
        /// </summary>
        public lvec3 bba => new lvec3(z, z, w);
        
        /// <summary>
        /// Returns lvec4.bbar swizzling.
        /// </summary>
        public lvec4 bbar => new lvec4(z, z, w, x);
        
        /// <summary>
        /// Returns lvec4.bbag swizzling.
        /// </summary>
        public lvec4 bbag => new lvec4(z, z, w, y);
        
        /// <summary>
        /// Returns lvec4.bbab swizzling.
        /// </summary>
        public lvec4 bbab => new lvec4(z, z, w, z);
        
        /// <summary>
        /// Returns lvec4.bbaa swizzling.
        /// </summary>
        public lvec4 bbaa => new lvec4(z, z, w, w);
        
        /// <summary>
        /// Returns lvec4.ba swizzling.
        /// </summary>
        public lvec2 ba => new lvec2(z, w);
        
        /// <summary>
        /// Returns lvec4.bar swizzling.
        /// </summary>
        public lvec3 bar => new lvec3(z, w, x);
        
        /// <summary>
        /// Returns lvec4.barr swizzling.
        /// </summary>
        public lvec4 barr => new lvec4(z, w, x, x);
        
        /// <summary>
        /// Returns lvec4.barg swizzling.
        /// </summary>
        public lvec4 barg => new lvec4(z, w, x, y);
        
        /// <summary>
        /// Returns lvec4.barb swizzling.
        /// </summary>
        public lvec4 barb => new lvec4(z, w, x, z);
        
        /// <summary>
        /// Returns lvec4.bara swizzling.
        /// </summary>
        public lvec4 bara => new lvec4(z, w, x, w);
        
        /// <summary>
        /// Returns lvec4.bag swizzling.
        /// </summary>
        public lvec3 bag => new lvec3(z, w, y);
        
        /// <summary>
        /// Returns lvec4.bagr swizzling.
        /// </summary>
        public lvec4 bagr => new lvec4(z, w, y, x);
        
        /// <summary>
        /// Returns lvec4.bagg swizzling.
        /// </summary>
        public lvec4 bagg => new lvec4(z, w, y, y);
        
        /// <summary>
        /// Returns lvec4.bagb swizzling.
        /// </summary>
        public lvec4 bagb => new lvec4(z, w, y, z);
        
        /// <summary>
        /// Returns lvec4.baga swizzling.
        /// </summary>
        public lvec4 baga => new lvec4(z, w, y, w);
        
        /// <summary>
        /// Returns lvec4.bab swizzling.
        /// </summary>
        public lvec3 bab => new lvec3(z, w, z);
        
        /// <summary>
        /// Returns lvec4.babr swizzling.
        /// </summary>
        public lvec4 babr => new lvec4(z, w, z, x);
        
        /// <summary>
        /// Returns lvec4.babg swizzling.
        /// </summary>
        public lvec4 babg => new lvec4(z, w, z, y);
        
        /// <summary>
        /// Returns lvec4.babb swizzling.
        /// </summary>
        public lvec4 babb => new lvec4(z, w, z, z);
        
        /// <summary>
        /// Returns lvec4.baba swizzling.
        /// </summary>
        public lvec4 baba => new lvec4(z, w, z, w);
        
        /// <summary>
        /// Returns lvec4.baa swizzling.
        /// </summary>
        public lvec3 baa => new lvec3(z, w, w);
        
        /// <summary>
        /// Returns lvec4.baar swizzling.
        /// </summary>
        public lvec4 baar => new lvec4(z, w, w, x);
        
        /// <summary>
        /// Returns lvec4.baag swizzling.
        /// </summary>
        public lvec4 baag => new lvec4(z, w, w, y);
        
        /// <summary>
        /// Returns lvec4.baab swizzling.
        /// </summary>
        public lvec4 baab => new lvec4(z, w, w, z);
        
        /// <summary>
        /// Returns lvec4.baaa swizzling.
        /// </summary>
        public lvec4 baaa => new lvec4(z, w, w, w);
        
        /// <summary>
        /// Returns lvec4.ar swizzling.
        /// </summary>
        public lvec2 ar => new lvec2(w, x);
        
        /// <summary>
        /// Returns lvec4.arr swizzling.
        /// </summary>
        public lvec3 arr => new lvec3(w, x, x);
        
        /// <summary>
        /// Returns lvec4.arrr swizzling.
        /// </summary>
        public lvec4 arrr => new lvec4(w, x, x, x);
        
        /// <summary>
        /// Returns lvec4.arrg swizzling.
        /// </summary>
        public lvec4 arrg => new lvec4(w, x, x, y);
        
        /// <summary>
        /// Returns lvec4.arrb swizzling.
        /// </summary>
        public lvec4 arrb => new lvec4(w, x, x, z);
        
        /// <summary>
        /// Returns lvec4.arra swizzling.
        /// </summary>
        public lvec4 arra => new lvec4(w, x, x, w);
        
        /// <summary>
        /// Returns lvec4.arg swizzling.
        /// </summary>
        public lvec3 arg => new lvec3(w, x, y);
        
        /// <summary>
        /// Returns lvec4.argr swizzling.
        /// </summary>
        public lvec4 argr => new lvec4(w, x, y, x);
        
        /// <summary>
        /// Returns lvec4.argg swizzling.
        /// </summary>
        public lvec4 argg => new lvec4(w, x, y, y);
        
        /// <summary>
        /// Returns lvec4.argb swizzling.
        /// </summary>
        public lvec4 argb => new lvec4(w, x, y, z);
        
        /// <summary>
        /// Returns lvec4.arga swizzling.
        /// </summary>
        public lvec4 arga => new lvec4(w, x, y, w);
        
        /// <summary>
        /// Returns lvec4.arb swizzling.
        /// </summary>
        public lvec3 arb => new lvec3(w, x, z);
        
        /// <summary>
        /// Returns lvec4.arbr swizzling.
        /// </summary>
        public lvec4 arbr => new lvec4(w, x, z, x);
        
        /// <summary>
        /// Returns lvec4.arbg swizzling.
        /// </summary>
        public lvec4 arbg => new lvec4(w, x, z, y);
        
        /// <summary>
        /// Returns lvec4.arbb swizzling.
        /// </summary>
        public lvec4 arbb => new lvec4(w, x, z, z);
        
        /// <summary>
        /// Returns lvec4.arba swizzling.
        /// </summary>
        public lvec4 arba => new lvec4(w, x, z, w);
        
        /// <summary>
        /// Returns lvec4.ara swizzling.
        /// </summary>
        public lvec3 ara => new lvec3(w, x, w);
        
        /// <summary>
        /// Returns lvec4.arar swizzling.
        /// </summary>
        public lvec4 arar => new lvec4(w, x, w, x);
        
        /// <summary>
        /// Returns lvec4.arag swizzling.
        /// </summary>
        public lvec4 arag => new lvec4(w, x, w, y);
        
        /// <summary>
        /// Returns lvec4.arab swizzling.
        /// </summary>
        public lvec4 arab => new lvec4(w, x, w, z);
        
        /// <summary>
        /// Returns lvec4.araa swizzling.
        /// </summary>
        public lvec4 araa => new lvec4(w, x, w, w);
        
        /// <summary>
        /// Returns lvec4.ag swizzling.
        /// </summary>
        public lvec2 ag => new lvec2(w, y);
        
        /// <summary>
        /// Returns lvec4.agr swizzling.
        /// </summary>
        public lvec3 agr => new lvec3(w, y, x);
        
        /// <summary>
        /// Returns lvec4.agrr swizzling.
        /// </summary>
        public lvec4 agrr => new lvec4(w, y, x, x);
        
        /// <summary>
        /// Returns lvec4.agrg swizzling.
        /// </summary>
        public lvec4 agrg => new lvec4(w, y, x, y);
        
        /// <summary>
        /// Returns lvec4.agrb swizzling.
        /// </summary>
        public lvec4 agrb => new lvec4(w, y, x, z);
        
        /// <summary>
        /// Returns lvec4.agra swizzling.
        /// </summary>
        public lvec4 agra => new lvec4(w, y, x, w);
        
        /// <summary>
        /// Returns lvec4.agg swizzling.
        /// </summary>
        public lvec3 agg => new lvec3(w, y, y);
        
        /// <summary>
        /// Returns lvec4.aggr swizzling.
        /// </summary>
        public lvec4 aggr => new lvec4(w, y, y, x);
        
        /// <summary>
        /// Returns lvec4.aggg swizzling.
        /// </summary>
        public lvec4 aggg => new lvec4(w, y, y, y);
        
        /// <summary>
        /// Returns lvec4.aggb swizzling.
        /// </summary>
        public lvec4 aggb => new lvec4(w, y, y, z);
        
        /// <summary>
        /// Returns lvec4.agga swizzling.
        /// </summary>
        public lvec4 agga => new lvec4(w, y, y, w);
        
        /// <summary>
        /// Returns lvec4.agb swizzling.
        /// </summary>
        public lvec3 agb => new lvec3(w, y, z);
        
        /// <summary>
        /// Returns lvec4.agbr swizzling.
        /// </summary>
        public lvec4 agbr => new lvec4(w, y, z, x);
        
        /// <summary>
        /// Returns lvec4.agbg swizzling.
        /// </summary>
        public lvec4 agbg => new lvec4(w, y, z, y);
        
        /// <summary>
        /// Returns lvec4.agbb swizzling.
        /// </summary>
        public lvec4 agbb => new lvec4(w, y, z, z);
        
        /// <summary>
        /// Returns lvec4.agba swizzling.
        /// </summary>
        public lvec4 agba => new lvec4(w, y, z, w);
        
        /// <summary>
        /// Returns lvec4.aga swizzling.
        /// </summary>
        public lvec3 aga => new lvec3(w, y, w);
        
        /// <summary>
        /// Returns lvec4.agar swizzling.
        /// </summary>
        public lvec4 agar => new lvec4(w, y, w, x);
        
        /// <summary>
        /// Returns lvec4.agag swizzling.
        /// </summary>
        public lvec4 agag => new lvec4(w, y, w, y);
        
        /// <summary>
        /// Returns lvec4.agab swizzling.
        /// </summary>
        public lvec4 agab => new lvec4(w, y, w, z);
        
        /// <summary>
        /// Returns lvec4.agaa swizzling.
        /// </summary>
        public lvec4 agaa => new lvec4(w, y, w, w);
        
        /// <summary>
        /// Returns lvec4.ab swizzling.
        /// </summary>
        public lvec2 ab => new lvec2(w, z);
        
        /// <summary>
        /// Returns lvec4.abr swizzling.
        /// </summary>
        public lvec3 abr => new lvec3(w, z, x);
        
        /// <summary>
        /// Returns lvec4.abrr swizzling.
        /// </summary>
        public lvec4 abrr => new lvec4(w, z, x, x);
        
        /// <summary>
        /// Returns lvec4.abrg swizzling.
        /// </summary>
        public lvec4 abrg => new lvec4(w, z, x, y);
        
        /// <summary>
        /// Returns lvec4.abrb swizzling.
        /// </summary>
        public lvec4 abrb => new lvec4(w, z, x, z);
        
        /// <summary>
        /// Returns lvec4.abra swizzling.
        /// </summary>
        public lvec4 abra => new lvec4(w, z, x, w);
        
        /// <summary>
        /// Returns lvec4.abg swizzling.
        /// </summary>
        public lvec3 abg => new lvec3(w, z, y);
        
        /// <summary>
        /// Returns lvec4.abgr swizzling.
        /// </summary>
        public lvec4 abgr => new lvec4(w, z, y, x);
        
        /// <summary>
        /// Returns lvec4.abgg swizzling.
        /// </summary>
        public lvec4 abgg => new lvec4(w, z, y, y);
        
        /// <summary>
        /// Returns lvec4.abgb swizzling.
        /// </summary>
        public lvec4 abgb => new lvec4(w, z, y, z);
        
        /// <summary>
        /// Returns lvec4.abga swizzling.
        /// </summary>
        public lvec4 abga => new lvec4(w, z, y, w);
        
        /// <summary>
        /// Returns lvec4.abb swizzling.
        /// </summary>
        public lvec3 abb => new lvec3(w, z, z);
        
        /// <summary>
        /// Returns lvec4.abbr swizzling.
        /// </summary>
        public lvec4 abbr => new lvec4(w, z, z, x);
        
        /// <summary>
        /// Returns lvec4.abbg swizzling.
        /// </summary>
        public lvec4 abbg => new lvec4(w, z, z, y);
        
        /// <summary>
        /// Returns lvec4.abbb swizzling.
        /// </summary>
        public lvec4 abbb => new lvec4(w, z, z, z);
        
        /// <summary>
        /// Returns lvec4.abba swizzling.
        /// </summary>
        public lvec4 abba => new lvec4(w, z, z, w);
        
        /// <summary>
        /// Returns lvec4.aba swizzling.
        /// </summary>
        public lvec3 aba => new lvec3(w, z, w);
        
        /// <summary>
        /// Returns lvec4.abar swizzling.
        /// </summary>
        public lvec4 abar => new lvec4(w, z, w, x);
        
        /// <summary>
        /// Returns lvec4.abag swizzling.
        /// </summary>
        public lvec4 abag => new lvec4(w, z, w, y);
        
        /// <summary>
        /// Returns lvec4.abab swizzling.
        /// </summary>
        public lvec4 abab => new lvec4(w, z, w, z);
        
        /// <summary>
        /// Returns lvec4.abaa swizzling.
        /// </summary>
        public lvec4 abaa => new lvec4(w, z, w, w);
        
        /// <summary>
        /// Returns lvec4.aa swizzling.
        /// </summary>
        public lvec2 aa => new lvec2(w, w);
        
        /// <summary>
        /// Returns lvec4.aar swizzling.
        /// </summary>
        public lvec3 aar => new lvec3(w, w, x);
        
        /// <summary>
        /// Returns lvec4.aarr swizzling.
        /// </summary>
        public lvec4 aarr => new lvec4(w, w, x, x);
        
        /// <summary>
        /// Returns lvec4.aarg swizzling.
        /// </summary>
        public lvec4 aarg => new lvec4(w, w, x, y);
        
        /// <summary>
        /// Returns lvec4.aarb swizzling.
        /// </summary>
        public lvec4 aarb => new lvec4(w, w, x, z);
        
        /// <summary>
        /// Returns lvec4.aara swizzling.
        /// </summary>
        public lvec4 aara => new lvec4(w, w, x, w);
        
        /// <summary>
        /// Returns lvec4.aag swizzling.
        /// </summary>
        public lvec3 aag => new lvec3(w, w, y);
        
        /// <summary>
        /// Returns lvec4.aagr swizzling.
        /// </summary>
        public lvec4 aagr => new lvec4(w, w, y, x);
        
        /// <summary>
        /// Returns lvec4.aagg swizzling.
        /// </summary>
        public lvec4 aagg => new lvec4(w, w, y, y);
        
        /// <summary>
        /// Returns lvec4.aagb swizzling.
        /// </summary>
        public lvec4 aagb => new lvec4(w, w, y, z);
        
        /// <summary>
        /// Returns lvec4.aaga swizzling.
        /// </summary>
        public lvec4 aaga => new lvec4(w, w, y, w);
        
        /// <summary>
        /// Returns lvec4.aab swizzling.
        /// </summary>
        public lvec3 aab => new lvec3(w, w, z);
        
        /// <summary>
        /// Returns lvec4.aabr swizzling.
        /// </summary>
        public lvec4 aabr => new lvec4(w, w, z, x);
        
        /// <summary>
        /// Returns lvec4.aabg swizzling.
        /// </summary>
        public lvec4 aabg => new lvec4(w, w, z, y);
        
        /// <summary>
        /// Returns lvec4.aabb swizzling.
        /// </summary>
        public lvec4 aabb => new lvec4(w, w, z, z);
        
        /// <summary>
        /// Returns lvec4.aaba swizzling.
        /// </summary>
        public lvec4 aaba => new lvec4(w, w, z, w);
        
        /// <summary>
        /// Returns lvec4.aaa swizzling.
        /// </summary>
        public lvec3 aaa => new lvec3(w, w, w);
        
        /// <summary>
        /// Returns lvec4.aaar swizzling.
        /// </summary>
        public lvec4 aaar => new lvec4(w, w, w, x);
        
        /// <summary>
        /// Returns lvec4.aaag swizzling.
        /// </summary>
        public lvec4 aaag => new lvec4(w, w, w, y);
        
        /// <summary>
        /// Returns lvec4.aaab swizzling.
        /// </summary>
        public lvec4 aaab => new lvec4(w, w, w, z);
        
        /// <summary>
        /// Returns lvec4.aaaa swizzling.
        /// </summary>
        public lvec4 aaaa => new lvec4(w, w, w, w);
    }
}
