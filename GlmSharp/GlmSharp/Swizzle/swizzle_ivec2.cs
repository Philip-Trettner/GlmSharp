using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp.Swizzle
{
    
    /// <summary>
    /// Temporary vector of type int with 2 components, used for implementing swizzling for ivec2.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "swizzle")]
    [StructLayout(LayoutKind.Sequential)]
    public struct swizzle_ivec2
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        internal readonly int x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        internal readonly int y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Constructor for swizzle_ivec2.
        /// </summary>
        internal swizzle_ivec2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns ivec2.xx swizzling.
        /// </summary>
        public ivec2 xx => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec2.rr swizzling (equivalent to ivec2.xx).
        /// </summary>
        public ivec2 rr => new ivec2(x, x);
        
        /// <summary>
        /// Returns ivec2.xxx swizzling.
        /// </summary>
        public ivec3 xxx => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec2.rrr swizzling (equivalent to ivec2.xxx).
        /// </summary>
        public ivec3 rrr => new ivec3(x, x, x);
        
        /// <summary>
        /// Returns ivec2.xxxx swizzling.
        /// </summary>
        public ivec4 xxxx => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec2.rrrr swizzling (equivalent to ivec2.xxxx).
        /// </summary>
        public ivec4 rrrr => new ivec4(x, x, x, x);
        
        /// <summary>
        /// Returns ivec2.xxxy swizzling.
        /// </summary>
        public ivec4 xxxy => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec2.rrrg swizzling (equivalent to ivec2.xxxy).
        /// </summary>
        public ivec4 rrrg => new ivec4(x, x, x, y);
        
        /// <summary>
        /// Returns ivec2.xxy swizzling.
        /// </summary>
        public ivec3 xxy => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec2.rrg swizzling (equivalent to ivec2.xxy).
        /// </summary>
        public ivec3 rrg => new ivec3(x, x, y);
        
        /// <summary>
        /// Returns ivec2.xxyx swizzling.
        /// </summary>
        public ivec4 xxyx => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec2.rrgr swizzling (equivalent to ivec2.xxyx).
        /// </summary>
        public ivec4 rrgr => new ivec4(x, x, y, x);
        
        /// <summary>
        /// Returns ivec2.xxyy swizzling.
        /// </summary>
        public ivec4 xxyy => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec2.rrgg swizzling (equivalent to ivec2.xxyy).
        /// </summary>
        public ivec4 rrgg => new ivec4(x, x, y, y);
        
        /// <summary>
        /// Returns ivec2.xy swizzling.
        /// </summary>
        public ivec2 xy => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec2.rg swizzling (equivalent to ivec2.xy).
        /// </summary>
        public ivec2 rg => new ivec2(x, y);
        
        /// <summary>
        /// Returns ivec2.xyx swizzling.
        /// </summary>
        public ivec3 xyx => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec2.rgr swizzling (equivalent to ivec2.xyx).
        /// </summary>
        public ivec3 rgr => new ivec3(x, y, x);
        
        /// <summary>
        /// Returns ivec2.xyxx swizzling.
        /// </summary>
        public ivec4 xyxx => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec2.rgrr swizzling (equivalent to ivec2.xyxx).
        /// </summary>
        public ivec4 rgrr => new ivec4(x, y, x, x);
        
        /// <summary>
        /// Returns ivec2.xyxy swizzling.
        /// </summary>
        public ivec4 xyxy => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec2.rgrg swizzling (equivalent to ivec2.xyxy).
        /// </summary>
        public ivec4 rgrg => new ivec4(x, y, x, y);
        
        /// <summary>
        /// Returns ivec2.xyy swizzling.
        /// </summary>
        public ivec3 xyy => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec2.rgg swizzling (equivalent to ivec2.xyy).
        /// </summary>
        public ivec3 rgg => new ivec3(x, y, y);
        
        /// <summary>
        /// Returns ivec2.xyyx swizzling.
        /// </summary>
        public ivec4 xyyx => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec2.rggr swizzling (equivalent to ivec2.xyyx).
        /// </summary>
        public ivec4 rggr => new ivec4(x, y, y, x);
        
        /// <summary>
        /// Returns ivec2.xyyy swizzling.
        /// </summary>
        public ivec4 xyyy => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec2.rggg swizzling (equivalent to ivec2.xyyy).
        /// </summary>
        public ivec4 rggg => new ivec4(x, y, y, y);
        
        /// <summary>
        /// Returns ivec2.yx swizzling.
        /// </summary>
        public ivec2 yx => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec2.gr swizzling (equivalent to ivec2.yx).
        /// </summary>
        public ivec2 gr => new ivec2(y, x);
        
        /// <summary>
        /// Returns ivec2.yxx swizzling.
        /// </summary>
        public ivec3 yxx => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec2.grr swizzling (equivalent to ivec2.yxx).
        /// </summary>
        public ivec3 grr => new ivec3(y, x, x);
        
        /// <summary>
        /// Returns ivec2.yxxx swizzling.
        /// </summary>
        public ivec4 yxxx => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec2.grrr swizzling (equivalent to ivec2.yxxx).
        /// </summary>
        public ivec4 grrr => new ivec4(y, x, x, x);
        
        /// <summary>
        /// Returns ivec2.yxxy swizzling.
        /// </summary>
        public ivec4 yxxy => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec2.grrg swizzling (equivalent to ivec2.yxxy).
        /// </summary>
        public ivec4 grrg => new ivec4(y, x, x, y);
        
        /// <summary>
        /// Returns ivec2.yxy swizzling.
        /// </summary>
        public ivec3 yxy => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec2.grg swizzling (equivalent to ivec2.yxy).
        /// </summary>
        public ivec3 grg => new ivec3(y, x, y);
        
        /// <summary>
        /// Returns ivec2.yxyx swizzling.
        /// </summary>
        public ivec4 yxyx => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec2.grgr swizzling (equivalent to ivec2.yxyx).
        /// </summary>
        public ivec4 grgr => new ivec4(y, x, y, x);
        
        /// <summary>
        /// Returns ivec2.yxyy swizzling.
        /// </summary>
        public ivec4 yxyy => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec2.grgg swizzling (equivalent to ivec2.yxyy).
        /// </summary>
        public ivec4 grgg => new ivec4(y, x, y, y);
        
        /// <summary>
        /// Returns ivec2.yy swizzling.
        /// </summary>
        public ivec2 yy => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec2.gg swizzling (equivalent to ivec2.yy).
        /// </summary>
        public ivec2 gg => new ivec2(y, y);
        
        /// <summary>
        /// Returns ivec2.yyx swizzling.
        /// </summary>
        public ivec3 yyx => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec2.ggr swizzling (equivalent to ivec2.yyx).
        /// </summary>
        public ivec3 ggr => new ivec3(y, y, x);
        
        /// <summary>
        /// Returns ivec2.yyxx swizzling.
        /// </summary>
        public ivec4 yyxx => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec2.ggrr swizzling (equivalent to ivec2.yyxx).
        /// </summary>
        public ivec4 ggrr => new ivec4(y, y, x, x);
        
        /// <summary>
        /// Returns ivec2.yyxy swizzling.
        /// </summary>
        public ivec4 yyxy => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec2.ggrg swizzling (equivalent to ivec2.yyxy).
        /// </summary>
        public ivec4 ggrg => new ivec4(y, y, x, y);
        
        /// <summary>
        /// Returns ivec2.yyy swizzling.
        /// </summary>
        public ivec3 yyy => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec2.ggg swizzling (equivalent to ivec2.yyy).
        /// </summary>
        public ivec3 ggg => new ivec3(y, y, y);
        
        /// <summary>
        /// Returns ivec2.yyyx swizzling.
        /// </summary>
        public ivec4 yyyx => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec2.gggr swizzling (equivalent to ivec2.yyyx).
        /// </summary>
        public ivec4 gggr => new ivec4(y, y, y, x);
        
        /// <summary>
        /// Returns ivec2.yyyy swizzling.
        /// </summary>
        public ivec4 yyyy => new ivec4(y, y, y, y);
        
        /// <summary>
        /// Returns ivec2.gggg swizzling (equivalent to ivec2.yyyy).
        /// </summary>
        public ivec4 gggg => new ivec4(y, y, y, y);

        #endregion

    }
}
