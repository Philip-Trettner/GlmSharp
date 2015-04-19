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
        public static swizzle_hvec4 swizzle(hvec4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static Half[] Values(hvec4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<Half> GetEnumerator(hvec4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(hvec4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(hvec4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(hvec4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(hvec4 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(hvec4 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(hvec4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(hvec4 v, hvec4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(hvec4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(hvec4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(hvec4 lhs, hvec4 rhs, float eps = 0.1f) => hvec4.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(hvec4 lhs, hvec4 rhs) => hvec4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(hvec4 lhs, hvec4 rhs) => hvec4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(hvec4 lhs, hvec4 rhs) => hvec4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(hvec4 lhs, hvec4 rhs) => hvec4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(hvec4 lhs, hvec4 rhs) => hvec4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(hvec4 lhs, hvec4 rhs) => hvec4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsInfinity (Half.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(hvec4 v) => hvec4.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsFinite (!Half.IsNaN(v) &amp;&amp; !Half.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(hvec4 v) => hvec4.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNaN (Half.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(hvec4 v) => hvec4.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNegativeInfinity (Half.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(hvec4 v) => hvec4.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsPositiveInfinity (Half.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(hvec4 v) => hvec4.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Abs (Half.Abs(v)).
        /// </summary>
        public static hvec4 Abs(hvec4 v) => hvec4.Abs(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static hvec4 HermiteInterpolationOrder3(hvec4 v) => hvec4.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static hvec4 HermiteInterpolationOrder5(hvec4 v) => hvec4.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static hvec4 Sqr(hvec4 v) => hvec4.Sqr(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static hvec4 Pow2(hvec4 v) => hvec4.Pow2(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static hvec4 Pow3(hvec4 v) => hvec4.Pow3(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Step (v &gt;= Half.Zero ? Half.One : Half.Zero).
        /// </summary>
        public static hvec4 Step(hvec4 v) => hvec4.Step(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Sqrt ((Half)Math.Sqrt((double)v)).
        /// </summary>
        public static hvec4 Sqrt(hvec4 v) => hvec4.Sqrt(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of InverseSqrt ((Half)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static hvec4 InverseSqrt(hvec4 v) => hvec4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(hvec4 v) => hvec4.Sign(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Max (Half.Max(lhs, rhs)).
        /// </summary>
        public static hvec4 Max(hvec4 lhs, hvec4 rhs) => hvec4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Min (Half.Min(lhs, rhs)).
        /// </summary>
        public static hvec4 Min(hvec4 lhs, hvec4 rhs) => hvec4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Pow ((Half)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec4 Pow(hvec4 lhs, hvec4 rhs) => hvec4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Log ((Half)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec4 Log(hvec4 lhs, hvec4 rhs) => hvec4.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec4 Clamp(hvec4 v, hvec4 min, hvec4 max) => hvec4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec4 Mix(hvec4 min, hvec4 max, hvec4 a) => hvec4.Mix(min, max, a);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec4 Lerp(hvec4 min, hvec4 max, hvec4 a) => hvec4.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec4 Smoothstep(hvec4 edge0, hvec4 edge1, hvec4 v) => hvec4.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec4 Smootherstep(hvec4 edge0, hvec4 edge1, hvec4 v) => hvec4.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec4 Fma(hvec4 a, hvec4 b, hvec4 c) => hvec4.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat2x4 OuterProduct(hvec4 c, hvec2 r) => hvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat3x4 OuterProduct(hvec4 c, hvec3 r) => hvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat4 OuterProduct(hvec4 c, hvec4 r) => hvec4.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static hvec4 Add(hvec4 lhs, hvec4 rhs) => hvec4.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static hvec4 Sub(hvec4 lhs, hvec4 rhs) => hvec4.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static hvec4 Mul(hvec4 lhs, hvec4 rhs) => hvec4.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static hvec4 Div(hvec4 lhs, hvec4 rhs) => hvec4.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static hvec4 Modulo(hvec4 lhs, hvec4 rhs) => hvec4.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static hvec4 Degrees(hvec4 v) => hvec4.Degrees(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static hvec4 Radians(hvec4 v) => hvec4.Radians(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Acos ((Half)Math.Acos((double)v)).
        /// </summary>
        public static hvec4 Acos(hvec4 v) => hvec4.Acos(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Asin ((Half)Math.Asin((double)v)).
        /// </summary>
        public static hvec4 Asin(hvec4 v) => hvec4.Asin(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Atan ((Half)Math.Atan((double)v)).
        /// </summary>
        public static hvec4 Atan(hvec4 v) => hvec4.Atan(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Cos ((Half)Math.Cos((double)v)).
        /// </summary>
        public static hvec4 Cos(hvec4 v) => hvec4.Cos(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Cosh ((Half)Math.Cosh((double)v)).
        /// </summary>
        public static hvec4 Cosh(hvec4 v) => hvec4.Cosh(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Exp ((Half)Math.Exp((double)v)).
        /// </summary>
        public static hvec4 Exp(hvec4 v) => hvec4.Exp(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Log ((Half)Math.Log((double)v)).
        /// </summary>
        public static hvec4 Log(hvec4 v) => hvec4.Log(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Log2 ((Half)Math.Log((double)v, 2)).
        /// </summary>
        public static hvec4 Log2(hvec4 v) => hvec4.Log2(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Log10 ((Half)Math.Log10((double)v)).
        /// </summary>
        public static hvec4 Log10(hvec4 v) => hvec4.Log10(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Floor ((Half)Math.Floor(v)).
        /// </summary>
        public static hvec4 Floor(hvec4 v) => hvec4.Floor(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Ceiling ((Half)Math.Ceiling(v)).
        /// </summary>
        public static hvec4 Ceiling(hvec4 v) => hvec4.Ceiling(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Round ((Half)Math.Round(v)).
        /// </summary>
        public static hvec4 Round(hvec4 v) => hvec4.Round(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Sin ((Half)Math.Sin((double)v)).
        /// </summary>
        public static hvec4 Sin(hvec4 v) => hvec4.Sin(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Sinh ((Half)Math.Sinh((double)v)).
        /// </summary>
        public static hvec4 Sinh(hvec4 v) => hvec4.Sinh(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Tan ((Half)Math.Tan((double)v)).
        /// </summary>
        public static hvec4 Tan(hvec4 v) => hvec4.Tan(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Tanh ((Half)Math.Tanh((double)v)).
        /// </summary>
        public static hvec4 Tanh(hvec4 v) => hvec4.Tanh(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Truncate ((Half)Math.Truncate((double)v)).
        /// </summary>
        public static hvec4 Truncate(hvec4 v) => hvec4.Truncate(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Fract ((Half)(v - Math.Floor(v))).
        /// </summary>
        public static hvec4 Fract(hvec4 v) => hvec4.Fract(v);
        
        /// <summary>
        /// Returns a hvec4 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static hvec4 Trunc(hvec4 v) => hvec4.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static Half MinElement(hvec4 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static Half MaxElement(hvec4 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(hvec4 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(hvec4 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static Half Sum(hvec4 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(hvec4 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(hvec4 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(hvec4 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(hvec4 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(hvec4 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static hvec4 Normalized(hvec4 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static hvec4 NormalizedSafe(hvec4 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Half Dot(hvec4 lhs, hvec4 rhs) => hvec4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(hvec4 lhs, hvec4 rhs) => hvec4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(hvec4 lhs, hvec4 rhs) => hvec4.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static hvec4 Reflect(hvec4 I, hvec4 N) => hvec4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static hvec4 Refract(hvec4 I, hvec4 N, Half eta) => hvec4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static hvec4 FaceForward(hvec4 N, hvec4 I, hvec4 Nref) => hvec4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a hvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec4 Random(Random random, hvec4 minValue, hvec4 maxValue) => hvec4.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a hvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec4 RandomUniform(Random random, hvec4 minValue, hvec4 maxValue) => hvec4.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a hvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec4 RandomNormal(Random random, hvec4 mean, hvec4 variance) => hvec4.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a hvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec4 RandomGaussian(Random random, hvec4 mean, hvec4 variance) => hvec4.RandomGaussian(random, mean, variance);

    }
}
