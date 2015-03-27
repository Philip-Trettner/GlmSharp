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
        public static swizzle_vec2 swizzle(vec2 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static float[] Values(vec2 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<float> GetEnumerator(vec2 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(vec2 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(vec2 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(vec2 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(vec2 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(vec2 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public static int Count(vec2 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(vec2 v, vec2 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(vec2 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(vec2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(vec2 lhs, vec2 rhs, float eps = 0.1f) => vec2.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(vec2 lhs, vec2 rhs) => vec2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(vec2 lhs, vec2 rhs) => vec2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(vec2 lhs, vec2 rhs) => vec2.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(vec2 lhs, vec2 rhs) => vec2.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(vec2 lhs, vec2 rhs) => vec2.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(vec2 lhs, vec2 rhs) => vec2.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsInfinity(vec2 v) => vec2.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bvec2 IsFinite(vec2 v) => vec2.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bvec2 IsNaN(vec2 v) => vec2.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec2 IsNegativeInfinity(vec2 v) => vec2.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec2 IsPositiveInfinity(vec2 v) => vec2.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static vec2 Abs(vec2 v) => vec2.Abs(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static vec2 HermiteInterpolationOrder3(vec2 v) => vec2.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static vec2 HermiteInterpolationOrder5(vec2 v) => vec2.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static vec2 Sqr(vec2 v) => vec2.Sqr(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static vec2 Pow2(vec2 v) => vec2.Pow2(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static vec2 Pow3(vec2 v) => vec2.Pow3(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static vec2 Step(vec2 v) => vec2.Step(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Sqrt ((float)Math.Sqrt((double)v)).
        /// </summary>
        public static vec2 Sqrt(vec2 v) => vec2.Sqrt(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of InverseSqrt ((float)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static vec2 InverseSqrt(vec2 v) => vec2.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(vec2 v) => vec2.Sign(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec2 Max(vec2 lhs, vec2 rhs) => vec2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec2 Min(vec2 lhs, vec2 rhs) => vec2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec2 Pow(vec2 lhs, vec2 rhs) => vec2.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec2 Log(vec2 lhs, vec2 rhs) => vec2.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec2 Clamp(vec2 v, vec2 min, vec2 max) => vec2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec2 Mix(vec2 min, vec2 max, vec2 a) => vec2.Mix(min, max, a);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec2 Lerp(vec2 min, vec2 max, vec2 a) => vec2.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec2 Smoothstep(vec2 edge0, vec2 edge1, vec2 v) => vec2.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec2 Smootherstep(vec2 edge0, vec2 edge1, vec2 v) => vec2.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec2 Fma(vec2 a, vec2 b, vec2 c) => vec2.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat2 OuterProduct(vec2 c, vec2 r) => vec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat3x2 OuterProduct(vec2 c, vec3 r) => vec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat4x2 OuterProduct(vec2 c, vec4 r) => vec2.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec2 Add(vec2 lhs, vec2 rhs) => vec2.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec2 Sub(vec2 lhs, vec2 rhs) => vec2.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec2 Mul(vec2 lhs, vec2 rhs) => vec2.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec2 Div(vec2 lhs, vec2 rhs) => vec2.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec2 Modulo(vec2 lhs, vec2 rhs) => vec2.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static vec2 Degrees(vec2 v) => vec2.Degrees(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static vec2 Radians(vec2 v) => vec2.Radians(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Acos ((float)Math.Acos((double)v)).
        /// </summary>
        public static vec2 Acos(vec2 v) => vec2.Acos(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Asin ((float)Math.Asin((double)v)).
        /// </summary>
        public static vec2 Asin(vec2 v) => vec2.Asin(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Atan ((float)Math.Atan((double)v)).
        /// </summary>
        public static vec2 Atan(vec2 v) => vec2.Atan(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Cos ((float)Math.Cos((double)v)).
        /// </summary>
        public static vec2 Cos(vec2 v) => vec2.Cos(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Cosh ((float)Math.Cosh((double)v)).
        /// </summary>
        public static vec2 Cosh(vec2 v) => vec2.Cosh(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Exp ((float)Math.Exp((double)v)).
        /// </summary>
        public static vec2 Exp(vec2 v) => vec2.Exp(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Log ((float)Math.Log((double)v)).
        /// </summary>
        public static vec2 Log(vec2 v) => vec2.Log(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Log2 ((float)Math.Log((double)v, 2)).
        /// </summary>
        public static vec2 Log2(vec2 v) => vec2.Log2(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Log10 ((float)Math.Log10((double)v)).
        /// </summary>
        public static vec2 Log10(vec2 v) => vec2.Log10(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Floor ((float)Math.Floor(v)).
        /// </summary>
        public static vec2 Floor(vec2 v) => vec2.Floor(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Ceiling ((float)Math.Ceiling(v)).
        /// </summary>
        public static vec2 Ceiling(vec2 v) => vec2.Ceiling(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Round ((float)Math.Round(v)).
        /// </summary>
        public static vec2 Round(vec2 v) => vec2.Round(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Sin ((float)Math.Sin((double)v)).
        /// </summary>
        public static vec2 Sin(vec2 v) => vec2.Sin(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Sinh ((float)Math.Sinh((double)v)).
        /// </summary>
        public static vec2 Sinh(vec2 v) => vec2.Sinh(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Tan ((float)Math.Tan((double)v)).
        /// </summary>
        public static vec2 Tan(vec2 v) => vec2.Tan(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Tanh ((float)Math.Tanh((double)v)).
        /// </summary>
        public static vec2 Tanh(vec2 v) => vec2.Tanh(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Truncate ((float)Math.Truncate((double)v)).
        /// </summary>
        public static vec2 Truncate(vec2 v) => vec2.Truncate(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Fract ((float)(v - Math.Floor(v))).
        /// </summary>
        public static vec2 Fract(vec2 v) => vec2.Fract(v);
        
        /// <summary>
        /// Returns a vec2 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static vec2 Trunc(vec2 v) => vec2.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static float MinElement(vec2 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static float MaxElement(vec2 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(vec2 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(vec2 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static float Sum(vec2 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(vec2 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(vec2 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(vec2 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(vec2 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(vec2 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static vec2 Normalized(vec2 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static vec2 NormalizedSafe(vec2 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public static double Angle(vec2 v) => v.Angle;
        
        /// <summary>
        /// Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).
        /// </summary>
        public static vec2 Rotated(vec2 v, double angleInRad) => v.Rotated(angleInRad);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(vec2 lhs, vec2 rhs) => vec2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(vec2 lhs, vec2 rhs) => vec2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(vec2 lhs, vec2 rhs) => vec2.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec2 Reflect(vec2 I, vec2 N) => vec2.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec2 Refract(vec2 I, vec2 N, float eta) => vec2.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static vec2 FaceForward(vec2 N, vec2 I, vec2 Nref) => vec2.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static float Cross(vec2 l, vec2 r) => vec2.Cross(l, r);
        
        /// <summary>
        /// Returns a vec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec2 Random(Random random, vec2 minValue, vec2 maxValue) => vec2.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a vec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec2 RandomUniform(Random random, vec2 minValue, vec2 maxValue) => vec2.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a vec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec2 RandomNormal(Random random, vec2 mean, vec2 variance) => vec2.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a vec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec2 RandomGaussian(Random random, vec2 mean, vec2 variance) => vec2.RandomGaussian(random, mean, variance);

    }
}
