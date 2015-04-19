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
        public static swizzle_hvec2 swizzle(hvec2 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static Half[] Values(hvec2 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<Half> GetEnumerator(hvec2 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(hvec2 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(hvec2 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(hvec2 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(hvec2 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(hvec2 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public static int Count(hvec2 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(hvec2 v, hvec2 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(hvec2 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(hvec2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(hvec2 lhs, hvec2 rhs, float eps = 0.1f) => hvec2.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(hvec2 lhs, hvec2 rhs) => hvec2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(hvec2 lhs, hvec2 rhs) => hvec2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(hvec2 lhs, hvec2 rhs) => hvec2.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(hvec2 lhs, hvec2 rhs) => hvec2.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(hvec2 lhs, hvec2 rhs) => hvec2.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(hvec2 lhs, hvec2 rhs) => hvec2.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsInfinity (Half.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsInfinity(hvec2 v) => hvec2.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsFinite (!Half.IsNaN(v) &amp;&amp; !Half.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsFinite(hvec2 v) => hvec2.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsNaN (Half.IsNaN(v)).
        /// </summary>
        public static bvec2 IsNaN(hvec2 v) => hvec2.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsNegativeInfinity (Half.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec2 IsNegativeInfinity(hvec2 v) => hvec2.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsPositiveInfinity (Half.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec2 IsPositiveInfinity(hvec2 v) => hvec2.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Abs (Half.Abs(v)).
        /// </summary>
        public static hvec2 Abs(hvec2 v) => hvec2.Abs(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static hvec2 HermiteInterpolationOrder3(hvec2 v) => hvec2.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static hvec2 HermiteInterpolationOrder5(hvec2 v) => hvec2.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static hvec2 Sqr(hvec2 v) => hvec2.Sqr(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static hvec2 Pow2(hvec2 v) => hvec2.Pow2(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static hvec2 Pow3(hvec2 v) => hvec2.Pow3(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Step (v &gt;= Half.Zero ? Half.One : Half.Zero).
        /// </summary>
        public static hvec2 Step(hvec2 v) => hvec2.Step(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Sqrt ((Half)Math.Sqrt((double)v)).
        /// </summary>
        public static hvec2 Sqrt(hvec2 v) => hvec2.Sqrt(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of InverseSqrt ((Half)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static hvec2 InverseSqrt(hvec2 v) => hvec2.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(hvec2 v) => hvec2.Sign(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Max (Half.Max(lhs, rhs)).
        /// </summary>
        public static hvec2 Max(hvec2 lhs, hvec2 rhs) => hvec2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Min (Half.Min(lhs, rhs)).
        /// </summary>
        public static hvec2 Min(hvec2 lhs, hvec2 rhs) => hvec2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Pow ((Half)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec2 Pow(hvec2 lhs, hvec2 rhs) => hvec2.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Log ((Half)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec2 Log(hvec2 lhs, hvec2 rhs) => hvec2.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec2 Clamp(hvec2 v, hvec2 min, hvec2 max) => hvec2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec2 Mix(hvec2 min, hvec2 max, hvec2 a) => hvec2.Mix(min, max, a);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec2 Lerp(hvec2 min, hvec2 max, hvec2 a) => hvec2.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec2 Smoothstep(hvec2 edge0, hvec2 edge1, hvec2 v) => hvec2.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec2 Smootherstep(hvec2 edge0, hvec2 edge1, hvec2 v) => hvec2.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec2 Fma(hvec2 a, hvec2 b, hvec2 c) => hvec2.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat2 OuterProduct(hvec2 c, hvec2 r) => hvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat3x2 OuterProduct(hvec2 c, hvec3 r) => hvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat4x2 OuterProduct(hvec2 c, hvec4 r) => hvec2.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static hvec2 Add(hvec2 lhs, hvec2 rhs) => hvec2.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static hvec2 Sub(hvec2 lhs, hvec2 rhs) => hvec2.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static hvec2 Mul(hvec2 lhs, hvec2 rhs) => hvec2.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static hvec2 Div(hvec2 lhs, hvec2 rhs) => hvec2.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static hvec2 Modulo(hvec2 lhs, hvec2 rhs) => hvec2.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static hvec2 Degrees(hvec2 v) => hvec2.Degrees(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static hvec2 Radians(hvec2 v) => hvec2.Radians(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Acos ((Half)Math.Acos((double)v)).
        /// </summary>
        public static hvec2 Acos(hvec2 v) => hvec2.Acos(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Asin ((Half)Math.Asin((double)v)).
        /// </summary>
        public static hvec2 Asin(hvec2 v) => hvec2.Asin(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Atan ((Half)Math.Atan((double)v)).
        /// </summary>
        public static hvec2 Atan(hvec2 v) => hvec2.Atan(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Cos ((Half)Math.Cos((double)v)).
        /// </summary>
        public static hvec2 Cos(hvec2 v) => hvec2.Cos(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Cosh ((Half)Math.Cosh((double)v)).
        /// </summary>
        public static hvec2 Cosh(hvec2 v) => hvec2.Cosh(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Exp ((Half)Math.Exp((double)v)).
        /// </summary>
        public static hvec2 Exp(hvec2 v) => hvec2.Exp(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Log ((Half)Math.Log((double)v)).
        /// </summary>
        public static hvec2 Log(hvec2 v) => hvec2.Log(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Log2 ((Half)Math.Log((double)v, 2)).
        /// </summary>
        public static hvec2 Log2(hvec2 v) => hvec2.Log2(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Log10 ((Half)Math.Log10((double)v)).
        /// </summary>
        public static hvec2 Log10(hvec2 v) => hvec2.Log10(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Floor ((Half)Math.Floor(v)).
        /// </summary>
        public static hvec2 Floor(hvec2 v) => hvec2.Floor(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Ceiling ((Half)Math.Ceiling(v)).
        /// </summary>
        public static hvec2 Ceiling(hvec2 v) => hvec2.Ceiling(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Round ((Half)Math.Round(v)).
        /// </summary>
        public static hvec2 Round(hvec2 v) => hvec2.Round(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Sin ((Half)Math.Sin((double)v)).
        /// </summary>
        public static hvec2 Sin(hvec2 v) => hvec2.Sin(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Sinh ((Half)Math.Sinh((double)v)).
        /// </summary>
        public static hvec2 Sinh(hvec2 v) => hvec2.Sinh(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Tan ((Half)Math.Tan((double)v)).
        /// </summary>
        public static hvec2 Tan(hvec2 v) => hvec2.Tan(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Tanh ((Half)Math.Tanh((double)v)).
        /// </summary>
        public static hvec2 Tanh(hvec2 v) => hvec2.Tanh(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Truncate ((Half)Math.Truncate((double)v)).
        /// </summary>
        public static hvec2 Truncate(hvec2 v) => hvec2.Truncate(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Fract ((Half)(v - Math.Floor(v))).
        /// </summary>
        public static hvec2 Fract(hvec2 v) => hvec2.Fract(v);
        
        /// <summary>
        /// Returns a hvec2 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static hvec2 Trunc(hvec2 v) => hvec2.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static Half MinElement(hvec2 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static Half MaxElement(hvec2 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(hvec2 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(hvec2 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static Half Sum(hvec2 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(hvec2 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(hvec2 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(hvec2 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(hvec2 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(hvec2 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static hvec2 Normalized(hvec2 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static hvec2 NormalizedSafe(hvec2 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public static double Angle(hvec2 v) => v.Angle;
        
        /// <summary>
        /// Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).
        /// </summary>
        public static hvec2 Rotated(hvec2 v, double angleInRad) => v.Rotated(angleInRad);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Half Dot(hvec2 lhs, hvec2 rhs) => hvec2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(hvec2 lhs, hvec2 rhs) => hvec2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(hvec2 lhs, hvec2 rhs) => hvec2.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static hvec2 Reflect(hvec2 I, hvec2 N) => hvec2.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static hvec2 Refract(hvec2 I, hvec2 N, Half eta) => hvec2.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static hvec2 FaceForward(hvec2 N, hvec2 I, hvec2 Nref) => hvec2.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static Half Cross(hvec2 l, hvec2 r) => hvec2.Cross(l, r);
        
        /// <summary>
        /// Returns a hvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec2 Random(Random random, hvec2 minValue, hvec2 maxValue) => hvec2.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a hvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec2 RandomUniform(Random random, hvec2 minValue, hvec2 maxValue) => hvec2.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a hvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec2 RandomNormal(Random random, hvec2 mean, hvec2 variance) => hvec2.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a hvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec2 RandomGaussian(Random random, hvec2 mean, hvec2 variance) => hvec2.RandomGaussian(random, mean, variance);

    }
}
