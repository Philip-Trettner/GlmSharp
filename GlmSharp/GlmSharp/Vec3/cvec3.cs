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
    /// A vector of type Complex with 3 components.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct cvec3 : IReadOnlyList<Complex>, IEquatable<cvec3>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public Complex x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public Complex y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public Complex z;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public cvec3(Complex x, Complex y, Complex z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public cvec3(Complex v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public cvec3(cvec2 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = 0.0;
        }
        
        /// <summary>
        /// from-vector-and-value constructor (empty fields are zero/false)
        /// </summary>
        public cvec3(cvec2 v, Complex z)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public cvec3(cvec3 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }
        
        /// <summary>
        /// from-vector constructor (empty fields are zero/false)
        /// </summary>
        public cvec3(cvec4 v)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a cvec2.
        /// </summary>
        public static explicit operator cvec2(cvec3 v) => new cvec2((Complex)v.x, (Complex)v.y);
        
        /// <summary>
        /// Explicitly converts this to a cvec4. (Higher components are zeroed)
        /// </summary>
        public static explicit operator cvec4(cvec3 v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, 0.0);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public Complex this[int index]
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
        public swizzle_cvec3 swizzle => new swizzle_cvec3(x, y, z);
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public Complex[] Values => new[] { x, y, z };
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public int Count => 3;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public double Length => (double)Math.Sqrt(x.LengthSqr() + y.LengthSqr() + z.LengthSqr());
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public double LengthSqr => x.LengthSqr() + y.LengthSqr() + z.LengthSqr();
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public Complex Sum => x + y + z;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public double Norm => (double)Math.Sqrt(x.LengthSqr() + y.LengthSqr() + z.LengthSqr());
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public double Norm1 => x.Magnitude + y.Magnitude + z.Magnitude;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public double Norm2 => (double)Math.Sqrt(x.LengthSqr() + y.LengthSqr() + z.LengthSqr());
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public double NormMax => Math.Max(Math.Max(x.Magnitude, y.Magnitude), z.Magnitude);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public cvec3 Normalized => this / Length;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public cvec3 NormalizedSafe => this == Zero ? Zero : this / Length;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero vector
        /// </summary>
        public static cvec3 Zero { get; } = new cvec3(0.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined all-ones vector
        /// </summary>
        public static cvec3 Ones { get; } = new cvec3(1.0, 1.0, 1.0);
        
        /// <summary>
        /// Predefined unit-X vector
        /// </summary>
        public static cvec3 UnitX { get; } = new cvec3(1.0, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Y vector
        /// </summary>
        public static cvec3 UnitY { get; } = new cvec3(0.0, 1.0, 0.0);
        
        /// <summary>
        /// Predefined unit-Z vector
        /// </summary>
        public static cvec3 UnitZ { get; } = new cvec3(0.0, 0.0, 1.0);
        
        /// <summary>
        /// Predefined all-imaginary-ones vector
        /// </summary>
        public static cvec3 ImaginaryOnes { get; } = new cvec3(Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne);
        
        /// <summary>
        /// Predefined unit-imaginary-X vector
        /// </summary>
        public static cvec3 ImaginaryUnitX { get; } = new cvec3(Complex.ImaginaryOne, 0.0, 0.0);
        
        /// <summary>
        /// Predefined unit-imaginary-Y vector
        /// </summary>
        public static cvec3 ImaginaryUnitY { get; } = new cvec3(0.0, Complex.ImaginaryOne, 0.0);
        
        /// <summary>
        /// Predefined unit-imaginary-Z vector
        /// </summary>
        public static cvec3 ImaginaryUnitZ { get; } = new cvec3(0.0, 0.0, Complex.ImaginaryOne);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(cvec3 lhs, cvec3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(cvec3 lhs, cvec3 rhs) => !lhs.Equals(rhs);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<Complex> GetEnumerator()
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
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(cvec3 rhs) => x.Equals(rhs.x) && y.Equals(rhs.y) && z.Equals(rhs.z);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is cvec3 && Equals((cvec3) obj);
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
        public double NormP(double p) => Math.Pow(Math.Pow((double)x.Magnitude, p) + Math.Pow((double)y.Magnitude, p) + Math.Pow((double)z.Magnitude, p), 1 / p);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(cvec3 lhs, cvec3 rhs) => new bvec3(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(cvec3 lhs, Complex rhs) => new bvec3(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(Complex lhs, cvec3 rhs) => new bvec3(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(Complex lhs, Complex rhs) => new bvec3(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(cvec3 lhs, cvec3 rhs) => new bvec3(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(cvec3 lhs, Complex rhs) => new bvec3(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(Complex lhs, cvec3 rhs) => new bvec3(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(Complex lhs, Complex rhs) => new bvec3(lhs != rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Abs (v.Magnitude).
        /// </summary>
        public static dvec3 Abs(cvec3 v) => new dvec3(v.x.Magnitude, v.y.Magnitude, v.z.Magnitude);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Abs (v.Magnitude).
        /// </summary>
        public static dvec3 Abs(Complex v) => new dvec3(v.Magnitude);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static cvec3 HermiteInterpolationOrder3(cvec3 v) => new cvec3((3 - 2 * v.x) * v.x * v.x, (3 - 2 * v.y) * v.y * v.y, (3 - 2 * v.z) * v.z * v.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static cvec3 HermiteInterpolationOrder3(Complex v) => new cvec3((3 - 2 * v) * v * v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static cvec3 HermiteInterpolationOrder5(cvec3 v) => new cvec3(((6 * v.x - 15) * v.x + 10) * v.x * v.x * v.x, ((6 * v.y - 15) * v.y + 10) * v.y * v.y * v.y, ((6 * v.z - 15) * v.z + 10) * v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static cvec3 HermiteInterpolationOrder5(Complex v) => new cvec3(((6 * v - 15) * v + 10) * v * v * v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static cvec3 Sqr(cvec3 v) => new cvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static cvec3 Sqr(Complex v) => new cvec3(v * v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static cvec3 Pow2(cvec3 v) => new cvec3(v.x * v.x, v.y * v.y, v.z * v.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static cvec3 Pow2(Complex v) => new cvec3(v * v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static cvec3 Pow3(cvec3 v) => new cvec3(v.x * v.x * v.x, v.y * v.y * v.y, v.z * v.z * v.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static cvec3 Pow3(Complex v) => new cvec3(v * v * v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Acos (Complex.Acos(v)).
        /// </summary>
        public static cvec3 Acos(cvec3 v) => new cvec3(Complex.Acos(v.x), Complex.Acos(v.y), Complex.Acos(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Acos (Complex.Acos(v)).
        /// </summary>
        public static cvec3 Acos(Complex v) => new cvec3(Complex.Acos(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Asin (Complex.Asin(v)).
        /// </summary>
        public static cvec3 Asin(cvec3 v) => new cvec3(Complex.Asin(v.x), Complex.Asin(v.y), Complex.Asin(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Asin (Complex.Asin(v)).
        /// </summary>
        public static cvec3 Asin(Complex v) => new cvec3(Complex.Asin(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Atan (Complex.Atan(v)).
        /// </summary>
        public static cvec3 Atan(cvec3 v) => new cvec3(Complex.Atan(v.x), Complex.Atan(v.y), Complex.Atan(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Atan (Complex.Atan(v)).
        /// </summary>
        public static cvec3 Atan(Complex v) => new cvec3(Complex.Atan(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Cos (Complex.Cos(v)).
        /// </summary>
        public static cvec3 Cos(cvec3 v) => new cvec3(Complex.Cos(v.x), Complex.Cos(v.y), Complex.Cos(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Cos (Complex.Cos(v)).
        /// </summary>
        public static cvec3 Cos(Complex v) => new cvec3(Complex.Cos(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Cosh (Complex.Cosh(v)).
        /// </summary>
        public static cvec3 Cosh(cvec3 v) => new cvec3(Complex.Cosh(v.x), Complex.Cosh(v.y), Complex.Cosh(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Cosh (Complex.Cosh(v)).
        /// </summary>
        public static cvec3 Cosh(Complex v) => new cvec3(Complex.Cosh(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Exp (Complex.Exp(v)).
        /// </summary>
        public static cvec3 Exp(cvec3 v) => new cvec3(Complex.Exp(v.x), Complex.Exp(v.y), Complex.Exp(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Exp (Complex.Exp(v)).
        /// </summary>
        public static cvec3 Exp(Complex v) => new cvec3(Complex.Exp(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(v)).
        /// </summary>
        public static cvec3 Log(cvec3 v) => new cvec3(Complex.Log(v.x), Complex.Log(v.y), Complex.Log(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(v)).
        /// </summary>
        public static cvec3 Log(Complex v) => new cvec3(Complex.Log(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log2 (Complex.Log(v, 2.0)).
        /// </summary>
        public static cvec3 Log2(cvec3 v) => new cvec3(Complex.Log(v.x, 2.0), Complex.Log(v.y, 2.0), Complex.Log(v.z, 2.0));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log2 (Complex.Log(v, 2.0)).
        /// </summary>
        public static cvec3 Log2(Complex v) => new cvec3(Complex.Log(v, 2.0));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log10 (Complex.Log10(v)).
        /// </summary>
        public static cvec3 Log10(cvec3 v) => new cvec3(Complex.Log10(v.x), Complex.Log10(v.y), Complex.Log10(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log10 (Complex.Log10(v)).
        /// </summary>
        public static cvec3 Log10(Complex v) => new cvec3(Complex.Log10(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Reciprocal (Complex.Reciprocal(v)).
        /// </summary>
        public static cvec3 Reciprocal(cvec3 v) => new cvec3(Complex.Reciprocal(v.x), Complex.Reciprocal(v.y), Complex.Reciprocal(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Reciprocal (Complex.Reciprocal(v)).
        /// </summary>
        public static cvec3 Reciprocal(Complex v) => new cvec3(Complex.Reciprocal(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sin (Complex.Sin(v)).
        /// </summary>
        public static cvec3 Sin(cvec3 v) => new cvec3(Complex.Sin(v.x), Complex.Sin(v.y), Complex.Sin(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sin (Complex.Sin(v)).
        /// </summary>
        public static cvec3 Sin(Complex v) => new cvec3(Complex.Sin(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sinh (Complex.Sinh(v)).
        /// </summary>
        public static cvec3 Sinh(cvec3 v) => new cvec3(Complex.Sinh(v.x), Complex.Sinh(v.y), Complex.Sinh(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sinh (Complex.Sinh(v)).
        /// </summary>
        public static cvec3 Sinh(Complex v) => new cvec3(Complex.Sinh(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sqrt (Complex.Sqrt(v)).
        /// </summary>
        public static cvec3 Sqrt(cvec3 v) => new cvec3(Complex.Sqrt(v.x), Complex.Sqrt(v.y), Complex.Sqrt(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sqrt (Complex.Sqrt(v)).
        /// </summary>
        public static cvec3 Sqrt(Complex v) => new cvec3(Complex.Sqrt(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Tan (Complex.Tan(v)).
        /// </summary>
        public static cvec3 Tan(cvec3 v) => new cvec3(Complex.Tan(v.x), Complex.Tan(v.y), Complex.Tan(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Tan (Complex.Tan(v)).
        /// </summary>
        public static cvec3 Tan(Complex v) => new cvec3(Complex.Tan(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Tanh (Complex.Tanh(v)).
        /// </summary>
        public static cvec3 Tanh(cvec3 v) => new cvec3(Complex.Tanh(v.x), Complex.Tanh(v.y), Complex.Tanh(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Tanh (Complex.Tanh(v)).
        /// </summary>
        public static cvec3 Tanh(Complex v) => new cvec3(Complex.Tanh(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Conjugate (Complex.Conjugate(v)).
        /// </summary>
        public static cvec3 Conjugate(cvec3 v) => new cvec3(Complex.Conjugate(v.x), Complex.Conjugate(v.y), Complex.Conjugate(v.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Conjugate (Complex.Conjugate(v)).
        /// </summary>
        public static cvec3 Conjugate(Complex v) => new cvec3(Complex.Conjugate(v));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec3 Pow(cvec3 lhs, cvec3 rhs) => new cvec3(Complex.Pow(lhs.x, rhs.x), Complex.Pow(lhs.y, rhs.y), Complex.Pow(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec3 Pow(cvec3 lhs, Complex rhs) => new cvec3(Complex.Pow(lhs.x, rhs), Complex.Pow(lhs.y, rhs), Complex.Pow(lhs.z, rhs));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec3 Pow(Complex lhs, cvec3 rhs) => new cvec3(Complex.Pow(lhs, rhs.x), Complex.Pow(lhs, rhs.y), Complex.Pow(lhs, rhs.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec3 Pow(Complex lhs, Complex rhs) => new cvec3(Complex.Pow(lhs, rhs));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec3 Log(cvec3 lhs, dvec3 rhs) => new cvec3(Complex.Log(lhs.x, rhs.x), Complex.Log(lhs.y, rhs.y), Complex.Log(lhs.z, rhs.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec3 Log(cvec3 lhs, double rhs) => new cvec3(Complex.Log(lhs.x, rhs), Complex.Log(lhs.y, rhs), Complex.Log(lhs.z, rhs));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec3 Log(Complex lhs, dvec3 rhs) => new cvec3(Complex.Log(lhs, rhs.x), Complex.Log(lhs, rhs.y), Complex.Log(lhs, rhs.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec3 Log(Complex lhs, double rhs) => new cvec3(Complex.Log(lhs, rhs));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec3 FromPolarCoordinates(dvec3 magnitude, dvec3 phase) => new cvec3(Complex.FromPolarCoordinates(magnitude.x, phase.x), Complex.FromPolarCoordinates(magnitude.y, phase.y), Complex.FromPolarCoordinates(magnitude.z, phase.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec3 FromPolarCoordinates(dvec3 magnitude, double phase) => new cvec3(Complex.FromPolarCoordinates(magnitude.x, phase), Complex.FromPolarCoordinates(magnitude.y, phase), Complex.FromPolarCoordinates(magnitude.z, phase));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec3 FromPolarCoordinates(double magnitude, dvec3 phase) => new cvec3(Complex.FromPolarCoordinates(magnitude, phase.x), Complex.FromPolarCoordinates(magnitude, phase.y), Complex.FromPolarCoordinates(magnitude, phase.z));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec3 FromPolarCoordinates(double magnitude, double phase) => new cvec3(Complex.FromPolarCoordinates(magnitude, phase));
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec3 Add(cvec3 lhs, cvec3 rhs) => new cvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec3 Add(cvec3 lhs, Complex rhs) => new cvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec3 Add(Complex lhs, cvec3 rhs) => new cvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec3 Add(Complex lhs, Complex rhs) => new cvec3(lhs + rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec3 Sub(cvec3 lhs, cvec3 rhs) => new cvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec3 Sub(cvec3 lhs, Complex rhs) => new cvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec3 Sub(Complex lhs, cvec3 rhs) => new cvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec3 Sub(Complex lhs, Complex rhs) => new cvec3(lhs - rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec3 Mul(cvec3 lhs, cvec3 rhs) => new cvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec3 Mul(cvec3 lhs, Complex rhs) => new cvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec3 Mul(Complex lhs, cvec3 rhs) => new cvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec3 Mul(Complex lhs, Complex rhs) => new cvec3(lhs * rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec3 Div(cvec3 lhs, cvec3 rhs) => new cvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec3 Div(cvec3 lhs, Complex rhs) => new cvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec3 Div(Complex lhs, cvec3 rhs) => new cvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec3 Div(Complex lhs, Complex rhs) => new cvec3(lhs / rhs);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static cvec3 operator+(cvec3 lhs, cvec3 rhs) => new cvec3(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static cvec3 operator+(cvec3 lhs, Complex rhs) => new cvec3(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static cvec3 operator+(Complex lhs, cvec3 rhs) => new cvec3(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static cvec3 operator-(cvec3 lhs, cvec3 rhs) => new cvec3(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static cvec3 operator-(cvec3 lhs, Complex rhs) => new cvec3(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static cvec3 operator-(Complex lhs, cvec3 rhs) => new cvec3(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static cvec3 operator*(cvec3 lhs, cvec3 rhs) => new cvec3(lhs.x * rhs.x, lhs.y * rhs.y, lhs.z * rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static cvec3 operator*(cvec3 lhs, Complex rhs) => new cvec3(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static cvec3 operator*(Complex lhs, cvec3 rhs) => new cvec3(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static cvec3 operator/(cvec3 lhs, cvec3 rhs) => new cvec3(lhs.x / rhs.x, lhs.y / rhs.y, lhs.z / rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static cvec3 operator/(cvec3 lhs, Complex rhs) => new cvec3(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static cvec3 operator/(Complex lhs, cvec3 rhs) => new cvec3(lhs / rhs.x, lhs / rhs.y, lhs / rhs.z);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator+ (identity).
        /// </summary>
        public static cvec3 operator+(cvec3 v) => v;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of operator- (-v).
        /// </summary>
        public static cvec3 operator-(cvec3 v) => new cvec3(-v.x, -v.y, -v.z);

        #endregion

        
        /// <summary>
        /// Returns a vector containing component-wise magnitudes.
        /// </summary>
        public dvec3 Magnitude => new dvec3(x.Magnitude, y.Magnitude, z.Magnitude);
        
        /// <summary>
        /// Returns a vector containing component-wise phases.
        /// </summary>
        public dvec3 Phase => new dvec3(x.Phase, y.Phase, z.Phase);
        
        /// <summary>
        /// Returns a vector containing component-wise imaginary parts.
        /// </summary>
        public dvec3 Imaginary => new dvec3(x.Imaginary, y.Imaginary, z.Imaginary);
        
        /// <summary>
        /// Returns a vector containing component-wise real parts.
        /// </summary>
        public dvec3 Real => new dvec3(x.Real, y.Real, z.Real);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Complex Dot(cvec3 lhs, cvec3 rhs) => lhs.x * rhs.x + lhs.y * rhs.y + lhs.z * rhs.z;
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(cvec3 lhs, cvec3 rhs) => (lhs - rhs).Length;
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(cvec3 lhs, cvec3 rhs) => (lhs - rhs).LengthSqr;
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static cvec3 Reflect(cvec3 I, cvec3 N) => I - 2 * Dot(N, I) * N;
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static cvec3 Cross(cvec3 l, cvec3 r) => new cvec3(l.y * r.z - l.z * r.y, l.z * r.x - l.x * r.z, l.x * r.y - l.y * r.x);
    }
}
