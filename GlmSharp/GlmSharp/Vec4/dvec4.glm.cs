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
        public static swizzle_dvec4 swizzle(dvec4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static double[] Values(dvec4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<double> GetEnumerator(dvec4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(dvec4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(dvec4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(dvec4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(dvec4 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(dvec4 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(dvec4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(dvec4 v, dvec4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(dvec4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(dvec4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(dvec4 lhs, dvec4 rhs, double eps = 0.1d) => dvec4.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(dvec4 lhs, dvec4 rhs) => dvec4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(dvec4 lhs, dvec4 rhs) => dvec4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(dvec4 lhs, dvec4 rhs) => dvec4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(dvec4 lhs, dvec4 rhs) => dvec4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(dvec4 lhs, dvec4 rhs) => dvec4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(dvec4 lhs, dvec4 rhs) => dvec4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(dvec4 v) => dvec4.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(dvec4 v) => dvec4.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(dvec4 v) => dvec4.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(dvec4 v) => dvec4.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(dvec4 v) => dvec4.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec4 Abs(dvec4 v) => dvec4.Abs(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec4 HermiteInterpolationOrder3(dvec4 v) => dvec4.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec4 HermiteInterpolationOrder5(dvec4 v) => dvec4.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static dvec4 Sqr(dvec4 v) => dvec4.Sqr(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static dvec4 Pow2(dvec4 v) => dvec4.Pow2(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static dvec4 Pow3(dvec4 v) => dvec4.Pow3(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec4 Step(dvec4 v) => dvec4.Step(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec4 Sqrt(dvec4 v) => dvec4.Sqrt(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec4 InverseSqrt(dvec4 v) => dvec4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(dvec4 v) => dvec4.Sign(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec4 Max(dvec4 lhs, dvec4 rhs) => dvec4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec4 Min(dvec4 lhs, dvec4 rhs) => dvec4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Pow(dvec4 lhs, dvec4 rhs) => dvec4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec4 Log(dvec4 lhs, dvec4 rhs) => dvec4.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec4 Clamp(dvec4 v, dvec4 min, dvec4 max) => dvec4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Mix(dvec4 min, dvec4 max, dvec4 a) => dvec4.Mix(min, max, a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec4 Lerp(dvec4 min, dvec4 max, dvec4 a) => dvec4.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec4 Smoothstep(dvec4 edge0, dvec4 edge1, dvec4 v) => dvec4.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec4 Smootherstep(dvec4 edge0, dvec4 edge1, dvec4 v) => dvec4.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec4 Fma(dvec4 a, dvec4 b, dvec4 c) => dvec4.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat2x4 OuterProduct(dvec4 c, dvec2 r) => dvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat3x4 OuterProduct(dvec4 c, dvec3 r) => dvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat4 OuterProduct(dvec4 c, dvec4 r) => dvec4.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec4 Add(dvec4 lhs, dvec4 rhs) => dvec4.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec4 Sub(dvec4 lhs, dvec4 rhs) => dvec4.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec4 Mul(dvec4 lhs, dvec4 rhs) => dvec4.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec4 Div(dvec4 lhs, dvec4 rhs) => dvec4.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec4 Modulo(dvec4 lhs, dvec4 rhs) => dvec4.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec4 Degrees(dvec4 v) => dvec4.Degrees(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec4 Radians(dvec4 v) => dvec4.Radians(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec4 Acos(dvec4 v) => dvec4.Acos(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec4 Asin(dvec4 v) => dvec4.Asin(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec4 Atan(dvec4 v) => dvec4.Atan(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec4 Cos(dvec4 v) => dvec4.Cos(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec4 Cosh(dvec4 v) => dvec4.Cosh(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec4 Exp(dvec4 v) => dvec4.Exp(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec4 Log(dvec4 v) => dvec4.Log(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec4 Log2(dvec4 v) => dvec4.Log2(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec4 Log10(dvec4 v) => dvec4.Log10(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec4 Floor(dvec4 v) => dvec4.Floor(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec4 Ceiling(dvec4 v) => dvec4.Ceiling(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec4 Round(dvec4 v) => dvec4.Round(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec4 Sin(dvec4 v) => dvec4.Sin(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec4 Sinh(dvec4 v) => dvec4.Sinh(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec4 Tan(dvec4 v) => dvec4.Tan(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec4 Tanh(dvec4 v) => dvec4.Tanh(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec4 Truncate(dvec4 v) => dvec4.Truncate(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec4 Fract(dvec4 v) => dvec4.Fract(v);
        
        /// <summary>
        /// Returns a dvec4 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static dvec4 Trunc(dvec4 v) => dvec4.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static double MinElement(dvec4 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static double MaxElement(dvec4 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(dvec4 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(dvec4 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static double Sum(dvec4 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(dvec4 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(dvec4 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(dvec4 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(dvec4 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(dvec4 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static dvec4 Normalized(dvec4 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static dvec4 NormalizedSafe(dvec4 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(dvec4 lhs, dvec4 rhs) => dvec4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(dvec4 lhs, dvec4 rhs) => dvec4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(dvec4 lhs, dvec4 rhs) => dvec4.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec4 Reflect(dvec4 I, dvec4 N) => dvec4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec4 Refract(dvec4 I, dvec4 N, double eta) => dvec4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static dvec4 FaceForward(dvec4 N, dvec4 I, dvec4 Nref) => dvec4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 Random(Random random, dvec4 minValue, dvec4 maxValue) => dvec4.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec4 RandomUniform(Random random, dvec4 minValue, dvec4 maxValue) => dvec4.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomNormal(Random random, dvec4 mean, dvec4 variance) => dvec4.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a dvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec4 RandomGaussian(Random random, dvec4 mean, dvec4 variance) => dvec4.RandomGaussian(random, mean, variance);

    }
}
