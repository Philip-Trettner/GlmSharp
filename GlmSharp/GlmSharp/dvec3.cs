using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct dvec3 : IReadOnlyList<double>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public double y;
        
        /// <summary>
        /// z-component
        /// </summary>
        public double z;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_dvec3 swizzle => new swizzle_dvec3(x, y, z);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public double[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public dvec3(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public dvec3(double v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec3(dvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(double);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public dvec3(dvec2 v, double z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec3(dvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec3(dvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public double this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                    case 2: this.z = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }
    }
}
