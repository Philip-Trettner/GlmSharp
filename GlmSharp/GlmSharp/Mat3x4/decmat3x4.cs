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
    /// A matrix of type decimal with 3 columns and 4 rows.
    /// </summary>
    [Serializable]
    [DataContract(Namespace = "mat")]
    [StructLayout(LayoutKind.Sequential)]
    public struct decmat3x4 : IReadOnlyList<decimal>, IEquatable<decmat3x4>
    {

        #region Fields
        
        /// <summary>
        /// Column 0, Rows 0
        /// </summary>
        [DataMember]
        public decimal m00;
        
        /// <summary>
        /// Column 0, Rows 1
        /// </summary>
        [DataMember]
        public decimal m01;
        
        /// <summary>
        /// Column 0, Rows 2
        /// </summary>
        [DataMember]
        public decimal m02;
        
        /// <summary>
        /// Column 0, Rows 3
        /// </summary>
        [DataMember]
        public decimal m03;
        
        /// <summary>
        /// Column 1, Rows 0
        /// </summary>
        [DataMember]
        public decimal m10;
        
        /// <summary>
        /// Column 1, Rows 1
        /// </summary>
        [DataMember]
        public decimal m11;
        
        /// <summary>
        /// Column 1, Rows 2
        /// </summary>
        [DataMember]
        public decimal m12;
        
        /// <summary>
        /// Column 1, Rows 3
        /// </summary>
        [DataMember]
        public decimal m13;
        
        /// <summary>
        /// Column 2, Rows 0
        /// </summary>
        [DataMember]
        public decimal m20;
        
        /// <summary>
        /// Column 2, Rows 1
        /// </summary>
        [DataMember]
        public decimal m21;
        
        /// <summary>
        /// Column 2, Rows 2
        /// </summary>
        [DataMember]
        public decimal m22;
        
        /// <summary>
        /// Column 2, Rows 3
        /// </summary>
        [DataMember]
        public decimal m23;

        #endregion


        #region Constructors
        
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
        /// Constructs this matrix from a decmat2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decmat2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0m;
            this.m03 = 0m;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0m;
            this.m13 = 0m;
            this.m20 = 0m;
            this.m21 = 0m;
            this.m22 = 1m;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat3x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decmat3x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0m;
            this.m03 = 0m;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0m;
            this.m13 = 0m;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = 1m;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat4x2. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decmat4x2 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = 0m;
            this.m03 = 0m;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = 0m;
            this.m13 = 0m;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = 1m;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat2x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decmat2x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0m;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0m;
            this.m20 = 0m;
            this.m21 = 0m;
            this.m22 = 1m;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decmat3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0m;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0m;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat4x3. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decmat4x3 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = 0m;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = 0m;
            this.m20 = m.m20;
            this.m21 = m.m21;
            this.m22 = m.m22;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat2x4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decmat2x4 m)
        {
            this.m00 = m.m00;
            this.m01 = m.m01;
            this.m02 = m.m02;
            this.m03 = m.m03;
            this.m10 = m.m10;
            this.m11 = m.m11;
            this.m12 = m.m12;
            this.m13 = m.m13;
            this.m20 = 0m;
            this.m21 = 0m;
            this.m22 = 1m;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a decmat3x4. Non-overwritten fields are from an Identity matrix.
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
        /// Constructs this matrix from a decmat4. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decmat4 m)
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
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decvec2 c0, decvec2 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0m;
            this.m03 = 0m;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0m;
            this.m13 = 0m;
            this.m20 = 0m;
            this.m21 = 0m;
            this.m22 = 1m;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decvec2 c0, decvec2 c1, decvec2 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = 0m;
            this.m03 = 0m;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = 0m;
            this.m13 = 0m;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = 1m;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decvec3 c0, decvec3 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0m;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0m;
            this.m20 = 0m;
            this.m21 = 0m;
            this.m22 = 1m;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decvec3 c0, decvec3 c1, decvec3 c2)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = 0m;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = 0m;
            this.m20 = c2.x;
            this.m21 = c2.y;
            this.m22 = c2.z;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
        /// </summary>
        public decmat3x4(decvec4 c0, decvec4 c1)
        {
            this.m00 = c0.x;
            this.m01 = c0.y;
            this.m02 = c0.z;
            this.m03 = c0.w;
            this.m10 = c1.x;
            this.m11 = c1.y;
            this.m12 = c1.z;
            this.m13 = c1.w;
            this.m20 = 0m;
            this.m21 = 0m;
            this.m22 = 1m;
            this.m23 = 0m;
        }
        
        /// <summary>
        /// Constructs this matrix from a series of column vectors. Non-overwritten fields are from an Identity matrix.
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

        #endregion


        #region Properties
        
        /// <summary>
        /// Creates a 2D array with all values (address: Values[x, y])
        /// </summary>
        public decimal[,] Values => new[,] { { m00, m01, m02, m03 }, { m10, m11, m12, m13 }, { m20, m21, m22, m23 } };
        
        /// <summary>
        /// Creates a 1D array with all values (internal order)
        /// </summary>
        public decimal[] Values1D => new[] { m00, m01, m02, m03, m10, m11, m12, m13, m20, m21, m22, m23 };
        
        /// <summary>
        /// Gets or sets the column nr 0
        /// </summary>
        public decvec4 Column0
        {
            get
            {
                return new decvec4(m00, m01, m02, m03);
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
        public decvec4 Column1
        {
            get
            {
                return new decvec4(m10, m11, m12, m13);
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
        /// Gets or sets the column nr 2
        /// </summary>
        public decvec4 Column2
        {
            get
            {
                return new decvec4(m20, m21, m22, m23);
            }
            set
            {
                m20 = value.x;
                m21 = value.y;
                m22 = value.z;
                m23 = value.w;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 0
        /// </summary>
        public decvec3 Row0
        {
            get
            {
                return new decvec3(m00, m10, m20);
            }
            set
            {
                m00 = value.x;
                m10 = value.y;
                m20 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 1
        /// </summary>
        public decvec3 Row1
        {
            get
            {
                return new decvec3(m01, m11, m21);
            }
            set
            {
                m01 = value.x;
                m11 = value.y;
                m21 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 2
        /// </summary>
        public decvec3 Row2
        {
            get
            {
                return new decvec3(m02, m12, m22);
            }
            set
            {
                m02 = value.x;
                m12 = value.y;
                m22 = value.z;
            }
        }
        
        /// <summary>
        /// Gets or sets the row nr 3
        /// </summary>
        public decvec3 Row3
        {
            get
            {
                return new decvec3(m03, m13, m23);
            }
            set
            {
                m03 = value.x;
                m13 = value.y;
                m23 = value.z;
            }
        }

        #endregion


        #region Static Properties
        
        /// <summary>
        /// Predefined all-zero matrix
        /// </summary>
        public static decmat3x4 Zero { get; } = new decmat3x4(0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m, 0m);
        
        /// <summary>
        /// Predefined all-ones matrix
        /// </summary>
        public static decmat3x4 Ones { get; } = new decmat3x4(1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m, 1m);
        
        /// <summary>
        /// Predefined identity matrix
        /// </summary>
        public static decmat3x4 Identity { get; } = new decmat3x4(1m, 0m, 0m, 0m, 0m, 1m, 0m, 0m, 0m, 0m, 1m, 0m);
        
        /// <summary>
        /// Predefined all-MaxValue matrix
        /// </summary>
        public static decmat3x4 AllMaxValue { get; } = new decmat3x4(decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue, decimal.MaxValue);
        
        /// <summary>
        /// Predefined diagonal-MaxValue matrix
        /// </summary>
        public static decmat3x4 DiagonalMaxValue { get; } = new decmat3x4(decimal.MaxValue, 0m, 0m, 0m, 0m, decimal.MaxValue, 0m, 0m, 0m, 0m, decimal.MaxValue, 0m);
        
        /// <summary>
        /// Predefined all-MinValue matrix
        /// </summary>
        public static decmat3x4 AllMinValue { get; } = new decmat3x4(decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue, decimal.MinValue);
        
        /// <summary>
        /// Predefined diagonal-MinValue matrix
        /// </summary>
        public static decmat3x4 DiagonalMinValue { get; } = new decmat3x4(decimal.MinValue, 0m, 0m, 0m, 0m, decimal.MinValue, 0m, 0m, 0m, 0m, decimal.MinValue, 0m);
        
        /// <summary>
        /// Predefined all-MinusOne matrix
        /// </summary>
        public static decmat3x4 AllMinusOne { get; } = new decmat3x4(decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne, decimal.MinusOne);
        
        /// <summary>
        /// Predefined diagonal-MinusOne matrix
        /// </summary>
        public static decmat3x4 DiagonalMinusOne { get; } = new decmat3x4(decimal.MinusOne, 0m, 0m, 0m, 0m, decimal.MinusOne, 0m, 0m, 0m, 0m, decimal.MinusOne, 0m);

        #endregion


        #region Functions
        
        /// <summary>
        /// Returns an enumerator that iterates through all fields.
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
        /// Returns an enumerator that iterates through all fields.
        /// </summary>
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

        #endregion

        
        /// <summary>
        /// Returns the number of Fields (3 x 4 = 12).
        /// </summary>
        public int Count => 12;
        
        /// <summary>
        /// Gets/Sets a specific indexed component (a bit slower than direct access).
        /// </summary>
        public decimal this[int fieldIndex]
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
                    case 8: return m20;
                    case 9: return m21;
                    case 10: return m22;
                    case 11: return m23;
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
                    case 8: this.m20 = value; break;
                    case 9: this.m21 = value; break;
                    case 10: this.m22 = value; break;
                    case 11: this.m23 = value; break;
                    default: throw new ArgumentOutOfRangeException("fieldIndex");
                }
            }
        }
        
        /// <summary>
        /// Gets/Sets a specific 2D-indexed component (a bit slower than direct access).
        /// </summary>
        public decimal this[int col, int row]
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
        public bool Equals(decmat3x4 rhs) => ((((m00.Equals(rhs.m00) && m01.Equals(rhs.m01)) && m02.Equals(rhs.m02)) && ((m03.Equals(rhs.m03) && m10.Equals(rhs.m10)) && m11.Equals(rhs.m11))) && (((m12.Equals(rhs.m12) && m13.Equals(rhs.m13)) && m20.Equals(rhs.m20)) && ((m21.Equals(rhs.m21) && m22.Equals(rhs.m22)) && m23.Equals(rhs.m23))));
        
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
        
        /// <summary>
        /// Returns a transposed version of this matrix.
        /// </summary>
        public decmat4x3 Transposed => new decmat4x3(m00, m10, m20, m01, m11, m21, m02, m12, m22, m03, m13, m23);
        
        /// <summary>
        /// Returns the minimal component of this matrix.
        /// </summary>
        public decimal MinElement => Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(Math.Min(m00, m01), m02), m03), m10), m11), m12), m13), m20), m21), m22), m23);
        
        /// <summary>
        /// Returns the maximal component of this matrix.
        /// </summary>
        public decimal MaxElement => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(m00, m01), m02), m03), m10), m11), m12), m13), m20), m21), m22), m23);
        
        /// <summary>
        /// Returns the euclidean length of this matrix.
        /// </summary>
        public decimal Length => (decimal)(((((m00*m00 + m01*m01) + m02*m02) + ((m03*m03 + m10*m10) + m11*m11)) + (((m12*m12 + m13*m13) + m20*m20) + ((m21*m21 + m22*m22) + m23*m23)))).Sqrt();
        
        /// <summary>
        /// Returns the squared euclidean length of this matrix.
        /// </summary>
        public decimal LengthSqr => ((((m00*m00 + m01*m01) + m02*m02) + ((m03*m03 + m10*m10) + m11*m11)) + (((m12*m12 + m13*m13) + m20*m20) + ((m21*m21 + m22*m22) + m23*m23)));
        
        /// <summary>
        /// Returns the sum of all fields.
        /// </summary>
        public decimal Sum => ((((m00 + m01) + m02) + ((m03 + m10) + m11)) + (((m12 + m13) + m20) + ((m21 + m22) + m23)));
        
        /// <summary>
        /// Returns the euclidean norm of this matrix.
        /// </summary>
        public decimal Norm => (decimal)(((((m00*m00 + m01*m01) + m02*m02) + ((m03*m03 + m10*m10) + m11*m11)) + (((m12*m12 + m13*m13) + m20*m20) + ((m21*m21 + m22*m22) + m23*m23)))).Sqrt();
        
        /// <summary>
        /// Returns the one-norm of this matrix.
        /// </summary>
        public decimal Norm1 => ((((Math.Abs(m00) + Math.Abs(m01)) + Math.Abs(m02)) + ((Math.Abs(m03) + Math.Abs(m10)) + Math.Abs(m11))) + (((Math.Abs(m12) + Math.Abs(m13)) + Math.Abs(m20)) + ((Math.Abs(m21) + Math.Abs(m22)) + Math.Abs(m23))));
        
        /// <summary>
        /// Returns the two-norm of this matrix.
        /// </summary>
        public decimal Norm2 => (decimal)(((((m00*m00 + m01*m01) + m02*m02) + ((m03*m03 + m10*m10) + m11*m11)) + (((m12*m12 + m13*m13) + m20*m20) + ((m21*m21 + m22*m22) + m23*m23)))).Sqrt();
        
        /// <summary>
        /// Returns the max-norm of this matrix.
        /// </summary>
        public decimal NormMax => Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Max(Math.Abs(m00), Math.Abs(m01)), Math.Abs(m02)), Math.Abs(m03)), Math.Abs(m10)), Math.Abs(m11)), Math.Abs(m12)), Math.Abs(m13)), Math.Abs(m20)), Math.Abs(m21)), Math.Abs(m22)), Math.Abs(m23));
        
        /// <summary>
        /// Returns the p-norm of this matrix.
        /// </summary>
        public double NormP(double p) => Math.Pow(((((Math.Pow((double)Math.Abs(m00), p) + Math.Pow((double)Math.Abs(m01), p)) + Math.Pow((double)Math.Abs(m02), p)) + ((Math.Pow((double)Math.Abs(m03), p) + Math.Pow((double)Math.Abs(m10), p)) + Math.Pow((double)Math.Abs(m11), p))) + (((Math.Pow((double)Math.Abs(m12), p) + Math.Pow((double)Math.Abs(m13), p)) + Math.Pow((double)Math.Abs(m20), p)) + ((Math.Pow((double)Math.Abs(m21), p) + Math.Pow((double)Math.Abs(m22), p)) + Math.Pow((double)Math.Abs(m23), p)))), 1 / p);
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication decmat3x4 * decmat2x3 -> decmat2x4.
        /// </summary>
        public static decmat2x4 operator*(decmat3x4 lhs, decmat2x3 rhs) => new decmat2x4(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02), ((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12), ((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication decmat3x4 * decmat3 -> decmat3x4.
        /// </summary>
        public static decmat3x4 operator*(decmat3x4 lhs, decmat3 rhs) => new decmat3x4(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02), ((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12), ((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12), ((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22), ((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22), ((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22), ((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + lhs.m23 * rhs.m22));
        
        /// <summary>
        /// Executes a matrix-matrix-multiplication decmat3x4 * decmat4x3 -> decmat4.
        /// </summary>
        public static decmat4 operator*(decmat3x4 lhs, decmat4x3 rhs) => new decmat4(((lhs.m00 * rhs.m00 + lhs.m10 * rhs.m01) + lhs.m20 * rhs.m02), ((lhs.m01 * rhs.m00 + lhs.m11 * rhs.m01) + lhs.m21 * rhs.m02), ((lhs.m02 * rhs.m00 + lhs.m12 * rhs.m01) + lhs.m22 * rhs.m02), ((lhs.m03 * rhs.m00 + lhs.m13 * rhs.m01) + lhs.m23 * rhs.m02), ((lhs.m00 * rhs.m10 + lhs.m10 * rhs.m11) + lhs.m20 * rhs.m12), ((lhs.m01 * rhs.m10 + lhs.m11 * rhs.m11) + lhs.m21 * rhs.m12), ((lhs.m02 * rhs.m10 + lhs.m12 * rhs.m11) + lhs.m22 * rhs.m12), ((lhs.m03 * rhs.m10 + lhs.m13 * rhs.m11) + lhs.m23 * rhs.m12), ((lhs.m00 * rhs.m20 + lhs.m10 * rhs.m21) + lhs.m20 * rhs.m22), ((lhs.m01 * rhs.m20 + lhs.m11 * rhs.m21) + lhs.m21 * rhs.m22), ((lhs.m02 * rhs.m20 + lhs.m12 * rhs.m21) + lhs.m22 * rhs.m22), ((lhs.m03 * rhs.m20 + lhs.m13 * rhs.m21) + lhs.m23 * rhs.m22), ((lhs.m00 * rhs.m30 + lhs.m10 * rhs.m31) + lhs.m20 * rhs.m32), ((lhs.m01 * rhs.m30 + lhs.m11 * rhs.m31) + lhs.m21 * rhs.m32), ((lhs.m02 * rhs.m30 + lhs.m12 * rhs.m31) + lhs.m22 * rhs.m32), ((lhs.m03 * rhs.m30 + lhs.m13 * rhs.m31) + lhs.m23 * rhs.m32));
        
        /// <summary>
        /// Executes a matrix-vector-multiplication.
        /// </summary>
        public static decvec4 operator*(decmat3x4 m, decvec3 v) => new decvec4(((m.m00 * v.x + m.m10 * v.y) + m.m20 * v.z), ((m.m01 * v.x + m.m11 * v.y) + m.m21 * v.z), ((m.m02 * v.x + m.m12 * v.y) + m.m22 * v.z), ((m.m03 * v.x + m.m13 * v.y) + m.m23 * v.z));
        
        /// <summary>
        /// Executes a component-wise * (multiply).
        /// </summary>
        public static decmat3x4 CompMul(decmat3x4 A, decmat3x4 B) => new decmat3x4(A.m00 * B.m00, A.m01 * B.m01, A.m02 * B.m02, A.m03 * B.m03, A.m10 * B.m10, A.m11 * B.m11, A.m12 * B.m12, A.m13 * B.m13, A.m20 * B.m20, A.m21 * B.m21, A.m22 * B.m22, A.m23 * B.m23);
        
        /// <summary>
        /// Executes a component-wise / (divide).
        /// </summary>
        public static decmat3x4 CompDiv(decmat3x4 A, decmat3x4 B) => new decmat3x4(A.m00 / B.m00, A.m01 / B.m01, A.m02 / B.m02, A.m03 / B.m03, A.m10 / B.m10, A.m11 / B.m11, A.m12 / B.m12, A.m13 / B.m13, A.m20 / B.m20, A.m21 / B.m21, A.m22 / B.m22, A.m23 / B.m23);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static decmat3x4 CompAdd(decmat3x4 A, decmat3x4 B) => new decmat3x4(A.m00 + B.m00, A.m01 + B.m01, A.m02 + B.m02, A.m03 + B.m03, A.m10 + B.m10, A.m11 + B.m11, A.m12 + B.m12, A.m13 + B.m13, A.m20 + B.m20, A.m21 + B.m21, A.m22 + B.m22, A.m23 + B.m23);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static decmat3x4 CompSub(decmat3x4 A, decmat3x4 B) => new decmat3x4(A.m00 - B.m00, A.m01 - B.m01, A.m02 - B.m02, A.m03 - B.m03, A.m10 - B.m10, A.m11 - B.m11, A.m12 - B.m12, A.m13 - B.m13, A.m20 - B.m20, A.m21 - B.m21, A.m22 - B.m22, A.m23 - B.m23);
        
        /// <summary>
        /// Executes a component-wise + (add).
        /// </summary>
        public static decmat3x4 operator+(decmat3x4 lhs, decmat3x4 rhs) => new decmat3x4(lhs.m00 + rhs.m00, lhs.m01 + rhs.m01, lhs.m02 + rhs.m02, lhs.m03 + rhs.m03, lhs.m10 + rhs.m10, lhs.m11 + rhs.m11, lhs.m12 + rhs.m12, lhs.m13 + rhs.m13, lhs.m20 + rhs.m20, lhs.m21 + rhs.m21, lhs.m22 + rhs.m22, lhs.m23 + rhs.m23);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static decmat3x4 operator+(decmat3x4 lhs, decimal rhs) => new decmat3x4(lhs.m00 + rhs, lhs.m01 + rhs, lhs.m02 + rhs, lhs.m03 + rhs, lhs.m10 + rhs, lhs.m11 + rhs, lhs.m12 + rhs, lhs.m13 + rhs, lhs.m20 + rhs, lhs.m21 + rhs, lhs.m22 + rhs, lhs.m23 + rhs);
        
        /// <summary>
        /// Executes a component-wise + (add) with a scalar.
        /// </summary>
        public static decmat3x4 operator+(decimal lhs, decmat3x4 rhs) => new decmat3x4(lhs + rhs.m00, lhs + rhs.m01, lhs + rhs.m02, lhs + rhs.m03, lhs + rhs.m10, lhs + rhs.m11, lhs + rhs.m12, lhs + rhs.m13, lhs + rhs.m20, lhs + rhs.m21, lhs + rhs.m22, lhs + rhs.m23);
        
        /// <summary>
        /// Executes a component-wise - (subtract).
        /// </summary>
        public static decmat3x4 operator-(decmat3x4 lhs, decmat3x4 rhs) => new decmat3x4(lhs.m00 - rhs.m00, lhs.m01 - rhs.m01, lhs.m02 - rhs.m02, lhs.m03 - rhs.m03, lhs.m10 - rhs.m10, lhs.m11 - rhs.m11, lhs.m12 - rhs.m12, lhs.m13 - rhs.m13, lhs.m20 - rhs.m20, lhs.m21 - rhs.m21, lhs.m22 - rhs.m22, lhs.m23 - rhs.m23);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static decmat3x4 operator-(decmat3x4 lhs, decimal rhs) => new decmat3x4(lhs.m00 - rhs, lhs.m01 - rhs, lhs.m02 - rhs, lhs.m03 - rhs, lhs.m10 - rhs, lhs.m11 - rhs, lhs.m12 - rhs, lhs.m13 - rhs, lhs.m20 - rhs, lhs.m21 - rhs, lhs.m22 - rhs, lhs.m23 - rhs);
        
        /// <summary>
        /// Executes a component-wise - (subtract) with a scalar.
        /// </summary>
        public static decmat3x4 operator-(decimal lhs, decmat3x4 rhs) => new decmat3x4(lhs - rhs.m00, lhs - rhs.m01, lhs - rhs.m02, lhs - rhs.m03, lhs - rhs.m10, lhs - rhs.m11, lhs - rhs.m12, lhs - rhs.m13, lhs - rhs.m20, lhs - rhs.m21, lhs - rhs.m22, lhs - rhs.m23);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static decmat3x4 operator/(decmat3x4 lhs, decimal rhs) => new decmat3x4(lhs.m00 / rhs, lhs.m01 / rhs, lhs.m02 / rhs, lhs.m03 / rhs, lhs.m10 / rhs, lhs.m11 / rhs, lhs.m12 / rhs, lhs.m13 / rhs, lhs.m20 / rhs, lhs.m21 / rhs, lhs.m22 / rhs, lhs.m23 / rhs);
        
        /// <summary>
        /// Executes a component-wise / (divide) with a scalar.
        /// </summary>
        public static decmat3x4 operator/(decimal lhs, decmat3x4 rhs) => new decmat3x4(lhs / rhs.m00, lhs / rhs.m01, lhs / rhs.m02, lhs / rhs.m03, lhs / rhs.m10, lhs / rhs.m11, lhs / rhs.m12, lhs / rhs.m13, lhs / rhs.m20, lhs / rhs.m21, lhs / rhs.m22, lhs / rhs.m23);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static decmat3x4 operator*(decmat3x4 lhs, decimal rhs) => new decmat3x4(lhs.m00 * rhs, lhs.m01 * rhs, lhs.m02 * rhs, lhs.m03 * rhs, lhs.m10 * rhs, lhs.m11 * rhs, lhs.m12 * rhs, lhs.m13 * rhs, lhs.m20 * rhs, lhs.m21 * rhs, lhs.m22 * rhs, lhs.m23 * rhs);
        
        /// <summary>
        /// Executes a component-wise * (multiply) with a scalar.
        /// </summary>
        public static decmat3x4 operator*(decimal lhs, decmat3x4 rhs) => new decmat3x4(lhs * rhs.m00, lhs * rhs.m01, lhs * rhs.m02, lhs * rhs.m03, lhs * rhs.m10, lhs * rhs.m11, lhs * rhs.m12, lhs * rhs.m13, lhs * rhs.m20, lhs * rhs.m21, lhs * rhs.m22, lhs * rhs.m23);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison.
        /// </summary>
        public static bmat3x4 operator<(decmat3x4 lhs, decmat3x4 rhs) => new bmat3x4(lhs.m00 < rhs.m00, lhs.m01 < rhs.m01, lhs.m02 < rhs.m02, lhs.m03 < rhs.m03, lhs.m10 < rhs.m10, lhs.m11 < rhs.m11, lhs.m12 < rhs.m12, lhs.m13 < rhs.m13, lhs.m20 < rhs.m20, lhs.m21 < rhs.m21, lhs.m22 < rhs.m22, lhs.m23 < rhs.m23);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat3x4 operator<(decmat3x4 lhs, decimal rhs) => new bmat3x4(lhs.m00 < rhs, lhs.m01 < rhs, lhs.m02 < rhs, lhs.m03 < rhs, lhs.m10 < rhs, lhs.m11 < rhs, lhs.m12 < rhs, lhs.m13 < rhs, lhs.m20 < rhs, lhs.m21 < rhs, lhs.m22 < rhs, lhs.m23 < rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-than comparison with a scalar.
        /// </summary>
        public static bmat3x4 operator<(decimal lhs, decmat3x4 rhs) => new bmat3x4(lhs < rhs.m00, lhs < rhs.m01, lhs < rhs.m02, lhs < rhs.m03, lhs < rhs.m10, lhs < rhs.m11, lhs < rhs.m12, lhs < rhs.m13, lhs < rhs.m20, lhs < rhs.m21, lhs < rhs.m22, lhs < rhs.m23);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison.
        /// </summary>
        public static bmat3x4 operator<=(decmat3x4 lhs, decmat3x4 rhs) => new bmat3x4(lhs.m00 <= rhs.m00, lhs.m01 <= rhs.m01, lhs.m02 <= rhs.m02, lhs.m03 <= rhs.m03, lhs.m10 <= rhs.m10, lhs.m11 <= rhs.m11, lhs.m12 <= rhs.m12, lhs.m13 <= rhs.m13, lhs.m20 <= rhs.m20, lhs.m21 <= rhs.m21, lhs.m22 <= rhs.m22, lhs.m23 <= rhs.m23);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat3x4 operator<=(decmat3x4 lhs, decimal rhs) => new bmat3x4(lhs.m00 <= rhs, lhs.m01 <= rhs, lhs.m02 <= rhs, lhs.m03 <= rhs, lhs.m10 <= rhs, lhs.m11 <= rhs, lhs.m12 <= rhs, lhs.m13 <= rhs, lhs.m20 <= rhs, lhs.m21 <= rhs, lhs.m22 <= rhs, lhs.m23 <= rhs);
        
        /// <summary>
        /// Executes a component-wise lesser-or-equal comparison with a scalar.
        /// </summary>
        public static bmat3x4 operator<=(decimal lhs, decmat3x4 rhs) => new bmat3x4(lhs <= rhs.m00, lhs <= rhs.m01, lhs <= rhs.m02, lhs <= rhs.m03, lhs <= rhs.m10, lhs <= rhs.m11, lhs <= rhs.m12, lhs <= rhs.m13, lhs <= rhs.m20, lhs <= rhs.m21, lhs <= rhs.m22, lhs <= rhs.m23);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison.
        /// </summary>
        public static bmat3x4 operator>(decmat3x4 lhs, decmat3x4 rhs) => new bmat3x4(lhs.m00 > rhs.m00, lhs.m01 > rhs.m01, lhs.m02 > rhs.m02, lhs.m03 > rhs.m03, lhs.m10 > rhs.m10, lhs.m11 > rhs.m11, lhs.m12 > rhs.m12, lhs.m13 > rhs.m13, lhs.m20 > rhs.m20, lhs.m21 > rhs.m21, lhs.m22 > rhs.m22, lhs.m23 > rhs.m23);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat3x4 operator>(decmat3x4 lhs, decimal rhs) => new bmat3x4(lhs.m00 > rhs, lhs.m01 > rhs, lhs.m02 > rhs, lhs.m03 > rhs, lhs.m10 > rhs, lhs.m11 > rhs, lhs.m12 > rhs, lhs.m13 > rhs, lhs.m20 > rhs, lhs.m21 > rhs, lhs.m22 > rhs, lhs.m23 > rhs);
        
        /// <summary>
        /// Executes a component-wise greater-than comparison with a scalar.
        /// </summary>
        public static bmat3x4 operator>(decimal lhs, decmat3x4 rhs) => new bmat3x4(lhs > rhs.m00, lhs > rhs.m01, lhs > rhs.m02, lhs > rhs.m03, lhs > rhs.m10, lhs > rhs.m11, lhs > rhs.m12, lhs > rhs.m13, lhs > rhs.m20, lhs > rhs.m21, lhs > rhs.m22, lhs > rhs.m23);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison.
        /// </summary>
        public static bmat3x4 operator>=(decmat3x4 lhs, decmat3x4 rhs) => new bmat3x4(lhs.m00 >= rhs.m00, lhs.m01 >= rhs.m01, lhs.m02 >= rhs.m02, lhs.m03 >= rhs.m03, lhs.m10 >= rhs.m10, lhs.m11 >= rhs.m11, lhs.m12 >= rhs.m12, lhs.m13 >= rhs.m13, lhs.m20 >= rhs.m20, lhs.m21 >= rhs.m21, lhs.m22 >= rhs.m22, lhs.m23 >= rhs.m23);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat3x4 operator>=(decmat3x4 lhs, decimal rhs) => new bmat3x4(lhs.m00 >= rhs, lhs.m01 >= rhs, lhs.m02 >= rhs, lhs.m03 >= rhs, lhs.m10 >= rhs, lhs.m11 >= rhs, lhs.m12 >= rhs, lhs.m13 >= rhs, lhs.m20 >= rhs, lhs.m21 >= rhs, lhs.m22 >= rhs, lhs.m23 >= rhs);
        
        /// <summary>
        /// Executes a component-wise greater-or-equal comparison with a scalar.
        /// </summary>
        public static bmat3x4 operator>=(decimal lhs, decmat3x4 rhs) => new bmat3x4(lhs >= rhs.m00, lhs >= rhs.m01, lhs >= rhs.m02, lhs >= rhs.m03, lhs >= rhs.m10, lhs >= rhs.m11, lhs >= rhs.m12, lhs >= rhs.m13, lhs >= rhs.m20, lhs >= rhs.m21, lhs >= rhs.m22, lhs >= rhs.m23);
    }
}
