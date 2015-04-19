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
    /// A vector of type uint with 3 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct uvec3 : IReadOnlyList<uint>, IEquatable<uvec3>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public uint x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public uint y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public uint z;

        #endregion


        #region Constructors
        
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
            this.z = 0u;
        }
        
        /// <summary>
        /// from-vector-and-value constructor
        /// </summary>
        public uvec3(uvec2 v, uint z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public uvec3(uvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public uvec3(uvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec3(IReadOnlyList<uint> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0u : v[0];
            this.y = c < 1 ? 0u : v[1];
            this.z = c < 2 ? 0u : v[2];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec3(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0u : (uint)v[0];
            this.y = c < 1 ? 0u : (uint)v[1];
            this.z = c < 2 ? 0u : (uint)v[2];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec3(uint[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0u : v[0];
            this.y = c < 1 ? 0u : v[1];
            this.z = c < 2 ? 0u : v[2];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec3(uint[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0u : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0u : v[1 + startIndex];
            this.z = c + startIndex < 2 ? 0u : v[2 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public uvec3(IEnumerable<uint> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a lvec3.
        /// </summary>
        public static implicit operator lvec3(uvec3 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Implicitly converts this to a vec3.
        /// </summary>
        public static implicit operator vec3(uvec3 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Implicitly converts this to a hvec3.
        /// </summary>
        public static implicit operator hvec3(uvec3 v) => new hvec3((Half)v.x, (Half)v.y, (Half)v.z);
        
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

        #endregion


        #region Explicit Operators
        
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
        public static explicit operator ivec4(uvec3 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(uvec3 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(uvec3 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, 0u);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(uvec3 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(uvec3 v) => new vec4((float)v.x, (float)v.y, (float)v.z, 0f);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(uvec3 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator hvec4(uvec3 v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(uvec3 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(uvec3 v) => new dvec4((double)v.x, (double)v.y, (double)v.z, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(uvec3 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(uvec3 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, 0m);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(uvec3 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(uvec3 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(uvec3 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(uvec3 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(uvec3 v) => new bvec2(v.x != 0u, v.y != 0u);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(uvec3 v) => new bvec3(v.x != 0u, v.y != 0u, v.z != 0u);
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(uvec3 v) => new bvec4(v.x != 0u, v.y != 0u, v.z != 0u, false);
        
        /// <summary>
        /// Explicitly converts this to a uint array.
        /// </summary>
        public static explicit operator uint[](uvec3 v) => new [] { v.x, v.y, v.z };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](uvec3 v) => new Object[] { v.x, v.y, v.z };

        #endregion


        #region Indexer
        
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
        public swizzle_uvec3 swizzle => new swizzle_uvec3(x, y, z);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public uvec2 xy
        {
            get
            {
                return new uvec2(x, y);
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
        public uvec2 xz
        {
            get
            {
                return new uvec2(x, z);
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
        public uvec2 yz
        {
            get
            {
                return new uvec2(y, z);
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
        public uvec3 xyz
        {
            get
            {
                return new uvec3(x, y, z);
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
        public uvec2 rg
        {
            get
            {
                return new uvec2(x, y);
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
        public uvec2 rb
        {
            get
            {
                return new uvec2(x, z);
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
        public uvec2 gb
        {
            get
            {
                return new uvec2(y, z);
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
        public uvec3 rgb
        {
            get
            {
                return new uvec3(x, y, z);
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
        public uint r
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
        public uint g
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
        public uint b
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
        public uint[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;
        
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
        public float Length => (float)Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public float LengthSqr => ((x*x + y*y) + z*z);
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public uint Sum => ((x + y) + z);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public float Norm => (float)Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public float Norm1 => ((x + y) + z);
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public float Norm2 => (float)Math.Sqrt(((x*x + y*y) + z*z));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public float NormMax => Math.Max(Math.Max(x, y), z);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static uvec3 Zero { get; } = new uvec3(0u, 0u, 0u);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static uvec3 Ones { get; } = new uvec3(1u, 1u, 1u);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static uvec3 UnitX { get; } = new uvec3(1u, 0u, 0u);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static uvec3 UnitY { get; } = new uvec3(0u, 1u, 0u);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static uvec3 UnitZ { get; } = new uvec3(0u, 0u, 1u);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static uvec3 MaxValue { get; } = new uvec3(uint.MaxValue, uint.MaxValue, uint.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static uvec3 MinValue { get; } = new uvec3(uint.MinValue, uint.MinValue, uint.MinValue);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(uvec3 lhs, uvec3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(uvec3 lhs, uvec3 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
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
        public bool Equals(uvec3 rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && z.Equals(rhs.z));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is uvec3 && Equals((uvec3) obj);
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
        public double NormP(double p) => Math.Pow(((Math.Pow((double)x, p) + Math.Pow((double)y, p)) + Math.Pow((double)z, p)), 1 / p);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static uvec3 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static uvec3 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new uvec3(uint.Parse(kvp[0].Trim()), uint.Parse(kvp[1].Trim()), uint.Parse(kvp[2].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static uvec3 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new uvec3(uint.Parse(kvp[0].Trim(), provider), uint.Parse(kvp[1].Trim(), provider), uint.Parse(kvp[2].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static uvec3 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new uvec3(uint.Parse(kvp[0].Trim(), style), uint.Parse(kvp[1].Trim(), style), uint.Parse(kvp[2].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static uvec3 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) throw new FormatException("input has not exactly 3 parts");
            return new uvec3(uint.Parse(kvp[0].Trim(), style, provider), uint.Parse(kvp[1].Trim(), style, provider), uint.Parse(kvp[2].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out uvec3 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out uvec3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            uint x = 0u, y = 0u, z = 0u;
            var ok = ((uint.TryParse(kvp[0].Trim(), out x) && uint.TryParse(kvp[1].Trim(), out y)) && uint.TryParse(kvp[2].Trim(), out z));
            result = ok ? new uvec3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out uvec3 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 3) return false;
            uint x = 0u, y = 0u, z = 0u;
            var ok = ((uint.TryParse(kvp[0].Trim(), style, provider, out x) && uint.TryParse(kvp[1].Trim(), style, provider, out y)) && uint.TryParse(kvp[2].Trim(), style, provider, out z));
            result = ok ? new uvec3(x, y, z) : Zero;
            return ok;
        }
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat3x2 OuterProduct(uvec2 c, uvec3 r) => new umat3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat2x3 OuterProduct(uvec3 c, uvec2 r) => new umat2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat3 OuterProduct(uvec3 c, uvec3 r) => new umat3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat3x4 OuterProduct(uvec4 c, uvec3 r) => new umat3x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.w * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat4x3 OuterProduct(uvec3 c, uvec4 r) => new umat4x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.x * r.z, c.y * r.z, c.z * r.z, c.x * r.w, c.y * r.w, c.z * r.w);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static uint Dot(uvec3 lhs, uvec3 rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + lhs.z * rhs.z);
        
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
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between 0 (inclusive) and int.MaxValue (exclusive).
        /// </summary>
        public static uvec3 Random(Random random) => new uvec3((uint)random.Next(), (uint)random.Next(), (uint)random.Next());

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(uvec3 lhs, uint rhs) => new bvec3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(uint lhs, uvec3 rhs) => new bvec3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(uint lhs, uint rhs) => new bvec3(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(uvec3 lhs, uint rhs) => new bvec3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(uint lhs, uvec3 rhs) => new bvec3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(uint lhs, uint rhs) => new bvec3(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(uvec3 lhs, uint rhs) => new bvec3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(uint lhs, uvec3 rhs) => new bvec3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(uint lhs, uint rhs) => new bvec3(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(uvec3 lhs, uint rhs) => new bvec3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(uint lhs, uvec3 rhs) => new bvec3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(uint lhs, uint rhs) => new bvec3(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(uvec3 lhs, uint rhs) => new bvec3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(uint lhs, uvec3 rhs) => new bvec3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(uint lhs, uint rhs) => new bvec3(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(uvec3 lhs, uint rhs) => new bvec3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(uint lhs, uvec3 rhs) => new bvec3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(uint lhs, uint rhs) => new bvec3(lhs <= rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Abs (v).
        /// </summary>
        public static uvec3 Abs(uvec3 v) => new uvec3(v.x, v.y, v.z);
        
        /// <summary>
        /// Returns a uvec from the application of Abs (v).
        /// </summary>
        public static uvec3 Abs(uint v) => new uvec3(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uvec3 HermiteInterpolationOrder3(uvec3 v) => new uvec3((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z);
        
        /// <summary>
        /// Returns a uvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uvec3 HermiteInterpolationOrder3(uint v) => new uvec3((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uvec3 HermiteInterpolationOrder5(uvec3 v) => new uvec3(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a uvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uvec3 HermiteInterpolationOrder5(uint v) => new uvec3(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static uvec3 Sqr(uvec3 v) => new uvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a uvec from the application of Sqr (v * v).
        /// </summary>
        public static uvec3 Sqr(uint v) => new uvec3(v * v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static uvec3 Pow2(uvec3 v) => new uvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a uvec from the application of Pow2 (v * v).
        /// </summary>
        public static uvec3 Pow2(uint v) => new uvec3(v * v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static uvec3 Pow3(uvec3 v) => new uvec3(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a uvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static uvec3 Pow3(uint v) => new uvec3(v * v * v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uvec3 Step(uvec3 v) => new uvec3(v.x >= 0u ? 1u : 0u, v.y >= 0u ? 1u : 0u, v.z >= 0u ? 1u : 0u);
        
        /// <summary>
        /// Returns a uvec from the application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uvec3 Step(uint v) => new uvec3(v >= 0u ? 1u : 0u);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sqrt ((uint)Math.Sqrt((double)v)).
        /// </summary>
        public static uvec3 Sqrt(uvec3 v) => new uvec3((uint)Math.Sqrt((double)v.x), (uint)Math.Sqrt((double)v.y), (uint)Math.Sqrt((double)v.z));
        
        /// <summary>
        /// Returns a uvec from the application of Sqrt ((uint)Math.Sqrt((double)v)).
        /// </summary>
        public static uvec3 Sqrt(uint v) => new uvec3((uint)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of InverseSqrt ((uint)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static uvec3 InverseSqrt(uvec3 v) => new uvec3((uint)(1.0 / Math.Sqrt((double)v.x)), (uint)(1.0 / Math.Sqrt((double)v.y)), (uint)(1.0 / Math.Sqrt((double)v.z)));
        
        /// <summary>
        /// Returns a uvec from the application of InverseSqrt ((uint)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static uvec3 InverseSqrt(uint v) => new uvec3((uint)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(uvec3 v) => new ivec3(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(uint v) => new ivec3(Math.Sign(v));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec3 Max(uvec3 lhs, uvec3 rhs) => new uvec3(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec3 Max(uvec3 lhs, uint rhs) => new uvec3(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs), Math.Max(lhs.z, rhs));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec3 Max(uint lhs, uvec3 rhs) => new uvec3(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y), Math.Max(lhs, rhs.z));
        
        /// <summary>
        /// Returns a uvec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec3 Max(uint lhs, uint rhs) => new uvec3(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec3 Min(uvec3 lhs, uvec3 rhs) => new uvec3(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec3 Min(uvec3 lhs, uint rhs) => new uvec3(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs), Math.Min(lhs.z, rhs));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec3 Min(uint lhs, uvec3 rhs) => new uvec3(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y), Math.Min(lhs, rhs.z));
        
        /// <summary>
        /// Returns a uvec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec3 Min(uint lhs, uint rhs) => new uvec3(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Pow(uvec3 lhs, uvec3 rhs) => new uvec3((uint)Math.Pow((double)lhs.x, (double)rhs.x), (uint)Math.Pow((double)lhs.y, (double)rhs.y), (uint)Math.Pow((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Pow(uvec3 lhs, uint rhs) => new uvec3((uint)Math.Pow((double)lhs.x, (double)rhs), (uint)Math.Pow((double)lhs.y, (double)rhs), (uint)Math.Pow((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Pow(uint lhs, uvec3 rhs) => new uvec3((uint)Math.Pow((double)lhs, (double)rhs.x), (uint)Math.Pow((double)lhs, (double)rhs.y), (uint)Math.Pow((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a uvec from the application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Pow(uint lhs, uint rhs) => new uvec3((uint)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Log(uvec3 lhs, uvec3 rhs) => new uvec3((uint)Math.Log((double)lhs.x, (double)rhs.x), (uint)Math.Log((double)lhs.y, (double)rhs.y), (uint)Math.Log((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Log(uvec3 lhs, uint rhs) => new uvec3((uint)Math.Log((double)lhs.x, (double)rhs), (uint)Math.Log((double)lhs.y, (double)rhs), (uint)Math.Log((double)lhs.z, (double)rhs));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Log(uint lhs, uvec3 rhs) => new uvec3((uint)Math.Log((double)lhs, (double)rhs.x), (uint)Math.Log((double)lhs, (double)rhs.y), (uint)Math.Log((double)lhs, (double)rhs.z));
        
        /// <summary>
        /// Returns a uvec from the application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Log(uint lhs, uint rhs) => new uvec3((uint)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec3 Clamp(uvec3 v, uvec3 min, uvec3 max) => new uvec3(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec3 Clamp(uvec3 v, uvec3 min, uint max) => new uvec3(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec3 Clamp(uvec3 v, uint min, uvec3 max) => new uvec3(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec3 Clamp(uvec3 v, uint min, uint max) => new uvec3(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec3 Clamp(uint v, uvec3 min, uvec3 max) => new uvec3(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec3 Clamp(uint v, uvec3 min, uint max) => new uvec3(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec3 Clamp(uint v, uint min, uvec3 max) => new uvec3(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z));
        
        /// <summary>
        /// Returns a uvec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec3 Clamp(uint v, uint min, uint max) => new uvec3(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Mix(uvec3 min, uvec3 max, uvec3 a) => new uvec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Mix(uvec3 min, uvec3 max, uint a) => new uvec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Mix(uvec3 min, uint max, uvec3 a) => new uvec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Mix(uvec3 min, uint max, uint a) => new uvec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Mix(uint min, uvec3 max, uvec3 a) => new uvec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Mix(uint min, uvec3 max, uint a) => new uvec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Mix(uint min, uint max, uvec3 a) => new uvec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a uvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Mix(uint min, uint max, uint a) => new uvec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Lerp(uvec3 min, uvec3 max, uvec3 a) => new uvec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Lerp(uvec3 min, uvec3 max, uint a) => new uvec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Lerp(uvec3 min, uint max, uvec3 a) => new uvec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Lerp(uvec3 min, uint max, uint a) => new uvec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Lerp(uint min, uvec3 max, uvec3 a) => new uvec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Lerp(uint min, uvec3 max, uint a) => new uvec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Lerp(uint min, uint max, uvec3 a) => new uvec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a uvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Lerp(uint min, uint max, uint a) => new uvec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec3 Smoothstep(uvec3 edge0, uvec3 edge1, uvec3 v) => new uvec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec3 Smoothstep(uvec3 edge0, uvec3 edge1, uint v) => new uvec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec3 Smoothstep(uvec3 edge0, uint edge1, uvec3 v) => new uvec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec3 Smoothstep(uvec3 edge0, uint edge1, uint v) => new uvec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec3 Smoothstep(uint edge0, uvec3 edge1, uvec3 v) => new uvec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec3 Smoothstep(uint edge0, uvec3 edge1, uint v) => new uvec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec3 Smoothstep(uint edge0, uint edge1, uvec3 v) => new uvec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec3 Smoothstep(uint edge0, uint edge1, uint v) => new uvec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec3 Smootherstep(uvec3 edge0, uvec3 edge1, uvec3 v) => new uvec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec3 Smootherstep(uvec3 edge0, uvec3 edge1, uint v) => new uvec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec3 Smootherstep(uvec3 edge0, uint edge1, uvec3 v) => new uvec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec3 Smootherstep(uvec3 edge0, uint edge1, uint v) => new uvec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec3 Smootherstep(uint edge0, uvec3 edge1, uvec3 v) => new uvec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec3 Smootherstep(uint edge0, uvec3 edge1, uint v) => new uvec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec3 Smootherstep(uint edge0, uint edge1, uvec3 v) => new uvec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec3 Smootherstep(uint edge0, uint edge1, uint v) => new uvec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec3 Fma(uvec3 a, uvec3 b, uvec3 c) => new uvec3(a.x * b.x + c.x, a.y * b.y + c.y, a.z * b.z + c.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec3 Fma(uvec3 a, uvec3 b, uint c) => new uvec3(a.x * b.x + c, a.y * b.y + c, a.z * b.z + c);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec3 Fma(uvec3 a, uint b, uvec3 c) => new uvec3(a.x * b + c.x, a.y * b + c.y, a.z * b + c.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec3 Fma(uvec3 a, uint b, uint c) => new uvec3(a.x * b + c, a.y * b + c, a.z * b + c);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec3 Fma(uint a, uvec3 b, uvec3 c) => new uvec3(a * b.x + c.x, a * b.y + c.y, a * b.z + c.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec3 Fma(uint a, uvec3 b, uint c) => new uvec3(a * b.x + c, a * b.y + c, a * b.z + c);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec3 Fma(uint a, uint b, uvec3 c) => new uvec3(a * b + c.x, a * b + c.y, a * b + c.z);
        
        /// <summary>
        /// Returns a uvec from the application of Fma (a * b + c).
        /// </summary>
        public static uvec3 Fma(uint a, uint b, uint c) => new uvec3(a * b + c);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec3 Add(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec3 Add(uvec3 lhs, uint rhs) => new uvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec3 Add(uint lhs, uvec3 rhs) => new uvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a uvec from the application of Add (lhs + rhs).
        /// </summary>
        public static uvec3 Add(uint lhs, uint rhs) => new uvec3(lhs + rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec3 Sub(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec3 Sub(uvec3 lhs, uint rhs) => new uvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec3 Sub(uint lhs, uvec3 rhs) => new uvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a uvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static uvec3 Sub(uint lhs, uint rhs) => new uvec3(lhs - rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec3 Mul(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec3 Mul(uvec3 lhs, uint rhs) => new uvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec3 Mul(uint lhs, uvec3 rhs) => new uvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a uvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static uvec3 Mul(uint lhs, uint rhs) => new uvec3(lhs * rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec3 Div(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec3 Div(uvec3 lhs, uint rhs) => new uvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec3 Div(uint lhs, uvec3 rhs) => new uvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a uvec from the application of Div (lhs / rhs).
        /// </summary>
        public static uvec3 Div(uint lhs, uint rhs) => new uvec3(lhs / rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec3 Xor(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec3 Xor(uvec3 lhs, uint rhs) => new uvec3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec3 Xor(uint lhs, uvec3 rhs) => new uvec3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);
        
        /// <summary>
        /// Returns a uvec from the application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec3 Xor(uint lhs, uint rhs) => new uvec3(lhs ^ rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec3 BitwiseOr(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec3 BitwiseOr(uvec3 lhs, uint rhs) => new uvec3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec3 BitwiseOr(uint lhs, uvec3 rhs) => new uvec3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);
        
        /// <summary>
        /// Returns a uvec from the application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec3 BitwiseOr(uint lhs, uint rhs) => new uvec3(lhs | rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec3 BitwiseAnd(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec3 BitwiseAnd(uvec3 lhs, uint rhs) => new uvec3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec3 BitwiseAnd(uint lhs, uvec3 rhs) => new uvec3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);
        
        /// <summary>
        /// Returns a uvec from the application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec3 BitwiseAnd(uint lhs, uint rhs) => new uvec3(lhs & rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec3 LeftShift(uvec3 lhs, ivec3 rhs) => new uvec3(lhs.x << rhs.x, lhs.y << rhs.y, lhs.z << rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec3 LeftShift(uvec3 lhs, int rhs) => new uvec3(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec3 LeftShift(uint lhs, ivec3 rhs) => new uvec3(lhs << rhs.x, lhs << rhs.y, lhs << rhs.z);
        
        /// <summary>
        /// Returns a uvec from the application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec3 LeftShift(uint lhs, int rhs) => new uvec3(lhs << rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec3 RightShift(uvec3 lhs, ivec3 rhs) => new uvec3(lhs.x >> rhs.x, lhs.y >> rhs.y, lhs.z >> rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec3 RightShift(uvec3 lhs, int rhs) => new uvec3(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec3 RightShift(uint lhs, ivec3 rhs) => new uvec3(lhs >> rhs.x, lhs >> rhs.y, lhs >> rhs.z);
        
        /// <summary>
        /// Returns a uvec from the application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec3 RightShift(uint lhs, int rhs) => new uvec3(lhs >> rhs);
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uvec3 Random(Random random, uvec3 maxValue) => new uvec3((uint)random.Next((int)maxValue.x), (uint)random.Next((int)maxValue.y), (uint)random.Next((int)maxValue.z));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uvec3 Random(Random random, uint maxValue) => new uvec3((uint)random.Next((int)maxValue));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 Random(Random random, uvec3 minValue, uvec3 maxValue) => new uvec3((uint)random.Next((int)minValue.x, (int)maxValue.x), (uint)random.Next((int)minValue.y, (int)maxValue.y), (uint)random.Next((int)minValue.z, (int)maxValue.z));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 Random(Random random, uvec3 minValue, uint maxValue) => new uvec3((uint)random.Next((int)minValue.x, (int)maxValue), (uint)random.Next((int)minValue.y, (int)maxValue), (uint)random.Next((int)minValue.z, (int)maxValue));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 Random(Random random, uint minValue, uvec3 maxValue) => new uvec3((uint)random.Next((int)minValue, (int)maxValue.x), (uint)random.Next((int)minValue, (int)maxValue.y), (uint)random.Next((int)minValue, (int)maxValue.z));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 Random(Random random, uint minValue, uint maxValue) => new uvec3((uint)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 RandomUniform(Random random, uvec3 minValue, uvec3 maxValue) => new uvec3((uint)random.Next((int)minValue.x, (int)maxValue.x), (uint)random.Next((int)minValue.y, (int)maxValue.y), (uint)random.Next((int)minValue.z, (int)maxValue.z));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 RandomUniform(Random random, uvec3 minValue, uint maxValue) => new uvec3((uint)random.Next((int)minValue.x, (int)maxValue), (uint)random.Next((int)minValue.y, (int)maxValue), (uint)random.Next((int)minValue.z, (int)maxValue));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 RandomUniform(Random random, uint minValue, uvec3 maxValue) => new uvec3((uint)random.Next((int)minValue, (int)maxValue.x), (uint)random.Next((int)minValue, (int)maxValue.y), (uint)random.Next((int)minValue, (int)maxValue.z));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 RandomUniform(Random random, uint minValue, uint maxValue) => new uvec3((uint)random.Next((int)minValue, (int)maxValue));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static uvec3 RandomPoisson(Random random, dvec3 lambda) => new uvec3((uint)lambda.x.GetPoisson(random), (uint)lambda.y.GetPoisson(random), (uint)lambda.z.GetPoisson(random));
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static uvec3 RandomPoisson(Random random, double lambda) => new uvec3((uint)lambda.GetPoisson(random));

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec3 operator<(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec3 operator<(uvec3 lhs, uint rhs) => new bvec3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec3 operator<(uint lhs, uvec3 rhs) => new bvec3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 operator<=(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 operator<=(uvec3 lhs, uint rhs) => new bvec3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 operator<=(uint lhs, uvec3 rhs) => new bvec3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec3 operator>(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec3 operator>(uvec3 lhs, uint rhs) => new bvec3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec3 operator>(uint lhs, uvec3 rhs) => new bvec3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 operator>=(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 operator>=(uvec3 lhs, uint rhs) => new bvec3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 operator>=(uint lhs, uvec3 rhs) => new bvec3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uvec3 operator+(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uvec3 operator+(uvec3 lhs, uint rhs) => new uvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static uvec3 operator+(uint lhs, uvec3 rhs) => new uvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uvec3 operator-(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uvec3 operator-(uvec3 lhs, uint rhs) => new uvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static uvec3 operator-(uint lhs, uvec3 rhs) => new uvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uvec3 operator*(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uvec3 operator*(uvec3 lhs, uint rhs) => new uvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static uvec3 operator*(uint lhs, uvec3 rhs) => new uvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uvec3 operator/(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uvec3 operator/(uvec3 lhs, uint rhs) => new uvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static uvec3 operator/(uint lhs, uvec3 rhs) => new uvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator+ (identity).
        /// </summary>
        public static uvec3 operator+(uvec3 v) => v;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator~ (~v).
        /// </summary>
        public static uvec3 operator~(uvec3 v) => new uvec3(~v.x, ~v.y, ~v.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uvec3 operator^(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x ^ rhs.x, lhs.y ^ rhs.y, lhs.z ^ rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uvec3 operator^(uvec3 lhs, uint rhs) => new uvec3(lhs.x ^ rhs, lhs.y ^ rhs, lhs.z ^ rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator^ (lhs ^ rhs).
        /// </summary>
        public static uvec3 operator^(uint lhs, uvec3 rhs) => new uvec3(lhs ^ rhs.x, lhs ^ rhs.y, lhs ^ rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uvec3 operator|(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uvec3 operator|(uvec3 lhs, uint rhs) => new uvec3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator| (lhs | rhs).
        /// </summary>
        public static uvec3 operator|(uint lhs, uvec3 rhs) => new uvec3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uvec3 operator&(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uvec3 operator&(uvec3 lhs, uint rhs) => new uvec3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator&amp; (lhs &amp; rhs).
        /// </summary>
        public static uvec3 operator&(uint lhs, uvec3 rhs) => new uvec3(lhs & rhs.x, lhs & rhs.y, lhs & rhs.z);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator&lt;&lt; (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec3 operator<<(uvec3 lhs, int rhs) => new uvec3(lhs.x << rhs, lhs.y << rhs, lhs.z << rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of operator&gt;&gt; (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec3 operator>>(uvec3 lhs, int rhs) => new uvec3(lhs.x >> rhs, lhs.y >> rhs, lhs.z >> rhs);

        #endregion

    }
}
