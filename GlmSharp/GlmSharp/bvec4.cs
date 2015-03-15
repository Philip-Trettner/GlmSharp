using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct bvec4 : IReadOnlyList<bool>, IEquatable<bvec4>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public bool x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public bool y;
        
        /// <summary>
        /// z-component
        /// </summary>
        public bool z;
        
        /// <summary>
        /// w-component
        /// </summary>
        public bool w;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_bvec4 swizzle => new swizzle_bvec4(x, y, z, w);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly bvec4 Zero = new bvec4(default(bool), default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly bvec4 Ones = new bvec4(true, true, true, true);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly bvec4 UnitX = new bvec4(true, default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly bvec4 UnitY = new bvec4(default(bool), true, default(bool), default(bool));
        
        /// <summary>
        /// Predefined unit-Z vector (DO NOT MODIFY)
        /// </summary>
        public static readonly bvec4 UnitZ = new bvec4(default(bool), default(bool), true, default(bool));
        
        /// <summary>
        /// Predefined unit-W vector (DO NOT MODIFY)
        /// </summary>
        public static readonly bvec4 UnitW = new bvec4(default(bool), default(bool), default(bool), true);
        
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
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(bvec4 v) => new ivec2(v.x ? 1 : default(int), v.y ? 1 : default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(bvec4 v) => new ivec3(v.x ? 1 : default(int), v.y ? 1 : default(int), v.z ? 1 : default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(bvec4 v) => new ivec4(v.x ? 1 : default(int), v.y ? 1 : default(int), v.z ? 1 : default(int), v.w ? 1 : default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(bvec4 v) => new uvec2(v.x ? 1 : default(uint), v.y ? 1 : default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(bvec4 v) => new uvec3(v.x ? 1 : default(uint), v.y ? 1 : default(uint), v.z ? 1 : default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(bvec4 v) => new uvec4(v.x ? 1 : default(uint), v.y ? 1 : default(uint), v.z ? 1 : default(uint), v.w ? 1 : default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(bvec4 v) => new vec2(v.x ? 1f : default(float), v.y ? 1f : default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(bvec4 v) => new vec3(v.x ? 1f : default(float), v.y ? 1f : default(float), v.z ? 1f : default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(bvec4 v) => new vec4(v.x ? 1f : default(float), v.y ? 1f : default(float), v.z ? 1f : default(float), v.w ? 1f : default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(bvec4 v) => new dvec2(v.x ? 1.0 : default(double), v.y ? 1.0 : default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(bvec4 v) => new dvec3(v.x ? 1.0 : default(double), v.y ? 1.0 : default(double), v.z ? 1.0 : default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(bvec4 v) => new dvec4(v.x ? 1.0 : default(double), v.y ? 1.0 : default(double), v.z ? 1.0 : default(double), v.w ? 1.0 : default(double));
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(bvec4 v) => new lvec2(v.x ? 1 : default(long), v.y ? 1 : default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(bvec4 v) => new lvec3(v.x ? 1 : default(long), v.y ? 1 : default(long), v.z ? 1 : default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(bvec4 v) => new lvec4(v.x ? 1 : default(long), v.y ? 1 : default(long), v.z ? 1 : default(long), v.w ? 1 : default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(bvec4 v) => new bvec2((bool)v.x, (bool)v.y);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(bvec4 v) => new bvec3((bool)v.x, (bool)v.y, (bool)v.z);
        
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
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bvec4 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z) && w.Equals(rhs.w);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bvec4 && Equals((bvec4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bvec4 lhs, bvec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bvec4 lhs, bvec4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((x.GetHashCode()) * 2) ^ y.GetHashCode()) * 2) ^ z.GetHashCode()) * 2) ^ w.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public bool MinElement => x && y && z && w;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public bool MaxElement => x || y || z || w;
    }
}
