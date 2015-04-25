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
    /// A matrix of type T with 2 columns and 4 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct gmat2x4<T> : IReadOnlyList<T>, IEquatable<gmat2x4<T>>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public T m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public T m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public T m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        [DataMember]
        public T m03;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public T m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public T m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public T m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        [DataMember]
        public T m13;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gmat2x4(T m00, T m01, T m02, T m03, T m10, T m11, T m12, T m13)
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
        /// Constructs this matrix from a gmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gmat2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m13 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gmat3x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m13 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gmat4x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m13 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gmat2x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gmat3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gmat4x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gmat2x4<T> m)
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
        /// Constructs this matrix from a gmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gmat3x4<T> m)
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
        /// Constructs this matrix from a gmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gmat4<T> m)
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
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gvec2<T> c0, gvec2<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = default(T);
            this.m03 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = default(T);
            this.m13 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gvec3<T> c0, gvec3<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat2x4(gvec4<T> c0, gvec4<T> c1)
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

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public T[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public T[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public gvec4<T> Column0
        {
            get
            {
                return new gvec4<T>(m00, m01, m02, m03);
            }
            set
            {
                m00 = value.x;
                m01 = value.y;
                m02 = value.z;
                m03 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 1
        /// </summary>
        public gvec4<T> Column1
        {
            get
            {
                return new gvec4<T>(m10, m11, m12, m13);
            }
            set
            {
                m10 = value.x;
                m11 = value.y;
                m12 = value.z;
                m13 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public gvec2<T> Row0
        {
            get
            {
                return new gvec2<T>(m00, m10);
            }
            set
            {
                m00 = value.x;
                m10 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 1
        /// </summary>
        public gvec2<T> Row1
        {
            get
            {
                return new gvec2<T>(m01, m11);
            }
            set
            {
                m01 = value.x;
                m11 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 2
        /// </summary>
        public gvec2<T> Row2
        {
            get
            {
                return new gvec2<T>(m02, m12);
            }
            set
            {
                m02 = value.x;
                m12 = value.y;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 3
        /// </summary>
        public gvec2<T> Row3
        {
            get
            {
                return new gvec2<T>(m03, m13);
            }
            set
            {
                m03 = value.x;
                m13 = value.y;
            }
        }

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static gmat2x4<T> Zero { get; } = new gmat2x4<T>(default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T));

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        public IEnumerator<T> GetEnumerator()
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
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (2 x 4 = 8).
        /// </summary>
        public int Count => 8;
        
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
        public T this[int col, int row]
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
        public bool Equals(gmat2x4<T> rhs) => (((EqualityComparer<T>.Default.Equals(m00, rhs.m00) && EqualityComparer<T>.Default.Equals(m01, rhs.m01)) && (EqualityComparer<T>.Default.Equals(m02, rhs.m02) && EqualityComparer<T>.Default.Equals(m03, rhs.m03))) && ((EqualityComparer<T>.Default.Equals(m10, rhs.m10) && EqualityComparer<T>.Default.Equals(m11, rhs.m11)) && (EqualityComparer<T>.Default.Equals(m12, rhs.m12) && EqualityComparer<T>.Default.Equals(m13, rhs.m13))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gmat2x4<T> && Equals((gmat2x4<T>) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(gmat2x4<T> lhs, gmat2x4<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(gmat2x4<T> lhs, gmat2x4<T> rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((EqualityComparer<T>.Default.GetHashCode(m00)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m01)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m02)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m03)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m10)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m11)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m12)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m13);
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public gmat4x2<T> Transposed => new gmat4x2<T>(m00, m10, m01, m11, m02, m12, m03, m13);
    }
}
