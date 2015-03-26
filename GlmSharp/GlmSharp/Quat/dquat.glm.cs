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
        public static double[] Values(dquat q) => q.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<double> GetEnumerator(dquat q) => q.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public static string ToString(dquat q) => q.ToString();
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public static string ToString(dquat q, string sep) => q.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(dquat q, string sep, IFormatProvider provider) => q.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(dquat q, string sep, string format) => q.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(dquat q, string sep, string format, IFormatProvider provider) => q.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(dquat q) => q.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(dquat q, dquat rhs) => q.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(dquat q, object obj) => q.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(dquat q) => q.GetHashCode();
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsInfinity (double.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(dquat v) => dquat.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsFinite (!double.IsNaN(v) &amp;&amp; !double.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(dquat v) => dquat.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNaN (double.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(dquat v) => dquat.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNegativeInfinity (double.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(dquat v) => dquat.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsPositiveInfinity (double.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(dquat v) => dquat.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(dquat lhs, dquat rhs) => dquat.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(dquat lhs, dquat rhs) => dquat.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(dquat lhs, dquat rhs) => dquat.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(dquat lhs, dquat rhs) => dquat.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(dquat lhs, dquat rhs) => dquat.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(dquat lhs, dquat rhs) => dquat.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two quaternions.
        /// </summary>
        public static double Dot(dquat lhs, dquat rhs) => dquat.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean length of this quaternion.
        /// </summary>
        public static double Length(dquat q) => q.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this quaternion.
        /// </summary>
        public static double LengthSqr(dquat q) => q.LengthSqr;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (undefined if this has zero length).
        /// </summary>
        public static dquat Normalized(dquat q) => q.Normalized;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (returns zero if length is zero).
        /// </summary>
        public static dquat NormalizedSafe(dquat q) => q.NormalizedSafe;
        
        /// <summary>
        /// Returns the represented angle of this quaternion.
        /// </summary>
        public static double Angle(dquat q) => q.Angle;
        
        /// <summary>
        /// Returns the represented axis of this quaternion.
        /// </summary>
        public static dvec3 Axis(dquat q) => q.Axis;
        
        /// <summary>
        /// Returns the represented yaw angle of this quaternion.
        /// </summary>
        public static double Yaw(dquat q) => q.Yaw;
        
        /// <summary>
        /// Returns the represented pitch angle of this quaternion.
        /// </summary>
        public static double Pitch(dquat q) => q.Pitch;
        
        /// <summary>
        /// Returns the represented roll angle of this quaternion.
        /// </summary>
        public static double Roll(dquat q) => q.Roll;
        
        /// <summary>
        /// Returns the represented euler angles (pitch, yaw, roll) of this quaternion.
        /// </summary>
        public static dvec3 EulerAngles(dquat q) => q.EulerAngles;
        
        /// <summary>
        /// Rotates this quaternion from an axis and an angle (in radians).
        /// </summary>
        public static dquat Rotated(dquat q, double angle, dvec3 v) => q.Rotated(angle, v);
        
        /// <summary>
        /// Creates a dmat3 that realizes the rotation of this quaternion
        /// </summary>
        public static dmat3 ToMat3(dquat q) => q.ToMat3;
        
        /// <summary>
        /// Creates a dmat4 that realizes the rotation of this quaternion
        /// </summary>
        public static dmat4 ToMat4(dquat q) => q.ToMat4;
        
        /// <summary>
        /// Returns the conjugated quaternion
        /// </summary>
        public static dquat Conjugate(dquat q) => q.Conjugate;
        
        /// <summary>
        /// Returns the inverse quaternion
        /// </summary>
        public static dquat Inverse(dquat q) => q.Inverse;
        
        /// <summary>
        /// Returns the cross product between two quaternions.
        /// </summary>
        public static dquat Cross(dquat q1, dquat q2) => dquat.Cross(q1, q2);
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static dquat Mix(dquat x, dquat y, double a) => dquat.Mix(x, y, a);
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static dquat SLerp(dquat x, dquat y, double a) => dquat.SLerp(x, y, a);
        
        /// <summary>
        /// Applies squad interpolation of these quaternions
        /// </summary>
        public static dquat Squad(dquat q1, dquat q2, dquat s1, dquat s2, double h) => dquat.Squad(q1, q2, s1, s2, h);
        
        /// <summary>
        /// Returns a dquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static dquat Lerp(dquat min, dquat max, dquat a) => dquat.Lerp(min, max, a);

    }
}
