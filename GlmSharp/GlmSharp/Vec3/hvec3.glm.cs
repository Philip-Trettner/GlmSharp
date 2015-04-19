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
        public static swizzle_hvec3 swizzle(hvec3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static Half[] Values(hvec3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<Half> GetEnumerator(hvec3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(hvec3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(hvec3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(hvec3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(hvec3 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(hvec3 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(hvec3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(hvec3 v, hvec3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(hvec3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(hvec3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(hvec3 lhs, hvec3 rhs, float eps = 0.1f) => hvec3.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(hvec3 lhs, hvec3 rhs) => hvec3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(Half lhs, Half rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(hvec3 lhs, hvec3 rhs) => hvec3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(Half lhs, Half rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(hvec3 lhs, hvec3 rhs) => hvec3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool GreaterThan(Half lhs, Half rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(hvec3 lhs, hvec3 rhs) => hvec3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool GreaterThanEqual(Half lhs, Half rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(hvec3 lhs, hvec3 rhs) => hvec3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool LesserThan(Half lhs, Half rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(hvec3 lhs, hvec3 rhs) => hvec3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool LesserThanEqual(Half lhs, Half rhs) => lhs <= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsInfinity (Half.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsInfinity(hvec3 v) => hvec3.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsInfinity (Half.IsInfinity(v)).
        /// </summary>
        public static bool IsInfinity(Half v) => Half.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsFinite (!Half.IsNaN(v) &amp;&amp; !Half.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsFinite(hvec3 v) => hvec3.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsFinite (!Half.IsNaN(v) &amp;&amp; !Half.IsInfinity(v)).
        /// </summary>
        public static bool IsFinite(Half v) => !Half.IsNaN(v) && !Half.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNaN (Half.IsNaN(v)).
        /// </summary>
        public static bvec3 IsNaN(hvec3 v) => hvec3.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNaN (Half.IsNaN(v)).
        /// </summary>
        public static bool IsNaN(Half v) => Half.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNegativeInfinity (Half.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec3 IsNegativeInfinity(hvec3 v) => hvec3.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNegativeInfinity (Half.IsNegativeInfinity(v)).
        /// </summary>
        public static bool IsNegativeInfinity(Half v) => Half.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsPositiveInfinity (Half.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec3 IsPositiveInfinity(hvec3 v) => hvec3.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsPositiveInfinity (Half.IsPositiveInfinity(v)).
        /// </summary>
        public static bool IsPositiveInfinity(Half v) => Half.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Abs (Half.Abs(v)).
        /// </summary>
        public static hvec3 Abs(hvec3 v) => hvec3.Abs(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Abs (Half.Abs(v)).
        /// </summary>
        public static Half Abs(Half v) => Half.Abs(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static hvec3 HermiteInterpolationOrder3(hvec3 v) => hvec3.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static Half HermiteInterpolationOrder3(Half v) => (3 - 2 * v) * v * v;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static hvec3 HermiteInterpolationOrder5(hvec3 v) => hvec3.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static Half HermiteInterpolationOrder5(Half v) => ((6 * v - 15) * v + 10) * v * v * v;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static hvec3 Sqr(hvec3 v) => hvec3.Sqr(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static Half Sqr(Half v) => v * v;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static hvec3 Pow2(hvec3 v) => hvec3.Pow2(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static Half Pow2(Half v) => v * v;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static hvec3 Pow3(hvec3 v) => hvec3.Pow3(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static Half Pow3(Half v) => v * v * v;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Step (v &gt;= Half.Zero ? Half.One : Half.Zero).
        /// </summary>
        public static hvec3 Step(hvec3 v) => hvec3.Step(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Step (v &gt;= Half.Zero ? Half.One : Half.Zero).
        /// </summary>
        public static Half Step(Half v) => v >= Half.Zero ? Half.One : Half.Zero;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sqrt ((Half)Math.Sqrt((double)v)).
        /// </summary>
        public static hvec3 Sqrt(hvec3 v) => hvec3.Sqrt(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sqrt ((Half)Math.Sqrt((double)v)).
        /// </summary>
        public static Half Sqrt(Half v) => (Half)Math.Sqrt((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of InverseSqrt ((Half)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static hvec3 InverseSqrt(hvec3 v) => hvec3.InverseSqrt(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of InverseSqrt ((Half)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static Half InverseSqrt(Half v) => (Half)(1.0 / Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(hvec3 v) => hvec3.Sign(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static int Sign(Half v) => Math.Sign(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Max (Half.Max(lhs, rhs)).
        /// </summary>
        public static hvec3 Max(hvec3 lhs, hvec3 rhs) => hvec3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Max (Half.Max(lhs, rhs)).
        /// </summary>
        public static Half Max(Half lhs, Half rhs) => Half.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Min (Half.Min(lhs, rhs)).
        /// </summary>
        public static hvec3 Min(hvec3 lhs, hvec3 rhs) => hvec3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Min (Half.Min(lhs, rhs)).
        /// </summary>
        public static Half Min(Half lhs, Half rhs) => Half.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Pow ((Half)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec3 Pow(hvec3 lhs, hvec3 rhs) => hvec3.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Pow ((Half)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static Half Pow(Half lhs, Half rhs) => (Half)Math.Pow((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Log ((Half)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static hvec3 Log(hvec3 lhs, hvec3 rhs) => hvec3.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Log ((Half)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static Half Log(Half lhs, Half rhs) => (Half)Math.Log((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static hvec3 Clamp(hvec3 v, hvec3 min, hvec3 max) => hvec3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Clamp (Half.Min(Half.Max(v, min), max)).
        /// </summary>
        public static Half Clamp(Half v, Half min, Half max) => Half.Min(Half.Max(v, min), max);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static hvec3 Mix(hvec3 min, hvec3 max, hvec3 a) => hvec3.Mix(min, max, a);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static Half Mix(Half min, Half max, Half a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hvec3 Lerp(hvec3 min, hvec3 max, hvec3 a) => hvec3.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static Half Lerp(Half min, Half max, Half a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static hvec3 Smoothstep(hvec3 edge0, hvec3 edge1, hvec3 v) => hvec3.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static Half Smoothstep(Half edge0, Half edge1, Half v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3();
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static hvec3 Smootherstep(hvec3 edge0, hvec3 edge1, hvec3 v) => hvec3.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static Half Smootherstep(Half edge0, Half edge1, Half v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5();
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static hvec3 Fma(hvec3 a, hvec3 b, hvec3 c) => hvec3.Fma(a, b, c);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static Half Fma(Half a, Half b, Half c) => a * b + c;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat2x3 OuterProduct(hvec3 c, hvec2 r) => hvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat3 OuterProduct(hvec3 c, hvec3 r) => hvec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static hmat4x3 OuterProduct(hvec3 c, hvec4 r) => hvec3.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static hvec3 Add(hvec3 lhs, hvec3 rhs) => hvec3.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static Half Add(Half lhs, Half rhs) => lhs + rhs;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static hvec3 Sub(hvec3 lhs, hvec3 rhs) => hvec3.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static Half Sub(Half lhs, Half rhs) => lhs - rhs;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static hvec3 Mul(hvec3 lhs, hvec3 rhs) => hvec3.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static Half Mul(Half lhs, Half rhs) => lhs * rhs;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static hvec3 Div(hvec3 lhs, hvec3 rhs) => hvec3.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static Half Div(Half lhs, Half rhs) => lhs / rhs;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static hvec3 Modulo(hvec3 lhs, hvec3 rhs) => hvec3.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static Half Modulo(Half lhs, Half rhs) => lhs % rhs;
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static hvec3 Degrees(hvec3 v) => hvec3.Degrees(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static Half Degrees(Half v) => (Half)(v * new Half(57.295779513082320876798154814105170332405472466564321));
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static hvec3 Radians(hvec3 v) => hvec3.Radians(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static Half Radians(Half v) => (Half)(v * new Half(0.0174532925199432957692369076848861271344287188854172));
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Acos ((Half)Math.Acos((double)v)).
        /// </summary>
        public static hvec3 Acos(hvec3 v) => hvec3.Acos(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Acos ((Half)Math.Acos((double)v)).
        /// </summary>
        public static Half Acos(Half v) => (Half)Math.Acos((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Asin ((Half)Math.Asin((double)v)).
        /// </summary>
        public static hvec3 Asin(hvec3 v) => hvec3.Asin(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Asin ((Half)Math.Asin((double)v)).
        /// </summary>
        public static Half Asin(Half v) => (Half)Math.Asin((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Atan ((Half)Math.Atan((double)v)).
        /// </summary>
        public static hvec3 Atan(hvec3 v) => hvec3.Atan(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Atan ((Half)Math.Atan((double)v)).
        /// </summary>
        public static Half Atan(Half v) => (Half)Math.Atan((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Cos ((Half)Math.Cos((double)v)).
        /// </summary>
        public static hvec3 Cos(hvec3 v) => hvec3.Cos(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Cos ((Half)Math.Cos((double)v)).
        /// </summary>
        public static Half Cos(Half v) => (Half)Math.Cos((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Cosh ((Half)Math.Cosh((double)v)).
        /// </summary>
        public static hvec3 Cosh(hvec3 v) => hvec3.Cosh(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Cosh ((Half)Math.Cosh((double)v)).
        /// </summary>
        public static Half Cosh(Half v) => (Half)Math.Cosh((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Exp ((Half)Math.Exp((double)v)).
        /// </summary>
        public static hvec3 Exp(hvec3 v) => hvec3.Exp(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Exp ((Half)Math.Exp((double)v)).
        /// </summary>
        public static Half Exp(Half v) => (Half)Math.Exp((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Log ((Half)Math.Log((double)v)).
        /// </summary>
        public static hvec3 Log(hvec3 v) => hvec3.Log(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Log ((Half)Math.Log((double)v)).
        /// </summary>
        public static Half Log(Half v) => (Half)Math.Log((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Log2 ((Half)Math.Log((double)v, 2)).
        /// </summary>
        public static hvec3 Log2(hvec3 v) => hvec3.Log2(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Log2 ((Half)Math.Log((double)v, 2)).
        /// </summary>
        public static Half Log2(Half v) => (Half)Math.Log((double)v, 2);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Log10 ((Half)Math.Log10((double)v)).
        /// </summary>
        public static hvec3 Log10(hvec3 v) => hvec3.Log10(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Log10 ((Half)Math.Log10((double)v)).
        /// </summary>
        public static Half Log10(Half v) => (Half)Math.Log10((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Floor ((Half)Math.Floor(v)).
        /// </summary>
        public static hvec3 Floor(hvec3 v) => hvec3.Floor(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Floor ((Half)Math.Floor(v)).
        /// </summary>
        public static Half Floor(Half v) => (Half)Math.Floor(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Ceiling ((Half)Math.Ceiling(v)).
        /// </summary>
        public static hvec3 Ceiling(hvec3 v) => hvec3.Ceiling(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Ceiling ((Half)Math.Ceiling(v)).
        /// </summary>
        public static Half Ceiling(Half v) => (Half)Math.Ceiling(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Round ((Half)Math.Round(v)).
        /// </summary>
        public static hvec3 Round(hvec3 v) => hvec3.Round(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Round ((Half)Math.Round(v)).
        /// </summary>
        public static Half Round(Half v) => (Half)Math.Round(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sin ((Half)Math.Sin((double)v)).
        /// </summary>
        public static hvec3 Sin(hvec3 v) => hvec3.Sin(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sin ((Half)Math.Sin((double)v)).
        /// </summary>
        public static Half Sin(Half v) => (Half)Math.Sin((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sinh ((Half)Math.Sinh((double)v)).
        /// </summary>
        public static hvec3 Sinh(hvec3 v) => hvec3.Sinh(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Sinh ((Half)Math.Sinh((double)v)).
        /// </summary>
        public static Half Sinh(Half v) => (Half)Math.Sinh((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Tan ((Half)Math.Tan((double)v)).
        /// </summary>
        public static hvec3 Tan(hvec3 v) => hvec3.Tan(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Tan ((Half)Math.Tan((double)v)).
        /// </summary>
        public static Half Tan(Half v) => (Half)Math.Tan((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Tanh ((Half)Math.Tanh((double)v)).
        /// </summary>
        public static hvec3 Tanh(hvec3 v) => hvec3.Tanh(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Tanh ((Half)Math.Tanh((double)v)).
        /// </summary>
        public static Half Tanh(Half v) => (Half)Math.Tanh((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Truncate ((Half)Math.Truncate((double)v)).
        /// </summary>
        public static hvec3 Truncate(hvec3 v) => hvec3.Truncate(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Truncate ((Half)Math.Truncate((double)v)).
        /// </summary>
        public static Half Truncate(Half v) => (Half)Math.Truncate((double)v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Fract ((Half)(v - Math.Floor(v))).
        /// </summary>
        public static hvec3 Fract(hvec3 v) => hvec3.Fract(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Fract ((Half)(v - Math.Floor(v))).
        /// </summary>
        public static Half Fract(Half v) => (Half)(v - Math.Floor(v));
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static hvec3 Trunc(hvec3 v) => hvec3.Trunc(v);
        
        /// <summary>
        /// Returns a hvec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static Half Trunc(Half v) => (long)(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static Half MinElement(hvec3 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static Half MaxElement(hvec3 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(hvec3 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(hvec3 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static Half Sum(hvec3 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(hvec3 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(hvec3 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(hvec3 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(hvec3 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(hvec3 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static hvec3 Normalized(hvec3 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static hvec3 NormalizedSafe(hvec3 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static Half Dot(hvec3 lhs, hvec3 rhs) => hvec3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(hvec3 lhs, hvec3 rhs) => hvec3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(hvec3 lhs, hvec3 rhs) => hvec3.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static hvec3 Reflect(hvec3 I, hvec3 N) => hvec3.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static hvec3 Refract(hvec3 I, hvec3 N, Half eta) => hvec3.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static hvec3 FaceForward(hvec3 N, hvec3 I, hvec3 Nref) => hvec3.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static hvec3 Cross(hvec3 l, hvec3 r) => hvec3.Cross(l, r);
        
        /// <summary>
        /// Returns a hvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec3 Random(Random random, hvec3 minValue, hvec3 maxValue) => hvec3.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a hvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static Half Random(Random random, Half minValue, Half maxValue) => (Half)random.NextDouble() * (maxValue - minValue) + minValue;
        
        /// <summary>
        /// Returns a hvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static hvec3 RandomUniform(Random random, hvec3 minValue, hvec3 maxValue) => hvec3.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a hvec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static Half RandomUniform(Random random, Half minValue, Half maxValue) => (Half)random.NextDouble() * (maxValue - minValue) + minValue;
        
        /// <summary>
        /// Returns a hvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec3 RandomNormal(Random random, hvec3 mean, hvec3 variance) => hvec3.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a hvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static Half RandomNormal(Random random, Half mean, Half variance) => (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean;
        
        /// <summary>
        /// Returns a hvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static hvec3 RandomGaussian(Random random, hvec3 mean, hvec3 variance) => hvec3.RandomGaussian(random, mean, variance);
        
        /// <summary>
        /// Returns a hvec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static Half RandomGaussian(Random random, Half mean, Half variance) => (Half)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean;

    }
}
