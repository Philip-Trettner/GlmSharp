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
        public static swizzle_decvec2 swizzle(decvec2 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static decimal[] Values(decvec2 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<decimal> GetEnumerator(decvec2 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(decvec2 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(decvec2 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(decvec2 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(decvec2 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(decvec2 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (2).
        /// </summary>
        public static int Count(decvec2 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(decvec2 v, decvec2 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(decvec2 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(decvec2 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(decvec2 lhs, decvec2 rhs, decimal eps = 0.1m) => decvec2.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec2 Equal(decvec2 lhs, decvec2 rhs) => decvec2.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec2 NotEqual(decvec2 lhs, decvec2 rhs) => decvec2.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec2 GreaterThan(decvec2 lhs, decvec2 rhs) => decvec2.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec2 GreaterThanEqual(decvec2 lhs, decvec2 rhs) => decvec2.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec2 LesserThan(decvec2 lhs, decvec2 rhs) => decvec2.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec2 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec2 LesserThanEqual(decvec2 lhs, decvec2 rhs) => decvec2.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec2 Abs(decvec2 v) => decvec2.Abs(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec2 HermiteInterpolationOrder3(decvec2 v) => decvec2.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec2 HermiteInterpolationOrder5(decvec2 v) => decvec2.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sqr (v * v).
        /// </summary>
        public static decvec2 Sqr(decvec2 v) => decvec2.Sqr(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static decvec2 Pow2(decvec2 v) => decvec2.Pow2(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static decvec2 Pow3(decvec2 v) => decvec2.Pow3(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec2 Step(decvec2 v) => decvec2.Step(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec2 Sqrt(decvec2 v) => decvec2.Sqrt(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec2 InverseSqrt(decvec2 v) => decvec2.InverseSqrt(v);
        
        /// <summary>
        /// Returns a ivec2 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec2 Sign(decvec2 v) => decvec2.Sign(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec2 Max(decvec2 lhs, decvec2 rhs) => decvec2.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec2 Min(decvec2 lhs, decvec2 rhs) => decvec2.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Pow(decvec2 lhs, decvec2 rhs) => decvec2.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec2 Log(decvec2 lhs, decvec2 rhs) => decvec2.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec2 Clamp(decvec2 v, decvec2 min, decvec2 max) => decvec2.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Mix(decvec2 min, decvec2 max, decvec2 a) => decvec2.Mix(min, max, a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec2 Lerp(decvec2 min, decvec2 max, decvec2 a) => decvec2.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec2 Smoothstep(decvec2 edge0, decvec2 edge1, decvec2 v) => decvec2.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec2 Smootherstep(decvec2 edge0, decvec2 edge1, decvec2 v) => decvec2.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec2 Fma(decvec2 a, decvec2 b, decvec2 c) => decvec2.Fma(a, b, c);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat2 OuterProduct(decvec2 c, decvec2 r) => decvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat3x2 OuterProduct(decvec2 c, decvec3 r) => decvec2.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat4x2 OuterProduct(decvec2 c, decvec4 r) => decvec2.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec2 Add(decvec2 lhs, decvec2 rhs) => decvec2.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec2 Sub(decvec2 lhs, decvec2 rhs) => decvec2.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec2 Mul(decvec2 lhs, decvec2 rhs) => decvec2.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec2 Div(decvec2 lhs, decvec2 rhs) => decvec2.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec2 Modulo(decvec2 lhs, decvec2 rhs) => decvec2.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec2 Degrees(decvec2 v) => decvec2.Degrees(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec2 Radians(decvec2 v) => decvec2.Radians(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec2 Acos(decvec2 v) => decvec2.Acos(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec2 Asin(decvec2 v) => decvec2.Asin(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec2 Atan(decvec2 v) => decvec2.Atan(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec2 Cos(decvec2 v) => decvec2.Cos(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec2 Cosh(decvec2 v) => decvec2.Cosh(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec2 Exp(decvec2 v) => decvec2.Exp(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec2 Log(decvec2 v) => decvec2.Log(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec2 Log2(decvec2 v) => decvec2.Log2(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec2 Log10(decvec2 v) => decvec2.Log10(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec2 Floor(decvec2 v) => decvec2.Floor(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec2 Ceiling(decvec2 v) => decvec2.Ceiling(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec2 Round(decvec2 v) => decvec2.Round(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec2 Sin(decvec2 v) => decvec2.Sin(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec2 Sinh(decvec2 v) => decvec2.Sinh(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec2 Tan(decvec2 v) => decvec2.Tan(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec2 Tanh(decvec2 v) => decvec2.Tanh(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec2 Truncate(decvec2 v) => decvec2.Truncate(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec2 Fract(decvec2 v) => decvec2.Fract(v);
        
        /// <summary>
        /// Returns a decvec2 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static decvec2 Trunc(decvec2 v) => decvec2.Trunc(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static decimal MinElement(decvec2 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static decimal MaxElement(decvec2 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static decimal Length(decvec2 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static decimal LengthSqr(decvec2 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static decimal Sum(decvec2 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static decimal Norm(decvec2 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static decimal Norm1(decvec2 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static decimal Norm2(decvec2 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static decimal NormMax(decvec2 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(decvec2 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static decvec2 Normalized(decvec2 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static decvec2 NormalizedSafe(decvec2 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the vector angle (atan2(y, x)) in radians.
        /// </summary>
        public static double Angle(decvec2 v) => v.Angle;
        
        /// <summary>
        /// Returns a 2D vector that was rotated by a given angle in radians (CAUTION: result is casted and may be truncated).
        /// </summary>
        public static decvec2 Rotated(decvec2 v, double angleInRad) => v.Rotated(angleInRad);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static decimal Dot(decvec2 lhs, decvec2 rhs) => decvec2.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static decimal Distance(decvec2 lhs, decvec2 rhs) => decvec2.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static decimal DistanceSqr(decvec2 lhs, decvec2 rhs) => decvec2.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec2 Reflect(decvec2 I, decvec2 N) => decvec2.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec2 Refract(decvec2 I, decvec2 N, decimal eta) => decvec2.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static decvec2 FaceForward(decvec2 N, decvec2 I, decvec2 Nref) => decvec2.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the length of the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static decimal Cross(decvec2 l, decvec2 r) => decvec2.Cross(l, r);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 Random(Random random, decvec2 minValue, decvec2 maxValue) => decvec2.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec2 RandomUniform(Random random, decvec2 minValue, decvec2 maxValue) => decvec2.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomNormal(Random random, decvec2 mean, decvec2 variance) => decvec2.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a decvec2 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec2 RandomGaussian(Random random, decvec2 mean, decvec2 variance) => decvec2.RandomGaussian(random, mean, variance);

    }
}
