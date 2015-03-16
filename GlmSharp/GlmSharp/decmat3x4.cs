using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct decmat3x4 : IEnumerable<decimal>, IEquatable<decmat3x4>
    {
        // Matrix fields mXY
        public decimal m00, m01, m02, m03; // Column 0
        public decimal m10, m11, m12, m13; // Column 1
        public decimal m20, m21, m22, m23; // Column 2
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public decimal[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 }, { m20, m21, m22, m23 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public decimal[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public decvec4 Column0 => new decvec4(m00, m01, m02, m03);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public decvec4 Column1 => new decvec4(m10, m11, m12, m13);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public decvec4 Column2 => new decvec4(m20, m21, m22, m23);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public decvec3 Row0 => new decvec3(m00, m10, m20);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public decvec3 Row1 => new decvec3(m01, m11, m21);
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public decvec3 Row2 => new decvec3(m02, m12, m22);
        
        /// <summary>
        /// Returns the row nr 3
        /// </summary>
        public decvec3 Row3 => new decvec3(m03, m13, m23);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly decmat3x4 Zero = new decmat3x4(default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal), default(decimal));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly decmat3x4 Ones = new decmat3x4(1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly decmat3x4 Identity = new decmat3x4(1m, default(decimal), default(decimal), default(decimal), default(decimal), 1m, default(decimal), default(decimal), default(decimal), default(decimal), 1m, default(decimal));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public decmat3x4(decimal m00, decimal m01, decimal m02, decimal m03, decimal m10, decimal m11, decimal m12, decimal m13, decimal m20, decimal m21, decimal m22, decimal m23)
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
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public decmat3x4(decmat3x4 m)
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
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public decmat3x4(decvec4 c0, decvec4 c1, decvec4 c2)
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
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<decimal> GetEnumerator()
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
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(decmat3x4 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m02.Equals(rhs.m02) && m03.Equals(rhs.m03) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m12.Equals(rhs.m12) && m13.Equals(rhs.m13) && m20.Equals(rhs.m20) && m21.Equals(rhs.m21) && m22.Equals(rhs.m22) && m23.Equals(rhs.m23);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is decmat3x4 && Equals((decmat3x4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(decmat3x4 lhs, decmat3x4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(decmat3x4 lhs, decmat3x4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m02.GetHashCode()) * 397) ^ m03.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m12.GetHashCode()) * 397) ^ m13.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode()) * 397) ^ m22.GetHashCode()) * 397) ^ m23.GetHashCode();
            }
        }
    }
}
