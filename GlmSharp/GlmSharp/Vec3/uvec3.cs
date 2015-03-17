using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Linq;
using GlmSharp.Swizzle;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    
    /// <summary>
    /// A vector of type uint with 3 components.
    /// </summary>
    [Serializable]
    [DataContract]
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
        public static explicit operator cvec4(uvec3 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, 0.0);
        
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
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_uvec3 swizzle => new swizzle_uvec3(x, y, z);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public uint[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;

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

        #endregion

        
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
        /// Returns a boolean vector with component-wise equal.
        /// </summary>
        public static bvec3 Equal(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a boolean vector with component-wise not-equal.
        /// </summary>
        public static bvec3 NotEqual(uvec3 lhs, uvec3 rhs) => new bvec3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than.
        /// </summary>
        public static bvec3 GreaterThan(uvec3 lhs, uvec3 rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than-or-equal.
        /// </summary>
        public static bvec3 GreaterThanEqual(uvec3 lhs, uvec3 rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than.
        /// </summary>
        public static bvec3 LesserThan(uvec3 lhs, uvec3 rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than-or-equal.
        /// </summary>
        public static bvec3 LesserThanEqual(uvec3 lhs, uvec3 rhs) => lhs <= rhs;
        
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
        /// Predefined all-MaxValue vector
        /// </summary>
        public static uvec3 MaxValue { get; } = new uvec3(uint.MaxValue, uint.MaxValue, uint.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static uvec3 MinValue { get; } = new uvec3(uint.MinValue, uint.MinValue, uint.MinValue);
        
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
            var ok = uint.TryParse(kvp[0].Trim(), out x) && uint.TryParse(kvp[1].Trim(), out y) && uint.TryParse(kvp[2].Trim(), out z);
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
            var ok = uint.TryParse(kvp[0].Trim(), style, provider, out x) && uint.TryParse(kvp[1].Trim(), style, provider, out y) && uint.TryParse(kvp[2].Trim(), style, provider, out z);
            result = ok ? new uvec3(x, y, z) : Zero;
            return ok;
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
        /// Executes a component-wise unary ~ (bitwise-not).
        /// </summary>
        public static uvec3 operator~(uvec3 v) => new uvec3(~v.x, ~v.y, ~v.z);
        
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
        /// Executes a component-wise bitwise-or.
        /// </summary>
        public static uvec3 operator|(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x | rhs.x, lhs.y | rhs.y, lhs.z | rhs.z);
        
        /// <summary>
        /// Executes a component-wise bitwise-or with a scalar.
        /// </summary>
        public static uvec3 operator|(uvec3 lhs, uint rhs) => new uvec3(lhs.x | rhs, lhs.y | rhs, lhs.z | rhs);
        
        /// <summary>
        /// Executes a component-wise bitwise-or with a scalar.
        /// </summary>
        public static uvec3 operator|(uint lhs, uvec3 rhs) => new uvec3(lhs | rhs.x, lhs | rhs.y, lhs | rhs.z);
        
        /// <summary>
        /// Executes a component-wise bitwise-and.
        /// </summary>
        public static uvec3 operator&(uvec3 lhs, uvec3 rhs) => new uvec3(lhs.x & rhs.x, lhs.y & rhs.y, lhs.z & rhs.z);
        
        /// <summary>
        /// Executes a component-wise bitwise-and with a scalar.
        /// </summary>
        public static uvec3 operator&(uvec3 lhs, uint rhs) => new uvec3(lhs.x & rhs, lhs.y & rhs, lhs.z & rhs);
        
        /// <summary>
        /// Executes a component-wise bitwise-and with a scalar.
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
        
        /// <summary>
        /// Returns a component-wise executed Abs.
        /// </summary>
        public static uvec3 Abs(uvec3 v) => new uvec3(v.x, v.y, v.z);
        
        /// <summary>
        /// Returns a component-wise executed Abs with a scalar.
        /// </summary>
        public static uvec3 Abs(uint v) => new uvec3(v);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder3.
        /// </summary>
        public static uvec3 HermiteInterpolationOrder3(uvec3 v) => new uvec3((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder3 with a scalar.
        /// </summary>
        public static uvec3 HermiteInterpolationOrder3(uint v) => new uvec3((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder5.
        /// </summary>
        public static uvec3 HermiteInterpolationOrder5(uvec3 v) => new uvec3(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder5 with a scalar.
        /// </summary>
        public static uvec3 HermiteInterpolationOrder5(uint v) => new uvec3(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a component-wise executed Sqr.
        /// </summary>
        public static uvec3 Sqr(uvec3 v) => new uvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed Sqr with a scalar.
        /// </summary>
        public static uvec3 Sqr(uint v) => new uvec3(v * v);
        
        /// <summary>
        /// Returns a component-wise executed Pow2.
        /// </summary>
        public static uvec3 Pow2(uvec3 v) => new uvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed Pow2 with a scalar.
        /// </summary>
        public static uvec3 Pow2(uint v) => new uvec3(v * v);
        
        /// <summary>
        /// Returns a component-wise executed Max.
        /// </summary>
        public static uvec3 Max(uvec3 lhs, uvec3 rhs) => new uvec3(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static uvec3 Max(uvec3 v, uint s) => new uvec3(Math.Max(v.x, s), Math.Max(v.y, s), Math.Max(v.z, s));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static uvec3 Max(uint s, uvec3 v) => new uvec3(Math.Max(s, v.x), Math.Max(s, v.y), Math.Max(s, v.z));
        
        /// <summary>
        /// Returns a component-wise executed Max with scalars.
        /// </summary>
        public static uvec3 Max(uint lhs, uint rhs) => new uvec3(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a component-wise executed Min.
        /// </summary>
        public static uvec3 Min(uvec3 lhs, uvec3 rhs) => new uvec3(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static uvec3 Min(uvec3 v, uint s) => new uvec3(Math.Min(v.x, s), Math.Min(v.y, s), Math.Min(v.z, s));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static uvec3 Min(uint s, uvec3 v) => new uvec3(Math.Min(s, v.x), Math.Min(s, v.y), Math.Min(s, v.z));
        
        /// <summary>
        /// Returns a component-wise executed Min with scalars.
        /// </summary>
        public static uvec3 Min(uint lhs, uint rhs) => new uvec3(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static uvec3 Pow(uvec3 lhs, uvec3 rhs) => new uvec3((uint)Math.Pow((double)lhs.x, (double)rhs.x), (uint)Math.Pow((double)lhs.y, (double)rhs.y), (uint)Math.Pow((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static uvec3 Pow(uvec3 v, uint s) => new uvec3((uint)Math.Pow((double)v.x, (double)s), (uint)Math.Pow((double)v.y, (double)s), (uint)Math.Pow((double)v.z, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static uvec3 Pow(uint s, uvec3 v) => new uvec3((uint)Math.Pow((double)s, (double)v.x), (uint)Math.Pow((double)s, (double)v.y), (uint)Math.Pow((double)s, (double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Pow with scalars.
        /// </summary>
        public static uvec3 Pow(uint lhs, uint rhs) => new uvec3((uint)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static uvec3 Log(uvec3 lhs, uvec3 rhs) => new uvec3((uint)Math.Log((double)lhs.x, (double)rhs.x), (uint)Math.Log((double)lhs.y, (double)rhs.y), (uint)Math.Log((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static uvec3 Log(uvec3 v, uint s) => new uvec3((uint)Math.Log((double)v.x, (double)s), (uint)Math.Log((double)v.y, (double)s), (uint)Math.Log((double)v.z, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static uvec3 Log(uint s, uvec3 v) => new uvec3((uint)Math.Log((double)s, (double)v.x), (uint)Math.Log((double)s, (double)v.y), (uint)Math.Log((double)s, (double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Log with scalars.
        /// </summary>
        public static uvec3 Log(uint lhs, uint rhs) => new uvec3((uint)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a component-wise executed Clamp.
        /// </summary>
        public static uvec3 Clamp(uvec3 v, uvec3 min, uvec3 max) => new uvec3(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static uvec3 Clamp(uint v, uvec3 min, uvec3 max) => new uvec3(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static uvec3 Clamp(uvec3 v, uint min, uvec3 max) => new uvec3(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static uvec3 Clamp(uvec3 v, uvec3 min, uint max) => new uvec3(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static uvec3 Clamp(uint v, uint min, uvec3 max) => new uvec3(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static uvec3 Clamp(uvec3 v, uint min, uint max) => new uvec3(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static uvec3 Clamp(uint v, uvec3 min, uint max) => new uvec3(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static uvec3 Clamp(uint v, uint min, uint max) => new uvec3(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a component-wise executed Mix.
        /// </summary>
        public static uvec3 Mix(uvec3 min, uvec3 max, uvec3 a) => new uvec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static uvec3 Mix(uint min, uvec3 max, uvec3 a) => new uvec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static uvec3 Mix(uvec3 min, uint max, uvec3 a) => new uvec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static uvec3 Mix(uvec3 min, uvec3 max, uint a) => new uvec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static uvec3 Mix(uint min, uint max, uvec3 a) => new uvec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static uvec3 Mix(uvec3 min, uint max, uint a) => new uvec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static uvec3 Mix(uint min, uvec3 max, uint a) => new uvec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static uvec3 Mix(uint min, uint max, uint a) => new uvec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp.
        /// </summary>
        public static uvec3 Lerp(uvec3 min, uvec3 max, uvec3 a) => new uvec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static uvec3 Lerp(uint min, uvec3 max, uvec3 a) => new uvec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static uvec3 Lerp(uvec3 min, uint max, uvec3 a) => new uvec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static uvec3 Lerp(uvec3 min, uvec3 max, uint a) => new uvec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static uvec3 Lerp(uint min, uint max, uvec3 a) => new uvec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static uvec3 Lerp(uvec3 min, uint max, uint a) => new uvec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static uvec3 Lerp(uint min, uvec3 max, uint a) => new uvec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static uvec3 Lerp(uint min, uint max, uint a) => new uvec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep.
        /// </summary>
        public static uvec3 Smoothstep(uvec3 edge0, uvec3 edge1, uvec3 v) => new uvec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static uvec3 Smoothstep(uint edge0, uvec3 edge1, uvec3 v) => new uvec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static uvec3 Smoothstep(uvec3 edge0, uint edge1, uvec3 v) => new uvec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static uvec3 Smoothstep(uvec3 edge0, uvec3 edge1, uint v) => new uvec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static uvec3 Smoothstep(uint edge0, uint edge1, uvec3 v) => new uvec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static uvec3 Smoothstep(uvec3 edge0, uint edge1, uint v) => new uvec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static uvec3 Smoothstep(uint edge0, uvec3 edge1, uint v) => new uvec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static uvec3 Smoothstep(uint edge0, uint edge1, uint v) => new uvec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep.
        /// </summary>
        public static uvec3 Smootherstep(uvec3 edge0, uvec3 edge1, uvec3 v) => new uvec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static uvec3 Smootherstep(uint edge0, uvec3 edge1, uvec3 v) => new uvec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static uvec3 Smootherstep(uvec3 edge0, uint edge1, uvec3 v) => new uvec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static uvec3 Smootherstep(uvec3 edge0, uvec3 edge1, uint v) => new uvec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static uvec3 Smootherstep(uint edge0, uint edge1, uvec3 v) => new uvec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static uvec3 Smootherstep(uvec3 edge0, uint edge1, uint v) => new uvec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static uvec3 Smootherstep(uint edge0, uvec3 edge1, uint v) => new uvec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static uvec3 Smootherstep(uint edge0, uint edge1, uint v) => new uvec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
    }
}
