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
    /// A quaternion of type int.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct iquat : IReadOnlyList<int>, IEquatable<iquat>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public int x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public int y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public int z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public int w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public iquat(int x, int y, int z, int w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public iquat(int v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// copy constructor
        /// </summary>
        public iquat(iquat q)
        {
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// vector-and-scalar constructor (CAUTION: not angle-axis, use FromAngleAxis instead)
        /// </summary>
        public iquat(ivec3 v, int s)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = s;
        }

        #endregion


        #region Implicit Operators
        
        /// <summary>
        /// Implicitly converts this to a lquat.
        /// </summary>
        public static implicit operator lquat(iquat v) => new lquat((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Implicitly converts this to a quat.
        /// </summary>
        public static implicit operator quat(iquat v) => new quat((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Implicitly converts this to a hquat.
        /// </summary>
        public static implicit operator hquat(iquat v) => new hquat((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Implicitly converts this to a dquat.
        /// </summary>
        public static implicit operator dquat(iquat v) => new dquat((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Implicitly converts this to a decquat.
        /// </summary>
        public static implicit operator decquat(iquat v) => new decquat((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Implicitly converts this to a cquat.
        /// </summary>
        public static implicit operator cquat(iquat v) => new cquat((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a ivec4.
        /// </summary>
        public static explicit operator ivec4(iquat v) => new ivec4((int)v.x, (int)v.y, (int)v.z, (int)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uvec4.
        /// </summary>
        public static explicit operator uvec4(iquat v) => new uvec4((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a uquat.
        /// </summary>
        public static explicit operator uquat(iquat v) => new uquat((uint)v.x, (uint)v.y, (uint)v.z, (uint)v.w);
        
        /// <summary>
        /// Explicitly converts this to a vec4.
        /// </summary>
        public static explicit operator vec4(iquat v) => new vec4((float)v.x, (float)v.y, (float)v.z, (float)v.w);
        
        /// <summary>
        /// Explicitly converts this to a hvec4.
        /// </summary>
        public static explicit operator hvec4(iquat v) => new hvec4((Half)v.x, (Half)v.y, (Half)v.z, (Half)v.w);
        
        /// <summary>
        /// Explicitly converts this to a dvec4.
        /// </summary>
        public static explicit operator dvec4(iquat v) => new dvec4((double)v.x, (double)v.y, (double)v.z, (double)v.w);
        
        /// <summary>
        /// Explicitly converts this to a decvec4.
        /// </summary>
        public static explicit operator decvec4(iquat v) => new decvec4((decimal)v.x, (decimal)v.y, (decimal)v.z, (decimal)v.w);
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(iquat v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);
        
        /// <summary>
        /// Explicitly converts this to a lvec4.
        /// </summary>
        public static explicit operator lvec4(iquat v) => new lvec4((long)v.x, (long)v.y, (long)v.z, (long)v.w);
        
        /// <summary>
        /// Explicitly converts this to a bvec4.
        /// </summary>
        public static explicit operator bvec4(iquat v) => new bvec4(v.x != 0, v.y != 0, v.z != 0, v.w != 0);
        
        /// <summary>
        /// Explicitly converts this to a bquat.
        /// </summary>
        public static explicit operator bquat(iquat v) => new bquat(v.x != 0, v.y != 0, v.z != 0, v.w != 0);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public int this[int index]
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
        public int[] Values => new[] { x, y, z, w };
        
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
        public int LengthSqr => ((x*x + y*y) + (z*z + w*w));
        
        /// <summary>
        /// Returns the conjugated quaternion
        /// </summary>
        public iquat Conjugate => new iquat(-x, -y, -z, w);
        
        /// <summary>
        /// Returns the inverse quaternion
        /// </summary>
        public iquat Inverse => Conjugate / LengthSqr;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero quaternion
        /// </summary>
        public static iquat Zero { get; } = new iquat(0, 0, 0, 0);
        
        /// <summary>
        /// Predefined all-ones quaternion
        /// </summary>
        public static iquat Ones { get; } = new iquat(1, 1, 1, 1);
        
        /// <summary>
        /// Predefined identity quaternion
        /// </summary>
        public static iquat Identity { get; } = new iquat(0, 0, 0, 1);
        
        /// <summary>
        /// Predefined unit-X quaternion
        /// </summary>
        public static iquat UnitX { get; } = new iquat(1, 0, 0, 0);
        
        /// <summary>
        /// Predefined unit-Y quaternion
        /// </summary>
        public static iquat UnitY { get; } = new iquat(0, 1, 0, 0);
        
        /// <summary>
        /// Predefined unit-Z quaternion
        /// </summary>
        public static iquat UnitZ { get; } = new iquat(0, 0, 1, 0);
        
        /// <summary>
        /// Predefined unit-W quaternion
        /// </summary>
        public static iquat UnitW { get; } = new iquat(0, 0, 0, 1);
        
        /// <summary>
        /// Predefined all-MaxValue quaternion
        /// </summary>
        public static iquat MaxValue { get; } = new iquat(int.MaxValue, int.MaxValue, int.MaxValue, int.MaxValue);
        
        /// <summary>
        /// Predefined all-MinValue quaternion
        /// </summary>
        public static iquat MinValue { get; } = new iquat(int.MinValue, int.MinValue, int.MinValue, int.MinValue);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(iquat lhs, iquat rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(iquat lhs, iquat rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns proper multiplication of two quaternions.
        /// </summary>
        public static iquat operator*(iquat p, iquat q) => new iquat(p.w * q.x + p.x * q.w + p.y * q.z - p.z * q.y, p.w * q.y + p.y * q.w + p.z * q.x - p.x * q.z, p.w * q.z + p.z * q.w + p.x * q.y - p.y * q.x, p.w * q.w - p.x * q.x - p.y * q.y - p.z * q.z);
        
        /// <summary>
        /// Returns a vector rotated by the quaternion.
        /// </summary>
        public static ivec3 operator*(iquat q, ivec3 v)
        {
            var qv = new ivec3(q.x, q.y, q.z);
            var uv = ivec3.Cross(qv, v);
            var uuv = ivec3.Cross(qv, uv);
            return v + ((uv * q.w) + uuv) * 2;
        }
        
        /// <summary>
        /// Returns a vector rotated by the quaternion (preserves v.w).
        /// </summary>
        public static ivec4 operator*(iquat q, ivec4 v) => new ivec4(q * new ivec3(v), v.w);
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion.
        /// </summary>
        public static ivec3 operator*(ivec3 v, iquat q) => q.Inverse * v;
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion (preserves v.w).
        /// </summary>
        public static ivec4 operator*(ivec4 v, iquat q) => q.Inverse * v;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<int> GetEnumerator()
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
        public bool Equals(iquat rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is iquat && Equals((iquat) obj);
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

        #endregion


        #region Static Functions
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using ', ' as a separator).
        /// </summary>
        public static iquat Parse(string s) => Parse(s, ", ");
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator).
        /// </summary>
        public static iquat Parse(string s, string sep)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new iquat(int.Parse(kvp[0].Trim()), int.Parse(kvp[1].Trim()), int.Parse(kvp[2].Trim()), int.Parse(kvp[3].Trim()));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a type provider).
        /// </summary>
        public static iquat Parse(string s, string sep, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new iquat(int.Parse(kvp[0].Trim(), provider), int.Parse(kvp[1].Trim(), provider), int.Parse(kvp[2].Trim(), provider), int.Parse(kvp[3].Trim(), provider));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style).
        /// </summary>
        public static iquat Parse(string s, string sep, NumberStyles style)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new iquat(int.Parse(kvp[0].Trim(), style), int.Parse(kvp[1].Trim(), style), int.Parse(kvp[2].Trim(), style), int.Parse(kvp[3].Trim(), style));
        }
        
        /// <summary>
        /// Converts the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider).
        /// </summary>
        public static iquat Parse(string s, string sep, NumberStyles style, IFormatProvider provider)
        {
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) throw new FormatException("input has not exactly 4 parts");
            return new iquat(int.Parse(kvp[0].Trim(), style, provider), int.Parse(kvp[1].Trim(), style, provider), int.Parse(kvp[2].Trim(), style, provider), int.Parse(kvp[3].Trim(), style, provider));
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using ', ' as a separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, out iquat result) => TryParse(s, ", ", out result);
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, out iquat result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            int x = 0, y = 0, z = 0, w = 0;
            var ok = ((int.TryParse(kvp[0].Trim(), out x) && int.TryParse(kvp[1].Trim(), out y)) && (int.TryParse(kvp[2].Trim(), out z) && int.TryParse(kvp[3].Trim(), out w)));
            result = ok ? new iquat(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Tries to convert the string representation of the quaternion into a quaternion representation (using a designated separator and a number style and a format provider), returns false if string was invalid.
        /// </summary>
        public static bool TryParse(string s, string sep, NumberStyles style, IFormatProvider provider, out iquat result)
        {
            result = Zero;
            if (string.IsNullOrEmpty(s)) return false;
            var kvp = s.Split(new[] { sep }, StringSplitOptions.None);
            if (kvp.Length != 4) return false;
            int x = 0, y = 0, z = 0, w = 0;
            var ok = ((int.TryParse(kvp[0].Trim(), style, provider, out x) && int.TryParse(kvp[1].Trim(), style, provider, out y)) && (int.TryParse(kvp[2].Trim(), style, provider, out z) && int.TryParse(kvp[3].Trim(), style, provider, out w)));
            result = ok ? new iquat(x, y, z, w) : Zero;
            return ok;
        }
        
        /// <summary>
        /// Returns the inner product (dot product, scalar product) of the two quaternions.
        /// </summary>
        public static int Dot(iquat lhs, iquat rhs) => ((lhs.x * rhs.x + lhs.y * rhs.y) + (lhs.z * rhs.z + lhs.w * rhs.w));
        
        /// <summary>
        /// Returns the cross product between two quaternions.
        /// </summary>
        public static iquat Cross(iquat q1, iquat q2) => new iquat(q1.w * q2.x + q1.x * q2.w + q1.y * q2.z - q1.z * q2.y, q1.w * q2.y + q1.y * q2.w + q1.z * q2.x - q1.x * q2.z, q1.w * q2.z + q1.z * q2.w + q1.x * q2.y - q1.y * q2.x, q1.w * q2.w - q1.x * q2.x - q1.y * q2.y - q1.z * q2.z);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(iquat lhs, iquat rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(iquat lhs, int rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(int lhs, iquat rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(int lhs, int rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(iquat lhs, iquat rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(iquat lhs, int rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(int lhs, iquat rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(int lhs, int rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(iquat lhs, iquat rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(iquat lhs, int rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(int lhs, iquat rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThan (lhs &gt; rhs).
        /// </summary>
        public static bvec4 GreaterThan(int lhs, int rhs) => new bvec4(lhs > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(iquat lhs, iquat rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(iquat lhs, int rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(int lhs, iquat rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of GreaterThanEqual (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 GreaterThanEqual(int lhs, int rhs) => new bvec4(lhs >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(iquat lhs, iquat rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(iquat lhs, int rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(int lhs, iquat rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThan (lhs &lt; rhs).
        /// </summary>
        public static bvec4 LesserThan(int lhs, int rhs) => new bvec4(lhs < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(iquat lhs, iquat rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(iquat lhs, int rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(int lhs, iquat rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of LesserThanEqual (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 LesserThanEqual(int lhs, int rhs) => new bvec4(lhs <= rhs);
        
        /// <summary>
        /// Returns a iquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static iquat Lerp(iquat min, iquat max, iquat a) => new iquat(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static iquat Lerp(iquat min, iquat max, int a) => new iquat(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a iquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static iquat Lerp(iquat min, int max, iquat a) => new iquat(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static iquat Lerp(iquat min, int max, int a) => new iquat(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a iquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static iquat Lerp(int min, iquat max, iquat a) => new iquat(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static iquat Lerp(int min, iquat max, int a) => new iquat(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a iquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static iquat Lerp(int min, int max, iquat a) => new iquat(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a iquat from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static iquat Lerp(int min, int max, int a) => new iquat(min * (1-a) + max * a);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(iquat lhs, iquat rhs) => new bvec4(lhs.x < rhs.x, lhs.y < rhs.y, lhs.z < rhs.z, lhs.w < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(iquat lhs, int rhs) => new bvec4(lhs.x < rhs, lhs.y < rhs, lhs.z < rhs, lhs.w < rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt; (lhs &lt; rhs).
        /// </summary>
        public static bvec4 operator<(int lhs, iquat rhs) => new bvec4(lhs < rhs.x, lhs < rhs.y, lhs < rhs.z, lhs < rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(iquat lhs, iquat rhs) => new bvec4(lhs.x <= rhs.x, lhs.y <= rhs.y, lhs.z <= rhs.z, lhs.w <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(iquat lhs, int rhs) => new bvec4(lhs.x <= rhs, lhs.y <= rhs, lhs.z <= rhs, lhs.w <= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&lt;= (lhs &lt;= rhs).
        /// </summary>
        public static bvec4 operator<=(int lhs, iquat rhs) => new bvec4(lhs <= rhs.x, lhs <= rhs.y, lhs <= rhs.z, lhs <= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(iquat lhs, iquat rhs) => new bvec4(lhs.x > rhs.x, lhs.y > rhs.y, lhs.z > rhs.z, lhs.w > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(iquat lhs, int rhs) => new bvec4(lhs.x > rhs, lhs.y > rhs, lhs.z > rhs, lhs.w > rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt; (lhs &gt; rhs).
        /// </summary>
        public static bvec4 operator>(int lhs, iquat rhs) => new bvec4(lhs > rhs.x, lhs > rhs.y, lhs > rhs.z, lhs > rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(iquat lhs, iquat rhs) => new bvec4(lhs.x >= rhs.x, lhs.y >= rhs.y, lhs.z >= rhs.z, lhs.w >= rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(iquat lhs, int rhs) => new bvec4(lhs.x >= rhs, lhs.y >= rhs, lhs.z >= rhs, lhs.w >= rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of operator&gt;= (lhs &gt;= rhs).
        /// </summary>
        public static bvec4 operator>=(int lhs, iquat rhs) => new bvec4(lhs >= rhs.x, lhs >= rhs.y, lhs >= rhs.z, lhs >= rhs.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator+ (identity).
        /// </summary>
        public static iquat operator+(iquat v) => v;
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator- (-v).
        /// </summary>
        public static iquat operator-(iquat v) => new iquat(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static iquat operator+(iquat lhs, iquat rhs) => new iquat(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static iquat operator+(iquat lhs, int rhs) => new iquat(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static iquat operator+(int lhs, iquat rhs) => new iquat(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static iquat operator-(iquat lhs, iquat rhs) => new iquat(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static iquat operator-(iquat lhs, int rhs) => new iquat(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static iquat operator-(int lhs, iquat rhs) => new iquat(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static iquat operator*(iquat lhs, int rhs) => new iquat(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static iquat operator*(int lhs, iquat rhs) => new iquat(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a iquat from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static iquat operator/(iquat lhs, int rhs) => new iquat(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

        #endregion

    }
}
