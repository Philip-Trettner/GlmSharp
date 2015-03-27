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
        public static swizzle_lvec4 swizzle(lvec4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static long[] Values(lvec4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<long> GetEnumerator(lvec4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(lvec4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(lvec4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(lvec4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(lvec4 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(lvec4 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(lvec4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(lvec4 v, lvec4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(lvec4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(lvec4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(lvec4 lhs, lvec4 rhs) => lvec4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(lvec4 lhs, lvec4 rhs) => lvec4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(lvec4 lhs, lvec4 rhs) => lvec4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(lvec4 lhs, lvec4 rhs) => lvec4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(lvec4 lhs, lvec4 rhs) => lvec4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(lvec4 lhs, lvec4 rhs) => lvec4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static lvec4 Abs(lvec4 v) => lvec4.Abs(v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static lvec4 HermiteInterpolationOrder3(lvec4 v) => lvec4.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static lvec4 HermiteInterpolationOrder5(lvec4 v) => lvec4.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static lvec4 Sqr(lvec4 v) => lvec4.Sqr(v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static lvec4 Pow2(lvec4 v) => lvec4.Pow2(v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static lvec4 Pow3(lvec4 v) => lvec4.Pow3(v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static lvec4 Step(lvec4 v) => lvec4.Step(v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Sqrt ((long)Math.Sqrt((double)v)).
        /// </summary>
        public static lvec4 Sqrt(lvec4 v) => lvec4.Sqrt(v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of InverseSqrt ((long)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static lvec4 InverseSqrt(lvec4 v) => lvec4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(lvec4 v) => lvec4.Sign(v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static lvec4 Max(lvec4 lhs, lvec4 rhs) => lvec4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static lvec4 Min(lvec4 lhs, lvec4 rhs) => lvec4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Pow ((long)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Pow(lvec4 lhs, lvec4 rhs) => lvec4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Log ((long)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec4 Log(lvec4 lhs, lvec4 rhs) => lvec4.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec4 Clamp(lvec4 v, lvec4 min, lvec4 max) => lvec4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Mix(lvec4 min, lvec4 max, lvec4 a) => lvec4.Mix(min, max, a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec4 Lerp(lvec4 min, lvec4 max, lvec4 a) => lvec4.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec4 Smoothstep(lvec4 edge0, lvec4 edge1, lvec4 v) => lvec4.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec4 Smootherstep(lvec4 edge0, lvec4 edge1, lvec4 v) => lvec4.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec4 Fma(lvec4 a, lvec4 b, lvec4 c) => lvec4.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat2x4 OuterProduct(lvec4 c, lvec2 r) => lvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat3x4 OuterProduct(lvec4 c, lvec3 r) => lvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat4 OuterProduct(lvec4 c, lvec4 r) => lvec4.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static lvec4 Add(lvec4 lhs, lvec4 rhs) => lvec4.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static lvec4 Sub(lvec4 lhs, lvec4 rhs) => lvec4.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static lvec4 Mul(lvec4 lhs, lvec4 rhs) => lvec4.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static lvec4 Div(lvec4 lhs, lvec4 rhs) => lvec4.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static lvec4 Xor(lvec4 lhs, lvec4 rhs) => lvec4.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static lvec4 BitwiseOr(lvec4 lhs, lvec4 rhs) => lvec4.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static lvec4 BitwiseAnd(lvec4 lhs, lvec4 rhs) => lvec4.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static lvec4 LeftShift(lvec4 lhs, ivec4 rhs) => lvec4.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static lvec4 RightShift(lvec4 lhs, ivec4 rhs) => lvec4.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static long MinElement(lvec4 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static long MaxElement(lvec4 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(lvec4 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(lvec4 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static long Sum(lvec4 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(lvec4 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(lvec4 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(lvec4 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(lvec4 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(lvec4 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static long Dot(lvec4 lhs, lvec4 rhs) => lvec4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(lvec4 lhs, lvec4 rhs) => lvec4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(lvec4 lhs, lvec4 rhs) => lvec4.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec4 Reflect(lvec4 I, lvec4 N) => lvec4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec4 Refract(lvec4 I, lvec4 N, long eta) => lvec4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static lvec4 FaceForward(lvec4 N, lvec4 I, lvec4 Nref) => lvec4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static lvec4 Random(Random random, lvec4 maxValue) => lvec4.Random(random, maxValue);
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 Random(Random random, lvec4 minValue, lvec4 maxValue) => lvec4.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a lvec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec4 RandomUniform(Random random, lvec4 minValue, lvec4 maxValue) => lvec4.RandomUniform(random, minValue, maxValue);

    }
}
