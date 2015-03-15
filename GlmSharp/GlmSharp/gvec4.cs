using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct gvec4<T> : IReadOnlyList<T>
    {
        public T x;
        public T y;
        public T z;
        public T w;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_gvec4<T> swizzle => new swizzle_gvec4<T>(x, y, z, w);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public T[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gvec4(T x, T y, T z, T w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public gvec4(T v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public gvec4(gvec2<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(T);
            this.w = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public gvec4(gvec2<T> v, T z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public gvec4(gvec2<T> v, T z, T w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public gvec4(gvec3<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = default(T);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public gvec4(gvec3<T> v, T w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public gvec4(gvec4<T> v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
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
        public T this[int index]
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
