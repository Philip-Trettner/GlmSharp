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
    /// A vector of type decimal with 2 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct decvec2 : IReadOnlyList<decimal>, IEquatable<decvec2>
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

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public decvec2(decimal x, decimal y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public decvec2(decimal v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public decvec2(decvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public decvec2(decvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public decvec2(decvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec2(IReadOnlyList<decimal> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0m : v[0];
            this.y = c < 1 ? 0m : v[1];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec2(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0m : (decimal)v[0];
            this.y = c < 1 ? 0m : (decimal)v[1];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec2(decimal[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0m : v[0];
            this.y = c < 1 ? 0m : v[1];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec2(decimal[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0m : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0m : v[1 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public decvec2(IEnumerable<decimal> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(decvec2 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec3(decvec2 v) => new ivec3((int)v.x, (int)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(decvec2 v) => new ivec4((int)v.x, (int)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(decvec2 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec3(decvec2 v) => new uvec3((uint)v.x, (uint)v.y, 0u);
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(decvec2 v) => new uvec4((uint)v.x, (uint)v.y, 0u, 0u);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(decvec2 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec3(decvec2 v) => new vec3((float)v.x, (float)v.y, 0f);
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(decvec2 v) => new vec4((float)v.x, (float)v.y, 0f, 0f);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(decvec2 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator hvec3(decvec2 v) => new hvec3((Half)v.x, (Half)v.y, Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a hvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator hvec4(decvec2 v) => new hvec4((Half)v.x, (Half)v.y, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(decvec2 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec3(decvec2 v) => new dvec3((double)v.x, (double)v.y, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(decvec2 v) => new dvec4((double)v.x, (double)v.y, 0.0, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a decvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec3(decvec2 v) => new decvec3((decimal)v.x, (decimal)v.y, 0m);
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(decvec2 v) => new decvec4((decimal)v.x, (decimal)v.y, 0m, 0m);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(decvec2 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec3(decvec2 v) => new cvec3((Complex)v.x, (Complex)v.y, Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(decvec2 v) => new cvec4((Complex)v.x, (Complex)v.y, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(decvec2 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec3(decvec2 v) => new lvec3((long)v.x, (long)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(decvec2 v) => new lvec4((long)v.x, (long)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(decvec2 v) => new bvec2(v.x != 0m, v.y != 0m);
        
        /// <summary>
        /// Explicitly converts this to a bvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec3(decvec2 v) => new bvec3(v.x != 0m, v.y != 0m, false);
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(decvec2 v) => new bvec4(v.x != 0m, v.y != 0m, false, false);
        
        /// <summary>
        /// Explicitly converts this to a decimal array.
        /// </summary>
        public static explicit operator decimal[](decvec2 v) => new [] { v.x, v.y };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](decvec2 v) => new Object[] { v.x, v.y };

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
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_decvec2 swizzle => new swizzle_decvec2(x, y);
        
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
        /// Returns an array with all values
        /// </summary>
        public decimal[] Values => new[] { x, y };
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public decimal MinElement => Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public decimal MaxElement => Math.Max(x, y);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public decimal Length => (decimal)((x*x + y*y)).Sqrt();
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public decimal LengthSqr => (x*x + y*y);
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public decimal Sum => (x + y);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public decimal Norm => (decimal)((x*x + y*y)).Sqrt();
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public decimal Norm1 => (Math.Abs(x) + Math.Abs(y));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public decimal Norm2 => (decimal)((x*x + y*y)).Sqrt();
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public decimal NormMax => Math.Max(Math.Abs(x), Math.Abs(y));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public decvec2 Normalized => this / (decimal)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public decvec2 NormalizedSafe => this == Zero ? Zero : this / (decimal)Length;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public double Angle => Math.Atan2((double)y, (double)x);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static decvec2 Zero { get; } = new decvec2(0m, 0m);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static decvec2 Ones { get; } = new decvec2(1m, 1m);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static decvec2 UnitX { get; } = new decvec2(1m, 0m);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static decvec2 UnitY { get; } = new decvec2(0m, 1m);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static decvec2 MaxValue { get; } = new decvec2(decimal.MaxValue, decimal.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static decvec2 MinValue { get; } = new decvec2(decimal.MinValue, decimal.MinValue);
        
        /// <summary>
        /// Predefined all-MinusOne vector
        /// </summary>
        public static decvec2 MinusOne { get; } = new decvec2(decimal.MinusOne, decimal.MinusOne);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(decvec2 lhs, decvec2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(decvec2 lhs, decvec2 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<decimal> GetEnumerator()
        {
            yield return x;
            yield return y;
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
        public string ToString(string sep) => (x + sep + y);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => (x.ToString(provider) + sep + y.ToString(provider));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => (x.ToString(format) + sep + y.ToString(format));
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => (x.ToString(format, provider) + sep + y.ToString(format, provider));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(decvec2 rhs) => (x.Equals(rhs.x) && y.Equals(rhs.y));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is decvec2 && Equals((decvec2) obj);
        }
        
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
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow((Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p)), 1 / p);
        
        /// <summary>
        /// Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).
        /// </summary>
        public decvec2 Rotated(double angleInRad) => (decvec2)(dvec2.FromAngle(Angle + angleInRad) * (double)Length);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static decvec2 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static decvec2 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new decvec2(decimal.Parse(kvp[0].Trim()), decimal.Parse(kvp[1].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static decvec2 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new decvec2(decimal.Parse(kvp[0].Trim(), provider), decimal.Parse(kvp[1].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static decvec2 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new decvec2(decimal.Parse(kvp[0].Trim(), style), decimal.Parse(kvp[1].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static decvec2 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new decvec2(decimal.Parse(kvp[0].Trim(), style, provider), decimal.Parse(kvp[1].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out decvec2 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out decvec2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            decimal x = 0m, y = 0m;
            var ok = (decimal.TryParse(kvp[0].Trim(), out x) && decimal.TryParse(kvp[1].Trim(), out y));
            result = ok ? new decvec2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out decvec2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            decimal x = 0m, y = 0m;
            var ok = (decimal.TryParse(kvp[0].Trim(), style, provider, out x) && decimal.TryParse(kvp[1].Trim(), style, provider, out y));
            result = ok ? new decvec2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(decvec2 lhs, decvec2 rhs, decimal eps = 0.1m) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat2 OuterProduct(decvec2 c, decvec2 r) => new decmat2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat2x3 OuterProduct(decvec3 c, decvec2 r) => new decmat2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat3x2 OuterProduct(decvec2 c, decvec3 r) => new decmat3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat2x4 OuterProduct(decvec4 c, decvec2 r) => new decmat2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat4x2 OuterProduct(decvec2 c, decvec4 r) => new decmat4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types).
        /// </summary>
        public static decvec2 FromAngle(double angleInRad) => new decvec2((decimal)Math.Cos(angleInRad), (decimal)Math.Sin(angleInRad));
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static decimal Dot(decvec2 lhs, decvec2 rhs) => (lhs.x * rhs.x + lhs.y * rhs.y);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static decimal Distance(decvec2 lhs, decvec2 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static decimal DistanceSqr(decvec2 lhs, decvec2 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec2 Reflect(decvec2 I, decvec2 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec2 Refract(decvec2 I, decvec2 N, decimal eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (decimal)(k).Sqrt()) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static decvec2 FaceForward(decvec2 N, decvec2 I, decvec2 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static decimal Cross(decvec2 l, decvec2 r) => l.x * r.y - l.y * r.x;
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static decvec2 Random(Random random) => new decvec2((decimal)random.NextDouble(), (decimal)random.NextDouble());
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static decvec2 RandomSigned(Random random) => new decvec2((decimal)(random.NextDouble() * 2.0 - 1.0), (decimal)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static decvec2 RandomNormal(Random random) => new decvec2((decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (decimal)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(decvec2 lhs, decimal rhs) => new bvec2(lhs.x == rhs, lhs.y == rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(decimal lhs, decvec2 rhs) => new bvec2(lhs == rhs.x, lhs == rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(decimal lhs, decimal rhs) => new bvec2(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(decvec2 lhs, decimal rhs) => new bvec2(lhs.x != rhs, lhs.y != rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(decimal lhs, decvec2 rhs) => new bvec2(lhs != rhs.x, lhs != rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(decimal lhs, decimal rhs) => new bvec2(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(decvec2 lhs, decimal rhs) => new bvec2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(decimal lhs, decvec2 rhs) => new bvec2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(decimal lhs, decimal rhs) => new bvec2(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(decvec2 lhs, decimal rhs) => new bvec2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(decimal lhs, decvec2 rhs) => new bvec2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(decimal lhs, decimal rhs) => new bvec2(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(decvec2 lhs, decimal rhs) => new bvec2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(decimal lhs, decvec2 rhs) => new bvec2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(decimal lhs, decimal rhs) => new bvec2(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(decvec2 lhs, decimal rhs) => new bvec2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(decimal lhs, decvec2 rhs) => new bvec2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(decimal lhs, decimal rhs) => new bvec2(lhs <= rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec2 Abs(decvec2 v) => new decvec2(Math.Abs(v.x), Math.Abs(v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec2 Abs(decimal v) => new decvec2(Math.Abs(v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec2 HermiteInterpolationOrder3(decvec2 v) => new decvec2((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y);
        
        /// <summary>
        /// Returns a decvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec2 HermiteInterpolationOrder3(decimal v) => new decvec2((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec2 HermiteInterpolationOrder5(decvec2 v) => new decvec2(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a decvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec2 HermiteInterpolationOrder5(decimal v) => new decvec2(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static decvec2 Sqr(decvec2 v) => new decvec2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a decvec from the application of Sqr (v * v).
        /// </summary>
        public static decvec2 Sqr(decimal v) => new decvec2(v * v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static decvec2 Pow2(decvec2 v) => new decvec2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a decvec from the application of Pow2 (v * v).
        /// </summary>
        public static decvec2 Pow2(decimal v) => new decvec2(v * v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static decvec2 Pow3(decvec2 v) => new decvec2(v.x * v.x * v.x, v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a decvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static decvec2 Pow3(decimal v) => new decvec2(v * v * v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec2 Step(decvec2 v) => new decvec2(v.x >= 0m ? 1m : 0m, v.y >= 0m ? 1m : 0m);
        
        /// <summary>
        /// Returns a decvec from the application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec2 Step(decimal v) => new decvec2(v >= 0m ? 1m : 0m);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec2 Sqrt(decvec2 v) => new decvec2((decimal)Math.Sqrt((double)v.x), (decimal)Math.Sqrt((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec2 Sqrt(decimal v) => new decvec2((decimal)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec2 InverseSqrt(decvec2 v) => new decvec2((decimal)(1.0 / Math.Sqrt((double)v.x)), (decimal)(1.0 / Math.Sqrt((double)v.y)));
        
        /// <summary>
        /// Returns a decvec from the application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec2 InverseSqrt(decimal v) => new decvec2((decimal)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(decvec2 v) => new ivec2(Math.Sign(v.x), Math.Sign(v.y));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(decimal v) => new ivec2(Math.Sign(v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec2 Max(decvec2 lhs, decvec2 rhs) => new decvec2(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec2 Max(decvec2 lhs, decimal rhs) => new decvec2(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec2 Max(decimal lhs, decvec2 rhs) => new decvec2(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y));
        
        /// <summary>
        /// Returns a decvec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec2 Max(decimal lhs, decimal rhs) => new decvec2(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec2 Min(decvec2 lhs, decvec2 rhs) => new decvec2(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec2 Min(decvec2 lhs, decimal rhs) => new decvec2(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec2 Min(decimal lhs, decvec2 rhs) => new decvec2(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y));
        
        /// <summary>
        /// Returns a decvec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec2 Min(decimal lhs, decimal rhs) => new decvec2(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Pow(decvec2 lhs, decvec2 rhs) => new decvec2((decimal)Math.Pow((double)lhs.x, (double)rhs.x), (decimal)Math.Pow((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Pow(decvec2 lhs, decimal rhs) => new decvec2((decimal)Math.Pow((double)lhs.x, (double)rhs), (decimal)Math.Pow((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Pow(decimal lhs, decvec2 rhs) => new decvec2((decimal)Math.Pow((double)lhs, (double)rhs.x), (decimal)Math.Pow((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a decvec from the application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Pow(decimal lhs, decimal rhs) => new decvec2((decimal)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Log(decvec2 lhs, decvec2 rhs) => new decvec2((decimal)Math.Log((double)lhs.x, (double)rhs.x), (decimal)Math.Log((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Log(decvec2 lhs, decimal rhs) => new decvec2((decimal)Math.Log((double)lhs.x, (double)rhs), (decimal)Math.Log((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Log(decimal lhs, decvec2 rhs) => new decvec2((decimal)Math.Log((double)lhs, (double)rhs.x), (decimal)Math.Log((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a decvec from the application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Log(decimal lhs, decimal rhs) => new decvec2((decimal)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec2 Clamp(decvec2 v, decvec2 min, decvec2 max) => new decvec2(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec2 Clamp(decvec2 v, decvec2 min, decimal max) => new decvec2(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec2 Clamp(decvec2 v, decimal min, decvec2 max) => new decvec2(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec2 Clamp(decvec2 v, decimal min, decimal max) => new decvec2(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec2 Clamp(decimal v, decvec2 min, decvec2 max) => new decvec2(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec2 Clamp(decimal v, decvec2 min, decimal max) => new decvec2(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec2 Clamp(decimal v, decimal min, decvec2 max) => new decvec2(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y));
        
        /// <summary>
        /// Returns a decvec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec2 Clamp(decimal v, decimal min, decimal max) => new decvec2(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Mix(decvec2 min, decvec2 max, decvec2 a) => new decvec2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Mix(decvec2 min, decvec2 max, decimal a) => new decvec2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Mix(decvec2 min, decimal max, decvec2 a) => new decvec2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Mix(decvec2 min, decimal max, decimal a) => new decvec2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Mix(decimal min, decvec2 max, decvec2 a) => new decvec2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Mix(decimal min, decvec2 max, decimal a) => new decvec2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Mix(decimal min, decimal max, decvec2 a) => new decvec2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a decvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Mix(decimal min, decimal max, decimal a) => new decvec2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Lerp(decvec2 min, decvec2 max, decvec2 a) => new decvec2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Lerp(decvec2 min, decvec2 max, decimal a) => new decvec2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Lerp(decvec2 min, decimal max, decvec2 a) => new decvec2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Lerp(decvec2 min, decimal max, decimal a) => new decvec2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Lerp(decimal min, decvec2 max, decvec2 a) => new decvec2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Lerp(decimal min, decvec2 max, decimal a) => new decvec2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Lerp(decimal min, decimal max, decvec2 a) => new decvec2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a decvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Lerp(decimal min, decimal max, decimal a) => new decvec2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec2 Smoothstep(decvec2 edge0, decvec2 edge1, decvec2 v) => new decvec2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec2 Smoothstep(decvec2 edge0, decvec2 edge1, decimal v) => new decvec2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec2 Smoothstep(decvec2 edge0, decimal edge1, decvec2 v) => new decvec2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec2 Smoothstep(decvec2 edge0, decimal edge1, decimal v) => new decvec2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec2 Smoothstep(decimal edge0, decvec2 edge1, decvec2 v) => new decvec2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec2 Smoothstep(decimal edge0, decvec2 edge1, decimal v) => new decvec2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec2 Smoothstep(decimal edge0, decimal edge1, decvec2 v) => new decvec2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec2 Smoothstep(decimal edge0, decimal edge1, decimal v) => new decvec2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec2 Smootherstep(decvec2 edge0, decvec2 edge1, decvec2 v) => new decvec2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec2 Smootherstep(decvec2 edge0, decvec2 edge1, decimal v) => new decvec2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec2 Smootherstep(decvec2 edge0, decimal edge1, decvec2 v) => new decvec2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec2 Smootherstep(decvec2 edge0, decimal edge1, decimal v) => new decvec2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec2 Smootherstep(decimal edge0, decvec2 edge1, decvec2 v) => new decvec2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec2 Smootherstep(decimal edge0, decvec2 edge1, decimal v) => new decvec2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec2 Smootherstep(decimal edge0, decimal edge1, decvec2 v) => new decvec2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec2 Smootherstep(decimal edge0, decimal edge1, decimal v) => new decvec2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec2 Fma(decvec2 a, decvec2 b, decvec2 c) => new decvec2(a.x * b.x + c.x, a.y * b.y + c.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec2 Fma(decvec2 a, decvec2 b, decimal c) => new decvec2(a.x * b.x + c, a.y * b.y + c);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec2 Fma(decvec2 a, decimal b, decvec2 c) => new decvec2(a.x * b + c.x, a.y * b + c.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec2 Fma(decvec2 a, decimal b, decimal c) => new decvec2(a.x * b + c, a.y * b + c);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec2 Fma(decimal a, decvec2 b, decvec2 c) => new decvec2(a * b.x + c.x, a * b.y + c.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec2 Fma(decimal a, decvec2 b, decimal c) => new decvec2(a * b.x + c, a * b.y + c);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec2 Fma(decimal a, decimal b, decvec2 c) => new decvec2(a * b + c.x, a * b + c.y);
        
        /// <summary>
        /// Returns a decvec from the application of Fma (a * b + c).
        /// </summary>
        public static decvec2 Fma(decimal a, decimal b, decimal c) => new decvec2(a * b + c);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec2 Add(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec2 Add(decvec2 lhs, decimal rhs) => new decvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec2 Add(decimal lhs, decvec2 rhs) => new decvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a decvec from the application of Add (lhs + rhs).
        /// </summary>
        public static decvec2 Add(decimal lhs, decimal rhs) => new decvec2(lhs + rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec2 Sub(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec2 Sub(decvec2 lhs, decimal rhs) => new decvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec2 Sub(decimal lhs, decvec2 rhs) => new decvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a decvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static decvec2 Sub(decimal lhs, decimal rhs) => new decvec2(lhs - rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec2 Mul(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec2 Mul(decvec2 lhs, decimal rhs) => new decvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec2 Mul(decimal lhs, decvec2 rhs) => new decvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a decvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static decvec2 Mul(decimal lhs, decimal rhs) => new decvec2(lhs * rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec2 Div(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec2 Div(decvec2 lhs, decimal rhs) => new decvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec2 Div(decimal lhs, decvec2 rhs) => new decvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a decvec from the application of Div (lhs / rhs).
        /// </summary>
        public static decvec2 Div(decimal lhs, decimal rhs) => new decvec2(lhs / rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec2 Modulo(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec2 Modulo(decvec2 lhs, decimal rhs) => new decvec2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec2 Modulo(decimal lhs, decvec2 rhs) => new decvec2(lhs % rhs.x, lhs % rhs.y);
        
        /// <summary>
        /// Returns a decvec from the application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec2 Modulo(decimal lhs, decimal rhs) => new decvec2(lhs % rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec2 Degrees(decvec2 v) => new decvec2((decimal)(v.x * 57.295779513082320876798154814105170332405472466564321m), (decimal)(v.y * 57.295779513082320876798154814105170332405472466564321m));
        
        /// <summary>
        /// Returns a decvec from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec2 Degrees(decimal v) => new decvec2((decimal)(v * 57.295779513082320876798154814105170332405472466564321m));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec2 Radians(decvec2 v) => new decvec2((decimal)(v.x * 0.0174532925199432957692369076848861271344287188854172m), (decimal)(v.y * 0.0174532925199432957692369076848861271344287188854172m));
        
        /// <summary>
        /// Returns a decvec from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec2 Radians(decimal v) => new decvec2((decimal)(v * 0.0174532925199432957692369076848861271344287188854172m));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec2 Acos(decvec2 v) => new decvec2((decimal)Math.Acos((double)v.x), (decimal)Math.Acos((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec2 Acos(decimal v) => new decvec2((decimal)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec2 Asin(decvec2 v) => new decvec2((decimal)Math.Asin((double)v.x), (decimal)Math.Asin((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec2 Asin(decimal v) => new decvec2((decimal)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec2 Atan(decvec2 v) => new decvec2((decimal)Math.Atan((double)v.x), (decimal)Math.Atan((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec2 Atan(decimal v) => new decvec2((decimal)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec2 Cos(decvec2 v) => new decvec2((decimal)Math.Cos((double)v.x), (decimal)Math.Cos((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec2 Cos(decimal v) => new decvec2((decimal)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec2 Cosh(decvec2 v) => new decvec2((decimal)Math.Cosh((double)v.x), (decimal)Math.Cosh((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec2 Cosh(decimal v) => new decvec2((decimal)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec2 Exp(decvec2 v) => new decvec2((decimal)Math.Exp((double)v.x), (decimal)Math.Exp((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec2 Exp(decimal v) => new decvec2((decimal)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec2 Log(decvec2 v) => new decvec2((decimal)Math.Log((double)v.x), (decimal)Math.Log((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec2 Log(decimal v) => new decvec2((decimal)Math.Log((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec2 Log2(decvec2 v) => new decvec2((decimal)Math.Log((double)v.x, 2), (decimal)Math.Log((double)v.y, 2));
        
        /// <summary>
        /// Returns a decvec from the application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec2 Log2(decimal v) => new decvec2((decimal)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec2 Log10(decvec2 v) => new decvec2((decimal)Math.Log10((double)v.x), (decimal)Math.Log10((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec2 Log10(decimal v) => new decvec2((decimal)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec2 Floor(decvec2 v) => new decvec2((decimal)Math.Floor(v.x), (decimal)Math.Floor(v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec2 Floor(decimal v) => new decvec2((decimal)Math.Floor(v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec2 Ceiling(decvec2 v) => new decvec2((decimal)Math.Ceiling(v.x), (decimal)Math.Ceiling(v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec2 Ceiling(decimal v) => new decvec2((decimal)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec2 Round(decvec2 v) => new decvec2((decimal)Math.Round(v.x), (decimal)Math.Round(v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec2 Round(decimal v) => new decvec2((decimal)Math.Round(v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec2 Sin(decvec2 v) => new decvec2((decimal)Math.Sin((double)v.x), (decimal)Math.Sin((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec2 Sin(decimal v) => new decvec2((decimal)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec2 Sinh(decvec2 v) => new decvec2((decimal)Math.Sinh((double)v.x), (decimal)Math.Sinh((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec2 Sinh(decimal v) => new decvec2((decimal)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec2 Tan(decvec2 v) => new decvec2((decimal)Math.Tan((double)v.x), (decimal)Math.Tan((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec2 Tan(decimal v) => new decvec2((decimal)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec2 Tanh(decvec2 v) => new decvec2((decimal)Math.Tanh((double)v.x), (decimal)Math.Tanh((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec2 Tanh(decimal v) => new decvec2((decimal)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec2 Truncate(decvec2 v) => new decvec2((decimal)Math.Truncate((double)v.x), (decimal)Math.Truncate((double)v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec2 Truncate(decimal v) => new decvec2((decimal)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec2 Fract(decvec2 v) => new decvec2((decimal)(v.x - Math.Floor(v.x)), (decimal)(v.y - Math.Floor(v.y)));
        
        /// <summary>
        /// Returns a decvec from the application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec2 Fract(decimal v) => new decvec2((decimal)(v - Math.Floor(v)));
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static decvec2 Trunc(decvec2 v) => new decvec2((long)(v.x), (long)(v.y));
        
        /// <summary>
        /// Returns a decvec from the application of Trunc ((long)(v)).
        /// </summary>
        public static decvec2 Trunc(decimal v) => new decvec2((long)(v));
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 Random(Random random, decvec2 minValue, decvec2 maxValue) => new decvec2((decimal)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 Random(Random random, decvec2 minValue, decimal maxValue) => new decvec2((decimal)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 Random(Random random, decimal minValue, decvec2 maxValue) => new decvec2((decimal)random.NextDouble() * (maxValue.x - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.y - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 Random(Random random, decimal minValue, decimal maxValue) => new decvec2((decimal)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 RandomUniform(Random random, decvec2 minValue, decvec2 maxValue) => new decvec2((decimal)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 RandomUniform(Random random, decvec2 minValue, decimal maxValue) => new decvec2((decimal)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (decimal)random.NextDouble() * (maxValue - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 RandomUniform(Random random, decimal minValue, decvec2 maxValue) => new decvec2((decimal)random.NextDouble() * (maxValue.x - minValue) + minValue, (decimal)random.NextDouble() * (maxValue.y - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 RandomUniform(Random random, decimal minValue, decimal maxValue) => new decvec2((decimal)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomNormal(Random random, decvec2 mean, decvec2 variance) => new decvec2((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomNormal(Random random, decvec2 mean, decimal variance) => new decvec2((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomNormal(Random random, decimal mean, decvec2 variance) => new decvec2((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomNormal(Random random, decimal mean, decimal variance) => new decvec2((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomGaussian(Random random, decvec2 mean, decvec2 variance) => new decvec2((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomGaussian(Random random, decvec2 mean, decimal variance) => new decvec2((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomGaussian(Random random, decimal mean, decvec2 variance) => new decvec2((decimal)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (decimal)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomGaussian(Random random, decimal mean, decimal variance) => new decvec2((decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec2 operator<(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec2 operator<(decvec2 lhs, decimal rhs) => new bvec2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec2 operator<(decimal lhs, decvec2 rhs) => new bvec2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 operator<=(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 operator<=(decvec2 lhs, decimal rhs) => new bvec2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 operator<=(decimal lhs, decvec2 rhs) => new bvec2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec2 operator>(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec2 operator>(decvec2 lhs, decimal rhs) => new bvec2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec2 operator>(decimal lhs, decvec2 rhs) => new bvec2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 operator>=(decvec2 lhs, decvec2 rhs) => new bvec2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 operator>=(decvec2 lhs, decimal rhs) => new bvec2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 operator>=(decimal lhs, decvec2 rhs) => new bvec2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decvec2 operator+(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decvec2 operator+(decvec2 lhs, decimal rhs) => new decvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decvec2 operator+(decimal lhs, decvec2 rhs) => new decvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decvec2 operator-(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decvec2 operator-(decvec2 lhs, decimal rhs) => new decvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decvec2 operator-(decimal lhs, decvec2 rhs) => new decvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decvec2 operator*(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decvec2 operator*(decvec2 lhs, decimal rhs) => new decvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decvec2 operator*(decimal lhs, decvec2 rhs) => new decvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decvec2 operator/(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decvec2 operator/(decvec2 lhs, decimal rhs) => new decvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decvec2 operator/(decimal lhs, decvec2 rhs) => new decvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator+ (identity).
        /// </summary>
        public static decvec2 operator+(decvec2 v) => v;
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator- (-v).
        /// </summary>
        public static decvec2 operator-(decvec2 v) => new decvec2(-v.x, -v.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static decvec2 operator%(decvec2 lhs, decvec2 rhs) => new decvec2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static decvec2 operator%(decvec2 lhs, decimal rhs) => new decvec2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static decvec2 operator%(decimal lhs, decvec2 rhs) => new decvec2(lhs % rhs.x, lhs % rhs.y);

        #endregion

    }
}
