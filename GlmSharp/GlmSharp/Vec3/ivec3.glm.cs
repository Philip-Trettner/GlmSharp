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
        public static swizzle_ivec3 swizzle(ivec3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static int[] Values(ivec3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<int> GetEnumerator(ivec3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(ivec3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(ivec3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(ivec3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(ivec3 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(ivec3 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(ivec3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(ivec3 v, ivec3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(ivec3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(ivec3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(ivec3 lhs, ivec3 rhs) => ivec3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(int lhs, int rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(ivec3 lhs, ivec3 rhs) => ivec3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(int lhs, int rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(ivec3 lhs, ivec3 rhs) => ivec3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool GreaterThan(int lhs, int rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(ivec3 lhs, ivec3 rhs) => ivec3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool GreaterThanEqual(int lhs, int rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(ivec3 lhs, ivec3 rhs) => ivec3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool LesserThan(int lhs, int rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(ivec3 lhs, ivec3 rhs) => ivec3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool LesserThanEqual(int lhs, int rhs) => lhs <= rhs;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static ivec3 Abs(ivec3 v) => ivec3.Abs(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static int Abs(int v) => Math.Abs(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static ivec3 HermiteInterpolationOrder3(ivec3 v) => ivec3.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static int HermiteInterpolationOrder3(int v) => (3 - 2 * v) * v * v;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static ivec3 HermiteInterpolationOrder5(ivec3 v) => ivec3.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static int HermiteInterpolationOrder5(int v) => ((6 * v - 15) * v + 10) * v * v * v;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static ivec3 Sqr(ivec3 v) => ivec3.Sqr(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static int Sqr(int v) => v * v;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static ivec3 Pow2(ivec3 v) => ivec3.Pow2(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static int Pow2(int v) => v * v;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static ivec3 Pow3(ivec3 v) => ivec3.Pow3(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static int Pow3(int v) => v * v * v;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static ivec3 Step(ivec3 v) => ivec3.Step(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Step (v &gt;= 0 ? 1 : 0).
        /// </summary>
        public static int Step(int v) => v >= 0 ? 1 : 0;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sqrt ((int)Math.Sqrt((double)v)).
        /// </summary>
        public static ivec3 Sqrt(ivec3 v) => ivec3.Sqrt(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sqrt ((int)Math.Sqrt((double)v)).
        /// </summary>
        public static int Sqrt(int v) => (int)Math.Sqrt((double)v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of InverseSqrt ((int)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static ivec3 InverseSqrt(ivec3 v) => ivec3.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of InverseSqrt ((int)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static int InverseSqrt(int v) => (int)(1.0 / Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(ivec3 v) => ivec3.Sign(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static int Sign(int v) => Math.Sign(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static ivec3 Max(ivec3 lhs, ivec3 rhs) => ivec3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static int Max(int lhs, int rhs) => Math.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static ivec3 Min(ivec3 lhs, ivec3 rhs) => ivec3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static int Min(int lhs, int rhs) => Math.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Pow ((int)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec3 Pow(ivec3 lhs, ivec3 rhs) => ivec3.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Pow ((int)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static int Pow(int lhs, int rhs) => (int)Math.Pow((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Log ((int)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static ivec3 Log(ivec3 lhs, ivec3 rhs) => ivec3.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Log ((int)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static int Log(int lhs, int rhs) => (int)Math.Log((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static ivec3 Clamp(ivec3 v, ivec3 min, ivec3 max) => ivec3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static int Clamp(int v, int min, int max) => Math.Min(Math.Max(v, min), max);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static ivec3 Mix(ivec3 min, ivec3 max, ivec3 a) => ivec3.Mix(min, max, a);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static int Mix(int min, int max, int a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static ivec3 Lerp(ivec3 min, ivec3 max, ivec3 a) => ivec3.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static int Lerp(int min, int max, int a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static ivec3 Smoothstep(ivec3 edge0, ivec3 edge1, ivec3 v) => ivec3.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static int Smoothstep(int edge0, int edge1, int v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3();
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static ivec3 Smootherstep(ivec3 edge0, ivec3 edge1, ivec3 v) => ivec3.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static int Smootherstep(int edge0, int edge1, int v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5();
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static ivec3 Fma(ivec3 a, ivec3 b, ivec3 c) => ivec3.Fma(a, b, c);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static int Fma(int a, int b, int c) => a * b + c;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat2x3 OuterProduct(ivec3 c, ivec2 r) => ivec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat3 OuterProduct(ivec3 c, ivec3 r) => ivec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static imat4x3 OuterProduct(ivec3 c, ivec4 r) => ivec3.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static ivec3 Add(ivec3 lhs, ivec3 rhs) => ivec3.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static int Add(int lhs, int rhs) => lhs + rhs;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static ivec3 Sub(ivec3 lhs, ivec3 rhs) => ivec3.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static int Sub(int lhs, int rhs) => lhs - rhs;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static ivec3 Mul(ivec3 lhs, ivec3 rhs) => ivec3.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static int Mul(int lhs, int rhs) => lhs * rhs;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static ivec3 Div(ivec3 lhs, ivec3 rhs) => ivec3.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static int Div(int lhs, int rhs) => lhs / rhs;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static ivec3 Xor(ivec3 lhs, ivec3 rhs) => ivec3.Xor(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Xor (lhs ^ rhs).
        /// </summary>
        public static int Xor(int lhs, int rhs) => lhs ^ rhs;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static ivec3 BitwiseOr(ivec3 lhs, ivec3 rhs) => ivec3.BitwiseOr(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of BitwiseOr (lhs | rhs).
        /// </summary>
        public static int BitwiseOr(int lhs, int rhs) => lhs | rhs;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static ivec3 BitwiseAnd(ivec3 lhs, ivec3 rhs) => ivec3.BitwiseAnd(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of BitwiseAnd (lhs &amp; rhs).
        /// </summary>
        public static int BitwiseAnd(int lhs, int rhs) => lhs & rhs;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static ivec3 LeftShift(ivec3 lhs, ivec3 rhs) => ivec3.LeftShift(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of LeftShift (lhs &lt;&lt; rhs).
        /// </summary>
        public static int LeftShift(int lhs, int rhs) => lhs << rhs;
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static ivec3 RightShift(ivec3 lhs, ivec3 rhs) => ivec3.RightShift(lhs, rhs);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of RightShift (lhs &gt;&gt; rhs).
        /// </summary>
        public static int RightShift(int lhs, int rhs) => lhs >> rhs;
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static int MinElement(ivec3 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static int MaxElement(ivec3 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(ivec3 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(ivec3 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static int Sum(ivec3 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(ivec3 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(ivec3 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(ivec3 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(ivec3 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(ivec3 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static int Dot(ivec3 lhs, ivec3 rhs) => ivec3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(ivec3 lhs, ivec3 rhs) => ivec3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(ivec3 lhs, ivec3 rhs) => ivec3.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec3 Reflect(ivec3 I, ivec3 N) => ivec3.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static ivec3 Refract(ivec3 I, ivec3 N, int eta) => ivec3.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static ivec3 FaceForward(ivec3 N, ivec3 I, ivec3 Nref) => ivec3.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static ivec3 Cross(ivec3 l, ivec3 r) => ivec3.Cross(l, r);
        
        /// <summary>
        /// Returns a ivec3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static ivec3 Random(Random random, ivec3 maxValue) => ivec3.Random(random, maxValue);
        
        /// <summary>
        /// Returns a ivec3 with independent and identically distributed uniform integer values between 0 (inclusive) and maxValue (exclusive). (A maxValue of 0 is allowed and returns 0.)
        /// </summary>
        public static int Random(Random random, int maxValue) => (int)random.Next((int)maxValue);
        
        /// <summary>
        /// Returns a ivec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec3 Random(Random random, ivec3 minValue, ivec3 maxValue) => ivec3.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a ivec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int Random(Random random, int minValue, int maxValue) => (int)random.Next((int)minValue, (int)maxValue);
        
        /// <summary>
        /// Returns a ivec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static ivec3 RandomUniform(Random random, ivec3 minValue, ivec3 maxValue) => ivec3.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a ivec3 with independent and identically distributed uniform integer values between minValue (inclusive) and maxValue (exclusive). (minValue == maxValue is allowed and returns minValue. Negative values are allowed.)
        /// </summary>
        public static int RandomUniform(Random random, int minValue, int maxValue) => (int)random.Next((int)minValue, (int)maxValue);
        
        /// <summary>
        /// Returns a ivec3 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static ivec3 RandomPoisson(Random random, dvec3 lambda) => ivec3.RandomPoisson(random, lambda);
        
        /// <summary>
        /// Returns a ivec3 with independent and identically distributed integer values according to a poisson distribution with given lambda parameter.
        /// </summary>
        public static int RandomPoisson(Random random, double lambda) => (int)lambda.GetPoisson(random);

    }
}
