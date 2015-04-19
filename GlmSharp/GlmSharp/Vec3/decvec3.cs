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
    /// A vector of type decimal with 3 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct decvec3 : IReadOnlyList<decimal>, IEquatable<decvec3>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public decimal x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public decimal y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public decimal z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public decvec3(decimal x, decimal y, decimal z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public decvec3(decimal v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public decvec3(decvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0m;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public decvec3(decvec2 v, decimal z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public decvec3(decvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public decvec3(decvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec3(IReadOnlyList<decimal> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0m : v[0];
            this.y = c < 1 ? 0m : v[1];
            this.z = c < 2 ? 0m : v[2];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec3(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0m : (decimal)v[0];
            this.y = c < 1 ? 0m : (decimal)v[1];
            this.z = c < 2 ? 0m : (decimal)v[2];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec3(decimal[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0m : v[0];
            this.y = c < 1 ? 0m : v[1];
            this.z = c < 2 ? 0m : v[2];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec3(decimal[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0m : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0m : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0m : v[2 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec3(IEnumerable<decimal> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(decvec3 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(decvec3 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(decvec3 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(decvec3 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(decvec3 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(decvec3 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, 0u);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(decvec3 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(decvec3 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(decvec3 v) => new vec4((float)v.x, (float)v.y, (float)v.z, 0f);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(decvec3 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3.
        /// </summary>
        public static explicit operator hvec3(decvec3 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
        /// <summary>
        /// Explicitly converts this to a hvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator hvec4(decvec3 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(decvec3 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(decvec3 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(decvec3 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(decvec3 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(decvec3 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, 0m);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(decvec3 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(decvec3 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(decvec3 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(decvec3 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(decvec3 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(decvec3 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(decvec3 v) => new bvec2(v.x != 0m, v.y != 0m);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(decvec3 v) => new bvec3(v.x != 0m, v.y != 0m, v.z != 0m);
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(decvec3 v) => new bvec4(v.x != 0m, v.y != 0m, v.z != 0m, false);
        
        /// <summary>
        /// Explicitly converts this to a decimal array.
        /// </summary>
        public static explicit operator decimal[](decvec3 v) => new [] { v.x, v.y, v.z };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](decvec3 v) => new Object[] { v.x, v.y, v.z };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public decimal this[int index]
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
        public swizzle_decvec3 swizzle => new swizzle_decvec3(x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public decvec2 xy
        {
            get
            {
                return new decvec2(x, y);
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
        public decvec2 xz
        {
            get
            {
                return new decvec2(x, z);
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
        public decvec2 yz
        {
            get
            {
                return new decvec2(y, z);
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
        public decvec3 xyz
        {
            get
            {
                return new decvec3(x, y, z);
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
        public decvec2 rg
        {
            get
            {
                return new decvec2(x, y);
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
        public decvec2 rb
        {
            get
            {
                return new decvec2(x, z);
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
        public decvec2 gb
        {
            get
            {
                return new decvec2(y, z);
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
        public decvec3 rgb
        {
            get
            {
                return new decvec3(x, y, z);
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
        public decimal r
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
        public decimal g
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
        public decimal b
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
        public decimal[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public decimal MinElement => Math.Min(Math.Min(x, y), z);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public decimal MaxElement => Math.Max(Math.Max(x, y), z);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public decimal Length => (decimal)(((x*x + y*y) + z*z)).Sqrt();
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public decimal LengthSqr => ((x*x + y*y) + z*z);
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public decimal Sum => ((x + y) + z);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public decimal Norm => (decimal)(((x*x + y*y) + z*z)).Sqrt();
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public decimal Norm1 => ((Math.Abs(x) + Math.Abs(y)) + Math.Abs(z));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public decimal Norm2 => (decimal)(((x*x + y*y) + z*z)).Sqrt();
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public decimal NormMax => Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public decvec3 Normalized => this / (decimal)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public decvec3 NormalizedSafe => this == Zero ? Zero : this / (decimal)Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static decvec3 Zero { get; } = new decvec3(0m, 0m, 0m);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static decvec3 Ones { get; } = new decvec3(1m, 1m, 1m);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static decvec3 UnitX { get; } = new decvec3(1m, 0m, 0m);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static decvec3 UnitY { get; } = new decvec3(0m, 1m, 0m);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static decvec3 UnitZ { get; } = new decvec3(0m, 0m, 1m);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static decvec3 MaxValue { get; } = new decvec3(decimal.MaxValue, decimal.MaxValue, decimal.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static decvec3 MinValue { get; } = new decvec3(decimal.MinValue, decimal.MinValue, decimal.MinValue);
        
        /// <summary>
        /// Predefined all-MinusOne vector
        /// </summary>
        public static decvec3 MinusOne { get; } = new decvec3(decimal.MinusOne, decimal.MinusOne, decimal.MinusOne);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(decvec3 lhs, decvec3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(decvec3 lhs, decvec3 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<decimal> GetEnumerator()
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
        public bool Equals(decvec3 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is decvec3 && Equals((decvec3) obj);
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
        public static decvec3 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static decvec3 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new decvec3(decimal.Parse(kvp[0].Trim()), decimal.Parse(kvp[1].Trim()), decimal.Parse(kvp[2].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static decvec3 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new decvec3(decimal.Parse(kvp[0].Trim(), provider), decimal.Parse(kvp[1].Trim(), provider), decimal.Parse(kvp[2].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static decvec3 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new decvec3(decimal.Parse(kvp[0].Trim(), style), decimal.Parse(kvp[1].Trim(), style), decimal.Parse(kvp[2].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static decvec3 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new decvec3(decimal.Parse(kvp[0].Trim(), style, provider), decimal.Parse(kvp[1].Trim(), style, provider), decimal.Parse(kvp[2].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out decvec3 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out decvec3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            decimal x = 0m, y = 0m, z = 0m;
            var ok = ((decimal.TryParse(kvp[0].Trim(), out x) && decimal.TryParse(kvp[1].Trim(), out y)) && decimal.TryParse(kvp[2].Trim(), out z));
            result = ok ? new decvec3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out decvec3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            decimal x = 0m, y = 0m, z = 0m;
            var ok = ((decimal.TryParse(kvp[0].Trim(), style, provider, out x) && decimal.TryParse(kvp[1].Trim(), style, provider, out y)) && decimal.TryParse(kvp[2].Trim(), style, provider, out z));
            result = ok ? new decvec3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(decvec3 lhs, decvec3 rhs, decimal eps = 0.1m) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat3x2 OuterProduct(decvec2 c, decvec3 r) => new decmat3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat2x3 OuterProduct(decvec3 c, decvec2 r) => new decmat2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat3 OuterProduct(decvec3 c, decvec3 r) => new decmat3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat3x4 OuterProduct(decvec4 c, decvec3 r) => new decmat3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat4x3 OuterProduct(decvec3 c, decvec4 r) => new decmat4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static decimal Dot(decvec3 lhs, decvec3 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static decimal Distance(decvec3 lhs, decvec3 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static decimal DistanceSqr(decvec3 lhs, decvec3 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec3 Reflect(decvec3 I, decvec3 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec3 Refract(decvec3 I, decvec3 N, decimal eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (decimal)(k).Sqrt()) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static decvec3 FaceForward(decvec3 N, decvec3 I, decvec3 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static decvec3 Cross(decvec3 l, decvec3 r) => new decvec3(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static decvec3 Random(Random random) => new decvec3((decimal)random.NextDouble(), (decimal)random.NextDouble(), (decimal)random.NextDouble());
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static decvec3 RandomSigned(Random random) => new decvec3((decimal)(random.NextDouble() * 2.0 - 1.0), (decimal)(random.NextDouble() * 2.0 - 1.0), (decimal)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static decvec3 RandomNormal(Random random) => new decvec3((decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(decvec3 lhs, decimal rhs) => new bvec3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(decimal lhs, decvec3 rhs) => new bvec3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(decimal lhs, decimal rhs) => new bvec3(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(decvec3 lhs, decimal rhs) => new bvec3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(decimal lhs, decvec3 rhs) => new bvec3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(decimal lhs, decimal rhs) => new bvec3(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(decvec3 lhs, decimal rhs) => new bvec3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(decimal lhs, decvec3 rhs) => new bvec3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(decimal lhs, decimal rhs) => new bvec3(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(decvec3 lhs, decimal rhs) => new bvec3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(decimal lhs, decvec3 rhs) => new bvec3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(decimal lhs, decimal rhs) => new bvec3(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(decvec3 lhs, decimal rhs) => new bvec3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(decimal lhs, decvec3 rhs) => new bvec3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(decimal lhs, decimal rhs) => new bvec3(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(decvec3 lhs, decimal rhs) => new bvec3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(decimal lhs, decvec3 rhs) => new bvec3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(decimal lhs, decimal rhs) => new bvec3(lhs <= rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec3 Abs(decvec3 v) => new decvec3(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec3 Abs(decimal v) => new decvec3(Math.Abs(v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec3 HermiteInterpolationOrder3(decvec3 v) => new decvec3((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z);
        
        /// <summary>
        /// Returns a decvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec3 HermiteInterpolationOrder3(decimal v) => new decvec3((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec3 HermiteInterpolationOrder5(decvec3 v) => new decvec3(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a decvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec3 HermiteInterpolationOrder5(decimal v) => new decvec3(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static decvec3 Sqr(decvec3 v) => new decvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a decvec from the application of Sqr (v * v).
        /// </summary>
        public static decvec3 Sqr(decimal v) => new decvec3(v * v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static decvec3 Pow2(decvec3 v) => new decvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a decvec from the application of Pow2 (v * v).
        /// </summary>
        public static decvec3 Pow2(decimal v) => new decvec3(v * v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static decvec3 Pow3(decvec3 v) => new decvec3(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a decvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static decvec3 Pow3(decimal v) => new decvec3(v * v * v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec3 Step(decvec3 v) => new decvec3(v.x >= 0m ? 1m : 0m, v.y >= 0m ? 1m : 0m, v.z >= 0m ? 1m : 0m);
        
        /// <summary>
        /// Returns a decvec from the application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec3 Step(decimal v) => new decvec3(v >= 0m ? 1m : 0m);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec3 Sqrt(decvec3 v) => new decvec3((decimal)Math.Sqrt((double)v.x), (decimal)Math.Sqrt((double)v.y), (decimal)Math.Sqrt((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec3 Sqrt(decimal v) => new decvec3((decimal)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec3 InverseSqrt(decvec3 v) => new decvec3((decimal)(1.0 / Math.Sqrt((double)v.x)), (decimal)(1.0 / Math.Sqrt((double)v.y)), (decimal)(1.0 / Math.Sqrt((double)v.z)));
        
        /// <summary>
        /// Returns a decvec from the application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec3 InverseSqrt(decimal v) => new decvec3((decimal)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(decvec3 v) => new ivec3(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(decimal v) => new ivec3(Math.Sign(v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec3 Max(decvec3 lhs, decvec3 rhs) => new decvec3(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec3 Max(decvec3 lhs, decimal rhs) => new decvec3(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec3 Max(decimal lhs, decvec3 rhs) => new decvec3(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z));
        
        /// <summary>
        /// Returns a decvec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec3 Max(decimal lhs, decimal rhs) => new decvec3(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec3 Min(decvec3 lhs, decvec3 rhs) => new decvec3(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec3 Min(decvec3 lhs, decimal rhs) => new decvec3(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec3 Min(decimal lhs, decvec3 rhs) => new decvec3(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z));
        
        /// <summary>
        /// Returns a decvec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec3 Min(decimal lhs, decimal rhs) => new decvec3(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Pow(decvec3 lhs, decvec3 rhs) => new decvec3((decimal)Math.Pow((double)lhs.x, (double)rhs.x), (decimal)Math.Pow((double)lhs.y, (double)rhs.y), (decimal)Math.Pow((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Pow(decvec3 lhs, decimal rhs) => new decvec3((decimal)Math.Pow((double)lhs.x, (double)rhs), (decimal)Math.Pow((double)lhs.y, (double)rhs), (decimal)Math.Pow((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Pow(decimal lhs, decvec3 rhs) => new decvec3((decimal)Math.Pow((double)lhs, (double)rhs.x), (decimal)Math.Pow((double)lhs, (double)rhs.y), (decimal)Math.Pow((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a decvec from the application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Pow(decimal lhs, decimal rhs) => new decvec3((decimal)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Log(decvec3 lhs, decvec3 rhs) => new decvec3((decimal)Math.Log((double)lhs.x, (double)rhs.x), (decimal)Math.Log((double)lhs.y, (double)rhs.y), (decimal)Math.Log((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Log(decvec3 lhs, decimal rhs) => new decvec3((decimal)Math.Log((double)lhs.x, (double)rhs), (decimal)Math.Log((double)lhs.y, (double)rhs), (decimal)Math.Log((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Log(decimal lhs, decvec3 rhs) => new decvec3((decimal)Math.Log((double)lhs, (double)rhs.x), (decimal)Math.Log((double)lhs, (double)rhs.y), (decimal)Math.Log((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a decvec from the application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Log(decimal lhs, decimal rhs) => new decvec3((decimal)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec3 Clamp(decvec3 v, decvec3 min, decvec3 max) => new decvec3(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec3 Clamp(decvec3 v, decvec3 min, decimal max) => new decvec3(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec3 Clamp(decvec3 v, decimal min, decvec3 max) => new decvec3(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec3 Clamp(decvec3 v, decimal min, decimal max) => new decvec3(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec3 Clamp(decimal v, decvec3 min, decvec3 max) => new decvec3(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec3 Clamp(decimal v, decvec3 min, decimal max) => new decvec3(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec3 Clamp(decimal v, decimal min, decvec3 max) => new decvec3(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z));
        
        /// <summary>
        /// Returns a decvec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec3 Clamp(decimal v, decimal min, decimal max) => new decvec3(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Mix(decvec3 min, decvec3 max, decvec3 a) => new decvec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Mix(decvec3 min, decvec3 max, decimal a) => new decvec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Mix(decvec3 min, decimal max, decvec3 a) => new decvec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Mix(decvec3 min, decimal max, decimal a) => new decvec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Mix(decimal min, decvec3 max, decvec3 a) => new decvec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Mix(decimal min, decvec3 max, decimal a) => new decvec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Mix(decimal min, decimal max, decvec3 a) => new decvec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a decvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Mix(decimal min, decimal max, decimal a) => new decvec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Lerp(decvec3 min, decvec3 max, decvec3 a) => new decvec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Lerp(decvec3 min, decvec3 max, decimal a) => new decvec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Lerp(decvec3 min, decimal max, decvec3 a) => new decvec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Lerp(decvec3 min, decimal max, decimal a) => new decvec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Lerp(decimal min, decvec3 max, decvec3 a) => new decvec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Lerp(decimal min, decvec3 max, decimal a) => new decvec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Lerp(decimal min, decimal max, decvec3 a) => new decvec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a decvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Lerp(decimal min, decimal max, decimal a) => new decvec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec3 Smoothstep(decvec3 edge0, decvec3 edge1, decvec3 v) => new decvec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec3 Smoothstep(decvec3 edge0, decvec3 edge1, decimal v) => new decvec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec3 Smoothstep(decvec3 edge0, decimal edge1, decvec3 v) => new decvec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec3 Smoothstep(decvec3 edge0, decimal edge1, decimal v) => new decvec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec3 Smoothstep(decimal edge0, decvec3 edge1, decvec3 v) => new decvec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec3 Smoothstep(decimal edge0, decvec3 edge1, decimal v) => new decvec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec3 Smoothstep(decimal edge0, decimal edge1, decvec3 v) => new decvec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec3 Smoothstep(decimal edge0, decimal edge1, decimal v) => new decvec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec3 Smootherstep(decvec3 edge0, decvec3 edge1, decvec3 v) => new decvec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec3 Smootherstep(decvec3 edge0, decvec3 edge1, decimal v) => new decvec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec3 Smootherstep(decvec3 edge0, decimal edge1, decvec3 v) => new decvec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec3 Smootherstep(decvec3 edge0, decimal edge1, decimal v) => new decvec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec3 Smootherstep(decimal edge0, decvec3 edge1, decvec3 v) => new decvec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec3 Smootherstep(decimal edge0, decvec3 edge1, decimal v) => new decvec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec3 Smootherstep(decimal edge0, decimal edge1, decvec3 v) => new decvec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec3 Smootherstep(decimal edge0, decimal edge1, decimal v) => new decvec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec3 Fma(decvec3 a, decvec3 b, decvec3 c) => new decvec3(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec3 Fma(decvec3 a, decvec3 b, decimal c) => new decvec3(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec3 Fma(decvec3 a, decimal b, decvec3 c) => new decvec3(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec3 Fma(decvec3 a, decimal b, decimal c) => new decvec3(a.x * b + c, a.y * b + c, a.z * b + c);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec3 Fma(decimal a, decvec3 b, decvec3 c) => new decvec3(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec3 Fma(decimal a, decvec3 b, decimal c) => new decvec3(a * b.x + c, a * b.y + c, a * b.z + c);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec3 Fma(decimal a, decimal b, decvec3 c) => new decvec3(a * b + c.x, a * b + c.y, a * b + c.z);
        
        /// <summary>
        /// Returns a decvec from the application of Fma (a * b + c).
        /// </summary>
        public static decvec3 Fma(decimal a, decimal b, decimal c) => new decvec3(a * b + c);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec3 Add(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec3 Add(decvec3 lhs, decimal rhs) => new decvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec3 Add(decimal lhs, decvec3 rhs) => new decvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a decvec from the application of Add (lhs + rhs).
        /// </summary>
        public static decvec3 Add(decimal lhs, decimal rhs) => new decvec3(lhs + rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec3 Sub(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec3 Sub(decvec3 lhs, decimal rhs) => new decvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec3 Sub(decimal lhs, decvec3 rhs) => new decvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a decvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static decvec3 Sub(decimal lhs, decimal rhs) => new decvec3(lhs - rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec3 Mul(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec3 Mul(decvec3 lhs, decimal rhs) => new decvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec3 Mul(decimal lhs, decvec3 rhs) => new decvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a decvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static decvec3 Mul(decimal lhs, decimal rhs) => new decvec3(lhs * rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec3 Div(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec3 Div(decvec3 lhs, decimal rhs) => new decvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec3 Div(decimal lhs, decvec3 rhs) => new decvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a decvec from the application of Div (lhs / rhs).
        /// </summary>
        public static decvec3 Div(decimal lhs, decimal rhs) => new decvec3(lhs / rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec3 Modulo(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec3 Modulo(decvec3 lhs, decimal rhs) => new decvec3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec3 Modulo(decimal lhs, decvec3 rhs) => new decvec3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);
        
        /// <summary>
        /// Returns a decvec from the application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec3 Modulo(decimal lhs, decimal rhs) => new decvec3(lhs % rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec3 Degrees(decvec3 v) => new decvec3((decimal)(v.x * 57.295779513082320876798154814105170332405472466564321m), (decimal)(v.y * 57.295779513082320876798154814105170332405472466564321m), (decimal)(v.z * 57.295779513082320876798154814105170332405472466564321m));
        
        /// <summary>
        /// Returns a decvec from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec3 Degrees(decimal v) => new decvec3((decimal)(v * 57.295779513082320876798154814105170332405472466564321m));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec3 Radians(decvec3 v) => new decvec3((decimal)(v.x * 0.0174532925199432957692369076848861271344287188854172m), (decimal)(v.y * 0.0174532925199432957692369076848861271344287188854172m), (decimal)(v.z * 0.0174532925199432957692369076848861271344287188854172m));
        
        /// <summary>
        /// Returns a decvec from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec3 Radians(decimal v) => new decvec3((decimal)(v * 0.0174532925199432957692369076848861271344287188854172m));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec3 Acos(decvec3 v) => new decvec3((decimal)Math.Acos((double)v.x), (decimal)Math.Acos((double)v.y), (decimal)Math.Acos((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec3 Acos(decimal v) => new decvec3((decimal)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec3 Asin(decvec3 v) => new decvec3((decimal)Math.Asin((double)v.x), (decimal)Math.Asin((double)v.y), (decimal)Math.Asin((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec3 Asin(decimal v) => new decvec3((decimal)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec3 Atan(decvec3 v) => new decvec3((decimal)Math.Atan((double)v.x), (decimal)Math.Atan((double)v.y), (decimal)Math.Atan((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec3 Atan(decimal v) => new decvec3((decimal)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec3 Cos(decvec3 v) => new decvec3((decimal)Math.Cos((double)v.x), (decimal)Math.Cos((double)v.y), (decimal)Math.Cos((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec3 Cos(decimal v) => new decvec3((decimal)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec3 Cosh(decvec3 v) => new decvec3((decimal)Math.Cosh((double)v.x), (decimal)Math.Cosh((double)v.y), (decimal)Math.Cosh((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec3 Cosh(decimal v) => new decvec3((decimal)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec3 Exp(decvec3 v) => new decvec3((decimal)Math.Exp((double)v.x), (decimal)Math.Exp((double)v.y), (decimal)Math.Exp((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec3 Exp(decimal v) => new decvec3((decimal)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec3 Log(decvec3 v) => new decvec3((decimal)Math.Log((double)v.x), (decimal)Math.Log((double)v.y), (decimal)Math.Log((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec3 Log(decimal v) => new decvec3((decimal)Math.Log((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec3 Log2(decvec3 v) => new decvec3((decimal)Math.Log((double)v.x, 2), (decimal)Math.Log((double)v.y, 2), (decimal)Math.Log((double)v.z, 2));
        
        /// <summary>
        /// Returns a decvec from the application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec3 Log2(decimal v) => new decvec3((decimal)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec3 Log10(decvec3 v) => new decvec3((decimal)Math.Log10((double)v.x), (decimal)Math.Log10((double)v.y), (decimal)Math.Log10((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec3 Log10(decimal v) => new decvec3((decimal)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec3 Floor(decvec3 v) => new decvec3((decimal)Math.Floor(v.x), (decimal)Math.Floor(v.y), (decimal)Math.Floor(v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec3 Floor(decimal v) => new decvec3((decimal)Math.Floor(v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec3 Ceiling(decvec3 v) => new decvec3((decimal)Math.Ceiling(v.x), (decimal)Math.Ceiling(v.y), (decimal)Math.Ceiling(v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec3 Ceiling(decimal v) => new decvec3((decimal)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec3 Round(decvec3 v) => new decvec3((decimal)Math.Round(v.x), (decimal)Math.Round(v.y), (decimal)Math.Round(v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec3 Round(decimal v) => new decvec3((decimal)Math.Round(v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec3 Sin(decvec3 v) => new decvec3((decimal)Math.Sin((double)v.x), (decimal)Math.Sin((double)v.y), (decimal)Math.Sin((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec3 Sin(decimal v) => new decvec3((decimal)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec3 Sinh(decvec3 v) => new decvec3((decimal)Math.Sinh((double)v.x), (decimal)Math.Sinh((double)v.y), (decimal)Math.Sinh((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec3 Sinh(decimal v) => new decvec3((decimal)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec3 Tan(decvec3 v) => new decvec3((decimal)Math.Tan((double)v.x), (decimal)Math.Tan((double)v.y), (decimal)Math.Tan((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec3 Tan(decimal v) => new decvec3((decimal)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec3 Tanh(decvec3 v) => new decvec3((decimal)Math.Tanh((double)v.x), (decimal)Math.Tanh((double)v.y), (decimal)Math.Tanh((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec3 Tanh(decimal v) => new decvec3((decimal)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec3 Truncate(decvec3 v) => new decvec3((decimal)Math.Truncate((double)v.x), (decimal)Math.Truncate((double)v.y), (decimal)Math.Truncate((double)v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec3 Truncate(decimal v) => new decvec3((decimal)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec3 Fract(decvec3 v) => new decvec3((decimal)(v.x - Math.Floor(v.x)), (decimal)(v.y - Math.Floor(v.y)), (decimal)(v.z - Math.Floor(v.z)));
        
        /// <summary>
        /// Returns a decvec from the application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec3 Fract(decimal v) => new decvec3((decimal)(v - Math.Floor(v)));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static decvec3 Trunc(decvec3 v) => new decvec3((long)(v.x), (long)(v.y), (long)(v.z));
        
        /// <summary>
        /// Returns a decvec from the application of Trunc ((long)(v)).
        /// </summary>
        public static decvec3 Trunc(decimal v) => new decvec3((long)(v));
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 Random(Random random, decvec3 minValue, decvec3 maxValue) => new decvec3((decimal)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (decimal)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 Random(Random random, decvec3 minValue, decimal maxValue) => new decvec3((decimal)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (decimal)random.NextDouble() * (maxValue - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 Random(Random random, decimal minValue, decvec3 maxValue) => new decvec3((decimal)random.NextDouble() * (maxValue.x - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.y - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.z - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 Random(Random random, decimal minValue, decimal maxValue) => new decvec3((decimal)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 RandomUniform(Random random, decvec3 minValue, decvec3 maxValue) => new decvec3((decimal)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y, (decimal)random.NextDouble() * (maxValue.z - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 RandomUniform(Random random, decvec3 minValue, decimal maxValue) => new decvec3((decimal)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue - minValue.y) + minValue.y, (decimal)random.NextDouble() * (maxValue - minValue.z) + minValue.z);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 RandomUniform(Random random, decimal minValue, decvec3 maxValue) => new decvec3((decimal)random.NextDouble() * (maxValue.x - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.y - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.z - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 RandomUniform(Random random, decimal minValue, decimal maxValue) => new decvec3((decimal)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomNormal(Random random, decvec3 mean, decvec3 variance) => new decvec3((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (decimal)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomNormal(Random random, decvec3 mean, decimal variance) => new decvec3((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomNormal(Random random, decimal mean, decvec3 variance) => new decvec3((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomNormal(Random random, decimal mean, decimal variance) => new decvec3((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomGaussian(Random random, decvec3 mean, decvec3 variance) => new decvec3((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (decimal)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomGaussian(Random random, decvec3 mean, decimal variance) => new decvec3((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.z);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomGaussian(Random random, decimal mean, decvec3 variance) => new decvec3((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.z) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomGaussian(Random random, decimal mean, decimal variance) => new decvec3((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec3 operator<(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec3 operator<(decvec3 lhs, decimal rhs) => new bvec3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec3 operator<(decimal lhs, decvec3 rhs) => new bvec3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 operator<=(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 operator<=(decvec3 lhs, decimal rhs) => new bvec3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 operator<=(decimal lhs, decvec3 rhs) => new bvec3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec3 operator>(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec3 operator>(decvec3 lhs, decimal rhs) => new bvec3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec3 operator>(decimal lhs, decvec3 rhs) => new bvec3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 operator>=(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 operator>=(decvec3 lhs, decimal rhs) => new bvec3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 operator>=(decimal lhs, decvec3 rhs) => new bvec3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decvec3 operator+(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decvec3 operator+(decvec3 lhs, decimal rhs) => new decvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decvec3 operator+(decimal lhs, decvec3 rhs) => new decvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decvec3 operator-(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decvec3 operator-(decvec3 lhs, decimal rhs) => new decvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decvec3 operator-(decimal lhs, decvec3 rhs) => new decvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decvec3 operator*(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decvec3 operator*(decvec3 lhs, decimal rhs) => new decvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decvec3 operator*(decimal lhs, decvec3 rhs) => new decvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decvec3 operator/(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decvec3 operator/(decvec3 lhs, decimal rhs) => new decvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decvec3 operator/(decimal lhs, decvec3 rhs) => new decvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator+ (identity).
        /// </summary>
        public static decvec3 operator+(decvec3 v) => v;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator- (-v).
        /// </summary>
        public static decvec3 operator-(decvec3 v) => new decvec3(-v.x, -v.y, -v.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static decvec3 operator%(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x % rhs.x, lhs.y % rhs.y, lhs.z % rhs.z);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static decvec3 operator%(decvec3 lhs, decimal rhs) => new decvec3(lhs.x % rhs, lhs.y % rhs, lhs.z % rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static decvec3 operator%(decimal lhs, decvec3 rhs) => new decvec3(lhs % rhs.x, lhs % rhs.y, lhs % rhs.z);

        #endregion

    }
}
