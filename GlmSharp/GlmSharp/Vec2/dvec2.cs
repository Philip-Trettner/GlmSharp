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
    /// A vector of type double with 2 components.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "vec")]
    [StructLayout(LayoutKind.Sequential)]
    public struct dvec2 : IReadOnlyList<double>, IEquatable<dvec2>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public double x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public double y;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public dvec2(double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public dvec2(double v)
        {
            this.x = v;
            this.y = v;
        }
        
        /// <summary>
        /// from-vector constructor
        /// </summary>
        public dvec2(dvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public dvec2(dvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// from-vector constructor (additional fields are truncated)
        /// </summary>
        public dvec2(dvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
        }
        
        /// <summary>
        /// From-array/list constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec2(IReadOnlyList<double> v)
        {
            var c = v.Count;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
        }
        
        /// <summary>
        /// Generic from-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec2(Object[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : (double)v[0];
            this.y = c < 1 ? 0.0 : (double)v[1];
        }
        
        /// <summary>
        /// From-array constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec2(double[] v)
        {
            var c = v.Length;
            this.x = c < 0 ? 0.0 : v[0];
            this.y = c < 1 ? 0.0 : v[1];
        }
        
        /// <summary>
        /// From-array constructor with base index (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec2(double[] v, int startIndex)
        {
            var c = v.Length;
            this.x = c + startIndex < 0 ? 0.0 : v[0 + startIndex];
            this.y = c + startIndex < 1 ? 0.0 : v[1 + startIndex];
        }
        
        /// <summary>
        /// From-IEnumerable constructor (superfluous values are ignored, missing values are zero-filled).
        /// </summary>
        public dvec2(IEnumerable<double> v)
            : this(v.ToArray())
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a cvec2.
        /// </summary>
        public static implicit operator cvec2(dvec2 v) => new cvec2((Complex)v.x, (Complex)v.y);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(dvec2 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec3(dvec2 v) => new ivec3((int)v.x, (int)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a ivec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator ivec4(dvec2 v) => new ivec4((int)v.x, (int)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(dvec2 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec3(dvec2 v) => new uvec3((uint)v.x, (uint)v.y, 0u);
        
        /// <summary>
        /// Explicitly converts this to a uvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator uvec4(dvec2 v) => new uvec4((uint)v.x, (uint)v.y, 0u, 0u);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(dvec2 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec3(dvec2 v) => new vec3((float)v.x, (float)v.y, 0f);
        
        /// <summary>
        /// Explicitly converts this to a vec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator vec4(dvec2 v) => new vec4((float)v.x, (float)v.y, 0f, 0f);
        
        /// <summary>
        /// Explicitly converts this to a hvec2.
        /// </summary>
        public static explicit operator hvec2(dvec2 v) => new hvec2((Half)v.x, (Half)v.y);
        
        /// <summary>
        /// Explicitly converts this to a hvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator hvec3(dvec2 v) => new hvec3((Half)v.x, (Half)v.y, Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a hvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator hvec4(dvec2 v) => new hvec4((Half)v.x, (Half)v.y, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a dvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec3(dvec2 v) => new dvec3((double)v.x, (double)v.y, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a dvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator dvec4(dvec2 v) => new dvec4((double)v.x, (double)v.y, 0.0, 0.0);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(dvec2 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec3(dvec2 v) => new decvec3((decimal)v.x, (decimal)v.y, 0m);
        
        /// <summary>
        /// Explicitly converts this to a decvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator decvec4(dvec2 v) => new decvec4((decimal)v.x, (decimal)v.y, 0m, 0m);
        
        /// <summary>
        /// Explicitly converts this to a cvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec3(dvec2 v) => new cvec3((Complex)v.x, (Complex)v.y, Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(dvec2 v) => new cvec4((Complex)v.x, (Complex)v.y, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(dvec2 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec3(dvec2 v) => new lvec3((long)v.x, (long)v.y, 0);
        
        /// <summary>
        /// Explicitly converts this to a lvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator lvec4(dvec2 v) => new lvec4((long)v.x, (long)v.y, 0, 0);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(dvec2 v) => new bvec2(v.x != 0.0, v.y != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bvec3. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec3(dvec2 v) => new bvec3(v.x != 0.0, v.y != 0.0, false);
        
        /// <summary>
        /// Explicitly converts this to a bvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator bvec4(dvec2 v) => new bvec4(v.x != 0.0, v.y != 0.0, false, false);
        
        /// <summary>
        /// Explicitly converts this to a double array.
        /// </summary>
        public static explicit operator double[](dvec2 v) => new [] { v.x, v.y };
        
        /// <summary>
        /// Explicitly converts this to a generic object array.
        /// </summary>
        public static explicit operator Object[](dvec2 v) => new Object[] { v.x, v.y };

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public double this[int index]
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
        public swizzle_dvec2 swizzle => new swizzle_dvec2(x, y);
        
        /// <summary>
        /// Gets or sets the specified subset of components. For more advanced (read-only) swizzling, use the .swizzle property.
        /// </summary>
        public dvec2 xy
        {
            get
            {
                return new dvec2(x, y);
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
        public dvec2 rg
        {
            get
            {
                return new dvec2(x, y);
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
        public double r
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
        public double g
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
        public double[] Values => new[] { x, y };
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public int Count => 2;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public double MinElement => Math.Min(x, y);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public double MaxElement => Math.Max(x, y);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => (x*x + y*y);
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public double Sum => (x + y);
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => (Math.Abs(x) + Math.Abs(y));
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt((x*x + y*y));
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => Math.Max(Math.Abs(x), Math.Abs(y));
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public dvec2 Normalized => this / (double)Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public dvec2 NormalizedSafe => this == Zero ? Zero : this / (double)Length;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public double Angle => Math.Atan2((double)y, (double)x);

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static dvec2 Zero { get; } = new dvec2(0.0, 0.0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static dvec2 Ones { get; } = new dvec2(1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static dvec2 UnitX { get; } = new dvec2(1.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static dvec2 UnitY { get; } = new dvec2(0.0, 1.0);
        
        /// <summary>
        /// Predefined all-MaxValue vector
        /// </summary>
        public static dvec2 MaxValue { get; } = new dvec2(double.MaxValue, double.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static dvec2 MinValue { get; } = new dvec2(double.MinValue, double.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static dvec2 Epsilon { get; } = new dvec2(double.Epsilon, double.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static dvec2 NaN { get; } = new dvec2(double.NaN, double.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static dvec2 NegativeInfinity { get; } = new dvec2(double.NegativeInfinity, double.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static dvec2 PositiveInfinity { get; } = new dvec2(double.PositiveInfinity, double.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(dvec2 lhs, dvec2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(dvec2 lhs, dvec2 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
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
        public bool Equals(dvec2 rhs) => (x.Equals(rhs.x) && y.Equals(rhs.y));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is dvec2 && Equals((dvec2) obj);
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
        public dvec2 Rotated(double angleInRad) => (dvec2)(dvec2.FromAngle(Angle + angleInRad) * (double)Length);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static dvec2 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static dvec2 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new dvec2(double.Parse(kvp[0].Trim()), double.Parse(kvp[1].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static dvec2 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new dvec2(double.Parse(kvp[0].Trim(), provider), double.Parse(kvp[1].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static dvec2 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new dvec2(double.Parse(kvp[0].Trim(), style), double.Parse(kvp[1].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static dvec2 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) throw new FormatException("input has not exactly 2 parts");
            return new dvec2(double.Parse(kvp[0].Trim(), style, provider), double.Parse(kvp[1].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out dvec2 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out dvec2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            double x = 0.0, y = 0.0;
            var ok = (double.TryParse(kvp[0].Trim(), out x) && double.TryParse(kvp[1].Trim(), out y));
            result = ok ? new dvec2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out dvec2 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 2) return false;
            double x = 0.0, y = 0.0;
            var ok = (double.TryParse(kvp[0].Trim(), style, provider, out x) && double.TryParse(kvp[1].Trim(), style, provider, out y));
            result = ok ? new dvec2(x, y) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(dvec2 lhs, dvec2 rhs, double eps = 0.1d) => Distance(lhs, rhs) <= eps;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat2 OuterProduct(dvec2 c, dvec2 r) => new dmat2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat2x3 OuterProduct(dvec3 c, dvec2 r) => new dmat2x3(c.x * r.x, c.y * r.x, c.z * r.x, c.x * r.y, c.y * r.y, c.z * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat3x2 OuterProduct(dvec2 c, dvec3 r) => new dmat3x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat2x4 OuterProduct(dvec4 c, dvec2 r) => new dmat2x4(c.x * r.x, c.y * r.x, c.z * r.x, c.w * r.x, c.x * r.y, c.y * r.y, c.z * r.y, c.w * r.y);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat4x2 OuterProduct(dvec2 c, dvec4 r) => new dmat4x2(c.x * r.x, c.y * r.x, c.x * r.y, c.y * r.y, c.x * r.z, c.y * r.z, c.x * r.w, c.y * r.w);
        
        /// <summary>
        /// Returns a unit 2D vector with a given angle in radians (CAUTION: result may be truncated for integer types).
        /// </summary>
        public static dvec2 FromAngle(double angleInRad) => new dvec2((double)Math.Cos(angleInRad), (double)Math.Sin(angleInRad));
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(dvec2 lhs, dvec2 rhs) => (lhs.x * rhs.x + lhs.y * rhs.y);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(dvec2 lhs, dvec2 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(dvec2 lhs, dvec2 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec2 Reflect(dvec2 I, dvec2 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec2 Refract(dvec2 I, dvec2 N, double eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (double)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static dvec2 FaceForward(dvec2 N, dvec2 I, dvec2 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static double Cross(dvec2 l, dvec2 r) => l.x * r.y - l.y * r.x;
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 0.0 and 1.0.
        /// </summary>
        public static dvec2 Random(Random random) => new dvec2((double)random.NextDouble(), (double)random.NextDouble());
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between -1.0 and 1.0.
        /// </summary>
        public static dvec2 RandomSigned(Random random) => new dvec2((double)(random.NextDouble() * 2.0 - 1.0), (double)(random.NextDouble() * 2.0 - 1.0));
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal distribution (zero mean, unit variance).
        /// </summary>
        public static dvec2 RandomNormal(Random random) => new dvec2((double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))), (double)(Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))));

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x == rhs.x, lhs.y == rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(dvec2 lhs, double rhs) => new bvec2(lhs.x == rhs, lhs.y == rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(double lhs, dvec2 rhs) => new bvec2(lhs == rhs.x, lhs == rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(double lhs, double rhs) => new bvec2(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x != rhs.x, lhs.y != rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(dvec2 lhs, double rhs) => new bvec2(lhs.x != rhs, lhs.y != rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(double lhs, dvec2 rhs) => new bvec2(lhs != rhs.x, lhs != rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(double lhs, double rhs) => new bvec2(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(dvec2 lhs, double rhs) => new bvec2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(double lhs, dvec2 rhs) => new bvec2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(double lhs, double rhs) => new bvec2(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(dvec2 lhs, double rhs) => new bvec2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(double lhs, dvec2 rhs) => new bvec2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(double lhs, double rhs) => new bvec2(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(dvec2 lhs, double rhs) => new bvec2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(double lhs, dvec2 rhs) => new bvec2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(double lhs, double rhs) => new bvec2(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(dvec2 lhs, double rhs) => new bvec2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(double lhs, dvec2 rhs) => new bvec2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(double lhs, double rhs) => new bvec2(lhs <= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsInfinity(dvec2 v) => new bvec2(double.IsInfinity(v.x), double.IsInfinity(v.y));
        
        /// <summary>
        /// Returns a bvec from the application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsInfinity(double v) => new bvec2(double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsFinite(dvec2 v) => new bvec2(!double.IsNaN(v.x) && !double.IsInfinity(v.x), !double.IsNaN(v.y) && !double.IsInfinity(v.y));
        
        /// <summary>
        /// Returns a bvec from the application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsFinite(double v) => new bvec2(!double.IsNaN(v) && !double.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec2 IsNaN(dvec2 v) => new bvec2(double.IsNaN(v.x), double.IsNaN(v.y));
        
        /// <summary>
        /// Returns a bvec from the application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec2 IsNaN(double v) => new bvec2(double.IsNaN(v));
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec2 IsNegativeInfinity(dvec2 v) => new bvec2(double.IsNegativeInfinity(v.x), double.IsNegativeInfinity(v.y));
        
        /// <summary>
        /// Returns a bvec from the application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec2 IsNegativeInfinity(double v) => new bvec2(double.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec2 IsPositiveInfinity(dvec2 v) => new bvec2(double.IsPositiveInfinity(v.x), double.IsPositiveInfinity(v.y));
        
        /// <summary>
        /// Returns a bvec from the application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec2 IsPositiveInfinity(double v) => new bvec2(double.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec2 Abs(dvec2 v) => new dvec2(Math.Abs(v.x), Math.Abs(v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec2 Abs(double v) => new dvec2(Math.Abs(v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec2 HermiteInterpolationOrder3(dvec2 v) => new dvec2((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y);
        
        /// <summary>
        /// Returns a dvec from the application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec2 HermiteInterpolationOrder3(double v) => new dvec2((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec2 HermiteInterpolationOrder5(dvec2 v) => new dvec2(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a dvec from the application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec2 HermiteInterpolationOrder5(double v) => new dvec2(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static dvec2 Sqr(dvec2 v) => new dvec2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a dvec from the application of Sqr (v * v).
        /// </summary>
        public static dvec2 Sqr(double v) => new dvec2(v * v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static dvec2 Pow2(dvec2 v) => new dvec2(v.x * v.x, v.y * v.y);
        
        /// <summary>
        /// Returns a dvec from the application of Pow2 (v * v).
        /// </summary>
        public static dvec2 Pow2(double v) => new dvec2(v * v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static dvec2 Pow3(dvec2 v) => new dvec2(v.x * v.x * v.x, v.y * v.y * v.y);
        
        /// <summary>
        /// Returns a dvec from the application of Pow3 (v * v * v).
        /// </summary>
        public static dvec2 Pow3(double v) => new dvec2(v * v * v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec2 Step(dvec2 v) => new dvec2(v.x >= 0.0 ? 1.0 : 0.0, v.y >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a dvec from the application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec2 Step(double v) => new dvec2(v >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec2 Sqrt(dvec2 v) => new dvec2((double)Math.Sqrt((double)v.x), (double)Math.Sqrt((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec2 Sqrt(double v) => new dvec2((double)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec2 InverseSqrt(dvec2 v) => new dvec2((double)(1.0 / Math.Sqrt((double)v.x)), (double)(1.0 / Math.Sqrt((double)v.y)));
        
        /// <summary>
        /// Returns a dvec from the application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec2 InverseSqrt(double v) => new dvec2((double)(1.0 / Math.Sqrt((double)v)));
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(dvec2 v) => new ivec2(Math.Sign(v.x), Math.Sign(v.y));
        
        /// <summary>
        /// Returns a ivec from the application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(double v) => new ivec2(Math.Sign(v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec2 Max(dvec2 lhs, dvec2 rhs) => new dvec2(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec2 Max(dvec2 lhs, double rhs) => new dvec2(Math.Max(lhs.x, rhs), Math.Max(lhs.y, rhs));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec2 Max(double lhs, dvec2 rhs) => new dvec2(Math.Max(lhs, rhs.x), Math.Max(lhs, rhs.y));
        
        /// <summary>
        /// Returns a dvec from the application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec2 Max(double lhs, double rhs) => new dvec2(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec2 Min(dvec2 lhs, dvec2 rhs) => new dvec2(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec2 Min(dvec2 lhs, double rhs) => new dvec2(Math.Min(lhs.x, rhs), Math.Min(lhs.y, rhs));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec2 Min(double lhs, dvec2 rhs) => new dvec2(Math.Min(lhs, rhs.x), Math.Min(lhs, rhs.y));
        
        /// <summary>
        /// Returns a dvec from the application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec2 Min(double lhs, double rhs) => new dvec2(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Pow(dvec2 lhs, dvec2 rhs) => new dvec2((double)Math.Pow((double)lhs.x, (double)rhs.x), (double)Math.Pow((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Pow(dvec2 lhs, double rhs) => new dvec2((double)Math.Pow((double)lhs.x, (double)rhs), (double)Math.Pow((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Pow(double lhs, dvec2 rhs) => new dvec2((double)Math.Pow((double)lhs, (double)rhs.x), (double)Math.Pow((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a dvec from the application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Pow(double lhs, double rhs) => new dvec2((double)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Log(dvec2 lhs, dvec2 rhs) => new dvec2((double)Math.Log((double)lhs.x, (double)rhs.x), (double)Math.Log((double)lhs.y, (double)rhs.y));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Log(dvec2 lhs, double rhs) => new dvec2((double)Math.Log((double)lhs.x, (double)rhs), (double)Math.Log((double)lhs.y, (double)rhs));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Log(double lhs, dvec2 rhs) => new dvec2((double)Math.Log((double)lhs, (double)rhs.x), (double)Math.Log((double)lhs, (double)rhs.y));
        
        /// <summary>
        /// Returns a dvec from the application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Log(double lhs, double rhs) => new dvec2((double)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec2 Clamp(dvec2 v, dvec2 min, dvec2 max) => new dvec2(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec2 Clamp(dvec2 v, dvec2 min, double max) => new dvec2(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec2 Clamp(dvec2 v, double min, dvec2 max) => new dvec2(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec2 Clamp(dvec2 v, double min, double max) => new dvec2(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec2 Clamp(double v, dvec2 min, dvec2 max) => new dvec2(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec2 Clamp(double v, dvec2 min, double max) => new dvec2(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec2 Clamp(double v, double min, dvec2 max) => new dvec2(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y));
        
        /// <summary>
        /// Returns a dvec from the application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec2 Clamp(double v, double min, double max) => new dvec2(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Mix(dvec2 min, dvec2 max, dvec2 a) => new dvec2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Mix(dvec2 min, dvec2 max, double a) => new dvec2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Mix(dvec2 min, double max, dvec2 a) => new dvec2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Mix(dvec2 min, double max, double a) => new dvec2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Mix(double min, dvec2 max, dvec2 a) => new dvec2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Mix(double min, dvec2 max, double a) => new dvec2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Mix(double min, double max, dvec2 a) => new dvec2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a dvec from the application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Mix(double min, double max, double a) => new dvec2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Lerp(dvec2 min, dvec2 max, dvec2 a) => new dvec2(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Lerp(dvec2 min, dvec2 max, double a) => new dvec2(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Lerp(dvec2 min, double max, dvec2 a) => new dvec2(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Lerp(dvec2 min, double max, double a) => new dvec2(min.x * (1-a) + max * a, min.y * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Lerp(double min, dvec2 max, dvec2 a) => new dvec2(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Lerp(double min, dvec2 max, double a) => new dvec2(min * (1-a) + max.x * a, min * (1-a) + max.y * a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Lerp(double min, double max, dvec2 a) => new dvec2(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y);
        
        /// <summary>
        /// Returns a dvec from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Lerp(double min, double max, double a) => new dvec2(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec2 Smoothstep(dvec2 edge0, dvec2 edge1, dvec2 v) => new dvec2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec2 Smoothstep(dvec2 edge0, dvec2 edge1, double v) => new dvec2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec2 Smoothstep(dvec2 edge0, double edge1, dvec2 v) => new dvec2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec2 Smoothstep(dvec2 edge0, double edge1, double v) => new dvec2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec2 Smoothstep(double edge0, dvec2 edge1, dvec2 v) => new dvec2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec2 Smoothstep(double edge0, dvec2 edge1, double v) => new dvec2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec2 Smoothstep(double edge0, double edge1, dvec2 v) => new dvec2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec from the application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec2 Smoothstep(double edge0, double edge1, double v) => new dvec2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec2 Smootherstep(dvec2 edge0, dvec2 edge1, dvec2 v) => new dvec2(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec2 Smootherstep(dvec2 edge0, dvec2 edge1, double v) => new dvec2(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec2 Smootherstep(dvec2 edge0, double edge1, dvec2 v) => new dvec2(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec2 Smootherstep(dvec2 edge0, double edge1, double v) => new dvec2(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec2 Smootherstep(double edge0, dvec2 edge1, dvec2 v) => new dvec2(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec2 Smootherstep(double edge0, dvec2 edge1, double v) => new dvec2(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec2 Smootherstep(double edge0, double edge1, dvec2 v) => new dvec2(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec from the application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec2 Smootherstep(double edge0, double edge1, double v) => new dvec2(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec2 Fma(dvec2 a, dvec2 b, dvec2 c) => new dvec2(a.x * b.x + c.x, a.y * b.y + c.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec2 Fma(dvec2 a, dvec2 b, double c) => new dvec2(a.x * b.x + c, a.y * b.y + c);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec2 Fma(dvec2 a, double b, dvec2 c) => new dvec2(a.x * b + c.x, a.y * b + c.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec2 Fma(dvec2 a, double b, double c) => new dvec2(a.x * b + c, a.y * b + c);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec2 Fma(double a, dvec2 b, dvec2 c) => new dvec2(a * b.x + c.x, a * b.y + c.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec2 Fma(double a, dvec2 b, double c) => new dvec2(a * b.x + c, a * b.y + c);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec2 Fma(double a, double b, dvec2 c) => new dvec2(a * b + c.x, a * b + c.y);
        
        /// <summary>
        /// Returns a dvec from the application of Fma (a * b + c).
        /// </summary>
        public static dvec2 Fma(double a, double b, double c) => new dvec2(a * b + c);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec2 Add(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec2 Add(dvec2 lhs, double rhs) => new dvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec2 Add(double lhs, dvec2 rhs) => new dvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a dvec from the application of Add (lhs + rhs).
        /// </summary>
        public static dvec2 Add(double lhs, double rhs) => new dvec2(lhs + rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec2 Sub(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec2 Sub(dvec2 lhs, double rhs) => new dvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec2 Sub(double lhs, dvec2 rhs) => new dvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a dvec from the application of Sub (lhs - rhs).
        /// </summary>
        public static dvec2 Sub(double lhs, double rhs) => new dvec2(lhs - rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec2 Mul(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec2 Mul(dvec2 lhs, double rhs) => new dvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec2 Mul(double lhs, dvec2 rhs) => new dvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a dvec from the application of Mul (lhs * rhs).
        /// </summary>
        public static dvec2 Mul(double lhs, double rhs) => new dvec2(lhs * rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec2 Div(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec2 Div(dvec2 lhs, double rhs) => new dvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec2 Div(double lhs, dvec2 rhs) => new dvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a dvec from the application of Div (lhs / rhs).
        /// </summary>
        public static dvec2 Div(double lhs, double rhs) => new dvec2(lhs / rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec2 Modulo(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec2 Modulo(dvec2 lhs, double rhs) => new dvec2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec2 Modulo(double lhs, dvec2 rhs) => new dvec2(lhs % rhs.x, lhs % rhs.y);
        
        /// <summary>
        /// Returns a dvec from the application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec2 Modulo(double lhs, double rhs) => new dvec2(lhs % rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec2 Degrees(dvec2 v) => new dvec2((double)(v.x * 57.295779513082320876798154814105170332405472466564321d), (double)(v.y * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a dvec from the application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec2 Degrees(double v) => new dvec2((double)(v * 57.295779513082320876798154814105170332405472466564321d));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec2 Radians(dvec2 v) => new dvec2((double)(v.x * 0.0174532925199432957692369076848861271344287188854172d), (double)(v.y * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a dvec from the application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec2 Radians(double v) => new dvec2((double)(v * 0.0174532925199432957692369076848861271344287188854172d));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec2 Acos(dvec2 v) => new dvec2((double)Math.Acos((double)v.x), (double)Math.Acos((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec2 Acos(double v) => new dvec2((double)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec2 Asin(dvec2 v) => new dvec2((double)Math.Asin((double)v.x), (double)Math.Asin((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec2 Asin(double v) => new dvec2((double)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec2 Atan(dvec2 v) => new dvec2((double)Math.Atan((double)v.x), (double)Math.Atan((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec2 Atan(double v) => new dvec2((double)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec2 Cos(dvec2 v) => new dvec2((double)Math.Cos((double)v.x), (double)Math.Cos((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec2 Cos(double v) => new dvec2((double)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec2 Cosh(dvec2 v) => new dvec2((double)Math.Cosh((double)v.x), (double)Math.Cosh((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec2 Cosh(double v) => new dvec2((double)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec2 Exp(dvec2 v) => new dvec2((double)Math.Exp((double)v.x), (double)Math.Exp((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec2 Exp(double v) => new dvec2((double)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec2 Log(dvec2 v) => new dvec2((double)Math.Log((double)v.x), (double)Math.Log((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec2 Log(double v) => new dvec2((double)Math.Log((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec2 Log2(dvec2 v) => new dvec2((double)Math.Log((double)v.x, 2), (double)Math.Log((double)v.y, 2));
        
        /// <summary>
        /// Returns a dvec from the application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec2 Log2(double v) => new dvec2((double)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec2 Log10(dvec2 v) => new dvec2((double)Math.Log10((double)v.x), (double)Math.Log10((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec2 Log10(double v) => new dvec2((double)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec2 Floor(dvec2 v) => new dvec2((double)Math.Floor(v.x), (double)Math.Floor(v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec2 Floor(double v) => new dvec2((double)Math.Floor(v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec2 Ceiling(dvec2 v) => new dvec2((double)Math.Ceiling(v.x), (double)Math.Ceiling(v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec2 Ceiling(double v) => new dvec2((double)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec2 Round(dvec2 v) => new dvec2((double)Math.Round(v.x), (double)Math.Round(v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec2 Round(double v) => new dvec2((double)Math.Round(v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec2 Sin(dvec2 v) => new dvec2((double)Math.Sin((double)v.x), (double)Math.Sin((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec2 Sin(double v) => new dvec2((double)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec2 Sinh(dvec2 v) => new dvec2((double)Math.Sinh((double)v.x), (double)Math.Sinh((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec2 Sinh(double v) => new dvec2((double)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec2 Tan(dvec2 v) => new dvec2((double)Math.Tan((double)v.x), (double)Math.Tan((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec2 Tan(double v) => new dvec2((double)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec2 Tanh(dvec2 v) => new dvec2((double)Math.Tanh((double)v.x), (double)Math.Tanh((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec2 Tanh(double v) => new dvec2((double)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec2 Truncate(dvec2 v) => new dvec2((double)Math.Truncate((double)v.x), (double)Math.Truncate((double)v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec2 Truncate(double v) => new dvec2((double)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec2 Fract(dvec2 v) => new dvec2((double)(v.x - Math.Floor(v.x)), (double)(v.y - Math.Floor(v.y)));
        
        /// <summary>
        /// Returns a dvec from the application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec2 Fract(double v) => new dvec2((double)(v - Math.Floor(v)));
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static dvec2 Trunc(dvec2 v) => new dvec2((long)(v.x), (long)(v.y));
        
        /// <summary>
        /// Returns a dvec from the application of Trunc ((long)(v)).
        /// </summary>
        public static dvec2 Trunc(double v) => new dvec2((long)(v));
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 Random(Random random, dvec2 minValue, dvec2 maxValue) => new dvec2((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 Random(Random random, dvec2 minValue, double maxValue) => new dvec2((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 Random(Random random, double minValue, dvec2 maxValue) => new dvec2((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 Random(Random random, double minValue, double maxValue) => new dvec2((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 RandomUniform(Random random, dvec2 minValue, dvec2 maxValue) => new dvec2((double)random.NextDouble() * (maxValue.x - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue.y - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 RandomUniform(Random random, dvec2 minValue, double maxValue) => new dvec2((double)random.NextDouble() * (maxValue - minValue.x) + minValue.x, (double)random.NextDouble() * (maxValue - minValue.y) + minValue.y);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 RandomUniform(Random random, double minValue, dvec2 maxValue) => new dvec2((double)random.NextDouble() * (maxValue.x - minValue) + minValue, (double)random.NextDouble() * (maxValue.y - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 RandomUniform(Random random, double minValue, double maxValue) => new dvec2((double)random.NextDouble() * (maxValue - minValue) + minValue);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomNormal(Random random, dvec2 mean, dvec2 variance) => new dvec2((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomNormal(Random random, dvec2 mean, double variance) => new dvec2((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomNormal(Random random, double mean, dvec2 variance) => new dvec2((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomNormal(Random random, double mean, double variance) => new dvec2((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomGaussian(Random random, dvec2 mean, dvec2 variance) => new dvec2((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomGaussian(Random random, dvec2 mean, double variance) => new dvec2((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.x, (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean.y);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomGaussian(Random random, double mean, dvec2 variance) => new dvec2((double)(Math.Sqrt((double)variance.x) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean, (double)(Math.Sqrt((double)variance.y) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomGaussian(Random random, double mean, double variance) => new dvec2((double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec2 operator<(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x < rhs.x, lhs.y < rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec2 operator<(dvec2 lhs, double rhs) => new bvec2(lhs.x < rhs, lhs.y < rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec2 operator<(double lhs, dvec2 rhs) => new bvec2(lhs < rhs.x, lhs < rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 operator<=(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x <= rhs.x, lhs.y <= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 operator<=(dvec2 lhs, double rhs) => new bvec2(lhs.x <= rhs, lhs.y <= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 operator<=(double lhs, dvec2 rhs) => new bvec2(lhs <= rhs.x, lhs <= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec2 operator>(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x > rhs.x, lhs.y > rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec2 operator>(dvec2 lhs, double rhs) => new bvec2(lhs.x > rhs, lhs.y > rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec2 operator>(double lhs, dvec2 rhs) => new bvec2(lhs > rhs.x, lhs > rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 operator>=(dvec2 lhs, dvec2 rhs) => new bvec2(lhs.x >= rhs.x, lhs.y >= rhs.y);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 operator>=(dvec2 lhs, double rhs) => new bvec2(lhs.x >= rhs, lhs.y >= rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 operator>=(double lhs, dvec2 rhs) => new bvec2(lhs >= rhs.x, lhs >= rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static dvec2 operator+(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x + rhs.x, lhs.y + rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static dvec2 operator+(dvec2 lhs, double rhs) => new dvec2(lhs.x + rhs, lhs.y + rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static dvec2 operator+(double lhs, dvec2 rhs) => new dvec2(lhs + rhs.x, lhs + rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static dvec2 operator-(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x - rhs.x, lhs.y - rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static dvec2 operator-(dvec2 lhs, double rhs) => new dvec2(lhs.x - rhs, lhs.y - rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static dvec2 operator-(double lhs, dvec2 rhs) => new dvec2(lhs - rhs.x, lhs - rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static dvec2 operator*(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x * rhs.x, lhs.y * rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static dvec2 operator*(dvec2 lhs, double rhs) => new dvec2(lhs.x * rhs, lhs.y * rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static dvec2 operator*(double lhs, dvec2 rhs) => new dvec2(lhs * rhs.x, lhs * rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static dvec2 operator/(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x / rhs.x, lhs.y / rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static dvec2 operator/(dvec2 lhs, double rhs) => new dvec2(lhs.x / rhs, lhs.y / rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static dvec2 operator/(double lhs, dvec2 rhs) => new dvec2(lhs / rhs.x, lhs / rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator+ (identity).
        /// </summary>
        public static dvec2 operator+(dvec2 v) => v;
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator- (-v).
        /// </summary>
        public static dvec2 operator-(dvec2 v) => new dvec2(-v.x, -v.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static dvec2 operator%(dvec2 lhs, dvec2 rhs) => new dvec2(lhs.x % rhs.x, lhs.y % rhs.y);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static dvec2 operator%(dvec2 lhs, double rhs) => new dvec2(lhs.x % rhs, lhs.y % rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of operator% (lhs % rhs).
        /// </summary>
        public static dvec2 operator%(double lhs, dvec2 rhs) => new dvec2(lhs % rhs.x, lhs % rhs.y);

        #endregion

    }
}
