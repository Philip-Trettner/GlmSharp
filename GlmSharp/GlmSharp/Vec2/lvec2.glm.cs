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
        public static swizzle_lvec2 swizzle(lvec2 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static long[] Values(lvec2 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<long> GetEnumerator(lvec2 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(lvec2 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(lvec2 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(lvec2 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(lvec2 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(lvec2 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public static int Count(lvec2 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(lvec2 v, lvec2 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(lvec2 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(lvec2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(lvec2 lhs, lvec2 rhs) => lvec2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(lvec2 lhs, lvec2 rhs) => lvec2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(lvec2 lhs, lvec2 rhs) => lvec2.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(lvec2 lhs, lvec2 rhs) => lvec2.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(lvec2 lhs, lvec2 rhs) => lvec2.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(lvec2 lhs, lvec2 rhs) => lvec2.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static lvec2 Abs(lvec2 v) => lvec2.Abs(v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static lvec2 HermiteInterpolationOrder3(lvec2 v) => lvec2.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static lvec2 HermiteInterpolationOrder5(lvec2 v) => lvec2.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static lvec2 Sqr(lvec2 v) => lvec2.Sqr(v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static lvec2 Pow2(lvec2 v) => lvec2.Pow2(v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static lvec2 Pow3(lvec2 v) => lvec2.Pow3(v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static lvec2 Step(lvec2 v) => lvec2.Step(v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Sqrt ((long)Math.Sqrt((double)v)).
        /// </summary>
        public static lvec2 Sqrt(lvec2 v) => lvec2.Sqrt(v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of InverseSqrt ((long)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static lvec2 InverseSqrt(lvec2 v) => lvec2.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(lvec2 v) => lvec2.Sign(v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static lvec2 Max(lvec2 lhs, lvec2 rhs) => lvec2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static lvec2 Min(lvec2 lhs, lvec2 rhs) => lvec2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Pow ((long)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec2 Pow(lvec2 lhs, lvec2 rhs) => lvec2.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Log ((long)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static lvec2 Log(lvec2 lhs, lvec2 rhs) => lvec2.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static lvec2 Clamp(lvec2 v, lvec2 min, lvec2 max) => lvec2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static lvec2 Mix(lvec2 min, lvec2 max, lvec2 a) => lvec2.Mix(min, max, a);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lvec2 Lerp(lvec2 min, lvec2 max, lvec2 a) => lvec2.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static lvec2 Smoothstep(lvec2 edge0, lvec2 edge1, lvec2 v) => lvec2.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static lvec2 Smootherstep(lvec2 edge0, lvec2 edge1, lvec2 v) => lvec2.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static lvec2 Fma(lvec2 a, lvec2 b, lvec2 c) => lvec2.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat2 OuterProduct(lvec2 c, lvec2 r) => lvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat3x2 OuterProduct(lvec2 c, lvec3 r) => lvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static lmat4x2 OuterProduct(lvec2 c, lvec4 r) => lvec2.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static lvec2 Add(lvec2 lhs, lvec2 rhs) => lvec2.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static lvec2 Sub(lvec2 lhs, lvec2 rhs) => lvec2.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static lvec2 Mul(lvec2 lhs, lvec2 rhs) => lvec2.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static lvec2 Div(lvec2 lhs, lvec2 rhs) => lvec2.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static lvec2 Xor(lvec2 lhs, lvec2 rhs) => lvec2.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static lvec2 BitwiseOr(lvec2 lhs, lvec2 rhs) => lvec2.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static lvec2 BitwiseAnd(lvec2 lhs, lvec2 rhs) => lvec2.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static lvec2 LeftShift(lvec2 lhs, ivec2 rhs) => lvec2.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a lvec2 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static lvec2 RightShift(lvec2 lhs, ivec2 rhs) => lvec2.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static long MinElement(lvec2 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static long MaxElement(lvec2 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(lvec2 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(lvec2 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static long Sum(lvec2 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(lvec2 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(lvec2 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(lvec2 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(lvec2 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(lvec2 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static long Dot(lvec2 lhs, lvec2 rhs) => lvec2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(lvec2 lhs, lvec2 rhs) => lvec2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(lvec2 lhs, lvec2 rhs) => lvec2.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec2 Reflect(lvec2 I, lvec2 N) => lvec2.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static lvec2 Refract(lvec2 I, lvec2 N, long eta) => lvec2.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static lvec2 FaceForward(lvec2 N, lvec2 I, lvec2 Nref) => lvec2.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static long Cross(lvec2 l, lvec2 r) => lvec2.Cross(l, r);
        
        /// <summary>
        /// Returns a lvec2 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static lvec2 Random(Random random, lvec2 maxValue) => lvec2.Random(random, maxValue);
        
        /// <summary>
        /// Returns a lvec2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec2 Random(Random random, lvec2 minValue, lvec2 maxValue) => lvec2.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a lvec2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static lvec2 RandomUniform(Random random, lvec2 minValue, lvec2 maxValue) => lvec2.RandomUniform(random, minValue, maxValue);

    }
}
