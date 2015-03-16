using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct decmat4x3 : IEnumerable<decimal>, IEquatable<decmat4x3>
    {
        // Matrix fields mXY
        public decimal m00, m01, m02; // Column 0
        public decimal m10, m11, m12; // Column 1
        public decimal m20, m21, m22; // Column 2
        public decimal m30, m31, m32; // Column 3
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public decimal[,] Values => new[,] { { m00, m01, m02 }, { m10, m11, m12 }, { m20, m21, m22 }, { m30, m31, m32 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public decimal[] Values1D => new[] { m00, m01, m02, m10, m11, m12, m20, m21, m22, m30, m31, m32 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public decvec3 Column0 => new decvec3(m00, m01, m02);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public decvec3 Column1 => new decvec3(m10, m11, m12);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public decvec3 Column2 => new decvec3(m20, m21, m22);
        
        /// <summary>
        /// Returns the column nr 3
        /// </summary>
        public decvec3 Column3 => new decvec3(m30, m31, m32);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public decvec4 Row0 => new decvec4(m00, m10, m20, m30);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public decvec4 Row1 => new decvec4(m01, m11, m21, m31);
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public decvec4 Row2 => new decvec4(m02, m12, m22, m32);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly decmat4x3 Zero = new decmat4x3(default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly decmat4x3 Ones = new decmat4x3(1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly decmat4x3 Identity = new decmat4x3(1m, default(decimal), default(decimal), default(decimal), 1m, default(decimal), default(decimal), default(decimal), 1m, default(decimal), default(decimal), default(decimal));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public decmat4x3(decimal m00, decimal m01, decimal m02, decimal m10, decimal m11, decimal m12, decimal m20, decimal m21, decimal m22, decimal m30, decimal m31, decimal m32)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public decmat4x3(decmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = m.m32;
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public decmat4x3(decvec3 c0, decvec3 c1, decvec3 c2, decvec3 c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = c3.z;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<decimal> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m02;
            yield return m10;
            yield return m11;
            yield return m12;
            yield return m20;
            yield return m21;
            yield return m22;
            yield return m30;
            yield return m31;
            yield return m32;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(decmat4x3 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m02.Equals(rhs.m02) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m12.Equals(rhs.m12) && m20.Equals(rhs.m20) && m21.Equals(rhs.m21) && m22.Equals(rhs.m22) && m30.Equals(rhs.m30) && m31.Equals(rhs.m31) && m32.Equals(rhs.m32);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is decmat4x3 && Equals((decmat4x3) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(decmat4x3 lhs, decmat4x3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(decmat4x3 lhs, decmat4x3 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m02.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m12.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m22.GetHashCode()) * 397) ^ m30.GetHashCode()) * 397) ^ m31.GetHashCode()) * 397) ^ m32.GetHashCode();
            }
        }
    }
}
