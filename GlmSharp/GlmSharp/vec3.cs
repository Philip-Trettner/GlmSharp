using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct vec3 : IReadOnlyList<float>, IEquatable<vec3>
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
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_vec3 swizzle => new swizzle_vec3(x, y, z);
        
        /// <summary>
        /// Predefined all-zero vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 Zero = new vec3(default(float), default(float), default(float));
        
        /// <summary>
        /// Predefined all-ones vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 Ones = new vec3(1f, 1f, 1f);
        
        /// <summary>
        /// Predefined unit-X vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 UnitX = new vec3(1f, default(float), default(float));
        
        /// <summary>
        /// Predefined unit-Y vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 UnitY = new vec3(default(float), 1f, default(float));
        
        /// <summary>
        /// Predefined unit-Z vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 UnitZ = new vec3(default(float), default(float), 1f);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public float[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public vec3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public vec3(float v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public vec3(vec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = default(float);
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public vec3(vec2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public vec3(vec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public vec3(vec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// Implicitly converts this to a dvec3.
        /// </summary>
        public static implicit operator dvec3(vec3 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Implicitly converts this to a cvec3.
        /// </summary>
        public static implicit operator cvec3(vec3 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(vec3 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(vec3 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(vec3 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, default(int));
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(vec3 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(vec3 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(vec3 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, default(uint));
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(vec3 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(vec3 v) => new vec4((float)v.x, (float)v.y, (float)v.z, default(float));
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(vec3 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(vec3 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, default(double));
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(vec3 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(vec3 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(vec3 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, default(decimal));
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(vec3 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(vec3 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, default(Complex));
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(vec3 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(vec3 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(vec3 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, default(long));
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(vec3 v) => new bvec2(v.x != default(float), v.y != default(float));
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(vec3 v) => new bvec3(v.x != default(float), v.y != default(float), v.z != default(float));
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(vec3 v) => new bvec4(v.x != default(float), v.y != default(float), v.z != default(float), default(bool));
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<float> GetEnumerator()
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
        public float this[int index]
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
        public bool Equals(vec3 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is vec3 && Equals((vec3) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(vec3 lhs, vec3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(vec3 lhs, vec3 rhs) => !lhs.Equals(rhs);
        
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
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => x + sep + y + sep + z;
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => x.ToString(provider) + sep + y.ToString(provider) + sep + z.ToString(provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => x.ToString(format) + sep + y.ToString(format) + sep + z.ToString(format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => x.ToString(format, provider) + sep + y.ToString(format, provider) + sep + z.ToString(format, provider);
        
        /// <summary>
        /// Predefined all-MaxValue vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 MaxValue = new vec3(float.MaxValue, float.MaxValue, float.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 MinValue = new vec3(float.MinValue, float.MinValue, float.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 Epsilon = new vec3(float.Epsilon, float.Epsilon, float.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 NaN = new vec3(float.NaN, float.NaN, float.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 NegativeInfinity = new vec3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector (DO NOT MODIFY)
        /// </summary>
        public static readonly vec3 PositiveInfinity = new vec3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
        
        /// <summary>
        /// Executes a component-wise IsInfinity
        /// </summary>
        public static bvec3 IsInfinity(vec3 v) => new bvec3(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z));
        
        /// <summary>
        /// Executes a component-wise IsFinite
        /// </summary>
        public static bvec3 IsFinite(vec3 v) => new bvec3(!float.IsNaN(v.x) && !float.IsInfinity(v.x), !float.IsNaN(v.y) && !float.IsInfinity(v.y), !float.IsNaN(v.z) && !float.IsInfinity(v.z));
        
        /// <summary>
        /// Executes a component-wise IsNaN
        /// </summary>
        public static bvec3 IsNaN(vec3 v) => new bvec3(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z));
        
        /// <summary>
        /// Executes a component-wise IsNegativeInfinity
        /// </summary>
        public static bvec3 IsNegativeInfinity(vec3 v) => new bvec3(float.IsNegativeInfinity(v.x), float.IsNegativeInfinity(v.y), float.IsNegativeInfinity(v.z));
        
        /// <summary>
        /// Executes a component-wise IsPositiveInfinity
        /// </summary>
        public static bvec3 IsPositiveInfinity(vec3 v) => new bvec3(float.IsPositiveInfinity(v.x), float.IsPositiveInfinity(v.y), float.IsPositiveInfinity(v.z));
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static vec3 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static vec3 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new vec3(float.Parse(kvp[0].Trim()), float.Parse(kvp[1].Trim()), float.Parse(kvp[2].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static vec3 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new vec3(float.Parse(kvp[0].Trim(), provider), float.Parse(kvp[1].Trim(), provider), float.Parse(kvp[2].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static vec3 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new vec3(float.Parse(kvp[0].Trim(), style), float.Parse(kvp[1].Trim(), style), float.Parse(kvp[2].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static vec3 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new vec3(float.Parse(kvp[0].Trim(), style, provider), float.Parse(kvp[1].Trim(), style, provider), float.Parse(kvp[2].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out vec3 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out vec3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            float x = default(float), y = default(float), z = default(float);
            var ok = float.TryParse(kvp[0].Trim(), out x) && float.TryParse(kvp[1].Trim(), out y) && float.TryParse(kvp[2].Trim(), out z);
            result = ok ? new vec3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out vec3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            float x = default(float), y = default(float), z = default(float);
            var ok = float.TryParse(kvp[0].Trim(), style, provider, out x) && float.TryParse(kvp[1].Trim(), style, provider, out y) && float.TryParse(kvp[2].Trim(), style, provider, out z);
            result = ok ? new vec3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public float MinElement => Math.Min(Math.Min(x, y), z);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public float MaxElement => Math.Max(Math.Max(x, y), z);
        
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
        public float Sum => x + y + z;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt(x*x + y*y + z*z);
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => Math.Abs(x) + Math.Abs(y) + Math.Abs(z);
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt(x*x + y*y + z*z);
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p) + Math.Pow((double)Math.Abs(z), p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static vec3 operator+(vec3 lhs, vec3 rhs) => new vec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static vec3 operator+(vec3 lhs, float rhs) => new vec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static vec3 operator+(float lhs, vec3 rhs) => new vec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator+(vec3 lhs, dvec3 rhs) => new dvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator+(dvec3 lhs, vec3 rhs) => new dvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator+(vec3 lhs, double rhs) => new dvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator+(double lhs, vec3 rhs) => new dvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator+(vec3 lhs, cvec3 rhs) => new cvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator+(cvec3 lhs, vec3 rhs) => new cvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator+(vec3 lhs, Complex rhs) => new cvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator+(Complex lhs, vec3 rhs) => new cvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static vec3 operator-(vec3 lhs, vec3 rhs) => new vec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static vec3 operator-(vec3 lhs, float rhs) => new vec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static vec3 operator-(float lhs, vec3 rhs) => new vec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator-(vec3 lhs, dvec3 rhs) => new dvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator-(dvec3 lhs, vec3 rhs) => new dvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator-(vec3 lhs, double rhs) => new dvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator-(double lhs, vec3 rhs) => new dvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator-(vec3 lhs, cvec3 rhs) => new cvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator-(cvec3 lhs, vec3 rhs) => new cvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator-(vec3 lhs, Complex rhs) => new cvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator-(Complex lhs, vec3 rhs) => new cvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static vec3 operator/(vec3 lhs, vec3 rhs) => new vec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static vec3 operator/(vec3 lhs, float rhs) => new vec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static vec3 operator/(float lhs, vec3 rhs) => new vec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator/(vec3 lhs, dvec3 rhs) => new dvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator/(dvec3 lhs, vec3 rhs) => new dvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator/(vec3 lhs, double rhs) => new dvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator/(double lhs, vec3 rhs) => new dvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator/(vec3 lhs, cvec3 rhs) => new cvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator/(cvec3 lhs, vec3 rhs) => new cvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator/(vec3 lhs, Complex rhs) => new cvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator/(Complex lhs, vec3 rhs) => new cvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static vec3 operator*(vec3 lhs, vec3 rhs) => new vec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static vec3 operator*(vec3 lhs, float rhs) => new vec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static vec3 operator*(float lhs, vec3 rhs) => new vec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator*(vec3 lhs, dvec3 rhs) => new dvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to dvec3).
        /// </summary>
        public static dvec3 operator*(dvec3 lhs, vec3 rhs) => new dvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator*(vec3 lhs, double rhs) => new dvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to dvec3).
        /// </summary>
        public static dvec3 operator*(double lhs, vec3 rhs) => new dvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator*(vec3 lhs, cvec3 rhs) => new cvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec3).
        /// </summary>
        public static cvec3 operator*(cvec3 lhs, vec3 rhs) => new cvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator*(vec3 lhs, Complex rhs) => new cvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec3).
        /// </summary>
        public static cvec3 operator*(Complex lhs, vec3 rhs) => new cvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise unary + (add).
        /// </summary>
        public static vec3 operator+(vec3 v) => v;
        
        /// <summary>
        /// Executes a component-wise unary - (subtract).
        /// </summary>
        public static vec3 operator-(vec3 v) => new vec3(-v.x, -v.y, -v.z);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bvec3 operator<(vec3 lhs, vec3 rhs) => new bvec3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator<(vec3 lhs, float rhs) => new bvec3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator<(float lhs, vec3 rhs) => new bvec3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec3 operator<=(vec3 lhs, vec3 rhs) => new bvec3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator<=(vec3 lhs, float rhs) => new bvec3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator<=(float lhs, vec3 rhs) => new bvec3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bvec3 operator>(vec3 lhs, vec3 rhs) => new bvec3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator>(vec3 lhs, float rhs) => new bvec3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator>(float lhs, vec3 rhs) => new bvec3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec3 operator>=(vec3 lhs, vec3 rhs) => new bvec3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator>=(vec3 lhs, float rhs) => new bvec3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator>=(float lhs, vec3 rhs) => new bvec3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public vec3 Normalized => this / Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public vec3 NormalizedSafe => this == Zero ? Zero : this / Length;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(vec3 lhs, vec3 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(vec3 lhs, vec3 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(vec3 lhs, vec3 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static vec3 Cross(vec3 l, vec3 r) => new vec3(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);
        
        /// <summary>
        /// Returns a component-wise executed Abs.
        /// </summary>
        public static vec3 Abs(vec3 v) => new vec3(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Step.
        /// </summary>
        public static vec3 Step(vec3 v) => new vec3(v.x >= default(float) ? 1f : default(float), v.y >= default(float) ? 1f : default(float), v.z >= default(float) ? 1f : default(float));
        
        /// <summary>
        /// Returns a component-wise executed Acos.
        /// </summary>
        public static vec3 Acos(vec3 v) => new vec3((float)Math.Acos((double)v.x), (float)Math.Acos((double)v.y), (float)Math.Acos((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Asin.
        /// </summary>
        public static vec3 Asin(vec3 v) => new vec3((float)Math.Asin((double)v.x), (float)Math.Asin((double)v.y), (float)Math.Asin((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Atan.
        /// </summary>
        public static vec3 Atan(vec3 v) => new vec3((float)Math.Atan((double)v.x), (float)Math.Atan((double)v.y), (float)Math.Atan((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Cos.
        /// </summary>
        public static vec3 Cos(vec3 v) => new vec3((float)Math.Cos((double)v.x), (float)Math.Cos((double)v.y), (float)Math.Cos((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Cosh.
        /// </summary>
        public static vec3 Cosh(vec3 v) => new vec3((float)Math.Cosh((double)v.x), (float)Math.Cosh((double)v.y), (float)Math.Cosh((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Exp.
        /// </summary>
        public static vec3 Exp(vec3 v) => new vec3((float)Math.Exp((double)v.x), (float)Math.Exp((double)v.y), (float)Math.Exp((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static vec3 Log(vec3 v) => new vec3((float)Math.Log((double)v.x), (float)Math.Log((double)v.y), (float)Math.Log((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Log2.
        /// </summary>
        public static vec3 Log2(vec3 v) => new vec3((float)Math.Log((double)v.x, 2), (float)Math.Log((double)v.y, 2), (float)Math.Log((double)v.z, 2));
        
        /// <summary>
        /// Returns a component-wise executed Log10.
        /// </summary>
        public static vec3 Log10(vec3 v) => new vec3((float)Math.Log10((double)v.x), (float)Math.Log10((double)v.y), (float)Math.Log10((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Floor.
        /// </summary>
        public static vec3 Floor(vec3 v) => new vec3((float)Math.Floor(v.x), (float)Math.Floor(v.y), (float)Math.Floor(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Ceiling.
        /// </summary>
        public static vec3 Ceiling(vec3 v) => new vec3((float)Math.Ceiling(v.x), (float)Math.Ceiling(v.y), (float)Math.Ceiling(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Round.
        /// </summary>
        public static vec3 Round(vec3 v) => new vec3((float)Math.Round(v.x), (float)Math.Round(v.y), (float)Math.Round(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Sin.
        /// </summary>
        public static vec3 Sin(vec3 v) => new vec3((float)Math.Sin((double)v.x), (float)Math.Sin((double)v.y), (float)Math.Sin((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Sinh.
        /// </summary>
        public static vec3 Sinh(vec3 v) => new vec3((float)Math.Sinh((double)v.x), (float)Math.Sinh((double)v.y), (float)Math.Sinh((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Sqrt.
        /// </summary>
        public static vec3 Sqrt(vec3 v) => new vec3((float)Math.Sqrt((double)v.x), (float)Math.Sqrt((double)v.y), (float)Math.Sqrt((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Tan.
        /// </summary>
        public static vec3 Tan(vec3 v) => new vec3((float)Math.Tan((double)v.x), (float)Math.Tan((double)v.y), (float)Math.Tan((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Tanh.
        /// </summary>
        public static vec3 Tanh(vec3 v) => new vec3((float)Math.Tanh((double)v.x), (float)Math.Tanh((double)v.y), (float)Math.Tanh((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Truncate.
        /// </summary>
        public static vec3 Truncate(vec3 v) => new vec3((float)Math.Truncate((double)v.x), (float)Math.Truncate((double)v.y), (float)Math.Truncate((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Sign.
        /// </summary>
        public static ivec3 Sign(vec3 v) => new ivec3(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Sqr.
        /// </summary>
        public static vec3 Sqr(vec3 v) => new vec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed Pow2.
        /// </summary>
        public static vec3 Pow2(vec3 v) => new vec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed Max.
        /// </summary>
        public static vec3 Max(vec3 lhs, vec3 rhs) => new vec3(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static vec3 Max(vec3 v, float s) => new vec3(Math.Max(v.x, s), Math.Max(v.y, s), Math.Max(v.z, s));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static vec3 Max(float s, vec3 v) => new vec3(Math.Max(s, v.x), Math.Max(s, v.y), Math.Max(s, v.z));
        
        /// <summary>
        /// Returns a component-wise executed Min.
        /// </summary>
        public static vec3 Min(vec3 lhs, vec3 rhs) => new vec3(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static vec3 Min(vec3 v, float s) => new vec3(Math.Min(v.x, s), Math.Min(v.y, s), Math.Min(v.z, s));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static vec3 Min(float s, vec3 v) => new vec3(Math.Min(s, v.x), Math.Min(s, v.y), Math.Min(s, v.z));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static vec3 Pow(vec3 lhs, vec3 rhs) => new vec3((float)Math.Pow((double)lhs.x, (double)rhs.x), (float)Math.Pow((double)lhs.y, (double)rhs.y), (float)Math.Pow((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static vec3 Pow(vec3 v, float s) => new vec3((float)Math.Pow((double)v.x, (double)s), (float)Math.Pow((double)v.y, (double)s), (float)Math.Pow((double)v.z, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static vec3 Pow(float s, vec3 v) => new vec3((float)Math.Pow((double)s, (double)v.x), (float)Math.Pow((double)s, (double)v.y), (float)Math.Pow((double)s, (double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static vec3 Log(vec3 lhs, vec3 rhs) => new vec3((float)Math.Log((double)lhs.x, (double)rhs.x), (float)Math.Log((double)lhs.y, (double)rhs.y), (float)Math.Log((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static vec3 Log(vec3 v, float s) => new vec3((float)Math.Log((double)v.x, (double)s), (float)Math.Log((double)v.y, (double)s), (float)Math.Log((double)v.z, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static vec3 Log(float s, vec3 v) => new vec3((float)Math.Log((double)s, (double)v.x), (float)Math.Log((double)s, (double)v.y), (float)Math.Log((double)s, (double)v.z));
    }
}
