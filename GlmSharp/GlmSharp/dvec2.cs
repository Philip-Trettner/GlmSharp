using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct dvec2
    {
        public double x;
        public double y;
        
        public swizzle_dvec2 swizzle => new swizzle_dvec2(x, y);
        
        public dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
    }
}
