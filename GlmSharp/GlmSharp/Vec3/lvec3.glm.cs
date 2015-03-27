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
        public static swizzle_lvec3 swizzle(lvec3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static long[] Values(lvec3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<long> GetEnumerator(lvec3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(lvec3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(lvec3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(lvec3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(lvec3 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(lvec3 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(lvec3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(lvec3 v, lvec3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(lvec3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(lvec3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(lvec3 lhs, lvec3 rhs) => lvec3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(long lhs, long rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(lvec3 lhs, lvec3 rhs) => lvec3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(long lhs, long rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(lvec3 lhs, lvec3 rhs) => lvec3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool GreaterThan(long lhs, long rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(lvec3 lhs, lvec3 rhs) => lvec3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool GreaterThanEqual(long lhs, long rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(lvec3 lhs, lvec3 rhs) => lvec3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool LesserThan(long lhs, long rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(lvec3 lhs, lvec3 rhs) => lvec3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool LesserThanEqual(long lhs, long rhs) => lhs <= rhs;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static lvec3 Abs(lvec3 v) => lvec3.Abs(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static long Abs(long v) => Math.Abs(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static lvec3 HermiteInterpolationOrder3(lvec3 v) => lvec3.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static long HermiteInterpolationOrder3(long v) => (3 - 2 * v) * v * v;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static lvec3 HermiteInterpolationOrder5(lvec3 v) => lvec3.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static long HermiteInterpolationOrder5(long v) => ((6 * v - 15) * v + 10) * v * v * v;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static lvec3 Sqr(lvec3 v) => lvec3.Sqr(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static long Sqr(long v) => v * v;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static lvec3 Pow2(lvec3 v) => lvec3.Pow2(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static long Pow2(long v) => v * v;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static lvec3 Pow3(lvec3 v) => lvec3.Pow3(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static long Pow3(long v) => v * v * v;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static lvec3 Step(lvec3 v) => lvec3.Step(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static long Step(long v) => v >= 0 ? 1 : 0;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Sqrt ((long)Math.Sqrt((double)v)).
        /// </summary>
        public static lvec3 Sqrt(lvec3 v) => lvec3.Sqrt(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Sqrt ((long)Math.Sqrt((double)v)).
        /// </summary>
        public static long Sqrt(long v) => (long)Math.Sqrt((double)v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of InverseSqrt ((long)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static lvec3 InverseSqrt(lvec3 v) => lvec3.InverseSqrt(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of InverseSqrt ((long)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static long InverseSqrt(long v) => (long)(1.0 / Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(lvec3 v) => lvec3.Sign(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static int Sign(long v) => Math.Sign(v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static lvec3 Max(lvec3 lhs, lvec3 rhs) => lvec3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static long Max(long lhs, long rhs) => Math.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static lvec3 Min(lvec3 lhs, lvec3 rhs) => lvec3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static long Min(long lhs, long rhs) => Math.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Pow ((long)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec3 Pow(lvec3 lhs, lvec3 rhs) => lvec3.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Pow ((long)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static long Pow(long lhs, long rhs) => (long)Math.Pow((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Log ((long)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec3 Log(lvec3 lhs, lvec3 rhs) => lvec3.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Log ((long)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static long Log(long lhs, long rhs) => (long)Math.Log((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec3 Clamp(lvec3 v, lvec3 min, lvec3 max) => lvec3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static long Clamp(long v, long min, long max) => Math.Min(Math.Max(v, min), max);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec3 Mix(lvec3 min, lvec3 max, lvec3 a) => lvec3.Mix(min, max, a);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static long Mix(long min, long max, long a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec3 Lerp(lvec3 min, lvec3 max, lvec3 a) => lvec3.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static long Lerp(long min, long max, long a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec3 Smoothstep(lvec3 edge0, lvec3 edge1, lvec3 v) => lvec3.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static long Smoothstep(long edge0, long edge1, long v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3();
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec3 Smootherstep(lvec3 edge0, lvec3 edge1, lvec3 v) => lvec3.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static long Smootherstep(long edge0, long edge1, long v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5();
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec3 Fma(lvec3 a, lvec3 b, lvec3 c) => lvec3.Fma(a, b, c);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static long Fma(long a, long b, long c) => a * b + c;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat2x3 OuterProduct(lvec3 c, lvec2 r) => lvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat3 OuterProduct(lvec3 c, lvec3 r) => lvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat4x3 OuterProduct(lvec3 c, lvec4 r) => lvec3.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static lvec3 Add(lvec3 lhs, lvec3 rhs) => lvec3.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static long Add(long lhs, long rhs) => lhs + rhs;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static lvec3 Sub(lvec3 lhs, lvec3 rhs) => lvec3.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static long Sub(long lhs, long rhs) => lhs - rhs;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static lvec3 Mul(lvec3 lhs, lvec3 rhs) => lvec3.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static long Mul(long lhs, long rhs) => lhs * rhs;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static lvec3 Div(lvec3 lhs, lvec3 rhs) => lvec3.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static long Div(long lhs, long rhs) => lhs / rhs;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static lvec3 Xor(lvec3 lhs, lvec3 rhs) => lvec3.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static long Xor(long lhs, long rhs) => lhs ^ rhs;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static lvec3 BitwiseOr(lvec3 lhs, lvec3 rhs) => lvec3.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static long BitwiseOr(long lhs, long rhs) => lhs | rhs;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static lvec3 BitwiseAnd(lvec3 lhs, lvec3 rhs) => lvec3.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static long BitwiseAnd(long lhs, long rhs) => lhs & rhs;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static lvec3 LeftShift(lvec3 lhs, ivec3 rhs) => lvec3.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static long LeftShift(long lhs, int rhs) => lhs << rhs;
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static lvec3 RightShift(lvec3 lhs, ivec3 rhs) => lvec3.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static long RightShift(long lhs, int rhs) => lhs >> rhs;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static long MinElement(lvec3 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static long MaxElement(lvec3 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(lvec3 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(lvec3 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static long Sum(lvec3 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(lvec3 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(lvec3 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(lvec3 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(lvec3 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(lvec3 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static long Dot(lvec3 lhs, lvec3 rhs) => lvec3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(lvec3 lhs, lvec3 rhs) => lvec3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(lvec3 lhs, lvec3 rhs) => lvec3.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec3 Reflect(lvec3 I, lvec3 N) => lvec3.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec3 Refract(lvec3 I, lvec3 N, long eta) => lvec3.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static lvec3 FaceForward(lvec3 N, lvec3 I, lvec3 Nref) => lvec3.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static lvec3 Cross(lvec3 l, lvec3 r) => lvec3.Cross(l, r);
        
        /// <summary>
        /// Returns a lvec3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static lvec3 Random(Random random, lvec3 maxValue) => lvec3.Random(random, maxValue);
        
        /// <summary>
        /// Returns a lvec3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static long Random(Random random, long maxValue) => (long)random.Next((int)maxValue);
        
        /// <summary>
        /// Returns a lvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec3 Random(Random random, lvec3 minValue, lvec3 maxValue) => lvec3.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a lvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long Random(Random random, long minValue, long maxValue) => (long)random.Next((int)minValue, (int)maxValue);
        
        /// <summary>
        /// Returns a lvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec3 RandomUniform(Random random, lvec3 minValue, lvec3 maxValue) => lvec3.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a lvec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static long RandomUniform(Random random, long minValue, long maxValue) => (long)random.Next((int)minValue, (int)maxValue);

    }
}
