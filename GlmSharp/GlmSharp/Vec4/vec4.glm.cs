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
        public static swizzle_vec4 swizzle(vec4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static float[] Values(vec4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<float> GetEnumerator(vec4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(vec4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(vec4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(vec4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(vec4 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(vec4 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(vec4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(vec4 v, vec4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(vec4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(vec4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(vec4 lhs, vec4 rhs, float eps = 0.1f) => vec4.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(vec4 lhs, vec4 rhs) => vec4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(vec4 lhs, vec4 rhs) => vec4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(vec4 lhs, vec4 rhs) => vec4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(vec4 lhs, vec4 rhs) => vec4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(vec4 lhs, vec4 rhs) => vec4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(vec4 lhs, vec4 rhs) => vec4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(vec4 v) => vec4.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(vec4 v) => vec4.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(vec4 v) => vec4.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(vec4 v) => vec4.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(vec4 v) => vec4.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static vec4 Abs(vec4 v) => vec4.Abs(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static vec4 HermiteInterpolationOrder3(vec4 v) => vec4.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static vec4 HermiteInterpolationOrder5(vec4 v) => vec4.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static vec4 Sqr(vec4 v) => vec4.Sqr(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static vec4 Pow2(vec4 v) => vec4.Pow2(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static vec4 Pow3(vec4 v) => vec4.Pow3(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static vec4 Step(vec4 v) => vec4.Step(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sqrt ((float)Math.Sqrt((double)v)).
        /// </summary>
        public static vec4 Sqrt(vec4 v) => vec4.Sqrt(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of InverseSqrt ((float)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static vec4 InverseSqrt(vec4 v) => vec4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(vec4 v) => vec4.Sign(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec4 Max(vec4 lhs, vec4 rhs) => vec4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec4 Min(vec4 lhs, vec4 rhs) => vec4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Pow(vec4 lhs, vec4 rhs) => vec4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec4 Log(vec4 lhs, vec4 rhs) => vec4.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec4 Clamp(vec4 v, vec4 min, vec4 max) => vec4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Mix(vec4 min, vec4 max, vec4 a) => vec4.Mix(min, max, a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec4 Lerp(vec4 min, vec4 max, vec4 a) => vec4.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec4 Smoothstep(vec4 edge0, vec4 edge1, vec4 v) => vec4.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec4 Smootherstep(vec4 edge0, vec4 edge1, vec4 v) => vec4.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec4 Fma(vec4 a, vec4 b, vec4 c) => vec4.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat2x4 OuterProduct(vec4 c, vec2 r) => vec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat3x4 OuterProduct(vec4 c, vec3 r) => vec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat4 OuterProduct(vec4 c, vec4 r) => vec4.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec4 Add(vec4 lhs, vec4 rhs) => vec4.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec4 Sub(vec4 lhs, vec4 rhs) => vec4.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec4 Mul(vec4 lhs, vec4 rhs) => vec4.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec4 Div(vec4 lhs, vec4 rhs) => vec4.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec4 Modulo(vec4 lhs, vec4 rhs) => vec4.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static vec4 Degrees(vec4 v) => vec4.Degrees(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static vec4 Radians(vec4 v) => vec4.Radians(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Acos ((float)Math.Acos((double)v)).
        /// </summary>
        public static vec4 Acos(vec4 v) => vec4.Acos(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Asin ((float)Math.Asin((double)v)).
        /// </summary>
        public static vec4 Asin(vec4 v) => vec4.Asin(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Atan ((float)Math.Atan((double)v)).
        /// </summary>
        public static vec4 Atan(vec4 v) => vec4.Atan(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Cos ((float)Math.Cos((double)v)).
        /// </summary>
        public static vec4 Cos(vec4 v) => vec4.Cos(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Cosh ((float)Math.Cosh((double)v)).
        /// </summary>
        public static vec4 Cosh(vec4 v) => vec4.Cosh(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Exp ((float)Math.Exp((double)v)).
        /// </summary>
        public static vec4 Exp(vec4 v) => vec4.Exp(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log ((float)Math.Log((double)v)).
        /// </summary>
        public static vec4 Log(vec4 v) => vec4.Log(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log2 ((float)Math.Log((double)v, 2)).
        /// </summary>
        public static vec4 Log2(vec4 v) => vec4.Log2(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Log10 ((float)Math.Log10((double)v)).
        /// </summary>
        public static vec4 Log10(vec4 v) => vec4.Log10(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Floor ((float)Math.Floor(v)).
        /// </summary>
        public static vec4 Floor(vec4 v) => vec4.Floor(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Ceiling ((float)Math.Ceiling(v)).
        /// </summary>
        public static vec4 Ceiling(vec4 v) => vec4.Ceiling(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Round ((float)Math.Round(v)).
        /// </summary>
        public static vec4 Round(vec4 v) => vec4.Round(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sin ((float)Math.Sin((double)v)).
        /// </summary>
        public static vec4 Sin(vec4 v) => vec4.Sin(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Sinh ((float)Math.Sinh((double)v)).
        /// </summary>
        public static vec4 Sinh(vec4 v) => vec4.Sinh(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Tan ((float)Math.Tan((double)v)).
        /// </summary>
        public static vec4 Tan(vec4 v) => vec4.Tan(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Tanh ((float)Math.Tanh((double)v)).
        /// </summary>
        public static vec4 Tanh(vec4 v) => vec4.Tanh(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Truncate ((float)Math.Truncate((double)v)).
        /// </summary>
        public static vec4 Truncate(vec4 v) => vec4.Truncate(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Fract ((float)(v - Math.Floor(v))).
        /// </summary>
        public static vec4 Fract(vec4 v) => vec4.Fract(v);
        
        /// <summary>
        /// Returns a vec4 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static vec4 Trunc(vec4 v) => vec4.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static float MinElement(vec4 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static float MaxElement(vec4 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(vec4 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(vec4 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static float Sum(vec4 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(vec4 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(vec4 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(vec4 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(vec4 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(vec4 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static vec4 Normalized(vec4 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static vec4 NormalizedSafe(vec4 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(vec4 lhs, vec4 rhs) => vec4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(vec4 lhs, vec4 rhs) => vec4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(vec4 lhs, vec4 rhs) => vec4.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec4 Reflect(vec4 I, vec4 N) => vec4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec4 Refract(vec4 I, vec4 N, float eta) => vec4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static vec4 FaceForward(vec4 N, vec4 I, vec4 Nref) => vec4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 Random(Random random, vec4 minValue, vec4 maxValue) => vec4.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec4 RandomUniform(Random random, vec4 minValue, vec4 maxValue) => vec4.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomNormal(Random random, vec4 mean, vec4 variance) => vec4.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a vec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec4 RandomGaussian(Random random, vec4 mean, vec4 variance) => vec4.RandomGaussian(random, mean, variance);

    }
}
