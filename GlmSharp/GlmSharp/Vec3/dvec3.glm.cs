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
        public static swizzle_dvec3 swizzle(dvec3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static double[] Values(dvec3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<double> GetEnumerator(dvec3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(dvec3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(dvec3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(dvec3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(dvec3 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(dvec3 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(dvec3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(dvec3 v, dvec3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(dvec3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(dvec3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(dvec3 lhs, dvec3 rhs, double eps = 0.1d) => dvec3.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(dvec3 lhs, dvec3 rhs) => dvec3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(double lhs, double rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(dvec3 lhs, dvec3 rhs) => dvec3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(double lhs, double rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(dvec3 lhs, dvec3 rhs) => dvec3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool GreaterThan(double lhs, double rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(dvec3 lhs, dvec3 rhs) => dvec3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool GreaterThanEqual(double lhs, double rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(dvec3 lhs, dvec3 rhs) => dvec3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool LesserThan(double lhs, double rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(dvec3 lhs, dvec3 rhs) => dvec3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool LesserThanEqual(double lhs, double rhs) => lhs <= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsInfinity(dvec3 v) => dvec3.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bool IsInfinity(double v) => double.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsFinite(dvec3 v) => dvec3.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bool IsFinite(double v) => !double.IsNaN(v) && !double.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec3 IsNaN(dvec3 v) => dvec3.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bool IsNaN(double v) => double.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec3 IsNegativeInfinity(dvec3 v) => dvec3.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bool IsNegativeInfinity(double v) => double.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec3 IsPositiveInfinity(dvec3 v) => dvec3.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bool IsPositiveInfinity(double v) => double.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static dvec3 Abs(dvec3 v) => dvec3.Abs(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static double Abs(double v) => Math.Abs(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static dvec3 HermiteInterpolationOrder3(dvec3 v) => dvec3.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static double HermiteInterpolationOrder3(double v) => (3 - 2 * v) * v * v;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static dvec3 HermiteInterpolationOrder5(dvec3 v) => dvec3.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static double HermiteInterpolationOrder5(double v) => ((6 * v - 15) * v + 10) * v * v * v;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static dvec3 Sqr(dvec3 v) => dvec3.Sqr(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static double Sqr(double v) => v * v;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static dvec3 Pow2(dvec3 v) => dvec3.Pow2(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static double Pow2(double v) => v * v;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static dvec3 Pow3(dvec3 v) => dvec3.Pow3(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static double Pow3(double v) => v * v * v;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static dvec3 Step(dvec3 v) => dvec3.Step(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Step (v &gt;= 0.0 ? 1.0 : 0.0).
        /// </summary>
        public static double Step(double v) => v >= 0.0 ? 1.0 : 0.0;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static dvec3 Sqrt(dvec3 v) => dvec3.Sqrt(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sqrt ((double)Math.Sqrt((double)v)).
        /// </summary>
        public static double Sqrt(double v) => (double)Math.Sqrt((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static dvec3 InverseSqrt(dvec3 v) => dvec3.InverseSqrt(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of InverseSqrt ((double)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static double InverseSqrt(double v) => (double)(1.0 / Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(dvec3 v) => dvec3.Sign(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static int Sign(double v) => Math.Sign(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static dvec3 Max(dvec3 lhs, dvec3 rhs) => dvec3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static double Max(double lhs, double rhs) => Math.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static dvec3 Min(dvec3 lhs, dvec3 rhs) => dvec3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static double Min(double lhs, double rhs) => Math.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec3 Pow(dvec3 lhs, dvec3 rhs) => dvec3.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Pow ((double)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static double Pow(double lhs, double rhs) => (double)Math.Pow((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static dvec3 Log(dvec3 lhs, dvec3 rhs) => dvec3.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Log ((double)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static double Log(double lhs, double rhs) => (double)Math.Log((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static dvec3 Clamp(dvec3 v, dvec3 min, dvec3 max) => dvec3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static double Clamp(double v, double min, double max) => Math.Min(Math.Max(v, min), max);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static dvec3 Mix(dvec3 min, dvec3 max, dvec3 a) => dvec3.Mix(min, max, a);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static double Mix(double min, double max, double a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dvec3 Lerp(dvec3 min, dvec3 max, dvec3 a) => dvec3.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static double Lerp(double min, double max, double a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static dvec3 Smoothstep(dvec3 edge0, dvec3 edge1, dvec3 v) => dvec3.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static double Smoothstep(double edge0, double edge1, double v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3();
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static dvec3 Smootherstep(dvec3 edge0, dvec3 edge1, dvec3 v) => dvec3.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static double Smootherstep(double edge0, double edge1, double v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5();
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static dvec3 Fma(dvec3 a, dvec3 b, dvec3 c) => dvec3.Fma(a, b, c);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static double Fma(double a, double b, double c) => a * b + c;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat2x3 OuterProduct(dvec3 c, dvec2 r) => dvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat3 OuterProduct(dvec3 c, dvec3 r) => dvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static dmat4x3 OuterProduct(dvec3 c, dvec4 r) => dvec3.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static dvec3 Add(dvec3 lhs, dvec3 rhs) => dvec3.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static double Add(double lhs, double rhs) => lhs + rhs;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static dvec3 Sub(dvec3 lhs, dvec3 rhs) => dvec3.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static double Sub(double lhs, double rhs) => lhs - rhs;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static dvec3 Mul(dvec3 lhs, dvec3 rhs) => dvec3.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static double Mul(double lhs, double rhs) => lhs * rhs;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static dvec3 Div(dvec3 lhs, dvec3 rhs) => dvec3.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static double Div(double lhs, double rhs) => lhs / rhs;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static dvec3 Modulo(dvec3 lhs, dvec3 rhs) => dvec3.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static double Modulo(double lhs, double rhs) => lhs % rhs;
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static dvec3 Degrees(dvec3 v) => dvec3.Degrees(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static double Degrees(double v) => (double)(v * 57.295779513082320876798154814105170332405472466564321d);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static dvec3 Radians(dvec3 v) => dvec3.Radians(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static double Radians(double v) => (double)(v * 0.0174532925199432957692369076848861271344287188854172d);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static dvec3 Acos(dvec3 v) => dvec3.Acos(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Acos ((double)Math.Acos((double)v)).
        /// </summary>
        public static double Acos(double v) => (double)Math.Acos((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static dvec3 Asin(dvec3 v) => dvec3.Asin(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Asin ((double)Math.Asin((double)v)).
        /// </summary>
        public static double Asin(double v) => (double)Math.Asin((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static dvec3 Atan(dvec3 v) => dvec3.Atan(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Atan ((double)Math.Atan((double)v)).
        /// </summary>
        public static double Atan(double v) => (double)Math.Atan((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static dvec3 Cos(dvec3 v) => dvec3.Cos(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Cos ((double)Math.Cos((double)v)).
        /// </summary>
        public static double Cos(double v) => (double)Math.Cos((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static dvec3 Cosh(dvec3 v) => dvec3.Cosh(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Cosh ((double)Math.Cosh((double)v)).
        /// </summary>
        public static double Cosh(double v) => (double)Math.Cosh((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static dvec3 Exp(dvec3 v) => dvec3.Exp(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Exp ((double)Math.Exp((double)v)).
        /// </summary>
        public static double Exp(double v) => (double)Math.Exp((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static dvec3 Log(dvec3 v) => dvec3.Log(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Log ((double)Math.Log((double)v)).
        /// </summary>
        public static double Log(double v) => (double)Math.Log((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static dvec3 Log2(dvec3 v) => dvec3.Log2(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Log2 ((double)Math.Log((double)v, 2)).
        /// </summary>
        public static double Log2(double v) => (double)Math.Log((double)v, 2);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static dvec3 Log10(dvec3 v) => dvec3.Log10(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Log10 ((double)Math.Log10((double)v)).
        /// </summary>
        public static double Log10(double v) => (double)Math.Log10((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static dvec3 Floor(dvec3 v) => dvec3.Floor(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Floor ((double)Math.Floor(v)).
        /// </summary>
        public static double Floor(double v) => (double)Math.Floor(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static dvec3 Ceiling(dvec3 v) => dvec3.Ceiling(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Ceiling ((double)Math.Ceiling(v)).
        /// </summary>
        public static double Ceiling(double v) => (double)Math.Ceiling(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Round ((double)Math.Round(v)).
        /// </summary>
        public static dvec3 Round(dvec3 v) => dvec3.Round(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Round ((double)Math.Round(v)).
        /// </summary>
        public static double Round(double v) => (double)Math.Round(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static dvec3 Sin(dvec3 v) => dvec3.Sin(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sin ((double)Math.Sin((double)v)).
        /// </summary>
        public static double Sin(double v) => (double)Math.Sin((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static dvec3 Sinh(dvec3 v) => dvec3.Sinh(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Sinh ((double)Math.Sinh((double)v)).
        /// </summary>
        public static double Sinh(double v) => (double)Math.Sinh((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static dvec3 Tan(dvec3 v) => dvec3.Tan(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Tan ((double)Math.Tan((double)v)).
        /// </summary>
        public static double Tan(double v) => (double)Math.Tan((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static dvec3 Tanh(dvec3 v) => dvec3.Tanh(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Tanh ((double)Math.Tanh((double)v)).
        /// </summary>
        public static double Tanh(double v) => (double)Math.Tanh((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static dvec3 Truncate(dvec3 v) => dvec3.Truncate(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Truncate ((double)Math.Truncate((double)v)).
        /// </summary>
        public static double Truncate(double v) => (double)Math.Truncate((double)v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static dvec3 Fract(dvec3 v) => dvec3.Fract(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Fract ((double)(v - Math.Floor(v))).
        /// </summary>
        public static double Fract(double v) => (double)(v - Math.Floor(v));
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static dvec3 Trunc(dvec3 v) => dvec3.Trunc(v);
        
        /// <summary>
        /// Returns a dvec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static double Trunc(double v) => (long)(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static double MinElement(dvec3 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static double MaxElement(dvec3 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static double Length(dvec3 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static double LengthSqr(dvec3 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static double Sum(dvec3 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static double Norm(dvec3 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static double Norm1(dvec3 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static double Norm2(dvec3 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static double NormMax(dvec3 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(dvec3 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static dvec3 Normalized(dvec3 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static dvec3 NormalizedSafe(dvec3 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static double Dot(dvec3 lhs, dvec3 rhs) => dvec3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static double Distance(dvec3 lhs, dvec3 rhs) => dvec3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static double DistanceSqr(dvec3 lhs, dvec3 rhs) => dvec3.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec3 Reflect(dvec3 I, dvec3 N) => dvec3.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static dvec3 Refract(dvec3 I, dvec3 N, double eta) => dvec3.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static dvec3 FaceForward(dvec3 N, dvec3 I, dvec3 Nref) => dvec3.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static dvec3 Cross(dvec3 l, dvec3 r) => dvec3.Cross(l, r);
        
        /// <summary>
        /// Returns a dvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec3 Random(Random random, dvec3 minValue, dvec3 maxValue) => dvec3.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a dvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double Random(Random random, double minValue, double maxValue) => (double)random.NextDouble() * (maxValue - minValue) + minValue;
        
        /// <summary>
        /// Returns a dvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static dvec3 RandomUniform(Random random, dvec3 minValue, dvec3 maxValue) => dvec3.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a dvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static double RandomUniform(Random random, double minValue, double maxValue) => (double)random.NextDouble() * (maxValue - minValue) + minValue;
        
        /// <summary>
        /// Returns a dvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec3 RandomNormal(Random random, dvec3 mean, dvec3 variance) => dvec3.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a dvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double RandomNormal(Random random, double mean, double variance) => (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean;
        
        /// <summary>
        /// Returns a dvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static dvec3 RandomGaussian(Random random, dvec3 mean, dvec3 variance) => dvec3.RandomGaussian(random, mean, variance);
        
        /// <summary>
        /// Returns a dvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static double RandomGaussian(Random random, double mean, double variance) => (double)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean;

    }
}
