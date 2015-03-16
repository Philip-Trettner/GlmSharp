using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Linq;

namespace GlmSharp
{
    [Serializable]
    public struct gmat3x2<T> : IReadOnlyList<T>, IEquatable<gmat3x2<T>>
    {
        // Matrix fields mXY
        public T m00, m01; // Column 0
        public T m10, m11; // Column 1
        public T m20, m21; // Column 2
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public T[,] Values => new[,] { { m00, m01 }, { m10, m11 }, { m20, m21 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public T[] Values1D => new[] { m00, m01, m10, m11, m20, m21 };
        
        /// <summary>
        /// Returns the column nr 0
        /// </summary>
        public gvec2<T> Column0 => new gvec2<T>(m00, m01);
        
        /// <summary>
        /// Returns the column nr 1
        /// </summary>
        public gvec2<T> Column1 => new gvec2<T>(m10, m11);
        
        /// <summary>
        /// Returns the column nr 2
        /// </summary>
        public gvec2<T> Column2 => new gvec2<T>(m20, m21);
        
        /// <summary>
        /// Returns the row nr 0
        /// </summary>
        public gvec3<T> Row0 => new gvec3<T>(m00, m10, m20);
        
        /// <summary>
        /// Returns the row nr 1
        /// </summary>
        public gvec3<T> Row1 => new gvec3<T>(m01, m11, m21);
        
        /// <summary>
        /// Predefined all-zero matrix (DO NOT MODIFY)
        /// </summary>
        public static readonly gmat3x2<T> Zero = new gmat3x2<T>(default(T), default(T), default(T), default(T), default(T), default(T));
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gmat3x2(T m00, T m01, T m10, T m11, T m20, T m21)
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
        public gmat3x2(gmat3x2<T> m)
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
        public gmat3x2(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m20 = c2.x;
            this.m21 = c2.y;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all FieldCount.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
        {
            yield return m00;
            yield return m01;
            yield return m10;
            yield return m11;
            yield return m20;
            yield return m21;
        }
        
        /// <summary>
        /// Returns an enumerator that iterates through all FieldCount.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        
        /// <summary>
        /// Returns the number of FieldCount (6).
        /// </summary>
        public int Count => 6;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public T this[int fieldIndex]
        {
            get
            {
                switch (fieldIndex)
                {
                    case 0: return m00;
                    case 1: return m01;
                    case 2: return m10;
                    case 3: return m11;
                    case 4: return m20;
                    case 5: return m21;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
            set
            {
                switch (fieldIndex)
                {
                    case 0: this.m00 = value; break;
                    case 1: this.m01 = value; break;
                    case 2: this.m10 = value; break;
                    case 3: this.m11 = value; break;
                    case 4: this.m20 = value; break;
                    case 5: this.m21 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public T this[int col, int row]
        {
            get
            {
                return this[col * 2 + row];
            }
            set
            {
                this[col * 2 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(gmat3x2<T> rhs) => EqualityComparer<T>.Default.Equals(m00, rhs.m00) && EqualityComparer<T>.Default.Equals(m01, rhs.m01) && EqualityComparer<T>.Default.Equals(m10, rhs.m10) && EqualityComparer<T>.Default.Equals(m11, rhs.m11) && EqualityComparer<T>.Default.Equals(m20, rhs.m20) && EqualityComparer<T>.Default.Equals(m21, rhs.m21);
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gmat3x2<T> && Equals((gmat3x2<T>) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(gmat3x2<T> lhs, gmat3x2<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(gmat3x2<T> lhs, gmat3x2<T> rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((EqualityComparer<T>.Default.GetHashCode(m00)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m01)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m10)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m11)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m20)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m21);
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public gmat2x3<T> Transposed => new gmat2x3<T>(m00, m10, m20, m01, m11, m21);
    }
}
