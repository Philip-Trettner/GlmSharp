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
        public static swizzle_uvec3 swizzle(uvec3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static uint[] Values(uvec3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<uint> GetEnumerator(uvec3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(uvec3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(uvec3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(uvec3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(uvec3 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(uvec3 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(uvec3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(uvec3 v, uvec3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(uvec3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(uvec3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(uvec3 lhs, uvec3 rhs) => uvec3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(uint lhs, uint rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(uvec3 lhs, uvec3 rhs) => uvec3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(uint lhs, uint rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(uvec3 lhs, uvec3 rhs) => uvec3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool GreaterThan(uint lhs, uint rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(uvec3 lhs, uvec3 rhs) => uvec3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool GreaterThanEqual(uint lhs, uint rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(uvec3 lhs, uvec3 rhs) => uvec3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool LesserThan(uint lhs, uint rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(uvec3 lhs, uvec3 rhs) => uvec3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool LesserThanEqual(uint lhs, uint rhs) => lhs <= rhs;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Abs (v).
        /// </summary>
        public static uvec3 Abs(uvec3 v) => uvec3.Abs(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Abs (v).
        /// </summary>
        public static uint Abs(uint v) => v;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uvec3 HermiteInterpolationOrder3(uvec3 v) => uvec3.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static uint HermiteInterpolationOrder3(uint v) => (3 - 2 * v) * v * v;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uvec3 HermiteInterpolationOrder5(uvec3 v) => uvec3.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static uint HermiteInterpolationOrder5(uint v) => ((6 * v - 15) * v + 10) * v * v * v;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static uvec3 Sqr(uvec3 v) => uvec3.Sqr(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static uint Sqr(uint v) => v * v;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static uvec3 Pow2(uvec3 v) => uvec3.Pow2(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static uint Pow2(uint v) => v * v;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static uvec3 Pow3(uvec3 v) => uvec3.Pow3(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static uint Pow3(uint v) => v * v * v;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uvec3 Step(uvec3 v) => uvec3.Step(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Step (v &gt;= 0u ? 1u : 0u).
        /// </summary>
        public static uint Step(uint v) => v >= 0u ? 1u : 0u;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sqrt ((uint)Math.Sqrt((double)v)).
        /// </summary>
        public static uvec3 Sqrt(uvec3 v) => uvec3.Sqrt(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sqrt ((uint)Math.Sqrt((double)v)).
        /// </summary>
        public static uint Sqrt(uint v) => (uint)Math.Sqrt((double)v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of InverseSqrt ((uint)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static uvec3 InverseSqrt(uvec3 v) => uvec3.InverseSqrt(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of InverseSqrt ((uint)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static uint InverseSqrt(uint v) => (uint)(1.0 / Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(uvec3 v) => uvec3.Sign(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static int Sign(uint v) => Math.Sign(v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uvec3 Max(uvec3 lhs, uvec3 rhs) => uvec3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static uint Max(uint lhs, uint rhs) => Math.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uvec3 Min(uvec3 lhs, uvec3 rhs) => uvec3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static uint Min(uint lhs, uint rhs) => Math.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Pow(uvec3 lhs, uvec3 rhs) => uvec3.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Pow ((uint)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static uint Pow(uint lhs, uint rhs) => (uint)Math.Pow((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uvec3 Log(uvec3 lhs, uvec3 rhs) => uvec3.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Log ((uint)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static uint Log(uint lhs, uint rhs) => (uint)Math.Log((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uvec3 Clamp(uvec3 v, uvec3 min, uvec3 max) => uvec3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static uint Clamp(uint v, uint min, uint max) => Math.Min(Math.Max(v, min), max);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Mix(uvec3 min, uvec3 max, uvec3 a) => uvec3.Mix(min, max, a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static uint Mix(uint min, uint max, uint a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uvec3 Lerp(uvec3 min, uvec3 max, uvec3 a) => uvec3.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static uint Lerp(uint min, uint max, uint a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uvec3 Smoothstep(uvec3 edge0, uvec3 edge1, uvec3 v) => uvec3.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static uint Smoothstep(uint edge0, uint edge1, uint v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3();
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uvec3 Smootherstep(uvec3 edge0, uvec3 edge1, uvec3 v) => uvec3.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static uint Smootherstep(uint edge0, uint edge1, uint v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5();
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uvec3 Fma(uvec3 a, uvec3 b, uvec3 c) => uvec3.Fma(a, b, c);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static uint Fma(uint a, uint b, uint c) => a * b + c;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat2x3 OuterProduct(uvec3 c, uvec2 r) => uvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat3 OuterProduct(uvec3 c, uvec3 r) => uvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static umat4x3 OuterProduct(uvec3 c, uvec4 r) => uvec3.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uvec3 Add(uvec3 lhs, uvec3 rhs) => uvec3.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static uint Add(uint lhs, uint rhs) => lhs + rhs;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uvec3 Sub(uvec3 lhs, uvec3 rhs) => uvec3.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static uint Sub(uint lhs, uint rhs) => lhs - rhs;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uvec3 Mul(uvec3 lhs, uvec3 rhs) => uvec3.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static uint Mul(uint lhs, uint rhs) => lhs * rhs;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uvec3 Div(uvec3 lhs, uvec3 rhs) => uvec3.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static uint Div(uint lhs, uint rhs) => lhs / rhs;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uvec3 Xor(uvec3 lhs, uvec3 rhs) => uvec3.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static uint Xor(uint lhs, uint rhs) => lhs ^ rhs;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uvec3 BitwiseOr(uvec3 lhs, uvec3 rhs) => uvec3.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static uint BitwiseOr(uint lhs, uint rhs) => lhs | rhs;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uvec3 BitwiseAnd(uvec3 lhs, uvec3 rhs) => uvec3.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static uint BitwiseAnd(uint lhs, uint rhs) => lhs & rhs;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uvec3 LeftShift(uvec3 lhs, ivec3 rhs) => uvec3.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static uint LeftShift(uint lhs, int rhs) => lhs << rhs;
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uvec3 RightShift(uvec3 lhs, ivec3 rhs) => uvec3.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns a uvec3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static uint RightShift(uint lhs, int rhs) => lhs >> rhs;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static uint MinElement(uvec3 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static uint MaxElement(uvec3 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(uvec3 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(uvec3 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static uint Sum(uvec3 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(uvec3 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(uvec3 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(uvec3 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(uvec3 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(uvec3 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static uint Dot(uvec3 lhs, uvec3 rhs) => uvec3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(uvec3 lhs, uvec3 rhs) => uvec3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(uvec3 lhs, uvec3 rhs) => uvec3.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static uvec3 Cross(uvec3 l, uvec3 r) => uvec3.Cross(l, r);
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uvec3 Random(Random random, uvec3 maxValue) => uvec3.Random(random, maxValue);
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static uint Random(Random random, uint maxValue) => (uint)random.Next((int)maxValue);
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 Random(Random random, uvec3 minValue, uvec3 maxValue) => uvec3.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint Random(Random random, uint minValue, uint maxValue) => (uint)random.Next((int)minValue, (int)maxValue);
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uvec3 RandomUniform(Random random, uvec3 minValue, uvec3 maxValue) => uvec3.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a uvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static uint RandomUniform(Random random, uint minValue, uint maxValue) => (uint)random.Next((int)minValue, (int)maxValue);

    }
}
