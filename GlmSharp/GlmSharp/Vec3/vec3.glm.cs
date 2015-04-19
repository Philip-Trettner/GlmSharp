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
        public static swizzle_vec3 swizzle(vec3 v) => v.swizzle;
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public static float[] Values(vec3 v) => v.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<float> GetEnumerator(vec3 v) => v.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this vector using ', ' as a seperator.
        /// </summary>
        public static string ToString(vec3 v) => v.ToString();
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator.
        /// </summary>
        public static string ToString(vec3 v, string sep) => v.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(vec3 v, string sep, IFormatProvider provider) => v.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(vec3 v, string sep, string format) => v.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this vector using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(vec3 v, string sep, string format, IFormatProvider provider) => v.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (3).
        /// </summary>
        public static int Count(vec3 v) => v.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(vec3 v, vec3 rhs) => v.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(vec3 v, object obj) => v.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(vec3 v) => v.GetHashCode();
        
        /// <summary>
        /// Returns true iff distance between lhs and rhs is less than or equal to epsilon
        /// </summary>
        public static bool ApproxEqual(vec3 lhs, vec3 rhs, float eps = 0.1f) => vec3.ApproxEqual(lhs, rhs, eps);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec3 Equal(vec3 lhs, vec3 rhs) => vec3.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bool Equal(float lhs, float rhs) => lhs == rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec3 NotEqual(vec3 lhs, vec3 rhs) => vec3.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bool NotEqual(float lhs, float rhs) => lhs != rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec3 GreaterThan(vec3 lhs, vec3 rhs) => vec3.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bool GreaterThan(float lhs, float rhs) => lhs > rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec3 GreaterThanEqual(vec3 lhs, vec3 rhs) => vec3.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bool GreaterThanEqual(float lhs, float rhs) => lhs >= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec3 LesserThan(vec3 lhs, vec3 rhs) => vec3.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bool LesserThan(float lhs, float rhs) => lhs < rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec3 LesserThanEqual(vec3 lhs, vec3 rhs) => vec3.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bool LesserThanEqual(float lhs, float rhs) => lhs <= rhs;
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsInfinity(vec3 v) => vec3.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bool IsInfinity(float v) => float.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bvec3 IsFinite(vec3 v) => vec3.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bool IsFinite(float v) => !float.IsNaN(v) && !float.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bvec3 IsNaN(vec3 v) => vec3.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bool IsNaN(float v) => float.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec3 IsNegativeInfinity(vec3 v) => vec3.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bool IsNegativeInfinity(float v) => float.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec3 IsPositiveInfinity(vec3 v) => vec3.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a bvec3 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bool IsPositiveInfinity(float v) => float.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static vec3 Abs(vec3 v) => vec3.Abs(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Abs (Math.Abs(v)).
        /// </summary>
        public static float Abs(float v) => Math.Abs(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static vec3 HermiteInterpolationOrder3(vec3 v) => vec3.HermiteInterpolationOrder3(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of HermiteInterpolationOrder3 ((3 - 2 * v) * v * v).
        /// </summary>
        public static float HermiteInterpolationOrder3(float v) => (3 - 2 * v) * v * v;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static vec3 HermiteInterpolationOrder5(vec3 v) => vec3.HermiteInterpolationOrder5(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of HermiteInterpolationOrder5 (((6 * v - 15) * v + 10) * v * v * v).
        /// </summary>
        public static float HermiteInterpolationOrder5(float v) => ((6 * v - 15) * v + 10) * v * v * v;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static vec3 Sqr(vec3 v) => vec3.Sqr(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sqr (v * v).
        /// </summary>
        public static float Sqr(float v) => v * v;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static vec3 Pow2(vec3 v) => vec3.Pow2(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow2 (v * v).
        /// </summary>
        public static float Pow2(float v) => v * v;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static vec3 Pow3(vec3 v) => vec3.Pow3(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow3 (v * v * v).
        /// </summary>
        public static float Pow3(float v) => v * v * v;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static vec3 Step(vec3 v) => vec3.Step(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Step (v &gt;= 0f ? 1f : 0f).
        /// </summary>
        public static float Step(float v) => v >= 0f ? 1f : 0f;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sqrt ((float)Math.Sqrt((double)v)).
        /// </summary>
        public static vec3 Sqrt(vec3 v) => vec3.Sqrt(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sqrt ((float)Math.Sqrt((double)v)).
        /// </summary>
        public static float Sqrt(float v) => (float)Math.Sqrt((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of InverseSqrt ((float)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static vec3 InverseSqrt(vec3 v) => vec3.InverseSqrt(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of InverseSqrt ((float)(1.0 / Math.Sqrt((double)v))).
        /// </summary>
        public static float InverseSqrt(float v) => (float)(1.0 / Math.Sqrt((double)v));
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static ivec3 Sign(vec3 v) => vec3.Sign(v);
        
        /// <summary>
        /// Returns a ivec3 from component-wise application of Sign (Math.Sign(v)).
        /// </summary>
        public static int Sign(float v) => Math.Sign(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static vec3 Max(vec3 lhs, vec3 rhs) => vec3.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Max (Math.Max(lhs, rhs)).
        /// </summary>
        public static float Max(float lhs, float rhs) => Math.Max(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static vec3 Min(vec3 lhs, vec3 rhs) => vec3.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Min (Math.Min(lhs, rhs)).
        /// </summary>
        public static float Min(float lhs, float rhs) => Math.Min(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Pow(vec3 lhs, vec3 rhs) => vec3.Pow(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Pow ((float)Math.Pow((double)lhs, (double)rhs)).
        /// </summary>
        public static float Pow(float lhs, float rhs) => (float)Math.Pow((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static vec3 Log(vec3 lhs, vec3 rhs) => vec3.Log(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log ((float)Math.Log((double)lhs, (double)rhs)).
        /// </summary>
        public static float Log(float lhs, float rhs) => (float)Math.Log((double)lhs, (double)rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static vec3 Clamp(vec3 v, vec3 min, vec3 max) => vec3.Clamp(v, min, max);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Clamp (Math.Min(Math.Max(v, min), max)).
        /// </summary>
        public static float Clamp(float v, float min, float max) => Math.Min(Math.Max(v, min), max);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Mix(vec3 min, vec3 max, vec3 a) => vec3.Mix(min, max, a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mix (min * (1-a) + max * a).
        /// </summary>
        public static float Mix(float min, float max, float a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static vec3 Lerp(vec3 min, vec3 max, vec3 a) => vec3.Lerp(min, max, a);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static float Lerp(float min, float max, float a) => min * (1-a) + max * a;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static vec3 Smoothstep(vec3 edge0, vec3 edge1, vec3 v) => vec3.Smoothstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smoothstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3()).
        /// </summary>
        public static float Smoothstep(float edge0, float edge1, float v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder3();
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static vec3 Smootherstep(vec3 edge0, vec3 edge1, vec3 v) => vec3.Smootherstep(edge0, edge1, v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Smootherstep (((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5()).
        /// </summary>
        public static float Smootherstep(float edge0, float edge1, float v) => ((v - edge0) / (edge1 - edge0)).Clamp().HermiteInterpolationOrder5();
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static vec3 Fma(vec3 a, vec3 b, vec3 c) => vec3.Fma(a, b, c);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fma (a * b + c).
        /// </summary>
        public static float Fma(float a, float b, float c) => a * b + c;
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat2x3 OuterProduct(vec3 c, vec2 r) => vec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat3 OuterProduct(vec3 c, vec3 r) => vec3.OuterProduct(c, r);
        
        /// <summary>
        /// OuterProduct treats the first parameter c as a column vector (matrix with one column) and the second parameter r as a row vector (matrix with one row) and does a linear algebraic matrix multiply c * r, yielding a matrix whose number of rows is the number of components in c and whose number of columns is the number of components in r.
        /// </summary>
        public static mat4x3 OuterProduct(vec3 c, vec4 r) => vec3.OuterProduct(c, r);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static vec3 Add(vec3 lhs, vec3 rhs) => vec3.Add(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Add (lhs + rhs).
        /// </summary>
        public static float Add(float lhs, float rhs) => lhs + rhs;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static vec3 Sub(vec3 lhs, vec3 rhs) => vec3.Sub(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sub (lhs - rhs).
        /// </summary>
        public static float Sub(float lhs, float rhs) => lhs - rhs;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static vec3 Mul(vec3 lhs, vec3 rhs) => vec3.Mul(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Mul (lhs * rhs).
        /// </summary>
        public static float Mul(float lhs, float rhs) => lhs * rhs;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static vec3 Div(vec3 lhs, vec3 rhs) => vec3.Div(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Div (lhs / rhs).
        /// </summary>
        public static float Div(float lhs, float rhs) => lhs / rhs;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static vec3 Modulo(vec3 lhs, vec3 rhs) => vec3.Modulo(lhs, rhs);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Modulo (lhs % rhs).
        /// </summary>
        public static float Modulo(float lhs, float rhs) => lhs % rhs;
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static vec3 Degrees(vec3 v) => vec3.Degrees(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Degrees (Radians-To-Degrees Conversion).
        /// </summary>
        public static float Degrees(float v) => (float)(v * 57.295779513082320876798154814105170332405472466564321f);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static vec3 Radians(vec3 v) => vec3.Radians(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Radians (Degrees-To-Radians Conversion).
        /// </summary>
        public static float Radians(float v) => (float)(v * 0.0174532925199432957692369076848861271344287188854172f);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Acos ((float)Math.Acos((double)v)).
        /// </summary>
        public static vec3 Acos(vec3 v) => vec3.Acos(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Acos ((float)Math.Acos((double)v)).
        /// </summary>
        public static float Acos(float v) => (float)Math.Acos((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Asin ((float)Math.Asin((double)v)).
        /// </summary>
        public static vec3 Asin(vec3 v) => vec3.Asin(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Asin ((float)Math.Asin((double)v)).
        /// </summary>
        public static float Asin(float v) => (float)Math.Asin((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Atan ((float)Math.Atan((double)v)).
        /// </summary>
        public static vec3 Atan(vec3 v) => vec3.Atan(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Atan ((float)Math.Atan((double)v)).
        /// </summary>
        public static float Atan(float v) => (float)Math.Atan((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Cos ((float)Math.Cos((double)v)).
        /// </summary>
        public static vec3 Cos(vec3 v) => vec3.Cos(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Cos ((float)Math.Cos((double)v)).
        /// </summary>
        public static float Cos(float v) => (float)Math.Cos((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Cosh ((float)Math.Cosh((double)v)).
        /// </summary>
        public static vec3 Cosh(vec3 v) => vec3.Cosh(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Cosh ((float)Math.Cosh((double)v)).
        /// </summary>
        public static float Cosh(float v) => (float)Math.Cosh((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Exp ((float)Math.Exp((double)v)).
        /// </summary>
        public static vec3 Exp(vec3 v) => vec3.Exp(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Exp ((float)Math.Exp((double)v)).
        /// </summary>
        public static float Exp(float v) => (float)Math.Exp((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log ((float)Math.Log((double)v)).
        /// </summary>
        public static vec3 Log(vec3 v) => vec3.Log(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log ((float)Math.Log((double)v)).
        /// </summary>
        public static float Log(float v) => (float)Math.Log((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log2 ((float)Math.Log((double)v, 2)).
        /// </summary>
        public static vec3 Log2(vec3 v) => vec3.Log2(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log2 ((float)Math.Log((double)v, 2)).
        /// </summary>
        public static float Log2(float v) => (float)Math.Log((double)v, 2);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log10 ((float)Math.Log10((double)v)).
        /// </summary>
        public static vec3 Log10(vec3 v) => vec3.Log10(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Log10 ((float)Math.Log10((double)v)).
        /// </summary>
        public static float Log10(float v) => (float)Math.Log10((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Floor ((float)Math.Floor(v)).
        /// </summary>
        public static vec3 Floor(vec3 v) => vec3.Floor(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Floor ((float)Math.Floor(v)).
        /// </summary>
        public static float Floor(float v) => (float)Math.Floor(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Ceiling ((float)Math.Ceiling(v)).
        /// </summary>
        public static vec3 Ceiling(vec3 v) => vec3.Ceiling(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Ceiling ((float)Math.Ceiling(v)).
        /// </summary>
        public static float Ceiling(float v) => (float)Math.Ceiling(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Round ((float)Math.Round(v)).
        /// </summary>
        public static vec3 Round(vec3 v) => vec3.Round(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Round ((float)Math.Round(v)).
        /// </summary>
        public static float Round(float v) => (float)Math.Round(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sin ((float)Math.Sin((double)v)).
        /// </summary>
        public static vec3 Sin(vec3 v) => vec3.Sin(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sin ((float)Math.Sin((double)v)).
        /// </summary>
        public static float Sin(float v) => (float)Math.Sin((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sinh ((float)Math.Sinh((double)v)).
        /// </summary>
        public static vec3 Sinh(vec3 v) => vec3.Sinh(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Sinh ((float)Math.Sinh((double)v)).
        /// </summary>
        public static float Sinh(float v) => (float)Math.Sinh((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Tan ((float)Math.Tan((double)v)).
        /// </summary>
        public static vec3 Tan(vec3 v) => vec3.Tan(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Tan ((float)Math.Tan((double)v)).
        /// </summary>
        public static float Tan(float v) => (float)Math.Tan((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Tanh ((float)Math.Tanh((double)v)).
        /// </summary>
        public static vec3 Tanh(vec3 v) => vec3.Tanh(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Tanh ((float)Math.Tanh((double)v)).
        /// </summary>
        public static float Tanh(float v) => (float)Math.Tanh((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Truncate ((float)Math.Truncate((double)v)).
        /// </summary>
        public static vec3 Truncate(vec3 v) => vec3.Truncate(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Truncate ((float)Math.Truncate((double)v)).
        /// </summary>
        public static float Truncate(float v) => (float)Math.Truncate((double)v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fract ((float)(v - Math.Floor(v))).
        /// </summary>
        public static vec3 Fract(vec3 v) => vec3.Fract(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Fract ((float)(v - Math.Floor(v))).
        /// </summary>
        public static float Fract(float v) => (float)(v - Math.Floor(v));
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static vec3 Trunc(vec3 v) => vec3.Trunc(v);
        
        /// <summary>
        /// Returns a vec3 from component-wise application of Trunc ((long)(v)).
        /// </summary>
        public static float Trunc(float v) => (long)(v);
        
        /// <summary>
        /// Returns the minimal component of this vector.
        /// </summary>
        public static float MinElement(vec3 v) => v.MinElement;
        
        /// <summary>
        /// Returns the maximal component of this vector.
        /// </summary>
        public static float MaxElement(vec3 v) => v.MaxElement;
        
        /// <summary>
        /// Returns the euclidean length of this vector.
        /// </summary>
        public static float Length(vec3 v) => v.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this vector.
        /// </summary>
        public static float LengthSqr(vec3 v) => v.LengthSqr;
        
        /// <summary>
        /// Returns the sum of all components.
        /// </summary>
        public static float Sum(vec3 v) => v.Sum;
        
        /// <summary>
        /// Returns the euclidean norm of this vector.
        /// </summary>
        public static float Norm(vec3 v) => v.Norm;
        
        /// <summary>
        /// Returns the one-norm of this vector.
        /// </summary>
        public static float Norm1(vec3 v) => v.Norm1;
        
        /// <summary>
        /// Returns the two-norm (euclidean length) of this vector.
        /// </summary>
        public static float Norm2(vec3 v) => v.Norm2;
        
        /// <summary>
        /// Returns the max-norm of this vector.
        /// </summary>
        public static float NormMax(vec3 v) => v.NormMax;
        
        /// <summary>
        /// Returns the p-norm of this vector.
        /// </summary>
        public static double NormP(vec3 v, double p) => v.NormP(p);
        
        /// <summary>
        /// Returns a copy of this vector with length one (undefined if this has zero length).
        /// </summary>
        public static vec3 Normalized(vec3 v) => v.Normalized;
        
        /// <summary>
        /// Returns a copy of this vector with length one (returns zero if length is zero).
        /// </summary>
        public static vec3 NormalizedSafe(vec3 v) => v.NormalizedSafe;
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two vectors.
        /// </summary>
        public static float Dot(vec3 lhs, vec3 rhs) => vec3.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean distance between the two vectors.
        /// </summary>
        public static float Distance(vec3 lhs, vec3 rhs) => vec3.Distance(lhs, rhs);
        
        /// <summary>
        /// Returns the squared euclidean distance between the two vectors.
        /// </summary>
        public static float DistanceSqr(vec3 lhs, vec3 rhs) => vec3.DistanceSqr(lhs, rhs);
        
        /// <summary>
        /// Calculate the reflection direction for an incident vector (N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec3 Reflect(vec3 I, vec3 N) => vec3.Reflect(I, N);
        
        /// <summary>
        /// Calculate the refraction direction for an incident vector (The input parameters I and N should be normalized in order to achieve the desired result).
        /// </summary>
        public static vec3 Refract(vec3 I, vec3 N, float eta) => vec3.Refract(I, N, eta);
        
        /// <summary>
        /// Returns a vector pointing in the same direction as another (faceforward orients a vector to point away from a surface as defined by its normal. If dot(Nref, I) is negative faceforward returns N, otherwise it returns -N).
        /// </summary>
        public static vec3 FaceForward(vec3 N, vec3 I, vec3 Nref) => vec3.FaceForward(N, I, Nref);
        
        /// <summary>
        /// Returns the outer product (cross product, vector product) of the two vectors.
        /// </summary>
        public static vec3 Cross(vec3 l, vec3 r) => vec3.Cross(l, r);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 Random(Random random, vec3 minValue, vec3 maxValue) => vec3.Random(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float Random(Random random, float minValue, float maxValue) => (float)random.NextDouble() * (maxValue - minValue) + minValue;
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static vec3 RandomUniform(Random random, vec3 minValue, vec3 maxValue) => vec3.RandomUniform(random, minValue, maxValue);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed uniform values between 'minValue' and 'maxValue'.
        /// </summary>
        public static float RandomUniform(Random random, float minValue, float maxValue) => (float)random.NextDouble() * (maxValue - minValue) + minValue;
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomNormal(Random random, vec3 mean, vec3 variance) => vec3.RandomNormal(random, mean, variance);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float RandomNormal(Random random, float mean, float variance) => (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean;
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static vec3 RandomGaussian(Random random, vec3 mean, vec3 variance) => vec3.RandomGaussian(random, mean, variance);
        
        /// <summary>
        /// Returns a vec3 with independent and identically distributed values according to a normal/Gaussian distribution with specified mean and variance.
        /// </summary>
        public static float RandomGaussian(Random random, float mean, float variance) => (float)(Math.Sqrt((double)variance) * Math.Cos(2 * Math.PI * random.NextDouble()) * Math.Sqrt(-2.0 * Math.Log(random.NextDouble()))) + mean;

    }
}
