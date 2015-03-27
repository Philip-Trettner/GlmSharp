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
        public static swizzle_cvec4 swizzle(cvec4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static Complex[] Values(cvec4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<Complex> GetEnumerator(cvec4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(cvec4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(cvec4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(cvec4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(cvec4 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(cvec4 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(cvec4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(cvec4 v, cvec4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(cvec4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(cvec4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(cvec4 lhs, cvec4 rhs, double eps = 0.1d) => cvec4.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(cvec4 lhs, cvec4 rhs) => cvec4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(cvec4 lhs, cvec4 rhs) => cvec4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Abs (v.Magnitude).
        /// </summary>
        public static dvec4 Abs(cvec4 v) => cvec4.Abs(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static cvec4 HermiteInterpolationOrder3(cvec4 v) => cvec4.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static cvec4 HermiteInterpolationOrder5(cvec4 v) => cvec4.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static cvec4 Sqr(cvec4 v) => cvec4.Sqr(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static cvec4 Pow2(cvec4 v) => cvec4.Pow2(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static cvec4 Pow3(cvec4 v) => cvec4.Pow3(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Acos (Complex.Acos(v)).
        /// </summary>
        public static cvec4 Acos(cvec4 v) => cvec4.Acos(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Asin (Complex.Asin(v)).
        /// </summary>
        public static cvec4 Asin(cvec4 v) => cvec4.Asin(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Atan (Complex.Atan(v)).
        /// </summary>
        public static cvec4 Atan(cvec4 v) => cvec4.Atan(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Cos (Complex.Cos(v)).
        /// </summary>
        public static cvec4 Cos(cvec4 v) => cvec4.Cos(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Cosh (Complex.Cosh(v)).
        /// </summary>
        public static cvec4 Cosh(cvec4 v) => cvec4.Cosh(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Exp (Complex.Exp(v)).
        /// </summary>
        public static cvec4 Exp(cvec4 v) => cvec4.Exp(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Log (Complex.Log(v)).
        /// </summary>
        public static cvec4 Log(cvec4 v) => cvec4.Log(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Log2 (Complex.Log(v, 2.0)).
        /// </summary>
        public static cvec4 Log2(cvec4 v) => cvec4.Log2(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Log10 (Complex.Log10(v)).
        /// </summary>
        public static cvec4 Log10(cvec4 v) => cvec4.Log10(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Reciprocal (Complex.Reciprocal(v)).
        /// </summary>
        public static cvec4 Reciprocal(cvec4 v) => cvec4.Reciprocal(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Sin (Complex.Sin(v)).
        /// </summary>
        public static cvec4 Sin(cvec4 v) => cvec4.Sin(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Sinh (Complex.Sinh(v)).
        /// </summary>
        public static cvec4 Sinh(cvec4 v) => cvec4.Sinh(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Sqrt (Complex.Sqrt(v)).
        /// </summary>
        public static cvec4 Sqrt(cvec4 v) => cvec4.Sqrt(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of InverseSqrt (Complex.One / Complex.Sqrt(v)).
        /// </summary>
        public static cvec4 InverseSqrt(cvec4 v) => cvec4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Tan (Complex.Tan(v)).
        /// </summary>
        public static cvec4 Tan(cvec4 v) => cvec4.Tan(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Tanh (Complex.Tanh(v)).
        /// </summary>
        public static cvec4 Tanh(cvec4 v) => cvec4.Tanh(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Conjugate (Complex.Conjugate(v)).
        /// </summary>
        public static cvec4 Conjugate(cvec4 v) => cvec4.Conjugate(v);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec4 Pow(cvec4 lhs, cvec4 rhs) => cvec4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec4 Log(cvec4 lhs, dvec4 rhs) => cvec4.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec4 FromPolarCoordinates(dvec4 magnitude, dvec4 phase) => cvec4.FromPolarCoordinates(magnitude, phase);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec4 Fma(cvec4 a, cvec4 b, cvec4 c) => cvec4.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat2x4 OuterProduct(cvec4 c, cvec2 r) => cvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat3x4 OuterProduct(cvec4 c, cvec3 r) => cvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat4 OuterProduct(cvec4 c, cvec4 r) => cvec4.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec4 Add(cvec4 lhs, cvec4 rhs) => cvec4.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec4 Sub(cvec4 lhs, cvec4 rhs) => cvec4.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec4 Mul(cvec4 lhs, cvec4 rhs) => cvec4.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec4 Div(cvec4 lhs, cvec4 rhs) => cvec4.Div(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(cvec4 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(cvec4 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static Complex Sum(cvec4 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(cvec4 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(cvec4 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(cvec4 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(cvec4 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(cvec4 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static cvec4 Normalized(cvec4 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static cvec4 NormalizedSafe(cvec4 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns a vector containing component-wise magnitudes.
        /// </summary>
        public static dvec4 Magnitude(cvec4 v) => v.Magnitude;
        
        /// <summary>
        /// Returns a vector containing component-wise phases.
        /// </summary>
        public static dvec4 Phase(cvec4 v) => v.Phase;
        
        /// <summary>
        /// Returns a vector containing component-wise imaginary parts.
        /// </summary>
        public static dvec4 Imaginary(cvec4 v) => v.Imaginary;
        
        /// <summary>
        /// Returns a vector containing component-wise real parts.
        /// </summary>
        public static dvec4 Real(cvec4 v) => v.Real;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Complex Dot(cvec4 lhs, cvec4 rhs) => cvec4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(cvec4 lhs, cvec4 rhs) => cvec4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(cvec4 lhs, cvec4 rhs) => cvec4.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static cvec4 Reflect(cvec4 I, cvec4 N) => cvec4.Reflect(I, N);

    }
}
