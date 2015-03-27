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
    /// Static class that contains static glm functions
    /// </summary>
    public static partial class glm
    {
        
        /// <summary>
        /// Returns an object that can be used for arbitrary swizzling (e.g. swizzle.zy)
        /// </summary>
        public static swizzle_cvec3 swizzle(cvec3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static Complex[] Values(cvec3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<Complex> GetEnumerator(cvec3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(cvec3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(cvec3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(cvec3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(cvec3 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(cvec3 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(cvec3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(cvec3 v, cvec3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(cvec3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(cvec3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(cvec3 lhs, cvec3 rhs, double eps = 0.1d) => cvec3.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(cvec3 lhs, cvec3 rhs) => cvec3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(Complex lhs, Complex rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(cvec3 lhs, cvec3 rhs) => cvec3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(Complex lhs, Complex rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Abs (v.Magnitude).
        /// </summary>
        public static dvec3 Abs(cvec3 v) => cvec3.Abs(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Abs (v.Magnitude).
        /// </summary>
        public static double Abs(Complex v) => v.Magnitude;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static cvec3 HermiteInterpolationOrder3(cvec3 v) => cvec3.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static Complex HermiteInterpolationOrder3(Complex v) => (3 - 2 * v) * v * v;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static cvec3 HermiteInterpolationOrder5(cvec3 v) => cvec3.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static Complex HermiteInterpolationOrder5(Complex v) => ((6 * v - 15) * v + 10) * v * v * v;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static cvec3 Sqr(cvec3 v) => cvec3.Sqr(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static Complex Sqr(Complex v) => v * v;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static cvec3 Pow2(cvec3 v) => cvec3.Pow2(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static Complex Pow2(Complex v) => v * v;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static cvec3 Pow3(cvec3 v) => cvec3.Pow3(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static Complex Pow3(Complex v) => v * v * v;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Acos (Complex.Acos(v)).
        /// </summary>
        public static cvec3 Acos(cvec3 v) => cvec3.Acos(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Acos (Complex.Acos(v)).
        /// </summary>
        public static Complex Acos(Complex v) => Complex.Acos(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Asin (Complex.Asin(v)).
        /// </summary>
        public static cvec3 Asin(cvec3 v) => cvec3.Asin(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Asin (Complex.Asin(v)).
        /// </summary>
        public static Complex Asin(Complex v) => Complex.Asin(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Atan (Complex.Atan(v)).
        /// </summary>
        public static cvec3 Atan(cvec3 v) => cvec3.Atan(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Atan (Complex.Atan(v)).
        /// </summary>
        public static Complex Atan(Complex v) => Complex.Atan(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Cos (Complex.Cos(v)).
        /// </summary>
        public static cvec3 Cos(cvec3 v) => cvec3.Cos(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Cos (Complex.Cos(v)).
        /// </summary>
        public static Complex Cos(Complex v) => Complex.Cos(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Cosh (Complex.Cosh(v)).
        /// </summary>
        public static cvec3 Cosh(cvec3 v) => cvec3.Cosh(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Cosh (Complex.Cosh(v)).
        /// </summary>
        public static Complex Cosh(Complex v) => Complex.Cosh(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Exp (Complex.Exp(v)).
        /// </summary>
        public static cvec3 Exp(cvec3 v) => cvec3.Exp(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Exp (Complex.Exp(v)).
        /// </summary>
        public static Complex Exp(Complex v) => Complex.Exp(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(v)).
        /// </summary>
        public static cvec3 Log(cvec3 v) => cvec3.Log(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(v)).
        /// </summary>
        public static Complex Log(Complex v) => Complex.Log(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log2 (Complex.Log(v, 2.0)).
        /// </summary>
        public static cvec3 Log2(cvec3 v) => cvec3.Log2(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log2 (Complex.Log(v, 2.0)).
        /// </summary>
        public static Complex Log2(Complex v) => Complex.Log(v, 2.0);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log10 (Complex.Log10(v)).
        /// </summary>
        public static cvec3 Log10(cvec3 v) => cvec3.Log10(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log10 (Complex.Log10(v)).
        /// </summary>
        public static Complex Log10(Complex v) => Complex.Log10(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Reciprocal (Complex.Reciprocal(v)).
        /// </summary>
        public static cvec3 Reciprocal(cvec3 v) => cvec3.Reciprocal(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Reciprocal (Complex.Reciprocal(v)).
        /// </summary>
        public static Complex Reciprocal(Complex v) => Complex.Reciprocal(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sin (Complex.Sin(v)).
        /// </summary>
        public static cvec3 Sin(cvec3 v) => cvec3.Sin(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sin (Complex.Sin(v)).
        /// </summary>
        public static Complex Sin(Complex v) => Complex.Sin(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sinh (Complex.Sinh(v)).
        /// </summary>
        public static cvec3 Sinh(cvec3 v) => cvec3.Sinh(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sinh (Complex.Sinh(v)).
        /// </summary>
        public static Complex Sinh(Complex v) => Complex.Sinh(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sqrt (Complex.Sqrt(v)).
        /// </summary>
        public static cvec3 Sqrt(cvec3 v) => cvec3.Sqrt(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sqrt (Complex.Sqrt(v)).
        /// </summary>
        public static Complex Sqrt(Complex v) => Complex.Sqrt(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of InverseSqrt (Complex.One / Complex.Sqrt(v)).
        /// </summary>
        public static cvec3 InverseSqrt(cvec3 v) => cvec3.InverseSqrt(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of InverseSqrt (Complex.One / Complex.Sqrt(v)).
        /// </summary>
        public static Complex InverseSqrt(Complex v) => Complex.One / Complex.Sqrt(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Tan (Complex.Tan(v)).
        /// </summary>
        public static cvec3 Tan(cvec3 v) => cvec3.Tan(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Tan (Complex.Tan(v)).
        /// </summary>
        public static Complex Tan(Complex v) => Complex.Tan(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Tanh (Complex.Tanh(v)).
        /// </summary>
        public static cvec3 Tanh(cvec3 v) => cvec3.Tanh(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Tanh (Complex.Tanh(v)).
        /// </summary>
        public static Complex Tanh(Complex v) => Complex.Tanh(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Conjugate (Complex.Conjugate(v)).
        /// </summary>
        public static cvec3 Conjugate(cvec3 v) => cvec3.Conjugate(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Conjugate (Complex.Conjugate(v)).
        /// </summary>
        public static Complex Conjugate(Complex v) => Complex.Conjugate(v);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec3 Pow(cvec3 lhs, cvec3 rhs) => cvec3.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static Complex Pow(Complex lhs, Complex rhs) => Complex.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec3 Log(cvec3 lhs, dvec3 rhs) => cvec3.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static Complex Log(Complex lhs, double rhs) => Complex.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec3 FromPolarCoordinates(dvec3 magnitude, dvec3 phase) => cvec3.FromPolarCoordinates(magnitude, phase);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static Complex FromPolarCoordinates(double magnitude, double phase) => Complex.FromPolarCoordinates(magnitude, phase);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec3 Fma(cvec3 a, cvec3 b, cvec3 c) => cvec3.Fma(a, b, c);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static Complex Fma(Complex a, Complex b, Complex c) => a * b + c;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat2x3 OuterProduct(cvec3 c, cvec2 r) => cvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat3 OuterProduct(cvec3 c, cvec3 r) => cvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat4x3 OuterProduct(cvec3 c, cvec4 r) => cvec3.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec3 Add(cvec3 lhs, cvec3 rhs) => cvec3.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static Complex Add(Complex lhs, Complex rhs) => lhs + rhs;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec3 Sub(cvec3 lhs, cvec3 rhs) => cvec3.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static Complex Sub(Complex lhs, Complex rhs) => lhs - rhs;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec3 Mul(cvec3 lhs, cvec3 rhs) => cvec3.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static Complex Mul(Complex lhs, Complex rhs) => lhs * rhs;
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec3 Div(cvec3 lhs, cvec3 rhs) => cvec3.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static Complex Div(Complex lhs, Complex rhs) => lhs / rhs;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(cvec3 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(cvec3 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static Complex Sum(cvec3 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(cvec3 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(cvec3 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(cvec3 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(cvec3 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(cvec3 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static cvec3 Normalized(cvec3 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static cvec3 NormalizedSafe(cvec3 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns a vector containing component-wise magnitudes.
        /// </summary>
        public static dvec3 Magnitude(cvec3 v) => v.Magnitude;
        
        /// <summary>
        /// Returns a vector containing component-wise phases.
        /// </summary>
        public static dvec3 Phase(cvec3 v) => v.Phase;
        
        /// <summary>
        /// Returns a vector containing component-wise imaginary parts.
        /// </summary>
        public static dvec3 Imaginary(cvec3 v) => v.Imaginary;
        
        /// <summary>
        /// Returns a vector containing component-wise real parts.
        /// </summary>
        public static dvec3 Real(cvec3 v) => v.Real;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Complex Dot(cvec3 lhs, cvec3 rhs) => cvec3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(cvec3 lhs, cvec3 rhs) => cvec3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(cvec3 lhs, cvec3 rhs) => cvec3.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static cvec3 Reflect(cvec3 I, cvec3 N) => cvec3.Reflect(I, N);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static cvec3 Cross(cvec3 l, cvec3 r) => cvec3.Cross(l, r);

    }
}
