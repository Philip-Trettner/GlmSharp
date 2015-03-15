using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct vec4 : IReadOnlyList<float>, IEquatable<vec4>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        public float z;
        
        /// <summary>
        /// w-component
        /// </summary>
        public float w;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_vec4 swizzle => new swizzle_vec4(x, y, z, w);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec4 Zero = new vec4(default(float), default(float), default(float), default(float));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec4 Ones = new vec4(1f, 1f, 1f, 1f);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec4 UnitX = new vec4(1f, default(float), default(float), default(float));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec4 UnitY = new vec4(default(float), 1f, default(float), default(float));
        
        /// <summary>
        /// Predefined unit-Z vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec4 UnitZ = new vec4(default(float), default(float), 1f, default(float));
        
        /// <summary>
        /// Predefined unit-W vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec4 UnitW = new vec4(default(float), default(float), default(float), 1f);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public float[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public vec4(float x, float y, float z, float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public vec4(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public vec4(vec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(float);
            this.w = default(float);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public vec4(vec2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = default(float);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public vec4(vec2 v, float z, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public vec4(vec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = default(float);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public vec4(vec3 v, float w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public vec4(vec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(vec4 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(vec4 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(vec4 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(vec4 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(vec4 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(vec4 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(vec4 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(vec4 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(vec4 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(vec4 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(vec4 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(vec4 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(vec4 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(vec4 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(vec4 v) => new bvec2(v.x == default(float) ? false : true, v.y == default(float) ? false : true);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(vec4 v) => new bvec3(v.x == default(float) ? false : true, v.y == default(float) ? false : true, v.z == default(float) ? false : true);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(vec4 v) => new bvec4(v.x == default(float) ? false : true, v.y == default(float) ? false : true, v.z == default(float) ? false : true, v.w == default(float) ? false : true);
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<float> GetEnumerator()
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
        public float this[int index]
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
        public bool Equals(vec4 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z) && w.Equals(rhs.w);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is vec4 && Equals((vec4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(vec4 lhs, vec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(vec4 lhs, vec4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((x.GetHashCode()) * 397) ^ y.GetHashCode()) * 397) ^ z.GetHashCode()) * 397) ^ w.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public float MinElement => Math.Min(Math.Min(Math.Min(x, y), z), w);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public float MaxElement => Math.Max(Math.Max(Math.Max(x, y), z), w);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public float Length => (float)Math.Sqrt(x*x + y*y + z*z + w*w);
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => x*x + y*y + z*z + w*w;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt(x*x + y*y + z*z + w*w);
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => Math.Abs(x) + Math.Abs(y) + Math.Abs(z) + Math.Abs(w);
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt(x*x + y*y + z*z + w*w);
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => Math.Max(Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z)), Math.Abs(w));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow(Math.Abs(x), p) + Math.Pow(Math.Abs(y), p) + Math.Pow(Math.Abs(z), p) + Math.Pow(Math.Abs(w), p), 1 / p);
    }
}
