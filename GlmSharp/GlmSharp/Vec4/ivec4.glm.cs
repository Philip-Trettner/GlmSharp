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
        public static swizzle_ivec4 swizzle(ivec4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static int[] Values(ivec4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<int> GetEnumerator(ivec4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(ivec4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(ivec4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(ivec4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(ivec4 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(ivec4 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(ivec4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(ivec4 v, ivec4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(ivec4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(ivec4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(ivec4 lhs, ivec4 rhs) => ivec4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(ivec4 lhs, ivec4 rhs) => ivec4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(ivec4 lhs, ivec4 rhs) => ivec4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(ivec4 lhs, ivec4 rhs) => ivec4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(ivec4 lhs, ivec4 rhs) => ivec4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(ivec4 lhs, ivec4 rhs) => ivec4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static ivec4 Abs(ivec4 v) => ivec4.Abs(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static ivec4 HermiteInterpolationOrder3(ivec4 v) => ivec4.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static ivec4 HermiteInterpolationOrder5(ivec4 v) => ivec4.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static ivec4 Sqr(ivec4 v) => ivec4.Sqr(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static ivec4 Pow2(ivec4 v) => ivec4.Pow2(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static ivec4 Pow3(ivec4 v) => ivec4.Pow3(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static ivec4 Step(ivec4 v) => ivec4.Step(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sqrt ((int)Math.Sqrt((double)v)).
        /// </summary>
        public static ivec4 Sqrt(ivec4 v) => ivec4.Sqrt(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of InverseSqrt ((int)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static ivec4 InverseSqrt(ivec4 v) => ivec4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(ivec4 v) => ivec4.Sign(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static ivec4 Max(ivec4 lhs, ivec4 rhs) => ivec4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static ivec4 Min(ivec4 lhs, ivec4 rhs) => ivec4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Pow ((int)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec4 Pow(ivec4 lhs, ivec4 rhs) => ivec4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Log ((int)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec4 Log(ivec4 lhs, ivec4 rhs) => ivec4.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec4 Clamp(ivec4 v, ivec4 min, ivec4 max) => ivec4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec4 Mix(ivec4 min, ivec4 max, ivec4 a) => ivec4.Mix(min, max, a);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec4 Lerp(ivec4 min, ivec4 max, ivec4 a) => ivec4.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec4 Smoothstep(ivec4 edge0, ivec4 edge1, ivec4 v) => ivec4.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec4 Smootherstep(ivec4 edge0, ivec4 edge1, ivec4 v) => ivec4.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec4 Fma(ivec4 a, ivec4 b, ivec4 c) => ivec4.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat2x4 OuterProduct(ivec4 c, ivec2 r) => ivec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat3x4 OuterProduct(ivec4 c, ivec3 r) => ivec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat4 OuterProduct(ivec4 c, ivec4 r) => ivec4.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static ivec4 Add(ivec4 lhs, ivec4 rhs) => ivec4.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static ivec4 Sub(ivec4 lhs, ivec4 rhs) => ivec4.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static ivec4 Mul(ivec4 lhs, ivec4 rhs) => ivec4.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static ivec4 Div(ivec4 lhs, ivec4 rhs) => ivec4.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static ivec4 Xor(ivec4 lhs, ivec4 rhs) => ivec4.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static ivec4 BitwiseOr(ivec4 lhs, ivec4 rhs) => ivec4.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static ivec4 BitwiseAnd(ivec4 lhs, ivec4 rhs) => ivec4.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static ivec4 LeftShift(ivec4 lhs, ivec4 rhs) => ivec4.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static ivec4 RightShift(ivec4 lhs, ivec4 rhs) => ivec4.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static int MinElement(ivec4 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static int MaxElement(ivec4 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(ivec4 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(ivec4 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static int Sum(ivec4 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(ivec4 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(ivec4 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(ivec4 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(ivec4 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(ivec4 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static int Dot(ivec4 lhs, ivec4 rhs) => ivec4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(ivec4 lhs, ivec4 rhs) => ivec4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(ivec4 lhs, ivec4 rhs) => ivec4.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec4 Reflect(ivec4 I, ivec4 N) => ivec4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec4 Refract(ivec4 I, ivec4 N, int eta) => ivec4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static ivec4 FaceForward(ivec4 N, ivec4 I, ivec4 Nref) => ivec4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a ivec4 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static ivec4 Random(Random random, ivec4 maxValue) => ivec4.Random(random, maxValue);
        
        /// <summary>
        /// Returns a ivec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec4 Random(Random random, ivec4 minValue, ivec4 maxValue) => ivec4.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a ivec4 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec4 RandomUniform(Random random, ivec4 minValue, ivec4 maxValue) => ivec4.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a ivec4 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static ivec4 RandomPoisson(Random random, dvec4 lambda) => ivec4.RandomPoisson(random, lambda);

    }
}
