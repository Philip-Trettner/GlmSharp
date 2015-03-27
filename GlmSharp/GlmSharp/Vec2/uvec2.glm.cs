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
        public static swizzle_uvec2 swizzle(uvec2 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static uint[] Values(uvec2 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<uint> GetEnumerator(uvec2 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(uvec2 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(uvec2 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(uvec2 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(uvec2 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(uvec2 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public static int Count(uvec2 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(uvec2 v, uvec2 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(uvec2 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(uvec2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(uvec2 lhs, uvec2 rhs) => uvec2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(uvec2 lhs, uvec2 rhs) => uvec2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(uvec2 lhs, uvec2 rhs) => uvec2.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(uvec2 lhs, uvec2 rhs) => uvec2.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(uvec2 lhs, uvec2 rhs) => uvec2.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(uvec2 lhs, uvec2 rhs) => uvec2.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Abs (v).
        /// </summary>
        public static uvec2 Abs(uvec2 v) => uvec2.Abs(v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uvec2 HermiteInterpolationOrder3(uvec2 v) => uvec2.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uvec2 HermiteInterpolationOrder5(uvec2 v) => uvec2.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static uvec2 Sqr(uvec2 v) => uvec2.Sqr(v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static uvec2 Pow2(uvec2 v) => uvec2.Pow2(v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static uvec2 Pow3(uvec2 v) => uvec2.Pow3(v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uvec2 Step(uvec2 v) => uvec2.Step(v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Sqrt ((uint)Math.Sqrt((double)v)).
        /// </summary>
        public static uvec2 Sqrt(uvec2 v) => uvec2.Sqrt(v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of InverseSqrt ((uint)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static uvec2 InverseSqrt(uvec2 v) => uvec2.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(uvec2 v) => uvec2.Sign(v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec2 Max(uvec2 lhs, uvec2 rhs) => uvec2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec2 Min(uvec2 lhs, uvec2 rhs) => uvec2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec2 Pow(uvec2 lhs, uvec2 rhs) => uvec2.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec2 Log(uvec2 lhs, uvec2 rhs) => uvec2.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec2 Clamp(uvec2 v, uvec2 min, uvec2 max) => uvec2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec2 Mix(uvec2 min, uvec2 max, uvec2 a) => uvec2.Mix(min, max, a);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec2 Lerp(uvec2 min, uvec2 max, uvec2 a) => uvec2.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec2 Smoothstep(uvec2 edge0, uvec2 edge1, uvec2 v) => uvec2.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec2 Smootherstep(uvec2 edge0, uvec2 edge1, uvec2 v) => uvec2.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec2 Fma(uvec2 a, uvec2 b, uvec2 c) => uvec2.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat2 OuterProduct(uvec2 c, uvec2 r) => uvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat3x2 OuterProduct(uvec2 c, uvec3 r) => uvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat4x2 OuterProduct(uvec2 c, uvec4 r) => uvec2.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec2 Add(uvec2 lhs, uvec2 rhs) => uvec2.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec2 Sub(uvec2 lhs, uvec2 rhs) => uvec2.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec2 Mul(uvec2 lhs, uvec2 rhs) => uvec2.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec2 Div(uvec2 lhs, uvec2 rhs) => uvec2.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec2 Xor(uvec2 lhs, uvec2 rhs) => uvec2.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec2 BitwiseOr(uvec2 lhs, uvec2 rhs) => uvec2.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec2 BitwiseAnd(uvec2 lhs, uvec2 rhs) => uvec2.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec2 LeftShift(uvec2 lhs, ivec2 rhs) => uvec2.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec2 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec2 RightShift(uvec2 lhs, ivec2 rhs) => uvec2.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static uint MinElement(uvec2 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static uint MaxElement(uvec2 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(uvec2 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(uvec2 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static uint Sum(uvec2 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(uvec2 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(uvec2 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(uvec2 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(uvec2 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(uvec2 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static uint Dot(uvec2 lhs, uvec2 rhs) => uvec2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(uvec2 lhs, uvec2 rhs) => uvec2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(uvec2 lhs, uvec2 rhs) => uvec2.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static uint Cross(uvec2 l, uvec2 r) => uvec2.Cross(l, r);
        
        /// <summary>
        /// Returns a uvec2 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uvec2 Random(Random random, uvec2 maxValue) => uvec2.Random(random, maxValue);
        
        /// <summary>
        /// Returns a uvec2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec2 Random(Random random, uvec2 minValue, uvec2 maxValue) => uvec2.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a uvec2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec2 RandomUniform(Random random, uvec2 minValue, uvec2 maxValue) => uvec2.RandomUniform(random, minValue, maxValue);

    }
}
