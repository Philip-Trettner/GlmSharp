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
        public static swizzle_ivec2 swizzle(ivec2 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static int[] Values(ivec2 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<int> GetEnumerator(ivec2 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(ivec2 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(ivec2 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(ivec2 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(ivec2 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(ivec2 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public static int Count(ivec2 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(ivec2 v, ivec2 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(ivec2 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(ivec2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(ivec2 lhs, ivec2 rhs) => ivec2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(ivec2 lhs, ivec2 rhs) => ivec2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(ivec2 lhs, ivec2 rhs) => ivec2.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(ivec2 lhs, ivec2 rhs) => ivec2.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(ivec2 lhs, ivec2 rhs) => ivec2.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(ivec2 lhs, ivec2 rhs) => ivec2.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static ivec2 Abs(ivec2 v) => ivec2.Abs(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static ivec2 HermiteInterpolationOrder3(ivec2 v) => ivec2.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static ivec2 HermiteInterpolationOrder5(ivec2 v) => ivec2.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static ivec2 Sqr(ivec2 v) => ivec2.Sqr(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static ivec2 Pow2(ivec2 v) => ivec2.Pow2(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static ivec2 Pow3(ivec2 v) => ivec2.Pow3(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static ivec2 Step(ivec2 v) => ivec2.Step(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sqrt ((int)Math.Sqrt((double)v)).
        /// </summary>
        public static ivec2 Sqrt(ivec2 v) => ivec2.Sqrt(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of InverseSqrt ((int)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static ivec2 InverseSqrt(ivec2 v) => ivec2.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(ivec2 v) => ivec2.Sign(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static ivec2 Max(ivec2 lhs, ivec2 rhs) => ivec2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static ivec2 Min(ivec2 lhs, ivec2 rhs) => ivec2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Pow ((int)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec2 Pow(ivec2 lhs, ivec2 rhs) => ivec2.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Log ((int)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec2 Log(ivec2 lhs, ivec2 rhs) => ivec2.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec2 Clamp(ivec2 v, ivec2 min, ivec2 max) => ivec2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec2 Mix(ivec2 min, ivec2 max, ivec2 a) => ivec2.Mix(min, max, a);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec2 Lerp(ivec2 min, ivec2 max, ivec2 a) => ivec2.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec2 Smoothstep(ivec2 edge0, ivec2 edge1, ivec2 v) => ivec2.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec2 Smootherstep(ivec2 edge0, ivec2 edge1, ivec2 v) => ivec2.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec2 Fma(ivec2 a, ivec2 b, ivec2 c) => ivec2.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat2 OuterProduct(ivec2 c, ivec2 r) => ivec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat3x2 OuterProduct(ivec2 c, ivec3 r) => ivec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat4x2 OuterProduct(ivec2 c, ivec4 r) => ivec2.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static ivec2 Add(ivec2 lhs, ivec2 rhs) => ivec2.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static ivec2 Sub(ivec2 lhs, ivec2 rhs) => ivec2.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static ivec2 Mul(ivec2 lhs, ivec2 rhs) => ivec2.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static ivec2 Div(ivec2 lhs, ivec2 rhs) => ivec2.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static ivec2 Xor(ivec2 lhs, ivec2 rhs) => ivec2.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static ivec2 BitwiseOr(ivec2 lhs, ivec2 rhs) => ivec2.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static ivec2 BitwiseAnd(ivec2 lhs, ivec2 rhs) => ivec2.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static ivec2 LeftShift(ivec2 lhs, ivec2 rhs) => ivec2.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static ivec2 RightShift(ivec2 lhs, ivec2 rhs) => ivec2.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static int MinElement(ivec2 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static int MaxElement(ivec2 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(ivec2 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(ivec2 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static int Sum(ivec2 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(ivec2 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(ivec2 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(ivec2 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(ivec2 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(ivec2 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static int Dot(ivec2 lhs, ivec2 rhs) => ivec2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(ivec2 lhs, ivec2 rhs) => ivec2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(ivec2 lhs, ivec2 rhs) => ivec2.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec2 Reflect(ivec2 I, ivec2 N) => ivec2.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec2 Refract(ivec2 I, ivec2 N, int eta) => ivec2.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static ivec2 FaceForward(ivec2 N, ivec2 I, ivec2 Nref) => ivec2.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static int Cross(ivec2 l, ivec2 r) => ivec2.Cross(l, r);
        
        /// <summary>
        /// Returns a ivec2 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static ivec2 Random(Random random, ivec2 maxValue) => ivec2.Random(random, maxValue);
        
        /// <summary>
        /// Returns a ivec2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec2 Random(Random random, ivec2 minValue, ivec2 maxValue) => ivec2.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a ivec2 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec2 RandomUniform(Random random, ivec2 minValue, ivec2 maxValue) => ivec2.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a ivec2 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static ivec2 RandomPoisson(Random random, dvec2 lambda) => ivec2.RandomPoisson(random, lambda);

    }
}
