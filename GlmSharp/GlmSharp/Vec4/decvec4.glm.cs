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
        public static swizzle_decvec4 swizzle(decvec4 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static decimal[] Values(decvec4 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<decimal> GetEnumerator(decvec4 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(decvec4 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(decvec4 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(decvec4 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(decvec4 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(decvec4 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(decvec4 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(decvec4 v, decvec4 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(decvec4 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(decvec4 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(decvec4 lhs, decvec4 rhs, decimal eps = 0.1m) => decvec4.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(decvec4 lhs, decvec4 rhs) => decvec4.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(decvec4 lhs, decvec4 rhs) => decvec4.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(decvec4 lhs, decvec4 rhs) => decvec4.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(decvec4 lhs, decvec4 rhs) => decvec4.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(decvec4 lhs, decvec4 rhs) => decvec4.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(decvec4 lhs, decvec4 rhs) => decvec4.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec4 Abs(decvec4 v) => decvec4.Abs(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec4 HermiteInterpolationOrder3(decvec4 v) => decvec4.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec4 HermiteInterpolationOrder5(decvec4 v) => decvec4.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Sqr (v * v).
        /// </summary>
        public static decvec4 Sqr(decvec4 v) => decvec4.Sqr(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static decvec4 Pow2(decvec4 v) => decvec4.Pow2(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static decvec4 Pow3(decvec4 v) => decvec4.Pow3(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec4 Step(decvec4 v) => decvec4.Step(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec4 Sqrt(decvec4 v) => decvec4.Sqrt(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec4 InverseSqrt(decvec4 v) => decvec4.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec4 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec4 Sign(decvec4 v) => decvec4.Sign(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec4 Max(decvec4 lhs, decvec4 rhs) => decvec4.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec4 Min(decvec4 lhs, decvec4 rhs) => decvec4.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec4 Pow(decvec4 lhs, decvec4 rhs) => decvec4.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec4 Log(decvec4 lhs, decvec4 rhs) => decvec4.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec4 Clamp(decvec4 v, decvec4 min, decvec4 max) => decvec4.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec4 Mix(decvec4 min, decvec4 max, decvec4 a) => decvec4.Mix(min, max, a);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec4 Lerp(decvec4 min, decvec4 max, decvec4 a) => decvec4.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec4 Smoothstep(decvec4 edge0, decvec4 edge1, decvec4 v) => decvec4.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec4 Smootherstep(decvec4 edge0, decvec4 edge1, decvec4 v) => decvec4.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec4 Fma(decvec4 a, decvec4 b, decvec4 c) => decvec4.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat2x4 OuterProduct(decvec4 c, decvec2 r) => decvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat3x4 OuterProduct(decvec4 c, decvec3 r) => decvec4.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat4 OuterProduct(decvec4 c, decvec4 r) => decvec4.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec4 Add(decvec4 lhs, decvec4 rhs) => decvec4.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec4 Sub(decvec4 lhs, decvec4 rhs) => decvec4.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec4 Mul(decvec4 lhs, decvec4 rhs) => decvec4.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec4 Div(decvec4 lhs, decvec4 rhs) => decvec4.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec4 Modulo(decvec4 lhs, decvec4 rhs) => decvec4.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec4 Degrees(decvec4 v) => decvec4.Degrees(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec4 Radians(decvec4 v) => decvec4.Radians(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec4 Acos(decvec4 v) => decvec4.Acos(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec4 Asin(decvec4 v) => decvec4.Asin(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec4 Atan(decvec4 v) => decvec4.Atan(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec4 Cos(decvec4 v) => decvec4.Cos(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec4 Cosh(decvec4 v) => decvec4.Cosh(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec4 Exp(decvec4 v) => decvec4.Exp(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec4 Log(decvec4 v) => decvec4.Log(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec4 Log2(decvec4 v) => decvec4.Log2(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec4 Log10(decvec4 v) => decvec4.Log10(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec4 Floor(decvec4 v) => decvec4.Floor(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec4 Ceiling(decvec4 v) => decvec4.Ceiling(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec4 Round(decvec4 v) => decvec4.Round(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec4 Sin(decvec4 v) => decvec4.Sin(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec4 Sinh(decvec4 v) => decvec4.Sinh(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec4 Tan(decvec4 v) => decvec4.Tan(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec4 Tanh(decvec4 v) => decvec4.Tanh(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec4 Truncate(decvec4 v) => decvec4.Truncate(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec4 Fract(decvec4 v) => decvec4.Fract(v);
        
        /// <summary>
        /// Returns a decvec4 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static decvec4 Trunc(decvec4 v) => decvec4.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static decimal MinElement(decvec4 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static decimal MaxElement(decvec4 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static decimal Length(decvec4 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static decimal LengthSqr(decvec4 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static decimal Sum(decvec4 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static decimal Norm(decvec4 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static decimal Norm1(decvec4 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static decimal Norm2(decvec4 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static decimal NormMax(decvec4 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(decvec4 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static decvec4 Normalized(decvec4 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static decvec4 NormalizedSafe(decvec4 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static decimal Dot(decvec4 lhs, decvec4 rhs) => decvec4.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static decimal Distance(decvec4 lhs, decvec4 rhs) => decvec4.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static decimal DistanceSqr(decvec4 lhs, decvec4 rhs) => decvec4.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec4 Reflect(decvec4 I, decvec4 N) => decvec4.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec4 Refract(decvec4 I, decvec4 N, decimal eta) => decvec4.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static decvec4 FaceForward(decvec4 N, decvec4 I, decvec4 Nref) => decvec4.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns a decvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec4 Random(Random random, decvec4 minValue, decvec4 maxValue) => decvec4.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a decvec4 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec4 RandomUniform(Random random, decvec4 minValue, decvec4 maxValue) => decvec4.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a decvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec4 RandomNormal(Random random, decvec4 mean, decvec4 variance) => decvec4.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a decvec4 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec4 RandomGaussian(Random random, decvec4 mean, decvec4 variance) => decvec4.RandomGaussian(random, mean, variance);

    }
}
