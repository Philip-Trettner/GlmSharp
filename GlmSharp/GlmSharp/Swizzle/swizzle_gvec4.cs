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
    /// Temporary vector of type T with 4 components, used for implementing swizzling for gvec4.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_gvec4<T>
    {
        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly T x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly T y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        internal readonly T z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        internal readonly T w;

        #endregion
        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_gvec4.
        /// </summary>
        internal swizzle_gvec4(T x, T y, T z, T w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }

        #endregion
        
        // XYZW Versions
        
        /// <summary>
        /// Returns gvec4.xx swizzling.
        /// </summary>
        public gvec2<T> xx => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec4.xxx swizzling.
        /// </summary>
        public gvec3<T> xxx => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec4.xxxx swizzling.
        /// </summary>
        public gvec4<T> xxxx => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.xxxy swizzling.
        /// </summary>
        public gvec4<T> xxxy => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.xxxz swizzling.
        /// </summary>
        public gvec4<T> xxxz => new gvec4<T>(x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.xxxw swizzling.
        /// </summary>
        public gvec4<T> xxxw => new gvec4<T>(x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.xxy swizzling.
        /// </summary>
        public gvec3<T> xxy => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec4.xxyx swizzling.
        /// </summary>
        public gvec4<T> xxyx => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.xxyy swizzling.
        /// </summary>
        public gvec4<T> xxyy => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.xxyz swizzling.
        /// </summary>
        public gvec4<T> xxyz => new gvec4<T>(x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.xxyw swizzling.
        /// </summary>
        public gvec4<T> xxyw => new gvec4<T>(x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.xxz swizzling.
        /// </summary>
        public gvec3<T> xxz => new gvec3<T>(x, x, z);
        
        /// <summary>
        /// Returns gvec4.xxzx swizzling.
        /// </summary>
        public gvec4<T> xxzx => new gvec4<T>(x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.xxzy swizzling.
        /// </summary>
        public gvec4<T> xxzy => new gvec4<T>(x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.xxzz swizzling.
        /// </summary>
        public gvec4<T> xxzz => new gvec4<T>(x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.xxzw swizzling.
        /// </summary>
        public gvec4<T> xxzw => new gvec4<T>(x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.xxw swizzling.
        /// </summary>
        public gvec3<T> xxw => new gvec3<T>(x, x, w);
        
        /// <summary>
        /// Returns gvec4.xxwx swizzling.
        /// </summary>
        public gvec4<T> xxwx => new gvec4<T>(x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.xxwy swizzling.
        /// </summary>
        public gvec4<T> xxwy => new gvec4<T>(x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.xxwz swizzling.
        /// </summary>
        public gvec4<T> xxwz => new gvec4<T>(x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.xxww swizzling.
        /// </summary>
        public gvec4<T> xxww => new gvec4<T>(x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.xy swizzling.
        /// </summary>
        public gvec2<T> xy => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec4.xyx swizzling.
        /// </summary>
        public gvec3<T> xyx => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec4.xyxx swizzling.
        /// </summary>
        public gvec4<T> xyxx => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.xyxy swizzling.
        /// </summary>
        public gvec4<T> xyxy => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.xyxz swizzling.
        /// </summary>
        public gvec4<T> xyxz => new gvec4<T>(x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.xyxw swizzling.
        /// </summary>
        public gvec4<T> xyxw => new gvec4<T>(x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.xyy swizzling.
        /// </summary>
        public gvec3<T> xyy => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec4.xyyx swizzling.
        /// </summary>
        public gvec4<T> xyyx => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.xyyy swizzling.
        /// </summary>
        public gvec4<T> xyyy => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.xyyz swizzling.
        /// </summary>
        public gvec4<T> xyyz => new gvec4<T>(x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.xyyw swizzling.
        /// </summary>
        public gvec4<T> xyyw => new gvec4<T>(x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.xyz swizzling.
        /// </summary>
        public gvec3<T> xyz => new gvec3<T>(x, y, z);
        
        /// <summary>
        /// Returns gvec4.xyzx swizzling.
        /// </summary>
        public gvec4<T> xyzx => new gvec4<T>(x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.xyzy swizzling.
        /// </summary>
        public gvec4<T> xyzy => new gvec4<T>(x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.xyzz swizzling.
        /// </summary>
        public gvec4<T> xyzz => new gvec4<T>(x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.xyzw swizzling.
        /// </summary>
        public gvec4<T> xyzw => new gvec4<T>(x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.xyw swizzling.
        /// </summary>
        public gvec3<T> xyw => new gvec3<T>(x, y, w);
        
        /// <summary>
        /// Returns gvec4.xywx swizzling.
        /// </summary>
        public gvec4<T> xywx => new gvec4<T>(x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.xywy swizzling.
        /// </summary>
        public gvec4<T> xywy => new gvec4<T>(x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.xywz swizzling.
        /// </summary>
        public gvec4<T> xywz => new gvec4<T>(x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.xyww swizzling.
        /// </summary>
        public gvec4<T> xyww => new gvec4<T>(x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.xz swizzling.
        /// </summary>
        public gvec2<T> xz => new gvec2<T>(x, z);
        
        /// <summary>
        /// Returns gvec4.xzx swizzling.
        /// </summary>
        public gvec3<T> xzx => new gvec3<T>(x, z, x);
        
        /// <summary>
        /// Returns gvec4.xzxx swizzling.
        /// </summary>
        public gvec4<T> xzxx => new gvec4<T>(x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.xzxy swizzling.
        /// </summary>
        public gvec4<T> xzxy => new gvec4<T>(x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.xzxz swizzling.
        /// </summary>
        public gvec4<T> xzxz => new gvec4<T>(x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.xzxw swizzling.
        /// </summary>
        public gvec4<T> xzxw => new gvec4<T>(x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.xzy swizzling.
        /// </summary>
        public gvec3<T> xzy => new gvec3<T>(x, z, y);
        
        /// <summary>
        /// Returns gvec4.xzyx swizzling.
        /// </summary>
        public gvec4<T> xzyx => new gvec4<T>(x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.xzyy swizzling.
        /// </summary>
        public gvec4<T> xzyy => new gvec4<T>(x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.xzyz swizzling.
        /// </summary>
        public gvec4<T> xzyz => new gvec4<T>(x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.xzyw swizzling.
        /// </summary>
        public gvec4<T> xzyw => new gvec4<T>(x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.xzz swizzling.
        /// </summary>
        public gvec3<T> xzz => new gvec3<T>(x, z, z);
        
        /// <summary>
        /// Returns gvec4.xzzx swizzling.
        /// </summary>
        public gvec4<T> xzzx => new gvec4<T>(x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.xzzy swizzling.
        /// </summary>
        public gvec4<T> xzzy => new gvec4<T>(x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.xzzz swizzling.
        /// </summary>
        public gvec4<T> xzzz => new gvec4<T>(x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.xzzw swizzling.
        /// </summary>
        public gvec4<T> xzzw => new gvec4<T>(x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.xzw swizzling.
        /// </summary>
        public gvec3<T> xzw => new gvec3<T>(x, z, w);
        
        /// <summary>
        /// Returns gvec4.xzwx swizzling.
        /// </summary>
        public gvec4<T> xzwx => new gvec4<T>(x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.xzwy swizzling.
        /// </summary>
        public gvec4<T> xzwy => new gvec4<T>(x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.xzwz swizzling.
        /// </summary>
        public gvec4<T> xzwz => new gvec4<T>(x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.xzww swizzling.
        /// </summary>
        public gvec4<T> xzww => new gvec4<T>(x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.xw swizzling.
        /// </summary>
        public gvec2<T> xw => new gvec2<T>(x, w);
        
        /// <summary>
        /// Returns gvec4.xwx swizzling.
        /// </summary>
        public gvec3<T> xwx => new gvec3<T>(x, w, x);
        
        /// <summary>
        /// Returns gvec4.xwxx swizzling.
        /// </summary>
        public gvec4<T> xwxx => new gvec4<T>(x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.xwxy swizzling.
        /// </summary>
        public gvec4<T> xwxy => new gvec4<T>(x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.xwxz swizzling.
        /// </summary>
        public gvec4<T> xwxz => new gvec4<T>(x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.xwxw swizzling.
        /// </summary>
        public gvec4<T> xwxw => new gvec4<T>(x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.xwy swizzling.
        /// </summary>
        public gvec3<T> xwy => new gvec3<T>(x, w, y);
        
        /// <summary>
        /// Returns gvec4.xwyx swizzling.
        /// </summary>
        public gvec4<T> xwyx => new gvec4<T>(x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.xwyy swizzling.
        /// </summary>
        public gvec4<T> xwyy => new gvec4<T>(x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.xwyz swizzling.
        /// </summary>
        public gvec4<T> xwyz => new gvec4<T>(x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.xwyw swizzling.
        /// </summary>
        public gvec4<T> xwyw => new gvec4<T>(x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.xwz swizzling.
        /// </summary>
        public gvec3<T> xwz => new gvec3<T>(x, w, z);
        
        /// <summary>
        /// Returns gvec4.xwzx swizzling.
        /// </summary>
        public gvec4<T> xwzx => new gvec4<T>(x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.xwzy swizzling.
        /// </summary>
        public gvec4<T> xwzy => new gvec4<T>(x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.xwzz swizzling.
        /// </summary>
        public gvec4<T> xwzz => new gvec4<T>(x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.xwzw swizzling.
        /// </summary>
        public gvec4<T> xwzw => new gvec4<T>(x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.xww swizzling.
        /// </summary>
        public gvec3<T> xww => new gvec3<T>(x, w, w);
        
        /// <summary>
        /// Returns gvec4.xwwx swizzling.
        /// </summary>
        public gvec4<T> xwwx => new gvec4<T>(x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.xwwy swizzling.
        /// </summary>
        public gvec4<T> xwwy => new gvec4<T>(x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.xwwz swizzling.
        /// </summary>
        public gvec4<T> xwwz => new gvec4<T>(x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.xwww swizzling.
        /// </summary>
        public gvec4<T> xwww => new gvec4<T>(x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.yx swizzling.
        /// </summary>
        public gvec2<T> yx => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec4.yxx swizzling.
        /// </summary>
        public gvec3<T> yxx => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec4.yxxx swizzling.
        /// </summary>
        public gvec4<T> yxxx => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.yxxy swizzling.
        /// </summary>
        public gvec4<T> yxxy => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.yxxz swizzling.
        /// </summary>
        public gvec4<T> yxxz => new gvec4<T>(y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.yxxw swizzling.
        /// </summary>
        public gvec4<T> yxxw => new gvec4<T>(y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.yxy swizzling.
        /// </summary>
        public gvec3<T> yxy => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec4.yxyx swizzling.
        /// </summary>
        public gvec4<T> yxyx => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.yxyy swizzling.
        /// </summary>
        public gvec4<T> yxyy => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.yxyz swizzling.
        /// </summary>
        public gvec4<T> yxyz => new gvec4<T>(y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.yxyw swizzling.
        /// </summary>
        public gvec4<T> yxyw => new gvec4<T>(y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.yxz swizzling.
        /// </summary>
        public gvec3<T> yxz => new gvec3<T>(y, x, z);
        
        /// <summary>
        /// Returns gvec4.yxzx swizzling.
        /// </summary>
        public gvec4<T> yxzx => new gvec4<T>(y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.yxzy swizzling.
        /// </summary>
        public gvec4<T> yxzy => new gvec4<T>(y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.yxzz swizzling.
        /// </summary>
        public gvec4<T> yxzz => new gvec4<T>(y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.yxzw swizzling.
        /// </summary>
        public gvec4<T> yxzw => new gvec4<T>(y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.yxw swizzling.
        /// </summary>
        public gvec3<T> yxw => new gvec3<T>(y, x, w);
        
        /// <summary>
        /// Returns gvec4.yxwx swizzling.
        /// </summary>
        public gvec4<T> yxwx => new gvec4<T>(y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.yxwy swizzling.
        /// </summary>
        public gvec4<T> yxwy => new gvec4<T>(y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.yxwz swizzling.
        /// </summary>
        public gvec4<T> yxwz => new gvec4<T>(y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.yxww swizzling.
        /// </summary>
        public gvec4<T> yxww => new gvec4<T>(y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.yy swizzling.
        /// </summary>
        public gvec2<T> yy => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec4.yyx swizzling.
        /// </summary>
        public gvec3<T> yyx => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec4.yyxx swizzling.
        /// </summary>
        public gvec4<T> yyxx => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.yyxy swizzling.
        /// </summary>
        public gvec4<T> yyxy => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.yyxz swizzling.
        /// </summary>
        public gvec4<T> yyxz => new gvec4<T>(y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.yyxw swizzling.
        /// </summary>
        public gvec4<T> yyxw => new gvec4<T>(y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.yyy swizzling.
        /// </summary>
        public gvec3<T> yyy => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec4.yyyx swizzling.
        /// </summary>
        public gvec4<T> yyyx => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.yyyy swizzling.
        /// </summary>
        public gvec4<T> yyyy => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.yyyz swizzling.
        /// </summary>
        public gvec4<T> yyyz => new gvec4<T>(y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.yyyw swizzling.
        /// </summary>
        public gvec4<T> yyyw => new gvec4<T>(y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.yyz swizzling.
        /// </summary>
        public gvec3<T> yyz => new gvec3<T>(y, y, z);
        
        /// <summary>
        /// Returns gvec4.yyzx swizzling.
        /// </summary>
        public gvec4<T> yyzx => new gvec4<T>(y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.yyzy swizzling.
        /// </summary>
        public gvec4<T> yyzy => new gvec4<T>(y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.yyzz swizzling.
        /// </summary>
        public gvec4<T> yyzz => new gvec4<T>(y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.yyzw swizzling.
        /// </summary>
        public gvec4<T> yyzw => new gvec4<T>(y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.yyw swizzling.
        /// </summary>
        public gvec3<T> yyw => new gvec3<T>(y, y, w);
        
        /// <summary>
        /// Returns gvec4.yywx swizzling.
        /// </summary>
        public gvec4<T> yywx => new gvec4<T>(y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.yywy swizzling.
        /// </summary>
        public gvec4<T> yywy => new gvec4<T>(y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.yywz swizzling.
        /// </summary>
        public gvec4<T> yywz => new gvec4<T>(y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.yyww swizzling.
        /// </summary>
        public gvec4<T> yyww => new gvec4<T>(y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.yz swizzling.
        /// </summary>
        public gvec2<T> yz => new gvec2<T>(y, z);
        
        /// <summary>
        /// Returns gvec4.yzx swizzling.
        /// </summary>
        public gvec3<T> yzx => new gvec3<T>(y, z, x);
        
        /// <summary>
        /// Returns gvec4.yzxx swizzling.
        /// </summary>
        public gvec4<T> yzxx => new gvec4<T>(y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.yzxy swizzling.
        /// </summary>
        public gvec4<T> yzxy => new gvec4<T>(y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.yzxz swizzling.
        /// </summary>
        public gvec4<T> yzxz => new gvec4<T>(y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.yzxw swizzling.
        /// </summary>
        public gvec4<T> yzxw => new gvec4<T>(y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.yzy swizzling.
        /// </summary>
        public gvec3<T> yzy => new gvec3<T>(y, z, y);
        
        /// <summary>
        /// Returns gvec4.yzyx swizzling.
        /// </summary>
        public gvec4<T> yzyx => new gvec4<T>(y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.yzyy swizzling.
        /// </summary>
        public gvec4<T> yzyy => new gvec4<T>(y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.yzyz swizzling.
        /// </summary>
        public gvec4<T> yzyz => new gvec4<T>(y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.yzyw swizzling.
        /// </summary>
        public gvec4<T> yzyw => new gvec4<T>(y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.yzz swizzling.
        /// </summary>
        public gvec3<T> yzz => new gvec3<T>(y, z, z);
        
        /// <summary>
        /// Returns gvec4.yzzx swizzling.
        /// </summary>
        public gvec4<T> yzzx => new gvec4<T>(y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.yzzy swizzling.
        /// </summary>
        public gvec4<T> yzzy => new gvec4<T>(y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.yzzz swizzling.
        /// </summary>
        public gvec4<T> yzzz => new gvec4<T>(y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.yzzw swizzling.
        /// </summary>
        public gvec4<T> yzzw => new gvec4<T>(y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.yzw swizzling.
        /// </summary>
        public gvec3<T> yzw => new gvec3<T>(y, z, w);
        
        /// <summary>
        /// Returns gvec4.yzwx swizzling.
        /// </summary>
        public gvec4<T> yzwx => new gvec4<T>(y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.yzwy swizzling.
        /// </summary>
        public gvec4<T> yzwy => new gvec4<T>(y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.yzwz swizzling.
        /// </summary>
        public gvec4<T> yzwz => new gvec4<T>(y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.yzww swizzling.
        /// </summary>
        public gvec4<T> yzww => new gvec4<T>(y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.yw swizzling.
        /// </summary>
        public gvec2<T> yw => new gvec2<T>(y, w);
        
        /// <summary>
        /// Returns gvec4.ywx swizzling.
        /// </summary>
        public gvec3<T> ywx => new gvec3<T>(y, w, x);
        
        /// <summary>
        /// Returns gvec4.ywxx swizzling.
        /// </summary>
        public gvec4<T> ywxx => new gvec4<T>(y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.ywxy swizzling.
        /// </summary>
        public gvec4<T> ywxy => new gvec4<T>(y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.ywxz swizzling.
        /// </summary>
        public gvec4<T> ywxz => new gvec4<T>(y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.ywxw swizzling.
        /// </summary>
        public gvec4<T> ywxw => new gvec4<T>(y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.ywy swizzling.
        /// </summary>
        public gvec3<T> ywy => new gvec3<T>(y, w, y);
        
        /// <summary>
        /// Returns gvec4.ywyx swizzling.
        /// </summary>
        public gvec4<T> ywyx => new gvec4<T>(y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.ywyy swizzling.
        /// </summary>
        public gvec4<T> ywyy => new gvec4<T>(y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.ywyz swizzling.
        /// </summary>
        public gvec4<T> ywyz => new gvec4<T>(y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.ywyw swizzling.
        /// </summary>
        public gvec4<T> ywyw => new gvec4<T>(y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.ywz swizzling.
        /// </summary>
        public gvec3<T> ywz => new gvec3<T>(y, w, z);
        
        /// <summary>
        /// Returns gvec4.ywzx swizzling.
        /// </summary>
        public gvec4<T> ywzx => new gvec4<T>(y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.ywzy swizzling.
        /// </summary>
        public gvec4<T> ywzy => new gvec4<T>(y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.ywzz swizzling.
        /// </summary>
        public gvec4<T> ywzz => new gvec4<T>(y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.ywzw swizzling.
        /// </summary>
        public gvec4<T> ywzw => new gvec4<T>(y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.yww swizzling.
        /// </summary>
        public gvec3<T> yww => new gvec3<T>(y, w, w);
        
        /// <summary>
        /// Returns gvec4.ywwx swizzling.
        /// </summary>
        public gvec4<T> ywwx => new gvec4<T>(y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.ywwy swizzling.
        /// </summary>
        public gvec4<T> ywwy => new gvec4<T>(y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.ywwz swizzling.
        /// </summary>
        public gvec4<T> ywwz => new gvec4<T>(y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.ywww swizzling.
        /// </summary>
        public gvec4<T> ywww => new gvec4<T>(y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.zx swizzling.
        /// </summary>
        public gvec2<T> zx => new gvec2<T>(z, x);
        
        /// <summary>
        /// Returns gvec4.zxx swizzling.
        /// </summary>
        public gvec3<T> zxx => new gvec3<T>(z, x, x);
        
        /// <summary>
        /// Returns gvec4.zxxx swizzling.
        /// </summary>
        public gvec4<T> zxxx => new gvec4<T>(z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.zxxy swizzling.
        /// </summary>
        public gvec4<T> zxxy => new gvec4<T>(z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.zxxz swizzling.
        /// </summary>
        public gvec4<T> zxxz => new gvec4<T>(z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.zxxw swizzling.
        /// </summary>
        public gvec4<T> zxxw => new gvec4<T>(z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.zxy swizzling.
        /// </summary>
        public gvec3<T> zxy => new gvec3<T>(z, x, y);
        
        /// <summary>
        /// Returns gvec4.zxyx swizzling.
        /// </summary>
        public gvec4<T> zxyx => new gvec4<T>(z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.zxyy swizzling.
        /// </summary>
        public gvec4<T> zxyy => new gvec4<T>(z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.zxyz swizzling.
        /// </summary>
        public gvec4<T> zxyz => new gvec4<T>(z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.zxyw swizzling.
        /// </summary>
        public gvec4<T> zxyw => new gvec4<T>(z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.zxz swizzling.
        /// </summary>
        public gvec3<T> zxz => new gvec3<T>(z, x, z);
        
        /// <summary>
        /// Returns gvec4.zxzx swizzling.
        /// </summary>
        public gvec4<T> zxzx => new gvec4<T>(z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.zxzy swizzling.
        /// </summary>
        public gvec4<T> zxzy => new gvec4<T>(z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.zxzz swizzling.
        /// </summary>
        public gvec4<T> zxzz => new gvec4<T>(z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.zxzw swizzling.
        /// </summary>
        public gvec4<T> zxzw => new gvec4<T>(z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.zxw swizzling.
        /// </summary>
        public gvec3<T> zxw => new gvec3<T>(z, x, w);
        
        /// <summary>
        /// Returns gvec4.zxwx swizzling.
        /// </summary>
        public gvec4<T> zxwx => new gvec4<T>(z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.zxwy swizzling.
        /// </summary>
        public gvec4<T> zxwy => new gvec4<T>(z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.zxwz swizzling.
        /// </summary>
        public gvec4<T> zxwz => new gvec4<T>(z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.zxww swizzling.
        /// </summary>
        public gvec4<T> zxww => new gvec4<T>(z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.zy swizzling.
        /// </summary>
        public gvec2<T> zy => new gvec2<T>(z, y);
        
        /// <summary>
        /// Returns gvec4.zyx swizzling.
        /// </summary>
        public gvec3<T> zyx => new gvec3<T>(z, y, x);
        
        /// <summary>
        /// Returns gvec4.zyxx swizzling.
        /// </summary>
        public gvec4<T> zyxx => new gvec4<T>(z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.zyxy swizzling.
        /// </summary>
        public gvec4<T> zyxy => new gvec4<T>(z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.zyxz swizzling.
        /// </summary>
        public gvec4<T> zyxz => new gvec4<T>(z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.zyxw swizzling.
        /// </summary>
        public gvec4<T> zyxw => new gvec4<T>(z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.zyy swizzling.
        /// </summary>
        public gvec3<T> zyy => new gvec3<T>(z, y, y);
        
        /// <summary>
        /// Returns gvec4.zyyx swizzling.
        /// </summary>
        public gvec4<T> zyyx => new gvec4<T>(z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.zyyy swizzling.
        /// </summary>
        public gvec4<T> zyyy => new gvec4<T>(z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.zyyz swizzling.
        /// </summary>
        public gvec4<T> zyyz => new gvec4<T>(z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.zyyw swizzling.
        /// </summary>
        public gvec4<T> zyyw => new gvec4<T>(z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.zyz swizzling.
        /// </summary>
        public gvec3<T> zyz => new gvec3<T>(z, y, z);
        
        /// <summary>
        /// Returns gvec4.zyzx swizzling.
        /// </summary>
        public gvec4<T> zyzx => new gvec4<T>(z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.zyzy swizzling.
        /// </summary>
        public gvec4<T> zyzy => new gvec4<T>(z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.zyzz swizzling.
        /// </summary>
        public gvec4<T> zyzz => new gvec4<T>(z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.zyzw swizzling.
        /// </summary>
        public gvec4<T> zyzw => new gvec4<T>(z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.zyw swizzling.
        /// </summary>
        public gvec3<T> zyw => new gvec3<T>(z, y, w);
        
        /// <summary>
        /// Returns gvec4.zywx swizzling.
        /// </summary>
        public gvec4<T> zywx => new gvec4<T>(z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.zywy swizzling.
        /// </summary>
        public gvec4<T> zywy => new gvec4<T>(z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.zywz swizzling.
        /// </summary>
        public gvec4<T> zywz => new gvec4<T>(z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.zyww swizzling.
        /// </summary>
        public gvec4<T> zyww => new gvec4<T>(z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.zz swizzling.
        /// </summary>
        public gvec2<T> zz => new gvec2<T>(z, z);
        
        /// <summary>
        /// Returns gvec4.zzx swizzling.
        /// </summary>
        public gvec3<T> zzx => new gvec3<T>(z, z, x);
        
        /// <summary>
        /// Returns gvec4.zzxx swizzling.
        /// </summary>
        public gvec4<T> zzxx => new gvec4<T>(z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.zzxy swizzling.
        /// </summary>
        public gvec4<T> zzxy => new gvec4<T>(z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.zzxz swizzling.
        /// </summary>
        public gvec4<T> zzxz => new gvec4<T>(z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.zzxw swizzling.
        /// </summary>
        public gvec4<T> zzxw => new gvec4<T>(z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.zzy swizzling.
        /// </summary>
        public gvec3<T> zzy => new gvec3<T>(z, z, y);
        
        /// <summary>
        /// Returns gvec4.zzyx swizzling.
        /// </summary>
        public gvec4<T> zzyx => new gvec4<T>(z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.zzyy swizzling.
        /// </summary>
        public gvec4<T> zzyy => new gvec4<T>(z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.zzyz swizzling.
        /// </summary>
        public gvec4<T> zzyz => new gvec4<T>(z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.zzyw swizzling.
        /// </summary>
        public gvec4<T> zzyw => new gvec4<T>(z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.zzz swizzling.
        /// </summary>
        public gvec3<T> zzz => new gvec3<T>(z, z, z);
        
        /// <summary>
        /// Returns gvec4.zzzx swizzling.
        /// </summary>
        public gvec4<T> zzzx => new gvec4<T>(z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.zzzy swizzling.
        /// </summary>
        public gvec4<T> zzzy => new gvec4<T>(z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.zzzz swizzling.
        /// </summary>
        public gvec4<T> zzzz => new gvec4<T>(z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.zzzw swizzling.
        /// </summary>
        public gvec4<T> zzzw => new gvec4<T>(z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.zzw swizzling.
        /// </summary>
        public gvec3<T> zzw => new gvec3<T>(z, z, w);
        
        /// <summary>
        /// Returns gvec4.zzwx swizzling.
        /// </summary>
        public gvec4<T> zzwx => new gvec4<T>(z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.zzwy swizzling.
        /// </summary>
        public gvec4<T> zzwy => new gvec4<T>(z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.zzwz swizzling.
        /// </summary>
        public gvec4<T> zzwz => new gvec4<T>(z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.zzww swizzling.
        /// </summary>
        public gvec4<T> zzww => new gvec4<T>(z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.zw swizzling.
        /// </summary>
        public gvec2<T> zw => new gvec2<T>(z, w);
        
        /// <summary>
        /// Returns gvec4.zwx swizzling.
        /// </summary>
        public gvec3<T> zwx => new gvec3<T>(z, w, x);
        
        /// <summary>
        /// Returns gvec4.zwxx swizzling.
        /// </summary>
        public gvec4<T> zwxx => new gvec4<T>(z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.zwxy swizzling.
        /// </summary>
        public gvec4<T> zwxy => new gvec4<T>(z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.zwxz swizzling.
        /// </summary>
        public gvec4<T> zwxz => new gvec4<T>(z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.zwxw swizzling.
        /// </summary>
        public gvec4<T> zwxw => new gvec4<T>(z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.zwy swizzling.
        /// </summary>
        public gvec3<T> zwy => new gvec3<T>(z, w, y);
        
        /// <summary>
        /// Returns gvec4.zwyx swizzling.
        /// </summary>
        public gvec4<T> zwyx => new gvec4<T>(z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.zwyy swizzling.
        /// </summary>
        public gvec4<T> zwyy => new gvec4<T>(z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.zwyz swizzling.
        /// </summary>
        public gvec4<T> zwyz => new gvec4<T>(z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.zwyw swizzling.
        /// </summary>
        public gvec4<T> zwyw => new gvec4<T>(z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.zwz swizzling.
        /// </summary>
        public gvec3<T> zwz => new gvec3<T>(z, w, z);
        
        /// <summary>
        /// Returns gvec4.zwzx swizzling.
        /// </summary>
        public gvec4<T> zwzx => new gvec4<T>(z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.zwzy swizzling.
        /// </summary>
        public gvec4<T> zwzy => new gvec4<T>(z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.zwzz swizzling.
        /// </summary>
        public gvec4<T> zwzz => new gvec4<T>(z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.zwzw swizzling.
        /// </summary>
        public gvec4<T> zwzw => new gvec4<T>(z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.zww swizzling.
        /// </summary>
        public gvec3<T> zww => new gvec3<T>(z, w, w);
        
        /// <summary>
        /// Returns gvec4.zwwx swizzling.
        /// </summary>
        public gvec4<T> zwwx => new gvec4<T>(z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.zwwy swizzling.
        /// </summary>
        public gvec4<T> zwwy => new gvec4<T>(z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.zwwz swizzling.
        /// </summary>
        public gvec4<T> zwwz => new gvec4<T>(z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.zwww swizzling.
        /// </summary>
        public gvec4<T> zwww => new gvec4<T>(z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.wx swizzling.
        /// </summary>
        public gvec2<T> wx => new gvec2<T>(w, x);
        
        /// <summary>
        /// Returns gvec4.wxx swizzling.
        /// </summary>
        public gvec3<T> wxx => new gvec3<T>(w, x, x);
        
        /// <summary>
        /// Returns gvec4.wxxx swizzling.
        /// </summary>
        public gvec4<T> wxxx => new gvec4<T>(w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.wxxy swizzling.
        /// </summary>
        public gvec4<T> wxxy => new gvec4<T>(w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.wxxz swizzling.
        /// </summary>
        public gvec4<T> wxxz => new gvec4<T>(w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.wxxw swizzling.
        /// </summary>
        public gvec4<T> wxxw => new gvec4<T>(w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.wxy swizzling.
        /// </summary>
        public gvec3<T> wxy => new gvec3<T>(w, x, y);
        
        /// <summary>
        /// Returns gvec4.wxyx swizzling.
        /// </summary>
        public gvec4<T> wxyx => new gvec4<T>(w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.wxyy swizzling.
        /// </summary>
        public gvec4<T> wxyy => new gvec4<T>(w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.wxyz swizzling.
        /// </summary>
        public gvec4<T> wxyz => new gvec4<T>(w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.wxyw swizzling.
        /// </summary>
        public gvec4<T> wxyw => new gvec4<T>(w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.wxz swizzling.
        /// </summary>
        public gvec3<T> wxz => new gvec3<T>(w, x, z);
        
        /// <summary>
        /// Returns gvec4.wxzx swizzling.
        /// </summary>
        public gvec4<T> wxzx => new gvec4<T>(w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.wxzy swizzling.
        /// </summary>
        public gvec4<T> wxzy => new gvec4<T>(w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.wxzz swizzling.
        /// </summary>
        public gvec4<T> wxzz => new gvec4<T>(w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.wxzw swizzling.
        /// </summary>
        public gvec4<T> wxzw => new gvec4<T>(w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.wxw swizzling.
        /// </summary>
        public gvec3<T> wxw => new gvec3<T>(w, x, w);
        
        /// <summary>
        /// Returns gvec4.wxwx swizzling.
        /// </summary>
        public gvec4<T> wxwx => new gvec4<T>(w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.wxwy swizzling.
        /// </summary>
        public gvec4<T> wxwy => new gvec4<T>(w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.wxwz swizzling.
        /// </summary>
        public gvec4<T> wxwz => new gvec4<T>(w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.wxww swizzling.
        /// </summary>
        public gvec4<T> wxww => new gvec4<T>(w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.wy swizzling.
        /// </summary>
        public gvec2<T> wy => new gvec2<T>(w, y);
        
        /// <summary>
        /// Returns gvec4.wyx swizzling.
        /// </summary>
        public gvec3<T> wyx => new gvec3<T>(w, y, x);
        
        /// <summary>
        /// Returns gvec4.wyxx swizzling.
        /// </summary>
        public gvec4<T> wyxx => new gvec4<T>(w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.wyxy swizzling.
        /// </summary>
        public gvec4<T> wyxy => new gvec4<T>(w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.wyxz swizzling.
        /// </summary>
        public gvec4<T> wyxz => new gvec4<T>(w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.wyxw swizzling.
        /// </summary>
        public gvec4<T> wyxw => new gvec4<T>(w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.wyy swizzling.
        /// </summary>
        public gvec3<T> wyy => new gvec3<T>(w, y, y);
        
        /// <summary>
        /// Returns gvec4.wyyx swizzling.
        /// </summary>
        public gvec4<T> wyyx => new gvec4<T>(w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.wyyy swizzling.
        /// </summary>
        public gvec4<T> wyyy => new gvec4<T>(w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.wyyz swizzling.
        /// </summary>
        public gvec4<T> wyyz => new gvec4<T>(w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.wyyw swizzling.
        /// </summary>
        public gvec4<T> wyyw => new gvec4<T>(w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.wyz swizzling.
        /// </summary>
        public gvec3<T> wyz => new gvec3<T>(w, y, z);
        
        /// <summary>
        /// Returns gvec4.wyzx swizzling.
        /// </summary>
        public gvec4<T> wyzx => new gvec4<T>(w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.wyzy swizzling.
        /// </summary>
        public gvec4<T> wyzy => new gvec4<T>(w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.wyzz swizzling.
        /// </summary>
        public gvec4<T> wyzz => new gvec4<T>(w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.wyzw swizzling.
        /// </summary>
        public gvec4<T> wyzw => new gvec4<T>(w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.wyw swizzling.
        /// </summary>
        public gvec3<T> wyw => new gvec3<T>(w, y, w);
        
        /// <summary>
        /// Returns gvec4.wywx swizzling.
        /// </summary>
        public gvec4<T> wywx => new gvec4<T>(w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.wywy swizzling.
        /// </summary>
        public gvec4<T> wywy => new gvec4<T>(w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.wywz swizzling.
        /// </summary>
        public gvec4<T> wywz => new gvec4<T>(w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.wyww swizzling.
        /// </summary>
        public gvec4<T> wyww => new gvec4<T>(w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.wz swizzling.
        /// </summary>
        public gvec2<T> wz => new gvec2<T>(w, z);
        
        /// <summary>
        /// Returns gvec4.wzx swizzling.
        /// </summary>
        public gvec3<T> wzx => new gvec3<T>(w, z, x);
        
        /// <summary>
        /// Returns gvec4.wzxx swizzling.
        /// </summary>
        public gvec4<T> wzxx => new gvec4<T>(w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.wzxy swizzling.
        /// </summary>
        public gvec4<T> wzxy => new gvec4<T>(w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.wzxz swizzling.
        /// </summary>
        public gvec4<T> wzxz => new gvec4<T>(w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.wzxw swizzling.
        /// </summary>
        public gvec4<T> wzxw => new gvec4<T>(w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.wzy swizzling.
        /// </summary>
        public gvec3<T> wzy => new gvec3<T>(w, z, y);
        
        /// <summary>
        /// Returns gvec4.wzyx swizzling.
        /// </summary>
        public gvec4<T> wzyx => new gvec4<T>(w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.wzyy swizzling.
        /// </summary>
        public gvec4<T> wzyy => new gvec4<T>(w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.wzyz swizzling.
        /// </summary>
        public gvec4<T> wzyz => new gvec4<T>(w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.wzyw swizzling.
        /// </summary>
        public gvec4<T> wzyw => new gvec4<T>(w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.wzz swizzling.
        /// </summary>
        public gvec3<T> wzz => new gvec3<T>(w, z, z);
        
        /// <summary>
        /// Returns gvec4.wzzx swizzling.
        /// </summary>
        public gvec4<T> wzzx => new gvec4<T>(w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.wzzy swizzling.
        /// </summary>
        public gvec4<T> wzzy => new gvec4<T>(w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.wzzz swizzling.
        /// </summary>
        public gvec4<T> wzzz => new gvec4<T>(w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.wzzw swizzling.
        /// </summary>
        public gvec4<T> wzzw => new gvec4<T>(w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.wzw swizzling.
        /// </summary>
        public gvec3<T> wzw => new gvec3<T>(w, z, w);
        
        /// <summary>
        /// Returns gvec4.wzwx swizzling.
        /// </summary>
        public gvec4<T> wzwx => new gvec4<T>(w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.wzwy swizzling.
        /// </summary>
        public gvec4<T> wzwy => new gvec4<T>(w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.wzwz swizzling.
        /// </summary>
        public gvec4<T> wzwz => new gvec4<T>(w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.wzww swizzling.
        /// </summary>
        public gvec4<T> wzww => new gvec4<T>(w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.ww swizzling.
        /// </summary>
        public gvec2<T> ww => new gvec2<T>(w, w);
        
        /// <summary>
        /// Returns gvec4.wwx swizzling.
        /// </summary>
        public gvec3<T> wwx => new gvec3<T>(w, w, x);
        
        /// <summary>
        /// Returns gvec4.wwxx swizzling.
        /// </summary>
        public gvec4<T> wwxx => new gvec4<T>(w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.wwxy swizzling.
        /// </summary>
        public gvec4<T> wwxy => new gvec4<T>(w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.wwxz swizzling.
        /// </summary>
        public gvec4<T> wwxz => new gvec4<T>(w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.wwxw swizzling.
        /// </summary>
        public gvec4<T> wwxw => new gvec4<T>(w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.wwy swizzling.
        /// </summary>
        public gvec3<T> wwy => new gvec3<T>(w, w, y);
        
        /// <summary>
        /// Returns gvec4.wwyx swizzling.
        /// </summary>
        public gvec4<T> wwyx => new gvec4<T>(w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.wwyy swizzling.
        /// </summary>
        public gvec4<T> wwyy => new gvec4<T>(w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.wwyz swizzling.
        /// </summary>
        public gvec4<T> wwyz => new gvec4<T>(w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.wwyw swizzling.
        /// </summary>
        public gvec4<T> wwyw => new gvec4<T>(w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.wwz swizzling.
        /// </summary>
        public gvec3<T> wwz => new gvec3<T>(w, w, z);
        
        /// <summary>
        /// Returns gvec4.wwzx swizzling.
        /// </summary>
        public gvec4<T> wwzx => new gvec4<T>(w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.wwzy swizzling.
        /// </summary>
        public gvec4<T> wwzy => new gvec4<T>(w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.wwzz swizzling.
        /// </summary>
        public gvec4<T> wwzz => new gvec4<T>(w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.wwzw swizzling.
        /// </summary>
        public gvec4<T> wwzw => new gvec4<T>(w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.www swizzling.
        /// </summary>
        public gvec3<T> www => new gvec3<T>(w, w, w);
        
        /// <summary>
        /// Returns gvec4.wwwx swizzling.
        /// </summary>
        public gvec4<T> wwwx => new gvec4<T>(w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.wwwy swizzling.
        /// </summary>
        public gvec4<T> wwwy => new gvec4<T>(w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.wwwz swizzling.
        /// </summary>
        public gvec4<T> wwwz => new gvec4<T>(w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.wwww swizzling.
        /// </summary>
        public gvec4<T> wwww => new gvec4<T>(w, w, w, w);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns gvec4.rr swizzling.
        /// </summary>
        public gvec2<T> rr => new gvec2<T>(x, x);
        
        /// <summary>
        /// Returns gvec4.rrr swizzling.
        /// </summary>
        public gvec3<T> rrr => new gvec3<T>(x, x, x);
        
        /// <summary>
        /// Returns gvec4.rrrr swizzling.
        /// </summary>
        public gvec4<T> rrrr => new gvec4<T>(x, x, x, x);
        
        /// <summary>
        /// Returns gvec4.rrrg swizzling.
        /// </summary>
        public gvec4<T> rrrg => new gvec4<T>(x, x, x, y);
        
        /// <summary>
        /// Returns gvec4.rrrb swizzling.
        /// </summary>
        public gvec4<T> rrrb => new gvec4<T>(x, x, x, z);
        
        /// <summary>
        /// Returns gvec4.rrra swizzling.
        /// </summary>
        public gvec4<T> rrra => new gvec4<T>(x, x, x, w);
        
        /// <summary>
        /// Returns gvec4.rrg swizzling.
        /// </summary>
        public gvec3<T> rrg => new gvec3<T>(x, x, y);
        
        /// <summary>
        /// Returns gvec4.rrgr swizzling.
        /// </summary>
        public gvec4<T> rrgr => new gvec4<T>(x, x, y, x);
        
        /// <summary>
        /// Returns gvec4.rrgg swizzling.
        /// </summary>
        public gvec4<T> rrgg => new gvec4<T>(x, x, y, y);
        
        /// <summary>
        /// Returns gvec4.rrgb swizzling.
        /// </summary>
        public gvec4<T> rrgb => new gvec4<T>(x, x, y, z);
        
        /// <summary>
        /// Returns gvec4.rrga swizzling.
        /// </summary>
        public gvec4<T> rrga => new gvec4<T>(x, x, y, w);
        
        /// <summary>
        /// Returns gvec4.rrb swizzling.
        /// </summary>
        public gvec3<T> rrb => new gvec3<T>(x, x, z);
        
        /// <summary>
        /// Returns gvec4.rrbr swizzling.
        /// </summary>
        public gvec4<T> rrbr => new gvec4<T>(x, x, z, x);
        
        /// <summary>
        /// Returns gvec4.rrbg swizzling.
        /// </summary>
        public gvec4<T> rrbg => new gvec4<T>(x, x, z, y);
        
        /// <summary>
        /// Returns gvec4.rrbb swizzling.
        /// </summary>
        public gvec4<T> rrbb => new gvec4<T>(x, x, z, z);
        
        /// <summary>
        /// Returns gvec4.rrba swizzling.
        /// </summary>
        public gvec4<T> rrba => new gvec4<T>(x, x, z, w);
        
        /// <summary>
        /// Returns gvec4.rra swizzling.
        /// </summary>
        public gvec3<T> rra => new gvec3<T>(x, x, w);
        
        /// <summary>
        /// Returns gvec4.rrar swizzling.
        /// </summary>
        public gvec4<T> rrar => new gvec4<T>(x, x, w, x);
        
        /// <summary>
        /// Returns gvec4.rrag swizzling.
        /// </summary>
        public gvec4<T> rrag => new gvec4<T>(x, x, w, y);
        
        /// <summary>
        /// Returns gvec4.rrab swizzling.
        /// </summary>
        public gvec4<T> rrab => new gvec4<T>(x, x, w, z);
        
        /// <summary>
        /// Returns gvec4.rraa swizzling.
        /// </summary>
        public gvec4<T> rraa => new gvec4<T>(x, x, w, w);
        
        /// <summary>
        /// Returns gvec4.rg swizzling.
        /// </summary>
        public gvec2<T> rg => new gvec2<T>(x, y);
        
        /// <summary>
        /// Returns gvec4.rgr swizzling.
        /// </summary>
        public gvec3<T> rgr => new gvec3<T>(x, y, x);
        
        /// <summary>
        /// Returns gvec4.rgrr swizzling.
        /// </summary>
        public gvec4<T> rgrr => new gvec4<T>(x, y, x, x);
        
        /// <summary>
        /// Returns gvec4.rgrg swizzling.
        /// </summary>
        public gvec4<T> rgrg => new gvec4<T>(x, y, x, y);
        
        /// <summary>
        /// Returns gvec4.rgrb swizzling.
        /// </summary>
        public gvec4<T> rgrb => new gvec4<T>(x, y, x, z);
        
        /// <summary>
        /// Returns gvec4.rgra swizzling.
        /// </summary>
        public gvec4<T> rgra => new gvec4<T>(x, y, x, w);
        
        /// <summary>
        /// Returns gvec4.rgg swizzling.
        /// </summary>
        public gvec3<T> rgg => new gvec3<T>(x, y, y);
        
        /// <summary>
        /// Returns gvec4.rggr swizzling.
        /// </summary>
        public gvec4<T> rggr => new gvec4<T>(x, y, y, x);
        
        /// <summary>
        /// Returns gvec4.rggg swizzling.
        /// </summary>
        public gvec4<T> rggg => new gvec4<T>(x, y, y, y);
        
        /// <summary>
        /// Returns gvec4.rggb swizzling.
        /// </summary>
        public gvec4<T> rggb => new gvec4<T>(x, y, y, z);
        
        /// <summary>
        /// Returns gvec4.rgga swizzling.
        /// </summary>
        public gvec4<T> rgga => new gvec4<T>(x, y, y, w);
        
        /// <summary>
        /// Returns gvec4.rgb swizzling.
        /// </summary>
        public gvec3<T> rgb => new gvec3<T>(x, y, z);
        
        /// <summary>
        /// Returns gvec4.rgbr swizzling.
        /// </summary>
        public gvec4<T> rgbr => new gvec4<T>(x, y, z, x);
        
        /// <summary>
        /// Returns gvec4.rgbg swizzling.
        /// </summary>
        public gvec4<T> rgbg => new gvec4<T>(x, y, z, y);
        
        /// <summary>
        /// Returns gvec4.rgbb swizzling.
        /// </summary>
        public gvec4<T> rgbb => new gvec4<T>(x, y, z, z);
        
        /// <summary>
        /// Returns gvec4.rgba swizzling.
        /// </summary>
        public gvec4<T> rgba => new gvec4<T>(x, y, z, w);
        
        /// <summary>
        /// Returns gvec4.rga swizzling.
        /// </summary>
        public gvec3<T> rga => new gvec3<T>(x, y, w);
        
        /// <summary>
        /// Returns gvec4.rgar swizzling.
        /// </summary>
        public gvec4<T> rgar => new gvec4<T>(x, y, w, x);
        
        /// <summary>
        /// Returns gvec4.rgag swizzling.
        /// </summary>
        public gvec4<T> rgag => new gvec4<T>(x, y, w, y);
        
        /// <summary>
        /// Returns gvec4.rgab swizzling.
        /// </summary>
        public gvec4<T> rgab => new gvec4<T>(x, y, w, z);
        
        /// <summary>
        /// Returns gvec4.rgaa swizzling.
        /// </summary>
        public gvec4<T> rgaa => new gvec4<T>(x, y, w, w);
        
        /// <summary>
        /// Returns gvec4.rb swizzling.
        /// </summary>
        public gvec2<T> rb => new gvec2<T>(x, z);
        
        /// <summary>
        /// Returns gvec4.rbr swizzling.
        /// </summary>
        public gvec3<T> rbr => new gvec3<T>(x, z, x);
        
        /// <summary>
        /// Returns gvec4.rbrr swizzling.
        /// </summary>
        public gvec4<T> rbrr => new gvec4<T>(x, z, x, x);
        
        /// <summary>
        /// Returns gvec4.rbrg swizzling.
        /// </summary>
        public gvec4<T> rbrg => new gvec4<T>(x, z, x, y);
        
        /// <summary>
        /// Returns gvec4.rbrb swizzling.
        /// </summary>
        public gvec4<T> rbrb => new gvec4<T>(x, z, x, z);
        
        /// <summary>
        /// Returns gvec4.rbra swizzling.
        /// </summary>
        public gvec4<T> rbra => new gvec4<T>(x, z, x, w);
        
        /// <summary>
        /// Returns gvec4.rbg swizzling.
        /// </summary>
        public gvec3<T> rbg => new gvec3<T>(x, z, y);
        
        /// <summary>
        /// Returns gvec4.rbgr swizzling.
        /// </summary>
        public gvec4<T> rbgr => new gvec4<T>(x, z, y, x);
        
        /// <summary>
        /// Returns gvec4.rbgg swizzling.
        /// </summary>
        public gvec4<T> rbgg => new gvec4<T>(x, z, y, y);
        
        /// <summary>
        /// Returns gvec4.rbgb swizzling.
        /// </summary>
        public gvec4<T> rbgb => new gvec4<T>(x, z, y, z);
        
        /// <summary>
        /// Returns gvec4.rbga swizzling.
        /// </summary>
        public gvec4<T> rbga => new gvec4<T>(x, z, y, w);
        
        /// <summary>
        /// Returns gvec4.rbb swizzling.
        /// </summary>
        public gvec3<T> rbb => new gvec3<T>(x, z, z);
        
        /// <summary>
        /// Returns gvec4.rbbr swizzling.
        /// </summary>
        public gvec4<T> rbbr => new gvec4<T>(x, z, z, x);
        
        /// <summary>
        /// Returns gvec4.rbbg swizzling.
        /// </summary>
        public gvec4<T> rbbg => new gvec4<T>(x, z, z, y);
        
        /// <summary>
        /// Returns gvec4.rbbb swizzling.
        /// </summary>
        public gvec4<T> rbbb => new gvec4<T>(x, z, z, z);
        
        /// <summary>
        /// Returns gvec4.rbba swizzling.
        /// </summary>
        public gvec4<T> rbba => new gvec4<T>(x, z, z, w);
        
        /// <summary>
        /// Returns gvec4.rba swizzling.
        /// </summary>
        public gvec3<T> rba => new gvec3<T>(x, z, w);
        
        /// <summary>
        /// Returns gvec4.rbar swizzling.
        /// </summary>
        public gvec4<T> rbar => new gvec4<T>(x, z, w, x);
        
        /// <summary>
        /// Returns gvec4.rbag swizzling.
        /// </summary>
        public gvec4<T> rbag => new gvec4<T>(x, z, w, y);
        
        /// <summary>
        /// Returns gvec4.rbab swizzling.
        /// </summary>
        public gvec4<T> rbab => new gvec4<T>(x, z, w, z);
        
        /// <summary>
        /// Returns gvec4.rbaa swizzling.
        /// </summary>
        public gvec4<T> rbaa => new gvec4<T>(x, z, w, w);
        
        /// <summary>
        /// Returns gvec4.ra swizzling.
        /// </summary>
        public gvec2<T> ra => new gvec2<T>(x, w);
        
        /// <summary>
        /// Returns gvec4.rar swizzling.
        /// </summary>
        public gvec3<T> rar => new gvec3<T>(x, w, x);
        
        /// <summary>
        /// Returns gvec4.rarr swizzling.
        /// </summary>
        public gvec4<T> rarr => new gvec4<T>(x, w, x, x);
        
        /// <summary>
        /// Returns gvec4.rarg swizzling.
        /// </summary>
        public gvec4<T> rarg => new gvec4<T>(x, w, x, y);
        
        /// <summary>
        /// Returns gvec4.rarb swizzling.
        /// </summary>
        public gvec4<T> rarb => new gvec4<T>(x, w, x, z);
        
        /// <summary>
        /// Returns gvec4.rara swizzling.
        /// </summary>
        public gvec4<T> rara => new gvec4<T>(x, w, x, w);
        
        /// <summary>
        /// Returns gvec4.rag swizzling.
        /// </summary>
        public gvec3<T> rag => new gvec3<T>(x, w, y);
        
        /// <summary>
        /// Returns gvec4.ragr swizzling.
        /// </summary>
        public gvec4<T> ragr => new gvec4<T>(x, w, y, x);
        
        /// <summary>
        /// Returns gvec4.ragg swizzling.
        /// </summary>
        public gvec4<T> ragg => new gvec4<T>(x, w, y, y);
        
        /// <summary>
        /// Returns gvec4.ragb swizzling.
        /// </summary>
        public gvec4<T> ragb => new gvec4<T>(x, w, y, z);
        
        /// <summary>
        /// Returns gvec4.raga swizzling.
        /// </summary>
        public gvec4<T> raga => new gvec4<T>(x, w, y, w);
        
        /// <summary>
        /// Returns gvec4.rab swizzling.
        /// </summary>
        public gvec3<T> rab => new gvec3<T>(x, w, z);
        
        /// <summary>
        /// Returns gvec4.rabr swizzling.
        /// </summary>
        public gvec4<T> rabr => new gvec4<T>(x, w, z, x);
        
        /// <summary>
        /// Returns gvec4.rabg swizzling.
        /// </summary>
        public gvec4<T> rabg => new gvec4<T>(x, w, z, y);
        
        /// <summary>
        /// Returns gvec4.rabb swizzling.
        /// </summary>
        public gvec4<T> rabb => new gvec4<T>(x, w, z, z);
        
        /// <summary>
        /// Returns gvec4.raba swizzling.
        /// </summary>
        public gvec4<T> raba => new gvec4<T>(x, w, z, w);
        
        /// <summary>
        /// Returns gvec4.raa swizzling.
        /// </summary>
        public gvec3<T> raa => new gvec3<T>(x, w, w);
        
        /// <summary>
        /// Returns gvec4.raar swizzling.
        /// </summary>
        public gvec4<T> raar => new gvec4<T>(x, w, w, x);
        
        /// <summary>
        /// Returns gvec4.raag swizzling.
        /// </summary>
        public gvec4<T> raag => new gvec4<T>(x, w, w, y);
        
        /// <summary>
        /// Returns gvec4.raab swizzling.
        /// </summary>
        public gvec4<T> raab => new gvec4<T>(x, w, w, z);
        
        /// <summary>
        /// Returns gvec4.raaa swizzling.
        /// </summary>
        public gvec4<T> raaa => new gvec4<T>(x, w, w, w);
        
        /// <summary>
        /// Returns gvec4.gr swizzling.
        /// </summary>
        public gvec2<T> gr => new gvec2<T>(y, x);
        
        /// <summary>
        /// Returns gvec4.grr swizzling.
        /// </summary>
        public gvec3<T> grr => new gvec3<T>(y, x, x);
        
        /// <summary>
        /// Returns gvec4.grrr swizzling.
        /// </summary>
        public gvec4<T> grrr => new gvec4<T>(y, x, x, x);
        
        /// <summary>
        /// Returns gvec4.grrg swizzling.
        /// </summary>
        public gvec4<T> grrg => new gvec4<T>(y, x, x, y);
        
        /// <summary>
        /// Returns gvec4.grrb swizzling.
        /// </summary>
        public gvec4<T> grrb => new gvec4<T>(y, x, x, z);
        
        /// <summary>
        /// Returns gvec4.grra swizzling.
        /// </summary>
        public gvec4<T> grra => new gvec4<T>(y, x, x, w);
        
        /// <summary>
        /// Returns gvec4.grg swizzling.
        /// </summary>
        public gvec3<T> grg => new gvec3<T>(y, x, y);
        
        /// <summary>
        /// Returns gvec4.grgr swizzling.
        /// </summary>
        public gvec4<T> grgr => new gvec4<T>(y, x, y, x);
        
        /// <summary>
        /// Returns gvec4.grgg swizzling.
        /// </summary>
        public gvec4<T> grgg => new gvec4<T>(y, x, y, y);
        
        /// <summary>
        /// Returns gvec4.grgb swizzling.
        /// </summary>
        public gvec4<T> grgb => new gvec4<T>(y, x, y, z);
        
        /// <summary>
        /// Returns gvec4.grga swizzling.
        /// </summary>
        public gvec4<T> grga => new gvec4<T>(y, x, y, w);
        
        /// <summary>
        /// Returns gvec4.grb swizzling.
        /// </summary>
        public gvec3<T> grb => new gvec3<T>(y, x, z);
        
        /// <summary>
        /// Returns gvec4.grbr swizzling.
        /// </summary>
        public gvec4<T> grbr => new gvec4<T>(y, x, z, x);
        
        /// <summary>
        /// Returns gvec4.grbg swizzling.
        /// </summary>
        public gvec4<T> grbg => new gvec4<T>(y, x, z, y);
        
        /// <summary>
        /// Returns gvec4.grbb swizzling.
        /// </summary>
        public gvec4<T> grbb => new gvec4<T>(y, x, z, z);
        
        /// <summary>
        /// Returns gvec4.grba swizzling.
        /// </summary>
        public gvec4<T> grba => new gvec4<T>(y, x, z, w);
        
        /// <summary>
        /// Returns gvec4.gra swizzling.
        /// </summary>
        public gvec3<T> gra => new gvec3<T>(y, x, w);
        
        /// <summary>
        /// Returns gvec4.grar swizzling.
        /// </summary>
        public gvec4<T> grar => new gvec4<T>(y, x, w, x);
        
        /// <summary>
        /// Returns gvec4.grag swizzling.
        /// </summary>
        public gvec4<T> grag => new gvec4<T>(y, x, w, y);
        
        /// <summary>
        /// Returns gvec4.grab swizzling.
        /// </summary>
        public gvec4<T> grab => new gvec4<T>(y, x, w, z);
        
        /// <summary>
        /// Returns gvec4.graa swizzling.
        /// </summary>
        public gvec4<T> graa => new gvec4<T>(y, x, w, w);
        
        /// <summary>
        /// Returns gvec4.gg swizzling.
        /// </summary>
        public gvec2<T> gg => new gvec2<T>(y, y);
        
        /// <summary>
        /// Returns gvec4.ggr swizzling.
        /// </summary>
        public gvec3<T> ggr => new gvec3<T>(y, y, x);
        
        /// <summary>
        /// Returns gvec4.ggrr swizzling.
        /// </summary>
        public gvec4<T> ggrr => new gvec4<T>(y, y, x, x);
        
        /// <summary>
        /// Returns gvec4.ggrg swizzling.
        /// </summary>
        public gvec4<T> ggrg => new gvec4<T>(y, y, x, y);
        
        /// <summary>
        /// Returns gvec4.ggrb swizzling.
        /// </summary>
        public gvec4<T> ggrb => new gvec4<T>(y, y, x, z);
        
        /// <summary>
        /// Returns gvec4.ggra swizzling.
        /// </summary>
        public gvec4<T> ggra => new gvec4<T>(y, y, x, w);
        
        /// <summary>
        /// Returns gvec4.ggg swizzling.
        /// </summary>
        public gvec3<T> ggg => new gvec3<T>(y, y, y);
        
        /// <summary>
        /// Returns gvec4.gggr swizzling.
        /// </summary>
        public gvec4<T> gggr => new gvec4<T>(y, y, y, x);
        
        /// <summary>
        /// Returns gvec4.gggg swizzling.
        /// </summary>
        public gvec4<T> gggg => new gvec4<T>(y, y, y, y);
        
        /// <summary>
        /// Returns gvec4.gggb swizzling.
        /// </summary>
        public gvec4<T> gggb => new gvec4<T>(y, y, y, z);
        
        /// <summary>
        /// Returns gvec4.ggga swizzling.
        /// </summary>
        public gvec4<T> ggga => new gvec4<T>(y, y, y, w);
        
        /// <summary>
        /// Returns gvec4.ggb swizzling.
        /// </summary>
        public gvec3<T> ggb => new gvec3<T>(y, y, z);
        
        /// <summary>
        /// Returns gvec4.ggbr swizzling.
        /// </summary>
        public gvec4<T> ggbr => new gvec4<T>(y, y, z, x);
        
        /// <summary>
        /// Returns gvec4.ggbg swizzling.
        /// </summary>
        public gvec4<T> ggbg => new gvec4<T>(y, y, z, y);
        
        /// <summary>
        /// Returns gvec4.ggbb swizzling.
        /// </summary>
        public gvec4<T> ggbb => new gvec4<T>(y, y, z, z);
        
        /// <summary>
        /// Returns gvec4.ggba swizzling.
        /// </summary>
        public gvec4<T> ggba => new gvec4<T>(y, y, z, w);
        
        /// <summary>
        /// Returns gvec4.gga swizzling.
        /// </summary>
        public gvec3<T> gga => new gvec3<T>(y, y, w);
        
        /// <summary>
        /// Returns gvec4.ggar swizzling.
        /// </summary>
        public gvec4<T> ggar => new gvec4<T>(y, y, w, x);
        
        /// <summary>
        /// Returns gvec4.ggag swizzling.
        /// </summary>
        public gvec4<T> ggag => new gvec4<T>(y, y, w, y);
        
        /// <summary>
        /// Returns gvec4.ggab swizzling.
        /// </summary>
        public gvec4<T> ggab => new gvec4<T>(y, y, w, z);
        
        /// <summary>
        /// Returns gvec4.ggaa swizzling.
        /// </summary>
        public gvec4<T> ggaa => new gvec4<T>(y, y, w, w);
        
        /// <summary>
        /// Returns gvec4.gb swizzling.
        /// </summary>
        public gvec2<T> gb => new gvec2<T>(y, z);
        
        /// <summary>
        /// Returns gvec4.gbr swizzling.
        /// </summary>
        public gvec3<T> gbr => new gvec3<T>(y, z, x);
        
        /// <summary>
        /// Returns gvec4.gbrr swizzling.
        /// </summary>
        public gvec4<T> gbrr => new gvec4<T>(y, z, x, x);
        
        /// <summary>
        /// Returns gvec4.gbrg swizzling.
        /// </summary>
        public gvec4<T> gbrg => new gvec4<T>(y, z, x, y);
        
        /// <summary>
        /// Returns gvec4.gbrb swizzling.
        /// </summary>
        public gvec4<T> gbrb => new gvec4<T>(y, z, x, z);
        
        /// <summary>
        /// Returns gvec4.gbra swizzling.
        /// </summary>
        public gvec4<T> gbra => new gvec4<T>(y, z, x, w);
        
        /// <summary>
        /// Returns gvec4.gbg swizzling.
        /// </summary>
        public gvec3<T> gbg => new gvec3<T>(y, z, y);
        
        /// <summary>
        /// Returns gvec4.gbgr swizzling.
        /// </summary>
        public gvec4<T> gbgr => new gvec4<T>(y, z, y, x);
        
        /// <summary>
        /// Returns gvec4.gbgg swizzling.
        /// </summary>
        public gvec4<T> gbgg => new gvec4<T>(y, z, y, y);
        
        /// <summary>
        /// Returns gvec4.gbgb swizzling.
        /// </summary>
        public gvec4<T> gbgb => new gvec4<T>(y, z, y, z);
        
        /// <summary>
        /// Returns gvec4.gbga swizzling.
        /// </summary>
        public gvec4<T> gbga => new gvec4<T>(y, z, y, w);
        
        /// <summary>
        /// Returns gvec4.gbb swizzling.
        /// </summary>
        public gvec3<T> gbb => new gvec3<T>(y, z, z);
        
        /// <summary>
        /// Returns gvec4.gbbr swizzling.
        /// </summary>
        public gvec4<T> gbbr => new gvec4<T>(y, z, z, x);
        
        /// <summary>
        /// Returns gvec4.gbbg swizzling.
        /// </summary>
        public gvec4<T> gbbg => new gvec4<T>(y, z, z, y);
        
        /// <summary>
        /// Returns gvec4.gbbb swizzling.
        /// </summary>
        public gvec4<T> gbbb => new gvec4<T>(y, z, z, z);
        
        /// <summary>
        /// Returns gvec4.gbba swizzling.
        /// </summary>
        public gvec4<T> gbba => new gvec4<T>(y, z, z, w);
        
        /// <summary>
        /// Returns gvec4.gba swizzling.
        /// </summary>
        public gvec3<T> gba => new gvec3<T>(y, z, w);
        
        /// <summary>
        /// Returns gvec4.gbar swizzling.
        /// </summary>
        public gvec4<T> gbar => new gvec4<T>(y, z, w, x);
        
        /// <summary>
        /// Returns gvec4.gbag swizzling.
        /// </summary>
        public gvec4<T> gbag => new gvec4<T>(y, z, w, y);
        
        /// <summary>
        /// Returns gvec4.gbab swizzling.
        /// </summary>
        public gvec4<T> gbab => new gvec4<T>(y, z, w, z);
        
        /// <summary>
        /// Returns gvec4.gbaa swizzling.
        /// </summary>
        public gvec4<T> gbaa => new gvec4<T>(y, z, w, w);
        
        /// <summary>
        /// Returns gvec4.ga swizzling.
        /// </summary>
        public gvec2<T> ga => new gvec2<T>(y, w);
        
        /// <summary>
        /// Returns gvec4.gar swizzling.
        /// </summary>
        public gvec3<T> gar => new gvec3<T>(y, w, x);
        
        /// <summary>
        /// Returns gvec4.garr swizzling.
        /// </summary>
        public gvec4<T> garr => new gvec4<T>(y, w, x, x);
        
        /// <summary>
        /// Returns gvec4.garg swizzling.
        /// </summary>
        public gvec4<T> garg => new gvec4<T>(y, w, x, y);
        
        /// <summary>
        /// Returns gvec4.garb swizzling.
        /// </summary>
        public gvec4<T> garb => new gvec4<T>(y, w, x, z);
        
        /// <summary>
        /// Returns gvec4.gara swizzling.
        /// </summary>
        public gvec4<T> gara => new gvec4<T>(y, w, x, w);
        
        /// <summary>
        /// Returns gvec4.gag swizzling.
        /// </summary>
        public gvec3<T> gag => new gvec3<T>(y, w, y);
        
        /// <summary>
        /// Returns gvec4.gagr swizzling.
        /// </summary>
        public gvec4<T> gagr => new gvec4<T>(y, w, y, x);
        
        /// <summary>
        /// Returns gvec4.gagg swizzling.
        /// </summary>
        public gvec4<T> gagg => new gvec4<T>(y, w, y, y);
        
        /// <summary>
        /// Returns gvec4.gagb swizzling.
        /// </summary>
        public gvec4<T> gagb => new gvec4<T>(y, w, y, z);
        
        /// <summary>
        /// Returns gvec4.gaga swizzling.
        /// </summary>
        public gvec4<T> gaga => new gvec4<T>(y, w, y, w);
        
        /// <summary>
        /// Returns gvec4.gab swizzling.
        /// </summary>
        public gvec3<T> gab => new gvec3<T>(y, w, z);
        
        /// <summary>
        /// Returns gvec4.gabr swizzling.
        /// </summary>
        public gvec4<T> gabr => new gvec4<T>(y, w, z, x);
        
        /// <summary>
        /// Returns gvec4.gabg swizzling.
        /// </summary>
        public gvec4<T> gabg => new gvec4<T>(y, w, z, y);
        
        /// <summary>
        /// Returns gvec4.gabb swizzling.
        /// </summary>
        public gvec4<T> gabb => new gvec4<T>(y, w, z, z);
        
        /// <summary>
        /// Returns gvec4.gaba swizzling.
        /// </summary>
        public gvec4<T> gaba => new gvec4<T>(y, w, z, w);
        
        /// <summary>
        /// Returns gvec4.gaa swizzling.
        /// </summary>
        public gvec3<T> gaa => new gvec3<T>(y, w, w);
        
        /// <summary>
        /// Returns gvec4.gaar swizzling.
        /// </summary>
        public gvec4<T> gaar => new gvec4<T>(y, w, w, x);
        
        /// <summary>
        /// Returns gvec4.gaag swizzling.
        /// </summary>
        public gvec4<T> gaag => new gvec4<T>(y, w, w, y);
        
        /// <summary>
        /// Returns gvec4.gaab swizzling.
        /// </summary>
        public gvec4<T> gaab => new gvec4<T>(y, w, w, z);
        
        /// <summary>
        /// Returns gvec4.gaaa swizzling.
        /// </summary>
        public gvec4<T> gaaa => new gvec4<T>(y, w, w, w);
        
        /// <summary>
        /// Returns gvec4.br swizzling.
        /// </summary>
        public gvec2<T> br => new gvec2<T>(z, x);
        
        /// <summary>
        /// Returns gvec4.brr swizzling.
        /// </summary>
        public gvec3<T> brr => new gvec3<T>(z, x, x);
        
        /// <summary>
        /// Returns gvec4.brrr swizzling.
        /// </summary>
        public gvec4<T> brrr => new gvec4<T>(z, x, x, x);
        
        /// <summary>
        /// Returns gvec4.brrg swizzling.
        /// </summary>
        public gvec4<T> brrg => new gvec4<T>(z, x, x, y);
        
        /// <summary>
        /// Returns gvec4.brrb swizzling.
        /// </summary>
        public gvec4<T> brrb => new gvec4<T>(z, x, x, z);
        
        /// <summary>
        /// Returns gvec4.brra swizzling.
        /// </summary>
        public gvec4<T> brra => new gvec4<T>(z, x, x, w);
        
        /// <summary>
        /// Returns gvec4.brg swizzling.
        /// </summary>
        public gvec3<T> brg => new gvec3<T>(z, x, y);
        
        /// <summary>
        /// Returns gvec4.brgr swizzling.
        /// </summary>
        public gvec4<T> brgr => new gvec4<T>(z, x, y, x);
        
        /// <summary>
        /// Returns gvec4.brgg swizzling.
        /// </summary>
        public gvec4<T> brgg => new gvec4<T>(z, x, y, y);
        
        /// <summary>
        /// Returns gvec4.brgb swizzling.
        /// </summary>
        public gvec4<T> brgb => new gvec4<T>(z, x, y, z);
        
        /// <summary>
        /// Returns gvec4.brga swizzling.
        /// </summary>
        public gvec4<T> brga => new gvec4<T>(z, x, y, w);
        
        /// <summary>
        /// Returns gvec4.brb swizzling.
        /// </summary>
        public gvec3<T> brb => new gvec3<T>(z, x, z);
        
        /// <summary>
        /// Returns gvec4.brbr swizzling.
        /// </summary>
        public gvec4<T> brbr => new gvec4<T>(z, x, z, x);
        
        /// <summary>
        /// Returns gvec4.brbg swizzling.
        /// </summary>
        public gvec4<T> brbg => new gvec4<T>(z, x, z, y);
        
        /// <summary>
        /// Returns gvec4.brbb swizzling.
        /// </summary>
        public gvec4<T> brbb => new gvec4<T>(z, x, z, z);
        
        /// <summary>
        /// Returns gvec4.brba swizzling.
        /// </summary>
        public gvec4<T> brba => new gvec4<T>(z, x, z, w);
        
        /// <summary>
        /// Returns gvec4.bra swizzling.
        /// </summary>
        public gvec3<T> bra => new gvec3<T>(z, x, w);
        
        /// <summary>
        /// Returns gvec4.brar swizzling.
        /// </summary>
        public gvec4<T> brar => new gvec4<T>(z, x, w, x);
        
        /// <summary>
        /// Returns gvec4.brag swizzling.
        /// </summary>
        public gvec4<T> brag => new gvec4<T>(z, x, w, y);
        
        /// <summary>
        /// Returns gvec4.brab swizzling.
        /// </summary>
        public gvec4<T> brab => new gvec4<T>(z, x, w, z);
        
        /// <summary>
        /// Returns gvec4.braa swizzling.
        /// </summary>
        public gvec4<T> braa => new gvec4<T>(z, x, w, w);
        
        /// <summary>
        /// Returns gvec4.bg swizzling.
        /// </summary>
        public gvec2<T> bg => new gvec2<T>(z, y);
        
        /// <summary>
        /// Returns gvec4.bgr swizzling.
        /// </summary>
        public gvec3<T> bgr => new gvec3<T>(z, y, x);
        
        /// <summary>
        /// Returns gvec4.bgrr swizzling.
        /// </summary>
        public gvec4<T> bgrr => new gvec4<T>(z, y, x, x);
        
        /// <summary>
        /// Returns gvec4.bgrg swizzling.
        /// </summary>
        public gvec4<T> bgrg => new gvec4<T>(z, y, x, y);
        
        /// <summary>
        /// Returns gvec4.bgrb swizzling.
        /// </summary>
        public gvec4<T> bgrb => new gvec4<T>(z, y, x, z);
        
        /// <summary>
        /// Returns gvec4.bgra swizzling.
        /// </summary>
        public gvec4<T> bgra => new gvec4<T>(z, y, x, w);
        
        /// <summary>
        /// Returns gvec4.bgg swizzling.
        /// </summary>
        public gvec3<T> bgg => new gvec3<T>(z, y, y);
        
        /// <summary>
        /// Returns gvec4.bggr swizzling.
        /// </summary>
        public gvec4<T> bggr => new gvec4<T>(z, y, y, x);
        
        /// <summary>
        /// Returns gvec4.bggg swizzling.
        /// </summary>
        public gvec4<T> bggg => new gvec4<T>(z, y, y, y);
        
        /// <summary>
        /// Returns gvec4.bggb swizzling.
        /// </summary>
        public gvec4<T> bggb => new gvec4<T>(z, y, y, z);
        
        /// <summary>
        /// Returns gvec4.bgga swizzling.
        /// </summary>
        public gvec4<T> bgga => new gvec4<T>(z, y, y, w);
        
        /// <summary>
        /// Returns gvec4.bgb swizzling.
        /// </summary>
        public gvec3<T> bgb => new gvec3<T>(z, y, z);
        
        /// <summary>
        /// Returns gvec4.bgbr swizzling.
        /// </summary>
        public gvec4<T> bgbr => new gvec4<T>(z, y, z, x);
        
        /// <summary>
        /// Returns gvec4.bgbg swizzling.
        /// </summary>
        public gvec4<T> bgbg => new gvec4<T>(z, y, z, y);
        
        /// <summary>
        /// Returns gvec4.bgbb swizzling.
        /// </summary>
        public gvec4<T> bgbb => new gvec4<T>(z, y, z, z);
        
        /// <summary>
        /// Returns gvec4.bgba swizzling.
        /// </summary>
        public gvec4<T> bgba => new gvec4<T>(z, y, z, w);
        
        /// <summary>
        /// Returns gvec4.bga swizzling.
        /// </summary>
        public gvec3<T> bga => new gvec3<T>(z, y, w);
        
        /// <summary>
        /// Returns gvec4.bgar swizzling.
        /// </summary>
        public gvec4<T> bgar => new gvec4<T>(z, y, w, x);
        
        /// <summary>
        /// Returns gvec4.bgag swizzling.
        /// </summary>
        public gvec4<T> bgag => new gvec4<T>(z, y, w, y);
        
        /// <summary>
        /// Returns gvec4.bgab swizzling.
        /// </summary>
        public gvec4<T> bgab => new gvec4<T>(z, y, w, z);
        
        /// <summary>
        /// Returns gvec4.bgaa swizzling.
        /// </summary>
        public gvec4<T> bgaa => new gvec4<T>(z, y, w, w);
        
        /// <summary>
        /// Returns gvec4.bb swizzling.
        /// </summary>
        public gvec2<T> bb => new gvec2<T>(z, z);
        
        /// <summary>
        /// Returns gvec4.bbr swizzling.
        /// </summary>
        public gvec3<T> bbr => new gvec3<T>(z, z, x);
        
        /// <summary>
        /// Returns gvec4.bbrr swizzling.
        /// </summary>
        public gvec4<T> bbrr => new gvec4<T>(z, z, x, x);
        
        /// <summary>
        /// Returns gvec4.bbrg swizzling.
        /// </summary>
        public gvec4<T> bbrg => new gvec4<T>(z, z, x, y);
        
        /// <summary>
        /// Returns gvec4.bbrb swizzling.
        /// </summary>
        public gvec4<T> bbrb => new gvec4<T>(z, z, x, z);
        
        /// <summary>
        /// Returns gvec4.bbra swizzling.
        /// </summary>
        public gvec4<T> bbra => new gvec4<T>(z, z, x, w);
        
        /// <summary>
        /// Returns gvec4.bbg swizzling.
        /// </summary>
        public gvec3<T> bbg => new gvec3<T>(z, z, y);
        
        /// <summary>
        /// Returns gvec4.bbgr swizzling.
        /// </summary>
        public gvec4<T> bbgr => new gvec4<T>(z, z, y, x);
        
        /// <summary>
        /// Returns gvec4.bbgg swizzling.
        /// </summary>
        public gvec4<T> bbgg => new gvec4<T>(z, z, y, y);
        
        /// <summary>
        /// Returns gvec4.bbgb swizzling.
        /// </summary>
        public gvec4<T> bbgb => new gvec4<T>(z, z, y, z);
        
        /// <summary>
        /// Returns gvec4.bbga swizzling.
        /// </summary>
        public gvec4<T> bbga => new gvec4<T>(z, z, y, w);
        
        /// <summary>
        /// Returns gvec4.bbb swizzling.
        /// </summary>
        public gvec3<T> bbb => new gvec3<T>(z, z, z);
        
        /// <summary>
        /// Returns gvec4.bbbr swizzling.
        /// </summary>
        public gvec4<T> bbbr => new gvec4<T>(z, z, z, x);
        
        /// <summary>
        /// Returns gvec4.bbbg swizzling.
        /// </summary>
        public gvec4<T> bbbg => new gvec4<T>(z, z, z, y);
        
        /// <summary>
        /// Returns gvec4.bbbb swizzling.
        /// </summary>
        public gvec4<T> bbbb => new gvec4<T>(z, z, z, z);
        
        /// <summary>
        /// Returns gvec4.bbba swizzling.
        /// </summary>
        public gvec4<T> bbba => new gvec4<T>(z, z, z, w);
        
        /// <summary>
        /// Returns gvec4.bba swizzling.
        /// </summary>
        public gvec3<T> bba => new gvec3<T>(z, z, w);
        
        /// <summary>
        /// Returns gvec4.bbar swizzling.
        /// </summary>
        public gvec4<T> bbar => new gvec4<T>(z, z, w, x);
        
        /// <summary>
        /// Returns gvec4.bbag swizzling.
        /// </summary>
        public gvec4<T> bbag => new gvec4<T>(z, z, w, y);
        
        /// <summary>
        /// Returns gvec4.bbab swizzling.
        /// </summary>
        public gvec4<T> bbab => new gvec4<T>(z, z, w, z);
        
        /// <summary>
        /// Returns gvec4.bbaa swizzling.
        /// </summary>
        public gvec4<T> bbaa => new gvec4<T>(z, z, w, w);
        
        /// <summary>
        /// Returns gvec4.ba swizzling.
        /// </summary>
        public gvec2<T> ba => new gvec2<T>(z, w);
        
        /// <summary>
        /// Returns gvec4.bar swizzling.
        /// </summary>
        public gvec3<T> bar => new gvec3<T>(z, w, x);
        
        /// <summary>
        /// Returns gvec4.barr swizzling.
        /// </summary>
        public gvec4<T> barr => new gvec4<T>(z, w, x, x);
        
        /// <summary>
        /// Returns gvec4.barg swizzling.
        /// </summary>
        public gvec4<T> barg => new gvec4<T>(z, w, x, y);
        
        /// <summary>
        /// Returns gvec4.barb swizzling.
        /// </summary>
        public gvec4<T> barb => new gvec4<T>(z, w, x, z);
        
        /// <summary>
        /// Returns gvec4.bara swizzling.
        /// </summary>
        public gvec4<T> bara => new gvec4<T>(z, w, x, w);
        
        /// <summary>
        /// Returns gvec4.bag swizzling.
        /// </summary>
        public gvec3<T> bag => new gvec3<T>(z, w, y);
        
        /// <summary>
        /// Returns gvec4.bagr swizzling.
        /// </summary>
        public gvec4<T> bagr => new gvec4<T>(z, w, y, x);
        
        /// <summary>
        /// Returns gvec4.bagg swizzling.
        /// </summary>
        public gvec4<T> bagg => new gvec4<T>(z, w, y, y);
        
        /// <summary>
        /// Returns gvec4.bagb swizzling.
        /// </summary>
        public gvec4<T> bagb => new gvec4<T>(z, w, y, z);
        
        /// <summary>
        /// Returns gvec4.baga swizzling.
        /// </summary>
        public gvec4<T> baga => new gvec4<T>(z, w, y, w);
        
        /// <summary>
        /// Returns gvec4.bab swizzling.
        /// </summary>
        public gvec3<T> bab => new gvec3<T>(z, w, z);
        
        /// <summary>
        /// Returns gvec4.babr swizzling.
        /// </summary>
        public gvec4<T> babr => new gvec4<T>(z, w, z, x);
        
        /// <summary>
        /// Returns gvec4.babg swizzling.
        /// </summary>
        public gvec4<T> babg => new gvec4<T>(z, w, z, y);
        
        /// <summary>
        /// Returns gvec4.babb swizzling.
        /// </summary>
        public gvec4<T> babb => new gvec4<T>(z, w, z, z);
        
        /// <summary>
        /// Returns gvec4.baba swizzling.
        /// </summary>
        public gvec4<T> baba => new gvec4<T>(z, w, z, w);
        
        /// <summary>
        /// Returns gvec4.baa swizzling.
        /// </summary>
        public gvec3<T> baa => new gvec3<T>(z, w, w);
        
        /// <summary>
        /// Returns gvec4.baar swizzling.
        /// </summary>
        public gvec4<T> baar => new gvec4<T>(z, w, w, x);
        
        /// <summary>
        /// Returns gvec4.baag swizzling.
        /// </summary>
        public gvec4<T> baag => new gvec4<T>(z, w, w, y);
        
        /// <summary>
        /// Returns gvec4.baab swizzling.
        /// </summary>
        public gvec4<T> baab => new gvec4<T>(z, w, w, z);
        
        /// <summary>
        /// Returns gvec4.baaa swizzling.
        /// </summary>
        public gvec4<T> baaa => new gvec4<T>(z, w, w, w);
        
        /// <summary>
        /// Returns gvec4.ar swizzling.
        /// </summary>
        public gvec2<T> ar => new gvec2<T>(w, x);
        
        /// <summary>
        /// Returns gvec4.arr swizzling.
        /// </summary>
        public gvec3<T> arr => new gvec3<T>(w, x, x);
        
        /// <summary>
        /// Returns gvec4.arrr swizzling.
        /// </summary>
        public gvec4<T> arrr => new gvec4<T>(w, x, x, x);
        
        /// <summary>
        /// Returns gvec4.arrg swizzling.
        /// </summary>
        public gvec4<T> arrg => new gvec4<T>(w, x, x, y);
        
        /// <summary>
        /// Returns gvec4.arrb swizzling.
        /// </summary>
        public gvec4<T> arrb => new gvec4<T>(w, x, x, z);
        
        /// <summary>
        /// Returns gvec4.arra swizzling.
        /// </summary>
        public gvec4<T> arra => new gvec4<T>(w, x, x, w);
        
        /// <summary>
        /// Returns gvec4.arg swizzling.
        /// </summary>
        public gvec3<T> arg => new gvec3<T>(w, x, y);
        
        /// <summary>
        /// Returns gvec4.argr swizzling.
        /// </summary>
        public gvec4<T> argr => new gvec4<T>(w, x, y, x);
        
        /// <summary>
        /// Returns gvec4.argg swizzling.
        /// </summary>
        public gvec4<T> argg => new gvec4<T>(w, x, y, y);
        
        /// <summary>
        /// Returns gvec4.argb swizzling.
        /// </summary>
        public gvec4<T> argb => new gvec4<T>(w, x, y, z);
        
        /// <summary>
        /// Returns gvec4.arga swizzling.
        /// </summary>
        public gvec4<T> arga => new gvec4<T>(w, x, y, w);
        
        /// <summary>
        /// Returns gvec4.arb swizzling.
        /// </summary>
        public gvec3<T> arb => new gvec3<T>(w, x, z);
        
        /// <summary>
        /// Returns gvec4.arbr swizzling.
        /// </summary>
        public gvec4<T> arbr => new gvec4<T>(w, x, z, x);
        
        /// <summary>
        /// Returns gvec4.arbg swizzling.
        /// </summary>
        public gvec4<T> arbg => new gvec4<T>(w, x, z, y);
        
        /// <summary>
        /// Returns gvec4.arbb swizzling.
        /// </summary>
        public gvec4<T> arbb => new gvec4<T>(w, x, z, z);
        
        /// <summary>
        /// Returns gvec4.arba swizzling.
        /// </summary>
        public gvec4<T> arba => new gvec4<T>(w, x, z, w);
        
        /// <summary>
        /// Returns gvec4.ara swizzling.
        /// </summary>
        public gvec3<T> ara => new gvec3<T>(w, x, w);
        
        /// <summary>
        /// Returns gvec4.arar swizzling.
        /// </summary>
        public gvec4<T> arar => new gvec4<T>(w, x, w, x);
        
        /// <summary>
        /// Returns gvec4.arag swizzling.
        /// </summary>
        public gvec4<T> arag => new gvec4<T>(w, x, w, y);
        
        /// <summary>
        /// Returns gvec4.arab swizzling.
        /// </summary>
        public gvec4<T> arab => new gvec4<T>(w, x, w, z);
        
        /// <summary>
        /// Returns gvec4.araa swizzling.
        /// </summary>
        public gvec4<T> araa => new gvec4<T>(w, x, w, w);
        
        /// <summary>
        /// Returns gvec4.ag swizzling.
        /// </summary>
        public gvec2<T> ag => new gvec2<T>(w, y);
        
        /// <summary>
        /// Returns gvec4.agr swizzling.
        /// </summary>
        public gvec3<T> agr => new gvec3<T>(w, y, x);
        
        /// <summary>
        /// Returns gvec4.agrr swizzling.
        /// </summary>
        public gvec4<T> agrr => new gvec4<T>(w, y, x, x);
        
        /// <summary>
        /// Returns gvec4.agrg swizzling.
        /// </summary>
        public gvec4<T> agrg => new gvec4<T>(w, y, x, y);
        
        /// <summary>
        /// Returns gvec4.agrb swizzling.
        /// </summary>
        public gvec4<T> agrb => new gvec4<T>(w, y, x, z);
        
        /// <summary>
        /// Returns gvec4.agra swizzling.
        /// </summary>
        public gvec4<T> agra => new gvec4<T>(w, y, x, w);
        
        /// <summary>
        /// Returns gvec4.agg swizzling.
        /// </summary>
        public gvec3<T> agg => new gvec3<T>(w, y, y);
        
        /// <summary>
        /// Returns gvec4.aggr swizzling.
        /// </summary>
        public gvec4<T> aggr => new gvec4<T>(w, y, y, x);
        
        /// <summary>
        /// Returns gvec4.aggg swizzling.
        /// </summary>
        public gvec4<T> aggg => new gvec4<T>(w, y, y, y);
        
        /// <summary>
        /// Returns gvec4.aggb swizzling.
        /// </summary>
        public gvec4<T> aggb => new gvec4<T>(w, y, y, z);
        
        /// <summary>
        /// Returns gvec4.agga swizzling.
        /// </summary>
        public gvec4<T> agga => new gvec4<T>(w, y, y, w);
        
        /// <summary>
        /// Returns gvec4.agb swizzling.
        /// </summary>
        public gvec3<T> agb => new gvec3<T>(w, y, z);
        
        /// <summary>
        /// Returns gvec4.agbr swizzling.
        /// </summary>
        public gvec4<T> agbr => new gvec4<T>(w, y, z, x);
        
        /// <summary>
        /// Returns gvec4.agbg swizzling.
        /// </summary>
        public gvec4<T> agbg => new gvec4<T>(w, y, z, y);
        
        /// <summary>
        /// Returns gvec4.agbb swizzling.
        /// </summary>
        public gvec4<T> agbb => new gvec4<T>(w, y, z, z);
        
        /// <summary>
        /// Returns gvec4.agba swizzling.
        /// </summary>
        public gvec4<T> agba => new gvec4<T>(w, y, z, w);
        
        /// <summary>
        /// Returns gvec4.aga swizzling.
        /// </summary>
        public gvec3<T> aga => new gvec3<T>(w, y, w);
        
        /// <summary>
        /// Returns gvec4.agar swizzling.
        /// </summary>
        public gvec4<T> agar => new gvec4<T>(w, y, w, x);
        
        /// <summary>
        /// Returns gvec4.agag swizzling.
        /// </summary>
        public gvec4<T> agag => new gvec4<T>(w, y, w, y);
        
        /// <summary>
        /// Returns gvec4.agab swizzling.
        /// </summary>
        public gvec4<T> agab => new gvec4<T>(w, y, w, z);
        
        /// <summary>
        /// Returns gvec4.agaa swizzling.
        /// </summary>
        public gvec4<T> agaa => new gvec4<T>(w, y, w, w);
        
        /// <summary>
        /// Returns gvec4.ab swizzling.
        /// </summary>
        public gvec2<T> ab => new gvec2<T>(w, z);
        
        /// <summary>
        /// Returns gvec4.abr swizzling.
        /// </summary>
        public gvec3<T> abr => new gvec3<T>(w, z, x);
        
        /// <summary>
        /// Returns gvec4.abrr swizzling.
        /// </summary>
        public gvec4<T> abrr => new gvec4<T>(w, z, x, x);
        
        /// <summary>
        /// Returns gvec4.abrg swizzling.
        /// </summary>
        public gvec4<T> abrg => new gvec4<T>(w, z, x, y);
        
        /// <summary>
        /// Returns gvec4.abrb swizzling.
        /// </summary>
        public gvec4<T> abrb => new gvec4<T>(w, z, x, z);
        
        /// <summary>
        /// Returns gvec4.abra swizzling.
        /// </summary>
        public gvec4<T> abra => new gvec4<T>(w, z, x, w);
        
        /// <summary>
        /// Returns gvec4.abg swizzling.
        /// </summary>
        public gvec3<T> abg => new gvec3<T>(w, z, y);
        
        /// <summary>
        /// Returns gvec4.abgr swizzling.
        /// </summary>
        public gvec4<T> abgr => new gvec4<T>(w, z, y, x);
        
        /// <summary>
        /// Returns gvec4.abgg swizzling.
        /// </summary>
        public gvec4<T> abgg => new gvec4<T>(w, z, y, y);
        
        /// <summary>
        /// Returns gvec4.abgb swizzling.
        /// </summary>
        public gvec4<T> abgb => new gvec4<T>(w, z, y, z);
        
        /// <summary>
        /// Returns gvec4.abga swizzling.
        /// </summary>
        public gvec4<T> abga => new gvec4<T>(w, z, y, w);
        
        /// <summary>
        /// Returns gvec4.abb swizzling.
        /// </summary>
        public gvec3<T> abb => new gvec3<T>(w, z, z);
        
        /// <summary>
        /// Returns gvec4.abbr swizzling.
        /// </summary>
        public gvec4<T> abbr => new gvec4<T>(w, z, z, x);
        
        /// <summary>
        /// Returns gvec4.abbg swizzling.
        /// </summary>
        public gvec4<T> abbg => new gvec4<T>(w, z, z, y);
        
        /// <summary>
        /// Returns gvec4.abbb swizzling.
        /// </summary>
        public gvec4<T> abbb => new gvec4<T>(w, z, z, z);
        
        /// <summary>
        /// Returns gvec4.abba swizzling.
        /// </summary>
        public gvec4<T> abba => new gvec4<T>(w, z, z, w);
        
        /// <summary>
        /// Returns gvec4.aba swizzling.
        /// </summary>
        public gvec3<T> aba => new gvec3<T>(w, z, w);
        
        /// <summary>
        /// Returns gvec4.abar swizzling.
        /// </summary>
        public gvec4<T> abar => new gvec4<T>(w, z, w, x);
        
        /// <summary>
        /// Returns gvec4.abag swizzling.
        /// </summary>
        public gvec4<T> abag => new gvec4<T>(w, z, w, y);
        
        /// <summary>
        /// Returns gvec4.abab swizzling.
        /// </summary>
        public gvec4<T> abab => new gvec4<T>(w, z, w, z);
        
        /// <summary>
        /// Returns gvec4.abaa swizzling.
        /// </summary>
        public gvec4<T> abaa => new gvec4<T>(w, z, w, w);
        
        /// <summary>
        /// Returns gvec4.aa swizzling.
        /// </summary>
        public gvec2<T> aa => new gvec2<T>(w, w);
        
        /// <summary>
        /// Returns gvec4.aar swizzling.
        /// </summary>
        public gvec3<T> aar => new gvec3<T>(w, w, x);
        
        /// <summary>
        /// Returns gvec4.aarr swizzling.
        /// </summary>
        public gvec4<T> aarr => new gvec4<T>(w, w, x, x);
        
        /// <summary>
        /// Returns gvec4.aarg swizzling.
        /// </summary>
        public gvec4<T> aarg => new gvec4<T>(w, w, x, y);
        
        /// <summary>
        /// Returns gvec4.aarb swizzling.
        /// </summary>
        public gvec4<T> aarb => new gvec4<T>(w, w, x, z);
        
        /// <summary>
        /// Returns gvec4.aara swizzling.
        /// </summary>
        public gvec4<T> aara => new gvec4<T>(w, w, x, w);
        
        /// <summary>
        /// Returns gvec4.aag swizzling.
        /// </summary>
        public gvec3<T> aag => new gvec3<T>(w, w, y);
        
        /// <summary>
        /// Returns gvec4.aagr swizzling.
        /// </summary>
        public gvec4<T> aagr => new gvec4<T>(w, w, y, x);
        
        /// <summary>
        /// Returns gvec4.aagg swizzling.
        /// </summary>
        public gvec4<T> aagg => new gvec4<T>(w, w, y, y);
        
        /// <summary>
        /// Returns gvec4.aagb swizzling.
        /// </summary>
        public gvec4<T> aagb => new gvec4<T>(w, w, y, z);
        
        /// <summary>
        /// Returns gvec4.aaga swizzling.
        /// </summary>
        public gvec4<T> aaga => new gvec4<T>(w, w, y, w);
        
        /// <summary>
        /// Returns gvec4.aab swizzling.
        /// </summary>
        public gvec3<T> aab => new gvec3<T>(w, w, z);
        
        /// <summary>
        /// Returns gvec4.aabr swizzling.
        /// </summary>
        public gvec4<T> aabr => new gvec4<T>(w, w, z, x);
        
        /// <summary>
        /// Returns gvec4.aabg swizzling.
        /// </summary>
        public gvec4<T> aabg => new gvec4<T>(w, w, z, y);
        
        /// <summary>
        /// Returns gvec4.aabb swizzling.
        /// </summary>
        public gvec4<T> aabb => new gvec4<T>(w, w, z, z);
        
        /// <summary>
        /// Returns gvec4.aaba swizzling.
        /// </summary>
        public gvec4<T> aaba => new gvec4<T>(w, w, z, w);
        
        /// <summary>
        /// Returns gvec4.aaa swizzling.
        /// </summary>
        public gvec3<T> aaa => new gvec3<T>(w, w, w);
        
        /// <summary>
        /// Returns gvec4.aaar swizzling.
        /// </summary>
        public gvec4<T> aaar => new gvec4<T>(w, w, w, x);
        
        /// <summary>
        /// Returns gvec4.aaag swizzling.
        /// </summary>
        public gvec4<T> aaag => new gvec4<T>(w, w, w, y);
        
        /// <summary>
        /// Returns gvec4.aaab swizzling.
        /// </summary>
        public gvec4<T> aaab => new gvec4<T>(w, w, w, z);
        
        /// <summary>
        /// Returns gvec4.aaaa swizzling.
        /// </summary>
        public gvec4<T> aaaa => new gvec4<T>(w, w, w, w);
    }
}
