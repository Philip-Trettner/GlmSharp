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
        public static swizzle_dvec2 swizzle(dvec2 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static double[] Values(dvec2 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<double> GetEnumerator(dvec2 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(dvec2 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(dvec2 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(dvec2 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(dvec2 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(dvec2 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public static int Count(dvec2 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(dvec2 v, dvec2 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(dvec2 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(dvec2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(dvec2 lhs, dvec2 rhs, double eps = 0.1d) => dvec2.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(dvec2 lhs, dvec2 rhs) => dvec2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(dvec2 lhs, dvec2 rhs) => dvec2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(dvec2 lhs, dvec2 rhs) => dvec2.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(dvec2 lhs, dvec2 rhs) => dvec2.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(dvec2 lhs, dvec2 rhs) => dvec2.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(dvec2 lhs, dvec2 rhs) => dvec2.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsInfinity(dvec2 v) => dvec2.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsFinite(dvec2 v) => dvec2.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec2 IsNaN(dvec2 v) => dvec2.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec2 IsNegativeInfinity(dvec2 v) => dvec2.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec2 IsPositiveInfinity(dvec2 v) => dvec2.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec2 Abs(dvec2 v) => dvec2.Abs(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec2 HermiteInterpolationOrder3(dvec2 v) => dvec2.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec2 HermiteInterpolationOrder5(dvec2 v) => dvec2.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static dvec2 Sqr(dvec2 v) => dvec2.Sqr(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static dvec2 Pow2(dvec2 v) => dvec2.Pow2(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static dvec2 Pow3(dvec2 v) => dvec2.Pow3(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec2 Step(dvec2 v) => dvec2.Step(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec2 Sqrt(dvec2 v) => dvec2.Sqrt(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec2 InverseSqrt(dvec2 v) => dvec2.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(dvec2 v) => dvec2.Sign(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec2 Max(dvec2 lhs, dvec2 rhs) => dvec2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec2 Min(dvec2 lhs, dvec2 rhs) => dvec2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Pow(dvec2 lhs, dvec2 rhs) => dvec2.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec2 Log(dvec2 lhs, dvec2 rhs) => dvec2.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec2 Clamp(dvec2 v, dvec2 min, dvec2 max) => dvec2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Mix(dvec2 min, dvec2 max, dvec2 a) => dvec2.Mix(min, max, a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec2 Lerp(dvec2 min, dvec2 max, dvec2 a) => dvec2.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec2 Smoothstep(dvec2 edge0, dvec2 edge1, dvec2 v) => dvec2.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec2 Smootherstep(dvec2 edge0, dvec2 edge1, dvec2 v) => dvec2.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec2 Fma(dvec2 a, dvec2 b, dvec2 c) => dvec2.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat2 OuterProduct(dvec2 c, dvec2 r) => dvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat3x2 OuterProduct(dvec2 c, dvec3 r) => dvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat4x2 OuterProduct(dvec2 c, dvec4 r) => dvec2.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec2 Add(dvec2 lhs, dvec2 rhs) => dvec2.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec2 Sub(dvec2 lhs, dvec2 rhs) => dvec2.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec2 Mul(dvec2 lhs, dvec2 rhs) => dvec2.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec2 Div(dvec2 lhs, dvec2 rhs) => dvec2.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec2 Modulo(dvec2 lhs, dvec2 rhs) => dvec2.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec2 Degrees(dvec2 v) => dvec2.Degrees(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec2 Radians(dvec2 v) => dvec2.Radians(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec2 Acos(dvec2 v) => dvec2.Acos(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec2 Asin(dvec2 v) => dvec2.Asin(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec2 Atan(dvec2 v) => dvec2.Atan(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec2 Cos(dvec2 v) => dvec2.Cos(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec2 Cosh(dvec2 v) => dvec2.Cosh(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec2 Exp(dvec2 v) => dvec2.Exp(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec2 Log(dvec2 v) => dvec2.Log(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec2 Log2(dvec2 v) => dvec2.Log2(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec2 Log10(dvec2 v) => dvec2.Log10(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec2 Floor(dvec2 v) => dvec2.Floor(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec2 Ceiling(dvec2 v) => dvec2.Ceiling(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec2 Round(dvec2 v) => dvec2.Round(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec2 Sin(dvec2 v) => dvec2.Sin(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec2 Sinh(dvec2 v) => dvec2.Sinh(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec2 Tan(dvec2 v) => dvec2.Tan(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec2 Tanh(dvec2 v) => dvec2.Tanh(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec2 Truncate(dvec2 v) => dvec2.Truncate(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec2 Fract(dvec2 v) => dvec2.Fract(v);
        
        /// <summary>
        /// Returns a dvec2 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static dvec2 Trunc(dvec2 v) => dvec2.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static double MinElement(dvec2 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static double MaxElement(dvec2 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(dvec2 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(dvec2 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static double Sum(dvec2 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(dvec2 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(dvec2 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(dvec2 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(dvec2 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(dvec2 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static dvec2 Normalized(dvec2 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static dvec2 NormalizedSafe(dvec2 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public static double Angle(dvec2 v) => v.Angle;
        
        /// <summary>
        /// Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).
        /// </summary>
        public static dvec2 Rotated(dvec2 v, double angleInRad) => v.Rotated(angleInRad);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(dvec2 lhs, dvec2 rhs) => dvec2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(dvec2 lhs, dvec2 rhs) => dvec2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(dvec2 lhs, dvec2 rhs) => dvec2.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec2 Reflect(dvec2 I, dvec2 N) => dvec2.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec2 Refract(dvec2 I, dvec2 N, double eta) => dvec2.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static dvec2 FaceForward(dvec2 N, dvec2 I, dvec2 Nref) => dvec2.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static double Cross(dvec2 l, dvec2 r) => dvec2.Cross(l, r);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 Random(Random random, dvec2 minValue, dvec2 maxValue) => dvec2.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec2 RandomUniform(Random random, dvec2 minValue, dvec2 maxValue) => dvec2.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomNormal(Random random, dvec2 mean, dvec2 variance) => dvec2.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a dvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec2 RandomGaussian(Random random, dvec2 mean, dvec2 variance) => dvec2.RandomGaussian(random, mean, variance);

    }
}
