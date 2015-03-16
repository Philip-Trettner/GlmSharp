using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct lmat2x4 : IEnumerable<long>, IEquatable<lmat2x4>
    {
        // Matrix fields mXY
        public long m00, m01, m02, m03; // Column 0
        public long m10, m11, m12, m13; // Column 1
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public long[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public long[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public lvec4 Column0 => new lvec4(m00, m01, m02, m03);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public lvec4 Column1 => new lvec4(m10, m11, m12, m13);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public lvec2 Row0 => new lvec2(m00, m10);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public lvec2 Row1 => new lvec2(m01, m11);
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public lvec2 Row2 => new lvec2(m02, m12);
        
        /// <summary>
        /// Returns the row nr 3
        /// </summary>
        public lvec2 Row3 => new lvec2(m03, m13);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly lmat2x4 Zero = new lmat2x4(default(long), default(long), default(long), default(long), default(long), default(long), default(long), default(long));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly lmat2x4 Ones = new lmat2x4(1, 1, 1, 1, 1, 1, 1, 1);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly lmat2x4 Identity = new lmat2x4(1, default(long), default(long), default(long), default(long), 1, default(long), default(long));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public lmat2x4(long m00, long m01, long m02, long m03, long m10, long m11, long m12, long m13)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m03 = m03;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public lmat2x4(lmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public lmat2x4(lvec4 c0, lvec4 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<long> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m02;
            yield return m03;
            yield return m10;
            yield return m11;
            yield return m12;
            yield return m13;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(lmat2x4 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m02.Equals(rhs.m02) && m03.Equals(rhs.m03) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m12.Equals(rhs.m12) && m13.Equals(rhs.m13);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is lmat2x4 && Equals((lmat2x4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(lmat2x4 lhs, lmat2x4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(lmat2x4 lhs, lmat2x4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m02.GetHashCode()) * 397) ^ m03.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m12.GetHashCode()) * 397) ^ m13.GetHashCode();
            }
        }
    }
}
