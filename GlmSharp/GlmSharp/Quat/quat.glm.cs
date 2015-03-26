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
        public static float[] Values(quat q) => q.Values;
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public static IEnumerator<float> GetEnumerator(quat q) => q.GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public static string ToString(quat q) => q.ToString();
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public static string ToString(quat q, string sep) => q.ToString(sep);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format provider for each component.
        /// </summary>
        public static string ToString(quat q, string sep, IFormatProvider provider) => q.ToString(sep, provider);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format for each component.
        /// </summary>
        public static string ToString(quat q, string sep, string format) => q.ToString(sep, format);
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format and format provider for each component.
        /// </summary>
        public static string ToString(quat q, string sep, string format, IFormatProvider provider) => q.ToString(sep, format, provider);
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public static int Count(quat q) => q.Count;
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool Equals(quat q, quat rhs) => q.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public static bool Equals(quat q, object obj) => q.Equals(obj);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public static int GetHashCode(quat q) => q.GetHashCode();
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsInfinity (float.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(quat v) => quat.IsInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsFinite (!float.IsNaN(v) &amp;&amp; !float.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(quat v) => quat.IsFinite(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNaN (float.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(quat v) => quat.IsNaN(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNegativeInfinity (float.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(quat v) => quat.IsNegativeInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsPositiveInfinity (float.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(quat v) => quat.IsPositiveInfinity(v);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(quat lhs, quat rhs) => quat.Equal(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(quat lhs, quat rhs) => quat.NotEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(quat lhs, quat rhs) => quat.GreaterThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(quat lhs, quat rhs) => quat.GreaterThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(quat lhs, quat rhs) => quat.LesserThan(lhs, rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(quat lhs, quat rhs) => quat.LesserThanEqual(lhs, rhs);
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two quaternions.
        /// </summary>
        public static float Dot(quat lhs, quat rhs) => quat.Dot(lhs, rhs);
        
        /// <summary>
        /// Returns the euclidean length of this quaternion.
        /// </summary>
        public static float Length(quat q) => q.Length;
        
        /// <summary>
        /// Returns the squared euclidean length of this quaternion.
        /// </summary>
        public static float LengthSqr(quat q) => q.LengthSqr;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (undefined if this has zero length).
        /// </summary>
        public static quat Normalized(quat q) => q.Normalized;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (returns zero if length is zero).
        /// </summary>
        public static quat NormalizedSafe(quat q) => q.NormalizedSafe;
        
        /// <summary>
        /// Returns the represented angle of this quaternion.
        /// </summary>
        public static double Angle(quat q) => q.Angle;
        
        /// <summary>
        /// Returns the represented axis of this quaternion.
        /// </summary>
        public static vec3 Axis(quat q) => q.Axis;
        
        /// <summary>
        /// Returns the represented yaw angle of this quaternion.
        /// </summary>
        public static double Yaw(quat q) => q.Yaw;
        
        /// <summary>
        /// Returns the represented pitch angle of this quaternion.
        /// </summary>
        public static double Pitch(quat q) => q.Pitch;
        
        /// <summary>
        /// Returns the represented roll angle of this quaternion.
        /// </summary>
        public static double Roll(quat q) => q.Roll;
        
        /// <summary>
        /// Returns the represented euler angles (pitch, yaw, roll) of this quaternion.
        /// </summary>
        public static dvec3 EulerAngles(quat q) => q.EulerAngles;
        
        /// <summary>
        /// Rotates this quaternion from an axis and an angle (in radians).
        /// </summary>
        public static quat Rotated(quat q, float angle, vec3 v) => q.Rotated(angle, v);
        
        /// <summary>
        /// Creates a mat3 that realizes the rotation of this quaternion
        /// </summary>
        public static mat3 ToMat3(quat q) => q.ToMat3;
        
        /// <summary>
        /// Creates a mat4 that realizes the rotation of this quaternion
        /// </summary>
        public static mat4 ToMat4(quat q) => q.ToMat4;
        
        /// <summary>
        /// Returns the conjugated quaternion
        /// </summary>
        public static quat Conjugate(quat q) => q.Conjugate;
        
        /// <summary>
        /// Returns the inverse quaternion
        /// </summary>
        public static quat Inverse(quat q) => q.Inverse;
        
        /// <summary>
        /// Returns the cross product between two quaternions.
        /// </summary>
        public static quat Cross(quat q1, quat q2) => quat.Cross(q1, q2);
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static quat Mix(quat x, quat y, float a) => quat.Mix(x, y, a);
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static quat SLerp(quat x, quat y, float a) => quat.SLerp(x, y, a);
        
        /// <summary>
        /// Applies squad interpolation of these quaternions
        /// </summary>
        public static quat Squad(quat q1, quat q2, quat s1, quat s2, float h) => quat.Squad(q1, q2, s1, s2, h);
        
        /// <summary>
        /// Returns a quat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static quat Lerp(quat min, quat max, quat a) => quat.Lerp(min, max, a);

    }
}
