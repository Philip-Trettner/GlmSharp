using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct swizzle_dvec2
    {
        public readonly double x;
        public readonly double y;
        
        public swizzle_dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        public dvec2 xx => new dvec2(x, x);
        public dvec2 xy => new dvec2(x, y);
        public dvec2 yx => new dvec2(y, x);
        public dvec2 yy => new dvec2(y, y);
    }
}
