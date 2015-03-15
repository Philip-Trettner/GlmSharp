using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct bvec4 : IReadOnlyList<bool>
    {
        public bool x;
        public bool y;
        public bool z;
        public bool w;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_bvec4 swizzle => new swizzle_bvec4(x, y, z, w);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public bool[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bvec4(bool x, bool y, bool z, bool w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public bvec4(bool v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(bool);
            this.w = default(bool);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec2 v, bool z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = default(bool);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec2 v, bool z, bool w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = default(bool);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec3 v, bool w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public bvec4(bvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
            yield return w;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
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
                    case 3: this.w = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }
    }
}
