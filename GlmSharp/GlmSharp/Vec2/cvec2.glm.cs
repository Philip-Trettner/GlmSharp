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
        public static swizzle_cvec2 swizzle(cvec2 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static Complex[] Values(cvec2 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<Complex> GetEnumerator(cvec2 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(cvec2 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(cvec2 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(cvec2 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(cvec2 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(cvec2 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public static int Count(cvec2 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(cvec2 v, cvec2 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(cvec2 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(cvec2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(cvec2 lhs, cvec2 rhs, double eps = 0.1d) => cvec2.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(cvec2 lhs, cvec2 rhs) => cvec2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(cvec2 lhs, cvec2 rhs) => cvec2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Abs (v.Magnitude).
        /// </summary>
        public static dvec2 Abs(cvec2 v) => cvec2.Abs(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static cvec2 HermiteInterpolationOrder3(cvec2 v) => cvec2.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static cvec2 HermiteInterpolationOrder5(cvec2 v) => cvec2.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static cvec2 Sqr(cvec2 v) => cvec2.Sqr(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static cvec2 Pow2(cvec2 v) => cvec2.Pow2(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static cvec2 Pow3(cvec2 v) => cvec2.Pow3(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Acos (Complex.Acos(v)).
        /// </summary>
        public static cvec2 Acos(cvec2 v) => cvec2.Acos(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Asin (Complex.Asin(v)).
        /// </summary>
        public static cvec2 Asin(cvec2 v) => cvec2.Asin(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Atan (Complex.Atan(v)).
        /// </summary>
        public static cvec2 Atan(cvec2 v) => cvec2.Atan(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Cos (Complex.Cos(v)).
        /// </summary>
        public static cvec2 Cos(cvec2 v) => cvec2.Cos(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Cosh (Complex.Cosh(v)).
        /// </summary>
        public static cvec2 Cosh(cvec2 v) => cvec2.Cosh(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Exp (Complex.Exp(v)).
        /// </summary>
        public static cvec2 Exp(cvec2 v) => cvec2.Exp(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Log (Complex.Log(v)).
        /// </summary>
        public static cvec2 Log(cvec2 v) => cvec2.Log(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Log2 (Complex.Log(v, 2.0)).
        /// </summary>
        public static cvec2 Log2(cvec2 v) => cvec2.Log2(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Log10 (Complex.Log10(v)).
        /// </summary>
        public static cvec2 Log10(cvec2 v) => cvec2.Log10(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Reciprocal (Complex.Reciprocal(v)).
        /// </summary>
        public static cvec2 Reciprocal(cvec2 v) => cvec2.Reciprocal(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Sin (Complex.Sin(v)).
        /// </summary>
        public static cvec2 Sin(cvec2 v) => cvec2.Sin(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Sinh (Complex.Sinh(v)).
        /// </summary>
        public static cvec2 Sinh(cvec2 v) => cvec2.Sinh(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Sqrt (Complex.Sqrt(v)).
        /// </summary>
        public static cvec2 Sqrt(cvec2 v) => cvec2.Sqrt(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of InverseSqrt (Complex.One / Complex.Sqrt(v)).
        /// </summary>
        public static cvec2 InverseSqrt(cvec2 v) => cvec2.InverseSqrt(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Tan (Complex.Tan(v)).
        /// </summary>
        public static cvec2 Tan(cvec2 v) => cvec2.Tan(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Tanh (Complex.Tanh(v)).
        /// </summary>
        public static cvec2 Tanh(cvec2 v) => cvec2.Tanh(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Conjugate (Complex.Conjugate(v)).
        /// </summary>
        public static cvec2 Conjugate(cvec2 v) => cvec2.Conjugate(v);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Pow (Complex.Pow(lhs, rhs)).
        /// </summary>
        public static cvec2 Pow(cvec2 lhs, cvec2 rhs) => cvec2.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Log (Complex.Log(lhs, rhs)).
        /// </summary>
        public static cvec2 Log(cvec2 lhs, dvec2 rhs) => cvec2.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of FromPolarCoordinates (Complex.FromPolarCoordinates(magnitude, phase)).
        /// </summary>
        public static cvec2 FromPolarCoordinates(dvec2 magnitude, dvec2 phase) => cvec2.FromPolarCoordinates(magnitude, phase);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static cvec2 Fma(cvec2 a, cvec2 b, cvec2 c) => cvec2.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat2 OuterProduct(cvec2 c, cvec2 r) => cvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat3x2 OuterProduct(cvec2 c, cvec3 r) => cvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static cmat4x2 OuterProduct(cvec2 c, cvec4 r) => cvec2.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static cvec2 Add(cvec2 lhs, cvec2 rhs) => cvec2.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static cvec2 Sub(cvec2 lhs, cvec2 rhs) => cvec2.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static cvec2 Mul(cvec2 lhs, cvec2 rhs) => cvec2.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a cvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static cvec2 Div(cvec2 lhs, cvec2 rhs) => cvec2.Div(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(cvec2 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(cvec2 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static Complex Sum(cvec2 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(cvec2 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(cvec2 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(cvec2 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(cvec2 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(cvec2 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static cvec2 Normalized(cvec2 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static cvec2 NormalizedSafe(cvec2 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns a vector containing component-wise magnitudes.
        /// </summary>
        public static dvec2 Magnitude(cvec2 v) => v.Magnitude;
        
        /// <summary>
        /// Returns a vector containing component-wise phases.
        /// </summary>
        public static dvec2 Phase(cvec2 v) => v.Phase;
        
        /// <summary>
        /// Returns a vector containing component-wise imaginary parts.
        /// </summary>
        public static dvec2 Imaginary(cvec2 v) => v.Imaginary;
        
        /// <summary>
        /// Returns a vector containing component-wise real parts.
        /// </summary>
        public static dvec2 Real(cvec2 v) => v.Real;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Complex Dot(cvec2 lhs, cvec2 rhs) => cvec2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(cvec2 lhs, cvec2 rhs) => cvec2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(cvec2 lhs, cvec2 rhs) => cvec2.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static cvec2 Reflect(cvec2 I, cvec2 N) => cvec2.Reflect(I, N);
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static Complex Cross(cvec2 l, cvec2 r) => cvec2.Cross(l, r);

    }
}
