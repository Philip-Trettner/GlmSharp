using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    
    /// <summary>
    /// Temporary vector of type bool with 4 components, used for implementing swizzling for bvec4.
    /// </summary>
    [Serializable]
    public struct swizzle_bvec4
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly bool z;
        
        /// <summary>
        /// w-component
        /// </summary>
        internal readonly bool w;
        
        
        /// <summary>
        /// Constructor for swizzle_bvec4.
        /// </summary>
        internal swizzle_bvec4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns bvec4.xx swizzling.
        /// </summary>
        public bvec2 xx => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec4.xxx swizzling.
        /// </summary>
        public bvec3 xxx => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec4.xxxx swizzling.
        /// </summary>
        public bvec4 xxxx => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.xxxy swizzling.
        /// </summary>
        public bvec4 xxxy => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.xxxz swizzling.
        /// </summary>
        public bvec4 xxxz => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.xxxw swizzling.
        /// </summary>
        public bvec4 xxxw => new bvec4(x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.xxy swizzling.
        /// </summary>
        public bvec3 xxy => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec4.xxyx swizzling.
        /// </summary>
        public bvec4 xxyx => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.xxyy swizzling.
        /// </summary>
        public bvec4 xxyy => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.xxyz swizzling.
        /// </summary>
        public bvec4 xxyz => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.xxyw swizzling.
        /// </summary>
        public bvec4 xxyw => new bvec4(x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.xxz swizzling.
        /// </summary>
        public bvec3 xxz => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec4.xxzx swizzling.
        /// </summary>
        public bvec4 xxzx => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.xxzy swizzling.
        /// </summary>
        public bvec4 xxzy => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.xxzz swizzling.
        /// </summary>
        public bvec4 xxzz => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.xxzw swizzling.
        /// </summary>
        public bvec4 xxzw => new bvec4(x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.xxw swizzling.
        /// </summary>
        public bvec3 xxw => new bvec3(x, x, w);
        
        /// <summary>
        /// Returns bvec4.xxwx swizzling.
        /// </summary>
        public bvec4 xxwx => new bvec4(x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.xxwy swizzling.
        /// </summary>
        public bvec4 xxwy => new bvec4(x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.xxwz swizzling.
        /// </summary>
        public bvec4 xxwz => new bvec4(x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.xxww swizzling.
        /// </summary>
        public bvec4 xxww => new bvec4(x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.xy swizzling.
        /// </summary>
        public bvec2 xy => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec4.xyx swizzling.
        /// </summary>
        public bvec3 xyx => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec4.xyxx swizzling.
        /// </summary>
        public bvec4 xyxx => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.xyxy swizzling.
        /// </summary>
        public bvec4 xyxy => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.xyxz swizzling.
        /// </summary>
        public bvec4 xyxz => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.xyxw swizzling.
        /// </summary>
        public bvec4 xyxw => new bvec4(x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.xyy swizzling.
        /// </summary>
        public bvec3 xyy => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec4.xyyx swizzling.
        /// </summary>
        public bvec4 xyyx => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.xyyy swizzling.
        /// </summary>
        public bvec4 xyyy => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.xyyz swizzling.
        /// </summary>
        public bvec4 xyyz => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.xyyw swizzling.
        /// </summary>
        public bvec4 xyyw => new bvec4(x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.xyz swizzling.
        /// </summary>
        public bvec3 xyz => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec4.xyzx swizzling.
        /// </summary>
        public bvec4 xyzx => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.xyzy swizzling.
        /// </summary>
        public bvec4 xyzy => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.xyzz swizzling.
        /// </summary>
        public bvec4 xyzz => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.xyzw swizzling.
        /// </summary>
        public bvec4 xyzw => new bvec4(x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.xyw swizzling.
        /// </summary>
        public bvec3 xyw => new bvec3(x, y, w);
        
        /// <summary>
        /// Returns bvec4.xywx swizzling.
        /// </summary>
        public bvec4 xywx => new bvec4(x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.xywy swizzling.
        /// </summary>
        public bvec4 xywy => new bvec4(x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.xywz swizzling.
        /// </summary>
        public bvec4 xywz => new bvec4(x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.xyww swizzling.
        /// </summary>
        public bvec4 xyww => new bvec4(x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.xz swizzling.
        /// </summary>
        public bvec2 xz => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec4.xzx swizzling.
        /// </summary>
        public bvec3 xzx => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec4.xzxx swizzling.
        /// </summary>
        public bvec4 xzxx => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.xzxy swizzling.
        /// </summary>
        public bvec4 xzxy => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.xzxz swizzling.
        /// </summary>
        public bvec4 xzxz => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.xzxw swizzling.
        /// </summary>
        public bvec4 xzxw => new bvec4(x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.xzy swizzling.
        /// </summary>
        public bvec3 xzy => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec4.xzyx swizzling.
        /// </summary>
        public bvec4 xzyx => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.xzyy swizzling.
        /// </summary>
        public bvec4 xzyy => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.xzyz swizzling.
        /// </summary>
        public bvec4 xzyz => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.xzyw swizzling.
        /// </summary>
        public bvec4 xzyw => new bvec4(x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.xzz swizzling.
        /// </summary>
        public bvec3 xzz => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec4.xzzx swizzling.
        /// </summary>
        public bvec4 xzzx => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.xzzy swizzling.
        /// </summary>
        public bvec4 xzzy => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.xzzz swizzling.
        /// </summary>
        public bvec4 xzzz => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.xzzw swizzling.
        /// </summary>
        public bvec4 xzzw => new bvec4(x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.xzw swizzling.
        /// </summary>
        public bvec3 xzw => new bvec3(x, z, w);
        
        /// <summary>
        /// Returns bvec4.xzwx swizzling.
        /// </summary>
        public bvec4 xzwx => new bvec4(x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.xzwy swizzling.
        /// </summary>
        public bvec4 xzwy => new bvec4(x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.xzwz swizzling.
        /// </summary>
        public bvec4 xzwz => new bvec4(x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.xzww swizzling.
        /// </summary>
        public bvec4 xzww => new bvec4(x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.xw swizzling.
        /// </summary>
        public bvec2 xw => new bvec2(x, w);
        
        /// <summary>
        /// Returns bvec4.xwx swizzling.
        /// </summary>
        public bvec3 xwx => new bvec3(x, w, x);
        
        /// <summary>
        /// Returns bvec4.xwxx swizzling.
        /// </summary>
        public bvec4 xwxx => new bvec4(x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.xwxy swizzling.
        /// </summary>
        public bvec4 xwxy => new bvec4(x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.xwxz swizzling.
        /// </summary>
        public bvec4 xwxz => new bvec4(x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.xwxw swizzling.
        /// </summary>
        public bvec4 xwxw => new bvec4(x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.xwy swizzling.
        /// </summary>
        public bvec3 xwy => new bvec3(x, w, y);
        
        /// <summary>
        /// Returns bvec4.xwyx swizzling.
        /// </summary>
        public bvec4 xwyx => new bvec4(x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.xwyy swizzling.
        /// </summary>
        public bvec4 xwyy => new bvec4(x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.xwyz swizzling.
        /// </summary>
        public bvec4 xwyz => new bvec4(x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.xwyw swizzling.
        /// </summary>
        public bvec4 xwyw => new bvec4(x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.xwz swizzling.
        /// </summary>
        public bvec3 xwz => new bvec3(x, w, z);
        
        /// <summary>
        /// Returns bvec4.xwzx swizzling.
        /// </summary>
        public bvec4 xwzx => new bvec4(x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.xwzy swizzling.
        /// </summary>
        public bvec4 xwzy => new bvec4(x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.xwzz swizzling.
        /// </summary>
        public bvec4 xwzz => new bvec4(x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.xwzw swizzling.
        /// </summary>
        public bvec4 xwzw => new bvec4(x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.xww swizzling.
        /// </summary>
        public bvec3 xww => new bvec3(x, w, w);
        
        /// <summary>
        /// Returns bvec4.xwwx swizzling.
        /// </summary>
        public bvec4 xwwx => new bvec4(x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.xwwy swizzling.
        /// </summary>
        public bvec4 xwwy => new bvec4(x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.xwwz swizzling.
        /// </summary>
        public bvec4 xwwz => new bvec4(x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.xwww swizzling.
        /// </summary>
        public bvec4 xwww => new bvec4(x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.yx swizzling.
        /// </summary>
        public bvec2 yx => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec4.yxx swizzling.
        /// </summary>
        public bvec3 yxx => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec4.yxxx swizzling.
        /// </summary>
        public bvec4 yxxx => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.yxxy swizzling.
        /// </summary>
        public bvec4 yxxy => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.yxxz swizzling.
        /// </summary>
        public bvec4 yxxz => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.yxxw swizzling.
        /// </summary>
        public bvec4 yxxw => new bvec4(y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.yxy swizzling.
        /// </summary>
        public bvec3 yxy => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec4.yxyx swizzling.
        /// </summary>
        public bvec4 yxyx => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.yxyy swizzling.
        /// </summary>
        public bvec4 yxyy => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.yxyz swizzling.
        /// </summary>
        public bvec4 yxyz => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.yxyw swizzling.
        /// </summary>
        public bvec4 yxyw => new bvec4(y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.yxz swizzling.
        /// </summary>
        public bvec3 yxz => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec4.yxzx swizzling.
        /// </summary>
        public bvec4 yxzx => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.yxzy swizzling.
        /// </summary>
        public bvec4 yxzy => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.yxzz swizzling.
        /// </summary>
        public bvec4 yxzz => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.yxzw swizzling.
        /// </summary>
        public bvec4 yxzw => new bvec4(y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.yxw swizzling.
        /// </summary>
        public bvec3 yxw => new bvec3(y, x, w);
        
        /// <summary>
        /// Returns bvec4.yxwx swizzling.
        /// </summary>
        public bvec4 yxwx => new bvec4(y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.yxwy swizzling.
        /// </summary>
        public bvec4 yxwy => new bvec4(y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.yxwz swizzling.
        /// </summary>
        public bvec4 yxwz => new bvec4(y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.yxww swizzling.
        /// </summary>
        public bvec4 yxww => new bvec4(y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.yy swizzling.
        /// </summary>
        public bvec2 yy => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec4.yyx swizzling.
        /// </summary>
        public bvec3 yyx => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec4.yyxx swizzling.
        /// </summary>
        public bvec4 yyxx => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.yyxy swizzling.
        /// </summary>
        public bvec4 yyxy => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.yyxz swizzling.
        /// </summary>
        public bvec4 yyxz => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.yyxw swizzling.
        /// </summary>
        public bvec4 yyxw => new bvec4(y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.yyy swizzling.
        /// </summary>
        public bvec3 yyy => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec4.yyyx swizzling.
        /// </summary>
        public bvec4 yyyx => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.yyyy swizzling.
        /// </summary>
        public bvec4 yyyy => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.yyyz swizzling.
        /// </summary>
        public bvec4 yyyz => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.yyyw swizzling.
        /// </summary>
        public bvec4 yyyw => new bvec4(y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.yyz swizzling.
        /// </summary>
        public bvec3 yyz => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec4.yyzx swizzling.
        /// </summary>
        public bvec4 yyzx => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.yyzy swizzling.
        /// </summary>
        public bvec4 yyzy => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.yyzz swizzling.
        /// </summary>
        public bvec4 yyzz => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.yyzw swizzling.
        /// </summary>
        public bvec4 yyzw => new bvec4(y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.yyw swizzling.
        /// </summary>
        public bvec3 yyw => new bvec3(y, y, w);
        
        /// <summary>
        /// Returns bvec4.yywx swizzling.
        /// </summary>
        public bvec4 yywx => new bvec4(y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.yywy swizzling.
        /// </summary>
        public bvec4 yywy => new bvec4(y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.yywz swizzling.
        /// </summary>
        public bvec4 yywz => new bvec4(y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.yyww swizzling.
        /// </summary>
        public bvec4 yyww => new bvec4(y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.yz swizzling.
        /// </summary>
        public bvec2 yz => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec4.yzx swizzling.
        /// </summary>
        public bvec3 yzx => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec4.yzxx swizzling.
        /// </summary>
        public bvec4 yzxx => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.yzxy swizzling.
        /// </summary>
        public bvec4 yzxy => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.yzxz swizzling.
        /// </summary>
        public bvec4 yzxz => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.yzxw swizzling.
        /// </summary>
        public bvec4 yzxw => new bvec4(y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.yzy swizzling.
        /// </summary>
        public bvec3 yzy => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec4.yzyx swizzling.
        /// </summary>
        public bvec4 yzyx => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.yzyy swizzling.
        /// </summary>
        public bvec4 yzyy => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.yzyz swizzling.
        /// </summary>
        public bvec4 yzyz => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.yzyw swizzling.
        /// </summary>
        public bvec4 yzyw => new bvec4(y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.yzz swizzling.
        /// </summary>
        public bvec3 yzz => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec4.yzzx swizzling.
        /// </summary>
        public bvec4 yzzx => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.yzzy swizzling.
        /// </summary>
        public bvec4 yzzy => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.yzzz swizzling.
        /// </summary>
        public bvec4 yzzz => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.yzzw swizzling.
        /// </summary>
        public bvec4 yzzw => new bvec4(y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.yzw swizzling.
        /// </summary>
        public bvec3 yzw => new bvec3(y, z, w);
        
        /// <summary>
        /// Returns bvec4.yzwx swizzling.
        /// </summary>
        public bvec4 yzwx => new bvec4(y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.yzwy swizzling.
        /// </summary>
        public bvec4 yzwy => new bvec4(y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.yzwz swizzling.
        /// </summary>
        public bvec4 yzwz => new bvec4(y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.yzww swizzling.
        /// </summary>
        public bvec4 yzww => new bvec4(y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.yw swizzling.
        /// </summary>
        public bvec2 yw => new bvec2(y, w);
        
        /// <summary>
        /// Returns bvec4.ywx swizzling.
        /// </summary>
        public bvec3 ywx => new bvec3(y, w, x);
        
        /// <summary>
        /// Returns bvec4.ywxx swizzling.
        /// </summary>
        public bvec4 ywxx => new bvec4(y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.ywxy swizzling.
        /// </summary>
        public bvec4 ywxy => new bvec4(y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.ywxz swizzling.
        /// </summary>
        public bvec4 ywxz => new bvec4(y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.ywxw swizzling.
        /// </summary>
        public bvec4 ywxw => new bvec4(y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.ywy swizzling.
        /// </summary>
        public bvec3 ywy => new bvec3(y, w, y);
        
        /// <summary>
        /// Returns bvec4.ywyx swizzling.
        /// </summary>
        public bvec4 ywyx => new bvec4(y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.ywyy swizzling.
        /// </summary>
        public bvec4 ywyy => new bvec4(y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.ywyz swizzling.
        /// </summary>
        public bvec4 ywyz => new bvec4(y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.ywyw swizzling.
        /// </summary>
        public bvec4 ywyw => new bvec4(y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.ywz swizzling.
        /// </summary>
        public bvec3 ywz => new bvec3(y, w, z);
        
        /// <summary>
        /// Returns bvec4.ywzx swizzling.
        /// </summary>
        public bvec4 ywzx => new bvec4(y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.ywzy swizzling.
        /// </summary>
        public bvec4 ywzy => new bvec4(y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.ywzz swizzling.
        /// </summary>
        public bvec4 ywzz => new bvec4(y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.ywzw swizzling.
        /// </summary>
        public bvec4 ywzw => new bvec4(y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.yww swizzling.
        /// </summary>
        public bvec3 yww => new bvec3(y, w, w);
        
        /// <summary>
        /// Returns bvec4.ywwx swizzling.
        /// </summary>
        public bvec4 ywwx => new bvec4(y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.ywwy swizzling.
        /// </summary>
        public bvec4 ywwy => new bvec4(y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.ywwz swizzling.
        /// </summary>
        public bvec4 ywwz => new bvec4(y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.ywww swizzling.
        /// </summary>
        public bvec4 ywww => new bvec4(y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.zx swizzling.
        /// </summary>
        public bvec2 zx => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec4.zxx swizzling.
        /// </summary>
        public bvec3 zxx => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec4.zxxx swizzling.
        /// </summary>
        public bvec4 zxxx => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.zxxy swizzling.
        /// </summary>
        public bvec4 zxxy => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.zxxz swizzling.
        /// </summary>
        public bvec4 zxxz => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.zxxw swizzling.
        /// </summary>
        public bvec4 zxxw => new bvec4(z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.zxy swizzling.
        /// </summary>
        public bvec3 zxy => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec4.zxyx swizzling.
        /// </summary>
        public bvec4 zxyx => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.zxyy swizzling.
        /// </summary>
        public bvec4 zxyy => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.zxyz swizzling.
        /// </summary>
        public bvec4 zxyz => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.zxyw swizzling.
        /// </summary>
        public bvec4 zxyw => new bvec4(z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.zxz swizzling.
        /// </summary>
        public bvec3 zxz => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec4.zxzx swizzling.
        /// </summary>
        public bvec4 zxzx => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.zxzy swizzling.
        /// </summary>
        public bvec4 zxzy => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.zxzz swizzling.
        /// </summary>
        public bvec4 zxzz => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.zxzw swizzling.
        /// </summary>
        public bvec4 zxzw => new bvec4(z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.zxw swizzling.
        /// </summary>
        public bvec3 zxw => new bvec3(z, x, w);
        
        /// <summary>
        /// Returns bvec4.zxwx swizzling.
        /// </summary>
        public bvec4 zxwx => new bvec4(z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.zxwy swizzling.
        /// </summary>
        public bvec4 zxwy => new bvec4(z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.zxwz swizzling.
        /// </summary>
        public bvec4 zxwz => new bvec4(z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.zxww swizzling.
        /// </summary>
        public bvec4 zxww => new bvec4(z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.zy swizzling.
        /// </summary>
        public bvec2 zy => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec4.zyx swizzling.
        /// </summary>
        public bvec3 zyx => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec4.zyxx swizzling.
        /// </summary>
        public bvec4 zyxx => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.zyxy swizzling.
        /// </summary>
        public bvec4 zyxy => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.zyxz swizzling.
        /// </summary>
        public bvec4 zyxz => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.zyxw swizzling.
        /// </summary>
        public bvec4 zyxw => new bvec4(z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.zyy swizzling.
        /// </summary>
        public bvec3 zyy => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec4.zyyx swizzling.
        /// </summary>
        public bvec4 zyyx => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.zyyy swizzling.
        /// </summary>
        public bvec4 zyyy => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.zyyz swizzling.
        /// </summary>
        public bvec4 zyyz => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.zyyw swizzling.
        /// </summary>
        public bvec4 zyyw => new bvec4(z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.zyz swizzling.
        /// </summary>
        public bvec3 zyz => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec4.zyzx swizzling.
        /// </summary>
        public bvec4 zyzx => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.zyzy swizzling.
        /// </summary>
        public bvec4 zyzy => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.zyzz swizzling.
        /// </summary>
        public bvec4 zyzz => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.zyzw swizzling.
        /// </summary>
        public bvec4 zyzw => new bvec4(z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.zyw swizzling.
        /// </summary>
        public bvec3 zyw => new bvec3(z, y, w);
        
        /// <summary>
        /// Returns bvec4.zywx swizzling.
        /// </summary>
        public bvec4 zywx => new bvec4(z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.zywy swizzling.
        /// </summary>
        public bvec4 zywy => new bvec4(z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.zywz swizzling.
        /// </summary>
        public bvec4 zywz => new bvec4(z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.zyww swizzling.
        /// </summary>
        public bvec4 zyww => new bvec4(z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.zz swizzling.
        /// </summary>
        public bvec2 zz => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec4.zzx swizzling.
        /// </summary>
        public bvec3 zzx => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec4.zzxx swizzling.
        /// </summary>
        public bvec4 zzxx => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.zzxy swizzling.
        /// </summary>
        public bvec4 zzxy => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.zzxz swizzling.
        /// </summary>
        public bvec4 zzxz => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.zzxw swizzling.
        /// </summary>
        public bvec4 zzxw => new bvec4(z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.zzy swizzling.
        /// </summary>
        public bvec3 zzy => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec4.zzyx swizzling.
        /// </summary>
        public bvec4 zzyx => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.zzyy swizzling.
        /// </summary>
        public bvec4 zzyy => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.zzyz swizzling.
        /// </summary>
        public bvec4 zzyz => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.zzyw swizzling.
        /// </summary>
        public bvec4 zzyw => new bvec4(z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.zzz swizzling.
        /// </summary>
        public bvec3 zzz => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec4.zzzx swizzling.
        /// </summary>
        public bvec4 zzzx => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.zzzy swizzling.
        /// </summary>
        public bvec4 zzzy => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.zzzz swizzling.
        /// </summary>
        public bvec4 zzzz => new bvec4(z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.zzzw swizzling.
        /// </summary>
        public bvec4 zzzw => new bvec4(z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.zzw swizzling.
        /// </summary>
        public bvec3 zzw => new bvec3(z, z, w);
        
        /// <summary>
        /// Returns bvec4.zzwx swizzling.
        /// </summary>
        public bvec4 zzwx => new bvec4(z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.zzwy swizzling.
        /// </summary>
        public bvec4 zzwy => new bvec4(z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.zzwz swizzling.
        /// </summary>
        public bvec4 zzwz => new bvec4(z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.zzww swizzling.
        /// </summary>
        public bvec4 zzww => new bvec4(z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.zw swizzling.
        /// </summary>
        public bvec2 zw => new bvec2(z, w);
        
        /// <summary>
        /// Returns bvec4.zwx swizzling.
        /// </summary>
        public bvec3 zwx => new bvec3(z, w, x);
        
        /// <summary>
        /// Returns bvec4.zwxx swizzling.
        /// </summary>
        public bvec4 zwxx => new bvec4(z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.zwxy swizzling.
        /// </summary>
        public bvec4 zwxy => new bvec4(z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.zwxz swizzling.
        /// </summary>
        public bvec4 zwxz => new bvec4(z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.zwxw swizzling.
        /// </summary>
        public bvec4 zwxw => new bvec4(z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.zwy swizzling.
        /// </summary>
        public bvec3 zwy => new bvec3(z, w, y);
        
        /// <summary>
        /// Returns bvec4.zwyx swizzling.
        /// </summary>
        public bvec4 zwyx => new bvec4(z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.zwyy swizzling.
        /// </summary>
        public bvec4 zwyy => new bvec4(z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.zwyz swizzling.
        /// </summary>
        public bvec4 zwyz => new bvec4(z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.zwyw swizzling.
        /// </summary>
        public bvec4 zwyw => new bvec4(z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.zwz swizzling.
        /// </summary>
        public bvec3 zwz => new bvec3(z, w, z);
        
        /// <summary>
        /// Returns bvec4.zwzx swizzling.
        /// </summary>
        public bvec4 zwzx => new bvec4(z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.zwzy swizzling.
        /// </summary>
        public bvec4 zwzy => new bvec4(z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.zwzz swizzling.
        /// </summary>
        public bvec4 zwzz => new bvec4(z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.zwzw swizzling.
        /// </summary>
        public bvec4 zwzw => new bvec4(z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.zww swizzling.
        /// </summary>
        public bvec3 zww => new bvec3(z, w, w);
        
        /// <summary>
        /// Returns bvec4.zwwx swizzling.
        /// </summary>
        public bvec4 zwwx => new bvec4(z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.zwwy swizzling.
        /// </summary>
        public bvec4 zwwy => new bvec4(z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.zwwz swizzling.
        /// </summary>
        public bvec4 zwwz => new bvec4(z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.zwww swizzling.
        /// </summary>
        public bvec4 zwww => new bvec4(z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.wx swizzling.
        /// </summary>
        public bvec2 wx => new bvec2(w, x);
        
        /// <summary>
        /// Returns bvec4.wxx swizzling.
        /// </summary>
        public bvec3 wxx => new bvec3(w, x, x);
        
        /// <summary>
        /// Returns bvec4.wxxx swizzling.
        /// </summary>
        public bvec4 wxxx => new bvec4(w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.wxxy swizzling.
        /// </summary>
        public bvec4 wxxy => new bvec4(w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.wxxz swizzling.
        /// </summary>
        public bvec4 wxxz => new bvec4(w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.wxxw swizzling.
        /// </summary>
        public bvec4 wxxw => new bvec4(w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.wxy swizzling.
        /// </summary>
        public bvec3 wxy => new bvec3(w, x, y);
        
        /// <summary>
        /// Returns bvec4.wxyx swizzling.
        /// </summary>
        public bvec4 wxyx => new bvec4(w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.wxyy swizzling.
        /// </summary>
        public bvec4 wxyy => new bvec4(w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.wxyz swizzling.
        /// </summary>
        public bvec4 wxyz => new bvec4(w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.wxyw swizzling.
        /// </summary>
        public bvec4 wxyw => new bvec4(w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.wxz swizzling.
        /// </summary>
        public bvec3 wxz => new bvec3(w, x, z);
        
        /// <summary>
        /// Returns bvec4.wxzx swizzling.
        /// </summary>
        public bvec4 wxzx => new bvec4(w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.wxzy swizzling.
        /// </summary>
        public bvec4 wxzy => new bvec4(w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.wxzz swizzling.
        /// </summary>
        public bvec4 wxzz => new bvec4(w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.wxzw swizzling.
        /// </summary>
        public bvec4 wxzw => new bvec4(w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.wxw swizzling.
        /// </summary>
        public bvec3 wxw => new bvec3(w, x, w);
        
        /// <summary>
        /// Returns bvec4.wxwx swizzling.
        /// </summary>
        public bvec4 wxwx => new bvec4(w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.wxwy swizzling.
        /// </summary>
        public bvec4 wxwy => new bvec4(w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.wxwz swizzling.
        /// </summary>
        public bvec4 wxwz => new bvec4(w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.wxww swizzling.
        /// </summary>
        public bvec4 wxww => new bvec4(w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.wy swizzling.
        /// </summary>
        public bvec2 wy => new bvec2(w, y);
        
        /// <summary>
        /// Returns bvec4.wyx swizzling.
        /// </summary>
        public bvec3 wyx => new bvec3(w, y, x);
        
        /// <summary>
        /// Returns bvec4.wyxx swizzling.
        /// </summary>
        public bvec4 wyxx => new bvec4(w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.wyxy swizzling.
        /// </summary>
        public bvec4 wyxy => new bvec4(w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.wyxz swizzling.
        /// </summary>
        public bvec4 wyxz => new bvec4(w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.wyxw swizzling.
        /// </summary>
        public bvec4 wyxw => new bvec4(w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.wyy swizzling.
        /// </summary>
        public bvec3 wyy => new bvec3(w, y, y);
        
        /// <summary>
        /// Returns bvec4.wyyx swizzling.
        /// </summary>
        public bvec4 wyyx => new bvec4(w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.wyyy swizzling.
        /// </summary>
        public bvec4 wyyy => new bvec4(w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.wyyz swizzling.
        /// </summary>
        public bvec4 wyyz => new bvec4(w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.wyyw swizzling.
        /// </summary>
        public bvec4 wyyw => new bvec4(w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.wyz swizzling.
        /// </summary>
        public bvec3 wyz => new bvec3(w, y, z);
        
        /// <summary>
        /// Returns bvec4.wyzx swizzling.
        /// </summary>
        public bvec4 wyzx => new bvec4(w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.wyzy swizzling.
        /// </summary>
        public bvec4 wyzy => new bvec4(w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.wyzz swizzling.
        /// </summary>
        public bvec4 wyzz => new bvec4(w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.wyzw swizzling.
        /// </summary>
        public bvec4 wyzw => new bvec4(w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.wyw swizzling.
        /// </summary>
        public bvec3 wyw => new bvec3(w, y, w);
        
        /// <summary>
        /// Returns bvec4.wywx swizzling.
        /// </summary>
        public bvec4 wywx => new bvec4(w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.wywy swizzling.
        /// </summary>
        public bvec4 wywy => new bvec4(w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.wywz swizzling.
        /// </summary>
        public bvec4 wywz => new bvec4(w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.wyww swizzling.
        /// </summary>
        public bvec4 wyww => new bvec4(w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.wz swizzling.
        /// </summary>
        public bvec2 wz => new bvec2(w, z);
        
        /// <summary>
        /// Returns bvec4.wzx swizzling.
        /// </summary>
        public bvec3 wzx => new bvec3(w, z, x);
        
        /// <summary>
        /// Returns bvec4.wzxx swizzling.
        /// </summary>
        public bvec4 wzxx => new bvec4(w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.wzxy swizzling.
        /// </summary>
        public bvec4 wzxy => new bvec4(w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.wzxz swizzling.
        /// </summary>
        public bvec4 wzxz => new bvec4(w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.wzxw swizzling.
        /// </summary>
        public bvec4 wzxw => new bvec4(w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.wzy swizzling.
        /// </summary>
        public bvec3 wzy => new bvec3(w, z, y);
        
        /// <summary>
        /// Returns bvec4.wzyx swizzling.
        /// </summary>
        public bvec4 wzyx => new bvec4(w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.wzyy swizzling.
        /// </summary>
        public bvec4 wzyy => new bvec4(w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.wzyz swizzling.
        /// </summary>
        public bvec4 wzyz => new bvec4(w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.wzyw swizzling.
        /// </summary>
        public bvec4 wzyw => new bvec4(w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.wzz swizzling.
        /// </summary>
        public bvec3 wzz => new bvec3(w, z, z);
        
        /// <summary>
        /// Returns bvec4.wzzx swizzling.
        /// </summary>
        public bvec4 wzzx => new bvec4(w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.wzzy swizzling.
        /// </summary>
        public bvec4 wzzy => new bvec4(w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.wzzz swizzling.
        /// </summary>
        public bvec4 wzzz => new bvec4(w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.wzzw swizzling.
        /// </summary>
        public bvec4 wzzw => new bvec4(w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.wzw swizzling.
        /// </summary>
        public bvec3 wzw => new bvec3(w, z, w);
        
        /// <summary>
        /// Returns bvec4.wzwx swizzling.
        /// </summary>
        public bvec4 wzwx => new bvec4(w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.wzwy swizzling.
        /// </summary>
        public bvec4 wzwy => new bvec4(w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.wzwz swizzling.
        /// </summary>
        public bvec4 wzwz => new bvec4(w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.wzww swizzling.
        /// </summary>
        public bvec4 wzww => new bvec4(w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.ww swizzling.
        /// </summary>
        public bvec2 ww => new bvec2(w, w);
        
        /// <summary>
        /// Returns bvec4.wwx swizzling.
        /// </summary>
        public bvec3 wwx => new bvec3(w, w, x);
        
        /// <summary>
        /// Returns bvec4.wwxx swizzling.
        /// </summary>
        public bvec4 wwxx => new bvec4(w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.wwxy swizzling.
        /// </summary>
        public bvec4 wwxy => new bvec4(w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.wwxz swizzling.
        /// </summary>
        public bvec4 wwxz => new bvec4(w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.wwxw swizzling.
        /// </summary>
        public bvec4 wwxw => new bvec4(w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.wwy swizzling.
        /// </summary>
        public bvec3 wwy => new bvec3(w, w, y);
        
        /// <summary>
        /// Returns bvec4.wwyx swizzling.
        /// </summary>
        public bvec4 wwyx => new bvec4(w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.wwyy swizzling.
        /// </summary>
        public bvec4 wwyy => new bvec4(w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.wwyz swizzling.
        /// </summary>
        public bvec4 wwyz => new bvec4(w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.wwyw swizzling.
        /// </summary>
        public bvec4 wwyw => new bvec4(w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.wwz swizzling.
        /// </summary>
        public bvec3 wwz => new bvec3(w, w, z);
        
        /// <summary>
        /// Returns bvec4.wwzx swizzling.
        /// </summary>
        public bvec4 wwzx => new bvec4(w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.wwzy swizzling.
        /// </summary>
        public bvec4 wwzy => new bvec4(w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.wwzz swizzling.
        /// </summary>
        public bvec4 wwzz => new bvec4(w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.wwzw swizzling.
        /// </summary>
        public bvec4 wwzw => new bvec4(w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.www swizzling.
        /// </summary>
        public bvec3 www => new bvec3(w, w, w);
        
        /// <summary>
        /// Returns bvec4.wwwx swizzling.
        /// </summary>
        public bvec4 wwwx => new bvec4(w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.wwwy swizzling.
        /// </summary>
        public bvec4 wwwy => new bvec4(w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.wwwz swizzling.
        /// </summary>
        public bvec4 wwwz => new bvec4(w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.wwww swizzling.
        /// </summary>
        public bvec4 wwww => new bvec4(w, w, w, w);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns bvec4.rr swizzling.
        /// </summary>
        public bvec2 rr => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec4.rrr swizzling.
        /// </summary>
        public bvec3 rrr => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec4.rrrr swizzling.
        /// </summary>
        public bvec4 rrrr => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec4.rrrg swizzling.
        /// </summary>
        public bvec4 rrrg => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec4.rrrb swizzling.
        /// </summary>
        public bvec4 rrrb => new bvec4(x, x, x, z);
        
        /// <summary>
        /// Returns bvec4.rrra swizzling.
        /// </summary>
        public bvec4 rrra => new bvec4(x, x, x, w);
        
        /// <summary>
        /// Returns bvec4.rrg swizzling.
        /// </summary>
        public bvec3 rrg => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec4.rrgr swizzling.
        /// </summary>
        public bvec4 rrgr => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec4.rrgg swizzling.
        /// </summary>
        public bvec4 rrgg => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec4.rrgb swizzling.
        /// </summary>
        public bvec4 rrgb => new bvec4(x, x, y, z);
        
        /// <summary>
        /// Returns bvec4.rrga swizzling.
        /// </summary>
        public bvec4 rrga => new bvec4(x, x, y, w);
        
        /// <summary>
        /// Returns bvec4.rrb swizzling.
        /// </summary>
        public bvec3 rrb => new bvec3(x, x, z);
        
        /// <summary>
        /// Returns bvec4.rrbr swizzling.
        /// </summary>
        public bvec4 rrbr => new bvec4(x, x, z, x);
        
        /// <summary>
        /// Returns bvec4.rrbg swizzling.
        /// </summary>
        public bvec4 rrbg => new bvec4(x, x, z, y);
        
        /// <summary>
        /// Returns bvec4.rrbb swizzling.
        /// </summary>
        public bvec4 rrbb => new bvec4(x, x, z, z);
        
        /// <summary>
        /// Returns bvec4.rrba swizzling.
        /// </summary>
        public bvec4 rrba => new bvec4(x, x, z, w);
        
        /// <summary>
        /// Returns bvec4.rra swizzling.
        /// </summary>
        public bvec3 rra => new bvec3(x, x, w);
        
        /// <summary>
        /// Returns bvec4.rrar swizzling.
        /// </summary>
        public bvec4 rrar => new bvec4(x, x, w, x);
        
        /// <summary>
        /// Returns bvec4.rrag swizzling.
        /// </summary>
        public bvec4 rrag => new bvec4(x, x, w, y);
        
        /// <summary>
        /// Returns bvec4.rrab swizzling.
        /// </summary>
        public bvec4 rrab => new bvec4(x, x, w, z);
        
        /// <summary>
        /// Returns bvec4.rraa swizzling.
        /// </summary>
        public bvec4 rraa => new bvec4(x, x, w, w);
        
        /// <summary>
        /// Returns bvec4.rg swizzling.
        /// </summary>
        public bvec2 rg => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec4.rgr swizzling.
        /// </summary>
        public bvec3 rgr => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec4.rgrr swizzling.
        /// </summary>
        public bvec4 rgrr => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec4.rgrg swizzling.
        /// </summary>
        public bvec4 rgrg => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec4.rgrb swizzling.
        /// </summary>
        public bvec4 rgrb => new bvec4(x, y, x, z);
        
        /// <summary>
        /// Returns bvec4.rgra swizzling.
        /// </summary>
        public bvec4 rgra => new bvec4(x, y, x, w);
        
        /// <summary>
        /// Returns bvec4.rgg swizzling.
        /// </summary>
        public bvec3 rgg => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec4.rggr swizzling.
        /// </summary>
        public bvec4 rggr => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec4.rggg swizzling.
        /// </summary>
        public bvec4 rggg => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec4.rggb swizzling.
        /// </summary>
        public bvec4 rggb => new bvec4(x, y, y, z);
        
        /// <summary>
        /// Returns bvec4.rgga swizzling.
        /// </summary>
        public bvec4 rgga => new bvec4(x, y, y, w);
        
        /// <summary>
        /// Returns bvec4.rgb swizzling.
        /// </summary>
        public bvec3 rgb => new bvec3(x, y, z);
        
        /// <summary>
        /// Returns bvec4.rgbr swizzling.
        /// </summary>
        public bvec4 rgbr => new bvec4(x, y, z, x);
        
        /// <summary>
        /// Returns bvec4.rgbg swizzling.
        /// </summary>
        public bvec4 rgbg => new bvec4(x, y, z, y);
        
        /// <summary>
        /// Returns bvec4.rgbb swizzling.
        /// </summary>
        public bvec4 rgbb => new bvec4(x, y, z, z);
        
        /// <summary>
        /// Returns bvec4.rgba swizzling.
        /// </summary>
        public bvec4 rgba => new bvec4(x, y, z, w);
        
        /// <summary>
        /// Returns bvec4.rga swizzling.
        /// </summary>
        public bvec3 rga => new bvec3(x, y, w);
        
        /// <summary>
        /// Returns bvec4.rgar swizzling.
        /// </summary>
        public bvec4 rgar => new bvec4(x, y, w, x);
        
        /// <summary>
        /// Returns bvec4.rgag swizzling.
        /// </summary>
        public bvec4 rgag => new bvec4(x, y, w, y);
        
        /// <summary>
        /// Returns bvec4.rgab swizzling.
        /// </summary>
        public bvec4 rgab => new bvec4(x, y, w, z);
        
        /// <summary>
        /// Returns bvec4.rgaa swizzling.
        /// </summary>
        public bvec4 rgaa => new bvec4(x, y, w, w);
        
        /// <summary>
        /// Returns bvec4.rb swizzling.
        /// </summary>
        public bvec2 rb => new bvec2(x, z);
        
        /// <summary>
        /// Returns bvec4.rbr swizzling.
        /// </summary>
        public bvec3 rbr => new bvec3(x, z, x);
        
        /// <summary>
        /// Returns bvec4.rbrr swizzling.
        /// </summary>
        public bvec4 rbrr => new bvec4(x, z, x, x);
        
        /// <summary>
        /// Returns bvec4.rbrg swizzling.
        /// </summary>
        public bvec4 rbrg => new bvec4(x, z, x, y);
        
        /// <summary>
        /// Returns bvec4.rbrb swizzling.
        /// </summary>
        public bvec4 rbrb => new bvec4(x, z, x, z);
        
        /// <summary>
        /// Returns bvec4.rbra swizzling.
        /// </summary>
        public bvec4 rbra => new bvec4(x, z, x, w);
        
        /// <summary>
        /// Returns bvec4.rbg swizzling.
        /// </summary>
        public bvec3 rbg => new bvec3(x, z, y);
        
        /// <summary>
        /// Returns bvec4.rbgr swizzling.
        /// </summary>
        public bvec4 rbgr => new bvec4(x, z, y, x);
        
        /// <summary>
        /// Returns bvec4.rbgg swizzling.
        /// </summary>
        public bvec4 rbgg => new bvec4(x, z, y, y);
        
        /// <summary>
        /// Returns bvec4.rbgb swizzling.
        /// </summary>
        public bvec4 rbgb => new bvec4(x, z, y, z);
        
        /// <summary>
        /// Returns bvec4.rbga swizzling.
        /// </summary>
        public bvec4 rbga => new bvec4(x, z, y, w);
        
        /// <summary>
        /// Returns bvec4.rbb swizzling.
        /// </summary>
        public bvec3 rbb => new bvec3(x, z, z);
        
        /// <summary>
        /// Returns bvec4.rbbr swizzling.
        /// </summary>
        public bvec4 rbbr => new bvec4(x, z, z, x);
        
        /// <summary>
        /// Returns bvec4.rbbg swizzling.
        /// </summary>
        public bvec4 rbbg => new bvec4(x, z, z, y);
        
        /// <summary>
        /// Returns bvec4.rbbb swizzling.
        /// </summary>
        public bvec4 rbbb => new bvec4(x, z, z, z);
        
        /// <summary>
        /// Returns bvec4.rbba swizzling.
        /// </summary>
        public bvec4 rbba => new bvec4(x, z, z, w);
        
        /// <summary>
        /// Returns bvec4.rba swizzling.
        /// </summary>
        public bvec3 rba => new bvec3(x, z, w);
        
        /// <summary>
        /// Returns bvec4.rbar swizzling.
        /// </summary>
        public bvec4 rbar => new bvec4(x, z, w, x);
        
        /// <summary>
        /// Returns bvec4.rbag swizzling.
        /// </summary>
        public bvec4 rbag => new bvec4(x, z, w, y);
        
        /// <summary>
        /// Returns bvec4.rbab swizzling.
        /// </summary>
        public bvec4 rbab => new bvec4(x, z, w, z);
        
        /// <summary>
        /// Returns bvec4.rbaa swizzling.
        /// </summary>
        public bvec4 rbaa => new bvec4(x, z, w, w);
        
        /// <summary>
        /// Returns bvec4.ra swizzling.
        /// </summary>
        public bvec2 ra => new bvec2(x, w);
        
        /// <summary>
        /// Returns bvec4.rar swizzling.
        /// </summary>
        public bvec3 rar => new bvec3(x, w, x);
        
        /// <summary>
        /// Returns bvec4.rarr swizzling.
        /// </summary>
        public bvec4 rarr => new bvec4(x, w, x, x);
        
        /// <summary>
        /// Returns bvec4.rarg swizzling.
        /// </summary>
        public bvec4 rarg => new bvec4(x, w, x, y);
        
        /// <summary>
        /// Returns bvec4.rarb swizzling.
        /// </summary>
        public bvec4 rarb => new bvec4(x, w, x, z);
        
        /// <summary>
        /// Returns bvec4.rara swizzling.
        /// </summary>
        public bvec4 rara => new bvec4(x, w, x, w);
        
        /// <summary>
        /// Returns bvec4.rag swizzling.
        /// </summary>
        public bvec3 rag => new bvec3(x, w, y);
        
        /// <summary>
        /// Returns bvec4.ragr swizzling.
        /// </summary>
        public bvec4 ragr => new bvec4(x, w, y, x);
        
        /// <summary>
        /// Returns bvec4.ragg swizzling.
        /// </summary>
        public bvec4 ragg => new bvec4(x, w, y, y);
        
        /// <summary>
        /// Returns bvec4.ragb swizzling.
        /// </summary>
        public bvec4 ragb => new bvec4(x, w, y, z);
        
        /// <summary>
        /// Returns bvec4.raga swizzling.
        /// </summary>
        public bvec4 raga => new bvec4(x, w, y, w);
        
        /// <summary>
        /// Returns bvec4.rab swizzling.
        /// </summary>
        public bvec3 rab => new bvec3(x, w, z);
        
        /// <summary>
        /// Returns bvec4.rabr swizzling.
        /// </summary>
        public bvec4 rabr => new bvec4(x, w, z, x);
        
        /// <summary>
        /// Returns bvec4.rabg swizzling.
        /// </summary>
        public bvec4 rabg => new bvec4(x, w, z, y);
        
        /// <summary>
        /// Returns bvec4.rabb swizzling.
        /// </summary>
        public bvec4 rabb => new bvec4(x, w, z, z);
        
        /// <summary>
        /// Returns bvec4.raba swizzling.
        /// </summary>
        public bvec4 raba => new bvec4(x, w, z, w);
        
        /// <summary>
        /// Returns bvec4.raa swizzling.
        /// </summary>
        public bvec3 raa => new bvec3(x, w, w);
        
        /// <summary>
        /// Returns bvec4.raar swizzling.
        /// </summary>
        public bvec4 raar => new bvec4(x, w, w, x);
        
        /// <summary>
        /// Returns bvec4.raag swizzling.
        /// </summary>
        public bvec4 raag => new bvec4(x, w, w, y);
        
        /// <summary>
        /// Returns bvec4.raab swizzling.
        /// </summary>
        public bvec4 raab => new bvec4(x, w, w, z);
        
        /// <summary>
        /// Returns bvec4.raaa swizzling.
        /// </summary>
        public bvec4 raaa => new bvec4(x, w, w, w);
        
        /// <summary>
        /// Returns bvec4.gr swizzling.
        /// </summary>
        public bvec2 gr => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec4.grr swizzling.
        /// </summary>
        public bvec3 grr => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec4.grrr swizzling.
        /// </summary>
        public bvec4 grrr => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec4.grrg swizzling.
        /// </summary>
        public bvec4 grrg => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec4.grrb swizzling.
        /// </summary>
        public bvec4 grrb => new bvec4(y, x, x, z);
        
        /// <summary>
        /// Returns bvec4.grra swizzling.
        /// </summary>
        public bvec4 grra => new bvec4(y, x, x, w);
        
        /// <summary>
        /// Returns bvec4.grg swizzling.
        /// </summary>
        public bvec3 grg => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec4.grgr swizzling.
        /// </summary>
        public bvec4 grgr => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec4.grgg swizzling.
        /// </summary>
        public bvec4 grgg => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec4.grgb swizzling.
        /// </summary>
        public bvec4 grgb => new bvec4(y, x, y, z);
        
        /// <summary>
        /// Returns bvec4.grga swizzling.
        /// </summary>
        public bvec4 grga => new bvec4(y, x, y, w);
        
        /// <summary>
        /// Returns bvec4.grb swizzling.
        /// </summary>
        public bvec3 grb => new bvec3(y, x, z);
        
        /// <summary>
        /// Returns bvec4.grbr swizzling.
        /// </summary>
        public bvec4 grbr => new bvec4(y, x, z, x);
        
        /// <summary>
        /// Returns bvec4.grbg swizzling.
        /// </summary>
        public bvec4 grbg => new bvec4(y, x, z, y);
        
        /// <summary>
        /// Returns bvec4.grbb swizzling.
        /// </summary>
        public bvec4 grbb => new bvec4(y, x, z, z);
        
        /// <summary>
        /// Returns bvec4.grba swizzling.
        /// </summary>
        public bvec4 grba => new bvec4(y, x, z, w);
        
        /// <summary>
        /// Returns bvec4.gra swizzling.
        /// </summary>
        public bvec3 gra => new bvec3(y, x, w);
        
        /// <summary>
        /// Returns bvec4.grar swizzling.
        /// </summary>
        public bvec4 grar => new bvec4(y, x, w, x);
        
        /// <summary>
        /// Returns bvec4.grag swizzling.
        /// </summary>
        public bvec4 grag => new bvec4(y, x, w, y);
        
        /// <summary>
        /// Returns bvec4.grab swizzling.
        /// </summary>
        public bvec4 grab => new bvec4(y, x, w, z);
        
        /// <summary>
        /// Returns bvec4.graa swizzling.
        /// </summary>
        public bvec4 graa => new bvec4(y, x, w, w);
        
        /// <summary>
        /// Returns bvec4.gg swizzling.
        /// </summary>
        public bvec2 gg => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec4.ggr swizzling.
        /// </summary>
        public bvec3 ggr => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec4.ggrr swizzling.
        /// </summary>
        public bvec4 ggrr => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec4.ggrg swizzling.
        /// </summary>
        public bvec4 ggrg => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec4.ggrb swizzling.
        /// </summary>
        public bvec4 ggrb => new bvec4(y, y, x, z);
        
        /// <summary>
        /// Returns bvec4.ggra swizzling.
        /// </summary>
        public bvec4 ggra => new bvec4(y, y, x, w);
        
        /// <summary>
        /// Returns bvec4.ggg swizzling.
        /// </summary>
        public bvec3 ggg => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec4.gggr swizzling.
        /// </summary>
        public bvec4 gggr => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec4.gggg swizzling.
        /// </summary>
        public bvec4 gggg => new bvec4(y, y, y, y);
        
        /// <summary>
        /// Returns bvec4.gggb swizzling.
        /// </summary>
        public bvec4 gggb => new bvec4(y, y, y, z);
        
        /// <summary>
        /// Returns bvec4.ggga swizzling.
        /// </summary>
        public bvec4 ggga => new bvec4(y, y, y, w);
        
        /// <summary>
        /// Returns bvec4.ggb swizzling.
        /// </summary>
        public bvec3 ggb => new bvec3(y, y, z);
        
        /// <summary>
        /// Returns bvec4.ggbr swizzling.
        /// </summary>
        public bvec4 ggbr => new bvec4(y, y, z, x);
        
        /// <summary>
        /// Returns bvec4.ggbg swizzling.
        /// </summary>
        public bvec4 ggbg => new bvec4(y, y, z, y);
        
        /// <summary>
        /// Returns bvec4.ggbb swizzling.
        /// </summary>
        public bvec4 ggbb => new bvec4(y, y, z, z);
        
        /// <summary>
        /// Returns bvec4.ggba swizzling.
        /// </summary>
        public bvec4 ggba => new bvec4(y, y, z, w);
        
        /// <summary>
        /// Returns bvec4.gga swizzling.
        /// </summary>
        public bvec3 gga => new bvec3(y, y, w);
        
        /// <summary>
        /// Returns bvec4.ggar swizzling.
        /// </summary>
        public bvec4 ggar => new bvec4(y, y, w, x);
        
        /// <summary>
        /// Returns bvec4.ggag swizzling.
        /// </summary>
        public bvec4 ggag => new bvec4(y, y, w, y);
        
        /// <summary>
        /// Returns bvec4.ggab swizzling.
        /// </summary>
        public bvec4 ggab => new bvec4(y, y, w, z);
        
        /// <summary>
        /// Returns bvec4.ggaa swizzling.
        /// </summary>
        public bvec4 ggaa => new bvec4(y, y, w, w);
        
        /// <summary>
        /// Returns bvec4.gb swizzling.
        /// </summary>
        public bvec2 gb => new bvec2(y, z);
        
        /// <summary>
        /// Returns bvec4.gbr swizzling.
        /// </summary>
        public bvec3 gbr => new bvec3(y, z, x);
        
        /// <summary>
        /// Returns bvec4.gbrr swizzling.
        /// </summary>
        public bvec4 gbrr => new bvec4(y, z, x, x);
        
        /// <summary>
        /// Returns bvec4.gbrg swizzling.
        /// </summary>
        public bvec4 gbrg => new bvec4(y, z, x, y);
        
        /// <summary>
        /// Returns bvec4.gbrb swizzling.
        /// </summary>
        public bvec4 gbrb => new bvec4(y, z, x, z);
        
        /// <summary>
        /// Returns bvec4.gbra swizzling.
        /// </summary>
        public bvec4 gbra => new bvec4(y, z, x, w);
        
        /// <summary>
        /// Returns bvec4.gbg swizzling.
        /// </summary>
        public bvec3 gbg => new bvec3(y, z, y);
        
        /// <summary>
        /// Returns bvec4.gbgr swizzling.
        /// </summary>
        public bvec4 gbgr => new bvec4(y, z, y, x);
        
        /// <summary>
        /// Returns bvec4.gbgg swizzling.
        /// </summary>
        public bvec4 gbgg => new bvec4(y, z, y, y);
        
        /// <summary>
        /// Returns bvec4.gbgb swizzling.
        /// </summary>
        public bvec4 gbgb => new bvec4(y, z, y, z);
        
        /// <summary>
        /// Returns bvec4.gbga swizzling.
        /// </summary>
        public bvec4 gbga => new bvec4(y, z, y, w);
        
        /// <summary>
        /// Returns bvec4.gbb swizzling.
        /// </summary>
        public bvec3 gbb => new bvec3(y, z, z);
        
        /// <summary>
        /// Returns bvec4.gbbr swizzling.
        /// </summary>
        public bvec4 gbbr => new bvec4(y, z, z, x);
        
        /// <summary>
        /// Returns bvec4.gbbg swizzling.
        /// </summary>
        public bvec4 gbbg => new bvec4(y, z, z, y);
        
        /// <summary>
        /// Returns bvec4.gbbb swizzling.
        /// </summary>
        public bvec4 gbbb => new bvec4(y, z, z, z);
        
        /// <summary>
        /// Returns bvec4.gbba swizzling.
        /// </summary>
        public bvec4 gbba => new bvec4(y, z, z, w);
        
        /// <summary>
        /// Returns bvec4.gba swizzling.
        /// </summary>
        public bvec3 gba => new bvec3(y, z, w);
        
        /// <summary>
        /// Returns bvec4.gbar swizzling.
        /// </summary>
        public bvec4 gbar => new bvec4(y, z, w, x);
        
        /// <summary>
        /// Returns bvec4.gbag swizzling.
        /// </summary>
        public bvec4 gbag => new bvec4(y, z, w, y);
        
        /// <summary>
        /// Returns bvec4.gbab swizzling.
        /// </summary>
        public bvec4 gbab => new bvec4(y, z, w, z);
        
        /// <summary>
        /// Returns bvec4.gbaa swizzling.
        /// </summary>
        public bvec4 gbaa => new bvec4(y, z, w, w);
        
        /// <summary>
        /// Returns bvec4.ga swizzling.
        /// </summary>
        public bvec2 ga => new bvec2(y, w);
        
        /// <summary>
        /// Returns bvec4.gar swizzling.
        /// </summary>
        public bvec3 gar => new bvec3(y, w, x);
        
        /// <summary>
        /// Returns bvec4.garr swizzling.
        /// </summary>
        public bvec4 garr => new bvec4(y, w, x, x);
        
        /// <summary>
        /// Returns bvec4.garg swizzling.
        /// </summary>
        public bvec4 garg => new bvec4(y, w, x, y);
        
        /// <summary>
        /// Returns bvec4.garb swizzling.
        /// </summary>
        public bvec4 garb => new bvec4(y, w, x, z);
        
        /// <summary>
        /// Returns bvec4.gara swizzling.
        /// </summary>
        public bvec4 gara => new bvec4(y, w, x, w);
        
        /// <summary>
        /// Returns bvec4.gag swizzling.
        /// </summary>
        public bvec3 gag => new bvec3(y, w, y);
        
        /// <summary>
        /// Returns bvec4.gagr swizzling.
        /// </summary>
        public bvec4 gagr => new bvec4(y, w, y, x);
        
        /// <summary>
        /// Returns bvec4.gagg swizzling.
        /// </summary>
        public bvec4 gagg => new bvec4(y, w, y, y);
        
        /// <summary>
        /// Returns bvec4.gagb swizzling.
        /// </summary>
        public bvec4 gagb => new bvec4(y, w, y, z);
        
        /// <summary>
        /// Returns bvec4.gaga swizzling.
        /// </summary>
        public bvec4 gaga => new bvec4(y, w, y, w);
        
        /// <summary>
        /// Returns bvec4.gab swizzling.
        /// </summary>
        public bvec3 gab => new bvec3(y, w, z);
        
        /// <summary>
        /// Returns bvec4.gabr swizzling.
        /// </summary>
        public bvec4 gabr => new bvec4(y, w, z, x);
        
        /// <summary>
        /// Returns bvec4.gabg swizzling.
        /// </summary>
        public bvec4 gabg => new bvec4(y, w, z, y);
        
        /// <summary>
        /// Returns bvec4.gabb swizzling.
        /// </summary>
        public bvec4 gabb => new bvec4(y, w, z, z);
        
        /// <summary>
        /// Returns bvec4.gaba swizzling.
        /// </summary>
        public bvec4 gaba => new bvec4(y, w, z, w);
        
        /// <summary>
        /// Returns bvec4.gaa swizzling.
        /// </summary>
        public bvec3 gaa => new bvec3(y, w, w);
        
        /// <summary>
        /// Returns bvec4.gaar swizzling.
        /// </summary>
        public bvec4 gaar => new bvec4(y, w, w, x);
        
        /// <summary>
        /// Returns bvec4.gaag swizzling.
        /// </summary>
        public bvec4 gaag => new bvec4(y, w, w, y);
        
        /// <summary>
        /// Returns bvec4.gaab swizzling.
        /// </summary>
        public bvec4 gaab => new bvec4(y, w, w, z);
        
        /// <summary>
        /// Returns bvec4.gaaa swizzling.
        /// </summary>
        public bvec4 gaaa => new bvec4(y, w, w, w);
        
        /// <summary>
        /// Returns bvec4.br swizzling.
        /// </summary>
        public bvec2 br => new bvec2(z, x);
        
        /// <summary>
        /// Returns bvec4.brr swizzling.
        /// </summary>
        public bvec3 brr => new bvec3(z, x, x);
        
        /// <summary>
        /// Returns bvec4.brrr swizzling.
        /// </summary>
        public bvec4 brrr => new bvec4(z, x, x, x);
        
        /// <summary>
        /// Returns bvec4.brrg swizzling.
        /// </summary>
        public bvec4 brrg => new bvec4(z, x, x, y);
        
        /// <summary>
        /// Returns bvec4.brrb swizzling.
        /// </summary>
        public bvec4 brrb => new bvec4(z, x, x, z);
        
        /// <summary>
        /// Returns bvec4.brra swizzling.
        /// </summary>
        public bvec4 brra => new bvec4(z, x, x, w);
        
        /// <summary>
        /// Returns bvec4.brg swizzling.
        /// </summary>
        public bvec3 brg => new bvec3(z, x, y);
        
        /// <summary>
        /// Returns bvec4.brgr swizzling.
        /// </summary>
        public bvec4 brgr => new bvec4(z, x, y, x);
        
        /// <summary>
        /// Returns bvec4.brgg swizzling.
        /// </summary>
        public bvec4 brgg => new bvec4(z, x, y, y);
        
        /// <summary>
        /// Returns bvec4.brgb swizzling.
        /// </summary>
        public bvec4 brgb => new bvec4(z, x, y, z);
        
        /// <summary>
        /// Returns bvec4.brga swizzling.
        /// </summary>
        public bvec4 brga => new bvec4(z, x, y, w);
        
        /// <summary>
        /// Returns bvec4.brb swizzling.
        /// </summary>
        public bvec3 brb => new bvec3(z, x, z);
        
        /// <summary>
        /// Returns bvec4.brbr swizzling.
        /// </summary>
        public bvec4 brbr => new bvec4(z, x, z, x);
        
        /// <summary>
        /// Returns bvec4.brbg swizzling.
        /// </summary>
        public bvec4 brbg => new bvec4(z, x, z, y);
        
        /// <summary>
        /// Returns bvec4.brbb swizzling.
        /// </summary>
        public bvec4 brbb => new bvec4(z, x, z, z);
        
        /// <summary>
        /// Returns bvec4.brba swizzling.
        /// </summary>
        public bvec4 brba => new bvec4(z, x, z, w);
        
        /// <summary>
        /// Returns bvec4.bra swizzling.
        /// </summary>
        public bvec3 bra => new bvec3(z, x, w);
        
        /// <summary>
        /// Returns bvec4.brar swizzling.
        /// </summary>
        public bvec4 brar => new bvec4(z, x, w, x);
        
        /// <summary>
        /// Returns bvec4.brag swizzling.
        /// </summary>
        public bvec4 brag => new bvec4(z, x, w, y);
        
        /// <summary>
        /// Returns bvec4.brab swizzling.
        /// </summary>
        public bvec4 brab => new bvec4(z, x, w, z);
        
        /// <summary>
        /// Returns bvec4.braa swizzling.
        /// </summary>
        public bvec4 braa => new bvec4(z, x, w, w);
        
        /// <summary>
        /// Returns bvec4.bg swizzling.
        /// </summary>
        public bvec2 bg => new bvec2(z, y);
        
        /// <summary>
        /// Returns bvec4.bgr swizzling.
        /// </summary>
        public bvec3 bgr => new bvec3(z, y, x);
        
        /// <summary>
        /// Returns bvec4.bgrr swizzling.
        /// </summary>
        public bvec4 bgrr => new bvec4(z, y, x, x);
        
        /// <summary>
        /// Returns bvec4.bgrg swizzling.
        /// </summary>
        public bvec4 bgrg => new bvec4(z, y, x, y);
        
        /// <summary>
        /// Returns bvec4.bgrb swizzling.
        /// </summary>
        public bvec4 bgrb => new bvec4(z, y, x, z);
        
        /// <summary>
        /// Returns bvec4.bgra swizzling.
        /// </summary>
        public bvec4 bgra => new bvec4(z, y, x, w);
        
        /// <summary>
        /// Returns bvec4.bgg swizzling.
        /// </summary>
        public bvec3 bgg => new bvec3(z, y, y);
        
        /// <summary>
        /// Returns bvec4.bggr swizzling.
        /// </summary>
        public bvec4 bggr => new bvec4(z, y, y, x);
        
        /// <summary>
        /// Returns bvec4.bggg swizzling.
        /// </summary>
        public bvec4 bggg => new bvec4(z, y, y, y);
        
        /// <summary>
        /// Returns bvec4.bggb swizzling.
        /// </summary>
        public bvec4 bggb => new bvec4(z, y, y, z);
        
        /// <summary>
        /// Returns bvec4.bgga swizzling.
        /// </summary>
        public bvec4 bgga => new bvec4(z, y, y, w);
        
        /// <summary>
        /// Returns bvec4.bgb swizzling.
        /// </summary>
        public bvec3 bgb => new bvec3(z, y, z);
        
        /// <summary>
        /// Returns bvec4.bgbr swizzling.
        /// </summary>
        public bvec4 bgbr => new bvec4(z, y, z, x);
        
        /// <summary>
        /// Returns bvec4.bgbg swizzling.
        /// </summary>
        public bvec4 bgbg => new bvec4(z, y, z, y);
        
        /// <summary>
        /// Returns bvec4.bgbb swizzling.
        /// </summary>
        public bvec4 bgbb => new bvec4(z, y, z, z);
        
        /// <summary>
        /// Returns bvec4.bgba swizzling.
        /// </summary>
        public bvec4 bgba => new bvec4(z, y, z, w);
        
        /// <summary>
        /// Returns bvec4.bga swizzling.
        /// </summary>
        public bvec3 bga => new bvec3(z, y, w);
        
        /// <summary>
        /// Returns bvec4.bgar swizzling.
        /// </summary>
        public bvec4 bgar => new bvec4(z, y, w, x);
        
        /// <summary>
        /// Returns bvec4.bgag swizzling.
        /// </summary>
        public bvec4 bgag => new bvec4(z, y, w, y);
        
        /// <summary>
        /// Returns bvec4.bgab swizzling.
        /// </summary>
        public bvec4 bgab => new bvec4(z, y, w, z);
        
        /// <summary>
        /// Returns bvec4.bgaa swizzling.
        /// </summary>
        public bvec4 bgaa => new bvec4(z, y, w, w);
        
        /// <summary>
        /// Returns bvec4.bb swizzling.
        /// </summary>
        public bvec2 bb => new bvec2(z, z);
        
        /// <summary>
        /// Returns bvec4.bbr swizzling.
        /// </summary>
        public bvec3 bbr => new bvec3(z, z, x);
        
        /// <summary>
        /// Returns bvec4.bbrr swizzling.
        /// </summary>
        public bvec4 bbrr => new bvec4(z, z, x, x);
        
        /// <summary>
        /// Returns bvec4.bbrg swizzling.
        /// </summary>
        public bvec4 bbrg => new bvec4(z, z, x, y);
        
        /// <summary>
        /// Returns bvec4.bbrb swizzling.
        /// </summary>
        public bvec4 bbrb => new bvec4(z, z, x, z);
        
        /// <summary>
        /// Returns bvec4.bbra swizzling.
        /// </summary>
        public bvec4 bbra => new bvec4(z, z, x, w);
        
        /// <summary>
        /// Returns bvec4.bbg swizzling.
        /// </summary>
        public bvec3 bbg => new bvec3(z, z, y);
        
        /// <summary>
        /// Returns bvec4.bbgr swizzling.
        /// </summary>
        public bvec4 bbgr => new bvec4(z, z, y, x);
        
        /// <summary>
        /// Returns bvec4.bbgg swizzling.
        /// </summary>
        public bvec4 bbgg => new bvec4(z, z, y, y);
        
        /// <summary>
        /// Returns bvec4.bbgb swizzling.
        /// </summary>
        public bvec4 bbgb => new bvec4(z, z, y, z);
        
        /// <summary>
        /// Returns bvec4.bbga swizzling.
        /// </summary>
        public bvec4 bbga => new bvec4(z, z, y, w);
        
        /// <summary>
        /// Returns bvec4.bbb swizzling.
        /// </summary>
        public bvec3 bbb => new bvec3(z, z, z);
        
        /// <summary>
        /// Returns bvec4.bbbr swizzling.
        /// </summary>
        public bvec4 bbbr => new bvec4(z, z, z, x);
        
        /// <summary>
        /// Returns bvec4.bbbg swizzling.
        /// </summary>
        public bvec4 bbbg => new bvec4(z, z, z, y);
        
        /// <summary>
        /// Returns bvec4.bbbb swizzling.
        /// </summary>
        public bvec4 bbbb => new bvec4(z, z, z, z);
        
        /// <summary>
        /// Returns bvec4.bbba swizzling.
        /// </summary>
        public bvec4 bbba => new bvec4(z, z, z, w);
        
        /// <summary>
        /// Returns bvec4.bba swizzling.
        /// </summary>
        public bvec3 bba => new bvec3(z, z, w);
        
        /// <summary>
        /// Returns bvec4.bbar swizzling.
        /// </summary>
        public bvec4 bbar => new bvec4(z, z, w, x);
        
        /// <summary>
        /// Returns bvec4.bbag swizzling.
        /// </summary>
        public bvec4 bbag => new bvec4(z, z, w, y);
        
        /// <summary>
        /// Returns bvec4.bbab swizzling.
        /// </summary>
        public bvec4 bbab => new bvec4(z, z, w, z);
        
        /// <summary>
        /// Returns bvec4.bbaa swizzling.
        /// </summary>
        public bvec4 bbaa => new bvec4(z, z, w, w);
        
        /// <summary>
        /// Returns bvec4.ba swizzling.
        /// </summary>
        public bvec2 ba => new bvec2(z, w);
        
        /// <summary>
        /// Returns bvec4.bar swizzling.
        /// </summary>
        public bvec3 bar => new bvec3(z, w, x);
        
        /// <summary>
        /// Returns bvec4.barr swizzling.
        /// </summary>
        public bvec4 barr => new bvec4(z, w, x, x);
        
        /// <summary>
        /// Returns bvec4.barg swizzling.
        /// </summary>
        public bvec4 barg => new bvec4(z, w, x, y);
        
        /// <summary>
        /// Returns bvec4.barb swizzling.
        /// </summary>
        public bvec4 barb => new bvec4(z, w, x, z);
        
        /// <summary>
        /// Returns bvec4.bara swizzling.
        /// </summary>
        public bvec4 bara => new bvec4(z, w, x, w);
        
        /// <summary>
        /// Returns bvec4.bag swizzling.
        /// </summary>
        public bvec3 bag => new bvec3(z, w, y);
        
        /// <summary>
        /// Returns bvec4.bagr swizzling.
        /// </summary>
        public bvec4 bagr => new bvec4(z, w, y, x);
        
        /// <summary>
        /// Returns bvec4.bagg swizzling.
        /// </summary>
        public bvec4 bagg => new bvec4(z, w, y, y);
        
        /// <summary>
        /// Returns bvec4.bagb swizzling.
        /// </summary>
        public bvec4 bagb => new bvec4(z, w, y, z);
        
        /// <summary>
        /// Returns bvec4.baga swizzling.
        /// </summary>
        public bvec4 baga => new bvec4(z, w, y, w);
        
        /// <summary>
        /// Returns bvec4.bab swizzling.
        /// </summary>
        public bvec3 bab => new bvec3(z, w, z);
        
        /// <summary>
        /// Returns bvec4.babr swizzling.
        /// </summary>
        public bvec4 babr => new bvec4(z, w, z, x);
        
        /// <summary>
        /// Returns bvec4.babg swizzling.
        /// </summary>
        public bvec4 babg => new bvec4(z, w, z, y);
        
        /// <summary>
        /// Returns bvec4.babb swizzling.
        /// </summary>
        public bvec4 babb => new bvec4(z, w, z, z);
        
        /// <summary>
        /// Returns bvec4.baba swizzling.
        /// </summary>
        public bvec4 baba => new bvec4(z, w, z, w);
        
        /// <summary>
        /// Returns bvec4.baa swizzling.
        /// </summary>
        public bvec3 baa => new bvec3(z, w, w);
        
        /// <summary>
        /// Returns bvec4.baar swizzling.
        /// </summary>
        public bvec4 baar => new bvec4(z, w, w, x);
        
        /// <summary>
        /// Returns bvec4.baag swizzling.
        /// </summary>
        public bvec4 baag => new bvec4(z, w, w, y);
        
        /// <summary>
        /// Returns bvec4.baab swizzling.
        /// </summary>
        public bvec4 baab => new bvec4(z, w, w, z);
        
        /// <summary>
        /// Returns bvec4.baaa swizzling.
        /// </summary>
        public bvec4 baaa => new bvec4(z, w, w, w);
        
        /// <summary>
        /// Returns bvec4.ar swizzling.
        /// </summary>
        public bvec2 ar => new bvec2(w, x);
        
        /// <summary>
        /// Returns bvec4.arr swizzling.
        /// </summary>
        public bvec3 arr => new bvec3(w, x, x);
        
        /// <summary>
        /// Returns bvec4.arrr swizzling.
        /// </summary>
        public bvec4 arrr => new bvec4(w, x, x, x);
        
        /// <summary>
        /// Returns bvec4.arrg swizzling.
        /// </summary>
        public bvec4 arrg => new bvec4(w, x, x, y);
        
        /// <summary>
        /// Returns bvec4.arrb swizzling.
        /// </summary>
        public bvec4 arrb => new bvec4(w, x, x, z);
        
        /// <summary>
        /// Returns bvec4.arra swizzling.
        /// </summary>
        public bvec4 arra => new bvec4(w, x, x, w);
        
        /// <summary>
        /// Returns bvec4.arg swizzling.
        /// </summary>
        public bvec3 arg => new bvec3(w, x, y);
        
        /// <summary>
        /// Returns bvec4.argr swizzling.
        /// </summary>
        public bvec4 argr => new bvec4(w, x, y, x);
        
        /// <summary>
        /// Returns bvec4.argg swizzling.
        /// </summary>
        public bvec4 argg => new bvec4(w, x, y, y);
        
        /// <summary>
        /// Returns bvec4.argb swizzling.
        /// </summary>
        public bvec4 argb => new bvec4(w, x, y, z);
        
        /// <summary>
        /// Returns bvec4.arga swizzling.
        /// </summary>
        public bvec4 arga => new bvec4(w, x, y, w);
        
        /// <summary>
        /// Returns bvec4.arb swizzling.
        /// </summary>
        public bvec3 arb => new bvec3(w, x, z);
        
        /// <summary>
        /// Returns bvec4.arbr swizzling.
        /// </summary>
        public bvec4 arbr => new bvec4(w, x, z, x);
        
        /// <summary>
        /// Returns bvec4.arbg swizzling.
        /// </summary>
        public bvec4 arbg => new bvec4(w, x, z, y);
        
        /// <summary>
        /// Returns bvec4.arbb swizzling.
        /// </summary>
        public bvec4 arbb => new bvec4(w, x, z, z);
        
        /// <summary>
        /// Returns bvec4.arba swizzling.
        /// </summary>
        public bvec4 arba => new bvec4(w, x, z, w);
        
        /// <summary>
        /// Returns bvec4.ara swizzling.
        /// </summary>
        public bvec3 ara => new bvec3(w, x, w);
        
        /// <summary>
        /// Returns bvec4.arar swizzling.
        /// </summary>
        public bvec4 arar => new bvec4(w, x, w, x);
        
        /// <summary>
        /// Returns bvec4.arag swizzling.
        /// </summary>
        public bvec4 arag => new bvec4(w, x, w, y);
        
        /// <summary>
        /// Returns bvec4.arab swizzling.
        /// </summary>
        public bvec4 arab => new bvec4(w, x, w, z);
        
        /// <summary>
        /// Returns bvec4.araa swizzling.
        /// </summary>
        public bvec4 araa => new bvec4(w, x, w, w);
        
        /// <summary>
        /// Returns bvec4.ag swizzling.
        /// </summary>
        public bvec2 ag => new bvec2(w, y);
        
        /// <summary>
        /// Returns bvec4.agr swizzling.
        /// </summary>
        public bvec3 agr => new bvec3(w, y, x);
        
        /// <summary>
        /// Returns bvec4.agrr swizzling.
        /// </summary>
        public bvec4 agrr => new bvec4(w, y, x, x);
        
        /// <summary>
        /// Returns bvec4.agrg swizzling.
        /// </summary>
        public bvec4 agrg => new bvec4(w, y, x, y);
        
        /// <summary>
        /// Returns bvec4.agrb swizzling.
        /// </summary>
        public bvec4 agrb => new bvec4(w, y, x, z);
        
        /// <summary>
        /// Returns bvec4.agra swizzling.
        /// </summary>
        public bvec4 agra => new bvec4(w, y, x, w);
        
        /// <summary>
        /// Returns bvec4.agg swizzling.
        /// </summary>
        public bvec3 agg => new bvec3(w, y, y);
        
        /// <summary>
        /// Returns bvec4.aggr swizzling.
        /// </summary>
        public bvec4 aggr => new bvec4(w, y, y, x);
        
        /// <summary>
        /// Returns bvec4.aggg swizzling.
        /// </summary>
        public bvec4 aggg => new bvec4(w, y, y, y);
        
        /// <summary>
        /// Returns bvec4.aggb swizzling.
        /// </summary>
        public bvec4 aggb => new bvec4(w, y, y, z);
        
        /// <summary>
        /// Returns bvec4.agga swizzling.
        /// </summary>
        public bvec4 agga => new bvec4(w, y, y, w);
        
        /// <summary>
        /// Returns bvec4.agb swizzling.
        /// </summary>
        public bvec3 agb => new bvec3(w, y, z);
        
        /// <summary>
        /// Returns bvec4.agbr swizzling.
        /// </summary>
        public bvec4 agbr => new bvec4(w, y, z, x);
        
        /// <summary>
        /// Returns bvec4.agbg swizzling.
        /// </summary>
        public bvec4 agbg => new bvec4(w, y, z, y);
        
        /// <summary>
        /// Returns bvec4.agbb swizzling.
        /// </summary>
        public bvec4 agbb => new bvec4(w, y, z, z);
        
        /// <summary>
        /// Returns bvec4.agba swizzling.
        /// </summary>
        public bvec4 agba => new bvec4(w, y, z, w);
        
        /// <summary>
        /// Returns bvec4.aga swizzling.
        /// </summary>
        public bvec3 aga => new bvec3(w, y, w);
        
        /// <summary>
        /// Returns bvec4.agar swizzling.
        /// </summary>
        public bvec4 agar => new bvec4(w, y, w, x);
        
        /// <summary>
        /// Returns bvec4.agag swizzling.
        /// </summary>
        public bvec4 agag => new bvec4(w, y, w, y);
        
        /// <summary>
        /// Returns bvec4.agab swizzling.
        /// </summary>
        public bvec4 agab => new bvec4(w, y, w, z);
        
        /// <summary>
        /// Returns bvec4.agaa swizzling.
        /// </summary>
        public bvec4 agaa => new bvec4(w, y, w, w);
        
        /// <summary>
        /// Returns bvec4.ab swizzling.
        /// </summary>
        public bvec2 ab => new bvec2(w, z);
        
        /// <summary>
        /// Returns bvec4.abr swizzling.
        /// </summary>
        public bvec3 abr => new bvec3(w, z, x);
        
        /// <summary>
        /// Returns bvec4.abrr swizzling.
        /// </summary>
        public bvec4 abrr => new bvec4(w, z, x, x);
        
        /// <summary>
        /// Returns bvec4.abrg swizzling.
        /// </summary>
        public bvec4 abrg => new bvec4(w, z, x, y);
        
        /// <summary>
        /// Returns bvec4.abrb swizzling.
        /// </summary>
        public bvec4 abrb => new bvec4(w, z, x, z);
        
        /// <summary>
        /// Returns bvec4.abra swizzling.
        /// </summary>
        public bvec4 abra => new bvec4(w, z, x, w);
        
        /// <summary>
        /// Returns bvec4.abg swizzling.
        /// </summary>
        public bvec3 abg => new bvec3(w, z, y);
        
        /// <summary>
        /// Returns bvec4.abgr swizzling.
        /// </summary>
        public bvec4 abgr => new bvec4(w, z, y, x);
        
        /// <summary>
        /// Returns bvec4.abgg swizzling.
        /// </summary>
        public bvec4 abgg => new bvec4(w, z, y, y);
        
        /// <summary>
        /// Returns bvec4.abgb swizzling.
        /// </summary>
        public bvec4 abgb => new bvec4(w, z, y, z);
        
        /// <summary>
        /// Returns bvec4.abga swizzling.
        /// </summary>
        public bvec4 abga => new bvec4(w, z, y, w);
        
        /// <summary>
        /// Returns bvec4.abb swizzling.
        /// </summary>
        public bvec3 abb => new bvec3(w, z, z);
        
        /// <summary>
        /// Returns bvec4.abbr swizzling.
        /// </summary>
        public bvec4 abbr => new bvec4(w, z, z, x);
        
        /// <summary>
        /// Returns bvec4.abbg swizzling.
        /// </summary>
        public bvec4 abbg => new bvec4(w, z, z, y);
        
        /// <summary>
        /// Returns bvec4.abbb swizzling.
        /// </summary>
        public bvec4 abbb => new bvec4(w, z, z, z);
        
        /// <summary>
        /// Returns bvec4.abba swizzling.
        /// </summary>
        public bvec4 abba => new bvec4(w, z, z, w);
        
        /// <summary>
        /// Returns bvec4.aba swizzling.
        /// </summary>
        public bvec3 aba => new bvec3(w, z, w);
        
        /// <summary>
        /// Returns bvec4.abar swizzling.
        /// </summary>
        public bvec4 abar => new bvec4(w, z, w, x);
        
        /// <summary>
        /// Returns bvec4.abag swizzling.
        /// </summary>
        public bvec4 abag => new bvec4(w, z, w, y);
        
        /// <summary>
        /// Returns bvec4.abab swizzling.
        /// </summary>
        public bvec4 abab => new bvec4(w, z, w, z);
        
        /// <summary>
        /// Returns bvec4.abaa swizzling.
        /// </summary>
        public bvec4 abaa => new bvec4(w, z, w, w);
        
        /// <summary>
        /// Returns bvec4.aa swizzling.
        /// </summary>
        public bvec2 aa => new bvec2(w, w);
        
        /// <summary>
        /// Returns bvec4.aar swizzling.
        /// </summary>
        public bvec3 aar => new bvec3(w, w, x);
        
        /// <summary>
        /// Returns bvec4.aarr swizzling.
        /// </summary>
        public bvec4 aarr => new bvec4(w, w, x, x);
        
        /// <summary>
        /// Returns bvec4.aarg swizzling.
        /// </summary>
        public bvec4 aarg => new bvec4(w, w, x, y);
        
        /// <summary>
        /// Returns bvec4.aarb swizzling.
        /// </summary>
        public bvec4 aarb => new bvec4(w, w, x, z);
        
        /// <summary>
        /// Returns bvec4.aara swizzling.
        /// </summary>
        public bvec4 aara => new bvec4(w, w, x, w);
        
        /// <summary>
        /// Returns bvec4.aag swizzling.
        /// </summary>
        public bvec3 aag => new bvec3(w, w, y);
        
        /// <summary>
        /// Returns bvec4.aagr swizzling.
        /// </summary>
        public bvec4 aagr => new bvec4(w, w, y, x);
        
        /// <summary>
        /// Returns bvec4.aagg swizzling.
        /// </summary>
        public bvec4 aagg => new bvec4(w, w, y, y);
        
        /// <summary>
        /// Returns bvec4.aagb swizzling.
        /// </summary>
        public bvec4 aagb => new bvec4(w, w, y, z);
        
        /// <summary>
        /// Returns bvec4.aaga swizzling.
        /// </summary>
        public bvec4 aaga => new bvec4(w, w, y, w);
        
        /// <summary>
        /// Returns bvec4.aab swizzling.
        /// </summary>
        public bvec3 aab => new bvec3(w, w, z);
        
        /// <summary>
        /// Returns bvec4.aabr swizzling.
        /// </summary>
        public bvec4 aabr => new bvec4(w, w, z, x);
        
        /// <summary>
        /// Returns bvec4.aabg swizzling.
        /// </summary>
        public bvec4 aabg => new bvec4(w, w, z, y);
        
        /// <summary>
        /// Returns bvec4.aabb swizzling.
        /// </summary>
        public bvec4 aabb => new bvec4(w, w, z, z);
        
        /// <summary>
        /// Returns bvec4.aaba swizzling.
        /// </summary>
        public bvec4 aaba => new bvec4(w, w, z, w);
        
        /// <summary>
        /// Returns bvec4.aaa swizzling.
        /// </summary>
        public bvec3 aaa => new bvec3(w, w, w);
        
        /// <summary>
        /// Returns bvec4.aaar swizzling.
        /// </summary>
        public bvec4 aaar => new bvec4(w, w, w, x);
        
        /// <summary>
        /// Returns bvec4.aaag swizzling.
        /// </summary>
        public bvec4 aaag => new bvec4(w, w, w, y);
        
        /// <summary>
        /// Returns bvec4.aaab swizzling.
        /// </summary>
        public bvec4 aaab => new bvec4(w, w, w, z);
        
        /// <summary>
        /// Returns bvec4.aaaa swizzling.
        /// </summary>
        public bvec4 aaaa => new bvec4(w, w, w, w);
    }
}
