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
        /// Returns an array with all values
        /// </summary>
        public static long[] Values(lquat q) => q.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<long> GetEnumerator(lquat q) => q.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public static string ToString(lquat q) => q.ToString();
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public static string ToString(lquat q, string sep) => q.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(lquat q, string sep, IFormatProvider provider) => q.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(lquat q, string sep, string format) => q.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(lquat q, string sep, string format, IFormatProvider provider) => q.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(lquat q) => q.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(lquat q, lquat rhs) => q.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(lquat q, object obj) => q.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(lquat q) => q.GetHashCode();
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(lquat lhs, lquat rhs) => lquat.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(lquat lhs, lquat rhs) => lquat.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(lquat lhs, lquat rhs) => lquat.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(lquat lhs, lquat rhs) => lquat.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(lquat lhs, lquat rhs) => lquat.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(lquat lhs, lquat rhs) => lquat.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two quaternions.
        /// </summary>
        public static long Dot(lquat lhs, lquat rhs) => lquat.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean length of this quaternion.
        /// </summary>
        public static double Length(lquat q) => q.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this quaternion.
        /// </summary>
        public static long LengthSqr(lquat q) => q.LengthSqr;
        
        /// <summary>
        /// Returns the conjugated quaternion
        /// </summary>
        public static lquat Conjugate(lquat q) => q.Conjugate;
        
        /// <summary>
        /// Returns the inverse quaternion
        /// </summary>
        public static lquat Inverse(lquat q) => q.Inverse;
        
        /// <summary>
        /// Returns the cross product between two quaternions.
        /// </summary>
        public static lquat Cross(lquat q1, lquat q2) => lquat.Cross(q1, q2);
        
        /// <summary>
        /// Returns a lquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static lquat Lerp(lquat min, lquat max, lquat a) => lquat.Lerp(min, max, a);

    }
}
