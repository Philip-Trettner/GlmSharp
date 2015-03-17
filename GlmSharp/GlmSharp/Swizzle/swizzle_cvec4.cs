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
    /// Temporary vector of type Complex with 4 components, used for implementing swizzling for cvec4.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_cvec4
    {
        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly Complex x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly Complex y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly Complex z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly Complex w;

        #endregion
        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_cvec4.
        /// </summary>
        internal swizzle_cvec4(Complex x, Complex y, Complex z, Complex w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion
        
        // XYZW Versions
        
        /// <summary>
        /// Returns cvec4.xx swizzling.
        /// </summary>
        public cvec2 xx => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec4.xxx swizzling.
        /// </summary>
        public cvec3 xxx => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec4.xxxx swizzling.
        /// </summary>
        public cvec4 xxxx => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.xxxy swizzling.
        /// </summary>
        public cvec4 xxxy => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.xxxz swizzling.
        /// </summary>
        public cvec4 xxxz => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.xxxw swizzling.
        /// </summary>
        public cvec4 xxxw => new cvec4(x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.xxy swizzling.
        /// </summary>
        public cvec3 xxy => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec4.xxyx swizzling.
        /// </summary>
        public cvec4 xxyx => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.xxyy swizzling.
        /// </summary>
        public cvec4 xxyy => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.xxyz swizzling.
        /// </summary>
        public cvec4 xxyz => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.xxyw swizzling.
        /// </summary>
        public cvec4 xxyw => new cvec4(x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.xxz swizzling.
        /// </summary>
        public cvec3 xxz => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec4.xxzx swizzling.
        /// </summary>
        public cvec4 xxzx => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.xxzy swizzling.
        /// </summary>
        public cvec4 xxzy => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.xxzz swizzling.
        /// </summary>
        public cvec4 xxzz => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.xxzw swizzling.
        /// </summary>
        public cvec4 xxzw => new cvec4(x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.xxw swizzling.
        /// </summary>
        public cvec3 xxw => new cvec3(x, x, w);
        
        /// <summary>
        /// Returns cvec4.xxwx swizzling.
        /// </summary>
        public cvec4 xxwx => new cvec4(x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.xxwy swizzling.
        /// </summary>
        public cvec4 xxwy => new cvec4(x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.xxwz swizzling.
        /// </summary>
        public cvec4 xxwz => new cvec4(x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.xxww swizzling.
        /// </summary>
        public cvec4 xxww => new cvec4(x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.xy swizzling.
        /// </summary>
        public cvec2 xy => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec4.xyx swizzling.
        /// </summary>
        public cvec3 xyx => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec4.xyxx swizzling.
        /// </summary>
        public cvec4 xyxx => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.xyxy swizzling.
        /// </summary>
        public cvec4 xyxy => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.xyxz swizzling.
        /// </summary>
        public cvec4 xyxz => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.xyxw swizzling.
        /// </summary>
        public cvec4 xyxw => new cvec4(x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.xyy swizzling.
        /// </summary>
        public cvec3 xyy => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec4.xyyx swizzling.
        /// </summary>
        public cvec4 xyyx => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.xyyy swizzling.
        /// </summary>
        public cvec4 xyyy => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.xyyz swizzling.
        /// </summary>
        public cvec4 xyyz => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.xyyw swizzling.
        /// </summary>
        public cvec4 xyyw => new cvec4(x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.xyz swizzling.
        /// </summary>
        public cvec3 xyz => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec4.xyzx swizzling.
        /// </summary>
        public cvec4 xyzx => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.xyzy swizzling.
        /// </summary>
        public cvec4 xyzy => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.xyzz swizzling.
        /// </summary>
        public cvec4 xyzz => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.xyzw swizzling.
        /// </summary>
        public cvec4 xyzw => new cvec4(x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.xyw swizzling.
        /// </summary>
        public cvec3 xyw => new cvec3(x, y, w);
        
        /// <summary>
        /// Returns cvec4.xywx swizzling.
        /// </summary>
        public cvec4 xywx => new cvec4(x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.xywy swizzling.
        /// </summary>
        public cvec4 xywy => new cvec4(x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.xywz swizzling.
        /// </summary>
        public cvec4 xywz => new cvec4(x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.xyww swizzling.
        /// </summary>
        public cvec4 xyww => new cvec4(x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.xz swizzling.
        /// </summary>
        public cvec2 xz => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec4.xzx swizzling.
        /// </summary>
        public cvec3 xzx => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec4.xzxx swizzling.
        /// </summary>
        public cvec4 xzxx => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.xzxy swizzling.
        /// </summary>
        public cvec4 xzxy => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.xzxz swizzling.
        /// </summary>
        public cvec4 xzxz => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.xzxw swizzling.
        /// </summary>
        public cvec4 xzxw => new cvec4(x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.xzy swizzling.
        /// </summary>
        public cvec3 xzy => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec4.xzyx swizzling.
        /// </summary>
        public cvec4 xzyx => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.xzyy swizzling.
        /// </summary>
        public cvec4 xzyy => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.xzyz swizzling.
        /// </summary>
        public cvec4 xzyz => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.xzyw swizzling.
        /// </summary>
        public cvec4 xzyw => new cvec4(x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.xzz swizzling.
        /// </summary>
        public cvec3 xzz => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec4.xzzx swizzling.
        /// </summary>
        public cvec4 xzzx => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.xzzy swizzling.
        /// </summary>
        public cvec4 xzzy => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.xzzz swizzling.
        /// </summary>
        public cvec4 xzzz => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.xzzw swizzling.
        /// </summary>
        public cvec4 xzzw => new cvec4(x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.xzw swizzling.
        /// </summary>
        public cvec3 xzw => new cvec3(x, z, w);
        
        /// <summary>
        /// Returns cvec4.xzwx swizzling.
        /// </summary>
        public cvec4 xzwx => new cvec4(x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.xzwy swizzling.
        /// </summary>
        public cvec4 xzwy => new cvec4(x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.xzwz swizzling.
        /// </summary>
        public cvec4 xzwz => new cvec4(x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.xzww swizzling.
        /// </summary>
        public cvec4 xzww => new cvec4(x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.xw swizzling.
        /// </summary>
        public cvec2 xw => new cvec2(x, w);
        
        /// <summary>
        /// Returns cvec4.xwx swizzling.
        /// </summary>
        public cvec3 xwx => new cvec3(x, w, x);
        
        /// <summary>
        /// Returns cvec4.xwxx swizzling.
        /// </summary>
        public cvec4 xwxx => new cvec4(x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.xwxy swizzling.
        /// </summary>
        public cvec4 xwxy => new cvec4(x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.xwxz swizzling.
        /// </summary>
        public cvec4 xwxz => new cvec4(x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.xwxw swizzling.
        /// </summary>
        public cvec4 xwxw => new cvec4(x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.xwy swizzling.
        /// </summary>
        public cvec3 xwy => new cvec3(x, w, y);
        
        /// <summary>
        /// Returns cvec4.xwyx swizzling.
        /// </summary>
        public cvec4 xwyx => new cvec4(x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.xwyy swizzling.
        /// </summary>
        public cvec4 xwyy => new cvec4(x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.xwyz swizzling.
        /// </summary>
        public cvec4 xwyz => new cvec4(x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.xwyw swizzling.
        /// </summary>
        public cvec4 xwyw => new cvec4(x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.xwz swizzling.
        /// </summary>
        public cvec3 xwz => new cvec3(x, w, z);
        
        /// <summary>
        /// Returns cvec4.xwzx swizzling.
        /// </summary>
        public cvec4 xwzx => new cvec4(x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.xwzy swizzling.
        /// </summary>
        public cvec4 xwzy => new cvec4(x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.xwzz swizzling.
        /// </summary>
        public cvec4 xwzz => new cvec4(x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.xwzw swizzling.
        /// </summary>
        public cvec4 xwzw => new cvec4(x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.xww swizzling.
        /// </summary>
        public cvec3 xww => new cvec3(x, w, w);
        
        /// <summary>
        /// Returns cvec4.xwwx swizzling.
        /// </summary>
        public cvec4 xwwx => new cvec4(x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.xwwy swizzling.
        /// </summary>
        public cvec4 xwwy => new cvec4(x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.xwwz swizzling.
        /// </summary>
        public cvec4 xwwz => new cvec4(x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.xwww swizzling.
        /// </summary>
        public cvec4 xwww => new cvec4(x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.yx swizzling.
        /// </summary>
        public cvec2 yx => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec4.yxx swizzling.
        /// </summary>
        public cvec3 yxx => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec4.yxxx swizzling.
        /// </summary>
        public cvec4 yxxx => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.yxxy swizzling.
        /// </summary>
        public cvec4 yxxy => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.yxxz swizzling.
        /// </summary>
        public cvec4 yxxz => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.yxxw swizzling.
        /// </summary>
        public cvec4 yxxw => new cvec4(y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.yxy swizzling.
        /// </summary>
        public cvec3 yxy => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec4.yxyx swizzling.
        /// </summary>
        public cvec4 yxyx => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.yxyy swizzling.
        /// </summary>
        public cvec4 yxyy => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.yxyz swizzling.
        /// </summary>
        public cvec4 yxyz => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.yxyw swizzling.
        /// </summary>
        public cvec4 yxyw => new cvec4(y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.yxz swizzling.
        /// </summary>
        public cvec3 yxz => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec4.yxzx swizzling.
        /// </summary>
        public cvec4 yxzx => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.yxzy swizzling.
        /// </summary>
        public cvec4 yxzy => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.yxzz swizzling.
        /// </summary>
        public cvec4 yxzz => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.yxzw swizzling.
        /// </summary>
        public cvec4 yxzw => new cvec4(y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.yxw swizzling.
        /// </summary>
        public cvec3 yxw => new cvec3(y, x, w);
        
        /// <summary>
        /// Returns cvec4.yxwx swizzling.
        /// </summary>
        public cvec4 yxwx => new cvec4(y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.yxwy swizzling.
        /// </summary>
        public cvec4 yxwy => new cvec4(y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.yxwz swizzling.
        /// </summary>
        public cvec4 yxwz => new cvec4(y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.yxww swizzling.
        /// </summary>
        public cvec4 yxww => new cvec4(y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.yy swizzling.
        /// </summary>
        public cvec2 yy => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec4.yyx swizzling.
        /// </summary>
        public cvec3 yyx => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec4.yyxx swizzling.
        /// </summary>
        public cvec4 yyxx => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.yyxy swizzling.
        /// </summary>
        public cvec4 yyxy => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.yyxz swizzling.
        /// </summary>
        public cvec4 yyxz => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.yyxw swizzling.
        /// </summary>
        public cvec4 yyxw => new cvec4(y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.yyy swizzling.
        /// </summary>
        public cvec3 yyy => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec4.yyyx swizzling.
        /// </summary>
        public cvec4 yyyx => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.yyyy swizzling.
        /// </summary>
        public cvec4 yyyy => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.yyyz swizzling.
        /// </summary>
        public cvec4 yyyz => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.yyyw swizzling.
        /// </summary>
        public cvec4 yyyw => new cvec4(y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.yyz swizzling.
        /// </summary>
        public cvec3 yyz => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec4.yyzx swizzling.
        /// </summary>
        public cvec4 yyzx => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.yyzy swizzling.
        /// </summary>
        public cvec4 yyzy => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.yyzz swizzling.
        /// </summary>
        public cvec4 yyzz => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.yyzw swizzling.
        /// </summary>
        public cvec4 yyzw => new cvec4(y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.yyw swizzling.
        /// </summary>
        public cvec3 yyw => new cvec3(y, y, w);
        
        /// <summary>
        /// Returns cvec4.yywx swizzling.
        /// </summary>
        public cvec4 yywx => new cvec4(y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.yywy swizzling.
        /// </summary>
        public cvec4 yywy => new cvec4(y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.yywz swizzling.
        /// </summary>
        public cvec4 yywz => new cvec4(y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.yyww swizzling.
        /// </summary>
        public cvec4 yyww => new cvec4(y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.yz swizzling.
        /// </summary>
        public cvec2 yz => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec4.yzx swizzling.
        /// </summary>
        public cvec3 yzx => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec4.yzxx swizzling.
        /// </summary>
        public cvec4 yzxx => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.yzxy swizzling.
        /// </summary>
        public cvec4 yzxy => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.yzxz swizzling.
        /// </summary>
        public cvec4 yzxz => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.yzxw swizzling.
        /// </summary>
        public cvec4 yzxw => new cvec4(y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.yzy swizzling.
        /// </summary>
        public cvec3 yzy => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec4.yzyx swizzling.
        /// </summary>
        public cvec4 yzyx => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.yzyy swizzling.
        /// </summary>
        public cvec4 yzyy => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.yzyz swizzling.
        /// </summary>
        public cvec4 yzyz => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.yzyw swizzling.
        /// </summary>
        public cvec4 yzyw => new cvec4(y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.yzz swizzling.
        /// </summary>
        public cvec3 yzz => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec4.yzzx swizzling.
        /// </summary>
        public cvec4 yzzx => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.yzzy swizzling.
        /// </summary>
        public cvec4 yzzy => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.yzzz swizzling.
        /// </summary>
        public cvec4 yzzz => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.yzzw swizzling.
        /// </summary>
        public cvec4 yzzw => new cvec4(y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.yzw swizzling.
        /// </summary>
        public cvec3 yzw => new cvec3(y, z, w);
        
        /// <summary>
        /// Returns cvec4.yzwx swizzling.
        /// </summary>
        public cvec4 yzwx => new cvec4(y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.yzwy swizzling.
        /// </summary>
        public cvec4 yzwy => new cvec4(y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.yzwz swizzling.
        /// </summary>
        public cvec4 yzwz => new cvec4(y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.yzww swizzling.
        /// </summary>
        public cvec4 yzww => new cvec4(y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.yw swizzling.
        /// </summary>
        public cvec2 yw => new cvec2(y, w);
        
        /// <summary>
        /// Returns cvec4.ywx swizzling.
        /// </summary>
        public cvec3 ywx => new cvec3(y, w, x);
        
        /// <summary>
        /// Returns cvec4.ywxx swizzling.
        /// </summary>
        public cvec4 ywxx => new cvec4(y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.ywxy swizzling.
        /// </summary>
        public cvec4 ywxy => new cvec4(y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.ywxz swizzling.
        /// </summary>
        public cvec4 ywxz => new cvec4(y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.ywxw swizzling.
        /// </summary>
        public cvec4 ywxw => new cvec4(y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.ywy swizzling.
        /// </summary>
        public cvec3 ywy => new cvec3(y, w, y);
        
        /// <summary>
        /// Returns cvec4.ywyx swizzling.
        /// </summary>
        public cvec4 ywyx => new cvec4(y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.ywyy swizzling.
        /// </summary>
        public cvec4 ywyy => new cvec4(y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.ywyz swizzling.
        /// </summary>
        public cvec4 ywyz => new cvec4(y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.ywyw swizzling.
        /// </summary>
        public cvec4 ywyw => new cvec4(y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.ywz swizzling.
        /// </summary>
        public cvec3 ywz => new cvec3(y, w, z);
        
        /// <summary>
        /// Returns cvec4.ywzx swizzling.
        /// </summary>
        public cvec4 ywzx => new cvec4(y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.ywzy swizzling.
        /// </summary>
        public cvec4 ywzy => new cvec4(y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.ywzz swizzling.
        /// </summary>
        public cvec4 ywzz => new cvec4(y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.ywzw swizzling.
        /// </summary>
        public cvec4 ywzw => new cvec4(y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.yww swizzling.
        /// </summary>
        public cvec3 yww => new cvec3(y, w, w);
        
        /// <summary>
        /// Returns cvec4.ywwx swizzling.
        /// </summary>
        public cvec4 ywwx => new cvec4(y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.ywwy swizzling.
        /// </summary>
        public cvec4 ywwy => new cvec4(y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.ywwz swizzling.
        /// </summary>
        public cvec4 ywwz => new cvec4(y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.ywww swizzling.
        /// </summary>
        public cvec4 ywww => new cvec4(y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.zx swizzling.
        /// </summary>
        public cvec2 zx => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec4.zxx swizzling.
        /// </summary>
        public cvec3 zxx => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec4.zxxx swizzling.
        /// </summary>
        public cvec4 zxxx => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.zxxy swizzling.
        /// </summary>
        public cvec4 zxxy => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.zxxz swizzling.
        /// </summary>
        public cvec4 zxxz => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.zxxw swizzling.
        /// </summary>
        public cvec4 zxxw => new cvec4(z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.zxy swizzling.
        /// </summary>
        public cvec3 zxy => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec4.zxyx swizzling.
        /// </summary>
        public cvec4 zxyx => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.zxyy swizzling.
        /// </summary>
        public cvec4 zxyy => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.zxyz swizzling.
        /// </summary>
        public cvec4 zxyz => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.zxyw swizzling.
        /// </summary>
        public cvec4 zxyw => new cvec4(z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.zxz swizzling.
        /// </summary>
        public cvec3 zxz => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec4.zxzx swizzling.
        /// </summary>
        public cvec4 zxzx => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.zxzy swizzling.
        /// </summary>
        public cvec4 zxzy => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.zxzz swizzling.
        /// </summary>
        public cvec4 zxzz => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.zxzw swizzling.
        /// </summary>
        public cvec4 zxzw => new cvec4(z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.zxw swizzling.
        /// </summary>
        public cvec3 zxw => new cvec3(z, x, w);
        
        /// <summary>
        /// Returns cvec4.zxwx swizzling.
        /// </summary>
        public cvec4 zxwx => new cvec4(z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.zxwy swizzling.
        /// </summary>
        public cvec4 zxwy => new cvec4(z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.zxwz swizzling.
        /// </summary>
        public cvec4 zxwz => new cvec4(z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.zxww swizzling.
        /// </summary>
        public cvec4 zxww => new cvec4(z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.zy swizzling.
        /// </summary>
        public cvec2 zy => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec4.zyx swizzling.
        /// </summary>
        public cvec3 zyx => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec4.zyxx swizzling.
        /// </summary>
        public cvec4 zyxx => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.zyxy swizzling.
        /// </summary>
        public cvec4 zyxy => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.zyxz swizzling.
        /// </summary>
        public cvec4 zyxz => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.zyxw swizzling.
        /// </summary>
        public cvec4 zyxw => new cvec4(z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.zyy swizzling.
        /// </summary>
        public cvec3 zyy => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec4.zyyx swizzling.
        /// </summary>
        public cvec4 zyyx => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.zyyy swizzling.
        /// </summary>
        public cvec4 zyyy => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.zyyz swizzling.
        /// </summary>
        public cvec4 zyyz => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.zyyw swizzling.
        /// </summary>
        public cvec4 zyyw => new cvec4(z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.zyz swizzling.
        /// </summary>
        public cvec3 zyz => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec4.zyzx swizzling.
        /// </summary>
        public cvec4 zyzx => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.zyzy swizzling.
        /// </summary>
        public cvec4 zyzy => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.zyzz swizzling.
        /// </summary>
        public cvec4 zyzz => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.zyzw swizzling.
        /// </summary>
        public cvec4 zyzw => new cvec4(z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.zyw swizzling.
        /// </summary>
        public cvec3 zyw => new cvec3(z, y, w);
        
        /// <summary>
        /// Returns cvec4.zywx swizzling.
        /// </summary>
        public cvec4 zywx => new cvec4(z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.zywy swizzling.
        /// </summary>
        public cvec4 zywy => new cvec4(z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.zywz swizzling.
        /// </summary>
        public cvec4 zywz => new cvec4(z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.zyww swizzling.
        /// </summary>
        public cvec4 zyww => new cvec4(z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.zz swizzling.
        /// </summary>
        public cvec2 zz => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec4.zzx swizzling.
        /// </summary>
        public cvec3 zzx => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec4.zzxx swizzling.
        /// </summary>
        public cvec4 zzxx => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.zzxy swizzling.
        /// </summary>
        public cvec4 zzxy => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.zzxz swizzling.
        /// </summary>
        public cvec4 zzxz => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.zzxw swizzling.
        /// </summary>
        public cvec4 zzxw => new cvec4(z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.zzy swizzling.
        /// </summary>
        public cvec3 zzy => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec4.zzyx swizzling.
        /// </summary>
        public cvec4 zzyx => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.zzyy swizzling.
        /// </summary>
        public cvec4 zzyy => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.zzyz swizzling.
        /// </summary>
        public cvec4 zzyz => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.zzyw swizzling.
        /// </summary>
        public cvec4 zzyw => new cvec4(z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.zzz swizzling.
        /// </summary>
        public cvec3 zzz => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec4.zzzx swizzling.
        /// </summary>
        public cvec4 zzzx => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.zzzy swizzling.
        /// </summary>
        public cvec4 zzzy => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.zzzz swizzling.
        /// </summary>
        public cvec4 zzzz => new cvec4(z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.zzzw swizzling.
        /// </summary>
        public cvec4 zzzw => new cvec4(z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.zzw swizzling.
        /// </summary>
        public cvec3 zzw => new cvec3(z, z, w);
        
        /// <summary>
        /// Returns cvec4.zzwx swizzling.
        /// </summary>
        public cvec4 zzwx => new cvec4(z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.zzwy swizzling.
        /// </summary>
        public cvec4 zzwy => new cvec4(z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.zzwz swizzling.
        /// </summary>
        public cvec4 zzwz => new cvec4(z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.zzww swizzling.
        /// </summary>
        public cvec4 zzww => new cvec4(z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.zw swizzling.
        /// </summary>
        public cvec2 zw => new cvec2(z, w);
        
        /// <summary>
        /// Returns cvec4.zwx swizzling.
        /// </summary>
        public cvec3 zwx => new cvec3(z, w, x);
        
        /// <summary>
        /// Returns cvec4.zwxx swizzling.
        /// </summary>
        public cvec4 zwxx => new cvec4(z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.zwxy swizzling.
        /// </summary>
        public cvec4 zwxy => new cvec4(z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.zwxz swizzling.
        /// </summary>
        public cvec4 zwxz => new cvec4(z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.zwxw swizzling.
        /// </summary>
        public cvec4 zwxw => new cvec4(z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.zwy swizzling.
        /// </summary>
        public cvec3 zwy => new cvec3(z, w, y);
        
        /// <summary>
        /// Returns cvec4.zwyx swizzling.
        /// </summary>
        public cvec4 zwyx => new cvec4(z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.zwyy swizzling.
        /// </summary>
        public cvec4 zwyy => new cvec4(z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.zwyz swizzling.
        /// </summary>
        public cvec4 zwyz => new cvec4(z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.zwyw swizzling.
        /// </summary>
        public cvec4 zwyw => new cvec4(z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.zwz swizzling.
        /// </summary>
        public cvec3 zwz => new cvec3(z, w, z);
        
        /// <summary>
        /// Returns cvec4.zwzx swizzling.
        /// </summary>
        public cvec4 zwzx => new cvec4(z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.zwzy swizzling.
        /// </summary>
        public cvec4 zwzy => new cvec4(z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.zwzz swizzling.
        /// </summary>
        public cvec4 zwzz => new cvec4(z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.zwzw swizzling.
        /// </summary>
        public cvec4 zwzw => new cvec4(z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.zww swizzling.
        /// </summary>
        public cvec3 zww => new cvec3(z, w, w);
        
        /// <summary>
        /// Returns cvec4.zwwx swizzling.
        /// </summary>
        public cvec4 zwwx => new cvec4(z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.zwwy swizzling.
        /// </summary>
        public cvec4 zwwy => new cvec4(z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.zwwz swizzling.
        /// </summary>
        public cvec4 zwwz => new cvec4(z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.zwww swizzling.
        /// </summary>
        public cvec4 zwww => new cvec4(z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.wx swizzling.
        /// </summary>
        public cvec2 wx => new cvec2(w, x);
        
        /// <summary>
        /// Returns cvec4.wxx swizzling.
        /// </summary>
        public cvec3 wxx => new cvec3(w, x, x);
        
        /// <summary>
        /// Returns cvec4.wxxx swizzling.
        /// </summary>
        public cvec4 wxxx => new cvec4(w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.wxxy swizzling.
        /// </summary>
        public cvec4 wxxy => new cvec4(w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.wxxz swizzling.
        /// </summary>
        public cvec4 wxxz => new cvec4(w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.wxxw swizzling.
        /// </summary>
        public cvec4 wxxw => new cvec4(w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.wxy swizzling.
        /// </summary>
        public cvec3 wxy => new cvec3(w, x, y);
        
        /// <summary>
        /// Returns cvec4.wxyx swizzling.
        /// </summary>
        public cvec4 wxyx => new cvec4(w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.wxyy swizzling.
        /// </summary>
        public cvec4 wxyy => new cvec4(w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.wxyz swizzling.
        /// </summary>
        public cvec4 wxyz => new cvec4(w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.wxyw swizzling.
        /// </summary>
        public cvec4 wxyw => new cvec4(w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.wxz swizzling.
        /// </summary>
        public cvec3 wxz => new cvec3(w, x, z);
        
        /// <summary>
        /// Returns cvec4.wxzx swizzling.
        /// </summary>
        public cvec4 wxzx => new cvec4(w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.wxzy swizzling.
        /// </summary>
        public cvec4 wxzy => new cvec4(w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.wxzz swizzling.
        /// </summary>
        public cvec4 wxzz => new cvec4(w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.wxzw swizzling.
        /// </summary>
        public cvec4 wxzw => new cvec4(w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.wxw swizzling.
        /// </summary>
        public cvec3 wxw => new cvec3(w, x, w);
        
        /// <summary>
        /// Returns cvec4.wxwx swizzling.
        /// </summary>
        public cvec4 wxwx => new cvec4(w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.wxwy swizzling.
        /// </summary>
        public cvec4 wxwy => new cvec4(w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.wxwz swizzling.
        /// </summary>
        public cvec4 wxwz => new cvec4(w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.wxww swizzling.
        /// </summary>
        public cvec4 wxww => new cvec4(w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.wy swizzling.
        /// </summary>
        public cvec2 wy => new cvec2(w, y);
        
        /// <summary>
        /// Returns cvec4.wyx swizzling.
        /// </summary>
        public cvec3 wyx => new cvec3(w, y, x);
        
        /// <summary>
        /// Returns cvec4.wyxx swizzling.
        /// </summary>
        public cvec4 wyxx => new cvec4(w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.wyxy swizzling.
        /// </summary>
        public cvec4 wyxy => new cvec4(w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.wyxz swizzling.
        /// </summary>
        public cvec4 wyxz => new cvec4(w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.wyxw swizzling.
        /// </summary>
        public cvec4 wyxw => new cvec4(w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.wyy swizzling.
        /// </summary>
        public cvec3 wyy => new cvec3(w, y, y);
        
        /// <summary>
        /// Returns cvec4.wyyx swizzling.
        /// </summary>
        public cvec4 wyyx => new cvec4(w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.wyyy swizzling.
        /// </summary>
        public cvec4 wyyy => new cvec4(w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.wyyz swizzling.
        /// </summary>
        public cvec4 wyyz => new cvec4(w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.wyyw swizzling.
        /// </summary>
        public cvec4 wyyw => new cvec4(w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.wyz swizzling.
        /// </summary>
        public cvec3 wyz => new cvec3(w, y, z);
        
        /// <summary>
        /// Returns cvec4.wyzx swizzling.
        /// </summary>
        public cvec4 wyzx => new cvec4(w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.wyzy swizzling.
        /// </summary>
        public cvec4 wyzy => new cvec4(w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.wyzz swizzling.
        /// </summary>
        public cvec4 wyzz => new cvec4(w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.wyzw swizzling.
        /// </summary>
        public cvec4 wyzw => new cvec4(w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.wyw swizzling.
        /// </summary>
        public cvec3 wyw => new cvec3(w, y, w);
        
        /// <summary>
        /// Returns cvec4.wywx swizzling.
        /// </summary>
        public cvec4 wywx => new cvec4(w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.wywy swizzling.
        /// </summary>
        public cvec4 wywy => new cvec4(w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.wywz swizzling.
        /// </summary>
        public cvec4 wywz => new cvec4(w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.wyww swizzling.
        /// </summary>
        public cvec4 wyww => new cvec4(w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.wz swizzling.
        /// </summary>
        public cvec2 wz => new cvec2(w, z);
        
        /// <summary>
        /// Returns cvec4.wzx swizzling.
        /// </summary>
        public cvec3 wzx => new cvec3(w, z, x);
        
        /// <summary>
        /// Returns cvec4.wzxx swizzling.
        /// </summary>
        public cvec4 wzxx => new cvec4(w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.wzxy swizzling.
        /// </summary>
        public cvec4 wzxy => new cvec4(w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.wzxz swizzling.
        /// </summary>
        public cvec4 wzxz => new cvec4(w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.wzxw swizzling.
        /// </summary>
        public cvec4 wzxw => new cvec4(w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.wzy swizzling.
        /// </summary>
        public cvec3 wzy => new cvec3(w, z, y);
        
        /// <summary>
        /// Returns cvec4.wzyx swizzling.
        /// </summary>
        public cvec4 wzyx => new cvec4(w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.wzyy swizzling.
        /// </summary>
        public cvec4 wzyy => new cvec4(w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.wzyz swizzling.
        /// </summary>
        public cvec4 wzyz => new cvec4(w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.wzyw swizzling.
        /// </summary>
        public cvec4 wzyw => new cvec4(w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.wzz swizzling.
        /// </summary>
        public cvec3 wzz => new cvec3(w, z, z);
        
        /// <summary>
        /// Returns cvec4.wzzx swizzling.
        /// </summary>
        public cvec4 wzzx => new cvec4(w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.wzzy swizzling.
        /// </summary>
        public cvec4 wzzy => new cvec4(w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.wzzz swizzling.
        /// </summary>
        public cvec4 wzzz => new cvec4(w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.wzzw swizzling.
        /// </summary>
        public cvec4 wzzw => new cvec4(w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.wzw swizzling.
        /// </summary>
        public cvec3 wzw => new cvec3(w, z, w);
        
        /// <summary>
        /// Returns cvec4.wzwx swizzling.
        /// </summary>
        public cvec4 wzwx => new cvec4(w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.wzwy swizzling.
        /// </summary>
        public cvec4 wzwy => new cvec4(w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.wzwz swizzling.
        /// </summary>
        public cvec4 wzwz => new cvec4(w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.wzww swizzling.
        /// </summary>
        public cvec4 wzww => new cvec4(w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.ww swizzling.
        /// </summary>
        public cvec2 ww => new cvec2(w, w);
        
        /// <summary>
        /// Returns cvec4.wwx swizzling.
        /// </summary>
        public cvec3 wwx => new cvec3(w, w, x);
        
        /// <summary>
        /// Returns cvec4.wwxx swizzling.
        /// </summary>
        public cvec4 wwxx => new cvec4(w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.wwxy swizzling.
        /// </summary>
        public cvec4 wwxy => new cvec4(w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.wwxz swizzling.
        /// </summary>
        public cvec4 wwxz => new cvec4(w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.wwxw swizzling.
        /// </summary>
        public cvec4 wwxw => new cvec4(w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.wwy swizzling.
        /// </summary>
        public cvec3 wwy => new cvec3(w, w, y);
        
        /// <summary>
        /// Returns cvec4.wwyx swizzling.
        /// </summary>
        public cvec4 wwyx => new cvec4(w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.wwyy swizzling.
        /// </summary>
        public cvec4 wwyy => new cvec4(w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.wwyz swizzling.
        /// </summary>
        public cvec4 wwyz => new cvec4(w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.wwyw swizzling.
        /// </summary>
        public cvec4 wwyw => new cvec4(w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.wwz swizzling.
        /// </summary>
        public cvec3 wwz => new cvec3(w, w, z);
        
        /// <summary>
        /// Returns cvec4.wwzx swizzling.
        /// </summary>
        public cvec4 wwzx => new cvec4(w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.wwzy swizzling.
        /// </summary>
        public cvec4 wwzy => new cvec4(w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.wwzz swizzling.
        /// </summary>
        public cvec4 wwzz => new cvec4(w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.wwzw swizzling.
        /// </summary>
        public cvec4 wwzw => new cvec4(w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.www swizzling.
        /// </summary>
        public cvec3 www => new cvec3(w, w, w);
        
        /// <summary>
        /// Returns cvec4.wwwx swizzling.
        /// </summary>
        public cvec4 wwwx => new cvec4(w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.wwwy swizzling.
        /// </summary>
        public cvec4 wwwy => new cvec4(w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.wwwz swizzling.
        /// </summary>
        public cvec4 wwwz => new cvec4(w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.wwww swizzling.
        /// </summary>
        public cvec4 wwww => new cvec4(w, w, w, w);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns cvec4.rr swizzling.
        /// </summary>
        public cvec2 rr => new cvec2(x, x);
        
        /// <summary>
        /// Returns cvec4.rrr swizzling.
        /// </summary>
        public cvec3 rrr => new cvec3(x, x, x);
        
        /// <summary>
        /// Returns cvec4.rrrr swizzling.
        /// </summary>
        public cvec4 rrrr => new cvec4(x, x, x, x);
        
        /// <summary>
        /// Returns cvec4.rrrg swizzling.
        /// </summary>
        public cvec4 rrrg => new cvec4(x, x, x, y);
        
        /// <summary>
        /// Returns cvec4.rrrb swizzling.
        /// </summary>
        public cvec4 rrrb => new cvec4(x, x, x, z);
        
        /// <summary>
        /// Returns cvec4.rrra swizzling.
        /// </summary>
        public cvec4 rrra => new cvec4(x, x, x, w);
        
        /// <summary>
        /// Returns cvec4.rrg swizzling.
        /// </summary>
        public cvec3 rrg => new cvec3(x, x, y);
        
        /// <summary>
        /// Returns cvec4.rrgr swizzling.
        /// </summary>
        public cvec4 rrgr => new cvec4(x, x, y, x);
        
        /// <summary>
        /// Returns cvec4.rrgg swizzling.
        /// </summary>
        public cvec4 rrgg => new cvec4(x, x, y, y);
        
        /// <summary>
        /// Returns cvec4.rrgb swizzling.
        /// </summary>
        public cvec4 rrgb => new cvec4(x, x, y, z);
        
        /// <summary>
        /// Returns cvec4.rrga swizzling.
        /// </summary>
        public cvec4 rrga => new cvec4(x, x, y, w);
        
        /// <summary>
        /// Returns cvec4.rrb swizzling.
        /// </summary>
        public cvec3 rrb => new cvec3(x, x, z);
        
        /// <summary>
        /// Returns cvec4.rrbr swizzling.
        /// </summary>
        public cvec4 rrbr => new cvec4(x, x, z, x);
        
        /// <summary>
        /// Returns cvec4.rrbg swizzling.
        /// </summary>
        public cvec4 rrbg => new cvec4(x, x, z, y);
        
        /// <summary>
        /// Returns cvec4.rrbb swizzling.
        /// </summary>
        public cvec4 rrbb => new cvec4(x, x, z, z);
        
        /// <summary>
        /// Returns cvec4.rrba swizzling.
        /// </summary>
        public cvec4 rrba => new cvec4(x, x, z, w);
        
        /// <summary>
        /// Returns cvec4.rra swizzling.
        /// </summary>
        public cvec3 rra => new cvec3(x, x, w);
        
        /// <summary>
        /// Returns cvec4.rrar swizzling.
        /// </summary>
        public cvec4 rrar => new cvec4(x, x, w, x);
        
        /// <summary>
        /// Returns cvec4.rrag swizzling.
        /// </summary>
        public cvec4 rrag => new cvec4(x, x, w, y);
        
        /// <summary>
        /// Returns cvec4.rrab swizzling.
        /// </summary>
        public cvec4 rrab => new cvec4(x, x, w, z);
        
        /// <summary>
        /// Returns cvec4.rraa swizzling.
        /// </summary>
        public cvec4 rraa => new cvec4(x, x, w, w);
        
        /// <summary>
        /// Returns cvec4.rg swizzling.
        /// </summary>
        public cvec2 rg => new cvec2(x, y);
        
        /// <summary>
        /// Returns cvec4.rgr swizzling.
        /// </summary>
        public cvec3 rgr => new cvec3(x, y, x);
        
        /// <summary>
        /// Returns cvec4.rgrr swizzling.
        /// </summary>
        public cvec4 rgrr => new cvec4(x, y, x, x);
        
        /// <summary>
        /// Returns cvec4.rgrg swizzling.
        /// </summary>
        public cvec4 rgrg => new cvec4(x, y, x, y);
        
        /// <summary>
        /// Returns cvec4.rgrb swizzling.
        /// </summary>
        public cvec4 rgrb => new cvec4(x, y, x, z);
        
        /// <summary>
        /// Returns cvec4.rgra swizzling.
        /// </summary>
        public cvec4 rgra => new cvec4(x, y, x, w);
        
        /// <summary>
        /// Returns cvec4.rgg swizzling.
        /// </summary>
        public cvec3 rgg => new cvec3(x, y, y);
        
        /// <summary>
        /// Returns cvec4.rggr swizzling.
        /// </summary>
        public cvec4 rggr => new cvec4(x, y, y, x);
        
        /// <summary>
        /// Returns cvec4.rggg swizzling.
        /// </summary>
        public cvec4 rggg => new cvec4(x, y, y, y);
        
        /// <summary>
        /// Returns cvec4.rggb swizzling.
        /// </summary>
        public cvec4 rggb => new cvec4(x, y, y, z);
        
        /// <summary>
        /// Returns cvec4.rgga swizzling.
        /// </summary>
        public cvec4 rgga => new cvec4(x, y, y, w);
        
        /// <summary>
        /// Returns cvec4.rgb swizzling.
        /// </summary>
        public cvec3 rgb => new cvec3(x, y, z);
        
        /// <summary>
        /// Returns cvec4.rgbr swizzling.
        /// </summary>
        public cvec4 rgbr => new cvec4(x, y, z, x);
        
        /// <summary>
        /// Returns cvec4.rgbg swizzling.
        /// </summary>
        public cvec4 rgbg => new cvec4(x, y, z, y);
        
        /// <summary>
        /// Returns cvec4.rgbb swizzling.
        /// </summary>
        public cvec4 rgbb => new cvec4(x, y, z, z);
        
        /// <summary>
        /// Returns cvec4.rgba swizzling.
        /// </summary>
        public cvec4 rgba => new cvec4(x, y, z, w);
        
        /// <summary>
        /// Returns cvec4.rga swizzling.
        /// </summary>
        public cvec3 rga => new cvec3(x, y, w);
        
        /// <summary>
        /// Returns cvec4.rgar swizzling.
        /// </summary>
        public cvec4 rgar => new cvec4(x, y, w, x);
        
        /// <summary>
        /// Returns cvec4.rgag swizzling.
        /// </summary>
        public cvec4 rgag => new cvec4(x, y, w, y);
        
        /// <summary>
        /// Returns cvec4.rgab swizzling.
        /// </summary>
        public cvec4 rgab => new cvec4(x, y, w, z);
        
        /// <summary>
        /// Returns cvec4.rgaa swizzling.
        /// </summary>
        public cvec4 rgaa => new cvec4(x, y, w, w);
        
        /// <summary>
        /// Returns cvec4.rb swizzling.
        /// </summary>
        public cvec2 rb => new cvec2(x, z);
        
        /// <summary>
        /// Returns cvec4.rbr swizzling.
        /// </summary>
        public cvec3 rbr => new cvec3(x, z, x);
        
        /// <summary>
        /// Returns cvec4.rbrr swizzling.
        /// </summary>
        public cvec4 rbrr => new cvec4(x, z, x, x);
        
        /// <summary>
        /// Returns cvec4.rbrg swizzling.
        /// </summary>
        public cvec4 rbrg => new cvec4(x, z, x, y);
        
        /// <summary>
        /// Returns cvec4.rbrb swizzling.
        /// </summary>
        public cvec4 rbrb => new cvec4(x, z, x, z);
        
        /// <summary>
        /// Returns cvec4.rbra swizzling.
        /// </summary>
        public cvec4 rbra => new cvec4(x, z, x, w);
        
        /// <summary>
        /// Returns cvec4.rbg swizzling.
        /// </summary>
        public cvec3 rbg => new cvec3(x, z, y);
        
        /// <summary>
        /// Returns cvec4.rbgr swizzling.
        /// </summary>
        public cvec4 rbgr => new cvec4(x, z, y, x);
        
        /// <summary>
        /// Returns cvec4.rbgg swizzling.
        /// </summary>
        public cvec4 rbgg => new cvec4(x, z, y, y);
        
        /// <summary>
        /// Returns cvec4.rbgb swizzling.
        /// </summary>
        public cvec4 rbgb => new cvec4(x, z, y, z);
        
        /// <summary>
        /// Returns cvec4.rbga swizzling.
        /// </summary>
        public cvec4 rbga => new cvec4(x, z, y, w);
        
        /// <summary>
        /// Returns cvec4.rbb swizzling.
        /// </summary>
        public cvec3 rbb => new cvec3(x, z, z);
        
        /// <summary>
        /// Returns cvec4.rbbr swizzling.
        /// </summary>
        public cvec4 rbbr => new cvec4(x, z, z, x);
        
        /// <summary>
        /// Returns cvec4.rbbg swizzling.
        /// </summary>
        public cvec4 rbbg => new cvec4(x, z, z, y);
        
        /// <summary>
        /// Returns cvec4.rbbb swizzling.
        /// </summary>
        public cvec4 rbbb => new cvec4(x, z, z, z);
        
        /// <summary>
        /// Returns cvec4.rbba swizzling.
        /// </summary>
        public cvec4 rbba => new cvec4(x, z, z, w);
        
        /// <summary>
        /// Returns cvec4.rba swizzling.
        /// </summary>
        public cvec3 rba => new cvec3(x, z, w);
        
        /// <summary>
        /// Returns cvec4.rbar swizzling.
        /// </summary>
        public cvec4 rbar => new cvec4(x, z, w, x);
        
        /// <summary>
        /// Returns cvec4.rbag swizzling.
        /// </summary>
        public cvec4 rbag => new cvec4(x, z, w, y);
        
        /// <summary>
        /// Returns cvec4.rbab swizzling.
        /// </summary>
        public cvec4 rbab => new cvec4(x, z, w, z);
        
        /// <summary>
        /// Returns cvec4.rbaa swizzling.
        /// </summary>
        public cvec4 rbaa => new cvec4(x, z, w, w);
        
        /// <summary>
        /// Returns cvec4.ra swizzling.
        /// </summary>
        public cvec2 ra => new cvec2(x, w);
        
        /// <summary>
        /// Returns cvec4.rar swizzling.
        /// </summary>
        public cvec3 rar => new cvec3(x, w, x);
        
        /// <summary>
        /// Returns cvec4.rarr swizzling.
        /// </summary>
        public cvec4 rarr => new cvec4(x, w, x, x);
        
        /// <summary>
        /// Returns cvec4.rarg swizzling.
        /// </summary>
        public cvec4 rarg => new cvec4(x, w, x, y);
        
        /// <summary>
        /// Returns cvec4.rarb swizzling.
        /// </summary>
        public cvec4 rarb => new cvec4(x, w, x, z);
        
        /// <summary>
        /// Returns cvec4.rara swizzling.
        /// </summary>
        public cvec4 rara => new cvec4(x, w, x, w);
        
        /// <summary>
        /// Returns cvec4.rag swizzling.
        /// </summary>
        public cvec3 rag => new cvec3(x, w, y);
        
        /// <summary>
        /// Returns cvec4.ragr swizzling.
        /// </summary>
        public cvec4 ragr => new cvec4(x, w, y, x);
        
        /// <summary>
        /// Returns cvec4.ragg swizzling.
        /// </summary>
        public cvec4 ragg => new cvec4(x, w, y, y);
        
        /// <summary>
        /// Returns cvec4.ragb swizzling.
        /// </summary>
        public cvec4 ragb => new cvec4(x, w, y, z);
        
        /// <summary>
        /// Returns cvec4.raga swizzling.
        /// </summary>
        public cvec4 raga => new cvec4(x, w, y, w);
        
        /// <summary>
        /// Returns cvec4.rab swizzling.
        /// </summary>
        public cvec3 rab => new cvec3(x, w, z);
        
        /// <summary>
        /// Returns cvec4.rabr swizzling.
        /// </summary>
        public cvec4 rabr => new cvec4(x, w, z, x);
        
        /// <summary>
        /// Returns cvec4.rabg swizzling.
        /// </summary>
        public cvec4 rabg => new cvec4(x, w, z, y);
        
        /// <summary>
        /// Returns cvec4.rabb swizzling.
        /// </summary>
        public cvec4 rabb => new cvec4(x, w, z, z);
        
        /// <summary>
        /// Returns cvec4.raba swizzling.
        /// </summary>
        public cvec4 raba => new cvec4(x, w, z, w);
        
        /// <summary>
        /// Returns cvec4.raa swizzling.
        /// </summary>
        public cvec3 raa => new cvec3(x, w, w);
        
        /// <summary>
        /// Returns cvec4.raar swizzling.
        /// </summary>
        public cvec4 raar => new cvec4(x, w, w, x);
        
        /// <summary>
        /// Returns cvec4.raag swizzling.
        /// </summary>
        public cvec4 raag => new cvec4(x, w, w, y);
        
        /// <summary>
        /// Returns cvec4.raab swizzling.
        /// </summary>
        public cvec4 raab => new cvec4(x, w, w, z);
        
        /// <summary>
        /// Returns cvec4.raaa swizzling.
        /// </summary>
        public cvec4 raaa => new cvec4(x, w, w, w);
        
        /// <summary>
        /// Returns cvec4.gr swizzling.
        /// </summary>
        public cvec2 gr => new cvec2(y, x);
        
        /// <summary>
        /// Returns cvec4.grr swizzling.
        /// </summary>
        public cvec3 grr => new cvec3(y, x, x);
        
        /// <summary>
        /// Returns cvec4.grrr swizzling.
        /// </summary>
        public cvec4 grrr => new cvec4(y, x, x, x);
        
        /// <summary>
        /// Returns cvec4.grrg swizzling.
        /// </summary>
        public cvec4 grrg => new cvec4(y, x, x, y);
        
        /// <summary>
        /// Returns cvec4.grrb swizzling.
        /// </summary>
        public cvec4 grrb => new cvec4(y, x, x, z);
        
        /// <summary>
        /// Returns cvec4.grra swizzling.
        /// </summary>
        public cvec4 grra => new cvec4(y, x, x, w);
        
        /// <summary>
        /// Returns cvec4.grg swizzling.
        /// </summary>
        public cvec3 grg => new cvec3(y, x, y);
        
        /// <summary>
        /// Returns cvec4.grgr swizzling.
        /// </summary>
        public cvec4 grgr => new cvec4(y, x, y, x);
        
        /// <summary>
        /// Returns cvec4.grgg swizzling.
        /// </summary>
        public cvec4 grgg => new cvec4(y, x, y, y);
        
        /// <summary>
        /// Returns cvec4.grgb swizzling.
        /// </summary>
        public cvec4 grgb => new cvec4(y, x, y, z);
        
        /// <summary>
        /// Returns cvec4.grga swizzling.
        /// </summary>
        public cvec4 grga => new cvec4(y, x, y, w);
        
        /// <summary>
        /// Returns cvec4.grb swizzling.
        /// </summary>
        public cvec3 grb => new cvec3(y, x, z);
        
        /// <summary>
        /// Returns cvec4.grbr swizzling.
        /// </summary>
        public cvec4 grbr => new cvec4(y, x, z, x);
        
        /// <summary>
        /// Returns cvec4.grbg swizzling.
        /// </summary>
        public cvec4 grbg => new cvec4(y, x, z, y);
        
        /// <summary>
        /// Returns cvec4.grbb swizzling.
        /// </summary>
        public cvec4 grbb => new cvec4(y, x, z, z);
        
        /// <summary>
        /// Returns cvec4.grba swizzling.
        /// </summary>
        public cvec4 grba => new cvec4(y, x, z, w);
        
        /// <summary>
        /// Returns cvec4.gra swizzling.
        /// </summary>
        public cvec3 gra => new cvec3(y, x, w);
        
        /// <summary>
        /// Returns cvec4.grar swizzling.
        /// </summary>
        public cvec4 grar => new cvec4(y, x, w, x);
        
        /// <summary>
        /// Returns cvec4.grag swizzling.
        /// </summary>
        public cvec4 grag => new cvec4(y, x, w, y);
        
        /// <summary>
        /// Returns cvec4.grab swizzling.
        /// </summary>
        public cvec4 grab => new cvec4(y, x, w, z);
        
        /// <summary>
        /// Returns cvec4.graa swizzling.
        /// </summary>
        public cvec4 graa => new cvec4(y, x, w, w);
        
        /// <summary>
        /// Returns cvec4.gg swizzling.
        /// </summary>
        public cvec2 gg => new cvec2(y, y);
        
        /// <summary>
        /// Returns cvec4.ggr swizzling.
        /// </summary>
        public cvec3 ggr => new cvec3(y, y, x);
        
        /// <summary>
        /// Returns cvec4.ggrr swizzling.
        /// </summary>
        public cvec4 ggrr => new cvec4(y, y, x, x);
        
        /// <summary>
        /// Returns cvec4.ggrg swizzling.
        /// </summary>
        public cvec4 ggrg => new cvec4(y, y, x, y);
        
        /// <summary>
        /// Returns cvec4.ggrb swizzling.
        /// </summary>
        public cvec4 ggrb => new cvec4(y, y, x, z);
        
        /// <summary>
        /// Returns cvec4.ggra swizzling.
        /// </summary>
        public cvec4 ggra => new cvec4(y, y, x, w);
        
        /// <summary>
        /// Returns cvec4.ggg swizzling.
        /// </summary>
        public cvec3 ggg => new cvec3(y, y, y);
        
        /// <summary>
        /// Returns cvec4.gggr swizzling.
        /// </summary>
        public cvec4 gggr => new cvec4(y, y, y, x);
        
        /// <summary>
        /// Returns cvec4.gggg swizzling.
        /// </summary>
        public cvec4 gggg => new cvec4(y, y, y, y);
        
        /// <summary>
        /// Returns cvec4.gggb swizzling.
        /// </summary>
        public cvec4 gggb => new cvec4(y, y, y, z);
        
        /// <summary>
        /// Returns cvec4.ggga swizzling.
        /// </summary>
        public cvec4 ggga => new cvec4(y, y, y, w);
        
        /// <summary>
        /// Returns cvec4.ggb swizzling.
        /// </summary>
        public cvec3 ggb => new cvec3(y, y, z);
        
        /// <summary>
        /// Returns cvec4.ggbr swizzling.
        /// </summary>
        public cvec4 ggbr => new cvec4(y, y, z, x);
        
        /// <summary>
        /// Returns cvec4.ggbg swizzling.
        /// </summary>
        public cvec4 ggbg => new cvec4(y, y, z, y);
        
        /// <summary>
        /// Returns cvec4.ggbb swizzling.
        /// </summary>
        public cvec4 ggbb => new cvec4(y, y, z, z);
        
        /// <summary>
        /// Returns cvec4.ggba swizzling.
        /// </summary>
        public cvec4 ggba => new cvec4(y, y, z, w);
        
        /// <summary>
        /// Returns cvec4.gga swizzling.
        /// </summary>
        public cvec3 gga => new cvec3(y, y, w);
        
        /// <summary>
        /// Returns cvec4.ggar swizzling.
        /// </summary>
        public cvec4 ggar => new cvec4(y, y, w, x);
        
        /// <summary>
        /// Returns cvec4.ggag swizzling.
        /// </summary>
        public cvec4 ggag => new cvec4(y, y, w, y);
        
        /// <summary>
        /// Returns cvec4.ggab swizzling.
        /// </summary>
        public cvec4 ggab => new cvec4(y, y, w, z);
        
        /// <summary>
        /// Returns cvec4.ggaa swizzling.
        /// </summary>
        public cvec4 ggaa => new cvec4(y, y, w, w);
        
        /// <summary>
        /// Returns cvec4.gb swizzling.
        /// </summary>
        public cvec2 gb => new cvec2(y, z);
        
        /// <summary>
        /// Returns cvec4.gbr swizzling.
        /// </summary>
        public cvec3 gbr => new cvec3(y, z, x);
        
        /// <summary>
        /// Returns cvec4.gbrr swizzling.
        /// </summary>
        public cvec4 gbrr => new cvec4(y, z, x, x);
        
        /// <summary>
        /// Returns cvec4.gbrg swizzling.
        /// </summary>
        public cvec4 gbrg => new cvec4(y, z, x, y);
        
        /// <summary>
        /// Returns cvec4.gbrb swizzling.
        /// </summary>
        public cvec4 gbrb => new cvec4(y, z, x, z);
        
        /// <summary>
        /// Returns cvec4.gbra swizzling.
        /// </summary>
        public cvec4 gbra => new cvec4(y, z, x, w);
        
        /// <summary>
        /// Returns cvec4.gbg swizzling.
        /// </summary>
        public cvec3 gbg => new cvec3(y, z, y);
        
        /// <summary>
        /// Returns cvec4.gbgr swizzling.
        /// </summary>
        public cvec4 gbgr => new cvec4(y, z, y, x);
        
        /// <summary>
        /// Returns cvec4.gbgg swizzling.
        /// </summary>
        public cvec4 gbgg => new cvec4(y, z, y, y);
        
        /// <summary>
        /// Returns cvec4.gbgb swizzling.
        /// </summary>
        public cvec4 gbgb => new cvec4(y, z, y, z);
        
        /// <summary>
        /// Returns cvec4.gbga swizzling.
        /// </summary>
        public cvec4 gbga => new cvec4(y, z, y, w);
        
        /// <summary>
        /// Returns cvec4.gbb swizzling.
        /// </summary>
        public cvec3 gbb => new cvec3(y, z, z);
        
        /// <summary>
        /// Returns cvec4.gbbr swizzling.
        /// </summary>
        public cvec4 gbbr => new cvec4(y, z, z, x);
        
        /// <summary>
        /// Returns cvec4.gbbg swizzling.
        /// </summary>
        public cvec4 gbbg => new cvec4(y, z, z, y);
        
        /// <summary>
        /// Returns cvec4.gbbb swizzling.
        /// </summary>
        public cvec4 gbbb => new cvec4(y, z, z, z);
        
        /// <summary>
        /// Returns cvec4.gbba swizzling.
        /// </summary>
        public cvec4 gbba => new cvec4(y, z, z, w);
        
        /// <summary>
        /// Returns cvec4.gba swizzling.
        /// </summary>
        public cvec3 gba => new cvec3(y, z, w);
        
        /// <summary>
        /// Returns cvec4.gbar swizzling.
        /// </summary>
        public cvec4 gbar => new cvec4(y, z, w, x);
        
        /// <summary>
        /// Returns cvec4.gbag swizzling.
        /// </summary>
        public cvec4 gbag => new cvec4(y, z, w, y);
        
        /// <summary>
        /// Returns cvec4.gbab swizzling.
        /// </summary>
        public cvec4 gbab => new cvec4(y, z, w, z);
        
        /// <summary>
        /// Returns cvec4.gbaa swizzling.
        /// </summary>
        public cvec4 gbaa => new cvec4(y, z, w, w);
        
        /// <summary>
        /// Returns cvec4.ga swizzling.
        /// </summary>
        public cvec2 ga => new cvec2(y, w);
        
        /// <summary>
        /// Returns cvec4.gar swizzling.
        /// </summary>
        public cvec3 gar => new cvec3(y, w, x);
        
        /// <summary>
        /// Returns cvec4.garr swizzling.
        /// </summary>
        public cvec4 garr => new cvec4(y, w, x, x);
        
        /// <summary>
        /// Returns cvec4.garg swizzling.
        /// </summary>
        public cvec4 garg => new cvec4(y, w, x, y);
        
        /// <summary>
        /// Returns cvec4.garb swizzling.
        /// </summary>
        public cvec4 garb => new cvec4(y, w, x, z);
        
        /// <summary>
        /// Returns cvec4.gara swizzling.
        /// </summary>
        public cvec4 gara => new cvec4(y, w, x, w);
        
        /// <summary>
        /// Returns cvec4.gag swizzling.
        /// </summary>
        public cvec3 gag => new cvec3(y, w, y);
        
        /// <summary>
        /// Returns cvec4.gagr swizzling.
        /// </summary>
        public cvec4 gagr => new cvec4(y, w, y, x);
        
        /// <summary>
        /// Returns cvec4.gagg swizzling.
        /// </summary>
        public cvec4 gagg => new cvec4(y, w, y, y);
        
        /// <summary>
        /// Returns cvec4.gagb swizzling.
        /// </summary>
        public cvec4 gagb => new cvec4(y, w, y, z);
        
        /// <summary>
        /// Returns cvec4.gaga swizzling.
        /// </summary>
        public cvec4 gaga => new cvec4(y, w, y, w);
        
        /// <summary>
        /// Returns cvec4.gab swizzling.
        /// </summary>
        public cvec3 gab => new cvec3(y, w, z);
        
        /// <summary>
        /// Returns cvec4.gabr swizzling.
        /// </summary>
        public cvec4 gabr => new cvec4(y, w, z, x);
        
        /// <summary>
        /// Returns cvec4.gabg swizzling.
        /// </summary>
        public cvec4 gabg => new cvec4(y, w, z, y);
        
        /// <summary>
        /// Returns cvec4.gabb swizzling.
        /// </summary>
        public cvec4 gabb => new cvec4(y, w, z, z);
        
        /// <summary>
        /// Returns cvec4.gaba swizzling.
        /// </summary>
        public cvec4 gaba => new cvec4(y, w, z, w);
        
        /// <summary>
        /// Returns cvec4.gaa swizzling.
        /// </summary>
        public cvec3 gaa => new cvec3(y, w, w);
        
        /// <summary>
        /// Returns cvec4.gaar swizzling.
        /// </summary>
        public cvec4 gaar => new cvec4(y, w, w, x);
        
        /// <summary>
        /// Returns cvec4.gaag swizzling.
        /// </summary>
        public cvec4 gaag => new cvec4(y, w, w, y);
        
        /// <summary>
        /// Returns cvec4.gaab swizzling.
        /// </summary>
        public cvec4 gaab => new cvec4(y, w, w, z);
        
        /// <summary>
        /// Returns cvec4.gaaa swizzling.
        /// </summary>
        public cvec4 gaaa => new cvec4(y, w, w, w);
        
        /// <summary>
        /// Returns cvec4.br swizzling.
        /// </summary>
        public cvec2 br => new cvec2(z, x);
        
        /// <summary>
        /// Returns cvec4.brr swizzling.
        /// </summary>
        public cvec3 brr => new cvec3(z, x, x);
        
        /// <summary>
        /// Returns cvec4.brrr swizzling.
        /// </summary>
        public cvec4 brrr => new cvec4(z, x, x, x);
        
        /// <summary>
        /// Returns cvec4.brrg swizzling.
        /// </summary>
        public cvec4 brrg => new cvec4(z, x, x, y);
        
        /// <summary>
        /// Returns cvec4.brrb swizzling.
        /// </summary>
        public cvec4 brrb => new cvec4(z, x, x, z);
        
        /// <summary>
        /// Returns cvec4.brra swizzling.
        /// </summary>
        public cvec4 brra => new cvec4(z, x, x, w);
        
        /// <summary>
        /// Returns cvec4.brg swizzling.
        /// </summary>
        public cvec3 brg => new cvec3(z, x, y);
        
        /// <summary>
        /// Returns cvec4.brgr swizzling.
        /// </summary>
        public cvec4 brgr => new cvec4(z, x, y, x);
        
        /// <summary>
        /// Returns cvec4.brgg swizzling.
        /// </summary>
        public cvec4 brgg => new cvec4(z, x, y, y);
        
        /// <summary>
        /// Returns cvec4.brgb swizzling.
        /// </summary>
        public cvec4 brgb => new cvec4(z, x, y, z);
        
        /// <summary>
        /// Returns cvec4.brga swizzling.
        /// </summary>
        public cvec4 brga => new cvec4(z, x, y, w);
        
        /// <summary>
        /// Returns cvec4.brb swizzling.
        /// </summary>
        public cvec3 brb => new cvec3(z, x, z);
        
        /// <summary>
        /// Returns cvec4.brbr swizzling.
        /// </summary>
        public cvec4 brbr => new cvec4(z, x, z, x);
        
        /// <summary>
        /// Returns cvec4.brbg swizzling.
        /// </summary>
        public cvec4 brbg => new cvec4(z, x, z, y);
        
        /// <summary>
        /// Returns cvec4.brbb swizzling.
        /// </summary>
        public cvec4 brbb => new cvec4(z, x, z, z);
        
        /// <summary>
        /// Returns cvec4.brba swizzling.
        /// </summary>
        public cvec4 brba => new cvec4(z, x, z, w);
        
        /// <summary>
        /// Returns cvec4.bra swizzling.
        /// </summary>
        public cvec3 bra => new cvec3(z, x, w);
        
        /// <summary>
        /// Returns cvec4.brar swizzling.
        /// </summary>
        public cvec4 brar => new cvec4(z, x, w, x);
        
        /// <summary>
        /// Returns cvec4.brag swizzling.
        /// </summary>
        public cvec4 brag => new cvec4(z, x, w, y);
        
        /// <summary>
        /// Returns cvec4.brab swizzling.
        /// </summary>
        public cvec4 brab => new cvec4(z, x, w, z);
        
        /// <summary>
        /// Returns cvec4.braa swizzling.
        /// </summary>
        public cvec4 braa => new cvec4(z, x, w, w);
        
        /// <summary>
        /// Returns cvec4.bg swizzling.
        /// </summary>
        public cvec2 bg => new cvec2(z, y);
        
        /// <summary>
        /// Returns cvec4.bgr swizzling.
        /// </summary>
        public cvec3 bgr => new cvec3(z, y, x);
        
        /// <summary>
        /// Returns cvec4.bgrr swizzling.
        /// </summary>
        public cvec4 bgrr => new cvec4(z, y, x, x);
        
        /// <summary>
        /// Returns cvec4.bgrg swizzling.
        /// </summary>
        public cvec4 bgrg => new cvec4(z, y, x, y);
        
        /// <summary>
        /// Returns cvec4.bgrb swizzling.
        /// </summary>
        public cvec4 bgrb => new cvec4(z, y, x, z);
        
        /// <summary>
        /// Returns cvec4.bgra swizzling.
        /// </summary>
        public cvec4 bgra => new cvec4(z, y, x, w);
        
        /// <summary>
        /// Returns cvec4.bgg swizzling.
        /// </summary>
        public cvec3 bgg => new cvec3(z, y, y);
        
        /// <summary>
        /// Returns cvec4.bggr swizzling.
        /// </summary>
        public cvec4 bggr => new cvec4(z, y, y, x);
        
        /// <summary>
        /// Returns cvec4.bggg swizzling.
        /// </summary>
        public cvec4 bggg => new cvec4(z, y, y, y);
        
        /// <summary>
        /// Returns cvec4.bggb swizzling.
        /// </summary>
        public cvec4 bggb => new cvec4(z, y, y, z);
        
        /// <summary>
        /// Returns cvec4.bgga swizzling.
        /// </summary>
        public cvec4 bgga => new cvec4(z, y, y, w);
        
        /// <summary>
        /// Returns cvec4.bgb swizzling.
        /// </summary>
        public cvec3 bgb => new cvec3(z, y, z);
        
        /// <summary>
        /// Returns cvec4.bgbr swizzling.
        /// </summary>
        public cvec4 bgbr => new cvec4(z, y, z, x);
        
        /// <summary>
        /// Returns cvec4.bgbg swizzling.
        /// </summary>
        public cvec4 bgbg => new cvec4(z, y, z, y);
        
        /// <summary>
        /// Returns cvec4.bgbb swizzling.
        /// </summary>
        public cvec4 bgbb => new cvec4(z, y, z, z);
        
        /// <summary>
        /// Returns cvec4.bgba swizzling.
        /// </summary>
        public cvec4 bgba => new cvec4(z, y, z, w);
        
        /// <summary>
        /// Returns cvec4.bga swizzling.
        /// </summary>
        public cvec3 bga => new cvec3(z, y, w);
        
        /// <summary>
        /// Returns cvec4.bgar swizzling.
        /// </summary>
        public cvec4 bgar => new cvec4(z, y, w, x);
        
        /// <summary>
        /// Returns cvec4.bgag swizzling.
        /// </summary>
        public cvec4 bgag => new cvec4(z, y, w, y);
        
        /// <summary>
        /// Returns cvec4.bgab swizzling.
        /// </summary>
        public cvec4 bgab => new cvec4(z, y, w, z);
        
        /// <summary>
        /// Returns cvec4.bgaa swizzling.
        /// </summary>
        public cvec4 bgaa => new cvec4(z, y, w, w);
        
        /// <summary>
        /// Returns cvec4.bb swizzling.
        /// </summary>
        public cvec2 bb => new cvec2(z, z);
        
        /// <summary>
        /// Returns cvec4.bbr swizzling.
        /// </summary>
        public cvec3 bbr => new cvec3(z, z, x);
        
        /// <summary>
        /// Returns cvec4.bbrr swizzling.
        /// </summary>
        public cvec4 bbrr => new cvec4(z, z, x, x);
        
        /// <summary>
        /// Returns cvec4.bbrg swizzling.
        /// </summary>
        public cvec4 bbrg => new cvec4(z, z, x, y);
        
        /// <summary>
        /// Returns cvec4.bbrb swizzling.
        /// </summary>
        public cvec4 bbrb => new cvec4(z, z, x, z);
        
        /// <summary>
        /// Returns cvec4.bbra swizzling.
        /// </summary>
        public cvec4 bbra => new cvec4(z, z, x, w);
        
        /// <summary>
        /// Returns cvec4.bbg swizzling.
        /// </summary>
        public cvec3 bbg => new cvec3(z, z, y);
        
        /// <summary>
        /// Returns cvec4.bbgr swizzling.
        /// </summary>
        public cvec4 bbgr => new cvec4(z, z, y, x);
        
        /// <summary>
        /// Returns cvec4.bbgg swizzling.
        /// </summary>
        public cvec4 bbgg => new cvec4(z, z, y, y);
        
        /// <summary>
        /// Returns cvec4.bbgb swizzling.
        /// </summary>
        public cvec4 bbgb => new cvec4(z, z, y, z);
        
        /// <summary>
        /// Returns cvec4.bbga swizzling.
        /// </summary>
        public cvec4 bbga => new cvec4(z, z, y, w);
        
        /// <summary>
        /// Returns cvec4.bbb swizzling.
        /// </summary>
        public cvec3 bbb => new cvec3(z, z, z);
        
        /// <summary>
        /// Returns cvec4.bbbr swizzling.
        /// </summary>
        public cvec4 bbbr => new cvec4(z, z, z, x);
        
        /// <summary>
        /// Returns cvec4.bbbg swizzling.
        /// </summary>
        public cvec4 bbbg => new cvec4(z, z, z, y);
        
        /// <summary>
        /// Returns cvec4.bbbb swizzling.
        /// </summary>
        public cvec4 bbbb => new cvec4(z, z, z, z);
        
        /// <summary>
        /// Returns cvec4.bbba swizzling.
        /// </summary>
        public cvec4 bbba => new cvec4(z, z, z, w);
        
        /// <summary>
        /// Returns cvec4.bba swizzling.
        /// </summary>
        public cvec3 bba => new cvec3(z, z, w);
        
        /// <summary>
        /// Returns cvec4.bbar swizzling.
        /// </summary>
        public cvec4 bbar => new cvec4(z, z, w, x);
        
        /// <summary>
        /// Returns cvec4.bbag swizzling.
        /// </summary>
        public cvec4 bbag => new cvec4(z, z, w, y);
        
        /// <summary>
        /// Returns cvec4.bbab swizzling.
        /// </summary>
        public cvec4 bbab => new cvec4(z, z, w, z);
        
        /// <summary>
        /// Returns cvec4.bbaa swizzling.
        /// </summary>
        public cvec4 bbaa => new cvec4(z, z, w, w);
        
        /// <summary>
        /// Returns cvec4.ba swizzling.
        /// </summary>
        public cvec2 ba => new cvec2(z, w);
        
        /// <summary>
        /// Returns cvec4.bar swizzling.
        /// </summary>
        public cvec3 bar => new cvec3(z, w, x);
        
        /// <summary>
        /// Returns cvec4.barr swizzling.
        /// </summary>
        public cvec4 barr => new cvec4(z, w, x, x);
        
        /// <summary>
        /// Returns cvec4.barg swizzling.
        /// </summary>
        public cvec4 barg => new cvec4(z, w, x, y);
        
        /// <summary>
        /// Returns cvec4.barb swizzling.
        /// </summary>
        public cvec4 barb => new cvec4(z, w, x, z);
        
        /// <summary>
        /// Returns cvec4.bara swizzling.
        /// </summary>
        public cvec4 bara => new cvec4(z, w, x, w);
        
        /// <summary>
        /// Returns cvec4.bag swizzling.
        /// </summary>
        public cvec3 bag => new cvec3(z, w, y);
        
        /// <summary>
        /// Returns cvec4.bagr swizzling.
        /// </summary>
        public cvec4 bagr => new cvec4(z, w, y, x);
        
        /// <summary>
        /// Returns cvec4.bagg swizzling.
        /// </summary>
        public cvec4 bagg => new cvec4(z, w, y, y);
        
        /// <summary>
        /// Returns cvec4.bagb swizzling.
        /// </summary>
        public cvec4 bagb => new cvec4(z, w, y, z);
        
        /// <summary>
        /// Returns cvec4.baga swizzling.
        /// </summary>
        public cvec4 baga => new cvec4(z, w, y, w);
        
        /// <summary>
        /// Returns cvec4.bab swizzling.
        /// </summary>
        public cvec3 bab => new cvec3(z, w, z);
        
        /// <summary>
        /// Returns cvec4.babr swizzling.
        /// </summary>
        public cvec4 babr => new cvec4(z, w, z, x);
        
        /// <summary>
        /// Returns cvec4.babg swizzling.
        /// </summary>
        public cvec4 babg => new cvec4(z, w, z, y);
        
        /// <summary>
        /// Returns cvec4.babb swizzling.
        /// </summary>
        public cvec4 babb => new cvec4(z, w, z, z);
        
        /// <summary>
        /// Returns cvec4.baba swizzling.
        /// </summary>
        public cvec4 baba => new cvec4(z, w, z, w);
        
        /// <summary>
        /// Returns cvec4.baa swizzling.
        /// </summary>
        public cvec3 baa => new cvec3(z, w, w);
        
        /// <summary>
        /// Returns cvec4.baar swizzling.
        /// </summary>
        public cvec4 baar => new cvec4(z, w, w, x);
        
        /// <summary>
        /// Returns cvec4.baag swizzling.
        /// </summary>
        public cvec4 baag => new cvec4(z, w, w, y);
        
        /// <summary>
        /// Returns cvec4.baab swizzling.
        /// </summary>
        public cvec4 baab => new cvec4(z, w, w, z);
        
        /// <summary>
        /// Returns cvec4.baaa swizzling.
        /// </summary>
        public cvec4 baaa => new cvec4(z, w, w, w);
        
        /// <summary>
        /// Returns cvec4.ar swizzling.
        /// </summary>
        public cvec2 ar => new cvec2(w, x);
        
        /// <summary>
        /// Returns cvec4.arr swizzling.
        /// </summary>
        public cvec3 arr => new cvec3(w, x, x);
        
        /// <summary>
        /// Returns cvec4.arrr swizzling.
        /// </summary>
        public cvec4 arrr => new cvec4(w, x, x, x);
        
        /// <summary>
        /// Returns cvec4.arrg swizzling.
        /// </summary>
        public cvec4 arrg => new cvec4(w, x, x, y);
        
        /// <summary>
        /// Returns cvec4.arrb swizzling.
        /// </summary>
        public cvec4 arrb => new cvec4(w, x, x, z);
        
        /// <summary>
        /// Returns cvec4.arra swizzling.
        /// </summary>
        public cvec4 arra => new cvec4(w, x, x, w);
        
        /// <summary>
        /// Returns cvec4.arg swizzling.
        /// </summary>
        public cvec3 arg => new cvec3(w, x, y);
        
        /// <summary>
        /// Returns cvec4.argr swizzling.
        /// </summary>
        public cvec4 argr => new cvec4(w, x, y, x);
        
        /// <summary>
        /// Returns cvec4.argg swizzling.
        /// </summary>
        public cvec4 argg => new cvec4(w, x, y, y);
        
        /// <summary>
        /// Returns cvec4.argb swizzling.
        /// </summary>
        public cvec4 argb => new cvec4(w, x, y, z);
        
        /// <summary>
        /// Returns cvec4.arga swizzling.
        /// </summary>
        public cvec4 arga => new cvec4(w, x, y, w);
        
        /// <summary>
        /// Returns cvec4.arb swizzling.
        /// </summary>
        public cvec3 arb => new cvec3(w, x, z);
        
        /// <summary>
        /// Returns cvec4.arbr swizzling.
        /// </summary>
        public cvec4 arbr => new cvec4(w, x, z, x);
        
        /// <summary>
        /// Returns cvec4.arbg swizzling.
        /// </summary>
        public cvec4 arbg => new cvec4(w, x, z, y);
        
        /// <summary>
        /// Returns cvec4.arbb swizzling.
        /// </summary>
        public cvec4 arbb => new cvec4(w, x, z, z);
        
        /// <summary>
        /// Returns cvec4.arba swizzling.
        /// </summary>
        public cvec4 arba => new cvec4(w, x, z, w);
        
        /// <summary>
        /// Returns cvec4.ara swizzling.
        /// </summary>
        public cvec3 ara => new cvec3(w, x, w);
        
        /// <summary>
        /// Returns cvec4.arar swizzling.
        /// </summary>
        public cvec4 arar => new cvec4(w, x, w, x);
        
        /// <summary>
        /// Returns cvec4.arag swizzling.
        /// </summary>
        public cvec4 arag => new cvec4(w, x, w, y);
        
        /// <summary>
        /// Returns cvec4.arab swizzling.
        /// </summary>
        public cvec4 arab => new cvec4(w, x, w, z);
        
        /// <summary>
        /// Returns cvec4.araa swizzling.
        /// </summary>
        public cvec4 araa => new cvec4(w, x, w, w);
        
        /// <summary>
        /// Returns cvec4.ag swizzling.
        /// </summary>
        public cvec2 ag => new cvec2(w, y);
        
        /// <summary>
        /// Returns cvec4.agr swizzling.
        /// </summary>
        public cvec3 agr => new cvec3(w, y, x);
        
        /// <summary>
        /// Returns cvec4.agrr swizzling.
        /// </summary>
        public cvec4 agrr => new cvec4(w, y, x, x);
        
        /// <summary>
        /// Returns cvec4.agrg swizzling.
        /// </summary>
        public cvec4 agrg => new cvec4(w, y, x, y);
        
        /// <summary>
        /// Returns cvec4.agrb swizzling.
        /// </summary>
        public cvec4 agrb => new cvec4(w, y, x, z);
        
        /// <summary>
        /// Returns cvec4.agra swizzling.
        /// </summary>
        public cvec4 agra => new cvec4(w, y, x, w);
        
        /// <summary>
        /// Returns cvec4.agg swizzling.
        /// </summary>
        public cvec3 agg => new cvec3(w, y, y);
        
        /// <summary>
        /// Returns cvec4.aggr swizzling.
        /// </summary>
        public cvec4 aggr => new cvec4(w, y, y, x);
        
        /// <summary>
        /// Returns cvec4.aggg swizzling.
        /// </summary>
        public cvec4 aggg => new cvec4(w, y, y, y);
        
        /// <summary>
        /// Returns cvec4.aggb swizzling.
        /// </summary>
        public cvec4 aggb => new cvec4(w, y, y, z);
        
        /// <summary>
        /// Returns cvec4.agga swizzling.
        /// </summary>
        public cvec4 agga => new cvec4(w, y, y, w);
        
        /// <summary>
        /// Returns cvec4.agb swizzling.
        /// </summary>
        public cvec3 agb => new cvec3(w, y, z);
        
        /// <summary>
        /// Returns cvec4.agbr swizzling.
        /// </summary>
        public cvec4 agbr => new cvec4(w, y, z, x);
        
        /// <summary>
        /// Returns cvec4.agbg swizzling.
        /// </summary>
        public cvec4 agbg => new cvec4(w, y, z, y);
        
        /// <summary>
        /// Returns cvec4.agbb swizzling.
        /// </summary>
        public cvec4 agbb => new cvec4(w, y, z, z);
        
        /// <summary>
        /// Returns cvec4.agba swizzling.
        /// </summary>
        public cvec4 agba => new cvec4(w, y, z, w);
        
        /// <summary>
        /// Returns cvec4.aga swizzling.
        /// </summary>
        public cvec3 aga => new cvec3(w, y, w);
        
        /// <summary>
        /// Returns cvec4.agar swizzling.
        /// </summary>
        public cvec4 agar => new cvec4(w, y, w, x);
        
        /// <summary>
        /// Returns cvec4.agag swizzling.
        /// </summary>
        public cvec4 agag => new cvec4(w, y, w, y);
        
        /// <summary>
        /// Returns cvec4.agab swizzling.
        /// </summary>
        public cvec4 agab => new cvec4(w, y, w, z);
        
        /// <summary>
        /// Returns cvec4.agaa swizzling.
        /// </summary>
        public cvec4 agaa => new cvec4(w, y, w, w);
        
        /// <summary>
        /// Returns cvec4.ab swizzling.
        /// </summary>
        public cvec2 ab => new cvec2(w, z);
        
        /// <summary>
        /// Returns cvec4.abr swizzling.
        /// </summary>
        public cvec3 abr => new cvec3(w, z, x);
        
        /// <summary>
        /// Returns cvec4.abrr swizzling.
        /// </summary>
        public cvec4 abrr => new cvec4(w, z, x, x);
        
        /// <summary>
        /// Returns cvec4.abrg swizzling.
        /// </summary>
        public cvec4 abrg => new cvec4(w, z, x, y);
        
        /// <summary>
        /// Returns cvec4.abrb swizzling.
        /// </summary>
        public cvec4 abrb => new cvec4(w, z, x, z);
        
        /// <summary>
        /// Returns cvec4.abra swizzling.
        /// </summary>
        public cvec4 abra => new cvec4(w, z, x, w);
        
        /// <summary>
        /// Returns cvec4.abg swizzling.
        /// </summary>
        public cvec3 abg => new cvec3(w, z, y);
        
        /// <summary>
        /// Returns cvec4.abgr swizzling.
        /// </summary>
        public cvec4 abgr => new cvec4(w, z, y, x);
        
        /// <summary>
        /// Returns cvec4.abgg swizzling.
        /// </summary>
        public cvec4 abgg => new cvec4(w, z, y, y);
        
        /// <summary>
        /// Returns cvec4.abgb swizzling.
        /// </summary>
        public cvec4 abgb => new cvec4(w, z, y, z);
        
        /// <summary>
        /// Returns cvec4.abga swizzling.
        /// </summary>
        public cvec4 abga => new cvec4(w, z, y, w);
        
        /// <summary>
        /// Returns cvec4.abb swizzling.
        /// </summary>
        public cvec3 abb => new cvec3(w, z, z);
        
        /// <summary>
        /// Returns cvec4.abbr swizzling.
        /// </summary>
        public cvec4 abbr => new cvec4(w, z, z, x);
        
        /// <summary>
        /// Returns cvec4.abbg swizzling.
        /// </summary>
        public cvec4 abbg => new cvec4(w, z, z, y);
        
        /// <summary>
        /// Returns cvec4.abbb swizzling.
        /// </summary>
        public cvec4 abbb => new cvec4(w, z, z, z);
        
        /// <summary>
        /// Returns cvec4.abba swizzling.
        /// </summary>
        public cvec4 abba => new cvec4(w, z, z, w);
        
        /// <summary>
        /// Returns cvec4.aba swizzling.
        /// </summary>
        public cvec3 aba => new cvec3(w, z, w);
        
        /// <summary>
        /// Returns cvec4.abar swizzling.
        /// </summary>
        public cvec4 abar => new cvec4(w, z, w, x);
        
        /// <summary>
        /// Returns cvec4.abag swizzling.
        /// </summary>
        public cvec4 abag => new cvec4(w, z, w, y);
        
        /// <summary>
        /// Returns cvec4.abab swizzling.
        /// </summary>
        public cvec4 abab => new cvec4(w, z, w, z);
        
        /// <summary>
        /// Returns cvec4.abaa swizzling.
        /// </summary>
        public cvec4 abaa => new cvec4(w, z, w, w);
        
        /// <summary>
        /// Returns cvec4.aa swizzling.
        /// </summary>
        public cvec2 aa => new cvec2(w, w);
        
        /// <summary>
        /// Returns cvec4.aar swizzling.
        /// </summary>
        public cvec3 aar => new cvec3(w, w, x);
        
        /// <summary>
        /// Returns cvec4.aarr swizzling.
        /// </summary>
        public cvec4 aarr => new cvec4(w, w, x, x);
        
        /// <summary>
        /// Returns cvec4.aarg swizzling.
        /// </summary>
        public cvec4 aarg => new cvec4(w, w, x, y);
        
        /// <summary>
        /// Returns cvec4.aarb swizzling.
        /// </summary>
        public cvec4 aarb => new cvec4(w, w, x, z);
        
        /// <summary>
        /// Returns cvec4.aara swizzling.
        /// </summary>
        public cvec4 aara => new cvec4(w, w, x, w);
        
        /// <summary>
        /// Returns cvec4.aag swizzling.
        /// </summary>
        public cvec3 aag => new cvec3(w, w, y);
        
        /// <summary>
        /// Returns cvec4.aagr swizzling.
        /// </summary>
        public cvec4 aagr => new cvec4(w, w, y, x);
        
        /// <summary>
        /// Returns cvec4.aagg swizzling.
        /// </summary>
        public cvec4 aagg => new cvec4(w, w, y, y);
        
        /// <summary>
        /// Returns cvec4.aagb swizzling.
        /// </summary>
        public cvec4 aagb => new cvec4(w, w, y, z);
        
        /// <summary>
        /// Returns cvec4.aaga swizzling.
        /// </summary>
        public cvec4 aaga => new cvec4(w, w, y, w);
        
        /// <summary>
        /// Returns cvec4.aab swizzling.
        /// </summary>
        public cvec3 aab => new cvec3(w, w, z);
        
        /// <summary>
        /// Returns cvec4.aabr swizzling.
        /// </summary>
        public cvec4 aabr => new cvec4(w, w, z, x);
        
        /// <summary>
        /// Returns cvec4.aabg swizzling.
        /// </summary>
        public cvec4 aabg => new cvec4(w, w, z, y);
        
        /// <summary>
        /// Returns cvec4.aabb swizzling.
        /// </summary>
        public cvec4 aabb => new cvec4(w, w, z, z);
        
        /// <summary>
        /// Returns cvec4.aaba swizzling.
        /// </summary>
        public cvec4 aaba => new cvec4(w, w, z, w);
        
        /// <summary>
        /// Returns cvec4.aaa swizzling.
        /// </summary>
        public cvec3 aaa => new cvec3(w, w, w);
        
        /// <summary>
        /// Returns cvec4.aaar swizzling.
        /// </summary>
        public cvec4 aaar => new cvec4(w, w, w, x);
        
        /// <summary>
        /// Returns cvec4.aaag swizzling.
        /// </summary>
        public cvec4 aaag => new cvec4(w, w, w, y);
        
        /// <summary>
        /// Returns cvec4.aaab swizzling.
        /// </summary>
        public cvec4 aaab => new cvec4(w, w, w, z);
        
        /// <summary>
        /// Returns cvec4.aaaa swizzling.
        /// </summary>
        public cvec4 aaaa => new cvec4(w, w, w, w);
    }
}
