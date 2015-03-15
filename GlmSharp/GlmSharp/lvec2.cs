using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct lvec2 : IReadOnlyList<long>
    {
        public long x;
        public long y;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_lvec2 swizzle => new swizzle_lvec2(x, y);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public long[] Values => new[] { x, y };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public lvec2(long x, long y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public lvec2(long v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public lvec2(lvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public lvec2(lvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public lvec2(lvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<long> GetEnumerator()
        {
            yield return x;
            yield return y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public long this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: this.x = value; break;
                    case 1: this.y = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }
    }
}
