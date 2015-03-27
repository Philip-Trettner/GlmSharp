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
        public static swizzle_uvec4 swizzle(uvec4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static uint[] Values(uvec4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<uint> GetEnumerator(uvec4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(uvec4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(uvec4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(uvec4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(uvec4 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(uvec4 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(uvec4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(uvec4 v, uvec4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(uvec4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(uvec4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(uvec4 lhs, uvec4 rhs) => uvec4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(uvec4 lhs, uvec4 rhs) => uvec4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(uvec4 lhs, uvec4 rhs) => uvec4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(uvec4 lhs, uvec4 rhs) => uvec4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(uvec4 lhs, uvec4 rhs) => uvec4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(uvec4 lhs, uvec4 rhs) => uvec4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Abs (v).
        /// </summary>
        public static uvec4 Abs(uvec4 v) => uvec4.Abs(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uvec4 HermiteInterpolationOrder3(uvec4 v) => uvec4.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uvec4 HermiteInterpolationOrder5(uvec4 v) => uvec4.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static uvec4 Sqr(uvec4 v) => uvec4.Sqr(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static uvec4 Pow2(uvec4 v) => uvec4.Pow2(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static uvec4 Pow3(uvec4 v) => uvec4.Pow3(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uvec4 Step(uvec4 v) => uvec4.Step(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Sqrt ((uint)Math.Sqrt((double)v)).
        /// </summary>
        public static uvec4 Sqrt(uvec4 v) => uvec4.Sqrt(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of InverseSqrt ((uint)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static uvec4 InverseSqrt(uvec4 v) => uvec4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(uvec4 v) => uvec4.Sign(v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec4 Max(uvec4 lhs, uvec4 rhs) => uvec4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec4 Min(uvec4 lhs, uvec4 rhs) => uvec4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Pow(uvec4 lhs, uvec4 rhs) => uvec4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec4 Log(uvec4 lhs, uvec4 rhs) => uvec4.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec4 Clamp(uvec4 v, uvec4 min, uvec4 max) => uvec4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Mix(uvec4 min, uvec4 max, uvec4 a) => uvec4.Mix(min, max, a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec4 Lerp(uvec4 min, uvec4 max, uvec4 a) => uvec4.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec4 Smoothstep(uvec4 edge0, uvec4 edge1, uvec4 v) => uvec4.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec4 Smootherstep(uvec4 edge0, uvec4 edge1, uvec4 v) => uvec4.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec4 Fma(uvec4 a, uvec4 b, uvec4 c) => uvec4.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat2x4 OuterProduct(uvec4 c, uvec2 r) => uvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat3x4 OuterProduct(uvec4 c, uvec3 r) => uvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat4 OuterProduct(uvec4 c, uvec4 r) => uvec4.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec4 Add(uvec4 lhs, uvec4 rhs) => uvec4.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec4 Sub(uvec4 lhs, uvec4 rhs) => uvec4.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec4 Mul(uvec4 lhs, uvec4 rhs) => uvec4.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec4 Div(uvec4 lhs, uvec4 rhs) => uvec4.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec4 Xor(uvec4 lhs, uvec4 rhs) => uvec4.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec4 BitwiseOr(uvec4 lhs, uvec4 rhs) => uvec4.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec4 BitwiseAnd(uvec4 lhs, uvec4 rhs) => uvec4.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec4 LeftShift(uvec4 lhs, ivec4 rhs) => uvec4.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec4 RightShift(uvec4 lhs, ivec4 rhs) => uvec4.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static uint MinElement(uvec4 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static uint MaxElement(uvec4 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(uvec4 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(uvec4 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static uint Sum(uvec4 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(uvec4 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(uvec4 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(uvec4 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(uvec4 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(uvec4 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static uint Dot(uvec4 lhs, uvec4 rhs) => uvec4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(uvec4 lhs, uvec4 rhs) => uvec4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(uvec4 lhs, uvec4 rhs) => uvec4.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uvec4 Random(Random random, uvec4 maxValue) => uvec4.Random(random, maxValue);
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 Random(Random random, uvec4 minValue, uvec4 maxValue) => uvec4.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a uvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec4 RandomUniform(Random random, uvec4 minValue, uvec4 maxValue) => uvec4.RandomUniform(random, minValue, maxValue);

    }
}
