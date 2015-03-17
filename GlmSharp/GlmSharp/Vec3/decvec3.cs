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
    /// A vector of type decimal with 3 components.
    /// </summary>
    [Serializable]
    [DataContract]
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
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public decvec3(decvec2 v, decimal z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public decvec3(decvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public decvec3(decvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
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
        public static explicit operator cvec4(decvec3 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, 0.0);
        
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
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_decvec3 swizzle => new swizzle_decvec3(x, y, z);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public decimal[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;

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
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(decvec3 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z);
        
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
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(decimal lhs, decimal rhs) => new bvec3(lhs == rhs);

        #endregion

        
        /// <summary>
        /// Returns a boolean vector with component-wise not-equal.
        /// </summary>
        public static bvec3 NotEqual(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than.
        /// </summary>
        public static bvec3 GreaterThan(decvec3 lhs, decvec3 rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than-or-equal.
        /// </summary>
        public static bvec3 GreaterThanEqual(decvec3 lhs, decvec3 rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than.
        /// </summary>
        public static bvec3 LesserThan(decvec3 lhs, decvec3 rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than-or-equal.
        /// </summary>
        public static bvec3 LesserThanEqual(decvec3 lhs, decvec3 rhs) => lhs <= rhs;
        
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
        public static decvec3 MaxValue { get; } = new decvec3(decimal.MaxValue, decimal.MaxValue, decimal.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static decvec3 MinValue { get; } = new decvec3(decimal.MinValue, decimal.MinValue, decimal.MinValue);
        
        /// <summary>
        /// Predefined all-MinusOne vector
        /// </summary>
        public static decvec3 MinusOne { get; } = new decvec3(decimal.MinusOne, decimal.MinusOne, decimal.MinusOne);
        
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
            var ok = decimal.TryParse(kvp[0].Trim(), out x) && decimal.TryParse(kvp[1].Trim(), out y) && decimal.TryParse(kvp[2].Trim(), out z);
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
            var ok = decimal.TryParse(kvp[0].Trim(), style, provider, out x) && decimal.TryParse(kvp[1].Trim(), style, provider, out y) && decimal.TryParse(kvp[2].Trim(), style, provider, out z);
            result = ok ? new decvec3(x, y, z) : Zero;
            return ok;
        }
        
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
        public decimal Length => (decimal)x*x + y*y + z*z.Sqrt();
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public decimal LengthSqr => x*x + y*y + z*z;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public decimal Sum => x + y + z;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public decimal Norm => (decimal)x*x + y*y + z*z.Sqrt();
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public decimal Norm1 => Math.Abs(x) + Math.Abs(y) + Math.Abs(z);
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public decimal Norm2 => (decimal)x*x + y*y + z*z.Sqrt();
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public decimal NormMax => Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p) + Math.Pow((double)Math.Abs(z), p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static decvec3 operator+(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static decvec3 operator+(decvec3 lhs, decimal rhs) => new decvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static decvec3 operator+(decimal lhs, decvec3 rhs) => new decvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static decvec3 operator-(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static decvec3 operator-(decvec3 lhs, decimal rhs) => new decvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static decvec3 operator-(decimal lhs, decvec3 rhs) => new decvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static decvec3 operator/(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static decvec3 operator/(decvec3 lhs, decimal rhs) => new decvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static decvec3 operator/(decimal lhs, decvec3 rhs) => new decvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static decvec3 operator*(decvec3 lhs, decvec3 rhs) => new decvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static decvec3 operator*(decvec3 lhs, decimal rhs) => new decvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static decvec3 operator*(decimal lhs, decvec3 rhs) => new decvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Executes a component-wise unary + (add).
        /// </summary>
        public static decvec3 operator+(decvec3 v) => v;
        
        /// <summary>
        /// Executes a component-wise unary - (subtract).
        /// </summary>
        public static decvec3 operator-(decvec3 v) => new decvec3(-v.x, -v.y, -v.z);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bvec3 operator<(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator<(decvec3 lhs, decimal rhs) => new bvec3(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator<(decimal lhs, decvec3 rhs) => new bvec3(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec3 operator<=(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator<=(decvec3 lhs, decimal rhs) => new bvec3(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator<=(decimal lhs, decvec3 rhs) => new bvec3(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bvec3 operator>(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator>(decvec3 lhs, decimal rhs) => new bvec3(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec3 operator>(decimal lhs, decvec3 rhs) => new bvec3(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec3 operator>=(decvec3 lhs, decvec3 rhs) => new bvec3(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator>=(decvec3 lhs, decimal rhs) => new bvec3(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec3 operator>=(decimal lhs, decvec3 rhs) => new bvec3(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public decvec3 Normalized => this / Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public decvec3 NormalizedSafe => this == Zero ? Zero : this / Length;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static decimal Dot(decvec3 lhs, decvec3 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        
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
            return eta * I - (eta * dNI + (decimal)k.Sqrt()) * N;
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
        /// Returns a component-wise executed Abs.
        /// </summary>
        public static decvec3 Abs(decvec3 v) => new decvec3(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Abs with a scalar.
        /// </summary>
        public static decvec3 Abs(decimal v) => new decvec3(Math.Abs(v));
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder3.
        /// </summary>
        public static decvec3 HermiteInterpolationOrder3(decvec3 v) => new decvec3((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder3 with a scalar.
        /// </summary>
        public static decvec3 HermiteInterpolationOrder3(decimal v) => new decvec3((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder5.
        /// </summary>
        public static decvec3 HermiteInterpolationOrder5(decvec3 v) => new decvec3(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder5 with a scalar.
        /// </summary>
        public static decvec3 HermiteInterpolationOrder5(decimal v) => new decvec3(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a component-wise executed Step.
        /// </summary>
        public static decvec3 Step(decvec3 v) => new decvec3(v.x >= 0m ? 1m : 0m, v.y >= 0m ? 1m : 0m, v.z >= 0m ? 1m : 0m);
        
        /// <summary>
        /// Returns a component-wise executed Step with a scalar.
        /// </summary>
        public static decvec3 Step(decimal v) => new decvec3(v >= 0m ? 1m : 0m);
        
        /// <summary>
        /// Returns a component-wise executed Acos.
        /// </summary>
        public static decvec3 Acos(decvec3 v) => new decvec3((decimal)Math.Acos((double)v.x), (decimal)Math.Acos((double)v.y), (decimal)Math.Acos((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Acos with a scalar.
        /// </summary>
        public static decvec3 Acos(decimal v) => new decvec3((decimal)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Asin.
        /// </summary>
        public static decvec3 Asin(decvec3 v) => new decvec3((decimal)Math.Asin((double)v.x), (decimal)Math.Asin((double)v.y), (decimal)Math.Asin((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Asin with a scalar.
        /// </summary>
        public static decvec3 Asin(decimal v) => new decvec3((decimal)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Atan.
        /// </summary>
        public static decvec3 Atan(decvec3 v) => new decvec3((decimal)Math.Atan((double)v.x), (decimal)Math.Atan((double)v.y), (decimal)Math.Atan((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Atan with a scalar.
        /// </summary>
        public static decvec3 Atan(decimal v) => new decvec3((decimal)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Cos.
        /// </summary>
        public static decvec3 Cos(decvec3 v) => new decvec3((decimal)Math.Cos((double)v.x), (decimal)Math.Cos((double)v.y), (decimal)Math.Cos((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Cos with a scalar.
        /// </summary>
        public static decvec3 Cos(decimal v) => new decvec3((decimal)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Cosh.
        /// </summary>
        public static decvec3 Cosh(decvec3 v) => new decvec3((decimal)Math.Cosh((double)v.x), (decimal)Math.Cosh((double)v.y), (decimal)Math.Cosh((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Cosh with a scalar.
        /// </summary>
        public static decvec3 Cosh(decimal v) => new decvec3((decimal)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Exp.
        /// </summary>
        public static decvec3 Exp(decvec3 v) => new decvec3((decimal)Math.Exp((double)v.x), (decimal)Math.Exp((double)v.y), (decimal)Math.Exp((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Exp with a scalar.
        /// </summary>
        public static decvec3 Exp(decimal v) => new decvec3((decimal)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static decvec3 Log(decvec3 v) => new decvec3((decimal)Math.Log((double)v.x), (decimal)Math.Log((double)v.y), (decimal)Math.Log((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static decvec3 Log(decimal v) => new decvec3((decimal)Math.Log((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Log2.
        /// </summary>
        public static decvec3 Log2(decvec3 v) => new decvec3((decimal)Math.Log((double)v.x, 2), (decimal)Math.Log((double)v.y, 2), (decimal)Math.Log((double)v.z, 2));
        
        /// <summary>
        /// Returns a component-wise executed Log2 with a scalar.
        /// </summary>
        public static decvec3 Log2(decimal v) => new decvec3((decimal)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a component-wise executed Log10.
        /// </summary>
        public static decvec3 Log10(decvec3 v) => new decvec3((decimal)Math.Log10((double)v.x), (decimal)Math.Log10((double)v.y), (decimal)Math.Log10((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Log10 with a scalar.
        /// </summary>
        public static decvec3 Log10(decimal v) => new decvec3((decimal)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Floor.
        /// </summary>
        public static decvec3 Floor(decvec3 v) => new decvec3((decimal)Math.Floor(v.x), (decimal)Math.Floor(v.y), (decimal)Math.Floor(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Floor with a scalar.
        /// </summary>
        public static decvec3 Floor(decimal v) => new decvec3((decimal)Math.Floor(v));
        
        /// <summary>
        /// Returns a component-wise executed Ceiling.
        /// </summary>
        public static decvec3 Ceiling(decvec3 v) => new decvec3((decimal)Math.Ceiling(v.x), (decimal)Math.Ceiling(v.y), (decimal)Math.Ceiling(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Ceiling with a scalar.
        /// </summary>
        public static decvec3 Ceiling(decimal v) => new decvec3((decimal)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a component-wise executed Round.
        /// </summary>
        public static decvec3 Round(decvec3 v) => new decvec3((decimal)Math.Round(v.x), (decimal)Math.Round(v.y), (decimal)Math.Round(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Round with a scalar.
        /// </summary>
        public static decvec3 Round(decimal v) => new decvec3((decimal)Math.Round(v));
        
        /// <summary>
        /// Returns a component-wise executed Sin.
        /// </summary>
        public static decvec3 Sin(decvec3 v) => new decvec3((decimal)Math.Sin((double)v.x), (decimal)Math.Sin((double)v.y), (decimal)Math.Sin((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Sin with a scalar.
        /// </summary>
        public static decvec3 Sin(decimal v) => new decvec3((decimal)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Sinh.
        /// </summary>
        public static decvec3 Sinh(decvec3 v) => new decvec3((decimal)Math.Sinh((double)v.x), (decimal)Math.Sinh((double)v.y), (decimal)Math.Sinh((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Sinh with a scalar.
        /// </summary>
        public static decvec3 Sinh(decimal v) => new decvec3((decimal)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Sqrt.
        /// </summary>
        public static decvec3 Sqrt(decvec3 v) => new decvec3((decimal)Math.Sqrt((double)v.x), (decimal)Math.Sqrt((double)v.y), (decimal)Math.Sqrt((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Sqrt with a scalar.
        /// </summary>
        public static decvec3 Sqrt(decimal v) => new decvec3((decimal)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Tan.
        /// </summary>
        public static decvec3 Tan(decvec3 v) => new decvec3((decimal)Math.Tan((double)v.x), (decimal)Math.Tan((double)v.y), (decimal)Math.Tan((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Tan with a scalar.
        /// </summary>
        public static decvec3 Tan(decimal v) => new decvec3((decimal)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Tanh.
        /// </summary>
        public static decvec3 Tanh(decvec3 v) => new decvec3((decimal)Math.Tanh((double)v.x), (decimal)Math.Tanh((double)v.y), (decimal)Math.Tanh((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Tanh with a scalar.
        /// </summary>
        public static decvec3 Tanh(decimal v) => new decvec3((decimal)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Truncate.
        /// </summary>
        public static decvec3 Truncate(decvec3 v) => new decvec3((decimal)Math.Truncate((double)v.x), (decimal)Math.Truncate((double)v.y), (decimal)Math.Truncate((double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Truncate with a scalar.
        /// </summary>
        public static decvec3 Truncate(decimal v) => new decvec3((decimal)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Sign.
        /// </summary>
        public static ivec3 Sign(decvec3 v) => new ivec3(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z));
        
        /// <summary>
        /// Returns a component-wise executed Sign with a scalar.
        /// </summary>
        public static ivec3 Sign(decimal v) => new ivec3(Math.Sign(v));
        
        /// <summary>
        /// Returns a component-wise executed radians-to-degrees conversion.
        /// </summary>
        public static decvec3 Degrees(decvec3 v) => v * 57.295779513082320876798154814105170332405472466564321m;
        
        /// <summary>
        /// Returns a component-wise executed radians-to-degrees conversion with a scalar.
        /// </summary>
        public static decvec3 Degrees(decimal v) => new decvec3(v * 57.295779513082320876798154814105170332405472466564321m);
        
        /// <summary>
        /// Returns a component-wise executed degrees-to-radians conversion.
        /// </summary>
        public static decvec3 Radians(decvec3 v) => v * 0.0174532925199432957692369076848861271344287188854172m;
        
        /// <summary>
        /// Returns a component-wise executed degrees-to-radians conversion with a scalar.
        /// </summary>
        public static decvec3 Radians(decimal v) => new decvec3(v * 0.0174532925199432957692369076848861271344287188854172m);
        
        /// <summary>
        /// Returns a component-wise executed Sqr.
        /// </summary>
        public static decvec3 Sqr(decvec3 v) => new decvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed Sqr with a scalar.
        /// </summary>
        public static decvec3 Sqr(decimal v) => new decvec3(v * v);
        
        /// <summary>
        /// Returns a component-wise executed Pow2.
        /// </summary>
        public static decvec3 Pow2(decvec3 v) => new decvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a component-wise executed Pow2 with a scalar.
        /// </summary>
        public static decvec3 Pow2(decimal v) => new decvec3(v * v);
        
        /// <summary>
        /// Returns a component-wise executed Max.
        /// </summary>
        public static decvec3 Max(decvec3 lhs, decvec3 rhs) => new decvec3(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static decvec3 Max(decvec3 v, decimal s) => new decvec3(Math.Max(v.x, s), Math.Max(v.y, s), Math.Max(v.z, s));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static decvec3 Max(decimal s, decvec3 v) => new decvec3(Math.Max(s, v.x), Math.Max(s, v.y), Math.Max(s, v.z));
        
        /// <summary>
        /// Returns a component-wise executed Max with scalars.
        /// </summary>
        public static decvec3 Max(decimal lhs, decimal rhs) => new decvec3(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a component-wise executed Min.
        /// </summary>
        public static decvec3 Min(decvec3 lhs, decvec3 rhs) => new decvec3(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static decvec3 Min(decvec3 v, decimal s) => new decvec3(Math.Min(v.x, s), Math.Min(v.y, s), Math.Min(v.z, s));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static decvec3 Min(decimal s, decvec3 v) => new decvec3(Math.Min(s, v.x), Math.Min(s, v.y), Math.Min(s, v.z));
        
        /// <summary>
        /// Returns a component-wise executed Min with scalars.
        /// </summary>
        public static decvec3 Min(decimal lhs, decimal rhs) => new decvec3(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static decvec3 Pow(decvec3 lhs, decvec3 rhs) => new decvec3((decimal)Math.Pow((double)lhs.x, (double)rhs.x), (decimal)Math.Pow((double)lhs.y, (double)rhs.y), (decimal)Math.Pow((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static decvec3 Pow(decvec3 v, decimal s) => new decvec3((decimal)Math.Pow((double)v.x, (double)s), (decimal)Math.Pow((double)v.y, (double)s), (decimal)Math.Pow((double)v.z, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static decvec3 Pow(decimal s, decvec3 v) => new decvec3((decimal)Math.Pow((double)s, (double)v.x), (decimal)Math.Pow((double)s, (double)v.y), (decimal)Math.Pow((double)s, (double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Pow with scalars.
        /// </summary>
        public static decvec3 Pow(decimal lhs, decimal rhs) => new decvec3((decimal)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static decvec3 Log(decvec3 lhs, decvec3 rhs) => new decvec3((decimal)Math.Log((double)lhs.x, (double)rhs.x), (decimal)Math.Log((double)lhs.y, (double)rhs.y), (decimal)Math.Log((double)lhs.z, (double)rhs.z));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static decvec3 Log(decvec3 v, decimal s) => new decvec3((decimal)Math.Log((double)v.x, (double)s), (decimal)Math.Log((double)v.y, (double)s), (decimal)Math.Log((double)v.z, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static decvec3 Log(decimal s, decvec3 v) => new decvec3((decimal)Math.Log((double)s, (double)v.x), (decimal)Math.Log((double)s, (double)v.y), (decimal)Math.Log((double)s, (double)v.z));
        
        /// <summary>
        /// Returns a component-wise executed Log with scalars.
        /// </summary>
        public static decvec3 Log(decimal lhs, decimal rhs) => new decvec3((decimal)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a component-wise executed Clamp.
        /// </summary>
        public static decvec3 Clamp(decvec3 v, decvec3 min, decvec3 max) => new decvec3(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static decvec3 Clamp(decimal v, decvec3 min, decvec3 max) => new decvec3(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static decvec3 Clamp(decvec3 v, decimal min, decvec3 max) => new decvec3(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static decvec3 Clamp(decvec3 v, decvec3 min, decimal max) => new decvec3(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static decvec3 Clamp(decimal v, decimal min, decvec3 max) => new decvec3(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static decvec3 Clamp(decvec3 v, decimal min, decimal max) => new decvec3(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static decvec3 Clamp(decimal v, decvec3 min, decimal max) => new decvec3(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static decvec3 Clamp(decimal v, decimal min, decimal max) => new decvec3(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a component-wise executed Mix.
        /// </summary>
        public static decvec3 Mix(decvec3 min, decvec3 max, decvec3 a) => new decvec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static decvec3 Mix(decimal min, decvec3 max, decvec3 a) => new decvec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static decvec3 Mix(decvec3 min, decimal max, decvec3 a) => new decvec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static decvec3 Mix(decvec3 min, decvec3 max, decimal a) => new decvec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static decvec3 Mix(decimal min, decimal max, decvec3 a) => new decvec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static decvec3 Mix(decvec3 min, decimal max, decimal a) => new decvec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static decvec3 Mix(decimal min, decvec3 max, decimal a) => new decvec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static decvec3 Mix(decimal min, decimal max, decimal a) => new decvec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp.
        /// </summary>
        public static decvec3 Lerp(decvec3 min, decvec3 max, decvec3 a) => new decvec3(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static decvec3 Lerp(decimal min, decvec3 max, decvec3 a) => new decvec3(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static decvec3 Lerp(decvec3 min, decimal max, decvec3 a) => new decvec3(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static decvec3 Lerp(decvec3 min, decvec3 max, decimal a) => new decvec3(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static decvec3 Lerp(decimal min, decimal max, decvec3 a) => new decvec3(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static decvec3 Lerp(decvec3 min, decimal max, decimal a) => new decvec3(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static decvec3 Lerp(decimal min, decvec3 max, decimal a) => new decvec3(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static decvec3 Lerp(decimal min, decimal max, decimal a) => new decvec3(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep.
        /// </summary>
        public static decvec3 Smoothstep(decvec3 edge0, decvec3 edge1, decvec3 v) => new decvec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static decvec3 Smoothstep(decimal edge0, decvec3 edge1, decvec3 v) => new decvec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static decvec3 Smoothstep(decvec3 edge0, decimal edge1, decvec3 v) => new decvec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static decvec3 Smoothstep(decvec3 edge0, decvec3 edge1, decimal v) => new decvec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static decvec3 Smoothstep(decimal edge0, decimal edge1, decvec3 v) => new decvec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static decvec3 Smoothstep(decvec3 edge0, decimal edge1, decimal v) => new decvec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static decvec3 Smoothstep(decimal edge0, decvec3 edge1, decimal v) => new decvec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static decvec3 Smoothstep(decimal edge0, decimal edge1, decimal v) => new decvec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep.
        /// </summary>
        public static decvec3 Smootherstep(decvec3 edge0, decvec3 edge1, decvec3 v) => new decvec3(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static decvec3 Smootherstep(decimal edge0, decvec3 edge1, decvec3 v) => new decvec3(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static decvec3 Smootherstep(decvec3 edge0, decimal edge1, decvec3 v) => new decvec3(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static decvec3 Smootherstep(decvec3 edge0, decvec3 edge1, decimal v) => new decvec3(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static decvec3 Smootherstep(decimal edge0, decimal edge1, decvec3 v) => new decvec3(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static decvec3 Smootherstep(decvec3 edge0, decimal edge1, decimal v) => new decvec3(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static decvec3 Smootherstep(decimal edge0, decvec3 edge1, decimal v) => new decvec3(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static decvec3 Smootherstep(decimal edge0, decimal edge1, decimal v) => new decvec3(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
    }
}
