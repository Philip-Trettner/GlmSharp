using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Numerics;
using System.Linq;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    
    /// <summary>
    /// A vector of type float with 3 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct vec3 : IReadOnlyList<float>, IEquatable<vec3>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public float x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public float y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public float z;

        #endregion


        #region Constructors
        
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
            this.z = 0f;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public vec3(vec2 v, float z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public vec3(vec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public vec3(vec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec3(IReadOnlyList<float> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
            this.z = c < 2 ? 0f : v[2];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec3(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : (float)v[0];
            this.y = c < 1 ? 0f : (float)v[1];
            this.z = c < 2 ? 0f : (float)v[2];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec3(float[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0f : v[0];
            this.y = c < 1 ? 0f : v[1];
            this.z = c < 2 ? 0f : v[2];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec3(float[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0f : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0f : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0f : v[2 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public vec3(IEnumerable<float> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a dvec3.
        /// </summary>
        public static implicit operator dvec3(vec3 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Implicitly converts this to a cvec3.
        /// </summary>
        public static implicit operator cvec3(vec3 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);

        #endregion


        #region Explicit Operators
        
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
        public static explicit operator ivec4(vec3 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, 0);
        
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
        public static explicit operator uvec4(vec3 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, 0u);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(vec3 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(vec3 v) => new vec4((float)v.x, (float)v.y, (float)v.z, 0f);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(vec3 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(vec3 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator hvec4(vec3 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(vec3 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(vec3 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, 0.0);
        
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
        public static explicit operator decvec4(vec3 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, 0m);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(vec3 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(vec3 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, Complex.Zero);
        
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
        public static explicit operator lvec4(vec3 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(vec3 v) => new bvec2(v.x != 0f, v.y != 0f);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(vec3 v) => new bvec3(v.x != 0f, v.y != 0f, v.z != 0f);
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(vec3 v) => new bvec4(v.x != 0f, v.y != 0f, v.z != 0f, false);
        
        /// <summary>
        /// Explicitly converts this to a float array.
        /// </summary>
        public static explicit operator float[](vec3 v) => new [] { v.x, v.y, v.z };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](vec3 v) => new Object[] { v.x, v.y, v.z };

        #endregion


        #region Indexer
        
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
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_vec3 swizzle => new swizzle_vec3(x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public vec2 xy
        {
            get
            {
                return new vec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public vec2 xz
        {
            get
            {
                return new vec2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public vec2 yz
        {
            get
            {
                return new vec2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public vec3 xyz
        {
            get
            {
                return new vec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public vec2 rg
        {
            get
            {
                return new vec2(x, y);
            }
            set
            {
                x = value.x;
                y = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public vec2 rb
        {
            get
            {
                return new vec2(x, z);
            }
            set
            {
                x = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public vec2 gb
        {
            get
            {
                return new vec2(y, z);
            }
            set
            {
                y = value.x;
                z = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public vec3 rgb
        {
            get
            {
                return new vec3(x, y, z);
            }
            set
            {
                x = value.x;
                y = value.y;
                z = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public float r
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public float g
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        
        /// <summary>
        /// Gets or sets the specified RGBA component. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public float b
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public float[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;
        
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
        public float Length => (float)Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => ((x*x + y*y) + z*z);
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public float Sum => ((x + y) + z);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => ((Math.Abs(x) + Math.Abs(y)) + Math.Abs(z));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public vec3 Normalized => this / (float)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public vec3 NormalizedSafe => this == Zero ? Zero : this / (float)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static vec3 Zero { get; } = new vec3(0f, 0f, 0f);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static vec3 Ones { get; } = new vec3(1f, 1f, 1f);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static vec3 UnitX { get; } = new vec3(1f, 0f, 0f);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static vec3 UnitY { get; } = new vec3(0f, 1f, 0f);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static vec3 UnitZ { get; } = new vec3(0f, 0f, 1f);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static vec3 MaxValue { get; } = new vec3(float.MaxValue, float.MaxValue, float.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static vec3 MinValue { get; } = new vec3(float.MinValue, float.MinValue, float.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static vec3 Epsilon { get; } = new vec3(float.Epsilon, float.Epsilon, float.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static vec3 NaN { get; } = new vec3(float.NaN, float.NaN, float.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static vec3 NegativeInfinity { get; } = new vec3(float.NegativeInfinity, float.NegativeInfinity, float.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static vec3 PositiveInfinity { get; } = new vec3(float.PositiveInfinity, float.PositiveInfinity, float.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(vec3 lhs, vec3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(vec3 lhs, vec3 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
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
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public string ToString(string sep) => ((x + sep + y) + sep + z);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => ((x.ToString(provider) + sep + y.ToString(provider)) + sep + z.ToString(provider));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => ((x.ToString(format) + sep + y.ToString(format)) + sep + z.ToString(format));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => ((x.ToString(format, provider) + sep + y.ToString(format, provider)) + sep + z.ToString(format, provider));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(vec3 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is vec3 && Equals((vec3) obj);
        }
        
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
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(((Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p)) + Math.Pow((double)Math.Abs(z), p)), 1 / p);

        #endregion


        #region Static Functions
        
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
            float x = 0f, y = 0f, z = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), out x) && float.TryParse(kvp[1].Trim(), out y)) && float.TryParse(kvp[2].Trim(), out z));
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
            float x = 0f, y = 0f, z = 0f;
            var ok = ((float.TryParse(kvp[0].Trim(), style, provider, out x) && float.TryParse(kvp[1].Trim(), style, provider, out y)) && float.TryParse(kvp[2].Trim(), style, provider, out z));
            result = ok ? new vec3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(vec3 lhs, vec3 rhs, float eps = 0.1f) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat3x2 OuterProduct(vec2 c, vec3 r) => new mat3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat2x3 OuterProduct(vec3 c, vec2 r) => new mat2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat3 OuterProduct(vec3 c, vec3 r) => new mat3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat3x4 OuterProduct(vec4 c, vec3 r) => new mat3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat4x3 OuterProduct(vec3 c, vec4 r) => new mat4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(vec3 lhs, vec3 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(vec3 lhs, vec3 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(vec3 lhs, vec3 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec3 Reflect(vec3 I, vec3 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec3 Refract(vec3 I, vec3 N, float eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (float)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static vec3 FaceForward(vec3 N, vec3 I, vec3 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static vec3 Cross(vec3 l, vec3 r) => new vec3(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static vec3 Random(Random random) => new vec3((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static vec3 RandomSigned(Random random) => new vec3((float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0), (float)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static vec3 RandomNormal(Random random) => new vec3((float)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (float)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (float)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(vec3 lhs, vec3 rhs) => new bvec3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(vec3 lhs, float rhs) => new bvec3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(float lhs, vec3 rhs) => new bvec3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(float lhs, float rhs) => new bvec3(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(vec3 lhs, vec3 rhs) => new bvec3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(vec3 lhs, float rhs) => new bvec3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(float lhs, vec3 rhs) => new bvec3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(float lhs, float rhs) => new bvec3(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(vec3 lhs, vec3 rhs) => new bvec3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(vec3 lhs, float rhs) => new bvec3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(float lhs, vec3 rhs) => new bvec3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(float lhs, float rhs) => new bvec3(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(vec3 lhs, vec3 rhs) => new bvec3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(vec3 lhs, float rhs) => new bvec3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(float lhs, vec3 rhs) => new bvec3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(float lhs, float rhs) => new bvec3(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(vec3 lhs, vec3 rhs) => new bvec3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(vec3 lhs, float rhs) => new bvec3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(float lhs, vec3 rhs) => new bvec3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(float lhs, float rhs) => new bvec3(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(vec3 lhs, vec3 rhs) => new bvec3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(vec3 lhs, float rhs) => new bvec3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(float lhs, vec3 rhs) => new bvec3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(float lhs, float rhs) => new bvec3(lhs <= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsInfinity(vec3 v) => new bvec3(float.IsInfinity(v.x), float.IsInfinity(v.y), float.IsInfinity(v.z));
        
        /// <summary>
        /// Returns a bvec from the application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsInfinity(float v) => new bvec3(float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsFinite(vec3 v) => new bvec3(!float.IsNaN(v.x) && !float.IsInfinity(v.x), !float.IsNaN(v.y) && !float.IsInfinity(v.y), !float.IsNaN(v.z) && !float.IsInfinity(v.z));
        
        /// <summary>
        /// Returns a bvec from the application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsFinite(float v) => new bvec3(!float.IsNaN(v) && !float.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bvec3 IsNaN(vec3 v) => new bvec3(float.IsNaN(v.x), float.IsNaN(v.y), float.IsNaN(v.z));
        
        /// <summary>
        /// Returns a bvec from the application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bvec3 IsNaN(float v) => new bvec3(float.IsNaN(v));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec3 IsNegativeInfinity(vec3 v) => new bvec3(float.IsNegativeInfinity(v.x), float.IsNegativeInfinity(v.y), float.IsNegativeInfinity(v.z));
        
        /// <summary>
        /// Returns a bvec from the application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec3 IsNegativeInfinity(float v) => new bvec3(float.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec3 IsPositiveInfinity(vec3 v) => new bvec3(float.IsPositiveInfinity(v.x), float.IsPositiveInfinity(v.y), float.IsPositiveInfinity(v.z));
        
        /// <summary>
        /// Returns a bvec from the application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec3 IsPositiveInfinity(float v) => new bvec3(float.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static vec3 Abs(vec3 v) => new vec3(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z));
        
        /// <summary>
        /// Returns a vec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static vec3 Abs(float v) => new vec3(Math.Abs(v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static vec3 HermiteInterpolationOrder3(vec3 v) => new vec3((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z);
        
        /// <summary>
        /// Returns a vec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static vec3 HermiteInterpolationOrder3(float v) => new vec3((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static vec3 HermiteInterpolationOrder5(vec3 v) => new vec3(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a vec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static vec3 HermiteInterpolationOrder5(float v) => new vec3(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static vec3 Sqr(vec3 v) => new vec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a vec from the application of Sqr (v * v).
        /// </summary>
        public static vec3 Sqr(float v) => new vec3(v * v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static vec3 Pow2(vec3 v) => new vec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a vec from the application of Pow2 (v * v).
        /// </summary>
        public static vec3 Pow2(float v) => new vec3(v * v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static vec3 Pow3(vec3 v) => new vec3(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a vec from the application of Pow3 (v * v * v).
        /// </summary>
        public static vec3 Pow3(float v) => new vec3(v * v * v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static vec3 Step(vec3 v) => new vec3(v.x >= 0f ? 1f : 0f, v.y >= 0f ? 1f : 0f, v.z >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a vec from the application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static vec3 Step(float v) => new vec3(v >= 0f ? 1f : 0f);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sqrt ((float)Math.Sqrt((double)v)).
        /// </summary>
        public static vec3 Sqrt(vec3 v) => new vec3((float)Math.Sqrt((double)v.x), (float)Math.Sqrt((double)v.y), (float)Math.Sqrt((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Sqrt ((float)Math.Sqrt((double)v)).
        /// </summary>
        public static vec3 Sqrt(float v) => new vec3((float)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of InverseSqrt ((float)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static vec3 InverseSqrt(vec3 v) => new vec3((float)(1.0 / Math.Sqrt((double)v.x)), (float)(1.0 / Math.Sqrt((double)v.y)), (float)(1.0 / Math.Sqrt((double)v.z)));
        
        /// <summary>
        /// Returns a vec from the application of InverseSqrt ((float)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static vec3 InverseSqrt(float v) => new vec3((float)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(vec3 v) => new ivec3(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(float v) => new ivec3(Math.Sign(v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec3 Max(vec3 lhs, vec3 rhs) => new vec3(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec3 Max(vec3 lhs, float rhs) => new vec3(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec3 Max(float lhs, vec3 rhs) => new vec3(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z));
        
        /// <summary>
        /// Returns a vec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec3 Max(float lhs, float rhs) => new vec3(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec3 Min(vec3 lhs, vec3 rhs) => new vec3(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec3 Min(vec3 lhs, float rhs) => new vec3(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec3 Min(float lhs, vec3 rhs) => new vec3(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z));
        
        /// <summary>
        /// Returns a vec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec3 Min(float lhs, float rhs) => new vec3(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Pow(vec3 lhs, vec3 rhs) => new vec3((float)Math.Pow((double)lhs.x, (double)rhs.x), (float)Math.Pow((double)lhs.y, (double)rhs.y), (float)Math.Pow((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Pow(vec3 lhs, float rhs) => new vec3((float)Math.Pow((double)lhs.x, (double)rhs), (float)Math.Pow((double)lhs.y, (double)rhs), (float)Math.Pow((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Pow(float lhs, vec3 rhs) => new vec3((float)Math.Pow((double)lhs, (double)rhs.x), (float)Math.Pow((double)lhs, (double)rhs.y), (float)Math.Pow((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a vec from the application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Pow(float lhs, float rhs) => new vec3((float)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Log(vec3 lhs, vec3 rhs) => new vec3((float)Math.Log((double)lhs.x, (double)rhs.x), (float)Math.Log((double)lhs.y, (double)rhs.y), (float)Math.Log((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Log(vec3 lhs, float rhs) => new vec3((float)Math.Log((double)lhs.x, (double)rhs), (float)Math.Log((double)lhs.y, (double)rhs), (float)Math.Log((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Log(float lhs, vec3 rhs) => new vec3((float)Math.Log((double)lhs, (double)rhs.x), (float)Math.Log((double)lhs, (double)rhs.y), (float)Math.Log((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a vec from the application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Log(float lhs, float rhs) => new vec3((float)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec3 Clamp(vec3 v, vec3 min, vec3 max) => new vec3(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec3 Clamp(vec3 v, vec3 min, float max) => new vec3(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec3 Clamp(vec3 v, float min, vec3 max) => new vec3(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec3 Clamp(vec3 v, float min, float max) => new vec3(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec3 Clamp(float v, vec3 min, vec3 max) => new vec3(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec3 Clamp(float v, vec3 min, float max) => new vec3(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec3 Clamp(float v, float min, vec3 max) => new vec3(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z));
        
        /// <summary>
        /// Returns a vec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec3 Clamp(float v, float min, float max) => new vec3(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Mix(vec3 min, vec3 max, vec3 a) => new vec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Mix(vec3 min, vec3 max, float a) => new vec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Mix(vec3 min, float max, vec3 a) => new vec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Mix(vec3 min, float max, float a) => new vec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Mix(float min, vec3 max, vec3 a) => new vec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Mix(float min, vec3 max, float a) => new vec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Mix(float min, float max, vec3 a) => new vec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a vec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Mix(float min, float max, float a) => new vec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Lerp(vec3 min, vec3 max, vec3 a) => new vec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Lerp(vec3 min, vec3 max, float a) => new vec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Lerp(vec3 min, float max, vec3 a) => new vec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Lerp(vec3 min, float max, float a) => new vec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Lerp(float min, vec3 max, vec3 a) => new vec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Lerp(float min, vec3 max, float a) => new vec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Lerp(float min, float max, vec3 a) => new vec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a vec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Lerp(float min, float max, float a) => new vec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec3 Smoothstep(vec3 edge0, vec3 edge1, vec3 v) => new vec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec3 Smoothstep(vec3 edge0, vec3 edge1, float v) => new vec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec3 Smoothstep(vec3 edge0, float edge1, vec3 v) => new vec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec3 Smoothstep(vec3 edge0, float edge1, float v) => new vec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec3 Smoothstep(float edge0, vec3 edge1, vec3 v) => new vec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec3 Smoothstep(float edge0, vec3 edge1, float v) => new vec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec3 Smoothstep(float edge0, float edge1, vec3 v) => new vec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec3 Smoothstep(float edge0, float edge1, float v) => new vec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec3 Smootherstep(vec3 edge0, vec3 edge1, vec3 v) => new vec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec3 Smootherstep(vec3 edge0, vec3 edge1, float v) => new vec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec3 Smootherstep(vec3 edge0, float edge1, vec3 v) => new vec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec3 Smootherstep(vec3 edge0, float edge1, float v) => new vec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec3 Smootherstep(float edge0, vec3 edge1, vec3 v) => new vec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec3 Smootherstep(float edge0, vec3 edge1, float v) => new vec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec3 Smootherstep(float edge0, float edge1, vec3 v) => new vec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec3 Smootherstep(float edge0, float edge1, float v) => new vec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec3 Fma(vec3 a, vec3 b, vec3 c) => new vec3(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec3 Fma(vec3 a, vec3 b, float c) => new vec3(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec3 Fma(vec3 a, float b, vec3 c) => new vec3(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec3 Fma(vec3 a, float b, float c) => new vec3(a.x * b + c, a.y * b + c, a.z * b + c);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec3 Fma(float a, vec3 b, vec3 c) => new vec3(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec3 Fma(float a, vec3 b, float c) => new vec3(a * b.x + c, a * b.y + c, a * b.z + c);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec3 Fma(float a, float b, vec3 c) => new vec3(a * b + c.x, a * b + c.y, a * b + c.z);
        
        /// <summary>
        /// Returns a vec from the application of Fma (a * b + c).
        /// </summary>
        public static vec3 Fma(float a, float b, float c) => new vec3(a * b + c);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec3 Add(vec3 lhs, vec3 rhs) => new vec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec3 Add(vec3 lhs, float rhs) => new vec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec3 Add(float lhs, vec3 rhs) => new vec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a vec from the application of Add (lhs + rhs).
        /// </summary>
        public static vec3 Add(float lhs, float rhs) => new vec3(lhs + rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec3 Sub(vec3 lhs, vec3 rhs) => new vec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec3 Sub(vec3 lhs, float rhs) => new vec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec3 Sub(float lhs, vec3 rhs) => new vec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a vec from the application of Sub (lhs - rhs).
        /// </summary>
        public static vec3 Sub(float lhs, float rhs) => new vec3(lhs - rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec3 Mul(vec3 lhs, vec3 rhs) => new vec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec3 Mul(vec3 lhs, float rhs) => new vec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec3 Mul(float lhs, vec3 rhs) => new vec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a vec from the application of Mul (lhs * rhs).
        /// </summary>
        public static vec3 Mul(float lhs, float rhs) => new vec3(lhs * rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec3 Div(vec3 lhs, vec3 rhs) => new vec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec3 Div(vec3 lhs, float rhs) => new vec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec3 Div(float lhs, vec3 rhs) => new vec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a vec from the application of Div (lhs / rhs).
        /// </summary>
        public static vec3 Div(float lhs, float rhs) => new vec3(lhs / rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec3 Modulo(vec3 lhs, vec3 rhs) => new vec3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec3 Modulo(vec3 lhs, float rhs) => new vec3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec3 Modulo(float lhs, vec3 rhs) => new vec3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);
        
        /// <summary>
        /// Returns a vec from the application of Modulo (lhs % rhs).
        /// </summary>
        public static vec3 Modulo(float lhs, float rhs) => new vec3(lhs % rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static vec3 Degrees(vec3 v) => new vec3((float)(v.x * 57.295779513082320876798154814105170332405472466564321f), (float)(v.y * 57.295779513082320876798154814105170332405472466564321f), (float)(v.z * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a vec from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static vec3 Degrees(float v) => new vec3((float)(v * 57.295779513082320876798154814105170332405472466564321f));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static vec3 Radians(vec3 v) => new vec3((float)(v.x * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.y * 0.0174532925199432957692369076848861271344287188854172f), (float)(v.z * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a vec from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static vec3 Radians(float v) => new vec3((float)(v * 0.0174532925199432957692369076848861271344287188854172f));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Acos ((float)Math.Acos((double)v)).
        /// </summary>
        public static vec3 Acos(vec3 v) => new vec3((float)Math.Acos((double)v.x), (float)Math.Acos((double)v.y), (float)Math.Acos((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Acos ((float)Math.Acos((double)v)).
        /// </summary>
        public static vec3 Acos(float v) => new vec3((float)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Asin ((float)Math.Asin((double)v)).
        /// </summary>
        public static vec3 Asin(vec3 v) => new vec3((float)Math.Asin((double)v.x), (float)Math.Asin((double)v.y), (float)Math.Asin((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Asin ((float)Math.Asin((double)v)).
        /// </summary>
        public static vec3 Asin(float v) => new vec3((float)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Atan ((float)Math.Atan((double)v)).
        /// </summary>
        public static vec3 Atan(vec3 v) => new vec3((float)Math.Atan((double)v.x), (float)Math.Atan((double)v.y), (float)Math.Atan((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Atan ((float)Math.Atan((double)v)).
        /// </summary>
        public static vec3 Atan(float v) => new vec3((float)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Cos ((float)Math.Cos((double)v)).
        /// </summary>
        public static vec3 Cos(vec3 v) => new vec3((float)Math.Cos((double)v.x), (float)Math.Cos((double)v.y), (float)Math.Cos((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Cos ((float)Math.Cos((double)v)).
        /// </summary>
        public static vec3 Cos(float v) => new vec3((float)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Cosh ((float)Math.Cosh((double)v)).
        /// </summary>
        public static vec3 Cosh(vec3 v) => new vec3((float)Math.Cosh((double)v.x), (float)Math.Cosh((double)v.y), (float)Math.Cosh((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Cosh ((float)Math.Cosh((double)v)).
        /// </summary>
        public static vec3 Cosh(float v) => new vec3((float)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Exp ((float)Math.Exp((double)v)).
        /// </summary>
        public static vec3 Exp(vec3 v) => new vec3((float)Math.Exp((double)v.x), (float)Math.Exp((double)v.y), (float)Math.Exp((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Exp ((float)Math.Exp((double)v)).
        /// </summary>
        public static vec3 Exp(float v) => new vec3((float)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log ((float)Math.Log((double)v)).
        /// </summary>
        public static vec3 Log(vec3 v) => new vec3((float)Math.Log((double)v.x), (float)Math.Log((double)v.y), (float)Math.Log((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Log ((float)Math.Log((double)v)).
        /// </summary>
        public static vec3 Log(float v) => new vec3((float)Math.Log((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log2 ((float)Math.Log((double)v, 2)).
        /// </summary>
        public static vec3 Log2(vec3 v) => new vec3((float)Math.Log((double)v.x, 2), (float)Math.Log((double)v.y, 2), (float)Math.Log((double)v.z, 2));
        
        /// <summary>
        /// Returns a vec from the application of Log2 ((float)Math.Log((double)v, 2)).
        /// </summary>
        public static vec3 Log2(float v) => new vec3((float)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log10 ((float)Math.Log10((double)v)).
        /// </summary>
        public static vec3 Log10(vec3 v) => new vec3((float)Math.Log10((double)v.x), (float)Math.Log10((double)v.y), (float)Math.Log10((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Log10 ((float)Math.Log10((double)v)).
        /// </summary>
        public static vec3 Log10(float v) => new vec3((float)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Floor ((float)Math.Floor(v)).
        /// </summary>
        public static vec3 Floor(vec3 v) => new vec3((float)Math.Floor(v.x), (float)Math.Floor(v.y), (float)Math.Floor(v.z));
        
        /// <summary>
        /// Returns a vec from the application of Floor ((float)Math.Floor(v)).
        /// </summary>
        public static vec3 Floor(float v) => new vec3((float)Math.Floor(v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Ceiling ((float)Math.Ceiling(v)).
        /// </summary>
        public static vec3 Ceiling(vec3 v) => new vec3((float)Math.Ceiling(v.x), (float)Math.Ceiling(v.y), (float)Math.Ceiling(v.z));
        
        /// <summary>
        /// Returns a vec from the application of Ceiling ((float)Math.Ceiling(v)).
        /// </summary>
        public static vec3 Ceiling(float v) => new vec3((float)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Round ((float)Math.Round(v)).
        /// </summary>
        public static vec3 Round(vec3 v) => new vec3((float)Math.Round(v.x), (float)Math.Round(v.y), (float)Math.Round(v.z));
        
        /// <summary>
        /// Returns a vec from the application of Round ((float)Math.Round(v)).
        /// </summary>
        public static vec3 Round(float v) => new vec3((float)Math.Round(v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sin ((float)Math.Sin((double)v)).
        /// </summary>
        public static vec3 Sin(vec3 v) => new vec3((float)Math.Sin((double)v.x), (float)Math.Sin((double)v.y), (float)Math.Sin((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Sin ((float)Math.Sin((double)v)).
        /// </summary>
        public static vec3 Sin(float v) => new vec3((float)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sinh ((float)Math.Sinh((double)v)).
        /// </summary>
        public static vec3 Sinh(vec3 v) => new vec3((float)Math.Sinh((double)v.x), (float)Math.Sinh((double)v.y), (float)Math.Sinh((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Sinh ((float)Math.Sinh((double)v)).
        /// </summary>
        public static vec3 Sinh(float v) => new vec3((float)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Tan ((float)Math.Tan((double)v)).
        /// </summary>
        public static vec3 Tan(vec3 v) => new vec3((float)Math.Tan((double)v.x), (float)Math.Tan((double)v.y), (float)Math.Tan((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Tan ((float)Math.Tan((double)v)).
        /// </summary>
        public static vec3 Tan(float v) => new vec3((float)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Tanh ((float)Math.Tanh((double)v)).
        /// </summary>
        public static vec3 Tanh(vec3 v) => new vec3((float)Math.Tanh((double)v.x), (float)Math.Tanh((double)v.y), (float)Math.Tanh((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Tanh ((float)Math.Tanh((double)v)).
        /// </summary>
        public static vec3 Tanh(float v) => new vec3((float)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Truncate ((float)Math.Truncate((double)v)).
        /// </summary>
        public static vec3 Truncate(vec3 v) => new vec3((float)Math.Truncate((double)v.x), (float)Math.Truncate((double)v.y), (float)Math.Truncate((double)v.z));
        
        /// <summary>
        /// Returns a vec from the application of Truncate ((float)Math.Truncate((double)v)).
        /// </summary>
        public static vec3 Truncate(float v) => new vec3((float)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fract ((float)(v - Math.Floor(v))).
        /// </summary>
        public static vec3 Fract(vec3 v) => new vec3((float)(v.x - Math.Floor(v.x)), (float)(v.y - Math.Floor(v.y)), (float)(v.z - Math.Floor(v.z)));
        
        /// <summary>
        /// Returns a vec from the application of Fract ((float)(v - Math.Floor(v))).
        /// </summary>
        public static vec3 Fract(float v) => new vec3((float)(v - Math.Floor(v)));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static vec3 Trunc(vec3 v) => new vec3((long)(v.x), (long)(v.y), (long)(v.z));
        
        /// <summary>
        /// Returns a vec from the application of Trunc ((long)(v)).
        /// </summary>
        public static vec3 Trunc(float v) => new vec3((long)(v));
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 Random(Random random, vec3 minValue, vec3 maxValue) => new vec3((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 Random(Random random, vec3 minValue, float maxValue) => new vec3((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 Random(Random random, float minValue, vec3 maxValue) => new vec3((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue, (float)random.NextDouble() * (maxValue.z - minValue) + minValue);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 Random(Random random, float minValue, float maxValue) => new vec3((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 RandomUniform(Random random, vec3 minValue, vec3 maxValue) => new vec3((float)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 RandomUniform(Random random, vec3 minValue, float maxValue) => new vec3((float)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (float)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (float)random.NextDouble() * (maxValue - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 RandomUniform(Random random, float minValue, vec3 maxValue) => new vec3((float)random.NextDouble() * (maxValue.x - minValue) + minValue, (float)random.NextDouble() * (maxValue.y - minValue) + minValue, (float)random.NextDouble() * (maxValue.z - minValue) + minValue);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 RandomUniform(Random random, float minValue, float maxValue) => new vec3((float)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomNormal(Random random, vec3 mean, vec3 variance) => new vec3((float)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (float)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (float)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomNormal(Random random, vec3 mean, float variance) => new vec3((float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomNormal(Random random, float mean, vec3 variance) => new vec3((float)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomNormal(Random random, float mean, float variance) => new vec3((float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomGaussian(Random random, vec3 mean, vec3 variance) => new vec3((float)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (float)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (float)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomGaussian(Random random, vec3 mean, float variance) => new vec3((float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomGaussian(Random random, float mean, vec3 variance) => new vec3((float)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (float)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomGaussian(Random random, float mean, float variance) => new vec3((float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec3 operator<(vec3 lhs, vec3 rhs) => new bvec3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec3 operator<(vec3 lhs, float rhs) => new bvec3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec3 operator<(float lhs, vec3 rhs) => new bvec3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 operator<=(vec3 lhs, vec3 rhs) => new bvec3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 operator<=(vec3 lhs, float rhs) => new bvec3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 operator<=(float lhs, vec3 rhs) => new bvec3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec3 operator>(vec3 lhs, vec3 rhs) => new bvec3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec3 operator>(vec3 lhs, float rhs) => new bvec3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec3 operator>(float lhs, vec3 rhs) => new bvec3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 operator>=(vec3 lhs, vec3 rhs) => new bvec3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 operator>=(vec3 lhs, float rhs) => new bvec3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 operator>=(float lhs, vec3 rhs) => new bvec3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static vec3 operator+(vec3 lhs, vec3 rhs) => new vec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static vec3 operator+(vec3 lhs, float rhs) => new vec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static vec3 operator+(float lhs, vec3 rhs) => new vec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static vec3 operator-(vec3 lhs, vec3 rhs) => new vec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static vec3 operator-(vec3 lhs, float rhs) => new vec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static vec3 operator-(float lhs, vec3 rhs) => new vec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static vec3 operator*(vec3 lhs, vec3 rhs) => new vec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static vec3 operator*(vec3 lhs, float rhs) => new vec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static vec3 operator*(float lhs, vec3 rhs) => new vec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static vec3 operator/(vec3 lhs, vec3 rhs) => new vec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static vec3 operator/(vec3 lhs, float rhs) => new vec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static vec3 operator/(float lhs, vec3 rhs) => new vec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator+ (identity).
        /// </summary>
        public static vec3 operator+(vec3 v) => v;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator- (-v).
        /// </summary>
        public static vec3 operator-(vec3 v) => new vec3(-v.x, -v.y, -v.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static vec3 operator%(vec3 lhs, vec3 rhs) => new vec3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static vec3 operator%(vec3 lhs, float rhs) => new vec3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static vec3 operator%(float lhs, vec3 rhs) => new vec3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);

        #endregion

    }
}
