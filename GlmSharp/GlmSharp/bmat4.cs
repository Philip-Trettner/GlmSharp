using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct bmat4 : IEnumerable<bool>, IEquatable<bmat4>
    {
        // Matrix fields mXY
        public bool m00, m01, m02, m03; // Column 0
        public bool m10, m11, m12, m13; // Column 1
        public bool m20, m21, m22, m23; // Column 2
        public bool m30, m31, m32, m33; // Column 3
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public bool[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 }, { m20, m21, m22, m23 }, { m30, m31, m32, m33 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public bool[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23, m30, m31, m32, m33 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public bvec4 Column0 => new bvec4(m00, m01, m02, m03);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public bvec4 Column1 => new bvec4(m10, m11, m12, m13);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public bvec4 Column2 => new bvec4(m20, m21, m22, m23);
        
        /// <summary>
        /// Returns the column nr 3
        /// </summary>
        public bvec4 Column3 => new bvec4(m30, m31, m32, m33);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public bvec4 Row0 => new bvec4(m00, m10, m20, m30);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public bvec4 Row1 => new bvec4(m01, m11, m21, m31);
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public bvec4 Row2 => new bvec4(m02, m12, m22, m32);
        
        /// <summary>
        /// Returns the row nr 3
        /// </summary>
        public bvec4 Row3 => new bvec4(m03, m13, m23, m33);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly bmat4 Zero = new bmat4(default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly bmat4 Ones = new bmat4(true, true, true, true, true, true, true, true, true, true, true, true, true, true, true, true);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly bmat4 Identity = new bmat4(true, default(bool), default(bool), default(bool), default(bool), true, default(bool), default(bool), default(bool), default(bool), true, default(bool), default(bool), default(bool), default(bool), true);
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bmat4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13, bool m20, bool m21, bool m22, bool m23, bool m30, bool m31, bool m32, bool m33)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m03 = m03;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public bmat4(bmat4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = m.m23;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
            this.m33 = m.m33;
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public bmat4(bvec4 c0, bvec4 c1, bvec4 c2, bvec4 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = c2.w;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
            this.m33 = c3.w;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m02;
            yield return m03;
            yield return m10;
            yield return m11;
            yield return m12;
            yield return m13;
            yield return m20;
            yield return m21;
            yield return m22;
            yield return m23;
            yield return m30;
            yield return m31;
            yield return m32;
            yield return m33;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bmat4 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m02.Equals(rhs.m02) && m03.Equals(rhs.m03) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m12.Equals(rhs.m12) && m13.Equals(rhs.m13) && m20.Equals(rhs.m20) && m21.Equals(rhs.m21) && m22.Equals(rhs.m22) && m23.Equals(rhs.m23) && m30.Equals(rhs.m30) && m31.Equals(rhs.m31) && m32.Equals(rhs.m32) && m33.Equals(rhs.m33);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bmat4 && Equals((bmat4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bmat4 lhs, bmat4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bmat4 lhs, bmat4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((((((((((m00.GetHashCode()) * 2) ^ m01.GetHashCode()) * 2) ^ m02.GetHashCode()) * 2) ^ m03.GetHashCode()) * 2) ^ m10.GetHashCode()) * 2) ^ m11.GetHashCode()) * 2) ^ m12.GetHashCode()) * 2) ^ m13.GetHashCode()) * 2) ^ m20.GetHashCode()) * 2) ^ m21.GetHashCode()) * 2) ^ m22.GetHashCode()) * 2) ^ m23.GetHashCode()) * 2) ^ m30.GetHashCode()) * 2) ^ m31.GetHashCode()) * 2) ^ m32.GetHashCode()) * 2) ^ m33.GetHashCode();
            }
        }
    }
}
