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
        public static Half[] Values(hquat q) => q.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<Half> GetEnumerator(hquat q) => q.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public static string ToString(hquat q) => q.ToString();
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public static string ToString(hquat q, string sep) => q.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(hquat q, string sep, IFormatProvider provider) => q.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(hquat q, string sep, string format) => q.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(hquat q, string sep, string format, IFormatProvider provider) => q.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(hquat q) => q.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(hquat q, hquat rhs) => q.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(hquat q, object obj) => q.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(hquat q) => q.GetHashCode();
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsInfinity (Half.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(hquat v) => hquat.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsFinite (!Half.IsNaN(v) &amp;&amp; !Half.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(hquat v) => hquat.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNaN (Half.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(hquat v) => hquat.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNegativeInfinity (Half.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(hquat v) => hquat.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsPositiveInfinity (Half.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(hquat v) => hquat.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(hquat lhs, hquat rhs) => hquat.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(hquat lhs, hquat rhs) => hquat.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(hquat lhs, hquat rhs) => hquat.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(hquat lhs, hquat rhs) => hquat.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(hquat lhs, hquat rhs) => hquat.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(hquat lhs, hquat rhs) => hquat.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two quaternions.
        /// </summary>
        public static Half Dot(hquat lhs, hquat rhs) => hquat.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean length of this quaternion.
        /// </summary>
        public static float Length(hquat q) => q.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this quaternion.
        /// </summary>
        public static Half LengthSqr(hquat q) => q.LengthSqr;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (undefined if this has zero length).
        /// </summary>
        public static hquat Normalized(hquat q) => q.Normalized;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (returns zero if length is zero).
        /// </summary>
        public static hquat NormalizedSafe(hquat q) => q.NormalizedSafe;
        
        /// <summary>
        /// Returns the represented angle of this quaternion.
        /// </summary>
        public static double Angle(hquat q) => q.Angle;
        
        /// <summary>
        /// Returns the represented axis of this quaternion.
        /// </summary>
        public static hvec3 Axis(hquat q) => q.Axis;
        
        /// <summary>
        /// Returns the represented yaw angle of this quaternion.
        /// </summary>
        public static double Yaw(hquat q) => q.Yaw;
        
        /// <summary>
        /// Returns the represented pitch angle of this quaternion.
        /// </summary>
        public static double Pitch(hquat q) => q.Pitch;
        
        /// <summary>
        /// Returns the represented roll angle of this quaternion.
        /// </summary>
        public static double Roll(hquat q) => q.Roll;
        
        /// <summary>
        /// Returns the represented euler angles (pitch, yaw, roll) of this quaternion.
        /// </summary>
        public static dvec3 EulerAngles(hquat q) => q.EulerAngles;
        
        /// <summary>
        /// Rotates this quaternion from an axis and an angle (in radians).
        /// </summary>
        public static hquat Rotated(hquat q, Half angle, hvec3 v) => q.Rotated(angle, v);
        
        /// <summary>
        /// Creates a hmat3 that realizes the rotation of this quaternion
        /// </summary>
        public static hmat3 ToMat3(hquat q) => q.ToMat3;
        
        /// <summary>
        /// Creates a hmat4 that realizes the rotation of this quaternion
        /// </summary>
        public static hmat4 ToMat4(hquat q) => q.ToMat4;
        
        /// <summary>
        /// Returns the conjugated quaternion
        /// </summary>
        public static hquat Conjugate(hquat q) => q.Conjugate;
        
        /// <summary>
        /// Returns the inverse quaternion
        /// </summary>
        public static hquat Inverse(hquat q) => q.Inverse;
        
        /// <summary>
        /// Returns the cross product between two quaternions.
        /// </summary>
        public static hquat Cross(hquat q1, hquat q2) => hquat.Cross(q1, q2);
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static hquat Mix(hquat x, hquat y, Half a) => hquat.Mix(x, y, a);
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static hquat SLerp(hquat x, hquat y, Half a) => hquat.SLerp(x, y, a);
        
        /// <summary>
        /// Applies squad interpolation of these quaternions
        /// </summary>
        public static hquat Squad(hquat q1, hquat q2, hquat s1, hquat s2, Half h) => hquat.Squad(q1, q2, s1, s2, h);
        
        /// <summary>
        /// Returns a hquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hquat Lerp(hquat min, hquat max, hquat a) => hquat.Lerp(min, max, a);

    }
}
