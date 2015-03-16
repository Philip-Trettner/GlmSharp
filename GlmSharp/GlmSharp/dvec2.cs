using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct dvec2 : IReadOnlyList<double>, IEquatable<dvec2>
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
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_dvec2 swizzle => new swizzle_dvec2(x, y);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly dvec2 Zero = new dvec2(default(double), default(double));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly dvec2 Ones = new dvec2(1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly dvec2 UnitX = new dvec2(1.0, default(double));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly dvec2 UnitY = new dvec2(default(double), 1.0);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public double[] Values => new[] { x, y };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public dvec2(double v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec2(dvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec2(dvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec2(dvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// Implicitly converts this to a cvec2.
        /// </summary>
        public static implicit operator cvec2(dvec2 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(dvec2 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec3(dvec2 v) => new ivec3((int)v.x, (int)v.y, default(int));
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(dvec2 v) => new ivec4((int)v.x, (int)v.y, default(int), default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(dvec2 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec3(dvec2 v) => new uvec3((uint)v.x, (uint)v.y, default(uint));
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(dvec2 v) => new uvec4((uint)v.x, (uint)v.y, default(uint), default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(dvec2 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec3(dvec2 v) => new vec3((float)v.x, (float)v.y, default(float));
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(dvec2 v) => new vec4((float)v.x, (float)v.y, default(float), default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec3(dvec2 v) => new dvec3((double)v.x, (double)v.y, default(double));
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(dvec2 v) => new dvec4((double)v.x, (double)v.y, default(double), default(double));
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(dvec2 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec3(dvec2 v) => new decvec3((decimal)v.x, (decimal)v.y, default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(dvec2 v) => new decvec4((decimal)v.x, (decimal)v.y, default(decimal), default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a cvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec3(dvec2 v) => new cvec3((Complex)v.x, (Complex)v.y, default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(dvec2 v) => new cvec4((Complex)v.x, (Complex)v.y, default(Complex), default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(dvec2 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec3(dvec2 v) => new lvec3((long)v.x, (long)v.y, default(long));
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(dvec2 v) => new lvec4((long)v.x, (long)v.y, default(long), default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(dvec2 v) => new bvec2(v.x != default(double), v.y != default(double));
        
        /// <summary>
        /// Explicitly converts this to a bvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec3(dvec2 v) => new bvec3(v.x != default(double), v.y != default(double), default(bool));
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(dvec2 v) => new bvec4(v.x != default(double), v.y != default(double), default(bool), default(bool));
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
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
        public double this[int index]
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
        public bool Equals(dvec2 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is dvec2 && Equals((dvec2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(dvec2 lhs, dvec2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(dvec2 lhs, dvec2 rhs) => !lhs.Equals(rhs);
        
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
        public double MinElement => Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public double MaxElement => Math.Max(x, y);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => x*x + y*y;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public double Sum => x + y;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => Math.Abs(x) + Math.Abs(y);
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(x*x + y*y);
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => Math.Max(Math.Abs(x), Math.Abs(y));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static dvec2 operator+(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static dvec2 operator+(dvec2 lhs, double rhs) => new dvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static dvec2 operator+(double lhs, dvec2 rhs) => new dvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec2).
        /// </summary>
        public static cvec2 operator+(dvec2 lhs, cvec2 rhs) => new cvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec2).
        /// </summary>
        public static cvec2 operator+(cvec2 lhs, dvec2 rhs) => new cvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec2).
        /// </summary>
        public static cvec2 operator+(dvec2 lhs, Complex rhs) => new cvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec2).
        /// </summary>
        public static cvec2 operator+(Complex lhs, dvec2 rhs) => new cvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static dvec2 operator-(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static dvec2 operator-(dvec2 lhs, double rhs) => new dvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static dvec2 operator-(double lhs, dvec2 rhs) => new dvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec2).
        /// </summary>
        public static cvec2 operator-(dvec2 lhs, cvec2 rhs) => new cvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec2).
        /// </summary>
        public static cvec2 operator-(cvec2 lhs, dvec2 rhs) => new cvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec2).
        /// </summary>
        public static cvec2 operator-(dvec2 lhs, Complex rhs) => new cvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec2).
        /// </summary>
        public static cvec2 operator-(Complex lhs, dvec2 rhs) => new cvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static dvec2 operator/(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static dvec2 operator/(dvec2 lhs, double rhs) => new dvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static dvec2 operator/(double lhs, dvec2 rhs) => new dvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec2).
        /// </summary>
        public static cvec2 operator/(dvec2 lhs, cvec2 rhs) => new cvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec2).
        /// </summary>
        public static cvec2 operator/(cvec2 lhs, dvec2 rhs) => new cvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec2).
        /// </summary>
        public static cvec2 operator/(dvec2 lhs, Complex rhs) => new cvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec2).
        /// </summary>
        public static cvec2 operator/(Complex lhs, dvec2 rhs) => new cvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static dvec2 operator*(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static dvec2 operator*(dvec2 lhs, double rhs) => new dvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static dvec2 operator*(double lhs, dvec2 rhs) => new dvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec2).
        /// </summary>
        public static cvec2 operator*(dvec2 lhs, cvec2 rhs) => new cvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec2).
        /// </summary>
        public static cvec2 operator*(cvec2 lhs, dvec2 rhs) => new cvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec2).
        /// </summary>
        public static cvec2 operator*(dvec2 lhs, Complex rhs) => new cvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec2).
        /// </summary>
        public static cvec2 operator*(Complex lhs, dvec2 rhs) => new cvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bvec2 operator<(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(dvec2 lhs, double rhs) => new bvec2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator<(double lhs, dvec2 rhs) => new bvec2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec2 operator<=(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(dvec2 lhs, double rhs) => new bvec2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator<=(double lhs, dvec2 rhs) => new bvec2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bvec2 operator>(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(dvec2 lhs, double rhs) => new bvec2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec2 operator>(double lhs, dvec2 rhs) => new bvec2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec2 operator>=(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(dvec2 lhs, double rhs) => new bvec2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec2 operator>=(double lhs, dvec2 rhs) => new bvec2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public dvec2 Normalized => this / Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public dvec2 NormalizedSafe => this == Zero ? Zero : this / Length;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(dvec2 lhs, dvec2 rhs) => lhs.x * rhs.x + lhs.y * rhs.y;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(dvec2 lhs, dvec2 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(dvec2 lhs, dvec2 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static double Cross(dvec2 l, dvec2 r) => l.x * r.y - l.y * r.x;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public double Angle => Math.Atan2((double)y, (double)x);
        
        /// <summary>
        /// Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types).
        /// </summary>
        public static dvec2 FromAngle(double angleInRad) => new dvec2((double)Math.Cos(angleInRad), (double)Math.Sin(angleInRad));
        
        /// <summary>
        /// Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).
        /// </summary>
        public dvec2 Rotated(double angleInRad) => (dvec2)(dvec2.FromAngle(Angle) * (double)Length);
    }
}
