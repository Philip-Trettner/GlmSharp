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
    /// A quaternion of type Complex.
    /// </summary>
    [Serializable]
    [DataContract]
    [StructLayout(LayoutKind.Sequential)]
    public struct cquat : IReadOnlyList<Complex>, IEquatable<cquat>
    {

        #region Fields
        
        /// <summary>
        /// x-component
        /// </summary>
        [DataMember]
        public Complex x;
        
        /// <summary>
        /// y-component
        /// </summary>
        [DataMember]
        public Complex y;
        
        /// <summary>
        /// z-component
        /// </summary>
        [DataMember]
        public Complex z;
        
        /// <summary>
        /// w-component
        /// </summary>
        [DataMember]
        public Complex w;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public cquat(Complex x, Complex y, Complex z, Complex w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w;
        }
        
        /// <summary>
        /// all-same-value constructor
        /// </summary>
        public cquat(Complex v)
        {
            this.x = v;
            this.y = v;
            this.z = v;
            this.w = v;
        }
        
        /// <summary>
        /// copy constructor
        /// </summary>
        public cquat(cquat q)
        {
            this.x = q.x;
            this.y = q.y;
            this.z = q.z;
            this.w = q.w;
        }
        
        /// <summary>
        /// vector-and-scalar constructor (CAUTION: not angle-axis, use FromAngleAxis instead)
        /// </summary>
        public cquat(cvec3 v, Complex s)
        {
            this.x = v.x;
            this.y = v.y;
            this.z = v.z;
            this.w = s;
        }

        #endregion


        #region Explicit Operators
        
        /// <summary>
        /// Explicitly converts this to a cvec4.
        /// </summary>
        public static explicit operator cvec4(cquat v) => new cvec4((Complex)v.x, (Complex)v.y, (Complex)v.z, (Complex)v.w);

        #endregion


        #region Indexer
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public Complex this[int index]
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
        public Complex[] Values => new[] { x, y, z, w };
        
        /// <summary>
        /// Returns the number of components (4).
        /// </summary>
        public int Count => 4;
        
        /// <summary>
        /// Returns the euclidean length of this quaternion.
        /// </summary>
        public double Length => (double)Math.Sqrt(((x.LengthSqr() + y.LengthSqr()) + (z.LengthSqr() + w.LengthSqr())));
        
        /// <summary>
        /// Returns the squared euclidean length of this quaternion.
        /// </summary>
        public Complex LengthSqr => ((x.LengthSqr() + y.LengthSqr()) + (z.LengthSqr() + w.LengthSqr()));
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (undefined if this has zero length).
        /// </summary>
        public cquat Normalized => this / (Complex)Length;
        
        /// <summary>
        /// Returns a copy of this quaternion with length one (returns zero if length is zero).
        /// </summary>
        public cquat NormalizedSafe => this == Zero ? Identity : this / (Complex)Length;
        
        /// <summary>
        /// Returns the conjugated quaternion
        /// </summary>
        public cquat Conjugate => new cquat(-x, -y, -z, w);
        
        /// <summary>
        /// Returns the inverse quaternion
        /// </summary>
        public cquat Inverse => Conjugate / LengthSqr;

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero quaternion
        /// </summary>
        public static cquat Zero { get; } = new cquat(Complex.Zero, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined all-ones quaternion
        /// </summary>
        public static cquat Ones { get; } = new cquat(Complex.One, Complex.One, Complex.One, Complex.One);
        
        /// <summary>
        /// Predefined identity quaternion
        /// </summary>
        public static cquat Identity { get; } = new cquat(Complex.Zero, Complex.Zero, Complex.Zero, Complex.One);
        
        /// <summary>
        /// Predefined unit-X quaternion
        /// </summary>
        public static cquat UnitX { get; } = new cquat(Complex.One, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-Y quaternion
        /// </summary>
        public static cquat UnitY { get; } = new cquat(Complex.Zero, Complex.One, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-Z quaternion
        /// </summary>
        public static cquat UnitZ { get; } = new cquat(Complex.Zero, Complex.Zero, Complex.One, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-W quaternion
        /// </summary>
        public static cquat UnitW { get; } = new cquat(Complex.Zero, Complex.Zero, Complex.Zero, Complex.One);
        
        /// <summary>
        /// Predefined all-imaginary-ones quaternion
        /// </summary>
        public static cquat ImaginaryOnes { get; } = new cquat(Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne, Complex.ImaginaryOne);
        
        /// <summary>
        /// Predefined unit-imaginary-X quaternion
        /// </summary>
        public static cquat ImaginaryUnitX { get; } = new cquat(Complex.ImaginaryOne, Complex.Zero, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-imaginary-Y quaternion
        /// </summary>
        public static cquat ImaginaryUnitY { get; } = new cquat(Complex.Zero, Complex.ImaginaryOne, Complex.Zero, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-imaginary-Z quaternion
        /// </summary>
        public static cquat ImaginaryUnitZ { get; } = new cquat(Complex.Zero, Complex.Zero, Complex.ImaginaryOne, Complex.Zero);
        
        /// <summary>
        /// Predefined unit-imaginary-W quaternion
        /// </summary>
        public static cquat ImaginaryUnitW { get; } = new cquat(Complex.Zero, Complex.Zero, Complex.Zero, Complex.ImaginaryOne);

        #endregion


        #region Operators
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator==(cquat lhs, cquat rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator!=(cquat lhs, cquat rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns proper multiplication of two quaternions.
        /// </summary>
        public static cquat operator*(cquat p, cquat q) => new cquat(p.w * q.x + p.x * q.w + p.y * q.z - p.z * q.y, p.w * q.y + p.y * q.w + p.z * q.x - p.x * q.z, p.w * q.z + p.z * q.w + p.x * q.y - p.y * q.x, p.w * q.w - p.x * q.x - p.y * q.y - p.z * q.z);
        
        /// <summary>
        /// Returns a vector rotated by the quaternion.
        /// </summary>
        public static cvec3 operator*(cquat q, cvec3 v)
        {
            var qv = new cvec3(q.x, q.y, q.z);
            var uv = cvec3.Cross(qv, v);
            var uuv = cvec3.Cross(qv, uv);
            return v + ((uv * q.w) + uuv) * 2;
        }
        
        /// <summary>
        /// Returns a vector rotated by the quaternion (preserves v.w).
        /// </summary>
        public static cvec4 operator*(cquat q, cvec4 v) => new cvec4(q * new cvec3(v), v.w);
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion.
        /// </summary>
        public static cvec3 operator*(cvec3 v, cquat q) => q.Inverse * v;
        
        /// <summary>
        /// Returns a vector rotated by the inverted quaternion (preserves v.w).
        /// </summary>
        public static cvec4 operator*(cvec4 v, cquat q) => q.Inverse * v;

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<Complex> GetEnumerator()
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
        public bool Equals(cquat rhs) => ((x.Equals(rhs.x) && y.Equals(rhs.y)) && (z.Equals(rhs.z) && w.Equals(rhs.w)));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is cquat && Equals((cquat) obj);
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
        /// Returns the inner product (dot product, scalar product) of the two quaternions.
        /// </summary>
        public static Complex Dot(cquat lhs, cquat rhs) => ((lhs.x * Complex.Conjugate(rhs.x) + lhs.y * Complex.Conjugate(rhs.y)) + (lhs.z * Complex.Conjugate(rhs.z) + lhs.w * Complex.Conjugate(rhs.w)));
        
        /// <summary>
        /// Returns the cross product between two quaternions.
        /// </summary>
        public static cquat Cross(cquat q1, cquat q2) => new cquat(q1.w * q2.x + q1.x * q2.w + q1.y * q2.z - q1.z * q2.y, q1.w * q2.y + q1.y * q2.w + q1.z * q2.x - q1.x * q2.z, q1.w * q2.z + q1.z * q2.w + q1.x * q2.y - q1.y * q2.x, q1.w * q2.w - q1.x * q2.x - q1.y * q2.y - q1.z * q2.z);

        #endregion


        #region Component-Wise Static Functions
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(cquat lhs, cquat rhs) => new bvec4(lhs.x == rhs.x, lhs.y == rhs.y, lhs.z == rhs.z, lhs.w == rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(cquat lhs, Complex rhs) => new bvec4(lhs.x == rhs, lhs.y == rhs, lhs.z == rhs, lhs.w == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(Complex lhs, cquat rhs) => new bvec4(lhs == rhs.x, lhs == rhs.y, lhs == rhs.z, lhs == rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of Equal (lhs == rhs).
        /// </summary>
        public static bvec4 Equal(Complex lhs, Complex rhs) => new bvec4(lhs == rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(cquat lhs, cquat rhs) => new bvec4(lhs.x != rhs.x, lhs.y != rhs.y, lhs.z != rhs.z, lhs.w != rhs.w);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(cquat lhs, Complex rhs) => new bvec4(lhs.x != rhs, lhs.y != rhs, lhs.z != rhs, lhs.w != rhs);
        
        /// <summary>
        /// Returns a bvec4 from component-wise application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(Complex lhs, cquat rhs) => new bvec4(lhs != rhs.x, lhs != rhs.y, lhs != rhs.z, lhs != rhs.w);
        
        /// <summary>
        /// Returns a bvec from the application of NotEqual (lhs != rhs).
        /// </summary>
        public static bvec4 NotEqual(Complex lhs, Complex rhs) => new bvec4(lhs != rhs);
        
        /// <summary>
        /// Returns a cquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static cquat Lerp(cquat min, cquat max, cquat a) => new cquat(min.x * (1-a.x) + max.x * a.x, min.y * (1-a.y) + max.y * a.y, min.z * (1-a.z) + max.z * a.z, min.w * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a cquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static cquat Lerp(cquat min, cquat max, Complex a) => new cquat(min.x * (1-a) + max.x * a, min.y * (1-a) + max.y * a, min.z * (1-a) + max.z * a, min.w * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a cquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static cquat Lerp(cquat min, Complex max, cquat a) => new cquat(min.x * (1-a.x) + max * a.x, min.y * (1-a.y) + max * a.y, min.z * (1-a.z) + max * a.z, min.w * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a cquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static cquat Lerp(cquat min, Complex max, Complex a) => new cquat(min.x * (1-a) + max * a, min.y * (1-a) + max * a, min.z * (1-a) + max * a, min.w * (1-a) + max * a);
        
        /// <summary>
        /// Returns a cquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static cquat Lerp(Complex min, cquat max, cquat a) => new cquat(min * (1-a.x) + max.x * a.x, min * (1-a.y) + max.y * a.y, min * (1-a.z) + max.z * a.z, min * (1-a.w) + max.w * a.w);
        
        /// <summary>
        /// Returns a cquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static cquat Lerp(Complex min, cquat max, Complex a) => new cquat(min * (1-a) + max.x * a, min * (1-a) + max.y * a, min * (1-a) + max.z * a, min * (1-a) + max.w * a);
        
        /// <summary>
        /// Returns a cquat from component-wise application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static cquat Lerp(Complex min, Complex max, cquat a) => new cquat(min * (1-a.x) + max * a.x, min * (1-a.y) + max * a.y, min * (1-a.z) + max * a.z, min * (1-a.w) + max * a.w);
        
        /// <summary>
        /// Returns a cquat from the application of Lerp (min * (1-a) + max * a).
        /// </summary>
        public static cquat Lerp(Complex min, Complex max, Complex a) => new cquat(min * (1-a) + max * a);

        #endregion


        #region Component-Wise Operator Overloads
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator+ (identity).
        /// </summary>
        public static cquat operator+(cquat v) => v;
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator- (-v).
        /// </summary>
        public static cquat operator-(cquat v) => new cquat(-v.x, -v.y, -v.z, -v.w);
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static cquat operator+(cquat lhs, cquat rhs) => new cquat(lhs.x + rhs.x, lhs.y + rhs.y, lhs.z + rhs.z, lhs.w + rhs.w);
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static cquat operator+(cquat lhs, Complex rhs) => new cquat(lhs.x + rhs, lhs.y + rhs, lhs.z + rhs, lhs.w + rhs);
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator+ (lhs + rhs).
        /// </summary>
        public static cquat operator+(Complex lhs, cquat rhs) => new cquat(lhs + rhs.x, lhs + rhs.y, lhs + rhs.z, lhs + rhs.w);
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static cquat operator-(cquat lhs, cquat rhs) => new cquat(lhs.x - rhs.x, lhs.y - rhs.y, lhs.z - rhs.z, lhs.w - rhs.w);
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static cquat operator-(cquat lhs, Complex rhs) => new cquat(lhs.x - rhs, lhs.y - rhs, lhs.z - rhs, lhs.w - rhs);
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator- (lhs - rhs).
        /// </summary>
        public static cquat operator-(Complex lhs, cquat rhs) => new cquat(lhs - rhs.x, lhs - rhs.y, lhs - rhs.z, lhs - rhs.w);
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static cquat operator*(cquat lhs, Complex rhs) => new cquat(lhs.x * rhs, lhs.y * rhs, lhs.z * rhs, lhs.w * rhs);
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator* (lhs * rhs).
        /// </summary>
        public static cquat operator*(Complex lhs, cquat rhs) => new cquat(lhs * rhs.x, lhs * rhs.y, lhs * rhs.z, lhs * rhs.w);
        
        /// <summary>
        /// Returns a cquat from component-wise application of operator/ (lhs / rhs).
        /// </summary>
        public static cquat operator/(cquat lhs, Complex rhs) => new cquat(lhs.x / rhs, lhs.y / rhs, lhs.z / rhs, lhs.w / rhs);

        #endregion

    }
}
