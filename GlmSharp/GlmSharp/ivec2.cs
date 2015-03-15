using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct ivec2 : IReadOnlyList<int>, IEquatable<ivec2>
    {
        
        /// <summary>
        /// x-component
        /// </summary>
        public int x;
        
        /// <summary>
        /// y-component
        /// </summary>
        public int y;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_ivec2 swizzle => new swizzle_ivec2(x, y);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec2 Zero = new ivec2(default(int), default(int));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec2 Ones = new ivec2(1, 1);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec2 UnitX = new ivec2(1, default(int));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec2 UnitY = new ivec2(default(int), 1);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public int[] Values => new[] { x, y };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public ivec2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public ivec2(int v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public ivec2(ivec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public ivec2(ivec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public ivec2(ivec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// Explicitly converts this to a ivec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec3(ivec2 v) => new ivec3((int)v.x, (int)v.y, default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(ivec2 v) => new ivec4((int)v.x, (int)v.y, default(int), default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(ivec2 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec3(ivec2 v) => new uvec3((uint)v.x, (uint)v.y, default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(ivec2 v) => new uvec4((uint)v.x, (uint)v.y, default(uint), default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(ivec2 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec3(ivec2 v) => new vec3((float)v.x, (float)v.y, default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(ivec2 v) => new vec4((float)v.x, (float)v.y, default(float), default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(ivec2 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec3(ivec2 v) => new dvec3((double)v.x, (double)v.y, default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(ivec2 v) => new dvec4((double)v.x, (double)v.y, default(double), default(double));
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(ivec2 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec3(ivec2 v) => new lvec3((long)v.x, (long)v.y, default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(ivec2 v) => new lvec4((long)v.x, (long)v.y, default(long), default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(ivec2 v) => new bvec2(v.x != default(int), v.y != default(int));
        
        /// <summary>
        /// Explicitly converts this to a bvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec3(ivec2 v) => new bvec3(v.x != default(int), v.y != default(int), default(bool));
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(ivec2 v) => new bvec4(v.x != default(int), v.y != default(int), default(bool), default(bool));
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<int> GetEnumerator()
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
        public int this[int index]
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
        public bool Equals(ivec2 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is ivec2 && Equals((ivec2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(ivec2 lhs, ivec2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(ivec2 lhs, ivec2 rhs) => !lhs.Equals(rhs);
        
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
        public int MinElement => Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public int MaxElement => Math.Max(x, y);
        
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
        public float Norm1 => Math.Abs(x) + Math.Abs(y);
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public int NormMax => Math.Max(Math.Abs(x), Math.Abs(y));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow(Math.Abs(x), p) + Math.Pow(Math.Abs(y), p), 1 / p);
        
        /// <summary>
        /// Executed a component-wise + (add).
        /// </summary>
        public static ivec2 operator+(ivec2 lhs, ivec2 rhs) => new ivec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Executed a component-wise + (add) with a scalar.
        /// </summary>
        public static ivec2 operator+(ivec2 lhs, int rhs) => new ivec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Executed a component-wise + (add) with a scalar.
        /// </summary>
        public static ivec2 operator+(int lhs, ivec2 rhs) => new ivec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Executed a component-wise - (subtract).
        /// </summary>
        public static ivec2 operator-(ivec2 lhs, ivec2 rhs) => new ivec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Executed a component-wise - (subtract) with a scalar.
        /// </summary>
        public static ivec2 operator-(ivec2 lhs, int rhs) => new ivec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Executed a component-wise - (subtract) with a scalar.
        /// </summary>
        public static ivec2 operator-(int lhs, ivec2 rhs) => new ivec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Executed a component-wise / (divide).
        /// </summary>
        public static ivec2 operator/(ivec2 lhs, ivec2 rhs) => new ivec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Executed a component-wise / (divide) with a scalar.
        /// </summary>
        public static ivec2 operator/(ivec2 lhs, int rhs) => new ivec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Executed a component-wise / (divide) with a scalar.
        /// </summary>
        public static ivec2 operator/(int lhs, ivec2 rhs) => new ivec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Executed a component-wise * (multiply).
        /// </summary>
        public static ivec2 operator*(ivec2 lhs, ivec2 rhs) => new ivec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Executed a component-wise * (multiply) with a scalar.
        /// </summary>
        public static ivec2 operator*(ivec2 lhs, int rhs) => new ivec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Executed a component-wise * (multiply) with a scalar.
        /// </summary>
        public static ivec2 operator*(int lhs, ivec2 rhs) => new ivec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Executed a component-wise % (mod).
        /// </summary>
        public static ivec2 operator%(ivec2 lhs, ivec2 rhs) => new ivec2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Executed a component-wise % (mod) with a scalar.
        /// </summary>
        public static ivec2 operator%(ivec2 lhs, int rhs) => new ivec2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Executed a component-wise % (mod) with a scalar.
        /// </summary>
        public static ivec2 operator%(int lhs, ivec2 rhs) => new ivec2(lhs % rhs.x, lhs % rhs.y);
        
        /// <summary>
        /// Executed a component-wise ^ (xor).
        /// </summary>
        public static ivec2 operator^(ivec2 lhs, ivec2 rhs) => new ivec2(lhs.x ^ rhs.x, lhs.y ^ rhs.y);
        
        /// <summary>
        /// Executed a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static ivec2 operator^(ivec2 lhs, int rhs) => new ivec2(lhs.x ^ rhs, lhs.y ^ rhs);
        
        /// <summary>
        /// Executed a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static ivec2 operator^(int lhs, ivec2 rhs) => new ivec2(lhs ^ rhs.x, lhs ^ rhs.y);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or).
        /// </summary>
        public static ivec2 operator|(ivec2 lhs, ivec2 rhs) => new ivec2(lhs.x | rhs.x, lhs.y | rhs.y);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static ivec2 operator|(ivec2 lhs, int rhs) => new ivec2(lhs.x | rhs, lhs.y | rhs);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static ivec2 operator|(int lhs, ivec2 rhs) => new ivec2(lhs | rhs.x, lhs | rhs.y);
        
        /// <summary>
        /// Executed a component-wise & (bitwise-or).
        /// </summary>
        public static ivec2 operator&(ivec2 lhs, ivec2 rhs) => new ivec2(lhs.x & rhs.x, lhs.y & rhs.y);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static ivec2 operator&(ivec2 lhs, int rhs) => new ivec2(lhs.x & rhs, lhs.y & rhs);
        
        /// <summary>
        /// Executed a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static ivec2 operator&(int lhs, ivec2 rhs) => new ivec2(lhs & rhs.x, lhs & rhs.y);
        
        /// <summary>
        /// Executed a component-wise left-shift with a scalar.
        /// </summary>
        public static ivec2 operator<<(ivec2 lhs, int rhs) => new ivec2(lhs.x << rhs, lhs.y << rhs);
        
        /// <summary>
        /// Executed a component-wise right-shift with a scalar.
        /// </summary>
        public static ivec2 operator>>(ivec2 lhs, int rhs) => new ivec2(lhs.x >> rhs, lhs.y >> rhs);
        
        /// <summary>
        /// Executed a component-wise lesser-than comparison.
        /// </summary>
        public static bvec2 operator<(ivec2 lhs, ivec2 rhs) => new bvec2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Executed a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(ivec2 lhs, int rhs) => new bvec2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Executed a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(int lhs, ivec2 rhs) => new bvec2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Executed a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec2 operator<=(ivec2 lhs, ivec2 rhs) => new bvec2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Executed a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(ivec2 lhs, int rhs) => new bvec2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Executed a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(int lhs, ivec2 rhs) => new bvec2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Executed a component-wise greater-than comparison.
        /// </summary>
        public static bvec2 operator>(ivec2 lhs, ivec2 rhs) => new bvec2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Executed a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(ivec2 lhs, int rhs) => new bvec2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Executed a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(int lhs, ivec2 rhs) => new bvec2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Executed a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec2 operator>=(ivec2 lhs, ivec2 rhs) => new bvec2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Executed a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(ivec2 lhs, int rhs) => new bvec2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Executed a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(int lhs, ivec2 rhs) => new bvec2(lhs >= rhs.x, lhs >= rhs.y);
    }
}
