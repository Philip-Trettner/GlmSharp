using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Numerics;
using System.Linq;

// ReSharper disable InconsistentNaming

namespace GlmSharp
{
    
    /// <summary>
    /// A matrix of type bool with 2 columns and 4 rows.
    /// </summary>
    [Serializable]
    public struct bmat2x4 : IReadOnlyList<bool>, IEquatable<bmat2x4>
    {
        // Matrix fields mXY
        
        /// <summary>
        /// Column 0
        /// </summary>
        public bool m00, m01, m02, m03; // 
        
        /// <summary>
        /// Column 1
        /// </summary>
        public bool m10, m11, m12, m13; // 
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public bool[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public bool[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public bvec4 Column0 => new bvec4(m00, m01, m02, m03);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public bvec4 Column1 => new bvec4(m10, m11, m12, m13);
        
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
        /// Returns the row nr 3
        /// </summary>
        public bvec2 Row3 => new bvec2(m03, m13);
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static bmat2x4 Zero { get; } = new bmat2x4(default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool), default(bool));
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static bmat2x4 Ones { get; } = new bmat2x4(true, true, true, true, true, true, true, true);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static bmat2x4 Identity { get; } = new bmat2x4(true, default(bool), default(bool), default(bool), default(bool), true, default(bool), default(bool));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public bmat2x4(bool m00, bool m01, bool m02, bool m03, bool m10, bool m11, bool m12, bool m13)
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
        public bmat2x4(bmat2x4 m)
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
        public bmat2x4(bvec4 c0, bvec4 c1)
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
        /// Returns an enumerator that iterates through all FieldCount.
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
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all FieldCount.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of FieldCount (8).
        /// </summary>
        public int Count => 8;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m02;
                    case 3: return m03;
                    case 4: return m10;
                    case 5: return m11;
                    case 6: return m12;
                    case 7: return m13;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
            set
            {
                switch (fieldIndex)
                {
                    case 0: this.m00 = value; break;
                    case 1: this.m01 = value; break;
                    case 2: this.m02 = value; break;
                    case 3: this.m03 = value; break;
                    case 4: this.m10 = value; break;
                    case 5: this.m11 = value; break;
                    case 6: this.m12 = value; break;
                    case 7: this.m13 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public bool this[int col, int row]
        {
            get
            {
                return this[col * 4 + row];
            }
            set
            {
                this[col * 4 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(bmat2x4 rhs) => m00.Equals(rhs.m00) && m01.Equals(rhs.m01) && m02.Equals(rhs.m02) && m03.Equals(rhs.m03) && m10.Equals(rhs.m10) && m11.Equals(rhs.m11) && m12.Equals(rhs.m12) && m13.Equals(rhs.m13);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is bmat2x4 && Equals((bmat2x4) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(bmat2x4 lhs, bmat2x4 rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(bmat2x4 lhs, bmat2x4 rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((m00.GetHashCode()) * 2) ^ m01.GetHashCode()) * 2) ^ m02.GetHashCode()) * 2) ^ m03.GetHashCode()) * 2) ^ m10.GetHashCode()) * 2) ^ m11.GetHashCode()) * 2) ^ m12.GetHashCode()) * 2) ^ m13.GetHashCode();
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public bmat4x2 Transposed => new bmat4x2(m00, m10, m01, m11, m02, m12, m03, m13);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public bool MinElement => m00 && m01 && m02 && m03 && m10 && m11 && m12 && m13;
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public bool MaxElement => m00 || m01 || m02 || m03 || m10 || m11 || m12 || m13;
        
        /// <summary>
        /// Returns true if all component are true.
        /// </summary>
        public bool All => m00 && m01 && m02 && m03 && m10 && m11 && m12 && m13;
        
        /// <summary>
        /// Returns true if any component is true.
        /// </summary>
        public bool Any => m00 || m01 || m02 || m03 || m10 || m11 || m12 || m13;
        
        /// <summary>
        /// Executes a component-wise &amp;&amp;. (sorry for different overload but &amp;&amp; cannot be overloaded directly)
        /// </summary>
        public static bmat2x4 operator&(bmat2x4 lhs, bmat2x4 rhs) => new bmat2x4(lhs.m00 && rhs.m00, lhs.m01 && rhs.m01, lhs.m02 && rhs.m02, lhs.m03 && rhs.m03, lhs.m10 && rhs.m10, lhs.m11 && rhs.m11, lhs.m12 && rhs.m12, lhs.m13 && rhs.m13);
        
        /// <summary>
        /// Executes a component-wise ||. (sorry for different overload but || cannot be overloaded directly)
        /// </summary>
        public static bmat2x4 operator|(bmat2x4 lhs, bmat2x4 rhs) => new bmat2x4(lhs.m00 || rhs.m00, lhs.m01 || rhs.m01, lhs.m02 || rhs.m02, lhs.m03 || rhs.m03, lhs.m10 || rhs.m10, lhs.m11 || rhs.m11, lhs.m12 || rhs.m12, lhs.m13 || rhs.m13);
    }
}
