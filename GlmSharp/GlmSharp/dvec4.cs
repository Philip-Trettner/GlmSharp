using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct dvec4
    {
        public double x;
        public double y;
        public double z;
        public double w;
        
        public swizzle_dvec4 swizzle => new swizzle_dvec4(x, y, z, w);
        
        public dvec4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
    }
}
