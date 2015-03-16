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
    /// Temporary vector of type bool with 2 components, used for implementing swizzling for bvec2.
    /// </summary>
    [Serializable]
    public struct swizzle_bvec2
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
        /// Constructor for swizzle_bvec2.
        /// </summary>
        internal swizzle_bvec2(bool x, bool y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns bvec2.xx swizzling.
        /// </summary>
        public bvec2 xx => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec2.xxx swizzling.
        /// </summary>
        public bvec3 xxx => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec2.xxxx swizzling.
        /// </summary>
        public bvec4 xxxx => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec2.xxxy swizzling.
        /// </summary>
        public bvec4 xxxy => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec2.xxy swizzling.
        /// </summary>
        public bvec3 xxy => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec2.xxyx swizzling.
        /// </summary>
        public bvec4 xxyx => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec2.xxyy swizzling.
        /// </summary>
        public bvec4 xxyy => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec2.xy swizzling.
        /// </summary>
        public bvec2 xy => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec2.xyx swizzling.
        /// </summary>
        public bvec3 xyx => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec2.xyxx swizzling.
        /// </summary>
        public bvec4 xyxx => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec2.xyxy swizzling.
        /// </summary>
        public bvec4 xyxy => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec2.xyy swizzling.
        /// </summary>
        public bvec3 xyy => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec2.xyyx swizzling.
        /// </summary>
        public bvec4 xyyx => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec2.xyyy swizzling.
        /// </summary>
        public bvec4 xyyy => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec2.yx swizzling.
        /// </summary>
        public bvec2 yx => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec2.yxx swizzling.
        /// </summary>
        public bvec3 yxx => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec2.yxxx swizzling.
        /// </summary>
        public bvec4 yxxx => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec2.yxxy swizzling.
        /// </summary>
        public bvec4 yxxy => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec2.yxy swizzling.
        /// </summary>
        public bvec3 yxy => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec2.yxyx swizzling.
        /// </summary>
        public bvec4 yxyx => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec2.yxyy swizzling.
        /// </summary>
        public bvec4 yxyy => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec2.yy swizzling.
        /// </summary>
        public bvec2 yy => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec2.yyx swizzling.
        /// </summary>
        public bvec3 yyx => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec2.yyxx swizzling.
        /// </summary>
        public bvec4 yyxx => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec2.yyxy swizzling.
        /// </summary>
        public bvec4 yyxy => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec2.yyy swizzling.
        /// </summary>
        public bvec3 yyy => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec2.yyyx swizzling.
        /// </summary>
        public bvec4 yyyx => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec2.yyyy swizzling.
        /// </summary>
        public bvec4 yyyy => new bvec4(y, y, y, y);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns bvec2.rr swizzling.
        /// </summary>
        public bvec2 rr => new bvec2(x, x);
        
        /// <summary>
        /// Returns bvec2.rrr swizzling.
        /// </summary>
        public bvec3 rrr => new bvec3(x, x, x);
        
        /// <summary>
        /// Returns bvec2.rrrr swizzling.
        /// </summary>
        public bvec4 rrrr => new bvec4(x, x, x, x);
        
        /// <summary>
        /// Returns bvec2.rrrg swizzling.
        /// </summary>
        public bvec4 rrrg => new bvec4(x, x, x, y);
        
        /// <summary>
        /// Returns bvec2.rrg swizzling.
        /// </summary>
        public bvec3 rrg => new bvec3(x, x, y);
        
        /// <summary>
        /// Returns bvec2.rrgr swizzling.
        /// </summary>
        public bvec4 rrgr => new bvec4(x, x, y, x);
        
        /// <summary>
        /// Returns bvec2.rrgg swizzling.
        /// </summary>
        public bvec4 rrgg => new bvec4(x, x, y, y);
        
        /// <summary>
        /// Returns bvec2.rg swizzling.
        /// </summary>
        public bvec2 rg => new bvec2(x, y);
        
        /// <summary>
        /// Returns bvec2.rgr swizzling.
        /// </summary>
        public bvec3 rgr => new bvec3(x, y, x);
        
        /// <summary>
        /// Returns bvec2.rgrr swizzling.
        /// </summary>
        public bvec4 rgrr => new bvec4(x, y, x, x);
        
        /// <summary>
        /// Returns bvec2.rgrg swizzling.
        /// </summary>
        public bvec4 rgrg => new bvec4(x, y, x, y);
        
        /// <summary>
        /// Returns bvec2.rgg swizzling.
        /// </summary>
        public bvec3 rgg => new bvec3(x, y, y);
        
        /// <summary>
        /// Returns bvec2.rggr swizzling.
        /// </summary>
        public bvec4 rggr => new bvec4(x, y, y, x);
        
        /// <summary>
        /// Returns bvec2.rggg swizzling.
        /// </summary>
        public bvec4 rggg => new bvec4(x, y, y, y);
        
        /// <summary>
        /// Returns bvec2.gr swizzling.
        /// </summary>
        public bvec2 gr => new bvec2(y, x);
        
        /// <summary>
        /// Returns bvec2.grr swizzling.
        /// </summary>
        public bvec3 grr => new bvec3(y, x, x);
        
        /// <summary>
        /// Returns bvec2.grrr swizzling.
        /// </summary>
        public bvec4 grrr => new bvec4(y, x, x, x);
        
        /// <summary>
        /// Returns bvec2.grrg swizzling.
        /// </summary>
        public bvec4 grrg => new bvec4(y, x, x, y);
        
        /// <summary>
        /// Returns bvec2.grg swizzling.
        /// </summary>
        public bvec3 grg => new bvec3(y, x, y);
        
        /// <summary>
        /// Returns bvec2.grgr swizzling.
        /// </summary>
        public bvec4 grgr => new bvec4(y, x, y, x);
        
        /// <summary>
        /// Returns bvec2.grgg swizzling.
        /// </summary>
        public bvec4 grgg => new bvec4(y, x, y, y);
        
        /// <summary>
        /// Returns bvec2.gg swizzling.
        /// </summary>
        public bvec2 gg => new bvec2(y, y);
        
        /// <summary>
        /// Returns bvec2.ggr swizzling.
        /// </summary>
        public bvec3 ggr => new bvec3(y, y, x);
        
        /// <summary>
        /// Returns bvec2.ggrr swizzling.
        /// </summary>
        public bvec4 ggrr => new bvec4(y, y, x, x);
        
        /// <summary>
        /// Returns bvec2.ggrg swizzling.
        /// </summary>
        public bvec4 ggrg => new bvec4(y, y, x, y);
        
        /// <summary>
        /// Returns bvec2.ggg swizzling.
        /// </summary>
        public bvec3 ggg => new bvec3(y, y, y);
        
        /// <summary>
        /// Returns bvec2.gggr swizzling.
        /// </summary>
        public bvec4 gggr => new bvec4(y, y, y, x);
        
        /// <summary>
        /// Returns bvec2.gggg swizzling.
        /// </summary>
        public bvec4 gggg => new bvec4(y, y, y, y);
    }
}
