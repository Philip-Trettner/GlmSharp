using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct ivec4 : IReadOnlyList<int>, IEquatable<ivec4>
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
        /// z-component
        /// </summary>
        public int z;
        
        /// <summary>
        /// w-component
        /// </summary>
        public int w;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_ivec4 swizzle => new swizzle_ivec4(x, y, z, w);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec4 Zero = new ivec4(default(int), default(int), default(int), default(int));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec4 Ones = new ivec4(1, 1, 1, 1);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec4 UnitX = new ivec4(1, default(int), default(int), default(int));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec4 UnitY = new ivec4(default(int), 1, default(int), default(int));
        
        /// <summary>
        /// Predefined unit-Z vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec4 UnitZ = new ivec4(default(int), default(int), 1, default(int));
        
        /// <summary>
        /// Predefined unit-W vector (DO NOT MODIFY)
        /// </summary>
        public static readonly ivec4 UnitW = new ivec4(default(int), default(int), default(int), 1);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public int[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public ivec4(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public ivec4(int v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public ivec4(ivec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(int);
            this.w = default(int);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public ivec4(ivec2 v, int z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = default(int);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public ivec4(ivec2 v, int z, int w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public ivec4(ivec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = default(int);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public ivec4(ivec3 v, int w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public ivec4(ivec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }
        
        /// <summary>
        /// Implicitly converts this to a lvec4.
        /// </summary>
        public static implicit operator lvec4(ivec4 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Implicitly converts this to a vec4.
        /// </summary>
        public static implicit operator vec4(ivec4 v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Implicitly converts this to a dvec4.
        /// </summary>
        public static implicit operator dvec4(ivec4 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Implicitly converts this to a decvec4.
        /// </summary>
        public static implicit operator decvec4(ivec4 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Implicitly converts this to a cvec4.
        /// </summary>
        public static implicit operator cvec4(ivec4 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(ivec4 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(ivec4 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(ivec4 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(ivec4 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(ivec4 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(ivec4 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(ivec4 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(ivec4 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(ivec4 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(ivec4 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(ivec4 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(ivec4 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(ivec4 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(ivec4 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(ivec4 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(ivec4 v) => new bvec2(v.x != default(int), v.y != default(int));
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(ivec4 v) => new bvec3(v.x != default(int), v.y != default(int), v.z != default(int));
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(ivec4 v) => new bvec4(v.x != default(int), v.y != default(int), v.z != default(int), v.w != default(int));
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<int> GetEnumerator()
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
        public int this[int index]
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
        public bool Equals(ivec4 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z) && w.Equals(rhs.w);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is ivec4 && Equals((ivec4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(ivec4 lhs, ivec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(ivec4 lhs, ivec4 rhs) => !lhs.Equals(rhs);
        
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
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => x + sep + y + sep + z + sep + w;
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => x.ToString(provider) + sep + y.ToString(provider) + sep + z.ToString(provider) + sep + w.ToString(provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => x.ToString(format) + sep + y.ToString(format) + sep + z.ToString(format) + sep + w.ToString(format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => x.ToString(format, provider) + sep + y.ToString(format, provider) + sep + z.ToString(format, provider) + sep + w.ToString(format, provider);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public int MinElement => Math.Min(Math.Min(Math.Min(x, y), z), w);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public int MaxElement => Math.Max(Math.Max(Math.Max(x, y), z), w);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public float Length => (float)Math.Sqrt(x*x + y*y + z*z + w*w);
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => x*x + y*y + z*z + w*w;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public int Sum => x + y + z + w;
        
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
        public int NormMax => Math.Max(Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z)), Math.Abs(w));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p) + Math.Pow((double)Math.Abs(z), p) + Math.Pow((double)Math.Abs(w), p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static ivec4 operator+(ivec4 lhs, ivec4 rhs) => new ivec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static ivec4 operator+(ivec4 lhs, int rhs) => new ivec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static ivec4 operator+(int lhs, ivec4 rhs) => new ivec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to lvec4).
        /// </summary>
        public static lvec4 operator+(ivec4 lhs, lvec4 rhs) => new lvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to lvec4).
        /// </summary>
        public static lvec4 operator+(lvec4 lhs, ivec4 rhs) => new lvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to lvec4).
        /// </summary>
        public static lvec4 operator+(ivec4 lhs, long rhs) => new lvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to lvec4).
        /// </summary>
        public static lvec4 operator+(long lhs, ivec4 rhs) => new lvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to vec4).
        /// </summary>
        public static vec4 operator+(ivec4 lhs, vec4 rhs) => new vec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to vec4).
        /// </summary>
        public static vec4 operator+(vec4 lhs, ivec4 rhs) => new vec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to vec4).
        /// </summary>
        public static vec4 operator+(ivec4 lhs, float rhs) => new vec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to vec4).
        /// </summary>
        public static vec4 operator+(float lhs, ivec4 rhs) => new vec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator+(ivec4 lhs, dvec4 rhs) => new dvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator+(dvec4 lhs, ivec4 rhs) => new dvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator+(ivec4 lhs, double rhs) => new dvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator+(double lhs, ivec4 rhs) => new dvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to decvec4).
        /// </summary>
        public static decvec4 operator+(ivec4 lhs, decvec4 rhs) => new decvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to decvec4).
        /// </summary>
        public static decvec4 operator+(decvec4 lhs, ivec4 rhs) => new decvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to decvec4).
        /// </summary>
        public static decvec4 operator+(ivec4 lhs, decimal rhs) => new decvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to decvec4).
        /// </summary>
        public static decvec4 operator+(decimal lhs, ivec4 rhs) => new decvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(ivec4 lhs, cvec4 rhs) => new cvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(cvec4 lhs, ivec4 rhs) => new cvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(ivec4 lhs, Complex rhs) => new cvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(Complex lhs, ivec4 rhs) => new cvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static ivec4 operator-(ivec4 lhs, ivec4 rhs) => new ivec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static ivec4 operator-(ivec4 lhs, int rhs) => new ivec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static ivec4 operator-(int lhs, ivec4 rhs) => new ivec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to lvec4).
        /// </summary>
        public static lvec4 operator-(ivec4 lhs, lvec4 rhs) => new lvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to lvec4).
        /// </summary>
        public static lvec4 operator-(lvec4 lhs, ivec4 rhs) => new lvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to lvec4).
        /// </summary>
        public static lvec4 operator-(ivec4 lhs, long rhs) => new lvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to lvec4).
        /// </summary>
        public static lvec4 operator-(long lhs, ivec4 rhs) => new lvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to vec4).
        /// </summary>
        public static vec4 operator-(ivec4 lhs, vec4 rhs) => new vec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to vec4).
        /// </summary>
        public static vec4 operator-(vec4 lhs, ivec4 rhs) => new vec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to vec4).
        /// </summary>
        public static vec4 operator-(ivec4 lhs, float rhs) => new vec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to vec4).
        /// </summary>
        public static vec4 operator-(float lhs, ivec4 rhs) => new vec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator-(ivec4 lhs, dvec4 rhs) => new dvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator-(dvec4 lhs, ivec4 rhs) => new dvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator-(ivec4 lhs, double rhs) => new dvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator-(double lhs, ivec4 rhs) => new dvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to decvec4).
        /// </summary>
        public static decvec4 operator-(ivec4 lhs, decvec4 rhs) => new decvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to decvec4).
        /// </summary>
        public static decvec4 operator-(decvec4 lhs, ivec4 rhs) => new decvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to decvec4).
        /// </summary>
        public static decvec4 operator-(ivec4 lhs, decimal rhs) => new decvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to decvec4).
        /// </summary>
        public static decvec4 operator-(decimal lhs, ivec4 rhs) => new decvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(ivec4 lhs, cvec4 rhs) => new cvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(cvec4 lhs, ivec4 rhs) => new cvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(ivec4 lhs, Complex rhs) => new cvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(Complex lhs, ivec4 rhs) => new cvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static ivec4 operator/(ivec4 lhs, ivec4 rhs) => new ivec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static ivec4 operator/(ivec4 lhs, int rhs) => new ivec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static ivec4 operator/(int lhs, ivec4 rhs) => new ivec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to lvec4).
        /// </summary>
        public static lvec4 operator/(ivec4 lhs, lvec4 rhs) => new lvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to lvec4).
        /// </summary>
        public static lvec4 operator/(lvec4 lhs, ivec4 rhs) => new lvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to lvec4).
        /// </summary>
        public static lvec4 operator/(ivec4 lhs, long rhs) => new lvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to lvec4).
        /// </summary>
        public static lvec4 operator/(long lhs, ivec4 rhs) => new lvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to vec4).
        /// </summary>
        public static vec4 operator/(ivec4 lhs, vec4 rhs) => new vec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to vec4).
        /// </summary>
        public static vec4 operator/(vec4 lhs, ivec4 rhs) => new vec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to vec4).
        /// </summary>
        public static vec4 operator/(ivec4 lhs, float rhs) => new vec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to vec4).
        /// </summary>
        public static vec4 operator/(float lhs, ivec4 rhs) => new vec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator/(ivec4 lhs, dvec4 rhs) => new dvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator/(dvec4 lhs, ivec4 rhs) => new dvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator/(ivec4 lhs, double rhs) => new dvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator/(double lhs, ivec4 rhs) => new dvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to decvec4).
        /// </summary>
        public static decvec4 operator/(ivec4 lhs, decvec4 rhs) => new decvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to decvec4).
        /// </summary>
        public static decvec4 operator/(decvec4 lhs, ivec4 rhs) => new decvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to decvec4).
        /// </summary>
        public static decvec4 operator/(ivec4 lhs, decimal rhs) => new decvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to decvec4).
        /// </summary>
        public static decvec4 operator/(decimal lhs, ivec4 rhs) => new decvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(ivec4 lhs, cvec4 rhs) => new cvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(cvec4 lhs, ivec4 rhs) => new cvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(ivec4 lhs, Complex rhs) => new cvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(Complex lhs, ivec4 rhs) => new cvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static ivec4 operator*(ivec4 lhs, ivec4 rhs) => new ivec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static ivec4 operator*(ivec4 lhs, int rhs) => new ivec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static ivec4 operator*(int lhs, ivec4 rhs) => new ivec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to lvec4).
        /// </summary>
        public static lvec4 operator*(ivec4 lhs, lvec4 rhs) => new lvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to lvec4).
        /// </summary>
        public static lvec4 operator*(lvec4 lhs, ivec4 rhs) => new lvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to lvec4).
        /// </summary>
        public static lvec4 operator*(ivec4 lhs, long rhs) => new lvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to lvec4).
        /// </summary>
        public static lvec4 operator*(long lhs, ivec4 rhs) => new lvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to vec4).
        /// </summary>
        public static vec4 operator*(ivec4 lhs, vec4 rhs) => new vec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to vec4).
        /// </summary>
        public static vec4 operator*(vec4 lhs, ivec4 rhs) => new vec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to vec4).
        /// </summary>
        public static vec4 operator*(ivec4 lhs, float rhs) => new vec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to vec4).
        /// </summary>
        public static vec4 operator*(float lhs, ivec4 rhs) => new vec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator*(ivec4 lhs, dvec4 rhs) => new dvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator*(dvec4 lhs, ivec4 rhs) => new dvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator*(ivec4 lhs, double rhs) => new dvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator*(double lhs, ivec4 rhs) => new dvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to decvec4).
        /// </summary>
        public static decvec4 operator*(ivec4 lhs, decvec4 rhs) => new decvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to decvec4).
        /// </summary>
        public static decvec4 operator*(decvec4 lhs, ivec4 rhs) => new decvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to decvec4).
        /// </summary>
        public static decvec4 operator*(ivec4 lhs, decimal rhs) => new decvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to decvec4).
        /// </summary>
        public static decvec4 operator*(decimal lhs, ivec4 rhs) => new decvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(ivec4 lhs, cvec4 rhs) => new cvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(cvec4 lhs, ivec4 rhs) => new cvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(ivec4 lhs, Complex rhs) => new cvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(Complex lhs, ivec4 rhs) => new cvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise unary + (add).
        /// </summary>
        public static ivec4 operator+(ivec4 v) => v;
        
        /// <summary>
        /// Executes a component-wise unary - (subtract).
        /// </summary>
        public static ivec4 operator-(ivec4 v) => new ivec4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Executes a component-wise % (modulo).
        /// </summary>
        public static ivec4 operator%(ivec4 lhs, ivec4 rhs) => new ivec4(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z, lhs.w % rhs.w);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static ivec4 operator%(ivec4 lhs, int rhs) => new ivec4(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs, lhs.w % rhs);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static ivec4 operator%(int lhs, ivec4 rhs) => new ivec4(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z, lhs % rhs.w);
        
        /// <summary>
        /// Executes a component-wise ^ (xor).
        /// </summary>
        public static ivec4 operator^(ivec4 lhs, ivec4 rhs) => new ivec4(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z, lhs.w ^ rhs.w);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static ivec4 operator^(ivec4 lhs, int rhs) => new ivec4(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs, lhs.w ^ rhs);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static ivec4 operator^(int lhs, ivec4 rhs) => new ivec4(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z, lhs ^ rhs.w);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or).
        /// </summary>
        public static ivec4 operator|(ivec4 lhs, ivec4 rhs) => new ivec4(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z, lhs.w | rhs.w);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static ivec4 operator|(ivec4 lhs, int rhs) => new ivec4(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs, lhs.w | rhs);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static ivec4 operator|(int lhs, ivec4 rhs) => new ivec4(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z, lhs | rhs.w);
        
        /// <summary>
        /// Executes a component-wise & (bitwise-and).
        /// </summary>
        public static ivec4 operator&(ivec4 lhs, ivec4 rhs) => new ivec4(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z, lhs.w & rhs.w);
        
        /// <summary>
        /// Executes a component-wise & (bitwise-and) with a scalar.
        /// </summary>
        public static ivec4 operator&(ivec4 lhs, int rhs) => new ivec4(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs, lhs.w & rhs);
        
        /// <summary>
        /// Executes a component-wise & (bitwise-and) with a scalar.
        /// </summary>
        public static ivec4 operator&(int lhs, ivec4 rhs) => new ivec4(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z, lhs & rhs.w);
        
        /// <summary>
        /// Executes a component-wise left-shift with a scalar.
        /// </summary>
        public static ivec4 operator<<(ivec4 lhs, int rhs) => new ivec4(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs, lhs.w << rhs);
        
        /// <summary>
        /// Executes a component-wise right-shift with a scalar.
        /// </summary>
        public static ivec4 operator>>(ivec4 lhs, int rhs) => new ivec4(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs, lhs.w >> rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bvec4 operator<(ivec4 lhs, ivec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator<(ivec4 lhs, int rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator<(int lhs, ivec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec4 operator<=(ivec4 lhs, ivec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator<=(ivec4 lhs, int rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator<=(int lhs, ivec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bvec4 operator>(ivec4 lhs, ivec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator>(ivec4 lhs, int rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator>(int lhs, ivec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec4 operator>=(ivec4 lhs, ivec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator>=(ivec4 lhs, int rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator>=(int lhs, ivec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static int Dot(ivec4 lhs, ivec4 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(ivec4 lhs, ivec4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(ivec4 lhs, ivec4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns a component-wise executed Abs.
        /// </summary>
        public static ivec4 Abs(ivec4 v) => new ivec4(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z), Math.Abs(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Sqr.
        /// </summary>
        public static ivec4 Sqr(ivec4 v) => new ivec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed Pow2.
        /// </summary>
        public static ivec4 Pow2(ivec4 v) => new ivec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed Max.
        /// </summary>
        public static ivec4 Max(ivec4 lhs, ivec4 rhs) => new ivec4(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static ivec4 Max(ivec4 v, int s) => new ivec4(Math.Max(v.x, s), Math.Max(v.y, s), Math.Max(v.z, s), Math.Max(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static ivec4 Max(int s, ivec4 v) => new ivec4(Math.Max(s, v.x), Math.Max(s, v.y), Math.Max(s, v.z), Math.Max(s, v.w));
        
        /// <summary>
        /// Returns a component-wise executed Min.
        /// </summary>
        public static ivec4 Min(ivec4 lhs, ivec4 rhs) => new ivec4(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static ivec4 Min(ivec4 v, int s) => new ivec4(Math.Min(v.x, s), Math.Min(v.y, s), Math.Min(v.z, s), Math.Min(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static ivec4 Min(int s, ivec4 v) => new ivec4(Math.Min(s, v.x), Math.Min(s, v.y), Math.Min(s, v.z), Math.Min(s, v.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static ivec4 Pow(ivec4 lhs, ivec4 rhs) => new ivec4((int)Math.Pow((double)lhs.x, (double)rhs.x), (int)Math.Pow((double)lhs.y, (double)rhs.y), (int)Math.Pow((double)lhs.z, (double)rhs.z), (int)Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static ivec4 Pow(ivec4 v, int s) => new ivec4((int)Math.Pow((double)v.x, (double)s), (int)Math.Pow((double)v.y, (double)s), (int)Math.Pow((double)v.z, (double)s), (int)Math.Pow((double)v.w, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static ivec4 Pow(int s, ivec4 v) => new ivec4((int)Math.Pow((double)s, (double)v.x), (int)Math.Pow((double)s, (double)v.y), (int)Math.Pow((double)s, (double)v.z), (int)Math.Pow((double)s, (double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static ivec4 Log(ivec4 lhs, ivec4 rhs) => new ivec4((int)Math.Log((double)lhs.x, (double)rhs.x), (int)Math.Log((double)lhs.y, (double)rhs.y), (int)Math.Log((double)lhs.z, (double)rhs.z), (int)Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static ivec4 Log(ivec4 v, int s) => new ivec4((int)Math.Log((double)v.x, (double)s), (int)Math.Log((double)v.y, (double)s), (int)Math.Log((double)v.z, (double)s), (int)Math.Log((double)v.w, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static ivec4 Log(int s, ivec4 v) => new ivec4((int)Math.Log((double)s, (double)v.x), (int)Math.Log((double)s, (double)v.y), (int)Math.Log((double)s, (double)v.z), (int)Math.Log((double)s, (double)v.w));
    }
}
