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
    /// A quaternion of type Half.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct hquat : IReadOnlyList<Half>, IEquatable<hquat>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public Half x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public Half y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public Half z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public Half w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public hquat(Half x, Half y, Half z, Half w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public hquat(Half v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// copy constructor
        /// </summary>
        public hquat(hquat q)
        {
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// vector-and-scalar constructor (CAUTION: not angle-axis, use FromAngleAxis instead)
        /// </summary>
        public hquat(hvec3 v, Half s)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = s;
        }
        
        /// <summary>
        /// Create a quaternion from two normalized axis (http://lolengine.net/blog/2013/09/18/beautiful-maths-quaternion-from-vectors)
        /// </summary>
        public hquat(hvec3 u, hvec3 v)
        {
            var localW = hvec3.Cross(u, v);
            var dot = hvec3.Dot(u, v);
            var q = new hquat(localW.x, localW.y, localW.z, Half.One + dot).Normalized;
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// Create a quaternion from two normalized axis (http://lolengine.net/blog/2013/09/18/beautiful-maths-quaternion-from-vectors)
        /// </summary>
        public hquat(hvec3 eulerAngle)
        {
            var c = hvec3.Cos(eulerAngle / 2);
            var s = hvec3.Sin(eulerAngle / 2);
            this.x = s.x * c.y * c.z - c.x * s.y * s.z;
            this.y = c.x * s.y * c.z + s.x * c.y * s.z;
            this.z = c.x * c.y * s.z - s.x * s.y * c.z;
            this.w = c.x * c.y * c.z + s.x * s.y * s.z;
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a hmat3.
        /// </summary>
        public hquat(hmat3 m)
            : this(FromMat3(m))
        {
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a hmat4.
        /// </summary>
        public hquat(hmat4 m)
            : this(FromMat4(m))
        {
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a quat.
        /// </summary>
        public static implicit operator quat(hquat v) => new quat((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Implicitly converts this to a dquat.
        /// </summary>
        public static implicit operator dquat(hquat v) => new dquat((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Implicitly converts this to a cquat.
        /// </summary>
        public static implicit operator cquat(hquat v) => new cquat((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(hquat v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a iquat.
        /// </summary>
        public static explicit operator iquat(hquat v) => new iquat((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(hquat v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uquat.
        /// </summary>
        public static explicit operator uquat(hquat v) => new uquat((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(hquat v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(hquat v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(hquat v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(hquat v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decquat.
        /// </summary>
        public static explicit operator decquat(hquat v) => new decquat((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(hquat v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(hquat v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lquat.
        /// </summary>
        public static explicit operator lquat(hquat v) => new lquat((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(hquat v) => new bvec4(v.x != Half.Zero, v.y != Half.Zero, v.z != Half.Zero, v.w != Half.Zero);
        
        /// <summary>
        /// Explicitly converts this to a bquat.
        /// </summary>
        public static explicit operator bquat(hquat v) => new bquat(v.x != Half.Zero, v.y != Half.Zero, v.z != Half.Zero, v.w != Half.Zero);
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a hmat3.
        /// </summary>
        public static explicit operator hquat(hmat3 m) => FromMat3(m);
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a hmat4.
        /// </summary>
        public static explicit operator hquat(hmat4 m) => FromMat4(m);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public Half this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    case 2: return z;
                    case 3: return w;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
            set
            {
                switch (index)
                {
                    case 0: x = value; break;
                    case 1: y = value; break;
                    case 2: z = value; break;
                    case 3: w = value; break;
                    default: throw new ArgumentOutOfRangeException("index");
                }
            }
        }

        #endregion


        #region Properties
        
        /// <summary>
        /// Returns an array with all values
        /// </summary>
        public Half[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the euclidean length of this quaternion.
        /// </summary>
        public float Length => (float)Math.Sqrt(((x*x + y*y) + (z*z + w*w)));
        
        /// <summary>
        /// Returns the squared euclidean length of this quaternion.
        /// </summary>
        public Half LengthSqr => ((x*x + y*y) + (z*z + w*w));
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (undefined if this has zero length).
        /// </summary>
        public hquat Normalized => this / (Half)Length;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (returns zero if length is zero).
        /// </summary>
        public hquat NormalizedSafe => this == Zero ? Identity : this / (Half)Length;
        
        /// <summary>
        /// Returns the represented angle of this quaternion.
        /// </summary>
        public double Angle => Math.Acos((double)w) * 2.0;
        
        /// <summary>
        /// Returns the represented axis of this quaternion.
        /// </summary>
        public hvec3 Axis
        {
            get
            {
                var s1 = 1 - w * w;
                if (s1 < 0) return hvec3.UnitZ;
                var s2 = 1 / Math.Sqrt(s1);
                return new hvec3((Half)(x * s2), (Half)(y * s2), (Half)(z * s2));
            }
        }
        
        /// <summary>
        /// Returns the represented yaw angle of this quaternion.
        /// </summary>
        public double Yaw => Math.Asin(-2.0 * (double)(x * z - w * y));
        
        /// <summary>
        /// Returns the represented pitch angle of this quaternion.
        /// </summary>
        public double Pitch => Math.Atan2(2.0 * (double)(y * z + w * x), (double)(w * w - x * x - y * y + z * z));
        
        /// <summary>
        /// Returns the represented roll angle of this quaternion.
        /// </summary>
        public double Roll => Math.Atan2(2.0 * (double)(x * y + w * z), (double)(w * w + x * x - y * y - z * z));
        
        /// <summary>
        /// Returns the represented euler angles (pitch, yaw, roll) of this quaternion.
        /// </summary>
        public dvec3 EulerAngles => new dvec3(Pitch, Yaw, Roll);
        
        /// <summary>
        /// Creates a hmat3 that realizes the rotation of this quaternion
        /// </summary>
        public hmat3 ToMat3 => new hmat3(1 - 2 * (y*y + z*z), 2 * (x*y + w*z), 2 * (x*z - w*y), 2 * (x*y - w*z), 1 - 2 * (x*x + z*z), 2 * (y*z + w*x), 2 * (x*z + w*y), 2 * (y*z - w*x), 1 - 2 * (x*x + y*y));
        
        /// <summary>
        /// Creates a hmat4 that realizes the rotation of this quaternion
        /// </summary>
        public hmat4 ToMat4 => new hmat4(ToMat3);
        
        /// <summary>
        /// Returns the conjugated quaternion
        /// </summary>
        public hquat Conjugate => new hquat(-x, -y, -z, w);
        
        /// <summary>
        /// Returns the inverse quaternion
        /// </summary>
        public hquat Inverse => Conjugate / LengthSqr;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero quaternion
        /// </summary>
        public static hquat Zero { get; } = new hquat(Half.Zero, Half.Zero, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined all-ones quaternion
        /// </summary>
        public static hquat Ones { get; } = new hquat(Half.One, Half.One, Half.One, Half.One);
        
        /// <summary>
        /// Predefined identity quaternion
        /// </summary>
        public static hquat Identity { get; } = new hquat(Half.Zero, Half.Zero, Half.Zero, Half.One);
        
        /// <summary>
        /// Predefined unit-X quaternion
        /// </summary>
        public static hquat UnitX { get; } = new hquat(Half.One, Half.Zero, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined unit-Y quaternion
        /// </summary>
        public static hquat UnitY { get; } = new hquat(Half.Zero, Half.One, Half.Zero, Half.Zero);
        
        /// <summary>
        /// Predefined unit-Z quaternion
        /// </summary>
        public static hquat UnitZ { get; } = new hquat(Half.Zero, Half.Zero, Half.One, Half.Zero);
        
        /// <summary>
        /// Predefined unit-W quaternion
        /// </summary>
        public static hquat UnitW { get; } = new hquat(Half.Zero, Half.Zero, Half.Zero, Half.One);
        
        /// <summary>
        /// Predefined all-MaxValue quaternion
        /// </summary>
        public static hquat MaxValue { get; } = new hquat(Half.MaxValue, Half.MaxValue, Half.MaxValue, Half.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue quaternion
        /// </summary>
        public static hquat MinValue { get; } = new hquat(Half.MinValue, Half.MinValue, Half.MinValue, Half.MinValue);
        
        /// <summary>
        /// Predefined all-Epsilon quaternion
        /// </summary>
        public static hquat Epsilon { get; } = new hquat(Half.Epsilon, Half.Epsilon, Half.Epsilon, Half.Epsilon);
        
        /// <summary>
        /// Predefined all-NaN quaternion
        /// </summary>
        public static hquat NaN { get; } = new hquat(Half.NaN, Half.NaN, Half.NaN, Half.NaN);
        
        /// <summary>
        /// Predefined all-NegativeInfinity quaternion
        /// </summary>
        public static hquat NegativeInfinity { get; } = new hquat(Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity, Half.NegativeInfinity);
        
        /// <summary>
        /// Predefined all-PositiveInfinity quaternion
        /// </summary>
        public static hquat PositiveInfinity { get; } = new hquat(Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity, Half.PositiveInfinity);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(hquat lhs, hquat rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(hquat lhs, hquat rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns proper multiplication of two quaternions.
        /// </summary>
        public static hquat operator*(hquat p, hquat q) => new hquat(p.w * q.x + p.x * q.w + p.y * q.z - p.z * q.y, p.w * q.y + p.y * q.w + p.z * q.x - p.x * q.z, p.w * q.z + p.z * q.w + p.x * q.y - p.y * q.x, p.w * q.w - p.x * q.x - p.y * q.y - p.z * q.z);
        
        /// <summary>
        /// Returns a vector rotated by the quaternion.
        /// </summary>
        public static hvec3 operator*(hquat q, hvec3 v)
        {
            var qv = new hvec3(q.x, q.y, q.z);
            var uv = hvec3.Cross(qv, v);
            var uuv = hvec3.Cross(qv, uv);
            return v + ((uv * q.w) + uuv) * 2;
        }
        
        /// <summary>
        /// Returns a vector rotated by the quaternion (preserves v.w).
        /// </summary>
        public static hvec4 operator*(hquat q, hvec4 v) => new hvec4(q * new hvec3(v), v.w);
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion.
        /// </summary>
        public static hvec3 operator*(hvec3 v, hquat q) => q.Inverse * v;
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion (preserves v.w).
        /// </summary>
        public static hvec4 operator*(hvec4 v, hquat q) => q.Inverse * v;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<Half> GetEnumerator()
        {
            yield return x;
            yield return y;
            yield return z;
            yield return w;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns a string representation of this quaternion using ', ' as a seperator.
        /// </summary>
        public override string ToString() => ToString(", ");
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator.
        /// </summary>
        public string ToString(string sep) => ((x + sep + y) + sep + (z + sep + w));
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format provider for each component.
        /// </summary>
        public string ToString(string sep, IFormatProvider provider) => ((x.ToString(provider) + sep + y.ToString(provider)) + sep + (z.ToString(provider) + sep + w.ToString(provider)));
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format for each component.
        /// </summary>
        public string ToString(string sep, string format) => ((x.ToString(format) + sep + y.ToString(format)) + sep + (z.ToString(format) + sep + w.ToString(format)));
        
        /// <summary>
        /// Returns a string representation of this quaternion using a provided seperator and a format and format provider for each component.
        /// </summary>
        public string ToString(string sep, string format, IFormatProvider provider) => ((x.ToString(format, provider) + sep + y.ToString(format, provider)) + sep + (z.ToString(format, provider) + sep + w.ToString(format, provider)));
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(hquat rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is hquat && Equals((hquat) obj);
        }
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((x.GetHashCode()) * 397) ^ y.GetHashCode()) * 397) ^ z.GetHashCode()) * 397) ^ w.GetHashCode();
            }
        }
        
        /// <summary>
        /// Rotates this quaternion from an axis and an angle (in radians).
        /// </summary>
        public hquat Rotated(Half angle, hvec3 v) => this * FromAxisAngle(angle, v);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using ', ' as a separator).
        /// </summary>
        public static hquat Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator).
        /// </summary>
        public static hquat Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new hquat(Half.Parse(kvp[0].Trim()), Half.Parse(kvp[1].Trim()), Half.Parse(kvp[2].Trim()), Half.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a type provider).
        /// </summary>
        public static hquat Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new hquat(Half.Parse(kvp[0].Trim(), provider), Half.Parse(kvp[1].Trim(), provider), Half.Parse(kvp[2].Trim(), provider), Half.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style).
        /// </summary>
        public static hquat Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new hquat(Half.Parse(kvp[0].Trim(), style), Half.Parse(kvp[1].Trim(), style), Half.Parse(kvp[2].Trim(), style), Half.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static hquat Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new hquat(Half.Parse(kvp[0].Trim(), style, provider), Half.Parse(kvp[1].Trim(), style, provider), Half.Parse(kvp[2].Trim(), style, provider), Half.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out hquat result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out hquat result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            Half x = Half.Zero, y = Half.Zero, z = Half.Zero, w = Half.Zero;
            var ok = ((Half.TryParse(kvp[0].Trim(), out x) && Half.TryParse(kvp[1].Trim(), out y)) && (Half.TryParse(kvp[2].Trim(), out z) && Half.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new hquat(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out hquat result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            Half x = Half.Zero, y = Half.Zero, z = Half.Zero, w = Half.Zero;
            var ok = ((Half.TryParse(kvp[0].Trim(), style, provider, out x) && Half.TryParse(kvp[1].Trim(), style, provider, out y)) && (Half.TryParse(kvp[2].Trim(), style, provider, out z) && Half.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new hquat(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two quaternions.
        /// </summary>
        public static Half Dot(hquat lhs, hquat rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Creates a quaternion from an axis and an angle (in radians).
        /// </summary>
        public static hquat FromAxisAngle(Half angle, hvec3 v)
        {
            var s = Math.Sin((double)angle * 0.5);
            var c = Math.Cos((double)angle * 0.5);
            return new hquat((Half)((double)v.x * s), (Half)((double)v.y * s), (Half)((double)v.z * s), (Half)c);
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a hmat4.
        /// </summary>
        public static hquat FromMat3(hmat3 m)
        {
            var fourXSquaredMinus1 = m.m00 - m.m11 - m.m22;
            var fourYSquaredMinus1 = m.m11 - m.m00 - m.m22;
            var fourZSquaredMinus1 = m.m22 - m.m00 - m.m11;
            var fourWSquaredMinus1 = m.m00 + m.m11 + m.m22;
            var biggestIndex = 0;
            var fourBiggestSquaredMinus1 = fourWSquaredMinus1;
            if(fourXSquaredMinus1 > fourBiggestSquaredMinus1)
            {
                fourBiggestSquaredMinus1 = fourXSquaredMinus1;
                biggestIndex = 1;
            }
            if(fourYSquaredMinus1 > fourBiggestSquaredMinus1)
            {
                fourBiggestSquaredMinus1 = fourYSquaredMinus1;
                biggestIndex = 2;
            }
            if(fourZSquaredMinus1 > fourBiggestSquaredMinus1)
            {
                fourBiggestSquaredMinus1 = fourZSquaredMinus1;
                biggestIndex = 3;
            }
            var biggestVal = Math.Sqrt((double)fourBiggestSquaredMinus1 + 1.0) * 0.5;
            var mult = 0.25 / biggestVal;
            switch(biggestIndex)
            {
                case 0: return new hquat((Half)((double)(m.m12 - m.m21) * mult), (Half)((double)(m.m20 - m.m02) * mult), (Half)((double)(m.m01 - m.m10) * mult), (Half)(biggestVal));
                case 1: return new hquat((Half)(biggestVal), (Half)((double)(m.m01 + m.m10) * mult), (Half)((double)(m.m20 + m.m02) * mult), (Half)((double)(m.m12 - m.m21) * mult));
                case 2: return new hquat((Half)((double)(m.m01 + m.m10) * mult), (Half)(biggestVal), (Half)((double)(m.m12 + m.m21) * mult), (Half)((double)(m.m20 - m.m02) * mult));
                default: return new hquat((Half)((double)(m.m20 + m.m02) * mult), (Half)((double)(m.m12 + m.m21) * mult), (Half)(biggestVal), (Half)((double)(m.m01 - m.m10) * mult));
            }
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a hmat3.
        /// </summary>
        public static hquat FromMat4(hmat4 m) => FromMat3(new hmat3(m));
        
        /// <summary>
        /// Returns the cross product between two quaternions.
        /// </summary>
        public static hquat Cross(hquat q1, hquat q2) => new hquat(q1.w * q2.x + q1.x * q2.w + q1.y * q2.z - q1.z * q2.y, q1.w * q2.y + q1.y * q2.w + q1.z * q2.x - q1.x * q2.z, q1.w * q2.z + q1.z * q2.w + q1.x * q2.y - q1.y * q2.x, q1.w * q2.w - q1.x * q2.x - q1.y * q2.y - q1.z * q2.z);
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static hquat Mix(hquat x, hquat y, Half a)
        {
            var cosTheta = (double)Dot(x, y);
            if (cosTheta > 1 - float.Epsilon)
                return Lerp(x, y, a);
            else
            {
                var angle = Math.Acos((double)cosTheta);
                return (hquat)( (Math.Sin((1 - (double)a) * angle) * (dquat)x + Math.Sin((double)a * angle) * (dquat)y) / Math.Sin(angle) );
            }
        }
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static hquat SLerp(hquat x, hquat y, Half a)
        {
            var z = y;
            var cosTheta = (double)Dot(x, y);
            if (cosTheta < 0) { z = -y; cosTheta = -cosTheta; }
            if (cosTheta > 1 - float.Epsilon)
                return Lerp(x, z, a);
            else
            {
                var angle = Math.Acos((double)cosTheta);
                return (hquat)( (Math.Sin((1 - (double)a) * angle) * (dquat)x + Math.Sin((double)a * angle) * (dquat)z) / Math.Sin(angle) );
            }
        }
        
        /// <summary>
        /// Applies squad interpolation of these quaternions
        /// </summary>
        public static hquat Squad(hquat q1, hquat q2, hquat s1, hquat s2, Half h) => Mix(Mix(q1, q2, h), Mix(s1, s2, h), 2 * (1 - h) * h);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsInfinity (Half.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(hquat v) => new bvec4(Half.IsInfinity(v.x), Half.IsInfinity(v.y), Half.IsInfinity(v.z), Half.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsInfinity (Half.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsInfinity(Half v) => new bvec4(Half.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsFinite (!Half.IsNaN(v) &amp;&amp; !Half.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(hquat v) => new bvec4(!Half.IsNaN(v.x) && !Half.IsInfinity(v.x), !Half.IsNaN(v.y) && !Half.IsInfinity(v.y), !Half.IsNaN(v.z) && !Half.IsInfinity(v.z), !Half.IsNaN(v.w) && !Half.IsInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsFinite (!Half.IsNaN(v) &amp;&amp; !Half.IsInfinity(v)).
        /// </summary>
        public static bvec4 IsFinite(Half v) => new bvec4(!Half.IsNaN(v) && !Half.IsInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNaN (Half.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(hquat v) => new bvec4(Half.IsNaN(v.x), Half.IsNaN(v.y), Half.IsNaN(v.z), Half.IsNaN(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsNaN (Half.IsNaN(v)).
        /// </summary>
        public static bvec4 IsNaN(Half v) => new bvec4(Half.IsNaN(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsNegativeInfinity (Half.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(hquat v) => new bvec4(Half.IsNegativeInfinity(v.x), Half.IsNegativeInfinity(v.y), Half.IsNegativeInfinity(v.z), Half.IsNegativeInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsNegativeInfinity (Half.IsNegativeInfinity(v)).
        /// </summary>
        public static bvec4 IsNegativeInfinity(Half v) => new bvec4(Half.IsNegativeInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of IsPositiveInfinity (Half.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(hquat v) => new bvec4(Half.IsPositiveInfinity(v.x), Half.IsPositiveInfinity(v.y), Half.IsPositiveInfinity(v.z), Half.IsPositiveInfinity(v.w));
        
        /// <summary>
        /// Returns a bvec from the application of IsPositiveInfinity (Half.IsPositiveInfinity(v)).
        /// </summary>
        public static bvec4 IsPositiveInfinity(Half v) => new bvec4(Half.IsPositiveInfinity(v));
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(hquat lhs, hquat rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(hquat lhs, Half rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(Half lhs, hquat rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(Half lhs, Half rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(hquat lhs, hquat rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(hquat lhs, Half rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(Half lhs, hquat rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(Half lhs, Half rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(hquat lhs, hquat rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(hquat lhs, Half rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(Half lhs, hquat rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(Half lhs, Half rhs) => new bvec4(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(hquat lhs, hquat rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(hquat lhs, Half rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(Half lhs, hquat rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(Half lhs, Half rhs) => new bvec4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(hquat lhs, hquat rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(hquat lhs, Half rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(Half lhs, hquat rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(Half lhs, Half rhs) => new bvec4(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(hquat lhs, hquat rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(hquat lhs, Half rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(Half lhs, hquat rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(Half lhs, Half rhs) => new bvec4(lhs <= rhs);
        
        /// <summary>
        /// Returns a hquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hquat Lerp(hquat min, hquat max, hquat a) => new hquat(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hquat Lerp(hquat min, hquat max, Half a) => new hquat(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a hquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hquat Lerp(hquat min, Half max, hquat a) => new hquat(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hquat Lerp(hquat min, Half max, Half a) => new hquat(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a hquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hquat Lerp(Half min, hquat max, hquat a) => new hquat(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hquat Lerp(Half min, hquat max, Half a) => new hquat(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a hquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hquat Lerp(Half min, Half max, hquat a) => new hquat(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a hquat from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static hquat Lerp(Half min, Half max, Half a) => new hquat(min * (1-a) + max * a);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(hquat lhs, hquat rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(hquat lhs, Half rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(Half lhs, hquat rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(hquat lhs, hquat rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(hquat lhs, Half rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(Half lhs, hquat rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(hquat lhs, hquat rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(hquat lhs, Half rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(Half lhs, hquat rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(hquat lhs, hquat rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(hquat lhs, Half rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(Half lhs, hquat rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator+ (identity).
        /// </summary>
        public static hquat operator+(hquat v) => v;
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator- (-v).
        /// </summary>
        public static hquat operator-(hquat v) => new hquat(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static hquat operator+(hquat lhs, hquat rhs) => new hquat(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static hquat operator+(hquat lhs, Half rhs) => new hquat(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static hquat operator+(Half lhs, hquat rhs) => new hquat(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static hquat operator-(hquat lhs, hquat rhs) => new hquat(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static hquat operator-(hquat lhs, Half rhs) => new hquat(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static hquat operator-(Half lhs, hquat rhs) => new hquat(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static hquat operator*(hquat lhs, Half rhs) => new hquat(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static hquat operator*(Half lhs, hquat rhs) => new hquat(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a hquat from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static hquat operator/(hquat lhs, Half rhs) => new hquat(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

        #endregion

    }
}
