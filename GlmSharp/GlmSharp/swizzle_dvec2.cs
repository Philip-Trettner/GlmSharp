using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp.Swizzle
{
    
    /// <summary>
    /// Temporary vector of type double with 2 components, used for implementing swizzling for dvec2.
    /// </summary>
    [Serializable]
    public struct swizzle_dvec2
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly double y;
        
        
        /// <summary>
        /// Constructor for swizzle_dvec2.
        /// </summary>
        internal swizzle_dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns dvec2.xx swizzling.
        /// </summary>
        public dvec2 xx => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec2.xxx swizzling.
        /// </summary>
        public dvec3 xxx => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec2.xxxx swizzling.
        /// </summary>
        public dvec4 xxxx => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec2.xxxy swizzling.
        /// </summary>
        public dvec4 xxxy => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec2.xxy swizzling.
        /// </summary>
        public dvec3 xxy => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec2.xxyx swizzling.
        /// </summary>
        public dvec4 xxyx => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec2.xxyy swizzling.
        /// </summary>
        public dvec4 xxyy => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec2.xy swizzling.
        /// </summary>
        public dvec2 xy => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec2.xyx swizzling.
        /// </summary>
        public dvec3 xyx => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec2.xyxx swizzling.
        /// </summary>
        public dvec4 xyxx => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec2.xyxy swizzling.
        /// </summary>
        public dvec4 xyxy => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec2.xyy swizzling.
        /// </summary>
        public dvec3 xyy => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec2.xyyx swizzling.
        /// </summary>
        public dvec4 xyyx => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec2.xyyy swizzling.
        /// </summary>
        public dvec4 xyyy => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec2.yx swizzling.
        /// </summary>
        public dvec2 yx => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec2.yxx swizzling.
        /// </summary>
        public dvec3 yxx => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec2.yxxx swizzling.
        /// </summary>
        public dvec4 yxxx => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec2.yxxy swizzling.
        /// </summary>
        public dvec4 yxxy => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec2.yxy swizzling.
        /// </summary>
        public dvec3 yxy => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec2.yxyx swizzling.
        /// </summary>
        public dvec4 yxyx => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec2.yxyy swizzling.
        /// </summary>
        public dvec4 yxyy => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec2.yy swizzling.
        /// </summary>
        public dvec2 yy => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec2.yyx swizzling.
        /// </summary>
        public dvec3 yyx => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec2.yyxx swizzling.
        /// </summary>
        public dvec4 yyxx => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec2.yyxy swizzling.
        /// </summary>
        public dvec4 yyxy => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec2.yyy swizzling.
        /// </summary>
        public dvec3 yyy => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec2.yyyx swizzling.
        /// </summary>
        public dvec4 yyyx => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec2.yyyy swizzling.
        /// </summary>
        public dvec4 yyyy => new dvec4(y, y, y, y);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns dvec2.rr swizzling.
        /// </summary>
        public dvec2 rr => new dvec2(x, x);
        
        /// <summary>
        /// Returns dvec2.rrr swizzling.
        /// </summary>
        public dvec3 rrr => new dvec3(x, x, x);
        
        /// <summary>
        /// Returns dvec2.rrrr swizzling.
        /// </summary>
        public dvec4 rrrr => new dvec4(x, x, x, x);
        
        /// <summary>
        /// Returns dvec2.rrrg swizzling.
        /// </summary>
        public dvec4 rrrg => new dvec4(x, x, x, y);
        
        /// <summary>
        /// Returns dvec2.rrg swizzling.
        /// </summary>
        public dvec3 rrg => new dvec3(x, x, y);
        
        /// <summary>
        /// Returns dvec2.rrgr swizzling.
        /// </summary>
        public dvec4 rrgr => new dvec4(x, x, y, x);
        
        /// <summary>
        /// Returns dvec2.rrgg swizzling.
        /// </summary>
        public dvec4 rrgg => new dvec4(x, x, y, y);
        
        /// <summary>
        /// Returns dvec2.rg swizzling.
        /// </summary>
        public dvec2 rg => new dvec2(x, y);
        
        /// <summary>
        /// Returns dvec2.rgr swizzling.
        /// </summary>
        public dvec3 rgr => new dvec3(x, y, x);
        
        /// <summary>
        /// Returns dvec2.rgrr swizzling.
        /// </summary>
        public dvec4 rgrr => new dvec4(x, y, x, x);
        
        /// <summary>
        /// Returns dvec2.rgrg swizzling.
        /// </summary>
        public dvec4 rgrg => new dvec4(x, y, x, y);
        
        /// <summary>
        /// Returns dvec2.rgg swizzling.
        /// </summary>
        public dvec3 rgg => new dvec3(x, y, y);
        
        /// <summary>
        /// Returns dvec2.rggr swizzling.
        /// </summary>
        public dvec4 rggr => new dvec4(x, y, y, x);
        
        /// <summary>
        /// Returns dvec2.rggg swizzling.
        /// </summary>
        public dvec4 rggg => new dvec4(x, y, y, y);
        
        /// <summary>
        /// Returns dvec2.gr swizzling.
        /// </summary>
        public dvec2 gr => new dvec2(y, x);
        
        /// <summary>
        /// Returns dvec2.grr swizzling.
        /// </summary>
        public dvec3 grr => new dvec3(y, x, x);
        
        /// <summary>
        /// Returns dvec2.grrr swizzling.
        /// </summary>
        public dvec4 grrr => new dvec4(y, x, x, x);
        
        /// <summary>
        /// Returns dvec2.grrg swizzling.
        /// </summary>
        public dvec4 grrg => new dvec4(y, x, x, y);
        
        /// <summary>
        /// Returns dvec2.grg swizzling.
        /// </summary>
        public dvec3 grg => new dvec3(y, x, y);
        
        /// <summary>
        /// Returns dvec2.grgr swizzling.
        /// </summary>
        public dvec4 grgr => new dvec4(y, x, y, x);
        
        /// <summary>
        /// Returns dvec2.grgg swizzling.
        /// </summary>
        public dvec4 grgg => new dvec4(y, x, y, y);
        
        /// <summary>
        /// Returns dvec2.gg swizzling.
        /// </summary>
        public dvec2 gg => new dvec2(y, y);
        
        /// <summary>
        /// Returns dvec2.ggr swizzling.
        /// </summary>
        public dvec3 ggr => new dvec3(y, y, x);
        
        /// <summary>
        /// Returns dvec2.ggrr swizzling.
        /// </summary>
        public dvec4 ggrr => new dvec4(y, y, x, x);
        
        /// <summary>
        /// Returns dvec2.ggrg swizzling.
        /// </summary>
        public dvec4 ggrg => new dvec4(y, y, x, y);
        
        /// <summary>
        /// Returns dvec2.ggg swizzling.
        /// </summary>
        public dvec3 ggg => new dvec3(y, y, y);
        
        /// <summary>
        /// Returns dvec2.gggr swizzling.
        /// </summary>
        public dvec4 gggr => new dvec4(y, y, y, x);
        
        /// <summary>
        /// Returns dvec2.gggg swizzling.
        /// </summary>
        public dvec4 gggg => new dvec4(y, y, y, y);
    }
}
