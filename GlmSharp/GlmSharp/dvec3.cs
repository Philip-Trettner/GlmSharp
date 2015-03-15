using System;
using System.Collections.Generic;
using System.Linq;
namespace GlmSharp
{
    [Serializable]
    public struct dvec3
    {
        public double x;
        public double y;
        public double z;
        
        public swizzle_dvec3 swizzle => new swizzle_dvec3(x, y, z);
        
        public dvec3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
    }
}
