using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct uvec2 : IReadOnlyList<uint>, IEquatable<uvec2>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public uint y;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_uvec2 swizzle => new swizzle_uvec2(x, y);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly uvec2 Zero = new uvec2(default(uint), default(uint));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly uvec2 Ones = new uvec2(1, 1);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly uvec2 UnitX = new uvec2(1, default(uint));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly uvec2 UnitY = new uvec2(default(uint), 1);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public uint[] Values => new[] { x, y };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public uvec2(uint x, uint y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public uvec2(uint v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public uvec2(uvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public uvec2(uvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public uvec2(uvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(uvec2 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec3(uvec2 v) => new ivec3((int)v.x, (int)v.y, default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(uvec2 v) => new ivec4((int)v.x, (int)v.y, default(int), default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec3(uvec2 v) => new uvec3((uint)v.x, (uint)v.y, default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(uvec2 v) => new uvec4((uint)v.x, (uint)v.y, default(uint), default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(uvec2 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec3(uvec2 v) => new vec3((float)v.x, (float)v.y, default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(uvec2 v) => new vec4((float)v.x, (float)v.y, default(float), default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(uvec2 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec3(uvec2 v) => new dvec3((double)v.x, (double)v.y, default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(uvec2 v) => new dvec4((double)v.x, (double)v.y, default(double), default(double));
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(uvec2 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec3(uvec2 v) => new lvec3((long)v.x, (long)v.y, default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(uvec2 v) => new lvec4((long)v.x, (long)v.y, default(long), default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(uvec2 v) => new bvec2(v.x != default(uint), v.y != default(uint));
        
        /// <summary>
        /// Explicitly converts this to a bvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec3(uvec2 v) => new bvec3(v.x != default(uint), v.y != default(uint), default(bool));
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(uvec2 v) => new bvec4(v.x != default(uint), v.y != default(uint), default(bool), default(bool));
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<uint> GetEnumerator()
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
        public uint this[int index]
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
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(uvec2 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is uvec2 && Equals((uvec2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(uvec2 lhs, uvec2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(uvec2 lhs, uvec2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((x.GetHashCode()) * 397) ^ y.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public uint MinElement => Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public uint MaxElement => Math.Max(x, y);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public float Length => (float)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => x*x + y*y;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public float Sum => x + y;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => x + y;
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public uint NormMax => Math.Max(x, y);
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow(x, p) + Math.Pow(y, p), 1 / p);
        
        /// <summary>
        /// Executed a component-wise + (add).
        /// </summary>
        public static uvec2 operator+(uvec2 lhs, uvec2 rhs) => new uvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Executed a component-wise + (add) with a scalar.
        /// </summary>
        public static uvec2 operator+(uvec2 lhs, uint rhs) => new uvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Executed a component-wise + (add) with a scalar.
        /// </summary>
        public static uvec2 operator+(uint lhs, uvec2 rhs) => new uvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Executed a component-wise - (subtract).
        /// </summary>
        public static uvec2 operator-(uvec2 lhs, uvec2 rhs) => new uvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Executed a component-wise - (subtract) with a scalar.
        /// </summary>
        public static uvec2 operator-(uvec2 lhs, uint rhs) => new uvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Executed a component-wise - (subtract) with a scalar.
        /// </summary>
        public static uvec2 operator-(uint lhs, uvec2 rhs) => new uvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Executed a component-wise / (divide).
        /// </summary>
        public static uvec2 operator/(uvec2 lhs, uvec2 rhs) => new uvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Executed a component-wise / (divide) with a scalar.
        /// </summary>
        public static uvec2 operator/(uvec2 lhs, uint rhs) => new uvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Executed a component-wise / (divide) with a scalar.
        /// </summary>
        public static uvec2 operator/(uint lhs, uvec2 rhs) => new uvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Executed a component-wise * (multiply).
        /// </summary>
        public static uvec2 operator*(uvec2 lhs, uvec2 rhs) => new uvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Executed a component-wise * (multiply) with a scalar.
        /// </summary>
        public static uvec2 operator*(uvec2 lhs, uint rhs) => new uvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Executed a component-wise * (multiply) with a scalar.
        /// </summary>
        public static uvec2 operator*(uint lhs, uvec2 rhs) => new uvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Executed a component-wise % (mod).
        /// </summary>
        public static uvec2 operator%(uvec2 lhs, uvec2 rhs) => new uvec2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Executed a component-wise % (mod) with a scalar.
        /// </summary>
        public static uvec2 operator%(uvec2 lhs, uint rhs) => new uvec2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Executed a component-wise % (mod) with a scalar.
        /// </summary>
        public static uvec2 operator%(uint lhs, uvec2 rhs) => new uvec2(lhs % rhs.x, lhs % rhs.y);
        
        /// <summary>
        /// Executed a component-wise ^ (xor).
        /// </summary>
        public static uvec2 operator^(uvec2 lhs, uvec2 rhs) => new uvec2(lhs.x ^ rhs.x, lhs.y ^ rhs.y);
        
        /// <summary>
        /// Executed a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static uvec2 operator^(uvec2 lhs, uint rhs) => new uvec2(lhs.x ^ rhs, lhs.y ^ rhs);
        
        /// <summary>
        /// Executed a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static uvec2 operator^(uint lhs, uvec2 rhs) => new uvec2(lhs ^ rhs.x, lhs ^ rhs.y);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or).
        /// </summary>
        public static uvec2 operator|(uvec2 lhs, uvec2 rhs) => new uvec2(lhs.x | rhs.x, lhs.y | rhs.y);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static uvec2 operator|(uvec2 lhs, uint rhs) => new uvec2(lhs.x | rhs, lhs.y | rhs);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static uvec2 operator|(uint lhs, uvec2 rhs) => new uvec2(lhs | rhs.x, lhs | rhs.y);
        
        /// <summary>
        /// Executed a component-wise & (bitwise-or).
        /// </summary>
        public static uvec2 operator&(uvec2 lhs, uvec2 rhs) => new uvec2(lhs.x & rhs.x, lhs.y & rhs.y);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static uvec2 operator&(uvec2 lhs, uint rhs) => new uvec2(lhs.x & rhs, lhs.y & rhs);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static uvec2 operator&(uint lhs, uvec2 rhs) => new uvec2(lhs & rhs.x, lhs & rhs.y);
        
        /// <summary>
        /// Executed a component-wise left-shift with a scalar.
        /// </summary>
        public static uvec2 operator<<(uvec2 lhs, int rhs) => new uvec2(lhs.x << rhs, lhs.y << rhs);
        
        /// <summary>
        /// Executed a component-wise right-shift with a scalar.
        /// </summary>
        public static uvec2 operator>>(uvec2 lhs, int rhs) => new uvec2(lhs.x >> rhs, lhs.y >> rhs);
        
        /// <summary>
        /// Executed a component-wise lesser-than comparison.
        /// </summary>
        public static bvec2 operator<(uvec2 lhs, uvec2 rhs) => new bvec2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Executed a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(uvec2 lhs, uint rhs) => new bvec2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Executed a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(uint lhs, uvec2 rhs) => new bvec2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Executed a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec2 operator<=(uvec2 lhs, uvec2 rhs) => new bvec2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Executed a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(uvec2 lhs, uint rhs) => new bvec2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Executed a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(uint lhs, uvec2 rhs) => new bvec2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Executed a component-wise greater-than comparison.
        /// </summary>
        public static bvec2 operator>(uvec2 lhs, uvec2 rhs) => new bvec2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Executed a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(uvec2 lhs, uint rhs) => new bvec2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Executed a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(uint lhs, uvec2 rhs) => new bvec2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Executed a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec2 operator>=(uvec2 lhs, uvec2 rhs) => new bvec2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Executed a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(uvec2 lhs, uint rhs) => new bvec2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Executed a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(uint lhs, uvec2 rhs) => new bvec2(lhs >= rhs.x, lhs >= rhs.y);
    }
}
