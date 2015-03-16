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
    /// Temporary vector of type uint with 2 components, used for implementing swizzling for uvec2.
    /// </summary>
    [Serializable]
    public struct swizzle_uvec2
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        internal readonly uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        internal readonly uint y;
        
        
        /// <summary>
        /// Constructor for swizzle_uvec2.
        /// </summary>
        internal swizzle_uvec2(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }
        
        // XYZW Versions
        
        /// <summary>
        /// Returns uvec2.xx swizzling.
        /// </summary>
        public uvec2 xx => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec2.xxx swizzling.
        /// </summary>
        public uvec3 xxx => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec2.xxxx swizzling.
        /// </summary>
        public uvec4 xxxx => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec2.xxxy swizzling.
        /// </summary>
        public uvec4 xxxy => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec2.xxy swizzling.
        /// </summary>
        public uvec3 xxy => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec2.xxyx swizzling.
        /// </summary>
        public uvec4 xxyx => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec2.xxyy swizzling.
        /// </summary>
        public uvec4 xxyy => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec2.xy swizzling.
        /// </summary>
        public uvec2 xy => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec2.xyx swizzling.
        /// </summary>
        public uvec3 xyx => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec2.xyxx swizzling.
        /// </summary>
        public uvec4 xyxx => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec2.xyxy swizzling.
        /// </summary>
        public uvec4 xyxy => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec2.xyy swizzling.
        /// </summary>
        public uvec3 xyy => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec2.xyyx swizzling.
        /// </summary>
        public uvec4 xyyx => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec2.xyyy swizzling.
        /// </summary>
        public uvec4 xyyy => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec2.yx swizzling.
        /// </summary>
        public uvec2 yx => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec2.yxx swizzling.
        /// </summary>
        public uvec3 yxx => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec2.yxxx swizzling.
        /// </summary>
        public uvec4 yxxx => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec2.yxxy swizzling.
        /// </summary>
        public uvec4 yxxy => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec2.yxy swizzling.
        /// </summary>
        public uvec3 yxy => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec2.yxyx swizzling.
        /// </summary>
        public uvec4 yxyx => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec2.yxyy swizzling.
        /// </summary>
        public uvec4 yxyy => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec2.yy swizzling.
        /// </summary>
        public uvec2 yy => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec2.yyx swizzling.
        /// </summary>
        public uvec3 yyx => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec2.yyxx swizzling.
        /// </summary>
        public uvec4 yyxx => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec2.yyxy swizzling.
        /// </summary>
        public uvec4 yyxy => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec2.yyy swizzling.
        /// </summary>
        public uvec3 yyy => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec2.yyyx swizzling.
        /// </summary>
        public uvec4 yyyx => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec2.yyyy swizzling.
        /// </summary>
        public uvec4 yyyy => new uvec4(y, y, y, y);
        
        // RGBA Versions
        
        /// <summary>
        /// Returns uvec2.rr swizzling.
        /// </summary>
        public uvec2 rr => new uvec2(x, x);
        
        /// <summary>
        /// Returns uvec2.rrr swizzling.
        /// </summary>
        public uvec3 rrr => new uvec3(x, x, x);
        
        /// <summary>
        /// Returns uvec2.rrrr swizzling.
        /// </summary>
        public uvec4 rrrr => new uvec4(x, x, x, x);
        
        /// <summary>
        /// Returns uvec2.rrrg swizzling.
        /// </summary>
        public uvec4 rrrg => new uvec4(x, x, x, y);
        
        /// <summary>
        /// Returns uvec2.rrg swizzling.
        /// </summary>
        public uvec3 rrg => new uvec3(x, x, y);
        
        /// <summary>
        /// Returns uvec2.rrgr swizzling.
        /// </summary>
        public uvec4 rrgr => new uvec4(x, x, y, x);
        
        /// <summary>
        /// Returns uvec2.rrgg swizzling.
        /// </summary>
        public uvec4 rrgg => new uvec4(x, x, y, y);
        
        /// <summary>
        /// Returns uvec2.rg swizzling.
        /// </summary>
        public uvec2 rg => new uvec2(x, y);
        
        /// <summary>
        /// Returns uvec2.rgr swizzling.
        /// </summary>
        public uvec3 rgr => new uvec3(x, y, x);
        
        /// <summary>
        /// Returns uvec2.rgrr swizzling.
        /// </summary>
        public uvec4 rgrr => new uvec4(x, y, x, x);
        
        /// <summary>
        /// Returns uvec2.rgrg swizzling.
        /// </summary>
        public uvec4 rgrg => new uvec4(x, y, x, y);
        
        /// <summary>
        /// Returns uvec2.rgg swizzling.
        /// </summary>
        public uvec3 rgg => new uvec3(x, y, y);
        
        /// <summary>
        /// Returns uvec2.rggr swizzling.
        /// </summary>
        public uvec4 rggr => new uvec4(x, y, y, x);
        
        /// <summary>
        /// Returns uvec2.rggg swizzling.
        /// </summary>
        public uvec4 rggg => new uvec4(x, y, y, y);
        
        /// <summary>
        /// Returns uvec2.gr swizzling.
        /// </summary>
        public uvec2 gr => new uvec2(y, x);
        
        /// <summary>
        /// Returns uvec2.grr swizzling.
        /// </summary>
        public uvec3 grr => new uvec3(y, x, x);
        
        /// <summary>
        /// Returns uvec2.grrr swizzling.
        /// </summary>
        public uvec4 grrr => new uvec4(y, x, x, x);
        
        /// <summary>
        /// Returns uvec2.grrg swizzling.
        /// </summary>
        public uvec4 grrg => new uvec4(y, x, x, y);
        
        /// <summary>
        /// Returns uvec2.grg swizzling.
        /// </summary>
        public uvec3 grg => new uvec3(y, x, y);
        
        /// <summary>
        /// Returns uvec2.grgr swizzling.
        /// </summary>
        public uvec4 grgr => new uvec4(y, x, y, x);
        
        /// <summary>
        /// Returns uvec2.grgg swizzling.
        /// </summary>
        public uvec4 grgg => new uvec4(y, x, y, y);
        
        /// <summary>
        /// Returns uvec2.gg swizzling.
        /// </summary>
        public uvec2 gg => new uvec2(y, y);
        
        /// <summary>
        /// Returns uvec2.ggr swizzling.
        /// </summary>
        public uvec3 ggr => new uvec3(y, y, x);
        
        /// <summary>
        /// Returns uvec2.ggrr swizzling.
        /// </summary>
        public uvec4 ggrr => new uvec4(y, y, x, x);
        
        /// <summary>
        /// Returns uvec2.ggrg swizzling.
        /// </summary>
        public uvec4 ggrg => new uvec4(y, y, x, y);
        
        /// <summary>
        /// Returns uvec2.ggg swizzling.
        /// </summary>
        public uvec3 ggg => new uvec3(y, y, y);
        
        /// <summary>
        /// Returns uvec2.gggr swizzling.
        /// </summary>
        public uvec4 gggr => new uvec4(y, y, y, x);
        
        /// <summary>
        /// Returns uvec2.gggg swizzling.
        /// </summary>
        public uvec4 gggg => new uvec4(y, y, y, y);
    }
}
