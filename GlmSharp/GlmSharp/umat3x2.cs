using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct umat3x2 : IEnumerable<uint>, IEquatable<umat3x2>
    {
        // Matrix fields mXY
        public uint m00, m01; // Column 0
        public uint m10, m11; // Column 1
        public uint m20, m21; // Column 2
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public uint[,] Values => new[,] { { m00, m01 }, { m10, m11 }, { m20, m21 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public uint[] Values1D => new[] { m00, m01, m10, m11, m20, m21 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public uvec2 Column0 => new uvec2(m00, m01);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public uvec2 Column1 => new uvec2(m10, m11);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public uvec2 Column2 => new uvec2(m20, m21);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public uvec3 Row0 => new uvec3(m00, m10, m20);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public uvec3 Row1 => new uvec3(m01, m11, m21);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly umat3x2 Zero = new umat3x2(default(uint), default(uint), default(uint), default(uint), default(uint), default(uint));
        
        /// <summary>
        /// Predefined all-ones matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly umat3x2 Ones = new umat3x2(1, 1, 1, 1, 1, 1);
        
        /// <summary>
        /// Predefined identity matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly umat3x2 Identity = new umat3x2(1, default(uint), default(uint), 1, default(uint), default(uint));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public umat3x2(uint m00, uint m01, uint m10, uint m11, uint m20, uint m21)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m10 = m10;
            this.m11 = m11;
            this.m20 = m20;
            this.m21 = m21;
        }
        
        /// <summary>
        /// Copy constructor
        /// </summary>
        public umat3x2(umat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m20 = m.m20;
            this.m21 = m.m21;
        }
        
        /// <summary>
        /// Column constructor
        /// </summary>
        public umat3x2(uvec2 c0, uvec2 c1, uvec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = c2.x;
            this.m21 = c2.y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        public IEnumerator<uint> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m10;
            yield return m11;
            yield return m20;
            yield return m21;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all components.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(umat3x2 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m20.Equals(rhs.m20) && m21.Equals(rhs.m21);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is umat3x2 && Equals((umat3x2) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(umat3x2 lhs, umat3x2 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(umat3x2 lhs, umat3x2 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((m00.GetHashCode()) * 397) ^ m01.GetHashCode()) * 397) ^ m10.GetHashCode()) * 397) ^ m11.GetHashCode()) * 397) ^ m20.GetHashCode()) * 397) ^ m21.GetHashCode();
            }
        }
    }
}
