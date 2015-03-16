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
    /// Temporary vector of type decimal with 4 components, used for implementing swizzling for decvec4.
    /// </summary>
    [Serializable]
    public struct swizzle_decvec4
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly decimal x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly decimal y;
        
        /// <summary>
        /// z-component
        /// </summary>
        internal readonly decimal z;
        
        /// <summary>
        /// w-component
        /// </summary>
        internal readonly decimal w;
        
        
        /// <summary>
        /// Constructor for swizzle_decvec4.
        /// </summary>
        internal swizzle_decvec4(decimal x, decimal y, decimal z, decimal w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns decvec4.xx swizzling.
        /// </summary>
        public decvec2 xx => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec4.xxx swizzling.
        /// </summary>
        public decvec3 xxx => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec4.xxxx swizzling.
        /// </summary>
        public decvec4 xxxx => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.xxxy swizzling.
        /// </summary>
        public decvec4 xxxy => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.xxxz swizzling.
        /// </summary>
        public decvec4 xxxz => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.xxxw swizzling.
        /// </summary>
        public decvec4 xxxw => new decvec4(x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.xxy swizzling.
        /// </summary>
        public decvec3 xxy => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec4.xxyx swizzling.
        /// </summary>
        public decvec4 xxyx => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.xxyy swizzling.
        /// </summary>
        public decvec4 xxyy => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.xxyz swizzling.
        /// </summary>
        public decvec4 xxyz => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.xxyw swizzling.
        /// </summary>
        public decvec4 xxyw => new decvec4(x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.xxz swizzling.
        /// </summary>
        public decvec3 xxz => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec4.xxzx swizzling.
        /// </summary>
        public decvec4 xxzx => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.xxzy swizzling.
        /// </summary>
        public decvec4 xxzy => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.xxzz swizzling.
        /// </summary>
        public decvec4 xxzz => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.xxzw swizzling.
        /// </summary>
        public decvec4 xxzw => new decvec4(x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.xxw swizzling.
        /// </summary>
        public decvec3 xxw => new decvec3(x, x, w);
        
        /// <summary>
        /// Returns decvec4.xxwx swizzling.
        /// </summary>
        public decvec4 xxwx => new decvec4(x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.xxwy swizzling.
        /// </summary>
        public decvec4 xxwy => new decvec4(x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.xxwz swizzling.
        /// </summary>
        public decvec4 xxwz => new decvec4(x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.xxww swizzling.
        /// </summary>
        public decvec4 xxww => new decvec4(x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.xy swizzling.
        /// </summary>
        public decvec2 xy => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec4.xyx swizzling.
        /// </summary>
        public decvec3 xyx => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec4.xyxx swizzling.
        /// </summary>
        public decvec4 xyxx => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.xyxy swizzling.
        /// </summary>
        public decvec4 xyxy => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.xyxz swizzling.
        /// </summary>
        public decvec4 xyxz => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.xyxw swizzling.
        /// </summary>
        public decvec4 xyxw => new decvec4(x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.xyy swizzling.
        /// </summary>
        public decvec3 xyy => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec4.xyyx swizzling.
        /// </summary>
        public decvec4 xyyx => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.xyyy swizzling.
        /// </summary>
        public decvec4 xyyy => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.xyyz swizzling.
        /// </summary>
        public decvec4 xyyz => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.xyyw swizzling.
        /// </summary>
        public decvec4 xyyw => new decvec4(x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.xyz swizzling.
        /// </summary>
        public decvec3 xyz => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec4.xyzx swizzling.
        /// </summary>
        public decvec4 xyzx => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.xyzy swizzling.
        /// </summary>
        public decvec4 xyzy => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.xyzz swizzling.
        /// </summary>
        public decvec4 xyzz => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.xyzw swizzling.
        /// </summary>
        public decvec4 xyzw => new decvec4(x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.xyw swizzling.
        /// </summary>
        public decvec3 xyw => new decvec3(x, y, w);
        
        /// <summary>
        /// Returns decvec4.xywx swizzling.
        /// </summary>
        public decvec4 xywx => new decvec4(x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.xywy swizzling.
        /// </summary>
        public decvec4 xywy => new decvec4(x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.xywz swizzling.
        /// </summary>
        public decvec4 xywz => new decvec4(x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.xyww swizzling.
        /// </summary>
        public decvec4 xyww => new decvec4(x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.xz swizzling.
        /// </summary>
        public decvec2 xz => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec4.xzx swizzling.
        /// </summary>
        public decvec3 xzx => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec4.xzxx swizzling.
        /// </summary>
        public decvec4 xzxx => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.xzxy swizzling.
        /// </summary>
        public decvec4 xzxy => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.xzxz swizzling.
        /// </summary>
        public decvec4 xzxz => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.xzxw swizzling.
        /// </summary>
        public decvec4 xzxw => new decvec4(x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.xzy swizzling.
        /// </summary>
        public decvec3 xzy => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec4.xzyx swizzling.
        /// </summary>
        public decvec4 xzyx => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.xzyy swizzling.
        /// </summary>
        public decvec4 xzyy => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.xzyz swizzling.
        /// </summary>
        public decvec4 xzyz => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.xzyw swizzling.
        /// </summary>
        public decvec4 xzyw => new decvec4(x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.xzz swizzling.
        /// </summary>
        public decvec3 xzz => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec4.xzzx swizzling.
        /// </summary>
        public decvec4 xzzx => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.xzzy swizzling.
        /// </summary>
        public decvec4 xzzy => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.xzzz swizzling.
        /// </summary>
        public decvec4 xzzz => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.xzzw swizzling.
        /// </summary>
        public decvec4 xzzw => new decvec4(x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.xzw swizzling.
        /// </summary>
        public decvec3 xzw => new decvec3(x, z, w);
        
        /// <summary>
        /// Returns decvec4.xzwx swizzling.
        /// </summary>
        public decvec4 xzwx => new decvec4(x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.xzwy swizzling.
        /// </summary>
        public decvec4 xzwy => new decvec4(x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.xzwz swizzling.
        /// </summary>
        public decvec4 xzwz => new decvec4(x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.xzww swizzling.
        /// </summary>
        public decvec4 xzww => new decvec4(x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.xw swizzling.
        /// </summary>
        public decvec2 xw => new decvec2(x, w);
        
        /// <summary>
        /// Returns decvec4.xwx swizzling.
        /// </summary>
        public decvec3 xwx => new decvec3(x, w, x);
        
        /// <summary>
        /// Returns decvec4.xwxx swizzling.
        /// </summary>
        public decvec4 xwxx => new decvec4(x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.xwxy swizzling.
        /// </summary>
        public decvec4 xwxy => new decvec4(x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.xwxz swizzling.
        /// </summary>
        public decvec4 xwxz => new decvec4(x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.xwxw swizzling.
        /// </summary>
        public decvec4 xwxw => new decvec4(x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.xwy swizzling.
        /// </summary>
        public decvec3 xwy => new decvec3(x, w, y);
        
        /// <summary>
        /// Returns decvec4.xwyx swizzling.
        /// </summary>
        public decvec4 xwyx => new decvec4(x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.xwyy swizzling.
        /// </summary>
        public decvec4 xwyy => new decvec4(x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.xwyz swizzling.
        /// </summary>
        public decvec4 xwyz => new decvec4(x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.xwyw swizzling.
        /// </summary>
        public decvec4 xwyw => new decvec4(x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.xwz swizzling.
        /// </summary>
        public decvec3 xwz => new decvec3(x, w, z);
        
        /// <summary>
        /// Returns decvec4.xwzx swizzling.
        /// </summary>
        public decvec4 xwzx => new decvec4(x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.xwzy swizzling.
        /// </summary>
        public decvec4 xwzy => new decvec4(x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.xwzz swizzling.
        /// </summary>
        public decvec4 xwzz => new decvec4(x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.xwzw swizzling.
        /// </summary>
        public decvec4 xwzw => new decvec4(x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.xww swizzling.
        /// </summary>
        public decvec3 xww => new decvec3(x, w, w);
        
        /// <summary>
        /// Returns decvec4.xwwx swizzling.
        /// </summary>
        public decvec4 xwwx => new decvec4(x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.xwwy swizzling.
        /// </summary>
        public decvec4 xwwy => new decvec4(x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.xwwz swizzling.
        /// </summary>
        public decvec4 xwwz => new decvec4(x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.xwww swizzling.
        /// </summary>
        public decvec4 xwww => new decvec4(x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.yx swizzling.
        /// </summary>
        public decvec2 yx => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec4.yxx swizzling.
        /// </summary>
        public decvec3 yxx => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec4.yxxx swizzling.
        /// </summary>
        public decvec4 yxxx => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.yxxy swizzling.
        /// </summary>
        public decvec4 yxxy => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.yxxz swizzling.
        /// </summary>
        public decvec4 yxxz => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.yxxw swizzling.
        /// </summary>
        public decvec4 yxxw => new decvec4(y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.yxy swizzling.
        /// </summary>
        public decvec3 yxy => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec4.yxyx swizzling.
        /// </summary>
        public decvec4 yxyx => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.yxyy swizzling.
        /// </summary>
        public decvec4 yxyy => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.yxyz swizzling.
        /// </summary>
        public decvec4 yxyz => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.yxyw swizzling.
        /// </summary>
        public decvec4 yxyw => new decvec4(y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.yxz swizzling.
        /// </summary>
        public decvec3 yxz => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec4.yxzx swizzling.
        /// </summary>
        public decvec4 yxzx => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.yxzy swizzling.
        /// </summary>
        public decvec4 yxzy => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.yxzz swizzling.
        /// </summary>
        public decvec4 yxzz => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.yxzw swizzling.
        /// </summary>
        public decvec4 yxzw => new decvec4(y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.yxw swizzling.
        /// </summary>
        public decvec3 yxw => new decvec3(y, x, w);
        
        /// <summary>
        /// Returns decvec4.yxwx swizzling.
        /// </summary>
        public decvec4 yxwx => new decvec4(y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.yxwy swizzling.
        /// </summary>
        public decvec4 yxwy => new decvec4(y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.yxwz swizzling.
        /// </summary>
        public decvec4 yxwz => new decvec4(y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.yxww swizzling.
        /// </summary>
        public decvec4 yxww => new decvec4(y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.yy swizzling.
        /// </summary>
        public decvec2 yy => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec4.yyx swizzling.
        /// </summary>
        public decvec3 yyx => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec4.yyxx swizzling.
        /// </summary>
        public decvec4 yyxx => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.yyxy swizzling.
        /// </summary>
        public decvec4 yyxy => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.yyxz swizzling.
        /// </summary>
        public decvec4 yyxz => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.yyxw swizzling.
        /// </summary>
        public decvec4 yyxw => new decvec4(y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.yyy swizzling.
        /// </summary>
        public decvec3 yyy => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec4.yyyx swizzling.
        /// </summary>
        public decvec4 yyyx => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.yyyy swizzling.
        /// </summary>
        public decvec4 yyyy => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.yyyz swizzling.
        /// </summary>
        public decvec4 yyyz => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.yyyw swizzling.
        /// </summary>
        public decvec4 yyyw => new decvec4(y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.yyz swizzling.
        /// </summary>
        public decvec3 yyz => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec4.yyzx swizzling.
        /// </summary>
        public decvec4 yyzx => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.yyzy swizzling.
        /// </summary>
        public decvec4 yyzy => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.yyzz swizzling.
        /// </summary>
        public decvec4 yyzz => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.yyzw swizzling.
        /// </summary>
        public decvec4 yyzw => new decvec4(y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.yyw swizzling.
        /// </summary>
        public decvec3 yyw => new decvec3(y, y, w);
        
        /// <summary>
        /// Returns decvec4.yywx swizzling.
        /// </summary>
        public decvec4 yywx => new decvec4(y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.yywy swizzling.
        /// </summary>
        public decvec4 yywy => new decvec4(y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.yywz swizzling.
        /// </summary>
        public decvec4 yywz => new decvec4(y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.yyww swizzling.
        /// </summary>
        public decvec4 yyww => new decvec4(y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.yz swizzling.
        /// </summary>
        public decvec2 yz => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec4.yzx swizzling.
        /// </summary>
        public decvec3 yzx => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec4.yzxx swizzling.
        /// </summary>
        public decvec4 yzxx => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.yzxy swizzling.
        /// </summary>
        public decvec4 yzxy => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.yzxz swizzling.
        /// </summary>
        public decvec4 yzxz => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.yzxw swizzling.
        /// </summary>
        public decvec4 yzxw => new decvec4(y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.yzy swizzling.
        /// </summary>
        public decvec3 yzy => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec4.yzyx swizzling.
        /// </summary>
        public decvec4 yzyx => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.yzyy swizzling.
        /// </summary>
        public decvec4 yzyy => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.yzyz swizzling.
        /// </summary>
        public decvec4 yzyz => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.yzyw swizzling.
        /// </summary>
        public decvec4 yzyw => new decvec4(y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.yzz swizzling.
        /// </summary>
        public decvec3 yzz => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec4.yzzx swizzling.
        /// </summary>
        public decvec4 yzzx => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.yzzy swizzling.
        /// </summary>
        public decvec4 yzzy => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.yzzz swizzling.
        /// </summary>
        public decvec4 yzzz => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.yzzw swizzling.
        /// </summary>
        public decvec4 yzzw => new decvec4(y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.yzw swizzling.
        /// </summary>
        public decvec3 yzw => new decvec3(y, z, w);
        
        /// <summary>
        /// Returns decvec4.yzwx swizzling.
        /// </summary>
        public decvec4 yzwx => new decvec4(y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.yzwy swizzling.
        /// </summary>
        public decvec4 yzwy => new decvec4(y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.yzwz swizzling.
        /// </summary>
        public decvec4 yzwz => new decvec4(y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.yzww swizzling.
        /// </summary>
        public decvec4 yzww => new decvec4(y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.yw swizzling.
        /// </summary>
        public decvec2 yw => new decvec2(y, w);
        
        /// <summary>
        /// Returns decvec4.ywx swizzling.
        /// </summary>
        public decvec3 ywx => new decvec3(y, w, x);
        
        /// <summary>
        /// Returns decvec4.ywxx swizzling.
        /// </summary>
        public decvec4 ywxx => new decvec4(y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.ywxy swizzling.
        /// </summary>
        public decvec4 ywxy => new decvec4(y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.ywxz swizzling.
        /// </summary>
        public decvec4 ywxz => new decvec4(y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.ywxw swizzling.
        /// </summary>
        public decvec4 ywxw => new decvec4(y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.ywy swizzling.
        /// </summary>
        public decvec3 ywy => new decvec3(y, w, y);
        
        /// <summary>
        /// Returns decvec4.ywyx swizzling.
        /// </summary>
        public decvec4 ywyx => new decvec4(y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.ywyy swizzling.
        /// </summary>
        public decvec4 ywyy => new decvec4(y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.ywyz swizzling.
        /// </summary>
        public decvec4 ywyz => new decvec4(y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.ywyw swizzling.
        /// </summary>
        public decvec4 ywyw => new decvec4(y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.ywz swizzling.
        /// </summary>
        public decvec3 ywz => new decvec3(y, w, z);
        
        /// <summary>
        /// Returns decvec4.ywzx swizzling.
        /// </summary>
        public decvec4 ywzx => new decvec4(y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.ywzy swizzling.
        /// </summary>
        public decvec4 ywzy => new decvec4(y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.ywzz swizzling.
        /// </summary>
        public decvec4 ywzz => new decvec4(y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.ywzw swizzling.
        /// </summary>
        public decvec4 ywzw => new decvec4(y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.yww swizzling.
        /// </summary>
        public decvec3 yww => new decvec3(y, w, w);
        
        /// <summary>
        /// Returns decvec4.ywwx swizzling.
        /// </summary>
        public decvec4 ywwx => new decvec4(y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.ywwy swizzling.
        /// </summary>
        public decvec4 ywwy => new decvec4(y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.ywwz swizzling.
        /// </summary>
        public decvec4 ywwz => new decvec4(y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.ywww swizzling.
        /// </summary>
        public decvec4 ywww => new decvec4(y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.zx swizzling.
        /// </summary>
        public decvec2 zx => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec4.zxx swizzling.
        /// </summary>
        public decvec3 zxx => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec4.zxxx swizzling.
        /// </summary>
        public decvec4 zxxx => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.zxxy swizzling.
        /// </summary>
        public decvec4 zxxy => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.zxxz swizzling.
        /// </summary>
        public decvec4 zxxz => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.zxxw swizzling.
        /// </summary>
        public decvec4 zxxw => new decvec4(z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.zxy swizzling.
        /// </summary>
        public decvec3 zxy => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec4.zxyx swizzling.
        /// </summary>
        public decvec4 zxyx => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.zxyy swizzling.
        /// </summary>
        public decvec4 zxyy => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.zxyz swizzling.
        /// </summary>
        public decvec4 zxyz => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.zxyw swizzling.
        /// </summary>
        public decvec4 zxyw => new decvec4(z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.zxz swizzling.
        /// </summary>
        public decvec3 zxz => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec4.zxzx swizzling.
        /// </summary>
        public decvec4 zxzx => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.zxzy swizzling.
        /// </summary>
        public decvec4 zxzy => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.zxzz swizzling.
        /// </summary>
        public decvec4 zxzz => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.zxzw swizzling.
        /// </summary>
        public decvec4 zxzw => new decvec4(z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.zxw swizzling.
        /// </summary>
        public decvec3 zxw => new decvec3(z, x, w);
        
        /// <summary>
        /// Returns decvec4.zxwx swizzling.
        /// </summary>
        public decvec4 zxwx => new decvec4(z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.zxwy swizzling.
        /// </summary>
        public decvec4 zxwy => new decvec4(z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.zxwz swizzling.
        /// </summary>
        public decvec4 zxwz => new decvec4(z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.zxww swizzling.
        /// </summary>
        public decvec4 zxww => new decvec4(z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.zy swizzling.
        /// </summary>
        public decvec2 zy => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec4.zyx swizzling.
        /// </summary>
        public decvec3 zyx => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec4.zyxx swizzling.
        /// </summary>
        public decvec4 zyxx => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.zyxy swizzling.
        /// </summary>
        public decvec4 zyxy => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.zyxz swizzling.
        /// </summary>
        public decvec4 zyxz => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.zyxw swizzling.
        /// </summary>
        public decvec4 zyxw => new decvec4(z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.zyy swizzling.
        /// </summary>
        public decvec3 zyy => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec4.zyyx swizzling.
        /// </summary>
        public decvec4 zyyx => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.zyyy swizzling.
        /// </summary>
        public decvec4 zyyy => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.zyyz swizzling.
        /// </summary>
        public decvec4 zyyz => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.zyyw swizzling.
        /// </summary>
        public decvec4 zyyw => new decvec4(z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.zyz swizzling.
        /// </summary>
        public decvec3 zyz => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec4.zyzx swizzling.
        /// </summary>
        public decvec4 zyzx => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.zyzy swizzling.
        /// </summary>
        public decvec4 zyzy => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.zyzz swizzling.
        /// </summary>
        public decvec4 zyzz => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.zyzw swizzling.
        /// </summary>
        public decvec4 zyzw => new decvec4(z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.zyw swizzling.
        /// </summary>
        public decvec3 zyw => new decvec3(z, y, w);
        
        /// <summary>
        /// Returns decvec4.zywx swizzling.
        /// </summary>
        public decvec4 zywx => new decvec4(z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.zywy swizzling.
        /// </summary>
        public decvec4 zywy => new decvec4(z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.zywz swizzling.
        /// </summary>
        public decvec4 zywz => new decvec4(z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.zyww swizzling.
        /// </summary>
        public decvec4 zyww => new decvec4(z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.zz swizzling.
        /// </summary>
        public decvec2 zz => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec4.zzx swizzling.
        /// </summary>
        public decvec3 zzx => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec4.zzxx swizzling.
        /// </summary>
        public decvec4 zzxx => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.zzxy swizzling.
        /// </summary>
        public decvec4 zzxy => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.zzxz swizzling.
        /// </summary>
        public decvec4 zzxz => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.zzxw swizzling.
        /// </summary>
        public decvec4 zzxw => new decvec4(z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.zzy swizzling.
        /// </summary>
        public decvec3 zzy => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec4.zzyx swizzling.
        /// </summary>
        public decvec4 zzyx => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.zzyy swizzling.
        /// </summary>
        public decvec4 zzyy => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.zzyz swizzling.
        /// </summary>
        public decvec4 zzyz => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.zzyw swizzling.
        /// </summary>
        public decvec4 zzyw => new decvec4(z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.zzz swizzling.
        /// </summary>
        public decvec3 zzz => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec4.zzzx swizzling.
        /// </summary>
        public decvec4 zzzx => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.zzzy swizzling.
        /// </summary>
        public decvec4 zzzy => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.zzzz swizzling.
        /// </summary>
        public decvec4 zzzz => new decvec4(z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.zzzw swizzling.
        /// </summary>
        public decvec4 zzzw => new decvec4(z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.zzw swizzling.
        /// </summary>
        public decvec3 zzw => new decvec3(z, z, w);
        
        /// <summary>
        /// Returns decvec4.zzwx swizzling.
        /// </summary>
        public decvec4 zzwx => new decvec4(z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.zzwy swizzling.
        /// </summary>
        public decvec4 zzwy => new decvec4(z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.zzwz swizzling.
        /// </summary>
        public decvec4 zzwz => new decvec4(z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.zzww swizzling.
        /// </summary>
        public decvec4 zzww => new decvec4(z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.zw swizzling.
        /// </summary>
        public decvec2 zw => new decvec2(z, w);
        
        /// <summary>
        /// Returns decvec4.zwx swizzling.
        /// </summary>
        public decvec3 zwx => new decvec3(z, w, x);
        
        /// <summary>
        /// Returns decvec4.zwxx swizzling.
        /// </summary>
        public decvec4 zwxx => new decvec4(z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.zwxy swizzling.
        /// </summary>
        public decvec4 zwxy => new decvec4(z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.zwxz swizzling.
        /// </summary>
        public decvec4 zwxz => new decvec4(z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.zwxw swizzling.
        /// </summary>
        public decvec4 zwxw => new decvec4(z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.zwy swizzling.
        /// </summary>
        public decvec3 zwy => new decvec3(z, w, y);
        
        /// <summary>
        /// Returns decvec4.zwyx swizzling.
        /// </summary>
        public decvec4 zwyx => new decvec4(z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.zwyy swizzling.
        /// </summary>
        public decvec4 zwyy => new decvec4(z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.zwyz swizzling.
        /// </summary>
        public decvec4 zwyz => new decvec4(z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.zwyw swizzling.
        /// </summary>
        public decvec4 zwyw => new decvec4(z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.zwz swizzling.
        /// </summary>
        public decvec3 zwz => new decvec3(z, w, z);
        
        /// <summary>
        /// Returns decvec4.zwzx swizzling.
        /// </summary>
        public decvec4 zwzx => new decvec4(z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.zwzy swizzling.
        /// </summary>
        public decvec4 zwzy => new decvec4(z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.zwzz swizzling.
        /// </summary>
        public decvec4 zwzz => new decvec4(z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.zwzw swizzling.
        /// </summary>
        public decvec4 zwzw => new decvec4(z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.zww swizzling.
        /// </summary>
        public decvec3 zww => new decvec3(z, w, w);
        
        /// <summary>
        /// Returns decvec4.zwwx swizzling.
        /// </summary>
        public decvec4 zwwx => new decvec4(z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.zwwy swizzling.
        /// </summary>
        public decvec4 zwwy => new decvec4(z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.zwwz swizzling.
        /// </summary>
        public decvec4 zwwz => new decvec4(z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.zwww swizzling.
        /// </summary>
        public decvec4 zwww => new decvec4(z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.wx swizzling.
        /// </summary>
        public decvec2 wx => new decvec2(w, x);
        
        /// <summary>
        /// Returns decvec4.wxx swizzling.
        /// </summary>
        public decvec3 wxx => new decvec3(w, x, x);
        
        /// <summary>
        /// Returns decvec4.wxxx swizzling.
        /// </summary>
        public decvec4 wxxx => new decvec4(w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.wxxy swizzling.
        /// </summary>
        public decvec4 wxxy => new decvec4(w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.wxxz swizzling.
        /// </summary>
        public decvec4 wxxz => new decvec4(w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.wxxw swizzling.
        /// </summary>
        public decvec4 wxxw => new decvec4(w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.wxy swizzling.
        /// </summary>
        public decvec3 wxy => new decvec3(w, x, y);
        
        /// <summary>
        /// Returns decvec4.wxyx swizzling.
        /// </summary>
        public decvec4 wxyx => new decvec4(w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.wxyy swizzling.
        /// </summary>
        public decvec4 wxyy => new decvec4(w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.wxyz swizzling.
        /// </summary>
        public decvec4 wxyz => new decvec4(w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.wxyw swizzling.
        /// </summary>
        public decvec4 wxyw => new decvec4(w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.wxz swizzling.
        /// </summary>
        public decvec3 wxz => new decvec3(w, x, z);
        
        /// <summary>
        /// Returns decvec4.wxzx swizzling.
        /// </summary>
        public decvec4 wxzx => new decvec4(w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.wxzy swizzling.
        /// </summary>
        public decvec4 wxzy => new decvec4(w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.wxzz swizzling.
        /// </summary>
        public decvec4 wxzz => new decvec4(w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.wxzw swizzling.
        /// </summary>
        public decvec4 wxzw => new decvec4(w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.wxw swizzling.
        /// </summary>
        public decvec3 wxw => new decvec3(w, x, w);
        
        /// <summary>
        /// Returns decvec4.wxwx swizzling.
        /// </summary>
        public decvec4 wxwx => new decvec4(w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.wxwy swizzling.
        /// </summary>
        public decvec4 wxwy => new decvec4(w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.wxwz swizzling.
        /// </summary>
        public decvec4 wxwz => new decvec4(w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.wxww swizzling.
        /// </summary>
        public decvec4 wxww => new decvec4(w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.wy swizzling.
        /// </summary>
        public decvec2 wy => new decvec2(w, y);
        
        /// <summary>
        /// Returns decvec4.wyx swizzling.
        /// </summary>
        public decvec3 wyx => new decvec3(w, y, x);
        
        /// <summary>
        /// Returns decvec4.wyxx swizzling.
        /// </summary>
        public decvec4 wyxx => new decvec4(w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.wyxy swizzling.
        /// </summary>
        public decvec4 wyxy => new decvec4(w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.wyxz swizzling.
        /// </summary>
        public decvec4 wyxz => new decvec4(w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.wyxw swizzling.
        /// </summary>
        public decvec4 wyxw => new decvec4(w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.wyy swizzling.
        /// </summary>
        public decvec3 wyy => new decvec3(w, y, y);
        
        /// <summary>
        /// Returns decvec4.wyyx swizzling.
        /// </summary>
        public decvec4 wyyx => new decvec4(w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.wyyy swizzling.
        /// </summary>
        public decvec4 wyyy => new decvec4(w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.wyyz swizzling.
        /// </summary>
        public decvec4 wyyz => new decvec4(w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.wyyw swizzling.
        /// </summary>
        public decvec4 wyyw => new decvec4(w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.wyz swizzling.
        /// </summary>
        public decvec3 wyz => new decvec3(w, y, z);
        
        /// <summary>
        /// Returns decvec4.wyzx swizzling.
        /// </summary>
        public decvec4 wyzx => new decvec4(w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.wyzy swizzling.
        /// </summary>
        public decvec4 wyzy => new decvec4(w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.wyzz swizzling.
        /// </summary>
        public decvec4 wyzz => new decvec4(w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.wyzw swizzling.
        /// </summary>
        public decvec4 wyzw => new decvec4(w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.wyw swizzling.
        /// </summary>
        public decvec3 wyw => new decvec3(w, y, w);
        
        /// <summary>
        /// Returns decvec4.wywx swizzling.
        /// </summary>
        public decvec4 wywx => new decvec4(w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.wywy swizzling.
        /// </summary>
        public decvec4 wywy => new decvec4(w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.wywz swizzling.
        /// </summary>
        public decvec4 wywz => new decvec4(w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.wyww swizzling.
        /// </summary>
        public decvec4 wyww => new decvec4(w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.wz swizzling.
        /// </summary>
        public decvec2 wz => new decvec2(w, z);
        
        /// <summary>
        /// Returns decvec4.wzx swizzling.
        /// </summary>
        public decvec3 wzx => new decvec3(w, z, x);
        
        /// <summary>
        /// Returns decvec4.wzxx swizzling.
        /// </summary>
        public decvec4 wzxx => new decvec4(w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.wzxy swizzling.
        /// </summary>
        public decvec4 wzxy => new decvec4(w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.wzxz swizzling.
        /// </summary>
        public decvec4 wzxz => new decvec4(w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.wzxw swizzling.
        /// </summary>
        public decvec4 wzxw => new decvec4(w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.wzy swizzling.
        /// </summary>
        public decvec3 wzy => new decvec3(w, z, y);
        
        /// <summary>
        /// Returns decvec4.wzyx swizzling.
        /// </summary>
        public decvec4 wzyx => new decvec4(w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.wzyy swizzling.
        /// </summary>
        public decvec4 wzyy => new decvec4(w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.wzyz swizzling.
        /// </summary>
        public decvec4 wzyz => new decvec4(w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.wzyw swizzling.
        /// </summary>
        public decvec4 wzyw => new decvec4(w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.wzz swizzling.
        /// </summary>
        public decvec3 wzz => new decvec3(w, z, z);
        
        /// <summary>
        /// Returns decvec4.wzzx swizzling.
        /// </summary>
        public decvec4 wzzx => new decvec4(w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.wzzy swizzling.
        /// </summary>
        public decvec4 wzzy => new decvec4(w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.wzzz swizzling.
        /// </summary>
        public decvec4 wzzz => new decvec4(w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.wzzw swizzling.
        /// </summary>
        public decvec4 wzzw => new decvec4(w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.wzw swizzling.
        /// </summary>
        public decvec3 wzw => new decvec3(w, z, w);
        
        /// <summary>
        /// Returns decvec4.wzwx swizzling.
        /// </summary>
        public decvec4 wzwx => new decvec4(w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.wzwy swizzling.
        /// </summary>
        public decvec4 wzwy => new decvec4(w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.wzwz swizzling.
        /// </summary>
        public decvec4 wzwz => new decvec4(w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.wzww swizzling.
        /// </summary>
        public decvec4 wzww => new decvec4(w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.ww swizzling.
        /// </summary>
        public decvec2 ww => new decvec2(w, w);
        
        /// <summary>
        /// Returns decvec4.wwx swizzling.
        /// </summary>
        public decvec3 wwx => new decvec3(w, w, x);
        
        /// <summary>
        /// Returns decvec4.wwxx swizzling.
        /// </summary>
        public decvec4 wwxx => new decvec4(w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.wwxy swizzling.
        /// </summary>
        public decvec4 wwxy => new decvec4(w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.wwxz swizzling.
        /// </summary>
        public decvec4 wwxz => new decvec4(w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.wwxw swizzling.
        /// </summary>
        public decvec4 wwxw => new decvec4(w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.wwy swizzling.
        /// </summary>
        public decvec3 wwy => new decvec3(w, w, y);
        
        /// <summary>
        /// Returns decvec4.wwyx swizzling.
        /// </summary>
        public decvec4 wwyx => new decvec4(w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.wwyy swizzling.
        /// </summary>
        public decvec4 wwyy => new decvec4(w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.wwyz swizzling.
        /// </summary>
        public decvec4 wwyz => new decvec4(w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.wwyw swizzling.
        /// </summary>
        public decvec4 wwyw => new decvec4(w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.wwz swizzling.
        /// </summary>
        public decvec3 wwz => new decvec3(w, w, z);
        
        /// <summary>
        /// Returns decvec4.wwzx swizzling.
        /// </summary>
        public decvec4 wwzx => new decvec4(w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.wwzy swizzling.
        /// </summary>
        public decvec4 wwzy => new decvec4(w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.wwzz swizzling.
        /// </summary>
        public decvec4 wwzz => new decvec4(w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.wwzw swizzling.
        /// </summary>
        public decvec4 wwzw => new decvec4(w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.www swizzling.
        /// </summary>
        public decvec3 www => new decvec3(w, w, w);
        
        /// <summary>
        /// Returns decvec4.wwwx swizzling.
        /// </summary>
        public decvec4 wwwx => new decvec4(w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.wwwy swizzling.
        /// </summary>
        public decvec4 wwwy => new decvec4(w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.wwwz swizzling.
        /// </summary>
        public decvec4 wwwz => new decvec4(w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.wwww swizzling.
        /// </summary>
        public decvec4 wwww => new decvec4(w, w, w, w);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns decvec4.rr swizzling.
        /// </summary>
        public decvec2 rr => new decvec2(x, x);
        
        /// <summary>
        /// Returns decvec4.rrr swizzling.
        /// </summary>
        public decvec3 rrr => new decvec3(x, x, x);
        
        /// <summary>
        /// Returns decvec4.rrrr swizzling.
        /// </summary>
        public decvec4 rrrr => new decvec4(x, x, x, x);
        
        /// <summary>
        /// Returns decvec4.rrrg swizzling.
        /// </summary>
        public decvec4 rrrg => new decvec4(x, x, x, y);
        
        /// <summary>
        /// Returns decvec4.rrrb swizzling.
        /// </summary>
        public decvec4 rrrb => new decvec4(x, x, x, z);
        
        /// <summary>
        /// Returns decvec4.rrra swizzling.
        /// </summary>
        public decvec4 rrra => new decvec4(x, x, x, w);
        
        /// <summary>
        /// Returns decvec4.rrg swizzling.
        /// </summary>
        public decvec3 rrg => new decvec3(x, x, y);
        
        /// <summary>
        /// Returns decvec4.rrgr swizzling.
        /// </summary>
        public decvec4 rrgr => new decvec4(x, x, y, x);
        
        /// <summary>
        /// Returns decvec4.rrgg swizzling.
        /// </summary>
        public decvec4 rrgg => new decvec4(x, x, y, y);
        
        /// <summary>
        /// Returns decvec4.rrgb swizzling.
        /// </summary>
        public decvec4 rrgb => new decvec4(x, x, y, z);
        
        /// <summary>
        /// Returns decvec4.rrga swizzling.
        /// </summary>
        public decvec4 rrga => new decvec4(x, x, y, w);
        
        /// <summary>
        /// Returns decvec4.rrb swizzling.
        /// </summary>
        public decvec3 rrb => new decvec3(x, x, z);
        
        /// <summary>
        /// Returns decvec4.rrbr swizzling.
        /// </summary>
        public decvec4 rrbr => new decvec4(x, x, z, x);
        
        /// <summary>
        /// Returns decvec4.rrbg swizzling.
        /// </summary>
        public decvec4 rrbg => new decvec4(x, x, z, y);
        
        /// <summary>
        /// Returns decvec4.rrbb swizzling.
        /// </summary>
        public decvec4 rrbb => new decvec4(x, x, z, z);
        
        /// <summary>
        /// Returns decvec4.rrba swizzling.
        /// </summary>
        public decvec4 rrba => new decvec4(x, x, z, w);
        
        /// <summary>
        /// Returns decvec4.rra swizzling.
        /// </summary>
        public decvec3 rra => new decvec3(x, x, w);
        
        /// <summary>
        /// Returns decvec4.rrar swizzling.
        /// </summary>
        public decvec4 rrar => new decvec4(x, x, w, x);
        
        /// <summary>
        /// Returns decvec4.rrag swizzling.
        /// </summary>
        public decvec4 rrag => new decvec4(x, x, w, y);
        
        /// <summary>
        /// Returns decvec4.rrab swizzling.
        /// </summary>
        public decvec4 rrab => new decvec4(x, x, w, z);
        
        /// <summary>
        /// Returns decvec4.rraa swizzling.
        /// </summary>
        public decvec4 rraa => new decvec4(x, x, w, w);
        
        /// <summary>
        /// Returns decvec4.rg swizzling.
        /// </summary>
        public decvec2 rg => new decvec2(x, y);
        
        /// <summary>
        /// Returns decvec4.rgr swizzling.
        /// </summary>
        public decvec3 rgr => new decvec3(x, y, x);
        
        /// <summary>
        /// Returns decvec4.rgrr swizzling.
        /// </summary>
        public decvec4 rgrr => new decvec4(x, y, x, x);
        
        /// <summary>
        /// Returns decvec4.rgrg swizzling.
        /// </summary>
        public decvec4 rgrg => new decvec4(x, y, x, y);
        
        /// <summary>
        /// Returns decvec4.rgrb swizzling.
        /// </summary>
        public decvec4 rgrb => new decvec4(x, y, x, z);
        
        /// <summary>
        /// Returns decvec4.rgra swizzling.
        /// </summary>
        public decvec4 rgra => new decvec4(x, y, x, w);
        
        /// <summary>
        /// Returns decvec4.rgg swizzling.
        /// </summary>
        public decvec3 rgg => new decvec3(x, y, y);
        
        /// <summary>
        /// Returns decvec4.rggr swizzling.
        /// </summary>
        public decvec4 rggr => new decvec4(x, y, y, x);
        
        /// <summary>
        /// Returns decvec4.rggg swizzling.
        /// </summary>
        public decvec4 rggg => new decvec4(x, y, y, y);
        
        /// <summary>
        /// Returns decvec4.rggb swizzling.
        /// </summary>
        public decvec4 rggb => new decvec4(x, y, y, z);
        
        /// <summary>
        /// Returns decvec4.rgga swizzling.
        /// </summary>
        public decvec4 rgga => new decvec4(x, y, y, w);
        
        /// <summary>
        /// Returns decvec4.rgb swizzling.
        /// </summary>
        public decvec3 rgb => new decvec3(x, y, z);
        
        /// <summary>
        /// Returns decvec4.rgbr swizzling.
        /// </summary>
        public decvec4 rgbr => new decvec4(x, y, z, x);
        
        /// <summary>
        /// Returns decvec4.rgbg swizzling.
        /// </summary>
        public decvec4 rgbg => new decvec4(x, y, z, y);
        
        /// <summary>
        /// Returns decvec4.rgbb swizzling.
        /// </summary>
        public decvec4 rgbb => new decvec4(x, y, z, z);
        
        /// <summary>
        /// Returns decvec4.rgba swizzling.
        /// </summary>
        public decvec4 rgba => new decvec4(x, y, z, w);
        
        /// <summary>
        /// Returns decvec4.rga swizzling.
        /// </summary>
        public decvec3 rga => new decvec3(x, y, w);
        
        /// <summary>
        /// Returns decvec4.rgar swizzling.
        /// </summary>
        public decvec4 rgar => new decvec4(x, y, w, x);
        
        /// <summary>
        /// Returns decvec4.rgag swizzling.
        /// </summary>
        public decvec4 rgag => new decvec4(x, y, w, y);
        
        /// <summary>
        /// Returns decvec4.rgab swizzling.
        /// </summary>
        public decvec4 rgab => new decvec4(x, y, w, z);
        
        /// <summary>
        /// Returns decvec4.rgaa swizzling.
        /// </summary>
        public decvec4 rgaa => new decvec4(x, y, w, w);
        
        /// <summary>
        /// Returns decvec4.rb swizzling.
        /// </summary>
        public decvec2 rb => new decvec2(x, z);
        
        /// <summary>
        /// Returns decvec4.rbr swizzling.
        /// </summary>
        public decvec3 rbr => new decvec3(x, z, x);
        
        /// <summary>
        /// Returns decvec4.rbrr swizzling.
        /// </summary>
        public decvec4 rbrr => new decvec4(x, z, x, x);
        
        /// <summary>
        /// Returns decvec4.rbrg swizzling.
        /// </summary>
        public decvec4 rbrg => new decvec4(x, z, x, y);
        
        /// <summary>
        /// Returns decvec4.rbrb swizzling.
        /// </summary>
        public decvec4 rbrb => new decvec4(x, z, x, z);
        
        /// <summary>
        /// Returns decvec4.rbra swizzling.
        /// </summary>
        public decvec4 rbra => new decvec4(x, z, x, w);
        
        /// <summary>
        /// Returns decvec4.rbg swizzling.
        /// </summary>
        public decvec3 rbg => new decvec3(x, z, y);
        
        /// <summary>
        /// Returns decvec4.rbgr swizzling.
        /// </summary>
        public decvec4 rbgr => new decvec4(x, z, y, x);
        
        /// <summary>
        /// Returns decvec4.rbgg swizzling.
        /// </summary>
        public decvec4 rbgg => new decvec4(x, z, y, y);
        
        /// <summary>
        /// Returns decvec4.rbgb swizzling.
        /// </summary>
        public decvec4 rbgb => new decvec4(x, z, y, z);
        
        /// <summary>
        /// Returns decvec4.rbga swizzling.
        /// </summary>
        public decvec4 rbga => new decvec4(x, z, y, w);
        
        /// <summary>
        /// Returns decvec4.rbb swizzling.
        /// </summary>
        public decvec3 rbb => new decvec3(x, z, z);
        
        /// <summary>
        /// Returns decvec4.rbbr swizzling.
        /// </summary>
        public decvec4 rbbr => new decvec4(x, z, z, x);
        
        /// <summary>
        /// Returns decvec4.rbbg swizzling.
        /// </summary>
        public decvec4 rbbg => new decvec4(x, z, z, y);
        
        /// <summary>
        /// Returns decvec4.rbbb swizzling.
        /// </summary>
        public decvec4 rbbb => new decvec4(x, z, z, z);
        
        /// <summary>
        /// Returns decvec4.rbba swizzling.
        /// </summary>
        public decvec4 rbba => new decvec4(x, z, z, w);
        
        /// <summary>
        /// Returns decvec4.rba swizzling.
        /// </summary>
        public decvec3 rba => new decvec3(x, z, w);
        
        /// <summary>
        /// Returns decvec4.rbar swizzling.
        /// </summary>
        public decvec4 rbar => new decvec4(x, z, w, x);
        
        /// <summary>
        /// Returns decvec4.rbag swizzling.
        /// </summary>
        public decvec4 rbag => new decvec4(x, z, w, y);
        
        /// <summary>
        /// Returns decvec4.rbab swizzling.
        /// </summary>
        public decvec4 rbab => new decvec4(x, z, w, z);
        
        /// <summary>
        /// Returns decvec4.rbaa swizzling.
        /// </summary>
        public decvec4 rbaa => new decvec4(x, z, w, w);
        
        /// <summary>
        /// Returns decvec4.ra swizzling.
        /// </summary>
        public decvec2 ra => new decvec2(x, w);
        
        /// <summary>
        /// Returns decvec4.rar swizzling.
        /// </summary>
        public decvec3 rar => new decvec3(x, w, x);
        
        /// <summary>
        /// Returns decvec4.rarr swizzling.
        /// </summary>
        public decvec4 rarr => new decvec4(x, w, x, x);
        
        /// <summary>
        /// Returns decvec4.rarg swizzling.
        /// </summary>
        public decvec4 rarg => new decvec4(x, w, x, y);
        
        /// <summary>
        /// Returns decvec4.rarb swizzling.
        /// </summary>
        public decvec4 rarb => new decvec4(x, w, x, z);
        
        /// <summary>
        /// Returns decvec4.rara swizzling.
        /// </summary>
        public decvec4 rara => new decvec4(x, w, x, w);
        
        /// <summary>
        /// Returns decvec4.rag swizzling.
        /// </summary>
        public decvec3 rag => new decvec3(x, w, y);
        
        /// <summary>
        /// Returns decvec4.ragr swizzling.
        /// </summary>
        public decvec4 ragr => new decvec4(x, w, y, x);
        
        /// <summary>
        /// Returns decvec4.ragg swizzling.
        /// </summary>
        public decvec4 ragg => new decvec4(x, w, y, y);
        
        /// <summary>
        /// Returns decvec4.ragb swizzling.
        /// </summary>
        public decvec4 ragb => new decvec4(x, w, y, z);
        
        /// <summary>
        /// Returns decvec4.raga swizzling.
        /// </summary>
        public decvec4 raga => new decvec4(x, w, y, w);
        
        /// <summary>
        /// Returns decvec4.rab swizzling.
        /// </summary>
        public decvec3 rab => new decvec3(x, w, z);
        
        /// <summary>
        /// Returns decvec4.rabr swizzling.
        /// </summary>
        public decvec4 rabr => new decvec4(x, w, z, x);
        
        /// <summary>
        /// Returns decvec4.rabg swizzling.
        /// </summary>
        public decvec4 rabg => new decvec4(x, w, z, y);
        
        /// <summary>
        /// Returns decvec4.rabb swizzling.
        /// </summary>
        public decvec4 rabb => new decvec4(x, w, z, z);
        
        /// <summary>
        /// Returns decvec4.raba swizzling.
        /// </summary>
        public decvec4 raba => new decvec4(x, w, z, w);
        
        /// <summary>
        /// Returns decvec4.raa swizzling.
        /// </summary>
        public decvec3 raa => new decvec3(x, w, w);
        
        /// <summary>
        /// Returns decvec4.raar swizzling.
        /// </summary>
        public decvec4 raar => new decvec4(x, w, w, x);
        
        /// <summary>
        /// Returns decvec4.raag swizzling.
        /// </summary>
        public decvec4 raag => new decvec4(x, w, w, y);
        
        /// <summary>
        /// Returns decvec4.raab swizzling.
        /// </summary>
        public decvec4 raab => new decvec4(x, w, w, z);
        
        /// <summary>
        /// Returns decvec4.raaa swizzling.
        /// </summary>
        public decvec4 raaa => new decvec4(x, w, w, w);
        
        /// <summary>
        /// Returns decvec4.gr swizzling.
        /// </summary>
        public decvec2 gr => new decvec2(y, x);
        
        /// <summary>
        /// Returns decvec4.grr swizzling.
        /// </summary>
        public decvec3 grr => new decvec3(y, x, x);
        
        /// <summary>
        /// Returns decvec4.grrr swizzling.
        /// </summary>
        public decvec4 grrr => new decvec4(y, x, x, x);
        
        /// <summary>
        /// Returns decvec4.grrg swizzling.
        /// </summary>
        public decvec4 grrg => new decvec4(y, x, x, y);
        
        /// <summary>
        /// Returns decvec4.grrb swizzling.
        /// </summary>
        public decvec4 grrb => new decvec4(y, x, x, z);
        
        /// <summary>
        /// Returns decvec4.grra swizzling.
        /// </summary>
        public decvec4 grra => new decvec4(y, x, x, w);
        
        /// <summary>
        /// Returns decvec4.grg swizzling.
        /// </summary>
        public decvec3 grg => new decvec3(y, x, y);
        
        /// <summary>
        /// Returns decvec4.grgr swizzling.
        /// </summary>
        public decvec4 grgr => new decvec4(y, x, y, x);
        
        /// <summary>
        /// Returns decvec4.grgg swizzling.
        /// </summary>
        public decvec4 grgg => new decvec4(y, x, y, y);
        
        /// <summary>
        /// Returns decvec4.grgb swizzling.
        /// </summary>
        public decvec4 grgb => new decvec4(y, x, y, z);
        
        /// <summary>
        /// Returns decvec4.grga swizzling.
        /// </summary>
        public decvec4 grga => new decvec4(y, x, y, w);
        
        /// <summary>
        /// Returns decvec4.grb swizzling.
        /// </summary>
        public decvec3 grb => new decvec3(y, x, z);
        
        /// <summary>
        /// Returns decvec4.grbr swizzling.
        /// </summary>
        public decvec4 grbr => new decvec4(y, x, z, x);
        
        /// <summary>
        /// Returns decvec4.grbg swizzling.
        /// </summary>
        public decvec4 grbg => new decvec4(y, x, z, y);
        
        /// <summary>
        /// Returns decvec4.grbb swizzling.
        /// </summary>
        public decvec4 grbb => new decvec4(y, x, z, z);
        
        /// <summary>
        /// Returns decvec4.grba swizzling.
        /// </summary>
        public decvec4 grba => new decvec4(y, x, z, w);
        
        /// <summary>
        /// Returns decvec4.gra swizzling.
        /// </summary>
        public decvec3 gra => new decvec3(y, x, w);
        
        /// <summary>
        /// Returns decvec4.grar swizzling.
        /// </summary>
        public decvec4 grar => new decvec4(y, x, w, x);
        
        /// <summary>
        /// Returns decvec4.grag swizzling.
        /// </summary>
        public decvec4 grag => new decvec4(y, x, w, y);
        
        /// <summary>
        /// Returns decvec4.grab swizzling.
        /// </summary>
        public decvec4 grab => new decvec4(y, x, w, z);
        
        /// <summary>
        /// Returns decvec4.graa swizzling.
        /// </summary>
        public decvec4 graa => new decvec4(y, x, w, w);
        
        /// <summary>
        /// Returns decvec4.gg swizzling.
        /// </summary>
        public decvec2 gg => new decvec2(y, y);
        
        /// <summary>
        /// Returns decvec4.ggr swizzling.
        /// </summary>
        public decvec3 ggr => new decvec3(y, y, x);
        
        /// <summary>
        /// Returns decvec4.ggrr swizzling.
        /// </summary>
        public decvec4 ggrr => new decvec4(y, y, x, x);
        
        /// <summary>
        /// Returns decvec4.ggrg swizzling.
        /// </summary>
        public decvec4 ggrg => new decvec4(y, y, x, y);
        
        /// <summary>
        /// Returns decvec4.ggrb swizzling.
        /// </summary>
        public decvec4 ggrb => new decvec4(y, y, x, z);
        
        /// <summary>
        /// Returns decvec4.ggra swizzling.
        /// </summary>
        public decvec4 ggra => new decvec4(y, y, x, w);
        
        /// <summary>
        /// Returns decvec4.ggg swizzling.
        /// </summary>
        public decvec3 ggg => new decvec3(y, y, y);
        
        /// <summary>
        /// Returns decvec4.gggr swizzling.
        /// </summary>
        public decvec4 gggr => new decvec4(y, y, y, x);
        
        /// <summary>
        /// Returns decvec4.gggg swizzling.
        /// </summary>
        public decvec4 gggg => new decvec4(y, y, y, y);
        
        /// <summary>
        /// Returns decvec4.gggb swizzling.
        /// </summary>
        public decvec4 gggb => new decvec4(y, y, y, z);
        
        /// <summary>
        /// Returns decvec4.ggga swizzling.
        /// </summary>
        public decvec4 ggga => new decvec4(y, y, y, w);
        
        /// <summary>
        /// Returns decvec4.ggb swizzling.
        /// </summary>
        public decvec3 ggb => new decvec3(y, y, z);
        
        /// <summary>
        /// Returns decvec4.ggbr swizzling.
        /// </summary>
        public decvec4 ggbr => new decvec4(y, y, z, x);
        
        /// <summary>
        /// Returns decvec4.ggbg swizzling.
        /// </summary>
        public decvec4 ggbg => new decvec4(y, y, z, y);
        
        /// <summary>
        /// Returns decvec4.ggbb swizzling.
        /// </summary>
        public decvec4 ggbb => new decvec4(y, y, z, z);
        
        /// <summary>
        /// Returns decvec4.ggba swizzling.
        /// </summary>
        public decvec4 ggba => new decvec4(y, y, z, w);
        
        /// <summary>
        /// Returns decvec4.gga swizzling.
        /// </summary>
        public decvec3 gga => new decvec3(y, y, w);
        
        /// <summary>
        /// Returns decvec4.ggar swizzling.
        /// </summary>
        public decvec4 ggar => new decvec4(y, y, w, x);
        
        /// <summary>
        /// Returns decvec4.ggag swizzling.
        /// </summary>
        public decvec4 ggag => new decvec4(y, y, w, y);
        
        /// <summary>
        /// Returns decvec4.ggab swizzling.
        /// </summary>
        public decvec4 ggab => new decvec4(y, y, w, z);
        
        /// <summary>
        /// Returns decvec4.ggaa swizzling.
        /// </summary>
        public decvec4 ggaa => new decvec4(y, y, w, w);
        
        /// <summary>
        /// Returns decvec4.gb swizzling.
        /// </summary>
        public decvec2 gb => new decvec2(y, z);
        
        /// <summary>
        /// Returns decvec4.gbr swizzling.
        /// </summary>
        public decvec3 gbr => new decvec3(y, z, x);
        
        /// <summary>
        /// Returns decvec4.gbrr swizzling.
        /// </summary>
        public decvec4 gbrr => new decvec4(y, z, x, x);
        
        /// <summary>
        /// Returns decvec4.gbrg swizzling.
        /// </summary>
        public decvec4 gbrg => new decvec4(y, z, x, y);
        
        /// <summary>
        /// Returns decvec4.gbrb swizzling.
        /// </summary>
        public decvec4 gbrb => new decvec4(y, z, x, z);
        
        /// <summary>
        /// Returns decvec4.gbra swizzling.
        /// </summary>
        public decvec4 gbra => new decvec4(y, z, x, w);
        
        /// <summary>
        /// Returns decvec4.gbg swizzling.
        /// </summary>
        public decvec3 gbg => new decvec3(y, z, y);
        
        /// <summary>
        /// Returns decvec4.gbgr swizzling.
        /// </summary>
        public decvec4 gbgr => new decvec4(y, z, y, x);
        
        /// <summary>
        /// Returns decvec4.gbgg swizzling.
        /// </summary>
        public decvec4 gbgg => new decvec4(y, z, y, y);
        
        /// <summary>
        /// Returns decvec4.gbgb swizzling.
        /// </summary>
        public decvec4 gbgb => new decvec4(y, z, y, z);
        
        /// <summary>
        /// Returns decvec4.gbga swizzling.
        /// </summary>
        public decvec4 gbga => new decvec4(y, z, y, w);
        
        /// <summary>
        /// Returns decvec4.gbb swizzling.
        /// </summary>
        public decvec3 gbb => new decvec3(y, z, z);
        
        /// <summary>
        /// Returns decvec4.gbbr swizzling.
        /// </summary>
        public decvec4 gbbr => new decvec4(y, z, z, x);
        
        /// <summary>
        /// Returns decvec4.gbbg swizzling.
        /// </summary>
        public decvec4 gbbg => new decvec4(y, z, z, y);
        
        /// <summary>
        /// Returns decvec4.gbbb swizzling.
        /// </summary>
        public decvec4 gbbb => new decvec4(y, z, z, z);
        
        /// <summary>
        /// Returns decvec4.gbba swizzling.
        /// </summary>
        public decvec4 gbba => new decvec4(y, z, z, w);
        
        /// <summary>
        /// Returns decvec4.gba swizzling.
        /// </summary>
        public decvec3 gba => new decvec3(y, z, w);
        
        /// <summary>
        /// Returns decvec4.gbar swizzling.
        /// </summary>
        public decvec4 gbar => new decvec4(y, z, w, x);
        
        /// <summary>
        /// Returns decvec4.gbag swizzling.
        /// </summary>
        public decvec4 gbag => new decvec4(y, z, w, y);
        
        /// <summary>
        /// Returns decvec4.gbab swizzling.
        /// </summary>
        public decvec4 gbab => new decvec4(y, z, w, z);
        
        /// <summary>
        /// Returns decvec4.gbaa swizzling.
        /// </summary>
        public decvec4 gbaa => new decvec4(y, z, w, w);
        
        /// <summary>
        /// Returns decvec4.ga swizzling.
        /// </summary>
        public decvec2 ga => new decvec2(y, w);
        
        /// <summary>
        /// Returns decvec4.gar swizzling.
        /// </summary>
        public decvec3 gar => new decvec3(y, w, x);
        
        /// <summary>
        /// Returns decvec4.garr swizzling.
        /// </summary>
        public decvec4 garr => new decvec4(y, w, x, x);
        
        /// <summary>
        /// Returns decvec4.garg swizzling.
        /// </summary>
        public decvec4 garg => new decvec4(y, w, x, y);
        
        /// <summary>
        /// Returns decvec4.garb swizzling.
        /// </summary>
        public decvec4 garb => new decvec4(y, w, x, z);
        
        /// <summary>
        /// Returns decvec4.gara swizzling.
        /// </summary>
        public decvec4 gara => new decvec4(y, w, x, w);
        
        /// <summary>
        /// Returns decvec4.gag swizzling.
        /// </summary>
        public decvec3 gag => new decvec3(y, w, y);
        
        /// <summary>
        /// Returns decvec4.gagr swizzling.
        /// </summary>
        public decvec4 gagr => new decvec4(y, w, y, x);
        
        /// <summary>
        /// Returns decvec4.gagg swizzling.
        /// </summary>
        public decvec4 gagg => new decvec4(y, w, y, y);
        
        /// <summary>
        /// Returns decvec4.gagb swizzling.
        /// </summary>
        public decvec4 gagb => new decvec4(y, w, y, z);
        
        /// <summary>
        /// Returns decvec4.gaga swizzling.
        /// </summary>
        public decvec4 gaga => new decvec4(y, w, y, w);
        
        /// <summary>
        /// Returns decvec4.gab swizzling.
        /// </summary>
        public decvec3 gab => new decvec3(y, w, z);
        
        /// <summary>
        /// Returns decvec4.gabr swizzling.
        /// </summary>
        public decvec4 gabr => new decvec4(y, w, z, x);
        
        /// <summary>
        /// Returns decvec4.gabg swizzling.
        /// </summary>
        public decvec4 gabg => new decvec4(y, w, z, y);
        
        /// <summary>
        /// Returns decvec4.gabb swizzling.
        /// </summary>
        public decvec4 gabb => new decvec4(y, w, z, z);
        
        /// <summary>
        /// Returns decvec4.gaba swizzling.
        /// </summary>
        public decvec4 gaba => new decvec4(y, w, z, w);
        
        /// <summary>
        /// Returns decvec4.gaa swizzling.
        /// </summary>
        public decvec3 gaa => new decvec3(y, w, w);
        
        /// <summary>
        /// Returns decvec4.gaar swizzling.
        /// </summary>
        public decvec4 gaar => new decvec4(y, w, w, x);
        
        /// <summary>
        /// Returns decvec4.gaag swizzling.
        /// </summary>
        public decvec4 gaag => new decvec4(y, w, w, y);
        
        /// <summary>
        /// Returns decvec4.gaab swizzling.
        /// </summary>
        public decvec4 gaab => new decvec4(y, w, w, z);
        
        /// <summary>
        /// Returns decvec4.gaaa swizzling.
        /// </summary>
        public decvec4 gaaa => new decvec4(y, w, w, w);
        
        /// <summary>
        /// Returns decvec4.br swizzling.
        /// </summary>
        public decvec2 br => new decvec2(z, x);
        
        /// <summary>
        /// Returns decvec4.brr swizzling.
        /// </summary>
        public decvec3 brr => new decvec3(z, x, x);
        
        /// <summary>
        /// Returns decvec4.brrr swizzling.
        /// </summary>
        public decvec4 brrr => new decvec4(z, x, x, x);
        
        /// <summary>
        /// Returns decvec4.brrg swizzling.
        /// </summary>
        public decvec4 brrg => new decvec4(z, x, x, y);
        
        /// <summary>
        /// Returns decvec4.brrb swizzling.
        /// </summary>
        public decvec4 brrb => new decvec4(z, x, x, z);
        
        /// <summary>
        /// Returns decvec4.brra swizzling.
        /// </summary>
        public decvec4 brra => new decvec4(z, x, x, w);
        
        /// <summary>
        /// Returns decvec4.brg swizzling.
        /// </summary>
        public decvec3 brg => new decvec3(z, x, y);
        
        /// <summary>
        /// Returns decvec4.brgr swizzling.
        /// </summary>
        public decvec4 brgr => new decvec4(z, x, y, x);
        
        /// <summary>
        /// Returns decvec4.brgg swizzling.
        /// </summary>
        public decvec4 brgg => new decvec4(z, x, y, y);
        
        /// <summary>
        /// Returns decvec4.brgb swizzling.
        /// </summary>
        public decvec4 brgb => new decvec4(z, x, y, z);
        
        /// <summary>
        /// Returns decvec4.brga swizzling.
        /// </summary>
        public decvec4 brga => new decvec4(z, x, y, w);
        
        /// <summary>
        /// Returns decvec4.brb swizzling.
        /// </summary>
        public decvec3 brb => new decvec3(z, x, z);
        
        /// <summary>
        /// Returns decvec4.brbr swizzling.
        /// </summary>
        public decvec4 brbr => new decvec4(z, x, z, x);
        
        /// <summary>
        /// Returns decvec4.brbg swizzling.
        /// </summary>
        public decvec4 brbg => new decvec4(z, x, z, y);
        
        /// <summary>
        /// Returns decvec4.brbb swizzling.
        /// </summary>
        public decvec4 brbb => new decvec4(z, x, z, z);
        
        /// <summary>
        /// Returns decvec4.brba swizzling.
        /// </summary>
        public decvec4 brba => new decvec4(z, x, z, w);
        
        /// <summary>
        /// Returns decvec4.bra swizzling.
        /// </summary>
        public decvec3 bra => new decvec3(z, x, w);
        
        /// <summary>
        /// Returns decvec4.brar swizzling.
        /// </summary>
        public decvec4 brar => new decvec4(z, x, w, x);
        
        /// <summary>
        /// Returns decvec4.brag swizzling.
        /// </summary>
        public decvec4 brag => new decvec4(z, x, w, y);
        
        /// <summary>
        /// Returns decvec4.brab swizzling.
        /// </summary>
        public decvec4 brab => new decvec4(z, x, w, z);
        
        /// <summary>
        /// Returns decvec4.braa swizzling.
        /// </summary>
        public decvec4 braa => new decvec4(z, x, w, w);
        
        /// <summary>
        /// Returns decvec4.bg swizzling.
        /// </summary>
        public decvec2 bg => new decvec2(z, y);
        
        /// <summary>
        /// Returns decvec4.bgr swizzling.
        /// </summary>
        public decvec3 bgr => new decvec3(z, y, x);
        
        /// <summary>
        /// Returns decvec4.bgrr swizzling.
        /// </summary>
        public decvec4 bgrr => new decvec4(z, y, x, x);
        
        /// <summary>
        /// Returns decvec4.bgrg swizzling.
        /// </summary>
        public decvec4 bgrg => new decvec4(z, y, x, y);
        
        /// <summary>
        /// Returns decvec4.bgrb swizzling.
        /// </summary>
        public decvec4 bgrb => new decvec4(z, y, x, z);
        
        /// <summary>
        /// Returns decvec4.bgra swizzling.
        /// </summary>
        public decvec4 bgra => new decvec4(z, y, x, w);
        
        /// <summary>
        /// Returns decvec4.bgg swizzling.
        /// </summary>
        public decvec3 bgg => new decvec3(z, y, y);
        
        /// <summary>
        /// Returns decvec4.bggr swizzling.
        /// </summary>
        public decvec4 bggr => new decvec4(z, y, y, x);
        
        /// <summary>
        /// Returns decvec4.bggg swizzling.
        /// </summary>
        public decvec4 bggg => new decvec4(z, y, y, y);
        
        /// <summary>
        /// Returns decvec4.bggb swizzling.
        /// </summary>
        public decvec4 bggb => new decvec4(z, y, y, z);
        
        /// <summary>
        /// Returns decvec4.bgga swizzling.
        /// </summary>
        public decvec4 bgga => new decvec4(z, y, y, w);
        
        /// <summary>
        /// Returns decvec4.bgb swizzling.
        /// </summary>
        public decvec3 bgb => new decvec3(z, y, z);
        
        /// <summary>
        /// Returns decvec4.bgbr swizzling.
        /// </summary>
        public decvec4 bgbr => new decvec4(z, y, z, x);
        
        /// <summary>
        /// Returns decvec4.bgbg swizzling.
        /// </summary>
        public decvec4 bgbg => new decvec4(z, y, z, y);
        
        /// <summary>
        /// Returns decvec4.bgbb swizzling.
        /// </summary>
        public decvec4 bgbb => new decvec4(z, y, z, z);
        
        /// <summary>
        /// Returns decvec4.bgba swizzling.
        /// </summary>
        public decvec4 bgba => new decvec4(z, y, z, w);
        
        /// <summary>
        /// Returns decvec4.bga swizzling.
        /// </summary>
        public decvec3 bga => new decvec3(z, y, w);
        
        /// <summary>
        /// Returns decvec4.bgar swizzling.
        /// </summary>
        public decvec4 bgar => new decvec4(z, y, w, x);
        
        /// <summary>
        /// Returns decvec4.bgag swizzling.
        /// </summary>
        public decvec4 bgag => new decvec4(z, y, w, y);
        
        /// <summary>
        /// Returns decvec4.bgab swizzling.
        /// </summary>
        public decvec4 bgab => new decvec4(z, y, w, z);
        
        /// <summary>
        /// Returns decvec4.bgaa swizzling.
        /// </summary>
        public decvec4 bgaa => new decvec4(z, y, w, w);
        
        /// <summary>
        /// Returns decvec4.bb swizzling.
        /// </summary>
        public decvec2 bb => new decvec2(z, z);
        
        /// <summary>
        /// Returns decvec4.bbr swizzling.
        /// </summary>
        public decvec3 bbr => new decvec3(z, z, x);
        
        /// <summary>
        /// Returns decvec4.bbrr swizzling.
        /// </summary>
        public decvec4 bbrr => new decvec4(z, z, x, x);
        
        /// <summary>
        /// Returns decvec4.bbrg swizzling.
        /// </summary>
        public decvec4 bbrg => new decvec4(z, z, x, y);
        
        /// <summary>
        /// Returns decvec4.bbrb swizzling.
        /// </summary>
        public decvec4 bbrb => new decvec4(z, z, x, z);
        
        /// <summary>
        /// Returns decvec4.bbra swizzling.
        /// </summary>
        public decvec4 bbra => new decvec4(z, z, x, w);
        
        /// <summary>
        /// Returns decvec4.bbg swizzling.
        /// </summary>
        public decvec3 bbg => new decvec3(z, z, y);
        
        /// <summary>
        /// Returns decvec4.bbgr swizzling.
        /// </summary>
        public decvec4 bbgr => new decvec4(z, z, y, x);
        
        /// <summary>
        /// Returns decvec4.bbgg swizzling.
        /// </summary>
        public decvec4 bbgg => new decvec4(z, z, y, y);
        
        /// <summary>
        /// Returns decvec4.bbgb swizzling.
        /// </summary>
        public decvec4 bbgb => new decvec4(z, z, y, z);
        
        /// <summary>
        /// Returns decvec4.bbga swizzling.
        /// </summary>
        public decvec4 bbga => new decvec4(z, z, y, w);
        
        /// <summary>
        /// Returns decvec4.bbb swizzling.
        /// </summary>
        public decvec3 bbb => new decvec3(z, z, z);
        
        /// <summary>
        /// Returns decvec4.bbbr swizzling.
        /// </summary>
        public decvec4 bbbr => new decvec4(z, z, z, x);
        
        /// <summary>
        /// Returns decvec4.bbbg swizzling.
        /// </summary>
        public decvec4 bbbg => new decvec4(z, z, z, y);
        
        /// <summary>
        /// Returns decvec4.bbbb swizzling.
        /// </summary>
        public decvec4 bbbb => new decvec4(z, z, z, z);
        
        /// <summary>
        /// Returns decvec4.bbba swizzling.
        /// </summary>
        public decvec4 bbba => new decvec4(z, z, z, w);
        
        /// <summary>
        /// Returns decvec4.bba swizzling.
        /// </summary>
        public decvec3 bba => new decvec3(z, z, w);
        
        /// <summary>
        /// Returns decvec4.bbar swizzling.
        /// </summary>
        public decvec4 bbar => new decvec4(z, z, w, x);
        
        /// <summary>
        /// Returns decvec4.bbag swizzling.
        /// </summary>
        public decvec4 bbag => new decvec4(z, z, w, y);
        
        /// <summary>
        /// Returns decvec4.bbab swizzling.
        /// </summary>
        public decvec4 bbab => new decvec4(z, z, w, z);
        
        /// <summary>
        /// Returns decvec4.bbaa swizzling.
        /// </summary>
        public decvec4 bbaa => new decvec4(z, z, w, w);
        
        /// <summary>
        /// Returns decvec4.ba swizzling.
        /// </summary>
        public decvec2 ba => new decvec2(z, w);
        
        /// <summary>
        /// Returns decvec4.bar swizzling.
        /// </summary>
        public decvec3 bar => new decvec3(z, w, x);
        
        /// <summary>
        /// Returns decvec4.barr swizzling.
        /// </summary>
        public decvec4 barr => new decvec4(z, w, x, x);
        
        /// <summary>
        /// Returns decvec4.barg swizzling.
        /// </summary>
        public decvec4 barg => new decvec4(z, w, x, y);
        
        /// <summary>
        /// Returns decvec4.barb swizzling.
        /// </summary>
        public decvec4 barb => new decvec4(z, w, x, z);
        
        /// <summary>
        /// Returns decvec4.bara swizzling.
        /// </summary>
        public decvec4 bara => new decvec4(z, w, x, w);
        
        /// <summary>
        /// Returns decvec4.bag swizzling.
        /// </summary>
        public decvec3 bag => new decvec3(z, w, y);
        
        /// <summary>
        /// Returns decvec4.bagr swizzling.
        /// </summary>
        public decvec4 bagr => new decvec4(z, w, y, x);
        
        /// <summary>
        /// Returns decvec4.bagg swizzling.
        /// </summary>
        public decvec4 bagg => new decvec4(z, w, y, y);
        
        /// <summary>
        /// Returns decvec4.bagb swizzling.
        /// </summary>
        public decvec4 bagb => new decvec4(z, w, y, z);
        
        /// <summary>
        /// Returns decvec4.baga swizzling.
        /// </summary>
        public decvec4 baga => new decvec4(z, w, y, w);
        
        /// <summary>
        /// Returns decvec4.bab swizzling.
        /// </summary>
        public decvec3 bab => new decvec3(z, w, z);
        
        /// <summary>
        /// Returns decvec4.babr swizzling.
        /// </summary>
        public decvec4 babr => new decvec4(z, w, z, x);
        
        /// <summary>
        /// Returns decvec4.babg swizzling.
        /// </summary>
        public decvec4 babg => new decvec4(z, w, z, y);
        
        /// <summary>
        /// Returns decvec4.babb swizzling.
        /// </summary>
        public decvec4 babb => new decvec4(z, w, z, z);
        
        /// <summary>
        /// Returns decvec4.baba swizzling.
        /// </summary>
        public decvec4 baba => new decvec4(z, w, z, w);
        
        /// <summary>
        /// Returns decvec4.baa swizzling.
        /// </summary>
        public decvec3 baa => new decvec3(z, w, w);
        
        /// <summary>
        /// Returns decvec4.baar swizzling.
        /// </summary>
        public decvec4 baar => new decvec4(z, w, w, x);
        
        /// <summary>
        /// Returns decvec4.baag swizzling.
        /// </summary>
        public decvec4 baag => new decvec4(z, w, w, y);
        
        /// <summary>
        /// Returns decvec4.baab swizzling.
        /// </summary>
        public decvec4 baab => new decvec4(z, w, w, z);
        
        /// <summary>
        /// Returns decvec4.baaa swizzling.
        /// </summary>
        public decvec4 baaa => new decvec4(z, w, w, w);
        
        /// <summary>
        /// Returns decvec4.ar swizzling.
        /// </summary>
        public decvec2 ar => new decvec2(w, x);
        
        /// <summary>
        /// Returns decvec4.arr swizzling.
        /// </summary>
        public decvec3 arr => new decvec3(w, x, x);
        
        /// <summary>
        /// Returns decvec4.arrr swizzling.
        /// </summary>
        public decvec4 arrr => new decvec4(w, x, x, x);
        
        /// <summary>
        /// Returns decvec4.arrg swizzling.
        /// </summary>
        public decvec4 arrg => new decvec4(w, x, x, y);
        
        /// <summary>
        /// Returns decvec4.arrb swizzling.
        /// </summary>
        public decvec4 arrb => new decvec4(w, x, x, z);
        
        /// <summary>
        /// Returns decvec4.arra swizzling.
        /// </summary>
        public decvec4 arra => new decvec4(w, x, x, w);
        
        /// <summary>
        /// Returns decvec4.arg swizzling.
        /// </summary>
        public decvec3 arg => new decvec3(w, x, y);
        
        /// <summary>
        /// Returns decvec4.argr swizzling.
        /// </summary>
        public decvec4 argr => new decvec4(w, x, y, x);
        
        /// <summary>
        /// Returns decvec4.argg swizzling.
        /// </summary>
        public decvec4 argg => new decvec4(w, x, y, y);
        
        /// <summary>
        /// Returns decvec4.argb swizzling.
        /// </summary>
        public decvec4 argb => new decvec4(w, x, y, z);
        
        /// <summary>
        /// Returns decvec4.arga swizzling.
        /// </summary>
        public decvec4 arga => new decvec4(w, x, y, w);
        
        /// <summary>
        /// Returns decvec4.arb swizzling.
        /// </summary>
        public decvec3 arb => new decvec3(w, x, z);
        
        /// <summary>
        /// Returns decvec4.arbr swizzling.
        /// </summary>
        public decvec4 arbr => new decvec4(w, x, z, x);
        
        /// <summary>
        /// Returns decvec4.arbg swizzling.
        /// </summary>
        public decvec4 arbg => new decvec4(w, x, z, y);
        
        /// <summary>
        /// Returns decvec4.arbb swizzling.
        /// </summary>
        public decvec4 arbb => new decvec4(w, x, z, z);
        
        /// <summary>
        /// Returns decvec4.arba swizzling.
        /// </summary>
        public decvec4 arba => new decvec4(w, x, z, w);
        
        /// <summary>
        /// Returns decvec4.ara swizzling.
        /// </summary>
        public decvec3 ara => new decvec3(w, x, w);
        
        /// <summary>
        /// Returns decvec4.arar swizzling.
        /// </summary>
        public decvec4 arar => new decvec4(w, x, w, x);
        
        /// <summary>
        /// Returns decvec4.arag swizzling.
        /// </summary>
        public decvec4 arag => new decvec4(w, x, w, y);
        
        /// <summary>
        /// Returns decvec4.arab swizzling.
        /// </summary>
        public decvec4 arab => new decvec4(w, x, w, z);
        
        /// <summary>
        /// Returns decvec4.araa swizzling.
        /// </summary>
        public decvec4 araa => new decvec4(w, x, w, w);
        
        /// <summary>
        /// Returns decvec4.ag swizzling.
        /// </summary>
        public decvec2 ag => new decvec2(w, y);
        
        /// <summary>
        /// Returns decvec4.agr swizzling.
        /// </summary>
        public decvec3 agr => new decvec3(w, y, x);
        
        /// <summary>
        /// Returns decvec4.agrr swizzling.
        /// </summary>
        public decvec4 agrr => new decvec4(w, y, x, x);
        
        /// <summary>
        /// Returns decvec4.agrg swizzling.
        /// </summary>
        public decvec4 agrg => new decvec4(w, y, x, y);
        
        /// <summary>
        /// Returns decvec4.agrb swizzling.
        /// </summary>
        public decvec4 agrb => new decvec4(w, y, x, z);
        
        /// <summary>
        /// Returns decvec4.agra swizzling.
        /// </summary>
        public decvec4 agra => new decvec4(w, y, x, w);
        
        /// <summary>
        /// Returns decvec4.agg swizzling.
        /// </summary>
        public decvec3 agg => new decvec3(w, y, y);
        
        /// <summary>
        /// Returns decvec4.aggr swizzling.
        /// </summary>
        public decvec4 aggr => new decvec4(w, y, y, x);
        
        /// <summary>
        /// Returns decvec4.aggg swizzling.
        /// </summary>
        public decvec4 aggg => new decvec4(w, y, y, y);
        
        /// <summary>
        /// Returns decvec4.aggb swizzling.
        /// </summary>
        public decvec4 aggb => new decvec4(w, y, y, z);
        
        /// <summary>
        /// Returns decvec4.agga swizzling.
        /// </summary>
        public decvec4 agga => new decvec4(w, y, y, w);
        
        /// <summary>
        /// Returns decvec4.agb swizzling.
        /// </summary>
        public decvec3 agb => new decvec3(w, y, z);
        
        /// <summary>
        /// Returns decvec4.agbr swizzling.
        /// </summary>
        public decvec4 agbr => new decvec4(w, y, z, x);
        
        /// <summary>
        /// Returns decvec4.agbg swizzling.
        /// </summary>
        public decvec4 agbg => new decvec4(w, y, z, y);
        
        /// <summary>
        /// Returns decvec4.agbb swizzling.
        /// </summary>
        public decvec4 agbb => new decvec4(w, y, z, z);
        
        /// <summary>
        /// Returns decvec4.agba swizzling.
        /// </summary>
        public decvec4 agba => new decvec4(w, y, z, w);
        
        /// <summary>
        /// Returns decvec4.aga swizzling.
        /// </summary>
        public decvec3 aga => new decvec3(w, y, w);
        
        /// <summary>
        /// Returns decvec4.agar swizzling.
        /// </summary>
        public decvec4 agar => new decvec4(w, y, w, x);
        
        /// <summary>
        /// Returns decvec4.agag swizzling.
        /// </summary>
        public decvec4 agag => new decvec4(w, y, w, y);
        
        /// <summary>
        /// Returns decvec4.agab swizzling.
        /// </summary>
        public decvec4 agab => new decvec4(w, y, w, z);
        
        /// <summary>
        /// Returns decvec4.agaa swizzling.
        /// </summary>
        public decvec4 agaa => new decvec4(w, y, w, w);
        
        /// <summary>
        /// Returns decvec4.ab swizzling.
        /// </summary>
        public decvec2 ab => new decvec2(w, z);
        
        /// <summary>
        /// Returns decvec4.abr swizzling.
        /// </summary>
        public decvec3 abr => new decvec3(w, z, x);
        
        /// <summary>
        /// Returns decvec4.abrr swizzling.
        /// </summary>
        public decvec4 abrr => new decvec4(w, z, x, x);
        
        /// <summary>
        /// Returns decvec4.abrg swizzling.
        /// </summary>
        public decvec4 abrg => new decvec4(w, z, x, y);
        
        /// <summary>
        /// Returns decvec4.abrb swizzling.
        /// </summary>
        public decvec4 abrb => new decvec4(w, z, x, z);
        
        /// <summary>
        /// Returns decvec4.abra swizzling.
        /// </summary>
        public decvec4 abra => new decvec4(w, z, x, w);
        
        /// <summary>
        /// Returns decvec4.abg swizzling.
        /// </summary>
        public decvec3 abg => new decvec3(w, z, y);
        
        /// <summary>
        /// Returns decvec4.abgr swizzling.
        /// </summary>
        public decvec4 abgr => new decvec4(w, z, y, x);
        
        /// <summary>
        /// Returns decvec4.abgg swizzling.
        /// </summary>
        public decvec4 abgg => new decvec4(w, z, y, y);
        
        /// <summary>
        /// Returns decvec4.abgb swizzling.
        /// </summary>
        public decvec4 abgb => new decvec4(w, z, y, z);
        
        /// <summary>
        /// Returns decvec4.abga swizzling.
        /// </summary>
        public decvec4 abga => new decvec4(w, z, y, w);
        
        /// <summary>
        /// Returns decvec4.abb swizzling.
        /// </summary>
        public decvec3 abb => new decvec3(w, z, z);
        
        /// <summary>
        /// Returns decvec4.abbr swizzling.
        /// </summary>
        public decvec4 abbr => new decvec4(w, z, z, x);
        
        /// <summary>
        /// Returns decvec4.abbg swizzling.
        /// </summary>
        public decvec4 abbg => new decvec4(w, z, z, y);
        
        /// <summary>
        /// Returns decvec4.abbb swizzling.
        /// </summary>
        public decvec4 abbb => new decvec4(w, z, z, z);
        
        /// <summary>
        /// Returns decvec4.abba swizzling.
        /// </summary>
        public decvec4 abba => new decvec4(w, z, z, w);
        
        /// <summary>
        /// Returns decvec4.aba swizzling.
        /// </summary>
        public decvec3 aba => new decvec3(w, z, w);
        
        /// <summary>
        /// Returns decvec4.abar swizzling.
        /// </summary>
        public decvec4 abar => new decvec4(w, z, w, x);
        
        /// <summary>
        /// Returns decvec4.abag swizzling.
        /// </summary>
        public decvec4 abag => new decvec4(w, z, w, y);
        
        /// <summary>
        /// Returns decvec4.abab swizzling.
        /// </summary>
        public decvec4 abab => new decvec4(w, z, w, z);
        
        /// <summary>
        /// Returns decvec4.abaa swizzling.
        /// </summary>
        public decvec4 abaa => new decvec4(w, z, w, w);
        
        /// <summary>
        /// Returns decvec4.aa swizzling.
        /// </summary>
        public decvec2 aa => new decvec2(w, w);
        
        /// <summary>
        /// Returns decvec4.aar swizzling.
        /// </summary>
        public decvec3 aar => new decvec3(w, w, x);
        
        /// <summary>
        /// Returns decvec4.aarr swizzling.
        /// </summary>
        public decvec4 aarr => new decvec4(w, w, x, x);
        
        /// <summary>
        /// Returns decvec4.aarg swizzling.
        /// </summary>
        public decvec4 aarg => new decvec4(w, w, x, y);
        
        /// <summary>
        /// Returns decvec4.aarb swizzling.
        /// </summary>
        public decvec4 aarb => new decvec4(w, w, x, z);
        
        /// <summary>
        /// Returns decvec4.aara swizzling.
        /// </summary>
        public decvec4 aara => new decvec4(w, w, x, w);
        
        /// <summary>
        /// Returns decvec4.aag swizzling.
        /// </summary>
        public decvec3 aag => new decvec3(w, w, y);
        
        /// <summary>
        /// Returns decvec4.aagr swizzling.
        /// </summary>
        public decvec4 aagr => new decvec4(w, w, y, x);
        
        /// <summary>
        /// Returns decvec4.aagg swizzling.
        /// </summary>
        public decvec4 aagg => new decvec4(w, w, y, y);
        
        /// <summary>
        /// Returns decvec4.aagb swizzling.
        /// </summary>
        public decvec4 aagb => new decvec4(w, w, y, z);
        
        /// <summary>
        /// Returns decvec4.aaga swizzling.
        /// </summary>
        public decvec4 aaga => new decvec4(w, w, y, w);
        
        /// <summary>
        /// Returns decvec4.aab swizzling.
        /// </summary>
        public decvec3 aab => new decvec3(w, w, z);
        
        /// <summary>
        /// Returns decvec4.aabr swizzling.
        /// </summary>
        public decvec4 aabr => new decvec4(w, w, z, x);
        
        /// <summary>
        /// Returns decvec4.aabg swizzling.
        /// </summary>
        public decvec4 aabg => new decvec4(w, w, z, y);
        
        /// <summary>
        /// Returns decvec4.aabb swizzling.
        /// </summary>
        public decvec4 aabb => new decvec4(w, w, z, z);
        
        /// <summary>
        /// Returns decvec4.aaba swizzling.
        /// </summary>
        public decvec4 aaba => new decvec4(w, w, z, w);
        
        /// <summary>
        /// Returns decvec4.aaa swizzling.
        /// </summary>
        public decvec3 aaa => new decvec3(w, w, w);
        
        /// <summary>
        /// Returns decvec4.aaar swizzling.
        /// </summary>
        public decvec4 aaar => new decvec4(w, w, w, x);
        
        /// <summary>
        /// Returns decvec4.aaag swizzling.
        /// </summary>
        public decvec4 aaag => new decvec4(w, w, w, y);
        
        /// <summary>
        /// Returns decvec4.aaab swizzling.
        /// </summary>
        public decvec4 aaab => new decvec4(w, w, w, z);
        
        /// <summary>
        /// Returns decvec4.aaaa swizzling.
        /// </summary>
        public decvec4 aaaa => new decvec4(w, w, w, w);
    }
}
