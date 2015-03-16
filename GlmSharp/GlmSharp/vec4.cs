using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

// ReSharper disable InconsistentNaming

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
        /// Predefined all-zero vector
        /// </summary>
        public static vec4 Zero { get; } = new vec4(default(float), default(float), default(float), default(float));
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static vec4 Ones { get; } = new vec4(1f, 1f, 1f, 1f);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static vec4 UnitX { get; } = new vec4(1f, default(float), default(float), default(float));
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static vec4 UnitY { get; } = new vec4(default(float), 1f, default(float), default(float));
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static vec4 UnitZ { get; } = new vec4(default(float), default(float), 1f, default(float));
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static vec4 UnitW { get; } = new vec4(default(float), default(float), default(float), 1f);
        
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
        /// Implicitly converts this to a dvec4.
        /// </summary>
        public static implicit operator dvec4(vec4 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Implicitly converts this to a cvec4.
        /// </summary>
        public static implicit operator cvec4(vec4 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
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
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(vec4 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(vec4 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(vec4 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(vec4 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(vec4 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
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
        public static explicit operator bvec2(vec4 v) => new bvec2(v.x != default(float), v.y != default(float));
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(vec4 v) => new bvec3(v.x != default(float), v.y != default(float), v.z != default(float));
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(vec4 v) => new bvec4(v.x != default(float), v.y != default(float), v.z != default(float), v.w != default(float));
        
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
        /// Returns a boolean vector with component-wise equal.
        /// </summary>
        public static bvec4 Equal(vec4 lhs, vec4 rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a boolean vector with component-wise not-equal.
        /// </summary>
        public static bvec4 NotEqual(vec4 lhs, vec4 rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than.
        /// </summary>
        public static bvec4 GreaterThan(vec4 lhs, vec4 rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than-or-equal.
        /// </summary>
        public static bvec4 GreaterThanEqual(vec4 lhs, vec4 rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than.
        /// </summary>
        public static bvec4 LesserThan(vec4 lhs, vec4 rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than-or-equal.
        /// </summary>
        public static bvec4 LesserThanEqual(vec4 lhs, vec4 rhs) => lhs <= rhs;
        
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
        /// Predefined all-MaxValue vector
        /// </summary>
        public static vec4 MaxValue { get; } = new vec4(float.MaxValue, float.MaxValue, float.MaxValue, float.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static vec4 MinValue { get; } = new vec4(float.MinValue, float.MinValue, float.MinValue, float.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static vec4 Epsilon { get; } = new vec4(float.Epsilon, float.Epsilon, float.Epsilon, float.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static vec4 NaN { get; } = new vec4(float.NaN, float.NaN, float.NaN, float.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static vec4 NegativeInfinity { get; } = new vec4(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static vec4 PositiveInfinity { get; } = new vec4(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);
        
        /// <summary>
        /// Executes a component-wise IsInfinity
        /// </summary>
        public static bvec4 IsInfinity(vec4 v) => new bvec4(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z), float.IsInfinity(v.w));
        
        /// <summary>
        /// Executes a component-wise IsFinite
        /// </summary>
        public static bvec4 IsFinite(vec4 v) => new bvec4(!float.IsNaN(v.x) && !float.IsInfinity(v.x), !float.IsNaN(v.y) && !float.IsInfinity(v.y), !float.IsNaN(v.z) && !float.IsInfinity(v.z), !float.IsNaN(v.w) && !float.IsInfinity(v.w));
        
        /// <summary>
        /// Executes a component-wise IsNaN
        /// </summary>
        public static bvec4 IsNaN(vec4 v) => new bvec4(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z), float.IsNaN(v.w));
        
        /// <summary>
        /// Executes a component-wise IsNegativeInfinity
        /// </summary>
        public static bvec4 IsNegativeInfinity(vec4 v) => new bvec4(float.IsNegativeInfinity(v.x), float.IsNegativeInfinity(v.y), float.IsNegativeInfinity(v.z), float.IsNegativeInfinity(v.w));
        
        /// <summary>
        /// Executes a component-wise IsPositiveInfinity
        /// </summary>
        public static bvec4 IsPositiveInfinity(vec4 v) => new bvec4(float.IsPositiveInfinity(v.x), float.IsPositiveInfinity(v.y), float.IsPositiveInfinity(v.z), float.IsPositiveInfinity(v.w));
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static vec4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static vec4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new vec4(float.Parse(kvp[0].Trim()), float.Parse(kvp[1].Trim()), float.Parse(kvp[2].Trim()), float.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static vec4 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new vec4(float.Parse(kvp[0].Trim(), provider), float.Parse(kvp[1].Trim(), provider), float.Parse(kvp[2].Trim(), provider), float.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static vec4 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new vec4(float.Parse(kvp[0].Trim(), style), float.Parse(kvp[1].Trim(), style), float.Parse(kvp[2].Trim(), style), float.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static vec4 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new vec4(float.Parse(kvp[0].Trim(), style, provider), float.Parse(kvp[1].Trim(), style, provider), float.Parse(kvp[2].Trim(), style, provider), float.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out vec4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out vec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            float x = default(float), y = default(float), z = default(float), w = default(float);
            var ok = float.TryParse(kvp[0].Trim(), out x) && float.TryParse(kvp[1].Trim(), out y) && float.TryParse(kvp[2].Trim(), out z) && float.TryParse(kvp[3].Trim(), out w);
            result = ok ? new vec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out vec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            float x = default(float), y = default(float), z = default(float), w = default(float);
            var ok = float.TryParse(kvp[0].Trim(), style, provider, out x) && float.TryParse(kvp[1].Trim(), style, provider, out y) && float.TryParse(kvp[2].Trim(), style, provider, out z) && float.TryParse(kvp[3].Trim(), style, provider, out w);
            result = ok ? new vec4(x, y, z, w) : Zero;
            return ok;
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
        /// Returns the sum of all components.
        /// </summary>
        public float Sum => x + y + z + w;
        
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
        public double NormP(double p) => Math.Pow(Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p) + Math.Pow((double)Math.Abs(z), p) + Math.Pow((double)Math.Abs(w), p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static vec4 operator+(vec4 lhs, vec4 rhs) => new vec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static vec4 operator+(vec4 lhs, float rhs) => new vec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static vec4 operator+(float lhs, vec4 rhs) => new vec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator+(vec4 lhs, dvec4 rhs) => new dvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator+(dvec4 lhs, vec4 rhs) => new dvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator+(vec4 lhs, double rhs) => new dvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator+(double lhs, vec4 rhs) => new dvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(vec4 lhs, cvec4 rhs) => new cvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(cvec4 lhs, vec4 rhs) => new cvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(vec4 lhs, Complex rhs) => new cvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(Complex lhs, vec4 rhs) => new cvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static vec4 operator-(vec4 lhs, vec4 rhs) => new vec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static vec4 operator-(vec4 lhs, float rhs) => new vec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static vec4 operator-(float lhs, vec4 rhs) => new vec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator-(vec4 lhs, dvec4 rhs) => new dvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator-(dvec4 lhs, vec4 rhs) => new dvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator-(vec4 lhs, double rhs) => new dvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator-(double lhs, vec4 rhs) => new dvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(vec4 lhs, cvec4 rhs) => new cvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(cvec4 lhs, vec4 rhs) => new cvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(vec4 lhs, Complex rhs) => new cvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(Complex lhs, vec4 rhs) => new cvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static vec4 operator/(vec4 lhs, vec4 rhs) => new vec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static vec4 operator/(vec4 lhs, float rhs) => new vec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static vec4 operator/(float lhs, vec4 rhs) => new vec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator/(vec4 lhs, dvec4 rhs) => new dvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator/(dvec4 lhs, vec4 rhs) => new dvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator/(vec4 lhs, double rhs) => new dvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator/(double lhs, vec4 rhs) => new dvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(vec4 lhs, cvec4 rhs) => new cvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(cvec4 lhs, vec4 rhs) => new cvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(vec4 lhs, Complex rhs) => new cvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(Complex lhs, vec4 rhs) => new cvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static vec4 operator*(vec4 lhs, vec4 rhs) => new vec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static vec4 operator*(vec4 lhs, float rhs) => new vec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static vec4 operator*(float lhs, vec4 rhs) => new vec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator*(vec4 lhs, dvec4 rhs) => new dvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to dvec4).
        /// </summary>
        public static dvec4 operator*(dvec4 lhs, vec4 rhs) => new dvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator*(vec4 lhs, double rhs) => new dvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to dvec4).
        /// </summary>
        public static dvec4 operator*(double lhs, vec4 rhs) => new dvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(vec4 lhs, cvec4 rhs) => new cvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(cvec4 lhs, vec4 rhs) => new cvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(vec4 lhs, Complex rhs) => new cvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(Complex lhs, vec4 rhs) => new cvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise unary + (add).
        /// </summary>
        public static vec4 operator+(vec4 v) => v;
        
        /// <summary>
        /// Executes a component-wise unary - (subtract).
        /// </summary>
        public static vec4 operator-(vec4 v) => new vec4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bvec4 operator<(vec4 lhs, vec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator<(vec4 lhs, float rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator<(float lhs, vec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec4 operator<=(vec4 lhs, vec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator<=(vec4 lhs, float rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator<=(float lhs, vec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bvec4 operator>(vec4 lhs, vec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator>(vec4 lhs, float rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator>(float lhs, vec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec4 operator>=(vec4 lhs, vec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator>=(vec4 lhs, float rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator>=(float lhs, vec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public vec4 Normalized => this / Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public vec4 NormalizedSafe => this == Zero ? Zero : this / Length;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(vec4 lhs, vec4 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(vec4 lhs, vec4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(vec4 lhs, vec4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec4 Reflect(vec4 I, vec4 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec4 Refract(vec4 I, vec4 N, float eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (float)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static vec4 FaceForward(vec4 N, vec4 I, vec4 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a component-wise executed Abs.
        /// </summary>
        public static vec4 Abs(vec4 v) => new vec4(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z), Math.Abs(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Abs with a scalar.
        /// </summary>
        public static vec4 Abs(float v) => new vec4(Math.Abs(v));
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder3.
        /// </summary>
        public static vec4 HermiteInterpolationOrder3(vec4 v) => new vec4((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder3 with a scalar.
        /// </summary>
        public static vec4 HermiteInterpolationOrder3(float v) => new vec4((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder5.
        /// </summary>
        public static vec4 HermiteInterpolationOrder5(vec4 v) => new vec4(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder5 with a scalar.
        /// </summary>
        public static vec4 HermiteInterpolationOrder5(float v) => new vec4(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a component-wise executed Step.
        /// </summary>
        public static vec4 Step(vec4 v) => new vec4(v.x >= default(float) ? 1f : default(float), v.y >= default(float) ? 1f : default(float), v.z >= default(float) ? 1f : default(float), v.w >= default(float) ? 1f : default(float));
        
        /// <summary>
        /// Returns a component-wise executed Step.
        /// </summary>
        public static vec4 Step(float v) => new vec4(v >= default(float) ? 1f : default(float));
        
        /// <summary>
        /// Returns a component-wise executed Acos.
        /// </summary>
        public static vec4 Acos(vec4 v) => new vec4((float)Math.Acos((double)v.x), (float)Math.Acos((double)v.y), (float)Math.Acos((double)v.z), (float)Math.Acos((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Acos.
        /// </summary>
        public static vec4 Acos(float v) => new vec4((float)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Asin.
        /// </summary>
        public static vec4 Asin(vec4 v) => new vec4((float)Math.Asin((double)v.x), (float)Math.Asin((double)v.y), (float)Math.Asin((double)v.z), (float)Math.Asin((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Asin.
        /// </summary>
        public static vec4 Asin(float v) => new vec4((float)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Atan.
        /// </summary>
        public static vec4 Atan(vec4 v) => new vec4((float)Math.Atan((double)v.x), (float)Math.Atan((double)v.y), (float)Math.Atan((double)v.z), (float)Math.Atan((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Atan.
        /// </summary>
        public static vec4 Atan(float v) => new vec4((float)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Cos.
        /// </summary>
        public static vec4 Cos(vec4 v) => new vec4((float)Math.Cos((double)v.x), (float)Math.Cos((double)v.y), (float)Math.Cos((double)v.z), (float)Math.Cos((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Cos.
        /// </summary>
        public static vec4 Cos(float v) => new vec4((float)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Cosh.
        /// </summary>
        public static vec4 Cosh(vec4 v) => new vec4((float)Math.Cosh((double)v.x), (float)Math.Cosh((double)v.y), (float)Math.Cosh((double)v.z), (float)Math.Cosh((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Cosh.
        /// </summary>
        public static vec4 Cosh(float v) => new vec4((float)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Exp.
        /// </summary>
        public static vec4 Exp(vec4 v) => new vec4((float)Math.Exp((double)v.x), (float)Math.Exp((double)v.y), (float)Math.Exp((double)v.z), (float)Math.Exp((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Exp.
        /// </summary>
        public static vec4 Exp(float v) => new vec4((float)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static vec4 Log(vec4 v) => new vec4((float)Math.Log((double)v.x), (float)Math.Log((double)v.y), (float)Math.Log((double)v.z), (float)Math.Log((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static vec4 Log(float v) => new vec4((float)Math.Log((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Log2.
        /// </summary>
        public static vec4 Log2(vec4 v) => new vec4((float)Math.Log((double)v.x, 2), (float)Math.Log((double)v.y, 2), (float)Math.Log((double)v.z, 2), (float)Math.Log((double)v.w, 2));
        
        /// <summary>
        /// Returns a component-wise executed Log2.
        /// </summary>
        public static vec4 Log2(float v) => new vec4((float)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a component-wise executed Log10.
        /// </summary>
        public static vec4 Log10(vec4 v) => new vec4((float)Math.Log10((double)v.x), (float)Math.Log10((double)v.y), (float)Math.Log10((double)v.z), (float)Math.Log10((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Log10.
        /// </summary>
        public static vec4 Log10(float v) => new vec4((float)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Floor.
        /// </summary>
        public static vec4 Floor(vec4 v) => new vec4((float)Math.Floor(v.x), (float)Math.Floor(v.y), (float)Math.Floor(v.z), (float)Math.Floor(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Floor.
        /// </summary>
        public static vec4 Floor(float v) => new vec4((float)Math.Floor(v));
        
        /// <summary>
        /// Returns a component-wise executed Ceiling.
        /// </summary>
        public static vec4 Ceiling(vec4 v) => new vec4((float)Math.Ceiling(v.x), (float)Math.Ceiling(v.y), (float)Math.Ceiling(v.z), (float)Math.Ceiling(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Ceiling.
        /// </summary>
        public static vec4 Ceiling(float v) => new vec4((float)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a component-wise executed Round.
        /// </summary>
        public static vec4 Round(vec4 v) => new vec4((float)Math.Round(v.x), (float)Math.Round(v.y), (float)Math.Round(v.z), (float)Math.Round(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Round.
        /// </summary>
        public static vec4 Round(float v) => new vec4((float)Math.Round(v));
        
        /// <summary>
        /// Returns a component-wise executed Sin.
        /// </summary>
        public static vec4 Sin(vec4 v) => new vec4((float)Math.Sin((double)v.x), (float)Math.Sin((double)v.y), (float)Math.Sin((double)v.z), (float)Math.Sin((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Sin.
        /// </summary>
        public static vec4 Sin(float v) => new vec4((float)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Sinh.
        /// </summary>
        public static vec4 Sinh(vec4 v) => new vec4((float)Math.Sinh((double)v.x), (float)Math.Sinh((double)v.y), (float)Math.Sinh((double)v.z), (float)Math.Sinh((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Sinh.
        /// </summary>
        public static vec4 Sinh(float v) => new vec4((float)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Sqrt.
        /// </summary>
        public static vec4 Sqrt(vec4 v) => new vec4((float)Math.Sqrt((double)v.x), (float)Math.Sqrt((double)v.y), (float)Math.Sqrt((double)v.z), (float)Math.Sqrt((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Sqrt.
        /// </summary>
        public static vec4 Sqrt(float v) => new vec4((float)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Tan.
        /// </summary>
        public static vec4 Tan(vec4 v) => new vec4((float)Math.Tan((double)v.x), (float)Math.Tan((double)v.y), (float)Math.Tan((double)v.z), (float)Math.Tan((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Tan.
        /// </summary>
        public static vec4 Tan(float v) => new vec4((float)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Tanh.
        /// </summary>
        public static vec4 Tanh(vec4 v) => new vec4((float)Math.Tanh((double)v.x), (float)Math.Tanh((double)v.y), (float)Math.Tanh((double)v.z), (float)Math.Tanh((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Tanh.
        /// </summary>
        public static vec4 Tanh(float v) => new vec4((float)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Truncate.
        /// </summary>
        public static vec4 Truncate(vec4 v) => new vec4((float)Math.Truncate((double)v.x), (float)Math.Truncate((double)v.y), (float)Math.Truncate((double)v.z), (float)Math.Truncate((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Truncate.
        /// </summary>
        public static vec4 Truncate(float v) => new vec4((float)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Sign.
        /// </summary>
        public static ivec4 Sign(vec4 v) => new ivec4(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Sign.
        /// </summary>
        public static ivec4 Sign(float v) => new ivec4(Math.Sign(v));
        
        /// <summary>
        /// Returns a component-wise executed Sqr.
        /// </summary>
        public static vec4 Sqr(vec4 v) => new vec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed Sqr with a scalar.
        /// </summary>
        public static vec4 Sqr(float v) => new vec4(v * v);
        
        /// <summary>
        /// Returns a component-wise executed Pow2.
        /// </summary>
        public static vec4 Pow2(vec4 v) => new vec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed Pow2 with a scalar.
        /// </summary>
        public static vec4 Pow2(float v) => new vec4(v * v);
        
        /// <summary>
        /// Returns a component-wise executed Max.
        /// </summary>
        public static vec4 Max(vec4 lhs, vec4 rhs) => new vec4(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static vec4 Max(vec4 v, float s) => new vec4(Math.Max(v.x, s), Math.Max(v.y, s), Math.Max(v.z, s), Math.Max(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static vec4 Max(float s, vec4 v) => new vec4(Math.Max(s, v.x), Math.Max(s, v.y), Math.Max(s, v.z), Math.Max(s, v.w));
        
        /// <summary>
        /// Returns a component-wise executed Max with scalars.
        /// </summary>
        public static vec4 Max(float lhs, float rhs) => new vec4(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a component-wise executed Min.
        /// </summary>
        public static vec4 Min(vec4 lhs, vec4 rhs) => new vec4(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static vec4 Min(vec4 v, float s) => new vec4(Math.Min(v.x, s), Math.Min(v.y, s), Math.Min(v.z, s), Math.Min(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static vec4 Min(float s, vec4 v) => new vec4(Math.Min(s, v.x), Math.Min(s, v.y), Math.Min(s, v.z), Math.Min(s, v.w));
        
        /// <summary>
        /// Returns a component-wise executed Min with scalars.
        /// </summary>
        public static vec4 Min(float lhs, float rhs) => new vec4(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static vec4 Pow(vec4 lhs, vec4 rhs) => new vec4((float)Math.Pow((double)lhs.x, (double)rhs.x), (float)Math.Pow((double)lhs.y, (double)rhs.y), (float)Math.Pow((double)lhs.z, (double)rhs.z), (float)Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static vec4 Pow(vec4 v, float s) => new vec4((float)Math.Pow((double)v.x, (double)s), (float)Math.Pow((double)v.y, (double)s), (float)Math.Pow((double)v.z, (double)s), (float)Math.Pow((double)v.w, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static vec4 Pow(float s, vec4 v) => new vec4((float)Math.Pow((double)s, (double)v.x), (float)Math.Pow((double)s, (double)v.y), (float)Math.Pow((double)s, (double)v.z), (float)Math.Pow((double)s, (double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow with scalars.
        /// </summary>
        public static vec4 Pow(float lhs, float rhs) => new vec4((float)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static vec4 Log(vec4 lhs, vec4 rhs) => new vec4((float)Math.Log((double)lhs.x, (double)rhs.x), (float)Math.Log((double)lhs.y, (double)rhs.y), (float)Math.Log((double)lhs.z, (double)rhs.z), (float)Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static vec4 Log(vec4 v, float s) => new vec4((float)Math.Log((double)v.x, (double)s), (float)Math.Log((double)v.y, (double)s), (float)Math.Log((double)v.z, (double)s), (float)Math.Log((double)v.w, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static vec4 Log(float s, vec4 v) => new vec4((float)Math.Log((double)s, (double)v.x), (float)Math.Log((double)s, (double)v.y), (float)Math.Log((double)s, (double)v.z), (float)Math.Log((double)s, (double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Log with scalars.
        /// </summary>
        public static vec4 Log(float lhs, float rhs) => new vec4((float)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a component-wise executed Clamp.
        /// </summary>
        public static vec4 Clamp(vec4 v, vec4 min, vec4 max) => new vec4(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z), Math.Min(Math.Max(v.w, min.w), max.w));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static vec4 Clamp(float v, vec4 min, vec4 max) => new vec4(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z), Math.Min(Math.Max(v, min.w), max.w));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static vec4 Clamp(vec4 v, float min, vec4 max) => new vec4(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z), Math.Min(Math.Max(v.w, min), max.w));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static vec4 Clamp(vec4 v, vec4 min, float max) => new vec4(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max), Math.Min(Math.Max(v.w, min.w), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static vec4 Clamp(float v, float min, vec4 max) => new vec4(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z), Math.Min(Math.Max(v, min), max.w));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static vec4 Clamp(vec4 v, float min, float max) => new vec4(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max), Math.Min(Math.Max(v.w, min), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static vec4 Clamp(float v, vec4 min, float max) => new vec4(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max), Math.Min(Math.Max(v, min.w), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static vec4 Clamp(float v, float min, float max) => new vec4(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a component-wise executed Mix.
        /// </summary>
        public static vec4 Mix(vec4 min, vec4 max, vec4 a) => new vec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static vec4 Mix(float min, vec4 max, vec4 a) => new vec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static vec4 Mix(vec4 min, float max, vec4 a) => new vec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static vec4 Mix(vec4 min, vec4 max, float a) => new vec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static vec4 Mix(float min, float max, vec4 a) => new vec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static vec4 Mix(vec4 min, float max, float a) => new vec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static vec4 Mix(float min, vec4 max, float a) => new vec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static vec4 Mix(float min, float max, float a) => new vec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp.
        /// </summary>
        public static vec4 Lerp(vec4 min, vec4 max, vec4 a) => new vec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static vec4 Lerp(float min, vec4 max, vec4 a) => new vec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static vec4 Lerp(vec4 min, float max, vec4 a) => new vec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static vec4 Lerp(vec4 min, vec4 max, float a) => new vec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static vec4 Lerp(float min, float max, vec4 a) => new vec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static vec4 Lerp(vec4 min, float max, float a) => new vec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static vec4 Lerp(float min, vec4 max, float a) => new vec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static vec4 Lerp(float min, float max, float a) => new vec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep.
        /// </summary>
        public static vec4 Smoothstep(vec4 edge0, vec4 edge1, vec4 v) => new vec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static vec4 Smoothstep(float edge0, vec4 edge1, vec4 v) => new vec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static vec4 Smoothstep(vec4 edge0, float edge1, vec4 v) => new vec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static vec4 Smoothstep(vec4 edge0, vec4 edge1, float v) => new vec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static vec4 Smoothstep(float edge0, float edge1, vec4 v) => new vec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static vec4 Smoothstep(vec4 edge0, float edge1, float v) => new vec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static vec4 Smoothstep(float edge0, vec4 edge1, float v) => new vec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static vec4 Smoothstep(float edge0, float edge1, float v) => new vec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep.
        /// </summary>
        public static vec4 Smootherstep(vec4 edge0, vec4 edge1, vec4 v) => new vec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static vec4 Smootherstep(float edge0, vec4 edge1, vec4 v) => new vec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static vec4 Smootherstep(vec4 edge0, float edge1, vec4 v) => new vec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static vec4 Smootherstep(vec4 edge0, vec4 edge1, float v) => new vec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static vec4 Smootherstep(float edge0, float edge1, vec4 v) => new vec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static vec4 Smootherstep(vec4 edge0, float edge1, float v) => new vec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static vec4 Smootherstep(float edge0, vec4 edge1, float v) => new vec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static vec4 Smootherstep(float edge0, float edge1, float v) => new vec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
    }
}
