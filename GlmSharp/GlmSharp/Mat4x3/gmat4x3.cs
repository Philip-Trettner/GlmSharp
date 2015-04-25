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
    /// A matrix of type T with 4 columns and 3 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct gmat4x3<T> : IReadOnlyList<T>, IEquatable<gmat4x3<T>>
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
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public T m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public T m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        [DataMember]
        public T m22;
        
        /// <summary>
        /// Column 3, Rows 0
        /// </summary>
        [DataMember]
        public T m30;
        
        /// <summary>
        /// Column 3, Rows 1
        /// </summary>
        [DataMember]
        public T m31;
        
        /// <summary>
        /// Column 3, Rows 2
        /// </summary>
        [DataMember]
        public T m32;

        #endregion


        #region Constructors
        
        /// <summary>
        /// Component-wise constructor
        /// </summary>
        public gmat4x3(T m00, T m01, T m02, T m10, T m11, T m12, T m20, T m21, T m22, T m30, T m31, T m32)
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
        /// Constructs this matrix from a gmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gmat2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gmat3x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gmat4x2<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = default(T);
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = default(T);
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = default(T);
            this.m30 = m.m30;
            this.m31 = m.m31;
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gmat2x3<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gmat3<T> m)
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
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gmat4x3<T> m)
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
        /// Constructs this matrix from a gmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gmat2x4<T> m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat3x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gmat3x4<T> m)
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
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a gmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gmat4<T> m)
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
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gvec2<T> c0, gvec2<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = default(T);
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gvec2<T> c0, gvec2<T> c1, gvec2<T> c2, gvec2<T> c3)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = default(T);
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = default(T);
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = default(T);
            this.m30 = c3.x;
            this.m31 = c3.y;
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gvec3<T> c0, gvec3<T> c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m20 = default(T);
            this.m21 = default(T);
            this.m22 = default(T);
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gvec3<T> c0, gvec3<T> c1, gvec3<T> c2)
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
            this.m30 = default(T);
            this.m31 = default(T);
            this.m32 = default(T);
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public gmat4x3(gvec3<T> c0, gvec3<T> c1, gvec3<T> c2, gvec3<T> c3)
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

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public T[,] Values => new[,] { { m00, m01, m02 }, { m10, m11, m12 }, { m20, m21, m22 }, { m30, m31, m32 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public T[] Values1D => new[] { m00, m01, m02, m10, m11, m12, m20, m21, m22, m30, m31, m32 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public gvec3<T> Column0
        {
            get
            {
                return new gvec3<T>(m00, m01, m02);
            }
            set
            {
                m00 = value.x;
                m01 = value.y;
                m02 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 1
        /// </summary>
        public gvec3<T> Column1
        {
            get
            {
                return new gvec3<T>(m10, m11, m12);
            }
            set
            {
                m10 = value.x;
                m11 = value.y;
                m12 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 2
        /// </summary>
        public gvec3<T> Column2
        {
            get
            {
                return new gvec3<T>(m20, m21, m22);
            }
            set
            {
                m20 = value.x;
                m21 = value.y;
                m22 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the column nr 3
        /// </summary>
        public gvec3<T> Column3
        {
            get
            {
                return new gvec3<T>(m30, m31, m32);
            }
            set
            {
                m30 = value.x;
                m31 = value.y;
                m32 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public gvec4<T> Row0
        {
            get
            {
                return new gvec4<T>(m00, m10, m20, m30);
            }
            set
            {
                m00 = value.x;
                m10 = value.y;
                m20 = value.z;
                m30 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 1
        /// </summary>
        public gvec4<T> Row1
        {
            get
            {
                return new gvec4<T>(m01, m11, m21, m31);
            }
            set
            {
                m01 = value.x;
                m11 = value.y;
                m21 = value.z;
                m31 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 2
        /// </summary>
        public gvec4<T> Row2
        {
            get
            {
                return new gvec4<T>(m02, m12, m22, m32);
            }
            set
            {
                m02 = value.x;
                m12 = value.y;
                m22 = value.z;
                m32 = value.w;
            }
        }

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static gmat4x3<T> Zero { get; } = new gmat4x3<T>(default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T), default(T));

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
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (4 x 3 = 12).
        /// </summary>
        public int Count => 12;
        
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
                    case 3: return m10;
                    case 4: return m11;
                    case 5: return m12;
                    case 6: return m20;
                    case 7: return m21;
                    case 8: return m22;
                    case 9: return m30;
                    case 10: return m31;
                    case 11: return m32;
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
                    case 3: this.m10 = value; break;
                    case 4: this.m11 = value; break;
                    case 5: this.m12 = value; break;
                    case 6: this.m20 = value; break;
                    case 7: this.m21 = value; break;
                    case 8: this.m22 = value; break;
                    case 9: this.m30 = value; break;
                    case 10: this.m31 = value; break;
                    case 11: this.m32 = value; break;
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
                return this[col * 3 + row];
            }
            set
            {
                this[col * 3 + row] = value;
            }
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public bool Equals(gmat4x3<T> rhs) => ((((EqualityComparer<T>.Default.Equals(m00, rhs.m00) && EqualityComparer<T>.Default.Equals(m01, rhs.m01)) && EqualityComparer<T>.Default.Equals(m02, rhs.m02)) && ((EqualityComparer<T>.Default.Equals(m10, rhs.m10) && EqualityComparer<T>.Default.Equals(m11, rhs.m11)) && EqualityComparer<T>.Default.Equals(m12, rhs.m12))) && (((EqualityComparer<T>.Default.Equals(m20, rhs.m20) && EqualityComparer<T>.Default.Equals(m21, rhs.m21)) && EqualityComparer<T>.Default.Equals(m22, rhs.m22)) && ((EqualityComparer<T>.Default.Equals(m30, rhs.m30) && EqualityComparer<T>.Default.Equals(m31, rhs.m31)) && EqualityComparer<T>.Default.Equals(m32, rhs.m32))));
        
        /// <summary>
        /// Returns true iff this equals rhs type- and component-wise.
        /// </summary>
        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            return obj is gmat4x3<T> && Equals((gmat4x3<T>) obj);
        }
        
        /// <summary>
        /// Returns true iff this equals rhs component-wise.
        /// </summary>
        public static bool operator ==(gmat4x3<T> lhs, gmat4x3<T> rhs) => lhs.Equals(rhs);
        
        /// <summary>
        /// Returns true iff this does not equal rhs (component-wise).
        /// </summary>
        public static bool operator !=(gmat4x3<T> lhs, gmat4x3<T> rhs) => !lhs.Equals(rhs);
        
        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        public override int GetHashCode()
        {
            unchecked
            {
                return ((((((((((((((((((((((EqualityComparer<T>.Default.GetHashCode(m00)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m01)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m02)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m10)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m11)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m12)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m20)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m21)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m22)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m30)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m31)) * 397) ^ EqualityComparer<T>.Default.GetHashCode(m32);
            }
        }
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public gmat3x4<T> Transposed => new gmat3x4<T>(m00, m10, m20, m30, m01, m11, m21, m31, m02, m12, m22, m32);
    }
}
