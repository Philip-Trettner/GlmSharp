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
    /// Temporary vector of type long with 2 components, used for implementing swizzling for lvec2.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_lvec2
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
        /// Constructor for swizzle_lvec2.
        /// </summary>
        internal swizzle_lvec2(long x, long y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns lvec2.xx swizzling.
        /// </summary>
        public lvec2 xx => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec2.xxx swizzling.
        /// </summary>
        public lvec3 xxx => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec2.xxxx swizzling.
        /// </summary>
        public lvec4 xxxx => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec2.xxxy swizzling.
        /// </summary>
        public lvec4 xxxy => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec2.xxy swizzling.
        /// </summary>
        public lvec3 xxy => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec2.xxyx swizzling.
        /// </summary>
        public lvec4 xxyx => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec2.xxyy swizzling.
        /// </summary>
        public lvec4 xxyy => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec2.xy swizzling.
        /// </summary>
        public lvec2 xy => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec2.xyx swizzling.
        /// </summary>
        public lvec3 xyx => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec2.xyxx swizzling.
        /// </summary>
        public lvec4 xyxx => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec2.xyxy swizzling.
        /// </summary>
        public lvec4 xyxy => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec2.xyy swizzling.
        /// </summary>
        public lvec3 xyy => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec2.xyyx swizzling.
        /// </summary>
        public lvec4 xyyx => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec2.xyyy swizzling.
        /// </summary>
        public lvec4 xyyy => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec2.yx swizzling.
        /// </summary>
        public lvec2 yx => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec2.yxx swizzling.
        /// </summary>
        public lvec3 yxx => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec2.yxxx swizzling.
        /// </summary>
        public lvec4 yxxx => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec2.yxxy swizzling.
        /// </summary>
        public lvec4 yxxy => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec2.yxy swizzling.
        /// </summary>
        public lvec3 yxy => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec2.yxyx swizzling.
        /// </summary>
        public lvec4 yxyx => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec2.yxyy swizzling.
        /// </summary>
        public lvec4 yxyy => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec2.yy swizzling.
        /// </summary>
        public lvec2 yy => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec2.yyx swizzling.
        /// </summary>
        public lvec3 yyx => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec2.yyxx swizzling.
        /// </summary>
        public lvec4 yyxx => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec2.yyxy swizzling.
        /// </summary>
        public lvec4 yyxy => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec2.yyy swizzling.
        /// </summary>
        public lvec3 yyy => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec2.yyyx swizzling.
        /// </summary>
        public lvec4 yyyx => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec2.yyyy swizzling.
        /// </summary>
        public lvec4 yyyy => new lvec4(y, y, y, y);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns lvec2.rr swizzling.
        /// </summary>
        public lvec2 rr => new lvec2(x, x);
        
        /// <summary>
        /// Returns lvec2.rrr swizzling.
        /// </summary>
        public lvec3 rrr => new lvec3(x, x, x);
        
        /// <summary>
        /// Returns lvec2.rrrr swizzling.
        /// </summary>
        public lvec4 rrrr => new lvec4(x, x, x, x);
        
        /// <summary>
        /// Returns lvec2.rrrg swizzling.
        /// </summary>
        public lvec4 rrrg => new lvec4(x, x, x, y);
        
        /// <summary>
        /// Returns lvec2.rrg swizzling.
        /// </summary>
        public lvec3 rrg => new lvec3(x, x, y);
        
        /// <summary>
        /// Returns lvec2.rrgr swizzling.
        /// </summary>
        public lvec4 rrgr => new lvec4(x, x, y, x);
        
        /// <summary>
        /// Returns lvec2.rrgg swizzling.
        /// </summary>
        public lvec4 rrgg => new lvec4(x, x, y, y);
        
        /// <summary>
        /// Returns lvec2.rg swizzling.
        /// </summary>
        public lvec2 rg => new lvec2(x, y);
        
        /// <summary>
        /// Returns lvec2.rgr swizzling.
        /// </summary>
        public lvec3 rgr => new lvec3(x, y, x);
        
        /// <summary>
        /// Returns lvec2.rgrr swizzling.
        /// </summary>
        public lvec4 rgrr => new lvec4(x, y, x, x);
        
        /// <summary>
        /// Returns lvec2.rgrg swizzling.
        /// </summary>
        public lvec4 rgrg => new lvec4(x, y, x, y);
        
        /// <summary>
        /// Returns lvec2.rgg swizzling.
        /// </summary>
        public lvec3 rgg => new lvec3(x, y, y);
        
        /// <summary>
        /// Returns lvec2.rggr swizzling.
        /// </summary>
        public lvec4 rggr => new lvec4(x, y, y, x);
        
        /// <summary>
        /// Returns lvec2.rggg swizzling.
        /// </summary>
        public lvec4 rggg => new lvec4(x, y, y, y);
        
        /// <summary>
        /// Returns lvec2.gr swizzling.
        /// </summary>
        public lvec2 gr => new lvec2(y, x);
        
        /// <summary>
        /// Returns lvec2.grr swizzling.
        /// </summary>
        public lvec3 grr => new lvec3(y, x, x);
        
        /// <summary>
        /// Returns lvec2.grrr swizzling.
        /// </summary>
        public lvec4 grrr => new lvec4(y, x, x, x);
        
        /// <summary>
        /// Returns lvec2.grrg swizzling.
        /// </summary>
        public lvec4 grrg => new lvec4(y, x, x, y);
        
        /// <summary>
        /// Returns lvec2.grg swizzling.
        /// </summary>
        public lvec3 grg => new lvec3(y, x, y);
        
        /// <summary>
        /// Returns lvec2.grgr swizzling.
        /// </summary>
        public lvec4 grgr => new lvec4(y, x, y, x);
        
        /// <summary>
        /// Returns lvec2.grgg swizzling.
        /// </summary>
        public lvec4 grgg => new lvec4(y, x, y, y);
        
        /// <summary>
        /// Returns lvec2.gg swizzling.
        /// </summary>
        public lvec2 gg => new lvec2(y, y);
        
        /// <summary>
        /// Returns lvec2.ggr swizzling.
        /// </summary>
        public lvec3 ggr => new lvec3(y, y, x);
        
        /// <summary>
        /// Returns lvec2.ggrr swizzling.
        /// </summary>
        public lvec4 ggrr => new lvec4(y, y, x, x);
        
        /// <summary>
        /// Returns lvec2.ggrg swizzling.
        /// </summary>
        public lvec4 ggrg => new lvec4(y, y, x, y);
        
        /// <summary>
        /// Returns lvec2.ggg swizzling.
        /// </summary>
        public lvec3 ggg => new lvec3(y, y, y);
        
        /// <summary>
        /// Returns lvec2.gggr swizzling.
        /// </summary>
        public lvec4 gggr => new lvec4(y, y, y, x);
        
        /// <summary>
        /// Returns lvec2.gggg swizzling.
        /// </summary>
        public lvec4 gggg => new lvec4(y, y, y, y);
    }
}
