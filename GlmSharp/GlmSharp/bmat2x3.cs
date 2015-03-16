using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct bmat2x3 : IEnumerable<bool>, IEquatable<bmat2x3>
    {
        // Matrix fields mXY
        public bool m00, m01, m02; // Column 0
        public bool m10, m11, m12; // Column 1
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public bool[,] Values => new[,] { { m00, m01, m02 }, { m10, m11, m12 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public bool[] Values1D => new[] { m00, m01, m02, m10, m11, m12 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public bvec3 Column0 => new bvec3(m00, m01, m02);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public bvec3 Column1 => new bvec3(m10, m11, m12);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public bvec2 Row0 => new bvec2(m00, m10);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public bvec2 Row1 => new bvec2(m01, m11);
        
        /// <summary>
        /// Returns the row nr 2
        /// </summary>
        public bvec2 Row2 => new bvec2(m02, m12);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly bmat2x3 Zero = new bmat2x3(default(bool), default(bool), default(bool), default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly bmat2x3 Ones = new bmat2x3(true, true, true, true, true, true);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly bmat2x3 Identity = new bmat2x3(true, default(bool), default(bool), default(bool), true, default(bool));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bmat2x3(bool m00, bool m01, bool m02, bool m10, bool m11, bool m12)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public bmat2x3(bmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public bmat2x3(bvec3 c0, bvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<bool> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m02;
            yield return m10;
            yield return m11;
            yield return m12;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bmat2x3 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m02.Equals(rhs.m02) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m12.Equals(rhs.m12);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bmat2x3 && Equals((bmat2x3) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bmat2x3 lhs, bmat2x3 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bmat2x3 lhs, bmat2x3 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((m00.GetHashCode()) * 2) ^ m01.GetHashCode()) * 2) ^ m02.GetHashCode()) * 2) ^ m10.GetHashCode()) * 2) ^ m11.GetHashCode()) * 2) ^ m12.GetHashCode();
            }
        }
    }
}