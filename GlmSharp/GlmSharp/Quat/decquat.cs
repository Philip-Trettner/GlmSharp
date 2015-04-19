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
    /// A quaternion of type decimal.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct decquat : IReadOnlyList<decimal>, IEquatable<decquat>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public decimal x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public decimal y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public decimal z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public decimal w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public decquat(decimal x, decimal y, decimal z, decimal w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public decquat(decimal v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// copy constructor
        /// </summary>
        public decquat(decquat q)
        {
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// vector-and-scalar constructor (CAUTION: not angle-axis, use FromAngleAxis instead)
        /// </summary>
        public decquat(decvec3 v, decimal s)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = s;
        }
        
        /// <summary>
        /// Create a quaternion from two normalized axis (http://lolengine.net/blog/2013/09/18/beautiful-maths-quaternion-from-vectors)
        /// </summary>
        public decquat(decvec3 u, decvec3 v)
        {
            var localW = decvec3.Cross(u, v);
            var dot = decvec3.Dot(u, v);
            var q = new decquat(localW.x, localW.y, localW.z, 1m + dot).Normalized;
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// Create a quaternion from two normalized axis (http://lolengine.net/blog/2013/09/18/beautiful-maths-quaternion-from-vectors)
        /// </summary>
        public decquat(decvec3 eulerAngle)
        {
            var c = decvec3.Cos(eulerAngle / 2);
            var s = decvec3.Sin(eulerAngle / 2);
            this.x = s.x * c.y * c.z - c.x * s.y * s.z;
            this.y = c.x * s.y * c.z + s.x * c.y * s.z;
            this.z = c.x * c.y * s.z - s.x * s.y * c.z;
            this.w = c.x * c.y * c.z + s.x * s.y * s.z;
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a decmat3.
        /// </summary>
        public decquat(decmat3 m)
            : this(FromMat3(m))
        {
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a decmat4.
        /// </summary>
        public decquat(decmat4 m)
            : this(FromMat4(m))
        {
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(decquat v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a iquat.
        /// </summary>
        public static explicit operator iquat(decquat v) => new iquat((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(decquat v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uquat.
        /// </summary>
        public static explicit operator uquat(decquat v) => new uquat((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(decquat v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a quat.
        /// </summary>
        public static explicit operator quat(decquat v) => new quat((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(decquat v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hquat.
        /// </summary>
        public static explicit operator hquat(decquat v) => new hquat((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(decquat v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dquat.
        /// </summary>
        public static explicit operator dquat(decquat v) => new dquat((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(decquat v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(decquat v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cquat.
        /// </summary>
        public static explicit operator cquat(decquat v) => new cquat((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(decquat v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lquat.
        /// </summary>
        public static explicit operator lquat(decquat v) => new lquat((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(decquat v) => new bvec4(v.x != 0m, v.y != 0m, v.z != 0m, v.w != 0m);
        
        /// <summary>
        /// Explicitly converts this to a bquat.
        /// </summary>
        public static explicit operator bquat(decquat v) => new bquat(v.x != 0m, v.y != 0m, v.z != 0m, v.w != 0m);
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a decmat3.
        /// </summary>
        public static explicit operator decquat(decmat3 m) => FromMat3(m);
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a decmat4.
        /// </summary>
        public static explicit operator decquat(decmat4 m) => FromMat4(m);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public decimal this[int index]
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
        public decimal[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the euclidean length of this quaternion.
        /// </summary>
        public decimal Length => (decimal)(((x*x + y*y) + (z*z + w*w))).Sqrt();
        
        /// <summary>
        /// Returns the squared euclidean length of this quaternion.
        /// </summary>
        public decimal LengthSqr => ((x*x + y*y) + (z*z + w*w));
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (undefined if this has zero length).
        /// </summary>
        public decquat Normalized => this / (decimal)Length;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (returns zero if length is zero).
        /// </summary>
        public decquat NormalizedSafe => this == Zero ? Identity : this / (decimal)Length;
        
        /// <summary>
        /// Returns the represented angle of this quaternion.
        /// </summary>
        public double Angle => Math.Acos((double)w) * 2.0;
        
        /// <summary>
        /// Returns the represented axis of this quaternion.
        /// </summary>
        public decvec3 Axis
        {
            get
            {
                var s1 = 1 - w * w;
                if (s1 < 0) return decvec3.UnitZ;
                var s2 = 1 / (s1).Sqrt();
                return new decvec3((decimal)(x * s2), (decimal)(y * s2), (decimal)(z * s2));
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
        /// Creates a decmat3 that realizes the rotation of this quaternion
        /// </summary>
        public decmat3 ToMat3 => new decmat3(1 - 2 * (y*y + z*z), 2 * (x*y + w*z), 2 * (x*z - w*y), 2 * (x*y - w*z), 1 - 2 * (x*x + z*z), 2 * (y*z + w*x), 2 * (x*z + w*y), 2 * (y*z - w*x), 1 - 2 * (x*x + y*y));
        
        /// <summary>
        /// Creates a decmat4 that realizes the rotation of this quaternion
        /// </summary>
        public decmat4 ToMat4 => new decmat4(ToMat3);
        
        /// <summary>
        /// Returns the conjugated quaternion
        /// </summary>
        public decquat Conjugate => new decquat(-x, -y, -z, w);
        
        /// <summary>
        /// Returns the inverse quaternion
        /// </summary>
        public decquat Inverse => Conjugate / LengthSqr;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero quaternion
        /// </summary>
        public static decquat Zero { get; } = new decquat(0m, 0m, 0m, 0m);
        
        /// <summary>
        /// Predefined all-ones quaternion
        /// </summary>
        public static decquat Ones { get; } = new decquat(1m, 1m, 1m, 1m);
        
        /// <summary>
        /// Predefined identity quaternion
        /// </summary>
        public static decquat Identity { get; } = new decquat(0m, 0m, 0m, 1m);
        
        /// <summary>
        /// Predefined unit-X quaternion
        /// </summary>
        public static decquat UnitX { get; } = new decquat(1m, 0m, 0m, 0m);
        
        /// <summary>
        /// Predefined unit-Y quaternion
        /// </summary>
        public static decquat UnitY { get; } = new decquat(0m, 1m, 0m, 0m);
        
        /// <summary>
        /// Predefined unit-Z quaternion
        /// </summary>
        public static decquat UnitZ { get; } = new decquat(0m, 0m, 1m, 0m);
        
        /// <summary>
        /// Predefined unit-W quaternion
        /// </summary>
        public static decquat UnitW { get; } = new decquat(0m, 0m, 0m, 1m);
        
        /// <summary>
        /// Predefined all-MaxValue quaternion
        /// </summary>
        public static decquat MaxValue { get; } = new decquat(decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue quaternion
        /// </summary>
        public static decquat MinValue { get; } = new decquat(decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue);
        
        /// <summary>
        /// Predefined all-MinusOne quaternion
        /// </summary>
        public static decquat MinusOne { get; } = new decquat(decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(decquat lhs, decquat rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(decquat lhs, decquat rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns proper multiplication of two quaternions.
        /// </summary>
        public static decquat operator*(decquat p, decquat q) => new decquat(p.w * q.x + p.x * q.w + p.y * q.z - p.z * q.y, p.w * q.y + p.y * q.w + p.z * q.x - p.x * q.z, p.w * q.z + p.z * q.w + p.x * q.y - p.y * q.x, p.w * q.w - p.x * q.x - p.y * q.y - p.z * q.z);
        
        /// <summary>
        /// Returns a vector rotated by the quaternion.
        /// </summary>
        public static decvec3 operator*(decquat q, decvec3 v)
        {
            var qv = new decvec3(q.x, q.y, q.z);
            var uv = decvec3.Cross(qv, v);
            var uuv = decvec3.Cross(qv, uv);
            return v + ((uv * q.w) + uuv) * 2;
        }
        
        /// <summary>
        /// Returns a vector rotated by the quaternion (preserves v.w).
        /// </summary>
        public static decvec4 operator*(decquat q, decvec4 v) => new decvec4(q * new decvec3(v), v.w);
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion.
        /// </summary>
        public static decvec3 operator*(decvec3 v, decquat q) => q.Inverse * v;
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion (preserves v.w).
        /// </summary>
        public static decvec4 operator*(decvec4 v, decquat q) => q.Inverse * v;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<decimal> GetEnumerator()
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
        public bool Equals(decquat rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is decquat && Equals((decquat) obj);
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
        public decquat Rotated(decimal angle, decvec3 v) => this * FromAxisAngle(angle, v);

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using ', ' as a separator).
        /// </summary>
        public static decquat Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator).
        /// </summary>
        public static decquat Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new decquat(decimal.Parse(kvp[0].Trim()), decimal.Parse(kvp[1].Trim()), decimal.Parse(kvp[2].Trim()), decimal.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a type provider).
        /// </summary>
        public static decquat Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new decquat(decimal.Parse(kvp[0].Trim(), provider), decimal.Parse(kvp[1].Trim(), provider), decimal.Parse(kvp[2].Trim(), provider), decimal.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style).
        /// </summary>
        public static decquat Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new decquat(decimal.Parse(kvp[0].Trim(), style), decimal.Parse(kvp[1].Trim(), style), decimal.Parse(kvp[2].Trim(), style), decimal.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static decquat Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new decquat(decimal.Parse(kvp[0].Trim(), style, provider), decimal.Parse(kvp[1].Trim(), style, provider), decimal.Parse(kvp[2].Trim(), style, provider), decimal.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out decquat result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out decquat result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            decimal x = 0m, y = 0m, z = 0m, w = 0m;
            var ok = ((decimal.TryParse(kvp[0].Trim(), out x) && decimal.TryParse(kvp[1].Trim(), out y)) && (decimal.TryParse(kvp[2].Trim(), out z) && decimal.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new decquat(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out decquat result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            decimal x = 0m, y = 0m, z = 0m, w = 0m;
            var ok = ((decimal.TryParse(kvp[0].Trim(), style, provider, out x) && decimal.TryParse(kvp[1].Trim(), style, provider, out y)) && (decimal.TryParse(kvp[2].Trim(), style, provider, out z) && decimal.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new decquat(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two quaternions.
        /// </summary>
        public static decimal Dot(decquat lhs, decquat rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Creates a quaternion from an axis and an angle (in radians).
        /// </summary>
        public static decquat FromAxisAngle(decimal angle, decvec3 v)
        {
            var s = Math.Sin((double)angle * 0.5);
            var c = Math.Cos((double)angle * 0.5);
            return new decquat((decimal)((double)v.x * s), (decimal)((double)v.y * s), (decimal)((double)v.z * s), (decimal)c);
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a decmat4.
        /// </summary>
        public static decquat FromMat3(decmat3 m)
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
                case 0: return new decquat((decimal)((double)(m.m12 - m.m21) * mult), (decimal)((double)(m.m20 - m.m02) * mult), (decimal)((double)(m.m01 - m.m10) * mult), (decimal)(biggestVal));
                case 1: return new decquat((decimal)(biggestVal), (decimal)((double)(m.m01 + m.m10) * mult), (decimal)((double)(m.m20 + m.m02) * mult), (decimal)((double)(m.m12 - m.m21) * mult));
                case 2: return new decquat((decimal)((double)(m.m01 + m.m10) * mult), (decimal)(biggestVal), (decimal)((double)(m.m12 + m.m21) * mult), (decimal)((double)(m.m20 - m.m02) * mult));
                default: return new decquat((decimal)((double)(m.m20 + m.m02) * mult), (decimal)((double)(m.m12 + m.m21) * mult), (decimal)(biggestVal), (decimal)((double)(m.m01 - m.m10) * mult));
            }
        }
        
        /// <summary>
        /// Creates a quaternion from the rotational part of a decmat3.
        /// </summary>
        public static decquat FromMat4(decmat4 m) => FromMat3(new decmat3(m));
        
        /// <summary>
        /// Returns the cross product between two quaternions.
        /// </summary>
        public static decquat Cross(decquat q1, decquat q2) => new decquat(q1.w * q2.x + q1.x * q2.w + q1.y * q2.z - q1.z * q2.y, q1.w * q2.y + q1.y * q2.w + q1.z * q2.x - q1.x * q2.z, q1.w * q2.z + q1.z * q2.w + q1.x * q2.y - q1.y * q2.x, q1.w * q2.w - q1.x * q2.x - q1.y * q2.y - q1.z * q2.z);
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static decquat Mix(decquat x, decquat y, decimal a)
        {
            var cosTheta = (double)Dot(x, y);
            if (cosTheta > 1 - float.Epsilon)
                return Lerp(x, y, a);
            else
            {
                var angle = Math.Acos((double)cosTheta);
                return (decquat)( (Math.Sin((1 - (double)a) * angle) * (dquat)x + Math.Sin((double)a * angle) * (dquat)y) / Math.Sin(angle) );
            }
        }
        
        /// <summary>
        /// Calculates a proper spherical interpolation between two quaternions (only works for normalized quaternions).
        /// </summary>
        public static decquat SLerp(decquat x, decquat y, decimal a)
        {
            var z = y;
            var cosTheta = (double)Dot(x, y);
            if (cosTheta < 0) { z = -y; cosTheta = -cosTheta; }
            if (cosTheta > 1 - float.Epsilon)
                return Lerp(x, z, a);
            else
            {
                var angle = Math.Acos((double)cosTheta);
                return (decquat)( (Math.Sin((1 - (double)a) * angle) * (dquat)x + Math.Sin((double)a * angle) * (dquat)z) / Math.Sin(angle) );
            }
        }
        
        /// <summary>
        /// Applies squad interpolation of these quaternions
        /// </summary>
        public static decquat Squad(decquat q1, decquat q2, decquat s1, decquat s2, decimal h) => Mix(Mix(q1, q2, h), Mix(s1, s2, h), 2 * (1 - h) * h);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(decquat lhs, decquat rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(decquat lhs, decimal rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(decimal lhs, decquat rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(decimal lhs, decimal rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(decquat lhs, decquat rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(decquat lhs, decimal rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(decimal lhs, decquat rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(decimal lhs, decimal rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(decquat lhs, decquat rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(decquat lhs, decimal rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(decimal lhs, decquat rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(decimal lhs, decimal rhs) => new bvec4(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(decquat lhs, decquat rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(decquat lhs, decimal rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(decimal lhs, decquat rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(decimal lhs, decimal rhs) => new bvec4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(decquat lhs, decquat rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(decquat lhs, decimal rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(decimal lhs, decquat rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(decimal lhs, decimal rhs) => new bvec4(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(decquat lhs, decquat rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(decquat lhs, decimal rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(decimal lhs, decquat rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(decimal lhs, decimal rhs) => new bvec4(lhs <= rhs);
        
        /// <summary>
        /// Returns a decquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decquat Lerp(decquat min, decquat max, decquat a) => new decquat(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decquat Lerp(decquat min, decquat max, decimal a) => new decquat(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a decquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decquat Lerp(decquat min, decimal max, decquat a) => new decquat(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decquat Lerp(decquat min, decimal max, decimal a) => new decquat(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a decquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decquat Lerp(decimal min, decquat max, decquat a) => new decquat(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decquat Lerp(decimal min, decquat max, decimal a) => new decquat(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a decquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decquat Lerp(decimal min, decimal max, decquat a) => new decquat(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a decquat from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static decquat Lerp(decimal min, decimal max, decimal a) => new decquat(min * (1-a) + max * a);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(decquat lhs, decquat rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(decquat lhs, decimal rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(decimal lhs, decquat rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(decquat lhs, decquat rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(decquat lhs, decimal rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(decimal lhs, decquat rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(decquat lhs, decquat rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(decquat lhs, decimal rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(decimal lhs, decquat rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(decquat lhs, decquat rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(decquat lhs, decimal rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(decimal lhs, decquat rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator+ (identity).
        /// </summary>
        public static decquat operator+(decquat v) => v;
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator- (-v).
        /// </summary>
        public static decquat operator-(decquat v) => new decquat(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decquat operator+(decquat lhs, decquat rhs) => new decquat(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decquat operator+(decquat lhs, decimal rhs) => new decquat(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static decquat operator+(decimal lhs, decquat rhs) => new decquat(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decquat operator-(decquat lhs, decquat rhs) => new decquat(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decquat operator-(decquat lhs, decimal rhs) => new decquat(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static decquat operator-(decimal lhs, decquat rhs) => new decquat(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decquat operator*(decquat lhs, decimal rhs) => new decquat(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static decquat operator*(decimal lhs, decquat rhs) => new decquat(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a decquat from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static decquat operator/(decquat lhs, decimal rhs) => new decquat(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

        #endregion

    }
}
