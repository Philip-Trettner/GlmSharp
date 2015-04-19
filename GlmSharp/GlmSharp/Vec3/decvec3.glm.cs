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
        public static swizzle_decvec3 swizzle(decvec3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static decimal[] Values(decvec3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<decimal> GetEnumerator(decvec3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(decvec3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(decvec3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(decvec3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(decvec3 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(decvec3 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(decvec3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(decvec3 v, decvec3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(decvec3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(decvec3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(decvec3 lhs, decvec3 rhs, decimal eps = 0.1m) => decvec3.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(decvec3 lhs, decvec3 rhs) => decvec3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(decimal lhs, decimal rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(decvec3 lhs, decvec3 rhs) => decvec3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(decimal lhs, decimal rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(decvec3 lhs, decvec3 rhs) => decvec3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool GreaterThan(decimal lhs, decimal rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(decvec3 lhs, decvec3 rhs) => decvec3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool GreaterThanEqual(decimal lhs, decimal rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(decvec3 lhs, decvec3 rhs) => decvec3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool LesserThan(decimal lhs, decimal rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(decvec3 lhs, decvec3 rhs) => decvec3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool LesserThanEqual(decimal lhs, decimal rhs) => lhs <= rhs;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static decvec3 Abs(decvec3 v) => decvec3.Abs(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static decimal Abs(decimal v) => Math.Abs(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decvec3 HermiteInterpolationOrder3(decvec3 v) => decvec3.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static decimal HermiteInterpolationOrder3(decimal v) => (3 - 2 * v) * v * v;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decvec3 HermiteInterpolationOrder5(decvec3 v) => decvec3.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static decimal HermiteInterpolationOrder5(decimal v) => ((6 * v - 15) * v + 10) * v * v * v;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static decvec3 Sqr(decvec3 v) => decvec3.Sqr(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static decimal Sqr(decimal v) => v * v;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static decvec3 Pow2(decvec3 v) => decvec3.Pow2(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static decimal Pow2(decimal v) => v * v;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static decvec3 Pow3(decvec3 v) => decvec3.Pow3(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static decimal Pow3(decimal v) => v * v * v;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decvec3 Step(decvec3 v) => decvec3.Step(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Step (v &gt;= 0m ? 1m : 0m).
        /// </summary>
        public static decimal Step(decimal v) => v >= 0m ? 1m : 0m;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decvec3 Sqrt(decvec3 v) => decvec3.Sqrt(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sqrt ((decimal)Math.Sqrt((double)v)).
        /// </summary>
        public static decimal Sqrt(decimal v) => (decimal)Math.Sqrt((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decvec3 InverseSqrt(decvec3 v) => decvec3.InverseSqrt(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of InverseSqrt ((decimal)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static decimal InverseSqrt(decimal v) => (decimal)(1.0 / Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(decvec3 v) => decvec3.Sign(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static int Sign(decimal v) => Math.Sign(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decvec3 Max(decvec3 lhs, decvec3 rhs) => decvec3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static decimal Max(decimal lhs, decimal rhs) => Math.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decvec3 Min(decvec3 lhs, decvec3 rhs) => decvec3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static decimal Min(decimal lhs, decimal rhs) => Math.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Pow(decvec3 lhs, decvec3 rhs) => decvec3.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Pow ((decimal)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static decimal Pow(decimal lhs, decimal rhs) => (decimal)Math.Pow((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decvec3 Log(decvec3 lhs, decvec3 rhs) => decvec3.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log ((decimal)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static decimal Log(decimal lhs, decimal rhs) => (decimal)Math.Log((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decvec3 Clamp(decvec3 v, decvec3 min, decvec3 max) => decvec3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static decimal Clamp(decimal v, decimal min, decimal max) => Math.Min(Math.Max(v, min), max);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Mix(decvec3 min, decvec3 max, decvec3 a) => decvec3.Mix(min, max, a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static decimal Mix(decimal min, decimal max, decimal a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decvec3 Lerp(decvec3 min, decvec3 max, decvec3 a) => decvec3.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decimal Lerp(decimal min, decimal max, decimal a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decvec3 Smoothstep(decvec3 edge0, decvec3 edge1, decvec3 v) => decvec3.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static decimal Smoothstep(decimal edge0, decimal edge1, decimal v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3();
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decvec3 Smootherstep(decvec3 edge0, decvec3 edge1, decvec3 v) => decvec3.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static decimal Smootherstep(decimal edge0, decimal edge1, decimal v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5();
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decvec3 Fma(decvec3 a, decvec3 b, decvec3 c) => decvec3.Fma(a, b, c);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static decimal Fma(decimal a, decimal b, decimal c) => a * b + c;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat2x3 OuterProduct(decvec3 c, decvec2 r) => decvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat3 OuterProduct(decvec3 c, decvec3 r) => decvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static decmat4x3 OuterProduct(decvec3 c, decvec4 r) => decvec3.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decvec3 Add(decvec3 lhs, decvec3 rhs) => decvec3.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static decimal Add(decimal lhs, decimal rhs) => lhs + rhs;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decvec3 Sub(decvec3 lhs, decvec3 rhs) => decvec3.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static decimal Sub(decimal lhs, decimal rhs) => lhs - rhs;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decvec3 Mul(decvec3 lhs, decvec3 rhs) => decvec3.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static decimal Mul(decimal lhs, decimal rhs) => lhs * rhs;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decvec3 Div(decvec3 lhs, decvec3 rhs) => decvec3.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static decimal Div(decimal lhs, decimal rhs) => lhs / rhs;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decvec3 Modulo(decvec3 lhs, decvec3 rhs) => decvec3.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static decimal Modulo(decimal lhs, decimal rhs) => lhs % rhs;
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decvec3 Degrees(decvec3 v) => decvec3.Degrees(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static decimal Degrees(decimal v) => (decimal)(v * 57.295779513082320876798154814105170332405472466564321m);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decvec3 Radians(decvec3 v) => decvec3.Radians(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static decimal Radians(decimal v) => (decimal)(v * 0.0174532925199432957692369076848861271344287188854172m);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decvec3 Acos(decvec3 v) => decvec3.Acos(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Acos ((decimal)Math.Acos((double)v)).
        /// </summary>
        public static decimal Acos(decimal v) => (decimal)Math.Acos((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decvec3 Asin(decvec3 v) => decvec3.Asin(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Asin ((decimal)Math.Asin((double)v)).
        /// </summary>
        public static decimal Asin(decimal v) => (decimal)Math.Asin((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decvec3 Atan(decvec3 v) => decvec3.Atan(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Atan ((decimal)Math.Atan((double)v)).
        /// </summary>
        public static decimal Atan(decimal v) => (decimal)Math.Atan((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decvec3 Cos(decvec3 v) => decvec3.Cos(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Cos ((decimal)Math.Cos((double)v)).
        /// </summary>
        public static decimal Cos(decimal v) => (decimal)Math.Cos((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decvec3 Cosh(decvec3 v) => decvec3.Cosh(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Cosh ((decimal)Math.Cosh((double)v)).
        /// </summary>
        public static decimal Cosh(decimal v) => (decimal)Math.Cosh((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decvec3 Exp(decvec3 v) => decvec3.Exp(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Exp ((decimal)Math.Exp((double)v)).
        /// </summary>
        public static decimal Exp(decimal v) => (decimal)Math.Exp((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decvec3 Log(decvec3 v) => decvec3.Log(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log ((decimal)Math.Log((double)v)).
        /// </summary>
        public static decimal Log(decimal v) => (decimal)Math.Log((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decvec3 Log2(decvec3 v) => decvec3.Log2(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log2 ((decimal)Math.Log((double)v, 2)).
        /// </summary>
        public static decimal Log2(decimal v) => (decimal)Math.Log((double)v, 2);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decvec3 Log10(decvec3 v) => decvec3.Log10(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Log10 ((decimal)Math.Log10((double)v)).
        /// </summary>
        public static decimal Log10(decimal v) => (decimal)Math.Log10((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decvec3 Floor(decvec3 v) => decvec3.Floor(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Floor ((decimal)Math.Floor(v)).
        /// </summary>
        public static decimal Floor(decimal v) => (decimal)Math.Floor(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decvec3 Ceiling(decvec3 v) => decvec3.Ceiling(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Ceiling ((decimal)Math.Ceiling(v)).
        /// </summary>
        public static decimal Ceiling(decimal v) => (decimal)Math.Ceiling(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decvec3 Round(decvec3 v) => decvec3.Round(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Round ((decimal)Math.Round(v)).
        /// </summary>
        public static decimal Round(decimal v) => (decimal)Math.Round(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decvec3 Sin(decvec3 v) => decvec3.Sin(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sin ((decimal)Math.Sin((double)v)).
        /// </summary>
        public static decimal Sin(decimal v) => (decimal)Math.Sin((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decvec3 Sinh(decvec3 v) => decvec3.Sinh(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Sinh ((decimal)Math.Sinh((double)v)).
        /// </summary>
        public static decimal Sinh(decimal v) => (decimal)Math.Sinh((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decvec3 Tan(decvec3 v) => decvec3.Tan(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Tan ((decimal)Math.Tan((double)v)).
        /// </summary>
        public static decimal Tan(decimal v) => (decimal)Math.Tan((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decvec3 Tanh(decvec3 v) => decvec3.Tanh(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Tanh ((decimal)Math.Tanh((double)v)).
        /// </summary>
        public static decimal Tanh(decimal v) => (decimal)Math.Tanh((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decvec3 Truncate(decvec3 v) => decvec3.Truncate(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Truncate ((decimal)Math.Truncate((double)v)).
        /// </summary>
        public static decimal Truncate(decimal v) => (decimal)Math.Truncate((double)v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decvec3 Fract(decvec3 v) => decvec3.Fract(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Fract ((decimal)(v - Math.Floor(v))).
        /// </summary>
        public static decimal Fract(decimal v) => (decimal)(v - Math.Floor(v));
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static decvec3 Trunc(decvec3 v) => decvec3.Trunc(v);
        
        /// <summary>
        /// Returns a decvec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static decimal Trunc(decimal v) => (long)(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static decimal MinElement(decvec3 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static decimal MaxElement(decvec3 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static decimal Length(decvec3 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static decimal LengthSqr(decvec3 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static decimal Sum(decvec3 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static decimal Norm(decvec3 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static decimal Norm1(decvec3 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static decimal Norm2(decvec3 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static decimal NormMax(decvec3 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(decvec3 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static decvec3 Normalized(decvec3 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static decvec3 NormalizedSafe(decvec3 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static decimal Dot(decvec3 lhs, decvec3 rhs) => decvec3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static decimal Distance(decvec3 lhs, decvec3 rhs) => decvec3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static decimal DistanceSqr(decvec3 lhs, decvec3 rhs) => decvec3.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec3 Reflect(decvec3 I, decvec3 N) => decvec3.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static decvec3 Refract(decvec3 I, decvec3 N, decimal eta) => decvec3.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static decvec3 FaceForward(decvec3 N, decvec3 I, decvec3 Nref) => decvec3.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static decvec3 Cross(decvec3 l, decvec3 r) => decvec3.Cross(l, r);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 Random(Random random, decvec3 minValue, decvec3 maxValue) => decvec3.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decimal Random(Random random, decimal minValue, decimal maxValue) => (decimal)random.NextDouble() * (maxValue - minValue) + minValue;
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decvec3 RandomUniform(Random random, decvec3 minValue, decvec3 maxValue) => decvec3.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static decimal RandomUniform(Random random, decimal minValue, decimal maxValue) => (decimal)random.NextDouble() * (maxValue - minValue) + minValue;
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomNormal(Random random, decvec3 mean, decvec3 variance) => decvec3.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decimal RandomNormal(Random random, decimal mean, decimal variance) => (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean;
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decvec3 RandomGaussian(Random random, decvec3 mean, decvec3 variance) => decvec3.RandomGaussian(random, mean, variance);
        
        /// <summary>
        /// Returns a decvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static decimal RandomGaussian(Random random, decimal mean, decimal variance) => (decimal)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean;

    }
}
