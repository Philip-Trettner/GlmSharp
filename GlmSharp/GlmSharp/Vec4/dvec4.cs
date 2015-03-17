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
    /// A vector of type double with 4 components.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct dvec4 : IReadOnlyList<double>, IEquatable<dvec4>
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
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public double z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public double w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public dvec4(double x, double y, double z, double w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public dvec4(double v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec4(dvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0.0;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public dvec4(dvec2 v, double z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public dvec4(dvec2 v, double z, double w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec4(dvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public dvec4(dvec3 v, double w)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = w;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public dvec4(dvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = v.w;
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a cvec4.
        /// </summary>
        public static implicit operator cvec4(dvec4 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec2.
        /// </summary>
        public static explicit operator ivec2(dvec4 v) => new ivec2((int)v.x, (int)v.y);
        
        /// <summary>
        /// Explicitly converts this to a ivec3.
        /// </summary>
        public static explicit operator ivec3(dvec4 v) => new ivec3((int)v.x, (int)v.y, (int)v.z);
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(dvec4 v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec2.
        /// </summary>
        public static explicit operator uvec2(dvec4 v) => new uvec2((uint)v.x, (uint)v.y);
        
        /// <summary>
        /// Explicitly converts this to a uvec3.
        /// </summary>
        public static explicit operator uvec3(dvec4 v) => new uvec3((uint)v.x, (uint)v.y, (uint)v.z);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(dvec4 v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec2.
        /// </summary>
        public static explicit operator vec2(dvec4 v) => new vec2((float)v.x, (float)v.y);
        
        /// <summary>
        /// Explicitly converts this to a vec3.
        /// </summary>
        public static explicit operator vec3(dvec4 v) => new vec3((float)v.x, (float)v.y, (float)v.z);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(dvec4 v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec2.
        /// </summary>
        public static explicit operator dvec2(dvec4 v) => new dvec2((double)v.x, (double)v.y);
        
        /// <summary>
        /// Explicitly converts this to a dvec3.
        /// </summary>
        public static explicit operator dvec3(dvec4 v) => new dvec3((double)v.x, (double)v.y, (double)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec2.
        /// </summary>
        public static explicit operator decvec2(dvec4 v) => new decvec2((decimal)v.x, (decimal)v.y);
        
        /// <summary>
        /// Explicitly converts this to a decvec3.
        /// </summary>
        public static explicit operator decvec3(dvec4 v) => new decvec3((decimal)v.x, (decimal)v.y, (decimal)v.z);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(dvec4 v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(dvec4 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec3.
        /// </summary>
        public static explicit operator cvec3(dvec4 v) => new cvec3((Complex)v.x, (Complex)v.y, (Complex)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec2.
        /// </summary>
        public static explicit operator lvec2(dvec4 v) => new lvec2((long)v.x, (long)v.y);
        
        /// <summary>
        /// Explicitly converts this to a lvec3.
        /// </summary>
        public static explicit operator lvec3(dvec4 v) => new lvec3((long)v.x, (long)v.y, (long)v.z);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(dvec4 v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bvec2.
        /// </summary>
        public static explicit operator bvec2(dvec4 v) => new bvec2(v.x != 0.0, v.y != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bvec3.
        /// </summary>
        public static explicit operator bvec3(dvec4 v) => new bvec3(v.x != 0.0, v.y != 0.0, v.z != 0.0);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(dvec4 v) => new bvec4(v.x != 0.0, v.y != 0.0, v.z != 0.0, v.w != 0.0);

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
                    case 2: return z;
                    case 3: return w;
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
                    case 3: w = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an object that can be used for swizzling (e.g. swizzle.zy)
        /// </summary>
        public swizzle_dvec4 swizzle => new swizzle_dvec4(x, y, z, w);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public double[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static dvec4 Zero { get; } = new dvec4(0.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static dvec4 Ones { get; } = new dvec4(1.0, 1.0, 1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static dvec4 UnitX { get; } = new dvec4(1.0, 0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static dvec4 UnitY { get; } = new dvec4(0.0, 1.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static dvec4 UnitZ { get; } = new dvec4(0.0, 0.0, 1.0, 0.0);
        
        /// <summary>
        /// Predefined unit-W vector
        /// </summary>
        public static dvec4 UnitW { get; } = new dvec4(0.0, 0.0, 0.0, 1.0);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(dvec4 lhs, dvec4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(dvec4 lhs, dvec4 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<double> GetEnumerator()
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
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(dvec4 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z) && w.Equals(rhs.w);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is dvec4 && Equals((dvec4) obj);
        }
        
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

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(dvec4 lhs, double rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(double lhs, dvec4 rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(double lhs, double rhs) => new bvec4(lhs == rhs);

        #endregion

        
        /// <summary>
        /// Returns a boolean vector with component-wise not-equal.
        /// </summary>
        public static bvec4 NotEqual(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than.
        /// </summary>
        public static bvec4 GreaterThan(dvec4 lhs, dvec4 rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise greater-than-or-equal.
        /// </summary>
        public static bvec4 GreaterThanEqual(dvec4 lhs, dvec4 rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than.
        /// </summary>
        public static bvec4 LesserThan(dvec4 lhs, dvec4 rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a boolean vector with component-wise lesser-than-or-equal.
        /// </summary>
        public static bvec4 LesserThanEqual(dvec4 lhs, dvec4 rhs) => lhs <= rhs;
        
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
        public static dvec4 MaxValue { get; } = new dvec4(double.MaxValue, double.MaxValue, double.MaxValue, double.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue vector
        /// </summary>
        public static dvec4 MinValue { get; } = new dvec4(double.MinValue, double.MinValue, double.MinValue, double.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon vector
        /// </summary>
        public static dvec4 Epsilon { get; } = new dvec4(double.Epsilon, double.Epsilon, double.Epsilon, double.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN vector
        /// </summary>
        public static dvec4 NaN { get; } = new dvec4(double.NaN, double.NaN, double.NaN, double.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity vector
        /// </summary>
        public static dvec4 NegativeInfinity { get; } = new dvec4(double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity, double.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity vector
        /// </summary>
        public static dvec4 PositiveInfinity { get; } = new dvec4(double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity, double.PositiveInfinity);
        
        /// <summary>
        /// Executes a component-wise IsInfinity
        /// </summary>
        public static bvec4 IsInfinity(dvec4 v) => new bvec4(double.IsInfinity(v.x), double.IsInfinity(v.y), double.IsInfinity(v.z), double.IsInfinity(v.w));
        
        /// <summary>
        /// Executes a component-wise IsFinite
        /// </summary>
        public static bvec4 IsFinite(dvec4 v) => new bvec4(!double.IsNaN(v.x) && !double.IsInfinity(v.x), !double.IsNaN(v.y) && !double.IsInfinity(v.y), !double.IsNaN(v.z) && !double.IsInfinity(v.z), !double.IsNaN(v.w) && !double.IsInfinity(v.w));
        
        /// <summary>
        /// Executes a component-wise IsNaN
        /// </summary>
        public static bvec4 IsNaN(dvec4 v) => new bvec4(double.IsNaN(v.x), double.IsNaN(v.y), double.IsNaN(v.z), double.IsNaN(v.w));
        
        /// <summary>
        /// Executes a component-wise IsNegativeInfinity
        /// </summary>
        public static bvec4 IsNegativeInfinity(dvec4 v) => new bvec4(double.IsNegativeInfinity(v.x), double.IsNegativeInfinity(v.y), double.IsNegativeInfinity(v.z), double.IsNegativeInfinity(v.w));
        
        /// <summary>
        /// Executes a component-wise IsPositiveInfinity
        /// </summary>
        public static bvec4 IsPositiveInfinity(dvec4 v) => new bvec4(double.IsPositiveInfinity(v.x), double.IsPositiveInfinity(v.y), double.IsPositiveInfinity(v.z), double.IsPositiveInfinity(v.w));
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using ', ' as a separator).
        /// </summary>
        public static dvec4 Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator).
        /// </summary>
        public static dvec4 Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new dvec4(double.Parse(kvp[0].Trim()), double.Parse(kvp[1].Trim()), double.Parse(kvp[2].Trim()), double.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a type provider).
        /// </summary>
        public static dvec4 Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new dvec4(double.Parse(kvp[0].Trim(), provider), double.Parse(kvp[1].Trim(), provider), double.Parse(kvp[2].Trim(), provider), double.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style).
        /// </summary>
        public static dvec4 Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new dvec4(double.Parse(kvp[0].Trim(), style), double.Parse(kvp[1].Trim(), style), double.Parse(kvp[2].Trim(), style), double.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static dvec4 Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new dvec4(double.Parse(kvp[0].Trim(), style, provider), double.Parse(kvp[1].Trim(), style, provider), double.Parse(kvp[2].Trim(), style, provider), double.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out dvec4 result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out dvec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            double x = 0.0, y = 0.0, z = 0.0, w = 0.0;
            var ok = double.TryParse(kvp[0].Trim(), out x) && double.TryParse(kvp[1].Trim(), out y) && double.TryParse(kvp[2].Trim(), out z) && double.TryParse(kvp[3].Trim(), out w);
            result = ok ? new dvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the vector into a vector representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out dvec4 result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            double x = 0.0, y = 0.0, z = 0.0, w = 0.0;
            var ok = double.TryParse(kvp[0].Trim(), style, provider, out x) && double.TryParse(kvp[1].Trim(), style, provider, out y) && double.TryParse(kvp[2].Trim(), style, provider, out z) && double.TryParse(kvp[3].Trim(), style, provider, out w);
            result = ok ? new dvec4(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public double MinElement => Math.Min(Math.Min(Math.Min(x, y), z), w);
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public double MaxElement => Math.Max(Math.Max(Math.Max(x, y), z), w);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt(x*x + y*y + z*z + w*w);
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => x*x + y*y + z*z + w*w;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public double Sum => x + y + z + w;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt(x*x + y*y + z*z + w*w);
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => Math.Abs(x) + Math.Abs(y) + Math.Abs(z) + Math.Abs(w);
        
        /// <summary>
        /// Returns the two-norm of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(x*x + y*y + z*z + w*w);
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => Math.Max(Math.Max(Math.Max(Math.Abs(x), Math.Abs(y)), Math.Abs(z)), Math.Abs(w));
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public double NormP(double p) => Math.Pow(Math.Pow((double)Math.Abs(x), p) + Math.Pow((double)Math.Abs(y), p) + Math.Pow((double)Math.Abs(z), p) + Math.Pow((double)Math.Abs(w), p), 1 / p);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static dvec4 operator+(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static dvec4 operator+(dvec4 lhs, double rhs) => new dvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static dvec4 operator+(double lhs, dvec4 rhs) => new dvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(dvec4 lhs, cvec4 rhs) => new cvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(cvec4 lhs, dvec4 rhs) => new cvec4(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(dvec4 lhs, Complex rhs) => new cvec4(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator+(Complex lhs, dvec4 rhs) => new cvec4(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static dvec4 operator-(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static dvec4 operator-(dvec4 lhs, double rhs) => new dvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static dvec4 operator-(double lhs, dvec4 rhs) => new dvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(dvec4 lhs, cvec4 rhs) => new cvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(cvec4 lhs, dvec4 rhs) => new cvec4(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(dvec4 lhs, Complex rhs) => new cvec4(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator-(Complex lhs, dvec4 rhs) => new cvec4(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static dvec4 operator/(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static dvec4 operator/(dvec4 lhs, double rhs) => new dvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static dvec4 operator/(double lhs, dvec4 rhs) => new dvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(dvec4 lhs, cvec4 rhs) => new cvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(cvec4 lhs, dvec4 rhs) => new cvec4(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z, lhs.w / rhs.w);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(dvec4 lhs, Complex rhs) => new cvec4(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator/(Complex lhs, dvec4 rhs) => new cvec4(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z, lhs / rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static dvec4 operator*(dvec4 lhs, dvec4 rhs) => new dvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static dvec4 operator*(dvec4 lhs, double rhs) => new dvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static dvec4 operator*(double lhs, dvec4 rhs) => new dvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(dvec4 lhs, cvec4 rhs) => new cvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(cvec4 lhs, dvec4 rhs) => new cvec4(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z, lhs.w * rhs.w);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(dvec4 lhs, Complex rhs) => new cvec4(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar (upcast to cvec4).
        /// </summary>
        public static cvec4 operator*(Complex lhs, dvec4 rhs) => new cvec4(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Executes a component-wise unary + (add).
        /// </summary>
        public static dvec4 operator+(dvec4 v) => v;
        
        /// <summary>
        /// Executes a component-wise unary - (subtract).
        /// </summary>
        public static dvec4 operator-(dvec4 v) => new dvec4(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bvec4 operator<(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator<(dvec4 lhs, double rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator<(double lhs, dvec4 rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bvec4 operator<=(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator<=(dvec4 lhs, double rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator<=(double lhs, dvec4 rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bvec4 operator>(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator>(dvec4 lhs, double rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bvec4 operator>(double lhs, dvec4 rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bvec4 operator>=(dvec4 lhs, dvec4 rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator>=(dvec4 lhs, double rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bvec4 operator>=(double lhs, dvec4 rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public dvec4 Normalized => this / Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public dvec4 NormalizedSafe => this == Zero ? Zero : this / Length;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(dvec4 lhs, dvec4 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z + lhs.w * rhs.w;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(dvec4 lhs, dvec4 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(dvec4 lhs, dvec4 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec4 Reflect(dvec4 I, dvec4 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec4 Refract(dvec4 I, dvec4 N, double eta)
        {
            var dNI = Dot(N, I);
            var k = 1 - eta * eta * (1 - dNI * dNI);
            if (k < 0) return Zero;
            return eta * I - (eta * dNI + (double)Math.Sqrt(k)) * N;
        }
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static dvec4 FaceForward(dvec4 N, dvec4 I, dvec4 Nref) => Dot(Nref, I) < 0 ? N : -N;
        
        /// <summary>
        /// Returns a component-wise executed Abs.
        /// </summary>
        public static dvec4 Abs(dvec4 v) => new dvec4(Math.Abs(v.x), Math.Abs(v.y), Math.Abs(v.z), Math.Abs(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Abs with a scalar.
        /// </summary>
        public static dvec4 Abs(double v) => new dvec4(Math.Abs(v));
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder3.
        /// </summary>
        public static dvec4 HermiteInterpolationOrder3(dvec4 v) => new dvec4((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z, (3 - 2 * v.w) * v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder3 with a scalar.
        /// </summary>
        public static dvec4 HermiteInterpolationOrder3(double v) => new dvec4((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder5.
        /// </summary>
        public static dvec4 HermiteInterpolationOrder5(dvec4 v) => new dvec4(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z, ((6 * v.w - 15) * v.w + 10) * v.w * v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed HermiteInterpolationOrder5 with a scalar.
        /// </summary>
        public static dvec4 HermiteInterpolationOrder5(double v) => new dvec4(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a component-wise executed Step.
        /// </summary>
        public static dvec4 Step(dvec4 v) => new dvec4(v.x >= 0.0 ? 1.0 : 0.0, v.y >= 0.0 ? 1.0 : 0.0, v.z >= 0.0 ? 1.0 : 0.0, v.w >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a component-wise executed Step with a scalar.
        /// </summary>
        public static dvec4 Step(double v) => new dvec4(v >= 0.0 ? 1.0 : 0.0);
        
        /// <summary>
        /// Returns a component-wise executed Acos.
        /// </summary>
        public static dvec4 Acos(dvec4 v) => new dvec4((double)Math.Acos((double)v.x), (double)Math.Acos((double)v.y), (double)Math.Acos((double)v.z), (double)Math.Acos((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Acos with a scalar.
        /// </summary>
        public static dvec4 Acos(double v) => new dvec4((double)Math.Acos((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Asin.
        /// </summary>
        public static dvec4 Asin(dvec4 v) => new dvec4((double)Math.Asin((double)v.x), (double)Math.Asin((double)v.y), (double)Math.Asin((double)v.z), (double)Math.Asin((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Asin with a scalar.
        /// </summary>
        public static dvec4 Asin(double v) => new dvec4((double)Math.Asin((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Atan.
        /// </summary>
        public static dvec4 Atan(dvec4 v) => new dvec4((double)Math.Atan((double)v.x), (double)Math.Atan((double)v.y), (double)Math.Atan((double)v.z), (double)Math.Atan((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Atan with a scalar.
        /// </summary>
        public static dvec4 Atan(double v) => new dvec4((double)Math.Atan((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Cos.
        /// </summary>
        public static dvec4 Cos(dvec4 v) => new dvec4((double)Math.Cos((double)v.x), (double)Math.Cos((double)v.y), (double)Math.Cos((double)v.z), (double)Math.Cos((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Cos with a scalar.
        /// </summary>
        public static dvec4 Cos(double v) => new dvec4((double)Math.Cos((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Cosh.
        /// </summary>
        public static dvec4 Cosh(dvec4 v) => new dvec4((double)Math.Cosh((double)v.x), (double)Math.Cosh((double)v.y), (double)Math.Cosh((double)v.z), (double)Math.Cosh((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Cosh with a scalar.
        /// </summary>
        public static dvec4 Cosh(double v) => new dvec4((double)Math.Cosh((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Exp.
        /// </summary>
        public static dvec4 Exp(dvec4 v) => new dvec4((double)Math.Exp((double)v.x), (double)Math.Exp((double)v.y), (double)Math.Exp((double)v.z), (double)Math.Exp((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Exp with a scalar.
        /// </summary>
        public static dvec4 Exp(double v) => new dvec4((double)Math.Exp((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static dvec4 Log(dvec4 v) => new dvec4((double)Math.Log((double)v.x), (double)Math.Log((double)v.y), (double)Math.Log((double)v.z), (double)Math.Log((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static dvec4 Log(double v) => new dvec4((double)Math.Log((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Log2.
        /// </summary>
        public static dvec4 Log2(dvec4 v) => new dvec4((double)Math.Log((double)v.x, 2), (double)Math.Log((double)v.y, 2), (double)Math.Log((double)v.z, 2), (double)Math.Log((double)v.w, 2));
        
        /// <summary>
        /// Returns a component-wise executed Log2 with a scalar.
        /// </summary>
        public static dvec4 Log2(double v) => new dvec4((double)Math.Log((double)v, 2));
        
        /// <summary>
        /// Returns a component-wise executed Log10.
        /// </summary>
        public static dvec4 Log10(dvec4 v) => new dvec4((double)Math.Log10((double)v.x), (double)Math.Log10((double)v.y), (double)Math.Log10((double)v.z), (double)Math.Log10((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Log10 with a scalar.
        /// </summary>
        public static dvec4 Log10(double v) => new dvec4((double)Math.Log10((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Floor.
        /// </summary>
        public static dvec4 Floor(dvec4 v) => new dvec4((double)Math.Floor(v.x), (double)Math.Floor(v.y), (double)Math.Floor(v.z), (double)Math.Floor(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Floor with a scalar.
        /// </summary>
        public static dvec4 Floor(double v) => new dvec4((double)Math.Floor(v));
        
        /// <summary>
        /// Returns a component-wise executed Ceiling.
        /// </summary>
        public static dvec4 Ceiling(dvec4 v) => new dvec4((double)Math.Ceiling(v.x), (double)Math.Ceiling(v.y), (double)Math.Ceiling(v.z), (double)Math.Ceiling(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Ceiling with a scalar.
        /// </summary>
        public static dvec4 Ceiling(double v) => new dvec4((double)Math.Ceiling(v));
        
        /// <summary>
        /// Returns a component-wise executed Round.
        /// </summary>
        public static dvec4 Round(dvec4 v) => new dvec4((double)Math.Round(v.x), (double)Math.Round(v.y), (double)Math.Round(v.z), (double)Math.Round(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Round with a scalar.
        /// </summary>
        public static dvec4 Round(double v) => new dvec4((double)Math.Round(v));
        
        /// <summary>
        /// Returns a component-wise executed Sin.
        /// </summary>
        public static dvec4 Sin(dvec4 v) => new dvec4((double)Math.Sin((double)v.x), (double)Math.Sin((double)v.y), (double)Math.Sin((double)v.z), (double)Math.Sin((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Sin with a scalar.
        /// </summary>
        public static dvec4 Sin(double v) => new dvec4((double)Math.Sin((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Sinh.
        /// </summary>
        public static dvec4 Sinh(dvec4 v) => new dvec4((double)Math.Sinh((double)v.x), (double)Math.Sinh((double)v.y), (double)Math.Sinh((double)v.z), (double)Math.Sinh((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Sinh with a scalar.
        /// </summary>
        public static dvec4 Sinh(double v) => new dvec4((double)Math.Sinh((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Sqrt.
        /// </summary>
        public static dvec4 Sqrt(dvec4 v) => new dvec4((double)Math.Sqrt((double)v.x), (double)Math.Sqrt((double)v.y), (double)Math.Sqrt((double)v.z), (double)Math.Sqrt((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Sqrt with a scalar.
        /// </summary>
        public static dvec4 Sqrt(double v) => new dvec4((double)Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Tan.
        /// </summary>
        public static dvec4 Tan(dvec4 v) => new dvec4((double)Math.Tan((double)v.x), (double)Math.Tan((double)v.y), (double)Math.Tan((double)v.z), (double)Math.Tan((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Tan with a scalar.
        /// </summary>
        public static dvec4 Tan(double v) => new dvec4((double)Math.Tan((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Tanh.
        /// </summary>
        public static dvec4 Tanh(dvec4 v) => new dvec4((double)Math.Tanh((double)v.x), (double)Math.Tanh((double)v.y), (double)Math.Tanh((double)v.z), (double)Math.Tanh((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Tanh with a scalar.
        /// </summary>
        public static dvec4 Tanh(double v) => new dvec4((double)Math.Tanh((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Truncate.
        /// </summary>
        public static dvec4 Truncate(dvec4 v) => new dvec4((double)Math.Truncate((double)v.x), (double)Math.Truncate((double)v.y), (double)Math.Truncate((double)v.z), (double)Math.Truncate((double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Truncate with a scalar.
        /// </summary>
        public static dvec4 Truncate(double v) => new dvec4((double)Math.Truncate((double)v));
        
        /// <summary>
        /// Returns a component-wise executed Sign.
        /// </summary>
        public static ivec4 Sign(dvec4 v) => new ivec4(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z), Math.Sign(v.w));
        
        /// <summary>
        /// Returns a component-wise executed Sign with a scalar.
        /// </summary>
        public static ivec4 Sign(double v) => new ivec4(Math.Sign(v));
        
        /// <summary>
        /// Returns a component-wise executed radians-to-degrees conversion.
        /// </summary>
        public static dvec4 Degrees(dvec4 v) => v * 57.295779513082320876798154814105170332405472466564321d;
        
        /// <summary>
        /// Returns a component-wise executed radians-to-degrees conversion with a scalar.
        /// </summary>
        public static dvec4 Degrees(double v) => new dvec4(v * 57.295779513082320876798154814105170332405472466564321d);
        
        /// <summary>
        /// Returns a component-wise executed degrees-to-radians conversion.
        /// </summary>
        public static dvec4 Radians(dvec4 v) => v * 0.0174532925199432957692369076848861271344287188854172d;
        
        /// <summary>
        /// Returns a component-wise executed degrees-to-radians conversion with a scalar.
        /// </summary>
        public static dvec4 Radians(double v) => new dvec4(v * 0.0174532925199432957692369076848861271344287188854172d);
        
        /// <summary>
        /// Returns a component-wise executed Sqr.
        /// </summary>
        public static dvec4 Sqr(dvec4 v) => new dvec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed Sqr with a scalar.
        /// </summary>
        public static dvec4 Sqr(double v) => new dvec4(v * v);
        
        /// <summary>
        /// Returns a component-wise executed Pow2.
        /// </summary>
        public static dvec4 Pow2(dvec4 v) => new dvec4(v.x * v.x, v.y * v.y, v.z * v.z, v.w * v.w);
        
        /// <summary>
        /// Returns a component-wise executed Pow2 with a scalar.
        /// </summary>
        public static dvec4 Pow2(double v) => new dvec4(v * v);
        
        /// <summary>
        /// Returns a component-wise executed Max.
        /// </summary>
        public static dvec4 Max(dvec4 lhs, dvec4 rhs) => new dvec4(Math.Max(lhs.x, rhs.x), Math.Max(lhs.y, rhs.y), Math.Max(lhs.z, rhs.z), Math.Max(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static dvec4 Max(dvec4 v, double s) => new dvec4(Math.Max(v.x, s), Math.Max(v.y, s), Math.Max(v.z, s), Math.Max(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed Max with a scalar.
        /// </summary>
        public static dvec4 Max(double s, dvec4 v) => new dvec4(Math.Max(s, v.x), Math.Max(s, v.y), Math.Max(s, v.z), Math.Max(s, v.w));
        
        /// <summary>
        /// Returns a component-wise executed Max with scalars.
        /// </summary>
        public static dvec4 Max(double lhs, double rhs) => new dvec4(Math.Max(lhs, rhs));
        
        /// <summary>
        /// Returns a component-wise executed Min.
        /// </summary>
        public static dvec4 Min(dvec4 lhs, dvec4 rhs) => new dvec4(Math.Min(lhs.x, rhs.x), Math.Min(lhs.y, rhs.y), Math.Min(lhs.z, rhs.z), Math.Min(lhs.w, rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static dvec4 Min(dvec4 v, double s) => new dvec4(Math.Min(v.x, s), Math.Min(v.y, s), Math.Min(v.z, s), Math.Min(v.w, s));
        
        /// <summary>
        /// Returns a component-wise executed Min with a scalar.
        /// </summary>
        public static dvec4 Min(double s, dvec4 v) => new dvec4(Math.Min(s, v.x), Math.Min(s, v.y), Math.Min(s, v.z), Math.Min(s, v.w));
        
        /// <summary>
        /// Returns a component-wise executed Min with scalars.
        /// </summary>
        public static dvec4 Min(double lhs, double rhs) => new dvec4(Math.Min(lhs, rhs));
        
        /// <summary>
        /// Returns a component-wise executed Pow.
        /// </summary>
        public static dvec4 Pow(dvec4 lhs, dvec4 rhs) => new dvec4((double)Math.Pow((double)lhs.x, (double)rhs.x), (double)Math.Pow((double)lhs.y, (double)rhs.y), (double)Math.Pow((double)lhs.z, (double)rhs.z), (double)Math.Pow((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static dvec4 Pow(dvec4 v, double s) => new dvec4((double)Math.Pow((double)v.x, (double)s), (double)Math.Pow((double)v.y, (double)s), (double)Math.Pow((double)v.z, (double)s), (double)Math.Pow((double)v.w, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Pow with a scalar.
        /// </summary>
        public static dvec4 Pow(double s, dvec4 v) => new dvec4((double)Math.Pow((double)s, (double)v.x), (double)Math.Pow((double)s, (double)v.y), (double)Math.Pow((double)s, (double)v.z), (double)Math.Pow((double)s, (double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Pow with scalars.
        /// </summary>
        public static dvec4 Pow(double lhs, double rhs) => new dvec4((double)Math.Pow((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a component-wise executed Log.
        /// </summary>
        public static dvec4 Log(dvec4 lhs, dvec4 rhs) => new dvec4((double)Math.Log((double)lhs.x, (double)rhs.x), (double)Math.Log((double)lhs.y, (double)rhs.y), (double)Math.Log((double)lhs.z, (double)rhs.z), (double)Math.Log((double)lhs.w, (double)rhs.w));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static dvec4 Log(dvec4 v, double s) => new dvec4((double)Math.Log((double)v.x, (double)s), (double)Math.Log((double)v.y, (double)s), (double)Math.Log((double)v.z, (double)s), (double)Math.Log((double)v.w, (double)s));
        
        /// <summary>
        /// Returns a component-wise executed Log with a scalar.
        /// </summary>
        public static dvec4 Log(double s, dvec4 v) => new dvec4((double)Math.Log((double)s, (double)v.x), (double)Math.Log((double)s, (double)v.y), (double)Math.Log((double)s, (double)v.z), (double)Math.Log((double)s, (double)v.w));
        
        /// <summary>
        /// Returns a component-wise executed Log with scalars.
        /// </summary>
        public static dvec4 Log(double lhs, double rhs) => new dvec4((double)Math.Log((double)lhs, (double)rhs));
        
        /// <summary>
        /// Returns a component-wise executed Clamp.
        /// </summary>
        public static dvec4 Clamp(dvec4 v, dvec4 min, dvec4 max) => new dvec4(Math.Min(Math.Max(v.x, min.x), max.x), Math.Min(Math.Max(v.y, min.y), max.y), Math.Min(Math.Max(v.z, min.z), max.z), Math.Min(Math.Max(v.w, min.w), max.w));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static dvec4 Clamp(double v, dvec4 min, dvec4 max) => new dvec4(Math.Min(Math.Max(v, min.x), max.x), Math.Min(Math.Max(v, min.y), max.y), Math.Min(Math.Max(v, min.z), max.z), Math.Min(Math.Max(v, min.w), max.w));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static dvec4 Clamp(dvec4 v, double min, dvec4 max) => new dvec4(Math.Min(Math.Max(v.x, min), max.x), Math.Min(Math.Max(v.y, min), max.y), Math.Min(Math.Max(v.z, min), max.z), Math.Min(Math.Max(v.w, min), max.w));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static dvec4 Clamp(dvec4 v, dvec4 min, double max) => new dvec4(Math.Min(Math.Max(v.x, min.x), max), Math.Min(Math.Max(v.y, min.y), max), Math.Min(Math.Max(v.z, min.z), max), Math.Min(Math.Max(v.w, min.w), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static dvec4 Clamp(double v, double min, dvec4 max) => new dvec4(Math.Min(Math.Max(v, min), max.x), Math.Min(Math.Max(v, min), max.y), Math.Min(Math.Max(v, min), max.z), Math.Min(Math.Max(v, min), max.w));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static dvec4 Clamp(dvec4 v, double min, double max) => new dvec4(Math.Min(Math.Max(v.x, min), max), Math.Min(Math.Max(v.y, min), max), Math.Min(Math.Max(v.z, min), max), Math.Min(Math.Max(v.w, min), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static dvec4 Clamp(double v, dvec4 min, double max) => new dvec4(Math.Min(Math.Max(v, min.x), max), Math.Min(Math.Max(v, min.y), max), Math.Min(Math.Max(v, min.z), max), Math.Min(Math.Max(v, min.w), max));
        
        /// <summary>
        /// Returns a component-wise executed Clamp with scalars.
        /// </summary>
        public static dvec4 Clamp(double v, double min, double max) => new dvec4(Math.Min(Math.Max(v, min), max));
        
        /// <summary>
        /// Returns a component-wise executed Mix.
        /// </summary>
        public static dvec4 Mix(dvec4 min, dvec4 max, dvec4 a) => new dvec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static dvec4 Mix(double min, dvec4 max, dvec4 a) => new dvec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static dvec4 Mix(dvec4 min, double max, dvec4 a) => new dvec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static dvec4 Mix(dvec4 min, dvec4 max, double a) => new dvec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static dvec4 Mix(double min, double max, dvec4 a) => new dvec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static dvec4 Mix(dvec4 min, double max, double a) => new dvec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static dvec4 Mix(double min, dvec4 max, double a) => new dvec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a component-wise executed Mix with scalars.
        /// </summary>
        public static dvec4 Mix(double min, double max, double a) => new dvec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp.
        /// </summary>
        public static dvec4 Lerp(dvec4 min, dvec4 max, dvec4 a) => new dvec4(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static dvec4 Lerp(double min, dvec4 max, dvec4 a) => new dvec4(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static dvec4 Lerp(dvec4 min, double max, dvec4 a) => new dvec4(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static dvec4 Lerp(dvec4 min, dvec4 max, double a) => new dvec4(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static dvec4 Lerp(double min, double max, dvec4 a) => new dvec4(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static dvec4 Lerp(dvec4 min, double max, double a) => new dvec4(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static dvec4 Lerp(double min, dvec4 max, double a) => new dvec4(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a component-wise executed Lerp with scalars.
        /// </summary>
        public static dvec4 Lerp(double min, double max, double a) => new dvec4(min * (1-a) + max * a);
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep.
        /// </summary>
        public static dvec4 Smoothstep(dvec4 edge0, dvec4 edge1, dvec4 v) => new dvec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static dvec4 Smoothstep(double edge0, dvec4 edge1, dvec4 v) => new dvec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static dvec4 Smoothstep(dvec4 edge0, double edge1, dvec4 v) => new dvec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static dvec4 Smoothstep(dvec4 edge0, dvec4 edge1, double v) => new dvec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static dvec4 Smoothstep(double edge0, double edge1, dvec4 v) => new dvec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static dvec4 Smoothstep(dvec4 edge0, double edge1, double v) => new dvec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder3(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static dvec4 Smoothstep(double edge0, dvec4 edge1, double v) => new dvec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder3(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smoothstep with scalars.
        /// </summary>
        public static dvec4 Smoothstep(double edge0, double edge1, double v) => new dvec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep.
        /// </summary>
        public static dvec4 Smootherstep(dvec4 edge0, dvec4 edge1, dvec4 v) => new dvec4(((v.x - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static dvec4 Smootherstep(double edge0, dvec4 edge1, dvec4 v) => new dvec4(((v.x - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static dvec4 Smootherstep(dvec4 edge0, double edge1, dvec4 v) => new dvec4(((v.x - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static dvec4 Smootherstep(dvec4 edge0, dvec4 edge1, double v) => new dvec4(((v - edge0.x) / (edge1.x - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1.y - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1.z - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1.w - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static dvec4 Smootherstep(double edge0, double edge1, dvec4 v) => new dvec4(((v.x - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.y - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.z - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5(), ((v.w - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static dvec4 Smootherstep(dvec4 edge0, double edge1, double v) => new dvec4(((v - edge0.x) / (edge1 - edge0.x)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.y) / (edge1 - edge0.y)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.z) / (edge1 - edge0.z)).Clamp().HermiteInterpolationOrder5(), ((v - edge0.w) / (edge1 - edge0.w)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static dvec4 Smootherstep(double edge0, dvec4 edge1, double v) => new dvec4(((v - edge0) / (edge1.x - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.y - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.z - edge0)).Clamp().HermiteInterpolationOrder5(), ((v - edge0) / (edge1.w - edge0)).Clamp().HermiteInterpolationOrder5());
        
        /// <summary>
        /// Returns a component-wise executed Smootherstep with scalars.
        /// </summary>
        public static dvec4 Smootherstep(double edge0, double edge1, double v) => new dvec4(((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5());
    }
}
