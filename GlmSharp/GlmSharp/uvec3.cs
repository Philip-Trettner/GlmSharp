using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct uvec3 : IReadOnlyList<uint>, IEquatable<uvec3>
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
        /// z-component
        /// </summary>
        public uint z;
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_uvec3 swizzle => new swizzle_uvec3(x, y, z);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly uvec3 Zero = new uvec3(default(uint), default(uint), default(uint));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly uvec3 Ones = new uvec3(1, 1, 1);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly uvec3 UnitX = new uvec3(1, default(uint), default(uint));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly uvec3 UnitY = new uvec3(default(uint), 1, default(uint));
        
        /// <summary>
        /// Predefined unit-Z vector (DO NOT MODIFY)
        /// </summary>
        public static readonly uvec3 UnitZ = new uvec3(default(uint), default(uint), 1);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public uint[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public uvec3(uint x, uint y, uint z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public uvec3(uint v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public uvec3(uvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(uint);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public uvec3(uvec2 v, uint z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public uvec3(uvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public uvec3(uvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// Implicitly converts this to a lvec3.
        /// </summary>
        public static implicit operator lvec3(uvec3 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Implicitly converts this to a vec3.
        /// </summary>
        public static implicit operator vec3(uvec3 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Implicitly converts this to a dvec3.
        /// </summary>
        public static implicit operator dvec3(uvec3 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Implicitly converts this to a decvec3.
        /// </summary>
        public static implicit operator decvec3(uvec3 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Implicitly converts this to a cvec3.
        /// </summary>
        public static implicit operator cvec3(uvec3 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(uvec3 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(uvec3 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(uvec3 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(uvec3 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(uvec3 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(uvec3 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(uvec3 v) => new vec4((float)v.x, (float)v.y, (float)v.z, default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(uvec3 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(uvec3 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, default(double));
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(uvec3 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(uvec3 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(uvec3 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(uvec3 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(uvec3 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(uvec3 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(uvec3 v) => new bvec2(v.x != default(uint), v.y != default(uint));
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(uvec3 v) => new bvec3(v.x != default(uint), v.y != default(uint), v.z != default(uint));
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(uvec3 v) => new bvec4(v.x != default(uint), v.y != default(uint), v.z != default(uint), default(bool));
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<uint> GetEnumerator()
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
        public uint this[int index]
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
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(uvec3 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is uvec3 && Equals((uvec3) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(uvec3 lhs, uvec3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(uvec3 lhs, uvec3 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((x.GetHashCode()) * 397) ^ y.GetHashCode()) * 397) ^ z.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public uint MinElement => Math.Min(Math.Min(x, y), z);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public uint MaxElement => Math.Max(Math.Max(x, y), z);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public float Length => (float)Math.Sqrt(x*x + y*y + z*z);
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => x*x + y*y + z*z;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public uint Sum => x + y + z;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt(x*x + y*y + z*z);
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => x + y + z;
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt(x*x + y*y + z*z);
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public uint NormMax => Math.Max(Math.Max(x, y), z);
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)x, p) + Math.Pow((double)y, p) + Math.Pow((double)z, p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static uvec3 operator+(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static uvec3 operator+(uvec3 lhs, uint rhs) => new uvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static uvec3 operator+(uint lhs, uvec3 rhs) => new uvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to lvec3).
        /// </summary>
        public static lvec3 operator+(uvec3 lhs, lvec3 rhs) => new lvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to lvec3).
        /// </summary>
        public static lvec3 operator+(lvec3 lhs, uvec3 rhs) => new lvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to lvec3).
        /// </summary>
        public static lvec3 operator+(uvec3 lhs, long rhs) => new lvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to lvec3).
        /// </summary>
        public static lvec3 operator+(long lhs, uvec3 rhs) => new lvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to vec3).
        /// </summary>
        public static vec3 operator+(uvec3 lhs, vec3 rhs) => new vec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to vec3).
        /// </summary>
        public static vec3 operator+(vec3 lhs, uvec3 rhs) => new vec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to vec3).
        /// </summary>
        public static vec3 operator+(uvec3 lhs, float rhs) => new vec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to vec3).
        /// </summary>
        public static vec3 operator+(float lhs, uvec3 rhs) => new vec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator+(uvec3 lhs, dvec3 rhs) => new dvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator+(dvec3 lhs, uvec3 rhs) => new dvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator+(uvec3 lhs, double rhs) => new dvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator+(double lhs, uvec3 rhs) => new dvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to decvec3).
        /// </summary>
        public static decvec3 operator+(uvec3 lhs, decvec3 rhs) => new decvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to decvec3).
        /// </summary>
        public static decvec3 operator+(decvec3 lhs, uvec3 rhs) => new decvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to decvec3).
        /// </summary>
        public static decvec3 operator+(uvec3 lhs, decimal rhs) => new decvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to decvec3).
        /// </summary>
        public static decvec3 operator+(decimal lhs, uvec3 rhs) => new decvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator+(uvec3 lhs, cvec3 rhs) => new cvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator+(cvec3 lhs, uvec3 rhs) => new cvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator+(uvec3 lhs, Complex rhs) => new cvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator+(Complex lhs, uvec3 rhs) => new cvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static uvec3 operator-(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static uvec3 operator-(uvec3 lhs, uint rhs) => new uvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static uvec3 operator-(uint lhs, uvec3 rhs) => new uvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to lvec3).
        /// </summary>
        public static lvec3 operator-(uvec3 lhs, lvec3 rhs) => new lvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to lvec3).
        /// </summary>
        public static lvec3 operator-(lvec3 lhs, uvec3 rhs) => new lvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to lvec3).
        /// </summary>
        public static lvec3 operator-(uvec3 lhs, long rhs) => new lvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to lvec3).
        /// </summary>
        public static lvec3 operator-(long lhs, uvec3 rhs) => new lvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to vec3).
        /// </summary>
        public static vec3 operator-(uvec3 lhs, vec3 rhs) => new vec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to vec3).
        /// </summary>
        public static vec3 operator-(vec3 lhs, uvec3 rhs) => new vec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to vec3).
        /// </summary>
        public static vec3 operator-(uvec3 lhs, float rhs) => new vec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to vec3).
        /// </summary>
        public static vec3 operator-(float lhs, uvec3 rhs) => new vec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator-(uvec3 lhs, dvec3 rhs) => new dvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator-(dvec3 lhs, uvec3 rhs) => new dvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator-(uvec3 lhs, double rhs) => new dvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator-(double lhs, uvec3 rhs) => new dvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to decvec3).
        /// </summary>
        public static decvec3 operator-(uvec3 lhs, decvec3 rhs) => new decvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to decvec3).
        /// </summary>
        public static decvec3 operator-(decvec3 lhs, uvec3 rhs) => new decvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to decvec3).
        /// </summary>
        public static decvec3 operator-(uvec3 lhs, decimal rhs) => new decvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to decvec3).
        /// </summary>
        public static decvec3 operator-(decimal lhs, uvec3 rhs) => new decvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator-(uvec3 lhs, cvec3 rhs) => new cvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator-(cvec3 lhs, uvec3 rhs) => new cvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator-(uvec3 lhs, Complex rhs) => new cvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator-(Complex lhs, uvec3 rhs) => new cvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static uvec3 operator/(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static uvec3 operator/(uvec3 lhs, uint rhs) => new uvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static uvec3 operator/(uint lhs, uvec3 rhs) => new uvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to lvec3).
        /// </summary>
        public static lvec3 operator/(uvec3 lhs, lvec3 rhs) => new lvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to lvec3).
        /// </summary>
        public static lvec3 operator/(lvec3 lhs, uvec3 rhs) => new lvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to lvec3).
        /// </summary>
        public static lvec3 operator/(uvec3 lhs, long rhs) => new lvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to lvec3).
        /// </summary>
        public static lvec3 operator/(long lhs, uvec3 rhs) => new lvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to vec3).
        /// </summary>
        public static vec3 operator/(uvec3 lhs, vec3 rhs) => new vec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to vec3).
        /// </summary>
        public static vec3 operator/(vec3 lhs, uvec3 rhs) => new vec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to vec3).
        /// </summary>
        public static vec3 operator/(uvec3 lhs, float rhs) => new vec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to vec3).
        /// </summary>
        public static vec3 operator/(float lhs, uvec3 rhs) => new vec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator/(uvec3 lhs, dvec3 rhs) => new dvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator/(dvec3 lhs, uvec3 rhs) => new dvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator/(uvec3 lhs, double rhs) => new dvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator/(double lhs, uvec3 rhs) => new dvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to decvec3).
        /// </summary>
        public static decvec3 operator/(uvec3 lhs, decvec3 rhs) => new decvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to decvec3).
        /// </summary>
        public static decvec3 operator/(decvec3 lhs, uvec3 rhs) => new decvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to decvec3).
        /// </summary>
        public static decvec3 operator/(uvec3 lhs, decimal rhs) => new decvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to decvec3).
        /// </summary>
        public static decvec3 operator/(decimal lhs, uvec3 rhs) => new decvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator/(uvec3 lhs, cvec3 rhs) => new cvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator/(cvec3 lhs, uvec3 rhs) => new cvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator/(uvec3 lhs, Complex rhs) => new cvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator/(Complex lhs, uvec3 rhs) => new cvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static uvec3 operator*(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static uvec3 operator*(uvec3 lhs, uint rhs) => new uvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static uvec3 operator*(uint lhs, uvec3 rhs) => new uvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to lvec3).
        /// </summary>
        public static lvec3 operator*(uvec3 lhs, lvec3 rhs) => new lvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to lvec3).
        /// </summary>
        public static lvec3 operator*(lvec3 lhs, uvec3 rhs) => new lvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to lvec3).
        /// </summary>
        public static lvec3 operator*(uvec3 lhs, long rhs) => new lvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to lvec3).
        /// </summary>
        public static lvec3 operator*(long lhs, uvec3 rhs) => new lvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to vec3).
        /// </summary>
        public static vec3 operator*(uvec3 lhs, vec3 rhs) => new vec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to vec3).
        /// </summary>
        public static vec3 operator*(vec3 lhs, uvec3 rhs) => new vec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to vec3).
        /// </summary>
        public static vec3 operator*(uvec3 lhs, float rhs) => new vec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to vec3).
        /// </summary>
        public static vec3 operator*(float lhs, uvec3 rhs) => new vec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator*(uvec3 lhs, dvec3 rhs) => new dvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator*(dvec3 lhs, uvec3 rhs) => new dvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator*(uvec3 lhs, double rhs) => new dvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator*(double lhs, uvec3 rhs) => new dvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to decvec3).
        /// </summary>
        public static decvec3 operator*(uvec3 lhs, decvec3 rhs) => new decvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to decvec3).
        /// </summary>
        public static decvec3 operator*(decvec3 lhs, uvec3 rhs) => new decvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to decvec3).
        /// </summary>
        public static decvec3 operator*(uvec3 lhs, decimal rhs) => new decvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to decvec3).
        /// </summary>
        public static decvec3 operator*(decimal lhs, uvec3 rhs) => new decvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator*(uvec3 lhs, cvec3 rhs) => new cvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator*(cvec3 lhs, uvec3 rhs) => new cvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator*(uvec3 lhs, Complex rhs) => new cvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator*(Complex lhs, uvec3 rhs) => new cvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise unary + (add).
        /// </summary>
        public static uvec3 operator+(uvec3 v) => v;
        
        /// <summary>
        /// Executes a component-wise % (modulo).
        /// </summary>
        public static uvec3 operator%(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static uvec3 operator%(uvec3 lhs, uint rhs) => new uvec3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);
        
        /// <summary>
        /// Executes a component-wise % (modulo) with a scalar.
        /// </summary>
        public static uvec3 operator%(uint lhs, uvec3 rhs) => new uvec3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);
        
        /// <summary>
        /// Executes a component-wise ^ (xor).
        /// </summary>
        public static uvec3 operator^(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static uvec3 operator^(uvec3 lhs, uint rhs) => new uvec3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);
        
        /// <summary>
        /// Executes a component-wise ^ (xor) with a scalar.
        /// </summary>
        public static uvec3 operator^(uint lhs, uvec3 rhs) => new uvec3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or).
        /// </summary>
        public static uvec3 operator|(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static uvec3 operator|(uvec3 lhs, uint rhs) => new uvec3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);
        
        /// <summary>
        /// Executes a component-wise | (bitwise-or) with a scalar.
        /// </summary>
        public static uvec3 operator|(uint lhs, uvec3 rhs) => new uvec3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);
        
        /// <summary>
        /// Executes a component-wise & (bitwise-and).
        /// </summary>
        public static uvec3 operator&(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);
        
        /// <summary>
        /// Executes a component-wise & (bitwise-and) with a scalar.
        /// </summary>
        public static uvec3 operator&(uvec3 lhs, uint rhs) => new uvec3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);
        
        /// <summary>
        /// Executes a component-wise & (bitwise-and) with a scalar.
        /// </summary>
        public static uvec3 operator&(uint lhs, uvec3 rhs) => new uvec3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);
        
        /// <summary>
        /// Executes a component-wise left-shift with a scalar.
        /// </summary>
        public static uvec3 operator<<(uvec3 lhs, int rhs) => new uvec3(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs);
        
        /// <summary>
        /// Executes a component-wise right-shift with a scalar.
        /// </summary>
        public static uvec3 operator>>(uvec3 lhs, int rhs) => new uvec3(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bvec3 operator<(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator<(uvec3 lhs, uint rhs) => new bvec3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator<(uint lhs, uvec3 rhs) => new bvec3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec3 operator<=(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator<=(uvec3 lhs, uint rhs) => new bvec3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator<=(uint lhs, uvec3 rhs) => new bvec3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bvec3 operator>(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator>(uvec3 lhs, uint rhs) => new bvec3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator>(uint lhs, uvec3 rhs) => new bvec3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec3 operator>=(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator>=(uvec3 lhs, uint rhs) => new bvec3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator>=(uint lhs, uvec3 rhs) => new bvec3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static uint Dot(uvec3 lhs, uvec3 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(uvec3 lhs, uvec3 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(uvec3 lhs, uvec3 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static uvec3 Cross(uvec3 l, uvec3 r) => new uvec3(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);
    }
}
